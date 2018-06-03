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
        Me.itemName.Location = New System.Drawing.Point(15, 17)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(218, 44)
        Me.itemName.TabIndex = 0
        Me.itemName.Text = "Item_Name"
        '
        'addCart
        '
        Me.addCart.Enabled = False
        Me.addCart.Location = New System.Drawing.Point(15, 78)
        Me.addCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addCart.Name = "addCart"
        Me.addCart.Size = New System.Drawing.Size(199, 33)
        Me.addCart.TabIndex = 1
        Me.addCart.Text = "Add to Cart"
        Me.addCart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Brand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'imagePic
        '
        Me.imagePic.Location = New System.Drawing.Point(23, 78)
        Me.imagePic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imagePic.Name = "imagePic"
        Me.imagePic.Size = New System.Drawing.Size(149, 150)
        Me.imagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagePic.TabIndex = 2
        Me.imagePic.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "OS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Storage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "RAM"
        '
        'brand
        '
        Me.brand.AutoSize = True
        Me.brand.Location = New System.Drawing.Point(104, 34)
        Me.brand.Name = "brand"
        Me.brand.Size = New System.Drawing.Size(51, 17)
        Me.brand.TabIndex = 9
        Me.brand.Text = "Label7"
        '
        'os
        '
        Me.os.AutoSize = True
        Me.os.Location = New System.Drawing.Point(104, 60)
        Me.os.Name = "os"
        Me.os.Size = New System.Drawing.Size(51, 17)
        Me.os.TabIndex = 10
        Me.os.Text = "Label8"
        '
        'storage
        '
        Me.storage.AutoSize = True
        Me.storage.Location = New System.Drawing.Point(104, 84)
        Me.storage.Name = "storage"
        Me.storage.Size = New System.Drawing.Size(51, 17)
        Me.storage.TabIndex = 11
        Me.storage.Text = "Label9"
        '
        'ram
        '
        Me.ram.AutoSize = True
        Me.ram.Location = New System.Drawing.Point(104, 111)
        Me.ram.Name = "ram"
        Me.ram.Size = New System.Drawing.Size(59, 17)
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
        Me.GroupBox1.Location = New System.Drawing.Point(189, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(341, 150)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Device Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.description)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 235)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(508, 130)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description"
        '
        'description
        '
        Me.description.BackColor = System.Drawing.SystemColors.Control
        Me.description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.description.Enabled = False
        Me.description.Location = New System.Drawing.Point(7, 20)
        Me.description.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(495, 105)
        Me.description.TabIndex = 14
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.Location = New System.Drawing.Point(556, 81)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(185, 29)
        Me.price.TabIndex = 16
        Me.price.Text = "Rp. Price_Label"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(600, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 17)
        Me.Label12.TabIndex = 17
        '
        'ShopName
        '
        Me.ShopName.AutoSize = True
        Me.ShopName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShopName.Location = New System.Drawing.Point(5, 27)
        Me.ShopName.Name = "ShopName"
        Me.ShopName.Size = New System.Drawing.Size(131, 25)
        Me.ShopName.TabIndex = 18
        Me.ShopName.Text = "Shop_Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ShopAddress)
        Me.GroupBox3.Controls.Add(Me.ShopName)
        Me.GroupBox3.Location = New System.Drawing.Point(551, 252)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(219, 113)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Shop Information"
        '
        'ShopAddress
        '
        Me.ShopAddress.BackColor = System.Drawing.SystemColors.Control
        Me.ShopAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ShopAddress.Enabled = False
        Me.ShopAddress.Location = New System.Drawing.Point(15, 55)
        Me.ShopAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ShopAddress.Multiline = True
        Me.ShopAddress.Name = "ShopAddress"
        Me.ShopAddress.Size = New System.Drawing.Size(197, 52)
        Me.ShopAddress.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 17)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Qty:"
        '
        'totalPrice
        '
        Me.totalPrice.AutoSize = True
        Me.totalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.totalPrice.Location = New System.Drawing.Point(57, 59)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(56, 17)
        Me.totalPrice.TabIndex = 22
        Me.totalPrice.Text = "Rp. 0,--"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 17)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Total: "
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(61, 27)
        Me.qty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(152, 22)
        Me.qty.TabIndex = 24
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.totalPrice)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.qty)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.addCart)
        Me.GroupBox4.Location = New System.Drawing.Point(551, 122)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(219, 124)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buy"
        '
        'BuyItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(784, 386)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.imagePic)
        Me.Controls.Add(Me.itemName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuyItem"
        Me.Text = "Item Details"
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
