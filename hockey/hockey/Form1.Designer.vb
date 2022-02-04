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
        Me.components = New System.ComponentModel.Container
        Me.pcbGoalLeft = New System.Windows.Forms.PictureBox
        Me.pcbRightPad = New System.Windows.Forms.PictureBox
        Me.pcbLeftPad = New System.Windows.Forms.PictureBox
        Me.pcbGoalRight = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.pcbBall = New System.Windows.Forms.PictureBox
        Me.lblRightScore = New System.Windows.Forms.Label
        Me.lblLeftScore = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbGoalLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbRightPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbLeftPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbGoalRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbGoalLeft
        '
        Me.pcbGoalLeft.BackColor = System.Drawing.Color.Black
        Me.pcbGoalLeft.Location = New System.Drawing.Point(0, 117)
        Me.pcbGoalLeft.Name = "pcbGoalLeft"
        Me.pcbGoalLeft.Size = New System.Drawing.Size(17, 92)
        Me.pcbGoalLeft.TabIndex = 0
        Me.pcbGoalLeft.TabStop = False
        '
        'pcbRightPad
        '
        Me.pcbRightPad.BackColor = System.Drawing.Color.Red
        Me.pcbRightPad.Location = New System.Drawing.Point(470, 141)
        Me.pcbRightPad.Name = "pcbRightPad"
        Me.pcbRightPad.Size = New System.Drawing.Size(35, 35)
        Me.pcbRightPad.TabIndex = 2
        Me.pcbRightPad.TabStop = False
        '
        'pcbLeftPad
        '
        Me.pcbLeftPad.BackColor = System.Drawing.Color.Blue
        Me.pcbLeftPad.Location = New System.Drawing.Point(99, 141)
        Me.pcbLeftPad.Name = "pcbLeftPad"
        Me.pcbLeftPad.Size = New System.Drawing.Size(35, 35)
        Me.pcbLeftPad.TabIndex = 3
        Me.pcbLeftPad.TabStop = False
        '
        'pcbGoalRight
        '
        Me.pcbGoalRight.BackColor = System.Drawing.Color.Black
        Me.pcbGoalRight.Location = New System.Drawing.Point(576, 117)
        Me.pcbGoalRight.Name = "pcbGoalRight"
        Me.pcbGoalRight.Size = New System.Drawing.Size(17, 92)
        Me.pcbGoalRight.TabIndex = 4
        Me.pcbGoalRight.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(296, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(5, 328)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'pcbBall
        '
        Me.pcbBall.BackColor = System.Drawing.Color.Black
        Me.pcbBall.Location = New System.Drawing.Point(281, 156)
        Me.pcbBall.Name = "pcbBall"
        Me.pcbBall.Size = New System.Drawing.Size(20, 20)
        Me.pcbBall.TabIndex = 6
        Me.pcbBall.TabStop = False
        '
        'lblRightScore
        '
        Me.lblRightScore.AutoSize = True
        Me.lblRightScore.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightScore.ForeColor = System.Drawing.Color.Black
        Me.lblRightScore.Location = New System.Drawing.Point(345, -1)
        Me.lblRightScore.Name = "lblRightScore"
        Me.lblRightScore.Size = New System.Drawing.Size(51, 54)
        Me.lblRightScore.TabIndex = 8
        Me.lblRightScore.Text = "0"
        '
        'lblLeftScore
        '
        Me.lblLeftScore.AutoSize = True
        Me.lblLeftScore.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftScore.ForeColor = System.Drawing.Color.Black
        Me.lblLeftScore.Location = New System.Drawing.Point(201, -1)
        Me.lblLeftScore.Name = "lblLeftScore"
        Me.lblLeftScore.Size = New System.Drawing.Size(51, 54)
        Me.lblLeftScore.TabIndex = 7
        Me.lblLeftScore.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 120
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(593, 326)
        Me.Controls.Add(Me.lblRightScore)
        Me.Controls.Add(Me.lblLeftScore)
        Me.Controls.Add(Me.pcbBall)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pcbGoalRight)
        Me.Controls.Add(Me.pcbLeftPad)
        Me.Controls.Add(Me.pcbRightPad)
        Me.Controls.Add(Me.pcbGoalLeft)
        Me.Name = "Form1"
        Me.Text = "Hockey"
        CType(Me.pcbGoalLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbRightPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbLeftPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbGoalRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbGoalLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pcbRightPad As System.Windows.Forms.PictureBox
    Friend WithEvents pcbLeftPad As System.Windows.Forms.PictureBox
    Friend WithEvents pcbGoalRight As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbBall As System.Windows.Forms.PictureBox
    Friend WithEvents lblRightScore As System.Windows.Forms.Label
    Friend WithEvents lblLeftScore As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
