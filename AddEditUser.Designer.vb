<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AUDataGrid = New System.Windows.Forms.DataGridView()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Real_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Real_NameLabel = New System.Windows.Forms.Label()
        Me.User_NameTextBox = New System.Windows.Forms.TextBox()
        Me.User_NameLabel = New System.Windows.Forms.Label()
        Me.UserDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.ShowPassCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConfirmTextBox = New System.Windows.Forms.TextBox()
        Me.User_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User_IdLabel = New System.Windows.Forms.Label()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ChangeUser_Button = New System.Windows.Forms.Button()
        Me.AddUser_Button = New System.Windows.Forms.Button()
        Me.NewUserButton = New System.Windows.Forms.Button()
        Me.DeleteUserButton = New System.Windows.Forms.Button()
        CType(Me.AUDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDataGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AUDataGrid
        '
        Me.AUDataGrid.AllowUserToAddRows = False
        Me.AUDataGrid.AllowUserToDeleteRows = False
        Me.AUDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AUDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AUDataGrid.Location = New System.Drawing.Point(6, 317)
        Me.AUDataGrid.Name = "AUDataGrid"
        Me.AUDataGrid.ReadOnly = True
        Me.AUDataGrid.RowTemplate.Height = 25
        Me.AUDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AUDataGrid.Size = New System.Drawing.Size(504, 298)
        Me.AUDataGrid.TabIndex = 0
        '
        'RoleComboBox
        '
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Location = New System.Drawing.Point(6, 265)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(250, 23)
        Me.RoleComboBox.TabIndex = 6
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RoleLabel.Location = New System.Drawing.Point(6, 245)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(40, 19)
        Me.RoleLabel.TabIndex = 14
        Me.RoleLabel.Text = "Role:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(6, 175)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(152, 23)
        Me.PasswordTextBox.TabIndex = 4
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordLabel.Location = New System.Drawing.Point(6, 155)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(71, 19)
        Me.PasswordLabel.TabIndex = 12
        Me.PasswordLabel.Text = "Password:"
        '
        'Real_NameTextBox
        '
        Me.Real_NameTextBox.Location = New System.Drawing.Point(6, 85)
        Me.Real_NameTextBox.Name = "Real_NameTextBox"
        Me.Real_NameTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Real_NameTextBox.TabIndex = 2
        '
        'Real_NameLabel
        '
        Me.Real_NameLabel.AutoSize = True
        Me.Real_NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Real_NameLabel.Location = New System.Drawing.Point(5, 65)
        Me.Real_NameLabel.Name = "Real_NameLabel"
        Me.Real_NameLabel.Size = New System.Drawing.Size(80, 19)
        Me.Real_NameLabel.TabIndex = 9
        Me.Real_NameLabel.Text = "Real Name:"
        '
        'User_NameTextBox
        '
        Me.User_NameTextBox.Location = New System.Drawing.Point(6, 130)
        Me.User_NameTextBox.Name = "User_NameTextBox"
        Me.User_NameTextBox.Size = New System.Drawing.Size(250, 23)
        Me.User_NameTextBox.TabIndex = 3
        '
        'User_NameLabel
        '
        Me.User_NameLabel.AutoSize = True
        Me.User_NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.User_NameLabel.Location = New System.Drawing.Point(6, 110)
        Me.User_NameLabel.Name = "User_NameLabel"
        Me.User_NameLabel.Size = New System.Drawing.Size(81, 19)
        Me.User_NameLabel.TabIndex = 7
        Me.User_NameLabel.Text = "User Name:"
        '
        'UserDataGroupBox
        '
        Me.UserDataGroupBox.Controls.Add(Me.ShowPassCheckBox)
        Me.UserDataGroupBox.Controls.Add(Me.ConfirmTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.Real_NameTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_IdTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.Label1)
        Me.UserDataGroupBox.Controls.Add(Me.RoleComboBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_IdLabel)
        Me.UserDataGroupBox.Controls.Add(Me.RoleLabel)
        Me.UserDataGroupBox.Controls.Add(Me.Real_NameLabel)
        Me.UserDataGroupBox.Controls.Add(Me.User_NameTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.PasswordLabel)
        Me.UserDataGroupBox.Controls.Add(Me.User_NameLabel)
        Me.UserDataGroupBox.Location = New System.Drawing.Point(6, 8)
        Me.UserDataGroupBox.Name = "UserDataGroupBox"
        Me.UserDataGroupBox.Size = New System.Drawing.Size(266, 303)
        Me.UserDataGroupBox.TabIndex = 15
        Me.UserDataGroupBox.TabStop = False
        Me.UserDataGroupBox.Text = "User Data"
        '
        'ShowPassCheckBox
        '
        Me.ShowPassCheckBox.AutoSize = True
        Me.ShowPassCheckBox.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowPassCheckBox.Location = New System.Drawing.Point(164, 200)
        Me.ShowPassCheckBox.Name = "ShowPassCheckBox"
        Me.ShowPassCheckBox.Size = New System.Drawing.Size(92, 16)
        Me.ShowPassCheckBox.TabIndex = 21
        Me.ShowPassCheckBox.Text = "Show Password"
        Me.ShowPassCheckBox.UseVisualStyleBackColor = True
        '
        'ConfirmTextBox
        '
        Me.ConfirmTextBox.Location = New System.Drawing.Point(6, 220)
        Me.ConfirmTextBox.Name = "ConfirmTextBox"
        Me.ConfirmTextBox.Size = New System.Drawing.Size(152, 23)
        Me.ConfirmTextBox.TabIndex = 5
        Me.ConfirmTextBox.UseSystemPasswordChar = True
        '
        'User_IdTextBox
        '
        Me.User_IdTextBox.Enabled = False
        Me.User_IdTextBox.Location = New System.Drawing.Point(6, 40)
        Me.User_IdTextBox.Name = "User_IdTextBox"
        Me.User_IdTextBox.Size = New System.Drawing.Size(57, 23)
        Me.User_IdTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Confirm Password:"
        '
        'User_IdLabel
        '
        Me.User_IdLabel.AutoSize = True
        Me.User_IdLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.User_IdLabel.Location = New System.Drawing.Point(6, 20)
        Me.User_IdLabel.Name = "User_IdLabel"
        Me.User_IdLabel.Size = New System.Drawing.Size(55, 19)
        Me.User_IdLabel.TabIndex = 9
        Me.User_IdLabel.Text = "User ID"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Location = New System.Drawing.Point(393, 248)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(114, 29)
        Me.Cancel_Button.TabIndex = 10
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'ChangeUser_Button
        '
        Me.ChangeUser_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangeUser_Button.Location = New System.Drawing.Point(276, 282)
        Me.ChangeUser_Button.Name = "ChangeUser_Button"
        Me.ChangeUser_Button.Size = New System.Drawing.Size(114, 29)
        Me.ChangeUser_Button.TabIndex = 9
        Me.ChangeUser_Button.Text = "Change Selected"
        Me.ChangeUser_Button.UseVisualStyleBackColor = True
        '
        'AddUser_Button
        '
        Me.AddUser_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddUser_Button.Location = New System.Drawing.Point(276, 247)
        Me.AddUser_Button.Name = "AddUser_Button"
        Me.AddUser_Button.Size = New System.Drawing.Size(114, 29)
        Me.AddUser_Button.TabIndex = 8
        Me.AddUser_Button.Text = "Add User"
        Me.AddUser_Button.UseVisualStyleBackColor = True
        '
        'NewUserButton
        '
        Me.NewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewUserButton.Location = New System.Drawing.Point(276, 212)
        Me.NewUserButton.Name = "NewUserButton"
        Me.NewUserButton.Size = New System.Drawing.Size(114, 29)
        Me.NewUserButton.TabIndex = 7
        Me.NewUserButton.Text = "New User"
        Me.NewUserButton.UseVisualStyleBackColor = True
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteUserButton.Location = New System.Drawing.Point(393, 283)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(114, 29)
        Me.DeleteUserButton.TabIndex = 10
        Me.DeleteUserButton.Text = "Delete Selected"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'AddEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 627)
        Me.Controls.Add(Me.NewUserButton)
        Me.Controls.Add(Me.AddUser_Button)
        Me.Controls.Add(Me.DeleteUserButton)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.ChangeUser_Button)
        Me.Controls.Add(Me.UserDataGroupBox)
        Me.Controls.Add(Me.AUDataGrid)
        Me.Name = "AddEditUser"
        Me.Text = "Add/Edit User"
        CType(Me.AUDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDataGroupBox.ResumeLayout(False)
        Me.UserDataGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AUDataGrid As DataGridView
    Friend WithEvents RoleComboBox As ComboBox
    Friend WithEvents RoleLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Real_NameTextBox As TextBox
    Friend WithEvents Real_NameLabel As Label
    Friend WithEvents User_NameTextBox As TextBox
    Friend WithEvents User_NameLabel As Label
    Friend WithEvents UserDataGroupBox As GroupBox
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents ChangeUser_Button As Button
    Friend WithEvents User_IdLabel As Label
    Friend WithEvents User_IdTextBox As TextBox
    Friend WithEvents AddUser_Button As Button
    Friend WithEvents ConfirmTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NewUserButton As Button
    Friend WithEvents ShowPassCheckBox As CheckBox
    Friend WithEvents DeleteUserButton As Button
End Class
