
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class SessionList

    Private Sub SessionList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewDBFDataSet.Org' table. You can move, or remove it, as needed.
        Me.OrgTableAdapter.Fill(Me.NewDBFDataSet.Org)
        'TODO: This line of code loads data into the 'NewDBFDataSet.Login_Session' table. You can move, or remove it, as needed.
        Me.Login_SessionTableAdapter.Fill(Me.NewDBFDataSet.Login_Session)

    End Sub





    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click


        PrintableComponentLink1.CreateDocument()


        PrintableComponentLink1.ShowPreview()


    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(sender As System.Object, e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 14, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString("الهيئة الوطنية للاستثمار", Color.Black, rec, BorderSide.None)

        Dim rec2 As RectangleF = New RectangleF(0, 50, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString("جدول استخدام الموظفين", Color.Black, rec2, BorderSide.None)

    End Sub
End Class