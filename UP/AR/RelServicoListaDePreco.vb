Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports System
Imports System.Data
Public Class RelServicoListaDePreco
    'Declaramos a veriável para o sub report
    'Private objSubReport As RelResumoServicoGrupo = Nothing
    Dim conexao As New Conectar
    Public TotalResumo As Double = 0

    Private Sub RelServicoListaDePreco_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        'Criamos uma nova estância do datasource do relatório pai.
        Dim ds As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        'Define a string de conexão
        ds.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD) '"provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet oledb:database password=abc;"
        ds.SQL = "SELECT servicos.serv_codigo, servicos.serv_descricao, servicos.serv_valorservico, servicos.serv_referencia, GrupoServico.gDescricao FROM GrupoServico INNER JOIN servicos ON GrupoServico.gID = servicos.GrupoServico ORDER BY GrupoServico.gDescricao;"
        Me.DataSource = ds
    End Sub


    Private Sub RelServicoListaDePreco_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        'If objSubReport Is Nothing Then
        '    'Crio uma nova estância para o objeto
        '    objSubReport = New RelResumoServicoGrupo
        '    'Define o objeto SubRelat pela variavel.
        '    Me.subrlt.Report = objSubReport
        '    'Define o dataSource do objeto SubRelat
        '    Me.subrlt.Report.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        'End If
    End Sub
End Class
