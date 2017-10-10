Public Class DongleForm

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub DongleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        OrginalCopy = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim Num1, Num2, LicType As Integer
        Dim DriveTestResult As Long
        Dim Disk As Char
        Call Dscbf11(AddressOf Rufcb1, 1)
        DriveTestResult = DriveInPort()
        If Label3.Text <> "0" Then
            If DriveTestResult = 7 Then
                If DriveIsOrig(Disk, Num1, Num2, LicType) Then
                    Label4.Text = "نسخة نظام مرخصة ... شكرا"
                    Label4.ForeColor = Color.Blue
                    Label4.Refresh()


                    My.Computer.Audio.Play(My.Resources.alarm, AudioPlayMode.Background)
                    System.Threading.Thread.Sleep(4000)
                    OrginalCopy = True
                    Timer1.Enabled = False
                    Me.Hide()
                Else
                    Label4.Text = "نسخة نظام مقرصنة ... سيتم غلق النظام"
                    Label4.ForeColor = Color.Red
                    Label4.Refresh()
                    System.Threading.Thread.Sleep(4000)
                    OrginalCopy = False
                    Timer1.Enabled = False
                    End
                End If


            Else

                If (DriveTestResult = 10) Then
                    Label4.Text = "The previous session is still running!"
                Else
                    Label4.Text = "لم يتم العثور على مفتاح ترخيص"
                    Label4.Refresh()
                    System.Threading.Thread.Sleep(4000)
                End If
            End If
            Label3.Text = Str(Val(Label3.Text) - 1)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        Else
            If Label3.Text = "0" Then
                Label4.Text = " سيتم غلق النظام"
                Label4.Refresh()
                System.Threading.Thread.Sleep(4000)
                Timer1.Enabled = False
                End

            End If

        End If

    End Sub
End Class