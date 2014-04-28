Imports System.IO
Public Class EmpresaConfiguracao

    Public IdContaLanc As String 'JUROS/MULTA/DESCONTO/VALORDOC

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.DescontoLinha.Checked = False And Me.ComPorProduto.Checked = True Then
            MessageBox.Show("O usuário não pode usar Comissão por Produto e dar desconto no Total do Pedido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ComPorProduto.Checked = False
            Exit Sub
        End If



       
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update Empresa set  cJurosReceber = @1, cMultaReceber = @2, cDescReceber = @3, cValorReceber = @4, cJurosPagar = @5, cMultaPagar = @6, cDescPagar = @7, cValorPagar = @8, ContaBalanceteVendaAvista = @9, VerderEstoqueNegativo = @10, ReciboVendaVista = @11, DescontoLinha = @12, ComPorProduto = @13, ComPorVendedor = @14, ComRecebimento = @15, EmitirDuplicataPedidoConfirmado = @16, ModeloDp = @17, ValidadeOrcamento = @18, ParcelamentoFixo = @19, ComFaixa = @20, NaoValidaCpfCnpj = @21, SemComissao = @22, UsarGradeProdutos = @23, UsarServico = @24, DescontoGerencia = @25, EnterCodBarra = @26, ContaCRVenda = @27, ISSQN=@28, VendedorFechaPedido = @29, UsarPedidoSellShoes = @30, CaixaMovimento = @31, UserAlertaAgendaServico = @32, EntradaDesmenbrarNF = @33, DiaFechamentoMensal = @34, UsaMateriaPrima = @35, Manual = @36, Leitor = @37, ContaCCJuros = @38, ContaCCMulta = @39, ContaCCDescConcedido = @40 Where CódigoEmpresa = " & My.Forms.Empresa.CódigoEmpresa.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.cJurosReceber.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.cMultaReceber.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.cDescReceber.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.cValorReceber.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.cJurosPagar.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.cMultaPagar.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.cDescPagar.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.cValorPagar.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.ContaBalanceteVendaAvista.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.VenderEstoqueNegativo.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.ReciboVendaVista.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Me.DescontoLinha.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Me.ComPorProduto.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Me.ComPorVendedor.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Me.ComRecebimento.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Me.EmitirDuplicataPedidoConfirmado.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.ModeloDP.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ValidadeOrcamento.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Me.ParcelamentoFixo.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Me.ComFaixa.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Me.NaoValidaCpfCnpj.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Me.SemComissao.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Me.UsarGradeProdutos.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Me.UsarServico.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.DescontoGerencia.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Me.EnterCodBarra.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.ContaCRVenda.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@28", NzZero(Me.ISSQN.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Me.VendedorFechaPedido.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Me.UsarPedidoSellShoes.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.CaixaMovimento.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.UserAlertaAgendaServico.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Me.EntradaDesmenbrarNF.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@34", NzZero(Me.txtDiaFechamentoMensal.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Me.chkUsaMateriaPrima.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Me.rdmAcessoManual.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Me.rdnAcessoLeitor.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.ContaCCJuros.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.ContaCCMulta.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.ContaCCDescConcedido.Text, 1)))


        Try
            cmd.ExecuteNonQuery()
            DiaFechamentoMensal = Me.txtDiaFechamentoMensal.Text
            CNN.Close()
            MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Editou, My.Forms.Empresa.CódigoEmpresa.Text)
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try
    End Sub


    Public Sub LocalizaDadosEmpresa()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & My.Forms.Empresa.CódigoEmpresa.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.cJurosReceber.Text = DR.Item("cJurosReceber") & ""
            Me.cMultaReceber.Text = DR.Item("cMultaReceber") & ""
            Me.cDescReceber.Text = DR.Item("cDescReceber") & ""
            Me.cValorReceber.Text = DR.Item("cValorReceber") & ""

            Me.cJurosPagar.Text = DR.Item("cJurosPagar") & ""
            Me.cMultaPagar.Text = DR.Item("cMultaPagar") & ""
            Me.cDescPagar.Text = DR.Item("cDescPagar") & ""
            Me.cValorPagar.Text = DR.Item("cValorPagar") & ""

            Me.ContaCCJuros.Text = DR.Item("ContaCCJuros") & ""
            Me.ContaCCMulta.Text = DR.Item("ContaCCMulta") & ""
            Me.ContaCCDescConcedido.Text = DR.Item("ContaCCDescConcedido") & ""

            Me.ContaBalanceteVendaAvista.Text = DR.Item("ContaBalanceteVendaAvista") & ""
            Me.VenderEstoqueNegativo.Checked = DR.Item("VerderEstoqueNegativo")
            Me.ReciboVendaVista.Checked = DR.Item("ReciboVendaVista")
            Me.DescontoLinha.Checked = DR.Item("DescontoLinha")
            Me.ParcelamentoFixo.Checked = DR.Item("ParcelamentoFixo")
            Me.NaoValidaCpfCnpj.Checked = DR.Item("NaoValidaCpfCnpj")

            Me.ComPorProduto.Checked = DR.Item("ComPorProduto")
            Me.ComPorVendedor.Checked = DR.Item("ComPorVendedor")
            Me.ComRecebimento.Checked = DR.Item("ComRecebimento")
            Me.ComFaixa.Checked = DR.Item("ComFaixa")
            Me.SemComissao.Checked = DR.Item("SemComissao")
            Me.UsarGradeProdutos.Checked = DR.Item("UsarGradeProdutos")
            Me.UsarServico.Checked = DR.Item("UsarServico")
            Me.EnterCodBarra.Checked = DR.Item("EnterCodBarra")
            Me.txtDiaFechamentoMensal.Text = NzZero(DR.Item("DiaFechamentoMensal"))
            Me.EmitirDuplicataPedidoConfirmado.Checked = DR.Item("EmitirDuplicataPedidoConfirmado")
            Me.ModeloDP.Text = DR.Item("ModeloDP") & ""
            Me.ValidadeOrcamento.Text = DR.Item("ValidadeOrcamento") & ""

            Me.DescontoGerencia.Text = DR.Item("DescontoGerencia") & ""
            Me.ContaCRVenda.Text = DR.Item("ContaCRVenda") & ""
            Me.ISSQN.Text = NzZero(DR.Item("ISSQN"))
            Me.VendedorFechaPedido.Checked = DR.Item("VendedorFechaPedido")
            Me.UsarPedidoSellShoes.Checked = DR.Item("UsarPedidoSellShoes")
            Me.CaixaMovimento.Text = DR.Item("CaixaMovimento") & ""
            Me.UserAlertaAgendaServico.Text = DR.Item("UserAlertaAgendaServico") & ""
            Me.EntradaDesmenbrarNF.Checked = DR.Item("EntradaDesmenbrarNF")
            Me.chkUsaMateriaPrima.Checked = DR.Item("UsaMateriaPrima")
            Me.rdmAcessoManual.Checked = DR.Item("Manual")
            Me.rdnAcessoLeitor.Checked = DR.Item("Leitor")
        End If

        If Me.ComFaixa.Checked = True Then
            Me.btFaixaComissao.Visible = True
        Else
            Me.btFaixaComissao.Visible = False
        End If

        DR.Close()
        CNN.Close()

    End Sub



    Private Sub Empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizaDadosEmpresa()
    End Sub

    Private Sub ComPorProduto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComPorProduto.CheckedChanged
        If Me.DescontoLinha.Checked = False And Me.ComPorProduto.Checked = True Then
            MessageBox.Show("O usuário não pode usar Comissão por Produto e dar desconto no Total do Pedido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ComPorProduto.Checked = False
            Exit Sub
        End If
    End Sub

    Private Sub btFaixaComissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFaixaComissao.Click
        If My.Forms.Empresa.CódigoEmpresa.Text = "" Then Exit Sub
        My.Forms.EmpresaComissaoFaixa.ShowDialog()
    End Sub

    Private Sub ComFaixa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComFaixa.CheckedChanged
        If Me.ComFaixa.Checked = True Then
            Me.btFaixaComissao.Visible = True
        Else
            Me.btFaixaComissao.Visible = False
        End If
    End Sub

    Private Sub UsarGradeProdutos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsarGradeProdutos.CheckedChanged
        If Me.UsarGradeProdutos.Checked = True Then
            Me.UsarServico.Checked = False
        End If
    End Sub

    Private Sub UsarServico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsarServico.CheckedChanged
        If Me.UsarServico.Checked = True Then
            Me.UsarGradeProdutos.Checked = False
        End If
    End Sub

    Private Sub btFind1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind1.Click
        IdContaLanc = "JUROS" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.cJurosReceber.Focus()
    End Sub


    Private Sub btFind2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind2.Click
        IdContaLanc = "MULTA" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.cMultaReceber.Focus()
    End Sub

    Private Sub btFind3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind3.Click
        IdContaLanc = "DESCONTO" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.cDescReceber.Focus()
    End Sub

    Private Sub btFind4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind4.Click
        IdContaLanc = "VALORDOC" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.cValorReceber.Focus()
    End Sub

    Private Sub btFind5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind5.Click
        IdContaLanc = "JUROSPAGAR" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.cJurosPagar.Focus()
    End Sub

    Private Sub btFind6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind6.Click
        IdContaLanc = "MULTAPAGAR" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.cMultaPagar.Focus()
    End Sub

    Private Sub btFind7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind7.Click
        IdContaLanc = "DESCONTOPAGAR" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.cDescPagar.Focus()
    End Sub

    Private Sub btFind8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind8.Click
        IdContaLanc = "VALORDOCPAGAR" 'JUROS/MULTA/DESCONTO/VALORDOC
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.cValorPagar.Focus()
    End Sub

    
    Private Sub btCC1_Click(sender As Object, e As EventArgs) Handles btCC1.Click, btCC2.Click, btCC3.Click
        Select Case CType(sender, Label).Name
            Case "btCC1"
                IdContaLanc = "ContaCCJuros"
                My.Forms.CentroCustoNewLocalizar.ShowDialog()
                Me.ContaCCJuros.Focus()
            Case "btCC2"
                IdContaLanc = "ContaCCMulta"
                My.Forms.CentroCustoNewLocalizar.ShowDialog()
                Me.ContaCCMulta.Focus()
            Case "btCC3"
                IdContaLanc = "ContaCCDescConcedido"
                My.Forms.CentroCustoNewLocalizar.ShowDialog()
                Me.ContaCCDescConcedido.Focus()
        End Select
    End Sub
End Class