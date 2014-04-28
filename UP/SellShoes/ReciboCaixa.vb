Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class ReciboCaixa 
    Public cPed As Integer
    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub

    Private Sub ReciboCaixa_DataInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        Conect.SQL = "Select *  FROM LancamentoBanco where id=" & cPed

        Me.DataSource = Conect

    End Sub

End Class
