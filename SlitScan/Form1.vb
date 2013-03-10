Imports DirectX.Capture
Public Class frmSplitScan

    Private Sub frmSplitScan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim myVideoFilter As Filter
        Dim myAudioFilter As Filter
        Dim Filters As New Filters

        For Each F As Filter In Filters.VideoInputDevices
            If MsgBox("Do you want """ + F.Name + """ To be your camera?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                myVideoFilter = F
                Exit For
            End If
        Next
        If Not IsNothing(myVideoFilter) And Not IsNothing(myAudioFilter) Then
            myAudioFilter = Filters.AudioInputDevices(0)

            Dim capture As New Capture(myVideoFilter, myAudioFilter)
            c = capture
            capture.PreviewWindow = picScan
            capture.VideoCompressor = Filters.VideoCompressors(0)
            capture.AudioCompressor = Filters.AudioCompressors(0)
            capture.FrameRate = 29.997               '  // NTSC
            capture.FrameSize = New Size(640, 480)   '// 640x480
            capture.AudioSamplingRate = 44100       ' // 44.1 kHz
            capture.AudioSampleSize = 16              ' // 16-bit
            capture.AudioChannels = 2                 ' // Mono
            ' c.Start()
        Else
            MsgBox("No video source found. Exiting.")
            Application.Exit()
        End If
    End Sub
    Dim c As Capture
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        btnGo.Enabled = False
        c.Start()
        c.Stop()
        Dim b As New Bitmap(picScan.Width, picScan.Height)
        Dim g As Graphics = Graphics.FromImage(b)
        If chkVertical.Checked Then
            For i As Integer = b.Height To 1 Step -1
                g.CopyFromScreen(Me.PointToScreen(picScan.Location), New Point(0, 0), New Size(b.Width, i))
                If chkBlack.CheckState = CheckState.Checked Then g.FillRectangle(Brushes.Black, 0, 0, b.Width, i - 1)
                picResult.Image = b
                Application.DoEvents()
                Try
                    Threading.Thread.Sleep(txtSpeed.Text)
                Catch
                    Threading.Thread.Sleep(10)
                End Try
            Next i
        Else
            For i As Integer = b.Width To 1 Step -1
                g.CopyFromScreen(Me.PointToScreen(picScan.Location), New Point(0, 0), New Size(i, b.Height))
                If chkBlack.CheckState = CheckState.Checked Then g.FillRectangle(Brushes.Black, 0, 0, i - 1, b.Height)
                picResult.Image = b
                Application.DoEvents()
                Try
                    Threading.Thread.Sleep(txtSpeed.Text)
                Catch
                    Threading.Thread.Sleep(10)
                End Try
            Next i
        End If
        btnGo.Enabled = True

    End Sub

    Private Sub picScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picScan.Click, picResult.Click

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim frmSave As New SaveFileDialog
        frmSave.Filter = "Bitmap (*.bmp)|*.bmp"
        frmSave.ShowDialog()
        picResult.Image.Save(frmSave.FileName)

    End Sub
End Class
