Public Class OrgManager
    Dim OPType As String

    Private Sub OrgManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)

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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            OPType = "ADD"
            GroupControl1.Visible = True
            TreeList1.Enabled = False
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
            If Not GotAdminAuth Then
                DevExpress.XtraEditors.XtraMessageBox.Show("لا تملك صلاحيات للح>ف والتعديل")
                Return
            End If
            OPType = "EDIT"
            TextEdit1.EditValue = TreeList1.FocusedNode(0).ToString.Trim
            GroupControl1.Visible = True
            TreeList1.Enabled = False
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
            TreeList1.Enabled = True
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
            Dim parent As String


            Select Case OPType
                Case "ADD"
                    orgno = OrgTableAdapter.GetNexNo().ToString
                    If orgno.Length = 3 Then
                        orgno = "0" + orgno
                    Else
                        If orgno.Length = 2 Then
                            orgno = "00" + orgno
                        Else
                            If orgno.Length = 1 Then
                                orgno = "000" + orgno
                            End If
                        End If
                    End If
                    If TreeList1.AllNodesCount > 0 Then
                        parent = TreeList1.FocusedNode(2).ToString
                    Else
                        parent = "0000"
                    End If
                    If parent = "0006" And Not CanAddPrimeOrgProperty Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن اضافة قسم الى دوائر الهيئة")
                        Return
                    End If

                    If OrgTableAdapter.CheckName(TextEdit1.EditValue) > 0 Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("الاسم مكرر")
                        Return
                    End If
                    OrgTableAdapter.AddOrg(orgno, TextEdit1.EditValue, parent, "")
                    Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
                    TreeList1.RefreshDataSource()
                    TreeList1.Refresh()
                    TextEdit1.EditValue = ""

                Case "EDIT"
                    OrgTableAdapter.UpdateOrg(TextEdit1.EditValue, TreeList1.FocusedNode(2).ToString, TreeList1.FocusedNode(3).ToString)
                    Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
                    TreeList1.RefreshDataSource()
                    TreeList1.Refresh()
                    TextEdit1.EditValue = ""

            End Select

            OPType = ""
            GroupControl1.Visible = False
            TreeList1.Enabled = True
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
            Dim parent As String
            If Not GotAdminAuth Then
                DevExpress.XtraEditors.XtraMessageBox.Show("لا تملك صلاحيات للحذف والتعديل")
                Return
            End If

            If TreeList1.FocusedNode.HasChildren Then
                DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن حذف الجهة لأحتوائها على اقسام وجهات مرتبطة بها")
                Return
            End If
            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

            If TreeList1.AllNodesCount > 0 Then
                parent = TreeList1.FocusedNode(2).ToString
            Else
                parent = "0000"
            End If
            If Parent = "0006" And Not CanAddPrimeOrgProperty Then
                DevExpress.XtraEditors.XtraMessageBox.Show("لا تملك صلاحيات لحذف دائرة من دوائر الهيئة")
                Return
            End If
            OrgTableAdapter.DeleteOrg(TreeList1.FocusedNode(2).ToString, TreeList1.FocusedNode(0).ToString, TreeList1.FocusedNode(3).ToString)
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            TreeList1.RefreshDataSource()
            TreeList1.Refresh()
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