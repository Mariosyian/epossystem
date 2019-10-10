Public Class Mode
    Private Sub Mode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '************COPY PASTE - BEGIN********************
        'Initialise Window Size
        Me.Width = 600
        Me.Height = 325

        'Miscellanous Form Properties
        Me.ShowIcon = False
        Me.MaximizeBox = False
        Me.Text = "Marios POS System - Mode"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Me.StartPosition = FormStartPosition.CenterScreen HOW TO DO THIS BEFORE LOAD?!
        '*************COPY PASTE - END*********************

        Label1.AutoSize = False
        Label1.Text = "Select Mode:"
        Label1.Font = New Font("Arial", 25)
        Label1.Size = New Size(Me.Size.Width, 150)
        Label1.Location = New Point(0, 0)
        Label1.TextAlign = ContentAlignment.MiddleCenter

        dine_in.Text = "Dine In"
        dine_in.Size = New Size(125, 30)
        dine_in.Location = New Point((Me.Size.Width / 2) - (dine_in.Size.Width / 2), Label1.Location.Y + Label1.Size.Height + 10)

        take_away.Text = "Take Away"
        take_away.Size = New Size(125, 30)
        take_away.Location = New Point((Me.Size.Width / 2) - (take_away.Size.Width / 2), dine_in.Location.Y + dine_in.Size.Height + 10)
    End Sub

    'Global var for Dine In or Take Away mode
    Public mode As Integer = 0

    Private Sub dine_in_Click(sender As Object, e As EventArgs) Handles dine_in.Click
        mode = 0
        MainMenu.Show()
        Order.Show()
        Me.Close()
    End Sub

    Private Sub take_away_Click(sender As Object, e As EventArgs) Handles take_away.Click
        mode = 1
        MainMenu.Show()
        Me.Close()
    End Sub
End Class