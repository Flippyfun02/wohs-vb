Public Class Form1

    Private Sub txtFirstNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstNum.TextChanged

    End Sub

    Private Sub defaultn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResultN.Click

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblResult As Double
        dblNum1 = Double.Parse(txtFirstNum.Text)
        dblNum2 = Double.Parse(txtSecondNum.Text)
        dblResult = dblNum1 + dblNum2

        lblResultN.Text = dblResult.ToString("n")
        lblResultN0.Text = dblResult.ToString("n0")
        lblResultN1.Text = dblResult.ToString("n1")
        lblResultN3.Text = dblResult.ToString("n3")

        lblResultC.Text = dblResult.ToString("c")
        lblResultC0.Text = dblResult.ToString("c0")
        lblResultC1.Text = dblResult.ToString("c1")
        lblResultC3.Text = dblResult.ToString("c3")

        lblResultE.Text = dblResult.ToString("e")
        lblResultE0.Text = dblResult.ToString("e0")
        lblResultE1.Text = dblResult.ToString("e1")
        lblResultE3.Text = dblResult.ToString("e3")

        lblResultP.Text = dblResult.ToString("p")
        lblResultP0.Text = dblResult.ToString("p0")
        lblResultP1.Text = dblResult.ToString("p1")
        lblResultP3.Text = dblResult.ToString("p3")

    End Sub

    Private Sub no_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblResult As Double
        dblNum1 = Double.Parse(txtFirstNum.Text)
        dblNum2 = Double.Parse(txtSecondNum.Text)
        dblResult = dblNum1 - dblNum2

        lblResultN.Text = dblResult.ToString("n")
        lblResultN0.Text = dblResult.ToString("n0")
        lblResultN1.Text = dblResult.ToString("n1")
        lblResultN3.Text = dblResult.ToString("n3")

        lblResultC.Text = dblResult.ToString("c")
        lblResultC0.Text = dblResult.ToString("c0")
        lblResultC1.Text = dblResult.ToString("c1")
        lblResultC3.Text = dblResult.ToString("c3")

        lblResultE.Text = dblResult.ToString("e")
        lblResultE0.Text = dblResult.ToString("e0")
        lblResultE1.Text = dblResult.ToString("e1")
        lblResultE3.Text = dblResult.ToString("e3")

        lblResultP.Text = dblResult.ToString("p")
        lblResultP0.Text = dblResult.ToString("p0")
        lblResultP1.Text = dblResult.ToString("p1")
        lblResultP3.Text = dblResult.ToString("p3")
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblResult As Double
        dblNum1 = Double.Parse(txtFirstNum.Text)
        dblNum2 = Double.Parse(txtSecondNum.Text)
        dblResult = dblNum1 * dblNum2

        lblResultN.Text = dblResult.ToString("n")
        lblResultN0.Text = dblResult.ToString("n0")
        lblResultN1.Text = dblResult.ToString("n1")
        lblResultN3.Text = dblResult.ToString("n3")

        lblResultC.Text = dblResult.ToString("c")
        lblResultC0.Text = dblResult.ToString("c0")
        lblResultC1.Text = dblResult.ToString("c1")
        lblResultC3.Text = dblResult.ToString("c3")

        lblResultE.Text = dblResult.ToString("e")
        lblResultE0.Text = dblResult.ToString("e0")
        lblResultE1.Text = dblResult.ToString("e1")
        lblResultE3.Text = dblResult.ToString("e3")

        lblResultP.Text = dblResult.ToString("p")
        lblResultP0.Text = dblResult.ToString("p0")
        lblResultP1.Text = dblResult.ToString("p1")
        lblResultP3.Text = dblResult.ToString("p3")
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblResult As Double
        dblNum1 = Double.Parse(txtFirstNum.Text)
        dblNum2 = Double.Parse(txtSecondNum.Text)
        dblResult = dblNum1 / dblNum2

        lblResultN.Text = dblResult.ToString("n")
        lblResultN0.Text = dblResult.ToString("n0")
        lblResultN1.Text = dblResult.ToString("n1")
        lblResultN3.Text = dblResult.ToString("n3")

        lblResultC.Text = dblResult.ToString("c")
        lblResultC0.Text = dblResult.ToString("c0")
        lblResultC1.Text = dblResult.ToString("c1")
        lblResultC3.Text = dblResult.ToString("c3")

        lblResultE.Text = dblResult.ToString("e")
        lblResultE0.Text = dblResult.ToString("e0")
        lblResultE1.Text = dblResult.ToString("e1")
        lblResultE3.Text = dblResult.ToString("e3")

        lblResultP.Text = dblResult.ToString("p")
        lblResultP0.Text = dblResult.ToString("p0")
        lblResultP1.Text = dblResult.ToString("p1")
        lblResultP3.Text = dblResult.ToString("p3")
    End Sub

    Private Sub btnDivideInt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivideInt.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblResult As Double
        dblNum1 = Double.Parse(txtFirstNum.Text)
        dblNum2 = Double.Parse(txtSecondNum.Text)
        dblResult = dblNum1 \ dblNum2

        lblResultN.Text = dblResult.ToString("n")
        lblResultN0.Text = dblResult.ToString("n0")
        lblResultN1.Text = dblResult.ToString("n1")
        lblResultN3.Text = dblResult.ToString("n3")

        lblResultC.Text = dblResult.ToString("c")
        lblResultC0.Text = dblResult.ToString("c0")
        lblResultC1.Text = dblResult.ToString("c1")
        lblResultC3.Text = dblResult.ToString("c3")

        lblResultE.Text = dblResult.ToString("e")
        lblResultE0.Text = dblResult.ToString("e0")
        lblResultE1.Text = dblResult.ToString("e1")
        lblResultE3.Text = dblResult.ToString("e3")

        lblResultP.Text = dblResult.ToString("p")
        lblResultP0.Text = dblResult.ToString("p0")
        lblResultP1.Text = dblResult.ToString("p1")
        lblResultP3.Text = dblResult.ToString("p3")
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblResult As Double
        dblNum1 = Double.Parse(txtFirstNum.Text)
        dblNum2 = Double.Parse(txtSecondNum.Text)
        dblResult = dblNum1 Mod dblNum2

        lblResultN.Text = dblResult.ToString("n")
        lblResultN0.Text = dblResult.ToString("n0")
        lblResultN1.Text = dblResult.ToString("n1")
        lblResultN3.Text = dblResult.ToString("n3")

        lblResultC.Text = dblResult.ToString("c")
        lblResultC0.Text = dblResult.ToString("c0")
        lblResultC1.Text = dblResult.ToString("c1")
        lblResultC3.Text = dblResult.ToString("c3")

        lblResultE.Text = dblResult.ToString("e")
        lblResultE0.Text = dblResult.ToString("e0")
        lblResultE1.Text = dblResult.ToString("e1")
        lblResultE3.Text = dblResult.ToString("e3")

        lblResultP.Text = dblResult.ToString("p")
        lblResultP0.Text = dblResult.ToString("p0")
        lblResultP1.Text = dblResult.ToString("p1")
        lblResultP3.Text = dblResult.ToString("p3")
    End Sub

    Private Sub btnExponent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExponent.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblResult As Double
        dblNum1 = Double.Parse(txtFirstNum.Text)
        dblNum2 = Double.Parse(txtSecondNum.Text)
        dblResult = dblNum1 ^ dblNum2

        lblResultN.Text = dblResult.ToString("n")
        lblResultN0.Text = dblResult.ToString("n0")
        lblResultN1.Text = dblResult.ToString("n1")
        lblResultN3.Text = dblResult.ToString("n3")

        lblResultC.Text = dblResult.ToString("c")
        lblResultC0.Text = dblResult.ToString("c0")
        lblResultC1.Text = dblResult.ToString("c1")
        lblResultC3.Text = dblResult.ToString("c3")

        lblResultE.Text = dblResult.ToString("e")
        lblResultE0.Text = dblResult.ToString("e0")
        lblResultE1.Text = dblResult.ToString("e1")
        lblResultE3.Text = dblResult.ToString("e3")

        lblResultP.Text = dblResult.ToString("p")
        lblResultP0.Text = dblResult.ToString("p0")
        lblResultP1.Text = dblResult.ToString("p1")
        lblResultP3.Text = dblResult.ToString("p3")
    End Sub
End Class
