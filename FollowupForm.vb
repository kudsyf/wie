Imports DevExpress.XtraTreeList.Nodes
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class FollowupForm
    Dim Bk As String
    Dim BkDate As DateTime
    Dim BkFrom As String
    Dim BkSubject As String

    Private Sub FollowupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.Security' table. You can move, or remove it, as needed.
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Type' table. You can move, or remove it, as needed.
            Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
            'TODO: This line of code loads data into the 'NewDBFDataSet.ImportDoc' table. You can move, or remove it, as needed.
            ' Me.ImportDocTableAdapter.Fill(Me.NewDBFDataSet.ImportDoc)
            TreeList1.BeginUpdate()
            TreeList1.Columns.Add()
            TreeList1.Columns(0).Caption = "شجرة المتابعة"
            TreeList1.Columns(0).VisibleIndex = 0


            TreeList1.EndUpdate()
            Dim start As TreeListNode = Nothing
            Select Case FollowTypeProperty
                Case "Imp"
                    Add_Tree_Node(start, FollowSelectedImpIDProperty, 5, "I")
                    SaveSession(SessionType.FollowImp)
                Case "Exp"
                    Dim FEdata As NewDBFDataSet.Import_DenoteExportedDataTable = Me.Import_DenoteExportedTableAdapter.GetData(FollowSelectedImpIDProperty)
                    Dim FErow As NewDBFDataSet.Import_DenoteExportedRow
                    For Each FErow In FEdata
                        Add_Tree_Node(start, FErow("importId"), 2, "I")
                    Next
                    SaveSession(SessionType.FollowExp)
            End Select

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

    Private Sub Add_Tree_Node(ByVal startNode As TreeListNode, ByVal ImpId As Int32, ByVal parentId As Int32, ByVal ttype As String)
        Try
            If parentId > 0 Then

                Dim tmpStr As String
                ' Create a root node .
                Dim ttstr As String

                TreeList1.BeginUnboundLoad()
                Dim parentForRootNodes As TreeListNode = TreeList1.AppendNode(New Object() {"كتاب"}, startNode)
                parentForRootNodes.StateImageIndex = 6
                parentForRootNodes.Tag = New Object() {ttype.ToString + ImpId.ToString}

                Dim tmpNode As TreeListNode
                Dim tmpNode2 As TreeListNode


                Dim BookIdNode As TreeListNode = TreeList1.AppendNode(New Object() {"معلومات الكتاب"}, parentForRootNodes)
                Dim BookExpDenoteNode As TreeListNode = TreeList1.AppendNode(New Object() {"أشارة الى الكتب الصادرة"}, parentForRootNodes)
                Dim BookImpDenoteNode As TreeListNode = TreeList1.AppendNode(New Object() {"أشارة الى الكتب الواردة"}, parentForRootNodes)
                Dim BookActionsNode As TreeListNode = TreeList1.AppendNode(New Object() {"الاجرائات"}, parentForRootNodes)

                BookIdNode.StateImageIndex = 5
                BookIdNode.Tag = New Object() {ttype.ToString + ImpId.ToString}
                BookExpDenoteNode.StateImageIndex = 2
                BookImpDenoteNode.StateImageIndex = 0
                BookActionsNode.StateImageIndex = 1


                Dim Ndata As NewDBFDataSet.ImportDocDataTable = Me.ImportDocTableAdapter.GetDataByID(ImpId)
                Dim Nrow As NewDBFDataSet.ImportDocRow

                For Each Nrow In Ndata
                    tmpNode = TreeList1.AppendNode(New Object() {"رقم الكتاب" + " : " + Nrow("Import_No").ToString}, BookIdNode)
                    tmpNode.Tag = New Object() {ttype.ToString + ImpId.ToString}
                    tmpNode.StateImageIndex = 7
                    tmpNode2 = TreeList1.AppendNode(New Object() {"تاريخ الكتاب" + " : " + Nrow("Import_Date").ToString.Remove(Nrow("Import_Date").ToString.Length - 11, 11)}, BookIdNode)
                    tmpNode2.StateImageIndex = 7
                    tmpNode2 = TreeList1.AppendNode(New Object() {"درجة السرية" + " : " + Me.SecurityTableAdapter.FillBySec(Val(Nrow("Security_Code"))).Trim}, BookIdNode)
                    tmpNode2.StateImageIndex = 7
                    tmpNode2 = TreeList1.AppendNode(New Object() {"نوع الكتاب" + " : " + Me.TypeTableAdapter.FillByType(Val(Nrow("Type_Code"))).Trim}, BookIdNode)
                    tmpNode2.StateImageIndex = 7
                    tmpNode2 = TreeList1.AppendNode(New Object() {"جهة الاصدار" + " : " + Me.OrgTableAdapter.FillByNo(Nrow("Import_Org_No")).Trim}, BookIdNode)
                    tmpNode2.StateImageIndex = 7
                    tmpNode2 = TreeList1.AppendNode(New Object() {"الموضوع" + " : " + Nrow("Subject")}, BookIdNode)
                    tmpNode2.StateImageIndex = 7
                Next

                Dim Idata As NewDBFDataSet.Fill_IDataTable = Me.Fill_ITableAdapter.GetData(ImpId)
                Dim Irow As NewDBFDataSet.Fill_IRow
                For Each Irow In Idata
                    tmpStr = "الكتاب " + " : " + Irow("Book_No").ToString.Trim + " " + "بتاريخ " + " : " + Irow("Book_Date").ToString.Remove(Irow("Book_Date").ToString.Length - 11, 11) + " " + "وارد من" + " : " + Me.OrgTableAdapter.FillByNo(Irow("Book_Org_No")).Trim

                    tmpNode = TreeList1.AppendNode(New Object() {tmpStr}, BookImpDenoteNode)
                    If Irow("ExportId").ToString <> "" Then
                        If Irow("ExportId") > 0 Then
                            tmpNode.StateImageIndex = 8
                            tmpNode.Tag = New Object() {"I" + Irow("ExportId").ToString}
                            Add_Tree_Node(tmpNode, Irow("ExportId"), parentId - 1, "I")
                        Else
                            tmpNode.StateImageIndex = 7
                        End If
                    End If

                Next

                Dim Edata As NewDBFDataSet.Fill_EDataTable = Me.Fill_ETableAdapter.GetData(ImpId)
                Dim Erow As NewDBFDataSet.Fill_ERow
                For Each Erow In Edata
                    tmpStr = "الكتاب " + " : " + Erow("Book_No").ToString.Trim + " " + "بتاريخ " + " : " + Erow("Book_Date").ToString.Remove(Erow("Book_Date").ToString.Length - 11, 11) ' +  " " + " صادر الى" + " : " + Me.OrgTableAdapter.FillByNo(Erow("Book_Org_No")).Trim
                    tmpNode = TreeList1.AppendNode(New Object() {tmpStr}, BookExpDenoteNode)
                    tmpNode.StateImageIndex = 7
                    tmpNode.Tag = New Object() {"E" + Erow("ExportId").ToString}


                Next
                Dim Adata As NewDBFDataSet.Import_ActionDataTable = Me.Import_ActionTableAdapter.GetDataByID(ImpId)
                Dim Arow As NewDBFDataSet.Import_ActionRow
                For Each Arow In Adata
                    If Arow("Cur_Org").ToString <> "" Then
                        ttstr = Me.OrgTableAdapter.FillByNo(Arow("Cur_Org")).Trim
                    Else
                        ttstr = ".........."
                    End If

                    tmpStr = "الاجراء :" + Me.ActionsTableAdapter.FillByAc(Arow("Action_Type")).ToString.Trim + " " + "بتاريخ : " + Arow("Action_Date").ToString.Remove(Arow("Action_Date").ToString.Length - 11, 11) + " " + "من قبل " + ttstr

                    tmpNode = TreeList1.AppendNode(New Object() {tmpStr}, BookActionsNode)


                    If Arow("Action_Type") = 4 Then
                        tmpNode.StateImageIndex = 8
                        tmpNode2 = TreeList1.AppendNode(New Object() {"الكتب المشار اليها بهذا الصادر"}, tmpNode)
                        tmpNode2.StateImageIndex = 8
                        Dim AEdata As NewDBFDataSet.Import_DenoteExportedDataTable = Me.Import_DenoteExportedTableAdapter.GetData(Arow("ExportedId"))
                        Dim AErow As NewDBFDataSet.Import_DenoteExportedRow
                        For Each AErow In AEdata
                            Add_Tree_Node(tmpNode2, AErow("importId"), parentId - 1, "I")
                        Next
                    Else
                        tmpNode.StateImageIndex = 7

                    End If


                Next
                'If ImpId > 0 Then
                '    Add_Tree_Node(BookActionsNode, ImpId - 1)
                'End If
                ' Create a child node for the node1            
                ' TreeList1.AppendNode(New Object() {"رقم الكتاب" + "2233"}, rootNode)
                ' Creating more nodes
                ' ...
                TreeList1.EndUnboundLoad()

                parentId = parentId - 1

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
            TreeList1.ExpandAll()
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

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            TreeList1.CollapseAll()
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

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            TreeList1.ShowPrintPreview()
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

    Private Sub TreeList1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick
        If Not TreeList1.FocusedNode.Tag Is Nothing Then

            Dim tmp As String

            Select Case Strings.Left(TreeList1.FocusedNode.Tag(0).ToString, 1)
                Case "I"
                    tmp = Strings.Right(TreeList1.FocusedNode.Tag(0).ToString, TreeList1.FocusedNode.Tag(0).ToString.Length - 1)
                    If tmp <> Nothing Then
                        SelectedImpIDProperty = tmp
                        If SelectedImpIDProperty <> "" Then
                            EditOrAddProperty = "EDIT"

                            ffrm = NewImpForm
                            ffrm.Show()
                        End If

                    End If
                Case "E"
                    tmp = Strings.Right(TreeList1.FocusedNode.Tag(0).ToString, TreeList1.FocusedNode.Tag(0).ToString.Length - 1)
                    If tmp <> Nothing Then
                        SelectedExpIDProperty = tmp
                        If SelectedExpIDProperty <> "" Then
                            EditOrAddexpProperty = "EDIT"

                            ffrmexp = NewExpForm
                            ffrmexp.Show()
                        End If

                    End If
            End Select

        End If


    End Sub
End Class