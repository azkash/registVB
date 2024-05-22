Public Class Form1
    Sub ClearTextMenuList()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
    End Sub
    Sub SetTextMenuList()
        Button1.Text = "Menu"
        Button2.Text = "Mail"
        Button3.Text = "Logout"
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
End Class
