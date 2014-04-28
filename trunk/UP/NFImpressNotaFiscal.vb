Imports System.Drawing.Printing
Imports System.Drawing.Printing.PrinterSettings
Imports System.Data.OleDb
Imports Microsoft.Win32

Public Class NFImpressNotaFiscal
    Inherits System.Windows.Forms.Form

    Private WithEvents PDoc As New PrintDocument()


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btVisualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents NF As TexBoxFocusNet.TextBoxFocusNet
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NF = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btVisualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Informe o Nº da NF"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NF
        '
        Me.NF.AceitaColarTexto = True
        Me.NF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NF.CasasDecimais = 0
        Me.NF.CPObrigatorio = False
        Me.NF.CPObrigatorioMsg = Nothing
        Me.NF.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NF.FlatBorder = False
        Me.NF.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NF.FocusColor = System.Drawing.Color.Empty
        Me.NF.FocusColorEnd = System.Drawing.Color.Empty
        Me.NF.HighlightBorderOnEnter = False
        Me.NF.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NF.Location = New System.Drawing.Point(123, 22)
        Me.NF.Name = "NF"
        Me.NF.PreencherZeroEsqueda = False
        Me.NF.RegraValidação = Nothing
        Me.NF.RegraValidaçãoMensagem = Nothing
        Me.NF.Size = New System.Drawing.Size(48, 20)
        Me.NF.TabIndex = 1
        Me.NF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NF.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NF.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btVisualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.NF)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(227, 126)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 4
        '
        'btVisualizar
        '
        Me.btVisualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVisualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVisualizar.Location = New System.Drawing.Point(47, 91)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(83, 26)
        Me.btVisualizar.TabIndex = 5
        Me.btVisualizar.Text = "Visualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(136, 91)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(83, 26)
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "Fechar"
        '
        'NFImpressNotaFiscal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(227, 126)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NFImpressNotaFiscal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impressão de Nota Fiscal - T152"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click

        Dim ppd As New PrintPreviewDialog()

        'Dim L As Integer = 23 * 38
        'Dim C As Integer = 27 * 38

        'Dim Papel As New PaperSize("Custom Paper Size", 900, 1000)


        Try
            ppd.Document = PDoc

            With PDoc.DefaultPageSettings
                .Landscape = False
                '.PaperSize = Papel
                .Margins.Bottom = 0
                .Margins.Left = 0
                .Margins.Right = 0
                .Margins.Top = 0
            End With

            ppd.WindowState = FormWindowState.Maximized
            ppd.PrintPreviewControl.Zoom = 1
            ppd.Text = "Impressão de Nota Fiscal"

            PDoc.PrinterSettings.PrinterName = ImpressPadrão

            If PDoc.PrinterSettings.IsValid Then
                ppd.ShowDialog()
            Else
                MsgBox("Impressora invalida")
            End If

        Catch exp As Exception
            MsgBox("Erro ao carregar a impressão", 64, "Impressão de Nota Fiscal")
        End Try

    End Sub

    Private Sub PDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDoc.PrintPage
        'Environment.CommandLine 
        'Abertura de Banco de Dados para fazer o posicionamento das informações

        If Me.NF.Text = "" Then
            MsgBox("O usuário deve definir primeiro o numero da nota fiscal a ser impresso.", 64, "Impressão de Nf")
            Exit Sub
        End If

        If NomeFormulario = "" Then
            MsgBox("O usuário deve definir primeiro o formulário padrão.", 64, "Impressão de Nf")
            Exit Sub
        End If

        Dim CNN As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        'dados da Nf
        Dim Sql As String = "Select * from NotaFiscal where NotaFiscal = " & Me.NF.Text
        Dim CMD As New OleDbCommand(Sql, CNN)
        Dim DR As OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Dim STRNF As String = DR.Item("NotaFiscal") & ""
        Dim STRCfop As String = DR.Item("Cfop") & ""
        Dim STRCliente As String = DR.Item("Cliente") & ""
        Dim StrEmissao As String = DR.Item("DataEmissao") & ""
        Dim StrSaida As String = DR.Item("DataSaida") & ""
        Dim StrBaseIcms As String = FormatNumber(Nz(DR.Item("BaseCalcIcms"), 3), 2)
        Dim StrVlrIcms As String = FormatNumber(Nz(DR.Item("ValorIcms"), 3), 2)
        Dim StrDesconto As String = FormatNumber(Nz(DR.Item("Desconto"), 3), 2)
        Dim StrTotPord As String = FormatNumber(Nz(DR.Item("TotalProdutos"), 3), 2)
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
                StrCep = ""
                StrCida = DR.Item("Cidade") & " - " & DR.Item("Estado") & ""
                StrFone = DR.Item("Fone") & ""
                StrInsc = DR.Item("Inscricao") & ""
            End If
            DR.Close()
        End If

        'Fim dos dados de clientes

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
                Sql = "Select * from Receber where PedidoProdutos = " & StrPedido & " and Empresa = " & CodEmpresa & " and Documento <> 'Cheque'"
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
            Dim StrCf As String = DR.Item("NotaFiscalItens.Cf") & ""
            Dim StrCst As String = "0" & DR.Item("NotaFiscalItens.Cst") & ""
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
        'G.DrawString(StrObs, F, Brushes.Black, Observacao_X, Observacao_Y, New StringFormat())
        'G.DrawString(StrCupom, F, Brushes.Black, Observacao_X, (Observacao_Y + F.GetHeight(e.Graphics)), New StringFormat())
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

    Private Sub NFImpressNotaFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub
End Class
