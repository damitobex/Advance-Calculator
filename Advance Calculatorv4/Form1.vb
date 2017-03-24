Imports System.Text.RegularExpressions
Imports SolveEquationVB.PolynomialEquationForm
Public Class Form1

    Private x As PolynomialEquationForm
    Public numba As Integer

    Public Sub form1()
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, e As EventArgs) Handles RadioButtonPolynomial.CheckedChanged
        LabelPP.Text = "Input Order of the Equation"
        textBoxNum.Location = New Point(159, 103)
    End Sub

    Private Sub RadioButtonLinear_CheckedChanged(ByVal sender As System.Object, e As EventArgs) Handles RadioButtonLinear.CheckedChanged
        LabelPP.Text = "Input No of unknowns"
        textBoxNum.Location = New Point(139, 103)

    End Sub

    Private Sub LabelPP_Click(ByVal sender As System.Object, e As EventArgs) Handles LabelPP.Click

    End Sub

    Private Sub textBoxNum_TextChanged(ByVal sender As System.Object, e As EventArgs) Handles textBoxNum.TextChanged
        If textBoxNum.Text <> "" Then
            buttonOK.Enabled = True
        Else
            buttonOK.Enabled = False
        End If
    End Sub

    Private Sub buttonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonOK.Click
        Try

            numba = Int16.Parse(textBoxNum.Text)

            If numba > 1 Then

                If numba <= 10 Then

                    If RadioButtonLinear.Checked Then
                        Dim l As New LinearEquationForm(numba)
                        l.StartPosition = FormStartPosition.CenterScreen
                        l.Show()
                    Else
                        Dim p As New PolynomialEquationForm(numba)
                        p.StartPosition = FormStartPosition.CenterScreen
                        p.Show()

                    End If

                Else
                    MessageBox.Show("No of unknowns are too high")
                End If

            Else
                MessageBox.Show("No of unknowns are not enough to solve")
            End If

        Catch ex As InvalidCastException
            MessageBox.Show(ex.Message)
        End Try
        Try

            numba = Int16.Parse(textBoxNum.Text)

            If numba > 1 Then

                If numba <= 10 Then

                    If RadioButtonLinear.Checked Then
                        Dim l As New LinearEquationForm(numba)
                        l.StartPosition = FormStartPosition.CenterScreen
                        l.Show()
                    Else
                        Dim p As New PolynomialEquationForm(numba)
                        p.StartPosition = FormStartPosition.CenterScreen
                        p.Show()

                    End If

                Else
                    MessageBox.Show("No of unknowns are too high")
                End If

            Else
                MessageBox.Show("No of unknowns are not enough to solve")
            End If

        Catch ex As InvalidCastException
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub buttonExit_Click(ByVal sender As System.Object, e As EventArgs) Handles buttonExit.Click
        Environment.Exit(0)
    End Sub

End Class