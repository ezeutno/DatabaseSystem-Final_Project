﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Picture
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
        Me.LocationDetail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LocationDetail
        '
        Me.LocationDetail.Location = New System.Drawing.Point(12, 12)
        Me.LocationDetail.Name = "LocationDetail"
        Me.LocationDetail.Size = New System.Drawing.Size(348, 20)
        Me.LocationDetail.TabIndex = 0
        '
        'Picture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(370, 47)
        Me.Controls.Add(Me.LocationDetail)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Picture"
        Me.Text = "Picture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LocationDetail As TextBox
End Class
