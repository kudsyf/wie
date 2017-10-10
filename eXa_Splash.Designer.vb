Imports Microsoft.VisualBasic
Imports System

Partial Public Class eXa_Splash
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(eXa_Splash))
        Me.timerFade = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        ' 
        ' timerFade
        ' 
        Me.timerFade.Enabled = True
        Me.timerFade.Interval = 50
        '			Me.timerFade.Tick += New System.EventHandler(Me.timerFade_Tick);
        ' 
        ' FormSplash
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = (CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image))
        Me.ClientSize = New System.Drawing.Size(601, 359)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        Me.TopMost = True
        '			Me.Load += New System.EventHandler(Me.Form1_Load);
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents timerFade As System.Windows.Forms.Timer

End Class


