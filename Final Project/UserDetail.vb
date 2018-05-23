Imports MySql.Data.MySqlClient

Public Class UserDetail
    Dim Db As Database = Main.getDB()
    Dim reader As MySqlDataReader

    Public Function getSelectedAddress() As String
        Return Address.SelectedItem.ToString
    End Function

    Public Sub refresh()
        reader = Db.getUserDetail(Main.getUsername())
        Username.Text = reader.Item(0)
        Password.Text = reader.Item(1)
        fName.Text = reader.Item(2)
        lName.Text = reader.Item(3)
        email.Text = reader.Item(4)
        phone.Text = reader.Item(5)
        birthday.Value = reader.Item(6)
        Db.closeCon()
        Address.Items.Clear()
        reader = Db.getUserAddress(Main.getUsername())
        If reader.HasRows Then
            Do While reader.Read()
                Address.Items.Add(reader.Item(0))
            Loop
        End If
        Db.closeCon()
    End Sub

    Private Sub UserDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Main.getUsername() + "'s Detail"
        birthday.MaxDate = Today
        birthday.Value = Today
        refresh()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Main.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim exceptText As String = "Error : "
        If Username.Text.Length > 0 And Username IsNot "Username" Then
            If fName.Text.Length > 0 And lName.Text.Length > 0 Then
                If email.Text.Length > 0 And email.Text.Contains("@") And email.Text.Contains(".") Then
                    If phone.Text.Length > 0 Then
                        Try
                            Convert.ToDouble(phone.Text)
                            Dim dateRes As String = CStr(birthday.Value.Year) + "-" + CStr(birthday.Value.Month) + "-" + CStr(birthday.Value.Day)
                            Db.updateDetail(Username.Text, fName.Text, lName.Text, email.Text, phone.Text, dateRes)
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
            exceptText += "Username Must Be Inserted!"
        End If
        If exceptText IsNot "Error : " Then
            MessageBox.Show(exceptText)
        End If
        Main.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click
        ChangePass.Show()
        Me.Enabled = False
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        AddAddress.Show()
        Me.Enabled = False
    End Sub

    Private Sub Address_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Address.SelectedIndexChanged
        Try
            getSelectedAddress()
            AddressDetail.Show()
        Catch ex As Exception
        End Try
    End Sub
End Class