Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class AddUser

    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
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
                        Dim command As New MySqlCommand("INSERT INTO `users`(`real_name`, `user_name`, `password`,`role`) VALUES (@real_name,@user_name,@password,@role)", connection)
                        command.Parameters.Add("@real_name", MySqlDbType.VarChar).Value = Real_NameTextBox.Text
                        command.Parameters.Add("@user_name", MySqlDbType.VarChar).Value = User_NameTextBox.Text
                        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text
                        command.Parameters.Add("@role", MySqlDbType.VarChar).Value = RoleComboBox.SelectedValue

                        connection.Open()

                        If command.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("New User Created")
                        Else
                            MessageBox.Show("ERROR")
                        End If
                        connection.Close()
                        Close()
                    End If
                End If
            End If
        End If
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

    End Sub
    Private Sub User_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles User_NameTextBox.TextChanged
        Dim user_name As String
        Dim command As New MySqlCommand("SELECT `user_name` FROM `users` WHERE `user_name` = @user_name", connection)
        command.Parameters.Add("@user_name", MySqlDbType.VarChar).Value = User_NameTextBox.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        For Each row In table.AsEnumerable
            user_name = (String.Format("{0}", row("user_name")))
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

    Private Sub ConfirmTextBox_LostFocus(sender As Object, e As EventArgs) Handles ConfirmTextBox.LostFocus
        If String.Compare(PasswordTextBox.Text, ConfirmTextBox.Text) = 0 Then

        Else
            MessageBox.Show("Password and Confirmation doesn't match! Please Check Again")
        End If
    End Sub
    Private Sub PasswordTextBox_LostFocus(sender As Object, e As EventArgs) Handles PasswordTextBox.LostFocus
        Dim strPwd As String
        strPwd = PasswordTextBox.Text
        If ValidatePassword(strPwd) = True Then
            PasswordTextBox.Text = PasswordTextBox.Text
        Else
            MessageBox.Show("Password is invalid." & vbCrLf & "Must be at least 6 Characters long." & vbCrLf & "Must contain at least 1 Uppercase Character." & vbCrLf & "Must contain at least 1 Lowercase Character." & vbCrLf & "Must contain at least 1 Number Character." & vbCrLf & "Please try again.")
            PasswordTextBox.Clear()
            PasswordTextBox.TabIndex = 3
        End If
    End Sub
End Class