Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelCusto 

    Private Sub RelCusto_DataInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        Conect.SQL = "SELECT Grupos.C�digoGrupo, Grupos.Descri��o AS NomeGrupo, produtos.CodigoProduto, produtos.Descri��o, produtos.ValorCompra, produtos.Ipi, produtos.FreteEntrada, produtos.pPIS, produtos.pCofins, produtos.MargemLucro, produtos.OutrosIncargos, produtos.Acrescimo, produtos.IcmsDebitado, produtos.IcmsCreditado, produtos.DiferencaIcms, produtos.Inativo, Empresa.NomeFantasia, produtos.Custo, produtos.ValorVenda FROM (produtos INNER JOIN Grupos ON produtos.C�digoGrupo = Grupos.C�digoGrupo) INNER JOIN Empresa ON produtos.Empresa = Empresa.C�digoEmpresa WHERE(((Produtos.Inativo) = False)) ORDER BY Grupos.C�digoGrupo, produtos.Descri��o;"

        Me.DataSource = Conect
    End Sub
End Class
