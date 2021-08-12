Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class AddEntry
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    Public Shared Property WorkOrderValue As Object
    Dim arrImage1() As Byte
    Dim arrImage2() As Byte
    Dim arrImage3() As Byte
    Dim workorder_accepted As Boolean
    Dim additional_defects As Boolean
    Private Sub AddDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = True
        RejectedDataGroupBox.Visible = True
        Dim t As String = Date.Now.ToString("HH:mm:ss")
        TimeTextBox.Text = t
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
        Using PCcommand As New MySqlCommand("SELECT `paintcode_code` FROM `paintcode`", connection)
            Dim PCadapter As New MySqlDataAdapter(PCcommand)
            Dim PCtable As New DataTable()
            Dim PC = PCadapter.Fill(PCtable)
            PaintCodeComboBox.DataSource = PCtable
            PaintCodeComboBox.ValueMember = "paintcode_code"
            PaintCodeComboBox.DisplayMember = "paintcode_code"
        End Using
        Using RJcommand As New MySqlCommand("SELECT `workorder_date`, `workorder_workstation`, `workorder_number`, `workorder_serial`, `workorder_consecutive`, `workorder_paintcode`, `workorder_moldbrand`, `workorder_moldmodel`, `workorder_moldserial`,  `workorder_defect_origin`, `workorder_defect`, `workorder_defect_location`, `workorder_comments` FROM `workorder` WHERE `workorder_accepted` = 0 AND `workorder_rework` != 'RW08'", connection)
            Dim RJadapter As New MySqlDataAdapter(RJcommand)
            Dim RJtable As New DataTable()
            Dim RJ = RJadapter.Fill(RJtable)
            RejectedDataGridView.DataSource = RJtable
            With RejectedDataGridView
                .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "Date"
                .Columns(1).HeaderCell.Value = "Workstation"
                .Columns(2).HeaderCell.Value = "Work Order"
                .Columns(3).HeaderCell.Value = "Serial Number"
                .Columns(4).HeaderCell.Value = "Consecutive Number"
                .Columns(5).HeaderCell.Value = "Paint Code"
                .Columns(6).HeaderCell.Value = "Mold Brand"
                .Columns(7).HeaderCell.Value = "Mold Model"
                .Columns(8).HeaderCell.Value = "Mold Serial"
                .Columns(9).HeaderCell.Value = "Defect Origin"
                .Columns(10).HeaderCell.Value = "Defect Description"
                .Columns(11).HeaderCell.Value = "Defect Location"
                .Columns(12).HeaderCell.Value = "Comments"
            End With
        End Using
        ARPictureBox.Image = My.Resources.leer_logo
        ARPictureBox.SizeMode = PictureBoxSizeMode.Zoom
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
    End Sub
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
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

        Dim command As New MySqlCommand("INSERT INTO `workorder`(`workorder_date`, `workorder_time`, `workorder_reportedby`, `workorder_workstation`, `workorder_number`, `workorder_serial`, `workorder_consecutive`, `workorder_moldbrand`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_accepted`, `workorder_rework`, `workorder_defect_origin`, `workorder_defect`, `workorder_defect_location`, `workorder_additionalerror`, `workorder_image1`, `workorder_image2`, `workorder_image3`, `workorder_comments`) 
                                        VALUES (@workorder_date, @workorder_time, @workorder_reportedby, @workorder_workstation, @workorder_number, @workorder_serial, @workorder_consecutive, @workorder_moldbrand, @workorder_moldmodel, @workorder_moldserial, @workorder_paintcode, @workorder_accepted, @workorder_rework, @workorder_defect_origin, @workorder_defect, @workorder_defect_location, @workorder_additionalerror, @workorder_image1, @workorder_image2, @workorder_image3, @workorder_comments)", connection)
        command.Parameters.Add("@workorder_date", MySqlDbType.Date).Value = DatePicker.Value.ToString("yyyy/MM/dd")
        command.Parameters.Add("@workorder_time", MySqlDbType.VarChar).Value = TimeTextBox.Text
        command.Parameters.Add("@workorder_reportedby", MySqlDbType.VarChar).Value = LoginForm.login_user
        command.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WorkStationComboBox.SelectedValue
        command.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = WorkOrderTextBox.Text
        command.Parameters.Add("@workorder_serial", MySqlDbType.VarChar).Value = SerialNumberTextBox.Text
        command.Parameters.Add("@workorder_consecutive", MySqlDbType.VarChar).Value = ConsecutiveTextBox.Text
        command.Parameters.Add("@workorder_moldbrand", MySqlDbType.VarChar).Value = MoldBrandComboBox.SelectedValue
        command.Parameters.Add("@workorder_moldmodel", MySqlDbType.VarChar).Value = MoldModelComboBox.SelectedValue
        command.Parameters.Add("@workorder_moldserial", MySqlDbType.VarChar).Value = MoldSerialComboBox.SelectedValue
        command.Parameters.Add("@workorder_paintcode", MySqlDbType.VarChar).Value = PaintCodeComboBox.SelectedValue
        command.Parameters.Add("@workorder_accepted", MySqlDbType.Bit).Value = workorder_accepted
        command.Parameters.Add("@workorder_rework", MySqlDbType.VarChar).Value = ReworkComboBox.SelectedValue
        command.Parameters.Add("@workorder_defect_origin", MySqlDbType.VarChar).Value = DefectOriginComboBox.SelectedValue
        command.Parameters.Add("@workorder_defect", MySqlDbType.VarChar).Value = DefectComboBox.SelectedValue
        command.Parameters.Add("@workorder_defect_location", MySqlDbType.VarChar).Value = DefectLocationComboBox.SelectedValue
        command.Parameters.Add("@workorder_additionalerror", MySqlDbType.Bit).Value = additional_defects
        command.Parameters.Add("@workorder_image1", MySqlDbType.LongBlob).Value = arrImage1
        command.Parameters.Add("@workorder_image2", MySqlDbType.LongBlob).Value = arrImage2
        command.Parameters.Add("@workorder_image3", MySqlDbType.LongBlob).Value = arrImage3
        command.Parameters.Add("@workorder_comments", MySqlDbType.VarChar).Value = CommentsRichTextBox.Text
        connection.Open()

        Dim Entrylist As New List(Of String) From {LoginForm.login_user, WorkStationComboBox.SelectedValue, WorkOrderTextBox.Text, SerialNumberTextBox.Text, ConsecutiveTextBox.Text, MoldBrandComboBox.SelectedValue, MoldModelComboBox.SelectedValue, MoldSerialComboBox.SelectedValue, PaintCodeComboBox.SelectedValue}
        If additional_defects = False Then
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Entered")
            Else
                MessageBox.Show("ERROR")
            End If
            Close()
        Else
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Entered, Please enter next defect Data")
                Controls.Clear() 'removes all the controls on the form
                InitializeComponent() 'load all the controls again
                AddDefect_Load(e, e)
                WorkStationComboBox.SelectedValue = (Entrylist(1)).ToString
                WorkOrderTextBox.Text = (Entrylist(2)).ToString
                SerialNumberTextBox.Text = (Entrylist(3)).ToString
                ConsecutiveTextBox.Text = (Entrylist(4)).ToString
                MoldBrandComboBox.SelectedValue = (Entrylist(5)).ToString
                MoldModelComboBox.SelectedValue = (Entrylist(6)).ToString
                MoldSerialComboBox.SelectedValue = (Entrylist(7)).ToString
                PaintCodeComboBox.SelectedValue = (Entrylist(8)).ToString
            Else
                MessageBox.Show("ERROR")
            End If
        End If
        connection.Close()
    End Sub
    Private Sub WorkOrderTextBox_TextChanged(sender As Object, e As EventArgs) Handles WorkOrderTextBox.TextChanged, PaintCodeDescriptionTextBox.TextChanged
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
    Private Sub ApprovedRadio_CheckedChanged(sender As Object, e As EventArgs) Handles ApprovedRadio.CheckedChanged
        ARPictureBox.Image = My.Resources.Ok_icon
        ARPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        workorder_accepted = True
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = True
        RejectedDataGroupBox.Visible = True
    End Sub

    Private Sub RejectedRadio_CheckedChanged(sender As Object, e As EventArgs) Handles RejectedRadio.CheckedChanged
        ARPictureBox.Image = My.Resources.Actions_edit_delete_icon
        ARPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        workorder_accepted = False
        DefectDataGroupBox.Visible = True
        AddPicturesGroupBox.Visible = True
        RejectedDataGroupBox.Visible = False
    End Sub
    Private Sub BrandComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MoldBrandComboBox.SelectedIndexChanged
        Dim models_brand As String
        Dim toString As String = MoldBrandComboBox.Text.ToString
        models_brand = toString
        With MoldModelComboBox
            Using Bcommand As New MySqlCommand("SELECT DISTINCT `models_mold` FROM `models` WHERE `models_brand` = @models_brand", connection)
                Bcommand.Parameters.Add("@models_brand", MySqlDbType.String).Value = models_brand
                Dim Badapter As New MySqlDataAdapter(Bcommand)
                Dim Btable As New DataTable()
                Badapter.Fill(Btable)

                MoldModelComboBox.DataSource = Btable
                MoldModelComboBox.ValueMember = "models_mold"
                MoldModelComboBox.DisplayMember = "models_mold"
            End Using
        End With
    End Sub
    Private Sub ModelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MoldModelComboBox.SelectedIndexChanged
        Dim models_molde As String
        Dim toString As String = MoldModelComboBox.Text.ToString
        models_molde = toString
        With MoldSerialComboBox
            Using Mcommand As New MySqlCommand("SELECT `models_serial` FROM `models` WHERE `models_mold` = @models_molde", connection)
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
    Private Sub RejectedDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles RejectedDataGridView.SelectionChanged
        If RejectedDataGridView.SelectedRows.Count > 0 Then
            WorkStationComboBox.SelectedValue = RejectedDataGridView.Item("workorder_workstation", RejectedDataGridView.SelectedRows(0).Index).Value
            WorkOrderTextBox.Text = RejectedDataGridView.Item("workorder_number", RejectedDataGridView.SelectedRows(0).Index).Value
            SerialNumberTextBox.Text = RejectedDataGridView.Item("workorder_serial", RejectedDataGridView.SelectedRows(0).Index).Value
            ConsecutiveTextBox.Text = RejectedDataGridView.Item("workorder_consecutive", RejectedDataGridView.SelectedRows(0).Index).Value
            MoldBrandComboBox.SelectedValue = RejectedDataGridView.Item("workorder_moldbrand", RejectedDataGridView.SelectedRows(0).Index).Value
            MoldModelComboBox.SelectedValue = RejectedDataGridView.Item("workorder_moldmodel", RejectedDataGridView.SelectedRows(0).Index).Value
            MoldSerialComboBox.SelectedValue = RejectedDataGridView.Item("workorder_moldserial", RejectedDataGridView.SelectedRows(0).Index).Value
            PaintCodeComboBox.SelectedValue = RejectedDataGridView.Item("workorder_paintcode", RejectedDataGridView.SelectedRows(0).Index).Value
        End If
    End Sub
    Private Sub AdditionalDefectYESRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AdditionalDefectYESRadioButton.CheckedChanged
        additional_defects = True
    End Sub
    Private Sub AdditionalDefectNORadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AdditionalDefectNORadioButton.CheckedChanged
        additional_defects = False
    End Sub
End Class
