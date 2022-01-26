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
        Me.txtUserNum = New System.Windows.Forms.TextBox
        Me.btnEnter = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFeedback = New System.Windows.Forms.TextBox
        Me.lstFactors = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtUserNum
        '
        Me.txtUserNum.Location = New System.Drawing.Point(29, 30)
        Me.txtUserNum.Name = "txtUserNum"
        Me.txtUserNum.Size = New System.Drawing.Size(100, 20)
        Me.txtUserNum.TabIndex = 0
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(143, 28)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Feedback:"
        '
        'txtFeedback
        '
        Me.txtFeedback.Location = New System.Drawing.Point(90, 57)
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.ReadOnly = True
        Me.txtFeedback.Size = New System.Drawing.Size(128, 20)
        Me.txtFeedback.TabIndex = 3
        '
        'lstFactors
        '
        Me.lstFactors.FormattingEnabled = True
        Me.lstFactors.Location = New System.Drawing.Point(29, 100)
        Me.lstFactors.Name = "lstFactors"
        Me.lstFactors.Size = New System.Drawing.Size(189, 95)
        Me.lstFactors.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Factors:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 222)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstFactors)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtUserNum)
        Me.Name = "Form1"
        Me.Text = "Prime Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserNum As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFeedback As System.Windows.Forms.TextBox
    Friend WithEvents lstFactors As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
