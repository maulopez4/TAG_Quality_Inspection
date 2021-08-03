Public Class User_Main
    Private Sub AddNewDefectButton_Click(sender As Object, e As EventArgs) Handles AddNewDefectButton.Click
        Dim newForm As New AddEntry()
        newForm.Show()
    End Sub
    Private Sub User_Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
    Private Sub User_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim login_role As String
        Dim login_user As String
        login_role = LoginForm.login_role
        Select Case login_role
            Case "USER"
                UserGroupBox.Visible = True
                SuperGroupBox.Visible = False
                AdminGroupBox.Visible = False
            Case "SUPER"
                UserGroupBox.Visible = True
                SuperGroupBox.Visible = True
                AdminGroupBox.Visible = False
            Case "ADMIN"
                UserGroupBox.Visible = True
                SuperGroupBox.Visible = True
                AdminGroupBox.Visible = True
        End Select

        login_user = LoginForm.login_user
        CurrentUserTextBox.Text = "USER/ROLE: " & login_user.ToUpper & "/" & login_role.ToUpper
    End Sub
    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        Dim newForm As New AddUser()
        newForm.Show()
    End Sub
End Class