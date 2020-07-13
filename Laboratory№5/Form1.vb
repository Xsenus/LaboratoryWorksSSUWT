Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g As Double
        Dim k As Double
        g = (1 + Math.PI - Math.E ^ 2.61) / (Math.E + Math.PI ^ 2)
        k = Math.Tan((Math.PI ^ 2 + 1) / 19)
        Dim y As Double
        If g > k Then
            y = (1 - g) / (k + Math.PI)
        Else
            y = (1 + g) / (k + Math.PI)
        End If
        TextBox1.Text = Math.Round(y, 7)
        PictureBox1.Image = Global.Laboratory_5.My.Resources.Resources._1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim q As Double
        Dim a As Double
        q = Math.Sin(Math.E ^ 2)
        a = Math.Sqrt(1 - q)
        Dim y As Double
        If ((1 / q) + a) <= (Math.Sqrt((1 / ((q ^ 2) + (a ^ 2))))) Then
            y = (q ^ 2) + Math.Sqrt(q * a)
        Else
            y = (a ^ 2) + Math.Sqrt(q * a)
        End If
        TextBox2.Text = Math.Round(y, 5)
        PictureBox1.Image = Global.Laboratory_5.My.Resources.Resources._2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Double
        Dim m As Double
        n = Math.E ^ (Math.Sin(1 / 3))
        m = Math.Sqrt(n + 1)
        Dim y As Double
        If n + m <= n ^ 2 Then
            y = n - m + 3
        Else
            y = n + m - 3
        End If
        TextBox3.Text = Math.Round(y, 7)
        PictureBox1.Image = Global.Laboratory_5.My.Resources.Resources._3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x1 As Double
        Dim x2 As Double
        x1 = ((Math.E ^ 2) + (Math.E ^ 3)) * (Math.PI / 10)
        x2 = ((Math.PI ^ 2) + (Math.PI)) * (Math.E / 8)
        Dim y As Double
        If 2 * x1 <= 3 * x2 Then
            y = x1 ^ 3 + x2 ^ 2
        Else
            y = x1 ^ 2 + x2 ^ 3
        End If
        TextBox4.Text = Math.Round(y, 3)
        PictureBox1.Image = Global.Laboratory_5.My.Resources.Resources._4
    End Sub

    Private Sub ОбАвтореToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбАвтореToolStripMenuItem.Click
        MsgBox("Лабораторную работу" + Chr(13) + Chr(10) + "выполнил студент" + Chr(13) + Chr(10) + "Тарасов Илья", vbInformation + vbOKOnly, "Сообщение об авторе")
    End Sub

    Private Sub СбросToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СбросToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        PictureBox1.Image = Nothing
    End Sub
End Class
