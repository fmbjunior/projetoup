Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelCusto 

    Private Sub RelCusto_DataInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        Conect.SQL = "SELECT Grupos.CódigoGrupo, Grupos.Descrição AS NomeGrupo, produtos.CodigoProduto, produtos.Descrição, produtos.ValorCompra, produtos.Ipi, produtos.FreteEntrada, produtos.pPIS, produtos.pCofins, produtos.MargemLucro, produtos.OutrosIncargos, produtos.Acrescimo, produtos.IcmsDebitado, produtos.IcmsCreditado, produtos.DiferencaIcms, produtos.Inativo, Empresa.NomeFantasia, produtos.Custo, produtos.ValorVenda FROM (produtos INNER JOIN Grupos ON produtos.CódigoGrupo = Grupos.CódigoGrupo) INNER JOIN Empresa ON produtos.Empresa = Empresa.CódigoEmpresa WHERE(((Produtos.Inativo) = False)) ORDER BY Grupos.CódigoGrupo, produtos.Descrição;"

        Me.DataSource = Conect
    End Sub
End Class
