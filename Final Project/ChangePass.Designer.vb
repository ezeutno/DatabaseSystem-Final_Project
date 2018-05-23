<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nPassword2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(11, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Re-Type New Password"
        '
        'nPassword2
        '
        Me.nPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nPassword2.Location = New System.Drawing.Point(173, 74)
        Me.nPassword2.Name = "nPassword2"
        Me.nPassword2.Size = New System.Drawing.Size(181, 23)
        Me.nPassword2.TabIndex = 27
        Me.nPassword2.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "New Password"
        '
        'nPassword
        '
        Me.nPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nPassword.Location = New System.Drawing.Point(173, 42)
        Me.nPassword.Name = "nPassword"
        Me.nPassword.Size = New System.Drawing.Size(181, 23)
        Me.nPassword.TabIndex = 25
        Me.nPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Password"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Password.Location = New System.Drawing.Point(173, 13)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(181, 23)
        Me.Password.TabIndex = 29
        Me.Password.UseSystemPasswordChar = True
        '
        'cancel
        '
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel.Location = New System.Drawing.Point(279, 113)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 44
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(198, 113)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 43
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'ChangePass
        '
        Me.AcceptButton = Me.Submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancel
        Me.ClientSize = New System.Drawing.Size(366, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nPassword2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nPassword)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePass"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents nPassword2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents cancel As Button
    Friend WithEvents Submit As Button
End Class
