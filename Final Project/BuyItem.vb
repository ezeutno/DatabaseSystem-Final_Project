Imports MySql.Data.MySqlClient

Public Class BuyItem
    Dim Db As Database = Main.getDB()
    Dim reader As MySqlDataReader
    Dim item_id As Integer

    Public Sub setItemId(ByVal id As Integer)
        item_id = id
    End Sub

    Private Sub BuyItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Enabled = False
        If Main.getLoginCond() Then
            If Not Db.checkItemOwnerShip(item_id, Main.getUsername()) Then
                addCart.Enabled = True
            End If
        End If
        Db.closeCon()
        reader = Db.getItemDetails(item_id)
        itemName.Text = reader.Item(1)
        qty.Maximum = reader.Item(2)
        Dim revalue As Double = Val(CStr(reader.Item(3)))
        Dim slprice() As String = CStr(reader.Item(3)).Split(New Char() {","c})
        Try
            price.Text = "Rp " + revalue.ToString("###,###") + "," + slprice(1)
        Catch ex As Exception
            price.Text = "Rp " + revalue.ToString("###,###") + ",--"
        End Try
        Dim brand_id As Integer = reader.Item(4)
        Dim os_id As Integer = reader.Item(5)
        storage.Text = CStr(reader.Item(6)) + " GB"
        ram.Text = CStr(reader.Item(7)) + " GB"
        description.Text = reader.Item(8)
        imagePic.ImageLocation = reader.Item(9)
        ShopName.Text = reader.Item(10)
        Db.closeCon()
        brand.Text = Db.getBrandName(brand_id).Item(0)
        Db.closeCon()
        os.Text = Db.getOsName(os_id).Item(0)
        Db.closeCon()
        ShopAddress.Text = Db.getStoreAddress(ShopName.Text).Item(0)
        Db.closeCon()
    End Sub

    Private Sub BuyItem_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Main.Enabled = True
        Main.Focus()
    End Sub

    Private Sub qty_ValueChanged(sender As Object, e As EventArgs) Handles qty.ValueChanged
        reader = Db.getTotalPrice(item_id, qty.Value)
        Dim revalue As Double = Val(CStr(reader.Item(0)))
        Dim slprice() As String = CStr(reader.Item(0)).Split(New Char() {","c})
        Try
            totalPrice.Text = "Rp " + revalue.ToString("###,###") + "," + slprice(1)
        Catch ex As Exception
            totalPrice.Text = "Rp " + revalue.ToString("###,###") + ",--"
        End Try
        Db.closeCon()
    End Sub

    Private Sub addCart_Click(sender As Object, e As EventArgs) Handles addCart.Click
        If qty.Value > 0 Then
            Db.insertDetailTrans(item_id, qty.Value, Main.getTransId())
            Main.Enabled = True
            Main.Focus()
            Me.Dispose()
        Else
            MessageBox.Show("Quantity must be more than 0!")
        End If
    End Sub
End Class