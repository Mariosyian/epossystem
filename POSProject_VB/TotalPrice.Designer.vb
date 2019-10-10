<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TotalPrice
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
        Me.total = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(13, 13)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 96)
        Me.total.TabIndex = 0
        Me.total.Text = ""
        '
        'TotalPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 309)
        Me.Controls.Add(Me.total)
        Me.Name = "TotalPrice"
        Me.Text = "TotalPrice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents total As RichTextBox
End Class
