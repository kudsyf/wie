Imports System.Windows.Forms
Imports System.Threading
Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Imports System.IO



Public Class MainSys
    'Private Const AdminUser As String = "AdminUser"

    Private Shared SharedData As New SharedObject()
    Protected Overridable Sub StartMarqueeThread()
        Try
            Dim t As New Thread(AddressOf ShowMarqueeForm)
            t.Start()
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
    Protected Overridable Sub ShowMarqueeForm()
        Try
            Dim frm As New LoadingFrm()
            frm.Show()
            frm.Update()
            Do
                SyncLock SharedData
                    If SharedData.ReadyToHideMarquee Then
                        Exit Do
                    End If
                End SyncLock
                Application.DoEvents()
            Loop
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
    Private Class SharedObject
        Public ReadyToHideMarquee As Boolean
    End Class


    Private Sub MainSys_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If CurLogin.ToString <> "" Then
                Me.AlertControl2.Show(Me, "خروج مستخدم ", Me.Org_UsersTableAdapter1.GetLoginName(_ActivePass, _ActiveUser).ToString.Trim + " شكرا لاستخدامك النظام يا ..")
                Me.Org_UsersTableAdapter1.Logging(False, _ActiveUser, _ActivePass)
                SaveSession(SessionType.Logout)
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

    Private _Config As Configuration
    Private Sub MainSys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
       
            _Config = New Configuration(ConfigFilePath)

            If _Config.GetString("SMTPServer") Is Nothing Then
                _Config.SetValue("SMTPServer", Crypto.EncryptTripleDES("smtp.gmail.com", "eXa1975"))
                _Config.SetValue("SMTPUser", Crypto.EncryptTripleDES("activeproject.error@gmail.com", "eXa1975"))
                _Config.SetValue("SMTPPass", Crypto.EncryptTripleDES("godblessusall", "eXa1975"))
                _Config.SetValue("SendTo", Crypto.EncryptTripleDES("activeproject.error@gmail.com", "eXa1975"))
                _Config.SetValue("From", Crypto.EncryptTripleDES("activeproject.error@gmail.com", "eXa1975"))

                _Config.SetValue("ConnectType", Crypto.EncryptTripleDES("Auto", "eXa1975")) ' or User

                _Config.SetValue("ConnectBy", Crypto.EncryptTripleDES("Local", "eXa1975")) ' Net or Local or Both

                _Config.SetValue("SQLServerName", Crypto.EncryptTripleDES("NIC-PC", "eXa1975"))
                _Config.SetValue("SQLServerDBName", Crypto.EncryptTripleDES("NEW", "eXa1975"))

                _Config.SetValue("SQLServerIP", Crypto.EncryptTripleDES("192.168.0.201", "eXa1975"))
                _Config.SetValue("SQLServerUserName", Crypto.EncryptTripleDES("sa", "eXa1975"))
                _Config.SetValue("SQLServerpassword", Crypto.EncryptTripleDES("baghdad@iraq1", "eXa1975"))
                _Config.SetValue("SQLServerDB", Crypto.EncryptTripleDES("NICADMIN", "eXa1975"))
                _Config.SetValue("NetCode", Crypto.EncryptTripleDES("192.168.0.201", "eXa1975"))


                _Config.SetValue("OrgPop3", Crypto.EncryptTripleDES("owa020.serverdata.net", "eXa1975"))

                _Config.SetValue("eMailSMTPServer", Crypto.EncryptTripleDES("smtpx20.serverdata.net", "eXa1975"))

                _Config.SetValue("AdminUser", Crypto.EncryptTripleDES("admin", "eXa1975"))
                _Config.SetValue("AdminPass", Crypto.EncryptTripleDES("nimda", "eXa1975"))
                _Config.SetValue("DPC", Crypto.EncryptTripleDES("F", "eXa1975"))
                _Config.SetValue("ActivePass", Crypto.EncryptTripleDES("nimda", "eXa1975"))

            End If
            _Config.Save()

            'System.Threading.Thread.Sleep(1000)



            rSMTPServer = Crypto.DecryptTripleDES(_Config.GetString("SMTPServer"), "eXa1975")
            rSMTPUser = Crypto.DecryptTripleDES(_Config.GetString("SMTPUser"), "eXa1975")
            rSMTPPass = Crypto.DecryptTripleDES(_Config.GetString("SMTPPass"), "eXa1975")
            rSendTo = Crypto.DecryptTripleDES(_Config.GetString("SendTo"), "eXa1975")
            rFrom = Crypto.DecryptTripleDES(_Config.GetString("From"), "eXa1975")



            If Crypto.DecryptTripleDES(_Config.GetString("DPC"), "eXa1975") = "T" Then
                Dim dong As New DongleForm
                dong.ShowDialog()
                BarSubItem7.Enabled = False
            End If





            CurLogin = ""
            BarSubItem2.Enabled = False
            BarSubItem3.Enabled = False
            BarButtonItem14.Enabled = False
            BarButtonItem13.Enabled = False
            BarButtonItem12.Enabled = False
            BarButtonItem35.Enabled = False
            BarButtonItem44.Enabled = False

            BarSubItem4.Enabled = False
            BarSubItem5.Enabled = False
            BarSubItem6.Enabled = False
            BarSubItem7.Enabled = False
            BarSubItem8.Enabled = False
            BarButtonItem2.Enabled = False
            BarButtonItem56.Enabled = False
            BarButtonItem57.Enabled = False
            BarButtonItem23.Enabled = False
            BarButtonItem36.Enabled = False
            BarButtonItem37.Enabled = False
            BarButtonItem3.Enabled = True

            BarButtonItem58.Enabled = False
            BarButtonItem59.Enabled = False
            BarButtonItem60.Enabled = False
            BarButtonItem62.Enabled = False

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
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace + vbCrLf + vbCrLf + ex.StackTrace

                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try

    End Sub





    Private Sub CreateAdminitrator()
        Dim cmd As SqlClient.SqlCommand
        Dim Cn As New SqlClient.SqlConnection

        ' Dim dr As SqlClient.SqlDataReader
        cmd = New SqlClient.SqlCommand
        cmd.Connection = Cn
        Cn.ConnectionString = Conn_Str
        Cn.Open()

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into org_users " + _
            "(owner_org_no,login_name,user_name,password,enable_login,privilage_1,privilage_2)" + _
            " values ('0000','admin','administrator','',1,3,3)"
        cmd.ExecuteNonQuery()
        Cn.Close()
        Cn.Dispose()
        Cn = Nothing

    End Sub




    Private Sub SelectOrg()
        Try
            'Dim frm2 As New SelectOrgForm
            'frm2.ShowDialog()
            'If Not frm2.CancelF Then
            '    CurOrgNo = SelOrgNo
            Dim frm3 As New LoginForm
            frm3.ShowDialog()
            If Not frm3.CancelF Then
                CurOrgNo = frm3.SelOrgg
                SelOrgNo = frm3.SelOrgg

                If CurLogin = "admin" Then
                    BarSubItem2.Enabled = True
                    BarSubItem6.Enabled = True
                    BarButtonItem2.Enabled = True
                    BarSubItem4.Enabled = True
                    BarSubItem5.Enabled = True
                    BarSubItem7.Enabled = True
                    BarSubItem8.Enabled = True
                    BarButtonItem58.Enabled = True
                    BarButtonItem3.Enabled = True
                    BarButtonItem15.Enabled = True
                    BarButtonItem56.Enabled = True
                    BarButtonItem57.Enabled = True
                    BarButtonItem7.Enabled = True
                    BarSubItem8.Enabled = True
                    BarButtonItem23.Enabled = True
                    BarSubItem3.Enabled = True
                    BarButtonItem14.Enabled = True
                    BarButtonItem13.Enabled = True
                    BarButtonItem12.Enabled = True
                    BarButtonItem35.Enabled = True
                    BarButtonItem44.Enabled = True


                    BarButtonItem36.Enabled = True
                    BarButtonItem37.Enabled = True

                    BarButtonItem58.Enabled = True
                    BarButtonItem59.Enabled = True
                    BarButtonItem60.Enabled = True
                    BarButtonItem62.Enabled = True

                Else
                    BarSubItem2.Enabled = True
                    BarSubItem4.Enabled = CanImpProperty
                    BarSubItem5.Enabled = CanExpProperty
                    BarSubItem7.Enabled = CanEmailProperty
                    BarSubItem8.Enabled = CanRepProperty
                    BarButtonItem3.Enabled = CanCreateDBProperty
                    BarButtonItem37.Enabled = CanBackupDBProperty
                    BarButtonItem36.Enabled = CanDBrestoreProperty
                    BarButtonItem7.Enabled = CanUsersManagProperty
                    BarButtonItem23.Enabled = CanEntImpProperty
                    BarButtonItem56.Enabled = CanImpProperty
                    BarButtonItem57.Enabled = CanExpProperty

                    BarSubItem3.Enabled = CanSettingProperty
                    BarButtonItem14.Enabled = CanManageSecuritiesProperty
                    BarButtonItem13.Enabled = CanManageTypesProperty
                    BarButtonItem12.Enabled = CanManageOrgsProperty
                    BarButtonItem35.Enabled = CanManageShortcutsProperty
                    BarButtonItem44.Enabled = CanManageEmailsProperty

                    BarButtonItem58.Enabled = CanRep1Property
                    BarButtonItem59.Enabled = CanRep2Property
                    BarButtonItem60.Enabled = CanMembersProperty
                    BarButtonItem62.Enabled = CanUsersManagProperty



                    BarSubItem6.Enabled = CanRecycleProperty
                    BarButtonItem15.Enabled = CanManageFoldersProperty

                    If GotAdminAuth Then
                        BarButtonItem31.Enabled = True
                        BarButtonItem33.Enabled = True
                    Else
                        BarButtonItem31.Enabled = False
                        BarButtonItem33.Enabled = False


                    End If
                End If
            Else
            End If
            frm3 = Nothing
            'End If
            'frm2 = Nothing
            'BarStaticItem3.Caption = CurLogin
            'BarStaticItem8.Caption = CurOrgNameProperty.ToString.Trim
            'Timer1.Interval = 3600000   ' each second = 1000 millsecond
            'Timer1.Enabled = True
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



    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Timer1.Enabled = False

            Dim frm1 As New OpenDataBaseForm
            IsOpenDB = True
            frm1.ShowDialog()
            If Not frm1.CancelF Then
                'impDelcount.Caption = Me.ImportDocTableAdapter.CountDeleted()
                'ImpCount.Caption = Me.ImportDocTableAdapter.impcount()
                'expdelcount.Caption = Me.ExportDocTableAdapter.CountExpDeleted()
                'ExpCount.Caption = Me.ExportDocTableAdapter.expcount()

                Call SelectOrg()

            End If
            frm1 = Nothing
        Catch ex2 As SqlException
            If ex2.ErrorCode = -2146232060 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("خطأ في اسم او معلومات ربط قاعدة البيانات")
                End

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

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

        Try

            Dim frmcu As New CreateNewDB




            frmcu.ShowDialog()
            frmcu = Nothing


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

    Private Sub BarButtonItem5_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Try


            If (DevExpress.XtraEditors.XtraMessageBox.Show("سيتم اغلاق جميع النوافذ المفتوحة حاليا ؟", "اختيار دائرة اخرى ", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                For Each frmee As Form In Me.MdiChildren
                    frmee.Close()

                    frmee.Dispose()

                    frmee = Nothing
                Next
                Dim frm As New LoginForm


                If CurLogin.ToString <> "" Then
                    Me.AlertControl2.Show(Me, "خروج مستخدم ", Me.Org_UsersTableAdapter1.GetLoginName(_ActivePass, _ActiveUser).ToString.Trim + " شكرا لاستخدامك النظام يا ..")
                    Me.Org_UsersTableAdapter1.Logging(False, _ActiveUser, _ActivePass)
                    SaveSession(SessionType.Logout)
                End If

                frm.ShowDialog()
                If Not frm.CancelF Then
                    CurOrgNo = frm.SelOrgg
                    SelOrgNo = frm.SelOrgg
                    Call DisposeAll()
                    If CurLogin = "admin" Then
                        BarSubItem2.Enabled = True
                        BarSubItem6.Enabled = True
                        BarButtonItem2.Enabled = True
                        BarSubItem4.Enabled = True
                        BarSubItem5.Enabled = True
                        BarSubItem7.Enabled = True
                        BarButtonItem56.Enabled = True
                        BarButtonItem57.Enabled = True
                        BarSubItem8.Enabled = True
                        BarButtonItem3.Enabled = True
                        BarButtonItem4.Enabled = True
                        BarButtonItem37.Enabled = True
                        BarButtonItem36.Enabled = True
                        BarButtonItem7.Enabled = True
                        BarButtonItem23.Enabled = True
                        BarSubItem3.Enabled = True

                        BarButtonItem14.Enabled = True
                        BarButtonItem13.Enabled = True
                        BarButtonItem12.Enabled = True
                        BarButtonItem35.Enabled = True
                        BarButtonItem44.Enabled = True
                        BarButtonItem58.Enabled = True
                        BarButtonItem59.Enabled = True
                        BarButtonItem60.Enabled = True
                        BarButtonItem62.Enabled = True
                    Else
                        BarSubItem2.Enabled = True
                        BarSubItem4.Enabled = CanImpProperty
                        BarSubItem5.Enabled = CanExpProperty
                        BarSubItem7.Enabled = CanEmailProperty
                        BarSubItem8.Enabled = CanRepProperty
                        BarButtonItem3.Enabled = CanCreateDBProperty
                        BarButtonItem37.Enabled = CanBackupDBProperty
                        BarButtonItem36.Enabled = CanDBrestoreProperty
                        BarButtonItem7.Enabled = CanUsersManagProperty
                        BarButtonItem62.Enabled = CanUsersManagProperty
                        BarButtonItem23.Enabled = CanEntImpProperty
                        BarButtonItem56.Enabled = CanImpProperty
                        BarButtonItem57.Enabled = CanExpProperty
                        BarSubItem3.Enabled = CanSettingProperty

                        BarButtonItem14.Enabled = CanManageSecuritiesProperty
                        BarButtonItem13.Enabled = CanManageTypesProperty

                        BarButtonItem12.Enabled = CanManageOrgsProperty
                        BarButtonItem35.Enabled = CanManageShortcutsProperty
                        BarButtonItem44.Enabled = CanManageEmailsProperty

                        BarButtonItem58.Enabled = CanRep1Property
                        BarButtonItem59.Enabled = CanRep2Property
                        BarButtonItem60.Enabled = CanMembersProperty

                        BarSubItem6.Enabled = CanRecycleProperty
                    End If
                End If
                frm = Nothing

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

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Try
            Dim frmu As New UsersForm
            frmu.ShowDialog()
            frmu = Nothing
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


    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Try
            If Not frmExpList Is Nothing Then
                frmExpList.Close()
                frmExpList = Nothing
            End If

            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()


            ExpRangeProperty = "FULL"
            frmExpList = New ExportListForm
            frmExpList.MdiParent = Me
            frmExpList.Show()
            frmExpList.WindowState = FormWindowState.Maximized
            frmExpList.BringToFront()

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

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


    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Try
            Dim frmo As New OrgManager
            frmo.ShowDialog()
            frmo = Nothing
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

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Try
            Dim delfrm As New DeletedImportListForm
            delfrm.MdiParent = Me
            delfrm.Show()
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

    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Try
            Dim frmt As New TypeManager
            frmt.ShowDialog()
            frmt = Nothing
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

    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Try
            Dim frms As New SecurityManager
            frms.ShowDialog()
            frms = Nothing
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

    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Try
            Dim frmff As New FolderManager
            frmff.ShowDialog()
            frmff = Nothing
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


    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        Try
            For Each frmee As Form In Application.OpenForms

                If frmee.Name = "NewExpForm" Or frmee.Name = "NewImpForm" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن فتح اكثر من نافذة واحدة للصادر او الوارد")

                    Exit Sub
                End If
            Next


            EditOrAddProperty = "NEW"

            ffrm = NewImpForm
            ActionOpenFormProperty = ""
            ffrm.Show()
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

    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Try
            For Each frmee As Form In Application.OpenForms

                If frmee.Name = "NewExpForm" Or frmee.Name = "NewImpForm" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن فتح اكثر من نافذة واحدة للصادر او الوارد")

                    Exit Sub
                End If
            Next



            EditOrAddexpProperty = "NEW"

            ffrmexp = NewExpForm
            ffrmexp.Show()
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


    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Try
            Dim edelfrm As New DeletedExportListForm
            edelfrm.MdiParent = Me
            edelfrm.Show()
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



    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        Try
            If lclfrmImpList Is Nothing Then
                SharedData.ReadyToHideMarquee = False
                StartMarqueeThread()

                lclfrmImpList = New LocalImportListForm
                lclfrmImpList.MdiParent = Me
                lclfrmImpList.Show()

                SyncLock SharedData
                    SharedData.ReadyToHideMarquee = True
                End SyncLock
                Application.DoEvents()

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

    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Try
            If Not frmImpList Is Nothing Then
                frmImpList.Close()

                frmImpList = Nothing
            End If


            SharedData.ReadyToHideMarquee = False

            StartMarqueeThread()

            frmImpList = New ImportListForm
            frmImpList.MdiParent = Me
            frmImpList.Show()


            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

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



    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        Try



            If Not frmExpList Is Nothing Then
                frmExpList.Close()
                frmExpList = Nothing
            End If

            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()




            frmExpList = New ExportListForm
            frmExpList.MdiParent = Me
            frmExpList.Show()
            frmExpList.WindowState = FormWindowState.Maximized
            frmExpList.BringToFront()

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()
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

    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Try
            If Not frmExpList Is Nothing Then
                frmExpList.Close()
                frmExpList = Nothing
            End If

            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()
            ExpRangeProperty = "30"
            frmExpList = New ExportListForm
            frmExpList.MdiParent = Me
            frmExpList.Show()
            frmExpList.WindowState = FormWindowState.Maximized
            frmExpList.BringToFront()

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()
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

    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        Try
            If Not frmExpList Is Nothing Then
                frmExpList.Close()
                frmExpList = Nothing
            End If

            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()
            ExpRangeProperty = "180"
            frmExpList = New ExportListForm
            frmExpList.MdiParent = Me
            frmExpList.Show()
            frmExpList.WindowState = FormWindowState.Maximized
            frmExpList.BringToFront()

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()
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



    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        Try
            For Each frmee As Form In Application.OpenForms

                If frmee.Name = "NewExpForm" Or frmee.Name = "NewImpForm" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن فتح اكثر من نافذة واحدة للصادر او الوارد")

                    Exit Sub
                End If
            Next

            If GotAdminAuth Then

                Dim neworgfrm As New SelectNewOrg
                neworgfrm.ShowDialog()

                EditOrAddProperty = "NEW"

                ffrm = NewImpForm
                ActionOpenFormProperty = ""
                ffrm.Show()
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



    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        Try
            For Each frmee As Form In Application.OpenForms

                If frmee.Name = "NewExpForm" Or frmee.Name = "NewImpForm" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن فتح اكثر من نافذة واحدة للصادر او الوارد")

                    Exit Sub
                End If
            Next



            If GotAdminAuth Then

                Dim neworgfrm As New SelectNewOrg
                neworgfrm.ShowDialog()

                EditOrAddexpProperty = "NEW"

                ffrmexp = NewExpForm
                ffrmexp.Show()
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


    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        Try
            Dim frms As New ShortcutManager
            frms.ShowDialog()
            frms = Nothing
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

    Private Sub BarButtonItem36_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        Try
            Dim frmss As New SignedManager
            frmss.ShowDialog()
            frmss = Nothing
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

    Private Sub BarButtonItem37_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        Try
            Timer1.Enabled = False

            If (DevExpress.XtraEditors.XtraMessageBox.Show("سيتم اغلاق جميع النوافذ المفتوحة حاليا ؟", "اختيار دائرة اخرى ", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                For Each frmee As Form In Me.MdiChildren
                    frmee.Hide()
                    frmee = Nothing
                Next
                If CurLogin.ToString <> "" Then
                    Me.AlertControl2.Show(Me, "خروج مستخدم ", Me.Org_UsersTableAdapter1.GetLoginName(_ActivePass, _ActiveUser).ToString.Trim + " شكرا لاستخدامك النظام يا ..")
                    Me.Org_UsersTableAdapter1.Logging(False, _ActiveUser, _ActivePass)
                    SaveSession(SessionType.Logout)
                End If





                Call SelectOrg()
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


    Private Sub AlertControl1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs) Handles AlertControl1.ButtonClick
        Try
            Dim frmrs As New ReminderList
            frmrs.ShowDialog()
            frmrs = Nothing
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            AlertControl1.Show(Me, "تنبيه ...", "للأطلاع على قائمة الكتب المتاخرة ... اضغط على الزر في اسفل الملاحظة")
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

    Private Sub AlertControl1_FormLoad(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs) Handles AlertControl1.FormLoad
        Try
            My.Computer.Audio.Play(My.Resources.alarm, AudioPlayMode.Background)
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

    Private Sub BarButtonItem40_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        Try
            For Each frmne As Form In Application.OpenForms

                If frmne.Name = "NewEmail" Or frmne.Name = "NewEmailImport" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن فتح اكثر من نافذة واحدة للصادر او الوارد")

                    Exit Sub
                End If
            Next
            If OrgemailTableAdapter.GetEmail(CurOrgNo) Is Nothing Then
                DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم العثور على بريد الكتروني خاص بدائرتك , الرجاء اتمام الاعدادات او الاتصال بمدير قاعدة البيانات")
                Return
            Else
                frmres = New NewEmailImport

                frmres.ShowDialog()
                frmres = Nothing
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

    Private Sub BarButtonItem44_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem44.ItemClick
        Try
            Dim frmresm As New EmailManager

            frmresm.ShowDialog()
            frmresm = Nothing
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

    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        Try
            If Not frmemImpList Is Nothing Then
                frmemImpList.Close()

                frmemImpList = Nothing
            End If
            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()


            frmemImpList = New EmailImportList
            frmemImpList.MdiParent = Me
            frmemImpList.Show()


            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

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

    Private Sub BarButtonItem42_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        Try
            For Each frmne As Form In Application.OpenForms

                If frmne.Name = "NewEmail" Or frmne.Name = "NewEmailImport" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن فتح اكثر من نافذة واحدة للصادر او الوارد")

                    Exit Sub
                End If
            Next


            emad = NewEmail
            emad.Show()
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

    Private Sub BarButtonItem43_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        Try
            If Not frmemxImpList Is Nothing Then
                frmemxImpList.Close()

                frmemxImpList = Nothing
            End If
            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()


            frmemxImpList = New EmailExportList
            frmemxImpList.MdiParent = Me
            frmemxImpList.Show()


            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

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

    Private Sub BarButtonItem45_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem45.ItemClick
        Try
            Dim edelfrm As New DeletedEmailImportList
            edelfrm.MdiParent = Me
            edelfrm.Show()
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

    Private Sub BarButtonItem46_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        Try
            Dim edelfrm As New DeletedEmailExportList
            edelfrm.MdiParent = Me
            edelfrm.Show()
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

    Private Sub BarButtonItem47_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        Try
            Dim edelfrm As New EmailFollowup
            edelfrm.MdiParent = Me

            edelfrm.Show()
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

    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim edelfrm As New ImportOldImages

            edelfrm.Show()
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

    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        Try
            Dim edelfrm As New AdminSetting

            edelfrm.Show()
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

    Private Sub BarButtonItem49_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem49.ItemClick


        If (DevExpress.XtraEditors.XtraMessageBox.Show("سيتم اغلاق جميع النوافذ المفتوحة حاليا ؟", "اختيار دائرة اخرى ", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            For Each frmee As Form In Me.MdiChildren
                frmee.Close()
                frmee.Dispose()

                frmee = Nothing
            Next

            Me.AlertControl2.Show(Me, "خروج مستخدم ", Me.Org_UsersTableAdapter1.GetLoginName(_ActivePass, _ActiveUser).ToString.Trim + " شكرا لاستخدامك النظام يا ..")
            Me.Org_UsersTableAdapter1.Logging(False, _ActiveUser, _ActivePass)
            SaveSession(SessionType.Logout)

            CurLogin = ""
            BarSubItem2.Enabled = False

            BarSubItem3.Enabled = False
            BarButtonItem14.Enabled = False
            BarButtonItem13.Enabled = False
            BarButtonItem12.Enabled = False
            BarButtonItem35.Enabled = False
            BarButtonItem44.Enabled = False

            BarButtonItem56.Enabled = False
            BarButtonItem57.Enabled = False
            BarSubItem4.Enabled = False
            BarSubItem5.Enabled = False
            BarSubItem6.Enabled = False
            BarSubItem7.Enabled = False
            BarSubItem8.Enabled = False
            BarButtonItem58.Enabled = False
            BarButtonItem59.Enabled = False
            BarButtonItem60.Enabled = False
            BarButtonItem62.Enabled = False
            BarButtonItem2.Enabled = False

            BarButtonItem23.Enabled = False
            BarButtonItem36.Enabled = False
            BarButtonItem37.Enabled = False
            BarButtonItem3.Enabled = True
        End If
    End Sub


    Private Sub BarButtonItem54_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem54.ItemClick
        Try
            Dim edelfrm As New AboutBox

            edelfrm.ShowDialog()
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

    Private Sub BarButtonItem55_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem55.ItemClick
        Try
            Dim edelfrm As New PassForm

            edelfrm.ShowDialog()
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

    Private Sub BarButtonItem56_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem56.ItemClick
        Try

            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()

            lclfrmImpList2 = New ElementReqList
            lclfrmImpList2.MdiParent = Me
            lclfrmImpList2.Show()

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

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

    Private Sub BarButtonItem57_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem57.ItemClick
        Try

            SharedData.ReadyToHideMarquee = False
            StartMarqueeThread()

            lclfrmImpList22 = New LocalExportListForm
            lclfrmImpList22.MdiParent = Me
            lclfrmImpList22.Show()

            SyncLock SharedData
                SharedData.ReadyToHideMarquee = True
            End SyncLock
            Application.DoEvents()

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

    Private Sub BarButtonItem58_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem58.ItemClick
        Try
            Dim edelfrmre As New ReportSelector
            edelfrmre.ShowDialog()
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

    Private Sub BarButtonItem59_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem59.ItemClick
        Try


            If Not Genrfrm Is Nothing Then
                Genrfrm.Close()

                Genrfrm = Nothing
            End If



            Genrfrm = New GenReport
            Genrfrm.MdiParent = Me
            Genrfrm.Show()


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

    Private Sub BarButtonItem60_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem60.ItemClick
        Try
            Dim frmtmem As New MembersManager

            frmtmem.ShowDialog()
            frmtmem = Nothing
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



    Private Sub BarButtonItem62_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem62.ItemClick
        Try
            If Not SSfrm Is Nothing Then
                SSfrm.Close()

                SSfrm = Nothing
            End If



            SSfrm = New SessionList
            SSfrm.MdiParent = Me
            SSfrm.Show()


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
