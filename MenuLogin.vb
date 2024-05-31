Imports MySql.Data.MySqlClient

Public Class MenuLogin
    Public Shared LoggedInUser As String
    Private Sub MenuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.PasswordChar = "*"c
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        If AuthenticateUser(username, password) Then
            LoggedInUser = username ' Simpan nama pengguna yang login
            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Cek username untuk menentukan form yang akan ditampilkan
            If username.ToLower() = "admin" Then
                Main.Show() ' Menampilkan form utama
                Form_TampilanAntrian.Show() ' Menampilkan form tampilan antrian
            Else
                Form_TampilanAntrian.Show() ' Menampilkan form tampilan antrian
            End If

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
End Class
