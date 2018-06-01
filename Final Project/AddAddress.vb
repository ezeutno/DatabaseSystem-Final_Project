Imports MySql.Data.MySqlClient

Public Class AddAddress
    Dim Db As Database = Main.getDB()
    Dim reader As MySqlDataReader

    Private Sub AddAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reader = Db.getAllCountry()
        Do While reader.Read()
            country.Items.Add(reader.Item(0))
        Loop
        Db.closeCon()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim exceptText As String = "Error : "
        If Address.Text.Length > 0 Then
            If sub_district.Text.Length > 0 And district.Text.Length > 0 And province.Text.Length > 0 Then
                Try
                    Dim postal As Integer = Convert.ToInt32(postal_code.Text)
                    Try
                        Dim country_id As Integer = Db.getCountryId(country.Text).Item(0)
                        Db.closeCon()
                        If country_id > 0 Then
                            Db.insertAddress(Main.getUsername(), Address.Text, sub_district.Text, district.Text, province.Text, postal, country_id)
                            UserDetail.refreshDetail()
                            UserDetail.Enabled = True
                            Me.Dispose()
                        Else
                            exceptText += "The right country hasn't been chosen!"
                        End If
                    Catch ex As Exception
                        Db.closeCon()
                        exceptText += ex.Message()
                    End Try
                Catch ex As Exception
                    exceptText += "Please input the correct type of postal code!"
                End Try
            Else
                exceptText += "Sub District, District & Province Name Must Be Inserted!"
            End If
        Else
            exceptText += "Username Must Be Inserted!"
        End If
        If exceptText IsNot "Error : " Then
            MessageBox.Show(exceptText)
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        UserDetail.Enabled = True
        Me.Dispose()
    End Sub

End Class