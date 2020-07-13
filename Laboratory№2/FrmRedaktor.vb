Public Class FrmRedaktor

    Private formHeight As Double
    Private formWitdh As Double

    Private defaultFont As Font
    Private Sub FrmRedaktor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        defaultFont = txtStroka.Font
    End Sub
    Private Sub ОбАвтореToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбАвтореToolStripMenuItem.Click
        MsgBox("Лабораторную работу" + Chr(13) + Chr(10) + "выполнил студент Тарасов Илья", vbInformation + vbOKOnly, "Сообщение об Авторе")
    End Sub

    Private Sub ВысотаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВысотаToolStripMenuItem.Click
        formHeight = Val(InputBox("Задайте высоту формы", "Изменение высоты формы"))
        Height = formHeight
    End Sub

    Private Sub ШиринаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ШиринаToolStripMenuItem.Click
        formWitdh = Val(InputBox("Задайте высоту формы", "Изменение высоты формы"))
        Width = formWitdh
    End Sub

    Private Sub БирюзовыйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles БирюзовыйToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.Azure
        BackColor = myRgbColor
    End Sub

    Private Sub СерыйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СерыйToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.Gray
        BackColor = myRgbColor
    End Sub

    Private Sub СиреневыйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СиреневыйToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.LightPink
        BackColor = myRgbColor
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub КрасныйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КрасныйToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.Red
        txtStroka.ForeColor = myRgbColor
    End Sub

    Private Sub ЧерныйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЧерныйToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.Black
        txtStroka.ForeColor = myRgbColor
    End Sub

    Private Sub СинийToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СинийToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.Blue
        txtStroka.ForeColor = myRgbColor
    End Sub

    Private Sub БелыйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles БелыйToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.White
        txtStroka.BackColor = myRgbColor
    End Sub

    Private Sub ЗеленыйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗеленыйToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.Green
        txtStroka.BackColor = myRgbColor
    End Sub

    Private Sub ЖелтыйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЖелтыйToolStripMenuItem.Click
        Dim myRgbColor As Color
        myRgbColor = Color.Yellow
        txtStroka.BackColor = myRgbColor
    End Sub

    Private Sub OptLeft_CheckedChanged(sender As Object, e As EventArgs) Handles OptLeft.CheckedChanged
        txtStroka.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub OptCenter_CheckedChanged(sender As Object, e As EventArgs) Handles OptCenter.CheckedChanged
        txtStroka.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub OptRight_CheckedChanged(sender As Object, e As EventArgs) Handles OptRight.CheckedChanged
        txtStroka.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub СhBold_CheckedChanged(sender As Object, e As EventArgs) Handles СhBold.CheckedChanged
        If СhBold.Checked Then
            txtStroka.Font = CreateFont(txtStroka.Font.Name, txtStroka.Font.Size, True, txtStroka.Font.Italic, txtStroka.Font.Underline)
        Else
            txtStroka.Font = CreateFont(txtStroka.Font.Name, txtStroka.Font.Size, False, txtStroka.Font.Italic, txtStroka.Font.Underline)
        End If
    End Sub

    Private Sub ChItalic_CheckedChanged(sender As Object, e As EventArgs) Handles ChItalic.CheckedChanged
        If ChItalic.Checked Then
            txtStroka.Font = CreateFont(txtStroka.Font.Name, txtStroka.Font.Size, txtStroka.Font.Bold, True, txtStroka.Font.Underline)
        Else
            txtStroka.Font = CreateFont(txtStroka.Font.Name, txtStroka.Font.Size, txtStroka.Font.Bold, False, txtStroka.Font.Underline)
        End If
    End Sub

    Private Sub ChUnderline_CheckedChanged(sender As Object, e As EventArgs) Handles ChUnderline.CheckedChanged
        If ChUnderline.Checked Then
            txtStroka.Font = CreateFont(txtStroka.Font.Name, txtStroka.Font.Size, txtStroka.Font.Bold, txtStroka.Font.Italic, True)
        Else
            txtStroka.Font = CreateFont(txtStroka.Font.Name, txtStroka.Font.Size, txtStroka.Font.Bold, txtStroka.Font.Italic, False)
        End If
    End Sub

    Private Sub ДоступноИзменениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДоступноИзменениеToolStripMenuItem.Click
        frmFront.Visible = True
    End Sub

    Private Sub НедоступноToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НедоступноToolStripMenuItem.Click
        frmFront.Visible = False
    End Sub

    Private Sub ДоступноИзменениеToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДоступноИзменениеToolStripMenuItem1.Click
        frmAlignment.Visible = True
    End Sub

    Private Sub НедоступноToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles НедоступноToolStripMenuItem1.Click
        frmAlignment.Visible = False
    End Sub

    Public Function CreateFont(ByVal fontName As String,
                           ByVal fontSize As Integer,
                           ByVal isBold As Boolean,
                           ByVal isItalic As Boolean,
                           ByVal isUnderline As Boolean) As Drawing.Font

        Dim styles As FontStyle = FontStyle.Regular

        If (isBold) Then
            styles = styles Or FontStyle.Bold
        End If

        If (isItalic) Then
            styles = styles Or FontStyle.Italic
        End If

        If (isUnderline) Then
            styles = styles Or FontStyle.Underline
        End If

        Dim newFont As New Drawing.Font(fontName, fontSize, styles)
        Return newFont

    End Function

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        txtStroka.Font = CreateFont(txtStroka.Font.Name, 10, txtStroka.Font.Bold, txtStroka.Font.Italic, txtStroka.Font.Underline)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        txtStroka.Font = CreateFont(txtStroka.Font.Name, 14, txtStroka.Font.Bold, txtStroka.Font.Italic, txtStroka.Font.Underline)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        txtStroka.Font = CreateFont(txtStroka.Font.Name, 16, txtStroka.Font.Bold, txtStroka.Font.Italic, txtStroka.Font.Underline)
    End Sub

    Private Sub СбросToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СбросToolStripMenuItem.Click
        СhBold.Checked = False
        ChItalic.Checked = False
        ChUnderline.Checked = False
        txtStroka.Font = CreateFont(defaultFont.Name, defaultFont.Size, False, False, False)
    End Sub
End Class
