Public Class SecurityManager
    Dim OPType As String



    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Try


            OPType = "ADD"
            GroupControl1.Visible = True
            GridControl1.Enabled = False
            SimpleButton1.Enabled = False
            SimpleButton2.Enabled = False
            SimpleButton3.Enabled = False
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
        'DevExpress.XtraEditors.XtraMessageBox.Show(TreeList1.FocusedNode(3).ToString)
    End Sub



    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            OPType = "EDIT"
            TextEdit1.EditValue = GridView1.FocusedValue.ToString.Trim
            GroupControl1.Visible = True
            GridControl1.Enabled = False
            SimpleButton1.Enabled = False
            SimpleButton2.Enabled = False
            SimpleButton3.Enabled = False
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
            OPType = ""

            GroupControl1.Visible = False
            GridControl1.Enabled = True
            SimpleButton1.Enabled = True
            SimpleButton2.Enabled = True
            SimpleButton3.Enabled = True
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
            Dim orgno As String
            Dim i As Int16

            Select Case OPType
                Case "ADD"
                    orgno = SecurityTableAdapter.GetNextNo().ToString
                    If TextEdit1.Text = "" Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                        Return

                    Else
                        If GridView1.DataRowCount > 0 Then
                            For i = 0 To GridView1.DataRowCount - 1
                                If TextEdit1.Text.Trim = DirectCast(GridView1.GetDataRow(i), WinImpExp.NewDBFDataSet.SecurityRow).Security.Trim Then
                                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول مكرر ... الرجاء التاكد")
                                    Return
                                End If
                            Next
                        End If

                        SecurityTableAdapter.Insert(orgno, TextEdit1.EditValue)
                        Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
                        GridView1.RefreshData()
                        TextEdit1.EditValue = ""
                    End If
                Case "EDIT"
                    If TextEdit1.Text = "" Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                        Return

                    Else
                        For i = 0 To GridView1.DataRowCount - 1
                            If TextEdit1.Text.Trim = DirectCast(GridView1.GetDataRow(i), WinImpExp.NewDBFDataSet.SecurityRow).Security.Trim Then
                                DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول مكرر ... الرجاء التاكد")
                                Return
                            End If
                        Next
                        SecurityTableAdapter.Update(TextEdit1.EditValue, GridView1.GetFocusedDataRow("Security_Code").ToString, GridView1.GetFocusedDataRow("Security").ToString)

                        Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
                        GridView1.RefreshData()

                        TextEdit1.EditValue = ""
                    End If
            End Select

            OPType = ""
            GroupControl1.Visible = False
            GridControl1.Enabled = True
            SimpleButton1.Enabled = True
            SimpleButton2.Enabled = True
            SimpleButton3.Enabled = True
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
            SecurityTableAdapter.Delete(GridView1.GetFocusedDataRow("Security_Code").ToString, GridView1.GetFocusedDataRow("Security").ToString)
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
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

    Private Sub SecurityManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.Security' table. You can move, or remove it, as needed.
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Type' table. You can move, or remove it, as needed.

            'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.

            GroupControl1.Visible = False
            OPType = ""
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