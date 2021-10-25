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
    Dim workorder_status As String
    Dim additional_defects As Boolean
    Private Sub AddEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub
    Private Sub Init_Form()
        ReportedDataGroupBox.Visible = True
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = False
        TimeTextBox.Text = Date.Now.ToString("HH:mm:ss")
        Using WScommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim WSadapter As New MySqlDataAdapter(WScommand)
            Dim WStable As New DataTable()
            Dim WS = WSadapter.Fill(WStable)
            WorkStationComboBox.DataSource = WStable
            WorkStationComboBox.ValueMember = "workstation_code"
            WorkStationComboBox.DisplayMember = "workstation_description"
        End Using
        Using MBcommand As New MySqlCommand("SELECT DISTINCT `models_brand` FROM `models`", connection)
            Dim MBadapter As New MySqlDataAdapter(MBcommand)
            Dim MBtable As New DataTable()
            Dim MB = MBadapter.Fill(MBtable)
            MoldBrandComboBox.DataSource = MBtable
            MoldBrandComboBox.ValueMember = "models_brand"
            MoldBrandComboBox.DisplayMember = "models_brand"
        End Using
        Using RWcommand As New MySqlCommand("SELECT `rework_code`, `rework_description` FROM `rework`", connection)
            Dim RWadapter As New MySqlDataAdapter(RWcommand)
            Dim RWtable As New DataTable()
            Dim RW = RWadapter.Fill(RWtable)
            ReworkComboBox.DataSource = RWtable
            ReworkComboBox.ValueMember = "rework_code"
            ReworkComboBox.DisplayMember = "rework_description"
        End Using
        Using DLcommand As New MySqlCommand("SELECT `locations_code`, `locations_description` FROM `locations`", connection)
            Dim DLadapter As New MySqlDataAdapter(DLcommand)
            Dim DLtable As New DataTable()
            Dim DL = DLadapter.Fill(DLtable)
            DefectLocationComboBox.DataSource = DLtable
            DefectLocationComboBox.ValueMember = "locations_code"
            DefectLocationComboBox.DisplayMember = "locations_description"
        End Using
        Using WOcommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim WOadapter As New MySqlDataAdapter(WOcommand)
            Dim WOtable As New DataTable()
            Dim WO = WOadapter.Fill(WOtable)
            DefectOriginComboBox.DataSource = WOtable
            DefectOriginComboBox.ValueMember = "workstation_code"
            DefectOriginComboBox.DisplayMember = "workstation_description"
        End Using
        Using PCcommand As New MySqlCommand("SELECT `paintcode_code`, `paintcode_description` FROM `paintcode`", connection)
            Dim PCadapter As New MySqlDataAdapter(PCcommand)
            Dim PCtable As New DataTable()
            Dim PC = PCadapter.Fill(PCtable)
            PaintCodeComboBox.DataSource = PCtable
            PaintCodeComboBox.ValueMember = "paintcode_code"
            PaintCodeComboBox.DisplayMember = "paintcode_code"
        End Using
        ReportedDataGridView_Load()
        WorkStationComboBox.Enabled = True
        WorkOrderTextBox.Enabled = False
        MoldBrandComboBox.Enabled = False
        ProductLineComboBox.Enabled = False
        MoldModelComboBox.Enabled = False
        MoldSerialComboBox.Enabled = False
        PaintCodeComboBox.Enabled = False
        DefectOriginComboBox.Enabled = False
        DefectComboBox.Enabled = False
        DefectLocationComboBox.Enabled = False
        Approved_Button.Enabled = False
        ReportDefect_Button.Enabled = False
    End Sub
    Friend Shared Function GetWorkOrder()
        Return WorkOrderValue
    End Function
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Close()
    End Sub
    Private Sub DefectOriginComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DefectOriginComboBox.SelectedIndexChanged
        Dim Defect_Origin As String
        Dim toString As String = DefectOriginComboBox.Text.ToString
        Defect_Origin = toString
        With DefectComboBox
            Using DFcommand As New MySqlCommand("SELECT `defects_code`, `defects_description` FROM `defects` WHERE `defects_workstation` = @defects_origin", connection)
                DFcommand.Parameters.Add("@defects_origin", MySqlDbType.String).Value = Defect_Origin
                Dim DFadapter As New MySqlDataAdapter(DFcommand)
                Dim DFtable As New DataTable()
                DFadapter.Fill(DFtable)
                DefectComboBox.DataSource = DFtable
                DefectComboBox.ValueMember = "defects_code"
                DefectComboBox.DisplayMember = "defects_description"
            End Using
        End With
        DefectOriginComboBox.Enabled = True
        DefectComboBox.Enabled = True
        DefectLocationComboBox.Enabled = True
        ReworkComboBox.Enabled = True
    End Sub
    Private Sub WorkOrderTextBox_TextChanged(sender As Object, e As EventArgs) Handles WorkOrderTextBox.TextChanged
        WorkOrderValue = WorkOrderTextBox.Text
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
        '.FileName = $"{WorkOrderValue}-*",
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
    Private Sub BrandComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MoldBrandComboBox.SelectedIndexChanged
        Dim models_brand As String
        Dim toString As String = MoldBrandComboBox.Text.ToString
        models_brand = toString
        With MoldModelComboBox
            Using Bcommand As New MySqlCommand("Select DISTINCT `models_mold` FROM `models` WHERE `models_brand` = @models_brand  ORDER BY `models_mold` asc", connection)
                Bcommand.Parameters.Add("@models_brand", MySqlDbType.String).Value = models_brand
                Dim Badapter As New MySqlDataAdapter(Bcommand)
                Dim Btable As New DataTable()
                Badapter.Fill(Btable)
                MoldModelComboBox.DataSource = Btable
                MoldModelComboBox.ValueMember = "models_mold"
                MoldModelComboBox.DisplayMember = "models_mold"
            End Using
        End With
        With ProductLineComboBox
            Using Pcommand As New MySqlCommand("Select DISTINCT `brands_prefix` FROM `brands` WHERE `brands_name` = @models_brand  ORDER BY `brands_prefix` asc", connection)
                Pcommand.Parameters.Add("@models_brand", MySqlDbType.String).Value = models_brand
                Dim Padapter As New MySqlDataAdapter(Pcommand)
                Dim Ptable As New DataTable()
                Padapter.Fill(Ptable)
                ProductLineComboBox.DataSource = Ptable
                ProductLineComboBox.ValueMember = "brands_prefix"
                ProductLineComboBox.DisplayMember = "brands_prefix"
            End Using
        End With
    End Sub
    Private Sub ModelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MoldModelComboBox.SelectedIndexChanged, ProductLineComboBox.SelectedIndexChanged
        Dim models_molde As String
        Dim toString As String = MoldModelComboBox.Text.ToString
        models_molde = toString
        With MoldSerialComboBox
            Using Mcommand As New MySqlCommand("Select `models_serial` FROM `models` WHERE `models_mold` = @models_molde", connection)
                Mcommand.Parameters.Add("@models_molde", MySqlDbType.String).Value = models_molde
                Dim Madapter As New MySqlDataAdapter(Mcommand)
                Dim Mtable As New DataTable()
                Madapter.Fill(Mtable)
                MoldSerialComboBox.DataSource = Mtable
                MoldSerialComboBox.ValueMember = "models_serial"
                MoldSerialComboBox.DisplayMember = "models_serial"
            End Using
        End With
    End Sub
    Private Sub PaintcodeDescription_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaintCodeComboBox.SelectedIndexChanged
        Dim paint_code As String
        Dim toString As String = PaintCodeComboBox.Text.ToString
        paint_code = toString
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
    Private Sub ReportedDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ReportedDataGridView.SelectionChanged
        If ReportedDataGridView.SelectedRows.Count = 1 Then
            WorkStationComboBox.SelectedValue = ReportedDataGridView.Item("workorder_workstation", ReportedDataGridView.SelectedRows(0).Index).Value
            WorkOrderTextBox.Text = ReportedDataGridView.Item("workorder_number", ReportedDataGridView.SelectedRows(0).Index).Value
            MoldBrandComboBox.SelectedValue = ReportedDataGridView.Item("workorder_moldbrand", ReportedDataGridView.SelectedRows(0).Index).Value
            ProductLineComboBox.SelectedValue = ReportedDataGridView.Item("workorder_productline", ReportedDataGridView.SelectedRows(0).Index).Value
            MoldModelComboBox.SelectedValue = ReportedDataGridView.Item("workorder_moldmodel", ReportedDataGridView.SelectedRows(0).Index).Value
            MoldSerialComboBox.SelectedValue = ReportedDataGridView.Item("workorder_moldserial", ReportedDataGridView.SelectedRows(0).Index).Value
            PaintCodeComboBox.SelectedValue = ReportedDataGridView.Item("workorder_paintcode", ReportedDataGridView.SelectedRows(0).Index).Value
            ReworkComboBox.SelectedValue = ReportedDataGridView.Item("workorder_rework", ReportedDataGridView.SelectedRows(0).Index).Value
            DefectComboBox.SelectedValue = ReportedDataGridView.Item("workorder_defect", ReportedDataGridView.SelectedRows(0).Index).Value
            DefectOriginComboBox.SelectedValue = ReportedDataGridView.Item("workorder_defect_origin", ReportedDataGridView.SelectedRows(0).Index).Value
            DefectLocationComboBox.SelectedValue = ReportedDataGridView.Item("workorder_defect_location", ReportedDataGridView.SelectedRows(0).Index).Value

            Dim Status_Name As String = ReportedDataGridView.Item("workorder_status", ReportedDataGridView.SelectedRows(0).Index).Value.ToString
            Status_Label.Text = Status_Name
            Status_PictureBox.Image = My.Resources.ResourceManager.GetObject(Status_Name)
            Status_PictureBox.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
    Private Sub Export_Button_Click(sender As Object, e As EventArgs) Handles Export_Button.Click
        Dim newForm As New Export_Data()
        newForm.Show()
    End Sub
    Private Sub WorkStationComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WorkStationComboBox.SelectedIndexChanged
        ReportedDataGroupBox.Visible = True
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = False
        ReportedDataGridView_Load()
    End Sub
    Private Sub ReportedDataGridView_Load()
        ReportedDataGridView.DataSource = Create_DataGridView()
        DataGridViewHeaders()
    End Sub
    Private Sub NewEntry_Button_Click(sender As Object, e As EventArgs) Handles NewEntry_Button.Click
        ReportedDataGroupBox.Visible = False
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = True
        WorkStationComboBox.Enabled = False
        WorkOrderTextBox.Enabled = True
        MoldBrandComboBox.Enabled = True
        ProductLineComboBox.Enabled = True
        MoldModelComboBox.Enabled = True
        MoldSerialComboBox.Enabled = True
        PaintCodeComboBox.Enabled = True
        ReworkComboBox.Enabled = True
        DefectOriginComboBox.Enabled = True
        DefectComboBox.Enabled = True
        DefectLocationComboBox.Enabled = True
        WorkOrderTextBox.Clear()
        MoldBrandComboBox.SelectedItem = Nothing
        ProductLineComboBox.SelectedItem = Nothing
        MoldModelComboBox.SelectedItem = Nothing
        MoldSerialComboBox.SelectedItem = Nothing
        PaintCodeComboBox.SelectedItem = Nothing
        PaintcodeDescription_ComboBox.SelectedItem = Nothing
        ReworkComboBox.ResetText()
        DefectOriginComboBox.ResetText()
        DefectComboBox.ResetText()
        DefectLocationComboBox.ResetText()
        Status_PictureBox.Image = My.Resources._NEW
        Status_Label.Text = "NEW ENTRY"
        Status_PictureBox.SizeMode = PictureBoxSizeMode.Zoom
        Approved_Button.Enabled = True
        ReportDefect_Button.Enabled = True
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
        ReworkComboBox.Enabled = True
        DefectOriginComboBox.Enabled = True
        DefectComboBox.Enabled = True
        DefectLocationComboBox.Enabled = True
        Dim Status_Name As String = ReportedDataGridView.Item("workorder_status", ReportedDataGridView.SelectedRows(0).Index).Value.ToString
        Status_Label.Text = Status_Name
        Status_PictureBox.Image = My.Resources.ResourceManager.GetObject(Status_Name)
        Status_PictureBox.SizeMode = PictureBoxSizeMode.Zoom
        Approved_Button.Enabled = False
        ReportDefect_Button.Enabled = False
        GetEditImages()
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
            connection.Close()
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Dim PopUp As New PopUp_Window
        PopUp.PopUp_PictureBox.Image = PictureBox1.Image
        PopUp.ShowDialog()
        'Any actions after the user returns would be here
        PopUp.Dispose()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick
        Dim PopUp As New PopUp_Window
        PopUp.PopUp_PictureBox.Image = PictureBox2.Image
        PopUp.ShowDialog()
        'Any actions after the user returns would be here
        PopUp.Dispose()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        Dim PopUp As New PopUp_Window
        PopUp.PopUp_PictureBox.Image = PictureBox3.Image
        PopUp.ShowDialog()
        'Any actions after the user returns would be here
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
    Private Sub CancelEdit_Button_Click(sender As Object, e As EventArgs) Handles CancelEdit_Button.Click, CancelDefect_Button.Click
        Dim WO_selected As String = WorkStationComboBox.SelectedItem.ToString
        WorkStationComboBox.Enabled = True
        ReportedDataGroupBox.Visible = True
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = False
        WorkStationComboBox.SelectedText = WO_selected
        ReportedDataGridView_Load()
    End Sub
    Private Sub Approved_Button_Click(sender As Object, e As EventArgs) Handles Approved_Button.Click
        'If WorkOrderTextBox.TextLength > 0 Then
        Dim rslt As DialogResult = MessageBox.Show("SET WORKORDER " & WorkOrderTextBox.Text & " AS APPROVED?", "PLEASE CONFIRM ACTION", MessageBoxButtons.YesNo)
        If rslt = Windows.Forms.DialogResult.Yes Then
            workorder_status = "APPROVED"
            Insert_Data()
        End If
        'Else
        '    MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
        'End If
    End Sub
    Private Sub ReportDefect_Button_Click(sender As Object, e As EventArgs) Handles ReportDefect_Button.Click
        'If WorkOrderTextBox.TextLength > 0 Then
        DefectDataGroupBox.Visible = True
            AddPicturesGroupBox.Visible = True
            ReportedDataGroupBox.Visible = False
        'Else
        '    MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
        'End If
    End Sub
    Private Sub Repaired_Button_Click(sender As Object, e As EventArgs) Handles Repaired_Button.Click
        'If WorkOrderTextBox.TextLength > 0 Then
        Dim repair_rslt As DialogResult = MessageBox.Show("SET WORKORDER " & WorkOrderTextBox.Text & " AS REPAIRED?", "PLEASE CONFIRM ACTION", MessageBoxButtons.YesNo)
        If repair_rslt = Windows.Forms.DialogResult.Yes Then
                workorder_status = "REPAIRED"
                Update_Data()
            ElseIf repair_rslt = Windows.Forms.DialogResult.No Then
                workorder_status = "REPORTED"
                Update_Data()
            End If
        'Else
        '    MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
        'End If
    End Sub
    Private Sub SubmitDefect_Button_Click(sender As Object, e As EventArgs) Handles SubmitDefect_Button.Click
        'If WorkOrderTextBox.TextLength > 0 Then
        Dim additional_rslt As DialogResult = MessageBox.Show("DEFECT ADDED TO WORKORDER " & WorkOrderTextBox.Text & vbCrLf & "ADD AN ADDITIONAL DEFECT TO WORKORDER " & WorkOrderTextBox.Text & "?", "PLEASE CONFIRM ACTION", MessageBoxButtons.YesNo)
        If additional_rslt = Windows.Forms.DialogResult.Yes Then
                workorder_status = "REPORTED"
                additional_defects = True
                Insert_Data()
            ElseIf additional_rslt = Windows.Forms.DialogResult.No Then
                workorder_status = "REPORTED"
                additional_defects = False
                Insert_Data()
            End If
        'Else
        '    MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
        'End If
    End Sub
    Private Sub Insert_Data()
        connection.Close()
        If WorkOrderTextBox.TextLength > 0 Then
            Get_Images()
            Dim command As New MySqlCommand("INSERT INTO `workorder`(`workorder_date`, `workorder_time`, `workorder_reportedby`, `workorder_workstation`, `workorder_number`, `workorder_moldbrand`, `workorder_productline`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_rework`, `workorder_defect_origin`, `workorder_defect`, `workorder_defect_location`, `workorder_additionalerror`, `workorder_status`, `workorder_image1`, `workorder_image2`, `workorder_image3`, `workorder_comments`)
            VALUES (@workorder_date, @workorder_time, @workorder_reportedby, @workorder_workstation, @workorder_number,  @workorder_moldbrand, @workorder_productline, @workorder_moldmodel, @workorder_moldserial, @workorder_paintcode, @workorder_rework, @workorder_defect_origin, @workorder_defect, @workorder_defect_location, @workorder_additionalerror, @workorder_status, @workorder_image1, @workorder_image2, @workorder_image3, @workorder_comments)", connection)
            command.Parameters.Add("@workorder_date", MySqlDbType.Date).Value = DatePicker.Value.ToString("yyyy/MM/dd")
            command.Parameters.Add("@workorder_time", MySqlDbType.VarChar).Value = TimeTextBox.Text
            command.Parameters.Add("@workorder_reportedby", MySqlDbType.VarChar).Value = LoginForm.login_user
            command.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WorkStationComboBox.SelectedValue
            command.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = WorkOrderTextBox.Text
            command.Parameters.Add("@workorder_moldbrand", MySqlDbType.VarChar).Value = MoldBrandComboBox.SelectedValue
            command.Parameters.Add("@workorder_productline", MySqlDbType.VarChar).Value = ProductLineComboBox.SelectedValue
            command.Parameters.Add("@workorder_moldmodel", MySqlDbType.VarChar).Value = MoldModelComboBox.SelectedValue
            If MoldSerialComboBox.SelectedValue Is Nothing Then
                command.Parameters.Add("@workorder_moldserial", MySqlDbType.VarChar).Value = "NONE"
            Else
                command.Parameters.Add("@workorder_moldserial", MySqlDbType.VarChar).Value = MoldSerialComboBox.SelectedValue
            End If
            If PaintCodeComboBox.SelectedValue Is Nothing Then
                command.Parameters.Add("@workorder_paintcode", MySqlDbType.VarChar).Value = "NONE"
            Else
                command.Parameters.Add("@workorder_paintcode", MySqlDbType.VarChar).Value = PaintCodeComboBox.SelectedValue
            End If
            command.Parameters.Add("@workorder_rework", MySqlDbType.VarChar).Value = ReworkComboBox.SelectedValue
            command.Parameters.Add("@workorder_defect_origin", MySqlDbType.VarChar).Value = DefectOriginComboBox.SelectedValue
            command.Parameters.Add("@workorder_defect", MySqlDbType.VarChar).Value = DefectComboBox.SelectedValue
            command.Parameters.Add("@workorder_defect_location", MySqlDbType.VarChar).Value = DefectLocationComboBox.SelectedValue
            command.Parameters.Add("@workorder_additionalerror", MySqlDbType.Bit).Value = additional_defects
            command.Parameters.Add("@workorder_status", MySqlDbType.VarChar).Value = workorder_status
            command.Parameters.Add("@workorder_image1", MySqlDbType.LongBlob).Value = arrImage1
            command.Parameters.Add("@workorder_image2", MySqlDbType.LongBlob).Value = arrImage2
            command.Parameters.Add("@workorder_image3", MySqlDbType.LongBlob).Value = arrImage3
            command.Parameters.Add("@workorder_comments", MySqlDbType.VarChar).Value = CommentsRichTextBox.Text
            connection.Open()

            If additional_defects = False Then
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Data Entered")
                    Init_Form()
                Else
                    MessageBox.Show("ERROR")
                End If
            ElseIf additional_defects = True Then
                If command.ExecuteNonQuery() = 1 Then
                    Dim Entrylist As New List(Of String) From {LoginForm.login_user, WorkStationComboBox.SelectedValue, WorkOrderTextBox.Text, MoldBrandComboBox.SelectedValue, ProductLineComboBox.SelectedValue, MoldModelComboBox.SelectedValue, MoldSerialComboBox.SelectedValue, PaintCodeComboBox.SelectedValue}
                    MessageBox.Show("Data Entered, Please enter next defect Data")
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

                    DefectOriginComboBox.ResetText()
                    DefectComboBox.ResetText()
                    DefectLocationComboBox.ResetText()
                    ReworkComboBox.ResetText()

                    DefectOriginComboBox.Enabled = True
                    DefectComboBox.Enabled = True
                    DefectLocationComboBox.Enabled = True
                    ReworkComboBox.Enabled = True
                Else
                    MessageBox.Show("ERROR")
                End If
            End If
        Else
            MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
        End If
        connection.Close()
    End Sub
    Private Sub Update_Data()
        connection.Close()
        If WorkOrderTextBox.TextLength > 0 Then
            Get_Images()
            Dim update_command As New MySqlCommand("UPDATE `workorder` SET `workorder_reportedby` = @workorder_reportedby, `workorder_workstation` = @workorder_workstation, `workorder_number` = @workorder_number, `workorder_moldbrand` = @workorder_moldbrand,
					                                                `workorder_productline` = @workorder_productline, `workorder_moldmodel` = @workorder_moldmodel, `workorder_moldserial` = @workorder_moldserial,
					                                                `workorder_paintcode` = @workorder_paintcode, `workorder_rework`= @workorder_rework, `workorder_defect_origin` = @workorder_defect_origin,
					                                                `workorder_defect` = @workorder_defect, `workorder_defect_location` = @workorder_defect_location, `workorder_status` = @workorder_status,
                                                                    `workorder_image1` = @workorder_image1, `workorder_image2` = @workorder_image2, `workorder_image3` = @workorder_image3,
					                                                `workorder_comments` = @workorder_comments WHERE `workorder_id` =  @workorder_id", connection)
            update_command.Parameters.Add("@workorder_id", MySqlDbType.VarChar).Value = WorkOrderId_TextBox.Text
            'command.Parameters.Add("@workorder_date", MySqlDbType.Date).Value = DatePicker.Value.ToString("yyyy/MM/dd")
            'command.Parameters.Add("@workorder_time", MySqlDbType.VarChar).Value = TimeTextBox.Text
            update_command.Parameters.Add("@workorder_reportedby", MySqlDbType.VarChar).Value = LoginForm.login_user
            update_command.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WorkStationComboBox.SelectedValue
            update_command.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = WorkOrderTextBox.Text
            update_command.Parameters.Add("@workorder_moldbrand", MySqlDbType.VarChar).Value = MoldBrandComboBox.SelectedValue
            update_command.Parameters.Add("@workorder_productline", MySqlDbType.VarChar).Value = ProductLineComboBox.SelectedValue
            update_command.Parameters.Add("@workorder_moldmodel", MySqlDbType.VarChar).Value = MoldModelComboBox.SelectedValue
            If MoldSerialComboBox.SelectedValue Is Nothing Then
                update_command.Parameters.Add("@workorder_moldserial", MySqlDbType.VarChar).Value = "NONE"
            Else
                update_command.Parameters.Add("@workorder_moldserial", MySqlDbType.VarChar).Value = MoldSerialComboBox.SelectedValue
            End If
            If PaintCodeComboBox.SelectedValue Is Nothing Then
                update_command.Parameters.Add("@workorder_paintcode", MySqlDbType.VarChar).Value = "NONE"
            Else
                update_command.Parameters.Add("@workorder_paintcode", MySqlDbType.VarChar).Value = PaintCodeComboBox.SelectedValue
            End If
            update_command.Parameters.Add("@workorder_rework", MySqlDbType.VarChar).Value = ReworkComboBox.SelectedValue
            update_command.Parameters.Add("@workorder_defect_origin", MySqlDbType.VarChar).Value = DefectOriginComboBox.SelectedValue
            update_command.Parameters.Add("@workorder_defect", MySqlDbType.VarChar).Value = DefectComboBox.SelectedValue
            update_command.Parameters.Add("@workorder_defect_location", MySqlDbType.VarChar).Value = DefectLocationComboBox.SelectedValue
            update_command.Parameters.Add("@workorder_status", MySqlDbType.VarChar).Value = workorder_status
            update_command.Parameters.Add("@workorder_image1", MySqlDbType.LongBlob).Value = arrImage1
            update_command.Parameters.Add("@workorder_image2", MySqlDbType.LongBlob).Value = arrImage2
            update_command.Parameters.Add("@workorder_image3", MySqlDbType.LongBlob).Value = arrImage3
            update_command.Parameters.Add("@workorder_comments", MySqlDbType.VarChar).Value = CommentsRichTextBox.Text
            connection.Open()

            If update_command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Entered")
                connection.Close()
                Init_Form()
            Else
                MessageBox.Show("ERROR")
            End If

        Else
            MessageBox.Show("WorkOrder Number Can Not Be Empty, Please enter WO Number or Select from Data Grid", "WO ERROR")
        End If
    End Sub
    Private Sub SearchWO_Button_Click(sender As Object, e As EventArgs) Handles SearchWO_Button.Click, ClearSearchWO_Button.Click
        ReportedDataGridView.DataSource = Filter_DataGridView()
        DataGridViewHeaders()
    End Sub
    Private Sub ClearSearchWO_Button_Click(sender As Object, e As EventArgs) Handles ClearSearchWO_Button.Click
        SearchWO_TextBox.Clear()
        ReportedDataGridView.DataSource = Create_DataGridView()
        DataGridViewHeaders()
    End Sub
    Private Function Create_DataGridView() As DataTable
        Dim RJcommand As New MySqlCommand("SELECT `workorder_id`, `workorder_date`, `workorder_time`, `workorder_reportedby`, `workorder_workstation`, `workstation_description`, `workorder_number`, 
                                                    `workorder_moldbrand`, `workorder_productline`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_defect_origin`,
                                                    `workstation_description`, `workorder_defect`, `defects_description`, `workorder_defect_location`, 
                                                    `workorder_rework`,`rework_description`, `workorder_status`, `workorder_comments` FROM `workorder` 
                                                    INNER JOIN `defects` ON `workorder_defect` = `defects_code` 
                                                    INNER JOIN `workstation` ON `workorder_workstation` = `workstation_code`
                                                    INNER JOIN `rework` ON `workorder_rework` = `rework_code`
                                                    WHERE `workorder_workstation` = @workorder_workstation
                                                    AND `workorder_rework` != 'RW08' 
                                                    ORDER BY `workorder_date` desc, `workorder_time` desc", connection)
        RJcommand.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WorkStationComboBox.SelectedValue
        Dim RJadapter As New MySqlDataAdapter(RJcommand)
        Dim RJtable As New DataTable()
        Dim RJ = RJadapter.Fill(RJtable)
        Return RJtable
    End Function
    Private Function Filter_DataGridView() As DataTable
        Dim RJcommand As New MySqlCommand("SELECT `workorder_id`, `workorder_date`, `workorder_time`, `workorder_reportedby`, `workorder_workstation`, `workstation_description`, `workorder_number`, 
                                                    `workorder_moldbrand`, `workorder_productline`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_defect_origin`,
                                                    `workstation_description`, `workorder_defect`, `defects_description`, `workorder_defect_location`, 
                                                    `workorder_rework`,`rework_description`, `workorder_status`, `workorder_comments` FROM `workorder` 
                                                    INNER JOIN `defects` ON `workorder_defect` = `defects_code` 
                                                    INNER JOIN `workstation` ON `workorder_workstation` = `workstation_code`
                                                    INNER JOIN `rework` ON `workorder_rework` = `rework_code`
                                                    WHERE `workorder_workstation` = @workorder_workstation
                                                    AND `workorder_number` LIKE CONCAT (@Search, '%') 
                                                    AND `workorder_rework` != 'RW08' 
                                                    ORDER BY `workorder_date` desc, `workorder_time` desc", connection)
        RJcommand.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WorkStationComboBox.SelectedValue
        RJcommand.Parameters.AddWithValue("@Search", SearchWO_TextBox.Text.Trim())
        Dim RJadapter As New MySqlDataAdapter(RJcommand)
        Dim RJtable As New DataTable()
        Dim RJ = RJadapter.Fill(RJtable)
        Return RJtable
    End Function
    'Private Function FilterView_DataGridView() As DataTable
    '    Dim RJcommand As New MySqlCommand("SELECT `workorder_id`, `workorder_date`, `workorder_time`, `workorder_reportedby`, `workorder_workstation`, `workstation_description`, `workorder_number`, 
    '                                                `workorder_moldbrand`, `workorder_productline`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_defect_origin`,
    '                                                `workstation_description`, `workorder_defect`, `defects_description`, `workorder_defect_location`, 
    '                                                `workorder_rework`,`rework_description`, `workorder_status`, `workorder_comments` FROM `workorder` 
    '                                                INNER JOIN `defects` ON `workorder_defect` = `defects_code` 
    '                                                INNER JOIN `workstation` ON `workorder_workstation` = `workstation_code`
    '                                                INNER JOIN `rework` ON `workorder_rework` = `rework_code`
    '                                                WHERE `workorder_workstation` = @workorder_workstation
    '                                                AND `workorder_number` LIKE CONCAT (@Search, '%') 
    '                                                AND `workorder_rework` != 'RW08' 
    '                                                ORDER BY `workorder_date` desc, `workorder_time` desc", connection)
    '    RJcommand.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WorkStationComboBox.SelectedValue
    '    RJcommand.Parameters.AddWithValue("@Filter", MySqlDbType.VarChar).Value = Filter_Name
    '    Dim RJadapter As New MySqlDataAdapter(RJcommand)
    '    Dim RJtable As New DataTable()
    '    Dim RJ = RJadapter.Fill(RJtable)
    '    Return RJtable
    'End Function
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
            .Columns(5).HeaderCell.Value = "Workstation Name"
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
    'Private Sub Filter_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Filter_ComboBox.SelectedIndexChanged
    '    Dim Selected_Text As String = Filter_ComboBox.SelectedText.ToString
    '    Dim Filter_Name As String
    '    Select Case Selected_Text
    '        Case All
    '            Filter_Name = "View All"
    '        Case Reported
    '            Filter_Name = "REPORTED"
    '        Case Repaired
    '            Filter_Name = "REPAIRED"
    '        Case Approved
    '            Filter_Name = "APPROVED"
    '        Case Else
    '    End Select
    'End Sub
End Class
