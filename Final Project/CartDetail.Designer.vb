<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.transactionCart = New System.Windows.Forms.DataGridView()
        Me.DetailTransactionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Store = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purchase = New System.Windows.Forms.Button()
        Me.Buy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        CType(Me.transactionCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'transactionCart
        '
        Me.transactionCart.AllowUserToAddRows = False
        Me.transactionCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.transactionCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailTransactionId, Me.transId, Me.Store, Me.ItemId, Me.itemName, Me.price, Me.qty, Me.subtotal, Me.Status})
        Me.transactionCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.transactionCart.Location = New System.Drawing.Point(11, 11)
        Me.transactionCart.Margin = New System.Windows.Forms.Padding(2)
        Me.transactionCart.Name = "transactionCart"
        Me.transactionCart.ReadOnly = True
        Me.transactionCart.RowTemplate.Height = 24
        Me.transactionCart.Size = New System.Drawing.Size(494, 225)
        Me.transactionCart.TabIndex = 1
        '
        'DetailTransactionId
        '
        Me.DetailTransactionId.HeaderText = "Id"
        Me.DetailTransactionId.Name = "DetailTransactionId"
        Me.DetailTransactionId.ReadOnly = True
        Me.DetailTransactionId.Visible = False
        '
        'transId
        '
        Me.transId.HeaderText = "Transaction Id"
        Me.transId.Name = "transId"
        Me.transId.ReadOnly = True
        Me.transId.Visible = False
        '
        'Store
        '
        Me.Store.HeaderText = "Store"
        Me.Store.Name = "Store"
        Me.Store.ReadOnly = True
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "Item Id"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Visible = False
        '
        'itemName
        '
        Me.itemName.HeaderText = "Item Name"
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        Me.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 50
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Visible = False
        '
        'Purchase
        '
        Me.Purchase.Location = New System.Drawing.Point(11, 244)
        Me.Purchase.Margin = New System.Windows.Forms.Padding(2)
        Me.Purchase.Name = "Purchase"
        Me.Purchase.Size = New System.Drawing.Size(106, 35)
        Me.Purchase.TabIndex = 2
        Me.Purchase.Text = "Purchases History"
        Me.Purchase.UseVisualStyleBackColor = True
        '
        'Buy
        '
        Me.Buy.Location = New System.Drawing.Point(121, 244)
        Me.Buy.Margin = New System.Windows.Forms.Padding(2)
        Me.Buy.Name = "Buy"
        Me.Buy.Size = New System.Drawing.Size(106, 35)
        Me.Buy.TabIndex = 3
        Me.Buy.Text = "Buy Now"
        Me.Buy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total"
        '
        'Total
        '
        Me.Total.BackColor = System.Drawing.SystemColors.Control
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(269, 252)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(236, 22)
        Me.Total.TabIndex = 5
        '
        'CartDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(517, 286)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buy)
        Me.Controls.Add(Me.Purchase)
        Me.Controls.Add(Me.transactionCart)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CartDetail"
        Me.Text = "Shopping Cart"
        CType(Me.transactionCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents transactionCart As DataGridView
    Friend WithEvents Purchase As Button
    Friend WithEvents Buy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Total As TextBox
    Friend WithEvents DetailTransactionId As DataGridViewTextBoxColumn
    Friend WithEvents transId As DataGridViewTextBoxColumn
    Friend WithEvents Store As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
