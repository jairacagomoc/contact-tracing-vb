Imports ZXing
Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec


Public Class Form1
    Dim iSubmit As DialogResult
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
    End Sub

    Private Sub Scan_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            StopWebcam()
            reader = New QRCodeDecoder
            txtbox1.Text = reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("QRcode is now detected!")
            'for QRCode
            Dim SD As New SaveFileDialog
            SD.Filter = "PNG|*.png"
            If SD.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            End If
            'for the text 
            iSubmit = MessageBox.Show("Save Data?", "Contact Tracing QRCode", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If iSubmit = DialogResult.OK Then
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\63907\Desktop\Cagomoc_Contact_Tracing_App\CAGOMOC_ContactTracingQRCode1\Data.txt", True)
                file.WriteLine(txtbox1.Text)
            Else
                'do nothing 
            End If
        Catch ex As Exception
            MsgBox("QRcode is not detected!")
            StartWebcam()
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
