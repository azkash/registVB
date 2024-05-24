<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.SlidingPanel = New System.Windows.Forms.Panel()
        Me.Button_Logout = New System.Windows.Forms.Button()
        Me.Button_Menu = New System.Windows.Forms.Button()
        Me.Button_Utama = New System.Windows.Forms.Button()
        Me.ImagePanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HeaderSlidingPanel = New System.Windows.Forms.Panel()
        Me.BtnSlidingMenu = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.TextBox_TTL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_L = New System.Windows.Forms.RadioButton()
        Me.RadioButton_P = New System.Windows.Forms.RadioButton()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeaderMainPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SlidingPanel.SuspendLayout()
        Me.ImagePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderSlidingPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.HeaderMainPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SlidingPanel
        '
        Me.SlidingPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SlidingPanel.Controls.Add(Me.Button_Logout)
        Me.SlidingPanel.Controls.Add(Me.Button_Menu)
        Me.SlidingPanel.Controls.Add(Me.Button_Utama)
        Me.SlidingPanel.Controls.Add(Me.ImagePanel)
        Me.SlidingPanel.Controls.Add(Me.HeaderSlidingPanel)
        Me.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidingPanel.Location = New System.Drawing.Point(0, 0)
        Me.SlidingPanel.Name = "SlidingPanel"
        Me.SlidingPanel.Size = New System.Drawing.Size(250, 636)
        Me.SlidingPanel.TabIndex = 0
        '
        'Button_Logout
        '
        Me.Button_Logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Logout.FlatAppearance.BorderSize = 0
        Me.Button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Logout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Logout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Logout.Image = Global.tugasbesar1.My.Resources.Resources.icons8_power_25
        Me.Button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Logout.Location = New System.Drawing.Point(0, 400)
        Me.Button_Logout.Name = "Button_Logout"
        Me.Button_Logout.Size = New System.Drawing.Size(250, 50)
        Me.Button_Logout.TabIndex = 4
        Me.Button_Logout.Text = "Log out"
        Me.Button_Logout.UseVisualStyleBackColor = True
        '
        'Button_Menu
        '
        Me.Button_Menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Menu.FlatAppearance.BorderSize = 0
        Me.Button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Menu.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Menu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Menu.Image = Global.tugasbesar1.My.Resources.Resources.icons8_mail_25
        Me.Button_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Menu.Location = New System.Drawing.Point(0, 350)
        Me.Button_Menu.Name = "Button_Menu"
        Me.Button_Menu.Size = New System.Drawing.Size(250, 50)
        Me.Button_Menu.TabIndex = 3
        Me.Button_Menu.Text = "Menu"
        Me.Button_Menu.UseVisualStyleBackColor = True
        '
        'Button_Utama
        '
        Me.Button_Utama.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Utama.FlatAppearance.BorderSize = 0
        Me.Button_Utama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Utama.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Utama.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Utama.Image = Global.tugasbesar1.My.Resources.Resources.icons8_home_25
        Me.Button_Utama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Utama.Location = New System.Drawing.Point(0, 300)
        Me.Button_Utama.Name = "Button_Utama"
        Me.Button_Utama.Size = New System.Drawing.Size(250, 50)
        Me.Button_Utama.TabIndex = 2
        Me.Button_Utama.Text = "Utama"
        Me.Button_Utama.UseVisualStyleBackColor = True
        '
        'ImagePanel
        '
        Me.ImagePanel.Controls.Add(Me.PictureBox1)
        Me.ImagePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePanel.Location = New System.Drawing.Point(0, 50)
        Me.ImagePanel.Name = "ImagePanel"
        Me.ImagePanel.Padding = New System.Windows.Forms.Padding(75)
        Me.ImagePanel.Size = New System.Drawing.Size(250, 250)
        Me.ImagePanel.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tugasbesar1.My.Resources.Resources.icons8_user_75
        Me.PictureBox1.Location = New System.Drawing.Point(78, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'HeaderSlidingPanel
        '
        Me.HeaderSlidingPanel.BackColor = System.Drawing.Color.DarkCyan
        Me.HeaderSlidingPanel.Controls.Add(Me.BtnSlidingMenu)
        Me.HeaderSlidingPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderSlidingPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderSlidingPanel.Name = "HeaderSlidingPanel"
        Me.HeaderSlidingPanel.Size = New System.Drawing.Size(250, 50)
        Me.HeaderSlidingPanel.TabIndex = 0
        '
        'BtnSlidingMenu
        '
        Me.BtnSlidingMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSlidingMenu.FlatAppearance.BorderSize = 0
        Me.BtnSlidingMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSlidingMenu.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSlidingMenu.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnSlidingMenu.Image = Global.tugasbesar1.My.Resources.Resources.icons8_menu_25_1_
        Me.BtnSlidingMenu.Location = New System.Drawing.Point(200, 0)
        Me.BtnSlidingMenu.Name = "BtnSlidingMenu"
        Me.BtnSlidingMenu.Size = New System.Drawing.Size(50, 50)
        Me.BtnSlidingMenu.TabIndex = 0
        Me.BtnSlidingMenu.UseVisualStyleBackColor = True
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.HeaderMainPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(250, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(898, 636)
        Me.MainPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(898, 586)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.TabControl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(898, 586)
        Me.Panel3.TabIndex = 2
        '
        'TabControl
        '
        Me.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(898, 586)
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
        Me.TabControl.TabIndex = 2
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
        Me.TabPage1.Size = New System.Drawing.Size(710, 578)
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
        Me.Button_Print.Location = New System.Drawing.Point(566, 129)
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
        Me.Button_Delete.Location = New System.Drawing.Point(566, 170)
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
        Me.Button_Edit.Location = New System.Drawing.Point(566, 88)
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
        Me.DataGridView1.Size = New System.Drawing.Size(538, 412)
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
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.Button_Cancel)
        Me.TabPage2.Controls.Add(Me.Button_Save)
        Me.TabPage2.Controls.Add(Me.TextBox_TTL)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.TextBox_Alamat)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TextBox_Nama)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(710, 578)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tambah data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(241, 216)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(123, 30)
        Me.Button_Cancel.TabIndex = 10
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(87, 216)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(123, 30)
        Me.Button_Save.TabIndex = 9
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'TextBox_TTL
        '
        Me.TextBox_TTL.Location = New System.Drawing.Point(241, 40)
        Me.TextBox_TTL.Name = "TextBox_TTL"
        Me.TextBox_TTL.Size = New System.Drawing.Size(200, 22)
        Me.TextBox_TTL.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(237, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tempat, Tanggal lahir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_L)
        Me.GroupBox1.Controls.Add(Me.RadioButton_P)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 74)
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
        Me.TextBox_Alamat.Location = New System.Drawing.Point(241, 112)
        Me.TextBox_Alamat.Multiline = True
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(200, 62)
        Me.TextBox_Alamat.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alamat"
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Location = New System.Drawing.Point(10, 40)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(200, 22)
        Me.TextBox_Nama.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama"
        '
        'HeaderMainPanel
        '
        Me.HeaderMainPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.HeaderMainPanel.Controls.Add(Me.Label1)
        Me.HeaderMainPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMainPanel.Name = "HeaderMainPanel"
        Me.HeaderMainPanel.Size = New System.Drawing.Size(898, 50)
        Me.HeaderMainPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRASI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(10, 272)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(538, 274)
        Me.DataGridView2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1148, 636)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SlidingPanel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SlidingPanel.ResumeLayout(False)
        Me.ImagePanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSlidingPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.HeaderMainPanel.ResumeLayout(False)
        Me.HeaderMainPanel.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SlidingPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents HeaderSlidingPanel As Panel
    Friend WithEvents BtnSlidingMenu As Button
    Friend WithEvents HeaderMainPanel As Panel
    Friend WithEvents ImagePanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_Utama As Button
    Friend WithEvents Button_Logout As Button
    Friend WithEvents Button_Menu As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage2 As TabPage
    Public WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox_Search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Search As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button_Print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button_Delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button_Edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_L As RadioButton
    Friend WithEvents RadioButton_P As RadioButton
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents TextBox_TTL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
