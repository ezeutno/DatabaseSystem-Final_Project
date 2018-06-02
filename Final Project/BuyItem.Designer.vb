<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuyItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.itemName = New System.Windows.Forms.Label()
        Me.addCart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imagePic = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.brand = New System.Windows.Forms.Label()
        Me.os = New System.Windows.Forms.Label()
        Me.storage = New System.Windows.Forms.Label()
        Me.ram = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.description = New System.Windows.Forms.TextBox()
        Me.price = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ShopName = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ShopAddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.totalPrice = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.imagePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'itemName
        '
        Me.itemName.AutoSize = True
        Me.itemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemName.Location = New System.Drawing.Point(11, 14)
        Me.itemName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(164, 36)
        Me.itemName.TabIndex = 0
        Me.itemName.Text = "Item_Name"
        '
        'addCart
        '
        Me.addCart.Enabled = False
        Me.addCart.Location = New System.Drawing.Point(11, 63)
        Me.addCart.Margin = New System.Windows.Forms.Padding(2)
        Me.addCart.Name = "addCart"
        Me.addCart.Size = New System.Drawing.Size(149, 27)
        Me.addCart.TabIndex = 1
        Me.addCart.Text = "Add to Cart"
        Me.addCart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Brand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'imagePic
        '
        Me.imagePic.Location = New System.Drawing.Point(17, 63)
        Me.imagePic.Margin = New System.Windows.Forms.Padding(2)
        Me.imagePic.Name = "imagePic"
        Me.imagePic.Size = New System.Drawing.Size(112, 122)
        Me.imagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagePic.TabIndex = 2
        Me.imagePic.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "OS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Storage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "RAM"
        '
        'brand
        '
        Me.brand.AutoSize = True
        Me.brand.Location = New System.Drawing.Point(78, 28)
        Me.brand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.brand.Name = "brand"
        Me.brand.Size = New System.Drawing.Size(39, 13)
        Me.brand.TabIndex = 9
        Me.brand.Text = "Label7"
        '
        'os
        '
        Me.os.AutoSize = True
        Me.os.Location = New System.Drawing.Point(78, 49)
        Me.os.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.os.Name = "os"
        Me.os.Size = New System.Drawing.Size(39, 13)
        Me.os.TabIndex = 10
        Me.os.Text = "Label8"
        '
        'storage
        '
        Me.storage.AutoSize = True
        Me.storage.Location = New System.Drawing.Point(78, 68)
        Me.storage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.storage.Name = "storage"
        Me.storage.Size = New System.Drawing.Size(39, 13)
        Me.storage.TabIndex = 11
        Me.storage.Text = "Label9"
        '
        'ram
        '
        Me.ram.AutoSize = True
        Me.ram.Location = New System.Drawing.Point(78, 90)
        Me.ram.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ram.Name = "ram"
        Me.ram.Size = New System.Drawing.Size(45, 13)
        Me.ram.TabIndex = 12
        Me.ram.Text = "Label10"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ram)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.storage)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.os)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.brand)
        Me.GroupBox1.Location = New System.Drawing.Point(142, 63)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(256, 122)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Device Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.description)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 191)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(381, 106)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description"
        '
        'description
        '
        Me.description.BackColor = System.Drawing.SystemColors.Control
        Me.description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.description.Enabled = False
        Me.description.Location = New System.Drawing.Point(5, 16)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(371, 85)
        Me.description.TabIndex = 14
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.Location = New System.Drawing.Point(417, 66)
        Me.price.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(143, 24)
        Me.price.TabIndex = 16
        Me.price.Text = "Rp. Price_Label"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(450, 214)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 17
        '
        'ShopName
        '
        Me.ShopName.AutoSize = True
        Me.ShopName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShopName.Location = New System.Drawing.Point(4, 22)
        Me.ShopName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ShopName.Name = "ShopName"
        Me.ShopName.Size = New System.Drawing.Size(107, 20)
        Me.ShopName.TabIndex = 18
        Me.ShopName.Text = "Shop_Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ShopAddress)
        Me.GroupBox3.Controls.Add(Me.ShopName)
        Me.GroupBox3.Location = New System.Drawing.Point(413, 205)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(164, 92)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Shop Information"
        '
        'ShopAddress
        '
        Me.ShopAddress.BackColor = System.Drawing.SystemColors.Control
        Me.ShopAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ShopAddress.Enabled = False
        Me.ShopAddress.Location = New System.Drawing.Point(11, 45)
        Me.ShopAddress.Multiline = True
        Me.ShopAddress.Name = "ShopAddress"
        Me.ShopAddress.Size = New System.Drawing.Size(148, 42)
        Me.ShopAddress.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 24)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Qty:"
        '
        'totalPrice
        '
        Me.totalPrice.AutoSize = True
        Me.totalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.totalPrice.Location = New System.Drawing.Point(43, 48)
        Me.totalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(42, 13)
        Me.totalPrice.TabIndex = 22
        Me.totalPrice.Text = "Rp. 0,--"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 48)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Total: "
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(46, 22)
        Me.qty.Margin = New System.Windows.Forms.Padding(2)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(114, 20)
        Me.qty.TabIndex = 24
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.totalPrice)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.qty)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.addCart)
        Me.GroupBox4.Location = New System.Drawing.Point(413, 99)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(164, 101)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buy"
        '
        'BuyItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(588, 314)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.imagePic)
        Me.Controls.Add(Me.itemName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuyItem"
        Me.Text = "BuyItem"
        CType(Me.imagePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemName As Label
    Friend WithEvents addCart As Button
    Friend WithEvents imagePic As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents brand As Label
    Friend WithEvents os As Label
    Friend WithEvents storage As Label
    Friend WithEvents ram As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents price As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ShopName As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents totalPrice As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents qty As NumericUpDown
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents description As TextBox
    Friend WithEvents ShopAddress As TextBox
End Class
