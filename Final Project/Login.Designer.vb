<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.CancleBtn = New System.Windows.Forms.Button()
        Me.StoreLogo = New System.Windows.Forms.PictureBox()
        CType(Me.StoreLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Username.Location = New System.Drawing.Point(101, 93)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(181, 23)
        Me.Username.TabIndex = 0
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Password.Location = New System.Drawing.Point(101, 131)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(181, 23)
        Me.Password.TabIndex = 1
        Me.Password.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'LoginBtn
        '
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LoginBtn.Location = New System.Drawing.Point(16, 168)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(84, 27)
        Me.LoginBtn.TabIndex = 7
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RegisterBtn.Location = New System.Drawing.Point(108, 168)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(84, 27)
        Me.RegisterBtn.TabIndex = 8
        Me.RegisterBtn.Text = "Register"
        Me.RegisterBtn.UseVisualStyleBackColor = True
        '
        'CancleBtn
        '
        Me.CancleBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CancleBtn.Location = New System.Drawing.Point(198, 168)
        Me.CancleBtn.Name = "CancleBtn"
        Me.CancleBtn.Size = New System.Drawing.Size(84, 27)
        Me.CancleBtn.TabIndex = 9
        Me.CancleBtn.Text = "Cancel"
        Me.CancleBtn.UseVisualStyleBackColor = True
        '
        'StoreLogo
        '
        Me.StoreLogo.Enabled = False
        Me.StoreLogo.Image = Global.Final_Project.My.Resources.Resources.TG0wQQ40_400x400_mart_ai_on_twitter
        Me.StoreLogo.Location = New System.Drawing.Point(48, 12)
        Me.StoreLogo.Name = "StoreLogo"
        Me.StoreLogo.Size = New System.Drawing.Size(205, 69)
        Me.StoreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.StoreLogo.TabIndex = 4
        Me.StoreLogo.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.CancleBtn
        Me.ClientSize = New System.Drawing.Size(294, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancleBtn)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StoreLogo)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.StoreLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents StoreLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents CancleBtn As Button
End Class
