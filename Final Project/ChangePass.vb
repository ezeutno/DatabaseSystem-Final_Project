Public Class ChangePass
    Dim Db As Database = Main.getDB()
    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += " : " + Main.getUsername()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If Db.checkPassword(Main.getUsername(), Password.Text) Then
            If nPassword.Text = nPassword2.Text And nPassword.Text.Length >= 8 Then
                Db.updatePassDetail(Main.getUsername(), nPassword.Text)
                UserDetail.Enabled = True
                UserDetail.refresh()
                Me.Dispose()
            Else
                MessageBox.Show("Password isn't a match or less than 8 digits!")
            End If
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        UserDetail.Enabled = True
        Me.Dispose()
    End Sub
End Class