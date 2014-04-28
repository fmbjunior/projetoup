Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class CilindroA 

    Private Sub CilindroA_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        Conect.SQL = "SELECT LocCilindro.LocCodigoCliente, LocCilindro.LocCodigoProduto, Sum(LocCilindro.LocQtde) AS SomaDeLocQtde, Clientes.Nome, Produtos.Descrição FROM (LocCilindro INNER JOIN Clientes ON LocCilindro.LocCodigoCliente = Clientes.Codigo) INNER JOIN Produtos ON LocCilindro.LocCodigoProduto = Produtos.CodigoProduto GROUP BY LocCilindro.LocCodigoProduto, LocCilindro.LocCodigoCliente,  Clientes.Nome, Produtos.Descrição;"
       
        Me.DataSource = Conect
    End Sub
End Class
