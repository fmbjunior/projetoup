Imports Microsoft.Win32
Public Class CompraCtrPedido


    Public EditaItens As Boolean = False
    Dim Ação As New TrfGerais()
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim SalvoDoc As Boolean = False
    Dim ExistDoc As Boolean = False
    Public Aprovado As Boolean = False
    Dim CNN As OleDb.OleDbConnection
    Public Editou As Boolean = False



    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        If Editou = True Then
            If MsgBox("A ordem foi editada, Deseja processeguir mesmo assim?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação de Dados") = MsgBoxResult.Yes Then
                Me.NotaFiscal.Enabled = True
                Me.NotaFiscal.Focus()
                Me.Close()
                Me.Dispose()
            Else
                Exit Sub
            End If
            Me.NotaFiscal.Enabled = True
            Me.NotaFiscal.Focus()
            Me.Close()
            Me.Dispose()
        Else
            Me.Close()
            Me.Dispose()

        End If



    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        AdicionaNovo()
    End Sub

    Public Sub AdicionaNovo()
        Ação.LimpaTextBox(Me)
        Me.Confirmado.Checked = False
        Ação.Desbloquear_Controle(Me, True)
        MyLista.Items.Clear()
        Me.Id.Enabled = False
        Me.Id.Text = "0000"
        Me.Usuario.Text = UserAtivo
        SalvoDoc = False
        Me.ConfImg.Visible = False
        Operation = INS
        Me.ConfirmarBT.Enabled = False

        'define dados da empresa padrão
        Me.Empresa.Text = CodEmpresa
        Me.Empresa.Enabled = False
        Me.EmpresaDesc.Enabled = False
        Dim AchaEmpresa As New TrfGerais
        AchaEmpresa.Descrição_ItenRegistro(Me.Empresa, Me.EmpresaDesc, "Empresa", "CódigoEmpresa", Me.Empresa.Text, "RazãoSocial", TrfGerais.TipoDados.Numérico, False)
        'fim

        Me.Solicitacao.Focus()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click

        'If Me.Id.Text = "" Or Me.Id.Text = "0000" Then
        '    MessageBox.Show("Não foi encontrado dados para salvar; Verifioque.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        If Me.LancaItens.Checked = True Then
            If Me.MyLista.Items.Count = 0 Then
                MsgBox("Você marcou [Lançar Itens] e não adicionou, Antes de salvar você prescisa adicionar Itens na Ordem de Compra." & Chr(13) & "Caso tenha alguma dúvida contate o Administrador", 48, "Validação de Dados")
                Exit Sub
            End If
        End If

        'If Me.Fornecedor.Text = "" Then
        '    MessageBox.Show("Não foi encontrado dados para salvar; Verifioque.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        VerificarDuplicidadeDocumento()
        If ExistDoc = True Then
            If MsgBox("Existe um documento com este Nº: " & Me.Documento.Text & " lançado para este fornecedor, deseja laçar este documento Duplicado ?", 36, "Validação de Dados") = 6 Then
            Else
                Ação.LimpaTextBox(Me)
                Ação.Desbloquear_Controle(Me, False)
                Exit Sub
            End If
        End If
        'Area destinada para as validacoes
        If Me.Fornecedor.Text = "" Then
            MsgBox("O Fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Fornecedor.Focus()
            Exit Sub
        ElseIf Me.Documento.Text = "" Then
            MsgBox("O documento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Documento.Focus()
            Exit Sub

        ElseIf Me.DataPedido.Text = "" Then
            MsgBox("A Data do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataPedido.Focus()
            Exit Sub

        ElseIf Me.Destino.Text = "" Then
            MsgBox("O destino não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub

        ElseIf Me.Solicitante.Text = "" Then
            MsgBox("O Solicitante não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub

        ElseIf Me.ValorPedido.Text = "" Then
            MsgBox("O Valor do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorPedido.Focus()
            Exit Sub
        End If

        If Me.Solicitacao.Text = "" Then
            MessageBox.Show("O usuário deve informar o código da solicitação, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.PlanoContasFornecedor.Text = "" Then
            MsgBox("O fornecedor selecionado não esta cadastrado no plano de contas.", 64, "Validação de Dados")
            Me.Fornecedor.Focus()
            Exit Sub
        End If

        If Me.TipoPgto.Text = "" Then
            MessageBox.Show("O usuário deve informar 1 para Pagamento a Vista ou 2 para Pagamento a Prazo.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            If Me.TipoPgto.Text = "2" Then
                If Me.CondPgto.Text = "" Then
                    MessageBox.Show("O usuário deve descrever a condição de pagamento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If Me.TipoPgto.Text = "1" Then Me.CondPgto.Text = "A VISTA"
        End If


        If Me.Usuario.Text = "" Then Me.Usuario.Text = UserAtivo
        If Me.DataLançamento.Text = "" Then Me.DataLançamento.Text = DataDia

        'Fim da Area destinada para as validacoes

        If Operation = INS Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            UltimoReg()
            Dim Sql As String = "INSERT INTO CompraCtrlPedido (Id, Fornecedor, Documento, DataPedido, DataLançamento, Destino, Solicitante, ValorPedido, Empresa, Confirmado, FornecedorDesc, NotaFiscal, Usuario, Solicitacao, TipoPgto, CondPgto, LancaItens, EnviadoFinanceiro, Senha, PrazoEntrega, Estoque, Inativo) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Fornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLançamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Destino.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Solicitante.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.Empresa.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", False))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.FornecedorDesc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.Solicitacao.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.TipoPgto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.CondPgto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Me.LancaItens.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Me.EnviadoFinanceiro.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Senha.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.PrazoEntrega.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Me.Estoque.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Me.Inativo.Checked))

            Try
                cmd.ExecuteNonQuery()
                Ação.CriaLog(UserAtivo, "CompraCtrPedido", "Add: ID " & Me.Id.Text & " - Doc Fornecedor: " & Me.Documento.Text, CaminhoLog, DataDia)
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Editou = False
                CNN.Close()
                SalvoDoc = True
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                Ação.LimpaTextBox(Me)
                Me.Confirmado.Checked = False
                Ação.Desbloquear_Controle(Me, True)
                Me.Id.Enabled = False
                Me.Id.Text = "0000"
                Operation = INS
                CNN.Close()
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update CompraCtrlPedido set Fornecedor = @2, Documento = @3, DataPedido = @4, DataLançamento = @5, Destino = @6, Solicitante = @7, ValorPedido = @8, Empresa = @9, Confirmado = @10, FornecedorDesc = @11, NotaFiscal = @12, Usuario = @13, Solicitacao = @14, TipoPgto = @15, CondPgto = @16, LancaItens = @17, EnviadoFinanceiro = @18, Senha = @19, PrazoEntrega = @20, Estoque = @21, Inativo = @22 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Fornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLançamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Destino.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Solicitante.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorPedido.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.Empresa.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.FornecedorDesc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.Solicitacao.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.TipoPgto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.CondPgto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Me.LancaItens.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Me.EnviadoFinanceiro.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Senha.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.PrazoEntrega.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Me.Estoque.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Me.Inativo.Checked))


            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                Ação.CriaLog(UserAtivo, "CompraCtrPedido", "Edd: ID " & Me.Id.Text & " - Doc Fornecedor: " & Me.Documento.Text, CaminhoLog, DataDia)
                AtPagarNF()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Editou = False
                SalvoDoc = True
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                CNN.Close()
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)

        End If
    End Sub

    Public Sub SalvarRegistro()


        ''VerificarDuplicidadeDocumento()
        'If ExistDoc = True Then
        '    If MsgBox("Existe um documento com este Nº: " & Me.Documento.Text & " lançado para este fornecedor, deseja laçar este documento Duplicado ?", 36, "Validação de Dados") = 6 Then
        '    Else
        '        Ação.LimpaTextBox(Me)
        '        Ação.Desbloquear_Controle(Me, False)
        '        Exit Sub
        '    End If
        'End If
        'Area destinada para as validacoes


        If Me.DataPedido.Text = "" Then
            MsgBox("A Data do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataPedido.Focus()
            Exit Sub

        ElseIf Me.Destino.Text = "" Then
            MsgBox("O destino não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub

        ElseIf Me.Solicitante.Text = "" Then
            MsgBox("O Solicitante não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub

        End If

        If Me.Solicitacao.Text = "" Then
            MessageBox.Show("O usuário deve informar o código da solicitação, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'If Me.TipoPgto.Text = "" Then
        '    MessageBox.Show("O usuário deve informar 1 para Pagamento a Vista ou 2 para Pagamento a Prazo.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'Else
        '    If Me.TipoPgto.Text = "2" Then
        '        If Me.CondPgto.Text = "" Then
        '            MessageBox.Show("O usuário deve descrever a condição de pagamento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Exit Sub
        '        End If
        '    End If
        '    If Me.TipoPgto.Text = "1" Then Me.CondPgto.Text = "A VISTA"
        'End If


        If Me.Usuario.Text = "" Then Me.Usuario.Text = UserAtivo
        If Me.DataLançamento.Text = "" Then Me.DataLançamento.Text = DataDia

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        UltimoReg()
        Dim Sql As String = "INSERT INTO CompraCtrlPedido (Id, Fornecedor, Documento, DataPedido, DataLançamento, Destino, Solicitante, ValorPedido, Empresa, Confirmado, FornecedorDesc, NotaFiscal, Usuario, Solicitacao, TipoPgto, CondPgto, LancaItens, EnviadoFinanceiro) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Fornecedor.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataPedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLançamento.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Destino.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Solicitante.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.ValorPedido.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.Empresa.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", False))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.FornecedorDesc.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NotaFiscal.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Usuario.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.Solicitacao.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.TipoPgto.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.CondPgto.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Me.LancaItens.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Me.EnviadoFinanceiro.Checked))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            Operation = UPD
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
            Ação.LimpaTextBox(Me)
            Me.Confirmado.Checked = False
            Ação.Desbloquear_Controle(Me, True)
            Me.Id.Enabled = False
            Me.Id.Text = "0000"
            Operation = INS
            CNN.Close()
        End Try
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub AtPagarNF()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "UPDATE Pagar INNER JOIN CompraCtrlPedido ON Pagar.IdCompraCtrlPedido = CompraCtrlPedido.Id SET Pagar.NotaFiscal = '" & Me.NotaFiscal.Text & "' WHERE Pagar.IdCompraCtrlPedido = " & Me.Id.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
        Catch x As Exception
            MsgBox(x.Message)
            CNN.Close()
            Exit Sub
        End Try
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub CompraCtrPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F6 Then
            Dim HH As DateTime = Now
            Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança para exclusão", "Validação de Dados", 0)

            If VerificaCodigoSegurança(CodSegurança) = False Then
                MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
                Exit Sub
            End If

            Ação.Desbloquear_Controle(Me, True)
            Me.Id.Enabled = False
            Me.NotaFiscal.Focus()

        End If
    End Sub
    Public Sub SomaCusto(ByVal sconta As String)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT CentroCustoLancamento.G3, Sum(CentroCustoLancamento.VlrDebito) AS SomaDeVlrDebito, CentroCustoApropriacao.ValorMaximo, CentroCustoLancamento.Empresa FROM CentroCustoLancamento INNER JOIN CentroCustoApropriacao ON CentroCustoLancamento.G3 = CentroCustoApropriacao.ContaG3 GROUP BY CentroCustoLancamento.G3, CentroCustoApropriacao.ValorMaximo, CentroCustoLancamento.Empresa HAVING(((CentroCustoLancamento.G3) = '" & sconta & "') And ((CentroCustoLancamento.Empresa) = " & CodEmpresa & ")) ORDER BY CentroCustoLancamento.G3;"
            .CommandType = CommandType.Text
        End With
        Try

            DR = Cmd.ExecuteReader

            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Me.VlrGasto.Text = FormatCurrency(DR.Item("SomaDeVlrDebito"), 2)
                    Me.valorApropriado.Text = FormatCurrency(DR.Item("Valormaximo"), 2)

                Else
                    Me.VlrGasto.Text = "0,00"
                    Me.valorApropriado.Text = "0,00"
                End If
            End While
            DR.Close()
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNN.Close()
                Exit Sub
            End If
        End Try

    End Sub
    
    Private Sub CompraCtrPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Degrade()

        Ação.Desbloquear_Controle(Me, False)
        If Me.LancaItens.Checked = True Then
            Me.Size = New Size(800, 650)
        Else
            Me.Size = New Size(800, 400)

        End If
    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from CompraCtrlPedido"
            .CommandType = CommandType.Text
        End With
        Try

            DR = Cmd.ExecuteReader

            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DR.Item(0)
                End If
            End While
            DR.Close()
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNN.Close()
                Exit Sub
            End If
        End Try

        Me.Id.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub

    Private Sub DataLançamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLançamento.Enter
        If Me.DataLançamento.Text = "" Then Me.DataLançamento.Text = DataDia
    End Sub

    Private Sub Fornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fornecedor.KeyDown
        'Desativado pelo Beto por motivos informado pelo Douglas

        'If e.KeyCode = Keys.F5 Then
        '    If Me.Empresa.Text = "" Then
        '        MessageBox.Show("Não foi informado a empresa para procura", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If
        '    RetornoProcura = String.Empty
        '    My.Forms.TelaProcuraForCtrlPedido.ShowDialog()
        '    Me.Fornecedor.Text = RetornoProcura
        '    Me.Fornecedor.Focus()
        'End If
    End Sub

    Private Sub Fornecedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fornecedor.Validated

        If ConnectionState.Closed Then
            Exit Sub
        End If

        If Me.Fornecedor.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Fornecedor where CódigoFornecedor = " & Me.Fornecedor.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.FornecedorDesc.Text = DR.Item("RazãoSocial") & ""
            Me.PlanoContasFornecedor.Text = DR.Item("CodPlanoConta") & ""
        Else
            MsgBox("Verifique os dados do fornecedor, ou fornecedor não existe no cadastro.", 64, "Validação de Dados")
            CNN.Close()
            Exit Sub
        End If
        DR.Close()
        CNN.Close()
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.Id.Text = "" Then
            MsgBox("Não existe Controle de Compra para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD

        If Me.Confirmado.Checked = True Then
            MsgBox("Este Pedido já foi confirmado.", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            If Me.NotaFiscal.Text = "" Then Me.NotaFiscal.Enabled = True
        Else
            Ação.Desbloquear_Controle(Me, True)
            Me.Empresa.Enabled = False
            Me.EmpresaDesc.Enabled = False
            If Me.EnviadoFinanceiro.Checked = True Then
                Me.ValorPedido.Enabled = False
                Me.btItens.Enabled = False
            Else
                Me.ValorPedido.Enabled = True
                Me.btItens.Enabled = True
            End If
            Editou = True
        End If

        Me.Solicitacao.Focus()

    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        Ação.Desbloquear_Controle(Me, False)
        MultiEmpresa = True
        My.Forms.TelaProcuraCtrlPedido.ShowDialog()

        If Me.Id.Text <> "" Then
            LocalizaDados()
            EncheLista()
            Me.Fornecedor.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Dim Sql As String = "SELECT CompraCtrlPedido.Id, CompraCtrlPedido.Fornecedor, CompraCtrlPedido.FornecedorDesc, Fornecedor.CodPlanoConta, CompraCtrlPedido.TipoPedido, CompraCtrlPedido.NotaFiscal, CompraCtrlPedido.Documento, CompraCtrlPedido.DataPedido, CompraCtrlPedido.Destino, CompraCtrlPedido.DataLançamento, CompraCtrlPedido.Solicitante, CompraCtrlPedido.ValorPedido, CompraCtrlPedido.Confirmado, CompraCtrlPedido.Inativo, CompraCtrlPedido.Empresa, CompraCtrlPedido.Usuario FROM CompraCtrlPedido INNER JOIN Fornecedor ON CompraCtrlPedido.Fornecedor = Fornecedor.CódigoFornecedor WHERE (((CompraCtrlPedido.Id)=" & Me.Id.Text & "));"
        'Dim Sql As String = "SELECT CompraCtrlPedido.Id, CompraCtrlPedido.Solicitacao,CompraCtrlPedido.Fornecedor, CompraCtrlPedido.FornecedorDesc, Fornecedor.CodPlanoConta, CompraCtrlPedido.TipoPedido, CompraCtrlPedido.NotaFiscal, CompraCtrlPedido.Documento, CompraCtrlPedido.DataPedido, CompraCtrlPedido.Destino, CompraCtrlPedido.DataLançamento, CompraCtrlPedido.Solicitante, CompraCtrlPedido.ValorPedido, CompraCtrlPedido.Confirmado, CompraCtrlPedido.Inativo, CompraCtrlPedido.Empresa, CompraCtrlPedido.Usuario, CompraCtrlPedido.Senha, CompraCtrlPedido.TipoPgto, CompraCtrlPedido.CondPgto, CompraCtrlPedido.LancaItens, CompraCtrlPedido.Estoque, CompraCtrlPedido.EnviadoFinanceiro, Empresa.RazãoSocial AS EmpresaDesc FROM (CompraCtrlPedido LEFT JOIN Fornecedor ON CompraCtrlPedido.Fornecedor = Fornecedor.CódigoFornecedor) LEFT JOIN Empresa ON CompraCtrlPedido.Empresa = Empresa.CódigoEmpresa WHERE (((CompraCtrlPedido.Id)=" & Me.Id.Text & "));"
        Dim Sql As String = "SELECT CompraCtrlPedido.Id, CompraCtrlPedido.Solicitacao, CompraCtrlPedido.Fornecedor, CompraCtrlPedido.FornecedorDesc, Fornecedor.CodPlanoConta, CompraCtrlPedido.TipoPedido, CompraCtrlPedido.NotaFiscal, CompraCtrlPedido.Documento, CompraCtrlPedido.DataPedido, CompraCtrlPedido.Destino, CompraCtrlPedido.DataLançamento, CompraCtrlPedido.Solicitante, CompraCtrlPedido.ValorPedido, CompraCtrlPedido.Confirmado, CompraCtrlPedido.Inativo, CompraCtrlPedido.Empresa, CompraCtrlPedido.Usuario, CompraCtrlPedido.Senha, CompraCtrlPedido.TipoPgto, CompraCtrlPedido.CondPgto, CompraCtrlPedido.LancaItens, CompraCtrlPedido.Estoque, CompraCtrlPedido.EnviadoFinanceiro, Empresa.RazãoSocial AS EmpresaDesc, Solicitacao.CentroCusto, CCG3.DescG3 FROM (((CompraCtrlPedido LEFT JOIN Fornecedor ON CompraCtrlPedido.Fornecedor = Fornecedor.CódigoFornecedor) LEFT JOIN Empresa ON CompraCtrlPedido.Empresa = Empresa.CódigoEmpresa) INNER JOIN Solicitacao ON CompraCtrlPedido.Solicitacao = Solicitacao.CodigoSolicitacao) INNER JOIN CCG3 ON Solicitacao.CentroCusto = CCG3.ContaG3 WHERE (((CompraCtrlPedido.Id)=" & Me.Id.Text & ") And ((CompraCtrlPedido.Inativo)=False));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Id.Text = DR.Item("id") & ""
            Me.Fornecedor.Text = DR.Item("Fornecedor") & ""
            Me.FornecedorDesc.Text = DR.Item("FornecedorDesc") & ""
            Me.Documento.Text = DR.Item("Documento") & ""
            Me.DataPedido.Text = DR.Item("DataPedido") & ""
            Me.DataLançamento.Text = DR.Item("DataLançamento") & ""
            Me.Solicitante.Text = DR.Item("Solicitante") & ""
            Me.Destino.Text = DR.Item("Destino") & ""
            Me.ValorPedido.Text = FormatCurrency(Nz(DR.Item("ValorPedido"), 3), 2)
            Me.Confirmado.Checked = DR.Item("Confirmado")
            Me.NotaFiscal.Text = DR.Item("NotaFiscal") & ""
            Me.PlanoContasFornecedor.Text = DR.Item("CodPlanoConta") & ""
            Me.Usuario.Text = DR.Item("Usuario") & ""
            Me.Solicitacao.Text = DR.Item("Solicitacao") & ""
            Me.Empresa.Text = DR.Item("Empresa") & ""
            Me.EmpresaDesc.Text = DR.Item("EmpresaDesc") & ""
            Me.LancaItens.Checked = DR.Item("LancaItens")
            Me.Estoque.Checked = DR.Item("Estoque")
            Me.TipoPgto.Text = DR.Item("TipoPgto") & ""
            Me.CondPgto.Text = DR.Item("CondPgto") & ""
            Me.EnviadoFinanceiro.Checked = DR.Item("EnviadoFinanceiro")
            Me.Senha.Text = DR.Item("SEnha") & ""
            Me.Inativo.Checked = DR.Item("Inativo")
            Me.CentroCusto.Text = DR.Item("CentroCusto") & ""
            Me.CentroCustoDesc.Text = DR.Item("DescG3") & ""

            If Me.LancaItens.Checked = True Then
                Me.Size = New Size(800, 650)
                EncheLista()
            Else
                Me.Size = New Size(800, 400)
                EncheLista()
            End If

            If Me.EnviadoFinanceiro.Checked = True Then
                Me.ConfirmarBT.Enabled = True
            Else
                Me.ConfirmarBT.Enabled = False
            End If
            SomaCusto(Me.CentroCusto.Text)
        Else
            MsgBox("Controle de Compra não Identificado,pode ser que a ordem tenha sindo cancelada favor verificar.", 64, "Validação de Dados")
            Me.Id.Clear()
            Ação.LimpaTextBox(Me)
            Operation = INS

            Me.Fornecedor.Focus()
            Me.Id.Text = "0000"
            Me.Id.Enabled = False
            CNN.Close()
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            Me.ConfImg.Visible = True
        Else
            Me.ConfImg.Visible = False
        End If

        Operation = UPD
        DR.Close()
    End Sub

    Public Sub VerificarDuplicidadeDocumento()

        If Operation = INS Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "SELECT CompraCtrlPedido.Id, CompraCtrlPedido.Fornecedor, CompraCtrlPedido.FornecedorDesc, Fornecedor.CodPlanoConta, CompraCtrlPedido.TipoPedido, CompraCtrlPedido.NotaFiscal, CompraCtrlPedido.Documento, CompraCtrlPedido.DataPedido, CompraCtrlPedido.Destino, CompraCtrlPedido.DataLançamento, CompraCtrlPedido.Solicitante, CompraCtrlPedido.ValorPedido, CompraCtrlPedido.Confirmado, CompraCtrlPedido.Inativo, CompraCtrlPedido.Empresa FROM CompraCtrlPedido INNER JOIN Fornecedor ON CompraCtrlPedido.Fornecedor = Fornecedor.CódigoFornecedor WHERE CompraCtrlPedido.Documento = '" & Me.Documento.Text & "' AND CompraCtrlPedido.Empresa = " & CodEmpresa & " and CompraCtrlPedido.Fornecedor = " & Me.Fornecedor.Text
            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim DR As OleDb.OleDbDataReader

            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                ExistDoc = True
            Else
                ExistDoc = False
            End If
            DR.Close()
        End If
    End Sub

    Private Sub PedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TipoPedido.Text = "PED"
    End Sub

    Private Sub NotaFiscalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TipoPedido.Text = "NF"
    End Sub

    Private Sub TipoPedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TipoPedido.Enter
        Me.TipoPedido.Text = "PED"
    End Sub

    Private Sub ConfirmarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarBT.Click
        'Area destinada para as validacoes
        'If F6 = False Then
        '    MessageBox.Show("O usuário não tem permissão para esta operação." & Chr(13) & "Ative F6 nas Permissões do item Ordem de Compra." & Chr(13) & "Consulte o Administrador.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        If Me.Senha.Text = "" Then
            MessageBox.Show("Esta ordem de compra ainda não foi autorizada para o Financeiro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.EnviadoFinanceiro.Checked = False Then
            MessageBox.Show("Esta ordem de Compra ainda não foi enviada ao financeiro, aguarde a liberação do setor de Compra.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.Fornecedor.Text = "" Then
            MsgBox("O Fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Fornecedor.Focus()
            Exit Sub
        ElseIf Me.Documento.Text = "" Then
            MsgBox("O documento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Documento.Focus()
            Exit Sub

        ElseIf Me.DataPedido.Text = "" Then
            MsgBox("A Data do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataPedido.Focus()
            Exit Sub

        ElseIf Me.Destino.Text = "" Then
            MsgBox("O destino não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub

        ElseIf Me.Solicitante.Text = "" Then
            MsgBox("O Solicitante não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub

        ElseIf Me.ValorPedido.Text = "" Then
            MsgBox("O Valor do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorPedido.Focus()
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            MsgBox("Este pedido já foi confirmado, selecione outro.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.LancaItens.Checked = True Then
            If CDbl(Me.ValorPedido.Text) <> CDbl(Me.TTotal.Text) Then
                MessageBox.Show("O valor da ordem de compra esta diferente do total dos itens.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        If Me.Empresa.Text = "" Then
            MessageBox.Show("O usuário deve informar o código da empresa para confirmar a ordem de compra.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.Solicitacao.Text = "" Then
            MessageBox.Show("O usuário deve informar o Número da solicitação para salvar a ordem de compra.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.DataLançamento.Text = "" Then Me.DataLançamento.Text = DataDia

        'Fim da Area destinada para as validacoes

        If SalvoDoc = False Then
            MsgBox("Este documento ainda não foi salvo para poder confirmar.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.Id.Text = "0000" Or Me.Id.Text = "" Then
            MessageBox.Show("O documento não foi salvo! Verifique...", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Operation = UPD Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update CompraCtrlPedido set Fornecedor = @2, Documento = @3, DataPedido = @4, DataLançamento = @5, Destino = @6, Solicitante = @7, ValorPedido = @8, Empresa = @9, Confirmado = @10, FornecedorDesc = @11, Estoque = @12 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Fornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLançamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Destino.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Solicitante.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.Empresa.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", True))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.FornecedorDesc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Me.Estoque.Checked))

            Try
                cmd.ExecuteNonQuery()
                Ação.CriaLog(UserAtivo, "CompraCtrPedido", "Confirmou: ID " & Me.Id.Text & " - Doc Fornecedor: " & Me.Documento.Text, CaminhoLog, DataDia)
                Me.Confirmado.Checked = True
                Me.ConfImg.Visible = True



                'If Me.Estoque.Checked = False Then
                '    My.Forms.CentroCustoLancamento.OrigemLanc = "CompraCtrPedido"
                '    My.Forms.CentroCustoLancamento.ShowDialog()
                'Else
                'AtualizaEstoqueEntrada() 'Atualiza estoque de entrada dos Itens


                'System.Threading.Thread.Sleep(2000)
                'Dim XXestoque As New EstoqueAtualizarCtrPedido
                'RetornoProcura = Me.Id.Text
                'XXestoque.Run_AtualizadorEstoque()

                'End If

                If MsgBox("Deseja fazer programação de contas para este documento ?", 36, "Validação de Dados") = 6 Then
                    My.Forms.PagarLancamentos.ShowDialog()
                End If
                MsgBox("Pedido de Compra Confirmado.", 64, "Validação de Dados")

                CNN.Close()
            Catch x As Exception
                MsgBox(x.Message)
                CNN.Close()
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)

        End If

    End Sub
    Private Sub AtualizaEstoqueEntrada()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = ""
        Sql = "INSERT INTO EstoqueEFocus ( CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg ) SELECT CompraCtrlPedidoItens.Produto, CompraCtrlPedidoItens.Qtd, 'E' AS Expr1, 0 AS Expr2, CompraCtrlPedido.DataLançamento, CompraCtrlPedido.Id, 'CompraCtrlPedido' AS Expr3 FROM CompraCtrlPedido INNER JOIN CompraCtrlPedidoItens ON CompraCtrlPedido.Id = CompraCtrlPedidoItens.IdPedido WHERE (((CompraCtrlPedidoItens.IdPedido)=" & Me.Id.Text & ") AND ((CompraCtrlPedido.Empresa)=" & CodEmpresa & "));"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        cmd.ExecuteNonQuery()

    End Sub
    Private Sub Usuario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usuario.Enter
        Me.Usuario.Text = UserAtivo
    End Sub

    Private Sub TravarOCampoDataDeLançamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TravarOCampoDataDeLançamentoToolStripMenuItem.Click
        Me.DataLançamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
    End Sub

    Private Sub DestravarOCampoDataDeLançamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestravarOCampoDataDeLançamentoToolStripMenuItem.Click
        Dim HH As DateTime = Now
        Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança.", "Validação de Dados", 0)

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            Exit Sub
        Else
            Ação.CriaLog(UserAtivo, "CompraCtrPedido", "Destravou a data de lançamento Pedido " & Me.Id.Text & "- Nf :" & Me.NotaFiscal.Text, CaminhoLog, DataDia)
            Me.DataLançamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If
    End Sub

    Public Sub EncheLista()
        If Me.Id.Text = "" Then
            Exit Sub
        End If

        MyLista.Items.Clear()


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT CompraCtrlPedidoItens.*, CompraCtrlPedidoItens.IdPedido, Produtos.Descrição FROM CompraCtrlPedidoItens LEFT JOIN Produtos ON CompraCtrlPedidoItens.Produto = Produtos.CodigoProduto WHERE (((CompraCtrlPedidoItens.IdPedido)=" & Me.Id.Text & "));"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = True
            Dim TT As Double

            While DR.Read
                If Not IsDBNull(DR.Item("Codigo")) Then
                    Dim AA As String = DR.Item("Codigo")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("CompraCtrlPedidoItens.IdPedido") & "")
                    It.SubItems.Add(DR.Item("Produto") & "")
                    It.SubItems.Add(DR.Item("Descrição") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("Qtd"), 3), 2))

                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorUnitario"), 3), 2))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorTotal"), 3), 2))
                    MyLista.Items.AddRange(New ListViewItem() {It})


                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.LightSlateGray
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = True
                    End If
                    TT += Nz(DR.Item("ValorTotal"), 3)

                End If
            End While
            DR.Close()
            Me.TTotal.Text = FormatNumber(TT, 2)
            Me.MyLista.Focus()
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub EditarItenSelecionadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarItenSelecionadoToolStripMenuItem.Click
        If Me.Confirmado.Checked = True Then
            MsgBox("O Item não pode ser mais editado, pois o pedido já foi confirmado.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Codigo.Text = (MyLista.Items(I).Text.Substring(0))
        Next

        EditaItens = True
        My.Forms.CompraCtrPedidoItens.ShowDialog()

    End Sub

    Private Sub ExcluirItenSelecionadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirItenSelecionadoToolStripMenuItem.Click
        If Me.Confirmado.Checked = True Then
            MsgBox("O Item não pode ser Excluido, pois o pedido já foi confirmado.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim I As Integer = 0
        Dim CodigoSelecionado As String = ""

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then CodigoSelecionado = (MyLista.Items(I).Text.Substring(0))
        Next

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Delete * from CompraCtrlPedidoItens Where Codigo = " & CodigoSelecionado
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            Ação.CriaLog(UserAtivo, "CompraCtrPedido", "Exc Item : ID " & CodigoSelecionado, CaminhoLog, DataDia)
            EncheLista()

        Catch x As Exception
            MsgBox(x.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        If Me.Confirmado.Checked = True Then
            MsgBox("O Item não pode ser mais editado, pois o pedido já foi confirmado.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Codigo.Text = (MyLista.Items(I).Text.Substring(0))
        Next

        EditaItens = True
        My.Forms.CompraCtrPedidoItens.ShowDialog()
    End Sub

    'Private Sub AtualizaEstoqueEntrada()
    '    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    '    CNN.Open()
    '    Dim Sql As String = ""
    '    Sql = "INSERT INTO EstoqueEFocus ( CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg ) SELECT CompraCtrlPedidoItens.Produto, CompraCtrlPedidoItens.Qtd, 'E' AS Expr1, 0 AS Expr2, CompraCtrlPedido.DataLançamento, CompraCtrlPedido.Id, 'CompraCtrlPedido' AS Expr3 FROM CompraCtrlPedido INNER JOIN CompraCtrlPedidoItens ON CompraCtrlPedido.Id = CompraCtrlPedidoItens.IdPedido WHERE (((CompraCtrlPedidoItens.IdPedido)=" & Me.Id.Text & ") AND ((CompraCtrlPedido.Empresa)=" & CodEmpresa & "));"
    '    Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
    '    cmd.ExecuteNonQuery()
    '    CNN.Close()
    'End Sub

    Private Sub Degrade()
        Try

            Dim Key As RegistryKey = Registry.LocalMachine
            Dim PegaKeyPadrão As RegistryKey = Key.OpenSubKey("Software\\UPTema\\Tema")

            Cor1TelaPrimaria = PegaKeyPadrão.GetValue("Cor1TelaPrimaria", " ")
            Cor2TelaPrimaria = PegaKeyPadrão.GetValue("Cor2TelaPrimaria", " ")

            Cor1TelaSecundaria = PegaKeyPadrão.GetValue("Cor1TelaSecundaria", " ")
            Cor2TelaSecundaria = PegaKeyPadrão.GetValue("Cor2TelaSecundaria", " ")


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

    Private Sub InfNfeLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfNfeLote.Click
        TRVDados(UserAtivo, "LoteInformarNF")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.LoteInformarNF.ShowDialog()
        End If
    End Sub

    Private Sub btPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPagar.Click

        Dim HH As DateTime = Now
        Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança para edição dos itens a pagar", "Validação de Dados", 0)

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PagarLancamentos.EmEdiçao = True
            My.Forms.PagarLancamentos.ShowDialog()
        End If

    End Sub

    Private Sub btConfEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviaFinanceiro.Click
        Senha_Leave(sender, e)




        If Me.Senha.Text = "" Then
            MessageBox.Show("Esta ordem de compra ainda não foi autorizada para o Financeiro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If Me.EnviadoFinanceiro.Checked = True Then
            MessageBox.Show("Esta ordem de compra já foi enviada para o Financeiro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.LancaItens.Checked = True Then

            If CDbl(Me.TTotal.Text) <> CDbl(Me.ValorPedido.Text) Then
                MessageBox.Show("Verifique os valor dos itens não batem com o valor da ordem de compra.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update CompraCtrlPedido set EnviadoFinanceiro = @1 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))

            Try
                cmd.ExecuteNonQuery()
                Me.EnviadoFinanceiro.Checked = True
                Me.ConfirmarBT.Enabled = True
                CNN.Close()
                'Fazer impressao da ordem de compra
                If MessageBox.Show("Odem de compra Atualizada para o Financeiro, Deseja Imprimir a Ordem", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    RelatorioCarregar = "RelOrdemCompra"
                    My.Forms.VisualizadorRelatorio.ShowDialog()
                End If

            Catch x As Exception
                MsgBox(x.Message)
                CNN.Close()
                Exit Sub
            End Try

        Else

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update CompraCtrlPedido set EnviadoFinanceiro = @1 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                'Fazer impressao da ordem de compra
                If MessageBox.Show("Odem de compra Atualizada para o Financeiro, Deseja Imprimir a Ordem", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    RelatorioCarregar = "RelOrdemCompra"
                    My.Forms.VisualizadorRelatorio.ShowDialog()
                End If
            Catch x As Exception
                MsgBox(x.Message)
                CNN.Close()
                Exit Sub
            End Try
        End If

    End Sub

    Private Sub OrdemLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdemLabel.Click
        Me.Id.Enabled = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.SelectAll()
        Me.btProcuraPedido.Visible = True
        Me.Id.Focus()
    End Sub

    Private Sub CondPgto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CondPgto.Leave
        If Me.TipoPgto.Text = "1" Then
            Me.CondPgto.Text = "A VISTA"
            Me.CondPgto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.CondPgto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If
    End Sub

    Private Sub Empresa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Empresa.Leave
        If String.CompareOrdinal(Me.Empresa.Text, Me.Empresa.TextoAntigo) <> 0 Then
            Dim AchaEmpresa As New TrfGerais
            AchaEmpresa.Descrição_ItenRegistro(Me.Empresa, Me.EmpresaDesc, "Empresa", "CódigoEmpresa", Me.Empresa.Text, "RazãoSocial", TrfGerais.TipoDados.Numérico, False)
            Me.Fornecedor.Clear()
            Me.FornecedorDesc.Clear()
            Me.Fornecedor.Focus()
            Me.Empresa.Enabled = False
        End If
    End Sub

    Private Sub ImprimirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBT.Click

        If Me.Id.Text = "" Then
            MessageBox.Show("O usuário deve definir uma ordem de compra para impressão.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.Senha.Text = "" Then
            MessageBox.Show("Não é possível imprimir uma Ordem que não foi aprovada!", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        RelatorioCarregar = "RelOrdemCompra"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub DataPedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataPedido.Enter
        If Me.DataPedido.Text = "" Then
            Me.DataPedido.Text = DataDia
        End If
    End Sub

    Private Function AcharSolicitação() As Boolean
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Solicitacao where CodigoSolicitacao = " & Me.Solicitacao.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            DR.Close()
            CNN.Close()
            Return True
        Else
            DR.Close()
            CNN.Close()
            Return False
        End If
    End Function

    Private Sub Solicitacao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Solicitacao.Leave
        If String.CompareOrdinal(Me.Solicitacao.Text, Me.Solicitacao.TextoAntigo) Then
            If Me.Solicitacao.Text = "" Then Exit Sub

            Dim Achou As Boolean = AcharSolicitação()
            If Achou = False Then
                MessageBox.Show("Esta solicitação não existe no cadastro, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Solicitacao.Clear()
                Me.Solicitacao.Focus()
            End If
        End If
    End Sub

    Private Sub btItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btItens.Click
        If Me.Senha.Text <> "" Then
            MsgBox("Não é possível adicionar item em uma nota já aprovada", 48, "Validação de Dados")
            Exit Sub
        End If


        If Me.Confirmado.Checked = True Then
            MsgBox("Este pedido de Compra já foi confirmado, não pode mais ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.EnviadoFinanceiro.Checked = True Then
            MsgBox("Este pedido de Compra já foi confirmado em estoque, não pode mais ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.Id.Text = "" Then
            Exit Sub
        End If

        If Operation = INS Then
            SalvarBT_Click(sender, e)
        End If

        EditaItens = False
        My.Forms.CompraCtrPedidoItens.ShowDialog()
    End Sub

    Private Sub btProcuraPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcuraPedido.Click
        If String.CompareOrdinal(Me.Id.Text, Me.Id.TextoAntigo) <> 0 Then
            If Me.Id.Text = "0000" Or Me.Id.Text = "" Then Exit Sub
            LocalizaDados()
            EncheLista()
            Me.btProcuraPedido.Visible = False
            Me.Fornecedor.Focus()
            Me.Id.Enabled = False
        End If
    End Sub

   
    Private Sub LancaItens_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LancaItens.CheckedChanged

        If Me.LancaItens.Checked = False And Me.MyLista.Items.Count <> 0 Then
            MessageBox.Show("O usuário não pode desativar uma lista que contem itens.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.LancaItens.Checked = True
            Exit Sub
        End If

        If Me.LancaItens.Checked = True Then
            If Me.Fornecedor.Text = "" Then
                MsgBox("Não foi definido nenhum fornecedor", 48, "Validação de Dados")
                Me.LancaItens.Checked = False
                Exit Sub
            End If
        End If

        'If Me.LancaItens.Checked = True Then
        '    Me.Size = New Size(800, 593)
        'Else
        '    Me.Size = New Size(800, 382)
        'End If

    End Sub

    
    Private Sub AlterarEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarEmpresa.Click
        If Me.Confirmado.Checked = False Then
            Me.Empresa.Enabled = True
            Me.Fornecedor.Enabled = True
            Me.Empresa.Clear()
            Me.Fornecedor.Clear()
            Me.EmpresaDesc.Clear()
            Me.FornecedorDesc.Clear()
            Me.Empresa.Focus()
        End If
    End Sub

    Private Sub TipoPgto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TipoPgto.Leave
        If Me.TipoPgto.Text = 1 Then
            Me.CondPgto.Text = "A vista"
        End If

        If Me.TipoPgto.Text = 2 Then
            If Me.CondPgto.Text = "" Then
                Me.CondPgto.Text = "INFORMAR AQUI A COND. DE PAGAMENTO"
            End If
        End If
    End Sub

    Private Sub Fornecedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fornecedor.TextChanged

    End Sub

    Private Sub btForCotacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btForCotacao.Click
        If ConfImg.Visible = True Then
            MsgBox("Esse pedido não pode  ser editado, Pedido já foi confirmado", 48, "Validação de Dados")
            Exit Sub
        End If
        If Me.Solicitacao.Text = "" Then
            MsgBox("Operação inválida!", 48, "Validação de Dados")
            Exit Sub
        End If

        AtualizarDados()
    End Sub


    Private Sub AtualizarDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update CompraCtrlPedido set Fornecedor = @2, Documento = @3, DataPedido = @4, DataLançamento = @5, Destino = @6, Solicitante = @7, ValorPedido = @8, Empresa = @9, Confirmado = @10, FornecedorDesc = @11, NotaFiscal = @12, Usuario = @13, Solicitacao = @14, TipoPgto = @15, CondPgto = @16, LancaItens = @17, EnviadoFinanceiro = 18 Where Id = " & Me.Id.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Fornecedor.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataPedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLançamento.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Destino.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Solicitante.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorPedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.Empresa.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.Confirmado.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.FornecedorDesc.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NotaFiscal.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Usuario.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.Solicitacao.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.TipoPgto.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.CondPgto.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Me.LancaItens.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Me.EnviadoFinanceiro.Checked))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            Operation = UPD
        Catch x As Exception
            MsgBox(x.Message)
            CNN.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub btEndEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEndEntrega.Click

        If Me.Id.Text = "" Then
            MessageBox.Show("O usuário não pode informar endereço de entrega sem uma Ordem de Compra.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        My.Forms.CompraCtrPedidoEndEntrega.ShowDialog()
    End Sub

    Private Sub Senha_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Senha.Leave
        If String.CompareOrdinal(Me.Senha.Text, Me.Senha.TextoAntigo) Then
            VerificaSenha()

        End If


        TRVDados(UserAtivo, "PODEAPROVARORDEM")
        If Ina = True Then
            MsgBox("O Usuário: " & UserAtivo & " não pode aprovar Ordem de Compra.", 48, "Validação de Dados")
            Me.Senha.Clear()
            Exit Sub
        Else

        End If
    End Sub

    Private Sub VerificaSenha()

        If Me.Senha.Text = "" Then
            Exit Sub
        End If

        Dim Con As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Con.Open()
        Dim Sql As String = "SELECT * FROM LoginUser WHERE Login ='" & UserAtivo & "'"
        Dim ocmd As New OleDb.OleDbCommand(Sql, Con)
        Dim odr As OleDb.OleDbDataReader

        odr = ocmd.ExecuteReader
        odr.Read()
        If odr.HasRows Then
            If odr.Item("Senha") = Me.Senha.Text Then
                Exit Sub
            Else
                MessageBox.Show("Senha inválida para o usuário, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Senha.Clear()
                Me.Senha.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Este usuário não foi encontrado, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Senha.Clear()
            Me.Senha.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub Estoque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Estoque.CheckedChanged
        If Me.Estoque.Checked = True Then
            Me.LancaItens.Checked = True
        End If
    End Sub

    Private Sub Senha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Senha.TextChanged

    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        'verifica se existe nota e se existir nao pode cancelar o documento
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select Compra.Controle From Compra Where Compra.Controle = " & Me.Id.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            MessageBox.Show("Existe uma Nota Fiscal para este Documento não pode cancelar.", "Validação de Dados", MessageBoxButtons.OK)
            DR.Close()
            CNN.Close()
            Exit Sub
        End If
        DR.Close()


        If Me.Confirmado.Checked = False Then
            Operation = UPD
            Me.Inativo.Checked = True
            SalvaCancelamento()
        Else
            'verifica se existe contas a pagar para este documento e se ja existe alguma baixa foram baixadas
            Sql = "Select Pagar.IdCompraCtrlPedido, Pagar.Baixado From Pagar Where Pagar.IdCompraCtrlPedido = " & Me.Id.Text & " and Pagar.Baixado = True"
            CMD = New OleDb.OleDbCommand(Sql, CNN)
            DR = CMD.ExecuteReader

            If DR.HasRows Then
                MessageBox.Show("Esta Ordem de Compra possui contas relacionada que já foram pagas, não pode cancelar o documento.", "Validação de Dados", MessageBoxButtons.OK)
                DR.Close()
                CMD.Dispose()
                CNN.Close()
                Exit Sub
            End If

            'Deleta contas relacionadas
            Sql = "Delete PagarIdCompraCtrlPedido From Pagar Where Pagar.IdCompraCtrlPedido = " & Me.Id.Text
            CMD = New OleDb.OleDbCommand(Sql, CNN)
            CMD.ExecuteNonQuery()
            Operation = UPD
            Me.Inativo.Checked = True
            SalvaCancelamento()

        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub SalvaCancelamento()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update CompraCtrlPedido set Inativo = @1 Where Id = " & Me.Id.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        CMD.Parameters.Add(New OleDb.OleDbParameter("@1", Me.Inativo.Checked))

        Try
            CMD.ExecuteNonQuery()
            CNN.Close()
            Ação.CriaLog(UserAtivo, "CompraCtrPedido", "Exc: ID " & Me.Id.Text & " - Doc Fornecedor: " & Me.Documento.Text, CaminhoLog, DataDia)
            MsgBox("Ordem de Compra cancelado com sucesso.", 64, "Validação de Dados")
        Catch x As Exception
            MsgBox(x.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub LancaItens_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LancaItens.Click
        If Me.LancaItens.Checked = False And Me.MyLista.Items.Count <> 0 Then
            MessageBox.Show("O usuário não pode desativar uma lista que contem itens.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.LancaItens.Checked = True
            Exit Sub
        End If

        If Me.LancaItens.Checked = True Then
            Me.Size = New Size(800, 650)
            Me.btItens.Enabled = True
        Else
            Me.Size = New Size(800, 400)
        End If
    End Sub
End Class