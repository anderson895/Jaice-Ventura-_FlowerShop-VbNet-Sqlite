Imports System.Data.SQLite
Imports System.IO

Public Class OneFiveToThree
    Public dbPath As String = Path.Combine(Application.StartupPath, "CartDB.db")
    Private connectionString As String = $"Data Source={dbPath};Version=3;"

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

    Private Sub cartButton_Click(sender As Object, e As EventArgs) Handles cartButton.Click
        ' Create an instance of the Cart form
        Dim cartForm As New Cart()

        ' Show the Cart form
        cartForm.Show()

        ' Optionally, hide the current form
        Me.Close()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Dim mainForm As New Main()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub AddToShoppingCart(productName As String, price As Integer, quantity As Integer)
        Try
            ' Connect to the SQLite database
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Check if the product with the same name already exists in the ShoppingCart
                Dim queryCheck As String = "SELECT COUNT(*) FROM ShoppingCart WHERE [Product Name] = @ProductName"
                Using commandCheck As New SQLiteCommand(queryCheck, connection)
                    ' Use parameters to avoid SQL injection
                    commandCheck.Parameters.AddWithValue("@ProductName", productName)

                    ' Execute the query to check if the product exists
                    Dim existingProductCount As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingProductCount > 0 Then
                        ' Product already exists, update the quantity
                        Dim queryUpdate As String = "UPDATE ShoppingCart SET [Quantity] = [Quantity] + @Quantity WHERE [Product Name] = @ProductName"
                        Using commandUpdate As New SQLiteCommand(queryUpdate, connection)
                            ' Use parameters to avoid SQL injection
                            commandUpdate.Parameters.AddWithValue("@ProductName", productName)
                            commandUpdate.Parameters.AddWithValue("@Quantity", quantity)

                            ' Execute the query to update the quantity
                            commandUpdate.ExecuteNonQuery()
                        End Using
                    Else
                        ' Product does not exist, insert a new record
                        Dim queryInsert As String = "INSERT INTO ShoppingCart ([Product Name], [Product Price], [Quantity]) VALUES (@ProductName, @Price, @Quantity)"
                        Using commandInsert As New SQLiteCommand(queryInsert, connection)
                            ' Use parameters to avoid SQL injection
                            commandInsert.Parameters.AddWithValue("@ProductName", productName)
                            commandInsert.Parameters.AddWithValue("@Price", price)
                            commandInsert.Parameters.AddWithValue("@Quantity", quantity)

                            ' Execute the query to insert the new record
                            commandInsert.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions, log, or display an error message
            MessageBox.Show("Error adding product to cart: " & ex.Message)
        End Try
    End Sub

    Private quantity As Integer = 0 ' Initial quantity
    Private quantity2 As Integer = 0
    Private quantity3 As Integer = 0
    Private quantity4 As Integer = 0
    Private quantity5 As Integer = 0
    Private quantity6 As Integer = 0
    Private quantity7 As Integer = 0
    Private quantity8 As Integer = 0
    Private quantity9 As Integer = 0
    Private quantity10 As Integer = 0

    Private Sub addToCartButton_Click(sender As Object, e As EventArgs) Handles addToCartButton.Click
        ' Retrieve product information from the form
        Dim productName As String = name1.Text
        Dim priceString As String = price1.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity > 0 Then
            quantity -= 1
        End If

        ' Update the quantityLabel
        quantityLabel.Text = quantity.ToString()
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        ' Increase quantity
        quantity += 1

        ' Update the quantityLabel
        quantityLabel.Text = quantity.ToString()
    End Sub

    Private Sub addToCartButton2_Click(sender As Object, e As EventArgs) Handles addToCartButton2.Click
        ' Retrieve product information from the form
        Dim productName As String = name2.Text
        Dim priceString As String = price2.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel2.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity2 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel2.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton2_Click(sender As Object, e As EventArgs) Handles minusButton2.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity2 > 0 Then
            quantity2 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel2.Text = quantity2.ToString()
    End Sub

    Private Sub plusButton2_Click(sender As Object, e As EventArgs) Handles plusButton2.Click
        ' Increase quantity
        quantity2 += 1

        ' Update the quantityLabel
        quantityLabel2.Text = quantity2.ToString()
    End Sub

    Private Sub addToCartButton3_Click(sender As Object, e As EventArgs) Handles addToCartButton3.Click
        ' Retrieve product information from the form
        Dim productName As String = name3.Text
        Dim priceString As String = price3.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel3.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity3 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel3.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton3_Click(sender As Object, e As EventArgs) Handles minusButton3.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity3 > 0 Then
            quantity3 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel3.Text = quantity3.ToString()
    End Sub

    Private Sub plusButton3_Click(sender As Object, e As EventArgs) Handles plusButton3.Click
        ' Increase quantity
        quantity3 += 1

        ' Update the quantityLabel
        quantityLabel3.Text = quantity3.ToString()
    End Sub

    Private Sub addToCartButton4_Click(sender As Object, e As EventArgs) Handles addToCartButton4.Click
        ' Retrieve product information from the form
        Dim productName As String = name4.Text
        Dim priceString As String = price4.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel4.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity4 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel4.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton4_Click(sender As Object, e As EventArgs) Handles minusButton4.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity4 > 0 Then
            quantity4 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel4.Text = quantity4.ToString()
    End Sub

    Private Sub plusButton4_Click(sender As Object, e As EventArgs) Handles plusButton4.Click
        ' Increase quantity
        quantity4 += 1

        ' Update the quantityLabel
        quantityLabel4.Text = quantity4.ToString()
    End Sub

    Private Sub addToCartButton5_Click(sender As Object, e As EventArgs) Handles addToCartButton5.Click
        ' Retrieve product information from the form
        Dim productName As String = name5.Text
        Dim priceString As String = price5.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel5.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity5 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel5.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton5_Click(sender As Object, e As EventArgs) Handles minusButton5.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity5 > 0 Then
            quantity5 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel5.Text = quantity5.ToString()
    End Sub

    Private Sub plusButton5_Click(sender As Object, e As EventArgs) Handles plusButton5.Click
        ' Increase quantity
        quantity5 += 1

        ' Update the quantityLabel
        quantityLabel5.Text = quantity5.ToString()
    End Sub

    Private Sub addToCartButton6_Click(sender As Object, e As EventArgs) Handles addToCartButton6.Click
        ' Retrieve product information from the form
        Dim productName As String = name6.Text
        Dim priceString As String = price6.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel6.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity6 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel6.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton6_Click(sender As Object, e As EventArgs) Handles minusButton6.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity6 > 0 Then
            quantity6 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel6.Text = quantity6.ToString()
    End Sub

    Private Sub plusButton6_Click(sender As Object, e As EventArgs) Handles plusButton6.Click
        ' Increase quantity
        quantity6 += 1

        ' Update the quantityLabel
        quantityLabel6.Text = quantity6.ToString()
    End Sub

    Private Sub addToCartButton7_Click(sender As Object, e As EventArgs) Handles addToCartButton7.Click
        ' Retrieve product information from the form
        Dim productName As String = name7.Text
        Dim priceString As String = price7.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel7.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity7 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel7.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton7_Click(sender As Object, e As EventArgs) Handles minusButton7.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity7 > 0 Then
            quantity7 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel7.Text = quantity7.ToString()
    End Sub

    Private Sub plusButton7_Click(sender As Object, e As EventArgs) Handles plusButton7.Click
        ' Increase quantity
        quantity7 += 1

        ' Update the quantityLabel
        quantityLabel7.Text = quantity7.ToString()
    End Sub

    Private Sub addToCartButton8_Click(sender As Object, e As EventArgs) Handles addToCartButton8.Click
        ' Retrieve product information from the form
        Dim productName As String = name8.Text
        Dim priceString As String = price8.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel8.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity8 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel8.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton8_Click(sender As Object, e As EventArgs) Handles minusButton8.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity8 > 0 Then
            quantity8 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel8.Text = quantity8.ToString()
    End Sub

    Private Sub plusButton8_Click(sender As Object, e As EventArgs) Handles plusButton8.Click
        ' Increase quantity
        quantity8 += 1

        ' Update the quantityLabel
        quantityLabel8.Text = quantity8.ToString()
    End Sub

    Private Sub addToCartButton9_Click(sender As Object, e As EventArgs) Handles addToCartButton9.Click
        ' Retrieve product information from the form
        Dim productName As String = name9.Text
        Dim priceString As String = price9.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel9.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity9 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel9.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton9_Click(sender As Object, e As EventArgs) Handles minusButton9.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity9 > 0 Then
            quantity9 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel9.Text = quantity9.ToString()
    End Sub

    Private Sub plusButton9_Click(sender As Object, e As EventArgs) Handles plusButton9.Click
        ' Increase quantity
        quantity9 += 1

        ' Update the quantityLabel
        quantityLabel9.Text = quantity9.ToString()
    End Sub

    Private Sub addToCartButton10_Click(sender As Object, e As EventArgs) Handles addToCartButton10.Click
        ' Retrieve product information from the form
        Dim productName As String = name10.Text
        Dim priceString As String = price10.Text.Replace("P", "").Replace(",", "").Trim()
        Dim price As Integer = Integer.Parse(priceString)
        Dim quantity As Integer = Integer.Parse(quantityLabel10.Text)

        ' Check if the quantity is greater than zero before adding to the cart
        If quantity10 > 0 Then
            ' Add the product to the ShoppingCart
            AddToShoppingCart(productName, price, quantity)

            ' Inform the user that the product has been added to the cart
            MessageBox.Show($"{productName} added to cart!")

            ' You might also want to update the UI to reflect the changes, like resetting the quantity label
            quantityLabel10.Text = "0"
        Else
            ' Display a message if the quantity is zero
            MessageBox.Show("Please select a quantity greater than zero before adding to the cart.")
        End If
    End Sub

    Private Sub minusButton10_Click(sender As Object, e As EventArgs) Handles minusButton10.Click
        ' Decrease quantity but ensure it doesn't go below zero
        If quantity10 > 0 Then
            quantity10 -= 1
        End If

        ' Update the quantityLabel
        quantityLabel10.Text = quantity10.ToString()
    End Sub

    Private Sub plusButton10_Click(sender As Object, e As EventArgs) Handles plusButton10.Click
        ' Increase quantity
        quantity10 += 1

        ' Update the quantityLabel
        quantityLabel10.Text = quantity10.ToString()
    End Sub
End Class