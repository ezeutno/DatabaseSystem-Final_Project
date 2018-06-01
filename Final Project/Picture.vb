Public Class Picture
    Private Sub Picture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LocationDetail.Text = StoreDetail.getPictureLocation()
    End Sub

    Private Sub Picture_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        StoreDetail.setPictureLocation(LocationDetail.Text)
    End Sub

    Private Sub Picture_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LocationDetail.KeyDown
        If e.KeyCode = Keys.Enter Then
            StoreDetail.setPictureLocation(LocationDetail.Text)
            Me.Dispose()
        End If
    End Sub

End Class