Public Class Picture
    Private Sub Picture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location.Text = StoreDetail.getPictureLocation()
    End Sub

    Private Sub Picture_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        StoreDetail.setPictureLocation(Location.Text)
    End Sub

    Private Sub Picture_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Location.KeyDown
        If e.KeyCode = Keys.Enter Then
            StoreDetail.setPictureLocation(Location.Text)
            Me.Dispose()
        End If
    End Sub
End Class