Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports System
Imports System.Data

Public Class OSLiquido
    Private objProd As OsLiquidoItemProduto = Nothing
    Private objServ As OsLiquidoItemServico = Nothing
    Private objReceber As OsReceber = Nothing
    Dim conexao As New Conectar

    Private Sub OS_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        'Criamos uma nova estância do datasource do relatório pai.
        Dim ds As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        'Define a string de conexão
        ds.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        ds.SQL = "SELECT Pedido.*, Pedido.PedidoSequencia, Clientes.CpfCgc, Clientes.Insc, Clientes.Nome, Clientes.Endereço, Clientes.Nro, Clientes.Cidade, Clientes.Bairro, Clientes.Cep, Clientes.Estado, Clientes.Telefone, Clientes.Fax, Funcionários.Nome AS FuncNome, Empresa.Cgc, Empresa.RazãoSocial, Empresa.Endereço, Empresa.Numero, Empresa.Telefone, Propriedades.NomePropriedade, Propriedades.Endereco, Propriedades.Cidade, Propriedades.Inscricao FROM (((Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Empresa ON Pedido.Empresa = Empresa.CódigoEmpresa) LEFT JOIN Propriedades ON Pedido.Propriedade = Propriedades.Id WHERE Pedido.PedidoSequencia=" & PedidoOS.PedidoSequencia.Text

        Me.DataSource = ds


    End Sub
    Private Sub OS_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        If objProd Is Nothing Then
            'Crio uma nova estância para o objeto
            objProd = New OsLiquidoItemProduto
            'Define o objeto SubRelat pela variavel.
            Me.SubProduto.Report = objProd
            'Define o dataSource do objeto SubRelat
            Me.SubProduto.Report.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        End If
        If objServ Is Nothing Then
            objServ = New OsLiquidoItemServico
            Me.SubServico.Report = objServ
            Me.SubServico.Report.DataSource = New DataSources.OleDBDataSource
        End If
        If objReceber Is Nothing Then
            objReceber = New OsReceber
            'Me.SubReceber.Report = objReceber
            'Me.SubReceber.Report.DataSource = New DataSources.OleDBDataSource
        End If


    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        'Atualizar a fonte de dados do sub-objeto SubProduto para obter registros filho a linha actual
        CType(Me.SubProduto.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        CType(Me.SubProduto.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).SQL = "SELECT ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.TotalProduto, ([TotalProduto]-[ValorDesconto])/[qtd] AS UnitarioL, ([TotalProduto]-[ValorDesconto]) AS TotalL, Produtos.Descrição, ProdutoLocal.SetorLocalDesc, Produtos.UnidadeMedida FROM (ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal WHERE ItensPedido.PedidoSequencia=" + Me.txtPedido_PedidoSequencia1.Text

        CType(Me.SubServico.Report.DataSource, DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        CType(Me.SubServico.Report.DataSource, DataSources.OleDBDataSource).SQL = "SELECT ItemServico.PedidoSequencia, Servicos.Serv_Codigo, Servicos.Serv_Descricao, ItemServico.Qtd, ItemServico.ValorUnitario, ItemServico.ValorDesconto, ItemServico.TotalServico, ItemServico.Funcionario,([Totalservico]/[qtd]) AS UnitarioL FROM ItemServico INNER JOIN Servicos ON ItemServico.CodigoServico=Servicos.Serv_Codigo WHERE ItemServico.PedidoSequencia=" + Me.txtPedido_PedidoSequencia1.Text

        'CType(Me.SubReceber.Report.DataSource, DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        'CType(Me.SubReceber.Report.DataSource, DataSources.OleDBDataSource).SQL = "SELECT Receber.Documento, Receber.ValorDocumento, Receber.Vencimento, Receber.LocalPgto FROM Receber WHERE Receber.PedidoProdutos=" + Me.txtPedido_PedidoSequencia1.Text

    End Sub

    Private Sub GroupHeader2_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader2.Format
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        If Me.txtCodigoPropriedade.Text > 0 Then
            Me.GroupHeader1.Visible = False
            Me.GroupHeader2.Visible = True
        End If
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format

        TextBox9.Text = objProd.txtTotalProduto.Text



        If My.Forms.PedidoOS.chkReterImposto.Checked = True Then
            Me.TLiquido.Text = FormatCurrency(Me.Tped.Text - Me.ValorIssqn.Text, 2)
        Else
            Me.TLiquido.Text = FormatCurrency(Me.Tped.Text, 2)
        End If
    End Sub
End Class
