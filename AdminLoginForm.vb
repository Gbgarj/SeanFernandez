Imports MySql.Data.MySqlClient

Public Class AdminLoginForm
    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Public Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Connect to the database
        Connect()

        ' Define the SQL query to check for matching username and password
        Dim query As String = "SELECT * FROM admins WHERE username = @username AND password = @password"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)

        ' Execute the query
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Check if any records are returned
        If reader.HasRows Then
            ' Login successful
            OrderingApp.Show()
            Me.Hide()
            txtUsername.Text = ""
            txtPassword.Text = ""
            ' You can navigate to another form or dashboard here
        Else
            ' Login declined
            MessageBox.Show("Invalid username or password. Login declined.")
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If

        ' Close the reader and the connection
        reader.Close()
        conn.Close()


        NotifyLowStockAfterOrder()

    End Sub
    Private connectionString As String = "server=localhost;user id=root;password=;database=productinventorydb"
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
        Me.Close()
    End Sub

    Dim SignUp As New AdminSignUpForm()

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

End Class