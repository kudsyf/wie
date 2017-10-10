Public Class EmailManager

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            GroupControl1.Visible = True
            GridControl1.Enabled = False
            SimpleButton1.Enabled = False
            SimpleButton2.Enabled = False
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

            GroupControl1.Visible = False
            GridControl1.Enabled = True
            SimpleButton1.Enabled = True
            SimpleButton2.Enabled = True
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
            Dim i As Int16
            If TextEdit1.Text = "" Or LookUpEdit1.EditValue = Nothing Then
                DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                Return

            Else
                If GridView1.DataRowCount > 0 Then
                    For i = 0 To GridView1.DataRowCount - 1
                        If LookUpEdit1.EditValue.Trim = DirectCast(GridView1.GetDataRow(i), WinImpExp.NewDBFDataSet.orgemailRow).Org.Trim Then
                            DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول مكرر ... الرجاء التاكد")
                            Return
                        End If
                    Next
                End If


                OrgemailTableAdapter.InsertEmail(LookUpEdit1.EditValue, TextEdit1.EditValue, TextEdit2.EditValue)
                Me.OrgemailTableAdapter.Fill(Me.NewDBFDataSet.orgemail)
                GridView1.RefreshData()
                TextEdit1.EditValue = ""

                GroupControl1.Visible = False
                GridControl1.Enabled = True
                SimpleButton1.Enabled = True
                SimpleButton2.Enabled = True
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
            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            OrgemailTableAdapter.DeleteEmail(GridView1.GetFocusedDataRow("Org").ToString)
            Me.OrgemailTableAdapter.Fill(Me.NewDBFDataSet.orgemail)
            GridView1.RefreshData()
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

    Private Sub EmailManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            'TODO: This line of code loads data into the 'NewDBFDataSet.orgshort' table. You can move, or remove it, as needed.
            Me.OrgemailTableAdapter.Fill(Me.NewDBFDataSet.orgemail)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.

            'TODO: This line of code loads data into the 'NewDBFDataSet.orgshort' table. You can move, or remove it, as needed.
            'Me.OrgshortTableAdapter.Fill(Me.NewDBFDataSet.orgshort)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Type' table. You can move, or remove it, as needed.



            GroupControl1.Visible = False

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