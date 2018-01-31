Public Class Form1
    Dim numbers(-1) As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim average As Single
        AveNum(numbers, average)
        lblAverege.Text = average
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim up As Integer = numbers.Length - 1
        ReDim Preserve numbers(up + 1)
        numbers(up + 1) = txtNum.Text
        txtNum.Clear()
        txtNum.Focus()

    End Sub
End Class
