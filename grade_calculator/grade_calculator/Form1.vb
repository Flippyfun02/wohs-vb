Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim dblMP1 As Double
        Dim dblMP2 As Double
        Dim dblMP3 As Double
        Dim dblMP4 As Double
        Dim dblFinal As Double

        If sem1.Checked Then
            If txt1.Text = "" Or txt2.Text = "" Then
                txtResult.Text = "Please enter results for all available MPs"
            ElseIf Not IsNumeric(txt1.Text) Or Not IsNumeric(txt2.Text) Then
                txtResult.Text = "Numbers only."
            Else
                'get values
                dblMP1 = Double.Parse(txt1.Text)
                dblMP2 = Double.Parse(txt2.Text)
                If (dblMP1 >= 50 And dblMP1 <= 100) And (dblMP2 >= 50 And dblMP2 <= 100) Then
                    dblFinal = (dblMP1 * 0.5) + (dblMP2 * 0.5)
                    txtResult.Text = dblFinal.ToString("n1")
                Else
                    txtResult.Text = "Invalid grades."
                End If
            End If
        ElseIf sem2.Checked Then
            If txt3.Text = "" Or txt4.Text = "" Then
                txtResult.Text = "Please enter results for all available MPs"
            ElseIf Not IsNumeric(txt3.Text) Or Not IsNumeric(txt4.Text) Then
                txtResult.Text = "Numbers only."
            Else
                'get values
                dblMP3 = Double.Parse(txt3.Text)
                dblMP4 = Double.Parse(txt4.Text)
                If (dblMP3 >= 50 And dblMP3 <= 100) And (dblMP4 >= 50 And dblMP4 <= 100) Then
                    dblFinal = (dblMP3 * 0.5) + (dblMP4 * 0.5)
                    txtResult.Text = dblFinal.ToString("n1")
                Else
                    txtResult.Text = "Invalid grades"
                End If
            End If

        ElseIf fullYear.Checked Then
            If txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Then
                txtResult.Text = "Please enter results for all available MPs"
            ElseIf Not IsNumeric(txt1.Text) Or Not IsNumeric(txt2.Text) Or Not IsNumeric(txt3.Text) Or Not IsNumeric(txt4.Text) Then
                txtResult.Text = "Numbers only."
            Else
                'get values
                dblMP1 = Double.Parse(txt1.Text)
                dblMP2 = Double.Parse(txt2.Text)
                dblMP3 = Double.Parse(txt3.Text)
                dblMP4 = Double.Parse(txt4.Text)
                If (dblMP1 >= 50 And dblMP1 <= 100) And (dblMP2 >= 50 And dblMP2 <= 100) _
                And (dblMP3 >= 50 And dblMP3 <= 100) And (dblMP4 >= 50 And dblMP4 <= 100) Then
                    dblFinal = (dblMP1 * 0.25) + (dblMP2 * 0.25) + (dblMP3 * 0.25) + (dblMP4 * 0.25)
                    txtResult.Text = dblFinal.ToString("n1")
                End If
            End If
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub sem1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sem1.CheckedChanged
        txt1.ReadOnly = False
        txt2.ReadOnly = False
        txt3.ReadOnly = True
        txt4.ReadOnly = True
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub sem2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sem2.CheckedChanged
        txt1.ReadOnly = True
        txt2.ReadOnly = True
        txt3.ReadOnly = False
        txt4.ReadOnly = False
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub fullYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fullYear.CheckedChanged
        txt1.ReadOnly = False
        txt2.ReadOnly = False
        txt3.ReadOnly = False
        txt4.ReadOnly = False
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged

    End Sub
End Class
