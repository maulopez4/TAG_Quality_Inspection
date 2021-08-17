<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchEntry
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Search_WorkOrderInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.Search_WorkOrderTextBox = New System.Windows.Forms.TextBox()
        Me.Export_Button = New System.Windows.Forms.Button()
        Me.Print_Button = New System.Windows.Forms.Button()
        Me.Search_WorkOrderLabel = New System.Windows.Forms.Label()
        Me.Search_Button = New System.Windows.Forms.Button()
        Me.SearchResultsDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchResultsDataGrid = New System.Windows.Forms.DataGridView()
        Me.EntryReport_GroupBox = New System.Windows.Forms.GroupBox()
        Me.WorkOrderInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.Search_WorkOrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.Results_ConsecutiveTextBox = New System.Windows.Forms.TextBox()
        Me.WorkStationLabel = New System.Windows.Forms.Label()
        Me.ConsecutiveLabel = New System.Windows.Forms.Label()
        Me.Results_PaintCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Results_MoldSerialTextBox = New System.Windows.Forms.TextBox()
        Me.Results_MoldModelTextBox = New System.Windows.Forms.TextBox()
        Me.Results_MoldBrandTextBox = New System.Windows.Forms.TextBox()
        Me.Results_WorkstationTextBox = New System.Windows.Forms.TextBox()
        Me.Results_SerialNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ModelBrandLabel = New System.Windows.Forms.Label()
        Me.SerialNumberLabel = New System.Windows.Forms.Label()
        Me.MoldSerialLabel = New System.Windows.Forms.Label()
        Me.MoldModelLabel = New System.Windows.Forms.Label()
        Me.Results_WorkOrderTextBox = New System.Windows.Forms.TextBox()
        Me.WorkOrderLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Results_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Results_DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Results_DefectDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.AdditionalDefectNORadioButton = New System.Windows.Forms.RadioButton()
        Me.AdditionalDefectYESRadioButton = New System.Windows.Forms.RadioButton()
        Me.AdditionalDefectsLabel = New System.Windows.Forms.Label()
        Me.DefectLocationLabel = New System.Windows.Forms.Label()
        Me.DefectLabel = New System.Windows.Forms.Label()
        Me.DefectOriginLabel = New System.Windows.Forms.Label()
        Me.ReworkTypeLabel = New System.Windows.Forms.Label()
        Me.Results_Defect_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Results_DefectTextBox = New System.Windows.Forms.TextBox()
        Me.Results_Defect_OriginTextBox = New System.Windows.Forms.TextBox()
        Me.Results_ReworkTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Results_CommentsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Search_WorkOrderInfoGroupBox.SuspendLayout()
        Me.SearchResultsDataGroupBox.SuspendLayout()
        CType(Me.SearchResultsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EntryReport_GroupBox.SuspendLayout()
        Me.WorkOrderInfoGroupBox.SuspendLayout()
        Me.Results_DefectDataGroupBox.SuspendLayout()
        Me.CommentsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Cancel_Button.Location = New System.Drawing.Point(458, 19)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 25)
        Me.Cancel_Button.TabIndex = 25
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Search_WorkOrderInfoGroupBox
        '
        Me.Search_WorkOrderInfoGroupBox.Controls.Add(Me.Search_WorkOrderTextBox)
        Me.Search_WorkOrderInfoGroupBox.Controls.Add(Me.Export_Button)
        Me.Search_WorkOrderInfoGroupBox.Controls.Add(Me.Print_Button)
        Me.Search_WorkOrderInfoGroupBox.Controls.Add(Me.Cancel_Button)
        Me.Search_WorkOrderInfoGroupBox.Controls.Add(Me.Search_WorkOrderLabel)
        Me.Search_WorkOrderInfoGroupBox.Controls.Add(Me.Search_Button)
        Me.Search_WorkOrderInfoGroupBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Search_WorkOrderInfoGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.Search_WorkOrderInfoGroupBox.Name = "Search_WorkOrderInfoGroupBox"
        Me.Search_WorkOrderInfoGroupBox.Size = New System.Drawing.Size(775, 52)
        Me.Search_WorkOrderInfoGroupBox.TabIndex = 22
        Me.Search_WorkOrderInfoGroupBox.TabStop = False
        Me.Search_WorkOrderInfoGroupBox.Text = "Work Order Info:"
        '
        'Search_WorkOrderTextBox
        '
        Me.Search_WorkOrderTextBox.Location = New System.Drawing.Point(148, 19)
        Me.Search_WorkOrderTextBox.Name = "Search_WorkOrderTextBox"
        Me.Search_WorkOrderTextBox.Size = New System.Drawing.Size(198, 25)
        Me.Search_WorkOrderTextBox.TabIndex = 3
        '
        'Export_Button
        '
        Me.Export_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Export_Button.Location = New System.Drawing.Point(669, 18)
        Me.Export_Button.Name = "Export_Button"
        Me.Export_Button.Size = New System.Drawing.Size(100, 25)
        Me.Export_Button.TabIndex = 0
        Me.Export_Button.Text = "Export"
        Me.Export_Button.UseVisualStyleBackColor = True
        Me.Export_Button.Visible = False
        '
        'Print_Button
        '
        Me.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Print_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Print_Button.Location = New System.Drawing.Point(564, 19)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(100, 25)
        Me.Print_Button.TabIndex = 0
        Me.Print_Button.Text = "Print"
        Me.Print_Button.UseVisualStyleBackColor = True
        Me.Print_Button.Visible = False
        '
        'Search_WorkOrderLabel
        '
        Me.Search_WorkOrderLabel.AutoSize = True
        Me.Search_WorkOrderLabel.Location = New System.Drawing.Point(6, 23)
        Me.Search_WorkOrderLabel.Name = "Search_WorkOrderLabel"
        Me.Search_WorkOrderLabel.Size = New System.Drawing.Size(142, 19)
        Me.Search_WorkOrderLabel.TabIndex = 2
        Me.Search_WorkOrderLabel.Text = "W&ork Order Number:"
        '
        'Search_Button
        '
        Me.Search_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Search_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Search_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Search_Button.Location = New System.Drawing.Point(352, 19)
        Me.Search_Button.Name = "Search_Button"
        Me.Search_Button.Size = New System.Drawing.Size(100, 25)
        Me.Search_Button.TabIndex = 24
        Me.Search_Button.Text = "Search Entry"
        Me.Search_Button.UseVisualStyleBackColor = True
        '
        'SearchResultsDataGroupBox
        '
        Me.SearchResultsDataGroupBox.Controls.Add(Me.SearchResultsDataGrid)
        Me.SearchResultsDataGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchResultsDataGroupBox.Location = New System.Drawing.Point(12, 70)
        Me.SearchResultsDataGroupBox.Name = "SearchResultsDataGroupBox"
        Me.SearchResultsDataGroupBox.Size = New System.Drawing.Size(1115, 244)
        Me.SearchResultsDataGroupBox.TabIndex = 26
        Me.SearchResultsDataGroupBox.TabStop = False
        Me.SearchResultsDataGroupBox.Text = "Search Results"
        '
        'SearchResultsDataGrid
        '
        Me.SearchResultsDataGrid.AllowUserToAddRows = False
        Me.SearchResultsDataGrid.AllowUserToDeleteRows = False
        Me.SearchResultsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SearchResultsDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.SearchResultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SearchResultsDataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.SearchResultsDataGrid.Location = New System.Drawing.Point(6, 18)
        Me.SearchResultsDataGrid.Name = "SearchResultsDataGrid"
        Me.SearchResultsDataGrid.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SearchResultsDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.SearchResultsDataGrid.RowHeadersWidth = 30
        Me.SearchResultsDataGrid.RowTemplate.Height = 25
        Me.SearchResultsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SearchResultsDataGrid.Size = New System.Drawing.Size(1100, 220)
        Me.SearchResultsDataGrid.TabIndex = 21
        '
        'EntryReport_GroupBox
        '
        Me.EntryReport_GroupBox.Controls.Add(Me.WorkOrderInfoGroupBox)
        Me.EntryReport_GroupBox.Controls.Add(Me.Results_DefectDataGroupBox)
        Me.EntryReport_GroupBox.Controls.Add(Me.CommentsGroupBox)
        Me.EntryReport_GroupBox.Location = New System.Drawing.Point(13, 320)
        Me.EntryReport_GroupBox.Name = "EntryReport_GroupBox"
        Me.EntryReport_GroupBox.Size = New System.Drawing.Size(1114, 334)
        Me.EntryReport_GroupBox.TabIndex = 27
        Me.EntryReport_GroupBox.TabStop = False
        Me.EntryReport_GroupBox.Text = "Entry Report"
        '
        'WorkOrderInfoGroupBox
        '
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_ConsecutiveTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.WorkStationLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.ConsecutiveLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_PaintCodeTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_MoldSerialTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_MoldModelTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_MoldBrandTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_WorkstationTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_SerialNumberTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.ModelBrandLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.SerialNumberLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.MoldSerialLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.MoldModelLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_WorkOrderTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.WorkOrderLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Label2)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_TimeTextBox)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.TimeLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.DateLabel)
        Me.WorkOrderInfoGroupBox.Controls.Add(Me.Results_DatePicker)
        Me.WorkOrderInfoGroupBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.WorkOrderInfoGroupBox.Location = New System.Drawing.Point(6, 22)
        Me.WorkOrderInfoGroupBox.Name = "WorkOrderInfoGroupBox"
        Me.WorkOrderInfoGroupBox.Size = New System.Drawing.Size(354, 306)
        Me.WorkOrderInfoGroupBox.TabIndex = 28
        Me.WorkOrderInfoGroupBox.TabStop = False
        Me.WorkOrderInfoGroupBox.Text = "Work Order Info:"
        '
        'Search_WorkOrderIDTextBox
        '
        Me.Search_WorkOrderIDTextBox.Enabled = False
        Me.Search_WorkOrderIDTextBox.Location = New System.Drawing.Point(1058, 41)
        Me.Search_WorkOrderIDTextBox.Name = "Search_WorkOrderIDTextBox"
        Me.Search_WorkOrderIDTextBox.Size = New System.Drawing.Size(69, 23)
        Me.Search_WorkOrderIDTextBox.TabIndex = 3
        Me.Search_WorkOrderIDTextBox.Visible = False
        '
        'Results_ConsecutiveTextBox
        '
        Me.Results_ConsecutiveTextBox.Enabled = False
        Me.Results_ConsecutiveTextBox.Location = New System.Drawing.Point(176, 142)
        Me.Results_ConsecutiveTextBox.Name = "Results_ConsecutiveTextBox"
        Me.Results_ConsecutiveTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_ConsecutiveTextBox.TabIndex = 5
        '
        'WorkStationLabel
        '
        Me.WorkStationLabel.AutoSize = True
        Me.WorkStationLabel.Location = New System.Drawing.Point(20, 66)
        Me.WorkStationLabel.Name = "WorkStationLabel"
        Me.WorkStationLabel.Size = New System.Drawing.Size(80, 15)
        Me.WorkStationLabel.TabIndex = 1
        Me.WorkStationLabel.Text = "&Work Station:"
        '
        'ConsecutiveLabel
        '
        Me.ConsecutiveLabel.AutoSize = True
        Me.ConsecutiveLabel.Location = New System.Drawing.Point(176, 117)
        Me.ConsecutiveLabel.Name = "ConsecutiveLabel"
        Me.ConsecutiveLabel.Size = New System.Drawing.Size(121, 15)
        Me.ConsecutiveLabel.TabIndex = 2
        Me.ConsecutiveLabel.Text = "&Consecutive Number:"
        '
        'Results_PaintCodeTextBox
        '
        Me.Results_PaintCodeTextBox.Enabled = False
        Me.Results_PaintCodeTextBox.Location = New System.Drawing.Point(176, 243)
        Me.Results_PaintCodeTextBox.Name = "Results_PaintCodeTextBox"
        Me.Results_PaintCodeTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_PaintCodeTextBox.TabIndex = 4
        '
        'Results_MoldSerialTextBox
        '
        Me.Results_MoldSerialTextBox.Enabled = False
        Me.Results_MoldSerialTextBox.Location = New System.Drawing.Point(19, 243)
        Me.Results_MoldSerialTextBox.Name = "Results_MoldSerialTextBox"
        Me.Results_MoldSerialTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_MoldSerialTextBox.TabIndex = 4
        '
        'Results_MoldModelTextBox
        '
        Me.Results_MoldModelTextBox.Enabled = False
        Me.Results_MoldModelTextBox.Location = New System.Drawing.Point(176, 190)
        Me.Results_MoldModelTextBox.Name = "Results_MoldModelTextBox"
        Me.Results_MoldModelTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_MoldModelTextBox.TabIndex = 4
        '
        'Results_MoldBrandTextBox
        '
        Me.Results_MoldBrandTextBox.Enabled = False
        Me.Results_MoldBrandTextBox.Location = New System.Drawing.Point(20, 190)
        Me.Results_MoldBrandTextBox.Name = "Results_MoldBrandTextBox"
        Me.Results_MoldBrandTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_MoldBrandTextBox.TabIndex = 4
        '
        'Results_WorkstationTextBox
        '
        Me.Results_WorkstationTextBox.Enabled = False
        Me.Results_WorkstationTextBox.Location = New System.Drawing.Point(20, 91)
        Me.Results_WorkstationTextBox.Name = "Results_WorkstationTextBox"
        Me.Results_WorkstationTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_WorkstationTextBox.TabIndex = 4
        '
        'Results_SerialNumberTextBox
        '
        Me.Results_SerialNumberTextBox.Enabled = False
        Me.Results_SerialNumberTextBox.Location = New System.Drawing.Point(19, 142)
        Me.Results_SerialNumberTextBox.Name = "Results_SerialNumberTextBox"
        Me.Results_SerialNumberTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_SerialNumberTextBox.TabIndex = 4
        '
        'ModelBrandLabel
        '
        Me.ModelBrandLabel.AutoSize = True
        Me.ModelBrandLabel.Location = New System.Drawing.Point(20, 168)
        Me.ModelBrandLabel.Name = "ModelBrandLabel"
        Me.ModelBrandLabel.Size = New System.Drawing.Size(72, 15)
        Me.ModelBrandLabel.TabIndex = 2
        Me.ModelBrandLabel.Text = "Mold Brand:"
        '
        'SerialNumberLabel
        '
        Me.SerialNumberLabel.AutoSize = True
        Me.SerialNumberLabel.Location = New System.Drawing.Point(19, 117)
        Me.SerialNumberLabel.Name = "SerialNumberLabel"
        Me.SerialNumberLabel.Size = New System.Drawing.Size(86, 15)
        Me.SerialNumberLabel.TabIndex = 2
        Me.SerialNumberLabel.Text = "&Serial Number:"
        '
        'MoldSerialLabel
        '
        Me.MoldSerialLabel.AutoSize = True
        Me.MoldSerialLabel.Location = New System.Drawing.Point(20, 221)
        Me.MoldSerialLabel.Name = "MoldSerialLabel"
        Me.MoldSerialLabel.Size = New System.Drawing.Size(70, 15)
        Me.MoldSerialLabel.TabIndex = 2
        Me.MoldSerialLabel.Text = "Mold Serial:"
        '
        'MoldModelLabel
        '
        Me.MoldModelLabel.AutoSize = True
        Me.MoldModelLabel.Location = New System.Drawing.Point(176, 168)
        Me.MoldModelLabel.Name = "MoldModelLabel"
        Me.MoldModelLabel.Size = New System.Drawing.Size(72, 15)
        Me.MoldModelLabel.TabIndex = 2
        Me.MoldModelLabel.Text = "&Mold Model"
        '
        'Results_WorkOrderTextBox
        '
        Me.Results_WorkOrderTextBox.Enabled = False
        Me.Results_WorkOrderTextBox.Location = New System.Drawing.Point(176, 91)
        Me.Results_WorkOrderTextBox.Name = "Results_WorkOrderTextBox"
        Me.Results_WorkOrderTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_WorkOrderTextBox.TabIndex = 3
        '
        'WorkOrderLabel
        '
        Me.WorkOrderLabel.AutoSize = True
        Me.WorkOrderLabel.Location = New System.Drawing.Point(176, 66)
        Me.WorkOrderLabel.Name = "WorkOrderLabel"
        Me.WorkOrderLabel.Size = New System.Drawing.Size(119, 15)
        Me.WorkOrderLabel.TabIndex = 2
        Me.WorkOrderLabel.Text = "W&ork Order Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Paint Code:"
        '
        'Results_TimeTextBox
        '
        Me.Results_TimeTextBox.Enabled = False
        Me.Results_TimeTextBox.Location = New System.Drawing.Point(176, 40)
        Me.Results_TimeTextBox.Name = "Results_TimeTextBox"
        Me.Results_TimeTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_TimeTextBox.TabIndex = 0
        Me.Results_TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(176, 18)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(37, 15)
        Me.TimeLabel.TabIndex = 2
        Me.TimeLabel.Text = "&Time:"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(20, 15)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(35, 15)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "&Date:"
        '
        'Results_DatePicker
        '
        Me.Results_DatePicker.CustomFormat = "mm/dd/yyyy"
        Me.Results_DatePicker.Enabled = False
        Me.Results_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Results_DatePicker.Location = New System.Drawing.Point(20, 40)
        Me.Results_DatePicker.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.Results_DatePicker.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.Results_DatePicker.Name = "Results_DatePicker"
        Me.Results_DatePicker.Size = New System.Drawing.Size(150, 23)
        Me.Results_DatePicker.TabIndex = 1
        '
        'Results_DefectDataGroupBox
        '
        Me.Results_DefectDataGroupBox.Controls.Add(Me.AdditionalDefectNORadioButton)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.AdditionalDefectYESRadioButton)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.AdditionalDefectsLabel)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.DefectLocationLabel)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.DefectLabel)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.DefectOriginLabel)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.ReworkTypeLabel)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.Results_Defect_LocationTextBox)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.Results_DefectTextBox)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.Results_Defect_OriginTextBox)
        Me.Results_DefectDataGroupBox.Controls.Add(Me.Results_ReworkTextBox)
        Me.Results_DefectDataGroupBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Results_DefectDataGroupBox.Location = New System.Drawing.Point(366, 22)
        Me.Results_DefectDataGroupBox.Name = "Results_DefectDataGroupBox"
        Me.Results_DefectDataGroupBox.Size = New System.Drawing.Size(199, 306)
        Me.Results_DefectDataGroupBox.TabIndex = 30
        Me.Results_DefectDataGroupBox.TabStop = False
        Me.Results_DefectDataGroupBox.Text = "Defect Data:"
        '
        'AdditionalDefectNORadioButton
        '
        Me.AdditionalDefectNORadioButton.AutoSize = True
        Me.AdditionalDefectNORadioButton.Enabled = False
        Me.AdditionalDefectNORadioButton.Location = New System.Drawing.Point(992, 46)
        Me.AdditionalDefectNORadioButton.Name = "AdditionalDefectNORadioButton"
        Me.AdditionalDefectNORadioButton.Size = New System.Drawing.Size(41, 19)
        Me.AdditionalDefectNORadioButton.TabIndex = 17
        Me.AdditionalDefectNORadioButton.TabStop = True
        Me.AdditionalDefectNORadioButton.Text = "No"
        Me.AdditionalDefectNORadioButton.UseVisualStyleBackColor = True
        Me.AdditionalDefectNORadioButton.Visible = False
        '
        'AdditionalDefectYESRadioButton
        '
        Me.AdditionalDefectYESRadioButton.AutoSize = True
        Me.AdditionalDefectYESRadioButton.Enabled = False
        Me.AdditionalDefectYESRadioButton.Location = New System.Drawing.Point(939, 46)
        Me.AdditionalDefectYESRadioButton.Name = "AdditionalDefectYESRadioButton"
        Me.AdditionalDefectYESRadioButton.Size = New System.Drawing.Size(42, 19)
        Me.AdditionalDefectYESRadioButton.TabIndex = 16
        Me.AdditionalDefectYESRadioButton.TabStop = True
        Me.AdditionalDefectYESRadioButton.Text = "Yes"
        Me.AdditionalDefectYESRadioButton.UseVisualStyleBackColor = True
        Me.AdditionalDefectYESRadioButton.Visible = False
        '
        'AdditionalDefectsLabel
        '
        Me.AdditionalDefectsLabel.AutoSize = True
        Me.AdditionalDefectsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdditionalDefectsLabel.Location = New System.Drawing.Point(925, 18)
        Me.AdditionalDefectsLabel.Name = "AdditionalDefectsLabel"
        Me.AdditionalDefectsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdditionalDefectsLabel.Size = New System.Drawing.Size(127, 17)
        Me.AdditionalDefectsLabel.TabIndex = 1
        Me.AdditionalDefectsLabel.Text = "&Additional Defects?:"
        Me.AdditionalDefectsLabel.Visible = False
        '
        'DefectLocationLabel
        '
        Me.DefectLocationLabel.AutoSize = True
        Me.DefectLocationLabel.Location = New System.Drawing.Point(20, 171)
        Me.DefectLocationLabel.Name = "DefectLocationLabel"
        Me.DefectLocationLabel.Size = New System.Drawing.Size(94, 15)
        Me.DefectLocationLabel.TabIndex = 1
        Me.DefectLocationLabel.Text = "Defect &Location:"
        '
        'DefectLabel
        '
        Me.DefectLabel.AutoSize = True
        Me.DefectLabel.Location = New System.Drawing.Point(20, 118)
        Me.DefectLabel.Name = "DefectLabel"
        Me.DefectLabel.Size = New System.Drawing.Size(45, 15)
        Me.DefectLabel.TabIndex = 1
        Me.DefectLabel.Text = "D&efect:"
        '
        'DefectOriginLabel
        '
        Me.DefectOriginLabel.AutoSize = True
        Me.DefectOriginLabel.Location = New System.Drawing.Point(20, 68)
        Me.DefectOriginLabel.Name = "DefectOriginLabel"
        Me.DefectOriginLabel.Size = New System.Drawing.Size(81, 15)
        Me.DefectOriginLabel.TabIndex = 1
        Me.DefectOriginLabel.Text = "&Defect Origin:"
        '
        'ReworkTypeLabel
        '
        Me.ReworkTypeLabel.AutoSize = True
        Me.ReworkTypeLabel.Location = New System.Drawing.Point(20, 18)
        Me.ReworkTypeLabel.Name = "ReworkTypeLabel"
        Me.ReworkTypeLabel.Size = New System.Drawing.Size(77, 15)
        Me.ReworkTypeLabel.TabIndex = 1
        Me.ReworkTypeLabel.Text = "&Rework Type:"
        '
        'Results_Defect_LocationTextBox
        '
        Me.Results_Defect_LocationTextBox.Enabled = False
        Me.Results_Defect_LocationTextBox.Location = New System.Drawing.Point(20, 193)
        Me.Results_Defect_LocationTextBox.Name = "Results_Defect_LocationTextBox"
        Me.Results_Defect_LocationTextBox.Size = New System.Drawing.Size(152, 23)
        Me.Results_Defect_LocationTextBox.TabIndex = 4
        '
        'Results_DefectTextBox
        '
        Me.Results_DefectTextBox.Enabled = False
        Me.Results_DefectTextBox.Location = New System.Drawing.Point(20, 140)
        Me.Results_DefectTextBox.Name = "Results_DefectTextBox"
        Me.Results_DefectTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_DefectTextBox.TabIndex = 4
        '
        'Results_Defect_OriginTextBox
        '
        Me.Results_Defect_OriginTextBox.Enabled = False
        Me.Results_Defect_OriginTextBox.Location = New System.Drawing.Point(20, 90)
        Me.Results_Defect_OriginTextBox.Name = "Results_Defect_OriginTextBox"
        Me.Results_Defect_OriginTextBox.Size = New System.Drawing.Size(152, 23)
        Me.Results_Defect_OriginTextBox.TabIndex = 4
        '
        'Results_ReworkTextBox
        '
        Me.Results_ReworkTextBox.Enabled = False
        Me.Results_ReworkTextBox.Location = New System.Drawing.Point(20, 40)
        Me.Results_ReworkTextBox.Name = "Results_ReworkTextBox"
        Me.Results_ReworkTextBox.Size = New System.Drawing.Size(150, 23)
        Me.Results_ReworkTextBox.TabIndex = 4
        '
        'CommentsGroupBox
        '
        Me.CommentsGroupBox.Controls.Add(Me.Results_CommentsRichTextBox)
        Me.CommentsGroupBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CommentsGroupBox.Location = New System.Drawing.Point(571, 25)
        Me.CommentsGroupBox.Name = "CommentsGroupBox"
        Me.CommentsGroupBox.Size = New System.Drawing.Size(366, 168)
        Me.CommentsGroupBox.TabIndex = 29
        Me.CommentsGroupBox.TabStop = False
        Me.CommentsGroupBox.Text = "Comments:"
        '
        'Results_CommentsRichTextBox
        '
        Me.Results_CommentsRichTextBox.Enabled = False
        Me.Results_CommentsRichTextBox.Location = New System.Drawing.Point(6, 24)
        Me.Results_CommentsRichTextBox.Name = "Results_CommentsRichTextBox"
        Me.Results_CommentsRichTextBox.Size = New System.Drawing.Size(355, 136)
        Me.Results_CommentsRichTextBox.TabIndex = 18
        Me.Results_CommentsRichTextBox.Text = ""
        '
        'SearchEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 666)
        Me.Controls.Add(Me.Search_WorkOrderIDTextBox)
        Me.Controls.Add(Me.EntryReport_GroupBox)
        Me.Controls.Add(Me.Search_WorkOrderInfoGroupBox)
        Me.Controls.Add(Me.SearchResultsDataGroupBox)
        Me.Name = "SearchEntry"
        Me.Text = "Work Oerder Search"
        Me.Search_WorkOrderInfoGroupBox.ResumeLayout(False)
        Me.Search_WorkOrderInfoGroupBox.PerformLayout()
        Me.SearchResultsDataGroupBox.ResumeLayout(False)
        CType(Me.SearchResultsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EntryReport_GroupBox.ResumeLayout(False)
        Me.WorkOrderInfoGroupBox.ResumeLayout(False)
        Me.WorkOrderInfoGroupBox.PerformLayout()
        Me.Results_DefectDataGroupBox.ResumeLayout(False)
        Me.Results_DefectDataGroupBox.PerformLayout()
        Me.CommentsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Search_WorkOrderInfoGroupBox As GroupBox
    Friend WithEvents Search_WorkOrderTextBox As TextBox
    Friend WithEvents Search_WorkOrderLabel As Label
    Friend WithEvents Search_Button As Button
    Friend WithEvents SearchResultsDataGroupBox As GroupBox
    Friend WithEvents SearchResultsDataGrid As DataGridView
    Friend WithEvents EntryReport_GroupBox As GroupBox
    Friend WithEvents Export_Button As Button
    Friend WithEvents Print_Button As Button
    Friend WithEvents WorkOrderInfoGroupBox As GroupBox
    Friend WithEvents Results_ConsecutiveTextBox As TextBox
    Friend WithEvents WorkStationLabel As Label
    Friend WithEvents ConsecutiveLabel As Label
    Friend WithEvents Results_SerialNumberTextBox As TextBox
    Friend WithEvents ModelBrandLabel As Label
    Friend WithEvents SerialNumberLabel As Label
    Friend WithEvents MoldSerialLabel As Label
    Friend WithEvents MoldModelLabel As Label
    Friend WithEvents Results_WorkOrderTextBox As TextBox
    Friend WithEvents WorkOrderLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Results_TimeTextBox As TextBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents Results_DatePicker As DateTimePicker
    Friend WithEvents CommentsGroupBox As GroupBox
    Friend WithEvents Results_CommentsRichTextBox As RichTextBox
    Friend WithEvents Results_DefectDataGroupBox As GroupBox
    Friend WithEvents AdditionalDefectNORadioButton As RadioButton
    Friend WithEvents AdditionalDefectYESRadioButton As RadioButton
    Friend WithEvents AdditionalDefectsLabel As Label
    Friend WithEvents DefectLocationLabel As Label
    Friend WithEvents DefectLabel As Label
    Friend WithEvents DefectOriginLabel As Label
    Friend WithEvents ReworkTypeLabel As Label
    Friend WithEvents Results_Defect_LocationTextBox As TextBox
    Friend WithEvents Results_DefectTextBox As TextBox
    Friend WithEvents Results_Defect_OriginTextBox As TextBox
    Friend WithEvents Results_ReworkTextBox As TextBox
    Friend WithEvents Results_PaintCodeTextBox As TextBox
    Friend WithEvents Results_MoldSerialTextBox As TextBox
    Friend WithEvents Results_MoldModelTextBox As TextBox
    Friend WithEvents Results_MoldBrandTextBox As TextBox
    Friend WithEvents Results_WorkstationTextBox As TextBox
    Friend WithEvents Search_WorkOrderIDTextBox As TextBox
End Class
