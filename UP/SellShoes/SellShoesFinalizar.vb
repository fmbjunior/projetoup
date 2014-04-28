Imports System.Math


Public Class SellShoesFinalizar

    Dim DocReceberAvista As String = String.Empty


    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Dim Ds As New DataSet()
    Dim DAFaturar As OleDb.OleDbDataAdapter
    Dim DACheque As OleDb.OleDbDataAdapter
    Dim DaChTemp As OleDb.OleDbDataAdapter
    Dim DAAvista As OleDb.OleDbDataAdapter

    Dim CmdAPrazo As New OleDb.OleDbCommand
    Dim CmdAVista As New OleDb.OleDbCommand
    Dim CmdChTemp As New OleDb.OleDbCommand
    Dim CmdCheque As New OleDb.OleDbCommand


    Dim RestaValorGeral As Double
    Dim qconfirmacao As Integer = 0


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub



    Private Sub SellShoesFinalizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.Open()

        If My.Forms.SellShoes.PedidoTipo.Text = "VENDA" Then
            Me.ValorAVista.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.ValorVista.Text)), 2)
            Me.ValorCheque.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.ValorCheque.Text)), 2)
            Me.ValorFaturar.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.ValorFaturar.Text)), 2)
        Else
            Me.ValorAVista.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.ValorVista.Text)), 2)
            Me.ValorCheque.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.ValorCheque.Text)), 2)
            Me.ValorFaturar.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.ValorFaturar.Text)), 2)
        End If

        Me.PainelAPrazo.Enabled = False
        Me.PainelCheque.Enabled = False

        If CDbl(NzZero(Me.ValorCheque.Text)) <> 0 Then

            'Cria a Parcela do total do Cheque
            Dim Sql As String = String.Empty
            Sql = "SELECT * from Receber Where Id  = -1"

            CmdChTemp.Connection = Cnn
            CmdChTemp.CommandText = Sql

            DaChTemp = New OleDb.OleDbDataAdapter(CmdChTemp)
            DaChTemp.Fill(Ds, "ReceberChTemp")

            Dim Func() As String = CType(My.Forms.SellShoes.Vendedor.Text, String).Split("-")

            Dim DrNew As DataRow
            DrNew = Ds.Tables("ReceberChTemp").NewRow

            DrNew("Documento") = "CHEQUE"
            DrNew("DataDocumento") = My.Forms.SellShoes.DataVenda.Text
            DrNew("ValorDocumento") = CDbl(Me.ValorCheque.Text)
            DrNew("ValorLiquido") = CDbl(Me.ValorCheque.Text)
            DrNew("LocalPgto") = "CHEQUE PRE-DATADO"
            DrNew("PedidoProdutos") = My.Forms.SellShoes.Venda.Text
            DrNew("CodCliente") = My.Forms.SellShoes.xCodCliente.Text
            DrNew("Cliente") = My.Forms.SellShoes.xNome.Text
            DrNew("Empresa") = CodEmpresa
            DrNew("OriginalParcial") = "O"
            DrNew("Vendedor") = Func(0)
            DrNew("Vencimento") = DataDia
            DrNew("MediaDescontoPedido") = 0
            DrNew("PercentComissao") = 0
            DrNew("ControlePedido") = 0
            DrNew("ContaValorBaixado") = Nz(CodLancamentoReceber, 1)
            DrNew("Baixado") = True
            DrNew("Recebimento") = DataDia
            Ds.Tables("ReceberChTemp").Rows.Add(DrNew)
            'Fim


            Sql = "SELECT * from ArquivoCheque Where IdCodigo  = -1"

            CmdCheque.Connection = Cnn
            CmdCheque.CommandText = Sql

            DACheque = New OleDb.OleDbDataAdapter(CmdCheque)
            DACheque.Fill(Ds, "Cheque")

            CarregaCadBancos()

            Me.TotalParcelamentoCheque.Text = FormatNumber(0, 2)
        End If


        If CDbl(NzZero(Me.ValorAVista.Text)) <> 0 Then
            Me.ContaBalanceteVendaAvista.Text = cbVendaVista

            Dim Sql As String = String.Empty
            Sql = "SELECT * from Receber Where Id  = -1"

            CmdAVista.Connection = Cnn
            CmdAVista.CommandText = Sql

            DAAvista = New OleDb.OleDbDataAdapter(CmdAVista)
            DAAvista.Fill(Ds, "ReceberAvista")

            Dim Func() As String = CType(My.Forms.SellShoes.Vendedor.Text, String).Split("-")

            Dim DrNew As DataRow
            DrNew = Ds.Tables("ReceberAvista").NewRow

            Dim Parc As String = String.Empty

            If My.Forms.SellShoes.PedidoTipo.Text = "DEVOLUÇÃO" Then
                Parc = My.Forms.SellShoes.Venda.Text & "-DEV"
            Else
                Parc = My.Forms.SellShoes.Venda.Text & "-AVISTA"
            End If

            DrNew("Documento") = Parc
            DrNew("DataDocumento") = My.Forms.SellShoes.DataVenda.Text
            DrNew("ValorDocumento") = CDbl(Me.ValorAVista.Text)
            DrNew("LocalPgto") = "CARTEIRA"
            DrNew("PedidoProdutos") = My.Forms.SellShoes.Venda.Text
            DrNew("CodCliente") = My.Forms.SellShoes.xCodCliente.Text
            DrNew("Cliente") = My.Forms.SellShoes.xNome.Text
            DrNew("Empresa") = CodEmpresa
            DrNew("OriginalParcial") = "O"
            DrNew("Vendedor") = Func(0)
            DrNew("Vencimento") = DataDia
            DrNew("MediaDescontoPedido") = 0
            DrNew("PercentComissao") = 0
            DrNew("ControlePedido") = 0
            DrNew("ContaValorBaixado") = Nz(CodLancamentoReceber, 1)

            DrNew("ValorLiquido") = CDbl(Me.ValorAVista.Text)
            DrNew("Baixado") = True
            DrNew("Recebimento") = DataDia


            Ds.Tables("ReceberAvista").Rows.Add(DrNew)
            DocReceberAvista = Parc
        End If


        If CDbl(NzZero(Me.ValorFaturar.Text)) <> 0 Then

            CarregaLocalPgto()

            Dim Sql As String = String.Empty
            Sql = "SELECT * from Receber Where PedidoProdutos  = " & CInt(My.Forms.SellShoes.Venda.Text)

            CmdAPrazo.Connection = Cnn
            CmdAPrazo.CommandText = Sql

            DAFaturar = New OleDb.OleDbDataAdapter(CmdAPrazo)
            DAFaturar.Fill(Ds, "Receber")


            Me.Parcelado.Text = NzZero(Ds.Tables("Receber").Compute("sum(ValorDocumento)", ""))
            RestaValorGeral = NzZero(Ds.Tables("Receber").Compute("sum(ValorDocumento)", ""))
            Dim Tbl As New DataView(Ds.Tables("Receber").Copy)
            Me.ListaReceber.DataSource = Tbl.ToTable("Table", True, "Documento", "ValorDocumento", "Vencimento", "LocalPgto", "VencimentoOriginal")

        Else
            Me.Parcelado.Text = FormatNumber(0, 2)
        End If
    End Sub

    'Public Sub AchaContaBalanceteAvista()

    '    Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    '    Cn.Open()

    '    Dim Sql As String = "Select * from ContasG3 where ContaGrupo3 = '" & Me.ContaBalanceteVendaAvista.Text & "' And Empresa = " & CodEmpresa
    '    Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
    '    Dim DR As OleDb.OleDbDataReader

    '    DR = CMD.ExecuteReader
    '    DR.Read()
    '    If DR.HasRows Then
    '        Me.ContaBalanceteVendaAvistaDesc.Text = DR.Item("DescContaGrupo3") & ""
    '    End If
    '    Cn.Close()
    'End Sub


    Private Sub btSalvarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarCheque.Click

        If Me.Cheque.Text = "" Then
            MsgBox("O Cheque não pode ser nulo.", 64, "Validação de Dados")
            Me.Cheque.Focus()
            Exit Sub
        ElseIf Me.CC.Text = "" Then
            MsgBox("A Conta Corrente não pode ser nula", 64, "Validação de Dados")
            Me.CC.Focus()
            Exit Sub
        ElseIf Me.BancoCheque.Text = "" Then
            MsgBox("O Banco do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.BancoCheque.Focus()
            Exit Sub
        ElseIf Me.Titular.Text = "" Then
            MsgBox("O titular do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.Titular.Focus()
            Exit Sub
        ElseIf Me.EntreguePor.Text = "" Then
            MsgBox("Por quem o cheque foi entregue não pode ser nulo", 64, "Validação de Dados")
            Me.EntreguePor.Focus()
            Exit Sub
        ElseIf Me.ValorCh.Text = "" Then
            MsgBox("O Valord do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.ValorCh.Focus()
            Exit Sub
        ElseIf Me.Vencimento.Text = "" Then
            MsgBox("O Vencimento do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.Vencimento.Focus()
            Exit Sub
        End If

        Dim DrCheque() As DataRow
        DrCheque = Ds.Tables("Cheque").Select("Cheque = '" & Me.Cheque.Text & "' And CC = '" & Me.CC.Text & "'")

        If DrCheque.Length = 1 Then

            DrCheque(0).BeginEdit()
            DrCheque(0)("Cheque") = Me.Cheque.Text
            DrCheque(0)("CC") = Me.CC.Text
            DrCheque(0)("BancoCheque") = Me.BancoCheque.SelectedValue
            DrCheque(0)("Titular") = Me.Titular.Text
            DrCheque(0)("EntreguePor") = Me.EntreguePor.Text
            DrCheque(0)("ValorCh") = Me.ValorCh.Text
            DrCheque(0)("Vencimento") = Me.Vencimento.Text
            DrCheque(0)("Empresa") = CodEmpresa
            DrCheque(0)("Pedido") = My.Forms.SellShoes.Venda.Text
            DrCheque(0)("Historico") = "CHEQUE-PRE"
            DrCheque(0)("Documento") = System.DBNull.Value
            DrCheque(0)("IDRECEBER") = System.DBNull.Value
            DrCheque(0)("IdCodigo") = 0
            DrCheque(0)("Cliente") = My.Forms.SellShoes.xCodCliente.Text

            Dim Func() As String = CType(My.Forms.SellShoes.Vendedor.Text, String).Split("-")
            DrCheque(0)("Vendedor") = Func(0)
            DrCheque(0)("MediaDescontoPedido") = 0
            DrCheque(0)("PercentComissao") = 0
            DrCheque(0)("CaixaCheque") = CaixaAtivo
            DrCheque(0)("DataLancamento") = DataDia
            DrCheque(0).EndEdit()
        Else
            Dim TBL As DataTable
            TBL = Ds.Tables("Cheque")

            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()

            DRnovo("Cheque") = Me.Cheque.Text
            DRnovo("CC") = Me.CC.Text
            DRnovo("BancoCheque") = Me.BancoCheque.SelectedValue
            DRnovo("Titular") = Me.Titular.Text
            DRnovo("EntreguePor") = Me.EntreguePor.Text
            DRnovo("ValorCh") = CDbl(Me.ValorCh.Text)
            DRnovo("Vencimento") = Me.Vencimento.Text
            DRnovo("Empresa") = CodEmpresa
            DRnovo("Pedido") = My.Forms.SellShoes.Venda.Text
            DRnovo("Historico") = "CHEQUE-PRE"
            DRnovo("Documento") = System.DBNull.Value
            DRnovo("IDRECEBER") = System.DBNull.Value
            DRnovo("IdCodigo") = 0
            DRnovo("Cliente") = My.Forms.SellShoes.xCodCliente.Text

            Dim Func() As String = CType(My.Forms.SellShoes.Vendedor.Text, String).Split("-")
            DRnovo("Vendedor") = Func(0)
            DRnovo("MediaDescontoPedido") = 0
            DRnovo("PercentComissao") = 0
            DRnovo("CaixaCheque") = CaixaAtivo
            DRnovo("DataLancamento") = DataDia
            TBL.Rows.Add(DRnovo)

        End If
        Me.TotalParcelamentoCheque.Text = NzZero(Ds.Tables("Cheque").Compute("sum(ValorCh)", ""))
        Me.Lista.DataSource = Ds.Tables("Cheque").DefaultView

        Me.Cheque.Clear()
        Me.CC.Clear()
        Me.ValorCh.Clear()
        Me.Vencimento.Clear()
        Me.BancoCheque.SelectedValue = -1
        Me.Titular.Clear()
        Me.EntreguePor.Clear()
        Me.Cheque.Focus()

    End Sub

    Private Sub CarregaCadBancos()

        Dim Sql As String = String.Empty

        Sql = "SELECT * from CadBancos"
        Dim DACadBancos As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DACadBancos.Fill(Ds, "CadBancos")

        Me.BancoCheque.DataSource = Ds.Tables("CadBancos")
        Me.BancoCheque.DisplayMember = "NomeBanco"
        Me.BancoCheque.ValueMember = "NomeBanco"
        Me.BancoCheque.SelectedValue = 0

    End Sub

    Private Sub SellShoesFinalizar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.PainelAPrazo.Enabled = False

            If NzZero(Me.ValorCheque.Text) <> 0 Then
                Me.PainelCheque.Enabled = True
                Me.Cheque.Focus()
            End If
        End If
        If e.KeyCode = Keys.F3 Then
            Me.PainelCheque.Enabled = False

            If NzZero(Me.ValorFaturar.Text) <> 0 Then
                Me.PainelAPrazo.Enabled = True
            End If
        End If

        If e.KeyCode = Keys.F10 Then
            btFinalizarVenda_Click(sender, e)
        End If

    End Sub

    Private Sub CarregaLocalPgto()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM(LocalPagamento) WHERE (((LocalPagamento.Empresa)=" & CodEmpresa & ") AND ((LocalPagamento.LocalPgto)<>'CHEQUE PRE-DATADO'));"
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(Ds, "LocalPgto")

        Me.txtLocalPgto.DataSource = Ds.Tables("LocalPgto")
        Me.txtLocalPgto.ValueMember = "LocalPgto"
        Me.txtLocalPgto.DisplayMember = "LocalPgto"
        Me.txtLocalPgto.SelectedIndex = -1
        Cnn.Close()

    End Sub

    Private Sub ListaReceber_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaReceber.CellDoubleClick

        Me.txtDocumento.Text = Me.ListaReceber.CurrentRow.Cells("cDoc").Value
        Me.txtVencimento.Text = Me.ListaReceber.CurrentRow.Cells("cVenc").Value
        Me.txtValor.Text = Me.ListaReceber.CurrentRow.Cells("cValorDoc").Value
        Me.txtLocalPgto.Text = Me.ListaReceber.CurrentRow.Cells("cLocalPagamento").Value
        Me.VencimentoOriginal.Text = Me.ListaReceber.CurrentRow.Cells("cVencimentoOriginal").Value

        If e.RowIndex = (Me.ListaReceber.Rows.Count - 1) Then
            MessageBox.Show("O usuário não pode alterar o valor da ultima parcela, o valor sera bloqueado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtValor.Enabled = False
        Else
            Me.txtValor.Enabled = True
        End If
        Me.txtDocumento.Focus()

    End Sub

    Private Sub btAlterarParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterarParcela.Click

        If Me.txtDocumento.Text = "" Then
            MessageBox.Show("O Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtDocumento.Focus()
            Exit Sub
        End If
        If Me.txtVencimento.Text = "" Then
            MessageBox.Show("O Vencimento do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtVencimento.Focus()
            Exit Sub
        End If
        If Me.txtValor.Text = "" Then
            MessageBox.Show("O Valor do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtValor.Focus()
            Exit Sub
        End If
        If Me.txtLocalPgto.Text = "" Then
            MessageBox.Show("O Local de Pagamento do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtLocalPgto.Focus()
            Exit Sub
        End If

        'If RestaValorGeral < NzZero(Me.txtValor.Text) Then
        '    MessageBox.Show("O Valor da Parcela não pode ser maior que o valor restante", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.txtValor.Focus()
        '    Exit Sub
        'End If

        Dim QtdRow As Integer = Ds.Tables("Receber").Rows.Count
        Dim QtdRowTemp As Integer
        Dim RowAlterada As Integer

        Dim SomaValor As Double = 0
        Dim RestaValor As Double = 0

        Dim Linha As DataRow
        For Each Linha In Ds.Tables("Receber").Rows

            QtdRowTemp += 1
            If Linha("Documento") = Me.txtDocumento.Text Then

                Linha.BeginEdit()
                Linha("Vencimento") = Me.txtVencimento.Text
                Linha("ValorDocumento") = Me.txtValor.Text
                Linha("LocalPgto") = Me.txtLocalPgto.Text
                Linha.EndEdit()
                RowAlterada = QtdRowTemp
                SomaValor += FormatNumber(Linha("ValorDocumento"), 2)
                Exit For
            End If
            SomaValor += Linha("ValorDocumento")

            'If QtdRowTemp <= RowAlterada Then
            '    SomaValor += Linha("ValorDocumento")
            'End If

        Next

        RestaValor = FormatNumber(CDbl(NzZero(Me.ValorFaturar.Text)) - SomaValor, 2)

        RestaValorGeral = RestaValor

        Dim dividido As Double
        dividido = FormatNumber((RestaValor), 2) / (Ds.Tables("Receber").Rows.Count - RowAlterada)

        dividido = Round(dividido, 2)

        Dim TestaValor As Double = dividido * (Ds.Tables("Receber").Rows.Count - RowAlterada)
        Dim ValorSobra As Double = Round(RestaValor - TestaValor, 2)


        QtdRowTemp = 0

        'Reajusta as parcelas abaixo da alterada o valor

        For Each Linha In Ds.Tables("Receber").Rows
            QtdRowTemp += 1
            If QtdRowTemp > RowAlterada Then
                Linha.BeginEdit()
                If QtdRowTemp = Ds.Tables("Receber").Rows.Count Then
                    Linha("ValorDocumento") = dividido + ValorSobra
                Else
                    Linha("ValorDocumento") = dividido
                End If

                Linha.EndEdit()
            End If
        Next

        Me.Parcelado.Text = NzZero(Ds.Tables("Receber").Compute("sum(ValorDocumento)", ""))
        Dim Tbl As New DataView(Ds.Tables("Receber").Copy)
        Me.ListaReceber.DataSource = Tbl.ToTable("Table", True, "Documento", "ValorDocumento", "Vencimento", "LocalPgto", "VencimentoOriginal")


        'Limpar as Caixas
        Me.txtDocumento.Clear()
        Me.txtVencimento.Clear()
        Me.txtValor.Clear()
        Me.txtLocalPgto.SelectedIndex = -1
    End Sub

    Private Sub btFinalizarVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFinalizarVenda.Click

        'Dim cxFechado As New CaixaFechado
        'cxFechado.CaixaEstaFechado()

        If MessageBox.Show("Deseja finalizar o pedido", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        qconfirmacao += 1
        ErroLivre = qconfirmacao & " - " & "Solicitado a confirmação do pedido"
        GerarLog(Me.Text, AçãoTP.Livre, My.Forms.SellShoes.Venda.Text)


        Me.btFinalizarVenda.Enabled = False

        If CDbl(NzZero(Me.TotalParcelamentoCheque.Text)) <> CDbl(NzZero(Me.ValorCheque.Text)) Then
            MessageBox.Show("O total dos parcelamento em cheque esta diferente do valor faturado para cheque, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btFinalizarVenda.Enabled = True
            Exit Sub
        End If


        If My.Forms.SellShoes.PedidoTipo.Text <> "DEVOLUÇÃO" Then
            If CDbl(NzZero(Me.Parcelado.Text)) <> CDbl(NzZero(Me.ValorFaturar.Text)) Then
                MessageBox.Show("O total das parcelas faturadas esta diferente do valor faturado, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.btFinalizarVenda.Enabled = True
                Exit Sub
            End If
        End If

        'verifica se a conexao ainda esta aberta
        If Cnn.State = ConnectionState.Closed Then
            Cnn.Open()
        End If
        Dim Transacao As OleDb.OleDbTransaction
        Transacao = Cnn.BeginTransaction()

        Dim CmdEmpresaComissao As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim CmdComissao As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim CmdComissaoAVISTA As OleDb.OleDbCommand = Cnn.CreateCommand


        CmdAVista.Transaction = Transacao
        CmdAPrazo.Transaction = Transacao
        CmdCheque.Transaction = Transacao
        CmdChTemp.Transaction = Transacao

        CmdEmpresaComissao.Transaction = Transacao
        CmdComissao.Transaction = Transacao
        CmdComissaoAVISTA.Transaction = Transacao


        If CDbl(NzZero(Me.ValorAVista.Text)) <> 0 Then
            If Ds.Tables.Contains("ReceberAvista") Then
                If Ds.Tables("ReceberAvista").Rows.Count = 0 Then
                    MessageBox.Show("Verifique o recebimento nâo foi criado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Me.Dispose()
                    Me.btFinalizarVenda.Enabled = True
                    Exit Sub
                Else
                    Dim VlrReceberGerado As Double = Ds.Tables("ReceberAvista").Compute("sum(ValorDocumento)", "")
                    Dim VlrReceberVerificar As Double = CDbl(Me.ValorAVista.Text)
                    If CDbl(VlrReceberGerado) <> CDbl(VlrReceberVerificar) Then
                        MessageBox.Show("Verifique o recebimento, os valores não estão corretos", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                        Me.Dispose()
                        Me.btFinalizarVenda.Enabled = True
                        Exit Sub
                    End If
                End If
            Else
                MessageBox.Show("Verifique o recebimento nâo foi criado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Me.Dispose()
                Me.btFinalizarVenda.Enabled = True
                Exit Sub
            End If
        End If

        Try

            If CDbl(NzZero(Me.ValorFaturar.Text)) <> 0 Then

                If Ds.Tables.Contains("Receber") Then
                    Dim I As Integer
                    For I = 0 To Ds.Tables("Receber").Rows.Count - 1
                        Ds.Tables("Receber").Rows(I).BeginEdit()
                        Ds.Tables("Receber").Rows(I)("Virtual") = False
                        Ds.Tables("Receber").Rows(I).EndEdit()
                    Next
                Else
                    MessageBox.Show("Não foi criado parcelas para o valor de faturar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Me.Dispose()
                    Me.btFinalizarVenda.Enabled = True
                    Exit Sub
                End If

                Dim ObjFaturar As New OleDb.OleDbCommandBuilder(DAFaturar)
                DAFaturar.Update(Ds, "Receber")
            End If

            If CDbl(NzZero(Me.ValorAVista.Text)) <> 0 Then
                Dim ObjAvista As New OleDb.OleDbCommandBuilder(DAAvista)
                DAAvista.Update(Ds, "ReceberAvista")
            End If

            If CDbl(NzZero(Me.ValorCheque.Text)) > 0 Then
                Dim ObjCheque As New OleDb.OleDbCommandBuilder(DACheque)
                DACheque.Update(Ds, "Cheque")

                Dim ObjChTemp As New OleDb.OleDbCommandBuilder(DaChTemp)
                DaChTemp.Update(Ds, "ReceberChTemp")
            End If


            'Confirmar o Pedido
            Dim Sql As String = String.Empty
            Sql = "SELECT * from Pedido Where PedidoSequencia  = " & My.Forms.SellShoes.Venda.Text

            Dim CmdVenda As New OleDb.OleDbCommand(Sql, Cnn)
            CmdVenda.Transaction = Transacao

            Dim DAVenda As New OleDb.OleDbDataAdapter(CmdVenda)
            DAVenda.Fill(Ds, "Venda")

            Ds.Tables("Venda").Rows(0).BeginEdit()
            Ds.Tables("Venda").Rows(0)("DataFechamento") = DataDia
            Ds.Tables("Venda").Rows(0)("Confirmado") = True
            Ds.Tables("Venda").Rows(0)("StatusAndamentos") = "FINALIZADO"
            Ds.Tables("Venda").Rows(0).EndEdit()

            Dim ObjVenda As New OleDb.OleDbCommandBuilder(DAVenda)
            DAVenda.Update(Ds, "Venda")
            'Fim da confirmação do Pedido


            'Fazer Lançamentos no caixa
            If CDbl(NzZero(Me.ValorAVista.Text)) <> 0 Then
                Sql = "SELECT * from LancamentoBanco Where Id  = -1"

                Dim CmdLcto As New OleDb.OleDbCommand(Sql, Cnn)
                CmdLcto.Transaction = Transacao

                Dim DALcto As New OleDb.OleDbDataAdapter(CmdLcto)

                DALcto.Fill(Ds, "Lcto")

                Dim DrNew As DataRow
                DrNew = Ds.Tables("Lcto").NewRow

                Dim Hist As String = String.Empty
                If My.Forms.SellShoes.PedidoTipo.Text = "DEVOLUÇÃO" Then
                    Hist = "DEV. " & My.Forms.SellShoes.Venda.Text
                Else
                    Hist = "RECEB. AVISTA VENDA. " & My.Forms.SellShoes.Venda.Text
                End If

                DrNew("DataLancamento") = DataDia
                DrNew("PreDatado") = False
                DrNew("DataPreDatado") = System.DBNull.Value
                DrNew("Documento") = My.Forms.SellShoes.Venda.Text
                DrNew("DataDocumento") = DataDia
                DrNew("TipoLancamento") = "C"
                DrNew("Favorecido") = My.Forms.SellShoes.xNome.Text
                DrNew("Historico") = Hist
                DrNew("CaiuBanco") = "S"
                DrNew("ConfirmadoLancamento") = True
                DrNew("Empresa") = CodEmpresa
                DrNew("ValorDocumento") = CDbl(Me.ValorAVista.Text)
                DrNew("ContaCorrente") = CaixaAtivo
                DrNew("EmitirCheque") = "N"
                DrNew("ContaBalancete") = Me.ContaBalanceteVendaAvista.Text
                DrNew("Tipo") = "CAIXA"
                DrNew("IdLancamento") = "SELLSHOES"
                DrNew("IdProcura") = My.Forms.SellShoes.Venda.Text
                Ds.Tables("Lcto").Rows.Add(DrNew)

                Dim ObjLcto As New OleDb.OleDbCommandBuilder(DALcto)
                DALcto.Update(Ds, "Lcto")

            End If

            'fim dos Lançamentos no Caixa


            'Atualiza tabela de Estoque
            Dim TpEst As String = String.Empty
            Dim NCliente As String = My.Forms.SellShoes.xNome.Text
            If My.Forms.SellShoes.PedidoTipo.Text = "VENDA" Then
                TpEst = "S"
                Sql = "INSERT INTO EstoqueUP (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc, Numero) SELECT ItensPedido.CodigoProduto, [Qtd]*-1 AS QtdEst, '" & TpEst & "' AS Expr1, 0 AS Expr2, Pedido.DataFechamento, Pedido.PedidoSequencia, 'SELLSHOES' AS Expr3,'" & NCliente & "' AS Expr4, '" & My.Forms.SellShoes.Venda.Text & "' As Expr5, ItensPedido.Numero FROM (ItensPedido INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & My.Forms.SellShoes.Venda.Text & ") AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Produtos.ControlaEstoque)='SIM'));"
                Dim CmdEstoque As New OleDb.OleDbCommand(Sql, Cnn)
                CmdEstoque.Transaction = Transacao
                CmdEstoque.ExecuteNonQuery()
            End If
            If My.Forms.SellShoes.PedidoTipo.Text = "DEVOLUÇÃO" Then
                TpEst = "E"
                Sql = "INSERT INTO EstoqueUP (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc, Numero) SELECT ItensPedido.CodigoProduto, [Qtd] AS QtdEst, '" & TpEst & "' AS Expr1, 0 AS Expr2, Pedido.DataFechamento, Pedido.PedidoSequencia, 'SELLSHOESDEV' AS Expr3,'" & NCliente & "' AS Expr4, '" & My.Forms.SellShoes.Venda.Text & "' As Expr5, ItensPedido.Numero FROM (ItensPedido INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & My.Forms.SellShoes.Venda.Text & ") AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Produtos.ControlaEstoque)='SIM'));"
                Dim CmdEstoque As New OleDb.OleDbCommand(Sql, Cnn)
                CmdEstoque.Transaction = Transacao
                CmdEstoque.ExecuteNonQuery()
            End If

            'Dim CmdEstoque As New OleDb.OleDbCommand(Sql, Cnn)
            'CmdEstoque.Transaction = Transacao
            'CmdEstoque.ExecuteNonQuery()
            'fim

            If My.Forms.SellShoes.PedidoTipo.Text = "DEVOLUÇÃO" Then

                Sql = "SELECT * from ItensPedido Where PedidoSequencia  = " & My.Forms.SellShoes.DevNumero.Text
                Dim CmdDev As New OleDb.OleDbCommand(Sql, Cnn)
                CmdDev.Transaction = Transacao

                Dim DADev As New OleDb.OleDbDataAdapter(CmdDev)
                DADev.Fill(Ds, "ITdev")

                For Each Linha As DataGridViewRow In My.Forms.SellShoes.Lista.Rows

                    Dim drIT() As DataRow
                    drIT = Ds.Tables("ITdev").Select("Id = " & NzZero(Linha.Cells("cDevolvidoId").Value))

                    If drIT.Length <> 0 Then
                        drIT(0).BeginEdit()
                        drIT(0)("QtdDevolvido") = CDbl(NzZero(drIT(0)("QtdDevolvido"))) + CDbl(NzZero(Linha.Cells("cQtd").Value))

                        If CDbl(NzZero(drIT(0)("QtdDevolvido"))) = CDbl(drIT(0)("Qtd")) Then
                            drIT(0)("Devolvido") = True
                        End If

                        drIT(0).EndEdit()
                    End If
                Next
                Dim ObjItDev As New OleDb.OleDbCommandBuilder(DADev)
                DADev.Update(Ds, "ITdev")

            End If


            If TipoComissaoVenda = "porFAIXA" Then

                CmdEmpresaComissao.CommandText = "Select * From EmpresaComissaoFaixa Where Empresa = " & CodEmpresa
                Dim DrEmpresaComissao As OleDb.OleDbDataReader

                DrEmpresaComissao = CmdEmpresaComissao.ExecuteReader
                DrEmpresaComissao.Read()

                Dim media_DESCONTO As Double = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.DescPercentual.Text)), 2)
                Dim ComissaoFaixaExecutar As Double = 0
                Dim ComissaoFaixaExecutarAVISTA As Double = 0
                If DrEmpresaComissao.HasRows = True Then
                    If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa1")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa2")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa3")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa4")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa5")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa6")

                    If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa1")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa2")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa3")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa4")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa5")
                    If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And NzZero(My.Forms.SellShoes.DescPercentual.Text) <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutarAVISTA = DrEmpresaComissao.Item("cFaixa6")
                End If

                Dim Func() As String = CType(My.Forms.SellShoes.Vendedor.Text, String).Split("-")
                If CDbl(NzZero(Me.ValorAVista.Text)) <> 0 Then
                    If CDbl(NzZero(ComissaoFaixaExecutar)) > 0 Then
                        Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, Pago, ComissaoFaturamento, OndeVeio, IdOrigem, Documento, DescComissao ) Values ( #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#,#" & Format(CDate(My.Forms.SellShoes.DataVenda.Text), "MM/dd/yyyy") & "# ," & Func(0) & " ," & My.Forms.SellShoes.Venda.Text & " , 0 ,'" & ComissaoFaixaExecutarAVISTA & "' ,'" & Me.ValorAVista.Text & "' ,'" & CDbl((CDbl(Me.ValorAVista.Text) * CDbl(ComissaoFaixaExecutarAVISTA)) / 100) & "' ,'porFAIXA' , False, False, 'SELLSHOES', " & My.Forms.SellShoes.Venda.Text & ", '" & DocReceberAvista & "', 'RECEB. AVISTA DOC: " & DocReceberAvista & "' )"
                        CmdComissaoAVISTA.CommandText = Sql
                        CmdComissaoAVISTA.ExecuteNonQuery()
                    End If
                End If

                If (NzZero(DrEmpresaComissao.Item("cFat"))) > 0 Then
                    Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, Pago, ComissaoFaturamento, OndeVeio, IdOrigem, Documento, DescComissao ) SELECT #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# AS DataLancamento, Pedido.DataPedido, Pedido.CódigoFuncionário, Pedido.PedidoSequencia, 0 AS Produto, EmpresaComissaoFaixa.cFat, Pedido.TotalPedido, ([TotalPedido]*[cFat])/100 AS ValorComissao, 'porFAIXA' AS TipoComissao, False AS Pago, True AS éFaturamento, 'SELLSHOES', " & My.Forms.SellShoes.Venda.Text & ", '" & My.Forms.SellShoes.Venda.Text & "', 'COMISSAO FAT. VENDA: " & My.Forms.SellShoes.Venda.Text & "' FROM Pedido INNER JOIN EmpresaComissaoFaixa ON Pedido.Empresa = EmpresaComissaoFaixa.Empresa WHERE (((Pedido.PedidoSequencia)=" & My.Forms.SellShoes.Venda.Text & "));"
                    CmdComissao.CommandText = Sql
                    CmdComissao.ExecuteNonQuery()
                End If

            End If

            'Throw New System.Exception()
            Transacao.Commit()
            Cnn.Close()
            Ds.Dispose()

            'impressao se for promissoria
            If My.Forms.SellShoes.PedidoTipo.Text <> "DEVOLUÇÃO" Then
                Dim VarPromissoria As String = My.Forms.SellShoes.TipoPgto.Text
                Dim posicao As Integer = VarPromissoria.IndexOf("33 - PROMISSÓRIA")

                If posicao = 0 Then
                    'Definir Impressão da NP
                    Dim cl As New cImpressNP 'Cria uma nova instância, nela encontra-se os metodos para impressão do NP.
                    cl.CodigoPedido = Convert.ToInt32(My.Forms.SellShoes.Venda.Text) 'passa o codigo da venda para a classe
                    cl.Impressao(False) 'Faz a impresão

                    'Se houve erro retorna um bolean true e cancela.
                    If cl.erro = True Then
                        MessageBox.Show("Erro ao tentar imprimir a nota promissória", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Cursor = Cursors.Default
                    End If

                    'RelatorioCarregar = "ImpressNP"
                    'My.Forms.VisualizadorRelatorio.ShowDialog()
                End If
            End If
            'fim

            If UsarGrade = True Then
                RelatorioCarregar = "Carne"
                My.Forms.VisualizadorRelatorio.ShowDialog()
            End If


            MessageBox.Show("Pedido confirmado com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ErroLivre = "Pedido Confirmado com sucesso"
            GerarLog(Me.Text, AçãoTP.Livre, My.Forms.SellShoes.Venda.Text)

        Catch ex As Exception
            Transacao.Rollback()
            Cnn.Close()
            MsgBox(ex.Message)
        End Try

        'Atualizar o Estoque do Cadastro de Produtos
        Dim EstoqueGeral As New EstoqueAtualizar
        EstoqueGeral.Run_AtualizadorEstoquePedido(My.Forms.SellShoes.Venda.Text)
        'fim

        'Atualizar o Estoque de Numeraçao
        If UsarGrade = True Then
            Dim EstoqueNumeracao As New EstoqueAtualizar
            EstoqueNumeracao.Run_AtualizadorNumeracao(My.Forms.SellShoes.Venda.Text)
        End If
        'fim

        My.Forms.SellShoes.Close()
        My.Forms.SellShoes.Dispose()
        My.Forms.SellShoesPendentes.EncherListaPendente()
        Me.Close()
        Me.Dispose()

    End Sub

    'Private Function AchaContaContrado()
    '    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    '    Dim Sql As String = "SELECT Contratos.CodContrato, Contratos.ContaCR FROM Contratos WHERE Contratos.CodContrato = '" & My.Forms.SellShoes.Contrato.SelectedValue & "'"

    '    Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
    '    Dim ds As New DataSet
    '    da.Fill(ds, "Table")

    '    Dim Conta As String = String.Empty
    '    If ds.Tables("Table").Rows.Count > 0 Then
    '        Conta = ds.Tables("Table").Rows(0)("ContaCr")
    '    End If

    '    ds.Dispose()
    '    Cnn.Close()

    '    Return Conta

    'End Function


    Private Sub Lista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista.DoubleClick
        Me.Cheque.Text = Me.Lista.CurrentRow.Cells("cCheque").Value
        Me.CC.Text = Me.Lista.CurrentRow.Cells("cCC").Value
        Me.ValorCh.Text = FormatNumber(NzZero(Me.Lista.CurrentRow.Cells("cValor").Value), 2)
        Me.Vencimento.Text = Me.Lista.CurrentRow.Cells("cVencimento").Value
        Me.BancoCheque.Text = Me.Lista.CurrentRow.Cells("CBancoCheque").Value
        Me.Titular.Text = Me.Lista.CurrentRow.Cells("cTitular").Value()
        Me.EntreguePor.Text = Me.Lista.CurrentRow.Cells("cEntreguePor").Value
        Me.Cheque.Focus()
    End Sub

    Private Sub btExcluirCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluirCheque.Click
        If Me.Cheque.Text = "" Then
            MsgBox("O Cheque não pode ser nulo.", 64, "Validação de Dados")
            Me.Cheque.Focus()
            Exit Sub
        ElseIf Me.CC.Text = "" Then
            MsgBox("A Conta Corrente não pode ser nula", 64, "Validação de Dados")
            Me.CC.Focus()
            Exit Sub
        End If

        Dim DrCheque() As DataRow
        DrCheque = Ds.Tables("Cheque").Select("Cheque = '" & Me.Cheque.Text & "' And CC = '" & Me.CC.Text & "'")

        If DrCheque.Length = 1 Then
            DrCheque(0).Delete()
        End If

        Me.TotalParcelamentoCheque.Text = NzZero(Ds.Tables("Cheque").Compute("sum(ValorCh)", ""))
        Me.Lista.DataSource = Ds.Tables("Cheque").DefaultView

        Me.Cheque.Clear()
        Me.CC.Clear()
        Me.ValorCh.Clear()
        Me.Vencimento.Clear()
        Me.BancoCheque.SelectedValue = -1
        Me.Titular.Clear()
        Me.EntreguePor.Clear()
        Me.Cheque.Focus()

    End Sub

    Private Sub txtVencimento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVencimento.Leave
        Dim DataVencimento As DateTime = CDate(Me.VencimentoOriginal.Text)
        Dim DataAlterada As DateTime = CDate(Me.txtVencimento.Text)


        Dim inicio As New DateTime(DataVencimento.Year, DataVencimento.Month, DataVencimento.Day) 'ano, mês, dia
        Dim fim As New DateTime(DataAlterada.Year, DataAlterada.Month, DataAlterada.Day) 'ano, mês, dia
        Dim dif As TimeSpan = fim.Subtract(inicio)
        Dim dias As Integer = dif.Days



        Select Case dias
            Case -5 To 5
                'Esta na faixa dos dias permitidos
            Case Else
                MessageBox.Show("A quantidade de dias não pode ser maior que 5, o sistema vai desfazer a operação.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtVencimento.Text = Format(DataVencimento, "dd/MM/yyyy")
                Exit Sub
        End Select

    End Sub

    
End Class