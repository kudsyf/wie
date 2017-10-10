'Imports System.Net.Mail.MailMessage


Public Class ErrorTrace
    Inherits System.ComponentModel.Component

    Private x As New Exception()
    Public Property Ex() As Exception
        Get
            Return x
        End Get
        Set(ByVal Value As Exception)
            x = Value
            If bEnabled Then
                If Value.ToString.Length > 0 Then

                    If SendReport Then
                        SendMail()
                    End If
                    If bNotifyLocal Then
                        MessageBox.Show("خطا في النظام ..الرجاء ابلاغ مدير قاعدة البيانات", "نظام ادارة الصادر والوارد", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    End If
                End If
            End If
        End Set
    End Property


    Private bSend As Boolean
    Public Property SendReport() As Boolean
        Get
            Return bSend
        End Get
        Set(ByVal Value As Boolean)
            bSend = Value
        End Set
    End Property


    Private bNotifyLocal As Boolean = False
    Public Property NotifyLocal() As Boolean
        Get
            Return bNotifyLocal
        End Get
        Set(ByVal Value As Boolean)
            bNotifyLocal = Value
        End Set
    End Property

    Private sCustBody As String
    Public Property CustomBody() As String
        Get
            Return sCustBody
        End Get
        Set(ByVal Value As String)
            sCustBody = Value
        End Set
    End Property

    Private sLineNumber As String
    Public Property LineNumber() As String
        Get
            Return sLineNumber
        End Get
        Set(ByVal Value As String)
            sLineNumber = Value
        End Set
    End Property


    Private sActiveMethod As String
    Public Property ActiveMethod() As String
        Get
            Return sActiveMethod
        End Get
        Set(ByVal Value As String)
            sActiveMethod = Value
        End Set
    End Property



    Private bEnabled As Boolean = False
    Public Property Enabled() As Boolean
        Get
            Return bEnabled
        End Get
        Set(ByVal Value As Boolean)
            bEnabled = Value
        End Set
    End Property

    Private sSMTPUser As String
    Public Property SMTPUser() As String
        Get
            Return sSMTPUser
        End Get
        Set(ByVal Value As String)
            sSMTPUser = Value
        End Set
    End Property

    Private sSMTPPass As String
    Public Property SMTPPass() As String
        Get
            Return sSMTPPass
        End Get
        Set(ByVal Value As String)
            sSMTPPass = Value
        End Set
    End Property

    Private sSMTPServer As String
    Public Property SMTPServer() As String
        Get
            Return sSMTPServer
        End Get
        Set(ByVal Value As String)
            sSMTPServer = Value
        End Set
    End Property

    Private sSendTo As String
    Public Property SendTo As String
        Get
            Return sSendTo
        End Get
        Set(ByVal value As String)
            If sSendTo = value Then
                Return
            End If
            sSendTo = value
        End Set
    End Property

    Private sFrom As String
    Public Property From As String
        Get
            Return sFrom
        End Get
        Set(ByVal value As String)
            If sFrom = value Then
                Return
            End If
            sFrom = value
        End Set
    End Property

    Private sMMSG As String
    Public Property MMSG As String
        Get
            Return sMMSG
        End Get
        Set(ByVal value As String)
            If sMMSG = value Then
                Return
            End If
            sMMSG = value
        End Set
    End Property

    Private sSubject As String
    Public Property Subject As String
        Get
            Return sSubject
        End Get
        Set(ByVal value As String)
            If sSubject = value Then
                Return
            End If
            sSubject = value
        End Set
    End Property
    Public ReadOnly Property OS() As String
        Get
            Return Environment.OSVersion.ToString
        End Get
    End Property

    Public ReadOnly Property ComputerName() As String
        Get
            Return Environment.MachineName.ToString
        End Get
    End Property

    Public ReadOnly Property UserName() As String
        Get
            Return Environment.UserName.ToString
        End Get
    End Property

    Public ReadOnly Property UserDomainName() As String
        Get
            Return Environment.UserDomainName.ToString
        End Get
    End Property

    Private Function Decr(ByVal inp As String) As String
        Dim i As Int16
        Dim tempS As String
        tempS = ""

        For i = 1 To inp.Length
            tempS = tempS + Chr(Asc(Mid(inp, i, 1)) Xor 1)
        Next
        Return tempS
    End Function



    Private Sub SendMail()
        Try

            Dim mail As New System.Net.Mail.MailMessage()
            Dim sendnow As New System.Net.Mail.SmtpClient

            mail = New System.Net.Mail.MailMessage()
            mail.From = New Net.Mail.MailAddress(From)
            mail.To.Add(SendTo)
            Subject = "[Project = WinImpExp NIC - ERROR] at " + DateTime.Today
            mail.Subject = Subject


            CustomBody = "Machine Name = " + ComputerName + vbCrLf _
             + "User Name = " + UserName + vbCrLf _
             + "User Domain Name = " + UserDomainName + vbCrLf _
             + "OS = " + OS + vbCrLf _
             + "Error in Method = " + ActiveMethod + vbCrLf _
             + "Error in Line = " + LineNumber + vbCrLf _
             + "Error = " + Ex.Message + vbCrLf _
             + " --------------------------------------------------------- " + vbCrLf _
             + MMSG




            mail.Body = CustomBody



            sendnow.Credentials = New Net.NetworkCredential(SMTPUser, SMTPPass)
            sendnow.Port = 587
            sendnow.EnableSsl = True
            sendnow.Host = SMTPServer
            sendnow.Send(mail)
        Catch exc As Exception

        End Try
    End Sub
End Class
