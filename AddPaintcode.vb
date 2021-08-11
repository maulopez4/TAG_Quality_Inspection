Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class AddPaintcode
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    'Dim arrImage1() As Byte
    Private Sub AddPaintcode_Load(sender As Object, e As EventArgs) Handles Me.Load
        Paintcolor_IdTextBox.Clear()
        Paintcolor__CodeTextBox.Clear()
        Paintcolor_DescriptionTextBox.Clear()

        CreateNew_PaintcolorButton.Enabled = True
        AddNew_PaintcolorButton.Enabled = False
        ChangeSelected_PaintcolorButton.Enabled = False
        DeleteSelected_PaintcolorButton.Enabled = False
        Try
            Using PCBcommand As New MySqlCommand("SELECT `models_id`, `models_brand`, `models_mold`, `models_serial`,`models_color`,`models_description`,`models_status` FROM `models`", connection)
                Dim MLadapter As New MySqlDataAdapter(MLcommand)
                Dim MLtable As New DataTable()
                Dim ML = MLadapter.Fill(MLtable)
                PCDataGrid.DataSource = MLtable
            End Using
            Using CBcommand As New MySqlCommand("SELECT DISTINCT models_brand FROM models", connection)
                Dim CBadapter As New MySqlDataAdapter(CBcommand)
                Dim CBtable As New DataTable()
                CBadapter.Fill(CBtable)
                Paintcolor__BrandComboBox.DataSource = CBtable
                Paintcolor__BrandComboBox.ValueMember = "models_brand"
                Paintcolor__BrandComboBox.DisplayMember = "models_brand"
            End Using
            Using MCcommand As New MySqlCommand("SELECT DISTINCT models_color FROM models", connection)
                Dim MCadapter As New MySqlDataAdapter(MCcommand)
                Dim MCtable As New DataTable()
                MCadapter.Fill(MCtable)
                Model_ColorComboBox.DataSource = MCtable
                Model_ColorComboBox.ValueMember = "models_color"
                Model_ColorComboBox.DisplayMember = "models_color"
            End Using
            Using MScommand As New MySqlCommand("SELECT DISTINCT models_status FROM models", connection)
                Dim MSadapter As New MySqlDataAdapter(MScommand)
                Dim MStable As New DataTable()
                MSadapter.Fill(MStable)
                Paintcolor__StatusComboBox.DataSource = MStable
                Paintcolor__StatusComboBox.ValueMember = "models_status"
                Paintcolor__StatusComboBox.DisplayMember = "models_status"
            End Using
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub MLDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles PCDataGrid.SelectionChanged
        CreateNew_PaintcolorButton.Enabled = True
        AddNew_PaintcolorButton.Enabled = False
        ChangeSelected_PaintcolorButton.Enabled = True
        DeleteSelected_PaintcolorButton.Enabled = True
        If PCDataGrid.SelectedRows.Count > 0 Then
            Paintcolor_IdTextBox.Text = PCDataGrid.Item("models_id", PCDataGrid.SelectedRows(0).Index).Value
            Paintcolor__BrandComboBox.SelectedValue = PCDataGrid.Item("models_brand", PCDataGrid.SelectedRows(0).Index).Value
            Paintcolor__CodeTextBox.Text = PCDataGrid.Item("models_mold", PCDataGrid.SelectedRows(0).Index).Value
            Model_SerialTextBox.Text = PCDataGrid.Item("models_serial", PCDataGrid.SelectedRows(0).Index).Value
            Paintcolor__DescriptionTextBox.Text = PCDataGrid.Item("models_description", PCDataGrid.SelectedRows(0).Index).Value
            Model_ColorComboBox.SelectedValue = PCDataGrid.Item("models_color", PCDataGrid.SelectedRows(0).Index).Value
            Paintcolor__StatusComboBox.SelectedValue = PCDataGrid.Item("models_status", PCDataGrid.SelectedRows(0).Index).Value
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        connection.Close()
        Me.Close()
    End Sub
    Private Sub CreateNew_PaintcolorButton_Click(sender As Object, e As MouseEventArgs) Handles CreateNew_PaintcolorButton.Click
        Paintcolor_IdTextBox.Clear()
        Paintcolor__CodeTextBox.Clear()
        Model_SerialTextBox.Clear()
        Paintcolor__DescriptionTextBox.Clear()
        CreateNew_PaintcolorButton.Enabled = False
        AddNew_PaintcolorButton.Enabled = True
        ChangeSelected_PaintcolorButton.Enabled = False
        DeleteSelected_PaintcolorButton.Enabled = False
    End Sub
    Private Sub DeleteSelected_PaintcolorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelected_PaintcolorButton.Click
        Dim command As New MySqlCommand("DELETE FROM `models` WHERE `models_id` = @models_id", connection)
        command.Parameters.Add("@models_id", MySqlDbType.VarChar).Value = Paintcolor_IdTextBox.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Model Deleted")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddModel_Load(sender, e)
    End Sub
    Private Sub ChangeSelected_PaintcolorButton_Click(sender As Object, e As EventArgs) Handles ChangeSelected_PaintcolorButton.Click
        Dim command As New MySqlCommand("UPDATE `models` SET `models_brand` = @models_brand, `models_mold` = @models_mold, `models_serial` = @models_serial, `models_color` = @models_color, `modesl_description` = @models_description,  `models_status` = @models_status WHERE `models_id` = @models_id", connection)
        command.Parameters.Add("@models_id", MySqlDbType.VarChar).Value = Paintcolor_IdTextBox.Text
        command.Parameters.Add("@models_brand", MySqlDbType.VarChar).Value = Paintcolor__BrandComboBox.SelectedValue
        command.Parameters.Add("@models_mold", MySqlDbType.VarChar).Value = Paintcolor__CodeTextBox.Text
        command.Parameters.Add("@models_serial", MySqlDbType.VarChar).Value = Model_SerialTextBox.Text
        command.Parameters.Add("@models_color", MySqlDbType.VarChar).Value = Model_ColorComboBox.SelectedValue
        command.Parameters.Add("@models_description", MySqlDbType.VarChar).Value = Paintcolor__DescriptionTextBox.Text
        command.Parameters.Add("@models_status", MySqlDbType.VarChar).Value = Convert.ToInt32(Paintcolor__StatusComboBox.SelectedValue.GetHashCode())
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Model Updated")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddModel_Load(sender, e)
    End Sub
    Private Sub AddNew_PaintcolorButton_Click(sender As Object, e As EventArgs) Handles AddNew_PaintcolorButton.Click
        Dim command As New MySqlCommand("INSERT INTO `models` (`models_brand`,`models_mold`,`models_serial`,`models_color`,`models_description`,`models_status`) VALUES (@models_brand,@models_mold,@models_serial,@models_color,@models_description,@models_status)", connection)
        command.Parameters.Add("@models_id", MySqlDbType.VarChar).Value = Paintcolor_IdTextBox.Text
        command.Parameters.Add("@models_brand", MySqlDbType.VarChar).Value = Paintcolor__BrandComboBox.SelectedValue
        command.Parameters.Add("@models_mold", MySqlDbType.VarChar).Value = Paintcolor__CodeTextBox.Text
        command.Parameters.Add("@models_serial", MySqlDbType.VarChar).Value = Model_SerialTextBox.Text
        command.Parameters.Add("@models_color", MySqlDbType.VarChar).Value = Model_ColorComboBox.SelectedValue
        command.Parameters.Add("@models_description", MySqlDbType.VarChar).Value = Paintcolor__DescriptionTextBox.Text
        command.Parameters.Add("@models_status", MySqlDbType.VarChar).Value = Convert.ToInt32(Paintcolor__StatusComboBox.SelectedValue.GetHashCode())
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Model Added")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddModel_Load(sender, e)
    End Sub
End Class