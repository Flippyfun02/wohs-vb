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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnLuckyNums = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.lblNums = New System.Windows.Forms.Label
        Me.Pick3 = New System.Windows.Forms.RadioButton
        Me.Pick4 = New System.Windows.Forms.RadioButton
        Me.Pick5 = New System.Windows.Forms.RadioButton
        Me.Pick6 = New System.Windows.Forms.RadioButton
        Me.txtMax = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnLuckyNums
        '
        Me.btnLuckyNums.Location = New System.Drawing.Point(135, 162)
        Me.btnLuckyNums.Name = "btnLuckyNums"
        Me.btnLuckyNums.Size = New System.Drawing.Size(86, 39)
        Me.btnLuckyNums.TabIndex = 0
        Me.btnLuckyNums.Text = "Get My Lucky Numbers"
        Me.btnLuckyNums.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(227, 162)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(44, 39)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblNums
        '
        Me.lblNums.AutoSize = True
        Me.lblNums.Location = New System.Drawing.Point(9, 213)
        Me.lblNums.Name = "lblNums"
        Me.lblNums.Size = New System.Drawing.Size(22, 13)
        Me.lblNums.TabIndex = 2
        Me.lblNums.Text = ". . ."
        '
        'Pick3
        '
        Me.Pick3.AutoSize = True
        Me.Pick3.Location = New System.Drawing.Point(12, 162)
        Me.Pick3.Name = "Pick3"
        Me.Pick3.Size = New System.Drawing.Size(31, 17)
        Me.Pick3.TabIndex = 3
        Me.Pick3.Text = "3"
        Me.Pick3.UseVisualStyleBackColor = True
        '
        'Pick4
        '
        Me.Pick4.AutoSize = True
        Me.Pick4.Location = New System.Drawing.Point(12, 184)
        Me.Pick4.Name = "Pick4"
        Me.Pick4.Size = New System.Drawing.Size(31, 17)
        Me.Pick4.TabIndex = 4
        Me.Pick4.Text = "4"
        Me.Pick4.UseVisualStyleBackColor = True
        '
        'Pick5
        '
        Me.Pick5.AutoSize = True
        Me.Pick5.Location = New System.Drawing.Point(49, 162)
        Me.Pick5.Name = "Pick5"
        Me.Pick5.Size = New System.Drawing.Size(31, 17)
        Me.Pick5.TabIndex = 5
        Me.Pick5.Text = "5"
        Me.Pick5.UseVisualStyleBackColor = True
        '
        'Pick6
        '
        Me.Pick6.AutoSize = True
        Me.Pick6.Checked = True
        Me.Pick6.Location = New System.Drawing.Point(49, 184)
        Me.Pick6.Name = "Pick6"
        Me.Pick6.Size = New System.Drawing.Size(31, 17)
        Me.Pick6.TabIndex = 6
        Me.Pick6.TabStop = True
        Me.Pick6.Text = "6"
        Me.Pick6.UseVisualStyleBackColor = True
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(87, 180)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(42, 20)
        Me.txtMax.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Max:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 241)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.Pick6)
        Me.Controls.Add(Me.Pick5)
        Me.Controls.Add(Me.Pick4)
        Me.Controls.Add(Me.Pick3)
        Me.Controls.Add(Me.lblNums)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnLuckyNums)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Lottery"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLuckyNums As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblNums As System.Windows.Forms.Label
    Friend WithEvents Pick3 As System.Windows.Forms.RadioButton
    Friend WithEvents Pick4 As System.Windows.Forms.RadioButton
    Friend WithEvents Pick5 As System.Windows.Forms.RadioButton
    Friend WithEvents Pick6 As System.Windows.Forms.RadioButton
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
