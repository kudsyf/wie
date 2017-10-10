<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletedExportListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletedExportListForm))
        Me.ImportGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOwner_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colUnderAction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAboutToSign = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdate_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdate_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreate_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreate_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ExportToBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ExportDocTableAdapter()
        Me.TypeTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter()
        Me.SecurityTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter()
        Me.Export_ToTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_ToTableAdapter()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ExportDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImportGridControl
        '
        Me.ImportGridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ImportGridControl.DataSource = Me.ExportDocBindingSource
        Me.ImportGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImportGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ImportGridControl.LookAndFeel.UseWindowsXPTheme = True
        Me.ImportGridControl.MainView = Me.GridView1
        Me.ImportGridControl.Name = "ImportGridControl"
        Me.ImportGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TypeItemLookUpEdit1, Me.SecurityItemLookUpEdit1})
        Me.ImportGridControl.Size = New System.Drawing.Size(863, 420)
        Me.ImportGridControl.TabIndex = 1
        Me.ImportGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOwner_Org_No, Me.colExportId, Me.colBook_no, Me.colBook_Date, Me.colType_Code, Me.colSecurity_Code, Me.colSubject, Me.colSummary, Me.colUnderAction, Me.colAboutToSign, Me.colDeleted, Me.colUpdate_Login, Me.colUpdate_Date, Me.colCreate_Login, Me.colCreate_Date, Me.colDelete_Login, Me.colDelete_Date})
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
        Me.colOwner_Org_No.FieldName = "Owner_Org_No"
        Me.colOwner_Org_No.Name = "colOwner_Org_No"
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
        'DeletedExportListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 420)
        Me.Controls.Add(Me.ImportGridControl)
        Me.Name = "DeletedExportListForm"
        Me.Text = "سلة محذوفات الصادر"
        CType(Me.ImportGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ExportDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
End Class
