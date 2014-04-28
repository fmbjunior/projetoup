Imports Microsoft.Win32
Public Class DocumentoEntrada


    Public EditaItens As Boolean = False
    Dim Ação As New TrfGerais()
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim SalvoDoc As Boolean = False
    Dim ExistDoc As Boolean = False
    Public CancelouPagar As Boolean
    Public varPegaConta As String = String.Empty
    Dim vNumeroDoc As String = String.Empty
    Dim Ult As Integer
   
    ''' <summary>Recebe o codigo do contrato quando for feito o lançamento das despesas </summary>
    ''' <remarks>Vareavel criado pelo beto</remarks>
    Public sContrato As String = String.Empty

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click

        Me.NotaFiscal.Enabled = True
        Me.NotaFiscal.Focus()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        AdicionaNovo()
        LiberarConta1()
        UltimoReg()
        Me.NovoBT.Enabled = False
    End Sub

    Public Sub AdicionaNovo()
        Ação.LimpaTextBox(Me)
        Me.Confirmado.Checked = False
        Me.Inativo.Checked = False
        Ação.Desbloquear_Controle(Me, True)
        Me.Id.Enabled = False

        Me.Usuario.Text = UserAtivo
        SalvoDoc = False
        Me.ConfImg.Visible = False
        Operation = INS
        Me.ConfirmarBT.Enabled = True
        Me.Id.Enabled = False


        Me.BaseCalcIcmsST.Text = "R$ 0,00"
        Me.ValorPedido.Text = "R$ 0,00"
        Me.ValorIcms.Text = "R$ 0,00"
        Me.BaseCalcIcms.Text = "R$ 0,00"
        Me.ValorBaseCalcIcmsSt.Text = "R$ 0,00"
        Me.ConfImg.Visible = False
        Me.ConfImg.Text = "Confirmado"
        Me.DataPedido.Focus()

    End Sub


    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click

        If Me.Confirmado.Checked = True Then
            MsgBox("Este lançamento já foi confirmado", 48, "Validação de Dados")
            Exit Sub
        End If

        If Me.Fornecedor.Text = "" Then
            MessageBox.Show("Não foi encontrado dados para salvar; Verifioque.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        VerificarDuplicidadeDocumento()
        If ExistDoc = True Then
            If MsgBox("Existe um documento com este Nº: " & Me.NotaFiscal.Text & " lançado para este fornecedor, deseja laçar este documento Duplicado ?", 36, "Validação de Dados") = 6 Then
            Else
                Ação.LimpaTextBox(Me)
                Ação.Desbloquear_Controle(Me, False)
                Me.cTipo.Text = ""
                Exit Sub
            End If
        End If
        'Area destinada para as validacoes
        If Me.Fornecedor.Text = "" Then
            MsgBox("O Fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Fornecedor.Focus()
            Exit Sub

        ElseIf Me.DataPedido.Text = "" Then
            MsgBox("A Data do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataPedido.Focus()
            Exit Sub

        ElseIf Me.Destino.Text = "" Then
            MsgBox("O destino não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub

        ElseIf Me.ValorPedido.Text = "" Or CDbl(Me.ValorPedido.Text) = 0 Then
            MsgBox("O Valor do documento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorPedido.Focus()
            Exit Sub
        End If


        If Me.cTipo.Text = "" Then
            MessageBox.Show("Favor informar o Tipo de Lançamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cTipo.Focus()
            Exit Sub
        End If



        If Me.ContaDespesa.Text = "" Then
            MessageBox.Show("Favor informar a Conta de Lançamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ContaDespesa.Focus()
            Exit Sub
        End If


        If CDbl(NzZero(Me.Vlr1.Text)) + CDbl(NzZero(Me.Vlr2.Text)) + CDbl(NzZero(Me.Vlr3.Text)) + CDbl(NzZero(Me.Vlr4.Text)) + CDbl(NzZero(Me.Vlr5.Text)) + CDbl(NzZero(Me.Vlr6.Text)) <> CDbl(Me.ValorPedido.Text) Then
            MessageBox.Show("O valor dos Lançamento nas contas são diferente do valor da entrada, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorPedido.Focus()
            Exit Sub
        End If

        If CDbl(NzZero(Me.Vlr1.Text)) <> 0 And Me.Conta1.Text = "" Then
            MessageBox.Show("A conta não foi informada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Conta1.Focus()
            Exit Sub
        End If

        If CDbl(NzZero(Me.Vlr2.Text)) <> 0 And Me.Conta2.Text = "" Then
            MessageBox.Show("A conta não foi informada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Conta2.Focus()
            Exit Sub
        End If

        If CDbl(NzZero(Me.Vlr3.Text)) <> 0 And Me.Conta3.Text = "" Then
            MessageBox.Show("A conta não foi informada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Conta3.Focus()
            Exit Sub
        End If

        If CDbl(NzZero(Me.Vlr4.Text)) <> 0 And Me.Conta4.Text = "" Then
            MessageBox.Show("A conta não foi informada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Conta4.Focus()
            Exit Sub
        End If

        If CDbl(NzZero(Me.Vlr5.Text)) <> 0 And Me.Conta5.Text = "" Then
            MessageBox.Show("A conta não foi informada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Conta5.Focus()
            Exit Sub
        End If

        If CDbl(NzZero(Me.Vlr6.Text)) <> 0 And Me.Conta6.Text = "" Then
            MessageBox.Show("A conta não foi informada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Conta6.Focus()
            Exit Sub
        End If


        Dim TestaValor As Double = CDbl(NzZero(Me.Vlr1.Text)) + CDbl(NzZero(Me.Vlr2.Text)) + CDbl(NzZero(Me.Vlr3.Text)) + CDbl(NzZero(Me.Vlr4.Text)) + CDbl(NzZero(Me.Vlr5.Text)) + CDbl(NzZero(Me.Vlr6.Text))

        If NzZero(TestaValor) <> NzZero(Me.ValorPedido.Text) Then
            MessageBox.Show("Os valores das contas não batem com o valor da compra.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If Me.Usuario.Text = "" Then Me.Usuario.Text = UserAtivo
        If Me.DataLançamento.Text = "" Then Me.DataLançamento.Text = DataDia

        'Fim da Area destinada para as validacoes

        If Operation = INS Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            UltimoReg()                                        '1     '2          '3          '4             '5        '6          '7        '8            '9            '10       '11     '12     '13 
            Dim Sql As String = "INSERT INTO CompraCtrlPedido (Id, Fornecedor, DataPedido, DataLançamento, Destino, ValorPedido, Empresa, Confirmado, FornecedorDesc, NotaFiscal, Usuario, Tipo, Inativo, BaseCalcIcmsST, ValorBaseCalcIcmsSt, BaseCalcIcms, ValorIcms, ContaLancamento, Conta1, Conta2, Conta3, Conta4, Conta5, Conta6, Vlr1, Vlr2, Vlr3, Vlr4, Vlr5, Vlr6, Contrato) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @contrato)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
            Me.Id.Text = Ult
            cmd.Parameters.AddWithValue("@1", Nz(Me.Id.Text, 1))
            cmd.Parameters.AddWithValue("@2", Nz(Me.Fornecedor.Text, 1))
            cmd.Parameters.AddWithValue("@3", Nz(Me.DataPedido.Text, 1))
            cmd.Parameters.AddWithValue("@4", Nz(Me.DataLançamento.Text, 1))
            cmd.Parameters.AddWithValue("@5", Nz(Me.Destino.Text, 1))
            cmd.Parameters.AddWithValue("@6", Nz(Me.ValorPedido.Text, 1))
            cmd.Parameters.AddWithValue("@7", CodEmpresa)
            cmd.Parameters.AddWithValue("@8", False)
            cmd.Parameters.AddWithValue("@9", Nz(Me.FornecedorDesc.Text, 1))
            cmd.Parameters.AddWithValue("@10", Nz(Me.NotaFiscal.Text, 1))
            cmd.Parameters.AddWithValue("@11", Nz(Me.Usuario.Text, 1))
            cmd.Parameters.AddWithValue("@12", Nz(Me.cTipo.Text, 1))
            cmd.Parameters.AddWithValue("@13", Me.Inativo.Checked)
            cmd.Parameters.AddWithValue("@14", Nz(Me.BaseCalcIcmsST.Text, 1))
            cmd.Parameters.AddWithValue("@15", Nz(Me.ValorBaseCalcIcmsSt.Text, 1))
            cmd.Parameters.AddWithValue("@16", Nz(Me.BaseCalcIcms.Text, 1))
            cmd.Parameters.AddWithValue("@17", Nz(Me.ValorIcms.Text, 1))
            cmd.Parameters.AddWithValue("@18", Nz(Me.ContaDespesa.Text, 1))

            cmd.Parameters.AddWithValue("@19", Nz(Me.Conta1.Text, 1))
            cmd.Parameters.AddWithValue("@20", Nz(Me.Conta2.Text, 1))
            cmd.Parameters.AddWithValue("@21", Nz(Me.Conta3.Text, 1))
            cmd.Parameters.AddWithValue("@22", Nz(Me.Conta4.Text, 1))
            cmd.Parameters.AddWithValue("@23", Nz(Me.Conta5.Text, 1))
            cmd.Parameters.AddWithValue("@24", Nz(Me.Conta6.Text, 1))
            cmd.Parameters.AddWithValue("@25", Nz(Me.Vlr1.Text, 1))
            cmd.Parameters.AddWithValue("@26", Nz(Me.Vlr2.Text, 1))
            cmd.Parameters.AddWithValue("@27", Nz(Me.Vlr3.Text, 1))
            cmd.Parameters.AddWithValue("@28", Nz(Me.Vlr4.Text, 1))
            cmd.Parameters.AddWithValue("@29", Nz(Me.Vlr5.Text, 1))
            cmd.Parameters.AddWithValue("@30", Nz(Me.Vlr6.Text, 1))
            cmd.Parameters.AddWithValue("@contrato", Nz(sContrato, 1))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.Id.Text)
                CNN.Close()
                SalvoDoc = True
                Operation = UPD
                Me.NovoBT.Enabled = True
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

            Dim Sql As String = "Update CompraCtrlPedido set Fornecedor = @Fornecedor, DataPedido = @DataPedido, DataLançamento = @Datalancamento, Destino = @Destino, ValorPedido = @ValorPedido, Empresa = @Empresa, FornecedorDesc = @FornecedorDesc, NotaFiscal = @Notafiscal, Usuario = @Usuario, Tipo = @Tipo, Inativo = @Inativo, BaseCalcIcms = @BaseCalcIcms, ValorIcms = @ValorIcms, BaseCalcIcmsST = @BaseCalcIcmsST, ValorBaseCalcIcmsSt = @ValorBaseCalcIcmsSt, ContaLancamento = @ContaDespesa, Conta1 = @Conta1, Conta2 = @Conta2, Conta3 = @Conta3, Conta4 = @Conta4, Conta5 = @Conta5, Conta6 = @Conta6, Vlr1 = @Vlr1, Vlr2 = @Vlr2, Vlr3 = @Vlr3, Vlr4 = @Vlr4, Vlr5 = @Vlr5, Vlr6 = @Vlr6, Contrato=@contrato  Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.AddWithValue("@Fornecedor", Nz(Me.Fornecedor.Text, 1))
            cmd.Parameters.AddWithValue("@Datapedido", Nz(Me.DataPedido.Text, 1))
            cmd.Parameters.AddWithValue("@Datalancamento", Nz(Me.DataLançamento.Text, 1))
            cmd.Parameters.AddWithValue("@Destino", Nz(Me.Destino.Text, 1))
            cmd.Parameters.AddWithValue("@ValorPedido", Nz(Me.ValorPedido.Text, 1))
            cmd.Parameters.AddWithValue("@Empresa", CodEmpresa)
            cmd.Parameters.AddWithValue("@FornecedorDesc", Nz(Me.FornecedorDesc.Text, 1))
            cmd.Parameters.AddWithValue("@Notafiscal", Nz(Me.NotaFiscal.Text, 1))
            cmd.Parameters.AddWithValue("@usuario", Nz(Me.Usuario.Text, 1))
            cmd.Parameters.AddWithValue("@tipo", Nz(Me.cTipo.Text, 1))
            cmd.Parameters.AddWithValue("@inativo", Me.Inativo.Checked)
            cmd.Parameters.AddWithValue("@BaseCalcIcms", Nz(Me.BaseCalcIcms.Text, 1))
            cmd.Parameters.AddWithValue("@ValorIcms", Nz(Me.ValorIcms.Text, 1))
            cmd.Parameters.AddWithValue("@BaseCalcIcmsST", Nz(Me.BaseCalcIcmsST.Text, 1))
            cmd.Parameters.AddWithValue("@ValorBaseCalcIcmsSt", Nz(Me.ValorBaseCalcIcmsSt.Text, 1))
            cmd.Parameters.AddWithValue("@ContaDespesa", Nz(Me.ContaDespesa.Text, 1))
            cmd.Parameters.AddWithValue("@Conta1", Nz(Me.Conta1.Text, 1))
            cmd.Parameters.AddWithValue("@Conta2", Nz(Me.Conta2.Text, 1))
            cmd.Parameters.AddWithValue("@Conta3", Nz(Me.Conta3.Text, 1))
            cmd.Parameters.AddWithValue("@Conta4", Nz(Me.Conta4.Text, 1))
            cmd.Parameters.AddWithValue("@Conta5", Nz(Me.Conta5.Text, 1))
            cmd.Parameters.AddWithValue("@Conta6", Nz(Me.Conta6.Text, 1))
            cmd.Parameters.AddWithValue("@Vlr1", Nz(Me.Vlr1.Text, 1))
            cmd.Parameters.AddWithValue("@Vlr2", Nz(Me.Vlr2.Text, 1))
            cmd.Parameters.AddWithValue("@Vlr3", Nz(Me.Vlr3.Text, 1))
            cmd.Parameters.AddWithValue("@Vlr4", Nz(Me.Vlr4.Text, 1))
            cmd.Parameters.AddWithValue("@Vlr5", Nz(Me.Vlr5.Text, 1))
            cmd.Parameters.AddWithValue("@Vlr6", Nz(Me.Vlr6.Text, 1))
            cmd.Parameters.AddWithValue("@contrato", Nz(sContrato, 1))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                AtPagarNF()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.Id.Text)
                SalvoDoc = True
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                CNN.Close()
                Exit Sub
            End Try

            Ação.Desbloquear_Controle(Me, False)

        End If
        'ConfirmarBT_Click(sender, e)

    End Sub


    Public Sub cancelouPgto(ByVal xcod As Integer)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update CompraCtrlPedido set Confirmado = @Confirmado  Where Id = " & xcod
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.AddWithValue("@confirmado", False)

        Try
            cmd.ExecuteNonQuery()
            Ação.CriaLog(UserAtivo, "CompraCtrPedido", "Cancelou: ID " & Me.Id.Text & " - Doc Fornecedor: " & Me.NotaFiscal.Text, CaminhoLog, DataDia)
            Me.Confirmado.Checked = False
            Me.ConfImg.Visible = False

            CNN.Close()

        Catch x As Exception
            MsgBox(x.Message)
            CNN.Close()
            Exit Sub
        End Try
        Ação.Desbloquear_Controle(Me, False)
    End Sub
    Public Sub SalvarRegistro()

        'Area destinada para as validacoes


        If Me.DataPedido.Text = "" Then
            MsgBox("A Data do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataPedido.Focus()
            Exit Sub

        ElseIf Me.Destino.Text = "" Then
            MsgBox("O destino não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Destino.Focus()
            Exit Sub

        End If


        If Me.Usuario.Text = "" Then Me.Usuario.Text = UserAtivo
        If Me.DataLançamento.Text = "" Then Me.DataLançamento.Text = DataDia

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        UltimoReg()
        Dim Sql As String = "INSERT INTO CompraCtrlPedido (Id, Fornecedor, Documento, DataPedido, DataLançamento, Destino, Solicitante, ValorPedido, Empresa, Confirmado, FornecedorDesc, NotaFiscal, Usuario, Solicitacao, TipoPgto, CondPgto, LancaItens, EnviadoFinanceiro, Conta1, Conta2, Conta3, Conta4, Conta5, Conta6, Vlr1, Vlr2, Vlr3, Vlr4, Vlr5, Vlr6,contrato) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30,@contrato)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Fornecedor.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NotaFiscal.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataPedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLançamento.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Destino.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.ValorPedido.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", False))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.FornecedorDesc.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NotaFiscal.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Usuario.Text, 1)))


        cmd.Parameters.AddWithValue("@19", Nz(Me.Conta1.Text, 1))
        cmd.Parameters.AddWithValue("@20", Nz(Me.Conta2.Text, 1))
        cmd.Parameters.AddWithValue("@21", Nz(Me.Conta3.Text, 1))
        cmd.Parameters.AddWithValue("@22", Nz(Me.Conta4.Text, 1))
        cmd.Parameters.AddWithValue("@23", Nz(Me.Conta5.Text, 1))
        cmd.Parameters.AddWithValue("@24", Nz(Me.Conta6.Text, 1))
        cmd.Parameters.AddWithValue("@25", Nz(Me.Vlr1.Text, 1))
        cmd.Parameters.AddWithValue("@26", Nz(Me.Vlr2.Text, 1))
        cmd.Parameters.AddWithValue("@27", Nz(Me.Vlr3.Text, 1))
        cmd.Parameters.AddWithValue("@28", Nz(Me.Vlr4.Text, 1))
        cmd.Parameters.AddWithValue("@29", Nz(Me.Vlr5.Text, 1))
        cmd.Parameters.AddWithValue("@30", Nz(Me.Vlr6.Text, 1))
        cmd.Parameters.AddWithValue("@contrato", Nz(sContrato, 1))

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

        Dim Sql As String = "UPDATE Pagar INNER JOIN CompraCtrlPedido ON Pagar.IdCompraCtrlPedido = CompraCtrlPedido.Id SET Pagar.NotaFiscal = ' " & Nz(Me.NotaFiscal.Text, 1) & " ' WHERE Pagar.IdCompraCtrlPedido = " & Me.Id.Text
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


    Private Sub CompraCtrPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se o contrato estiver ativo
        'carrega o documento de entrada com as informações 
        'do contrato e já cria um novo lançamento
        If My.Forms.Contrato.Visible Then
            NovoBT_Click(sender, e)
            Dim st = Me.Text
            Me.Text = st & "-" & "Lançamento Despesas Contrato"
        Else
            Ação.Desbloquear_Controle(Me, False)
            ' Me.Size = New Size(800, 382)
        End If

    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader


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

        Ult += 1
        vNumeroDoc = String.Format("{0:ddMMyyyy}", (DateTime.Today)) & "-" & Ult
        'fim inserir ultimo registro

    End Sub

    Private Sub DataLançamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLançamento.Enter
        If Me.DataLançamento.Text = "" Then Me.DataLançamento.Text = DataDia
    End Sub

    Private Sub Fornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fornecedor.KeyDown

        If e.KeyCode = Keys.F5 Then
            RetornoProcura = String.Empty
            My.Forms.TelaProcuraForCtrlPedido.ShowDialog()
            Me.Fornecedor.Text = RetornoProcura
            Me.Fornecedor.Focus()
        End If
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

        Dim Sql As String = "Select * from Fornecedor where CódigoFornecedor = " & Me.Fornecedor.Text & " and inativo = false"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.FornecedorDesc.Text = DR.Item("RazãoSocial") & ""
        Else
            MsgBox("Verifique os dados do fornecedor, ou fornecedor não existe no cadastro.", 64, "Validador de Dados")
            Me.Fornecedor.Focus()
            CNN.Close()
            Exit Sub
        End If
        DR.Close()


        'Verificar se a nota foi lancada na compra com o mesmo fornecedor
        If Me.Confirmado.Checked = False Then
            Sql = "select * from Compra Where CodigoFornecedor = " & Me.Fornecedor.Text & " and NotaFiscal = '" & Me.NotaFiscal.Text & "'"
            CMD.CommandText = Sql
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                If MessageBox.Show("Esta NF já foi lançada como Compra de Itens, Deseja Continuar.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    Me.NotaFiscal.Clear()
                    Me.Fornecedor.Clear()
                    Me.FornecedorDesc.Clear()
                    Me.NotaFiscal.Focus()
                End If
            End If
        End If

        DR.Close()
        CNN.Close()


    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.Id.Text = "" Then
            MsgBox("Não existe Controle de Compra para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.Inativo.Checked = True Then
            MsgBox("Este documento foi cancelado não pode ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If


        Operation = UPD

        If Me.Confirmado.Checked = True Then
            MsgBox("Este Pedido já foi confirmado.", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
        Else
            Ação.Desbloquear_Controle(Me, True)
            LiberarConta1()
        End If


    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        Ação.Desbloquear_Controle(Me, False)
        Ação.LimpaTextBox(Me)
        My.Forms.TelaProcuraDocumento.ShowDialog()

        If Me.Id.Text <> "" Then
            LocalizaDados()
            Me.Fornecedor.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Dim Sql As String = "SELECT CompraCtrlPedido.Id, CompraCtrlPedido.Fornecedor, CompraCtrlPedido.ContaLancamento, CompraCtrlPedido.FornecedorDesc, CompraCtrlPedido.Tipo, CompraCtrlPedido.NotaFiscal, CompraCtrlPedido.DataPedido, CompraCtrlPedido.Destino, CompraCtrlPedido.DataLançamento, CompraCtrlPedido.ValorPedido, CompraCtrlPedido.Confirmado, CompraCtrlPedido.Inativo, CompraCtrlPedido.Empresa, CompraCtrlPedido.Usuario, CompraCtrlPedido.ValorFrete, CompraCtrlPedido.ValorIpi, CompraCtrlPedido.BaseCalcIpi, CompraCtrlPedido.ValorIcms, CompraCtrlPedido.BaseCalcIcms, CompraCtrlPedido.Icms, CompraCtrlPedido.Empresa FROM CompraCtrlPedido LEFT JOIN Fornecedor ON CompraCtrlPedido.Fornecedor = Fornecedor.CódigoFornecedor WHERE (((CompraCtrlPedido.Id)=" & Me.Id.Text & ") AND ((CompraCtrlPedido.Empresa)=" & CodEmpresa & "));"
        Dim Sql As String = "SELECT CompraCtrlPedido.* FROM CompraCtrlPedido LEFT JOIN Fornecedor ON CompraCtrlPedido.Fornecedor = Fornecedor.CódigoFornecedor WHERE (((CompraCtrlPedido.Id)=" & Me.Id.Text & ") AND ((CompraCtrlPedido.Empresa)=" & CodEmpresa & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Id.Text = DR.Item("id") & ""
            Me.Fornecedor.Text = DR.Item("Fornecedor") & ""
            Me.FornecedorDesc.Text = DR.Item("FornecedorDesc") & ""
            Me.DataPedido.Text = DR.Item("DataPedido") & ""
            Me.DataLançamento.Text = DR.Item("DataLançamento") & ""
            Me.Destino.Text = DR.Item("Destino") & ""
            Me.ValorPedido.Text = FormatCurrency(Nz(DR.Item("ValorPedido"), 3), 2)
            Me.Confirmado.Checked = DR.Item("Confirmado")
            Me.NotaFiscal.Text = DR.Item("NotaFiscal") & ""
            Me.Usuario.Text = DR.Item("Usuario") & ""
            Me.Inativo.Checked = DR.Item("Inativo")
            Me.BaseCalcIcms.Text = FormatCurrency(Nz(DR.Item("BaseCalcIcms"), 3), 2)
            Me.ValorIcms.Text = FormatCurrency(Nz(DR.Item("valoricms"), 3), 2)
            Me.cTipo.Text = DR.Item("Tipo") & ""
            Me.ContaDespesa.Text = DR.Item("ContaLancamento") & ""

            Me.Conta1.Text = DR.Item("Conta1") & ""
            Me.Conta2.Text = DR.Item("Conta2") & ""
            Me.Conta3.Text = DR.Item("Conta3") & ""
            Me.Conta4.Text = DR.Item("Conta4") & ""
            Me.Conta5.Text = DR.Item("Conta5") & ""
            Me.Conta6.Text = DR.Item("Conta6") & ""

            Me.Vlr1.Text = DR.Item("Vlr1") & ""
            Me.Vlr2.Text = DR.Item("Vlr2") & ""
            Me.Vlr3.Text = DR.Item("Vlr3") & ""
            Me.Vlr4.Text = DR.Item("Vlr4") & ""
            Me.Vlr5.Text = DR.Item("Vlr5") & ""
            Me.Vlr6.Text = DR.Item("Vlr6") & ""


        Else

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
        CNN.Close()

        AchaContaCC(Me.Conta1.Text, Me.DescConta1)
        AchaContaCC(Me.Conta2.Text, Me.DescConta2)
        AchaContaCC(Me.Conta3.Text, Me.DescConta3)
        AchaContaCC(Me.Conta4.Text, Me.DescConta4)
        AchaContaCC(Me.Conta5.Text, Me.DescConta5)
        AchaContaCC(Me.Conta6.Text, Me.DescConta6)

        If Me.ContaDespesa.Text <> "" Then
            AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaDespesaDesc, False)
        End If

    End Sub

    Public Sub VerificarDuplicidadeDocumento()

        If Operation = INS Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            'Dim Sql As String = "SELECT CompraCtrlPedido.Id, CompraCtrlPedido.Fornecedor, CompraCtrlPedido.FornecedorDesc, Fornecedor.CodPlanoConta, CompraCtrlPedido.TipoPedido, CompraCtrlPedido.NotaFiscal, CompraCtrlPedido.notafiscal, CompraCtrlPedido.DataPedido, CompraCtrlPedido.Destino, CompraCtrlPedido.DataLançamento, CompraCtrlPedido.Solicitante, CompraCtrlPedido.ValorPedido, CompraCtrlPedido.Confirmado, CompraCtrlPedido.Inativo, CompraCtrlPedido.Empresa FROM CompraCtrlPedido INNER JOIN Fornecedor ON CompraCtrlPedido.Fornecedor = Fornecedor.CódigoFornecedor WHERE CompraCtrlPedido.notafiscal = '" & Me.notafiscal.Text & "' AND CompraCtrlPedido.Empresa = " & CodEmpresa & " and CompraCtrlPedido.Fornecedor = " & Me.Fornecedor.Text
            Dim SQL As String = "SELECT Fornecedor.CódigoFornecedor, CompraCtrlPedido.Tipo, CompraCtrlPedido.Empresa, CompraCtrlPedido.NotaFiscal, CompraCtrlPedido.Id FROM CompraCtrlPedido INNER JOIN Fornecedor ON CompraCtrlPedido.Fornecedor = Fornecedor.CódigoFornecedor WHERE (((Fornecedor.CódigoFornecedor)=" & Me.Fornecedor.Text & ") AND ((CompraCtrlPedido.Tipo)='" & Me.cTipo.Text & "') AND ((CompraCtrlPedido.Empresa)=" & CodEmpresa & ") AND ((CompraCtrlPedido.NotaFiscal)='" & Me.NotaFiscal.Text & "'));"


            Dim CMD As New OleDb.OleDbCommand(SQL, CNN)
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

    Private Sub ConfirmarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarBT.Click

        If Me.Fornecedor.Text = "" Then
            MsgBox("O Fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Fornecedor.Focus()
            Exit Sub
        ElseIf Me.NotaFiscal.Text = "" Then
            MsgBox("O documento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.NotaFiscal.Focus()
            Exit Sub

        ElseIf Me.DataPedido.Text = "" Then
            MsgBox("A Data do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataPedido.Focus()
            Exit Sub

        ElseIf Me.Destino.Text = "" Then
            MsgBox("O destino não foi informado, favor verificar.", 64, "Validação de Dados")
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

        If CDbl(NzZero(Me.Vlr1.Text)) + CDbl(NzZero(Me.Vlr2.Text)) + CDbl(NzZero(Me.Vlr3.Text)) + CDbl(NzZero(Me.Vlr4.Text)) + CDbl(NzZero(Me.Vlr5.Text)) + CDbl(NzZero(Me.Vlr6.Text)) <> CDbl(Me.ValorPedido.Text) Then
            MessageBox.Show("O valor dos Lançamento nas contas são diferente do valor da entrada, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorPedido.Focus()
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

            If MsgBox("O usuário deverá fazer lançamento para o contas a pagar, Continua...", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação de Dados") = MsgBoxResult.Yes Then
                My.Forms.PagarLancamentos.ShowDialog()
            Else
                MessageBox.Show("Lançamento Cancelado pelo Usuário.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If CancelouPagar = True Then
                MessageBox.Show("Confirmação cancelada pelo usuário", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Me.Confirmado.Checked = True

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update CompraCtrlPedido set Fornecedor = @Fornecedor, DataPedido = @DataPedido, DataLançamento = @Datalancamento, Destino = @Destino, ValorPedido = @ValorPedido, Empresa = @Empresa, FornecedorDesc = @FornecedorDesc, NotaFiscal = @Notafiscal, Usuario = @Usuario, Tipo = @Tipo, Inativo = @Inativo, Confirmado=@Confirmado  Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.AddWithValue("@Fornecedor", Nz(Me.Fornecedor.Text, 1))
            cmd.Parameters.AddWithValue("@Datapedido", Nz(Me.DataPedido.Text, 1))
            cmd.Parameters.AddWithValue("@Datalancamento", Nz(Me.DataLançamento.Text, 1))
            cmd.Parameters.AddWithValue("@Destino", Nz(Me.Destino.Text, 1))
            cmd.Parameters.AddWithValue("@ValorPedido", Nz(Me.ValorPedido.Text, 1))
            cmd.Parameters.AddWithValue("@Empresa", CodEmpresa)
            cmd.Parameters.AddWithValue("@FornecedorDesc", Nz(Me.FornecedorDesc.Text, 1))
            cmd.Parameters.AddWithValue("@Notafiscal", Nz(Me.NotaFiscal.Text, 1))
            cmd.Parameters.AddWithValue("@usuario", Nz(Me.Usuario.Text, 1))
            cmd.Parameters.AddWithValue("@tipo", Nz(Me.cTipo.Text, 1))
            cmd.Parameters.AddWithValue("@inativo", Me.Inativo.Checked)
            cmd.Parameters.AddWithValue("@confirmado", Me.Confirmado.Checked)

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()

                If Me.Confirmado.Checked = True Then
                    Me.ConfImg.Visible = True
                Else
                    Me.ConfImg.Visible = False
                End If
                MsgBox("Documento Confirmado.", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.Id.Text)
            Catch x As Exception
                MsgBox(x.Message)
                CNN.Close()
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)

        End If

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

    Private Sub ImprimirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBT.Click

        If Me.Id.Text = "" Then
            MessageBox.Show("O usuário deve definir um Documento para impressão.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        RelatorioCarregar = "EntradaDocumento"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub DataPedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataPedido.Enter
        If Me.DataPedido.Text = "" Then
            Me.DataPedido.Text = DataDia
        End If
    End Sub

    Private Sub btProcuraPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If String.CompareOrdinal(Me.Id.Text, Me.Id.TextoAntigo) <> 0 Then
            If Me.Id.Text = "0000" Or Me.Id.Text = "" Then Exit Sub
            LocalizaDados()
            Me.Fornecedor.Focus()
            Me.Id.Enabled = False
        End If
    End Sub

    Private Sub AtualizarDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update CompraCtrlPedido set Fornecedor = @2, Documento = @3, DataPedido = @4, DataLançamento = @5, Destino = @6, Solicitante = @7, ValorPedido = @8, Empresa = @9, Confirmado = @10, FornecedorDesc = @11, NotaFiscal = @12, Usuario = @13, Solicitacao = @14, TipoPgto = @15, CondPgto = @16, LancaItens = @17, EnviadoFinanceiro = 18 Where Id = " & Me.Id.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Fornecedor.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NotaFiscal.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataPedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLançamento.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Destino.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorPedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.Confirmado.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.FornecedorDesc.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NotaFiscal.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Usuario.Text, 1)))

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

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click

        'verifica se existe nota e se existir nao pode cancelar o documento
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = String.Empty
        Try
            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim DR As OleDb.OleDbDataReader

            If Me.Confirmado.Checked = False Then
                Operation = UPD
                Me.Inativo.Checked = True
                SalvarBT_Click(sender, e)
            Else


                Dim HH As DateTime = Now

                Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.Id.Text)
                Autorizado = varAutorizado
                If Autorizado = False Then
                    Exit Sub

                    'Dim CodSegurança As String = InformaCodigoSeguranca()
                    'If VerificaCodigoSegurança(CodSegurança) = False Then
                    '    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
                    '    Exit Sub
                End If

                Dim Motivo As String = ""
                Motivo = InputBox("Informe o motivo para inativar a nota fiscal de compra.", "Validação de Dados")
                If Motivo = "" Then
                    MsgBox("Não foi informado o motivo, nota fiscal não será cancelada.", 64, "Validação de Dados")
                    Exit Sub
                End If

                'verifica se existe contas a pagar para este documento e se ja existe alguma baixa foram baixadas
                Sql = "Select Pagar.IdCompraCtrlPedido, Pagar.Baixado From Pagar Where Pagar.IdCompraCtrlPedido = " & Me.Id.Text & " and Pagar.Baixado = True"
                CMD = New OleDb.OleDbCommand(Sql, CNN)
                DR = CMD.ExecuteReader

                If DR.HasRows Then
                    MessageBox.Show("Este documento possui contas relacionada que já foram pagas, não pode cancelar o documento.", "Validação de Dados", MessageBoxButtons.OK)
                    DR.Close()
                    CMD.Dispose()
                    CNN.Close()
                    Exit Sub
                End If

                'Deleta contas relacionadas
                Sql = "Delete PagarIdCompraCtrlPedido From Pagar Where Pagar.IdCompraCtrlPedido = " & Me.Id.Text
                CMD = New OleDb.OleDbCommand(Sql, CNN)

                Try
                    CMD.ExecuteNonQuery()
                    Operation = UPD
                    Me.Inativo.Checked = True
                    Sql = Nothing
                    CMD = Nothing
                Catch xx As Exception
                    MsgBox(xx.Message)
                End Try
                'SalvarBT_Click(sender, e)

                Sql = "Update CompraCtrlPedido set Inativo = @1, Destino = @2 Where id = " & Me.Id.Text
                CMD = New OleDb.OleDbCommand(Sql, CNN)

                CMD.Parameters.Add(New OleDb.OleDbParameter("@1", True))
                CMD.Parameters.Add(New OleDb.OleDbParameter("@2", "Inativado por: " & "UserAtivo & Autorizado por: " & Motivo))

                Try
                    CMD.ExecuteNonQuery()
                Catch x As Exception
                    MsgBox(x.Message)
                    Exit Sub
                End Try

                MsgBox("Documento cancelado com sucesso.", 64, "Validação de Dados")
                Me.ConfImg.Visible = True
                Me.ConfImg.Text = "Cancelado"
            End If
        Catch err As Exception
            MessageBox.Show(err.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cTipo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cTipo.Leave
        If Me.cTipo.Text = "DOC" Then
            Me.BaseCalcIcms.Enabled = False
            Me.ValorIcms.Enabled = False
            Me.BaseCalcIcmsST.Enabled = False
            Me.ValorBaseCalcIcmsSt.Enabled = False
        Else
            Me.BaseCalcIcms.Enabled = True
            Me.ValorIcms.Enabled = True
            Me.BaseCalcIcmsST.Enabled = True
            Me.ValorBaseCalcIcmsSt.Enabled = True
        End If
    End Sub

    Private Sub ContaLancamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaDespesa.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.ContaDespesa.Text = varPegaConta
            AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaDespesaDesc, True)
            Me.ContaDespesa.Focus()
        End If
    End Sub

    Private Sub btFindValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindValor.Click
        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.ContaDespesa.Text = varPegaConta
        AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaDespesaDesc, True)
        Me.ContaDespesa.Focus()
    End Sub

    Public Sub AchaContaBalancete(ByVal ContaBalancete As String, ByVal CampoParaRetornar As Control, ByVal retErro As Boolean)

        If ContaBalancete = "" Then ContaBalancete = "00000000"

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
            If retErro = True Then
                MessageBox.Show("Conta Inexistente, Favor verificar...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CType(CampoParaRetornar, TextBox).Clear()
                'If CType(CampoParaRetornar, TextBox).Name = "DescConta1" Then Me.Conta1.Focus()
                'If CType(CampoParaRetornar, TextBox).Name = "DescConta2" Then Me.Conta2.Focus()
                'If CType(CampoParaRetornar, TextBox).Name = "DescConta3" Then Me.Conta3.Focus()
                'If CType(CampoParaRetornar, TextBox).Name = "DescConta4" Then Me.Conta4.Focus()
                'If CType(CampoParaRetornar, TextBox).Name = "DescConta5" Then Me.Conta5.Focus()
                'If CType(CampoParaRetornar, TextBox).Name = "DescConta6" Then Me.Conta6.Focus()
                Exit Sub
            End If
        End If
        Cnn.Close()
    End Sub

    Public Sub AchaContaCC(ByVal Conta As String, ByVal CampoParaRetornar As Control)

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

    Private Sub ContaCR_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaDespesa.Leave
        If String.CompareOrdinal(Me.ContaDespesa.Text, Me.ContaDespesa.TextoAntigo) Then
            AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaDespesaDesc, True)
        End If

    End Sub

    Private Sub btFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFornecedor.Click
        TRVDados(UserAtivo, "Fornecedor")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Fornecedor.ShowDialog()
        End If
    End Sub

    Private Sub btEditarContas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditarContas.Click
        If Me.Id.Text = "" Then
            MessageBox.Show("Favor informar o documento para alterar as contas.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Confirmado.Checked = False Then
            Exit Sub
        End If

        'Verificar se algum pagamento do documento foi executado
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM Pagar WHERE Pagar.IdCompraCtrlPedido = " & Me.Id.Text & " AND Pagar.Baixado = True"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader
        Try
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                MessageBox.Show("Já foi feito pagamento para este documento, o documento não pode ser alterado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            CNN.Close()
            Exit Sub

        End Try
        DR.Close()

        Dim HH As DateTime = Now

        Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.Id.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub

            'Dim CodSegurança As String = InformaCodigoSeguranca()

            'If VerificaCodigoSegurança(CodSegurança) = False Then
            '    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            '    Exit Sub
        End If

        My.Forms.PagarLancamentos.ShowDialog()

        'fim
    End Sub

#Region "Códigos para o Lançamento de Contas"

    Private Sub Find1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find1.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta1.Text = varPegaConta
        AchaContaCC(Me.Conta1.Text, Me.DescConta1)
        Me.Conta1.Focus()

    End Sub

    Private Sub Find2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find2.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta2.Text = varPegaConta
        AchaContaCC(Me.Conta2.Text, Me.DescConta2)
        Me.Conta2.Focus()

    End Sub

    Private Sub Find3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find3.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta3.Text = varPegaConta
        AchaContaCC(Me.Conta3.Text, Me.DescConta3)
        Me.Conta3.Focus()

    End Sub

    Private Sub Find4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find4.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta4.Text = varPegaConta
        AchaContaCC(Me.Conta4.Text, Me.DescConta4)
        Me.Conta4.Focus()

    End Sub

    Private Sub Find5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find5.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta5.Text = varPegaConta
        AchaContaCC(Me.Conta5.Text, Me.DescConta5)
        Me.Conta5.Focus()

    End Sub

    Private Sub Find6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find6.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta6.Text = varPegaConta
        AchaContaCC(Me.Conta6.Text, Me.DescConta6)
        Me.Conta6.Focus()

    End Sub

    Private Sub Conta1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta1.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta1.Text = varPegaConta
            AchaContaCC(Me.Conta1.Text, Me.DescConta1)
            Me.Conta1.Focus()
        End If
    End Sub

    Private Sub Conta2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta2.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta2.Text = varPegaConta
            AchaContaCC(Me.Conta2.Text, Me.DescConta2)
            Me.Conta2.Focus()
        End If
    End Sub

    Private Sub Conta3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta3.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta3.Text = varPegaConta
            AchaContaCC(Me.Conta3.Text, Me.DescConta3)
            Me.Conta3.Focus()
        End If
    End Sub

    Private Sub Conta4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta4.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta4.Text = varPegaConta
            AchaContaCC(Me.Conta4.Text, Me.DescConta4)
            Me.Conta4.Focus()
        End If
    End Sub

    Private Sub Conta5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta5.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta5.Text = varPegaConta
            AchaContaCC(Me.Conta5.Text, Me.DescConta5)
            Me.Conta5.Focus()
        End If
    End Sub

    Private Sub Conta6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta6.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta6.Text = varPegaConta
            AchaContaCC(Me.Conta6.Text, Me.DescConta6)
            Me.Conta6.Focus()
        End If
    End Sub

    Private Sub Conta1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Conta1.Validating, Conta2.Validating, Conta3.Validating, Conta4.Validating, Conta5.Validating, Conta6.Validating
        Select Case CType(sender, TextBox).Name
            Case "Conta1"
                If String.CompareOrdinal(Me.Conta1.Text, Me.Conta1.TextoAntigo) Then
                    'AchaContaBalancete(Me.Conta1.Text, Me.DescConta1, True)
                    AchaContaCC(Me.Conta1.Text, Me.DescConta1)
                End If
            Case "Conta2"
                If String.CompareOrdinal(Me.Conta2.Text, Me.Conta2.TextoAntigo) Then
                    'AchaContaBalancete(Me.Conta2.Text, Me.DescConta2, True)
                    AchaContaCC(Me.Conta2.Text, Me.DescConta2)
                End If
            Case "Conta3"
                If String.CompareOrdinal(Me.Conta3.Text, Me.Conta3.TextoAntigo) Then
                    'AchaContaBalancete(Me.Conta3.Text, Me.DescConta3, True)
                    AchaContaCC(Me.Conta3.Text, Me.DescConta3)
                End If
            Case "Conta4"
                If String.CompareOrdinal(Me.Conta4.Text, Me.Conta4.TextoAntigo) Then
                    'AchaContaBalancete(Me.Conta4.Text, Me.DescConta4, True)
                    AchaContaCC(Me.Conta4.Text, Me.DescConta4)
                End If
            Case "Conta5"
                If String.CompareOrdinal(Me.Conta5.Text, Me.Conta5.TextoAntigo) Then
                    'AchaContaBalancete(Me.Conta5.Text, Me.DescConta5, True)
                    AchaContaCC(Me.Conta5.Text, Me.DescConta5)
                End If
            Case "Conta6"
                If String.CompareOrdinal(Me.Conta6.Text, Me.Conta6.TextoAntigo) Then
                    'AchaContaBalancete(Me.Conta6.Text, Me.DescConta6, True)
                    AchaContaCC(Me.Conta6.Text, Me.DescConta6)
                End If
        End Select
    End Sub

    Private Sub LiberarConta1()
        Me.Conta1.Enabled = True
        Me.Conta2.Enabled = False
        Me.Conta3.Enabled = False
        Me.Conta4.Enabled = False
        Me.Conta5.Enabled = False
        Me.Conta6.Enabled = False

        Me.Find1.Enabled = True
        Me.Find2.Enabled = False
        Me.Find3.Enabled = False
        Me.Find4.Enabled = False
        Me.Find5.Enabled = False
        Me.Find6.Enabled = False

        Me.DescConta1.Enabled = True
        Me.DescConta2.Enabled = False
        Me.DescConta3.Enabled = False
        Me.DescConta4.Enabled = False
        Me.DescConta5.Enabled = False
        Me.DescConta6.Enabled = False

        Me.Vlr1.Enabled = True
        Me.Vlr2.Enabled = False
        Me.Vlr3.Enabled = False
        Me.Vlr4.Enabled = False
        Me.Vlr5.Enabled = False
        Me.Vlr6.Enabled = False
    End Sub

    Private Sub Vlr1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vlr1.Leave, Vlr2.Leave, Vlr3.Leave, Vlr4.Leave, Vlr5.Leave, Vlr6.Leave

        Select Case CType(sender, TextBox).Name

            Case "Vlr1"

                If String.CompareOrdinal(Me.Vlr1.Text, Me.Vlr1.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr1.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text))
                        If Resta <> 0 Then
                            If CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr1.Focus()
                                Exit Sub
                            End If

                            Me.Conta2.Enabled = True : Me.DescConta2.Enabled = True : Me.Find2.Enabled = True : Me.Vlr2.Enabled = True
                            Me.Vlr2.Text = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text))
                            Me.Vlr3.Text = FormatNumber(0, 2)
                            Me.Vlr4.Text = FormatNumber(0, 2)
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta2.Focus()
                        Else
                            Me.Conta2.Enabled = False : Me.DescConta2.Enabled = False : Me.Find2.Enabled = False : Me.Vlr2.Enabled = False
                        End If
                    End If
                End If

            Case "Vlr2"
                If String.CompareOrdinal(Me.Vlr2.Text, Me.Vlr2.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr2.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr2.Focus()
                                Exit Sub
                            End If

                            Me.Conta3.Enabled = True : Me.DescConta3.Enabled = True : Me.Find3.Enabled = True : Me.Vlr3.Enabled = True
                            Me.Vlr3.Text = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))
                            Me.Vlr4.Text = FormatNumber(0, 2)
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta3.Focus()
                        Else
                            Me.Conta3.Enabled = False : Me.DescConta3.Enabled = False : Me.Find3.Enabled = False : Me.Vlr3.Enabled = False
                        End If
                    End If
                End If
            Case "Vlr3"
                If String.CompareOrdinal(Me.Vlr3.Text, Me.Vlr3.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr3.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr3.Focus()
                                Exit Sub
                            End If

                            Me.Conta4.Enabled = True : Me.DescConta4.Enabled = True : Me.Find4.Enabled = True : Me.Vlr4.Enabled = True
                            Me.Vlr4.Text = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta4.Focus()
                        Else
                            Me.Conta4.Enabled = False : Me.DescConta4.Enabled = False : Me.Find4.Enabled = False : Me.Vlr4.Enabled = False
                        End If
                    End If
                End If
            Case "Vlr4"
                If String.CompareOrdinal(Me.Vlr4.Text, Me.Vlr4.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr4.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr4.Focus()
                                Exit Sub
                            End If

                            Me.Conta5.Enabled = True : Me.DescConta5.Enabled = True : Me.Find5.Enabled = True : Me.Vlr5.Enabled = True
                            Me.Vlr5.Text = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta5.Focus()
                        Else
                            Me.Conta5.Enabled = False : Me.DescConta5.Enabled = False : Me.Find5.Enabled = False : Me.Vlr5.Enabled = False
                        End If
                    End If
                End If
            Case "Vlr5"
                If String.CompareOrdinal(Me.Vlr5.Text, Me.Vlr5.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr5.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr5.Focus()
                                Exit Sub
                            End If

                            Me.Conta6.Enabled = True : Me.DescConta6.Enabled = True : Me.Find6.Enabled = True : Me.Vlr6.Enabled = True
                            Me.Vlr6.Text = CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))
                            Me.Conta6.Focus()
                        Else
                            Me.Conta6.Enabled = False : Me.DescConta6.Enabled = False : Me.Find6.Enabled = False : Me.Vlr6.Enabled = False
                        End If
                    End If
                End If
            Case "Vlr6"
                If (CDbl(NzZero(Me.ValorPedido.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text)) - CDbl(NzZero(Me.Vlr6.Text))) < 0 Then
                    MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Vlr6.Focus()
                    Exit Sub
                End If

        End Select


        If CDbl(NzZero(Me.ValorPedido.Text)) < (CDbl(NzZero(Me.Vlr1.Text)) + CDbl(NzZero(Me.Vlr2.Text)) + CDbl(NzZero(Me.Vlr3.Text)) + CDbl(NzZero(Me.Vlr4.Text)) + CDbl(NzZero(Me.Vlr5.Text)) + CDbl(NzZero(Me.Vlr6.Text))) Then
            MessageBox.Show("O Valor dos Lançamentos esta maior que o valor do Pedido, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CType(sender, TextBox).Focus()
            Exit Sub
        End If
    End Sub

#End Region

    Private Sub NotaFiscal_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaFiscal.Enter
        If String.IsNullOrEmpty(Me.NotaFiscal.Text) Then
            Me.NotaFiscal.Text = vNumeroDoc
        End If
    End Sub

    Private Sub Vlr1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vlr1.Enter
        Me.Vlr1.Text = FormatCurrency(Me.ValorPedido.Text)
    End Sub
End Class