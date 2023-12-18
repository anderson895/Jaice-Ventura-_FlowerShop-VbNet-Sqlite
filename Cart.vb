Imports System.Data.SQLite
Imports System.IO

Public Class Cart
    Dim dbPath As String = Path.Combine(Application.StartupPath, "CartDB.db")
    Private Sub logoPanel_Paint(sender As Object, e As PaintEventArgs) Handles logoPanel.Paint
        ' Create a rectangle with rounded corners
        Dim roundedRect As New Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = New Rectangle(0, 0, logoPanel.Width, logoPanel.Height)
        Dim cornerRadius As Integer = 15 ' Adjust the corner radius as needed

        roundedRect.AddArc(rectangle.X, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 180, 90)
        roundedRect.AddArc(rectangle.Right - cornerRadius * 2, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 270, 90)
        roundedRect.AddArc(rectangle.Right - cornerRadius * 2, rectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        roundedRect.AddArc(rectangle.X, rectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)
        roundedRect.CloseFigure()

        ' Apply the rounded rectangle to the Region property of the panel
        logoPanel.Region = New Region(roundedRect)
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Dim mainForm As New Main()
        mainForm.Show()
        Me.Close()
    End Sub

    Private connectionString As String = $"Data Source={dbPath};Version=3;"

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form loads
        LoadShoppingCartData()

        ' Calculate and display the totalLabel
        CalculateAndDisplayTotal()
    End Sub

    Public Sub LoadShoppingCartData()
        Try
            ' Connect to the SQLite database
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Select all records from the ShoppingCart table
                Dim query As String = "SELECT * FROM ShoppingCart"
                Using command As New SQLiteCommand(query, connection)
                    ' Execute the query and fill the DataTable with the result
                    Dim dataTable As New DataTable()
                    Using adapter As New SQLiteDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using

                    ' Bind the DataTable to the DataGridView
                    cartTable.DataSource = dataTable
                End Using
            End Using

            ' Format the "Product Price" column to display "P" with comma-separated values
            For Each column As DataGridViewColumn In cartTable.Columns
                If column.Name = "Product Price" Then
                    column.DefaultCellStyle.Format = "#,0" ' Use "P0" for currency format with zero decimal places
                End If
            Next

        Catch ex As Exception
            ' Handle exceptions, log, or display an error message
            MessageBox.Show("Error loading data from ShoppingCart.db: " & ex.Message)
        End Try
    End Sub


    Public Sub CalculateAndDisplayTotal()
        Dim total As Decimal = 0

        ' Iterate through the rows of the DataGridView
        For Each row As DataGridViewRow In cartTable.Rows
            If Not row.IsNewRow Then ' Check if the row is not the new row for data entry
                ' Retrieve values from the DataGridView for the calculation
                Dim price As Integer = Convert.ToInt32(row.Cells("Product Price").Value)
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)

                ' Calculate subtotal for the current row and add it to the total
                total += price * quantity
            End If
        Next

        ' Display the total in the totalLabel with the "P" format
        totalLabel.Text = $"P{total:N0}"
    End Sub

    Private Sub removeAllButton_Click(sender As Object, e As EventArgs) Handles removeAllButton.Click
        ' Check if there are no items in the cart
        If cartTable.Rows.Count = 0 Then
            MessageBox.Show("There are no items to remove from the cart.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Ask the user for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove all items from the cart?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            Try
                ' Connect to the SQLite database
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()

                    ' Delete all records from the ShoppingCart table
                    Dim query As String = "DELETE FROM ShoppingCart"
                    Using command As New SQLiteCommand(query, connection)
                        ' Execute the query
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Refresh the DataGridView to reflect the changes
                LoadShoppingCartData()

                ' Recalculate and display the total
                CalculateAndDisplayTotal()

                ' Optionally, inform the user that items have been removed
                MessageBox.Show("All items removed from the cart!")

            Catch ex As Exception
                ' Handle exceptions, log, or display an error message
                MessageBox.Show("Error removing items from the cart: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        ' Check if there are no items in the cart
        If cartTable.Rows.Count = 0 Then
            MessageBox.Show("There are no items to delete from the cart.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Check if a row is selected
        If cartTable.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ask the user for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            Try
                ' Connect to the SQLite database
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()

                    ' Get the selected row
                    Dim selectedRow As DataGridViewRow = cartTable.SelectedRows(0)

                    ' Get the Product Name of the selected row (assuming "Product Name" is in a column named "Product Name")
                    Dim selectedProductName As String = Convert.ToString(selectedRow.Cells("Product Name").Value)

                    ' Delete the selected record from the ShoppingCart table based on Product Name
                    Dim query As String = "DELETE FROM ShoppingCart WHERE [Product Name] = @ProductName"
                    Using command As New SQLiteCommand(query, connection)
                        ' Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ProductName", selectedProductName)

                        ' Execute the query
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Refresh the DataGridView to reflect the changes
                LoadShoppingCartData()

                ' Recalculate and display the total
                CalculateAndDisplayTotal()

                ' Optionally, inform the user that the item has been deleted
                MessageBox.Show("Selected item deleted from the cart!")

            Catch ex As Exception
                ' Handle exceptions, log, or display an error message
                MessageBox.Show("Error deleting item from the cart: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub placeOrderButton_Click(sender As Object, e As EventArgs) Handles placeOrderButton.Click
        ' Check if there are items in the cart
        If cartTable.Rows.Count = 0 Then
            MessageBox.Show("There are no items to place an order. Add items before placing an order.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Get the total value from the totalLabel in the Cart form
        Dim totalValue As String = totalLabel.Text

        ' Create an instance of the PlaceOrderForm and pass the total value
        Dim placeOrderForm As New PlaceOrderForm(totalValue)

        ' Show the PlaceOrderForm
        placeOrderForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ordersSummaryButton_Click(sender As Object, e As EventArgs) Handles ordersSummaryButton.Click
        Dim ordersSummaryForm = New OrdersSummaryForm
        ordersSummaryForm.Show()
        Me.Close()
    End Sub

    Private emailDiscountApplied As Boolean = False

    Private Sub addEmailButton_Click(sender As Object, e As EventArgs) Handles addEmailButton.Click
        ' Check if the discount has already been applied
        If emailDiscountApplied Then
            MessageBox.Show("Email discount has already been applied.", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Create an instance of the EmailInputDialog
        Dim emailInputDialog As New EmailInputDialog()

        ' Show the EmailInputDialog as a dialog
        emailInputDialog.ShowDialog()

        ' Check if the user entered a valid email
        If Not String.IsNullOrWhiteSpace(emailInputDialog.UserEmail) Then
            ' Apply the 10% discount to the prices in the cartTable
            ApplyDiscountToCart(0.1) ' 10% discount

            ' Mark that the discount has been applied
            emailDiscountApplied = True

            ' Optionally, inform the user that the discount has been applied
            MessageBox.Show("10% discount applied. Prices have been updated.", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ApplyDiscountToCart(discountPercentage As Decimal)
        ' Iterate through the rows of the DataGridView and apply the discount to the "Product Price" column
        For Each row As DataGridViewRow In cartTable.Rows
            If Not row.IsNewRow Then ' Check if the row is not the new row for data entry
                ' Retrieve values from the DataGridView for the calculation
                Dim price As Decimal = Convert.ToDecimal(row.Cells("Product Price").Value)

                ' Apply the discount to the price
                Dim discountedPrice As Decimal = price - (price * discountPercentage)

                ' Update the "Product Price" column with the discounted price
                row.Cells("Product Price").Value = discountedPrice
            End If
        Next

        ' Recalculate and display the total
        CalculateAndDisplayTotal()
    End Sub
End Class