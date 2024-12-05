Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class InventoryReport
    ' Define the connection string to your database
    Private connectionString As String = "server=localhost;user id=root;password=;database=productinventorydb"
    Dim connection As MySqlConnection

    Private Sub InventoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    Public Sub NotifyLowStockAfterOrder()
        Dim query As String = "SELECT ProductName, Quantity, LowestQty FROM inventoryreport WHERE Quantity <= LowestQty"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(query, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim productName As String = reader("ProductName").ToString()
                Dim quantity As Integer = Integer.Parse(reader("Quantity").ToString())
                Dim lowestQty As Integer = Integer.Parse(reader("LowestQty").ToString())

                ' Display notification
                MessageBox.Show($"{productName} has low stock: {quantity} items left. Please restock.", "Low Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End While
        Catch ex As Exception
            MessageBox.Show($"Error checking low stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrderingApp.Click
        OrderingApp.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnTransactionReport.Click
        TransactionReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        SalesReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnProductInventory.Click
        ProductInventoryApp.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub LoadData()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ProductID, ProductName, Quantity, LowestQty FROM inventoryreport"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvInventory.DataSource = table
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
    End Sub

    Private Sub btnEditLowStock_Click(sender As Object, e As EventArgs) Handles btnEditLowStock.Click
        ' Ensure a row is selected
        If dgvInventory.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvInventory.SelectedRows(0)
            Dim productId = selectedRow.Cells("ProductID").Value.ToString ' Use ToString for alphanumeric ProductID

            ' Get the new Low Stock Level from the TextBox
            If Integer.TryParse(txtLowStockLevel.Text, Nothing) Then
                Dim newLowStockLevel = Convert.ToInt32(txtLowStockLevel.Text)
                UpdateLowStockLevel(productId, newLowStockLevel)
            Else
                MessageBox.Show("Please enter a valid number in the Low Stock Level textbox.")
            End If
        Else
            MessageBox.Show("Please select a product to edit.")
        End If

        txtLowStockLevel.Text = ""
    End Sub

    Private Sub UpdateLowStockLevel(productId As String, newLowStockLevel As Integer)
        Dim query As String = "UPDATE inventoryreport SET LowestQty = @LowestQty WHERE ProductID = @ProductID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@LowestQty", newLowStockLevel)
                command.Parameters.AddWithValue("@ProductID", productId)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Low Stock Level updated successfully.")
                    LoadData() ' Refresh the DataGridView
                Catch ex As MySqlException
                    MessageBox.Show("Error updating Low Stock Level: " & ex.Message)
                End Try

            End Using
        End Using
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ProductInventoryApp.Show()
        Me.Hide()
    End Sub
End Class