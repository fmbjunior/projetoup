Public Class CaixaLançamentos

    Dim Ação As New TrfGerais

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If Adi = False Then
            MsgBox("O Usuário não tem permissão para Adicionar dados do caixa, verifique com Administrador.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.A1.Checked = False And Me.A2.Checked = False Then
            MessageBox.Show("O usuário deve selecionar se é débito ou crédito no caixa", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.DataLancamento.Text = "" Then
            MsgBox("A data de lançamento não pode ser nula", 64, "Validação de Dados")
            Me.DataLancamento.Focus()
            Exit Sub
        ElseIf Me.CliFor.Text = "" Then
            Dim Mm As String = String.Empty
            If Me.A1.Checked = True Then Mm = "O Cliente não pode ser nulo"
            If Me.A2.Checked = True Then Mm = "O Fornecedor não pode ser nulo"
            MsgBox(Mm, 64, "Validação de Dados")
            Me.CliFor.Focus()
            Exit Sub
        ElseIf Me.Documento.Text = "" Then
            MsgBox("O Documento não pode ser nulo", 64, "Validação de Dados")
            Me.Documento.Focus()
            Exit Sub
        ElseIf Me.DataDocumento.Text = "" Then
            MsgBox("A data do documento não pode ser nulo", 64, "Validação de Dados")
            Me.DataDocumento.Focus()
            Exit Sub
        ElseIf Me.Valor.Text = "" Then
            MsgBox("O Valor do lançamento não pode ser nulo", 64, "Validação de Dados")
            Me.Valor.Focus()
            Exit Sub
        End If

        If Me.A2.Checked = True Then
            If Me.ContaBalancete.Text = "" Then
                MsgBox("A Conta de Receita não pode ser nulo", 64, "Validação de Dados")
                Me.ContaBalancete.Focus()
                Exit Sub
            End If
            If Me.ContaCC.Text = "" Then
                MsgBox("A Conta de centro de custo não pode ser nulo", 64, "Validação de Dados")
                Me.ContaCC.Focus()
                Exit Sub
            End If
        End If

        If Me.A1.Checked = True Then
            If Me.ContaBalancete.Text = "" Then
                MsgBox("A Conta de Receita não pode ser nulo", 64, "Validação de Dados")
                Me.ContaBalancete.Focus()
                Exit Sub
            End If
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim CmdCaixa As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdReceber As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdPagar As OleDb.OleDbCommand = CNN.CreateCommand

        CmdCaixa.Transaction = Transacao
        CmdReceber.Transaction = Transacao
        CmdPagar.Transaction = Transacao

        Try

            Dim TipoLanc As String = String.Empty
            Dim ValorLanc As Double
            If Me.A1.Checked = True Then
                TipoLanc = "C"
                ValorLanc = CDbl(NzZero(Me.Valor.Text))
            End If
            If Me.A2.Checked = True Then
                TipoLanc = "D"
                ValorLanc = CDbl(NzZero(Me.Valor.Text)) * -1
            End If

            Dim IdLocal As String = String.Empty

            Dim UltReg As Integer

            If Me.A1.Checked = True Then
                IdLocal = "RECEBER"


                UltReg = UltimoRegReceber()
                Dim SqlReceber As String = "INSERT INTO Receber (Documento, DataDocumento, ValorDocumento, ValorLiquido, LocalPgto, CodCliente, Cliente, Empresa, OriginalParcial, Vencimento, Recebimento, Baixado, ContaValorBaixado, CaixaBaixado, Id, Referencia) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16)"
                CmdReceber.CommandText = SqlReceber

                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@1", "CX-" & Nz(Me.Documento.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataDocumento.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Valor.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Valor.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@5", "CARTEIRA"))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.CliFor.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.CliForDesc.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@9", "O"))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.DataLancamento.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.DataLancamento.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@12", True))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ContaBalancete.Text, 1)))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@14", My.Forms.Caixa.CaixaCod.Text))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@15", UltReg))
                CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Historico.Text, 1)))
                CmdReceber.ExecuteNonQuery()

                CmdReceber.CommandText = "SELECT @@IDENTITY"
                UltReg = CmdReceber.ExecuteScalar.ToString

            End If

            If Me.A2.Checked = True Then
                IdLocal = "PAGAR"
                UltReg = UltimoRegPagar()
                Dim SqlPagar As String = "INSERT INTO Pagar (Documento, DataDocumento, ValorDocumento, ValorLiquido, LocalPgto, CodFornecedor, Fornecedor, Empresa, Vencimento, Pagamento, Baixado, ContaValorBaixado, CaixaBaixado, Id, Conta1, Referencia, Percent1) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"
                CmdPagar.CommandText = SqlPagar

                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@1", "CX-" & Nz(Me.Documento.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataDocumento.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Valor.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Valor.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@5", "CARTEIRA"))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.CliFor.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.CliForDesc.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.DataLancamento.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.DataLancamento.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@11", True))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.ContaBalancete.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@13", My.Forms.Caixa.CaixaCod.Text))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@14", UltReg))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.ContaCC.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Historico.Text, 1)))
                CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@17", nzNUM(100)))
                CmdPagar.ExecuteNonQuery()

                CmdPagar.CommandText = "SELECT @@IDENTITY"
                UltReg = CmdPagar.ExecuteScalar.ToString
            End If


            Dim Sql As String = "INSERT INTO LancamentoBanco (Id, DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19)"
            CmdCaixa.CommandText = Sql

            Dim Ult As Integer = UltimoReg()
            Me.Id.Text = Ult

            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@3", False))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@4", System.DBNull.Value))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Documento.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DataDocumento.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(TipoLanc, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.CliForDesc.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Historico.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@10", Nz("S", 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@11", True)) 'Confirmado Lancamento como true
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@13", ValorLanc))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(My.Forms.Caixa.CaixaCod.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.ContaBalancete.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@17", "CAIXA"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@18", IdLocal))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@19", UltReg))

            CmdCaixa.ExecuteNonQuery()

            CmdCaixa.CommandText = "SELECT @@IDENTITY"
            Dim IdLancBancoCaixa As Integer = CmdCaixa.ExecuteScalar.ToString


            If A2.Checked = True Then
                Dim CmdConta1 As OleDb.OleDbCommand = CNN.CreateCommand
                CmdConta1.Transaction = Transacao

                If Me.ContaCC.Text <> "" Then
                    CmdConta1.CommandText = "INSERT INTO CcLanc (IdCaixaBanco, ContaCC, DataLanc, ValorLanc) VALUES (@1, @2, @3, @4)"
                    CmdConta1.Parameters.Add(New OleDb.OleDbParameter("@1", nzINT(IdLancBancoCaixa)))
                    CmdConta1.Parameters.Add(New OleDb.OleDbParameter("@2", nzNUL(Me.ContaCC.Text)))
                    CmdConta1.Parameters.Add(New OleDb.OleDbParameter("@3", nzDAT(DataDia)))
                    CmdConta1.Parameters.Add(New OleDb.OleDbParameter("@4", nzNUM(ValorLanc)))
                    CmdConta1.ExecuteNonQuery()
                End If
            End If



            Transacao.Commit()
            CNN.Close()

            If Me.A1.Checked = True Then
                If MsgBox("Deseja imprimir o recibo de Recebimento.", 36, "Validação de Dados") = 6 Then
                    'Fazer impressão do recibo
                    RelatorioCarregar = "RelReciboCaixa"
                    My.Forms.VisualizadorRelatorio.ShowDialog()
                End If
            End If

            My.Forms.Caixa.MostraCaixa()
            MsgBox("Lançamento feito no caixa do dia : " & Me.DataLancamento.Text, 64, "Validação de Dados")
            ErroLivre = "Lançamento feito no caixa Doc" & Me.Documento.Text
            GerarLog(Me.Text, AçãoTP.Livre, My.Forms.Caixa.CaixaCod.Text) 'Me.Documento.Text)
            'GerarLog(Me.Text, AçãoTP.Livre, My.Forms.Caixa.CaixaCod.Text)

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox("Erro na Criação do Lancamento no caixa.", 64, "Validação de Dados")
            MsgBox(ex.Message, 64, "Validação de Dados")
            CNN.Close()
        End Try

        If MsgBox("Deseja fazer um novo Lançamento", 36, "Validação de Dados") = 6 Then
            If Me.TravarDados.Checked = True Then
                Me.Valor.Clear() : Me.Documento.Clear() : Me.Documento.Focus()
            Else
                Me.Documento.Clear() : Me.CliFor.Clear() : Me.CliForDesc.Clear()
                Me.ContaCC.Clear() : Me.ContaCCDesc.Clear() : Me.Documento.Clear() : Me.ContaBalancete.Clear() : Me.ContaBalanceteDesc.Clear()
                Me.DataDocumento.Clear() : Me.Valor.Clear() : Me.Historico.Clear()
                Me.A1.Checked = False : Me.A2.Checked = False
                Me.DataLancamento.Focus()
            End If
        Else
            btFechar_Click(sender, e)
        End If


    End Sub

    Private Sub CaixaLançamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Ação.Desbloquear_Controle(Me, True)
            Me.DataLancamento.Text = DataDia
            Me.LabelCliFor.Text = "Cliente"
            Me.LabelReceitaDespesa.Text = "Conta de Receita"
            Me.ContaCC.Enabled = False
            Me.ContaCCDesc.Enabled = False
            Me.btFindContaLanc.Enabled = False
            Me.CliFor.Clear()
            Me.CliForDesc.Clear()
            Me.CliFor.Focus()
        End If

        If Me.A2.Checked = True Then
            Ação.Desbloquear_Controle(Me, True)
            Me.DataLancamento.Text = DataDia
            Me.LabelCliFor.Text = "Fornecedor"
            Me.LabelReceitaDespesa.Text = "Conta de Despesa"
            Me.ContaCC.Enabled = True
            Me.ContaCCDesc.Enabled = True
            Me.btFindContaLanc.Enabled = True
            Me.CliFor.Clear()
            Me.CliForDesc.Clear()
            Me.CliFor.Focus()
        End If

    End Sub

    Private Sub CliFor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CliFor.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.A1.Checked = True Then
                My.Forms.ClientesProcura.ShowDialog()
            End If
            If Me.A2.Checked = True Then
                My.Forms.TelaProcuraFor.ShowDialog()
            End If
        End If
    End Sub

    Private Sub CliFor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CliFor.Leave
        If String.CompareOrdinal(Me.CliFor.Text, Me.CliFor.TextoAntigo) Then
            If Me.A1.Checked = True Then
                AchaCli()
            End If
            If Me.A2.Checked = True Then
                AchaFor()
            End If
        End If
    End Sub


    Public Sub AchaFor()

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()
        Dim Sql As String = "Select * from Fornecedor where CódigoFornecedor = " & Me.CliFor.Text & " And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CliForDesc.Text = DR.Item("RazãoSocial") & ""
        End If
        Cn.Close()
    End Sub

    Public Sub AchaCli()

        If Me.CliFor.Text = "" Then
            Exit Sub
        End If

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()
        Dim Sql As String = "Select * from Clientes where Codigo = " & Me.CliFor.Text & " And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CliForDesc.Text = DR.Item("Nome") & ""
        Else
            MessageBox.Show("Cliente não encontrado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CliFor.Clear()
            Me.CliForDesc.Clear()
            Me.CliFor.Focus()
        End If
        Cn.Close()
    End Sub

    Public Sub AchaContaBalancete()

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()
        Dim Sql As String = "Select * from ContasG3 where ContaGrupo3 = '" & Me.ContaBalancete.Text & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.ContaBalanceteDesc.Text = DR.Item("DescContaGrupo3") & ""
        End If
        Cn.Close()
    End Sub

    Private Sub ContaBalancete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaCC.KeyDown

        If e.KeyCode = Keys.F5 Then
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
        End If
    End Sub

    Private Sub ContaCC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaCC.Leave
        If String.CompareOrdinal(Me.ContaCC.Text, Me.ContaCCDesc.TextoAntigo) Then
            AchaContaCc(Me.ContaCC.Text, Me.ContaCCDesc)
        End If
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


    Public Function UltimoRegReceber() As Integer
        'Inserir ultimo registro

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim Sql As String = "Select max(Id) from Receber"
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

    Public Function UltimoRegPagar() As Integer
        'Inserir ultimo registro

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim Sql As String = "Select max(Id) from Pagar"
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


    Private Sub btFindContaLanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindContaLanc.Click
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        AchaContaCc(Me.ContaCC.Text, Me.ContaCCDesc)
        Me.ContaCC.Focus()

    End Sub

    Private Sub btFindCliFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCliFor.Click
        If Me.A1.Checked = True Then
            My.Forms.ClientesProcura.ShowDialog()
            AchaCli()
            Me.CliFor.Focus()
        End If
        If Me.A2.Checked = True Then
            My.Forms.TelaProcuraFor.ShowDialog()
            AchaFor()
            Me.CliFor.Focus()
        End If
    End Sub

    Private Sub btFindCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCR.Click
        If Me.A1.Checked = True Then
            My.Forms.BalanceteContasProcura.TipoConta = "C"
        End If
        If Me.A2.Checked = True Then
            My.Forms.BalanceteContasProcura.TipoConta = "D"
        End If
        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete()
        Me.ContaBalancete.Focus()


    End Sub

    Private Sub ContaCR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaBalancete.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.A1.Checked = True Then
                My.Forms.BalanceteContasProcura.TipoConta = "C"
            End If
            If Me.A2.Checked = True Then
                My.Forms.BalanceteContasProcura.TipoConta = "D"
            End If
            My.Forms.BalanceteContasProcura.ShowDialog()
        End If
    End Sub

    Private Sub ContaBalancete_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaBalancete.Leave
        If String.CompareOrdinal(Me.ContaBalancete.Text, Me.ContaBalanceteDesc.TextoAntigo) Then
            AchaContaBalancete()
        End If

    End Sub

    Public Sub AchaContaCc(ByVal Conta As String, ByVal CampoParaRetornar As Control)

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

    Private Sub DataDocumento_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataDocumento.Enter
        Me.DataDocumento.Text = DataDia
    End Sub


End Class