Public Class DeletedExportListForm

    Private Sub DeletedExportListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.Export_To' table. You can move, or remove it, as needed.
            'Me.Export_ToTableAdapter.Fill(Me.NewDBFDataSet.Export_To)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Security' table. You can move, or remove it, as needed.
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Type' table. You can move, or remove it, as needed.
            Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)
            'TODO: This line of code loads data into the 'NewDBFDataSet.ExportDoc' table. You can move, or remove it, as needed.
            Me.ExportDocTableAdapter.FillByList(Me.NewDBFDataSet.ExportDoc, CurOrgNo, 1)
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
            Me.ExportDocTableAdapter.UnDelete(GridView1.GetFocusedDataRow("ExportId"))
            GridView1.DeleteSelectedRows()
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

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Me.ExportDocTableAdapter.DeleteForEver(GridView1.GetFocusedDataRow("Exportid"))
            GridView1.DeleteSelectedRows()
            MainSys.impDelcount.Caption = Me.ExportDocTableAdapter.CountExpDeleted()
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