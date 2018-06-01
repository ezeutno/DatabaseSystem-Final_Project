Imports MySql.Data.MySqlClient

Public Class Main
    Dim data As Boolean = True
    Dim currentPoint As Integer = 0
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
        refreshRun()
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
        refreshAllData()
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

    Private Sub subRun(gp As GroupBox, image As PictureBox, id As Label, name As Label, price As Label)
        If reader.HasRows Then
            If reader.Read() Then
                Display_Project(gp, image, id, name, price, {reader.Item(1), reader.Item(9), reader.Item(0), reader.Item(3)})
            Else
                Display_Project(gp)
            End If
        End If
    End Sub

    Public Sub refreshAllData()
        currentPoint = 0
        refreshRun()
    End Sub

    Private Sub refreshRun()
        reader = Db.getAllItem(currentPoint, Search.Text)
        subRun(Item1, ImageItem1, idItem1, NameItem1, PriceItem1)
        subRun(Item2, ImageItem2, idItem2, NameItem2, PriceItem2)
        subRun(Item3, ImageItem3, idItem3, NameItem3, PriceItem3)
        subRun(Item4, ImageItem4, idItem4, NameItem4, PriceItem4)
        subRun(Item5, ImageItem5, idItem5, NameItem5, PriceItem5)
        subRun(Item6, ImageItem6, idItem6, NameItem6, PriceItem6)
        subRun(item7, ImageItem7, idItem7, NameItem7, PriceItem7)
        subRun(Item8, ImageItem8, idItem8, NameItem8, PriceItem8)
        Db.closeCon()
        If currentPoint + 8 >= Db.getCountItems(Search.Text).Item(0) Then
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

    Private Sub Display_Project(gp As GroupBox)
        gp.Visible = False
    End Sub

    Private Sub Display_Project(gp As GroupBox, image As PictureBox, id As Label, name As Label, price As Label, data() As String)
        gp.Visible = True
        image.ImageLocation = ""
        image.ImageLocation = data(1)
        id.Text = data(2)
        name.Text = data(0)
        price.Text = "Rp " + data(3)
    End Sub

    Private Sub Clicked_Project(id As Label)
        MessageBox.Show(id.Text)
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
End Class
