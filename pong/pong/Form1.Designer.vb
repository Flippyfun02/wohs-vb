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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pcbRightPad = New System.Windows.Forms.PictureBox
        Me.pcbLeftPad = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblLeftScore = New System.Windows.Forms.Label
        Me.lblRightScore = New System.Windows.Forms.Label
        Me.pcbBall = New System.Windows.Forms.PictureBox
        CType(Me.pcbRightPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbLeftPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'pcbRightPad
        '
        Me.pcbRightPad.BackColor = System.Drawing.Color.Red
        Me.pcbRightPad.Location = New System.Drawing.Point(564, 152)
        Me.pcbRightPad.Name = "pcbRightPad"
        Me.pcbRightPad.Size = New System.Drawing.Size(15, 59)
        Me.pcbRightPad.TabIndex = 0
        Me.pcbRightPad.TabStop = False
        '
        'pcbLeftPad
        '
        Me.pcbLeftPad.BackColor = System.Drawing.Color.Blue
        Me.pcbLeftPad.Location = New System.Drawing.Point(12, 152)
        Me.pcbLeftPad.Name = "pcbLeftPad"
        Me.pcbLeftPad.Size = New System.Drawing.Size(15, 59)
        Me.pcbLeftPad.TabIndex = 1
        Me.pcbLeftPad.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PictureBox1.Location = New System.Drawing.Point(290, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(3, 374)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblLeftScore
        '
        Me.lblLeftScore.AutoSize = True
        Me.lblLeftScore.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLeftScore.Location = New System.Drawing.Point(192, 9)
        Me.lblLeftScore.Name = "lblLeftScore"
        Me.lblLeftScore.Size = New System.Drawing.Size(51, 54)
        Me.lblLeftScore.TabIndex = 3
        Me.lblLeftScore.Text = "0"
        '
        'lblRightScore
        '
        Me.lblRightScore.AutoSize = True
        Me.lblRightScore.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRightScore.Location = New System.Drawing.Point(336, 9)
        Me.lblRightScore.Name = "lblRightScore"
        Me.lblRightScore.Size = New System.Drawing.Size(51, 54)
        Me.lblRightScore.TabIndex = 4
        Me.lblRightScore.Text = "0"
        '
        'pcbBall
        '
        Me.pcbBall.BackColor = System.Drawing.Color.White
        Me.pcbBall.Location = New System.Drawing.Point(290, 181)
        Me.pcbBall.Name = "pcbBall"
        Me.pcbBall.Size = New System.Drawing.Size(12, 12)
        Me.pcbBall.TabIndex = 5
        Me.pcbBall.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(591, 367)
        Me.Controls.Add(Me.pcbBall)
        Me.Controls.Add(Me.lblRightScore)
        Me.Controls.Add(Me.lblLeftScore)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pcbLeftPad)
        Me.Controls.Add(Me.pcbRightPad)
        Me.Name = "Form1"
        Me.Text = "Pong"
        CType(Me.pcbRightPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbLeftPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pcbRightPad As System.Windows.Forms.PictureBox
    Friend WithEvents pcbLeftPad As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLeftScore As System.Windows.Forms.Label
    Friend WithEvents lblRightScore As System.Windows.Forms.Label
    Friend WithEvents pcbBall As System.Windows.Forms.PictureBox

End Class
