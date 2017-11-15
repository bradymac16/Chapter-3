Public Class Form1

    Private Sub btnClaculateAverage_Click(sender As Object, e As EventArgs) Handles btnClaculateAverage.Click
        Dim dblTestScore1, dblTestScore2, dblTestScore3, dblAverage As Double

        Const Num_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0

        Try
            dblTestScore1 = CDbl(txtTestScore1.Text)
            dblTestScore2 = CDbl(txtTestScore2.Text)
            dblTestScore3 = CDbl(txtTestScore3.Text)
            dblAverage = (dblTestScore1 + dblTestScore2 + dblTestScore3) / Num_SCORES

            lblAverageScore.Text = dblAverage

        Catch ex As Exception

        End Try
    End Sub
End Class
