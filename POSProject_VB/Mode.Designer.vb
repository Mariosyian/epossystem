﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mode
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
        Me.dine_in = New System.Windows.Forms.Button()
        Me.take_away = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dine_in
        '
        Me.dine_in.Location = New System.Drawing.Point(12, 25)
        Me.dine_in.Name = "dine_in"
        Me.dine_in.Size = New System.Drawing.Size(75, 23)
        Me.dine_in.TabIndex = 0
        Me.dine_in.Text = "Button1"
        Me.dine_in.UseVisualStyleBackColor = True
        '
        'take_away
        '
        Me.take_away.Location = New System.Drawing.Point(12, 54)
        Me.take_away.Name = "take_away"
        Me.take_away.Size = New System.Drawing.Size(75, 23)
        Me.take_away.TabIndex = 1
        Me.take_away.Text = "Button2"
        Me.take_away.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Mode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.take_away)
        Me.Controls.Add(Me.dine_in)
        Me.Name = "Mode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dine_in As Button
    Friend WithEvents take_away As Button
    Friend WithEvents Label1 As Label
End Class
