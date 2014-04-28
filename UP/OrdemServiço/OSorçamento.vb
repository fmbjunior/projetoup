Public Class OSorçamento

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Private OperationItens As Byte
    Public SomaTotalServico As Double = 0
    Public SomaTotalProdutos As Double = 0
    Private IdLinha As Integer

    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const NONE As Byte = 3
    Public Sub atGridServico()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String

        sql = "SELECT OrcamentoItemServico.Id, OrcamentoItemServico.CodigoOrcamento, OrcamentoItemServico.CodigoServico, Servicos.Serv_Descricao, Funcionários.Nome, OrcamentoItemServico.Qtd, OrcamentoItemServico.ValorUnitario, OrcamentoItemServico.ValorDesconto, OrcamentoItemServico.TotalServico FROM (OrcamentoItemServico INNER JOIN Servicos ON OrcamentoItemServico.CodigoServico = Servicos.Serv_Codigo) INNER JOIN Funcionários ON OrcamentoItemServico.Funcionario = Funcionários.CódigoFuncionário WHERE OrcamentoItemServico.CodigoOrcamento=" & NzZero(Me.CodOrçamento.Text)


        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet


        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView
        Me.TotalServico.Text = FormatCurrency(NzZero(ds.Tables("Table").Compute("SUM(totalservico)", "")), 2)
        Me.DServico.Text = FormatCurrency(NzZero(ds.Tables("Table").Compute("SUM(ValorDesconto)", "")), 2)
        SomaTotalServico = Me.TotalServico.Text


        Me.VlrDescProduto.Text = FormatCurrency(CDbl(NzZero(Me.DServico.Text)) + CDbl(NzZero(Me.DProduto.Text)), 2)
        Me.TotalOrcamento.Text = FormatCurrency(SomaTotalProdutos + SomaTotalServico, 2)
        Da.Dispose()
        CNN.Close()

    End Sub
    Public Sub atGridProduto()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String

        sql = "SELECT DISTINCTROW OrcamentoItensProduto.Id, OrcamentoItensProduto.Orcamento, OrcamentoItensProduto.CodigoProduto, Produtos.Descrição, OrcamentoItensProduto.Qtd, OrcamentoItensProduto.ValorUnitario, OrcamentoItensProduto.TotalProduto, OrcamentoItensProduto.ValorDesconto FROM Produtos INNER JOIN OrcamentoItensProduto ON Produtos.CodigoProduto = OrcamentoItensProduto.CodigoProduto WHERE OrcamentoItensProduto.Orcamento = " & Me.CodOrçamento.Text & " ORDER BY OrcamentoItensProduto.ID"


        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Try
            Da.Fill(ds, "Table")

            Me.dgvItemP.DataSource = ds.Tables("Table").DefaultView
            Me.ValorProduto.Text = FormatCurrency(NzZero(ds.Tables("Table").Compute("SUM(TotalProduto)", "")), 2)
            Me.DProduto.Text = FormatCurrency(NzZero(ds.Tables("Table").Compute("SUM(ValorDesconto)", "")), 2)
            Me.VlrDescProduto.Text = FormatCurrency(CDbl(NzZero(Me.DServico.Text)) + CDbl(NzZero(Me.DProduto.Text)), 2)
            SomaTotalProdutos = Me.ValorProduto.Text
            'Me.TotalOrcamento.Text = FormatCurrency(SomaTotalProdutos + SomaTotalServico, 2)
            Da.Dispose()
            CNN.Close()
        Catch ex As Exception
            Da.Dispose()
            CNN.Close()
        End Try

         
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        If Operation = UPD Then
            MessageBox.Show("O orçamento foi editado, clique no botão salvar para prosseguir", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub OSorçamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Operation = NONE Then
            MessageBox.Show("Clique no botão editar para inserir um item", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        If e.KeyCode = Keys.F6 Then
            Me.superTabControl1.SelectedTab = Me.SuperTabItemProduto
            btItens_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            ItemServico_Click(sender, e)
        End If
    End Sub

    Private Sub Orçamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RetornoProcura = ""
        Ação.Desbloquear_Controle(Me, False)
        Operation = NONE
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click

        Me.PedidoGerado.Visible = False
        Me.PedidoGeradoLabel.Visible = False

        Ação.LimpaTextBox(Me)
        Me.ConfImg.Visible = False
        Ação.Desbloquear_Controle(Me, True)
        Me.CodOrçamento.Enabled = False
        Me.CodOrçamento.Text = "0000"
        Me.Validade.Text = ValidadeOrcamento
        Me.GeradoPedido.Checked = False
        Me.DataOrçamento.Focus()
        atGridServico()
        atGridProduto()


        Operation = INS
        SomaTotalServico = 0
        SomaTotalProdutos = 0


    End Sub


    Private Sub AchaFuncionario()
        If Me.CódigoFuncionário.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Funcionários where CódigoFuncionário = " & Me.CódigoFuncionário.Text
        Dim CMD As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, CNN)
        Dim Dr As OleDb.OleDbDataReader

        Dr = CMD.ExecuteReader
        Dr.Read()

        If Dr.HasRows = True Then
            Me.FuncionarioDesc.Text = Dr.Item("Nome") & ""
        Else
            MessageBox.Show("Funcionário não encontrado, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CódigoFuncionário.Clear()
            Me.CódigoFuncionário.Focus()
            Exit Sub
        End If
        Dr.Close()
        CNN.Close()

    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If Me.CodOrçamento.Text = "" Then
            MsgBox("Não existe orçamento para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.GeradoPedido.Checked = True Then
            MessageBox.Show("Para este orçamento já foi gerado um Pedido, não pode ser editado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.CodOrçamento.Enabled = False
        Me.DataOrçamento.Focus()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        If Operation = NONE Then
            Exit Sub
        End If


        If Me.GeradoPedido.Checked = True Then
            MessageBox.Show("Para este orçamento já foi gerado um Pedido, não pode ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Area destinada para as validacoes
        If Me.ValorProduto.Text = "" Then FormatCurrency(0, 2)
        If Me.VlrDescProduto.Text = "" Then FormatCurrency(0, 2)
        If Me.TotalOrcamento.Text = "" Then FormatCurrency(0, 2)

        If Me.CódigoCliente.Text = "" Then
            MsgBox("O Código do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CódigoCliente.Focus()
            Exit Sub
        ElseIf Me.DataOrçamento.Text = "" Then
            MsgBox("A data do orçamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataOrçamento.Focus()
            Exit Sub
        ElseIf Me.Validade.Text = "" Then
            MsgBox("A Validade do Orçamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Validade.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes
        Me.TotalOrcamento.Text = FormatCurrency((SomaTotalProdutos + SomaTotalServico), 2)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            UltimoOrçamento()

            Dim Sql As String = "INSERT INTO Orcamento (Orcamento, CódigoCliente, DataOrcamento, Validade, ValorProduto, VlrDescProduto, TotalOrcamento, CódigoPagamento, GeradoPedido, Empresa, CódigoFuncionário, NomeCliente, CnpjCpf, RgIe, ValorServico, ObsServico) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Validade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.VlrDescProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.TotalOrcamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.CódigoPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.GeradoPedido.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NomeCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CpfCnpj.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.RgInscrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.TotalServico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.txtObservacao.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                MsgBox("Registro Salvo com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.CodOrçamento.Text)
                Operation = UPD
                Ação.Desbloquear_Controle(Me, False)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                Exit Sub
            End Try

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update Orcamento Set CódigoCliente = @1, DataOrcamento = @2, Validade = @3, ValorProduto = @4, VlrDescProduto = @5, TotalOrcamento = @6, CódigoPagamento = @7, GeradoPedido = @8, Empresa = @9, CódigoFuncionário = @10, NomeCliente = @11, CnpjCpf = @12, RgIe = @13, ValorServico=@14, ObsServico=@15 Where Orcamento = " & Me.CodOrçamento.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Validade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.VlrDescProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.TotalOrcamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.CódigoPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.GeradoPedido.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.NomeCliente.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CpfCnpj.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.RgInscrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.TotalServico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.txtObservacao.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.CodOrçamento.Text)
                Operation = NONE
                Ação.Desbloquear_Controle(Me, False)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            'Ação.Desbloquear_Controle(Me, False)
        End If
    End Sub

    Private Sub DataOrçamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataOrçamento.Enter
        If Me.DataOrçamento.Text = "" Then
            Me.DataOrçamento.Text = Format(CDate(Today), "dd/MM/yyyy")
        End If
    End Sub

    Private Sub CódigoCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CódigoCliente.KeyDown

        If e.KeyCode = Keys.F5 Then
            If Operation = INS Or Operation = UPD Then
                My.Forms.ClientesProcura.ShowDialog()
            End If
        End If

    End Sub

    Private Sub CódigoCliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CódigoCliente.Leave
        LocalizaDadosCliente()
    End Sub

    Public Sub LocalizaDadosCliente()

        If Me.CódigoCliente.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Clientes where inativo=false and Codigo = " & Me.CódigoCliente.Text
        Dim CMD As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, CNN)
        Dim Dr As OleDb.OleDbDataReader

        Dr = CMD.ExecuteReader
        Dr.Read()

        If Dr.HasRows = True Then
            Me.CpfCnpj.Text = Dr.Item("CpfCgc") & ""
            Me.RgInscrição.Text = Dr.Item("Insc") & ""
            Me.NomeCliente.Text = Dr.Item("Nome") & ""
            Me.TpComercio.Text = Dr.Item("TpComercio") & ""
        End If
        Dr.Close()
        CNN.Close()

    End Sub

    Private Sub CodigoProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.CodOrçamento.Text = "" Then
            MsgBox("Para lançar Itens o usuário deve selecionar um Orçamento ou salvar o atual'.", 64, "Validação de Dados")
            Me.CódigoCliente.Focus()
            Exit Sub
        End If
    End Sub

    
    Private Sub btItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btItens.Click
        If Operation = NONE Then
            MessageBox.Show("Clique no botão editar para inserir um item", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Me.CódigoCliente.Text = "" Then
            MsgBox("O Código do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CódigoCliente.Focus()
            Exit Sub
        ElseIf Me.DataOrçamento.Text = "" Then
            MsgBox("A data do orçamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataOrçamento.Focus()
            Exit Sub
        ElseIf Me.Validade.Text = "" Then
            MsgBox("A Validade do Orçamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Validade.Focus()
            Exit Sub
        End If

        If Me.ValorProduto.Text = "" Then Me.ValorProduto.Text = FormatCurrency(0, 2)
        If Me.VlrDescProduto.Text = "" Then Me.VlrDescProduto.Text = FormatCurrency(0, 2)
        If Me.TotalOrcamento.Text = "" Then Me.TotalOrcamento.Text = FormatCurrency(0, 2)


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            UltimoOrçamento()

            Dim Sql As String = "INSERT INTO Orcamento (Orcamento, CódigoCliente, DataOrcamento, Validade, ValorProduto, VlrDescProduto, TotalOrcamento, CódigoPagamento, GeradoPedido, Empresa, CódigoFuncionário, NomeCliente, CnpjCpf, RgIe) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Validade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.VlrDescProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.TotalOrcamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.CódigoPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.GeradoPedido.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NomeCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CpfCnpj.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.RgInscrição.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
                CNN.Close()

                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                Exit Sub
            End Try

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update Orcamento Set CódigoCliente = @1, DataOrcamento = @2, Validade = @3, ValorProduto = @4, VlrDescProduto = @5, TotalOrcamento = @6, CódigoPagamento = @7, GeradoPedido = @8, Empresa = @9, CódigoFuncionário = @10 Where Orcamento = " & Me.CodOrçamento.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Validade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.VlrDescProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.TotalOrcamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.CódigoPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.GeradoPedido.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.CódigoFuncionário.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                'MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            'Ação.Desbloquear_Controle(Me, False)
        End If

        My.Forms.OSorçamentoItens.OperationItens = INS
        My.Forms.OSorçamentoItens.ShowDialog()
        Me.VlrDescProduto.Focus()

    End Sub


    Private Sub UltimoOrçamento()

        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Orcamento) from Orcamento"
            .CommandType = CommandType.Text
        End With
        Try

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

        Me.CodOrçamento.Text = Ult + 1
        'fim inserir ultimo registro


    End Sub

    Private Sub btLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizar.Click
        RetornoProcura = ""
        My.Forms.OSorçamentoProcura.ShowDialog()
        Me.CodOrçamento.Text = RetornoProcura
        LocalizaDadosOrçamento()
        atGridProduto()
        atGridServico()
        Me.CodOrçamento.Focus()
        Operation = NONE
        Me.TotalOrcamento.Text = FormatCurrency((SomaTotalProdutos + SomaTotalServico), 2)
        RetornoProcura = ""
        Ação.Desbloquear_Controle(Me, False)

    End Sub

    Public Sub LocalizaDadosOrçamento()

        If Me.CodOrçamento.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Dim Sql As String = "SELECT Orcamento.Orcamento, Clientes.Nome, Clientes.CpfCgc, Clientes.Insc, Orcamento.Requisicao, Orcamento.CódigoCliente, Orcamento.Propriedade, Propriedades.NomePropriedade, Orcamento.DataOrcamento, Orcamento.ValorProduto, Orcamento.ValorServico, Orcamento.VlrDescProduto, Orcamento.DescontoServico, Orcamento.TotalOrcamento, Orcamento.CódigoPagamento, Orcamento.Inativo, Orcamento.ObsServico, Orcamento.DefeitoReclamado, Orcamento.PatrimonioCliente, Orcamento.Confirmado, Orcamento.ObsCab, Orcamento.ObsRod, Orcamento.Validade, Orcamento.CódigoFuncionário, Orcamento.Empresa FROM (Orcamento LEFT JOIN Propriedades ON Orcamento.Propriedade = Propriedades.Id) INNER JOIN Clientes ON Orcamento.CódigoCliente = Clientes.Codigo WHERE Orcamento.Orcamento = " & Me.CodOrçamento.Text & " AND Orcamento.Empresa = " & CodEmpresa

        Dim sql As String = "SELECT Orcamento.Orcamento, Orcamento.NomeCliente, Orcamento.CnpjCpf, Orcamento.NomeCliente, Orcamento.RgIe, Orcamento.Requisicao, Orcamento.CódigoCliente, Orcamento.Propriedade, Propriedades.NomePropriedade, Orcamento.DataOrcamento, Orcamento.ValorProduto, Orcamento.ValorServico, Orcamento.VlrDescProduto, Orcamento.DescontoServico, Orcamento.TotalOrcamento, Orcamento.CódigoPagamento, Orcamento.Inativo, Orcamento.ObsServico, Orcamento.DefeitoReclamado, Orcamento.PatrimonioCliente, Orcamento.GeradoPedido, Orcamento.PedidoGerado, Orcamento.ObsCab, Orcamento.ObsRod, Orcamento.Validade, Orcamento.CódigoFuncionário, Funcionários.Nome, Orcamento.Empresa, Orcamento.ObsServico FROM ((Orcamento LEFT JOIN Propriedades ON Orcamento.Propriedade = Propriedades.Id) LEFT JOIN Clientes ON Orcamento.CódigoCliente = Clientes.Codigo) LEFT JOIN Funcionários ON Orcamento.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Orcamento.Orcamento)=" & Me.CodOrçamento.Text & ") AND ((Orcamento.Empresa)=" & CodEmpresa & "));"

        Dim CMD As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, CNN)
        Dim Dr As OleDb.OleDbDataReader

        Dr = CMD.ExecuteReader
        Dr.Read()

        If Dr.HasRows = True Then
            'Me.CodOrçamento.Text = Dr.Item("Orcamento") & ""
            Me.DataOrçamento.Text = Dr.Item("DataOrcamento") & ""
            Me.Validade.Text = Dr.Item("Validade") & ""
            Me.CódigoCliente.Text = Dr.Item("CódigoCliente") & ""
            Me.CódigoCliente.Text = Me.CódigoCliente.Text.PadLeft(4, "0")
            Me.NomeCliente.Text = Dr.Item("NomeCliente") & ""
            Me.CpfCnpj.Text = Dr.Item("cnpjcpf") & ""
            Me.RgInscrição.Text = Dr.Item("rgie") & ""
            Me.CódigoPagamento.Text = Dr.Item("CódigoPagamento") & ""
            Me.CódigoFuncionário.Text = Dr.Item("CódigoFuncionário") & ""
            Me.FuncionarioDesc.Text = Dr.Item("Nome") & ""
            Me.ValorProduto.Text = FormatNumber(Nz(Dr.Item("ValorProduto"), 3), 2)
            Me.VlrDescProduto.Text = FormatNumber(Nz(Dr.Item("VlrDescProduto"), 3), 2)
            Me.TotalServico.Text = FormatNumber(Nz(Dr.Item("ValorServico"), 3), 2)
            Me.TotalOrcamento.Text = FormatNumber(Nz(Dr.Item("TotalOrcamento"), 3), 2)
            Me.GeradoPedido.Checked = Dr.Item("GeradoPedido") & ""
            Me.PedidoGerado.Text = Dr.Item("PedidoGerado") & ""
            Me.txtObservacao.Text = Dr.Item("ObsServico") & ""

            If NzZero(Me.PedidoGerado.Text) <> 0 Then
                Me.PedidoGerado.Visible = True
                Me.PedidoGeradoLabel.Visible = True
                Me.ConfImg.Visible = True
            Else
                Me.PedidoGerado.Visible = False
                Me.PedidoGeradoLabel.Visible = False
                Me.ConfImg.Visible = False
            End If
        End If
        Dr.Close()
        CNN.Close()

    End Sub

    Private Sub VlrDescProduto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles VlrDescProduto.Validated
        Me.VlrDescProduto.Text = FormatNumber(NzZero(Me.VlrDescProduto.Text), 2)
        Me.TotalOrcamento.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.TotalServico.Text)), 2)
    End Sub

    Private Sub btExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExportar.Click
        If Operation = UPD Then
            MessageBox.Show("Clique no botão SALVAR para prosseguir", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Me.CódigoCliente.Text = "0000" Then
            MessageBox.Show("Favor informar um cliente cadastrado para exportar o orçamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CódigoCliente.Focus()
            Exit Sub
        End If


        If CDate(DataDia) > CDate(Me.DataOrçamento.Text).AddDays(CInt(Me.Validade.Text)) Then
            MessageBox.Show("Este orçamento esta vencido, não pode ser exportado para pedido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.GeradoPedido.Checked = True Then
            MessageBox.Show("Para este orçamento já foi gerado um Pedido, não pode ser exportado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.CódigoCliente.Text = "0000" Then
            MessageBox.Show("O pedido sera criado sem o cliente, pois o orçamento esta com um cliente que não tem Cadastro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If MsgBox("Deseja transformar o Orçamento em Pedido", 36, "Validação de Dados") = 6 Then
            Dim UltimoREgistro As Integer = AchaUltimoPedido()

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "INSERT INTO Pedido ( PedidoSequencia, Requisicao, Empresa, CódigoCliente, Propriedade, DataPedido, DataFechamento, ValorProduto, VlrDescProduto,  TotalPedido, Inativo, ObsCab, ObsRod, CódigoFuncionário, PedidoTipo, TipoEntrega ) SELECT  " & UltimoREgistro & " AS Expr1, Orcamento.Requisicao, Orcamento.Empresa, Orcamento.CódigoCliente, Orcamento.Propriedade, Orcamento.DataOrcamento, Orcamento.DataOrcamento, Orcamento.ValorProduto, Orcamento.VlrDescProduto, Orcamento.TotalOrcamento, Orcamento.Inativo, Orcamento.ObsServico, Orcamento.ObsRod, Orcamento.CódigoFuncionário, 'VENDA', 'IMEDIATA' FROM Orcamento WHERE (((Orcamento.Orcamento)=" & Me.CodOrçamento.Text & "));"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                Exit Sub
            End Try


            Sql = "SELECT * from Pedido WHERE PedidoSequencia = " & UltimoREgistro & " and empresa = " & CodEmpresa
            cmd = New OleDb.OleDbCommand(Sql, CNN)
            Dim Dr As OleDb.OleDbDataReader

            Dr = cmd.ExecuteReader
            Dr.Read()

            Dim ultInterno As Integer
            If Dr.HasRows = True Then
                ultInterno = Dr.Item("PedidoInterno")
            End If
            Dr.Close()

            Sql = "INSERT INTO ItensPedido ( PedidoSequencia, CodigoProduto, Qtd, ValorUnitario, Desconto, ValorDesconto, TotalProduto, Grupo, PedidoInterno ) SELECT " & UltimoREgistro & " AS Expr1, OrcamentoItensProduto.CodigoProduto, OrcamentoItensProduto.Qtd, OrcamentoItensProduto.ValorUnitario, OrcamentoItensProduto.Desconto, OrcamentoItensProduto.ValorDesconto, [OrcamentoItensProduto.TotalProduto]+[OrcamentoItensProduto.ValorDesconto],OrcamentoItensProduto.Grupo, " & ultInterno & " FROM OrcamentoItensProduto WHERE (((OrcamentoItensProduto.Orcamento)=" & Me.CodOrçamento.Text & "));"
            Dim cmd1 As New OleDb.OleDbCommand(Sql, CNN)
            cmd1.ExecuteNonQuery()

            Sql = "INSERT INTO ItemServico ( PedidoSequencia, Codigoservico, Funcionario, qtd, Valorunitario, ValorDesconto, Totalservico, Comissao, ValorComissao ) SELECT " & UltimoREgistro & ", OrcamentoItemServico.Codigoservico, OrcamentoItemServico.Funcionario, OrcamentoItemServico.qtd, OrcamentoItemServico.Valorunitario, OrcamentoItemServico.ValorDesconto, OrcamentoItemServico.Totalservico, OrcamentoItemServico.Comissao, OrcamentoItemServico.ValorComissao FROM OrcamentoItemServico WHERE (((OrcamentoItemServico.CodigoOrcamento)=" & Me.CodOrçamento.Text & "));"
            Dim cmd2 As New OleDb.OleDbCommand(Sql, CNN)
            cmd2.ExecuteNonQuery()



            Sql = "Update Orcamento Set GeradoPedido = True, PedidoGerado = " & UltimoREgistro & " Where Orcamento = " & Me.CodOrçamento.Text
            Dim cmd3 As New OleDb.OleDbCommand(Sql, CNN)
            cmd3.ExecuteNonQuery()


            MsgBox("Orçamento transformado com sucesso no Pedido Nrº " & UltimoREgistro, 64, "Validação de Dados")
            CNN.Close()
            'LocalizaDadosOrçamento()

            Me.PedidoGerado.Visible = True
            Me.PedidoGeradoLabel.Visible = True
            Me.ConfImg.Visible = True
            Me.GeradoPedido.Checked = True
        

        Ação.Desbloquear_Controle(Me, False)

        End If

    End Sub

    Public Function AchaUltimoPedido()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT Max(Pedido.PedidoSequencia) AS MáxDePedidoSequencia FROM Pedido"

            .CommandType = CommandType.Text
        End With
        Try

            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("MáxDePedidoSequencia")) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item("MáxDePedidoSequencia")
                End If
            End While
            DataReader.Close()
            CNN.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Return 0
                Exit Function
            End If
        End Try

        Return Ult + 1

    End Function


    Private Sub CódigoFuncionário_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CódigoFuncionário.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Operation = UPD Or Operation = INS Then
                My.Forms.PedidoVendaFindVendedores.ShowDialog()
                Me.CódigoFuncionário.Focus()
            End If
        End If
    End Sub

    Private Sub CódigoFuncionário_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CódigoFuncionário.Leave
        If Me.CódigoFuncionário.Text = "" Then
            Me.FuncionarioDesc.Text = ""
        End If
    End Sub

    Private Sub CódigoFuncionário_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CódigoFuncionário.Validated
        If String.CompareOrdinal(Me.CódigoFuncionário.Text, Me.CódigoFuncionário.TextoAntigo) Then
            AchaFuncionario()
        End If
    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click

        'If Me.GeradoPedido.Checked = True Then
        '    MessageBox.Show("Para este orçamento já foi gerado um Pedido, não pode Imprimir.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'Area destinada para as validacoes
        If Me.ValorProduto.Text = "" Then FormatCurrency(0, 2)
        If Me.VlrDescProduto.Text = "" Then FormatCurrency(0, 2)
        If Me.TotalOrcamento.Text = "" Then FormatCurrency(0, 2)


        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        If Operation = UPD Then

            Dim Sql As String = "Update Orcamento Set CódigoCliente = @1, DataOrcamento = @2, Validade = @3, ValorProduto = @4, VlrDescProduto = @5, TotalOrcamento = @6, CódigoPagamento = @7, GeradoPedido = @8, Empresa = @9, CódigoFuncionário = @10, NomeCliente = @11, CnpjCpf = @12, RgIe = @13, ValorServico=@14 Where Orcamento = " & Me.CodOrçamento.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Validade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.VlrDescProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.TotalOrcamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.CódigoPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.GeradoPedido.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.NomeCliente.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CpfCnpj.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.RgInscrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.TotalServico.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            'Ação.Desbloquear_Controle(Me, False)
        End If






        If MessageBox.Show("Deseja imprimir o Orçamento agora", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim rpt As New OsOrcamentoRel
            ViewReport.VerRelat.Document = rpt.Document
            rpt.Run()
            ViewReport.ShowDialog()
        End If
    End Sub

    Private Sub btFindVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindVendedor.Click
        If Operation = UPD Or Operation = INS Then
            My.Forms.PedidoVendaFindVendedores.ShowDialog()
            Me.CódigoFuncionário.Focus()
            AchaFuncionario()
        End If
    End Sub

    Private Sub btClienteFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClienteFind.Click
        If Operation = INS Or Operation = UPD Then
            My.Forms.ClientesProcura.ShowDialog()
            Me.CódigoCliente.Focus()
        End If
    End Sub

    Private Sub btEditarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditarCliente.Click

        Me.NomeCliente.TabStop = True
        Me.CpfCnpj.TabStop = True
        Me.RgInscrição.TabStop = True

        Me.CódigoCliente.Text = "0000"
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CpfCnpj.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.RgInscrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeCliente.Focus()

    End Sub


    Private Sub ItemServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemServico.Click
        If Operation = NONE Then
            MessageBox.Show("Clique no botão editar para inserir um item", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Me.CódigoCliente.Text = "" Then
            MsgBox("O Código do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CódigoCliente.Focus()
            Exit Sub
        ElseIf Me.DataOrçamento.Text = "" Then
            MsgBox("A data do orçamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataOrçamento.Focus()
            Exit Sub
        ElseIf Me.Validade.Text = "" Then
            MsgBox("A Validade do Orçamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Validade.Focus()
            Exit Sub
        End If

        If Me.ValorProduto.Text = "" Then Me.ValorProduto.Text = FormatCurrency(0, 2)
        If Me.TotalServico.Text = "" Then Me.TotalServico.Text = FormatCurrency(0, 2)
        If Me.VlrDescProduto.Text = "" Then Me.VlrDescProduto.Text = FormatCurrency(0, 2)
        If Me.TotalOrcamento.Text = "" Then Me.TotalOrcamento.Text = FormatCurrency(0, 2)


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            UltimoOrçamento()

            Dim Sql As String = "INSERT INTO Orcamento (Orcamento, CódigoCliente, DataOrcamento, Validade, ValorProduto, VlrDescProduto, TotalOrcamento, CódigoPagamento, GeradoPedido, Empresa, CódigoFuncionário, NomeCliente, CnpjCpf, RgIe) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Validade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.VlrDescProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.TotalOrcamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.CódigoPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.GeradoPedido.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NomeCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CpfCnpj.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.RgInscrição.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
                CNN.Close()

                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                Exit Sub
            End Try

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update Orcamento Set CódigoCliente = @1, DataOrcamento = @2, Validade = @3, ValorProduto = @4, VlrDescProduto = @5, TotalOrcamento = @6, CódigoPagamento = @7, GeradoPedido = @8, Empresa = @9, CódigoFuncionário = @10 Where Orcamento = " & Me.CodOrçamento.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Validade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.VlrDescProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.TotalOrcamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.CódigoPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.GeradoPedido.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.CódigoFuncionário.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                'MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            'Ação.Desbloquear_Controle(Me, False)
        End If


        Me.superTabControl1.SelectedTab = Me.SuperTabItemServico
        My.Forms.OSorcamentoItemServicoAdd.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DgvItem_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellClick
        IdLinha = Me.DgvItem.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        If Operation = NONE Then
            MessageBox.Show("Clique no botão Editar Orçamento para prosseguir", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If IdLinha = 0 Then
            MessageBox.Show("Não foi selecionado nenhuma linha, clique primeiro em uma linha da grade para depois editar ou excluir um item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.OSorcamentoItemServicoAdd.OperationItens = UPD
        My.Forms.OSorcamentoItemServicoAdd.IdLinha = IdLinha
        OSorcamentoItemServicoAdd.ShowDialog()
    End Sub

    Private Sub DgvItem_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgvItem.SelectionChanged
        Try
            IdLinha = Me.DgvItem.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try


    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

        If Operation = NONE Then
            MessageBox.Show("Clique no botão Editar Orçamento para prosseguir", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Delete * from OrcamentoItemServico where Id = " & IdLinha
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        DR.Close()
        CNN.Close()

        OperationItens = INS
        Me.atGridServico()
        Me.TotalOrcamento.Text = FormatCurrency((SomaTotalProdutos + SomaTotalServico), 2)
    End Sub


    Private Sub dgvItemP_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvItemP.SelectionChanged
        Try

            IdLinha = Me.dgvItemP.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try

    End Sub

    Private Sub dgvItemP_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemP.CellClick
        IdLinha = Me.dgvItemP.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click

        If Operation = NONE Then
            MessageBox.Show("Clique no botão Editar Orçamento para prosseguir", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Delete * from OrcamentoItensProduto where Id = " & IdLinha
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        DR.Close()
        CNN.Close()

        OperationItens = INS
        Me.atGridProduto()
        Me.TotalOrcamento.Text = FormatCurrency((SomaTotalProdutos + SomaTotalServico), 2)

    End Sub
    ' Função que pesquisa na coluna 0 por um id e devolve a posição na lista
    Private Function getDataGridViewIndex(ByVal id As Integer) As Integer
        For Each row As DataGridViewRow In Me.dgvItemP.Rows
            If Not row.IsNewRow Then
                If row.Cells(0).Value = id Then
                    Return row.Index
                End If
            End If
        Next

        Return 0

    End Function

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        If Operation = NONE Then
            MessageBox.Show("Clique no botão Editar Orçamento para prosseguir", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If
        If IdLinha = 0 Then
            MessageBox.Show("Não foi selecionado nenhuma linha, clique primeiro em uma linha da grade para depois editar ou excluir um item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        OSorçamentoItens.OperationItens = UPD
        OSorçamentoItens.IdLinha = IdLinha
        OSorçamentoItens.ShowDialog()
    End Sub

    Private Sub SuperTabItemProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperTabItemProduto.Click
        IdLinha = 0
        Me.dgvItemP.Focus()
    End Sub

    Private Sub SuperTabItemServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperTabItemServico.Click
        IdLinha = 0
    End Sub

    Private Sub DgvItem_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        DgvItem_CellClick(sender, e)
        ToolStripMenuItem2_Click(sender, e)
    End Sub

    Private Sub dgvItemP_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemP.CellDoubleClick
        dgvItemP_CellClick(sender, e)
        ToolStripMenuItem1_Click_1(sender, e)
    End Sub

    Private Sub RgInscrição_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RgInscrição.LostFocus
        Me.btItens.Focus()
    End Sub

  
    Private Sub NomeCliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NomeCliente.Validated
        If Me.NomeCliente.Text = "" Then
            Me.NomeCliente.Text = "CONSUMIDOR"
        End If

    End Sub
    Private Sub VlrDescProduto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VlrDescProduto.Enter
        Me.TotalOrcamento.Text = FormatCurrency((SomaTotalProdutos + SomaTotalServico), 2)
    End Sub
End Class