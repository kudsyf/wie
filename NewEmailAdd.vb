Public Class NewEmailAdd

    Private Sub NewEmailAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Hide()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            If NameTxt.EditValue Is Nothing Then

                DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة")
                Return

            Else
                If eMailTxt.EditValue Is Nothing Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("احد الحقول فارغة")
                    Return
                Else
                    If Not eMailTxt.DoValidate Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("عنوان البريد الالكتروني خاطئ")
                        Return
                    Else
                        Select Case EMailActionAddTypeProperty

                            Case "TO"
                                Select Case EMailActionAddFromProperty
                                    Case "Action"
                                        Dim tableTo As DataTable = New DataTable("EmailTo")
                                        tableTo.Columns.Add("To")
                                        tableTo.Columns.Add("Org")
                                        tableTo.Columns.Add("Sel")
                                        tableTo.Columns("Sel").DataType = System.Type.GetType("System.Boolean")

                                        Dim er As Integer
                                        For er = 0 To emac.GridView2.RowCount - 1
                                            tableTo.Rows.Add(emac.GridView2.GetDataRow(er).Item("To").ToString, emac.GridView2.GetDataRow(er).Item("Org").ToString, emac.GridView2.GetDataRow(er).Item("Sel"))
                                        Next
                                        tableTo.Rows.Add(NameTxt.EditValue.ToString.Trim, eMailTxt.EditValue.ToString.Trim, True)
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

                                    Case "New"

                                        Dim tableTo As DataTable = New DataTable("EmailTo")
                                        tableTo.Columns.Add("To")
                                        tableTo.Columns.Add("Org")
                                        tableTo.Columns.Add("Sel")
                                        tableTo.Columns("Sel").DataType = System.Type.GetType("System.Boolean")

                                        Dim er As Integer
                                        For er = 0 To emad.GridView2.RowCount - 1
                                            tableTo.Rows.Add(emad.GridView2.GetDataRow(er).Item("To").ToString, emad.GridView2.GetDataRow(er).Item("Org").ToString, emad.GridView2.GetDataRow(er).Item("Sel"))
                                        Next
                                        tableTo.Rows.Add(NameTxt.EditValue.ToString.Trim, eMailTxt.EditValue.ToString.Trim, True)
                                        Dim setTo As DataSet = New DataSet("EmailTo")
                                        Dim dvmTo As DataViewManager = New DataViewManager(setTo)
                                        Dim myDatatViewTo As DataView = dvmTo.CreateDataView(tableTo)
                                        emad.GridControl2.DataSource = Nothing
                                        emad.GridControl2.DataMember = Nothing

                                        emad.GridView2.Columns(0).FieldName = "To"
                                        emad.GridView2.Columns(2).FieldName = "Sel"
                                        emad.GridView2.Columns(1).FieldName = "Org"
                                        emad.GridView2.Columns(1).OptionsColumn.AllowEdit = False
                                        emad.GridView2.Columns(0).OptionsColumn.AllowEdit = False
                                        emad.GridView2.Columns(2).OptionsColumn.AllowEdit = True
                                        emad.GridView2.Columns(2).OptionsColumn.ShowCaption = False


                                        emad.GridView2.Columns(1).Visible = False

                                        emad.GridControl2.DataSource = myDatatViewTo


                                End Select
                              
                            Case "CC"
                                Select Case EMailActionAddFromProperty
                                    Case "Action"
                                        Dim tableCC As DataTable = New DataTable("EmailCC")
                                        tableCC.Columns.Add("CC")
                                        tableCC.Columns.Add("Sel")
                                        tableCC.Columns("Sel").DataType = System.Type.GetType("System.Boolean")
                                        Dim er As Integer
                                        For er = 0 To emac.GridView3.RowCount - 1
                                            tableCC.Rows.Add(emac.GridView3.GetDataRow(er).Item("CC").ToString, emac.GridView3.GetDataRow(er).Item("Sel"))
                                        Next
                                        tableCC.Rows.Add(eMailTxt.EditValue.ToString.Trim, True)
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
                                    Case "New"
                                        Dim tableCC As DataTable = New DataTable("EmailCC")
                                        tableCC.Columns.Add("CC")
                                        tableCC.Columns.Add("Sel")
                                        tableCC.Columns("Sel").DataType = System.Type.GetType("System.Boolean")
                                        Dim er As Integer
                                        For er = 0 To emad.GridView3.RowCount - 1
                                            tableCC.Rows.Add(emad.GridView3.GetDataRow(er).Item("CC").ToString, emad.GridView3.GetDataRow(er).Item("Sel"))
                                        Next
                                        tableCC.Rows.Add(eMailTxt.EditValue.ToString.Trim, True)
                                        Dim setCC As DataSet = New DataSet("EmailCC")
                                        Dim dvmCC As DataViewManager = New DataViewManager(setCC)
                                        Dim myDatatViewCC As DataView = dvmCC.CreateDataView(tableCC)
                                        emad.GridControl3.DataSource = Nothing
                                        emad.GridControl3.DataMember = Nothing
                                        emad.GridControl3.DataSource = myDatatViewCC
                                        emad.GridView3.Columns(0).FieldName = "CC"
                                        emad.GridView3.Columns(1).FieldName = "Sel"
                                        emad.GridView3.Columns(1).OptionsColumn.AllowEdit = True
                                        emad.GridView3.Columns(0).OptionsColumn.AllowEdit = False
                                        emad.GridView3.Columns(1).OptionsColumn.ShowCaption = False
                                End Select
                                
                        End Select

                    End If
                End If

            End If
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
End Class