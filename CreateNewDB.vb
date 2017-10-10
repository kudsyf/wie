Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading
Public Class CreateNewDB



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
    'Private Function GetSqlServers(ByVal shouldSortList As Boolean) As List(Of String)
    '    Try
    '        'create the list that would hold our servers 
    '        Dim listOfServers As New List(Of String)()

    '        'create a new instance of our SqlDataSourceEnumerator 
    '        Dim sqlEnumerator As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance

    '        'get the datatable containing our sql servers 
    '        Dim sqlServersTable As DataTable = sqlEnumerator.GetDataSources()

    '        'iterate thru all the rows 
    '        For Each rowOfData As DataRow In sqlServersTable.Rows
    '            'get the server name 
    '            Dim serverName As String = rowOfData("ServerName").ToString()
    '            'get the instance name 
    '            Dim instanceName As String = rowOfData("InstanceName").ToString()

    '            'check if the instance name is empty 
    '            If Not instanceName.Equals(String.Empty) Then
    '                'append the instance name to the server name 
    '                serverName += String.Format("\{0}", instanceName)
    '            End If

    '            'add the server to our list 
    '            listOfServers.Add(serverName)
    '        Next

    '        'sort the list if the sort option is specified 
    '        If shouldSortList Then
    '            'sort it! 
    '            listOfServers.Sort()
    '        End If

    '        'return our list 
    '        Return listOfServers
    '    Catch ex As Exception
    '        Dim trace As New System.Diagnostics.StackTrace(ex, True)
    '        With ErrorTrace1
    '            .SendReport = True
    '            .NotifyLocal = True
    '            .From = rFrom
    '            .SendTo = rSendTo
    '            .SMTPServer = rSMTPServer
    '            .SMTPPass = rSMTPPass
    '            .SMTPUser = rSMTPUser
    '            .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
    '            .LineNumber = trace.GetFrame(0).GetFileLineNumber()
    '            .Ex = ex
    '        End With
    '    End Try
    'End Function

    Private Sub WizardControl1_SelectedPageChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles WizardControl1.SelectedPageChanging
        Try
            If e.Page.Name = "WizardPage1" And e.Direction = DevExpress.XtraWizard.Direction.Forward Then
                If TextEdit3.Text = "&123abc" Then



                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("ترخيص الانشاء خاطئ .. الرجاء اعادة المحاولة")
                    e.Page = WelcomeWizardPage1
                End If
            End If

            If e.Page.Name = "WizardPage2" And e.Direction = DevExpress.XtraWizard.Direction.Forward Then
                If ServerList.SelectedIndex <> -1 Then



                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار خادم.. الرجاء اعادة المحاولة")
                    e.Page = WizardPage1
                End If
            End If
            If e.Page.Name = "WizardPage3" And e.Direction = DevExpress.XtraWizard.Direction.Forward Then
                If TextEdit1.Text <> "" And TextEdit2.Text <> "" Then



                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة.. الرجاء اعادة المحاولة")
                    e.Page = WizardPage2
                End If
            End If
            If e.Page.Name = "CompletionWizardPage1" And e.Direction = DevExpress.XtraWizard.Direction.Forward Then
                ' create the database here
                Call CreateDB(TextEdit1.Text, TextEdit2.Text, ServerList.SelectedItem.ToString.Trim)
                Call CreateTables(TextEdit1.Text, ServerList.SelectedItem.ToString.Trim)

            End If
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
    Private Sub ExecuteSQLStmt(ByVal sql As String)
        ' Open the connectio
        Try


            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            conn.ConnectionString = ConnectionString
            conn.Open()
            cmd = New SqlCommand(sql, conn)
            Try
                cmd.ExecuteNonQuery()
            Catch ae As SqlException
                MessageBox.Show(ae.Message.ToString())
            End Try
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
    End Sub 'ExecuteSQLStmt 

    Private cmd As SqlCommand = Nothing
    Private ConnectionString As String
    Private conn As SqlConnection = Nothing

    Private reader As SqlDataReader = Nothing


    Private Sub CreateDB(ByVal DbName As String, ByVal DbPath As String, ByVal ServerName As String)
        Try
            ConnectionString = "Integrated Security=SSPI;" + "Initial Catalog=;" + "Data Source=" + ServerName + ";"
            Dim sql As String = "CREATE DATABASE " + DbName + " ON PRIMARY" + "(Name=" + DbName + "_data, filename = '" + DbPath + "\" + DbName + "_data.mdf', size=3," + "maxsize=5, filegrowth=10%)log on" + "(name=" + DbName + "_log, filename='" + DbPath + "\" + DbName + "_log.ldf',size=3," + "maxsize=20,filegrowth=1)"
            sql = sql + "ALTER DATABASE [" + DbName + "] COLLATE Arabic_CI_AS "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET ANSI_NULL_DEFAULT OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET ANSI_NULLS OFF "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET ANSI_PADDING OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET ANSI_WARNINGS OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET ARITHABORT OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET AUTO_CLOSE OFF "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET AUTO_CREATE_STATISTICS ON "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET AUTO_SHRINK OFF "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET AUTO_UPDATE_STATISTICS ON  "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET CURSOR_CLOSE_ON_COMMIT OFF "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET CURSOR_DEFAULT  GLOBAL "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET CONCAT_NULL_YIELDS_NULL OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET NUMERIC_ROUNDABORT OFF "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET QUOTED_IDENTIFIER OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET RECURSIVE_TRIGGERS OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET  DISABLE_BROKER "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET AUTO_UPDATE_STATISTICS_ASYNC OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET DATE_CORRELATION_OPTIMIZATION OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET TRUSTWORTHY OFF  "
            sql = sql + "ALTER DATABASE [" + DbName + "]   SET ALLOW_SNAPSHOT_ISOLATION OFF "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET PARAMETERIZATION SIMPLE "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET READ_COMMITTED_SNAPSHOT OFF "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET HONOR_BROKER_PRIORITY OFF "
            sql = sql + "ALTER DATABASE [" + DbName + "]  SET  READ_WRITE "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET RECOVERY FULL  "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET  MULTI_USER  "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET PAGE_VERIFY CHECKSUM  "
            sql = sql + "ALTER DATABASE [" + DbName + "] SET DB_CHAINING OFF  "

            conn = New SqlConnection(ConnectionString)

            ExecuteSQLStmt(sql)
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

    Private Sub CreateTables(ByVal DbName As String, ByVal ServerName As String)
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            ConnectionString = "Integrated Security=SSPI;" + "Initial Catalog=" + DbName + ";" + "Data Source=localhost;"
            conn.ConnectionString = ConnectionString
            conn.Open()
            Dim Sql As String = "USE  [" + DbName + "] " + vbCrLf + My.Resources.CreateTableRes.ToString + vbCrLf + My.Resources.CreateTableResNoData.ToString

            cmd = New SqlCommand(Sql, conn)
            cmd.ExecuteNonQuery()

            'Try
            '    cmd.ExecuteNonQuery()
            '    ' Adding records the table
            '    Sql = "INSERT INTO myTable(myId, myName, myAddress, myBalance) " + "VALUES (1001, 'Puneet Nehra', 'A 449 Sect 19, DELHI', 23.98 ) "
            '    cmd = New SqlCommand(Sql, conn)
            '    cmd.ExecuteNonQuery()
            '    Sql = "INSERT INTO myTable(myId, myName, myAddress, myBalance) " + "VALUES (1002, 'Anoop Singh', 'Lodi Road, DELHI', 353.64) "
            '    cmd = New SqlCommand(Sql, conn)
            '    cmd.ExecuteNonQuery()
            '    Sql = "INSERT INTO myTable(myId, myName, myAddress, myBalance) " + "VALUES (1003, 'Rakesh M', 'Nag Chowk, Jabalpur M.P.', 43.43) "
            '    cmd = New SqlCommand(Sql, conn)
            '    cmd.ExecuteNonQuery()
            '    Sql = "INSERT INTO myTable(myId, myName, myAddress, myBalance) " + "VALUES (1004, 'Madan Kesh', '4th Street, Lane 3, DELHI', 23.00) "
            '    cmd = New SqlCommand(Sql, conn)
            '    cmd.ExecuteNonQuery()
            'Catch ae As SqlException
            '    MessageBox.Show(ae.Message.ToString())
            'End Try
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



    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()







            ServerList.Text = ""

            ServerList.Items.Clear()


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

    End Sub

    Private Sub TextEdit2_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TextEdit2.ButtonClick
        Try
            FolderBrowserDialog1.ShowDialog()
            TextEdit2.Text = FolderBrowserDialog1.SelectedPath
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
End Class