Public Class EmailFollowup

    Private Sub EmailFollowup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBoxEdit1.SelectedIndex = 0
            RadioGroup1.SelectedIndex = 0
            ComboBoxEdit2.SelectedIndex = 0
            Me.EmailListTableAdapter.FillAll(Me.NewDBFDataSet.EmailList)
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

    Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        Try
            Select Case ComboBoxEdit1.SelectedIndex
                Case 0
                    Me.EmailListTableAdapter.FillAll(Me.NewDBFDataSet.EmailList)
                    LookUpEdit1.Update()

                Case 1
                    Me.EmailListTableAdapter.FillTO(Me.NewDBFDataSet.EmailList)
                    LookUpEdit1.Update()
                Case 2
                    Me.EmailListTableAdapter.FillCC(Me.NewDBFDataSet.EmailList)
                    LookUpEdit1.Update()
                Case 3
                    Me.EmailListTableAdapter.FillFROM(Me.NewDBFDataSet.EmailList)
                    LookUpEdit1.Update()
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            If RadioGroup1.SelectedIndex = 0 Then

                Select Case ComboBoxEdit1.SelectedIndex
                    Case 0  ' الكل
                        EmailImportsFollowUpTableAdapter.FollowImpByAll(NewDBFDataSet.EmailImportsFollowUp, LookUpEdit1.EditValue.ToString.Trim, CurOrgNo)
                        GridView1.RefreshData()

                        GridControl2.Enabled = True
                        EmailExportsFollowUpTableAdapter.FollowExpByAll(NewDBFDataSet.EmailExportsFollowUp, LookUpEdit1.EditValue.ToString.Trim, CurOrgNo)
                        GridView2.RefreshData()


                    Case 1   ' الى
                        EmailImportsFollowUpTableAdapter.FollowImpByTO(NewDBFDataSet.EmailImportsFollowUp, LookUpEdit1.EditValue.ToString.Trim, CurOrgNo)
                        GridView1.RefreshData()

                        GridControl2.Enabled = True
                        EmailExportsFollowUpTableAdapter.FollowExpByTO(NewDBFDataSet.EmailExportsFollowUp, LookUpEdit1.EditValue.ToString.Trim, CurOrgNo)
                        GridView2.RefreshData()
                    Case 2   ' نسخة الى
                        EmailImportsFollowUpTableAdapter.FollowImpByCC(NewDBFDataSet.EmailImportsFollowUp, LookUpEdit1.EditValue.ToString.Trim, CurOrgNo)
                        GridView1.RefreshData()

                        GridControl2.Enabled = True
                        EmailExportsFollowUpTableAdapter.FollowExpByCC(NewDBFDataSet.EmailExportsFollowUp, LookUpEdit1.EditValue.ToString.Trim, CurOrgNo)
                        GridView2.RefreshData()
                    Case 3    ' من
                        EmailImportsFollowUpTableAdapter.FollowImpByFrom(NewDBFDataSet.EmailImportsFollowUp, LookUpEdit1.EditValue.ToString.Trim, CurOrgNo)
                        GridView1.RefreshData()
                        GridControl2.Enabled = False


                End Select

            Else
                If TextEdit1.EditValue = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("حقل البحث فارغ ... الرجاء التاكد")
                    Return
                Else

                    Select Case ComboBoxEdit2.SelectedIndex
                        Case 0    'الكل
                            EmailImportsFollowUpTableAdapter.FollowImpTxtAll(NewDBFDataSet.EmailImportsFollowUp, CurOrgNo, TextEdit1.EditValue.ToString.Trim)
                            GridView1.RefreshData()

                            GridControl2.Enabled = True
                            EmailExportsFollowUpTableAdapter.FollowExpTxtAll(NewDBFDataSet.EmailExportsFollowUp, CurOrgNo, TextEdit1.EditValue.ToString.Trim)
                            GridView2.RefreshData()


                        Case 1     'الموضوع
                            EmailImportsFollowUpTableAdapter.FollowImpTxtSubject(NewDBFDataSet.EmailImportsFollowUp, CurOrgNo, TextEdit1.EditValue.ToString.Trim)
                            GridView1.RefreshData()

                            GridControl2.Enabled = True
                            EmailExportsFollowUpTableAdapter.FollowExpTxtSubject(NewDBFDataSet.EmailExportsFollowUp, CurOrgNo, TextEdit1.EditValue.ToString.Trim)
                            GridView2.RefreshData()

                        Case 2     'الرسالة
                            EmailImportsFollowUpTableAdapter.FollowImpTxtBody(NewDBFDataSet.EmailImportsFollowUp, CurOrgNo, TextEdit1.EditValue.ToString.Trim)
                            GridView1.RefreshData()

                            GridControl2.Enabled = True
                            EmailExportsFollowUpTableAdapter.FollowExpTxtBody(NewDBFDataSet.EmailExportsFollowUp, CurOrgNo, TextEdit1.EditValue.ToString.Trim)
                            GridView2.RefreshData()

                    End Select
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



    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Try
            Select Case RadioGroup1.SelectedIndex
                Case 0
                    ComboBoxEdit1.Enabled = True
                    LookUpEdit1.Enabled = True

                    ComboBoxEdit2.Enabled = False
                    TextEdit1.Enabled = False
                Case 1
                    ComboBoxEdit1.Enabled = False
                    LookUpEdit1.Enabled = False


                    ComboBoxEdit2.Enabled = True
                    TextEdit1.Enabled = True

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

    Private Sub GridControl1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Try
            Dim tmp As String
            Dim sd() As Byte
            tmp = GridView1.GetFocusedDataRow("ImportId")
            If tmp <> Nothing Then
                SelectedemailImpIDProperty = tmp
                If SelectedemailImpIDProperty <> "" Then
                    eeffrm = New eMailView
                    eeffrm.FromTxt.EditValue = GridView1.GetFocusedDataRow("EmailFrom").ToString
                    eeffrm.SubjectTxt.EditValue = GridView1.GetFocusedDataRow("EmailSubject").ToString
                    eeffrm.LookUpEdit1.EditValue = GridView1.GetFocusedDataRow("ImportNo").ToString
                    eeffrm.DateEdit1.EditValue = GridView1.GetFocusedDataRow("ImportDate").ToString
                    eeffrm.DateTxt.EditValue = GridView1.GetFocusedDataRow("EmailDate").ToString
                    eeffrm.WebBrowser1.DocumentText = GridView1.GetFocusedDataRow("Email").ToString


                    Dim Ndata As NewDBFDataSet.EmailImports_AttachDataTable = Me.EmailImports_AttachTableAdapter1.GetDataBy3(SelectedemailImpIDProperty)
                    Dim Nrow As NewDBFDataSet.EmailImports_AttachRow

                    Dim table2 As DataTable = New DataTable("Attach")
                    table2.Columns.Add("ico")
                    table2.Columns.Add("Attach")
                    table2.Columns.Add("AttachBin")
                    table2.Columns("AttachBin").DataType = System.Type.GetType("System.Byte[]")

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
                        table2.Rows.Add(id, Nrow("AttachName").ToString.Trim, sd)

                    Next
                    Dim set2 As DataSet = New DataSet("Attach")

                    Dim dvm2 As DataViewManager = New DataViewManager(set2)

                    Dim myDatatView2 As DataView = dvm2.CreateDataView(table2)


                    eeffrm.GridControl1.DataSource = Nothing
                    eeffrm.GridControl1.DataMember = Nothing
                    eeffrm.GridControl1.DataSource = myDatatView2


                    eeffrm.GridView1.Columns(0).FieldName = "ico"
                    eeffrm.GridView1.Columns(1).FieldName = "Attach"
                    eeffrm.GridView1.Columns(2).FieldName = "AttachBin"


                    Dim Todata As NewDBFDataSet.EmailImports_TO_CCDataTable = Me.EmailImports_TO_CCTableAdapter1.GetDataBy1(SelectedemailImpIDProperty)
                    Dim Torow As NewDBFDataSet.EmailImports_TO_CCRow
                    For Each Torow In Todata

                        eeffrm.ToTxt.EditValue = eeffrm.ToTxt.EditValue + Torow("eAddress").ToString.Trim + " ; "
                    Next

                    Dim CCdata As NewDBFDataSet.EmailImports_TO_CCDataTable = Me.EmailImports_TO_CCTableAdapter1.GetDataBy2(SelectedemailImpIDProperty)
                    Dim CCrow As NewDBFDataSet.EmailImports_TO_CCRow
                    For Each CCrow In CCdata

                        eeffrm.CCTxt.EditValue = eeffrm.CCTxt.EditValue + CCrow("eAddress").ToString.Trim + " ; "
                    Next

                    eeffrm.Show()
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

    Private Sub GridControl2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl2.DoubleClick
        Try
            Dim tmp As String

            tmp = GridView1.GetFocusedDataRow("ExportId")
            If tmp <> Nothing Then
                SelectedemailExpIDProperty = tmp
                If SelectedemailExpIDProperty <> "" Then
                    eXeeffrm = New ExpeMailView
                    eXeeffrm.FromTxt.EditValue = OrgemailTableAdapter1.GetEmail(CurOrgNo).ToString.Trim
                    eXeeffrm.SubjectTxt.EditValue = GridView1.GetFocusedDataRow("EmailSubject").ToString
                    eXeeffrm.LookUpEdit1.EditValue = GridView1.GetFocusedDataRow("ExportNo").ToString
                    eXeeffrm.DateEdit1.EditValue = GridView1.GetFocusedDataRow("ExportDate").ToString
                    'eXeeffrm.DateTxt.EditValue = GridView1.GetFocusedDataRow("EmailDate").ToString
                    eXeeffrm.WebBrowser1.DocumentText = GridView1.GetFocusedDataRow("Email").ToString

                    Dim Todata As NewDBFDataSet.EmailExports_TO_CCDataTable = Me.EmailExports_TO_CCTableAdapter1.GetTo(SelectedemailExpIDProperty)
                    Dim Torow As NewDBFDataSet.EmailExports_TO_CCRow
                    For Each Torow In Todata

                        eXeeffrm.ToTxt.EditValue = eXeeffrm.ToTxt.EditValue + Torow("eAddress").ToString.Trim + " ; "
                    Next

                    Dim CCdata As NewDBFDataSet.EmailExports_TO_CCDataTable = Me.EmailExports_TO_CCTableAdapter1.GetCC(SelectedemailExpIDProperty)
                    Dim CCrow As NewDBFDataSet.EmailExports_TO_CCRow
                    For Each CCrow In CCdata

                        eXeeffrm.CCTxt.EditValue = eXeeffrm.CCTxt.EditValue + CCrow("eAddress").ToString.Trim + " ; "
                    Next


                    Dim Ndata As NewDBFDataSet.EmailExports_AttachDataTable = Me.EmailExports_AttachTableAdapter1.GetDataBy2(SelectedemailExpIDProperty)
                    Dim Nrow As NewDBFDataSet.EmailExports_AttachRow

                    Dim table2 As DataTable = New DataTable("Attach")
                    table2.Columns.Add("ico")
                    table2.Columns.Add("Attach")

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

                        table2.Rows.Add(id, Nrow("AttachName").ToString.Trim)

                    Next
                    Dim set2 As DataSet = New DataSet("Attach")

                    Dim dvm2 As DataViewManager = New DataViewManager(set2)

                    Dim myDatatView2 As DataView = dvm2.CreateDataView(table2)


                    eXeeffrm.GridControl1.DataSource = Nothing
                    eXeeffrm.GridControl1.DataMember = Nothing
                    eXeeffrm.GridControl1.DataSource = myDatatView2


                    eXeeffrm.GridView1.Columns(0).FieldName = "ico"
                    eXeeffrm.GridView1.Columns(1).FieldName = "Attach"



                    '     

                    eXeeffrm.Show()
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