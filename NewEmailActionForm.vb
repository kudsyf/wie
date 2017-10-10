Public Class NewEmailActionForm



    Private Sub NewEmailActionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
          

            Me.FolderTableAdapter.FillByOrgAndYear(Me.NewDBFDataSet.Folder, CurOrgNo, Year(DateTime.Today))
            Select Case EMailActTypeProperty
                Case "I_Save"
                    LayoutControlItem14.Visibility = True
                    LayoutControlItem6.Visibility = False

                Case "E_Save"
                    LayoutControlItem14.Visibility = False
                    LayoutControlItem6.Visibility = True

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

    Private Sub LookUpEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEdit2.EditValueChanged
        Try
            TextEdit3.Text = LookUpEdit2.GetColumnValue("Folder_No").ToString
            Select Case EMailActTypeProperty
                Case "I_Save"
                    Me.ImportFolderSeqGapsTableAdapter1.Fill(Me.NewDBFDataSet.ImportFolderSeqGaps, LookUpEdit2.GetColumnValue("FolderId"))


                Case "E_Save"
                    Me.ExportFolderSeqGapsTableAdapter.Fill(Me.NewDBFDataSet.ExportFolderSeqGaps, LookUpEdit2.GetColumnValue("FolderId"))


            End Select
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
            If DateEdit1.EditValue Is Nothing Then
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال تاريخ الاجراء")
                Return
            End If

            Select Case EMailActTypeProperty
                Case "I_Save"
                    If LookUpEdit2.EditValue Is Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال اسم الاضبارة للحفظ")
                        Return
                    End If
                    Dim gfolder As String = " [ أضبارة :[ " + LookUpEdit2.Text.Trim + "  ]  بالرقم  [ " + TextEdit3.Text.Trim + " ] والتسلسل [ " + LookUpEdit1.EditValue.ToString.Trim

                    Me.EmailImports_ActionTableAdapter1.Insert(SelectedemailImpIDProperty, EmailImports_ActionTableAdapter1.GetMaxId(SelectedemailImpIDProperty), 3, DateEdit1.EditValue, CurOrgNo, gfolder, "", True)
                    Me.ImportFolderSeqGapsTableAdapter1.InsertImportFolder(SelectedemailImpIDProperty, LookUpEdit2.GetColumnValue("FolderId"), DateTime.Today, LookUpEdit1.EditValue)


                    eeffrm.EmailImports_ActionTableAdapter1.FillByOrgID(eeffrm.NewDBFDataSet.EmailImports_Action, CurOrgNo, SelectedemailImpIDProperty)
                    eeffrm.GridView2.RefreshData()


                Case "I_Other"
                    Me.EmailImports_ActionTableAdapter1.Insert(SelectedemailImpIDProperty, EmailImports_ActionTableAdapter1.GetMaxId(SelectedemailImpIDProperty), 4, DateEdit1.EditValue, CurOrgNo, TextEdit1.Text, "", False)
                    eeffrm.EmailImports_ActionTableAdapter1.FillByOrgID(eeffrm.NewDBFDataSet.EmailImports_Action, CurOrgNo, SelectedemailImpIDProperty)
                    eeffrm.GridView2.RefreshData()



                Case "E_Save"
                    If LookUpEdit2.EditValue Is Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال اسم الاضبارة للحفظ")
                        Return
                    End If
                    Dim gfolder As String = " [ أضبارة :[ " + LookUpEdit2.Text.Trim + "  ]  بالرقم  [ " + TextEdit3.Text.Trim + " ] والتسلسل [ " + LookUpEdit3.EditValue.ToString.Trim

                    Me.EmailExports_ActionTableAdapter1.Insert(SelectedemailExpIDProperty, EmailExports_ActionTableAdapter1.GetMaxId(SelectedemailExpIDProperty), 3, DateEdit1.EditValue, CurOrgNo, gfolder, "", True)
                    Me.ExportFolderSeqGapsTableAdapter1.InsertExportFolder(SelectedemailExpIDProperty, LookUpEdit2.GetColumnValue("FolderId"), DateTime.Today, LookUpEdit3.EditValue)


                    eXeeffrm.EmailExports_ActionTableAdapter.FillByOrgID(eXeeffrm.NewDBFDataSet.EmailExports_Action, CurOrgNo, SelectedemailExpIDProperty)
                    eXeeffrm.GridView2.RefreshData()


                Case "E_Other"
                    Me.EmailExports_ActionTableAdapter1.Insert(SelectedemailExpIDProperty, EmailExports_ActionTableAdapter1.GetMaxId(SelectedemailExpIDProperty), 4, DateEdit1.EditValue, CurOrgNo, TextEdit1.Text, "", False)
                    eXeeffrm.EmailExports_ActionTableAdapter.FillByOrgID(eXeeffrm.NewDBFDataSet.EmailExports_Action, CurOrgNo, SelectedemailExpIDProperty)
                    eXeeffrm.GridView2.RefreshData()


            End Select
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





End Class