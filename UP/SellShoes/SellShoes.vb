Imports System.Math
Public Class SellShoes

    Public ImportsOrc As Boolean = False
    Public OrcNumber As Integer = 0
    Public AcharVenda As Double = False
    Public StrVenda As Integer
    Dim VarTemEntrada As Boolean = False

    Dim IT As Integer = 0

    Dim LinhaSelecionada As Integer

    'Variaveis que servem para passar informaçoes
    Dim varCustoMercadoriaVendia As Double = 0

    Public DsItens As New DataSet

    Dim RestaValorGeral As Double

    Dim P_Desc As Double
    Dim P_Acre As Double

    Dim DsReceber As New DataSet
    Dim bs As New BindingSource
    Dim DAReceber As OleDb.OleDbDataAdapter
    Dim cvend As New cVendedor

    Dim VarDesconto As Double = 0 'usado para receber o percentual que ira ser descontado na linha
    Dim VarAcrecimo As Double = 0 'usado para receber o percentual que ira ser Acrecentado na linha



    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click

        If Me.Venda.Text = "000000" And Me.xCodCliente.Text <> "" Then
            If MessageBox.Show("Deseja sair do pedido sem salvar", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub SellShoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        EncheListaTipoPgto()

        If AcharVenda = False Then
            HabilitarItens(False)

            'If Len(CaixaAtivo) <> 4 Then
            '    Me.PainelCredito.Visible = False
            'Else
            '    Me.PainelCredito.Visible = True
            '    Me.PainelFaturamento.Enabled = True
            'End If


            Me.xCodCliente.Focus()

            'Carrega a Tabela para a Memoria
            Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CN.Open()


            Dim Sql As String = "SELECT 0 AS Linha, ItensPedido.CodigoProduto, Produtos.Descrição, ItensPedido.Numero, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.vAcrecimoVenda, ItensPedido.ValorDesconto, ItensPedido.vDescontoEspecial, ItensPedido.TotalProduto, ItensPedido.CustoMercadoriaVendida, ItensPedido.DevolvidoId, ItensPedido.pAcrecimoVenda, ItensPedido.Desconto, ItensPedido.pDescontoEspecial FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=-1));"

            Try

                Dim CMD As New OleDb.OleDbCommand(Sql, CN)
                Dim DaItem As New OleDb.OleDbDataAdapter(CMD)

                DaItem.Fill(DsItens, "Itens")

                Me.Lista.DataSource = DsItens.Tables("Itens").DefaultView
                CN.Close()
            Catch ex As Exception
                CN.Close()
                MsgBox(ex.Message)
                Me.Close()
                Me.Dispose()
            End Try
            Me.ConfImg.Visible = False
            Me.DataVenda.Text = DataDia
            Me.StatusAndamento.Text = "INICIAL"
            Me.btEnviarCaixa.Enabled = True
            Me.btConcluirVenda.Enabled = False

            If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
                ItensDevolução()
                Me.DevNumero.Visible = True
                Me.LabelDevNumero.Visible = True
                PegaDadosPedidoDevolucao(Me.DevNumero.Text)
                Me.TipoPgto.Enabled = False
                Me.CodPgto.Enabled = False
                Me.Contrato.Enabled = False
            Else
                Me.DevNumero.Visible = False
                Me.LabelDevNumero.Visible = False
            End If

            If ImportsOrc = True Then
                'OrcNumber = Variavel que contem o numero do orçamento
                'My.Forms.SellShoesOrcamento.Close()
                'My.Forms.SellShoesOrcamento.Dispose()

                ImportarOrcamento(OrcNumber)

            End If

        End If


        If AcharVenda = True Then
            Me.PainelCliente.Enabled = False
            Me.PainelItens.Enabled = False
            Me.PainelTotal.Enabled = False
            Me.PainelFaturamento.Enabled = False
            Me.btEnviarCaixa.Enabled = False
            Me.btConcluirVenda.Enabled = True
            Me.CodPgto.Enabled = False
            Me.TipoPgto.Enabled = False

            LocalizarVenda(StrVenda)

            If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
                Me.DevNumero.Visible = True
                Me.LabelDevNumero.Visible = True
                Me.ValorFaturar.Enabled = False
                Me.ValorCheque.Enabled = False
                Me.FormaPgto.Enabled = False
            Else
                Me.DevNumero.Visible = False
                Me.LabelDevNumero.Visible = False
            End If

            If Len(CaixaAtivo) <> 4 Then
                Me.PainelCredito.Visible = False
            Else
                Me.PainelCredito.Visible = True
                'Me.PainelFaturamento.Enabled = True
            End If


        End If

        Me.xCodCliente.Focus()
    End Sub

    Private Sub ImportarOrcamento(ByVal CodOrc As Integer)

        Dim dsV As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CN.Open()

        Dim Sql As String = String.Empty

        Sql = "SELECT Orc.*, Clientes.*, Municipio.NomeMunic, UF.NomeUF, Funcionários.Nome, FormaPgto.Descrição FROM ((Orc INNER JOIN ((Clientes LEFT JOIN UF ON Clientes.cUF = UF.CodigoUF) LEFT JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio) ON Orc.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Orc.CódigoFuncionário = Funcionários.CódigoFuncionário) LEFT JOIN FormaPgto ON Orc.FormaPgto = FormaPgto.CodFormaPgto WHERE (((Orc.OrcSequencia)=" & codorc & ") AND ((Orc.Inativo)=False) AND ((Orc.Empresa)=" & CodEmpresa & "));"
        Dim DaVenda As New OleDb.OleDbDataAdapter(Sql, CN)

        Sql = "SELECT 0 AS Linha, OrcITEM.CodigoProduto, Produtos.Descrição, OrcITEM.Numero, OrcITEM.Qtd, OrcITEM.ValorUnitario, OrcITEM.vAcrecimoVenda, OrcITEM.Desconto, OrcITEM.ValorDesconto, OrcITEM.vDescontoEspecial, OrcITEM.TotalProduto, OrcITEM.CustoMercadoriaVendida, OrcITEM.pAcrecimoVenda, OrcITEM.pDescontoEspecial FROM OrcITEM INNER JOIN Produtos ON OrcITEM.CodigoProduto = Produtos.CodigoProduto WHERE (((OrcITEM.OrcSequencia)=" & CodOrc & "));"
        Dim DaItem As New OleDb.OleDbDataAdapter(Sql, CN)

        DaVenda.Fill(dsV, "Orc")
        DaItem.Fill(dsV, "Itens")


        If dsV.Tables("Orc").Rows.Count > 0 Then
            Me.xCodCliente.Text = dsV.Tables("Orc").Rows(0)("Codigo").ToString
            Me.xNome.Text = dsV.Tables("Orc").Rows(0)("Clientes.Nome").ToString
            Me.xCpfCnpj.Text = dsV.Tables("Orc").Rows(0)("CpfCgc").ToString
            Me.xEndereco.Text = dsV.Tables("Orc").Rows(0)("Endereço").ToString
            Me.xBairro.Text = dsV.Tables("Orc").Rows(0)("Bairro").ToString
            Me.xCidadeEstado.Text = dsV.Tables("Orc").Rows(0)("Cidade").ToString & "-" & dsV.Tables("Orc").Rows(0)("NomeUF").ToString
            Me.xLimiteCredito.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("LimiteMensal").ToString), 2)
            Me.VendaVista.Checked = dsV.Tables("Orc").Rows(0)("VendaVista").ToString
            Me.VendaCheque.Checked = dsV.Tables("Orc").Rows(0)("VendaCheque").ToString
            Me.VendaCrediario.Checked = dsV.Tables("Orc").Rows(0)("VendaCrediario").ToString
            Me.DataVenda.Text = DataDia  'dsV.Tables("Orc").Rows(0)("DataOrc").ToString
            Me.Vendedor.Text = dsV.Tables("Orc").Rows(0)("CódigoFuncionário").ToString & "-" & dsV.Tables("Orc").Rows(0)("Funcionários.Nome").ToString
            Me.DescPercentual.Text = NzZero(dsV.Tables("Orc").Rows(0)("PercDesconto").ToString)
            Me.TotalDesconto.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("VlrDescProduto").ToString), 2)
            Me.ValorProduto.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("ValorProduto").ToString), 2)
            Me.TotalPedido.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("TotalOrc").ToString), 2)
            Me.ValorVista.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("ValorAVista").ToString), 2)
            Me.ValorCheque.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("ValorOutros").ToString), 2)
            Me.ValorFaturar.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("ValorAFaturar").ToString), 2)
            Me.FormaPgto.Text = dsV.Tables("Orc").Rows(0)("FormaPgto").ToString
            Me.DiasParcelamento.Text = dsV.Tables("Orc").Rows(0)("DiasParcelamento").ToString
            Me.Confirmado.Checked = dsV.Tables("Orc").Rows(0)("Confirmado").ToString
            Me.PedidoTipo.Text = "VENDA"
            Me.lblOperador.Text = dsV.Tables("Orc").Rows(0)("OrcOperador").ToString
            Me.EnderecoEntrega.Text = dsV.Tables("Orc").Rows(0)("EnderecoEntrega").ToString
        End If

        'Adiciona os Itens
        Dim DrLinha As DataRow
        For Each DrLinha In dsV.Tables("Itens").Rows 'DsItens.Tables("Itens").Rows

            Dim TBL As DataTable
            TBL = DsItens.Tables("Itens")

            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()
            IT += 1
            DRnovo("Linha") = IT
            DRnovo("CodigoProduto") = DrLinha("CodigoProduto")
            DRnovo("Descrição") = DrLinha("Descrição")
            DRnovo("Numero") = DrLinha("Numero")
            DRnovo("Qtd") = DrLinha("Qtd")
            DRnovo("ValorUnitario") = DrLinha("ValorUnitario")
            DRnovo("Desconto") = DrLinha("Desconto")
            DRnovo("ValorDesconto") = DrLinha("ValorDesconto")
            DRnovo("TotalProduto") = DrLinha("TotalProduto")
            DRnovo("CustoMercadoriaVendida") = DrLinha("CustoMercadoriaVendida")

            DRnovo("vAcrecimoVenda") = DrLinha("vAcrecimoVenda")
            DRnovo("pAcrecimoVenda") = DrLinha("pAcrecimoVenda")
            DRnovo("pDescontoEspecial") = DrLinha("pDescontoEspecial")
            DRnovo("vDescontoEspecial") = DrLinha("vDescontoEspecial")

            TBL.Rows.Add(DRnovo)

        Next

        'Me.Lista.DataSource = dsV.Tables("Itens").DefaultView
        Me.Lista.DataSource = DsItens.Tables("Itens").DefaultView

        Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
        Me.Acrecimo.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)
        Dim DescEspecial As Double = NzZero(DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
        Dim DescNormal As Double = NzZero(DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
        Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)
        Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)

        CarregaLocalPgto()
        'Fim do Carregamento do recebimento
        VerificaLimiteCredito()
        EncheListaContrato()


        Me.Contrato.SelectedValue = dsV.Tables("Orc").Rows(0)("Contrato").ToString & ""
        'PegarContaContrato()
        Me.TipoPgto.SelectedValue = dsV.Tables("Orc").Rows(0)("TipoPgto").ToString
        EncheListaTipoPgto()
        EncheCodPgto()
        Me.CodPgto.SelectedValue = dsV.Tables("Orc").Rows(0)("CodPgto").ToString


        CN.Close()

        Me.CodBarra.Focus()

    End Sub


    'Private Sub PegarContaContrato()

    '    Me.ContaCR.Text = VAR_ContaCrVenda
    '    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    '    Dim Sql As String = "SELECT Contratos.CodContrato, Contratos.ContaCR FROM Contratos WHERE Contratos.CodContrato = '" & Me.Contrato.SelectedValue & "'"

    '    Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
    '    Dim ds As New DataSet
    '    da.Fill(ds, "Table")

    '    If ds.Tables("Table").Rows.Count > 0 Then
    '        Me.ContaCR.Text = ds.Tables("Table").Rows(0)("ContaCr")
    '    End If

    '    ds.Dispose()
    '    Cnn.Close()

    'End Sub

    Private Sub PegaDadosPedidoDevolucao(ByVal PedidoDevolver As Integer)

        If PedidoDevolver = 0 Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Pedido Where PedidoSequencia = " & PedidoDevolver
        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then

                If Not IsDBNull(DR.Item("Contrato")) Then
                    Me.Contrato.Text = DR.Item("Contrato")
                    EncheListaTipoPgto()
                End If
                cvend.AchaVendedor(DR.Item("CódigoFuncionário"))
                Me.Vendedor.Text = cvend.codigovendedor & "-" & cvend.nomevendedor
                Me.TipoPgto.SelectedValue = DR.Item("TipoPgto") & ""
                EncheCodPgto()
                Me.CodPgto.SelectedValue = DR.Item("CodPgto") & ""
            End If
            DR.Close()
            CNN.Close()


        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
        End Try

    End Sub

    Private Sub ItensDevolução()

        Dim TBL As DataTable
        TBL = DsItens.Tables("Itens")

        For Each Linha As DataGridViewRow In My.Forms.SellShoesDevolucao.ListaItens.Rows
            If Linha.Cells("Selecionado").Value = True Then
                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()
                IT += 1
                DRnovo("Linha") = IT
                DRnovo("CodigoProduto") = Linha.Cells("cCodigoProduto").Value
                DRnovo("Descrição") = Linha.Cells("cDescrição").Value
                DRnovo("Numero") = Linha.Cells("cNumero").Value
                DRnovo("Qtd") = Linha.Cells("cQDevolver").Value
                DRnovo("ValorUnitario") = Linha.Cells("cValorUnitario").Value
                DRnovo("Desconto") = Linha.Cells("cDesconto").Value
                DRnovo("ValorDesconto") = (Linha.Cells("cValorDesconto").Value / Linha.Cells("cQtd").Value) * Linha.Cells("cQDevolver").Value

                DRnovo("vAcrecimoVenda") = (NzZero(Linha.Cells("cAcrecimo").Value) / NzZero(Linha.Cells("cQtd").Value)) * NzZero(Linha.Cells("cQDevolver").Value)
                DRnovo("pAcrecimoVenda") = (NzZero(Linha.Cells("cpAcrecimo").Value) / NzZero(Linha.Cells("cQtd").Value)) * NzZero(Linha.Cells("cQDevolver").Value)
                DRnovo("pDescontoEspecial") = (NzZero(Linha.Cells("cpEspecial").Value) / NzZero(Linha.Cells("cQtd").Value)) * NzZero(Linha.Cells("cQDevolver").Value)
                DRnovo("vDescontoEspecial") = (NzZero(Linha.Cells("cEspecial").Value) / NzZero(Linha.Cells("cQtd").Value)) * NzZero(Linha.Cells("cQDevolver").Value)

                DRnovo("TotalProduto") = (CDbl(NzZero(Linha.Cells("cValorUnitario").Value)) * CDbl(NzZero(Linha.Cells("cQDevolver").Value))) * -1
                DRnovo("CustoMercadoriaVendida") = CDbl(NzZero(Linha.Cells("cCustoMercadoriaVendida").Value)) * -1
                DRnovo("DevolvidoId") = CDbl(Linha.Cells("cId").Value)
                TBL.Rows.Add(DRnovo)
            End If

        Next

        'Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)


        Me.ValorProduto.Text = SomaColuna("cTotalProduto")
        Me.Acrecimo.Text = SomaColuna("cAcrecimo") * -1

        Dim DescEspecial As Double = SomaColuna("cEspecial")
        Dim DescNormal As Double = SomaColuna("cValorDesconto")
        Me.TotalDesconto.Text = FormatNumber((NzZero(DescNormal) + NzZero(DescEspecial)) * -1, 2)

        Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)


        Me.Lista.Refresh()
        Me.CodBarra.Enabled = False

    End Sub

