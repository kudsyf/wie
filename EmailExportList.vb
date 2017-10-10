Public Class EmailExportList

    Private Sub EmailExportList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.EmailExports' table. You can move, or remove it, as needed.

        Try
            Me.EmailExportsTableAdapter.FillByOrg(Me.NewDBFDataSet.EmailExports, CurOrgNo)
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

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Try
            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

            EmailExportsTableAdapter.DeleteExport(GridView1.GetFocusedDataRow("ExportId").ToString, CurOrgNo, GridView1.GetFocusedDataRow("ExportNo").ToString)

            GridView1.DeleteSelectedRows()

            '  SaveSession(SessionType.DelImp)
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

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class