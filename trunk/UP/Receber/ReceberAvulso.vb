Public Class ReceberAvulso

    Dim Ação As New TrfGerais

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        Dim cxFechado As New CaixaFechado
        cxFechado.CaixaEstaFechado()

        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este Lançamento já foi confirmado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.DataVencimento.Text = "" Then
            MsgBox("A Data do Documento não pode ser nula", 64, "Validação de Dados")
            Me.DataVencimento.Focus()
            Exit Sub

        ElseIf Me.DataLancamento.Text = "" Then
            MsgBox("A data de Lançamento não pode ser nula", 64, "Validação de Dados")
            Me.DataLancamento.Focus()
            Exit Sub

        ElseIf Me.Documento.Text = "" Then
            MsgBox("O Documento não pode ser nulo", 64, "Validação de Dados")
            Me.Documento.Focus()
            Exit Sub
        ElseIf Me.ValorDoc.Text = "" Then
            MsgBox("O Valor do lançamento não pode ser nulo", 64, "Validação de Dados")
            Me.ValorDoc.Focus()
            Exit Sub
        ElseIf Me.Cliente.Text = "" Then
            MsgBox("O Cliente não pode ser nulo", 64, "Validação de Dados")
            Me.Cliente.Focus()
            Exit Sub
        ElseIf Me.Vendedor.Text = "" Then
            MsgBox("O Vendedor não pode ser nulo", 64, "Validação de Dados")
            Me.Vendedor.Focus()
            Exit Sub
        ElseIf Me.LocalPgto.Text = "" Then
            MsgBox("O Local de pagamento não pode ser nulo", 64, "Validação de Dados")
            Me.LocalPgto.Focus()
            Exit Sub
        ElseIf Me.ContaLancamento.Text = "" Then
            MsgBox("A Conta de Lançamento não pode ser nulo", 64, "Validação de Dados")
            Me.ContaLancamento.Focus()
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Me.Confirmado.Checked = True
        UltimoReg()

        If Me.Id.Text = "0000" Then
            MessageBox.Show("Nao foi criado o [ID] do registro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CNN.Close()
            Exit Sub
        End If

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim cmd As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdReceber As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdDebito As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdCredito As OleDb.OleDbCommand = CNN.CreateCommand


        cmd.Transaction = Transacao
        CmdReceber.Transaction = Transacao
        CmdDebito.Transaction = Transacao
        CmdCredito.Transaction = Transacao

        Try

            cmd.CommandText = "INSERT INTO ReceberLancamentoAvulso (Id, Cliente, Documento, DataVencimento, DataLancamento, ValorDoc, Historico, Confirmado, Empresa, LocalPgto, Vendedor, ContaLancamento) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12)"

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataVencimento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorDoc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Historico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.LocalPgto.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.Vendedor.SelectedValue))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Me.ContaLancamento.Text))


            cmd.ExecuteNonQuery()

            UltimoRegReceber()
            CmdReceber.CommandText = "INSERT INTO Receber (Documento, DataDocumento, ValorDocumento, ValorLiquido, LocalPgto, PedidoProdutos, CodCliente, Cliente, Empresa, OriginalParcial, Vencimento, Recebimento, Baixado, Id, Referencia, Vendedor, ContaValorBaixado, Virtual, Origem) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @20)"

            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@1", Mid("AV" & Me.Id.Text & "-" & Me.Documento.Text, 1, 25)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ValorDoc.Text, 1)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorDoc.Text, 1)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@5", Me.LocalPgto.Text))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@6", "0"))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cliente.Text, 1)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ClienteDesc.Text, 1)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@10", "O"))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.DataVencimento.Text, 1)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@12", System.DBNull.Value))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@13", False))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@14", Me.IdReceber.Text))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.Historico.Text, 1)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@16", Me.Vendedor.SelectedValue))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.ContaLancamento.Text, 1)))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@18", False))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@20", "AVULSO"))
            CmdReceber.ExecuteNonQuery()

            Transacao.Commit()
            CNN.Close()

            MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Confirmou, Me.Id.Text)
            If MessageBox.Show("Deseja baixar o Recebimento gerado pelo lançamento", "Validação de Dados", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If Me.IdReceber.Text = "" Then
                    MessageBox.Show("Não pode carregar o lançamento, a Identificação não foi criada, verifique...", "Validação de Dados", MessageBoxButtons.OK)
                    Exit Sub
                End If

                If Len(CaixaAtivo) <> 4 Then
                    MessageBox.Show("O usuário não tem caixa ativo e não pode baixar o Documento, ative e baixe pelo central de pagamento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                My.Forms.ReceberBaixa.AchaRegistro(Me.IdReceber.Text)
                My.Forms.ReceberBaixa.ShowDialog()
            End If

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try

        CNN.Close()

    End Sub


    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from ReceberLancamentoAvulso"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Me.Id.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub


    Public Sub UltimoRegReceber()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from Receber"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Me.IdReceber.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub



    Private Sub DataLancamento_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        If Me.DataLancamento.Text = "" Then
            Me.DataLancamento.Text = DataDia
        End If
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown

        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
                LocalizaDadosCliente()
            End If
        End If
    End Sub

    Public Sub LocalizaDadosCliente()
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Clientes.* FROM Clientes WHERE Clientes.Empresa = " & CodEmpresa & " AND Clientes.Codigo = " & Me.Cliente.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        Else
            MessageBox.Show("Cliente não encontrado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cliente.Clear()
            Me.Cliente.Focus()
        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.Desbloquear_Controle(Me, True)
        Me.Id.Text = "0000"

        Me.Cliente.Clear()
        Me.ClienteDesc.Clear()
        Me.Documento.Clear()
        Me.ValorDoc.Clear()
        Me.DataLancamento.Clear()
        Me.DataVencimento.Clear()
        Me.Historico.Clear()
        Me.ContaLancamento.Clear()
        Me.ContaLancamentoDesc.Clear()
        Me.Confirmado.Checked = False



        Me.LocalPgto.SelectedValue = -1
        Me.Vendedor.SelectedValue = -1

        Me.Cliente.Focus()
    End Sub

    Private Sub Cliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Cliente.Validating
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If
    End Sub


    Private Sub btFindClintes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClintes.Click

        My.Forms.ClientesProcura.ShowDialog()
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If

    End Sub

    Private Sub ReceberAvulso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        EncheListaVendedor()
        EncheListaLocalPgto()
    End Sub

    Private Sub EncheListaVendedor()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select Funcionários.CódigoFuncionário, Funcionários.Nome From Funcionários  Where Funcionários.Empresa = " & CodEmpresa & " And Funcionários.AdicionarEmVendas = True Order by Funcionários.Nome"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Vendedor.DataSource = ds.Tables("Table").DefaultView
        Me.Vendedor.DisplayMember = "Nome"
        Me.Vendedor.ValueMember = "CódigoFuncionário"
        Me.Vendedor.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheListaLocalPgto()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * From LocalPagamento Where Empresa = " & CodEmpresa
        Dim ds As New DataSet
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(ds, "LocalPgto")

        Me.LocalPgto.DataSource = ds.Tables("LocalPgto")
        Me.LocalPgto.ValueMember = "LocalPgto"
        Me.LocalPgto.DisplayMember = "LocalPgto"
        Cnn.Close()

    End Sub

    Private Sub btFindValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindContaLanc.Click
        ' IdContaLanc = "VALORDOC" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete(Me.ContaLancamento.Text, Me.ContaLancamentoDesc)
        Me.ContaLancamento.Focus()
    End Sub

    Private Sub ContaLancamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaLancamento.KeyDown
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
        Else
            MessageBox.Show("Conta Inexistente, Favor verificar...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ContaLancamento.Focus()
            Exit Sub
        End If
        Cnn.Close()
    End Sub

    Private Sub ContaLancamento_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContaLancamento.Validating
        If String.CompareOrdinal(Me.ContaLancamento.Text, Me.ContaLancamento.TextoAntigo) Then
            AchaContaBalancete(Me.ContaLancamento.Text, Me.ContaLancamentoDesc)
        End If
    End Sub

    Private Sub ContaCR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F5 Then
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
        End If
    End Sub

    Public Sub AchaContaCR(ByVal Conta As String, ByVal CampoParaRetornar As Control)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from ContasCR2 where CR2 = '" & Conta & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescCr2") & ""
        Else
            CampoParaRetornar.Text = ""
            Exit Sub
        End If
        Cnn.Close()
    End Sub
End Class