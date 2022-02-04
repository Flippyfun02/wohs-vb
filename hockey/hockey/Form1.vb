Public Class Form1
    Dim blnToTop
    Dim intRightScore As Integer = 0
    Dim intLeftScore As Integer = 0
    Dim blnToRight As Boolean = False
    Dim blnToBottom As Boolean = False
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' wasd for left paddle
        If e.KeyCode = Keys.W Then
            pcbLeftPad.Top -= 4
        End If
        If e.KeyCode = Keys.S Then
            pcbLeftPad.Top += 4
        End If
        If e.KeyCode = Keys.A Then
            pcbLeftPad.Left -= 4
        End If
        If e.KeyCode = Keys.D Then
            pcbLeftPad.Left += 4
        End If

        ' ijkl for right paddle
        If e.KeyCode = Keys.I Then
            pcbRightPad.Top -= 4
        End If
        If e.KeyCode = Keys.K Then
            pcbRightPad.Top += 4
        End If
        If e.KeyCode = Keys.J Then
            pcbRightPad.Left -= 4
        End If
        If e.KeyCode = Keys.L Then
            pcbRightPad.Left += 4
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Label1.Text = "Ball Coordinates: (" + pcbBall.Left.ToString + ", " + pcbBall.Top.ToString + ")"
        'Label2.Text = "Right Paddle: (" + pcbRightPad.Left.ToString + ", " + pcbRightPad.Top.ToString + ")"

        If blnToRight Then
            pcbBall.Left += 8
        Else
            pcbBall.Left -= 8
        End If
        'Moves the ball vertically
        If blnToBottom Then
            pcbBall.Top += 8
        Else
            pcbBall.Top -= 8
        End If

        If pcbBall.Top > pcbGoalLeft.Top And pcbBall.Top < pcbGoalLeft.Top + pcbGoalLeft.Height _
        And pcbBall.Left < pcbGoalLeft.Width Then
            ' right scores point
            intRightScore += 1
            lblRightScore.Text = intRightScore
            pcbBall.Top = Me.ClientRectangle.Bottom / 2
            pcbBall.Left = Me.ClientRectangle.Right / 2
            blnToRight = True
        End If
        If pcbBall.Top > pcbGoalRight.Top And pcbBall.Top < pcbGoalRight.Top + pcbGoalRight.Height _
        And pcbBall.Left + pcbBall.Width > Me.ClientRectangle.Right - pcbGoalRight.Width Then
            ' left scores point
            intLeftScore += 1
            lblLeftScore.Text = intLeftScore
            pcbBall.Top = Me.ClientRectangle.Bottom / 2
            pcbBall.Left = Me.ClientRectangle.Right / 2
            blnToRight = False
        End If

        If (pcbBall.Top + pcbBall.Height > pcbLeftPad.Top _
        And pcbBall.Top < pcbLeftPad.Top + pcbLeftPad.Height) _
        And pcbBall.Left <= pcbLeftPad.Left + pcbLeftPad.Width Then
            'Ball hit left paddle - no score - reverse ball
            blnToRight = True

        ElseIf (pcbBall.Top + pcbBall.Height > pcbRightPad.Top _
        And pcbBall.Top < pcbRightPad.Top + pcbRightPad.Height) _
        And pcbBall.Left + pcbBall.Width >= pcbRightPad.Left Then
            'Ball hit right paddle no score - reverse bail
            blnToRight = False

        ElseIf pcbBall.Left <= Me.ClientRectangle.Left Then
            'Ball in missed left paddle & hit wall - score right - left - serve ball
            blnToRight = True
        ElseIf pcbBall.Left + pcbBall.Width >= Me.ClientRectangle.Right Then
            'Bail missed right - paddie & hit wail - score left - right serve bail
            blnToRight = False
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
        End If

    End Sub
End Class
