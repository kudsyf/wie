Public Class XtraReport_ActionsExp


    Private Sub XtraReport_ActionsExp_ParametersRequestBeforeShow(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
        XrRichText1.Text = CurLogin
    End Sub


End Class