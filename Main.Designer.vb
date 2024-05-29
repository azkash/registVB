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
        Me.HeaderMainPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.SlidingPanel.Controls.Add(Me.Button_Logout)
        Me.SlidingPanel.Controls.Add(Me.Button_Menu)
        Me.SlidingPanel.Controls.Add(Me.Button_Utama)
        Me.SlidingPanel.Controls.Add(Me.ImagePanel)
        Me.SlidingPanel.Controls.Add(Me.HeaderSlidingPanel)
        Me.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidingPanel.Location = New System.Drawing.Point(0, 0)
        Me.SlidingPanel.Name = "SlidingPanel"
        Me.SlidingPanel.Size = New System.Drawing.Size(250, 1033)
        Me.SlidingPanel.TabIndex = 0
        '
        'Button_Logout
        '
        Me.Button_Logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Logout.FlatAppearance.BorderSize = 0
        Me.Button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Logout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Logout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Logout.Image = CType(resources.GetObject("Button_Logout.Image"), System.Drawing.Image)
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
        Me.Button_Menu.Image = CType(resources.GetObject("Button_Menu.Image"), System.Drawing.Image)
        Me.Button_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Menu.Location = New System.Drawing.Point(0, 350)
        Me.Button_Menu.Name = "Button_Menu"
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
        Me.Button_Utama.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Utama.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Utama.Image = CType(resources.GetObject("Button_Utama.Image"), System.Drawing.Image)
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
        Me.MainPanel.Size = New System.Drawing.Size(1058, 1033)
        Me.MainPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 983)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1058, 983)
        Me.Panel3.TabIndex = 2
        '
        'HeaderMainPanel
        '
        Me.HeaderMainPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.HeaderMainPanel.Controls.Add(Me.Label1)
        Me.HeaderMainPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMainPanel.Name = "HeaderMainPanel"
        Me.HeaderMainPanel.Padding = New System.Windows.Forms.Padding(12, 12, 2, 12)
        Me.HeaderMainPanel.Size = New System.Drawing.Size(1058, 50)
        Me.HeaderMainPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 12)
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1308, 1033)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SlidingPanel)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
End Class
