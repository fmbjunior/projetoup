Public Class FolhaPgtoDecimoTerceiroGerarLancamentos

    Public ChequeInicial As Integer
    Public ChequeFinal As Integer
    Public ContaCheque As String = String.Empty
    Public ContaChequeCod As String = String.Empty

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Caixa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Caixa.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Descrição", "Responsavel", "CaixaCadastro", "CodigoCaixa", "CaixaNome", "Responsavel", True)
            Me.Caixa.Text = RetornoProcura
        End If
    End Sub

    Private Sub BancoCartao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BancoCartao.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Conta Corrente", "", "Banco", "Codigo", "ContaCorrente", "", True)
            Me.BancoCartao.Text = RetornoProcura
        End If
    End Sub

    Private Sub BancoCartao_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles BancoCartao.Validated
        LocalizaDadosBanco(Me.BancoCartao.Text, TipoBanco.Cartão)
    End Sub

    Public Enum TipoBanco
        Cheque = 0
        Cartão = 1
    End Enum

    Public Sub LocalizaDadosBanco(ByVal Cod As String, ByVal Tipo As TipoBanco)
        If Cod = "" Then Exit Sub

        Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOpen.Open()
        Dim Sql As String = "Select * from Banco where Codigo = " & Cod & " and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, DBOpen)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then

            If Tipo = TipoBanco.Cheque Then
                'Me.BancoChequeDesc.Text = DR.Item("NomeBanco") & ""
                'Me.BancoChequeConta.Text = DR.Item("PCBanco") & ""
            Else
                Me.BancoCartaoDesc.Text = DR.Item("NomeBanco") & ""
                Me.BancoCartaoConta.Text = DR.Item("PCBanco") & ""
            End If
        End If
        DR.Close()
        DBOpen.Close()
    End Sub

    Private Sub MensalCompetencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MensalCompetencia.Enter
        If MesAnoCompetencia = "" Then
            MsgBox("O Mês e Ano de competência não foi informado, favor verificar.", 64, "Validação de Dados")
            Exit Sub
        End If
        Me.MensalCompetencia.Text = MesAnoCompetencia
    End Sub

    Public Sub LocalizaContaCaixa(ByVal Cod As String)
        If Cod = "" Then Exit Sub

        Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOpen.Open()
        Dim Sql As String = "Select * from CaixaCadastro where CodigoCaixa = " & Cod & " and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, DBOpen)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CaixaDesc.Text = DR.Item("CaixaNome") & ""
            Me.CaixaConta.Text = DR.Item("ContaCaixa") & ""
        End If
        DR.Close()
        DBOpen.Close()
    End Sub

    Private Sub Caixa_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Caixa.Validated
        LocalizaContaCaixa(Me.Caixa.Text)
    End Sub

