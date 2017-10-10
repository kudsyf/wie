<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocalExportListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocalExportListForm))
        Me.ImportGridControl = New DevExpress.XtraGrid.GridControl()
        Me.LocalExportToBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTo_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOwner_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OrgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSecurity_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSummary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStts = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.colExportId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SecurityLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.typeItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        Me.LocalExportToTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.LocalExportToTableAdapter()
        Me.OrgTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter()
        Me.SecurityTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter()
        Me.TypeTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter()
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalExportToBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.typeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImportGridControl
        '
        Me.ImportGridControl.DataSource = Me.LocalExportToBindingSource
        Me.ImportGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImportGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ImportGridControl.LookAndFeel.UseWindowsXPTheme = True
        Me.ImportGridControl.MainView = Me.GridView1
        Me.ImportGridControl.Name = "ImportGridControl"
        Me.ImportGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SecurityLookUpEdit1, Me.typeItemLookUpEdit1, Me.RepositoryItemImageComboBox1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4})
        Me.ImportGridControl.Size = New System.Drawing.Size(824, 416)
        Me.ImportGridControl.TabIndex = 0
        Me.ImportGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'LocalExportToBindingSource
        '
        Me.LocalExportToBindingSource.DataMember = "LocalExportTo"
        Me.LocalExportToBindingSource.DataSource = Me.NewDBFDataSet
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTo_Org_No, Me.colBook_no, Me.colBook_Date, Me.colOwner_Org_No, Me.colSecurity_Code, Me.colSubject, Me.colSummary, Me.colType_Code, Me.colDeleted, Me.colStts, Me.colExportId})
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
        'colTo_Org_No
        '
        Me.colTo_Org_No.FieldName = "To_Org_No"
        Me.colTo_Org_No.Name = "colTo_Org_No"
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
        Me.colBook_no.VisibleIndex = 4
        Me.colBook_no.Width = 86
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
        Me.colBook_Date.VisibleIndex = 3
        Me.colBook_Date.Width = 84
        '
        'colOwner_Org_No
        '
        Me.colOwner_Org_No.AppearanceCell.Options.UseTextOptions = True
        Me.colOwner_Org_No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colOwner_Org_No.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOwner_Org_No.AppearanceHeader.Options.UseFont = True
        Me.colOwner_Org_No.AppearanceHeader.Options.UseTextOptions = True
        Me.colOwner_Org_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOwner_Org_No.Caption = "صادر من"
        Me.colOwner_Org_No.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colOwner_Org_No.FieldName = "Owner_Org_No"
        Me.colOwner_Org_No.Name = "colOwner_Org_No"
        Me.colOwner_Org_No.Visible = True
        Me.colOwner_Org_No.VisibleIndex = 5
        Me.colOwner_Org_No.Width = 280
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_no", "Org_no", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_Name", "القسم", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Org_Up", "Org_Up", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("org_folder", "org_folder", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
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
        'colSecurity_Code
        '
        Me.colSecurity_Code.AppearanceCell.Options.UseTextOptions = True
        Me.colSecurity_Code.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colSecurity_Code.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSecurity_Code.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSecurity_Code.AppearanceHeader.Options.UseFont = True
        Me.colSecurity_Code.AppearanceHeader.Options.UseTextOptions = True
        Me.colSecurity_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSecurity_Code.Caption = "درجة السرية"
        Me.colSecurity_Code.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colSecurity_Code.FieldName = "Security_Code"
        Me.colSecurity_Code.Name = "colSecurity_Code"
        Me.colSecurity_Code.Visible = True
        Me.colSecurity_Code.VisibleIndex = 1
        Me.colSecurity_Code.Width = 92
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemLookUpEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Security_Code", "Security_Code", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Security", "درجة السرية", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.SecurityBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Security"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Security_Code"
        '
        'SecurityBindingSource
        '
        Me.SecurityBindingSource.DataMember = "Security"
        Me.SecurityBindingSource.DataSource = Me.NewDBFDataSet
        '
        'colSubject
        '
        Me.colSubject.AppearanceCell.Options.UseTextOptions = True
        Me.colSubject.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubject.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSubject.AppearanceHeader.Options.UseFont = True
        Me.colSubject.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubject.Caption = "الموضوع"
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 0
        Me.colSubject.Width = 348
        '
        'colSummary
        '
        Me.colSummary.AppearanceCell.Options.UseTextOptions = True
        Me.colSummary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSummary.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSummary.AppearanceHeader.Options.UseFont = True
        Me.colSummary.AppearanceHeader.Options.UseTextOptions = True
        Me.colSummary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSummary.Caption = "الملخص"
        Me.colSummary.FieldName = "Summary"
        Me.colSummary.Name = "colSummary"
        '
        'colType_Code
        '
        Me.colType_Code.AppearanceCell.Options.UseTextOptions = True
        Me.colType_Code.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colType_Code.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colType_Code.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colType_Code.AppearanceHeader.Options.UseFont = True
        Me.colType_Code.AppearanceHeader.Options.UseTextOptions = True
        Me.colType_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colType_Code.Caption = "نوع الكتاب"
        Me.colType_Code.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colType_Code.FieldName = "Type_Code"
        Me.colType_Code.Name = "colType_Code"
        Me.colType_Code.Visible = True
        Me.colType_Code.VisibleIndex = 2
        Me.colType_Code.Width = 78
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemLookUpEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type_Code", "Type_Code", 78, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "نوع الكتاب", 34, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.TypeBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Type"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "Type_Code"
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.NewDBFDataSet
        '
        'colDeleted
        '
        Me.colDeleted.FieldName = "Deleted"
        Me.colDeleted.Name = "colDeleted"
        '
        'colStts
        '
        Me.colStts.AppearanceCell.Options.UseTextOptions = True
        Me.colStts.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStts.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStts.AppearanceHeader.Options.UseFont = True
        Me.colStts.AppearanceHeader.Options.UseTextOptions = True
        Me.colStts.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStts.Caption = "الحالة"
        Me.colStts.ColumnEdit = Me.RepositoryItemImageComboBox1
        Me.colStts.FieldName = "Stts"
        Me.colStts.Name = "colStts"
        Me.colStts.Visible = True
        Me.colStts.VisibleIndex = 6
        Me.colStts.Width = 126
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("بدون متابعة", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("تم الحفظ", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("تم الطبع", 2, 2)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        Me.RepositoryItemImageComboBox1.SmallImages = Me.ImageList1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "MyEgy (1552).ico")
        Me.ImageList1.Images.SetKeyName(1, "save.png")
        Me.ImageList1.Images.SetKeyName(2, "print-view.ico")
        '
        'colExportId
        '
        Me.colExportId.FieldName = "ExportId"
        Me.colExportId.Name = "colExportId"
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
        Me.SecurityLookUpEdit1.DisplayMember = "Security"
        Me.SecurityLookUpEdit1.Name = "SecurityLookUpEdit1"
        Me.SecurityLookUpEdit1.ValueMember = "Security_Code"
        '
        'typeItemLookUpEdit1
        '
        Me.typeItemLookUpEdit1.Appearance.Options.UseTextOptions = True
        Me.typeItemLookUpEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.typeItemLookUpEdit1.AppearanceDropDown.Options.UseTextOptions = True
        Me.typeItemLookUpEdit1.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.typeItemLookUpEdit1.AutoHeight = False
        Me.typeItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.typeItemLookUpEdit1.DisplayMember = "Type"
        Me.typeItemLookUpEdit1.Name = "typeItemLookUpEdit1"
        Me.typeItemLookUpEdit1.ValueMember = "Type_Code"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
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
        'LocalExportToTableAdapter
        '
        Me.LocalExportToTableAdapter.ClearBeforeFill = True
        '
        'OrgTableAdapter
        '
        Me.OrgTableAdapter.ClearBeforeFill = True
        '
        'SecurityTableAdapter
        '
        Me.SecurityTableAdapter.ClearBeforeFill = True
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'LocalExportListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 416)
        Me.Controls.Add(Me.ImportGridControl)
        Me.Name = "LocalExportListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "قائمة الصادر الداخلي"
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalExportToBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.typeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImportGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SecurityLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents typeItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LocalExportToBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents colTo_Org_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOwner_Org_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecurity_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSummary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStts As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExportId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LocalExportToTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.LocalExportToTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OrgBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrgTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SecurityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SecurityTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
