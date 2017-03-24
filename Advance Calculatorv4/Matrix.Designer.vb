<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matrix
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Show Matrix"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(144, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(275, 35)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "New Matrix"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 35)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Adding with Matrix"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(374, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 35)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Subtracting with Matrix"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 130)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(175, 35)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Multilying by Matrix"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(193, 130)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(175, 35)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Multuply by Scalar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(374, 130)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(175, 35)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Divid by Scalar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 182)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(175, 35)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Tranpose"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(193, 182)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(175, 35)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Determinant"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(374, 182)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(175, 35)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "Inverse"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Matrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 353)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Matrix"
        Me.Text = "Matrix"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
