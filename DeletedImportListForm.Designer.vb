<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletedImportListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletedImportListForm))
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.ImportGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ImportDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOwner_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.ImportDocTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDocSecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ImportDocTableAdapter()
        Me.SecurityTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter()
        Me.TypeTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.typeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocSecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewDBFDataSet
        '
        Me.NewDBFDataSet.DataSetName = "NewDBFDataSet"
        Me.NewDBFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImportGridControl
        '
        Me.ImportGridControl.DataSource = Me.ImportDocBindingSource
        Me.ImportGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImportGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ImportGridControl.LookAndFeel.UseWindowsXPTheme = True
        Me.ImportGridControl.MainView = Me.GridView1
        Me.ImportGridControl.Name = "ImportGridControl"
        Me.ImportGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SecurityLookUpEdit1, Me.typeItemLookUpEdit1})
        Me.ImportGridControl.Size = New System.Drawing.Size(824, 416)
        Me.ImportGridControl.TabIndex = 0
        Me.ImportGridControl.UseEmbeddedNavigator = True
        Me.ImportGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ImportDocBindingSource
        '
        Me.ImportDocBindingSource.DataMember = "ImportDoc"
        Me.ImportDocBindingSource.DataSource = Me.NewDBFDataSet
        Me.ImportDocBindingSource.Filter = ""
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOwner_Org_No, Me.colImportId, Me.colImport_Org_No, Me.colDeleted, Me.colBook_no, Me.colBook_Date, Me.colType_Code, Me.colSecurity_Code, Me.colSubject, Me.colSummary, Me.colImport_Date, Me.colImport_No})
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
        Me.colOwner_Org_No.FieldName = "Owner_Org_No"
        Me.colOwner_Org_No.Name = "colOwner_Org_No"
        '
        'colImportId
        '
        Me.colImportId.FieldName = "ImportId"
        Me.colImportId.Name = "colImportId"
        '
        'colImport_Org_No
        '
        Me.colImport_Org_No.FieldName = "Import_Org_No"
        Me.colImport_Org_No.Name = "colImport_Org_No"
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
        Me.colBook_no.VisibleIndex = 5
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
        Me.colBook_Date.VisibleIndex = 4
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
        Me.colType_Code.VisibleIndex = 3
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
        Me.colSecurity_Code.VisibleIndex = 2
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
        Me.colSubject.VisibleIndex = 1
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
        Me.colSummary.VisibleIndex = 0
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
        Me.colImport_Date.VisibleIndex = 6
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
        Me.colImport_No.VisibleIndex = 7
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem1.Text = "حذف قيد نهائيا"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem2.Text = "استرجاع قيد"
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
        Me.ErrorTrace1.NotifyLocal = False
        Me.ErrorTrace1.SendReport = False
        Me.ErrorTrace1.SendTo = Nothing
        Me.ErrorTrace1.SMTPPass = Nothing
        Me.ErrorTrace1.SMTPServer = Nothing
        Me.ErrorTrace1.SMTPUser = Nothing
        Me.ErrorTrace1.Subject = Nothing
        '
        'DeletedImportListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 416)
        Me.Controls.Add(Me.ImportGridControl)
        Me.Name = "DeletedImportListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "سلة محذوفات الوارد"
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.typeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocSecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ExportDocTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
End Class
