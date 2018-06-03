Imports MySql.Data.MySqlClient

Public Class CartDetail
    Dim reader As MySqlDataReader
    Dim Db As Database = Main.getDB()
    Dim past As Boolean = False

    Private Function priceConverter(Data As Double) As String
        Dim newdata As Double = Val(CStr(Data))
        Dim slprice() As String = CStr(Data).Split(New Char() {","c})
        Try
            Return "Rp " + newdata.ToString("###,###") + "," + slprice(1)
        Catch ex As Exception
            Return "Rp " + newdata.ToString("###,###") + ",--"
        End Try
    End Function

    Public Sub refreshTotal()
        Try
            If past Then
                Total.Text = priceConverter(Db.getTotalTrans(Main.getUsername()).Item(0))
            Else
                Total.Text = priceConverter(Db.getTotalTrans(Main.getTransId()).Item(0))
            End If
        Catch ex As Exception
            Total.Text = "Rp. ,--"
        End Try
        Db.closeCon()
    End Sub


    Public Sub refreshDetail()
        transactionCart.Rows.Clear()
        If past Then
            transId.Visible = True
            Status.Visible = True
            transactionCart.AllowUserToDeleteRows = False
            reader = Db.getDetailTransaction(Main.getUsername())
        Else
            transId.Visible = False
            Status.Visible = False
            transactionCart.AllowUserToDeleteRows = True
            reader = Db.getDetailTransaction(Main.getTransId())
        End If
        If reader.HasRows Then
            Do While reader.Read()
                transactionCart.Rows.Add(New String() {reader.Item(2), reader.Item(0), reader.Item(1), reader.Item(3), reader.Item(4), priceConverter(reader.Item(5)), reader.Item(6), priceConverter(reader.Item(7)), reader.Item(8)})
            Loop
        End If
        Db.closeCon()
        refreshTotal()
    End Sub

    Private Sub UserDeletingRow(ByVal sender As Object, ByVal e As DataGridViewRowCancelEventArgs) Handles transactionCart.UserDeletingRow
        Db.deleteDetailTrans(e.Row.Cells(0).Value)
        refreshTotal()
    End Sub

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Enabled = False
        refreshDetail()
    End Sub
    Private Sub Cart_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Main.Enabled = True
        Main.Focus()
    End Sub

    Private Sub Buy_Click(sender As Object, e As EventArgs) Handles Buy.Click
        If Purchase.Text = "Current Cart" Then
            For Each SelectedRow As DataGridViewRow In transactionCart.SelectedRows
                If Not SelectedRow.Cells(8).Value = "REJECTED" Then
                    Db.updateDetailTrans(SelectedRow.Cells(0).Value, "FULLFILLED")
                End If
            Next
            refreshDetail()
        Else
            Dim errorValue As String = "An Error Occured : "
            Dim total As Integer = 0
            For Each r As DataGridViewRow In transactionCart.Rows
                If Db.checkAvQuantity(r.Cells(3).Value, r.Cells(6).Value) Then
                    Db.closeCon()
                    Db.updateItem(r.Cells(3).Value, r.Cells(6).Value, False)
                Else
                    Db.closeCon()
                    errorValue += vbNewLine + Db.getItemDetails(r.Cells(3).Value).Item(1) + " no more stocks! (Auto Delete)"
                    Db.closeCon()
                    Db.deleteDetailTrans(r.Cells(0).Value)
                    Db.closeCon()
                    total -= 1
                End If
                total += 1
            Next

            If Db.checkAddress(Main.getUsername()) Then
                Db.closeCon()
                If total > 0 Then
                    ChooseAddress.Show()
                Else
                    errorValue += vbNewLine + "You haven't bought anything!"
                End If
            Else
                errorValue += vbNewLine + "Please create your address first for shipping!"
                Db.closeCon()
            End If
            If errorValue IsNot "An Error Occured : " Then MessageBox.Show(errorValue)
        End If
    End Sub

    Private Sub Purchase_Click(sender As Object, e As EventArgs) Handles Purchase.Click
        If past Then
            Buy.Text = "Buy Now"
            Purchase.Text = "Purchased History"
        Else
            Buy.Text = "Fullfilled"
            Purchase.Text = "Current Cart"
        End If
        past = Not past
        refreshDetail()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class