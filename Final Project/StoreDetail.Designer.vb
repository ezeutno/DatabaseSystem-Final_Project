<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StoreDetail
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
        Me.StoreTitle = New System.Windows.Forms.Label()
        Me.Items = New System.Windows.Forms.ListBox()
        Me.ItemImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameData = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.id = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ram = New System.Windows.Forms.TextBox()
        Me.storage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.description = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.os = New System.Windows.Forms.ComboBox()
        Me.brand = New System.Windows.Forms.ComboBox()
        Me.price = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.StoreAddress = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Sales = New System.Windows.Forms.Button()
        CType(Me.ItemImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StoreTitle
        '
        Me.StoreTitle.AutoSize = True
        Me.StoreTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.StoreTitle.Location = New System.Drawing.Point(17, 9)
        Me.StoreTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StoreTitle.Name = "StoreTitle"
        Me.StoreTitle.Size = New System.Drawing.Size(172, 39)
        Me.StoreTitle.TabIndex = 0
        Me.StoreTitle.Text = "Store Title"
        '
        'Items
        '
        Me.Items.FormattingEnabled = True
        Me.Items.Location = New System.Drawing.Point(240, 126)
        Me.Items.Margin = New System.Windows.Forms.Padding(2)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(158, 316)
        Me.Items.TabIndex = 1
        '
        'ItemImage
        '
        Me.ItemImage.Enabled = False
        Me.ItemImage.Location = New System.Drawing.Point(85, 15)
        Me.ItemImage.Margin = New System.Windows.Forms.Padding(2)
        Me.ItemImage.Name = "ItemImage"
        Me.ItemImage.Size = New System.Drawing.Size(112, 122)
        Me.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemImage.TabIndex = 2
        Me.ItemImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Image"
        '
        'nameData
        '
        Me.nameData.Enabled = False
        Me.nameData.Location = New System.Drawing.Point(75, 141)
        Me.nameData.Margin = New System.Windows.Forms.Padding(2)
        Me.nameData.Name = "nameData"
        Me.nameData.Size = New System.Drawing.Size(132, 20)
        Me.nameData.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.qty)
        Me.GroupBox1.Controls.Add(Me.delete)
        Me.GroupBox1.Controls.Add(Me.updateBtn)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ram)
        Me.GroupBox1.Controls.Add(Me.storage)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.description)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.os)
        Me.GroupBox1.Controls.Add(Me.brand)
        Me.GroupBox1.Controls.Add(Me.price)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ItemImage)
        Me.GroupBox1.Controls.Add(Me.nameData)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(220, 411)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Details"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(7, 15)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(15, 13)
        Me.id.TabIndex = 29
        Me.id.Text = "id"
        Me.id.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(185, 284)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "GB"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(185, 265)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "GB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 166)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Quantity"
        '
        'qty
        '
        Me.qty.Enabled = False
        Me.qty.Location = New System.Drawing.Point(75, 163)
        Me.qty.Margin = New System.Windows.Forms.Padding(2)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(132, 20)
        Me.qty.TabIndex = 25
        '
        'delete
        '
        Me.delete.Enabled = False
        Me.delete.Location = New System.Drawing.Point(102, 379)
        Me.delete.Margin = New System.Windows.Forms.Padding(2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(71, 27)
        Me.delete.TabIndex = 24
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Enabled = False
        Me.updateBtn.Location = New System.Drawing.Point(27, 378)
        Me.updateBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(71, 28)
        Me.updateBtn.TabIndex = 23
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 284)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "RAM"
        '
        'ram
        '
        Me.ram.Enabled = False
        Me.ram.Location = New System.Drawing.Point(75, 281)
        Me.ram.Margin = New System.Windows.Forms.Padding(2)
        Me.ram.Name = "ram"
        Me.ram.Size = New System.Drawing.Size(109, 20)
        Me.ram.TabIndex = 21
        '
        'storage
        '
        Me.storage.Enabled = False
        Me.storage.Location = New System.Drawing.Point(75, 258)
        Me.storage.Margin = New System.Windows.Forms.Padding(2)
        Me.storage.Name = "storage"
        Me.storage.Size = New System.Drawing.Size(109, 20)
        Me.storage.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 293)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 306)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 261)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Storage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 238)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "OS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Price"
        '
        'description
        '
        Me.description.Enabled = False
        Me.description.Location = New System.Drawing.Point(75, 306)
        Me.description.Margin = New System.Windows.Forms.Padding(2)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(132, 68)
        Me.description.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Name"
        '
        'os
        '
        Me.os.Enabled = False
        Me.os.FormattingEnabled = True
        Me.os.Location = New System.Drawing.Point(75, 235)
        Me.os.Margin = New System.Windows.Forms.Padding(2)
        Me.os.Name = "os"
        Me.os.Size = New System.Drawing.Size(132, 21)
        Me.os.TabIndex = 8
        '
        'brand
        '
        Me.brand.Enabled = False
        Me.brand.FormattingEnabled = True
        Me.brand.Location = New System.Drawing.Point(75, 210)
        Me.brand.Margin = New System.Windows.Forms.Padding(2)
        Me.brand.Name = "brand"
        Me.brand.Size = New System.Drawing.Size(132, 21)
        Me.brand.TabIndex = 7
        '
        'price
        '
        Me.price.Enabled = False
        Me.price.Location = New System.Drawing.Point(75, 187)
        Me.price.Margin = New System.Windows.Forms.Padding(2)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(132, 20)
        Me.price.TabIndex = 5
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(240, 446)
        Me.add.Margin = New System.Windows.Forms.Padding(2)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(77, 28)
        Me.add.TabIndex = 25
        Me.add.Text = "Add Item"
        Me.add.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(321, 446)
        Me.cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(77, 27)
        Me.cancel.TabIndex = 24
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'StoreAddress
        '
        Me.StoreAddress.AutoSize = True
        Me.StoreAddress.Location = New System.Drawing.Point(21, 48)
        Me.StoreAddress.Name = "StoreAddress"
        Me.StoreAddress.Size = New System.Drawing.Size(73, 13)
        Me.StoreAddress.TabIndex = 26
        Me.StoreAddress.Text = "Store Address"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Search)
        Me.GroupBox2.Location = New System.Drawing.Point(240, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 53)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(7, 20)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(145, 20)
        Me.Search.TabIndex = 0
        '
        'Sales
        '
        Me.Sales.Location = New System.Drawing.Point(321, 9)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(76, 23)
        Me.Sales.TabIndex = 28
        Me.Sales.Text = "All Sales"
        Me.Sales.UseVisualStyleBackColor = True
        '
        'StoreDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(412, 489)
        Me.Controls.Add(Me.Sales)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StoreAddress)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Items)
        Me.Controls.Add(Me.StoreTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StoreDetail"
        Me.Text = "My Store"
        CType(Me.ItemImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StoreTitle As Label
    Friend WithEvents Items As ListBox
    Friend WithEvents ItemImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nameData As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ram As TextBox
    Friend WithEvents storage As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents description As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents os As ComboBox
    Friend WithEvents brand As ComboBox
    Friend WithEvents price As TextBox
    Friend WithEvents add As Button
    Friend WithEvents delete As Button
    Friend WithEvents cancel As Button
    Friend WithEvents StoreAddress As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents qty As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Search As TextBox
    Friend WithEvents id As Label
    Friend WithEvents Sales As Button
End Class
