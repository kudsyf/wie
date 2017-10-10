<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportListForm))
        Me.colUnderAction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.ImportGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ImportDocWithTrans1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOwner_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OrgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colImportId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImport_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.typeItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSecurity_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SecurityLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSummary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImport_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImport_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrg_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ImportDocWithTransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDocTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDocSecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ImportDocTableAdapter()
        Me.SecurityTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter()
        Me.TypeTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FollowupMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelMax = New DevExpress.XtraEditors.LabelControl()
        Me.LabelMin = New DevExpress.XtraEditors.LabelControl()
        Me.RangeTrackBarControl1 = New DevExpress.XtraEditors.RangeTrackBarControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.OrgTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter()
        Me.ImportDocDatesTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.ImportDocDatesTableAdapter()
        Me.Import_FolderTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.Import_FolderTableAdapter()
        Me.FolderTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.FolderTableAdapter()
        Me.ImportDocWithTransTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ImportDocWithTransTableAdapter()
        Me.ImportDocWithTrans1TableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ImportDocWithTrans1TableAdapter()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocWithTrans1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.typeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocWithTransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocSecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colUnderAction
        '
        Me.colUnderAction.FieldName = "UnderAction"
        Me.colUnderAction.Name = "colUnderAction"
        '
        'NewDBFDataSet
        '
        Me.NewDBFDataSet.DataSetName = "NewDBFDataSet"
        Me.NewDBFDataSet.EnforceConstraints = False
        Me.NewDBFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImportGridControl
        '
        Me.ImportGridControl.DataSource = Me.ImportDocWithTrans1BindingSource
        Me.ImportGridControl.Location = New System.Drawing.Point(131, 12)
        Me.ImportGridControl.LookAndFeel.UseWindowsXPTheme = True
        Me.ImportGridControl.MainView = Me.GridView1
        Me.ImportGridControl.Name = "ImportGridControl"
        Me.ImportGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SecurityLookUpEdit1, Me.typeItemLookUpEdit1, Me.RepositoryItemLookUpEdit1})
        Me.ImportGridControl.Size = New System.Drawing.Size(1016, 365)
        Me.ImportGridControl.TabIndex = 0
        Me.ImportGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ImportDocWithTrans1BindingSource
        '
        Me.ImportDocWithTrans1BindingSource.DataMember = "ImportDocWithTrans1"
        Me.ImportDocWithTrans1BindingSource.DataSource = Me.NewDBFDataSet
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOwner_Org_No, Me.colImportId, Me.colImport_Org_No, Me.colDeleted, Me.colBook_no, Me.colBook_Date, Me.colType_Code, Me.colSecurity_Code, Me.colSubject, Me.colSummary, Me.colImport_Date, Me.colImport_No, Me.colUnderAction, Me.GridColumn2, Me.GridColumn3, Me.colOrg_Name})
        Me.GridView1.GridControl = Me.ImportGridControl
        Me.GridView1.GroupPanelText = "أختيار العمود لغرض التجميع"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colOwner_Org_No
        '
        Me.colOwner_Org_No.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOwner_Org_No.AppearanceHeader.Options.UseFont = True
        Me.colOwner_Org_No.AppearanceHeader.Options.UseTextOptions = True
        Me.colOwner_Org_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOwner_Org_No.Caption = "القسم"
        Me.colOwner_Org_No.FieldName = "_Owner_Org_No"
        Me.colOwner_Org_No.Name = "colOwner_Org_No"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemLookUpEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemLookUpEdit1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.RepositoryItemLookUpEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.Options.UseTextOptions = True
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.RepositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.Options.UseFont = True
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.RepositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_no", "Org_no", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_Name", "وارد من", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_Up", "Org_Up", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("org_folder", "org_folder", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.OrgBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Org_Name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Org_no"
        '
        'OrgBindingSource
        '
        Me.OrgBindingSource.DataMember = "Org"
        Me.OrgBindingSource.DataSource = Me.NewDBFDataSet
        '
        'colImportId
        '
        Me.colImportId.FieldName = "ImportId"
        Me.colImportId.Name = "colImportId"
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
        Me.colImport_Org_No.Caption = "وارد من"
        Me.colImport_Org_No.FieldName = "_Import_Org_No"
        Me.colImport_Org_No.Name = "colImport_Org_No"
        Me.colImport_Org_No.Visible = True
        Me.colImport_Org_No.VisibleIndex = 10
        Me.colImport_Org_No.Width = 71
        '
        'colDeleted
        '
        Me.colDeleted.FieldName = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        '
        'colBook_no
        '
        Me.colBook_no.AppearanceCell.Options.UseTextOptions = True
        Me.colBook_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colBook_no.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colBook_no.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray
        Me.colBook_no.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBook_no.AppearanceHeader.Options.UseBackColor = True
        Me.colBook_no.AppearanceHeader.Options.UseFont = True
        Me.colBook_no.AppearanceHeader.Options.UseTextOptions = True
        Me.colBook_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_no.Caption = "رقم الكتاب"
        Me.colBook_no.FieldName = "Book_no"
        Me.colBook_no.Name = "colBook_no"
        Me.colBook_no.Visible = True
        Me.colBook_no.VisibleIndex = 7
        Me.colBook_no.Width = 83
        '
        'colBook_Date
        '
        Me.colBook_Date.AppearanceCell.Options.UseTextOptions = True
        Me.colBook_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colBook_Date.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colBook_Date.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray
        Me.colBook_Date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBook_Date.AppearanceHeader.Options.UseBackColor = True
        Me.colBook_Date.AppearanceHeader.Options.UseFont = True
        Me.colBook_Date.AppearanceHeader.Options.UseTextOptions = True
        Me.colBook_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_Date.Caption = "تاريخ الكتاب"
        Me.colBook_Date.FieldName = "Book_Date"
        Me.colBook_Date.Name = "colBook_Date"
        Me.colBook_Date.Visible = True
        Me.colBook_Date.VisibleIndex = 6
        Me.colBook_Date.Width = 83
        '
        'colType_Code
        '
        Me.colType_Code.AppearanceCell.Options.UseTextOptions = True
        Me.colType_Code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colType_Code.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colType_Code.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray
        Me.colType_Code.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colType_Code.AppearanceHeader.Options.UseBackColor = True
        Me.colType_Code.AppearanceHeader.Options.UseFont = True
        Me.colType_Code.AppearanceHeader.Options.UseTextOptions = True
        Me.colType_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colType_Code.Caption = "نوع الكتاب"
        Me.colType_Code.ColumnEdit = Me.typeItemLookUpEdit1
        Me.colType_Code.FieldName = "Type_Code"
        Me.colType_Code.Name = "colType_Code"
        Me.colType_Code.Visible = True
        Me.colType_Code.VisibleIndex = 5
        Me.colType_Code.Width = 83
        '
        'typeItemLookUpEdit1
        '
        Me.typeItemLookUpEdit1.Appearance.Options.UseTextOptions = True
        Me.typeItemLookUpEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.typeItemLookUpEdit1.AppearanceDropDown.Options.UseTextOptions = True
        Me.typeItemLookUpEdit1.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.typeItemLookUpEdit1.AutoHeight = False
        Me.typeItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.typeItemLookUpEdit1.DataSource = Me.TypeBindingSource
        Me.typeItemLookUpEdit1.DisplayMember = "Type"
        Me.typeItemLookUpEdit1.Name = "typeItemLookUpEdit1"
        Me.typeItemLookUpEdit1.ValueMember = "Type_Code"
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.NewDBFDataSet
        '
        'colSecurity_Code
        '
        Me.colSecurity_Code.AppearanceCell.Options.UseTextOptions = True
        Me.colSecurity_Code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSecurity_Code.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colSecurity_Code.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray
        Me.colSecurity_Code.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSecurity_Code.AppearanceHeader.Options.UseBackColor = True
        Me.colSecurity_Code.AppearanceHeader.Options.UseFont = True
        Me.colSecurity_Code.AppearanceHeader.Options.UseTextOptions = True
        Me.colSecurity_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSecurity_Code.Caption = "درجة السرية"
        Me.colSecurity_Code.ColumnEdit = Me.SecurityLookUpEdit1
        Me.colSecurity_Code.FieldName = "Security_Code"
        Me.colSecurity_Code.Name = "colSecurity_Code"
        Me.colSecurity_Code.Visible = True
        Me.colSecurity_Code.VisibleIndex = 4
        Me.colSecurity_Code.Width = 83
        '
        'SecurityLookUpEdit1
        '
        Me.SecurityLookUpEdit1.AllowFocused = False
        Me.SecurityLookUpEdit1.Appearance.Options.UseTextOptions = True
        Me.SecurityLookUpEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SecurityLookUpEdit1.AppearanceDropDown.Options.UseTextOptions = True
        Me.SecurityLookUpEdit1.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SecurityLookUpEdit1.AutoHeight = False
        Me.SecurityLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SecurityLookUpEdit1.DataSource = Me.SecurityBindingSource
        Me.SecurityLookUpEdit1.DisplayMember = "Security"
        Me.SecurityLookUpEdit1.Name = "SecurityLookUpEdit1"
        Me.SecurityLookUpEdit1.ValueMember = "Security_Code"
        '
        'SecurityBindingSource
        '
        Me.SecurityBindingSource.DataMember = "Security"
        Me.SecurityBindingSource.DataSource = Me.NewDBFDataSet
        '
        'colSubject
        '
        Me.colSubject.AppearanceCell.Options.UseTextOptions = True
        Me.colSubject.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSubject.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colSubject.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray
        Me.colSubject.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubject.AppearanceHeader.Options.UseBackColor = True
        Me.colSubject.AppearanceHeader.Options.UseFont = True
        Me.colSubject.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubject.Caption = "الموضوع"
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 3
        Me.colSubject.Width = 83
        '
        'colSummary
        '
        Me.colSummary.AppearanceCell.Options.UseTextOptions = True
        Me.colSummary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSummary.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colSummary.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray
        Me.colSummary.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSummary.AppearanceHeader.Options.UseBackColor = True
        Me.colSummary.AppearanceHeader.Options.UseFont = True
        Me.colSummary.AppearanceHeader.Options.UseTextOptions = True
        Me.colSummary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSummary.Caption = "الملخص"
        Me.colSummary.FieldName = "Summary"
        Me.colSummary.Name = "colSummary"
        Me.colSummary.Visible = True
        Me.colSummary.VisibleIndex = 2
        Me.colSummary.Width = 83
        '
        'colImport_Date
        '
        Me.colImport_Date.AppearanceCell.Options.UseTextOptions = True
        Me.colImport_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colImport_Date.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colImport_Date.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray
        Me.colImport_Date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colImport_Date.AppearanceHeader.Options.UseBackColor = True
        Me.colImport_Date.AppearanceHeader.Options.UseFont = True
        Me.colImport_Date.AppearanceHeader.Options.UseTextOptions = True
        Me.colImport_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImport_Date.Caption = "تاريخ الوارد"
        Me.colImport_Date.FieldName = "Import_Date"
        Me.colImport_Date.Name = "colImport_Date"
        Me.colImport_Date.Visible = True
        Me.colImport_Date.VisibleIndex = 8
        Me.colImport_Date.Width = 83
        '
        'colImport_No
        '
        Me.colImport_No.AppearanceCell.Options.UseTextOptions = True
        Me.colImport_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colImport_No.AppearanceHeader.BackColor = System.Drawing.Color.Gray
        Me.colImport_No.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray
        Me.colImport_No.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colImport_No.AppearanceHeader.Options.UseBackColor = True
        Me.colImport_No.AppearanceHeader.Options.UseFont = True
        Me.colImport_No.AppearanceHeader.Options.UseTextOptions = True
        Me.colImport_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImport_No.Caption = "رقم الوارد"
        Me.colImport_No.FieldName = "Import_No"
        Me.colImport_No.Name = "colImport_No"
        Me.colImport_No.Visible = True
        Me.colImport_No.VisibleIndex = 9
        Me.colImport_No.Width = 64
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "رقم الاضبارة"
        Me.GridColumn2.FieldName = "Foldrnr"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 83
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "اسم الاضبارة"
        Me.GridColumn3.FieldName = "Foldernm"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 83
        '
        'colOrg_Name
        '
        Me.colOrg_Name.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.colOrg_Name.AppearanceHeader.Options.UseFont = True
        Me.colOrg_Name.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrg_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrg_Name.Caption = "الجهة المحال اليها"
        Me.colOrg_Name.FieldName = "Org_Name"
        Me.colOrg_Name.Name = "colOrg_Name"
        Me.colOrg_Name.Width = 116
        '
        'ImportDocWithTransBindingSource
        '
        Me.ImportDocWithTransBindingSource.DataMember = "ImportDocWithTrans"
        Me.ImportDocWithTransBindingSource.DataSource = Me.NewDBFDataSet
        '
        'ImportDocBindingSource
        '
        Me.ImportDocBindingSource.DataMember = "ImportDoc"
        Me.ImportDocBindingSource.DataSource = Me.NewDBFDataSet
        Me.ImportDocBindingSource.Filter = ""
        '
        'ImportDocTypeBindingSource
        '
        Me.ImportDocTypeBindingSource.DataMember = "ImportDoc_Type"
        Me.ImportDocTypeBindingSource.DataSource = Me.ImportDocBindingSource
        '
        'ImportDocSecurityBindingSource
        '
        Me.ImportDocSecurityBindingSource.DataMember = "ImportDoc_Security"
        Me.ImportDocSecurityBindingSource.DataSource = Me.ImportDocBindingSource
        '
        'ImportDocTableAdapter
        '
        Me.ImportDocTableAdapter.ClearBeforeFill = True
        '
        'SecurityTableAdapter
        '
        Me.SecurityTableAdapter.ClearBeforeFill = True
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FollowupMenu})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripMenuItem1.Text = "حذف قيد وارد"
        '
        'FollowupMenu
        '
        Me.FollowupMenu.Name = "FollowupMenu"
        Me.FollowupMenu.Size = New System.Drawing.Size(108, 22)
        Me.FollowupMenu.Text = "متابعة وارد"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "ExportDoc"
        Me.BindingSource1.DataSource = Me.NewDBFDataSet
        '
        'ExportDocTableAdapter
        '
        Me.ExportDocTableAdapter.ClearBeforeFill = True
        '
        'ErrorTrace1
        '
        Me.ErrorTrace1.ActiveMethod = Nothing
        Me.ErrorTrace1.CustomBody = Nothing
        Me.ErrorTrace1.Enabled = True
        Me.ErrorTrace1.Ex = CType(resources.GetObject("ErrorTrace1.Ex"), System.Exception)
        Me.ErrorTrace1.From = Nothing
        Me.ErrorTrace1.LineNumber = Nothing
        Me.ErrorTrace1.MMSG = Nothing
        Me.ErrorTrace1.NotifyLocal = False
        Me.ErrorTrace1.SendReport = False
        Me.ErrorTrace1.SendTo = Nothing
        Me.ErrorTrace1.SMTPPass = Nothing
        Me.ErrorTrace1.SMTPServer = Nothing
        Me.ErrorTrace1.SMTPUser = Nothing
        Me.ErrorTrace1.Subject = Nothing
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.LabelControl2)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.LabelMax)
        Me.LayoutControl1.Controls.Add(Me.LabelMin)
        Me.LayoutControl1.Controls.Add(Me.RangeTrackBarControl1)
        Me.LayoutControl1.Controls.Add(Me.ImportGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1159, 389)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 38)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.CheckEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Properties.Caption = "جميع الاقسام"
        Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Size = New System.Drawing.Size(115, 19)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 10
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(115, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "تحديث"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Location = New System.Drawing.Point(61, 347)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl2.StyleController = Me.LayoutControl1
        Me.LabelControl2.TabIndex = 8
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Location = New System.Drawing.Point(61, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 7
        '
        'LabelMax
        '
        Me.LabelMax.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelMax.Location = New System.Drawing.Point(61, 364)
        Me.LabelMax.Name = "LabelMax"
        Me.LabelMax.Size = New System.Drawing.Size(66, 13)
        Me.LabelMax.StyleController = Me.LayoutControl1
        Me.LabelMax.TabIndex = 6
        '
        'LabelMin
        '
        Me.LabelMin.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelMin.Location = New System.Drawing.Point(61, 61)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(66, 13)
        Me.LabelMin.StyleController = Me.LayoutControl1
        Me.LabelMin.TabIndex = 5
        '
        'RangeTrackBarControl1
        '
        Me.RangeTrackBarControl1.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 0)
        Me.RangeTrackBarControl1.Location = New System.Drawing.Point(12, 61)
        Me.RangeTrackBarControl1.Name = "RangeTrackBarControl1"
        Me.RangeTrackBarControl1.Properties.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.RangeTrackBarControl1.Size = New System.Drawing.Size(45, 316)
        Me.RangeTrackBarControl1.StyleController = Me.LayoutControl1
        Me.RangeTrackBarControl1.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1159, 389)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ImportGridControl
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(119, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1020, 369)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RangeTrackBarControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(49, 320)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(49, 83)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(70, 252)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.LabelMin
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(49, 49)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelMax
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(49, 352)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LabelControl1
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(49, 66)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.LabelControl2
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(49, 335)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckEdit1
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(119, 23)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'OrgTableAdapter
        '
        Me.OrgTableAdapter.ClearBeforeFill = True
        '
        'ImportDocDatesTableAdapter1
        '
        Me.ImportDocDatesTableAdapter1.ClearBeforeFill = True
        '
        'Import_FolderTableAdapter1
        '
        Me.Import_FolderTableAdapter1.ClearBeforeFill = True
        '
        'FolderTableAdapter1
        '
        Me.FolderTableAdapter1.ClearBeforeFill = True
        '
        'ImportDocWithTransTableAdapter
        '
        Me.ImportDocWithTransTableAdapter.ClearBeforeFill = True
        '
        'ImportDocWithTrans1TableAdapter
        '
        Me.ImportDocWithTrans1TableAdapter.ClearBeforeFill = True
        '
        'ImportListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 389)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ImportListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "قائمة الوارد"
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocWithTrans1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.typeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocWithTransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocSecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents ImportGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ImportDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImportDocTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ImportDocTableAdapter
    Friend WithEvents colOwner_Org_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImport_Org_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSummary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecurity_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImport_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImport_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SecurityLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SecurityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SecurityTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter
    Friend WithEvents typeItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ImportDocTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents ImportDocSecurityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ExportDocTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter
    Friend WithEvents FollowupMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colUnderAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OrgBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrgTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter
    Friend WithEvents LabelMax As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelMin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RangeTrackBarControl1 As DevExpress.XtraEditors.RangeTrackBarControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImportDocDatesTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.ImportDocDatesTableAdapter
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Import_FolderTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.Import_FolderTableAdapter
    Friend WithEvents FolderTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.FolderTableAdapter
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrg_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImportDocWithTransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImportDocWithTransTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ImportDocWithTransTableAdapter
    Friend WithEvents ImportDocWithTrans1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImportDocWithTrans1TableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ImportDocWithTrans1TableAdapter
End Class
