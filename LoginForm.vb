Imports System.Xml


Public Class LoginForm
    Public SelOrgg As String

    Public CancelF As Boolean
    Dim iTrial As Integer
    Dim cmd As SqlClient.SqlCommand
    Dim DS As DataSet
    Dim da As SqlClient.SqlDataAdapter
    Dim CorrectPassword As String
    Dim Cn As New SqlClient.SqlConnection

    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Cn = Nothing
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

    Private _Config As Configuration
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _Config = New Configuration(ConfigFilePath)
            txtLogin.Text = ""
            txtpass.Text = ""
            iTrial = 1
            CancelF = True
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

    Private Function PassWordOK() As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand
            Dim CorrectPassword As String


            If Trim(txtLogin.Text) = Crypto.DecryptTripleDES(_Config.GetString("AdminUser"), "eXa1975") And Trim(txtpass.Text) = Crypto.DecryptTripleDES(_Config.GetString("AdminPass"), "eXa1975") Then
                PassWordOK = True
                CurLogin = "admin"
            Else
                cmd = New SqlClient.SqlCommand
                cmd.Connection = Cn
                cmd.CommandType = CommandType.Text
                Cn.ConnectionString = Conn_Str
                Cn.Open()

                cmd.CommandText = "select password from org_users " + _
                    " where " + _
                    " LTRIM(RTRIM(login_name)) ='" + txtLogin.Text + "'" + _
                                    " and enable_login =1"

                '" and  owner_org_no = '" + CurOrgNo + "'" + _


                If Not cmd.ExecuteScalar Is Nothing Then
                    CorrectPassword = cmd.ExecuteScalar()
                    cmd = Nothing
                    If Trim(CorrectPassword) = Trim(txtpass.Text) Then
                        PassWordOK = True


                    Else
                        PassWordOK = False
                    End If
                Else
                    PassWordOK = False
                End If

                Cn.Close()
                Cn.Dispose()
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
    End Function

    Private Function GetCorrectPassword() As String
        Dim rslt As String = ""

        Try
            Dim cmd As SqlClient.SqlCommand
            ' Dim dr As SqlClient.SqlDataReader
            Cn.ConnectionString = Conn_Str
            Cn.Open()

            cmd = New SqlClient.SqlCommand
            cmd.Connection = Cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select password from org_users " + _
                " where " + _
                " login_name ='" + txtLogin.Text + "'"     ' + _
            '  " and  owner_org_no = '" + CurOrgNo + "'"

            If Not cmd.ExecuteScalar Is Nothing Then
                rslt = cmd.ExecuteScalar()

            End If
            cmd = Nothing
            Cn.Close()
            Cn.Dispose()
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
        Return rslt
    End Function

    Private Sub GetUserInfo()
        Try
            Dim cmd As SqlClient.SqlCommand
            Dim dr As SqlClient.SqlDataReader
            cmd = New SqlClient.SqlCommand
            Cn.ConnectionString = Conn_Str
            Cn.Open()

            cmd.Connection = Cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from org_users " + _
                " where " + _
                " login_name ='" + txtLogin.Text + "'" ' + _
            '" and (owner_org_no = '" + CurOrgNo + "'" + " or " + "owner_org_no = '0000')"
            dr = cmd.ExecuteReader
            Do While dr.Read
                CanExpProperty = dr("CanExp")
                CanImpProperty = dr("CanImp")
                CanRepProperty = dr("CanRep")
                CanFollowProperty = dr("CanFollow")

                CanAddPrimeOrgProperty = dr("CanAddPrimeOrg")
                CanDeletePrimeFoldersProperty = dr("CanDeletePrimeFolders")
                CanManageFoldersProperty = dr("CanManageFolders")

                CanManageEmailsProperty = dr("CanManageEmails")
                CanManageOrgsProperty = dr("CanManageOrgs")
                CanManageSecuritiesProperty = dr("CanManageSecurities")
                CanManageShortcutsProperty = dr("CanManageShortcuts")
                CanManageTypesProperty = dr("CanManageTypes")

                CanRep1Property = dr("CanReport1")
                CanRep2Property = dr("CanReport2")
                CanMembersProperty = dr("CanMembers")


                If dr("CanPrint") Is Nothing Then
                    GotAdminAuth = False
                Else
                    GotAdminAuth = dr("CanPrint")
                End If

                CanRecycleProperty = dr("CanRecycle")
                CanEntImpProperty = dr("CanEntImp")
                CanCreateDBProperty = dr("CanCreateDB")
                CanBackupDBProperty = dr("CanBackupDB")
                CanDBrestoreProperty = dr("CanDBrestore")
                CanSettingProperty = dr("CanSetting")
                CanUsersManagProperty = dr("CanUsersManag")
                CanEmailProperty = dr("CanEmail")
            Loop
            dr.Close()
            dr = Nothing
            cmd = Nothing
            Cn.Close()
            Cn.Dispose()
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

    Private Sub txtLogin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogin.TextChanged
        Try
            If Trim(txtLogin.Text) >= "" Then
                SimpleButton1.Enabled = True
            Else
                SimpleButton1.Enabled = False
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
            CancelF = True
            Cn = Nothing
            Me.Close()
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
            If PassWordOK() Then
                If Not Me.Org_UsersTableAdapter1.isLogged(txtLogin.Text, txtpass.Text) Is Nothing Then
                    If Not Me.Org_UsersTableAdapter1.isLogged(txtLogin.Text, txtpass.Text) Then
                        MainSys.AlertControl2.Show(Me, "دخول مستخدم جديد", String.Format("{0} شكرا لتسجيل دخولك يا ..{1} من قسم {2}", Me.Org_UsersTableAdapter1.GetLoginName(txtpass.Text, txtLogin.Text).ToString.Trim, vbCrLf, Me.OrgTableAdapter1.GetOrgByNo(Me.Org_UsersTableAdapter1.GetOrgByLN(txtLogin.Text)).ToString.Trim))


                 


                        Me.Org_UsersTableAdapter1.Logging(True, txtLogin.Text, txtpass.Text)
                        SelOrgg = Me.Org_UsersTableAdapter1.GetOrgByLN(txtLogin.Text)
                        CurOrgNo = SelOrgg
                        CurOrgNameProperty = Me.OrgTableAdapter1.GetOrgByNo(SelOrgg)
                        CurLogin = txtLogin.Text

                        MainSys.BarStaticItem3.Caption = txtLogin.Text
                        MainSys.BarStaticItem8.Caption = CurOrgNameProperty.ToString.Trim
                        MainSys.Timer1.Interval = 3600000   ' each second = 1000 millsecond
                        MainSys.Timer1.Enabled = True
                        SaveSession(SessionType.Login)
                    Else

                        Dim Fl As Integer = DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("لا يمكنك تسجيل دخولك من اكثر من نظام ... {0}اذا كنت مدير النظام فيمكن الضغط على نعم لتفعيل المستخدم", vbCrLf), "خطأ في تسجيل الدخول", MessageBoxButtons.YesNo)
                        If Fl = vbYes Then

                            Dim fin As String = InputBox("الرجاء ادخال الرمز السري لاعادة التفعيل", "رمز اعادة التفعيل")
                            If fin = Crypto.DecryptTripleDES(_Config.GetString("ActivePass"), "eXa1975") Then
                                Me.Org_UsersTableAdapter1.UnLog(txtLogin.Text, txtpass.Text)

                                MainSys.AlertControl2.Show(Me, "دخول مستخدم جديد", String.Format("{0} شكرا لتسجيل دخولك يا ..{1} من قسم {2}", Me.Org_UsersTableAdapter1.GetLoginName(txtpass.Text, txtLogin.Text).ToString.Trim, vbCrLf, Me.OrgTableAdapter1.GetOrgByNo(Me.Org_UsersTableAdapter1.GetOrgByLN(txtLogin.Text)).ToString.Trim))
                                Me.Org_UsersTableAdapter1.Logging(True, txtLogin.Text, txtpass.Text)
                                SelOrgg = Me.Org_UsersTableAdapter1.GetOrgByLN(txtLogin.Text)
                                CurOrgNo = SelOrgg
                                CurLogin = txtLogin.Text
                                CurOrgNameProperty = Me.OrgTableAdapter1.GetOrgByNo(SelOrgg)
                                MainSys.BarStaticItem3.Caption = txtLogin.Text
                                MainSys.BarStaticItem8.Caption = CurOrgNameProperty.ToString.Trim
                                MainSys.Timer1.Interval = 3600000   ' each second = 1000 millsecond
                                MainSys.Timer1.Enabled = True
                                SaveSession(SessionType.Login)
                            Else
                                DevExpress.XtraEditors.XtraMessageBox.Show("رمز تفعيل خاطئ")
                                Return
                            End If
                        Else
                            Return

                        End If



                    End If

                Else

                    MainSys.AlertControl2.Show(Me, "دخول مستخدم جديد", String.Format("{0} شكرا لتسجيل دخولك يا ..{1} من قسم {2}", Me.Org_UsersTableAdapter1.GetLoginName(txtpass.Text, txtLogin.Text).ToString.Trim, vbCrLf, Me.OrgTableAdapter1.GetOrgByNo(Me.Org_UsersTableAdapter1.GetOrgByLN(txtLogin.Text)).ToString.Trim))
                    Me.Org_UsersTableAdapter1.Logging(True, txtLogin.Text, txtpass.Text)
                    SaveSession(SessionType.Login)

                End If
                _ActiveUser = txtLogin.Text
                _ActivePass = txtpass.Text

                If CurLogin.ToString <> "" Then
                    SaveSession(SessionType.Login)
                End If
                CurLogin = Trim(txtLogin.Text)
                If CurLogin = "admin" Then
                    CurOrgNameProperty = "Admin"
                End If


                If CurLogin <> "admin" Then
                    Call GetUserInfo()
                End If



                CancelF = False
                Cn = Nothing
                Me.Close()
            Else
                iTrial = iTrial + 1
                If iTrial > 3 Then
                    CancelF = True
                    Me.Close()
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("اسم مستخدم او كلمة مرور خاطئة ... الرجاء اعد المحاولة")
                End If

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
End Class
