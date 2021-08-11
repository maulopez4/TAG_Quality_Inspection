<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Main
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
        Me.UserGroupBox = New System.Windows.Forms.GroupBox()
        Me.User_AddNewEntryButton = New System.Windows.Forms.Button()
        Me.SuperGroupBox = New System.Windows.Forms.GroupBox()
        Me.Super_AddColorButton = New System.Windows.Forms.Button()
        Me.Super_AddModelButton = New System.Windows.Forms.Button()
        Me.Super_AddEditUserButton = New System.Windows.Forms.Button()
        Me.AdminGroupBox = New System.Windows.Forms.GroupBox()
        Me.Admin_AddColorButton = New System.Windows.Forms.Button()
        Me.Admin_AddModelButton = New System.Windows.Forms.Button()
        Me.Admin_AddEditUserButton = New System.Windows.Forms.Button()
        Me.CurrentUserTextBox = New System.Windows.Forms.TextBox()
        Me.UserGroupBox.SuspendLayout()
        Me.SuperGroupBox.SuspendLayout()
        Me.AdminGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserGroupBox
        '
        Me.UserGroupBox.Controls.Add(Me.User_AddNewEntryButton)
        Me.UserGroupBox.Location = New System.Drawing.Point(6, 32)
        Me.UserGroupBox.Name = "UserGroupBox"
        Me.UserGroupBox.Size = New System.Drawing.Size(792, 94)
        Me.UserGroupBox.TabIndex = 0
        Me.UserGroupBox.TabStop = False
        Me.UserGroupBox.Text = "User Options"
        '
        'User_AddNewEntryButton
        '
        Me.User_AddNewEntryButton.Location = New System.Drawing.Point(6, 28)
        Me.User_AddNewEntryButton.Name = "User_AddNewEntryButton"
        Me.User_AddNewEntryButton.Size = New System.Drawing.Size(162, 60)
        Me.User_AddNewEntryButton.TabIndex = 0
        Me.User_AddNewEntryButton.Text = "New Entry"
        Me.User_AddNewEntryButton.UseVisualStyleBackColor = True
        '
        'SuperGroupBox
        '
        Me.SuperGroupBox.Controls.Add(Me.Super_AddColorButton)
        Me.SuperGroupBox.Controls.Add(Me.Super_AddModelButton)
        Me.SuperGroupBox.Controls.Add(Me.Super_AddEditUserButton)
        Me.SuperGroupBox.Location = New System.Drawing.Point(6, 132)
        Me.SuperGroupBox.Name = "SuperGroupBox"
        Me.SuperGroupBox.Size = New System.Drawing.Size(792, 92)
        Me.SuperGroupBox.TabIndex = 0
        Me.SuperGroupBox.TabStop = False
        Me.SuperGroupBox.Text = "Supervisor Options"
        '
        'Super_AddColorButton
        '
        Me.Super_AddColorButton.Location = New System.Drawing.Point(342, 22)
        Me.Super_AddColorButton.Name = "Super_AddColorButton"
        Me.Super_AddColorButton.Size = New System.Drawing.Size(162, 60)
        Me.Super_AddColorButton.TabIndex = 0
        Me.Super_AddColorButton.Text = "Add/Edit Color"
        Me.Super_AddColorButton.UseVisualStyleBackColor = True
        '
        'Super_AddModelButton
        '
        Me.Super_AddModelButton.Location = New System.Drawing.Point(174, 22)
        Me.Super_AddModelButton.Name = "Super_AddModelButton"
        Me.Super_AddModelButton.Size = New System.Drawing.Size(162, 60)
        Me.Super_AddModelButton.TabIndex = 0
        Me.Super_AddModelButton.Text = "Add/Edit Mold Model"
        Me.Super_AddModelButton.UseVisualStyleBackColor = True
        '
        'Super_AddEditUserButton
        '
        Me.Super_AddEditUserButton.Location = New System.Drawing.Point(6, 22)
        Me.Super_AddEditUserButton.Name = "Super_AddEditUserButton"
        Me.Super_AddEditUserButton.Size = New System.Drawing.Size(162, 60)
        Me.Super_AddEditUserButton.TabIndex = 0
        Me.Super_AddEditUserButton.Text = "Add/Edit User"
        Me.Super_AddEditUserButton.UseVisualStyleBackColor = True
        '
        'AdminGroupBox
        '
        Me.AdminGroupBox.Controls.Add(Me.Admin_AddColorButton)
        Me.AdminGroupBox.Controls.Add(Me.Admin_AddModelButton)
        Me.AdminGroupBox.Controls.Add(Me.Admin_AddEditUserButton)
        Me.AdminGroupBox.Location = New System.Drawing.Point(6, 230)
        Me.AdminGroupBox.Name = "AdminGroupBox"
        Me.AdminGroupBox.Size = New System.Drawing.Size(792, 94)
        Me.AdminGroupBox.TabIndex = 0
        Me.AdminGroupBox.TabStop = False
        Me.AdminGroupBox.Text = "Admin Options"
        '
        'Admin_AddColorButton
        '
        Me.Admin_AddColorButton.Location = New System.Drawing.Point(342, 22)
        Me.Admin_AddColorButton.Name = "Admin_AddColorButton"
        Me.Admin_AddColorButton.Size = New System.Drawing.Size(162, 60)
        Me.Admin_AddColorButton.TabIndex = 0
        Me.Admin_AddColorButton.Text = "Add/Edit Color"
        Me.Admin_AddColorButton.UseVisualStyleBackColor = True
        '
        'Admin_AddModelButton
        '
        Me.Admin_AddModelButton.Location = New System.Drawing.Point(174, 22)
        Me.Admin_AddModelButton.Name = "Admin_AddModelButton"
        Me.Admin_AddModelButton.Size = New System.Drawing.Size(162, 60)
        Me.Admin_AddModelButton.TabIndex = 0
        Me.Admin_AddModelButton.Text = "Add/Edit Mold Model"
        Me.Admin_AddModelButton.UseVisualStyleBackColor = True
        '
        'Admin_AddEditUserButton
        '
        Me.Admin_AddEditUserButton.Location = New System.Drawing.Point(6, 22)
        Me.Admin_AddEditUserButton.Name = "Admin_AddEditUserButton"
        Me.Admin_AddEditUserButton.Size = New System.Drawing.Size(162, 60)
        Me.Admin_AddEditUserButton.TabIndex = 0
        Me.Admin_AddEditUserButton.Text = "Add/Edit User"
        Me.Admin_AddEditUserButton.UseVisualStyleBackColor = True
        '
        'CurrentUserTextBox
        '
        Me.CurrentUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentUserTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.CurrentUserTextBox.Enabled = False
        Me.CurrentUserTextBox.Location = New System.Drawing.Point(545, 12)
        Me.CurrentUserTextBox.Name = "CurrentUserTextBox"
        Me.CurrentUserTextBox.Size = New System.Drawing.Size(243, 16)
        Me.CurrentUserTextBox.TabIndex = 1
        Me.CurrentUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'User_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 548)
        Me.Controls.Add(Me.CurrentUserTextBox)
        Me.Controls.Add(Me.AdminGroupBox)
        Me.Controls.Add(Me.SuperGroupBox)
        Me.Controls.Add(Me.UserGroupBox)
        Me.Name = "User_Main"
        Me.Text = "Workorder Entry"
        Me.UserGroupBox.ResumeLayout(False)
        Me.SuperGroupBox.ResumeLayout(False)
        Me.AdminGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserGroupBox As GroupBox
    Friend WithEvents User_AddNewEntryButton As Button
    Friend WithEvents SuperGroupBox As GroupBox
    Friend WithEvents AdminGroupBox As GroupBox
    Friend WithEvents Admin_AddModelButton As Button
    Friend WithEvents Admin_AddEditUserButton As Button
    Friend WithEvents CurrentUserTextBox As TextBox
    Friend WithEvents Super_AddModelButton As Button
    Friend WithEvents Super_AddEditUserButton As Button
    Friend WithEvents Super_AddColorButton As Button
    Friend WithEvents Admin_AddColorButton As Button
End Class
