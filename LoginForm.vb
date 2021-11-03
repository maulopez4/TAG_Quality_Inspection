Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class LoginForm
    Friend Shared login_role As String
    Friend Shared login_user As String
    Friend Shared login_workstation As String
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Workstation DropDown Menu 
        Using WScommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim WSadapter As New MySqlDataAdapter(WScommand)
            Dim WStable As New DataTable()
            Dim WS = WSadapter.Fill(WStable)
            LoginWorkstationComboBox.DataSource = WStable
            LoginWorkstationComboBox.ValueMember = "workstation_code"
            LoginWorkstationComboBox.DisplayMember = "workstation_description"
        End Using
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_OKButton.Click
        Dim command As New MySqlCommand("SELECT `users_username`, `users_password`, `users_role`, `users_status` FROM `users` WHERE `users_username` = @username AND `users_password` = @password", connection)
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Login_UsernameTextBox.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Login_PasswordTextBox.Text
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
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_CancelButton.Click
        Me.Close()
    End Sub
    Private Sub ShowPasswordCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_ShowPasswordCheckBox.CheckedChanged
        If Login_PasswordTextBox.UseSystemPasswordChar = True Then
            Login_PasswordTextBox.UseSystemPasswordChar = False
        Else
            Login_PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub LoginWorkstationComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LoginWorkstationComboBox.SelectedIndexChanged
        login_workstation = LoginWorkstationComboBox.SelectedValue.ToString
    End Sub
End Class