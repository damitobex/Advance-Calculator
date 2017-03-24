Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class LinearEquationForm

    Private textBoxArray As TextBox(,)
    Private ansTextBoxArray As TextBox()
    'private int noOfUnknowns;
    Friend WithEvents buttonOK As Button, buttonCancel As Button
    Public Property KPlinear As Object

    Public Sub New(ByVal num As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LoadInputLabelsTextBoxes(num)
        LoadButtons(num)
    End Sub

    Private Sub LinearEquationForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        'LoadInputLabelsTextBoxes(noOfUnknowns);
    End Sub

    Private Sub LoadInputLabelsTextBoxes(ByVal num As Integer)
        Dim stPt As New Point(25, 50)
        Const gapLT As Integer = 20, gapTL As Integer = 0
        Const lableLength As Integer = 30, txtBoxLength As Integer = 40
        Const gapRow As Integer = 40
        'Labels and TextBoxes for Giving inputs
        textBoxArray = New TextBox(num - 1, num) {}
        ansTextBoxArray = New TextBox(num - 1) {}

        Dim tGapX As Integer = txtBoxLength + gapTL + lableLength + gapLT

        For i As Integer = 0 To num - 1
            For j As Integer = 0 To num
                'Create TextBox
                Dim textBox(num) As TextBox
                textBox(j) = New TextBox()
                textBox(j).Location = New Point(stPt.X + tGapX * j, stPt.Y + i * gapRow)
                textBox(j).Size = New Size(txtBoxLength, 20)
                textBox(j).Text = "0"


                KPlinear.Controls.Add(textBox(j))
                textBoxArray(i, j) = textBox(j)

                'Create Lable
                Dim label As New Label()
                label.Location = New Point(stPt.X + lableLength + gapLT + tGapX * j, 3 + stPt.Y + i * gapRow)
                label.Size = New Size(lableLength, 13)
                label.BackColor = Color.FromArgb(&HBB, &HCE, &HE6)
                If j < num - 1 Then
                    label.Text = String.Format("X{0} +", j + 1)
                ElseIf j = num - 1 Then
                    label.Text = String.Format("X{0} =", j + 1)
                Else
                    Continue For
                End If

                KPlinear.Controls.Add(label)
            Next

            'Create TextBox for Answers
            Dim txtBox(num) As TextBox
            txtBox(i) = New TextBox()
            txtBox(i).Location = New Point(stPt.X + lableLength + gapTL + tGapX * i, stPt.Y + (num + 2) * gapRow)
            txtBox(i).Size = New Size(txtBoxLength + 20, 20)
            txtBox(i).[ReadOnly] = True

            KPlinear.Controls.Add(txtBox(i))
            ansTextBoxArray(i) = txtBox(i)

            'Create Lable for answer
            Dim lbl As New Label()
            lbl.Location = New Point(stPt.X + tGapX * i, 3 + stPt.Y + (num + 2) * gapRow)
            lbl.Size = New Size(lableLength, 13)
            lbl.Text = String.Format("X{0} =", i + 1)
            lbl.BackColor = Color.FromArgb(&HBB, &HCE, &HE6)

            KPlinear.Controls.Add(lbl)
        Next

        KPlinear.Size = New Size(stPt.X + tGapX * (num + 1), 170 + stPt.Y + num * gapRow)
    End Sub

    Private Sub LoadButtons(ByVal num As Integer)
        Dim lenX As Integer = 90, lenY As Integer = 40
        buttonOK = New Button()
        buttonOK.Location = New Point(-70 + (num - 1) * lenX, 25 + (num + 1) * lenY)
        buttonOK.Size = New Size(75, 23)
        buttonOK.Text = "Calculate"


        buttonCancel = New Button()
        buttonCancel.Location = New Point(-70 + num * lenX, 25 + (num + 1) * lenY)
        buttonCancel.Size = New Size(75, 23)
        buttonCancel.Text = "Cancel"


        KPlinear.Controls.Add(buttonOK)
        KPlinear.Controls.Add(buttonCancel)
    End Sub

    Private Sub buttonOK_Clicked(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
        Dim length As Integer = textBoxArray.GetLength(0)
        Dim equMatrix As Double(,) = New Double(length - 1, length) {}

        For i As Integer = 0 To length - 1
            For j As Integer = 0 To length
                Try
                    Dim val As Double = [Double].Parse(textBoxArray(i, j).Text)
                    equMatrix(i, j) = val
                Catch ex As FormatException
                End Try
            Next
        Next

        Try
            Dim x As New SolveEquations
            Dim ans As Double() = x.SolveLinearEquation(equMatrix)

            For i As Integer = 0 To length - 1
                ansTextBoxArray(i).Text = ans(i).ToString()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LinearEquationForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonCancel_Clicked(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
        Me.Close()
    End Sub


End Class