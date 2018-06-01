Imports MySql.Data.MySqlClient

Public Class ChooseAddress
    Dim Db As Database = Main.getDB()
    Dim reader As MySqlDataReader
    Private Sub address_SelectedIndexChanged(sender As Object, e As EventArgs) Handles address.SelectedIndexChanged
        If address.SelectedIndex <> -1 Then
            submit.Enabled = True
        End If
    End Sub

    Private Sub ChooseAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reader = Db.getUserAddress(Main.getUsername())
        If reader.HasRows Then
            Do While reader.Read()
                address.Items.Add(reader.Item(0))
            Loop
        End If
        Db.closeCon()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim loc As Integer = Db.getAddressId(Main.getUsername(), address.SelectedItem.ToString).Item(0)
        Db.closeCon()
        Db.updateTransactionAddress(Main.getTransId(), loc)
        Main.newTransaction()
        CartDetail.refreshDetail()
        Me.Dispose()
    End Sub
End Class