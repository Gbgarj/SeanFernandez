Imports MySql.Data.MySqlClient

Module DatabaseConnection
    Public conn As MySqlConnection

    Public Sub Connect()
        ' Update with your database details
        Dim connectionString As String = "server=127.0.0.1;user id=root;password=;database=adminsdb"
        conn = New MySqlConnection(connectionString)
        conn.Open()
    End Sub
End Module

Public Class AdminSignUpForm

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles register.Click
        Connect()

        Dim query As String = "INSERT INTO admins (firstname, lastname, username, password) VALUES (@firstname, @lastname, @username, @password)"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@firstname", firstname.Text)
        cmd.Parameters.AddWithValue("@lastname", lastname.Text)
        cmd.Parameters.AddWithValue("@username", username.Text)
        cmd.Parameters.AddWithValue("@password", password.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Registration successful!")
        AdminLoginForm.Show()
        Me.Hide()

        conn.Close()

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles lastname.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        firstname.Text = ""
        lastname.Text = ""
        username.Text = ""
        password.Text = ""
    End Sub

    Private Sub firstname_TextChanged(sender As Object, e As EventArgs) Handles firstname.TextChanged

    End Sub

    Private Sub AdminSignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class