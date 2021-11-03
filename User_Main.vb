Public Class User_Main
    Private Sub AddNewDefectButton_Click(sender As Object, e As EventArgs) Handles User_AddNewEntryButton.Click
        Dim newForm As New AddEntry()
        newForm.Show()
    End Sub
    Private Sub User_Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
    Private Sub User_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim login_role As String = LoginForm.login_role
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

        CurrentUserTextBox.Text = "USER/ROLE: " & LoginForm.login_user.ToUpper & "/" & login_role.ToUpper
    End Sub
    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles Admin_AddEditUserButton.Click, Super_AddEditUserButton.Click
        Dim newForm As New AddEditUser()
        newForm.Show()
    End Sub

    Private Sub AddModelButton_Click(sender As Object, e As EventArgs) Handles Super_AddModelButton.Click, Admin_AddModelButton.Click
        Dim newForm As New AddEditModel()
        newForm.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim newForm As New SearchEntry()
        newForm.Show()
    End Sub

    Private Sub Export_Button_Click(sender As Object, e As EventArgs) Handles Export_Button.Click
        Dim newForm As New Export_Data()
        newForm.Show()
    End Sub

    Private Sub Super_AddColorButton_Click(sender As Object, e As EventArgs) Handles Super_AddColorButton.Click, Admin_AddColorButton.Click
        Dim newForm As New AddPaintcode()
        newForm.Show()
    End Sub
End Class