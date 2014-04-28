Public Class FolhaPgtoGerarLancamentos

    Public ChequeInicial As Integer
    Public ChequeFinal As Integer
    Public ContaCheque As String = String.Empty
    Public ContaChequeCod As String = String.Empty




    Private Sub TipoGeradorBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoGeradorBT.Click
        Dim X As New Point(27, 0)
        Me.MenuTipoGerador.Show(Me.TipoGeradorBT, X)
    End Sub

    Private Sub MensalDiaristaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DécimoTerceiroToolStripMenuItem.Click, PgtoPISToolStripMenuItem.Click, RecisãoToolStripMenuItem.Click, PISToolStripMenuItem.Click, ValeQuinzenalToolStripMenuItem.Click
        Me.Modulo.Text = sender.ToString

        Select Case Me.Modulo.Text
            Case "Mensalistas"
                Me.DescPagamento.Text = "PAGAMENTO"
            Case "Vale Quinzenal"
                Me.DescPagamento.Text = "VALE QUINZENAL"
            Case "Recisão"
                Me.DescPagamento.Text = "RECISAO"
            Case "Pgto PIS"
                Me.DescPagamento.Text = "PGTO PIS"
            Case "Férias"
                Me.DescPagamento.Text = "PGTO FERIAS"
        End Select
    End Sub

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

    Private Sub GeraMensalistas()
        If Me.Modulo.Text = "" Then
            MsgBox("O usuário deve escolher o modulo para gerar a folha", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.MensalCompetencia.Text = "" Then
            MsgBox("O usuário deve informar o mês e ano de competência para gerar os lançamentos.", 64, "Validação de Dados")
        End If

        If Me.DataLançamento.Text = "" Then
            MsgBox("O usuário não informou a data de lançamento, favor informar.", 64, "Validação de Dados")
            Exit Sub
        End If


        Dim Ultimo As String = String.Empty
        Dim CompSql As String = ""
        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Dim DR As OleDb.OleDbDataReader
        Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand()


        Sql = "SELECT FolhaPgto.Id, FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcionários.Nome, Funcionários.CodPlanoContas, Funcionários.TipoPagamentoMensal, Funcionários.GeraMovimentoFolha, FolhaPgto.Evento, FolhaPgto.Historico, FolhaPgto.Referencia, FolhaPgto.VlrDebito, FolhaPgto.VlrCredito, FolhaPgto.Empresa, FolhaPgto.Confirmado, FolhaPgto.Usuario, FolhaPgto.ContaDebito, FolhaPgto.ContaCredito, FolhaPgto.Protegido, FolhaPgtoEventos.CodigoEvento, FolhaPgtoEventos.Descrição, FolhaPgtoEventos.Indicador, FolhaPgtoEventos.Inss, FolhaPgtoEventos.SalarioFamilia, FolhaPgtoEventos.Perc_Valor, FolhaPgtoEventos.VlrBase, FolhaPgtoEventos.Debito, FolhaPgtoEventos.Credito, FolhaPgtoEventos.Empresa, FolhaPgtoEventos.Inativo, FolhaPgtoEventos.CalculoSobre, FolhaPgtoEventos.SomenteEvento FROM (FolhaPgto INNER JOIN Funcionários ON FolhaPgto.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN FolhaPgtoEventos ON FolhaPgto.Evento = FolhaPgtoEventos.CodigoEvento WHERE(((FolhaPgto.Competencia) = '" & Me.MensalCompetencia.Text & "') And ((FolhaPgto.Modulo) = '" & Me.Modulo.Text & "') And ((FolhaPgto.Empresa) =" & CodEmpresa & ")) ORDER BY Funcionários.Nome;"
        Dim DAFolhaPgto As New OleDb.OleDbDataAdapter(Sql, CNN)


        Dim DS As New DataSet

        DAFolhaPgto.Fill(DS, "FolhaPgto")

        Dim TotalLinhas As Integer = DS.Tables("FolhaPgto").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Gerando Lançamentos de Eventos nas Contas."
        Me.Msg.Refresh()

        Dim DrFolhaPgto As DataRow
        For Each DrFolhaPgto In DS.Tables("FolhaPgto").Rows

            If DrFolhaPgto("Confirmado") = False Then
                Dim ContaD As String
                Dim ContaC As String


                Dim VlrD As Double
                Dim VlrC As Double
                'Achar debito e credito
                If DrFolhaPgto("Debito") = "00000000000000" Then
                    ContaD = DrFolhaPgto("CodPlanoContas")
                Else
                    ContaD = DrFolhaPgto("Debito")
                End If

                If DrFolhaPgto("Credito") = "00000000000000" Then
                    ContaC = DrFolhaPgto("CodPlanoContas")
                Else
                    ContaC = DrFolhaPgto("Credito")
                End If


                If DrFolhaPgto("Credito") = "00000000000000" Then
                    VlrD = DrFolhaPgto("VlrCredito")
                    VlrC = DrFolhaPgto("VlrDebito")
                Else
                    VlrD = DrFolhaPgto("VlrDebito")
                    VlrC = DrFolhaPgto("VlrCredito")
                End If


                'fim

                Dim Ult As String
                Ult = CalcIdLancamento()

                'With Cmd
                '    .Connection = CNN
                '    .CommandTimeout = 0
                '    .CommandText = "SELECT Max("& AnoContabel &".Id) AS MáxDeId FROM "& AnoContabel &";"
                '    .CommandType = CommandType.Text
                'End With

                'Try

                '    DR = Cmd.ExecuteReader
                '    DR.Read()
                '    If DR.HasRows Then
                '        Ult = DR.Item("MáxDeId")
                '    Else
                '        Ult = 0
                '    End If
                '    DR.Close()
                '    Ult += 1

                'Catch Merror As System.Exception
                '    Ult = 1
                'End Try


                Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)

                'Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", ContaD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", ContaC))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", DrFolhaPgto("Id")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrC))

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", DrFolhaPgto("Historico")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "FolhaPgto"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", DrFolhaPgto("Id")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

                'Contra Partida

                Sql = "INSERT INTO " & AnoContabel & " ( DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Cmd = New OleDb.OleDbCommand(Sql, CNN)

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", ContaC))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", ContaD))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", DrFolhaPgto("Id")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrC))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrD))

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", DrFolhaPgto("Historico")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "FolhaPgto"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", DrFolhaPgto("Id")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", 0))

                Try
                    Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try


                MyBarra.PerformStep()
            End If
        Next DrFolhaPgto

        'Gerar Lançamento no banco e fazer o Pagamento


        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' AND Modulo = '" & Me.Modulo.Text & "' AND Empresa = " & CodEmpresa & " and Confirmado = False"
        Dim DaValidar As New OleDb.OleDbDataAdapter(Sql, CNN)
        DaValidar.Fill(DS, "Validar")
        Dim TotalValidar As Integer = DS.Tables("Validar").Rows.Count
        If TotalValidar = 0 Then
            MsgBox("Não existe vale para gerar nesta competência. Verifique", 64, "Validação de Dados")
            Exit Sub
        End If

        Sql = "SELECT FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcionários.Nome, Funcionários.CodPlanoContas, Funcionários.TipoPagamentoMensal, Funcionários.GeraMovimentoFolha, Sum(FolhaPgto.VlrDebito) AS SomaDeVlrDebito, Sum(FolhaPgto.VlrCredito) AS SomaDeVlrCredito, FolhaPgto.Empresa FROM FolhaPgto INNER JOIN Funcionários ON FolhaPgto.Funcionario = Funcionários.CódigoFuncionário GROUP BY FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcionários.Nome, Funcionários.CodPlanoContas, Funcionários.TipoPagamentoMensal, Funcionários.GeraMovimentoFolha, FolhaPgto.Empresa HAVING (((FolhaPgto.Competencia)='" & Me.MensalCompetencia.Text & "') AND ((FolhaPgto.Modulo)='" & Me.Modulo.Text & "') AND ((Funcionários.GeraMovimentoFolha) = 'S') and((FolhaPgto.Empresa)=" & CodEmpresa & ")) Order by Funcionários.Nome;"
        Dim DAPagamentos As New OleDb.OleDbDataAdapter(Sql, CNN)

        DAPagamentos.Fill(DS, "Pagamentos")


        TotalLinhas = DS.Tables("Pagamentos").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Gerando Pagamento."
        Me.Msg.Refresh()

        Dim IIDD As String = ""

        Dim DrPagamento As DataRow
        For Each DrPagamento In DS.Tables("Pagamentos").Rows

            Dim Ult As String
            Ult = CalcIdLancamento()

            'Sql = "SELECT Max("& AnoContabel &".Id) AS MáxDeId FROM "& AnoContabel &";"
            'Cmd = New OleDb.OleDbCommand(Sql, CNN)
            'Try

            '    DR = Cmd.ExecuteReader
            '    DR.Read()
            '    If DR.HasRows Then
            '        Ult = DR.Item("MáxDeId")
            '    Else
            '        Ult = 0
            '    End If
            '    DR.Close()
            '    Ult += 1

            'Catch Merror As System.Exception
            '    Ult = 1
            'End Try


            Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Cmd = New OleDb.OleDbCommand(Sql, CNN)

            'Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("CodPlanoContas")))
            Select Case DrPagamento("TipoPagamentoMensal")
                Case "CARTÃO"
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.BancoCartaoConta.Text))
                    IIDD = Me.MensalCompetencia.Text
                    IIDD = IIDD.Remove(2, 1)
                    IIDD = IIDD & DrPagamento("Funcionario")

                Case "CHEQUE"
                    'IIDD = Me.MensalCompetencia.Text
                    'IIDD = IIDD.Remove(2, 1)
                    'IIDD = IIDD & DrPagamento("Funcionario")

                    If ChequeInicial = 0 Then
                        My.Forms.FolhaPgtoPegaContaCheque.ShowDialog()
                        'ChequeInicial = InputBox("Informe a sequência inicial do cheque.", "Sequência de cheques")
                        'ChequeFinal = InputBox("Informe a sequência final do cheque.", "Sequência de cheques")
                        Me.Refresh()
                    End If
                    IIDD = ChequeInicial
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", ContaCheque))
                Case "DINHEIRO"
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.CaixaConta.Text))
                    IIDD = Me.MensalCompetencia.Text
                    IIDD = IIDD.Remove(2, 1)
                    IIDD = IIDD & DrPagamento("Funcionario")

            End Select
            Dim VlrPgto As Double = CDbl(DrPagamento("SomaDeVlrCredito")) - CDbl(DrPagamento("SomaDeVlrDebito"))

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrPgto))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "FolhaPgto"))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", CInt(IIDD)))
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
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("CodPlanoContas")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrPgto))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "FolhaPgto"))
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

                'Sql = "SELECT Max(LancamentoBanco.Id) AS MáxDeId FROM LancamentoBanco;"
                'Cmd = New OleDb.OleDbCommand(Sql, CNN)
                'Try

                '    DR = Cmd.ExecuteReader
                '    DR.Read()
                '    If DR.HasRows Then
                '        Ult = DR.Item("MáxDeId")
                '    Else
                '        Ult = 0
                '    End If
                '    DR.Close()
                '    Ult += 1

                'Catch Merror As System.Exception
                '    Ult = 1
                'End Try

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
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", DrPagamento("CodPlanoContas")))
                Select Case DrPagamento("TipoPagamentoMensal")
                    Case "CARTÃO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Me.BancoCartaoConta.Text))
                    Case "CHEQUE"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", ContaCheque))
                End Select
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", True))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", "FolhaPgto"))
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
            Me.MyBarra.PerformStep()
        Next DrPagamento

        Me.Msg.Text = "Confirmando Pagamento."
        Me.Msg.Refresh()

        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' AND Modulo = '" & Me.Modulo.Text & "' AND Empresa = " & CodEmpresa & " and Confirmado = False"
        Dim DAConfirmar As New OleDb.OleDbDataAdapter(Sql, CNN)

        DAConfirmar.Fill(DS, "FolhaPgtoConfirmar")

        Dim drConfirmar As DataRow
        For Each drConfirmar In DS.Tables("FolhaPgtoConfirmar").Rows
            drConfirmar.BeginEdit()
            drConfirmar("Confirmado") = True
            drConfirmar.EndEdit()
        Next drConfirmar

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAConfirmar)
        DAConfirmar.Update(DS, "FolhaPgtoConfirmar")


        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub GeraValeQuinzenal()
        If Me.Modulo.Text = "" Then
            MsgBox("O usuário deve escolher o modulo para gerar a folha", 64, "Validação de Dados")
            Exit Sub
        End If
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

        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' AND Modulo = '" & Me.Modulo.Text & "' AND Empresa = " & CodEmpresa & " and Confirmado = False"
        Dim DaValidar As New OleDb.OleDbDataAdapter(Sql, CNN)
        DaValidar.Fill(DS, "Validar")
        Dim TotalValidar As Integer = DS.Tables("Validar").Rows.Count
        If TotalValidar = 0 Then
            MsgBox("Não existe vale para gerar nesta competência. Verifique", 64, "Validação de Dados")
            Exit Sub
        End If

        Sql = "SELECT FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcionários.Nome, Funcionários.CodPlanoContas, Funcionários.TipoPagamentoMensal, Sum(FolhaPgto.VlrDebito) AS SomaDeVlrDebito, Sum(FolhaPgto.VlrCredito) AS SomaDeVlrCredito, FolhaPgto.Empresa FROM FolhaPgto INNER JOIN Funcionários ON FolhaPgto.Funcionario = Funcionários.CódigoFuncionário GROUP BY FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcionários.Nome, Funcionários.CodPlanoContas, Funcionários.TipoPagamentoMensal, FolhaPgto.Empresa HAVING (((FolhaPgto.Competencia)='" & Me.MensalCompetencia.Text & "') AND ((FolhaPgto.Modulo)='" & Me.Modulo.Text & "') AND ((FolhaPgto.Empresa)=" & CodEmpresa & ")) order by Funcionários.Nome ;"
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
        Me.Msg.Text = "Gerando Pagamento."
        Me.Msg.Refresh()

        Dim DrPagamento As DataRow
        For Each DrPagamento In DS.Tables("Pagamentos").Rows

            Dim Ult As String
            Ult = CalcIdLancamento()

            'Sql = "SELECT Max("& AnoContabel &".Id) AS MáxDeId FROM "& AnoContabel &";"
            'Cmd = New OleDb.OleDbCommand(Sql, CNN)
            'Try

            '    DR = Cmd.ExecuteReader
            '    DR.Read()
            '    If DR.HasRows Then
            '        Ult = DR.Item("MáxDeId")
            '    Else
            '        Ult = 0
            '    End If
            '    DR.Close()
            '    Ult += 1

            'Catch Merror As System.Exception
            '    Ult = 1
            'End Try

            Dim IIDD As String = ""

            Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Cmd = New OleDb.OleDbCommand(Sql, CNN)

            'Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("CodPlanoContas")))
            Select Case DrPagamento("TipoPagamentoMensal")
                Case "CARTÃO"
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.BancoCartaoConta.Text))
                    IIDD = Me.MensalCompetencia.Text
                    IIDD = IIDD.Remove(2, 1)
                    IIDD = IIDD & DrPagamento("Funcionario")
                Case "CHEQUE"
                    If ChequeInicial = 0 Then
                        My.Forms.FolhaPgtoPegaContaCheque.ShowDialog()
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
                    IIDD = IIDD & DrPagamento("Funcionario")
            End Select
            Dim VlrPgto As Double = CDbl(DrPagamento("SomaDeVlrDebito"))

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrPgto))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "ValeQ"))
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
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("CodPlanoContas")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrPgto))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "ValeQ"))
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

                'Sql = "SELECT Max(LancamentoBanco.Id) AS MáxDeId FROM LancamentoBanco;"
                'Cmd = New OleDb.OleDbCommand(Sql, CNN)
                'Try

                '    DR = Cmd.ExecuteReader
                '    DR.Read()
                '    If DR.HasRows Then
                '        Ult = DR.Item("MáxDeId")
                '    Else
                '        Ult = 0
                '    End If
                '    DR.Close()
                '    Ult += 1

                'Catch Merror As System.Exception
                '    Ult = 1
                'End Try

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
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", DrPagamento("CodPlanoContas")))
                Select Case DrPagamento("TipoPagamentoMensal")
                    Case "CARTÃO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Me.BancoCartaoConta.Text))
                    Case "CHEQUE"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", ContaCheque))
                End Select
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", True))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", "ValeQ"))
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

            Me.MyBarra.PerformStep()
        Next DrPagamento

        Try
            Sql = "SELECT * FROM FolhaPgto where FolhaPgto.Competencia = '" & Me.MensalCompetencia.Text & "' AND FolhaPgto.Modulo = '" & Me.Modulo.Text & "' AND FolhaPgto.Empresa = " & CodEmpresa
            Dim DAConfirmarVale As New OleDb.OleDbDataAdapter(Sql, CNN)

            DAConfirmarVale.Fill(DS, "ValeQ")


            TotalLinhas = DS.Tables("ValeQ").Rows.Count
            'Atualiza a barra de Progresso
            If TotalLinhas = 0 Then TotalLinhas = 1
            MyBarra.Visible = True
            MyBarra.Minimum = 1
            MyBarra.Maximum = TotalLinhas
            MyBarra.Value = 1
            MyBarra.Step = 1
            Me.Msg.Visible = True
            Me.Msg.Text = "Confirmando Lançamento do Vale."
            Me.Msg.Refresh()

            Dim DrVale As DataRow
            For Each DrVale In DS.Tables("ValeQ").Rows
                DrVale.BeginEdit()
                DrVale("Confirmado") = True
                DrVale("Modulo") = "Mensalistas"
                DrVale.EndEdit()
            Next DrVale

            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAConfirmarVale)
            DAConfirmarVale.Update(DS, "ValeQ")
            CNN.Close()
            MsgBox("Vale Quinzenal gerado e confirmado com sucesso.", 64, "Validação de Dados")
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Ocorreram erros na geração do vale, o processo foi cancelado, verifique.", 64, "Validação de Dados")
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub GeraPIS()
        If Me.Modulo.Text = "" Then
            MsgBox("O usuário deve escolher o modulo para gerar a folha", 64, "Validação de Dados")
            Exit Sub
        End If
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

        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' AND Modulo = '" & Me.Modulo.Text & "' AND Empresa = " & CodEmpresa & " and Confirmado = False"
        Dim DaValidar As New OleDb.OleDbDataAdapter(Sql, CNN)
        DaValidar.Fill(DS, "Validar")
        Dim TotalValidar As Integer = DS.Tables("Validar").Rows.Count
        If TotalValidar = 0 Then
            MsgBox("Não existe lançamento de PIS para gerar nesta competência. Verifique", 64, "Validação de Dados")
            Exit Sub
        End If

        Sql = "SELECT FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcionários.Nome, Funcionários.CodPlanoContas, Funcionários.TipoPagamentoMensal, Sum(FolhaPgto.VlrDebito) AS SomaDeVlrDebito, Sum(FolhaPgto.VlrCredito) AS SomaDeVlrCredito, FolhaPgto.Empresa FROM FolhaPgto INNER JOIN Funcionários ON FolhaPgto.Funcionario = Funcionários.CódigoFuncionário GROUP BY FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcionários.Nome, Funcionários.CodPlanoContas, Funcionários.TipoPagamentoMensal, FolhaPgto.Empresa HAVING (((FolhaPgto.Competencia)='" & Me.MensalCompetencia.Text & "') AND ((FolhaPgto.Modulo)='" & Me.Modulo.Text & "') AND ((FolhaPgto.Empresa)=" & CodEmpresa & ")) order by Funcionários.Nome ;"
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
        Me.Msg.Text = "Gerando Pagamento."
        Me.Msg.Refresh()

        Dim DrPagamento As DataRow
        For Each DrPagamento In DS.Tables("Pagamentos").Rows

            Dim Ult As String
            Ult = CalcIdLancamento()

            'Sql = "SELECT Max("& AnoContabel &".Id) AS MáxDeId FROM "& AnoContabel &";"
            'Cmd = New OleDb.OleDbCommand(Sql, CNN)
            'Try

            '    DR = Cmd.ExecuteReader
            '    DR.Read()
            '    If DR.HasRows Then
            '        Ult = DR.Item("MáxDeId")
            '    Else
            '        Ult = 0
            '    End If
            '    DR.Close()
            '    Ult += 1

            'Catch Merror As System.Exception
            '    Ult = 1
            'End Try

            Dim IIDD As String = ""

            Sql = "INSERT INTO " & AnoContabel & " (DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Cmd = New OleDb.OleDbCommand(Sql, CNN)

            'Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DrPagamento("CodPlanoContas")))
            Select Case DrPagamento("TipoPagamentoMensal")
                Case "CARTÃO"
                    Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.BancoCartaoConta.Text))
                    IIDD = Me.MensalCompetencia.Text
                    IIDD = IIDD.Remove(2, 1)
                    IIDD = IIDD & DrPagamento("Funcionario")
                Case "CHEQUE"
                    If ChequeInicial = 0 Then
                        My.Forms.FolhaPgtoPegaContaCheque.ShowDialog()
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
                    IIDD = IIDD & DrPagamento("Funcionario")
            End Select
            Dim VlrPgto As Double = CDbl(DrPagamento("SomaDeVlrCredito"))

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", VlrPgto))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "PIS"))
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
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", DrPagamento("CodPlanoContas")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IIDD))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.DataLançamento.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", VlrPgto))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "PIS"))
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

                'Sql = "SELECT Max(LancamentoBanco.Id) AS MáxDeId FROM LancamentoBanco;"
                'Cmd = New OleDb.OleDbCommand(Sql, CNN)
                'Try

                '    DR = Cmd.ExecuteReader
                '    DR.Read()
                '    If DR.HasRows Then
                '        Ult = DR.Item("MáxDeId")
                '    Else
                '        Ult = 0
                '    End If
                '    DR.Close()
                '    Ult += 1

                'Catch Merror As System.Exception
                '    Ult = 1
                'End Try

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
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", DrPagamento("CodPlanoContas")))
                Select Case DrPagamento("TipoPagamentoMensal")
                    Case "CARTÃO"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Me.BancoCartaoConta.Text))
                    Case "CHEQUE"
                        Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", ContaCheque))
                End Select
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Me.DescPagamento.Text & " " & DrPagamento("Nome")))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", True))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", "PIS"))
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

            Me.MyBarra.PerformStep()
        Next DrPagamento

        Try
            Sql = "SELECT * FROM FolhaPgto where FolhaPgto.Competencia = '" & Me.MensalCompetencia.Text & "' AND FolhaPgto.Modulo = '" & Me.Modulo.Text & "' AND FolhaPgto.Empresa = " & CodEmpresa
            Dim DAConfirmarVale As New OleDb.OleDbDataAdapter(Sql, CNN)

            DAConfirmarVale.Fill(DS, "PgtoPIS")


            TotalLinhas = DS.Tables("PgtoPIS").Rows.Count
            'Atualiza a barra de Progresso
            If TotalLinhas = 0 Then TotalLinhas = 1
            MyBarra.Visible = True
            MyBarra.Minimum = 1
            MyBarra.Maximum = TotalLinhas
            MyBarra.Value = 1
            MyBarra.Step = 1
            Me.Msg.Visible = True
            Me.Msg.Text = "Conirmando Lançamento do PIS."
            Me.Msg.Refresh()

            Dim DrVale As DataRow
            For Each DrVale In DS.Tables("PgtoPIS").Rows
                DrVale.BeginEdit()
                DrVale("Confirmado") = True
                DrVale("Modulo") = "Pgto PIS"
                DrVale.EndEdit()
            Next DrVale

            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAConfirmarVale)
            DAConfirmarVale.Update(DS, "PgtoPIS")
            CNN.Close()
            MsgBox("Pagamento de PIS gerado e confirmado com sucesso.", 64, "Validação de Dados")
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Ocorreram erros na geração do Pagamento do PIS, o processo foi cancelado, verifique.", 64, "Validação de Dados")
            CNN.Close()
            Exit Sub
        End Try

    End Sub


#End Region


    Private Sub GerarLanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerarLanc.Click
        If Me.Modulo.Text = "Mensalistas" Then
            GeraMensalistas()
        End If

        If Me.Modulo.Text = "Vale Quinzenal" Then
            GeraValeQuinzenal()
        End If

        If Me.Modulo.Text = "Pgto PIS" Then
            GeraPIS()
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

    Private Sub MensalCompetencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MensalCompetencia.Enter
        If MesAnoCompetencia = "" Then
            MsgBox("O Mês e Ano de competência não foi informado, favor verificar.", 64, "Validação de Dados")
            Exit Sub
        End If
        Me.MensalCompetencia.Text = MesAnoCompetencia
    End Sub


    Private Sub MensalCompetencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MensalCompetencia.TextChanged

    End Sub
End Class