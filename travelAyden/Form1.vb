Public Class Form1
    Dim intBooking As Integer = 0

    Private Sub btnBelgium_Click(sender As Object, e As EventArgs) Handles btnBelgium.Click
        Dim intPeople As Integer
        Dim sngFee As Single
        Dim sngCost As Single
        Const PRICE As Single = 1924.88
        Const FEE As Single = 0.1
        Const BOOKING As Single = 354.27

        intPeople = Val(txtPeople.Text)
        intBooking = intBooking + 1

        sngFee = intPeople * PRICE * FEE
        sngCost = intPeople * PRICE + sngFee + BOOKING

        lblCost.Text = "Total Cost: $" & sngCost
        lblBooking.Text = "Booking: " & intBooking
        picFlag.Image = My.Resources.Belgium_Flag
    End Sub

    Private Sub btnEgypt_Click(sender As Object, e As EventArgs) Handles btnEgypt.Click
        Dim intPeople As Integer
        Dim sngFee As Single
        Dim sngCost As Single
        Const PRICE As Single = 2215.35
        Const FEE As Single = 0.12
        Const BOOKING As Single = 354.27

        intPeople = Val(txtPeople.Text)
        intBooking = intBooking + 1

        sngFee = intPeople * PRICE * FEE
        sngCost = intPeople * PRICE + sngFee + BOOKING

        lblCost.Text = "Total Cost: $" & sngCost
        lblBooking.Text = "Booking: " & intBooking
        picFlag.Image = My.Resources.Egypt_Flag

    End Sub
End Class
