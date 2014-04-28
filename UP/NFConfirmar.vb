Imports System.Drawing.Printing
Imports System.Data.OleDb
Imports Microsoft.Win32

Public Class NFConfirmar

    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private WithEvents PDoc As New PrintDocument()

    Private Sub MaterialParaImobilizado_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaterialParaImobilizado.Enter
        If Me.MaterialParaImobilizado.Text = "" Then Me.MaterialParaImobilizado.Text = "N"
    End Sub

    Private Sub MaterialParaImobilizado_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaterialParaImobilizado.Leave
        If Me.TotalIpi.Text = "" Then Me.TotalIpi.Text = FormatCurrency(0, 2)
        If Me.MaterialParaImobilizado.Text = "S" Then
            If DescontoEmLinha = True Then
                Me.BaseCalcIcms.Text = FormatNumber(CDbl(My.Forms.NFiscal.TotalProdutos.Text) + CDbl(Me.TotalIpi.Text), 2)
            Else
                Me.BaseCalcIcms.Text = FormatNumber(CDbl(My.Forms.NFiscal.TotalProdutos.Text) - CDbl(My.Forms.NFiscal.Desconto.Text) + CDbl(Me.TotalIpi.Text), 2)
            End If
        Else
            If DescontoEmLinha = True Then
                Me.BaseCalcIcms.Text = FormatNumber(CDbl(My.Forms.NFiscal.TotalProdutos.Text), 2)
            Else
                Me.BaseCalcIcms.Text = FormatNumber(CDbl(My.Forms.NFiscal.TotalProdutos.Text) - CDbl(My.Forms.NFiscal.Desconto.Text), 2)
            End If
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        CNN.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Obs_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Obs.Enter
        If Me.Mensagem.Text <> "" Then
            If Me.Mensagem.Text = 1 Then
                Me.Obs.Text = "Ipi com Aliq. reduz. a zero por Intermédio do dec. lei n.649 - 11/09/92"
            End If
            If Me.Mensagem.Text = 2 Then
                Me.Obs.Text = "Isento de Ipi conf. dec. lei n. 551/92"
            End If
            If Me.Mensagem.Text = 3 Then
                Me.Obs.Text = "Conforme Substituição Tributaria, Decreto nº 10.100 de 10/2000."
            End If
            If Me.Mensagem.Text = 4 Then
                Me.Obs.Text = "Icms Retido por substituição tributaria, conf. dec. 10.907 anexo 003 art. 24-II"
            End If
            If Me.Mensagem.Text = 5 Then
                Me.Obs.Text = "AGRICOLAS PECUARIOS OU AGROPECUARIOS" & vbNewLine & "ISENTO DE ICMS CONF. ANEXO 1 ART" & vbNewLine & "DECRETO 10 741/2002 - DESTE. A. ESTB"
            End If
        End If
    End Sub

    Private Sub Icms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Icms.Enter
        If Me.Icms.Text = "" Then Me.Icms.Text = "17"
    End Sub

    Private Sub ValorIcms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorIcms.Enter
        If Me.BaseCalcIcms.Text = "" Then Me.BaseCalcIcms.Text = FormatNumber(0, 2)
        If Me.Icms.Text = "" Then Me.Icms.Text = 0

        Me.ValorIcms.Text = FormatNumber(CDbl(Me.BaseCalcIcms.Text) * CDbl(Me.Icms.Text) / 100, 2)

    End Sub

    Private Sub IsentoIcms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles IsentoIcms.Enter
        Me.IsentoIcms.Text = FormatNumber(0, 2)
    End Sub

    Private Sub ValorOutrosIcms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorOutrosIcms.Enter
        Me.ValorOutrosIcms.Text = CDbl(My.Forms.NFiscal.TotalNota.Text) - CDbl(Me.BaseCalcIcms.Text)
    End Sub

    Private Sub BaseCalcIpi_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BaseCalcIpi.Enter
        Me.TotalIpi.Text = FormatNumber(My.Forms.NFiscal.TTIPI.Text, 2)
        Me.BaseCalcIpi.Text = (CDbl(Me.TotalIpi.Text) * 100) / 5
    End Sub

    Private Sub IsentoIpi_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles IsentoIpi.Enter
        If Mid(My.Forms.NFiscal.CFOP.Text, 5, 1) = "2" Or Mid(My.Forms.NFiscal.CFOP.Text, 5, 1) = "9" Then
            Me.IsentoIpi.Text = CDbl(0)
            Exit Sub
        End If

        If IsentaDeIpi = False Then
            If Me.BaseCalcIpi.Text <> 0 Then
                Me.IsentoIpi.Text = CDbl(My.Forms.NFiscal.TotalNota.Text) - CDbl(Me.TotalIpi.Text) - CDbl(Me.BaseCalcIpi.Text)
            End If

            If Me.BaseCalcIpi.Text = 0 Then
                Me.IsentoIpi.Text = CDbl(My.Forms.NFiscal.TotalNota.Text)
            End If
        Else
            Me.IsentoIpi.Text = CDbl(My.Forms.NFiscal.TotalNota.Text)
        End If

    End Sub

    Private Sub ValorOutrosIpi_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorOutrosIpi.Enter
        If Mid(My.Forms.NFiscal.CFOP.Text, 5, 1) = "2" Or Mid(My.Forms.NFiscal.CFOP.Text, 5, 1) = "9" Then
            Me.ValorOutrosIpi.Text = CDbl(My.Forms.NFiscal.TotalNota.Text)
            Exit Sub
        End If

        If IsentaDeIpi = False Then
            If Me.BaseCalcIpi.Text = 0 And Me.TotalIpi.Text = 0 Then
                Me.ValorOutrosIpi.Text = CDbl(0)
            Else
                Me.ValorOutrosIpi.Text = CDbl(0)
            End If
        Else
            Me.ValorOutrosIpi.Text = CDbl(0)
        End If
    End Sub

    Private Sub NFConfirmar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CNN.Open()
    End Sub

    Private Sub btSalvarImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarImprimir.Click
        If Me.MaterialParaImobilizado.Text = "" Then
            MsgBox("O Usuário deve informar se a Nota é Imobilizado ou Não.", 64, "Validação de Dados")
            Me.MaterialParaImobilizado.Focus()
            Exit Sub
        ElseIf Me.Icms.Text = "" Then
            MsgBox("O Usuário deve informar a aliquota do ICMS.", 64, "Validação de Dados")
            Me.Icms.Focus()
            Exit Sub
        ElseIf Me.BaseCalcIcms.Text = "" Then
            MsgBox("O Usuário deve informar a Base de Calculo do ICMS.", 64, "Validação de Dados")
            Me.BaseCalcIcms.Focus()
            Exit Sub
        ElseIf Me.ValorIcms.Text = "" Then
            MsgBox("O Usuário deve informar o Valor do ICMS.", 64, "Validação de Dados")
            Me.ValorIcms.Focus()
            Exit Sub
        ElseIf Me.IsentoIcms.Text = "" Then
            MsgBox("O Usuário deve informar o valor isento do ICMS.", 64, "Validação de Dados")
            Me.IsentoIcms.Focus()
            Exit Sub
        ElseIf Me.ValorOutrosIcms.Text = "" Then
            MsgBox("O Usuário deve informar o valor de Outros do ICMS.", 64, "Validação de Dados")
            Me.ValorOutrosIcms.Focus()
            Exit Sub
        ElseIf Me.BaseCalcIpi.Text = "" Then
            MsgBox("O Usuário deve informar a Base de Calculo do IPI.", 64, "Validação de Dados")
            Me.BaseCalcIpi.Focus()
            Exit Sub
        ElseIf Me.TotalIpi.Text = "" Then
            MsgBox("O Usuário deve informar o valor do IPI.", 64, "Validação de Dados")
            Me.TotalIpi.Focus()
            Exit Sub
        ElseIf Me.IsentoIpi.Text = "" Then
            MsgBox("O Usuário deve informar o valor de Isento do IPI.", 64, "Validação de Dados")
            Me.IsentoIcms.Focus()
            Exit Sub
        ElseIf Me.ValorOutrosIpi.Text = "" Then
            MsgBox("O Usuário deve informar o valor de Outros do IPI.", 64, "Validação de Dados")
            Me.ValorOutrosIpi.Focus()
            Exit Sub
        End If

        If Me.FormaPagamento.Text = "" Then
            MsgBox("O usuário deve informar a forma de pagamento.", 64, "Validação de Dados")
            Me.FormaPagamento.Focus()
            Exit Sub
        End If

        If Me.Transportadora.Text = "" Then Me.Transportadora.Text = 0


        Dim Sql As String = "Update NotaFiscal set NotaFiscal = @1, Pedido = @2, CFOP = @3, Cliente = @4, Propriedade = @5, Cnpj = @6, Incrição = @7, DataEmissao = @8, DataSaida = @9, Modelo = @10, Serie = @11, Empresa = @12, MaterialParaImobilizado = @13, Icms = @14, BaseCalcIcms = @15, ValorIcms = @16, IsentoIcms = @17, ValorOutrosIcms = @18, BaseCalcIpi = @19, TotalIpi = @20, IsentoIpi = @21, ValorOutrosIpi = @22, Transportadora = @23, PlacaVeiculo = @24, FreteContaDo = @25, FormaPagamento = @26, ObsCupon = @27, Obs = @28, Uf = @29, Situaçao = @30, Comfirmado = @31, TotalProdutos = @32,  TotalNota = @33, Desconto = @34, DescriçãoServiço = @35, ValorServiço = @36, AliquotaIss = @37, ValorIss = @38, ValorInss = @39, ReterImpostosServiço = @40 Where NotaFiscal = " & My.Forms.NFiscal.NotaFiscal.Text

        Dim Transacao As OleDbTransaction = CNN.BeginTransaction()
        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)

        Cmd.Transaction = Transacao


        Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.NFiscal.NotaFiscal.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.NFiscal.Pedido.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(My.Forms.NFiscal.CFOP.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(My.Forms.NFiscal.Cliente.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", RetornaValorComboBox(My.Forms.NFiscal.Propriedade)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(My.Forms.NFiscal.Cnpj.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(My.Forms.NFiscal.Incrição.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(My.Forms.NFiscal.DataEmissao.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(My.Forms.NFiscal.DataSaida.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(My.Forms.NFiscal.Modelo.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(My.Forms.NFiscal.Serie.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.MaterialParaImobilizado.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Icms.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.BaseCalcIcms.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.ValorIcms.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.IsentoIcms.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ValorOutrosIcms.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.BaseCalcIpi.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.TotalIpi.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.IsentoIpi.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.ValorOutrosIpi.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.Transportadora.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.PlacaVeiculo.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.FreteContaDo.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.FormaPagamento.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.ObsCupon.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.Obs.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(My.Forms.NFiscal.UF.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@30", "E"))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@31", True))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(My.Forms.NFiscal.TotalProdutos.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(My.Forms.NFiscal.TotalNota.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(My.Forms.NFiscal.Desconto.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(My.Forms.NFiscal.DescriçãoServiço.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(My.Forms.NFiscal.ValorServiço.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(My.Forms.NFiscal.AliquotaIss.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(My.Forms.NFiscal.ValorIss.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(My.Forms.NFiscal.ValorInss.Text, 1)))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(My.Forms.NFiscal.ReterImpostosServiço.Text, 1)))

        Try
            Cmd.ExecuteNonQuery()


            Transacao.Commit()

            MsgBox("Nota Fiscal Salva e confirmada.", 64, "Validação de Dados")
            My.Forms.NFiscal.Comfirmado.Checked = True

        Catch x As Exception
            Transacao.Rollback()
            MsgBox(x.Message, 64, "Validação de Dados")
            MsgBox("Erro ao confirmar a Nota Fiscal, tente novamente confirmar ou consulte o administrador.", 64, "Validação de Dados")
            Exit Sub
        End Try

        'preparar para Impressão da NotaFiscal
        ColocarNumeroNF() 'coloca no contas a receber o numeros da nota fiscal
        ImprimirNf()

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Transportadora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Transportadora.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            ChamaTelaProcura("Codigo", "Razão Social", "", "Transportadora", "Codigo", "RazãoTransportadora", "", True)
            Me.Transportadora.Text = RetornoProcura
        End If
    End Sub

    Private Sub FormaPagamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FormaPagamento.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ObsCupon.Focus()
        End If
    End Sub

