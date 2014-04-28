Public Class BancoLançamento
    Dim Ação As New TrfGerais


    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Me.PreDatado.Checked = False
        Ação.Desbloquear_Controle(Me, True)
        Me.Id.Enabled = False
        Me.A1.Enabled = True
        Me.A2.Enabled = True
        Me.A3.Enabled = True
        Me.A4.Enabled = True

        If Me.TravarDados.Checked = False Then
            Ação.LimpaTextBox(Me)
        Else
            Me.Documento.Clear()
            Me.ValorDocumento.Clear()
        End If
        A1_CheckedChanged(sender, e)
        Me.DataLancamento.Focus()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click

        If Me.A1.Checked = False And Me.A2.Checked = False And Me.A3.Checked = False And Me.A4.Checked = False Then
            MessageBox.Show("O usuário deve selecionar um tipo de Lançamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.PreDatado.Checked = True And Me.DataPreDatado.Text = "" Then
            MsgBox("O usuário não pode lancar um cheque pre-datado sem que haja uma data para compensação", 64, "Validação de Dados")
            Me.DataPreDatado.Focus()
            Exit Sub
        End If

        If Me.PreDatado.Checked = True And Me.TipoLancamento.Text = "C" Then
            MsgBox("Um cheque pré-datado não pode ser um Crédito na conta", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.DataLancamento.Text = "" Then
            MsgBox("A data de Lançamento não pode ser nula", 64, "Validação de Dados")
            Me.DataLancamento.Focus()
            Exit Sub
        ElseIf Me.DataDocumento.Text = "" Then
            MsgBox("A data do documento não pode ser nula", 64, "Validação de Dados")
            Me.DataDocumento.Focus()
            Exit Sub
        ElseIf Me.Documento.Text = "" Then
            MsgBox("O documento não foi informado, verifique as informações digitadas.", 64, "Validação de Dados")
            Me.Documento.Focus()
            Exit Sub
        ElseIf Me.ValorDocumento.Text = "" Then
            MsgBox("O valor do documento não pode ser nulo", 64, "Validação de Dados")
            Me.ValorDocumento.Focus()
            Exit Sub
        ElseIf Me.Favorecido.Text = "" Then
            MsgBox("O favorecido não pode ser nulo", 64, "Validação de Dados")
            Me.Favorecido.Focus()
            Exit Sub
        ElseIf Me.Historico.Text = "" Then
            MsgBox("O histórico não pode ser nulo", 64, "Validação de Dados")
            Me.Historico.Focus()
            Exit Sub
        ElseIf Me.CaiuBanco.Text = "" Then
            MsgBox("O usuário precisa informar se o documento caiu ou não no banco.", 64, "Validação de Dados")
            Me.CaiuBanco.Text = "N"
            Exit Sub
        End If

        If NzZero(Me.ValorDocumento.Text) = 0 Then
            MessageBox.Show("O valor do documento não pode serm [0,00]", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorDocumento.Focus()
            Exit Sub
        End If

        If Me.A3.Checked = True And Me.ContaCorrenteTranferencia.Text = "" Then
            MessageBox.Show("O usuário deve informar qual é a conta que vai ser feita a transferência.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.A1.Checked = True And Me.A2.Checked = True And Me.CentroCusto.Text = "" Then
            MessageBox.Show("O usuário deve informar qual é a Conta de lançamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.A4.Checked = True Then
            If Me.CodigoCaixa.Text = "" Then
                MessageBox.Show("O usuário deve informar uma conta do caixa", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CodigoCaixa.Focus()
                Exit Sub
            End If
            Dim Achou As Boolean = AchaContaCaixa()
            If Achou = False Then
                Exit Sub
            End If
        End If

        'If Me.ContaBalancete.Text = "" Then
        '    MessageBox.Show("O usuário deve selecionar a conta de Lançamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.ContaBalancete.Focus()
        '    Exit Sub
        'End If

        If Me.ContaCorrenteTranferencia.Text = My.Forms.BancoVisualizador.Codigo.Text Then
            MessageBox.Show("O usuário deve selecionar uma conta diferente da conta atual.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ContaCorrenteTranferencia.Focus()
            Exit Sub
        End If

        Dim Sql As String = String.Empty
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim CmdBanco As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdTRF As OleDb.OleDbCommand = CNN.CreateCommand

        CmdBanco.Transaction = Transacao
        CmdTRF.Transaction = Transacao

        Try
            Sql = "INSERT INTO LancamentoBanco (Id, DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura, CentroCusto) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20)"
            CmdBanco.CommandText = Sql

            Dim VarID As Integer = UltimoReg()

            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@1", VarID))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@3", Me.PreDatado.Checked))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataPreDatado.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Documento.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DataDocumento.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.TipoLancamento.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Favorecido.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Historico.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.CaiuBanco.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@11", True)) 'Confirmado Lancamento como true
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
            Dim Vlr As Double = 0
            If Me.TipoLancamento.Text = "D" Then Vlr = CDbl(NzZero(Me.ValorDocumento.Text)) * -1
            If Me.TipoLancamento.Text = "C" Then Vlr = CDbl(NzZero(Me.ValorDocumento.Text))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@13", Vlr))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(My.Forms.BancoVisualizador.Codigo.Text, 1)))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
            If Me.A3.Checked = True Or Me.A4.Checked = True Then
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@16", "000000"))
            Else
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.ContaBalancete.Text, 1)))
            End If
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@17", "BANCO"))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@18", "BANCOLANC"))
            CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@19", VarID))
            If Me.A3.Checked = True Or Me.A4.Checked = True Then
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@20", "000000"))
            Else
                CmdBanco.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.CentroCusto.Text, 1)))
            End If

            CmdBanco.ExecuteNonQuery()
            CmdBanco.CommandText = "SELECT @@IDENTITY"
            Dim IdLancBancoCaixa As Integer = CmdBanco.ExecuteScalar.ToString

            If A1.Checked = True Then
                Dim CmdConta1 As OleDb.OleDbCommand = CNN.CreateCommand
                CmdConta1.Transaction = Transacao

                If Me.CentroCusto.Text <> "" Then
                    CmdConta1.CommandText = "INSERT INTO CcLanc (IdCaixaBanco, ContaCC, DataLanc, ValorLanc) VALUES (@1, @2, @3, @4)"
                    CmdConta1.Parameters.Add(New OleDb.OleDbParameter("@1", nzINT(IdLancBancoCaixa)))
                    CmdConta1.Parameters.Add(New OleDb.OleDbParameter("@2", nzNUL(Me.CentroCusto.Text)))
                    CmdConta1.Parameters.Add(New OleDb.OleDbParameter("@3", nzDAT(DataDia)))
                    CmdConta1.Parameters.Add(New OleDb.OleDbParameter("@4", nzNUM(Me.ValorDocumento.Text)))
                    CmdConta1.ExecuteNonQuery()
                End If
            End If



            'Verificar se existe transferencia
            If Me.A3.Checked = True Or Me.A4.Checked = True Then
                Sql = "INSERT INTO LancamentoBanco (DataLancamento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Documento, ValorDocumento, EmitirCheque, ConfirmadoLancamento, Empresa, Historico, CaiuBanco, Tipo, IdLancamento, IdProcura, ContaBalancete,CentroCusto) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"
                CmdTRF.CommandText = Sql

                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.DataLancamento.Text, 1)))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataDocumento.Text, 1)))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@3", "C"))
                If Me.A3.Checked = True Then
                    CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ContaCorrenteTranferencia.Text, 1)))
                End If
                If Me.A4.Checked = True Then
                    CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.CodigoCaixa.Text, 1)))
                End If
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@5", "TRANSFERENCIA"))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Documento.Text, 1)))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorDocumento.Text, 1)))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@8", "N"))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@9", True)) 'Confirmado Lancamento como true
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@11", "TRANSF. DOC Nº " & Me.Documento.Text))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CaiuBanco.Text, 1)))
                If Me.A3.Checked = True Then
                    CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@13", "BANCO"))
                End If
                If Me.A4.Checked = True Then
                    CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@13", "CAIXA"))
                End If
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@14", "BANCOLANC"))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@15", VarID))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@16", "000000"))
                CmdTRF.Parameters.Add(New OleDb.OleDbParameter("@17", "000000"))
                CmdTRF.ExecuteNonQuery()
            End If
            'Fim da verificação de transferencia
           
            Transacao.Commit()
            CNN.Close()
            MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.Documento.Text)
            If MsgBox("Deseja Adicionar um novo Lançamento.", 36, "Validação de Dados") = 6 Then
                Novo_Click(sender, e)
            Else
                Me.Close()
                Me.Dispose()
            End If

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try

    End Sub

    Private Sub BancoLançamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Insert Then
            TRVDados(UserAtivo, "CodigoSegurança")
            If Ina = True Then
                MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                Exit Sub
            Else
                My.Forms.CodigoSegurança.ShowDialog()
            End If
        End If
    End Sub

    Private Sub BancoLançamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        Me.A1.Checked = False
        Me.A2.Checked = False
        Me.A3.Checked = False
        Me.A4.Checked = False
        Me.A1.Enabled = False
        Me.A2.Enabled = False
        Me.A3.Enabled = False
        Me.A4.Enabled = False
    End Sub

    Private Sub DataLancamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        Me.DataLancamento.Text = CDate(DataDia)
    End Sub

    Private Sub CaiuBanco_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CaiuBanco.Enter
        If Me.CaiuBanco.Text = "" Then Me.CaiuBanco.Text = "N"
    End Sub

    Private Sub ValorDocumento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorDocumento.Leave
        Me.ValorDocumento.Text = FormatNumber(Me.ValorDocumento.Text, 2)
    End Sub

    Private Sub LiberarDataLançamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiberarDataLançamentoToolStripMenuItem.Click
        Dim HH As DateTime = Now
        Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança.", "Validação de Dados", 0)

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            Exit Sub
        Else
            Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If

    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged
        If Me.A1.Checked Then
            Me.TipoLancamento.Text = "D"
            Me.GrupoCCTransf.Visible = False
            Me.PainelContaBalancete.Visible = True
            Me.LabelCaixa.Visible = False
            Me.CodigoCaixa.Visible = False
            Me.CentroCusto.Enabled = True
            Me.CentroCustoDesc.Enabled = True
            Me.btFindContaCentroCusto.Enabled = True
            Me.LabelDespesaReceita.Text = "Conta de Despesa"
            Me.DataLancamento.Focus()
        End If
        If Me.A2.Checked Then
            Me.TipoLancamento.Text = "C"
            Me.GrupoCCTransf.Visible = False
            Me.PainelContaBalancete.Visible = True
            Me.LabelCaixa.Visible = False
            Me.CodigoCaixa.Visible = False
            Me.LabelDespesaReceita.Text = "Conta de Receita"
            Me.CentroCusto.Enabled = False
            Me.CentroCustoDesc.Enabled = False
            Me.btFindContaCentroCusto.Enabled = False
            Me.DataLancamento.Focus()
        End If
        If Me.A3.Checked Then
            Me.TipoLancamento.Text = "D"
            Me.GrupoCCTransf.Visible = True
            Me.PainelContaBalancete.Visible = False
            Me.LabelCaixa.Visible = False
            Me.CodigoCaixa.Visible = False
            Me.ContaCorrenteTranferencia.Focus()
        End If
        If Me.A4.Checked Then
            Me.TipoLancamento.Text = "D"
            Me.GrupoCCTransf.Visible = False
            Me.PainelContaBalancete.Visible = False
            Me.LabelCaixa.Visible = True
            Me.CodigoCaixa.Visible = True
            Me.CaixaDesc.Visible = True
            Me.CaixaDesc.Text = ""
            Me.DataLancamento.Focus()
        End If

    End Sub

    Private Sub ContaCorrenteTranferencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaCorrenteTranferencia.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.TelaProcuraBancoCC.ShowDialog()
        End If
    End Sub

    Public Sub LocalizaCC()
        If Me.ContaCorrenteTranferencia.Text = "" Then Exit Sub

        Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOpen.Open()

        Dim Sql As String = "Select * from Banco where Codigo = '" & Me.ContaCorrenteTranferencia.Text & "' and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, DBOpen)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.ContaCorrenteTranferenciaDesc.Text = DR.Item("NomeBanco") & ""
        End If
        DR.Close()
        DBOpen.Close()
    End Sub

    Private Sub ContaCorrenteTranferencia_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaCorrenteTranferencia.Leave
        If String.CompareOrdinal(Me.ContaCorrenteTranferencia.Text, Me.ContaCorrenteTranferencia.TextoAntigo) Then
            LocalizaCC()
        End If
    End Sub


    Private Sub CentroCusto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CentroCusto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
        End If

    End Sub

    Private Sub CentroCusto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CentroCusto.Leave

        If String.CompareOrdinal(Me.CentroCusto.Text, Me.CentroCusto.TextoAntigo) Then
            AchaContaCR(Me.CentroCusto.Text, Me.CentroCustoDesc)
        End If

    End Sub

    Public Sub AchaContaBalancete()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from ContasG3 where ContaGrupo3 = '" & Me.ContaBalancete.Text & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.ContaBalanceteDesc.Text = DR.Item("DescContaGrupo3") & ""
        End If
        Cnn.Close()
    End Sub


    Public Function UltimoReg() As Integer
        'Inserir ultimo registro

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim Sql As String = "Select max(Id) from LancamentoBanco"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        Try
            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Ult = DR.Item(0)
            End If
            DR.Close()

        Catch Merror As System.Exception
            Return 0
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Function
            End If
        End Try

        Return Ult + 1


    End Function

    Private Sub DataDocumento_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataDocumento.Enter
        If Me.DataDocumento.Text = "" Then Me.DataDocumento.Text = DataDia
    End Sub

    Private Sub btFindContaCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindContaCentroCusto.Click
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        AchaContaCR(Me.CentroCusto.Text, Me.CentroCustoDesc)
        Me.CentroCusto.Focus()
    End Sub

    Private Sub btFindCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCC.Click
        My.Forms.TelaProcuraBancoCC.ShowDialog()
        LocalizaCC()
        Me.ContaCorrenteTranferencia.Focus()
    End Sub


    Private Function AchaContaCaixa() As Boolean
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from CaixaCadastro where CodigoCaixa = '" & Me.CodigoCaixa.Text & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Return True
        Else
            MessageBox.Show("Conta do Caixa inexistente, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodigoCaixa.Clear()
            Me.CodigoCaixa.Focus()
            Return False
        End If
        DR.Close()
    End Function


    Private Sub btContaDespesaReceita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btContaDespesaReceita.Click
        If Me.A1.Checked = True Then
            My.Forms.BalanceteContasProcura.TipoConta = "D"
        End If

        If Me.A2.Checked = True Then
            My.Forms.BalanceteContasProcura.TipoConta = "C"
        End If

        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete()
        Me.CentroCusto.Focus()
    End Sub

    Private Sub ContaBalancete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaBalancete.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.A1.Checked = True Then
                My.Forms.BalanceteContasProcura.TipoConta = "D"
            End If

            If Me.A2.Checked = True Then
                My.Forms.BalanceteContasProcura.TipoConta = "C"
            End If

            My.Forms.BalanceteContasProcura.ShowDialog()
        End If

    End Sub

    Private Sub ContaBalancete_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaBalancete.Leave
        If String.CompareOrdinal(Me.ContaBalancete.Text, Me.ContaBalancete.TextoAntigo) Then
            AchaContaBalancete()
        End If
    End Sub

    Public Sub AchaContaCR(ByVal Conta As String, ByVal CampoParaRetornar As Control)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from CC3 where ContaGrupo3 = '" & Conta & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescContaGrupo3") & ""
        Else
            CampoParaRetornar.Text = ""
            CampoParaRetornar.Focus()
            Exit Sub
        End If
        Cnn.Close()
    End Sub


    Private Sub CodigoCaixa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoCaixa.Leave

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT CaixaDia.CaixaCod, CaixaCadastro.CaixaNome, CaixaDia.DataCaixaDia, CaixaDia.Fechado FROM CaixaDia INNER JOIN CaixaCadastro ON CaixaDia.CaixaCod = CaixaCadastro.CodigoCaixa WHERE (((CaixaDia.CaixaCod)='" & Me.CodigoCaixa.Text & "') AND ((CaixaDia.DataCaixaDia)=#" & Format(CDate(DataDia), "MM/dd/yyyy") & "#) AND ((CaixaDia.Fechado)=False));"

        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CaixaDesc.Text = DR.Item("CaixaNome") & ""
        Else
            MessageBox.Show("Conta de caixa não encontrada, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodigoCaixa.Clear()
            Me.CaixaDesc.Text = ""
            Me.CodigoCaixa.Focus()
            Exit Sub
        End If
        Cnn.Close()

    End Sub

End Class