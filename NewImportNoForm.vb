Public Class NewImportNoForm

    Public NewImp As Integer

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        NewImp = -1
        Me.Hide()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        NewImp = CInt(Val(LookUpEdit1.EditValue.ToString.Trim))
        Me.Hide()

    End Sub

    Private Sub NewImportNoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GapsImportTableAdapter1.Fill(Me.NewDBFDataSet.GapsImport, CurOrgNo, Year(DateTime.Today))

    End Sub
End Class