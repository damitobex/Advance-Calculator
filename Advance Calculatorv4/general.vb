Public Class General
    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Dim n As Int32

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button3.Click, Button2.Click, Button19.Click, Button15.Click, Button14.Click, Button13.Click, Button21.Click
        Dim b As Button = sender
        If Label1.Text = "0" Then
            Label1.Text = b.Text
        Else
            Label1.Text = Label1.Text + b.Text

        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Label1.Text = "0"
        Label3.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Label1.Text = "0"
        Label3.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub arithmetic_function(sender As Object, e As EventArgs) Handles Button4.Click, Button6.Click, Button24.Click, Button22.Click, Button16.Click, Button10.Click
        Dim ops As Button = sender
        f = Label1.Text
        Label3.Text = Label1.Text
        Label1.Text = ""
        op = ops.Text
        Label3.Text = Label3.Text + " " + op

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        s = Label1.Text
        If op = "+" Then
            a = f + s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "-" Then
            a = f - s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "*" Then
            a = f * s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "/" Then
            a = f / s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "Mod" Then
            a = f Mod s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "Exp" Then
            a = f ^ s
            Label1.Text = a
            Label3.Text = ""
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Int32.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 2)
        Else
            Label1.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a = Math.Sin(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        a = Math.Cos(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        a = Math.Tan(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        a = Math.Log(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Height = 435
        Me.Width = 399
        Button26.Width = 238
        Label1.Width = 355
    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitConversionToolStripMenuItem.Click
        Me.Height = 435
        Me.Width = 671
        Button26.Width = 238
        Label1.Width = 355
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Height = 435
        Me.Width = 272
        Button26.Width = 112
        Label1.Width = 229
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Label2.Text = ""
        TextBox1.Text = ""

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim convt As Double
        If ComboBox1.Text = "Celsius to Fahrenheit" Then
            convt = (9 / 5 * TextBox1.Text) + 32
            Label2.Text = (convt) & "Fahrenheit"
        ElseIf ComboBox1.Text = "Fahrenheit to Celsius" Then
            convt = 5 / 9 * (TextBox1.Text) - 32
            Label2.Text = convt & "Celsius"
        ElseIf ComboBox1.Text = "Kilometres to Miles" Then
            convt = (TextBox1.Text / 1.609344)
            Label2.Text = convt & " Miles"
        ElseIf ComboBox1.Text = "Miles to Kilometres" Then
            convt = (TextBox1.Text * 1.609344)
            Label2.Text = convt & "Kilometres"
        End If
    End Sub
    Private Sub general_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose One....."
        ComboBox1.Items.Add("Celsuis to fahrenheit")
        ComboBox1.Items.Add("Fahrenheit to Celsius")
        ComboBox1.Items.Add("Miles to Kilometers")
        ComboBox1.Items.Add("Kilometers to Miles")
        ComboBox1.Items.Add("Centimeter to Metres")

    End Sub

End Class