Public Class XtraReport_DeletedImp

    Private Sub XtraReport_DeletedImp_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint


    End Sub

    Private Sub XtraReport_DeletedImp_DesignerLoaded(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs) Handles MyBase.DesignerLoaded

    End Sub

    Private Sub XtraReport_DeletedImp_ParametersRequestBeforeShow(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
        XrRichText1.Text = CurLogin
    End Sub
End Class