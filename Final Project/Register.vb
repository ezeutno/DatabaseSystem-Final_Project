Public Class Register
    Dim Db As Database = Main.getDB()

    Private Sub backLogin()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim exceptText As String = "Error : "
        If Username.Text.Length > 0 And Username IsNot "Username" Then
            If Password.Text = Password2.Text And Password.Text.Length >= 8 Then
                If fName.Text.Length > 0 And lName.Text.Length > 0 Then
                    If email.Text.Length > 0 And email.Text.Contains("@") And email.Text.Contains(".") Then
                        If phone.Text.Length > 0 Then
                            Try
                                Convert.ToDouble(phone.Text)
                                Dim dateRes As String = CStr(birthday.Value.Year) + "-" + CStr(birthday.Value.Month) + "-" + CStr(birthday.Value.Day)
                                Db.insertDetail(Username.Text, Password.Text, fName.Text, lName.Text, email.Text, phone.Text, dateRes)
                                backLogin()
                            Catch ex As Exception
                                exceptText += "Phone Number Wrong Format!"
                            End Try
                        Else
                            exceptText += "Phone Number Must Be Inserted!"
                        End If
                    Else
                        exceptText += "Email Must Be Inserted Correctly!"
                    End If
                Else
                    exceptText += "First & Last Name Must Be Inserted!"
                End If
            Else
                exceptText += "Password isn't a match or less than 8 digits!"
            End If
        Else
            exceptText += "Username Must Be Inserted!"
        End If
        If exceptText IsNot "Error : " Then
            MessageBox.Show(exceptText)
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        backLogin()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        birthday.MaxDate = Today
        birthday.Value = Today
    End Sub
End Class