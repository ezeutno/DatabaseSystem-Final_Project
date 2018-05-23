Imports MySql.Data.MySqlClient

Public Class AddressDetail
    Dim Db As Database = Main.getDB()
    Dim reader As MySqlDataReader

    Private Sub AddressDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reader = Db.getAddressDetail(Main.getUsername(), UserDetail.getSelectedAddress())
        If reader.HasRows Then
            reader.Read()
            id.Text = reader.Item(0)
            Address.Text = reader.Item(1)
            sub_district.Text = reader.Item(2)
            district.Text = reader.Item(3)
            province.Text = reader.Item(4)
            postal_code.Text = reader.Item(5)
            country.Text = reader.Item(6)
            If reader.Item(7) Then
                storeYes.Checked = True
            Else
                storeNo.Checked = True
            End If
        End If
        Db.closeCon()
        reader = Db.getAllCountry()
        Do While reader.Read()
            country.Items.Add(reader.Item(0))
        Loop
        Db.closeCon()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Dim exceptText As String = "Error : "
        If Address.Text.Length > 0 Then
            If sub_district.Text.Length > 0 And district.Text.Length > 0 And province.Text.Length > 0 Then
                Try
                    Dim postal As Integer = Convert.ToInt32(postal_code.Text)
                    Try
                        Dim country_id As Integer = Db.getCountryId(country.Text).Item(0)
                        Db.closeCon()
                        If country_id > 0 Then
                            Db.updateAddress(Convert.ToInt32(id.Text), Address.Text, sub_district.Text, district.Text, province.Text, postal, country_id)
                            UserDetail.refresh()
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

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Db.deleteAddress(Convert.ToInt32(id.Text))
        UserDetail.refresh()
        Me.Dispose()
    End Sub
End Class