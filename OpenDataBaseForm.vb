Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class OpenDataBaseForm

    Private Shared SharedData As New SharedObject()
    Protected Overridable Sub StartMarqueeThread()
        Try
            Dim t As New Thread(AddressOf ShowMarqueeForm)
            t.Start()
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Sub
    Protected Overridable Sub ShowMarqueeForm()
        Try
            Dim frm As New LoadingFrm()
            'frm.NewWidth = Me.Width / 2 - 45
            'frm.NewHeight = Me.Height / 2 + 120
            frm.Show()
            frm.Update()
            Do
                SyncLock SharedData
                    If SharedData.ReadyToHideMarquee Then
                        Exit Do
                    End If
                End SyncLock
                Application.DoEvents()
            Loop
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Sub
    Private Class SharedObject
        Public ReadyToHideMarquee As Boolean
    End Class





    Public CancelF As Boolean
    Dim databaseNames As New List(Of String)



    Private Function GetSqlServers(ByVal shouldSortList As Boolean) As List(Of String)
        Dim listOfServers As New List(Of String)()

        Try
            'create the list that would hold our servers 


            'create a new instance of our SqlDataSourceEnumerator 
            Dim sqlEnumerator As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance

            'get the datatable containing our sql servers 
            Dim sqlServersTable As DataTable = sqlEnumerator.GetDataSources()

            'iterate thru all the rows 
            For Each rowOfData As DataRow In sqlServersTable.Rows
                'get the server name 
                Dim serverName As String = rowOfData("ServerName").ToString()
                'get the instance name 
                Dim instanceName As String = rowOfData("InstanceName").ToString()

                'check if the instance name is empty 
                If Not instanceName.Equals(String.Empty) Then
                    'append the instance name to the server name 
                    serverName += String.Format("\{0}", instanceName)
                End If

                'add the server to our list 
                listOfServers.Add(serverName)
            Next

            'sort the list if the sort option is specified 
            If shouldSortList Then
                'sort it! 
                listOfServers.Sort()
            End If



            'return our list 

        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With

        End Try
        Return listOfServers
    End Function

    'Private Function GetSqlServers() As List(Of String)

    '    'get the servers with the list sorted 

    '    Return GetSqlServers(True)

    'End Function








    Private Sub cmbDB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDB.SelectedIndexChanged
        Try
            SimpleButton2.Enabled = True
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Sub

    Private Sub ServerList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerList.DoubleClick
        Try
            cmbDB.DataSource = GetDatabaseNames()
            CurServerNameProperty = ServerList.SelectedItem.ToString
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Sub


    Private Function GetDatabaseNames() As List(Of String)
        Try
            Dim connString As String
            Dim TmpDB As String
            Dim TmpDB2 As String
            Dim connString2 As String
            ' Be sure to replace this with your connection string.
            connString = "Data Source=" + ServerList.Text + ";Integrated Security=True"
            connString2 = "Data Source=" + ServerList.Text + ";Integrated Security=True"
            ' If Not String.IsNullOrWhiteSpace(connString) Then
            Using cn As SqlConnection = New SqlConnection(connString)
                ' Open the connection
                cn.Open()

                Using cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_databases"

                    Using myReader As SqlDataReader = cmd.ExecuteReader()
                        While (myReader.Read())
                            TmpDB = myReader.GetString(0)
                            Using cn2 As SqlConnection = New SqlConnection(connString2)
                                cn2.Open()
                                Using cmd2 As SqlCommand = New SqlCommand()


                                    cmd2.Connection = cn2
                                    cmd2.CommandType = CommandType.Text
                                    cmd2.CommandText = "USE " + TmpDB + " SELECT isnull(name,0) as name2 FROM sys.TABLES tt WHERE NAME='ExportDoc'"
                                    Using myReader2 As SqlDataReader = cmd2.ExecuteReader()
                                        While (myReader2.Read())
                                            TmpDB2 = myReader2.GetString(0)
                                            databaseNames.Add(TmpDB)
                                        End While


                                    End Using
                                    cn2.Close()

                                End Using
                            End Using


                        End While
                    End Using
                End Using
            End Using
            '  End If
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
        Return databaseNames

    End Function


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()






            CancelF = True
            ServerList.Text = ""
            cmbDB.Text = ""
            ServerList.Items.Clear()

            SimpleButton2.Enabled = False
            ServerList.Enabled = True


            Dim SqlEnumerator As System.Data.Sql.SqlDataSourceEnumerator
            SqlEnumerator = System.Data.Sql.SqlDataSourceEnumerator.Instance
            Dim dTable As System.Data.DataTable
            dTable = SqlEnumerator.GetDataSources()
            Dim dRow As System.Data.DataRow

            For Each dRow In dTable.Rows
                ServerList.Items.Add(dRow.Item(0).ToString)
            Next



            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try

        '  ServerList.DataSource = GetSqlServers()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            Dim Ip As String


            Select Case XtraTabControl1.SelectedTabPage.Tag
                Case 1
                    CurDataBase = cmbDB.Text
                    Server_Str = "Data Source=" + CurServerNameProperty   'CurSqlServer.Name
                    DBase_Str = "Initial Catalog=" + CurDataBase
                    Conn_Str = String.Format("{0};{1};{2}", Server_Str, DBase_Str, Others_Str)
                    CancelF = False


                Case 2
                    '  Data Source=192.162.1.100,1433;Network Library=DBMSSOCN;
                    '  Initial Catalog=Northwind;User ID=sa;Password=;

                    '  Data Source=82.205.240.149;Initial Catalog=NIC;Persist Security Info=True;User ID=sa;Password=baghdad@iraq1
                    Ip = IPtxt.Text.Replace(" ", "")
                    Ip = Ip.Trim()




                    Server_Str = "Data Source=" + Ip
                    DBase_Str = String.Format("Initial Catalog={0};Persist Security Info=True;", DBtxt.Text)
                    Others_Str = String.Format("User ID={0};Password={1}", Usertxt.Text, Passtxt.Text)
                    Conn_Str = String.Format("{0};{1};{2}", Server_Str, DBase_Str, Others_Str)
            End Select





            My.Settings.RunTimeConnectionString = Conn_Str

            Me.Close()

        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try


    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            CancelF = True
            Me.Close()
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Sub



    Private _Config As Configuration
    Private Sub OpenDataBaseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _Config = New Configuration(ConfigFilePath)
            Select Case Crypto.DecryptTripleDES(_Config.GetString("ConnectType"), "eXa1975")
                Case "Auto"
                    XtraTabPage1.PageVisible = False
                    XtraTabPage2.PageVisible = False
                    XtraTabPage3.PageVisible = True
                    Select Case Crypto.DecryptTripleDES(_Config.GetString("ConnectBy"), "eXa1975")
                        Case "Local"
                            CurDataBase = Crypto.DecryptTripleDES(_Config.GetString("SQLServerDBName"), "eXa1975")
                            Server_Str = "Data Source=" + Crypto.DecryptTripleDES(_Config.GetString("SQLServerName"), "eXa1975")   'CurSqlServer.Name
                            DBase_Str = "Initial Catalog=" + CurDataBase
                            Conn_Str = Server_Str + ";" + DBase_Str + ";" + Others_Str
                            CancelF = False
                        Case "Net"

                            SqlIP = Crypto.DecryptTripleDES(_Config.GetString("NetCode"), "eXa1975")

                            Server_Str = "Data Source=" + Crypto.DecryptTripleDES(_Config.GetString("SQLServerIP"), "eXa1975")
                            DBase_Str = "Initial Catalog=" + Crypto.DecryptTripleDES(_Config.GetString("SQLServerDB"), "eXa1975") + ";Persist Security Info=True;"
                            Others_Str = "User ID=" + Crypto.DecryptTripleDES(_Config.GetString("SQLServerUserName"), "eXa1975") + ";Password=" + Crypto.DecryptTripleDES(_Config.GetString("SQLServerpassword"), "eXa1975")
                            Conn_Str = Server_Str + ";" + DBase_Str + ";" + Others_Str
                    End Select
                Case "User"
                    Select Case Crypto.DecryptTripleDES(_Config.GetString("ConnectBy"), "eXa1975")
                        Case "Local"
                            XtraTabPage1.PageVisible = True
                            XtraTabPage2.PageVisible = False
                            XtraTabPage3.PageVisible = False
                        Case "Net"
                            XtraTabPage1.PageVisible = False
                            XtraTabPage2.PageVisible = True
                            XtraTabPage3.PageVisible = False
                        Case "Both"
                            XtraTabPage1.PageVisible = True
                            XtraTabPage2.PageVisible = True
                            XtraTabPage3.PageVisible = False
                    End Select
            End Select
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Sub


    Private Sub TextEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtNetCode.EditValueChanged

    End Sub
End Class