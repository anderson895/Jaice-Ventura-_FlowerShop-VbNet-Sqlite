Imports System.Data.SQLite
Imports System.IO

Public Class OrdersSummaryForm
    Dim dbPath As String = Path.Combine(Application.StartupPath, "CartDB.db")
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

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Dim cartForm = New Cart()
        cartForm.Show()
        Me.Close()
    End Sub

    Private Sub OrdersSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form loads
        LoadOrdersSummaryData()
    End Sub

    Private Sub LoadOrdersSummaryData()
        Try
            ' Connect to the SQLite database
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Select all records from the OrdersSummary table
                Dim query As String = "SELECT * FROM OrdersSummary"
                Using command As New SQLiteCommand(query, connection)
                    ' Execute the query and fill the DataTable with the result
                    Dim dataTable As New DataTable()
                    Using adapter As New SQLiteDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using

                    ' Bind the DataTable to the DataGridView
                    ordersSummaryTable.DataSource = dataTable
                End Using
            End Using

            ' Format the "Subtotal" column to display "P" with comma-separated values
            For Each column As DataGridViewColumn In ordersSummaryTable.Columns
                If column.Name = "Subtotal" Then
                    column.DefaultCellStyle.Format = "#,0" ' Use "P0" for currency format with zero decimal places
                End If
            Next

        Catch ex As Exception
            ' Handle exceptions, log, or display an error message
            MessageBox.Show("Error loading data from OrdersSummary table: " & ex.Message)
        End Try
    End Sub

    Private Sub removeAllButton_Click(sender As Object, e As EventArgs) Handles removeAllButton.Click
        ' Check if there are no items in the order summary
        If ordersSummaryTable.Rows.Count = 0 Then
            MessageBox.Show("There are no items to remove from the order summary.", "Empty Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Ask the user for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove all items from the order summary?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            Try
                ' Connect to the SQLite database
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()

                    ' Delete all records from the OrdersSummary table
                    Dim query As String = "DELETE FROM OrdersSummary"
                    Using command As New SQLiteCommand(query, connection)
                        ' Execute the query
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Refresh the DataGridView to reflect the changes
                LoadOrdersSummaryData()

                ' Optionally, inform the user that items have been removed
                MessageBox.Show("All items removed from the order summary!")

            Catch ex As Exception
                ' Handle exceptions, log, or display an error message
                MessageBox.Show("Error removing items from the order summary: " & ex.Message)
            End Try
        End If
    End Sub
End Class
