Public Class Login
    Dim Db As Database = Main.getDB()
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub disposedMe()
        Main.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If Db.checkPassword(Username.Text, Password.Text) Then
            Main.setUsername(CStr(Username.Text))
            Main.loginEx()
            disposedMe()
            Main.Focus()
        End If
    End Sub

    Private Sub CancleBtn_Click(sender As Object, e As EventArgs) Handles CancleBtn.Click
        Main.getUsernameTextBox().Enabled = False
        disposedMe()
    End Sub

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Register.Show()
        Me.Dispose()
    End Sub
End Class