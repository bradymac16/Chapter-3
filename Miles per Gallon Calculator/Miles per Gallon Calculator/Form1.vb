Public Class Form1

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Dim dblMPG As Double
        dblMPG = CDbl(txtmiles.Text) / CDbl(txtGallons.Text)

        lblResult.Text = dblMPG
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""

    End Sub
End Class
