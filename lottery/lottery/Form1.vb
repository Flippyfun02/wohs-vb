Public Class Form1
    Private Sub Clear()
        lblNums.Text = "..."
        Pick3.Enabled = True
        Pick4.Enabled = True
        Pick5.Enabled = True
        Pick6.Enabled = True
        txtMax.ReadOnly = False
        btnLuckyNums.Enabled = True
        btnReset.Enabled = False
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Clear()
    End Sub

    Private Sub btnLuckyNums_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuckyNums.Click
        'declare variables
        Dim intCounter, intRandom, intTemp, targetNum As Integer

        ' set target num
        If Pick3.Checked Then
            targetNum = 3
        ElseIf Pick4.Checked Then
            targetNum = 4
        ElseIf Pick5.Checked Then
            targetNum = 5
        ElseIf Pick6.Checked Then
            targetNum = 6
        End If

        Pick3.Enabled = False
        Pick4.Enabled = False
        Pick5.Enabled = False
        Pick6.Enabled = False

        ' check num
        If txtMax.Text <> "" And IsNumeric(txtMax.Text) Then
            Dim max As Integer = Integer.Parse(txtMax.Text)
            If max > 2 And max < 100 Then
                Dim intNumArray(max) As Integer

                txtMax.ReadOnly = True

                'Fill the elements 1-49 with integers 1-49
                For intCounter = 1 To max
                    intNumArray(intCounter) = intCounter
                Next intCounter

                ' Shuffle values in elements 1-49
                For intCounter = 1 To max
                    intRandom = Int(max * Rnd()) + 1
                    intTemp = intNumArray(intCounter)
                    intNumArray(intCounter) = intNumArray(intRandom)
                    intNumArray(intRandom) = intTemp
                Next intCounter

                lblNums.Text = ""

                ' sort array
                ReDim Preserve intNumArray(targetNum + 1)
                Array.Sort(intNumArray)

                For i = 1 To targetNum
                    lblNums.Text += intNumArray(i).ToString + "          "
                Next i

                'Set the button states to done
                btnLuckyNums.Enabled = False
                btnReset.Enabled = True

            End If
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear()
        Randomize()
    End Sub
End Class
