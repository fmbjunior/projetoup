Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports System
Imports System.Data

Public Class OsOrcamentoRel
    Private objProd As OsOrcamentoItemProdutoRel = Nothing
    Private objServ As OsOrcamentoItemServicoRel = Nothing
    Dim conexao As New Conectar

    Private Sub OS_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        'Criamos uma nova estância do datasource do relatório pai.
        Dim ds As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        'Define a string de conexão
        ds.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        ds.SQL = "SELECT Orcamento.*, Clientes.CpfCgc, Clientes.Insc, Clientes.Nome, Clientes.Endereço, Clientes.Nro, Clientes.Cidade, Clientes.Bairro, Clientes.Cep, Clientes.Estado, Clientes.Telefone, Clientes.Fax, Empresa.Cgc, Empresa.RazãoSocial, Empresa.Endereço, Empresa.Numero, Empresa.foto, Empresa.Telefone, Propriedades.NomePropriedade, Propriedades.Endereco, Propriedades.Cidade, Propriedades.Inscricao FROM ((Orcamento LEFT JOIN Clientes ON Orcamento.CódigoCliente = Clientes.Codigo) INNER JOIN Empresa ON Orcamento.Empresa = Empresa.CódigoEmpresa) LEFT JOIN Propriedades ON Orcamento.Propriedade = Propriedades.Id WHERE Orcamento.Orcamento=" & OSorçamento.CodOrçamento.Text


        Me.DataSource = ds

        If chkGeradoPed.Checked Then
            Me.lblMsg.Text = "Atenção.: Orçamento não é válido para fins de venda"
            Validade.Visible = False
        Else
            Me.lblMsg.Text = "Atenção.: Orçamento válido por (" & Me.Validade.Text & ")"
            Validade.Visible = True
        End If


    End Sub

    Private Sub OsOrcamentoRel_PageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PageStart
        Me.lblMsg.Text = "Atenção.: Orçamento válido por (" & Me.Validade.Text & ") dias."

    End Sub
    Private Sub OS_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        If objProd Is Nothing Then
            'Crio uma nova estância para o objeto
            objProd = New OsOrcamentoItemProdutoRel
            'Define o objeto SubRelat pela variavel.
            Me.SubProduto.Report = objProd
            'Define o dataSource do objeto SubRelat
            Me.SubProduto.Report.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        End If
        If objServ Is Nothing Then
            objServ = New OsOrcamentoItemServicoRel
            Me.SubServico.Report = objServ
            Me.SubServico.Report.DataSource = New DataSources.OleDBDataSource
        End If
        If chkGeradoPed.Checked Then
            Me.lblMsg.Text = "Atenção.: Orçamento não é válido para fins de venda"
            Validade.Visible = False
        Else
            Me.lblMsg.Text = "Atenção.: Orçamento válido por (" & Me.Validade.Text & ")"
            Validade.Visible = True
        End If

    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        'Atualizar a fonte de dados do sub-objeto SubProduto para obter registros filho a linha actual
        CType(Me.SubProduto.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        CType(Me.SubProduto.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).SQL = "SELECT OrcamentoItensProduto.Orcamento, OrcamentoItensProduto.CodigoProduto, OrcamentoItensProduto.Qtd, OrcamentoItensProduto.ValorUnitario, OrcamentoItensProduto.TotalProduto,OrcamentoItensProduto.ValorDesconto, Produtos.Descrição, ProdutoLocal.SetorLocalDesc, Produtos.UnidadeMedida FROM (OrcamentoItensProduto INNER JOIN Produtos ON OrcamentoItensProduto.CodigoProduto = Produtos.CodigoProduto) LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal WHERE OrcamentoItensProduto.Orcamento=" + Me.txtCodigoOrcamento.Text + " Order by OrcamentoItensProduto.id"

        CType(Me.SubServico.Report.DataSource, DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        CType(Me.SubServico.Report.DataSource, DataSources.OleDBDataSource).SQL = "SELECT OrcamentoItemServico.CodigoOrcamento, Servicos.Serv_Codigo, Servicos.Serv_Descricao, OrcamentoItemServico.Qtd, OrcamentoItemServico.ValorUnitario, OrcamentoItemServico.ValorDesconto, OrcamentoItemServico.TotalServico, OrcamentoItemServico.Funcionario FROM OrcamentoItemServico INNER JOIN Servicos ON OrcamentoItemServico.CodigoServico=Servicos.Serv_Codigo WHERE OrcamentoItemServico.CodigoOrcamento=" + Me.txtCodigoOrcamento.Text
        If chkGeradoPed.Checked Then
            Me.lblMsg.Text = "Atenção.: Orçamento não é válido para fins de venda"
            Validade.Visible = False
        Else
            Me.lblMsg.Text = "Atenção.: Orçamento válido por (" & Me.Validade.Text & ")"
            Validade.Visible = True
        End If


    End Sub


    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        If Me.txtCodigoPropriedade.Text > 0 Then
            Me.GroupHeader1.Visible = False
            Me.GroupHeader2.Visible = True
        End If
    End Sub

  
End Class
