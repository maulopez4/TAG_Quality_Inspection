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
        Me.DeleteSelected_MoldButton = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ChangeSelected_MoldButton = New System.Windows.Forms.Button()
        Me.MLDataGrid = New System.Windows.Forms.DataGridView()
        Me.ModelDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.Model_BrandComboBox = New System.Windows.Forms.ComboBox()
        Me.Take_PictureButton = New System.Windows.Forms.Button()
        Me.MoldPictureBox = New System.Windows.Forms.PictureBox()
        Me.Add_ImageButton = New System.Windows.Forms.Button()
        Me.Model_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Model_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Mold_DescriptionLabel = New System.Windows.Forms.Label()
        Me.Model_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Model_ColorComboBox = New System.Windows.Forms.ComboBox()
        Me.Mold_StatusLabel = New System.Windows.Forms.Label()
        Me.Model_IdLabel = New System.Windows.Forms.Label()
        Me.Mold_ColorLabel = New System.Windows.Forms.Label()
        Me.Model_BrandLabel = New System.Windows.Forms.Label()
        Me.Model_MoldTextBox = New System.Windows.Forms.TextBox()
        Me.Model_SerialTextBox = New System.Windows.Forms.TextBox()
        Me.Model_SerialLabel = New System.Windows.Forms.Label()
        Me.Model_MoldLabel = New System.Windows.Forms.Label()
        CType(Me.MLDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ModelDataGroupBox.SuspendLayout()
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
        'DeleteSelected_MoldButton
        '
        Me.DeleteSelected_MoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteSelected_MoldButton.Location = New System.Drawing.Point(674, 304)
        Me.DeleteSelected_MoldButton.Name = "DeleteSelected_MoldButton"
        Me.DeleteSelected_MoldButton.Size = New System.Drawing.Size(114, 44)
        Me.DeleteSelected_MoldButton.TabIndex = 20
        Me.DeleteSelected_MoldButton.Text = "Delete Selected Mold"
        Me.DeleteSelected_MoldButton.UseVisualStyleBackColor = True
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
        'ChangeSelected_MoldButton
        '
        Me.ChangeSelected_MoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangeSelected_MoldButton.Location = New System.Drawing.Point(557, 303)
        Me.ChangeSelected_MoldButton.Name = "ChangeSelected_MoldButton"
        Me.ChangeSelected_MoldButton.Size = New System.Drawing.Size(114, 44)
        Me.ChangeSelected_MoldButton.TabIndex = 19
        Me.ChangeSelected_MoldButton.Text = "Change Selected Mold"
        Me.ChangeSelected_MoldButton.UseVisualStyleBackColor = True
        '
        'MLDataGrid
        '
        Me.MLDataGrid.AllowUserToAddRows = False
        Me.MLDataGrid.AllowUserToDeleteRows = False
        Me.MLDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MLDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MLDataGrid.Location = New System.Drawing.Point(12, 354)
        Me.MLDataGrid.Name = "MLDataGrid"
        Me.MLDataGrid.ReadOnly = True
        Me.MLDataGrid.RowTemplate.Height = 25
        Me.MLDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MLDataGrid.Size = New System.Drawing.Size(776, 260)
        Me.MLDataGrid.TabIndex = 16
        '
        'ModelDataGroupBox
        '
        Me.ModelDataGroupBox.Controls.Add(Me.Model_BrandComboBox)
        Me.ModelDataGroupBox.Controls.Add(Me.Take_PictureButton)
        Me.ModelDataGroupBox.Controls.Add(Me.MoldPictureBox)
        Me.ModelDataGroupBox.Controls.Add(Me.Add_ImageButton)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_DescriptionTextBox)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_IdTextBox)
        Me.ModelDataGroupBox.Controls.Add(Me.Mold_DescriptionLabel)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_StatusComboBox)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_ColorComboBox)
        Me.ModelDataGroupBox.Controls.Add(Me.Mold_StatusLabel)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_IdLabel)
        Me.ModelDataGroupBox.Controls.Add(Me.Mold_ColorLabel)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_BrandLabel)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_MoldTextBox)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_SerialTextBox)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_SerialLabel)
        Me.ModelDataGroupBox.Controls.Add(Me.Model_MoldLabel)
        Me.ModelDataGroupBox.Location = New System.Drawing.Point(14, 8)
        Me.ModelDataGroupBox.Name = "ModelDataGroupBox"
        Me.ModelDataGroupBox.Size = New System.Drawing.Size(537, 340)
        Me.ModelDataGroupBox.TabIndex = 22
        Me.ModelDataGroupBox.TabStop = False
        Me.ModelDataGroupBox.Text = "Mold Data"
        '
        'Model_BrandComboBox
        '
        Me.Model_BrandComboBox.FormattingEnabled = True
        Me.Model_BrandComboBox.Location = New System.Drawing.Point(6, 85)
        Me.Model_BrandComboBox.Name = "Model_BrandComboBox"
        Me.Model_BrandComboBox.Size = New System.Drawing.Size(249, 23)
        Me.Model_BrandComboBox.TabIndex = 25
        '
        'Take_PictureButton
        '
        Me.Take_PictureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Take_PictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Take_PictureButton.Location = New System.Drawing.Point(301, 304)
        Me.Take_PictureButton.Name = "Take_PictureButton"
        Me.Take_PictureButton.Size = New System.Drawing.Size(90, 30)
        Me.Take_PictureButton.TabIndex = 23
        Me.Take_PictureButton.Text = "Take Picture"
        Me.Take_PictureButton.UseVisualStyleBackColor = True
        '
        'MoldPictureBox
        '
        Me.MoldPictureBox.Location = New System.Drawing.Point(262, 22)
        Me.MoldPictureBox.Name = "MoldPictureBox"
        Me.MoldPictureBox.Size = New System.Drawing.Size(269, 276)
        Me.MoldPictureBox.TabIndex = 21
        Me.MoldPictureBox.TabStop = False
        '
        'Add_ImageButton
        '
        Me.Add_ImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Add_ImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Add_ImageButton.Location = New System.Drawing.Point(412, 304)
        Me.Add_ImageButton.Name = "Add_ImageButton"
        Me.Add_ImageButton.Size = New System.Drawing.Size(90, 30)
        Me.Add_ImageButton.TabIndex = 24
        Me.Add_ImageButton.Text = "Add Image"
        Me.Add_ImageButton.UseVisualStyleBackColor = True
        '
        'Model_DescriptionTextBox
        '
        Me.Model_DescriptionTextBox.Location = New System.Drawing.Point(6, 220)
        Me.Model_DescriptionTextBox.Name = "Model_DescriptionTextBox"
        Me.Model_DescriptionTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Model_DescriptionTextBox.TabIndex = 5
        Me.Model_DescriptionTextBox.UseSystemPasswordChar = True
        '
        'Model_IdTextBox
        '
        Me.Model_IdTextBox.Enabled = False
        Me.Model_IdTextBox.Location = New System.Drawing.Point(6, 40)
        Me.Model_IdTextBox.Name = "Model_IdTextBox"
        Me.Model_IdTextBox.Size = New System.Drawing.Size(57, 23)
        Me.Model_IdTextBox.TabIndex = 1
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
        'Model_StatusComboBox
        '
        Me.Model_StatusComboBox.FormattingEnabled = True
        Me.Model_StatusComboBox.Location = New System.Drawing.Point(6, 311)
        Me.Model_StatusComboBox.Name = "Model_StatusComboBox"
        Me.Model_StatusComboBox.Size = New System.Drawing.Size(250, 23)
        Me.Model_StatusComboBox.TabIndex = 6
        '
        'Model_ColorComboBox
        '
        Me.Model_ColorComboBox.FormattingEnabled = True
        Me.Model_ColorComboBox.Location = New System.Drawing.Point(6, 265)
        Me.Model_ColorComboBox.Name = "Model_ColorComboBox"
        Me.Model_ColorComboBox.Size = New System.Drawing.Size(250, 23)
        Me.Model_ColorComboBox.TabIndex = 6
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
        'AddModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 626)
        Me.Controls.Add(Me.ModelDataGroupBox)
        Me.Controls.Add(Me.CreateNew_MoldButton)
        Me.Controls.Add(Me.AddNew_MoldButton)
        Me.Controls.Add(Me.DeleteSelected_MoldButton)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.ChangeSelected_MoldButton)
        Me.Controls.Add(Me.MLDataGrid)
        Me.Name = "AddModel"
        Me.Text = "AddModel"
        CType(Me.MLDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ModelDataGroupBox.ResumeLayout(False)
        Me.ModelDataGroupBox.PerformLayout()
        CType(Me.MoldPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CreateNew_MoldButton As Button
    Friend WithEvents AddNew_MoldButton As Button
    Friend WithEvents DeleteSelected_MoldButton As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents ChangeSelected_MoldButton As Button
    Friend WithEvents MLDataGrid As DataGridView
    Friend WithEvents ModelDataGroupBox As GroupBox
    Friend WithEvents Model_DescriptionTextBox As TextBox
    Friend WithEvents Model_IdTextBox As TextBox
    Friend WithEvents Mold_DescriptionLabel As Label
    Friend WithEvents Model_ColorComboBox As ComboBox
    Friend WithEvents Model_IdLabel As Label
    Friend WithEvents Mold_ColorLabel As Label
    Friend WithEvents Model_BrandLabel As Label
    Friend WithEvents Model_MoldTextBox As TextBox
    Friend WithEvents Model_SerialTextBox As TextBox
    Friend WithEvents Model_SerialLabel As Label
    Friend WithEvents Model_MoldLabel As Label
    Friend WithEvents Model_StatusComboBox As ComboBox
    Friend WithEvents Mold_StatusLabel As Label
    Friend WithEvents MoldPictureBox As PictureBox
    Friend WithEvents Take_PictureButton As Button
    Friend WithEvents Add_ImageButton As Button
    Friend WithEvents Model_BrandComboBox As ComboBox
End Class