#Region "Impressão da Nota Fiscal"

    Public Sub ImprimirNf()


        Dim Key As RegistryKey = Registry.LocalMachine
        Dim PegaKey As RegistryKey = Key.OpenSubKey("Software\\E-FocusNF\\Conf")

        Try
            NomeFormulario = PegaKey.GetValue("FormPadrao", ".")
            ImpressPadrão = PegaKey.GetValue("ImpressNf", 0)

            If NomeFormulario = "." Then
                MsgBox("Não existe formulario padrão, favor definir.", 64, "Validação de Dados")
            End If
        Catch
            MsgBox("Não existe configuração definida, favor verificar", 64, "Exportação de Dados")
        End Try

        ' Dim ppd As New PrintPreviewDialog()

        Try
            'ppd.Document = PDoc

            With PDoc.DefaultPageSettings
                .Landscape = False
                '.PaperSize = Papel
                .Margins.Bottom = 0
                .Margins.Left = 0
                .Margins.Right = 0
                .Margins.Top = 0
            End With

            'ppd.WindowState = FormWindowState.Maximized
            'ppd.PrintPreviewControl.Zoom = 1
            'ppd.Text = "Impressão de Nota Fiscal"

            'ppd.ShowDialog()
            PDoc.PrinterSettings.PrinterName = ImpressPadrão
            If PDoc.PrinterSettings.IsValid Then
                PDoc.Print()
            Else
                MsgBox("Impressora invalida")
            End If

        Catch exp As Exception
            MsgBox("Erro ao carregar a impressão", 64, "Impressão de Nota Fiscal")
        End Try

    End Sub

    Private Sub PDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDoc.PrintPage
        'PDoc.PrintController.OnStartPrint(e)
        'Environment.CommandLine 
        'Abertura de Banco de Dados para fazer o posicionamento das informações

        ' If CmdLine = "" Then
        ' MsgBox("O usuário deve definir primeiro o numero da nota fiscal a ser impresso.", 64, "Impressão de Nf")
        ' Exit Sub
        ' End If


        'dados da Nf
        Dim Sql As String = "Select * from NotaFiscal where NotaFiscal = " & My.Forms.NFiscal.NotaFiscal.Text
        Dim CMD As New OleDbCommand(Sql, CNN)
        Dim DR As OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Dim STRNF As String = DR.Item("NotaFiscal") & ""
        Dim STRCfop As String = DR.Item("CFOP") & ""
        Dim STRCliente As String = DR.Item("Cliente") & ""
        Dim StrEmissao As String = DR.Item("DataEmissao") & ""
        Dim StrSaida As String = DR.Item("DataSaida") & ""
        Dim StrBaseIcms As String = FormatNumber(Nz(DR.Item("BaseCalcIcms"), 3), 2)
        Dim StrVlrIcms As String = FormatNumber(Nz(DR.Item("ValorIcms"), 3), 2)
        Dim StrDesconto As String = FormatNumber(Nz(DR.Item("Desconto"), 3), 2)

        Dim StrTotPord As String = ""

        If DescontoEmLinha = True Then
            StrTotPord = FormatNumber(Nz(DR.Item("TotalProdutos"), 3), 2)
        Else
            StrTotPord = FormatNumber(Nz(DR.Item("TotalProdutos"), 3) - Nz(DR.Item("Desconto"), 3), 2)
        End If

        Dim StrTotIpi As String = FormatNumber(Nz(DR.Item("TotalIpi"), 3), 2)
        Dim StrTotNota As String = FormatNumber(Nz(DR.Item("TotalNota"), 3), 2)
        Dim StrObs As String = DR.Item("Obs") & ""
        Dim StrTransp As String = DR.Item("Transportadora") & ""
        Dim StrUsarDescrição As Boolean = DR.Item("UsarDescricao")
        Dim StrPropriedade As String = DR.Item("Propriedade")
        Dim StrPedido As String = DR.Item("Pedido")
        Dim StrCupom As String = DR.Item("ObsCupon") & ""
        Dim StrIcmsGeral As String = DR.Item("Icms") & ""

        Dim StrServiço As String = DR.Item("DescriçãoServiço") & ""
        Dim StrAliquotaIss As String = DR.Item("AliquotaIss") & ""
        Dim StrValorIss As String = FormatNumber(Nz(DR.Item("ValorIss"), 3), 2)
        Dim StrValorServiço As String = FormatNumber(Nz(DR.Item("ValorServiço"), 3), 2)

        Dim Plc As String = DR.Item("PlacaVeiculo") & ""
        Dim Frt As String = DR.Item("FreteContaDo") & ""

        DR.Close()

        'Dados do Cliente
        Sql = "Select * from Clientes where Codigo = " & STRCliente
        CMD.CommandText = Sql
        DR = CMD.ExecuteReader

        Dim StrNome As String = ""
        Dim StrCpf As String = ""
        Dim StrEnde As String = ""
        Dim StrBair As String = ""
        Dim StrCep As String = ""
        Dim StrCida As String = ""
        Dim StrFone As String = ""
        Dim StrInsc As String = ""

        If DR.Read() Then
            StrNome = DR.Item("Nome") & ""
            StrCpf = DR.Item("CpfCgc") & ""
            StrEnde = DR.Item("Endereço") & ", " & DR.Item("Nro") & ""
            StrBair = DR.Item("Bairro") & ""
            StrCep = DR.Item("Cep") & ""
            StrCida = DR.Item("Cidade") & " - " & DR.Item("Estado") & ""
            StrFone = DR.Item("Telefone") & ""
            StrInsc = DR.Item("Insc") & ""
        End If
        DR.Close()

        If StrPropriedade <> "" Or StrPropriedade <> "0" Then
            Sql = "Select * from Propriedades where Id = " & StrPropriedade
            CMD.CommandText = Sql
            DR = CMD.ExecuteReader
            If DR.Read() Then
                StrEnde = DR.Item("NomePropriedade") & ""
                StrBair = ""
                StrCep = DR.Item("Cep") & ""
                StrCida = DR.Item("Cidade") & " - " & DR.Item("Estado") & ""
                StrFone = DR.Item("Fone") & ""
                StrInsc = DR.Item("Inscricao") & ""
            End If
            DR.Close()
        End If

        'fim dos dados de clientes

        'Dados do Cfop
        Sql = "Select * from CFOP where CFOP = '" & STRCfop & "'"
        CMD.CommandText = Sql
        DR = CMD.ExecuteReader

        Dim StrCfopDesc As String = ""
        If DR.Read() Then
            StrCfopDesc = DR.Item("Descrição") & ""
        End If
        DR.Close()
        'Fim dos Dados de cfop

        'Dados da transportadora
        Sql = "Select * from Transportadora where Codigo = " & StrTransp
        CMD.CommandText = Sql
        DR = CMD.ExecuteReader

        Dim StrNomeTransp As String = ""
        Dim StrEndeTransp As String = ""
        Dim StrCidaTransp As String = ""
        Dim StrUfTransp As String = ""
        Dim StrInscTransp As String = ""

        If DR.Read() Then
            StrNomeTransp = DR.Item("RazãoTransportadora") & ""
            StrEndeTransp = DR.Item("Endereço") & ""
            StrCidaTransp = DR.Item("Cidade") & ""
            StrUfTransp = DR.Item("Uf") & ""
            StrInscTransp = DR.Item("Incricao") & ""
        End If
        DR.Close()
        'fim dos dados da transportadora

        'Dados de posições da Nota 
        Sql = "Select * from ConfNfSystem where NomeForms = '" & NomeFormulario & "'"
        CMD.CommandText = Sql
        Try
            DR = CMD.ExecuteReader
            DR.Read()

        Catch px As Exception
            MsgBox("Não foi possiver ler o banco de dados de posições", 64, "Validação de Dados")
            Exit Sub
        End Try

        'INICIO DA VARIAVEIS DE POSIÇÃO
        Dim EntradaSaida_X As Integer = DR.Item("EntradaSaida_X") & ""
        Dim EntradaSaida_Y As Integer = DR.Item("EntradaSaida_Y") & ""
        Dim NumeroNf_X As Integer = DR.Item("NumeroNf_X") & ""
        Dim NumeroNf_Y As Integer = DR.Item("NumeroNf_Y") & ""
        Dim CfopDesc_X As Integer = DR.Item("CfopDesc_X") & ""
        Dim CfopDesc_Y As Integer = DR.Item("CfopDesc_Y") & ""
        Dim Cfop_X As Integer = DR.Item("Cfop_X") & ""
        Dim Cfop_Y As Integer = DR.Item("Cfop_Y") & ""
        Dim Nome_X As Integer = DR.Item("Nome_X") & ""
        Dim Nome_Y As Integer = DR.Item("Nome_Y") & ""
        Dim Cnpj_X As Integer = DR.Item("Cnpj_X") & ""
        Dim Cnpj_Y As Integer = DR.Item("CnpJ_Y") & ""
        Dim DataEmissao_X As Integer = DR.Item("DataEmissao_X") & ""
        Dim DataEmissao_Y As Integer = DR.Item("DataEmissao_Y") & ""
        Dim Endereco_X As Integer = DR.Item("Endereco_X") & ""
        Dim Endereco_Y As Integer = DR.Item("Endereco_Y") & ""
        Dim Bairro_X As Integer = DR.Item("Bairro_X") & ""
        Dim Bairro_Y As Integer = DR.Item("Bairro_Y") & ""
        Dim Cep_X As Integer = DR.Item("Cep_X") & ""
        Dim Cep_Y As Integer = DR.Item("Cep_Y") & ""
        Dim DataSaida_X As Integer = DR.Item("DataSaida_X") & ""
        Dim DataSaida_Y As Integer = DR.Item("DataSaida_Y") & ""
        Dim Cidade_X As Integer = DR.Item("Cidade_X") & ""
        Dim Cidade_Y As Integer = DR.Item("Cidade_Y") & ""
        Dim Fone_X As Integer = DR.Item("Fone_X") & ""
        Dim Fone_Y As Integer = DR.Item("Fone_Y") & ""
        Dim Inscricao_X As Integer = DR.Item("Inscricao_X") & ""
        Dim Inscricao_Y As Integer = DR.Item("Inscricao_Y") & ""
        Dim HoraSaida_X As Integer = DR.Item("HoraSaida_X") & ""
        Dim HoraSaida_Y As Integer = DR.Item("HoraSaida_Y") & ""
        Dim Dp1Posição_X As Integer = DR.Item("Dp1Posição_X") & ""
        Dim Dp1Posição_Y As Integer = DR.Item("Dp1Posição_Y") & ""
        Dim Dp2Posição_X As Integer = DR.Item("Dp2Posição_X") & ""
        Dim Dp2Posição_Y As Integer = DR.Item("Dp2Posição_Y") & ""
        Dim Dp3Posição_X As Integer = DR.Item("Dp3Posição_X") & ""
        Dim Dp3Posição_Y As Integer = DR.Item("Dp3Posição_Y") & ""
        Dim DescItens_X As Integer = DR.Item("DescItens_X") & ""
        Dim DescItens_Y As Integer = DR.Item("DescItens_Y") & ""
        Dim Cf_X As Integer = DR.Item("Cf_X") & ""
        Dim Cf_Y As Integer = DR.Item("Cf_Y") & ""
        Dim St_X As Integer = DR.Item("St_X") & ""
        Dim St_Y As Integer = DR.Item("St_Y") & ""
        Dim Unid_X As Integer = DR.Item("Unid_X") & ""
        Dim Unid_Y As Integer = DR.Item("Unid_Y") & ""
        Dim Qtd_X As Integer = DR.Item("Qtd_X") & ""
        Dim Qtd_Y As Integer = DR.Item("Qtd_Y") & ""
        Dim Unitario_X As Integer = DR.Item("Unitario_X") & ""
        Dim Unitario_Y As Integer = DR.Item("Unitario_Y") & ""
        Dim Total_X As Integer = DR.Item("Total_X") & ""
        Dim Total_Y As Integer = DR.Item("Total_Y") & ""
        Dim Icms_X As Integer = DR.Item("Icms_X") & ""
        Dim Icms_Y As Integer = DR.Item("Icms_Y") & ""
        Dim Ipi_X As Integer = DR.Item("Ipi_X") & ""
        Dim Ipi_Y As Integer = DR.Item("Ipi_Y") & ""
        Dim ValorIpi_X As Integer = DR.Item("ValorIpi_X") & ""
        Dim ValorIpi_Y As Integer = DR.Item("ValorIpi_Y") & ""
        Dim BaseCalcIcms_X As Integer = DR.Item("BaseCalcIcms_X") & ""
        Dim BaseCalcIcms_Y As Integer = DR.Item("BaseCalcIcms_Y") & ""
        Dim ValorIcms_X As Integer = DR.Item("ValorIcms_X") & ""
        Dim ValorIcms_Y As Integer = DR.Item("ValorIcms_Y") & ""
        Dim TotalProdutos_X As Integer = DR.Item("TotalProdutos_X") & ""
        Dim TotalProdutos_Y As Integer = DR.Item("TotalProdutos_Y") & ""
        Dim TotalIpi_X As Integer = DR.Item("TotalIpi_X") & ""
        Dim TotalIpi_Y As Integer = DR.Item("TotalIpi_Y") & ""
        Dim TotalNota_X As Integer = DR.Item("TotalNota_X") & ""
        Dim TotalNota_Y As Integer = DR.Item("TotalNota_Y") & ""
        Dim Transportadora_X As Integer = DR.Item("Transportadora_X") & ""
        Dim Transportadora_Y As Integer = DR.Item("Transportadora_Y") & ""
        Dim EndTransportadora_X As Integer = DR.Item("EndTransportadora_X") & ""
        Dim EndTransportadora_Y As Integer = DR.Item("EndTransportadora_Y") & ""
        Dim CidadeTransportador_X As Integer = DR.Item("CidadeTransportador_X") & ""
        Dim CidadeTransportador_Y As Integer = DR.Item("CidadeTransportador_Y") & ""
        Dim UfTransportadora_X As Integer = DR.Item("UfTransportadora_X") & ""
        Dim UfTransportadora_Y As Integer = DR.Item("UfTransportadora_Y") & ""
        Dim IncricaoTransportadora_X As Integer = DR.Item("IncricaoTransportadora_X") & ""
        Dim IncricaoTransportadora_Y As Integer = DR.Item("IncricaoTransportadora_Y") & ""
        Dim Observacao_X As Integer = DR.Item("Observacao_X") & ""
        Dim Observacao_Y As Integer = DR.Item("Observacao_Y") & ""
        Dim NumeroNota2_X As Integer = DR.Item("NumeroNota2_X") & ""
        Dim NumeroNota2_Y As Integer = DR.Item("NumeroNota2_Y") & ""
        Dim Desconto_X As Integer = DR.Item("Desconto_X") & ""
        Dim Desconto_Y As Integer = DR.Item("Desconto_Y") & ""
        Dim FFonte As String = DR.Item("NomeFonte") & ""
        Dim TFonte As Integer = DR.Item("TamanhoFonte") & ""
        Dim ImprimirDp As String = DR.Item("ImpressDp") & ""
        Dim PosInicialProdutos As Integer = DR.Item("DescItens_Y") & ""
        Dim CasaDecimaisQtd As Integer = DR.Item("CasaDecimaisQtd") & ""
        Dim CasaDecimaisValores As Integer = DR.Item("CasaDecimaisValores") & ""

        Dim Serviço_X As Integer = DR.Item("Serviço_X") & ""
        Dim Serviço_Y As Integer = DR.Item("Serviço_Y") & ""
        Dim AliquotaIss_X As Integer = DR.Item("AliquotaIss_X") & ""
        Dim AliquotaIss_Y As Integer = DR.Item("AliquotaIss_Y") & ""
        Dim ValorIss_X As Integer = DR.Item("ValorIss_X") & ""
        Dim ValorIss_Y As Integer = DR.Item("ValorIss_Y") & ""
        Dim ValorServiço_X As Integer = DR.Item("ValorServiço_X") & ""
        Dim ValorServiço_Y As Integer = DR.Item("ValorServiço_Y") & ""

        Dim StrImprimirServiço As String = DR.Item("ImprimirServiço") & ""

        Dim PlacaVeiculoX As String = DR.Item("PlacaTransportadora_X") & ""
        Dim PlacaVeiculoY As String = DR.Item("PlacaTransportadora_Y") & ""

        Dim FreteX As String = DR.Item("FreteContaDe_X") & ""
        Dim FreteY As String = DR.Item("FreteContaDe_Y") & ""


        'FIM DA VARIAVEIS DE POSIÇÕES

        DR.Close()
        'e.Graphics.PageUnit = GraphicsUnit.Millimeter

        Dim PosVertical As Single = 0
        Dim Contador As Integer = 0
        Dim LinhasPorPagina As Single = 0
        Dim LinhaAtual As Integer = 0
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)

        Dim G As Graphics = e.Graphics
        Dim F As New Font(FFonte, TFonte, System.Drawing.GraphicsUnit.Point)

        'Entrada/Saida
        G.DrawString("X", F, Brushes.Black, EntradaSaida_X, EntradaSaida_Y, New StringFormat())
        'Fim

        'NumeroNf_X 
        G.DrawString(STRNF, F, Brushes.Black, NumeroNf_X, NumeroNf_Y, New StringFormat())
        'Fim

        'CfopDesc_X 
        G.DrawString(StrCfopDesc, F, Brushes.Black, CfopDesc_X, CfopDesc_Y, New StringFormat())
        'Fim

        'Cfop_X 
        G.DrawString(STRCfop, F, Brushes.Black, Cfop_X, Cfop_Y, New StringFormat())
        'Fim

        'Nome_X 
        G.DrawString(StrNome, F, Brushes.Black, Nome_X, Nome_Y, New StringFormat())
        'Fim

        'Cnpj_X 
        G.DrawString(StrCpf, F, Brushes.Black, Cnpj_X, Cnpj_Y, New StringFormat())
        'Fim

        'DataEmissao_X 
        G.DrawString(StrEmissao, F, Brushes.Black, DataEmissao_X, DataEmissao_Y, New StringFormat())
        'Fim

        'Endereco_X 
        G.DrawString(StrEnde, F, Brushes.Black, Endereco_X, Endereco_Y, New StringFormat())
        'Fim

        'Bairro_X 
        G.DrawString(StrBair, F, Brushes.Black, Bairro_X, Bairro_Y, New StringFormat())
        'Fim

        'Cep_X 
        G.DrawString(StrCep, F, Brushes.Black, Cep_X, Cep_Y, New StringFormat())
        'Fim

        'DataSaida_X 
        G.DrawString(StrSaida, F, Brushes.Black, DataSaida_X, DataSaida_Y, New StringFormat())
        'Fim

        'Cidade_X 
        G.DrawString(StrCida, F, Brushes.Black, Cidade_X, Cidade_Y, New StringFormat())
        'Fim

        'Fone_X 
        G.DrawString(StrFone, F, Brushes.Black, Fone_X, Fone_Y, New StringFormat())
        'Fim

        'Inscricao_X 
        G.DrawString(StrInsc, F, Brushes.Black, Inscricao_X, Inscricao_Y, New StringFormat())
        'Fim

        'HoraSaida_X 
        G.DrawString("", F, Brushes.Black, HoraSaida_X, HoraSaida_Y, New StringFormat())
        'Fim

        'Area destinadas a duplicatas
        If ImprimirDp = "S" Then

            Dim FonteReceber As New Font(FFonte, 8, System.Drawing.GraphicsUnit.Point)

            If StrPedido <> 0 Then
                Sql = "Select * from Receber where PedidoProdutos = " & StrPedido & " and Empresa = " & CodEmpresa
                CMD.CommandText = Sql
                DR = CMD.ExecuteReader

                Dim ContReceber As Integer = 1
                Dim PosInicialReceber = Dp1Posição_Y
                While DR.Read
                    Select Case ContReceber
                        Case 1
                            G.DrawString(DR.Item("Documento"), FonteReceber, Brushes.Black, Dp1Posição_X, PosInicialReceber, New StringFormat())
                            G.DrawString(DR.Item("Vencimento"), FonteReceber, Brushes.Black, Dp1Posição_X + 60, PosInicialReceber, New StringFormat())
                            G.DrawString(FormatNumber(DR.Item("ValorDocumento"), CasaDecimaisValores), FonteReceber, Brushes.Black, Dp1Posição_X + 150, PosInicialReceber, New StringFormat())
                        Case 2
                            G.DrawString(DR.Item("Documento"), FonteReceber, Brushes.Black, Dp2Posição_X, PosInicialReceber, New StringFormat())
                            G.DrawString(DR.Item("Vencimento"), FonteReceber, Brushes.Black, Dp2Posição_X + 60, PosInicialReceber, New StringFormat())
                            G.DrawString(FormatNumber(DR.Item("ValorDocumento"), CasaDecimaisValores), FonteReceber, Brushes.Black, Dp2Posição_X + 150, PosInicialReceber, New StringFormat())
                        Case 3
                            G.DrawString(DR.Item("Documento"), FonteReceber, Brushes.Black, Dp3Posição_X, PosInicialReceber, New StringFormat())
                            G.DrawString(DR.Item("Vencimento"), FonteReceber, Brushes.Black, Dp3Posição_X + 60, PosInicialReceber, New StringFormat())
                            G.DrawString(FormatNumber(DR.Item("ValorDocumento"), CasaDecimaisValores), FonteReceber, Brushes.Black, Dp3Posição_X + 150, PosInicialReceber, New StringFormat())
                        Case 4
                            PosInicialReceber += F.GetHeight(e.Graphics)
                            G.DrawString(DR.Item("Documento"), FonteReceber, Brushes.Black, Dp1Posição_X, PosInicialReceber, New StringFormat())
                            G.DrawString(DR.Item("Vencimento"), FonteReceber, Brushes.Black, Dp1Posição_X + 60, PosInicialReceber, New StringFormat())
                            G.DrawString(FormatNumber(DR.Item("ValorDocumento"), CasaDecimaisValores), FonteReceber, Brushes.Black, Dp1Posição_X + 150, PosInicialReceber, New StringFormat())
                        Case 5
                            G.DrawString(DR.Item("Documento"), FonteReceber, Brushes.Black, Dp2Posição_X, PosInicialReceber, New StringFormat())
                            G.DrawString(DR.Item("Vencimento"), FonteReceber, Brushes.Black, Dp2Posição_X + 60, PosInicialReceber, New StringFormat())
                            G.DrawString(FormatNumber(DR.Item("ValorDocumento"), CasaDecimaisValores), FonteReceber, Brushes.Black, Dp2Posição_X + 150, PosInicialReceber, New StringFormat())
                        Case 6
                            G.DrawString(DR.Item("Documento"), FonteReceber, Brushes.Black, Dp3Posição_X, PosInicialReceber, New StringFormat())
                            G.DrawString(DR.Item("Vencimento"), FonteReceber, Brushes.Black, Dp3Posição_X + 60, PosInicialReceber, New StringFormat())
                            G.DrawString(FormatNumber(DR.Item("ValorDocumento"), CasaDecimaisValores), FonteReceber, Brushes.Black, Dp3Posição_X + 150, PosInicialReceber, New StringFormat())
                    End Select
                    ContReceber += 1
                End While
            End If
        End If
        DR.Close()
        'fim da area destinada a duplicatas

        'Itens
        Sql = "SELECT NotaFiscalItens.Id, NotaFiscalItens.NotaFiscal, NotaFiscalItens.Produto, Produtos.Descrição, Produtos.UnidadeMedida, NotaFiscalItens.Qtd, NotaFiscalItens.Unitario, NotaFiscalItens.ValorTotal, NotaFiscalItens.Icms, NotaFiscalItens.ValorIcms, NotaFiscalItens.Ipi, NotaFiscalItens.ValorIpi, NotaFiscalItens.Cst, NotaFiscalItens.Cf, NotaFiscalItens.ValorDesconto, * FROM Produtos INNER JOIN NotaFiscalItens ON Produtos.CodigoProduto = NotaFiscalItens.Produto WHERE NotaFiscalItens.NotaFiscal = " & STRNF


        CMD.CommandText = Sql
        DR = CMD.ExecuteReader

        While DR.Read

            Dim StrProd As String = DR.Item("Produto") & ""
            Dim StrProduto As String = DR.Item("Descrição") & ""
            Dim StrQtd As String = FormatNumber(Nz(DR.Item("Qtd"), 3), CasaDecimaisQtd)
            Dim StrUnitario As String = FormatNumber(NzZero(DR.Item("ValorTotal")) / StrQtd, CasaDecimaisValores) ' FormatNumber(Nz(DR.Item("Unitario"), 3), CasaDecimaisValores)
            Dim StrValorTotal As String = FormatNumber(Nz(DR.Item("ValorTotal"), 3), CasaDecimaisValores)
            Dim StrIcms As String = DR.Item("NotaFiscalItens.Icms") & ""
            Dim StrIpi As String = DR.Item("NotaFiscalItens.Ipi") & ""
            Dim StrVlrIpi As String = FormatNumber(Nz(DR.Item("ValorIpi"), 3), CasaDecimaisValores)
            Dim StrCf As String = "0" & DR.Item("NotaFiscalItens.Cf") & ""
            Dim StrCst As String = DR.Item("NotaFiscalItens.Cst") & ""
            Dim StrUM As String = DR.Item("UnidadeMedida") & ""

            G.DrawString(StrProduto, F, Brushes.Black, DescItens_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrCf, F, Brushes.Black, Cf_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrCst, F, Brushes.Black, St_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrUM, F, Brushes.Black, Unid_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrQtd, F, Brushes.Black, Qtd_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrUnitario, F, Brushes.Black, Unitario_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrValorTotal, F, Brushes.Black, Total_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrIcms, F, Brushes.Black, Icms_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrIpi, F, Brushes.Black, Ipi_X, PosInicialProdutos, New StringFormat())
            G.DrawString(StrVlrIpi, F, Brushes.Black, ValorIpi_X, PosInicialProdutos, New StringFormat())
            PosInicialProdutos += F.GetHeight(e.Graphics)
        End While
        'fim dos Itens

        'Desconto_X 
        Dim DescontoImpress As String
        DescontoImpress = "Desconto....................: " & StrDesconto
        G.DrawString(DescontoImpress, F, Brushes.Black, Desconto_X, Desconto_Y, New StringFormat())        'Fim

        'Fim

        Try
            If StrImprimirServiço = "S" Then
                'Area de Serviços
                'Serviço_X 
                G.DrawString(StrServiço, F, Brushes.Black, Serviço_X, Serviço_Y, New StringFormat())
                'Fim

                'AliquotaIss_X 
                G.DrawString(StrAliquotaIss, F, Brushes.Black, AliquotaIss_X, AliquotaIss_Y, New StringFormat())
                'Fim

                'ValorIss_X 
                G.DrawString(StrValorIss, F, Brushes.Black, ValorIss_X, ValorIss_Y, New StringFormat())
                'Fim

                'ValorServiço_X 
                G.DrawString(StrValorServiço, F, Brushes.Black, ValorServiço_X, ValorServiço_Y, New StringFormat())
                'Fim
                'Fim da area de serviços
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'BaseCalcIcms_X 
        G.DrawString(StrBaseIcms, F, Brushes.Black, BaseCalcIcms_X, BaseCalcIcms_Y, New StringFormat())
        'Fim

        'ValorIcms_X 
        G.DrawString(StrVlrIcms, F, Brushes.Black, ValorIcms_X, ValorIcms_Y, New StringFormat())
        'Fim

        'TotalProdutos_X 
        G.DrawString(StrTotPord, F, Brushes.Black, TotalProdutos_X, TotalProdutos_Y, New StringFormat())
        'Fim

        'TotalIpi_X 
        G.DrawString(StrTotIpi, F, Brushes.Black, TotalIpi_X, TotalIpi_Y, New StringFormat())
        'Fim

        'TotalNota_X 
        G.DrawString(StrTotNota, F, Brushes.Black, TotalNota_X, TotalNota_Y, New StringFormat())
        'Fim

        'Transportadora_X 
        G.DrawString(StrNomeTransp, F, Brushes.Black, Transportadora_X, Transportadora_Y, New StringFormat())
        'Fim

        'Frete por Conta do 
        G.DrawString(Frt, F, Brushes.Black, FreteX, FreteY, New StringFormat())
        'Fim

        'Placa Veiculo 
        G.DrawString(Plc, F, Brushes.Black, PlacaVeiculoX, PlacaVeiculoY, New StringFormat())
        'Fim

        'EndTransportadora_X 
        G.DrawString(StrEndeTransp, F, Brushes.Black, EndTransportadora_X, EndTransportadora_Y, New StringFormat())
        'Fim

        'CidadeTransportador_X 
        G.DrawString(StrCidaTransp, F, Brushes.Black, CidadeTransportador_X, CidadeTransportador_Y, New StringFormat())
        'Fim

        'UfTransportadora_X 
        G.DrawString(StrUfTransp, F, Brushes.Black, UfTransportadora_X, UfTransportadora_Y, New StringFormat())
        'Fim

        'IncricaoTransportadora_X 
        G.DrawString(StrInscTransp, F, Brushes.Black, IncricaoTransportadora_X, IncricaoTransportadora_Y, New StringFormat())
        'Fim

        'Observacao_X 
        If Len(StrObs) > 120 Then
            Dim Cont As Integer = 0
            Dim Vazio As Boolean = False
            Dim TxtTemp As String = ""
            While Not Vazio = True
                TxtTemp = StrObs.Substring((120 + Cont), 1)

                If TxtTemp = " " Then
                    G.DrawString(Mid(StrObs, 1, (120 + Cont)), F, Brushes.Black, Observacao_X, Observacao_Y, New StringFormat())
                    G.DrawString(Mid((LTrim(StrObs)), (120 + Cont + 1), 120), F, Brushes.Black, Observacao_X, (Observacao_Y + 10), New StringFormat())
                    G.DrawString(StrCupom, F, Brushes.Black, Observacao_X, (Observacao_Y + F.GetHeight(e.Graphics) + 5), New StringFormat())
                    Exit While
                End If
                Cont += 1
            End While
        Else
            G.DrawString(StrObs, F, Brushes.Black, Observacao_X, Observacao_Y, New StringFormat())
            G.DrawString(StrCupom, F, Brushes.Black, Observacao_X, (Observacao_Y + F.GetHeight(e.Graphics)), New StringFormat())
        End If
        'Fim

        'NumeroNota2_X 
        G.DrawString(STRNF, F, Brushes.Black, NumeroNota2_X, NumeroNota2_Y, New StringFormat())
        'Fim

    End Sub

