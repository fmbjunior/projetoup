Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class BalanceteOrcamentarioRelat
    Public strFiltro As String = ""
    Dim objectRpt As New ReportDocument()
    Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados
    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A15.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked Then
            Visualizador.Refresh()
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

        If Me.A15.Checked Then
            Visualizador.Refresh()
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If
        If Me.A2.Checked Then
            Visualizador.Refresh()
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click

        If Me.A1.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            Dim DS As New DataSet()
            Dim Sql As String = String.Empty


            Try


                Sql = "SELECT ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, BalanceteLanc.ContaBalancete, ContasG3.DescContaGrupo3, Sum(BalanceteLanc.ValorDocumento) AS SomaDeValorDocumento FROM BalanceteLanc INNER JOIN ((ContasG1 INNER JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) INNER JOIN ContasG3 ON (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1)) ON BalanceteLanc.ContaBalancete = ContasG3.ContaGrupo3 WHERE (((BalanceteLanc.DataLancamento) Between #" & Format(CDate(DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, BalanceteLanc.ContaBalancete, ContasG3.DescContaGrupo3;"
                Dim DABalancetePeriodo As New OleDb.OleDbDataAdapter(Sql, Cnn)
                DABalancetePeriodo.Fill(DS, "BalancetePeriodo")


                Sql = "Select * From Empresa Where CódigoEmpresa = " & CodEmpresa
                Dim daEmpresa As New OleDb.OleDbDataAdapter(Sql, Cnn)
                daEmpresa.Fill(DS, "Empresa")

                Dim NomeEmpresa = DS.Tables("Empresa").Rows(0).Item("RazãoSocial").ToString


                Dim Relat As New ReportDocument()
                Relat.Load(DirRelat & "RelBalancetePeriodo.rpt")

                Relat.DataDefinition.FormulaFields.Item("xEmpresa").Text = "'" & NomeEmpresa & "'"
                Relat.DataDefinition.FormulaFields.Item("xTitulo").Text = "'Balancete no Período de " & DataInicial.Text & " a " & DataFinal.Text & "'"


                Relat.SetDataSource(DS)

                Me.Visualizador.ReportSource = Relat
            Catch Ex As Exception
                MsgBox(Ex.Message)
                MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If

        If Me.A15.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            VerRelat.Load(DirRelat & "RelContaResultadoPerido.rpt")
            VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
            VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))


            Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
            T = VerRelat.ReportDefinition.ReportObjects.Item("xPeriodo")
            T.Text = "Contas de Resultados no periodo de " + DataInicial.Text + " a " + DataFinal.Text

            Me.Visualizador.SelectionFormula = CrDateBetween("{BalanceteLanc.DataLancamento}", DataInicial.Text, DataFinal.Text)
            Me.Visualizador.ReportSource = VerRelat

        End If

        'selecao por contas
        If A2.Checked Then
            If String.IsNullOrEmpty(DataInicial.Text) Or String.IsNullOrEmpty(DataFinal.Text) Then
                MessageBox.Show("Verifique a data inicial ou a data final", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataInicial.Focus()

            Else
                Try
                    Dim f As New ContasProcura
                    f.ShowDialog()

                    If String.IsNullOrEmpty(strFiltro) Then
                        MessageBox.Show("Não foi selecionado contas para gerar o relatorio", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                    Cnn.Open()

                    'cria o dataset e anexa um datatable que vai ser usado no relatorio
                    Dim xDs As DataSet = New DataSet("NewDataSet")
                    Dim xDT As DataTable = xDs.Tables.Add("MargemLucro")



                    'Seleciona todos os produtos vendidos no periodo
                    Dim sSql1 = "SELECT Pedido.PedidoSequencia, ItensPedido.CodigoProduto, Produtos.Descrição,Produtos.ValorCompra, ItensPedido.Qtd, ItensPedido.CustoMercadoriaVendida, ItensPedido.TotalProduto, ItensPedido.ValorDesconto, Pedido.CódigoFuncionário, Pedido.CódigoCliente, Pedido.DataPedido, Funcionários.Nome AS Funcionario, Clientes.Nome, Pedido.Confirmado, Pedido.Inativo, Pedido.PedidoTipo FROM (((ItensPedido INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.DataPedido) Between #" & Format(CDate(DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True) AND ((Pedido.Inativo)=False));"

                    'Seleciona todos os servicos vendidos no perido
                    Dim sSql2 As String = "SELECT Pedido.PedidoSequencia, Pedido.CódigoFuncionário, Pedido.CódigoCliente, Pedido.DataPedido, Funcionários.Nome AS Funcionario, Clientes.Nome, Pedido.Confirmado, Pedido.Inativo, Pedido.PedidoTipo, ItemServico.Codigoservico, servicos.serv_descricao, ItemServico.qtd, ItemServico.Valorunitario, ItemServico.ValorDesconto, ItemServico.ValorCusto, ItemServico.Totalservico FROM servicos INNER JOIN (((Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) ON servicos.serv_codigo = ItemServico.Codigoservico WHERE (((Pedido.DataPedido) Between #" & Format(CDate(DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True) AND ((Pedido.Inativo)=False));"

                    'Preenche os dataAdapter com as instruções sql 
                    Dim oDA1 As New OleDb.OleDbDataAdapter(sSql1, Cnn)
                    Dim oDA2 As New OleDb.OleDbDataAdapter(sSql2, Cnn)
                    Dim adapterEmpresa As New OleDb.OleDbDataAdapter("Select * from Empresa", Cnn)

                    Dim ds As New DataSet 'usado para guardar as informações da pesquisa
                    oDA1.Fill(ds, "IteP")
                    oDA2.Fill(ds, "IteS")
                    adapterEmpresa.Fill(xDs, "Empresa")


                    'Cria as colunas no datatable em runtime
                    xDT.Columns.Add("NumeroPedido", GetType(Integer))
                    xDT.Columns.Add("CodCliente", GetType(String))
                    xDT.Columns.Add("NomeCliente", GetType(String))
                    xDT.Columns.Add("DataPedido", GetType(String))
                    xDT.Columns.Add("NomeFuncionario", GetType(String))
                    xDT.Columns.Add("Descricao", GetType(String))
                    xDT.Columns.Add("qtd", GetType(Decimal))
                    xDT.Columns.Add("Custo", GetType(Decimal))
                    xDT.Columns.Add("ValorVenda", GetType(Decimal))
                    xDT.Columns.Add("TotalItem", GetType(Decimal))
                    xDT.Columns.Add("CodigoProduto", GetType(String))
                    xDT.Columns.Add("VlrDesconto", GetType(Decimal))

                    'Set o DataRow do DataSet para criar uma nova linha.
                    Dim rowNew As DataRow

                    Dim I As DataRow
                    ' insere os produtos vendidos
                    For Each I In ds.Tables("IteP").Rows


                        rowNew = xDT.NewRow
                        rowNew("NumeroPedido") = I("PedidoSequencia")
                        rowNew("CodCliente") = I("CódigoCliente")
                        rowNew("NomeCliente") = I("Nome")
                        rowNew("DataPedido") = I("DataPedido")
                        rowNew("NomeFuncionario") = I("Funcionario")
                        rowNew("Descricao") = I("Descrição")
                        rowNew("CodigoProduto") = I("CodigoProduto")
                        
                        If (I("PedidoTipo").ToString = "DEVOLUÇÃO") Then
                            rowNew("VlrDesconto") = I("ValorDesconto") * -1
                            rowNew("qtd") = I("Qtd")
                            rowNew("Custo") = I("CustoMercadoriaVendida")
                            rowNew("TotalItem") = I("TotalProduto") - (I("ValorDesconto") * -1)
                        Else
                            rowNew("VlrDesconto") = I("ValorDesconto")
                            rowNew("qtd") = I("Qtd")
                            rowNew("Custo") = I("ValorCompra")
                            rowNew("TotalItem") = I("TotalProduto") - I("ValorDesconto")
                        End If

                        xDT.Rows.Add(rowNew)
                    Next

                    ' insere os serviços vendidos
                    For Each I In ds.Tables("IteS").Rows


                        rowNew = xDT.NewRow
                        rowNew("NumeroPedido") = I("PedidoSequencia")
                        rowNew("CodCliente") = I("CódigoCliente")
                        rowNew("NomeCliente") = I("Nome")
                        rowNew("DataPedido") = I("DataPedido")
                        rowNew("NomeFuncionario") = I("Funcionario")
                        rowNew("Descricao") = I("serv_descricao")

                        If (I("PedidoTipo").ToString = "DEVOLUÇÃO") Then
                            rowNew("qtd") = I("Qtd")
                            rowNew("Custo") = I("ValorCusto") * -1
                            rowNew("VlrDesconto") = I("ValorDesconto") * -1
                            rowNew("TotalItem") = I("Totalservico") - (I("ValorDesconto") * -1)
                        Else
                            rowNew("qtd") = I("Qtd")
                            rowNew("Custo") = I("ValorCusto")
                            rowNew("VlrDesconto") = I("ValorDesconto")
                            rowNew("TotalItem") = I("Totalservico") - I("ValorDesconto")
                        End If

                        xDT.Rows.Add(rowNew)
                    Next

                    Dim lucro As Double = 0
                    Dim tot As Double = 0

                    For Each I In xDT.Rows
                        tot = I("TotalItem") / I("qtd")
                        lucro = lucro + (tot - I("custo")) * I("qtd")
                    Next



                    '*********************************************
                    Dim oDS As New DataSet()
                    Dim Sql As String = String.Empty

                    Sql = "SELECT ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, BalanceteLanc.ContaBalancete, ContasG3.DescContaGrupo3, Sum(BalanceteLanc.ValorDocumento) AS SomaDeValorDocumento FROM BalanceteLanc INNER JOIN ((ContasG1 INNER JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) INNER JOIN ContasG3 ON (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1)) ON BalanceteLanc.ContaBalancete = ContasG3.ContaGrupo3 WHERE (((BalanceteLanc.DataLancamento) Between #" & Format(CDate(DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, BalanceteLanc.ContaBalancete, ContasG3.DescContaGrupo3;"
                    Dim DABalancetePeriodo As New OleDb.OleDbDataAdapter(Sql, Cnn)
                    DABalancetePeriodo.Fill(oDS, "BalancetePeriodo")


                    Sql = "Select * From Empresa Where CódigoEmpresa = " & CodEmpresa
                    Dim daEmpresa As New OleDb.OleDbDataAdapter(Sql, Cnn)
                    daEmpresa.Fill(oDS, "Empresa")

                    Dim NomeEmpresa = oDS.Tables("Empresa").Rows(0).Item("RazãoSocial").ToString


                    Dim Relat As New ReportDocument()
                    Relat.Load(DirRelat & "RelBalanceteContas.rpt")

                    Relat.DataDefinition.FormulaFields.Item("xEmpresa").Text = "'" & NomeEmpresa & "'"
                    Relat.DataDefinition.FormulaFields.Item("xTitulo").Text = "'Balancete no Período de " & DataInicial.Text & " a " & DataFinal.Text & "'"

                    Relat.DataDefinition.FormulaFields.Item("TotalLucro").Text = "'" & FormatNumber(lucro, 2) & "'"


                    Relat.SetDataSource(oDS)

                    Dim SelectFormula As String
                    SelectFormula = strFiltro
                    Visualizador.SelectionFormula = SelectFormula

                    Me.Visualizador.ReportSource = Relat

                Catch Ex As Exception
                    MsgBox(Ex.Message)
                    MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            End If
        End If
    End Sub

    Private Sub DataFinal_Enter(sender As Object, e As EventArgs) Handles DataFinal.Enter
        Dim ultimo As DateTime = CDate(Me.DataInicial.Text).AddDays(-(CDate(Me.DataInicial.Text).Day - 1)).AddMonths(1).AddDays(-1)

        If Not String.IsNullOrWhiteSpace(DataInicial.Text) Then
            DataFinal.Text = ultimo
        End If

    End Sub

    Private Sub DataFinal_TextChanged(sender As Object, e As EventArgs) Handles DataFinal.TextChanged

    End Sub
End Class