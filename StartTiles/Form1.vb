Imports MaterialSkin
Imports System.IO
Imports System.Environment
Public Class Form1
    '提取ico函数
    Declare Function ExtractIcon Lib "shell32.dll" Alias "ExtractIconExA" (ByVal lpszFile As String, ByVal nIconIndex As Integer, ByRef phiconLarge As Integer, ByRef phiconSmall As Integer, ByVal nIcons As Integer) As Integer
    Private Function ReturnIcon(ByVal Path As String, ByVal Index As Integer, Optional ByVal small As Boolean = False) As Icon
        Dim bigIcon As Integer
        Dim smallIcon As Integer
        ExtractIcon(Path, Index, bigIcon, smallIcon, 1)
        If bigIcon = 0 Then
            ExtractIcon(Path, 0, bigIcon, smallIcon, 1)
        End If
        If bigIcon <> 0 Then
            If small = False Then
                Return Icon.FromHandle(bigIcon)
            Else
                Return Icon.FromHandle(smallIcon)
            End If
        Else
            Return Nothing
        End If
    End Function
    'OpenFileDialog父目录
    Function GetDirPath(ByVal file As String) As String
        Dim fi As New FileInfo(file)
        Return fi.Directory.ToString
    End Function
    Dim iconCenterColor As Color
    Dim iconCornerColor As Color

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MaterialSkin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Timer1.Enabled = True '停一秒说明这里是路径
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PathText.Text = "C:\Windows\explorer.exe"
        PreviewImage.Image = ReturnIcon(PathText.Text, 0).ToBitmap
        Timer1.Enabled = False
    End Sub
    Private Sub PathText_Click(sender As Object, e As EventArgs) Handles PathText.Click
        PathSelect.ShowDialog()
        PathText.Text = PathSelect.FileName
        PreviewImage.Image = ReturnIcon(PathText.Text, 0).ToBitmap
        TabControl.SelectedTab = TabPage2
        TabSelector.Enabled = True
    End Sub
    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        '中心像素颜色
        iconCenterColor = CType(PreviewImage.Image, Bitmap).GetPixel(PreviewImage.Image.Width.ToString / 2, PreviewImage.Image.Height.ToString / 2)
        iconCenterColorRGBText.Text = "RGB(" + iconCenterColor.R.ToString + "," + iconCenterColor.G.ToString + "," + iconCenterColor.B.ToString + ")"
        iconCenterColorHEXText.Text = "#" + String.Format("{0}{1}{2}", iconCenterColor.R.ToString("X").PadLeft(2, "0"), iconCenterColor.G.ToString("X").PadLeft(2, "0"), iconCenterColor.B.ToString("X").PadLeft(2, "0"))
        PreviewImage.BackColor = iconCenterColor


        '角落像素颜色
        Dim ColorPointX As Integer = 1
        Dim ColorPointY As Integer = 1
        Dim times As Integer = 0
        iconCornerColor = CType(PreviewImage.Image, Bitmap).GetPixel(ColorPointX, ColorPointY)
        IconCornerColorRGBText.Text = "RGB(" + iconCornerColor.R.ToString + "," + iconCornerColor.G.ToString + "," + iconCornerColor.B.ToString + ")"
        '如果1,1是透明
        Do While iconCornerColor.ToString = "Color [A=0, R=0, G=0, B=0]"
            If ColorPointX <= 16 Then
                ColorPointX = ColorPointX + 1
            Else
                If ColorPointY <= 16 Then
                    ColorPointY = ColorPointY + 1
                Else
                    If ColorPointX And ColorPointY = 16 Then
                        MsgBox("No Icon")
                    End If
                End If
            End If
            iconCornerColor = CType(PreviewImage.Image, Bitmap).GetPixel(ColorPointX, ColorPointY)
            IconCornerColorRGBText.Text = "RGB(" + iconCornerColor.R.ToString + "," + iconCornerColor.G.ToString + "," + iconCornerColor.B.ToString + ")"
        Loop
        IconCornerColorHEXText.Text = "#" + String.Format("{0}{1}{2}", iconCornerColor.R.ToString("X").PadLeft(2, "0"), iconCornerColor.G.ToString("X").PadLeft(2, "0"), iconCornerColor.B.ToString("X").PadLeft(2, "0"))

    End Sub

    Private Sub PickRadio_CheckedChanged(sender As Object, e As EventArgs) Handles PickRadio.CheckedChanged
        If PickRadio.Checked = True Then
            ColorDialog1.ShowDialog()
            PreviewImage.BackColor = ColorDialog1.Color
            PickColorRGBText.Text = "RGB(" + ColorDialog1.Color.R.ToString + "," + ColorDialog1.Color.G.ToString + "," + ColorDialog1.Color.B.ToString + ")"
            PickColorHEXText.Text = "#" + String.Format("{0}{1}{2}", ColorDialog1.Color.R.ToString("X").PadLeft(2, "0"), ColorDialog1.Color.G.ToString("X").PadLeft(2, "0"), ColorDialog1.Color.B.ToString("X").PadLeft(2, "0"))
        End If
    End Sub

    Private Sub CornerRadio_CheckedChanged(sender As Object, e As EventArgs) Handles CornerRadio.CheckedChanged
        If CornerRadio.Checked = True Then
            IconCornerColorHEXText.Visible = True
            IconCornerColorRGBText.Visible = True
            PreviewImage.BackColor = iconCornerColor
        End If
    End Sub
    Private Sub CenterRadio_CheckedChanged(sender As Object, e As EventArgs) Handles CenterRadio.CheckedChanged
        If CenterRadio.Checked = True Then
            PreviewImage.BackColor = iconCenterColor
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Editxml.Visible = True
    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        TabSelector.Enabled = False
        '替换xml字符
        If CenterRadio.Checked = True Then
            Editxml.RichTextBox1.Text = Editxml.RichTextBox1.Text.Replace("$color$", IconCenterColorHEXText.Text)
        End If
        If PickRadio.Checked = True Then
            Editxml.RichTextBox1.Text = Editxml.RichTextBox1.Text.Replace("$color$", PickColorHEXText.Text)
        End If
        If CornerRadio.Checked = True Then
            Editxml.RichTextBox1.Text = Editxml.RichTextBox1.Text.Replace("$color$", IconCornerColorHEXText.Text)
        End If
        If IFShowName.Enabled = True Then
            Editxml.RichTextBox1.Text = Editxml.RichTextBox1.Text.Replace("$ifshowname$", "on")
        Else
            Editxml.RichTextBox1.Text = Editxml.RichTextBox1.Text.Replace("$ifshowname$", "off")
        End If
    End Sub

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click
        '加载一下窗体
        Editxml.Show()
        Editxml.Visible = False

        '各种路径然后保存
        Dim savepath As String = GetDirPath(PathText.Text)
        Dim programnameexe As String = System.IO.Path.GetFileName(PathText.Text)
        Dim programname As String = Replace(programnameexe, ".exe", "")

        '总有人不用管理员运行往C盘塞东西
        Try
            Editxml.RichTextBox1.SaveFile(savepath & "\" & programname & ".VisualElementsManifest.xml", RichTextBoxStreamType.PlainText)
            MsgBox("Done!Right Click the Program and select 'pin To start'")
            Shell("Explorer.exe " & savepath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class

