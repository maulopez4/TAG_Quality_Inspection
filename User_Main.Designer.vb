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
        Me.AddNewDefectButton = New System.Windows.Forms.Button()
        Me.SuperGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddColorButton1 = New System.Windows.Forms.Button()
        Me.AddModelButton1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AdminGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddColorButton2 = New System.Windows.Forms.Button()
        Me.AddModelButton2 = New System.Windows.Forms.Button()
        Me.AddEditUserButton = New System.Windows.Forms.Button()
        Me.CurrentUserTextBox = New System.Windows.Forms.TextBox()
        Me.UserGroupBox.SuspendLayout()
        Me.SuperGroupBox.SuspendLayout()
        Me.AdminGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserGroupBox
        '
        Me.UserGroupBox.Controls.Add(Me.AddNewDefectButton)
        Me.UserGroupBox.Location = New System.Drawing.Point(6, 32)
        Me.UserGroupBox.Name = "UserGroupBox"
        Me.UserGroupBox.Size = New System.Drawing.Size(792, 94)
        Me.UserGroupBox.TabIndex = 0
        Me.UserGroupBox.TabStop = False
        Me.UserGroupBox.Text = "User Options"
        '
        'AddNewDefectButton
        '
        Me.AddNewDefectButton.Location = New System.Drawing.Point(6, 28)
        Me.AddNewDefectButton.Name = "AddNewDefectButton"
        Me.AddNewDefectButton.Size = New System.Drawing.Size(162, 60)
        Me.AddNewDefectButton.TabIndex = 0
        Me.AddNewDefectButton.Text = "New Entry"
        Me.AddNewDefectButton.UseVisualStyleBackColor = True
        '
        'SuperGroupBox
        '
        Me.SuperGroupBox.Controls.Add(Me.AddColorButton1)
        Me.SuperGroupBox.Controls.Add(Me.AddModelButton1)
        Me.SuperGroupBox.Controls.Add(Me.Button1)
        Me.SuperGroupBox.Location = New System.Drawing.Point(6, 132)
        Me.SuperGroupBox.Name = "SuperGroupBox"
        Me.SuperGroupBox.Size = New System.Drawing.Size(792, 92)
        Me.SuperGroupBox.TabIndex = 0
        Me.SuperGroupBox.TabStop = False
        Me.SuperGroupBox.Text = "Supervisor Options"
        '
        'AddColorButton1
        '
        Me.AddColorButton1.Location = New System.Drawing.Point(342, 22)
        Me.AddColorButton1.Name = "AddColorButton1"
        Me.AddColorButton1.Size = New System.Drawing.Size(162, 60)
        Me.AddColorButton1.TabIndex = 0
        Me.AddColorButton1.Text = "Add/Edit Color"
        Me.AddColorButton1.UseVisualStyleBackColor = True
        '
        'AddModelButton1
        '
        Me.AddModelButton1.Location = New System.Drawing.Point(174, 22)
        Me.AddModelButton1.Name = "AddModelButton1"
        Me.AddModelButton1.Size = New System.Drawing.Size(162, 60)
        Me.AddModelButton1.TabIndex = 0
        Me.AddModelButton1.Text = "Add/Edit Mold Model"
        Me.AddModelButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add/Edit User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdminGroupBox
        '
        Me.AdminGroupBox.Controls.Add(Me.AddColorButton2)
        Me.AdminGroupBox.Controls.Add(Me.AddModelButton2)
        Me.AdminGroupBox.Controls.Add(Me.AddEditUserButton)
        Me.AdminGroupBox.Location = New System.Drawing.Point(6, 230)
        Me.AdminGroupBox.Name = "AdminGroupBox"
        Me.AdminGroupBox.Size = New System.Drawing.Size(792, 94)
        Me.AdminGroupBox.TabIndex = 0
        Me.AdminGroupBox.TabStop = False
        Me.AdminGroupBox.Text = "Admin Options"
        '
        'AddColorButton2
        '
        Me.AddColorButton2.Location = New System.Drawing.Point(342, 22)
        Me.AddColorButton2.Name = "AddColorButton2"
        Me.AddColorButton2.Size = New System.Drawing.Size(162, 60)
        Me.AddColorButton2.TabIndex = 0
        Me.AddColorButton2.Text = "Add/Edit Color"
        Me.AddColorButton2.UseVisualStyleBackColor = True
        '
        'AddModelButton2
        '
        Me.AddModelButton2.Location = New System.Drawing.Point(174, 22)
        Me.AddModelButton2.Name = "AddModelButton2"
        Me.AddModelButton2.Size = New System.Drawing.Size(162, 60)
        Me.AddModelButton2.TabIndex = 0
        Me.AddModelButton2.Text = "Add/Edit Mold Model"
        Me.AddModelButton2.UseVisualStyleBackColor = True
        '
        'AddEditUserButton
        '
        Me.AddEditUserButton.Location = New System.Drawing.Point(6, 22)
        Me.AddEditUserButton.Name = "AddEditUserButton"
        Me.AddEditUserButton.Size = New System.Drawing.Size(162, 60)
        Me.AddEditUserButton.TabIndex = 0
        Me.AddEditUserButton.Text = "Add/Edit User"
        Me.AddEditUserButton.UseVisualStyleBackColor = True
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
    Friend WithEvents AddNewDefectButton As Button
    Friend WithEvents SuperGroupBox As GroupBox
    Friend WithEvents AdminGroupBox As GroupBox
    Friend WithEvents AddModelButton2 As Button
    Friend WithEvents AddEditUserButton As Button
    Friend WithEvents CurrentUserTextBox As TextBox
    Friend WithEvents AddModelButton1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AddColorButton1 As Button
    Friend WithEvents AddColorButton2 As Button
End Class
