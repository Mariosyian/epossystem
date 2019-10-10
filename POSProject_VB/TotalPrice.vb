Public Class TotalPrice
    Private Sub TotalPrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '************COPY PASTE - BEGIN********************
        'Initialise Window Size
        Me.Width = 150
        Me.Height = 65

        'Miscellanous Form Properties
        Me.ShowIcon = False
        Me.MaximizeBox = False

        Me.Text = "Total Price"

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
        '*************COPY PASTE - END*********************

        Me.ControlBox = False
        Me.Location = New Point(MainMenu.Location.X + MainMenu.Width - Me.Width, MainMenu.Location.Y + MainMenu.Height + 10)

        total.Size = New Size(Me.Width - 21, Me.Height - 43)
        total.Location = New Point(2, 2)
        total.Font = New Font("Arial", 11)

        total.Text = "€" + Order.totalOrderPrice.ToString("#0.00")
        total.Multiline = True
        total.ReadOnly = True
    End Sub
End Class