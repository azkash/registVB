Imports MySql.Data.MySqlClient
Public Class registrasi
    Private connString As String = "server=localhost;userid=root;password=;database=datapasien"
    Private conn As New MySqlConnection(connString)
    Private Sub registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            TextBox_Nama.Text = selectedRow.Cells("nama").Value.ToString()
            TextBox_TTL.Text = selectedRow.Cells("ttl").Value.ToString()

            Dim gender As String = selectedRow.Cells("gender").Value.ToString()
            If gender = "P" Then
                RadioButton_P.Checked = True
            ElseIf gender = "L" Then
                RadioButton_L.Checked = True
            End If

            TextBox_Alamat.Text = selectedRow.Cells("alamat").Value.ToString()

            ' Pindah ke tab tambah data
            TabControl.SelectedTab = TabPage2
            DataGridView1 = DataGridView2
        Else
            MessageBox.Show("Pilih baris yang akan diedit terlebih dahulu.")
        End If
    End Sub

    Private Sub Button_Print_Click(sender As Object, e As EventArgs) Handles Button_Print.Click
        ' Implement print functionality
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        DeletePatient()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    ' Page tambah data
    Private Sub TextBox_Nama_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Nama.TextChanged
    End Sub

    Private Sub TextBox_TTL_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TTL.TextChanged
    End Sub

    Private Sub RadioButton_P_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_P.CheckedChanged
    End Sub

    Private Sub TextBox_Alamat_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Alamat.TextChanged
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        SavePatient()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
    End Sub

    ' Function to load patient data
    Private Sub LoadData()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim query As String = "SELECT * FROM pasien"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As MySqlException
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Function to save or update patient data
    Private Sub SavePatient()
        If String.IsNullOrEmpty(TextBox_Nama.Text) OrElse String.IsNullOrEmpty(TextBox_TTL.Text) OrElse String.IsNullOrEmpty(TextBox_Alamat.Text) Then
            MessageBox.Show("Mohon isi semua data.")
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Periksa apakah data sudah ada (mode edit) atau data baru (mode tambah)
            Dim query As String
            If DataGridView1.SelectedRows.Count > 0 Then
                query = "UPDATE pasien SET nama = @nama, ttl = @ttl, gender = @gender, alamat = @alamat WHERE id = @id"
            Else
                query = "INSERT INTO pasien (nama, ttl, gender, alamat) VALUES (@nama, @ttl, @gender, @alamat)"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", TextBox_Nama.Text)
            cmd.Parameters.AddWithValue("@ttl", TextBox_TTL.Text)
            cmd.Parameters.AddWithValue("@gender", If(RadioButton_P.Checked, "P", "L"))
            cmd.Parameters.AddWithValue("@alamat", TextBox_Alamat.Text)

            If DataGridView1.SelectedRows.Count > 0 Then
                cmd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells("id").Value)
            End If

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!")
            LoadData()
        Catch ex As MySqlException
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Function to delete patient data
    Private Sub DeletePatient()
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id").Value)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "DELETE FROM pasien WHERE id = @id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus!")
                LoadData()
            Catch ex As MySqlException
                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        Else
            MessageBox.Show("Pilih baris yang akan dihapus terlebih dahulu.")
        End If
    End Sub

    ' Form Load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            ' Get the search text
            Dim searchText As String = TextBox_Search.Text.Trim()

            ' Define the query with a parameter for the search text
            Dim query As String = "SELECT * FROM pasien WHERE nama LIKE @search OR alamat LIKE @search"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Set the filtered data as the DataSource for DataGridViewPatients
            DataGridView1.DataSource = table

        Catch ex As MySqlException
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub Button_Save_Click_1(sender As Object, e As EventArgs) Handles Button_Save.Click

    End Sub
End Class