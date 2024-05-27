Imports MySql.Data.MySqlClient

Public Class Form1
    Private connString As String = "server=localhost;userid=root;password=;database=datapasien"
    Private conn As New MySqlConnection(connString)

    Sub ClearTextMenuList()
        Button_Utama.Text = ""
        Button_Menu.Text = ""
        Button_Logout.Text = ""
    End Sub

    Sub SetTextMenuList()
        Button_Utama.Text = "Menu"
        Button_Menu.Text = "Mail"
        Button_Logout.Text = "Logout"
    End Sub

    Dim slidingMenu As String = "close"
    Private Sub BtnSlidingMenu_Click(sender As Object, e As EventArgs) Handles BtnSlidingMenu.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If slidingMenu = "open" Then
            SlidingPanel.Width += 25
            ImagePanel.Width += 25
            ImagePanel.Height += 25

            If SlidingPanel.Width >= 200 Then
                SetTextMenuList()
                ImagePanel.Visible = True
                slidingMenu = "close"
                Timer1.Stop()
            End If
        Else
            SlidingPanel.Width -= 25
            ImagePanel.Width -= 25
            ImagePanel.Height -= 25
            If SlidingPanel.Width <= 50 Then
                ClearTextMenuList()
                ImagePanel.Visible = False
                slidingMenu = "open"
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint
    End Sub

    Private Sub HeaderMainPanel_Paint(sender As Object, e As PaintEventArgs) Handles HeaderMainPanel.Paint
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        ' Implement search functionality
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_L.CheckedChanged
    End Sub

    ' side bar menu
    Private Sub Button_Utama_Click(sender As Object, e As EventArgs) Handles Button_Utama.Click
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Button_Menu.Click
    End Sub

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
    End Sub

    ' page lihat data
    Private Sub TextBox_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Search.TextChanged
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
    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Button_Menu.Click
        switchPanel(registrasi)
        Dock = DockStyle.Fill
    End Sub

    Private Sub Button_Utama_Click(sender As Object, e As EventArgs) Handles Button_Utama.Click
        'switchPanel(dashboard)'
        Dock = DockStyle.Fill
    End Sub
End Class
