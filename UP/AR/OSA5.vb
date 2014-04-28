Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports System.Drawing

Public Class OSA5 
    Private objProd As OsItemProduto = Nothing
    Private objServ As OsItemServico = Nothing
    Private objReceber As OsReceber = Nothing
    Dim conexao As New Conectar

    Private Sub OSA5_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        'Criamos uma nova estância do datasource do relatório pai.
        Dim ds As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        'Define a string de conexão
        ds.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        ds.SQL = "SELECT Pedido.*, Pedido.PedidoSequencia,Clientes.CpfCgc, Clientes.Insc, Clientes.Nome, Clientes.Endereço, Clientes.Nro, Clientes.Cidade, Clientes.Bairro, Clientes.Cep, Clientes.Estado, Clientes.Telefone, Clientes.Fax, Funcionários.Nome AS FuncNome, Empresa.Cgc, Empresa.RazãoSocial, Empresa.Endereço, Empresa.Numero, Empresa.Telefone, Propriedades.NomePropriedade, Propriedades.Endereco, Propriedades.Cidade, Propriedades.Inscricao,[Clientes].[Codigo] & '-' & [Clientes].[Nome] AS Expr1 FROM (((Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Empresa ON Pedido.Empresa = Empresa.CódigoEmpresa) LEFT JOIN Propriedades ON Pedido.Propriedade = Propriedades.Id WHERE Pedido.PedidoSequencia=" & PedidoOS.PedidoSequencia.Text


        Me.DataSource = ds

        Dim sql As String = "Select * from Empresa"
        Dim oDA As New OleDb.OleDbDataAdapter(sql, ds.ConnectionString)
        Dim oDS As New DataSet
        oDA.Fill(oDS, "empresa")
        Dim bytePic() As Byte = oDS.Tables("empresa").Rows(0).Item("foto")

        Dim PicMemStream As New System.IO.MemoryStream(bytePic)

        Picture1.Image = Image.FromStream(PicMemStream)




    End Sub
    Private Sub OSA5_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        If objProd Is Nothing Then
            'Crio uma nova estância para o objeto
            objProd = New OsItemProduto
            'Define o objeto SubRelat pela variavel.
            Me.SubProduto.Report = objProd
            'Define o dataSource do objeto SubRelat
            Me.SubProduto.Report.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        End If
        If objServ Is Nothing Then
            objServ = New OsItemServico
            Me.SubServico.Report = objServ
            Me.SubServico.Report.DataSource = New DataSources.OleDBDataSource
        End If
        If objReceber Is Nothing Then
            objReceber = New OsReceber
            Me.SubReceber.Report = objReceber
            Me.SubReceber.Report.DataSource = New DataSources.OleDBDataSource
        End If
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        'Atualizar a fonte de dados do sub-objeto SubProduto para obter registros filho a linha actual
        CType(Me.SubProduto.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        CType(Me.SubProduto.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).SQL = "SELECT ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, ItensPedido.Qtd, ItensPedido.ValorUnitario,ItensPedido.ValorDesconto, ItensPedido.TotalProduto, Produtos.Descrição, ProdutoLocal.SetorLocalDesc, Produtos.UnidadeMedida FROM (ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal WHERE ItensPedido.PedidoSequencia=" + Me.txtPedido_PedidoSequencia1.Text

        CType(Me.SubServico.Report.DataSource, DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        CType(Me.SubServico.Report.DataSource, DataSources.OleDBDataSource).SQL = "SELECT ItemServico.PedidoSequencia, Servicos.Serv_Codigo, Servicos.Serv_Descricao, ItemServico.Qtd, ItemServico.ValorUnitario, ItemServico.ValorDesconto, ItemServico.TotalServico, ItemServico.Funcionario FROM ItemServico INNER JOIN Servicos ON ItemServico.CodigoServico=Servicos.Serv_Codigo WHERE ItemServico.PedidoSequencia=" + Me.txtPedido_PedidoSequencia1.Text

        CType(Me.SubReceber.Report.DataSource, DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        CType(Me.SubReceber.Report.DataSource, DataSources.OleDBDataSource).SQL = "SELECT Receber.Documento, Receber.ValorDocumento, Receber.Vencimento, Receber.LocalPgto FROM Receber WHERE Receber.PedidoProdutos=" + Me.txtPedido_PedidoSequencia1.Text




    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        If Me.txtCodigoPropriedade.Text > 0 Then
            Me.GroupHeader1.Visible = False
            Me.GroupHeader2.Visible = True
        End If
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        If My.Forms.PedidoOS.chkReterImposto.Checked = True Then
            Me.TLiquido.Text = FormatCurrency(Me.Tped.Text - Me.ValorIssqn.Text, 2)
        Else
            Me.TLiquido.Text = FormatCurrency(Me.Tped.Text, 2)
        End If
    End Sub
End Class
