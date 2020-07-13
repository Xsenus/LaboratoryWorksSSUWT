Public Class FrmArifm

    Private a As Double
    Private b As Double
    Private c As Double

    Private Sub cmdPls_Click(sender As Object, e As EventArgs) Handles cmdPls.Click
        a = Val(txta.Text)
        b = Val(txtb.Text)
        c = a + b
        txtc.Text = Str(c)
    End Sub

    Private Sub cmdMns_Click(sender As Object, e As EventArgs) Handles cmdMns.Click
        a = Val(txta.Text)
        b = Val(txtb.Text)
        c = a - b
        txtc.Text = Str(c)
    End Sub

    Private Sub cmdUmn_Click(sender As Object, e As EventArgs) Handles cmdUmn.Click
        a = Val(txta.Text)
        b = Val(txtb.Text)
        c = a * b
        txtc.Text = Str(c)
    End Sub

    Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
        a = Val(txta.Text)
        b = Val(txtb.Text)
        c = a / b
        txtc.Text = Str(c)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txta.Text = ""
        txtb.Text = ""
        txtc.Text = ""
    End Sub

    Private Sub btnAuthor_Click(sender As Object, e As EventArgs) Handles btnAuthor.Click
        MsgBox("Лабораторную работу" + Chr(13) + Chr(10) + "выполнил студент" + Chr(13) + Chr(10) + "Тарасов Илья гр.СЭ-121а", vbInformation + vbOKOnly, "Сообщение об авторе")
    End Sub
End Class
