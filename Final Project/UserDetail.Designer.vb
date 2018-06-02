<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDetail
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
        Me.cancel = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.birthday = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.change = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancel
        '
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel.Location = New System.Drawing.Point(459, 218)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 42
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(378, 218)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 41
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'birthday
        '
        Me.birthday.Location = New System.Drawing.Point(146, 163)
        Me.birthday.MaxDate = New Date(2018, 5, 18, 0, 0, 0, 0)
        Me.birthday.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(181, 20)
        Me.birthday.TabIndex = 40
        Me.birthday.Value = New Date(2018, 5, 18, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Birthday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Handphone"
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.phone.Location = New System.Drawing.Point(146, 131)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(181, 23)
        Me.phone.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Email"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.email.Location = New System.Drawing.Point(146, 102)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(181, 23)
        Me.email.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Last Name"
        '
        'lName
        '
        Me.lName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lName.Location = New System.Drawing.Point(146, 73)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(181, 23)
        Me.lName.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "First Name"
        '
        'fName
        '
        Me.fName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.fName.Location = New System.Drawing.Point(146, 44)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(181, 23)
        Me.fName.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Password"
        '
        'Password
        '
        Me.Password.Enabled = False
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Password.Location = New System.Drawing.Point(146, 189)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(181, 23)
        Me.Password.TabIndex = 28
        Me.Password.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Username"
        '
        'Username
        '
        Me.Username.Enabled = False
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Username.Location = New System.Drawing.Point(146, 12)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(181, 23)
        Me.Username.TabIndex = 26
        '
        'Address
        '
        Me.Address.FormattingEnabled = True
        Me.Address.Location = New System.Drawing.Point(8, 14)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(187, 160)
        Me.Address.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Add)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Location = New System.Drawing.Point(333, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 203)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address"
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(8, 177)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(187, 23)
        Me.Add.TabIndex = 44
        Me.Add.Text = "Add New Address"
        Me.Add.UseVisualStyleBackColor = True
        '
        'change
        '
        Me.change.Location = New System.Drawing.Point(220, 218)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(107, 23)
        Me.change.TabIndex = 46
        Me.change.Text = "Change Password"
        Me.change.UseVisualStyleBackColor = True
        '
        'UserDetail
        '
        Me.AcceptButton = Me.cancel
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.cancel
        Me.ClientSize = New System.Drawing.Size(541, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.change)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.birthday)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Username)
        Me.MaximizeBox = False
        Me.Name = "UserDetail"
        Me.Text = "User Detail"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancel As Button
    Friend WithEvents Submit As Button
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Address As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents change As Button
    Friend WithEvents Add As Button
End Class
