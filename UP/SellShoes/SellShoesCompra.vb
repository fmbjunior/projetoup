
Public Class SellShoesCompra

    Dim AlteraItens As Boolean = False
    Public varPegaConta As String = String.Empty
    Dim CodigoPlanoContasFornecedor As String = ""
    Dim ValorProdutosLaçamentos As Double
    Dim ValorIpiLancamentos As Double
    Dim AliquotaFrete As Double

    Dim VlrListaDevolucao As Double

    Dim ChecaPedido As Boolean = False
    Dim LancamentoRetroativo As Boolean = False
    Dim IdItem As Integer
    Public CancelouPagar As Boolean

    Dim T As Double

    Dim Ação As New TrfGerais()

    Private OperationItens As Byte
    Public Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim clsPC As New clsPedidoCompra         'vareavel para implementação dos dados do pedido de compra





    Private Sub FecharBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click

        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub AddItem(ByVal xcod As Integer, ByVal xQtd As Double, ByVal xVlrU As Double, ByVal xTotP As Double, ByVal xIpi As Double, ByVal xVipi As Double, ByVal xCId As Integer)


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "INSERT INTO ItensCompra ( CodigoProduto, Qtd, ValorUnitario, TotalProduto, Ipi, ValorIpi, CompraInterno) VALUES (@1, @2, @3, @4, @5, @6, @7)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", xcod))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", xQtd))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", xVlrU))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", xTotP))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", xIpi))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", xVipi))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", xCId))

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro adicionado com sucesso", 64, "Validador de Dados")
            CNN.Close()
            EncheListaItens()
            OperationItens = INS
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validador de Dados")
        End Try

    End Sub


    Public Sub NovoBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click


        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)

        Me.RazaoSocial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CompraInterno.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim

        'Limpar controle do Container

        Me.ValorCompra.Clear()
        Me.BaseCalcIcms.Clear()
        Me.ValorIcms.Clear()

        Me.BaseCalcIpi.Clear()
        Me.VlrIpi.Clear()
        Me.TotalProdutos.Clear()

        Me.cTipo.Text = ""
        Me.TpEntrada.Text = ""
        Me.Confirmado.Checked = False
        Me.VlrIpi.Clear()
        Me.DevolucaoTab.Visible = False
        Me.PedidoCompra.ReadOnly = False

        Me.TabGeral.SelectedTab = Me.TabItens



        Me.TotalItensLançado.Clear()
        Me.TotalItensIpi.Clear()
        Me.TotalItensIpi.Clear()

        Ação.Desbloquear_Controle(Me, True)
        BloquearCtrlExtras(True)
        DesativaLancamentoItens(False)
        Me.AdicionarItens.Enabled = True
        Me.ConfImg.Visible = False
        Me.SalvarBT.Enabled = True

        Me.PainelDev.Visible = False

        Operation = INS

        Me.TabGeral.SelectedTab = Me.TabItens

        Me.PedidoCompra.Focus()
        AtGrade()
        MostraPagar()
    End Sub

    Private Sub CódigoFornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoFornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Razão Social", "Cnpj/Cpf", "Fornecedor", "CódigoFornecedor", "RazãoSocial", "CgcCpf", True)
            Me.CodigoFornecedor.Text = RetornoProcura
            Me.DataCompra.Focus()

        End If
    End Sub

    Public Sub LocalizaFornecedor()
        If Me.CodigoFornecedor.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM Fornecedor WHERE CódigoFornecedor=" & Me.CodigoFornecedor.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.RazaoSocial.Text = DR.Item("RazãoSocial") & ""
            Else
                MsgBox("Verifique os dados do fornecedor, ou fornecedor não existe no cadastro.", 64, "Validador de Dados")
                Exit Sub
            End If
            DR.Close()
            CNN.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub Compra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F7 Then
            If Operation = UPD Then
                Me.TabGeral.SelectedTab = Me.TabItens
                AdicionarItens_Click(sender, e)
                Me.BaseCalcIcms.Focus()
            End If
        End If
    End Sub
    Public Sub AtGrade()

         Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String = "SELECT ItensCompra.Id, ItensCompra.CompraInterno, ItensCompra.CodigoProduto, ItensCompra.Tamanho, Produtos.Descrição, ItensCompra.Qtd, ItensCompra.ValorUnitario, ItensCompra.TotalProduto, ItensCompra.CFOP, ItensCompra.SeqNf, ItensCompra.ValorIPI, ItensCompra.ValorPisProduto, ItensCompra.ValorCofinsProduto FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE ItensCompra.CompraInterno=" & NzZero(Me.CompraInterno.Text) & " Order By ItensCompra.ID"


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet

        Try


            Da.Fill(ds, "Table")

            Me.dgv.DataSource = ds.Tables("Table").DefaultView
            Me.TotalItensLançado.Text = FormatCurrency(NzZero(ds.Tables(0).Compute("SUM(TotalProduto)", "")), 2)
            Me.TotalItensIpi.Text = FormatCurrency(NzZero(ds.Tables(0).Compute("SUM(ValorIPI)", "")), 2)
            Me.TotalPis.Text = FormatCurrency(NzZero(ds.Tables(0).Compute("SUM(ValorPisProduto)", "")), 2)
            Me.TotalCofins.Text = FormatCurrency(NzZero(ds.Tables(0).Compute("SUM(ValorCofinsProduto)", "")), 2)

            Da.Dispose()
            CNN.Close()
        Catch ex As Exception
            Da.Dispose()
            CNN.Close()
        End Try
    End Sub
    Private Sub Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LocalizarBT.Enabled = True

        Ação.Desbloquear_Controle(Me, False)


        'Dim Tab As DevComponents.DotNetBar.TabItem = Me.TabItem1
        Me.TabGeral.SelectedTab = Me.TabItens
    End Sub

    Private Sub CódigoFornecedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoFornecedor.Leave
        LocalizaFornecedor()

    End Sub

    Private Sub EditarBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click

        If Me.CompraInterno.Text = "" Then
            MsgBox("No existe Entrada para ser editado.", 64, "Validador de Dados")
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este lançamento ja foi confirmado e não pode ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Inativo.Checked = True Then
            MsgBox("Este registro esta cancelado, não pode ser alterado.", 64, "Validador de Dados")
            Exit Sub
        Else
            If Me.Confirmado.Checked = False Then
                Operation = UPD
                Ação.Desbloquear_Controle(Me, True)
                BloquearCtrlExtras(True)
                Me.AdicionarItens.Enabled = True
                Me.NotaFiscal.Focus()
                If NzZero(Me.PedidoCompra.Text) > 0 Then
                    Me.PedidoCompra.ReadOnly = True
                    Me.CodigoFuncionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                    Me.CodigoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Else
                    Me.PedidoCompra.ReadOnly = True
                    Me.CodigoFuncionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                    Me.CodigoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                End If


            Else

                Dim HH As DateTime = Now
                Dim CodSegurança As String = InputBox("Este registro já foi confirmado, não pode ser alterado ou informe o Código de Segurança para Alteração", "Validador de Dados", 0)

                If VerificaCodigoSegurança(CodSegurança) = False Then
                    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validador de Dados")
                    BloquearCtrlExtras(False)
                    Exit Sub
                Else
                    Operation = UPD
                    Ação.Desbloquear_Controle(Me, True)
                    BloquearCtrlExtras(True)

                    Me.Confirmado.Enabled = False
                    Me.ConfImg.Visible = False
                    Me.SalvarBT.Enabled = True
                    Me.AdicionarItens.Enabled = True
                    Me.NotaFiscal.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub CodigoFuncionario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoFuncionario.Enter
        If Me.CodigoFuncionario.Text = "" Then
            Me.CodigoFuncionario.Text = VarCodFunc
            Me.FuncionarioDesc.Text = VarNomFunc
        End If
    End Sub

    Private Sub CodigoFuncionario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoFuncionario.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", False)
            Me.CodigoFuncionario.Text = RetornoProcura
            Ação.Descrição_ItenRegistro(Me.CodigoFuncionario, Me.FuncionarioDesc, "Funcionários", "CódigoFuncionário", Me.CodigoFuncionario.Text, "Nome", TrfGerais.TipoDados.Numérico, False)
        End If
    End Sub

    Private Sub CodigoFuncionario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoFuncionario.Leave
        If Me.CodigoFuncionario.TextoAntigo <> Me.CodigoFuncionario.Text Then
            Ação.Descrição_ItenRegistro(Me.CodigoFuncionario, Me.FuncionarioDesc, "Funcionários", "CódigoFuncionário", Me.CodigoFuncionario.Text, "Nome", TrfGerais.TipoDados.Numérico, False)
        End If
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Area destinada para as validacoes
        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este lançamento ja foi confirmado e não pode ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.NotaFiscal.Text = "" Then
            If MsgBox("O Numero da Nota fiscal não foi informado." & Chr(13) & "Deseja que o sistema complete o com a palavra chave [DOC]?.", 36, "Validador de Dados") = MsgBoxResult.Yes Then
                Me.NotaFiscal.Focus()
                Me.NotaFiscal.Text = "DOC"
                Exit Sub
            Else
                Me.NotaFiscal.Focus()
            End If
        ElseIf Me.DataCompra.Text = "" Then
            MsgBox("A data da compra não foi informado, favor verificar.", 64, "Validador de Dados")
            Me.DataCompra.Focus()
            Exit Sub
        ElseIf Me.DataEntrada.Text = "" Then
            MsgBox("A data da entrada não foi informado, favor verificar.", 64, "Validador de Dados")
            Me.DataEntrada.Focus()
            Exit Sub
        ElseIf Me.DataLancamento.Text = "" Then
            MsgBox("A data de lançamento não foi informado, favor verificar.", 64, "Validador de Dados")
            Me.DataLancamento.Focus()
            Exit Sub
        ElseIf Me.CodigoFornecedor.Text = "" Then
            MsgBox("O fornecedor da nota fiscal não foi informado", 64, "Validador de Dados")
            Me.CodigoFornecedor.Focus()
            Exit Sub
        ElseIf Me.CodigoFuncionario.Text = "" Then
            MsgBox("O Funcionário não foi informado", 64, "Validador de Dados")
            Me.CodigoFuncionario.Focus()
            Exit Sub
        ElseIf NzZero(Me.ValorCompra.Text) = 0 Then
            MsgBox("O valor da compra não foi informado", 64, "Validador de Dados")
            Me.ValorCompra.Focus()
            Exit Sub
        ElseIf Me.cTipo.Text = "" Then
            MsgBox("O Tipo de Lançamento não foi informado", 64, "Validador de Dados")
            Me.cTipo.Focus()
            Exit Sub
        ElseIf CDate(Me.DataCompra.Text) > CDate(Me.DataLancamento.Text) Then
            MsgBox("A data de Emissão não pode ser maior que a data de lançamento.", 64, "Validador de Dados")
            Me.DataCompra.Focus()
            Exit Sub
        ElseIf CDate(Me.DataEntrada.Text) > CDate(Me.DataLancamento.Text) Then
            MsgBox("A data de Entrada não pode ser maior que a data de lançamento.", 64, "Validador de Dados")
            Me.DataEntrada.Focus()
            Exit Sub
        End If


        If Me.TpEntrada.Text = "DEVOLUÇÃO" Then

            Dim VlrUsarDev As Double = (CDbl(NzZero(NFdevMaeValor.Text)) - CDbl(NzZero(VlrListaDevolucao)))

            If CDbl(NzZero(Me.ValorCompra.Text)) > CDbl(VlrUsarDev) Then
                Dim MsgErr As String = String.Empty
                MsgErr = "Verifique os valore para devolução, o valor informado é maior que o restante a ser devolvido" & vbNewLine & vbNewLine & vbNewLine
                MsgErr = MsgErr & "Valor já Devolvido.....: " & FormatNumber(CDbl(NzZero(VlrListaDevolucao)), 2) & vbNewLine
                MsgErr = MsgErr & "Valor a ser Devolvido.: " & FormatNumber((CDbl(NzZero(NFdevMaeValor.Text)) - CDbl(NzZero(VlrListaDevolucao))), 2)

                MessageBox.Show(MsgErr, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If


        If CDate(Me.DataEntrada.Text) < CDate(Me.DataCompra.Text) Then
            MessageBox.Show("A data de entrada não pode ser menor que a data de emissão.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DataCompra.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

        If Me.TpEntrada.Text = "" Then
            MessageBox.Show("O Usuário deve informar se o documento é [ENTRADA] [DEVOLUÇÃO]", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TpEntrada.Focus()
            Exit Sub
        End If

        If Me.TpEntrada.Text = "DEVOLUÇÃO" Then
            If Me.IdNFdevMae.Text = "" Then
                MessageBox.Show("O Usuário deve informar se o documento de [DEVOLUÇÃO]", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.NFdevMae.Focus()
                Exit Sub
            End If
        End If


        If Me.CompraInterno.Text = "" Then
            Operation = INS
        Else
            Operation = UPD
        End If

        If Operation = INS Then

            UltimoReg()

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "INSERT INTO Compra (CompraInterno, NotaFiscal, DataCompra, DataEntrada, CodigoFornecedor, Obs, CodigoFuncionario, ValorCompra, BaseCalcIcms, ValorIcms, BaseCalcIpi, ValorIpi, tipo, Empresa, Confirmado, TotalProdutos, DataLançamento, ValorFrete, ValorOutros, TpEntrada, IdNFdevMae, NFdevMae, NFdevMaeValor, PedidoCompra) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @25)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CompraInterno.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataCompra.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataEntrada.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.CodigoFornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Obs.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.CodigoFuncionario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorCompra.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.BaseCalcIcms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.ValorIcms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.BaseCalcIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.VlrIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.cTipo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", False))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.TotalProdutos.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", NzZero(Me.ValorFrete.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", NzZero(Me.ValorOutros.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Me.TpEntrada.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.IdNFdevMae.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.NFdevMae.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.NFdevMaeValor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.PedidoCompra.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
                'CarregaPedidoCompra()
                MsgBox("Registro adicionado com sucesso", 64, "Validador de Dados")
                CNN.Close()
                Operation = UPD

            Catch ex As OleDb.OleDbException
                MsgBox(ex.Message, 64, "Validador de Dados")
            End Try

        ElseIf Operation = UPD Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update Compra set NotaFiscal = @2, DataCompra = @3, DataEntrada = @4, CodigoFornecedor = @5, Obs = @6, CodigoFuncionario = @7, ValorCompra = @8, BaseCalcIcms = @9, ValorIcms = @10, BaseCalcIpi = @11, ValorIpi = @12, Tipo = @13, Empresa = @14, Confirmado = @15, TotalProdutos = @16, DataLançamento = @17, ValorFrete = @18, ValorOutros = @19, TpEntrada = @20, IdNFdevMae = @21, NFdevMae = @22, NFdevMaeValor = @23, PedidoCompra=@25 Where CompraInterno = " & Me.CompraInterno.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)


            cmd.Parameters.AddWithValue("@2", Nz(Me.NotaFiscal.Text, 1))
            cmd.Parameters.AddWithValue("@3", Nz(Me.DataCompra.Text, 1))
            cmd.Parameters.AddWithValue("@4", Nz(Me.DataEntrada.Text, 1))
            cmd.Parameters.AddWithValue("@5", Nz(Me.CodigoFornecedor.Text, 1))
            cmd.Parameters.AddWithValue("@6", Nz(Me.Obs.Text, 1))
            cmd.Parameters.AddWithValue("@7", Nz(Me.CodigoFuncionario.Text, 1))
            cmd.Parameters.AddWithValue("@8", Nz(Me.ValorCompra.Text, 1))
            cmd.Parameters.AddWithValue("@9", Nz(Me.BaseCalcIcms.Text, 1))
            cmd.Parameters.AddWithValue("@10", Nz(Me.ValorIcms.Text, 1))
            cmd.Parameters.AddWithValue("@11", Nz(Me.BaseCalcIpi.Text, 1))
            cmd.Parameters.AddWithValue("@12", Nz(Me.VlrIpi.Text, 1))
            cmd.Parameters.AddWithValue("@13", Nz(Me.cTipo.Text, 1))
            cmd.Parameters.AddWithValue("@14", CodEmpresa)
            cmd.Parameters.AddWithValue("@15", False)
            cmd.Parameters.AddWithValue("@16", Nz(Me.TotalProdutos.Text, 1))
            cmd.Parameters.AddWithValue("@17", Nz(Me.DataLancamento.Text, 1))
            cmd.Parameters.AddWithValue("@18", NzZero(Me.ValorFrete.Text))
            cmd.Parameters.AddWithValue("@19", NzZero(Me.ValorOutros.Text))
            cmd.Parameters.AddWithValue("@20", Me.TpEntrada.Text)
            cmd.Parameters.AddWithValue("@21", Nz(Me.IdNFdevMae.Text, 1))
            cmd.Parameters.AddWithValue("@22", Nz(Me.NFdevMae.Text, 1))
            cmd.Parameters.AddWithValue("@23", Nz(Me.NFdevMaeValor.Text, 1))
            cmd.Parameters.AddWithValue("@25", Nz(Me.PedidoCompra.Text, 1))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validador de Dados")
                CNN.Close()

                Operation = UPD

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
        End If

    End Sub


    Public Sub UltimoReg()
        'Inserir ultimo registro

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "Select max(CompraInterno) from Compra"
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
            CNN.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        Me.CompraInterno.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub

    Private Sub DesativaLancamentoItens(ByVal TrueFalse As Boolean)
        Me.TotalItensLançado.Enabled = TrueFalse
        Me.TotalItensIpi.Enabled = TrueFalse
        Me.TotalPis.Enabled = TrueFalse
        Me.TotalCofins.Enabled = TrueFalse
    End Sub

    Private Sub LocalizarBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        AlteraItens = False
        Me.TotalItensLançado.Clear()
        Ação.Desbloquear_Controle(Me, False)
        RetornoProcura = ""
        SellShoesCompraProcurar.ShowDialog()
        LocalizaDados()
        AtGrade()
        MostraPagar()
        Me.TabGeral.Enabled = True
        BloquearCtrlExtras(False)

        Operation = UPD

        If Me.Confirmado.Checked = False Then
            Ação.Desbloquear_Controle(Me, False)
            Me.TabGeral.Enabled = True
            BloquearCtrlExtras(False)
        End If

    End Sub

    Public Sub LocalizaDados()

        If RetornoProcura = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Compra.*, Compra.CompraInterno, Funcionários.Nome, Fornecedor.RazãoSocial FROM (Compra INNER JOIN Funcionários ON Compra.CodigoFuncionario = Funcionários.CódigoFuncionário) INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((Compra.CompraInterno)=" & RetornoProcura & "))"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader
        Try
            DR = CMD.ExecuteReader
            DR.Read()


            Me.CompraInterno.Text = DR.Item("Compra.CompraInterno") & ""
            Me.PedidoCompra.Text = DR.Item("PedidoCompra") & ""
            Me.NotaFiscal.Text = DR.Item("NotaFiscal") & ""
            Me.DataCompra.Text = DR.Item("DataCompra") & ""
            Me.DataEntrada.Text = DR.Item("DataEntrada") & ""
            Me.DataLancamento.Text = DR.Item("DataLançamento") & ""


            Me.CodigoFornecedor.Text = DR.Item("CodigoFornecedor") & ""
            Me.RazaoSocial.Text = DR.Item("RazãoSocial") & ""
            Me.Obs.Text = DR.Item("Obs") & ""
            Me.CodigoFuncionario.Text = DR.Item("CodigoFuncionario") & ""
            Me.FuncionarioDesc.Text = DR.Item("Nome") & ""

            Me.ValorCompra.Text = FormatCurrency(Nz(DR.Item("ValorCompra"), 3), 2)
            Me.TotalProdutos.Text = FormatCurrency(Nz(DR.Item("TotalProdutos"), 3), 2)
            Me.BaseCalcIcms.Text = FormatCurrency(Nz(DR.Item("BaseCalcIcms"), 3), 2)
            Me.ValorIcms.Text = FormatCurrency(Nz(DR.Item("ValorIcms"), 3), 2)
            Me.BaseCalcIpi.Text = FormatCurrency(Nz(DR.Item("BaseCalcIpi"), 3), 2)
            Me.ValorOutros.Text = FormatCurrency(Nz(DR.Item("ValorOutros"), 3), 2)

            Me.VlrIpi.Text = DR.Item("ValorIpi") & ""
            Me.cTipo.Text = DR.Item("Tipo") & ""

            Me.ValorFrete.Text = FormatCurrency(Nz(DR.Item("ValorFrete"), 3), 2)
            Me.Confirmado.Checked = DR.Item("Confirmado")
            Me.Inativo.Checked = DR.Item("Inativo")


            Me.TpEntrada.Text = DR.Item("TpEntrada") & ""

            Me.IdNFdevMae.Text = DR.Item("IdNFdevMae") & ""
            Me.NFdevMae.Text = DR.Item("NFdevMae") & ""
            Me.NFdevMaeValor.Text = FormatCurrency(Nz(DR.Item("NFdevMaeValor"), 3), 2)


            Operation = UPD
            DR.Close()
            CNN.Close()

            If Me.TpEntrada.Text = "DEVOLUÇÃO" Then
                Me.PainelDev.Visible = True
                ListaDevolucao()
            Else
               
            End If




        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNN.Close()
                Exit Sub
            End If
        End Try

        If Me.Inativo.Checked = True Then
            BloquearCtrlExtras(False)
            MsgBox("Este registro esta cancelado, não pode ser alterado.", 64, "Validador de Dados")
            ConfImg.Visible = True
            Me.ConfImg.Text = "Cancelado"
            Exit Sub
        Else
            If Me.Confirmado.Checked = True Then
                Me.ConfImg.Visible = True
                Me.ConfImg.Text = "Lanç. Confirmado"
                BloquearCtrlExtras(False)
                Me.AdicionarItens.Enabled = False
                MsgBox("Este registro já foi confirmado, não pode ser alterado.", 64, "Validador de Dados")
                Exit Sub
            Else
                Me.ConfImg.Visible = False
                Me.ConfImg.Text = "Lanç. Confirmado"
                BloquearCtrlExtras(False)
                Me.AdicionarItens.Enabled = False
                Exit Sub
            End If
        End If
    End Sub



    Private Sub BaseCalcIpi_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BaseCalcIpi.Enter
        If Me.BaseCalcIpi.Text = "" Then Me.BaseCalcIpi.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub BaseCalcIpi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BaseCalcIpi.Leave
        If Me.BaseCalcIpi.Text = "" Then
            Me.BaseCalcIpi.Text = FormatCurrency(0, 2)
        End If
    End Sub


    Public Sub EncheListaItens()
        'If Me.CompraInterno.Text = "" Then
        '    Exit Sub
        'End If



        'MyLista.Items.Clear()


        'Dim tPis As Double = 0
        'Dim tCOFINS As Double = 0
        'ValorIpiLancamentos = 0

        'Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        'CNN.Open()

        'Dim Cmd As New OleDb.OleDbCommand()
        'Dim DataReader As OleDb.OleDbDataReader

        'With Cmd
        '    .Connection = CNN
        '    .CommandTimeout = 0
        '    .CommandText = "SELECT Produtos.Descrição, * FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE ItensCompra.CompraInterno = " & Me.CompraInterno.Text & " "
        '    .CommandType = CommandType.Text
        'End With

        'Try
        '    DataReader = Cmd.ExecuteReader

        '    ValorProdutosLaçamentos = 0

        '    Dim VlrFrete As Double = 0

        '    Dim Zebrar As Boolean = False
        '    While DataReader.Read
        '        If Not IsDBNull(DataReader.Item("Id")) Then
        '            Dim AA As String = DataReader.Item("Id")
        '            Dim item1 As New ListViewItem(AA, 0)

        '            item1.SubItems.Add(DataReader.Item("ItensCompra.CodigoProduto") & "")
        '            item1.SubItems.Add(DataReader.Item("Descrição") & "")
        '            item1.SubItems.Add(FormatNumber(DataReader.Item("Qtd"), 2))
        '            item1.SubItems.Add(Nz(DataReader.Item("SeqNf"), 2))
        '            item1.SubItems.Add(FormatNumber(DataReader.Item("ValorUnitario"), 5))
        '            item1.SubItems.Add(FormatNumber(DataReader.Item("TotalProduto"), 2))
        '            item1.SubItems.Add(DataReader.Item("CFOP") & "")
        '            MyLista.Items.AddRange(New ListViewItem() {item1})

        '            ValorProdutosLaçamentos += CDbl(DataReader.Item("TotalProduto"))
        '            ValorIpiLancamentos += CDbl(DataReader.Item("ValorIpi"))
        '            tPis += CDbl(NzZero(DataReader.Item("ValorPisProduto")))
        '            tCOFINS += CDbl(NzZero(DataReader.Item("ValorCofinsProduto")))

        '            If Zebrar = True Then
        '                MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
        '                Zebrar = False
        '            Else
        '                MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
        '                Zebrar = True
        '            End If

        '        End If
        '    End While
        '    Me.TotalItensLançado.Text = FormatNumber(ValorProdutosLaçamentos, 2)
        '    Me.TotalItensIpi.Text = FormatNumber(ValorIpiLancamentos, 2)
        '    Me.TotalPis.Text = FormatNumber(tPis, 2)
        '    Me.TotalCofins.Text = FormatNumber(tCOFINS, 2)
        '    Me.TotalProdutos.Text = FormatNumber(NzZero(Me.TotalItensLançado.Text) + NzZero(ValorIpiLancamentos) + NzZero(Me.ValorOutros.Text), 2)

        '    DataReader.Close()
        '    CNN.Close()
        '    Me.MyLista.Refresh()

        'Catch Merror As System.Exception
        '    MsgBox(Merror.ToString)
        '    If ConnectionState.Open Then
        '        Exit Sub
        '    End If
        'End Try
    End Sub

    Private Sub ConfirmarBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarBT.Click

        If Me.Inativo.Checked = True Then
            MsgBox("Esta NF está cancelada não será possível confirmá-la.", 48, "Validação de dados")
            Return
        End If
        If Operation = INS Then
            MsgBox("O usuário deve salvar o documento antes de confirmar.", 64, "Validador de Dados")
            Exit Sub
        End If

        If Me.ValorCompra.Text = 0 Or Me.ValorCompra.Text = "" Then
            MsgBox("O campo [TOTAL NOTA FISCAL] está com valor [0,00]", 48, "Validador de Dados")
            Me.ValorCompra.Focus()
            Exit Sub

        End If
        If Me.TotalProdutos.Text = 0 Or Me.TotalProdutos.Text = "" Then
            MsgBox("O campo [VALOR PRODUTOS] está com valor [0,00]", 48, "Validador de Dados")
            Me.TotalProdutos.Focus()
            Exit Sub

        End If


        If FormatNumber(CDbl(NzZero(Me.TotalProdutos.Text)) + CDbl(NzZero(Me.ValorBaseCalcIcmsST.Text)) + CDbl(NzZero(Me.VlrIpi.Text)) + CDbl(NzZero(Me.ValorFrete.Text)) + CDbl(NzZero(Me.ValorOutros.Text)), 2) <> FormatNumber(CDbl(NzZero(Me.ValorCompra.Text)), 2) Then
            MessageBox.Show("Os valores do lançamento não conferem, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MsgBox("Deseja realmente confirmar o lançamento de entrada.", 36, "Validador de Dados") = 6 Then
            If Me.DataLancamento.Text <> DataDia Then
                If MsgBox("A data de Lançamento esta diferente da data do dia deseja continuar com esta data.", 36, "Validador de Dados") = 6 Then
                    'nada a fazer continuar com a data 
                Else
                    Me.DataLancamento.Text = DataDia
                End If
            End If

            If Me.dgv.Rows.Count = 0 Then
                MsgBox("ATENÇÃO!!! Não há itens lançado para esta compra." & Chr(13) & "A Compra só será possível confirmar após o lançamento de um ou mais itens, Verifique.", 48, "Validador de Dados")
                Exit Sub
            End If

            If Me.Confirmado.Checked = True Then
                MsgBox("Este pedido de compra ja foi confirmado, Verifique.", 64, "Validador de Dados")
                Exit Sub
            End If

            If DataDia = Nothing Then
                MsgBox("Não foi informado a data do dia, talvez tenha que reinicializar o sistema.", 64, "Validador de Dados")
                Exit Sub
            ElseIf Me.NotaFiscal.Text = "" Then
                MsgBox("O Numero da Nota fiscal não foi informado, favor verificar.", 64, "Validador de Dados")
                Me.NotaFiscal.Focus()
                Exit Sub
            ElseIf Me.DataCompra.Text = "" Then
                MsgBox("A data da compra não foi informado, favor verificar.", 64, "Validador de Dados")
                Me.DataCompra.Focus()
                Exit Sub
            ElseIf Me.ValorCompra.Text = "" Then
                MsgBox("O valor da compra não foi informado", 64, "Validador de Dados")
                Me.ValorCompra.Focus()
                Exit Sub
            End If


            'Confirmar a Compra


            Me.Cursor = Cursors.WaitCursor
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim myTrans As OleDb.OleDbTransaction = CNN.BeginTransaction

            Dim Sql As String = "Update Compra set NotaFiscal = @2, DataCompra = @3, DataEntrada = @4, CodigoFornecedor = @5, Obs = @6, CodigoFuncionario = @7, ValorCompra = @8, BaseCalcIcms = @9, ValorIcms = @10, BaseCalcIpi = @11, ValorIpi = @12, Tipo = @13, Empresa = @14, Confirmado = @15, TotalProdutos = @16, DataLançamento = @17, ValorFrete = @18, ValorOutros = @19, TpEntrada = @20 Where CompraInterno = " & Me.CompraInterno.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN, myTrans)
            Try

                cmd.Parameters.AddWithValue("@2", Nz(Me.NotaFiscal.Text, 1))
                cmd.Parameters.AddWithValue("@3", Nz(Me.DataCompra.Text, 1))
                cmd.Parameters.AddWithValue("@4", Nz(Me.DataEntrada.Text, 1))
                cmd.Parameters.AddWithValue("@5", Nz(Me.CodigoFornecedor.Text, 1))
                cmd.Parameters.AddWithValue("@6", Nz(Me.Obs.Text, 1))
                cmd.Parameters.AddWithValue("@7", Nz(Me.CodigoFuncionario.Text, 1))
                cmd.Parameters.AddWithValue("@8", Nz(Me.ValorCompra.Text, 1))
                cmd.Parameters.AddWithValue("@9", Nz(Me.BaseCalcIcms.Text, 1))
                cmd.Parameters.AddWithValue("@10", Nz(Me.ValorIcms.Text, 1))
                cmd.Parameters.AddWithValue("@11", Nz(Me.BaseCalcIpi.Text, 1))
                cmd.Parameters.AddWithValue("@12", Nz(Me.VlrIpi.Text, 1))
                cmd.Parameters.AddWithValue("@13", Nz(Me.cTipo.Text, 1))
                cmd.Parameters.AddWithValue("@14", CodEmpresa)
                cmd.Parameters.AddWithValue("@15", True)
                cmd.Parameters.AddWithValue("@16", Nz(Me.TotalProdutos.Text, 1))
                cmd.Parameters.AddWithValue("@17", Nz(Me.DataLancamento.Text, 1))
                cmd.Parameters.AddWithValue("@18", NzZero(Me.ValorFrete.Text))
                cmd.Parameters.AddWithValue("@19", NzZero(Me.ValorOutros.Text))
                cmd.Parameters.AddWithValue("@20", Me.TpEntrada.Text)

                cmd.ExecuteNonQuery()


                'Atualiza table estoqueup
                If Me.TpEntrada.Text = "ENTRADA" Then
                    Dim SqlEstUP As String = ""
                    If Me.cTipo.Text = "DOC" Then
                        SqlEstUP = "INSERT INTO EstoqueUp (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc, Numero ) SELECT ItensCompra.CodigoProduto, (ItensCompra.Qtd), 'E' AS Expr1, 0 AS Expr2, Compra.DataLançamento, Compra.CompraInterno, 'COMPRA' AS Expr3, '" & Me.RazaoSocial.Text & "' AS Expr4, '" & Me.NotaFiscal.Text & "' As Expr5, ItensCompra.Tamanho FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Compra.Empresa)=" & CodEmpresa & "));"
                    Else
                        SqlEstUP = "INSERT INTO EstoqueUp (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc, QtdF, Numero ) SELECT ItensCompra.CodigoProduto, (ItensCompra.Qtd), 'E' AS Expr1, 0 AS Expr2, Compra.DataLançamento, Compra.CompraInterno, 'COMPRA' AS Expr3, '" & Me.RazaoSocial.Text & "' AS Expr4, '" & Me.NotaFiscal.Text & "' As Expr5, (ItensCompra.Qtd * ItensCompra.ConversorQtd), ItensCompra.Tamanho FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Compra.Empresa)=" & CodEmpresa & "));"
                    End If

                    Using cmdEU As New OleDb.OleDbCommand(SqlEstUP, CNN, myTrans)
                        cmdEU.ExecuteNonQuery()
                    End Using



                    'Atualiza da data da ultima compra na tabela Produtos
                    Sql = "UPDATE (Produtos INNER JOIN ItensCompra ON Produtos.CodigoProduto = ItensCompra.CodigoProduto) INNER JOIN Compra ON ItensCompra.CompraInterno = Compra.CompraInterno SET Produtos.ValorCompra = [ItensCompra].[ValorUnitario], Produtos.ValorP = [ItensCompra].[ValorP], Produtos.DataUltimaCompra = [Compra].[DataCompra] WHERE (((Compra.CompraInterno)=" & Me.CompraInterno.Text & "));"
                    Dim cmd0 As New OleDb.OleDbCommand(Sql, CNN, myTrans)
                    cmd0.ExecuteNonQuery()
                Else
                    'Devolução 
                    If Me.cTipo.Text = "DOC" Then
                        Sql = "INSERT INTO EstoqueUp (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc, Numero ) SELECT ItensCompra.CodigoProduto, (ItensCompra.Qtd * -1), 'D' AS Expr1, 0 AS Expr2, Compra.DataLançamento, Compra.CompraInterno, 'DEVOLUCAO' AS Expr3, '" & Me.RazaoSocial.Text & "' AS Expr4, '" & Me.NotaFiscal.Text & "' As Expr5, ItensCompra.Tamanho FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Compra.Empresa)=" & CodEmpresa & "));"
                    Else
                        Sql = "INSERT INTO EstoqueUp (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc, QtdF, Numero ) SELECT ItensCompra.CodigoProduto, (ItensCompra.Qtd * -1), 'D' AS Expr1, 0 AS Expr2, Compra.DataLançamento, Compra.CompraInterno, 'DEVOLUCAO' AS Expr3, '" & Me.RazaoSocial.Text & "' AS Expr4, '" & Me.NotaFiscal.Text & "' As Expr5, (ItensCompra.Qtd * ItensCompra.ConversorQtd), ItensCompra.Tamanho FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Compra.Empresa)=" & CodEmpresa & "));"
                    End If

                    Dim cmdDev As New OleDb.OleDbCommand(Sql, CNN, myTrans)
                    cmdDev.ExecuteNonQuery()
                End If

                'Here begins to update inventory
                If Me.TpEntrada.Text = "ENTRADA" Then
                    'create objct dataset
                    Dim dsEstGeral As New DataSet()

                    'It is a sum of all products in the table estoqueup
                    Dim sql1 = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto;"

                    'create um new command para a trans da table estoqueup
                    Dim cmd1 As New OleDb.OleDbCommand(sql1, CNN, myTrans)
                    'create a new obj adapter para o cmd1
                    Dim daEstoque As New OleDb.OleDbDataAdapter(cmd1)
                    'Is a dataset and fill.
                    daEstoque.Fill(dsEstGeral, "Estoque")

                    Dim cmd2 As New OleDb.OleDbCommand("SELECT * FROM Produtos", CNN, myTrans)
                    Dim daProduto As New OleDb.OleDbDataAdapter(cmd2)
                    daProduto.Fill(dsEstGeral, "Produtos")

                    Dim cmd3 As New OleDb.OleDbCommand("SELECT ItensCompra.CompraInterno, ItensCompra.CodigoProduto FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE(((Produtos.ControlaEstoque) = 'SIM')) GROUP BY ItensCompra.CompraInterno, ItensCompra.CodigoProduto HAVING (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & "))", CNN, myTrans)
                    Dim daIT As New OleDb.OleDbDataAdapter(cmd3)
                    daIT.Fill(dsEstGeral, "Itens")

                    Dim DrLinha As DataRow
                    For Each DrLinha In dsEstGeral.Tables("Itens").Rows
                        Dim drEst() As DataRow

                        drEst = dsEstGeral.Tables("Estoque").Select("CodigoProduto = " & DrLinha("CodigoProduto"))

                        Dim drProduto() As DataRow
                        drProduto = dsEstGeral.Tables("Produtos").Select("CodigoProduto = " & DrLinha("CodigoProduto"))


                        drProduto(0).BeginEdit()
                        drProduto(0)("QuantidadeEstoque") = drEst(0)("SomaDeQtd")
                        drProduto(0).EndEdit()

                    Next
                    Dim objProduto As New OleDb.OleDbCommandBuilder(daProduto)
                    daProduto.Update(dsEstGeral, "Produtos")

                    'here begins to update the inventory of numbering

                    Dim ds As New DataSet()

                    Dim Cmd4 As New OleDb.OleDbCommand("SELECT EstoqueUP.CodigoProduto, EstoqueUP.Numero, Sum(EstoqueUP.Qtd) AS SomaDeQtd FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto, EstoqueUP.Numero;", CNN, myTrans)
                    Dim oDA1 As New OleDb.OleDbDataAdapter(Cmd4)
                    oDA1.Fill(ds, "Estoque")

                    Dim cmd5 As New OleDb.OleDbCommand("SELECT * FROM ProdutoGrade", CNN, myTrans)
                    Dim daGrade As New OleDb.OleDbDataAdapter(cmd5)
                    daGrade.Fill(ds, "Numeracao")

                    Dim cmd6 As New OleDb.OleDbCommand("SELECT ItensCompra.CompraInterno, ItensCompra.CodigoProduto, ItensCompra.Tamanho FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Produtos.ControlaEstoque)='SIM'));", CNN, myTrans)
                    Dim IT As New OleDb.OleDbDataAdapter(cmd6)
                    IT.Fill(ds, "Itens")


                    Dim Dr As DataRow
                    For Each Dr In ds.Tables("Itens").Rows
                        Dim drEst() As DataRow
                        drEst = ds.Tables("Estoque").Select("CodigoProduto = " & Dr("CodigoProduto") & " And Numero = '" & Dr("Tamanho") & "'")

                        Dim drGrade() As DataRow
                        drGrade = ds.Tables("Numeracao").Select("Produto = " & Dr("CodigoProduto") & " And Numero = '" & Dr("Tamanho") & "'")


                        drGrade(0).BeginEdit()
                        drGrade(0)("QtdEst") = drEst(0)("SomaDeQtd")
                        drGrade(0).EndEdit()
                    Next


                    Dim objGrade As New OleDb.OleDbCommandBuilder(daGrade)
                    daGrade.Update(ds, "Numeracao")

                End If

                myTrans.Commit()
                Me.Cursor = Cursors.Default
                MsgBox("Compra confirmada com sucesso", 64, "Validador de Dados")
                Me.AdicionarItens.Enabled = False
                ConfImg.Visible = True
                Me.SalvarBT.Enabled = False
                Me.Confirmado.Checked = True

                'Fim da confirmação da compra

                Ação.Desbloquear_Controle(Me, False)

                '    'Devolução
                '    'Atualizar o Estoque do Cadastro de Produtos
                '    System.Threading.Thread.Sleep(2000)
                '    Dim EstoqueGeral As New EstoqueAtualizar
                '    EstoqueGeral.Run_AtualizadorNFCompra(Me.CompraInterno.Text)
                '    ''Atualizar o Estoque de Numeraçao
                '    Dim EstoqueNumero As New EstoqueAtualizar
                '    EstoqueNumero.Run_AtualizadorNumeracaoEntrada(Me.CompraInterno.Text)



            Catch x As Exception
                Me.Cursor = Cursors.Default
                myTrans.Rollback()
                MsgBox(x.Message)
            Finally
                CNN.Close()
            End Try

        End If

    End Sub

    Private Sub ValorCompra_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorCompra.Enter
        If Me.ValorCompra.Text = "" Then Me.ValorCompra.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub BaseCalcIcms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BaseCalcIcms.Enter, baseCalcIcmsST.Enter, ValorBaseCalcIcmsST.Enter, NotaFiscal.Enter
        If Me.BaseCalcIcms.Text = "" Then Me.BaseCalcIcms.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub ValorIcms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorIcms.Enter
        If Me.ValorIcms.Text = "" Then Me.ValorIcms.Text = FormatCurrency(0, 2)
    End Sub

    Public Sub CancelProdutoEstoque()
        Try
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim cmd As OleDb.OleDbCommand
            Dim Sql As String = ""
            Sql = "Delete * from EstoqueUP WHERE PedidoOrdem = " & Me.CompraInterno.Text & " and Prg ='COMPRA' "

            cmd = New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()
            CNN.Close()
        Catch ex As Exception
            MsgBox("Não foi possível cancelar os produtos do Estoque", 48, "Validador de Dados")
        End Try

    End Sub
    Private Sub CancelarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBT.Click

        If Me.Inativo.Checked = True Then
            MsgBox("Esta compra já foi cancelada, escolha outra", 48, "Validação de dados")
            Return
        End If

        Try
            If Me.Confirmado.Checked = True Then

                Dim HH As DateTime = Now
                Dim CodSegurança As String = InformaCodigoSeguranca()

                If VerificaCodigoSegurança(CodSegurança) = False Then
                    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
                    Exit Sub
                End If

                Dim Motivo As String = ""
                Motivo = InputBox("Informe o motivo para inativar a nota fiscal de compra.", "Validador de Dados")
                If Motivo = "" Then
                    MsgBox("Não foi informado o motivo, nota fiscal não será cancelada.", 64, "Validador de Dados")
                    Exit Sub
                End If

                Me.Cursor = Cursors.WaitCursor
                Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                Dim mytrans As OleDb.OleDbTransaction
                CNN.Open()
                mytrans = CNN.BeginTransaction

                If Me.dgv.RowCount > 0 Then
                    Try
                        'CANCELAR EXCLUIR OS PRODUTOS DA TABELA UPESTOQUE
                        Dim cmd1 As OleDb.OleDbCommand
                        Dim Sql1 As String = ""
                        Sql1 = "Delete * from EstoqueUP WHERE PedidoOrdem = " & Me.CompraInterno.Text & " and Prg ='COMPRA' "
                        cmd1 = New OleDb.OleDbCommand(Sql1, CNN, mytrans)
                        cmd1.ExecuteNonQuery()

                        'ROTINA PARA ATUALIZAR O ESTOQUE GERAL DOS PRODUTOS
                        Dim dsEstGeral As New DataSet()

                        'Faz uma Sum na Tabela Estoqueup com todos os produtos.
                        Dim sql2 = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto;"
                        Dim cmd2 As New OleDb.OleDbCommand(sql2, CNN, mytrans)
                        Dim daEstoque As New OleDb.OleDbDataAdapter(cmd2)
                        daEstoque.Fill(dsEstGeral, "Estoque")

                        'Seleciona todos os registro da tabela produtos.
                        Dim cmd3 As New OleDb.OleDbCommand("SELECT * FROM Produtos", CNN, mytrans)
                        Dim daProduto As New OleDb.OleDbDataAdapter(cmd3)
                        daProduto.Fill(dsEstGeral, "Produtos")

                        'Selecionas todos itens que serão cancelados na compra filtrado pelo codigo da compra
                        sql2 = "SELECT ItensCompra.CompraInterno, ItensCompra.CodigoProduto FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE(((Produtos.ControlaEstoque) = 'SIM')) GROUP BY ItensCompra.CompraInterno, ItensCompra.CodigoProduto HAVING (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & "));"
                        Dim cmd4 As New OleDb.OleDbCommand(sql2, CNN, mytrans)
                        Dim daIT As New OleDb.OleDbDataAdapter(cmd4)
                        daIT.Fill(dsEstGeral, "Itens")

                        'Cria um datarow e faz comparações dos registros encontrados.
                        Dim DrLinha As DataRow
                        For Each DrLinha In dsEstGeral.Tables("Itens").Rows
                            Dim drEst() As DataRow

                            drEst = dsEstGeral.Tables("Estoque").Select("CodigoProduto = " & DrLinha("CodigoProduto"))

                            Dim drProduto() As DataRow
                            drProduto = dsEstGeral.Tables("Produtos").Select("CodigoProduto = " & DrLinha("CodigoProduto"))
                            drProduto(0).BeginEdit()
                            If drEst.Length > 0 Then
                                drProduto(0)("QuantidadeEstoque") = drEst(0)("SomaDeQtd")
                            Else
                                drProduto(0)("QuantidadeEstoque") = 0
                            End If
                            drProduto(0).EndEdit()

                        Next

                        Dim objProduto As New OleDb.OleDbCommandBuilder(daProduto)
                        daProduto.Update(dsEstGeral, "Produtos")


                        'ATUALIZA O ESTOQUE DA NUMERAÇÃO
                        Dim dsNUM As New DataSet()

                        Dim sqlN1 = "SELECT EstoqueUP.CodigoProduto, EstoqueUP.Numero As Num, Sum(EstoqueUP.Qtd) AS SomaDeQtd FROM EstoqueUP GROUP BY EstoqueUP.CodigoProduto, EstoqueUP.Numero;"
                        Dim Cmd5 As New OleDb.OleDbCommand(sqlN1, CNN, mytrans)

                        Dim daEstoqueNum As New OleDb.OleDbDataAdapter(Cmd5)
                        daEstoqueNum.Fill(dsNUM, "EstoqueNum")

                        Dim SqlN2 = "SELECT * FROM ProdutoGrade"
                        Dim cmd6 As New OleDb.OleDbCommand(SqlN2, CNN, mytrans)
                        Dim daGrade As New OleDb.OleDbDataAdapter(cmd6)
                        daGrade.Fill(dsNUM, "Numeracao")

                        Dim sqlN3 = "SELECT ItensCompra.CompraInterno, ItensCompra.CodigoProduto, ItensCompra.Tamanho FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Produtos.ControlaEstoque)='SIM'));"
                        Dim cmd7 As New OleDb.OleDbCommand(sqlN3, CNN, mytrans)
                        Dim daIT1 As New OleDb.OleDbDataAdapter(cmd7)
                        daIT1.Fill(dsNUM, "Itens")

                        Dim DrLinha1 As DataRow
                        For Each DrLinha1 In dsNUM.Tables("Itens").Rows
                            Dim drEst() As DataRow

                            drEst = dsNUM.Tables("EstoqueNum").Select("CodigoProduto = " & DrLinha1("CodigoProduto") & " And Num = '" & DrLinha1("Tamanho") & "'")

                            Dim drGrade() As DataRow
                            drGrade = dsNUM.Tables("Numeracao").Select("Produto = " & DrLinha1("CodigoProduto") & " And Numero = '" & DrLinha1("Tamanho") & "'")


                            drGrade(0).BeginEdit()
                            If drEst.Length > 0 Then
                                drGrade(0)("QtdEst") = drEst(0)("SomaDeQtd")
                            Else
                                drGrade(0)("QtdEst") = 0
                            End If
                            drGrade(0).EndEdit()
                        Next
                        Dim objGrade As New OleDb.OleDbCommandBuilder(daGrade)
                        daGrade.Update(dsNUM, "Numeracao")

                        'verifica se existe contas a pagar para este documento e se ja existe alguma baixa foram baixadas
                        Dim sSql As String = String.Empty

                        sSql = "Select Pagar.IdCompra, Pagar.Baixado From Pagar Where Pagar.IdCompra = " & Me.CompraInterno.Text & " and Pagar.Baixado = True"
                        Dim Ccmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sSql, CNN, mytrans)
                        Dim oDR As OleDb.OleDbDataReader
                        oDR = Ccmd.ExecuteReader

                        If oDR.HasRows Then
                            MessageBox.Show("Este documento possui contas relacionada que já foram pagas, não pode cancelar o documento.", "Validador de Dados", MessageBoxButtons.OK)
                            oDR.Close()
                            Ccmd = Nothing
                            sSql = Nothing
                            Exit Sub
                        End If

                        'Deleta contas relacionadas
                        sSql = "Delete * From Pagar Where IdCompra = " & Me.CompraInterno.Text
                        Ccmd = New OleDb.OleDbCommand(sSql, CNN, mytrans)
                        Ccmd.ExecuteNonQuery()

                        Dim Sql As String = "Update Compra set Inativo = @1, Obs = @2 Where CompraInterno = " & Me.CompraInterno.Text
                        Dim cmd As New OleDb.OleDbCommand(Sql, CNN, mytrans)

                        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))
                        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", "Inativado por: " & "UserAtivo & Autorizado por: " & Motivo))


                        cmd.ExecuteNonQuery()
                        'here I chenge the status of the pedidocompra.
                        clsPC.EntregouTodoItem(Me.PedidoCompra.Text)
                        If clsPC.Status = "EM ANDAMENTO" Then
                            Dim i As Integer
                            Dim sUpd As String
                            Dim cmdUPD As New OleDb.OleDbCommand
                            For rowIndex As Integer = 0 To dgv.Rows.Count - 1 Step 1
                                i = dgv.Item(0, rowIndex).Value

                                sUpd = "UPDATE ItensCompra INNER JOIN PedidoCompraItem ON ItensCompra.IDItemPedidoCompra = PedidoCompraItem.Id SET PedidoCompraItem.QtdEntregue = [qtdentregue]-[ItensCompra].[qtd] WHERE (((ItensCompra.Id)=" & i & "))"

                                cmdUPD = New OleDb.OleDbCommand(sUpd, CNN, mytrans)

                                cmdUPD.ExecuteNonQuery()

                            Next rowIndex

                        End If



                        mytrans.Commit()
                        Me.Cursor = Cursors.Default



                        'Fim do cancelamento da compra
                        MsgBox("Compra inativada com sucesso", 64, "Validador de Dados")
                        Ação.Desbloquear_Controle(Me, False)
                        Me.Close()
                        Me.Dispose()
                    Catch ex As Exception
                        mytrans.Rollback()
                        CNN.Close()
                        Me.Cursor = Cursors.Default
                    End Try
                End If
            Else
                Dim Motivo As String = ""
                Motivo = InputBox("Informe o motivo para inativar a nota fiscal de compra.", "Validador de Dados")
                If Motivo = "" Then
                    MsgBox("Não foi informado o motivo, nota fiscal não sera cancelada.", 64, "Validador de Dados")
                    Exit Sub
                End If

                Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                Dim mytrans As OleDb.OleDbTransaction
                CNN.Open()
                mytrans = CNN.BeginTransaction


                Dim Sql As String = "Update Compra set Inativo = @1, Obs = @2 Where CompraInterno = " & Me.CompraInterno.Text
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN, mytrans)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", "Inativado por: " & "UserAtivo & Autorizado por: " & Motivo))

                Try
                    cmd.ExecuteNonQuery()
                    'here I chenge the status of the pedidocompra.
                    clsPC.EntregouTodoItem(Me.PedidoCompra.Text)
                    If clsPC.Status = "EM ANDAMENTO" Then
                        Dim i As Integer
                        Dim sUpd As String
                        Dim cmdUPD As New OleDb.OleDbCommand
                        For rowIndex As Integer = 0 To dgv.Rows.Count - 1 Step 1
                            i = dgv.Item(0, rowIndex).Value

                            sUpd = "UPDATE ItensCompra INNER JOIN PedidoCompraItem ON ItensCompra.IDItemPedidoCompra = PedidoCompraItem.Id SET PedidoCompraItem.QtdEntregue = [qtdentregue]-[ItensCompra].[qtd] WHERE (((ItensCompra.Id)=" & i & "))"

                            cmdUPD = New OleDb.OleDbCommand(sUpd, CNN, mytrans)

                            cmdUPD.ExecuteNonQuery()

                        Next rowIndex

                    End If

                    mytrans.Commit()
                    CNN.Close()
                    Me.ConfImg.Visible = True
                    Me.ConfImg.Text = "Cancelada"
                Catch x As Exception
                    mytrans.Rollback()
                    MsgBox(x.Message)
                    Exit Sub
                End Try

                MsgBox("Compra Inativada com sucesso", 64, "Validador de Dados")
            End If
        Catch sqlError As OleDb.OleDbException

        End Try

    End Sub

    Public Sub BloquearCtrlExtras(ByVal TrueFalse As Boolean)
        Me.ValorCompra.Enabled = TrueFalse
        Me.TotalProdutos.Enabled = TrueFalse
        Me.BaseCalcIcms.Enabled = TrueFalse
        Me.ValorIcms.Enabled = TrueFalse
        Me.BaseCalcIpi.Enabled = TrueFalse
        Me.VlrIpi.Enabled = TrueFalse
        Me.ValorFrete.Enabled = TrueFalse
    End Sub

    Private Sub CadProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.Produtos.ShowDialog()
    End Sub

    Private Sub DataLançamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        If Me.DataLancamento.Text = "" Then
            Me.DataLancamento.Text = DataDia
        End If
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        Salvar_Click(sender, e)
    End Sub

    Private Sub TravarOCampoDataDeLançamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TravarOCampoDataDeLançamentoToolStripMenuItem.Click
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
    End Sub

    Private Sub DestravarOCampoDataDeLançamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestravarOCampoDataDeLançamentoToolStripMenuItem.Click
        Dim HH As DateTime = Now
        Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança.", "Validador de Dados", 0)

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, "Validador de Dados")
            Exit Sub
        Else
            Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If
    End Sub

    Public Function achaNF(ByVal strNF As String, ByVal intFor As Integer) As Boolean
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String = "SELECT Compra.CódigoFornecedor, Compra.NotaFiscal, Compra.Empresa, Compra.Inativo  FROM(Compra) WHERE (((Compra.CódigoFornecedor)=" & intFor & ") AND ((Compra.NotaFiscal) Like '" & strNF & "') AND ((Compra.Empresa)=" & CodEmpresa & ") AND ((Compra.Inativo)=False));"

        'Inserir ultimo registro
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = sql
            .CommandType = CommandType.Text
        End With
        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    Return True
                Else
                    Return False
                End If
            End While
            DataReader.Close()
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Function
            End If
        End Try

    End Function

    Private Sub NotaFiscal_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If achaNF(Me.NotaFiscal.Text, Me.CodigoFornecedor.Text) = True Then
            'Achou o iten procurado o iten as caixas serão preenchida
            MsgBox("Esta nota já foi lançada para esse Fornecedor", 48, "Validador de Dados")
            Exit Sub
        End If
    End Sub

    Public Sub TabItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem1.Click
        Me.BaseCalcIcms.Focus()
    End Sub

    Private Sub TotalProdutos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalProdutos.Enter
        Me.TotalProdutos.Text = FormatNumber(CDbl(NzZero(Me.TotalItensLançado.Text)) + CDbl(NzZero(Me.TotalItensIpi.Text)) + CDbl(NzZero(Me.ValorOutros.Text)), 4)
    End Sub

    Private Sub AdicionarItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarItens.Click
        If Me.PedidoCompra.Text <> "" Then
            MsgBox("Você informou um pedido de compra, não poderá usar esta opção", 48, "Validação de dados")
            Return
        End If

        If Me.CompraInterno.Text = "" Then
            If Operation = INS Then Salvar_Click(sender, e)
            Me.PedidoCompra.ReadOnly = True
        End If

        If Me.Confirmado.Checked = True Then
            MsgBox("Esta nota já foi confirmada, não será mais possível adicionar itens", 48, "Validador de Dados")
            Exit Sub
        End If

        'Verifica se a nf foi gravada no banco de dados.
        If Me.CompraInterno.Text = "" Or Me.CompraInterno.Text = "0" Then
            MsgBox("A nota não foi salva!", MsgBoxStyle.Information, "Validador de Dados")
            Exit Sub
        End If
        Try
            'Carrega o form para adicionar os itens.
            SellShoesComprasAddItem.ShowDialog()
            Me.VlrIpi.Text = FormatNumber(NzZero(Me.TotalItensIpi.Text), 2)
            Me.TotalProdutos.Text = FormatNumber(NzZero(Me.TotalItensLançado.Text) + NzZero(CDbl(Me.VlrIpi.Text)), 4)


        Catch x As Exception
            MsgBox(x.Message)
        End Try

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

        'If Me.Confirmado.Checked = True Then
        '    MessageBox.Show("Este iten não pode mais ser editado, pois o pedido já foi confirmado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        'Dim I As Integer = 0

        'Dim idVLR As String = String.Empty

        'For I = 0 To MyLista.Items.Count - 1
        '    If MyLista.Items(I).Selected = True Then idVLR = MyLista.Items(I).Text.Substring(0)
        'Next

        'My.Forms.ComprasAddItem.Id.Text = idVLR
        'My.Forms.ComprasAddItem.LocalizaItens()
        'My.Forms.ComprasAddItem.ShowDialog()
        'Me.BaseCalcIcms.Focus()
    End Sub


    Private Sub ExcluirOItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirOItemToolStripMenuItem.Click

        If Me.Confirmado.Checked = True Then
            Exit Sub
        End If

        If Me.Inativo.Checked = True Then
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            MsgBox("Este pedido de compra ja foi confirmado não pode ser alterado, Verifique.", 64, "Validador de Dados")
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim myTrans As OleDb.OleDbTransaction = CNN.BeginTransaction

        Dim Sql As String = "Delete * from ItensCompra Where id = " & IdItem
        Dim sUpd As String = "UPDATE ItensCompra INNER JOIN PedidoCompraItem ON ItensCompra.IDItemPedidoCompra = PedidoCompraItem.Id SET PedidoCompraItem.QtdEntregue = [qtdentregue]-[ItensCompra].[qtd] WHERE (((ItensCompra.Id)=" & IdItem & "))"

        Dim cmd As New OleDb.OleDbCommand(Sql, CNN, myTrans)
        Dim cmd1 As New OleDb.OleDbCommand(sUpd, CNN, myTrans)


        Try
            cmd1.ExecuteNonQuery()
            cmd.ExecuteNonQuery()

            myTrans.Commit()
            MsgBox("Registro excluido com sucesso", 64, "Validador de Dados")
            CNN.Close()
            AtGrade()
            If NzZero(Me.PedidoCompra.Text) > 0 Then
                clsPC.EntregouTodoItem(Me.PedidoCompra.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validador de Dados")
            myTrans.Commit()
        Finally
            CNN.Close()
        End Try
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        If Me.CompraInterno.Text = "" Then
            MessageBox.Show("Não foi informado nenhuma compra para impressão.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        RelatorioCarregar = "RelSellShoesCompra"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub DataEntrada_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataEntrada.Enter
        If Me.DataEntrada.Text = "" Then
            Me.DataEntrada.Text = DataDia
        End If
    End Sub

    Private Sub VlrIpi_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VlrIpi.Enter
        Me.VlrIpi.Text = FormatNumber(NzZero(Me.TotalItensIpi.Text), 2)
    End Sub

    Private Sub CodigoFornecedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoFornecedor.TextChanged

    End Sub

    Private Sub CodigoFornecedor_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CodigoFornecedor.Validating
        If Len(Me.CodigoFornecedor.Text) = 0 Then
        Else
            Dim CNN1 As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN1.Open()

            Dim Sql As String = "SELECT Compra.CompraInterno, Compra.CodigoFornecedor, Compra.NotaFiscal, Compra.Tipo, Compra.Inativo  FROM(Compra) WHERE (((Compra.CodigoFornecedor)=" & Me.CodigoFornecedor.Text & ") AND ((Compra.NotaFiscal)='" & Me.NotaFiscal.Text & "') AND ((Compra.Tipo)='" & cTipo.Text & "') AND ((Compra.Inativo)=False));"

            Dim Cmd As New OleDb.OleDbCommand(Sql, CNN1)
            Dim DataReader As OleDb.OleDbDataReader

            Try
                DataReader = Cmd.ExecuteReader

                If Operation = INS Then
                    If DataReader.HasRows = True Then
                        MsgBox("Já existe um nota com esse numero para este Fornecedor. Verifique", 48, "Atenção")
                        Me.CodigoFornecedor.Focus()
                        Exit Sub
                    End If
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub TpEntrada_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TpEntrada.Leave
        If Me.TpEntrada.Text = "DEVOLUÇÃO" Then
            Me.PainelDev.Visible = True
            Me.NFdevMae.Focus()
        Else
            Me.PainelDev.Visible = False
        End If
    End Sub


    Private Sub ImportarNFDevolver()

        If Me.IdNFdevMae.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Compra.*, Compra.CompraInterno, Funcionários.Nome, Fornecedor.RazãoSocial FROM (Compra INNER JOIN Funcionários ON Compra.CodigoFuncionario = Funcionários.CódigoFuncionário) INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((Compra.CompraInterno)=" & Me.IdNFdevMae.Text & "))"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader
        Try
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows = True Then
                Me.NFdevMae.Text = DR.Item("NotaFiscal") & ""
                Me.CodigoFornecedor.Text = DR.Item("CodigoFornecedor") & ""
                Me.RazaoSocial.Text = DR.Item("RazãoSocial") & ""
                Me.CodigoFuncionario.Text = DR.Item("CodigoFuncionario") & ""
                Me.FuncionarioDesc.Text = DR.Item("Nome") & ""

                Me.NFdevMaeValor.Text = FormatCurrency(Nz(DR.Item("ValorCompra"), 3), 2)


                Me.ValorCompra.Text = FormatCurrency(Nz(DR.Item("ValorCompra"), 3), 2)
                Me.TotalProdutos.Text = FormatCurrency(Nz(DR.Item("TotalProdutos"), 3), 2)
                Me.BaseCalcIcms.Text = FormatCurrency(Nz(DR.Item("BaseCalcIcms"), 3), 2)
                Me.ValorIcms.Text = FormatCurrency(Nz(DR.Item("ValorIcms"), 3), 2)
                Me.BaseCalcIpi.Text = FormatCurrency(Nz(DR.Item("BaseCalcIpi"), 3), 2)
                Me.ValorOutros.Text = FormatCurrency(Nz(DR.Item("ValorOutros"), 3), 2)

                Me.VlrIpi.Text = DR.Item("ValorIpi") & ""
                Me.cTipo.Text = DR.Item("Tipo") & ""

                Me.ValorFrete.Text = FormatCurrency(Nz(DR.Item("ValorFrete"), 3), 2)
            End If
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

    Private Sub btFindNFDevolucao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindNFDevolucao.Click
        My.Forms.CompraProcurarDevolucao.ShowDialog()

        If Me.IdNFdevMae.Text <> "" Then
            ImportarNFDevolver()
            ListaDevolucao()
        End If
    End Sub

    Private Sub ImportarItensParaDevoluçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarItensParaDevoluçãoToolStripMenuItem.Click

        If Me.IdNFdevMae.Text = "" Then
            MessageBox.Show("Não pode Importar, verifique se existe NF/Doc de Devolução.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "INSERT INTO ItensCompra ( CompraInterno, CodigoProduto, Qtd, ConversorQtd, ValorUnitario, Desconto, ValorDesconto, Ipi, ValorIpi, TotalProduto, Cst, Cf, SeqNf, CFOP, IcmsProduto, ValorIcmsProduto, PisProduto, ValorPisProduto, CofinsProduto, ValorCofinsProduto, FreteProduto, ValorFreteProduto, ClassContabilProduto, ValorP ) SELECT " & Me.CompraInterno.Text & " AS Expr1, ItensCompra.CodigoProduto, ItensCompra.Qtd, ItensCompra.ConversorQtd, ItensCompra.ValorUnitario, ItensCompra.Desconto, ItensCompra.ValorDesconto, ItensCompra.Ipi, ItensCompra.ValorIpi, ItensCompra.TotalProduto, ItensCompra.Cst, ItensCompra.Cf, ItensCompra.SeqNf, ItensCompra.CFOP, ItensCompra.IcmsProduto, ItensCompra.ValorIcmsProduto, ItensCompra.PisProduto, ItensCompra.ValorPisProduto, ItensCompra.CofinsProduto, ItensCompra.ValorCofinsProduto, ItensCompra.FreteProduto, ItensCompra.ValorFreteProduto, ItensCompra.ClassContabilProduto, ItensCompra.ValorP FROM(ItensCompra) WHERE (((ItensCompra.CompraInterno)=" & Me.IdNFdevMae.Text & "));"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.ExecuteNonQuery()

        MsgBox("Registros Importados com sucesso", 64, "Validador de Dados")
        CNN.Close()

        AtGrade()
    End Sub

    Private Sub ListaDevolucao()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Compra.CompraInterno, Compra.NotaFiscal, Fornecedor.RazãoSocial, Compra.ValorCompra FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((Compra.Confirmado)=True) AND ((Compra.TpEntrada)='DEVOLUÇÃO') AND ((Compra.IdNFdevMae)=" & Me.IdNFdevMae.Text & "));"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        VlrListaDevolucao = NzZero(ds.Tables("Table").Compute("sum(ValorCompra)", ""))
        Me.Lista.DataSource = ds.Tables("Table").DefaultView


        da.Dispose()
        Cnn.Close()

        If Me.Lista.RowCount > 0 Then
            Me.DevolucaoTab.Visible = True
        Else
            Me.DevolucaoTab.Visible = False
        End If

    End Sub

    Private Sub ValorCompra_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorCompra.Leave
        Me.AdicionarItens.Focus()
    End Sub

    Private Sub ContaLancamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F5 Then
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
        End If
    End Sub


    Private Sub MostraPagar()



        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Pagar.Id, Pagar.Documento, Pagar.NotaFiscal, Pagar.Fornecedor, Pagar.ValorDocumento, Pagar.Vencimento, Pagar.Pagamento FROM(Pagar) WHERE (((Pagar.IdCompra)=" & NzZero(Me.CompraInterno.Text) & "));"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.ListaPagar.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

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

    Private Sub ListaPagar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaPagar.CellDoubleClick
        Dim vID As Integer
        Dim dtPGTO As String = String.Empty
        vID = CInt(Me.ListaPagar.CurrentRow.Cells("cId").Value)
        dtPGTO = Me.ListaPagar.CurrentRow.Cells("cPagamento").Value & ""

        If dtPGTO <> "" Then
            MessageBox.Show("Este documento já foi baixado e não pode mais ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.PagarBaixa.AchaRegistro(vID)
        My.Forms.PagarBaixa.ShowDialog()
        MostraPagar()


    End Sub


    Private Sub NFdevMae_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NFdevMae.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CompraProcurarDevolucao.ShowDialog()

            If Me.IdNFdevMae.Text <> "" Then
                ImportarNFDevolver()
                ListaDevolucao()
            End If
        End If
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        IdItem = Me.dgv.CurrentRow.Cells(0).Value

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este iten não pode mais ser editado, pois o pedido já foi confirmado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.PedidoCompra.Text <> "" Then
            MsgBox("Este item veio de um pedido de compra, você não pode editar.", 48, "Validação de dados")
            Return
        End If

        If IdItem = 0 Then
            MsgBox("Selecione um produto para editá-lo", 48, "Validação de dados")
            Exit Sub
        End If

        SellShoesComprasAddItem.Id.Text = IdItem
        SellShoesComprasAddItem.LocalizaItens()
        SellShoesComprasAddItem.butNovo.Enabled = False
        SellShoesComprasAddItem.ShowDialog()
        Me.BaseCalcIcms.Focus()
    End Sub

    Private Sub dgv_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv.SelectionChanged
        Try
            IdItem = Me.dgv.CurrentRow.Cells(0).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PedidoCompra_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoCompra.Leave
        Try

            clsPC.LoclizaItemParaEditar(Me.PedidoCompra.Text)
            If clsPC.Localizado = False Then
                MsgBox("Este pedido de compra não pode ser utilizado, verifique as seguintes opções:" & Chr(13) & "« O pedido de compra deverá estar confirmado »" & Chr(13) & "« Verificar se tem item para ser importado «", 48, "Validação de dados")
                Me.PedidoCompra.Clear()
                Me.AdicionarItens.Enabled = True
                Me.PedidoCompra.ReadOnly = False
                Return
            End If


            clsPC.Localizar(Me.PedidoCompra.Text)

            If clsPC.Inativo = True Then
                MsgBox("Este pedido foi cancelado, tente um outro.", 48, "Validação de dados")
                Me.PedidoCompra.Clear()
                Return

            End If
            With clsPC
                If .Localizado = True Then
                    Me.PedidoCompra.ReadOnly = True
                    Me.CodigoFuncionario.Text = .CodigoFuncionario
                    Me.FuncionarioDesc.Text = .NomeFuncionario
                    Me.TpEntrada.Text = "ENTRADA"
                    Me.cTipo.Text = "NF"
                    Me.CodigoFornecedor.Text = .CodigoFornecedor
                    Me.RazaoSocial.Text = .NomeFornecedor
                    Me.AdicionarItens.Enabled = False
                    Me.CodigoFuncionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                    Me.CodigoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Else
                    MsgBox("Pedido de compra não localizado.", 48, "Validação de dados")
                    Me.PedidoCompra.Clear()
                    Me.AdicionarItens.Enabled = True
                    Me.PedidoCompra.ReadOnly = False
                    Me.CodigoFuncionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                    Me.CodigoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                    Return
                End If

            End With
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Sub

    Private Sub ImportarItemDoPedidoDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarItemDoPedidoDeCompraToolStripMenuItem.Click

        'Area destinada para as validacoes
        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este lançamento ja foi confirmado e não pode ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.NotaFiscal.Text = "" Then
            If MsgBox("O Numero da Nota fiscal não foi informado." & Chr(13) & "Deseja que o sistema complete o com a palavra chave [DOC]?.", 36, "Validador de Dados") = MsgBoxResult.Yes Then
                Me.NotaFiscal.Focus()
                Me.NotaFiscal.Text = "DOC"
                Exit Sub
            Else
                Me.NotaFiscal.Focus()
            End If
        ElseIf Me.DataCompra.Text = "" Then
            MsgBox("A data da compra não foi informado, favor verificar.", 64, "Validador de Dados")
            Me.DataCompra.Focus()
            Exit Sub
        ElseIf Me.DataEntrada.Text = "" Then
            MsgBox("A data da entrada não foi informado, favor verificar.", 64, "Validador de Dados")
            Me.DataEntrada.Focus()
            Exit Sub
        ElseIf Me.DataLancamento.Text = "" Then
            MsgBox("A data de lançamento não foi informado, favor verificar.", 64, "Validador de Dados")
            Me.DataLancamento.Focus()
            Exit Sub
        ElseIf Me.CodigoFornecedor.Text = "" Then
            MsgBox("O fornecedor da nota fiscal não foi informado", 64, "Validador de Dados")
            Me.CodigoFornecedor.Focus()
            Exit Sub
        ElseIf Me.CodigoFuncionario.Text = "" Then
            MsgBox("O Funcionário não foi informado", 64, "Validador de Dados")
            Me.CodigoFuncionario.Focus()
            Exit Sub
        ElseIf NzZero(Me.ValorCompra.Text) = 0 Then
            MsgBox("O valor da compra não foi informado", 64, "Validador de Dados")
            Me.ValorCompra.Focus()
            Exit Sub
        ElseIf Me.cTipo.Text = "" Then
            MsgBox("O Tipo de Lançamento não foi informado", 64, "Validador de Dados")
            Me.cTipo.Focus()
            Exit Sub
        ElseIf CDate(Me.DataCompra.Text) > CDate(Me.DataLancamento.Text) Then
            MsgBox("A data de Emissão não pode ser maior que a data de lançamento.", 64, "Validador de Dados")
            Me.DataCompra.Focus()
            Exit Sub
        ElseIf CDate(Me.DataEntrada.Text) > CDate(Me.DataLancamento.Text) Then
            MsgBox("A data de Entrada não pode ser maior que a data de lançamento.", 64, "Validador de Dados")
            Me.DataEntrada.Focus()
            Exit Sub
        End If

        RetornoProcura = Me.PedidoCompra.Text

        If Me.CompraInterno.Text = "" Then
            If Operation = INS Then Salvar_Click(sender, e)
        End If
        PedidoCompraImportar.ShowDialog()
        Me.VlrIpi.Text = FormatNumber(NzZero(Me.TotalItensIpi.Text), 2)
        Me.TotalProdutos.Text = FormatNumber(NzZero(Me.TotalItensLançado.Text) + NzZero(CDbl(Me.VlrIpi.Text)), 4)

        'here I chenge the status of the pedidocompra.
        clsPC.EntregouTodoItem(Me.PedidoCompra.Text)

    End Sub
End Class