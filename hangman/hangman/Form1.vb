Public Class frmMain
    Const cTitleBarMsg As String = "HANGMAN" ' Titlebar message
    Private strWordListArray(25) As String ' list of game words
    Private strGameWord As String = "" ' stores word currently in play
    Private strWrong As String = "" ' Stores a list of missed guesses
    Private intHangmanNo As Integer = 6 ' controls hangman display

    ' stats
    Private intMisses As Integer = 0
    Private intNoRight As Integer = 0
    Private intPlayAgain As Integer = 0

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadWordArray()
        InitializeGameStats()
        StartTheGame()
    End Sub

    Sub LoadWordArray()
        strWordListArray(0) = "ELEPHANT"
        strWordListArray(1) = "CARRIAGE"
        strWordListArray(2) = "ENVELOPE"
        strWordListArray(3) = "PRESIDENT"
        strWordListArray(4) = "ELLIPTICAL"
        strWordListArray(5) = "MARKER"
        strWordListArray(6) = "BATTLESHIP"
        strWordListArray(7) = "TERMINATE"
        strWordListArray(8) = "REJOICE"
        strWordListArray(9) = "LIBERTY"
        strWordListArray(10) = "CLASSIC"
        strWordListArray(11) = "REFLEX"
        strWordListArray(12) = "AIRPLANE"
        strWordListArray(13) = "DWELLING"
        strWordListArray(14) = "APARTMENT"
        strWordListArray(15) = "RENTAL"
        strWordListArray(16) = "FAUCET"
        strWordListArray(17) = "BEDROOM"
        strWordListArray(18) = "VOLLEY"
        strWordListArray(19) = "WHISTLE"
        strWordListArray(20) = "PENCIL"
        strWordListArray(21) = "THIEF"
        strWordListArray(22) = "DRAGON"
        strWordListArray(23) = "POTATO"
        strWordListArray(24) = "VOYAGER"
        strWordListArray(25) = "HANGMAN"
    End Sub

    Sub InitializeGameStats()
        txtGamesWon.Text = 0
        txtGamesLost.Text = 0
    End Sub

    Sub StartTheGame()
        ResetDefaultSettings()
        strGameWord = RetrieveWord()
        FormatGameWord()
        txtInput.Focus()
    End Sub
    Sub ResetDefaultSettings()
        intMisses = 0
        intNoRight = 0
        txtGuesses.Text = ""
        txtMisses.Text = intMisses
        txtInput.Text = ""
        intHangmanNo = 6
        pbcHangmanBmp.Image = imlHangmanBmps.Images.Item(6)
    End Sub
    Function RetrieveWord() As String
        Dim intRandomNo As Integer = 0
        Dim r As New Random

        intRandomNo = r.Next(strWordListArray.Length)
        Return strWordListArray(intRandomNo)
    End Function
    Sub FormatGameWord()
        Dim intCounter As Integer = 1

        ' blank words
        txtLetter1.Text = ""
        txtLetter2.Text = ""
        txtLetter3.Text = ""
        txtLetter4.Text = ""
        txtLetter5.Text = ""
        txtLetter6.Text = ""
        txtLetter7.Text = ""
        txtLetter8.Text = ""
        txtLetter9.Text = ""
        txtLetter10.Text = ""

        For intCounter = 1 To strGameWord.Length
            If intCounter = 1 Then txtLetter1.Text = "-"
            If intCounter = 2 Then txtLetter2.Text = "-"
            If intCounter = 3 Then txtLetter3.Text = "-"
            If intCounter = 4 Then txtLetter4.Text = "-"
            If intCounter = 5 Then txtLetter5.Text = "-"
            If intCounter = 6 Then txtLetter6.Text = "-"
            If intCounter = 7 Then txtLetter7.Text = "-"
            If intCounter = 8 Then txtLetter8.Text = "-"
            If intCounter = 9 Then txtLetter9.Text = "-"
            If intCounter = 10 Then txtLetter10.Text = "-"
        Next
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim intCounter As Integer = 0
        Dim strWordLetter As String = ""
        Dim strInputOk As String = ""

        strInputOk = ValidatePlayerInput()
        If strInputOk = "Error" Then
            Exit Sub
        End If

        ' if user already guessed letter
        If Strings.InStr(1, txtGuesses.Text, txtInput.Text.ToUpper, 1) <> 0 Then
            MessageBox.Show("Error: Letter has already been guessed.")
        Else
            txtGuesses.Text += " " + txtInput.Text

            ' if guess is wrong
            If Strings.InStr(1, strGameWord.ToUpper, txtInput.Text.ToUpper, 1) = 0 Then
                strWrong += " " + txtInput.Text.ToUpper
                intMisses += 1
                txtMisses.Text = intMisses

                ' update hangman
                intHangmanNo -= 1
                pbcHangmanBmp.Image = imlHangmanBmps.Images.Item(intHangmanNo)

                ' losing game
                If intMisses = 6 Then
                    txtGamesLost.Text += 1
                    PromptForNewGame("Sorry. You have lost. The word was " + strGameWord + ".")
                End If
            End If

            ' go through each letter
            For intCounter = 1 To strGameWord.Length
                ' select one letter at a time
                strWordLetter = Mid(strGameWord, intCounter, 1)
                ' if letter matches player's guess
                If strWordLetter.ToUpper = txtInput.Text.ToUpper Then
                    intNoRight += 1
                    FlipGameLetter(intCounter)
                End If
            Next
        End If

        If intNoRight = strGameWord.Length Then
            txtGamesWon.Text += 1
            PromptForNewGame("Congratulations. You have won!")
        End If

        txtInput.Text = ""
        txtInput.Focus()

    End Sub
    Function ValidatePlayerInput() As String
        If txtInput.Text = "" Then
            MessageBox.Show("Error: You must enter a letter.")
            txtInput.Text = ""
            txtInput.Focus()
            Return "Error"
        End If

        If txtInput.Text.Length > 1 Then
            MessageBox.Show("Error: You may only enter one letter per guess")
            txtInput.Text = ""
            txtInput.Focus()
            Return "Error"
        End If
        If IsNumeric(txtInput.Text) Then
            MessageBox.Show("Error: Numeric entries are not valid.")
            txtInput.Text = ""
            txtInput.Focus()
            Return "Error"
        End If
        Return "Passed"

    End Function
    Sub FlipGameLetter(ByVal intLetterNumber As Integer)
        ' display letter
        Select Case intLetterNumber
            Case 1
                txtLetter1.Text = txtInput.Text.ToUpper
            Case 2
                txtLetter2.Text = txtInput.Text.ToUpper
            Case 3
                txtLetter3.Text = txtInput.Text.ToUpper
            Case 4
                txtLetter4.Text = txtInput.Text.ToUpper
            Case 5
                txtLetter5.Text = txtInput.Text.ToUpper
            Case 6
                txtLetter6.Text = txtInput.Text.ToUpper
            Case 7
                txtLetter7.Text = txtInput.Text.ToUpper
            Case 8
                txtLetter8.Text = txtInput.Text.ToUpper
            Case 9
                txtLetter9.Text = txtInput.Text.ToUpper
            Case 10
                txtLetter10.Text = txtInput.Text.ToUpper
        End Select
    End Sub

    Sub PromptForNewGame(ByVal strMessage As String)
        intPlayAgain = MessageBox.Show(strMessage & " Would you like to play again?", _
                                       cTitleBarMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intPlayAgain = 6 Then
            StartTheGame()
        Else
            Application.Exit()
        End If
    End Sub

End Class
