Module Module1

    Public Sub AveNum(numbers() As Single, ByRef average As Single)
        Dim total As String = 0

        For i As Integer = 0 To numbers.Length - 1

            total += numbers(i)

        Next i

        average = total / numbers.Length

    End Sub




End Module
