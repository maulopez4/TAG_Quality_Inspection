﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Export_Data
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RejectedDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.RejectedDataGridView = New System.Windows.Forms.DataGridView()
        Me.From_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Till_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.From_Label = New System.Windows.Forms.Label()
        Me.Till_Label = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Export_Button = New System.Windows.Forms.Button()
        Me.GetData_Button = New System.Windows.Forms.Button()
        Me.Selected_ListBox = New System.Windows.Forms.ListBox()
        Me.Select_ListBox = New System.Windows.Forms.ListBox()
        Me.Remove_Button = New System.Windows.Forms.Button()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Date_GroupBox = New System.Windows.Forms.GroupBox()
        Me.RejectedDataGroupBox.SuspendLayout()
        CType(Me.RejectedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Date_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'RejectedDataGroupBox
        '
        Me.RejectedDataGroupBox.Controls.Add(Me.RejectedDataGridView)
        Me.RejectedDataGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0, System.Drawing.GraphicsUnit.Point)
        Me.RejectedDataGroupBox.Location = New System.Drawing.Point(12, 183)
        Me.RejectedDataGroupBox.Name = "RejectedDataGroupBox"
        Me.RejectedDataGroupBox.Size = New System.Drawing.Size(1029, 382)
        Me.RejectedDataGroupBox.TabIndex = 22
        Me.RejectedDataGroupBox.TabStop = False
        Me.RejectedDataGroupBox.Text = "On-Hold WorkOrders"
        '
        'RejectedDataGridView
        '
        Me.RejectedDataGridView.AllowUserToAddRows = False
        Me.RejectedDataGridView.AllowUserToDeleteRows = False
        Me.RejectedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RejectedDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.RejectedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RejectedDataGridView.Location = New System.Drawing.Point(6, 22)
        Me.RejectedDataGridView.Name = "RejectedDataGridView"
        Me.RejectedDataGridView.ReadOnly = True
        Me.RejectedDataGridView.RowHeadersWidth = 30
        Me.RejectedDataGridView.RowTemplate.Height = 25
        Me.RejectedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RejectedDataGridView.Size = New System.Drawing.Size(1017, 354)
        Me.RejectedDataGridView.TabIndex = 21
        '
        'From_DateTimePicker
        '
        Me.From_DateTimePicker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.From_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.From_DateTimePicker.Location = New System.Drawing.Point(6, 76)
        Me.From_DateTimePicker.Name = "From_DateTimePicker"
        Me.From_DateTimePicker.Size = New System.Drawing.Size(150, 23)
        Me.From_DateTimePicker.TabIndex = 23
        '
        'Till_DateTimePicker
        '
        Me.Till_DateTimePicker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Till_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Till_DateTimePicker.Location = New System.Drawing.Point(187, 76)
        Me.Till_DateTimePicker.Name = "Till_DateTimePicker"
        Me.Till_DateTimePicker.Size = New System.Drawing.Size(150, 23)
        Me.Till_DateTimePicker.TabIndex = 23
        '
        'From_Label
        '
        Me.From_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.From_Label.AutoSize = True
        Me.From_Label.Font = New System.Drawing.Font("Segoe UI", 12.0, System.Drawing.GraphicsUnit.Point)
        Me.From_Label.Location = New System.Drawing.Point(6, 46)
        Me.From_Label.Name = "From_Label"
        Me.From_Label.Size = New System.Drawing.Size(50, 21)
        Me.From_Label.TabIndex = 26
        Me.From_Label.Text = "From:"
        '
        'Till_Label
        '
        Me.Till_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Till_Label.AutoSize = True
        Me.Till_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0, System.Drawing.GraphicsUnit.Point)
        Me.Till_Label.Location = New System.Drawing.Point(187, 47)
        Me.Till_Label.Name = "Till_Label"
        Me.Till_Label.Size = New System.Drawing.Size(31, 20)
        Me.Till_Label.TabIndex = 26
        Me.Till_Label.Text = "Till:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Close_Button)
        Me.GroupBox2.Controls.Add(Me.Export_Button)
        Me.GroupBox2.Controls.Add(Me.GetData_Button)
        Me.GroupBox2.Controls.Add(Me.Selected_ListBox)
        Me.GroupBox2.Controls.Add(Me.Select_ListBox)
        Me.GroupBox2.Controls.Add(Me.Remove_Button)
        Me.GroupBox2.Controls.Add(Me.Add_Button)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 166)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Check Points:"
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(401, 130)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(150, 30)
        Me.Close_Button.TabIndex = 1
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Export_Button
        '
        Me.Export_Button.Location = New System.Drawing.Point(401, 76)
        Me.Export_Button.Name = "Export_Button"
        Me.Export_Button.Size = New System.Drawing.Size(150, 30)
        Me.Export_Button.TabIndex = 1
        Me.Export_Button.Text = "2) Export To Excel"
        Me.Export_Button.UseVisualStyleBackColor = True
        '
        'GetData_Button
        '
        Me.GetData_Button.Location = New System.Drawing.Point(401, 22)
        Me.GetData_Button.Name = "GetData_Button"
        Me.GetData_Button.Size = New System.Drawing.Size(150, 30)
        Me.GetData_Button.TabIndex = 1
        Me.GetData_Button.Text = "1) Get Data"
        Me.GetData_Button.UseVisualStyleBackColor = True
        '
        'Selected_ListBox
        '
        Me.Selected_ListBox.FormattingEnabled = True
        Me.Selected_ListBox.ItemHeight = 15
        Me.Selected_ListBox.Location = New System.Drawing.Point(244, 22)
        Me.Selected_ListBox.Name = "Selected_ListBox"
        Me.Selected_ListBox.Size = New System.Drawing.Size(151, 139)
        Me.Selected_ListBox.TabIndex = 29
        '
        'Select_ListBox
        '
        Me.Select_ListBox.Font = New System.Drawing.Font("Segoe UI", 9.0, System.Drawing.GraphicsUnit.Point)
        Me.Select_ListBox.FormattingEnabled = True
        Me.Select_ListBox.ItemHeight = 15
        Me.Select_ListBox.Items.AddRange(New Object() {"CP1", "CP2", "CP3", "CP4", "CP5", "CP6", "CP7"})
        Me.Select_ListBox.Location = New System.Drawing.Point(6, 22)
        Me.Select_ListBox.Name = "Select_ListBox"
        Me.Select_ListBox.Size = New System.Drawing.Size(151, 139)
        Me.Select_ListBox.TabIndex = 29
        '
        'Remove_Button
        '
        Me.Remove_Button.Location = New System.Drawing.Point(163, 101)
        Me.Remove_Button.Name = "Remove_Button"
        Me.Remove_Button.Size = New System.Drawing.Size(75, 23)
        Me.Remove_Button.TabIndex = 1
        Me.Remove_Button.Text = "<< Remove"
        Me.Remove_Button.UseVisualStyleBackColor = True
        '
        'Add_Button
        '
        Me.Add_Button.Location = New System.Drawing.Point(163, 47)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(75, 23)
        Me.Add_Button.TabIndex = 1
        Me.Add_Button.Text = ">>"
        Me.Add_Button.UseVisualStyleBackColor = True
        '
        'Date_GroupBox
        '
        Me.Date_GroupBox.Controls.Add(Me.Till_Label)
        Me.Date_GroupBox.Controls.Add(Me.From_Label)
        Me.Date_GroupBox.Controls.Add(Me.Till_DateTimePicker)
        Me.Date_GroupBox.Controls.Add(Me.From_DateTimePicker)
        Me.Date_GroupBox.Location = New System.Drawing.Point(8, 12)
        Me.Date_GroupBox.Name = "Date_GroupBox"
        Me.Date_GroupBox.Size = New System.Drawing.Size(343, 165)
        Me.Date_GroupBox.TabIndex = 28
        Me.Date_GroupBox.TabStop = False
        Me.Date_GroupBox.Text = "Select Dates:"
        '
        'ExportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 577)
        Me.Controls.Add(Me.Date_GroupBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RejectedDataGroupBox)
        Me.Name = "ExportData"
        Me.Text = "Export Data"
        Me.RejectedDataGroupBox.ResumeLayout(False)
        CType(Me.RejectedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Date_GroupBox.ResumeLayout(False)
        Me.Date_GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RejectedDataGroupBox As GroupBox
    Friend WithEvents RejectedDataGridView As DataGridView
    Friend WithEvents From_DateTimePicker As DateTimePicker
    Friend WithEvents Till_DateTimePicker As DateTimePicker
    Friend WithEvents From_Label As Label
    Friend WithEvents Till_Label As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GetData_Button As Button
    Friend WithEvents Remove_Button As Button
    Friend WithEvents Add_Button As Button
    Friend WithEvents Date_GroupBox As GroupBox
    Friend WithEvents Select_ListBox As ListBox
    Friend WithEvents Selected_ListBox As ListBox
    Friend WithEvents Close_Button As Button
    Friend WithEvents Export_Button As Button
End Class
