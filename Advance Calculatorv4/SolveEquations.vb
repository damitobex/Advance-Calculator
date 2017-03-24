
Imports System
Imports System.Collections.Generic
Imports System.Text

Public Class SolveEquations
    Private Const noSolution As Double = -100000
    '!
    '         * If Equation is a * x^3 + b * x^2 + c * x + d = 0
    '         * Then coeffient is <a,b,c,d>
    '         

    Public Function SolvePolynomialEquation(ByVal coeffient As List(Of Double)) As List(Of Double)
        While Math.Abs(coeffient(0)) < 0.01
            coeffient.RemoveAt(0)
        End While

        Dim solutions As New List(Of Double)()
        If coeffient.Count > 3 Then
            Dim dcoeff As New List(Of Double)()
            For i As Integer = 0 To coeffient.Count - 2
                dcoeff.Add(coeffient(i) * (coeffient.Count - 1 - i))
            Next

            Dim sol As Double = SingleSolution_Polynomial(coeffient, dcoeff, 1)
            If sol <> noSolution Then
                solutions.Add(sol)

                Dim coEff As New List(Of Double)()
                coEff.Add(coeffient(0))
                For i As Integer = 1 To coeffient.Count - 2
                    coEff.Add(coeffient(i) + sol * coEff(i - 1))
                Next
                Dim partialSol As List(Of Double) = SolvePolynomialEquation(coEff)
                solutions.AddRange(partialSol)
            End If
        ElseIf coeffient.Count = 3 Then
            Dim delta As Double = Math.Pow(coeffient(1), 2) - 4 * coeffient(0) * coeffient(2)
            If delta >= 0 Then
                Dim rootVal As Double = Math.Sqrt(delta)
                solutions.Add((-1 * coeffient(1) + rootVal) / (2 * coeffient(0)))
                solutions.Add((-1 * coeffient(1) - rootVal) / (2 * coeffient(0)))
            End If
        ElseIf coeffient.Count = 2 Then
            solutions.Add(-1 * coeffient(1) / coeffient(0))
        End If
        Return solutions
    End Function

    Private Function SingleSolution_Polynomial(ByVal coefficient As List(Of Double), ByVal dCoeff As List(Of Double), ByVal initX As Double) As Double
        Dim dFunc As Double, func As Double, x As Double = initX, x0 As Double = 0
        Const maxIteration As Integer = 1000
        Dim itr As Integer = 0

        While Math.Abs(x - x0) > 0.0001
            If System.Math.Max(System.Threading.Interlocked.Increment(itr), itr - 1) > maxIteration Then
                Return noSolution
            End If
            x0 = x
            func = 0
            dFunc = 0
            For i As Integer = 0 To coefficient.Count - 1
                func += coefficient(i) * Math.Pow(x, coefficient.Count - 1 - i)
            Next
            For i As Integer = 0 To dCoeff.Count - 1
                dFunc += dCoeff(i) * Math.Pow(x, dCoeff.Count - 1 - i)
            Next

            If dFunc <> 0 Then
                x = x - func / dFunc
            ElseIf func < 0.0001 Then
                Return x
            Else
                x += 1
            End If
        End While
        Return x
    End Function

    Public Function SolveLinearEquation(ByVal equationMatrix As Double(,)) As Double()
        If equationMatrix.GetLength(0) + 1 = equationMatrix.GetLength(1) Then
            Dim nVar As Integer = equationMatrix.GetLength(0)

            For i As Integer = 0 To nVar - 1
                'If the element is zero, make it non zero by row operation
                If equationMatrix(i, i) = 0 Then
                    Dim j As Integer
                    For j = i + 1 To nVar - 1
                        If equationMatrix(j, i) <> 0 Then
                            For k As Integer = i To nVar
                                equationMatrix(i, k) += equationMatrix(j, k)
                            Next
                            Exit For
                        End If
                    Next
                    'If all value for this variable is zero, there should a duplicated equation
                    If j = nVar Then
                        Throw New Exception("Same equation repeated. Can't solve it")
                    End If
                End If

                'make the diagonal element as 1
                For k As Integer = nVar To i Step -1
                    equationMatrix(i, k) /= equationMatrix(i, i)
                Next

                'use row operation to make upper matrix
                For j As Integer = i + 1 To nVar - 1
                    For k As Integer = nVar To i Step -1
                        equationMatrix(j, k) -= equationMatrix(i, k) * equationMatrix(j, i)
                    Next
                Next
            Next

            'It is to make unit matrix
            For i As Integer = nVar - 1 To 1 Step -1
                For j As Integer = i - 1 To 0 Step -1
                    equationMatrix(j, nVar) -= equationMatrix(j, i) * equationMatrix(i, nVar)
                    equationMatrix(j, i) = 0
                Next
            Next

            Dim ans As Double() = New Double(nVar - 1) {}
            For j As Integer = 0 To nVar - 1
                ans(j) = equationMatrix(j, nVar)
            Next


            Return ans
        Else
            Throw New Exception("These equation matrix can't be solved")
        End If
    End Function
End Class
