﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.239
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WinImpExp.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property alarm() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("alarm", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SET ANSI_NULLS ON
        '''SET QUOTED_IDENTIFIER ON
        '''SET ANSI_PADDING ON
        '''CREATE TABLE [dbo].[Type](
        '''	[Type_Code] [char](1) NOT NULL,
        '''	[Type] [char](25) NOT NULL,
        ''' CONSTRAINT [PK_Type1] PRIMARY KEY CLUSTERED 
        '''(
        '''	[Type_Code] ASC
        ''')WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
        ''') ON [PRIMARY]
        '''SET ANSI_PADDING OFF
        '''INSERT [dbo].[Type] ([Type_Code], [Type]) VALUES (N&apos;1&apos;, N&apos;كتاب                     &apos;)
        '''INSERT [dbo].[Type] ([ [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property CreateTableRes() As String
            Get
                Return ResourceManager.GetString("CreateTableRes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SET ANSI_NULLS ON
        '''SET QUOTED_IDENTIFIER ON
        '''SET ANSI_PADDING ON
        '''CREATE TABLE [dbo].[to_assigned](
        '''	[owner_Org_No] [char](4) NULL,
        '''	[Subject] [varchar](250) NULL,
        '''	[SendToSignedDate] [datetime] NULL,
        '''	[userName] [varchar](10) NULL
        ''') ON [PRIMARY]
        '''SET ANSI_PADDING OFF
        '''SET ANSI_NULLS ON
        '''
        '''SET QUOTED_IDENTIFIER ON
        '''
        '''SET ANSI_PADDING ON
        '''
        '''CREATE TABLE [dbo].[orgshort](
        '''	[firstcode] [char](6) NULL,
        '''	[code] [char](4) NULL
        ''') ON [PRIMARY]
        '''
        '''SET ANSI_PADDING OFF
        '''
        '''/****** Object:  Table [dbo].[Org_Use [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property CreateTableResNoData() As String
            Get
                Return ResourceManager.GetString("CreateTableResNoData", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property ding() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("ding", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property nic() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nic", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0000() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0000", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0001() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0001", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0002() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0002", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0003() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0003", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0004() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0004", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0005() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0005", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0006() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0006", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0007() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0007", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0008() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0008", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0009() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0009", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0010() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0010", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0011() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0011", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0012() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0012", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0013() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0013", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0014() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0014", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0015() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0015", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0016() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0016", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0017() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0017", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0018() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0018", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0019() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0019", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0020() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0020", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0021() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0021", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0022() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0022", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0023() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0023", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0024() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0024", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0025() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0025", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0026() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0026", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0027() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0027", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0028() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0028", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0029() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0029", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0030() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0030", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property SplashScreenPSD0031() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SplashScreenPSD0031", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property Windows_Notify() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Windows_Notify", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
