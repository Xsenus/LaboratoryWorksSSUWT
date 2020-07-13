Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileno As Integer
        Dim i As Integer, j As Integer, m As Integer, n As Integer
        fileno = FreeFile()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("data.txt")
        TextBox1.Text = fileReader
    End Sub
End Class
