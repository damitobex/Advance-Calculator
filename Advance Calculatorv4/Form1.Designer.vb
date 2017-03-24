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
        Me.RadioButtonPolynomial = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLinear = New System.Windows.Forms.RadioButton()
        Me.LabelPP = New System.Windows.Forms.Label()
        Me.textBoxNum = New System.Windows.Forms.TextBox()
        Me.buttonOK = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RadioButtonPolynomial
        '
        Me.RadioButtonPolynomial.AutoSize = True
        Me.RadioButtonPolynomial.Location = New System.Drawing.Point(12, 64)
        Me.RadioButtonPolynomial.Name = "RadioButtonPolynomial"
        Me.RadioButtonPolynomial.Size = New System.Drawing.Size(118, 17)
        Me.RadioButtonPolynomial.TabIndex = 0
        Me.RadioButtonPolynomial.TabStop = True
        Me.RadioButtonPolynomial.Text = "Poynomial Equation"
        Me.RadioButtonPolynomial.UseVisualStyleBackColor = True
        '
        'RadioButtonLinear
        '
        Me.RadioButtonLinear.AutoSize = True
        Me.RadioButtonLinear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButtonLinear.Location = New System.Drawing.Point(12, 41)
        Me.RadioButtonLinear.Name = "RadioButtonLinear"
        Me.RadioButtonLinear.Size = New System.Drawing.Size(133, 17)
        Me.RadioButtonLinear.TabIndex = 0
        Me.RadioButtonLinear.TabStop = True
        Me.RadioButtonLinear.Text = "Simultaneous Equation"
        Me.RadioButtonLinear.UseVisualStyleBackColor = True
        '
        'LabelPP
        '
        Me.LabelPP.AutoSize = True
        Me.LabelPP.Location = New System.Drawing.Point(41, 146)
        Me.LabelPP.Name = "LabelPP"
        Me.LabelPP.Size = New System.Drawing.Size(39, 13)
        Me.LabelPP.TabIndex = 1
        Me.LabelPP.Text = "Label1"
        '
        'textBoxNum
        '
        Me.textBoxNum.Location = New System.Drawing.Point(168, 143)
        Me.textBoxNum.Multiline = True
        Me.textBoxNum.Name = "textBoxNum"
        Me.textBoxNum.Size = New System.Drawing.Size(23, 20)
        Me.textBoxNum.TabIndex = 2
        '
        'buttonOK
        '
        Me.buttonOK.Location = New System.Drawing.Point(99, 193)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(75, 23)
        Me.buttonOK.TabIndex = 3
        Me.buttonOK.Text = "OK"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.Location = New System.Drawing.Point(180, 193)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(75, 23)
        Me.buttonExit.TabIndex = 3
        Me.buttonExit.Text = "Exit"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 247)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.textBoxNum)
        Me.Controls.Add(Me.LabelPP)
        Me.Controls.Add(Me.RadioButtonLinear)
        Me.Controls.Add(Me.RadioButtonPolynomial)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButtonPolynomial As RadioButton
    Friend WithEvents RadioButtonLinear As RadioButton
    Friend WithEvents LabelPP As Label
    Friend WithEvents textBoxNum As TextBox
    Private WithEvents buttonOK As Button
    Private WithEvents buttonExit As Button
End Class
