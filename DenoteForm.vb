Public Class DenoteForm

    Dim expp As Int32




    Private Sub DenoteForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Import_AttachmentTableAdapter.Fill(Me.NewDBFDataSet1.Import_Attachment)
            Me.Export_AttachmentTableAdapter.Fill(Me.NewDBFDataSet.Export_Attachment)
            Me.ExportDoc1TableAdapter.Fill(Me.NewDBFDataSet.ExportDoc1)
            Me.ImportDocIDenoteTableAdapter.Fill(Me.NewDBFDataSet.ImportDocIDenote)
            Me.ImportDocIDenoteTableAdapter.Fill(Me.NewDBFDataSet.ImportDocIDenote)
            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)


            Select Case SelectDenotePopupTypeProperty
                Case "I_ADD"
                    XtraTabPage1.PageVisible = True
                    XtraTabPage2.PageVisible = False
                    XtraTabPage5.PageVisible = False

                    Me.Height = 470
                Case "E_ADD"
                    XtraTabPage2.PageVisible = True
                    XtraTabPage1.PageVisible = False
                    XtraTabPage5.PageVisible = False

                    Me.Height = 470
                Case "I_ADD_E"
                    XtraTabPage1.PageVisible = True
                    XtraTabPage2.PageVisible = False
                    XtraTabPage5.PageVisible = False

                    Me.Height = 470
                Case "E_ADD_E"
                    XtraTabPage2.PageVisible = True
                    XtraTabPage1.PageVisible = False
                    XtraTabPage5.PageVisible = False

                    Me.Height = 470
                Case "I_ADD_A"
                    XtraTabPage2.PageVisible = False
                    XtraTabPage1.PageVisible = False
                    XtraTabPage5.PageVisible = True

                    Me.Height = 150
                Case "E_ADD_A"
                    XtraTabPage2.PageVisible = False
                    XtraTabPage1.PageVisible = False
                    XtraTabPage5.PageVisible = True

                    Me.Height = 150
                Case "I_ADD_L"
                    XtraTabPage2.PageVisible = False
                    XtraTabPage1.PageVisible = False
                    XtraTabPage5.PageVisible = False
          Me.Height = 150

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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
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

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
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

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click
        Try
            TextEdit2.Text = GridView1.GetFocusedDataRow("Book_No")
            DateEdit2.EditValue = GridView1.GetFocusedDataRow("Book_Date")
            expp = GridView1.GetFocusedDataRow("ExportId")
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
            Select Case XtraTabControl2.SelectedTabPage.Tag
                Case 0
                    If GridView2.FocusedValue IsNot Nothing Then
                        Select Case SelectDenotePopupTypeProperty
                            Case "I_ADD"
                                Me.Import_DenoteTableAdapter.InsertIDenote(UsedImportIdProperty, "I", -1, GridView2.GetFocusedDataRow("Import_No"), GridView2.GetFocusedDataRow("Import_Date"), GridView2.GetFocusedDataRow("Import_Org_No"), GridView2.GetFocusedDataRow("ImportId"))


                                ffrm.Fill_ITableAdapter1.Fill(ffrm.NewDBFDataSet.Fill_I, Val(UsedImportIdProperty))
                                ffrm.GridView1.RefreshData()
                                Me.Hide()
                                SaveSession(SessionType.AddImpDenote)

                            Case "I_ADD_E"
                                Me.Export_DenoteITableAdapter.InsertDenoteI(UsedExportIdProperty, "I", -1, GridView2.GetFocusedDataRow("Import_No"), GridView2.GetFocusedDataRow("Import_Date"), GridView2.GetFocusedDataRow("Import_Org_No"), GridView2.GetFocusedDataRow("ImportId"))


                                ffrmexp.Export_DenoteITableAdapter.ExportFill_I(ffrmexp.NewDBFDataSet.Export_DenoteI, Val(UsedExportIdProperty))
                                ffrmexp.GridView1.RefreshData()
                                Me.Hide()
                                SaveSession(SessionType.AddExpDenote)

                        End Select
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                        Return
                    End If


                Case 1
                    If TextEdit1.Text IsNot Nothing And DateEdit1.EditValue IsNot Nothing And PopupContainerEdit1.Tag IsNot Nothing Then
                        Select Case SelectDenotePopupTypeProperty
                            Case "I_ADD"
                                Me.Import_DenoteTableAdapter.InsertIDenote(UsedImportIdProperty, "I", -1, TextEdit1.Text, DateEdit1.EditValue, PopupContainerEdit1.Tag, 0)
                                ffrm.Fill_ITableAdapter1.Fill(ffrm.NewDBFDataSet.Fill_I, Val(UsedImportIdProperty))
                                ffrm.GridView1.RefreshData()
                                Me.Hide()
                                SaveSession(SessionType.AddImpDenote)

                            Case "I_ADD_E"
                                Me.Export_DenoteITableAdapter.InsertDenoteI(UsedExportIdProperty, "I", -1, TextEdit1.Text, DateEdit1.EditValue, PopupContainerEdit1.Tag, 0)
                                ffrmexp.Export_DenoteITableAdapter.ExportFill_I(ffrmexp.NewDBFDataSet.Export_DenoteI, Val(UsedExportIdProperty))
                                ffrmexp.GridView1.RefreshData()
                                Me.Hide()
                                SaveSession(SessionType.AddExpDenote)
                        End Select
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار حقل")
                        Return
                    End If


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

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            If TextEdit2.Text IsNot Nothing And DateEdit2.EditValue IsNot Nothing Then
                Select Case SelectDenotePopupTypeProperty
                    Case "E_ADD"
                        Me.Import_DenoteTableAdapter.InserEDenote(UsedImportIdProperty, "E", -1, TextEdit2.Text, DateEdit2.EditValue, "", expp)
                        ffrm.Fill_ETableAdapter1.Fill(ffrm.NewDBFDataSet.Fill_E, Val(UsedImportIdProperty))
                        ffrm.GridView2.RefreshData()
                        Me.Hide()
                        SaveSession(SessionType.AddImpDenote)
                    Case "E_ADD_E"
                        Me.Export_DenoteETableAdapter.InsertDenoteE(UsedExportIdProperty, "E", -1, TextEdit2.Text, DateEdit2.EditValue, "")
                        ffrmexp.Export_DenoteETableAdapter.ExportFill_E(ffrmexp.NewDBFDataSet.Export_DenoteE, Val(UsedExportIdProperty))
                        ffrmexp.GridView1.RefreshData()
                        Me.Hide()
                        SaveSession(SessionType.AddExpDenote)
                End Select
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

    Private Sub TreeList1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick
        Try
            PopupContainerEdit1.ClosePopup()
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

    Private Sub TreeList1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeList1.Click
        Try
            PopupContainerEdit1.Tag = TreeList1.FocusedNode.GetValue(2)
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



    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Try
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

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        Try
            If TextEdit3.EditValue IsNot Nothing Then
                Select Case SelectDenotePopupTypeProperty
                    Case "E_ADD_A"
                        Export_AttachmentTableAdapter.Insert(UsedExportIdProperty, Export_AttachmentTableAdapter.GetNextNo(UsedExportIdProperty), TextEdit3.EditValue)
                        ffrmexp.Export_AttachmentTableAdapter.FillByID(ffrmexp.NewDBFDataSet.Export_Attachment, UsedExportIdProperty)
                        ffrmexp.GridView3.RefreshData()
                        Me.Hide()
                        SaveSession(SessionType.AddExpAction)


                    Case "I_ADD_A"
                        Import_AttachmentTableAdapter.Insert(UsedImportIdProperty, Import_AttachmentTableAdapter.GetNextNo(UsedImportIdProperty), TextEdit3.EditValue)
                        ffrm.Import_AttachmentTableAdapter.FillByID(ffrm.NewDBFDataSet.Import_Attachment, UsedImportIdProperty)
                        ffrm.GridView3.RefreshData()
                        Me.Hide()
                        SaveSession(SessionType.AddImpAttach)
                End Select
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

    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
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

    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If TextEdit4.EditValue IsNot Nothing And LookUpEdit1.EditValue IsNot Nothing Then
        '        Select Case SelectDenotePopupTypeProperty
        '            Case "I_ADD_L"
        '                ElementReqTableAdapter1.Insert(UsedImportIdProperty, LookUpEdit1.EditValue, DateTime.Today, 1, TextEdit4.Text, ElementReqTableAdapter1.GetMaxImgId())
        '                ffrm.ElementReqTableAdapter.FillByImpId(ffrm.NewDBFDataSet.ElementReq, UsedImportIdProperty)
        '                ffrm.GridView5.RefreshData()
        '                Me.Hide()
        '                SaveSession(SessionType.AddExpAction)
        '        End Select
        '    End If

        'Catch ex As Exception
        '    Dim trace As New System.Diagnostics.StackTrace(ex, True)
        '    With ErrorTrace1
        '        .SendReport = True
        '        .NotifyLocal = True
        '        .From = rFrom
        '        .SendTo = rSendTo
        '        .SMTPServer = rSMTPServer
        '        .SMTPPass = rSMTPPass
        '        .SMTPUser = rSMTPUser
        '        .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
        '        .LineNumber = trace.GetFrame(0).GetFileLineNumber()
        '        .Ex = ex
        '    End With
        'End Try
    End Sub
End Class