Imports System.Data.SQLite
Imports System.IO

Public Class PlaceOrderForm
    Dim dbPath As String = Path.Combine(Application.StartupPath, "CartDB.db")
    Private connectionString As String = $"Data Source={dbPath};Version=3;"

    ' Declare a variable to store the total value
    Private totalValue As String

    ' Constructor to receive the total value
    Public Sub New(totalValue As String)
        InitializeComponent()

        ' Set the totalValue variable
        Me.totalValue = totalValue
    End Sub

    ' Load event where you can set the totalLabel text
    Private Sub PlaceOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the totalLabel text with the received total value
        totalLabel.Text = Me.totalValue
    End Sub

    Private Sub placeOrderButton_Click(sender As Object, e As EventArgs) Handles placeOrderButton.Click
        ' Validate nameTextBox, addressTextBox, and paymentTextBox
        If String.IsNullOrWhiteSpace(nameTextBox.Text) Then
            MessageBox.Show("Please enter your name.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(addressTextBox.Text) Then
            MessageBox.Show("Please enter your address.", "Address Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim paymentAmount As Decimal

        If Not Decimal.TryParse(paymentTextBox.Text, paymentAmount) Then
            MessageBox.Show("Please enter a valid payment amount.", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the total value from the totalLabel in the Cart form
        Dim totalValue As Decimal

        If Not Decimal.TryParse(totalLabel.Text.Replace("P", "").Replace(",", ""), totalValue) Then
            MessageBox.Show("Error parsing the total amount.", "Invalid Total", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if payment is greater than or equal to the total amount
        If paymentAmount < totalValue Then
            MessageBox.Show("Payment amount must be greater than or equal to the total amount.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate the deliveryDatePicker
        Dim selectedDeliveryDate As Date = deliveryDatePicker.Value.Date
        Dim today As Date = Date.Today
        Dim minValidDate As Date = today.AddDays(2) ' Minimum valid date is 2 days from today
        Dim maxValidDate As Date = today.AddDays(30) ' Maximum valid date is 30 days from today

        If selectedDeliveryDate < minValidDate OrElse selectedDeliveryDate > maxValidDate Then
            MessageBox.Show("Invalid delivery date. Please select a date between " &
                        minValidDate.ToString("MMMM d, yyyy") & " and " &
                        maxValidDate.ToString("MMMM d, yyyy") & ".", "Invalid Delivery Date",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Continue processing the order if all validations pass

        Try
            ' Connect to the SQLite database
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Insert the order details into the OrdersSummary table
                Dim query As String = "INSERT INTO OrdersSummary (Name, Address, [Delivery Date], Subtotal) VALUES (@Name, @Address, @DeliveryDate, @Subtotal)"
                Using command As New SQLiteCommand(query, connection)
                    ' Use parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@Name", nameTextBox.Text)
                    command.Parameters.AddWithValue("@Address", addressTextBox.Text)
                    command.Parameters.AddWithValue("@DeliveryDate", selectedDeliveryDate.ToString("dddd, MMMM d, yyyy"))
                    command.Parameters.AddWithValue("@Subtotal", totalValue) ' Use the total value obtained from the Cart form

                    ' Execute the query
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Calculate the change
            Dim change As Integer = paymentAmount - totalValue

            ' Optionally, inform the user about the order and change
            MessageBox.Show($"Order placed successfully! Your change is P{change}", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the cartTable in the Cart form
            ClearCartTable()

            ' Optionally, go back to the Cart form
            Dim cartForm = New Cart()
            cartForm.LoadShoppingCartData()
            cartForm.CalculateAndDisplayTotal()
            cartForm.Show()
            Me.Close()

        Catch ex As Exception
            ' Handle exceptions, log, or display an error message
            MessageBox.Show("Error placing the order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearCartTable()
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

            ' Refresh the DataGridView to reflect the changes in the Cart form
            ' Dim cartForm As New Cart() '
            ' cartForm.LoadShoppingCartData() '
            ' cartForm.CalculateAndDisplayTotal() '

        Catch ex As Exception
            ' Handle exceptions, log, or display an error message
            MessageBox.Show("Error clearing the cart: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class