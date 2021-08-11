Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class AddModel
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    'Dim arrImage1() As Byte
    Private Sub AddModel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Model_IdTextBox.Clear()
        Model_MoldTextBox.Clear()
        Model_SerialTextBox.Clear()
        Model_DescriptionTextBox.Clear()

        CreateNew_MoldButton.Enabled = True
        AddNew_MoldButton.Enabled = False
        ChangeSelected_MoldButton.Enabled = False
        DeleteSelected_MoldButton.Enabled = False
        Try
            Using MLcommand As New MySqlCommand("SELECT `models_id`, `models_brand`, `models_mold`, `models_serial`,`models_color`,`models_description`,`models_status` FROM `models`", connection)
                Dim MLadapter As New MySqlDataAdapter(MLcommand)
                Dim MLtable As New DataTable()
                Dim ML = MLadapter.Fill(MLtable)
                MLDataGrid.DataSource = MLtable
            End Using
            Using CBcommand As New MySqlCommand("SELECT DISTINCT models_brand FROM models", connection)
                Dim CBadapter As New MySqlDataAdapter(CBcommand)
                Dim CBtable As New DataTable()
                CBadapter.Fill(CBtable)
                Model_BrandComboBox.DataSource = CBtable
                Model_BrandComboBox.ValueMember = "models_brand"
                Model_BrandComboBox.DisplayMember = "models_brand"
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
                Model_StatusComboBox.DataSource = MStable
                Model_StatusComboBox.ValueMember = "models_status"
                Model_StatusComboBox.DisplayMember = "models_status"
            End Using
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub MLDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles MLDataGrid.SelectionChanged
        CreateNew_MoldButton.Enabled = True
        AddNew_MoldButton.Enabled = False
        ChangeSelected_MoldButton.Enabled = True
        DeleteSelected_MoldButton.Enabled = True
        If MLDataGrid.SelectedRows.Count > 0 Then
            Model_IdTextBox.Text = MLDataGrid.Item("models_id", MLDataGrid.SelectedRows(0).Index).Value
            Model_BrandComboBox.SelectedValue = MLDataGrid.Item("models_brand", MLDataGrid.SelectedRows(0).Index).Value
            Model_MoldTextBox.Text = MLDataGrid.Item("models_mold", MLDataGrid.SelectedRows(0).Index).Value
            Model_SerialTextBox.Text = MLDataGrid.Item("models_serial", MLDataGrid.SelectedRows(0).Index).Value
            Model_DescriptionTextBox.Text = MLDataGrid.Item("models_description", MLDataGrid.SelectedRows(0).Index).Value
            Model_ColorComboBox.SelectedValue = MLDataGrid.Item("models_color", MLDataGrid.SelectedRows(0).Index).Value
            Model_StatusComboBox.SelectedValue = MLDataGrid.Item("models_status", MLDataGrid.SelectedRows(0).Index).Value
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        connection.Close()
        Me.Close()
    End Sub
    Private Sub CreateNew_MoldButton_Click(sender As Object, e As MouseEventArgs) Handles CreateNew_MoldButton.Click
        Model_IdTextBox.Clear()
        Model_MoldTextBox.Clear()
        Model_SerialTextBox.Clear()
        Model_DescriptionTextBox.Clear()
        CreateNew_MoldButton.Enabled = False
        AddNew_MoldButton.Enabled = True
        ChangeSelected_MoldButton.Enabled = False
        DeleteSelected_MoldButton.Enabled = False
    End Sub
    Private Sub DeleteSelected_MoldButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelected_MoldButton.Click
        Dim command As New MySqlCommand("DELETE FROM `models` WHERE `models_id` = @models_id", connection)
        command.Parameters.Add("@models_id", MySqlDbType.VarChar).Value = Model_IdTextBox.Text
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Model Deleted")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddModel_Load(sender, e)
    End Sub
    Private Sub ChangeSelected_MoldButton_Click(sender As Object, e As EventArgs) Handles ChangeSelected_MoldButton.Click
        Dim command As New MySqlCommand("UPDATE `models` SET `models_brand` = @models_brand, `models_mold` = @models_mold, `models_serial` = @models_serial, `models_color` = @models_color, `modesl_description` = @models_description,  `models_status` = @models_status WHERE `models_id` = @models_id", connection)
        command.Parameters.Add("@models_id", MySqlDbType.VarChar).Value = Model_IdTextBox.Text
        command.Parameters.Add("@models_brand", MySqlDbType.VarChar).Value = Model_BrandComboBox.SelectedValue
        command.Parameters.Add("@models_mold", MySqlDbType.VarChar).Value = Model_MoldTextBox.Text
        command.Parameters.Add("@models_serial", MySqlDbType.VarChar).Value = Model_SerialTextBox.Text
        command.Parameters.Add("@models_color", MySqlDbType.VarChar).Value = Model_ColorComboBox.SelectedValue
        command.Parameters.Add("@models_description", MySqlDbType.VarChar).Value = Model_DescriptionTextBox.Text
        command.Parameters.Add("@models_status", MySqlDbType.VarChar).Value = Convert.ToInt32(Model_StatusComboBox.SelectedValue.GetHashCode())
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Model Updated")
        Else
            MessageBox.Show("ERROR")
        End If
        connection.Close()
        AddModel_Load(sender, e)
    End Sub
    Private Sub AddNew_MoldButton_Click(sender As Object, e As EventArgs) Handles AddNew_MoldButton.Click
        Dim command As New MySqlCommand("INSERT INTO `models` (`models_brand`,`models_mold`,`models_serial`,`models_color`,`models_description`,`models_status`) VALUES (@models_brand,@models_mold,@models_serial,@models_color,@models_description,@models_status)", connection)
        command.Parameters.Add("@models_id", MySqlDbType.VarChar).Value = Model_IdTextBox.Text
        command.Parameters.Add("@models_brand", MySqlDbType.VarChar).Value = Model_BrandComboBox.SelectedValue
        command.Parameters.Add("@models_mold", MySqlDbType.VarChar).Value = Model_MoldTextBox.Text
        command.Parameters.Add("@models_serial", MySqlDbType.VarChar).Value = Model_SerialTextBox.Text
        command.Parameters.Add("@models_color", MySqlDbType.VarChar).Value = Model_ColorComboBox.SelectedValue
        command.Parameters.Add("@models_description", MySqlDbType.VarChar).Value = Model_DescriptionTextBox.Text
        command.Parameters.Add("@models_status", MySqlDbType.VarChar).Value = Convert.ToInt32(Model_StatusComboBox.SelectedValue.GetHashCode())
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
