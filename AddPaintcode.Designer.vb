<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPaintcode
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
        Me.PCDataGrid = New System.Windows.Forms.DataGridView()
        Me.PaintcodeDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.Paintcolor__BrandComboBox = New System.Windows.Forms.ComboBox()
        Me.Take_PictureButton = New System.Windows.Forms.Button()
        Me.MoldPictureBox = New System.Windows.Forms.PictureBox()
        Me.Add_ImageButton = New System.Windows.Forms.Button()
        Me.Paintcolor__DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Paintcolor_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Paintcolor_DescriptionLabel = New System.Windows.Forms.Label()
        Me.Paintcolor__StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Paintcolor_StatusLabel = New System.Windows.Forms.Label()
        Me.Paintcolor_IDLabel = New System.Windows.Forms.Label()
        Me.Paintcolor_BrandLabel = New System.Windows.Forms.Label()
        Me.Paintcolor__CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Paintcode_CodeLabel = New System.Windows.Forms.Label()
        Me.CreateNew_PaintcolorButton = New System.Windows.Forms.Button()
        Me.AddNew_PaintcolorButton = New System.Windows.Forms.Button()
        Me.DeleteSelected_PaintcolorButton = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ChangeSelected_PaintcolorButton = New System.Windows.Forms.Button()
        CType(Me.PCDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaintcodeDataGroupBox.SuspendLayout()
        CType(Me.MoldPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PCDataGrid
        '
        Me.PCDataGrid.AllowUserToAddRows = False
        Me.PCDataGrid.AllowUserToDeleteRows = False
        Me.PCDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PCDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PCDataGrid.Location = New System.Drawing.Point(12, 302)
        Me.PCDataGrid.Name = "PCDataGrid"
        Me.PCDataGrid.ReadOnly = True
        Me.PCDataGrid.RowTemplate.Height = 25
        Me.PCDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PCDataGrid.Size = New System.Drawing.Size(776, 312)
        Me.PCDataGrid.TabIndex = 17
        '
        'PaintcodeDataGroupBox
        '
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor__BrandComboBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Take_PictureButton)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.MoldPictureBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Add_ImageButton)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor__DescriptionTextBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor_IdTextBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor_DescriptionLabel)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor__StatusComboBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor_StatusLabel)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor_IDLabel)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor_BrandLabel)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor__CodeTextBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcode_CodeLabel)
        Me.PaintcodeDataGroupBox.Location = New System.Drawing.Point(12, 8)
        Me.PaintcodeDataGroupBox.Name = "PaintcodeDataGroupBox"
        Me.PaintcodeDataGroupBox.Size = New System.Drawing.Size(537, 288)
        Me.PaintcodeDataGroupBox.TabIndex = 23
        Me.PaintcodeDataGroupBox.TabStop = False
        Me.PaintcodeDataGroupBox.Text = "Paint Code Data"
        '
        'Paintcolor__BrandComboBox
        '
        Me.Paintcolor__BrandComboBox.FormattingEnabled = True
        Me.Paintcolor__BrandComboBox.Location = New System.Drawing.Point(6, 85)
        Me.Paintcolor__BrandComboBox.Name = "Paintcolor__BrandComboBox"
        Me.Paintcolor__BrandComboBox.Size = New System.Drawing.Size(249, 23)
        Me.Paintcolor__BrandComboBox.TabIndex = 25
        '
        'Take_PictureButton
        '
        Me.Take_PictureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Take_PictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Take_PictureButton.Location = New System.Drawing.Point(330, 251)
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
        Me.MoldPictureBox.Size = New System.Drawing.Size(269, 223)
        Me.MoldPictureBox.TabIndex = 21
        Me.MoldPictureBox.TabStop = False
        '
        'Add_ImageButton
        '
        Me.Add_ImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Add_ImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Add_ImageButton.Location = New System.Drawing.Point(441, 251)
        Me.Add_ImageButton.Name = "Add_ImageButton"
        Me.Add_ImageButton.Size = New System.Drawing.Size(90, 30)
        Me.Add_ImageButton.TabIndex = 24
        Me.Add_ImageButton.Text = "Add Image"
        Me.Add_ImageButton.UseVisualStyleBackColor = True
        '
        'Paintcolor__DescriptionTextBox
        '
        Me.Paintcolor__DescriptionTextBox.Location = New System.Drawing.Point(6, 176)
        Me.Paintcolor__DescriptionTextBox.Name = "Paintcolor__DescriptionTextBox"
        Me.Paintcolor__DescriptionTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Paintcolor__DescriptionTextBox.TabIndex = 5
        Me.Paintcolor__DescriptionTextBox.UseSystemPasswordChar = True
        '
        'Paintcolor_IdTextBox
        '
        Me.Paintcolor_IdTextBox.Enabled = False
        Me.Paintcolor_IdTextBox.Location = New System.Drawing.Point(6, 40)
        Me.Paintcolor_IdTextBox.Name = "Paintcolor_IdTextBox"
        Me.Paintcolor_IdTextBox.Size = New System.Drawing.Size(57, 23)
        Me.Paintcolor_IdTextBox.TabIndex = 1
        '
        'Paintcolor_DescriptionLabel
        '
        Me.Paintcolor_DescriptionLabel.AutoSize = True
        Me.Paintcolor_DescriptionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Paintcolor_DescriptionLabel.Location = New System.Drawing.Point(6, 156)
        Me.Paintcolor_DescriptionLabel.Name = "Paintcolor_DescriptionLabel"
        Me.Paintcolor_DescriptionLabel.Size = New System.Drawing.Size(155, 19)
        Me.Paintcolor_DescriptionLabel.TabIndex = 20
        Me.Paintcolor_DescriptionLabel.Text = "Paint Color Description"
        '
        'Paintcolor__StatusComboBox
        '
        Me.Paintcolor__StatusComboBox.FormattingEnabled = True
        Me.Paintcolor__StatusComboBox.Location = New System.Drawing.Point(6, 222)
        Me.Paintcolor__StatusComboBox.Name = "Paintcolor__StatusComboBox"
        Me.Paintcolor__StatusComboBox.Size = New System.Drawing.Size(250, 23)
        Me.Paintcolor__StatusComboBox.TabIndex = 6
        '
        'Paintcolor_StatusLabel
        '
        Me.Paintcolor_StatusLabel.AutoSize = True
        Me.Paintcolor_StatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Paintcolor_StatusLabel.Location = New System.Drawing.Point(6, 202)
        Me.Paintcolor_StatusLabel.Name = "Paintcolor_StatusLabel"
        Me.Paintcolor_StatusLabel.Size = New System.Drawing.Size(125, 19)
        Me.Paintcolor_StatusLabel.TabIndex = 14
        Me.Paintcolor_StatusLabel.Text = "Paint Color Status:"
        '
        'Paintcolor_IDLabel
        '
        Me.Paintcolor_IDLabel.AutoSize = True
        Me.Paintcolor_IDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Paintcolor_IDLabel.Location = New System.Drawing.Point(6, 20)
        Me.Paintcolor_IDLabel.Name = "Paintcolor_IDLabel"
        Me.Paintcolor_IDLabel.Size = New System.Drawing.Size(97, 19)
        Me.Paintcolor_IDLabel.TabIndex = 9
        Me.Paintcolor_IDLabel.Text = "Paint Color ID"
        '
        'Paintcolor_BrandLabel
        '
        Me.Paintcolor_BrandLabel.AutoSize = True
        Me.Paintcolor_BrandLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Paintcolor_BrandLabel.Location = New System.Drawing.Point(5, 65)
        Me.Paintcolor_BrandLabel.Name = "Paintcolor_BrandLabel"
        Me.Paintcolor_BrandLabel.Size = New System.Drawing.Size(122, 19)
        Me.Paintcolor_BrandLabel.TabIndex = 9
        Me.Paintcolor_BrandLabel.Text = "Paint Color Brand:"
        '
        'Paintcolor__CodeTextBox
        '
        Me.Paintcolor__CodeTextBox.Location = New System.Drawing.Point(6, 130)
        Me.Paintcolor__CodeTextBox.Name = "Paintcolor__CodeTextBox"
        Me.Paintcolor__CodeTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Paintcolor__CodeTextBox.TabIndex = 3
        '
        'Paintcode_CodeLabel
        '
        Me.Paintcode_CodeLabel.AutoSize = True
        Me.Paintcode_CodeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Paintcode_CodeLabel.Location = New System.Drawing.Point(6, 110)
        Me.Paintcode_CodeLabel.Name = "Paintcode_CodeLabel"
        Me.Paintcode_CodeLabel.Size = New System.Drawing.Size(118, 19)
        Me.Paintcode_CodeLabel.TabIndex = 7
        Me.Paintcode_CodeLabel.Text = "Paint Color Code:"
        '
        'CreateNew_PaintcolorButton
        '
        Me.CreateNew_PaintcolorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateNew_PaintcolorButton.Location = New System.Drawing.Point(555, 178)
        Me.CreateNew_PaintcolorButton.Name = "CreateNew_PaintcolorButton"
        Me.CreateNew_PaintcolorButton.Size = New System.Drawing.Size(114, 29)
        Me.CreateNew_PaintcolorButton.TabIndex = 24
        Me.CreateNew_PaintcolorButton.Text = "Create New Paint Color"
        Me.CreateNew_PaintcolorButton.UseVisualStyleBackColor = True
        '
        'AddNew_PaintcolorButton
        '
        Me.AddNew_PaintcolorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew_PaintcolorButton.Location = New System.Drawing.Point(555, 210)
        Me.AddNew_PaintcolorButton.Name = "AddNew_PaintcolorButton"
        Me.AddNew_PaintcolorButton.Size = New System.Drawing.Size(114, 29)
        Me.AddNew_PaintcolorButton.TabIndex = 25
        Me.AddNew_PaintcolorButton.Text = "Add New Paint Color"
        Me.AddNew_PaintcolorButton.UseVisualStyleBackColor = True
        '
        'DeleteSelected_PaintcolorButton
        '
        Me.DeleteSelected_PaintcolorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteSelected_PaintcolorButton.Location = New System.Drawing.Point(672, 245)
        Me.DeleteSelected_PaintcolorButton.Name = "DeleteSelected_PaintcolorButton"
        Me.DeleteSelected_PaintcolorButton.Size = New System.Drawing.Size(114, 44)
        Me.DeleteSelected_PaintcolorButton.TabIndex = 27
        Me.DeleteSelected_PaintcolorButton.Text = "Delete Selected Paint Color"
        Me.DeleteSelected_PaintcolorButton.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Location = New System.Drawing.Point(672, 210)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(114, 29)
        Me.Cancel_Button.TabIndex = 28
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'ChangeSelected_PaintcolorButton
        '
        Me.ChangeSelected_PaintcolorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangeSelected_PaintcolorButton.Location = New System.Drawing.Point(555, 245)
        Me.ChangeSelected_PaintcolorButton.Name = "ChangeSelected_PaintcolorButton"
        Me.ChangeSelected_PaintcolorButton.Size = New System.Drawing.Size(114, 44)
        Me.ChangeSelected_PaintcolorButton.TabIndex = 26
        Me.ChangeSelected_PaintcolorButton.Text = "Change Selected Paint Color"
        Me.ChangeSelected_PaintcolorButton.UseVisualStyleBackColor = True
        '
        'AddPaintcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 626)
        Me.Controls.Add(Me.CreateNew_PaintcolorButton)
        Me.Controls.Add(Me.AddNew_PaintcolorButton)
        Me.Controls.Add(Me.DeleteSelected_PaintcolorButton)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.ChangeSelected_PaintcolorButton)
        Me.Controls.Add(Me.PaintcodeDataGroupBox)
        Me.Controls.Add(Me.PCDataGrid)
        Me.Name = "AddPaintcode"
        Me.Text = "AddPaintcode"
        CType(Me.PCDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaintcodeDataGroupBox.ResumeLayout(False)
        Me.PaintcodeDataGroupBox.PerformLayout()
        CType(Me.MoldPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PCDataGrid As DataGridView
    Friend WithEvents PaintcodeDataGroupBox As GroupBox
    Friend WithEvents Paintcolor__BrandComboBox As ComboBox
    Friend WithEvents Take_PictureButton As Button
    Friend WithEvents MoldPictureBox As PictureBox
    Friend WithEvents Add_ImageButton As Button
    Friend WithEvents Paintcolor__DescriptionTextBox As TextBox
    Friend WithEvents Paintcolor_IdTextBox As TextBox
    Friend WithEvents Paintcolor_DescriptionLabel As Label
    Friend WithEvents Paintcolor__StatusComboBox As ComboBox
    Friend WithEvents Paintcolor_StatusLabel As Label
    Friend WithEvents Paintcolor_IDLabel As Label
    Friend WithEvents Paintcolor_BrandLabel As Label
    Friend WithEvents Paintcolor__CodeTextBox As TextBox
    Friend WithEvents Paintcode_CodeLabel As Label
    Friend WithEvents CreateNew_PaintcolorButton As Button
    Friend WithEvents AddNew_PaintcolorButton As Button
    Friend WithEvents DeleteSelected_PaintcolorButton As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents ChangeSelected_PaintcolorButton As Button
End Class
