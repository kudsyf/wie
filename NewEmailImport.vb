
Imports System.Windows.Forms
Imports System.Threading
Imports Rebex.Net
Imports Rebex.Mail
Imports Rebex.Mime.Headers




Public Class NewEmailImport

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

    Dim eclient As New Imap
    Dim Message As MailMessage
    Dim messages As New ImapMessageCollection


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Try

            Dim par As New TlsParameters()
            par.AllowedSuites = TlsCipherSuite.Secure
            par.Version = TlsVersion.SSL30 Or TlsVersion.TLS10
    
            par.CommonName = Crypto.DecryptTripleDES(_Config.GetString("OrgPop3"), "eXa1975")


            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()

            If Not eclient Is Nothing Then
                eclient.Disconnect()

            End If
            eclient.Connect(Crypto.DecryptTripleDES(_Config.GetString("OrgPop3"), "eXa1975"), 993, par, ImapSecurity.Implicit)

            eclient.Login(OrgemailTableAdapter.GetEmail(CurOrgNo).Trim, OrgemailTableAdapter.GetPass(CurOrgNo).Trim)

            eclient.SelectFolder("Inbox")





            messages = eclient.Search(ImapSearchParameter.HasFlagsNoneOf(ImapMessageFlags.Seen))

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

            Dim message As ImapMessageInfo


            Dim table1 As DataTable = New DataTable("emailTables")
            table1.Columns.Add("Seq")
            table1.Columns.Add("eFrom")
            table1.Columns.Add("eSubject")
            table1.Columns.Add("eDate")
            Dim ico As Int16

            For Each message In messages
                If EmailImportsTableAdapter.UIDCount((message.UniqueId.ToString)) > 0 Then
                    ico = 1
                Else
                    ico = 0

                End If
                table1.Rows.Add(message.SequenceNumber.ToString, message.From.ToString, message.Subject.ToString, message.Date.ToString)

            Next
            Dim set1 As DataSet = New DataSet("emails")

            Dim dvm As DataViewManager = New DataViewManager(set1)

            Dim myDatatView As DataView = dvm.CreateDataView(table1)


            GridControl1.DataSource = Nothing
            GridControl1.DataMember = Nothing
            GridControl1.DataSource = myDatatView


            GridView1.Columns(1).FieldName = "eSubject"
            GridView1.Columns(2).FieldName = "eDate"
            GridView1.Columns(3).FieldName = "Seq"
            GridView1.Columns(0).FieldName = "eFrom"

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


    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick

        Try
            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()

            Message = eclient.GetMailMessage(CInt((Val(GridView1.GetFocusedDataRow("Seq").ToString))))

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

            Dim Nee As New eMail
            Nee.FromTxt.Text = Message.From.Item(0).Address
            Nee.DateTxt.Text = Message.Date.ToString
            Nee.SubjectTxt.Text = Message.Subject.ToString
            Nee.WebBrowser1.Navigate("about:blank")
            If Message.HasBodyHtml Then
                Nee.WebBrowser1.Document.OpenNew(False).Write(Message.BodyHtml.ToString)
            Else
                Nee.WebBrowser1.Document.OpenNew(False).Write(Message.BodyText.ToString)
            End If

            Nee.iMessage = Message

            Dim table2 As DataTable = New DataTable("Attach")
            table2.Columns.Add("ico")
            table2.Columns.Add("Attach")
            Dim i As Int16
            Dim id As Int16 = -1
            For i = 0 To Message.Attachments.Count - 1
                Select Case Strings.Right(Message.Attachments(i).FileName.ToString, 4).ToLower
                    Case "docx"
                        id = 4
                    Case "pptx"
                        id = 6
                    Case "xlsx"
                        id = 2
                End Select
                Select Case Strings.Right(Message.Attachments(i).FileName.ToString, 3).ToLower
                    Case "jpg"
                        id = 3
                    Case "bmp"
                        id = 3
                    Case "gif"
                        id = 3
                    Case "doc"
                        id = 4
                    Case "ppt"
                        id = 6
                    Case "xls"
                        id = 2
                    Case "mdb"
                        id = 1
                    Case "txt"
                        id = 7
                    Case "rar"
                        id = 9
                    Case "zip"
                        id = 9
                    Case "pdf"
                        id = 5
                End Select
                If id = -1 Then
                    id = 8
                End If
                table2.Rows.Add(id, Message.Attachments(i).FileName)
            Next
            Dim set2 As DataSet = New DataSet("Attach")
            Dim dvm2 As DataViewManager = New DataViewManager(set2)
            Dim myDatatView2 As DataView = dvm2.CreateDataView(table2)
            Nee.GridControl1.DataSource = Nothing
            Nee.GridControl1.DataMember = Nothing
            Nee.GridControl1.DataSource = myDatatView2
            Nee.GridView1.Columns(0).FieldName = "ico"
            Nee.GridView1.Columns(0).Caption = ""
            Nee.GridView1.Columns(1).FieldName = "Attach"

            Dim tableTo As DataTable = New DataTable("EmailTo")
            tableTo.Columns.Add("To")
            For i = 0 To Message.To.Count - 1
                tableTo.Rows.Add(Message.To(i).Address)
            Next
            Dim setTo As DataSet = New DataSet("EmailTo")
            Dim dvmTo As DataViewManager = New DataViewManager(setTo)
            Dim myDatatViewTo As DataView = dvmTo.CreateDataView(tableTo)
            Nee.GridControl2.DataSource = Nothing
            Nee.GridControl2.DataMember = Nothing
            Nee.GridControl2.DataSource = myDatatViewTo
            Nee.GridView2.Columns(0).FieldName = "To"


            Dim tableCC As DataTable = New DataTable("EmailCC")
            tableCC.Columns.Add("CC")
            For i = 0 To Message.CC.Count - 1
                tableCC.Rows.Add(Message.CC(i).Address)
            Next
            Dim setCC As DataSet = New DataSet("EmailCC")
            Dim dvmCC As DataViewManager = New DataViewManager(setCC)
            Dim myDatatViewCC As DataView = dvmCC.CreateDataView(tableCC)
            Nee.GridControl3.DataSource = Nothing
            Nee.GridControl3.DataMember = Nothing
            Nee.GridControl3.DataSource = myDatatViewCC
            Nee.GridView3.Columns(0).FieldName = "CC"



            Nee.Show()
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
    Private Sub NewEmailImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.EmailImports' table. You can move, or remove it, as needed.
        'Me.EmailImportsTableAdapter.Fill(Me.NewDBFDataSet.EmailImports)
        _Config = New Configuration(ConfigFilePath)
    End Sub

    Private Sub NewEmailImport_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        eclient.Disconnect()
        messages = Nothing
        Message = Nothing


    End Sub

End Class