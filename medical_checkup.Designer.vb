<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medical_checkup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medical_checkup))
        Me.textbox_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_cari = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_select = New Guna.UI2.WinForms.Guna2Button()
        Me.textbox_nama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textbox_keluhan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textbox_diagnosa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_simpan = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_print = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox_id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textbox_search
        '
        Me.textbox_search.BorderRadius = 8
        Me.textbox_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_search.DefaultText = ""
        Me.textbox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textbox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textbox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textbox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textbox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textbox_search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textbox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textbox_search.Location = New System.Drawing.Point(524, 122)
        Me.textbox_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textbox_search.Name = "textbox_search"
        Me.textbox_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textbox_search.PlaceholderText = "Cari..."
        Me.textbox_search.SelectedText = ""
        Me.textbox_search.Size = New System.Drawing.Size(229, 40)
        Me.textbox_search.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(524, 196)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(818, 282)
        Me.DataGridView1.TabIndex = 8
        '
        'btn_cari
        '
        Me.btn_cari.BorderRadius = 8
        Me.btn_cari.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cari.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari.ForeColor = System.Drawing.Color.White
        Me.btn_cari.Location = New System.Drawing.Point(769, 120)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(76, 45)
        Me.btn_cari.TabIndex = 9
        Me.btn_cari.Text = "Cari"
        '
        'btn_select
        '
        Me.btn_select.BorderRadius = 8
        Me.btn_select.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_select.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_select.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_select.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.Location = New System.Drawing.Point(1381, 196)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(118, 45)
        Me.btn_select.TabIndex = 10
        Me.btn_select.Text = "Select"
        '
        'textbox_nama
        '
        Me.textbox_nama.BorderRadius = 8
        Me.textbox_nama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_nama.DefaultText = ""
        Me.textbox_nama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textbox_nama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textbox_nama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textbox_nama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textbox_nama.Enabled = False
        Me.textbox_nama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textbox_nama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.textbox_nama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textbox_nama.Location = New System.Drawing.Point(524, 567)
        Me.textbox_nama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textbox_nama.Name = "textbox_nama"
        Me.textbox_nama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textbox_nama.PlaceholderText = ""
        Me.textbox_nama.SelectedText = ""
        Me.textbox_nama.Size = New System.Drawing.Size(311, 48)
        Me.textbox_nama.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(519, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 639)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 28)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Keluhan "
        '
        'textbox_keluhan
        '
        Me.textbox_keluhan.BorderRadius = 8
        Me.textbox_keluhan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_keluhan.DefaultText = ""
        Me.textbox_keluhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textbox_keluhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textbox_keluhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textbox_keluhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textbox_keluhan.Enabled = False
        Me.textbox_keluhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textbox_keluhan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_keluhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textbox_keluhan.Location = New System.Drawing.Point(524, 678)
        Me.textbox_keluhan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textbox_keluhan.Name = "textbox_keluhan"
        Me.textbox_keluhan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textbox_keluhan.PlaceholderText = ""
        Me.textbox_keluhan.SelectedText = ""
        Me.textbox_keluhan.Size = New System.Drawing.Size(311, 116)
        Me.textbox_keluhan.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1018, 524)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 28)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Diagnosa"
        '
        'textbox_diagnosa
        '
        Me.textbox_diagnosa.BorderRadius = 8
        Me.textbox_diagnosa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_diagnosa.DefaultText = ""
        Me.textbox_diagnosa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textbox_diagnosa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textbox_diagnosa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textbox_diagnosa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textbox_diagnosa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textbox_diagnosa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_diagnosa.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textbox_diagnosa.Location = New System.Drawing.Point(1023, 567)
        Me.textbox_diagnosa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textbox_diagnosa.Name = "textbox_diagnosa"
        Me.textbox_diagnosa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textbox_diagnosa.PlaceholderText = ""
        Me.textbox_diagnosa.SelectedText = ""
        Me.textbox_diagnosa.Size = New System.Drawing.Size(319, 150)
        Me.textbox_diagnosa.TabIndex = 15
        '
        'btn_simpan
        '
        Me.btn_simpan.BorderRadius = 8
        Me.btn_simpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_simpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_simpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_simpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_simpan.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_simpan.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.Location = New System.Drawing.Point(1203, 746)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(139, 48)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        '
        'btn_print
        '
        Me.btn_print.BorderRadius = 8
        Me.btn_print.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_print.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_print.FillColor = System.Drawing.Color.Blue
        Me.btn_print.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.Location = New System.Drawing.Point(1381, 433)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(118, 45)
        Me.btn_print.TabIndex = 19
        Me.btn_print.Text = "Print"
        '
        'TextBox_id
        '
        Me.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_id.DefaultText = ""
        Me.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_id.Location = New System.Drawing.Point(861, 567)
        Me.TextBox_id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_id.PlaceholderText = ""
        Me.TextBox_id.SelectedText = ""
        Me.TextBox_id.Size = New System.Drawing.Size(63, 48)
        Me.TextBox_id.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(874, 524)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 28)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ID"
        '
        'medical_checkup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_id)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textbox_diagnosa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textbox_keluhan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textbox_nama)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.textbox_search)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "medical_checkup"
        Me.Text = "f"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbox_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_cari As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_select As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textbox_nama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox_keluhan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_diagnosa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_simpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBox_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
