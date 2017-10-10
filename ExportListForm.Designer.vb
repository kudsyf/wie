<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportListForm
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportListForm))
        Me.colUnderAction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ImportGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.followmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOwner_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OrgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colExportId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TypeItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSecurity_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SecurityItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSummary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAboutToSign = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdate_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdate_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreate_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreate_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ExportTo2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportTo1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter()
        Me.TypeTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter()
        Me.SecurityTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter()
        Me.Export_ToTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_ToTableAdapter()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        Me.Export_To1TableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_To1TableAdapter()
        Me.Export_To2TableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_To2TableAdapter()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelMin = New DevExpress.XtraEditors.LabelControl()
        Me.LabelMax = New DevExpress.XtraEditors.LabelControl()
        Me.RangeTrackBarControl1 = New DevExpress.XtraEditors.RangeTrackBarControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ExportDocDateTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.ExportDocDateTableAdapter()
        Me.OrgTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter()
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ExportDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportTo2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportTo1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ImportGridControl
        '
        Me.ImportGridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ImportGridControl.DataSource = Me.ExportDocBindingSource
        Me.ImportGridControl.Location = New System.Drawing.Point(137, 12)
        Me.ImportGridControl.LookAndFeel.UseWindowsXPTheme = True
        Me.ImportGridControl.MainView = Me.GridView1
        Me.ImportGridControl.Name = "ImportGridControl"
        Me.ImportGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TypeItemLookUpEdit1, Me.SecurityItemLookUpEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.ImportGridControl.Size = New System.Drawing.Size(714, 396)
        Me.ImportGridControl.TabIndex = 1
        Me.ImportGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.followmenu})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem1.Text = "حذف قيد صادر"
        '
        'followmenu
        '
        Me.followmenu.Name = "followmenu"
        Me.followmenu.Size = New System.Drawing.Size(127, 22)
        Me.followmenu.Text = "متابعة قيد"
        '
        'ExportDocBindingSource
        '
        Me.ExportDocBindingSource.DataMember = "ExportDoc"
        Me.ExportDocBindingSource.DataSource = Me.NewDBFDataSet
        Me.ExportDocBindingSource.Filter = "deleted = 0"
        '
        'NewDBFDataSet
        '
        Me.NewDBFDataSet.DataSetName = "NewDBFDataSet"
        Me.NewDBFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOwner_Org_No, Me.colExportId, Me.colBook_no, Me.colBook_Date, Me.colType_Code, Me.colSecurity_Code, Me.colSubject, Me.colSummary, Me.colUnderAction, Me.colAboutToSign, Me.colDeleted, Me.colUpdate_Login, Me.colUpdate_Date, Me.colCreate_Login, Me.colCreate_Date, Me.colDelete_Login, Me.colDelete_Date, Me.GridColumn1})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colUnderAction
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "true"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GridView1.GridControl = Me.ImportGridControl
        Me.GridView1.GroupPanelText = "أختيار العمود لغرض التجميع"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colOwner_Org_No
        '
        Me.colOwner_Org_No.AppearanceCell.Options.UseTextOptions = True
        Me.colOwner_Org_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOwner_Org_No.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOwner_Org_No.AppearanceHeader.Options.UseFont = True
        Me.colOwner_Org_No.AppearanceHeader.Options.UseTextOptions = True
        Me.colOwner_Org_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOwner_Org_No.Caption = "الدائرة"
        Me.colOwner_Org_No.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colOwner_Org_No.FieldName = "Owner_Org_No"
        Me.colOwner_Org_No.Name = "colOwner_Org_No"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemLookUpEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.Options.UseFont = True
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.RepositoryItemLookUpEdit2.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_no", "Org_no", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_Name", "الدائرة", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_Up", "Org_Up", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("org_folder", "org_folder", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.OrgBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Org_Name"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Org_no"
        '
        'OrgBindingSource
        '
        Me.OrgBindingSource.DataMember = "Org"
        Me.OrgBindingSource.DataSource = Me.NewDBFDataSet
        '
        'colExportId
        '
        Me.colExportId.AppearanceCell.Options.UseTextOptions = True
        Me.colExportId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExportId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExportId.AppearanceHeader.Options.UseFont = True
        Me.colExportId.AppearanceHeader.Options.UseTextOptions = True
        Me.colExportId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExportId.FieldName = "ExportId"
        Me.colExportId.Name = "colExportId"
        '
        'colBook_no
        '
        Me.colBook_no.AppearanceCell.Options.UseTextOptions = True
        Me.colBook_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_no.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBook_no.AppearanceHeader.Options.UseFont = True
        Me.colBook_no.AppearanceHeader.Options.UseTextOptions = True
        Me.colBook_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_no.Caption = "رقم الكتاب"
        Me.colBook_no.FieldName = "Book_no"
        Me.colBook_no.Name = "colBook_no"
        Me.colBook_no.Visible = True
        Me.colBook_no.VisibleIndex = 5
        '
        'colBook_Date
        '
        Me.colBook_Date.AppearanceCell.Options.UseTextOptions = True
        Me.colBook_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_Date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBook_Date.AppearanceHeader.Options.UseFont = True
        Me.colBook_Date.AppearanceHeader.Options.UseTextOptions = True
        Me.colBook_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBook_Date.Caption = "تاريخ الكتاب"
        Me.colBook_Date.FieldName = "Book_Date"
        Me.colBook_Date.Name = "colBook_Date"
        Me.colBook_Date.Visible = True
        Me.colBook_Date.VisibleIndex = 4
        '
        'colType_Code
        '
        Me.colType_Code.AppearanceCell.Options.UseTextOptions = True
        Me.colType_Code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colType_Code.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colType_Code.AppearanceHeader.Options.UseFont = True
        Me.colType_Code.AppearanceHeader.Options.UseTextOptions = True
        Me.colType_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colType_Code.Caption = "نوع الكتاب"
        Me.colType_Code.ColumnEdit = Me.TypeItemLookUpEdit1
        Me.colType_Code.FieldName = "Type_Code"
        Me.colType_Code.Name = "colType_Code"
        Me.colType_Code.Visible = True
        Me.colType_Code.VisibleIndex = 3
        '
        'TypeItemLookUpEdit1
        '
        Me.TypeItemLookUpEdit1.AutoHeight = False
        Me.TypeItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TypeItemLookUpEdit1.DataSource = Me.TypeBindingSource
        Me.TypeItemLookUpEdit1.DisplayMember = "Type"
        Me.TypeItemLookUpEdit1.Name = "TypeItemLookUpEdit1"
        Me.TypeItemLookUpEdit1.ValueMember = "Type_Code"
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.NewDBFDataSet
        '
        'colSecurity_Code
        '
        Me.colSecurity_Code.AppearanceCell.Options.UseTextOptions = True
        Me.colSecurity_Code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSecurity_Code.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSecurity_Code.AppearanceHeader.Options.UseFont = True
        Me.colSecurity_Code.AppearanceHeader.Options.UseTextOptions = True
        Me.colSecurity_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSecurity_Code.Caption = "درجة السرية"
        Me.colSecurity_Code.ColumnEdit = Me.SecurityItemLookUpEdit1
        Me.colSecurity_Code.FieldName = "Security_Code"
        Me.colSecurity_Code.Name = "colSecurity_Code"
        Me.colSecurity_Code.Visible = True
        Me.colSecurity_Code.VisibleIndex = 2
        '
        'SecurityItemLookUpEdit1
        '
        Me.SecurityItemLookUpEdit1.AutoHeight = False
        Me.SecurityItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SecurityItemLookUpEdit1.DataSource = Me.SecurityBindingSource
        Me.SecurityItemLookUpEdit1.DisplayMember = "Security"
        Me.SecurityItemLookUpEdit1.Name = "SecurityItemLookUpEdit1"
        Me.SecurityItemLookUpEdit1.ValueMember = "Security_Code"
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
        Me.colSubject.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubject.AppearanceHeader.Options.UseFont = True
        Me.colSubject.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubject.Caption = "الموضوع"
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 1
        '
        'colSummary
        '
        Me.colSummary.AppearanceCell.Options.UseTextOptions = True
        Me.colSummary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSummary.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSummary.AppearanceHeader.Options.UseFont = True
        Me.colSummary.AppearanceHeader.Options.UseTextOptions = True
        Me.colSummary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSummary.Caption = "الملخص"
        Me.colSummary.FieldName = "Summary"
        Me.colSummary.Name = "colSummary"
        Me.colSummary.Visible = True
        Me.colSummary.VisibleIndex = 0
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
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "صادر الى"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn1.FieldName = "ExportId"
        Me.GridColumn1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.ExportTo2BindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "SalesOrderIDs"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Exportid"
        '
        'ExportTo2BindingSource
        '
        Me.ExportTo2BindingSource.DataMember = "Export_To2"
        Me.ExportTo2BindingSource.DataSource = Me.NewDBFDataSet
        '
        'ExportTo1BindingSource
        '
        Me.ExportTo1BindingSource.DataMember = "Export_To1"
        Me.ExportTo1BindingSource.DataSource = Me.NewDBFDataSet
        '
        'ExportToBindingSource
        '
        Me.ExportToBindingSource.DataMember = "Export_To"
        Me.ExportToBindingSource.DataSource = Me.NewDBFDataSet
        '
        'ExportDocTableAdapter
        '
        Me.ExportDocTableAdapter.ClearBeforeFill = True
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'SecurityTableAdapter
        '
        Me.SecurityTableAdapter.ClearBeforeFill = True
        '
        'Export_ToTableAdapter
        '
        Me.Export_ToTableAdapter.ClearBeforeFill = True
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
        'Export_To1TableAdapter
        '
        Me.Export_To1TableAdapter.ClearBeforeFill = True
        '
        'Export_To2TableAdapter
        '
        Me.Export_To2TableAdapter.ClearBeforeFill = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.ImportGridControl)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.LabelControl2)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.LabelMin)
        Me.LayoutControl1.Controls.Add(Me.LabelMax)
        Me.LayoutControl1.Controls.Add(Me.RangeTrackBarControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(863, 420)
        Me.LayoutControl1.TabIndex = 2
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
        Me.CheckEdit1.Size = New System.Drawing.Size(121, 19)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 17
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(121, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "تحديث"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Location = New System.Drawing.Point(58, 378)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl2.StyleController = Me.LayoutControl1
        Me.LabelControl2.TabIndex = 15
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Location = New System.Drawing.Point(58, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 14
        '
        'LabelMin
        '
        Me.LabelMin.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelMin.Location = New System.Drawing.Point(58, 61)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(75, 13)
        Me.LabelMin.StyleController = Me.LayoutControl1
        Me.LabelMin.TabIndex = 12
        '
        'LabelMax
        '
        Me.LabelMax.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelMax.Location = New System.Drawing.Point(58, 395)
        Me.LabelMax.Name = "LabelMax"
        Me.LabelMax.Size = New System.Drawing.Size(75, 13)
        Me.LabelMax.StyleController = Me.LayoutControl1
        Me.LabelMax.TabIndex = 13
        '
        'RangeTrackBarControl1
        '
        Me.RangeTrackBarControl1.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 0)
        Me.RangeTrackBarControl1.Location = New System.Drawing.Point(12, 61)
        Me.RangeTrackBarControl1.Name = "RangeTrackBarControl1"
        Me.RangeTrackBarControl1.Properties.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.RangeTrackBarControl1.Size = New System.Drawing.Size(42, 347)
        Me.RangeTrackBarControl1.StyleController = Me.LayoutControl1
        Me.RangeTrackBarControl1.TabIndex = 11
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(863, 420)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ImportGridControl
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(125, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(718, 400)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(46, 83)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(79, 283)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(125, 26)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.RangeTrackBarControl1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(46, 351)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelMin
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(46, 49)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(79, 17)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LabelMax
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(46, 383)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(79, 17)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.LabelControl1
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(46, 66)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(79, 17)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.LabelControl2
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(46, 366)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(79, 17)
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
        Me.LayoutControlItem8.Size = New System.Drawing.Size(125, 23)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'ExportDocDateTableAdapter1
        '
        Me.ExportDocDateTableAdapter1.ClearBeforeFill = True
        '
        'OrgTableAdapter
        '
        Me.OrgTableAdapter.ClearBeforeFill = True
        '
        'ExportListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 420)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ExportListForm"
        Me.Text = "قائمة الصادر"
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ExportDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportTo2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportTo1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImportGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents ExportDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportDocTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter
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
    Friend WithEvents TypeItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents SecurityItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SecurityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SecurityTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter
    Friend WithEvents ExportToBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Export_ToTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Export_ToTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents followmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
    Friend WithEvents ExportTo1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Export_To1TableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Export_To1TableAdapter
    Friend WithEvents ExportTo2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Export_To2TableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Export_To2TableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelMin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelMax As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RangeTrackBarControl1 As DevExpress.XtraEditors.RangeTrackBarControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ExportDocDateTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.ExportDocDateTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OrgBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrgTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter
End Class