#Region "Gerações de Pagamentos"

    Private Sub GeraDecimo2()
        If Me.MensalCompetencia.Text = "" Then
            MsgBox("O usuário deve informar o mês e ano de competência para gerar os lançamentos.", 64, "Validação de Dados")
        End If

        If Me.DataLançamento.Text = "" Then
            MsgBox("O usuário não informou a data de lançamento, favor informar.", 64, "Validação de Dados")
            Exit Sub
        End If


        Dim Ultimo As Integer = 0
        Dim CompSql As String = ""
        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Dim DR As OleDb.OleDbDataReader
        Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand()


        Dim DS As New DataSet

        'Gerar Lançamento no banco e fazer o Pagamento

        'Dim ChequeInicial As Integer
        'Dim ChequeFinal As Integer

        Sql = "Select * from FolhaPgtoDecimoTerceiro where AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "' And Empresa = " & CodEmpresa
        Dim DaValidar As New OleDb.OleDbDataAdapter(Sql, CNN)
        DaValidar.Fill(DS, "Validar")
        Dim TotalValidar As Integer = DS.Tables("Validar").Rows.Count
        If TotalValidar = 0 Then
            MsgBox("Não existe Décimo Terceiro para gerar. Verifique", 64, "Validação de Dados")
            Exit Sub
        End If


        Sql = "SELECT FolhaPgtoDecimoTerceiro.*, FolhaPgtoDecimoTerceiro.AnoAtual, FolhaPgtoDecimoTerceiro.Funcionario, Funcionários.Nome, Funcionários.TipoPagamentoMensal FROM FolhaPgtoDecimoTerceiro INNER JOIN Funcionários ON FolhaPgtoDecimoTerceiro.Funcionario = Funcionários.CódigoFuncionário WHERE FolhaPgtoDecimoTerceiro.AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "' AND FolhaPgtoDecimoTerceiro.Empresa = " & CodEmpresa & " order by Funcionários.Nome"
        Dim DAPagamentos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAPagamentos.Fill(DS, "Pagamentos")

        Dim TotalLinhas As Integer = DS.Tables("Pagamentos").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Gerando Pagamento da 1 Parcela do Decimo Terceiro."
        Me.Msg.Refresh()

        Dim DrPagamento As DataRow
        For Each DrPagamento In DS.Tables("Pagamentos").Rows

            If CDbl(NzVlr(DrPagamento("2Parcela"))) > 0 Then

                Dim Ult As String
                Ult = CalcIdLancamento()

                Dim IIDD As String = ""

                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)


                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("Credito"))) ' conta do Funcionario
                Select Case DrPagamento("TipoPagamentoMensal")
                    Case "CARTÃO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.BancoCartaoConta.Text))
                        IIDD = Me.MensalCompetencia.Text
                        IIDD = IIDD.Remove(2, 1)
                        IIDD = IIDD & DrPagamento("FolhaPgtoDecimoTerceiro.Funcionario")
                    Case "CHEQUE"
                        If ChequeInicial = 0 Then
                            My.Forms.FolhaPgtoDecimoTerceiroPegaContaCheque.ShowDialog()
                            'ChequeInicial = InputBox("Informe a Nova sequência inicial do cheque.", "Sequência de cheques")
                            'ChequeFinal = InputBox("Informe a Nova sequência final do cheque.", "Sequência de cheques")
                            Me.Refresh()
                        End If
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", ContaCheque))
                        IIDD = ChequeInicial
                    Case "DINHEIRO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.CaixaConta.Text))
                        IIDD = Me.MensalCompetencia.Text
                        IIDD = IIDD.Remove(2, 1)
                        IIDD = IIDD & DrPagamento("FolhaPgtoDecimoTerceiro.Funcionario")
                End Select
                Dim VlrPgto As Double = CDbl(NzVlr(DrPagamento("2Parcela")))
                Dim Vlr2Parcela As Double = VlrPgto
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrPgto))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", 0))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "2ParDecimo"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

                'Contra Partida

                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Select Case DrPagamento("TipoPagamentoMensal")
                    Case "CARTÃO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.BancoCartaoConta.Text))
                    Case "CHEQUE"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", ContaCheque))
                    Case "DINHEIRO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.CaixaConta.Text))
                End Select
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("Credito")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", 0))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrPgto))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "2ParDecimo"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try


                'Fazer Lançamento Total do Décimo Terceiro ---------------------------------------------------------------------------->

                Ult = CalcIdLancamento()

                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)


                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("Debito")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("Credito"))) ' conta do Funcionario
                VlrPgto = CDbl(NzVlr(DrPagamento("VlrDecimo")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrPgto))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", 0))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", "Décimo Terceiro " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "13Salario"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

                'Contra Partida Total do Décimo Terceiro

                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("Credito")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("Debito")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", 0))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrPgto))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", "Décimo Terceiro " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "13Salario"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

                'Gerar Lançamento de Inss --------------------------------------------------------------------------------------------->


                Ult = CalcIdLancamento()

                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)


                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("Credito"))) ' conta do Funcionario
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("ContaInss")))
                VlrPgto = CDbl(NzZero(DrPagamento("Inss")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrPgto))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", 0))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", "Décimo Terceiro " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "13Inss"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

                'Contra Partida Total do Décimo Terceiro

                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("ContaInss")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("Credito")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", 0))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrPgto))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", "Décimo Terceiro " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "13Inss"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try






                'fazer lancamento no banco selecionado ------------------------------------------------------------------------------->
                If DrPagamento("TipoPagamentoMensal") = "CARTÃO" Or DrPagamento("TipoPagamentoMensal") = "CHEQUE" Then

                    Sql = "INSERT INTO LancamentoBanco (DataLancamento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Documento, ValorDocumento, EmitirCheque, ConfirmadoLancamento, Empresa, Debito, Credito, Historico, CaiuBanco, DocumentoExterno, IdLancamento, IdProcura) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                    Cmd = New OleDb.OleDbCommand(Sql, CNN)

                    'Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.DataLançamento.Text))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", "C"))
                    Select Case DrPagamento("TipoPagamentoMensal")
                        Case "CARTÃO"
                            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.BancoCartao.Text))
                        Case "CHEQUE"
                            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", ContaChequeCod))
                    End Select
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", DrPagamento("Nome")))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CInt(IIDD)))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Vlr2Parcela))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", "N"))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", True))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", DrPagamento("Credito")))
                    Select Case DrPagamento("TipoPagamentoMensal")
                        Case "CARTÃO"
                            Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Me.BancoCartaoConta.Text))
                        Case "CHEQUE"
                            Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", ContaCheque))
                    End Select
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", True))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", "2ParDecimo"))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@18", CInt(IIDD)))

                    Try
                        Cmd.ExecuteNonQuery()
                        If DrPagamento("TipoPagamentoMensal") = "CHEQUE" Then
                            ChequeInicial += 1
                            If ChequeInicial > ChequeFinal Then
                                ChequeInicial = 0
                                ChequeFinal = 0
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, 64, "Validação de Dados")
                    End Try

                End If
                'fim do lancamento do banco
            End If
            Me.MyBarra.PerformStep()
        Next DrPagamento


        Sql = "SELECT * FROM FolhaPgtoDecimoTerceiroCab WHERE AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "' AND Empresa = " & CodEmpresa
        Dim DADecimoCab As New OleDb.OleDbDataAdapter(Sql, CNN)
        DADecimoCab.Fill(DS, "FolhaPgtoDecimoTerceiroCab")


        Dim DRLinha() As DataRow
        DRLinha = DS.Tables("FolhaPgtoDecimoTerceiroCab").Select("AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "'")

        DRLinha(0).BeginEdit()
        DRLinha(0)("Gerado2Parcela") = True
        DRLinha(0).EndEdit()

        Dim objCommandBuilderCab As New OleDb.OleDbCommandBuilder(DADecimoCab)
        DADecimoCab.Update(DS, "FolhaPgtoDecimoTerceiroCab")



        CNN.Close()
        MsgBox("Lançamentos da Segunda Parcela do Décimo Terceira Gerada.", 64, "Validação de Dados")
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub GeraDecimo1()
        If Me.MensalCompetencia.Text = "" Then
            MsgBox("O usuário deve informar o mês e ano de competência para gerar os lançamentos.", 64, "Validação de Dados")
        End If

        If Me.DataLançamento.Text = "" Then
            MsgBox("O usuário não informou a data de lançamento, favor informar.", 64, "Validação de Dados")
            Exit Sub
        End If


        Dim Ultimo As Integer = 0
        Dim CompSql As String = ""
        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Dim DR As OleDb.OleDbDataReader
        Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand()


        Dim DS As New DataSet

        'Gerar Lançamento no banco e fazer o Pagamento

        'Dim ChequeInicial As Integer
        'Dim ChequeFinal As Integer

        Sql = "Select * from FolhaPgtoDecimoTerceiro where AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "' And Empresa = " & CodEmpresa
        Dim DaValidar As New OleDb.OleDbDataAdapter(Sql, CNN)
        DaValidar.Fill(DS, "Validar")
        Dim TotalValidar As Integer = DS.Tables("Validar").Rows.Count
        If TotalValidar = 0 Then
            MsgBox("Não existe Décimo Terceiro para gerar. Verifique", 64, "Validação de Dados")
            Exit Sub
        End If

        Sql = "SELECT FolhaPgtoDecimoTerceiro.*, FolhaPgtoDecimoTerceiro.AnoAtual, FolhaPgtoDecimoTerceiro.Funcionario, Funcionários.Nome, Funcionários.TipoPagamentoMensal FROM FolhaPgtoDecimoTerceiro INNER JOIN Funcionários ON FolhaPgtoDecimoTerceiro.Funcionario = Funcionários.CódigoFuncionário WHERE FolhaPgtoDecimoTerceiro.AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "' AND FolhaPgtoDecimoTerceiro.Empresa = " & CodEmpresa & " order by Funcionários.Nome"
        Dim DAPagamentos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAPagamentos.Fill(DS, "Pagamentos")

        Dim TotalLinhas As Integer = DS.Tables("Pagamentos").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Gerando Pagamento da 1 Parcela do Decimo Terceiro."
        Me.Msg.Refresh()

        Dim DrPagamento As DataRow
        For Each DrPagamento In DS.Tables("Pagamentos").Rows

            If CDbl(NzVlr(DrPagamento("1Parcela"))) > 0 Then
                Dim Ult As String
                Ult = CalcIdLancamento()

                Dim IIDD As String = ""

                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)


                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("Credito"))) ' conta do Funcionario
                Select Case DrPagamento("TipoPagamentoMensal")
                    Case "CARTÃO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.BancoCartaoConta.Text))
                        IIDD = Me.MensalCompetencia.Text
                        IIDD = IIDD.Remove(2, 1)
                        IIDD = IIDD & DrPagamento("FolhaPgtoDecimoTerceiro.Funcionario")
                    Case "CHEQUE"
                        If ChequeInicial = 0 Then
                            My.Forms.FolhaPgtoDecimoTerceiroPegaContaCheque.ShowDialog()
                            'ChequeInicial = InputBox("Informe a Nova sequência inicial do cheque.", "Sequência de cheques")
                            'ChequeFinal = InputBox("Informe a Nova sequência final do cheque.", "Sequência de cheques")
                            Me.Refresh()
                        End If
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", ContaCheque))
                        IIDD = ChequeInicial
                    Case "DINHEIRO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.CaixaConta.Text))
                        IIDD = Me.MensalCompetencia.Text
                        IIDD = IIDD.Remove(2, 1)
                        IIDD = IIDD & DrPagamento("FolhaPgtoDecimoTerceiro.Funcionario")
                End Select
                Dim VlrPgto As Double = CDbl(DrPagamento("1Parcela"))

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrPgto))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", 0))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "1ParDecimo"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

                'Contra Partida

                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Select Case DrPagamento("TipoPagamentoMensal")
                    Case "CARTÃO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.BancoCartaoConta.Text))
                    Case "CHEQUE"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", ContaCheque))
                    Case "DINHEIRO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.CaixaConta.Text))
                End Select
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("Credito")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", 0))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrPgto))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "1ParDecimo"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", IIDD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

                'fazer lancamento no banco selecionado
                If DrPagamento("TipoPagamentoMensal") = "CARTÃO" Or DrPagamento("TipoPagamentoMensal") = "CHEQUE" Then

                    Sql = "INSERT INTO LancamentoBanco (DataLancamento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Documento, ValorDocumento, EmitirCheque, ConfirmadoLancamento, Empresa, Debito, Credito, Historico, CaiuBanco, DocumentoExterno, IdLancamento, IdProcura) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                    Cmd = New OleDb.OleDbCommand(Sql, CNN)

                    'Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.DataLançamento.Text))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", "C"))
                    Select Case DrPagamento("TipoPagamentoMensal")
                        Case "CARTÃO"
                            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.BancoCartao.Text))
                        Case "CHEQUE"
                            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", ContaChequeCod))
                    End Select
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", DrPagamento("Nome")))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CInt(IIDD)))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrPgto))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", "N"))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", True))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", DrPagamento("Credito")))
                    Select Case DrPagamento("TipoPagamentoMensal")
                        Case "CARTÃO"
                            Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Me.BancoCartaoConta.Text))
                        Case "CHEQUE"
                            Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", ContaCheque))
                    End Select
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", True))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", "1ParDecimo"))
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@18", CInt(IIDD)))

                    Try
                        Cmd.ExecuteNonQuery()
                        If DrPagamento("TipoPagamentoMensal") = "CHEQUE" Then
                            ChequeInicial += 1
                            If ChequeInicial > ChequeFinal Then
                                ChequeInicial = 0
                                ChequeFinal = 0
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, 64, "Validação de Dados")
                    End Try

                End If
                'fim do lancamento do banco
            End If
            Me.MyBarra.PerformStep()
        Next DrPagamento


        Sql = "SELECT * FROM FolhaPgtoDecimoTerceiroCab WHERE AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "' AND Empresa = " & CodEmpresa
        Dim DADecimoCab As New OleDb.OleDbDataAdapter(Sql, CNN)
        DADecimoCab.Fill(DS, "FolhaPgtoDecimoTerceiroCab")


        Dim DRLinha() As DataRow
        DRLinha = DS.Tables("FolhaPgtoDecimoTerceiroCab").Select("AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "'")

        DRLinha(0).BeginEdit()
        DRLinha(0)("Gerado1Parcela") = True
        DRLinha(0).EndEdit()

        Dim objCommandBuilderCab As New OleDb.OleDbCommandBuilder(DADecimoCab)
        DADecimoCab.Update(DS, "FolhaPgtoDecimoTerceiroCab")



        CNN.Close()
        MsgBox("Lançamentos da Primeira parcela do Décimo Terceira Gerada.", 64, "Validação de Dados")
        Me.Close()
        Me.Dispose()

    End Sub

#End Region

    Private Sub GerarLanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerarLanc.Click
        If My.Forms.FolhaPgtoDecimoTerceiro.QualParcela = 1 Then
            GeraDecimo1()
        End If

        If My.Forms.FolhaPgtoDecimoTerceiro.QualParcela = 2 Then
            GeraDecimo2()
        End If

    End Sub

    Private Sub FolhaPgtoGerarLancamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

End Class