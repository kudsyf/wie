<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScannerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScannerForm))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.ImageListBoxControl1 = New DevExpress.XtraEditors.ImageListBoxControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDelpage = New DevExpress.XtraBars.BarButtonItem()
        Me.BarNewFolder = New DevExpress.XtraBars.BarButtonItem()
        Me.BarScan = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarNewPage = New DevExpress.XtraBars.BarButtonItem()
        Me.BarImageInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImpImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.Import_ImageTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Import_ImageTableAdapter()
        Me.ExpImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Export_ImageTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_ImageTableAdapter()
        Me.ImportImageImportDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ImportDocTableAdapter()
        Me.ImportImageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Import_ActionTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.Import_ActionTableAdapter()
        Me.ElementImgTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.ElementImgTableAdapter()
        Me.Export_To1TableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.Export_To1TableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.ImageListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImpImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportImageImportDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportImageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SplitContainerControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(803, 439)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainerControl1.Panel2.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LayoutControl3)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(779, 415)
        Me.SplitContainerControl1.SplitterPosition = 225
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.ImageListBoxControl1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(225, 415)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'ImageListBoxControl1
        '
        Me.ImageListBoxControl1.Appearance.Options.UseImage = True
        Me.ImageListBoxControl1.Location = New System.Drawing.Point(12, 12)
        Me.ImageListBoxControl1.Name = "ImageListBoxControl1"
        Me.ImageListBoxControl1.Size = New System.Drawing.Size(201, 391)
        Me.ImageListBoxControl1.StyleController = Me.LayoutControl2
        Me.ImageListBoxControl1.TabIndex = 4
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(225, 415)
        Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ImageListBoxControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(205, 395)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.Panel1)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(549, 415)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 391)
        Me.Panel1.TabIndex = 0
        '
        'PictureEdit1
        '
        Me.PictureEdit1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureEdit1.Location = New System.Drawing.Point(3, 3)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(235, 194)
        Me.PictureEdit1.TabIndex = 0
        Me.PictureEdit1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveImage})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'SaveImage
        '
        Me.SaveImage.Name = "SaveImage"
        Me.SaveImage.Size = New System.Drawing.Size(152, 22)
        Me.SaveImage.Text = "حفظ الصورة"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(549, 415)
        Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Panel1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(529, 395)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(803, 439)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SplitContainerControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(783, 419)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSave, Me.BarNewPage, Me.BarDelpage, Me.BarScan, Me.BarPrint, Me.BarImageInfo, Me.BarNewFolder})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarPrint), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSave, "", False, False, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarDelpage), New DevExpress.XtraBars.LinkPersistInfo(Me.BarNewFolder), New DevExpress.XtraBars.LinkPersistInfo(Me.BarScan)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DisableCustomization = True
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarPrint
        '
        Me.BarPrint.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarPrint.Glyph = CType(resources.GetObject("BarPrint.Glyph"), System.Drawing.Image)
        Me.BarPrint.Id = 9
        Me.BarPrint.Name = "BarPrint"
        '
        'BarSave
        '
        Me.BarSave.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSave.Glyph = CType(resources.GetObject("BarSave.Glyph"), System.Drawing.Image)
        Me.BarSave.Id = 0
        Me.BarSave.Name = "BarSave"
        Me.BarSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarDelpage
        '
        Me.BarDelpage.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarDelpage.Glyph = CType(resources.GetObject("BarDelpage.Glyph"), System.Drawing.Image)
        Me.BarDelpage.Id = 5
        Me.BarDelpage.Name = "BarDelpage"
        '
        'BarNewFolder
        '
        Me.BarNewFolder.Caption = "BarButtonItem1"
        Me.BarNewFolder.Glyph = CType(resources.GetObject("BarNewFolder.Glyph"), System.Drawing.Image)
        Me.BarNewFolder.Id = 12
        Me.BarNewFolder.Name = "BarNewFolder"
        '
        'BarScan
        '
        Me.BarScan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarScan.Glyph = CType(resources.GetObject("BarScan.Glyph"), System.Drawing.Image)
        Me.BarScan.Id = 8
        Me.BarScan.Name = "BarScan"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(803, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 463)
        Me.barDockControlBottom.Size = New System.Drawing.Size(803, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 439)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(803, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 439)
        '
        'BarNewPage
        '
        Me.BarNewPage.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarNewPage.Glyph = CType(resources.GetObject("BarNewPage.Glyph"), System.Drawing.Image)
        Me.BarNewPage.Id = 4
        Me.BarNewPage.Name = "BarNewPage"
        '
        'BarImageInfo
        '
        Me.BarImageInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarImageInfo.Caption = "       dfgdfg      "
        Me.BarImageInfo.Id = 10
        Me.BarImageInfo.Name = "BarImageInfo"
        Me.BarImageInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 0
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(128, 128)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImpImagesBindingSource
        '
        Me.ImpImagesBindingSource.DataMember = "Import_Image"
        Me.ImpImagesBindingSource.DataSource = Me.NewDBFDataSet
        '
        'NewDBFDataSet
        '
        Me.NewDBFDataSet.DataSetName = "NewDBFDataSet"
        Me.NewDBFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Import_ImageTableAdapter
        '
        Me.Import_ImageTableAdapter.ClearBeforeFill = True
        '
        'ExpImagesBindingSource
        '
        Me.ExpImagesBindingSource.DataMember = "Export_Image"
        Me.ExpImagesBindingSource.DataSource = Me.NewDBFDataSet
        '
        'Export_ImageTableAdapter
        '
        Me.Export_ImageTableAdapter.ClearBeforeFill = True
        '
        'ImportImageImportDocBindingSource
        '
        Me.ImportImageImportDocBindingSource.DataMember = "Import_Image_ImportDoc"
        Me.ImportImageImportDocBindingSource.DataSource = Me.ImpImagesBindingSource
        '
        'ImportDocTableAdapter
        '
        Me.ImportDocTableAdapter.ClearBeforeFill = True
        '
        'ImportImageBindingSource
        '
        Me.ImportImageBindingSource.DataMember = "Import_Image"
        Me.ImportImageBindingSource.DataSource = Me.NewDBFDataSet
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Import_ActionTableAdapter1
        '
        Me.Import_ActionTableAdapter1.ClearBeforeFill = True
        '
        'ElementImgTableAdapter1
        '
        Me.ElementImgTableAdapter1.ClearBeforeFill = True
        '
        'Export_To1TableAdapter1
        '
        Me.Export_To1TableAdapter1.ClearBeforeFill = True
        '
        'ScannerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 486)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ScannerForm"
        Me.Text = "ادارة الصور"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.ImageListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImpImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportImageImportDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportImageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureEdit1 As System.Windows.Forms.PictureBox

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDelpage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarNewPage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarScan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ImageListBoxControl1 As DevExpress.XtraEditors.ImageListBoxControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImpImagesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents Import_ImageTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Import_ImageTableAdapter
    Friend WithEvents ExpImagesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Export_ImageTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Export_ImageTableAdapter
    Friend WithEvents ImportImageImportDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImportDocTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ImportDocTableAdapter
    Friend WithEvents ImportImageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarImageInfo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarNewFolder As DevExpress.XtraBars.BarButtonItem

    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Import_ActionTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.Import_ActionTableAdapter
    Friend WithEvents ElementImgTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.ElementImgTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Export_To1TableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.Export_To1TableAdapter
End Class
