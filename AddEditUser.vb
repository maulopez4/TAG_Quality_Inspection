Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class AddEditUser
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    Private Sub AddEditUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        Real_NameTextBox.Clear()
        User_NameTextBox.Clear()
        PasswordTextBox.Clear()
        ConfirmTextBox.Clear()
        NewUserButton.Enabled = True
        AddUser_Button.Enabled = False
        ChangeUser_Button.Enabled = False
        DeleteUserButton.Enabled = False
        Try
            Using AUcommand As New MySqlCommand("SELECT `users_id`, `users_realname`, `users_username`, `users_password`,`users_role` FROM `users`", connection)
                Dim AUadapter As New MySqlDataAdapter(AUcommand)
                Dim AUtable As New DataTable()
                Dim AU = AUadapter.Fill(AUtable)
                AUDataGrid.DataSource = AUtable
            End Using
            Using RLcommand As New MySqlCommand("SELECT `roles_name`, `roles_description` FROM `roles`", connection)
                Dim RLadapter As New MySqlDataAdapter(RLcommand)
                Dim RLtable As New DataTable()
                RLadapter.Fill(RLtable)
                RoleComboBox.DataSource = RLtable
                RoleComboBox.ValueMember = "roles_name"
                RoleComboBox.DisplayMember = "roles_description"
            End Using
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub AUDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles AUDataGrid.SelectionChanged
        NewUserButton.Enabled = True
        AddUser_Button.Enabled = False
        ChangeUser_Button.Enabled = True
        DeleteUserButton.Enabled = True
        If AUDataGrid.SelectedRows.Count > 0 Then
            User_IdTextBox.Text = AUDataGrid.Item("users_id", AUDataGrid.SelectedRows(0).Index).Value
            Real_NameTextBox.Text = AUDataGrid.Item("users_realname", AUDataGrid.SelectedRows(0).Index).Value
            User_NameTextBox.Text = AUDataGrid.Item("users_username", AUDataGrid.SelectedRows(0).Index).Value
            PasswordTextBox.Text = AUDataGrid.Item("users_password", AUDataGrid.SelectedRows(0).Index).Value
            ConfirmTextBox.Text = AUDataGrid.Item("users_password", AUDataGrid.SelectedRows(0).Index).Value
            RoleComboBox.SelectedValue = AUDataGrid.Item("users_role", AUDataGrid.SelectedRows(0).Index).Value
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        connection.Close()
        Me.Close()
    End Sub
    Private Sub DeleteUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserButton.Click
        Dim command As New MySqlCommand("DELETE FROM `users` WHERE `users_id` = @users_id", connection)
        command.Parameters.Add("@users_id", MySqlDbType.VarChar).Value = User_IdTextBox.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("User Updated")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddEditUser_Load(sender, e)
    End Sub
    Private Sub EditUser_Button_Click(sender As Object, e As EventArgs) Handles ChangeUser_Button.Click
        If Real_NameTextBox.Text = "" Or User_NameTextBox.Text = "" Or PasswordTextBox.Text = "" Or ConfirmTextBox.Text = "" Then
            MessageBox.Show("Missign Fields, please review data entered")
        Else
            If IsNothing(Real_NameTextBox.Text) Then
                MessageBox.Show("Real Name Missing, Please Enter User Real Name")
            Else
                If IsNothing(User_NameTextBox.Text) Then
                    MessageBox.Show("User Name Required, Please Enter User Name")
                Else
                    If IsNothing(PasswordTextBox.Text) Then
                        MessageBox.Show("Password can not be Empty, Please Enter Password")
                    Else
                        Dim command As New MySqlCommand("UPDATE `users` SET `users_realname` = @users_realname, `users_username` = @users_username, `users_password` = @users_password, `users_role` = @users_role WHERE `users_id` = @users_id", connection)
                        command.Parameters.Add("@users_id", MySqlDbType.VarChar).Value = User_IdTextBox.Text
                        command.Parameters.Add("@users_realname", MySqlDbType.VarChar).Value = Real_NameTextBox.Text
                        command.Parameters.Add("@users_username", MySqlDbType.VarChar).Value = User_NameTextBox.Text
                        command.Parameters.Add("@users_password", MySqlDbType.VarChar).Value = PasswordTextBox.Text
                        command.Parameters.Add("@users_role", MySqlDbType.VarChar).Value = RoleComboBox.SelectedValue
                        connection.Open()
                        If command.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("User Updated")
                        Else
                            MessageBox.Show("ERROR")
                        End If
                        connection.Close()
                        AddEditUser_Load(sender, e)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub AddUser_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUser_Button.Click
        If Real_NameTextBox.Text = "" Or User_NameTextBox.Text = "" Or PasswordTextBox.Text = "" Or ConfirmTextBox.Text = "" Then
            MessageBox.Show("Missign Fields, please review data entered")
        Else
            If IsNothing(Real_NameTextBox.Text) Then
                MessageBox.Show("Real Name Missing, Please Enter User Real Name")
            Else
                If IsNothing(User_NameTextBox.Text) Then
                    MessageBox.Show("User Name Required, Please Enter User Name")
                Else
                    If IsNothing(PasswordTextBox.Text) Then
                        MessageBox.Show("Password can not be Empty, Please Enter Password")
                    Else
                        Dim command As New MySqlCommand("INSERT INTO `users`(`users_realname`, `users_username`, `users_password`,`users_role`) VALUES (@users_realname,@users_username,@users_password,@users_role)", connection)
                        command.Parameters.Add("@users_realname", MySqlDbType.VarChar).Value = Real_NameTextBox.Text
                        command.Parameters.Add("@users_username", MySqlDbType.VarChar).Value = User_NameTextBox.Text
                        command.Parameters.Add("@users_password", MySqlDbType.VarChar).Value = PasswordTextBox.Text
                        command.Parameters.Add("@users_role", MySqlDbType.VarChar).Value = RoleComboBox.SelectedValue

                        connection.Open()

                        If command.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("New User Created")
                        Else
                            MessageBox.Show("ERROR")
                        End If
                        connection.Close()
                        AddEditUser_Load(sender, e)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub User_NameTextBox_LostFocus(sender As Object, e As EventArgs) Handles User_NameTextBox.LostFocus
        Dim user_name As String
        Dim command As New MySqlCommand("SELECT `users_username` FROM `users` WHERE `users_username` = @users_username", connection)
        command.Parameters.Add("@users_username", MySqlDbType.VarChar).Value = User_NameTextBox.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        For Each row In table.AsEnumerable
            user_name = (String.Format("{0}", row("users_username")))
        Next

        If table.Rows.Count = 0 Then
            PasswordTextBox.Enabled = True
            ConfirmTextBox.Enabled = True
            RoleComboBox.Enabled = True
            AddUser_Button.Enabled = True
        Else
            MessageBox.Show("User Already Exist")
            User_NameTextBox.Clear()
            PasswordTextBox.Enabled = False
            ConfirmTextBox.Enabled = False
            RoleComboBox.Enabled = False
            AddUser_Button.Enabled = False
        End If
    End Sub
    Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 6,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1,
    Optional ByVal numSpecial As Integer = 1) As Boolean

        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function
    Private Sub PasswordTextBox_LostFocus(sender As Object, e As EventArgs) Handles PasswordTextBox.LostFocus
        Dim strPwd As String
        strPwd = PasswordTextBox.Text
        If ValidatePassword(strPwd) = True Then
            PasswordTextBox.Text = strPwd
        Else
            MessageBox.Show("Password is invalid." & vbCrLf & "Must be at least 6 Characters long." & vbCrLf & "Must contain at least 1 Uppercase Character." & vbCrLf & "Must contain at least 1 Lowercase Character." & vbCrLf & "Must contain at least 1 Number Character." & vbCrLf & "Please try again.")
            PasswordTextBox.Clear()
            PasswordTextBox.TabIndex = 3
        End If
    End Sub
    Private Sub ConfirmTextBox_LostFocus(sender As Object, e As EventArgs) Handles ConfirmTextBox.LostFocus
        If String.Compare(PasswordTextBox.Text, ConfirmTextBox.Text) = 0 Then

        Else
            MessageBox.Show("Password and Confirmation doesn't match! Please Check Again")
        End If
    End Sub
    Private Sub NewUserButton_Click(sender As Object, e As MouseEventArgs) Handles NewUserButton.Click
        Real_NameTextBox.Clear()
        User_NameTextBox.Clear()
        PasswordTextBox.Clear()
        ConfirmTextBox.Clear()
        NewUserButton.Enabled = False
        AddUser_Button.Enabled = True
        ChangeUser_Button.Enabled = False
        DeleteUserButton.Enabled = False
    End Sub

    Private Sub ShowPassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCheckBox.CheckStateChanged
        If PasswordTextBox.UseSystemPasswordChar = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If

        If ConfirmTextBox.UseSystemPasswordChar = True Then
            ConfirmTextBox.UseSystemPasswordChar = False
        Else
            ConfirmTextBox.UseSystemPasswordChar = True
        End If
    End Sub
End Class