Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_LogedAs.Text = "" & MenuLogin.LoggedInUser
    End Sub
End Class