Imports MySql.Data.MySqlClient

Public Class Main
    Dim data As Boolean = True
    Dim currentPoint As Integer = 0
    Dim Db As Database = New Database
    Dim reader As MySqlDataReader
    Dim userLogin As String = "Stranger!"
    Dim currTrans As Integer

    Private Function getLoginTerm() As Boolean
        Return data
    End Function

    Public Function getDB() As Database
        Return Db
    End Function

    Public Function getLoginCond() As Boolean
        Return Not data
    End Function

    Public Function getTransId() As Integer
        Return currTrans
    End Function

    Public Sub newTransaction()
        If Not Db.checkTransactionExists(userLogin) Then
            Db.closeCon()
            Db.insertNewTransaction(userLogin)
        Else
            Db.closeCon()
        End If
        currTrans = Db.getTransactionId(userLogin).Item(0)
        Db.closeCon()
    End Sub

    Public Sub loginEx()
        newTransaction()
        SetLoginBtn("Log-Out", LoginBtn.Width / 2)
        Store.Visible = Not Store.Visible
        Cart.Enabled = True
        changeLoginTerm()
    End Sub

    Private Sub changeLoginTerm()
        Me.data = Not data
    End Sub

    Public Sub setUsername()
        Username.Text = "Hello, Stranger!"
        userLogin = "Stranger!"
        Username.Refresh()
    End Sub

    Public Sub setUsername(User As String)
        Username.Text = "Welcome, " + Db.getFname(User).Item(0) + "!"
        Db.closeCon()
        userLogin = User
        Username.Refresh()
    End Sub

    Public Function getUsername() As String
        Return userLogin
    End Function

    Public Function getUsernameTextBox() As TextBox
        Return Username
    End Function

    Public Sub SetLoginBtn(login As String, width As Integer)
        LoginBtn.Text = login
        LoginBtn.Width = width
        LoginBtn.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginBtn.Width *= 2
        Username.Enabled = False
        Db.ConnectDB()
        refreshAllData()
        refreshSearchBy()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If getLoginTerm() Then
            Login.Show()
            Username.Enabled = True
            Me.Enabled = False
        Else
            SetLoginBtn("Log-In/Register", LoginBtn.Width * 2)
            setUsername()
            Cart.Enabled = False
            Username.Enabled = False
            Store.Visible = Not Store.Visible
            changeLoginTerm()
        End If
    End Sub

    Private Sub Username_Click(sender As Object, e As EventArgs) Handles Username.Click
        Me.Enabled = False
        UserDetail.Show()
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        refreshAllData()
    End Sub

    Private Sub brand_TextChanged(sender As Object, e As EventArgs) Handles brand.TextChanged
        refreshAllData()
    End Sub

    Private Sub os_TextChanged(sender As Object, e As EventArgs) Handles brand.TextChanged
        refreshAllData()
    End Sub

    Private Sub brand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles brand.SelectedIndexChanged
        refreshAllData()
    End Sub

    Private Sub Os_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Os.SelectedIndexChanged
        refreshAllData()
    End Sub

    Private Sub Cart_Click(sender As Object, e As EventArgs) Handles Cart.Click
        CartDetail.Show()
    End Sub

    Private Sub Store_Click(sender As Object, e As EventArgs) Handles Store.Click
        If Db.checkStoreAddress(getUsername()) Then
            Db.closeCon()
            StoreDetail.Show()
        Else
            Db.closeCon()
            CreateStore.Show()
        End If
    End Sub

    Private Sub CurrentTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentTime.Tick
        Time.Text = Now
    End Sub

    Public Sub refreshAllData()
        currentPoint = 0
        refreshRun()
    End Sub

    Private Sub subRun(gp As GroupBox, image As PictureBox, id As Label, name As Label, price As Label)
        Try
            If reader.HasRows Then
                If reader.Read() Then
                    Display_Project(gp, image, id, name, price, {reader.Item(0), reader.Item(1), reader.Item(2), reader.Item(3)})
                Else
                    Display_Project(gp)
                End If
            Else
                Display_Project(gp)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub refreshRun()
        If NameOB.Checked Then
            reader = Db.getAllItem(currentPoint, Search.Text, brand.Text, Os.Text, "name", Asc.Checked)
        ElseIf PriceOB.Checked Then
            reader = Db.getAllItem(currentPoint, Search.Text, brand.Text, Os.Text, "price", Asc.Checked)
        Else
            reader = Db.getAllItem(currentPoint, Search.Text, brand.Text, Os.Text)
        End If
        subRun(Item1, ImageItem1, idItem1, NameItem1, PriceItem1)
        subRun(Item2, ImageItem2, idItem2, NameItem2, PriceItem2)
        subRun(Item3, ImageItem3, idItem3, NameItem3, PriceItem3)
        subRun(Item4, ImageItem4, idItem4, NameItem4, PriceItem4)
        subRun(Item5, ImageItem5, idItem5, NameItem5, PriceItem5)
        subRun(Item6, ImageItem6, idItem6, NameItem6, PriceItem6)
        subRun(item7, ImageItem7, idItem7, NameItem7, PriceItem7)
        subRun(Item8, ImageItem8, idItem8, NameItem8, PriceItem8)
        Db.closeCon()
        If currentPoint + 8 >= Db.getCountItems(Search.Text, brand.Text, Os.Text).Item(0) Then
            NextBtn.Enabled = False
        Else
            NextBtn.Enabled = True
        End If
        Db.closeCon()
        If currentPoint - 8 < 0 Then
            PrevBtn.Enabled = False
        Else
            PrevBtn.Enabled = True
        End If
    End Sub

    Public Sub refreshSearchBy()
        Os.Items.Clear()
        reader = Db.getAllOS()
        If reader.HasRows Then
            Do While reader.Read()
                Os.Items.Add(reader.Item(0))
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
    End Sub

    Private Sub Display_Project(gp As GroupBox)
        gp.Visible = False
    End Sub

    Private Sub Display_Project(gp As GroupBox, image As PictureBox, id As Label, name As Label, price As Label, data() As String)
        gp.Visible = True
        image.ImageLocation = ""
        image.ImageLocation = data(2)
        id.Text = data(0)
        name.Text = data(1)
        Dim revalue As Double = Val(data(3))
        Dim slprice() As String = data(3).Split(New Char() {","c})
        If slprice.Length > 1 Then
            price.Text = "Rp " + revalue.ToString("###,###") + "," + slprice(1)
        Else
            price.Text = "Rp " + revalue.ToString("###,###") + ",--"
        End If
    End Sub

    Private Sub Clicked_Project(id As Label)
        BuyItem.setItemId(Val(id.Text))
        BuyItem.Show()
    End Sub

    'Distribute System'
    Private Sub Item1_Click(sender As Object, e As EventArgs) Handles Item1.Click
        Clicked_Project(idItem1)
    End Sub
    Private Sub Item2_Click(sender As Object, e As EventArgs) Handles Item2.Click
        Clicked_Project(idItem2)
    End Sub
    Private Sub Item3_Click(sender As Object, e As EventArgs) Handles Item3.Click
        Clicked_Project(idItem3)
    End Sub
    Private Sub Item4_Click(sender As Object, e As EventArgs) Handles Item4.Click
        Clicked_Project(idItem4)
    End Sub
    Private Sub Item5_Click(sender As Object, e As EventArgs) Handles Item5.Click
        Clicked_Project(idItem5)
    End Sub
    Private Sub Item6_Click(sender As Object, e As EventArgs) Handles Item6.Click
        Clicked_Project(idItem6)
    End Sub
    Private Sub Item7_Click(sender As Object, e As EventArgs) Handles item7.Click
        Clicked_Project(idItem7)
    End Sub
    Private Sub Item8_Click(sender As Object, e As EventArgs) Handles Item8.Click
        Clicked_Project(idItem8)
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        currentPoint += 8
        refreshRun()
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        currentPoint -= 8
        refreshRun()
    End Sub

    Private Sub NameOB_CheckedChanged(sender As Object, e As EventArgs) Handles NameOB.CheckedChanged
        refreshAllData()
    End Sub

    Private Sub PriceOB_CheckedChanged(sender As Object, e As EventArgs) Handles PriceOB.CheckedChanged
        refreshAllData()
    End Sub

    Private Sub Asc_CheckedChanged(sender As Object, e As EventArgs) Handles Asc.CheckedChanged
        If NameOB.Checked Or PriceOB.Checked Then
            refreshAllData()
        End If
    End Sub

    Private Sub Dsc_CheckedChanged(sender As Object, e As EventArgs) Handles Dsc.CheckedChanged
        If NameOB.Checked Or PriceOB.Checked Then
            refreshAllData()
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        NameOB.Checked = False
        PriceOB.Checked = False
        Dsc.Checked = False
        Asc.Checked = True
        brand.Text = ""
        Os.Text = ""
        Search.Text = ""
        refreshAllData()
    End Sub

End Class
