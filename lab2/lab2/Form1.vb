Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.Text = "Run Time"
        Label1.BackColor = Color.Blue
        Me.BackColor = Color.Green
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Load Time"
        Label1.BackColor = Color.Red
        Me.BackColor = Color.Purple
    End Sub
End Class
