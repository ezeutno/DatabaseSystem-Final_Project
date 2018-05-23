<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.StoreLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Password2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.birthday = New System.Windows.Forms.DateTimePicker()
        Me.submit = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.StoreLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StoreLogo
        '
        Me.StoreLogo.Enabled = False
        Me.StoreLogo.Image = Global.Final_Project.My.Resources.Resources.TG0wQQ40_400x400_mart_ai_on_twitter
        Me.StoreLogo.Location = New System.Drawing.Point(12, 12)
        Me.StoreLogo.Name = "StoreLogo"
        Me.StoreLogo.Size = New System.Drawing.Size(205, 69)
        Me.StoreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.StoreLogo.TabIndex = 5
        Me.StoreLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Username.Location = New System.Drawing.Point(146, 100)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(181, 23)
        Me.Username.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Password.Location = New System.Drawing.Point(146, 132)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(181, 23)
        Me.Password.TabIndex = 8
        Me.Password.UseSystemPasswordChar = True
        '
        'Password2
        '
        Me.Password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Password2.Location = New System.Drawing.Point(146, 164)
        Me.Password2.Name = "Password2"
        Me.Password2.Size = New System.Drawing.Size(181, 23)
        Me.Password2.TabIndex = 10
        Me.Password2.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "First Name"
        '
        'fName
        '
        Me.fName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.fName.Location = New System.Drawing.Point(146, 193)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(181, 23)
        Me.fName.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Last Name"
        '
        'lName
        '
        Me.lName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lName.Location = New System.Drawing.Point(146, 222)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(181, 23)
        Me.lName.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Email"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.email.Location = New System.Drawing.Point(146, 251)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(181, 23)
        Me.email.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Handphone"
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.phone.Location = New System.Drawing.Point(146, 280)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(181, 23)
        Me.phone.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Birthday"
        '
        'birthday
        '
        Me.birthday.Location = New System.Drawing.Point(146, 312)
        Me.birthday.MaxDate = New Date(2018, 5, 19, 7, 47, 25, 0)
        Me.birthday.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(181, 20)
        Me.birthday.TabIndex = 21
        Me.birthday.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(171, 351)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 22
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel.Location = New System.Drawing.Point(252, 351)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 23
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Re-Type Password"
        '
        'Register
        '
        Me.AcceptButton = Me.submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancel
        Me.ClientSize = New System.Drawing.Size(339, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.submit)
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
        Me.Controls.Add(Me.Password2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.StoreLogo)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.StoreLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StoreLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Password2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents submit As Button
    Friend WithEvents cancel As Button
    Friend WithEvents Label8 As Label
End Class
