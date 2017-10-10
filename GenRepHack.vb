Option Strict Off
Option Explicit On

Imports System

Namespace GenRepTableAdapters

    Partial Public Class ImportDocTableAdapter
        Inherits System.ComponentModel.Component


        Public Property SelectCommand() As SqlClient.SqlCommand()

            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get

            Set(ByVal value As SqlClient.SqlCommand())
                Me._commandCollection = value
            End Set

        End Property

        Public Function FillBy(ByVal dataTable As GenRep.ImportDocDataTable, ByVal WhereExp As String) _
     As Integer

            Dim stSelect As String = Me._commandCollection(0).CommandText
            Try

                Me._commandCollection(0).CommandText = "SELECT ImportDoc.Import_Date, ImportDoc.Book_no, ImportDoc.Book_Date, ImportDoc.Summary, ImportDoc.Subject, Org.Org_Name AS ImportOrg, " & _
                     " Org_1.Org_Name AS ImporetFromOrg, Type.Type, ImportDoc.Owner_Org_No, ImportDoc.Import_Org_No, ImportDoc.Import_No, Import_Action.OpenAction, " & _
              "  Import_Action.ActionId, Import_Action.Action_Date, Import_Action.Action, Import_Action.Finish_Within, Import_Action.end_Action_Date, Import_Action.To_Org_No, " & _
                   "   Import_Action.Action_Type, Import_Action.ConsultationWith , Security.Security ,  CASE Import_Action.OpenAction WHEN 0 THEN 'غير مكتمل' WHEN 1 THEN 'مكتمل' ELSE 'غير محدد' END AS STATUSS , Actions.ActionName, Org_2.Org_Name AS To_Org_Name " & _
" FROM         ImportDoc INNER JOIN" & _
                    "  Type ON ImportDoc.Type_Code = Type.Type_Code   LEFT OUTER JOIN  Security ON ImportDoc.Security_Code = Security.Security_Code LEFT OUTER JOIN" & _
                     " Org ON ImportDoc.Owner_Org_No = Org.Org_no LEFT OUTER JOIN" & _
                     " Org AS Org_1 ON ImportDoc.Import_Org_No = Org_1.Org_no LEFT OUTER JOIN" & _
                     " Import_Action ON ImportDoc.ImportId = Import_Action.ImportId LEFT OUTER JOIN" & _
                    "  Actions ON Import_Action.Action_Type = Actions.ActionType LEFT OUTER JOIN" & _
                    "  Org AS Org_2 ON Import_Action.To_Org_No = Org_2.Org_no" & " WHERE " + WhereExp



                Return Me.Fill(dataTable)
            Catch ex As Exception

            Finally
                Me._commandCollection(0).CommandText = stSelect
            End Try

        End Function



    End Class



End Namespace