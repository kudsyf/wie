Public Class UsersForm
    Dim addFlag As Boolean

    Private Sub UsersForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            addFlag = False

            'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Org_Users' table. You can move, or remove it, as needed.
            Me.Org_UsersTableAdapter.Fill(Me.NewDBFDataSet.Org_Users)

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




    Private Sub Org_Users1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Org_Users1BindingNavigatorSaveItem.Click
        Try

            If Login_NameTextEdit.Text = "" Or LookUpEdit1.EditValue = Nothing Or PassWordTextEdit.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة ... الرجاء التاكد")
                Return

            Else
                If addFlag Then
                    If Me.Org_UsersTableAdapter.CheckDoubleLogin(Login_NameTextEdit.Text.Trim) > 0 Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("اسم الدخول مكرر ... الرجاء التاكد")
                        Return
                    End If
                End If
                addFlag = False

                If Enable_LoginCheckEdit.EditValue.ToString = "" Then
                    Enable_LoginCheckEdit.EditValue = 0

                End If
                Me.Validate()
                Me.Org_Users1BindingSource.EndEdit()
                Me.Org_UsersTableAdapter.Update(Me.NewDBFDataSet)

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

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            If Login_NameTextEdit.Text.Trim = "admin" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن حذف مدير قاعدة البيانات")
                Return

            End If
            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            If (Org_Users1BindingSource.Count > 0) Then
                Org_Users1BindingSource.RemoveCurrent()
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

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        addFlag = True

    End Sub
End Class