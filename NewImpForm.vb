
Public Class NewImpForm




    Private Sub NewImpForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.OrgMembers' table. You can move, or remove it, as needed.
        Me.OrgMembersTableAdapter.Fill(Me.NewDBFDataSet.OrgMembers)

        Try

            Me.Import_AttachmentTableAdapter.FillByID(Me.NewDBFDataSet.Import_Attachment, SelectedImpIDProperty)
            Me.ActionsTableAdapter.Fill(Me.NewDBFDataSet.Actions)
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            If EditOrAddProperty = "EDIT" Then

                LayoutControlItem4.Visibility = False

                LayoutControlItem8.Visibility = True

                Me.Import_ActionTableAdapter.FillByID(Me.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                Me.ImportDocTableAdapter.FillByForm(Me.NewDBFDataSet.ImportDoc, Val(SelectedImpIDProperty))
                Me.Fill_ETableAdapter1.Fill(Me.NewDBFDataSet.Fill_E, Val(SelectedImpIDProperty))
                Me.Fill_ITableAdapter1.Fill(Me.NewDBFDataSet.Fill_I, Val(SelectedImpIDProperty))

                TextEdit1.Enabled = False
                TextEdit3.Enabled = False
                DateEdit1.Enabled = False
                DateEdit2.Enabled = False
                UsedImportIdProperty = SelectedImpIDProperty
                PopupContainerEdit1.Tag = DirectCast(Me.ImportDocTableAdapter.GetDataBy21(SelectedImpIDProperty).Rows.Item(0), WinImpExp.NewDBFDataSet.ImportDocRow).Import_Org_No
                PopupContainerEdit1.EditValue = OrgTableAdapter.GetOrgByNo(DirectCast(Me.ImportDocTableAdapter.GetDataBy21(SelectedImpIDProperty).Rows.Item(0), WinImpExp.NewDBFDataSet.ImportDocRow).Import_Org_No)
                
            End If

            If EditOrAddProperty = "NEW" Then
                
                LayoutControlItem8.Visibility = False
                LayoutControlItem4.Visibility = True

                SimpleButton10.Enabled = False
                XtraTabControl2.Enabled = False
                DateEdit2.EditValue = Date.Today

                If IsnewselectedorgImpProperty Then
                    Me.GapsImportTableAdapter.Fill(Me.NewDBFDataSet.GapsImport, NewselectedorgImpProperty, Year(DateTime.Today))

                Else
                    Me.GapsImportTableAdapter.Fill(Me.NewDBFDataSet.GapsImport, CurOrgNo, Year(DateTime.Today))
                End If

                UsedImportIdProperty = Val(Me.ImportDocTableAdapter.GetMaxImportId()) + 1

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






    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try

            If GridView1.FocusedValue IsNot Nothing Then
                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                Me.Import_DenoteTableAdapter.DeleteIDenote(GridView1.GetFocusedDataRow("ImportId"), GridView1.GetFocusedDataRow("Book_No"), GridView1.GetFocusedDataRow("Book_Date"))
                GridView1.DeleteSelectedRows()
                SaveSession(SessionType.DelImpDenote)
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                Return

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

            If GridView2.FocusedValue IsNot Nothing Then
                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟ ", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                Me.Import_DenoteTableAdapter.DeleteEDonate(GridView2.GetFocusedDataRow("ImportId"), GridView2.GetFocusedDataRow("Book_No"), GridView2.GetFocusedDataRow("Book_Date"))
                GridView2.DeleteSelectedRows()
                SaveSession(SessionType.DelImpDenote)
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                Return
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

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            SelectDenotePopupTypeProperty = "I_ADD"
            Dim DenFrm As New DenoteForm
            DenFrm.Text = "أشارة الى الكتب الواردة"
            DenFrm.Show()
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
            SelectDenotePopupTypeProperty = "E_ADD"
            Dim DenFrm As New DenoteForm
            DenFrm.Text = "أشارة الى الكتب الصادرة"
            DenFrm.Show()
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


    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click

        Try
            If EditOrAddProperty = "EDIT" Then
                If TextEdit3.Text = "" Or DateEdit1.EditValue = Nothing Or LookUpEdit2.EditValue = Nothing Or LookUpEdit3.EditValue = Nothing Or MemoEdit1.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول الاساسية فارغة... لا يمكن الحفظ")
                Else
                    ImportDocTableAdapter.Updatemain(PopupContainerEdit1.Tag, LookUpEdit2.EditValue, LookUpEdit3.EditValue, TextEdit2.Text, MemoEdit1.Text, UsedImportIdProperty)
                    For Each frmee As Form In MainSys.MdiChildren
                        If frmee.Name = "ImportListForm" Then


                            If frmImpList.CheckEdit1.EditValue Then
                                frmImpList.ImportDocTableAdapter.FillByDateRangeAdmin(frmImpList.NewDBFDataSet.ImportDoc, 0, frmImpList.ImportDocDatesTableAdapter1.GetData(frmImpList.RangeTrackBarControl1.Value.Minimum).Column1, frmImpList.ImportDocDatesTableAdapter1.GetData(frmImpList.RangeTrackBarControl1.Value.Maximum).Column1)

                            Else
                                frmImpList.ImportDocTableAdapter.FillByDateRangeAndOrg(frmImpList.NewDBFDataSet.ImportDoc, CurOrgNo, 0, frmImpList.ImportDocDatesTableAdapter1.GetData(frmImpList.RangeTrackBarControl1.Value.Minimum).Column1, frmImpList.ImportDocDatesTableAdapter1.GetData(frmImpList.RangeTrackBarControl1.Value.Maximum).Column1)

                            End If
                            frmImpList.GridView1.RefreshData()


                        End If
                    Next
                    SaveSession(SessionType.EditImp)
                End If
            End If

            If EditOrAddProperty = "NEW" Then
                If ImportDocTableAdapter.CheckPreBook(Year(DateEdit1.EditValue), TextEdit3.Text, PopupContainerEdit1.Tag) > 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("الكتاب مكرر .. الرجاء التاكد")
                    Exit Sub

                End If

                If LookUpEdit1.EditValue = Nothing Or DateEdit2.EditValue = Nothing Or TextEdit3.Text = "" Or DateEdit1.EditValue = Nothing Or LookUpEdit2.EditValue = Nothing Or LookUpEdit3.EditValue = Nothing Or MemoEdit1.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول الاساسية فارغة... لا يمكن الحفظ")
                Else

                    UsedImportIdProperty = Val(Me.ImportDocTableAdapter.GetMaxImportId()) + 1
                    If IsnewselectedorgImpProperty Then
                        Me.ImportDocTableAdapter.InsertNewImport(NewselectedorgImpProperty, UsedImportIdProperty, LookUpEdit1.Text, DateEdit2.EditValue, TextEdit3.Text, DateEdit1.EditValue, PopupContainerEdit1.Tag, LookUpEdit2.EditValue.ToString(), LookUpEdit3.EditValue.ToString(), TextEdit2.Text, MemoEdit1.Text, False, False, False, CurLogin, Date.Today, CurLogin, Date.Today)

                    Else

                        Me.ImportDocTableAdapter.InsertNewImport(CurOrgNo, UsedImportIdProperty, LookUpEdit1.Text, DateEdit2.EditValue, TextEdit3.Text, DateEdit1.EditValue, PopupContainerEdit1.Tag, LookUpEdit2.EditValue.ToString(), LookUpEdit3.EditValue.ToString(), TextEdit2.Text, MemoEdit1.Text, False, False, False, CurLogin, Date.Today, CurLogin, Date.Today)
                        IsnewselectedorgImpProperty = False

                        For Each frmee As Form In MainSys.MdiChildren
                            If frmee.Name = "ImportListForm" Then


                                If frmImpList.CheckEdit1.EditValue Then
                                    frmImpList.ImportDocTableAdapter.FillByDateRangeAdmin(frmImpList.NewDBFDataSet.ImportDoc, 0, frmImpList.ImportDocDatesTableAdapter1.GetData(frmImpList.RangeTrackBarControl1.Value.Minimum).Column1, frmImpList.ImportDocDatesTableAdapter1.GetData(frmImpList.RangeTrackBarControl1.Value.Maximum).Column1)

                                Else
                                    frmImpList.ImportDocTableAdapter.FillByDateRangeAndOrg(frmImpList.NewDBFDataSet.ImportDoc, CurOrgNo, 0, frmImpList.ImportDocDatesTableAdapter1.GetData(frmImpList.RangeTrackBarControl1.Value.Minimum).Column1, frmImpList.ImportDocDatesTableAdapter1.GetData(frmImpList.RangeTrackBarControl1.Value.Maximum).Column1)

                                End If
                                frmImpList.GridView1.RefreshData()

                                'Select Case ImpRangeProperty
                                '    Case "FULL"
                                '        frmImpList.ImportDocTableAdapter.FillBy1(frmImpList.NewDBFDataSet.ImportDoc, CurOrgNo, 0)

                                '    Case "7"
                                '        frmImpList.ImportDocTableAdapter.FillByRange7(frmImpList.NewDBFDataSet.ImportDoc, CurOrgNo, 0)
                                '        frmImpList.GridView1.RefreshData()
                                '    Case "30"
                                '        frmImpList.ImportDocTableAdapter.FillByRange30(frmImpList.NewDBFDataSet.ImportDoc, CurOrgNo, 0)
                                '        frmImpList.GridView1.RefreshData()
                                '    Case "180"
                                '        frmImpList.ImportDocTableAdapter.FillByRange180(frmImpList.NewDBFDataSet.ImportDoc, CurOrgNo, 0)
                                '        frmImpList.GridView1.RefreshData()
                                'End Select

                            End If
                        Next

                    End If
                    SimpleButton10.Enabled = True
                    XtraTabControl2.Enabled = True
                    SelectedImpIDProperty = UsedImportIdProperty
                    SaveSession(SessionType.NewImp)
                    LookUpEdit1.Enabled = False
                    TextEdit3.Enabled = False
                    DateEdit1.Enabled = False
                    DateEdit2.Enabled = False
                    EditOrAddProperty = "EDIT"
                End If
            End If
        Catch Sqlex As SqlClient.SqlException
            Select Case Sqlex.ErrorCode
                Case -2146232060
                    DevExpress.XtraEditors.XtraMessageBox.Show("القيد موجود اصلا")
                    Return
                Case Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن تحديث القيد .. رقم الخطأ " + Sqlex.ErrorCode)
                    Return
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

    Private Sub TreeList1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick
        Try

            PopupContainerEdit1.ClosePopup()
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

    Private Sub TreeList1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeList1.Click
        Try
            PopupContainerEdit1.Tag = TreeList1.FocusedNode.GetValue(2)
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
            If GridView4.FocusedValue IsNot Nothing Then
                If GotAdminAuth Then
                    Dim dell As Int32
                    Dim Actt As Int32

                    dell = GridView4.GetFocusedDataRow("ImportId")
                    Actt = GridView4.GetFocusedDataRow("ActionId")


                    If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                    Me.Import_ActionTableAdapter.DeleteById(dell, Actt)
                    GridView4.DeleteSelectedRows()
                    SaveSession(SessionType.DelImpAction)
                    Me.Import_ImageTableAdapter.DeleteByType(dell, "Action", Actt)
                    SaveSession(SessionType.DelImpActionImg)
                    Me.ImportFolderSeqGapsTableAdapter.DeletefolderSeq(dell)
                    SaveSession(SessionType.DelImpFolder)
                Else
                    If GridView4.GetFocusedDataRow("Cur_Org") Is Nothing Then

                    Else
                        If GridView4.GetFocusedDataRow("Cur_Org") = CurOrgNo Then
                            Dim dell As Int32
                            Dim Actt As Int32

                            dell = GridView4.GetFocusedDataRow("ImportId")
                            Actt = GridView4.GetFocusedDataRow("ActionId")


                            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                            Me.Import_ActionTableAdapter.DeleteById(dell, Actt)
                            GridView4.DeleteSelectedRows()
                            SaveSession(SessionType.DelImpAction)
                            Me.Import_ImageTableAdapter.DeleteByType(dell, "Action", Actt)
                            SaveSession(SessionType.DelImpActionImg)
                            Me.ImportFolderSeqGapsTableAdapter.DeletefolderSeq(dell)
                            SaveSession(SessionType.DelImpFolder)
                        Else
                            DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن حذف اجراء صادر من جهة اخرى")
                        End If
                    End If
                End If
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                Return
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

    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Try

            Dim actfrm As New NewImpActionForm

            actfrm.Show()
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

    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        Try
            Dim scnfrm As New ScannerForm
            ScanOrImagetypeProperty = "FromOrginImp"
            scnfrm.Show()
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

    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        Try
            If GridView3.FocusedValue IsNot Nothing Then

                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟ ", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

                Me.Import_AttachmentTableAdapter.Delete(GridView3.GetFocusedDataRow("ImportId"), GridView3.GetFocusedDataRow("AttachId"), GridView3.GetFocusedDataRow("Attachment"))
                Me.Import_ImageTableAdapter.DeleteByType(GridView3.GetFocusedDataRow("ImportId"), "Attach", GridView3.GetFocusedDataRow("AttachId"))
                GridView3.DeleteSelectedRows()
                SaveSession(SessionType.DelImpAttach)
                SaveSession(SessionType.DelImpAttachImg)
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                Return
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

    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        Try
            SelectDenotePopupTypeProperty = "I_ADD_A"
            Dim DenFrm As New DenoteForm
            DenFrm.Text = "المرفقات"
            DenFrm.Show()
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

    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        Try
            If GridView3.FocusedValue IsNot Nothing Then
                Dim scnfrm As New ScannerForm
                ScanOrImagetypeProperty = "FromImpAttach"
                ImgIdProperty = Val(GridView3.GetFocusedDataRow("AttachId"))
                scnfrm.Show()
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                Return
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


    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        Try
            If GridView4.FocusedValue IsNot Nothing Then
                Dim scnfrm As New ScannerForm
                ScanOrImagetypeProperty = "FromImpAction"
                ImgIdProperty = GridView4.GetFocusedDataRow("ActionId")
                If GridView4.GetFocusedDataRow("Cur_Org") = CurOrgNo Then

                    NewActionOpenFormProperty = "NEW"
                Else
                    NewActionOpenFormProperty = ""


                End If
                scnfrm.Show()
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                Return
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

    Private Sub NewImpForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            NewActionOpenFormProperty = ""

            IsnewselectedorgImpProperty = False
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

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        Try
            'If GridView4.GetFocusedDataRow("Action_Type") = 2 Then
            '    DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن انهاء الاحالة من نفس الجهة الصادر منها")
            'Else
            If GotAdminAuth Then
                Me.Import_ActionTableAdapter.UpdateOpenAction(GridView4.GetFocusedDataRow("ImportId"), GridView4.GetFocusedDataRow("ActionId"))
                Me.Import_ActionTableAdapter.FillByID(Me.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                GridView4.RefreshData()
            Else
                If GridView4.FocusedValue Is Nothing Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                    Return
                Else
                    If GridView4.GetFocusedDataRow("Cur_Org") = CurOrgNo Then
                        Me.Import_ActionTableAdapter.UpdateOpenAction(GridView4.GetFocusedDataRow("ImportId"), GridView4.GetFocusedDataRow("ActionId"))
                        Me.Import_ActionTableAdapter.FillByID(Me.NewDBFDataSet.Import_Action, SelectedImpIDProperty)
                        GridView4.RefreshData()
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن انهاء اجراء صادر من جهة اخرى")

                    End If

                End If
            End If
            'End If
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

    Private Sub TextEdit4_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles TextEdit4.EditValueChanging
        Try

            Dim op As New FindNodesOperation(TreeList1.Columns("Org_Name"), TextEdit4.Text)
            TreeList1.NodesIterator.DoOperation(op)
            Dim result As String = String.Empty
            Dim rd As ArrayList = op.FoundNodes
            'For Each node As TreeListNode In op.FoundNodes
            If rd.Count > 0 Then
                TreeList1.FocusedNode = rd(0)
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

    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SelectDenotePopupTypeProperty = "I_ADD_L"
            Dim DenFrm As New DenoteForm
            DenFrm.Text = "طلب اوليات"
            DenFrm.Show()
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

    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If GridView5.FocusedValue IsNot Nothing Then

        '        If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟ ", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

        '        Me.ElementReqTableAdapter.Delete1(GridView5.GetFocusedDataRow("ImportId"), GridView5.GetFocusedDataRow("ReqByOrg"))
        '        GridView5.DeleteSelectedRows()

        '    Else
        '        DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
        '        Return
        '    End If

        'Catch ex As Exception
        '    Dim trace As New System.Diagnostics.StackTrace(ex, True)
        '    With ErrorTrace1
        '        .SendReport = True
        '        .NotifyLocal = True
        '        .From = rFrom
        '        .SendTo = rSendTo
        '        .SMTPServer = rSMTPServer
        '        .SMTPPass = rSMTPPass
        '        .SMTPUser = rSMTPUser
        '        .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
        '        .LineNumber = trace.GetFrame(0).GetFileLineNumber()
        '        .Ex = ex
        '    End With
        'End Try
    End Sub
End Class
