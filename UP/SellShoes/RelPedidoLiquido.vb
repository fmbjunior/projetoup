Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelPedidoLiquido
    Dim I As Integer
    Public cPed As Integer 'Armazena o valor do codigo da venda e passa para as demais conex�oes.

   


    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If (I Mod 2) = 0 Then
            Me.Detail1.BackColor = Color.Silver
        Else
            Me.Detail1.BackColor = Color.Transparent
        End If
        I += 1
        Me.txtVlrUnitLiq.Text = FormatNumber(Me.txtValorUnitario.Text - (Me.txtValorUnitario.Text * Me.txtPercentual1.Text / 100), 4)
        Me.VlrLiquido.Text = FormatNumber(Me.txtQtd1.Text * Me.txtVlrUnitLiq.Text, 2)
    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        ''Mostra se o pedido esta cancelado na impressao.
        'If Me.txtInativo1.Text = True Then
        '    Me.lblmsgCancelado.Visible = True
        'Else
        '    Me.lblmsgCancelado.Visible = False
        'End If
    End Sub

    Private Sub RelPedidoSellShoes_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        'Conect.SQL = "SELECT Empresa.Raz�oSocial, Empresa.Endere�o AS EnderecoEmpresa, Empresa.Numero, Empresa.Telefone AS FoneEmpresa, Empresa.Cidade AS CidadeEmpresa, Empresa.Estado AS EstadoEmpresa, Empresa.Cep, Funcion�rios.Nome AS NomeFuncionario, Funcion�rios.Telefone AS FoneFuncionario, Pedido.PedidoSequencia, Pedido.DataPedido, Pedido.ValorProduto AS PedValorProdutos, Pedido.VlrDescProduto AS PedVlrDescProduto, Pedido.Acrecimo, Pedido.TotalPedido, Pedido.EnderecoEntrega, Clientes.Nome, Clientes.Endere�o, Clientes.Nro, Clientes.Cidade, Clientes.Bairro, Clientes.Estado, Clientes.Codigo, Clientes.Telefone, Clientes.Celular, ItensPedido.CodigoProduto, Produtos.Descri��o AS ProdutoDescricao, Produtos.UnidadeMedida, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, Pedido.FormaPgto, FormaPgto.Descri��o, Pedido.TipoPgto,Pedido.PedidoTipo, TipoPgto.DescricaoTipoPgto,  Pedido.Inativo FROM FormaPgto INNER JOIN (TipoPgto INNER JOIN ((Clientes INNER JOIN (Produtos INNER JOIN ((Funcion�rios INNER JOIN Pedido ON Funcion�rios.C�digoFuncion�rio = Pedido.C�digoFuncion�rio) INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) ON Produtos.CodigoProduto = ItensPedido.CodigoProduto) ON Clientes.Codigo = Pedido.C�digoCliente) INNER JOIN Empresa ON Pedido.Empresa = Empresa.C�digoEmpresa) ON TipoPgto.CodigoTipoPgto = Pedido.TipoPgto) ON FormaPgto.CodFormaPgto = Pedido.CodPgto WHERE(((Pedido.PedidoSequencia) = " & cPed & ")) ORDER BY ItensPedido.Id;"
        Conect.SQL = "SELECT Empresa.Raz�oSocial, Empresa.Endere�o AS EnderecoEmpresa, Empresa.Numero, Empresa.Telefone AS FoneEmpresa, Empresa.Cidade AS CidadeEmpresa, Empresa.Estado AS EstadoEmpresa, Empresa.Cep, Funcion�rios.Nome AS NomeFuncionario, Funcion�rios.Telefone AS FoneFuncionario, Pedido.PedidoSequencia, Pedido.Contrato, Pedido.DataPedido, Pedido.ValorProduto AS PedValorProdutos, Pedido.VlrDescProduto AS PedVlrDescProduto, Pedido.Acrecimo, Pedido.TotalPedido, Pedido.PedidoTipo, Clientes.Nome, Clientes.Endere�o, Clientes.Nro, Clientes.Cidade, Clientes.Bairro, Clientes.Estado, Clientes.Telefone, Clientes.Celular, Clientes.Codigo, ItensPedido.CodigoProduto, Produtos.Descri��o AS ProdutoDescricao, Produtos.UnidadeMedida, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, Pedido.FormaPgto, FormaPgto.Descri��o, Pedido.TipoPgto, TipoPgto.DescricaoTipoPgto, Pedido.Inativo,  Format(([Pedido].[vlrdescProduto]*100)/[Pedido].[valorproduto],'#.##') AS Percentual FROM FormaPgto INNER JOIN (TipoPgto INNER JOIN ((Clientes INNER JOIN (Produtos INNER JOIN ((Funcion�rios INNER JOIN Pedido ON Funcion�rios.C�digoFuncion�rio = Pedido.C�digoFuncion�rio) INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) ON Produtos.CodigoProduto = ItensPedido.CodigoProduto) ON Clientes.Codigo = Pedido.C�digoCliente) INNER JOIN Empresa ON Pedido.Empresa = Empresa.C�digoEmpresa) ON TipoPgto.CodigoTipoPgto = Pedido.TipoPgto) ON FormaPgto.CodFormaPgto = Pedido.CodPgto WHERE(((Pedido.PedidoSequencia) = " & cPed & ")) ORDER BY ItensPedido.Id;"
        Me.DataSource = Conect

        

    End Sub

End Class
