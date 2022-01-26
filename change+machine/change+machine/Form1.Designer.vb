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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPennies = New System.Windows.Forms.TextBox
        Me.lblDollars = New System.Windows.Forms.TextBox
        Me.lblDimes = New System.Windows.Forms.TextBox
        Me.lblPennies = New System.Windows.Forms.TextBox
        Me.lblNickels = New System.Windows.Forms.TextBox
        Me.lblQuarters = New System.Windows.Forms.TextBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Pennies:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nickels"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dollars"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Pennies"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quarters"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dimes"
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(91, 6)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(100, 20)
        Me.txtPennies.TabIndex = 6
        '
        'lblDollars
        '
        Me.lblDollars.Location = New System.Drawing.Point(91, 42)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.ReadOnly = True
        Me.lblDollars.Size = New System.Drawing.Size(100, 20)
        Me.lblDollars.TabIndex = 7
        '
        'lblDimes
        '
        Me.lblDimes.Location = New System.Drawing.Point(91, 111)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.ReadOnly = True
        Me.lblDimes.Size = New System.Drawing.Size(100, 20)
        Me.lblDimes.TabIndex = 8
        '
        'lblPennies
        '
        Me.lblPennies.Location = New System.Drawing.Point(91, 186)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.ReadOnly = True
        Me.lblPennies.Size = New System.Drawing.Size(100, 20)
        Me.lblPennies.TabIndex = 9
        '
        'lblNickels
        '
        Me.lblNickels.Location = New System.Drawing.Point(91, 149)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.ReadOnly = True
        Me.lblNickels.Size = New System.Drawing.Size(100, 20)
        Me.lblNickels.TabIndex = 10
        '
        'lblQuarters
        '
        Me.lblQuarters.Location = New System.Drawing.Point(91, 77)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.ReadOnly = True
        Me.lblQuarters.Size = New System.Drawing.Size(100, 20)
        Me.lblQuarters.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 226)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(115, 226)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 261)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Change Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPennies As System.Windows.Forms.TextBox
    Friend WithEvents lblDollars As System.Windows.Forms.TextBox
    Friend WithEvents lblDimes As System.Windows.Forms.TextBox
    Friend WithEvents lblPennies As System.Windows.Forms.TextBox
    Friend WithEvents lblNickels As System.Windows.Forms.TextBox
    Friend WithEvents lblQuarters As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
