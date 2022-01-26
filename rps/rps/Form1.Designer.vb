<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pcbLeft = New System.Windows.Forms.PictureBox
        Me.pcbRight = New System.Windows.Forms.PictureBox
        Me.lblComputer = New System.Windows.Forms.Label
        Me.lblPlayer = New System.Windows.Forms.Label
        Me.pgbCountDown = New System.Windows.Forms.ProgressBar
        Me.lblCountDown = New System.Windows.Forms.Label
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnPaper = New System.Windows.Forms.Button
        Me.btnScissors = New System.Windows.Forms.Button
        Me.btnRock = New System.Windows.Forms.Button
        Me.grpStatus = New System.Windows.Forms.GroupBox
        Me.txtTies = New System.Windows.Forms.TextBox
        Me.txtLosses = New System.Windows.Forms.TextBox
        Me.txtWins = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.imlHands = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrControl = New System.Windows.Forms.Timer(Me.components)
        Me.btnHowToPlay = New System.Windows.Forms.Button
        CType(Me.pcbLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbLeft
        '
        Me.pcbLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbLeft.Location = New System.Drawing.Point(12, 12)
        Me.pcbLeft.Name = "pcbLeft"
        Me.pcbLeft.Size = New System.Drawing.Size(90, 79)
        Me.pcbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLeft.TabIndex = 0
        Me.pcbLeft.TabStop = False
        '
        'pcbRight
        '
        Me.pcbRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbRight.Location = New System.Drawing.Point(268, 12)
        Me.pcbRight.Name = "pcbRight"
        Me.pcbRight.Size = New System.Drawing.Size(90, 79)
        Me.pcbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbRight.TabIndex = 1
        Me.pcbRight.TabStop = False
        '
        'lblComputer
        '
        Me.lblComputer.AutoSize = True
        Me.lblComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputer.Location = New System.Drawing.Point(9, 98)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(98, 13)
        Me.lblComputer.TabIndex = 2
        Me.lblComputer.Text = "Computer's Pick"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(279, 98)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(80, 13)
        Me.lblPlayer.TabIndex = 3
        Me.lblPlayer.Text = "Player's Pick"
        '
        'pgbCountDown
        '
        Me.pgbCountDown.Location = New System.Drawing.Point(12, 146)
        Me.pgbCountDown.Name = "pgbCountDown"
        Me.pgbCountDown.Size = New System.Drawing.Size(225, 23)
        Me.pgbCountDown.TabIndex = 4
        '
        'lblCountDown
        '
        Me.lblCountDown.AutoSize = True
        Me.lblCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountDown.Location = New System.Drawing.Point(12, 130)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(70, 13)
        Me.lblCountDown.TabIndex = 5
        Me.lblCountDown.Text = "Countdown"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(129, 175)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 6
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.Location = New System.Drawing.Point(270, 154)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(75, 23)
        Me.btnPaper.TabIndex = 7
        Me.btnPaper.Text = "Paper"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.Location = New System.Drawing.Point(271, 184)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(75, 23)
        Me.btnScissors.TabIndex = 8
        Me.btnScissors.Text = "Scissors"
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'btnRock
        '
        Me.btnRock.Location = New System.Drawing.Point(271, 125)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(75, 23)
        Me.btnRock.TabIndex = 9
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.txtTies)
        Me.grpStatus.Controls.Add(Me.txtLosses)
        Me.grpStatus.Controls.Add(Me.txtWins)
        Me.grpStatus.Controls.Add(Me.Label3)
        Me.grpStatus.Controls.Add(Me.Label2)
        Me.grpStatus.Controls.Add(Me.Label1)
        Me.grpStatus.Location = New System.Drawing.Point(12, 233)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(154, 100)
        Me.grpStatus.TabIndex = 10
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Status"
        '
        'txtTies
        '
        Me.txtTies.Location = New System.Drawing.Point(54, 71)
        Me.txtTies.Name = "txtTies"
        Me.txtTies.Size = New System.Drawing.Size(94, 20)
        Me.txtTies.TabIndex = 5
        '
        'txtLosses
        '
        Me.txtLosses.Location = New System.Drawing.Point(54, 45)
        Me.txtLosses.Name = "txtLosses"
        Me.txtLosses.Size = New System.Drawing.Size(94, 20)
        Me.txtLosses.TabIndex = 4
        '
        'txtWins
        '
        Me.txtWins.Location = New System.Drawing.Point(54, 19)
        Me.txtWins.Name = "txtWins"
        Me.txtWins.Size = New System.Drawing.Size(94, 20)
        Me.txtWins.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ties"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Losses"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wins"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(212, 252)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(134, 72)
        Me.txtOutput.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Results:"
        '
        'imlHands
        '
        Me.imlHands.ImageStream = CType(resources.GetObject("imlHands.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlHands.TransparentColor = System.Drawing.Color.Transparent
        Me.imlHands.Images.SetKeyName(0, "Left-Paper.bmp")
        Me.imlHands.Images.SetKeyName(1, "Right-Paper.bmp")
        Me.imlHands.Images.SetKeyName(2, "Left-Rock.bmp")
        Me.imlHands.Images.SetKeyName(3, "Right-Rock.bmp")
        Me.imlHands.Images.SetKeyName(4, "Left-Scissors.bmp")
        Me.imlHands.Images.SetKeyName(5, "Right-Scissors.bmp")
        Me.imlHands.Images.SetKeyName(6, "Blank.bmp")
        '
        'tmrControl
        '
        Me.tmrControl.Interval = 500
        '
        'btnHowToPlay
        '
        Me.btnHowToPlay.Location = New System.Drawing.Point(48, 175)
        Me.btnHowToPlay.Name = "btnHowToPlay"
        Me.btnHowToPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnHowToPlay.TabIndex = 13
        Me.btnHowToPlay.Text = "How to Play"
        Me.btnHowToPlay.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(379, 345)
        Me.Controls.Add(Me.btnHowToPlay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblCountDown)
        Me.Controls.Add(Me.pgbCountDown)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.pcbRight)
        Me.Controls.Add(Me.pcbLeft)
        Me.Name = "frmMain"
        Me.Text = "Rock, Paper, Scissors"
        CType(Me.pcbLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pcbRight As System.Windows.Forms.PictureBox
    Friend WithEvents lblComputer As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents pgbCountDown As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCountDown As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents txtTies As System.Windows.Forms.TextBox
    Friend WithEvents txtLosses As System.Windows.Forms.TextBox
    Friend WithEvents txtWins As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents imlHands As System.Windows.Forms.ImageList
    Friend WithEvents tmrControl As System.Windows.Forms.Timer
    Friend WithEvents btnHowToPlay As System.Windows.Forms.Button

End Class
