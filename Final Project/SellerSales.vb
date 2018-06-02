Imports MySql.Data.MySqlClient

Public Class SellerSales
    Dim Db As Database = Main.getDB()
    Dim reader As MySqlDataReader
    Dim storeName As String
    Dim pasted As Boolean = False

    Private Function priceConverter(Data As Double) As String
        Dim newdata As Double = Val(CStr(Data))
        Dim slprice() As String = CStr(Data).Split(New Char() {","c})
        Try
            Return "Rp " + newdata.ToString("###,###") + "," + slprice(1)
        Catch ex As Exception
            Return "Rp " + newdata.ToString("###,###") + ",--"
        End Try
    End Function

    Public Sub setStoreName(store As String)
        storeName = store
    End Sub

    Private Sub setVisible(cond As Boolean)
        address.Visible = cond
        subDistrict.Visible = cond
        district.Visible = cond
        province.Visible = cond
        postal.Visible = cond
        country.Visible = cond
    End Sub

    Public Sub refreshDetail()
        allsales.Rows.Clear()
        If pasted Then
            setVisible(False)
            allsales.ReadOnly = Not allsales.ReadOnly
            reader = Db.getStoreFullfilmet(storeName, "FULLFILED", True)
        Else
            setVisible(True)
            allsales.ReadOnly = False
            reader = Db.getStoreFullfilmet(storeName, "FULLFILED", False)
        End If
        If reader.HasRows Then
            Do While reader.Read()
                allsales.Rows.Add(New String() {reader.Item(0), reader.Item(1), reader.Item(2), reader.Item(3), reader.Item(4), priceConverter(reader.Item(5)), priceConverter(reader.Item(6)), reader.Item(7), reader.Item(8), reader.Item(9), reader.Item(10), reader.Item(11), reader.Item(12)})
            Loop
        End If
        Db.closeCon()
        If pasted Then
            reader = Db.getTotalCurrent(storeName, "FULLFILED", True)
        Else
            reader = Db.getTotalCurrent(storeName, "FULLFILED", False)
        End If
        TotalRev.Text = priceConverter(reader.Item(0))
        Db.closeCon()

    End Sub

    Private Sub SellerSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StoreDetail.Enabled = False
        refreshDetail()

    End Sub
    Private Sub SellerSales_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        StoreDetail.Enabled = True
        StoreDetail.Focus()
    End Sub

    'Private Sub UserDeletingRow(ByVal sender As Object, ByVal e As DataGridViewRowEventArgs) Handles allsales.EditModeChanged
    ' Db.updateDetailTrans(e.Row.Cells(0).Value, e.Row.Cells(1).Value)
    'End Sub

    Private Sub sales_Click(sender As Object, e As EventArgs) Handles sales.Click
        If pasted Then
            pasted = Not pasted
            sales.Text = "Past Sales"
            Fulfilment.Enabled = True
        Else
            pasted = Not pasted
            sales.Text = "Current Sales"
            Fulfilment.Enabled = False
        End If
        refreshDetail()
    End Sub

    Private Sub Fulfilment_Click(sender As Object, e As EventArgs) Handles Fulfilment.Click
        For Each SelectedRow As DataGridViewRow In allsales.SelectedRows
            Db.updateDetailTrans(SelectedRow.Cells(0).Value, "FULLFILED")
        Next
        refreshDetail()
    End Sub

End Class