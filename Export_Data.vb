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
    Public Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Using WScommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim WSadapter As New MySqlDataAdapter(WScommand)
            Dim WStable As New DataTable()
            Dim WS = WSadapter.Fill(WStable)
            Selection_ListBox.DataSource = WStable
            Selection_ListBox.ValueMember = "workstation_code"
            Selection_ListBox.DisplayMember = "workstation_description"
        End Using

    End Sub
    Private Sub GetData_Button_Click(sender As Object, e As EventArgs) Handles GetData_Button.Click
        Dim SL As New List(Of String)
        For Each item As Object In Selection_ListBox.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            SL.Add(row("workstation_code"))
        Next
        Dim SList As String = String.Join("','", SL).ToString

        Dim From As String = From_DateTimePicker.Value.ToString("yyyy-MM-dd")
        Dim Till As String = Till_DateTimePicker.Value.ToString("yyyy-MM-dd")
        Dim sql As String = "SELECT `workorder_id`, DATE_FORMAT(`workorder_date`, '%m/%d/%Y'), `workorder_time`, `workorder_reportedby`, `workorder_workstation`, `workstation_description`, `workorder_number`, 
                                                    `workorder_moldbrand`, `workorder_productline`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_defect_origin`,
                                                    `workstation_description`, `workorder_defect`, `defects_description`, `workorder_defect_location`, 
                                                    `workorder_rework`,`rework_description`, `workorder_status`, `workorder_comments` FROM `workorder` 
                                                    INNER JOIN `defects` ON `workorder_defect` = `defects_code` 
                                                    INNER JOIN `workstation` ON `workorder_workstation` = `workstation_code`
                                                    INNER JOIN `rework` ON `workorder_rework` = `rework_code`
                                                    AND `workorder_workstation` IN ('" & SList & "') 
                                                    AND `workorder_date` >= CAST('" & From & "' AS DATE) 
                                                    AND `workorder_date` <= CAST('" & Till & "' AS DATE) 
                                                    AND `workorder_rework` != 'RW08'
                                                    ORDER BY `workorder_date` desc, `workorder_time` desc"
        Using RJcommand As New MySqlCommand(sql, connection)
            Dim RJadapter As New MySqlDataAdapter(RJcommand)
            Dim RJtable As New DataTable()
            Dim RJ = RJadapter.Fill(RJtable)
            ReportedDataGridView.DataSource = RJtable
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
                .Columns(7).HeaderCell.Value = "Mold Brand"
                .Columns(8).HeaderCell.Value = "Product Line"
                .Columns(9).HeaderCell.Value = "Mold Model"
                .Columns(10).HeaderCell.Value = "Mold Serial"
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
        End Using
    End Sub
    Private Sub Export_Button_Click(sender As Object, e As EventArgs) Handles Export_Button.Click
        DataGridToCSV(ReportedDataGridView)
    End Sub
    Private Sub DataGridToCSV(ByRef dt As DataGridView)
        Dim NL As New List(Of String)
        For Each item As Object In Selection_ListBox.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            NL.Add(row("workstation_code"))
        Next
        Dim NList As String = String.Join("_", NL).ToString
        Dim fileName As String = ("DataDump-" & NList & "-" & System.DateTime.Now.ToString("yyyyMMdd"))
        Dim TB As DataGridView = ReportedDataGridView

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
    'Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click, Selection_ListBox.DoubleClick
    '    If Selection_ListBox.SelectedItems.Count > 0 Then
    '        For i As Int32 = Selection_ListBox.SelectedItems.Count - 1 To 0 Step -1
    '            Selected_ListBox.Items.Add(Selection_ListBox.SelectedItems(i))
    '            Selection_ListBox.Items.Remove(Selection_ListBox.SelectedItems(i))
    '        Next
    '    End If
    'End Sub
    'Private Sub Remove_Button_Click(sender As Object, e As EventArgs) Handles Remove_Button.Click, Selected_ListBox.DoubleClick
    '    If Selected_ListBox.SelectedItems.Count > 0 Then
    '        For a As Int32 = Selected_ListBox.SelectedItems.Count - 1 To 0 Step -1
    '            Selection_ListBox.Items.Add(Selected_ListBox.SelectedItems(a))
    '            Selected_ListBox.Items.Remove(Selected_ListBox.SelectedItems(a))
    '        Next
    '    End If
    'End Sub
End Class