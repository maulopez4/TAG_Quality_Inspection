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
        Me.User_AUDataGrid = New System.Windows.Forms.DataGridView()
        Me.User_RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.User_RoleLabel = New System.Windows.Forms.Label()
        Me.User_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.User_PasswordLabel = New System.Windows.Forms.Label()
        Me.User_RealNameTextBox = New System.Windows.Forms.TextBox()
        Me.User_RealNameLabel = New System.Windows.Forms.Label()
        Me.User_NameTextBox = New System.Windows.Forms.TextBox()
        Me.User_NameLabel = New System.Windows.Forms.Label()
        Me.UserDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.ShowPassCheckBox = New System.Windows.Forms.CheckBox()
        Me.User_ConfirmTextBox = New System.Windows.Forms.TextBox()
        Me.User_IdTextBox = New System.Windows.Forms.TextBox()
        Me.User_ConfirmLabel = New System.Windows.Forms.Label()
        Me.User_IdLabel = New System.Windows.Forms.Label()
        Me.User_CancelButton = New System.Windows.Forms.Button()
        Me.User_ChangeUserButton = New System.Windows.Forms.Button()
        Me.User_AddUserButton = New System.Windows.Forms.Button()
        Me.User_NewUserButton = New System.Windows.Forms.Button()
        Me.User_DeleteUserButton = New System.Windows.Forms.Button()
        CType(Me.User_AUDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDataGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'User_AUDataGrid
        '
        Me.User_AUDataGrid.AllowUserToAddRows = False
        Me.User_AUDataGrid.AllowUserToDeleteRows = False
        Me.User_AUDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.User_AUDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.User_AUDataGrid.Location = New System.Drawing.Point(6, 317)
        Me.User_AUDataGrid.Name = "User_AUDataGrid"
        Me.User_AUDataGrid.ReadOnly = True
        Me.User_AUDataGrid.RowTemplate.Height = 25
        Me.User_AUDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.User_AUDataGrid.Size = New System.Drawing.Size(504, 298)
        Me.User_AUDataGrid.TabIndex = 0
        '
        'User_RoleComboBox
        '
        Me.User_RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.User_RoleComboBox.FormattingEnabled = True
        Me.User_RoleComboBox.Location = New System.Drawing.Point(6, 265)
        Me.User_RoleComboBox.Name = "User_RoleComboBox"
        Me.User_RoleComboBox.Size = New System.Drawing.Size(250, 23)
        Me.User_RoleComboBox.TabIndex = 6
        '
        'User_RoleLabel
        '
        Me.User_RoleLabel.AutoSize = True
        Me.User_RoleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.User_RoleLabel.Location = New System.Drawing.Point(6, 245)
        Me.User_RoleLabel.Name = "User_RoleLabel"
        Me.User_RoleLabel.Size = New System.Drawing.Size(40, 19)
        Me.User_RoleLabel.TabIndex = 14
        Me.User_RoleLabel.Text = "Role:"
        '
        'User_PasswordTextBox
        '
        Me.User_PasswordTextBox.Location = New System.Drawing.Point(6, 175)
        Me.User_PasswordTextBox.Name = "User_PasswordTextBox"
        Me.User_PasswordTextBox.Size = New System.Drawing.Size(152, 23)
        Me.User_PasswordTextBox.TabIndex = 4
        Me.User_PasswordTextBox.UseSystemPasswordChar = True
        '
        'User_PasswordLabel
        '
        Me.User_PasswordLabel.AutoSize = True
        Me.User_PasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.User_PasswordLabel.Location = New System.Drawing.Point(6, 155)
        Me.User_PasswordLabel.Name = "User_PasswordLabel"
        Me.User_PasswordLabel.Size = New System.Drawing.Size(71, 19)
        Me.User_PasswordLabel.TabIndex = 12
        Me.User_PasswordLabel.Text = "Password:"
        '
        'User_RealNameTextBox
        '
        Me.User_RealNameTextBox.Location = New System.Drawing.Point(6, 85)
        Me.User_RealNameTextBox.Name = "User_RealNameTextBox"
        Me.User_RealNameTextBox.Size = New System.Drawing.Size(250, 23)
        Me.User_RealNameTextBox.TabIndex = 2
        '
        'User_RealNameLabel
        '
        Me.User_RealNameLabel.AutoSize = True
        Me.User_RealNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.User_RealNameLabel.Location = New System.Drawing.Point(5, 65)
        Me.User_RealNameLabel.Name = "User_RealNameLabel"
        Me.User_RealNameLabel.Size = New System.Drawing.Size(80, 19)
        Me.User_RealNameLabel.TabIndex = 9
        Me.User_RealNameLabel.Text = "Real Name:"
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
        Me.UserDataGroupBox.Controls.Add(Me.User_ConfirmTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_RealNameTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_IdTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_ConfirmLabel)
        Me.UserDataGroupBox.Controls.Add(Me.User_RoleComboBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_IdLabel)
        Me.UserDataGroupBox.Controls.Add(Me.User_RoleLabel)
        Me.UserDataGroupBox.Controls.Add(Me.User_RealNameLabel)
        Me.UserDataGroupBox.Controls.Add(Me.User_NameTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_PasswordTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_PasswordLabel)
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
        'User_ConfirmTextBox
        '
        Me.User_ConfirmTextBox.Location = New System.Drawing.Point(6, 220)
        Me.User_ConfirmTextBox.Name = "User_ConfirmTextBox"
        Me.User_ConfirmTextBox.Size = New System.Drawing.Size(152, 23)
        Me.User_ConfirmTextBox.TabIndex = 5
        Me.User_ConfirmTextBox.UseSystemPasswordChar = True
        '
        'User_IdTextBox
        '
        Me.User_IdTextBox.Enabled = False
        Me.User_IdTextBox.Location = New System.Drawing.Point(6, 40)
        Me.User_IdTextBox.Name = "User_IdTextBox"
        Me.User_IdTextBox.Size = New System.Drawing.Size(57, 23)
        Me.User_IdTextBox.TabIndex = 1
        '
        'User_ConfirmLabel
        '
        Me.User_ConfirmLabel.AutoSize = True
        Me.User_ConfirmLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.User_ConfirmLabel.Location = New System.Drawing.Point(6, 200)
        Me.User_ConfirmLabel.Name = "User_ConfirmLabel"
        Me.User_ConfirmLabel.Size = New System.Drawing.Size(126, 19)
        Me.User_ConfirmLabel.TabIndex = 20
        Me.User_ConfirmLabel.Text = "Confirm Password:"
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
        'User_CancelButton
        '
        Me.User_CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.User_CancelButton.Location = New System.Drawing.Point(393, 248)
        Me.User_CancelButton.Name = "User_CancelButton"
        Me.User_CancelButton.Size = New System.Drawing.Size(114, 29)
        Me.User_CancelButton.TabIndex = 10
        Me.User_CancelButton.Text = "Cancel"
        Me.User_CancelButton.UseVisualStyleBackColor = True
        '
        'User_ChangeUserButton
        '
        Me.User_ChangeUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.User_ChangeUserButton.Location = New System.Drawing.Point(276, 282)
        Me.User_ChangeUserButton.Name = "User_ChangeUserButton"
        Me.User_ChangeUserButton.Size = New System.Drawing.Size(114, 29)
        Me.User_ChangeUserButton.TabIndex = 9
        Me.User_ChangeUserButton.Text = "Change Selected"
        Me.User_ChangeUserButton.UseVisualStyleBackColor = True
        '
        'User_AddUserButton
        '
        Me.User_AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.User_AddUserButton.Location = New System.Drawing.Point(276, 247)
        Me.User_AddUserButton.Name = "User_AddUserButton"
        Me.User_AddUserButton.Size = New System.Drawing.Size(114, 29)
        Me.User_AddUserButton.TabIndex = 8
        Me.User_AddUserButton.Text = "Add User"
        Me.User_AddUserButton.UseVisualStyleBackColor = True
        '
        'User_NewUserButton
        '
        Me.User_NewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.User_NewUserButton.Location = New System.Drawing.Point(276, 212)
        Me.User_NewUserButton.Name = "User_NewUserButton"
        Me.User_NewUserButton.Size = New System.Drawing.Size(114, 29)
        Me.User_NewUserButton.TabIndex = 7
        Me.User_NewUserButton.Text = "New User"
        Me.User_NewUserButton.UseVisualStyleBackColor = True
        '
        'User_DeleteUserButton
        '
        Me.User_DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.User_DeleteUserButton.Location = New System.Drawing.Point(393, 283)
        Me.User_DeleteUserButton.Name = "User_DeleteUserButton"
        Me.User_DeleteUserButton.Size = New System.Drawing.Size(114, 29)
        Me.User_DeleteUserButton.TabIndex = 10
        Me.User_DeleteUserButton.Text = "Delete Selected"
        Me.User_DeleteUserButton.UseVisualStyleBackColor = True
        '
        'AddEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 627)
        Me.Controls.Add(Me.User_NewUserButton)
        Me.Controls.Add(Me.User_AddUserButton)
        Me.Controls.Add(Me.User_DeleteUserButton)
        Me.Controls.Add(Me.User_CancelButton)
        Me.Controls.Add(Me.User_ChangeUserButton)
        Me.Controls.Add(Me.UserDataGroupBox)
        Me.Controls.Add(Me.User_AUDataGrid)
        Me.Name = "AddEditUser"
        Me.Text = "Add/Edit User"
        CType(Me.User_AUDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDataGroupBox.ResumeLayout(False)
        Me.UserDataGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents User_AUDataGrid As DataGridView
    Friend WithEvents User_RoleComboBox As ComboBox
    Friend WithEvents User_RoleLabel As Label
    Friend WithEvents User_PasswordTextBox As TextBox
    Friend WithEvents User_PasswordLabel As Label
    Friend WithEvents User_RealNameTextBox As TextBox
    Friend WithEvents User_RealNameLabel As Label
    Friend WithEvents User_NameTextBox As TextBox
    Friend WithEvents User_NameLabel As Label
    Friend WithEvents UserDataGroupBox As GroupBox
    Friend WithEvents User_CancelButton As Button
    Friend WithEvents User_ChangeUserButton As Button
    Friend WithEvents User_IdLabel As Label
    Friend WithEvents User_IdTextBox As TextBox
    Friend WithEvents User_AddUserButton As Button
    Friend WithEvents User_ConfirmTextBox As TextBox
    Friend WithEvents User_ConfirmLabel As Label
    Friend WithEvents User_NewUserButton As Button
    Friend WithEvents ShowPassCheckBox As CheckBox
    Friend WithEvents User_DeleteUserButton As Button
End Class
