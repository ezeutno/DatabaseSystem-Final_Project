Imports MySql.Data.MySqlClient

Public Class StoreDetail
    Dim Db As Database = Main.getDB()
    Dim reader As MySqlDataReader
    Dim condAdd As Boolean = True
    Dim condUpdate As Boolean = True

    Public Function getPictureLocation() As String
        Return ItemImage.ImageLocation
    End Function

    Public Sub setPictureLocation(location As String)
        ItemImage.ImageLocation = location
    End Sub

    Private Sub intVal(data As String, ByRef ValError As String, newValError As String, ByRef cond As Boolean)
        Try
            Dim newData As Integer = Val(data)
        Catch ex As Exception
            ValError += vbNewLine + newValError + " isn't Integer/Numerical Type!"
            cond = False
        End Try
    End Sub

    Private Sub doubleVal(data As String, ByRef ValError As String, newValError As String, ByRef cond As Boolean)
        Try
            Dim newData As Double = Val(data)
        Catch ex As Exception
            ValError += vbNewLine + newValError + " isn't Double/Numerical Type!"
            cond = False
        End Try
    End Sub

    Private Sub semVal(data As String, ByRef ValError As String, newValError As String, ByRef cond As Boolean)
        If data.Length <= 0 Then
            ValError += vbNewLine + newValError + " hasn't been inserted!"
            cond = False
        End If
    End Sub

    Private Function Validation() As Boolean
        Dim cond As Boolean = True
        Dim A() As String = {ItemImage.ImageLocation, nameData.Text, qty.Text, price.Text, brand.Text, os.Text, storage.Text, ram.Text, description.Text}
        Dim ValError As String = "An Error Occured : "
        semVal(A(0), ValError, "Image location (Press Picture Box)", cond)
        If Not A(0).ToLower.Contains("http") And (Not A(0).ToLower.Contains(".png") Or Not A(0).ToLower.Contains(".jpeg") Or Not A(0).ToLower.Contains(".jpg")) Then
            ValError += vbNewLine + "Image location isn't a link with .png/.jpeg/.jpg file format!"
            cond = False
        End If
        semVal(A(1), ValError, "Item Name", cond)
        semVal(A(2), ValError, "Quantity", cond)
        intVal(A(2), ValError, "Quantity", cond)
        semVal(A(3), ValError, "Price", cond)
        doubleVal(A(3), ValError, "Price", cond)
        semVal(A(4), ValError, "Brand", cond)
        semVal(A(5), ValError, "Operating System (OS)", cond)
        semVal(A(6), ValError, "Storage", cond)
        doubleVal(A(6), ValError, "Storage", cond)
        semVal(A(7), ValError, "RAM", cond)
        doubleVal(A(7), ValError, "RAM", cond)
        If Not cond Then
            MessageBox.Show(ValError)
        End If
        Return cond
    End Function

    Public Sub Clear()
        ItemImage.ImageLocation = ""
        nameData.Text = ""
        qty.Text = ""
        price.Text = ""
        brand.Text = ""
        os.Text = ""
        storage.Text = ""
        ram.Text = ""
        description.Text = ""
        Items.ClearSelected()
    End Sub

    Public Sub changeEnable()
        ItemImage.Enabled = Not ItemImage.Enabled
        nameData.Enabled = Not nameData.Enabled
        qty.Enabled = Not qty.Enabled
        price.Enabled = Not price.Enabled
        brand.Enabled = Not brand.Enabled
        os.Enabled = Not os.Enabled
        storage.Enabled = Not storage.Enabled
        ram.Enabled = Not ram.Enabled
        description.Enabled = Not description.Enabled
        Items.Enabled = Not Items.Enabled
    End Sub

    Public Sub refreshDetail()
        Items.Items.Clear()
        reader = Db.getStoreDetail(Main.getUsername())
        StoreTitle.Text = reader.Item(0)
        Dim storeAddressId As Integer = reader.Item(1)
        Db.closeCon()
        StoreAddress.Text = Db.getUserAddress(storeAddressId).Item(0)
        Db.closeCon()
        os.Items.Clear()
        reader = Db.getAllOS()
        If reader.HasRows Then
            Do While reader.Read()
                os.Items.Add(reader.Item(0))
            Loop
        End If
        Db.closeCon()
        brand.Items.Clear()
        reader = Db.getAllBrand()
        If reader.HasRows Then
            Do While reader.Read()
                brand.Items.Add(reader.Item(0))
            Loop
        End If
        Db.closeCon()
        If Search.Text.Length > 0 Then
            reader = Db.getStoreData(StoreTitle.Text, Search.Text)
        Else
            reader = Db.getStoreData(StoreTitle.Text)
        End If
        If reader.HasRows Then
            Do While reader.Read()
                Items.Items.Add(reader.Item(0))
            Loop
        End If
        Db.closeCon()
        Clear()
    End Sub

    Private Sub StoreDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Enabled = False
        refreshDetail()
    End Sub

    Private Sub StoreDetail_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Me.Dispose()
        Main.Enabled = True
        Main.Focus()
    End Sub

    Private Sub StoreTitle_Click(sender As Object, e As EventArgs) Handles StoreTitle.Click
        CreateStore.setstoreName = StoreTitle.Text
        CreateStore.Updatecond = True
        CreateStore.Show()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles add.Click
        If condAdd Then
            Clear()
            updateBtn.Enabled = False
            delete.Enabled = False
            Search.Enabled = False
            changeEnable()
            condAdd = Not condAdd
        Else
            If Validation() Then
                Dim brand_id As Integer = Db.getBrandId(brand.Text).Item(0)
                Db.closeCon()
                Dim os_id As Integer = Db.getOsId(os.Text).Item(0)
                Db.closeCon()
                Db.insertStoreItem(nameData.Text, Val(qty.Text), price.Text, brand_id, os_id, storage.Text, ram.Text, description.Text, ItemImage.ImageLocation, StoreTitle.Text)
                Search.Enabled = True
                changeEnable()
                condAdd = Not condAdd
                refreshDetail()
                Main.refreshAllData()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ItemImage.Click
        Picture.Show()
    End Sub

    Private Sub Items_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Items.SelectedIndexChanged
        If Items.SelectedIndex <> -1 Then
            delete.Enabled = True
            updateBtn.Enabled = True
            reader = Db.getItemDetails(Items.SelectedItem.ToString, StoreTitle.Text)
            id.Text = reader.Item(0)
            nameData.Text = reader.Item(1)
            qty.Text = reader.Item(2)
            price.Text = reader.Item(3)
            Dim brand_id As Integer = reader.Item(4)
            Dim os_id As Integer = reader.Item(5)
            storage.Text = reader.Item(6)
            ram.Text = reader.Item(7)
            description.Text = reader.Item(8)
            ItemImage.ImageLocation = ""
            ItemImage.ImageLocation = reader.Item(9)
            Db.closeCon()
            brand.Text = Db.getBrandName(brand_id).Item(0)
            Db.closeCon()
            os.Text = Db.getOsName(os_id).Item(0)
            Db.closeCon()
        Else
            delete.Enabled = False
            updateBtn.Enabled = False
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If condUpdate Then
            add.Enabled = False
            Search.Enabled = False
            delete.Enabled = False
            changeEnable()
            condUpdate = Not condUpdate
        Else
            If Validation() Then
                Dim brand_id As Integer = Db.getBrandId(brand.Text).Item(0)
                Db.closeCon()
                Dim os_id As Integer = Db.getOsId(os.Text).Item(0)
                Db.closeCon()
                Db.updateStoreItem(Val(id.Text), nameData.Text, Val(qty.Text), price.Text, brand_id, os_id, storage.Text, ram.Text, description.Text, ItemImage.ImageLocation)
                updateBtn.Enabled = False
                delete.Enabled = False
                add.Enabled = True
                Search.Enabled = True
                changeEnable()
                refreshDetail()
                condUpdate = Not condUpdate
                Main.refreshAllData()
            End If
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If Items.SelectedIndex <> -1 Then
            Db.deleteItem(Val(id.Text))
            refreshDetail()
            Main.refreshAllData()
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Clear()
        Search.Text = ""
        If Not condAdd Then
            condAdd = True
            Search.Enabled = True
            changeEnable()
        End If
        If Not condUpdate Then
            changeEnable()
            condUpdate = True
            add.Enabled = True
            Search.Enabled = True
            updateBtn.Enabled = False
        End If
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        delete.Enabled = False
        updateBtn.Enabled = False
        refreshDetail()
    End Sub
End Class