#Region "Rotinas de Find"


    Public Sub LocalizaCliente(ByVal CodCliente As Integer)

        If CodCliente = 0 Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Clientes.*, Clientes.Empresa, Municipio.NomeMunic, UF.NomeUF FROM (Clientes LEFT JOIN UF ON Clientes.cUF = UF.CodigoUF) LEFT JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio WHERE (((Clientes.Empresa)=" & CodEmpresa & ") AND ((Clientes.Codigo)=" & CodCliente & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            If DR.Item("Inativo") = True Then
                MessageBox.Show("Este cliente foi Inativado, não é permitido nenhum tipo de venda para ele, verifique com o Administrador", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.xCodCliente.Clear()
                Me.xCodCliente.Focus()
                Exit Sub
            End If

            Me.xCodCliente.Text = DR.Item("Codigo") & ""
            Me.xNome.Text = DR.Item("Nome") & ""
            Me.xCpfCnpj.Text = DR.Item("CpfCgc") & ""
            Me.xEndereco.Text = DR.Item("Endereço") & ""
            Me.xBairro.Text = DR.Item("Bairro") & ""
            Me.xCidadeEstado.Text = DR.Item("Cidade") & "-" & DR.Item("NomeUF")
            Me.xLimiteCredito.Text = FormatNumber(DR.Item("LimiteMensal"), 2)
            Me.VendaVista.Checked = DR.Item("VendaVista")
            Me.VendaCheque.Checked = DR.Item("VendaCheque")
            Me.VendaCrediario.Checked = DR.Item("VendaCrediario")

            If Me.VendaCheque.Checked = False Then
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.ValorCheque.Enabled = False
            Else
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.ValorCheque.Enabled = False
            End If

            If Me.VendaCrediario.Checked = False Then
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Enabled = False
                Me.FormaPgto.Enabled = False
            Else
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Enabled = True
                Me.FormaPgto.Enabled = True

            End If

            Me.Bloqueado.Checked = DR.Item("Bloqueado")
            If DR.Item("Bloqueado") = True Then
                MessageBox.Show("Este cliente foi bloqueado, verifique com o Administrador ou venda somente a vista", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.ValorCheque.Enabled = False
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Enabled = False
                Me.FormaPgto.Enabled = False
            End If

            VerificaLimiteCredito()
            EncheListaContrato()
            Me.TipoPgto.Focus()
        Else
            MessageBox.Show("Este cliente não consta no cadastro, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.xCodCliente.Clear()
            Me.xCodCliente.Focus()
            Exit Sub
        End If
        DR.Close()

    End Sub

    Private Sub VerificaLimiteCredito()
        VerDebitoCliente()
        Me.xLimiteSaldo.Text = FormatNumber(CDbl(NzZero(Me.xLimiteCredito.Text)) - CDbl(NzZero(Me.xLimiteUtilizado.Text)), 2)
    End Sub


    Private Sub LocalizaProdutoCodBarra(ByVal IdProduto As Integer, ByVal IdNumero As String)

        If NzZero(IdProduto) = 0 Then Exit Sub : If IdNumero = "" Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Produtos.*, ProdutoGrade.Numero, ProdutoGrade.QtdEst FROM Produtos INNER JOIN ProdutoGrade ON Produtos.CodigoProduto = ProdutoGrade.Produto WHERE Produtos.CodigoProduto = " & IdProduto & "  AND ProdutoGrade.Numero ='" & IdNumero & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        varCustoMercadoriaVendia = 0

        If DR.HasRows Then
            Me.CodProduto.Text = DR.Item("CodigoProduto") & ""
            Me.Descricao.Text = DR.Item("Descrição") & ""
            Me.Numero.Text = DR.Item("Numero") & ""
            Me.Qtd.Text = FormatNumber(1, 4)

            If VenderEstoqueNegativo = False Then
                If DR.Item("ControlaEstoque") = "SIM" Then
                    If Me.PedidoTipo.Text = "VENDA" Then
                        If CDbl(NzZero(DR.Item("QtdEst"))) < CDbl(NzZero(Me.Qtd.Text)) Then
                            MessageBox.Show(" Este Produto não possui quantidade suficiente para venda, favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            CNN.Close()
                            Me.CodBarra.Clear()
                            Me.CodBarra.Focus()
                            Exit Sub
                        End If
                    End If
                End If
            End If

            Me.Unitario.Text = FormatNumber(NzZero(DR.Item("ValorVenda")), 2)

            Me.ValorDesconto.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarDesconto) / 100
            Me.vAcrecimo.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarAcrecimo) / 100
            Dim tTotal As Double = (NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text)) + NzZero(Me.vAcrecimo.Text) - NzZero(Me.ValorDesconto.Text)
            Me.Total.Text = FormatNumber(tTotal, 2)

            varCustoMercadoriaVendia = FormatNumber(NzZero(DR.Item("ValorCompra")), 2)

            If Var_EnterCodBarra = True Then
                AddItem()
                Me.CodBarra.Clear()
                Me.CodBarra.Focus()
            Else
                Me.Qtd.Enabled = True
                Me.Unitario.Enabled = True
                Me.btSalvarItem.Enabled = True
                DR.Close()
                CNN.Close()
                Me.Qtd.Focus()
            End If

            DR.Close()
            CNN.Close()

        Else
            DR.Close()
            CNN.Close()
            MessageBox.Show("Produto não encontrado, Verifique ou selecione outro", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodProduto.Clear()
            Me.Descricao.Clear()
            Me.Numero.Clear()
            Me.Qtd.Clear()
            Me.Unitario.Clear()
            Me.ValorDesconto.Clear()
            Me.Total.Clear()
            Me.CodBarra.Clear()
            Me.CodBarra.Focus()
        End If
    End Sub

    Private Sub LocalizaProdutoCodBarraSemNumeros(ByVal IdProduto As Integer)

        If NzZero(IdProduto) = 0 Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Produtos.* FROM Produtos WHERE Produtos.Inativo=False And Produtos.CodigoBarra = '" & IdProduto & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        varCustoMercadoriaVendia = 0

        Dim AchouItem As Boolean = False
        If DR.HasRows Then
            AchouItem = True
            Me.CodProduto.Text = DR.Item("CodigoProduto") & ""
            Me.Descricao.Text = DR.Item("Descrição") & ""
            Me.Numero.Text = 0
            Me.Qtd.Text = FormatNumber(1, 4)

            If VenderEstoqueNegativo = False Then
                If DR.Item("ControlaEstoque") = "SIM" Then
                    If Me.PedidoTipo.Text = "VENDA" Then
                        If CDbl(NzZero(DR.Item("QuantidadeEstoque"))) < CDbl(NzZero(Me.Qtd.Text)) Then
                            MessageBox.Show(" Este Produto não possui quantidade suficiente para venda, favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            CNN.Close()
                            Me.CodBarra.Clear()
                            Me.CodBarra.Focus()
                            Exit Sub
                        End If
                    End If
                End If
            End If

            Me.Unitario.Text = FormatNumber(NzZero(DR.Item("ValorVenda")), 2)

            Me.ValorDesconto.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarDesconto) / 100
            Me.vAcrecimo.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarAcrecimo) / 100
            Dim tTotal As Double = (NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text)) + NzZero(Me.vAcrecimo.Text) - NzZero(Me.ValorDesconto.Text)
            Me.Total.Text = FormatNumber(tTotal, 2)

            varCustoMercadoriaVendia = FormatNumber(NzZero(DR.Item("ValorCompra")), 2)

            If Var_EnterCodBarra = True Then
                AddItem()
            Else
                Me.Qtd.Enabled = True
                Me.Unitario.Enabled = True
                Me.btSalvarItem.Enabled = True
                DR.Close()
                CNN.Close()

                If AchouItem = True Then
                    Me.Qtd.Focus()
                End If

            End If

            DR.Close()
            CNN.Close()

        Else
            DR.Close()
            CNN.Close()
            MessageBox.Show("Produto não encontrado, Verifique ou selecione outro", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodProduto.Clear()
            Me.Descricao.Clear()
            Me.Numero.Clear()
            Me.Qtd.Clear()
            Me.Unitario.Clear()
            Me.ValorDesconto.Clear()
            Me.Total.Clear()
            Me.CodBarra.Clear()
            Me.CodBarra.Focus()
        End If
    End Sub


#End Region

    Private Sub HabilitarItens(ByVal SimNao As Boolean)
        Me.CodProduto.Enabled = SimNao
        Me.Descricao.Enabled = SimNao
        Me.Numero.Enabled = SimNao
        Me.Qtd.Enabled = SimNao
        Me.Unitario.Enabled = SimNao
        Me.ValorDesconto.Enabled = SimNao
        Me.vAcrecimo.Enabled = SimNao
        Me.vDescontoEspecial.Enabled = SimNao
        Me.Total.Enabled = SimNao
        Me.btSalvarItem.Enabled = SimNao
    End Sub

    Private Sub btFindCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCliente.Click
        My.Forms.ClientesProcura.ShowDialog()

        If String.CompareOrdinal(Me.xCodCliente.Text, Me.xCodCliente.TextLength) Then
            If Me.xCodCliente.Text = "" Then Exit Sub
            LocalizaCliente(Me.xCodCliente.Text)
        End If
    End Sub

    Private Sub xCodCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles xCodCliente.KeyDown

        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()

            If String.CompareOrdinal(Me.xCodCliente.Text, Me.xCodCliente.TextLength) Then
                If Me.xCodCliente.Text = "" Then Exit Sub
                LocalizaCliente(Me.xCodCliente.Text)
            End If
        End If
    End Sub

    Private Sub xCodCliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xCodCliente.Validating
        Try
            If AcharVenda = False Then
                If Me.xCodCliente.Text = "" Then Exit Sub
                If String.CompareOrdinal(Me.xCodCliente.Text, Me.xCodCliente.TextoAntigo) Then
                    LocalizaCliente(Me.xCodCliente.Text)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SellShoes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            If Me.xCodCliente.Text = "" Then
                MessageBox.Show("Primeiro o usuário deve definir o Cliente, para lançar os Produtos", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.xCodCliente.Focus()
                Exit Sub
            End If
            HabilitarItens(False)
            Me.CodBarra.Enabled = True
            Me.CodBarra.Focus()
        End If


        If e.KeyCode = Keys.F7 Then
            btEnderecoEntrega_Click(sender, e)
        End If


        Dim isControlPressed As Boolean = (Control.ModifierKeys And Keys.Control) <> 0
        If isControlPressed = True Then
            If Me.Lista.RowCount > 0 Then
                If e.KeyCode = Keys.D Then
                    If Me.PedidoTipo.Text <> "DEVOLUÇÃO" Then
                        e.Handled = True
                        Me.CodBarra.Focus()
                        Dim frmDesconto As New SellShoesDescontoGerencia
                        frmDesconto.Individual = False
                        'frmDesconto.idITEM = LinhaSelecionada
                        frmDesconto.ShowDialog()
                        Me.TotalPedido.Focus()
                    End If
                End If
            End If
        End If

        'If e.KeyCode = Keys.F2 Then
        '    If Me.xCodCliente.Text = "" Then
        '        MessageBox.Show("Primeiro o usuário deve definir o Cliente, para lançar os Produtos", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.xCodCliente.Focus()
        '        Exit Sub
        '    End If
        '    HabilitarItens(True)
        '    Me.CodBarra.Enabled = False
        '    Me.CodProduto.Focus()
        'End If
    End Sub

    Private Sub CodBarra_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodBarra.Enter
        If Me.xCodCliente.Text = "" Then
            Me.xCodCliente.Focus()
            Exit Sub
        End If
        Me.CodBarra.Clear()
        Me.CodProduto.Clear()
        Me.Descricao.Clear()
        Me.Numero.Clear()
        Me.Qtd.Clear()
        Me.Unitario.Clear()
        Me.vAcrecimo.Clear()
        Me.ValorDesconto.Clear()
        Me.vDescontoEspecial.Clear()
        Me.Total.Clear()
    End Sub

    Private Sub AddItem()

        If Me.CodProduto.Text = "" Then
            Me.CodBarra.Focus()
            Exit Sub
        End If

        If NzZero(Me.Unitario.Text) = 0 Then
            MessageBox.Show("O Valor do produto não pode ser [0,00], verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodBarra.Focus()
            Exit Sub
        End If

        Dim DrFindProduto() As DataRow
        If UsarGrade = False Then
            DrFindProduto = DsItens.Tables("Itens").Select("CodigoProduto = '" & Me.CodProduto.Text & "'")
        Else
            DrFindProduto = DsItens.Tables("Itens").Select("CodigoProduto = '" & Me.CodProduto.Text & "' and Numero = '" & Me.Numero.Text & "'")
        End If

        If DrFindProduto.Length = 0 Then

            Dim TBL As DataTable
            TBL = DsItens.Tables("Itens")

            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()
            IT += 1
            DRnovo("Linha") = IT
            DRnovo("CodigoProduto") = Me.CodProduto.Text
            DRnovo("Descrição") = Me.Descricao.Text
            DRnovo("Numero") = Me.Numero.Text
            DRnovo("Qtd") = Me.Qtd.Text
            DRnovo("ValorUnitario") = FormatNumber(Me.Unitario.Text, 2)
            DRnovo("vAcrecimoVenda") = FormatNumber(Me.vAcrecimo.Text, 2)
            DRnovo("ValorDesconto") = FormatNumber(Me.ValorDesconto.Text, 2)
            DRnovo("TotalProduto") = FormatNumber(Me.Total.Text, 2)
            DRnovo("CustoMercadoriaVendida") = FormatNumber(varCustoMercadoriaVendia, 2)
            DRnovo("Desconto") = FormatNumber(NzZero(VarDesconto), 2)
            DRnovo("pAcrecimoVenda") = FormatNumber(NzZero(VarAcrecimo), 2)
            DRnovo("pDescontoEspecial") = FormatNumber(0, 2)
            DRnovo("vDescontoEspecial") = FormatNumber(0, 2)

            TBL.Rows.Add(DRnovo)
        Else

            DrFindProduto(0).BeginEdit()
            DrFindProduto(0)("Qtd") += NzZero(Me.Qtd.Text)
            DrFindProduto(0)("ValorUnitario") = FormatNumber(Me.Unitario.Text, 2)
            DrFindProduto(0)("vAcrecimoVenda") = FormatNumber(((CDbl(NzZero(DrFindProduto(0)("Qtd"))) * CDbl(NzZero(DrFindProduto(0)("ValorUnitario")))) * VarAcrecimo) / 100, 2)
            DrFindProduto(0)("ValorDesconto") = FormatNumber(((CDbl(NzZero(DrFindProduto(0)("Qtd"))) * CDbl(NzZero(DrFindProduto(0)("ValorUnitario")))) * VarDesconto) / 100, 2)
            DrFindProduto(0)("TotalProduto") = FormatNumber(CDbl(NzZero(DrFindProduto(0)("Qtd"))) * CDbl(NzZero(DrFindProduto(0)("ValorUnitario"))), 2)

            DrFindProduto(0)("Desconto") = FormatNumber(NzZero(VarDesconto), 2)
            DrFindProduto(0)("pAcrecimoVenda") = FormatNumber(NzZero(VarAcrecimo), 2)
            DrFindProduto(0)("pDescontoEspecial") = FormatNumber(0, 2)
            DrFindProduto(0)("vDescontoEspecial") = FormatNumber(0, 2)


            DrFindProduto(0).EndEdit()

        End If

        'Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
        'Me.Acrecimo.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)

        'Dim DescEspecial As Double = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", "")), 2)
        'Dim DescNormal As Double = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(ValorDesconto)", "")), 2)
        'Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

        'Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)


        Me.ValorProduto.Text = SomaColuna("cTotalProduto")
        Me.Acrecimo.Text = SomaColuna("cAcrecimo")

        Dim DescEspecial As Double = SomaColuna("cEspecial")
        Dim DescNormal As Double = SomaColuna("cValorDesconto")
        Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

        Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)

        Me.Lista.Refresh()

        'Limpa Caixas para um novo Item
        Me.CodProduto.Clear()
        Me.Descricao.Clear()
        Me.Numero.Clear()
        Me.Qtd.Clear()
        Me.Unitario.Clear()
        Me.ValorDesconto.Clear()
        Me.Total.Clear()
        Me.CodBarra.Clear()
        Me.CodBarra.Focus()

        'Fim

    End Sub


    Public Function SomaColuna(ByVal Coluna As String)
        Dim vlr As Decimal

        For Each col As DataGridViewRow In Me.Lista.Rows
            vlr += col.Cells(Coluna).Value
        Next
        Return FormatNumber(NzZero(vlr), 2)
    End Function

    Private Sub btSalvarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarItem.Click
        AddItem()
    End Sub

    Private Sub CodBarra_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodBarra.Leave


        If Me.CodBarra.Text = "" Then
            If Me.Lista.RowCount > 0 Then
                Me.TotalPedido.Focus()
            End If
        End If

        Try
            If UsarGrade = True Then
                Dim VarCod As String = Me.CodBarra.Text
                Dim VarCodSplit() As String

                If VarCod.IndexOf("-") = -1 Then
                    MessageBox.Show("Não existe indexador de numero para este codigo de Produto, ação sera cancelada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.CodBarra.Clear()
                    Me.CodBarra.Focus()
                    Exit Sub
                End If

                VarCodSplit = VarCod.Split("-")

                LocalizaProdutoCodBarra(VarCodSplit(0), VarCodSplit(1))
            Else
                LocalizaProdutoCodBarraSemNumeros(CInt(Me.CodBarra.Text))
            End If
        Catch ex As Exception
            Select Case Err.Number
                Case 13
                    MsgBox("Erro de conversão, era esperado o código do produto", MsgBoxStyle.Critical, "Erro")

            End Select
            Me.CodBarra.Clear()
            Me.CodBarra.Focus()
        End Try


        'If Var_EnterCodBarra = True Then
        '    Me.CodBarra.Clear()
        '    Me.CodBarra.Focus()
        'Else
        '    Me.Qtd.Focus()
        'End If

    End Sub

    Private Sub CodProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodProduto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.CodProduto.Text = "" Then
                If Me.Lista.RowCount > 0 Then
                    HabilitarItens(False)
                    Me.DescPercentual.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub DescPercentual_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DescPercentual.Enter
        If NzZero(Me.ValorProduto.Text) = 0 Then
            MessageBox.Show("O Total da Venda não pode ser [00,00], para informar desconto", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodBarra.Focus()
            Exit Sub
        End If
        If Me.DescPercentual.Text = "" Then
            Me.DescPercentual.Text = FormatNumber(0, 4)
        End If
    End Sub

    Private Sub ValorVista_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorVista.Enter
        'Verificação dos Calculos do total da venda

        If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
            Me.ValorVista.Enabled = False
        Else
            Me.ValorVista.Enabled = True
        End If

        Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)

        If NzZero(Me.TotalPedido.Text) = 0 Then
            'MessageBox.Show("Não existe valor para faturamento, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Exit Sub
        Else
            'If NzZero(Me.ValorVista.Text) = 0 Then
            Me.ValorVista.Text = FormatNumber(NzZero(Me.TotalPedido.Text) - NzZero(Me.ValorCheque.Text) - NzZero(Me.ValorFaturar.Text), 2)
            'End If
        End If
    End Sub

    Private Sub ValorCheque_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorCheque.Enter
        If NzZero(Me.TotalPedido.Text) = 0 Then
            MessageBox.Show("Não existe valor para faturamento, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.ValorCheque.Text = FormatNumber(NzZero(Me.TotalPedido.Text) - NzZero(Me.ValorVista.Text) - NzZero(Me.ValorFaturar.Text), 2)

    End Sub

    Private Sub ValorFaturar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorFaturar.Enter
        If NzZero(Me.TotalPedido.Text) = 0 Then
            MessageBox.Show("Não existe valor para faturamento, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Me.ValorFaturar.Text = FormatNumber(NzZero(Me.TotalPedido.Text) - NzZero(Me.ValorCheque.Text) - NzZero(Me.ValorVista.Text), 2)
        If Me.VendaCrediario.Checked = False And NzZero(Me.ValorFaturar.Text) > 0 Then
            MessageBox.Show("Este Cliente não tem permissão para fazer venda no crediário, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Focus()
        End If

        If Me.Contrato.Text = "" Then
            If Me.VendaCrediario.Checked = True And NzZero(Me.ValorFaturar.Text) > CDbl(NzZero(Me.xLimiteSaldo.Text)) Then
                MessageBox.Show("Este Cliente não tem Saldo suficiente para o Faturamento no crediário, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorVista.Focus()
            End If
        End If

        If Me.ValorVista.Enabled = True And Me.ValorVista.Text = 0 Then
            MessageBox.Show("A Forma de Pagamento selecionada necessita de um valor de Entrada, Verifique...", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ValorVista.Focus()
            Exit Sub
        End If

    End Sub

   
    Private Sub ValorFaturar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorFaturar.Leave

        Dim ConferirValores As Double = FormatNumber(CDbl(NzZero(Me.ValorVista.Text)) + CDbl(NzZero(Me.ValorCheque.Text)) + CDbl(NzZero(Me.ValorFaturar.Text)), 2)

        If NzZero(ConferirValores) <> (NzZero(Me.TotalPedido.Text)) Then
            MessageBox.Show("Os Valores indicado estão diferente do Valor da Venda, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorVista.Focus()
            Exit Sub
        End If

        If NzZero(Me.ValorFaturar.Text) = 0 Then
            Me.FormaPgto.Enabled = False
        Else
            Me.FormaPgto.Enabled = True
        End If

        If Me.Contrato.Text <> "" Then
            Exit Sub
        End If

        If NzZero(Me.ValorFaturar.Text) <> 0 Then

            If Me.TipoPgto.Text = "" Then
                MessageBox.Show("Para faturamento o usuário deve selecionar um tipo de pagamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.TipoPgto.Focus()
                Exit Sub
            End If

            If Me.CodPgto.Text = "" Then
                MessageBox.Show("Para faturamento o usuário deve selecionar a condição de pagamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CodPgto.Focus()
                Exit Sub
            End If


            DsReceber.Clear()
            If DsReceber.Tables.Contains("Receber") Then DsReceber.Tables.Remove("Receber")
            CarregaLocalPgto()

            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            Dim CmdAPrazo As New OleDb.OleDbCommand

            Dim Sql As String = String.Empty
            Sql = "SELECT * from Receber Where Id  = -1"

            CmdAPrazo.Connection = Cnn
            CmdAPrazo.CommandText = Sql

            DAReceber = New OleDb.OleDbDataAdapter(CmdAPrazo)
            DAReceber.Fill(DsReceber, "Receber")

            Dim Parcelas() As String

            If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
                Parcelas = {"005"}
            Else
                Parcelas = Split(Me.DiasParcelamento.Text, "-")
            End If

            Dim Contar As Integer
            Dim Dividido As Decimal

            Dim Func() As String = CType(Me.Vendedor.Text, String).Split("-")

            Dividido = Me.ValorFaturar.Text / Parcelas.Length

            

            For Contar = 1 To Parcelas.Length
                Dim DrNew As DataRow
                DrNew = DsReceber.Tables("Receber").NewRow

                Dim Parc As String = String.Empty
                If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
                    Parc = "DEV" & "@@" & "-" & Contar & "/" & Parcelas.Length
                Else
                    Parc = "@@" & "-" & Contar & "/" & Parcelas.Length
                End If

                DrNew("Documento") = Parc
                DrNew("DataDocumento") = Me.DataVenda.Text
                DrNew("ValorDocumento") = Dividido
                DrNew("LocalPgto") = "CARTEIRA"
                DrNew("PedidoProdutos") = Me.Venda.Text
                DrNew("CodCliente") = Me.xCodCliente.Text
                DrNew("Cliente") = Me.xNome.Text
                DrNew("Empresa") = CodEmpresa
                DrNew("OriginalParcial") = "O"
                DrNew("Vendedor") = Func(0)
                DrNew("Vencimento") = CDate(Me.DataVenda.Text).AddDays(CInt(Parcelas(Contar - 1)))
                DrNew("VencimentoOriginal") = CDate(Me.DataVenda.Text).AddDays(CInt(Parcelas(Contar - 1)))
                DrNew("MediaDescontoPedido") = 0
                DrNew("PercentComissao") = 0
                DrNew("ControlePedido") = 0
                DrNew("ContaValorBaixado") = Nz(CodLancamentoReceber, 1)
                DrNew("Virtual") = True
                DsReceber.Tables("Receber").Rows.Add(DrNew)

            Next

            bs.DataSource = DsReceber.Tables("Receber")
            Me.ListaReceber.DataSource = bs


            If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
                Me.ListaReceber.Enabled = False
            Else
                Me.ListaReceber.Enabled = True
            End If

            Me.btEnviarCaixa.Focus()

        Else
            'Me.Parcelado.Text = FormatNumber(0, 2)
        End If


    End Sub

    Private Sub ListaReceber_DrawItem(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs) Handles ListaReceber.DrawItem

        Dim currItem As DataRowView = bs.Item(e.DataRepeaterItem.ItemIndex)

        DirectCast(e.DataRepeaterItem.Controls("txtDocumento"), TextBox).Text = currItem.Item("Documento")
        DirectCast(e.DataRepeaterItem.Controls("txtVencimento"), TextBox).Text = currItem.Item("Vencimento")
        DirectCast(e.DataRepeaterItem.Controls("VencimentoOriginal"), TextBox).Text = currItem.Item("VencimentoOriginal")
        DirectCast(e.DataRepeaterItem.Controls("txtValor"), TextBox).Text = FormatNumber(currItem.Item("ValorDocumento"), 2)
        DirectCast(e.DataRepeaterItem.Controls("txtLocalPgto"), ComboBox).Text = currItem.Item("LocalPgto")



        If e.DataRepeaterItem.ItemIndex Mod 2 = 0 Then
            e.DataRepeaterItem.BackColor = Color.FromArgb(213, 224, 211)
        Else
            e.DataRepeaterItem.BackColor = SystemColors.Control
        End If

    End Sub

    Private Sub ListaReceber_CurrentItemIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaReceber.CurrentItemIndexChanged
        If Me.ListaReceber.CurrentItemIndex > -1 Then
            Me.ListaReceber.CurrentItem.Controls("txtVencimento").Focus()
        End If
    End Sub

    Private Sub CarregaLocalPgto()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        '        Dim Ds As New DataSet

        Dim Sql As String = "SELECT * FROM(LocalPagamento) WHERE (((LocalPagamento.Empresa)=" & CodEmpresa & ") AND ((LocalPagamento.LocalPgto)<>'CHEQUE PRE-DATADO'));"
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(DsReceber, "LocalPgto")

        'Me.txtLocalPgto.DataSource = Ds.Tables("LocalPgto")
        'Me.txtLocalPgto.DisplayMember = "LocalPgto"
        'Me.txtLocalPgto.Text = ""
        Cnn.Close()

    End Sub

    Private Sub DescValor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NzZero(Me.ValorProduto.Text) = 0 Then
            MessageBox.Show("O Total da Venda não pode ser [00,00], para informar desconto", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodBarra.Focus()
            Exit Sub
        End If
    End Sub


    Private Sub TravaCaixasFechamento(ByVal Travar As Boolean)
        Me.btEnviarCaixa.Enabled = Travar
        Me.TipoPgto.Enabled = Travar
        Me.CodPgto.Enabled = Travar
        Me.TotalDesconto.Enabled = Travar
        Me.Acrecimo.Enabled = Travar
        Me.TotalPedido.Enabled = Travar
        Me.ValorVista.Enabled = Travar
        Me.ValorFaturar.Enabled = Travar

    End Sub

    Private Sub btEnviarCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarCaixa.Click
        'Validaçoes de dados


        Dim CX As Boolean = CaixaMovimentoEstaFechado()
        If CX = True Then
            MessageBox.Show("O Caixa de Movimento ja foi finalizado ou não foi iniciado, favor reiniciar o sistema.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
            Exit Sub
        End If

        Dim vAVISTA As Double = NzZero(Me.ValorVista.Text)
        Dim vCHEQUE As Double = NzZero(Me.ValorCheque.Text)
        Dim vCREDIA As Double = NzZero(Me.ValorFaturar.Text)
        Dim vTotal As Double = FormatNumber(vAVISTA + vCHEQUE + vCREDIA, 2)

        If CDbl(NzZero(vTotal)) <> CDbl(NzZero(Me.TotalPedido.Text)) Then
            MessageBox.Show("O total dos pagamentos estão diferente do Total do Pedido, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TotalPedido.Focus()
            Exit Sub
        End If

        If CStr(Me.Venda.Text) <> "000000" Then
            MessageBox.Show("Ja foi gerado um número para este pedido.", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If MessageBox.Show("Deseja realmente enviar para o caixa", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)

            If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
                Me.TotalDesconto.Focus()
            Else
                Me.TipoPgto.Focus()
            End If

            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        TravaCaixasFechamento(False)
        Me.btFechar.Enabled = False
        Me.btEnderecoEntrega.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        'If Me.Venda.Text = "000000" Then
        '    Exit Sub
        'End If

        If Me.xCodCliente.Text = "" Then
            MessageBox.Show("Não foi informado o cliente para a venda.", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.PedidoTipo.Text = "" Then
            MessageBox.Show("Não foi informado o Tipo da Venda.", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.Vendedor.Text = "" Then
            MessageBox.Show("Não foi informado o vendedor para a venda.", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)
        If Me.ValorFaturar.Enabled = True Then
            If CDbl(NzZero(Me.TotalPedido.Text)) = 0 Then
                MessageBox.Show("Não pode finalizar uma venda com valor [0,00].", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.btEnviarCaixa.Enabled = True
                TravaCaixasFechamento(True)
                Me.ValorFaturar.Enabled = False
                Me.ValorVista.Enabled = False
                Me.ValorCheque.Enabled = False

                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorVista.Text = FormatNumber(0, 2)
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.TipoPgto.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If


        vAVISTA = NzZero(Me.ValorVista.Text)
        vCHEQUE = NzZero(Me.ValorCheque.Text)
        vCREDIA = NzZero(Me.ValorFaturar.Text)
        vTotal = FormatNumber(vAVISTA + vCHEQUE + vCREDIA, 2)

        If CDbl(NzZero(vTotal)) <> CDbl(NzZero(Me.TotalPedido.Text)) Then
            MessageBox.Show("O total dos pagamentos estão diferente do Total do Pedido, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TravaCaixasFechamento(True)
            Me.TipoPgto.Focus()
            Me.btEnviarCaixa.Enabled = True
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Me.btFechar.Enabled = True
            Exit Sub
        End If

        'Validaçoes do Cliente
        If Me.VendaCheque.Checked = False And CDbl(NzZero(Me.ValorCheque.Text)) <> 0 Then
            MessageBox.Show("[CHEQUE]-Este Cliente não pode usar esta modalidade de Venda, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If Me.PedidoTipo.Text <> "DEVOLUÇÃO" Then
            If Me.VendaCrediario.Checked = True Then
                If Me.Contrato.Text = "" Then
                    If CDbl(NzZero(Me.ValorFaturar.Text)) > CDbl(NzZero(Me.xLimiteSaldo.Text)) Then
                        MessageBox.Show("[FATURAR]-O Limite para Cliente foi ultrapassado, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.TipoPgto.Focus()
                        Me.btEnviarCaixa.Enabled = True
                        Me.btFechar.Enabled = True
                        TravaCaixasFechamento(True)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If
            End If
        End If

        If CDbl(NzZero(Me.ValorFaturar.Text)) <> 0 Then
            If Me.FormaPgto.Text = "" Then
                MessageBox.Show("O usuário deve informar a Cond. de Pagamento para o valor a faturar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ValorFaturar.Focus()
                Me.btEnviarCaixa.Enabled = True
                TravaCaixasFechamento(True)
                Me.ValorFaturar.Enabled = False
                Me.ValorVista.Enabled = False
                Me.ValorCheque.Enabled = False

                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorVista.Text = FormatNumber(0, 2)
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.TipoPgto.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            If Me.Contrato.Text = "" Then

                If Not DsReceber.Tables.Contains("Receber") Then
                    MessageBox.Show("O usuário deve gerar o recebimento para a Venda/Devolução.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.btEnviarCaixa.Enabled = True
                    Me.btFechar.Enabled = True
                    Me.btEnderecoEntrega.Enabled = True
                    TravaCaixasFechamento(True)
                    Me.ValorFaturar.Enabled = False
                    Me.ValorVista.Enabled = False
                    Me.ValorCheque.Enabled = False

                    Me.ValorFaturar.Text = FormatNumber(0, 2)
                    Me.ValorVista.Text = FormatNumber(0, 2)
                    Me.ValorCheque.Text = FormatNumber(0, 2)
                    Me.TipoPgto.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                Dim ValorParcelado As Double = FormatNumber(NzZero(DsReceber.Tables("Receber").Compute("sum(ValorDocumento)", "")), 2)
                If FormatNumber(NzZero(ValorParcelado), 2) <> FormatNumber(NzZero(Me.ValorFaturar.Text), 2) Then
                    MessageBox.Show("O valor parcelado não pode ser diferente do valor a parcelar, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TravaCaixasFechamento(True)
                    Me.ValorFaturar.Enabled = False
                    Me.ValorVista.Enabled = False
                    Me.ValorCheque.Enabled = False

                    Me.ValorFaturar.Text = FormatNumber(0, 2)
                    Me.ValorVista.Text = FormatNumber(0, 2)
                    Me.ValorCheque.Text = FormatNumber(0, 2)
                    Me.TipoPgto.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
        End If

        If Me.CodPgto.Text = "" Then
            MessageBox.Show("O usuário deve selecionar uma Condição de Pagamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)

            Me.Cursor = Cursors.Default
            Me.CodPgto.Focus()
            Exit Sub
        End If
        'Fim das Validaçoes


        'Salvar o Registro Principal


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdUlt As OleDb.OleDbCommand = CNN.CreateCommand

        Cmd.Transaction = Transacao
        CmdUlt.Transaction = Transacao


        Dim Num As New Random
        Dim Tempo As Integer = 0

        Me.Cursor = Cursors.WaitCursor

        Tempo = Num.Next(1, 4000)
        System.Threading.Thread.Sleep(Tempo)
        Try
            'Rotina para Buscar o ultimo Registro
            CmdUlt.CommandText = "Select max(PedidoSequencia) + 1 from Pedido"
            Dim UltimoReg As Integer = NzZero(CmdUlt.ExecuteScalar)
            If NzZero(UltimoReg) = 0 Then UltimoReg = 1
            Me.Venda.Text = UltimoReg.ToString.PadLeft(6, "0")
            'Rotina para Buscar o ultimo Registro Termina aqui


            Dim Sql As String = "INSERT INTO Pedido (PedidoSequencia, DataPedido, Empresa, ValorProduto, TotalPedido, ValorAVista, ValorOutros, ValorAFaturar, LimiteCredito, PedidoTipo, TipoEntrega, Requisicao, CódigoFuncionário, CódigoCliente, PercDesconto, VlrDescProduto, FormaPgto, DiasParcelamento, StatusAndamentos, MediaDesconto, DevNumero, SenhaGerencia, TipoPgto, CodPgto, ContaCR, Contrato, Acrecimo, TotalPropostoPedido, PedOperador, EnderecoEntrega) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30)"
            Cmd.CommandText = Sql

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CInt(NzZero(Me.Venda.Text))))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataVenda.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.ValorProduto.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.TotalPedido.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.ValorVista.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.ValorCheque.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.ValorFaturar.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.xLimiteSaldo.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.PedidoTipo.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "IMEDIATA"))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", System.DBNull.Value))

            Dim Func() As String = CType(Me.Vendedor.Text, String).Split("-")
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Func(0)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.xCodCliente.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(Me.DescPercentual.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzZero(Me.TotalDesconto.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.FormaPgto.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.DiasParcelamento.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@19", "ENV. CAIXA"))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.DescPercentual.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.DevNumero.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.SenhaGerencia.Text, 1)))

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Me.TipoPgto.SelectedValue))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Me.CodPgto.SelectedValue))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz("000000", 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Me.Contrato.SelectedValue & ""))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@27", NzZero(Me.Acrecimo.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@28", NzZero(Me.TotalPedido.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.lblOperador.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.EnderecoEntrega.Text, 1)))
            Me.StatusAndamento.Text = "ENV. CAIXA"

            Cmd.ExecuteNonQuery()
            Transacao.Commit()
            ErroLivre = "Criou o Pedido"
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.Venda.Text)
            CNN.Close()

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Venda.Text = "000000"
            Transacao.Rollback()
            CNN.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Me.Close()
            Me.Dispose()
            Exit Sub
        End Try


        'Dados do cabeçalho Ok começa a Salvar os itens
        CNN.Open()
        Dim DsIT As New DataSet


        Dim SqlItem As String = "Select * From ItensPedido  Where PedidoSequencia = " & CInt(Me.Venda.Text)

        Dim DaIT As New OleDb.OleDbDataAdapter(SqlItem, CNN)
        DaIT.Fill(DsIT, "ItensVenda")

        Dim DrLinha As DataRow

        Try
            For Each DrLinha In DsItens.Tables("Itens").Rows

                Dim TBL As DataTable
                TBL = DsIT.Tables("ItensVenda")

                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()

                DRnovo("PedidoSequencia") = Nz(Me.Venda.Text, 1)
                DRnovo("PedidoInterno") = 0
                DRnovo("CodigoProduto") = Nz(DrLinha("CodigoProduto").ToString, 1)
                DRnovo("Numero") = Nz(DrLinha("Numero").ToString, 1)
                DRnovo("Multiplos") = 0
                DRnovo("Qtd") = Nz(DrLinha("Qtd").ToString, 1)
                DRnovo("ValorUnitario") = Nz(DrLinha("ValorUnitario").ToString, 1)
                DRnovo("Desconto") = Nz(DrLinha("Desconto").ToString, 1)
                DRnovo("ValorDesconto") = Nz(DrLinha("ValorDesconto").ToString, 1)
                DRnovo("CustoMercadoriaVendida") = Nz(DrLinha("CustoMercadoriaVendida").ToString, 1)
                DRnovo("TotalProduto") = Nz(DrLinha("TotalProduto").ToString, 1)
                DRnovo("tpComissao") = "P"
                DRnovo("Comissao") = 0
                DRnovo("ValorComissao") = 0
                DRnovo("QtdRetirada") = 0
                DRnovo("Grupo") = 0
                DRnovo("Ipi") = 0
                DRnovo("ValorIpi") = 0
                DRnovo("QtdPc") = 0
                DRnovo("UserSenhaDesconto") = System.DBNull.Value
                DRnovo("Icms") = 0
                DRnovo("VlrBCicms") = 0
                DRnovo("VlrIcms") = 0
                DRnovo("CFOP") = System.DBNull.Value
                DRnovo("DevolvidoId") = Nz(DrLinha("DevolvidoId").ToString, 1)
                DRnovo("pAcrecimoVenda") = NzZero(DrLinha("pAcrecimoVenda").ToString)
                DRnovo("vAcrecimoVenda") = NzZero(DrLinha("vAcrecimoVenda").ToString)
                DRnovo("pDescontoEspecial") = NzZero(DrLinha("pDescontoEspecial").ToString)
                DRnovo("vDescontoEspecial") = NzZero(DrLinha("vDescontoEspecial").ToString)

                TBL.Rows.Add(DRnovo)

            Next

            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DaIT)
            DaIT.Update(DsIT, "ItensVenda")

            ErroLivre = "Adicionando itens"
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.Venda.Text)

            If NzZero(Me.ValorFaturar.Text) <> 0 Then
                Try
                    'Fazer Loop no contas a receber para colocar o documento e Pedido
                    If DsReceber.Tables.Contains("Receber") Then
                        Dim I As Integer
                        Dim DocVar As String = String.Empty
                        For I = 0 To DsReceber.Tables("Receber").Rows.Count - 1
                            DsReceber.Tables("Receber").Rows(I).BeginEdit()
                            DocVar = DsReceber.Tables("Receber").Rows(I)("Documento")
                            DocVar = DocVar.Replace("@@", CInt(Me.Venda.Text))
                            DsReceber.Tables("Receber").Rows(I)("Documento") = DocVar
                            DsReceber.Tables("Receber").Rows(I)("PedidoProdutos") = Me.Venda.Text
                            DsReceber.Tables("Receber").Rows(I).EndEdit()
                        Next
                        Dim ObjReceber As New OleDb.OleDbCommandBuilder(DAReceber)
                        DAReceber.Update(DsReceber, "Receber")

                        ErroLivre = "Editou contas a receber colocando o documento de cada parcela"
                        GerarLog(Me.Text, AçãoTP.Adicionou, Me.Venda.Text)

                    End If
                    'Fim do Loop
                    DsReceber.Dispose()
                    CNN.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.btEnviarCaixa.Enabled = True
                    Me.Cursor = Cursors.Default
                    Me.Close()
                    Me.Dispose()
                    Exit Sub
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Me.Close()
            Me.Dispose()
            Exit Sub
        End Try

        System.Threading.Thread.Sleep(1500) 'Thead criada para que haja tempo para salvar os documentos de Recebimento

        If UsaSellShoes = False Then
            Try
                'Definir Impressão da Venda
                Dim cl As New cImpressaoPedido 'Cria uma nova instância, nela encontra-se os metodos para impressão do pedido.
                cl.CodigoPedido = Convert.ToInt32(Me.Venda.Text) 'passa o codigo da venda para a classe
                cl.Impressao(False) 'Faz a impresão

                'Se houve erro retorna um bolean true e cancela.
                If cl.erro = True Then
                    MessageBox.Show("Erro ao tentar imprimir o pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.btEnviarCaixa.Enabled = True
                    Me.Cursor = Cursors.Default
                    ' Exit Sub
                End If

            Catch ex As Exception
                GerarLog(Me.Text, AçãoTP.Impress, Me.Venda.Text)
            End Try
        Else

            Dim Tel As New Form() ' Create a new instance of the form.
            Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer
            Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

            Tel.Text = "Visualizador de Relatório"
            Tel.Size = New Size(576, 352)
            Tel.HelpButton = False
            Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Tel.MaximizeBox = True
            Tel.MinimizeBox = True
            Tel.ControlBox = True
            Tel.Font = F
            Tel.StartPosition = FormStartPosition.CenterScreen
            Tel.ShowInTaskbar = True
            Tel.WindowState = FormWindowState.Maximized

            Vz.Dock = DockStyle.Fill


            Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados
            'Carrega o relatorio
            Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            VerRelat.Load(DirRelat & "RelSellShoesPedido.rpt")
            VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
            VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))
            VerRelat.DataDefinition.RecordSelectionFormula = "{Pedido.PedidoSequencia} = " & Me.Venda.Text & " and {Pedido.Empresa} = " & CodEmpresa

            Vz.ReportSource = VerRelat
            Tel.Controls.Add(Vz)
            Tel.ShowDialog()

        End If
        MessageBox.Show("Venda efetuada com sucesso e Enviada para o caixa.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ErroLivre = "Pedido efetuado com sucesso"
        GerarLog(Me.Text, AçãoTP.Livre, Me.Venda.Text)
        Me.Cursor = Cursors.Default

        If Vendedor_Fecha_Pedido = True Then
            If NzZero(Me.ValorVista.Text) = 0 Then
                My.Forms.SellShoesFinalizar.ShowDialog()
            End If
            Me.Close()
            Me.Dispose()
        End If

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btConcluirVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConcluirVenda.Click

        If Me.ValorVista.Enabled = True Then
            SalvarDadosPedidoCaixa()
        End If

        Dim cxFechado As New CaixaFechado
        cxFechado.CaixaEstaFechado()

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuario deve selecionar um caixa antes de Confirmar o Pedido. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                    My.Forms.SellShoesFinalizar.ShowDialog()
                End If
            End If
            Exit Sub
        Else
            My.Forms.SellShoesFinalizar.ShowDialog()
        End If

    End Sub

    Private Sub LocalizarVenda(ByVal CodVenda As String)

        Dim dsV As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CN.Open()

        Dim Sql As String = String.Empty

        Sql = "SELECT Pedido.*, Clientes.*, Municipio.NomeMunic, UF.NomeUF, Funcionários.Nome, FormaPgto.Descrição FROM ((Pedido INNER JOIN ((Clientes LEFT JOIN UF ON Clientes.cUF = UF.CodigoUF) LEFT JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio) ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) LEFT JOIN FormaPgto ON Pedido.FormaPgto = FormaPgto.CodFormaPgto WHERE (((Pedido.PedidoSequencia)=" & CodVenda & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Empresa)=" & CodEmpresa & "));"
        Dim DaVenda As New OleDb.OleDbDataAdapter(Sql, CN)

        'Sql = "SELECT 0 AS Linha, ItensPedido.CodigoProduto, Produtos.Descrição, ItensPedido.numero, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.Desconto, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, ItensPedido.CustoMercadoriaVendida, ItensPedido.DevolvidoId FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & CodVenda & "));"
        Sql = "SELECT 0 AS Linha, ItensPedido.CodigoProduto, Produtos.Descrição, ItensPedido.Numero, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.vAcrecimoVenda, ItensPedido.ValorDesconto, ItensPedido.vDescontoEspecial, ItensPedido.TotalProduto, ItensPedido.CustoMercadoriaVendida, ItensPedido.DevolvidoId, ItensPedido.pAcrecimoVenda, ItensPedido.Desconto, ItensPedido.pDescontoEspecial FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & CodVenda & "));"
        Dim DaItem As New OleDb.OleDbDataAdapter(Sql, CN)

        DaVenda.Fill(dsV, "Venda")
        DaItem.Fill(dsV, "Itens")


        If dsV.Tables("Venda").Rows.Count > 0 Then
            Me.Venda.Text = dsV.Tables("Venda").Rows(0)("PedidoSequencia").ToString
            Me.xCodCliente.Text = dsV.Tables("Venda").Rows(0)("Codigo").ToString
            Me.xNome.Text = dsV.Tables("Venda").Rows(0)("Clientes.Nome").ToString
            Me.xCpfCnpj.Text = dsV.Tables("Venda").Rows(0)("CpfCgc").ToString
            Me.xEndereco.Text = dsV.Tables("Venda").Rows(0)("Endereço").ToString
            Me.xBairro.Text = dsV.Tables("Venda").Rows(0)("Bairro").ToString
            Me.xCidadeEstado.Text = dsV.Tables("Venda").Rows(0)("Cidade").ToString & "-" & dsV.Tables("Venda").Rows(0)("NomeUF").ToString
            Me.xLimiteCredito.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("LimiteMensal").ToString), 2)
            Me.VendaVista.Checked = dsV.Tables("Venda").Rows(0)("VendaVista").ToString
            Me.VendaCheque.Checked = dsV.Tables("Venda").Rows(0)("VendaCheque").ToString
            Me.VendaCrediario.Checked = dsV.Tables("Venda").Rows(0)("VendaCrediario").ToString
            Me.DataVenda.Text = dsV.Tables("Venda").Rows(0)("DataPedido").ToString
            Me.StatusAndamento.Text = dsV.Tables("Venda").Rows(0)("StatusAndamentos").ToString
            Me.PedidoTipo.Text = dsV.Tables("Venda").Rows(0)("PedidoTipo").ToString
            Me.Vendedor.Text = dsV.Tables("Venda").Rows(0)("CódigoFuncionário").ToString & "-" & dsV.Tables("Venda").Rows(0)("Funcionários.Nome").ToString
            Me.DescPercentual.Text = NzZero(dsV.Tables("Venda").Rows(0)("PercDesconto").ToString)
            Me.TotalDesconto.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("VlrDescProduto").ToString), 2)
            Me.Acrecimo.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("Acrecimo").ToString), 2)
            Me.ValorProduto.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("ValorProduto").ToString), 2)
            Me.TotalPedido.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("TotalPedido").ToString), 2)
            Me.ValorVista.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("ValorAVista").ToString), 2)
            Me.ValorCheque.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("ValorOutros").ToString), 2)
            Me.ValorFaturar.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("ValorAFaturar").ToString), 2)
            Me.FormaPgto.Text = dsV.Tables("Venda").Rows(0)("FormaPgto").ToString
            Me.DiasParcelamento.Text = dsV.Tables("Venda").Rows(0)("DiasParcelamento").ToString
            Me.Confirmado.Checked = dsV.Tables("Venda").Rows(0)("Confirmado").ToString
            Me.DevNumero.Text = dsV.Tables("Venda").Rows(0)("DevNumero").ToString & ""
          
            Me.TipoPgto.SelectedValue = dsV.Tables("Venda").Rows(0)("TipoPgto").ToString
            EncheCodPgto()
            Me.CodPgto.SelectedValue = dsV.Tables("Venda").Rows(0)("CodPgto").ToString

            If Me.Confirmado.Checked = True Then
                MessageBox.Show("Pedido ja confirmado, favor escolher outro", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Me.Dispose()
            End If

            'Me.PainelFaturamento.Enabled = False
        End If

        Me.Lista.DataSource = dsV.Tables("Itens").DefaultView


        'Carrega o Recebimento
        DsReceber.Clear()
        If DsReceber.Tables.Contains("Receber") Then DsReceber.Tables.Remove("Receber")
        CarregaLocalPgto()

        Dim CmdAPrazo As New OleDb.OleDbCommand

        Sql = "SELECT * from Receber Where PedidoProdutos = " & CInt(Me.Venda.Text)

        CmdAPrazo.Connection = CN
        CmdAPrazo.CommandText = Sql

        DAReceber = New OleDb.OleDbDataAdapter(CmdAPrazo)
        DAReceber.Fill(DsReceber, "Receber")

        bs.DataSource = DsReceber.Tables("Receber")
        Me.ListaReceber.DataSource = bs
        Me.ListaReceber.Enabled = False
        'Fim do Carregamento do recebimento

        If Me.Confirmado.Checked = True Then
            Me.ConfImg.Visible = True
            Me.btEnviarCaixa.Enabled = False
            Me.btConcluirVenda.Enabled = False
            MessageBox.Show("Esta venda ja foi confirmada e não pode mais ser Alterada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.ConfImg.Visible = False
            Me.btEnviarCaixa.Enabled = True
            Me.btConcluirVenda.Enabled = True
        End If

        If Me.StatusAndamento.Text = "ENV. CAIXA" Then
            Me.btEnviarCaixa.Enabled = False
        End If

        VerificaLimiteCredito()
        EncheListaContrato()
        Me.Contrato.SelectedValue = dsV.Tables("Venda").Rows(0)("Contrato").ToString & ""

        CN.Close()

    End Sub

    Private Sub FormaPgto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FormaPgto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcuraFormaPgto.ShowDialog()
        End If
    End Sub

    Private Sub AchaFormaPgto()
        If Me.FormaPgto.Text = "" Then
            VarTemEntrada = False
            Exit Sub
        Else

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Select * from FormaPgto Where CodFormaPgto = " & Me.FormaPgto.Text
            Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
            Dim DR As OleDb.OleDbDataReader

            Try
                DR = Cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Me.DiasParcelamento.Text = DR.Item("DiasParcelamento") & ""
                    If DR.Item("TemEntrada") = True Then
                        VarTemEntrada = True
                    Else
                        VarTemEntrada = False
                    End If
                Else
                    Me.DiasParcelamento.Text = ""
                    VarTemEntrada = False
                End If
                DR.Close()
                CNN.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
            End Try
        End If
    End Sub

    Private Sub FormaPgto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormaPgto.Leave
        If String.CompareOrdinal(Me.FormaPgto.Text, Me.FormaPgto.TextoAntigo) Then
            AchaFormaPgto()
        End If
    End Sub

    Private Sub ExcluirOItemSelecionadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirOItemSelecionadoToolStripMenuItem.Click

        If LinhaSelecionada < 0 Then Exit Sub

        If Me.StatusAndamento.Text = "ENV. CAIXA" Then
            MessageBox.Show("Este pedido ja foi enviado para o caixa e não pode mais ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Deseja Excluir o item selecionado", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DsItens.Tables("Itens").Rows(LinhaSelecionada).Delete()

            Me.Acrecimo.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)
            Dim DescEspecial As Double = NzZero(DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
            Dim DescNormal As Double = NzZero(DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
            Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

            Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
            Me.TotalPedido.Text = FormatNumber(NzZero(Me.ValorProduto.Text) - NzZero(Me.TotalDesconto.Text), 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.CodBarra.Focus()
            Me.Lista.Refresh()
            LinhaSelecionada = -1
        End If

    End Sub

    Private Sub Lista_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellClick
        LinhaSelecionada = e.RowIndex

        If Me.PedidoTipo.Text <> "DEVOLUÇÃO" Then
            If e.ColumnIndex = Me.btDescontoEspecial.Index AndAlso e.RowIndex >= 0 Then
                Dim frmDesconto As New SellShoesDescontoGerencia
                frmDesconto.Individual = True
                frmDesconto.idITEM = LinhaSelecionada
                frmDesconto.ShowDialog()


                Me.ValorProduto.Text = SomaColuna("cTotalProduto")
                Me.Acrecimo.Text = SomaColuna("cAcrecimo")

                Dim DescEspecial As Double = SomaColuna("cEspecial")
                Dim DescNormal As Double = SomaColuna("cValorDesconto")
                Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)


                Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)

                Me.Lista.Refresh()
                Me.TotalPedido.Focus()
            End If
        End If

    End Sub


    Private Sub SalvarDadosPedidoCaixa()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update Pedido  Set ValorAVista = @1, ValorOutros = @2, ValorAFaturar = @3, DiasParcelamento = @4, FormaPgto = @5 Where Pedido.PedidoSequencia = " & Me.Venda.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", NzZero(Me.ValorVista.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", NzZero(Me.ValorCheque.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.ValorFaturar.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.DiasParcelamento.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.FormaPgto.Text)))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try

    End Sub

    Private Sub VerDebitoCliente()
        If Me.xCodCliente.Text = "" Then
            Exit Sub
        End If

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        'Dim Sql As String = "SELECT Receber.CodCliente AS Cliente, Sum(Receber.ValorDocumento) AS Total FROM Receber WHERE (((Receber.Recebimento) Is Null) AND ((Receber.Baixado)=False) AND ((Receber.Empresa)=" & CodEmpresa & ")) GROUP BY Receber.CodCliente HAVING (((Receber.CodCliente)=" & Me.xCodCliente.Text & ")); UNION SELECT ArquivoCheque.Cliente, Sum(ArquivoCheque.ValorCh) AS Total FROM ArquivoCheque WHERE (((ArquivoCheque.DataBaixa) Is Null) AND ((ArquivoCheque.Empresa)=" & CodEmpresa & ")) GROUP BY ArquivoCheque.Cliente HAVING (((ArquivoCheque.Cliente)=" & Me.xCodCliente.Text & "));"
        '        Dim Sql As String = "SELECT Receber.CodCliente AS Cliente, Sum(Receber.ValorDocumento) AS Total FROM Receber WHERE (((InStr(1,[Documento],'C'))=0) AND ((Receber.Recebimento) Is Null) AND ((Receber.Baixado)=False) AND (Receber.Empresa)=" & CodEmpresa & ")) GROUP BY Receber.CodCliente HAVING (((Receber.CodCliente)=" & Me.xCodCliente.Text & ")); UNION SELECT ArquivoCheque.Cliente, Sum(ArquivoCheque.ValorCh) AS Total FROM ArquivoCheque WHERE (((ArquivoCheque.DataBaixa) Is Null) AND ((ArquivoCheque.Empresa)=" & CodEmpresa & ")) GROUP BY ArquivoCheque.Cliente HAVING (((ArquivoCheque.Cliente)=" & Me.xCodCliente.Text & "));"
        Dim sql As String = "SELECT Receber.CodCliente AS Cliente, Sum(Receber.ValorDocumento) AS Total FROM(Receber) WHERE (((InStr(1,[Documento],'-C'))=0) AND ((Receber.Recebimento) Is Null) AND ((Receber.Baixado)=False) AND ((Receber.Empresa)=" & CodEmpresa & ")) GROUP BY Receber.CodCliente HAVING (((Receber.CodCliente)=" & Me.xCodCliente.Text & ")); UNION SELECT ArquivoCheque.Cliente, Sum(ArquivoCheque.ValorCh) AS Total FROM ArquivoCheque WHERE (((ArquivoCheque.DataBaixa) Is Null) AND ((ArquivoCheque.Empresa)=" & CodEmpresa & ")) GROUP BY ArquivoCheque.Cliente HAVING (((ArquivoCheque.Cliente)=" & Me.xCodCliente.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        Dim VlrDebito As Double = 0

        While DR.Read
            VlrDebito += NzZero(DR.Item("Total"))
        End While

        Me.xLimiteUtilizado.Text = FormatNumber(NzZero(VlrDebito), 2)

        DR.Close()
        CnnFind.Close()
    End Sub

    Private Sub EncheListaTipoPgto()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        If Me.Contrato.Text = "" Then
            Sql = "Select TipoPgto.CodigoTipoPgto, TipoPgto.DescricaoTipoPgto From TipoPgto Where TipoPgto.SomenteContrato = False order by TipoPgto.DescricaoTipoPgto"
        Else
            Sql = "Select TipoPgto.CodigoTipoPgto, TipoPgto.DescricaoTipoPgto From TipoPgto Where TipoPgto.SomenteContrato = True order by TipoPgto.DescricaoTipoPgto"
        End If
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.TipoPgto.DataSource = ds.Tables("Table").DefaultView
        Me.TipoPgto.DisplayMember = "DescricaoTipoPgto"
        Me.TipoPgto.ValueMember = "CodigoTipoPgto"
        Me.TipoPgto.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheCodPgto()

        If Me.TipoPgto.Text = "" Then
            Me.TipoPgto.Focus()
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT AnexarForma.Fp_Codigo, [Fp_Codigo] & ' - ' & '(' & [Descrição] & ')' AS [Desc] FROM AnexarForma INNER JOIN FormaPgto ON AnexarForma.Fp_Codigo = FormaPgto.CodFormaPgto WHERE (((AnexarForma.Tp_Codigo)=" & Me.TipoPgto.SelectedValue & "));"


        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.CodPgto.DataSource = ds.Tables("Table").DefaultView
        Me.CodPgto.DisplayMember = "Desc"
        Me.CodPgto.ValueMember = "Fp_Codigo"
        Me.CodPgto.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Public Sub EncheListaContrato()


        If Me.xCodCliente.Text = 0 Then
            Exit Sub
        End If


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = "SELECT Contratos.Cliente, Contratos.Finalizado, * FROM (Contratos) WHERE (((Contratos.Cliente)=" & Me.xCodCliente.Text & ") AND ((Contratos.Finalizado)='N'));"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Contrato.DataSource = ds.Tables("Table").DefaultView
        Me.Contrato.DisplayMember = "CodContrato"
        Me.Contrato.ValueMember = "CodContrato"
        Me.Contrato.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

        If Me.Contrato.Items.Count > 0 Then
            Me.LabelContrato.Visible = True
            Me.Contrato.Visible = True


            If Me.Contrato.Text = "" Then
                MsgBox("ATENÇÃO!!" & Chr(13) & Chr(13) & "Cliente com contrato de Obras." & Chr(13) & "Selecione o contrato se a venda for para uma obra específica.", 48, "Informação")
            End If
            Me.Contrato.Focus()

        Else
            Me.LabelContrato.Visible = False
            Me.Contrato.Visible = False
        End If


    End Sub

    Private Sub CodPgto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodPgto.Enter
        DsReceber.Clear()
        If DsReceber.Tables.Contains("Receber") Then DsReceber.Tables.Remove("Receber")
        EncheCodPgto()
    End Sub

    Private Sub AchaCodPgtoSelecionado()

        If Me.CodPgto.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty
        'Sql = "SELECT AnexarForma.Tp_Codigo, AnexarForma.Fp_Codigo, AnexarForma.Desconto, AnexarForma.Acrescimo FROM(AnexarForma) WHERE (((AnexarForma.Tp_Codigo)=" & Me.TipoPgto.SelectedValue & ") AND ((AnexarForma.Fp_Codigo)= " & Me.CodPgto.SelectedValue & "));"
        Sql = "SELECT AnexarForma.Tp_Codigo, AnexarForma.Fp_Codigo, FormaPgto.Descrição, FormaPgto.TemEntrada, AnexarForma.Desconto, AnexarForma.Acrescimo FROM AnexarForma INNER JOIN FormaPgto ON AnexarForma.Fp_Codigo = FormaPgto.CodFormaPgto WHERE (((AnexarForma.Tp_Codigo)=" & Me.TipoPgto.SelectedValue & ") AND ((AnexarForma.Fp_Codigo)=" & Me.CodPgto.SelectedValue & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then

            VarDesconto = NzZero(DR.Item("Desconto"))
            VarAcrecimo = NzZero(DR.Item("Acrescimo"))

            'If CDbl(VarDesconto) > 0 Then
            '    Me.DescPercentual.Text = VarDesconto
            '    Me.TotalDesconto.Text = FormatNumber((CDbl(NzZero(Me.ValorProduto.Text)) * CDbl(NzZero(Me.DescPercentual.Text)) / 100), 2)
            '    Me.Acrecimo.Text = FormatNumber(0, 2)
            'Else
            '    Me.DescPercentual.Text = 0
            '    Me.TotalDesconto.Text = FormatNumber(0, 2)
            '    Me.Acrecimo.Text = FormatNumber(0, 2)
            'End If

            'If CDbl(VarAcrecimo) > 0 Then
            '    Me.DescPercentual.Text = 0
            '    Me.Acrecimo.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) * CDbl(NzZero(VarAcrecimo)) / 100, 2)
            '    Me.TotalDesconto.Text = FormatNumber(0, 2)
            'Else
            '    Me.Acrecimo.Text = FormatNumber(0, 2)
            'End If


            If DR.Item("TemEntrada") = False Then
                Me.ValorVista.Text = FormatNumber(0, 2)
                Me.ValorVista.Enabled = False
            Else
                Me.ValorVista.Enabled = True
            End If

            If DR.Item("Descrição") = "A VISTA" Then
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Enabled = False
            Else
                If Me.Bloqueado.Checked = True Then
                    Me.ValorFaturar.Enabled = False
                Else
                    Me.ValorFaturar.Enabled = True
                End If
            End If

                'If Me.PedidoTipo.Text = "DEVOLUÇÃO" And Me.Contrato.Text <> "" Then
                '    Me.ValorVista.Enabled = True
                '    Me.ValorCheque.Enabled = False
                '    Me.ValorFaturar.Text = FormatNumber(0, 2)
                '    Me.ValorFaturar.Enabled = False
                'End If

                'P_Acre = DR.Item("Acrescimo")
        End If


        Cnn.Close()

    End Sub

  


    Private Sub TotalPedido_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TotalPedido.Validating

        If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
            If CDbl(NzZero(Me.TotalPedido.Text)) > 0 Then
                Me.TotalPedido.Text = NzZero(Me.TotalPedido.Text) * -1
            Else

                'Me.ValorVista.Text = Me.TotalPedido.Text
                'Me.ValorVista.Enabled = False
                'Me.ValorFaturar.Enabled = False
                'Me.ValorCheque.Enabled = False
            End If
        End If

        If Me.PedidoTipo.Text = "VENDA" Then

            If CDbl(NzZero(Me.TotalPedido.Text)) < 0 Then
                MessageBox.Show("O valor para venda não pode ser negativo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.TotalPedido.Clear()
                Me.CodPgto.Focus()
                Exit Sub
            End If

            'Dim vlr_Pedido As Double = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)))
            'If NzZero(Me.TotalPedido.Text) > NzZero(vlr_Pedido) Then
            '    Me.DescPercentual.Text = 0
            '    Me.TotalDesconto.Text = 0
            '    Me.Acrecimo.Text = 0
            '    Me.TotalPedido.Text = FormatNumber(vlr_Pedido, 2)
            '    Me.TipoPgto.Focus()
            '    Exit Sub
            'End If
        End If



        'Dim Var_TPedido As Double = 0
        'Dim Var_VlrDesconto As Double = 0
        'Dim Var_VlrDiferenca As Double = 0

        'Var_TPedido = FormatNumber(CDbl(NzZero(Me.TotalPedido.Text)))
        'Var_VlrDesconto = FormatNumber(CDbl(NzZero(Me.TotalDesconto.Text)))
        'Var_VlrDiferenca = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalPedido.Text)))
        'Var_VlrDiferenca -= Var_VlrDesconto

        'Dim DescG As Double = Var_VlrDiferenca / (Var_TPedido) * 100
        'If CDbl(DescG) > CDbl(DescontoGerencia) Then
        '    My.Forms.SellShoesDescontoGerencia.ShowDialog()


        '    Dim Crpt As New ClCrypto

        '    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        '    Cnn.Open()

        '    Dim Sql As String = "SELECT FuncionarioCartao.*, Funcionários.Nome FROM Funcionários INNER JOIN FuncionarioCartao ON Funcionários.CódigoFuncionário = FuncionarioCartao.Funcionario WHERE (((Funcionários.Inativo)=False) AND ((FuncionarioCartao.Inativo)=False) AND ((FuncionarioCartao.idCartao)='" & DeCriptografa(Me.SenhaGerencia.Text) & "'));"

        '    Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        '    Dim DR As OleDb.OleDbDataReader

        '    DR = CMD.ExecuteReader
        '    DR.Read()

        '    If DR.HasRows Then
        '        Dim DTExpirar As Date = CDate(DR.Item("DataExpiracao"))
        '        If CDate(DataDia) > CDate(DTExpirar) Then
        '            MessageBox.Show("Este cartão esta com a data expirada, verifique com o Administrador.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            TravaCaixasFechamento(True)
        '            Me.CodPgto.Focus()
        '            Exit Sub
        '        End If

        '        If DR.Item("PermissaoMaster") = False Then
        '            MessageBox.Show("Este cartão não tem permissão para a operação, verifique com o Administrador.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            TravaCaixasFechamento(True)
        '            Me.CodPgto.Focus()
        '            Exit Sub
        '        End If
        '    Else
        '        MessageBox.Show("Senha informada é inválida.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.SenhaGerencia.Text = ""
        '        If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then
        '            Me.ValorFaturar.Text = FormatNumber(0, 2)
        '            Me.ValorCheque.Text = FormatNumber(0, 2)
        '            Me.ValorVista.Text = FormatNumber(0, 2)
        '            TravaCaixasFechamento(True)
        '            Me.TotalDesconto.Focus()
        '        Else
        '            Me.ValorFaturar.Text = FormatNumber(0, 2)
        '            Me.ValorCheque.Text = FormatNumber(0, 2)
        '            Me.ValorVista.Text = FormatNumber(0, 2)
        '            TravaCaixasFechamento(True)
        '            Me.CodPgto.Focus()
        '        End If
        '        Exit Sub
        '    End If
        'End If



        'Me.TotalDesconto.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalPedido.Text)))

        'Me.DescPercentual.Text = FormatNumber((CDbl(NzZero(Me.TotalDesconto.Text)) + CDbl(NzZero(Me.Acrecimo.Text))) / CDbl(NzZero(Me.ValorProduto.Text)) * 100, 4)

        'Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)




    End Sub

    Private Sub Contrato_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Contrato.Leave
        'If Me.Contrato.Text = "" Then
        '    EncheListaTipoPgto()
        '    If Me.Contrato.Items.Count > 0 Then ' verifica se tem item na combo
        '        If String.IsNullOrEmpty(Me.Contrato.Text) Then 'verifica se o nenhum item do combo foi seleicionado e retorna uma mensagem para o usuário
        '            MsgBox("ATENÇÃO!!" & Chr(13) & Chr(13) & "Cliente com contrato de Obras." & Chr(13) & "Selecione o contrato se a venda for para uma obra específica.", 48, "Informação")
        '        End If
        '    End If

        'End If  - teste referente validação do contrato 

        'Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        'Dim Sql As String = "SELECT Contratos.CodContrato, Contratos.ContaCR FROM Contratos WHERE Contratos.CodContrato = '" & Me.Contrato.SelectedValue & "'"

        'Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        'Dim ds As New DataSet
        'da.Fill(ds, "Table")

        'If ds.Tables("Table").Rows.Count > 0 Then
        '    Me.ContaCR.Text = ds.Tables("Table").Rows(0)("ContaCr")
        'End If

        'ds.Dispose()
        'Cnn.Close()

        EncheListaTipoPgto()

    End Sub

    Private Sub CodBarra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodBarra.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.CodBarra.Text.Length = 0 Then
                Me.TotalDesconto.Focus()
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            If Me.CodBarra.Text.Length = 0 Then
                If UsarGrade = True Then
                    My.Forms.SellShoesProdutoProcura.ShowDialog()

                Else
                    My.Forms.ProcuraProduto.ShowDialog()
                    CodBarra_Leave(sender, e)
                End If
            End If
        End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtParcelas.Click

        If Me.ListaReceber.CurrentItem.Controls("txtDocumento").Text = "" Then
            MessageBox.Show("O Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtDocumento.Focus()
            Exit Sub
        End If
        If Me.ListaReceber.CurrentItem.Controls("txtVencimento").Text = "" Then
            MessageBox.Show("O Vencimento do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtVencimento.Focus()
            Exit Sub
        End If
        If Me.ListaReceber.CurrentItem.Controls("txtValor").Text = "" Then
            MessageBox.Show("O Valor do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtValor.Focus()
            Exit Sub
        End If
        If Me.ListaReceber.CurrentItem.Controls("txtLocalPgto").Text = "" Then
            MessageBox.Show("O Local de Pagamento do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtLocalPgto.Focus()
            Exit Sub
        End If

        'If RestaValorGeral < NzZero(Me.txtValor.Text) Then
        '    MessageBox.Show("O Valor da Parcela não pode ser maior que o valor restante", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.txtValor.Focus()
        '    Exit Sub
        'End If

        Dim QtdRow As Integer = DsReceber.Tables("Receber").Rows.Count
        Dim QtdRowTemp As Integer
        Dim RowAlterada As Integer

        Dim SomaValor As Double = 0
        Dim RestaValor As Double = 0

        Dim Linha As DataRow
        For Each Linha In DsReceber.Tables("Receber").Rows

            QtdRowTemp += 1
            If Linha("Documento") = Me.ListaReceber.CurrentItem.Controls("txtDocumento").Text Then

                Linha.BeginEdit()
                Linha("Vencimento") = Me.ListaReceber.CurrentItem.Controls("txtVencimento").Text
                Linha("ValorDocumento") = Me.ListaReceber.CurrentItem.Controls("txtValor").Text
                Linha("LocalPgto") = Me.ListaReceber.CurrentItem.Controls("txtLocalPgto").Text
                Linha.EndEdit()
                RowAlterada = QtdRowTemp
                SomaValor += FormatNumber(Linha("ValorDocumento"), 2)
                Exit For
            End If
            SomaValor += Linha("ValorDocumento")

        Next

        RestaValor = FormatNumber(CDbl(NzZero(Me.ValorFaturar.Text)) - SomaValor, 2)

        RestaValorGeral = RestaValor

        Dim dividido As Double
        dividido = FormatNumber((RestaValor), 2) / (DsReceber.Tables("Receber").Rows.Count - RowAlterada)

        dividido = Round(dividido, 2)

        Dim TestaValor As Double = dividido * (DsReceber.Tables("Receber").Rows.Count - RowAlterada)
        Dim ValorSobra As Double = Round(RestaValor - TestaValor, 2)


        QtdRowTemp = 0

        'Reajusta as parcelas abaixo da alterada o valor

        For Each Linha In DsReceber.Tables("Receber").Rows
            QtdRowTemp += 1
            If QtdRowTemp > RowAlterada Then
                Linha.BeginEdit()
                If QtdRowTemp = DsReceber.Tables("Receber").Rows.Count Then
                    Linha("ValorDocumento") = dividido + ValorSobra
                Else
                    Linha("ValorDocumento") = dividido
                End If

                Linha.EndEdit()
            End If
        Next



        If (Me.ListaReceber.CurrentItemIndex + 1) < Me.ListaReceber.ItemCount Then
            Me.ListaReceber.CurrentItemIndex = Me.ListaReceber.CurrentItemIndex + 1
        Else
            Me.ListaReceber.CurrentItemIndex = 0
        End If


        'Me.Parcelado.Text = NzZero(Ds.Tables("Receber").Compute("sum(ValorDocumento)", ""))
        'Dim Tbl As New DataView(Ds.Tables("Receber").Copy)
        'Me.ListaReceber.DataSource = Tbl.ToTable("Table", True, "Documento", "ValorDocumento", "Vencimento", "LocalPgto")



    End Sub

    Private Sub Qtd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        If Me.Qtd.Text = "" Then FormatNumber(0, 2)

        If NzZero(Me.Qtd.Text) <= 0 Then
            MessageBox.Show("O valor  do item não pode ser negativo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Qtd.Text = 1
            Me.Qtd.Focus()
            Exit Sub
        End If

        If Me.Qtd.Text > 0 Then
            Me.ValorDesconto.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarDesconto) / 100
            Me.vAcrecimo.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarAcrecimo) / 100

            Dim tTotal As Double = (NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text))
            Me.Total.Text = FormatNumber(tTotal, 2)

        End If
    End Sub

    Private Sub ListaReceber_ItemCloned(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs) Handles ListaReceber.ItemCloned

        Dim CloneCmb As ComboBox = CType(e.DataRepeaterItem.Controls.Item("txtLocalPgto"), ComboBox)
        For i As Integer = 0 To DsReceber.Tables("LocalPgto").Rows.Count - 1
            CloneCmb.Items.Add(DsReceber.Tables("LocalPgto").Rows(i).Item("LocalPgto"))
        Next

    End Sub



    Dim VlrUnitarioTemp As Double
    Private Sub Unitario_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unitario.Enter
        VlrUnitarioTemp = NzZero(Me.Unitario.Text)
    End Sub

    Private Sub Qtd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Qtd.KeyDown
        Dim isControlPressed As Boolean = (Control.ModifierKeys And Keys.Control) <> 0
        If isControlPressed = True Then
            If e.KeyCode = Keys.Insert Then
                Me.Unitario.Enabled = True
                Me.Unitario.Focus()
            End If
        End If
    End Sub
    
    Private Sub Qtd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Enter
        Me.Unitario.Enabled = False
    End Sub

    Private Sub TotalDesconto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalDesconto.Enter
        AchaCodPgtoSelecionado()
        Me.FormaPgto.Text = Me.CodPgto.SelectedValue
        AchaFormaPgto()

        Dim Parcelas() As String = Split(Me.DiasParcelamento.Text, "-")

        'If Parcelas.Length > 0 And Me.ValorFaturar.Enabled = False Then
        '    MessageBox.Show("Este Cliente esta bloqueado venda a faturar ou seu limite esta esgotado, verifique com o Administrador", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.CodPgto.SelectedValue = -1
        '    Me.TipoPgto.Focus()
        '    Exit Sub
        'End If
    End Sub

   
    Private Sub btCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCheque.Click

        If Me.VendaCheque.Checked = False Then
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.ValorCheque.Enabled = False
            MessageBox.Show("Este Cliente não pode usar esta modalidade de pagamento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.ValorCheque.Enabled = True
            Me.ValorCheque.Focus()
        End If

    End Sub

    

#Region "Controla Alteraçao da Data de vencimento de uma Parcela"

    Private Sub txtVencimento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVencimento.Leave

        Dim DataVencimento As DateTime = CDate(Me.ListaReceber.CurrentItem.Controls("VencimentoOriginal").Text)
        Dim DataAlterada As DateTime = Me.ListaReceber.CurrentItem.Controls("txtVencimento").Text


        Dim inicio As New DateTime(DataVencimento.Year, DataVencimento.Month, DataVencimento.Day) 'ano, mês, dia
        Dim fim As New DateTime(DataAlterada.Year, DataAlterada.Month, DataAlterada.Day) 'ano, mês, dia
        Dim dif As TimeSpan = fim.Subtract(inicio)
        Dim dias As Integer = dif.Days



        Select Case dias
            Case -5 To 5
                'Esta na faixa dos dias permitidos
            Case Else
                MessageBox.Show("A quantidade de dias não pode ser maior que 5.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ListaReceber.CurrentItem.Controls("txtVencimento").Text = Format(DataVencimento, "dd/MM/yyyy")
                Exit Sub
        End Select

    End Sub

#End Region

   
    Private Sub Vendedor_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vendedor.DoubleClick
        If PedidoTipo.Text = "VENDA" Then
            If EstaCarregado("SellShoesAutenticacao") = False Then
                My.Forms.SellShoesAutenticacao.ShowDialog()
            Else
                My.Forms.SellShoesAutenticacao.Close()
                My.Forms.SellShoesAutenticacao.Dispose()
                'My.Forms.SellShoesAutenticacao.Visible = True
            End If

        End If
    End Sub

    Private Sub xCodCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles xCodCliente.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(OnlyNumber(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btEnderecoEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnderecoEntrega.Click
        If Me.xCodCliente.Text = "" Then
            MessageBox.Show("O usuário deve informar o cliente ante do endereço de entrega", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.SellShoesEnderecoEntrega.ShowDialog()
        Me.btEnviarCaixa.Focus()

    End Sub

    Private Sub TipoPgto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoPgto.Enter
        Me.ValorCheque.Text = FormatNumber(0, 2)
        Me.ValorFaturar.Text = FormatNumber(0, 2)
        Me.ValorVista.Text = FormatNumber(0, 2)

        Me.CodPgto.Text = Nothing
        If DsReceber.Tables.Contains("Receber") Then
            DsReceber.Clear()
            DsReceber.Tables.Remove("Receber")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TravaCaixasFechamento(True)
    End Sub

    Private Sub CodPgto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodPgto.Validated
        AchaCodPgtoSelecionado()
        Me.FormaPgto.Text = Me.CodPgto.SelectedValue
        AchaFormaPgto()

        Dim Parcelas() As String = Split(Me.DiasParcelamento.Text, "-")

        'Refaz os valores na lista de Produto caso o usuario altera o plano de recebimento
        If DsItens.Tables("Itens").Rows.Count > 0 Then
            Dim drlinha As DataRow
            For Each drlinha In DsItens.Tables("Itens").Rows

                'MsgBox(drlinha("vAcrecimoVenda"))

                drlinha.BeginEdit()
                drlinha("vAcrecimoVenda") = FormatNumber(((CDbl(NzZero(drlinha("Qtd"))) * CDbl(NzZero(drlinha("ValorUnitario")))) * VarAcrecimo) / 100, 2)
                drlinha("ValorDesconto") = FormatNumber(((CDbl(NzZero(drlinha("Qtd"))) * CDbl(NzZero(drlinha("ValorUnitario")))) * VarDesconto) / 100, 2)
                drlinha("TotalProduto") = FormatNumber(CDbl(NzZero(drlinha("Qtd"))) * CDbl(NzZero(drlinha("ValorUnitario"))), 2)

                drlinha("Desconto") = NzZero(VarDesconto)
                drlinha("pAcrecimoVenda") = NzZero(VarAcrecimo)
                drlinha("pDescontoEspecial") = 0
                drlinha("vDescontoEspecial") = 0
                drlinha.EndEdit()

            Next

            Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
            Me.Acrecimo.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)

            Dim DescEspecial As Double = NzZero(DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
            Dim DescNormal As Double = NzZero(DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
            Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

            Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)
            Me.Lista.Refresh()

        End If
        'fim

    End Sub

    Private Sub Unitario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unitario.Validated
        If CDbl(NzZero(Me.Unitario.Text)) < CDbl(NzZero(VlrUnitarioTemp)) Then
            MessageBox.Show("O valor do produto não pode ser menor que o valor do cadastro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Unitario.Text = VlrUnitarioTemp
            Exit Sub
        End If

        If Me.Qtd.Text = "" Then FormatNumber(0, 2)
        If Me.Qtd.Text > 0 Then

            Me.ValorDesconto.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarDesconto) / 100
            Me.vAcrecimo.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarAcrecimo) / 100

            Dim tTotal As Double = (NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text))
            Me.Total.Text = FormatNumber(tTotal, 2)
        End If
    End Sub

    Private Sub TotalPedido_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalPedido.Enter
        Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)
    End Sub

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.xCodCliente.Text = "" Then
            Me.xCodCliente.Focus()
        End If
        Me.Timer1.Enabled = False
    End Sub

   
    Private Sub txtValor_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.Validated
        If Me.PedidoTipo.Text = "VENDA" Then
            If CDbl(NzZero(Me.ListaReceber.CurrentItem.Controls("txtValor").Text)) < 0 Then
                Me.ListaReceber.CurrentItem.Controls("txtValor").Text = FormatNumber(CDbl(NzZero(Me.ListaReceber.CurrentItem.Controls("txtValor").Text)) * -1, 2)
            End If
        End If
    End Sub

    Private Sub CriarDevolução()

        Dim CX As Boolean = CaixaMovimentoEstaFechado()
        If CX = True Then
            MessageBox.Show("O Caixa de Movimento ja foi finalizado ou não foi iniciado, favor reiniciar o sistema.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
            Exit Sub
        End If


        If CStr(Me.Venda.Text) <> "000000" Then
            MessageBox.Show("Ja foi gerado um número para este pedido.", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If MessageBox.Show("Deseja realmente enviar para o caixa", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        TravaCaixasFechamento(False)
        Me.btFechar.Enabled = False
        Me.btEnderecoEntrega.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        If Me.xCodCliente.Text = "" Then
            MessageBox.Show("Não foi informado o cliente para a Devolução.", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.PedidoTipo.Text = "" Then
            MessageBox.Show("Não foi informado o Tipo da Venda.", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.Vendedor.Text = "" Then
            MessageBox.Show("Não foi informado o vendedor para a Devolução.", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Me.TotalPedido.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)
        If Me.ValorFaturar.Enabled = True Then
            If CDbl(NzZero(Me.TotalPedido.Text)) = 0 Then
                MessageBox.Show("Não pode finalizar uma Devolução com valor [0,00].", "Validação de Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.btEnviarCaixa.Enabled = True
                TravaCaixasFechamento(True)
                Me.ValorFaturar.Enabled = False
                Me.ValorVista.Enabled = False
                Me.ValorCheque.Enabled = False

                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorVista.Text = FormatNumber(0, 2)
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.TipoPgto.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If


        Dim vAVISTA As Double = NzZero(Me.ValorVista.Text)
        Dim vCHEQUE As Double = NzZero(Me.ValorCheque.Text)
        Dim vCREDIA As Double = NzZero(Me.ValorFaturar.Text)
        Dim vTotal As Double = FormatNumber(vAVISTA + vCHEQUE + vCREDIA, 2)

        If CDbl(NzZero(vTotal)) <> CDbl(NzZero(Me.TotalPedido.Text)) Then
            MessageBox.Show("O total dos pagamentos estão diferente do Total do Pedido de Devolução, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TravaCaixasFechamento(True)
            Me.TipoPgto.Focus()
            Me.btEnviarCaixa.Enabled = True
            Me.ValorFaturar.Enabled = False
            Me.ValorVista.Enabled = False
            Me.ValorCheque.Enabled = False

            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Text = FormatNumber(0, 2)
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.TipoPgto.Focus()
            Me.Cursor = Cursors.Default
            Me.btFechar.Enabled = True
            Exit Sub
        End If


        If CDbl(NzZero(Me.ValorFaturar.Text)) > 0 Then
            If Me.FormaPgto.Text = "" Then
                MessageBox.Show("O usuário deve informar a Cond. de Pagamento para o valor a faturar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ValorFaturar.Focus()
                Me.btEnviarCaixa.Enabled = True
                TravaCaixasFechamento(True)
                Me.ValorFaturar.Enabled = False
                Me.ValorVista.Enabled = False
                Me.ValorCheque.Enabled = False

                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorVista.Text = FormatNumber(0, 2)
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.TipoPgto.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If


            If Me.Contrato.Text = "" Then
                If Not DsReceber.Tables.Contains("Receber") Then
                    MessageBox.Show("O usuário deve gerar o recebimento para a venda.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.btEnviarCaixa.Enabled = True
                    Me.btFechar.Enabled = True
                    Me.btEnderecoEntrega.Enabled = True
                    TravaCaixasFechamento(True)
                    Me.ValorFaturar.Enabled = False
                    Me.ValorVista.Enabled = False
                    Me.ValorCheque.Enabled = False

                    Me.ValorFaturar.Text = FormatNumber(0, 2)
                    Me.ValorVista.Text = FormatNumber(0, 2)
                    Me.ValorCheque.Text = FormatNumber(0, 2)
                    Me.TipoPgto.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                Dim ValorParcelado As Double = FormatNumber(NzZero(DsReceber.Tables("Receber").Compute("sum(ValorDocumento)", "")), 2)
                If FormatNumber(NzZero(ValorParcelado), 2) <> FormatNumber(NzZero(Me.ValorFaturar.Text), 2) Then
                    MessageBox.Show("O valor parcelado não pode ser diferente do valor a parcelar, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TravaCaixasFechamento(True)
                    Me.ValorFaturar.Enabled = False
                    Me.ValorVista.Enabled = False
                    Me.ValorCheque.Enabled = False

                    Me.ValorFaturar.Text = FormatNumber(0, 2)
                    Me.ValorVista.Text = FormatNumber(0, 2)
                    Me.ValorCheque.Text = FormatNumber(0, 2)
                    Me.TipoPgto.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
        End If

        If Me.CodPgto.Text = "" Then
            MessageBox.Show("O usuário deve selecionar uma Condição de Pagamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            TravaCaixasFechamento(True)

            Me.Cursor = Cursors.Default
            Me.CodPgto.Focus()
            Exit Sub
        End If
        'Fim das Validaçoes


        'Salvar o Registro Principal


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdUlt As OleDb.OleDbCommand = CNN.CreateCommand

        Cmd.Transaction = Transacao
        CmdUlt.Transaction = Transacao


        Dim Num As New Random
        Dim Tempo As Integer = 0

        Me.Cursor = Cursors.WaitCursor

        Tempo = Num.Next(1, 4000)
        System.Threading.Thread.Sleep(Tempo)
        Try
            'Rotina para Buscar o ultimo Registro
            CmdUlt.CommandText = "Select max(PedidoSequencia) + 1 from Pedido"
            Dim UltimoReg As Integer = NzZero(CmdUlt.ExecuteScalar)
            If NzZero(UltimoReg) = 0 Then UltimoReg = 1
            Me.Venda.Text = UltimoReg.ToString.PadLeft(6, "0")
            'Rotina para Buscar o ultimo Registro Termina aqui


            Dim Sql As String = "INSERT INTO Pedido (PedidoSequencia, DataPedido, Empresa, ValorProduto, TotalPedido, ValorAVista, ValorOutros, ValorAFaturar, LimiteCredito, PedidoTipo, TipoEntrega, Requisicao, CódigoFuncionário, CódigoCliente, PercDesconto, VlrDescProduto, FormaPgto, DiasParcelamento, StatusAndamentos, MediaDesconto, DevNumero, SenhaGerencia, TipoPgto, CodPgto, ContaCR, Contrato, Acrecimo, TotalPropostoPedido, PedOperador, EnderecoEntrega, DataFechamento, Confirmado) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32)"
            Cmd.CommandText = Sql

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CInt(NzZero(Me.Venda.Text))))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataVenda.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.ValorProduto.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.TotalPedido.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.ValorVista.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.ValorCheque.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.ValorFaturar.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.xLimiteSaldo.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.PedidoTipo.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "IMEDIATA"))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", System.DBNull.Value))

            Dim Func() As String = CType(Me.Vendedor.Text, String).Split("-")
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Func(0)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.xCodCliente.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(Me.DescPercentual.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzZero(Me.TotalDesconto.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.FormaPgto.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.DiasParcelamento.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@19", "FINALIZADO"))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.DescPercentual.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.DevNumero.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.SenhaGerencia.Text, 1)))

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Me.TipoPgto.SelectedValue))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Me.CodPgto.SelectedValue))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz("000000", 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Me.Contrato.SelectedValue & ""))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@27", NzZero(Me.Acrecimo.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@28", NzZero(Me.TotalPedido.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.lblOperador.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.EnderecoEntrega.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(DataDia, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@32", True))

            Me.StatusAndamento.Text = "FINALIZADO"

            Cmd.ExecuteNonQuery()
            Transacao.Commit()
            ErroLivre = "Criou o Pedido"
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.Venda.Text)
            CNN.Close()

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Venda.Text = "000000"
            Transacao.Rollback()
            CNN.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Me.Close()
            Me.Dispose()
            Exit Sub
        End Try


        'Dados do cabeçalho Ok começa a Salvar os itens
        CNN.Open()
        Dim DsIT As New DataSet


        Dim SqlItem As String = "Select * From ItensPedido  Where PedidoSequencia = " & CInt(Me.Venda.Text)

        Dim DaIT As New OleDb.OleDbDataAdapter(SqlItem, CNN)
        DaIT.Fill(DsIT, "ItensVenda")

        Dim DrLinha As DataRow

        Try
            For Each DrLinha In DsItens.Tables("Itens").Rows

                Dim TBL As DataTable
                TBL = DsIT.Tables("ItensVenda")

                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()

                DRnovo("PedidoSequencia") = Nz(Me.Venda.Text, 1)
                DRnovo("PedidoInterno") = 0
                DRnovo("CodigoProduto") = Nz(DrLinha("CodigoProduto").ToString, 1)
                DRnovo("Numero") = Nz(DrLinha("Numero").ToString, 1)
                DRnovo("Multiplos") = 0
                DRnovo("Qtd") = Nz(DrLinha("Qtd").ToString, 1)
                DRnovo("ValorUnitario") = Nz(DrLinha("ValorUnitario").ToString, 1)
                DRnovo("Desconto") = Nz(DrLinha("Desconto").ToString, 1)
                DRnovo("ValorDesconto") = Nz(DrLinha("ValorDesconto").ToString, 1)
                DRnovo("CustoMercadoriaVendida") = Nz(DrLinha("CustoMercadoriaVendida").ToString, 1)
                DRnovo("TotalProduto") = Nz(DrLinha("TotalProduto").ToString, 1)
                DRnovo("tpComissao") = "P"
                DRnovo("Comissao") = 0
                DRnovo("ValorComissao") = 0
                DRnovo("QtdRetirada") = 0
                DRnovo("Grupo") = 0
                DRnovo("Ipi") = 0
                DRnovo("ValorIpi") = 0
                DRnovo("QtdPc") = 0
                DRnovo("UserSenhaDesconto") = System.DBNull.Value
                DRnovo("Icms") = 0
                DRnovo("VlrBCicms") = 0
                DRnovo("VlrIcms") = 0
                DRnovo("CFOP") = System.DBNull.Value
                DRnovo("DevolvidoId") = Nz(DrLinha("DevolvidoId").ToString, 1)
                DRnovo("pAcrecimoVenda") = NzZero(DrLinha("pAcrecimoVenda").ToString)
                DRnovo("vAcrecimoVenda") = NzZero(DrLinha("vAcrecimoVenda").ToString)
                DRnovo("pDescontoEspecial") = NzZero(DrLinha("pDescontoEspecial").ToString)
                DRnovo("vDescontoEspecial") = NzZero(DrLinha("vDescontoEspecial").ToString)

                TBL.Rows.Add(DRnovo)

            Next

            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DaIT)
            DaIT.Update(DsIT, "ItensVenda")

            ErroLivre = "Adicionando itens"
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.Venda.Text)

            If Me.PedidoTipo.Text <> "DEVOLUÇÃO" Then
                Try
                    'Fazer Loop no contas a receber para colocar o documento e Pedido
                    If DsReceber.Tables.Contains("Receber") Then
                        Dim I As Integer
                        Dim DocVar As String = String.Empty
                        For I = 0 To DsReceber.Tables("Receber").Rows.Count - 1
                            DsReceber.Tables("Receber").Rows(I).BeginEdit()
                            DocVar = DsReceber.Tables("Receber").Rows(I)("Documento")
                            DocVar = DocVar.Replace("@@", CInt(Me.Venda.Text))
                            DsReceber.Tables("Receber").Rows(I)("Documento") = DocVar
                            DsReceber.Tables("Receber").Rows(I)("PedidoProdutos") = Me.Venda.Text
                            DsReceber.Tables("Receber").Rows(I).EndEdit()
                        Next
                        Dim ObjReceber As New OleDb.OleDbCommandBuilder(DAReceber)
                        DAReceber.Update(DsReceber, "Receber")

                        ErroLivre = "Editou contas a receber colocando o documento de cada parcela"
                        GerarLog(Me.Text, AçãoTP.Adicionou, Me.Venda.Text)

                    End If
                    'Fim do Loop
                    DsReceber.Dispose()
                    CNN.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.btEnviarCaixa.Enabled = True
                    Me.Cursor = Cursors.Default
                    Me.Close()
                    Me.Dispose()
                    Exit Sub
                End Try
            Else
                'é uma devolução: Rotina para criar o Crédito ao Cliente
                If CNN.State = ConnectionState.Closed Then CNN.Open()

                Dim CmdCred As OleDb.OleDbCommand = CNN.CreateCommand

                Try
                    Dim Sql As String = "INSERT INTO ClienteCred (Cliente, DescCred, DataCred, VencimentoCred, ValorCred, Empresa, Confirmado) VALUES (@1, @2, @3, @4, @5, @6, @7)"
                    CmdCred.CommandText = Sql

                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.xCodCliente.Text, 1)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@2", Nz("CREDITO DEV: " & Nz(Me.Venda.Text, 1) & " CLIENTE: " & Me.xNome.Text, 1)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataVenda.Text, 1)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@4", CDate(Me.DataVenda.Text).AddDays(365)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@5", Nz((CDbl(Me.TotalPedido.Text) * -1), 3)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@7", True))
                    CmdCred.ExecuteNonQuery()

                    CNN.Close()
                    ErroLivre = "Gerou credito para o cliente da devolucao nr: " & Me.Venda.Text
                    GerarLog(Me.Text, AçãoTP.Adicionou, Me.Venda.Text)

                    'Confirma o pedido


                Catch ex As Exception
                    MsgBox("Erro no Lançamento do Crédito.", 64, "Validação de Dados")
                    MsgBox(ex.Message, 64, "Validação de Dados")
                    CNN.Close()
                End Try

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Me.Close()
            Me.Dispose()
            Exit Sub
        End Try

        System.Threading.Thread.Sleep(1500) 'Thead criada para que haja tempo para salvar os documentos de Recebimento

        If UsaSellShoes = False Then
            Try
                'Definir Impressão da Venda
                Dim cl As New cImpressaoPedido 'Cria uma nova instância, nela encontra-se os metodos para impressão do pedido.
                cl.CodigoPedido = Convert.ToInt32(Me.Venda.Text) 'passa o codigo da venda para a classe
                cl.Impressao(False) 'Faz a impresão

                'Se houve erro retorna um bolean true e cancela.
                If cl.erro = True Then
                    MessageBox.Show("Erro ao tentar imprimir o pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.btEnviarCaixa.Enabled = True
                    Me.Cursor = Cursors.Default
                    ' Exit Sub
                End If

            Catch ex As Exception
                GerarLog(Me.Text, AçãoTP.Impress, Me.Venda.Text)
            End Try
        Else

            Dim Tel As New Form() ' Create a new instance of the form.
            Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer
            Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

            Tel.Text = "Visualizador de Relatório"
            Tel.Size = New Size(576, 352)
            Tel.HelpButton = False
            Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Tel.MaximizeBox = True
            Tel.MinimizeBox = True
            Tel.ControlBox = True
            Tel.Font = F
            Tel.StartPosition = FormStartPosition.CenterScreen
            Tel.ShowInTaskbar = True
            Tel.WindowState = FormWindowState.Maximized

            Vz.Dock = DockStyle.Fill


            Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados
            'Carrega o relatorio
            Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            VerRelat.Load(DirRelat & "RelSellShoesPedido.rpt")
            VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
            VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))
            VerRelat.DataDefinition.RecordSelectionFormula = "{Pedido.PedidoSequencia} = " & Me.Venda.Text & " and {Pedido.Empresa} = " & CodEmpresa

            Vz.ReportSource = VerRelat
            Tel.Controls.Add(Vz)
            Tel.ShowDialog()

        End If
        MessageBox.Show("Venda efetuada com sucesso e Enviada para o caixa.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ErroLivre = "Pedido efetuado com sucesso"
        GerarLog(Me.Text, AçãoTP.Livre, Me.Venda.Text)
        Me.Cursor = Cursors.Default

        If Vendedor_Fecha_Pedido = True Then
            If NzZero(Me.ValorVista.Text) = 0 Then
                My.Forms.SellShoesFinalizar.ShowDialog()
            End If
            Me.Close()
            Me.Dispose()
        End If

        Me.Close()
        Me.Dispose()

    End Sub

   
    Private Sub xCodCliente_Leave(sender As Object, e As EventArgs) Handles xCodCliente.Leave
        If Me.xCodCliente.Text <> Me.xCodCliente.TextoAntigo Then
            Me.TipoPgto.SelectedIndex = -1
            Me.CodPgto.SelectedIndex = -1
        End If
    End Sub
End Class