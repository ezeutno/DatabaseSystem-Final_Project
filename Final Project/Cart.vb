Public Class TransCart
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Enabled = False
    End Sub

    Private Sub Cart_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Main.Enabled = True
        Main.Focus()
    End Sub
End Class