Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class OsLiquidoItemProduto

    Private Sub OsItemProduto_NoData(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.NoData
        Me.GroupHeader1.Visible = False
        Me.GroupFooter1.Visible = False

    End Sub


End Class
