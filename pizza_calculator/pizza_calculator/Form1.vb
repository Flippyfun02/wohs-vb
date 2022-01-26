Public Class Form1
    Const LARGE As Double = 10
    Const MEDIUM As Double = 7.5
    Const SMALL As Double = 5
    Const TOPPING As Double = 0.5
    Dim dblTotal As Double = 0
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If radLarge.Checked Then
            dblTotal = LARGE
        ElseIf radMedium.Checked Then
            dblTotal = MEDIUM
        ElseIf radSmall.Checked Then
            dblTotal = SMALL
        End If

        If chkPepperoni.Checked Then
            dblTotal += TOPPING
        End If
        If chkBacon.Checked Then
            dblTotal += TOPPING
        End If
        If chkPineapple.Checked Then
            dblTotal += TOPPING
        End If

        lblCost.Text = dblTotal.ToString("c")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        radLarge.Checked = True
        radMedium.Checked = False
        radSmall.Checked = False

        chkPepperoni.Checked = False
        chkBacon.Checked = False
        chkPineapple.Checked = False

        lblCost.Text = " "
    End Sub
End Class
