Public Class XtraReport_ActionsImp


    Private Sub XtraReport_ActionsImp_ParametersRequestBeforeShow(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
        XrRichText1.Text = CurLogin
    End Sub


End Class