Public Class frmMain
    Dim intCounter As Integer
    Dim blnMove As Boolean = False

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pcbLeft.Image = imlHands.Images.Item(6) 'blank bitmap
        pcbRight.Image = imlHands.Images.Item(6)

        ' Set game states
        txtWins.Text = 0
        txtLosses.Text = 0
        txtTies.Text = 0
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        blnMove = False
        pgbCountDown.Value = 0 ' progress bar is 0
        tmrControl.Enabled = True ' enable timer
        txtOutput.Text = ""

        pcbLeft.Image = imlHands.Images.Item(6)
        pcbRight.Image = imlHands.Images.Item(6)
    End Sub

    Private Sub tmrControl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrControl.Tick
        intCounter += 1

        Select Case intCounter
            Case 1 ' 0.5 sec
                pgbCountDown.Value = 33
            Case 2 ' 1 sec
                pgbCountDown.Value = 66
            Case 3 ' 1.5 sec
                pgbCountDown.Value = 100
                ' Enable choice buttons
                btnRock.Enabled = True
                btnPaper.Enabled = True
                btnScissors.Enabled = True
            Case 4 ' 2 sec
                intCounter = 0 ' reset counter
                tmrControl.Enabled = False
                ' disable choice buttons
                btnRock.Enabled = False
                btnPaper.Enabled = False
                btnScissors.Enabled = False
                pgbCountDown.Value = 0 ' reset progress bar
                If Not blnMove Then
                    MessageBox.Show("Be faster.")
                End If
        End Select
    End Sub

    Private Sub btnRock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRock.Click
        Dim strPlayerPick As String
        Dim strComputerPick As String
        blnMove = True
        ' load rock
        pcbRight.Image = imlHands.Images.Item(3)
        strPlayerPick = "Rock"

        ' determine computer pick
        strComputerPick = ComputerTurn()

        ' game results
        CheckGameResults(strPlayerPick, strComputerPick)
    End Sub

    Private Sub btnPaper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaper.Click
        Dim strPlayerPick As String
        Dim strComputerPick As String
        blnMove = True
        ' load rock
        pcbRight.Image = imlHands.Images.Item(1)
        strPlayerPick = "Paper"

        ' determine computer pick
        strComputerPick = ComputerTurn()

        ' game results
        CheckGameResults(strPlayerPick, strComputerPick)
    End Sub

    Private Sub btnScissors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScissors.Click
        Dim strPlayerPick As String
        Dim strComputerPick As String
        blnMove = True
        ' load rock
        pcbRight.Image = imlHands.Images.Item(5)
        strPlayerPick = "Scissors"

        ' determine computer pick
        strComputerPick = ComputerTurn()

        ' game results
        CheckGameResults(strPlayerPick, strComputerPick)
    End Sub

    Function ComputerTurn() As String
        Dim intRandomNumber As Integer
        Dim strComputerMove As String = ""

        Dim r As New Random
        intRandomNumber = r.Next(1, 3)

        Select Case intRandomNumber
            Case 3
                pcbLeft.Image = imlHands.Images.Item(2)
                strComputerMove = "Rock"
            Case 2
                pcbLeft.Image = imlHands.Images.Item(4)
                strComputerMove = "Scissors"
            Case 1
                pcbLeft.Image = imlHands.Images.Item(0)
                strComputerMove = "Paper"
        End Select

        Return strComputerMove
    End Function

    Sub CheckGameResults(ByVal strPlayerPick As String, ByVal strComputerPick As String)
        pgbCountDown.Value = 0

        Select Case strPlayerPick
            Case "Rock"
                Select Case strComputerPick
                    Case "Rock"
                        txtOutput.Text = "Rock vs Rock is a Tie!"
                        txtTies.Text += 1
                    Case "Scissors"
                        txtOutput.Text = "Rock crushes Scissors. You Win!"
                        txtWins.Text += 1
                    Case "Paper"
                        txtOutput.Text = "Paper covers Rock. You Lose!"
                        txtLosses.Text += 1
                End Select
            Case "Scissors"
                Select Case strComputerPick
                    Case "Rock"
                        txtOutput.Text = "Rock breaks scissors. You Lose!"
                        txtLosses.Text += 1
                    Case "Scissors"
                        txtOutput.Text = "Scissors vs Scissors is a Tie!"
                        txtTies.Text += 1
                    Case "Paper"
                        txtOutput.Text = "Scissors cut Paper. You Win!"
                        txtWins.Text += 1
                End Select
            Case "Paper"
                Select Case strComputerPick
                    Case "Rock"
                        txtOutput.Text = "Paper covers Rock. You Win!"
                        txtWins.Text += 1
                    Case "Scissors"
                        txtOutput.Text = "Scissors cut Paper. You Lose!"
                        txtLosses.Text += 1
                    Case "Paper"
                        txtOutput.Text = "Paper vs Paper is a Tie!"
                        txtTies.Text += 1
                End Select
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHowToPlay.Click
        txtOutput.Text = "Click play. When the bar fills green, select your move. Be quick so you don't run out of time!"
    End Sub
End Class
