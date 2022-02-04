Public Class Form1
    Dim blnToRight As Boolean = False
    Dim blnToBottom As Boolean = False
    Dim intLeftScore As Integer = 0
    Dim intRightScore As Integer = 0

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D Then
            pcbLeftPad.Top += 8
        End If
        If e.KeyCode = Keys.E Then
            pcbLeftPad.Top -= 8
        End If
        If e.KeyCode = Keys.L Then
            pcbRightPad.Top += 8
        End If
        If e.KeyCode = Keys.O Then
            pcbRightPad.Top -= 8
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Moves the bail horizontally
        If blnToRight Then
            pcbBall.Left += 2
        Else
            pcbBall.Left -= 2
        End If
        'Moves the ball vertically
        If blnToBottom Then
            pcbBall.Top += 2
        Else
            pcbBall.Top -= 2
        End If
        If (pcbBall.Top + pcbBall.Height > pcbLeftPad.Top _
        And pcbBall.Top < pcbLeftPad.Top + pcbLeftPad.Height) _
        And pcbBall.Left <= pcbLeftPad.Left + pcbLeftPad.Width Then
            'Ball hit left paddle - no score - reverse ball
            blnToRight = True
            'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Hit.wav")
        ElseIf (pcbBall.Top + pcbBall.Height > pcbRightPad.Top _
        And pcbBall.Top < pcbRightPad.Top + pcbRightPad.Height) _
        And pcbBall.Left + pcbBall.Width >= pcbRightPad.Left Then
            'Ball hit right paddle no score - reverse bail
            blnToRight = False
            'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Hit.wav")
        ElseIf pcbBall.Left <= Me.ClientRectangle.Left Then
            'Ball in missed left paddle & hit wall - score right - left - serve ball
            intRightScore += 1
            lblRightScore.Text = intRightScore
            pcbBall.Left = Me.ClientRectangle.Right / 2
            blnToRight = True
            'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Buzzer.wav")
        ElseIf pcbBall.Left + pcbBall.Width >= Me.ClientRectangle.Right Then
            'Bail missed right - paddie & hit wail - score left - right serve bail
            pcbBall.Left = Me.ClientRectangle.Right / 2
            blnToRight = False
            'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Bop.wav")
        End If
        If pcbBall.Top <= Me.ClientRectangle.Top Then
            'Ball hit top of form - reverse direction
            blnToBottom = True
        ElseIf pcbBall.Top + pcbBall.Height >= Me.ClientRectangle.Bottom Then
            'Ball hit bottom of form - reverse direction
            blnToBottom = False
        End If
        If intRightScore = 10 Or intLeftScore = 10 Then
            Timer1.Enabled = False
            'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\GameOver.wav")
        End If
    End Sub
End Class
