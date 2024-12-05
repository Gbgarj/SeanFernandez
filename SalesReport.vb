Imports MySql.Data.MySqlClient

Public Class SalesReport
    Dim connectionString As String = "server=127.0.0.1;userid=root;password=;database=productinventorydb"
    Dim connection As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OrderingApp.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProductInventoryApp.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TransactionReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnInventoryReport.Click
        InventoryReport.Show()
        Me.Hide()
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

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New MySqlConnection(connectionString)

    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        Dim filterType As String = cmbFilter.SelectedItem.ToString()
        Dim query As String = ""

        Select Case filterType
            Case "Daily"
                query = "SELECT ProductName, QuantitySold, TotalAmount FROM salesreport WHERE DATE(OrderTime) = CURDATE()"
            Case "Weekly"
                query = "SELECT ProductName, QuantitySold, TotalAmount FROM salesreport WHERE YEARWEEK(OrderTime, 1) = YEARWEEK(CURDATE(), 1)"
            Case "Monthly"
                query = "SELECT ProductName, QuantitySold, TotalAmount FROM salesreport WHERE MONTH(OrderTime) = MONTH(CURDATE()) AND YEAR(OrderTime) = YEAR(CURDATE())"
            Case "All"
                query = "SELECT ProductName, QuantitySold, TotalAmount FROM salesreport"
        End Select

        LoadSalesData(query)
        UpdateSummary(filterType)
    End Sub

    Private Sub LoadSalesData(query As String)
        Dim connection As New MySqlConnection(connectionString)
        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading sales data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub UpdateSummary(filterType As String)
        Dim query As String
        Dim totalSales As Decimal
        Dim highestProduct As String = ""
        Dim lowestProduct As String = ""

        Select Case filterType
            Case "Daily"
                query = "SELECT SUM(TotalAmount) AS TotalSales, MAX(ProductName) AS HighestProduct, MIN(ProductName) AS LowestProduct FROM salesreport WHERE DATE(OrderTime) = CURDATE()"
            Case "Weekly"
                query = "SELECT SUM(TotalAmount) AS TotalSales, MAX(ProductName) AS HighestProduct, MIN(ProductName) AS LowestProduct FROM salesreport WHERE YEARWEEK(OrderTime, 1) = YEARWEEK(CURDATE(), 1)"
            Case "Monthly"
                query = "SELECT SUM(TotalAmount) AS TotalSales, MAX(ProductName) AS HighestProduct, MIN(ProductName) AS LowestProduct FROM salesreport WHERE MONTH(OrderTime) = MONTH(CURDATE()) AND YEAR(OrderTime) = YEAR(CURDATE())"
            Case "All"
                query = "SELECT SUM(TotalAmount) AS TotalSales, MAX(ProductName) AS HighestProduct, MIN(ProductName) AS LowestProduct FROM salesreport"
        End Select

        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(query, connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                totalSales = If(IsDBNull(reader("TotalSales")), 0, reader("TotalSales"))
                highestProduct = If(IsDBNull(reader("HighestProduct")), "None", reader("HighestProduct"))
                lowestProduct = If(IsDBNull(reader("LowestProduct")), "None", reader("LowestProduct"))
            End If
            reader.Close()

            lblTotalSales.Text = "₱" & totalSales.ToString("N2")
            lblHighestSales.Text = highestProduct
            lblLowestSales.Text = lowestProduct
        Catch ex As Exception
            MessageBox.Show("Error updating summary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblHighestSales.Click

    End Sub
End Class

