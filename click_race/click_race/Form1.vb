Public Class Form1

    Dim intCounter As Integer = 0
    Dim intTimerCount As Integer = 0

    'Defines Form1 as an object'
    Private Sub Form1_Load(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load

        'User cannot play game until start_game is clicked'
        Button1.Enabled = False
        Button2.Enabled = False
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Red

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'update status'
        intCounter = intCounter + 1
        TextBox1.Text = intCounter
        Button1.Enabled = False
        Button2.Enabled = True 'enables other button to click'
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Green

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'update status'
        intCounter = intCounter + 1
        TextBox1.Text = intCounter
        Button1.Enabled = True
        Button2.Enabled = False 'enables other button to click'
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Red

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click _

        'Start or Reset game'
        intCounter = 0
        intTimerCount = 0
        TextBox1.Text = ""
        Button1.Enabled = True
        Button2.Enabled = False
        Timer1.Enabled = True
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Red

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Application.Exit()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        intTimerCount = intTimerCount + 1
        TextBox2.Text = intTimerCount
        If intTimerCount = 30 Then
            Button1.Enabled = False
            Button2.Enabled = False
            Timer1.Enabled = False
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
