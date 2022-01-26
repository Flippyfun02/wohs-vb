Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim x As Integer = 0
        Dim num As Integer
        'Do While (i < 20)
        '   If (i Mod 5 = 0) Then x += i
        '   i += 1
        'Loop
        'x = 30

        'Do
        '    If (i Mod 5 = 0) Then x += 1
        '       i += 1
        'Loop While (i < 20)
        'x = 4

        Dim total As Integer = 0
        For outer = 1 To 3
            For inner = outer To 3
                total += outer * inner
            Next
        Next

        num = total
    End Sub
End Class
