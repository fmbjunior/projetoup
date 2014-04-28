Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelComissaoFaixa 


    Dim SubRelat As RelComissaoFaixaSub = Nothing

   
    Private Sub GroupHeader2_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader2.Format
        If Me.IsFaturamento.Checked = True Then
            Me.txtComissaoFat.Text = "Comissão de Faturamento"
        Else
            Me.txtComissaoFat.Text = "Comissão de Recebimento"
        End If
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If Me.Detail1.BackColor = Color.Transparent Then
            Me.Detail1.BackColor = Color.LightGray
        Else
            Me.Detail1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub RelComissaoFaixa_NoData(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.NoData
        MessageBox.Show("Não existe informações para gerar o relatório", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
    
        Dim Sql As String = String.Empty
        Sql = "SELECT 1 AS Seq, Receber.Vendedor, Sum(Receber.ValorDocumento) AS SomaDeValorDocumento, 'Vlr Carteira' AS Carteira FROM(Receber) WHERE(((Receber.Empresa) = " & CodEmpresa & ") And ((Receber.Baixado) = False) And ((Receber.Inativo) = False)) GROUP BY 1, Receber.Vendedor, 'Vlr Carteira' HAVING(((Receber.Vendedor) = " & Me.txtFuncionario1.Text & ")) ORDER BY 1; UNION SELECT 2 AS Seq, Receber.Vendedor, Sum(Receber.ValorDocumento) AS SomaDeValorDocumento, 'Vencidas' AS Carteira FROM(Receber) WHERE (((Receber.Empresa)=" & CodEmpresa & ") AND ((Receber.Baixado)=False) AND ((Receber.Inativo)=False) AND ((Receber.Vencimento)<Date())) GROUP BY 2, Receber.Vendedor, 'Vencidas' HAVING(((Receber.Vendedor) = " & Me.txtFuncionario1.Text & ")) ORDER BY 2;"

        CType(Me.SubIndice.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        CType(Me.SubIndice.Report.DataSource, DataDynamics.ActiveReports.DataSources.OleDBDataSource).SQL = Sql
    
    End Sub

    Private Sub RelComissaoFaixa_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportEnd
        SubRelat.Document.Dispose()
        SubRelat.Dispose()
        SubRelat = Nothing
    End Sub

    Private Sub RelComissaoFaixa_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        If SubRelat Is Nothing Then
            SubRelat = New RelComissaoFaixaSub
            Me.SubIndice.Report = SubRelat
            Me.SubIndice.Report.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        End If
    End Sub
End Class
