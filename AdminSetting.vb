
Imports System.Deployment.Application
Imports System.Xml

Public Class AdminSetting
    Private _Config As Configuration
    Private Sub AdminSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.Org_UsersLogedIn' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'NewDBFDataSet.Org_Users' table. You can move, or remove it, as needed.
        Try
            LayoutControlItem1.Visibility = True
            Me.Height = Me.Height - LayoutControlItem1.Height + 10
            _Config = New Configuration(ConfigFilePath)
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
        Try
            If Trim(TextEdit1.Text) = Crypto.DecryptTripleDES(_Config.GetString("AdminUser"), "eXa1975") And Trim(TextEdit2.Text) = Crypto.DecryptTripleDES(_Config.GetString("AdminPass"), "eXa1975") Then


                TextAdminPass.EditValue = Crypto.DecryptTripleDES(_Config.GetString("AdminPass"), "eXa1975")
                TextAdminUser.EditValue = Crypto.DecryptTripleDES(_Config.GetString("AdminUser"), "eXa1975")
                TextEdit3.EditValue = Crypto.DecryptTripleDES(_Config.GetString("ActivePass"), "eXa1975")


                TextConnectionBy.EditValue = Crypto.DecryptTripleDES(_Config.GetString("ConnectBy"), "eXa1975")
                TextConnectionType.EditValue = Crypto.DecryptTripleDES(_Config.GetString("ConnectType"), "eXa1975")

                TextIMAP.EditValue = Crypto.DecryptTripleDES(_Config.GetString("OrgPop3"), "eXa1975")
                TextSMTP.EditValue = Crypto.DecryptTripleDES(_Config.GetString("eMailSMTPServer"), "eXa1975")

                TextLocalDB.EditValue = Crypto.DecryptTripleDES(_Config.GetString("SQLServerDBName"), "eXa1975")
                TextLocalServer.EditValue = Crypto.DecryptTripleDES(_Config.GetString("SQLServerName"), "eXa1975")

                TextNetDB.EditValue = Crypto.DecryptTripleDES(_Config.GetString("SQLServerDB"), "eXa1975")
                TextNetIp.EditValue = Crypto.DecryptTripleDES(_Config.GetString("SQLServerIP"), "eXa1975")
                TextNetPass.EditValue = Crypto.DecryptTripleDES(_Config.GetString("SQLServerpassword"), "eXa1975")
                TextNetUser.EditValue = Crypto.DecryptTripleDES(_Config.GetString("SQLServerUserName"), "eXa1975")
                txtNetCode.EditValue = Crypto.DecryptTripleDES(_Config.GetString("NetCode"), "eXa1975")
                If Crypto.DecryptTripleDES(_Config.GetString("DPC"), "eXa1975") = "F" Then
                    CheckEdit1.EditValue = False
                Else
                    CheckEdit1.EditValue = True
                End If



                Me.Height = Me.Height + LayoutControlItem1.Height
                LayoutControlItem1.Visibility = False
                Me.Refresh()
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("اسم مستخدم او كلمة مرور خاطئة ... الرجاء اعد المحاولة")

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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            _Config.SetValue("ConnectType", Crypto.EncryptTripleDES(TextConnectionType.EditValue.ToString.Trim, "eXa1975")) ' or User

            _Config.SetValue("ConnectBy", Crypto.EncryptTripleDES(TextConnectionBy.EditValue.ToString.Trim, "eXa1975")) ' Net or Local or Both

            _Config.SetValue("SQLServerName", Crypto.EncryptTripleDES(TextLocalServer.EditValue.ToString.Trim, "eXa1975"))
            _Config.SetValue("SQLServerDBName", Crypto.EncryptTripleDES(TextLocalDB.EditValue.ToString.Trim, "eXa1975"))

            _Config.SetValue("SQLServerIP", Crypto.EncryptTripleDES(TextNetIp.EditValue.ToString.Trim, "eXa1975"))
            _Config.SetValue("SQLServerUserName", Crypto.EncryptTripleDES(TextNetUser.EditValue.ToString.Trim, "eXa1975"))
            _Config.SetValue("SQLServerpassword", Crypto.EncryptTripleDES(TextNetPass.EditValue.ToString.Trim, "eXa1975"))
            _Config.SetValue("SQLServerDB", Crypto.EncryptTripleDES(TextNetDB.EditValue.ToString.Trim, "eXa1975"))
            _Config.SetValue("NetCode", Crypto.EncryptTripleDES(txtNetCode.EditValue.ToString.Trim, "eXa1975"))


            _Config.SetValue("OrgPop3", Crypto.EncryptTripleDES(TextIMAP.EditValue.ToString.Trim, "eXa1975"))

            _Config.SetValue("eMailSMTPServer", Crypto.EncryptTripleDES(TextSMTP.EditValue.ToString.Trim, "eXa1975"))

            _Config.SetValue("AdminUser", Crypto.EncryptTripleDES(TextAdminUser.EditValue.ToString.Trim, "eXa1975"))
            _Config.SetValue("AdminPass", Crypto.EncryptTripleDES(TextAdminPass.EditValue.ToString.Trim, "eXa1975"))
            _Config.SetValue("ActivePass", Crypto.EncryptTripleDES(TextEdit3.EditValue.ToString.Trim, "eXa1975"))

            If CheckEdit1.EditValue Then
                _Config.SetValue("DPC", Crypto.EncryptTripleDES("T", "eXa1975"))
            Else
                _Config.SetValue("DPC", Crypto.EncryptTripleDES("F", "eXa1975"))

            End If


            _Config.Save()
            LayoutControlItem1.Visibility = True
            Me.Height = Me.Height - LayoutControlItem1.Height + 10
            TextEdit1.Text = ""
            TextEdit2.Text = ""

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
    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show(String.Format("The new version of the application cannot be downloaded at this time. {0}{0}Please check your network connection, or try again later. Error: {1}", ControlChars.Lf, dde.Message))
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " & ioe.Message)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MessageBox.Show(String.Format("This application has detected a mandatory update from your current version to version {0}. The application will now install the update and restart.", info.MinimumRequiredVersion.ToString()), _
                        "Update Available", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                End If

                If (doUpdate) Then
                    Try
                        AD.Update()
                        MessageBox.Show("The application has been upgraded, and will now restart.")
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        MessageBox.Show(String.Format("Cannot install the latest version of the application. {0}{0}Please check your network connection, or try again later.", ControlChars.Lf))
                        Return
                    End Try
                End If
            End If
        End If
    End Sub


    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        InstallUpdateSyncWithInfo()


    End Sub


End Class