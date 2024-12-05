Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class TransactionReport

    Public ConnectionString As String = "Server=127.0.0.1;Database=productinventorydb;Uid=root;Pwd=;"
    Public Connection As New MySqlConnection(ConnectionString)

    Private Sub TransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactionReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SalesReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProductInventoryApp.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OrderingApp.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        AdminLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn.Click
        Me.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    Private Sub LoadTransactionReport()
        Try
            ' Open the database connection
            Connection.Open()

            ' SQL Query to fetch all transactions
            Dim query As String = "SELECT TransactionID, TransactionDate, TotalAmount FROM transactions"
            Dim adapter As New MySqlDataAdapter(query, Connection)
            Dim table As New DataTable()

            ' Fill the DataTable with the data from the query
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView
            TransactionGridView.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            Connection.Close()
        End Try

        TransactionGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    End Sub

    Private Sub TransactionGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionGridView.CellContentClick
        TransactionGridView.RowTemplate.Height = 40

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            ' Open the database connection
            Connection.Open()

            ' SQL Query to filter transactions based on date range
            Dim query = "SELECT TransactionID, TransactionDate, TotalAmount 
                               FROM transactions 
                               WHERE TransactionDate BETWEEN @FromDate AND @ToDate"
            Dim command As New MySqlCommand(query, Connection)

            ' Add parameters for the date range
            command.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date)
            command.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable

            ' Fill the DataTable with filtered data
            adapter.Fill(table)

            ' Bind the filtered data to the DataGridView
            TransactionGridView.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error filtering transactions: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            Connection.Close()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        InventoryReport.Show()
        Me.Hide()
        NotifyLowStockAfterOrder()
    End Sub

    Public Sub NotifyLowStockAfterOrder()
        Dim query As String = "SELECT ProductName, Quantity, LowestQty FROM inventoryreport WHERE Quantity <= LowestQty"
        Dim connection As New MySqlConnection(ConnectionString)
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