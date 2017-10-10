Imports Rebex.Mail
Imports System.IO


Public Class ExpeMailView
    Public iMessage As MailMessage
    Dim stream As MemoryStream
    Dim AttachArray() As Byte
    Dim sd As Byte()



    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click


        Try

            Dim d() As Byte
            FolderBrowserDialog1.ShowDialog()
            Dim Ndata As NewDBFDataSet.EmailExports_AttachDataTable = Me.EmailExports_AttachTableAdapter1.GetDataBy2(SelectedemailExpIDProperty)
            Dim Nrow As NewDBFDataSet.EmailExports_AttachRow

            For Each Nrow In Ndata
                d = Nrow("AttachBin")
                Dim fsm As FileStream
                fsm = File.OpenWrite(FolderBrowserDialog1.SelectedPath + "\" + Nrow("AttachName").ToString.Trim)
                fsm.Write(d, 0, d.Length)
                fsm.Close()

            Next


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

    Private Sub ExpeMailView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.EmailExports_ActionTableAdapter.FillByOrgID(NewDBFDataSet.EmailExports_Action, CurOrgNo, SelectedemailExpIDProperty)

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

    Private Sub ExpeMailView_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim emac As New eMailAction
            EMailActionTypeProperty = ""
            emac.ShowDialog()

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

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            Dim dell As Int32
            Dim Actt As Int32

            dell = GridView2.GetFocusedDataRow("ImportId")
            Actt = GridView2.GetFocusedDataRow("ActionId")

            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Me.EmailImports_ActionTableAdapter1.DeleteAction(dell, Actt)
            GridView2.DeleteSelectedRows()
            '  SaveSession(SessionType.DelExpAction)


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

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

        Try
            NewEmailFrm = New NewEmailActionForm
            NewEmailFrm.XtraTabPage3.PageVisible = False
            NewEmailFrm.XtraTabPage2.PageVisible = True
            EMailActTypeProperty = "E_Save"
            NewEmailFrm.ShowDialog()

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

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick

        Try
            NewEmailFrm = New NewEmailActionForm
            NewEmailFrm.XtraTabPage3.PageVisible = True
            NewEmailFrm.XtraTabPage2.PageVisible = False
            EMailActTypeProperty = "E_Other"
            NewEmailFrm.ShowDialog()

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


    Private Sub SimpleButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            Dim dell As Int32
            Dim Actt As Int32

            dell = GridView2.GetFocusedDataRow("ExportId")
            Actt = GridView2.GetFocusedDataRow("ActionId")

            If Me.EmailExports_ActionTableAdapter.isDone(dell, Actt) Then

                DevExpress.XtraEditors.XtraMessageBox.Show("الاجراء منتهي سابقا")
                Return
            Else

                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على انهاء الاجراء ؟", "تاكيد انهاء الاجراء", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                Me.EmailExports_ActionTableAdapter.MarkDone(dell, Actt)
                Me.EmailExports_ActionTableAdapter.FillByOrgID(NewDBFDataSet.EmailExports_Action, CurOrgNo, SelectedemailExpIDProperty)
                GridView2.RefreshData()
            End If



            '  SaveSession(SessionType.DelExpAction)


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