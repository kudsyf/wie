<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenDataBaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenDataBaseForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDB = New System.Windows.Forms.ComboBox()
        Me.ServerList = New System.Windows.Forms.ListBox()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.DBtxt = New DevExpress.XtraEditors.TextEdit()
        Me.Passtxt = New DevExpress.XtraEditors.TextEdit()
        Me.Usertxt = New DevExpress.XtraEditors.TextEdit()
        Me.IPtxt = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrorTrace1 = New WinImpExp.ErrorTrace(Me.components)
        Me.txtNetCode = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.DBtxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Passtxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usertxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IPtxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "أسم قاعدة البيانات"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "أسم الخادم"
        '
        'cmbDB
        '
        Me.cmbDB.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbDB.FormattingEnabled = True
        Me.cmbDB.Location = New System.Drawing.Point(7, 93)
        Me.cmbDB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDB.Name = "cmbDB"
        Me.cmbDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDB.Size = New System.Drawing.Size(253, 27)
        Me.cmbDB.TabIndex = 12
        '
        'ServerList
        '
        Me.ServerList.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ServerList.FormattingEnabled = True
        Me.ServerList.ItemHeight = 19
        Me.ServerList.Location = New System.Drawing.Point(7, 10)
        Me.ServerList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ServerList.Name = "ServerList"
        Me.ServerList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ServerList.Size = New System.Drawing.Size(253, 61)
        Me.ServerList.TabIndex = 13
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(367, 187)
        Me.XtraTabControl1.TabIndex = 14
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(361, 122)
        Me.XtraTabPage3.Text = "ربط تلقائي"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Location = New System.Drawing.Point(22, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(327, 21)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "للربط التلقائي ، الرجاء اضغط على موافق"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SimpleButton1)
        Me.XtraTabPage1.Controls.Add(Me.ServerList)
        Me.XtraTabPage1.Controls.Add(Me.cmbDB)
        Me.XtraTabPage1.Controls.Add(Me.Label1)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(361, 122)
        Me.XtraTabPage1.Tag = "1"
        Me.XtraTabPage1.Text = "خادم محلي"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(266, 57)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(71, 23)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "بحث "
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(361, 156)
        Me.XtraTabPage2.Tag = "2"
        Me.XtraTabPage2.Text = "خادم طرفي"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtNetCode)
        Me.LayoutControl1.Controls.Add(Me.DBtxt)
        Me.LayoutControl1.Controls.Add(Me.Passtxt)
        Me.LayoutControl1.Controls.Add(Me.Usertxt)
        Me.LayoutControl1.Controls.Add(Me.IPtxt)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(361, 156)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'DBtxt
        '
        Me.DBtxt.Location = New System.Drawing.Point(12, 90)
        Me.DBtxt.Name = "DBtxt"
        Me.DBtxt.Properties.Appearance.Options.UseTextOptions = True
        Me.DBtxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DBtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DBtxt.Size = New System.Drawing.Size(210, 22)
        Me.DBtxt.StyleController = Me.LayoutControl1
        Me.DBtxt.TabIndex = 7
        '
        'Passtxt
        '
        Me.Passtxt.Location = New System.Drawing.Point(12, 64)
        Me.Passtxt.Name = "Passtxt"
        Me.Passtxt.Properties.Appearance.Options.UseTextOptions = True
        Me.Passtxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.Passtxt.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Passtxt.Size = New System.Drawing.Size(210, 22)
        Me.Passtxt.StyleController = Me.LayoutControl1
        Me.Passtxt.TabIndex = 6
        '
        'Usertxt
        '
        Me.Usertxt.Location = New System.Drawing.Point(12, 38)
        Me.Usertxt.Name = "Usertxt"
        Me.Usertxt.Properties.Appearance.Options.UseTextOptions = True
        Me.Usertxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.Usertxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Usertxt.Size = New System.Drawing.Size(210, 22)
        Me.Usertxt.StyleController = Me.LayoutControl1
        Me.Usertxt.TabIndex = 5
        '
        'IPtxt
        '
        Me.IPtxt.Location = New System.Drawing.Point(12, 12)
        Me.IPtxt.Name = "IPtxt"
        Me.IPtxt.Properties.Appearance.Options.UseTextOptions = True
        Me.IPtxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.IPtxt.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong
        Me.IPtxt.Properties.Mask.BeepOnError = True
        Me.IPtxt.Properties.Mask.EditMask = resources.GetString("IPtxt.Properties.Mask.EditMask")
        Me.IPtxt.Properties.Mask.IgnoreMaskBlank = False
        Me.IPtxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.IPtxt.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.IPtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IPtxt.Size = New System.Drawing.Size(210, 22)
        Me.IPtxt.StyleController = Me.LayoutControl1
        Me.IPtxt.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(361, 156)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.Control = Me.Passtxt
        Me.LayoutControlItem3.CustomizationFormText = "كلمة المرور"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(341, 26)
        Me.LayoutControlItem3.Text = "كلمة المرور"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(123, 17)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me.Usertxt
        Me.LayoutControlItem2.CustomizationFormText = "اسم المستخدم"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(341, 26)
        Me.LayoutControlItem2.Text = "اسم المستخدم"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(123, 17)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.IPtxt
        Me.LayoutControlItem1.CustomizationFormText = "رقم الخادم"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(341, 26)
        Me.LayoutControlItem1.Text = "رقم الخادم"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(123, 17)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me.DBtxt
        Me.LayoutControlItem4.CustomizationFormText = "اسم قاعدة البيانات"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(341, 26)
        Me.LayoutControlItem4.Text = "اسم قاعدة البيانات"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(123, 17)
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(54, 216)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "موافق"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(268, 216)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 16
        Me.SimpleButton3.Text = "الغاء"
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
        'txtNetCode
        '
        Me.txtNetCode.Location = New System.Drawing.Point(12, 116)
        Me.txtNetCode.Name = "txtNetCode"
        Me.txtNetCode.Size = New System.Drawing.Size(210, 22)
        Me.txtNetCode.StyleController = Me.LayoutControl1
        Me.txtNetCode.TabIndex = 8
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.Control = Me.txtNetCode
        Me.LayoutControlItem5.CustomizationFormText = "رمز تمييز الشبكة"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(341, 32)
        Me.LayoutControlItem5.Text = "رمز تمييز الشبكة"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(123, 17)
        '
        'OpenDataBaseForm
        '
        Me.AcceptButton = Me.SimpleButton2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpenDataBaseForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فتح قاعدة بيانات"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.DBtxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Passtxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usertxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IPtxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents cmbDB As System.Windows.Forms.ComboBox
    Friend WithEvents ServerList As System.Windows.Forms.ListBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DBtxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Passtxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Usertxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IPtxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ErrorTrace1 As WinImpExp.ErrorTrace
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNetCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
