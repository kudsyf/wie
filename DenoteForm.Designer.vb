<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DenoteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DenoteForm))
        Me.OrgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.ExportDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrgTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter()
        Me.ExportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.OrgBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.PopupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.colOrg_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colorg_folder = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.importDocIDenoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOwner_Org_No1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImportId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImport_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImport_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_no1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_Date1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImport_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubject1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ExportDocNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOwner_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrgItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colExportId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSecurity_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSummary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnderAction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAboutToSign = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdate_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdate_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreate_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreate_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl5 = New DevExpress.XtraLayout.LayoutControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NewDBFDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDenoteI = New System.Windows.Forms.BindingSource(Me.components)
        Me.Export_DenoteITableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_DenoteITableAdapter()
        Me.ExportDenoteE = New System.Windows.Forms.BindingSource(Me.components)
        Me.Export_DenoteETableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_DenoteETableAdapter()
        Me.ImportDenote = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Import_DenoteTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Import_DenoteTableAdapter()
        Me.ImportDocIDenoteTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ImportDocIDenoteTableAdapter()
        Me.ExportDoc1TableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ExportDoc1TableAdapter()
        Me.ExportAttachBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Export_AttachmentTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_AttachmentTableAdapter()
        Me.ImportAttachBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet1 = New WinImpExp.NewDBFDataSet()
        Me.Import_AttachmentTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Import_AttachmentTableAdapter()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        CType(Me.OrgBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.importDocIDenoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDocNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl5.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDenoteI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDenoteE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDenote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportAttachBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportAttachBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrgBindingSource
        '
        Me.OrgBindingSource.DataMember = "Org"
        Me.OrgBindingSource.DataSource = Me.NewDBFDataSet
        '
        'NewDBFDataSet
        '
        Me.NewDBFDataSet.DataSetName = "NewDBFDataSet"
        Me.NewDBFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExportDocBindingSource
        '
        Me.ExportDocBindingSource.DataMember = "ExportDoc"
        Me.ExportDocBindingSource.DataSource = Me.NewDBFDataSet
        Me.ExportDocBindingSource.Filter = "DELETED = 0"
        '
        'OrgTableAdapter
        '
        Me.OrgTableAdapter.ClearBeforeFill = True
        '
        'ExportDocTableAdapter
        '
        Me.ExportDocTableAdapter.ClearBeforeFill = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(598, 269)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(574, 245)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage5})
        '
        'OrgBindingSource1
        '
        Me.OrgBindingSource1.DataMember = "Org"
        Me.OrgBindingSource1.DataSource = Me.NewDBFDataSet
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.XtraTabPage1.Size = New System.Drawing.Size(568, 218)
        Me.XtraTabPage1.Text = "أشارة الى الكتب الواردة"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.XtraTabControl2)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(568, 218)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(287, 184)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(269, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "حفظ"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 184)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(271, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "ألغاء"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.XtraTabControl2.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XtraTabControl2.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage4
        Me.XtraTabControl2.Size = New System.Drawing.Size(544, 168)
        Me.XtraTabControl2.TabIndex = 9
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.LayoutControl4)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(453, 162)
        Me.XtraTabPage4.Tag = "1"
        Me.XtraTabPage4.Text = "وارد غير مسجل"
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.TextEdit1)
        Me.LayoutControl4.Controls.Add(Me.DateEdit1)
        Me.LayoutControl4.Controls.Add(Me.PopupContainerEdit1)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup4
        Me.LayoutControl4.Size = New System.Drawing.Size(453, 162)
        Me.LayoutControl4.TabIndex = 0
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(12, 12)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit1.Size = New System.Drawing.Size(373, 20)
        Me.TextEdit1.StyleController = Me.LayoutControl4
        Me.TextEdit1.TabIndex = 4
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(12, 36)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.DateEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateEdit1.Size = New System.Drawing.Size(373, 20)
        Me.DateEdit1.StyleController = Me.LayoutControl4
        Me.DateEdit1.TabIndex = 5
        '
        'PopupContainerEdit1
        '
        Me.PopupContainerEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrgBindingSource, "Org_Name", True))
        Me.PopupContainerEdit1.EditValue = "أنقر لأختيار القيمة"
        Me.PopupContainerEdit1.Location = New System.Drawing.Point(12, 60)
        Me.PopupContainerEdit1.Name = "PopupContainerEdit1"
        Me.PopupContainerEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.PopupContainerEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PopupContainerEdit1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.PopupContainerEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerEdit1.Properties.MaxLength = 20
        Me.PopupContainerEdit1.Properties.NullText = "[EditValue is null]"
        Me.PopupContainerEdit1.Properties.PopupControl = Me.PopupContainerControl1
        Me.PopupContainerEdit1.Properties.PopupFormMinSize = New System.Drawing.Size(80, 80)
        Me.PopupContainerEdit1.Properties.PopupFormSize = New System.Drawing.Size(400, 300)
        Me.PopupContainerEdit1.Size = New System.Drawing.Size(373, 20)
        Me.PopupContainerEdit1.StyleController = Me.LayoutControl4
        Me.PopupContainerEdit1.TabIndex = 4
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.AutoSize = True
        Me.PopupContainerControl1.Controls.Add(Me.TreeList1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(269, 211)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(213, 84)
        Me.PopupContainerControl1.TabIndex = 5
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colOrg_Name, Me.colorg_folder, Me.TreeListColumn1})
        Me.TreeList1.DataSource = Me.OrgBindingSource
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.KeyFieldName = "Org_no"
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsBehavior.Editable = False
        Me.TreeList1.OptionsBehavior.ImmediateEditor = False
        Me.TreeList1.ParentFieldName = "Org_Up"
        Me.TreeList1.Size = New System.Drawing.Size(213, 84)
        Me.TreeList1.TabIndex = 0
        '
        'colOrg_Name
        '
        Me.colOrg_Name.Caption = "الاسم"
        Me.colOrg_Name.FieldName = "Org_Name"
        Me.colOrg_Name.Name = "colOrg_Name"
        Me.colOrg_Name.Visible = True
        Me.colOrg_Name.VisibleIndex = 0
        Me.colOrg_Name.Width = 90
        '
        'colorg_folder
        '
        Me.colorg_folder.FieldName = "org_folder"
        Me.colorg_folder.Name = "colorg_folder"
        Me.colorg_folder.Width = 89
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.TreeListColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TreeListColumn1.Caption = "TreeListColumn1"
        Me.TreeListColumn1.FieldName = "Org_no"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem13})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(453, 162)
        Me.LayoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup4"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextEdit1
        Me.LayoutControlItem2.CustomizationFormText = "رقم الكتاب"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(433, 24)
        Me.LayoutControlItem2.Text = "رقم الكتاب"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.DateEdit1
        Me.LayoutControlItem3.CustomizationFormText = "تاريخ الكتاب"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(433, 24)
        Me.LayoutControlItem3.Text = "تاريخ الكتاب"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.PopupContainerEdit1
        Me.LayoutControlItem13.CustomizationFormText = "وارد من"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(433, 94)
        Me.LayoutControlItem13.Text = "وارد من"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(52, 13)
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(453, 162)
        Me.XtraTabPage3.Tag = "0"
        Me.XtraTabPage3.Text = "وارد مسجل"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.importDocIDenoteBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(453, 162)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'importDocIDenoteBindingSource
        '
        Me.importDocIDenoteBindingSource.DataMember = "ImportDocIDenote"
        Me.importDocIDenoteBindingSource.DataSource = Me.NewDBFDataSet
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOwner_Org_No1, Me.colImportId, Me.colImport_No, Me.colImport_Date, Me.colBook_no1, Me.colBook_Date1, Me.colImport_Org_No, Me.colSubject1, Me.colDeleted1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.EnableMasterViewMode = False
        Me.GridView2.OptionsView.ShowDetailButtons = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colOwner_Org_No1
        '
        Me.colOwner_Org_No1.FieldName = "Owner_Org_No"
        Me.colOwner_Org_No1.Name = "colOwner_Org_No1"
        '
        'colImportId
        '
        Me.colImportId.FieldName = "ImportId"
        Me.colImportId.Name = "colImportId"
        '
        'colImport_No
        '
        Me.colImport_No.AppearanceCell.Options.UseTextOptions = True
        Me.colImport_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImport_No.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImport_No.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImport_No.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colImport_No.AppearanceHeader.Options.UseFont = True
        Me.colImport_No.AppearanceHeader.Options.UseTextOptions = True
        Me.colImport_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImport_No.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImport_No.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImport_No.Caption = "رقم الوارد"
        Me.colImport_No.FieldName = "Import_No"
        Me.colImport_No.Name = "colImport_No"
        Me.colImport_No.Visible = True
        Me.colImport_No.VisibleIndex = 5
        '
        'colImport_Date
        '
        Me.colImport_Date.AppearanceCell.Options.UseTextOptions = True
        Me.colImport_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImport_Date.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImport_Date.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImport_Date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colImport_Date.AppearanceHeader.Options.UseFont = True
        Me.colImport_Date.AppearanceHeader.Options.UseTextOptions = True
        Me.colImport_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImport_Date.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImport_Date.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImport_Date.Caption = "تاريخ الوارد"
        Me.colImport_Date.FieldName = "Import_Date"
        Me.colImport_Date.Name = "colImport_Date"
        Me.colImport_Date.Visible = True
        Me.colImport_Date.VisibleIndex = 4
        '
        'colBook_no1
        '
        Me.colBook_no1.AppearanceCell.Options.UseTextOptions = True
        Me.colBook_no1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_no1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colBook_no1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBook_no1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBook_no1.AppearanceHeader.Options.UseFont = True
        Me.colBook_no1.AppearanceHeader.Options.UseTextOptions = True
        Me.colBook_no1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_no1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colBook_no1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBook_no1.Caption = "رقم الكتاب"
        Me.colBook_no1.FieldName = "Book_no"
        Me.colBook_no1.Name = "colBook_no1"
        Me.colBook_no1.Visible = True
        Me.colBook_no1.VisibleIndex = 3
        '
        'colBook_Date1
        '
        Me.colBook_Date1.AppearanceCell.Options.UseTextOptions = True
        Me.colBook_Date1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_Date1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colBook_Date1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBook_Date1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBook_Date1.AppearanceHeader.Options.UseFont = True
        Me.colBook_Date1.AppearanceHeader.Options.UseTextOptions = True
        Me.colBook_Date1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_Date1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colBook_Date1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBook_Date1.Caption = "تاريخ الكتاب"
        Me.colBook_Date1.FieldName = "Book_Date"
        Me.colBook_Date1.Name = "colBook_Date1"
        Me.colBook_Date1.Visible = True
        Me.colBook_Date1.VisibleIndex = 2
        '
        'colImport_Org_No
        '
        Me.colImport_Org_No.AppearanceCell.Options.UseTextOptions = True
        Me.colImport_Org_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colImport_Org_No.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImport_Org_No.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImport_Org_No.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colImport_Org_No.AppearanceHeader.Options.UseFont = True
        Me.colImport_Org_No.AppearanceHeader.Options.UseTextOptions = True
        Me.colImport_Org_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImport_Org_No.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImport_Org_No.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImport_Org_No.Caption = "وارد من"
        Me.colImport_Org_No.FieldName = "Import_Org_No"
        Me.colImport_Org_No.Name = "colImport_Org_No"
        Me.colImport_Org_No.Visible = True
        Me.colImport_Org_No.VisibleIndex = 1
        '
        'colSubject1
        '
        Me.colSubject1.AppearanceCell.Options.UseTextOptions = True
        Me.colSubject1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSubject1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colSubject1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubject1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubject1.AppearanceHeader.Options.UseFont = True
        Me.colSubject1.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubject1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubject1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colSubject1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubject1.Caption = "الموضوع"
        Me.colSubject1.FieldName = "Subject"
        Me.colSubject1.Name = "colSubject1"
        Me.colSubject1.Visible = True
        Me.colSubject1.VisibleIndex = 0
        '
        'colDeleted1
        '
        Me.colDeleted1.FieldName = "Deleted"
        Me.colDeleted1.Name = "colDeleted1"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(568, 218)
        Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton1
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(275, 172)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(273, 26)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton2
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(275, 26)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.XtraTabControl2
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(548, 172)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.PageClient.Options.UseTextOptions = True
        Me.XtraTabPage2.Appearance.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.XtraTabPage2.Size = New System.Drawing.Size(568, 218)
        Me.XtraTabPage2.Text = "أشارة الى الكتب الصادرة"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.SimpleButton4)
        Me.LayoutControl3.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl3.Controls.Add(Me.GridControl1)
        Me.LayoutControl3.Controls.Add(Me.DateEdit2)
        Me.LayoutControl3.Controls.Add(Me.TextEdit2)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(568, 218)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Location = New System.Drawing.Point(12, 184)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(271, 22)
        Me.SimpleButton4.StyleController = Me.LayoutControl3
        Me.SimpleButton4.TabIndex = 8
        Me.SimpleButton4.Text = "ألغاء"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(287, 184)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(269, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl3
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "حفظ"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ExportDocNewBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 36)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.OrgItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(544, 144)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ExportDocNewBindingSource
        '
        Me.ExportDocNewBindingSource.DataMember = "ExportDoc1"
        Me.ExportDocNewBindingSource.DataSource = Me.NewDBFDataSet
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOwner_Org_No, Me.colExportId, Me.colBook_no, Me.colBook_Date, Me.colType_Code, Me.colSecurity_Code, Me.colSubject, Me.colSummary, Me.colUnderAction, Me.colAboutToSign, Me.colDeleted, Me.colUpdate_Login, Me.colUpdate_Date, Me.colCreate_Login, Me.colCreate_Date, Me.colDelete_Login, Me.colDelete_Date})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOwner_Org_No
        '
        Me.colOwner_Org_No.Caption = "صادر من"
        Me.colOwner_Org_No.ColumnEdit = Me.OrgItemLookUpEdit1
        Me.colOwner_Org_No.FieldName = "Owner_Org_No"
        Me.colOwner_Org_No.Name = "colOwner_Org_No"
        Me.colOwner_Org_No.Visible = True
        Me.colOwner_Org_No.VisibleIndex = 0
        '
        'OrgItemLookUpEdit1
        '
        Me.OrgItemLookUpEdit1.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.OrgItemLookUpEdit1.AppearanceDropDownHeader.Options.UseFont = True
        Me.OrgItemLookUpEdit1.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.OrgItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrgItemLookUpEdit1.AutoHeight = False
        Me.OrgItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrgItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_no", "الدائرة", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_Name", "Org_Name", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_Up", "Org_Up", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("org_folder", "org_folder", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.OrgItemLookUpEdit1.DataSource = Me.OrgBindingSource
        Me.OrgItemLookUpEdit1.DisplayMember = "Org_Name"
        Me.OrgItemLookUpEdit1.Name = "OrgItemLookUpEdit1"
        Me.OrgItemLookUpEdit1.ValueMember = "Org_no"
        '
        'colExportId
        '
        Me.colExportId.FieldName = "ExportId"
        Me.colExportId.Name = "colExportId"
        '
        'colBook_no
        '
        Me.colBook_no.Caption = "رقم الكتاب"
        Me.colBook_no.FieldName = "Book_no"
        Me.colBook_no.Name = "colBook_no"
        Me.colBook_no.Visible = True
        Me.colBook_no.VisibleIndex = 3
        '
        'colBook_Date
        '
        Me.colBook_Date.Caption = "تاريخ الكتاب"
        Me.colBook_Date.FieldName = "Book_Date"
        Me.colBook_Date.Name = "colBook_Date"
        Me.colBook_Date.Visible = True
        Me.colBook_Date.VisibleIndex = 2
        '
        'colType_Code
        '
        Me.colType_Code.FieldName = "Type_Code"
        Me.colType_Code.Name = "colType_Code"
        '
        'colSecurity_Code
        '
        Me.colSecurity_Code.FieldName = "Security_Code"
        Me.colSecurity_Code.Name = "colSecurity_Code"
        '
        'colSubject
        '
        Me.colSubject.Caption = "الموضوع"
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 1
        '
        'colSummary
        '
        Me.colSummary.FieldName = "Summary"
        Me.colSummary.Name = "colSummary"
        '
        'colUnderAction
        '
        Me.colUnderAction.FieldName = "UnderAction"
        Me.colUnderAction.Name = "colUnderAction"
        '
        'colAboutToSign
        '
        Me.colAboutToSign.FieldName = "AboutToSign"
        Me.colAboutToSign.Name = "colAboutToSign"
        '
        'colDeleted
        '
        Me.colDeleted.FieldName = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        '
        'colUpdate_Login
        '
        Me.colUpdate_Login.FieldName = "Update_Login"
        Me.colUpdate_Login.Name = "colUpdate_Login"
        '
        'colUpdate_Date
        '
        Me.colUpdate_Date.FieldName = "Update_Date"
        Me.colUpdate_Date.Name = "colUpdate_Date"
        '
        'colCreate_Login
        '
        Me.colCreate_Login.FieldName = "Create_Login"
        Me.colCreate_Login.Name = "colCreate_Login"
        '
        'colCreate_Date
        '
        Me.colCreate_Date.FieldName = "Create_Date"
        Me.colCreate_Date.Name = "colCreate_Date"
        '
        'colDelete_Login
        '
        Me.colDelete_Login.FieldName = "Delete_Login"
        Me.colDelete_Login.Name = "colDelete_Login"
        '
        'colDelete_Date
        '
        Me.colDelete_Date.FieldName = "Delete_Date"
        Me.colDelete_Date.Name = "colDelete_Date"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(12, 12)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(215, 20)
        Me.DateEdit2.StyleController = Me.LayoutControl3
        Me.DateEdit2.TabIndex = 5
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(287, 12)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(213, 20)
        Me.TextEdit2.StyleController = Me.LayoutControl3
        Me.TextEdit2.TabIndex = 4
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(568, 218)
        Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.DateEdit2
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem8.Text = "تاريخ الكتاب"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TextEdit2
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(275, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(273, 24)
        Me.LayoutControlItem7.Text = "رقم الكتاب"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.GridControl1
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(548, 148)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton3
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(275, 172)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(273, 26)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton4
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(275, 26)
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.LayoutControl5)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(568, 218)
        Me.XtraTabPage5.Text = "المرفقات"
        '
        'LayoutControl5
        '
        Me.LayoutControl5.Controls.Add(Me.TextEdit3)
        Me.LayoutControl5.Controls.Add(Me.SimpleButton5)
        Me.LayoutControl5.Controls.Add(Me.SimpleButton6)
        Me.LayoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl5.Name = "LayoutControl5"
        Me.LayoutControl5.Root = Me.LayoutControlGroup5
        Me.LayoutControl5.Size = New System.Drawing.Size(568, 218)
        Me.LayoutControl5.TabIndex = 0
        Me.LayoutControl5.Text = "LayoutControl5"
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(12, 12)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(507, 20)
        Me.TextEdit3.StyleController = Me.LayoutControl5
        Me.TextEdit3.TabIndex = 11
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Appearance.Options.UseForeColor = True
        Me.SimpleButton5.Location = New System.Drawing.Point(12, 36)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(269, 22)
        Me.SimpleButton5.StyleController = Me.LayoutControl5
        Me.SimpleButton5.TabIndex = 10
        Me.SimpleButton5.Text = "ألغاء"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Appearance.Options.UseForeColor = True
        Me.SimpleButton6.Location = New System.Drawing.Point(285, 36)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(271, 22)
        Me.SimpleButton6.StyleController = Me.LayoutControl5
        Me.SimpleButton6.TabIndex = 9
        Me.SimpleButton6.Text = "حفظ"
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup5"
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem18})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(568, 218)
        Me.LayoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup5.Text = "LayoutControlGroup5"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SimpleButton6
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(273, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(275, 174)
        Me.LayoutControlItem15.Text = "LayoutControlItem15"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextToControlDistance = 0
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.SimpleButton5
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(273, 174)
        Me.LayoutControlItem16.Text = "LayoutControlItem16"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextToControlDistance = 0
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.TextEdit3
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(548, 24)
        Me.LayoutControlItem18.Text = "المرفق"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(33, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(598, 269)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.XtraTabControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(578, 249)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'NewDBFDataSetBindingSource
        '
        Me.NewDBFDataSetBindingSource.DataSource = Me.NewDBFDataSet
        Me.NewDBFDataSetBindingSource.Position = 0
        '
        'ExportDenoteI
        '
        Me.ExportDenoteI.DataMember = "Export_DenoteI"
        Me.ExportDenoteI.DataSource = Me.NewDBFDataSet
        '
        'Export_DenoteITableAdapter
        '
        Me.Export_DenoteITableAdapter.ClearBeforeFill = True
        '
        'ExportDenoteE
        '
        Me.ExportDenoteE.DataMember = "Export_DenoteE"
        Me.ExportDenoteE.DataSource = Me.NewDBFDataSet
        '
        'Export_DenoteETableAdapter
        '
        Me.Export_DenoteETableAdapter.ClearBeforeFill = True
        '
        'ImportDenote
        '
        Me.ImportDenote.DataMember = "Import_Denote"
        Me.ImportDenote.DataSource = Me.NewDBFDataSet
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(689, 24)
        Me.LayoutControlItem17.Text = "وارد من"
        Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(34, 13)
        Me.LayoutControlItem17.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem17"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(689, 24)
        Me.LayoutControlItem12.Text = "وارد من"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(34, 13)
        Me.LayoutControlItem12.TextToControlDistance = 5
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem14.Control = Me.TextEdit1
        Me.LayoutControlItem14.CustomizationFormText = "رقم الكتاب"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 160)
        Me.LayoutControlItem14.Name = "LayoutControlItem2"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(547, 24)
        Me.LayoutControlItem14.Text = "رقم الكتاب"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem14.TextToControlDistance = 5
        '
        'Import_DenoteTableAdapter
        '
        Me.Import_DenoteTableAdapter.ClearBeforeFill = True
        '
        'ImportDocIDenoteTableAdapter
        '
        Me.ImportDocIDenoteTableAdapter.ClearBeforeFill = True
        '
        'ExportDoc1TableAdapter
        '
        Me.ExportDoc1TableAdapter.ClearBeforeFill = True
        '
        'ExportAttachBindingSource
        '
        Me.ExportAttachBindingSource.DataMember = "Export_Attachment"
        Me.ExportAttachBindingSource.DataSource = Me.NewDBFDataSet
        '
        'Export_AttachmentTableAdapter
        '
        Me.Export_AttachmentTableAdapter.ClearBeforeFill = True
        '
        'ImportAttachBindingSource
        '
        Me.ImportAttachBindingSource.DataMember = "Import_Attachment"
        Me.ImportAttachBindingSource.DataSource = Me.NewDBFDataSet1
        '
        'NewDBFDataSet1
        '
        Me.NewDBFDataSet1.DataSetName = "NewDBFDataSet"
        Me.NewDBFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Import_AttachmentTableAdapter
        '
        Me.Import_AttachmentTableAdapter.ClearBeforeFill = True
        '
        'ErrorTrace1
        '
        Me.ErrorTrace1.ActiveMethod = Nothing
        Me.ErrorTrace1.CustomBody = Nothing
        Me.ErrorTrace1.Enabled = True
        Me.ErrorTrace1.Ex = CType(resources.GetObject("ErrorTrace1.Ex"), System.Exception)
        Me.ErrorTrace1.From = Nothing
        Me.ErrorTrace1.LineNumber = Nothing
        Me.ErrorTrace1.NotifyLocal = False
        Me.ErrorTrace1.SendReport = False
        Me.ErrorTrace1.SendTo = Nothing
        Me.ErrorTrace1.SMTPPass = Nothing
        Me.ErrorTrace1.SMTPServer = Nothing
        Me.ErrorTrace1.SMTPUser = Nothing
        Me.ErrorTrace1.Subject = Nothing
        '
        'DenoteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 269)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "DenoteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DenoteForm"
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        CType(Me.OrgBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.importDocIDenoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDocNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl5.ResumeLayout(False)
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDenoteI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDenoteE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDenote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportAttachBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportAttachBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents OrgBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrgTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter
    Friend WithEvents ExportDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportDocTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOwner_Org_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExportId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecurity_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSummary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnderAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAboutToSign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdate_Login As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdate_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreate_Login As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreate_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDelete_Login As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDelete_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OrgItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ExportDenoteI As System.Windows.Forms.BindingSource
    Friend WithEvents Export_DenoteITableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Export_DenoteITableAdapter
    Friend WithEvents ExportDenoteE As System.Windows.Forms.BindingSource
    Friend WithEvents Export_DenoteETableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Export_DenoteETableAdapter
    Friend WithEvents ImportDenote As System.Windows.Forms.BindingSource
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PopupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colOrg_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colorg_folder As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents NewDBFDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOwner_Org_No1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImport_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImport_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook_no1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook_Date1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImport_Org_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Import_DenoteTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Import_DenoteTableAdapter
    Friend WithEvents importDocIDenoteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImportDocIDenoteTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ImportDocIDenoteTableAdapter
    Friend WithEvents ExportDocNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportDoc1TableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ExportDoc1TableAdapter
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl5 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ExportAttachBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Export_AttachmentTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Export_AttachmentTableAdapter
    Friend WithEvents ImportAttachBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewDBFDataSet1 As WinImpExp.NewDBFDataSet
    Friend WithEvents Import_AttachmentTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Import_AttachmentTableAdapter
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
    Friend WithEvents OrgBindingSource1 As System.Windows.Forms.BindingSource

End Class
