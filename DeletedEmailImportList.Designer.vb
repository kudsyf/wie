<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletedEmailImportList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletedEmailImportList))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailImportsBindingSource = New System.Windows.Forms.BindingSource()
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colImportId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImportNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImportDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOwner_Org_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreated_Login = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreated_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmailImportsTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.EmailImportsTableAdapter()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace()
        Me.EmailImports_AttachTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.EmailImports_AttachTableAdapter()
        Me.EmailImports_TO_CCTableAdapter1 = New WinImpExp.NewDBFDataSetTableAdapters.EmailImports_TO_CCTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.EmailImportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.DataSource = Me.EmailImportsBindingSource
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem22})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem1.Text = "حذف قيد وارد"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem22.Text = "استرجاع قيد وارد"
        '
        'EmailImportsBindingSource
        '
        Me.EmailImportsBindingSource.DataMember = "EmailImports"
        Me.EmailImportsBindingSource.DataSource = Me.NewDBFDataSet
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colImportId, Me.colImportNo, Me.colImportDate, Me.colOwner_Org_No, Me.colCreated_Login, Me.colCreated_Date, Me.colEmailSubject, Me.colEmailFrom, Me.colEmail, Me.coldeleted, Me.colUID, Me.colEmailDate})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "اختيار العمود لغرض التجميع"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.SmartDetailExpand = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        '
        'colImportId
        '
        Me.colImportId.FieldName = "ImportId"
        Me.colImportId.Name = "colImportId"
        '
        'colImportNo
        '
        Me.colImportNo.AppearanceCell.Options.UseTextOptions = True
        Me.colImportNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImportNo.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImportNo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImportNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colImportNo.AppearanceHeader.Options.UseFont = True
        Me.colImportNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colImportNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImportNo.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImportNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImportNo.Caption = "رقم الوارد"
        Me.colImportNo.FieldName = "ImportNo"
        Me.colImportNo.Name = "colImportNo"
        Me.colImportNo.Visible = True
        Me.colImportNo.VisibleIndex = 4
        '
        'colImportDate
        '
        Me.colImportDate.AppearanceCell.Options.UseTextOptions = True
        Me.colImportDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImportDate.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImportDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImportDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colImportDate.AppearanceHeader.Options.UseFont = True
        Me.colImportDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colImportDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImportDate.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colImportDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colImportDate.Caption = "تاريخ الوارد"
        Me.colImportDate.FieldName = "ImportDate"
        Me.colImportDate.Name = "colImportDate"
        Me.colImportDate.Visible = True
        Me.colImportDate.VisibleIndex = 3
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
        'colEmailFrom
        '
        Me.colEmailFrom.AppearanceCell.Options.UseTextOptions = True
        Me.colEmailFrom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmailFrom.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colEmailFrom.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmailFrom.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEmailFrom.AppearanceHeader.Options.UseFont = True
        Me.colEmailFrom.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmailFrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmailFrom.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colEmailFrom.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmailFrom.Caption = "بريد وارد من"
        Me.colEmailFrom.FieldName = "EmailFrom"
        Me.colEmailFrom.Name = "colEmailFrom"
        Me.colEmailFrom.Visible = True
        Me.colEmailFrom.VisibleIndex = 2
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
        'colUID
        '
        Me.colUID.FieldName = "UID"
        Me.colUID.Name = "colUID"
        '
        'colEmailDate
        '
        Me.colEmailDate.AppearanceCell.Options.UseTextOptions = True
        Me.colEmailDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmailDate.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colEmailDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmailDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEmailDate.AppearanceHeader.Options.UseFont = True
        Me.colEmailDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmailDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmailDate.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colEmailDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmailDate.Caption = "تاريخ البريد"
        Me.colEmailDate.FieldName = "EmailDate"
        Me.colEmailDate.Name = "colEmailDate"
        Me.colEmailDate.Visible = True
        Me.colEmailDate.VisibleIndex = 1
        '
        'EmailImportsTableAdapter
        '
        Me.EmailImportsTableAdapter.ClearBeforeFill = True
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
        'EmailImports_AttachTableAdapter1
        '
        Me.EmailImports_AttachTableAdapter1.ClearBeforeFill = True
        '
        'EmailImports_TO_CCTableAdapter1
        '
        Me.EmailImports_TO_CCTableAdapter1.ClearBeforeFill = True
        '
        'DeletedEmailImportList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 357)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "DeletedEmailImportList"
        Me.Text = "سلة محذوفات  وارد البريد الالكتروني"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.EmailImportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colImportId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOwner_Org_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreated_Login As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreated_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents EmailImportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmailImportsTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.EmailImportsTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
    Friend WithEvents colEmailDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmailImports_AttachTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.EmailImports_AttachTableAdapter
    Friend WithEvents EmailImports_TO_CCTableAdapter1 As WinImpExp.NewDBFDataSetTableAdapters.EmailImports_TO_CCTableAdapter
    Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
End Class
