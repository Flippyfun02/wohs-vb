Public Class Form1
    Dim BlackCar As New Car
    Dim BlueCar As New Car

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFuelBlack.Text = BlackCar.Fuel
        lblFuelBlue.Text = BlueCar.Fuel
        lblTiresBlack.Text = BlackCar.Tires
        lblTiresBlue.Text = BlueCar.Tires
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub btnDriveBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDriveBlack.Click
        BlackCar.Drive()
        pcbBlackCar.Left += BlackCar.Distance
        lblFuelBlack.Text = BlackCar.Fuel
        lblTiresBlack.Text = BlackCar.Tires
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Buzzer.wav")
    End Sub

    Private Sub btnDriveBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDriveBlue.Click
        BlueCar.Drive()
        pcbBlueCar.Left += BlueCar.Distance
        lblFuelBlue.Text = BlueCar.Fuel
        lblTiresBlue.Text = BlueCar.Tires
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Buzzer.wav")
        CheckWinner()
    End Sub

    Private Sub btnNitroBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNitroBlack.Click
        BlackCar.Nitro()
        pcbBlackCar.Left += BlackCar.Distance
        lblFuelBlack.Text = BlackCar.Fuel
        lblTiresBlack.Text = BlackCar.Tires
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Cheering.wav")
    End Sub

    Private Sub btnNitroBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNitroBlue.Click
        BlueCar.Nitro()
        pcbBlueCar.Left += BlueCar.Distance
        lblFuelBlue.Text = BlueCar.Fuel
        lblTiresBlue.Text = BlueCar.Tires
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Cheering.wav")
        CheckWinner()
    End Sub

    Private Sub btnMechanicBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMechanicBlack.Click
        BlackCar.Mechanic()
        pcbBlackCar.Left += BlackCar.Distance
        lblFuelBlack.Text = BlackCar.Fuel
        lblTiresBlack.Text = BlackCar.Tires
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Hit.wav")
    End Sub

    Private Sub btnMechanicBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMechanicBlue.Click
        BlueCar.Mechanic()
        pcbBlueCar.Left += BlueCar.Distance
        lblFuelBlue.Text = BlueCar.Fuel
        lblTiresBlue.Text = BlueCar.Tires
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Hit.wav")
        CheckWinner()
    End Sub

    Private Sub btnRefuelBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefuelBlack.Click
        BlackCar.Refuel()
        pcbBlackCar.Left += BlackCar.Distance
        lblFuelBlack.Text = BlackCar.Fuel
        lblTiresBlack.Text = BlackCar.Tires
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Applause.wav")
    End Sub

    Private Sub btnRefuelBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefuelBlue.Click
        BlueCar.Refuel()
        pcbBlueCar.Left += BlueCar.Distance
        lblFuelBlue.Text = BlueCar.Fuel
        lblTiresBlue.Text = BlueCar.Tires
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        'My.Computer.Audio.Play("W:\VisualBasic\WhackAMole\Applause.wav")
        CheckWinner()
    End Sub

    Private Sub CheckWinner()
        Dim blackFinish As Boolean
        Dim blueFinish As Boolean
        ' check which cars reaches the end
        If pcbBlackCar.Left >= Me.ClientRectangle.Right - 131 Then
            blackFinish = True
        End If
        If pcbBlueCar.Left >= Me.ClientRectangle.Right - 131 Then
            blueFinish = True
        End If
        If blackFinish And Not blueFinish Then
            txtResult.Text = "Black wins!"
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        ElseIf blueFinish And Not blackFinish Then
            txtResult.Text = "Blue wins!"
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        ElseIf blackFinish And blueFinish Then
            txtResult.Text = "Tie!"
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub btnTiresBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiresBlack.Click
        BlackCar.ChangeTires()
        lblTiresBlack.Text = BlackCar.Tires
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    Private Sub btnTiresBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiresBlue.Click
        BlueCar.ChangeTires()
        lblTiresBlue.Text = BlueCar.Tires
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        CheckWinner()
    End Sub
End Class
