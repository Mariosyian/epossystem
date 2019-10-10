Public Class Order
    Public totalOrderPrice As Double

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '************COPY PASTE - BEGIN********************
        'Initialise Window Size
        Me.Width = 400
        Me.Height = 700

        'Miscellanous Form Properties
        Me.ShowIcon = False
        Me.MaximizeBox = False

        Me.Text = "Marios POS System - Main Menu - Order"

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
        '*************COPY PASTE - END*********************

        Me.Location = New Point(MainMenu.Location.X + MainMenu.Size.Width + 5, MainMenu.Location.Y)

        list.Enabled = True
        list.Multiline = True
        list.ReadOnly = True
        list.Location = New Point(0, 0)
        list.Size = New Size(Me.Width - 10, Me.Height)
        list.Font = New Font("Arial", 14)
    End Sub

    Public Sub AppendOrder(ByVal item As String, ByVal mode As Integer)
        If mode = 0 Then
            list.Text += item & vbNewLine
        Else
            list.Text += vbTab & item & vbNewLine
        End If

        'All item prices
        If item = "Hamburger" Then
            totalOrderPrice += 100
        ElseIf item = "Cheeseburger" Then
            totalOrderPrice += 120
        ElseIf item = "Double Cheeseburger" Then
            totalOrderPrice += 170
        ElseIf item = "Double Patty" Then
            totalOrderPrice += 200
        ElseIf item = "Angus Grill" Then
            totalOrderPrice += 325
        ElseIf item = "Chickenburger" Then
            totalOrderPrice += 135
        ElseIf item = "Chicken Royal" Then
            totalOrderPrice += 175
        ElseIf item = "Grilled Chicken" Then
            totalOrderPrice += 160
        ElseIf item = "Regular Fries" Then
            totalOrderPrice += 100
        ElseIf item = "Medium Fries" Then
            totalOrderPrice += 135
        ElseIf item = "Large Fries" Then
            totalOrderPrice += 150
        ElseIf item = "4 Pcs Chicken Nuggets" Then
            totalOrderPrice += 110
        ElseIf item = "Coleslaw" Then
            totalOrderPrice += 100
        ElseIf item = "Regular Coke" Then
            totalOrderPrice += 100
        ElseIf item = "Medium Coke" Then
            totalOrderPrice += 150
        ElseIf item = "Large Coke" Then
            totalOrderPrice += 165
        End If

        TotalPrice.total.Text = "€" + (totalOrderPrice / 100).ToString("#0.00")
    End Sub
End Class