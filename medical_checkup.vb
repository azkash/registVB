Imports MySql.Data.MySqlClient
Public Class medical_checkup
    Private connString As String = "server=localhost;userid=root;password=;database=datapasien;Convert Zero Datetime=True"
    Private conn As New MySqlConnection(connString)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        LoadData()
    End Sub
    Private Sub ClearFormEdit()
        TextBox_id.Clear()
        textbox_nama.Text = ""
        textbox_keluhan.Text = ""
        textbox_diagnosa.Text = ""
    End Sub

    Private Sub LoadData()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim query As String = "SELECT id, nama, gender, keluhan, diagnosa FROM pasien"
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

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            ' Get the search text
            Dim searchText As String = textbox_search.Text.Trim()

            ' Define the query with a parameter for the search text
            Dim query As String = "SELECT id, nama, keluhan, diagnosa pasien WHERE nama LIKE @search OR id LIKE @search"
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

    'untuk select data'

    Private Sub medical_checkup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    'select'
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            TextBox_id.Text = selectedRow.Cells("id").Value.ToString()
            textbox_nama.Text = selectedRow.Cells("nama").Value.ToString()
            textbox_diagnosa.Text = selectedRow.Cells("diagnosa").Value.ToString()
            textbox_keluhan.Text = selectedRow.Cells("keluhan").Value.ToString()

            ' Pindah ke tab edit data
        Else
            MessageBox.Show("Pilih baris yang akan diedit terlebih dahulu.")
        End If
    End Sub

    'edit function'
    Private Sub edit_patient()
        Try
            ' Open the connection if it is closed
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Prepare the update query
            Dim query As String = "UPDATE pasien SET diagnosa = @diagnosa WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            ' Bind parameters
            cmd.Parameters.AddWithValue("@diagnosa", textbox_diagnosa.Text)
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
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        edit_patient()
        ClearFormEdit()
    End Sub
End Class