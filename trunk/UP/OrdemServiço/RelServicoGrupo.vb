Public Class RelServicoGrupo
    Public vTotalResumo As Double = 0
    Private Sub butfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butfechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub butImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butImprimir.Click
        'Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        'Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        ''Conect.SQL = "SELECT Pedido.PedidoSequencia, Pedido.DataFechamento, servicos.serv_codigo, servicos.serv_descricao, Funcionários.Nome, ItemServico.qtd, ItemServico.Valorunitario, ItemServico.ValorDesconto, ItemServico.Totalservico, Pedido.Confirmado, ItemServico.Funcionario FROM ((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(Me.txtA.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.txtB.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True)) ORDER BY ItemServico.Funcionario"

        'Conect.SQL = "SELECT Funcionários.Nome, Sum(ItemServico.Totalservico) AS SomaDeTotalservico, ItemServico.Funcionario, servicos.GrupoServico, GrupoServico.gDescricao FROM (((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN GrupoServico ON servicos.GrupoServico = GrupoServico.gID WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(Me.txtA.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.txtB.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True)) GROUP BY Funcionários.Nome, ItemServico.Funcionario, servicos.GrupoServico, GrupoServico.gDescricao ORDER BY ItemServico.Funcionario;"
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim oDA As New OleDb.OleDbDataAdapter("Select * from empresa", CNN)
        Dim oDa_Resumo As New OleDb.OleDbDataAdapter("SELECT ItemServico.Funcionario, Funcionários.Nome, Sum(ItemServico.Totalservico) AS SomaDeTotalservico FROM (((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN GrupoServico ON servicos.GrupoServico = GrupoServico.gID WHERE (((Pedido.Confirmado)=True) AND ((Pedido.DataFechamento) Between #" & Format(CDate(Me.txtA.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.txtB.Text), "MM/dd/yyyy") & "#)) GROUP BY ItemServico.Funcionario, Funcionários.Nome;", CNN)
        Dim oDs As New DataSet
        oDA.Fill(oDs, "T1")
        oDa_Resumo.Fill(oDs, "Resumo")

        Dim rpt As New RelServicoExecutadoGrupo
        'rpt.DataSource = Conect
        rpt.T1.Text = oDs.Tables(0).Rows(0).Item("razãosocial")
        rpt.Periodo.Text = "Serviços executados no período de " & Me.txtA.Text & " a " & Me.txtB.Text

        If oDs.Tables("Resumo").Compute("SUM(SomaDeTotalServico)", "") Is DBNull.Value Then
            vTotalResumo = 0

        Else
            vTotalResumo = oDs.Tables("Resumo").Compute("SUM(SomaDeTotalServico)", "")
        End If
        ViewReport.VerRelat.Document = rpt.Document
        rpt.Run()
        ViewReport.ShowDialog()
    End Sub
End Class