Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnShowFahrenheit_Click(sender As Object, e As EventArgs) Handles btnShowFahrenheit.Click
        Dim dblFahrenheit As Double
        Dim dblCelsius As Double

        dblCelsius = CDbl(txtCelsius.Text)
        dblFahrenheit = (1.8 * dblCelsius + 32)
        lblShowFahrenhiet.Text = dblFahrenheit.ToString("n")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelsius.Text = ""
        lblShowFahrenhiet.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
