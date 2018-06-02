<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressDetail
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
        Me.delete = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.postal_code = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.province = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.district = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sub_district = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.storeYes = New System.Windows.Forms.CheckBox()
        Me.storeNo = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.country = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(252, 271)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 23)
        Me.delete.TabIndex = 73
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Country"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Postal Code"
        '
        'postal_code
        '
        Me.postal_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.postal_code.Location = New System.Drawing.Point(146, 189)
        Me.postal_code.Name = "postal_code"
        Me.postal_code.Size = New System.Drawing.Size(181, 23)
        Me.postal_code.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Province"
        '
        'province
        '
        Me.province.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.province.Location = New System.Drawing.Point(146, 160)
        Me.province.Name = "province"
        Me.province.Size = New System.Drawing.Size(181, 23)
        Me.province.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "District"
        '
        'district
        '
        Me.district.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.district.Location = New System.Drawing.Point(146, 131)
        Me.district.Name = "district"
        Me.district.Size = New System.Drawing.Size(181, 23)
        Me.district.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Sub District"
        '
        'sub_district
        '
        Me.sub_district.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.sub_district.Location = New System.Drawing.Point(146, 102)
        Me.sub_district.Name = "sub_district"
        Me.sub_district.Size = New System.Drawing.Size(181, 23)
        Me.sub_district.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Address"
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Address.Location = New System.Drawing.Point(146, 39)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(181, 57)
        Me.Address.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 17)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Id"
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.id.Location = New System.Drawing.Point(146, 10)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(181, 23)
        Me.id.TabIndex = 76
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(171, 271)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(75, 23)
        Me.updateBtn.TabIndex = 78
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'storeYes
        '
        Me.storeYes.AutoSize = True
        Me.storeYes.Enabled = False
        Me.storeYes.Location = New System.Drawing.Point(146, 249)
        Me.storeYes.Name = "storeYes"
        Me.storeYes.Size = New System.Drawing.Size(44, 17)
        Me.storeYes.TabIndex = 79
        Me.storeYes.Text = "Yes"
        Me.storeYes.UseVisualStyleBackColor = True
        '
        'storeNo
        '
        Me.storeNo.AutoSize = True
        Me.storeNo.Enabled = False
        Me.storeNo.Location = New System.Drawing.Point(246, 248)
        Me.storeNo.Name = "storeNo"
        Me.storeNo.Size = New System.Drawing.Size(40, 17)
        Me.storeNo.TabIndex = 80
        Me.storeNo.Text = "No"
        Me.storeNo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Store Address"
        '
        'country
        '
        Me.country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.country.FormattingEnabled = True
        Me.country.Location = New System.Drawing.Point(146, 220)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(181, 21)
        Me.country.TabIndex = 82
        '
        'AddressDetail
        '
        Me.AcceptButton = Me.updateBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(339, 303)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.storeNo)
        Me.Controls.Add(Me.storeYes)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.postal_code)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.province)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.district)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sub_district)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Address)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddressDetail"
        Me.Text = "Address Detail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents delete As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents postal_code As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents province As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents district As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sub_district As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents storeYes As CheckBox
    Friend WithEvents storeNo As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents country As ComboBox
End Class
