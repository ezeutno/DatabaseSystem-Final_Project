Public Class StoreDetail
    Private Sub StoreDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Enabled = False
    End Sub

    Private Sub StoreDetail_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Me.Dispose()
        Main.Enabled = True
        Main.Focus()
    End Sub
End Class
