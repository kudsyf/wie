Imports DevExpress.XtraReports.UI

Public Class ReportSelector
    Public RepType As String

    Public RepSrtDate As DateTime

    Public RepEndDate As DateTime

    Public RepOrgName As String

    Public RepOrg As String

    Public RepAuthId As Integer

    Private Sub ReportSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)

            RepOrg = ""

            RepType = ""
            CheckEdit2.EditValue = True
            CheckEdit3.EditValue = False
            CheckEdit4.EditValue = True
            CheckEdit1.EditValue = False
            LookUpEdit1.Enabled = CheckEdit3.EditValue
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




    Private Sub WizardControl1_SelectedPageChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles WizardControl1.SelectedPageChanging
        Try


            If e.Page.Name = "WizardPage2" And e.Direction = DevExpress.XtraWizard.Direction.Backward Then

                If RepType = "RepOther0" Then
                    e.Page = WizardPage1
                Else
                    e.Page = WizardPage2
                End If
            End If
            If e.Page.Name = "WizardPage2" And e.Direction = DevExpress.XtraWizard.Direction.Forward Then

                Select Case XtraTabControl1.SelectedTabPage.Name
                    Case "XtraTabPage1"
                        If ListBoxControl1.SelectedIndex = -1 Then
                            DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار تقرير من القائمة")

                            e.Page = WizardPage1

                        Else
                            If ListBoxControl1.SelectedIndex = 0 Then
                                RepType = "RepImp" + ListBoxControl1.SelectedIndex.ToString
                                LayoutControlItem6.Visibility = True
                                LayoutControlItem7.Visibility = False
                            Else
                                RepType = "RepImp" + ListBoxControl1.SelectedIndex.ToString
                                LayoutControlItem6.Visibility = False
                                LayoutControlItem7.Visibility = False
                            End If

                        End If

                    Case "XtraTabPage2"
                        If ListBoxControl2.SelectedIndex = -1 Then
                            DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار تقرير من القائمة")

                            e.Page = WizardPage1
                        Else
                            RepType = "RepExp" + ListBoxControl2.SelectedIndex.ToString
                        End If
                    Case "XtraTabPage3"
                        If ListBoxControl3.SelectedIndex = -1 Then
                            DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار تقرير من القائمة")

                            e.Page = WizardPage1
                        Else
                            If ListBoxControl3.SelectedIndex = 0 Then
                                RepType = "RepOther" + ListBoxControl3.SelectedIndex.ToString
                                e.Page = WizardPage3
                            Else
                                RepType = "RepOther" + ListBoxControl3.SelectedIndex.ToString
                            End If

                        End If
                End Select
            End If
            If e.Page.Name = "WizardPage3" And e.Direction = DevExpress.XtraWizard.Direction.Forward Then

                If RepType <> "RepOther0" And RepType <> "RepImp0" Then
                    If DateEdit1.EditValue = Nothing Or DateEdit2.EditValue = Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن ترك احد التواريخ فاغة")
                        e.Page = WizardPage2
                        Exit Sub
                    Else
                        RepSrtDate = DateEdit2.EditValue
                        RepEndDate = DateEdit1.EditValue
                    End If
                Else


                End If

                If GotAdminAuth Then
                    e.Page = WizardPage3
                Else
                    RepOrg = CurOrgNo
                    e.Page = endWizPage


                End If
            End If
            If e.Page.Name = "WizardPage3" And e.Direction = DevExpress.XtraWizard.Direction.Backward Then
                If GotAdminAuth Then
                    e.Page = WizardPage3
                Else

                    e.Page = WizardPage2
                End If

            End If
            If e.Page.Name = "endWizPage" And e.Direction = DevExpress.XtraWizard.Direction.Forward Then
                If CheckEdit4.EditValue Then
                    RepAuthId = -1

                Else
                    If ComboBoxEdit1.EditValue = Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار درجة الاهمية")
                        e.Page = WizardPage4
                    End If
                    RepAuthId = ComboBoxEdit1.EditValue
                End If
            End If
            If e.Page.Name = "endWizPage" And e.Direction = DevExpress.XtraWizard.Direction.Backward Then
                If RepType = "RepImp2" Or RepType = "RepImp3" Or RepType = "RepExp0" Or RepType = "RepExp1" Or RepType = "RepOther0" Or RepType = "RepOther1" Or RepType = "RepOther2" Or RepType = "RepOther3" Then
                    e.Page = WizardPage3
                End If
            End If

            If e.Page.Name = "WizardPage4" And e.Direction = DevExpress.XtraWizard.Direction.Forward Then
                If RepType = "RepImp2" Or RepType = "RepImp3" Or RepType = "RepExp0" Or RepType = "RepExp1" Or RepType = "RepOther0" Or RepType = "RepOther1" Or RepType = "RepOther2" Or RepType = "RepOther3" Then
                    e.Page = endWizPage
                End If
                If CheckEdit2.EditValue Then
                    RepOrg = "ALL"
                    RepOrgName = "جميع الدوائر"

                Else
                    If LookUpEdit1.EditValue = Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار دائرة")
                        e.Page = WizardPage3
                    End If
                    RepOrg = LookUpEdit1.EditValue
                    RepOrgName = LookUpEdit1.Text.ToString.Trim



                End If
                If RepType = "RepImp0" Then
                    If DateEdit2.EditValue = Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("لا يمكن ترك احد التواريخ فاغة")
                        e.Page = WizardPage2
                        Exit Sub
                    Else
                        RepSrtDate = DateEdit2.EditValue

                    End If
                Else


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


    Private Sub CheckEdit3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit3.CheckedChanged
        Try
            LookUpEdit1.Enabled = CheckEdit3.EditValue
            CheckEdit2.EditValue = Not CheckEdit3.EditValue
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

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        Try
            CheckEdit3.EditValue = Not CheckEdit2.EditValue
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

    Private Sub WizardControl1_FinishClick(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WizardControl1.FinishClick
        Try
            Select Case RepType

                Case "RepImp0"  ' تقرير الكتب الواردة المتاخرة 
                    If RepAuthId = -1 Then


                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()

                            RepEndDate = DateTime.Today
                            DeAdap.DelaidEndActoin_All(newds.DelaidEndAction, RepEndDate, RepSrtDate)

                            ffrrA.XrRichText1.Text = CurLogin

                            ffrrA.XrLabel3.Text = DateTime.Today.ToString + " ولغاية تاريخ اليوم " + RepSrtDate.ToString + "تقرير الكتب الواردة المتاخرة من تاريخ  "
                            ffrrA.DataSource = newds

                            ffrrA.DataMember = "DelaidEndAction"

                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrr As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndActionByOrg(newds.DelaidEndAction, RepOrg, DateTime.Today.Date, RepSrtDate)
                            ffrr.XrLabel3.Text = DateTime.Today + " ولغاية تاريخ اليوم " + RepSrtDate + "تقرير الكتب الواردة المتاخرة من تاريخ  "

                            ffrr.XrRichText1.Text = CurLogin
                            ffrr.DataSource = newds
                            ffrr.DataMember = "DelaidEndAction"
                            ffrr.ShowPreviewDialog()

                        End If
                    Else

                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()

                            RepEndDate = DateTime.Today
                            DeAdap.DelaidEndAction_All_Pri(newds.DelaidEndAction, RepEndDate, RepSrtDate, RepAuthId)

                            ffrrA.XrRichText1.Text = CurLogin

                            ffrrA.XrLabel3.Text = DateTime.Today.ToString + " ولغاية تاريخ اليوم " + RepSrtDate.ToString + "تقرير الكتب الواردة المتاخرة من تاريخ  "
                            ffrrA.DataSource = newds

                            ffrrA.DataMember = "DelaidEndAction"

                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrr As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndActionByOrg_Pri(newds.DelaidEndAction, RepOrg, DateTime.Today.Date, RepSrtDate, RepAuthId)
                            ffrr.XrLabel3.Text = DateTime.Today + " ولغاية تاريخ اليوم " + RepSrtDate + "تقرير الكتب الواردة المتاخرة من تاريخ  "

                            ffrr.XrRichText1.Text = CurLogin
                            ffrr.DataSource = newds
                            ffrr.DataMember = "DelaidEndAction"
                            ffrr.ShowPreviewDialog()

                        End If

                    End If

                Case "RepImp1"  ' تقرير الكتب الواردو - بدون اجراء
                    If RepAuthId = -1 Then
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 
                            Dim ffrrA As New XtraReport_NoActionImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportNoActionTableAdapter = New NewDBFDataSetTableAdapters.ReportImportNoActionTableAdapter()


                            DeAdap.GetNoActionALLByDate(newds.ReportImportNoAction, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin

                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportNoAction"
                            ffrrA.ShowPreviewDialog()


                        Else
                            '##################  Report for ONE  Department ( From - To ) 
                            Dim ffrrA As New XtraReport_NoActionImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportNoActionTableAdapter = New NewDBFDataSetTableAdapters.ReportImportNoActionTableAdapter()


                            DeAdap.GetNoActionByOrgandDate(newds.ReportImportNoAction, RepSrtDate, RepEndDate, RepOrg)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportNoAction"
                            ffrrA.ShowPreviewDialog()


                        End If

                    Else
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 
                            Dim ffrrA As New XtraReport_NoActionImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportNoActionTableAdapter = New NewDBFDataSetTableAdapters.ReportImportNoActionTableAdapter()


                            DeAdap.GetNoActionALLByDate_Pri(newds.ReportImportNoAction, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin

                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportNoAction"
                            ffrrA.ShowPreviewDialog()


                        Else
                            '##################  Report for ONE  Department ( From - To ) 
                            Dim ffrrA As New XtraReport_NoActionImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportNoActionTableAdapter = New NewDBFDataSetTableAdapters.ReportImportNoActionTableAdapter()


                            DeAdap.GetNoActionByOrgandDate_Pri(newds.ReportImportNoAction, RepSrtDate, RepEndDate, RepOrg, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportNoAction"
                            ffrrA.ShowPreviewDialog()


                        End If

                    End If
                Case "RepImp2"

                    If RepOrg = "ALL" Then
                        '##################  Report for ALL Department ( From - To ) 

                        Dim ffrrA As New XtraReport_NoScanImp
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportNoScannerTableAdapter = New NewDBFDataSetTableAdapters.ReportImportNoScannerTableAdapter()


                        DeAdap.GetNoScanALLByDate(newds.ReportImportNoScanner, RepSrtDate, RepEndDate)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "ReportImportNoScanner"
                        ffrrA.ShowPreviewDialog()


                    Else
                        '##################  Report for ONE  Department ( From - To ) 
                        Dim ffrrA As New XtraReport_NoScanImp
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportNoScannerTableAdapter = New NewDBFDataSetTableAdapters.ReportImportNoScannerTableAdapter()


                        DeAdap.GetNoScanByOrgandDate(newds.ReportImportNoScanner, RepSrtDate, RepEndDate, RepOrg)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "ReportImportNoScanner"
                        ffrrA.ShowPreviewDialog()


                    End If

                Case "RepImp3"

                    If RepOrg = "ALL" Then
                        '##################  Report for ALL Department ( From - To ) 
                        Dim ffrrA As New XtraReport_DeletedImp
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.RepDeletedImpTableAdapter = New NewDBFDataSetTableAdapters.RepDeletedImpTableAdapter()


                        DeAdap.GetDeletedImpALLByDate(newds.RepDeletedImp, RepSrtDate, RepEndDate)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "RepDeletedImp"
                        ffrrA.ShowPreviewDialog()


                    Else
                        '##################  Report for ONE  Department ( From - To ) 

                        Dim ffrrA As New XtraReport_DeletedImp
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.RepDeletedImpTableAdapter = New NewDBFDataSetTableAdapters.RepDeletedImpTableAdapter()

                        DeAdap.GetDeletedImpByOrgandDate(newds.RepDeletedImp, RepSrtDate, RepEndDate, RepOrg)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "RepDeletedImp"
                        ffrrA.ShowPreviewDialog()

                    End If

                Case "RepImp4"  '  لفترة معينة تقرير الكتب الواردة المتاخرة 
                    If RepAuthId = -1 Then
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndActoin_All(newds.DelaidEndAction, RepEndDate, RepSrtDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المتاخرة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "DelaidEndAction"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrr As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndActionByOrg(newds.DelaidEndAction, RepOrg, RepEndDate, RepSrtDate)
                            ffrr.XrLabel3.Text = "تقرير الكتب الواردة المتاخرة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate

                            ffrr.XrRichText1.Text = CurLogin
                            ffrr.DataSource = newds
                            ffrr.DataMember = "DelaidEndAction"
                            ffrr.ShowPreviewDialog()

                        End If

                    Else
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndAction_All_Pri(newds.DelaidEndAction, RepEndDate, RepSrtDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المتاخرة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "DelaidEndAction"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrr As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndActionByOrg_Pri(newds.DelaidEndAction, RepOrg, RepEndDate, RepSrtDate, RepAuthId)
                            ffrr.XrLabel3.Text = "تقرير الكتب الواردة المتاخرة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate

                            ffrr.XrRichText1.Text = CurLogin
                            ffrr.DataSource = newds
                            ffrr.DataMember = "DelaidEndAction"
                            ffrr.ShowPreviewDialog()

                        End If
                    End If
                Case "RepImp5"  ' تقرير الكتب المطلوب انجازها المتاخرة 
                    If RepAuthId = -1 Then
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndActoin_All(newds.DelaidEndAction, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المطلوب انجازها للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "DelaidEndAction"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrr As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndActionByOrg(newds.DelaidEndAction, RepOrg, RepSrtDate, RepEndDate)
                            ffrr.XrLabel3.Text = "تقرير الكتب الواردة المطلوب انجازها للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate

                            ffrr.XrRichText1.Text = CurLogin
                            ffrr.DataSource = newds
                            ffrr.DataMember = "DelaidEndAction"
                            ffrr.ShowPreviewDialog()

                        End If
                    Else
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndAction_All_Pri(newds.DelaidEndAction, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المطلوب انجازها للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "DelaidEndAction"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrr As New XtraReport_DelaidImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter = New NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()


                            DeAdap.DelaidEndActionByOrg_Pri(newds.DelaidEndAction, RepOrg, RepSrtDate, RepEndDate, RepAuthId)
                            ffrr.XrLabel3.Text = "تقرير الكتب الواردة المطلوب انجازها للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate

                            ffrr.XrRichText1.Text = CurLogin
                            ffrr.DataSource = newds
                            ffrr.DataMember = "DelaidEndAction"
                            ffrr.ShowPreviewDialog()

                        End If

                    End If
                Case "RepImp6"  ' تقرير الكتب المطلوب انجازها المتاخرة 
                    If RepAuthId = -1 Then
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()


                            DeAdap.FillByAllAllAction(newds.ReportImportDoneActions, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المنجزة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()


                            DeAdap.FillByOrgAllActions(newds.ReportImportDoneActions, RepOrg, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المنجزة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        End If

                    Else
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()


                            DeAdap.FillByAllAllAction_Pri(newds.ReportImportDoneActions, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المنجزة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()


                            DeAdap.FillByOrgAllAction_Pri(newds.ReportImportDoneActions, RepOrg, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المنجزة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        End If
                    End If
                Case "RepImp7"  ' تقرير الكتب المطلوب انجازها المتاخرة 
                    If RepAuthId = -1 Then
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()


                            DeAdap.FillByAllSave(newds.ReportImportDoneActions, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المحفوظة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()


                            DeAdap.FillByOrgSave(newds.ReportImportDoneActions, RepOrg, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المحفوظة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        End If

                    Else
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()


                            DeAdap.FillByAllSave_Pri(newds.ReportImportDoneActions, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المحفوظة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsImp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()


                            DeAdap.FillByOrgSave_Pri(newds.ReportImportDoneActions, RepOrg, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المحفوظة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportImportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        End If

                    End If
                Case "RepExp0"


                    If RepOrg = "ALL" Then
                        '##################  Report for ALL Department ( From - To ) 

                        Dim ffrrA As New XtraReport_NoScanExp
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportNoScannerTableAdapter = New NewDBFDataSetTableAdapters.ReportExportNoScannerTableAdapter()


                        DeAdap.GetNoScanALLByDate(newds.ReportExportNoScanner, RepSrtDate, RepEndDate)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "ReportExportNoScanner"
                        ffrrA.ShowPreviewDialog()


                    Else
                        '##################  Report for ONE  Department ( From - To ) 
                        Dim ffrrA As New XtraReport_NoScanExp
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportNoScannerTableAdapter = New NewDBFDataSetTableAdapters.ReportExportNoScannerTableAdapter()


                        DeAdap.GetNoScanByOrgandDate(newds.ReportExportNoScanner, RepSrtDate, RepEndDate, RepOrg)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "ReportExportNoScanner"
                        ffrrA.ShowPreviewDialog()

                    End If

                Case "RepExp1"

                    If RepOrg = "ALL" Then
                        '##################  Report for ALL Department ( From - To ) 

                        Dim ffrrA As New XtraReport_DeletedExp
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.RepDeleteExpTableAdapter = New NewDBFDataSetTableAdapters.RepDeleteExpTableAdapter()


                        DeAdap.GetDeletedExpALLByDate(newds.RepDeleteExp, RepSrtDate, RepEndDate)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "RepDeleteExp"
                        ffrrA.ShowPreviewDialog()

                    Else
                        '##################  Report for ONE  Department ( From - To ) 
                        Dim ffrrA As New XtraReport_DeletedExp
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.RepDeleteExpTableAdapter = New NewDBFDataSetTableAdapters.RepDeleteExpTableAdapter()


                        DeAdap.GetDeletedExpByOrgandDate(newds.RepDeleteExp, RepOrg, RepSrtDate, RepEndDate)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "RepDeleteExp"
                        ffrrA.ShowPreviewDialog()

                    End If


                Case "RepExp2"  ' تقرير الكتب المطلوب انجازها المتاخرة 
                    If RepAuthId = -1 Then
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsExp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()


                            DeAdap.FillByAllAllAction(newds.ReportExportDoneActions, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المنجزة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportExportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsExp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()


                            DeAdap.FillByOrgAllAction(newds.ReportExportDoneActions, RepOrg, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المنجزة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportExportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        End If

                    Else
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsExp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()


                            DeAdap.FillByAllAllAction_Pri(newds.ReportExportDoneActions, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المنجزة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportExportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsExp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()


                            DeAdap.FillByOrgAllAction_Pri(newds.ReportExportDoneActions, RepOrg, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المنجزة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportExportDoneActions"

                            ffrrA.ShowPreviewDialog()

                        End If

                    End If
                Case "RepExp3"  ' تقرير الكتب المطلوب انجازها المتاخرة 
                    If RepAuthId = -1 Then
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsExp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()


                            DeAdap.FillByALLSave(newds.ReportExportDoneActions, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المحفوظة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportExportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsExp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()


                            DeAdap.FillByOrgSave(newds.ReportExportDoneActions, RepOrg, RepSrtDate, RepEndDate)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المحفوظة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportExportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        End If
                    Else
                        If RepOrg = "ALL" Then
                            '##################  Report for ALL Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsExp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()


                            DeAdap.FillByALLSave_Pri(newds.ReportExportDoneActions, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المحفوظة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportExportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        Else
                            '##################  Report for ONE  Department ( From - To ) 

                            Dim ffrrA As New XtraReport_ActionsExp
                            Dim newds As New NewDBFDataSet()
                            Dim DeAdap As NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter = New NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()


                            DeAdap.FillByOrgSave_Pri(newds.ReportExportDoneActions, RepOrg, RepSrtDate, RepEndDate, RepAuthId)
                            ffrrA.XrRichText1.Text = CurLogin
                            ffrrA.XrLabel3.Text = "تقرير الكتب الواردة المحفوظة للفترة من   " + RepSrtDate + " ولغاية " + RepEndDate
                            ffrrA.DataSource = newds
                            ffrrA.DataMember = "ReportExportDoneActions"
                            ffrrA.ShowPreviewDialog()

                        End If
                    End If
                Case "RepOther0"


                    If RepOrg = "ALL" Then
                        '##################  Report for ALL Department ( From - To ) 

                        Dim ffrrA As New XtraReport_ToAssigne
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.ToAssignedTableAdapter = New NewDBFDataSetTableAdapters.ToAssignedTableAdapter()


                        DeAdap.ToAssignedALL(newds.ToAssigned)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "ToAssigned"
                        ffrrA.ShowPreviewDialog()

                    Else
                        '##################  Report for ONE  Department ( From - To ) 

                        Dim ffrrA As New XtraReport_ToAssigne
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.ToAssignedTableAdapter = New NewDBFDataSetTableAdapters.ToAssignedTableAdapter()


                        DeAdap.ToAssignedByOrg(newds.ToAssigned, RepOrg)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "ToAssigned"
                        ffrrA.ShowPreviewDialog()
                    End If

                Case "RepOther1"


                    '    Dim ffrrA As New XtraReport_UserActivity
                    '    Dim newds As New NewDBFDataSet()
                    '    Dim DeAdap As NewDBFDataSetTableAdapters.RepGeneralStatisticTableAdapter = New NewDBFDataSetTableAdapters.RepGeneralStatisticTableAdapter()
                    'Dim uuuid As Integer

                    'DeAdap.StatisticByUserByDate(newds.RepGeneralStatistic, RepSrtDate, RepEndDate, uuuid)
                    '    ffrrA.XrRichText1.Text = CurLogin
                    '    ffrrA.XrTableCell3.Text = RepOrgName
                    '    ffrrA.XrTableCell1.Text = RepSrtDate
                    '    ffrrA.XrTableCell11.Text = RepEndDate

                    '    ffrrA.DataSource = newds
                    '    ffrrA.DataMember = "RepGeneralStatistic"
                    '    ffrrA.ShowPreviewDialog()


                Case "RepOther2"

                    If RepOrg = "ALL" Then
                        '##################  Report for ALL Department ( From - To ) 


                        Dim ffrrA As New XtraReport_OrgActivity
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.RepGeneralStatisticTableAdapter = New NewDBFDataSetTableAdapters.RepGeneralStatisticTableAdapter()


                        DeAdap.StatisticALLByDate(newds.RepGeneralStatistic, RepSrtDate, RepEndDate)
                        ffrrA.XrRichText1.Text = CurLogin
                        ffrrA.XrTableCell3.Text = RepOrgName
                        ffrrA.XrTableCell1.Text = RepSrtDate
                        ffrrA.XrTableCell11.Text = RepEndDate

                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "RepGeneralStatistic"
                        ffrrA.ShowPreviewDialog()

                    Else
                        '##################  Report for ONE  Department ( From - To ) 

                        Dim ffrrA As New XtraReport_OrgActivity
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.RepGeneralStatisticTableAdapter = New NewDBFDataSetTableAdapters.RepGeneralStatisticTableAdapter()


                        DeAdap.StatisticByOrgByDate(newds.RepGeneralStatistic, RepSrtDate, RepEndDate, RepOrg)
                        ffrrA.XrRichText1.Text = CurLogin
                        ffrrA.XrTableCell3.Text = RepOrgName
                        ffrrA.XrTableCell1.Text = RepSrtDate
                        ffrrA.XrTableCell11.Text = RepEndDate
                        ffrrA.DataSource = newds
                        ffrrA.DataMember = "RepGeneralStatistic"
                        ffrrA.ShowPreviewDialog()
                    End If

                Case "RepOther3"  ' تقرير الكتب المطلوب انجازها المتاخرة 

                    If RepOrg = "ALL" Then
                        '##################  Report for ALL Department ( From - To ) 

                        Dim ffrrA As New XtraReportChart
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.ReportChartTableAdapter = New NewDBFDataSetTableAdapters.ReportChartTableAdapter()

                        newds.EnforceConstraints = False
                        DeAdap.FillAll(newds.ReportChart, RepSrtDate, RepEndDate)
                        ffrrA.XrRichText1.Text = CurLogin

                        ffrrA.XrChart1.DataSource = newds

                        ffrrA.XrChart1.DataAdapter = DeAdap
                        ffrrA.ShowPreviewDialog()

                    Else
                        '##################  Report for ONE  Department ( From - To ) 

                        Dim ffrr As New XtraReportChart
                        Dim newds As New NewDBFDataSet()
                        Dim DeAdap As NewDBFDataSetTableAdapters.ReportChartTableAdapter = New NewDBFDataSetTableAdapters.ReportChartTableAdapter()

                        newds.EnforceConstraints = False
                        DeAdap.FillByOrg(newds.ReportChart, RepSrtDate, RepEndDate, RepOrg)

                        ffrr.XrRichText1.Text = CurLogin
                        ffrr.XrChart1.DataSource = newds
                        ffrr.XrChart1.DataAdapter = DeAdap
                        ffrr.ShowPreviewDialog()

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
End Class