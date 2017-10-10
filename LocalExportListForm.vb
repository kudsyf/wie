Imports DevExpress.XtraGrid.Views.Grid

Public Class LocalExportListForm

    Private Sub LocalExportListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            lclfrmImpList = Nothing
            ExpActionOpenFormProperty = ""
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


    Private Sub LocalExportListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.Type' table. You can move, or remove it, as needed.
        Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)
        'TODO: This line of code loads data into the 'NewDBFDataSet.Security' table. You can move, or remove it, as needed.
        Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
        'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
        Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)

        Try

            Me.LocalExportToTableAdapter.FillMyOrg(Me.NewDBFDataSet.LocalExportTo, CurOrgNo)


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
                        ExpActionOpenFormProperty = "ACTION"
                        ffrmexp = NewExpForm
                        ffrmexp.SimpleButton1.Enabled = False
                        ffrmexp.SimpleButton2.Enabled = False
                        ffrmexp.SimpleButton3.Enabled = False
                        ffrmexp.SimpleButton4.Enabled = False
                        ffrmexp.SimpleButton8.Enabled = False
                        ffrmexp.SimpleButton9.Enabled = False
                        ffrmexp.SimpleButton5.Enabled = False
                        ffrmexp.SimpleButton13.Enabled = False
                        ffrmexp.SimpleButton11.Enabled = False
                        ffrmexp.SimpleButton12.Enabled = False

                        ExpActionLocalExpIdProperty = GridView1.GetFocusedDataRow("ExportId")
                        ExpActionLocalExpTOProperty = GridView1.GetFocusedDataRow("To_Org_No")
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


    

End Class