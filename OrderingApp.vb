Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Globalization
Public Class OrderingApp



    Private connectionString As String = "server=localhost;user id=root;password=;database=productinventorydb"
    Dim connection As New MySqlConnection(connectionString)
    Private products As New Dictionary(Of String, Product)
    Private grandTotal As Decimal = 0
    Public quantity As Integer
    Public productCode As String

    Private Structure Product
        Public Code As String
        Public Name As String
        Public Price As Decimal
        Public StackRemain As Integer
    End Structure



    Private orders As Object

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub



    Private Sub OrderingApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshStockData()
        SetupDataGridView()
        OrdersDataGridView.Columns.Clear()

        ' Clear existing columns
        OrdersDataGridView.Columns.Clear()

        ' Add columns with specified names and headers
        OrdersDataGridView.Columns.Add("ProductColumn", "Product")
        OrdersDataGridView.Columns.Add("PriceColumn", "Price")
        OrdersDataGridView.Columns.Add("QuantityColumn", "Quantity")
        OrdersDataGridView.Columns.Add("TotalColumn", "Total")

    End Sub


    Public Sub RefreshStockData()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT ProductCode, Quantity FROM products"
            Dim cmd As New MySqlCommand(query, conn)

            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim productCode As String = reader("ProductCode").ToString()
                Dim quantity As Integer = Convert.ToInt32(reader("Quantity"))

                ' Update the corresponding label based on product code
                Select Case productCode
                    Case "CES001"
                        LblStack1.Text = quantity.ToString()
                    Case "CYB002"
                        LblStack2.Text = quantity.ToString()
                    Case "CS003"
                        LblStack3.Text = quantity.ToString()
                    Case "PBS004"
                        LblStack4.Text = quantity.ToString()
                    Case "BS005"
                        LblStack5.Text = quantity.ToString()
                    Case "JNF006"
                        LblStack6.Text = quantity.ToString()
                    Case "MPB007"
                        LblStack7.Text = quantity.ToString()
                    Case "CF008"
                        LblStack8.Text = quantity.ToString()
                    Case "CEEF009"
                        LblStack9.Text = quantity.ToString()
                    Case "FCJ010"
                        LblStack10.Text = quantity.ToString()

                End Select
            End While
        End Using
    End Sub


    Private Sub SetupDataGridView()
        OrdersDataGridView.Columns.Clear()

        With OrdersDataGridView
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
            .BackgroundColor = Color.White
            .RowHeadersVisible = False
        End With

        OrdersDataGridView.Columns.Add("Product", "Product")
        OrdersDataGridView.Columns.Add("Price", "Price")
        OrdersDataGridView.Columns.Add("Quantity", "Quantity")
        OrdersDataGridView.Columns.Add("Total", "Total")

        OrdersDataGridView.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        OrdersDataGridView.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles btnBuy1.Click, btnBuy2.Click, btnBuy3.Click, btnBuy4.Click, btnBuy5.Click, btnBuy6.Click, btnBuy7.Click, btnBuy8.Click, btnBuy9.Click, btnBuy10.Click
        ' Get product details based on which Buy button was clicked
        Dim productCode As String = ""
        Dim productName As String = ""
        Dim productPrice As Decimal = 0
        Dim quantityControl As NumericUpDown = Nothing
        Dim stackLabel As Label = Nothing
        Dim stackRemain As Integer = 0

        ' Identify the clicked button and corresponding controls
        Select Case True
            Case sender Is btnBuy1
                productCode = "CES001"
                productName = "Chickenjoy Solo"
                productPrice = 89
                quantityControl = UpDown1
                stackLabel = LblStack1
            Case sender Is btnBuy2
                productCode = "CYB002"
                productName = "Cheesy Yumburger"
                productPrice = 49
                quantityControl = UpDown2
                stackLabel = LblStack2
        ' Repeat for other buttons (btnBuy3, btnBuy4, etc.) with corresponding product details
            Case sender Is btnBuy3
                productCode = "CS003" ' Example product code for Burger Steak
                productName = "Chicken Sandwich"
                productPrice = 50
                quantityControl = UpDown3 ' Set to the appropriate NumericUpDown control
                stackLabel = LblStack3 ' Label for Stack Remain
        ' Add similar cases for each Buy button
            Case sender Is btnBuy4
                productCode = "PBS004" ' Example product code for Burger Steak
                productName = "Palabok Solo"
                productPrice = 49
                quantityControl = UpDown4 ' Set to the appropriate NumericUpDown control
                stackLabel = LblStack4 ' Label for Stack Remain
        ' Add similar cases for each Buy button
            Case sender Is btnBuy5
                productCode = "BS005" ' Example product code for Burger Steak
                productName = "Burger Steak"
                productPrice = 65
                quantityControl = UpDown5 ' Set to the appropriate NumericUpDown control
                stackLabel = LblStack5 ' Label for Stack Remain
        ' Add similar cases for each Buy button
            Case sender Is btnBuy6
                productCode = "JNF006" ' Example product code for Burger Steak
                productName = "Jollinget Fries"
                productPrice = 50
                quantityControl = UpDown6 ' Set to the appropriate NumericUpDown control
                stackLabel = LblStack6 ' Label for Stack Remain
        ' Add similar cases for each Buy button
            Case sender Is btnBuy7
                productCode = "MPB007" ' Example product code for Burger Steak
                productName = "Mango Pie Bundle"
                productPrice = 120
                quantityControl = UpDown7 ' Set to the appropriate NumericUpDown control
                stackLabel = LblStack7 ' Label for Stack Remain
        ' Add similar cases for each Buy button
            Case sender Is btnBuy8
                productCode = "CF008" ' Example product code for Burger Steak
                productName = "Coke Float"
                productPrice = 39
                quantityControl = UpDown8 ' Set to the appropriate NumericUpDown control
                stackLabel = LblStack8 ' Label for Stack Remain
        ' Add similar cases for each Buy button
            Case sender Is btnBuy9
                productCode = "CEEF009" ' Example product code for Burger Steak
                productName = "Coffee Float"
                productPrice = 45
                quantityControl = UpDown9 ' Set to the appropriate NumericUpDown control
                stackLabel = LblStack9 ' Label for Stack Remain
                ' Add similar cases for each Buy button
            Case sender Is btnBuy10
                productCode = "FCJ010"
                productName = "Family Chickenjoy"
                productPrice = 200
                quantityControl = UpDown10
                stackLabel = LblStack10

        End Select

        stackRemain = Convert.ToInt32(stackLabel.Text)


        ' Check if quantityControl was assigned correctly
        If quantityControl Is Nothing Then
            MessageBox.Show("Could not determine the quantity control for this product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        stackRemain = Convert.ToInt32(stackLabel.Text)
        If stackRemain <= 0 Then
            MessageBox.Show($"{productName} is sold out!", "Sold Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Check if quantity is valid
        Dim quantity As Integer = Convert.ToInt32(quantityControl.Value)
        If quantity <= 0 Then
            MessageBox.Show("Please select a quantity greater than 0", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If quantity > stackRemain Then
            MessageBox.Show($"The selected quantity for {productName} exceeds the available stock. Only {stackRemain} units are available.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        ' Calculate the total amount for the selected product
        Dim totalAmount As Decimal = quantity * productPrice

        ' Add to OrdersDataGridView
        OrdersDataGridView.Rows.Add(productName, productPrice.ToString("₱#,##0.00"), quantity, totalAmount.ToString("₱#,##0.00"))

        ' Update Stack Remain in the UI and in the database
        Dim newStackRemain As Integer
        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' Decrease quantity in the database
            Dim query As String = "UPDATE products SET Quantity = Quantity - @Quantity WHERE ProductCode = @ProductCode"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Quantity", quantity)
            cmd.Parameters.AddWithValue("@ProductCode", productCode)
            cmd.ExecuteNonQuery()

            ' Retrieve updated quantity from database
            query = "SELECT Quantity FROM products WHERE ProductCode = @ProductCode"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ProductCode", productCode)
            newStackRemain = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        ' Update the Stack Remain label in the UI
        stackLabel.Text = newStackRemain.ToString()

        ' Refresh the grand total in the UI
        UpdateGrandTotal()

        ' Reset the quantity selection to 0 for the next selection
        quantityControl.Value = 0

        ' Refresh ProductInventoryApp if open
        If ProductInventoryApp IsNot Nothing AndAlso Not ProductInventoryApp.IsDisposed Then
            ProductInventoryApp.LoadData() ' Ensure LoadData is public in ProductInventoryApp
        End If
    End Sub

    Private Sub UpdateGrandTotal()
        Dim grandTotal As Decimal = 0

        ' Loop through each row in OrdersDataGridView to calculate the total
        For Each row As DataGridViewRow In OrdersDataGridView.Rows
            If Not row.IsNewRow Then
                Dim cellValue As String = row.Cells("TotalColumn").Value.ToString().Replace("₱", "").Trim()
                grandTotal += Decimal.Parse(cellValue, NumberStyles.Any, CultureInfo.InvariantCulture)
            End If
        Next

        ' Display the grand total
        LblGrandTotal.Text = $"₱{grandTotal:N2}"
    End Sub


    Private Sub InitializeSearchBar()
        ' Create TextBox event handler for real-time searching
        AddHandler txtSearch.TextChanged, AddressOf SearchTextBox_TextChanged
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs)
        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        ' Loop through all panels in FlowLayoutPanel
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is Panel Then
                Dim panel As Panel = DirectCast(ctrl, Panel)
                Dim found As Boolean = False

                ' Search through all controls in the panel
                For Each innerCtrl As Control In panel.Controls
                    ' Check labels for item name, code, and price
                    If TypeOf innerCtrl Is Label Then
                        Dim label As Label = DirectCast(innerCtrl, Label)
                        If label.Text.ToLower().Contains(searchText) Then
                            found = True
                            Exit For
                        End If
                    End If
                Next

                ' Show/hide panel based on search result
                panel.Visible = searchText = "" OrElse found
            End If
        Next
    End Sub

    ' Add button click handler for the search button (optional)
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PerformSearch()
    End Sub

    ' Optional: Add key press handler for Enter key
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then ' Enter key
            e.Handled = True ' Prevent beep sound
            PerformSearch()
        End If
    End Sub

    ' Method to perform the search
    Private Sub PerformSearch()
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()

        ' Loop through each panel in the FlowLayoutPanel
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is Panel Then
                ' Find the label with the product name within the panel
                Dim productLabel As Label = ctrl.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.ToLower().Contains("productname"))

                ' Check if product label text contains the search term
                If productLabel IsNot Nothing AndAlso productLabel.Text.ToLower().Contains(searchTerm) Then
                    ctrl.Visible = True
                Else
                    ctrl.Visible = False
                End If
            End If
        Next
    End Sub

    ' Add this method to reset the search
    Private Sub ResetSearch()
        txtSearch.Clear()
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is Panel Then
                ctrl.Visible = True
            End If
        Next
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnBuy6.Click

    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuy1.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Show()
        Close()
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ' Clear the orders DataGridView - using the proper name of your DataGridView
            OrdersDataGridView.Rows.Clear()

            ' Reset the grand total - using Label control
            LblGrandTotal.Text = "₱0.00"

            ' Reset all quantity inputs to 0
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is NumericUpDown Then
                    DirectCast(ctrl, NumericUpDown).Value = 0
                End If
            Next

            ' Clear the orders list if you're using one
            If orders IsNot Nothing Then
                orders.Clear()
            End If

            MessageBox.Show("System ready for next order!", "Refresh Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error refreshing system: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OrdersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdersDataGridView.CellContentClick

    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        ProductInventoryApp.Show()
        Me.Hide()
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click, Button13.Click
        Close()
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click


        ' Calculate the SubTotal from the DataGridView
        Dim subTotal As Decimal = 0
        For Each row As DataGridViewRow In OrdersDataGridView.Rows
            If Not row.IsNewRow Then
                subTotal += Convert.ToDecimal(row.Cells("TotalColumn").Value.ToString().Replace("₱", "").Trim())
            End If
        Next

        ' Open PaymentForm and pass OrderDetails and SubTotal
        Dim paymentForm As New PaymentForm()
        paymentForm.SubTotal = subTotal
        paymentForm.OrderDetails = OrdersDataGridView.Rows.Cast(Of DataGridViewRow)().ToList()  ' Convert Rows to List


        ' Show PaymentForm and handle the result
        If paymentForm.ShowDialog() = DialogResult.OK Then
            ' Payment is successful, clear the orders
            OrdersDataGridView.Rows.Clear()
            LblGrandTotal.Text = "₱0.00"
        End If

        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is InventoryReport Then
                Dim inventoryReport As InventoryReport = DirectCast(openForm, InventoryReport)
                inventoryReport.LoadData() ' Call LoadData method in InventoryReport
                Exit For
            End If
        Next

        NotifyLowStockAfterOrder()

        Dim orderDetails As New List(Of DataGridViewRow)

        For Each row As DataGridViewRow In OrdersDataGridView.Rows ' Replace dgvCart with your actual DataGridView name
            If Not row.IsNewRow Then
                orderDetails.Add(row)
            End If
        Next

        ' Pass the order details to the PaymentForm
        paymentForm.OrderDetails = orderDetails
        paymentForm.SubTotal = CalculateSubTotal(orderDetails)


    End Sub

    Private Function CalculateSubTotal(orderDetails As List(Of DataGridViewRow)) As Decimal
        Dim subtotal As Decimal = 0

        ' Iterate through the DataGridView rows to calculate the subtotal
        For Each row As DataGridViewRow In orderDetails
            ' Replace "Total" with the actual column name for the subtotal in your DataGridView
            If Not row.IsNewRow Then
                subtotal += Convert.ToDecimal(row.Cells("Total").Value) ' Use your actual column name here
            End If
        Next

        Return subtotal
    End Function

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        AdminLoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click_3(sender As Object, e As EventArgs) Handles Button2.Click
        ProductInventoryApp.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        SalesReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TransactionReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnInventoryReport.Click
        InventoryReport.Show()
        Me.Hide()
        NotifyLowStockAfterOrder()
    End Sub



    Private Sub LblStack2_Click(sender As Object, e As EventArgs) Handles LblStack2.Click

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

    Private Sub UpdateInventory(productCode As String, quantity As Integer)
        ' Logic to update inventory
        Dim query As String = "UPDATE inventoryreport SET Quantity = Quantity - @quantity WHERE ProductID = @productCode"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@quantity", quantity)
        command.Parameters.AddWithValue("@productCode", productCode)

        Try
            connection.Open()
            command.ExecuteNonQuery()

            ' Check for low stock after updating
            NotifyLowStockAfterOrder()
        Catch ex As Exception
            MessageBox.Show($"Error updating inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

End Class


