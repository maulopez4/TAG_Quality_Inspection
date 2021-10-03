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
    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Using LBcommand As New MySqlCommand("SELECT workstation_code,workstation_description FROM workstation")
        '    Dim data_reader As MySqlDataReader
        '    LBcommand.CommandType = CommandType.Text
        '    LBcommand.Connection = connection
        '    connection.Open()
        '    data_reader = LBcommand.ExecuteReader()
        '    Select_ListBox.Items.Clear()
        '    If data_reader.HasRows Then
        '        Do While data_reader.Read()
        '            Dim Code As ListItem = data_reader.Item("workstation_code")
        '            Dim Description As ListItem = data_reader.Item("workstation_description")
        '            Select_ListBox.Items.Add(New ListItem(Code, Description))
        '        Loop
        '    End If
        '    connection.Close()
        'End Using
        Using LScommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim LSadapter As New MySqlDataAdapter(LScommand)
            Dim LSTable As New DataTable()
            Dim LS = LSadapter.Fill(LSTable)
            CheckedListBox1.DataSource = LSTable
            CheckedListBox1.ValueMember = "workstation_code"
            CheckedListBox1.DisplayMember = "workstation_description"
            connection.Close()
        End Using

    End Sub
    Private Sub GetData_Button_Click(sender As Object, e As EventArgs) Handles GetData_Button.Click

        Dim s As String = ""
        For a As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemCheckState(a) = CheckState.Checked Then
                s += CheckedListBox1.Items(a).ToString
            End If
        Next
        Dim ls As String = String.Join(",", s)
        MessageBox.Show(ls)

        'Dim From As String = From_DateTimePicker.Value.ToString("yyyy-MM-dd")
        'Dim Till As String = Till_DateTimePicker.Value.ToString("yyyy-MM-dd")
        ''Dim sql As String = "SELECT DATE_FORMAT(`workorder_date`, '%m/%d/%Y'), `workorder_time`,`workorder_workstation`,
        ''                            `workorder_number`, `rework_description`,`workorder_consecutive`,
        ''                            `workorder_paintcode`, `workorder_moldbrand`, `workorder_moldmodel`,
        ''                            `workorder_moldserial`,`workorder_defect_origin`,`workorder_defect`,
        ''                            `defects_description`, `workorder_defect_location`, `workorder_comments` FROM `workorder`
        ''                            INNER JOIN `defects` ON `defects_code` = `workorder_defect`
        ''                            INNER JOIN `rework` ON `rework_code` = `workorder_rework` 
        ''                            AND `workorder_workstation` IN (" & "'" & SList & "'" & ") 
        ''                            AND `workorder_date` >= CAST('" & From & "' AS DATE) 
        ''                            AND `workorder_date` <= CAST('" & Till & "' AS DATE) 
        ''                            AND `workorder_rework` != 'RW08'"
        'Dim sql As String = "SELECT DATE_FORMAT(`workorder_date`, '%m/%d/%Y'), `workorder_time`, `workorder_workstation`, `workstation_description`, `workorder_number`, 
        '                                            `workorder_moldbrand`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_defect_origin`,
        '                                            `workstation_description`, `workorder_defect`, `defects_description`, `workorder_defect_location`, 
        '                                            `workorder_rework`,`rework_description`, `workorder_status`, `workorder_comments` FROM `workorder` 
        '                                            INNER JOIN `defects` ON `workorder_defect` = `defects_code` 
        '                                            INNER JOIN `workstation` ON `workorder_workstation` = `workstation_code`
        '                                            INNER JOIN `rework` ON `workorder_rework` = `rework_code`
        '                                            WHERE `workorder_workstation` IN (" & "'" & SList & "'" & ") 
        '                                            AND `workorder_date` >= CAST('" & From & "' AS DATE) 
        '                                            AND `workorder_date` <= CAST('" & Till & "' AS DATE) 
        '                                            AND `workorder_rework` != 'RW08'"

        'Using EXcommand As New MySqlCommand(sql, connection)
        '    Dim EXadapter As New MySqlDataAdapter(EXcommand)
        '    Dim EXtable As New DataTable()
        '    Dim EX = EXadapter.Fill(EXtable)
        '    ExportDataGridView.DataSource = EXtable
        '    With ExportDataGridView
        '        .RowHeadersVisible = True
        '        .Columns(0).HeaderCell.Value = "Date"
        '        .Columns(1).HeaderCell.Value = "Time"
        '        .Columns(2).HeaderCell.Value = "Workstation Code"
        '        .Columns(2).Visible = False
        '        .Columns(3).HeaderCell.Value = "Workstation Name"
        '        .Columns(4).HeaderCell.Value = "Work Order"
        '        .Columns(5).HeaderCell.Value = "Mold Brand"
        '        .Columns(6).HeaderCell.Value = "Mold Model"
        '        .Columns(7).HeaderCell.Value = "Mold Serial"
        '        .Columns(8).HeaderCell.Value = "Paint Code"
        '        .Columns(9).HeaderCell.Value = "Defect Origin Code"
        '        .Columns(9).Visible = False
        '        .Columns(10).HeaderCell.Value = "Defect Origin"
        '        .Columns(11).HeaderCell.Value = "Defect Code"
        '        .Columns(11).Visible = False
        '        .Columns(12).HeaderCell.Value = "Defect Description"
        '        .Columns(13).HeaderCell.Value = "Defect Location"
        '        .Columns(14).HeaderCell.Value = "Rework Code"
        '        .Columns(14).Visible = False
        '        .Columns(15).HeaderCell.Value = "Rework Description"
        '        .Columns(16).HeaderCell.Value = "Work Order Status"
        '        .Columns(17).HeaderCell.Value = "Comments"
        '        .Columns(18).HeaderCell.Value = "Image1"
        '        .Columns(18).Visible = False
        '        .Columns(19).HeaderCell.Value = "Image2"
        '        .Columns(19).Visible = False
        '        .Columns(20).HeaderCell.Value = "Image3"
        '        .Columns(20).Visible = False
        '    End With
        'End Using
    End Sub
    Private Sub Export_Button_Click(sender As Object, e As EventArgs) Handles Export_Button.Click
        DataGridToCSV(ExportDataGridView)
    End Sub
    Private Sub DataGridToCSV(ByRef dt As DataGridView)
        'Dim farray()
        'ReDim farray(CheckedListBox1.Items.Count - 1)
        'CheckedListBox1.Items.CopyTo(farray, 0)
        'Dim SList As String = String.Join(",", farray)

        Dim SList_Array As New System.Collections.ArrayList()

        For i As Int32 = CheckedListBox1.SelectedItems.Count - 1 To 0 Step -1
            SList_Array.Add(i)
        Next

        'Dim fileName As String = ("DataDump-" & SList & "-" & System.DateTime.Now.ToString("yyyyMMdd"))
        'Dim TB As DataGridView = ExportDataGridView

        'Try
        '    If TB.RowCount < 1 Then
        '        MessageBox.Show("No records found on table", "ExControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        '    Dim Dg As New SaveFileDialog
        '    Dg.FileName = fileName
        '    Dg.Filter = "CSV|*.csv"
        '    Dg.Title = "Save File"
        '    Dg.ShowDialog()
        '    If Dg.FileName.Length > 3 Then
        '        ' Write each directory name to a file.
        '        Using fi As StreamWriter = New StreamWriter(Dg.FileName)
        '            Dim c, f As Integer
        '            Dim l As String = ""
        '            For c = 0 To TB.ColumnCount - 1
        '                l += TB.Columns(c).HeaderText
        '                If c < TB.ColumnCount - 1 Then l += ";"
        '            Next
        '            fi.WriteLine(l)
        '            fi.WriteLine("")
        '            For f = 0 To TB.Rows.Count - 1
        '                Dim li As String = ""
        '                For c = 0 To TB.ColumnCount - 1
        '                    li += Strings.Replace(TB(c, f).Value.ToString, ";", ".")
        '                    If c < TB.ColumnCount - 1 Then li += ";"
        '                Next
        '                fi.WriteLine(li)
        '            Next
        '            fi.Close()
        '        End Using
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Can not save file to folder, please review credentials", "ExControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try

    End Sub
    'Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
    '    Close()
    'End Sub
    'Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click, Selection_ListBox.MouseDoubleClick
    '    If Selection_ListBox.SelectedItems.Count > 0 Then
    '        For i As Int32 = Selection_ListBox.SelectedItems.Count - 1 To 0 Step -1
    '            Selected_ListBox.Items.Add(Selection_ListBox.SelectedItems(i))
    '            'Selection_ListBox.Items.Remove(Selection_ListBox.SelectedItems(i))
    '        Next
    '    End If
    'End Sub
    'Private Sub Remove_Button_Click(sender As Object, e As EventArgs) Handles Remove_Button.Click, Selected_ListBox.MouseDoubleClick
    '    If Selected_ListBox.SelectedItems.Count > 0 Then
    '        For a As Int32 = Selected_ListBox.SelectedItems.Count - 1 To 0 Step -1
    '            Selection_ListBox.Items.Add(Selected_ListBox.SelectedItems(a))
    '            'Selected_ListBox.Items.Remove(Selected_ListBox.SelectedItems(a))
    '        Next
    '    End If
    'End Sub
End Class