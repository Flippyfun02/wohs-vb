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
        Me.radRange10 = New System.Windows.Forms.RadioButton
        Me.radRange100 = New System.Windows.Forms.RadioButton
        Me.radRange1000 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGuess = New System.Windows.Forms.TextBox
        Me.btnCheck = New System.Windows.Forms.Button
        Me.btnNewGame = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFeedback = New System.Windows.Forms.TextBox
        Me.txtGamesWon = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtAverage = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGuesses = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radRange10
        '
        Me.radRange10.AutoSize = True
        Me.radRange10.Checked = True
        Me.radRange10.Location = New System.Drawing.Point(21, 19)
        Me.radRange10.Name = "radRange10"
        Me.radRange10.Size = New System.Drawing.Size(81, 17)
        Me.radRange10.TabIndex = 1
        Me.radRange10.TabStop = True
        Me.radRange10.Text = "Range 1-10"
        Me.radRange10.UseVisualStyleBackColor = True
        '
        'radRange100
        '
        Me.radRange100.AutoSize = True
        Me.radRange100.Location = New System.Drawing.Point(21, 43)
        Me.radRange100.Name = "radRange100"
        Me.radRange100.Size = New System.Drawing.Size(99, 17)
        Me.radRange100.TabIndex = 2
        Me.radRange100.Text = "Range 1 to 100"
        Me.radRange100.UseVisualStyleBackColor = True
        '
        'radRange1000
        '
        Me.radRange1000.AutoSize = True
        Me.radRange1000.Location = New System.Drawing.Point(21, 67)
        Me.radRange1000.Name = "radRange1000"
        Me.radRange1000.Size = New System.Drawing.Size(105, 17)
        Me.radRange1000.TabIndex = 3
        Me.radRange1000.Text = "Range 1 to 1000"
        Me.radRange1000.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Guess:"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(264, 50)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.ReadOnly = True
        Me.txtGuess.Size = New System.Drawing.Size(96, 20)
        Me.txtGuess.TabIndex = 5
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(193, 77)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 6
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(285, 77)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGame.TabIndex = 7
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No. of Games Won:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Feedback and Results"
        '
        'txtFeedback
        '
        Me.txtFeedback.Location = New System.Drawing.Point(193, 150)
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.ReadOnly = True
        Me.txtFeedback.Size = New System.Drawing.Size(167, 20)
        Me.txtFeedback.TabIndex = 11
        '
        'txtGamesWon
        '
        Me.txtGamesWon.Location = New System.Drawing.Point(113, 19)
        Me.txtGamesWon.Name = "txtGamesWon"
        Me.txtGamesWon.ReadOnly = True
        Me.txtGamesWon.Size = New System.Drawing.Size(23, 20)
        Me.txtGamesWon.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radRange10)
        Me.GroupBox1.Controls.Add(Me.radRange100)
        Me.GroupBox1.Controls.Add(Me.radRange1000)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 88)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Range"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAverage)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtGuesses)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtGamesWon)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 107)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Score"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(113, 76)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(23, 20)
        Me.txtAverage.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Avg. No. of Guesses:"
        '
        'txtGuesses
        '
        Me.txtGuesses.Location = New System.Drawing.Point(113, 48)
        Me.txtGuesses.Name = "txtGuesses"
        Me.txtGuesses.ReadOnly = True
        Me.txtGuesses.Size = New System.Drawing.Size(23, 20)
        Me.txtGuesses.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No. of Guesses Left:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 239)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmMain"
        Me.Text = "Guess A Number"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radRange10 As System.Windows.Forms.RadioButton
    Friend WithEvents radRange100 As System.Windows.Forms.RadioButton
    Friend WithEvents radRange1000 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFeedback As System.Windows.Forms.TextBox
    Friend WithEvents txtGamesWon As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGuesses As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
