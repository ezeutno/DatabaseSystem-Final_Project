﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellerSales
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
        Me.allsales = New System.Windows.Forms.DataGridView()
        Me.sales = New System.Windows.Forms.Button()
        Me.Fulfilment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalRev = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subDistrict = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.district = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.province = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.postal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.allsales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'allsales
        '
        Me.allsales.AllowUserToAddRows = False
        Me.allsales.AllowUserToDeleteRows = False
        Me.allsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.allsales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.status, Me.username, Me.item, Me.Quantity, Me.Price, Me.SubTotal, Me.address, Me.subDistrict, Me.district, Me.province, Me.postal, Me.country})
        Me.allsales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.allsales.Location = New System.Drawing.Point(9, 10)
        Me.allsales.Margin = New System.Windows.Forms.Padding(2)
        Me.allsales.Name = "allsales"
        Me.allsales.RowTemplate.Height = 24
        Me.allsales.Size = New System.Drawing.Size(731, 346)
        Me.allsales.TabIndex = 0
        '
        'sales
        '
        Me.sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.sales.Location = New System.Drawing.Point(12, 361)
        Me.sales.Name = "sales"
        Me.sales.Size = New System.Drawing.Size(165, 29)
        Me.sales.TabIndex = 1
        Me.sales.Text = "Past Sales"
        Me.sales.UseVisualStyleBackColor = True
        '
        'Fulfilment
        '
        Me.Fulfilment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Fulfilment.Location = New System.Drawing.Point(183, 361)
        Me.Fulfilment.Name = "Fulfilment"
        Me.Fulfilment.Size = New System.Drawing.Size(165, 29)
        Me.Fulfilment.TabIndex = 2
        Me.Fulfilment.Text = "Fullfilment"
        Me.Fulfilment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Revenue :"
        '
        'TotalRev
        '
        Me.TotalRev.BackColor = System.Drawing.SystemColors.Control
        Me.TotalRev.Enabled = False
        Me.TotalRev.Location = New System.Drawing.Point(455, 365)
        Me.TotalRev.Name = "TotalRev"
        Me.TotalRev.Size = New System.Drawing.Size(285, 20)
        Me.TotalRev.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Detail Transaction ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        '
        'username
        '
        Me.username.HeaderText = "Buyer's username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'item
        '
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'subDistrict
        '
        Me.subDistrict.HeaderText = "Sub-district"
        Me.subDistrict.Name = "subDistrict"
        Me.subDistrict.ReadOnly = True
        '
        'district
        '
        Me.district.HeaderText = "District"
        Me.district.Name = "district"
        Me.district.ReadOnly = True
        '
        'province
        '
        Me.province.HeaderText = "Province"
        Me.province.Name = "province"
        Me.province.ReadOnly = True
        '
        'postal
        '
        Me.postal.HeaderText = "Postal Code"
        Me.postal.Name = "postal"
        Me.postal.ReadOnly = True
        '
        'country
        '
        Me.country.HeaderText = "Country"
        Me.country.Name = "country"
        Me.country.ReadOnly = True
        '
        'SellerSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 398)
        Me.Controls.Add(Me.TotalRev)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Fulfilment)
        Me.Controls.Add(Me.sales)
        Me.Controls.Add(Me.allsales)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SellerSales"
        Me.Text = "Your Sales"
        CType(Me.allsales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents allsales As DataGridView
    Friend WithEvents sales As Button
    Friend WithEvents Fulfilment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalRev As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents subDistrict As DataGridViewTextBoxColumn
    Friend WithEvents district As DataGridViewTextBoxColumn
    Friend WithEvents province As DataGridViewTextBoxColumn
    Friend WithEvents postal As DataGridViewTextBoxColumn
    Friend WithEvents country As DataGridViewTextBoxColumn
End Class