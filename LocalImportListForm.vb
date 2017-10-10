Imports DevExpress.XtraGrid.Views.Grid
Imports System.Threading

Public Class LocalImportListForm

    Private Sub LocalImportListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            lclfrmImpList = Nothing
            ActionOpenFormProperty = ""
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


    Private Sub LocalImportListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'NewDBFDataSet.Import_Action' table. You can move, or remove it, as needed.
            '''''''''''' Me.Import_ActionTableAdapter.Fill(Me.NewDBFDataSet.Import_Action)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Security' table. You can move, or remove it, as needed.
            Me.SecurityTableAdapter.Fill(Me.NewDBFDataSet.Security)
            'TODO: This line of code loads data into the 'NewDBFDataSet.Type' table. You can move, or remove it, as needed.
            Me.TypeTableAdapter.Fill(Me.NewDBFDataSet.Type)

            'CurOrgNo = "0010"

            Me.ImportDocForTransferTableAdapter.FillBytransfer(Me.NewDBFDataSet.ImportDocForTransfer, CurOrgNo)


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





    Private Sub ImportGridControl_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportGridControl.DoubleClick
        Try
            Dim tmp As String

            tmp = GridView1.GetFocusedDataRow("ImportId")
            If tmp <> Nothing Then
                SelectedImpIDProperty = tmp
                If SelectedImpIDProperty <> "" Then
                    EditOrAddProperty = "EDIT"

                    ffrm = NewImpForm
                    ffrm.TextEdit1.Enabled = False
                    ffrm.TextEdit2.Enabled = False
                    ffrm.TextEdit3.Enabled = False
                    ffrm.DateEdit1.Enabled = False
                    ffrm.DateEdit2.Enabled = False
                    ffrm.PopupContainerEdit1.Enabled = False
                    ffrm.LookUpEdit2.Enabled = False
                    ffrm.LookUpEdit3.Enabled = False
                    ffrm.SimpleButton1.Enabled = False
                    ffrm.SimpleButton2.Enabled = False
                    ffrm.SimpleButton3.Enabled = False
                    ffrm.SimpleButton4.Enabled = False
                    ffrm.SimpleButton5.Enabled = False

                    ffrm.GridControl1.Enabled = False
                    ffrm.GridControl2.Enabled = False
                    ActionLocalIdProperty = GridView1.GetFocusedDataRow("ActionId")
                    ActionLocalImpIdProperty = GridView1.GetFocusedDataRow("ImportId")

                    ActionOpenFormProperty = "ACTION"
                    ffrm.Show()
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


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        'Try
        '    Import_ActionTableAdapter.UpdateOpenAction(GridView1.GetFocusedDataRow("ImportId"), GridView1.GetFocusedDataRow("ActionId"))
        '    Me.ImportDocForTransferTableAdapter.FillBytransfer(Me.NewDBFDataSet.ImportDocForTransfer, CurOrgNo)
        '    GridView1.RefreshData()
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

    Private Sub GridView1_CustomUnboundColumnData(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData


        If e.Column.FieldName = "TransferFrom" Then

            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim row As DataRow = gv.GetDataRow(e.RowHandle)
            If row Is Nothing Then Return
            Dim Iid As Integer = CInt(row.Item("ImportId"))
            Dim trb As New NewDBFDataSetTableAdapters.ImportDocTableAdapter
            Dim tro As New NewDBFDataSetTableAdapters.OrgTableAdapter
            e.Value = tro.GetOrgByNo(row.Item("Cur_Org"))
        End If

        If e.Column.FieldName = "ImportFrom" Then

            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim row As DataRow = gv.GetDataRow(e.RowHandle)
            If row Is Nothing Then Return
            Dim Iid As Integer = CInt(row.Item("ImportId"))
            Dim Aid As Integer = CInt(row.Item("ActionId"))
            Dim trb As New NewDBFDataSetTableAdapters.ImportDocTableAdapter
            Dim tro As New NewDBFDataSetTableAdapters.OrgTableAdapter
            e.Value = tro.GetOrgByNo(trb.GetImportFromId(Iid))
        End If

        If e.Column.FieldName = "Folder" Then

            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim row As DataRow = gv.GetDataRow(e.RowHandle)
            If row Is Nothing Then Return
            Dim Iid As Integer = CInt(row.Item("ImportId"))

            Dim trb As New NewDBFDataSetTableAdapters.ImportSavedActionTableAdapter

            If trb.GetSaveAction(Iid, CurOrgNo).Rows.Count > 0 Then
                e.Value = trb.GetSaveAction(Iid, CurOrgNo).Item(0).Action
            Else
                e.Value = "غير محفوظ"
            End If



        End If



    End Sub
End Class