Public Class Form1


    Private Sub btnCalculateTax_Click(sender As Object, e As EventArgs) Handles btnCalculateTax.Click
        Dim propertyValue, SixtyPercentValue, taxValue As Double
        Const TAX_RATE As Double = 0.64

        Try
            propertyValue = txtAcutalPropertyValue.Text()
            SixtyPercentValue = propertyValue * 0.6

            taxValue = (SixtyPercentValue / 100) * TAX_RATE

            lblTotal.Text = taxValue.ToString("c")
        Catch
            MessageBox.Show("Error: please enter values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAcutalPropertyValue.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
