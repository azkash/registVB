<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.SlidingPanel = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.HeaderMainPanel = New System.Windows.Forms.Panel()
        Me.HeaderSlidingPanel = New System.Windows.Forms.Panel()
        Me.ImagePanel = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSlidingMenu = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SlidingPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.HeaderSlidingPanel.SuspendLayout()
        Me.ImagePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SlidingPanel
        '
        Me.SlidingPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SlidingPanel.Controls.Add(Me.Button3)
        Me.SlidingPanel.Controls.Add(Me.Button2)
        Me.SlidingPanel.Controls.Add(Me.Button1)
        Me.SlidingPanel.Controls.Add(Me.ImagePanel)
        Me.SlidingPanel.Controls.Add(Me.HeaderSlidingPanel)
        Me.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidingPanel.Location = New System.Drawing.Point(0, 0)
        Me.SlidingPanel.Name = "SlidingPanel"
        Me.SlidingPanel.Size = New System.Drawing.Size(250, 636)
        Me.SlidingPanel.TabIndex = 0
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.HeaderMainPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(250, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(655, 636)
        Me.MainPanel.TabIndex = 1
        '
        'HeaderMainPanel
        '
        Me.HeaderMainPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.HeaderMainPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMainPanel.Name = "HeaderMainPanel"
        Me.HeaderMainPanel.Size = New System.Drawing.Size(655, 50)
        Me.HeaderMainPanel.TabIndex = 0
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
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.Image = Global.tugasbesar1.My.Resources.Resources.icons8_power_25
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 400)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 50)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Image = Global.tugasbesar1.My.Resources.Resources.icons8_mail_25
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(250, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Image = Global.tugasbesar1.My.Resources.Resources.icons8_home_25
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 636)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SlidingPanel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SlidingPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.HeaderSlidingPanel.ResumeLayout(False)
        Me.ImagePanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SlidingPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents HeaderSlidingPanel As Panel
    Friend WithEvents BtnSlidingMenu As Button
    Friend WithEvents HeaderMainPanel As Panel
    Friend WithEvents ImagePanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
End Class
