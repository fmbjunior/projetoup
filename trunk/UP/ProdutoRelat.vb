Imports System.Text

Public Class ProdutoRelat
    Dim Ação As New TrfGerais


    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click

        If Me.A1.Checked = True Then
            RelatorioCarregar = "RelProdutoGrupo.rpt"

            Dim f As New ClassView.cView
            Dim formula As String = String.Empty
            If String.IsNullOrEmpty(Grupo.Text) Then
                formula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa & " And {Produtos.Tipo} = 1"
                f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, formula)
            Else
                formula = "{Produtos.CódigoGrupo} = " & Grupo.Text & " and {Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa & " And {Produtos.Tipo} = 1"
                f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, formula)
            End If
        End If

        If Me.A2.Checked = True Then

            If Me.Produto.Text = "" Then
                MsgBox("O usuário deve informar o produto para o relatório.", 64, "Validação de Dados")
                Me.Produto.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelAnaliseCompraVendaProduto"
            My.Forms.VisualizadorRelatorio.ShowDialog()

        End If

        If Me.A3.Checked = True Then
            If Me.Produto.Text = "" Then
                MsgBox("O usuário deve informar o produto para o relatório.", 64, "Validação de Dados")
                Me.Produto.Focus()
                Exit Sub
            End If
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial do periodo.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            End If
            If Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final do periodo.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelAnaliseCompraVendaProdutoPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()

        End If




        If Me.A5.Checked = True Then
            RelatorioCarregar = "ProdutoAlfa"
            My.Forms.VisualizadorRelatorio.ShowDialog()

        End If

        If Me.A6.Checked = True Then
            RelatorioCarregar = "RelCatalogo"
            My.Forms.VisualizadorRelatorio.ShowDialog()


            'Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
            'Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

            'Conect.SQL = "SELECT Empresa.NomeFantasia, Empresa.Foto, Empresa.Mensagem, Empresa.Telefone, Produtos.Cor, Cor.CorDesc, Produtos.CodigoProduto, Produtos.Descrição, ProdutosFoto.Foto FROM ((Produtos LEFT JOIN ProdutosFoto ON Produtos.CodigoProduto = ProdutosFoto.CodigoProduto) LEFT JOIN Cor ON Produtos.Cor = Cor.Codigo) LEFT JOIN Empresa ON Produtos.Empresa = Empresa.CódigoEmpresa WHERE (((Produtos.Cor)=" & Me.Grupo.Text & "));"

            'Dim Rel As New RelCatalogo
            'Rel.DataSource = Conect

            'My.Forms.ViewReport.VerRelat.Document = Rel.Document
            'My.Forms.ViewReport.VerRelat.Document.Name = "RelCatalogo"
            'Rel.Run()

            'My.Forms.ViewReport.ShowDialog()
        End If

        If Me.A7.Checked = True Then
            If Me.ListaPrecoSelect.Text <> "Lista de Preço - Atacado" Then
                RelatorioCarregar = "RelListaPreco"
                My.Forms.VisualizadorRelatorio.ShowDialog()
            Else
                RelatorioCarregar = "RelListaPrecoAtacado"
                My.Forms.VisualizadorRelatorio.ShowDialog()
            End If
        End If

        If Me.A8.Checked = True Then
            RelatorioCarregar = "RelProdutoCod"
            My.Forms.VisualizadorRelatorio.ShowDialog()

        End If

        If Me.A9.Checked = True Then
            RelatorioCarregar = "RelProdutoLocalizacao"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A20.Checked = True Then
            RelatorioCarregar = "RelEstoqueMinimo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A21.Checked = True Then
            If Me.Produto.Text = "" Then
                MessageBox.Show("O produto não foi informado, Favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Produto.Focus()
                Exit Sub
            End If
            RelatorioCarregar = "RelEstoqueMinimo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A22.Checked = True Then
            If Me.Grupo.Text = "" Then
                MessageBox.Show("O Grupo do Produto não foi informado, Favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Grupo.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelEstoqueMinimo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If


        If Me.A30.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial do periodo.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            End If
            If Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final do periodo.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelCurvaABC"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        'Relatorio de analise de produtos vendidos feito pelo beto.
        If Me.A31.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial do periodo.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            End If
            If Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final do periodo.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            Dim rpt As New AnaliseProdutoVendido

            Dim Data1 As Date
            Dim Data2 As Date
            Dim horasValidas As TimeSpan
            Dim diasValidos As Integer
            ' obtem o valor da data de nascimento do controle DateTimePickerl
            Data1 = Me.DataInicial.Text
            Data2 = Me.DataFinal.Text
            ' subtri a data de nascimento da data atual
            horasValidas = Data2.Subtract(Data1)
            'Calcula o número de dias entre as datas
            diasValidos = horasValidas.Days '* (-1)
            'se o valor for menor que 1 indica que a data de nascimento é maior que a data atual
            If diasValidos = 1 Then
                '    Throw New ArgumentException("Você ainda não nasceu...")
            End If

            Dim conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            conn.Open()


            Try
                Dim sql1 = "SELECT ItensCompra.CodigoProduto, Last(ItensCompra.Qtd) AS ÚltimoDeQtd FROM ItensCompra GROUP BY ItensCompra.CodigoProduto;"
                'Dim sql As String = "SELECT ItensPedido.CodigoProduto, Produtos.Descrição, Produtos.CodigoFabrica, Marcas.Marca, Produtos.ValorCompra, Produtos.ValorVenda, Produtos.QuantidadeEstoque, Produtos.EstoqueMinimo, Produtos.DescontoMaximo, Sum(ItensPedido.Qtd) AS SomaDeQtd, Pedido.Confirmado, [SomaDeQtd]/30 AS Expr1, ([QuantidadeEstoque]/" & diasValidos & ") AS DuracEstoque, Last(ItensCompra.Qtd) AS ÚltimoDeQtd,Produtos.DataUltimaCompra FROM (((ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Marcas ON Produtos.Marca = Marcas.Codigo) INNER JOIN ItensCompra ON Produtos.CodigoProduto = ItensCompra.CodigoProduto WHERE (((Pedido.DataPedido) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY ItensPedido.CodigoProduto, Produtos.Descrição, Produtos.CodigoFabrica, Marcas.Marca, Produtos.ValorCompra, Produtos.ValorVenda, Produtos.QuantidadeEstoque, Produtos.EstoqueMinimo, Produtos.DescontoMaximo, Pedido.Confirmado,Produtos.DataUltimaCompra HAVING(((Sum(ItensPedido.Qtd)) > 0) And ((Pedido.Confirmado) = True)) ORDER BY Marcas.Marca, ItensPedido.CodigoProduto, ItensPedido.CodigoProduto;"
                Dim sql As String = "SELECT ItensPedido.CodigoProduto, Produtos.Descrição, Produtos.CodigoFabrica, Marcas.Marca, Produtos.ValorCompra, Produtos.ValorVenda, Produtos.QuantidadeEstoque, Produtos.EstoqueMinimo, Produtos.DescontoMaximo, Sum(ItensPedido.Qtd) AS SomaDeQtd, Pedido.Confirmado, [SomaDeQtd]/" & diasValidos & " AS Expr1, ([QuantidadeEstoque]/Expr1) AS DuracEstoque, Produtos.DataUltimaCompra,0 AS UltimoValorCompra FROM ((ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Marcas ON Produtos.Marca = Marcas.Codigo WHERE (((Pedido.DataPedido) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY ItensPedido.CodigoProduto, Produtos.Descrição, Produtos.CodigoFabrica, Marcas.Marca, Produtos.ValorCompra, Produtos.ValorVenda, Produtos.QuantidadeEstoque, Produtos.EstoqueMinimo, Produtos.DescontoMaximo, Pedido.Confirmado, Produtos.DataUltimaCompra HAVING (((Sum(ItensPedido.Qtd))>0) AND ((Pedido.Confirmado)=True)) ORDER BY Marcas.Marca, ItensPedido.CodigoProduto, ItensPedido.CodigoProduto;"

                Dim oDA1 As New OleDb.OleDbDataAdapter(sql1, conn)
                Dim oDA As New OleDb.OleDbDataAdapter(sql, conn)
                Dim adapterEmpresa As New OleDb.OleDbDataAdapter("Select * from Empresa", conn)

                Dim ds As New DataSet
                oDA.Fill(ds, "Ped")
                oDA1.Fill(ds, "IteCompra")
                adapterEmpresa.Fill(ds, "Empresa")

                Dim myTable As New DataTable
                myTable.Columns.Add("CodigoProduto", GetType(String))
                myTable.Columns.Add("Descrição", GetType(String))
                myTable.Columns.Add("CodigoFabrica", GetType(String))
                myTable.Columns.Add("Marca", GetType(String))
                myTable.Columns.Add("ValorCompra", GetType(Decimal))
                myTable.Columns.Add("valorVenda", GetType(Decimal))
                myTable.Columns.Add("QuantidadeEstoque", GetType(Decimal))
                myTable.Columns.Add("EstoqueMinimo", GetType(Decimal))
                myTable.Columns.Add("DescontoMaximo", GetType(Decimal))
                myTable.Columns.Add("SomaDeQtd", GetType(Decimal))
                myTable.Columns.Add("Confirmado", GetType(Boolean))
                myTable.Columns.Add("Expr1", GetType(Decimal))
                myTable.Columns.Add("DuracEstoque", GetType(Decimal))
                myTable.Columns.Add("DataUltimaCompra", GetType(String))
                myTable.Columns.Add("UltimoValorCompra", GetType(Decimal))


                'Set o DataRow do DataSet para criar uma nova linha.
                Dim rowNew As DataRow

                Dim I As DataRow
                Try
                    For Each I In ds.Tables("Ped").Rows
                        Dim Linha() As DataRow
                        Linha = ds.Tables("IteCompra").Select("CodigoProduto=" & I("CodigoProduto"))
                        If Linha.Length <> 0 Then
                            rowNew = myTable.NewRow
                            rowNew("CodigoProduto") = I("codigoProduto")
                            rowNew("Descrição") = I("Descrição")
                            rowNew("CodigoFabrica") = I("CodigoFabrica")
                            rowNew("Marca") = I("Marca")
                            rowNew("ValorCompra") = I("ValorCompra")
                            rowNew("valorVenda") = I("ValorVenda")
                            rowNew("QuantidadeEstoque") = I("QuantidadeEstoque")
                            rowNew("EstoqueMinimo") = I("EstoqueMinimo")
                            rowNew("DescontoMaximo") = I("DescontoMaximo")
                            rowNew("SomaDeQtd") = I("SomaDeQtd")
                            rowNew("Confirmado") = I("Confirmado")
                            rowNew("Expr1") = I("Expr1")
                            rowNew("DuracEstoque") = I("DuracEstoque")
                            rowNew("DataUltimaCompra") = I("DataUltimaCompra")
                            rowNew("UltimoValorCompra") = Linha(0)("ÚltimoDeQtd")
                            myTable.Rows.Add(rowNew)

                        End If
                    Next
                Catch ex As Exception

                End Try

                'Cabeçalho do Relatorio
                rpt.NomeEmpresa.Text = ds.Tables("Empresa").Rows(0).Item("RazãoSocial").ToString
                rpt.periodo.Text = "Periodo de " & Me.DataInicial.Text & " a " & Me.DataFinal.Text
                rpt.Dias.Text = diasValidos

                My.Forms.ViewReport.VerRelat.Document = rpt.Document
                rpt.DataSource = myTable
                'rpt.DataMember = myTable
                rpt.Run(True)
                My.Forms.ViewReport.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message, "Sem conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If

        'Relatorio de analise de produtos vendidos feito pelo beto.
        If Me.A32.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial do periodo.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            End If
            If Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final do periodo.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            Dim rpt As New RelAnaliseSaida

            Dim conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            conn.Open()

            Try



                Dim sql As String = "SELECT ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, Produtos.Descrição, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.Desconto, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, Pedido.PedidoTipo, Produtos.DataUltimaCompra, Produtos.ValorCompra, Pedido.DataPedido AS DataVenda, Empresa.CódigoEmpresa, Empresa.RazãoSocial, [TotalProduto]-[ValorDesconto] AS ValorLiquido FROM ((Produtos INNER JOIN ItensPedido ON Produtos.CodigoProduto = ItensPedido.CodigoProduto) INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Empresa ON Pedido.Empresa = Empresa.CódigoEmpresa WHERE (((ItensPedido.CodigoProduto)=" & Me.Produto.Text & ") AND ((Pedido.DataPedido) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#));"

                Dim oDA As New OleDb.OleDbDataAdapter(sql, conn)

                Dim ds As New DataSet
                oDA.Fill(ds, "Ped")
                If ds.Tables("ped").Rows.Count = 0 Then
                    MsgBox("Não foi encontrado informações para gerar o relatório", 48, "Validação de dados")
                    conn.Close()
                    Return
                End If


                rpt.periodo.Text = "Periodo de " & Me.DataInicial.Text & " a " & Me.DataFinal.Text

                My.Forms.ViewReport.VerRelat.Document = rpt.Document
                rpt.DataSource = ds.Tables("Ped")
                rpt.Run(True)
                My.Forms.ViewReport.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message, "Sem conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If

        If Me.A33.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            Dim rpt As New RelCusto
            My.Forms.ViewReport.VerRelat.Document = rpt.Document
            rpt.Run()
            Me.Cursor = Cursors.Default
            ViewReport.ShowDialog()

        End If

        If Me.A34.Checked = True Then
            RelatorioCarregar = "RelListaPrecoMarca"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A40.Checked Or A41.Checked Then
            RelatorioCarregar = "Prod_VndMarcaGrupo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        'relatorio para valor do estoque
        If Me.A42.Checked Then
            RelatorioCarregar = "ValorEstoque.rpt"

            Dim f As New ClassView.cView
            f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados)

        End If

        'relatorio para valor do estoque
        If Me.rdb_qtd_vendida.Checked Then
            If String.IsNullOrEmpty(Me.Produto.Text) Then
                MessageBox.Show("O produto não pode ser nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf String.IsNullOrEmpty(Me.DataFinal.Text) Or String.IsNullOrEmpty(DataFinal.Text) Then
                MessageBox.Show("Este relatório precisa de período", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            RelatorioCarregar = "RelProdutosPeriodo.rpt"

            'chama a classe e passa os parametros para o relatorio
            Dim f As New ClassView.cView
            Dim strParam As String = "{comando.DataPedido}>=Date (" & Format(CDate(DataInicial.Text), "yyyy,MM,dd") & ") and {comando.DataPedido}<=date(" & Format(CDate(DataFinal.Text), "yyyy,MM,dd") & ") AND {Comando.CodigoProduto} =" & Me.Produto.Text
            f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "Relatório de Produto entre  " & DataInicial.Text & " a " & DataFinal.Text, strParam)

        End If
    End Sub

    Private Sub Grupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grupo.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            Me.Grupo.Clear()
            Me.GrupoDesc.Clear()
            ChamaTelaProcura("Codigo", "Descricão", "", "Grupos", "CódigoGrupo", "Descrição", "", True)
            Me.Grupo.Text = RetornoProcura
        End If
    End Sub

    Private Sub Grupo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grupo.Validated
        If Me.A9.Checked = False Then
            If Me.Grupo.Text <> "" Then
                Ação.Descrição_ItenRegistro(Me.Grupo, Me.GrupoDesc, "Grupos", "CódigoGrupo", Me.Grupo.Text, "Descrição", TrfGerais.TipoDados.Numérico, True)
            End If
        End If
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A5.CheckedChanged, A7.CheckedChanged, A8.CheckedChanged, A9.CheckedChanged, A20.CheckedChanged, A21.CheckedChanged, A22.CheckedChanged, A30.CheckedChanged, A31.CheckedChanged, A32.CheckedChanged, A33.CheckedChanged, A34.CheckedChanged, A40.CheckedChanged, A41.CheckedChanged, A42.CheckedChanged, rdb_qtd_vendida.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = True
            Me.Grupo.Clear()
            Me.GrupoDesc.Clear()
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.Grupo.Focus()
            Me.Label1.Text = "Informe o Grupo"
            Me.TodosGrupoLabel.Visible = True
            Me.GrupoDesc.Visible = True
        End If

        If Me.A2.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = True
            Me.PainelPeriodo.Visible = False
            Me.Produto.Focus()
        End If

        If Me.A3.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = True
            Me.PainelPeriodo.Visible = True
            Me.Produto.Focus()
        End If

        If Me.A5.Checked = True Or Me.A8.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False

        End If

        If Me.A7.Checked = True Then
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False
            Me.PainelListaPreco.Visible = True
            Me.PainelListaPreco.Location = New System.Drawing.Point(7, 282)
            Me.PainelListaPreco.Size = New System.Drawing.Point(540, 34)
            Me.ListaPrecoSelect.Focus()
        End If

        If Me.A9.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = True
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False
            CarregaLocal()
            Me.Local.Focus()
        End If



        If Me.A20.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False
        End If

        If Me.A21.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = True
            Me.PainelPeriodo.Visible = False
            Me.Produto.Focus()
        End If

        If Me.A22.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = True
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False
            Me.TodosGrupoLabel.Visible = False
            Me.Grupo.Focus()
        End If

        If Me.A30.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

        If Me.A31.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

        If Me.A32.Checked = True Or rdb_qtd_vendida.Checked Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = True
            Me.PainelPeriodo.Visible = True
            Me.Produto.Focus()
        End If

        If Me.A33.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False
        End If

        If Me.A34.Checked = True Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False
        End If
        If Me.A40.Checked Or A41.Checked Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If
        If A42.Checked Then
            Me.PainelListaPreco.Visible = False
            Me.PainelGrupo.Visible = False
            Me.PainelLocalizacao.Visible = False
            Me.PainelProduto.Visible = False
            Me.PainelPeriodo.Visible = False

        End If
    End Sub

    Private Sub CarregaLocal()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * From ProdutoLocal Where Inativo = False and Empresa = " & CodEmpresa & " order by SetorLocalDesc Desc"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")


        Me.Local.DataSource = ds.Tables("Table").DefaultView
        Me.Local.DisplayMember = "SetorLocalDesc"
        Me.Local.ValueMember = "SetorLocal"
        Me.Local.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Produto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            Me.Produto.Clear()
            Me.ProdutoDesc.Clear()
            If Me.A1.Checked = True Then TipoItensProcurar = 1
            If Me.A2.Checked = True Then TipoItensProcurar = 1
            My.Forms.ProcuraProduto.ShowDialog()

        End If
    End Sub


    Private Sub Produto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Produto.Validated
        If Me.Produto.Text <> "" Then
            Ação.Descrição_ItenRegistro(Me.Produto, Me.ProdutoDesc, "Produtos", "CodigoProduto", Me.Produto.Text, "Descrição", TrfGerais.TipoDados.Numérico, True)
        End If
    End Sub



    Private Sub btFindProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindProduto.Click
        RetornoProcura = ""
        Me.Produto.Clear()
        Me.ProdutoDesc.Clear()
        If Me.A1.Checked = True Then TipoItensProcurar = 1
        If Me.A2.Checked = True Then TipoItensProcurar = 1
        My.Forms.ProcuraProduto.ShowDialog()
        Me.Produto.Focus()
    End Sub

    
End Class