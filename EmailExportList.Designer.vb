<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailExportList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmailExportList))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailExportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colExportId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExportNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExportDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOwner_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreated_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreated_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        Me.EmailExportsTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.EmailExportsTableAdapter()
        Me.OrgTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter()
        Me.OrgemailTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.orgemailTableAdapter()
        Me.EmailExports_TO_CCTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.EmailExports_TO_CCTableAdapter()
        Me.EmailExports_AttachTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.EmailExports_AttachTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.EmailExportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.DataSource = Me.EmailExportsBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(754, 357)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem1.Text = "حذف قيد صادر"
        '
        'EmailExportsBindingSource
        '
        Me.EmailExportsBindingSource.DataMember = "EmailExports"
        Me.EmailExportsBindingSource.DataSource = Me.NewDBFDataSet
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colExportId, Me.colExportNo, Me.colExportDate, Me.colOwner_Org_No, Me.colCreated_Login, Me.colCreated_Date, Me.colEmailSubject, Me.colEmailTo, Me.colEmail, Me.coldeleted})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "اختيار العمود لغرض التجميع"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.SmartDetailExpand = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        '
        'colExportId
        '
        Me.colExportId.FieldName = "ExportId"
        Me.colExportId.Name = "colExportId"
        '
        'colExportNo
        '
        Me.colExportNo.AppearanceCell.Options.UseTextOptions = True
        Me.colExportNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExportNo.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colExportNo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExportNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExportNo.AppearanceHeader.Options.UseFont = True
        Me.colExportNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colExportNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExportNo.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colExportNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExportNo.Caption = "رقم الصادر"
        Me.colExportNo.FieldName = "ExportNo"
        Me.colExportNo.Name = "colExportNo"
        Me.colExportNo.Visible = True
        Me.colExportNo.VisibleIndex = 3
        '
        'colExportDate
        '
        Me.colExportDate.AppearanceCell.Options.UseTextOptions = True
        Me.colExportDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExportDate.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colExportDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExportDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExportDate.AppearanceHeader.Options.UseFont = True
        Me.colExportDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExportDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExportDate.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colExportDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExportDate.Caption = "تاريخ الصادر"
        Me.colExportDate.FieldName = "ExportDate"
        Me.colExportDate.Name = "colExportDate"
        Me.colExportDate.Visible = True
        Me.colExportDate.VisibleIndex = 2
        '
        'colOwner_Org_No
        '
        Me.colOwner_Org_No.FieldName = "Owner_Org_No"
        Me.colOwner_Org_No.Name = "colOwner_Org_No"
        '
        'colCreated_Login
        '
        Me.colCreated_Login.FieldName = "Created_Login"
        Me.colCreated_Login.Name = "colCreated_Login"
        '
        'colCreated_Date
        '
        Me.colCreated_Date.FieldName = "Created_Date"
        Me.colCreated_Date.Name = "colCreated_Date"
        '
        'colEmailSubject
        '
        Me.colEmailSubject.AppearanceCell.Options.UseTextOptions = True
        Me.colEmailSubject.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmailSubject.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colEmailSubject.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmailSubject.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEmailSubject.AppearanceHeader.Options.UseFont = True
        Me.colEmailSubject.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmailSubject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmailSubject.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colEmailSubject.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmailSubject.Caption = "الموضوع"
        Me.colEmailSubject.FieldName = "EmailSubject"
        Me.colEmailSubject.Name = "colEmailSubject"
        Me.colEmailSubject.Visible = True
        Me.colEmailSubject.VisibleIndex = 0
        '
        'colEmailTo
        '
        Me.colEmailTo.AppearanceCell.Options.UseTextOptions = True
        Me.colEmailTo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmailTo.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colEmailTo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmailTo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEmailTo.AppearanceHeader.Options.UseFont = True
        Me.colEmailTo.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmailTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmailTo.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colEmailTo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmailTo.Caption = "صادر الى"
        Me.colEmailTo.FieldName = "EmailTo"
        Me.colEmailTo.Name = "colEmailTo"
        Me.colEmailTo.Visible = True
        Me.colEmailTo.VisibleIndex = 1
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        '
        'coldeleted
        '
        Me.coldeleted.FieldName = "deleted"
        Me.coldeleted.Name = "coldeleted"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'ErrorTrace1
        '
        Me.ErrorTrace1.ActiveMethod = Nothing
        Me.ErrorTrace1.CustomBody = Nothing
        Me.ErrorTrace1.Enabled = False
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
        'EmailExportsTableAdapter
        '
        Me.EmailExportsTableAdapter.ClearBeforeFill = True
        '
        'OrgTableAdapter1
        '
        Me.OrgTableAdapter1.ClearBeforeFill = True
        '
        'OrgemailTableAdapter1
        '
        Me.OrgemailTableAdapter1.ClearBeforeFill = True
        '
        'EmailExports_TO_CCTableAdapter1
        '
        Me.EmailExports_TO_CCTableAdapter1.ClearBeforeFill = True
        '
        'EmailExports_AttachTableAdapter1
        '
        Me.EmailExports_AttachTableAdapter1.ClearBeforeFill = True
        '
        'EmailExportList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 357)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "EmailExportList"
        Me.Text = "قائمة صادر البريد الالكتروني"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.EmailExportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
    Friend WithEvents EmailExportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmailExportsTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.EmailExportsTableAdapter
    Friend WithEvents colExportId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExportNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExportDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOwner_Org_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreated_Login As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreated_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrgTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter
    Friend WithEvents OrgemailTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.orgemailTableAdapter
    Friend WithEvents EmailExports_TO_CCTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.EmailExports_TO_CCTableAdapter
    Friend WithEvents EmailExports_AttachTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.EmailExports_AttachTableAdapter
End Class
