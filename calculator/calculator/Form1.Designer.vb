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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFirstNum = New System.Windows.Forms.TextBox
        Me.txtSecondNum = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSubtract = New System.Windows.Forms.Button
        Me.btnMultiply = New System.Windows.Forms.Button
        Me.btnDivide = New System.Windows.Forms.Button
        Me.btnDivideInt = New System.Windows.Forms.Button
        Me.btnMod = New System.Windows.Forms.Button
        Me.btnExponent = New System.Windows.Forms.Button
        Me.lblResultN = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblResultP0 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblResultN1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblResultE = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblResultC = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblResultP = New System.Windows.Forms.Label
        Me.lblResultC1 = New System.Windows.Forms.Label
        Me.lblResultN0 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblResultP1 = New System.Windows.Forms.Label
        Me.lblResultN3 = New System.Windows.Forms.Label
        Me.lblResultC3 = New System.Windows.Forms.Label
        Me.lblResultE0 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblResultE3 = New System.Windows.Forms.Label
        Me.lblResultP3 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lblResultC0 = New System.Windows.Forms.Label
        Me.lblResultE1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter 1st Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter 2nd Number:"
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Location = New System.Drawing.Point(12, 36)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNum.TabIndex = 2
        '
        'txtSecondNum
        '
        Me.txtSecondNum.Location = New System.Drawing.Point(154, 36)
        Me.txtSecondNum.Name = "txtSecondNum"
        Me.txtSecondNum.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondNum.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Choose an operation"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 109)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(55, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(73, 109)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(55, 23)
        Me.btnSubtract.TabIndex = 6
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(133, 109)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(55, 23)
        Me.btnMultiply.TabIndex = 7
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(194, 109)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(55, 23)
        Me.btnDivide.TabIndex = 8
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnDivideInt
        '
        Me.btnDivideInt.Location = New System.Drawing.Point(255, 109)
        Me.btnDivideInt.Name = "btnDivideInt"
        Me.btnDivideInt.Size = New System.Drawing.Size(55, 23)
        Me.btnDivideInt.TabIndex = 9
        Me.btnDivideInt.Text = "\"
        Me.btnDivideInt.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(316, 109)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(55, 23)
        Me.btnMod.TabIndex = 10
        Me.btnMod.Text = "MOD"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnExponent
        '
        Me.btnExponent.Location = New System.Drawing.Point(377, 109)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(55, 23)
        Me.btnExponent.TabIndex = 11
        Me.btnExponent.Text = "^"
        Me.btnExponent.UseVisualStyleBackColor = True
        '
        'lblResultN
        '
        Me.lblResultN.AutoSize = True
        Me.lblResultN.Location = New System.Drawing.Point(97, 176)
        Me.lblResultN.Name = "lblResultN"
        Me.lblResultN.Size = New System.Drawing.Size(10, 13)
        Me.lblResultN.TabIndex = 12
        Me.lblResultN.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Results"
        '
        'lblResultP0
        '
        Me.lblResultP0.AutoSize = True
        Me.lblResultP0.Location = New System.Drawing.Point(265, 198)
        Me.lblResultP0.Name = "lblResultP0"
        Me.lblResultP0.Size = New System.Drawing.Size(10, 13)
        Me.lblResultP0.TabIndex = 14
        Me.lblResultP0.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "1 decimal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "No Decimal"
        '
        'lblResultN1
        '
        Me.lblResultN1.AutoSize = True
        Me.lblResultN1.Location = New System.Drawing.Point(97, 222)
        Me.lblResultN1.Name = "lblResultN1"
        Me.lblResultN1.Size = New System.Drawing.Size(10, 13)
        Me.lblResultN1.TabIndex = 17
        Me.lblResultN1.Text = " "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "3 decimals"
        '
        'lblResultE
        '
        Me.lblResultE.AutoSize = True
        Me.lblResultE.Location = New System.Drawing.Point(353, 176)
        Me.lblResultE.Name = "lblResultE"
        Me.lblResultE.Size = New System.Drawing.Size(10, 13)
        Me.lblResultE.TabIndex = 19
        Me.lblResultE.Text = " "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Default"
        '
        'lblResultC
        '
        Me.lblResultC.AutoSize = True
        Me.lblResultC.Location = New System.Drawing.Point(179, 176)
        Me.lblResultC.Name = "lblResultC"
        Me.lblResultC.Size = New System.Drawing.Size(10, 13)
        Me.lblResultC.TabIndex = 21
        Me.lblResultC.Text = " "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(97, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "n Format"
        '
        'lblResultP
        '
        Me.lblResultP.AutoSize = True
        Me.lblResultP.Location = New System.Drawing.Point(265, 176)
        Me.lblResultP.Name = "lblResultP"
        Me.lblResultP.Size = New System.Drawing.Size(10, 13)
        Me.lblResultP.TabIndex = 23
        Me.lblResultP.Text = " "
        '
        'lblResultC1
        '
        Me.lblResultC1.AutoSize = True
        Me.lblResultC1.Location = New System.Drawing.Point(179, 222)
        Me.lblResultC1.Name = "lblResultC1"
        Me.lblResultC1.Size = New System.Drawing.Size(10, 13)
        Me.lblResultC1.TabIndex = 24
        Me.lblResultC1.Text = " "
        '
        'lblResultN0
        '
        Me.lblResultN0.AutoSize = True
        Me.lblResultN0.Location = New System.Drawing.Point(97, 198)
        Me.lblResultN0.Name = "lblResultN0"
        Me.lblResultN0.Size = New System.Drawing.Size(10, 13)
        Me.lblResultN0.TabIndex = 25
        Me.lblResultN0.Text = " "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(353, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "e Format"
        '
        'lblResultP1
        '
        Me.lblResultP1.AutoSize = True
        Me.lblResultP1.Location = New System.Drawing.Point(265, 222)
        Me.lblResultP1.Name = "lblResultP1"
        Me.lblResultP1.Size = New System.Drawing.Size(10, 13)
        Me.lblResultP1.TabIndex = 27
        Me.lblResultP1.Text = " "
        '
        'lblResultN3
        '
        Me.lblResultN3.AutoSize = True
        Me.lblResultN3.Location = New System.Drawing.Point(97, 245)
        Me.lblResultN3.Name = "lblResultN3"
        Me.lblResultN3.Size = New System.Drawing.Size(10, 13)
        Me.lblResultN3.TabIndex = 28
        Me.lblResultN3.Text = " "
        '
        'lblResultC3
        '
        Me.lblResultC3.AutoSize = True
        Me.lblResultC3.Location = New System.Drawing.Point(179, 245)
        Me.lblResultC3.Name = "lblResultC3"
        Me.lblResultC3.Size = New System.Drawing.Size(10, 13)
        Me.lblResultC3.TabIndex = 29
        Me.lblResultC3.Text = " "
        '
        'lblResultE0
        '
        Me.lblResultE0.AutoSize = True
        Me.lblResultE0.Location = New System.Drawing.Point(353, 198)
        Me.lblResultE0.Name = "lblResultE0"
        Me.lblResultE0.Size = New System.Drawing.Size(10, 13)
        Me.lblResultE0.TabIndex = 30
        Me.lblResultE0.Text = " "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(179, 152)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "c Format"
        '
        'lblResultE3
        '
        Me.lblResultE3.AutoSize = True
        Me.lblResultE3.Location = New System.Drawing.Point(353, 245)
        Me.lblResultE3.Name = "lblResultE3"
        Me.lblResultE3.Size = New System.Drawing.Size(10, 13)
        Me.lblResultE3.TabIndex = 32
        Me.lblResultE3.Text = " "
        '
        'lblResultP3
        '
        Me.lblResultP3.AutoSize = True
        Me.lblResultP3.Location = New System.Drawing.Point(265, 245)
        Me.lblResultP3.Name = "lblResultP3"
        Me.lblResultP3.Size = New System.Drawing.Size(10, 13)
        Me.lblResultP3.TabIndex = 33
        Me.lblResultP3.Text = " "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(265, 152)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 13)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "p Format"
        '
        'lblResultC0
        '
        Me.lblResultC0.AutoSize = True
        Me.lblResultC0.Location = New System.Drawing.Point(179, 198)
        Me.lblResultC0.Name = "lblResultC0"
        Me.lblResultC0.Size = New System.Drawing.Size(10, 13)
        Me.lblResultC0.TabIndex = 35
        Me.lblResultC0.Text = " "
        '
        'lblResultE1
        '
        Me.lblResultE1.AutoSize = True
        Me.lblResultE1.Location = New System.Drawing.Point(353, 222)
        Me.lblResultE1.Name = "lblResultE1"
        Me.lblResultE1.Size = New System.Drawing.Size(10, 13)
        Me.lblResultE1.TabIndex = 36
        Me.lblResultE1.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 290)
        Me.Controls.Add(Me.lblResultE1)
        Me.Controls.Add(Me.lblResultC0)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lblResultP3)
        Me.Controls.Add(Me.lblResultE3)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblResultE0)
        Me.Controls.Add(Me.lblResultC3)
        Me.Controls.Add(Me.lblResultN3)
        Me.Controls.Add(Me.lblResultP1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblResultN0)
        Me.Controls.Add(Me.lblResultC1)
        Me.Controls.Add(Me.lblResultP)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblResultC)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblResultE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblResultN1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblResultP0)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblResultN)
        Me.Controls.Add(Me.btnExponent)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnDivideInt)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSecondNum)
        Me.Controls.Add(Me.txtFirstNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Simple Caluclator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirstNum As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnDivideInt As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnExponent As System.Windows.Forms.Button
    Friend WithEvents lblResultN As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblResultP0 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblResultN1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblResultE As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblResultC As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblResultP As System.Windows.Forms.Label
    Friend WithEvents lblResultC1 As System.Windows.Forms.Label
    Friend WithEvents lblResultN0 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblResultP1 As System.Windows.Forms.Label
    Friend WithEvents lblResultN3 As System.Windows.Forms.Label
    Friend WithEvents lblResultC3 As System.Windows.Forms.Label
    Friend WithEvents lblResultE0 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblResultE3 As System.Windows.Forms.Label
    Friend WithEvents lblResultP3 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblResultC0 As System.Windows.Forms.Label
    Friend WithEvents lblResultE1 As System.Windows.Forms.Label

End Class
