<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateStore
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
        Me.storeName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Create = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'storeName
        '
        Me.storeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.storeName.Location = New System.Drawing.Point(15, 29)
        Me.storeName.Name = "storeName"
        Me.storeName.Size = New System.Drawing.Size(182, 23)
        Me.storeName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Store Name"
        '
        'Address
        '
        Me.Address.FormattingEnabled = True
        Me.Address.Location = New System.Drawing.Point(15, 80)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(182, 108)
        Me.Address.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Address"
        '
        'Create
        '
        Me.Create.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Create.Location = New System.Drawing.Point(15, 194)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(75, 36)
        Me.Create.TabIndex = 4
        Me.Create.Text = "Create"
        Me.Create.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Cancel.Location = New System.Drawing.Point(122, 194)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 36)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'CreateStore
        '
        Me.AcceptButton = Me.Create
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(212, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Create)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.storeName)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateStore"
        Me.Text = "Create Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents storeName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Address As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Create As Button
    Friend WithEvents Cancel As Button
End Class
