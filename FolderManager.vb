Public Class FolderManager
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



    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            OPType = "EDIT"
            TextEdit1.EditValue = GridView1.GetFocusedDataRow("Folder_Name").ToString.Trim()
            TextEdit2.EditValue = GridView1.GetFocusedDataRow("Folder_No").ToString.Trim()
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
            Dim i As Int16


            Select Case OPType
                Case "ADD"
                    If TextEdit1.Text = "" Or TextEdit2.Text = "" Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                        Return

                    Else
                        If GridView1.DataRowCount > 0 Then
                            For i = 0 To GridView1.DataRowCount - 1
                                If TextEdit1.Text.Trim = DirectCast(GridView1.GetDataRow(i), WinImpExp.NewDBFDataSet.FolderRow).Folder_Name.Trim Then
                                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول مكرر ... الرجاء التاكد")
                                    Return
                                End If
                            Next
                        End If

                        Me.FolderTableAdapter.InsertFolder(CurOrgNo, TextEdit2.Text, TextEdit1.Text, Year(DateTime.Today))
                        Me.FolderTableAdapter.FillByOrgAndYear(Me.NewDBFDataSet.Folder, CurOrgNo, Year(DateTime.Now))
                        GridView1.RefreshData()
                        TextEdit1.Text = ""
                        TextEdit2.Text = ""
                    End If


                Case "EDIT"
                    If TextEdit1.Text = "" Or TextEdit2.Text = "" Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                        Return

                    Else
                        For i = 0 To GridView1.DataRowCount - 1
                            If TextEdit1.Text.Trim = DirectCast(GridView1.GetDataRow(i), WinImpExp.NewDBFDataSet.FolderRow).Folder_Name.Trim Then
                                DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول مكرر ... الرجاء التاكد")
                                Return
                            End If
                        Next
                        Me.FolderTableAdapter.UpdateFolder(TextEdit2.Text, TextEdit1.Text, GridView1.GetFocusedDataRow("FolderId"))
                        Me.FolderTableAdapter.FillByOrgAndYear(Me.NewDBFDataSet.Folder, CurOrgNo, Year(DateTime.Now))
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

            Me.FolderTableAdapter.DeleteFolder(GridView1.GetFocusedDataRow("FolderId"))
            Me.FolderTableAdapter.FillByOrgAndYear(Me.NewDBFDataSet.Folder, CurOrgNo, Year(DateTime.Now))

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

    Private Sub FolderManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.FolderTableAdapter.FillByOrgAndYear(Me.NewDBFDataSet.Folder, CurOrgNo, Year(DateTime.Now))

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