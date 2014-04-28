Public Class PedidoRelat
    Dim A��o As New TrfGerais

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged, A7.CheckedChanged, A6.CheckedChanged, A8.CheckedChanged, A9.CheckedChanged, A10.CheckedChanged, A11.CheckedChanged, A12.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = True
            Me.PainelVendedor.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = True
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A3.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = True

            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = True
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A4.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A5.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = True
            Me.Cidade.Focus()
        End If

        If Me.A6.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A7.Checked Or A12.Checked Then
            Me.PainelPeriodo.Visible = False
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
        End If

        If Me.A8.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If
        If Me.A9.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = True
            Me.PainelVendedor.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If
        If Me.A10.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A11.Checked Then
            Me.PainelPeriodo.Visible = True
            Me.PanelFiltros.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelVendedor.Visible = True
            Me.PainelCidade.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A13.Checked Then
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
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            ElseIf Me.cboFiltros.Text = "" Then
                MsgBox("O usu�rio deve informar um filtro para o relat�rio.", 64, "Valida��o de Dados")
                Me.cboFiltros.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "PedidosFaturados"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        'Por cliente
        If Me.A2.Checked = True Then
            If Me.Cliente.Text = "" Then
                MsgBox("O usu�rio deve informar o cliente para o relat�rio.", 64, "Valida��o de Dados")
                Me.Cliente.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "PedidosFaturadosCliente"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        'Por Vendedor
        If Me.A3.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
                'ElseIf Me.cboFiltros.Text = "" Then
                '    MsgBox("O usu�rio deve informar um filtro para o relat�rio.", 64, "Valida��o de Dados")
                '    Me.cboFiltros.Focus()
                '    Exit Sub
                'ElseIf Me.cboFiltros.Text = "Todos" And Me.Vendedor.Text = "" Then

            End If

                RelatorioCarregar = "PedidosPorVendedor"
                My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A4.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPedidoCidadePeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A5.Checked = True Then
            If Me.Cidade.Text = "" Then
                MsgBox("O usu�rio deve informar a cidade para o relat�rio.", 64, "Valida��o de Dados")
                Me.Cidade.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPedidoCidadePeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If


        'Select Case DirectCast(sender, RadioButton).Checked



        'End Select

        If Me.A6.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPedidosFaturadoVendaInterna"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A7.Checked = True Then
            RelatorioCarregar = "RelPedidosAbertoVendaInterna"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A8.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelOrdemEntregaPendentes"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A9.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            ElseIf Me.cboFiltros.Text = "" Then
                MsgBox("O usu�rio deve informar um filtro para o relat�rio.", 64, "Valida��o de Dados")
                Me.cboFiltros.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "PedidosFaturadosTP"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A10.Checked = True Then


            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim oDA As New OleDb.OleDbDataAdapter("Select * from empresa", CNN)
            Dim oDs As New DataSet
            oDA.Fill(oDs, "T1")

            Dim rpt As New RelGraficoVendedor

            rpt.lblEmpresa.Text = oDs.Tables(0).Rows(0).Item("raz�osocial")
            rpt.lblPeriodo.Text = "Vendas realizadas no per�odo de " & Me.DataInicial.Text & " a " & Me.DataFinal.Text

            ViewReport.VerRelat.Document = rpt.Document
            rpt.Run()
            ViewReport.ShowDialog()
        End If

        'Por Vendedor por tipo
        If Me.A11.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPedidosFaturadosVendedorTP"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A12.Checked Then
            RelatorioCarregar = "RelComissaoDiario"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        'Pedidos [Margem e Lucro]
        If A13.Checked Then

            'set o caminho do banco de dados e abre o banco de dados
            Dim conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            conn.Open()

            'cria o dataset e anexa um datatable que vai ser usado no relatorio
            Dim xDs As DataSet = New DataSet("NewDataSet")
            Dim xDT As DataTable = xDs.Tables.Add("MargemLucro")


            Try
                'Seleciona todos os produtos vendidos no periodo
                Dim sSql1 = "SELECT Pedido.PedidoSequencia, ItensPedido.CodigoProduto, Produtos.Descri��o,Produtos.ValorCompra, ItensPedido.Qtd, ItensPedido.TotalProduto, ItensPedido.ValorDesconto, ItensPedido.CustoMercadoriaVendida, Pedido.C�digoFuncion�rio, Pedido.C�digoCliente, Pedido.DataPedido, Funcion�rios.Nome AS Funcionario, Clientes.Nome, Pedido.Confirmado, Pedido.Inativo, Pedido.PedidoTipo FROM (((ItensPedido INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Clientes ON Pedido.C�digoCliente = Clientes.Codigo) INNER JOIN Funcion�rios ON Pedido.C�digoFuncion�rio = Funcion�rios.C�digoFuncion�rio WHERE (((Pedido.DataPedido) Between #" & Format(CDate(DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True) AND ((Pedido.Inativo)=False));"

                'Seleciona todos os servicos vendidos no perido
                Dim sSql2 As String = "SELECT Pedido.PedidoSequencia, Pedido.C�digoFuncion�rio, Pedido.C�digoCliente, Pedido.DataPedido, Funcion�rios.Nome AS Funcionario, Clientes.Nome, Pedido.Confirmado, Pedido.Inativo, Pedido.PedidoTipo, ItemServico.Codigoservico, servicos.serv_descricao, ItemServico.qtd, ItemServico.Valorunitario, ItemServico.ValorCusto, ItemServico.ValorDesconto, ItemServico.Totalservico FROM servicos INNER JOIN (((Pedido INNER JOIN Clientes ON Pedido.C�digoCliente = Clientes.Codigo) INNER JOIN Funcion�rios ON Pedido.C�digoFuncion�rio = Funcion�rios.C�digoFuncion�rio) INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) ON servicos.serv_codigo = ItemServico.Codigoservico WHERE (((Pedido.DataPedido) Between #" & Format(CDate(DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Confirmado)=True) AND ((Pedido.Inativo)=False));"

                'Preenche os dataAdapter com as instru��es sql 
                Dim oDA1 As New OleDb.OleDbDataAdapter(sSql1, conn)
                Dim oDA2 As New OleDb.OleDbDataAdapter(sSql2, conn)
                Dim adapterEmpresa As New OleDb.OleDbDataAdapter("Select * from Empresa", conn)

                Dim ds As New DataSet 'usado para guardar as informa��es da pesquisa
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
                        rowNew("CodCliente") = I("C�digoCliente")
                        rowNew("NomeCliente") = I("Nome")
                        rowNew("DataPedido") = I("DataPedido")
                        rowNew("NomeFuncionario") = I("Funcionario")
                        rowNew("Descricao") = I("Descri��o")
                        rowNew("CodigoProduto") = I("CodigoProduto")
                        If (I("PedidoTipo").ToString = "DEVOLU��O") Then
                            rowNew("VlrDesconto") = I("ValorDesconto") * -1
                            rowNew("qtd") = I("Qtd")
                            rowNew("Custo") = I("CustoMercadoriaVendida")
                            rowNew("TotalItem") = I("TotalProduto") - (I("ValorDesconto") * -1)
                        Else
                            rowNew("VlrDesconto") = I("ValorDesconto")
                            rowNew("qtd") = I("Qtd")
                            rowNew("Custo") = I("CustoMercadoriaVendida")
                            rowNew("TotalItem") = I("TotalProduto") - I("ValorDesconto")
                        End If

                        xDT.Rows.Add(rowNew)
                    Next

                    ' insere os servi�os vendidos
                    For Each I In ds.Tables("IteS").Rows
                        rowNew = xDT.NewRow
                        rowNew("NumeroPedido") = I("PedidoSequencia")
                        rowNew("CodCliente") = I("C�digoCliente")
                        rowNew("NomeCliente") = I("Nome")
                        rowNew("DataPedido") = I("DataPedido")
                        rowNew("NomeFuncionario") = I("Funcionario")
                        rowNew("Descricao") = I("serv_descricao")
                        If (I("PedidoTipo").ToString = "DEVOLU��O") Then
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
                Catch ex As Exception
                    MessageBox.Show("Erro: " & ex.Message, "Sem conex�o", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message, "Sem conex�o", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            RelatorioCarregar = "Vendas_Margem.rpt"
            'chama a classe e passa os parametros para o relatorio
            Dim f As New ClassView.cView
            f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "Relat�rio de Margem de Lucro entre" & DataInicial.Text & " a " & DataFinal.Text, xDs)



        End If

    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                A��o.Descri��o_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Num�rico, True)
            End If
        End If
    End Sub

    Private Sub Cliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If String.IsNullOrEmpty(Me.Cliente.Text) Then
            Me.ClienteDesc.Clear()
            Exit Sub
        End If
        A��o.Descri��o_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Num�rico, True)
    End Sub

    Private Sub Vendedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Vendedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.Vendedor.Text = "" Then
                RetornoProcura = ""
                ChamaTelaProcura("Codigo", "Nome", "", "Funcion�rios", "C�digoFuncion�rio", "Nome", "", True)
                If RetornoProcura <> "" Then
                    Me.Vendedor.Text = RetornoProcura
                End If
            End If
        End If
    End Sub

    Private Sub Vendedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Vendedor.Validated
        A��o.Descri��o_ItenRegistro(Me.Vendedor, Me.VendedorDesc, "Funcion�rios", "C�digoFuncion�rio", Me.Vendedor.Text, "Nome", TrfGerais.TipoDados.Num�rico, True)
        If String.IsNullOrEmpty(Vendedor.Text) Then
            Me.VendedorDesc.Text = ""
        End If
    End Sub

   
    Private Sub btFindClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClientes.Click
        My.Forms.ClientesProcura.ShowDialog()
        If Me.Cliente.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Num�rico, True)
        End If
    End Sub

    Private Sub btFindVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindVendedor.Click
        If Me.Vendedor.Text = "" Then
            RetornoProcura = ""
            ChamaTelaProcura("Codigo", "Nome", "", "Funcion�rios", "C�digoFuncion�rio", "Nome", "", True)
            If RetornoProcura <> "" Then
                Me.Vendedor.Text = RetornoProcura
            End If
        End If
    End Sub

   
    Private Sub PedidoRelat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class