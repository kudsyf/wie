Imports System.IO

Public Class EmailImportList

    Private Sub EmailImportList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.EmailImportsTableAdapter.FillByEmailOrg(Me.NewDBFDataSet.EmailImports, CurOrgNo)
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

            EmailImportsTableAdapter.DeleteImport(GridView1.GetFocusedDataRow("ImportId").ToString, CurOrgNo, GridView1.GetFocusedDataRow("ImportNo").ToString)

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

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class