Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Diagnostics
Imports System.IO
Imports Spire.Xls
Imports System.Linq
Imports zExcel
Imports System.Text

Public Class Export_Data
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)
    'Public folder_path As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Using LBcommand As New MySqlCommand("SELECT workstation_code,workstation_description FROM workstation")
        '    LBcommand.CommandType = CommandType.Text
        '    LBcommand.Connection = connection
        '    connection.Open()
        '    Select_ListBox.DataSource = LBcommand.ExecuteReader()
        '    'Select_ListBox.Item.Clear()
        '    'If data_reader.HasRows Then
        '    '    Do While data_reader.Read()
        '    '        WorkItemNumber = data_reader.Item("work item number")
        '    '        Description = data_reader.Item("description")
        '    '        ListBox1.Items.Add(New ListItem(Description, WorkItemNumber)
        '    '    Loop
        '    'End If
        '    connection.Close()
        'End Using
    End Sub
    Private Sub GetData_Button_Click(sender As Object, e As EventArgs) Handles GetData_Button.Click
        Dim array()
        ReDim array(Selected_ListBox.Items.Count - 1)
        Selected_ListBox.Items.CopyTo(array, 0)
        Dim SList As String = String.Join("','", array)
        Dim From As String = From_DateTimePicker.Value.ToString("yyyy-MM-dd")
        Dim Till As String = Till_DateTimePicker.Value.ToString("yyyy-MM-dd")
        Dim sql As String = "SELECT `workorder_date`, `workorder_workstation`, `workorder_number`, `workorder_serial`, `workorder_consecutive`, `workorder_paintcode`, `workorder_moldbrand`, `workorder_moldmodel`, `workorder_moldserial`,  `workorder_defect_origin`, `workorder_defect`, `workorder_defect_location`, `workorder_comments` FROM `workorder` WHERE `workorder_workstation` IN (" & "'" & SList & "'" & ") AND `workorder_date` >= CAST('" & From & "' AS DATE) AND `workorder_date` <= CAST('" & Till & "' AS DATE) AND `workorder_rework` != 'RW08'"

        Using RJcommand As New MySqlCommand(sql, connection)
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
    End Sub
    Private Sub Export_Button_Click(sender As Object, e As EventArgs) Handles Export_Button.Click
        DataGridToCSV(RejectedDataGridView)
    End Sub
    Private Sub DataGridToCSV(ByRef dt As DataGridView)
        Dim farray()
        ReDim farray(Selected_ListBox.Items.Count - 1)
        Selected_ListBox.Items.CopyTo(farray, 0)
        Dim SList As String = String.Join("_", farray)
        Dim fileName As String = ("DataDump-" & SList & "-" & System.DateTime.Now.ToString("yyyyMMdd"))
        Dim TB As DataGridView = RejectedDataGridView

        Try
            If TB.RowCount < 1 Then
                MessageBox.Show("No records found on table", "ExControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Dim Dg As New SaveFileDialog
            Dg.FileName = fileName
            Dg.Filter = "CSV|*.csv"
            Dg.Title = "Save File"
            Dg.ShowDialog()
            If Dg.FileName.Length > 3 Then
                ' Write each directory name to a file.
                Using fi As StreamWriter = New StreamWriter(Dg.FileName)
                    Dim c, f As Integer
                    Dim l As String = ""
                    For c = 0 To TB.ColumnCount - 1
                        l += TB.Columns(c).HeaderText
                        If c < TB.ColumnCount - 1 Then l += ";"
                    Next
                    fi.WriteLine(l)
                    fi.WriteLine("")
                    For f = 0 To TB.Rows.Count - 1
                        Dim li As String = ""
                        For c = 0 To TB.ColumnCount - 1
                            li += Strings.Replace(TB(c, f).Value.ToString, ";", ".")
                            If c < TB.ColumnCount - 1 Then li += ";"
                        Next
                        fi.WriteLine(li)
                    Next
                    fi.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Can not save file to folder, please review credentials", "ExControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Close()
    End Sub
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        If Select_ListBox.SelectedItems.Count > 0 Then
            For i As Int32 = Select_ListBox.SelectedItems.Count - 1 To 0 Step -1
                Selected_ListBox.Items.Add(Select_ListBox.SelectedItems(i))
                Select_ListBox.Items.Remove(Select_ListBox.SelectedItems(i))
            Next
        End If
    End Sub
    Private Sub Remove_Button_Click(sender As Object, e As EventArgs) Handles Remove_Button.Click
        If Selected_ListBox.SelectedItems.Count > 0 Then
            For a As Int32 = Selected_ListBox.SelectedItems.Count - 1 To 0 Step -1
                Select_ListBox.Items.Add(Selected_ListBox.SelectedItems(a))
                Selected_ListBox.Items.Remove(Selected_ListBox.SelectedItems(a))
            Next
        End If
    End Sub
End Class