#End Region

    Private Sub Icms_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Icms.Leave
        If Me.Icms.Text = 0 Then
            Me.BaseCalcIcms.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub BtHelpMensagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtHelpMensagem.Click
        MsgBox("1-Ipi com Aliq. reduz. a zero por Intermédio do dec. lei n.649 - 11/09/92" & Chr(13) & "2-Isento de Ipi conf. dec. lei n. 551/92" & Chr(13) & "3-Substituição Tributaria, Decreto nº 10.100 de 10/2000" & Chr(13) & "4-Icms Retido por substituição tributaria, conf. dec. 10.907 anexo 003 art. 24-II" & Chr(13) & "5-AGRICOLAS PECUARIOS OU AGROPECUARIOS" & vbNewLine & "   ISENTO DE ICMS CONF. ANEXO 1 ART" & vbNewLine & "   DECRETO 10 741/2002 - DESTE. A. ESTB", 64, "Validação de Dados")
    End Sub

    Private Sub FormaPagamento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormaPagamento.Validated
        If NotaFiscalAvulsa = False Then
            If My.Forms.PedidoVenda.TotalParcelamento.Text = FormatCurrency(0, 2) Then
                If Me.FormaPagamento.Text <> "0" Then
                    Me.FormaPagamento.Text = 0
                    Me.FormaPagamentoDesc.Text = "A Vista"
                    Exit Sub
                End If
            End If

            If My.Forms.PedidoVenda.TotalParcelamento.Text > 0 Then
                If Me.FormaPagamento.Text <> "1" Then
                    Me.FormaPagamento.Text = 1
                    Me.FormaPagamentoDesc.Text = "A Prazo"
                    Exit Sub
                End If
            End If
        End If

        If Me.FormaPagamento.Text = "" Then Me.FormaPagamento.Text = 0
        If Me.FormaPagamento.Text = 0 Then
            Me.FormaPagamentoDesc.Text = "A Vista"
        ElseIf Me.FormaPagamento.Text = 1 Then
            Me.FormaPagamentoDesc.Text = "A Prazo"
        End If
    End Sub

    Private Sub NFConfirmar_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Validated
        If Me.FormaPagamento.Text = "" Then Me.FormaPagamentoDesc.Text = ""
    End Sub

    Private Sub Transportadora_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Transportadora.Validated

        If Me.Transportadora.Text = "" Then
            Exit Sub
        End If

        Dim Sql As String = "Select * from Transportadora where Codigo = " & Me.Transportadora.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.TransportadoraDesc.Text = DR.Item("RazãoTransportadora") & ""
        End If

        DR.Close()

    End Sub

    Private Sub ColocarNumeroNF()
        If My.Forms.NFiscal.Pedido.Text = "" Then
            Exit Sub
        End If



        Dim Sql As String = "UPDATE Receber SET Receber.NotaFiscal = " & My.Forms.NFiscal.NotaFiscal.Text & ", Receber.ContabilSimNao = 'Sim' WHERE (((Receber.PedidoProdutos)=" & My.Forms.NFiscal.Pedido.Text & "));"
        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            Cmd.ExecuteNonQuery()
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try


    End Sub

   
End Class