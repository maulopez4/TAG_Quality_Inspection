<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.User_NameLabel = New System.Windows.Forms.Label()
        Me.User_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Real_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Real_NameLabel = New System.Windows.Forms.Label()
        Me.WorkstationLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.AddUser_Button = New System.Windows.Forms.Button()
        Me.WorkstationComboBox = New System.Windows.Forms.ComboBox()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'User_NameLabel
        '
        Me.User_NameLabel.AutoSize = True
        Me.User_NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.User_NameLabel.Location = New System.Drawing.Point(12, 59)
        Me.User_NameLabel.Name = "User_NameLabel"
        Me.User_NameLabel.Size = New System.Drawing.Size(81, 19)
        Me.User_NameLabel.TabIndex = 0
        Me.User_NameLabel.Text = "User Name:"
        '
        'User_NameTextBox
        '
        Me.User_NameTextBox.Location = New System.Drawing.Point(12, 81)
        Me.User_NameTextBox.Name = "User_NameTextBox"
        Me.User_NameTextBox.Size = New System.Drawing.Size(250, 23)
        Me.User_NameTextBox.TabIndex = 2
        '
        'Real_NameTextBox
        '
        Me.Real_NameTextBox.Location = New System.Drawing.Point(12, 31)
        Me.Real_NameTextBox.Name = "Real_NameTextBox"
        Me.Real_NameTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Real_NameTextBox.TabIndex = 1
        '
        'Real_NameLabel
        '
        Me.Real_NameLabel.AutoSize = True
        Me.Real_NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Real_NameLabel.Location = New System.Drawing.Point(12, 9)
        Me.Real_NameLabel.Name = "Real_NameLabel"
        Me.Real_NameLabel.Size = New System.Drawing.Size(80, 19)
        Me.Real_NameLabel.TabIndex = 2
        Me.Real_NameLabel.Text = "Real Name:"
        '
        'WorkstationLabel
        '
        Me.WorkstationLabel.AutoSize = True
        Me.WorkstationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.WorkstationLabel.Location = New System.Drawing.Point(12, 209)
        Me.WorkstationLabel.Name = "WorkstationLabel"
        Me.WorkstationLabel.Size = New System.Drawing.Size(89, 19)
        Me.WorkstationLabel.TabIndex = 6
        Me.WorkstationLabel.Text = "Workstation:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(12, 131)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(250, 23)
        Me.PasswordTextBox.TabIndex = 3
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 109)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(71, 19)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Password:"
        '
        'AddUser_Button
        '
        Me.AddUser_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddUser_Button.Location = New System.Drawing.Point(12, 284)
        Me.AddUser_Button.Name = "AddUser_Button"
        Me.AddUser_Button.Size = New System.Drawing.Size(114, 29)
        Me.AddUser_Button.TabIndex = 6
        Me.AddUser_Button.Text = "Add User"
        Me.AddUser_Button.UseVisualStyleBackColor = True
        '
        'WorkstationComboBox
        '
        Me.WorkstationComboBox.FormattingEnabled = True
        Me.WorkstationComboBox.Location = New System.Drawing.Point(12, 231)
        Me.WorkstationComboBox.Name = "WorkstationComboBox"
        Me.WorkstationComboBox.Size = New System.Drawing.Size(250, 23)
        Me.WorkstationComboBox.TabIndex = 5
        '
        'Cancel_Button
        '
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Location = New System.Drawing.Point(146, 284)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(114, 29)
        Me.Cancel_Button.TabIndex = 7
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RoleLabel.Location = New System.Drawing.Point(12, 159)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(40, 19)
        Me.RoleLabel.TabIndex = 6
        Me.RoleLabel.Text = "Role:"
        '
        'RoleComboBox
        '
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Location = New System.Drawing.Point(12, 181)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(250, 23)
        Me.RoleComboBox.TabIndex = 4
        '
        'AddUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 323)
        Me.Controls.Add(Me.RoleComboBox)
        Me.Controls.Add(Me.WorkstationComboBox)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.AddUser_Button)
        Me.Controls.Add(Me.RoleLabel)
        Me.Controls.Add(Me.WorkstationLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.Real_NameTextBox)
        Me.Controls.Add(Me.Real_NameLabel)
        Me.Controls.Add(Me.User_NameTextBox)
        Me.Controls.Add(Me.User_NameLabel)
        Me.Name = "AddUserForm"
        Me.Text = "Add New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents User_NameLabel As Label
    Friend WithEvents User_NameTextBox As TextBox
    Friend WithEvents Real_NameTextBox As TextBox
    Friend WithEvents Real_NameLabel As Label
    Friend WithEvents WorkstationLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents AddUser_Button As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents WorkstationComboBox As ComboBox
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents RoleLabel As Label
    Friend WithEvents RoleComboBox As ComboBox
End Class
