Public Class CartDetail
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Enabled = False
    End Sub
    Private Sub Cart_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Main.Enabled = True
        Main.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class