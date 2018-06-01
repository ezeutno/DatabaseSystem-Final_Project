Imports MySql.Data.MySqlClient

Public Class Main
    Dim data As Boolean = True
    Dim Db As Database = New Database
    Dim reader As MySqlDataReader

    Private Function getLoginTerm() As Boolean
        Return data
    End Function

    Public Function getDB() As Database
        Return Db
    End Function

    Public Sub loginEx()
        SetLoginBtn("Log-Out", LoginBtn.Width / 2)
        Store.Visible = Not Store.Visible
        changeLoginTerm()
    End Sub

    Private Sub changeLoginTerm()
        Me.data = Not data
    End Sub

    Public Sub setUsername(User As String)
        Username.Text = User
        Username.Refresh()
    End Sub

    Public Function getUsername() As String
        Return Username.Text
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
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If getLoginTerm() Then
            Login.Show()
            Username.Enabled = True
            Me.Enabled = False
        Else
            SetLoginBtn("Log-In", LoginBtn.Width * 2)
            setUsername("Username")
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
        MessageBox.Show("(SEARCH BOX) Text has change to : " + Search.Text)
    End Sub

    Private Sub Cart_Click(sender As Object, e As EventArgs) Handles Cart.Click
        MessageBox.Show("Open Cart Result")
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

    Public Sub Run()

    End Sub

    Private Sub Display_Project(gp As GroupBox, gpCond As Boolean, image As PictureBox, id As Label, name As Label, price As Label, data() As String)
        If gpCond Then
            gp.Visible = gpCond
            image.ImageLocation = data(0)
            id.Text = data(1)
            name.Text = data(2)
            price.Text = "Rp " + data(3)
        Else
            gp.Visible = gpCond
        End If
    End Sub

    Private Sub Clicked_Project(id As Label)
        MessageBox.Show(id.Text)
    End Sub

    'Distribute System'
    Private Sub Item1_Click(sender As Object, e As EventArgs) Handles Item1.Click
        Clicked_Project(idItem1)
        Display_Project(Item1, True, ImageItem1, idItem1, NameItem1, PriceItem1, {"https://www.91-img.com/pictures/121008-v1-apple-iphone-x-mobile-phone-large-1.jpg", "12", "MART_TEST", "0000"})
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

End Class
