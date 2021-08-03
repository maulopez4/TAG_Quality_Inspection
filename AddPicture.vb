Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.ComponentModel
Imports System.IO
Public Class AddPicture
    Public WorkOrderNumber As String = AddEntry.GetWorkOrder
    Public CAMARA As VideoCaptureDevice
    Dim Cap As String = "Capture"
    'Private Sub AddPicture_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    Try
    '        'Dispose()
    '        CAMARA.Stop()
    '        CAMARA.SignalToStop()
    '        'PictureBox2.Image = Nothing
    '    Catch ex As Exception
    '        Dispose()
    '        'PictureBox2.Image = Nothing
    '    End Try
    'End Sub
    Private Sub AddPicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdno.Visible = False
        cmdok.Visible = False
        Dim CAMARAS As New VideoCaptureDeviceForm()
        If CAMARAS.ShowDialog() = DialogResult.OK Then
            CAMARA = CAMARAS.VideoDevice
            AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
            CAMARA.Start()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)
        Dim BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pbcaptureimage.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)


    End Sub
    Private Sub Pbcapture_Click(sender As Object, e As EventArgs) Handles pbcapture.Click
        If Cap = "Capture" Then
            cmdno.Visible = True
            cmdok.Visible = True
            pbcapture.Visible = False
            CAMARA.SignalToStop()
            Cap = "Start"
        ElseIf Cap = "Start" Then
            Dim CAMARAS As New VideoCaptureDeviceForm()
            CAMARA.Start()
            cmdno.Visible = False
            cmdok.Visible = False
            Cap = "Capture"
        End If
    End Sub

    Private Sub Cmdno_Click(sender As Object, e As EventArgs) Handles cmdno.Click
        Dim CAMARAS As New VideoCaptureDeviceForm()
        CAMARA.Start()
        cmdno.Visible = False
        cmdok.Visible = False
        pbcapture.Visible = True
        Cap = "Capture"
    End Sub

    Private Sub Cmdok_Click(sender As Object, e As EventArgs) Handles cmdok.Click
        Dim SD As New SaveFileDialog With {
            .InitialDirectory = Environment.SpecialFolder.UserProfile.MyPictures,
            .FileName = $"{WorkOrderNumber}-{Now:MM-dd-yy HH.mm.ss}",
            .SupportMultiDottedExtensions = True,
            .AddExtension = True,
            .Filter = "JPG File|*.jpg"
        }
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                pbcaptureimage.Image.Save(SD.FileName, Imaging.ImageFormat.Jpeg)
                Dim CAMARAS As New VideoCaptureDeviceForm()
                CAMARA.Start()
                cmdno.Visible = False
                cmdok.Visible = False
                pbcapture.Visible = True
                Cap = "Capture"
                Dispose()
                CAMARA.SignalToStop()
            Catch ex As Exception
            End Try
        Else
            Dim CAMARAS As New VideoCaptureDeviceForm()
            CAMARA.Start()
            cmdno.Visible = False
            cmdok.Visible = False
            pbcapture.Visible = True
            Cap = "Capture"
        End If
    End Sub

    Private Sub AddPicture_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            'Dispose()
            CAMARA.Stop()
            CAMARA.SignalToStop()
            'PictureBox2.Image = Nothing
        Catch ex As Exception
            Dispose()
            'PictureBox2.Image = Nothing
        End Try
    End Sub

    Private Sub AddPicture_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            'Dispose()
            CAMARA.Stop()
            CAMARA.SignalToStop()
            'PictureBox2.Image = Nothing
        Catch ex As Exception
            Dispose()
            'PictureBox2.Image = Nothing
        End Try
    End Sub
End Class