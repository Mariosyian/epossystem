<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.beef = New System.Windows.Forms.Button()
        Me.chicken = New System.Windows.Forms.Button()
        Me.sides = New System.Windows.Forms.Button()
        Me.item1 = New System.Windows.Forms.Button()
        Me.item2 = New System.Windows.Forms.Button()
        Me.item3 = New System.Windows.Forms.Button()
        Me.item4 = New System.Windows.Forms.Button()
        Me.item5 = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.drinks = New System.Windows.Forms.Button()
        Me.finish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'beef
        '
        Me.beef.Location = New System.Drawing.Point(13, 13)
        Me.beef.Name = "beef"
        Me.beef.Size = New System.Drawing.Size(75, 23)
        Me.beef.TabIndex = 0
        Me.beef.Text = "beef"
        Me.beef.UseVisualStyleBackColor = True
        '
        'chicken
        '
        Me.chicken.Location = New System.Drawing.Point(13, 43)
        Me.chicken.Name = "chicken"
        Me.chicken.Size = New System.Drawing.Size(75, 23)
        Me.chicken.TabIndex = 1
        Me.chicken.Text = "chicken"
        Me.chicken.UseVisualStyleBackColor = True
        '
        'sides
        '
        Me.sides.Location = New System.Drawing.Point(13, 73)
        Me.sides.Name = "sides"
        Me.sides.Size = New System.Drawing.Size(75, 23)
        Me.sides.TabIndex = 2
        Me.sides.Text = "sides"
        Me.sides.UseVisualStyleBackColor = True
        '
        'item1
        '
        Me.item1.Location = New System.Drawing.Point(13, 103)
        Me.item1.Name = "item1"
        Me.item1.Size = New System.Drawing.Size(75, 23)
        Me.item1.TabIndex = 3
        Me.item1.Text = "Button1"
        Me.item1.UseVisualStyleBackColor = True
        '
        'item2
        '
        Me.item2.Location = New System.Drawing.Point(13, 133)
        Me.item2.Name = "item2"
        Me.item2.Size = New System.Drawing.Size(75, 23)
        Me.item2.TabIndex = 4
        Me.item2.Text = "Button2"
        Me.item2.UseVisualStyleBackColor = True
        '
        'item3
        '
        Me.item3.Location = New System.Drawing.Point(13, 163)
        Me.item3.Name = "item3"
        Me.item3.Size = New System.Drawing.Size(75, 23)
        Me.item3.TabIndex = 5
        Me.item3.Text = "Button3"
        Me.item3.UseVisualStyleBackColor = True
        '
        'item4
        '
        Me.item4.Location = New System.Drawing.Point(13, 193)
        Me.item4.Name = "item4"
        Me.item4.Size = New System.Drawing.Size(75, 23)
        Me.item4.TabIndex = 6
        Me.item4.Text = "Button4"
        Me.item4.UseVisualStyleBackColor = True
        '
        'item5
        '
        Me.item5.Location = New System.Drawing.Point(13, 223)
        Me.item5.Name = "item5"
        Me.item5.Size = New System.Drawing.Size(75, 23)
        Me.item5.TabIndex = 7
        Me.item5.Text = "Button5"
        Me.item5.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(13, 253)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 8
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        'drinks
        '
        Me.drinks.Location = New System.Drawing.Point(13, 283)
        Me.drinks.Name = "drinks"
        Me.drinks.Size = New System.Drawing.Size(75, 23)
        Me.drinks.TabIndex = 9
        Me.drinks.Text = "drinks"
        Me.drinks.UseVisualStyleBackColor = True
        '
        'finish
        '
        Me.finish.Location = New System.Drawing.Point(13, 313)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(75, 23)
        Me.finish.TabIndex = 10
        Me.finish.Text = "pay"
        Me.finish.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.drinks)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.item5)
        Me.Controls.Add(Me.item4)
        Me.Controls.Add(Me.item3)
        Me.Controls.Add(Me.item2)
        Me.Controls.Add(Me.item1)
        Me.Controls.Add(Me.sides)
        Me.Controls.Add(Me.chicken)
        Me.Controls.Add(Me.beef)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents beef As Button
    Friend WithEvents chicken As Button
    Friend WithEvents sides As Button
    Friend WithEvents item1 As Button
    Friend WithEvents item2 As Button
    Friend WithEvents item3 As Button
    Friend WithEvents item4 As Button
    Friend WithEvents item5 As Button
    Friend WithEvents back As Button
    Friend WithEvents drinks As Button
    Friend WithEvents finish As Button
End Class
