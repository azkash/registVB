<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrasi
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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
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
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(1920, 1080)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 0
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
        Me.Button_Print.Location = New System.Drawing.Point(1010, 128)
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
        Me.Button_Delete.Location = New System.Drawing.Point(1010, 169)
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
        Me.Button_Edit.Location = New System.Drawing.Point(1010, 87)
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
        Me.DataGridView1.Location = New System.Drawing.Point(22, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(982, 555)
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
        'registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registrasi"
        Me.Text = "Form2"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents TextBox_TTL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_L As RadioButton
    Friend WithEvents RadioButton_P As RadioButton
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents Label3 As Label
End Class
