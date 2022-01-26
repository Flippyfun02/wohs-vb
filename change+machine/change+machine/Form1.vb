Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intLeftover As Integer
        intLeftover = Integer.Parse(txtPennies.Text)
        lblDollars.Text = (intLeftover \ 100).ToString
        intLeftover = intLeftover Mod 100
        lblQuarters.Text = (intLeftover \ 25).ToString
        intLeftover = intLeftover Mod 25
        lblDimes.Text = (intLeftover \ 10).ToString
        intLeftover = intLeftover Mod 10
        lblNickels.Text = (intLeftover \ 5).ToString
        intLeftover = intLeftover Mod 5
        lblPennies.Text = intLeftover.ToString
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPennies.Text = ""
        lblDollars.Text = ""
        lblQuarters.Text = ""
        lblDimes.Text = ""
        lblNickels.Text = ""
        lblPennies.Text = ""
    End Sub
End Class
