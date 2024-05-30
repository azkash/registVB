Imports MySql.Data.MySqlClient
Public Class registrasi
    Private connString As String = "server=localhost;userid=root;password=;database=datapasien;Convert Zero Datetime=True"
    Private conn As New MySqlConnection(connString)
    Private Sub registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPoliData()
        LoadData()
        DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 12)
        DataGridView1.Columns("id").Width = 30 ' Set the width of the "id" column
        DataGridView1.Columns("nama").Width = 150 ' Set the width of the "nama" column
        DataGridView1.Columns("tempat_lahir").Width = 100 ' Set the width of the "tempat_lahir" column
        DataGridView1.Columns("ttl").Width = 100 ' Set the width of the "ttl" column
        DataGridView1.Columns("gender").Width = 50 ' Set the width of the "gender" column
        DataGridView1.Columns("alamat").Width = 200 ' Set the width of the "alamat" column
        DataGridView1.Columns("keluhan").Width = 150 ' Set the width of the "keluhan" column
        DataGridView1.Columns("poli_id").Width = 45 ' Set the width of the "poli_id" column
        DataGridView1.Columns("diagnosa").Width = 150 ' Set the width of the "diagnosa" column

        DataGridView2.DefaultCellStyle.Font = New Font("Segoe UI", 12)
        DataGridView2.Columns("id").Width = 30 ' Set the width of the "id" column
        DataGridView2.Columns("nama").Width = 150 ' Set the width of the "nama" column
        DataGridView2.Columns("tempat_lahir").Width = 100 ' Set the width of the "tempat_lahir" column
        DataGridView2.Columns("ttl").Width = 100 ' Set the width of the "ttl" column
        DataGridView2.Columns("gender").Width = 50 ' Set the width of the "gender" column
        DataGridView2.Columns("alamat").Width = 200 ' Set the width of the "alamat" column
        DataGridView2.Columns("keluhan").Width = 150 ' Set the width of the "keluhan" column
        DataGridView2.Columns("poli_id").Width = 45 ' Set the width of the "poli_id" column
        DataGridView2.Columns("diagnosa").Width = 150 ' Set the width of the "diagnosa" column
    End Sub

    Private Sub ClearFormTambah()
        TextBox_Nama.Clear()
        RadioButton_L.Checked = False
        RadioButton_P.Checked = False
        tempat_lahir.Clear()
        tglLahir.Value = DateTime.Now
        TextBox_Alamat.Clear()
        keluhan.Clear()
        poli_id.SelectedIndex = -1 ' Deselect any selected item
    End Sub
    Private Sub ClearFormEdit()
        label_id.Text = ""
        TextBox4_nama.Clear()
        RadioButton1_L.Checked = False
        RadioButton2_p.Checked = False
        TextBox1_tLahir.Clear()
        DateTimePicker1.Value = DateTime.Now
        TextBox3_alamat.Clear()
        TextBox2_keluhan.Clear()
        ComboBox1_poli.SelectedIndex = -1 ' Deselect any selected item
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            label_id.Text = selectedRow.Cells("id").Value.ToString()
            TextBox4_nama.Text = selectedRow.Cells("nama").Value.ToString()
            Dim gender As String = selectedRow.Cells("gender").Value.ToString()

            If gender = "P" Then
                RadioButton2_p.Checked = True
            ElseIf gender = "L" Then
                RadioButton1_L.Checked = True
            End If

            TextBox1_tLahir.Text = selectedRow.Cells("tempat_lahir").Value.ToString()
            DateTimePicker1.Text = selectedRow.Cells("ttl").Value.ToString()
            TextBox3_alamat.Text = selectedRow.Cells("alamat").Value.ToString()

            Dim poliId As Integer = Convert.ToInt32(selectedRow.Cells("poli_id").Value)
            ComboBox1_poli.SelectedValue = poliId

            TextBox2_keluhan.Text = selectedRow.Cells("keluhan").Value.ToString()

            TabControl.Visible = True
            TabControl.SelectedTab = TabPage3
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

    ' Page tambah data

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        SavePatient()
    End Sub

    'load poli data'
    Private Sub LoadPoliData()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim query As String = "SELECT id, nama_poli FROM poli"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            poli_id.DataSource = table
            poli_id.DisplayMember = "nama_poli"
            poli_id.ValueMember = "id"
            ComboBox1_poli.DataSource = table
            ComboBox1_poli.DisplayMember = "nama_poli"
            ComboBox1_poli.ValueMember = "id"
        Catch ex As MySqlException
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
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
            DataGridView2.DataSource = table
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
        'buat assign edit form'

        If String.IsNullOrEmpty(TextBox_Nama.Text) OrElse String.IsNullOrEmpty(tempat_lahir.Text) OrElse String.IsNullOrEmpty(TextBox_Alamat.Text) Then
            MessageBox.Show("Mohon isi semua data.")
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "INSERT INTO pasien (nama, tempat_lahir, ttl, gender, alamat, keluhan, poli_id) VALUES (@nama, @tempat_lahir, @ttl, @gender, @alamat, @keluhan, @poli_id)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", TextBox_Nama.Text)
            cmd.Parameters.AddWithValue("@tempat_lahir", tempat_lahir.Text)
            cmd.Parameters.AddWithValue("@ttl", tglLahir.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@gender", If(RadioButton_P.Checked, "P", "L"))
            cmd.Parameters.AddWithValue("@alamat", TextBox_Alamat.Text)
            cmd.Parameters.AddWithValue("@keluhan", keluhan.Text)
            cmd.Parameters.AddWithValue("@poli_id", poli_id.SelectedValue)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!")
            ClearFormTambah()
            LoadData()
        Catch ex As MySqlException
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub EditPatient()
        ' Ensure required fields are not empty
        If String.IsNullOrEmpty(TextBox4_nama.Text) OrElse String.IsNullOrEmpty(TextBox1_tLahir.Text) OrElse String.IsNullOrEmpty(TextBox3_alamat.Text) Then
            MessageBox.Show("Mohon isi semua data.")
            Return
        End If

        ' Ensure a row is selected in DataGridView
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris yang akan diedit terlebih dahulu.")
            Return
        End If

        Try
            ' Open the connection if it is closed
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Prepare the update query
            Dim query As String = "UPDATE pasien SET nama = @nama, tempat_lahir = @tempat_lahir, ttl = @ttl, gender = @gender, alamat = @alamat, keluhan = @keluhan, poli_id = @poli_id WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            ' Bind parameters
            cmd.Parameters.AddWithValue("@nama", TextBox4_nama.Text)
            cmd.Parameters.AddWithValue("@tempat_lahir", TextBox1_tLahir.Text)
            cmd.Parameters.AddWithValue("@ttl", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@gender", If(RadioButton2_p.Checked, "P", "L"))
            cmd.Parameters.AddWithValue("@alamat", TextBox3_alamat.Text)
            cmd.Parameters.AddWithValue("@keluhan", TextBox2_keluhan.Text)
            cmd.Parameters.AddWithValue("@poli_id", ComboBox1_poli.SelectedValue)
            cmd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells("id").Value)

            ' Log parameters for debugging
            Console.WriteLine("Executing query: " & query)
            Console.WriteLine("Parameters:")
            For Each param As MySqlParameter In cmd.Parameters
                Console.WriteLine(param.ParameterName & ": " & param.Value)
            Next

            ' Execute the query
            cmd.ExecuteNonQuery()

            ' Show success message and clear form
            MessageBox.Show("Data berhasil diperbarui!")
            ClearFormEdit()
            LoadData()
        Catch ex As MySqlException
            ' Show detailed error message
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Close the connection if it is open
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
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    'tombol cari'
    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            ' Get the search text
            Dim searchText As String = TextBox_Search.Text.Trim()

            ' Define the query with a parameter for the search text
            Dim query As String = "SELECT * FROM pasien WHERE nama LIKE @search OR id = @search"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", searchText)

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


    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        ClearFormTambah()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearFormEdit()
    End Sub

    Private Sub saveEditPasien_Click(sender As Object, e As EventArgs) Handles saveEditPasien.Click
        EditPatient()
    End Sub
    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        LoadData()
    End Sub
End Class