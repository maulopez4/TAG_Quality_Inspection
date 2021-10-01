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
        Me.Paintcode_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Paintcode_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Paintcolor_DescriptionLabel = New System.Windows.Forms.Label()
        Me.Paintcolor_IDLabel = New System.Windows.Forms.Label()
        Me.Paintcolor_BrandLabel = New System.Windows.Forms.Label()
        Me.Paintcode_BrandTextBox = New System.Windows.Forms.TextBox()
        Me.Paintcode_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Paintcode_CodeLabel = New System.Windows.Forms.Label()
        Me.CreateNew_Button = New System.Windows.Forms.Button()
        Me.AddNew_Button = New System.Windows.Forms.Button()
        Me.DeleteSelected_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.EditSelected_Button = New System.Windows.Forms.Button()
        Me.UpdateSelected_Button = New System.Windows.Forms.Button()
        CType(Me.PCDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaintcodeDataGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PCDataGrid
        '
        Me.PCDataGrid.AllowUserToAddRows = False
        Me.PCDataGrid.AllowUserToDeleteRows = False
        Me.PCDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PCDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PCDataGrid.Location = New System.Drawing.Point(12, 239)
        Me.PCDataGrid.Name = "PCDataGrid"
        Me.PCDataGrid.ReadOnly = True
        Me.PCDataGrid.RowTemplate.Height = 25
        Me.PCDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PCDataGrid.Size = New System.Drawing.Size(582, 375)
        Me.PCDataGrid.TabIndex = 17
        '
        'PaintcodeDataGroupBox
        '
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcode_DescriptionTextBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcode_IdTextBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor_DescriptionLabel)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor_IDLabel)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcolor_BrandLabel)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcode_BrandTextBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcode_CodeTextBox)
        Me.PaintcodeDataGroupBox.Controls.Add(Me.Paintcode_CodeLabel)
        Me.PaintcodeDataGroupBox.Location = New System.Drawing.Point(12, 8)
        Me.PaintcodeDataGroupBox.Name = "PaintcodeDataGroupBox"
        Me.PaintcodeDataGroupBox.Size = New System.Drawing.Size(263, 225)
        Me.PaintcodeDataGroupBox.TabIndex = 23
        Me.PaintcodeDataGroupBox.TabStop = False
        Me.PaintcodeDataGroupBox.Text = "Paint Code Data"
        '
        'Paintcode_DescriptionTextBox
        '
        Me.Paintcode_DescriptionTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.Paintcode_DescriptionTextBox.Location = New System.Drawing.Point(6, 183)
        Me.Paintcode_DescriptionTextBox.Name = "Paintcode_DescriptionTextBox"
        Me.Paintcode_DescriptionTextBox.Size = New System.Drawing.Size(250, 23)
        Me.Paintcode_DescriptionTextBox.TabIndex = 5
        '
        'Paintcode_IdTextBox
        '
        Me.Paintcode_IdTextBox.Enabled = False
        Me.Paintcode_IdTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.Paintcode_IdTextBox.Location = New System.Drawing.Point(6, 39)
        Me.Paintcode_IdTextBox.Name = "Paintcode_IdTextBox"
        Me.Paintcode_IdTextBox.Size = New System.Drawing.Size(57, 23)
        Me.Paintcode_IdTextBox.TabIndex = 1
        '
        'Paintcolor_DescriptionLabel
        '
        Me.Paintcolor_DescriptionLabel.AutoSize = True
        Me.Paintcolor_DescriptionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.GraphicsUnit.Point)
        Me.Paintcolor_DescriptionLabel.Location = New System.Drawing.Point(6, 161)
        Me.Paintcolor_DescriptionLabel.Name = "Paintcolor_DescriptionLabel"
        Me.Paintcolor_DescriptionLabel.Size = New System.Drawing.Size(155, 19)
        Me.Paintcolor_DescriptionLabel.TabIndex = 20
        Me.Paintcolor_DescriptionLabel.Text = "Paint Color Description"
        '
        'Paintcolor_IDLabel
        '
        Me.Paintcolor_IDLabel.AutoSize = True
        Me.Paintcolor_IDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.GraphicsUnit.Point)
        Me.Paintcolor_IDLabel.Location = New System.Drawing.Point(6, 17)
        Me.Paintcolor_IDLabel.Name = "Paintcolor_IDLabel"
        Me.Paintcolor_IDLabel.Size = New System.Drawing.Size(97, 19)
        Me.Paintcolor_IDLabel.TabIndex = 9
        Me.Paintcolor_IDLabel.Text = "Paint Color ID"
        '
        'Paintcolor_BrandLabel
        '
        Me.Paintcolor_BrandLabel.AutoSize = True
        Me.Paintcolor_BrandLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.GraphicsUnit.Point)
        Me.Paintcolor_BrandLabel.Location = New System.Drawing.Point(6, 65)
        Me.Paintcolor_BrandLabel.Name = "Paintcolor_BrandLabel"
        Me.Paintcolor_BrandLabel.Size = New System.Drawing.Size(122, 19)
        Me.Paintcolor_BrandLabel.TabIndex = 9
        Me.Paintcolor_BrandLabel.Text = "Paint Color Brand:"
        '
        'Paintcode_BrandTextBox
        '
        Me.Paintcode_BrandTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.Paintcode_BrandTextBox.Location = New System.Drawing.Point(6, 87)
        Me.Paintcode_BrandTextBox.Name = "Paintcode_BrandTextBox"
        Me.Paintcode_BrandTextBox.Size = New System.Drawing.Size(125, 23)
        Me.Paintcode_BrandTextBox.TabIndex = 3
        '
        'Paintcode_CodeTextBox
        '
        Me.Paintcode_CodeTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.Paintcode_CodeTextBox.Location = New System.Drawing.Point(6, 135)
        Me.Paintcode_CodeTextBox.Name = "Paintcode_CodeTextBox"
        Me.Paintcode_CodeTextBox.Size = New System.Drawing.Size(125, 23)
        Me.Paintcode_CodeTextBox.TabIndex = 3
        '
        'Paintcode_CodeLabel
        '
        Me.Paintcode_CodeLabel.AutoSize = True
        Me.Paintcode_CodeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.GraphicsUnit.Point)
        Me.Paintcode_CodeLabel.Location = New System.Drawing.Point(5, 113)
        Me.Paintcode_CodeLabel.Name = "Paintcode_CodeLabel"
        Me.Paintcode_CodeLabel.Size = New System.Drawing.Size(118, 19)
        Me.Paintcode_CodeLabel.TabIndex = 7
        Me.Paintcode_CodeLabel.Text = "Paint Color Code:"
        '
        'CreateNew_Button
        '
        Me.CreateNew_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateNew_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.CreateNew_Button.Location = New System.Drawing.Point(281, 65)
        Me.CreateNew_Button.Name = "CreateNew_Button"
        Me.CreateNew_Button.Size = New System.Drawing.Size(100, 50)
        Me.CreateNew_Button.TabIndex = 24
        Me.CreateNew_Button.Text = "Create New Paint Color"
        Me.CreateNew_Button.UseVisualStyleBackColor = True
        '
        'AddNew_Button
        '
        Me.AddNew_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.AddNew_Button.Location = New System.Drawing.Point(387, 65)
        Me.AddNew_Button.Name = "AddNew_Button"
        Me.AddNew_Button.Size = New System.Drawing.Size(100, 50)
        Me.AddNew_Button.TabIndex = 25
        Me.AddNew_Button.Text = "Add New Paint Color"
        Me.AddNew_Button.UseVisualStyleBackColor = True
        '
        'DeleteSelected_Button
        '
        Me.DeleteSelected_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteSelected_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.DeleteSelected_Button.Location = New System.Drawing.Point(281, 183)
        Me.DeleteSelected_Button.Name = "DeleteSelected_Button"
        Me.DeleteSelected_Button.Size = New System.Drawing.Size(100, 50)
        Me.DeleteSelected_Button.TabIndex = 27
        Me.DeleteSelected_Button.Text = "Delete Selected Paint Color"
        Me.DeleteSelected_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.Cancel_Button.Location = New System.Drawing.Point(387, 183)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 50)
        Me.Cancel_Button.TabIndex = 28
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'EditSelected_Button
        '
        Me.EditSelected_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditSelected_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.EditSelected_Button.Location = New System.Drawing.Point(281, 121)
        Me.EditSelected_Button.Name = "EditSelected_Button"
        Me.EditSelected_Button.Size = New System.Drawing.Size(100, 56)
        Me.EditSelected_Button.TabIndex = 26
        Me.EditSelected_Button.Text = "Edit Selected Paint Color"
        Me.EditSelected_Button.UseVisualStyleBackColor = True
        '
        'UpdateSelected_Button
        '
        Me.UpdateSelected_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateSelected_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.GraphicsUnit.Point)
        Me.UpdateSelected_Button.Location = New System.Drawing.Point(387, 121)
        Me.UpdateSelected_Button.Name = "UpdateSelected_Button"
        Me.UpdateSelected_Button.Size = New System.Drawing.Size(100, 57)
        Me.UpdateSelected_Button.TabIndex = 26
        Me.UpdateSelected_Button.Text = "Update Selected Paint Color"
        Me.UpdateSelected_Button.UseVisualStyleBackColor = True
        '
        'AddPaintcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 626)
        Me.Controls.Add(Me.CreateNew_Button)
        Me.Controls.Add(Me.AddNew_Button)
        Me.Controls.Add(Me.DeleteSelected_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.UpdateSelected_Button)
        Me.Controls.Add(Me.EditSelected_Button)
        Me.Controls.Add(Me.PaintcodeDataGroupBox)
        Me.Controls.Add(Me.PCDataGrid)
        Me.Name = "AddPaintcode"
        Me.Text = "AddPaintcode"
        CType(Me.PCDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaintcodeDataGroupBox.ResumeLayout(False)
        Me.PaintcodeDataGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PCDataGrid As DataGridView
    Friend WithEvents PaintcodeDataGroupBox As GroupBox
    Friend WithEvents Paintcode_DescriptionTextBox As TextBox
    Friend WithEvents Paintcode_IdTextBox As TextBox
    Friend WithEvents Paintcolor_DescriptionLabel As Label
    Friend WithEvents Paintcolor_IDLabel As Label
    Friend WithEvents Paintcolor_BrandLabel As Label
    Friend WithEvents Paintcode_CodeTextBox As TextBox
    Friend WithEvents Paintcode_CodeLabel As Label
    Friend WithEvents CreateNew_Button As Button
    Friend WithEvents AddNew_Button As Button
    Friend WithEvents DeleteSelected_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents EditSelected_Button As Button
    Friend WithEvents Paintcode_BrandTextBox As TextBox
    Friend WithEvents UpdateSelected_Button As Button
End Class
