<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PathText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.IFShowName = New MaterialSkin.Controls.MaterialCheckBox()
        Me.PickColorHEXText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PickColorRGBText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.IconCenterColorHEXText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PickRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.CenterRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.IconCenterColorRGBText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.IconCornerColorHEXText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.IconCornerColorRGBText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.CornerRadio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Generate = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PreviewImage = New System.Windows.Forms.PictureBox()
        Me.TabSelector = New MaterialSkin.Controls.MaterialTabSelector()
        Me.PathSelect = New System.Windows.Forms.OpenFileDialog()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PreviewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Depth = 0
        Me.TabControl.Location = New System.Drawing.Point(3, 110)
        Me.TabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(384, 169)
        Me.TabControl.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.PathText)
        Me.TabPage1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 143)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1.Open .exe File"
        '
        'PathText
        '
        Me.PathText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PathText.Depth = 0
        Me.PathText.Hint = "Click to Select Path..."
        Me.PathText.Location = New System.Drawing.Point(32, 50)
        Me.PathText.MaxLength = 32767
        Me.PathText.MouseState = MaterialSkin.MouseState.HOVER
        Me.PathText.Name = "PathText"
        Me.PathText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PathText.SelectedText = ""
        Me.PathText.SelectionLength = 0
        Me.PathText.SelectionStart = 0
        Me.PathText.Size = New System.Drawing.Size(303, 23)
        Me.PathText.TabIndex = 12
        Me.PathText.TabStop = False
        Me.PathText.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.IFShowName)
        Me.TabPage2.Controls.Add(Me.PickColorHEXText)
        Me.TabPage2.Controls.Add(Me.PickColorRGBText)
        Me.TabPage2.Controls.Add(Me.IconCenterColorHEXText)
        Me.TabPage2.Controls.Add(Me.PickRadio)
        Me.TabPage2.Controls.Add(Me.CenterRadio)
        Me.TabPage2.Controls.Add(Me.IconCenterColorRGBText)
        Me.TabPage2.Controls.Add(Me.IconCornerColorHEXText)
        Me.TabPage2.Controls.Add(Me.IconCornerColorRGBText)
        Me.TabPage2.Controls.Add(Me.CornerRadio)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 143)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2.Pick a color"
        '
        'IFShowName
        '
        Me.IFShowName.AutoSize = True
        Me.IFShowName.Checked = True
        Me.IFShowName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IFShowName.Depth = 0
        Me.IFShowName.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.IFShowName.Location = New System.Drawing.Point(100, 96)
        Me.IFShowName.Margin = New System.Windows.Forms.Padding(0)
        Me.IFShowName.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.IFShowName.MouseState = MaterialSkin.MouseState.HOVER
        Me.IFShowName.Name = "IFShowName"
        Me.IFShowName.Ripple = True
        Me.IFShowName.Size = New System.Drawing.Size(158, 30)
        Me.IFShowName.TabIndex = 13
        Me.IFShowName.Text = "Display name on Tile"
        Me.IFShowName.UseVisualStyleBackColor = True
        '
        'PickColorHEXText
        '
        Me.PickColorHEXText.Depth = 0
        Me.PickColorHEXText.Enabled = False
        Me.PickColorHEXText.Hint = ""
        Me.PickColorHEXText.Location = New System.Drawing.Point(310, 40)
        Me.PickColorHEXText.MaxLength = 32767
        Me.PickColorHEXText.MouseState = MaterialSkin.MouseState.HOVER
        Me.PickColorHEXText.Name = "PickColorHEXText"
        Me.PickColorHEXText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PickColorHEXText.SelectedText = ""
        Me.PickColorHEXText.SelectionLength = 0
        Me.PickColorHEXText.SelectionStart = 0
        Me.PickColorHEXText.Size = New System.Drawing.Size(60, 23)
        Me.PickColorHEXText.TabIndex = 10
        Me.PickColorHEXText.TabStop = False
        Me.PickColorHEXText.UseSystemPasswordChar = False
        '
        'PickColorRGBText
        '
        Me.PickColorRGBText.Depth = 0
        Me.PickColorRGBText.Enabled = False
        Me.PickColorRGBText.Hint = ""
        Me.PickColorRGBText.Location = New System.Drawing.Point(185, 40)
        Me.PickColorRGBText.MaxLength = 32767
        Me.PickColorRGBText.MouseState = MaterialSkin.MouseState.HOVER
        Me.PickColorRGBText.Name = "PickColorRGBText"
        Me.PickColorRGBText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PickColorRGBText.SelectedText = ""
        Me.PickColorRGBText.SelectionLength = 0
        Me.PickColorRGBText.SelectionStart = 0
        Me.PickColorRGBText.Size = New System.Drawing.Size(119, 23)
        Me.PickColorRGBText.TabIndex = 9
        Me.PickColorRGBText.TabStop = False
        Me.PickColorRGBText.UseSystemPasswordChar = False
        '
        'IconCenterColorHEXText
        '
        Me.IconCenterColorHEXText.Depth = 0
        Me.IconCenterColorHEXText.Enabled = False
        Me.IconCenterColorHEXText.Hint = ""
        Me.IconCenterColorHEXText.Location = New System.Drawing.Point(310, 11)
        Me.IconCenterColorHEXText.MaxLength = 32767
        Me.IconCenterColorHEXText.MouseState = MaterialSkin.MouseState.HOVER
        Me.IconCenterColorHEXText.Name = "IconCenterColorHEXText"
        Me.IconCenterColorHEXText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IconCenterColorHEXText.SelectedText = ""
        Me.IconCenterColorHEXText.SelectionLength = 0
        Me.IconCenterColorHEXText.SelectionStart = 0
        Me.IconCenterColorHEXText.Size = New System.Drawing.Size(60, 23)
        Me.IconCenterColorHEXText.TabIndex = 8
        Me.IconCenterColorHEXText.TabStop = False
        Me.IconCenterColorHEXText.UseSystemPasswordChar = False
        '
        'PickRadio
        '
        Me.PickRadio.AutoSize = True
        Me.PickRadio.Depth = 0
        Me.PickRadio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.PickRadio.Location = New System.Drawing.Point(0, 36)
        Me.PickRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.PickRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.PickRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.PickRadio.Name = "PickRadio"
        Me.PickRadio.Ripple = True
        Me.PickRadio.Size = New System.Drawing.Size(160, 30)
        Me.PickRadio.TabIndex = 7
        Me.PickRadio.Text = "Pick a Theme Color..."
        Me.PickRadio.UseVisualStyleBackColor = True
        '
        'CenterRadio
        '
        Me.CenterRadio.AutoSize = True
        Me.CenterRadio.Checked = True
        Me.CenterRadio.Depth = 0
        Me.CenterRadio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.CenterRadio.Location = New System.Drawing.Point(0, 6)
        Me.CenterRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.CenterRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CenterRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.CenterRadio.Name = "CenterRadio"
        Me.CenterRadio.Ripple = True
        Me.CenterRadio.Size = New System.Drawing.Size(177, 30)
        Me.CenterRadio.TabIndex = 2
        Me.CenterRadio.TabStop = True
        Me.CenterRadio.Text = "Use Icon Centeral Color:"
        Me.CenterRadio.UseVisualStyleBackColor = True
        '
        'IconCenterColorRGBText
        '
        Me.IconCenterColorRGBText.Depth = 0
        Me.IconCenterColorRGBText.Enabled = False
        Me.IconCenterColorRGBText.Hint = ""
        Me.IconCenterColorRGBText.Location = New System.Drawing.Point(185, 11)
        Me.IconCenterColorRGBText.MaxLength = 32767
        Me.IconCenterColorRGBText.MouseState = MaterialSkin.MouseState.HOVER
        Me.IconCenterColorRGBText.Name = "IconCenterColorRGBText"
        Me.IconCenterColorRGBText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IconCenterColorRGBText.SelectedText = ""
        Me.IconCenterColorRGBText.SelectionLength = 0
        Me.IconCenterColorRGBText.SelectionStart = 0
        Me.IconCenterColorRGBText.Size = New System.Drawing.Size(119, 23)
        Me.IconCenterColorRGBText.TabIndex = 1
        Me.IconCenterColorRGBText.TabStop = False
        Me.IconCenterColorRGBText.UseSystemPasswordChar = False
        '
        'IconCornerColorHEXText
        '
        Me.IconCornerColorHEXText.Depth = 0
        Me.IconCornerColorHEXText.Hint = ""
        Me.IconCornerColorHEXText.Location = New System.Drawing.Point(310, 69)
        Me.IconCornerColorHEXText.MaxLength = 32767
        Me.IconCornerColorHEXText.MouseState = MaterialSkin.MouseState.HOVER
        Me.IconCornerColorHEXText.Name = "IconCornerColorHEXText"
        Me.IconCornerColorHEXText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IconCornerColorHEXText.SelectedText = ""
        Me.IconCornerColorHEXText.SelectionLength = 0
        Me.IconCornerColorHEXText.SelectionStart = 0
        Me.IconCornerColorHEXText.Size = New System.Drawing.Size(60, 23)
        Me.IconCornerColorHEXText.TabIndex = 12
        Me.IconCornerColorHEXText.TabStop = False
        Me.IconCornerColorHEXText.UseSystemPasswordChar = False
        Me.IconCornerColorHEXText.Visible = False
        '
        'IconCornerColorRGBText
        '
        Me.IconCornerColorRGBText.Depth = 0
        Me.IconCornerColorRGBText.Hint = ""
        Me.IconCornerColorRGBText.Location = New System.Drawing.Point(185, 69)
        Me.IconCornerColorRGBText.MaxLength = 32767
        Me.IconCornerColorRGBText.MouseState = MaterialSkin.MouseState.HOVER
        Me.IconCornerColorRGBText.Name = "IconCornerColorRGBText"
        Me.IconCornerColorRGBText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IconCornerColorRGBText.SelectedText = ""
        Me.IconCornerColorRGBText.SelectionLength = 0
        Me.IconCornerColorRGBText.SelectionStart = 0
        Me.IconCornerColorRGBText.Size = New System.Drawing.Size(119, 23)
        Me.IconCornerColorRGBText.TabIndex = 11
        Me.IconCornerColorRGBText.TabStop = False
        Me.IconCornerColorRGBText.UseSystemPasswordChar = False
        Me.IconCornerColorRGBText.Visible = False
        '
        'CornerRadio
        '
        Me.CornerRadio.AutoSize = True
        Me.CornerRadio.Depth = 0
        Me.CornerRadio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.CornerRadio.Location = New System.Drawing.Point(0, 66)
        Me.CornerRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.CornerRadio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CornerRadio.MouseState = MaterialSkin.MouseState.HOVER
        Me.CornerRadio.Name = "CornerRadio"
        Me.CornerRadio.Ripple = True
        Me.CornerRadio.Size = New System.Drawing.Size(166, 30)
        Me.CornerRadio.TabIndex = 5
        Me.CornerRadio.Text = "Use Icon's Edge Color:"
        Me.CornerRadio.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.MaterialFlatButton1)
        Me.TabPage3.Controls.Add(Me.Generate)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(376, 143)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "3.generate"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(130, 84)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(104, 36)
        Me.MaterialFlatButton1.TabIndex = 2
        Me.MaterialFlatButton1.Text = "show xml..."
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'Generate
        '
        Me.Generate.AutoSize = True
        Me.Generate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Generate.Depth = 0
        Me.Generate.Icon = Nothing
        Me.Generate.Location = New System.Drawing.Point(107, 39)
        Me.Generate.MouseState = MaterialSkin.MouseState.HOVER
        Me.Generate.Name = "Generate"
        Me.Generate.Primary = True
        Me.Generate.Size = New System.Drawing.Size(152, 36)
        Me.Generate.TabIndex = 1
        Me.Generate.Text = "Click to GENERATE"
        Me.Generate.UseVisualStyleBackColor = True
        '
        'PreviewImage
        '
        Me.PreviewImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PreviewImage.Location = New System.Drawing.Point(390, 131)
        Me.PreviewImage.Name = "PreviewImage"
        Me.PreviewImage.Size = New System.Drawing.Size(100, 100)
        Me.PreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PreviewImage.TabIndex = 10
        Me.PreviewImage.TabStop = False
        '
        'TabSelector
        '
        Me.TabSelector.BaseTabControl = Me.TabControl
        Me.TabSelector.Depth = 0
        Me.TabSelector.Enabled = False
        Me.TabSelector.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabSelector.Location = New System.Drawing.Point(0, 63)
        Me.TabSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabSelector.Name = "TabSelector"
        Me.TabSelector.Size = New System.Drawing.Size(672, 40)
        Me.TabSelector.TabIndex = 6
        Me.TabSelector.Text = "MaterialTabSelector1"
        '
        'PathSelect
        '
        Me.PathSelect.FileName = "C:\Windows\explorer.exe"
        Me.PathSelect.Filter = ".exe|*.exe"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(386, 106)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel1.TabIndex = 11
        Me.MaterialLabel1.Text = "Preview:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 262)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.TabSelector)
        Me.Controls.Add(Me.PreviewImage)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartTiles"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PreviewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PathText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PreviewImage As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabSelector As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents PathSelect As OpenFileDialog
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IconCenterColorRGBText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents CenterRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PickRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents CornerRadio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents IconCenterColorHEXText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PickColorHEXText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PickColorRGBText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents IconCornerColorHEXText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents IconCornerColorRGBText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Generate As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents IFShowName As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Timer1 As Timer
End Class
