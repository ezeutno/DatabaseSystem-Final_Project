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
            reader = Db.getStoreFullfilmet(storeName, {"FULLFILLED", "REJECTED"}, True)
        Else
            setVisible(True)
            allsales.ReadOnly = False
            reader = Db.getStoreFullfilmet(storeName, {"FULLFILLED", "REJECTED"}, False)
        End If
        If reader.HasRows Then
            Do While reader.Read()
                allsales.Rows.Add(New String() {reader.Item(0), reader.Item(1), reader.Item(2), reader.Item(3), reader.Item(4), reader.Item(5), priceConverter(reader.Item(6)), priceConverter(reader.Item(7)), reader.Item(8), reader.Item(9), reader.Item(10), reader.Item(11), reader.Item(12), reader.Item(13)})
            Loop
        End If
        Db.closeCon()
        If pasted Then
            reader = Db.getTotalCurrent(storeName, {"FULLFILLED", "REJECTED"}, True)
        Else
            reader = Db.getTotalCurrent(storeName, {"FULLFILLED", "REJECTED"}, False)
        End If
        Try
            TotalRev.Text = priceConverter(reader.Item(0))
        Catch ex As Exception
            TotalRev.Text = "Rp -,--"
        End Try

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

    Private Sub dataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles allsales.CellEndEdit
        Db.updateDetailTrans(allsales(0, e.RowIndex).Value, allsales(e.ColumnIndex, e.RowIndex).Value)
    End Sub

    Private Sub sales_Click(sender As Object, e As EventArgs) Handles sales.Click
        If pasted Then
            pasted = Not pasted
            sales.Text = "Past Sales"
            Fulfillment.Enabled = True
            reject.Enabled = True
        Else
            pasted = Not pasted
            sales.Text = "Current Sales"
            Fulfillment.Enabled = False
            reject.Enabled = False
        End If
        refreshDetail()
    End Sub

    Private Sub Fulfilment_Click(sender As Object, e As EventArgs) Handles Fulfillment.Click
        Dim errorValue As String = "An Error Occured : "
        For Each SelectedRow As DataGridViewRow In allsales.SelectedRows
            If SelectedRow.Cells("status").Value <> "On Process" Then
                Db.updateDetailTrans(SelectedRow.Cells(0).Value, "FULLFILLED")
            Else
                errorValue += vbNewLine + "Transaction: " + SelectedRow.Cells("username").Value + "-" + SelectedRow.Cells("item").Value + " hasn't been sent!"
            End If
        Next
        If errorValue <> "An Error Occured : " Then
            MessageBox.Show(errorValue)
        End If
        refreshDetail()
    End Sub

    Private Sub reject_Click(sender As Object, e As EventArgs) Handles reject.Click
        For Each SelectedRow As DataGridViewRow In allsales.SelectedRows
            Db.updateDetailTrans(SelectedRow.Cells(0).Value, "REJECTED")
            Db.updateItem(SelectedRow.Cells(1).Value, SelectedRow.Cells(5).Value, True)
            StoreDetail.refreshDetail()
            Main.refreshAllData()
        Next
        refreshDetail()
    End Sub
End Class