Imports DevExpress.XtraGrid.Views.Grid

Public Class ImportListForm

    Private Sub ImportListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            frmImpList = Nothing
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
    Private Sub BuildBar()

        LabelMin.Text = Me.ImportDocDatesTableAdapter1.GetMin

        LabelMax.Text = Me.ImportDocDatesTableAdapter1.GetMax

        RangeTrackBarControl1.Properties.Minimum = 0
        RangeTrackBarControl1.Properties.Maximum = Me.ImportDocDatesTableAdapter1.DatesCount - 1

        If Me.ImportDocDatesTableAdapter1.DatesCount > 31 Then
            RangeTrackBarControl1.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(RangeTrackBarControl1.Properties.Maximum - 30, RangeTrackBarControl1.Properties.Maximum)

        Else
            If Me.ImportDocDatesTableAdapter1.DatesCount < 2 Then
                RangeTrackBarControl1.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(RangeTrackBarControl1.Properties.Minimum, RangeTrackBarControl1.Properties.Maximum)

            Else
                RangeTrackBarControl1.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(RangeTrackBarControl1.Properties.Maximum - Me.ImportDocDatesTableAdapter1.DatesCount, RangeTrackBarControl1.Properties.Maximum)

            End If

        End If


    End Sub

    Private Sub ImportListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.ImportDocWithTrans1' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'NewDBFDataSet.ImportDocWithTrans' table. You can move, or remove it, as needed.
        
        BuildBar()

        CheckEdit1.Enabled = GotAdminAuth


        'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.

        Try
            Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)
         Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            Me.ImportDocWithTrans1TableAdapter.Fill(Me.NewDBFDataSet.ImportDocWithTrans1)
            If Me.ImportDocDatesTableAdapter1.GetData().Count <> 0 Then


                If CheckEdit1.EditValue Then
                    If Me.ImportDocDatesTableAdapter1.GetData().Count < 2 Then
                        Me.ImportDocWithTrans1TableAdapter.FillByDateRangeAdmin(Me.NewDBFDataSet.ImportDocWithTrans1, 0, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

                    Else
                        Me.ImportDocWithTrans1TableAdapter.FillByDateRangeAdmin(Me.NewDBFDataSet.ImportDocWithTrans1, 0, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

                    End If
         
                Else
                    If Me.ImportDocDatesTableAdapter1.GetData().Count < 2 Then
                        Me.ImportDocWithTrans1TableAdapter.FillByDateRangeAndOrg(Me.NewDBFDataSet.ImportDocWithTrans1, CurOrgNo, 0, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

                    Else

                        Me.ImportDocWithTrans1TableAdapter.FillByDateRangeAndOrg(Me.NewDBFDataSet.ImportDocWithTrans1, CurOrgNo, 0, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

                    End If

                End If


            End If

            GridView1.OptionsBehavior.AllowDeleteRows = True
            GridView1.OptionsBehavior.Editable = False
            MainSys.impDelcount.Caption = Me.ImportDocTableAdapter.CountDeleted()
            MainSys.expdelcount.Caption = Me.ExportDocTableAdapter.CountExpDeleted()
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



    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        Try
            If (e.KeyCode = Keys.Delete) Then
                If (DevExpress.XtraEditors.XtraMessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

                Dim view As GridView = CType(sender, GridView)
                view.DeleteRow(view.FocusedRowHandle)
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

    Private Sub GridView1_ShowGridMenu(ByVal sender As System.Object, ByVal e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Try
            If e.MenuType = GridMenuType.Row Then
                Dim View As GridView = CType(sender, GridView)
                Dim HitInfo As ViewInfo.GridHitInfo
                HitInfo = View.CalcHitInfo(e.Point)
                If HitInfo.InRow Then
                    View.FocusedRowHandle = HitInfo.RowHandle
                    ContextMenuStrip1.Show(View.GridControl, e.Point)
                End If

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


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If GridView1.FocusedValue IsNot Nothing Then
                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

                Me.ImportDocTableAdapter.Delete1(GridView1.GetFocusedDataRow("ImportId"))
                GridView1.DeleteSelectedRows()
                MainSys.impDelcount.Caption = Me.ImportDocTableAdapter.CountDeleted()
                SaveSession(SessionType.DelImp)
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

    Private Sub ImportGridControl_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportGridControl.DoubleClick
        Try
            Dim tmp As String
            'If GridView1.FocusedValue IsNot Nothing Then
            If GridView1.SelectedRowsCount > 0 And GridView1.FocusedValue <> Nothing Then
                tmp = GridView1.GetFocusedDataRow("ImportId")
                If tmp <> Nothing Then
                    SelectedImpIDProperty = tmp
                    If SelectedImpIDProperty <> "" Then
                        EditOrAddProperty = "EDIT"

                        ffrm = NewImpForm
                        ActionOpenFormProperty = ""
                        ffrm.Show()
                    End If

                End If
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



    Private Sub FollowupMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FollowupMenu.Click
        Try
            If GridView1.FocusedValue IsNot Nothing Then
                FollowSelectedImpIDProperty = GridView1.GetFocusedDataRow("ImportId")
                FollowTypeProperty = "Imp"
                Dim flfrm As New FollowupForm
                flfrm.Show()
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

  
    Private Sub RangeTrackBarControl1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RangeTrackBarControl1.EditValueChanged
        LabelControl1.Text = Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1
        LabelControl2.Text = Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If CheckEdit1.EditValue Then
            Me.ImportDocWithTrans1TableAdapter.FillByDateRangeAdmin(Me.NewDBFDataSet.ImportDocWithTrans1, 0, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

        Else
            Me.ImportDocWithTrans1TableAdapter.FillByDateRangeAndOrg(Me.NewDBFDataSet.ImportDocWithTrans1, CurOrgNo, 0, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

        End If
        GridView1.RefreshData()

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged

        GridView1.Columns("_Owner_Org_No").Visible = CheckEdit1.EditValue

        If CheckEdit1.EditValue Then
            Me.ImportDocWithTrans1TableAdapter.FillByDateRangeAdmin(Me.NewDBFDataSet.ImportDocWithTrans1, 0, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

        Else
            Me.ImportDocWithTrans1TableAdapter.FillByDateRangeAndOrg(Me.NewDBFDataSet.ImportDocWithTrans1, CurOrgNo, 0, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ImportDocDatesTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

        End If
        GridView1.RefreshData()

    End Sub

    Private Sub GridView1_CustomUnboundColumnData(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        If e.Column.FieldName = "Foldrnr" Then

            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim row As DataRow = gv.GetDataRow(e.RowHandle)
            If row Is Nothing Then Return
            Dim fid As Integer = CInt(Import_FolderTableAdapter1.GetFolderByImportId(CInt(row.Item("ImportId"))))
            e.Value = FolderTableAdapter1.GetFolderNo(fid)
        End If

        If e.Column.FieldName = "Foldernm" Then

            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim row As DataRow = gv.GetDataRow(e.RowHandle)
            If row Is Nothing Then Return
            Dim fid As Integer = CInt(Import_FolderTableAdapter1.GetFolderByImportId(CInt(row.Item("ImportId"))))
            e.Value = FolderTableAdapter1.GetFolderName(fid)
        End If

    End Sub
End Class