Imports MySql.Data.MySqlClient

Public Class queue_form
    Private lastProcessedId As Integer = -1 ' Variable to keep track of the last processed ID
    ' Deklarasikan sebuah instance dari Form_TampilanAntrian
    Private formAntrian As Form_TampilanAntrian
    Public Sub UpdateTampilanAntrian(id As String, namaPoli As String, namaPasien As String, dokter As String)
        If formAntrian IsNot Nothing Then
            formAntrian.UpdateAntrian(id, namaPoli, namaPasien, dokter)
        End If
    End Sub

    Private Sub queue_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQueue()
        UpdateNextButtonState()
        Guna2DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 12)
    End Sub

    Private Sub LoadQueue()
        Try
            Dim dbConnection As New DatabaseConnection()
            Using conn As MySqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT pasien.id, pasien.nama, poli.nama_poli, poli.dokter " &
                                      "FROM pasien " &
                                      "JOIN poli ON pasien.poli_id = poli.id " &
                                      "WHERE pasien.id > @lastProcessedId " &  ' Fetch records with id greater than the last processed id
                                      "ORDER BY pasien.id ASC"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@lastProcessedId", lastProcessedId)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        Guna2DataGridView1.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat memuat data pasien: " & ex.Message)
        End Try
        UpdateNextButtonState()
    End Sub
    Public Sub UpdateAntrian()
        ' Lakukan sesuatu untuk memperbarui informasi antrian di form ini
        ' Contoh:
        LoadQueue()
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        CommitDataGridViewEdits() ' Commit any uncommitted edits before proceeding

        If Guna2DataGridView1.Rows.Count > 0 Then
            Dim currentRow = Guna2DataGridView1.Rows(0)
            If currentRow IsNot Nothing AndAlso currentRow.Cells("id").Value IsNot Nothing Then
                Dim id As String = currentRow.Cells("id").Value.ToString()
                Dim namaPoli As String = currentRow.Cells("nama_poli").Value.ToString()
                Dim namaPasien As String = currentRow.Cells("nama").Value.ToString()
                Dim dokter As String = currentRow.Cells("dokter").Value.ToString()

                ' Update tampilan antrian di form ini
                Label_Antrian.Text = id
                Label_Poli.Text = namaPoli
                Label_NamaPasien.Text = namaPasien
                Label_Dokter.Text = dokter

                ' Update variabel lastProcessedId
                lastProcessedId = CInt(id)

                ' Hapus baris pertama dari DataGridView
                Guna2DataGridView1.Rows.RemoveAt(0)
            End If
        Else
            MessageBox.Show("Tidak ada antrian.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        UpdateNextButtonState()

        ' Kirim informasi antrian ke Form_TampilanAntrian
        If formAntrian IsNot Nothing Then
            formAntrian.UpdateAntrian(Label_Antrian.Text, Label_Poli.Text, Label_NamaPasien.Text, Label_Dokter.Text)
        End If
    End Sub

    ' Method ini akan dipanggil saat form Form_TampilanAntrian ditutup
    Public Sub SetFormAntrian(form As Form_TampilanAntrian)
        formAntrian = form
    End Sub

    Private Sub Button_RefreshAntrian_Click(sender As Object, e As EventArgs) Handles Button_RefreshAntrian.Click
        LoadQueue()
    End Sub

    Private Sub UpdateNextButtonState()
        Button_Next.Enabled = Guna2DataGridView1.Rows.Count > 0
    End Sub

    Private Sub CommitDataGridViewEdits()
        ' Ensure that any edits are committed before removing rows
        If Guna2DataGridView1.IsCurrentCellInEditMode Then
            Guna2DataGridView1.EndEdit()
        End If
        If Guna2DataGridView1.IsCurrentRowDirty Then
            Guna2DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub Button_TampilAntrian_Click(sender As Object, e As EventArgs) Handles Button_TampilAntrian.Click
        ' Buat instance dari form Form_TampilanAntrian
        Dim formAntrian As New Form_TampilanAntrian()

        ' Atur properti form jika diperlukan
        formAntrian.StartPosition = FormStartPosition.CenterScreen

        ' Simpan referensi ke Form_TampilanAntrian
        SetFormAntrian(formAntrian)

        ' Tampilkan form sebagai popup
        formAntrian.Show() ' Atau gunakan formAntrian.ShowDialog() jika ingin modal dialog
    End Sub

End Class
