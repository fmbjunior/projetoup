Imports System.Data.OleDb
Imports System.IO
Public Class PedidoVendaConfirmarOS

    Dim Ação As New TrfGerais

    Private OperationItensOutros As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Dim cbVendaVista As String = ""
    Dim TipoVenda As String = ""
    Dim cred As New cCreditoCliente


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Dim EstoqueGeral As New EstoqueAtualizar
        If My.Forms.PedidoOS.Visible Then
            EstoqueGeral.Run_AtualizadorEstoquePedido(My.Forms.PedidoOS.PedidoSequencia.Text)
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PedidoVendaConfirmar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizaDadosEmpresa()

        'se a tela de vendas estiver ativa 
        If My.Forms.PedidoOS.Visible Then
            Me.ValorAVista.Text = My.Forms.PedidoOS.ValorAVista.Text
            Me.ValorOutros.Text = My.Forms.PedidoOS.ValorOutros.Text
            Me.ValorAFaturar.Text = My.Forms.PedidoOS.ValorAFaturar.Text
            Me.txt_valor_credito_Descontar.Text = "0,00"

            EncheListaOutros()

            If My.Forms.PedidoOS.TpVenda.Text = "DEVOLUÇÃO" Then
                Me.ValorAVista.Enabled = False
                Me.ContaBalanceteVendaAvista.Enabled = False
                Me.ContaBalanceteVendaAvistaDesc.Enabled = False
                Me.ValorOutros.Enabled = False
                Me.BTParcelaOutros.Enabled = False
                Me.MyListaOutros.Enabled = False
                Me.TotalParcelamentoOutros.Enabled = False
                Me.ValorAFaturar.Focus()
            End If
            cred.Busca_Credito(My.Forms.PedidoOS.CódigoCliente.Text)
            Me.txtvalor_atual_credito.Text = FormatCurrency(cred.Soma_Valor_Credito, 2)

            If (Me.txtvalor_atual_credito.Text) = 0 Or Me.ValorAVista.Text = 0 Then
                Me.txt_valor_credito_Descontar.Enabled = False
            End If
            lblTotalOS.Text = My.Forms.PedidoOS.TPedido.Text
            cred.LocBalancete()

        Else 'caso contrario usa a tela de Materia Prima

            Me.ValorAVista.Text = My.Forms.frmPedidoMP.ValorAVista.Text
            Me.ValorOutros.Text = My.Forms.frmPedidoMP.ValorOutros.Text
            Me.ValorAFaturar.Text = My.Forms.frmPedidoMP.ValorAFaturar.Text
            Me.txt_valor_credito_Descontar.Text = "0,00"

            EncheListaOutros()

            cred.Busca_Credito(My.Forms.frmPedidoMP.CodigoCliente.Text)
            Me.txtvalor_atual_credito.Text = FormatCurrency(cred.Soma_Valor_Credito, 2)

            If (Me.txtvalor_atual_credito.Text) = 0 Or Me.ValorAVista.Text = 0 Then
                Me.txt_valor_credito_Descontar.Enabled = False
            End If
            lblTotalOS.Text = My.Forms.frmPedidoMP.TotalLiquido.Text
            cred.LocBalancete()
        End If

    End Sub

    Public Sub LocalizaDadosEmpresa()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            cbVendaVista = DR.Item("ContaBalanceteVendaAvista") & ""
        End If
        DR.Close()

    End Sub

    Private Sub BTParcelaOutros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTParcelaOutros.Click
        If Me.ValorOutros.Text = 0 Then
            Me.ValorAFaturar.Focus()
            Exit Sub
        End If

        If My.Forms.PedidoOS.Visible Then
            If CDbl(Me.ValorOutros.Text) > 0 Then

                Dim ComissaoFaixaExecutar As Double = 0
                If TipoComissaoVenda = "porFAIXA" Then

                    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                    CNN.Open()

                    Dim SqlEMPRESA As String = "Select * From EmpresaComissaoFaixa Where Empresa = " & CodEmpresa
                    Dim CmdComissaoMedia As New OleDb.OleDbCommand(SqlEMPRESA, CNN)

                    Dim DrEmpresaComissao As OleDb.OleDbDataReader

                    DrEmpresaComissao = CmdComissaoMedia.ExecuteReader
                    DrEmpresaComissao.Read()

                    Dim media_DESCONTO As Double = FormatNumber(CDbl(My.Forms.PedidoOS.MediaDesconto.Text), 2)
                    If DrEmpresaComissao.HasRows = True Then
                        If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa1")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And My.Forms.PedidoOS.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa2")))
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And My.Forms.PedidoOS.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa3")))
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And My.Forms.PedidoOS.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa4")))
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And My.Forms.PedidoOS.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa5")))
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And My.Forms.PedidoOS.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa6")))
                    End If
                    Me.PercentComissao.Text = NzZero(ComissaoFaixaExecutar)
                End If

            End If
        End If

        My.Forms.OSChequePreLancar.ShowDialog()
        EncheListaOutros()
        Me.ValorAFaturar.Focus()
    End Sub

    Public Sub EncheListaOutros()

        If My.Forms.PedidoOS.Visible Then
            If My.Forms.PedidoOS.PedidoSequencia.Text = "" Then Exit Sub

            Me.MyListaOutros.Items.Clear()

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Cmd As New OleDb.OleDbCommand()
            Dim DataReader As OleDb.OleDbDataReader

            With Cmd
                .Connection = CNN
                .CommandTimeout = 0
                .CommandText = "SELECT * FROM ArquivoCheque WHERE Pedido = " & My.Forms.PedidoOS.PedidoSequencia.Text
                .CommandType = CommandType.Text
            End With

            Try
                DataReader = Cmd.ExecuteReader

                Dim Zebrar As Boolean = True
                Dim Somar As Double = 0

                While DataReader.Read
                    If Not IsDBNull(DataReader.Item("Cheque")) Then
                        Dim AA As String = DataReader.Item("Cheque")
                        Dim item1 As New ListViewItem(AA, 0)

                        item1.SubItems.Add(DataReader.Item("CC") & "")
                        item1.SubItems.Add(FormatNumber(DataReader.Item("ValorCh"), 2))
                        item1.SubItems.Add(DataReader.Item("Vencimento"))
                        item1.SubItems.Add(DataReader.Item("EntreguePor") & "")

                        Me.MyListaOutros.Items.AddRange(New ListViewItem() {item1})

                        Somar += Nz(DataReader.Item("ValorCh"), 3)
                        If Zebrar = True Then
                            Me.MyListaOutros.Items.Item(Me.MyListaOutros.Items.Count() - 1).BackColor = Color.LemonChiffon
                            Zebrar = False
                        Else
                            Me.MyListaOutros.Items.Item(Me.MyListaOutros.Items.Count() - 1).BackColor = Color.Azure
                            Zebrar = True
                        End If

                    End If
                End While

                Me.TotalParcelamentoOutros.Text = FormatNumber(Somar, 2)
                DataReader.Close()
                CNN.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
                Exit Sub
            End Try

        Else 'Usa a tela de Pedido Materia Prima

            Me.MyListaOutros.Items.Clear()

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Cmd As New OleDb.OleDbCommand()
            Dim DataReader As OleDb.OleDbDataReader

            With Cmd
                .Connection = CNN
                .CommandTimeout = 0
                .CommandText = "SELECT * FROM ArquivoCheque WHERE PedidoMP = " & My.Forms.frmPedidoMP.NumeroPedido.Text
                .CommandType = CommandType.Text
            End With

            Try
                DataReader = Cmd.ExecuteReader

                Dim Zebrar As Boolean = True
                Dim Somar As Double = 0

                While DataReader.Read
                    If Not IsDBNull(DataReader.Item("Cheque")) Then
                        Dim AA As String = DataReader.Item("Cheque")
                        Dim item1 As New ListViewItem(AA, 0)

                        item1.SubItems.Add(DataReader.Item("CC") & "")
                        item1.SubItems.Add(FormatNumber(DataReader.Item("ValorCh"), 2))
                        item1.SubItems.Add(DataReader.Item("Vencimento"))
                        item1.SubItems.Add(DataReader.Item("EntreguePor") & "")

                        Me.MyListaOutros.Items.AddRange(New ListViewItem() {item1})

                        Somar += Nz(DataReader.Item("ValorCh"), 3)
                        If Zebrar = True Then
                            Me.MyListaOutros.Items.Item(Me.MyListaOutros.Items.Count() - 1).BackColor = Color.LemonChiffon
                            Zebrar = False
                        Else
                            Me.MyListaOutros.Items.Item(Me.MyListaOutros.Items.Count() - 1).BackColor = Color.Azure
                            Zebrar = True
                        End If

                    End If
                End While

                Me.TotalParcelamentoOutros.Text = FormatNumber(Somar, 2)
                DataReader.Close()
                CNN.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
                Exit Sub
            End Try
        End If

    End Sub
    Private Sub confimarOS()


        Dim cxFechado As New CaixaFechado
        cxFechado.CaixaEstaFechado()

        If CDbl(Me.ValorOutros.Text) <> CDbl(Me.TotalParcelamentoOutros.Text) Then
            MsgBox("O Valor do Parcelamento em Ch/Outros esta diferente, Verifique...", 64, "Validação de Dados")
            Me.ValorOutros.Focus()
            Exit Sub
        End If

        If Me.ValorAVista.Text = "" Then
            MsgBox("o Valor a vista não pode ser vazio, se não há faturamento a Vista coloque zero.", 64, "Validação de Dados")
            Me.ValorAVista.Focus()
            Exit Sub
        ElseIf Me.ValorOutros.Text = "" Then
            MsgBox("o Valor Ch/Outros não pode ser vazio, se não há faturamento Ch/Outros coloque zero.", 64, "Validação de Dados")
            Me.ValorOutros.Focus()
            Exit Sub
        ElseIf Me.ValorAFaturar.Text = "" Then
            MsgBox("o Valor a faturar não pode ser vazio, se não há faturamento a Prazo coloque zero.", 64, "Validação de Dados")
            Me.ValorAFaturar.Focus()
            Exit Sub
        End If

        If Me.ValorAVista.Text <> 0 And Me.ContaBalanceteVendaAvista.Text = "" Then
            MessageBox.Show("O usuário deve selecionar a conta de balancete da venda avista.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim DocReceberAvista As String = String.Empty

        If NzZero(txt_valor_credito_Descontar.Text) > NzZero(ValorAVista.Text) Then
            MessageBox.Show("O Crédito a descontar não pode ser maior que o Valor a Vista", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_valor_credito_Descontar.Clear()
            txt_valor_credito_Descontar.Focus()
            Exit Sub
        End If

        If MsgBox("Deseja Finalizar o Pedido/Venda", 36, "Validação de Dados") = 6 Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            If CDbl(Me.ValorAVista.Text) > 0 Then

                Dim ComissaoFaixaExecutar As Double = 0
                If TipoComissaoVenda = "porFAIXA" Then

                    Dim SqlEMPRESA As String = "Select * From EmpresaComissaoFaixa Where Empresa = " & CodEmpresa
                    Dim CmdComissaoMedia As New OleDb.OleDbCommand(SqlEMPRESA, CNN)

                    Dim DrEmpresaComissao As OleDb.OleDbDataReader

                    DrEmpresaComissao = CmdComissaoMedia.ExecuteReader
                    DrEmpresaComissao.Read()

                    Dim media_DESCONTO As Double = FormatNumber(CDbl(NzZero(My.Forms.PedidoOS.MediaDesconto.Text)), 2)
                    If DrEmpresaComissao.HasRows = True Then
                        If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa1")
                        If media_DESCONTO > NzZero(DrEmpresaComissao.Item("pFaixa1")) And My.Forms.PedidoOS.MediaDesconto.Text <= NzZero(DrEmpresaComissao.Item("pFaixa2")) Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa2")))
                        If media_DESCONTO > NzZero(DrEmpresaComissao.Item("pFaixa2")) And My.Forms.PedidoOS.MediaDesconto.Text <= NzZero(DrEmpresaComissao.Item("pFaixa3")) Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa3")))
                        If media_DESCONTO > NzZero(DrEmpresaComissao.Item("pFaixa3")) And My.Forms.PedidoOS.MediaDesconto.Text <= NzZero(DrEmpresaComissao.Item("pFaixa4")) Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa4")))
                        If media_DESCONTO > NzZero(DrEmpresaComissao.Item("pFaixa4")) And My.Forms.PedidoOS.MediaDesconto.Text <= NzZero(DrEmpresaComissao.Item("pFaixa5")) Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa5")))
                        If media_DESCONTO > NzZero(DrEmpresaComissao.Item("pFaixa5")) And My.Forms.PedidoOS.MediaDesconto.Text <= NzZero(DrEmpresaComissao.Item("pFaixa6")) Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa6")))
                    End If
                End If


                'Gerar o parcelamento a Vista do Pedido
                Dim ds As New DataSet()

                Dim Sqlstr As String = String.Empty
                Sqlstr = "SELECT * from Receber Where Documento  = '" & My.Forms.PedidoOS.PedidoSequencia.Text & "-AVISTA' and PedidoProdutos = " & My.Forms.PedidoOS.PedidoSequencia.Text

                Dim DAReceber As New OleDb.OleDbDataAdapter(Sqlstr, CNN)

                DAReceber.Fill(ds, "Receber")
                If ds.Tables("Receber").Rows.Count = 0 Then

                    Dim TBL As DataTable
                    TBL = ds.Tables("Receber")

                    Dim DRnovo As DataRow
                    DRnovo = TBL.NewRow()
                    DRnovo("Documento") = My.Forms.PedidoOS.PedidoSequencia.Text & "-AVISTA"
                    DRnovo("DataDocumento") = My.Forms.PedidoOS.DataPedido.Text
                    DRnovo("ValorDocumento") = CDbl(Me.ValorAVista.Text)
                    DRnovo("ValorLiquido") = CDbl(Me.ValorAVista.Text)
                    DRnovo("LocalPgto") = "CARTEIRA"
                    DRnovo("PedidoProdutos") = My.Forms.PedidoOS.PedidoSequencia.Text
                    DRnovo("CodCliente") = My.Forms.PedidoOS.CódigoCliente.Text
                    DRnovo("Cliente") = My.Forms.PedidoOS.NomeCliente.Text
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("OriginalParcial") = "O"
                    DRnovo("Vencimento") = My.Forms.PedidoOS.DataPedido.Text
                    DRnovo("Recebimento") = My.Forms.PedidoOS.DataPedido.Text
                    DRnovo("Baixado") = True
                    DRnovo("ContaValorBaixado") = Me.ContaBalanceteVendaAvista.Text
                    DRnovo("PercentComissao") = ComissaoFaixaExecutar
                    DRnovo("Virtual") = False
                    TBL.Rows.Add(DRnovo)
                    DocReceberAvista = My.Forms.PedidoOS.PedidoSequencia.Text & "-AVISTA"
                Else
                    Dim DrReceber() As DataRow
                    DrReceber = ds.Tables("Receber").Select("Documento = '" & My.Forms.PedidoOS.PedidoSequencia.Text & "-AVISTA' and PedidoProdutos = " & My.Forms.PedidoOS.PedidoSequencia.Text)

                    DrReceber(0).BeginEdit()
                    DrReceber(0)("Documento") = My.Forms.PedidoOS.PedidoSequencia.Text & "-AVISTA"
                    DrReceber(0)("DataDocumento") = My.Forms.PedidoOS.DataPedido.Text
                    DrReceber(0)("ValorDocumento") = CDbl(Me.ValorAVista.Text)
                    DrReceber(0)("ValorLiquido") = CDbl(Me.ValorAVista.Text)
                    DrReceber(0)("LocalPgto") = "CARTEIRA"
                    DrReceber(0)("PedidoProdutos") = My.Forms.PedidoOS.PedidoSequencia.Text
                    DrReceber(0)("CodCliente") = My.Forms.PedidoOS.CódigoCliente.Text
                    DrReceber(0)("Cliente") = My.Forms.PedidoOS.NomeCliente.Text
                    DrReceber(0)("Empresa") = CodEmpresa
                    DrReceber(0)("OriginalParcial") = "O"
                    DrReceber(0)("Vencimento") = My.Forms.PedidoOS.DataPedido.Text
                    DrReceber(0)("Recebimento") = My.Forms.PedidoOS.DataPedido.Text
                    DrReceber(0)("Baixado") = True
                    DrReceber(0)("ContaValorBaixado") = Me.ContaBalanceteVendaAvista.Text
                    DrReceber(0)("PercentComissao") = ComissaoFaixaExecutar
                    DrReceber(0)("Virtual") = False
                    DrReceber(0).EndEdit()
                    DocReceberAvista = My.Forms.PedidoOS.PedidoSequencia.Text & "-AVISTA"
                End If
                Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
                DAReceber.Update(ds, "Receber")

                ds.Dispose()

            End If

            'Fim da Geraçao do Parcelameto a Vista

            'Verificar se existe faturamento com Cheque
            'If CDbl(Me.ValorOutros.Text) > 0 Then
            '    'Gerar o parcelamento com cheque do Pedido
            '    Dim dsCheque As New DataSet()

            '    Dim Sqlstr As String = String.Empty
            '    Sqlstr = "SELECT * from Receber Where Documento  = 'CHEQUE' and PedidoProdutos = " & My.Forms.PedidoOS.PedidoSequencia.Text

            '    Dim DAReceber As New OleDb.OleDbDataAdapter(Sqlstr, CNN)

            '    DAReceber.Fill(dsCheque, "Receber")


            '    If dsCheque.Tables("Receber").Rows.Count = 0 Then

            '        Dim TBL As DataTable
            '        TBL = dsCheque.Tables("Receber")

            '        Dim DRnovo As DataRow
            '        DRnovo = TBL.NewRow()
            '        DRnovo("Documento") = "CHEQUE"
            '        DRnovo("DataDocumento") = My.Forms.PedidoOS.DataPedido.Text
            '        DRnovo("ValorDocumento") = CDbl(Me.ValorOutros.Text)
            '        DRnovo("ValorLiquido") = CDbl(Me.ValorOutros.Text)
            '        DRnovo("LocalPgto") = "CHEQUE PRE-DATADO"
            '        DRnovo("PedidoProdutos") = My.Forms.PedidoOS.PedidoSequencia.Text
            '        DRnovo("CodCliente") = My.Forms.PedidoOS.CódigoCliente.Text
            '        DRnovo("Cliente") = My.Forms.PedidoOS.NomeCliente.Text
            '        DRnovo("Empresa") = CodEmpresa
            '        DRnovo("OriginalParcial") = "O"
            '        DRnovo("Vencimento") = My.Forms.PedidoOS.DataPedido.Text
            '        DRnovo("Recebimento") = My.Forms.PedidoOS.DataPedido.Text
            '        DRnovo("Baixado") = True
            '        DRnovo("MediaDescontoPedido") = My.Forms.PedidoOS.MediaDesconto.Text
            '        DRnovo("Virtual") = False
            '        TBL.Rows.Add(DRnovo)
            '    Else
            '        Dim DrReceber() As DataRow
            '        DrReceber = dsCheque.Tables("Receber").Select("Documento = 'CHEQUE' and PedidoProdutos = " & My.Forms.PedidoOS.PedidoSequencia.Text)

            '        DrReceber(0).BeginEdit()
            '        DrReceber(0)("Documento") = "CHEQUE"
            '        DrReceber(0)("DataDocumento") = My.Forms.PedidoOS.DataPedido.Text
            '        DrReceber(0)("ValorDocumento") = CDbl(Me.ValorOutros.Text)
            '        DrReceber(0)("ValorLiquido") = CDbl(Me.ValorOutros.Text)
            '        DrReceber(0)("LocalPgto") = "CHEQUE PRE-DATADO"
            '        DrReceber(0)("PedidoProdutos") = My.Forms.PedidoOS.PedidoSequencia.Text
            '        DrReceber(0)("CodCliente") = My.Forms.PedidoOS.CódigoCliente.Text
            '        DrReceber(0)("Cliente") = My.Forms.PedidoOS.NomeCliente.Text
            '        DrReceber(0)("Empresa") = CodEmpresa
            '        DrReceber(0)("OriginalParcial") = "O"
            '        DrReceber(0)("Vencimento") = My.Forms.PedidoOS.DataPedido.Text
            '        DrReceber(0)("Recebimento") = My.Forms.PedidoOS.DataPedido.Text
            '        DrReceber(0)("Baixado") = True
            '        DrReceber(0)("MediaDescontoPedido") = My.Forms.PedidoOS.MediaDesconto.Text
            '        DrReceber(0)("Virtual") = False
            '        DrReceber(0).EndEdit()

            '    End If
            '    Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
            '    DAReceber.Update(dsCheque, "Receber")

            '    dsCheque.Dispose()
            'End If
            'Fim


            Dim Sql As String = ""

            Dim Transacao As OleDbTransaction = CNN.BeginTransaction()
            Dim Cmd As OleDbCommand = CNN.CreateCommand()
            Dim CmdAvista As OleDbCommand = CNN.CreateCommand
            Dim CmdAtItens As OleDbCommand = CNN.CreateCommand
            Dim CmdEstoque As OleDbCommand = CNN.CreateCommand
            Dim CmdComissao As OleDbCommand = CNN.CreateCommand
            Dim CmdComissaoItemAgrupada As OleDbCommand = CNN.CreateCommand
            Dim CmdComissaoAVISTA As OleDbCommand = CNN.CreateCommand
            Dim CmdEmpresaComissao As OleDbCommand = CNN.CreateCommand
            Dim CmdAtReceberVirtual As OleDbCommand = CNN.CreateCommand


            Cmd.Transaction = Transacao
            CmdAvista.Transaction = Transacao
            CmdAtItens.Transaction = Transacao
            CmdEstoque.Transaction = Transacao
            CmdComissao.Transaction = Transacao
            CmdComissaoItemAgrupada.Transaction = Transacao
            CmdComissaoAVISTA.Transaction = Transacao
            CmdEmpresaComissao.Transaction = Transacao
            CmdAtReceberVirtual.Transaction = Transacao


            Try
                If Me.ValorAVista.Text <> 0 Then
                    Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                    CmdAvista.CommandText = Sql

                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(My.Forms.PedidoOS.PedidoSequencia.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@6", Nz("C", 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(My.Forms.PedidoOS.NomeCliente.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("RECEB. AVISTA PED. " & My.Forms.PedidoOS.PedidoSequencia.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@12", Me.ValorAVista.Text))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(CaixaAtivo, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.ContaBalanceteVendaAvista.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@17", "PEDIDOOS"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@18", My.Forms.PedidoOS.PedidoSequencia.Text))
                    CmdAvista.ExecuteNonQuery() 'faz a persistencia no banco de dados

                End If

                'Atualizar o pedido confirmando
                Dim StatusPed As String
                If My.Forms.PedidoOS.TipoEntrega.Text = "IMEDIATA" Then
                    'Entrega Imediata atualiza a quantidade de entrega para quantidade do item
                    Sql = "UPDATE ItensPedido SET ItensPedido.QtdRetirada = [Qtd] WHERE (((ItensPedido.PedidoSequencia)=" & My.Forms.PedidoOS.PedidoSequencia.Text & "));"
                    CmdAtItens.CommandText = Sql
                    CmdAtItens.ExecuteNonQuery()

                    StatusPed = "FINALIZADO"
                Else
                    StatusPed = "INICIAL"
                End If

                Sql = "Update Pedido  set ValorAVista = @1, ValorOutros = @2, ValorAFaturar = @3, Confirmado = @4, DataFechamento = @5, StatusAndamentos = @6 Where PedidoSequencia = " & My.Forms.PedidoOS.PedidoSequencia.Text
                Cmd.CommandText = Sql
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.ValorAVista.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.ValorOutros.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ValorAFaturar.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", True))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", StatusPed))
                Cmd.ExecuteNonQuery()

                'Atualizar de virtual para nao virtual
                Sql = "UPDATE Receber SET Receber.Virtual = False WHERE (((Receber.PedidoProdutos)= " & My.Forms.PedidoOS.PedidoSequencia.Text & " ) AND ((Receber.Empresa)=" & CodEmpresa & "));"
                CmdAtReceberVirtual.CommandText = Sql
                CmdAtReceberVirtual.ExecuteNonQuery()


                'Atualizar estoque Tabela EstoqueUp
                Dim TpEst As String = "S"
                If My.Forms.PedidoOS.TipoEntrega.Text = "IMEDIATA" Then
                    Dim NCliente As String = My.Forms.PedidoOS.NomeCliente.Text
                    If My.Forms.PedidoOS.TpVenda.Text = "DEVOLUÇÃO" Then
                        NCliente = NCliente & " **DEVOLUÇÃO**"
                        TpEst = "D"
                    End If
                    Sql = "INSERT INTO EstoqueUP (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc) SELECT ItensPedido.CodigoProduto, [Qtd]*-1 AS QtdEst, '" & TpEst & "' AS Expr1, 0 AS Expr2, Pedido.DataFechamento, Pedido.PedidoSequencia, 'PedidoOS' AS Expr3,'" & NCliente & "' AS Expr4, '" & My.Forms.PedidoOS.PedidoSequencia.Text & "' As Expr5 FROM (ItensPedido INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & My.Forms.PedidoOS.PedidoSequencia.Text & ") AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Produtos.ControlaEstoque)='SIM'));"
                    CmdEstoque.CommandText = Sql
                    CmdEstoque.ExecuteNonQuery()
                End If

                'Atualiza comissoes de Venda
                'Atualiza comissao de venda do item se o desconto é por linha

                If TipoComissaoVenda = "P" Then
                    Sql = "UPDATE ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto SET ItensPedido.Comissao = [ComissaoVenda], ItensPedido.ValorComissao = (([TotalProduto]-[ValorDesconto])*[ComissaoVenda])/100, ItensPedido.tpComissao = 'P' WHERE (((ItensPedido.PedidoSequencia) = " & My.Forms.PedidoOS.PedidoSequencia.Text & "));"
                    CmdComissao.CommandText = Sql
                    CmdComissao.ExecuteNonQuery()

                    Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao ) SELECT Pedido.DataFechamento AS DTFecha, Pedido.DataFechamento, Pedido.CódigoFuncionário, ItensPedido.PedidoSequencia, 0 AS Produto, 0 AS [Percent], 0 AS VlrDoc, Sum(ItensPedido.ValorComissao) AS SomaDeValorComissao, 'P' AS TpComissao FROM (ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia GROUP BY Pedido.DataFechamento, Pedido.DataFechamento, Pedido.CódigoFuncionário, ItensPedido.PedidoSequencia, 0, 0, 0,  'P' HAVING (((ItensPedido.PedidoSequencia)=" & My.Forms.PedidoOS.PedidoSequencia.Text & "));"
                    CmdComissaoItemAgrupada.CommandText = Sql
                    CmdComissaoItemAgrupada.ExecuteNonQuery()
                End If
                If TipoComissaoVenda = "V" Then
                    Sql = "INSERT INTO FuncionarioComissao ( PedidoVenda, ValorDocumento, DataLancamento, DataDocumento, Funcionario, Produto, Percentual, ValorComissao, TipoComissao, Pago ) SELECT Pedido.PedidoSequencia, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.DataPedido, Pedido.CódigoFuncionário, 0 AS Produto, Funcionários.ComissaoVenda, ([TotalPedido]*[ComissaoVenda])/100 AS Comissao, 'V' AS TpComissao, False AS Pago FROM Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.PedidoSequencia)=" & My.Forms.PedidoOS.PedidoSequencia.Text & "));"
                    CmdComissao.CommandText = Sql
                    CmdComissao.ExecuteNonQuery()
                End If
                If TipoComissaoVenda = "R" Then 'esta rotina é apenas para recebimento a vista
                    Sql = "INSERT INTO FuncionarioComissao ( PedidoVenda, ValorDocumento, DataLancamento, DataDocumento, Funcionario, Produto, Percentual, ValorComissao, TipoComissao, Pago ) SELECT Pedido.PedidoSequencia, Pedido.ValorAVista, Pedido.DataFechamento, Pedido.DataPedido, Pedido.CódigoFuncionário, 0 AS Produto, Funcionários.ComissaoVenda, ([ValorAVista]*[ComissaoVenda])/100 AS Comissao, 'R' AS TpComissao, False AS Pago FROM Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.PedidoSequencia)=" & My.Forms.PedidoOS.PedidoSequencia.Text & "));"
                    CmdComissao.CommandText = Sql
                    CmdComissao.ExecuteNonQuery()
                End If

                If TipoComissaoVenda = "porFAIXA" Then

                    CmdEmpresaComissao.CommandText = "Select * From EmpresaComissaoFaixa Where Empresa = " & CodEmpresa
                    Dim DrEmpresaComissao As OleDb.OleDbDataReader

                    DrEmpresaComissao = CmdEmpresaComissao.ExecuteReader
                    DrEmpresaComissao.Read()

                    Dim media_DESCONTO As Double = FormatNumber(CDbl(NzZero(My.Forms.PedidoOS.MediaDesconto.Text)), 2)
                    Dim ComissaoFaixaExecutar As Double = 0
                    Dim ComissaoFaixaExecutarAVISTA As Double = 0
                    If DrEmpresaComissao.HasRows = True Then
                        If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa1")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa2")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa3")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa4")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa5")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa6")

                        If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa1")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa2")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa3")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa4")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa5")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And NzZero(My.Forms.PedidoOS.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa6")
                    End If

                    If CDbl(NzZero(Me.ValorAVista.Text)) <> 0 Then
                        Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, Pago, ComissaoFaturamento, OndeVeio, IdOrigem, Documento, DescComissao ) Values ( #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#,#" & Format(CDate(My.Forms.PedidoOS.DataPedido.Text), "MM/dd/yyyy") & "# ," & My.Forms.PedidoOS.CódigoFuncionário.Text & " ," & My.Forms.PedidoOS.PedidoSequencia.Text & " , 0 ,'" & ComissaoFaixaExecutarAVISTA & "' ,'" & Me.ValorAVista.Text & "' ,'" & CDbl((CDbl(Me.ValorAVista.Text) * CDbl(ComissaoFaixaExecutarAVISTA)) / 100) & "' ,'porFAIXA' , False, False, 'PEDIDOOS', " & My.Forms.PedidoOS.PedidoSequencia.Text & ", '" & DocReceberAvista & "', 'RECEB. AVISTA DOC: " & DocReceberAvista & "' )"
                        CmdComissaoAVISTA.CommandText = Sql
                        CmdComissaoAVISTA.ExecuteNonQuery()
                    End If

                    If CDbl(DrEmpresaComissao.Item("cFat")) > 0 Then
                        Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, Pago, ComissaoFaturamento, OndeVeio, IdOrigem, Documento, DescComissao ) SELECT #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# AS DataLancamento, Pedido.DataPedido, Pedido.CódigoFuncionário, Pedido.PedidoSequencia, 0 AS Produto, EmpresaComissaoFaixa.cFat, Pedido.TotalPedido, ([TotalPedido]*[cFat])/100 AS ValorComissao, 'porFAIXA' AS TipoComissao, False AS Pago, True AS éFaturamento, 'PEDIDOOS', " & My.Forms.PedidoOS.PedidoSequencia.Text & ", '" & My.Forms.PedidoOS.PedidoSequencia.Text & "', 'COMISSAO FAT. PED. OS: " & My.Forms.PedidoOS.PedidoSequencia.Text & "' FROM Pedido INNER JOIN EmpresaComissaoFaixa ON Pedido.Empresa = EmpresaComissaoFaixa.Empresa WHERE (((Pedido.PedidoSequencia)=" & My.Forms.PedidoOS.PedidoSequencia.Text & "));"
                        CmdComissao.CommandText = Sql
                        CmdComissao.ExecuteNonQuery()
                    End If

                End If


                If NzZero(Me.txt_valor_credito_Descontar.Text) > 0 Then
                    'Faz os devidos lançamentos referente ao credito
                    Dim CmdCred As OleDb.OleDbCommand = CNN.CreateCommand
                    Dim CmdCaixa As OleDb.OleDbCommand = CNN.CreateCommand
                    Dim CmdReceber As OleDb.OleDbCommand = CNN.CreateCommand
                    Dim cmd_balancete As OleDb.OleDbCommand = CNN.CreateCommand

                    CmdCred.Transaction = Transacao
                    CmdCaixa.Transaction = Transacao
                    cmd_balancete.Transaction = Transacao
                    CmdReceber.Transaction = Transacao
                    'Debita o Credito
                    Dim sSql As String = "INSERT INTO ClienteCred (Cliente, DescCred, DataCred, VencimentoCred, ValorCred, Empresa, Confirmado,Pedido) VALUES (@1, @2, @3, @4, @5, @6, @7,@8)"
                    CmdCred.CommandText = sSql
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@1", My.Forms.PedidoOS.CódigoCliente.Text))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@2", "PED:-" & My.Forms.PedidoOS.PedidoSequencia.Text & " PGTO DE CREDITO:-" & My.Forms.PedidoOS.NomeCliente.Text))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@3", CStr(DataDia)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@4", CStr(DataDia)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@5", (txt_valor_credito_Descontar.Text * -1)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@7", True))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@8", My.Forms.PedidoOS.PedidoSequencia.Text))
                    CmdCred.ExecuteNonQuery()

                    Dim IdCredito As Integer
                    CmdCred.CommandText = "SELECT @@IDENTITY"
                    IdCredito = CmdCred.ExecuteScalar.ToString

                    'Debita o Caixa
                    sSql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                    CmdCaixa.CommandText = sSql
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(CStr(DataDia), 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@4", "CRED-PED" & My.Forms.PedidoOS.PedidoSequencia.Text))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(CStr(DataDia), 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@6", Nz("D", 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(My.Forms.PedidoOS.NomeCliente.Text, 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("PGTO DE CREDITO: " & UCase(My.Forms.PedidoOS.NomeCliente.Text), 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@12", (txt_valor_credito_Descontar.Text * -1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(CaixaAtivo, 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@15", Nz("000000", 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@17", "PEDIDOOS"))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@18", My.Forms.PedidoOS.PedidoSequencia.Text))
                    CmdCaixa.ExecuteNonQuery()

                    'Debita a Conta balancete
                    ''inserir o credito no balancete
                    sSql = "INSERT INTO BALANCETELANC (CONTABALANCETE,CONTACR,DATALANCAMENTO,DOCUMENTO,VALORDOCUMENTO,HISTORICO,EMPRESA,PRGLANCAMENTO,IDPROCURA) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9)"
                    cmd_balancete.CommandText = sSql
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@1", Me.ContaBalanceteVendaAvista.Text))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(cred.ContaCR, 1)))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(CStr(DataDia), 1)))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@4", "CRED-PED" & My.Forms.PedidoOS.PedidoSequencia.Text))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(txt_valor_credito_Descontar.Text, 1) * -1))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@6", "BAIXA CRED REF. PEDIDO. " & My.Forms.PedidoOS.PedidoSequencia.Text))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@7", CodEmpresa))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@8", "PEDIDOOS"))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@9", My.Forms.PedidoOS.PedidoSequencia.Text))
                    cmd_balancete.ExecuteNonQuery()

                    'inserir o credito no contas a receber
                    CmdReceber.CommandText = "INSERT INTO Receber (Documento,DataDocumento,ValorDocumento,ValorLiquido,LocalPgto,CodCliente,Cliente,Empresa,OriginalParcial,Vencimento,Recebimento,Baixado,ContaValorBaixado,Virtual,Referencia) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15)"
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@1", "CRED-PED" & My.Forms.PedidoOS.PedidoSequencia.Text))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(CStr(DataDia), 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(txt_valor_credito_Descontar.Text, 1) * -1))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(txt_valor_credito_Descontar.Text, 1) * -1))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@5", "CARTEIRA"))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(My.Forms.PedidoOS.CódigoCliente.Text, 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(My.Forms.PedidoOS.NomeCliente.Text, 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@9", "O"))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(CStr(DataDia), 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(CStr(DataDia), 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@12", True))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ContaBalanceteVendaAvista.Text, 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@14", False))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@15", "Baixa de crédito ref. PED" & Nz(My.Forms.PedidoOS.PedidoSequencia.Text, 1)))
                    CmdReceber.ExecuteNonQuery()
                End If 'fim  do lancamento do credito

                Transacao.Commit()


                My.Forms.PedidoOS.Confirmado.Checked = True
                My.Forms.PedidoOS.DataFechamento.Text = DataDia
                My.Forms.PedidoOS.ConfImg.Visible = True

                Try
                    If ReciboAVista = True Then
                        'Imprimir recibo a vista
                        If CDbl(Me.ValorAVista.Text) > CDbl(FormatCurrency(0, 2)) Then
                            RelatorioCarregar = "RelReciboVendaVista"
                            My.Forms.VisualizadorRelatorio.ShowDialog()

                        End If
                    End If
                Catch exc As Exception
                    MsgBox(exc.Message, 64, "Validação de Dados")
                End Try


                If My.Forms.PedidoOS.TpVenda.Text <> "DEVOLUÇÃO" Then
                    If EmitirDpPedido = True Then
                        If MsgBox("Deseja imprimir a(s) Duplicata(s)/Nota Promissoria(s)", 36, "Validação de Dados") = 6 Then
                            If ModeloDuplicata = "DUPLICATA" Then
                                RelatorioCarregar = "ImpressDP"
                                My.Forms.VisualizadorRelatorio.ShowDialog()
                            End If
                            If ModeloDuplicata = "NOTA PROMISSORIA" Then
                                RelatorioCarregar = "ImpressNP"
                                My.Forms.VisualizadorRelatorio.ShowDialog()
                            End If
                        End If
                    End If
                End If

                MsgBox("Pedido confirmado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, My.Forms.PedidoOS.PedidoSequencia.Text)

                If My.Forms.PedidoOS.TipoEntrega.Text = "IMEDIATA" Then
                    'Atualizar o Estoque do Cadastro de Produtos
                    Dim EstoqueGeral As New EstoqueAtualizar
                    EstoqueGeral.Run_AtualizadorEstoquePedido(My.Forms.PedidoOS.PedidoSequencia.Text)
                End If

                My.Forms.PedidoOS.TabPedido.SelectedTab = My.Forms.PedidoOS.TabCliente


            Catch ex As Exception
                Transacao.Rollback()
                MsgBox(ex.Message, 64, "Validação de Dados")
                MsgBox("Erro ao confirmar o Pedido, tente novamente confirmar ou consulte o administrador.", 64, "Validação de Dados")
            End Try
            CNN.Close()
            Me.Close()
            Me.Dispose()
        End If
    End Sub
    Private Sub confirmarMP()

        Dim cxFechado As New CaixaFechado
        cxFechado.CaixaEstaFechado()

        If CDbl(Me.ValorOutros.Text) <> CDbl(Me.TotalParcelamentoOutros.Text) Then
            MsgBox("O Valor do Parcelamento em Ch/Outros esta diferente, Verifique...", 64, "Validação de Dados")
            Me.ValorOutros.Focus()
            Exit Sub
        End If

        If Me.ValorAVista.Text = "" Then
            MsgBox("o Valor a vista não pode ser vazio, se não há faturamento a Vista coloque zero.", 64, "Validação de Dados")
            Me.ValorAVista.Focus()
            Exit Sub
        ElseIf Me.ValorOutros.Text = "" Then
            MsgBox("o Valor Ch/Outros não pode ser vazio, se não há faturamento Ch/Outros coloque zero.", 64, "Validação de Dados")
            Me.ValorOutros.Focus()
            Exit Sub
        ElseIf Me.ValorAFaturar.Text = "" Then
            MsgBox("o Valor a faturar não pode ser vazio, se não há faturamento a Prazo coloque zero.", 64, "Validação de Dados")
            Me.ValorAFaturar.Focus()
            Exit Sub
        End If

        If Me.ValorAVista.Text <> 0 And Me.ContaBalanceteVendaAvista.Text = "" Then
            MessageBox.Show("O usuário deve selecionar a conta de balancete da venda avista.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim DocReceberAvista As String = String.Empty

        If NzZero(txt_valor_credito_Descontar.Text) > NzZero(ValorAVista.Text) Then
            MessageBox.Show("O Crédito a descontar não pode ser maior que o Valor a Vista", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_valor_credito_Descontar.Clear()
            txt_valor_credito_Descontar.Focus()
            Exit Sub
        End If

        If MsgBox("Deseja Finalizar o Pedido/Venda", 36, "Validação de Dados") = 6 Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            If CDbl(Me.ValorAVista.Text) > 0 Then
                'Gerar o parcelamento a Vista do Pedido
                Dim ds As New DataSet()

                Dim Sqlstr As String = String.Empty
                Sqlstr = "SELECT * from Receber Where Documento  = '" & My.Forms.frmPedidoMP.NumeroPedido.Text & "-AVISTA-MP' and PedidoMP = " & My.Forms.frmPedidoMP.NumeroPedido.Text

                Dim DAReceber As New OleDb.OleDbDataAdapter(Sqlstr, CNN)

                DAReceber.Fill(ds, "Receber")
                If ds.Tables("Receber").Rows.Count = 0 Then

                    Dim TBL As DataTable
                    TBL = ds.Tables("Receber")

                    Dim DRnovo As DataRow
                    DRnovo = TBL.NewRow()
                    DRnovo("Documento") = My.Forms.frmPedidoMP.NumeroPedido.Text & "-AVISTA-MP"
                    DRnovo("DataDocumento") = My.Forms.frmPedidoMP.DataFechamento.Text
                    DRnovo("ValorDocumento") = CDbl(Me.ValorAVista.Text)
                    DRnovo("ValorLiquido") = CDbl(Me.ValorAVista.Text)
                    DRnovo("LocalPgto") = "CARTEIRA"
                    DRnovo("PedidoMP") = My.Forms.frmPedidoMP.NumeroPedido.Text
                    DRnovo("CodCliente") = My.Forms.frmPedidoMP.CodigoCliente.Text
                    DRnovo("Cliente") = My.Forms.frmPedidoMP.NomeCliente.Text
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("OriginalParcial") = "O"
                    DRnovo("Vencimento") = My.Forms.frmPedidoMP.DataFechamento.Text
                    DRnovo("Recebimento") = My.Forms.frmPedidoMP.DataFechamento.Text
                    DRnovo("Baixado") = True
                    DRnovo("ContaValorBaixado") = Me.ContaBalanceteVendaAvista.Text
                    DRnovo("PercentComissao") = 0
                    DRnovo("Virtual") = False
                    TBL.Rows.Add(DRnovo)
                    DocReceberAvista = My.Forms.frmPedidoMP.NumeroPedido.Text & "-AVISTA-MP"
                Else
                    Dim DrReceber() As DataRow
                    DrReceber = ds.Tables("Receber").Select("Documento = '" & My.Forms.frmPedidoMP.NumeroPedido.Text & "-AVISTA-MP' and PedidoMP = " & My.Forms.frmPedidoMP.NumeroPedido.Text)

                    DrReceber(0).BeginEdit()
                    DrReceber(0)("Documento") = My.Forms.frmPedidoMP.NumeroPedido.Text & "-AVISTA-MP"
                    DrReceber(0)("DataDocumento") = My.Forms.frmPedidoMP.DataFechamento.Text
                    DrReceber(0)("ValorDocumento") = CDbl(Me.ValorAVista.Text)
                    DrReceber(0)("ValorLiquido") = CDbl(Me.ValorAVista.Text)
                    DrReceber(0)("LocalPgto") = "CARTEIRA"
                    DrReceber(0)("PedidoMP") = My.Forms.frmPedidoMP.NumeroPedido.Text
                    DrReceber(0)("CodCliente") = My.Forms.frmPedidoMP.CodigoCliente.Text
                    DrReceber(0)("Cliente") = My.Forms.frmPedidoMP.NomeCliente.Text
                    DrReceber(0)("Empresa") = CodEmpresa
                    DrReceber(0)("OriginalParcial") = "O"
                    DrReceber(0)("Vencimento") = My.Forms.frmPedidoMP.DataFechamento.Text
                    DrReceber(0)("Recebimento") = My.Forms.frmPedidoMP.DataFechamento.Text
                    DrReceber(0)("Baixado") = True
                    DrReceber(0)("ContaValorBaixado") = Me.ContaBalanceteVendaAvista.Text
                    DrReceber(0)("PercentComissao") = 0
                    DrReceber(0)("Virtual") = False
                    DrReceber(0).EndEdit()
                    DocReceberAvista = My.Forms.frmPedidoMP.NumeroPedido.Text & "-AVISTA-MP"
                End If
                Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
                DAReceber.Update(ds, "Receber")

                ds.Dispose()

            End If

            'Fim


            Dim Sql As String = ""

            Dim Transacao As OleDbTransaction = CNN.BeginTransaction()
            Dim Cmd As OleDbCommand = CNN.CreateCommand()
            Dim CmdAvista As OleDbCommand = CNN.CreateCommand
            Dim CmdAtItens As OleDbCommand = CNN.CreateCommand
            Dim CmdEstoque As OleDbCommand = CNN.CreateCommand
            Dim CmdComissao As OleDbCommand = CNN.CreateCommand
            Dim CmdComissaoItemAgrupada As OleDbCommand = CNN.CreateCommand
            Dim CmdComissaoAVISTA As OleDbCommand = CNN.CreateCommand
            Dim CmdEmpresaComissao As OleDbCommand = CNN.CreateCommand
            Dim CmdAtReceberVirtual As OleDbCommand = CNN.CreateCommand


            Cmd.Transaction = Transacao
            CmdAvista.Transaction = Transacao
            CmdAtItens.Transaction = Transacao
            CmdEstoque.Transaction = Transacao
            CmdComissao.Transaction = Transacao
            CmdComissaoItemAgrupada.Transaction = Transacao
            CmdComissaoAVISTA.Transaction = Transacao
            CmdEmpresaComissao.Transaction = Transacao
            CmdAtReceberVirtual.Transaction = Transacao


            Try
                If Me.ValorAVista.Text <> 0 Then
                    Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                    CmdAvista.CommandText = Sql

                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(My.Forms.frmPedidoMP.NumeroPedido.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@6", Nz("C", 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(My.Forms.frmPedidoMP.NomeCliente.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("RECEB. AVISTA PEDMP. " & My.Forms.frmPedidoMP.NumeroPedido.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@12", Me.ValorAVista.Text))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(CaixaAtivo, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.ContaBalanceteVendaAvista.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@17", "PEDIDOMP"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@18", My.Forms.frmPedidoMP.NumeroPedido.Text))
                    CmdAvista.ExecuteNonQuery() 'faz a persistencia no banco de dados

                End If

                'Atualizar o pedido confirmando

                Sql = "Update PedidoMateriaPrima  set ValorAVista = @1, ValorOutros = @2, ValorAFaturar = @3, fechado = @4, DataFechamento = @5, Status = @6 Where NumeroPedido = " & My.Forms.frmPedidoMP.NumeroPedido.Text & " and Modelo='" & My.Forms.frmPedidoMP.ModeloVenda.Text.Substring(0, 1) & "'"
                Cmd.CommandText = Sql
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.ValorAVista.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.ValorOutros.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ValorAFaturar.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", True))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", "FECHADO"))
                Cmd.ExecuteNonQuery()

                'Atualizar de virtual para nao virtual
                Sql = "UPDATE Receber SET Receber.Virtual = False WHERE (((Receber.Pedidomp)= " & My.Forms.frmPedidoMP.NumeroPedido.Text & " ) AND ((Receber.Empresa)=" & CodEmpresa & "));"
                CmdAtReceberVirtual.CommandText = Sql
                CmdAtReceberVirtual.ExecuteNonQuery()



                If NzZero(Me.txt_valor_credito_Descontar.Text) > 0 Then
                    'Faz os devidos lançamentos referente ao credito
                    Dim CmdCred As OleDb.OleDbCommand = CNN.CreateCommand
                    Dim CmdCaixa As OleDb.OleDbCommand = CNN.CreateCommand
                    Dim CmdReceber As OleDb.OleDbCommand = CNN.CreateCommand
                    Dim cmd_balancete As OleDb.OleDbCommand = CNN.CreateCommand

                    CmdCred.Transaction = Transacao
                    CmdCaixa.Transaction = Transacao
                    cmd_balancete.Transaction = Transacao
                    CmdReceber.Transaction = Transacao
                    'Debita o Credito
                    Dim sSql As String = "INSERT INTO ClienteCred (Cliente, DescCred, DataCred, VencimentoCred, ValorCred, Empresa, Confirmado,Pedido) VALUES (@1, @2, @3, @4, @5, @6, @7,@8)"
                    CmdCred.CommandText = sSql
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@1", My.Forms.frmPedidoMP.CodigoCliente.Text))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@2", "PED:-" & My.Forms.frmPedidoMP.NumeroPedido.Text & " PGTO DE CREDITO:-" & My.Forms.frmPedidoMP.NomeCliente.Text))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@3", CStr(DataDia)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@4", CStr(DataDia)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@5", (txt_valor_credito_Descontar.Text * -1)))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@7", True))
                    CmdCred.Parameters.Add(New OleDb.OleDbParameter("@8", My.Forms.frmPedidoMP.NumeroPedido.Text))
                    CmdCred.ExecuteNonQuery()

                    Dim IdCredito As Integer
                    CmdCred.CommandText = "SELECT @@IDENTITY"
                    IdCredito = CmdCred.ExecuteScalar.ToString

                    'Debita o Caixa
                    sSql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                    CmdCaixa.CommandText = sSql
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(CStr(DataDia), 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@4", "CRED-PED" & My.Forms.frmPedidoMP.NumeroPedido.Text))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(CStr(DataDia), 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@6", Nz("D", 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(My.Forms.frmPedidoMP.NomeCliente.Text, 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("PGTO DE CREDITO: " & UCase(My.Forms.frmPedidoMP.NomeCliente.Text), 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@12", (txt_valor_credito_Descontar.Text * -1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(CaixaAtivo, 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@15", Nz("000000", 1)))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@17", "PEDIDOMP"))
                    CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@18", My.Forms.frmPedidoMP.NumeroPedido.Text))
                    CmdCaixa.ExecuteNonQuery()

                    'Debita a Conta balancete
                    ''inserir o credito no balancete
                    sSql = "INSERT INTO BALANCETELANC (CONTABALANCETE,CONTACR,DATALANCAMENTO,DOCUMENTO,VALORDOCUMENTO,HISTORICO,EMPRESA,PRGLANCAMENTO,IDPROCURA) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9)"
                    cmd_balancete.CommandText = sSql
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@1", Me.ContaBalanceteVendaAvista.Text))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(cred.ContaCR, 1)))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(CStr(DataDia), 1)))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@4", "CRED-PED" & My.Forms.frmPedidoMP.NumeroPedido.Text))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(txt_valor_credito_Descontar.Text, 1) * -1))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@6", "BAIXA CRED REF. PEDIDO. " & My.Forms.frmPedidoMP.NumeroPedido.Text))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@7", CodEmpresa))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@8", "PEDIDOMP"))
                    cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@9", My.Forms.frmPedidoMP.NumeroPedido.Text))
                    cmd_balancete.ExecuteNonQuery()

                    'inserir o credito no contas a receber
                    CmdReceber.CommandText = "INSERT INTO Receber (Documento,DataDocumento,ValorDocumento,ValorLiquido,LocalPgto,CodCliente,Cliente,Empresa,OriginalParcial,Vencimento,Recebimento,Baixado,ContaValorBaixado,Virtual,Referencia) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15)"
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@1", "CRED-PED" & My.Forms.frmPedidoMP.NumeroPedido.Text))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(CStr(DataDia), 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(txt_valor_credito_Descontar.Text, 1) * -1))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(txt_valor_credito_Descontar.Text, 1) * -1))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@5", "CARTEIRA"))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(My.Forms.frmPedidoMP.CodigoCliente.Text, 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(My.Forms.frmPedidoMP.NomeCliente.Text, 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@9", "O"))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(CStr(DataDia), 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(CStr(DataDia), 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@12", True))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ContaBalanceteVendaAvista.Text, 1)))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@14", False))
                    CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@15", "Baixa de crédito ref. PED-MP" & Nz(My.Forms.frmPedidoMP.NumeroPedido.Text, 1)))
                    CmdReceber.ExecuteNonQuery()
                End If 'fim  do lancamento do credito

                Transacao.Commit()


                My.Forms.frmPedidoMP.chkConfirmado.Checked = True
                My.Forms.frmPedidoMP.status.Text = "FECHADO"
                My.Forms.frmPedidoMP.status.ForeColor = Color.Red

                Try
                    If ReciboAVista = True Then
                        'Imprimir recibo a vista
                        If CDbl(Me.ValorAVista.Text) > CDbl(FormatCurrency(0, 2)) Then
                            RelatorioCarregar = "RelReciboVendaVistaMP.rpt"


                            Dim filtro As String = "{PedidoMateriaPrima.NumeroPedido} =" & CInt(My.Forms.frmPedidoMP.NumeroPedido.Text) & " and {PedidoMateriaPrima.Modelo} ='" & My.Forms.frmPedidoMP.ModeloVenda.Text.Substring(0, 1) & "'"
                            Dim f As New ClassView.cView
                            f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "", filtro)


                        End If
                    End If
                Catch exc As Exception
                    MsgBox(exc.Message, 64, "Validação de Dados")
                End Try

                MsgBox("Pedido confirmado com sucesso", 64, "Validação de Dados")
                My.Forms.frmPedidoMP.btnSalvaEditar.Enabled = False
                My.Forms.frmPedidoMP.btnConfirmar.Enabled = False
                My.Forms.frmPedidoMP.Value = frmPedidoMP.TagType.eEditar
                GerarLog(Me.Text, AçãoTP.Confirmou, My.Forms.frmPedidoMP.NumeroPedido.Text)

            Catch ex As Exception
                Transacao.Rollback()
                MsgBox(ex.Message, 64, "Validação de Dados")
                MsgBox("Erro ao confirmar o Pedido, tente novamente confirmar ou consulte o administrador.", 64, "Validação de Dados")
            End Try
            CNN.Close()
            Me.Close()
            Me.Dispose()
        End If
    End Sub
    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

        If My.Forms.PedidoOS.Visible Then
            confimarOS()
        Else
            confirmarMP()
        End If

    End Sub

    Private Sub ValorAVista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ValorAVista.KeyDown
        'Se o character não for numérico ou backspace, ignorar o que foi digitado B.
        If Not IsNumeric(Chr(e.KeyCode)) And e.KeyCode <> 8 And e.KeyCode <> 188 Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ValorAVista_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorAVista.Validated
        If Me.ValorAVista.Text = "" Then Me.ValorAVista.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub ValorOutros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ValorOutros.KeyDown
        'Se o character não for numérico ou backspace, ignorar o que foi digitado B.
        If Not IsNumeric(Chr(e.KeyCode)) And e.KeyCode <> 8 And e.KeyCode <> 188 And e.KeyCode <> 13 Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ValorAFaturar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ValorAFaturar.KeyDown
        'Se o character não for numérico ou backspace, ignorar o que foi digitado B.
        If Not IsNumeric(Chr(e.KeyCode)) And e.KeyCode <> 8 And e.KeyCode <> 188 And e.KeyCode <> 13 Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ContaBalanceteVendaAvista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaBalanceteVendaAvista.KeyDown
        If NzZero(Me.ValorAVista.Text) <> 0 Then
            If e.KeyCode = Keys.F5 Then
                My.Forms.BalanceteContasProcura.TipoConta = "C"
                My.Forms.BalanceteContasProcura.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ContaBalanceteVendaAvista_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaBalanceteVendaAvista.Leave
        If String.CompareOrdinal(Me.ContaBalanceteVendaAvista.Text, Me.ContaBalanceteVendaAvista.TextoAntigo) Then
            AchaContaBalancete()
        End If
    End Sub

    Public Sub AchaContaBalancete()

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim Sql As String = "Select * from ContasG3 where ContaGrupo3 = '" & Me.ContaBalanceteVendaAvista.Text & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.ContaBalanceteVendaAvistaDesc.Text = DR.Item("DescContaGrupo3") & ""
        End If
        Cn.Close()
    End Sub

    Private Sub ContaBalanceteVendaAvista_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaBalanceteVendaAvista.Enter
        If Me.ValorAVista.Text <> 0 And Me.ContaBalanceteVendaAvista.Text = "" Then
            Me.ContaBalanceteVendaAvista.Text = cbVendaVista
        End If
    End Sub

    Private Sub ExcluirChequeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirChequeToolStripMenuItem.Click
        Dim I As Integer = 0

        Dim VlrCC As String = String.Empty
        Dim VlrCH As String = String.Empty

        For I = 0 To MyListaOutros.Items.Count - 1
            If MyListaOutros.Items(I).Selected = True Then
                VlrCH = MyListaOutros.Items(I).Text.Substring(0)
                VlrCC = MyListaOutros.Items(I).SubItems(1).Text.Substring(0)
            End If
        Next


        Try
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Delete * From ArquivoCheque Where Cheque = '" & VlrCH & "' And CC = '" & VlrCC & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.ExecuteNonQuery()
            CNN.Close()
            EncheListaOutros()
            MsgBox("Registro excluido com sucesso", 64, "Validação de Dados")
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
    End Sub

    Private Sub txt_valor_credito_Descontar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_valor_credito_Descontar.Leave
        If CDbl(txt_valor_credito_Descontar.Text) > CDbl(lblTotalOS.Text) Then
            MessageBox.Show("O Crédito a descontar não pode ser maior que o Total do Pedido/Os", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_valor_credito_Descontar.Clear()
            txt_valor_credito_Descontar.Focus()
            Exit Sub
        End If
        If CDbl(txt_valor_credito_Descontar.Text) > CDbl(ValorAVista.Text) Then
            MessageBox.Show("O Crédito a descontar não pode ser maior que o Valor a Vista", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_valor_credito_Descontar.Clear()
            txt_valor_credito_Descontar.Focus()
            Exit Sub
        End If
    End Sub
End Class