Public Class Form1
    Dim penguin = False
    Dim silence = False

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "What ceases to exist when you say its name? "
        TextBox2.Text = " "
        silence = True
        penguin = False
        Button3.Enabled = False
        Button4.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = "What's black and write and red all over?       "
        TextBox2.Text = " "
        penguin = True
        silence = False
        Button3.Enabled = True
        Button4.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If penguin Then
            TextBox2.Text = "A sunburned penguin!"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If silence Then
            TextBox2.Text = "Silence!"
        End If
    End Sub
End Class
