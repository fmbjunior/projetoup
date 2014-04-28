Imports System.Data.OleDb
Imports System.IO
Public Class PedidoVendaConfirmar
    Dim Ação As New TrfGerais

    Dim Ds As New DataSet()

    Private OperationItensOutros As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Dim cbVendaVista As String = ""
   

  
    Dim TipoVenda As String = ""


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Dim EstoqueGeral As New EstoqueAtualizar
        EstoqueGeral.Run_AtualizadorEstoquePedido(My.Forms.PedidoVenda.PedidoSequencia.Text)

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PedidoVendaConfirmar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LocalizaDadosEmpresa()

        Me.ValorAVista.Text = My.Forms.PedidoVenda.ValorAVista.Text
        Me.ValorOutros.Text = My.Forms.PedidoVenda.ValorOutros.Text
        Me.ValorAFaturar.Text = My.Forms.PedidoVenda.ValorAFaturar.Text

        EncheListaReceber()
        EncheListaOutros()

        If My.Forms.PedidoVenda.TpVenda.Text = "DEVOLUÇÃO" Then
            Me.ValorAVista.Enabled = False
            Me.ContaBalanceteVendaAvista.Enabled = False
            Me.ContaBalanceteVendaAvistaDesc.Enabled = False
            Me.ValorOutros.Enabled = False
            Me.BTParcelaOutros.Enabled = False
            Me.MyListaOutros.Enabled = False
            Me.TotalParcelamentoOutros.Enabled = False
            Me.ValorAFaturar.Focus()
        End If
    End Sub

    Public Sub LocalizaDadosEmpresa()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            cbVendaVista = DR.Item("ContaBalanceteVendaAvista") & ""
        End If
        DR.Close()

    End Sub


    Public Sub EncheListaReceber()
        If My.Forms.PedidoVenda.PedidoSequencia.Text = "" Then Exit Sub

        MyListaReceber.Items.Clear()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Receber WHERE PedidoProdutos = " & My.Forms.PedidoVenda.PedidoSequencia.Text & " and Documento <> 'Cheque'"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            Dim Zebrar As Boolean = True

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then
                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Documento") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorDocumento"), 2))
                    item1.SubItems.Add(DataReader.Item("Vencimento") & "")
                    item1.SubItems.Add(DataReader.Item("LocalPgto") & "")

                    MyListaReceber.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = True Then
                        MyListaReceber.Items.Item(MyListaReceber.Items.Count() - 1).BackColor = Color.LemonChiffon
                        Zebrar = False
                    Else
                        MyListaReceber.Items.Item(MyListaReceber.Items.Count() - 1).BackColor = Color.Azure
                        Zebrar = True
                    End If

                End If
            End While

            DataReader.Close()
            CNN.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub BTParcelaOutros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTParcelaOutros.Click
        If Me.ValorOutros.Text = 0 Then
            Me.ValorAFaturar.Focus()
            Exit Sub
        End If



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

                Dim media_DESCONTO As Double = FormatNumber(CDbl(My.Forms.PedidoVenda.MediaDesconto.Text), 2)
                If DrEmpresaComissao.HasRows = True Then
                    If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa1")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa2")))
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa3")))
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa4")))
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa5")))
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa6")))
                End If
                Me.PercentComissao.Text = NzZero(ComissaoFaixaExecutar)
            End If

        End If

        My.Forms.ChequePreLancar.ShowDialog()
        EncheListaOutros()
        Me.ValorAFaturar.Focus()
    End Sub

    Public Sub EncheListaOutros()
        If My.Forms.PedidoVenda.PedidoSequencia.Text = "" Then Exit Sub

        Me.MyListaOutros.Items.Clear()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM ArquivoCheque WHERE Pedido = " & My.Forms.PedidoVenda.PedidoSequencia.Text
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
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

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

                    Dim media_DESCONTO As Double = FormatNumber(CDbl(My.Forms.PedidoVenda.MediaDesconto.Text), 2)
                    If DrEmpresaComissao.HasRows = True Then
                        If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa1")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa2")))
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa3")))
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa4")))
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa5")))
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And My.Forms.PedidoVenda.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa6")))
                    End If
                End If


                'Gerar o parcelamento a Vista do Pedido
                Dim ds As New DataSet()

                Dim Sqlstr As String = String.Empty
                Sqlstr = "SELECT * from Receber Where Documento  = '" & My.Forms.PedidoVenda.PedidoSequencia.Text & "-AVISTA' and PedidoProdutos = " & My.Forms.PedidoVenda.PedidoSequencia.Text

                Dim DAReceber As New OleDb.OleDbDataAdapter(Sqlstr, CNN)

                DAReceber.Fill(ds, "Receber")
                If ds.Tables("Receber").Rows.Count = 0 Then

                    Dim TBL As DataTable
                    TBL = ds.Tables("Receber")

                    Dim DRnovo As DataRow
                    DRnovo = TBL.NewRow()
                    DRnovo("Documento") = My.Forms.PedidoVenda.PedidoSequencia.Text & "-AVISTA"
                    DRnovo("DataDocumento") = My.Forms.PedidoVenda.DataPedido.Text
                    DRnovo("ValorDocumento") = CDbl(Me.ValorAVista.Text)
                    DRnovo("ValorLiquido") = CDbl(Me.ValorAVista.Text)
                    DRnovo("LocalPgto") = "CARTEIRA"
                    DRnovo("PedidoProdutos") = My.Forms.PedidoVenda.PedidoSequencia.Text
                    DRnovo("CodCliente") = My.Forms.PedidoVenda.CódigoCliente.Text
                    DRnovo("Cliente") = My.Forms.PedidoVenda.NomeCliente.Text
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("OriginalParcial") = "O"
                    DRnovo("Vencimento") = My.Forms.PedidoVenda.DataPedido.Text
                    DRnovo("Recebimento") = My.Forms.PedidoVenda.DataPedido.Text
                    DRnovo("Baixado") = True
                    DRnovo("ContaValorBaixado") = Me.ContaBalanceteVendaAvista.Text
                    DRnovo("PercentComissao") = ComissaoFaixaExecutar
                    DRnovo("Virtual") = False
                    TBL.Rows.Add(DRnovo)
                    DocReceberAvista = My.Forms.PedidoVenda.PedidoSequencia.Text & "-AVISTA"
                Else
                    Dim DrReceber() As DataRow
                    DrReceber = ds.Tables("Receber").Select("Documento = '" & My.Forms.PedidoVenda.PedidoSequencia.Text & "-AVISTA' and PedidoProdutos = " & My.Forms.PedidoVenda.PedidoSequencia.Text)

                    DrReceber(0).BeginEdit()
                    DrReceber(0)("Documento") = My.Forms.PedidoVenda.PedidoSequencia.Text & "-AVISTA"
                    DrReceber(0)("DataDocumento") = My.Forms.PedidoVenda.DataPedido.Text
                    DrReceber(0)("ValorDocumento") = CDbl(Me.ValorAVista.Text)
                    DrReceber(0)("ValorLiquido") = CDbl(Me.ValorAVista.Text)
                    DrReceber(0)("LocalPgto") = "CARTEIRA"
                    DrReceber(0)("PedidoProdutos") = My.Forms.PedidoVenda.PedidoSequencia.Text
                    DrReceber(0)("CodCliente") = My.Forms.PedidoVenda.CódigoCliente.Text
                    DrReceber(0)("Cliente") = My.Forms.PedidoVenda.NomeCliente.Text
                    DrReceber(0)("Empresa") = CodEmpresa
                    DrReceber(0)("OriginalParcial") = "O"
                    DrReceber(0)("Vencimento") = My.Forms.PedidoVenda.DataPedido.Text
                    DrReceber(0)("Recebimento") = My.Forms.PedidoVenda.DataPedido.Text
                    DrReceber(0)("Baixado") = True
                    DrReceber(0)("ContaValorBaixado") = Me.ContaBalanceteVendaAvista.Text
                    DrReceber(0)("PercentComissao") = ComissaoFaixaExecutar
                    DrReceber(0)("Virtual") = False
                    DrReceber(0).EndEdit()
                    DocReceberAvista = My.Forms.PedidoVenda.PedidoSequencia.Text & "-AVISTA"
                End If
                Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
                DAReceber.Update(ds, "Receber")

                ds.Dispose()
            End If

            'Fim da Geraçao do Parcelameto a Vista

            'Verificar se existe faturamento com Cheque
            If CDbl(Me.ValorOutros.Text) > 0 Then
                'Gerar o parcelamento com cheque do Pedido
                Dim dsCheque As New DataSet()

                Dim Sqlstr As String = String.Empty
                Sqlstr = "SELECT * from Receber Where Documento  = 'CHEQUE' and PedidoProdutos = " & My.Forms.PedidoVenda.PedidoSequencia.Text

                Dim DAReceber As New OleDb.OleDbDataAdapter(Sqlstr, CNN)

                DAReceber.Fill(dsCheque, "Receber")


                If dsCheque.Tables("Receber").Rows.Count = 0 Then

                    Dim TBL As DataTable
                    TBL = dsCheque.Tables("Receber")

                    Dim DRnovo As DataRow
                    DRnovo = TBL.NewRow()
                    DRnovo("Documento") = "CHEQUE"
                    DRnovo("DataDocumento") = My.Forms.PedidoVenda.DataPedido.Text
                    DRnovo("ValorDocumento") = CDbl(Me.ValorOutros.Text)
                    DRnovo("ValorLiquido") = CDbl(Me.ValorOutros.Text)
                    DRnovo("LocalPgto") = "CHEQUE PRE-DATADO"
                    DRnovo("PedidoProdutos") = My.Forms.PedidoVenda.PedidoSequencia.Text
                    DRnovo("CodCliente") = My.Forms.PedidoVenda.CódigoCliente.Text
                    DRnovo("Cliente") = My.Forms.PedidoVenda.NomeCliente.Text
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("OriginalParcial") = "O"
                    DRnovo("Vencimento") = My.Forms.PedidoVenda.DataPedido.Text
                    DRnovo("Recebimento") = My.Forms.PedidoVenda.DataPedido.Text
                    DRnovo("Baixado") = True
                    DRnovo("MediaDescontoPedido") = My.Forms.PedidoVenda.MediaDesconto.Text
                    DRnovo("Virtual") = False
                    TBL.Rows.Add(DRnovo)
                Else
                    Dim DrReceber() As DataRow
                    DrReceber = dsCheque.Tables("Receber").Select("Documento = 'CHEQUE' and PedidoProdutos = " & My.Forms.PedidoVenda.PedidoSequencia.Text)

                    DrReceber(0).BeginEdit()
                    DrReceber(0)("Documento") = "CHEQUE"
                    DrReceber(0)("DataDocumento") = My.Forms.PedidoVenda.DataPedido.Text
                    DrReceber(0)("ValorDocumento") = CDbl(Me.ValorOutros.Text)
                    DrReceber(0)("ValorLiquido") = CDbl(Me.ValorOutros.Text)
                    DrReceber(0)("LocalPgto") = "CHEQUE PRE-DATADO"
                    DrReceber(0)("PedidoProdutos") = My.Forms.PedidoVenda.PedidoSequencia.Text
                    DrReceber(0)("CodCliente") = My.Forms.PedidoVenda.CódigoCliente.Text
                    DrReceber(0)("Cliente") = My.Forms.PedidoVenda.NomeCliente.Text
                    DrReceber(0)("Empresa") = CodEmpresa
                    DrReceber(0)("OriginalParcial") = "O"
                    DrReceber(0)("Vencimento") = My.Forms.PedidoVenda.DataPedido.Text
                    DrReceber(0)("Recebimento") = My.Forms.PedidoVenda.DataPedido.Text
                    DrReceber(0)("Baixado") = True
                    DrReceber(0)("MediaDescontoPedido") = My.Forms.PedidoVenda.MediaDesconto.Text
                    DrReceber(0)("Virtual") = False
                    DrReceber(0).EndEdit()

                End If
                Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
                DAReceber.Update(dsCheque, "Receber")

                dsCheque.Dispose()
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
                'Lanc plano conta valores a vista
                If Me.ValorAVista.Text <> 0 Then



                    Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                    CmdAvista.CommandText = Sql

                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(My.Forms.PedidoVenda.PedidoSequencia.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@6", Nz("C", 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(My.Forms.PedidoVenda.NomeCliente.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("RECEB. AVISTA PED. " & My.Forms.PedidoVenda.PedidoSequencia.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@12", Me.ValorAVista.Text))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(CaixaAtivo, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.ContaBalanceteVendaAvista.Text, 1)))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@17", "PEDIDO"))
                    CmdAvista.Parameters.Add(New OleDb.OleDbParameter("@18", My.Forms.PedidoVenda.PedidoSequencia.Text))

                    CmdAvista.ExecuteNonQuery()



                    'Fazer Lancamento do avista no balancelete
                    Sql = "SELECT * from BalanceteLanc Where Id  = -1"

                    Dim CmdLctoBalancelte As New OleDb.OleDbCommand(Sql, CNN)
                    CmdLctoBalancelte.Transaction = Transacao

                    Dim DALctoBalanc As New OleDb.OleDbDataAdapter(CmdLctoBalancelte)

                    DALctoBalanc.Fill(Ds, "Balancete")

                    Dim DrNewBalanc As DataRow
                    DrNewBalanc = Ds.Tables("Balancete").NewRow

                    Dim Hist As String = String.Empty
                    If My.Forms.SellShoes.PedidoTipo.Text = "DEVOLUÇÃO" Then
                        Hist = "DEV. " & My.Forms.PedidoVenda.PedidoSequencia.Text
                    Else
                        Hist = "RECEB. AVISTA VENDA. " & My.Forms.PedidoVenda.PedidoSequencia.Text
                    End If

                    DrNewBalanc("ContaBalancete") = Me.ContaBalanceteVendaAvista.Text
                    DrNewBalanc("ContaCR") = VAR_ContaCrVenda
                    DrNewBalanc("DataLancamento") = DataDia
                    DrNewBalanc("Documento") = My.Forms.PedidoVenda.PedidoSequencia.Text
                    DrNewBalanc("ValorDocumento") = CDbl(Me.ValorAVista.Text)
                    DrNewBalanc("Historico") = Hist
                    DrNewBalanc("Empresa") = CodEmpresa
                    DrNewBalanc("PrgLancamento") = "PEDIDO"
                    DrNewBalanc("IdProcura") = My.Forms.PedidoVenda.PedidoSequencia.Text
                    Ds.Tables("Balancete").Rows.Add(DrNewBalanc)

                    Dim ObjLctoBalanc As New OleDb.OleDbCommandBuilder(DALctoBalanc)
                    DALctoBalanc.Update(Ds, "Balancete")

                End If

                'Atualizar o pedido confirmando
                Dim StatusPed As String
                If My.Forms.PedidoVenda.TipoEntrega.Text = "IMEDIATA" Then
                    'Entrega Imediata atualiza a quantidade de entrega para quantidade do item
                    Sql = "UPDATE ItensPedido SET ItensPedido.QtdRetirada = [Qtd] WHERE (((ItensPedido.PedidoSequencia)=" & My.Forms.PedidoVenda.PedidoSequencia.Text & "));"
                    CmdAtItens.CommandText = Sql
                    CmdAtItens.ExecuteNonQuery()

                    StatusPed = "FINALIZADO"
                Else
                    StatusPed = "INICIAL"
                End If

                Sql = "Update Pedido  set ValorAVista = @1, ValorOutros = @2, ValorAFaturar = @3, Confirmado = @4, DataFechamento = @5, StatusAndamentos = @6, ContaBalanceteVendaAvista = @7 Where PedidoSequencia = " & My.Forms.PedidoVenda.PedidoSequencia.Text
                Cmd.CommandText = Sql

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.ValorAVista.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.ValorOutros.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ValorAFaturar.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", True))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", StatusPed))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ContaBalanceteVendaAvista.Text, 1)))
                Cmd.ExecuteNonQuery()

                'Atualizar de virtual para nao virtual
                Sql = "UPDATE Receber SET Receber.Virtual = False WHERE (((Receber.PedidoProdutos)= " & My.Forms.PedidoVenda.PedidoSequencia.Text & " ) AND ((Receber.Empresa)=" & CodEmpresa & "));"
                CmdAtReceberVirtual.CommandText = Sql
                CmdAtReceberVirtual.ExecuteNonQuery()

                'Atualizar estoque Tabela EstoqueUp
                Dim TpEst As String = "S"
                If My.Forms.PedidoVenda.TipoEntrega.Text = "IMEDIATA" Then
                    Dim NCliente As String = My.Forms.PedidoVenda.NomeCliente.Text
                    If My.Forms.PedidoVenda.TpVenda.Text = "DEVOLUÇÃO" Then
                        NCliente = NCliente & " **DEVOLUÇÃO**"
                        TpEst = "D"
                    End If
                    Sql = "INSERT INTO EstoqueUP (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc) SELECT ItensPedido.CodigoProduto, [Qtd]*-1 AS QtdEst, '" & TpEst & "' AS Expr1, 0 AS Expr2, Pedido.DataFechamento, Pedido.PedidoSequencia, 'PedidoVenda' AS Expr3,'" & NCliente & "' AS Expr4, '" & My.Forms.PedidoVenda.PedidoSequencia.Text & "' As Expr5 FROM (ItensPedido INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & My.Forms.PedidoVenda.PedidoSequencia.Text & ") AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Produtos.ControlaEstoque)='SIM'));"
                    CmdEstoque.CommandText = Sql
                    CmdEstoque.ExecuteNonQuery()
                End If

                'Atualiza comissoes de Venda
                'Atualiza comissao de venda do item se o desconto é por linha

                If TipoComissaoVenda = "P" Then
                    Sql = "UPDATE ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto SET ItensPedido.Comissao = [ComissaoVenda], ItensPedido.ValorComissao = (([TotalProduto]-[ValorDesconto])*[ComissaoVenda])/100, ItensPedido.tpComissao = 'P' WHERE (((ItensPedido.PedidoSequencia) = " & My.Forms.PedidoVenda.PedidoSequencia.Text & "));"
                    CmdComissao.CommandText = Sql
                    CmdComissao.ExecuteNonQuery()

                    Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao ) SELECT Pedido.DataFechamento AS DTFecha, Pedido.DataFechamento, Pedido.CódigoFuncionário, ItensPedido.PedidoSequencia, 0 AS Produto, 0 AS [Percent], 0 AS VlrDoc, Sum(ItensPedido.ValorComissao) AS SomaDeValorComissao, 'P' AS TpComissao FROM (ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia GROUP BY Pedido.DataFechamento, Pedido.DataFechamento, Pedido.CódigoFuncionário, ItensPedido.PedidoSequencia, 0, 0, 0,  'P' HAVING (((ItensPedido.PedidoSequencia)=" & My.Forms.PedidoVenda.PedidoSequencia.Text & "));"
                    CmdComissaoItemAgrupada.CommandText = Sql
                    CmdComissaoItemAgrupada.ExecuteNonQuery()
                End If
                If TipoComissaoVenda = "V" Then
                    Sql = "INSERT INTO FuncionarioComissao ( PedidoVenda, ValorDocumento, DataLancamento, DataDocumento, Funcionario, Produto, Percentual, ValorComissao, TipoComissao, Pago ) SELECT Pedido.PedidoSequencia, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.DataPedido, Pedido.CódigoFuncionário, 0 AS Produto, Funcionários.ComissaoVenda, ([TotalPedido]*[ComissaoVenda])/100 AS Comissao, 'V' AS TpComissao, False AS Pago FROM Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.PedidoSequencia)=" & My.Forms.PedidoVenda.PedidoSequencia.Text & "));"
                    CmdComissao.CommandText = Sql
                    CmdComissao.ExecuteNonQuery()
                End If
                If TipoComissaoVenda = "R" Then 'esta rotina é apenas para recebimento a vista
                    Sql = "INSERT INTO FuncionarioComissao ( PedidoVenda, ValorDocumento, DataLancamento, DataDocumento, Funcionario, Produto, Percentual, ValorComissao, TipoComissao, Pago ) SELECT Pedido.PedidoSequencia, Pedido.ValorAVista, Pedido.DataFechamento, Pedido.DataPedido, Pedido.CódigoFuncionário, 0 AS Produto, Funcionários.ComissaoVenda, ([ValorAVista]*[ComissaoVenda])/100 AS Comissao, 'R' AS TpComissao, False AS Pago FROM Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.PedidoSequencia)=" & My.Forms.PedidoVenda.PedidoSequencia.Text & "));"
                    CmdComissao.CommandText = Sql
                    CmdComissao.ExecuteNonQuery()
                End If

                If TipoComissaoVenda = "porFAIXA" Then

                    CmdEmpresaComissao.CommandText = "Select * From EmpresaComissaoFaixa Where Empresa = " & CodEmpresa
                    Dim DrEmpresaComissao As OleDb.OleDbDataReader

                    DrEmpresaComissao = CmdEmpresaComissao.ExecuteReader
                    DrEmpresaComissao.Read()

                    Dim media_DESCONTO As Double = FormatNumber(CDbl(NzZero(My.Forms.PedidoVenda.MediaDesconto.Text)), 2)
                    Dim ComissaoFaixaExecutar As Double = 0
                    Dim ComissaoFaixaExecutarAVISTA As Double = 0
                    If DrEmpresaComissao.HasRows = True Then
                        If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa1")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa2")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa3")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa4")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa5")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa6")

                        If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa1")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa2")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa3")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa4")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa5")
                        If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And NzZero(My.Forms.PedidoVenda.MediaDesconto.Text) <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa6")
                    End If

                    If CDbl(NzZero(Me.ValorAVista.Text)) <> 0 Then
                        Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, Pago, ComissaoFaturamento, OndeVeio, IdOrigem, Documento, DescComissao ) Values ( #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#,#" & Format(CDate(My.Forms.PedidoVenda.DataPedido.Text), "MM/dd/yyyy") & "# ," & My.Forms.PedidoVenda.CódigoFuncionário.Text & " ," & My.Forms.PedidoVenda.PedidoSequencia.Text & " , 0 ,'" & ComissaoFaixaExecutarAVISTA & "' ,'" & Me.ValorAVista.Text & "' ,'" & CDbl((CDbl(Me.ValorAVista.Text) * CDbl(ComissaoFaixaExecutarAVISTA)) / 100) & "' ,'porFAIXA' , False, False, 'PEDIDO', " & My.Forms.PedidoVenda.PedidoSequencia.Text & ", '" & DocReceberAvista & "', 'RECEB. AVISTA DOC: " & DocReceberAvista & "' )"
                        CmdComissaoAVISTA.CommandText = Sql
                        CmdComissaoAVISTA.ExecuteNonQuery()
                    End If

                    If CDbl(DrEmpresaComissao.Item("cFat")) > 0 Then
                        Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, Pago, ComissaoFaturamento, OndeVeio, IdOrigem, Documento, DescComissao ) SELECT #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# AS DataLancamento, Pedido.DataPedido, Pedido.CódigoFuncionário, Pedido.PedidoSequencia, 0 AS Produto, EmpresaComissaoFaixa.cFat, Pedido.TotalPedido, ([TotalPedido]*[cFat])/100 AS ValorComissao, 'porFAIXA' AS TipoComissao, False AS Pago, True AS éFaturamento, 'PEDIDO', " & My.Forms.PedidoVenda.PedidoSequencia.Text & ", '" & My.Forms.PedidoVenda.PedidoSequencia.Text & "', 'COMISSAO FAT. PED: " & My.Forms.PedidoVenda.PedidoSequencia.Text & "' FROM Pedido INNER JOIN EmpresaComissaoFaixa ON Pedido.Empresa = EmpresaComissaoFaixa.Empresa WHERE (((Pedido.PedidoSequencia)=" & My.Forms.PedidoVenda.PedidoSequencia.Text & "));"
                        CmdComissao.CommandText = Sql
                        CmdComissao.ExecuteNonQuery()
                    End If

                End If



                'Throw New System.Exception()
                Transacao.Commit()


                My.Forms.PedidoVenda.Confirmado.Checked = True
                My.Forms.PedidoVenda.DataFechamento.Text = DataDia
                My.Forms.PedidoVenda.ConfImg.Visible = True

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


                If My.Forms.PedidoVenda.TpVenda.Text <> "DEVOLUÇÃO" Then
                    If NzZero(Me.ValorAFaturar.Text) > 0 Then
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
                End If

                MsgBox("Pedido confirmado com sucesso", 64, "Validação de Dados")

                GerarLog(Me.Text, AçãoTP.Confirmou, My.Forms.PedidoVenda.PedidoSequencia.Text)

                If My.Forms.PedidoVenda.TipoEntrega.Text = "IMEDIATA" Then
                    'Atualizar o Estoque do Cadastro de Produtos
                    Dim EstoqueGeral As New EstoqueAtualizar
                    EstoqueGeral.Run_AtualizadorEstoquePedido(My.Forms.PedidoVenda.PedidoSequencia.Text)
                End If

                My.Forms.PedidoVenda.TabPedido.SelectedTab = My.Forms.PedidoVenda.TabCliente


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
End Class