Imports MySql.Data.MySqlClient

Public Class ProductInventoryApp

    Private connectionString As String = "server=localhost;user id=root;password=;database=productinventorydb"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        OrderingApp.Show()
        Hide()
    End Sub

    Private Sub ProductInventoryApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub

    Public Sub LoadData()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT ProductCode, ProductName, ProductPrice, Quantity FROM products"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvProducts.DataSource = table
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvProducts.SelectedRows(0)
            Dim productCode As String = selectedRow.Cells("ProductCode").Value.ToString()
            Dim newQuantity As Integer

            ' Validate the quantity entered
            If Integer.TryParse(txtQuantity.Text, newQuantity) Then
                ' Update the quantity in the database
                UpdateQuantity(productCode, newQuantity)

                ' Refresh the ProductInventoryApp DataGridView
                LoadData()

                ' Check if InventoryReport is open, then refresh its data
                For Each openForm As Form In Application.OpenForms
                    If TypeOf openForm Is InventoryReport Then
                        Dim inventoryReport As InventoryReport = DirectCast(openForm, InventoryReport)
                        inventoryReport.LoadData() ' Call LoadData method in InventoryReport
                        Exit For
                    End If
                Next

                MessageBox.Show("Quantity updated successfully!")
            Else
                MessageBox.Show("Please enter a valid quantity.")
            End If
        Else
            MessageBox.Show("Please select a product to update.")
        End If

        ' Clear the input field
        txtQuantity.Text = ""

        Dim orderingAppForm As OrderingApp = Application.OpenForms.OfType(Of OrderingApp)().FirstOrDefault()
        If orderingAppForm IsNot Nothing Then
            ' Call the RefreshStockData method
            orderingAppForm.RefreshStockData()
        Else
            MessageBox.Show("OrderingApp is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub UpdateQuantity(productCode As String, newQuantity As Integer)
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE products SET Quantity = @Quantity WHERE ProductCode = @ProductCode"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Quantity", newQuantity)
            command.Parameters.AddWithValue("@ProductCode", productCode)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

        End Using
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim productId As String = txtSearch.Text.Trim()  ' Get the entered Product ID

        ' Check if Product ID is provided
        If String.IsNullOrEmpty(productId) Then
            MessageBox.Show("Please enter a Product ID to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Clear any previous search results or highlights
        ClearSearchResults()

        ' Loop through each row in the DataGridView to find the matching Product ID
        Dim found As Boolean = False
        For Each row As DataGridViewRow In dgvProducts.Rows
            If row.Cells("ProductCode").Value.ToString().Equals(productId, StringComparison.OrdinalIgnoreCase) Then
                ' Highlight or select the matching row
                row.Selected = True
                found = True
                dgvProducts.FirstDisplayedScrollingRowIndex = row.Index  ' Scroll to the matched row
                Exit For  ' Stop searching after finding the first match
            End If
        Next

        ' Show a message if no match is found
        If Not found Then
            MessageBox.Show("Product ID not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearSearchResults()
        ' Loop through each row in the DataGridView and deselect it
        For Each row As DataGridViewRow In dgvProducts.Rows
            row.Selected = False
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OrderingApp.Show
        Hide
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        AdminLoginForm.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        OrderingApp.Show()
        Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SalesReport.Show()
        Me.Hide()
    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        TransactionReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        InventoryReport.Show()
        Me.Close()
        NotifyLowStockAfterOrder()
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


End Class
