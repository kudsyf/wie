
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices 'Needed
Imports System.Resources
Imports System.IO

Partial Public Class eXa_Splash
    Inherits Form
    Private Enum Phases
        FadeIn
        Hold
        FadeOut
    End Enum
    Private CurrentPhase As Phases = Phases.FadeIn
    Private FadeInStep As Integer = 0
    Private Const FadeInLast As Integer = 20
    Private HoldStep As Integer = 0
    Private Const HoldLast As Integer = 100
    Private FadeOutStep As Integer = 20
    Private Const FadeOutLast As Integer = 0
    Private Const OpacityMultiplier As Integer = 5
    Private MyOpacity As Double = 0
    Private xid As Integer = 0

    Private MaxSplash As Integer = 32
    Private SplashRes(MaxSplash - 1) As String
    Private SplashImageName As String = "SplashScreenPSD"

    Public Sub New()

        InitializeComponent()



        Dim res() As String = GetType(WinImpExp.eXa_Splash).Assembly.GetManifestResourceNames()
        Dim i As Integer = 0


        Dim assn As String = Path.GetFileNameWithoutExtension(Application.ExecutablePath)

        Dim xo As Integer

        For Each ss As String In res

            If Microsoft.VisualBasic.Strings.Left(ss, assn.Length + 1 + SplashImageName.Length) = assn + "." + SplashImageName Then
                xo = CInt(Microsoft.VisualBasic.Strings.Right(Path.GetFileNameWithoutExtension(ss), Path.GetFileNameWithoutExtension(ss).Length - (assn.Length + SplashImageName.Length + 1)))
                SplashRes.SetValue(ss, xo)
                i += 1

            End If

        Next



    End Sub

#Region "CUSTOM PAINT METHODS ----------------------------------------------"
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80000 ' Required: set WS_EX_LAYERED extended style
            Return cp
        End Get
    End Property

    'Updates the Form's display using API calls
    Public Sub UpdateFormDisplay(ByVal backgroundImage As Image)
        Dim screenDc As IntPtr = API.GetDC(IntPtr.Zero)
        Dim memDc As IntPtr = API.CreateCompatibleDC(screenDc)
        Dim hBitmap As IntPtr = IntPtr.Zero
        Dim oldBitmap As IntPtr = IntPtr.Zero

        Try
            'Display-image
            Dim bmp As New Bitmap(backgroundImage)
            hBitmap = bmp.GetHbitmap(Color.FromArgb(0)) 'Set the fact that background is transparent
            oldBitmap = API.SelectObject(memDc, hBitmap)

            'Display-rectangle
            Dim size As Size = bmp.Size
            Dim pointSource As New Point(0, 0)
            Dim topPos As New Point(Me.Left, Me.Top)

            'Set up blending options
            Dim blend As New API.BLENDFUNCTION()
            blend.BlendOp = API.AC_SRC_OVER
            blend.BlendFlags = 0
            blend.SourceConstantAlpha = CByte(255 * MyOpacity)
            blend.AlphaFormat = API.AC_SRC_ALPHA

            API.UpdateLayeredWindow(Me.Handle, screenDc, topPos, size, memDc, pointSource, Me.BackColor.ToArgb(), blend, API.ULW_ALPHA)

            'Clean-up
            bmp.Dispose()
            API.ReleaseDC(IntPtr.Zero, screenDc)
            If hBitmap <> IntPtr.Zero Then
                API.SelectObject(memDc, oldBitmap)
                API.DeleteObject(hBitmap)
            End If
            API.DeleteDC(memDc)
        Catch e1 As Exception
        End Try
    End Sub
#End Region

#Region "FORM EVENTS -------------------------------------------------------"
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load







        UpdateFormDisplay(Me.BackgroundImage)

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        'Call our drawing function

    End Sub
#End Region

    Private Sub timerFade_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timerFade.Tick

        If CurrentPhase = Phases.FadeIn Then

            If FadeInStep < FadeInLast Then
                'timerFade.Interval = 10
                FadeInStep += 1
                MyOpacity = (OpacityMultiplier * FadeInStep) / 100.0
                If xid > MaxSplash - 1 Then
                    xid = 0

                End If

                UpdateFormDisplay(New System.Drawing.Bitmap(GetType(WinImpExp.eXa_Splash).Assembly.GetManifestResourceStream(SplashRes(xid))))

                xid += 1

            Else
                CurrentPhase = Phases.Hold
            End If
        ElseIf CurrentPhase = Phases.Hold Then

            If HoldStep < HoldLast Then
                'timerFade.Interval = 30
                HoldStep += 1
                If xid > MaxSplash - 1 Then
                    xid = 0

                End If

                UpdateFormDisplay(New System.Drawing.Bitmap(GetType(WinImpExp.eXa_Splash).Assembly.GetManifestResourceStream(SplashRes(xid))))
                xid += 1
                'this.UpdateFormDisplay(this.BackgroundImage);
            Else
                CurrentPhase = Phases.FadeOut

            End If
        ElseIf CurrentPhase = Phases.FadeOut Then
            If FadeOutStep > FadeOutLast Then
                'timerFade.Interval = 10
                FadeOutStep -= 1
                MyOpacity = (OpacityMultiplier * FadeOutStep) / 100.0

                If xid > MaxSplash - 1 Then
                    xid = 0

                End If
                UpdateFormDisplay(New System.Drawing.Bitmap(GetType(WinImpExp.eXa_Splash).Assembly.GetManifestResourceStream(SplashRes(xid))))
                xid += 1
            Else
                Me.Close()
            End If
        End If

    End Sub
End Class

Friend Class API
    Public Const AC_SRC_OVER As Byte = &H0
    Public Const AC_SRC_ALPHA As Byte = &H1
    Public Const ULW_ALPHA As Int32 = &H2

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure BLENDFUNCTION
        Public BlendOp As Byte
        Public BlendFlags As Byte
        Public SourceConstantAlpha As Byte
        Public AlphaFormat As Byte
    End Structure

    <DllImport("user32.dll", ExactSpelling:=True, SetLastError:=True)> _
    Public Shared Function UpdateLayeredWindow(ByVal hwnd As IntPtr, ByVal hdcDst As IntPtr, ByRef pptDst As Point, ByRef psize As Size, ByVal hdcSrc As IntPtr, ByRef pprSrc As Point, ByVal crKey As Int32, ByRef pblend As BLENDFUNCTION, ByVal dwFlags As Int32) As Boolean
    End Function


    <DllImport("user32.dll", ExactSpelling:=True, SetLastError:=True)> _
    Public Shared Function GetDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll", ExactSpelling:=True, SetLastError:=True)> _
    Public Shared Function CreateCompatibleDC(ByVal hDC As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", ExactSpelling:=True)> _
    Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer
    End Function

    <DllImport("gdi32.dll", ExactSpelling:=True, SetLastError:=True)> _
    Public Shared Function DeleteDC(ByVal hdc As IntPtr) As Boolean
    End Function


    <DllImport("gdi32.dll", ExactSpelling:=True)> _
    Public Shared Function SelectObject(ByVal hDC As IntPtr, ByVal hObject As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll", ExactSpelling:=True, SetLastError:=True)> _
    Public Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
    End Function
End Class

