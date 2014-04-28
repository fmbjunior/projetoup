Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class OsItemServico 

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format

    End Sub

    Private Sub OsItemServico_NoData(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.NoData
        Me.GroupHeader1.Visible = False
    End Sub

    Private Sub OsItemServico_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub

    Private Sub ReportHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportHeader1.Format

    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format

    End Sub
End Class
