Imports MySql.Data.MySqlClient

Public Class Database
    Dim con As MySqlConnection
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim condition, condition2 As Boolean

    Public Sub ConnectDB()
        str = "Server = localhost; user id = root; password = ;database=finalproject; SslMode = none"
        con = New MySqlConnection(str)
    End Sub

    Public Sub closeCon()
        con.Close()
    End Sub

    Public Function checkPassword(username As String, password As String) As Boolean
        Try
            con.Open()
            query = "SELECT password FROM custDetail where username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            Dim cond As Boolean
            If reader.HasRows Then
                reader.Read()
                If reader.Item(0) = password Then
                    cond = True
                Else
                    MessageBox.Show("Wrong Password!")
                End If
            Else
                MessageBox.Show("Wrong Username!")
                cond = False
            End If
            con.Close()
            Return cond
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
        Return False
    End Function

    Public Sub insertAddress(username As String, detail As String, sub_district As String, district As String, province As String, postal_code As Integer, country_id As Integer)
        Try
            con.Open()
            query = "insert into custaddress(detail,sub_district,district,province,postal_code,country_id,store,username) values "
            query += "('" + detail + "','" + sub_district + "','" + district + "','" + province + "'," + CStr(postal_code) + ", " + CStr(country_id) + ", 0 ,'" + username + "')"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub insertDetail(username As String, password As String, fname As String, lname As String, email As String, phone As String, birthday As String)
        Try
            con.Open()
            query = "Insert Into custDetail Values('" + username + "','" + password + "','" + fname + "','" + lname + "','" + email + "','" + phone + "','" + birthday + "')"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Function getUserDetail(username As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT * FROM custDetail WHERE username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Return reader
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function getUserAddress(username As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT detail FROM custAddress WHERE username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            Return reader
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Function

    Public Function getAllCountry() As MySqlDataReader
        Try
            con.Open()
            query = "SELECT country_name FROM country"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                Return reader
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function getCountryId(countryName As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT country_id FROM country WHERE country_name = '" + countryName + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Return reader
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function getAddressDetail(username As String, addressdetail As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT custaddress.id, custaddress.detail, custaddress.sub_district, custaddress.district, custaddress.province,custaddress.postal_code, country.country_name, custaddress.store "
            query += "FROM custaddress, country WHERE custaddress.country_id = country.country_id  AND custaddress.detail = '" + addressdetail + "' AND custaddress.username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            Return reader
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function checkStoreAddress(Username As String) As Boolean
        Try
            con.Open()
            query = "SELECT * FROM custAddress WHERE username = '" + Username + "' AND store = 1"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            Dim cond As Boolean = reader.HasRows
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Function

    Public Sub updateDetail(username As String, fname As String, lname As String, email As String, phone As String, birthday As String)
        Try
            con.Open()
            query = "UPDATE custDetail SET fname = '" + fname + "', lname= '" + lname + "',email='" + email + "', phone = '" + phone + "',birthday = '" + birthday + "' WHERE username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub updatePassDetail(username As String, password As String)
        Try
            con.Open()
            query = "UPDATE custDetail SET password = '" + password + "' WHERE username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub updateAddress(id As Integer, detail As String, sub_district As String, district As String, province As String, postal_code As Integer, country_id As Integer)
        Try
            con.Open()
            query = "UPDATE custAddress SET detail = '" + detail + "', sub_district = '" + sub_district + "', district= '" + district + "', province = '" + province + "',postal_code = " + CStr(postal_code) + ",country_id = " + CStr(country_id) + " WHERE id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub deleteAddress(id As Integer)
        Try
            con.Open()
            query = "DELETE FROM custAddress WHERE id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

End Class
