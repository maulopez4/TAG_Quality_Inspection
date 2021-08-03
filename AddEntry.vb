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
    Private Sub AddDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Using MOcommand As New MySqlCommand("SELECT `model_mold`, `model_description` FROM `models`", connection)
            Dim MOadapter As New MySqlDataAdapter(MOcommand)
            Dim MOtable As New DataTable()
            Dim MO = MOadapter.Fill(MOtable)
            ModelComboBox.DataSource = MOtable
            ModelComboBox.ValueMember = "model_mold"
            ModelComboBox.DisplayMember = "model_mold"
        End Using
        Using RWcommand As New MySqlCommand("SELECT `rework_code`, `rework_description` FROM `rework`", connection)
            Dim RWadapter As New MySqlDataAdapter(RWcommand)
            Dim RWtable As New DataTable()
            Dim RW = RWadapter.Fill(RWtable)
            ReworkTypeComboBox.DataSource = RWtable
            ReworkTypeComboBox.ValueMember = "rework_code"
            ReworkTypeComboBox.DisplayMember = "rework_description"
        End Using
        Using DLcommand As New MySqlCommand("SELECT `location_code`, `location_description` FROM `locations`", connection)
            Dim DLadapter As New MySqlDataAdapter(DLcommand)
            Dim DLtable As New DataTable()
            Dim DL = DLadapter.Fill(DLtable)
            DefectLocationComboBox.DataSource = DLtable
            DefectLocationComboBox.ValueMember = "location_code"
            DefectLocationComboBox.DisplayMember = "location_description"
        End Using
        Using WOcommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim WOadapter As New MySqlDataAdapter(WOcommand)
            Dim WOtable As New DataTable()
            Dim WO = WOadapter.Fill(WOtable)
            DefectOriginComboBox.DataSource = WOtable
            DefectOriginComboBox.ValueMember = "workstation_code"
            DefectOriginComboBox.DisplayMember = "workstation_description"
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
            Using DFcommand As New MySqlCommand("SELECT `defect_code`, `defect_description` FROM `defects` WHERE `defect_workstation` = @Defect_Origin", connection)
                DFcommand.Parameters.Add("@Defect_Origin", MySqlDbType.String).Value = Defect_Origin
                Dim DFadapter As New MySqlDataAdapter(DFcommand)
                Dim DFtable As New DataTable()
                DFadapter.Fill(DFtable)

                DefectComboBox.DataSource = DFtable
                DefectComboBox.ValueMember = "defect_code"
                DefectComboBox.DisplayMember = "defect_description"
            End Using
        End With
    End Sub
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        '***Add images***************************************************************************
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

        Dim command As New MySqlCommand("INSERT INTO `workorder`(`workorder_date`, `workorder_time`, `reported_by`, `workorder_workstation`, `workorder_number`, `workorder_model`, `workorder_consecutive`, `workorder_serial`, `workorder_rework`, `workorder_defect_origin`, `workorder_defect`, `workorder_defect_location`, `workorder_comments`, `additional_error`, `Image1`, `Image2`, `Image3`) 
                                        VALUES 
                                        (@workorder_date,@workorder_time,@reported_by,@workorder_workstation,@workorder_number,@workorder_model,@workorder_consecutive,@workorder_serial,@workorder_rework,@workorder_defect_origin,@workorder_defect,@workorder_defect_location,@workorder_comments,@additional_error,@Image1,@Image2,@Image3)", connection)
        ' add Parameters to the command
        command.Parameters.Add("@workorder_date", MySqlDbType.Date).Value = DatePicker.Value.ToString("yyyy/MM/dd")
        command.Parameters.Add("@workorder_time", MySqlDbType.VarChar).Value = TimeTextBox.Text
        command.Parameters.Add("@reported_by", MySqlDbType.VarChar).Value = LoginForm.login_user
        command.Parameters.Add("@workorder_workstation", MySqlDbType.VarChar).Value = WorkStationComboBox.SelectedValue
        command.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = WorkOrderTextBox.Text
        command.Parameters.Add("@workorder_model", MySqlDbType.VarChar).Value = ModelComboBox.SelectedValue
        command.Parameters.Add("@workorder_consecutive", MySqlDbType.VarChar).Value = ConsecutiveTextBox.Text
        command.Parameters.Add("@workorder_serial", MySqlDbType.VarChar).Value = SerialNumberTextBox.Text
        command.Parameters.Add("@workorder_rework", MySqlDbType.VarChar).Value = ReworkTypeComboBox.SelectedValue
        command.Parameters.Add("@workorder_defect_origin", MySqlDbType.VarChar).Value = DefectOriginComboBox.SelectedValue
        command.Parameters.Add("@workorder_defect", MySqlDbType.VarChar).Value = DefectComboBox.SelectedValue
        command.Parameters.Add("@workorder_defect_location", MySqlDbType.VarChar).Value = DefectLocationComboBox.SelectedValue
        command.Parameters.Add("@workorder_comments", MySqlDbType.VarChar).Value = CommentsRichTextBox.Text
        command.Parameters.Add("@additional_error", MySqlDbType.VarChar).Value = AdditionalDefectsCheckBox.Text
        command.Parameters.Add("@Image1", MySqlDbType.LongBlob).Value = arrImage1
        command.Parameters.Add("@Image2", MySqlDbType.LongBlob).Value = arrImage2
        command.Parameters.Add("@Image3", MySqlDbType.LongBlob).Value = arrImage3
        connection.Open()

        'If AdditionalDefectsCheckBox.Checked <> True Then
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Defect Data Entered")
        Else
            MessageBox.Show("ERROR")
        End If
        Close()
        'Else
        '    If command.ExecuteNonQuery() = 1 Then
        '        MessageBox.Show("Defect Data Entered, Please enter next defect Data")
        '        Controls.Clear()
        '        InitializeComponent()
        '        AddDefect_Load(e, e)
        '    Else
        '        MessageBox.Show("ERROR")
        '    End If
        'End If
        connection.Close()
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
            .FileName = $"{WorkOrderValue}-*",
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
            .FileName = $"{WorkOrderValue}-*",
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
            .FileName = $"{WorkOrderValue}-*",
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
        workorder_accepted = 1
        DefectDataGroupBox.Visible = False
        AddPicturesGroupBox.Visible = False
    End Sub

    Private Sub RejectedRadio_CheckedChanged(sender As Object, e As EventArgs) Handles RejectedRadio.CheckedChanged
        ARPictureBox.Image = My.Resources.Actions_edit_delete_icon
        ARPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        workorder_accepted = 0
        DefectDataGroupBox.Visible = True
        AddPicturesGroupBox.Visible = True
    End Sub
    ''Convert Bitmap image to Byte
    'Public Shared Function BitmapToByteArray(ByVal value As Bitmap) As Byte()
    '    Dim bitmapBytes As Byte()
    '    Using MemStream As New System.IO.MemoryStream
    '        value.Save(MemStream, Imaging.ImageFormat.Jpeg)
    '        bitmapBytes = MemStream.ToArray
    '    End Using
    '    Return bitmapBytes
    'End Function
End Class
