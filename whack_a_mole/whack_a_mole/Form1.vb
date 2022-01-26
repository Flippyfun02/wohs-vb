Public Class Form1
    Dim dblTimerCount As Double = 0
    Dim intScore As Integer = 0
    Dim intPosition As Integer = 0
    Dim Random As New Random
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnMoleHole1.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        btnMoleHole2.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        btnMoleHole3.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        btnMoleHole4.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        btnMoleHole5.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        Me.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheHunt.jpg")
    End Sub

    Private Sub btnMoleHole1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoleHole1.Click
        If intPosition = 1 Then
            intScore += 1 'increase score
            lblScore.Text = intScore.ToString
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Bop.wav") 'play sound
            btnMoleHole1.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg") 'reset background
            intPosition = 15 'player cannot click on mole more than once per second
        Else
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\WrongAnswer.wav")
        End If
    End Sub

    Private Sub btnMoleHole2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoleHole2.Click
        If intPosition = 2 Then
            intScore += 1 'increase score
            lblScore.Text = intScore.ToString
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Bop.wav") 'play sound
            btnMoleHole2.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg") 'reset background
            intPosition = 15 'player cannot click on mole more than once per second
        Else
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\WrongAnswer.wav")
        End If
    End Sub

    Private Sub btnMoleHole3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoleHole3.Click
        If intPosition = 3 Then
            intScore += 1 'increase score
            lblScore.Text = intScore.ToString
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Bop.wav") 'play sound
            btnMoleHole3.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg") 'reset background
            intPosition = 15 'player cannot click on mole more than once per second
        Else
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\WrongAnswer.wav")
        End If
    End Sub

    Private Sub btnMoleHole4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoleHole4.Click
        If intPosition = 4 Then
            intScore += 1 'increase score
            lblScore.Text = intScore.ToString
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Bop.wav") 'play sound
            btnMoleHole4.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg") 'reset background
            intPosition = 15 'player cannot click on mole more than once per second
        Else
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\WrongAnswer.wav")
        End If
    End Sub

    Private Sub btnMoleHole5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoleHole5.Click
        If intPosition = 5 Then
            intScore += 1 'increase score
            lblScore.Text = intScore.ToString
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Bop.wav") 'play sound
            btnMoleHole5.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg") 'reset background
            intPosition = 15 'player cannot click on mole more than once per second
        Else
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\WrongAnswer.wav")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        intPosition = Random.Next(1, 15) 'position = random num from 1-15
        If dblTimerCount < 15 Then
            dblTimerCount += 1 'Adds 1 to time each tick
        ElseIf dblTimerCount >= 15 Then
            dblTimerCount += 0.5
        End If
        lblSeconds.Text = dblTimerCount.ToString 'display num of seconds

        'reset background image
        btnMoleHole1.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        btnMoleHole2.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        btnMoleHole3.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        btnMoleHole4.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")
        btnMoleHole5.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheGreen.jpg")

        If intPosition = 1 Then
            btnMoleHole1.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        ElseIf intPosition = 2 Then
            btnMoleHole2.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        ElseIf intPosition = 3 Then
            btnMoleHole3.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        ElseIf intPosition = 4 Then
            btnMoleHole4.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        ElseIf intPosition = 5 Then
            btnMoleHole5.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        End If


        'put image of mole in random button
        'Select Case intPosition
        'Case 1
        'btnMoleHole1.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        'Case 2
        'btnMoleHole2.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        'Case 3
        'btnMoleHole3.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        ' Case 4
        'btnMoleHole4.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        'Case 5
        'btnMoleHole5.BackgroundImage = Image.FromFile("W:\VisualBasic\WhackAMole\TheMole.jpg")
        'End Select

        If dblTimerCount = 30 Then 'game stops at 30 sec
            lblSeconds.Text = "GAME OVER"
            My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\GameOver.wav")
            Timer1.Enabled = False 'disable timer so it's never executed again
        ElseIf dblTimerCount = 15 Then
            Timer1.Interval = 500
        End If
    End Sub
End Class
