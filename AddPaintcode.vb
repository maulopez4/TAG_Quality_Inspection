Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class AddPaintcode
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    Private Sub AddPaintcode_Load(sender As Object, e As EventArgs) Handles Me.Load
        Paintcode_IdTextBox.Clear()
        Paintcode_DescriptionTextBox.Clear()
        Paintcode_CodeTextBox.Clear()
        Paintcode_DescriptionTextBox.Clear()
        Paintcode_IdTextBox.Enabled = False
        Paintcode_BrandTextBox.Enabled = False
        Paintcode_CodeTextBox.Enabled = False
        Paintcode_DescriptionTextBox.Enabled = False

        CreateNew_Button.Enabled = True
        AddNew_Button.Enabled = False
        EditSelected_Button.Enabled = False
        UpdateSelected_Button.Enabled = False
        DeleteSelected_Button.Enabled = False
        Try
            Using PCDcommand As New MySqlCommand("SELECT `paintcode_id`, `paintcode_code`, `paintcode_brandname`, `paintcode_description` FROM `paintcode`", connection)
                Dim PCDadapter As New MySqlDataAdapter(PCDcommand)
                Dim PCDtable As New DataTable()
                Dim PCD = PCDadapter.Fill(PCDtable)
                PCDataGrid.DataSource = PCDtable
                With PCDataGrid
                    .RowHeadersVisible = True
                    .Columns(0).HeaderCell.Value = "Paintcode ID"
                    .Columns(1).HeaderCell.Value = "Code"
                    .Columns(2).HeaderCell.Value = "Brand Name"
                    .Columns(3).HeaderCell.Value = "Description"
                End With
            End Using
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub PCDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles PCDataGrid.SelectionChanged
        Paintcode_IdTextBox.Enabled = False
        Paintcode_BrandTextBox.Enabled = False
        Paintcode_CodeTextBox.Enabled = False
        Paintcode_DescriptionTextBox.Enabled = False
        CreateNew_Button.Enabled = True
        AddNew_Button.Enabled = False
        EditSelected_Button.Enabled = True
        UpdateSelected_Button.Enabled = False
        DeleteSelected_Button.Enabled = True
        If PCDataGrid.SelectedRows.Count > 0 Then
            Paintcode_IdTextBox.Text = PCDataGrid.Item("paintcode_id", PCDataGrid.SelectedRows(0).Index).Value
            Paintcode_BrandTextBox.Text = PCDataGrid.Item("paintcode_brandname", PCDataGrid.SelectedRows(0).Index).Value
            Paintcode_CodeTextBox.Text = PCDataGrid.Item("paintcode_code", PCDataGrid.SelectedRows(0).Index).Value
            Paintcode_DescriptionTextBox.Text = PCDataGrid.Item("paintcode_description", PCDataGrid.SelectedRows(0).Index).Value
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        connection.Close()
        Me.Close()
    End Sub
    Private Sub DeleteSelected_PaintcolorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelected_Button.Click
        Dim command As New MySqlCommand("DELETE FROM `paintcode` WHERE `paintcode_id` = @paintcode_id", connection)
        command.Parameters.Add("@paintcode_id", MySqlDbType.VarChar).Value = Paintcode_IdTextBox.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("PaintCode Deleted")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddPaintcode_Load(sender, e)
    End Sub
    Private Sub EditSelected_Button_Click(sender As Object, e As EventArgs) Handles EditSelected_Button.Click
        Paintcode_IdTextBox.Enabled = False
        Paintcode_BrandTextBox.Enabled = True
        Paintcode_CodeTextBox.Enabled = True
        Paintcode_DescriptionTextBox.Enabled = True
        CreateNew_Button.Enabled = False
        AddNew_Button.Enabled = False
        EditSelected_Button.Enabled = False
        UpdateSelected_Button.Enabled = True
        DeleteSelected_Button.Enabled = True
    End Sub
    Private Sub UpdateSelected_Button_Click(sender As Object, e As EventArgs) Handles UpdateSelected_Button.Click
        Dim command As New MySqlCommand("UPDATE `paintcode` SET `paintcode_brandname` = @paintcode_brandname, `paintcode_code` = @paintcode_code, `paintcode_description` = @paintcode_description WHERE `paintcode_id` = @paintcode_id", connection)
        command.Parameters.Add("@paintcode_id", MySqlDbType.VarChar).Value = Paintcode_IdTextBox.Text
        command.Parameters.Add("@paintcode_brandname", MySqlDbType.VarChar).Value = Paintcode_BrandTextBox.Text
        command.Parameters.Add("@paintcode_code", MySqlDbType.VarChar).Value = Paintcode_CodeTextBox.Text
        command.Parameters.Add("@paintcode_description", MySqlDbType.VarChar).Value = Paintcode_DescriptionTextBox.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Paintcode Updated")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddPaintcode_Load(sender, e)
    End Sub
    Private Sub CreateNew_Button_Click(sender As Object, e As EventArgs) Handles CreateNew_Button.Click
        Paintcode_IdTextBox.Clear()
        Paintcode_BrandTextBox.Clear()
        Paintcode_CodeTextBox.Clear()
        Paintcode_DescriptionTextBox.Clear()
        Paintcode_BrandTextBox.Enabled = True
        Paintcode_CodeTextBox.Enabled = True
        Paintcode_DescriptionTextBox.Enabled = True
        CreateNew_Button.Enabled = False
        AddNew_Button.Enabled = True
        EditSelected_Button.Enabled = False
        DeleteSelected_Button.Enabled = False
    End Sub
    Private Sub AddNew_Button_Click(sender As Object, e As EventArgs) Handles AddNew_Button.Click
        Dim command As New MySqlCommand("INSERT INTO `paintcode` (`paintcode_brandname`,`paintcode_code`,`paintcode_description`) VALUES (@paintcode_brandname,@paintcode_code,@paintcode_description)", connection)
        command.Parameters.Add("@paintcode_brandname", MySqlDbType.VarChar).Value = Paintcode_BrandTextBox.Text
        command.Parameters.Add("@paintcode_code", MySqlDbType.VarChar).Value = Paintcode_CodeTextBox.Text
        command.Parameters.Add("@paintcode_description", MySqlDbType.VarChar).Value = Paintcode_DescriptionTextBox.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Paint Code Added")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddPaintcode_Load(sender, e)
    End Sub
End Class