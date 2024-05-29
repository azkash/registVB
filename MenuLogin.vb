Imports MySql.Data.MySqlClient

Public Class MenuLogin
    Private Sub MenuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.PasswordChar = "*"c
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Main.Show() ' Menampilkan form utama
            Me.Hide() ' Menyembunyikan form login
        Else
            MessageBox.Show("Username atau password salah!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit() ' Keluar dari aplikasi
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim isAuthenticated As Boolean = False

        Try
            Dim dbConnection As New DatabaseConnection()
            Using conn As MySqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    isAuthenticated = (result > 0)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghubungkan ke database: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return isAuthenticated
    End Function

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub
End Class
