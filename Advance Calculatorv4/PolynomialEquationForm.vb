Public Class PolynomialEquationForm
    Private numba As Integer
    Private textBoxArray As TextBox()
    Private ansTextBoxArray As TextBox()
    Friend WithEvents buttonOK As Button, buttonCancel As Button
    Public Property KPpoly As Object

    Public Sub New(ByVal num As Integer)
        InitializeComponent()

        LoadInputLabelsTextBoxes(num)
        LoadButtons(num)
    End Sub

    Private Sub LoadInputLabelsTextBoxes(ByVal num As Integer)
        Dim stPt As New Point(25, 50)
        Const gapLT As Integer = 10, gapTL As Integer = 0
        Const lableLength As Integer = 40, txtBoxLength As Integer = 40

        'Labels and TextBoxes for Giving inputs
        textBoxArray = New TextBox(num) {}
        ansTextBoxArray = New TextBox(num - 1) {}

        Dim tGapX As Integer = txtBoxLength + lableLength
        For i As Integer = 0 To num
            'int tGapX = txtBoxLength + lableLength;

            'Create TextBox
            Dim textBox(num + 1) As TextBox
            textBox(i) = New TextBox()
            textBox(i).Location = New Point(stPt.X + tGapX * i, stPt.Y)
            textBox(i).Size = New Size(txtBoxLength, 20)
            textBox(i).Text = "0"

            KPpoly.Controls.Add(textBox(i))
            textBoxArray(i) = textBox(i)

            'Create Lable
            Dim label As New Label()
            label.Location = New Point(stPt.X + txtBoxLength + tGapX * i, 3 + stPt.Y)
            label.Size = New Size(lableLength, 13)
            label.BackColor = Color.FromArgb(&HBB, &HCE, &HE6)


            If i < num Then
                label.Text = String.Format("X^{0} +", num - i)
            Else
                label.Text = " = 0"
            End If


            KPpoly.Controls.Add(label)
        Next

        tGapX += gapLT + 10
        For i As Integer = 0 To num - 1
            'int tGapX = txtBoxLength + lableLength + gapLT;

            'Create TextBox for Answers
            Dim txtBox(num) As TextBox
            txtBox(i) = New TextBox()
            txtBox(i).Location = New Point(stPt.X + lableLength - 10 + tGapX * i, stPt.Y + 100)
            txtBox(i).Size = New Size(txtBoxLength + 20, 20)
            txtBox(i).[ReadOnly] = True
            KPpoly.Controls.Add(txtBox(i))
            ansTextBoxArray(i) = txtBox(i)

            'Create Lable for answer
            Dim lbl As New Label()
            lbl.Location = New Point(stPt.X + tGapX * i, 3 + stPt.Y + 100)
            lbl.Size = New Size(lableLength - 10, 13)
            lbl.Text = String.Format("X{0} =", i + 1)
            lbl.BackColor = Color.FromArgb(&HBB, &HCE, &HE6)

            KPpoly.Controls.Add(lbl)
        Next
        '+ txtBoxLength
        Me.Size = New Size(2 * stPt.X + num * tGapX, 250)

    End Sub

    Private Sub LoadButtons(ByVal num As Integer)
        Dim lenX As Integer = 90
        buttonOK = New Button()
        buttonOK.Location = New Point(-70 + (num - 1) * lenX, 100)
        buttonOK.Size = New Size(75, 23)
        buttonOK.Text = "Calculate"


        buttonCancel = New Button()
        buttonCancel.Location = New Point(-70 + num * lenX, 100)
        buttonCancel.Size = New Size(75, 23)
        buttonCancel.Text = "Cancel"

        KPpoly.Controls.Add(buttonOK)
        KPpoly.Controls.Add(buttonCancel)
    End Sub
    Private Sub buttonOK_Clicked(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
        Dim coeff As New List(Of Double)()
        For i As Integer = 0 To textBoxArray.GetLength(0) - 1
            Try
                Dim val As Double = [Double].Parse(textBoxArray(i).Text)
                coeff.Add(val)
            Catch ex As FormatException
                MessageBox.Show(ex.Message)
            End Try
        Next

        Try
            Dim c As New SolveEquations
            Dim ans As List(Of Double) = c.SolvePolynomialEquation(coeff)

            For i As Integer = 0 To ans.Count - 1
                ansTextBoxArray(i).Text = ans(i).ToString()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub buttonCancel_Clicked(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
        Me.Close()
    End Sub

    Private Sub PolynomialEquationForm_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
End Class