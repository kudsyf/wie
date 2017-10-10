<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FollowupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FollowupForm))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.ImageList1 = New System.Windows.Forms.ImageList()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ImportDocBindingSource = New System.Windows.Forms.BindingSource()
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.ImportDocTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ImportDocTableAdapter()
        Me.OrgBindingSource = New System.Windows.Forms.BindingSource()
        Me.OrgTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter()
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource()
        Me.TypeTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter()
        Me.SecurityBindingSource = New System.Windows.Forms.BindingSource()
        Me.SecurityTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter()
        Me.Fill_ITableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Fill_ITableAdapter()
        Me.Fill_ETableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Fill_ETableAdapter()
        Me.Import_ActionTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Import_ActionTableAdapter()
        Me.ActionsTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.ActionsTableAdapter()
        Me.ImportDenoteExportedBindingSource = New System.Windows.Forms.BindingSource()
        Me.Import_DenoteExportedTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Import_DenoteExportedTableAdapter()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDenoteExportedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton4)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.TreeList1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(682, 523)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(327, 22)
        Me.SimpleButton4.StyleController = Me.LayoutControl1
        Me.SimpleButton4.TabIndex = 10
        Me.SimpleButton4.Text = "طباعة"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(343, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(161, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "غلق الكل"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(508, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(162, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "استعراض الكل"
        '
        'TreeList1
        '
        Me.TreeList1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeList1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeList1.ColumnsImageList = Me.ImageList1
        Me.TreeList1.Location = New System.Drawing.Point(12, 38)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsBehavior.Editable = False
        Me.TreeList1.OptionsBehavior.ImmediateEditor = False
        Me.TreeList1.OptionsView.ShowColumns = False
        Me.TreeList1.OptionsView.ShowHorzLines = False
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowVertLines = False
        Me.TreeList1.Size = New System.Drawing.Size(658, 473)
        Me.TreeList1.StateImageList = Me.ImageList1
        Me.TreeList1.TabIndex = 6
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add-to-basket.ico")
        Me.ImageList1.Images.SetKeyName(1, "app.ico")
        Me.ImageList1.Images.SetKeyName(2, "delete-from-basket.ico")
        Me.ImageList1.Images.SetKeyName(3, "file-export.ico")
        Me.ImageList1.Images.SetKeyName(4, "file-import.ico")
        Me.ImageList1.Images.SetKeyName(5, "graffle.ico")
        Me.ImageList1.Images.SetKeyName(6, "find.ico")
        Me.ImageList1.Images.SetKeyName(7, "red-flag.ico")
        Me.ImageList1.Images.SetKeyName(8, "on.ico")
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(682, 523)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TreeList1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(662, 477)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SimpleButton2
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(496, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(166, 26)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton3
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(331, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(165, 26)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton4
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(331, 26)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'ImportDocBindingSource
        '
        Me.ImportDocBindingSource.DataMember = "ImportDoc"
        Me.ImportDocBindingSource.DataSource = Me.NewDBFDataSet
        '
        'NewDBFDataSet
        '
        Me.NewDBFDataSet.DataSetName = "NewDBFDataSet"
        Me.NewDBFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImportDocTableAdapter
        '
        Me.ImportDocTableAdapter.ClearBeforeFill = True
        '
        'OrgBindingSource
        '
        Me.OrgBindingSource.DataMember = "Org"
        Me.OrgBindingSource.DataSource = Me.NewDBFDataSet
        '
        'OrgTableAdapter
        '
        Me.OrgTableAdapter.ClearBeforeFill = True
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.NewDBFDataSet
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'SecurityBindingSource
        '
        Me.SecurityBindingSource.DataMember = "Security"
        Me.SecurityBindingSource.DataSource = Me.NewDBFDataSet
        '
        'SecurityTableAdapter
        '
        Me.SecurityTableAdapter.ClearBeforeFill = True
        '
        'Fill_ITableAdapter
        '
        Me.Fill_ITableAdapter.ClearBeforeFill = True
        '
        'Fill_ETableAdapter
        '
        Me.Fill_ETableAdapter.ClearBeforeFill = True
        '
        'Import_ActionTableAdapter
        '
        Me.Import_ActionTableAdapter.ClearBeforeFill = True
        '
        'ActionsTableAdapter
        '
        Me.ActionsTableAdapter.ClearBeforeFill = True
        '
        'ImportDenoteExportedBindingSource
        '
        Me.ImportDenoteExportedBindingSource.DataMember = "Import_DenoteExported"
        Me.ImportDenoteExportedBindingSource.DataSource = Me.NewDBFDataSet
        '
        'Import_DenoteExportedTableAdapter
        '
        Me.Import_DenoteExportedTableAdapter.ClearBeforeFill = True
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
        'FollowupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 523)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FollowupForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "متابعة الوارد"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDenoteExportedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ImportDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents ImportDocTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ImportDocTableAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents OrgBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrgTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.OrgTableAdapter
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents SecurityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SecurityTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.SecurityTableAdapter
    Friend WithEvents Fill_ITableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Fill_ITableAdapter
    Friend WithEvents Fill_ETableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Fill_ETableAdapter
    Friend WithEvents Import_ActionTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Import_ActionTableAdapter
    Friend WithEvents ActionsTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.ActionsTableAdapter
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImportDenoteExportedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Import_DenoteExportedTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Import_DenoteExportedTableAdapter
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
End Class
