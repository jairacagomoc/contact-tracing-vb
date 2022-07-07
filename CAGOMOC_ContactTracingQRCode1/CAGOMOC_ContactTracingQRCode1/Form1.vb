Imports ZXing
Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec


Public Class Form1
    Dim iExit As DialogResult
    Dim iClear As DialogResult
    WithEvents mywebcam As WebCamCapture
    Dim reader As QRCodeDecoder


    Private Sub StartWebcam()
        Try
            StopWebcam()
            mywebcam = New WebCamCapture
            mywebcam.Start(0)
            mywebcam.Start(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StopWebcam()
        Try
            mywebcam = New WebCamCapture
            mywebcam.Stop()
            mywebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles mywebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage
    End Sub
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StartWebcam()
        txtbox1.Clear()
    End Sub

    Private Sub Scan_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim SD As New SaveFileDialog
            StopWebcam()
            reader = New QRCodeDecoder
            txtbox1.Text = reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("QRcode is now detected!", "Contact Tracing QRCode")
            SD.Filter = "PNG|*.png"
            If SD.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
                MsgBox("Data Saved!", "Contact Tracing QRCode")
            End If
        Catch ex As Exception
            MsgBox("QRcode is not detected!")
            StartWebcam()
            txtbox1.Clear()
        End Try
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtbox1.Clear()
    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iExit = MessageBox.Show("Do you want to exit? ", "Contact Tracing QRCode", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub
End Class
