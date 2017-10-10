Public Class ElementReqList

    Private Sub XtraForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
        Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
        'TODO: This line of code loads data into the 'NewDBFDataSet.ElementReq1' table. You can move, or remove it, as needed.

        Me.ElementReqByOrgTableAdapter.Fill(Me.NewDBFDataSet.ElementReqByOrg, CurOrgNo)
        Me.ElementReqToOrgTableAdapter.Fill(Me.NewDBFDataSet.ElementReqToOrg, CurOrgNo)
    End Sub




    Private Sub NewElement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewElement.Click
        Try
            Dim elfrm As New NewElement


            elfrm.ShowDialog()
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

    Private Sub ElementView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElementView.Click
        Try
            If GridView1.FocusedValue IsNot Nothing Then

                Dim scnfrm As New ScannerForm
                ScanOrImagetypeProperty = "ElementReq"
                scnfrm.Elimgid = GridView1.GetFocusedDataRow("ImgId")
                scnfrm.Bar2.Visible = False

                scnfrm.Show()
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

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Try
            If GridView2.FocusedValue IsNot Nothing Then

                Dim scnfrm As New ScannerForm
                ScanOrImagetypeProperty = "ElementReq"
                scnfrm.Elimgid = GridView2.GetFocusedDataRow("ImgId")

                scnfrm.Show()
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

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Try

            ElementReqByOrgTableAdapter.SetReject(GridView2.GetFocusedDataRow("ImgId"))
            Me.ElementReqToOrgTableAdapter.Fill(Me.NewDBFDataSet.ElementReqToOrg, CurOrgNo)
            GridView2.RefreshData()

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

 
    Private Sub EndEle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndEle.Click
        Try

            ElementReqByOrgTableAdapter.SetEnd(GridView2.GetFocusedDataRow("ImgId"))
            Me.ElementReqToOrgTableAdapter.Fill(Me.NewDBFDataSet.ElementReqToOrg, CurOrgNo)
            GridView2.RefreshData()

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