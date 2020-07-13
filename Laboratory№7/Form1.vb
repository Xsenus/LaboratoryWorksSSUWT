Public Class Form1

    Private Array1 As Array = {1, 5, -1, 5, 4, -20, 1}
    Private Array2 As Array = {{8.1, -3, 2, 6}, {11, 85, 3, -7.7}, {7.2, 2, 4, 9.5}, {-5, 9.1, 3, 2.9}}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        Dim str As String
        Dim EvenElements As Int32
        Dim ProductNumbers As Double = 1

        For index = 0 To Array1.Length - 1
            str += $"{Array1(index)} "

            If Array1(index) Mod 2 = 0 Then
                EvenElements = EvenElements + 1
            End If

            If Array1(index) > 0 Then
                ProductNumbers = ProductNumbers * Array1(index)
            End If
        Next

        TextBox1.Text = $"Одномерный массив: {str}{Environment.NewLine}"
        TextBox1.Text += $"Четных элементов: {EvenElements}{Environment.NewLine}"
        TextBox1.Text += $"Произведение положительных элементов: {ProductNumbers}{Environment.NewLine}"

        Dim SortArray As Array
        Dim tmp As Double
        SortArray = Array1

        For i = 0 To SortArray.Length - 1
            For j = i + 1 To SortArray.Length - 1
                If SortArray(j) < SortArray(i) Then
                    tmp = SortArray(i)
                    SortArray(i) = SortArray(j)
                    SortArray(j) = tmp
                End If
            Next
        Next

        TextBox1.Text += $"Упорядоченный массив в порядке возрастания: "

        For ind = 0 To SortArray.Length - 1
            TextBox1.Text += $"{SortArray(ind)} "
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        Dim str As String
        Dim maxElement As Double
        Dim minElement As Double
        Dim sumElement As Double
        Dim maxElementIndex As String
        maxElementIndex = "(0, 0)"
        maxElement = Array2(0, 0)

        For i = 0 To 3

            If minElement > Array2(i, 1) Then
                minElement = Array2(i, 1)
            End If

            For j = 0 To 3
                str += $"{Array2(i, j)}{vbTab}"

                If Array2(i, j) > maxElement Then
                    maxElement = Array2(i, j)
                    maxElementIndex = $"({i}, {j})"
                End If

                If i = j Then
                    sumElement = sumElement + Array2(i, j)
                End If

            Next
            str += $"{Environment.NewLine}"
        Next

        TextBox1.Text = $"Двумерный  массив: {Environment.NewLine}{str}{Environment.NewLine}"
        TextBox1.Text += $"Максимальный элемент массив: {maxElement} индекс {maxElementIndex}{Environment.NewLine}"
        TextBox1.Text += $"Минимальный элемент 2 столбца: {minElement} {Environment.NewLine}"
        TextBox1.Text += $"Сумма элементов диагонали: {sumElement} {Environment.NewLine}"

        Dim temp As Double

        For i = 0 To 3
            temp = Array2(i, 0)
            Array2(i, 0) = Array2(i, 3)
            Array2(i, 3) = temp
        Next

        TextBox1.Text += $"{Environment.NewLine}1 и 4 столбец поменялись местами: {Environment.NewLine}"

        For i = 0 To 3

            For j = 0 To 3
                TextBox1.Text += $"{Array2(i, j)}{vbTab}"
            Next
            TextBox1.Text += $"{Environment.NewLine}"
        Next

    End Sub
End Class
