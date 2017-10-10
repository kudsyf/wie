Public Class NewImpActionForm

    Public isNewSeq As Boolean

    Private Sub NewImpActionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.OrgMembers' table. You can move, or remove it, as needed.
        Me.OrgMembersTableAdapter.Fill(Me.NewDBFDataSet.OrgMembers)
        Try
            Me.ExportDoc1TableAdapter.Fill(Me.NewDBFDataSet.ExportDoc1)
            Me.FolderTableAdapter.FillByOrgAndYear(Me.NewDBFDataSet.Folder, CurOrgNo, Year(DateTime.Today))
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            DateEdit2.Enabled = False
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
            Me.ImportFolderSeqGapsTableAdapter.Fill(Me.NewDBFDataSet.ImportFolderSeqGaps, LookUpEdit2.GetColumnValue("FolderId"))
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
            Dim curOrg As Integer
            Dim ss As Integer
            If DateEdit2.EditValue = Nothing Or CheckEdit1.EditValue = False Then

                Dim sd As System.Windows.Forms.DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم تحديد موعد للاجراء، هل ترغب بالاستمرار في الحفظ. وفي حالة عدم اختيار موعد للاجراء لن يظهر في التقارير ككتاب متاخر في حالة تاخره", "تنبيه", MessageBoxButtons.YesNo)
                If sd = Windows.Forms.DialogResult.Yes Then



                    If Me.Import_ActionTableAdapter.GetmaxActionId(UsedImportIdProperty) Is Nothing Then
                        ss = 1
                    Else
                        ss = Me.Import_ActionTableAdapter.GetmaxActionId(UsedImportIdProperty) + 1
                    End If
                    If CheckEdit1.EditValue = True Then
                        If DateEdit2.EditValue <= DateEdit1.EditValue Then
                            DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال تاريخ اخر موعد لتنفيذ الاجراء اكبر من تاريخ الاجراء")
                            Return
                        End If
                    Else

                    End If

                Else

                    Return
                End If
            End If






            If DateEdit1.EditValue Is Nothing Then
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال تاريخ الاجراء")
                Return
            End If

            Select Case XtraTabControl1.SelectedTabPage.Tag
                Case 0 ' Others
                    Me.Import_ActionTableAdapter.InsertImportAction(UsedImportIdProperty, ss, XtraTabControl1.SelectedTabPage.Tag, DateEdit1.EditValue, TextEdit1.Text, ComboBoxEdit1.SelectedIndex, "", CurLogin, DateTime.Today, CurLogin, DateTime.Today, "", CurOrgNo, 0, DateEdit2.EditValue, True, Nothing)
                    ffrm.Import_ActionTableAdapter.FillByID(ffrm.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                    ffrm.GridView4.RefreshData()

                Case 1 ' Save 
                    If LookUpEdit2.EditValue Is Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال اسم الاضبارة للحفظ")
                        Return
                    End If


                    Dim gfolder As String = String.Format(" [ أضبارة :[ {0}  ]  بالرقم  [ {1} ] والتسلسل [ {2}", LookUpEdit2.Text.Trim, TextEdit3.Text.Trim, LookUpEdit3.EditValue.ToString.Trim)

                    Me.Import_ActionTableAdapter.InsertImportAction(UsedImportIdProperty, ss, XtraTabControl1.SelectedTabPage.Tag, DateEdit1.EditValue, gfolder.Trim, ComboBoxEdit1.SelectedIndex, "", CurLogin, DateTime.Today, CurLogin, DateTime.Today, "", CurOrgNo, 0, DateEdit2.EditValue, False, Nothing)

                    ffrm.Import_ActionTableAdapter.FillByID(ffrm.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                    ffrm.GridView4.RefreshData()




                    If ActionOpenFormProperty = "ACTION" Then

                        Import_ActionTableAdapter.UpdateLocalSave(ActionLocalImpIdProperty, ActionLocalIdProperty)
                        lclfrmImpList.ImportDocForTransferTableAdapter.FillBytransfer(lclfrmImpList.NewDBFDataSet.ImportDocForTransfer, CurOrgNo)
                        lclfrmImpList.GridView1.RefreshData()
                    Else
                        Me.ImportFolderSeqGapsTableAdapter.InsertImportFolder(UsedImportIdProperty, LookUpEdit2.GetColumnValue("FolderId"), DateTime.Today, LookUpEdit3.EditValue)

                    End If

                Case 2 ' Move to
                    If LookUpEdit1.EditValue Is Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال اسم الجهة المحال اليها")
                        Return
                    End If
                    Dim gmove As String = String.Format(" [ إحالة الى :[ {0} // {1}", LookUpEdit1.Text.Trim, TextEdit4.EditValue)

                    Me.Import_ActionTableAdapter.InsertImportAction(UsedImportIdProperty, ss, XtraTabControl1.SelectedTabPage.Tag, DateEdit1.EditValue, gmove, ComboBoxEdit1.SelectedIndex, "", CurLogin, DateTime.Today, CurLogin, DateTime.Today, LookUpEdit1.EditValue, CurOrgNo, 0, DateEdit2.EditValue, True, Nothing)
                    ffrm.Import_ActionTableAdapter.FillByID(ffrm.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                    ffrm.GridView4.RefreshData()
                    'check if this is the first transfer

                    If Me.ImportDocTableAdapter.checkIfCurOrg(UsedImportIdProperty) = 0 Then
                        If Me.ImportDocTableAdapter.MaxCurrentOrgById() Is Nothing Then
                            curOrg = 1
                        Else
                            curOrg = Me.ImportDocTableAdapter.MaxCurrentOrgById() + 1
                        End If
                        Me.ImportDocTableAdapter.UpdateCurrOrg(curOrg, UsedImportIdProperty)
                    Else
                        curOrg = Me.ImportDocTableAdapter.checkIfCurOrg(UsedImportIdProperty)
                    End If
                    Me.CurrentImportOrgusersTableAdapter.UpdateCurrOrg(curOrg, LookUpEdit1.EditValue)
                Case 3 ' return 
                    Me.Import_ActionTableAdapter.InsertImportAction(UsedImportIdProperty, ss, XtraTabControl1.SelectedTabPage.Tag, DateEdit1.EditValue, "إعادة : " + TextEdit2.Text, ComboBoxEdit1.SelectedIndex, "", CurLogin, DateTime.Today, CurLogin, DateTime.Today, "", CurOrgNo, 0, DateEdit2.EditValue, False, Nothing)
                    ffrm.Import_ActionTableAdapter.FillByID(ffrm.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                    ffrm.GridView4.RefreshData()
                Case 4 ' export 
                    Dim gexport As String = String.Format("صادر برقم :{0}   بتاريخ :{1}", GridView1.GetFocusedDataRow("Book_No"), GridView1.GetFocusedDataRow("Book_Date"))

                    Me.Import_ActionTableAdapter.InsertImportAction(UsedImportIdProperty, ss, XtraTabControl1.SelectedTabPage.Tag, DateEdit1.EditValue, gexport, ComboBoxEdit1.SelectedIndex, "", CurLogin, DateTime.Today, CurLogin, DateTime.Today, "", CurOrgNo, GridView1.GetFocusedDataRow("ExportId"), DateEdit2.EditValue, False, Nothing)


                    ffrm.Import_ActionTableAdapter.FillByID(ffrm.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                    ffrm.GridView4.RefreshData()
                    SaveSession(SessionType.AddImpAction)
                Case 5 ' Consultation 
                    Dim gexport As String = String.Format("مداولة مع :{0}", LookUpEdit4.Text.Trim)

                    Me.Import_ActionTableAdapter.InsertImportAction(UsedImportIdProperty, ss, XtraTabControl1.SelectedTabPage.Tag, DateEdit1.EditValue, gexport, ComboBoxEdit1.SelectedIndex, "", CurLogin, DateTime.Today, CurLogin, DateTime.Today, "", CurOrgNo, 0, DateEdit2.EditValue, False, LookUpEdit4.EditValue)


                    ffrm.Import_ActionTableAdapter.FillByID(ffrm.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                    ffrm.GridView4.RefreshData()
                    SaveSession(SessionType.AddImpAction)
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



    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Try
            DateEdit2.Enabled = Not DateEdit2.Enabled
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