<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseAddress
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
        Me.address = New System.Windows.Forms.ListBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'address
        '
        Me.address.FormattingEnabled = True
        Me.address.Location = New System.Drawing.Point(11, 12)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(204, 186)
        Me.address.TabIndex = 0
        '
        'submit
        '
        Me.submit.Enabled = False
        Me.submit.Location = New System.Drawing.Point(140, 204)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 1
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'ChooseAddress
        '
        Me.AcceptButton = Me.submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(227, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.address)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChooseAddress"
        Me.Text = "Choose Send Address"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents address As ListBox
    Friend WithEvents submit As Button
End Class
