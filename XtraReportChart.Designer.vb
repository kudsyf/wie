<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReportChart
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim SideBySideBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim Bar3DSeriesLabel2 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim SideBySideBar3DSeriesView2 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
        Dim Bar3DSeriesLabel3 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim SideBySideBar3DSeriesView3 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportChart))
        Me.ReportChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet1 = New WinImpExp.NewDBFDataSet()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.ReportChartTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ReportChartTableAdapter()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.DelaidEndActionTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter()
        Me.Import_ActionTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Import_ActionTableAdapter()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportImportDoneActionsTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter()
        Me.ReportExportDoneActionsTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter()
        CType(Me.ReportChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'ReportChartBindingSource
        '
        Me.ReportChartBindingSource.DataMember = "ReportChart"
        Me.ReportChartBindingSource.DataSource = Me.NewDBFDataSet1
        '
        'NewDBFDataSet1
        '
        Me.NewDBFDataSet1.DataSetName = "NewDBFDataSet"
        Me.NewDBFDataSet1.EnforceConstraints = False
        Me.NewDBFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.DataAdapter = Me.ReportChartTableAdapter
        Me.XrChart1.DataMember = "ReportChart"
        Me.XrChart1.DataSource = Me.NewDBFDataSet1
        XyDiagram3D1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram3D1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & _
    "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & _
    "1"
        Me.XrChart1.Diagram = XyDiagram3D1
        Me.XrChart1.IndicatorsPaletteName = "Default"
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(13.54167!, 22.91667!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.PaletteName = "Palette 1"
        Me.XrChart1.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Green, System.Drawing.Color.Green), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series1.ArgumentDataMember = "Cur_Org"
        Bar3DSeriesLabel1.LineVisible = True
        Bar3DSeriesLabel1.Visible = True
        Series1.Label = Bar3DSeriesLabel1
        Series1.Name = "الاجراءات المنجزة"
        Series1.ValueDataMembersSerializable = "ImportDone"
        Series1.View = SideBySideBar3DSeriesView1
        Series2.ArgumentDataMember = "Cur_Org"
        Bar3DSeriesLabel2.LineVisible = True
        Bar3DSeriesLabel2.Visible = True
        Series2.Label = Bar3DSeriesLabel2
        Series2.Name = "الاجراءات غير المنجزة"
        Series2.ValueDataMembersSerializable = "ImportNotDone"
        Series2.View = SideBySideBar3DSeriesView2
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        Bar3DSeriesLabel3.LineVisible = True
        Bar3DSeriesLabel3.Visible = True
        Me.XrChart1.SeriesTemplate.Label = Bar3DSeriesLabel3
        Me.XrChart1.SeriesTemplate.View = SideBySideBar3DSeriesView3
        Me.XrChart1.SizeF = New System.Drawing.SizeF(1042.458!, 566.6666!)
        '
        'ReportChartTableAdapter
        '
        Me.ReportChartTableAdapter.ClearBeforeFill = True
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1, Me.XrLabel4, Me.XrLine1, Me.XrPictureBox1, Me.XrLabel3, Me.XrLabel2, Me.XrPageInfo1, Me.XrLabel1})
        Me.TopMargin.HeightF = 200.4583!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText1
        '
        Me.XrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrRichText1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(907.6666!, 154.4583!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrRichText1.StylePriority.UseBorders = False
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1007.667!, 154.4583!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(54.16669!, 23.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = ":المستخدم"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine1.BorderWidth = 2
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 177.4583!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1056.0!, 23.0!)
        Me.XrLine1.StylePriority.UseBorders = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(448.7679!, 10.00001!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(114.5833!, 112.6667!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox1.StylePriority.UseBorders = False
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(341.4763!, 157.2083!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(329.1667!, 20.25002!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "تقرير نسب انجاز اجراءات الوارد"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1007.667!, 131.4583!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(54.16669!, 23.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = ":التاريخ"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrPageInfo1.Format = "{0:yyyy/MM/dd}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(917.0416!, 131.4583!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(90.625!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseBorders = False
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(341.4763!, 119.25!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(329.1667!, 37.95834!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "الهيئة الوطنية للأستثمار"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.BorderColor = System.Drawing.SystemColors.Control
        Me.BottomMargin.HeightF = 36.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.StylePriority.UseBorderColor = False
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1})
        Me.PageHeader.HeightF = 589.5833!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(355.0179!, 0.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseBorders = False
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2})
        Me.PageFooter.HeightF = 26.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'DelaidEndActionTableAdapter
        '
        Me.DelaidEndActionTableAdapter.ClearBeforeFill = True
        '
        'Import_ActionTableAdapter
        '
        Me.Import_ActionTableAdapter.ClearBeforeFill = True
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.DataSource = Me.NewDBFDataSet1
        Me.DetailReport.Expanded = False
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Name = "Detail1"
        '
        'ReportImportDoneActionsTableAdapter
        '
        Me.ReportImportDoneActionsTableAdapter.ClearBeforeFill = True
        '
        'ReportExportDoneActionsTableAdapter
        '
        Me.ReportExportDoneActionsTableAdapter.ClearBeforeFill = True
        '
        'XtraReportChart
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.ReportFooter, Me.PageFooter, Me.DetailReport})
        Me.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(16, 18, 200, 36)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "10.2"
        CType(Me.ReportChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents NewDBFDataSet1 As WinImpExp.NewDBFDataSet
    Friend WithEvents DelaidEndActionTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.DelaidEndActionTableAdapter
    Friend WithEvents Import_ActionTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Import_ActionTableAdapter
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportImportDoneActionsTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ReportImportDoneActionsTableAdapter
    Friend WithEvents ReportExportDoneActionsTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ReportExportDoneActionsTableAdapter
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents ReportChartTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ReportChartTableAdapter
    Friend WithEvents ReportChartBindingSource As System.Windows.Forms.BindingSource
End Class
