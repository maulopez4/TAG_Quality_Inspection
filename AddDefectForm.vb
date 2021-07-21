Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class AddDefect
    Dim connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Dim connection As New MySqlConnection(connection_string)
    Private Sub AddDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeTextBox.Text = System.DateTime.Now.ToString("HH:mm:ss")

        Using WScommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim WSadapter As New MySqlDataAdapter(WScommand)
            Dim WStable As New DataTable()
            WSadapter.Fill(WStable)

            WorkStationComboBox.DataSource = WStable
            WorkStationComboBox.ValueMember = "workstation_code"
            WorkStationComboBox.DisplayMember = "workstation_description"
        End Using
        Using RWcommand As New MySqlCommand("SELECT `rework_code`, `rework_description` FROM `rework`", connection)
            Dim RWadapter As New MySqlDataAdapter(RWcommand)
            Dim RWtable As New DataTable()
            RWadapter.Fill(RWtable)

            ReworkTypeComboBox.DataSource = RWtable
            ReworkTypeComboBox.ValueMember = "rework_code"
            ReworkTypeComboBox.DisplayMember = "rework_description"
        End Using
        Using DLcommand As New MySqlCommand("SELECT `location_code`, `location_description` FROM `locations`", connection)
            Dim DLadapter As New MySqlDataAdapter(DLcommand)
            Dim DLtable As New DataTable()
            DLadapter.Fill(DLtable)

            DefectLocationComboBox.DataSource = DLtable
            DefectLocationComboBox.ValueMember = "location_code"
            DefectLocationComboBox.DisplayMember = "location_description"
        End Using
        Using DOcommand As New MySqlCommand("SELECT `workstation_code`, `workstation_description` FROM `workstation`", connection)
            Dim DOadapter As New MySqlDataAdapter(DOcommand)
            Dim DOtable As New DataTable()
            DOadapter.Fill(DOtable)

            DefectOriginComboBox.DataSource = DOtable
            DefectOriginComboBox.ValueMember = "workstation_code"
            DefectOriginComboBox.DisplayMember = "workstation_description"
        End Using
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
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub DefectOriginComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DefectOriginComboBox.SelectedIndexChanged

        Dim Defect_Origin As String
        Dim toString As String = DefectOriginComboBox.Text.ToString
        Defect_Origin = toString
        Select Case Defect_Origin
            Case "LAMINACION"
                With DefectComboBox
                    Using DFcommand As New MySqlCommand("SELECT `defect_code`, `defect_description` FROM `defects` WHERE `defect_workstation` = 'LAMINACION'", connection)
                        Dim DFadapter As New MySqlDataAdapter(DFcommand)
                        Dim DFtable As New DataTable()
                        DFadapter.Fill(DFtable)

                        DefectComboBox.DataSource = DFtable
                        DefectComboBox.ValueMember = "defect_code"
                        DefectComboBox.DisplayMember = "defect_description"
                    End Using
                End With
            Case "RIEL_Y_RETRABAJOS"
                With DefectComboBox
                    Using DFcommand As New MySqlCommand("SELECT `defect_code`, `defect_description` FROM `defects` WHERE `defect_workstation` = 'RIEL_Y_RETRABAJOS'", connection)
                        Dim DFadapter As New MySqlDataAdapter(DFcommand)
                        Dim DFtable As New DataTable()
                        DFadapter.Fill(DFtable)

                        DefectComboBox.DataSource = DFtable
                        DefectComboBox.ValueMember = "defect_code"
                        DefectComboBox.DisplayMember = "defect_description"
                    End Using
                End With
            Case "ALFOMBRA"
                With DefectComboBox
                    Using DFcommand As New MySqlCommand("SELECT `defect_code`, `defect_description` FROM `defects` WHERE `defect_workstation` = 'ALFOMBRA'", connection)
                        Dim DFadapter As New MySqlDataAdapter(DFcommand)
                        Dim DFtable As New DataTable()
                        DFadapter.Fill(DFtable)

                        DefectComboBox.DataSource = DFtable
                        DefectComboBox.ValueMember = "defect_code"
                        DefectComboBox.DisplayMember = "defect_description"
                    End Using
                End With
            Case "PAINT_PREP"
                With DefectComboBox
                    Using DFcommand As New MySqlCommand("SELECT `defect_code`, `defect_description` FROM `defects` WHERE `defect_workstation` = 'PAINT_PREP'", connection)
                        Dim DFadapter As New MySqlDataAdapter(DFcommand)
                        Dim DFtable As New DataTable()
                        DFadapter.Fill(DFtable)

                        DefectComboBox.DataSource = DFtable
                        DefectComboBox.ValueMember = "defect_code"
                        DefectComboBox.DisplayMember = "defect_description"
                    End Using
                End With
            Case "PINTURA"
                With DefectComboBox
                    Using DFcommand As New MySqlCommand("SELECT `defect_code`, `defect_description` FROM `defects` WHERE `defect_workstation` = 'PINTURA'", connection)
                        Dim DFadapter As New MySqlDataAdapter(DFcommand)
                        Dim DFtable As New DataTable()
                        DFadapter.Fill(DFtable)

                        DefectComboBox.DataSource = DFtable
                        DefectComboBox.ValueMember = "defect_code"
                        DefectComboBox.DisplayMember = "defect_description"
                    End Using
                End With
            Case "INSPECCION_FINAL"
                With DefectComboBox
                    Using DFcommand As New MySqlCommand("SELECT `defect_code`, `defect_description` FROM `defects` WHERE `defect_workstation` = 'INSPECCION_FINAL'", connection)
                        Dim DFadapter As New MySqlDataAdapter(DFcommand)
                        Dim DFtable As New DataTable()
                        DFadapter.Fill(DFtable)

                        DefectComboBox.DataSource = DFtable
                        DefectComboBox.ValueMember = "defect_code"
                        DefectComboBox.DisplayMember = "defect_description"
                    End Using
                End With
            Case "OPERACION"
                With DefectComboBox
                    Using DFcommand As New MySqlCommand("SELECT `defect_code`, `defect_description` FROM `defects` WHERE `defect_workstation` = 'OPERACION'", connection)
                        Dim DFadapter As New MySqlDataAdapter(DFcommand)
                        Dim DFtable As New DataTable()
                        DFadapter.Fill(DFtable)

                        DefectComboBox.DataSource = DFtable
                        DefectComboBox.ValueMember = "defect_code"
                        DefectComboBox.DisplayMember = "defect_description"
                    End Using
                End With
            Case Else
        End Select
    End Sub
End Class