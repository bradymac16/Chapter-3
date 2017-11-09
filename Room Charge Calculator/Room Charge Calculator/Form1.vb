﻿Public Class Form1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables foe the calculations
        Dim decRoomCharges As Decimal ' Room charges total
        Dim decAddCharges As Decimal ' Additional charges
        Dim decSubtotal As Decimal ' Subtotal
        Dim decTax As Decimal ' Tax 
        Dim decTotal As Decimal ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D ' Tax Rate

        'lblStatus.Text = String.Empty
        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            'Calcualte and Display the additonal charges. 
            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            ' Calculate and display Subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            ' Calculate and display tax.
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            ' Calculate and display the total charges.
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")
        Catch
            ' Error Message
            MessageBox.Show("All inout must be valid numeric values.")
        End Try
    End Sub

    Private Sub lblDateToday_Click(sender As Object, e As EventArgs) Handles lblDateToday.Click
        lblDateToday.Text = Now.ToString("D")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the room info fields.
        txtNights.Clear()
        txtNightlyCharge.Clear()

        ' Clear the additional charges fields
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        ' Clear the decTotal fields.
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty

        ' Get today's date from the operating system and display it. 
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the operating system and display it.
        lblTimeToday.Text = Now.ToString("T")

        ' Reset the focus to the first field.
        txtNights.Focus()
    End Sub
End Class
