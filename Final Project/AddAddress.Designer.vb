<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAddress
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sub_district = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.district = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.province = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.postal_code = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.country = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Address.Location = New System.Drawing.Point(146, 6)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(181, 57)
        Me.Address.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Sub District"
        '
        'sub_district
        '
        Me.sub_district.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.sub_district.Location = New System.Drawing.Point(146, 69)
        Me.sub_district.Name = "sub_district"
        Me.sub_district.Size = New System.Drawing.Size(181, 23)
        Me.sub_district.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "District"
        '
        'district
        '
        Me.district.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.district.Location = New System.Drawing.Point(146, 98)
        Me.district.Name = "district"
        Me.district.Size = New System.Drawing.Size(181, 23)
        Me.district.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Province"
        '
        'province
        '
        Me.province.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.province.Location = New System.Drawing.Point(146, 127)
        Me.province.Name = "province"
        Me.province.Size = New System.Drawing.Size(181, 23)
        Me.province.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Postal Code"
        '
        'postal_code
        '
        Me.postal_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.postal_code.Location = New System.Drawing.Point(146, 156)
        Me.postal_code.Name = "postal_code"
        Me.postal_code.Size = New System.Drawing.Size(181, 23)
        Me.postal_code.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Country"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(170, 215)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 59
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(252, 214)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 60
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'country
        '
        Me.country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.country.FormattingEnabled = True
        Me.country.Location = New System.Drawing.Point(146, 188)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(181, 21)
        Me.country.TabIndex = 61
        '
        'AddAddress
        '
        Me.AcceptButton = Me.Submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(336, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Submit)
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
        Me.MaximizeBox = False
        Me.Name = "AddAddress"
        Me.Text = "Add Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Address As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sub_district As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents district As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents province As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents postal_code As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Submit As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents country As ComboBox
End Class
