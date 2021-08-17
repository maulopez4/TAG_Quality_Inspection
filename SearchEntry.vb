Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class SearchEntry
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    Public Shared Property WorkOrderValue As Object
    Dim arrImage1() As Byte
    Dim arrImage2() As Byte
    Dim arrImage3() As Byte
    Friend Shared Function GetWorkOrder()
        Return WorkOrderValue
    End Function
    Private Sub Search_Button_Click(sender As Object, e As EventArgs) Handles Search_Button.Click
        Using SRcommand As New MySqlCommand("SELECT `workorder_date`, `workorder_time`, `workorder_workstation`, `workorder_number`, `workorder_serial`, `workorder_consecutive`, `workorder_paintcode`, `workorder_moldbrand`, `workorder_moldmodel`, `workorder_moldserial`,  `workorder_rework`, `workorder_defect_origin`, `workorder_defect`, `workorder_defect_location`, `workorder_comments`, `workorder_id` FROM `workorder` WHERE `workorder_number` LIKE CONCAT (@workorder_number, '%') ", connection)
            SRcommand.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = Search_WorkOrderTextBox.Text
            Dim SRadapter As New MySqlDataAdapter(SRcommand)
            Dim SRtable As New DataTable()
            Dim SR = SRadapter.Fill(SRtable)
            SearchResultsDataGrid.DataSource = SRtable
            With SearchResultsDataGrid
                .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "Date"
                .Columns(1).HeaderCell.Value = "Time"
                .Columns(2).HeaderCell.Value = "Workstation"
                .Columns(3).HeaderCell.Value = "Work Order"
                .Columns(4).HeaderCell.Value = "Serial Number"
                .Columns(5).HeaderCell.Value = "Consecutive Number"
                .Columns(6).HeaderCell.Value = "Paint Code"
                .Columns(7).HeaderCell.Value = "Mold Brand"
                .Columns(8).HeaderCell.Value = "Mold Model"
                .Columns(9).HeaderCell.Value = "Mold Serial"
                .Columns(10).HeaderCell.Value = "Rework Type"
                .Columns(11).HeaderCell.Value = "Defect Origin"
                .Columns(12).HeaderCell.Value = "Defect Description"
                .Columns(13).HeaderCell.Value = "Defect Location"
                .Columns(14).HeaderCell.Value = "Comments"
                .Columns(15).HeaderCell.Value = "WorkOrderID"
                .Columns(15).Visible = False
            End With
        End Using
    End Sub
    Private Sub SearchResultsDataGrid__SelectionChanged(sender As Object, e As EventArgs) Handles SearchResultsDataGrid.SelectionChanged
        If SearchResultsDataGrid.SelectedRows.Count > 0 Then
            'Try
            Results_DatePicker.Text = SearchResultsDataGrid.Item("workorder_date", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_TimeTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_time", SearchResultsDataGrid.SelectedRows(0).Index).Value)
            Results_WorkstationTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_workstation", SearchResultsDataGrid.SelectedRows(0).Index).Value)
            Results_WorkOrderTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_number", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_SerialNumberTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_serial", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_ConsecutiveTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_consecutive", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_PaintCodeTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_paintcode", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_MoldBrandTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_moldbrand", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_MoldModelTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_moldmodel", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_MoldSerialTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_moldserial", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_ReworkTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_rework", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_Defect_OriginTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_defect_origin", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_DefectTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_defect", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_Defect_LocationTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_defect_location", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Results_CommentsRichTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_comments", SearchResultsDataGrid.SelectedRows(0).Index).Value)
                Search_WorkOrderIDTextBox.Text = Convert.ToString(SearchResultsDataGrid.Item("workorder_id", SearchResultsDataGrid.SelectedRows(0).Index).Value)

            'Using IMcommand As New MySqlCommand("SELECT `workorder_image1`, `workorder_image2`, `workorder_image3` FROM `workorder` WHERE (`workorder_number` = @workorder_number) AND (`workorder_id` = @workorder_id)", connection)
            '    IMcommand.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = Search_WorkOrderTextBox.Text
            '    IMcommand.Parameters.Add("@workorder_id", MySqlDbType.VarChar).Value = Search_WorkOrderIDTextBox.Text
            '    Dim IMadapter As New MySqlDataAdapter(IMcommand)
            '    Dim IMtable As New DataTable()
            '    Dim IM = IMadapter.Fill(IMtable)

            'If IsNothing(IMtable.Rows(0).Item("workorder_image1")) Then
            '    Results_PictureBox1.Image = My.Resources.leer_logo
            '    Results_PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            'Else
            '    arrImage1 = IMtable.Rows(0).Item("workorder_image1")
            '    Dim mstream1 As New System.IO.MemoryStream(arrImage1)
            '    Results_PictureBox1.Image = Image.FromStream(mstream1)
            '        Results_PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            '    End If


            'If IsDBNull(IMtable.Rows(0).Item("workorder_image2")) Then
            '    Results_PictureBox2.Image = My.Resources.leer_logo
            '    Results_PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            'Else
            '    arrImage2 = IMtable.Rows(0).Item("workorder_image2")
            '    Dim mstream2 As New System.IO.MemoryStream(arrImage2)
            '    Results_PictureBox2.Image = Image.FromStream(mstream2)
            '        Results_PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            '    End If


            'If IsDBNull(IMtable.Rows(0).Item("workorder_image3")) Then
            '    Results_PictureBox3.Image = My.Resources.leer_logo
            '    Results_PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
            'Else
            '    arrImage3 = IMtable.Rows(0).Item("workorder_image3")
            '    Dim mstream3 As New System.IO.MemoryStream(arrImage3)
            '    Results_PictureBox3.Image = Image.FromStream(mstream3)
            '        Results_PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
            '    End If
            'End Using
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message.ToString())
            'End Try
        End If
    End Sub
End Class