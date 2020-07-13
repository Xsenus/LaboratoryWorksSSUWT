Public Class FrmShar
    Private R As Double
    Private S As Double
    Private V As Double

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        txtR.Visible = True
        txtR.Enabled = True
        R = Val(InputBox("Введите значение R", "Ввод радиуса"))
        txtR.Text = R
        S = 4 * Math.PI * R ^ 2
        txtS.Text = Math.Round(S, 3)
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        txtR.Visible = True
        txtR.Enabled = True
        R = Val(InputBox("Введите значение R", "Ввод радиуса"))
        txtR.Text = R
        V = 4 / 3 * Math.PI * R ^ 3
        txtV.Text = Math.Round(V, 3)

    End Sub

    Private Sub СбросToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СбросToolStripMenuItem.Click
        txtR.Text = ""
        txtS.Text = ""
        txtV.Text = ""
    End Sub

    Private Sub ОбАвтореToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбАвтореToolStripMenuItem.Click
        MsgBox("Лабораторную работу" + Chr(13) + Chr(10) + "выполнил студент" + Chr(13) + Chr(10) + "Тарасов Илья", vbInformation + vbOKOnly, "Сообщение об авторе")
    End Sub
End Class
