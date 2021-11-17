Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports Spire.Xls
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class AddEntry
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    Public Shared Property WorkOrderValue As Object
    Dim arrImage1() As Byte
    Dim arrImage2() As Byte
    Dim arrImage3() As Byte
    Dim WO_User As String = LoginForm.login_user
    Dim Current_Workstation As String
    Dim WO_Workstation As String = LoginForm.login_workstation
    Dim WO_Text As String
    Dim WO_Id As String
    Dim WO_Number As String
    Dim WO_Brand As String
    Dim WO_Product_Line As String
    Dim WO_Model As String
    Dim WO_Serial As String
    Dim WO_Paintcode As String
    Dim WO_Status As String
    Dim WO_Defect_Origin As String
    Dim WO_Defect_Origin_Text As String
    Dim WO_Defect As String
    Dim WO_Location As String
    Dim WO_Rework As String
    Dim WO_Additional_Defects As Boolean
    Dim WO_Comments As String
    Private Sub AddEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub
    Private Sub Init_Form()
        'Load Workstation DropDown Menu 
        Using WScommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim WSadapter As New MySqlDataAdapter(WScommand)
            Dim WStable As New DataTable()
            Dim WS = WSadapter.Fill(WStable)
            WorkStationComboBox.DataSource = WStable
            WorkStationComboBox.ValueMember = "workstation_code"
            WorkStationComboBox.DisplayMember = "workstation_description"
        End Using
        'Load Mold Brand DropDown Menu 
        Using MBcommand As New MySqlCommand("SELECT DISTINCT `models_brand` FROM `models` WHERE `models_status` = '1'", connection)
            Dim MBadapter As New MySqlDataAdapter(MBcommand)
            Dim MBtable As New DataTable()
            Dim MB = MBadapter.Fill(MBtable)
            MoldBrandComboBox.DataSource = MBtable
            MoldBrandComboBox.ValueMember = "models_brand"
            MoldBrandComboBox.DisplayMember = "models_brand"
        End Using
        'Load Product Line DropDown Menu 
        Using PLcommand As New MySqlCommand("Select DISTINCT `brands_prefix` FROM `brands`", connection)
            Dim PLadapter As New MySqlDataAdapter(PLcommand)
            Dim PLtable As New DataTable()
            PLadapter.Fill(PLtable)
            ProductLineComboBox.DataSource = PLtable
            ProductLineComboBox.ValueMember = "brands_prefix"
            ProductLineComboBox.DisplayMember = "brands_prefix"
        End Using
        'Load Model DropDown Menu 
        Using MMcommand As New MySqlCommand("Select DISTINCT `models_mold` FROM `models`", connection)
            Dim MMadapter As New MySqlDataAdapter(MMcommand)
            Dim MMtable As New DataTable()
            MMadapter.Fill(MMtable)
            MoldModelComboBox.DataSource = MMtable
            MoldModelComboBox.ValueMember = "models_mold"
            MoldModelComboBox.DisplayMember = "models_mold"
        End Using
        'Load Serial DropDown Menu 
        Using MScommand As New MySqlCommand("Select DISTINCT `models_serial` FROM `models`", connection)
            Dim MSadapter As New MySqlDataAdapter(MScommand)
            Dim MStable As New DataTable()
            MSadapter.Fill(MStable)
            MoldSerialComboBox.DataSource = MStable
            MoldSerialComboBox.ValueMember = "models_serial"
            MoldSerialComboBox.DisplayMember = "models_serial"
        End Using
        'Load Paintcode DropDown Menu
        Using PCcommand As New MySqlCommand("SELECT `paintcode_code`, `paintcode_description` FROM `paintcode`", connection)
            Dim PCadapter As New MySqlDataAdapter(PCcommand)
            Dim PCtable As New DataTable()
            PCadapter.Fill(PCtable)
            PaintCodeComboBox.DataSource = PCtable
            PaintCodeComboBox.ValueMember = "paintcode_code"
            PaintCodeComboBox.DisplayMember = "paintcode_code"
        End Using
        'Load Defect Origin DropDown Menu
        Using DOcommand As New MySqlCommand("Select `defect_origins_workstation_code`, `defect_origins_origin` FROM `defect_origins` WHERE `defect_origins_status` = '1'", connection)
            Dim DOadapter As New MySqlDataAdapter(DOcommand)
            Dim DOtable As New DataTable()
            DOadapter.Fill(DOtable)
            DefectOriginComboBox.DataSource = DOtable
            DefectOriginComboBox.ValueMember = "defect_origins_origin"
            DefectOriginComboBox.DisplayMember = "defect_origins_origin"
        End Using
        'Load Defect DropDown Menu
        Using DCcommand As New MySqlCommand("SELECT `defects_code`, `defects_description` FROM `defects`", connection)
            Dim DCadapter As New MySqlDataAdapter(DCcommand)
            Dim DCtable As New DataTable()
            DCadapter.Fill(DCtable)
            DefectComboBox.DataSource = DCtable
            DefectComboBox.ValueMember = "defects_code"
            DefectComboBox.DisplayMember = "defects_description"
        End Using
        'Load Defect Location DropDown Menu
        Using DLcommand As New MySqlCommand("SELECT `locations_code`, `locations_description` FROM `locations`", connection)
            Dim DLadapter As New MySqlDataAdapter(DLcommand)
            Dim DLtable As New DataTable()
            Dim DL = DLadapter.Fill(DLtable)
            DefectLocationComboBox.DataSource = DLtable
            DefectLocationComboBox.ValueMember = "locations_code"
            DefectLocationComboBox.DisplayMember = "locations_description"
        End Using
        'Load Rework DropDown Menu
        Using RWcommand As New MySqlCommand("SELECT `rework_code`, `rework_description` FROM `rework`", connection)
            Dim RWadapter As New MySqlDataAdapter(RWcommand)
            Dim RWtable As New DataTable()
            Dim RW = RWadapter.Fill(RWtable)
            ReworkComboBox.DataSource = RWtable
            ReworkComboBox.ValueMember = "rework_code"
            ReworkComboBox.DisplayMember = "rework_description"
        End Using
        Clean_Form()
    End Sub
    Private Sub Clean_Form()
        WorkStationComboBox.Enabled = True
        WorkStationComboBox.SelectedValue = WO_Workstation

        NewEntry_Button.Enabled = True
        EditSelected_Button.Enabled = False
        SearchWO_Button.Enabled = True
        ClearSearchWO_Button.Enabled = True

        WorkOrderTextBox.Enabled = False
        MoldBrandComboBox.Enabled = False
        ProductLineComboBox.Enabled = False
        MoldModelComboBox.Enabled = False
        MoldSerialComboBox.Enabled = False
        PaintCodeComboBox.Enabled = False

        WorkOrderTextBox.Text = Nothing
        MoldBrandComboBox.SelectedItem = Nothing
        ProductLineComboBox.SelectedItem = Nothing
        MoldModelComboBox.SelectedItem = Nothing
        MoldSerialComboBox.SelectedItem = Nothing
        PaintCodeComboBox.SelectedItem = Nothing
        PaintcodeDescription_ComboBox.SelectedItem = Nothing

        DefectOriginComboBox.Enabled = False
        DefectComboBox.Enabled = False
        DefectLocationComboBox.Enabled = False
        ReworkComboBox.Enabled = False

        Approved_Button.Enabled = False
        ReportDefect_Button.Enabled = False

        ReportedDataGroupBox.Visible = True
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = False

        ReportedDataGridView.Enabled = False
        ReportedDataGridView.Visible = False
        Filter_Label.Enabled = False
        Filter_Label.Visible = False
        FilterView_ComboBox.Enabled = False
        FilterView_ComboBox.Visible = False

    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'Set Time
        TimeTextBox.Text = Format(Now, "HH:mm:ss")
    End Sub
    'Private Sub AddEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        WorkStationComboBox.Enabled = True
    '        ReportedDataGroupBox.Visible = True
    '        DefectDataGroupBox.Visible = False
    '    End If
    'End Sub
    Friend Shared Function GetWorkOrder()
        Return WorkOrderValue
    End Function
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Close()
    End Sub
    Private Sub WorkStationComboBox_ValueChanged(sender As Object, e As EventArgs) Handles WorkStationComboBox.SelectionChangeCommitted
        WO_Workstation = WorkStationComboBox.SelectedValue.ToString
    End Sub
    Private Sub WorkOrderTextBox_TextChanged(sender As Object, e As EventArgs) Handles WorkOrderTextBox.TextChanged
        WO_Number = WorkOrderTextBox.Text
    End Sub
    Private Sub MoldBrandComboBox_ValueChanged(sender As Object, e As EventArgs) Handles MoldBrandComboBox.SelectionChangeCommitted
        WO_Brand = MoldBrandComboBox.SelectedValue.ToString
        With ProductLineComboBox
            Using PLcommand As New MySqlCommand("Select DISTINCT `brands_prefix` FROM `brands` WHERE `brands_name` = @models_brand  ORDER BY `brands_prefix` asc", connection)
                PLcommand.Parameters.Add("@models_brand", MySqlDbType.String).Value = WO_Brand
                Dim PLadapter As New MySqlDataAdapter(PLcommand)
                Dim PLtable As New DataTable()
                PLadapter.Fill(PLtable)
                ProductLineComboBox.DataSource = PLtable
                ProductLineComboBox.ValueMember = "brands_prefix"
                ProductLineComboBox.DisplayMember = "brands_prefix"
            End Using
        End With
    End Sub
    Private Sub ProductLineComboBox_ValueChanged(sender As Object, e As EventArgs) Handles ProductLineComboBox.SelectionChangeCommitted
        WO_Product_Line = ProductLineComboBox.SelectedValue.ToString
        'With MoldModelComboBox
        '    Using MMcommand As New MySqlCommand("Select DISTINCT `models_mold` FROM `models` WHERE `models_prefix` = @product_line  ORDER BY `models_mold` asc", connection)
        '        MMcommand.Parameters.Add("@product_line", MySqlDbType.String).Value = WO_Product_Line
        '        Dim MMadapter As New MySqlDataAdapter(MMcommand)
        '        Dim MMtable As New DataTable()
        '        MMadapter.Fill(MMtable)
        '        MoldModelComboBox.DataSource = MMtable
        '        MoldModelComboBox.ValueMember = "models_mold"
        '        MoldModelComboBox.DisplayMember = "models_mold"
        '    End Using
        'End With
    End Sub
    Private Sub MoldModelComboBox_ValueChanged(sender As Object, e As EventArgs) Handles MoldModelComboBox.SelectionChangeCommitted
        WO_Model = MoldModelComboBox.SelectedValue.ToString
        'Dim models_mold As String = WO_Model
        'With MoldSerialComboBox
        '    Using Mcommand As New MySqlCommand("Select `models_serial` FROM `models` WHERE `models_mold` = @models_mold", connection)
        '        Mcommand.Parameters.Add("@models_mold", MySqlDbType.String).Value = models_mold
        '        Dim Madapter As New MySqlDataAdapter(Mcommand)
        '        Dim Mtable As New DataTable()
        '        Madapter.Fill(Mtable)
        '        MoldSerialComboBox.DataSource = Mtable
        '        MoldSerialComboBox.ValueMember = "models_serial"
        '        MoldSerialComboBox.DisplayMember = "models_serial"
        '    End Using
        'End With
    End Sub
    Private Sub MoldSerialComboBox_ValueChanged(sender As Object, e As EventArgs) Handles MoldSerialComboBox.SelectionChangeCommitted
        WO_Serial = MoldSerialComboBox.SelectedValue.ToString
    End Sub
    Private Sub PaintCodeComboBox_ValueChanged(sender As Object, e As EventArgs) Handles PaintCodeComboBox.SelectionChangeCommitted
        WO_Paintcode = PaintCodeComboBox.SelectedValue.ToString
        Dim paint_code As String = PaintCodeComboBox.Text.ToString
        With PaintcodeDescription_ComboBox
            Using PDcommand As New MySqlCommand("Select `paintcode_description` FROM `paintcode` WHERE `paintcode_code` = @Paint_Code", connection)
                PDcommand.Parameters.Add("@Paint_Code", MySqlDbType.String).Value = paint_code
                Dim PDadapter As New MySqlDataAdapter(PDcommand)
                Dim PDtable As New DataTable()
                PDadapter.Fill(PDtable)
                PaintcodeDescription_ComboBox.DataSource = PDtable
                PaintcodeDescription_ComboBox.ValueMember = "paintcode_description"
                PaintcodeDescription_ComboBox.DisplayMember = "paintcode_description"
            End Using
        End With
    End Sub
    Private Sub DefectOriginComboBox_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DefectOriginComboBox.SelectedValueChanged
        'Private Sub DefectOriginComboBox_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DefectOriginComboBox.SelectionChangeCommitted
        WO_Defect_Origin_Text = DefectOriginComboBox.Text
        WO_Text = WorkStationComboBox.Text
        '--------------------------------------
        With DefectComboBox
            Using DFcommand As New MySqlCommand("SELECT `defects_code`, `defects_description` FROM `defects` WHERE `defects_workstation` = @defects_origin", connection)
                DFcommand.Parameters.Add("@defects_origin", MySqlDbType.String).Value = WO_Defect_Origin_Text
                Dim DFadapter As New MySqlDataAdapter(DFcommand)
                Dim DFtable As New DataTable()
                DFadapter.Fill(DFtable)
                DefectComboBox.DataSource = DFtable
                DefectComboBox.ValueMember = "defects_code"
                DefectComboBox.DisplayMember = "defects_description"
                DefectComboBox.Refresh()
            End Using
        End With
        '------------------------------------------------
        With ReworkComboBox
            Using RWcommand As New MySqlCommand("SELECT `rework_code`, `rework_description` FROM `rework` WHERE `rework_apply_to_code` = @rework_apply_to_code", connection)
                RWcommand.Parameters.Add("@rework_apply_to_code", MySqlDbType.String).Value = WO_Workstation
                Dim RWadapter As New MySqlDataAdapter(RWcommand)
                Dim RWtable As New DataTable()
                Dim RW = RWadapter.Fill(RWtable)
                ReworkComboBox.DataSource = RWtable
                ReworkComboBox.ValueMember = "rework_code"
                ReworkComboBox.DisplayMember = "rework_description"
                ReworkComboBox.Refresh()
            End Using
        End With
        DefectComboBox.Enabled = True
        DefectLocationComboBox.Enabled = True
        ReworkComboBox.Enabled = True
    End Sub
    Private Sub DefectComboBox_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DefectComboBox.SelectionChangeCommitted
        WO_Defect = DefectComboBox.SelectedValue.ToString
    End Sub
    Private Sub DefectLocationComboBox_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DefectLocationComboBox.SelectionChangeCommitted
        WO_Location = DefectLocationComboBox.SelectedValue.ToString
    End Sub
    Private Sub ReworkComboBox_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ReworkComboBox.SelectionChangeCommitted
        WO_Rework = ReworkComboBox.SelectedValue.ToString
    End Sub
    Private Sub ReportedDataGridView_Load()
        FilterView_ComboBox.SelectedIndex = 0
        ReportedDataGridView.DataSource = Create_DataGridView()
        DataGridViewHeaders()
        ReportedDataGridView.ClearSelection()
    End Sub
    Private Sub ReportedDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ReportedDataGridView.SelectionChanged
        If ReportedDataGridView.SelectedRows.Count = 1 Then
            WorkOrderId_TextBox.Text = ReportedDataGridView.Item("workorder_id", ReportedDataGridView.SelectedRows(0).Index).Value
            'WorkStationComboBox.SelectedValue = ReportedDataGridView.Item("workorder_workstation", ReportedDataGridView.SelectedRows(0).Index).Value            WorkOrderTextBox.Text = ReportedDataGridView.Item("workorder_number", ReportedDataGridView.SelectedRows(0).Index).Value
            MoldBrandComboBox.SelectedValue = ReportedDataGridView.Item("workorder_moldbrand", ReportedDataGridView.SelectedRows(0).Index).Value
            ProductLineComboBox.SelectedValue = ReportedDataGridView.Item("workorder_productline", ReportedDataGridView.SelectedRows(0).Index).Value
            MoldModelComboBox.SelectedValue = ReportedDataGridView.Item("workorder_moldmodel", ReportedDataGridView.SelectedRows(0).Index).Value
            MoldSerialComboBox.SelectedValue = ReportedDataGridView.Item("workorder_moldserial", ReportedDataGridView.SelectedRows(0).Index).Value
            PaintCodeComboBox.SelectedValue = ReportedDataGridView.Item("workorder_paintcode", ReportedDataGridView.SelectedRows(0).Index).Value
            DefectOriginComboBox.SelectedValue = ReportedDataGridView.Item("workorder_defect_origin", ReportedDataGridView.SelectedRows(0).Index).Value
            DefectComboBox.SelectedValue = ReportedDataGridView.Item("workorder_defect", ReportedDataGridView.SelectedRows(0).Index).Value
            DefectLocationComboBox.SelectedValue = ReportedDataGridView.Item("workorder_defect_location", ReportedDataGridView.SelectedRows(0).Index).Value
            ReworkComboBox.SelectedValue = ReportedDataGridView.Item("workorder_rework", ReportedDataGridView.SelectedRows(0).Index).Value
            Dim Status_Name As String = ReportedDataGridView.Item("workorder_status", ReportedDataGridView.SelectedRows(0).Index).Value.ToString
            Status_Label.Text = Status_Name
            Status_PictureBox.Image = My.Resources.ResourceManager.GetObject(Status_Name)
            Status_PictureBox.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
    Private Function Create_DataGridView() As DataTable
        Dim From As String = From_DateTimePicker.Value.ToString("yyyy-MM-dd")
        Dim Till As String = Till_DateTimePicker.Value.ToString("yyyy-MM-dd")
        Dim RJcommand As New MySqlCommand("SELECT 
        `workorder_id`, 
        `workorder_date`, 
        `workorder_time`, 
        `workorder_reportedby`, 
        `workorder_workstation`, 
        `workstation_description`, 
        `workorder_number`,
        `workorder_moldbrand`, 
        `workorder_productline`, 
        `workorder_moldmodel`, 
        `workorder_moldserial`, 
        `workorder_paintcode`, 
        `workorder_defect_origin`, 
        `origin_description`, 
        `workorder_defect`, 
        `defects_description`, 
        `workorder_defect_location`, 
        `workorder_rework`,
        `rework_description`, 
        `workorder_status`, 
        `workorder_comments` 
        FROM `workorder` 
        INNER JOIN `defects` ON `workorder_defect` = `defects_code` 
        INNER JOIN `workstation` ON `workorder_workstation` = `workstation_code`
        INNER JOIN `origin` ON `workorder_defect_origin` = `origin_code`
        INNER JOIN `rework` ON `workorder_rework` = `rework_code`
        WHERE `workorder_workstation` = @workorder_workstation
        AND `workorder_date` >= CAST('" & From & "' AS DATE) 
        AND `workorder_date` <= CAST('" & Till & "' AS DATE)
        AND `workorder_rework` NOT LIKE CONCAT('%','00')
        AND `workorder_number` LIKE CONCAT (@Search, '%')
        AND `workorder_status` LIKE CONCAT (@Filter, '%')
        ORDER BY `workorder_date` DESC, `workorder_time` DESC", connection)
        RJcommand.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WO_Workstation
        RJcommand.Parameters.AddWithValue("@Search", SearchWO_TextBox.Text.Trim())
        RJcommand.Parameters.AddWithValue("@Filter", Filter_Show())

        Dim RJadapter As New MySqlDataAdapter(RJcommand)
        Dim RJtable As New DataTable()
        Dim RJ = RJadapter.Fill(RJtable)
        Return RJtable
    End Function
    Public Function Filter_Show()
        Dim case_view As String = FilterView_ComboBox.SelectedItem.ToString
        Dim filter_view As String
        Select Case case_view
            Case "Approved Only"
                filter_view = "APPROVED"
                Return filter_view
            Case "Repaired Only"
                filter_view = "REPAIRED"
                Return filter_view
            Case "Reported Only"
                filter_view = "REPORTED"
                Return filter_view
            Case Else
                filter_view = ""
                Return filter_view
        End Select
    End Function
    Private Sub ClearSearchWO_Button_Click(sender As Object, e As EventArgs) Handles ClearSearchWO_Button.Click
        SearchWO_TextBox.Clear()
        FilterView_ComboBox.SelectedIndex = 0
        ReportedDataGridView.DataSource = Nothing

        ReportedDataGridView.Enabled = False
        ReportedDataGridView.Visible = False
        Filter_Label.Enabled = False
        Filter_Label.Visible = False
        FilterView_ComboBox.Enabled = False
        FilterView_ComboBox.Visible = False
        ReportedDataGridView.ClearSelection()
        Clean_Form()
    End Sub
    Private Sub SearchWO_Button_Click(sender As Object, e As EventArgs) Handles SearchWO_Button.Click
        ReportedDataGridView_Load()
        ReportedDataGridView.Enabled = True
        ReportedDataGridView.Visible = True
        Filter_Label.Enabled = True
        Filter_Label.Visible = True
        FilterView_ComboBox.Enabled = True
        FilterView_ComboBox.Visible = True
        ReportedDataGridView.ClearSelection()
    End Sub
    Private Sub FilterView_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterView_ComboBox.SelectedIndexChanged
        ReportedDataGridView.DataSource = Create_DataGridView()
        DataGridViewHeaders()
        ReportedDataGridView.ClearSelection()
    End Sub
    Private Sub DataGridViewHeaders()
        With ReportedDataGridView
            .RowHeadersVisible = True
            .Columns(0).HeaderCell.Value = "ID"
            .Columns(0).Visible = False
            .Columns(1).HeaderCell.Value = "Date"
            .Columns(2).HeaderCell.Value = "Time"
            .Columns(3).HeaderCell.Value = "Reported By"
            .Columns(4).HeaderCell.Value = "Workstation Code"
            .Columns(4).Visible = False
            .Columns(5).HeaderCell.Value = "Reported From"
            .Columns(6).HeaderCell.Value = "Work Order"
            .Columns(7).HeaderCell.Value = "Brand"
            .Columns(8).HeaderCell.Value = "Product Line"
            .Columns(9).HeaderCell.Value = "Model"
            .Columns(10).HeaderCell.Value = "Serial"
            .Columns(11).HeaderCell.Value = "Paint Code"
            .Columns(12).HeaderCell.Value = "Defect Origin Code"
            .Columns(12).Visible = False
            .Columns(13).HeaderCell.Value = "Defect Origin"
            .Columns(14).HeaderCell.Value = "Defect Code"
            .Columns(14).Visible = False
            .Columns(15).HeaderCell.Value = "Defect Description"
            .Columns(16).HeaderCell.Value = "Defect Location"
            .Columns(17).HeaderCell.Value = "Rework Code"
            .Columns(17).Visible = False
            .Columns(18).HeaderCell.Value = "Rework Description"
            .Columns(19).HeaderCell.Value = "Work Order Status"
            .Columns(20).HeaderCell.Value = "Comments"
        End With
    End Sub
    Private Sub PictureButton1_Click(sender As Object, e As EventArgs) Handles PictureButton1.Click
        Dim newForm As New AddPicture()
        newForm.Show()
    End Sub
    Private Sub PictureButton2_Click(sender As Object, e As EventArgs) Handles PictureButton2.Click
        Dim newForm As New AddPicture()
        newForm.Show()
    End Sub
    Private Sub PictureButton3_Click(sender As Object, e As EventArgs) Handles PictureButton3.Click
        Dim newForm As New AddPicture()
        newForm.Show()
    End Sub
    Private Sub AddImageButton1_Click(sender As Object, e As EventArgs) Handles AddImageButton1.Click
        Try
            Dim imgpath1 As String
            Dim OFD As FileDialog = New OpenFileDialog With {
            .InitialDirectory = Environment.SpecialFolder.UserProfile.MyPictures,
            .FileName = $"*",
            .SupportMultiDottedExtensions = True,
            .AddExtension = True,
            .Filter = "JPG File|*.jpg"
            }
            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath1 = OFD.FileName
                PictureBox1.ImageLocation = imgpath1
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Else
                PictureBox1.Image = My.Resources.leer_logo
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End If
            OFD = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
    Private Sub AddImageButton2_Click(sender As Object, e As EventArgs) Handles AddImageButton2.Click
        Try
            Dim imgpath2 As String
            Dim OFD As FileDialog = New OpenFileDialog With {
            .InitialDirectory = Environment.SpecialFolder.UserProfile.MyPictures,
            .FileName = $"*",
            .SupportMultiDottedExtensions = True,
            .AddExtension = True,
            .Filter = "JPG File|*.jpg"
            }
            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath2 = OFD.FileName
                PictureBox2.ImageLocation = imgpath2
                PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            Else
                PictureBox2.Image = My.Resources.leer_logo
                PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            End If
            OFD = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
    Private Sub AddImageButton3_Click(sender As Object, e As EventArgs) Handles AddImageButton3.Click
        Try
            Dim imgpath3 As String
            Dim OFD As FileDialog = New OpenFileDialog With {
            .InitialDirectory = Environment.SpecialFolder.UserProfile.MyPictures,
            .FileName = $"*",
            .SupportMultiDottedExtensions = True,
            .AddExtension = True,
            .Filter = "JPG File|*.jpg"
            }
            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath3 = OFD.FileName
                PictureBox3.ImageLocation = imgpath3
                PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
            Else
                PictureBox3.Image = My.Resources.leer_logo
                PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
            End If
            OFD = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel1.Text
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel2.Text
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel3.Text
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel4.Text
    End Sub
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel5.Text
    End Sub
    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel6.Text
    End Sub
    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel7.Text
    End Sub
    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel8.Text
    End Sub
    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel9.Text
    End Sub
    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel10.Text
    End Sub
    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel11.Text
    End Sub
    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel12.Text
    End Sub
    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel13.Text
    End Sub
    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel14.Text
    End Sub
    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel15.Text
    End Sub
    Private Sub LinkLabel16_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel16.Text
    End Sub
    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel17.Text
    End Sub
    Private Sub LinkLabel18_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel18.Text
    End Sub
    Private Sub LinkLabel19_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel19.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel19.Text
    End Sub
    Private Sub LinkLabel20_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel20.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel20.Text
    End Sub
    Private Sub LinkLabel21_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel21.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel21.Text
    End Sub
    Private Sub LinkLabel22_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel22.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel22.Text
    End Sub
    Private Sub LinkLabel23_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel23.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel23.Text
    End Sub
    Private Sub LinkLabel24_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel24.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel24.Text
    End Sub
    Private Sub LinkLabel25_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel25.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel25.Text
    End Sub
    Private Sub LinkLabel26_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel26.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel26.Text
    End Sub
    Private Sub LinkLabel27_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel27.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel27.Text
    End Sub
    Private Sub LinkLabel28_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel28.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel28.Text
    End Sub
    Private Sub LinkLabel29_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel29.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel29.Text
    End Sub
    Private Sub LinkLabel30_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel30.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel30.Text
    End Sub
    Private Sub LinkLabel31_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel31.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel31.Text
    End Sub
    Private Sub LinkLabel32_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel32.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel32.Text
    End Sub
    Private Sub LinkLabel33_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel33.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel33.Text
    End Sub
    Private Sub LinkLabel34_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel34.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel34.Text
    End Sub
    Private Sub LinkLabel35_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel35.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel35.Text
    End Sub
    Private Sub LinkLabel36_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel36.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel36.Text
    End Sub
    Private Sub LinkLabel37_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel37.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel37.Text
    End Sub
    Private Sub LinkLabel38_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel38.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel38.Text
    End Sub
    Private Sub LinkLabel39_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel39.LinkClicked
        DefectLocationComboBox.SelectedValue = LinkLabel39.Text
    End Sub
    Private Sub Export_Button_Click(sender As Object, e As EventArgs) Handles Export_Button.Click
        Dim newForm As New Export_Data()
        newForm.Show()
    End Sub
    Private Sub NewEntry_Button_Click(sender As Object, e As EventArgs) Handles NewEntry_Button.Click
        ReportedDataGroupBox.Visible = False
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = False

        WorkStationComboBox.Enabled = False
        WorkOrderTextBox.Enabled = True
        MoldBrandComboBox.Enabled = True
        ProductLineComboBox.Enabled = True
        MoldModelComboBox.Enabled = True
        MoldSerialComboBox.Enabled = True
        PaintCodeComboBox.Enabled = True

        DefectOriginComboBox.Enabled = False
        DefectComboBox.Enabled = False
        DefectLocationComboBox.Enabled = False
        ReworkComboBox.Enabled = False

        WorkOrderTextBox.Clear()
        WorkOrderId_TextBox.Clear()

        MoldBrandComboBox.SelectedItem = Nothing
        ProductLineComboBox.SelectedItem = Nothing
        MoldModelComboBox.SelectedItem = Nothing
        MoldSerialComboBox.SelectedItem = Nothing
        PaintCodeComboBox.SelectedItem = Nothing
        PaintcodeDescription_ComboBox.SelectedItem = Nothing

        DefectOriginComboBox.ResetText()
        DefectComboBox.ResetText()
        DefectLocationComboBox.ResetText()
        ReworkComboBox.ResetText()

        Status_PictureBox.Image = My.Resources._NEW
        Status_Label.Text = "NEW ENTRY"
        Status_PictureBox.SizeMode = PictureBoxSizeMode.Zoom

        Approved_Button.Enabled = True
        ReportDefect_Button.Enabled = True

        EditSelected_Button.Enabled = False
        SearchWO_Button.Enabled = False
        ClearSearchWO_Button.Enabled = False

    End Sub
    Private Sub EditSelected_Button_Click(sender As Object, e As EventArgs) Handles EditSelected_Button.Click, ReportedDataGridView.CellDoubleClick
        WorkOrderId_TextBox.Text = ReportedDataGridView.Item("workorder_id", ReportedDataGridView.SelectedRows(0).Index).Value

        ReportedDataGroupBox.Visible = False
        DefectDataGroupBox.Visible = True
        AddPicturesGroupBox.Visible = True

        WorkStationComboBox.Enabled = False
        WorkOrderTextBox.Enabled = False
        MoldBrandComboBox.Enabled = True
        ProductLineComboBox.Enabled = True
        MoldModelComboBox.Enabled = True
        MoldSerialComboBox.Enabled = True
        PaintCodeComboBox.Enabled = True

        DefectOriginComboBox.Enabled = True
        DefectComboBox.Enabled = True
        DefectLocationComboBox.Enabled = True
        ReworkComboBox.Enabled = True

        Dim Status_Name As String = ReportedDataGridView.Item("workorder_status", ReportedDataGridView.SelectedRows(0).Index).Value.ToString
        Status_Label.Text = Status_Name
        Status_PictureBox.Image = My.Resources.ResourceManager.GetObject(Status_Name)
        Status_PictureBox.SizeMode = PictureBoxSizeMode.Zoom

        Approved_Button.Enabled = False
        ReportDefect_Button.Enabled = False
        GetEditImages()
    End Sub
    Private Sub CancelEdit_Button_Click(sender As Object, e As EventArgs) Handles CancelEdit_Button.Click, CancelDefect_Button.Click
        WorkStationComboBox.Enabled = True
        ReportedDataGroupBox.Visible = True
        DefectDataGroupBox.Visible = False

        EditSelected_Button.Enabled = True
        SearchWO_Button.Enabled = True
        ClearSearchWO_Button.Enabled = True

        Clean_Form()

    End Sub
    Private Sub Approved_Button_Click(sender As Object, e As EventArgs) Handles Approved_Button.Click
        connection.Open()
        If String.IsNullOrEmpty(WorkOrderTextBox.Text.ToString()) Then
            MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
        Else
            Dim rslt As DialogResult = MessageBox.Show("SET WORKORDER " & WorkOrderTextBox.Text & " AS APPROVED?", "PLEASE CONFIRM ACTION", MessageBoxButtons.YesNo)
            If rslt = Windows.Forms.DialogResult.Yes Then
                WO_User = LoginForm.login_user
                WO_Workstation = WorkStationComboBox.SelectedValue.ToString
                WO_Number = WorkOrderTextBox.Text
                WO_Brand = MoldBrandComboBox.Text
                WO_Product_Line = ProductLineComboBox.Text
                WO_Model = MoldModelComboBox.Text
                WO_Serial = MoldSerialComboBox.Text
                WO_Paintcode = PaintCodeComboBox.Text
                WO_Status = "APPROVED"
                WO_Defect_Origin = "NN"
                WO_Defect = "APP"
                WO_Location = ""
                WO_Rework = "NONE"
                Insert_Data()
            End If
        End If
    End Sub
    'Private Function Approved_Rework()
    '    Dim defect_origin As String = WorkStationComboBox.SelectedValue.ToString
    '    Dim app_rework As String
    '    Select Case defect_origin
    '        Case "CP1"
    '            app_rework = "APLAM"
    '            Return app_rework
    '        Case "CP2"
    '            app_rework = "APRYR"
    '            Return app_rework
    '        Case "CP3"
    '            app_rework = "APALF"
    '            Return app_rework
    '        Case "CP4"
    '            app_rework = "APPAP"
    '            Return app_rework
    '        Case "CP5"
    '            app_rework = "APPIN"
    '            Return app_rework
    '        Case "CP6"
    '            app_rework = "APINF"
    '            Return app_rework
    '        Case "CP7"
    '            app_rework = "APSHR"
    '            Return app_rework
    '        Case Else
    '            app_rework = "APPROVED"
    '            Return app_rework
    '    End Select
    'End Function
    Private Sub ReportDefect_Button_Click(sender As Object, e As EventArgs) Handles ReportDefect_Button.Click
        If String.IsNullOrEmpty(WorkOrderTextBox.Text.ToString()) Then
            MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
        Else
            DefectDataGroupBox.Visible = True
            AddPicturesGroupBox.Visible = True
            ReportedDataGroupBox.Visible = False

            DefectOriginComboBox.Enabled = True
            DefectComboBox.Enabled = False
            DefectLocationComboBox.Enabled = False
            ReworkComboBox.Enabled = False

            NewEntry_Button.Enabled = False
            EditSelected_Button.Enabled = False
            SearchWO_Button.Enabled = False
            ClearSearchWO_Button.Enabled = False
        End If
        'Load Defect Origin DropDown Menu
        Using DORcommand As New MySqlCommand("Select `defect_origins_origin`, `defect_origins_origin_code` FROM `defect_origins` WHERE `defect_origins_workstation_code` = @workorder_workstation AND `defect_origins_status` = '1'", connection)
            DORcommand.Parameters.Add("@workorder_workstation", MySqlDbType.String).Value = WO_Workstation
            Dim DORadapter As New MySqlDataAdapter(DORcommand)
            Dim DORtable As New DataTable()
            DORadapter.Fill(DORtable)
            DefectOriginComboBox.DataSource = DORtable
            DefectOriginComboBox.ValueMember = "defect_origins_origin_code"
            DefectOriginComboBox.DisplayMember = "defect_origins_origin"
            DefectOriginComboBox.SelectedItem = -1
        End Using
        'Load Rework DropDown Menu
        Using RWOcommand As New MySqlCommand("SELECT `rework_code`, `rework_description` FROM `rework` WHERE 'rework_apply_to_code' = @rework_apply_to_code", connection)
            RWOcommand.Parameters.Add("@rework_apply_to_code", MySqlDbType.String).Value = WO_Workstation
            Dim RWOadapter As New MySqlDataAdapter(RWOcommand)
            Dim RWOtable As New DataTable()
            Dim RWO = RWOadapter.Fill(RWOtable)
            ReworkComboBox.DataSource = RWOtable
            ReworkComboBox.ValueMember = "rework_code"
            ReworkComboBox.DisplayMember = "rework_description"
            ReworkComboBox.SelectedItem = -1
        End Using
    End Sub
    Private Sub Repaired_Button_Click(sender As Object, e As EventArgs) Handles Repaired_Button.Click
        connection.Open()
        Dim repair_rslt As DialogResult = MessageBox.Show("SET WORKORDER " & WorkOrderTextBox.Text & " AS REPAIRED?", "PLEASE CONFIRM ACTION", MessageBoxButtons.YesNo)
        If repair_rslt = Windows.Forms.DialogResult.Yes Then
            WO_Status = "REPAIRED"
            Update_Data()
        ElseIf repair_rslt = Windows.Forms.DialogResult.No Then
            WO_Status = Status_Label.Text
            Update_Data()
        End If
    End Sub
    Private Sub SubmitDefect_Button_Click(sender As Object, e As EventArgs) Handles SubmitDefect_Button.Click
        connection.Open()
        WO_User = LoginForm.login_user
        WO_Workstation = WorkStationComboBox.SelectedValue.ToString
        WO_Number = WorkOrderTextBox.Text
        WO_Brand = MoldBrandComboBox.Text
        WO_Product_Line = ProductLineComboBox.Text
        WO_Model = MoldModelComboBox.Text
        WO_Serial = MoldSerialComboBox.Text
        WO_Paintcode = PaintCodeComboBox.Text
        WO_Defect_Origin = DefectOriginComboBox.SelectedValue.ToString
        WO_Defect = DefectComboBox.SelectedValue.ToString
        WO_Location = DefectLocationComboBox.SelectedValue.ToString
        WO_Rework = ReworkComboBox.SelectedValue.ToString

        Using IDcommand As New MySqlCommand("SELECT COUNT(*) `workorder_id` FROM `workorder` WHERE `workorder_id` = @workorder_id", connection)
            IDcommand.Parameters.Add("@workorder_id", MySqlDbType.String).Value = WorkOrderId_TextBox.Text
            Dim record_exist = IDcommand.ExecuteScalar()
            If Convert.ToInt32(record_exist) = 0 Then
                Dim additional_rslt As DialogResult = MessageBox.Show("DEFECT ADDED TO WORKORDER " & WorkOrderTextBox.Text & vbCrLf & "ADD AN ADDITIONAL DEFECT TO WORKORDER " & WorkOrderTextBox.Text & "?", "PLEASE CONFIRM ACTION", MessageBoxButtons.YesNo)
                If additional_rslt = Windows.Forms.DialogResult.Yes Then
                    WO_Status = "REPORTED"
                    WO_Additional_Defects = True
                    Insert_Data()
                ElseIf additional_rslt = Windows.Forms.DialogResult.No Then
                    WO_Status = "REPORTED"
                    WO_Additional_Defects = False
                    Insert_Data()
                End If
            ElseIf Convert.ToInt32(record_exist) >= 1 Then
                MessageBox.Show("Workorder Entry Existed, Updating Entry", "WO ENTRY EXIST")
                Dim additional_rslt As DialogResult = MessageBox.Show("Workorder Entry " & WorkOrderTextBox.Text & " Exists, Updating Entry" & vbCrLf & "ADD AN ADDITIONAL DEFECT TO WORKORDER " & WorkOrderTextBox.Text & "?", "PLEASE CONFIRM ACTION", MessageBoxButtons.YesNo)
                If additional_rslt = Windows.Forms.DialogResult.Yes Then
                    WO_Status = "REPORTED"
                    WO_Additional_Defects = True
                    Update_Data()
                ElseIf additional_rslt = Windows.Forms.DialogResult.No Then
                    WO_Status = "REPORTED"
                    WO_Additional_Defects = False
                    Update_Data()
                End If
            End If
        End Using
    End Sub
    Private Sub GetEditImages()
        Try
            Using EDcommand As New MySqlCommand("SELECT `workorder_id`, `workorder_image1`, `workorder_image2`, `workorder_image3` FROM `workorder` WHERE `workorder_id` = @workorder_id", connection)
                EDcommand.Parameters.Add("@workorder_id", MySqlDbType.VarChar).Value = WorkOrderId_TextBox.Text
                Dim EDadapter As New MySqlDataAdapter(EDcommand)
                Dim EDtable As New DataTable
                Dim ED = EDadapter.Fill(EDtable)

                If Not IsDBNull(EDtable.Rows(0).Item("workorder_image1")) Then
                    arrImage1 = EDtable.Rows(0).Item("workorder_image1")
                    Dim mstream1 As New System.IO.MemoryStream(arrImage1)
                    PictureBox1.Image = Image.FromStream(mstream1)
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    PictureBox1.Image = My.Resources.leer_logo
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                End If

                If Not IsDBNull(EDtable.Rows(0).Item("workorder_image2")) Then
                    arrImage2 = EDtable.Rows(0).Item("workorder_image2")
                    Dim mstream2 As New System.IO.MemoryStream(arrImage2)
                    PictureBox2.Image = Image.FromStream(mstream2)
                    PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    PictureBox2.Image = My.Resources.leer_logo
                    PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
                End If

                If Not IsDBNull(EDtable.Rows(0).Item("workorder_image3")) Then
                    arrImage3 = EDtable.Rows(0).Item("workorder_image3")
                    Dim mstream3 As New System.IO.MemoryStream(arrImage3)
                    PictureBox3.Image = Image.FromStream(mstream3)
                    PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    PictureBox3.Image = My.Resources.leer_logo
                    PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Dim PopUp As New PopUp_Window
        PopUp.PopUp_PictureBox.Image = PictureBox1.Image
        PopUp.ShowDialog()
        PopUp.Dispose()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick
        Dim PopUp As New PopUp_Window
        PopUp.PopUp_PictureBox.Image = PictureBox2.Image
        PopUp.ShowDialog()
        PopUp.Dispose()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        Dim PopUp As New PopUp_Window
        PopUp.PopUp_PictureBox.Image = PictureBox3.Image
        PopUp.ShowDialog()
        PopUp.Dispose()
    End Sub
    Private Sub Get_Images()
        If PictureBox1.ImageLocation IsNot Nothing Then
            Dim mstream1 As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream1, Imaging.ImageFormat.Jpeg)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            arrImage1 = mstream1.GetBuffer()
            Dim FileSize1 As UInt32
            FileSize1 = mstream1.Length
            mstream1.Close()
        Else
            PictureBox1.Image = My.Resources.leer_logo
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
        If PictureBox2.ImageLocation IsNot Nothing Then
            Dim mstream2 As New System.IO.MemoryStream()
            PictureBox2.Image.Save(mstream2, Imaging.ImageFormat.Jpeg)
            arrImage2 = mstream2.GetBuffer()
            Dim FileSize2 As UInt32
            FileSize2 = mstream2.Length
            mstream2.Close()
        Else
            PictureBox2.Image = My.Resources.leer_logo
        End If
        If PictureBox3.ImageLocation IsNot Nothing Then
            Dim mstream3 As New System.IO.MemoryStream()
            PictureBox3.Image.Save(mstream3, Imaging.ImageFormat.Jpeg)
            arrImage3 = mstream3.GetBuffer()
            Dim FileSize3 As UInt32
            FileSize3 = mstream3.Length
            mstream3.Close()
        Else
            PictureBox3.Image = My.Resources.leer_logo
        End If
    End Sub
    Private Sub Insert_Data()
        Try
            If String.IsNullOrEmpty(WorkOrderTextBox.Text.ToString()) Then
                MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select Entry from DataGrid", "WO ERROR")
            Else
                Get_Images()
                Dim insert_command As New MySqlCommand("INSERT INTO `workorder`(`workorder_date`, `workorder_time`, `workorder_reportedby`, `workorder_workstation`, `workorder_number`, `workorder_moldbrand`, `workorder_productline`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_rework`, `workorder_defect_origin`, `workorder_defect`, `workorder_defect_location`, `workorder_additionalerror`, `workorder_status`, `workorder_image1`, `workorder_image2`, `workorder_image3`, `workorder_comments`)
            VALUES (@workorder_date, @workorder_time, @workorder_reportedby, @workorder_workstation, @workorder_number,  @workorder_moldbrand, @workorder_productline, @workorder_moldmodel, @workorder_moldserial, @workorder_paintcode, @workorder_rework, @workorder_defect_origin, @workorder_defect, @workorder_defect_location, @workorder_additionalerror, @workorder_status, @workorder_image1, @workorder_image2, @workorder_image3, @workorder_comments)", connection)
                insert_command.Parameters.Add("@workorder_date", MySqlDbType.Date).Value = DatePicker.Value.ToString("yyyy/MM/dd")
                insert_command.Parameters.Add("@workorder_time", MySqlDbType.VarChar).Value = TimeTextBox.Text
                insert_command.Parameters.Add("@workorder_reportedby", MySqlDbType.VarChar).Value = WO_User
                insert_command.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WO_Workstation
                insert_command.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = WO_Number
                insert_command.Parameters.Add("@workorder_moldbrand", MySqlDbType.VarChar).Value = WO_Brand
                insert_command.Parameters.Add("@workorder_productline", MySqlDbType.VarChar).Value = WO_Product_Line
                insert_command.Parameters.Add("@workorder_moldmodel", MySqlDbType.VarChar).Value = WO_Model
                If MoldSerialComboBox.SelectedValue Is Nothing Then
                    insert_command.Parameters.Add("@workorder_moldserial", MySqlDbType.VarChar).Value = "NONE"
                Else
                    insert_command.Parameters.Add("@workorder_moldserial", MySqlDbType.VarChar).Value = WO_Serial
                End If
                If PaintCodeComboBox.SelectedValue Is Nothing Then
                    insert_command.Parameters.Add("@workorder_paintcode", MySqlDbType.VarChar).Value = "NONE"
                Else
                    insert_command.Parameters.Add("@workorder_paintcode", MySqlDbType.VarChar).Value = WO_Paintcode
                End If
                insert_command.Parameters.Add("@workorder_rework", MySqlDbType.VarChar).Value = WO_Rework
                insert_command.Parameters.Add("@workorder_defect_origin", MySqlDbType.VarChar).Value = WO_Defect_Origin
                insert_command.Parameters.Add("@workorder_defect", MySqlDbType.VarChar).Value = WO_Defect
                insert_command.Parameters.Add("@workorder_defect_location", MySqlDbType.VarChar).Value = WO_Location
                insert_command.Parameters.Add("@workorder_additionalerror", MySqlDbType.Bit).Value = WO_Additional_Defects
                insert_command.Parameters.Add("@workorder_status", MySqlDbType.VarChar).Value = WO_Status
                insert_command.Parameters.Add("@workorder_image1", MySqlDbType.LongBlob).Value = arrImage1
                insert_command.Parameters.Add("@workorder_image2", MySqlDbType.LongBlob).Value = arrImage2
                insert_command.Parameters.Add("@workorder_image3", MySqlDbType.LongBlob).Value = arrImage3
                insert_command.Parameters.Add("@workorder_comments", MySqlDbType.VarChar).Value = WO_Comments

                If WO_Additional_Defects = False Then
                    If insert_command.ExecuteNonQuery() = 1 Then
                        Clean_Form()
                    End If
                ElseIf WO_Additional_Defects = True Then
                    If insert_command.ExecuteNonQuery() = 1 Then
                        Dim Entrylist As New List(Of String) From {
                        LoginForm.login_user,
                        WO_Workstation,
                        WO_Number,
                        WO_Brand,
                        WO_Product_Line,
                        WO_Model,
                        WO_Serial,
                        WO_Paintcode}

                        MessageBox.Show("Please enter additional Data")

                        ReportedDataGroupBox.Visible = False
                        DefectDataGroupBox.Visible = True
                        AddPicturesGroupBox.Visible = True
                        WorkOrderTextBox.Enabled = False
                        MoldBrandComboBox.Enabled = False
                        MoldModelComboBox.Enabled = False
                        MoldSerialComboBox.Enabled = False
                        PaintCodeComboBox.Enabled = False

                        WorkStationComboBox.SelectedValue = (Entrylist(1)).ToString
                        WorkOrderTextBox.Text = (Entrylist(2)).ToString
                        MoldBrandComboBox.SelectedValue = (Entrylist(3)).ToString
                        ProductLineComboBox.SelectedValue = (Entrylist(4)).ToString
                        MoldModelComboBox.SelectedValue = (Entrylist(5)).ToString
                        MoldSerialComboBox.SelectedValue = (Entrylist(6)).ToString
                        PaintCodeComboBox.SelectedValue = (Entrylist(7)).ToString

                        WorkOrderId_TextBox.Clear()

                        DefectOriginComboBox.ResetText()
                        DefectComboBox.ResetText()
                        DefectLocationComboBox.ResetText()
                        ReworkComboBox.ResetText()

                        DefectOriginComboBox.Enabled = True
                        DefectComboBox.Enabled = True
                        DefectLocationComboBox.Enabled = True
                        ReworkComboBox.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
        connection.Close()
    End Sub
    Private Sub Update_Data()
        Try
            If String.IsNullOrEmpty(WorkOrderTextBox.Text.ToString()) Then
                MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
            Else
                Get_Images()
                Dim update_command As New MySqlCommand("UPDATE `workorder` SET `workorder_reportedby` = @workorder_reportedby, `workorder_workstation` = @workorder_workstation, `workorder_number` = @workorder_number, `workorder_moldbrand` = @workorder_moldbrand,
					                                                `workorder_productline` = @workorder_productline, `workorder_moldmodel` = @workorder_moldmodel, `workorder_moldserial` = @workorder_moldserial,
					                                                `workorder_paintcode` = @workorder_paintcode, `workorder_rework`= @workorder_rework, `workorder_defect_origin` = @workorder_defect_origin,
					                                                `workorder_defect` = @workorder_defect, `workorder_defect_location` = @workorder_defect_location, `workorder_status` = @workorder_status,
                                                                    `workorder_image1` = @workorder_image1, `workorder_image2` = @workorder_image2, `workorder_image3` = @workorder_image3,
					                                                `workorder_comments` = @workorder_comments WHERE `workorder_id` =  @workorder_id", connection)
                update_command.Parameters.Add("@workorder_id", MySqlDbType.VarChar).Value = WorkOrderId_TextBox.Text
                update_command.Parameters.Add("@workorder_reportedby", MySqlDbType.VarChar).Value = LoginForm.login_user
                update_command.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WO_Workstation
                update_command.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = WO_Number
                update_command.Parameters.Add("@workorder_moldbrand", MySqlDbType.VarChar).Value = WO_Brand
                update_command.Parameters.Add("@workorder_productline", MySqlDbType.VarChar).Value = WO_Product_Line
                update_command.Parameters.Add("@workorder_moldmodel", MySqlDbType.VarChar).Value = WO_Model
                update_command.Parameters.Add("@workorder_moldserial", MySqlDbType.VarChar).Value = WO_Serial
                update_command.Parameters.Add("@workorder_paintcode", MySqlDbType.VarChar).Value = WO_Paintcode
                update_command.Parameters.Add("@workorder_rework", MySqlDbType.VarChar).Value = WO_Rework
                update_command.Parameters.Add("@workorder_defect_origin", MySqlDbType.VarChar).Value = WO_Defect_Origin
                update_command.Parameters.Add("@workorder_defect", MySqlDbType.VarChar).Value = WO_Defect
                update_command.Parameters.Add("@workorder_defect_location", MySqlDbType.VarChar).Value = WO_Location
                update_command.Parameters.Add("@workorder_additionalerror", MySqlDbType.Bit).Value = WO_Additional_Defects
                update_command.Parameters.Add("@workorder_status", MySqlDbType.VarChar).Value = WO_Status
                update_command.Parameters.Add("@workorder_image1", MySqlDbType.LongBlob).Value = arrImage1
                update_command.Parameters.Add("@workorder_image2", MySqlDbType.LongBlob).Value = arrImage2
                update_command.Parameters.Add("@workorder_image3", MySqlDbType.LongBlob).Value = arrImage3
                update_command.Parameters.Add("@workorder_comments", MySqlDbType.VarChar).Value = WO_Comments

                If WO_Additional_Defects = False Then
                    If update_command.ExecuteNonQuery() = 1 Then
                        Clean_Form()
                    End If
                ElseIf WO_Additional_Defects = True Then
                    If update_command.ExecuteNonQuery() = 1 Then
                        Dim Entrylist As New List(Of String) From {
                        LoginForm.login_user,
                        WO_Workstation,
                        WO_Number,
                        WO_Brand,
                        WO_Product_Line,
                        WO_Model,
                        WO_Serial,
                        WO_Paintcode}
                        MessageBox.Show("Please enter additional Data")

                        ReportedDataGroupBox.Visible = False
                        DefectDataGroupBox.Visible = True
                        AddPicturesGroupBox.Visible = True
                        WorkOrderTextBox.Enabled = False
                        MoldBrandComboBox.Enabled = False
                        MoldModelComboBox.Enabled = False
                        MoldSerialComboBox.Enabled = False
                        PaintCodeComboBox.Enabled = False

                        WorkStationComboBox.SelectedValue = (Entrylist(1)).ToString
                        WorkOrderTextBox.Text = (Entrylist(2)).ToString
                        MoldBrandComboBox.SelectedValue = (Entrylist(3)).ToString
                        ProductLineComboBox.SelectedValue = (Entrylist(4)).ToString
                        MoldModelComboBox.SelectedValue = (Entrylist(5)).ToString
                        MoldSerialComboBox.SelectedValue = (Entrylist(6)).ToString
                        PaintCodeComboBox.SelectedValue = (Entrylist(7)).ToString

                        WorkOrderId_TextBox.Clear()

                        DefectOriginComboBox.ResetText()
                        DefectComboBox.ResetText()
                        DefectLocationComboBox.ResetText()
                        ReworkComboBox.ResetText()

                        DefectOriginComboBox.Enabled = True
                        DefectComboBox.Enabled = True
                        DefectLocationComboBox.Enabled = True
                        ReworkComboBox.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
        connection.Close()
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click

    End Sub
End Class
