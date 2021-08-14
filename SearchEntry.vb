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
        Using SRcommand As New MySqlCommand("SELECT `workorder_date`, `workorder_workstation`, `workorder_number`, `workorder_serial`, `workorder_consecutive`, `workorder_paintcode`, `workorder_moldbrand`, `workorder_moldmodel`, `workorder_moldserial`,  `workorder_rework`, `workorder_defect_origin`, `workorder_defect`, `workorder_defect_location`, `workorder_comments` FROM `workorder` WHERE `workorder_number` LIKE CONCAT (@workorder_number, '%') ", connection)
            SRcommand.Parameters.Add("@workorder_number", MySqlDbType.VarChar).Value = Search_WorkOrderTextBox.Text
            Dim SRadapter As New MySqlDataAdapter(SRcommand)
            Dim SRtable As New DataTable()
            Dim SR = SRadapter.Fill(SRtable)
            SearchResultsDataGrid.DataSource = SRtable
            With SearchResultsDataGrid
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
                .Columns(9).HeaderCell.Value = "Rework Type"
                .Columns(10).HeaderCell.Value = "Defect Origin"
                .Columns(11).HeaderCell.Value = "Defect Description"
                .Columns(12).HeaderCell.Value = "Defect Location"
                .Columns(13).HeaderCell.Value = "Comments"
            End With
        End Using
    End Sub
    Private Sub SearchResultsDataGrid__SelectionChanged(sender As Object, e As EventArgs) Handles SearchResultsDataGrid.SelectionChanged
        '    User_NewUserButton.Enabled = True
        '    User_AddUserButton.Enabled = False
        '    User_ChangeUserButton.Enabled = True
        '    User_DeleteUserButton.Enabled = True
        If SearchResultsDataGrid.SelectedRows.Count > 0 Then
            Results_DatePicker.Text = SearchResultsDataGrid.Item("workorder_date", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_WorkstationTextBox.Text = SearchResultsDataGrid.Item("workorder_workstation", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_WorkOrderTextBox.Text = SearchResultsDataGrid.Item("workorder_number", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_SerialNumberTextBox.Text = SearchResultsDataGrid.Item("workorder_serial", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_ConsecutiveTextBox.Text = SearchResultsDataGrid.Item("workorder_consecutive", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_PaintCodeTextBox.Text = SearchResultsDataGrid.Item("workorder_paintcode", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_MoldBrandTextBox.Text = SearchResultsDataGrid.Item("workorder_moldbrand", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_MoldModelTextBox.Text = SearchResultsDataGrid.Item("workorder_moldmodel", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_MoldSerialTextBox.Text = SearchResultsDataGrid.Item("workorder_moldserial", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_ReworkTextBox.Text = SearchResultsDataGrid.Item("workorder_rework", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_Defect_OriginTextBox.Text = SearchResultsDataGrid.Item("workorder_defect_origin", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_DefectTextBox.Text = SearchResultsDataGrid.Item("workorder_defect", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_Defect_LocationTextBox.Text = SearchResultsDataGrid.Item("workorder_defect_location", SearchResultsDataGrid.SelectedRows(0).Index).Value
            Results_CommentsRichTextBox.Text = SearchResultsDataGrid.Item("workorder_comments", SearchResultsDataGrid.SelectedRows(0).Index).Value

            ''        User_RealNameTextBox.Text = SearchResultsDataGrid.Item("users_realname", SearchResultsDataGrid.SelectedRows(0).Index).Value
            ''        User_NameTextBox.Text = SearchResultsDataGrid.Item("users_username", SearchResultsDataGrid.SelectedRows(0).Index).Value
            ''        User_PasswordTextBox.Text = SearchResultsDataGrid.Item("users_password", SearchResultsDataGrid.SelectedRows(0).Index).Value
            ''        User_ConfirmTextBox.Text = SearchResultsDataGrid.Item("users_password", SearchResultsDataGrid.SelectedRows(0).Index).Value
            ''        User_RoleComboBox.SelectedValue = SearchResultsDataGrid.Item("users_role", SearchResultsDataGrid.SelectedRows(0).Index).Value
        End If
    End Sub
End Class