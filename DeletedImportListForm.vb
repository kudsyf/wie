Imports DevExpress.XtraGrid.Views.Grid

Public Class DeletedImportListForm


    Private Sub DeletedImportListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            Me.ImportDocTableAdapter.FillBy1(Me.NewDBFDataSet.ImportDoc, CurOrgNo, 1)
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


            Me.ImportDocTableAdapter.DeleteForEver(GridView1.GetFocusedDataRow("ImportId"))
            GridView1.DeleteSelectedRows()
            MainSys.impDelcount.Caption = Me.ImportDocTableAdapter.CountDeleted()


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


    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If Me.ImportDocTableAdapter.IsImportNoUsed(GridView1.GetFocusedDataRow("Import_No").ToString.Trim) > 0 Then
                Dim newimpno As New NewImportNoForm
                newimpno.ShowDialog()
                If newimpno.NewImp <> -1 Then
                    Me.ImportDocTableAdapter.UnDeleteNew(newimpno.NewImp, GridView1.GetFocusedDataRow("ImportId"))
                    GridView1.DeleteSelectedRows()
                    MainSys.impDelcount.Caption = Me.ImportDocTableAdapter.CountDeleted()
                End If


            Else
                Me.ImportDocTableAdapter.UnDelete(GridView1.GetFocusedDataRow("ImportId"))
                GridView1.DeleteSelectedRows()
                MainSys.impDelcount.Caption = Me.ImportDocTableAdapter.CountDeleted()
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