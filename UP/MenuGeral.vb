Imports Microsoft.Win32
Imports System.Threading
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports System.IO
Imports System.Net
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared



Public Class MenuGeral
    Private TRD As Thread

    Dim Dt As DataTable
    Dim DtOrdemCompra As DataTable


    Dim NomeBotão As String = ""
    Dim mouseBarraRapida As Double
    Dim PosiçãoIcone As Boolean
    Dim ItensMenuRapido As String

    Dim Img1 As Bitmap
    Dim Img2 As Bitmap
    Dim Img3 As Bitmap
    Dim Img4 As Bitmap
    Dim Img5 As Bitmap
    Dim Img6 As Bitmap
    Dim Img7 As Bitmap
    Dim ImgAtalho As Bitmap

    Private Sub MenuGeral_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim THRD As New Threading.Thread(AddressOf IniciaVerAgenda)
        THRD.Priority = ThreadPriority.Highest
        THRD.IsBackground = True
        THRD.Start()
    End Sub


    Private Sub FMenuGeral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        btCoresPersonalizadas.SelectedColor = Color.Blue
        If TSesquema = False Then
            btCoresPersonalizadas.Enabled = True
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eOffice2007ColorScheme.Silver, Color.CadetBlue)
        Else
            btCoresPersonalizadas.Enabled = False
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eOffice2007ColorScheme.Silver, Color.Black)
        End If

        Select Case mMenuCarregar
            Case ""
                Me.MenuDisplay.Visible = True
            Case "MenuDisplay"
                Me.MenuDisplay.Visible = True
            Case "MenuVendaShoes"
                Me.MenuRibbon.Visible = True
        End Select


        TamanhoTela = Screen.GetWorkingArea(Me)

        'If (UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0) Then
        '    MsgBox("A aplicação que você está iniciando já está em uso.", MsgBoxStyle.Information, "Aplicação em uso")
        '    End
        '    Exit Sub
        'End If

        VerAgendaServiço()

        Dim trd As Thread

        trd = New Thread(AddressOf ThreadTask)
        trd.IsBackground = True
        trd.Start()

        If UsarGrade = False Then
            Me.RelatórioDeProdutosGrade.Visible = False
        End If

        Me.Text = "Menu Geral - " & CodEmpresa & "-" & NomEmpresa & " - Data de Trabalho: " & DataDia & " - Usuário: " & UserAtivo & "- v." & verVersao
        Me.DisplayCaixaAtivo.Text = "Caixa Ativo: " & CaixaAtivo

        Try
            AtualizarSystem()


        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub

    Private Sub ThreadTask()
        UF_Preencher()
        CofinsCST_Preencher()
        IcmsCST_Preencher()
        IpiCST_Preencher()
        PisCST_Preencher()
        OrigemIcms_Preencher()
        IcmsModalidadeBC_Preencher()
        oDtCFOP()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        TRVDados(UserAtivo, "Clientes")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Clientes.ShowDialog()
        End If
    End Sub

    Private Sub ProdutosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "Produtos")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Produtos.ShowDialog()
        End If
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        TRVDados(UserAtivo, "Fornecedor")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Fornecedor.ShowDialog()
        End If
    End Sub

    Private Sub GruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposToolStripMenuItem.Click
        TRVDados(UserAtivo, "Grupos")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Grupos.ShowDialog()
        End If
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasToolStripMenuItem.Click
        TRVDados(UserAtivo, "Marcas")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Marcas.ShowDialog()
        End If
    End Sub

    Private Sub HistóricosDeDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistóricosDeDocumentosToolStripMenuItem.Click
        TRVDados(UserAtivo, "HistoricoPgtoReceb")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.HistoricoPgtoReceb.ShowDialog()
        End If
    End Sub



    Private Sub TransportadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportadoraToolStripMenuItem.Click
        TRVDados(UserAtivo, "Transportadora")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Transportadora.ShowDialog()
        End If
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        TRVDados(UserAtivo, "Empresa")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Empresa.ShowDialog()
        End If
    End Sub

    Private Sub CFOPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFOPToolStripMenuItem.Click
        TRVDados(UserAtivo, "Cfop")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Cfop.ShowDialog()
        End If
    End Sub

    Private Sub ConsultaBaixaDeContasARceberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaBaixaDeContasARceberToolStripMenuItem.Click
        TRVDados(UserAtivo, "Receber")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Receber.ShowDialog()
        End If
    End Sub

    Private Sub RelatórioDeContasAReceberToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatórioDeContasAReceberToolStripMenuItem1.Click
        TRVDados(UserAtivo, "ReceberRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberRelat.ShowDialog()
        End If
    End Sub

    Private Sub ConsultaBaixaDeContasAPagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaBaixaDeContasAPagarToolStripMenuItem.Click
        TRVDados(UserAtivo, "Pagar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Pagar.ShowDialog()
        End If
    End Sub

    Private Sub SenhaEUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenhaEUsuárioToolStripMenuItem.Click


        'Dim HH As DateTime = Now
        'Dim CodSegurança As String = InformaCodigoSeguranca()

        'If VerificaCodigoSegurança(CodSegurança) = False Then
        '    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
        '    Exit Sub
        'End If

        My.Forms.UserSenha.ShowDialog()


    End Sub

    Private Sub ConfiguraçãoDoBancoDeDadosAlternarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçãoDoBancoDeDadosAlternarToolStripMenuItem.Click
        TRVDados(UserAtivo, "Cfg")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CFG.ShowDialog()
        End If
    End Sub


    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        My.Forms.Sobre.ShowDialog()
    End Sub


    Private Sub RelatorioDeContasAPagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatorioDeContasAPagarToolStripMenuItem.Click
        TRVDados(UserAtivo, "PagarRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PagarRelat.ShowDialog()
        End If
    End Sub

    Private Sub CancelamentoDePedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelamentoDePedido.Click
        TRVDados(UserAtivo, "PedidoCancelamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedidoCancelamentoOS.ShowDialog()
        End If
    End Sub

    Private Sub ReimpressãoDoPedidoVendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReimpressãoDoPedidoVenda.Click
        TRVDados(UserAtivo, "PedidoReImpress")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedidoReImpress.ShowDialog()
        End If
    End Sub

    Private Sub PedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPedido.Click

        If UsaSellShoes = True Then
            TRVDados(UserAtivo, "SellShoesAutenticacao")
            If Ina = True Then
                MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                Exit Sub
            Else
                My.Forms.SellShoesAutenticacao.ShowDialog()
            End If
        Else
            TRVDados(UserAtivo, "SellShoesAutenticacao")
            If Ina = True Then
                MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                Exit Sub
            Else
                My.Forms.SellShoesAutenticacao.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ConsultarVendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConsultarVendas.Click
        TRVDados(UserAtivo, "PedidoVendaFaturamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedidoVendaFaturamento.ShowDialog()
        End If
    End Sub


    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        TRVDados(UserAtivo, "Funcionarios")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Funcionarios.ShowDialog()
        End If
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        TRVDados(UserAtivo, "Departamentos")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Departamentos.ShowDialog()
        End If
    End Sub

    Private Sub ProfissãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissãoToolStripMenuItem.Click
        TRVDados(UserAtivo, "Profissao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Profissao.ShowDialog()
        End If
    End Sub

    Private Sub FuncionáriosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem1.Click
        TRVDados(UserAtivo, "FuncionariosRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.FuncionariosRelat.ShowDialog()
        End If
    End Sub

    Private Sub DepartamentosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem1.Click
        TRVDados(UserAtivo, "RelDepartamentos")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            RelatorioCarregar = "RelDepartamentos"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If
    End Sub

    Private Sub ProfissãoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissãoToolStripMenuItem1.Click
        TRVDados(UserAtivo, "RelProfissão")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            RelatorioCarregar = "RelProfissão"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If
    End Sub

    Private Sub ReciboAvulsoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboAvulsoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ReciboAvulso")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReciboAvulso.ShowDialog()
        End If
    End Sub

    Private Sub OrçamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOrçamentos.Click
        TRVDados(UserAtivo, "Orçamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Orçamento.ShowDialog()
        End If
    End Sub

    Private Sub VisualizadorDoCaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizadorDoCaixaToolStripMenuItem.Click
        TRVDados(UserAtivo, "Caixa")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Caixa.ShowDialog()
        End If

    End Sub


    Private Sub CentralContaCorrenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentralContaCorrenteToolStripMenuItem.Click
        TRVDados(UserAtivo, "BancoVisualizador")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BancoVisualizador.ShowDialog()
        End If
    End Sub

    Private Sub MenuGeral_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.MaximizeBox = True
    End Sub

    Private Sub ChequePreClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequePreClientesToolStripMenuItem.Click
        TRVDados(UserAtivo, "ChequePreClientes")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            If Len(CaixaAtivo) <> 4 Then
                MessageBox.Show("O usuario deve selecionar um caixa antes de executar esta operação. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            My.Forms.ChequePreClientes.ShowDialog()
        End If
    End Sub

    Private Sub ClienteEtiquetasNatalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteEtiquetasNatalToolStripMenuItem.Click
        RelatorioCarregar = "RelEtiquetaNatal"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub NotaFiscalDeServiçoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "NFiscalServiço")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.NFiscalServiço.ShowDialog()
        End If
    End Sub

    Private Sub ConfiguraçãoDaNotaFiscalDeServiçoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "NFCFGServiço")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.NFCFGServiço.ShowDialog()
        End If
    End Sub

    Private Sub RelatoriosDeVendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatoriosDeVendas.Click
        TRVDados(UserAtivo, "PedidoRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedidoRelat.ShowDialog()
        End If
    End Sub

    Private Sub ContasAReceberNoPeríodoEValorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContasAReceberNoPeríodoEValorToolStripMenuItem.Click
        TRVDados(UserAtivo, "ReceberRelatPeriodoValor")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberRelatPeriodoValor.ShowDialog()
        End If
    End Sub



    Private Sub RelatóriosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem1.Click
        TRVDados(UserAtivo, "ProdutoRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoRelat.ShowDialog()
        End If
    End Sub

    Private Sub TipoDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "TipoSolicitação")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.TipoSolicitação.ShowDialog()
        End If
    End Sub

    Private Sub ConsultaCepToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCepToolStripMenuItem.Click
        My.Forms.CepLocalizar.ShowDialog()
    End Sub

    Private Sub ComprasOutrasEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasOutrasEntradasToolStripMenuItem.Click
        TRVDados(UserAtivo, "Compra")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Compra.ShowDialog()
        End If
    End Sub

    Private Sub RelatoriosDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatoriosDeComprasToolStripMenuItem.Click
        TRVDados(UserAtivo, "ComprasRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ComprasRelat.ShowDialog()
        End If
    End Sub

    Private Sub RelatóriosToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem6.Click
        TRVDados(UserAtivo, "ChequePreRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ChequePreRelat.ShowDialog()
        End If
    End Sub
    Private Sub RelatóriosToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem7.Click
        TRVDados(UserAtivo, "CaixaRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CaixaRelat.ShowDialog()
        End If
    End Sub

    Private Sub GerarCódigoDeSegurançaDoDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerarCódigoDeSegurançaDoDiaToolStripMenuItem.Click
        TRVDados(UserAtivo, "CodigoSegurança")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CodigoSegurança.ShowDialog()
        End If
    End Sub

    Private Sub AcompanhamentoDePedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAcompanhamentoDePedido.Click
        TRVDados(UserAtivo, "PedidoStatusAndamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedidoStatusAndamento.ShowDialog()
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Try
            Using cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

                Dim Sql As String = "SELECT Receber.Vencimento, Sum(Receber.ValorDocumento) AS SomaDeValorDocumento FROM(Receber) WHERE Receber.Empresa = " & CodEmpresa & " and Receber.Baixado = False And Receber.Inativo = False And Receber.ContaPerdida = False GROUP BY Receber.Vencimento HAVING Receber.Vencimento <= Date() ORDER BY Receber.Vencimento DESC"

                Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, cn)
                Dt = New DataTable("LSTRECEBER")

                Dim DA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                DA.Fill(Dt)
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub CorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorToolStripMenuItem.Click
        TRVDados(UserAtivo, "Cor")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Cor.ShowDialog()
        End If
    End Sub

    Private Sub SubGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubGrupoToolStripMenuItem.Click
        TRVDados(UserAtivo, "SubGrupo")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SubGrupo.ShowDialog()
        End If
    End Sub

    Private Sub TipoGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoGrupoToolStripMenuItem.Click
        TRVDados(UserAtivo, "TipoGrupo")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.TipoGrupo.ShowDialog()
        End If
    End Sub

    Private Sub CancelamentoDOrdemEmbarqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelamentoDOrdemEmbarqueToolStripMenuItem.Click
        TRVDados(UserAtivo, "OrdemEmbarqueCancelamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.OrdemEntregaCancelamento.ShowDialog()
        End If
    End Sub

    Private Sub ExtornoDeRecebimentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtornoDeRecebimentoToolStripMenuItem.Click
        TRVDados(UserAtivo, "RecebidaVoltar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else

            If Len(CaixaAtivo) <> 4 Then
                MessageBox.Show("O usuario deve selecionar um caixa antes de executar esta operação. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            My.Forms.RecebidaVoltar.ShowDialog()
        End If
    End Sub

    Private Sub ExtornoDePagamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtornoDePagamentoToolStripMenuItem.Click
        TRVDados(UserAtivo, "PagasVoltar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            If Len(CaixaAtivo) <> 4 Then
                MessageBox.Show("O usuario deve selecionar um caixa antes de executar esta operação. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            My.Forms.PagasVoltar.ShowDialog()
        End If
    End Sub
    Private Sub TimerFechar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFechar.Tick
        TRD = New Thread(AddressOf FecharNoRelogio)
        TRD.IsBackground = True
        TRD.Start()
    End Sub

    Private Sub FecharNoRelogio()
        Dim HoraFechar As String = "23:00"
        Dim HoraAtual As String = FormatDateTime(DateTime.Now, DateFormat.ShortTime)

        If HoraFechar = HoraAtual Then
            End
        End If
    End Sub


    Private Sub ExportaçãoParaNFEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportaçãoParaNFEToolStripMenuItem.Click
        TRVDados(UserAtivo, "ExportarNFE")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ExportarNFE.ShowDialog()
        End If

        TRVDados(UserAtivo, "ExportarNFE")

    End Sub

#Region "Preenchimento de arrays"

    Private Sub UF_Preencher()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM UF order by NomeUF"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                UFArray.Add(New cboItemData(DR.Item("CodigoUF"), DR.Item("NomeUF")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub

    Private Sub CofinsCST_Preencher()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM CofinsCST"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                CofinsCSTArray.Add(New cboItemData(DR.Item("CSTcofins"), DR.Item("DescCSTcofins")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

    Private Sub IcmsCST_Preencher()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM IcmsCST"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                IcmsArray.Add(New cboItemData(DR.Item("CSTicms"), DR.Item("DescCSTicms")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

    Private Sub IpiCST_Preencher()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM IpiCST"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                IpiArray.Add(New cboItemData(DR.Item("CSTipi"), DR.Item("DescCSTipi")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

    Private Sub PisCST_Preencher()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM PisCST"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                PisArray.Add(New cboItemData(DR.Item("CSTpis"), DR.Item("DescCSTpis")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

    Private Sub OrigemIcms_Preencher()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM IcmsOrigem"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                OrigemIcmsArray.Add(New cboItemData(DR.Item("Origem"), DR.Item("OrigemDesc")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

    Private Sub IcmsModalidadeBC_Preencher()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM IcmsModalidadeBC"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                IcmsModalidadeBCArray.Add(New cboItemData(DR.Item("modBC"), DR.Item("modBCDesc")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

#End Region

#Region "Preenchimento de dataset"
    Private Sub oDtCFOP()
        'Criar conexao
        Dim cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        'Abrir conexao.
        cnn.Open()

        Dim sSql As String = String.Empty

        sSql = "SELECT * From CFOP"


        'Após estabelecer uma conexão, execute comandos e retorna o resultados de uma fonte de dados como uma SQL.
        Dim Cmd As New OleDb.OleDbCommand(sSql, cnn)

        'Usa o DataAdapter para para se conectar ao objeto command
        Dim Adt As New OleDb.OleDbDataAdapter(Cmd)



        'preenche dataset com a tabela 
        Adt.Fill(Dst, "TbCFOP")



        cnn.Close()
    End Sub
#End Region



    Private Sub ChequePréDevolvidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequePréDevolvidosToolStripMenuItem.Click
        TRVDados(UserAtivo, "ChequePreDevolver")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ChequePreDevolver.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripMenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "CriaAnoContabil")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CriaAnoContabil.ShowDialog()
        End If
    End Sub

    Private Sub LocalDePagamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "LocalPagamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.LocalPagamento.ShowDialog()
        End If
    End Sub

    Private Sub RelatóriosDeCadGeraisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosDeCadGeraisToolStripMenuItem.Click
        TRVDados(UserAtivo, "CadGeraisRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CadGeraisRelat.ShowDialog()
        End If
    End Sub


    Private Sub ToolStripMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem48.Click
        TRVDados(UserAtivo, "DocumentoEntrada")
        If Ina = True Then
            MsgBox("O usuário não está autorizado a usar esta opção do sistema.", 48, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.DocumentoEntrada.ShowDialog()
        End If


    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem.Click
        TRVDados(UserAtivo, "RelClientes")
        If Ina = True Then
            MsgBox("O usuário não está autorizado a usar esta opção do sistema.", 48, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ClientesRalatorios.ShowDialog()
        End If
    End Sub


    Private Sub btMenuGeral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMenuGeral.Click
        Dim X As New Point(Me.btMenuGeral.Width, 0)
        Me.MnGeral.Show(Me.btMenuGeral, X)

        If UsarServico = True Then
            Me.btServiços.Visible = True
        Else
            Me.btServiços.Visible = False
        End If

        If UsarGrade = True Then
            Me.btProdução.Visible = False
        Else
            Me.btProdução.Visible = True
        End If

    End Sub

    Private Sub btPagarReceber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPagarReceber.Click
        Dim X As New Point(Me.btPagarReceber.Width, 0)
        Me.MnCtpCtr.Show(Me.btPagarReceber, X)
    End Sub

    Private Sub btMovimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMovimento.Click
        If UsarGrade = True Then
            Dim X As New Point(Me.btMovimento.Width, 0)
            Me.MnShoes.Show(Me.btMovimento, X)
        Else
            Dim X As New Point(Me.btMovimento.Width, 0)
            Me.MnMovimento.Show(Me.btMovimento, X)

            If UsarServico = True Then
                Me.btPedido.Visible = False
                Me.btOrçamentos.Visible = False
                Me.btOrdemServiço.Visible = True
                Me.btOrcamentoServico.Visible = True
                Me.btConsultarVendas.Visible = False
                Me.btReimpressãoDoPedidoVenda.Visible = False
                Me.btAcompanhamentoDePedido.Visible = False
                Me.btCancelamentoDePedido.Visible = False
                Me.mnuComissãoDeVendedores.Visible = True
                Me.RelatoriosDeVendas.Visible = False
            Else
                Me.btPedido.Visible = True
                Me.btOrçamentos.Visible = True
                Me.btOrdemServiço.Visible = False
                Me.btOrcamentoServico.Visible = False
                Me.mnuReltPedOS.Visible = False

            End If
        End If
    End Sub

    Private Sub btCaixaBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCaixaBanco.Click
        Dim X As New Point(Me.btCaixaBanco.Width, 0)
        Me.MnCaixaBanco.Show(Me.btCaixaBanco, X)
    End Sub

    Private Sub btRH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRH.Click
        Dim X As New Point(Me.btRH.Width, 0)
        Me.MnRH.Show(Me.btRH, X)
    End Sub

    Private Sub btConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConf.Click
        Dim X As New Point(Me.btConf.Width, 0)
        Me.MnConfiguração.Show(Me.btConf, X)
    End Sub



    Private Sub ContaCorrenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaCorrenteToolStripMenuItem.Click
        TRVDados(UserAtivo, "BancosContaCorrente")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BancosContaCorrente.ShowDialog()
        End If
    End Sub

    Private Sub CadastroDeBancoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeBancoToolStripMenuItem.Click
        TRVDados(UserAtivo, "BancosCad")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BancosCad.ShowDialog()
        End If
    End Sub

    Private Sub CriarEFecharDiaDeTrabalhoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriarEFecharDiaDeTrabalhoToolStripMenuItem.Click
        TRVDados(UserAtivo, "DiaAbrirFechar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.DiaAbrirFechar.ShowDialog()
        End If
    End Sub



#Region "Rotinas para os Themas"
    Private m_ColorSelected As Boolean = False
    Dim m_BaseColorScheme As DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme

    Private Sub btCoresPersonalizadas_ColorPreview(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ColorPreviewEventArgs)
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eOffice2007ColorScheme.Silver, e.Color)
    End Sub

    Private Sub btCoresPersonalizadas_ExpandChange(ByVal sender As Object, ByVal e As System.EventArgs)
        If btCoresPersonalizadas.Expanded Then
            ' Remember the starting color scheme to apply if no color is selected during live-preview
            m_ColorSelected = False
            m_BaseColorScheme = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable.InitialColorScheme
        Else
            If Not m_ColorSelected Then
                ' RibbonVisualizador.Office2007ColorTable = m_BaseColorScheme
            End If
        End If
    End Sub

    Private Sub btCoresPersonalizadas_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        m_ColorSelected = True ' Indicate that color was selected for buttonStyleCustom_ExpandChange method
        btCoresPersonalizadas.CommandParameter = btCoresPersonalizadas.SelectedColor
    End Sub

#End Region

    Private Sub LocalizaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizaçãoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutoLocal")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoLocal.ShowDialog()
        End If
    End Sub

    Private Sub CadastroDeContasResultadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeContasResultadoToolStripMenuItem.Click
        TRVDados(UserAtivo, "BalanceteCadastro")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BalanceteCadastro.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        TRVDados(UserAtivo, "CaixaAtivarDesativar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CaixaAtivarDesativar.ShowDialog()
        End If
    End Sub

    Private Sub FormaDePagamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormaDePagamentoToolStripMenuItem.Click
        TRVDados(UserAtivo, "FormaPgto")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.FormaPgto.ShowDialog()
        End If
    End Sub


    Private Sub AtualizadorDeEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizadorDeEstoqueToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutoEstoqueAtualizar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoEstoqueAtualizar.ShowDialog()
        End If
    End Sub


    Private Sub CadastroDeCaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeCaixaToolStripMenuItem.Click
        TRVDados(UserAtivo, "CaixaCadastro")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CaixaCadastro.ShowDialog()
        End If
    End Sub

    Private Sub ConsultaDeEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeEstoqueToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutoEstoqueConsulta")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoEstoqueConsulta.ShowDialog()
        End If
    End Sub

    Private Sub MenuGeral_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Dim isControlPressed As Boolean = (Control.ModifierKeys And Keys.Control) <> 0
        If isControlPressed = True Then
            If e.KeyCode = Keys.E Then
                My.Forms.ProdutoEstoqueConsulta.ShowDialog()
            End If

            If e.KeyCode = Keys.P Then

                'Incluido por Marcos Aurelio 
                If UsaSellShoes = True Then
                    TRVDados(UserAtivo, "SellShoesAutenticacao")
                    If Ina = True Then
                        MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                        Exit Sub
                    Else
                        My.Forms.SellShoesAutenticacao.ShowDialog()
                    End If
                Else
                    TRVDados(UserAtivo, "PedidoOs")
                    If Ina = True Then
                        MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                        Exit Sub
                    Else
                        EntrarAchandoPedido = False
                        My.Forms.PedidoOS.ShowDialog()
                    End If
                End If

                'Retirado por Marcos Aurelio                  'My.Forms.PedidoOS.ShowDialog()

            End If
            If e.KeyCode = Keys.F10 Then
                If Me.MenuDisplay.Visible = True Then
                    Me.MenuDisplay.Visible = False
                Else
                    Me.MenuDisplay.Visible = True
                End If
            End If
        End If

    End Sub

    Private Sub RelatóriosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem2.Click
        TRVDados(UserAtivo, "FornecedorRelatorio")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.FornecedorRelatorio.ShowDialog()
        End If
    End Sub

    Private Sub SaldoDeEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoDeEstoqueToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutoSaldoEstoque")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoSaldoEstoque.ShowDialog()
        End If

    End Sub

    Private Sub ImpressãoDeNPDuplicataDoPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpressãoDeNPDuplicataDoPedidoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ImprimirDuplicataNP")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ImprimirDuplicataNP.ShowDialog()
        End If
    End Sub

    Private Sub CaixasEmAbertosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaixasEmAbertosToolStripMenuItem.Click
        TRVDados(UserAtivo, "CaixasAbertos")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CaixasAbertos.ShowDialog()
        End If
    End Sub

    Private Sub ServiçosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiçosToolStripMenuItem1.Click
        TRVDados(UserAtivo, "Servicos")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Servicos.ShowDialog()
        End If
    End Sub

    Private Sub OrdemDeProduçToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdemDeProduçToolStripMenuItem.Click
        TRVDados(UserAtivo, "Producao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Producao.ShowDialog()
        End If
    End Sub

    Private Sub EtiquetasDeProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetasDeProdutoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutoEtiquetas")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoEtiquetas.ShowDialog()
        End If
    End Sub

    Private Sub RegiãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegiãoToolStripMenuItem.Click
        TRVDados(UserAtivo, "Regiao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Regiao.ShowDialog()
        End If
    End Sub

    Private Sub ConsultarProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarProdutosToolStripMenuItem.Click
        ProcuraProduto.ShowDialog()
    End Sub

    Private Sub ConfirmarOrdemDeProduçãoNoEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarOrdemDeProduçãoNoEstoqueToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProducaoEstoqueConfirmar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProducaoEstoqueConfirmar.ShowDialog()
        End If
    End Sub

    Private Sub AjusteEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjusteEstoqueToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutoEstoqueAjuste")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoEstoqueAjuste.ShowDialog()
        End If
    End Sub

    Private Sub MnMovimento_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MnMovimento.Opening
        If UsaSellShoes = True Then
            Me.btConsultarVendas.Visible = False
            Me.btReimpressãoDoPedidoVenda.Visible = False
            Me.btAcompanhamentoDePedido.Visible = False
        End If
        If UsaMateriaPrima Then
            Me.PedidoConfecçãoToolStripMenuItem.Visible = True
        Else
            Me.PedidoConfecçãoToolStripMenuItem.Visible = False

        End If
    End Sub

    Private Sub AReceberAvulsoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AReceberAvulsoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ReceberAvulso")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberAvulso.ShowDialog()
        End If
    End Sub

    Private Sub CadastroDeObjetosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "ObejtosCad")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ObjetosCad.ShowDialog()
        End If
    End Sub

    Private Sub ExportaçãoPAFHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportaçãoPAFHToolStripMenuItem.Click
        TRVDados(UserAtivo, "ExportPAF")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ExportPAF.ShowDialog()
        End If
    End Sub

    Private Sub RelatóriosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem3.Click
        TRVDados(UserAtivo, "BalanceteOrcamentarioRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BalanceteOrcamentarioRelat.ShowDialog()
        End If
    End Sub

    Private Sub ComissãoDeVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuComissãoDeVendedores.Click
        TRVDados(UserAtivo, "ComissaoRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ComissaoRelat.ShowDialog()
        End If
    End Sub

    Private Sub btConsultaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "SellShoesProdutoProcura")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesProdutoProcura.ShowDialog()
        End If
    End Sub


    Private Sub CartãoDeFuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartãoDeFuncionárioToolStripMenuItem.Click
        TRVDados(UserAtivo, "FuncionarioCartao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.FuncionarioCartao.ShowDialog()
        End If
    End Sub


    Private Sub AtualizarTabelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarTabelasToolStripMenuItem.Click
        My.Forms.AtTabelas.ShowDialog()
    End Sub

    Private Sub FuncionáriosEServiçosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosEServiçosToolStripMenuItem.Click
        My.Forms.ServicoFuncionario.ShowDialog()
    End Sub

    Private Sub OrdemServiçoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOrdemServiço.Click
        My.Forms.PedidoOS.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOrcamentoServico.Click
        OSorçamento.ShowDialog()
    End Sub

    Private Sub EmitirDuplicataAvulsoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmitirDuplicataAvulsoToolStripMenuItem.Click
        TRVDados(UserAtivo, "DuplicataAvulso")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            DuplicataAvulso.ShowDialog()
        End If
    End Sub

    Private Sub VendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "SellShoesAutenticacao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesAutenticacao.ShowDialog()
        End If
    End Sub


    Private Sub ConsultaClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaClienteToolStripMenuItem.Click
        TRVDados(UserAtivo, "SellShoesClientesProcura")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesClientesProcura.ShowDialog()
        End If
    End Sub


    Private Sub ConsultaProodutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaProodutoToolStripMenuItem.Click
        TRVDados(UserAtivo, "SellShoesProdutoProcura")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesProdutoProcura.ShowDialog()
        End If
    End Sub

    Private Sub FinalizarVendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalizarVendaToolStripMenuItem.Click
        TRVDados(UserAtivo, "SellShoesPendentes")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesPendentes.ShowDialog()
        End If
    End Sub

    Private Sub DevoluçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluçãoToolStripMenuItem.Click
        TRVDados(UserAtivo, "SellShoesDevolucao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesDevolucao.ShowDialog()
        End If
    End Sub

    Private Sub EntradaNotaFiscalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaNotaFiscalToolStripMenuItem.Click
        TRVDados(UserAtivo, "SellShoesCompra")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            SellShoesCompra.ShowDialog()
        End If
    End Sub

    Private Sub BaixaRecebimentoEmLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaixaRecebimentoEmLoteToolStripMenuItem.Click
        TRVDados(UserAtivo, "ReceberBaixaLote")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberBaixaLote.ShowDialog()
        End If
    End Sub

    Private Sub PedidoCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoCompraToolStripMenuItem.Click
        TRVDados(UserAtivo, "SellShoesPedidoCompra")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesPedidoCompra.ShowDialog()
        End If

        'My.Forms.SellShoesPedidoCompra.ShowDialog()
    End Sub

    Private Sub ServiçosExecutadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "RelServico")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.RelServico.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        TRVDados(UserAtivo, "SellShoesClientesProcura")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesClientesProcura.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        TRVDados(UserAtivo, "SellShoesProdutoProcura")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesProdutoProcura.ShowDialog()
        End If
    End Sub


    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        TRVDados(UserAtivo, "SellShoesAutenticacao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesAutenticacao.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        TRVDados(UserAtivo, "SellShoesDevolucao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesDevolucao.ShowDialog()
        End If
    End Sub


    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click
        TRVDados(UserAtivo, "SellShoesPendentes")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesPendentes.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        TRVDados(UserAtivo, "Receber")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Receber.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        TRVDados(UserAtivo, "CaixaAtivarDesativar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CaixaAtivarDesativar.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        TRVDados(UserAtivo, "Caixa")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Caixa.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        TRVDados(UserAtivo, "ReceberBaixaLote")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberBaixaLote.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        TRVDados(UserAtivo, "SellShoesOrcamentoProcura")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesOrcamentoProcura.ShowDialog()
        End If
    End Sub

    Private Sub GruposDeServiçosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposDeServiçosToolStripMenuItem.Click
        TRVDados(UserAtivo, "GrupoServico")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.GrupoServico.ShowDialog()
        End If
    End Sub

    Private Sub BuscarObjetoPorPlacaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarObjetoPorPlacaToolStripMenuItem.Click
        TRVDados(UserAtivo, "ObjetoLocalizarPlaca")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ObjetoLocalizarPlaca.ShowDialog()
        End If
    End Sub



    Private Sub mnuReltPedOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReltPedOS.Click
        My.Forms.OsRelat.ShowDialog()
    End Sub

    Private Sub TranferênciaDeEstoqueDepóditoVendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranferênciaDeEstoqueDepóditoVendaToolStripMenuItem.Click
        TRVDados(UserAtivo, "EstoqueTransferencia")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.EstoqueTransferencia.ShowDialog()
        End If
    End Sub

    Private Sub CadastroDeContasDeResultadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeContasDeResultadoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ResultadosContas")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CentroCustoNew.ShowDialog()
        End If
    End Sub

    Private Sub TipoDePagamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDePagamentoToolStripMenuItem.Click
        TRVDados(UserAtivo, "TipoPgto")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.TipoPgto.ShowDialog()
        End If
    End Sub

    Private Sub AnexarCondPgtoAoTipoDePgtoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnexarCondPgtoAoTipoDePgtoToolStripMenuItem.Click
        TRVDados(UserAtivo, "TipoFormaPgto")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.TipoFormaPgto.ShowDialog()
        End If
    End Sub

    Private Sub ContratosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContratosToolStripMenuItem.Click
        TRVDados(UserAtivo, "Contrato")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Contrato.ShowDialog()
        End If
    End Sub

    Private Sub VerLimiteDeCreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerLimiteDeCreditoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ClientesVerSaldoCredito")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ClientesVerSaldoCredito.ShowDialog()
        End If
    End Sub

    Private Sub ProdutosInaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosInaToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutosInativos")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutosInativos.ShowDialog()
        End If
    End Sub

    Private Sub ConsultarPreçoServiçoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarPreçoServiçoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ServicoConsultaPreco")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ServicoConsultaPreco.ShowDialog()
        End If
    End Sub

    Private Sub AlterarPreçoServiçoListagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarPreçoServiçoListagemToolStripMenuItem.Click
        TRVDados(UserAtivo, "ServicoListagemAlterarPreco")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ServicoListagemAlterarPreco.ShowDialog()
        End If
    End Sub


    Private Sub AtualizarOSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarOSistemaToolStripMenuItem.Click
        Shell(Application.StartupPath & "\upUpdate.exe", AppWinStyle.NormalFocus, False)
        End
    End Sub

    Private Sub DocumentoDeEntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentoDeEntradaToolStripMenuItem.Click
        TRVDados(UserAtivo, "DocumentoEntrada")
        If Ina = True Then
            MsgBox("O usuário não está autorizado a usar esta opção do sistema.", 48, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.DocumentoEntrada.ShowDialog()
        End If
    End Sub


    Private Sub Fundo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PermissõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissõesToolStripMenuItem.Click
        TRVDados(UserAtivo, "Permissoes")
        If Ina = True Then
            MsgBox("O usuário não está autorizado a usar esta opção do sistema.", 48, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Permissoes.ShowDialog()
        End If
    End Sub

    Private Sub RelatórioDeProdutosGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatórioDeProdutosGrade.Click
        TRVDados(UserAtivo, "SellShoesRelProdutoGrade")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesRelProdutoGrade.ShowDialog()
        End If
    End Sub

    Private Sub PedidoCompraFinanceiroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoCompraFinanceiroToolStripMenuItem.Click
        TRVDados(UserAtivo, "PedCompraFinanceiro")
        If Ina = True Then
            MsgBox("O usuário não está autorizado a usar esta opção do sistema.", 48, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedCompraFinanceiro.ShowDialog()
        End If
    End Sub

    Private Sub CoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ConsultaServicoPlaca")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ConsultaServicoPlaca.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        TRVDados(UserAtivo, "SellShoesReimpressao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesReimpressao.ShowDialog()
        End If
    End Sub

    Private Sub ExportaçãoPAFExclaimToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportaçãoPAFExclaimToolStripMenuItem.Click
        TRVDados(UserAtivo, "ExportPAF2")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ExportPAF2.ShowDialog()
        End If
    End Sub

    Private Sub ExportaçãoProSoftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportaçãoProSoftToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProSoftExport")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProSoftExport.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click


        TRVDados(UserAtivo, "SellShoesAutenticacao")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.SellShoesAutenticacao.OpcConsVenda.Checked = True
            My.Forms.SellShoesAutenticacao.ShowDialog()

        End If


        'TRVDados(UserAtivo, "SellShoesResumoVenda")
        'If Ina = True Then
        '    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
        '    Exit Sub
        'Else
        '    My.Forms.SellShoesResumoVenda.ShowDialog()
        'End If
    End Sub


    Private Sub ReimprimirReciboPagarReceberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReimprimirReciboPagarReceberToolStripMenuItem.Click

        TRVDados(UserAtivo, "ReimpressaoReciboPagarReceber")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReimpressaoReciboPagarReceber.ShowDialog()

        End If



    End Sub

    Private Sub LocaçãoDeCilindrosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocaçãoDeCilindrosToolStripMenuItem.Click
        TRVDados(UserAtivo, "LocacaoCilindro")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.LocacaoCilindro.ShowDialog()

        End If

    End Sub

    Private Sub RelatórioCilindrosLocadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatórioCilindrosLocadosToolStripMenuItem.Click
        My.Forms.RelLocaoCilindro.ShowDialog()
    End Sub

    Private Sub IventárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IventárioToolStripMenuItem.Click
        TRVDados(UserAtivo, "Iventario")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Iventario.ShowDialog()

        End If
    End Sub

    Private Sub GerarEtiquetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerarEtiquetasToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutoGerarEtiqueta")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoGerarEtiqueta.ShowDialog()

        End If
    End Sub

    Private Sub CentralDeCartãoDeCréditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentralDeCartãoDeCréditoToolStripMenuItem.Click
        TRVDados(UserAtivo, "CartaoCreditoMenu")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CartaoCreditoMenu.ShowDialog()
        End If
    End Sub

    Private Sub CancelamentoVendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelamentoVendaToolStripMenuItem.Click
        TRVDados(UserAtivo, "PedidoCancelamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedidoCancelamentoOS.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem35.Click
        ''lelo
        TRVDados(UserAtivo, "PedidoRelat")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedidoRelat.ShowDialog()
        End If
    End Sub

    Private Sub CadastroDeObjetoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeObjetoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ObejtosCad")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ObjetosCad.ShowDialog()
        End If
    End Sub


    Function GetRandomPassword(ByVal length As Integer) As String
        Static rand As New Random
        Dim password As New System.Text.StringBuilder(length)

        For i As Integer = 1 To length
            Dim charIndex As Integer
            ' allow only digits and letters 
            Do
                charIndex = rand.Next(48, 123)
            Loop Until (charIndex >= 48 AndAlso charIndex <= 57) OrElse (charIndex _
            >= 65 AndAlso charIndex <= 90) OrElse (charIndex >= 97 AndAlso _
            charIndex <= 122)
            ' add the random char to the password being built 
            password.Append(Convert.ToChar(charIndex))
        Next
        Return password.ToString()
    End Function


    Private Sub GerenciadorDePermissõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerenciadorDePermissõesToolStripMenuItem.Click
        TRVDados(UserAtivo, "PermissaoGetPost")
        If Ina = True Then
            MsgBox("O usuário não está autorizado a usar esta opção do sistema.", 48, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PermissaoGetPost.ShowDialog()
        End If
    End Sub

    Private Sub AjusteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjusteToolStripMenuItem.Click
        TRVDados(UserAtivo, "ProdutoGradeEstoqueAjuste")
        If Ina = True Then
            MsgBox("O usuário não está autorizado a usar esta opção do sistema.", 48, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ProdutoGradeEstoqueAjuste.ShowDialog()
        End If
    End Sub

    Private Sub CadastroDeProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeProdutosToolStripMenuItem.Click
        TRVDados(UserAtivo, "Produtos")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Produtos.ShowDialog()
        End If
    End Sub

    Private Sub ItoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItoriaToolStripMenuItem.Click
        TRVDados(UserAtivo, "Auditor")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.Auditor.ShowDialog()
        End If
    End Sub

    Private Sub HitoricoDeClientePedidoOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HitoricoDeClientePedidoOSToolStripMenuItem.Click
        TRVDados(UserAtivo, "HistoricoOsPedido")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.HistoricoOsPedido.ShowDialog()
        End If
    End Sub

    Private Sub AgendaDeServiçosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TRVDados(UserAtivo, "AgendaServico")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.AgendaServico.ShowDialog()
        End If
    End Sub

    Private Sub AgendaServiçosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendaServiçosToolStripMenuItem.Click
        TRVDados(UserAtivo, "AgendaServico")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.AgendaServico.ShowDialog()
        End If
    End Sub



    Private Sub VerAgendaServiço()

        Try
            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & "upAgendaDados.Mdb"))
            Dim Sql As String = String.Empty

            Sql = "Select AgendaServico.Id, AgendaServico.ClienteDesc, AgendaServico.DataAgenda  from AgendaServico Where AgendaServico.Status <> 'Finalizado' and AgendaServico.Status <> 'Cancelado' And AgendaServico.Usuario = '" & UserAtivo & "'"

            Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
            Dim ds As New DataSet
            da.Fill(ds, "Table")

            Me.AgendaLista.DataSource = ds.Tables("Table").DefaultView

            da.Dispose()
            Cnn.Close()


            Dim I As Integer
            Dim S As Double
            For I = 0 To Me.AgendaLista.Columns.Count - 2
                S += AgendaLista.Columns(I).Width
            Next
            Dim TCol As Double = Me.AgendaLista.Width - S - 20
            Me.AgendaLista.Columns(1).Width += TCol

            If Me.AgendaLista.RowCount > 0 Then
                Me.AgendaPainel.Visible = True
            Else
                Me.AgendaPainel.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btAgendaFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAgendaFechar.Click


        If Me.AgendaLista.Visible = True Then
            Me.AgendaLista.Visible = False
        Else
            Me.AgendaLista.Visible = True
        End If

        'If Me.AgendaPainel.Height > 30 Then

        '    While Me.AgendaPainel.Height > 30

        '        System.Windows.Forms.Application.DoEvents()

        '        Me.AgendaPainel.Height -= 1
        '        If Me.AgendaPainel.Height = 30 Then
        '            Me.btAgendaFechar.Image = Me.btAgendaFechar.InitialImage
        '            Exit While
        '        End If

        '    End While

        'Else

        '    Dim t As Integer = Me.Height - 188 - 40

        '    While Me.AgendaPainel.Height < t

        '        System.Windows.Forms.Application.DoEvents()

        '        Me.AgendaPainel.Height += 1
        '        If Me.AgendaPainel.Height = t Then
        '            Me.btAgendaFechar.Image = Me.btAgendaFechar.ErrorImage
        '            Exit While
        '        End If

        '    End While


        'End If
    End Sub


    Delegate Sub myDelegate()

    Private Sub IniciaVerAgenda()
        If Me.InvokeRequired Then
            Me.Invoke(New myDelegate(AddressOf VerAgendaServiço))
        End If
    End Sub

    Private Sub AgendaLista_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AgendaLista.CellContentDoubleClick
        My.Forms.AgendaServicoAdd.Procurar = Me.AgendaLista.CurrentRow.Cells("cId").Value
        My.Forms.AgendaServicoAdd.ShowDialog()
    End Sub

    Private Sub CFOPEntradaESaídaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFOPEntradaESaídaToolStripMenuItem.Click
        TRVDados(UserAtivo, "CFOPse")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CFOPse.ShowDialog()
        End If
    End Sub


    Private Sub ReclacificarContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReclacificarContasToolStripMenuItem.Click
        TRVDados(UserAtivo, "BalanceteEdit")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BalanceteEdit.ShowDialog()
        End If
    End Sub

    Private Sub AgruparRecebimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgruparRecebimentoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ReceberAgrupar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberAgrupar.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        TRVDados(UserAtivo, "AtualizarTributacaoProduto")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.AtualizarTributacaoProduto.ShowDialog()
        End If
    End Sub

    Private Sub LançarCreditoParaOClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LançarCreditoParaOClienteToolStripMenuItem.Click
        TRVDados(UserAtivo, "ClientesCred")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ClientesCred.ShowDialog()
        End If
    End Sub

    Private Sub BaixarCréditoDoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaixarCréditoDoClienteToolStripMenuItem.Click
        TRVDados(UserAtivo, "ClientesCredBaixar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ClientesCredBaixar.ShowDialog()
        End If
    End Sub

    Private Sub ExportaçãoPAFG4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportaçãoPAFG4ToolStripMenuItem.Click
        My.Forms.ExportaPAF3.ShowDialog()
    End Sub

    Private Sub AgruparPagamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgruparPagamentoToolStripMenuItem.Click
        TRVDados(UserAtivo, "PagarAgrupar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PagarAgrupar.ShowDialog()
        End If
    End Sub

    Private Sub btnNotaFiscalEletronica_Click(sender As Object, e As EventArgs) Handles btnNotaFiscalEletronica.Click
        Dim X As New Point(Me.btnNotaFiscalEletronica.Width, 0)
        Me.MnNfe.Show(Me.btnNotaFiscalEletronica, X)
    End Sub

    Private Sub PedidoOrçamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoOrçamentoToolStripMenuItem.Click
        My.Forms.frmPedidoMP.ShowDialog()
    End Sub

    Private Sub ProduçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduçãoToolStripMenuItem.Click
        My.Forms.frmProducao.ShowDialog()
    End Sub
End Class