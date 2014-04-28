Imports System.Drawing.Printing
Imports System.Drawing.Printing.PrinterSettings
Imports Microsoft.Win32
Imports System.IO
Imports System.Threading
Public Class Produtos

    Private WithEvents PDoc As New PrintDocument()

    Dim CaminhoImagem As String = ""

    Dim A��o As New TrfGerais()

    Private OperationImage As Byte
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const VAZ As Byte = 5

    Dim Tp As String

    Private Enum TpRetornoCBO
        N�o = 0
        Sim = 1
    End Enum

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        If Adi = False Then
            MsgBox("O Usu�rio n�o tem permiss�o para Adicionar o registro, verifique com o Administrador.", 64, "Valida��o de Dados")
            A��o.Desbloquear_Controle(Me, False)
            Exit Sub
        End If

        A��o.LimpaTextBox(Me)
        Me.UltCompraTab.Visible = False
        Me.cstICMS.SelectedIndex = -1
        Me.icmsCSTEntr.SelectedIndex = -1
        Me.modBCicms.SelectedIndex = -1
        Me.origemICMS.SelectedIndex = -1
        Me.pICMS.Clear()

        Me.cstIPI.SelectedIndex = -1
        Me.cstIPIentr.SelectedIndex = -1
        Me.tCalcIpi.Clear()
        Me.cEnq.Clear()
        Me.pIPI.Clear()

        Me.cstPIS.SelectedIndex = -1
        Me.cstPISentr.SelectedIndex = -1
        Me.pPIS.Clear()

        Me.cstCOFINS.SelectedIndex = -1
        Me.cstCOFINSentr.SelectedIndex = -1
        Me.pCOFINS.Clear()

        Me.Tipo.SelectedValue = -1
        Me.ControlaEstoque.Text = ""
        Me.UnidadeMedida.Text = ""

        Me.CboIsentoIcmsEstado.SelectedIndex = -1
        Me.CboSubICMSEstado.SelectedIndex = -1
        Me.cboNaoTributadoIcmsEstado.SelectedIndex = -1
        Me.DescAtacado.Clear()
        Me.DescVarejo.Clear()
        Me.DescontoMaximo.Clear()

        Me.TabOpcoes.SelectedTab = Me.TabOutras

        DesbloquearTextBox(Me, True)
        Me.CodigoProduto.Text = "0000"


        If UsarGrade = True Then
            Me.Multiplos.Text = 1
            Me.Multiplos.Enabled = False
        Else
            Me.Multiplos.Text = 0
            Me.Multiplos.Enabled = True
        End If

        Me.ControlaEstoque.Focus()
        Operation = INS

    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        If Con = False Then
            MsgBox("O Usu�rio n�o tem permiss�o para Consultar registro, verifique com o Administrador.", 64, "Valida��o de Dados")
            A��o.Desbloquear_Controle(Me, False)
            Exit Sub
        End If


        My.Forms.ProcuraProduto.ShowDialog()
        EncheListaComposicao()
        'A��o.Desbloquear_Controle(Me, False)
        'ChamaTelaProcura("Codigo", "Descric�o", "", "Produtos", "CodigoProduto", "Descri��o", "", True)
        'Me.CodigoProduto.Text = RetornoProcura

        'If Me.CodigoProduto.Text <> "" Then
        '    LocalizaDados()
        '    Me.CodigoProduto.Enabled = False
        '    Me.Descri��o.Focus()
        'End If

    End Sub

    Public Sub LocalizaDados()

        If Con = False Then
            MsgBox("O Usu�rio n�o tem permiss�o para Consultar registro, verifique com o Administrador.", 64, "Valida��o de Dados")
            A��o.Desbloquear_Controle(Me, False)
            Exit Sub
        End If

        If Me.CodigoProduto.Text = "" Then
            Exit Sub
        End If

        Dim tab As DevComponents.DotNetBar.TabItem = Me.TabOutras
        Me.TabOpcoes.SelectedTab = tab

        Me.cstICMS.SelectedIndex = -1
        Me.origemICMS.SelectedIndex = -1
        Me.modBCicms.SelectedIndex = -1
        Me.cstIPI.SelectedIndex = -1
        Me.cstPIS.SelectedIndex = -1
        Me.cstCOFINS.SelectedIndex = -1
        Me.Tipo.SelectedIndex = -1

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "SELECT Produtos.*,Produtos.CodigoProduto, Marcas.Marca, Grupos.Descri��o, ProdutoLocal.SetorLocalDesc," _
                          & " Produtos.Cor, Cor.CorDesc, Produtos.TipoGrupo, TipoGrupo.TipoGrupoDesc, Produtos.SubGrupo, SubGrupo.SubGrupoDesc," _
                          & " Produtos.Referencia, CofinsCST.DescCSTcofins, IcmsCST.DescCSTicms, IcmsModalidadeBC.modBCDesc, IcmsOrigem.OrigemDesc, IpiCST.DescCSTipi, PisCST.DescCSTpis" _
                          & " FROM (((((((((((Produtos LEFT JOIN Grupos ON Produtos.C�digoGrupo = Grupos.C�digoGrupo)" _
                          & " LEFT JOIN Marcas ON Produtos.Marca = Marcas.Codigo)" _
                          & " LEFT JOIN ProdutoLocal ON Produtos.Localiza��o = ProdutoLocal.SetorLocal)" _
                          & " LEFT JOIN Cor ON Produtos.Cor = Cor.Codigo)" _
                          & " LEFT JOIN TipoGrupo ON Produtos.TipoGrupo = TipoGrupo.Codigo)" _
                          & " LEFT JOIN SubGrupo ON Produtos.SubGrupo = SubGrupo.Codigo)" _
                          & " LEFT JOIN CofinsCST ON Produtos.cstCofins = CofinsCST.CSTcofins)" _
                          & " LEFT JOIN IpiCST ON Produtos.CstIPI = IpiCST.CSTipi)" _
                          & " LEFT JOIN IcmsCST ON Produtos.Cst = IcmsCST.CSTicms)" _
                          & " LEFT JOIN IcmsOrigem ON Produtos.OrigemIcms = IcmsOrigem.Origem)" _
                          & " LEFT JOIN IcmsModalidadeBC ON Produtos.ModBcIcms = IcmsModalidadeBC.modBC)" _
                          & " LEFT JOIN PisCST ON Produtos.cstPis = PisCST.CSTpis" _
                          & " WHERE Produtos.CodigoProduto = " & Me.CodigoProduto.Text & " and Produtos.Inativo = False"


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.CodigoProduto.Text = DR.Item("Produtos.CodigoProduto") & ""
            Me.Descri��o.Text = DR.Item("Produtos.Descri��o") & ""
            Me.Tipo.SelectedValue = DR.Item("Tipo")
            Me.ControlaEstoque.Text = DR.Item("ControlaEstoque") & ""
            Me.CodigoBarra.Text = DR.Item("CodigoBarra") & ""
            Me.CodigoFabrica.Text = DR.Item("CodigoFabrica") & ""
            Me.CodigoOriginal.Text = DR.Item("CodigoOriginal") & ""
            Me.UnidadeMedida.Text = DR.Item("UnidadeMedida") & ""
            Me.Grupo.Text = DR.Item("C�digoGrupo") & ""
            Me.GrupoDesc.Text = DR.Item("Grupos.Descri��o") & ""
            Me.Marca.Text = DR.Item("Produtos.Marca") & ""
            Me.MarcaDesc.Text = DR.Item("Marcas.Marca") & ""
            Me.ValorCompra.Text = FormatCurrency(Nz(DR.Item("ValorCompra"), 3), 4)
            Me.ValorVenda.Text = FormatCurrency(Nz(DR.Item("ValorVenda"), 3), 4)
            Me.ValorVendaAtacado.Text = FormatCurrency(Nz(DR.Item("ValorVendaAtacado"), 3), 4)
            Me.DescontoMaximo.Text = Nz(DR.Item("DescontoMaximo"), 3)
            Me.Peso.Text = NzZero(DR.Item("Peso"))
            Me.DataUltimaCompra.Text = DR.Item("DataUltimaCompra") & ""
            Me.DataUltimaVenda.Text = DR.Item("DataUltimaVenda") & ""
            Me.CF.Text = Nz(DR.Item("CF"), 3)
            Me.ComissaoVenda.Text = NzZero(DR.Item("ComissaoVenda"))
            Me.Multiplos.Text = NzZero(DR.Item("Multiplos"))
            Me.EstoqueMinimo.Text = NzZero(DR.Item("EstoqueMinimo"))
            Me.ValorPagoProducao.Text = FormatNumber(NzZero(DR.Item("ValorPagoProducao")), 2)
            Me.ValorP.Text = FormatNumber(NzZero(DR.Item("ValorP")), 2)
            Me.DescVarejo.Text = FormatNumber(NzZero(DR.Item("DescVarejo")), 2)
            Me.DescAtacado.Text = FormatNumber(NzZero(DR.Item("DescAtacado")), 2)
            Me.MostrarListaPreco.Text = DR.Item("MostrarListaPreco") & ""
            Me.CodigoNFE.Text = DR.Item("CodigoNFe") & ""
            Me.ValorVenda2.Text = String.Format("{0:c}", NzZero(DR.Item("Valorvenda2")))
            Me.CboSubICMSEstado.Text = IIf(DR.Item("SubstituicaoICMSEstado") = "S", "SIM", "N�O")
            Me.CboIsentoIcmsEstado.Text = IIf(DR.Item("IsentoICMSEstado") = "S", "SIM", "N�O")
            Me.cboNaoTributadoIcmsEstado.Text = IIf(DR.Item("NaoTributadoIcmsEstado") = "S", "SIM", "N�O")
            txtValorCusto.Text = NzZero(DR.Item("Custo2"))

            '---------------------------------------------------------------------------------------------
            'Aba ICMS

            Me.cstICMS.SelectedIndex = Me.cstICMS.FindStringExact(DR.Item("DescCSTicms") & "")
            Me.origemICMS.SelectedIndex = Me.origemICMS.FindStringExact(DR.Item("OrigemDesc") & "")
            Me.modBCicms.SelectedIndex = Me.modBCicms.FindStringExact(DR.Item("modBCDesc") & "")
            Me.pICMS.Text = Nz(DR.Item("ICMS"), 3)
            '---------------------------------------------------------------------------------------------
            'Aba IPI
            Me.cstIPI.SelectedIndex = Me.cstIPI.FindStringExact(DR.Item("DescCSTipi") & "")
            Me.tCalcIpi.Text = DR.Item("tcalcipi") & ""
            Me.cEnq.Text = DR.Item("cenq") & ""
            Me.pIPI.Text = Nz(DR.Item("Ipi"), 3)
            '----------------------------------------------------------------------------------------------
            'Aba PIS
            Me.cstPIS.SelectedIndex = Me.cstPIS.FindStringExact(DR.Item("DescCSTpis") & "")
            Me.pPIS.Text = Nz(DR.Item("ppis"), 3)
            '---------------------------------------------------------------------------------------------
            'Aba COFINS
            Me.cstCOFINS.SelectedIndex = Me.cstCOFINS.FindStringExact(DR.Item("DescCSTcofins") & "")
            Me.pCOFINS.Text = DR.Item("pCOFINS") & ""
            '--------------------------------------------------------------------------------------------
            Me.QuantidadeEstoque.Text = FormatNumber(Nz(DR.Item("QuantidadeEstoque"), 3), 4)
            Me.EstDeposito.Text = FormatNumber(Nz(DR.Item("EstDeposito"), 3), 4)
            Me.Localiza��o.Text = DR.Item("Localiza��o") & ""
            Me.Localiza��oDesc.Text = DR.Item("SetorLocalDesc") & ""
            Me.Referencia.Text = DR.Item("Produtos.Referencia") & ""
            Me.SubGrupo.Text = DR.Item("Produtos.SubGrupo") & ""
            Me.SubGrupoDesc.Text = DR.Item("SubGrupoDesc") & ""
            Me.TipoGrupo.Text = DR.Item("Produtos.TipoGrupo") & ""
            Me.TipoGrupoDesc.Text = DR.Item("TipoGrupoDesc") & ""
            Me.Cor.Text = DR.Item("Produtos.Cor") & ""
            Me.CorDesc.Text = DR.Item("CorDesc") & ""


            Me.icmsCSTEntr.SelectedValue = DR.Item("icmsCSTEntr")
            Me.cstIPIentr.SelectedValue = DR.Item("cstIPIentr")
            Me.cstPISentr.SelectedValue = DR.Item("cstPISentr")
            Me.cstCOFINSentr.SelectedValue = DR.Item("cstCOFINSentr")

            Me.CFOPentrEstadual.Text = DR.Item("CFOPentrEstadual") & ""
            Me.CFOPsaidaEstadual.Text = DR.Item("CFOPsaidaEstadual") & ""
            Me.CFOPentrInterestadual.Text = DR.Item("CFOPentrInterestadual") & ""
            Me.CFOPsaidaInterestadual.Text = DR.Item("CFOPsaidaInterestadual") & ""
            Me.CodCTBEntrada.Text = DR.Item("CodCTBEntrada") & ""


            If UsarGrade = True Then
                Me.Multiplos.Enabled = False
            Else
                Me.Multiplos.Enabled = True
            End If

            If Me.Tipo.SelectedValue <> 5 Then
                Me.TabComposicaoItens.Visible = False
            Else
                Me.TabComposicaoItens.Visible = True
            End If

            DR.Close()

            Operation = UPD

            VisualizaFoto()

            Dim THRD As New Threading.Thread(AddressOf IniciaUltimasCompras)
            THRD.Priority = ThreadPriority.Highest
            THRD.IsBackground = True
            THRD.Start()
        Else

            A��o.LimpaTextBox(Me)
            Me.UltCompraTab.Visible = False
            Me.cstICMS.SelectedIndex = -1
            Me.modBCicms.SelectedIndex = -1
            Me.origemICMS.SelectedIndex = -1
            Me.pICMS.Clear()

            Me.cstIPI.SelectedIndex = -1
            Me.tCalcIpi.Clear()
            Me.cEnq.Clear()
            Me.pIPI.Clear()

            Me.cstPIS.SelectedIndex = -1
            Me.pPIS.Clear()

            Me.cstCOFINS.SelectedIndex = -1
            Me.pCOFINS.Clear()

            Me.Tipo.SelectedValue = -1
            Me.ControlaEstoque.Text = ""
            Me.UnidadeMedida.Text = ""

            Me.TabOpcoes.SelectedTab = Me.TabOutras

            If UsarGrade = True Then
                Me.Multiplos.Text = 1
                Me.Multiplos.Enabled = False
            Else
                Me.Multiplos.Text = 0
                Me.Multiplos.Enabled = True
            End If
        End If

    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.CodigoProduto.Text = "" Then
            MsgBox("N�o existe Produto para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        If Edi = False Then
            MsgBox("O Usu�rio n�o tem permiss�o para editar o registro, verifique com o Administrador.", 64, "Valida��o de Dados")
            A��o.Desbloquear_Controle(Me, False)
            Exit Sub
        End If
        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.Descri��o.Focus()
    End Sub

    Private Sub Grupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grupo.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            ChamaTelaProcura("Codigo", "Descric�o", "", "Grupos", "C�digoGrupo", "Descri��o", "", True)
            Me.Grupo.Text = RetornoProcura
            If Me.Grupo.Text <> "" Then
                A��o.Descri��o_ItenRegistro(Me.Grupo, Me.GrupoDesc, "Grupos", "C�digoGrupo", Me.Grupo.Text, "Descri��o", TrfGerais.TipoDados.Num�rico, True)
                Me.Grupo.Focus()
            End If
        End If
    End Sub

    Private Sub Marca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Marca.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            ChamaTelaProcura("Codigo", "Descric�o", "", "Marcas", "Codigo", "Marca", "", True)
            Me.Marca.Text = RetornoProcura
            If Me.Marca.Text <> "" Then
                A��o.Descri��o_ItenRegistro(Me.Marca, Me.MarcaDesc, "Marcas", "Codigo", Me.Marca.Text, "Marca", TrfGerais.TipoDados.Num�rico, True)
                Me.Marca.Focus()
            End If
        End If
    End Sub

    Private Sub ValorVenda_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorVenda.Leave, ValorVenda2.Leave
        If Me.ValorVenda.Text <> "" Then Me.ValorVenda.Text = FormatCurrency(Me.ValorVenda.Text, 4)
    End Sub

    Private Sub ValorCompra_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorCompra.Leave
        If Me.ValorCompra.Text <> "" Then Me.ValorCompra.Text = FormatCurrency(Me.ValorCompra.Text, 4)
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes

        If Me.CodigoProduto.Text = "" Then
            MsgBox("O C�digo do produto n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.CodigoProduto.Focus()
            Exit Sub
        ElseIf Me.Descri��o.Text = "" Then
            MsgBox("A descri��o do produto n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Descri��o.Focus()
            Exit Sub
        ElseIf Me.Tipo.Text = "" Then
            MsgBox("O Tipo do produto n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Tipo.Focus()
            Exit Sub
        ElseIf Me.CF.Text = "" Then
            MsgBox("O CF do produto n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.CF.Focus()
            Exit Sub
        ElseIf Me.UnidadeMedida.Text = "" Then
            MsgBox("A Unidade de Medida do Produto n�o foi informada o sistema ir� colocar a data atual de trabalho", 64, "Valida��o de Dados")
            Me.UnidadeMedida.Focus()
            Exit Sub
        ElseIf Me.Grupo.Text = "" Then
            MsgBox("O grupo do produto n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Grupo.Focus()
            Exit Sub
        ElseIf Me.MostrarListaPreco.Text = "" Then
            MsgBox("O campo [Mostrar na Lista de Pre�o] n�o pode ser nulo, favor verificar.", 64, "Valida��o de Dados")
            Me.MostrarListaPreco.Focus()
            Exit Sub
        ElseIf String.IsNullOrEmpty(Me.CboSubICMSEstado.Text) Then
            MsgBox("O campo [Substitui��o ICMS Estado] n�o pode ser nulo, favor verificar.", 64, "Valida��o de Dados")
            Me.CboSubICMSEstado.Focus()
            Exit Sub
        ElseIf String.IsNullOrEmpty(Me.CboIsentoIcmsEstado.Text) Then
            MsgBox("O campo [Isento ICMS Estado] n�o pode ser nulo, favor verificar.", 64, "Valida��o de Dados")
            Me.CboIsentoIcmsEstado.Focus()
            Exit Sub
        ElseIf Me.Marca.Text = "" Then
            MsgBox("A marca do produto n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Marca.Focus()
            Exit Sub

            If Me.Tipo.Text = "" Then
                MessageBox.Show("O tipo do produto deve ser selecionado", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Tipo.Focus()
                Exit Sub
            End If

            'Situa��o Tribut�ria.
        ElseIf Me.cstICMS.Text = "" Then
            MsgBox("O CST do produto n�o foi informado", 64, "Valida��o de Dados")
            Dim tab As DevComponents.DotNetBar.TabItem = Me.TabICMS
            Me.TabOpcoes.SelectedTab = tab
            Me.cstICMS.Focus()
            Exit Sub

            'Origem do ICMS
        ElseIf Me.origemICMS.Text = "" Then
            MsgBox("A origem do ICMS n�o foi informado.", 64, "Valida��o de Dados")
            Me.origemICMS.Focus()
            Exit Sub

            'Mod. determina��o BcICMS
        ElseIf Me.modBCicms.Text = "" Then
            MsgBox("O Mod. Determina��o BCicms n�o foi informado.", 64, "Valida��o de Dados")
            Me.modBCicms.Focus()
            Exit Sub
        End If

        If Me.pICMS.Text = "" Then
            MsgBox("O ICMS do produto n�o foi informado o sistema ira definir como 17%.", 64, "Valida��o de Dados")
            Me.pICMS.Text = 17
            Exit Sub
        End If

        If Me.pPIS.Text = "" Then
            MsgBox("A aliquota de PIS do produto n�o foi informado.", 64, "Valida��o de Dados")
            Me.pPIS.Focus()
            Exit Sub
        End If

        If Me.pCOFINS.Text = "" Then
            MsgBox("A aliquota do COFINS do produto n�o foi informado.", 64, "Valida��o de Dados")
            Me.pCOFINS.Focus()
            Exit Sub
        End If

        If Me.ValorCompra.Text = "" Then
            Me.ValorCompra.Text = FormatCurrency(0, 2)
        End If

        If Me.ValorVenda.Text = "" Then
            MsgBox("O valor de venda do produto n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.ValorVenda.Focus()
            Exit Sub
        End If

        'Lelo
        If Me.ValorVendaAtacado.Text = "" Or Me.ValorVendaAtacado.Text = "R$ 0,0000" Then
            MsgBox("O valor de venda atacado do produto n�o foi informado, favor verificar. Caso n�o trabalhe com venda de atacado informe o mesmo valor de venda", 64, "Valida��o de Dados")
            'Me.ValorVendaAtacado.Text = FormatNumber(0, 2)
            Me.ValorVendaAtacado.Focus()
            Exit Sub
        End If
        'Lelo

        If Me.DescontoMaximo.Text = "" Then
            Me.DescontoMaximo.Text = 0
        End If

        If Me.Peso.Text = "" Then
            Me.Peso.Text = 0
        End If

        If Me.ControlaEstoque.Text = "" Then
            MessageBox.Show("O usu�rio deve definir se este item ser� ou n�o controlado o estoque.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ControlaEstoque.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(Multiplos.Text) Then
            MessageBox.Show("O usu�rio n�o pode definir Multiplos como vazio, Defina como zero ou com valores inteiros maiores que [0].", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Multiplos.Focus()
            Exit Sub
        End If

        If Me.CodigoProduto.Text <> "0000" Then
            If String.IsNullOrEmpty(Trim(Me.CodigoNFE.Text)) Then
                MessageBox.Show("O campo C�digo NFe n�o pode ser nulo", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CodigoNFE.Focus()
                Exit Sub
            End If
        End If


        'C�digo - Feito pelo Marcos Aur�lio para testar se o cliente n�o apagou o cod da nfe
       

        If Me.ComissaoVenda.Text = "" Then Me.ComissaoVenda.Text = FormatNumber(0, 2)
        'Fim da Area destinada para as validacoes

        If Me.EstoqueMinimo.Text = "" Then Me.EstoqueMinimo.Text = FormatNumber(0, 4)

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            If Adi = False Then
                MsgBox("O Usu�rio n�o tem permiss�o para adicionar o registro, verifique com o Administrador.", 64, "Valida��o de Dados")
                Exit Sub
            End If
            CNN.Open()

            UltimoReg()


   

            If Me.CodigoProduto.Text = "0000" Then
                MsgBox("O sistema n�o conseguiu definir o ultimo c�digo para salvar o registro, verifique.", 64, "Valida��o de Dados")
                Exit Sub
            End If

            Dim Sql As String = "INSERT INTO Produtos (CodigoProduto, Descri��o, Tipo, ControlaEstoque, CodigoBarra, UnidadeMedida, C�digoGrupo, Marca, ValorCompra, ValorVenda, DescontoMaximo, Peso, DataUltimaVenda, DataUltimaCompra, Icms, CF, Cst, Ipi, QuantidadeEstoque, Empresa, Localiza��o, Referencia, Cor, TipoGrupo, SubGrupo, OrigemIcms, Ean, cEanTrib, ModBcIcms, TcalcIPI, CstPIS, pPIS, cstCofins, pCofins, cEnq, CstIPI, CodigoOriginal, CodigoFabrica, ComissaoVenda, Multiplos, EstoqueMinimo, ValorPagoProducao, ValorP, DescVarejo, DescAtacado, MostrarListaPreco, CodigoNFE, ValorVenda2,SubstituicaoICMSEstado,IsentoICMSEstado, NaoTributadoIcmsEstado, Atualizado, ValorVendaAtacado, icmsCSTEntr, cstIPIentr, cstPISentr, cstCOFINSentr, CFOPentrEstadual, CFOPsaidaEstadual, CFOPentrInterestadual, CFOPsaidaInterestadual, CodCTBEntrada)" _
            & " VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59, @60, @61, @62)"

            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descri��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.Tipo.SelectedValue))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ControlaEstoque.Text, 1)))
            If Me.CodigoBarra.Text = "" Then
                Me.CodigoBarra.Text = Me.CodigoProduto.Text
            End If
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.CodigoBarra.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.UnidadeMedida.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Grupo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Marca.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorCompra.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.ValorVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.DescontoMaximo.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Peso.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.DataUltimaVenda.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.DataUltimaCompra.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.pICMS.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.CF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", NzVlr(PegaVlrCombo(Me.cstICMS, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", NzVlr(Me.pIPI.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", NzZero(Me.QuantidadeEstoque.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.Localiza��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.Referencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.Cor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.TipoGrupo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.SubGrupo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", NzVlr(PegaVlrCombo(Me.origemICMS, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", NzVlr(Me.Ean.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", NzVlr(Me.cEanTrib.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", NzVlr(PegaVlrCombo(Me.modBCicms, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", NzVlr(Me.tCalcIpi.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", NzVlr(PegaVlrCombo(Me.cstPIS, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", NzVlr(Me.pPIS.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", NzVlr(PegaVlrCombo(Me.cstCOFINS, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", NzVlr(Me.pCOFINS.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", NzVlr(Me.cEnq.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", NzVlr(PegaVlrCombo(Me.cstIPI, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", NzVlr(Me.CodigoOriginal.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", NzVlr(Me.CodigoFabrica.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", NzZero(Me.ComissaoVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", NzZero(Me.Multiplos.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", NzZero(Me.EstoqueMinimo.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", NzZero(Me.ValorPagoProducao.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", NzZero(Me.ValorP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", NzZero(Me.DescVarejo.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", NzZero(Me.DescAtacado.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.MostrarListaPreco.Text, 1)))
            If String.IsNullOrEmpty(Me.CodigoNFE.Text) Then
                Me.CodigoNFE.Text = Me.CodigoProduto.Text
            End If
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.CodigoNFE.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", NzZero(Me.ValorVenda2.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@49", IIf(Me.CboSubICMSEstado.Text = "SIM", "S", "N")))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@50", IIf(Me.CboIsentoIcmsEstado.Text = "SIM", "S", "N")))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@51", IIf(Me.cboNaoTributadoIcmsEstado.Text = "SIM", "S", "N")))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@52", True))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@53", NzZero(Me.ValorVendaAtacado.Text)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@54", Nz(Me.icmsCSTEntr.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@55", Nz(Me.cstIPIentr.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@56", Nz(Me.cstPISentr.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@57", Nz(Me.cstCOFINSentr.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@58", Nz(Me.CFOPentrEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@59", Nz(Me.CFOPsaidaEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@60", Nz(Me.CFOPentrInterestadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@61", Nz(Me.CFOPsaidaInterestadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@62", Nz(Me.CodCTBEntrada.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Adicionou, Me.CodigoProduto.Text)
                DesbloquearTextBox(Me, False)
                Operation = VAZ
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            CNN.Close()

        ElseIf Operation = UPD Then
            If Edi = False Then
                MsgBox("O Usu�rio n�o tem permiss�o para editar o registro, verifique com o Administrador.", 64, "Valida��o de Dados")
                Exit Sub
            End If

            CNN.Open()

            Dim Sql As String = "UPDATE Produtos SET  Descri��o = @1, Tipo = @2, ControlaEstoque = @3, CodigoBarra = @4, UnidadeMedida = @5, C�digoGrupo = @6, Marca = @7, ValorCompra = @8, ValorVenda = @9, DescontoMaximo = @10, Peso = @11, DataUltimaVenda = @12, DataUltimaCompra = @13, Icms = @14, CF = @15, Cst = @16, Ipi = @17, QuantidadeEstoque = @18, Empresa = @19, Localiza��o = @20, Referencia = @21, Cor = @22, TipoGrupo = @23, SubGrupo = @24, OrigemIcms = @25, Ean = @26, cEanTrib = @27, ModBcIcms = @28, TcalcIPI = @29, CstPIS = @30, pPIS = @31, cstCofins = @32, pCofins = @33, cEnq = @34, CstIPI = @35, CodigoOriginal = @36, CodigoFabrica = @37, ComissaoVenda = @38, Multiplos = @39, EstoqueMinimo = @40, ValorPagoProducao = @41, ValorP = @42, DescVarejo = @43, DescAtacado = @44, MostrarListaPreco = @45, CodigoNFE = @46, ValorVenda2 = @47, SubstituicaoICMSEstado = @48, IsentoICMSEstado = @49, NaoTributadoIcmsEstado = @50, Atualizado = @51, ValorVendaAtacado = @52, icmsCSTEntr = @53, cstIPIentr = @54, cstPISentr = @55, cstCOFINSentr = @56, CFOPentrEstadual = @57, CFOPsaidaEstadual = @58, CFOPentrInterestadual = @59, CFOPsaidaInterestadual = @60, CodCTBEntrada = @61 Where CodigoProduto = " & Me.CodigoProduto.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)


            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Descri��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.Tipo.SelectedValue))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ControlaEstoque.Text, 1)))
            If Me.CodigoBarra.Text = "" Then
                Me.CodigoBarra.Text = Me.CodigoProduto.Text
            End If
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.CodigoBarra.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.UnidadeMedida.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Grupo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Marca.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorCompra.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.ValorVenda.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.DescontoMaximo.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Peso.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.DataUltimaVenda.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.DataUltimaCompra.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.pICMS.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.CF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzVlr(PegaVlrCombo(Me.cstICMS, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", NzVlr(Me.pIPI.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.QuantidadeEstoque.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.Localiza��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.Referencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.Cor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.TipoGrupo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.SubGrupo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", NzVlr(PegaVlrCombo(Me.origemICMS, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", NzVlr(Me.Ean.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", NzVlr(Me.cEanTrib.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", NzVlr(PegaVlrCombo(Me.modBCicms, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", NzVlr(Me.tCalcIpi.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", NzVlr(PegaVlrCombo(Me.cstPIS, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", NzVlr(Me.pPIS.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", NzVlr(PegaVlrCombo(Me.cstCOFINS, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", NzVlr(Me.pCOFINS.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", NzVlr(Me.cEnq.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", NzVlr(PegaVlrCombo(Me.cstIPI, TpRetornoCBO.N�o))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", NzVlr(Me.CodigoOriginal.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", NzVlr(Me.CodigoFabrica.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", NzZero(Me.ComissaoVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", NzZero(Me.Multiplos.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", NzZero(Me.EstoqueMinimo.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", NzZero(Me.ValorPagoProducao.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", NzZero(Me.ValorP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", NzZero(Me.DescVarejo.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", NzZero(Me.DescAtacado.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.MostrarListaPreco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.CodigoNFE.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", NzZero(Me.ValorVenda2.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", IIf(Me.CboSubICMSEstado.Text = "SIM", "S", "N")))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@49", IIf(Me.CboIsentoIcmsEstado.Text = "SIM", "S", "N")))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@50", IIf(Me.cboNaoTributadoIcmsEstado.Text = "SIM", "S", "N")))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@51", True))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@52", NzZero(Me.ValorVendaAtacado.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@53", Nz(Me.icmsCSTEntr.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@54", Nz(Me.cstIPIentr.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@55", Nz(Me.cstPISentr.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@56", Nz(Me.cstCOFINSentr.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@57", Nz(Me.CFOPentrEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@58", Nz(Me.CFOPsaidaEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@59", Nz(Me.CFOPentrInterestadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@60", Nz(Me.CFOPsaidaInterestadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@61", Nz(Me.CodCTBEntrada.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Editou, Me.CodigoProduto.Text)
                Operation = VAZ
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            ' A��o.Desbloquear_Controle(Me, False)
            DesbloquearTextBox(Me, False)
            CNN.Close()
        End If

    End Sub

    Private Sub btFotoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFotoProduto.Click
        If Me.CodigoProduto.Text = "" Then
            MsgBox("O usu�rio deve selecionar um produto para Adionar/Visualizar/Editar a Foto.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "(Png Files) *.Png | *.png"
        OpenFileDialog1.Title = "Selecione um arquivo png para inserir no campo Imagem"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            CaminhoImagem = OpenFileDialog1.FileName
            SalvaFoto()
            VisualizaFoto()
            'MsgBox("A imagem foi capturada, utilize o bot�o salvar para armazenar no banco de dados", 64, TituloMsgBox)
            Exit Sub
        End If
    End Sub

    Private Sub CodigoProduto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CodigoProduto.Validating
        If IsNumeric(CodigoProduto.Text) Then
            If Me.CodigoProduto.Text <> "0000" Then
                If String.CompareOrdinal(Me.CodigoProduto.Text, Me.CodigoProduto.TextoAntigo) Then
                    LocalizaDados()
                    EncheListaComposicao()
                End If
            End If
        Else
            CodigoProduto.Clear()
        End If
    End Sub

    Public Sub VisualizaFoto()
        'Conexao
        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        'tratamento de erro
        Try
            'command para pegar os dados 
            Dim Cmd As New OleDb.OleDbCommand("SELECT * From ProdutosFoto where CodigoProduto = " & Me.CodigoProduto.Text, Cn)
            'dataadapter para fazer a liga��o dos dados
            Dim Da As New OleDb.OleDbDataAdapter(Cmd)
            'dataset para guardar em mem�ria os dados
            Dim Ds As New DataSet()
            'abre conex�o
            Cn.Open()
            'preenche dataset com a tabela "ProdutosFotos"
            Da.Fill(Ds, "FotoProduto")
            'variavel para recebe a quantidade de linhas da tabela retornada
            Dim c As Integer = Ds.Tables(0).Rows.Count
            If c > 0 Then
                'array recebe a �ltima linha do dataset, a imagem
                Dim ByteData() As Byte = Ds.Tables(0).Rows(c - 1).Item("Foto")
                'stream em mem�ria recebe a imagem
                Dim ImgVer As New MemoryStream(ByteData)
                'a picturebox recebe imagem que usa o m�todo FromStream para "ler" a stream que cont�m a imagem

                'Compara tamanhos para fazer ajustes no quadro de visualiza��o
                Me.Display.Visible = True
                Me.Display.Image = Image.FromStream(ImgVer)
                OperationImage = UPD
            Else
                Me.Display.Image = Me.Vazio.Image
                OperationImage = INS
            End If
            Cn.Close()
        Catch err As Exception
            Me.Display.Visible = False
        Finally
            'fecha a conex�o
            Cn.Close()
        End Try

    End Sub

    Public Sub SalvaFoto()

        Dim arqImg As FileStream
        Dim rImg As StreamReader

        If Len(CaminhoImagem) <> 0 Then
            arqImg = New FileStream(CaminhoImagem, FileMode.Open, FileAccess.Read, FileShare.Read)
            rImg = New StreamReader(arqImg)
        Else
            MsgBox("Defina uma foto para inserir no Banco de dados.", 64, "Valida��o de Dados")
            Exit Sub
        End If

        Dim Conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Sql As String = ""


        If OperationImage = UPD Then
            Sql = "Update ProdutosFoto Set Foto = ? where CodigoProduto = " & Me.CodigoProduto.Text
        Else
            Sql = "INSERT INTO ProdutosFoto(CodigoProduto, Foto) VALUES (?,?)"
        End If

        Dim Cmd As New OleDb.OleDbCommand(Sql, Conn)

        Try
            'declaramos um vetor de bytes para armazenar o conte�do da imagem a ser salva 
            Dim arqByteArray(arqImg.Length - 1) As Byte
            arqImg.Read(arqByteArray, 0, arqImg.Length)

            If OperationImage = UPD Then
                Cmd.Parameters.Add("@Foto", OleDb.OleDbType.Binary, arqImg.Length).Value = arqByteArray
            Else
                Cmd.Parameters.Add("@CodigoProduto", OleDb.OleDbType.Integer).Value = Me.CodigoProduto.Text
                Cmd.Parameters.Add("@Foto", OleDb.OleDbType.Binary, arqImg.Length).Value = arqByteArray
            End If

            Cmd.Connection.Open()
            Cmd.ExecuteNonQuery()
            Cmd.Connection.Close()
            Conn.Close()
            MsgBox("Imagem incluida/Alterada com sucesso !", 64, "Valida��o de Dados")

        Catch Ex As Exception
            MsgBox(Ex.Message, 64, "Valida��o de Dados")
        End Try

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
            .CommandText = "SELECT Max(Produtos.CodigoProduto) AS M�xDeCodigoProduto FROM(Produtos)"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas ser�o preenchida
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

        Me.CodigoProduto.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub

    Private Sub InativarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InativarBT.Click

        Dim HH As DateTime = Now


        Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.CodigoProduto.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If
        ' cod seguran�a retirado - Lelo
        ' Dim CodSeguran�a As String = InformaCodigoSeguranca()
        'If VerificaCodigoSeguran�a(CodSeguran�a) = False Then
        'MsgBox("C�digo de Seguran�a inv�lido, Verifique.", 64, "Valida��o de Dados")
        'Exit Sub
        'End If

        If MsgBox("Deseja realmente inativar este produto.", 36, "Valida��o de Dados") = 6 Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Try
                Dim Sql As String = "UPDATE Produtos SET Inativo = @1, Atualizado=@2 Where CodigoProduto = " & Me.CodigoProduto.Text
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN, Transacao)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", True))
                cmd.ExecuteNonQuery()

                'elimina  os registros na tabela prodEmit referente ao produto selecionado
                Sql = "DELETE * FROM prodEmit Where ProdErp ='" & Me.CodigoProduto.Text & "'"
                cmd = New OleDb.OleDbCommand(Sql, CNN, Transacao)
                cmd.ExecuteNonQuery()

                Transacao.Commit()
                MsgBox("Registro Inativado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Inativou, Me.CodigoProduto.Text)
            Catch x As Exception
                Transacao.Rollback()
                MsgBox(x.Message)
                Exit Sub
            End Try

            CNN.Close()
            NovoBT_Click(sender, e)
        End If

    End Sub

    Private Sub Localiza��o_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Localiza��o.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            ChamaTelaProcura("Setor", "Descric�o", "", "ProdutoLocal", "SetorLocal", "SetorLocalDesc", "", True)
            Me.Localiza��o.Text = RetornoProcura
            If Me.Localiza��o.Text <> "" Then
                A��o.Descri��o_ItenRegistro(Me.Localiza��o, Me.Localiza��oDesc, "ProdutoLocal", "SetorLocal", Me.Localiza��o.Text, "SetorLocalDesc", TrfGerais.TipoDados.AlfaNum�rico, True)
                Me.Localiza��o.Focus()
            End If
        End If
    End Sub

    Private Sub SubGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SubGrupo.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            ChamaTelaProcura("Codigo", "Descric�o", "", "SubGrupo", "Codigo", "SubGrupoDesc", "", True)
            Me.SubGrupo.Text = RetornoProcura
            Me.SubGrupo.Focus()
        End If
    End Sub

    Private Sub TipoGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TipoGrupo.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            ChamaTelaProcura("Codigo", "Descric�o", "", "TipoGrupo", "Codigo", "TipoGrupoDesc", "", True)
            Me.TipoGrupo.Text = RetornoProcura
            Me.TipoGrupo.Focus()
        End If
    End Sub

    Private Sub Cor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cor.KeyDown
        Select Case e.KeyCode
            Case 13
                Me.TabOpcoes.SelectedTab = Me.TabICMS
                'Me.cstICMS.Focus()
        End Select

        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            ChamaTelaProcura("Codigo", "Descric�o", "", "Cor", "Codigo", "CorDesc", "", True)
            Me.Cor.Text = RetornoProcura
            Me.Cor.Focus()
        End If
    End Sub

    Private Sub SubGrupo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubGrupo.Validated
        If Me.SubGrupo.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.SubGrupo, Me.SubGrupoDesc, "SubGrupo", "Codigo", Me.SubGrupo.Text, "SubGrupoDesc", TrfGerais.TipoDados.Num�rico, True)
        Else
            Me.SubGrupoDesc.Text = ""
        End If

    End Sub

    Private Sub TipoGrupo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TipoGrupo.Validated
        If Me.TipoGrupo.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.TipoGrupo, Me.TipoGrupoDesc, "TipoGrupo", "Codigo", Me.TipoGrupo.Text, "TipoGrupoDesc", TrfGerais.TipoDados.Num�rico, True)
        Else
            Me.TipoGrupoDesc.Text = ""
        End If
    End Sub

    Private Sub CarregaCSTipi()
        Dim i As Integer
        For i = 0 To IpiArray.Count - 1
            cstIPI.Items.Add(New cboItemData(IpiArray(i).Valor, IpiArray(i).Descri��o))
        Next
    End Sub

    Private Sub CarregaCSTpis()
        Dim i As Integer
        For i = 0 To PisArray.Count - 1
            cstPIS.Items.Add(New cboItemData(PisArray(i).Valor, PisArray(i).Descri��o))
        Next
    End Sub

    Private Sub CarregaCSTcofins()
        Dim i As Integer
        For i = 0 To CofinsCSTArray.Count - 1
            cstCOFINS.Items.Add(New cboItemData(CofinsCSTArray(i).Valor, CofinsCSTArray(i).Descri��o))
        Next
    End Sub

    Private Sub CarregaORIGEMicms()
        Dim i As Integer
        For i = 0 To OrigemIcmsArray.Count - 1
            origemICMS.Items.Add(New cboItemData(OrigemIcmsArray(i).Valor, OrigemIcmsArray(i).Descri��o))
        Next
    End Sub

    Private Sub CarregaIcmsModalidadeBC()
        Dim i As Integer
        For i = 0 To IcmsModalidadeBCArray.Count - 1
            modBCicms.Items.Add(New cboItemData(IcmsModalidadeBCArray(i).Valor, IcmsModalidadeBCArray(i).Descri��o))
        Next
    End Sub

    Private Sub CarregaCSTicms() 'carrega icms de venda
        Dim i As Integer
        For i = 0 To IcmsArray.Count - 1
            cstICMS.Items.Add(New cboItemData(IcmsArray(i).Valor, IcmsArray(i).Descri��o))
            icmsCSTEntr.Items.Add(New cboItemData(IcmsArray(i).Valor, IcmsArray(i).Descri��o))
        Next
    End Sub

    Private Sub Produtos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Operation = VAZ

        If UsarGrade = False Then
            Me.btGrade.Visible = False
        Else
            Me.btGrade.Visible = True
        End If

        CarregaCSTicms()
        CarregaCSTipi()
        CarregaCSTpis()
        CarregaCSTcofins()
        CarregaORIGEMicms()
        CarregaIcmsModalidadeBC()
        CarregaComboProdutoTipo()

        EncheListaICMS()
        EncheListaIPI()
        EncheListaPIS()
        EncheListaCOFINS()

    End Sub

    Private Function PegaVlrCombo(ByVal Cbo As CBOAutoCompleteFocus.CboFocus, ByVal Retorna_Descri��o As TpRetornoCBO)

        Dim Retorno As String = ""
        If Cbo.Text = "" Then
            Retorno = ""
        Else
            Cbo.SelectedIndex = Cbo.FindStringExact(Cbo.Text & "")
            If Retorna_Descri��o = TpRetornoCBO.N�o Then
                Retorno = CType(Cbo.SelectedItem, cboItemData).ItemData
            Else
                Retorno = CType(Cbo.SelectedItem, cboItemData).Name
            End If
        End If
        Return Retorno

    End Function

    Private Sub Localiza��o_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Localiza��o.Validated
        If Not Me.Localiza��o.Text = "" Then
            A��o.Descri��o_ItenRegistro(Me.Localiza��o, Me.Localiza��oDesc, "ProdutoLocal", "SetorLocal", Me.Localiza��o.Text, "SetorLocalDesc", TrfGerais.TipoDados.AlfaNum�rico, True)
        Else
            Me.Localiza��oDesc.Text = ""
        End If
    End Sub

    Private Sub Marca_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Marca.Validated
        If Not Me.Marca.Text = "" Then
            A��o.Descri��o_ItenRegistro(Me.Marca, Me.MarcaDesc, "Marcas", "Codigo", Me.Marca.Text, "Marca", TrfGerais.TipoDados.Num�rico, True)
        Else
            Me.MarcaDesc.Text = ""
        End If
    End Sub

    Private Sub Grupo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grupo.Validated
        If Not Me.Grupo.Text = "" Then
            A��o.Descri��o_ItenRegistro(Me.Grupo, Me.GrupoDesc, "Grupos", "C�digoGrupo", Me.Grupo.Text, "Descri��o", TrfGerais.TipoDados.Num�rico, True)
        Else
            Me.GrupoDesc.Text = ""
        End If
    End Sub

    Private Sub pICMS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pICMS.KeyDown
        If e.KeyCode = 13 Then
            If Me.pICMS.Text = "" Then Me.pICMS.Text = 0
            Me.TabOpcoes.SelectedTab = Me.TabItem3
            'Me.cstIPI.Focus()
        End If
    End Sub

    Private Sub pPIS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pPIS.KeyDown
        If e.KeyCode = 13 Then
            If Me.pPIS.Text = "" Then Me.pPIS.Text = 0
            Me.TabOpcoes.SelectedTab = Me.TabItem5
            'Me.cstCOFINS.Focus()
        End If
    End Sub
   
    Private Sub pIPI_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pIPI.KeyDown
        If e.KeyCode = 13 Then
            If Me.pIPI.Text = "" Then Me.pIPI.Text = 0
            Me.TabOpcoes.SelectedTab = Me.TabItem4
            'Me.cstPIS.Focus()
        End If
    End Sub

    Private Sub CarregaComboProdutoTipo()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet
        Dim Sql As String = "Select * From ProdutoTipo Where CodTipoProduto <> 99"
        Dim daProdutoTipo As OleDb.OleDbDataAdapter

        daProdutoTipo = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daProdutoTipo.Fill(DS, "ProdutoTipo")

        Me.Tipo.DataSource = DS.Tables("ProdutoTipo")
        Me.Tipo.ValueMember = "CodTipoProduto"
        Me.Tipo.DisplayMember = "DescTipoProduto"
        Me.Tipo.SelectedIndex = -1
        Cnn.Close()

    End Sub

    Private Sub Localiza��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Localiza��oToolStripMenuItem.Click
        My.Forms.ProdutoLocal.ShowDialog()
    End Sub

    Private Sub GruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposToolStripMenuItem.Click
        My.Forms.Grupos.ShowDialog()
    End Sub

    Private Sub SubGruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubGruposToolStripMenuItem.Click
        My.Forms.SubGrupo.ShowDialog()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasToolStripMenuItem.Click
        My.Forms.Marcas.ShowDialog()
    End Sub

    Private Sub TipoGruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoGruposToolStripMenuItem.Click
        My.Forms.TipoGrupo.ShowDialog()
    End Sub

    Private Sub CoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoresToolStripMenuItem.Click
        My.Forms.Cor.ShowDialog()
    End Sub

    Private Sub Cor_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cor.Validated
        If Me.Cor.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.Cor, Me.CorDesc, "Cor", "Codigo", Me.Cor.Text, "CorDesc", TrfGerais.TipoDados.Num�rico, True)
        Else
            Me.CorDesc.Clear()
        End If
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        If Me.CodigoProduto.Text = "" Then
            MessageBox.Show("Para adicionar um Produto de composi��o o usuario deve selecionar um produto principal antes.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.ProdutoComposicaoAdd.ShowDialog()
    End Sub

    Public Sub EncheListaComposicao()

        If Me.CodigoProduto.Text = "" Then Exit Sub

        MyLista.Items.Clear()


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = String.Empty

        Sql = "SELECT ProdutoComposicao.Produto, ProdutoComposicao.ProdComposicao, Produtos.Descri��o, ProdutoComposicao.QtdUsar, Produtos.ValorCompra, Produtos.ValorVenda, Produtos.Tipo, ProdutoComposicao.Empresa FROM ProdutoComposicao INNER JOIN Produtos ON ProdutoComposicao.ProdComposicao = Produtos.CodigoProduto WHERE (((ProdutoComposicao.Produto)=" & Me.CodigoProduto.Text & ") AND ((ProdutoComposicao.Empresa)=" & CodEmpresa & "));"

        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try

            DR = Cmd.ExecuteReader

            Dim Zebrar As Boolean = False
            Dim TotalLista As Double = 0

            Dim VlrTCusto As Double = 0
            While DR.Read
                If Not IsDBNull(DR.Item("ProdComposicao")) Then
                    Dim AA As String = DR.Item("ProdComposicao")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Descri��o") & "")
                    It.SubItems.Add(FormatNumber(DR.Item("QtdUsar"), 4))

                    Dim VlrCusto As Double = 0
                    Dim Unitario As Double = 0

                    If DR.Item("Tipo") = 99 Then
                        VlrCusto = NzZero(DR.Item("ValorVenda")) * FormatNumber(NzZero(DR.Item("QtdUsar")), 4)
                        Unitario = NzZero(DR.Item("ValorVenda"))
                    Else
                        VlrCusto = NzZero(DR.Item("ValorCompra")) * FormatNumber(NzZero(DR.Item("QtdUsar")), 4)
                        Unitario = NzZero(DR.Item("ValorCompra"))
                    End If
                    It.SubItems.Add(FormatNumber(NzZero(Unitario), 2))
                    It.SubItems.Add(FormatNumber(NzZero(VlrCusto), 2))

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
                        Zebrar = True
                    End If

                    VlrTCusto += FormatNumber(NzZero(VlrCusto), 4)
                End If
            End While
            Me.TCusto.Text = FormatNumber(VlrTCusto, 4)

            DR.Close()
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub btEdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdd.Click

        If Me.CodigoProduto.Text = "" Then
            MessageBox.Show("Para adicionar um Produto de composi��o o usuario deve selecionar um produto principal antes.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = MyLista.Items(I).Text.Substring(0)
        Next


        My.Forms.ProdutoComposicaoAdd.OperationItens = UPD
        My.Forms.ProdutoComposicaoAdd.ShowDialog()

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        btEdd_Click(sender, e)
    End Sub

    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        If Me.CodigoProduto.Text = "" Then
            MessageBox.Show("Para adicionar um Produto de composi��o o usuario deve selecionar um produto principal antes.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim I As Integer = 0
        Dim Prod As String = String.Empty

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Prod = MyLista.Items(I).Text.Substring(0)
        Next

        If Prod = "" Then
            MessageBox.Show("O usu�rio deve selecionar o item para excluir", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MsgBox("Deseja realmente excluir o registro selecionado.", 36, "Valida��o de Dados") = 6 Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            Dim Sql As String = "Delete * from ProdutoComposicao Where Produto = " & Me.CodigoProduto.Text & " and ProdComposicao = " & Prod
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.ExecuteNonQuery()
            MsgBox("Registro excluido com sucesso", 64, "Valida��o de Dados")
            CNN.Close()
            EncheListaComposicao()

        End If

    End Sub

    Private Sub pCOFINS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pCOFINS.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.pCOFINS.Text = "" Then Me.pCOFINS.Text = 0
            Me.TabOpcoes.SelectedTab = Me.TabComposicaoItens
        End If
    End Sub

    Private Sub btMarkup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMarkup.Click
        If Me.CodigoProduto.Text = "0000" Then
            MsgBox("O registro ainda n�o foi salvo, clique no bot�o salvar para poder lan�ar os valores de custo", 48, "Valida��o de dados")
            Exit Sub
        End If
        If Me.CodigoProduto.Text = "" Then
            Exit Sub
        End If

        My.Forms.CompraAlterarCusto.ShowDialog()

        LocalizaDados()

    End Sub

    Private Sub cstPIS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstPIS.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cstPIS.Text = "" Then Me.cstPIS.SelectedIndex = Me.cstPIS.FindStringExact("Outras Opera��es")
        End If
    End Sub

    Private Sub cstCOFINS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstCOFINS.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cstCOFINS.Text = "" Then Me.cstCOFINS.SelectedIndex = Me.cstCOFINS.FindStringExact("COFINS 99 - Outras Opera��es")
        End If
    End Sub

    Private Sub cstICMS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstICMS.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cstICMS.Text = "" Then Me.cstICMS.SelectedIndex = Me.cstICMS.FindStringExact("102�Tributada pelo Simples Nacional sem permiss�o de cr�dito")
        End If
    End Sub

    Private Sub origemICMS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles origemICMS.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.origemICMS.Text = "" Then Me.origemICMS.SelectedIndex = Me.origemICMS.FindStringExact("Nacional")
        End If
    End Sub

    Private Sub modBCicms_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles modBCicms.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.modBCicms.Text = "" Then Me.modBCicms.SelectedIndex = Me.modBCicms.FindStringExact("Valor da Opera��o")
        End If
    End Sub

    Private Sub cstIPI_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstIPI.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cstIPI.Text = "" Then Me.cstIPI.SelectedIndex = Me.cstIPI.FindStringExact("IPI 53 - Sa�da n�o-tributada")
        End If
    End Sub

    Private Sub tCalcIpi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tCalcIpi.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.tCalcIpi.Text = "" Then Me.tCalcIpi.Text = 1
        End If
    End Sub

    Private Sub cEnq_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cEnq.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cEnq.Text = "" Then Me.cEnq.Text = 999
        End If
    End Sub

    Private Sub Tipo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tipo.Validated
        If Me.Tipo.SelectedValue <> 5 Then
            Me.TabComposicaoItens.Visible = False
        Else
            Me.TabComposicaoItens.Visible = True
        End If
    End Sub

#Region "Carrega dados das Compras"
    Delegate Sub myDelegate()

    Private Sub IniciaUltimasCompras()
        If Me.InvokeRequired Then
            Me.Invoke(New myDelegate(AddressOf EncheListaUltimaCompra))
        End If
    End Sub

    Private Sub EncheListaUltimaCompra()
        Dim CnnTRD As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnTRD.Open()

        Dim Sql As String = String.Empty


        Sql = "SELECT TOP 10 Compra.DataCompra, Compra.DataLan�amento, ItensCompra.CompraInterno, Compra.NotaFiscal, [C�digoFornecedor] & '-' & [Raz�oSocial] AS Fornecedor, ItensCompra.Qtd, ItensCompra.ValorUnitario, Compra.TpEntrada FROM (ItensCompra INNER JOIN Compra ON ItensCompra.CompraInterno = Compra.CompraInterno) INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.C�digoFornecedor WHERE(((ItensCompra.CodigoProduto) = " & Me.CodigoProduto.Text & ") And ((Compra.Inativo) = False) And ((Compra.TpEntrada) = 'ENTRADA')) ORDER BY Compra.DataCompra DESC;"
        Dim da = New OleDb.OleDbDataAdapter(Sql, CnnTRD)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        CnnTRD.Close()

        If Me.Lista.RowCount > 0 Then
            Me.UltCompraTab.Visible = True
        Else
            Me.UltCompraTab.Visible = False
        End If
    End Sub
#End Region

    Private Sub btGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGrade.Click
        If Me.CodigoProduto.Text = "" Then
            MessageBox.Show("N�o existe produto selecionado para visualiza��o ou cadastro da grade", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.ProdutosGrade.ShowDialog()
    End Sub

    Private Sub btLocalizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizacao.Click
        RetornoProcura = ""
        ChamaTelaProcura("Setor", "Descric�o", "", "ProdutoLocal", "SetorLocal", "SetorLocalDesc", "", True)
        Me.Localiza��o.Text = RetornoProcura
        If Me.Localiza��o.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.Localiza��o, Me.Localiza��oDesc, "ProdutoLocal", "SetorLocal", Me.Localiza��o.Text, "SetorLocalDesc", TrfGerais.TipoDados.AlfaNum�rico, True)
            Me.Localiza��o.Focus()
        End If
    End Sub

    Private Sub btGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGrupo.Click
        RetornoProcura = ""
        ChamaTelaProcura("Codigo", "Descric�o", "", "Grupos", "C�digoGrupo", "Descri��o", "", True)
        Me.Grupo.Text = RetornoProcura
        If Me.Grupo.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.Grupo, Me.GrupoDesc, "Grupos", "C�digoGrupo", Me.Grupo.Text, "Descri��o", TrfGerais.TipoDados.Num�rico, True)
            Me.Grupo.Focus()
        End If
    End Sub

    Private Sub btSubGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSubGrupo.Click
        RetornoProcura = ""
        ChamaTelaProcura("Codigo", "Descric�o", "", "SubGrupo", "Codigo", "SubGrupoDesc", "", True)
        Me.SubGrupo.Text = RetornoProcura
        If Me.SubGrupo.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.SubGrupo, Me.SubGrupoDesc, "SubGrupo", "Codigo", Me.SubGrupo.Text, "SubGrupoDesc", TrfGerais.TipoDados.Num�rico, True)
            Me.SubGrupo.Focus()
        End If

    End Sub

    Private Sub btMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMarca.Click
        RetornoProcura = ""
        ChamaTelaProcura("Codigo", "Descric�o", "", "Marcas", "Codigo", "Marca", "", True)
        Me.Marca.Text = RetornoProcura
        If Me.Marca.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.Marca, Me.MarcaDesc, "Marcas", "Codigo", Me.Marca.Text, "Marca", TrfGerais.TipoDados.Num�rico, True)
            Me.Marca.Focus()
        End If
    End Sub

    Private Sub btTipoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTipoGrupo.Click
        RetornoProcura = ""
        ChamaTelaProcura("Codigo", "Descric�o", "", "TipoGrupo", "Codigo", "TipoGrupoDesc", "", True)
        Me.TipoGrupo.Text = RetornoProcura
        If Me.TipoGrupo.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.TipoGrupo, Me.TipoGrupoDesc, "TipoGrupo", "Codigo", Me.TipoGrupo.Text, "TipoGrupoDesc", TrfGerais.TipoDados.Num�rico, True)
            Me.TipoGrupo.Focus()
        End If

    End Sub

    Private Sub btCor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCor.Click
        RetornoProcura = ""
        ChamaTelaProcura("Codigo", "Descric�o", "", "Cor", "Codigo", "CorDesc", "", True)
        Me.Cor.Text = RetornoProcura

        If Me.Cor.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.Cor, Me.CorDesc, "Cor", "Codigo", Me.Cor.Text, "CorDesc", TrfGerais.TipoDados.Num�rico, True)
            Me.Cor.Focus()
        End If

    End Sub

    Private Sub btRetiraImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRetiraImagem.Click


        Dim Conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Sql As String = "Delete * from ProdutosFoto where CodigoProduto = " & Me.CodigoProduto.Text

        Dim Cmd As New OleDb.OleDbCommand(Sql, Conn)

        Try

            Cmd.Connection.Open()
            Cmd.ExecuteNonQuery()
            Cmd.Connection.Close()
            Conn.Close()
            VisualizaFoto()
            MsgBox("Imagem Removida com sucesso !", 64, "Valida��o de Dados")

        Catch Ex As Exception
            MsgBox(Ex.Message, 64, "Valida��o de Dados")
        End Try

    End Sub

    Private Sub DescontoMaximo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DescontoMaximo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TabOpcoes.SelectedTab = Me.TabOutras
        End If
    End Sub

    Private Sub Referencia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Referencia.KeyDown
        If e.KeyCode = Keys.Return And Len(Me.Referencia.Text) = 0 Then
            Me.cEanTrib.Focus()
        End If
    End Sub


    Private Sub CodigoNFE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoNFE.Leave
        'Inserir ultimo registro
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT produtos.CodigoNFE, Produtos.CodigoProduto  FROM Produtos WHERE (((produtos.CodigoNFE)='" & Me.CodigoNFE.Text & "'));"
            .CommandType = CommandType.Text
        End With
        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If DataReader.HasRows Then
                    If Me.CodigoProduto.Text = DataReader.Item("CodigoProduto").ToString Then
                    Else
                        MsgBox("Esse c�digo j� foi cadastrado para um outro produto", 48, "Valida��o de dados")
                        Me.CodigoNFE.Clear()
                    End If
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try


    End Sub



    Private Sub EncheListaCOFINS()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select * from CofinsCST"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.cstCOFINSentr.DataSource = ds.Tables("Table").DefaultView
        Me.cstCOFINSentr.DisplayMember = "DescCSTcofins"
        Me.cstCOFINSentr.ValueMember = "CSTcofins"
        Me.cstCOFINSentr.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub


    Private Sub EncheListaPIS()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select * from PisCST"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.cstPISentr.DataSource = ds.Tables("Table").DefaultView
        Me.cstPISentr.DisplayMember = "DescCSTpis"
        Me.cstPISentr.ValueMember = "CSTpis"
        Me.cstPISentr.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheListaIPI()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select * from IpiCST"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.cstIPIentr.DataSource = ds.Tables("Table").DefaultView
        Me.cstIPIentr.DisplayMember = "DescCSTipi"
        Me.cstIPIentr.ValueMember = "CSTipi"
        Me.cstIPIentr.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheListaICMS()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select * from IcmsCST"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.icmsCSTEntr.DataSource = ds.Tables("Table").DefaultView
        Me.icmsCSTEntr.DisplayMember = "DescCSTicms"
        Me.icmsCSTEntr.ValueMember = "CSTicms"
        Me.icmsCSTEntr.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub


    Private Sub icmsCSTEntr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles icmsCSTEntr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.icmsCSTEntr.Text = "" Then Me.icmsCSTEntr.SelectedIndex = Me.icmsCSTEntr.FindStringExact("102�Tributada pelo Simples Nacional sem permiss�o de cr�dito")
        End If
    End Sub

    Private Sub cstIPIentr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstIPIentr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cstIPIentr.Text = "" Then Me.cstIPIentr.SelectedIndex = Me.cstIPIentr.FindStringExact("IPI 53 - Sa�da n�o-tributada")
        End If
    End Sub

    Private Sub cstPISentr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstPISentr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cstPISentr.Text = "" Then Me.cstPISentr.SelectedIndex = Me.cstPISentr.FindStringExact("Outras Opera��es")
        End If
    End Sub

    Private Sub cstCOFINSentr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cstCOFINSentr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.cstCOFINSentr.Text = "" Then Me.cstCOFINSentr.SelectedIndex = Me.cstCOFINSentr.FindStringExact("COFINS 99 - Outras Opera��es")
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class