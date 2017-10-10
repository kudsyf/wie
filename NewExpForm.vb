Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraTreeList.Nodes.Operations
Imports DevExpress.XtraTreeList.Columns
Imports System.Collections
Imports DevExpress.XtraTreeList.Nodes
Public Class NewExpForm
    Dim tagList(200) As String
    Private Sub NewExpForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ActionsTableAdapter.Fill(Me.NewDBFDataSet.Actions)
            Me.OrgshortTableAdapter.Fill(Me.NewDBFDataSet.orgshort)
            Me.Export_AttachmentTableAdapter.FillByID(Me.NewDBFDataSet.Export_Attachment, SelectedExpIDProperty)
            Me.Export_To1TableAdapter.Fill(Me.NewDBFDataSet.Export_To1)
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)
            If EditOrAddexpProperty = "EDIT" Then
                Me.Export_ActionTableAdapter.FillByID(Me.NewDBFDataSet.Export_Action, SelectedExpIDProperty)
                If GotAdminAuth Then
                    Me.ExportDocTableAdapter.FillByExpAdmin(Me.NewDBFDataSet.ExportDoc, SelectedExpIDProperty)
                Else
                    Me.ExportDocTableAdapter.FillByExp(Me.NewDBFDataSet.ExportDoc, SelectedExpIDProperty, CurOrgNo)
                End If
                Me.Export_ToTableAdapter.FillByExp(Me.NewDBFDataSet.Export_To, SelectedExpIDProperty)
                Me.Export_DenoteETableAdapter.ExportFill_E(Me.NewDBFDataSet.Export_DenoteE, SelectedExpIDProperty)
                Me.Export_DenoteITableAdapter.ExportFill_I(Me.NewDBFDataSet.Export_DenoteI, SelectedExpIDProperty)
                DateEdit1.Enabled = False
                LayoutControlItem28.Visibility = False
                LayoutControlItem4.Visibility = True
                TextEdit11.Enabled = False
                PopupContainerEdit1.Enabled = True
                SimpleButton7.Enabled = True
                UsedExportIdProperty = SelectedExpIDProperty
            End If
            If EditOrAddexpProperty = "NEW" Then
                LayoutControlItem28.Visibility = True
                LayoutControlItem4.Visibility = False
                PopupContainerEdit1.Enabled = False
                SimpleButton7.Enabled = False
                SimpleButton6.Enabled = False
                XtraTabControl2.Enabled = False
                DateEdit1.EditValue = Date.Today
                If IsnewselectedorgImpProperty Then
                    Me.GapsTableAdapter.Fill(NewDBFDataSet.Gaps, NewselectedorgImpProperty, Year(DateTime.Today))
                    Dim rr2 As New EditorButton(ButtonPredefines.Glyph, Me.OrgshortTableAdapter.GetShort(NewselectedorgImpProperty), -1, True, True, False, HorzAlignment.Far, Nothing, Nothing, New DevExpress.Utils.AppearanceObject, Nothing)
                    rr2.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
                    rr2.Appearance.BackColor = Color.White
                    rr2.Appearance.Options.UseBackColor = True
                    TextEdit1.Properties.ButtonsStyle = BorderStyles.Flat
                    TextEdit1.Properties.Buttons.Add(rr2)
                    Dim rr As New EditorButton(ButtonPredefines.Glyph, "هـ . أ", -1, True, True, False, HorzAlignment.Far, Nothing, Nothing, New DevExpress.Utils.AppearanceObject, Nothing)
                    rr.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
                    rr.Appearance.BackColor = Color.White
                    rr.Appearance.Options.UseBackColor = True
                    TextEdit1.Properties.ButtonsStyle = BorderStyles.Flat
                    TextEdit1.Properties.Buttons.Add(rr)
                    If TextEdit1.Text = "" Then
                        TextEdit1.SelectedText = "1"
                        TextEdit1.EditValue = 1
                        TextEdit1.Text = "1"
                    End If
                Else
                    Me.GapsTableAdapter.Fill(NewDBFDataSet.Gaps, CurOrgNo, Year(DateTime.Today))
                    Dim rr2 As New EditorButton(ButtonPredefines.Glyph, Me.OrgshortTableAdapter.GetShort(CurOrgNo), -1, True, True, False, HorzAlignment.Far, Nothing, Nothing, New DevExpress.Utils.AppearanceObject, Nothing)
                    rr2.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
                    rr2.Appearance.BackColor = Color.White
                    rr2.Appearance.Options.UseBackColor = True
                    TextEdit1.Properties.ButtonsStyle = BorderStyles.Flat
                    TextEdit1.Properties.Buttons.Add(rr2)
                    Dim rr As New EditorButton(ButtonPredefines.Glyph, "هـ.أ", -1, True, True, False, HorzAlignment.Far, Nothing, Nothing, New DevExpress.Utils.AppearanceObject, Nothing)
                    rr.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
                    rr.Appearance.BackColor = Color.White
                    rr.Appearance.Options.UseBackColor = True
                    TextEdit1.Properties.ButtonsStyle = BorderStyles.Flat
                    TextEdit1.Properties.Buttons.Add(rr)
                    If TextEdit1.Text = "" Then
                        TextEdit1.SelectedText = "1"
                        TextEdit1.EditValue = 1
                        TextEdit1.Text = "1"
                    End If
                End If
                UsedExportIdProperty = Val(Me.ExportDocTableAdapter.GetMaxExportId() + 1)
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
                Me.Export_DenoteITableAdapter.DeleteI(GridView1.GetFocusedDataRow("ExportId"), GridView1.GetFocusedDataRow("Book_No"), GridView1.GetFocusedDataRow("Book_Date"))
                GridView1.DeleteSelectedRows()
                SaveSession(SessionType.DelExpDenote)
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
                Me.Export_DenoteETableAdapter.DeleteE(GridView2.GetFocusedDataRow("ExportId"), GridView2.GetFocusedDataRow("Book_No"), GridView2.GetFocusedDataRow("Book_Date"))
                GridView2.DeleteSelectedRows()
                SaveSession(SessionType.DelExpDenote)
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
            SelectDenotePopupTypeProperty = "I_ADD_E"
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
            SelectDenotePopupTypeProperty = "E_ADD_E"
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

            If EditOrAddexpProperty = "EDIT" Then
                If TextEdit11.EditValue = Nothing Or DateEdit1.EditValue = Nothing Or LookUpEdit1.EditValue = Nothing Or LookUpEdit2.EditValue = Nothing Or MemoEdit1.Text = "" Or TextEdit2.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول الاساسية فارغة... لا يمكن الحفظ")
                Else
                    Me.ExportDocTableAdapter.UpdateExport(LookUpEdit1.EditValue, LookUpEdit2.EditValue, TextEdit2.Text, MemoEdit1.Text, UsedExportIdProperty)
                    For Each frmee As Form In MainSys.MdiChildren
                        If frmee.Name = "ExportListForm" Then
                            If frmExpList.CheckEdit1.EditValue Then
                                If frmExpList.ExportDocDateTableAdapter1.GetData().Count < 2 Then
                                    frmExpList.ExportDocTableAdapter.FillByRangeExpAdmin(frmExpList.NewDBFDataSet.ExportDoc, 0, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Minimum).Column1, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Maximum).Column1)
                                Else
                                    frmExpList.ExportDocTableAdapter.FillByRangeExpAdmin(frmExpList.NewDBFDataSet.ExportDoc, 0, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Minimum).Column1, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Maximum).Column1)
                                End If
                            Else
                                If frmExpList.ExportDocDateTableAdapter1.GetData().Count < 2 Then
                                    Me.ExportDocTableAdapter.FillByRangeByOrg(frmExpList.NewDBFDataSet.ExportDoc, CurOrgNo, 0, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Minimum).Column1, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Maximum).Column1)
                                Else
                                    Me.ExportDocTableAdapter.FillByRangeByOrg(frmExpList.NewDBFDataSet.ExportDoc, CurOrgNo, 0, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Minimum).Column1, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Maximum).Column1)
                                End If
                            End If
                            frmExpList.GridView1.RefreshData()
                        End If
                    Next
                    SaveSession(SessionType.EditExp)
                End If
            End If
            If EditOrAddexpProperty = "NEW" Then
                If TextEdit1.EditValue = Nothing Or DateEdit1.EditValue = Nothing Or LookUpEdit1.EditValue = Nothing Or LookUpEdit2.EditValue = Nothing Or MemoEdit1.Text = "" Or TextEdit2.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول الاساسية فارغة... لا يمكن الحفظ")
                Else
                    UsedExportIdProperty = Val(Me.ExportDocTableAdapter.GetMaxExportId() + 1)
                    Dim ssd As String
                    ssd = TextEdit1.Properties.Buttons(2).Caption.Trim() + "/" + TextEdit1.Properties.Buttons(1).Caption.Trim() + "/" + TextEdit1.EditValue.ToString.Trim()
                    If IsnewselectedorgImpProperty Then
                        Me.ExportDocTableAdapter.InsertExport(NewselectedorgImpProperty, UsedExportIdProperty, ssd, DateEdit1.EditValue, LookUpEdit1.EditValue.ToString(), LookUpEdit2.EditValue.ToString(), TextEdit2.Text, MemoEdit1.Text, False, False, False, CurLogin, Date.Today, CurLogin, Date.Today)
                    Else
                        Me.ExportDocTableAdapter.InsertExport(CurOrgNo, UsedExportIdProperty, ssd, DateEdit1.EditValue, LookUpEdit1.EditValue.ToString(), LookUpEdit2.EditValue.ToString(), TextEdit2.Text, MemoEdit1.Text, False, False, False, CurLogin, Date.Today, CurLogin, Date.Today)
                        IsnewselectedorgImpProperty = False
                        For Each frmee As Form In MainSys.MdiChildren
                            If frmee.Name = "ExportListForm" Then
                                If frmExpList.CheckEdit1.EditValue Then
                                    If frmExpList.ExportDocDateTableAdapter1.GetData().Count < 2 Then
                                        frmExpList.ExportDocTableAdapter.FillByRangeExpAdmin(frmExpList.NewDBFDataSet.ExportDoc, 0, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Minimum).Column1, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Maximum).Column1)
                                    Else
                                        frmExpList.ExportDocTableAdapter.FillByRangeExpAdmin(frmExpList.NewDBFDataSet.ExportDoc, 0, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Minimum).Column1, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Maximum).Column1)
                                    End If
                                Else
                                    If frmExpList.ExportDocDateTableAdapter1.GetData().Count < 2 Then
                                        Me.ExportDocTableAdapter.FillByRangeByOrg(frmExpList.NewDBFDataSet.ExportDoc, CurOrgNo, 0, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Minimum).Column1, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Maximum).Column1)
                                    Else
                                        Me.ExportDocTableAdapter.FillByRangeByOrg(frmExpList.NewDBFDataSet.ExportDoc, CurOrgNo, 0, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Minimum).Column1, frmExpList.ExportDocDateTableAdapter1.GetData(frmExpList.RangeTrackBarControl1.Value.Maximum).Column1)
                                    End If
                                End If
                                frmExpList.GridView1.RefreshData()
                            End If
                        Next
                    End If
                    PopupContainerEdit1.Enabled = True
                    SimpleButton7.Enabled = True
                    SimpleButton6.Enabled = True
                    SelectedExpIDProperty = UsedExportIdProperty
                    XtraTabControl2.Enabled = True
                    SaveSession(SessionType.NewExp)
                    TextEdit1.Enabled = False
                    DateEdit1.Enabled = False
                    EditOrAddexpProperty = "EDIT"
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
            Export_To1TableAdapter.InsertQuery(UsedExportIdProperty, PopupContainerEdit1.Tag)



            Me.Export_ToTableAdapter.FillByExp(Me.NewDBFDataSet.Export_To, UsedExportIdProperty)
            GridView4.RefreshData()
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
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Try
            Me.Export_To1TableAdapter.DeleteQuery(UsedExportIdProperty, GridView4.GetFocusedDataRow(1).ToString())
            GridView4.DeleteSelectedRows()
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
            Dim scnfrm As New ScannerForm
            ScanOrImagetypeProperty = "FromOrginExp"
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
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        Try
            SelectDenotePopupTypeProperty = "E_ADD_A"
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
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        Try
            If GridView3.FocusedValue IsNot Nothing Then
                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟ ", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                Me.Export_AttachmentTableAdapter.Delete(GridView3.GetFocusedDataRow("ExportId"), GridView3.GetFocusedDataRow("AttachId"), GridView3.GetFocusedDataRow("Attachment"))
                Me.Export_ImageTableAdapter.DeleteByType(GridView3.GetFocusedDataRow("ExportId"), "Attach", GridView3.GetFocusedDataRow("AttachId"))
                GridView3.DeleteSelectedRows()
                SaveSession(SessionType.DelExpAttach)
                SaveSession(SessionType.DelExpAttachImg)
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
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        Try
            If GridView3.FocusedValue IsNot Nothing Then
                Dim scnfrm As New ScannerForm
                ScanOrImagetypeProperty = "FromExpAttach"
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
    Private Sub NewExpForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
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
    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton14.Click
        Try
            Dim actfrme As New NewExpActionForm
            actfrme.Show()
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
            If GridView5.FocusedValue IsNot Nothing Then
                Dim dell As Int32
                Dim Actt As Int32
                dell = GridView5.GetFocusedDataRow("ExportId")
                Actt = GridView5.GetFocusedDataRow("ActionId")
                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                Me.Export_ActionTableAdapter.DeleteByID(dell, Actt)
                GridView5.DeleteSelectedRows()
                SaveSession(SessionType.DelExpAction)
                Me.Export_ImageTableAdapter.DeleteByType(dell, "Action", Actt)
                SaveSession(SessionType.DelExpActionImg)
                Me.ExportFolderSeqGapsTableAdapter.DeletefolderSeq(dell)
                SaveSession(SessionType.DelExpFolder)
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
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        Try
            If GridView5.FocusedValue IsNot Nothing Then
                Dim scnfrme As New ScannerForm
                ScanOrImagetypeProperty = "FromExpAction"
                ImgIdProperty = GridView5.GetFocusedDataRow("ActionId")
                scnfrme.Show()
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
    Private Sub TextEdit3_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles TextEdit3.EditValueChanging
        Try
            Dim op As New FindNodesOperation(TreeList1.Columns("Org_Name"), TextEdit3.Text)
            TreeList1.NodesIterator.DoOperation(op)
            Dim result As String = String.Empty
            Dim rd As ArrayList = op.FoundNodes
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
End Class
Public Class FindNodesOperation
    Inherits TreeListOperation
    Private column As TreeListColumn
    Private value As Object
    Dim ErrorTrace1 As New ErrorTrace
    Private list As ArrayList
    Public Sub New(ByVal column As TreeListColumn, ByVal value As Object)
        list = New ArrayList()
        Me.column = column
        Me.value = value
    End Sub
    Public Overrides Sub Execute(ByVal node As TreeListNode)
        Try
            If ((value IsNot Nothing)) And Strings.InStr(node(column).ToString, value.ToString) > 0 Then
                list.Add(node)
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
    Public ReadOnly Property FoundNodes() As ArrayList
        Get
            Return list
        End Get
    End Property
End Class
