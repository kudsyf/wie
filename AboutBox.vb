Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.AxShockwaveFlash1.Top = Me.Top
        'Me.AxShockwaveFlash1.Left = Me.Left
        'Me.AxShockwaveFlash1.Width = Me.Width
        ''Make sure you over write the taskbar gap at the bottom
        'Me.AxShockwaveFlash1.Height = Me.Height + 28
        'Me.AxShockwaveFlash1.AllowFullScreen = True
        'Me.Width = Me.AxShockwaveFlash1.Width - 6
        'Me.AxShockwaveFlash1.BackgroundColor = 0

        'Me.AxShockwaveFlash1.Movie = Application.StartupPath + "\eXaDev.swf"

        'Me.AxShockwaveFlash1.Loop = True
        'Me.AxShockwaveFlash1.Menu = False




    End Sub



    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub
End Class
