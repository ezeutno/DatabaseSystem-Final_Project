Imports MySql.Data.MySqlClient

Public Class CreateStore
    Dim Db As Database = Main.getDB()
    Dim reader As MySqlDataReader
    Public Updatecond As Boolean
    Public setstoreName As String
    Private Sub CreateStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Updatecond Then
            StoreDetail.Enabled = False
            storeName.Text = setstoreName
            Me.Text = "Update Store"
            Create.Text = "Update"
        End If
        Create.Enabled = False
        reader = Db.getUserAddress(Main.getUsername())
        If reader.HasRows Then
            Do While reader.Read()
                Address.Items.Add(reader.Item(0))
            Loop
        End If
        Db.closeCon()
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Dim chosenAddress As String = Address.SelectedItem.ToString
        Dim name As String = storeName.Text
        If chosenAddress.Length > 0 And name.Length > 0 Then
            Dim address_id As Integer = Db.getAddressId(Main.getUsername(), chosenAddress).Item(0)
            Db.closeCon()
            If Updatecond Then
                If setstoreName <> name Then
                    Db.insertnewStore(name, Main.getUsername(), address_id)
                    Db.updateStore(setstoreName, name)
                    Db.deleteStore(setstoreName)
                    StoreDetail.refreshDetail()
                End If
                StoreDetail.Enabled = True
                StoreDetail.Focus()
            Else
                Db.insertnewStore(name, Main.getUsername(), address_id)
                StoreDetail.Show()
            End If
            Me.Dispose()
        Else
            MessageBox.Show("Store Name should be written!")
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        If Updatecond Then
            StoreDetail.Enabled = True
            StoreDetail.Focus()
        End If
        Me.Dispose()
    End Sub

    Private Sub Address_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Address.SelectedIndexChanged
        If Address.SelectedIndex <> -1 Then
            Create.Enabled = True
        End If
    End Sub

End Class