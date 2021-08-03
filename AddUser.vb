Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class AddUser

    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    Private Sub AddUser_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUser_Button.Click

        Dim command As New MySqlCommand("INSERT INTO `users`(`real_name`, `user_name`, `password`,`role`, `workstation`) VALUES (@real_name,@user_name,@password,@role,@workstation)", connection)

        ' add Parameters to the command
        command.Parameters.Add("@real_name", MySqlDbType.VarChar).Value = Real_NameTextBox.Text
        command.Parameters.Add("@user_name", MySqlDbType.VarChar).Value = User_NameTextBox.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text
        command.Parameters.Add("@role", MySqlDbType.VarChar).Value = RoleComboBox.SelectedValue
        command.Parameters.Add("@workstation", MySqlDbType.VarChar).Value = WorkstationComboBox.SelectedValue

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted")
        Else
            MessageBox.Show("ERROR")
        End If

        connection.Close()
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        connection.Close()
        Me.Close()

    End Sub
    Private Sub AddUserForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim RLcommand As New MySqlCommand("SELECT `role_name`, `role_description` FROM `roles`", connection)
        Dim RLadapter As New MySqlDataAdapter(RLcommand)
        Dim RLtable As New DataTable()
        RLadapter.Fill(RLtable)

        RoleComboBox.DataSource = RLtable
        RoleComboBox.ValueMember = "role_name"
        RoleComboBox.DisplayMember = "role_description"

        Dim WScommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
        Dim WSadapter As New MySqlDataAdapter(WScommand)
        Dim WStable As New DataTable()
        WSadapter.Fill(WStable)

        WorkstationComboBox.DataSource = WStable
        WorkstationComboBox.ValueMember = "workstation_code"
        WorkstationComboBox.DisplayMember = "workstation_description"

    End Sub
End Class