Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, minx, maxx, stepx, y, miny, maxy, stepy As Double
        Dim nx, ny As Double

        minx = Val(TextBox1.Text)
        maxx = Val(TextBox2.Text)
        stepx = Val(TextBox3.Text)

        miny = Val(TextBox6.Text)
        maxy = Val(TextBox5.Text)
        stepy = Val(TextBox4.Text)

        nx = (maxx - minx) / stepx
        ny = (maxy - miny) / stepy

        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart1.Series(0).Points.Clear()
        For x = minx To maxx Step stepx
            Chart1.Series(0).Points.AddXY(x, 0)
        Next

        For y = miny To maxy Step stepy
            Chart1.Series(0).Points.AddXY(0, y)
        Next
    End Sub

    Public Function f(x As Double) As Double
        f = Math.Exp(x) - x - 2
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
