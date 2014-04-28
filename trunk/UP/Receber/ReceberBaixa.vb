Imports System.Data.OleDb
Public Class ReceberBaixa

    Dim DS As New DataSet()

    Dim Ação As New TrfGerais()

    'Variaveis para lancamento de contas Padrao
    Dim cbJuros As String = String.Empty
    Dim cbMulta As String = String.Empty
    Dim cbDesco As String = String.Empty
    Dim cbValor As String = String.Empty


    'Dim CCAnaliticaBanco As String

    Public IdContaLanc As String 'JUROS/MULTA/DESCONTO/VALORDOC
    Public CancChequePre As Boolean = False ' True para cancelar a baixa de Cheque pre

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        If Me.Baixado.Checked = False Then Me.Recebimento.Clear()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ReceberBaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizaDadosEmpresa()
        CarregaComboBox()
        'AchaRegistro()
        Me.DisplayCaixa.Text = "Caixa Ativo: " & CaixaAtivo & "-" & CaixaNomeVar
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
            cbJuros = DR.Item("cJurosReceber") & ""
            cbMulta = DR.Item("cMultaReceber") & ""
            cbDesco = DR.Item("cDescReceber") & ""
            cbValor = DR.Item("cValorReceber") & ""
        End If
        DR.Close()

    End Sub


    Public Sub AchaRegistro(ByVal Id As String)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT Receber.* FROM Receber LEFT JOIN Clientes ON Receber.CodCliente = Clientes.Codigo WHERE Receber.ID = " & Id
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            DR.Read()

            Me.CodCliente.Text = DR.Item("CodCliente")
            Me.Cliente.Text = DR.Item("Cliente")
            Me.Id.Text = DR.Item("Id")
            Me.Pedido.Text = DR.Item("PedidoProdutos") & ""
            Me.Documento.Text = DR.Item("Documento") & ""
            Me.DataDocumento.Text = DR.Item("DataDocumento")
            Me.Vencimento.Text = DR.Item("Vencimento")
            Me.ValorJuros.Text = FormatCurrency(NzZero(DR.Item("Valorjuros")), 2)
            Me.Multa.Text = FormatCurrency(Nz(NzZero(DR.Item("Multa")), 3), 2)
            Me.ValorDocumento.Text = FormatCurrency(NzZero(DR.Item("ValorDocumento")), 2)
            Me.ValorDesconto.Text = FormatCurrency(NzZero(DR.Item("ValorDesconto")), 2)
            Me.ValorLiquido.Text = FormatCurrency(NzZero(DR.Item("ValorLiquido")), 2)
            Me.Recebimento.Text = DR.Item("Recebimento") & ""
            Me.LocalPgto.Text = UCase(DR.Item("LocalPgto") & "")
            Me.Banco.Text = DR.Item("Banco") & ""
            Me.DocRecebBanco.Text = DR.Item("DocRecebBanco") & ""
            Me.Referencia.Text = DR.Item("Referencia") & ""
            Me.Baixado.Checked = DR.Item("Baixado")
            Me.NotaFiscal.Text = DR.Item("NotaFiscal") & ""
            Me.DiasAtraso.Text = DateDiff(DateInterval.Day, CType(DR.Item("Vencimento"), Date), CType(DataDia, Date))
            Me.MediaDescontoPedido.Text = FormatNumber(NzZero(DR.Item("MediaDescontoPedido")), 2)
            Me.Vendedor.Text = DR.Item("Vendedor") & ""
            Me.ControlePedido.Text = DR.Item("ControlePedido") & ""
            Me.PercentComissao.Text = FormatNumber(NzZero(DR.Item("PercentComissao")), 2)
            Me.ContaValorBaixado.Text = DR.Item("ContaValorBaixado") & ""

            Dim IsDev As String = Me.Documento.Text

            'If IsDev.IndexOf("D") = 0 Then
            '    Me.Referencia.Enabled = False
            'Else
            '    Me.Referencia.Enabled = True
            'End If

            If NzZero(Me.ValorDocumento.Text) < 0 Then
                Me.JurosP.Text = FormatNumber(0, 2)
                Me.ValorJuros.Text = FormatNumber(0, 2)
                Me.MultaP.Text = FormatNumber(0, 2)
                Me.Multa.Text = FormatNumber(0, 2)
                Me.ValorDesconto.Text = FormatNumber(0, 2)

                Me.JurosP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.ValorJuros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.MultaP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.Multa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Else
                Me.JurosP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ValorJuros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.MultaP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.Multa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            End If
            AchaContaBalancete(Me.ContaValorBaixado.Text, Me.ContaValorBaixadoDesc)
            ' MsgBox(DateDiff(DateInterval.Day, CType(DataDia, Date), CType(DR.Item("Vencimento"), Date)))

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub

    Private Sub Desconto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorDesconto.Enter
        If Me.ValorDesconto.Text = "" Then Me.ValorDesconto.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub Valorjuros_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorJuros.Enter
        If Me.ValorJuros.Text = "" Then Me.ValorJuros.Text = FormatCurrency(0, 2)

        If Me.JurosP.Text = "" Then Me.JurosP.Text = FormatNumber(0, 2)

        If CDbl(Me.DiasAtraso.Text) > 3 Then
            If Me.JurosP.Text > FormatNumber(0, 2) Then
                Dim JDias As Double = FormatNumber((Me.JurosP.Text / 30) * CDbl(Me.DiasAtraso.Text), 2)
                Me.ValorJuros.Text = FormatNumber((CDbl(Me.ValorDocumento.Text) * CDbl(JDias)) / 100, 2)
            End If
        End If

    End Sub

    Private Sub ValorLiquido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorLiquido.Enter
        If Me.ValorDesconto.Text = "" Then Me.ValorDesconto.Text = FormatCurrency(0, 2)
        If Me.ValorJuros.Text = "" Then Me.ValorJuros.Text = FormatCurrency(0, 2)
        If Me.Multa.Text = "" Then Me.Multa.Text = FormatCurrency(0, 2)
        Me.ValorLiquido.Text = FormatCurrency(CDbl(Me.ValorDocumento.Text) + CDbl(Me.ValorJuros.Text) + CDbl(Me.Multa.Text) - CDbl(Me.ValorDesconto.Text), 2)


        If NzZero(Me.ValorLiquido.Text) < 0 Then
            Me.ValorLiquido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.ValorLiquido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If

    End Sub

    Private Sub LocalPgto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocalPgto.Leave

        If Me.LocalPgto.Text = "BANCO" Then
            Me.Banco.Visible = True
            Me.DocRecebBanco.Visible = True
            Me.BancoDesc.Visible = True
            Me.LabelBanco.Visible = True
            Me.LabelDocCheque.Visible = True
            Me.Banco.Focus()
        End If

        If Me.LocalPgto.Text = "CARTEIRA" Then
            Me.Banco.Visible = False
            Me.DocRecebBanco.Visible = False
            Me.BancoDesc.Visible = False
            Me.LabelBanco.Visible = False
            Me.LabelDocCheque.Visible = False
            Me.JurosP.Focus()
        End If

        If Me.LocalPgto.Text = "CHEQUE PRE-DATADO" Then
            Me.Banco.Visible = False
            Me.DocRecebBanco.Visible = False
            Me.BancoDesc.Visible = False
            Me.LabelBanco.Visible = False
            Me.LabelDocCheque.Visible = False
            Me.JurosP.Focus()
        End If

    End Sub

    Private Sub btBaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaixa.Click

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuário deve selecionar um caixa antes de baixar o documento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.btBaixa.Enabled = False

        If Me.Recebimento.Text = "" Then
            MsgBox("A data de Pagamento não foi informada, verifique", 64, "Validação de Dados")
            Me.Recebimento.Focus()
            Me.btBaixa.Enabled = True
            Exit Sub
        End If

        If FormatNumber(Me.ValorLiquido.Text, 2) = FormatNumber(0, 2) Then
            MsgBox("O Valor liquido para baixa do Documento não pode ser zero, verifique", 64, "Validação de Dados")
            Me.ValorLiquido.Focus()
            Me.btBaixa.Enabled = True
            Exit Sub
        End If

        If Me.Recebimento.Text <> DataDia Then
            MsgBox("Favor verificar......." & Chr(13) & "A Data de Recebimento esta diferente da data do dia do Caixa, o documento não pode ser baixado.", 64, "Validação de Dados")
            Me.Recebimento.Clear()
            Me.Recebimento.Focus()
            Me.btBaixa.Enabled = True
            Exit Sub
        End If

        If Me.Pedido.Text = "" Then
            If Me.LocalPgto.Text = "CHEQUE PRE-DATADO" Then
                If MsgBox("O Pedido esta vazio ou nulo para esta conta não pode ser feito o lançamento de Cheque-Pre-Datado, deseja informar o Nrº do Pidido", 36, "Validação de Dados") = 6 Then
                    Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                    Me.Pedido.Focus()
                    Me.btBaixa.Enabled = True
                    Exit Sub
                Else
                    Me.LocalPgto.Text = "CARTEIRA"
                    Me.Recebimento.Focus()
                    Me.btBaixa.Enabled = True
                    Exit Sub
                End If
            End If
        End If

        If Me.Pedido.Text = "0" Then
            If Me.LocalPgto.Text = "CHEQUE PRE-DATADO" Then
                If MsgBox("O Pedido está como zero/vazio/nulo para esta conta não pode ser feito o lançamento de Cheque-Pre-Datado, deseja informar o Nrº do Pidido", 36, "Validação de Dados") = 6 Then
                    Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                    Me.Pedido.Focus()
                    Me.btBaixa.Enabled = True
                    Exit Sub
                Else
                    Me.LocalPgto.Text = "CARTEIRA"
                    Me.Recebimento.Focus()
                    Me.btBaixa.Enabled = True
                    Exit Sub
                End If
            End If
        End If

        If Me.Baixado.Checked = True Then
            MsgBox("O documento já foi baixado, escolha outro", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.LocalPgto.Text = "BANCO" Then
            If Me.Banco.Text = "" Then
                MsgBox("Para pagamento em banco à conta corrente não pode ser nula", 64, "Validação de Dados")
                Me.Banco.Focus()
                Me.btBaixa.Enabled = True
                Exit Sub
            End If
            If Me.DocRecebBanco.Text = "" Then
                MsgBox("Para pagamento em banco o documento de recebimento em banco não pode ser nulo", 64, "Validação de Dados")
                Me.DocRecebBanco.Focus()
                Me.btBaixa.Enabled = True
                Exit Sub
            End If
        End If


        If FormatCurrency(Me.ValorJuros.Text, 2) > FormatCurrency(0, 2) And Me.ContaJuros.Text = "" Then
            MessageBox.Show("O usuário deve informar a conta de lançamento para os Juros.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ContaJuros.Focus()
            Exit Sub
        End If
        If FormatCurrency(Me.Multa.Text, 2) > FormatCurrency(0, 2) And Me.ContaMulta.Text = "" Then
            MessageBox.Show("O usuário deve informar a conta de lançamento para a Multa.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ContaMulta.Focus()
            Exit Sub
        End If
        If FormatCurrency(Me.ValorDesconto.Text, 2) > FormatCurrency(0, 2) And Me.ContaDesconto.Text = "" Then
            MessageBox.Show("O usuário deve informar a conta de lançamento para os Descontos.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ContaDesconto.Focus()
            Exit Sub
        End If
        If FormatCurrency(Me.ValorLiquido.Text, 2) > FormatCurrency(0, 2) And Me.ContaValorBaixado.Text = "" Then
            MessageBox.Show("O usuário deve informar a conta de lançamento para os juros.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ContaValorBaixado.Focus()
            Exit Sub
        End If


        Me.Refresh()

        Dim TotalDoc As String
        TotalDoc = (CDbl(NzZero(Me.ValorDocumento.Text)) + CDbl(NzZero(Me.Multa.Text)) + CDbl(NzZero(Me.ValorJuros.Text))) - CDbl(NzZero(Me.ValorDesconto.Text))
        TotalDoc = CDbl(TotalDoc)

        If DiaFechado = False Then
            If Me.LocalPgto.Text = "CHEQUE PRE-DATADO" Then
                My.Forms.ChequePreLancar.ShowDialog()

                If CancChequePre = True Then
                    MessageBox.Show("Baixa de Documento em CHEQUE PRE-DATADO foi cancelada", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Me.Baixado.Checked = True

                Dim CNNCh As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                CNNCh.Open()

                Dim TransacaoCH As OleDbTransaction = CNNCh.BeginTransaction()

                Dim CmdBxCH As OleDbCommand = CNNCh.CreateCommand
                Dim CmdBxCHParcial As OleDbCommand = CNNCh.CreateCommand
                Dim CmdCreditoCliCH As OleDbCommand = CNNCh.CreateCommand

                CmdBxCH.Transaction = TransacaoCH
                CmdBxCHParcial.Transaction = TransacaoCH
                CmdCreditoCliCH.Transaction = TransacaoCH


                Try
                    Dim VarLiquido As Double = CDbl(NzZero(Me.ValorLiquido.Text))
                    If TotalDoc < 0 Then
                        VarLiquido = VarLiquido * -1
                        TotalDoc = TotalDoc * -1
                    End If
                    If CDbl(TotalDoc) > CDbl(VarLiquido) Then

                        Dim Diferença As Double = CDbl(NzZero(Me.ValorDocumento.Text)) - (CDbl(NzZero(Me.ValorLiquido.Text)) + CDbl(NzZero(Me.ValorDesconto.Text)) - CDbl(NzZero(Me.ValorJuros.Text)) - CDbl(NzZero(Me.Multa.Text)))
                        MsgBox("O valor do documento esta diferente do total, será criado um documento com a diferença: " & Diferença, 64, "Validação de Dados")


                        CmdBxCHParcial.CommandText = "INSERT INTO Receber (Cliente, CodCliente, DataDocumento, Documento, Empresa, ValorDocumento, Vencimento, LocalPgto, PedidoProdutos, NotaFiscal, OriginalParcial, VinculoBXPARCIAL, Vendedor, MediaDescontoPedido, ControlePedido, PercentComissao, ContaValorBaixado) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"

                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cliente.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CodCliente.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataDocumento.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Documento.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@5", CodEmpresa))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Diferença, 3)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.LocalPgto.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Pedido.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.NotaFiscal.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@11", "P"))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Id.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Vendedor.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.MediaDescontoPedido.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.ControlePedido.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.PercentComissao.Text, 1)))
                        CmdBxCHParcial.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.ContaValorBaixado.Text, 1)))


                        CmdBxCHParcial.ExecuteNonQuery()
                    End If


                    CmdBxCH.CommandText = "Update Receber set CodCliente = @1, Cliente = @2, Documento = @3, DataDocumento = @4, Vencimento = @5, Valorjuros = @6, ValorDocumento = @7, ValorDesconto = @8, ValorLiquido = @9, Recebimento = @10, LocalPgto = @11, Banco = @12, DocRecebBanco = @13, Referencia = @14, Baixado = @15, Multa = @16, ContaDesconto = @17, ContaJuros = @18, ContaMulta = @19, ContaValorBaixado = @20, CaixaBaixado = @21 Where Id = " & Me.Id.Text

                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodCliente.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataDocumento.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Vencimento.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorJuros.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorDocumento.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorDesconto.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.ValorLiquido.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Recebimento.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.LocalPgto.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Banco.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.DocRecebBanco.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Referencia.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@15", Me.Baixado.Checked))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Multa.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.ContaDesconto.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ContaJuros.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.ContaMulta.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.ContaValorBaixado.Text, 1)))
                    CmdBxCH.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(CaixaAtivo, 1)))
                    CmdBxCH.ExecuteNonQuery()


                    Dim VlrTemp As Double = (CDbl(NzZero(Me.ValorDocumento.Text)) + CDbl(NzZero(Me.ValorJuros.Text)) + CDbl(NzZero(Me.Multa.Text))) - CDbl(NzZero(Me.ValorDesconto.Text))
                    Dim VlrLiq As Double = CDbl(NzZero(Me.ValorLiquido.Text))
                    If VlrLiq > VlrTemp Then
                        MessageBox.Show("O valor lançado é maior do que os valores a serem cobrados", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    TransacaoCH.Commit()
                    MsgBox("Documento Baixado.", 64, "Validação de Dados")
                    GerarLog(Me.Text, AçãoTP.Confirmou, Me.Id.Text)

                    CNNCh.Close()
                    Me.Close()
                    Me.Dispose()
                    Exit Sub
                Catch ex As Exception
                    TransacaoCH.Rollback()
                    MsgBox("Erro na Baixa do Documento.", 64, "Validação de Dados")
                    MsgBox(ex.Message, 64, "Validação de Dados")
                    CNNCh.Close()
                    Exit Sub
                End Try
            End If

            '********************Rotina destinada para baixa que nao seja de cheque pre datado************************
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Transacao As OleDbTransaction = CNN.BeginTransaction()

            Dim CmdBanco As OleDbCommand = CNN.CreateCommand
            Dim CmdJuros As OleDbCommand = CNN.CreateCommand
            Dim CmdMulta As OleDbCommand = CNN.CreateCommand
            Dim CmdDesconto As OleDbCommand = CNN.CreateCommand
            Dim CmdBaixa As OleDbCommand = CNN.CreateCommand
            Dim CmdBXParcial As OleDbCommand = CNN.CreateCommand
            Dim CmdEmpresaComissao As OleDbCommand = CNN.CreateCommand
            Dim CmdComissao As OleDbCommand = CNN.CreateCommand
            Dim CmdCreditoCli As OleDbCommand = CNN.CreateCommand


            CmdBanco.Transaction = Transacao
            CmdJuros.Transaction = Transacao
            CmdMulta.Transaction = Transacao
            CmdDesconto.Transaction = Transacao
            CmdBaixa.Transaction = Transacao
            CmdBXParcial.Transaction = Transacao
            CmdEmpresaComissao.Transaction = Transacao
            CmdComissao.Transaction = Transacao
            CmdCreditoCli.Transaction = Transacao

            Try
                'Baixa Parcial
                Dim VarLiquido As Double = CDbl(Me.ValorLiquido.Text)
                If TotalDoc < 0 Then
                    VarLiquido = VarLiquido * -1
                    TotalDoc = TotalDoc * -1
                End If
                If CDbl(TotalDoc) > CDbl(VarLiquido) Then

                    Dim Diferença As Double = CDbl(Me.ValorDocumento.Text) - (CDbl(Me.ValorLiquido.Text) + CDbl(Me.ValorDesconto.Text) - CDbl(Me.ValorJuros.Text) - CDbl(Me.Multa.Text))
                    MsgBox("O valor do documento esta diferente do total, será criado um documento com a diferença: " & Diferença, 64, "Validação de Dados")


                    CmdBXParcial.CommandText = "INSERT INTO Receber (Cliente, CodCliente, DataDocumento, Documento, Empresa, ValorDocumento, Vencimento, LocalPgto, PedidoProdutos, NotaFiscal, OriginalParcial, VinculoBXPARCIAL, Vendedor, MediaDescontoPedido, ControlePedido, PercentComissao, ContaValorBaixado) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"

                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cliente.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CodCliente.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataDocumento.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Documento.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@5", CodEmpresa))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Diferença, 3)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.LocalPgto.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Pedido.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.NotaFiscal.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@11", "P"))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Id.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Vendedor.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.MediaDescontoPedido.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.ControlePedido.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.PercentComissao.Text, 1)))
                    CmdBXParcial.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.ContaValorBaixado.Text, 1)))


                    CmdBXParcial.ExecuteNonQuery()
                End If

                'Fim da Baixa Parcial

                Dim Tp As String = String.Empty
                Dim CC As String = String.Empty
                Dim Doc As String = String.Empty
                Dim xCompensado As String = String.Empty

                If Me.LocalPgto.Text = "BANCO" Then
                    Tp = "BANCO"
                    CC = Me.Banco.Text
                    Doc = Me.DocRecebBanco.Text
                    xCompensado = "N"
                Else
                    Tp = "CAIXA"
                    CC = CaixaAtivo
                    Doc = Me.Documento.Text
                    xCompensado = "S"
                End If

                Dim VlrTemp As Double = FormatNumber((CDbl(NzZero(Me.ValorDocumento.Text)) + CDbl(NzZero(Me.ValorJuros.Text)) + CDbl(NzZero(Me.Multa.Text))) - CDbl(NzZero(Me.ValorDesconto.Text)), 2)
                Dim VlrLiq As Double = CDbl(NzZero(Me.ValorLiquido.Text))


                If VlrTemp > 0 Then
                    If VlrLiq > VlrTemp Then

                        Dim Diferença As Double = VlrTemp - VlrLiq
                        MessageBox.Show("O valor lançado é maior do que os valores a serem cobrados", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Else

                    If VlrLiq < VlrTemp Then
                        MessageBox.Show("O valor lançado é maior do que os valores a serem cobrados.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                    CmdBanco.CommandText = "INSERT INTO LancamentoBanco (DataLancamento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Documento, ValorDocumento, EmitirCheque, ConfirmadoLancamento, Empresa, Historico, CaiuBanco, DocumentoExterno, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"

                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                    Dim ValorLanc As Double = (CDbl(NzZero(Me.ValorLiquido.Text)) - CDbl(NzZero(Me.ValorJuros.Text)) - CDbl(NzZero(Me.Multa.Text))) + CDbl(NzZero(Me.ValorDesconto.Text))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataDocumento.Text, 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@3", Nz("C", 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(CC, 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Mid("RECEB: " & UCase(Me.Cliente.Text), 1, 80), 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Doc, 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@7", ValorLanc))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("N", 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@9", True))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Referencia.Text, 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(xCompensado, 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@13", True))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ContaValorBaixado.Text, 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Tp, 1)))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@16", "RECEBER"))
                    CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Id.Text, 1)))
                    CmdBanco.ExecuteNonQuery()

                    If Me.ValorJuros.Text > 0 Then
                        CmdJuros.CommandText = "INSERT INTO LancamentoBanco (DataLancamento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Documento, ValorDocumento, EmitirCheque, ConfirmadoLancamento, Empresa, Historico, CaiuBanco, DocumentoExterno, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"

                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataDocumento.Text, 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@3", Nz("C", 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(CC, 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Mid("REC. JUROS: " & UCase(Me.Cliente.Text), 1, 80), 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Doc, 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorJuros.Text, 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("N", 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@9", True))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@11", Nz("RECEB. DE JUROS DOC Nº " & Me.Documento.Text, 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(xCompensado, 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@13", True))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ContaJuros.Text, 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Tp, 1)))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@16", "RECEBER"))
                        CmdJuros.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Id.Text, 1)))
                        CmdJuros.ExecuteNonQuery()
                    End If

                    If Me.Multa.Text > 0 Then
                        CmdMulta.CommandText = "INSERT INTO LancamentoBanco (DataLancamento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Documento, ValorDocumento, EmitirCheque, ConfirmadoLancamento, Empresa, Historico, CaiuBanco, DocumentoExterno, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"

                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataDocumento.Text, 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@3", Nz("C", 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(CC, 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Mid("REC. MULTA:" & UCase(Me.Cliente.Text), 1, 80), 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Doc, 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Multa.Text, 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("N", 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@9", True))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@13", Nz("RECEB DE MULTA DOC Nº " & Me.Documento.Text, 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(xCompensado, 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@15", True))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ContaMulta.Text, 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Tp, 1)))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@16", "RECEBER"))
                        CmdMulta.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Id.Text, 1)))
                        CmdMulta.ExecuteNonQuery()
                    End If

                    If Me.ValorDesconto.Text > 0 Then
                        CmdDesconto.CommandText = "INSERT INTO LancamentoBanco (DataLancamento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Documento, ValorDocumento, EmitirCheque, ConfirmadoLancamento, Empresa, Historico, CaiuBanco, DocumentoExterno, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"

                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataDocumento.Text, 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@3", Nz("D", 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(CC, 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Mid("DESC. CONCEDIDO P/" & UCase(Me.Cliente.Text), 1, 80), 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Doc, 1)))
                        Dim VlrDesc As Double = NzZero(Me.ValorDesconto.Text) * -1
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@7", VlrDesc))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("N", 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@9", True))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@13", Nz("DESC. CONCEDIDO DOC Nº " & Me.Documento.Text, 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(xCompensado, 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@15", True))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ContaDesconto.Text, 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Tp, 1)))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@16", "RECEBER"))
                        CmdDesconto.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Id.Text, 1)))
                        CmdDesconto.ExecuteNonQuery()
                    End If

                    'Baixar o documento
                    Me.Baixado.Checked = True

                CmdBaixa.CommandText = "Update Receber set CodCliente = @1, Cliente = @2, Documento = @3, DataDocumento = @4, Vencimento = @5, Valorjuros = @6, ValorDocumento = @7, ValorDesconto = @8, ValorLiquido = @9, Recebimento = @10, LocalPgto = @11, Banco = @12, DocRecebBanco = @13, Referencia = @14, Baixado = @15, Multa = @16, ContaDesconto = @17, ContaJuros = @18, ContaMulta = @19, ContaValorBaixado = @20, CaixaBaixado = @21, DiasAtraso = @22, JurosP = @23, MultaP = @24 Where Id = " & Me.Id.Text

                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodCliente.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataDocumento.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Vencimento.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorJuros.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorDocumento.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorDesconto.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.ValorLiquido.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Recebimento.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.LocalPgto.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Banco.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.DocRecebBanco.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Referencia.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@15", Me.Baixado.Checked))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Multa.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.ContaDesconto.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ContaJuros.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.ContaMulta.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.ContaValorBaixado.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(CaixaAtivo, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.DiasAtraso.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.JurosP.Text, 1)))
                CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.MultaP.Text, 1)))

                CmdBaixa.ExecuteNonQuery()

                If TipoComissaoVenda = "porFAIXA" Then

                    Dim ComissaoFaixaExecutar As Double = NzZero(Me.PercentComissao.Text)
                    If ComissaoFaixaExecutar > 0 Then

                        If CDbl(NzZero(Me.ValorLiquido.Text)) <> 0 Then
                            Dim ValorAComisssionar As Double = CDbl(NzZero(Me.ValorLiquido.Text)) - CDbl(NzZero(Me.ValorJuros.Text)) - CDbl(NzZero(Me.Multa.Text))

                            CmdComissao.CommandText = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, Pago, ComissaoFaturamento, OndeVeio, IdOrigem, Documento, DescComissao ) Values ( #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#,#" & Format(CDate(Me.Recebimento.Text), "MM/dd/yyyy") & "# ," & Me.Vendedor.Text & " ," & Me.Pedido.Text & " , 0 ,'" & ComissaoFaixaExecutar & "' ,'" & ValorAComisssionar & "' ,'" & CDbl((CDbl(ValorAComisssionar) * CDbl(ComissaoFaixaExecutar)) / 100) & "' ,'porFAIXA' , False, False, 'RECEBER', " & Me.Id.Text & ", '" & Me.Documento.Text & "', 'RECEB. DOC: " & Me.Documento.Text & "' )"
                            CmdComissao.ExecuteNonQuery()
                        End If
                    End If

                End If


                My.Forms.ReceberBaixaVerTroco.ShowDialog()

                Transacao.Commit()
                  
                MsgBox("Documento Baixado.", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.Documento.Text)
                CNN.Close()

                If UsaSellShoes = False Then
                    RelatorioCarregar = "RelReciboReceber"
                    My.Forms.VisualizadorRelatorio.ShowDialog()
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
                    VerRelat.Load(DirRelat & "ReciboReceber7Col.rpt")
                    VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
                    VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))
                    VerRelat.DataDefinition.RecordSelectionFormula = "{Receber.Id} = " & Me.Id.Text

                    Vz.ReportSource = VerRelat
                    Tel.Controls.Add(Vz)
                    Tel.ShowDialog()

                End If

                Me.Close()
                Me.Dispose()

            Catch ex As Exception
                MsgBox("Erro na Baixa do Documento.", 64, "Validação de Dados")
                Transacao.Rollback()
                MsgBox(ex.Message, 64, "Validação de Dados")
                CNN.Close()
            End Try

        Else
            MsgBox("O lançamento não pode ser feito em um caixa ja fechado", 64, "Validação de Dados")
            Me.Recebimento.Clear()
            Me.Baixado.Checked = False
            Me.Documento.Focus()
        End If

    End Sub

    Private Sub ValorLiquido_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorLiquido.Leave
        If Me.ValorLiquido.Text = "" Then
            Me.ValorLiquido.Text = FormatCurrency(0, 2)
        Else
            Me.ValorLiquido.Text = FormatCurrency(Me.ValorLiquido.Text, 2)
        End If

        If CDbl(NzZero(Me.ValorLiquido.Text)) > 0 And CDbl(NzZero(Me.ValorDocumento.Text)) < 0 Then
            MessageBox.Show("O usuário não pode usar valores positivo em baixas negativas", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorLiquido.Text = Me.ValorLiquido.Text * -1
            Me.ValorLiquido.Focus()
        End If
    End Sub

    Private Sub Multa_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Multa.Enter
        If Me.Multa.Text = "" Then Me.Multa.Text = FormatCurrency(0, 2)

        If Me.MultaP.Text = "" Then Me.MultaP.Text = FormatNumber(0, 2)

        If CDbl(Me.DiasAtraso.Text) > 3 Then
            If Me.MultaP.Text > FormatNumber(0, 2) Then
                '  Dim JDias As Double = FormatNumber((Me.MultaP.Text / 30) * CDbl(Me.DiasAtraso.Text), 2)
                Me.Multa.Text = FormatNumber((CDbl(Me.ValorDocumento.Text) * CDbl(NzZero(Me.MultaP.Text))) / 100, 2)
            End If
        End If
    End Sub

    Private Sub Banco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Banco.KeyDown
        If e.KeyCode = Keys.F5 Then
            'ChamaTelaProcura("Codigo", "Descrição", "", "Banco", "Codigo", "ContaCorrente", "", True)
            My.Forms.BancoBuscaConta.ShowDialog()
            Me.Banco.Text = RetornoProcura
        End If
    End Sub

    Private Sub Banco_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Banco.Leave
        AchaContaBanco()
    End Sub

    Private Sub AchaContaBanco()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Banco WHERE Codigo = '" & Me.Banco.Text & "' and Banco.Inativo = False"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                Me.BancoDesc.Text = DR.Item("ContaCorrente") & "-" & DR.Item("NomeBanco")
            Else
                MessageBox.Show("Conta não encontrada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Banco.Clear()
                Me.Banco.Focus()
                Exit Sub
            End If

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
        End Try
        Cnn.Close()
    End Sub

    Private Sub Recebimento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Recebimento.Enter

        If Me.Recebimento.Text = "" Then Me.Recebimento.Text = DataDia
    End Sub

    Private Sub CarregaComboBox()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * From LocalPagamento Where Empresa = " & CodEmpresa
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(DS, "LocalPgto")

        Me.LocalPgto.DataSource = DS.Tables("LocalPgto")
        Me.LocalPgto.ValueMember = "LocalPgto"
        Me.LocalPgto.DisplayMember = "LocalPgto"
        Cnn.Close()

    End Sub

    Private Sub LocalPgto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalPgto.SelectedIndexChanged

    End Sub

    Private Sub Referencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Referencia.Enter
        If Len(Me.Referencia.Text) = 0 Then
            Me.Referencia.Text = "Bx Doc.: " & Me.Documento.Text & " " & Me.CodCliente.Text & "-" & Me.Cliente.Text
            Me.Referencia.SelectionStart = Len(Me.Referencia.Text)
        End If
    End Sub

    Private Sub ContaJuros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaJuros.KeyDown
        If e.KeyCode = Keys.F5 Then
            IdContaLanc = "JUROS" 'JUROS/MULTA/DESCONTO/VALORDOC
            My.Forms.BalanceteContasProcura.TipoConta = "C"
            My.Forms.BalanceteContasProcura.ShowDialog()
        End If
    End Sub

    Private Sub ContaMulta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaMulta.KeyDown
        If e.KeyCode = Keys.F5 Then
            IdContaLanc = "MULTA" 'JUROS/MULTA/DESCONTO/VALORDOC
            My.Forms.BalanceteContasProcura.TipoConta = "C"
            My.Forms.BalanceteContasProcura.ShowDialog()
        End If
    End Sub

    Private Sub ContaDesconto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaDesconto.KeyDown
        If e.KeyCode = Keys.F5 Then
            IdContaLanc = "DESCONTO" 'JUROS/MULTA/DESCONTO/VALORDOC
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
        End If
    End Sub

    Private Sub ContaValorBaixado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaValorBaixado.KeyDown
        If e.KeyCode = Keys.F5 Then
            IdContaLanc = "VALORDOC" 'JUROS/MULTA/DESCONTO/VALORDOC
            My.Forms.BalanceteContasProcura.TipoConta = "C"
            My.Forms.BalanceteContasProcura.ShowDialog()
        End If
    End Sub


    Private Sub ContaJuros_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaJuros.Leave
        If String.CompareOrdinal(Me.ContaJuros.Text, Me.ContaJuros.TextoAntigo) Then
            AchaContaBalancete(Me.ContaJuros.Text, Me.ContaJurosDesc)
        End If
    End Sub

    Private Sub ContaMulta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaMulta.Leave
        If String.CompareOrdinal(Me.ContaMulta.Text, Me.ContaMulta.TextoAntigo) Then
            AchaContaBalancete(Me.ContaMulta.Text, Me.ContaMultaDesc)
        End If
    End Sub

    Private Sub ContaDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaDesconto.Leave
        If String.CompareOrdinal(Me.ContaDesconto.Text, Me.ContaDesconto.TextoAntigo) Then
            AchaContaBalancete(Me.ContaDesconto.Text, Me.ContaDescontoDesc)
        End If
    End Sub

    Private Sub ContaValorBaixado_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaValorBaixado.Leave
        If String.CompareOrdinal(Me.ContaValorBaixado.Text, Me.ContaValorBaixado.TextoAntigo) Then
            AchaContaBalancete(Me.ContaValorBaixado.Text, Me.ContaValorBaixadoDesc)
        End If
    End Sub


    Public Sub AchaContaBalancete(ByVal ContaBalancete As String, ByVal CampoParaRetornar As Control)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from ContasG3 where ContaGrupo3 = '" & ContaBalancete & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescContaGrupo3") & ""
        End If
        Cnn.Close()
    End Sub

    Private Sub ContaJuros_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaJuros.Enter
        If Me.ValorJuros.Text <> 0 And Me.ContaJuros.Text = "" Then
            Me.ContaJuros.Text = cbJuros
        End If
    End Sub

    Private Sub ContaMulta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaMulta.Enter
        If Me.Multa.Text <> 0 And Me.ContaMulta.Text = "" Then
            Me.ContaMulta.Text = cbMulta
        End If
    End Sub

    Private Sub ContaDesconto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaDesconto.Enter
        If Me.ValorDesconto.Text <> 0 And Me.ContaDesconto.Text = "" Then
            Me.ContaDesconto.Text = cbDesco
        End If
    End Sub

    Private Sub ContaValorBaixado_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaValorBaixado.Enter
        If Me.ValorLiquido.Text <> 0 And Me.ContaValorBaixado.Text = "" Then
            If Me.ContaValorBaixado.Text = "" Then Me.ContaValorBaixado.Text = cbValor
        End If
    End Sub

    Private Sub ValorJuros_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorJuros.Validated
        If Me.ValorJuros.Text = "" Then Me.ValorJuros.Text = FormatNumber(0, 2)
        If Me.ValorJuros.Text = 0 Then
            Me.ContaJuros.Clear()
            Me.ContaJurosDesc.Clear()
        End If
    End Sub

    Private Sub Multa_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multa.Validated
        If Me.Multa.Text = "" Then Me.Multa.Text = FormatNumber(0, 2)
        If Me.Multa.Text = 0 Then
            Me.ContaMulta.Clear()
            Me.ContaMultaDesc.Clear()
        End If
    End Sub

    Private Sub ValorDesconto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorDesconto.Validated
        If Me.ValorDesconto.Text = "" Then Me.ValorDesconto.Text = FormatNumber(0, 2)
        If Me.ValorDesconto.Text = 0 Then
            Me.ContaDesconto.Clear()
            Me.ContaDescontoDesc.Clear()
        End If
    End Sub

    'Private Sub ValorLiquido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorLiquido.TextChanged
    '    If Me.ValorLiquido.Text = "" Then Me.ValorLiquido.Text = FormatNumber(0, 2)
    '    If NzZero(Me.ValorLiquido.Text) = 0 Then
    '        Me.ContaValorBaixado.Clear()
    '        Me.ContaValorBaixadoDesc.Clear()
    '    End If
    'End Sub

    Private Sub btFindJuros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindJuros.Click
        IdContaLanc = "JUROS" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete(Me.ContaJuros.Text, Me.ContaJurosDesc)
        Me.ContaJuros.Focus()
    End Sub

    Private Sub btFindMulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindMulta.Click
        IdContaLanc = "MULTA" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete(Me.ContaMulta.Text, Me.ContaMultaDesc)
        Me.ContaMulta.Focus()
    End Sub

    Private Sub btFindDesconto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindDesconto.Click
        IdContaLanc = "DESCONTO" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete(Me.ContaDesconto.Text, Me.ContaDescontoDesc)
        Me.ContaDesconto.Focus()
    End Sub

    Private Sub btFindValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindValor.Click
        IdContaLanc = "VALORDOC" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete(Me.ContaValorBaixado.Text, Me.ContaValorBaixadoDesc)
        Me.ContaValorBaixado.Focus()
    End Sub

    Private Sub JurosP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JurosP.TextChanged

    End Sub

    Private Sub ReceberBaixa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            My.Forms.CaixaAtivarDesativar.ShowDialog()
            Me.DisplayCaixa.Text = "Caixa Ativo: " & CaixaAtivo
        End If
    End Sub
End Class