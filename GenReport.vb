Imports DevExpress.XtraReports.UI

Public Class GenReport


    Private CanP As Boolean = False

    Structure RepColumn
        Dim ColumnName As String
        Dim ColumnWidth As Integer
        Dim ColumnTitle As String
        Dim ColumnAlign As Integer


        Public Sub New(ByVal Cn As String, ByVal Cw As Integer, ByVal Ct As String, ByVal Ca As Integer)
            ColumnName = Cn
            ColumnWidth = Cw
            ColumnTitle = Ct
            ColumnAlign = Ca
        End Sub

    End Structure

    Structure WhereStructure
        Dim Active As Boolean
        Dim ConditionValue As String
        Dim ConditionValue2 As String

        Public Sub New(ByVal act As Boolean, ByVal Cval As String, ByVal Cval2 As String)
            Active = act
            ConditionValue = Cval
            ConditionValue = Cval2
        End Sub
    End Structure



    Private loaded As Boolean = False

    Private WhereA() As WhereStructure = {New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", ""), New WhereStructure(False, "", "")}

    Private ColsArray As ArrayList = New ArrayList()


    Private Sub GenReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.OrgMembers' table. You can move, or remove it, as needed.
        Me.OrgMembersTableAdapter.Fill(Me.NewDBFDataSet.OrgMembers)




        'CheckEditA9.Enabled = False
        'CheckEditA10.Enabled = False
        'CheckEditA11.Enabled = False
        'CheckEditA12.Enabled = False

        Me.ActionsTableAdapter.Fill(Me.GenRep.Actions)

        Me.Org2TableAdapter.Fill(Me.GenRep.Org2)

        Me.BookNoTableAdapter.Fill(Me.GenRep.BookNo)

        Me.ImportNoTableAdapter.Fill(Me.GenRep.ImportNo)

        For Each Contrll As Control In Me.LayoutControl1.Controls
            If TypeOf Contrll Is DevExpress.XtraEditors.DateEdit Or TypeOf Contrll Is DevExpress.XtraEditors.LookUpEdit Or TypeOf Contrll Is DevExpress.XtraEditors.TextEdit Then
                Contrll.Enabled = False
            End If
        Next Contrll



        Me.Org1TableAdapter.Fill(Me.GenRep.Org1)

        Me.OrgTableAdapter.Fill(Me.GenRep.Org)

        Me.ImportDocTableAdapter.Fill(Me.GenRep.ImportDoc)



        loaded = True
        IsJoinProperty = False



    End Sub






    Private Sub ProcessWhere()
        LabelControl2.Visible = True

        LabelControl1.Visible = True

        Dim i As Byte
        Dim Swhere As String = ""
        Dim SAction As String = ""

        For i = 0 To WhereA.Length - 1

            If WhereA(i).Active Then
                Select Case i

                    Case 0

                        Swhere = String.Format("{0} ( ImportDoc.Deleted = {1} ) AND", Swhere, WhereA(i).ConditionValue)

                    Case 1

                        Swhere = String.Format("{0} ( ImportDoc.Import_Org_No = '{1}' ) AND", Swhere, WhereA(i).ConditionValue)

                    Case 2
                        If WhereA(i).ConditionValue IsNot Nothing And WhereA(i).ConditionValue2 IsNot Nothing Then
                            Swhere = String.Format("{0} ( ImportDoc.Import_Date >='{1}' ) AND ( ImportDoc.Import_Date <='{2}' ) AND", Swhere, WhereA(i).ConditionValue, WhereA(i).ConditionValue2)

                        End If

                    Case 3

                        Swhere = String.Format("{0} ( ImportDoc.Import_No = '{1}' ) AND", Swhere, WhereA(i).ConditionValue)

                    Case 4

                        Swhere = String.Format("{0} ( LTRIM(RTRIM(ImportDoc.Book_No)) = '{1}' ) AND", Swhere, WhereA(i).ConditionValue)

                    Case 5
                        If WhereA(i).ConditionValue IsNot Nothing And WhereA(i).ConditionValue2 IsNot Nothing Then
                            Swhere = String.Format("{0} ( ImportDoc.Book_Date >='{1}' ) AND ( ImportDoc.Book_Date <='{2}' ) AND", Swhere, WhereA(i).ConditionValue, WhereA(i).ConditionValue2)

                        End If

                    Case 6

                        Swhere = String.Format("{0} ( Owner_Org_No = '{1}' ) AND", Swhere, WhereA(i).ConditionValue)

                    Case 7

                        Swhere = String.Format("{0} (ISNULL(Import_Action.OpenAction, 0) = {1} ) AND", Swhere, WhereA(i).ConditionValue)
                    Case 8

                        Swhere = String.Format("{0} ( Import_Action.Action_Type = 2 ) AND  ( Import_Action.To_Org_No = '{1}' ) AND", Swhere, WhereA(i).ConditionValue)

                    Case 9
                        If WhereA(i).ConditionValue IsNot Nothing And WhereA(i).ConditionValue2 IsNot Nothing Then
                            Swhere = String.Format("{0} ( Import_Action.Action_Type = 2 ) AND  ( Import_Action.Action_Date >='{1}' ) AND ( Import_Action.Action_Date <='{2}' ) AND", Swhere, WhereA(i).ConditionValue, WhereA(i).ConditionValue2)

                        End If

                    Case 10

                        Swhere = String.Format("{0} ( Import_Action.Action_Type = {1} ) AND", Swhere, WhereA(i).ConditionValue)

                    Case 11
                        If WhereA(i).ConditionValue IsNot Nothing And WhereA(i).ConditionValue2 IsNot Nothing Then
                            Swhere = String.Format("{0} ( Import_Action.Action_Date >='{1}' ) AND ( Import_Action.Action_Date <='{2}' ) AND", Swhere, WhereA(i).ConditionValue, WhereA(i).ConditionValue2)

                        End If

                    Case 12

                        Swhere = String.Format("{0} ( Import_Action.Action_Type = 5 ) AND  ( Import_Action.ConsultationWith = '{1}' ) AND", Swhere, WhereA(i).ConditionValue)

                End Select



            End If

        Next

        If Swhere.Length >= 3 Then
            Swhere = SAction + Swhere.Remove(Swhere.Length - 3)

            Me.ImportDocTableAdapter.FillBy(Me.GenRep.ImportDoc, SAction + Swhere)
            'Me.ImportNoTableAdapter.FillBy(Me.GenRep.ImportNo, Swhere + " ORDER BY Import_No")
            'Me.BookNoTableAdapter.FillBy(Me.GenRep.BookNo, Swhere + " ORDER BY Book_No")
        Else

            Me.ImportDocTableAdapter.Fill(Me.GenRep.ImportDoc)
            'Me.ImportNoTableAdapter.Fill(Me.GenRep.ImportNo)
            'Me.BookNoTableAdapter.Fill(Me.GenRep.BookNo)
        End If


        LabelControl2.Text = GridView1.DataRowCount
        LabelControl1.Text = "عدد القيود"

        'If IsJoinProperty Then
        '    GridView1.Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn())
        '    GridView1.Columns(11).Visible = True
        '    GridView1.Columns(11).FieldName = "ActionId"

        '    GridView1.Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn())
        '    GridView1.Columns(12).Visible = True
        '    GridView1.Columns(12).FieldName = "Action"


        'Else
        '    If GridView1.Columns.Count >= 12 Then
        '        GridView1.Columns(11).Dispose()
        '        GridView1.Columns(11).Dispose()

        '    End If


        'End If

    End Sub


    Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Select Case CheckEdit1.Checked

            Case True

                With WhereA(0)
                    .Active = True
                    .ConditionValue = "0"
                End With

                ProcessWhere()



            Case False

                With WhereA(0)
                    .Active = False
                    .ConditionValue = "0"
                End With

                ProcessWhere()



        End Select

    End Sub

    Private Sub CheckImpFrom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckImpFrom.CheckedChanged
        Select Case CheckImpFrom.Checked

            Case True
                LookUpEdit1.Enabled = True
                With WhereA(1)
                    .Active = True
                    .ConditionValue = ""
                End With

            Case False

                LookUpEdit1.Enabled = False
                With WhereA(1)
                    .Active = False
                    .ConditionValue = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LookUpEdit1.EditValueChanged

        With WhereA(1)
            .Active = True
            .ConditionValue = LookUpEdit1.EditValue.ToString
        End With

        ProcessWhere()


    End Sub


    Private Sub CheckRange_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckRange.CheckedChanged
        Select Case CheckRange.Checked

            Case True
                DateRangeStart.Enabled = True
                DateRangeEnd.Enabled = True

                DateRangeStart.EditValue = Date.Today.Date.ToString("MM/dd/yyyy")
                DateRangeEnd.EditValue = Date.Today.Date.ToString("MM/dd/yyyy")

                With WhereA(2)
                    .Active = True

                End With
                ProcessWhere()
            Case False

                DateRangeStart.Enabled = False
                DateRangeEnd.Enabled = False

                DateRangeStart.EditValue = Nothing
                DateRangeEnd.EditValue = Nothing
                With WhereA(2)
                    .Active = False
                    .ConditionValue = ""
                    .ConditionValue2 = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub DateRangeStart_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateRangeStart.EditValueChanged

        If loaded Then
            With WhereA(2)
                .Active = True
                .ConditionValue = DateRangeStart.DateTime.Date.ToString("MM/dd/yyyy")

            End With

            ProcessWhere()
        End If


    End Sub

    Private Sub DateRangeEnd_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateRangeEnd.EditValueChanged

        If loaded Then
            With WhereA(2)
                .Active = True

                .ConditionValue2 = DateRangeEnd.DateTime.Date.ToString("MM/dd/yyyy")
            End With

            ProcessWhere()
        End If

    End Sub


    Private Sub CheckImpNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckImpNo.CheckedChanged
        Select Case CheckImpNo.Checked

            Case True
                LookUpEdit2.Enabled = True
                With WhereA(3)
                    .Active = True
                    .ConditionValue = ""
                End With

            Case False

                LookUpEdit2.Enabled = False
                With WhereA(3)
                    .Active = False
                    .ConditionValue = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub LookUpEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LookUpEdit2.EditValueChanged
        With WhereA(3)
            .Active = True
            .ConditionValue = LookUpEdit2.EditValue.ToString
        End With

        ProcessWhere()

    End Sub

    Private Sub CheckBookNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBookNo.CheckedChanged
        Select Case CheckBookNo.Checked

            Case True
                LookUpEdit4.Enabled = True
                With WhereA(4)
                    .Active = True
                    .ConditionValue = ""
                End With

            Case False

                LookUpEdit4.Enabled = False
                With WhereA(4)
                    .Active = False
                    .ConditionValue = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub LookUpEdit4_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LookUpEdit4.EditValueChanged
        With WhereA(4)
            .Active = True
            .ConditionValue = LookUpEdit4.EditValue.ToString.Trim
        End With

        ProcessWhere()
    End Sub



    Private Sub CheckBookDate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBookDate.CheckedChanged
        Select Case CheckBookDate.Checked

            Case True
                DateBookStart.Enabled = True
                DateBookEnd.Enabled = True

                DateBookStart.EditValue = Date.Today.Date.ToString("MM/dd/yyyy")
                DateBookEnd.EditValue = Date.Today.Date.ToString("MM/dd/yyyy")

                With WhereA(5)
                    .Active = True

                End With

            Case False

                DateBookStart.Enabled = False
                DateBookEnd.Enabled = False

                DateBookStart.EditValue = Nothing
                DateBookEnd.EditValue = Nothing
                With WhereA(5)
                    .Active = False
                    .ConditionValue = ""
                    .ConditionValue2 = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub DateBookStart_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateBookStart.EditValueChanged

        If loaded Then
            With WhereA(5)
                .Active = True
                .ConditionValue = DateBookStart.DateTime.Date.ToString("MM/dd/yyyy")

            End With

            ProcessWhere()
        End If

    End Sub

    Private Sub DateBookEnd_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateBookEnd.EditValueChanged

        If loaded Then
            With WhereA(5)
                .Active = True

                .ConditionValue2 = DateBookEnd.DateTime.Date.ToString("MM/dd/yyyy")
            End With

            ProcessWhere()
        End If
    End Sub

    Private Sub CheckOrg_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CheckOrg.EditValueChanged
        Select Case CheckOrg.Checked

            Case True
                LookUpEdit5.Enabled = True
                With WhereA(6)
                    .Active = True
                    .ConditionValue = ""
                End With

            Case False

                LookUpEdit5.Enabled = False
                With WhereA(6)
                    .Active = False
                    .ConditionValue = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub LookUpEdit5_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LookUpEdit5.EditValueChanged

        With WhereA(6)
            .Active = True
            .ConditionValue = LookUpEdit5.EditValue.ToString
        End With

        ProcessWhere()
    End Sub

    Private Sub CheckEdit3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit3.CheckedChanged
        Select Case CheckEdit3.Checked

            Case True
                'IsJoinProperty = True
                With WhereA(7)
                    .Active = True
                    .ConditionValue = "0"
                End With

                ProcessWhere()



            Case False
                'IsJoinProperty = False
                With WhereA(7)
                    .Active = False
                    .ConditionValue = "0"
                End With

                ProcessWhere()



        End Select
    End Sub

    Private Sub CheckTransTo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckTransTo.CheckedChanged
        Select Case CheckTransTo.Checked

            Case True
                'IsJoinProperty = True
                LookUpEdit3.Enabled = True

                With WhereA(8)
                    .Active = True
                    .ConditionValue = ""
                End With

            Case False
                'IsJoinProperty = False
                LookUpEdit3.Enabled = False

                With WhereA(8)
                    .Active = False
                    .ConditionValue = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub LookUpEdit3_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LookUpEdit3.EditValueChanged

        With WhereA(8)
            .Active = True
            .ConditionValue = LookUpEdit3.EditValue.ToString
        End With

        ProcessWhere()

    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        Select Case CheckEdit2.Checked

            Case True
                'IsJoinProperty = True
                DateEdit1.Enabled = True
                DateEdit2.Enabled = True

                DateEdit1.EditValue = Date.Today.Date.ToString("MM/dd/yyyy")
                DateEdit2.EditValue = Date.Today.Date.ToString("MM/dd/yyyy")

                With WhereA(9)
                    .Active = True

                End With

            Case False
                'IsJoinProperty = False
                DateEdit1.Enabled = False
                DateEdit2.Enabled = False

                DateEdit1.EditValue = Nothing
                DateEdit2.EditValue = Nothing
                With WhereA(9)
                    .Active = False
                    .ConditionValue = ""
                    .ConditionValue2 = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub DateEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateEdit1.EditValueChanged
        If loaded Then
            With WhereA(9)
                .Active = True
                .ConditionValue = DateEdit1.DateTime.Date.ToString("MM/dd/yyyy")

            End With

            ProcessWhere()
        End If

    End Sub

    Private Sub DateEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateEdit2.EditValueChanged
        If loaded Then
            With WhereA(9)
                .Active = True
                .ConditionValue2 = DateEdit2.DateTime.Date.ToString("MM/dd/yyyy")

            End With

            ProcessWhere()
        End If

    End Sub

    Private Sub CheckAction_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckAction.CheckedChanged
        Select Case CheckAction.Checked

            Case True
                'IsJoinProperty = True

                LookUpEditAction.Enabled = True
                With WhereA(10)
                    .Active = True
                    .ConditionValue = ""
                End With

            Case False
                'IsJoinProperty = False

                LookUpEditAction.Enabled = False
                With WhereA(10)
                    .Active = False
                    .ConditionValue = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub LookUpEditAction_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LookUpEditAction.EditValueChanged
        With WhereA(10)
            .Active = True
            .ConditionValue = LookUpEditAction.EditValue.ToString
        End With

        ProcessWhere()
    End Sub

    Private Sub CheckActionDate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckActionDate.CheckedChanged

        Select Case CheckActionDate.Checked

            Case True
                'IsJoinProperty = True
                DateEdit5.Enabled = True
                DateEdit3.Enabled = True

                DateEdit5.EditValue = Date.Today.Date.ToString("MM/dd/yyyy")
                DateEdit3.EditValue = Date.Today.Date.ToString("MM/dd/yyyy")

                With WhereA(11)
                    .Active = True

                End With

            Case False
                'IsJoinProperty = False
                DateEdit5.Enabled = False
                DateEdit3.Enabled = False

                DateEdit5.EditValue = Nothing
                DateEdit3.EditValue = Nothing
                With WhereA(11)
                    .Active = False

                    .ConditionValue = ""
                    .ConditionValue2 = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub DateEdit5_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateEdit5.EditValueChanged
        If loaded Then
            With WhereA(11)
                .Active = True
                .ConditionValue = DateEdit5.DateTime.Date.ToString("MM/dd/yyyy")

            End With

            ProcessWhere()
        End If
    End Sub

    Private Sub DateEdit3_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateEdit3.EditValueChanged
        If loaded Then
            With WhereA(11)
                .Active = True
                .ConditionValue2 = DateEdit3.DateTime.Date.ToString("MM/dd/yyyy")

            End With

            ProcessWhere()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Me.Hide()

    End Sub

    Public Shared Sub InitBands(ByVal rep As XtraReport)
        ' Create bands
        rep.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        rep.PaperKind = Printing.PaperKind.A4
        rep.Landscape = True
        rep.Margins.Bottom = 25
        rep.Margins.Top = 25
        rep.Margins.Left = 25
        rep.Margins.Right = 25

        Dim Logoss As TopMarginBand = New TopMarginBand()
        Dim detail As DetailBand = New DetailBand()
        Dim pageHeader As PageHeaderBand = New PageHeaderBand()
        Dim reportFooter As ReportFooterBand = New ReportFooterBand()
        Logoss.Height = 180
        Logoss.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        detail.Height = 20
        detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        reportFooter.Height = 380
        pageHeader.Height = 20

        ' Place the bands onto a report
        rep.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Logoss, detail, pageHeader, reportFooter})
    End Sub

    Public Shared Sub InitStyles(ByVal rep As XtraReport)
        '' Create different odd and even styles
        'Using oddStyle As XRControlStyle = New XRControlStyle()
        '    Using evenStyle As XRControlStyle = New XRControlStyle()
        '        ' Specify the odd style appearance
        '        oddStyle.BackColor = Color.LightBlue
        '        oddStyle.StyleUsing.UseBackColor = True
        '        oddStyle.StyleUsing.UseBorders = False
        '        oddStyle.Name = "OddStyle"
        '        ' Specify the even style appearance
        '        evenStyle.BackColor = Color.LightPink
        '        evenStyle.StyleUsing.UseBackColor = True
        '        evenStyle.StyleUsing.UseBorders = False
        '        evenStyle.Name = "EvenStyle"
        '        ' Add styles to report's style sheet
        '        rep.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {oddStyle, evenStyle})
        '    End Using
        'End Using
    End Sub

    Public Sub InitDetailsBasedonXRTable(ByVal rep As XtraReport)

        rep.ReportUnit = ReportUnit.HundredthsOfAnInch
        'Dim ds As DataSet = (CType(rep.DataSource, DataSet))
        Dim colCount As Integer = ColsArray.Count
        'Dim colWidth As Integer = Convert.ToInt32((rep.PageWidth - (rep.Margins.Left + rep.Margins.Right)) / 4)


        Dim summ As Integer = 0

        For i As Integer = 0 To ColsArray.Count - 1
            summ += ColsArray(i).ColumnWidth
        Next
        CanP = True

        If summ = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("لم يتم اختيار الحقول الخاصة بالتقرير")
            CanP = False

            Return

        End If


        Dim pwidth As Integer = (rep.PageWidth - (rep.Margins.Left + rep.Margins.Right))
        Dim Cwd As Integer = CInt(pwidth / summ)




        ' Create a table to represent headers
        Dim tableHeader As XRTable = New XRTable()
        tableHeader.Height = 20
        tableHeader.Width = pwidth
        Dim headerRow As XRTableRow = New XRTableRow()

        Dim HeadLogo As XRPictureBox = New XRPictureBox()

        HeadLogo.Image = My.Resources.nic
        HeadLogo.WidthF = 140
        HeadLogo.HeightF = 140
        HeadLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        HeadLogo.LocationF = New Point(470, 20)

        Dim HeadTitleP As XRLabel = New XRLabel()
        Dim HeadTitle As XRLabel = New XRLabel()

        HeadTitleP.Text = "الهيئة الوطنية للأستثمار"
        HeadTitleP.WidthF = 500
        HeadTitleP.HeightF = 75
        HeadTitleP.LocationF = New Point(290, 150)
        HeadTitleP.Font = New Font("Arial", 30, FontStyle.Bold)

        HeadTitle.Text = "تقرير الوارد العام"
        HeadTitle.WidthF = 300
        HeadTitle.HeightF = 75
        HeadTitle.LocationF = New Point(390, 180)
        HeadTitle.Font = New Font("Arial", 20)

        headerRow.Width = pwidth
        tableHeader.Rows.Add(headerRow)



        tableHeader.BackColor = Color.LightGray
        ' Create a table to display data

        Dim tableDetail As XRTable = New XRTable()
        tableDetail.Height = 20
        tableDetail.Width = pwidth

        Dim detailRow As XRTableRow = New XRTableRow()
        detailRow.Width = pwidth
        tableDetail.Rows.Add(detailRow)


        ' Create table cells, fill the header cells with text, bind the cells to data
        For i As Integer = 0 To ColsArray.Count - 1
            Dim headerCell As XRTableCell = New XRTableCell()
            Dim detailCell As XRTableCell = New XRTableCell()

            headerCell.Width = ColsArray(i).ColumnWidth

            headerCell.Text = ColsArray(i).ColumnTitle
            headerCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter

            detailCell.Width = ColsArray(i).ColumnWidth

            detailCell.Weight = ColsArray(i).ColumnWidth
            headerCell.Weight = ColsArray(i).ColumnWidth


            detailCell.TextAlignment = ColsArray(i).ColumnAlign



            If Strings.Right(ColsArray(i).ColumnName, 4).ToLower = "date" Then
                detailCell.DataBindings.Add("Text", Nothing, ColsArray(i).ColumnName, "{0:dd-MM-yyyy}")
            Else
                detailCell.DataBindings.Add("Text", Nothing, ColsArray(i).ColumnName)
            End If
            If i = 0 Then
                headerCell.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
                detailCell.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
            Else
                headerCell.Borders = DevExpress.XtraPrinting.BorderSide.All
                detailCell.Borders = DevExpress.XtraPrinting.BorderSide.All
            End If

            ' Place the cells into the corresponding tables



            headerRow.Cells.Add(headerCell)
            detailRow.Cells.Add(detailCell)
        Next i

        ' Place the table onto a report's Detail band
        rep.Bands(BandKind.TopMargin).Controls.Add(HeadLogo)
        rep.Bands(BandKind.TopMargin).Controls.Add(HeadTitleP)
        rep.Bands(BandKind.TopMargin).Controls.Add(HeadTitle)
        rep.Bands(BandKind.PageHeader).Controls.Add(tableHeader)

        rep.Bands(BandKind.Detail).Controls.Add(tableDetail)
    End Sub


    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click


        ColsArray.Clear()

        For Each cc As Control In LayoutControl1.Controls

            If TypeOf (cc) Is DevExpress.XtraEditors.CheckEdit Then

                Dim dc As DevExpress.XtraEditors.CheckEdit = cc
                If Strings.Left(cc.Name, 10).ToLower = "checkedita" Then
                    If dc.Checked Then

                        Select Case dc.Tag.ToString
                            Case "ImportOrg"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 3, "الدائرة", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "ImporetFromOrg"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 3, "وارد من", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Import_No"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 1, "رقم الوارد", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))


                            Case "Import_Date"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 1, "تاريخ الوارد", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Book_no"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 2, "رقم الكتاب", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Book_Date"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 1, "تاريخ الكتاب", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Type"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 1, "النوع", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Subject"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 4, "الموضوع", DevExpress.XtraPrinting.TextAlignment.TopRight))

                            Case "ActionName"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 1, "نوع الاجراء", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Action_Date"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 2, "تاريخ الاجراء", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "To_Org_Name"
                                ColsArray.Add(New RepColumn(dc.Tag.ToString, 3, "الجهة المحال اليها", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Action_Date2"
                                ColsArray.Add(New RepColumn("Action_Date", 2, "تاريخ الاحالة", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "ConsultationWith"
                                ColsArray.Add(New RepColumn("ConsultationWith", 2, "مداولة مع", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))
                            Case "STATUSS"
                                ColsArray.Add(New RepColumn("STATUSS", 1, "الحالة", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Security"
                                ColsArray.Add(New RepColumn("Security", 1, "السرية", DevExpress.XtraPrinting.TextAlignment.MiddleCenter))

                            Case "Action"
                                ColsArray.Add(New RepColumn("Action", 4, "الاجراء", DevExpress.XtraPrinting.TextAlignment.TopRight))


                        End Select


                    End If


                End If
            End If




        Next

        Dim rep As XtraReport = New XtraReport()

        rep.DataSource = GenRep

        rep.DataMember = "ImportDoc"

        InitBands(rep)
        InitStyles(rep)

        InitDetailsBasedonXRTable(rep)

        If CanP Then
            rep.ShowPreviewDialog()
        End If

    End Sub

    Private Sub CheckEdit4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit4.CheckedChanged
        Select Case CheckEdit4.Checked

            Case True
                'IsJoinProperty = True
                LookUpEdit6.Enabled = True

                With WhereA(12)
                    .Active = True
                    .ConditionValue = ""
                End With

            Case False
                'IsJoinProperty = False
                LookUpEdit6.Enabled = False

                With WhereA(12)
                    .Active = False
                    .ConditionValue = ""
                End With
                ProcessWhere()
        End Select
    End Sub

    Private Sub LookUpEdit6_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LookUpEdit6.EditValueChanged

        With WhereA(12)
            .Active = True
            .ConditionValue = LookUpEdit6.EditValue.ToString
        End With

        ProcessWhere()
    End Sub



End Class