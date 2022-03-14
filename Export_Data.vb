﻿Imports MySql.Data.MySqlClient
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
    Dim rs As New Resizer
    Public Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Using WScommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim WSadapter As New MySqlDataAdapter(WScommand)
            Dim WStable As New DataTable()
            Dim WS = WSadapter.Fill(WStable)
            Selection_ListBox.DataSource = WStable
            Selection_ListBox.ValueMember = "workstation_code"
            Selection_ListBox.DisplayMember = "workstation_description"
        End Using
        FilterView_ComboBox.SelectedIndex = 0
        rs.FindAllControls(Me)
    End Sub
    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    'Get the first day of the month
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function
    'Get the last day of the month
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function
    Private Sub GetData_Button_Click(sender As Object, e As EventArgs) Handles GetData_Button.Click
        Dim SL As New List(Of String)
        For Each item As Object In Selection_ListBox.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            SL.Add(row("workstation_code"))
        Next
        Dim SList As String = String.Join("','", SL).ToString
        From_DateTimePicker.Value = FirstDayOfMonth(Today())
        Till_DateTimePicker.Value = LastDayOfMonth(Today())
        Dim From As String = From_DateTimePicker.Value.ToString("yyyy-MM-dd")
        Dim Till As String = Till_DateTimePicker.Value.ToString("yyyy-MM-dd")
        Using RJcommand As New MySqlCommand("SELECT `workorder_id`,`workorder_date`, `workorder_time`, `workorder_reportedby`, `workorder_workstation`, `workstation_description`, `workorder_number`, 
                                                    `workorder_moldbrand`, `workorder_productline`, `workorder_moldmodel`, `workorder_moldserial`, `workorder_paintcode`, `workorder_defect_origin`,
                                                    `workstation_description`, `workorder_defect`, `defects_description`, `workorder_defect_location`, 
                                                    `workorder_rework`,`rework_description`, `workorder_status`, `workorder_comments` FROM `workorder` 
                                                    INNER JOIN `defects` ON `workorder_defect` = `defects_code` 
                                                    INNER JOIN `workstation` ON `workorder_workstation` = `workstation_code`
                                                    INNER JOIN `rework` ON `workorder_rework` = `rework_code`
                                                    AND `workorder_workstation` IN ('" & SList & "') 
                                                    AND `workorder_date` >= CAST('" & From & "' AS DATE) 
                                                    AND `workorder_date` <= CAST('" & Till & "' AS DATE)
                                                    AND `workorder_status` LIKE CONCAT (@Filter, '%')
                                                    AND `workorder_rework` != 'RW08'
                                                    ORDER BY `workorder_date` desc, `workorder_time` desc", connection)
            RJcommand.Parameters.AddWithValue("@Filter", Filter_Show())
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
    'Public Function Filter_Export()
    '    Dim export_filter As String = FilterExport_ComboBox.SelectedItem.ToString
    '    Dim filter_view As String
    '    Select Case export_filter
    '        Case "Approved Only"
    '            filter_view = "APPROVED"
    '            Return filter_view
    '        Case "Repaired Only"
    '            filter_view = "REPAIRED"
    '            Return filter_view
    '        Case "Reported Only"
    '            filter_view = "REPORTED"
    '            Return filter_view
    '        Case Else
    '            filter_view = ""
    '            Return filter_view
    '    End Select
    'End Function
    Public Function Filter_Show()
        Dim case_view As String = FilterView_ComboBox.SelectedItem.ToString
        Dim filter_view As String
        Select Case case_view
            Case "Approved Only"
                filter_view = "APPROVED"
                Return filter_view
            Case "Repaired Only"
                filter_view = "REPAIRED"
                Return filter_view
            Case "Reported Only"
                filter_view = "REPORTED"
                Return filter_view
            Case Else
                filter_view = ""
                Return filter_view
        End Select
    End Function
    Private Sub Export_Button_Click(sender As Object, e As EventArgs) Handles Export_Button.Click
        DataGridToCSV(ReportedDataGridView)
    End Sub
    Private Sub DataGridToCSV(ByRef ReportedDataGridView As DataGridView)
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

            Dim Dg As New SaveFileDialog With {
                .FileName = fileName,
                .Filter = "CSV|*.csv",
                .Title = "Save File"
            }
            Dg.ShowDialog()
            If Dg.FileName.Length > 3 Then
                ' Write each directory name to a file.
                Using fi As New StreamWriter(Dg.FileName)
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

End Class