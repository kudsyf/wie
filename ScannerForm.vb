Imports System.IO
Imports System.Runtime.InteropServices


Public Class ScannerForm
    Public saveFlag As Boolean
    Private ErrorTrace1 As New ErrorTrace

    Public Elimgid As Integer

    Dim d() As Byte
    Dim ImgArray() As Byte
    Dim ThmbArray() As Byte

    Dim selId As Int32
    Dim selImId As Int32
    Dim selpageId As Int32

    Dim stream As MemoryStream

    Private m_PanStartPoint As New Point

    Private Sub pb1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureEdit1.MouseDown
        Try
            m_PanStartPoint = New Point(e.X, e.Y)
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

    Private Sub pb1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)Handles PictureEdit1.MouseMove

        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
             Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
                Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)
                Panel1.AutoScrollPosition = New Drawing.Point((DeltaX - Panel1.AutoScrollPosition.X), (DeltaY - Panel1.AutoScrollPosition.Y))
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


    Private Sub ScannerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'SiAuto.Main.EnterMethod(Me, "ScannerForm_Load")
            Panel1.AutoScroll = True
            
            PictureEdit1.SizeMode = PictureBoxSizeMode.AutoSize
         
            Dim ic As Integer
            ImgArray = Nothing
            ThmbArray = Nothing

            saveFlag = False
            ImageListBoxControl1.ImageList = ImageList1
            ImageList1.Images.Clear()

            'PictureEdit1.Width = 1000
            'PictureEdit1.Height = 800

            BarNewFolder.Enabled = True
            BarPrint.Enabled = False
            BarSave.Enabled = False
            BarScan.Enabled = True
            BarDelpage.Enabled = False

            If NewActionOpenFormProperty = "NEW" Then
                BarScan.Enabled = True
                BarNewFolder.Enabled = True
            Else
                If ActionOpenFormProperty = "ACTION" Or ExpActionOpenFormProperty = "ACTION" Then
                    BarScan.Enabled = False
                    BarNewFolder.Enabled = False

                End If

            End If

            Select Case ScanOrImagetypeProperty
                Case "ElementReq"
                    If ElementImgTableAdapter1.GetImageByImgId(Elimgid).Count > 0 Then

                        Dim impdata As NewDBFDataSet.ElementImgDataTable = Me.ElementImgTableAdapter1.GetImageByImgId(Elimgid)
                        Dim imr As NewDBFDataSet.ElementImgRow

                        ic = 0
                        For Each imr In impdata
                            If imr("ThumbImg").ToString <> "" Then
                                d = imr("ThumbImg")
                                stream = New MemoryStream(d)
                                ImageList1.Images.Add(Image.FromStream(stream))
                                ImageListBoxControl1.Items.Add(imr("PageId").ToString, ic)
                                ic = ic + 1
                            End If

                        Next

                    End If



                Case "FromOrginImp"
                    ' if there is no image  as ORIGIN 
                    If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Origin") = -1 Then

                    Else
                        ' if there is an Image as ORIGIN

                        ' if this image got more than one page

                        Dim impdata As NewDBFDataSet.Import_ImageDataTable = Me.Import_ImageTableAdapter.GetImportImages_id_Type(UsedImportIdProperty, "Origin", 0)
                        Dim imr As NewDBFDataSet.Import_ImageRow

                        ic = 0
                        For Each imr In impdata
                            If imr("ThmbBin").ToString <> "" Then
                                d = imr("ThmbBin")
                                stream = New MemoryStream(d)
                                ImageList1.Images.Add(Image.FromStream(stream))
                                ImageListBoxControl1.Items.Add(imr("PageId").ToString, ic)
                                ic = ic + 1
                            End If

                        Next

                    End If

                Case "FromOrginExp"
                    ' if there is no image  as ORIGIN 
                    If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Origin") = -1 Then

                    Else
                        ' if there is an Image as ORIGIN

                        ' if this image got more than one page

                        Dim expdata As NewDBFDataSet.Export_ImageDataTable = Me.Export_ImageTableAdapter.GetExportImages_id_type(UsedExportIdProperty, "Origin", 0)
                        Dim exr As NewDBFDataSet.Export_ImageRow

                        ic = 0
                        For Each exr In expdata
                            If exr("ThmbBin").ToString <> "" Then
                                d = exr("ThmbBin")
                                stream = New MemoryStream(d)
                                ImageList1.Images.Add(Image.FromStream(stream))
                                ImageListBoxControl1.Items.Add(exr("PageId").ToString, ic)
                                ic = ic + 1
                            End If

                        Next

                    End If
                Case "FromImpAction"
                    If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Action") = -1 Then

                    Else


                        Dim impdata As NewDBFDataSet.Import_ImageDataTable = Me.Import_ImageTableAdapter.GetImportImages_id_Type(UsedImportIdProperty, "Action", ImgIdProperty)
                        Dim imr As NewDBFDataSet.Import_ImageRow

                        ic = 0
                        For Each imr In impdata
                            If imr("ThmbBin").ToString <> "" Then
                                d = imr("ThmbBin")
                                stream = New MemoryStream(d)
                                ImageList1.Images.Add(Image.FromStream(stream))
                                ImageListBoxControl1.Items.Add(imr("PageId").ToString, ic)
                                ic = ic + 1
                            End If

                        Next

                    End If

                Case "FromExpAction"
                    If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Action") = -1 Then

                    Else

                        ' if this image got more than one page

                        Dim expdata As NewDBFDataSet.Export_ImageDataTable = Me.Export_ImageTableAdapter.GetExportImages_id_type(UsedExportIdProperty, "Action", ImgIdProperty)
                        Dim exr As NewDBFDataSet.Export_ImageRow

                        ic = 0
                        For Each exr In expdata
                            If exr("ThmbBin").ToString <> "" Then
                                d = exr("ThmbBin")
                                stream = New MemoryStream(d)
                                ImageList1.Images.Add(Image.FromStream(stream))
                                ImageListBoxControl1.Items.Add(exr("PageId").ToString, ic)
                                ic = ic + 1
                            End If

                        Next

                    End If
                Case "FromImpAttach"
                    If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Attach") = -1 Then

                    Else


                        Dim impdata As NewDBFDataSet.Import_ImageDataTable = Me.Import_ImageTableAdapter.GetImportImages_id_Type(UsedImportIdProperty, "Attach", ImgIdProperty)
                        Dim imr As NewDBFDataSet.Import_ImageRow

                        ic = 0
                        For Each imr In impdata
                            If imr("ThmbBin").ToString <> "" Then
                                d = imr("ThmbBin")
                                stream = New MemoryStream(d)
                                ImageList1.Images.Add(Image.FromStream(stream))
                                ImageListBoxControl1.Items.Add(imr("PageId").ToString, ic)
                                ic = ic + 1
                            End If

                        Next

                    End If
                Case "FromExpAttach"
                    ' if there is no image  as ORIGIN 
                    If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Attach") = -1 Then

                    Else
                        ' if there is an Image as ORIGIN

                        ' if this image got more than one page

                        Dim expdata As NewDBFDataSet.Export_ImageDataTable = Me.Export_ImageTableAdapter.GetExportImages_id_type(UsedExportIdProperty, "Attach", ImgIdProperty)
                        Dim exr As NewDBFDataSet.Export_ImageRow

                        ic = 0
                        For Each exr In expdata
                            If exr("ThmbBin").ToString <> "" Then
                                d = exr("ThmbBin")
                                stream = New MemoryStream(d)
                                ImageList1.Images.Add(Image.FromStream(stream))
                                ImageListBoxControl1.Items.Add(exr("PageId").ToString, ic)
                                ic = ic + 1
                            End If

                        Next

                    End If

            End Select
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

    Private Sub BarNewPage_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarNewPage.ItemClick
        Try
            ImgArray = Nothing
            ThmbArray = Nothing
            saveFlag = False

            Select Case ScanOrImagetypeProperty
                Case "FromOrginImp"
                    BarScan.Enabled = True

                    BarNewFolder.Enabled = False
                    BarPrint.Enabled = False


                Case "FromOrginExp"
                    BarScan.Enabled = True

                    BarNewFolder.Enabled = False
                    BarPrint.Enabled = False
                Case "FromImpAction"
                    BarScan.Enabled = True

                    BarNewFolder.Enabled = False
                    BarPrint.Enabled = False
                Case "FromExpAction"
                    BarScan.Enabled = True

                    BarNewFolder.Enabled = False
                    BarPrint.Enabled = False


                Case "FromImpAttach"
                    BarScan.Enabled = True

                    BarNewFolder.Enabled = False

                    BarPrint.Enabled = False
                Case "FromExpAttach"

                    BarScan.Enabled = True

                    BarNewFolder.Enabled = False

                    BarPrint.Enabled = False
            End Select
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

    Private Sub ImageListBoxControl1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageListBoxControl1.DoubleClick
        Try
            saveFlag = False

            BarSave.Enabled = False
            BarDelpage.Enabled = True
            BarPrint.Enabled = True
            If NewActionOpenFormProperty = "NEW" Then
               BarDelpage.Enabled = True
            Else
                If ActionOpenFormProperty = "ACTION" Or ExpActionOpenFormProperty = "ACTION" Then
                    BarDelpage.Enabled = False
                End If
            End If

            Select Case ScanOrImagetypeProperty
                Case "ElementReq"

                    Dim impdata As NewDBFDataSet.ElementImgDataTable = Me.ElementImgTableAdapter1.GetImageByImgId(Elimgid)
                    Dim imr As NewDBFDataSet.ElementImgRow = impdata.Rows(ImageListBoxControl1.SelectedIndex)
                    selImId = Elimgid

                    selpageId = imr("PageId")
                    d = imr("BitmapImg")
                    stream = New MemoryStream(d)
                    PictureEdit1.Image = Image.FromStream(stream)

                Case "FromOrginImp"


                    Dim impdata As NewDBFDataSet.Import_ImageDataTable = Me.Import_ImageTableAdapter.GetImportImages_id_Type(UsedImportIdProperty, "Origin", 0)
                    Dim imr As NewDBFDataSet.Import_ImageRow = impdata.Rows(ImageListBoxControl1.SelectedIndex)
                    selId = UsedImportIdProperty
                    selImId = 0
                    selpageId = imr("PageId")
                    d = imr("ImageBin")
                    stream = New MemoryStream(d)
                    PictureEdit1.Image = Image.FromStream(stream)


                Case "FromOrginExp"

                    Dim expdata As NewDBFDataSet.Export_ImageDataTable = Me.Export_ImageTableAdapter.GetExportImages_id_type(UsedExportIdProperty, "Origin", 0)
                    Dim exr As NewDBFDataSet.Export_ImageRow = expdata.Rows(ImageListBoxControl1.SelectedIndex)
                    selId = UsedExportIdProperty
                    selImId = 0
                    selpageId = exr("PageId")

                    d = exr("ImageBin")
                    stream = New MemoryStream(d)
                    PictureEdit1.Image = Image.FromStream(stream)



                Case "FromImpAction"
                    Dim impdata As NewDBFDataSet.Import_ImageDataTable = Me.Import_ImageTableAdapter.GetImportImages_id_Type(UsedImportIdProperty, "Action", ImgIdProperty)
                    Dim imr As NewDBFDataSet.Import_ImageRow = impdata.Rows(ImageListBoxControl1.SelectedIndex)
                    selId = UsedImportIdProperty
                    selImId = 0
                    selpageId = imr("PageId")
                    d = imr("ImageBin")
                    stream = New MemoryStream(d)
                    PictureEdit1.Image = Image.FromStream(stream)


                Case "FromExpAction"
                    Dim expdata As NewDBFDataSet.Export_ImageDataTable = Me.Export_ImageTableAdapter.GetExportImages_id_type(UsedExportIdProperty, "Action", ImgIdProperty)
                    Dim exr As NewDBFDataSet.Export_ImageRow = expdata.Rows(ImageListBoxControl1.SelectedIndex)
                    selId = UsedExportIdProperty
                    selImId = 0
                    selpageId = exr("PageId")
                    d = exr("ImageBin")
                    stream = New MemoryStream(d)
                    PictureEdit1.Image = Image.FromStream(stream)


                Case "FromImpAttach"
                    Dim impdata As NewDBFDataSet.Import_ImageDataTable = Me.Import_ImageTableAdapter.GetImportImages_id_Type(UsedImportIdProperty, "Attach", ImgIdProperty)
                    Dim imr As NewDBFDataSet.Import_ImageRow = impdata.Rows(ImageListBoxControl1.SelectedIndex)
                    selId = UsedImportIdProperty
                    selImId = 0
                    selpageId = imr("PageId")
                    d = imr("ImageBin")
                    stream = New MemoryStream(d)
                    PictureEdit1.Image = Image.FromStream(stream)


                Case "FromExpAttach"
                    Dim expdata As NewDBFDataSet.Export_ImageDataTable = Me.Export_ImageTableAdapter.GetExportImages_id_type(UsedExportIdProperty, "Attach", ImgIdProperty)
                    Dim exr As NewDBFDataSet.Export_ImageRow = expdata.Rows(ImageListBoxControl1.SelectedIndex)
                    selId = UsedExportIdProperty
                    selImId = 0
                    selpageId = exr("PageId")
                    d = exr("ImageBin")
                    stream = New MemoryStream(d)
                    PictureEdit1.Image = Image.FromStream(stream)



            End Select
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

    Private Sub BarScan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarScan.ItemClick
        Try

            BarNewFolder.Enabled = False
            BarDelpage.Enabled = False
            BarPrint.Enabled = False
            Dim S As Collection


            S = TwainHandler.ScanImages(Application.StartupPath & "\", "jpg")

            If S.Count <> 0 Then


                Dim myCallback As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
                Dim myBitmap As New Bitmap(Application.StartupPath & "\0_ImpExpScan.jpg")


                stream = New MemoryStream()
                myBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                ImgArray = stream.GetBuffer()

                Dim myThumbnail As Image = myBitmap.GetThumbnailImage(128, 128, myCallback, IntPtr.Zero)
                myThumbnail.Save(Application.StartupPath & "\0_ImpExpScan_thumb.jpg")


                stream = New MemoryStream()
                myThumbnail.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                ThmbArray = stream.GetBuffer()

                PictureEdit1.Image = Image.FromHbitmap(myBitmap.GetHbitmap)
                FileSystem.Kill(Application.StartupPath & "\0_ImpExpScan_thumb.jpg")

                TwainHandler.Dispose()
                TwainHandler = Nothing
                myCallback = Nothing
                myBitmap.Dispose()

                stream = Nothing


                BarSave.Enabled = True
                saveFlag = True
            Else

                BarScan.Enabled = True
                BarNewFolder.Enabled = True

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

    Private Sub BarDelpage_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarDelpage.ItemClick
        Try

            saveFlag = False
            If (DevExpress.XtraEditors.XtraMessageBox.Show("توافق على الحذف ؟", "تاكيد حذف", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

            If BarSave.Enabled = False And Not PictureEdit1.Image Is Nothing Then


                Select Case ScanOrImagetypeProperty
                    Case "ElementReq"
                        Me.ElementImgTableAdapter1.Delete1(selImId, selpageId)
                        PictureEdit1.Image = Nothing
                        ImageListBoxControl1.Items.RemoveAt(ImageListBoxControl1.SelectedIndex)
                        ImageListBoxControl1.Refresh()
                    Case "FromOrginImp"
                        Me.Import_ImageTableAdapter.Delete(selId, "Origin", selImId, selpageId)
                        PictureEdit1.Image = Nothing
                        ImageListBoxControl1.Items.RemoveAt(ImageListBoxControl1.SelectedIndex)
                        ImageListBoxControl1.Refresh()

                    Case "FromOrginExp"
                        Me.Export_ImageTableAdapter.Delete(selId, "Origin", selImId, selpageId)
                        PictureEdit1.Image = Nothing
                        ImageListBoxControl1.Items.RemoveAt(ImageListBoxControl1.SelectedIndex)
                        ImageListBoxControl1.Refresh()
                    Case "FromImpAction"
                        Me.Import_ImageTableAdapter.Delete(selId, "Action", selImId, selpageId)
                        PictureEdit1.Image = Nothing
                        ImageListBoxControl1.Items.RemoveAt(ImageListBoxControl1.SelectedIndex)
                        ImageListBoxControl1.Refresh()
                    Case "FromExpAction"
                        Me.Export_ImageTableAdapter.Delete(selId, "Action", selImId, selpageId)
                        PictureEdit1.Image = Nothing
                        ImageListBoxControl1.Items.RemoveAt(ImageListBoxControl1.SelectedIndex)
                        ImageListBoxControl1.Refresh()
                    Case "FromImpAttach"
                        Me.Export_ImageTableAdapter.Delete(selId, "Attach", selImId, selpageId)
                        PictureEdit1.Image = Nothing
                        ImageListBoxControl1.Items.RemoveAt(ImageListBoxControl1.SelectedIndex)
                        ImageListBoxControl1.Refresh()
                    Case "FromExpAttach"
                        Me.Import_ImageTableAdapter.Delete(selId, "Attach", selImId, selpageId)
                        PictureEdit1.Image = Nothing
                        ImageListBoxControl1.Items.RemoveAt(ImageListBoxControl1.SelectedIndex)
                        ImageListBoxControl1.Refresh()

                End Select
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

    Private Sub BarSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSave.ItemClick
        Try
            Dim ipageid As Integer

            Dim MaxPageId As Int32
            Select Case ScanOrImagetypeProperty
                Case "FromExpAttach"
                    MaxPageId = Me.Export_ImageTableAdapter.GetMaxId(UsedExportIdProperty, "Attach", ImgIdProperty)
                Case "FromImpAttach"
                    MaxPageId = Me.Import_ImageTableAdapter.GetMaxPageId(UsedImportIdProperty, "Attach", ImgIdProperty)
                Case "FromExpAction"
                    MaxPageId = Me.Export_ImageTableAdapter.GetMaxId(UsedExportIdProperty, "Action", ImgIdProperty)
                Case "FromImpAction"
                    MaxPageId = Me.Import_ImageTableAdapter.GetMaxPageId(UsedImportIdProperty, "Action", ImgIdProperty)
                Case "ElementReq"
                    MaxPageId = Me.ElementImgTableAdapter1.GetMaxPageId(Elimgid)
            End Select

            Select Case ScanOrImagetypeProperty

                Case "ElementReq"

                    If Not ImgArray Is Nothing Then
                        ipageid = Me.ElementImgTableAdapter1.GetMaxPageId(Elimgid)

                        Me.ElementImgTableAdapter1.InsertImage(Elimgid, ipageid + 1, ThmbArray, ImgArray)
                        stream = New MemoryStream(ThmbArray)
                        ImageList1.Images.Add(Image.FromStream(stream))
                        ImageListBoxControl1.Items.Add((ipageid + 1).ToString, ImageListBoxControl1.Items.Count)

                        ThmbArray = Nothing
                        ImgArray = Nothing

                    End If




                Case "FromOrginImp"

                    If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Origin") = -1 Then
                        If Not ImgArray Is Nothing Then
                            Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Origin", 0, 1, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Origin", 0).ToString, ImageListBoxControl1.Items.Count)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If

                    Else
                        If Not ImgArray Is Nothing Then
                            Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Origin", 0, Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Origin", 0) + 1, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Origin", 0).ToString, ImageListBoxControl1.Items.Count)

                            ThmbArray = Nothing
                            ImgArray = Nothing

                        End If
                    End If
                    SaveSession(SessionType.AddImpImg)

                Case "FromOrginExp"
                    If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Origin") = -1 Then
                        If Not ImgArray Is Nothing Then
                            Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Origin", 0, 1, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Origin", 0).ToString, ImageListBoxControl1.Items.Count)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If
                    Else
                        If Not ImgArray Is Nothing Then
                            Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Origin", 0, Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Origin", 0) + 1, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Origin", 0).ToString, ImageListBoxControl1.Items.Count)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If
                    End If
                    SaveSession(SessionType.AddExpImg)
                Case "FromImpAction"
                    If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Action") = -1 Then
                        If Not ImgArray Is Nothing Then
                            Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Action", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Action", ImgIdProperty).ToString, MaxPageId - 1)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If

                    Else
                        If Not ImgArray Is Nothing Then
                            Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Action", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Action", ImgIdProperty).ToString, MaxPageId - 1)

                            ThmbArray = Nothing
                            ImgArray = Nothing

                        End If
                    End If
                    MaxPageId = MaxPageId + 1
                    SaveSession(SessionType.AddImpActionImg)
                Case "FromExpAction"
                    If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Action") = -1 Then
                        If Not ImgArray Is Nothing Then
                            Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Action", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Action", ImgIdProperty).ToString, MaxPageId - 1)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If
                    Else
                        If Not ImgArray Is Nothing Then
                            Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Action", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Action", ImgIdProperty).ToString, MaxPageId - 1)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If
                    End If
                    MaxPageId = MaxPageId + 1
                    SaveSession(SessionType.AddExpActionImg)
                Case "FromImpAttach"

                    If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Attach") = -1 Then
                        If Not ImgArray Is Nothing Then
                            Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Attach", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Attach", ImgIdProperty).ToString, MaxPageId - 1)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If
                    Else
                        If Not ImgArray Is Nothing Then
                            Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Attach", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Attach", ImgIdProperty).ToString, MaxPageId - 1)

                            ThmbArray = Nothing
                            ImgArray = Nothing

                        End If
                    End If
                    MaxPageId = MaxPageId + 1
                    SaveSession(SessionType.AddImpAttachImg)

                Case "FromExpAttach"
                    If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Attach") = -1 Then
                        If Not ImgArray Is Nothing Then
                            Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Attach", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Attach", ImgIdProperty).ToString, MaxPageId - 1)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If
                    Else
                        If Not ImgArray Is Nothing Then
                            Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Attach", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                            stream = New MemoryStream(ThmbArray)
                            ImageList1.Images.Add(Image.FromStream(stream))
                            ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Attach", 0).ToString, MaxPageId - 1)
                            ThmbArray = Nothing
                            ImgArray = Nothing
                        End If
                    End If
                    MaxPageId = MaxPageId + 1
                    SaveSession(SessionType.AddExpAttachImg)

            End Select
            saveFlag = False
            BarSave.Enabled = False
            BarNewFolder.Enabled = True


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

    Private Sub BarNewFolder_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarNewFolder.ItemClick

        Try

            ImgArray = Nothing
            ThmbArray = Nothing
            saveFlag = False

            BarScan.Enabled = False

            BarNewFolder.Enabled = False
            BarPrint.Enabled = False
            BarDelpage.Enabled = False


            Dim brsform As New OpenFileDialog
            brsform.Multiselect = True
            brsform.Filter = "JPG (*.jpg)|*.jpg"
            Dim dr As DialogResult = brsform.ShowDialog()
            If (dr = System.Windows.Forms.DialogResult.OK) Then
                Dim ipageid As Integer

                Dim MaxPageId As Int32
                Select Case ScanOrImagetypeProperty
                    Case "FromExpAttach"
                        MaxPageId = Me.Export_ImageTableAdapter.GetMaxId(UsedExportIdProperty, "Attach", ImgIdProperty)
                    Case "FromImpAttach"
                        MaxPageId = Me.Import_ImageTableAdapter.GetMaxPageId(UsedImportIdProperty, "Attach", ImgIdProperty)
                    Case "FromExpAction"
                        MaxPageId = Me.Export_ImageTableAdapter.GetMaxId(UsedExportIdProperty, "Action", ImgIdProperty)
                    Case "FromImpAction"
                        MaxPageId = Me.Import_ImageTableAdapter.GetMaxPageId(UsedImportIdProperty, "Action", ImgIdProperty)
                    Case "ElementReq"
                        MaxPageId = Me.ElementImgTableAdapter1.GetMaxPageId(Elimgid)
                End Select


                Dim file As String
                For Each file In brsform.FileNames

                    Dim myCallback As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
                    Dim myBitmap As New Bitmap(file)
                    stream = New MemoryStream()
                    myBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    ImgArray = stream.GetBuffer()
                    Dim myThumbnail As Image = myBitmap.GetThumbnailImage(128, 128, myCallback, IntPtr.Zero)
                    stream = New MemoryStream()
                    myThumbnail.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    ThmbArray = stream.GetBuffer()


                    Select Case ScanOrImagetypeProperty

                        Case "ElementReq"

                            If Not ImgArray Is Nothing Then
                                ipageid = Me.ElementImgTableAdapter1.GetMaxPageId(Elimgid)

                                Me.ElementImgTableAdapter1.InsertImage(Elimgid, ipageid + 1, ThmbArray, ImgArray)
                                stream = New MemoryStream(ThmbArray)
                                ImageList1.Images.Add(Image.FromStream(stream))
                                ImageListBoxControl1.Items.Add((ipageid + 1).ToString, ImageListBoxControl1.Items.Count)

                                ThmbArray = Nothing
                                ImgArray = Nothing

                            End If

                        Case "FromOrginImp"

                            If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Origin") = -1 Then
                                If Not ImgArray Is Nothing Then
                                    Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Origin", 0, 1, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Origin", 0).ToString, ImageListBoxControl1.Items.Count)
                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If

                            Else
                                If Not ImgArray Is Nothing Then
                                    Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Origin", 0, Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Origin", 0) + 1, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Origin", 0).ToString, ImageListBoxControl1.Items.Count)

                                    ThmbArray = Nothing
                                    ImgArray = Nothing

                                End If
                            End If
                            SaveSession(SessionType.AddImpImg)

                        Case "FromOrginExp"
                            If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Origin") = -1 Then
                                If Not ImgArray Is Nothing Then
                                    Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Origin", 0, 1, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Origin", 0).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If
                            Else
                                If Not ImgArray Is Nothing Then
                                    Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Origin", 0, Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Origin", 0) + 1, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Origin", 0).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If
                            End If
                            SaveSession(SessionType.AddExpImg)
                        Case "FromImpAction"
                            If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Action") = -1 Then
                                If Not ImgArray Is Nothing Then
                                    Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Action", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Action", ImgIdProperty).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If

                            Else
                                If Not ImgArray Is Nothing Then
                                    Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Action", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Action", ImgIdProperty).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing

                                End If
                            End If
                            MaxPageId = MaxPageId + 1
                            SaveSession(SessionType.AddImpActionImg)
                        Case "FromExpAction"
                            If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Action") = -1 Then
                                If Not ImgArray Is Nothing Then
                                    Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Action", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Action", ImgIdProperty).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If
                            Else
                                If Not ImgArray Is Nothing Then
                                    Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Action", ExpSelectedActionIDProperty, MaxPageId, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Action", ImgIdProperty).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If
                            End If
                            MaxPageId = MaxPageId + 1
                            SaveSession(SessionType.AddExpActionImg)
                        Case "FromImpAttach"
                            If Import_ImageTableAdapter.GetImageId_by_ImportId_Type(UsedImportIdProperty, "Attach") = -1 Then
                                If Not ImgArray Is Nothing Then
                                    Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Attach", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Attach", ImgIdProperty).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()

                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If
                            Else
                                If Not ImgArray Is Nothing Then

                                    Me.Import_ImageTableAdapter.InsertImage_thumb(UsedImportIdProperty, "Attach", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Import_ImageTableAdapter.GetPageId_by_ImportId_ImageId_Type(UsedImportIdProperty, "Attach", ImgIdProperty).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing

                                End If
                            End If
                            MaxPageId = MaxPageId + 1
                            SaveSession(SessionType.AddImpAttachImg)

                        Case "FromExpAttach"
                            If Export_ImageTableAdapter.GetImageId_by_ExportId_Type(UsedExportIdProperty, "Attach") = -1 Then
                                If Not ImgArray Is Nothing Then
                                    Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Attach", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Attach", ImgIdProperty).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If
                            Else
                                If Not ImgArray Is Nothing Then
                                    Me.Export_ImageTableAdapter.InsertImage_thumb(UsedExportIdProperty, "Attach", ImgIdProperty, MaxPageId, "", ImgArray, ThmbArray)
                                    stream = New MemoryStream(ThmbArray)
                                    ImageList1.Images.Add(Image.FromStream(stream))
                                    ImageListBoxControl1.Items.Add(Me.Export_ImageTableAdapter.GetPageId_by_ExportId_ImageId_type(UsedExportIdProperty, "Attach", ImgIdProperty).ToString, ImageListBoxControl1.Items.Count)
                                    ImageListBoxControl1.Refresh()
                                    ThmbArray = Nothing
                                    ImgArray = Nothing
                                End If
                            End If
                            MaxPageId = MaxPageId + 1
                            SaveSession(SessionType.AddExpAttachImg)

                    End Select

                    saveFlag = False
                    BarSave.Enabled = False
                    BarNewFolder.Enabled = True
                    BarScan.Enabled = True




                Next file
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

    Dim WithEvents PD As New Printing.PrintDocument

    Dim WithEvents PD2 As New Printing.PrintDocument


    Private Sub BarPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarPrint.ItemClick
        Try

            PD.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("PaperA4", 826, 1169)

            PrintDialog1.Document = PD
            PrintDialog1.ShowDialog()
            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                PD.Print()
                If ActionOpenFormProperty = "ACTION" Then

                    Import_ActionTableAdapter1.UpdateLocalPrint(ActionLocalImpIdProperty, ActionLocalIdProperty)
                    lclfrmImpList.ImportDocForTransferTableAdapter.FillBytransfer(lclfrmImpList.NewDBFDataSet.ImportDocForTransfer, CurOrgNo)
                    lclfrmImpList.GridView1.RefreshData()
                End If

                If ExpActionOpenFormProperty = "ACTION" Then

                    Export_To1TableAdapter1.UpdateStts(2, ExpActionLocalExpIdProperty, ExpActionLocalExpTOProperty)
                    lclfrmImpList22.LocalExportToTableAdapter.FillMyOrg(lclfrmImpList22.NewDBFDataSet.LocalExportTo, CurOrgNo)
                    lclfrmImpList22.GridView1.RefreshData()
                End If

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
    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Try
            Dim i As Image = PictureEdit1.Image

            Dim newWidth As Single = i.Width * 100 / i.HorizontalResolution
            Dim newHeight As Single = i.Height * 100 / i.VerticalResolution

            Dim widthFactor As Single = newWidth / e.PageBounds.Width
            Dim heightFactor As Single = newHeight / e.PageBounds.Height

            If widthFactor > 1 Or heightFactor > 1 Then
                If widthFactor > heightFactor Then
                    newWidth = newWidth / widthFactor
                    newHeight = newHeight / widthFactor
                Else
                    newWidth = newWidth / heightFactor
                    newHeight = newHeight / heightFactor
                End If
            End If
            e.Graphics.DrawImage(i, 10, 10, CInt(newWidth) - 20, CInt(newHeight) - 20)
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

    Private Sub SaveImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveImage.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog()
            dlg.Filter = "JPEG Files (*.jpg)|*.jpg"
            DialogResult = dlg.ShowDialog()
            If DialogResult = Windows.Forms.DialogResult.OK Then
                PictureEdit1.Image.Save(dlg.FileName)
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

  
 
End Class