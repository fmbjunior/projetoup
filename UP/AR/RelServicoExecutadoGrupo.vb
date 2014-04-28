Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports System
Imports System.Data
Public Class RelServicoExecutadoGrupo
    'Declaramos a veriável para o sub report
    Private objSubReport As RelResumoServicoGrupo = Nothing
    Dim conexao As New Conectar
    Public TotalResumo As Double = 0

    Private Sub RelServicoExecutadoGrupo_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        'Criamos uma nova estância do datasource do relatório pai.
        Dim ds As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        'Define a string de conexão
        ds.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        ds.SQL = "SELECT servicos.GrupoServico, GrupoServico.gDescricao, Funcionários.Nome, Sum(ItemServico.Totalservico) AS SomaDeTotalservico,itemServico.Funcionario FROM (((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN GrupoServico ON servicos.GrupoServico = GrupoServico.gID WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(OsRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(OsRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True)) GROUP BY servicos.GrupoServico, GrupoServico.gDescricao, Funcionários.Nome, ItemServico.Funcionario ORDER BY servicos.GrupoServico;"

        Me.DataSource = ds
    End Sub

    
    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        'Atualizar a fonte de dados do sub-objeto SubProduto para obter registros filho a linha actual
        CType(Me.subrlt.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        CType(Me.subrlt.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).SQL = "SELECT ItemServico.Funcionario, Funcionários.Nome, Sum(ItemServico.Totalservico) AS SomaDeTotalservico FROM (((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN GrupoServico ON servicos.GrupoServico = GrupoServico.gID WHERE (((Pedido.Confirmado)=True) AND ((Pedido.DataFechamento) Between #" & Format(CDate(OsRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(OsRelat.DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY ItemServico.Funcionario, Funcionários.Nome;"
    End Sub

    Private Sub RelServicoExecutadoGrupo_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        If objSubReport Is Nothing Then
            'Crio uma nova estância para o objeto
            objSubReport = New RelResumoServicoGrupo
            'Define o objeto SubRelat pela variavel.
            Me.subrlt.Report = objSubReport
            'Define o dataSource do objeto SubRelat
            Me.subrlt.Report.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        End If
    End Sub
End Class
