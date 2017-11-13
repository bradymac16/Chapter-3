Public Class Form1


    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        Dim dblClassA As Double
        Dim dblClassB As Double
        Dim dblClassC As Double

        dblClassA = CDbl(txtClassA.Text) * 15
        lblResultClassA.Text = dblClassA.ToString("c")

        dblClassB = CDbl(txtClassB.Text) * 12
        lblResultClassB.Text = dblClassB.ToString("c")

        dblClassC = CDbl(txtClassC.Text) * 9
        lblResultClassC.Text = dblClassC.ToString("c")



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResultClassA.Text = ""
        lblResultClassB.Text = ""
        lblResultClassC.Text = ""
        lblTotalRevenue.Text = ""

        txtClassA.Text = ""
        txtClassB.Text = ""
        txtClassC.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
