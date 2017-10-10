Public Class NewElement

    Private Sub NewElement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
        Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Hide()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            If NameTxt.EditValue = "" Or eMailTxt.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة .. الرجاء التاكد")
                Return
            Else
                ElementReqByOrgTableAdapter1.InsertByOrg(NameTxt.EditValue, CurOrgNo, DateTime.Today, 1, eMailTxt.Text, ElementImgTableAdapter1.GetMaxImgId())
                lclfrmImpList2.ElementReqByOrgTableAdapter.Fill(lclfrmImpList2.NewDBFDataSet.ElementReqByOrg, CurOrgNo)
                lclfrmImpList2.GridView1.RefreshData()

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