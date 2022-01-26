Public Class frmMain
    Dim Random As New Random
    Dim targetNum As Integer
    Dim intScore As Integer = 0
    Dim intGuesses As Integer
    Dim intTotalGuesses As Integer
    Dim intGamesPlayed As Integer = 0
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        intGuesses = 10
        txtGuesses.Text = intGuesses.ToString
        intGamesPlayed += 1
        'set targetNum
        If radRange10.Checked Then
            targetNum = Random.Next(1, 10)
        ElseIf radRange100.Checked Then
            targetNum = Random.Next(1, 100)
        ElseIf radRange1000.Checked Then
            targetNum = Random.Next(1, 1000)
        End If

        'enabled user to guess and check
        btnCheck.Enabled = True
        txtGuess.ReadOnly = False

        'reset guess and feedback
        txtGuess.Text = ""
        txtFeedback.Text = ""

        'disable changing game settings
        radRange10.Enabled = False
        radRange100.Enabled = False
        radRange1000.Enabled = False

        btnNewGame.Enabled = False

    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim intAverage As Double
        If txtGuess.Text = "" Then
            txtFeedback.Text = "No input. Try again."
        Else
            If IsNumeric(txtGuess.Text) Then
                intGuesses -= 1
                txtGuesses.Text = intGuesses.ToString
                'compare guess to answer
                If Integer.Parse(txtGuess.Text) = targetNum Then
                    txtFeedback.Text = "Congratulations, you win!"
                    btnNewGame.Enabled = True
                    intScore += 1

                    'display score
                    txtGamesWon.Text = intScore.ToString

                    'prevent player from winning again with same num
                    btnCheck.Enabled = False

                    'disable changing game settings
                    radRange10.Enabled = True
                    radRange100.Enabled = True
                    radRange1000.Enabled = True

                ElseIf Integer.Parse(txtGuess.Text) > targetNum Then
                    txtFeedback.Text = "Too large! "
                    If Integer.Parse(txtGuess.Text) = targetNum + 1 Then
                        txtFeedback.Text += "You're hot!"
                    ElseIf Integer.Parse(txtGuess.Text) <= targetNum + 3 Then
                        txtFeedback.Text += "You're warm!"
                    End If
                ElseIf Integer.Parse(txtGuess.Text) < targetNum Then
                    txtFeedback.Text = "Too low! "
                    If Integer.Parse(txtGuess.Text) = targetNum - 1 Then
                        txtFeedback.Text += "You're hot!"
                    ElseIf Integer.Parse(txtGuess.Text) >= targetNum - 3 Then
                        txtFeedback.Text += "You're warm!"
                    End If
                End If
                If intGuesses = 0 Then
                    btnCheck.Enabled = False
                    txtFeedback.Text = "You Lose. The number was " + targetNum.ToString + "."
                    btnNewGame.Enabled = True

                    ' reenable range
                    radRange10.Enabled = True
                    radRange100.Enabled = True
                    radRange1000.Enabled = True
                End If
                If btnNewGame.Enabled Then
                    intTotalGuesses += 10 - intGuesses
                    intAverage = intTotalGuesses / intGamesPlayed
                    txtAverage.Text = intAverage.ToString("n0")
                End If
            Else
                txtFeedback.Text = "Please enter a number."
            End If
            End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'display score
        txtGamesWon.Text = intScore.ToString

        'make blue
        btnNewGame.Focus()
    End Sub
End Class
