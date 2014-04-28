Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports System
Imports System.Data

Public Class RelPedidocompra 
    Private objPagar As RelPedidoCompraParcelamento = Nothing
    Dim conexao As New Conectar

    Private Sub RelPedidocompra_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        'Criamos uma nova estância do datasource do relatório pai.
        Dim ds As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        'Define a string de conexão
        ds.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        ds.SQL = "SELECT PedidoCompra.CodigoPedidoCompra, PedidoCompra.CodigoFornecedor, PedidoCompra.CodigoFuncionario, PedidoCompra.Datalancamento, PedidoCompra.DataPrevistaEntrega, PedidoCompra.TotalPedidoCompra, PedidoCompra.Parcelas, PedidoCompra.DataPrimeiroVencimento, PedidoCompra.Obs, PedidoCompraItem.CodigoProduto, PedidoCompraItem.Qtd, PedidoCompraItem.ValorUnitario, PedidoCompraItem.TotalProduto, PedidoCompraItem.Tamanho, Produtos.Descrição, Fornecedor.RazãoSocial, Funcionários.Nome FROM (((PedidoCompraItem INNER JOIN Produtos ON PedidoCompraItem.CodigoProduto = Produtos.CodigoProduto) INNER JOIN PedidoCompra ON PedidoCompraItem.CompraInterno = PedidoCompra.CodigoPedidoCompra) INNER JOIN Fornecedor ON PedidoCompra.CodigoFornecedor = Fornecedor.CódigoFornecedor) INNER JOIN Funcionários ON PedidoCompra.CodigoFuncionario = Funcionários.CódigoFuncionário WHERE PedidoCompra.CodigoPedidoCompra=" & SellShoesPedidoCompra.CodigoPedidoCompra.Text


        Me.DataSource = ds
    End Sub
    Private Sub RelPedidocompra_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        If objPagar Is Nothing Then
            objPagar = New RelPedidoCompraParcelamento
            Me.SubPagar.Report = objPagar
            Me.SubPagar.Report.DataSource = New DataSources.OleDBDataSource
        End If
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        'Atualizar a fonte de dados do sub-objeto SubProduto para obter registros filho a linha actual
        CType(Me.SubPagar.Report.DataSource, DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        CType(Me.SubPagar.Report.DataSource, DataSources.OleDBDataSource).SQL = "SELECT Documento, Valordocumento, Vencimento FROM Pagar WHERE IdPedidocompra=" + SellShoesPedidoCompra.CodigoPedidoCompra.Text

    End Sub

  
    Private Sub ReportHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportHeader1.Format
        If My.Forms.SellShoesPedidoCompra.Inativo.Checked = True Then
            Me.txtStatus.Text = "CANCELADO"
        ElseIf My.Forms.SellShoesPedidoCompra.Confirmado.Checked = True Then
            Me.txtStatus.Text = "CONFIRMADO"
        Else
            Me.txtStatus.Text = "EM ABERTO"
        End If
    End Sub
End Class
