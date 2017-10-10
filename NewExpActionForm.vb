Public Class NewExpActionForm

    Public isNewSeq As Boolean

    Private Sub NewExpActionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            Me.FolderTableAdapter.FillByOrgAndYear(Me.NewDBFDataSet.Folder, CurOrgNo, Year(DateTime.Today))
            ComboBoxEdit1.SelectedIndex = 0

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

    Private Sub LookUpEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEdit2.EditValueChanged
        Try
            TextEdit3.Text = LookUpEdit2.GetColumnValue("Folder_No").ToString
            Me.ExportFolderSeqGapsTableAdapter.Fill(Me.NewDBFDataSet.ExportFolderSeqGaps, LookUpEdit2.GetColumnValue("FolderId"))
            If LookUpEdit3.Text = "" Then
                LookUpEdit3.SelectedText = "1"
                LookUpEdit3.EditValue = 1
                LookUpEdit3.Text = "1"
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
        '    DevExpress.XtraEditors.XtraMessageBox.Show(LookUpEdit2.GetColumnValue("FolderId").ToString)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
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
            Dim ss As Integer

            If Me.Export_ActionTableAdapter.GetMaxActionId(UsedExportIdProperty) Is Nothing Then
                ss = 1
            Else
                ss = Me.Export_ActionTableAdapter.GetMaxActionId(UsedExportIdProperty) + 1
            End If

            If DateEdit1.EditValue Is Nothing Then
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال تاريخ الاجراء")
                Return
            End If

            Select Case XtraTabControl1.SelectedTabPage.Tag
                Case 0 ' Others
                    Me.Export_ActionTableAdapter.InsertExportAction(UsedExportIdProperty, ss, XtraTabControl1.SelectedTabPage.Tag, DateEdit1.EditValue, TextEdit1.Text, ComboBoxEdit1.SelectedIndex, "", CurLogin, DateTime.Today, CurLogin, DateTime.Today)
                    ffrmexp.Export_ActionTableAdapter.FillByID(ffrmexp.NewDBFDataSet.Export_Action, SelectedExpIDProperty)
                    ffrmexp.GridView4.RefreshData()

                Case 1 ' Save 
                    If LookUpEdit2.EditValue Is Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال اسم الاضبارة للحفظ")
                        Return
                    End If
                    Dim gfolder As String = " [ أضبارة :[ " + LookUpEdit2.Text.Trim + "  ]  بالرقم  [ " + TextEdit3.Text.Trim + " ] والتسلسل [ " + LookUpEdit3.EditValue.ToString.Trim

                    Me.Export_ActionTableAdapter.InsertExportAction(UsedExportIdProperty, ss, XtraTabControl1.SelectedTabPage.Tag, DateEdit1.EditValue, gfolder.Trim, ComboBoxEdit1.SelectedIndex, "", CurLogin, DateTime.Today, CurLogin, DateTime.Today)
                    Me.ExportFolderSeqGapsTableAdapter.InsertExportFolder(UsedExportIdProperty, LookUpEdit2.GetColumnValue("FolderId"), DateTime.Today, LookUpEdit3.EditValue)



                    ffrmexp.Export_ActionTableAdapter.FillByID(ffrmexp.NewDBFDataSet.Export_Action, SelectedExpIDProperty)
                    ffrmexp.GridView4.RefreshData()

                    If ExpActionOpenFormProperty = "ACTION" Then

                        Export_To1TableAdapter1.UpdateStts(1, ExpActionLocalExpIdProperty, ExpActionLocalExpTOProperty)
                        lclfrmImpList22.LocalExportToTableAdapter.FillMyOrg(lclfrmImpList22.NewDBFDataSet.LocalExportTo, CurOrgNo)
                        lclfrmImpList22.GridView1.RefreshData()
                    End If

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





End Class