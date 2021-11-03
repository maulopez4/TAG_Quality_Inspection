<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents Login_UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Login_PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Login_OKButton As System.Windows.Forms.Button
    Friend WithEvents Login_CancelButton As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Login_UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Login_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Login_OKButton = New System.Windows.Forms.Button()
        Me.Login_CancelButton = New System.Windows.Forms.Button()
        Me.Login_ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.LoginWorkstationComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(233, 218)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.GraphicsUnit.Point)
        Me.UsernameLabel.Location = New System.Drawing.Point(253, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Username:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.GraphicsUnit.Point)
        Me.PasswordLabel.Location = New System.Drawing.Point(252, 61)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login_UsernameTextBox
        '
        Me.Login_UsernameTextBox.Location = New System.Drawing.Point(252, 35)
        Me.Login_UsernameTextBox.Name = "Login_UsernameTextBox"
        Me.Login_UsernameTextBox.Size = New System.Drawing.Size(220, 23)
        Me.Login_UsernameTextBox.TabIndex = 1
        '
        'Login_PasswordTextBox
        '
        Me.Login_PasswordTextBox.Location = New System.Drawing.Point(252, 87)
        Me.Login_PasswordTextBox.Name = "Login_PasswordTextBox"
        Me.Login_PasswordTextBox.Size = New System.Drawing.Size(220, 23)
        Me.Login_PasswordTextBox.TabIndex = 3
        Me.Login_PasswordTextBox.UseSystemPasswordChar = True
        '
        'Login_OKButton
        '
        Me.Login_OKButton.Location = New System.Drawing.Point(252, 195)
        Me.Login_OKButton.Name = "Login_OKButton"
        Me.Login_OKButton.Size = New System.Drawing.Size(94, 23)
        Me.Login_OKButton.TabIndex = 4
        Me.Login_OKButton.Text = "&OK"
        '
        'Login_CancelButton
        '
        Me.Login_CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Login_CancelButton.Location = New System.Drawing.Point(377, 195)
        Me.Login_CancelButton.Name = "Login_CancelButton"
        Me.Login_CancelButton.Size = New System.Drawing.Size(94, 23)
        Me.Login_CancelButton.TabIndex = 5
        Me.Login_CancelButton.Text = "&Cancel"
        '
        'Login_ShowPasswordCheckBox
        '
        Me.Login_ShowPasswordCheckBox.AutoSize = True
        Me.Login_ShowPasswordCheckBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.GraphicsUnit.Point)
        Me.Login_ShowPasswordCheckBox.Location = New System.Drawing.Point(253, 116)
        Me.Login_ShowPasswordCheckBox.Name = "Login_ShowPasswordCheckBox"
        Me.Login_ShowPasswordCheckBox.Size = New System.Drawing.Size(122, 21)
        Me.Login_ShowPasswordCheckBox.TabIndex = 6
        Me.Login_ShowPasswordCheckBox.Text = "Show Password"
        Me.Login_ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'LoginWorkstationComboBox
        '
        Me.LoginWorkstationComboBox.FormattingEnabled = True
        Me.LoginWorkstationComboBox.Location = New System.Drawing.Point(252, 166)
        Me.LoginWorkstationComboBox.Name = "LoginWorkstationComboBox"
        Me.LoginWorkstationComboBox.Size = New System.Drawing.Size(219, 23)
        Me.LoginWorkstationComboBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(251, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Work Station:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginForm
        '
        Me.AcceptButton = Me.Login_OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Login_CancelButton
        Me.ClientSize = New System.Drawing.Size(493, 228)
        Me.Controls.Add(Me.LoginWorkstationComboBox)
        Me.Controls.Add(Me.Login_ShowPasswordCheckBox)
        Me.Controls.Add(Me.Login_CancelButton)
        Me.Controls.Add(Me.Login_OKButton)
        Me.Controls.Add(Me.Login_PasswordTextBox)
        Me.Controls.Add(Me.Login_UsernameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login V1.09.08"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login_ShowPasswordCheckBox As CheckBox
    Friend WithEvents LoginWorkstationComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
