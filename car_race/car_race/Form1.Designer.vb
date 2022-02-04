<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pcbBlueCar = New System.Windows.Forms.PictureBox
        Me.pcbBlackCar = New System.Windows.Forms.PictureBox
        Me.btnDriveBlack = New System.Windows.Forms.Button
        Me.btnNitroBlack = New System.Windows.Forms.Button
        Me.btnMechanicBlack = New System.Windows.Forms.Button
        Me.btnRefuelBlack = New System.Windows.Forms.Button
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFuelBlack = New System.Windows.Forms.Label
        Me.lblFuelBlue = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnRefuelBlue = New System.Windows.Forms.Button
        Me.btnMechanicBlue = New System.Windows.Forms.Button
        Me.btnNitroBlue = New System.Windows.Forms.Button
        Me.btnDriveBlue = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTiresBlack = New System.Windows.Forms.Label
        Me.btnTiresBlack = New System.Windows.Forms.Button
        Me.btnTiresBlue = New System.Windows.Forms.Button
        Me.lblTiresBlue = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.pcbBlueCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBlackCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbBlueCar
        '
        Me.pcbBlueCar.Image = Global.car_race.My.Resources.Resources.car2
        Me.pcbBlueCar.Location = New System.Drawing.Point(13, 149)
        Me.pcbBlueCar.Name = "pcbBlueCar"
        Me.pcbBlueCar.Size = New System.Drawing.Size(131, 75)
        Me.pcbBlueCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBlueCar.TabIndex = 1
        Me.pcbBlueCar.TabStop = False
        '
        'pcbBlackCar
        '
        Me.pcbBlackCar.Image = Global.car_race.My.Resources.Resources.car1989
        Me.pcbBlackCar.Location = New System.Drawing.Point(13, 13)
        Me.pcbBlackCar.Name = "pcbBlackCar"
        Me.pcbBlackCar.Size = New System.Drawing.Size(131, 75)
        Me.pcbBlackCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBlackCar.TabIndex = 0
        Me.pcbBlackCar.TabStop = False
        '
        'btnDriveBlack
        '
        Me.btnDriveBlack.Location = New System.Drawing.Point(6, 19)
        Me.btnDriveBlack.Name = "btnDriveBlack"
        Me.btnDriveBlack.Size = New System.Drawing.Size(75, 23)
        Me.btnDriveBlack.TabIndex = 2
        Me.btnDriveBlack.Text = "Drive"
        Me.btnDriveBlack.UseVisualStyleBackColor = True
        '
        'btnNitroBlack
        '
        Me.btnNitroBlack.Location = New System.Drawing.Point(87, 19)
        Me.btnNitroBlack.Name = "btnNitroBlack"
        Me.btnNitroBlack.Size = New System.Drawing.Size(75, 23)
        Me.btnNitroBlack.TabIndex = 3
        Me.btnNitroBlack.Text = "Nitro"
        Me.btnNitroBlack.UseVisualStyleBackColor = True
        '
        'btnMechanicBlack
        '
        Me.btnMechanicBlack.Location = New System.Drawing.Point(168, 19)
        Me.btnMechanicBlack.Name = "btnMechanicBlack"
        Me.btnMechanicBlack.Size = New System.Drawing.Size(75, 23)
        Me.btnMechanicBlack.TabIndex = 4
        Me.btnMechanicBlack.Text = "Mechanic"
        Me.btnMechanicBlack.UseVisualStyleBackColor = True
        '
        'btnRefuelBlack
        '
        Me.btnRefuelBlack.Location = New System.Drawing.Point(249, 19)
        Me.btnRefuelBlack.Name = "btnRefuelBlack"
        Me.btnRefuelBlack.Size = New System.Drawing.Size(75, 23)
        Me.btnRefuelBlack.TabIndex = 5
        Me.btnRefuelBlack.Text = "Refuel"
        Me.btnRefuelBlack.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(13, 284)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(647, 20)
        Me.txtResult.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fuel Remaining"
        '
        'lblFuelBlack
        '
        Me.lblFuelBlack.AutoSize = True
        Me.lblFuelBlack.Location = New System.Drawing.Point(498, 24)
        Me.lblFuelBlack.Name = "lblFuelBlack"
        Me.lblFuelBlack.Size = New System.Drawing.Size(39, 13)
        Me.lblFuelBlack.TabIndex = 12
        Me.lblFuelBlack.Text = "Label2"
        '
        'lblFuelBlue
        '
        Me.lblFuelBlue.AutoSize = True
        Me.lblFuelBlue.Location = New System.Drawing.Point(498, 24)
        Me.lblFuelBlue.Name = "lblFuelBlue"
        Me.lblFuelBlue.Size = New System.Drawing.Size(39, 13)
        Me.lblFuelBlue.TabIndex = 19
        Me.lblFuelBlue.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(411, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Fuel Remaining"
        '
        'btnRefuelBlue
        '
        Me.btnRefuelBlue.Location = New System.Drawing.Point(249, 19)
        Me.btnRefuelBlue.Name = "btnRefuelBlue"
        Me.btnRefuelBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnRefuelBlue.TabIndex = 17
        Me.btnRefuelBlue.Text = "Refuel"
        Me.btnRefuelBlue.UseVisualStyleBackColor = True
        '
        'btnMechanicBlue
        '
        Me.btnMechanicBlue.Location = New System.Drawing.Point(168, 19)
        Me.btnMechanicBlue.Name = "btnMechanicBlue"
        Me.btnMechanicBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnMechanicBlue.TabIndex = 16
        Me.btnMechanicBlue.Text = "Mechanic"
        Me.btnMechanicBlue.UseVisualStyleBackColor = True
        '
        'btnNitroBlue
        '
        Me.btnNitroBlue.Location = New System.Drawing.Point(87, 19)
        Me.btnNitroBlue.Name = "btnNitroBlue"
        Me.btnNitroBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnNitroBlue.TabIndex = 15
        Me.btnNitroBlue.Text = "Nitro"
        Me.btnNitroBlue.UseVisualStyleBackColor = True
        '
        'btnDriveBlue
        '
        Me.btnDriveBlue.Location = New System.Drawing.Point(6, 19)
        Me.btnDriveBlue.Name = "btnDriveBlue"
        Me.btnDriveBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnDriveBlue.TabIndex = 14
        Me.btnDriveBlue.Text = "Drive"
        Me.btnDriveBlue.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTiresBlack)
        Me.GroupBox1.Controls.Add(Me.lblTiresBlack)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnDriveBlack)
        Me.GroupBox1.Controls.Add(Me.btnNitroBlack)
        Me.GroupBox1.Controls.Add(Me.btnMechanicBlack)
        Me.GroupBox1.Controls.Add(Me.btnRefuelBlack)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblFuelBlack)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 49)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Black 1989 Mercedes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTiresBlue)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnTiresBlue)
        Me.GroupBox2.Controls.Add(Me.btnDriveBlue)
        Me.GroupBox2.Controls.Add(Me.btnNitroBlue)
        Me.GroupBox2.Controls.Add(Me.lblFuelBlue)
        Me.GroupBox2.Controls.Add(Me.btnMechanicBlue)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnRefuelBlue)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 48)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Blue Chevorlet Camaro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(547, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tire Life"
        '
        'lblTiresBlack
        '
        Me.lblTiresBlack.AutoSize = True
        Me.lblTiresBlack.Location = New System.Drawing.Point(598, 24)
        Me.lblTiresBlack.Name = "lblTiresBlack"
        Me.lblTiresBlack.Size = New System.Drawing.Size(39, 13)
        Me.lblTiresBlack.TabIndex = 14
        Me.lblTiresBlack.Text = "Label3"
        '
        'btnTiresBlack
        '
        Me.btnTiresBlack.Location = New System.Drawing.Point(330, 19)
        Me.btnTiresBlack.Name = "btnTiresBlack"
        Me.btnTiresBlack.Size = New System.Drawing.Size(75, 23)
        Me.btnTiresBlack.TabIndex = 23
        Me.btnTiresBlack.Text = "Tires"
        Me.btnTiresBlack.UseVisualStyleBackColor = True
        '
        'btnTiresBlue
        '
        Me.btnTiresBlue.Location = New System.Drawing.Point(330, 19)
        Me.btnTiresBlue.Name = "btnTiresBlue"
        Me.btnTiresBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnTiresBlue.TabIndex = 23
        Me.btnTiresBlue.Text = "Tires"
        Me.btnTiresBlue.UseVisualStyleBackColor = True
        '
        'lblTiresBlue
        '
        Me.lblTiresBlue.AutoSize = True
        Me.lblTiresBlue.Location = New System.Drawing.Point(598, 24)
        Me.lblTiresBlue.Name = "lblTiresBlue"
        Me.lblTiresBlue.Size = New System.Drawing.Size(39, 13)
        Me.lblTiresBlue.TabIndex = 25
        Me.lblTiresBlue.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(547, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tire Life"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 318)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.pcbBlueCar)
        Me.Controls.Add(Me.pcbBlackCar)
        Me.Name = "Form1"
        Me.Text = "Car Race"
        CType(Me.pcbBlueCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBlackCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbBlackCar As System.Windows.Forms.PictureBox
    Friend WithEvents pcbBlueCar As System.Windows.Forms.PictureBox
    Friend WithEvents btnDriveBlack As System.Windows.Forms.Button
    Friend WithEvents btnNitroBlack As System.Windows.Forms.Button
    Friend WithEvents btnMechanicBlack As System.Windows.Forms.Button
    Friend WithEvents btnRefuelBlack As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFuelBlack As System.Windows.Forms.Label
    Friend WithEvents lblFuelBlue As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRefuelBlue As System.Windows.Forms.Button
    Friend WithEvents btnMechanicBlue As System.Windows.Forms.Button
    Friend WithEvents btnNitroBlue As System.Windows.Forms.Button
    Friend WithEvents btnDriveBlue As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTiresBlack As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTiresBlack As System.Windows.Forms.Button
    Friend WithEvents lblTiresBlue As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnTiresBlue As System.Windows.Forms.Button

End Class
