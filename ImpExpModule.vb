Imports System.IO
Imports System.Net


Module ImpExpModule



    Public ConfigFilePath As String = Path.Combine(Application.StartupPath, "AppSet.xml")
    Public _UserLoginId As Integer
    Public _ActiveUser As String
    Public _ActivePass As String
    Public SqlIP As String = ""

    Private IsJoin As Boolean


    Public Function GetMyHost_IP(ByVal SQLIPP As String) As String
        Dim sqlip2 As String = SQLIPP
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(Environment.MachineName)
        Dim IpAddr As IPAddress() = ipEntry.AddressList

        If sqlip2.LastIndexOf(".") > 0 Then
            sqlip2 = Strings.Left(sqlip2, sqlip2.LastIndexOf("."))


            Dim m As Integer
            Dim s As String

            For m = 0 To IpAddr.Length - 1
                s = IpAddr(m).ToString
                If s.LastIndexOf(".") > 0 Then
                    s = Strings.Left(s, s.LastIndexOf("."))

                    If s = sqlip2 Then
                        Return String.Format("_{0}_{1}", ipEntry.HostName, IpAddr(m))
                    End If
                End If

            Next

        End If
        Return "_" + ipEntry.HostName
    End Function



    Public Property IsJoinProperty As Boolean
        Get
            Return IsJoin
        End Get
        Set(ByVal value As Boolean)
            If IsJoin = value Then
                Return
            End If
            IsJoin = value
        End Set
    End Property



    Private eMailActionAddFrom As String
    Public Property EMailActionAddFromProperty As String
        Get
            Return eMailActionAddFrom
        End Get
        Set(ByVal value As String)
            If eMailActionAddFrom = value Then
                Return
            End If
            eMailActionAddFrom = value
        End Set
    End Property


    Private eMailActType As String
    Public Property EMailActTypeProperty As String
        Get
            Return eMailActType
        End Get
        Set(ByVal value As String)
            If eMailActType = value Then
                Return
            End If
            eMailActType = value
        End Set
    End Property

    Private eMailActionAddType As String
    Public Property EMailActionAddTypeProperty As String
        Get
            Return eMailActionAddType
        End Get
        Set(ByVal value As String)
            If eMailActionAddType = value Then
                Return
            End If
            eMailActionAddType = value
        End Set
    End Property


    Private OrginC As Boolean
    Public Property OrginalCopy As Boolean
        Get
            Return OrginC
        End Get
        Set(ByVal value As Boolean)
            If OrginC = value Then
                Return
            End If
            OrginC = value
        End Set
    End Property


    Public frmres As New NewEmailImport
    Public frmemImpList As New EmailImportList
    Public frmemxImpList As New EmailExportList
    Public NewEmailFrm As New NewEmailActionForm
    'Public NewExpEmailFrm As New NewExpActionForm
    Public ffrm As New NewImpForm
    Public eeffrm As New eMailView
    Public eXeeffrm As New ExpeMailView
    Public ffrmexp As New NewExpForm
    Public scanfrm As ScannerForm
    Public emac As New eMailAction
    Public emad As New NewEmail
    Public SSfrm As New SessionList

    Public CurLogin As String

    Private eMailActionType As String
    Public Property EMailActionTypeProperty As String
        Get
            Return eMailActionType
        End Get
        Set(ByVal value As String)
            If eMailActionType = value Then
                Return
            End If
            eMailActionType = value
        End Set
    End Property


    Private ssSMTPUser As String
    Public Property rSMTPUser() As String
        Get
            Return ssSMTPUser
        End Get
        Set(ByVal Value As String)
            ssSMTPUser = Value
        End Set
    End Property

    Private ssSMTPPass As String
    Public Property rSMTPPass() As String
        Get
            Return ssSMTPPass
        End Get
        Set(ByVal Value As String)
            ssSMTPPass = Value
        End Set
    End Property

    Private ssSMTPServer As String
    Public Property rSMTPServer() As String
        Get
            Return ssSMTPServer
        End Get
        Set(ByVal Value As String)
            ssSMTPServer = Value
        End Set
    End Property

    Private ssSendTo As String
    Public Property rSendTo As String
        Get
            Return ssSendTo
        End Get
        Set(ByVal value As String)
            If ssSendTo = value Then
                Return
            End If
            ssSendTo = value
        End Set
    End Property

    Private ssFrom As String
    Public Property rFrom As String
        Get
            Return ssFrom
        End Get
        Set(ByVal value As String)
            If ssFrom = value Then
                Return
            End If
            ssFrom = value
        End Set
    End Property




    Private CurServerName As String
    Public Property CurServerNameProperty As String
        Get
            Return CurServerName
        End Get
        Set(ByVal value As String)
            If CurServerName = value Then
                Return
            End If
            CurServerName = value
        End Set
    End Property




    Private CurOrgName As String
    Public Property CurOrgNameProperty As String
        Get
            Return CurOrgName
        End Get
        Set(ByVal value As String)
            If CurOrgName = value Then
                Return
            End If
            CurOrgName = value
        End Set
    End Property



    Private isnewselectedorgImp As Boolean
    Public Property IsnewselectedorgImpProperty As Boolean
        Get
            Return isnewselectedorgImp
        End Get
        Set(ByVal value As Boolean)
            If isnewselectedorgImp = value Then
                Return
            End If
            isnewselectedorgImp = value
        End Set
    End Property


    Private newselectedorgImp As String
    Public Property NewselectedorgImpProperty As String
        Get
            Return newselectedorgImp
        End Get
        Set(ByVal value As String)
            If newselectedorgImp = value Then
                Return
            End If
            newselectedorgImp = value
        End Set
    End Property




    Private ImgId As Int32
    Public Property ImgIdProperty As Int32
        Get
            Return ImgId
        End Get
        Set(ByVal value As Int32)
            If ImgId = value Then
                Return
            End If
            ImgId = value
        End Set
    End Property


    Private ExpRange As String
    Public Property ExpRangeProperty As String
        Get
            Return ExpRange
        End Get
        Set(ByVal value As String)
            If ExpRange = value Then
                Return
            End If
            ExpRange = value
        End Set
    End Property


    Private ImpRange As String
    Public Property ImpRangeProperty As String
        Get
            Return ImpRange
        End Get
        Set(ByVal value As String)
            If ImpRange = value Then
                Return
            End If
            ImpRange = value
        End Set
    End Property


    Private CanManageEmails As Boolean
    Public Property CanManageEmailsProperty As Boolean
        Get
            Return CanManageEmails
        End Get
        Set(ByVal value As Boolean)
            If CanManageEmails = value Then
                Return
            End If
            CanManageEmails = value
        End Set
    End Property


    Private CanRep1 As Boolean
    Public Property CanRep1Property As Boolean
        Get
            Return CanRep1
        End Get
        Set(value As Boolean)
            If CanRep1 = value Then
                Return
            End If
            CanRep1 = value
        End Set
    End Property

    Private CanRep2 As Boolean
    Public Property CanRep2Property As Boolean
        Get
            Return CanRep2
        End Get
        Set(value As Boolean)
            If CanRep2 = value Then
                Return
            End If
            CanRep2 = value
        End Set
    End Property

    Private CanMembers As Boolean
    Public Property CanMembersProperty As Boolean
        Get
            Return CanMembers
        End Get
        Set(value As Boolean)
            If CanMembers = value Then
                Return
            End If
            CanMembers = value
        End Set
    End Property

    Private CanManageShortcuts As Boolean
    Public Property CanManageShortcutsProperty As Boolean
        Get
            Return CanManageShortcuts
        End Get
        Set(ByVal value As Boolean)
            If CanManageShortcuts = value Then
                Return
            End If
            CanManageShortcuts = value
        End Set
    End Property

    Private CanManageOrgs As Boolean
    Public Property CanManageOrgsProperty As Boolean
        Get
            Return CanManageOrgs
        End Get
        Set(ByVal value As Boolean)
            If CanManageOrgs = value Then
                Return
            End If
            CanManageOrgs = value
        End Set
    End Property



    Private CanManageTypes As Boolean
    Public Property CanManageTypesProperty As Boolean
        Get
            Return CanManageTypes
        End Get
        Set(ByVal value As Boolean)
            If CanManageTypes = value Then
                Return
            End If
            CanManageTypes = value
        End Set
    End Property

    Private CanManageSecurities As Boolean
    Public Property CanManageSecuritiesProperty As Boolean
        Get
            Return CanManageSecurities
        End Get
        Set(ByVal value As Boolean)
            If CanManageSecurities = value Then
                Return
            End If
            CanManageSecurities = value
        End Set
    End Property


    Private CanUsersManag As Boolean
    Public Property CanUsersManagProperty As Boolean
        Get
            Return CanUsersManag
        End Get
        Set(ByVal value As Boolean)
            If CanUsersManag = value Then
                Return
            End If
            CanUsersManag = value
        End Set
    End Property




    Private CanSetting As Boolean
    Public Property CanSettingProperty As Boolean
        Get
            Return CanSetting
        End Get
        Set(ByVal value As Boolean)
            If CanSetting = value Then
                Return
            End If
            CanSetting = value
        End Set
    End Property

    Private CanAddPrimeOrg As Boolean
    Public Property CanAddPrimeOrgProperty As Boolean
        Get
            Return CanAddPrimeOrg
        End Get
        Set(ByVal value As Boolean)
            If CanAddPrimeOrg = value Then
                Return
            End If
            CanAddPrimeOrg = value
        End Set
    End Property

    Private CanManageFolders As Boolean
    Public Property CanManageFoldersProperty As Boolean
        Get
            Return CanManageFolders
        End Get
        Set(ByVal value As Boolean)
            If CanManageFolders = value Then
                Return
            End If
            CanManageFolders = value
        End Set
    End Property

    Private CanDeletePrimeFolders As Boolean
    Public Property CanDeletePrimeFoldersProperty As Boolean
        Get
            Return CanDeletePrimeFolders
        End Get
        Set(ByVal value As Boolean)
            If CanDeletePrimeFolders = value Then
                Return
            End If
            CanDeletePrimeFolders = value
        End Set
    End Property

    Private CanDBrestore As Boolean
    Public Property CanDBrestoreProperty As Boolean
        Get
            Return CanDBrestore
        End Get
        Set(ByVal value As Boolean)
            If CanDBrestore = value Then
                Return
            End If
            CanDBrestore = value
        End Set
    End Property


    Private CanBackupDB As Boolean
    Public Property CanBackupDBProperty As Boolean
        Get
            Return CanBackupDB
        End Get
        Set(ByVal value As Boolean)
            If CanBackupDB = value Then
                Return
            End If
            CanBackupDB = value
        End Set
    End Property


    Private CanCreateDB As Boolean
    Public Property CanCreateDBProperty As Boolean
        Get
            Return CanCreateDB
        End Get
        Set(ByVal value As Boolean)
            If CanCreateDB = value Then
                Return
            End If
            CanCreateDB = value
        End Set
    End Property


    Private CanEntImp As Boolean
    Public Property CanEntImpProperty As Boolean
        Get
            Return CanEntImp
        End Get
        Set(ByVal value As Boolean)
            If CanEntImp = value Then
                Return
            End If
            CanEntImp = value
        End Set
    End Property


    Private CanRecycle As Boolean
    Public Property CanRecycleProperty As Boolean
        Get
            Return CanRecycle
        End Get
        Set(ByVal value As Boolean)
            If CanRecycle = value Then
                Return
            End If
            CanRecycle = value
        End Set
    End Property



    Private CanPrint As Boolean
    Public Property GotAdminAuth As Boolean
        Get
            Return CanPrint
        End Get
        Set(ByVal value As Boolean)
            If CanPrint = value Then
                Return
            End If
            CanPrint = value
        End Set
    End Property

    Private CanFollow As Boolean
    Public Property CanFollowProperty As Boolean
        Get
            Return CanFollow
        End Get
        Set(ByVal value As Boolean)
            If CanFollow = value Then
                Return
            End If
            CanFollow = value
        End Set
    End Property



    Private CanEmail As Boolean
    Public Property CanEmailProperty As Boolean
        Get
            Return CanEmail
        End Get
        Set(ByVal value As Boolean)
            If CanEmail = value Then
                Return
            End If
            CanEmail = value
        End Set
    End Property

    Private CanRep As Boolean
    Public Property CanRepProperty As Boolean
        Get
            Return CanRep
        End Get
        Set(ByVal value As Boolean)
            If CanRep = value Then
                Return
            End If
            CanRep = value
        End Set
    End Property


    Private CanImp As Boolean
    Public Property CanImpProperty As Boolean
        Get
            Return CanImp
        End Get
        Set(ByVal value As Boolean)
            If CanImp = value Then
                Return
            End If
            CanImp = value
        End Set
    End Property



    Private CanExp As Boolean
    Public Property CanExpProperty As Boolean
        Get
            Return CanExp
        End Get
        Set(ByVal value As Boolean)
            If CanExp = value Then
                Return
            End If
            CanExp = value
        End Set
    End Property



    Private FollowType As String
    Public Property FollowTypeProperty As String
        Get
            Return FollowType
        End Get
        Set(ByVal value As String)
            If FollowType = value Then
                Return
            End If
            FollowType = value
        End Set
    End Property



    Private FollowSelectedImpID As Int32
    Public Property FollowSelectedImpIDProperty As Int32
        Get
            Return FollowSelectedImpID
        End Get
        Set(ByVal value As Int32)
            If FollowSelectedImpID = value Then
                Return
            End If
            FollowSelectedImpID = value
        End Set
    End Property



    Private ExpSelectedActionID As Int32
    Public Property ExpSelectedActionIDProperty As Int32
        Get
            Return ExpSelectedActionID
        End Get
        Set(ByVal value As Int32)
            If ExpSelectedActionID = value Then
                Return
            End If
            ExpSelectedActionID = value
        End Set
    End Property

    Private ImpSelectedActionID As Int32
    Public Property ImpSelectedActionIDProperty As Int32
        Get
            Return ImpSelectedActionID
        End Get
        Set(ByVal value As Int32)
            If ImpSelectedActionID = value Then
                Return
            End If
            ImpSelectedActionID = value
        End Set
    End Property


    Private ScanOrImagetype As String
    Public Property ScanOrImagetypeProperty As String
        Get
            Return ScanOrImagetype
        End Get
        Set(ByVal value As String)
            If ScanOrImagetype = value Then
                Return
            End If
            ScanOrImagetype = value
        End Set
    End Property

    Private usedExportId As Int32
    Public Property UsedExportIdProperty As Int32
        Get
            Return usedExportId
        End Get
        Set(ByVal value As Int32)
            If usedExportId = value Then
                Return
            End If
            usedExportId = value
        End Set
    End Property

    Private EditOrAddexp As String
    Public Property EditOrAddexpProperty As String
        Get
            Return EditOrAddexp
        End Get
        Set(ByVal value As String)
            If EditOrAddexp = value Then
                Return
            End If
            EditOrAddexp = value
        End Set
    End Property

    Private selectedExpID As String

    Public Property SelectedExpIDProperty As String
        Get
            Return selectedExpID
        End Get
        Set(ByVal value As String)
            If selectedExpID = value Then
                Return
            End If
            selectedExpID = value
        End Set
    End Property



    Private usedImportId As Int32

    Public Property UsedImportIdProperty As Int32
        Get
            Return usedImportId
        End Get
        Set(ByVal value As Int32)
            If usedImportId = value Then
                Return
            End If
            usedImportId = value
        End Set
    End Property


    Private selectedemailExpID As String
    Public Property SelectedemailExpIDProperty As String
        Get
            Return selectedemailExpID
        End Get
        Set(ByVal value As String)
            If selectedemailExpID = value Then
                Return
            End If
            selectedemailExpID = value
        End Set
    End Property

    Private selectedemailImpID As String
    Public Property SelectedemailImpIDProperty As String
        Get
            Return selectedemailImpID
        End Get
        Set(ByVal value As String)
            If selectedemailImpID = value Then
                Return
            End If
            selectedemailImpID = value
        End Set
    End Property
    Private selectedImpID As String

    Public Property SelectedImpIDProperty As String
        Get
            Return selectedImpID
        End Get
        Set(ByVal value As String)
            If selectedImpID = value Then
                Return
            End If
            selectedImpID = value
        End Set
    End Property
    Private ExpActionLocalExpTO As String
    Public Property ExpActionLocalExpTOProperty As String
        Get
            Return ExpActionLocalExpTO
        End Get
        Set(ByVal value As String)
            If ExpActionLocalExpTO = value Then
                Return
            End If
            ExpActionLocalExpTO = value
        End Set
    End Property

    Private ExpActionLocalExpId As Integer
    Public Property ExpActionLocalExpIdProperty As Integer
        Get
            Return ExpActionLocalExpId
        End Get
        Set(ByVal value As Integer)
            If ExpActionLocalExpId = value Then
                Return
            End If
            ExpActionLocalExpId = value
        End Set
    End Property
    Private ActionLocalImpId As Integer
    Public Property ActionLocalImpIdProperty As Integer
        Get
            Return ActionLocalImpId
        End Get
        Set(ByVal value As Integer)
            If ActionLocalImpId = value Then
                Return
            End If
            ActionLocalImpId = value
        End Set
    End Property
    Private ActionLocalId As Integer
    Public Property ActionLocalIdProperty As Integer
        Get
            Return ActionLocalId
        End Get
        Set(ByVal value As Integer)
            If ActionLocalId = value Then
                Return
            End If
            ActionLocalId = value
        End Set
    End Property

    Private ExpActionOpenForm As String
    Public Property ExpActionOpenFormProperty As String
        Get
            Return ExpActionOpenForm
        End Get
        Set(ByVal value As String)
            If ExpActionOpenForm = value Then
                Return
            End If
            ExpActionOpenForm = value
        End Set
    End Property

    Private NewActionOpenForm As String
    Public Property NewActionOpenFormProperty As String
        Get
            Return NewActionOpenForm
        End Get
        Set(ByVal value As String)
            If NewActionOpenForm = value Then
                Return
            End If
            NewActionOpenForm = value
        End Set
    End Property
    Private ActionOpenForm As String

    Public Property ActionOpenFormProperty As String
        Get
            Return ActionOpenForm
        End Get
        Set(ByVal value As String)
            If ActionOpenForm = value Then
                Return
            End If
            ActionOpenForm = value
        End Set
    End Property
    Private EditOrAdd As String

    Public Property EditOrAddProperty As String
        Get
            Return EditOrAdd
        End Get
        Set(ByVal value As String)
            If EditOrAdd = value Then
                Return
            End If
            EditOrAdd = value
        End Set
    End Property

    Private SelectDenotePopupType As String
    Public Property SelectDenotePopupTypeProperty As String
        Get
            Return SelectDenotePopupType
        End Get
        Set(ByVal value As String)
            If SelectDenotePopupType = value Then
                Return
            End If
            SelectDenotePopupType = value
        End Set
    End Property


    Public frmExpList As ExportListForm

    Public frmImpList As ImportListForm
    Public Genrfrm As GenReport

    Public lclfrmImpList As LocalImportListForm
    Public lclfrmImpList2 As ElementReqList
    Public lclfrmImpList22 As LocalExportListForm
    Public SelOrgNo As String


    Public Conn_Str As String
    Public Server_Str As String = "Data SSurce=nerdo\sqlexpress"
    Public DBase_Str As String = "Initial Catalog=newdb2"
    Public Others_Str As String = "Integrated Security=True"
    Public IsOpenDB As Boolean

    Public CurDate As Date
    Public CurOrgNo As String

    Public CurUserName As String

    Public CurDataBase As String
    Public DBOnThisMachine As Boolean
    Public CurMachineName As String

    Sub Main()
    End Sub

    Private ErrorTRace1 As New ErrorTrace

    Public Sub DisposeAll()
        Try
            Dim i As Form
            For Each i In MainSys.MdiChildren
                If Not i.IsDisposed Then i.Dispose()
            Next

            frmExpList = Nothing
            frmImpList = Nothing
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTRace1
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

    Public Sub SaveSession(ByVal SesType As String)
        Try
            Dim Lsess As New NewDBFDataSetTableAdapters.Login_SessionTableAdapter
            Lsess.Insert(Lsess.GetMaxId() + 1, CurOrgNo, DateTime.Now, CurLogin, SesType + GetMyHost_IP(SqlIP))
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTRace1
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



    Public Sub CloseDataBase()

    End Sub



End Module
