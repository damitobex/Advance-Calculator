Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub arrangeCalc(ByVal calcName As Form)

        If calcName.Visible = True Then
            calcName.Location = New Point(Me.Width + Me.Left, Me.Top)
            calcName.BringToFront()
            If calcName.WindowState = FormWindowState.Minimized Then
                calcName.WindowState = FormWindowState.Normal
            End If

        Else
            calcName.Show()
            calcName.Location = New Point(Me.Width + Me.Left, Me.Top)
            calcName.TopMost = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        General.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        arrangeCalc(Form1)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Matrix.Show()

    End Sub
End Class
