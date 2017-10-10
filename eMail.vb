Imports Rebex.Mail
Imports System.IO

Public Class eMail
    Public iMessage As MailMessage
    Dim stream As MemoryStream
    Dim AttachArray() As Byte
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Try
            Dim imid As Integer
            imid = EmailImportsTableAdapter.MaxID(Year(DateTime.Today), CurOrgNo)
            EmailImportsTableAdapter.InsertEmailImport(imid, LookUpEdit1.EditValue, DateTxt.EditValue, CurOrgNo, CurLogin, DateTime.Today, SubjectTxt.EditValue.ToString.Trim, FromTxt.EditValue.ToString.Trim, DateTxt.EditValue.ToString.Trim, WebBrowser1.DocumentText, 0)



                For Each frmeee As Form In MainSys.MdiChildren
                    If frmeee.Name = "EmailImportList" Then
                        frmemImpList.EmailImportsTableAdapter.FillByEmailOrg(frmemImpList.NewDBFDataSet.EmailImports, CurOrgNo)
                        frmemImpList.GridView1.RefreshData()

                    End If
                Next

                Dim ai As Integer

                For ai = 0 To iMessage.Attachments.Count - 1

                    stream = New MemoryStream()
                    iMessage.Attachments(ai).Save(stream)


                    AttachArray = stream.GetBuffer()
                    EmailImports_AttachTableAdapter1.InsertEmailImportAttach(imid, LookUpEdit1.EditValue, iMessage.Attachments(ai).FileName.Trim, AttachArray)

                Next


                For ai = 0 To iMessage.To.Count - 1
                    EmailImports_TO_CCTableAdapter1.Insert(imid, "TO", iMessage.To(ai).Address)
                Next

                For ai = 0 To iMessage.CC.Count - 1
                    EmailImports_TO_CCTableAdapter1.Insert(imid, "CC", iMessage.CC(ai).Address)
                Next


                stream = Nothing
                iMessage = Nothing

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

    Private Sub eMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.EmailImports' table. You can move, or remove it, as needed.
            GapsImport1TableAdapter.Fill2(Me.NewDBFDataSet.GapsImport1, CurOrgNo, Year(DateTime.Today))
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

    Private Sub eMail_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            stream = Nothing
            iMessage = Nothing

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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Hide()

    End Sub
End Class