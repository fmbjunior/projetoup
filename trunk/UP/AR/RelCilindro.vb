Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelCilindro
    Public shCod As Short
    Public isRel As Boolean = False
    Private Sub RelCilindro_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        If isRel = False Then
            Conect.SQL = "SELECT LocCilindro.LocID, LocCilindro.LocCodigoCliente, LocCilindro.LocCodigoProduto, LocCilindro.LocQtde, LocCilindro.LocData, LocCilindro.LocControle, Clientes.Nome, Produtos.Descrição FROM (LocCilindro INNER JOIN Clientes ON LocCilindro.LocCodigoCliente = Clientes.Codigo) INNER JOIN Produtos ON LocCilindro.LocCodigoProduto = Produtos.CodigoProduto WHERE (((LocCilindro.LocCodigoCliente)=" & shCod & "));"
        Else
            Conect.SQL = "SELECT LocCilindro.LocID, LocCilindro.LocCodigoCliente, LocCilindro.LocCodigoProduto, LocCilindro.LocQtde, LocCilindro.LocData, LocCilindro.LocControle, Clientes.Nome, Produtos.Descrição FROM (LocCilindro INNER JOIN Clientes ON LocCilindro.LocCodigoCliente = Clientes.Codigo) INNER JOIN Produtos ON LocCilindro.LocCodigoProduto = Produtos.CodigoProduto"
        End If
        Me.DataSource = Conect

    End Sub

End Class
