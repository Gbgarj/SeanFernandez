Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud

Public Class PaymentForm

    Public Property SelectedProductID As String
    Public Property SelectedProductName As String
    Public Property QuantityEntered As Integer
    Public Property ProductPrice As Decimal

    Public ConnectionString As String = "Server=127.0.0.1;Database=productinventorydb;Uid=root;Pwd=;"
        Public Connection As New MySqlConnection(ConnectionString)
Public Property SubTotal As Decimal  ' This will be set by OrderingApp
    Private ReadOnly VATRate As Decimal = 0.12D  ' VAT rate of 12%
    Public Property OrderDetails As List(Of DataGridViewRow)

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calculate VAT and display SubTotal and VAT
        Dim vatAmount As Decimal = SubTotal * VATRate
        lblSubTotal.Text = SubTotal.ToString("₱#,##0.00")
        lblVAT.Text = vatAmount.ToString("₱#,##0.00")

        ' Display Total Amount (SubTotal + VAT)
        Dim totalAmount As Decimal = SubTotal + vatAmount
        lblTotalAmount.Text = totalAmount.ToString("₱#,##0.00")
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate Amount Received
        Dim amountReceived As Decimal
        If Not Decimal.TryParse(txtAmountReceived.Text, amountReceived) Then
            MessageBox.Show("Please enter a valid amount received.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get Total Amount from lblTotalAmount
        Dim totalAmount As Decimal = SubTotal * (1 + VATRate)

        ' Calculate Change
        If amountReceived < totalAmount Then
            MessageBox.Show("Insufficient amount received.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim change As Decimal = amountReceived - totalAmount
        lblChange.Text = change.ToString("₱#,##0.00")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()

    End Sub

    ' Add a property in PaymentForm to hold order details

    Private Sub GenerateReceipt(totalWithVat As Decimal, vat As Decimal, amountReceived As Decimal, change As Decimal)
        Dim receipt As New System.Text.StringBuilder()
        Dim subTotal As Decimal = totalWithVat - vat
        Dim receiptWidth As Integer = 30  ' Adjust width for better formatting

        ' Header with store information
        receipt.AppendLine(CenterText("                                   𝗝𝗢𝗟𝗟𝗜𝗚𝗘𝗧", receiptWidth))
        receipt.AppendLine(CenterText("            673 Quirino Highway, San Bartolome", receiptWidth))
        receipt.AppendLine(CenterText("                       Novaliches, Quezon City", receiptWidth))
        receipt.AppendLine(CenterText("                           Tel: (02) 8-123-4567", receiptWidth))
        receipt.AppendLine("")
        Dim transactionID As String = "JLNGET" & Now.ToString("yyyyMMddHHmmss")
        ' Transaction information
        receipt.AppendLine($"Date: {DateTime.Now:MM/dd/yyyy}")
        receipt.AppendLine($"Time: {DateTime.Now:HH:mm:ss}")
        receipt.AppendLine("")

        ' Order details header
        receipt.AppendLine(New String("="c, receiptWidth))
        receipt.AppendLine("ITEM                    QTY           PRICE            TOTAL")
        receipt.AppendLine(New String("="c, receiptWidth))

        ' Loop through each item in OrderDetails and add it to the receipt
        For Each row As DataGridViewRow In OrderDetails
            If Not row.IsNewRow Then
                Dim productName As String = row.Cells("ProductColumn").Value.ToString()
                Dim quantity As Integer = Convert.ToInt32(row.Cells("QuantityColumn").Value)

                ' Remove currency symbols and convert to decimal
                Dim price As Decimal = Convert.ToDecimal(row.Cells("PriceColumn").Value.ToString().Replace("₱", "").Trim())
                Dim total As Decimal = Convert.ToDecimal(row.Cells("TotalColumn").Value.ToString().Replace("₱", "").Trim())

                ' Truncate product name if too long
                If productName.Length > 15 Then
                    productName = productName.Substring(0, 12) & "..."
                End If

                ' Format the item line with fixed-width columns
                receipt.AppendLine(String.Format("{0,-15} {1,3}  {2,10} {3,10}",
                                         productName,
                                         quantity,
                                         price.ToString("          ₱#,##0.00"),
                                         total.ToString("         ₱#,##0.00")))
            End If
        Next

        ' Summary section
        receipt.AppendLine(New String("="c, receiptWidth))
        receipt.AppendLine(String.Format("{0,-25} {1,10}", "Sub Total:                                            ", subTotal.ToString("₱#,##0.00")))
        receipt.AppendLine(String.Format("{0,-25} {1,10}", "VAT (12%):                                            ", vat.ToString("₱#,##0.00")))
        receipt.AppendLine(New String("="c, receiptWidth))
        receipt.AppendLine(String.Format("{0,-25} {1,10}", "TOTAL:", totalWithVat.ToString("                                ₱#,##0.00")))
        receipt.AppendLine("")
        receipt.AppendLine(String.Format("{0,-25} {1,10}", "CASH:", amountReceived.ToString("                                 ₱#,##0.00")))
        receipt.AppendLine(String.Format("{0,-25} {1,10}", "CHANGE:", change.ToString("                              ₱#,##0.00")))

        ' Footer
        receipt.AppendLine(New String("="c, receiptWidth))
        receipt.AppendLine(CenterText("              Thank you for choosing JOLLIGET!", receiptWidth))
        receipt.AppendLine(CenterText("                       Please come again!", receiptWidth))
        receipt.AppendLine("")
        receipt.AppendLine(CenterText("                    Follow us on social media:", receiptWidth))
        receipt.AppendLine(CenterText("                FB: @JolligetPH | IG: @Jolliget", receiptWidth))

        ' Display the receipt in a message box (or replace with printing functionality)
        MessageBox.Show(receipt.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    ' Helper function to center text
    Private Function CenterText(text As String, width As Integer) As String
        Dim spaces As Integer = (width - text.Length) / 2
        Return text.PadLeft(spaces + text.Length).PadRight(width)
    End Function

    ' Helper function to generate a unique receipt number
    Private Function GenerateReceiptNumber() As String
        Return DateTime.Now.ToString("yyyyMMddHHmmss") & "-" & New Random().Next(1000, 9999).ToString()
    End Function

    ' Confirm button click event to generate and display the receipt
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' Assuming VAT is 12%
        Dim vat As Decimal = SubTotal * 0.12D
        Dim totalWithVat As Decimal = SubTotal + vat
        Dim amountReceived As Decimal
        Dim change As Decimal

        ' Validate and parse amount received
        If Decimal.TryParse(txtAmountReceived.Text, amountReceived) Then
            If amountReceived < totalWithVat Then
                MessageBox.Show("Insufficient amount received.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            change = amountReceived - totalWithVat

            ' Generate and show the receipt
            GenerateReceipt(totalWithVat, vat, amountReceived, change)

            ' Close the form with DialogResult.OK to indicate successful payment
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please enter a valid amount received.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Transaction report
        ' Generate a new Transaction ID (GUID format)
        Dim transactionID As String = "JLNGET" & Now.ToString("yyyyMMddHHmmss")
        Dim transactionDate As DateTime = DateTime.Now
        Dim totalAmount As Decimal = Decimal.Parse(lblTotalAmount.Text, Globalization.NumberStyles.Currency)

        Try
            ' Open the database connection
            Connection.Open()

            ' SQL Query to insert the transaction
            Dim query As String = "INSERT INTO transactions (TransactionID, TransactionDate, TotalAmount) VALUES (@TransactionID, @TransactionDate, @TotalAmount)"
            Dim command As New MySqlCommand(query, Connection)

            ' Add parameters to the query
            command.Parameters.AddWithValue("@TransactionID", transactionID)
            command.Parameters.AddWithValue("@TransactionDate", transactionDate)
            command.Parameters.AddWithValue("@TotalAmount", totalAmount)

            ' Execute the query
            command.ExecuteNonQuery()

            MessageBox.Show("Transaction saved successfully!")

            ' Optionally refresh the transaction report
            ' If you want to open the report directly:
            ' Dim report As New TransactionReport()
            ' report.Show()
        Catch ex As Exception
            MessageBox.Show("Error saving transaction: " & ex.Message)
        Finally
            ' Close the connection
            Connection.Close()
        End Try

        ' Ensure OrderDetails is not empty
        If OrderDetails Is Nothing OrElse OrderDetails.Count = 0 Then
            MessageBox.Show("No items to confirm.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim updateQuery As String = "
    INSERT INTO salesreport (ProductID, ProductName, QuantitySold, TotalAmount, OrderTime)
    VALUES (@ProductID, @ProductName, @Quantity, @Total, NOW())
    ON DUPLICATE KEY UPDATE
        QuantitySold = QuantitySold + @Quantity,
        TotalAmount = TotalAmount + @Total"

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            For Each row As DataGridViewRow In OrderDetails
                Dim command As New MySqlCommand(updateQuery, connection)

                command.Parameters.AddWithValue("@ProductID", row.Cells("ProductCode").Value)

                command.Parameters.AddWithValue("@ProductName", row.Cells("ProductName").Value)
                command.Parameters.AddWithValue("@Quantity", row.Cells("Quantity").Value)
                command.Parameters.AddWithValue("@Total", row.Cells("Total").Value)
                command.ExecuteNonQuery()
            Next
            connection.Close()
        End Using




    End Sub



    Public Function CalculateSubTotal(orderDetails As List(Of DataGridViewRow)) As Decimal
        Dim subtotal As Decimal = 0

        For Each row As DataGridViewRow In orderDetails
            subtotal += Convert.ToDecimal(row.Cells("Total").Value) ' Replace "Total" with the actual column name
        Next

        Return subtotal
    End Function




End Class