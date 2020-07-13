Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim w As Double = -9.86
        Dim b As Double = 1.57
        Dim y As Double
        Dim a As Double
        TextBox1.Text += $"{Environment.NewLine}w{vbTab}{vbTab}a{vbTab}{vbTab}y{Environment.NewLine}"
        For w = -9.86 To -12.86 Step -1
            a = Math.Round(Math.Sin(w / 6), 5)
            y = Math.Round((a - Math.Cos(w / 6)) / (b + (2 * a)), 5)
            TextBox1.Text += $"{w}{vbTab}{vbTab}{a}{vbTab}{vbTab}{y}{Environment.NewLine}"
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim y As Double
        Dim b As Double = 6.25
        Dim x1 As Double
        Dim x2 As Double
        TextBox1.Text += $"{Environment.NewLine}y{vbTab}{vbTab}x1{vbTab}{vbTab}x2{Environment.NewLine}"
        For i = 0 To 4 Step 2
            y = 10 ^ i
            x1 = Math.Round(Math.Sqrt(y) + (y * (1 / 3)), 2)
            x2 = Math.Round(Math.Log(y - ((y / x1) * b), Math.E), 2)

            TextBox1.Text += $"{y}{vbTab}{vbTab}{x1}{vbTab}{vbTab}{x2}{Environment.NewLine}"
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        Dim q As Single
        Dim ai As Single
        Dim eps As Single
        eps = 10 ^ (-8)
        i = 0
        q = 0
        Do
            i = i + 1
            ai = ((-1) ^ (i + 1)) / (i ^ 4)
            q = q + ai
        Loop Until Math.Abs(ai) < eps
        TextBox1.Text += $"{Environment.NewLine}Задание 3: {Math.Round(q, 5)}{Environment.NewLine}"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
    End Sub
End Class
