'  
'   Rebex Sample Code License
' 
'   Copyright (c) 2009, Rebex CR s.r.o. www.rebex.net, 
'   All rights reserved.
' 
'   Permission to use, copy, modify, and/or distribute this software for any
'   purpose with or without fee is hereby granted
' 
'   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
'   EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
'   OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
'   NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
'   HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
'   WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
'   FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
'   OTHER DEALINGS IN THE SOFTWARE.
' 

Imports System
Imports System.Collections
Imports System.Xml
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

''' <summary>
''' Class for easier access to configuration values.
''' </summary>
Public Class Configuration

    ''' <summary>
    ''' Gets a Boolean value from configuration.
    ''' </summary>
    ''' <param name="key">The key.</param>
    ''' <param name="defaultValue">The default value.</param>
    ''' <returns>A Boolean value from configuration.</returns>
    Public Overloads Function GetBoolean(ByVal key As String, ByVal defaultValue As Boolean) As Boolean
        Try
            Dim val As String = GetString(key)
            If val Is Nothing Then
                Return defaultValue
            End If
            Return Convert.ToBoolean(val)
        Catch
            Return defaultValue
        End Try
    End Function 'GetBoolean

    ''' <summary>
    ''' Gets an Int32 value from configuration.
    ''' </summary>
    ''' <param name="key">The key.</param>
    ''' <param name="defaultValue">The default value.</param>
    ''' <returns>An Int32 value from configuration.</returns>
    Public Overloads Function GetInt32(ByVal key As String, ByVal defaultValue As Integer) As Integer
        Try
            Dim val As String = GetString(key)
            If val Is Nothing Then
                Return defaultValue
            End If
            Return Convert.ToInt32(val)
        Catch
            Return defaultValue
        End Try
    End Function 'GetInt32


    ''' <summary>
    ''' Gets an Int32 value from configuration.
    ''' </summary>
    ''' <param name="key">The key.</param>
    ''' <returns>An Int32 value from configuration.</returns>
    Public Overloads Function GetInt32(ByVal key As String) As Integer
        Return CInt(GetValue(key, GetType(Integer)))
    End Function 'GetInt32

    ''' <summary>
    ''' Gets a string value from the configuration.
    ''' </summary>
    ''' <param name="key">The key.</param>
    ''' <param name="defaultValue">The default value.</param>
    ''' <returns>A string value from the configuration.</returns>
    Public Function GetString(ByVal key As String, ByVal defaultValue As String) As String
        Dim o As Object = GetValue(key, GetType(String))

        If o Is Nothing Then
            Return Nothing
        Else
            Return o.ToString()
        End If
    End Function 'GetString

    ''' <summary>
    ''' Gets a string value from the configuration.
    ''' </summary>
    ''' <param name="key">The key.</param>
    ''' <returns>A string value from the configuration.</returns>
    Public Function GetString(ByVal key As String) As String
        Return GetString(key, Nothing)
    End Function 'GetString

    ''' <summary>
    ''' Gets an object value from the configuration.
    ''' </summary>
    ''' <param name="key">The key.</param>
    ''' <param name="type">The type.</param>
    ''' <returns>An object value from the configuration.</returns>
    Public Function GetValue(ByVal key As String, ByVal type As Type) As Object
        If key Is Nothing Then
            Throw New ArgumentNullException
        End If

        If _table Is Nothing Then
            Load()
        End If

        If type.IsEnum Then
            If _table(key) Is Nothing Then Return System.Enum.Parse(type, "0")
            Return System.Enum.Parse(type, _table(key).ToString(), True)
        End If

        If _table(key) Is Nothing Then
            Return Nothing
        End If

        If IsSerializable(type) Then
            Dim value As String = _table(key).ToString()
            Dim stream As New MemoryStream(Convert.FromBase64String(value))

            Try
                Return Formatter.Deserialize(stream)
            Catch
                Return Nothing
            Finally
                stream.Close()
            End Try
        Else
            Return Convert.ChangeType(_table(key), type)
        End If
    End Function    'GetValue


    ''' <summary>
    ''' Sets a configuration value.
    ''' </summary>
    ''' <param name="key">The key.</param>
    ''' <param name="val">The value.</param>
    Public Sub SetValue(ByVal key As String, ByVal val As Object)
        If key Is Nothing Then
            Throw New ArgumentNullException
        End If

        If _table Is Nothing Then
            Load()
        End If

        If (Not val Is Nothing) AndAlso (val.GetType().IsEnum) Then
            val = Convert.ChangeType(val, System.Enum.GetUnderlyingType(val.GetType()))
        End If

        If _table.ContainsKey(key) Then
            _table(key) = val
        Else
            _table.Add(key, val)
        End If
    End Sub 'SetValue

    ''' <summary>
    ''' Initializes a new instance of the <see cref="Configuration"/> class.
    ''' </summary>
    ''' <param name="filename">The filename where configuration is stored.</param>
    Public Sub New(ByVal filename As String)
        _filename = filename
    End Sub 'New


    ''' <summary>
    ''' Saves the configuration values to file.
    ''' </summary>
    Public Sub Save()
        If _table Is Nothing Then
            Load()
        End If
        Dim xml As New XmlDocument
        Dim config As XmlElement = xml.CreateElement("configuration")
        xml.AppendChild(config)

        If _table.Count = 0 Then
            Return
        End If
        Dim e As IDictionaryEnumerator = _table.GetEnumerator()

        While e.MoveNext()
            Dim key As XmlElement = xml.CreateElement("key")
            config.AppendChild(key)
            Dim atrName As XmlAttribute = xml.CreateAttribute("name")
            atrName.Value = e.Key.ToString()
            Dim atrVal As XmlAttribute = xml.CreateAttribute("value")
            atrVal.Value = ValueToString(e.Value)
            key.Attributes.Append(atrName)
            key.Attributes.Append(atrVal)
        End While

        Dim configPath As String = Path.GetDirectoryName(_filename)
        If Not Directory.Exists(configPath) Then
            Directory.CreateDirectory(configPath)
        End If
        xml.Save(_filename)
    End Sub 'Save

#Region "Private attributes"

    ''' <summary>
    ''' Filename for I/O operations
    ''' </summary>
    Private _filename As String = Nothing

    ''' <summary>
    ''' Hashtable for inmemory config values storage
    ''' </summary>
    Private _table As Hashtable = Nothing

    Private _formatter As BinaryFormatter = Nothing
    Private ReadOnly Property Formatter() As BinaryFormatter
        Get
            If _formatter Is Nothing Then
                _formatter = New BinaryFormatter
            End If
            Return _formatter
        End Get
    End Property

#End Region

#Region " Private methods"

    ''' <summary>
    ''' Gets a value indicationg whether the type is serializable or not.
    ''' </summary>
    ''' <param name="type">System.Type object.</param>
    ''' <returns></returns>
    Private Function IsSerializable(ByVal type As Type) As Boolean
        ' strings and value types are consider as not serializable for this purpose
        Return Not type.IsValueType AndAlso type.FullName <> GetType(String).FullName AndAlso (type.Attributes And System.Reflection.TypeAttributes.Serializable) > 0
    End Function

    ''' <summary>
    ''' Gets a string representation of the value.
    ''' </summary>
    ''' <remarks>If value is serializable object, it returns Base64 string.</remarks>
    ''' <param name="value">Value to be represent as a string.</param>
    ''' <returns></returns>
    Private Function ValueToString(ByVal value As Object) As String
        If IsSerializable(value.[GetType]()) Then
            Dim stream As New MemoryStream
            Try
                Formatter.Serialize(stream, value)
                Return Convert.ToBase64String(stream.GetBuffer(), 0, CInt(stream.Length))
            Finally
                stream.Close()
            End Try
        End If

        Return value.ToString()
    End Function

    ''' <summary>
    ''' Loads the configuration from the file.
    ''' </summary>
    Private Sub Load()
        Dim xml As New XmlDocument

        If _table Is Nothing Then
            _table = New Hashtable
        End If
        If Not File.Exists(_filename) Then
            Return
        End If
        If Not (_table Is Nothing) Then
            _table.Clear()
        End If
        xml.Load(_filename)

        Dim config As XmlElement = xml("configuration")

        Dim key As XmlNode
        For Each key In config.ChildNodes
            Dim item As String = Nothing
            Dim name As String = Nothing

            If Not (key.Attributes("value") Is Nothing) Then
                item = key.Attributes("value").Value
            End If
            If Not (key.Attributes("name") Is Nothing) Then
                name = key.Attributes("name").Value
            End If
            If Not (key("value") Is Nothing) Then
                item = key("value").InnerText
            End If
            If Not (key("name") Is Nothing) Then
                name = key("name").InnerText
            End If
            If name Is Nothing Then
                GoTo ContinueForEach1
            End If
            If item Is Nothing Then
                item = ""
            End If
            _table.Add(name, item)
ContinueForEach1:
        Next key
    End Sub 'Load
#End Region
End Class 'Configuration

