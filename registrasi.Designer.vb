<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registrasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_Print = New Guna.UI2.WinForms.Guna2Button()
        Me.Button_Delete = New Guna.UI2.WinForms.Guna2Button()
        Me.Button_Edit = New Guna.UI2.WinForms.Guna2Button()
        Me.Button_Search = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox_Search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tempat_lahir = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tglLahir = New System.Windows.Forms.DateTimePicker()
        Me.poli_id = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.keluhan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_L = New System.Windows.Forms.RadioButton()
        Me.RadioButton_P = New System.Windows.Forms.RadioButton()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.label_id = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1_tLahir = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1_poli = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2_keluhan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.saveEditPasien = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2_jk = New System.Windows.Forms.GroupBox()
        Me.RadioButton1_L = New System.Windows.Forms.RadioButton()
        Me.RadioButton2_p = New System.Windows.Forms.RadioButton()
        Me.TextBox3_alamat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox4_nama = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2_jk.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1920, 1080)
        Me.TabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControl.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabControl.TabIndex = 3
        Me.TabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button_Print)
        Me.TabPage1.Controls.Add(Me.Button_Delete)
        Me.TabPage1.Controls.Add(Me.Button_Edit)
        Me.TabPage1.Controls.Add(Me.Button_Search)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.TextBox_Search)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1732, 1072)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lihat data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button_Print
        '
        Me.Button_Print.BorderRadius = 6
        Me.Button_Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button_Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button_Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button_Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button_Print.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button_Print.ForeColor = System.Drawing.Color.White
        Me.Button_Print.Location = New System.Drawing.Point(978, 129)
        Me.Button_Print.Name = "Button_Print"
        Me.Button_Print.Size = New System.Drawing.Size(86, 35)
        Me.Button_Print.TabIndex = 6
        Me.Button_Print.Text = "Print"
        '
        'Button_Delete
        '
        Me.Button_Delete.BorderRadius = 6
        Me.Button_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button_Delete.FillColor = System.Drawing.Color.Red
        Me.Button_Delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button_Delete.ForeColor = System.Drawing.Color.White
        Me.Button_Delete.Location = New System.Drawing.Point(978, 170)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(86, 35)
        Me.Button_Delete.TabIndex = 5
        Me.Button_Delete.Text = "Delete"
        '
        'Button_Edit
        '
        Me.Button_Edit.BorderRadius = 6
        Me.Button_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button_Edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button_Edit.ForeColor = System.Drawing.Color.White
        Me.Button_Edit.Location = New System.Drawing.Point(978, 88)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(86, 35)
        Me.Button_Edit.TabIndex = 4
        Me.Button_Edit.Text = "Edit"
        '
        'Button_Search
        '
        Me.Button_Search.BorderRadius = 6
        Me.Button_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button_Search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button_Search.ForeColor = System.Drawing.Color.White
        Me.Button_Search.Location = New System.Drawing.Point(474, 46)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(86, 35)
        Me.Button_Search.TabIndex = 3
        Me.Button_Search.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(950, 412)
        Me.DataGridView1.TabIndex = 2
        '
        'TextBox_Search
        '
        Me.TextBox_Search.BackColor = System.Drawing.Color.White
        Me.TextBox_Search.BorderRadius = 7
        Me.TextBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_Search.DefaultText = ""
        Me.TextBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_Search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_Search.Location = New System.Drawing.Point(22, 46)
        Me.TextBox_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox_Search.Name = "TextBox_Search"
        Me.TextBox_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_Search.PlaceholderText = ""
        Me.TextBox_Search.SelectedText = ""
        Me.TextBox_Search.Size = New System.Drawing.Size(446, 35)
        Me.TextBox_Search.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search For"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tempat_lahir)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.tglLahir)
        Me.TabPage2.Controls.Add(Me.poli_id)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.keluhan)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.Button_Cancel)
        Me.TabPage2.Controls.Add(Me.Button_Save)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.TextBox_Alamat)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TextBox_Nama)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1732, 1072)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tambah data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tempat_lahir
        '
        Me.tempat_lahir.Location = New System.Drawing.Point(22, 278)
        Me.tempat_lahir.Name = "tempat_lahir"
        Me.tempat_lahir.Size = New System.Drawing.Size(200, 22)
        Me.tempat_lahir.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Tempat lahir"
        '
        'tglLahir
        '
        Me.tglLahir.Location = New System.Drawing.Point(22, 217)
        Me.tglLahir.Name = "tglLahir"
        Me.tglLahir.Size = New System.Drawing.Size(200, 22)
        Me.tglLahir.TabIndex = 17
        '
        'poli_id
        '
        Me.poli_id.FormattingEnabled = True
        Me.poli_id.Location = New System.Drawing.Point(296, 130)
        Me.poli_id.Name = "poli_id"
        Me.poli_id.Size = New System.Drawing.Size(277, 24)
        Me.poli_id.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(292, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Keluhan"
        '
        'keluhan
        '
        Me.keluhan.Location = New System.Drawing.Point(296, 205)
        Me.keluhan.Multiline = True
        Me.keluhan.Name = "keluhan"
        Me.keluhan.Size = New System.Drawing.Size(280, 80)
        Me.keluhan.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Poli"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(22, 395)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1000, 412)
        Me.DataGridView2.TabIndex = 11
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(450, 300)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(123, 30)
        Me.Button_Cancel.TabIndex = 10
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(296, 300)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(123, 30)
        Me.Button_Save.TabIndex = 9
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tanggal lahir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_L)
        Me.GroupBox1.Controls.Add(Me.RadioButton_P)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'RadioButton_L
        '
        Me.RadioButton_L.AutoSize = True
        Me.RadioButton_L.Location = New System.Drawing.Point(17, 29)
        Me.RadioButton_L.Name = "RadioButton_L"
        Me.RadioButton_L.Size = New System.Drawing.Size(94, 27)
        Me.RadioButton_L.TabIndex = 4
        Me.RadioButton_L.TabStop = True
        Me.RadioButton_L.Text = "Laki-laki"
        Me.RadioButton_L.UseVisualStyleBackColor = True
        '
        'RadioButton_P
        '
        Me.RadioButton_P.AutoSize = True
        Me.RadioButton_P.Location = New System.Drawing.Point(17, 56)
        Me.RadioButton_P.Name = "RadioButton_P"
        Me.RadioButton_P.Size = New System.Drawing.Size(118, 27)
        Me.RadioButton_P.TabIndex = 5
        Me.RadioButton_P.TabStop = True
        Me.RadioButton_P.Text = "Perempuan"
        Me.RadioButton_P.UseVisualStyleBackColor = True
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.Location = New System.Drawing.Point(293, 38)
        Me.TextBox_Alamat.Multiline = True
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(280, 62)
        Me.TextBox_Alamat.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(289, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alamat"
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Location = New System.Drawing.Point(22, 40)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(200, 22)
        Me.TextBox_Nama.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.label_id)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.TextBox1_tLahir)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.ComboBox1_poli)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.TextBox2_keluhan)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.saveEditPasien)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.GroupBox2_jk)
        Me.TabPage3.Controls.Add(Me.TextBox3_alamat)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.TextBox4_nama)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1732, 1072)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Edit data"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'label_id
        '
        Me.label_id.Enabled = False
        Me.label_id.Location = New System.Drawing.Point(22, 41)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(100, 22)
        Me.label_id.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 17)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Label_id"
        '
        'TextBox1_tLahir
        '
        Me.TextBox1_tLahir.Location = New System.Drawing.Point(22, 333)
        Me.TextBox1_tLahir.Name = "TextBox1_tLahir"
        Me.TextBox1_tLahir.Size = New System.Drawing.Size(200, 22)
        Me.TextBox1_tLahir.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Tempat lahir"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(22, 272)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 32
        '
        'ComboBox1_poli
        '
        Me.ComboBox1_poli.FormattingEnabled = True
        Me.ComboBox1_poli.Location = New System.Drawing.Point(290, 133)
        Me.ComboBox1_poli.Name = "ComboBox1_poli"
        Me.ComboBox1_poli.Size = New System.Drawing.Size(277, 24)
        Me.ComboBox1_poli.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(286, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Keluhan"
        '
        'TextBox2_keluhan
        '
        Me.TextBox2_keluhan.Location = New System.Drawing.Point(290, 208)
        Me.TextBox2_keluhan.Multiline = True
        Me.TextBox2_keluhan.Name = "TextBox2_keluhan"
        Me.TextBox2_keluhan.Size = New System.Drawing.Size(280, 80)
        Me.TextBox2_keluhan.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(283, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 23)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Poli"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(444, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 30)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'saveEditPasien
        '
        Me.saveEditPasien.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveEditPasien.Location = New System.Drawing.Point(290, 303)
        Me.saveEditPasien.Name = "saveEditPasien"
        Me.saveEditPasien.Size = New System.Drawing.Size(123, 30)
        Me.saveEditPasien.TabIndex = 26
        Me.saveEditPasien.Text = "Save"
        Me.saveEditPasien.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 241)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 23)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Tanggal lahir"
        '
        'GroupBox2_jk
        '
        Me.GroupBox2_jk.Controls.Add(Me.RadioButton1_L)
        Me.GroupBox2_jk.Controls.Add(Me.RadioButton2_p)
        Me.GroupBox2_jk.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2_jk.Location = New System.Drawing.Point(22, 129)
        Me.GroupBox2_jk.Name = "GroupBox2_jk"
        Me.GroupBox2_jk.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2_jk.TabIndex = 24
        Me.GroupBox2_jk.TabStop = False
        Me.GroupBox2_jk.Text = "Jenis Kelamin"
        '
        'RadioButton1_L
        '
        Me.RadioButton1_L.AutoSize = True
        Me.RadioButton1_L.Location = New System.Drawing.Point(17, 29)
        Me.RadioButton1_L.Name = "RadioButton1_L"
        Me.RadioButton1_L.Size = New System.Drawing.Size(94, 27)
        Me.RadioButton1_L.TabIndex = 4
        Me.RadioButton1_L.TabStop = True
        Me.RadioButton1_L.Text = "Laki-laki"
        Me.RadioButton1_L.UseVisualStyleBackColor = True
        '
        'RadioButton2_p
        '
        Me.RadioButton2_p.AutoSize = True
        Me.RadioButton2_p.Location = New System.Drawing.Point(17, 56)
        Me.RadioButton2_p.Name = "RadioButton2_p"
        Me.RadioButton2_p.Size = New System.Drawing.Size(118, 27)
        Me.RadioButton2_p.TabIndex = 5
        Me.RadioButton2_p.TabStop = True
        Me.RadioButton2_p.Text = "Perempuan"
        Me.RadioButton2_p.UseVisualStyleBackColor = True
        '
        'TextBox3_alamat
        '
        Me.TextBox3_alamat.Location = New System.Drawing.Point(287, 41)
        Me.TextBox3_alamat.Multiline = True
        Me.TextBox3_alamat.Name = "TextBox3_alamat"
        Me.TextBox3_alamat.Size = New System.Drawing.Size(280, 62)
        Me.TextBox3_alamat.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(283, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Alamat"
        '
        'TextBox4_nama
        '
        Me.TextBox4_nama.Location = New System.Drawing.Point(22, 95)
        Me.TextBox4_nama.Name = "TextBox4_nama"
        Me.TextBox4_nama.Size = New System.Drawing.Size(200, 22)
        Me.TextBox4_nama.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 23)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Nama"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1920, 1080)
        Me.Panel1.TabIndex = 4
        '
        'registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registrasi"
        Me.Text = "registrasi"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2_jk.ResumeLayout(False)
        Me.GroupBox2_jk.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As Guna.UI2.WinForms.Guna2TabControl
    Public WithEvents TabPage1 As TabPage
    Friend WithEvents Button_Print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button_Delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button_Edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button_Search As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox_Search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_L As RadioButton
    Friend WithEvents RadioButton_P As RadioButton
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents keluhan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents poli_id As ComboBox
    Friend WithEvents tglLahir As DateTimePicker
    Friend WithEvents tempat_lahir As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox1_tLahir As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1_poli As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2_keluhan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents saveEditPasien As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2_jk As GroupBox
    Friend WithEvents RadioButton1_L As RadioButton
    Friend WithEvents RadioButton2_p As RadioButton
    Friend WithEvents TextBox3_alamat As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4_nama As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents label_id As TextBox
    Friend WithEvents Label14 As Label
End Class
