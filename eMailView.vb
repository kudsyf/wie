Imports Rebex.Mail
Imports System.IO


Public Class eMailView
    Public iMessage As MailMessage
    Dim stream As MemoryStream
    Dim AttachArray() As Byte
    Dim sd As Byte()
    


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click


        Try

            Dim d() As Byte
            FolderBrowserDialog1.ShowDialog()
            Dim Ndata As NewDBFDataSet.EmailImports_AttachDataTable = Me.EmailImports_AttachTableAdapter1.GetDataBy3(SelectedemailImpIDProperty)
            Dim Nrow As NewDBFDataSet.EmailImports_AttachRow

            For Each Nrow In Ndata
                d = Nrow("AttachBin")
                Dim fsm As FileStream
                fsm = File.OpenWrite(FolderBrowserDialog1.SelectedPath + "\" + Nrow("AttachName").ToString.Trim)
                fsm.Write(d, 0, d.Length)
                fsm.Close()

            Next


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

    Private Sub eMailView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.EmailImports_ActionTableAdapter1.FillByOrgID(NewDBFDataSet.EmailImports_Action, CurOrgNo, SelectedemailImpIDProperty)

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

    Private Sub eMailView_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            stream = Nothing
            iMessage = Nothing

            Me.Hide()
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

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim emac As New eMailAction
            EMailActionTypeProperty = ""
            emac.ShowDialog()

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

            EMailActionTypeProperty = "FW"
            emac.LayoutControlItem11.Visibility = True
            emac.LayoutControlItem12.Visibility = True
            emac.LayoutControlItem4.Visibility = True
            emac.FromTxt.EditValue = OrgemailTableAdapter1.GetEmail(CurOrgNo).Trim
            emac.FromTxt.Enabled = False
            emac.SubjectTxt.EditValue = SubjectTxt.EditValue.ToString.Trim
            emac.SubjectTxt.Properties.ReadOnly = False
            Dim myEncoder As New System.Text.ASCIIEncoding
            Dim bytes As Byte() = myEncoder.GetBytes(WebBrowser1.DocumentText)
            Dim ms As MemoryStream = New MemoryStream(bytes)


            emac.RichEditControl1.LoadDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.Html)




            Dim Ndata As NewDBFDataSet.EmailImports_AttachDataTable = Me.EmailImports_AttachTableAdapter1.GetDataBy3(SelectedemailImpIDProperty)
            Dim Nrow As NewDBFDataSet.EmailImports_AttachRow

            Dim table2 As DataTable = New DataTable("Attach")
            table2.Columns.Add("ico")
            table2.Columns.Add("Attach")
            table2.Columns.Add("Sel")
            table2.Columns.Add("AttachBin")
            table2.Columns("AttachBin").DataType = System.Type.GetType("System.Byte[]")

            table2.Columns("Sel").DataType = System.Type.GetType("System.Boolean")


            Dim id As Int16 = -1

            For Each Nrow In Ndata
                Select Case Strings.Right(Nrow("AttachName").ToString.Trim, 4).ToLower
                    Case "docx"
                        id = 4
                    Case "pptx"
                        id = 6
                    Case "xlsx"
                        id = 2
                End Select

                Select Case Strings.Right(Nrow("AttachName").ToString.Trim, 3).ToLower
                    Case "jpg"
                        id = 3
                    Case "bmp"
                        id = 3
                    Case "gif"
                        id = 3
                    Case "doc"
                        id = 4
                    Case "ppt"
                        id = 6
                    Case "xls"
                        id = 2
                    Case "mdb"
                        id = 1
                    Case "txt"
                        id = 7
                    Case "rar"
                        id = 9
                    Case "zip"
                        id = 9
                    Case "pdf"
                        id = 5
                End Select
                If id = -1 Then
                    id = 8
                End If
                sd = Nrow("AttachBin")
                table2.Rows.Add(id, Nrow("AttachName").ToString.Trim, True, sd)

            Next
            Dim set2 As DataSet = New DataSet("Attach")

            Dim dvm2 As DataViewManager = New DataViewManager(set2)

            Dim myDatatView2 As DataView = dvm2.CreateDataView(table2)


            emac.GridControl1.DataSource = Nothing
            emac.GridControl1.DataMember = Nothing
            emac.GridControl1.DataSource = myDatatView2


            emac.GridView1.Columns(0).FieldName = "ico"
            emac.GridView1.Columns(1).FieldName = "Attach"
            emac.GridView1.Columns(2).FieldName = "Sel"
            emac.GridView1.Columns(3).FieldName = "AttachBin"

            emac.GridView1.Columns(1).OptionsColumn.AllowEdit = False
            emac.GridView1.Columns(0).OptionsColumn.AllowEdit = False
            emac.GridView1.Columns(2).OptionsColumn.AllowEdit = True
            emac.GridView1.Columns(2).OptionsColumn.ShowCaption = False



            Dim CCfields() As String
            If CCTxt.EditValue Is Nothing Then

            Else
                CCfields = Split(CCTxt.EditValue.ToString.Trim, ";")
                Dim tableCC As DataTable = New DataTable("EmailCC")
                tableCC.Columns.Add("CC")
                tableCC.Columns.Add("Sel")
                tableCC.Columns("Sel").DataType = System.Type.GetType("System.Boolean")


                For Each ccs As String In CCfields
                    If ccs.Trim <> "" Then
                        tableCC.Rows.Add(ccs.Trim, True)
                    End If

                Next
                Dim setCC As DataSet = New DataSet("EmailCC")
                Dim dvmCC As DataViewManager = New DataViewManager(setCC)
                Dim myDatatViewCC As DataView = dvmCC.CreateDataView(tableCC)
                emac.GridControl3.DataSource = Nothing
                emac.GridControl3.DataMember = Nothing
                emac.GridControl3.DataSource = myDatatViewCC
                emac.GridView3.Columns(0).FieldName = "CC"
                emac.GridView3.Columns(1).FieldName = "Sel"
                emac.GridView3.Columns(1).OptionsColumn.AllowEdit = True
                emac.GridView3.Columns(0).OptionsColumn.AllowEdit = False
                emac.GridView3.Columns(1).OptionsColumn.ShowCaption = False
            End If




            Dim Todata As NewDBFDataSet.orgemailDataTable = Me.OrgemailTableAdapter1.ListEmails(CurOrgNo)
            Dim Torow As NewDBFDataSet.orgemailRow


            Dim tableTo As DataTable = New DataTable("EmailTo")
            tableTo.Columns.Add("To")
            tableTo.Columns.Add("Org")
            tableTo.Columns.Add("Sel")
            tableTo.Columns("Sel").DataType = System.Type.GetType("System.Boolean")


            For Each Torow In Todata
                tableTo.Rows.Add(OrgTableAdapter1.GetOrgByNo(Torow.Org.Trim).ToString.Trim, Torow.email.Trim, True)
            Next

            Dim setTo As DataSet = New DataSet("EmailTo")
            Dim dvmTo As DataViewManager = New DataViewManager(setTo)
            Dim myDatatViewTo As DataView = dvmTo.CreateDataView(tableTo)
            emac.GridControl2.DataSource = Nothing
            emac.GridControl2.DataMember = Nothing

            emac.GridView2.Columns(0).FieldName = "To"
            emac.GridView2.Columns(2).FieldName = "Sel"
            emac.GridView2.Columns(1).FieldName = "Org"
            emac.GridView2.Columns(1).OptionsColumn.AllowEdit = False
            emac.GridView2.Columns(0).OptionsColumn.AllowEdit = False
            emac.GridView2.Columns(2).OptionsColumn.AllowEdit = True
            emac.GridView2.Columns(2).OptionsColumn.ShowCaption = False

            emac.GridView2.Columns(1).Visible = False

            emac.GridControl2.DataSource = myDatatViewTo

            emac.ShowDialog()

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

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try

            EMailActionTypeProperty = "RE"
            emac.LayoutControlItem11.Visibility = False
            emac.LayoutControlItem12.Visibility = False
            emac.LayoutControlItem4.Visibility = False
            emac.FromTxt.EditValue = OrgemailTableAdapter1.GetEmail(CurOrgNo).Trim
            emac.FromTxt.Enabled = False
            emac.SubjectTxt.EditValue = SubjectTxt.EditValue.ToString.Trim
            emac.SubjectTxt.Properties.ReadOnly = False


            Dim myEncoder As New System.Text.ASCIIEncoding
            Dim bytes As Byte() = myEncoder.GetBytes(WebBrowser1.DocumentText)
            Dim ms As MemoryStream = New MemoryStream(bytes)


            emac.RichEditControl1.LoadDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.Html)

            Dim Ndata As NewDBFDataSet.EmailImports_AttachDataTable = Me.EmailImports_AttachTableAdapter1.GetDataBy3(SelectedemailImpIDProperty)
            Dim Nrow As NewDBFDataSet.EmailImports_AttachRow

            Dim table2 As DataTable = New DataTable("Attach")
            table2.Columns.Add("ico")
            table2.Columns.Add("Attach")
            table2.Columns.Add("Sel")
            table2.Columns.Add("AttachBin")
            table2.Columns("AttachBin").DataType = System.Type.GetType("System.Byte[]")

            table2.Columns("Sel").DataType = System.Type.GetType("System.Boolean")


            Dim id As Int16 = -1

            For Each Nrow In Ndata
                Select Case Strings.Right(Nrow("AttachName").ToString.Trim, 4).ToLower
                    Case "docx"
                        id = 4
                    Case "pptx"
                        id = 6
                    Case "xlsx"
                        id = 2
                End Select

                Select Case Strings.Right(Nrow("AttachName").ToString.Trim, 3).ToLower
                    Case "jpg"
                        id = 3
                    Case "bmp"
                        id = 3
                    Case "gif"
                        id = 3
                    Case "doc"
                        id = 4
                    Case "ppt"
                        id = 6
                    Case "xls"
                        id = 2
                    Case "mdb"
                        id = 1
                    Case "txt"
                        id = 7
                    Case "rar"
                        id = 9
                    Case "zip"
                        id = 9
                    Case "pdf"
                        id = 5
                End Select
                If id = -1 Then
                    id = 8
                End If
                sd = Nrow("AttachBin")
                table2.Rows.Add(id, Nrow("AttachName").ToString.Trim, True, sd)

            Next
            Dim set2 As DataSet = New DataSet("Attach")

            Dim dvm2 As DataViewManager = New DataViewManager(set2)

            Dim myDatatView2 As DataView = dvm2.CreateDataView(table2)


            emac.GridControl1.DataSource = Nothing
            emac.GridControl1.DataMember = Nothing
            emac.GridControl1.DataSource = myDatatView2


            emac.GridView1.Columns(0).FieldName = "ico"
            emac.GridView1.Columns(1).FieldName = "Attach"
            emac.GridView1.Columns(2).FieldName = "Sel"
            emac.GridView1.Columns(3).FieldName = "AttachBin"

            emac.GridView1.Columns(1).OptionsColumn.AllowEdit = False
            emac.GridView1.Columns(0).OptionsColumn.AllowEdit = False
            emac.GridView1.Columns(2).OptionsColumn.AllowEdit = True
            emac.GridView1.Columns(2).OptionsColumn.ShowCaption = False



            Dim CCfields() As String
            If CCTxt.EditValue Is Nothing Then

            Else
                CCfields = Split(CCTxt.EditValue.ToString.Trim, ";")
                Dim tableCC As DataTable = New DataTable("EmailCC")
                tableCC.Columns.Add("CC")
                tableCC.Columns.Add("Sel")
                tableCC.Columns("Sel").DataType = System.Type.GetType("System.Boolean")


                For Each ccs As String In CCfields
                    If ccs.Trim <> "" Then
                        tableCC.Rows.Add(ccs.Trim, True)
                    End If

                Next
                Dim setCC As DataSet = New DataSet("EmailCC")
                Dim dvmCC As DataViewManager = New DataViewManager(setCC)
                Dim myDatatViewCC As DataView = dvmCC.CreateDataView(tableCC)
                emac.GridControl3.DataSource = Nothing
                emac.GridControl3.DataMember = Nothing
                emac.GridControl3.DataSource = myDatatViewCC
                emac.GridView3.Columns(0).FieldName = "CC"
                emac.GridView3.Columns(1).FieldName = "Sel"
                emac.GridView3.Columns(1).OptionsColumn.AllowEdit = True
                emac.GridView3.Columns(0).OptionsColumn.AllowEdit = False
                emac.GridView3.Columns(1).OptionsColumn.ShowCaption = False
            End If




            Dim Todata As NewDBFDataSet.orgemailDataTable = Me.OrgemailTableAdapter1.ListEmails(CurOrgNo)
            Dim Torow As NewDBFDataSet.orgemailRow


            Dim tableTo As DataTable = New DataTable("EmailTo")
            tableTo.Columns.Add("To")
            tableTo.Columns.Add("Org")
            tableTo.Columns.Add("Sel")
            tableTo.Columns("Sel").DataType = System.Type.GetType("System.Boolean")


            For Each Torow In Todata
                tableTo.Rows.Add(OrgTableAdapter1.GetOrgByNo(Torow.Org.Trim).ToString.Trim, Torow.email.Trim, True)
            Next

            Dim setTo As DataSet = New DataSet("EmailTo")
            Dim dvmTo As DataViewManager = New DataViewManager(setTo)
            Dim myDatatViewTo As DataView = dvmTo.CreateDataView(tableTo)
            emac.GridControl2.DataSource = Nothing
            emac.GridControl2.DataMember = Nothing

            emac.GridView2.Columns(0).FieldName = "To"
            emac.GridView2.Columns(2).FieldName = "Sel"
            emac.GridView2.Columns(1).FieldName = "Org"
            emac.GridView2.Columns(1).OptionsColumn.AllowEdit = False
            emac.GridView2.Columns(0).OptionsColumn.AllowEdit = False
            emac.GridView2.Columns(2).OptionsColumn.AllowEdit = True
            emac.GridView2.Columns(2).OptionsColumn.ShowCaption = False


            emac.GridView2.Columns(1).Visible = False

            emac.GridControl2.DataSource = myDatatViewTo

            emac.ShowDialog()

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
        Me.Hide()

    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            Dim dell As Int32
            Dim Actt As Int32

            dell = GridView2.GetFocusedDataRow("ImportId")
            Actt = GridView2.GetFocusedDataRow("ActionId")

            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Me.EmailImports_ActionTableAdapter1.DeleteAction(dell, Actt)
            GridView2.DeleteSelectedRows()
            '  SaveSession(SessionType.DelExpAction)


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
            NewEmailFrm = New NewEmailActionForm
            NewEmailFrm.XtraTabPage3.PageVisible = False
            NewEmailFrm.XtraTabPage2.PageVisible = True
            EMailActTypeProperty = "I_Save"
            NewEmailFrm.ShowDialog()

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

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick

        Try
            NewEmailFrm = New NewEmailActionForm
            NewEmailFrm.XtraTabPage3.PageVisible = True
            NewEmailFrm.XtraTabPage2.PageVisible = False
            EMailActTypeProperty = "I_Other"
            NewEmailFrm.ShowDialog()

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

    Private Sub SimpleButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            Dim dell As Int32
            Dim Actt As Int32

            dell = GridView2.GetFocusedDataRow("ImportId")
            Actt = GridView2.GetFocusedDataRow("ActionId")

            If Me.EmailImports_ActionTableAdapter1.isDone(dell, Actt) Then

                DevExpress.XtraEditors.XtraMessageBox.Show("الاجراء منتهي سابقا")
                Return
            Else

                If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على انهاء الاجراء ؟", "تاكيد انهاء الاجراء", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                Me.EmailImports_ActionTableAdapter1.MarkDone(dell, Actt)
                Me.EmailImports_ActionTableAdapter1.FillByOrgID(NewDBFDataSet.EmailImports_Action, CurOrgNo, SelectedemailImpIDProperty)
                GridView2.RefreshData()
            End If

            '  SaveSession(SessionType.DelExpAction)


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