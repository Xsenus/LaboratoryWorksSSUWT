Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x as Double
        Dim eps As Double = 0.879001
        Dim y As Double
        x = 2 ^ (4 * (Math.PI ^ 2))
        y = ((Math.Abs(3 * x ^ 2 - 7 * x - 5)) ^ (1 / 6)) + (1 / 2 * eps)
        TextBox1.Text = Math.Round(y, 3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim y1 As Double = 0.25 * Math.PI
        Dim y2 As Double = 1.47
        Dim i As Double = 0.001
        Dim y As Double
        y = ((y1 ^ 2 * y2) / 2) - ((i ^ 2 + 1) * (y1 / 3)) + (1 / (20 * y2))
        TextBox2.Text = Math.Round(y, 4)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As Double = 0.775
        Dim a As Double = 5.6
        Dim y As Double
        y = ((3 * x - 1.4) / (2 * x * a)) + (Math.Atan(1 / (Math.Log(2 * x, Math.E) ^ 2)) / (1 - Math.E))
        TextBox3.Text = Math.Round(y, 4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x As Double = 2.648
        Dim y As Double
        y = ((3 * x ^ 2 + 2 * (Math.PI - 1)) / (6 * x)) + (Math.Cos(x ^ (1 / 4)) ^ 3)
        TextBox4.Text = Math.Round(y, 3)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x As Double = 0.624
        Dim y As Double
        y = ((Math.PI / 2) - Math.Log(3 * x, Math.E) + (x * (4 ^ Math.E))) / (3 * x)
        TextBox5.Text = Math.Round(y, 4)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Double
        x = Math.Log(Math.Abs(0.569 - ((4 * Math.PI) / 3)), Math.E) ^ 2
        Dim q As Double
        q = (x ^ 2) + Math.Sqrt(x)
        Dim y As Double
        y = (q / (2 * Math.PI)) - ((3 * Math.PI) / 2)
        TextBox6.Text = Math.Round(y, 4)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim x As Double = 0.892
        Dim y As Double
        y = (Math.Abs((3 * (x ^ 2)) - (1 / Math.E) - (1 / (2 * Math.PI))) ^ (1 / 3)) + ((x ^ (2 * Math.PI)) / (3 + x))
        TextBox7.Text = Math.Round(y, 4)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim x As Double = 10.01
        Dim eps As Double = 0.02
        Dim q As Double = 5 * Math.PI
        Dim y As Double
        y = (3 * Math.Log((2 * x) / (x - 1), Math.E) + eps ^ 2) / ((q * x) / 2)
        TextBox8.Text = Math.Round(y, 4)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
End Class
