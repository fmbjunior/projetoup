Public Class ChequePreClientesBaixa

    Dim Ação As New TrfGerais


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ChequePreClientesBaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaLocalPgto()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM ArquivoCheque WHERE Cheque = '" & My.Forms.ChequePreClientes.NCheque.Text & "' and CC = '" & My.Forms.ChequePreClientes.CC.Text & "' And Empresa = " & CodEmpresa
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            DR.Read()

            If DR.HasRows = True Then
                Me.IdCodigo.Text = Nz(DR.Item("IdCodigo"), 3)
                Me.Cheque.Text = DR.Item("Cheque") & ""
                Me.CC.Text = DR.Item("CC") & ""
                Me.Titular.Text = DR.Item("Titular") & ""
                Me.EntreguePor.Text = DR.Item("EntreguePor") & ""
                Me.ValorCh.Text = FormatCurrency(Nz(DR.Item("ValorCh"), 3), 2)
                Me.Vencimento.Text = DR.Item("Vencimento") & ""
                Me.DataBaixa.Text = DR.Item("DataBaixa") & ""
                Me.Pedido.Text = DR.Item("Pedido") & ""
                Me.LocalPgto.SelectedValue = Me.LocalPgto.FindStringExact(DR.Item("LocalPgto") & "")
                Me.Banco.Text = DR.Item("Banco") & ""
                If Me.LocalPgto.SelectedValue = "BANCO" Then
                    Me.Banco.Enabled = True
                    Me.BancoDesc.Enabled = True
                End If
                If Me.LocalPgto.SelectedValue = "CARTEIRA" Then
                    Me.Banco.Enabled = False
                    Me.BancoDesc.Enabled = False
                End If
                Me.Vendedor.Text = DR.Item("Vendedor") & ""
                Me.MediaDescontoPedido.Text = DR.Item("MediaDescontoPedido") & ""
                Me.PercentComissao.Text = DR.Item("PercentComissao") & ""
                Me.ContaBalancete.Text = DR.Item("ContaBalancete") & ""
            End If
            Cnn.Close()
            AchaContaBalancete(Me.ContaBalancete.Text, Me.ContaBalanceteDesc)

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try

    End Sub



    Private Sub Banco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Banco.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.TelaProcuraBancoCC.ShowDialog()
        End If
    End Sub

    Private Sub Banco_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Banco.Leave
        If String.CompareOrdinal(Me.Banco.Text, Me.Banco.TextoAntigo) Then
            LocalizaDadosBANCO()
        End If
    End Sub

    


    Public Sub LocalizaDadosBANCO()
        If Me.Banco.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Banco where Codigo = '" & Me.Banco.Text & "' and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.BancoDesc.Text = DR.Item("NomeBanco") & ""
        End If
        DR.Close()
        Cnn.Close()
    End Sub


    Private Sub btBaixar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaixar.Click
        If Me.LocalPgto.Text = "" Then
            MsgBox("O Local de pagamento deve ser indicado para fazer a baixa do Documento", 64, "Validação de Dados")
            Me.Banco.Focus()
            Exit Sub
        ElseIf Me.DataBaixa.Text = "" Then
            MsgBox("A data da baixa não pode ser nula", 64, "Validação de Dados")
            Me.DataBaixa.Focus()
            Exit Sub
        End If

        If Me.DataBaixa.Text <> DataDia Then
            MsgBox("A data da baixa não pode ser diferente da data do dia, o sistema ira definir a data da baixa", 64, "Validação de Dados")
            Me.DataBaixa.Text = DataDia
        End If

        If Me.Destino.Text = "" Then
            MsgBox("Não foi informado o destino do cheque, favor informar o destino.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub
        End If

        If Me.ContaBalancete.Text = "" Then
            MsgBox("Não foi informado a Conta do de lançamento, favor informar a conta.", 64, "Validação de Dados")
            Me.ContaBalancete.Focus()
            Exit Sub
        End If

        If Me.Banco.Text = "" Then Me.Banco.Text = 0

        Me.Historico.Text = "BAIXADO"


        If Me.LocalPgto.Text = "CARTEIRA" Then
            MessageBox.Show("Baixar um Cheque-pré neste local de Pagamento, o usuário vai credita-lo no caixa " & CaixaAtivo & " este documento não podera ser extornado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim CmdBaixaCheque As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdBanco As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdBLC As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdCaixa As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdComissao As OleDb.OleDbCommand = CNN.CreateCommand

        CmdBaixaCheque.Transaction = Transacao
        CmdBanco.Transaction = Transacao
        CmdBLC.Transaction = Transacao
        CmdCaixa.Transaction = Transacao
        CmdComissao.Transaction = Transacao

        Try
            Dim Sql As String = "Update ArquivoCheque set Cheque = @1, CC = @2, Historico = @3, Titular = @4, EntreguePor = @5, ValorCh = @6, Vencimento = @7, Empresa = @8, Pedido = @9, DataBaixa = @10, LocalPgto = @11, Banco = @12, Destino = @13, DescriçãoDestino = @14, CaixaBaixado = @15, ContaBalancete = @16  Where Cheque = '" & Me.Cheque.Text & "' and CC = '" & Me.CC.Text & "'"
            CmdBaixaCheque.CommandText = Sql

            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cheque.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CC.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Historico.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Titular.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EntreguePor.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.ValorCh.Text)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Pedido.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.DataBaixa.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@11", Me.LocalPgto.SelectedValue))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Banco.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Destino.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.DescriçãoDestino.Text, 1)))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@15", CaixaAtivo))
            CmdBaixaCheque.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.ContaBalancete.Text, 1)))
            CmdBaixaCheque.ExecuteNonQuery()

            If Me.LocalPgto.Text = "BANCO" Then

                Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                CmdBanco.CommandText = Sql

                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Cheque.Text, 1)))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Vencimento.Text, 1)))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@6", "C"))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@7", "BX. CHEQUE-PRE"))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.DescriçãoDestino.Text, 1)))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("N", 1)))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(CDbl(Me.ValorCh.Text))))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Banco.Text, 1)))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.ContaBalancete.Text, 1)))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@16", "BANCO"))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@17", "CHEQUE-PRE"))
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@18", Me.IdCodigo.Text))
                CmdBanco.ExecuteNonQuery()

            End If


            If Me.LocalPgto.Text = "CARTEIRA" Then

                Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                CmdCaixa.CommandText = Sql

                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Cheque.Text, 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Vencimento.Text, 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@6", "C"))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@7", "BX. CHEQUE-PRE"))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.DescriçãoDestino.Text, 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(CDbl(Me.ValorCh.Text))))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(CaixaAtivo, 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.ContaBalancete.Text, 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@17", "CHEQUE-PRE"))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@18", Me.IdCodigo.Text))

                CmdCaixa.ExecuteNonQuery()

            End If

            If TipoComissaoVenda = "porFAIXA" Then

                Dim ComissaoFaixaExecutar As Double = NzZero(Me.PercentComissao.Text)
                If ComissaoFaixaExecutar > 0 Then

                    If CDbl(NzZero(Me.ValorCh.Text)) <> 0 Then
                        Dim ValorAComisssionar As Double = CDbl(NzZero(Me.ValorCh.Text))

                        CmdComissao.CommandText = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, Pago, ComissaoFaturamento, OndeVeio, IdOrigem, Documento, DescComissao ) Values ( #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#,#" & Format(CDate(Me.DataBaixa.Text), "MM/dd/yyyy") & "# ," & Me.Vendedor.Text & " ," & Me.Pedido.Text & " , 0 ,'" & ComissaoFaixaExecutar & "' ,'" & ValorAComisssionar & "' ,'" & CDbl((CDbl(ValorAComisssionar) * CDbl(ComissaoFaixaExecutar)) / 100) & "' ,'porFAIXA' , False, False, 'CH-PRE', " & Me.IdCodigo.Text & ", '" & Me.Cheque.Text & "', 'RECEB. CH: " & Me.Cheque.Text & " C/C: " & Me.CC.Text & "' )"
                        CmdComissao.ExecuteNonQuery()
                    End If
                End If

            End If

            Transacao.Commit()
            CNN.Close()
            MessageBox.Show("Cheque Pre-Datado baixado com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.Cheque.Text)

            If My.Forms.ChequePreClientes.TxtProcurar.Text = "" Then
                My.Forms.ChequePreClientes.AtFiltro()
            Else
                My.Forms.ChequePreClientes.ProcuraTexto()
            End If
            Me.Close()
            Me.Dispose()

        Catch x As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(x.Message)
            Exit Sub
        End Try
        Ação.Desbloquear_Controle(Me, False)

    End Sub


    'Public Sub FazerLancBanco()

    '    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    '    CNN.Open()

    '    Dim Ult = Ação.Ultimo_RegistroParaVariavel("LancamentoBanco", "Id")
    '    Dim Sql As String = "INSERT INTO LancamentoBanco (Id, DataLancamento, PreDatado, Documento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, EmitirCheque, DocumentoExterno, CaixaBaixado) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16)"
    '    Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Ult)) 'Id
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@2", DataDia)) 'DataLançamento
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@3", False)) 'Pre-Datado
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Cheque.Text, 1))) 'Documento
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Vencimento.Text, 1))) 'DataDocumento/DataVencimento
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@6", "D")) 'TipoLancamento
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Banco.Text, 1))) 'ContaCorrente
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@8", "RECEB. CHEQUE")) 'Favorecido
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@9", "BX. CH. " & Me.Cheque.Text & " " & Me.EntreguePor.Text & " TIT. " & Me.Titular.Text)) 'Historico
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@10", "S")) 'CaiuBanco
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@11", True)) 'ConfirmadoLancamento 
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa)) 'Empresa
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ValorCh.Text, 1))) 'ValorDocumento
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@14", "N")) 'Emitir Cheque
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@15", True)) 'DocumentoExterno
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@16", CaixaAtivo)) 'Caixa Ativo

    '    Try
    '        cmd.ExecuteNonQuery()
    '        CNN.Close()
    '        'Fim da verificação de transferencia
    '    Catch Ex As Exception
    '        MsgBox(Ex.InnerException)
    '        MsgBox(Ex.Message, 64, "Validação de Dados")
    '    End Try

    'End Sub


    Private Sub CarregaLocalPgto()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Ds As New DataSet
        Dim Sql As String = String.Empty

        Sql = "SELECT LocalPagamento.LocalPgto FROM(LocalPagamento) WHERE (((LocalPagamento.LocalPgto)='BANCO' Or (LocalPagamento.LocalPgto)='CARTEIRA') AND ((LocalPagamento.Empresa)=" & CodEmpresa & ") AND ((LocalPagamento.Inativo)=False));"
        Dim DACadBancos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DACadBancos.Fill(Ds, "LocalPgto")

        Me.LocalPgto.DataSource = Ds.Tables("LocalPgto")
        Me.LocalPgto.DisplayMember = "LocalPgto"
        Me.LocalPgto.ValueMember = "LocalPgto"
        Me.LocalPgto.SelectedValue = 0
        CNN.Close()
    End Sub

    Private Sub LocalPgto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocalPgto.Leave
        If Me.LocalPgto.Text = "BANCO" Then
            Me.Banco.Enabled = True
            Me.BancoDesc.Enabled = True
            Me.Banco.Focus()
        End If
        If Me.LocalPgto.Text = "CARTEIRA" Then
            Me.Banco.Enabled = False
            Me.BancoDesc.Enabled = False
            Me.Destino.Focus()
        End If
    End Sub

    Private Sub ContaBalancete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaBalancete.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.BalanceteContasProcura.TipoConta = "C"
            My.Forms.BalanceteContasProcura.ShowDialog()
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

    Private Sub ContaBalancete_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaBalancete.Leave
        If String.CompareOrdinal(Me.ContaBalancete.Text, Me.ContaBalancete.TextoAntigo) Then
            AchaContaBalancete(Me.ContaBalancete.Text, Me.ContaBalanceteDesc)
        End If
    End Sub

    Private Sub btFindContaBalancete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindContaBalancete.Click
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete(Me.ContaBalancete.Text, Me.ContaBalanceteDesc)
        Me.ContaBalancete.Focus()
    End Sub

    Private Sub btFindCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCC.Click
        My.Forms.TelaProcuraBancoCC.ShowDialog()
        LocalizaDadosBANCO()
        Me.Banco.Focus()
    End Sub

    Private Sub DescriçãoDestino_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescriçãoDestino.Enter
        If Me.DescriçãoDestino.Text = "" Then
            Me.DescriçãoDestino.Text = Mid("BX CH: " & Me.Cheque.Text & " C/C: " & Me.CC.Text & " TITULAR: " & Me.Titular.Text, 1, 250)
            Me.DescriçãoDestino.SelectionStart = Len(Me.DescriçãoDestino.Text)
        End If
    End Sub

    Private Sub DataBaixa_Enter(sender As Object, e As EventArgs) Handles DataBaixa.Enter
        If Me.DataBaixa.Text = "" Then Me.DataBaixa.Text = DataDia
    End Sub
End Class