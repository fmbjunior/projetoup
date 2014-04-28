Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelPedidoSellShoes
    Dim I As Integer
    Public cPed As Integer 'Armazena o valor do codigo da venda e passa para as demais conexãoes.

    Dim ParcelamentoSub As New RelPedidoSellShoesParcelamento


    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If (I Mod 2) = 0 Then
            Me.Detail1.BackColor = Color.Silver
        Else
            Me.Detail1.BackColor = Color.Transparent
        End If
        I += 1

        CType(Me.Parcelas.Report.DataSource, DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        CType(Me.Parcelas.Report.DataSource, DataSources.OleDBDataSource).SQL = "SELECT Receber.Documento, Receber.Vencimento, Receber.ValorDocumento FROM Receber WHERE Receber.OriginalParcial='O' and Receber.PedidoProdutos=" & cPed & ""

    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        Me.txtPedVlrDescProduto1.Text = FormatCurrency(CDbl(NzZero(Me.txtAcrecimo1.Text)) - CDbl(NzZero(Me.TextBox2.Text)), 2)

        'Mostra se o pedido esta cancelado na impressao.
        If Me.txtInativo1.Text = True Then
            Me.lblmsgCancelado.Visible = True
        Else
            Me.lblmsgCancelado.Visible = False
        End If
    End Sub

    Private Sub RelPedidoSellShoes_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        'Conect.SQL = "SELECT Empresa.RazãoSocial, Empresa.Endereço AS EnderecoEmpresa, Empresa.Numero, Empresa.Telefone AS FoneEmpresa, Empresa.Cidade AS CidadeEmpresa, Empresa.Estado AS EstadoEmpresa, Empresa.Cep, Funcionários.Nome AS NomeFuncionario, Funcionários.Telefone AS FoneFuncionario, Pedido.PedidoSequencia, Pedido.DataPedido, Pedido.ValorProduto AS PedValorProdutos, Pedido.VlrDescProduto AS PedVlrDescProduto, Pedido.Acrecimo, Pedido.TotalPedido, Pedido.EnderecoEntrega, Clientes.Nome, Clientes.Endereço, Clientes.CpfCgc, Clientes.Nro, Clientes.Cidade, Clientes.Bairro, Clientes.Estado, Clientes.Codigo, Clientes.Telefone, Clientes.Celular, ItensPedido.CodigoProduto, Produtos.Descrição AS ProdutoDescricao, Produtos.UnidadeMedida, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.ValorDesconto,ItensPedido.TotalProduto, Pedido.FormaPgto, FormaPgto.Descrição, Pedido.TipoPgto,Pedido.PedidoTipo, TipoPgto.DescricaoTipoPgto,  Pedido.Inativo FROM FormaPgto INNER JOIN (TipoPgto INNER JOIN ((Clientes INNER JOIN (Produtos INNER JOIN ((Funcionários INNER JOIN Pedido ON Funcionários.CódigoFuncionário = Pedido.CódigoFuncionário) INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) ON Produtos.CodigoProduto = ItensPedido.CodigoProduto) ON Clientes.Codigo = Pedido.CódigoCliente) INNER JOIN Empresa ON Pedido.Empresa = Empresa.CódigoEmpresa) ON TipoPgto.CodigoTipoPgto = Pedido.TipoPgto) ON FormaPgto.CodFormaPgto = Pedido.CodPgto WHERE(((Pedido.PedidoSequencia) = " & cPed & ")) ORDER BY ItensPedido.Id;"
        Conect.SQL = "SELECT Empresa.RazãoSocial, Empresa.Endereço AS EnderecoEmpresa, Empresa.Numero, Empresa.Telefone AS FoneEmpresa, Empresa.Cidade AS CidadeEmpresa, Empresa.Estado AS EstadoEmpresa, Empresa.Cep, Funcionários.Nome AS NomeFuncionario, Funcionários.Telefone AS FoneFuncionario, Pedido.PedidoSequencia,Pedido.Contrato, Pedido.DataPedido, Pedido.ValorProduto AS PedValorProdutos, Pedido.VlrDescProduto AS PedVlrDescProduto, Pedido.Acrecimo, Pedido.TotalPedido, Pedido.EnderecoEntrega, Clientes.Nome, Clientes.Endereço, Clientes.CpfCgc, Clientes.Nro, Clientes.Cidade, Clientes.Bairro, Clientes.Estado, Clientes.Codigo, Clientes.Telefone, Clientes.Celular, ItensPedido.CodigoProduto, Produtos.Descrição AS ProdutoDescricao, Produtos.UnidadeMedida, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.ValorDesconto, [ValorDesconto]+[vDescontoEspecial] AS [Desc], ItensPedido.TotalProduto, Pedido.FormaPgto, FormaPgto.Descrição, Pedido.TipoPgto, Pedido.PedidoTipo, TipoPgto.DescricaoTipoPgto, Pedido.Inativo FROM FormaPgto INNER JOIN (TipoPgto INNER JOIN ((Clientes INNER JOIN (Produtos INNER JOIN ((Funcionários INNER JOIN Pedido ON Funcionários.CódigoFuncionário = Pedido.CódigoFuncionário) INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) ON Produtos.CodigoProduto = ItensPedido.CodigoProduto) ON Clientes.Codigo = Pedido.CódigoCliente) INNER JOIN Empresa ON Pedido.Empresa = Empresa.CódigoEmpresa) ON TipoPgto.CodigoTipoPgto = Pedido.TipoPgto) ON FormaPgto.CodFormaPgto = Pedido.CodPgto WHERE(((Pedido.PedidoSequencia) = " & cPed & "))ORDER BY ItensPedido.Id;"

        Me.DataSource = Conect

        Me.Parcelas.Report = ParcelamentoSub

    End Sub

End Class
