Imports MySql.Data.MySqlClient

Public Class MenuLogin
    Public Shared LoggedInUser As String
    Public Shared UserRole As String

    Private Sub MenuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.PasswordChar = "*"c
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        Dim role As String = AuthenticateUser(username, password)
        If role IsNot Nothing Then
            LoggedInUser = username ' Simpan nama pengguna yang login
            UserRole = role ' Simpan peran pengguna
            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Tampilkan form berdasarkan peran pengguna
            If role.ToLower() = "admin" Then
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

    Private Function AuthenticateUser(username As String, password As String) As String
        Dim role As String = Nothing

        Try
            Dim dbConnection As New DatabaseConnection()
            Using conn As MySqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT r.nama_role FROM users u JOIN roles r ON u.role_id = r.id_role WHERE u.username = @username AND u.password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        role = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghubungkan ke database: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return role
    End Function
End Class
