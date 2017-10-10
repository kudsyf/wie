Public Class XtraReport_DelaidImp

    Private Sub XtraReport_DelaidImp_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint



    End Sub

    Private Sub XtraReport_DelaidImp_DesignerLoaded(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs) Handles MyBase.DesignerLoaded

    End Sub

    Private Sub XtraReport_DelaidImp_ParametersRequestBeforeShow(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
        XrRichText1.Text = CurLogin
    End Sub

    Private Sub Detail1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)


    End Sub
End Class