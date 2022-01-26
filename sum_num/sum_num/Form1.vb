Public Class Form1
    Private Sub num_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        ' if num exists and is numeric

        If txtUserNum.Text <> "" And IsNumeric(txtUserNum.Text) Then
            Dim intStop As Integer = Integer.Parse(txtUserNum.Text)
            Dim sum As Integer = 0
            Dim intStep As Integer = 1
            Dim start As Integer = 1
            Dim flag As String = ""

            ' init start/step
            If txtStep.Text <> "" Then
                If IsNumeric(txtStep.Text) Then
                    intStep = CInt(txtStep.Text)
                Else
                    flag = "Step must be numeric"
                End If
            End If
            If txtStart.Text <> "" Then
                If IsNumeric(txtStart.Text) Then
                    start = CInt(txtStart.Text)
                Else
                    flag = "Start must be numeric"
                End If
            End If
            ' for i = 1 to 10 step 1
            ' for i = 10 to 1 step -1

            If (intStop < start And intStep > 0) Then
                flag = "Step must be negative"
            ElseIf (intStop > start And intStep < 0) Then
                flag = "Step must be positive"
            ElseIf intStep = 0 Then
                flag = "Step cannot be zero"
            End If

            If flag = "" Then
                ' if positive
                If intStop > 0 Then
                    For i = start To intStop Step intStep
                        sum += i
                    Next i
                    txtResult.Text = sum.ToString
                Else
                    txtResult.Text = "Num must be positive."
                End If
            Else
                txtResult.Text = flag
            End If
        Else
            txtResult.Text = "no input"
        End If
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtResult.Text = ""
        txtUserNum.Text = ""
        txtStart.Text = ""
        txtStep.Text = ""
    End Sub
End Class
