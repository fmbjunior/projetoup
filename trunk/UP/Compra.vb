
Public Class Compra

    Dim Autorizado As Boolean
    Dim TemErros As Boolean = False
    Dim AlteraItens As Boolean = False

    Public varPegaConta As String = String.Empty

    Dim CodigoPlanoContasFornecedor As String = ""
    Dim ValorProdutosLaçamentos As Double
    Dim ValorIpiLancamentos As Double
    Dim AliquotaFrete As Double

    Dim VlrListaDevolucao As Double

    Dim ChecaPedido As Boolean = False
    Dim LancamentoRetroativo As Boolean = False

    Public CancelouPagar As Boolean

    Dim T As Double

    Dim Ação As New TrfGerais()

    Private OperationItens As Byte
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    'Variaveis Para importação do Xml
    Public TbIT As New DataTable
    Public ItensErrado As Integer = 0
    'fim das Variaveis de Importação

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
        Me.Confirmado.Checked = False
        Me.VlrIpi.Clear()
        Me.MyLista.Items.Clear()
        Me.DevolucaoTab.Visible = False

        Me.TabGeral.SelectedTab = Me.TabItens



        Me.TotalItensLançado.Clear()
        Me.TotalItensIpi.Clear()
        Me.TotalItensIpi.Clear()
        Me.MyLista.Items.Clear()

        Ação.Desbloquear_Controle(Me, True)
        BloquearCtrlExtras(True)
        DesativaLancamentoItens(False)
        Me.AdicionarItens.Enabled = True
        Me.ConfImg.Visible = False
        Me.SalvarBT.Enabled = True

        Me.PainelDev.Visible = False

        LiberarConta1()
        Operation = INS

        Me.TabGeral.SelectedTab = Me.TabItens

        Me.TpEntrada.Focus()

    End Sub

    Private Sub CódigoFornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoFornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.TelaProcuraFor.ShowDialog()
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
        If e.KeyCode = Keys.F8 Then
            Me.TabGeral.SelectedTab = Me.TabItem1
            Me.BaseCalcIcmsST.Focus()
        End If
        If e.KeyCode = Keys.F9 Then
            Me.TabGeral.SelectedTab = Me.DevolucaoTab
        End If
        If e.KeyCode = Keys.F10 Then
            Me.TabGeral.SelectedTab = Me.TabItem2
        End If
    End Sub

    Private Sub Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LocalizarBT.Enabled = True

        Ação.Desbloquear_Controle(Me, False)


        'Dim Tab As DevComponents.DotNetBar.TabItem = Me.TabItem1
        Me.TabGeral.SelectedTab = Me.TabItens
        Operation = 99
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
            Autorizado = PedirPermissao(Me.Text, Me.NotaFiscal.Text)
            Autorizado = varAutorizado
            If Autorizado = False Then
                Exit Sub
            End If
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
                Me.SalvarBT.Enabled = True
                Me.NotaFiscal.Focus()

            Else

                Operation = UPD
                Ação.Desbloquear_Controle(Me, True)
                BloquearCtrlExtras(True)

                'Me.Confirmado.Enabled = False
                'Me.ConfImg.Visible = False
                Me.SalvarBT.Enabled = True
                Me.AdicionarItens.Enabled = True
                Me.NotaFiscal.Focus()

            End If
        End If
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Area destinada para as validacoes

        If Me.CodigoFornecedor.Text = "" Then
            Exit Sub
        End If

        If Autorizado = False Then
            If Me.Confirmado.Checked = True Then
                MessageBox.Show("Este lançamento ja foi confirmado e não pode ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
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
        ElseIf Me.FormaPagamento.Text = "" Then 'Lelo
            MsgBox("A Forma de pagamento não foi informado", 64, "Validador de Dados")
            Me.FormaPagamento.Focus()
            Exit Sub
        End If


        If Me.cTipo.Text = "NF" Then

            If Me.Serie.Text = "" Then
                MessageBox.Show("O usuário deve informar a Série da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Serie.Focus()
            End If

            If Me.Modelo.Text = "" Then
                MessageBox.Show("O usuário deve informar o Modelo da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Modelo.Focus()
            End If
            If Me.EspecieDocumento.Text = "" Then
                MessageBox.Show("O usuário deve informar a Espécie da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.EspecieDocumento.Focus()
            End If
            If Me.FormaPagamento.Text = "" Then
                MessageBox.Show("O usuário deve informar a Forma de pagamento da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.FormaPagamento.Focus()
            End If

        End If

        'If Me.SubSerie.Text = "" Then
        '    MessageBox.Show("O usuário deve informar a SubSérie da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.SubSerie.Focus()
        'End If
        'If Me.Modelo.Text = "" Then
        '    MessageBox.Show("O usuário deve informar o Modelo da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.Modelo.Focus()
        'End If
        'If Me.EspecieDocumento.Text = "" Then
        '    MessageBox.Show("O usuário deve informar a Espécie da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.EspecieDocumento.Focus()
        'End If
        'If Me.FormaPagamento.Text = "" Then
        '    MessageBox.Show("O usuário deve informar a Forma de pagamento da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.FormaPagamento.Focus()
        'End If

        If Me.ContaDespesa.Text = "" Then
            MessageBox.Show("O usuário deve informar a Conta de Lançamento, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ContaDespesa.Focus()
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

        If NzZero(TestaValor) <> NzZero(Me.ValorCompra.Text) Then
            MessageBox.Show("Os valores das contas não batem com o valor da compra.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


        'If Me.EspecieDocumento.Text = "NFE" Or Me.EspecieDocumento.Text = "NF-E" Then
        '    If Me.ChaveNFe.Text = "" Then
        '        MessageBox.Show("Usuário deve informar a chave da nota fiscal eletrônica", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.ChaveNFe.Focus()
        '        Exit Sub



        If Me.Modelo.Text = "55" Then
            If Me.ChaveNFe.Text = "" Then
                MessageBox.Show("Usuário deve informar a chave da nota fiscal eletrônica", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ChaveNFe.Focus()
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

            Dim Sql As String = "INSERT INTO Compra (CompraInterno, NotaFiscal, DataCompra, DataEntrada, CodigoFornecedor, Obs, ValorCompra, BaseCalcIcms, ValorIcms, BaseCalcIpi, ValorIpi, tipo, Empresa, Confirmado, TotalProdutos, DataLançamento, ValorFrete, ValorOutros, TpEntrada, IdNFdevMae, NFdevMae, NFdevMaeValor, ContaLancamento, BaseCalcIcmsST, ValorIcmsST, Conta1, Conta2, Conta3, Conta4, Conta5, Conta6, Vlr1, Vlr2, Vlr3, Vlr4, Vlr5, Vlr6, IsentoIcms, ValorOutrosIcms, IsentoIpi, ValorOutrosIpi, ValorIssqnRetido, Serie, Modelo, FormaPagamento, CFOP, Icms, SubSerie, EspecieDocumento, ChaveNfe, ValorDesconto, CRTfornecedor) VALUES (@1, @2, @3, @4, @5, @6, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CompraInterno.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataCompra.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataEntrada.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.CodigoFornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Obs.Text, 1)))
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
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.ContaDespesa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.BaseCalcIcmsST.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.ValorIcmsST.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.Conta1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.Conta2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.Conta3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.Conta4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.Conta5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.Conta6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.Vlr1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.Vlr2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.Vlr3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.Vlr4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.Vlr5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.Vlr6.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.IsentoIcms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.ValorOutrosIcms.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.IsentoIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.ValorOutrosIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.ValorIssqnRetido.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.Serie.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.Modelo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.FormaPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.CFOP.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", Nz(Me.Icms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@49", Nz(Me.SubSerie.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@50", Me.EspecieDocumento.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@51", Nz(Me.ChaveNFe.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@52", Nz(Me.ValorDesconto.Text, 1)))

            Dim CRT As String = Mid(Me.CRTfornecedor.Text, 1, 1)
            cmd.Parameters.Add(New OleDb.OleDbParameter("@53", Nz(CRT, 1)))

            Try
                cmd.ExecuteNonQuery()
                'CarregaPedidoCompra()
                MsgBox("Registro adicionado com sucesso", 64, "Validador de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.CompraInterno.Text)
                CNN.Close()
                Operation = UPD

            Catch ex As OleDb.OleDbException
                MsgBox(ex.Message, 64, "Validador de Dados")
            End Try

        ElseIf Operation = UPD Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update Compra set NotaFiscal = @2, DataCompra = @3, DataEntrada = @4, CodigoFornecedor = @5, Obs = @6, ValorCompra = @8, BaseCalcIcms = @9, ValorIcms = @10, BaseCalcIpi = @11, ValorIpi = @12, Tipo = @13, Empresa = @14, Confirmado = @15, TotalProdutos = @16, DataLançamento = @17, ValorFrete = @18, ValorOutros = @19, TpEntrada = @20, IdNFdevMae = @21, NFdevMae = @22, NFdevMaeValor = @23, ContaLancamento = @24, BaseCalcIcmsST = @25, ValorIcmsST = @26, Conta1 = @27, Conta2 = @28, Conta3 = @29, Conta4 = @30, Conta5 = @31, Conta6 = @32, Vlr1 = @33, Vlr2 = @34, Vlr3 = @35, Vlr4 = @36, Vlr5 = @37, Vlr6 = @38, IsentoIcms = @39, ValorOutrosIcms = @40, IsentoIpi = @41, ValorOutrosIpi = @42, ValorIssqnRetido = @43, Serie = @44, Modelo = @45, FormaPagamento = @46, CFOP = @47, Icms = @48, SubSerie = @49, EspecieDocumento = @50, ChaveNfe = @51, ValorDesconto = @52, CRTfornecedor = @53 Where CompraInterno = " & Me.CompraInterno.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)


            cmd.Parameters.AddWithValue("@2", Nz(Me.NotaFiscal.Text, 1))
            cmd.Parameters.AddWithValue("@3", Nz(Me.DataCompra.Text, 1))
            cmd.Parameters.AddWithValue("@4", Nz(Me.DataEntrada.Text, 1))
            cmd.Parameters.AddWithValue("@5", Nz(Me.CodigoFornecedor.Text, 1))
            cmd.Parameters.AddWithValue("@6", Nz(Me.Obs.Text, 1))
            cmd.Parameters.AddWithValue("@8", Nz(Me.ValorCompra.Text, 1))
            cmd.Parameters.AddWithValue("@9", Nz(Me.BaseCalcIcms.Text, 1))
            cmd.Parameters.AddWithValue("@10", Nz(Me.ValorIcms.Text, 1))
            cmd.Parameters.AddWithValue("@11", Nz(Me.BaseCalcIpi.Text, 1))
            cmd.Parameters.AddWithValue("@12", Nz(Me.VlrIpi.Text, 1))
            cmd.Parameters.AddWithValue("@13", Nz(Me.cTipo.Text, 1))
            cmd.Parameters.AddWithValue("@14", CodEmpresa)
            cmd.Parameters.AddWithValue("@15", Me.Confirmado.Checked)
            cmd.Parameters.AddWithValue("@16", Nz(Me.TotalProdutos.Text, 1))
            cmd.Parameters.AddWithValue("@17", Nz(Me.DataLancamento.Text, 1))
            cmd.Parameters.AddWithValue("@18", NzZero(Me.ValorFrete.Text))
            cmd.Parameters.AddWithValue("@19", NzZero(Me.ValorOutros.Text))
            cmd.Parameters.AddWithValue("@20", Me.TpEntrada.Text)
            cmd.Parameters.AddWithValue("@21", Nz(Me.IdNFdevMae.Text, 1))
            cmd.Parameters.AddWithValue("@22", Nz(Me.NFdevMae.Text, 1))
            cmd.Parameters.AddWithValue("@23", Nz(Me.NFdevMaeValor.Text, 1))
            cmd.Parameters.AddWithValue("@24", Nz(Me.ContaDespesa.Text, 1))
            cmd.Parameters.AddWithValue("@25", Nz(Me.BaseCalcIcmsST.Text, 1))
            cmd.Parameters.AddWithValue("@26", Nz(Me.ValorIcmsST.Text, 1))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.Conta1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.Conta2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.Conta3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.Conta4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.Conta5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.Conta6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.Vlr1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.Vlr2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.Vlr3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.Vlr4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.Vlr5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.Vlr6.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.IsentoIcms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.ValorOutrosIcms.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.IsentoIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.ValorOutrosIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.ValorIssqnRetido.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.Serie.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.Modelo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.FormaPagamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.CFOP.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", Nz(Me.Icms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@49", Nz(Me.SubSerie.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@50", Me.EspecieDocumento.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@51", Nz(Me.ChaveNFe.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@52", Nz(Me.ValorDesconto.Text, 1)))

            Dim CRT As String = Mid(Me.CRTfornecedor.Text, 1, 1)
            cmd.Parameters.Add(New OleDb.OleDbParameter("@53", Nz(CRT, 1)))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validador de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.CompraInterno.Text)
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
        My.Forms.CompraProcurar.ShowDialog()
        LocalizaDados()
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

        Dim Sql As String = "SELECT Compra.*, Compra.CompraInterno, Funcionários.Nome, Fornecedor.RazãoSocial FROM (Compra LEFT JOIN Funcionários ON Compra.CodigoFuncionario = Funcionários.CódigoFuncionário) INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((Compra.CompraInterno)=" & RetornoProcura & "))"



        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader
        Try
            DR = CMD.ExecuteReader
            DR.Read()


            Me.CompraInterno.Text = DR.Item("Compra.CompraInterno") & ""
            Me.NotaFiscal.Text = DR.Item("NotaFiscal") & ""
            Me.DataCompra.Text = DR.Item("DataCompra") & ""
            Me.DataEntrada.Text = DR.Item("DataEntrada") & ""
            Me.DataLancamento.Text = DR.Item("DataLançamento") & ""
            Me.ChaveNFe.Text = DR.Item("ChaveNFe") & ""

            Me.CodigoFornecedor.Text = DR.Item("CodigoFornecedor") & ""
            Me.RazaoSocial.Text = DR.Item("RazãoSocial") & ""
            Me.Obs.Text = DR.Item("Obs") & ""

            Me.ValorDesconto.Text = FormatCurrency(Nz(DR.Item("ValorDesconto"), 3), 2)
            Me.ValorCompra.Text = FormatCurrency(Nz(DR.Item("ValorCompra"), 3), 2)
            Me.TotalProdutos.Text = FormatCurrency(Nz(DR.Item("TotalProdutos"), 3), 2)
            Me.BaseCalcIcms.Text = FormatCurrency(Nz(DR.Item("BaseCalcIcms"), 3), 2)
            Me.ValorIcms.Text = FormatCurrency(Nz(DR.Item("ValorIcms"), 3), 2)
            Me.BaseCalcIpi.Text = FormatCurrency(Nz(DR.Item("BaseCalcIpi"), 3), 2)
            Me.ValorOutros.Text = FormatCurrency(Nz(DR.Item("ValorOutros"), 3), 2)
            Me.Icms.Text = FormatNumber(Nz(DR.Item("Icms"), 3), 2)

            Me.VlrIpi.Text = DR.Item("ValorIpi") & ""
            Me.cTipo.Text = DR.Item("Tipo") & ""

            Me.ValorFrete.Text = FormatCurrency(Nz(DR.Item("ValorFrete"), 3), 2)
            Me.Confirmado.Checked = DR.Item("Confirmado")
            Me.Inativo.Checked = DR.Item("Inativo")


            Me.TpEntrada.Text = DR.Item("TpEntrada") & ""

            Me.IdNFdevMae.Text = DR.Item("IdNFdevMae") & ""
            Me.NFdevMae.Text = DR.Item("NFdevMae") & ""
            Me.NFdevMaeValor.Text = FormatCurrency(Nz(DR.Item("NFdevMaeValor"), 3), 2)
            Me.ContaDespesa.Text = DR.Item("ContaLancamento") & ""

            Me.BaseCalcIcmsST.Text = DR.Item("BaseCalcIcmsST") & ""
            Me.ValorIcmsST.Text = DR.Item("ValorIcmsST") & ""

            Me.Conta1.Text = DR.Item("Conta1") & ""
            AchaContaCR(Me.Conta1.Text, Me.DescConta1)
            Me.Conta2.Text = DR.Item("Conta2") & ""
            AchaContaCR(Me.Conta2.Text, Me.DescConta2)
            Me.Conta3.Text = DR.Item("Conta3") & ""
            AchaContaCR(Me.Conta3.Text, Me.DescConta3)
            Me.Conta4.Text = DR.Item("Conta4") & ""
            AchaContaCR(Me.Conta4.Text, Me.DescConta4)
            Me.Conta5.Text = DR.Item("Conta5") & ""
            AchaContaCR(Me.Conta5.Text, Me.DescConta5)
            Me.Conta6.Text = DR.Item("Conta6") & ""
            AchaContaCR(Me.Conta6.Text, Me.DescConta6)

            Me.Vlr1.Text = DR.Item("Vlr1") & ""
            Me.Vlr2.Text = DR.Item("Vlr2") & ""
            Me.Vlr3.Text = DR.Item("Vlr3") & ""
            Me.Vlr4.Text = DR.Item("Vlr4") & ""
            Me.Vlr5.Text = DR.Item("Vlr5") & ""
            Me.Vlr6.Text = DR.Item("Vlr6") & ""

            Me.IsentoIcms.Text = FormatNumber(Nz(DR.Item("IsentoIcms"), 3), 2)
            Me.ValorOutrosIcms.Text = FormatNumber(Nz(DR.Item("ValorOutrosIcms"), 3), 2)
            Me.IsentoIpi.Text = FormatNumber(Nz(DR.Item("IsentoIpi"), 3), 2)
            Me.ValorOutrosIpi.Text = FormatNumber(Nz(DR.Item("ValorOutrosIpi"), 3), 2)
            Me.ValorIssqnRetido.Text = FormatNumber(Nz(DR.Item("ValorIssqnRetido"), 3), 2)

            Me.Serie.Text = DR.Item("Serie") & ""
            Me.Modelo.Text = DR.Item("Modelo") & ""
            Me.FormaPagamento.Text = DR.Item("FormaPagamento") & ""
            Me.CFOP.Text = DR.Item("CFOP") & ""
            Me.SubSerie.Text = DR.Item("SubSerie") & ""
            Me.EspecieDocumento.Text = DR.Item("EspecieDocumento") & ""

            If NzZero(DR.Item("CRTfornecedor")) = "0" Then Me.CRTfornecedor.Text = "0-Não Defido"
            If NzZero(DR.Item("CRTfornecedor")) = "1" Then Me.CRTfornecedor.Text = DR.Item("CRTfornecedor") & "-Simples Nacional"
            If NzZero(DR.Item("CRTfornecedor")) = "2" Then Me.CRTfornecedor.Text = DR.Item("CRTfornecedor") & "Simples Nacional - Excesso de Sublimite de Receita Bruta."
            If NzZero(DR.Item("CRTfornecedor")) = "3" Then Me.CRTfornecedor.Text = DR.Item("CRTfornecedor") & "-Regime Normal"

            Operation = UPD
            DR.Close()
            CNN.Close()

            If Me.TpEntrada.Text = "DEVOLUÇÃO" Then
                Me.PainelDev.Visible = True
                ListaDevolucao()
            Else
                Me.PainelDev.Visible = False
                Me.DevolucaoTab.Visible = False
            End If

            If Me.ContaDespesa.Text <> "" Then
                AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaCRDesc, False)
            End If

            EncheListaItens()

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
        ExecutaCalculos()
    End Sub
    ''' <summary>
    ''' Enche a lista com os produtos na grade de compra
    ''' </summary>

    Public Sub EncheListaItens()
        If Me.CompraInterno.Text = "" Then
            Exit Sub
        End If



        MyLista.Items.Clear()


        Dim tPis As Double = 0
        Dim tCOFINS As Double = 0
        ValorIpiLancamentos = 0

        Dim CNNIten As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNIten.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNNIten
            .CommandTimeout = 0
            .CommandText = "SELECT Produtos.Descrição, * FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE ItensCompra.CompraInterno = " & Me.CompraInterno.Text & " "
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            ValorProdutosLaçamentos = 0

            Dim VlrFrete As Double = 0

            Dim SomaIcms As Double
            Dim IsentoIcms As Double
            Dim OutrosIcms As Double
            Dim BaseCalcIpi As Double
            Dim IsentoIpi As Double
            Dim OutrosIpi As Double
            Dim BaseCalcST As Double
            Dim VlrIcmsST As Double
            Dim ValorOutros As Double
            Dim BaseCalcIcms As Double

            Dim Zebrar As Boolean = False
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then
                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("ItensCompra.CodigoProduto") & "")
                    item1.SubItems.Add(DataReader.Item("Descrição") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("Qtd"), 2))
                    item1.SubItems.Add(Nz(DataReader.Item("SeqNf"), 2))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorUnitario"), 5))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("TotalProduto"), 2))
                    item1.SubItems.Add(DataReader.Item("CFOP") & "")
                    item1.SubItems.Add(DataReader.Item("CFOPent") & "")


                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    ValorProdutosLaçamentos += CDbl(NzZero(DataReader.Item("TotalProduto")))
                    ValorIpiLancamentos += CDbl(DataReader.Item("ValorIpi"))
                    tPis += CDbl(NzZero(DataReader.Item("ValorPisProduto")))
                    tCOFINS += CDbl(NzZero(DataReader.Item("ValorCofinsProduto")))

                    SomaIcms += CDbl(NzZero(DataReader.Item("ValorIcmsProduto")))
                    IsentoIcms += CDbl(NzZero(DataReader.Item("IsentoIcms")))
                    OutrosIcms += CDbl(NzZero(DataReader.Item("ValorOutrosIcms")))
                    BaseCalcIpi += CDbl(NzZero(DataReader.Item("BaseCalcIpi")))
                    IsentoIpi += CDbl(NzZero(DataReader.Item("IsentoIpi")))
                    OutrosIpi += CDbl(NzZero(DataReader.Item("ValorOutrosIpi")))
                    BaseCalcST += CDbl(NzZero(DataReader.Item("BaseCalcST")))
                    VlrIcmsST += CDbl(NzZero(DataReader.Item("ValorIcmsST")))
                    ValorOutros += CDbl(NzZero(DataReader.Item("vOutro")))
                    BaseCalcIcms += CDbl(NzZero(DataReader.Item("BaseCalcIcms")))

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
                        Zebrar = True
                    End If

                End If
            End While

            Me.TotalItensLançado.Text = FormatNumber(ValorProdutosLaçamentos, 2)
            Me.TotalItensIpi.Text = FormatNumber(ValorIpiLancamentos, 2)
            Me.TotalPis.Text = FormatNumber(tPis, 2)
            Me.TotalCofins.Text = FormatNumber(tCOFINS, 2)

            Me.c1.Text = FormatNumber(BaseCalcST, 2)
            Me.c2.Text = FormatNumber(VlrIcmsST, 2)
            Me.c3.Text = FormatNumber(ValorOutros, 2)
            Me.c4.Text = FormatNumber(BaseCalcIcms, 2)
            Me.c5.Text = FormatNumber(SomaIcms, 2)
            Me.c6.Text = FormatNumber(IsentoIcms, 2)
            Me.c7.Text = FormatNumber(OutrosIcms, 2)
            Me.c8.Text = FormatNumber(BaseCalcIpi, 2)
            Me.c9.Text = FormatNumber(ValorIpiLancamentos, 2)
            Me.c10.Text = FormatNumber(IsentoIpi, 2)
            Me.c11.Text = FormatNumber(OutrosIpi, 2)


            DataReader.Close()
            CNNIten.Close()
            Me.MyLista.Refresh()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub ConfirmarBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarBT.Click
        If Operation = INS Then
            MsgBox("O usuário deve salvar o documento antes de confirmar.", 64, "Validador de Dados")
            Exit Sub
        End If

        Try
            For Each item As ListViewItem In Me.MyLista.Items
                If String.IsNullOrEmpty(item.SubItems(8).Text) Then
                    MessageBox.Show("Tem item(s) sem o codigo de CFOP de Entrada.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        If Me.ValorCompra.Text = 0 Or Me.ValorCompra.Text = "" Then
            MessageBox.Show("O campo [TOTAL NOTA FISCAL] está com valor [0,00]", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ValorCompra.Focus()
            Exit Sub
        End If

        If Me.CFOP.Text = "" Then
            MessageBox.Show("O CFOP de Entrada no cabeçalho da nota não pode ser nulo, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabGeral.SelectedTab = Me.TabItem1
            Me.CFOP.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(ContaDespesa.Text) Then
            MessageBox.Show("A conta de resultado não pode ser nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ContaDespesa.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(Conta1.Text) Then
            MessageBox.Show("O lançamento das contas não podem ser nulo.!", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Conta1.Focus()
            Exit Sub
        End If

        If Me.cTipo.Text = "NF" Then  ' lelo
            If Me.Serie.Text = "" Then
                MessageBox.Show("A Série da NF não pode ser nulo, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.TabGeral.SelectedTab = Me.TabItem1
                Me.Serie.Focus()
                Exit Sub
            End If
        End If
        'Exit Sub '´lelo

        If Me.cTipo.Text = "NF" Then  ' lelo
            If Me.Modelo.Text = "" Then
                MessageBox.Show("O Modelo da NF não pode ser nulo, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.TabGeral.SelectedTab = Me.TabItem1
                Me.Modelo.Focus()
                Exit Sub
            End If
        End If

        If Me.cTipo.Text = "NF" Then  ' lelo
            If Me.FormaPagamento.Text = "" Then
                MessageBox.Show("A Forma de Pagamento não pode ser nulo, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.TabGeral.SelectedTab = Me.TabItem1
                Me.FormaPagamento.Focus()
                Exit Sub
            End If
        End If


        If Me.CFOP.Text = "" Then
            MessageBox.Show("O CFOP de Entrada não pode ser nulo, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabGeral.SelectedTab = Me.TabItem1
            Me.CFOP.Focus()
            Exit Sub
        End If

        If CDbl(NzZero(Me.TotalProdutos.Text)) = 0 Then
            MessageBox.Show("O Valor das Mercadorias não pode ser [0,00], Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabGeral.SelectedTab = Me.TabItem1
            Me.TotalProdutos.Focus()
        End If

        'Funcao para executar calculos da nf
        ExecutaCalculos()

        If MsgBox("Deseja realmente confirmar o lançamento de entrada.", 36, "Validador de Dados") = 6 Then
            If Me.DataLancamento.Text <> DataDia Then
                If MsgBox("A data de Lançamento esta diferente da data do dia deseja continuar com esta data.", 36, "Validador de Dados") = 6 Then
                    'nada a fazer continuar com a data 
                Else
                    Me.DataLancamento.Text = DataDia
                End If
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

            If Me.FormaPagamento.Text <> 9 Then
                If Me.TpEntrada.Text <> "ENT BRINDE" Then
                    If MsgBox("O usuário deverá fazer lançamento para o contas a pagar, Continua...", 36, "Validador de Dados") = MsgBoxResult.Yes Then
                        My.Forms.PagarLancamentos.ShowDialog()
                        MostraPagar()
                    Else
                        MessageBox.Show("Lançamento Cancelado pelo Usuário.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If CancelouPagar = True Then
                        MessageBox.Show("Confirmação cancelada pelo usuário", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
            End If

            'Confirmar a Compra
            Me.Confirmado.Checked = True


            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update Compra set NotaFiscal = @2, DataCompra = @3, DataEntrada = @4, CodigoFornecedor = @5, Obs = @6, ValorCompra = @8, BaseCalcIcms = @9, ValorIcms = @10, BaseCalcIpi = @11, ValorIpi = @12, Tipo = @13, Empresa = @14, Confirmado = @15, TotalProdutos = @16, DataLançamento = @17, ValorFrete = @18, ValorOutros = @19, TpEntrada = @20, BaseCalcIcmsST = @21, ValorIcmsST = @22 Where CompraInterno = " & Me.CompraInterno.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)


            cmd.Parameters.AddWithValue("@2", Nz(Me.NotaFiscal.Text, 1))
            cmd.Parameters.AddWithValue("@3", Nz(Me.DataCompra.Text, 1))
            cmd.Parameters.AddWithValue("@4", Nz(Me.DataEntrada.Text, 1))
            cmd.Parameters.AddWithValue("@5", Nz(Me.CodigoFornecedor.Text, 1))
            cmd.Parameters.AddWithValue("@6", Nz(Me.Obs.Text, 1))
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
            cmd.Parameters.AddWithValue("@21", Nz(Me.BaseCalcIcmsST.Text, 1))
            cmd.Parameters.AddWithValue("@22", Nz(Me.ValorIcmsST.Text, 1))



            Try
                cmd.ExecuteNonQuery()
                CNN.Close()

                If Me.MyLista.Items.Count > 0 Then

                    If Me.TpEntrada.Text = "ENTRADA" Or Me.TpEntrada.Text = "ENT BRINDE" Then
                        'Faz um Insert dos itens na tabela EstoqueUP 
                        AtualizaEstoqueEntrada()

                        System.Threading.Thread.Sleep(2000)
                        Dim EstoqueGeral As New EstoqueAtualizar
                        EstoqueGeral.Run_AtualizadorNFCompra(Me.CompraInterno.Text)
                    Else
                        AtualizaEstoqueDevolucao() 'Atualiza estoque de entrada dos Itens
                        System.Threading.Thread.Sleep(2000)
                        Dim EstoqueGeral As New EstoqueAtualizar
                        EstoqueGeral.Run_AtualizadorNFCompra(Me.CompraInterno.Text)
                    End If
                End If

                MsgBox("Compra confirmada com sucesso", 64, "Validador de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.CompraInterno.Text)
                Me.AdicionarItens.Enabled = False
                ConfImg.Visible = True
                Me.SalvarBT.Enabled = False

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

            'Fim da confirmação da compra

            Ação.Desbloquear_Controle(Me, False)

        End If
        Exit Sub ' lelo
    End Sub

    Private Sub AtualizaEstoqueEntrada()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Faz a insercao de dados na tabela estoque up
        Dim Sql As String = ""
        If Me.cTipo.Text = "DOC" Then
            Sql = "INSERT INTO EstoqueUp (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc ) SELECT ItensCompra.CodigoProduto, (ItensCompra.Qtd), 'E' AS Expr1, 0 AS Expr2, Compra.DataLançamento, Compra.CompraInterno, 'COMPRA' AS Expr3, '" & Me.RazaoSocial.Text & "' AS Expr4, '" & Me.NotaFiscal.Text & "' As Expr5 FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Compra.Empresa)=" & CodEmpresa & "));"
        Else
            Sql = "INSERT INTO EstoqueUp (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc, QtdF ) SELECT ItensCompra.CodigoProduto, (ItensCompra.Qtd), 'E' AS Expr1, 0 AS Expr2, Compra.DataLançamento, Compra.CompraInterno, 'COMPRA' AS Expr3, '" & Me.RazaoSocial.Text & "' AS Expr4, '" & Me.NotaFiscal.Text & "' As Expr5, (ItensCompra.Qtd * ItensCompra.ConversorQtd) FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Compra.Empresa)=" & CodEmpresa & ") AND (Not ((ItensCompra.CFOPent) Like '2551' Or (ItensCompra.CFOPent) like '1551' Or (ItensCompra.CFOPent) Like '2556' Or (ItensCompra.CFOPent) Like '1556')));"
        End If
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        cmd.ExecuteNonQuery()
        'fim da insercao na tabela estoque up.

        'limpa as vareaveis
        cmd = Nothing
        Sql = Nothing

        'atualizar os valores de vendas DataUltimaCompra, ValorCompra e ValoP
        Sql = "UPDATE (Produtos INNER JOIN ItensCompra ON Produtos.CodigoProduto = ItensCompra.CodigoProduto) INNER JOIN Compra ON ItensCompra.CompraInterno = Compra.CompraInterno SET Produtos.ValorCompra = [ItensCompra].[ValorUnitario], Produtos.ValorP = [ItensCompra].[ValorP], Produtos.DataUltimaCompra = [Compra].[DataCompra] WHERE (((Compra.CompraInterno)=" & Me.CompraInterno.Text & "));"
        Dim cmd1 As New OleDb.OleDbCommand(Sql, CNN)
        cmd1.ExecuteNonQuery()
        'fim da autualizacao dos valores

        'CUSTO:: Atualiza os valores de custo
        Dim cmd2 As New OleDb.OleDbCommand
        cmd2.CommandText = "UPDATE Produtos INNER JOIN ItensCompra ON Produtos.CodigoProduto = ItensCompra.CodigoProduto SET Produtos.ValorCompra = [ItensCompra]![ValorUnitario], Produtos.Custo = [ItensCompra]![cCusto], Produtos.ValorVenda = [ItensCompra]![cvalorvenda], Produtos.Ipi = [ItensCompra]![cipi], Produtos.pPIS = [ItensCompra]![cpis], Produtos.FreteEntrada = [ItensCompra]![cfrete], Produtos.pCofins = [ItensCompra]![cCofins], Produtos.MargemLucro = [ItensCompra]![cMargem], Produtos.OutrosIncargos = [ItensCompra]![cOutros], Produtos.CompraAnterior = [ItensCompra]![cCompraAnterior], Produtos.Acrescimo = [ItensCompra]![cAcrescimo], Produtos.IcmsCreditado = [ItensCompra]![cIcmsCreditado], Produtos.IcmsDebitado = [ItensCompra]![cIcmsDebitado], Produtos.DiferencaIcms = [ItensCompra]![cDiferencaIcms], Produtos.Custo2 = [ItensCompra]![cCusto2] WHERE (((ItensCompra.AlterarCusto)=True) AND ((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & "));"
        cmd2.CommandType = CommandType.Text
        cmd2.Connection = CNN
        cmd2.ExecuteNonQuery()
        'CUSTO::FIM DA ATUALIZACAO DOS VALORES DE CUSTO
        '
        'fecha a conexao do banco de dados
        CNN.Close()

    End Sub

    Private Sub AtualizaEstoqueDevolucao()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = ""
        If Me.cTipo.Text = "DOC" Then
            Sql = "INSERT INTO EstoqueUp (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc ) SELECT ItensCompra.CodigoProduto, (ItensCompra.Qtd * -1), 'D' AS Expr1, 0 AS Expr2, Compra.DataLançamento, Compra.CompraInterno, 'DEVOLUCAO' AS Expr3, '" & Me.RazaoSocial.Text & "' AS Expr4, '" & Me.NotaFiscal.Text & "' As Expr5 FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Compra.Empresa)=" & CodEmpresa & "));"
        Else
            Sql = "INSERT INTO EstoqueUp (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc, QtdF ) SELECT ItensCompra.CodigoProduto, (ItensCompra.Qtd * -1), 'D' AS Expr1, 0 AS Expr2, Compra.DataLançamento, Compra.CompraInterno, 'DEVOLUCAO' AS Expr3, '" & Me.RazaoSocial.Text & "' AS Expr4, '" & Me.NotaFiscal.Text & "' As Expr5, (ItensCompra.Qtd * ItensCompra.ConversorQtd) FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((ItensCompra.CompraInterno)=" & Me.CompraInterno.Text & ") AND ((Compra.Empresa)=" & CodEmpresa & "));"
        End If

        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        cmd.ExecuteNonQuery()
        cmd = Nothing
        Sql = Nothing

        'Sql = "UPDATE (Produtos INNER JOIN ItensCompra ON Produtos.CodigoProduto = ItensCompra.CodigoProduto) INNER JOIN Compra ON ItensCompra.CompraInterno = Compra.CompraInterno SET Produtos.ValorCompra = ([ItensCompra].[ValorUnitario]), Produtos.DataUltimaCompra = [Compra].[DataCompra] WHERE (((Compra.CompraInterno)=" & Me.CompraInterno.Text & "));"
        Sql = "UPDATE (Produtos INNER JOIN ItensCompra ON Produtos.CodigoProduto = ItensCompra.CodigoProduto) INNER JOIN Compra ON ItensCompra.CompraInterno = Compra.CompraInterno SET Produtos.ValorCompra = [ItensCompra].[ValorUnitario], Produtos.ValorP = [ItensCompra].[ValorP], Produtos.DataUltimaCompra = [Compra].[DataCompra] WHERE (((Compra.CompraInterno)=" & Me.CompraInterno.Text & "));"
        Dim cmd1 As New OleDb.OleDbCommand(Sql, CNN)
        cmd1.ExecuteNonQuery()

        CNN.Close()

    End Sub

    Private Sub ValorCompra_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorCompra.Enter
        If Me.ValorCompra.Text = "" Then Me.ValorCompra.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub BaseCalcIcms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BaseCalcIcms.Enter, BaseCalcIcmsST.Enter, ValorIcmsST.Enter, NotaFiscal.Enter
        If Me.BaseCalcIcms.Text = "" Then Me.BaseCalcIcms.Text = FormatCurrency(0, 2)
        Me.VlrIpi.Text = FormatNumber(NzZero(Me.TotalItensIpi.Text), 2)
    End Sub

    Private Sub ValorIcms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorIcms.Enter
        ExecutaCalculos()
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

        Try
            If Me.Confirmado.Checked = True Then


                Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.CompraInterno.Text)
                Autorizado = varAutorizado
                If Autorizado = False Then
                    Exit Sub
                End If

                Dim Motivo As String = ""
                'Motivo = InputBox("Informe o motivo para inativar a nota fiscal de compra.", "Validador de Dados")
                'If Motivo = "" Then
                '    MsgBox("Não foi informado o motivo, nota fiscal não será cancelada.", 64, "Validador de Dados")
                '    Exit Sub
                'End If

                If Me.MyLista.Items.Count > 0 Then
                    CancelProdutoEstoque() 'Cancela os produto no Estoque.

                    System.Threading.Thread.Sleep(2000)

                    Dim EstoqueGeral As New EstoqueAtualizar
                    EstoqueGeral.Run_AtualizadorNFCompra(Me.CompraInterno.Text)
                End If

                'verifica se existe contas a pagar para este documento e se ja existe alguma baixa foram baixadas
                Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                CNN.Open()

                Dim sSql As String = String.Empty

                sSql = "Select Pagar.IdCompra, Pagar.Baixado From Pagar Where Pagar.IdCompra = " & Me.CompraInterno.Text & " and Pagar.Baixado = True"
                Dim Ccmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sSql, CNN)
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
                Ccmd = New OleDb.OleDbCommand(sSql, CNN)
                Ccmd.ExecuteNonQuery()



                Dim Sql As String = "Update Compra set Inativo = @1, Obs = @2 Where CompraInterno = " & Me.CompraInterno.Text
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", "Inativado por: " & "UserAtivo & Autorizado por: " & Motivo))

                Try
                    cmd.ExecuteNonQuery()
                Catch x As Exception
                    MsgBox(x.Message)
                    Exit Sub
                End Try

                CNN.Close()
                'Fim do cancelamento da compra

                'MessageBox.Show("Compra inativada com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Ação.Desbloquear_Controle(Me, False)

                Me.Close()
                Me.Dispose()

            Else
                Dim Motivo As String = ""
                Motivo = InputBox("Informe o motivo para inativar a nota fiscal de compra.", "Validador de Dados")
                If Motivo = "" Then
                    MsgBox("Não foi informado o motivo, nota fiscal não sera cancelada.", 64, "Validador de Dados")
                    Exit Sub
                End If

                Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                CNN.Open()

                Dim Sql As String = "Update Compra set Inativo = @1, Obs = @2 Where CompraInterno = " & Me.CompraInterno.Text
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", "Inativado por: " & "UserAtivo & Autorizado por: " & Motivo))

                Try
                    cmd.ExecuteNonQuery()
                    CNN.Close()
                    Me.ConfImg.Visible = True
                    Me.ConfImg.Text = "Cancelada"
                Catch x As Exception
                    MsgBox(x.Message)
                    Exit Sub
                End Try

                MsgBox("Compra Inativada com sucesso", 64, "Validador de Dados")



            End If

            'efetua o commit e confirma as alterações
            'transaction.Commit()
        Catch sqlError As OleDb.OleDbException
            'se ocorreu uma exceção desfaz as alterações 
            'transaction.Rollback()
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
        'Me.BaseCalcIcmsST.Focus()
        Me.TotalProdutos.Focus()
    End Sub

    Private Sub TotalProdutos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalProdutos.Enter
        Me.TotalProdutos.Text = FormatNumber(CDbl(NzZero(Me.TotalItensLançado.Text)) + CDbl(NzZero(Me.ValorOutros.Text)), 4)
    End Sub

    Private Sub AdicionarItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarItens.Click

        If Me.CompraInterno.Text = "" Then
            If Operation = INS Then Salvar_Click(sender, e)
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
            My.Forms.ComprasAddItem.ShowDialog()
            Me.VlrIpi.Text = FormatNumber(NzZero(Me.TotalItensIpi.Text), 2)
            Me.TotalProdutos.Text = FormatNumber(NzZero(Me.TotalItensLançado.Text), 4)


        Catch x As Exception
            MsgBox(x.Message)
        End Try

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick


        If Autorizado = False Then
            If Me.Confirmado.Checked = True Then
                MessageBox.Show("Este iten não pode mais ser editado, pois o pedido já foi confirmado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            ' Exit Sub
        End If

        Dim I As Integer = 0

        Dim idVLR As String = String.Empty

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then idVLR = MyLista.Items(I).Text.Substring(0)
        Next

        My.Forms.ComprasAddItem.Id.Text = idVLR
        My.Forms.ComprasAddItem.LocalizaItens()
        My.Forms.ComprasAddItem.ShowDialog()
        Me.BaseCalcIcms.Focus()
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

        Dim I As Integer = 0
        Dim idVLR As String = String.Empty

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then idVLR = MyLista.Items(I).Text.Substring(0)
        Next

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Delete * from ItensCompra Where id = " & idVLR
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro excluido com sucesso", 64, "Validador de Dados")
            CNN.Close()
            EncheListaItens()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validador de Dados")
        End Try
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        If Me.CompraInterno.Text = "" Then
            MessageBox.Show("Não foi informado nenhuma compra para impressão.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        RelatorioCarregar = "RelCompras"
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

    Private Sub CodigoFornecedor_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CodigoFornecedor.Validating
        If Len(Me.CodigoFornecedor.Text) = 0 Then
        Else
            Dim CNN1 As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN1.Open()

            Dim Sql As String = "SELECT Compra.CompraInterno, Compra.CodigoFornecedor, Compra.NotaFiscal, Compra.Tipo, Compra.Inativo  FROM(Compra) WHERE (((Compra.CodigoFornecedor)=" & Me.CodigoFornecedor.Text & ") AND ((Compra.NotaFiscal)='" & Me.NotaFiscal.Text & "') AND ((Compra.Tipo)='" & cTipo.Text & "') AND ((Compra.Inativo)=False));"

            Dim Cmd As New OleDb.OleDbCommand(Sql, CNN1)
            Dim DR As OleDb.OleDbDataReader

            Try
                DR = Cmd.ExecuteReader

                If Operation = INS Then
                    If DR.HasRows = True Then
                        MsgBox("Já existe um nota com esse numero para este Fornecedor. Verifique", 48, "Atenção")
                        Me.CodigoFornecedor.Focus()
                        Exit Sub
                    End If
                    DR.Close()

                    Sql = "Select * from CompraCtrlPedido Where Fornecedor = " & Me.CodigoFornecedor.Text & " And NotaFiscal = '" & Me.NotaFiscal.Text & "'"
                    Cmd.CommandText = Sql
                    DR = Cmd.ExecuteReader
                    DR.Read()
                    If DR.HasRows = True Then
                        If MessageBox.Show("Esta NF já foi lançada como Docuemnto de Entrada, Deseja Continuar.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                            Me.NotaFiscal.Clear()
                            Me.CodigoFornecedor.Clear()
                            Me.RazaoSocial.Clear()
                            Me.NotaFiscal.Focus()
                        End If
                    End If
                End If
                DR.Close()
                CNN1.Close()

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

        'Dim Sql As String = "SELECT Compra.*, Compra.CompraInterno, Funcionários.Nome, Fornecedor.RazãoSocial FROM (Compra INNER JOIN Funcionários ON Compra.CodigoFuncionario = Funcionários.CódigoFuncionário) INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((Compra.CompraInterno)=" & Me.IdNFdevMae.Text & "))"
        Dim sql As String = "SELECT Compra.*, Compra.CompraInterno, Fornecedor.RazãoSocial FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((Compra.CompraInterno)=" & Me.IdNFdevMae.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader
        Try
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows = True Then
                Me.NFdevMae.Text = DR.Item("NotaFiscal") & ""
                Me.CodigoFornecedor.Text = DR.Item("CodigoFornecedor") & ""
                Me.RazaoSocial.Text = DR.Item("RazãoSocial") & ""

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

        EncheListaItens()
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
        'Me.Conta1.Focus()
        'Me.CodigoFornecedor.Focus() - Lelo
        Me.BaseCalcIcmsST.Focus()
    End Sub

    Private Sub btFindValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindValor.Click

        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.ContaDespesa.Text = varPegaConta
        AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaCRDesc, True)
        Me.ContaDespesa.Focus()


    End Sub

    Public Sub AchaContaBalancete(ByVal ContaBalancete As String, ByVal CampoParaRetornar As Control, ByVal retErro As Boolean)

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
                If CType(CampoParaRetornar, TextBox).Name = "DescConta1" Then Me.Conta1.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta2" Then Me.Conta2.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta3" Then Me.Conta3.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta4" Then Me.Conta4.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta5" Then Me.Conta5.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta6" Then Me.Conta6.Focus()
                Exit Sub
            End If
        End If
        Cnn.Close()
    End Sub

    Private Sub ContaLancamento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaDespesa.Leave
        If String.CompareOrdinal(Me.ContaDespesa.Text, Me.ContaDespesa.TextoAntigo) Then
            AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaCRDesc, True)
        End If
    End Sub

    Private Sub ContaLancamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaDespesa.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.ContaDespesa.Text = varPegaConta
            AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaCRDesc, True)
            Me.ContaDespesa.Focus()
        End If

    End Sub

    Private Sub MostraPagar()

        If Me.CompraInterno.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Pagar.Id, Pagar.Documento, Pagar.NotaFiscal, Pagar.Fornecedor, Pagar.ValorDocumento, Pagar.Vencimento, Pagar.Pagamento FROM(Pagar) WHERE (((Pagar.IdCompra)=" & Me.CompraInterno.Text & "));"

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

    Private Sub btEditarContas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditarContas.Click
        If Me.CompraInterno.Text = "" Then
            MessageBox.Show("Favor informar o documento para alterar as contas.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Confirmado.Checked = False Then
            Exit Sub
        End If

        'Verificar se algum pagamento do documento foi executado
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM Pagar WHERE Pagar.IdCompra = " & Me.CompraInterno.Text & " AND Pagar.Baixado = True"

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
        'Dim CodSegurança As String = InformaCodigoSeguranca()

        Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.CompraInterno.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub

            'If VerificaCodigoSegurança(CodSegurança) = False Then
            '    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            '    Exit Sub
        End If

        My.Forms.PagarLancamentos.ShowDialog()

        'fim
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

    Private Sub btFindFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindFornecedor.Click
        My.Forms.TelaProcuraFor.ShowDialog()
        Me.CodigoFornecedor.Focus()
    End Sub


#Region "Códigos para o Lançamento de Contas"

    Private Sub Find1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find1.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta1.Text = varPegaConta
        AchaContaCR(Me.Conta1.Text, Me.DescConta1)
        Me.Conta1.Focus()

    End Sub

    Private Sub Find2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find2.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta2.Text = varPegaConta
        AchaContaCR(Me.Conta2.Text, Me.DescConta2)
        Me.Conta2.Focus()
    End Sub

    Private Sub Find3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find3.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta3.Text = varPegaConta
        AchaContaCR(Me.Conta3.Text, Me.DescConta3)
        Me.Conta3.Focus()
    End Sub

    Private Sub Find4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find4.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta4.Text = varPegaConta
        AchaContaCR(Me.Conta4.Text, Me.DescConta4)
        Me.Conta4.Focus()
    End Sub

    Private Sub Find5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find5.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta5.Text = varPegaConta
        AchaContaCR(Me.Conta5.Text, Me.DescConta5)
        Me.Conta5.Focus()
    End Sub

    Private Sub Find6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find6.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta6.Text = varPegaConta
        AchaContaCR(Me.Conta6.Text, Me.DescConta6)
        Me.Conta6.Focus()
    End Sub

    Private Sub Conta1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta1.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta1.Text = varPegaConta
            AchaContaCR(Me.Conta1.Text, Me.DescConta1)
            Me.Conta1.Focus()
        End If
    End Sub

    Private Sub Conta2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta2.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta2.Text = varPegaConta
            AchaContaCR(Me.Conta2.Text, Me.DescConta2)
            Me.Conta2.Focus()
        End If
    End Sub

    Private Sub Conta3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta3.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta3.Text = varPegaConta
            AchaContaCR(Me.Conta3.Text, Me.DescConta3)
            Me.Conta3.Focus()
        End If
    End Sub

    Private Sub Conta4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta4.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta4.Text = varPegaConta
            AchaContaCR(Me.Conta4.Text, Me.DescConta4)
            Me.Conta4.Focus()
        End If
    End Sub

    Private Sub Conta5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta5.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta5.Text = varPegaConta
            AchaContaCR(Me.Conta5.Text, Me.DescConta5)
            Me.Conta5.Focus()
        End If
    End Sub

    Private Sub Conta6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta6.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta6.Text = varPegaConta
            AchaContaCR(Me.Conta6.Text, Me.DescConta6)
            Me.Conta6.Focus()
        End If
    End Sub

    Private Sub Conta1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Conta1.Validating, Conta2.Validating, Conta3.Validating, Conta4.Validating, Conta5.Validating, Conta6.Validating
        Select Case CType(sender, TextBox).Name
            Case "Conta1"
                If String.CompareOrdinal(Me.Conta1.Text, Me.Conta1.TextoAntigo) Then
                    AchaContaCR(Me.Conta1.Text, Me.DescConta1)
                End If
            Case "Conta2"
                If String.CompareOrdinal(Me.Conta2.Text, Me.Conta2.TextoAntigo) Then
                    AchaContaCR(Me.Conta2.Text, Me.DescConta2)
                End If
            Case "Conta3"
                If String.CompareOrdinal(Me.Conta3.Text, Me.Conta3.TextoAntigo) Then
                    AchaContaCR(Me.Conta3.Text, Me.DescConta3)
                End If
            Case "Conta4"
                If String.CompareOrdinal(Me.Conta4.Text, Me.Conta4.TextoAntigo) Then
                    AchaContaCR(Me.Conta4.Text, Me.DescConta4)
                End If
            Case "Conta5"
                If String.CompareOrdinal(Me.Conta5.Text, Me.Conta5.TextoAntigo) Then
                    AchaContaCR(Me.Conta5.Text, Me.DescConta5)
                End If
            Case "Conta6"
                If String.CompareOrdinal(Me.Conta6.Text, Me.Conta6.TextoAntigo) Then
                    AchaContaCR(Me.Conta6.Text, Me.DescConta6)
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
                        Dim Resta As Double = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text))
                        If Resta <> 0 Then
                            If CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr1.Focus()
                                Exit Sub
                            End If

                            Me.Conta2.Enabled = True : Me.DescConta2.Enabled = True : Me.Find2.Enabled = True : Me.Vlr2.Enabled = True
                            Me.Vlr2.Text = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text))
                            Me.Vlr3.Text = FormatNumber(0, 2)
                            Me.Vlr4.Text = FormatNumber(0, 2)
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta2.Focus()
                        Else
                            Me.Conta2.Enabled = False : Me.DescConta2.Enabled = False : Me.Find2.Enabled = False : Me.Vlr2.Enabled = False
                            Me.AdicionarItens.Focus()
                        End If
                    End If
                End If

            Case "Vlr2"
                If String.CompareOrdinal(Me.Vlr2.Text, Me.Vlr2.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr2.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr2.Focus()
                                Exit Sub
                            End If

                            Me.Conta3.Enabled = True : Me.DescConta3.Enabled = True : Me.Find3.Enabled = True : Me.Vlr3.Enabled = True
                            Me.Vlr3.Text = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))
                            Me.Vlr4.Text = FormatNumber(0, 2)
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta3.Focus()
                        Else
                            Me.Conta3.Enabled = False : Me.DescConta3.Enabled = False : Me.Find3.Enabled = False : Me.Vlr3.Enabled = False
                            Me.AdicionarItens.Focus()
                        End If
                    End If
                End If
            Case "Vlr3"
                If String.CompareOrdinal(Me.Vlr3.Text, Me.Vlr3.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr3.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr3.Focus()
                                Exit Sub
                            End If

                            Me.Conta4.Enabled = True : Me.DescConta4.Enabled = True : Me.Find4.Enabled = True : Me.Vlr4.Enabled = True
                            Me.Vlr4.Text = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta4.Focus()
                        Else
                            Me.Conta4.Enabled = False : Me.DescConta4.Enabled = False : Me.Find4.Enabled = False : Me.Vlr4.Enabled = False
                            Me.AdicionarItens.Focus()
                        End If
                    End If
                End If
            Case "Vlr4"
                If String.CompareOrdinal(Me.Vlr4.Text, Me.Vlr4.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr4.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr4.Focus()
                                Exit Sub
                            End If

                            Me.Conta5.Enabled = True : Me.DescConta5.Enabled = True : Me.Find5.Enabled = True : Me.Vlr5.Enabled = True
                            Me.Vlr5.Text = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta5.Focus()
                        Else
                            Me.Conta5.Enabled = False : Me.DescConta5.Enabled = False : Me.Find5.Enabled = False : Me.Vlr5.Enabled = False
                            Me.AdicionarItens.Focus()
                        End If
                    End If
                End If
            Case "Vlr5"
                If String.CompareOrdinal(Me.Vlr5.Text, Me.Vlr5.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr5.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr5.Focus()
                                Exit Sub
                            End If

                            Me.Conta6.Enabled = True : Me.DescConta6.Enabled = True : Me.Find6.Enabled = True : Me.Vlr6.Enabled = True
                            Me.Vlr6.Text = CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))
                            Me.Conta6.Focus()
                        Else
                            Me.Conta6.Enabled = False : Me.DescConta6.Enabled = False : Me.Find6.Enabled = False : Me.Vlr6.Enabled = False
                            Me.AdicionarItens.Focus()
                        End If
                    End If
                End If
            Case "Vlr6"
                If (CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text)) - CDbl(NzZero(Me.Vlr6.Text))) < 0 Then
                    MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Vlr6.Focus()
                    Exit Sub
                End If

        End Select


        If CDbl(NzZero(Me.ValorCompra.Text)) < (CDbl(NzZero(Me.Vlr1.Text)) + CDbl(NzZero(Me.Vlr2.Text)) + CDbl(NzZero(Me.Vlr3.Text)) + CDbl(NzZero(Me.Vlr4.Text)) + CDbl(NzZero(Me.Vlr5.Text)) + CDbl(NzZero(Me.Vlr6.Text))) Then
            MessageBox.Show("O Valor dos Lançamentos esta maior que o valor do Pedido, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CType(sender, TextBox).Focus()
            Exit Sub
        End If
    End Sub

#End Region

    Public Sub AchaContaCR(ByVal Conta As String, ByVal CampoParaRetornar As Control)

        If Conta = "" Then Exit Sub

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
            Exit Sub
        End If
        Cnn.Close()
    End Sub
    Private Sub Conta1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Conta1.Leave
        If NzZero(Me.ValorCompra.Text) = 0 Then
            Me.ValorCompra.Focus()
            Exit Sub
        End If

        If NzZero(Me.Vlr1.Text) = 0 Then Me.Vlr1.Text = FormatNumber(Me.ValorCompra.Text, 2)

    End Sub
    Private Sub ExecutaCalculos()

        'ICMS
        If Me.ValorIcms.Text = "" Then Me.ValorIcms.Text = FormatCurrency(0, 2)
        If Me.IsentoIcms.Text = "" Then Me.IsentoIcms.Text = FormatCurrency(0, 2)
        If Me.ValorOutrosIcms.Text = "" Then Me.ValorOutrosIcms.Text = FormatCurrency(0, 2)

        Me.ValorIcms.Text = FormatCurrency(CDbl(CDbl(Me.BaseCalcIcms.Text) * CInt(NzZero(Me.Icms.Text)) / 100), 2)
        Me.ValorOutrosIcms.Text = FormatCurrency(CDbl(Me.ValorCompra.Text) - CDbl(Me.BaseCalcIcms.Text) - CDbl(Me.IsentoIcms.Text), 2)

        'IPI

        If Me.BaseCalcIpi.Text = "" Then
            Me.BaseCalcIpi.Text = FormatCurrency(0, 2)
            Me.ValorOutrosIpi.Text = FormatCurrency(CDbl(NzZero(Me.ValorCompra.Text)) - CDbl(NzZero(Me.BaseCalcIpi.Text)) - CDbl(NzZero(Me.VlrIpi.Text)) - CDbl(NzZero(Me.IsentoIpi.Text)), 2)
        End If

        If Me.ValorOutrosIpi.Text = "" Then Me.ValorOutrosIpi.Text = FormatCurrency(0, 2)
        If Me.IsentoIpi.Text = "" Then Me.IsentoIpi.Text = FormatCurrency(0, 2)
        If Me.VlrIpi.Text = "" Then Me.VlrIpi.Text = FormatCurrency(0, 2)
        Me.ValorOutrosIpi.Text = FormatCurrency(CDbl(Me.ValorCompra.Text) - CDbl(Me.BaseCalcIpi.Text) - CDbl(Me.VlrIpi.Text) - CDbl(Me.IsentoIpi.Text), 2)

    End Sub

    Private Sub Icms_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Icms.Leave, IsentoIcms.Enter, _
    ValorOutrosIcms.Enter, VlrIpi.Leave, IsentoIpi.Enter, ValorOutrosIpi.Enter

        ExecutaCalculos()
    End Sub

    Private Sub btModelos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModelos.Click
        Dim msg As String

        msg = "01 - NOTA FISCAL MODELO 1" & Chr(13)
        msg = msg & "02 - NOTA FISCAL DE VENDA A CONSUMIDOR, MODELO 2" & Chr(13)
        msg = msg & "03 - NOTA FISCAL DE ENTRADA, MODELO 3" & Chr(13)
        msg = msg & "04 - NOTA FISCAL DE PRODUTOR, MODELO 4" & Chr(13)
        msg = msg & "05 - NOTA FISCAL/ CONTA DE ENERGIA ELÉTRICA, MODELO 6" & Chr(13)
        msg = msg & "07 - NOTA FISCAL DE SEVIÇO DE TRANSPORTE, MODELO 7" & Chr(13)
        msg = msg & "21 - NOTA FISCAL DE SERVIÇO DE COMUNICAÇÃO, MODELO 21" & Chr(13)
        msg = msg & "55 - NFE - NOTA FISCAL ELETRONICA" & Chr(13)

        MessageBox.Show(msg, "Informações de Modelo", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Private Sub btFormaPgto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFormaPgto.Click
        Dim msg As String


        msg = "0(À vista)" & Chr(13)
        msg = msg & "1(À prazo)" & Chr(13)
        msg = msg & "9(Sem Pagto)" & Chr(13)

        MessageBox.Show(msg, "Informações de Forma de Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CFOP_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cfop.Validated
        Try
            Dim VarCFOP As Integer = Mid(Me.CFOP.Text, 1, 1)

            If VarCFOP > 2 Then
                MessageBox.Show("Verifique o [CFOP], inválido para esta operação", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CFOP.Clear()
                Me.CFOP.Focus()
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TotalProdutos_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalProdutos.Validated
        'If Me.MyLista.Items.Count > 0 Then
        '    If CDbl(NzZero(Me.TotalProdutos.Text)) <> CDbl(NzZero(Me.TotalItensLançado.Text)) Then
        '        MessageBox.Show("O Valor dos Produto esta diferente do total dos itens lançado, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.TotalProdutos.Focus()
        '    End If
        'End If
    End Sub

    Private Sub TotalProdutos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalProdutos.Leave
        'Me.BaseCalcIcms.Focus()
        Me.ValorFrete.Focus()
    End Sub



    Private Sub btImpXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImpXML.Click
        If Operation <> INS Then
            MessageBox.Show("Para importar o XML o registro deve estar no mode de INSERÇÃO, Selecione o Botão Novo e escolha o arquivo XML referente sua entrada", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "(Arquivos XML) *.Xml | *.xml"
        OpenFileDialog1.Title = "Selecione um arquivo XML para inportar"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            Dim ArquivoXML As String = String.Empty

            ArquivoXML = OpenFileDialog1.FileName
            LerNFe(ArquivoXML)
        End If

    End Sub




    Public Sub LerNFe(ByVal ArquivoNFe As String)


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim dsIntegracao As New DataSet()
        Dim Sql As String = String.Empty

        'Verifica se o arquivo existe
        If Not IO.File.Exists(ArquivoNFe) Then
            MessageBox.Show("O Arquivo não encontrado. Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Segue a rotina abaixo caso encontrou o arquivo xml
        Dim ds As New DataSet()
        ds.ReadXml(ArquivoNFe) 'Le o xml

        Dim SerieTemp As String = String.Empty
        Dim UFemit As String = String.Empty


        If Not ds.Tables.Contains("infNFe") Then
            MessageBox.Show("Erro na estrutura do arquivo ou não é uma NFe.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Ler tabela de Fornecedor e consertas os Dados do Fornecedor

        Dim DsFor As New DataSet
        Dim CnpjFormatado As String = String.Empty
        Dim CRT As String = String.Empty

        If ds.Tables("emit").Columns.Contains("CNPJ") Then CnpjFormatado = ds.Tables("emit").Rows(0)("CNPJ")
        If ds.Tables("emit").Columns.Contains("CPF") Then CnpjFormatado = ds.Tables("emit").Rows(0)("CPF")
        If ds.Tables("enderemit").Columns.Contains("UF") Then UFemit = ds.Tables("enderemit").Rows(0)("UF")

        CnpjFormatado = CnpjFormatado.Insert(2, ".")
        CnpjFormatado = CnpjFormatado.Insert(6, ".")
        CnpjFormatado = CnpjFormatado.Insert(10, "/")
        CnpjFormatado = CnpjFormatado.Insert(15, "-")

        Sql = "SELECT * from Fornecedor where CgcCpf = '" & CnpjFormatado & "'"
        Dim daFor = New OleDb.OleDbDataAdapter(Sql, CNN)
        daFor.Fill(DsFor, "Fornecedores")


        Sql = "Select * from UF"
        Dim DaUF As New OleDb.OleDbDataAdapter(Sql, CNN)
        DaUF.Fill(DsFor, "UF")

        Dim CodFornecedorTemp As Integer 'Pega o codigo do fornecedor editado ou adicionado
        If DsFor.Tables("Fornecedores").Rows.Count = 0 Then
            Dim DRnovo As DataRow
            DRnovo = DsFor.Tables("Fornecedores").NewRow

            Dim Tp As String
            If Len(CnpjFormatado) = 18 Then Tp = "J" Else Tp = "F"


            DRnovo("TipoFornecedor") = Nz(Tp, 1)
            DRnovo("CgcCpf") = Nz(CnpjFormatado, 1)

            If ds.Tables("emit").Columns.Contains("IE") Then DRnovo("IncriçãoEstadual") = ds.Tables("emit").Rows(0)("IE") Else DRnovo("IncriçãoEstadual") = ""
            If ds.Tables("emit").Columns.Contains("CRT") Then CRT = ds.Tables("emit").Rows(0)("CRT") Else CRT = "0"
            If ds.Tables("emit").Columns.Contains("xNome") Then DRnovo("RazãoSocial") = ds.Tables("emit").Rows(0)("xNome") Else DRnovo("RazãoSocial") = ""
            If ds.Tables("emit").Columns.Contains("xNome") Then DRnovo("NomeFantasia") = ds.Tables("emit").Rows(0)("xNome") Else DRnovo("NomeFantasia") = ""
            If ds.Tables("enderEmit").Columns.Contains("xLgr") Then DRnovo("Endereço") = ds.Tables("enderEmit").Rows(0)("xLgr") Else DRnovo("Endereço") = ""
            If ds.Tables("enderEmit").Columns.Contains("xMun") Then DRnovo("Cidade") = ds.Tables("enderEmit").Rows(0)("xMun") Else DRnovo("Cidade") = ""
            If ds.Tables("enderEmit").Columns.Contains("UF") Then DRnovo("Estado") = ds.Tables("enderEmit").Rows(0)("UF") Else DRnovo("Estado") = ""

            Dim Cep As String = String.Empty
            If ds.Tables("enderEmit").Columns.Contains("CEP") Then Cep = ds.Tables("enderEmit").Rows(0)("CEP") Else Cep = ""
            If Len(Cep) > 0 Then
                Cep = Cep.Insert(5, "-")
            End If
            DRnovo("Cep") = Cep

            Dim Fone As String = String.Empty
            If ds.Tables("enderEmit").Columns.Contains("fone") Then
                Fone = ds.Tables("enderEmit").Rows(0)("fone")
                If Len(Fone) > 0 Then
                    Fone = Fone.Insert(6, "-")
                    Fone = Fone.Insert(2, ")")
                    Fone = Fone.Insert(0, "(")
                End If
                DRnovo("Telefone1") = Fone
            Else
                Fone = ""
            End If

            DRnovo("Empresa") = CodEmpresa
            DRnovo("Inativo") = False
            If ds.Tables("enderEmit").Columns.Contains("xBairro") Then DRnovo("Bairro") = ds.Tables("enderEmit").Rows(0)("xBairro") Else DRnovo("Bairro") = ""
            'If ds.Tables("enderEmit").Columns.Contains("nro") Then DRnovo("nro") = ds.Tables("enderEmit").Rows(0)("nro") Else DRnovo("nro") = ""


            If ds.Tables("enderEmit").Columns.Contains("nro") Then
                If ds.Tables("enderEmit").Rows(0)("nro") = "SEM NUMERO" Then
                    DRnovo("nro") = "S/N"
                Else
                    DRnovo("nro") = ds.Tables("enderEmit").Rows(0)("nro")
                End If
            Else
                DRnovo("nro") = ""
            End If



            If ds.Tables("enderEmit").Columns.Contains("xCpl") Then DRnovo("xCpl") = ds.Tables("enderEmit").Rows(0)("xCpl") Else DRnovo("xCpl") = ""

            Dim drUF() As DataRow
            drUF = DsFor.Tables("UF").Select("NomeUF = '" & ds.Tables("enderEmit").Rows(0)("UF") & "'")
            If drUF.Length > 0 Then
                DRnovo("cUF") = drUF(0)("CodigoUF")
            Else
                DRnovo("cUF") = ""
            End If
            If ds.Tables("enderEmit").Columns.Contains("cMun") Then DRnovo("cMun") = ds.Tables("enderEmit").Rows(0)("cMun") Else DRnovo("cMun") = ""
            If ds.Tables("enderEmit").Columns.Contains("cPais") Then DRnovo("cPais") = ds.Tables("enderEmit").Rows(0)("cPais") Else DRnovo("cPais") = "1058"
            If ds.Tables("enderEmit").Columns.Contains("xPais") Then DRnovo("xPais") = ds.Tables("enderEmit").Rows(0)("xPais") Else DRnovo("xPais") = "BRASIL"
            DsFor.Tables("Fornecedores").Rows.Add(DRnovo)

        Else
            Dim Tp As String
            If Len(CnpjFormatado) = 18 Then Tp = "J" Else Tp = "F"

            DsFor.Tables("Fornecedores").Rows(0).BeginEdit()
            DsFor.Tables("Fornecedores").Rows(0)("TipoFornecedor") = Nz(Tp, 1)
            If ds.Tables("emit").Columns.Contains("IE") Then DsFor.Tables("Fornecedores").Rows(0)("IncriçãoEstadual") = ds.Tables("emit").Rows(0)("IE") Else DsFor.Tables("Fornecedores").Rows(0)("IncriçãoEstadual") = ""
            If ds.Tables("emit").Columns.Contains("CRT") Then CRT = ds.Tables("emit").Rows(0)("CRT") Else CRT = "0"
            If ds.Tables("emit").Columns.Contains("xNome") Then DsFor.Tables("Fornecedores").Rows(0)("RazãoSocial") = ds.Tables("emit").Rows(0)("xNome") Else DsFor.Tables("Fornecedores").Rows(0)("RazãoSocial") = ""
            If ds.Tables("emit").Columns.Contains("xNome") Then DsFor.Tables("Fornecedores").Rows(0)("NomeFantasia") = ds.Tables("emit").Rows(0)("xNome") Else DsFor.Tables("Fornecedores").Rows(0)("NomeFantasia") = ""
            If ds.Tables("enderEmit").Columns.Contains("xLgr") Then DsFor.Tables("Fornecedores").Rows(0)("Endereço") = ds.Tables("enderEmit").Rows(0)("xLgr") Else DsFor.Tables("Fornecedores").Rows(0)("Endereço") = ""
            If ds.Tables("enderEmit").Columns.Contains("xMun") Then DsFor.Tables("Fornecedores").Rows(0)("Cidade") = ds.Tables("enderEmit").Rows(0)("xMun") Else DsFor.Tables("Fornecedores").Rows(0)("Cidade") = ""
            If ds.Tables("enderEmit").Columns.Contains("UF") Then DsFor.Tables("Fornecedores").Rows(0)("Estado") = ds.Tables("enderEmit").Rows(0)("UF") Else DsFor.Tables("Fornecedores").Rows(0)("Estado") = ""

            Dim Cep As String = String.Empty
            If ds.Tables("enderEmit").Columns.Contains("CEP") Then Cep = ds.Tables("enderEmit").Rows(0)("CEP") Else Cep = ""
            If Len(Cep) > 0 Then
                Cep = Cep.Insert(5, "-")
            End If
            DsFor.Tables("Fornecedores").Rows(0)("Cep") = Cep

            Dim Fone As String = String.Empty
            If ds.Tables("enderEmit").Columns.Contains("fone") Then
                Fone = ds.Tables("enderEmit").Rows(0)("fone")
                If Len(Fone) > 0 Then
                    Fone = Fone.Insert(6, "-")
                    Fone = Fone.Insert(2, ")")
                    Fone = Fone.Insert(0, "(")
                End If
                DsFor.Tables("Fornecedores").Rows(0)("Telefone1") = Nz(Fone, 1)
            Else
                Fone = ""
            End If

            DsFor.Tables("Fornecedores").Rows(0)("Empresa") = CodEmpresa
            DsFor.Tables("Fornecedores").Rows(0)("Inativo") = False
            If ds.Tables("enderEmit").Columns.Contains("xBairro") Then DsFor.Tables("Fornecedores").Rows(0)("Bairro") = ds.Tables("enderEmit").Rows(0)("xBairro") Else DsFor.Tables("Fornecedores").Rows(0)("Bairro") = ""
            'If ds.Tables("enderEmit").Columns.Contains("nro") Then DsFor.Tables("Fornecedores").Rows(0)("nro") = ds.Tables("enderEmit").Rows(0)("nro") Else DsFor.Tables("Fornecedores").Rows(0)("nro") = ""
            If ds.Tables("enderEmit").Columns.Contains("nro") Then
                If ds.Tables("enderEmit").Rows(0)("nro") = "SEM NUMERO" Then
                    DsFor.Tables("Fornecedores").Rows(0)("nro") = "S/N"
                Else
                    DsFor.Tables("Fornecedores").Rows(0)("nro") = Mid(ds.Tables("enderEmit").Rows(0)("nro"), 1, 8)
                End If
            Else
                DsFor.Tables("Fornecedores").Rows(0)("nro") = ""
            End If

            If ds.Tables("enderEmit").Columns.Contains("xCpl") Then DsFor.Tables("Fornecedores").Rows(0)("xCpl") = ds.Tables("enderEmit").Rows(0)("xCpl") Else DsFor.Tables("Fornecedores").Rows(0)("xCpl") = ""

            Dim drUF() As DataRow
            drUF = DsFor.Tables("UF").Select("NomeUF = '" & ds.Tables("enderEmit").Rows(0)("UF") & "'")
            If drUF.Length > 0 Then
                DsFor.Tables("Fornecedores").Rows(0)("cUF") = drUF(0)("CodigoUF")
            Else
                DsFor.Tables("Fornecedores").Rows(0)("cUF") = ""
            End If
            If ds.Tables("enderEmit").Columns.Contains("cMun") Then DsFor.Tables("Fornecedores").Rows(0)("cMun") = ds.Tables("enderEmit").Rows(0)("cMun") Else DsFor.Tables("Fornecedores").Rows(0)("cMun") = ""
            If ds.Tables("enderEmit").Columns.Contains("cPais") Then DsFor.Tables("Fornecedores").Rows(0)("cPais") = ds.Tables("enderEmit").Rows(0)("cPais") Else DsFor.Tables("Fornecedores").Rows(0)("cPais") = "1058"
            If ds.Tables("enderEmit").Columns.Contains("xPais") Then DsFor.Tables("Fornecedores").Rows(0)("xPais") = ds.Tables("enderEmit").Rows(0)("xPais") Else DsFor.Tables("Fornecedores").Rows(0)("xPais") = "BRASIL"

            DsFor.Tables("Fornecedores").Rows(0).EndEdit()

        End If

        Try

            Dim objBuilder As New OleDb.OleDbCommandBuilder(daFor)
            daFor.Update(DsFor, "Fornecedores")

            'Recarega os dados para o dataSet
            DsFor.Tables.Remove("Fornecedores")

            Sql = "SELECT * from Fornecedor where CgcCpf = '" & CnpjFormatado & "'"
            daFor = New OleDb.OleDbDataAdapter(Sql, CNN)
            daFor.Fill(DsFor, "Fornecedores")

            CodFornecedorTemp = DsFor.Tables("Fornecedores").Rows(0)("CódigoFornecedor")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        '****************************************************


        'Inicia a exportação da nFe

        Dim NumeroNF As String = IIf(ds.Tables("ide").Columns.Contains("nNF"), ds.Tables("ide").Rows(0)("nNF"), 0)
        Sql = "Select * From Compra Where NotaFiscal = '" & NumeroNF & "' and CodigoFornecedor = " & CodFornecedorTemp & " And Inativo = False"

        Dim daNFCompra = New OleDb.OleDbDataAdapter(Sql, CNN)
        daNFCompra.Fill(DsFor, "NFentrada")

        If DsFor.Tables("NFentrada").Rows.Count = 0 Then
            Dim DRnovo As DataRow
            DRnovo = DsFor.Tables("NFentrada").NewRow

            DRnovo("NotaFiscal") = NumeroNF

            Dim ChAcesso As String = String.Empty
            If ds.Tables("infNFe").Columns.Contains("id") Then ChAcesso = Mid(ds.Tables("infNFe").Rows(0)("id"), 4)
            DRnovo("ChaveNFe") = ChAcesso

            If ds.Tables("ide").Columns.Contains("dEmi") Then DRnovo("DataCompra") = Format(CDate(ds.Tables("ide").Rows(0)("dEmi")), "dd/MM/yyyy") Else DRnovo("DataCompra") = DBNull.Value
            DRnovo("DataEntrada") = DataDia
            DRnovo("CodigoFornecedor") = IIf(Not IsDBNull(CodFornecedorTemp), CodFornecedorTemp, DBNull.Value)
            DRnovo("CRTfornecedor") = IIf(Not IsDBNull(CRT), CRT, 0)
            If ds.Tables("ide").Columns.Contains("serie") Then DRnovo("Serie") = ds.Tables("ide").Rows(0)("serie") Else DRnovo("Serie") = DBNull.Value
            If ds.Tables("ide").Columns.Contains("serie") Then SerieTemp = ds.Tables("ide").Rows(0)("serie") Else SerieTemp = ""
            If ds.Tables("ide").Columns.Contains("mod") Then DRnovo("Modelo") = ds.Tables("ide").Rows(0)("mod") Else DRnovo("Modelo") = DBNull.Value
            DRnovo("EspecieDocumento") = "NF-E"
            DRnovo("Tipo") = "NF"
            DRnovo("TpEntrada") = "ENTRADA"
            If ds.Tables("ide").Columns.Contains("indPag") Then DRnovo("FormaPagamento") = ds.Tables("ide").Rows(0)("indPag") Else DRnovo("FormaPagamento") = ""
            If ds.Tables("ICMSTot").Columns.Contains("vNF") Then DRnovo("ValorCompra") = cValor(ds.Tables("ICMSTot").Rows(0)("vNF")) Else DRnovo("ValorCompra") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vBC") Then DRnovo("BaseCalcIcms") = cValor(ds.Tables("ICMSTot").Rows(0)("vBC")) Else DRnovo("BaseCalcIcms") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vICMS") Then DRnovo("ValorIcms") = cValor(ds.Tables("ICMSTot").Rows(0)("vICMS")) Else DRnovo("ValorIcms") = DBNull.Value

            If NzZero(DRnovo("ValorIcms")) > 0 Then
                DRnovo("Icms") = (NzZero(DRnovo("ValorIcms")) / NzZero(DRnovo("BaseCalcIcms"))) * 100
            Else
                DRnovo("Icms") = 0
            End If

            DRnovo("BaseCalcIpi") = 0
            If ds.Tables("ICMSTot").Columns.Contains("vIPI") Then DRnovo("ValorIpi") = cValor(ds.Tables("ICMSTot").Rows(0)("vIPI")) Else DRnovo("ValorIpi") = DBNull.Value
            DRnovo("Empresa") = CodEmpresa
            If ds.Tables("ICMSTot").Columns.Contains("vProd") Then DRnovo("TotalProdutos") = cValor(ds.Tables("ICMSTot").Rows(0)("vProd")) Else DRnovo("TotalProdutos") = DBNull.Value
            DRnovo("DataLançamento") = DataDia
            If ds.Tables("ICMSTot").Columns.Contains("vDesc") Then DRnovo("ValorDesconto") = cValor(ds.Tables("ICMSTot").Rows(0)("vDesc")) Else DRnovo("ValorDesconto") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vFrete") Then DRnovo("ValorFrete") = cValor(ds.Tables("ICMSTot").Rows(0)("vFrete")) Else DRnovo("ValorFrete") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vOutro") Then DRnovo("ValorOutros") = cValor(ds.Tables("ICMSTot").Rows(0)("vOutro")) Else DRnovo("ValorOutros") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vBCST") Then DRnovo("BaseCalcIcmsST") = cValor(ds.Tables("ICMSTot").Rows(0)("vBCST")) Else DRnovo("BaseCalcIcmsST") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vST") Then DRnovo("ValorIcmsST") = cValor(ds.Tables("ICMSTot").Rows(0)("vST")) Else DRnovo("ValorIcmsST") = DBNull.Value
            DRnovo("IsentoIcms") = 0
            DRnovo("ValorOutrosIcms") = 0
            DRnovo("IsentoIpi") = 0
            DRnovo("ValorOutrosIpi") = 0
            DRnovo("ValorIssqnRetido") = 0

            If ds.Tables.Contains("InfAdic") Then
                If ds.Tables("InfAdic").Columns.Contains("infCpl") Then DRnovo("Obs") = ds.Tables("InfAdic").Rows(0)("infCpl") Else DRnovo("Obs") = DBNull.Value
            Else
                DRnovo("Obs") = DBNull.Value
            End If
            DsFor.Tables("NFentrada").Rows.Add(DRnovo)

        Else

            If DsFor.Tables("NFentrada").Rows(0)("Confirmado") = True Then
                MessageBox.Show("Esta Nota Fiscal já cadastrada e confirmada, importação cancelada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            DsFor.Tables("NFentrada").Rows(0).BeginEdit()

            Dim ChAcesso As String = String.Empty
            If ds.Tables("infNFe").Columns.Contains("id") Then ChAcesso = Mid(ds.Tables("infNFe").Rows(0)("id"), 4)
            DsFor.Tables("NFentrada").Rows(0)("ChaveNFe") = ChAcesso

            DsFor.Tables("NFentrada").Rows(0)("NotaFiscal") = NumeroNF
            If ds.Tables("ide").Columns.Contains("dEmi") Then DsFor.Tables("NFentrada").Rows(0)("DataCompra") = Format(CDate(ds.Tables("ide").Rows(0)("dEmi")), "dd/MM/yyyy") Else DsFor.Tables("NFentrada").Rows(0)("DataCompra") = DBNull.Value
            DsFor.Tables("NFentrada").Rows(0)("DataEntrada") = DataDia
            DsFor.Tables("NFentrada").Rows(0)("CodigoFornecedor") = IIf(Not IsDBNull(CodFornecedorTemp), CodFornecedorTemp, DBNull.Value)
            DsFor.Tables("NFentrada").Rows(0)("CRTfornecedor") = CRT

            If ds.Tables("ide").Columns.Contains("serie") Then DsFor.Tables("NFentrada").Rows(0)("Serie") = ds.Tables("ide").Rows(0)("serie") Else DsFor.Tables("NFentrada").Rows(0)("Serie") = DBNull.Value
            If ds.Tables("ide").Columns.Contains("serie") Then SerieTemp = ds.Tables("ide").Rows(0)("serie") Else SerieTemp = ""
            If ds.Tables("ide").Columns.Contains("mod") Then DsFor.Tables("NFentrada").Rows(0)("Modelo") = ds.Tables("ide").Rows(0)("mod") Else DsFor.Tables("NFentrada").Rows(0)("Modelo") = DBNull.Value
            DsFor.Tables("NFentrada").Rows(0)("EspecieDocumento") = "NF-E"
            DsFor.Tables("NFentrada").Rows(0)("Tipo") = "NF"
            DsFor.Tables("NFentrada").Rows(0)("TpEntrada") = "ENTRADA"
            If ds.Tables("ide").Columns.Contains("indPag") Then DsFor.Tables("NFentrada").Rows(0)("FormaPagamento") = ds.Tables("ide").Rows(0)("indPag") Else DsFor.Tables("NFentrada").Rows(0)("FormaPagamento") = ""
            If ds.Tables("ICMSTot").Columns.Contains("vNF") Then DsFor.Tables("NFentrada").Rows(0)("ValorCompra") = cValor(ds.Tables("ICMSTot").Rows(0)("vNF")) Else DsFor.Tables("NFentrada").Rows(0)("ValorCompra") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vBC") Then DsFor.Tables("NFentrada").Rows(0)("BaseCalcIcms") = cValor(ds.Tables("ICMSTot").Rows(0)("vBC")) Else DsFor.Tables("NFentrada").Rows(0)("BaseCalcIcms") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vICMS") Then DsFor.Tables("NFentrada").Rows(0)("ValorIcms") = cValor(ds.Tables("ICMSTot").Rows(0)("vICMS")) Else DsFor.Tables("NFentrada").Rows(0)("ValorIcms") = DBNull.Value

            If NzZero(DsFor.Tables("NFentrada").Rows(0)("ValorIcms")) > 0 Then
                DsFor.Tables("NFentrada").Rows(0)("Icms") = (NzZero(DsFor.Tables("NFentrada").Rows(0)("ValorIcms")) / NzZero(DsFor.Tables("NFentrada").Rows(0)("BaseCalcIcms"))) * 100
            Else
                DsFor.Tables("NFentrada").Rows(0)("Icms") = 0
            End If

            DsFor.Tables("NFentrada").Rows(0)("BaseCalcIpi") = 0
            If ds.Tables("ICMSTot").Columns.Contains("vIPI") Then DsFor.Tables("NFentrada").Rows(0)("ValorIpi") = cValor(ds.Tables("ICMSTot").Rows(0)("vIPI")) Else DsFor.Tables("NFentrada").Rows(0)("ValorIpi") = DBNull.Value
            DsFor.Tables("NFentrada").Rows(0)("Empresa") = CodEmpresa
            If ds.Tables("ICMSTot").Columns.Contains("vProd") Then DsFor.Tables("NFentrada").Rows(0)("TotalProdutos") = cValor(ds.Tables("ICMSTot").Rows(0)("vProd")) Else DsFor.Tables("NFentrada").Rows(0)("TotalProdutos") = DBNull.Value
            DsFor.Tables("NFentrada").Rows(0)("DataLançamento") = DataDia
            If ds.Tables("ICMSTot").Columns.Contains("vDesc") Then DsFor.Tables("NFentrada").Rows(0)("ValorDesconto") = cValor(ds.Tables("ICMSTot").Rows(0)("vDesc")) Else DsFor.Tables("NFentrada").Rows(0)("ValorDesconto") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vFrete") Then DsFor.Tables("NFentrada").Rows(0)("ValorFrete") = cValor(ds.Tables("ICMSTot").Rows(0)("vFrete")) Else DsFor.Tables("NFentrada").Rows(0)("ValorFrete") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vOutro") Then DsFor.Tables("NFentrada").Rows(0)("ValorOutros") = cValor(ds.Tables("ICMSTot").Rows(0)("vOutro")) Else DsFor.Tables("NFentrada").Rows(0)("ValorOutros") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vBCST") Then DsFor.Tables("NFentrada").Rows(0)("BaseCalcIcmsST") = cValor(ds.Tables("ICMSTot").Rows(0)("vBCST")) Else DsFor.Tables("NFentrada").Rows(0)("BaseCalcIcmsST") = DBNull.Value
            If ds.Tables("ICMSTot").Columns.Contains("vST") Then DsFor.Tables("NFentrada").Rows(0)("ValorIcmsST") = cValor(ds.Tables("ICMSTot").Rows(0)("vST")) Else DsFor.Tables("NFentrada").Rows(0)("ValorIcmsST") = DBNull.Value
            DsFor.Tables("NFentrada").Rows(0)("IsentoIcms") = 0
            DsFor.Tables("NFentrada").Rows(0)("ValorOutrosIcms") = 0
            DsFor.Tables("NFentrada").Rows(0)("IsentoIpi") = 0
            DsFor.Tables("NFentrada").Rows(0)("ValorOutrosIpi") = 0
            DsFor.Tables("NFentrada").Rows(0)("ValorIssqnRetido") = 0

            If ds.Tables.Contains("InfAdic") Then
                If ds.Tables("InfAdic").Columns.Contains("infCpl") Then DsFor.Tables("NFentrada").Rows(0)("Obs") = ds.Tables("InfAdic").Rows(0)("infCpl") Else DsFor.Tables("NFentrada").Rows(0)("Obs") = DBNull.Value
            Else
                DsFor.Tables("NFentrada").Rows(0)("Obs") = DBNull.Value
            End If

            DsFor.Tables("NFentrada").Rows(0).EndEdit()
        End If

        Dim Cod_CompraInterno As Integer  'Criado para pegar o registro interno adicionado
        Try

            Dim obj As New OleDb.OleDbCommandBuilder(daNFCompra)
            daNFCompra.Update(DsFor, "NFentrada")

            'Recarregar a Nota de entrada
            DsFor.Tables.Remove("NFentrada")
            Sql = "Select * From Compra Where NotaFiscal = '" & NumeroNF & "' and CodigoFornecedor = " & CodFornecedorTemp & " and Inativo = False"

            daNFCompra = New OleDb.OleDbDataAdapter(Sql, CNN)
            daNFCompra.Fill(DsFor, "NFentrada")

            Cod_CompraInterno = DsFor.Tables("NFentrada").Rows(0)("CompraInterno")

        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, 64, "Validador de Dados")
        End Try

        ' **************************************************************

        'Carrega produtos de integração do Emitente
        Sql = "SELECT * from prodEmit Where CNPJemit = '" & ds.Tables("emit").Rows(0)("CNPJ") & "'"
        Dim daProdInt As New OleDb.OleDbDataAdapter(Sql, CNN)
        daProdInt.Fill(dsIntegracao, "ProdInt")


        ''Ler tabela produtos

        'A tabela TbIT é uma datatable public
        TbIT = New DataTable

        TbIT.Columns.Add("det")
        TbIT.Columns.Add("cProd") : TbIT.Columns.Add("ProdERP") : TbIT.Columns.Add("xProd") : TbIT.Columns.Add("cEAN") : TbIT.Columns.Add("NCM")
        TbIT.Columns.Add("CFOP") : TbIT.Columns.Add("CFOPe") : TbIT.Columns.Add("ctb") : TbIT.Columns.Add("uCom") : TbIT.Columns.Add("qCom") : TbIT.Columns.Add("vUnCom")
        TbIT.Columns.Add("vProd") : TbIT.Columns.Add("cEANTrib") : TbIT.Columns.Add("uTrib") : TbIT.Columns.Add("qTrib")
        TbIT.Columns.Add("vUnTrib") : TbIT.Columns.Add("vDesc") : TbIT.Columns.Add("vFrete") : TbIT.Columns.Add("vSeg")
        TbIT.Columns.Add("vOutro") : TbIT.Columns.Add("indTot")
        'Colunas para o ICMS
        TbIT.Columns.Add("tpICMS") : TbIT.Columns.Add("origICMS") : TbIT.Columns.Add("CSTICMS") : TbIT.Columns.Add("modBC")
        TbIT.Columns.Add("vBC") : TbIT.Columns.Add("pICMS") : TbIT.Columns.Add("vICMS")
        TbIT.Columns.Add("modBCST") : TbIT.Columns.Add("pMVAST") : TbIT.Columns.Add("pRedBCST") : TbIT.Columns.Add("vBCST")
        TbIT.Columns.Add("pICMSST") : TbIT.Columns.Add("vICMSST") : TbIT.Columns.Add("pRedBC")
        TbIT.Columns.Add("vBCSTRet") : TbIT.Columns.Add("vICMSSTRet")
        TbIT.Columns.Add("CSOSN") : TbIT.Columns.Add("pCredSN") : TbIT.Columns.Add("vCredICMSSN")
        TbIT.Columns.Add("motDesICMS")
        'Colunas do Ipi
        TbIT.Columns.Add("CNPJProd") : TbIT.Columns.Add("cSelo") : TbIT.Columns.Add("qSelo")
        TbIT.Columns.Add("cEnq") : TbIT.Columns.Add("CSTIPI") : TbIT.Columns.Add("vBCIPI") : TbIT.Columns.Add("pIPI")
        TbIT.Columns.Add("qUnid") : TbIT.Columns.Add("vUnid") : TbIT.Columns.Add("vIPI")
        'Colunas do Pis
        TbIT.Columns.Add("CSTpis") : TbIT.Columns.Add("vBCpis") : TbIT.Columns.Add("pPIS")
        TbIT.Columns.Add("vPIS") : TbIT.Columns.Add("qBCProd") : TbIT.Columns.Add("vAliqProd")
        'Colunas do Cofins
        TbIT.Columns.Add("CSTcofins")
        TbIT.Columns.Add("vBCcofins")
        TbIT.Columns.Add("pCOFINS")
        TbIT.Columns.Add("vCOFINS")
        TbIT.Columns.Add("qBCProdCofins")
        TbIT.Columns.Add("vAliqProdCofins")



        Dim Linha As DataRow
        If ds.Tables.Contains("det") Then 'Identifica o Item do Produto

            Dim DRnovo As DataRow
            DRnovo = TbIT.NewRow()

            For Each Linha In ds.Tables("det").Rows
                DRnovo("det") = Linha("det_Id")

                If ds.Tables.Contains("Prod") Then ' Identifica o produto do Item
                    Dim F_Prod() As DataRow = ds.Tables("Prod").Select("det_Id = " & Linha("det_Id"))

                    If ds.Tables("Prod").Columns.Contains("cProd") Then DRnovo("cProd") = F_Prod(0)("Cprod")

                    'Codigo do Produto de integraçao sera adicionado aqui
                    'Dim F_ProdInt() As DataRow = dsIntegracao.Tables("ProdInt").Select("ProdEmit = '" & F_Prod(0)("cProd") & "'")
                    Dim F_ProdInt() As DataRow
                    Try
                        F_ProdInt = dsIntegracao.Tables("ProdInt").Select("ProdEmit = '" & F_Prod(0)("cProd") & "'")
                    Catch ex As Exception
                        Dim P As String = F_Prod(0)("cProd")
                        P = P.Replace("'", "''")
                        F_ProdInt = dsIntegracao.Tables("ProdInt").Select("ProdEmit = '" & P & "'")
                    End Try

                    If F_ProdInt.Length > 0 Then
                        DRnovo("ProdErp") = F_ProdInt(0)("ProdErp")
                    End If

                    If ds.Tables("Prod").Columns.Contains("cEAN") Then DRnovo("cEAN") = F_Prod(0)("cEAN")
                    If ds.Tables("Prod").Columns.Contains("xProd") Then DRnovo("xProd") = F_Prod(0)("xProd")
                    If ds.Tables("Prod").Columns.Contains("NCM") Then DRnovo("NCM") = F_Prod(0)("NCM")
                    If ds.Tables("Prod").Columns.Contains("CFOP") Then DRnovo("CFOP") = F_Prod(0)("CFOP")


                    If ds.Tables("Prod").Columns.Contains("uCom") Then DRnovo("uCom") = F_Prod(0)("uCom")
                    If ds.Tables("Prod").Columns.Contains("qCom") Then DRnovo("qCom") = cValor(F_Prod(0)("qCom"))
                    If ds.Tables("Prod").Columns.Contains("vUnCom") Then DRnovo("vUnCom") = cValor(F_Prod(0)("vUnCom"))
                    If ds.Tables("Prod").Columns.Contains("vProd") Then DRnovo("vProd") = cValor(F_Prod(0)("vProd"))
                    If ds.Tables("Prod").Columns.Contains("cEANTrib") Then DRnovo("cEANTrib") = F_Prod(0)("cEANTrib")
                    If ds.Tables("Prod").Columns.Contains("uTrib") Then DRnovo("uTrib") = F_Prod(0)("uTrib")
                    If ds.Tables("Prod").Columns.Contains("qTrib") Then DRnovo("qTrib") = cValor(F_Prod(0)("qTrib"))
                    If ds.Tables("Prod").Columns.Contains("vUnTrib") Then DRnovo("vUnTrib") = cValor(F_Prod(0)("vUnTrib"))
                    If ds.Tables("Prod").Columns.Contains("vDesc") Then DRnovo("vDesc") = cValor(Nz(F_Prod(0)("vDesc"), 3))
                    If ds.Tables("Prod").Columns.Contains("vFrete") Then DRnovo("vFrete") = cValor(Nz(F_Prod(0)("vFrete"), 3))
                    If ds.Tables("Prod").Columns.Contains("vSeg") Then DRnovo("vSeg") = cValor(Nz(F_Prod(0)("vSeg"), 3))
                    If ds.Tables("Prod").Columns.Contains("vDesc") Then DRnovo("vDesc") = cValor(Nz(F_Prod(0)("vDesc"), 3))
                    If ds.Tables("Prod").Columns.Contains("vOutro") Then DRnovo("vOutro") = cValor(Nz(F_Prod(0)("vOutro"), 3))
                    If ds.Tables("Prod").Columns.Contains("indTot") Then DRnovo("indTot") = cValor(F_Prod(0)("indTot"))

                    If ds.Tables.Contains("Imposto") Then 'Identifica se existe imposto no produto
                        Dim F_Imposto() As DataRow = ds.Tables("Imposto").Select("det_Id = " & Linha("det_Id"))

                        If ds.Tables.Contains("ICMS") Then 'Identifica a linha do Icms
                            Dim F_Icms() As DataRow = ds.Tables("ICMS").Select("imposto_Id = " & F_Imposto(0)("imposto_Id"))

                            'analisar para ver qual tabela ira anexar ao imposto de icms

                            If ds.Tables.Contains("ICMS00") Then
                                Dim F_00() As DataRow = ds.Tables("ICMS00").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_00.Length > 0 Then
                                    If ds.Tables("ICMS00").Columns.Contains("orig") Then DRnovo("origICMS") = F_00(0)("orig")
                                    If ds.Tables("ICMS00").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_00(0)("CST")
                                    If ds.Tables("ICMS00").Columns.Contains("modBC") Then DRnovo("modBC") = F_00(0)("modBC")
                                    If ds.Tables("ICMS00").Columns.Contains("vBC") Then DRnovo("vBC") = cValor(F_00(0)("vBC"))
                                    If ds.Tables("ICMS00").Columns.Contains("pICMS") Then DRnovo("pICMS") = cValor(F_00(0)("pICMS"))
                                    If ds.Tables("ICMS00").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(F_00(0)("vICMS"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS10") Then
                                Dim F_10() As DataRow = ds.Tables("ICMS10").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_10.Length > 0 Then
                                    If ds.Tables("ICMS10").Columns.Contains("orig") Then DRnovo("origICMS") = F_10(0)("orig")
                                    If ds.Tables("ICMS10").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_10(0)("CST")
                                    If ds.Tables("ICMS10").Columns.Contains("modBC") Then DRnovo("modBC") = F_10(0)("modBC")
                                    If ds.Tables("ICMS10").Columns.Contains("vBC") Then DRnovo("vBC") = cValor(Nz(F_10(0)("vBC"), 3))
                                    If ds.Tables("ICMS10").Columns.Contains("pICMS") Then DRnovo("pICMS") = cValor(Nz(F_10(0)("pICMS"), 3))
                                    If ds.Tables("ICMS10").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(Nz(F_10(0)("vICMS"), 3))
                                    If ds.Tables("ICMS10").Columns.Contains("modBCST") Then DRnovo("modBCST") = F_10(0)("modBCST")
                                    If ds.Tables("ICMS10").Columns.Contains("pMVAST") Then DRnovo("pMVAST") = cValor(Nz(F_10(0)("pMVAST"), 3))
                                    If ds.Tables("ICMS10").Columns.Contains("pRedBCST") Then DRnovo("pRedBCST") = cValor(Nz(F_10(0)("pRedBCST"), 3))
                                    If ds.Tables("ICMS10").Columns.Contains("vBCST") Then DRnovo("vBCST") = cValor(Nz(F_10(0)("vBCST"), 3))
                                    If ds.Tables("ICMS10").Columns.Contains("pICMSST") Then DRnovo("pICMSST") = cValor(Nz(F_10(0)("pICMSST"), 3))
                                    If ds.Tables("ICMS10").Columns.Contains("vICMSST") Then DRnovo("vICMSST") = cValor(Nz(F_10(0)("vICMSST"), 3))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS20") Then
                                Dim F_20() As DataRow = ds.Tables("ICMS20").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_20.Length > 0 Then
                                    If ds.Tables("ICMS20").Columns.Contains("orig") Then DRnovo("origICMS") = F_20(0)("orig")
                                    If ds.Tables("ICMS20").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_20(0)("CST")
                                    If ds.Tables("ICMS20").Columns.Contains("modBC") Then DRnovo("modBC") = F_20(0)("modBC")
                                    If ds.Tables("ICMS20").Columns.Contains("pRedBC") Then DRnovo("pRedBC") = cValor(Nz(F_20(0)("pRedBC"), 3))
                                    If ds.Tables("ICMS20").Columns.Contains("vBC") Then DRnovo("vBC") = cValor(Nz(F_20(0)("vBC"), 3))
                                    If ds.Tables("ICMS20").Columns.Contains("pICMS") Then DRnovo("pICMS") = cValor(Nz(F_20(0)("pICMS"), 3))
                                    If ds.Tables("ICMS20").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(Nz(F_20(0)("vICMS"), 3))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS30") Then
                                Dim F_30() As DataRow = ds.Tables("ICMS30").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_30.Length > 0 Then
                                    If ds.Tables("ICMS30").Columns.Contains("orig") Then DRnovo("origICMS") = F_30(0)("orig")
                                    If ds.Tables("ICMS30").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_30(0)("CST")
                                    If ds.Tables("ICMS30").Columns.Contains("modBCST") Then DRnovo("modBCST") = F_30(0)("modBCST")
                                    If ds.Tables("ICMS30").Columns.Contains("pMVAST") Then DRnovo("pMVAST") = cValor(Nz(F_30(0)("pMVAST"), 3))
                                    If ds.Tables("ICMS30").Columns.Contains("pRedBCST") Then DRnovo("pRedBCST") = cValor(Nz(F_30(0)("pRedBCST"), 3))
                                    If ds.Tables("ICMS30").Columns.Contains("vBCST") Then DRnovo("vBCST") = cValor(Nz(F_30(0)("vBCST"), 3))
                                    If ds.Tables("ICMS30").Columns.Contains("pICMSST") Then DRnovo("pICMSST") = cValor(Nz(F_30(0)("pICMSST"), 3))
                                    If ds.Tables("ICMS30").Columns.Contains("vICMSST") Then DRnovo("vICMSST") = cValor(Nz(F_30(0)("vICMSST"), 3))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS40") Then
                                Dim F_40() As DataRow = ds.Tables("ICMS40").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_40.Length > 0 Then
                                    If ds.Tables("ICMS40").Columns.Contains("orig") Then DRnovo("origICMS") = F_40(0)("orig")
                                    If ds.Tables("ICMS40").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_40(0)("CST")
                                    If ds.Tables("ICMS40").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(Nz(F_40(0)("vICMS"), 3))
                                    If ds.Tables("ICMS40").Columns.Contains("motDesICMS") Then DRnovo("motDesICMS") = cValor(F_40(0)("motDesICMS"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS41") Then
                                Dim F_41() As DataRow = ds.Tables("ICMS41").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_41.Length > 0 Then
                                    If ds.Tables("ICMS41").Columns.Contains("orig") Then DRnovo("origICMS") = F_41(0)("orig")
                                    If ds.Tables("ICMS41").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_41(0)("CST")
                                    If ds.Tables("ICMS41").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(Nz(F_41(0)("vICMS"), 3))
                                    If ds.Tables("ICMS41").Columns.Contains("motDesICMS") Then DRnovo("motDesICMS") = cValor(F_41(0)("motDesICMS"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS50") Then
                                Dim F_50() As DataRow = ds.Tables("ICMS50").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_50.Length > 0 Then
                                    If ds.Tables("ICMS50").Columns.Contains("orig") Then DRnovo("origICMS") = F_50(0)("orig")
                                    If ds.Tables("ICMS50").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_50(0)("CST")
                                    If ds.Tables("ICMS50").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(F_50(0)("vICMS"))
                                    If ds.Tables("ICMS50").Columns.Contains("motDesICMS") Then DRnovo("motDesICMS") = cValor(F_50(0)("motDesICMS"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS51") Then
                                Dim F_51() As DataRow = ds.Tables("ICMS51").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_51.Length > 0 Then
                                    If ds.Tables("ICMS51").Columns.Contains("orig") Then DRnovo("origICMS") = F_51(0)("orig")
                                    If ds.Tables("ICMS51").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_51(0)("CST")
                                    If ds.Tables("ICMS51").Columns.Contains("modBC") Then DRnovo("modBC") = F_51(0)("modBC")
                                    If ds.Tables("ICMS51").Columns.Contains("pRedBC") Then DRnovo("pRedBC") = cValor(F_51(0)("pRedBC"))
                                    If ds.Tables("ICMS51").Columns.Contains("vBC") Then DRnovo("vBC") = cValor(F_51(0)("vBC"))
                                    If ds.Tables("ICMS51").Columns.Contains("pICMS") Then DRnovo("pICMS") = cValor(F_51(0)("pICMS"))
                                    If ds.Tables("ICMS51").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(F_51(0)("vICMS"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS60") Then
                                Dim F_60() As DataRow = ds.Tables("ICMS60").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_60.Length > 0 Then
                                    If ds.Tables("ICMS60").Columns.Contains("orig") Then DRnovo("origICMS") = F_60(0)("orig")
                                    If ds.Tables("ICMS60").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_60(0)("CST")
                                    If ds.Tables("ICMS60").Columns.Contains("vBCSTRet") Then DRnovo("vBCSTRet") = cValor(F_60(0)("vBCSTRet"))
                                    If ds.Tables("ICMS60").Columns.Contains("vICMSSTRet") Then DRnovo("vICMSSTRet") = cValor(F_60(0)("vICMSSTRet"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS70") Then
                                Dim F_70() As DataRow = ds.Tables("ICMS70").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_70.Length > 0 Then
                                    If ds.Tables("ICMS70").Columns.Contains("orig") Then DRnovo("origICMS") = F_70(0)("orig")
                                    If ds.Tables("ICMS70").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_70(0)("CST")
                                    If ds.Tables("ICMS70").Columns.Contains("modBC") Then DRnovo("modBC") = F_70(0)("modBC")
                                    If ds.Tables("ICMS70").Columns.Contains("pRedBC") Then DRnovo("pRedBC") = cValor(F_70(0)("pRedBC"))
                                    If ds.Tables("ICMS70").Columns.Contains("vBC") Then DRnovo("vBC") = cValor(F_70(0)("vBC"))
                                    If ds.Tables("ICMS70").Columns.Contains("pICMS") Then DRnovo("pICMS") = cValor(F_70(0)("pICMS"))
                                    If ds.Tables("ICMS70").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(F_70(0)("vICMS"))
                                    If ds.Tables("ICMS70").Columns.Contains("modBCST") Then DRnovo("modBCST") = F_70(0)("modBCST")
                                    If ds.Tables("ICMS70").Columns.Contains("pMVAST") Then DRnovo("pMVAST") = cValor(F_70(0)("pMVAST"))
                                    If ds.Tables("ICMS70").Columns.Contains("pRedBCST") Then DRnovo("pRedBCST") = cValor(F_70(0)("pRedBCST"))
                                    If ds.Tables("ICMS70").Columns.Contains("vBCST") Then DRnovo("vBCST") = cValor(F_70(0)("vBCST"))
                                    If ds.Tables("ICMS70").Columns.Contains("pICMSST") Then DRnovo("pICMSST") = cValor(F_70(0)("pICMSST"))
                                    If ds.Tables("ICMS70").Columns.Contains("vICMSST") Then DRnovo("vICMSST") = cValor(F_70(0)("vICMSST"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMS90") Then
                                Dim F_90() As DataRow = ds.Tables("ICMS90").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_90.Length > 0 Then
                                    If ds.Tables("ICMS90").Columns.Contains("orig") Then DRnovo("origICMS") = F_90(0)("orig")
                                    If ds.Tables("ICMS90").Columns.Contains("CST") Then DRnovo("CSTICMS") = F_90(0)("CST")
                                    If ds.Tables("ICMS90").Columns.Contains("modBC") Then DRnovo("modBC") = F_90(0)("modBC")
                                    If ds.Tables("ICMS90").Columns.Contains("vBC") Then DRnovo("vBC") = cValor(F_90(0)("vBC"))
                                    If ds.Tables("ICMS90").Columns.Contains("pRedBC") Then DRnovo("pRedBC") = cValor(F_90(0)("pRedBC"))
                                    If ds.Tables("ICMS90").Columns.Contains("pICMS") Then DRnovo("pICMS") = cValor(F_90(0)("pICMS"))
                                    If ds.Tables("ICMS90").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(F_90(0)("vICMS"))
                                    If ds.Tables("ICMS90").Columns.Contains("modBCST") Then DRnovo("modBCST") = F_90(0)("modBCST")
                                    If ds.Tables("ICMS90").Columns.Contains("pMVAST") Then DRnovo("pMVAST") = cValor(F_90(0)("pMVAST"))
                                    If ds.Tables("ICMS90").Columns.Contains("pRedBCST") Then DRnovo("pRedBCST") = cValor(F_90(0)("pRedBCST"))
                                    If ds.Tables("ICMS90").Columns.Contains("vBCST") Then DRnovo("vBCST") = cValor(F_90(0)("vBCST"))
                                    If ds.Tables("ICMS90").Columns.Contains("pICMSST") Then DRnovo("pICMSST") = cValor(F_90(0)("pICMSST"))
                                    If ds.Tables("ICMS90").Columns.Contains("vICMSST") Then DRnovo("vICMSST") = cValor(F_90(0)("vICMSST"))
                                End If
                            End If
                            'Simples Nacional
                            If ds.Tables.Contains("ICMSSN101") Then
                                Dim F_101() As DataRow = ds.Tables("ICMSSN101").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_101.Length > 0 Then
                                    If ds.Tables("ICMSSN101").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_101(0)("CSOSN")
                                    If ds.Tables("ICMSSN101").Columns.Contains("orig") Then DRnovo("origICMS") = F_101(0)("orig")
                                    If ds.Tables("ICMSSN101").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_101(0)("CSOSN")
                                    If ds.Tables("ICMSSN101").Columns.Contains("pCredSN") Then DRnovo("pCredSN") = cValor(F_101(0)("pCredSN"))
                                    If ds.Tables("ICMSSN101").Columns.Contains("vCredICMSSN") Then DRnovo("vCredICMSSN") = cValor(F_101(0)("vCredICMSSN"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN102") Then
                                Dim F_102() As DataRow = ds.Tables("ICMSSN102").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_102.Length > 0 Then
                                    If ds.Tables("ICMSSN102").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_102(0)("CSOSN")
                                    If ds.Tables("ICMSSN102").Columns.Contains("orig") Then DRnovo("origICMS") = F_102(0)("orig")
                                    If ds.Tables("ICMSSN102").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_102(0)("CSOSN")
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN103") Then
                                Dim F_103() As DataRow = ds.Tables("ICMSSN103").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_103.Length > 0 Then
                                    If ds.Tables("ICMSSN103").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_103(0)("CSOSN")
                                    If ds.Tables("ICMSSN103").Columns.Contains("orig") Then DRnovo("origICMS") = F_103(0)("orig")
                                    If ds.Tables("ICMSSN103").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_103(0)("CSOSN")
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN201") Then
                                Dim F_201() As DataRow = ds.Tables("ICMSSN201").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_201.Length > 0 Then
                                    If ds.Tables("ICMSSN201").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_201(0)("CSOSN")
                                    If ds.Tables("ICMSSN201").Columns.Contains("orig") Then DRnovo("origICMS") = F_201(0)("orig")
                                    If ds.Tables("ICMSSN201").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_201(0)("CSOSN")
                                    If ds.Tables("ICMSSN201").Columns.Contains("modBCST") Then DRnovo("modBCST") = F_201(0)("modBCST")
                                    If ds.Tables("ICMSSN201").Columns.Contains("pMVAST") Then DRnovo("pMVAST") = cValor(F_201(0)("pMVAST"))
                                    If ds.Tables("ICMSSN201").Columns.Contains("pRedBCST") Then DRnovo("pRedBCST") = cValor(F_201(0)("pRedBCST"))
                                    If ds.Tables("ICMSSN201").Columns.Contains("vBCST") Then DRnovo("vBCST") = cValor(F_201(0)("vBCST"))
                                    If ds.Tables("ICMSSN201").Columns.Contains("pICMSST") Then DRnovo("pICMSST") = cValor(F_201(0)("pICMSST"))
                                    If ds.Tables("ICMSSN201").Columns.Contains("vICMSST") Then DRnovo("vICMSST") = cValor(F_201(0)("vICMSST"))
                                    If ds.Tables("ICMSSN201").Columns.Contains("pCredSN") Then DRnovo("pCredSN") = cValor(F_201(0)("pCredSN"))
                                    If ds.Tables("ICMSSN201").Columns.Contains("vCredICMSSN") Then DRnovo("vCredICMSSN") = cValor(F_201(0)("vCredICMSSN"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN202") Then
                                Dim F_202() As DataRow = ds.Tables("ICMSSN202").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_202.Length > 0 Then
                                    If ds.Tables("ICMSSN202").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_202(0)("CSOSN")
                                    If ds.Tables("ICMSSN202").Columns.Contains("orig") Then DRnovo("origICMS") = F_202(0)("orig")
                                    If ds.Tables("ICMSSN202").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_202(0)("CSOSN")
                                    If ds.Tables("ICMSSN202").Columns.Contains("modBCST") Then DRnovo("modBCST") = F_202(0)("modBCST")
                                    If ds.Tables("ICMSSN202").Columns.Contains("pMVAST") Then DRnovo("pMVAST") = cValor(NzZero(F_202(0)("pMVAST")))
                                    If ds.Tables("ICMSSN202").Columns.Contains("pRedBCST") Then DRnovo("pRedBCST") = cValor(F_202(0)("pRedBCST"))
                                    If ds.Tables("ICMSSN202").Columns.Contains("vBCST") Then DRnovo("vBCST") = cValor(F_202(0)("vBCST"))
                                    If ds.Tables("ICMSSN202").Columns.Contains("pICMSST") Then DRnovo("pICMSST") = cValor(F_202(0)("pICMSST"))
                                    If ds.Tables("ICMSSN202").Columns.Contains("vICMSST") Then DRnovo("vICMSST") = cValor(F_202(0)("vICMSST"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN203") Then
                                Dim F_203() As DataRow = ds.Tables("ICMSSN203").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_203.Length > 0 Then
                                    If ds.Tables("ICMSSN203").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_203(0)("CSOSN")
                                    If ds.Tables("ICMSSN203").Columns.Contains("orig") Then DRnovo("origICMS") = F_203(0)("orig")
                                    If ds.Tables("ICMSSN203").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_203(0)("CSOSN")
                                    If ds.Tables("ICMSSN203").Columns.Contains("modBCST") Then DRnovo("modBCST") = F_203(0)("modBCST")
                                    If ds.Tables("ICMSSN203").Columns.Contains("pMVAST") Then DRnovo("pMVAST") = cValor(F_203(0)("pMVAST"))
                                    If ds.Tables("ICMSSN203").Columns.Contains("pRedBCST") Then DRnovo("pRedBCST") = cValor(F_203(0)("pRedBCST"))
                                    If ds.Tables("ICMSSN203").Columns.Contains("vBCST") Then DRnovo("vBCST") = cValor(F_203(0)("vBCST"))
                                    If ds.Tables("ICMSSN203").Columns.Contains("pICMSST") Then DRnovo("pICMSST") = cValor(F_203(0)("pICMSST"))
                                    If ds.Tables("ICMSSN203").Columns.Contains("vICMSST") Then DRnovo("vICMSST") = cValor(F_203(0)("vICMSST"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN300") Then
                                Dim F_300() As DataRow = ds.Tables("ICMSSN300").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_300.Length > 0 Then
                                    If ds.Tables("ICMSSN300").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_300(0)("CSOSN")
                                    If ds.Tables("ICMSSN300").Columns.Contains("orig") Then DRnovo("origICMS") = F_300(0)("orig")
                                    If ds.Tables("ICMSSN300").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_300(0)("CSOSN")
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN400") Then
                                Dim F_400() As DataRow = ds.Tables("ICMSSN400").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_400.Length > 0 Then
                                    If ds.Tables("ICMSSN400").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_400(0)("CSOSN")
                                    If ds.Tables("ICMSSN400").Columns.Contains("orig") Then DRnovo("origICMS") = F_400(0)("orig")
                                    If ds.Tables("ICMSSN400").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_400(0)("CSOSN")
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN500") Then
                                Dim F_500() As DataRow = ds.Tables("ICMSSN500").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_500.Length > 0 Then
                                    If ds.Tables("ICMSSN500").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_500(0)("CSOSN")
                                    If ds.Tables("ICMSSN500").Columns.Contains("orig") Then DRnovo("origICMS") = F_500(0)("orig")
                                    If ds.Tables("ICMSSN500").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_500(0)("CSOSN")
                                    If ds.Tables("ICMSSN500").Columns.Contains("vBCSTRet") Then DRnovo("vBCSTRet") = cValor(F_500(0)("vBCSTRet"))
                                    If ds.Tables("ICMSSN500").Columns.Contains("vICMSSTRet") Then DRnovo("vICMSSTRet") = cValor(F_500(0)("vICMSSTRet"))
                                End If
                            End If
                            If ds.Tables.Contains("ICMSSN900") Then
                                Dim F_900() As DataRow = ds.Tables("ICMSSN900").Select("ICMS_Id = " & F_Icms(0)("ICMS_Id"))

                                If F_900.Length > 0 Then
                                    If ds.Tables("ICMSSN900").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_900(0)("CSOSN")
                                    If ds.Tables("ICMSSN900").Columns.Contains("orig") Then DRnovo("origICMS") = F_900(0)("orig")
                                    If ds.Tables("ICMSSN900").Columns.Contains("CSOSN") Then DRnovo("CSOSN") = F_900(0)("CSOSN")
                                    If ds.Tables("ICMSSN900").Columns.Contains("modBC") Then DRnovo("modBC") = F_900(0)("modBC")
                                    If ds.Tables("ICMSSN900").Columns.Contains("vBC") Then DRnovo("vBC") = cValor(F_900(0)("vBC"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("pRedBC") Then DRnovo("pRedBC") = cValor(F_900(0)("pRedBC"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("pICMS") Then DRnovo("pICMS") = cValor(F_900(0)("pICMS"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("vICMS") Then DRnovo("vICMS") = cValor(F_900(0)("vICMS"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("modBCST") Then DRnovo("modBCST") = F_900(0)("modBCST")
                                    If ds.Tables("ICMSSN900").Columns.Contains("pMVAST") Then DRnovo("pMVAST") = cValor(F_900(0)("pMVAST"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("pRedBCST") Then DRnovo("pRedBCST") = cValor(F_900(0)("pRedBCST"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("vBCST") Then DRnovo("vBCST") = cValor(F_900(0)("vBCST"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("pICMSST") Then DRnovo("pICMSST") = cValor(F_900(0)("pICMSST"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("vICMSST") Then DRnovo("vICMSST") = cValor(F_900(0)("vICMSST"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("pCredSN") Then DRnovo("pCredSN") = cValor(F_900(0)("pCredSN"))
                                    If ds.Tables("ICMSSN900").Columns.Contains("vCredICMSSN") Then DRnovo("vCredICMSSN") = cValor(F_900(0)("vCredICMSSN"))
                                End If
                            End If
                        End If

                        If ds.Tables.Contains("IPI") Then 'Identifica a linha do IPI
                            Dim F_IPI() As DataRow = ds.Tables("IPI").Select("imposto_Id = " & F_Imposto(0)("imposto_Id"))

                            If F_IPI.Length > 0 Then

                                If F_IPI.Length > 0 Then
                                    If ds.Tables("IPI").Columns.Contains("CNPJProd") Then DRnovo("CNPJProd") = F_IPI(0)("CNPJProd")
                                    If ds.Tables("IPI").Columns.Contains("cSelo") Then DRnovo("cSelo") = F_IPI(0)("cSelo")
                                    If ds.Tables("IPI").Columns.Contains("qSelo") Then DRnovo("qSelo") = F_IPI(0)("qSelo")
                                    If ds.Tables("IPI").Columns.Contains("cEnq") Then DRnovo("cEnq") = F_IPI(0)("cEnq")
                                End If

                                If ds.Tables.Contains("IPITrib") Then

                                    Dim F_IPITrib() As DataRow = ds.Tables("IPITrib").Select("IPI_Id = " & F_IPI(0)("IPI_Id"))

                                    If F_IPITrib.Length > 0 Then
                                        If ds.Tables("IPITrib").Columns.Contains("CST") Then DRnovo("CSTIPI") = F_IPITrib(0)("CST")
                                        If ds.Tables("IPITrib").Columns.Contains("vBC") Then DRnovo("vBCIPI") = cValor(Nz(F_IPITrib(0)("vBC"), 3))
                                        If ds.Tables("IPITrib").Columns.Contains("pIPI") Then DRnovo("pIPI") = cValor(Nz(F_IPITrib(0)("pIPI"), 3))
                                        If ds.Tables("IPITrib").Columns.Contains("qUnid") Then DRnovo("qUnid") = cValor(Nz(F_IPITrib(0)("qUnid"), 3))
                                        If ds.Tables("IPITrib").Columns.Contains("vUnid") Then DRnovo("vUnid") = cValor(Nz(F_IPITrib(0)("vUnid"), 3))
                                        If ds.Tables("IPITrib").Columns.Contains("vIPI") Then DRnovo("vIPI") = cValor(Nz(F_IPITrib(0)("vIPI"), 3))
                                    End If
                                End If
                                If ds.Tables.Contains("IPINT") Then
                                    Dim F_IPINT() As DataRow = ds.Tables("IPINT").Select("IPI_Id = " & F_IPI(0)("IPI_Id"))

                                    If F_IPINT.Length > 0 Then
                                        If ds.Tables("IPINT").Columns.Contains("CST") Then DRnovo("CSTIPI") = F_IPINT(0)("CST")
                                    End If
                                End If
                            End If
                        End If 'fim da identicacao do IPI


                        If ds.Tables.Contains("PIS") Then 'Identifica a linha do PIS
                            Dim F_PIS() As DataRow = ds.Tables("PIS").Select("imposto_Id = " & F_Imposto(0)("imposto_Id"))

                            If F_PIS.Length > 0 Then
                                If ds.Tables.Contains("PISAliq") Then
                                    Dim F_PISAliq() As DataRow = ds.Tables("PISAliq").Select("PIS_Id = " & F_PIS(0)("PIS_Id"))

                                    If F_PISAliq.Length > 0 Then
                                        If ds.Tables("PISAliq").Columns.Contains("CST") Then DRnovo("CSTpis") = F_PISAliq(0)("CST")
                                        If ds.Tables("PISAliq").Columns.Contains("vBC") Then DRnovo("vBCpis") = cValor(F_PISAliq(0)("vBC"))
                                        If ds.Tables("PISAliq").Columns.Contains("pPIS") Then DRnovo("pPIS") = cValor(F_PISAliq(0)("pPIS"))
                                        If ds.Tables("PISAliq").Columns.Contains("vPIS") Then DRnovo("vPIS") = cValor(F_PISAliq(0)("vPIS"))
                                    End If
                                End If

                                If ds.Tables.Contains("PISQtde") Then
                                    Dim F_PISQtde() As DataRow = ds.Tables("PISQtde").Select("PIS_Id = " & F_PIS(0)("PIS_Id"))

                                    If F_PISQtde.Length > 0 Then
                                        If ds.Tables("PISQtde").Columns.Contains("CST") Then DRnovo("CSTpis") = F_PISQtde(0)("CST")
                                        If ds.Tables("PISQtde").Columns.Contains("qBCProd") Then DRnovo("qBCProd") = cValor(F_PISQtde(0)("qBCProd"))
                                        If ds.Tables("PISQtde").Columns.Contains("vAliqProd") Then DRnovo("vAliqProd") = cValor(F_PISQtde(0)("vAliqProd"))
                                        If ds.Tables("PISQtde").Columns.Contains("vPIS") Then DRnovo("vPIS") = cValor(F_PISQtde(0)("vPIS"))
                                    End If
                                End If

                                If ds.Tables.Contains("PISNT") Then
                                    Dim F_PISNT() As DataRow = ds.Tables("PISNT").Select("PIS_Id = " & F_PIS(0)("PIS_Id"))

                                    If F_PISNT.Length > 0 Then
                                        If ds.Tables("PISNT").Columns.Contains("CST") Then DRnovo("CSTpis") = F_PISNT(0)("CST")
                                    End If
                                End If

                                If ds.Tables.Contains("PISOutr") Then
                                    Dim F_PISOutr() As DataRow = ds.Tables("PISOutr").Select("PIS_Id = " & F_PIS(0)("PIS_Id"))

                                    If F_PISOutr.Length > 0 Then
                                        If ds.Tables("PISOutr").Columns.Contains("CST") Then DRnovo("CSTpis") = F_PISOutr(0)("CST")
                                        If ds.Tables("PISOutr").Columns.Contains("vBC") Then DRnovo("vBCpis") = cValor(F_PISOutr(0)("vBC"))
                                        If ds.Tables("PISOutr").Columns.Contains("pPIS") Then DRnovo("pPIS") = cValor(F_PISOutr(0)("pPIS"))
                                        If ds.Tables("PISOutr").Columns.Contains("qBCProd") Then DRnovo("qBCProd") = cValor(F_PISOutr(0)("qBCProd"))
                                        If ds.Tables("PISOutr").Columns.Contains("vAliqProd") Then DRnovo("vAliqProd") = cValor(F_PISOutr(0)("vAliqProd"))
                                        If ds.Tables("PISOutr").Columns.Contains("vPIS") Then DRnovo("vPIS") = cValor(F_PISOutr(0)("vPIS"))
                                    End If
                                End If
                            End If
                        End If 'fim da identicacao do PIS

                        If ds.Tables.Contains("COFINS") Then 'Identifica a linha do COFINS
                            Dim F_COFINS() As DataRow = ds.Tables("COFINS").Select("imposto_Id = " & F_Imposto(0)("imposto_Id"))

                            If F_COFINS.Length > 0 Then
                                If ds.Tables.Contains("COFINSAliq") Then
                                    Dim F_COFINSAliq() As DataRow = ds.Tables("COFINSAliq").Select("COFINS_Id = " & F_COFINS(0)("COFINS_Id"))

                                    If F_COFINSAliq.Length > 0 Then
                                        If ds.Tables("COFINSAliq").Columns.Contains("CST") Then DRnovo("CSTcofins") = F_COFINSAliq(0)("CST")
                                        If ds.Tables("COFINSAliq").Columns.Contains("vBC") Then DRnovo("vBCcofins") = cValor(F_COFINSAliq(0)("vBC"))
                                        If ds.Tables("COFINSAliq").Columns.Contains("pCOFINS") Then DRnovo("pCOFINS") = cValor(F_COFINSAliq(0)("pCOFINS"))
                                        If ds.Tables("COFINSAliq").Columns.Contains("vCOFINS") Then DRnovo("vCOFINS") = cValor(F_COFINSAliq(0)("vCOFINS"))
                                    End If
                                End If

                                If ds.Tables.Contains("COFINSQtde") Then
                                    Dim F_CofinsQtde() As DataRow = ds.Tables("COFINSQtde").Select("COFINS_Id = " & F_COFINS(0)("COFINS_Id"))

                                    If F_CofinsQtde.Length > 0 Then
                                        If ds.Tables("COFINSQtde").Columns.Contains("CST") Then DRnovo("CSTcofins") = F_CofinsQtde(0)("CST")
                                        If ds.Tables("COFINSQtde").Columns.Contains("qBCProd") Then DRnovo("qBCProdcofins") = cValor(F_CofinsQtde(0)("qBCProd"))
                                        If ds.Tables("COFINSQtde").Columns.Contains("vAliqProd") Then DRnovo("vAliqProdcofins") = cValor(F_CofinsQtde(0)("vAliqProd"))
                                        If ds.Tables("COFINSQtde").Columns.Contains("vCOFINS") Then DRnovo("vCOFINS") = cValor(F_CofinsQtde(0)("vCOFINS"))
                                    End If
                                End If

                                If ds.Tables.Contains("COFINSNT") Then
                                    Dim F_COFINSNT() As DataRow = ds.Tables("COFINSNT").Select("COFINS_Id = " & F_COFINS(0)("COFINS_Id"))

                                    If F_COFINSNT.Length > 0 Then
                                        If ds.Tables("COFINSNT").Columns.Contains("CST") Then DRnovo("CSTcofins") = F_COFINSNT(0)("CST")
                                    End If
                                End If

                                If ds.Tables.Contains("COFINSOutr") Then
                                    Dim F_COFINSOutr() As DataRow = ds.Tables("COFINSOutr").Select("COFINS_Id = " & F_COFINS(0)("COFINS_Id"))

                                    If F_COFINSOutr.Length > 0 Then
                                        If ds.Tables("COFINSOutr").Columns.Contains("CST") Then DRnovo("CSTcofins") = F_COFINSOutr(0)("CST")
                                        If ds.Tables("COFINSOutr").Columns.Contains("vBC") Then DRnovo("vBCcofins") = cValor(F_COFINSOutr(0)("vBC"))
                                        If ds.Tables("COFINSOutr").Columns.Contains("pCOFINS") Then DRnovo("pCOFINS") = cValor(F_COFINSOutr(0)("pCOFINS"))
                                        If ds.Tables("COFINSOutr").Columns.Contains("qBCProd") Then DRnovo("qBCProdcofins") = cValor(F_COFINSOutr(0)("qBCProd"))
                                        If ds.Tables("COFINSOutr").Columns.Contains("vAliqProd") Then DRnovo("vAliqProdcofins") = cValor(F_COFINSOutr(0)("vAliqProd"))
                                        If ds.Tables("COFINSOutr").Columns.Contains("vCOFINS") Then DRnovo("vCOFINS") = cValor(F_COFINSOutr(0)("vCOFINS"))
                                    End If
                                End If
                            End If
                        End If 'fim da identicacao do COFINS

                    End If
                End If

                TbIT.Rows.Add(DRnovo)
                DRnovo = TbIT.NewRow()
            Next

        End If

        TbIT.Columns.Add("Desdobramento") 'Cria a Coluna Desdobramento

        Dim CFOPvetor As New ArrayList
        Dim Indice As Integer = -1

        Dim ILoop As Integer
        For ILoop = 0 To TbIT.Rows.Count - 1

            Indice = CFOPvetor.IndexOf(TbIT.Rows(ILoop)("CFOP"))
            If Indice = -1 Then
                CFOPvetor.Add(TbIT.Rows(ILoop)("CFOP"))
            End If

            Indice = CFOPvetor.IndexOf(TbIT.Rows(ILoop)("CFOP"))

            TbIT.Rows(ILoop).BeginEdit()
            TbIT.Rows(ILoop)("Desdobramento") = (Indice + 1)
            TbIT.Rows(ILoop).EndEdit()

        Next


        ItensErrado = 0
        My.Forms.CompraXmlProdutoImportar.CnpjEmitente = ds.Tables("emit").Rows(0)("CNPJ")
        My.Forms.CompraXmlProdutoImportar.ShowDialog()

        If ItensErrado > 0 Then
            Exit Sub
        End If


        'Limpar os itens para importação
        Sql = "Select * From ItensCompra Where CompraInterno = " & Cod_CompraInterno
        Dim cmdEx As New OleDb.OleDbCommand(Sql, CNN)
        cmdEx.ExecuteNonQuery()

        'Adicionar informações de entrada do Produto no item

        Dim SqlMontar As String = String.Empty
        Dim I As Integer

        For I = 0 To TbIT.Rows.Count - 1

            If I < (TbIT.Rows.Count - 1) Then
                SqlMontar &= TbIT.Rows(I)("ProdERP") & " Or CodigoProduto = "
            ElseIf I = (TbIT.Rows.Count - 1) Then
                SqlMontar &= TbIT.Rows(I)("ProdERP")
            End If
        Next

        'Carrega os produtos relacionados para dentro da Tabela no dataset
        Sql = "SELECT * from Produtos where CodigoProduto = " & SqlMontar
        Dim daProdutos = New OleDb.OleDbDataAdapter(Sql, CNN)
        daProdutos.Fill(DsFor, "Produtos")

        Sql = "Select * from Empresa Where CódigoEmpresa = " & CodEmpresa
        Dim daEmpresa = New OleDb.OleDbDataAdapter(Sql, CNN)
        daEmpresa.Fill(DsFor, "Empresa")

        Sql = "Select * from CFOPsaientra"
        Dim daCFOPse As New OleDb.OleDbDataAdapter(Sql, CNN)
        daCFOPse.Fill(DsFor, "CFOPse")

        Sql = "Select * From ItensCompra Where CompraInterno = " & Cod_CompraInterno
        Dim daNFItens = New OleDb.OleDbDataAdapter(Sql, CNN)
        daNFItens.Fill(DsFor, "NFitens")

        Dim dRow As DataRow
        For Each dRow In TbIT.Rows
            Dim LinhaIT() As DataRow
            LinhaIT = DsFor.Tables("NFitens").Select("CodigoProduto = " & dRow("ProdErp") & " And CompraInterno = " & Cod_CompraInterno)

            'Acha no Cadastro de Produto para fazer Integração de Algumas informaçoes
            Dim LinhaProduto() As DataRow
            LinhaProduto = DsFor.Tables("Produtos").Select("CodigoProduto = " & dRow("ProdErp"))

            If LinhaIT.Length = 0 Then

                Dim DRnovo As DataRow

                DRnovo = DsFor.Tables("NFitens").NewRow
                DRnovo("CompraInterno") = Cod_CompraInterno
                DRnovo("CodigoProduto") = dRow("ProdErp")
                DRnovo("Serie") = SerieTemp
                DRnovo("Qtd") = dRow("qCom")
                DRnovo("ConversorQtd") = "1"
                DRnovo("ValorUnitario") = Nz(dRow("vUnCom"), 3)
                'DRnovo("Desconto") = dRow("")
                DRnovo("ValorDesconto") = Nz(dRow("vDesc"), 3)
                DRnovo("Ipi") = Nz(dRow("pIPI"), 3)
                DRnovo("ValorIpi") = Nz(dRow("vIPI"), 3)
                DRnovo("TotalProduto") = Nz(dRow("vProd"), 3)

                Dim VarCstICMS As String = String.Empty
                If Not dRow.IsNull("CSTICMS") Then
                    VarCstICMS = Nz(dRow("CSTICMS"), 1)
                End If

                If Len(VarCstICMS) = 0 Then VarCstICMS = Nz(dRow("CSOSN"), 1)
                DRnovo("CSTICMS") = VarCstICMS

                DRnovo("Cf") = dRow("NCM")
                DRnovo("SeqNf") = (CInt(dRow("det")) + 1)
                DRnovo("CFOP") = dRow("CFOP")
                DRnovo("IcmsProduto") = Nz(dRow("pICMS"), 3)
                DRnovo("ValorIcmsProduto") = Nz(dRow("vICMS"), 3)
                DRnovo("PisProduto") = Nz(dRow("pPIS"), 3)
                DRnovo("ValorPisProduto") = Nz(dRow("vPIS"), 3)
                DRnovo("CofinsProduto") = Nz(dRow("pCOFINS"), 3)
                DRnovo("ValorCofinsProduto") = Nz(dRow("vCOFINS"), 3)
                'DRnovo("FreteProduto") = dRow("")
                DRnovo("ValorFreteProduto") = Nz(dRow("vFrete"), 3)
                DRnovo("ValorP") = Nz(dRow("vUnCom"), 3)
                DRnovo("AlterarCusto") = False
                DRnovo("IsentoIpi") = 0
                DRnovo("ValorOutrosIpi") = 0
                DRnovo("IsentoIcms") = 0
                DRnovo("ValorOutrosIcms") = 0
                DRnovo("BaseCalcIcms") = Nz(dRow("vBC"), 3)
                DRnovo("BaseCalcIpi") = Nz(dRow("vBCIPI"), 3)
                DRnovo("vSeg") = Nz(dRow("vSeg"), 3)
                DRnovo("vOutro") = Nz(dRow("vOutro"), 3)
                DRnovo("cEnq") = IIf(dRow.IsNull("cEnq"), "", dRow("cEnq"))
                DRnovo("CSTIPI") = IIf(dRow.IsNull("CSTIPI"), "", dRow("CSTIPI"))
                DRnovo("CSTpis") = Nz(dRow("CSTpis"), 1)
                DRnovo("vBCpis") = Nz(dRow("vBCpis"), 3)
                DRnovo("CSTcofins") = Nz(dRow("CSTcofins"), 3)
                DRnovo("vBCcofins") = Nz(dRow("vBCcofins"), 3)
                DRnovo("BaseCalcST") = Nz(dRow("vBCST"), 3)
                DRnovo("AliquotaIcmsST") = Nz(dRow("pICMSST"), 3)
                DRnovo("ValorIcmsST") = Nz(dRow("vICMSST"), 3)

                Dim drCFOPentrada() As DataRow
                drCFOPentrada = DsFor.Tables("CFOPse").Select("Empresa = " & CodEmpresa & " and cfopS = '" & dRow("CFOP") & "'")

                If drCFOPentrada.Length > 0 Then
                    DRnovo("CFOPent") = Nz(drCFOPentrada(0)("cfopE"), 1)
                    DRnovo("ctb") = Nz(drCFOPentrada(0)("ctb"), 1)
                End If

                DRnovo("CSTICMSent") = Nz(LinhaProduto(0)("icmsCSTEntr"), 2)
                DRnovo("CSTIPIent") = Nz(LinhaProduto(0)("cstIPIentr"), 2)
                DRnovo("CSTPISent") = Nz(LinhaProduto(0)("cstPISentr"), 2)
                DRnovo("CSTCOFINSent") = Nz(LinhaProduto(0)("cstCOFINSentr"), 2)

                DsFor.Tables("NFitens").Rows.Add(DRnovo)

                Try
                    Dim obj As New OleDb.OleDbCommandBuilder(daNFItens)
                    daNFItens.Update(DsFor, "NFitens")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                

            End If
        Next


        '********************************************************************************************************

        'Finalizando a Inportação
        CNN.Close()
        System.Threading.Thread.Sleep(400)
        RetornoProcura = Cod_CompraInterno
        LocalizaDados()

    End Sub


    Private Function cValor(ByVal Valor As String) As String
        If Len(Valor) > 0 Then
            Valor = Valor.Replace(".", ",")
        Else
            Valor = "0,00"
        End If
        Return Valor
    End Function

    Private Sub ExcluirTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirTodosToolStripMenuItem.Click
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

        Dim Sql As String = "Delete * from ItensCompra Where CompraInterno = " & Me.CompraInterno.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro excluido com sucesso", 64, "Validador de Dados")
            CNN.Close()
            EncheListaItens()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validador de Dados")
        End Try
    End Sub
End Class