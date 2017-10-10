


Public Class LoadingFrm
    Public NewWidth As Integer
    Public NewHeight As Integer


    Public ReadOnly Property Marquee() As DevExpress.XtraEditors.MarqueeProgressBarControl
        Get
            Return MarqueeProgressBarControl1
        End Get
    End Property



    Private Sub LoadingFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'PictureBox1.BackColor = System.Drawing.Color.Transparent
            'PictureBox1.Image = Image.FromFile("C:\1.gif")
            'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            MarqueeProgressBarControl1.Text = "انتظر رجاءا "
            Me.TopMost = True

            Me.Location = New Point(NewWidth, NewHeight)
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


        End

    End Sub
End Class