Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class LoginForm
    Dim connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Dim connection As New MySqlConnection(connection_string)
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim command As New MySqlCommand("SELECT `user_name`, `password`, `role`, `user_status` FROM `users` WHERE `user_name` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = UsernameTextBox.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text


        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim login_name As String = UsernameTextBox.Text
        Dim login_role As String
        RoleComboBox.DataSource = table
        RoleComboBox.ValueMember = "role"
        RoleComboBox.DisplayMember = "role"
        login_role = RoleComboBox.DisplayMember.ToString

        If table.Rows.Count = 0 Then
            MessageBox.Show("Invalid Username Or Password")
        Else
            MessageBox.Show("Welcome back" & login_name & "!")
            Dim newForm As New AddDefect()
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

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class