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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSeconds = New System.Windows.Forms.Label
        Me.lblScore = New System.Windows.Forms.Label
        Me.btnMoleHole1 = New System.Windows.Forms.Button
        Me.btnMoleHole2 = New System.Windows.Forms.Button
        Me.btnMoleHole3 = New System.Windows.Forms.Button
        Me.btnMoleHole4 = New System.Windows.Forms.Button
        Me.btnMoleHole5 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(47, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(266, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 7
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSeconds.Location = New System.Drawing.Point(266, 230)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(10, 13)
        Me.lblSeconds.TabIndex = 8
        Me.lblSeconds.Text = " "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore.Location = New System.Drawing.Point(47, 230)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(10, 13)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = " "
        '
        'btnMoleHole1
        '
        Me.btnMoleHole1.Location = New System.Drawing.Point(50, 37)
        Me.btnMoleHole1.Name = "btnMoleHole1"
        Me.btnMoleHole1.Size = New System.Drawing.Size(89, 53)
        Me.btnMoleHole1.TabIndex = 10
        Me.btnMoleHole1.Text = " "
        Me.btnMoleHole1.UseVisualStyleBackColor = True
        '
        'btnMoleHole2
        '
        Me.btnMoleHole2.Location = New System.Drawing.Point(187, 37)
        Me.btnMoleHole2.Name = "btnMoleHole2"
        Me.btnMoleHole2.Size = New System.Drawing.Size(89, 53)
        Me.btnMoleHole2.TabIndex = 11
        Me.btnMoleHole2.Text = " "
        Me.btnMoleHole2.UseVisualStyleBackColor = True
        '
        'btnMoleHole3
        '
        Me.btnMoleHole3.Location = New System.Drawing.Point(311, 37)
        Me.btnMoleHole3.Name = "btnMoleHole3"
        Me.btnMoleHole3.Size = New System.Drawing.Size(89, 53)
        Me.btnMoleHole3.TabIndex = 12
        Me.btnMoleHole3.Text = " "
        Me.btnMoleHole3.UseVisualStyleBackColor = True
        '
        'btnMoleHole4
        '
        Me.btnMoleHole4.Location = New System.Drawing.Point(117, 116)
        Me.btnMoleHole4.Name = "btnMoleHole4"
        Me.btnMoleHole4.Size = New System.Drawing.Size(89, 53)
        Me.btnMoleHole4.TabIndex = 13
        Me.btnMoleHole4.Text = " "
        Me.btnMoleHole4.UseVisualStyleBackColor = True
        '
        'btnMoleHole5
        '
        Me.btnMoleHole5.Location = New System.Drawing.Point(250, 116)
        Me.btnMoleHole5.Name = "btnMoleHole5"
        Me.btnMoleHole5.Size = New System.Drawing.Size(89, 53)
        Me.btnMoleHole5.TabIndex = 14
        Me.btnMoleHole5.Text = " "
        Me.btnMoleHole5.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 271)
        Me.Controls.Add(Me.btnMoleHole5)
        Me.Controls.Add(Me.btnMoleHole4)
        Me.Controls.Add(Me.btnMoleHole3)
        Me.Controls.Add(Me.btnMoleHole2)
        Me.Controls.Add(Me.btnMoleHole1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Whack A Mole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnMoleHole1 As System.Windows.Forms.Button
    Friend WithEvents btnMoleHole2 As System.Windows.Forms.Button
    Friend WithEvents btnMoleHole3 As System.Windows.Forms.Button
    Friend WithEvents btnMoleHole4 As System.Windows.Forms.Button
    Friend WithEvents btnMoleHole5 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
