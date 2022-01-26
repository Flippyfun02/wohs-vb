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
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.txt4 = New System.Windows.Forms.TextBox
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.sem1 = New System.Windows.Forms.RadioButton
        Me.sem2 = New System.Windows.Forms.RadioButton
        Me.fullYear = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(261, 169)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(346, 169)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MP1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MP2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MP3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MP4"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(33, 82)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 6
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(153, 82)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 7
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(395, 82)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(100, 20)
        Me.txt4.TabIndex = 8
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(277, 82)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 20)
        Me.txt3.TabIndex = 9
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(33, 169)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(220, 20)
        Me.txtResult.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Result"
        '
        'sem1
        '
        Me.sem1.AutoSize = True
        Me.sem1.Checked = True
        Me.sem1.Location = New System.Drawing.Point(36, 27)
        Me.sem1.Name = "sem1"
        Me.sem1.Size = New System.Drawing.Size(78, 17)
        Me.sem1.TabIndex = 12
        Me.sem1.TabStop = True
        Me.sem1.Text = "Semester 1"
        Me.sem1.UseVisualStyleBackColor = True
        '
        'sem2
        '
        Me.sem2.AutoSize = True
        Me.sem2.Location = New System.Drawing.Point(153, 27)
        Me.sem2.Name = "sem2"
        Me.sem2.Size = New System.Drawing.Size(78, 17)
        Me.sem2.TabIndex = 13
        Me.sem2.Text = "Semester 2"
        Me.sem2.UseVisualStyleBackColor = True
        '
        'fullYear
        '
        Me.fullYear.AutoSize = True
        Me.fullYear.Location = New System.Drawing.Point(277, 27)
        Me.fullYear.Name = "fullYear"
        Me.fullYear.Size = New System.Drawing.Size(66, 17)
        Me.fullYear.TabIndex = 14
        Me.fullYear.Text = "Full Year"
        Me.fullYear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 261)
        Me.Controls.Add(Me.fullYear)
        Me.Controls.Add(Me.sem2)
        Me.Controls.Add(Me.sem1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sem1 As System.Windows.Forms.RadioButton
    Friend WithEvents sem2 As System.Windows.Forms.RadioButton
    Friend WithEvents fullYear As System.Windows.Forms.RadioButton

End Class
