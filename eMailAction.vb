Imports System.IO
Imports System.Windows.Forms
Imports System.Threading
Public Class eMailAction



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


    Dim stream As MemoryStream
    Dim AttachArray() As Byte
    Dim sd As Byte()
    Private _Config As Configuration
    Private Sub eMailAction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.EmailExports_TO_CC' table. You can move, or remove it, as needed.

        Try
            _Config = New Configuration(ConfigFilePath)
            'TODO: This line of code loads data into the 'NewDBFDataSet.EmailImports' table. You can move, or remove it, as needed.
            Me.GabsNoEmailExportsTableAdapter.Fill(NewDBFDataSet.GabsNoEmailExports, CurOrgNo, Year(DateTime.Today))
            DateEdit1.EditValue = DateTime.Today

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

    Private Sub eMailAction_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            stream = Nothing


            Me.Hide()
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Dim mail As New System.Net.Mail.MailMessage()
            Dim sendnow As New System.Net.Mail.SmtpClient

            mail = New System.Net.Mail.MailMessage()
            mail.From = New Net.Mail.MailAddress(FromTxt.EditValue.ToString.Trim)

            Dim aa As Integer
            Dim isTo As Boolean = False
            Dim FwTo As String = ""

            For aa = 0 To GridView1.RowCount - 1
                If GridView1.GetDataRow(aa).Item("Sel") = True Then
                    sd = GridView1.GetDataRow(aa).Item("AttachBin")
                    Dim s As New MemoryStream(sd)
                    Dim att = New System.Net.Mail.Attachment(s, GridView1.GetDataRow(aa).Item("Attach").ToString)
                    mail.Attachments.Add(att)

                End If
            Next



            For aa = 0 To GridView2.RowCount - 1
                If GridView2.GetDataRow(aa).Item("Sel") = True Then
                    mail.To.Add(GridView2.GetDataRow(aa).Item("Org").ToString)
                    FwTo = FwTo + " " + GridView2.GetDataRow(aa).Item("To").ToString + ";"
                    isTo = True

                End If
            Next

            If Not isTo Then
                DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن اضافة اجراء من دون اختيار حقل - الى  ")
                Return
            End If
            For aa = 0 To GridView3.RowCount - 1
                If GridView3.GetDataRow(aa).Item("Sel") = True Then
                    mail.CC.Add(GridView3.GetDataRow(aa).Item("CC").ToString)
                End If
            Next

            mail.Subject = SubjectTxt.EditValue
            mail.Body = RichEditControl1.HtmlText
            mail.IsBodyHtml = True
            sendnow.Credentials = New Net.NetworkCredential(Me.OrgemailTableAdapter1.GetEmail(CurOrgNo).ToString.Trim, Me.OrgemailTableAdapter1.GetPass(CurOrgNo).ToString.Trim)
            sendnow.Port = 25
            sendnow.EnableSsl = True
       
            sendnow.Host = Crypto.DecryptTripleDES(_Config.GetString("eMailSMTPServer"), "eXa1975")

            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()


            sendnow.Send(mail)

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()


            Select Case EMailActionTypeProperty
                Case "FW"
                    EmailImports_ActionTableAdapter1.InsertQuery(SelectedemailImpIDProperty, EmailImports_ActionTableAdapter1.GetMaxId(SelectedemailImpIDProperty), 1, DateTime.Today, CurOrgNo, "احالة الى" + FwTo, FwTo, 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("تم تنفيذ الاجراء ")
                Case "RE"
                    Dim eid As String = EmailExportsTableAdapter1.GetMaxExportId()
                    Dim eno As String = LookUpEdit1.EditValue.ToString.Trim

                    EmailImports_ActionTableAdapter1.InsertQuery(SelectedemailImpIDProperty, EmailImports_ActionTableAdapter1.GetMaxId(SelectedemailImpIDProperty), 2, DateTime.Today, CurOrgNo, " اصدار بريد الكتروني بالرقم  " + LookUpEdit1.EditValue.ToString.Trim + " وبتاربخ " + DateEdit1.EditValue.ToString.Trim, FwTo, 1)
                    EmailExportsTableAdapter1.Insert(eid, eno, DateEdit1.EditValue.ToString.Trim, CurOrgNo, CurLogin, DateTime.Today, SubjectTxt.EditValue.ToString.Trim, FwTo, RichEditControl1.HtmlText, 0)

                    For aa = 0 To GridView1.RowCount - 1
                        If GridView1.GetDataRow(aa).Item("Sel") = True Then
                            sd = GridView1.GetDataRow(aa).Item("AttachBin")
                            EmailExports_AttachTableAdapter.InsertExportAttach(eid, EmailExports_AttachTableAdapter.MaxId(eid), GridView1.GetDataRow(aa).Item("Attach").ToString.Trim, sd)
                        End If
                    Next


                    For aa = 0 To GridView2.RowCount - 1
                        If GridView2.GetDataRow(aa).Item("Sel") = True Then
                            EmailExports_TO_CCTableAdapter.Insert(eid, "TO", GridView2.GetDataRow(aa).Item("Org").ToString)
                        End If
                    Next

                    For aa = 0 To GridView3.RowCount - 1
                        If GridView3.GetDataRow(aa).Item("Sel") = True Then
                            EmailExports_TO_CCTableAdapter.Insert(eid, "CC", GridView3.GetDataRow(aa).Item("CC").ToString)
                        End If
                    Next
                    DevExpress.XtraEditors.XtraMessageBox.Show("تم تنفيذ الاجراء ")
            End Select

            eeffrm.EmailImports_ActionTableAdapter1.FillByOrgID(eeffrm.NewDBFDataSet.EmailImports_Action, CurOrgNo, SelectedemailImpIDProperty)
            eeffrm.GridView2.RefreshData()

            mail = Nothing
            sendnow = Nothing

            Me.Hide()

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

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            Dim sf As New OpenFileDialog
            sf.Multiselect = True
            sf.ShowDialog()
            Dim table2 As DataTable = New DataTable("Attach")
            table2.Columns.Add("ico")
            table2.Columns.Add("Attach")
            table2.Columns.Add("Sel")
            table2.Columns.Add("AttachBin")
            table2.Columns("AttachBin").DataType = System.Type.GetType("System.Byte[]")
            table2.Columns("Sel").DataType = System.Type.GetType("System.Boolean")

            Dim id As Int16 = -1
            Dim er As Integer
            For er = 0 To GridView1.RowCount - 1
                table2.Rows.Add(GridView1.GetDataRow(er).Item("Ico"), GridView1.GetDataRow(er).Item("Attach").ToString.Trim, GridView1.GetDataRow(er).Item("Sel"), GridView1.GetDataRow(er).Item("AttachBin"))
            Next

            id = -1
            Dim ui As Integer

            For ui = 0 To sf.FileNames.Length - 1
                Select Case Strings.Right(sf.SafeFileNames(ui).Trim, 4).ToLower
                    Case "docx"
                        id = 4
                    Case "pptx"
                        id = 6
                    Case "xlsx"
                        id = 2
                End Select

                Select Case Strings.Right(sf.SafeFileNames(ui).Trim, 3).ToLower
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
                table2.Rows.Add(id, sf.SafeFileNames(ui).Trim, True, StreamFile(sf.FileNames(ui).Trim))

            Next

            Dim set2 As DataSet = New DataSet("Attach")

            Dim dvm2 As DataViewManager = New DataViewManager(set2)

            Dim myDatatView2 As DataView = dvm2.CreateDataView(table2)


            GridControl1.DataSource = Nothing
            GridControl1.DataMember = Nothing
            GridControl1.DataSource = myDatatView2


            GridView1.Columns(0).FieldName = "ico"
            GridView1.Columns(1).FieldName = "Attach"
            GridView1.Columns(2).FieldName = "Sel"
            GridView1.Columns(3).FieldName = "AttachBin"

            GridView1.Columns(1).OptionsColumn.AllowEdit = False
            GridView1.Columns(0).OptionsColumn.AllowEdit = False
            GridView1.Columns(2).OptionsColumn.AllowEdit = True
            GridView1.Columns(2).OptionsColumn.ShowCaption = False

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

    Private Function StreamFile(ByVal filename As String) As Byte()
        Dim fs As New FileStream(filename, FileMode.Open, FileAccess.Read)

        ' Create a byte array of file stream length
        Dim ImageData As Byte() = New Byte(fs.Length - 1) {}
        Try

            'Read block of bytes from stream into the byte array
            fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length))

            'Close the File Stream
            fs.Close()
            'return the byte data

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
        Return ImageData
    End Function

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        Try
            EMailActionAddFromProperty = "Action"
            EMailActionAddTypeProperty = "TO"
            Dim ead As New NewEmailAdd
            ead.ShowDialog()
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

    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        Try
            EMailActionAddFromProperty = "Action"
            EMailActionAddTypeProperty = "CC"
            Dim ead As New NewEmailAdd
            ead.ShowDialog()
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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Hide()

    End Sub
End Class