Imports MySql.Data.MySqlClient

Public Class Database
    Dim con As MySqlConnection
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader
    Dim condition, condition2 As Boolean

    Public Sub ConnectDB()
        str = "Server = localhost; user id = root; password = ;database=dbfinalproject; SslMode = none"
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
            query = "insert into custaddress(detail,sub_district,district,province,postal_code,country_id,username) values "
            query += "('" + detail + "','" + sub_district + "','" + district + "','" + province + "'," + CStr(postal_code) + ", " + CStr(country_id) + ",'" + username + "')"
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

    Public Sub insertnewStore(storeName As String, username As String, address_id As Integer)
        Try
            con.Open()
            query = "Insert Into store Values('" + storeName + "','" + username + "'," + CStr(address_id) + ")"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub insertStoreItem(name As String, quantity As Integer, price As String, brand_id As Integer, os_id As Integer, storage As String, ram As String, description As String, imageloc As String, store_name As String)
        Try
            con.Open()
            query = "INSERT INTO item(name,quantity,price,brand_id,os_id,storage,ram,description,imageloc,store_name)"
            query += " VALUES('" + name + "'," + CStr(quantity) + "," + price + "," + CStr(brand_id) + "," + CStr(os_id) + ","
            query += storage + "," + ram + ",'" + description + "','" + imageloc + "','" + store_name + "')"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub insertItemBrand(brand As String)
        Try
            con.Open()
            query = "INSERT INTO brand(name) VALUES('" + brand + "')"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
            Main.refreshSearchBy()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub insertItemOS(os As String)
        Try
            con.Open()
            query = "INSERT INTO os(name) VALUES('" + os + "')"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
            Main.refreshSearchBy()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub insertNewTransaction(username As String)
        Try
            con.Open()
            query = "INSERT INTO transaction(purchased,username) VALUES(0,'" + username + "')"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub insertDetailTrans(item_id As Integer, qty As Integer, trans_id As Integer)
        Try
            con.Open()
            query = "INSERT INTO detailtrans(item_id,quantity,transaction_id) "
            query += "VALUES(" + CStr(item_id) + "," + CStr(qty) + "," + CStr(trans_id) + ")"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Function getDetailTransaction(username As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT transaction.id, item.store_name, detailtrans.id,item.id, item.name,item.price, detailtrans.quantity, item.price * detailtrans.quantity as price, detailtrans.status "
            query += "FROM detailtrans,item,transaction "
            query += "WHERE detailtrans.item_id = item.id "
            query += "AND transaction.id = detailtrans.transaction_id "
            query += "AND transaction.username = '" + username + "' "
            query += "AND transaction.purchased = 1 "
            query += "ORDER By detailtrans.status"
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

    Public Function getDetailTransaction(currTrans As Integer) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT transaction.id, item.store_name, detailtrans.id,item.id, item.name,item.price, detailtrans.quantity, item.price * detailtrans.quantity as price, detailtrans.status "
            query += "FROM detailtrans,item,transaction "
            query += "WHERE detailtrans.item_id = item.id "
            query += "AND transaction.id = detailtrans.transaction_id "
            query += "AND transaction.id = " + CStr(currTrans)
            query += " ORDER By detailtrans.status"
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

    Public Function getTransactionId(username As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT id FROM transaction WHERE purchased = 0 AND username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Return reader
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

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

    Public Function getUserAddress(id As Integer) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT detail FROM custAddress WHERE id = " + CStr(id)
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
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function getAllBrand() As MySqlDataReader
        Try
            con.Open()
            query = "SELECT name FROM brand"
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

    Public Function getAllOS() As MySqlDataReader
        Try
            con.Open()
            query = "SELECT name FROM os"
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

    Public Function getStoreData(store_name As String)
        Try
            con.Open()
            query = "SELECT name FROM item WHERE store_name = '" + store_name + "'"
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

    Public Function getStoreData(store_name As String, search_text As String)
        Try
            con.Open()
            query = "SELECT name FROM item WHERE store_name = '" + store_name + "' AND name LIKE '%" + search_text + "%'"
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

    Public Function getAddressId(username As String, address As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT id FROM custaddress WHERE username = '" + username + "' AND detail = '" + address + "'"
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
            query = "SELECT custaddress.id, custaddress.detail, custaddress.sub_district, custaddress.district, custaddress.province,custaddress.postal_code, country.country_name "
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

    Public Function getStoreDetail(username As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT name, address_id FROM store WHERE username = '" + username + "'"
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

    Public Function getOsId(os As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT id FROM os WHERE name = '" + os + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Return reader
            Else
                con.Close()
                insertItemOS(os)
                Return getOsId(os)
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function getOsName(id As Integer) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT name FROM os WHERE id = " + CStr(id)
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

    Public Function getBrandId(brand As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT id FROM brand WHERE name = '" + brand + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Return reader
            Else
                con.Close()
                insertItemBrand(brand)
                Return getBrandId(brand)
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function getBrandName(id As Integer) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT name FROM brand WHERE id = " + CStr(id)
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

    Public Function getItemDetails(id As Integer) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT * FROM item WHERE id = " + CStr(id)
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

    Public Function getItemDetails(item_name As String, store_name As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT * FROM item WHERE name = '" + item_name + "' AND store_name = '" + store_name + "'"
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

    Public Function getAllItem(start_id As Integer, search As String, brand As String, os As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT item.id,item.name,item.imageloc,item.price FROM item,brand,os WHERE item.quantity > 0 "
            query += "AND item.brand_id = brand.id AND item.os_id = os.id "
            If search.Length > 0 Then
                query += "AND item.name LIKE '%" + search + "%' "
            End If
            If brand.Length > 0 Then
                query += "AND brand.name LIKE '%" + brand + "%' "
            End If
            If os.Length > 0 Then
                query += "AND os.name LIKE '%" + os + "%' "
            End If
            query += "LIMIT " + CStr(start_id) + ",8 "
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

    Public Function getAllItem(start_id As Integer, search As String, brand As String, os As String, orderBy As String, cond As Boolean) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT item.id,item.name,item.imageloc,item.price FROM item,brand,os WHERE item.quantity > 0 "
            query += "AND item.brand_id = brand.id AND item.os_id = os.id "
            If search.Length > 0 Then
                query += "AND item.name LIKE '%" + search + "%' "
            End If
            If brand.Length > 0 Then
                query += "AND brand.name LIKE '%" + brand + "%' "
            End If
            If os.Length > 0 Then
                query += "AND os.name LIKE '%" + os + "%' "
            End If
            If cond Then
                query += "ORDER BY " + orderBy + " ASC "
            Else
                query += "ORDER BY " + orderBy + " DESC "
            End If
            query += "LIMIT " + CStr(start_id) + ",8 "
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

    Public Function getCountItems(Search As String, brand As String, os As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT count(*) FROM item,brand,os WHERE item.quantity > 0 "
            query += "AND item.brand_id = brand.id AND item.os_id = os.id "
            If Search.Length > 0 Then
                query += "AND item.name LIKE '%" + Search + "%' "
            End If
            If brand.Length > 0 Then
                query += "AND brand.name LIKE '%" + brand + "%' "
            End If
            If os.Length > 0 Then
                query += "AND os.name LIKE '%" + os + "%' "
            End If
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows() Then
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

    Public Function getStoreAddress(storeName As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT custaddress.detail FROM custaddress, store "
            query += "WHERE custaddress.id = store.address_id "
            query += "AND store.name = '" + storeName + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows() Then
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

    Public Function getTotalPrice(item_id As Integer, amtOfpur As Integer) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT price *" + CStr(amtOfpur) + " AS Totalprice FROM item "
            query += "WHERE id = " + CStr(item_id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows() Then
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

    Public Function getFname(username As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT fname FROM custdetail "
            query += "WHERE username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows() Then
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

    Public Function getTotalTrans(username As String) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT sum(item.price * detailtrans.quantity) "
            query += "FROM detailtrans,item,transaction "
            query += "WHERE detailtrans.item_id = item.id "
            query += "AND transaction.id = detailtrans.transaction_id "
            query += "AND transaction.username = '" + username + "' "
            query += "AND detailtrans.status <> 'REJECTED' "
            query += "AND transaction.purchased = 1"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows() Then
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

    Public Function getTotalTrans(currTrans As Integer) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT sum(item.price * detailtrans.quantity) FROM item,detailtrans "
            query += "WHERE detailtrans.item_id = item.id "
            query += "AND  detailtrans.transaction_id = " + CStr(currTrans)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            If reader.HasRows() Then
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

    Public Function getStoreFullfilmet(storeName As String, status() As String, condition As Boolean) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT detailtrans.id, item.id, detailtrans.status, transaction.username, item.name, detailtrans.quantity, item.price, item.price*detailtrans.quantity, "
            query += "custaddress.detail,custaddress.sub_district, custaddress.district, custaddress.province,custaddress.postal_code, country.country_name "
            query += "FROM detailtrans,transaction,custaddress,country,item  "
            query += "WHERE detailtrans.transaction_id = transaction.id "
            query += "And transaction.address_id = custaddress.id "
            query += "And detailtrans.item_id = item.id "
            query += "And transaction.purchased = 1 "
            query += "And custaddress.country_id = country.country_id "
            query += "And item.store_name = '" + storeName + "' "
            query += "AND ("
            If condition Then
                Dim i As Integer = 0
                For Each state In status
                    If i = 0 Then
                        query += "detailtrans.status = '" + state + "'"
                    Else
                        query += "OR detailtrans.status = '" + state + "'"
                    End If
                    i += 1
                Next
            Else
                Dim i As Integer = 0
                For Each state In status
                    If i = 0 Then
                        query += "detailtrans.status <> '" + state + "'"
                    Else
                        query += "AND detailtrans.status <> '" + state + "'"
                    End If
                    i += 1
                Next
            End If
            query += ") "
            query += "ORDER By detailtrans.status"
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


    Public Function getTotalCurrent(storeName As String, status() As String, ByVal cond As Boolean) As MySqlDataReader
        Try
            con.Open()
            query = "SELECT sum( item.price * detailtrans.quantity ) FROM item,detailtrans,transaction "
            query += "WHERE detailtrans.item_id = item.id "
            query += "And transaction.id = detailtrans.transaction_id "
            query += "And transaction.purchased = 1 "
            query += "AND item.store_name = '" + storeName + "' "
            query += "AND ("
            If cond Then
                query += "detailtrans.status = '" + status(0) + "' "
            Else
                Dim i As Integer = 0
                For Each state In status
                    If i = 0 Then
                        query += "detailtrans.status <> '" + state + "' "
                    Else
                        query += "AND detailtrans.status <> '" + state + "' "
                    End If
                    i += 1
                Next
            End If
            query += ")"
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

    Public Function checkAvQuantity(item_id As Integer, qty As Integer) As Boolean
        Try
            con.Open()
            query = "SELECT quantity FROM item WHERE id = " + CStr(item_id) + " AND quantity >= " + CStr(qty)
            comm = New MySqlCommand(query, con)
            Return comm.ExecuteReader.HasRows
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths

    Public Function checkAddress(username As String) As Boolean
        Try
            con.Open()
            query = "SELECT * FROM custaddress WHERE username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            Return comm.ExecuteReader.HasRows
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths

    Public Function checkStoreAddress(Username As String) As Boolean
        Try
            con.Open()
            query = "SELECT * FROM store WHERE username = '" + Username + "'"
            comm = New MySqlCommand(query, con)
            Return comm.ExecuteReader.HasRows
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths


    Public Function checkStoreAddress(Username As String, Address_id As Integer) As Boolean
        Try
            con.Open()
            query = "SELECT * FROM store WHERE username = '" + Username + "' AND address_id = " + CStr(Address_id)
            comm = New MySqlCommand(query, con)
            Return comm.ExecuteReader.HasRows
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths

    Public Function checkItemOwnerShip(id As Integer, username As String) As Boolean
        Try
            con.Open()
            query = "SELECT item.id FROM item,store "
            query += "WHERE item.store_name = store.name "
            query += "AND store.username = '" + username + "' "
            query += "AND item.id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            Return comm.ExecuteReader.HasRows
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths

    Public Function checkTransactionExists(username As String) As Boolean
        Try
            con.Open()
            query = "SELECT * FROM transaction "
            query += "WHERE purchased = 0 "
            query += "AND username = '" + username + "'"
            comm = New MySqlCommand(query, con)
            Return comm.ExecuteReader.HasRows
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths

    Public Function checkTransactionExists(id As Integer) As Boolean
        Try
            con.Open()
            query = "SELECT * FROM transaction,detailtrans "
            query += "WHERE detailtrans.transaction_id = transaction.id "
            query += "AND transaction.id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            Return comm.ExecuteReader.HasRows
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths

    Public Sub updateTransactionAddress(trans_id As Integer, address_id As Integer)
        Try
            con.Open()
            query = "UPDATE transaction SET purchased = 1, address_id = " + CStr(address_id) + " WHERE id = " + CStr(trans_id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

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

    Public Sub updateStore(prevstoreName As String, storeName As String)
        Try
            con.Open()
            query = "UPDATE item SET store_name = '" + storeName + "'  WHERE store_name = '" + prevstoreName + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub updateStore(storeName As String, address_id As Integer)
        Try
            con.Open()
            query = "UPDATE store SET address_id = " + CStr(address_id) + " WHERE name = '" + storeName + "'"
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub updateStoreItem(id As Integer, name As String, quantity As Integer, price As String, brand_id As Integer, os_id As Integer, storage As String, ram As String, description As String, imageloc As String)
        Try
            con.Open()
            query = "UPDATE item SET name = '" + name + "', quantity=" + CStr(quantity) + ",price = " + price + ", brand_id = " + CStr(brand_id)
            query += ", os_id = " + CStr(os_id) + ", storage = " + storage + ", ram= " + ram + ", description = '" + description + "',imageloc = '" + imageloc + "'"
            query += " WHERE id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub updateItem(id As Integer, quantity As Integer, plus As Boolean)
        Try
            con.Open()
            If plus Then
                query = "UPDATE item SET  quantity = quantity + " + CStr(quantity) + " "
            Else
                query = "UPDATE item SET  quantity = quantity - " + CStr(quantity) + " "
            End If
            query += "WHERE id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub updateDetailTrans(id As Integer, status As String)
        Try
            con.Open()
            query = "UPDATE detailtrans SET  status =  '" + status + "' "
            query += "WHERE id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub deleteStore(prevstore As String)
        Try
            con.Open()
            query = "DELETE FROM store WHERE name = '" + prevstore + "'"
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

    Public Sub deleteItem(id As Integer)
        Try
            con.Open()
            query = "DELETE FROM item WHERE id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub deleteTransaction(id As Integer)
        Try
            con.Open()
            query = "DELETE FROM transaction WHERE id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub

    Public Sub deleteDetailTrans(id As Integer)
        Try
            con.Open()
            query = "DELETE FROM detailtrans WHERE id = " + CStr(id)
            comm = New MySqlCommand(query, con)
            reader = comm.ExecuteReader
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Connection error occured : " + ex.Message)
        End Try
    End Sub


End Class
