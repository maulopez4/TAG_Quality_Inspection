<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddModel
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
        Me.CreateNew_MoldButton = New System.Windows.Forms.Button()
        Me.AddNew_MoldButton = New System.Windows.Forms.Button()
        Me.Delete_MoldButton = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Change_MoldButton = New System.Windows.Forms.Button()
        Me.AUDataGrid = New System.Windows.Forms.DataGridView()
        Me.UserDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.Mold_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Model_BrandTextBox = New System.Windows.Forms.TextBox()
        Me.User_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Mold_DescriptionLabel = New System.Windows.Forms.Label()
        Me.Mold_ColorComboBox = New System.Windows.Forms.ComboBox()
        Me.Model_IdLabel = New System.Windows.Forms.Label()
        Me.Mold_ColorLabel = New System.Windows.Forms.Label()
        Me.Model_BrandLabel = New System.Windows.Forms.Label()
        Me.Model_MoldTextBox = New System.Windows.Forms.TextBox()
        Me.Model_SerialTextBox = New System.Windows.Forms.TextBox()
        Me.Model_SerialLabel = New System.Windows.Forms.Label()
        Me.Model_MoldLabel = New System.Windows.Forms.Label()
        Me.Mold_StatusLabel = New System.Windows.Forms.Label()
        Me.Mold_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.MoldPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureButton1 = New System.Windows.Forms.Button()
        Me.AddImageButton1 = New System.Windows.Forms.Button()
        CType(Me.AUDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDataGroupBox.SuspendLayout()
        CType(Me.MoldPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreateNew_MoldButton
        '
        Me.CreateNew_MoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateNew_MoldButton.Location = New System.Drawing.Point(557, 233)
        Me.CreateNew_MoldButton.Name = "CreateNew_MoldButton"
        Me.CreateNew_MoldButton.Size = New System.Drawing.Size(114, 29)
        Me.CreateNew_MoldButton.TabIndex = 17
        Me.CreateNew_MoldButton.Text = "Create New Mold"
        Me.CreateNew_MoldButton.UseVisualStyleBackColor = True
        '
        'AddNew_MoldButton
        '
        Me.AddNew_MoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew_MoldButton.Location = New System.Drawing.Point(557, 268)
        Me.AddNew_MoldButton.Name = "AddNew_MoldButton"
        Me.AddNew_MoldButton.Size = New System.Drawing.Size(114, 29)
        Me.AddNew_MoldButton.TabIndex = 18
        Me.AddNew_MoldButton.Text = "Add New Mold"
        Me.AddNew_MoldButton.UseVisualStyleBackColor = True
        '
        'Delete_MoldButton
        '
        Me.Delete_MoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Delete_MoldButton.Location = New System.Drawing.Point(674, 304)
        Me.Delete_MoldButton.Name = "Delete_MoldButton"
        Me.Delete_MoldButton.Size = New System.Drawing.Size(114, 44)
        Me.Delete_MoldButton.TabIndex = 20
        Me.Delete_MoldButton.Text = "Delete Selected Mold"
        Me.Delete_MoldButton.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Location = New System.Drawing.Point(674, 269)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(114, 29)
        Me.Cancel_Button.TabIndex = 21
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Change_MoldButton
        '
        Me.Change_MoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Change_MoldButton.Location = New System.Drawing.Point(557, 303)
        Me.Change_MoldButton.Name = "Change_MoldButton"
        Me.Change_MoldButton.Size = New System.Drawing.Size(114, 44)
        Me.Change_MoldButton.TabIndex = 19
        Me.Change_MoldButton.Text = "Change Selected Mold"
        Me.Change_MoldButton.UseVisualStyleBackColor = True
        '
        'AUDataGrid
        '
        Me.AUDataGrid.AllowUserToAddRows = False
        Me.AUDataGrid.AllowUserToDeleteRows = False
        Me.AUDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AUDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AUDataGrid.Location = New System.Drawing.Point(12, 354)
        Me.AUDataGrid.Name = "AUDataGrid"
        Me.AUDataGrid.ReadOnly = True
        Me.AUDataGrid.RowTemplate.Height = 25
        Me.AUDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AUDataGrid.Size = New System.Drawing.Size(776, 260)
        Me.AUDataGrid.TabIndex = 16
        '
        'UserDataGroupBox
        '
        Me.UserDataGroupBox.Controls.Add(Me.PictureButton1)
        Me.UserDataGroupBox.Controls.Add(Me.MoldPictureBox)
        Me.UserDataGroupBox.Controls.Add(Me.AddImageButton1)
        Me.UserDataGroupBox.Controls.Add(Me.Mold_DescriptionTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.Model_BrandTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.User_IdTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.Mold_DescriptionLabel)
        Me.UserDataGroupBox.Controls.Add(Me.Mold_StatusComboBox)
        Me.UserDataGroupBox.Controls.Add(Me.Mold_ColorComboBox)
        Me.UserDataGroupBox.Controls.Add(Me.Mold_StatusLabel)
        Me.UserDataGroupBox.Controls.Add(Me.Model_IdLabel)
        Me.UserDataGroupBox.Controls.Add(Me.Mold_ColorLabel)
        Me.UserDataGroupBox.Controls.Add(Me.Model_BrandLabel)
        Me.UserDataGroupBox.Controls.Add(Me.Model_MoldTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.Model_SerialTextBox)
        Me.UserDataGroupBox.Controls.Add(Me.Model_SerialLabel)
        Me.UserDataGroupBox.Controls.Add(Me.Model_MoldLabel)
        Me.UserDataGroupBox.Location = New System.Drawing.Point(14, 8)
        Me.UserDataGroupBox.Name = "UserDataGroupBox"
        Me.UserDataGroupBox.Size = New System.Drawing.Size(537, 340)
        Me.UserDataGroupBox.TabIndex = 22
        Me.UserDataGroupBox.TabStop = False
        Me.UserDataGroupBox.Text = "User Data"
        '
        'Mold_DescriptionTextBox
        '
        Me.Mold_DescriptionTextBox.Location = New System.Drawing.Point(6, 220)
        Me.Mold_DescriptionTextBox.Name = "Mold_DescriptionTextBox"
        Me.Mold_DescriptionTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Mold_DescriptionTextBox.TabIndex = 5
        Me.Mold_DescriptionTextBox.UseSystemPasswordChar = True
        '
        'Model_BrandTextBox
        '
        Me.Model_BrandTextBox.Location = New System.Drawing.Point(6, 85)
        Me.Model_BrandTextBox.Name = "Model_BrandTextBox"
        Me.Model_BrandTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Model_BrandTextBox.TabIndex = 2
        '
        'User_IdTextBox
        '
        Me.User_IdTextBox.Enabled = False
        Me.User_IdTextBox.Location = New System.Drawing.Point(6, 40)
        Me.User_IdTextBox.Name = "User_IdTextBox"
        Me.User_IdTextBox.Size = New System.Drawing.Size(57, 23)
        Me.User_IdTextBox.TabIndex = 1
        '
        'Mold_DescriptionLabel
        '
        Me.Mold_DescriptionLabel.AutoSize = True
        Me.Mold_DescriptionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mold_DescriptionLabel.Location = New System.Drawing.Point(6, 200)
        Me.Mold_DescriptionLabel.Name = "Mold_DescriptionLabel"
        Me.Mold_DescriptionLabel.Size = New System.Drawing.Size(118, 19)
        Me.Mold_DescriptionLabel.TabIndex = 20
        Me.Mold_DescriptionLabel.Text = "Mold Description"
        '
        'Mold_ColorComboBox
        '
        Me.Mold_ColorComboBox.FormattingEnabled = True
        Me.Mold_ColorComboBox.Location = New System.Drawing.Point(6, 265)
        Me.Mold_ColorComboBox.Name = "Mold_ColorComboBox"
        Me.Mold_ColorComboBox.Size = New System.Drawing.Size(250, 23)
        Me.Mold_ColorComboBox.TabIndex = 6
        '
        'Model_IdLabel
        '
        Me.Model_IdLabel.AutoSize = True
        Me.Model_IdLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Model_IdLabel.Location = New System.Drawing.Point(6, 20)
        Me.Model_IdLabel.Name = "Model_IdLabel"
        Me.Model_IdLabel.Size = New System.Drawing.Size(67, 19)
        Me.Model_IdLabel.TabIndex = 9
        Me.Model_IdLabel.Text = "Model ID"
        '
        'Mold_ColorLabel
        '
        Me.Mold_ColorLabel.AutoSize = True
        Me.Mold_ColorLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mold_ColorLabel.Location = New System.Drawing.Point(6, 245)
        Me.Mold_ColorLabel.Name = "Mold_ColorLabel"
        Me.Mold_ColorLabel.Size = New System.Drawing.Size(80, 19)
        Me.Mold_ColorLabel.TabIndex = 14
        Me.Mold_ColorLabel.Text = "Mold Color"
        '
        'Model_BrandLabel
        '
        Me.Model_BrandLabel.AutoSize = True
        Me.Model_BrandLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Model_BrandLabel.Location = New System.Drawing.Point(5, 65)
        Me.Model_BrandLabel.Name = "Model_BrandLabel"
        Me.Model_BrandLabel.Size = New System.Drawing.Size(92, 19)
        Me.Model_BrandLabel.TabIndex = 9
        Me.Model_BrandLabel.Text = "Model Brand:"
        '
        'Model_MoldTextBox
        '
        Me.Model_MoldTextBox.Location = New System.Drawing.Point(6, 130)
        Me.Model_MoldTextBox.Name = "Model_MoldTextBox"
        Me.Model_MoldTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Model_MoldTextBox.TabIndex = 3
        '
        'Model_SerialTextBox
        '
        Me.Model_SerialTextBox.Location = New System.Drawing.Point(6, 175)
        Me.Model_SerialTextBox.Name = "Model_SerialTextBox"
        Me.Model_SerialTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Model_SerialTextBox.TabIndex = 4
        Me.Model_SerialTextBox.UseSystemPasswordChar = True
        '
        'Model_SerialLabel
        '
        Me.Model_SerialLabel.AutoSize = True
        Me.Model_SerialLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Model_SerialLabel.Location = New System.Drawing.Point(6, 155)
        Me.Model_SerialLabel.Name = "Model_SerialLabel"
        Me.Model_SerialLabel.Size = New System.Drawing.Size(91, 19)
        Me.Model_SerialLabel.TabIndex = 12
        Me.Model_SerialLabel.Text = "Model Serial:"
        '
        'Model_MoldLabel
        '
        Me.Model_MoldLabel.AutoSize = True
        Me.Model_MoldLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Model_MoldLabel.Location = New System.Drawing.Point(6, 110)
        Me.Model_MoldLabel.Name = "Model_MoldLabel"
        Me.Model_MoldLabel.Size = New System.Drawing.Size(89, 19)
        Me.Model_MoldLabel.TabIndex = 7
        Me.Model_MoldLabel.Text = "Model Mold:"
        '
        'Mold_StatusLabel
        '
        Me.Mold_StatusLabel.AutoSize = True
        Me.Mold_StatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mold_StatusLabel.Location = New System.Drawing.Point(6, 291)
        Me.Mold_StatusLabel.Name = "Mold_StatusLabel"
        Me.Mold_StatusLabel.Size = New System.Drawing.Size(85, 19)
        Me.Mold_StatusLabel.TabIndex = 14
        Me.Mold_StatusLabel.Text = "Mold Status"
        '
        'Mold_StatusComboBox
        '
        Me.Mold_StatusComboBox.FormattingEnabled = True
        Me.Mold_StatusComboBox.Location = New System.Drawing.Point(6, 311)
        Me.Mold_StatusComboBox.Name = "Mold_StatusComboBox"
        Me.Mold_StatusComboBox.Size = New System.Drawing.Size(250, 23)
        Me.Mold_StatusComboBox.TabIndex = 6
        '
        'MoldPictureBox
        '
        Me.MoldPictureBox.Location = New System.Drawing.Point(262, 22)
        Me.MoldPictureBox.Name = "MoldPictureBox"
        Me.MoldPictureBox.Size = New System.Drawing.Size(269, 276)
        Me.MoldPictureBox.TabIndex = 21
        Me.MoldPictureBox.TabStop = False
        '
        'PictureButton1
        '
        Me.PictureButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.PictureButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PictureButton1.Location = New System.Drawing.Point(301, 304)
        Me.PictureButton1.Name = "PictureButton1"
        Me.PictureButton1.Size = New System.Drawing.Size(90, 30)
        Me.PictureButton1.TabIndex = 23
        Me.PictureButton1.Text = "Take Picture"
        Me.PictureButton1.UseVisualStyleBackColor = True
        '
        'AddImageButton1
        '
        Me.AddImageButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.AddImageButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddImageButton1.Location = New System.Drawing.Point(412, 304)
        Me.AddImageButton1.Name = "AddImageButton1"
        Me.AddImageButton1.Size = New System.Drawing.Size(90, 30)
        Me.AddImageButton1.TabIndex = 24
        Me.AddImageButton1.Text = "Add Image"
        Me.AddImageButton1.UseVisualStyleBackColor = True
        '
        'AddModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 626)
        Me.Controls.Add(Me.UserDataGroupBox)
        Me.Controls.Add(Me.CreateNew_MoldButton)
        Me.Controls.Add(Me.AddNew_MoldButton)
        Me.Controls.Add(Me.Delete_MoldButton)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Change_MoldButton)
        Me.Controls.Add(Me.AUDataGrid)
        Me.Name = "AddModel"
        Me.Text = "AddModel"
        CType(Me.AUDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDataGroupBox.ResumeLayout(False)
        Me.UserDataGroupBox.PerformLayout()
        CType(Me.MoldPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CreateNew_MoldButton As Button
    Friend WithEvents AddNew_MoldButton As Button
    Friend WithEvents Delete_MoldButton As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Change_MoldButton As Button
    Friend WithEvents AUDataGrid As DataGridView
    Friend WithEvents UserDataGroupBox As GroupBox
    Friend WithEvents Mold_DescriptionTextBox As TextBox
    Friend WithEvents Model_BrandTextBox As TextBox
    Friend WithEvents User_IdTextBox As TextBox
    Friend WithEvents Mold_DescriptionLabel As Label
    Friend WithEvents Mold_ColorComboBox As ComboBox
    Friend WithEvents Model_IdLabel As Label
    Friend WithEvents Mold_ColorLabel As Label
    Friend WithEvents Model_BrandLabel As Label
    Friend WithEvents Model_MoldTextBox As TextBox
    Friend WithEvents Model_SerialTextBox As TextBox
    Friend WithEvents Model_SerialLabel As Label
    Friend WithEvents Model_MoldLabel As Label
    Friend WithEvents Mold_StatusComboBox As ComboBox
    Friend WithEvents Mold_StatusLabel As Label
    Friend WithEvents MoldPictureBox As PictureBox
    Friend WithEvents PictureButton1 As Button
    Friend WithEvents AddImageButton1 As Button
End Class
