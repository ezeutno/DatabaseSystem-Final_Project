Public Class SellerSales
    Private Sub SellerSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Enabled = False
    End Sub
    Private Sub SellerSales_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Me.Dispose()
        Main.Enabled = True
        Main.Focus()
    End Sub
End Class