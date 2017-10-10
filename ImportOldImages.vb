
Imports System.IO
Public Class ImportOldImages
    Dim strCounter, strLocation As String
    Dim ImgArray() As Byte
    Dim ThmbArray() As Byte

    Dim stream As MemoryStream


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            'Open a folder browser dialog and select a folder
            FolderBrowserDialog1.ShowDialog()

            'Set variable to equal the selected path.
            If DialogResult.OK Then
                strLocation = FolderBrowserDialog1.SelectedPath()

                ProgressBar1.Visible = True

                Dim di As New IO.DirectoryInfo(strLocation)
                Dim diar1 As IO.FileInfo() = di.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
                lstBackupFiles.Items.Clear()


                ProgressBar1.Properties.Step = 1
                ProgressBar1.Properties.PercentView = False

                ProgressBar1.Properties.Minimum = 1
                ProgressBar1.Properties.Maximum = diar1.Length + 1
                Dim dra As IO.FileInfo
                For Each dra In diar1

                    lstBackupFiles.Items.Add(dra)
                    ListBox1.Items.Add(dra.Directory.Parent.Name)
                    lstFullPath.Items.Add(dra.FullName)
                    ProgressBar1.PerformStep()
                    ProgressBar1.Update()

                Next

                'ProgressBar1.Visible = False

                SimpleButton2.Enabled = True

            End If

        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Sub

    Private Sub ImportOldImages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.Export_Image' table. You can move, or remove it, as needed.
            ' Me.Export_ImageTableAdapter.Fill(Me.NewDBFDataSet.Export_Image)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Import_Image' table. You can move, or remove it, as needed.
            ' Me.Import_ImageTableAdapter.Fill(Me.NewDBFDataSet.Import_Image)
            SimpleButton2.Enabled = False
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        On Error Resume Next

        Dim i As Int32
        Dim impexpid As Int32
        Dim imgid, pagid As Int32
        Dim imgType As String
        Dim img As Image
        Dim thmb As Image

        Dim Str As String
        Dim fullpath As String

        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = False

        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Properties.Maximum = lstBackupFiles.Items.Count - 1

        For i = 0 To lstBackupFiles.Items.Count - 1


            fullpath = lstFullPath.Items(i).ToString

            If Dir(fullpath) <> "" Then

                Str = lstBackupFiles.Items(i).ToString
                imgType = ""
                impexpid = Val(Mid(Str, 3, Str.IndexOf("_") - 2))
                If Str.Contains("Origin") Then
                    imgType = "Origin"
                    imgid = Val(Mid(Str, Str.IndexOf("Origin") + 7, Str.Length - Str.IndexOf("Origin") - 10))
                End If


                If Str.Contains("Action") Then
                    imgType = "Action"
                    imgid = Val(Mid(Str, Str.IndexOf("Action") + 7, Str.Length - Str.IndexOf("Action") - 10))
                End If

                If Str.Contains("Attach") Then
                    imgType = "Attach"
                    imgid = Val(Mid(Str, Str.IndexOf("Attach") + 7, Str.Length - Str.IndexOf("Attach") - 10))
                End If

                pagid = Val(Mid(Str, Str.IndexOf("P") + 2, Str.Length - Str.IndexOf("P")))




                img = Image.FromFile(fullpath)

                If Not img Is Nothing Then

                    stream = New MemoryStream()
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    ImgArray = stream.GetBuffer()



                    Dim myCallback As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
                    thmb = Image.FromFile(fullpath).GetThumbnailImage(128, 128, myCallback, IntPtr.Zero)
                    stream = New MemoryStream()
                    thmb.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    ThmbArray = stream.GetBuffer()

                    Select Case ListBox1.Items(i).ToString
                        Case "Import"
                            Me.Import_ImageTableAdapter.UpdateImportImage(ImgArray, ThmbArray, impexpid, imgType, imgid, pagid)
                        Case "Export"
                            Me.Export_ImageTableAdapter.UpdateExportImage(ImgArray, ThmbArray, impexpid, imgType, imgid, pagid)
                    End Select

                    Console.Write(i.ToString + " " + fullpath + vbCrLf)

                    Debug.WriteLine(i.ToString)

                End If


                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()

                img = Nothing
                ImgArray = Nothing
                ThmbArray = Nothing
                stream = Nothing

            End If




        Next


        'Catch ex As Exception
        '    Dim trace As New System.Diagnostics.StackTrace(ex, True)
        '    With ErrorTrace1
        '        .SendReport = True
        '        .NotifyLocal = True
        '        .From = rFrom
        '        .SendTo = rSendTo
        '        .SMTPServer = rSMTPServer
        '        .SMTPPass = rSMTPPass
        '        .SMTPUser = rSMTPUser
        '        .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
        '        .LineNumber = trace.GetFrame(0).GetFileLineNumber()
        '        .Ex = ex
        '    End With
        'End Try

    End Sub

    Public Function ThumbnailCallback() As Boolean
        Try
            Return False
        Catch ex As Exception
            Dim trace As New System.Diagnostics.StackTrace(ex, True)
            With ErrorTrace1
                .SendReport = True
                .NotifyLocal = True
                .From = rFrom
                .SendTo = rSendTo
                .SMTPServer = rSMTPServer
                .SMTPPass = rSMTPPass
                .SMTPUser = rSMTPUser
                .ActiveMethod = System.Reflection.MethodBase.GetCurrentMethod().Name + vbCrLf + vbCrLf + ex.StackTrace
                .LineNumber = trace.GetFrame(0).GetFileLineNumber()
                .Ex = ex
            End With
        End Try
    End Function
End Class