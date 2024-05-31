Imports MySql.Data.MySqlClient
Public Class medical_checkup
    Private connString As String = "server=localhost;userid=root;password=;database=datapasien;Convert Zero Datetime=True"
    Private conn As New MySqlConnection(connString)
    Private Sub medical_checkup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kode untuk memuat data dan mengatur lebar kolom DataGridView
        LoadData()

        ' Set the width of the columns
        DataGridView1.Columns("id").Width = 30
        DataGridView1.Columns("nama").Width = 150
        DataGridView1.Columns("gender").Width = 45
        DataGridView1.Columns("keluhan").Width = 150
        DataGridView1.Columns("diagnosa").Width = 150
    End Sub


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
        DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 12)

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
            Dim query As String = "SELECT id, nama, keluhan, diagnosa FROM pasien WHERE nama LIKE @search OR id LIKE @search"
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

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        SaveFileDialog1.Filter = "Excel Files (.xlsx)|.xlsx"

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim xlaapp As New Microsoft.Office.Interop.Excel.Application
            Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misvalue As Object = System.Reflection.Missing.Value

            Try
                ' Create a new workbook and worksheet
                xlworkbook = xlaapp.Workbooks.Add(misvalue)
                xlworksheet = CType(xlworkbook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

                ' Write column headers
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlworksheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                Next

                ' Write row data
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    For j As Integer = 0 To DataGridView1.ColumnCount - 1
                        xlworksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next

                ' Save the workbook
                xlworkbook.SaveAs(SaveFileDialog1.FileName)
                xlworkbook.Close()
                xlaapp.Quit()

                releaseObject(xlaapp)
                releaseObject(xlworkbook)
                releaseObject(xlworksheet)

                MessageBox.Show("Proses Export Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengekspor data: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class