Public Class Form1
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        lstFactors.Items.Clear()
        ' if num exists and is numeric
        If txtUserNum.Text <> "" And IsNumeric(txtUserNum.Text) Then
            Dim num As Integer = Integer.Parse(txtUserNum.Text)
            Dim flag As Boolean
            ' if positive
            If num > 1 Then
                'For i = 2 To num / 2
                'If num Mod i = 0 Then
                'flag = True
                ' Exit For
                'End If
                'Next i
                lstFactors.Items.Add(1)
                Dim i As Integer = 2
                Do While num >= i
                    If num Mod i = 0 Then
                        flag = True
                        lstFactors.Items.Add(i)
                    End If
                    i += 1
                Loop

                If flag Then
                    txtFeedback.Text = num.ToString + " is not a prime number."
                Else
                    txtFeedback.Text = num.ToString + " is a prime number."
                    lstFactors.Items.Add(num)
                End If
            Else
                txtFeedback.Text = "Must be greater than 1."
            End If
        Else
            txtFeedback.Text = "Enter a number"
        End If
    End Sub
End Class
