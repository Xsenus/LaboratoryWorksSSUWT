Public Class Form1
    Private arg As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        arg = Val(TextBox1.Text)
        TextBox2.Text = Arcsin(arg)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        arg = Val(TextBox1.Text)
        TextBox2.Text = Arccos(arg)
    End Sub

    Public Function Arcsin(x As Double) As Double
        Arcsin = Math.Sinh(x)
    End Function

    Public Function Arccos(x As Double) As Double
        Arccos = Math.Cosh(x)
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        arg = Val(TextBox1.Text)
        TextBox2.Text = Ctg(arg)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        arg = Val(TextBox1.Text)
        TextBox2.Text = Arcctg(arg)
    End Sub

    Public Function Ctg(x As Double) As Double
        Ctg = Math.Tan(x)
    End Function

    Public Function Arcctg(x As Double) As Double
        Arcctg = Math.Tanh(x)
    End Function
End Class
