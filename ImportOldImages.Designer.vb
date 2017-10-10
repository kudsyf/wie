<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportOldImages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportOldImages))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lstBackupFiles = New System.Windows.Forms.ListBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lstFullPath = New System.Windows.Forms.ListBox()
        Me.Import_ImageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDBFDataSet = New WinImpExp.NewDBFDataSet()
        Me.Import_ImageTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Import_ImageTableAdapter()
        Me.Export_ImageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Export_ImageTableAdapter = New WinImpExp.NewDBFDataSetTableAdapters.Export_ImageTableAdapter()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Import_ImageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Export_ImageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstBackupFiles
        '
        Me.lstBackupFiles.FormattingEnabled = True
        Me.lstBackupFiles.Location = New System.Drawing.Point(12, 64)
        Me.lstBackupFiles.Name = "lstBackupFiles"
        Me.lstBackupFiles.Size = New System.Drawing.Size(269, 316)
        Me.lstBackupFiles.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SimpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SimpleButton1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.SimpleButton1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.SimpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.SimpleButton1.Location = New System.Drawing.Point(376, 12)
        Me.SimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "اختيار مجلد الصور"
        Me.SimpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 40)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ProgressBar1.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProgressBar1.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProgressBar1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProgressBar1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProgressBar1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProgressBar1.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProgressBar1.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProgressBar1.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProgressBar1.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProgressBar1.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProgressBar1.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProgressBar1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProgressBar1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProgressBar1.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProgressBar1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProgressBar1.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar1.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProgressBar1.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProgressBar1.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProgressBar1.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProgressBar1.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProgressBar1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ProgressBar1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ProgressBar1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ProgressBar1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ProgressBar1.Properties.PercentView = False
        Me.ProgressBar1.Properties.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Horizontal
        Me.ProgressBar1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Broken
        Me.ProgressBar1.Properties.ShowTitle = True
        Me.ProgressBar1.Properties.Step = 1
        Me.ProgressBar1.Size = New System.Drawing.Size(497, 18)
        Me.ProgressBar1.TabIndex = 5
        Me.ProgressBar1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'SimpleButton2
        '
        Me.SimpleButton2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.SimpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SimpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SimpleButton2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.SimpleButton2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.SimpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.SimpleButton2.Location = New System.Drawing.Point(207, 414)
        Me.SimpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 23)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "اعادة ربط الصور"
        Me.SimpleButton2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(287, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(73, 316)
        Me.ListBox1.TabIndex = 7
        '
        'lstFullPath
        '
        Me.lstFullPath.FormattingEnabled = True
        Me.lstFullPath.Location = New System.Drawing.Point(367, 65)
        Me.lstFullPath.Name = "lstFullPath"
        Me.lstFullPath.Size = New System.Drawing.Size(142, 316)
        Me.lstFullPath.TabIndex = 8
        '
        'Import_ImageBindingSource
        '
        Me.Import_ImageBindingSource.DataMember = "Import_Image"
        Me.Import_ImageBindingSource.DataSource = Me.NewDBFDataSet
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
        'Export_ImageBindingSource
        '
        Me.Export_ImageBindingSource.DataMember = "Export_Image"
        Me.Export_ImageBindingSource.DataSource = Me.NewDBFDataSet
        '
        'Export_ImageTableAdapter
        '
        Me.Export_ImageTableAdapter.ClearBeforeFill = True
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ProgressBarControl1.Location = New System.Drawing.Point(12, 387)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ProgressBarControl1.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBarControl1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProgressBarControl1.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProgressBarControl1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProgressBarControl1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProgressBarControl1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProgressBarControl1.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBarControl1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProgressBarControl1.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProgressBarControl1.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProgressBarControl1.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProgressBarControl1.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProgressBarControl1.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBarControl1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProgressBarControl1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProgressBarControl1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProgressBarControl1.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProgressBarControl1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProgressBarControl1.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBarControl1.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProgressBarControl1.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProgressBarControl1.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProgressBarControl1.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProgressBarControl1.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProgressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ProgressBarControl1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ProgressBarControl1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ProgressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ProgressBarControl1.Properties.PercentView = False
        Me.ProgressBarControl1.Properties.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Horizontal
        Me.ProgressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Broken
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Properties.Step = 1
        Me.ProgressBarControl1.Size = New System.Drawing.Size(497, 18)
        Me.ProgressBarControl1.TabIndex = 9
        Me.ProgressBarControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
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
        'ImportOldImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 449)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.lstFullPath)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lstBackupFiles)
        Me.Name = "ImportOldImages"
        Me.Text = "ImportOldImages"
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Import_ImageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDBFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Export_ImageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lstBackupFiles As System.Windows.Forms.ListBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lstFullPath As System.Windows.Forms.ListBox
    Friend WithEvents Import_ImageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewDBFDataSet As WinImpExp.NewDBFDataSet
    Friend WithEvents Import_ImageTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Import_ImageTableAdapter
    Friend WithEvents Export_ImageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Export_ImageTableAdapter As WinImpExp.NewDBFDataSetTableAdapters.Export_ImageTableAdapter
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
End Class
