Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class LoginForm
    Friend Shared login_role As String
    Friend Shared login_user As String
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim command As New MySqlCommand("SELECT `users_username`, `users_password`, `users_role`, `users_status` FROM `users` WHERE `users_username` = @username AND `users_password` = @password", connection)
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = UsernameTextBox.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        For Each row In table.AsEnumerable
            login_role = (String.Format("{0}", row("users_role")))
            login_user = (String.Format("{0}", row("users_username")))
        Next
        If table.Rows.Count = 0 Then
            MessageBox.Show("Invalid Username Or Password")
        Else
            MessageBox.Show("WELCOME BACK " & login_role.ToUpper() & " " & login_user.ToUpper() & "!")
            Dim newForm As New User_Main()
            newForm.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub ShowPasswordCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If PasswordTextBox.UseSystemPasswordChar = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub
End Class