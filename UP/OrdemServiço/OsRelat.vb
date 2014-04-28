Public Class OsRelat
    Dim Ação As New TrfGerais
    Public vTotalResumo As Double = 0

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A8.CheckedChanged, A5.CheckedChanged, A6.CheckedChanged, A7.CheckedChanged, A9.CheckedChanged, A10.CheckedChanged, A11.CheckedChanged, A12.CheckedChanged
        'Pedidos/OS Faturado
        If Me.A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = True
            Me.PainelVendedor.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        'Pedidos/OS Faturados por Cliente
        If Me.A2.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = True
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        'Pedidos/OS por Vendedor
        If Me.A3.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = True
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If


        'Serviços Executados
        If Me.A5.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        'Serviços Executados por grupo
        If Me.A6.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        'Lista de Preço de Serviços
        If Me.A7.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False

        End If

        'Ordem de Entrega pendentes
        If Me.A8.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If
        'Margem e Lucro
        If Me.A9.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        'Produtos vendido no periodo para Cliente
        If Me.A10.Checked Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = True
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If
        'nfe no periodo
        If Me.A11.Checked Or A12.Checked Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
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
            ElseIf Me.cboFiltros.Text = "" Then
                MsgBox("O usuário deve informar um filtro para o relatório.", 64, "Validação de Dados")
                Me.cboFiltros.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "PedidosOSFaturados"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            If Me.Cliente.Text = "" Then
                MsgBox("O usuário deve informar o cliente para o relatório.", 64, "Validação de Dados")
                Me.Cliente.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "PedidosOSFaturadosCliente"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If


        If Me.A3.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "PedidosOsPorVendedor"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If A5.Checked = True Then
            Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
            Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

            Conect.SQL = "SELECT Pedido.PedidoSequencia, Pedido.DataFechamento, servicos.serv_codigo, servicos.serv_descricao, Funcionários.Nome, ItemServico.qtd, ItemServico.Valorunitario, ItemServico.ValorDesconto, ItemServico.Totalservico, Pedido.Confirmado, ItemServico.Funcionario FROM ((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True)) ORDER BY ItemServico.Funcionario"

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim oDA As New OleDb.OleDbDataAdapter("Select * from empresa", CNN)
            Dim oDs As New DataSet
            oDA.Fill(oDs, "T1")

            Dim rpt As New RelServicoExecutado
            rpt.DataSource = Conect
            rpt.T1.Text = oDs.Tables(0).Rows(0).Item("razãosocial")
            rpt.Periodo.Text = "Serviços executados no período de " & Me.DataInicial.Text & " a " & Me.DataFinal.Text

            ViewReport.VerRelat.Document = rpt.Document
            rpt.Run()
            ViewReport.ShowDialog()
        End If


        If Me.A6.Checked = True Then

            'Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
            'Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

            ''Conect.SQL = "SELECT Pedido.PedidoSequencia, Pedido.DataFechamento, servicos.serv_codigo, servicos.serv_descricao, Funcionários.Nome, ItemServico.qtd, ItemServico.Valorunitario, ItemServico.ValorDesconto, ItemServico.Totalservico, Pedido.Confirmado, ItemServico.Funcionario FROM ((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(Me.txtA.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.txtB.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True)) ORDER BY ItemServico.Funcionario"

            'Conect.SQL = "SELECT Funcionários.Nome, Sum(ItemServico.Totalservico) AS SomaDeTotalservico, ItemServico.Funcionario, servicos.GrupoServico, GrupoServico.gDescricao FROM (((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN GrupoServico ON servicos.GrupoServico = GrupoServico.gID WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(Me.txtA.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.txtB.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True)) GROUP BY Funcionários.Nome, ItemServico.Funcionario, servicos.GrupoServico, GrupoServico.gDescricao ORDER BY ItemServico.Funcionario;"
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim oDA As New OleDb.OleDbDataAdapter("Select * from empresa", CNN)
            Dim oDa_Resumo As New OleDb.OleDbDataAdapter("SELECT ItemServico.Funcionario, Funcionários.Nome, Sum(ItemServico.Totalservico) AS SomaDeTotalservico FROM (((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN GrupoServico ON servicos.GrupoServico = GrupoServico.gID WHERE (((Pedido.Confirmado)=True) AND ((Pedido.DataFechamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY ItemServico.Funcionario, Funcionários.Nome;", CNN)
            Dim oDs As New DataSet
            oDA.Fill(oDs, "T1")
            oDa_Resumo.Fill(oDs, "Resumo")

            Dim rpt As New RelServicoExecutadoGrupo
            'rpt.DataSource = Conect
            rpt.T1.Text = oDs.Tables(0).Rows(0).Item("razãosocial")
            rpt.Periodo.Text = "Serviços executados no período de " & Me.DataInicial.Text & " a " & Me.DataFinal.Text

            If oDs.Tables("Resumo").Compute("SUM(SomaDeTotalServico)", "") Is DBNull.Value Then
                vTotalResumo = 0

            Else
                vTotalResumo = oDs.Tables("Resumo").Compute("SUM(SomaDeTotalServico)", "")
            End If
            ViewReport.VerRelat.Document = rpt.Document
            rpt.Run()
            ViewReport.ShowDialog()



        End If

        If Me.A7.Checked = True Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim oDA As New OleDb.OleDbDataAdapter("Select * from empresa", CNN)
            Dim oDs As New DataSet
            oDA.Fill(oDs, "T1")

            Dim rpt As New RelServicoListaDePreco
            'rpt.DataSource = Conect
            rpt.T1.Text = oDs.Tables(0).Rows(0).Item("razãosocial")
            rpt.Periodo.Text = "Serviços executados no período de " & Me.DataInicial.Text & " a " & Me.DataFinal.Text

            ViewReport.VerRelat.Document = rpt.Document
            rpt.Run()
            ViewReport.ShowDialog()
        End If

      
        If Me.A8.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelOrdemEntregaPendentes"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If A9.Checked Then 'Relatorio Margem de lucro

            Dim conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            conn.Open()

            'cria o dataset e anexa um datatable que vai ser usado no relatorio
            Dim xDs As DataSet = New DataSet("NewDataSet")
            Dim xDT As DataTable = xDs.Tables.Add("MargemLucro")


            Try
                'Seleciona todos os produtos vendidos no periodo
                Dim sSql1 = "SELECT Pedido.PedidoSequencia, ItensPedido.CodigoProduto, Produtos.Descrição,Produtos.ValorCompra, ItensPedido.Qtd, ItensPedido.TotalProduto, ItensPedido.ValorDesconto, Pedido.CódigoFuncionário, Pedido.CódigoCliente, Pedido.DataPedido, Funcionários.Nome AS Funcionario, Clientes.Nome, Pedido.Confirmado, Pedido.Inativo, Pedido.PedidoTipo FROM (((ItensPedido INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.DataPedido) Between #" & Format(CDate(DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True) AND ((Pedido.Inativo)=False));"

                'Seleciona todos os servicos vendidos no perido
                Dim sSql2 As String = "SELECT Pedido.PedidoSequencia, Pedido.CódigoFuncionário, Pedido.CódigoCliente, Pedido.DataPedido, Funcionários.Nome AS Funcionario, Clientes.Nome, Pedido.Confirmado, Pedido.Inativo, Pedido.PedidoTipo, ItemServico.Codigoservico, servicos.serv_descricao, ItemServico.qtd, ItemServico.Valorunitario, ItemServico.ValorCusto, ItemServico.ValorDesconto, ItemServico.Totalservico FROM servicos INNER JOIN (((Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) ON servicos.serv_codigo = ItemServico.Codigoservico WHERE (((Pedido.DataPedido) Between #" & Format(CDate(DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True) AND ((Pedido.Inativo)=False));"

                'Preenche os dataAdapter com as instruções sql 
                Dim oDA1 As New OleDb.OleDbDataAdapter(sSql1, conn)
                Dim oDA2 As New OleDb.OleDbDataAdapter(sSql2, conn)
                Dim adapterEmpresa As New OleDb.OleDbDataAdapter("Select * from Empresa", conn)

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
                Try
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
                            rowNew("Custo") = I("ValorCompra") * -1
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
                            rowNew("TotalItem") = I("Totalservico")
                        End If

                        xDT.Rows.Add(rowNew)
                    Next




                Catch ex As Exception
                    MessageBox.Show("Erro: " & ex.Message, "Sem conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try



            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message, "Sem conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            RelatorioCarregar = "Vendas_Margem.rpt"
            'chama a classe e passa os parametros para o relatorio
            Dim f As New ClassView.cView
            f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "Relatório de Margem de Lucro entre" & DataInicial.Text & " a " & DataFinal.Text, xDs)


        End If

        'A10 produtos vendidos no perido para o cliente
        If A10.Checked Then
            Try
                RelatorioCarregar = "RelProdutoVendidoCliente.rpt"
                Dim strFormula As String = "{Pedido.DataPedido}>=Date (" & Format(CDate(DataInicial.Text), "yyyy,MM,dd") & ") and {Pedido.DataPedido}<=date(" & Format(CDate(DataFinal.Text), "yyyy,MM,dd") & ") AND {Pedido.Confirmado} AND not {Pedido.Inativo} AND {Pedido.CódigoCliente}=" & Me.Cliente.Text
                'chama a classe e passa os parametros para o relatorio
                Dim f As New ClassView.cView
                f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "Relatório de Produtos Vendidos entre " & DataInicial.Text & " a " & DataFinal.Text, strFormula)

            Catch ex As Exception

            End Try

        End If 'fim do A10

        If A11.Checked Then
            Try
                RelatorioCarregar = "RelNfPecasPeriodo.rpt"
                Dim strFormula As String = "{Pedido.DataPedido}>=Date (" & Format(CDate(DataInicial.Text), "yyyy,MM,dd") & ") and {Pedido.DataPedido}<=date(" & Format(CDate(DataFinal.Text), "yyyy,MM,dd") & ") AND {Pedido.Confirmado} AND not {Pedido.Inativo} AND {Pedido.NfePecas} > '0'"
                'chama a classe e passa os parametros para o relatorio
                Dim f As New ClassView.cView
                f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "Pedidos com Nota de Peças no Período entre " & DataInicial.Text & " a " & DataFinal.Text, strFormula)

            Catch ex As Exception

            End Try
        End If

        If A12.Checked Then
            Try
                RelatorioCarregar = "RelNfServiço.rpt"
                Dim strFormula As String = "{Pedido.DataPedido}>=Date (" & Format(CDate(DataInicial.Text), "yyyy,MM,dd") & ") and {Pedido.DataPedido}<=date(" & Format(CDate(DataFinal.Text), "yyyy,MM,dd") & ") AND {Pedido.Confirmado} AND not {Pedido.Inativo} AND {Pedido.NfeServico} > '0'"
                'chama a classe e passa os parametros para o relatorio
                Dim f As New ClassView.cView
                f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "Pedidos com Nota de Serviços no Período entre " & DataInicial.Text & " a " & DataFinal.Text, strFormula)

            Catch ex As Exception

            End Try
        End If



    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
            End If
        End If
    End Sub

    Private Sub Cliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If String.IsNullOrEmpty(Me.Cliente.Text) Then
            Me.ClienteDesc.Clear()
            Exit Sub
        End If

        Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
    End Sub

    Private Sub Vendedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Vendedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.Vendedor.Text = "" Then
                RetornoProcura = ""
                ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", True)
                If RetornoProcura <> "" Then
                    Me.Vendedor.Text = RetornoProcura
                End If
            End If
        End If
    End Sub

    Private Sub Vendedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Vendedor.Validated
        Ação.Descrição_ItenRegistro(Me.Vendedor, Me.VendedorDesc, "Funcionários", "CódigoFuncionário", Me.Vendedor.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
    End Sub

   
    Private Sub OsRelat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub A7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A7.CheckedChanged

    End Sub
End Class