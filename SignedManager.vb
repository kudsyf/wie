Public Class SignedManager
    Dim OPType As String



    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            OPType = "ADD"
            TextEdit1.Text = ""
            TextEdit2.Text = ""
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
            OPType = ""

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


            Select Case OPType
                Case "ADD"
                    If Not GotAdminAuth Then
                        If TextEdit1.Text = "" Or TextEdit2.Text = "" Then
                            DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                            Return

                        Else
                            Me.To_assignedTableAdapter.Insertsiggned(CurOrgNo, TextEdit1.Text.Trim, TextEdit2.EditValue, CurLogin)
                            Me.To_assignedTableAdapter.Fill(Me.NewDBFDataSet.to_assigned, CurOrgNo)
                        End If
                    Else
                        If TextEdit1.Text = "" Or TextEdit2.Text = "" Or LookUpEdit1.EditValue = Nothing Then
                            DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                            Return

                        Else
                            Me.To_assignedTableAdapter.Insertsiggned(LookUpEdit1.EditValue, TextEdit1.Text.Trim, TextEdit2.EditValue, CurLogin)
                            Me.To_assignedTableAdapter.FillAll(Me.NewDBFDataSet.to_assigned)
                        End If
                    End If

                    GridView1.RefreshData()
                    TextEdit1.Text = ""
                    TextEdit2.Text = ""


            End Select

            OPType = ""
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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

            'Me.FolderTableAdapter.DeleteFolder(GridView1.GetFocusedDataRow("FolderId"))
            'Me.FolderTableAdapter.FillByOrgAndYear(Me.NewDBFDataSet.Folder, CurOrgNo, Year(DateTime.Now))
            Me.To_assignedTableAdapter.Delete1(GridView1.GetFocusedDataRow("owner_Org_No"), GridView1.GetFocusedDataRow("Subject"), GridView1.GetFocusedDataRow("SendToSignedDate"), GridView1.GetFocusedDataRow("userName"))
            If Not GotAdminAuth Then
                Me.To_assignedTableAdapter.Fill(Me.NewDBFDataSet.to_assigned, CurOrgNo)
            Else
                Me.To_assignedTableAdapter.FillAll(Me.NewDBFDataSet.to_assigned)
            End If
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

    Private Sub SignedManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            'TODO: This line of code loads data into the 'NewDBFDataSet.to_assigned' table. You can move, or remove it, as needed.
            If Not GotAdminAuth Then
                Me.To_assignedTableAdapter.Fill(Me.NewDBFDataSet.to_assigned, CurOrgNo)
                GridView1.Columns("owner_Org_No").Visible = False
                LayoutControlItem7.Visibility = True


            Else
                Me.To_assignedTableAdapter.FillAll(Me.NewDBFDataSet.to_assigned)
                GridView1.Columns("owner_Org_No").Visible = True
                LayoutControlItem7.Visibility = False


            End If

            'TODO: This line of code loads data into the 'NewDBFDataSet.to_assigned' table. You can move, or remove it, as needed.

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