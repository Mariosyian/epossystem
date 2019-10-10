Public Class POS

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        '************COPY PASTE - BEGIN********************
        'Initialise Window Size
        Me.Width = 600
        Me.Height = 325

        'Miscellanous Form Properties
        Me.ShowIcon = False
        Me.MaximizeBox = False
        Me.Text = "Marios POS System - Login"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
        '*************COPY PASTE - END*********************

        'Align label text
        welLbl.AutoSize = False
        welLbl.TextAlign = ContentAlignment.MiddleCenter

        userLbl.AutoSize = False
        userLbl.TextAlign = ContentAlignment.MiddleCenter

        passLbl.AutoSize = False
        passLbl.TextAlign = ContentAlignment.MiddleCenter

        'Initialise label text 
        welLbl.Text = "Welcome to" + vbNewLine + "Marios Yiannakou Restaurant"
        userLbl.Text = "Username: "
        passLbl.Text = "Password: "
        loginBtn.Text = "LogIn"

        'Initialise Textbox text and set password character for passTxt
        userTxt.Text = ""
        passTxt.Text = ""
        passTxt.UseSystemPasswordChar = True

        'Set label and textbox dimensions - Use relative positions
        welLbl.Font = New Font("Arial", 15)
        welLbl.Size = New Size(Me.Size.Width, 120)
        welLbl.Location = New Point(0, 0)

        userLbl.Font = New Font("Arial", 12)
        userLbl.Size = New Size(Me.Size.Width, 20)
        userLbl.Location = New Point(0, welLbl.Location.Y + welLbl.Size.Height)

        'Textbox location = Middle of window - half of txtbox width so its centered
        userTxt.Size = New Size(120, 25)
        userTxt.Location = New Point((Me.Width / 2) - (userTxt.Size.Width / 2), userLbl.Location.Y + userLbl.Size.Height)

        passLbl.Font = New Font("Arial", 12)
        passLbl.Size = New Size(Me.Size.Width, 20)
        passLbl.Location = New Point(0, userTxt.Location.Y + userTxt.Size.Height + 25)

        passTxt.Size = New Size(120, 25)
        passTxt.Location = New Point((Me.Width / 2) - (passTxt.Size.Width / 2), passLbl.Location.Y + passLbl.Size.Height)

        loginBtn.Font = New Font("Arial", 10)
        loginBtn.Size = New Size(75, 25)
        loginBtn.Location = New Point((Me.Width / 2) - (loginBtn.Size.Width / 2), passTxt.Location.Y + passTxt.Size.Height + 25)
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        'Connect with database and have admin / employee accounts
        If userTxt.Text.ToUpper = "MARIOS" And passTxt.Text = "YIANNAKOU" Then
            MessageBox.Show("Welcome " + userTxt.Text + "!")
            Mode.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect login!")
        End If
    End Sub
End Class
