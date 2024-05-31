<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SlidingPanel = New System.Windows.Forms.Panel()
        Me.Button_queue = New System.Windows.Forms.Button()
        Me.Button_Logout = New System.Windows.Forms.Button()
        Me.Button_mcu = New System.Windows.Forms.Button()
        Me.Button_Menu = New System.Windows.Forms.Button()
        Me.Button_Utama = New System.Windows.Forms.Button()
        Me.ImagePanel = New System.Windows.Forms.Panel()
        Me.TextBox_LogedAs = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HeaderSlidingPanel = New System.Windows.Forms.Panel()
        Me.BtnSlidingMenu = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.HeaderMainPanel = New System.Windows.Forms.Panel()
        Me.queue = New System.Windows.Forms.Label()
        Me.Label_mcu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MySqlCommand1 = New MySqlConnector.MySqlCommand()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Guna2ContextMenuStrip2 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.SlidingPanel.SuspendLayout()
        Me.ImagePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderSlidingPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.HeaderMainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SlidingPanel
        '
        Me.SlidingPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SlidingPanel.Controls.Add(Me.Button_queue)
        Me.SlidingPanel.Controls.Add(Me.Button_Logout)
        Me.SlidingPanel.Controls.Add(Me.Button_mcu)
        Me.SlidingPanel.Controls.Add(Me.Button_Menu)
        Me.SlidingPanel.Controls.Add(Me.Button_Utama)
        Me.SlidingPanel.Controls.Add(Me.ImagePanel)
        Me.SlidingPanel.Controls.Add(Me.HeaderSlidingPanel)
        Me.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidingPanel.Location = New System.Drawing.Point(0, 0)
        Me.SlidingPanel.Name = "SlidingPanel"
        Me.SlidingPanel.Size = New System.Drawing.Size(250, 921)
        Me.SlidingPanel.TabIndex = 0
        '
        'Button_queue
        '
        Me.Button_queue.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_queue.FlatAppearance.BorderSize = 0
        Me.Button_queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_queue.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_queue.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_queue.Image = Global.tugasbesar1.My.Resources.Resources.icons8_queue_251
        Me.Button_queue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_queue.Location = New System.Drawing.Point(0, 476)
        Me.Button_queue.Name = "Button_queue"
        Me.Button_queue.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button_queue.Size = New System.Drawing.Size(250, 50)
        Me.Button_queue.TabIndex = 7
        Me.Button_queue.Text = "Queue"
        Me.Button_queue.UseVisualStyleBackColor = True
        '
        'Button_Logout
        '
        Me.Button_Logout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button_Logout.FlatAppearance.BorderSize = 0
        Me.Button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Logout.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Logout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Logout.Image = Global.tugasbesar1.My.Resources.Resources.icons8_logout_25
        Me.Button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Logout.Location = New System.Drawing.Point(0, 871)
        Me.Button_Logout.Name = "Button_Logout"
        Me.Button_Logout.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button_Logout.Size = New System.Drawing.Size(250, 50)
        Me.Button_Logout.TabIndex = 4
        Me.Button_Logout.Text = "Log out"
        Me.Button_Logout.UseVisualStyleBackColor = True
        '
        'Button_mcu
        '
        Me.Button_mcu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_mcu.FlatAppearance.BorderSize = 0
        Me.Button_mcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_mcu.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_mcu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_mcu.Image = Global.tugasbesar1.My.Resources.Resources.icons8_checkup_25_1_
        Me.Button_mcu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_mcu.Location = New System.Drawing.Point(0, 426)
        Me.Button_mcu.Name = "Button_mcu"
        Me.Button_mcu.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button_mcu.Size = New System.Drawing.Size(250, 50)
        Me.Button_mcu.TabIndex = 5
        Me.Button_mcu.Text = "MedCheck"
        Me.Button_mcu.UseVisualStyleBackColor = True
        '
        'Button_Menu
        '
        Me.Button_Menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Menu.FlatAppearance.BorderSize = 0
        Me.Button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Menu.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Menu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Menu.Image = Global.tugasbesar1.My.Resources.Resources.icons8_registration_25
        Me.Button_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Menu.Location = New System.Drawing.Point(0, 376)
        Me.Button_Menu.Name = "Button_Menu"
        Me.Button_Menu.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button_Menu.Size = New System.Drawing.Size(250, 50)
        Me.Button_Menu.TabIndex = 3
        Me.Button_Menu.Text = "Registrasi"
        Me.Button_Menu.UseVisualStyleBackColor = True
        '
        'Button_Utama
        '
        Me.Button_Utama.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Utama.FlatAppearance.BorderSize = 0
        Me.Button_Utama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Utama.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Utama.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Utama.Image = CType(resources.GetObject("Button_Utama.Image"), System.Drawing.Image)
        Me.Button_Utama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Utama.Location = New System.Drawing.Point(0, 326)
        Me.Button_Utama.Name = "Button_Utama"
        Me.Button_Utama.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button_Utama.Size = New System.Drawing.Size(250, 50)
        Me.Button_Utama.TabIndex = 2
        Me.Button_Utama.Text = "Dashboard"
        Me.Button_Utama.UseVisualStyleBackColor = True
        '
        'ImagePanel
        '
        Me.ImagePanel.Controls.Add(Me.TextBox_LogedAs)
        Me.ImagePanel.Controls.Add(Me.PictureBox1)
        Me.ImagePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImagePanel.Location = New System.Drawing.Point(0, 50)
        Me.ImagePanel.Name = "ImagePanel"
        Me.ImagePanel.Padding = New System.Windows.Forms.Padding(75)
        Me.ImagePanel.Size = New System.Drawing.Size(250, 276)
        Me.ImagePanel.TabIndex = 1
        '
        'TextBox_LogedAs
        '
        Me.TextBox_LogedAs.Animated = True
        Me.TextBox_LogedAs.AutoRoundedCorners = True
        Me.TextBox_LogedAs.BorderRadius = 23
        Me.TextBox_LogedAs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_LogedAs.DefaultText = ""
        Me.TextBox_LogedAs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_LogedAs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_LogedAs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_LogedAs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_LogedAs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_LogedAs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_LogedAs.ForeColor = System.Drawing.Color.Black
        Me.TextBox_LogedAs.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_LogedAs.Location = New System.Drawing.Point(33, 186)
        Me.TextBox_LogedAs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_LogedAs.Name = "TextBox_LogedAs"
        Me.TextBox_LogedAs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_LogedAs.PlaceholderText = ""
        Me.TextBox_LogedAs.ReadOnly = True
        Me.TextBox_LogedAs.SelectedText = ""
        Me.TextBox_LogedAs.Size = New System.Drawing.Size(183, 49)
        Me.TextBox_LogedAs.TabIndex = 1
        Me.TextBox_LogedAs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
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
        Me.BtnSlidingMenu.Image = CType(resources.GetObject("BtnSlidingMenu.Image"), System.Drawing.Image)
        Me.BtnSlidingMenu.Location = New System.Drawing.Point(160, 0)
        Me.BtnSlidingMenu.Name = "BtnSlidingMenu"
        Me.BtnSlidingMenu.Size = New System.Drawing.Size(90, 50)
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
        Me.MainPanel.Size = New System.Drawing.Size(1362, 921)
        Me.MainPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 871)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1362, 871)
        Me.Panel3.TabIndex = 2
        '
        'HeaderMainPanel
        '
        Me.HeaderMainPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.HeaderMainPanel.Controls.Add(Me.queue)
        Me.HeaderMainPanel.Controls.Add(Me.Label_mcu)
        Me.HeaderMainPanel.Controls.Add(Me.Label1)
        Me.HeaderMainPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMainPanel.Name = "HeaderMainPanel"
        Me.HeaderMainPanel.Padding = New System.Windows.Forms.Padding(12, 12, 2, 12)
        Me.HeaderMainPanel.Size = New System.Drawing.Size(1362, 50)
        Me.HeaderMainPanel.TabIndex = 0
        '
        'queue
        '
        Me.queue.AutoSize = True
        Me.queue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queue.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.queue.Location = New System.Drawing.Point(12, 12)
        Me.queue.Name = "queue"
        Me.queue.Size = New System.Drawing.Size(87, 25)
        Me.queue.TabIndex = 2
        Me.queue.Text = "QUEUE"
        Me.queue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.queue.Visible = False
        '
        'Label_mcu
        '
        Me.Label_mcu.AutoSize = True
        Me.Label_mcu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_mcu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mcu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label_mcu.Location = New System.Drawing.Point(12, 12)
        Me.Label_mcu.Name = "Label_mcu"
        Me.Label_mcu.Size = New System.Drawing.Size(219, 25)
        Me.Label_mcu.TabIndex = 1
        Me.Label_mcu.Text = "MEDICAL CHECKUP"
        Me.Label_mcu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_mcu.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRASI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CommandTimeout = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.Transaction = Nothing
        Me.MySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Guna2ContextMenuStrip2
        '
        Me.Guna2ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1612, 921)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SlidingPanel)
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN MENU - NEXT CENTRAL CLINICS"
        Me.SlidingPanel.ResumeLayout(False)
        Me.ImagePanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSlidingPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.HeaderMainPanel.ResumeLayout(False)
        Me.HeaderMainPanel.PerformLayout()
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
    Friend WithEvents Button_mcu As Button
    Friend WithEvents Label_mcu As Label
    Friend WithEvents queue As Label
    Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
    Friend WithEvents TextBox_LogedAs As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2ContextMenuStrip2 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Button_queue As Button
End Class
