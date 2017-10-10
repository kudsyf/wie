Public Class MembersManager
    Dim OPType As String



    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            OPType = "ADD"
            TextEdit1.EditValue = ""
            LookUpEdit1.EditValue = ""
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
        'DevExpress.XtraEditors.XtraMessageBox.Show(TreeList1.FocusedNode(3).ToString)
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

            Dim i As Int16

            Select Case OPType
                Case "ADD"

                    If TextEdit1.Text = "" Or LookUpEdit1.EditValue Is Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                        Return

                    Else
                        If GridView1.DataRowCount > 0 Then
                            For i = 0 To GridView1.DataRowCount - 1
                                If TextEdit1.Text.Trim = DirectCast(GridView1.GetDataRow(i), WinImpExp.NewDBFDataSet.OrgMembersRow).MemberName.Trim Then
                                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول مكرر ... الرجاء التاكد")
                                    Return
                                End If
                            Next
                        End If

                        Me.OrgMembersTableAdapter.InsertNewMember(TextEdit1.EditValue, LookUpEdit1.EditValue)
                        Me.OrgMembersTableAdapter.Fill(Me.NewDBFDataSet.OrgMembers)
                        GridView1.RefreshData()
                        TextEdit1.EditValue = ""
                        LookUpEdit1.EditValue = ""
                    End If
               
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

            OrgMembersTableAdapter.DeleteMember(CInt(GridView1.GetFocusedDataRow("MemberId").ToString))
            Me.OrgMembersTableAdapter.Fill(Me.NewDBFDataSet.OrgMembers)

         
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

    Private Sub MembersManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
              Try
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            'TODO: This line of code loads data into the 'NewDBFDataSet.OrgMembers' table. You can move, or remove it, as needed.
            Me.OrgMembersTableAdapter.Fill(Me.NewDBFDataSet.OrgMembers)

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