﻿Imports MySql.Data.MySqlClient

Public Class Form1
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
    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Button_Menu.Click
        Label1.Visible = True
        switchPanel(registrasi)
        Dock = DockStyle.Fill
    End Sub

    Private Sub Button_Utama_Click(sender As Object, e As EventArgs) Handles Button_Utama.Click
        Label1.Visible = False
        switchPanel(dashboard)
        Dock = DockStyle.Fill
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
