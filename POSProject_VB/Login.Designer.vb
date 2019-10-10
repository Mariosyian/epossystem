<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS
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
        Me.welLbl = New System.Windows.Forms.Label()
        Me.userLbl = New System.Windows.Forms.Label()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.passLbl = New System.Windows.Forms.Label()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'welLbl
        '
        Me.welLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.welLbl.Location = New System.Drawing.Point(12, 9)
        Me.welLbl.Name = "welLbl"
        Me.welLbl.Size = New System.Drawing.Size(560, 32)
        Me.welLbl.TabIndex = 0
        Me.welLbl.Text = "welcome msg"
        '
        'userLbl
        '
        Me.userLbl.AutoSize = True
        Me.userLbl.Location = New System.Drawing.Point(14, 41)
        Me.userLbl.Name = "userLbl"
        Me.userLbl.Size = New System.Drawing.Size(53, 13)
        Me.userLbl.TabIndex = 1
        Me.userLbl.Text = "username"
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(17, 57)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(100, 20)
        Me.userTxt.TabIndex = 2
        Me.userTxt.Text = "username"
        '
        'passLbl
        '
        Me.passLbl.AutoSize = True
        Me.passLbl.Location = New System.Drawing.Point(15, 80)
        Me.passLbl.Name = "passLbl"
        Me.passLbl.Size = New System.Drawing.Size(52, 13)
        Me.passLbl.TabIndex = 3
        Me.passLbl.Text = "password"
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(17, 96)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(100, 20)
        Me.passTxt.TabIndex = 4
        Me.passTxt.Text = "password"
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(18, 122)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 5
        Me.loginBtn.Text = "Button1"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.passLbl)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.userLbl)
        Me.Controls.Add(Me.welLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "POS"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marios POS System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents welLbl As Label
    Friend WithEvents userLbl As Label
    Friend WithEvents userTxt As TextBox
    Friend WithEvents passLbl As Label
    Friend WithEvents passTxt As TextBox
    Friend WithEvents loginBtn As Button
End Class
