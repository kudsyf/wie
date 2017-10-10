Public Class ExportListForm

    Private Sub ExportListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            frmExpList = Nothing
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

        LabelMin.Text = Me.ExportDocDateTableAdapter1.GetMin

        LabelMax.Text = Me.ExportDocDateTableAdapter1.GetMax

        RangeTrackBarControl1.Properties.Minimum = 0
        RangeTrackBarControl1.Properties.Maximum = Me.ExportDocDateTableAdapter1.DatesCount - 1

        If Me.ExportDocDateTableAdapter1.DatesCount > 31 Then
            RangeTrackBarControl1.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(RangeTrackBarControl1.Properties.Maximum - 30, RangeTrackBarControl1.Properties.Maximum)

        Else
            If Me.ExportDocDateTableAdapter1.DatesCount < 2 Then
                RangeTrackBarControl1.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(RangeTrackBarControl1.Properties.Minimum, RangeTrackBarControl1.Properties.Maximum)

            Else
                RangeTrackBarControl1.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(RangeTrackBarControl1.Properties.Maximum - Me.ExportDocDateTableAdapter1.DatesCount, RangeTrackBarControl1.Properties.Maximum)


            End If


        End If
    End Sub

    Private Sub ExportListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
        Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
        'TODO: This line of code loads data into the 'NewDBFDataSet.Export_To2' table. You can move, or remove it, as needed.
        Me.Export_To2TableAdapter.Fill(Me.NewDBFDataSet.Export_To2)

        BuildBar()
        CheckEdit1.Enabled = GotAdminAuth

        'TODO: This line of code loads data into the 'NewDBFDataSet.Export_To1' table. You can move, or remove it, as needed.

        'Dim keyColumn As DataColumn = NewDBFDataSet.Tables("ExportDoc").Columns("ExportId")
        'Dim foreignKeyColumn As DataColumn = NewDBFDataSet.Tables("Export_To").Columns("ExportId")
        'NewDBFDataSet.Relations.Add("CategoriesProducts", keyColumn, foreignKeyColumn)


        Try
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)

            If Me.ExportDocDateTableAdapter1.GetData().Count <> 0 Then
                If CheckEdit1.EditValue Then
                    If Me.ExportDocDateTableAdapter1.GetData().Count < 2 Then
                        Me.ExportDocTableAdapter.FillByRangeExpAdmin(Me.NewDBFDataSet.ExportDoc, 0, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)
                    Else
                        Me.ExportDocTableAdapter.FillByRangeExpAdmin(Me.NewDBFDataSet.ExportDoc, 0, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

                    End If
                Else
                    If Me.ExportDocDateTableAdapter1.GetData().Count < 2 Then
                        Me.ExportDocTableAdapter.FillByRangeByOrg(Me.NewDBFDataSet.ExportDoc, CurOrgNo, 0, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

                    Else
                        Me.ExportDocTableAdapter.FillByRangeByOrg(Me.NewDBFDataSet.ExportDoc, CurOrgNo, 0, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

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

    Private Sub ImportGridControl_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportGridControl.DoubleClick
        Try
            Dim tmp As String
            If GridView1.SelectedRowsCount > 0 And GridView1.FocusedValue <> Nothing Then
                tmp = GridView1.GetFocusedDataRow("ExportId")
                If tmp <> Nothing Then
                    SelectedExpIDProperty = tmp
                    If SelectedExpIDProperty <> "" Then
                        EditOrAddexpProperty = "EDIT"

                        ffrmexp = NewExpForm
                        ffrmexp.Show()
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



    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If GridView1.FocusedValue IsNot Nothing Then
                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                Me.ExportDocTableAdapter.DeleteExport(GridView1.GetFocusedDataRow("ExportId"))
                GridView1.DeleteSelectedRows()
                MainSys.impDelcount.Caption = Me.ExportDocTableAdapter.ExpCountDeleted()
                SaveSession(SessionType.DelExp)
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

    Private Sub followmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles followmenu.Click
        Try
            If GridView1.FocusedValue IsNot Nothing Then
                FollowSelectedImpIDProperty = GridView1.GetFocusedDataRow("ExportId")
                FollowTypeProperty = "Exp"
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If CheckEdit1.EditValue Then
            Me.ExportDocTableAdapter.FillByRangeExpAdmin(Me.NewDBFDataSet.ExportDoc, 0, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

        Else
            Me.ExportDocTableAdapter.FillByRangeByOrg(Me.NewDBFDataSet.ExportDoc, CurOrgNo, 0, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

        End If
        GridView1.RefreshData()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged

        GridView1.Columns("Owner_Org_No").Visible = CheckEdit1.EditValue

        If CheckEdit1.EditValue Then
            Me.ExportDocTableAdapter.FillByRangeExpAdmin(Me.NewDBFDataSet.ExportDoc, 0, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

        Else
            Me.ExportDocTableAdapter.FillByRangeByOrg(Me.NewDBFDataSet.ExportDoc, CurOrgNo, 0, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1, Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1)

        End If
        GridView1.RefreshData()
    End Sub

    Private Sub RangeTrackBarControl1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RangeTrackBarControl1.EditValueChanged
        LabelControl1.Text = Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Minimum).Column1
        LabelControl2.Text = Me.ExportDocDateTableAdapter1.GetData(RangeTrackBarControl1.Value.Maximum).Column1
    End Sub


End Class