Public Class MainMenu

    Dim btnMode As Integer = 0

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '************COPY PASTE - BEGIN********************
        'Initialise Window Size
        Me.Width = 600
        Me.Height = 325

        'Miscellanous Form Properties
        Me.ShowIcon = False
        Me.MaximizeBox = False

        If Mode.mode = 0 Then
            Me.Text = "Marios POS System - Main Menu - Dine In"
        Else
            Me.Text = "Marios POS System - Main Menu - Take Away"
        End If

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
        '*************COPY PASTE - END*********************

        item1.Visible = False
        item2.Visible = False
        item3.Visible = False
        item4.Visible = False
        item5.Visible = False
        back.Visible = False

        beef.Visible = True
        chicken.Visible = True
        sides.Visible = True
        drinks.Visible = True

        beef.Text = "Beef"
        beef.Font = New Font("Arial", 12)
        beef.Size = New Size(120, 50)
        beef.Location = New Point(10, 10)

        chicken.Text = "Chicken"
        chicken.Font = New Font("Arial", 12)
        chicken.Size = New Size(120, 50)
        chicken.Location = New Point(beef.Location.X, beef.Location.Y + beef.Size.Height + 10)

        sides.Text = "Sides"
        sides.Font = New Font("Arial", 12)
        sides.Size = New Size(120, 50)
        sides.Location = New Point(chicken.Location.X, chicken.Location.Y + chicken.Size.Height + 10)

        drinks.Text = "Drinks"
        drinks.Font = New Font("Arial", 12)
        drinks.Size = New Size(120, 50)
        drinks.Location = New Point(sides.Location.X, sides.Location.Y + sides.Size.Height + 10)

        finish.Text = "Finish Order"
        finish.Font = New Font("Arial", 12)
        finish.Size = New Size(120, 50)
        finish.Location = New Point(Me.Width - (finish.Width + 20), Me.Height - (finish.Height * 2 - 5))

        Order.Show()
        TotalPrice.Show()
    End Sub

    Private Sub beef_Click(sender As Object, e As EventArgs) Handles beef.Click
        fixBtns()
        item1.Text = "Hamburger"
        item2.Text = "Cheeseburger"
        item3.Text = "Double Cheeseburger"
        item4.Text = "Double Patty"
        item5.Text = "Angus Grill"

        item1.Visible = True
        item2.Visible = True
        item3.Visible = True
        item4.Visible = True
        item5.Visible = True

        btnMode = 0
    End Sub

    Private Sub chicken_Click(sender As Object, e As EventArgs) Handles chicken.Click
        fixBtns()
        item1.Text = "Chickenburger"
        item2.Text = "Chicken Royal"
        item3.Text = "Grilled Chicken"

        item1.Visible = True
        item2.Visible = True
        item3.Visible = True
        item4.Visible = False
        item5.Visible = False

        btnMode = 0
    End Sub

    Private Sub sides_Click(sender As Object, e As EventArgs) Handles sides.Click
        fixBtns()
        item1.Text = "Regular Fries"
        item2.Text = "Medium Fries"
        item3.Text = "Large Fries"
        item4.Text = "4 Pcs Chicken Nuggets"
        item5.Text = "Coleslaw"

        item1.Visible = True
        item2.Visible = True
        item3.Visible = True
        item4.Visible = True
        item5.Visible = True

        btnMode = 1
    End Sub

    Private Sub drinks_Click(sender As Object, e As EventArgs) Handles drinks.Click
        fixBtns()
        item1.Text = "Regular Coke"
        item2.Text = "Medium Coke"
        item3.Text = "Large Coke"

        item1.Visible = True
        item2.Visible = True
        item3.Visible = True
        item4.Visible = False
        item5.Visible = False

        btnMode = 1
    End Sub

    Private Sub fixBtns()
        beef.Visible = False
        chicken.Visible = False
        sides.Visible = False
        drinks.Visible = False

        item1.Font = New Font("Arial", 12)
        item1.Size = New Size(120, 50)
        item1.Location = New Point(10, 10)

        item2.Font = New Font("Arial", 12)
        item2.Size = New Size(120, 50)
        item2.Location = New Point(item1.Location.X + item1.Size.Width + 10, item1.Location.Y)

        item3.Font = New Font("Arial", 12)
        item3.Size = New Size(120, 50)
        item3.Location = New Point(item1.Location.X, item1.Location.Y + item1.Size.Height + 10)

        item4.Font = New Font("Arial", 12)
        item4.Size = New Size(120, 50)
        item4.Location = New Point(item2.Location.X, item2.Location.Y + item2.Size.Height + 10)

        item5.Font = New Font("Arial", 12)
        item5.Size = New Size(120, 50)
        item5.Location = New Point(item3.Location.X, item3.Location.Y + item3.Size.Height + 10)

        back.Text = "Back"
        back.Font = New Font("Arial", 12)
        back.Size = New Size(120, 50)
        back.Location = New Point((Me.Width / 2) - (back.Size.Width / 2), Me.Height - (back.Size.Height * 2 - 5))

        back.Visible = True
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        MainMenu_Load(sender, e)
    End Sub

    Private Sub item1_Click(sender As Object, e As EventArgs) Handles item1.Click
        Order.AppendOrder(item1.Text, btnMode)
    End Sub

    Private Sub item2_Click(sender As Object, e As EventArgs) Handles item2.Click
        Order.AppendOrder(item2.Text, btnMode)
    End Sub

    Private Sub item3_Click(sender As Object, e As EventArgs) Handles item3.Click
        Order.AppendOrder(item3.Text, btnMode)
    End Sub

    Private Sub item4_Click(sender As Object, e As EventArgs) Handles item4.Click
        Order.AppendOrder(item4.Text, btnMode)
    End Sub

    Private Sub item5_Click(sender As Object, e As EventArgs) Handles item5.Click
        Order.AppendOrder(item5.Text, btnMode)
    End Sub

    Private Sub MainMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Order.Close()
        TotalPrice.Close()
    End Sub

    Private Sub finish_Click(sender As Object, e As EventArgs) Handles finish.Click
        MsgBox("€" & (Order.totalOrderPrice / 100).ToString("#.00"), , "Total Price")
        Order.list.Text = ""
    End Sub
End Class