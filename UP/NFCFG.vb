Imports Microsoft.Win32
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class NFCFG
    Inherits System.Windows.Forms.Form
    Private WithEvents PDoc As New PrintDocument()


    Dim Ação As New TrfGerais()

    Private Operation As Byte

    Const INS As Byte = 0
    Const UPD As Byte = 1
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TABGERAL As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Impress As System.Windows.Forms.Button
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Impressora As System.Windows.Forms.ComboBox
    Friend WithEvents VisualizarModelo As System.Windows.Forms.Button
    Friend WithEvents PlacaTransportadora_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents PlacaTransportadora_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents FreteContaDe_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents FreteContaDe_X As TexBoxFocusNet.TextBoxFocusNet
    Const DEL As Byte = 2


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EntradaSaida_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EntradaSaida_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NumeroNf_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NumeroNf_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CfopDesc_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CfopDesc_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cfop_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Cfop_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Nome_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Nome_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataEmissao_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataEmissao_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cnpj_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cnpj_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelNome As System.Windows.Forms.Label
    Friend WithEvents Endereco_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Endereco_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cidade_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cidade_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataSaida_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataSaida_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cep_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cep_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Bairro_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Bairro_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HoraSaida_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents HoraSaida_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Inscricao_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Inscricao_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fone_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Fone_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Novo As System.Windows.Forms.Button
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents Salvar As System.Windows.Forms.Button
    Friend WithEvents Padrão As System.Windows.Forms.Button
    Friend WithEvents NomeForms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NomeFonte As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ImpressDp As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Transportadora_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Transportadora_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EndTransportadora_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents EndTransportadora_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CidadeTransportador_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CidadeTransportador_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents UfTransportadora_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents UfTransportadora_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IncricaoTransportadora_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents IncricaoTransportadora_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Observacao_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Observacao_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NumeroNota2_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents NumeroNota2_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Desconto_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Desconto_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BaseCalcIcms_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BaseCalcIcms_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorIcms_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents ValorIcms_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TotalProdutos_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TotalProdutos_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TotalIpi_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TotalIpi_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TotalNota_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TotalNota_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DescItens_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DescItens_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cf_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Cf_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Unid_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Unid_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Qtd_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Qtd_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Unitario_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Unitario_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Total_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Total_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Icms_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Icms_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Ipi_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Ipi_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorIpi_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ValorIpi_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Dp1Posição_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Dp1Posição_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Dp2Posição_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Dp2Posição_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Dp3Posição_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Dp3Posição_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Procurar As System.Windows.Forms.Button
    Friend WithEvents St_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents St_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TamanhoFonte As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents CasaDecimaisQtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CasaDecimaisValores As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoEmpresa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents ValorIss_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents ValorIss_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents AliquotaIss_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents AliquotaIss_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Serviço_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Serviço_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorServiço_Y As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents ValorServiço_X As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ImprimirServiço As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label53 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NomeForms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomeFonte = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EntradaSaida_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EntradaSaida_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NumeroNf_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumeroNf_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cfop_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label = New System.Windows.Forms.Label()
        Me.Cfop_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CfopDesc_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CfopDesc_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Endereco_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Endereco_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataEmissao_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataEmissao_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cnpj_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cnpj_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Nome_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.Nome_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cidade_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cidade_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataSaida_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataSaida_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cep_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Cep_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Bairro_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Bairro_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HoraSaida_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.HoraSaida_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Inscricao_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Inscricao_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fone_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Fone_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fechar = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.ImpressDp = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Novo = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.Salvar = New System.Windows.Forms.Button()
        Me.Procurar = New System.Windows.Forms.Button()
        Me.Padrão = New System.Windows.Forms.Button()
        Me.Dp3Posição_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Dp3Posição_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Dp2Posição_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Dp2Posição_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Dp1Posição_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Dp1Posição_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorIpi_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ValorIpi_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Ipi_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Ipi_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Icms_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Icms_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Total_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Total_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Unitario_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Unitario_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Qtd_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Qtd_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Unid_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Unid_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cf_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Cf_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DescItens_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DescItens_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TotalNota_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TotalNota_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TotalIpi_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TotalIpi_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TotalProdutos_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TotalProdutos_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorIcms_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ValorIcms_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.BaseCalcIcms_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.BaseCalcIcms_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Desconto_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Desconto_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NumeroNota2_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.NumeroNota2_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Observacao_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Observacao_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IncricaoTransportadora_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.IncricaoTransportadora_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.UfTransportadora_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.UfTransportadora_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CidadeTransportador_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CidadeTransportador_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.EndTransportadora_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.EndTransportadora_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Transportadora_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Transportadora_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.St_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.St_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TamanhoFonte = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.CodigoEmpresa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.CasaDecimaisQtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.CasaDecimaisValores = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorIss_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.ValorIss_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.AliquotaIss_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.AliquotaIss_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Serviço_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Serviço_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorServiço_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.ValorServiço_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.ImprimirServiço = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TABGERAL = New DevComponents.DotNetBar.TabControlPanel()
        Me.PlacaTransportadora_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.PlacaTransportadora_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.FreteContaDe_Y = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.FreteContaDe_X = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.VisualizarModelo = New System.Windows.Forms.Button()
        Me.Impress = New System.Windows.Forms.Button()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Impressora = New System.Windows.Forms.ComboBox()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TABGERAL.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomeForms
        '
        Me.NomeForms.AceitaColarTexto = True
        Me.NomeForms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomeForms.CasasDecimais = 0
        Me.NomeForms.CPObrigatorio = False
        Me.NomeForms.CPObrigatorioMsg = Nothing
        Me.NomeForms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeForms.FlatBorder = False
        Me.NomeForms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeForms.FocusColor = System.Drawing.Color.Empty
        Me.NomeForms.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeForms.HighlightBorderOnEnter = False
        Me.NomeForms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeForms.Location = New System.Drawing.Point(108, 4)
        Me.NomeForms.Name = "NomeForms"
        Me.NomeForms.PreencherZeroEsqueda = False
        Me.NomeForms.RegraValidação = Nothing
        Me.NomeForms.RegraValidaçãoMensagem = Nothing
        Me.NomeForms.Size = New System.Drawing.Size(136, 21)
        Me.NomeForms.TabIndex = 1
        Me.NomeForms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeForms.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome Forms"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(379, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fonte"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NomeFonte
        '
        Me.NomeFonte.AceitaColarTexto = True
        Me.NomeFonte.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeFonte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomeFonte.CasasDecimais = 0
        Me.NomeFonte.CPObrigatorio = False
        Me.NomeFonte.CPObrigatorioMsg = Nothing
        Me.NomeFonte.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeFonte.FlatBorder = False
        Me.NomeFonte.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeFonte.FocusColor = System.Drawing.Color.Empty
        Me.NomeFonte.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeFonte.HighlightBorderOnEnter = False
        Me.NomeFonte.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeFonte.Location = New System.Drawing.Point(414, 5)
        Me.NomeFonte.Name = "NomeFonte"
        Me.NomeFonte.PreencherZeroEsqueda = False
        Me.NomeFonte.RegraValidação = Nothing
        Me.NomeFonte.RegraValidaçãoMensagem = Nothing
        Me.NomeFonte.Size = New System.Drawing.Size(140, 21)
        Me.NomeFonte.TabIndex = 5
        Me.NomeFonte.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeFonte.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Entrada/Saida"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EntradaSaida_X
        '
        Me.EntradaSaida_X.AceitaColarTexto = True
        Me.EntradaSaida_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntradaSaida_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EntradaSaida_X.CasasDecimais = 0
        Me.EntradaSaida_X.CPObrigatorio = False
        Me.EntradaSaida_X.CPObrigatorioMsg = Nothing
        Me.EntradaSaida_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntradaSaida_X.FlatBorder = False
        Me.EntradaSaida_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EntradaSaida_X.FocusColor = System.Drawing.Color.Empty
        Me.EntradaSaida_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntradaSaida_X.HighlightBorderOnEnter = False
        Me.EntradaSaida_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EntradaSaida_X.Location = New System.Drawing.Point(112, 50)
        Me.EntradaSaida_X.Name = "EntradaSaida_X"
        Me.EntradaSaida_X.PreencherZeroEsqueda = False
        Me.EntradaSaida_X.RegraValidação = Nothing
        Me.EntradaSaida_X.RegraValidaçãoMensagem = Nothing
        Me.EntradaSaida_X.Size = New System.Drawing.Size(48, 21)
        Me.EntradaSaida_X.TabIndex = 15
        Me.EntradaSaida_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EntradaSaida_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntradaSaida_X.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(116, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Horizontal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(168, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vertical"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EntradaSaida_Y
        '
        Me.EntradaSaida_Y.AceitaColarTexto = True
        Me.EntradaSaida_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntradaSaida_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EntradaSaida_Y.CasasDecimais = 0
        Me.EntradaSaida_Y.CPObrigatorio = False
        Me.EntradaSaida_Y.CPObrigatorioMsg = Nothing
        Me.EntradaSaida_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntradaSaida_Y.FlatBorder = False
        Me.EntradaSaida_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EntradaSaida_Y.FocusColor = System.Drawing.Color.Empty
        Me.EntradaSaida_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntradaSaida_Y.HighlightBorderOnEnter = False
        Me.EntradaSaida_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EntradaSaida_Y.Location = New System.Drawing.Point(164, 50)
        Me.EntradaSaida_Y.Name = "EntradaSaida_Y"
        Me.EntradaSaida_Y.PreencherZeroEsqueda = False
        Me.EntradaSaida_Y.RegraValidação = Nothing
        Me.EntradaSaida_Y.RegraValidaçãoMensagem = Nothing
        Me.EntradaSaida_Y.Size = New System.Drawing.Size(48, 21)
        Me.EntradaSaida_Y.TabIndex = 16
        Me.EntradaSaida_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EntradaSaida_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntradaSaida_Y.ValorPadrao = Nothing
        '
        'NumeroNf_Y
        '
        Me.NumeroNf_Y.AceitaColarTexto = True
        Me.NumeroNf_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NumeroNf_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroNf_Y.CasasDecimais = 0
        Me.NumeroNf_Y.CPObrigatorio = False
        Me.NumeroNf_Y.CPObrigatorioMsg = Nothing
        Me.NumeroNf_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NumeroNf_Y.FlatBorder = False
        Me.NumeroNf_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NumeroNf_Y.FocusColor = System.Drawing.Color.Empty
        Me.NumeroNf_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroNf_Y.HighlightBorderOnEnter = False
        Me.NumeroNf_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NumeroNf_Y.Location = New System.Drawing.Point(380, 50)
        Me.NumeroNf_Y.Name = "NumeroNf_Y"
        Me.NumeroNf_Y.PreencherZeroEsqueda = False
        Me.NumeroNf_Y.RegraValidação = Nothing
        Me.NumeroNf_Y.RegraValidaçãoMensagem = Nothing
        Me.NumeroNf_Y.Size = New System.Drawing.Size(48, 21)
        Me.NumeroNf_Y.TabIndex = 19
        Me.NumeroNf_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroNf_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroNf_Y.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(224, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Numero NF"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumeroNf_X
        '
        Me.NumeroNf_X.AceitaColarTexto = True
        Me.NumeroNf_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NumeroNf_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroNf_X.CasasDecimais = 0
        Me.NumeroNf_X.CPObrigatorio = False
        Me.NumeroNf_X.CPObrigatorioMsg = Nothing
        Me.NumeroNf_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NumeroNf_X.FlatBorder = False
        Me.NumeroNf_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NumeroNf_X.FocusColor = System.Drawing.Color.Empty
        Me.NumeroNf_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroNf_X.HighlightBorderOnEnter = False
        Me.NumeroNf_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NumeroNf_X.Location = New System.Drawing.Point(328, 50)
        Me.NumeroNf_X.Name = "NumeroNf_X"
        Me.NumeroNf_X.PreencherZeroEsqueda = False
        Me.NumeroNf_X.RegraValidação = Nothing
        Me.NumeroNf_X.RegraValidaçãoMensagem = Nothing
        Me.NumeroNf_X.Size = New System.Drawing.Size(48, 21)
        Me.NumeroNf_X.TabIndex = 18
        Me.NumeroNf_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroNf_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroNf_X.ValorPadrao = Nothing
        '
        'Cfop_Y
        '
        Me.Cfop_Y.AceitaColarTexto = True
        Me.Cfop_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cfop_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cfop_Y.CasasDecimais = 0
        Me.Cfop_Y.CPObrigatorio = False
        Me.Cfop_Y.CPObrigatorioMsg = Nothing
        Me.Cfop_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cfop_Y.FlatBorder = False
        Me.Cfop_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cfop_Y.FocusColor = System.Drawing.Color.Empty
        Me.Cfop_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cfop_Y.HighlightBorderOnEnter = False
        Me.Cfop_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cfop_Y.Location = New System.Drawing.Point(164, 75)
        Me.Cfop_Y.Name = "Cfop_Y"
        Me.Cfop_Y.PreencherZeroEsqueda = False
        Me.Cfop_Y.RegraValidação = Nothing
        Me.Cfop_Y.RegraValidaçãoMensagem = Nothing
        Me.Cfop_Y.Size = New System.Drawing.Size(48, 21)
        Me.Cfop_Y.TabIndex = 25
        Me.Cfop_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cfop_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cfop_Y.ValorPadrao = Nothing
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(8, 80)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(100, 16)
        Me.Label.TabIndex = 23
        Me.Label.Text = "CFOP"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cfop_X
        '
        Me.Cfop_X.AceitaColarTexto = True
        Me.Cfop_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cfop_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cfop_X.CasasDecimais = 0
        Me.Cfop_X.CPObrigatorio = False
        Me.Cfop_X.CPObrigatorioMsg = Nothing
        Me.Cfop_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cfop_X.FlatBorder = False
        Me.Cfop_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cfop_X.FocusColor = System.Drawing.Color.Empty
        Me.Cfop_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cfop_X.HighlightBorderOnEnter = False
        Me.Cfop_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cfop_X.Location = New System.Drawing.Point(112, 75)
        Me.Cfop_X.Name = "Cfop_X"
        Me.Cfop_X.PreencherZeroEsqueda = False
        Me.Cfop_X.RegraValidação = Nothing
        Me.Cfop_X.RegraValidaçãoMensagem = Nothing
        Me.Cfop_X.Size = New System.Drawing.Size(48, 21)
        Me.Cfop_X.TabIndex = 24
        Me.Cfop_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cfop_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cfop_X.ValorPadrao = Nothing
        '
        'CfopDesc_Y
        '
        Me.CfopDesc_Y.AceitaColarTexto = True
        Me.CfopDesc_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CfopDesc_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CfopDesc_Y.CasasDecimais = 0
        Me.CfopDesc_Y.CPObrigatorio = False
        Me.CfopDesc_Y.CPObrigatorioMsg = Nothing
        Me.CfopDesc_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CfopDesc_Y.FlatBorder = False
        Me.CfopDesc_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CfopDesc_Y.FocusColor = System.Drawing.Color.Empty
        Me.CfopDesc_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.CfopDesc_Y.HighlightBorderOnEnter = False
        Me.CfopDesc_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CfopDesc_Y.Location = New System.Drawing.Point(596, 50)
        Me.CfopDesc_Y.Name = "CfopDesc_Y"
        Me.CfopDesc_Y.PreencherZeroEsqueda = False
        Me.CfopDesc_Y.RegraValidação = Nothing
        Me.CfopDesc_Y.RegraValidaçãoMensagem = Nothing
        Me.CfopDesc_Y.Size = New System.Drawing.Size(48, 21)
        Me.CfopDesc_Y.TabIndex = 22
        Me.CfopDesc_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CfopDesc_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CfopDesc_Y.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(440, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "CFOP Descrição"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CfopDesc_X
        '
        Me.CfopDesc_X.AceitaColarTexto = True
        Me.CfopDesc_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CfopDesc_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CfopDesc_X.CasasDecimais = 0
        Me.CfopDesc_X.CPObrigatorio = False
        Me.CfopDesc_X.CPObrigatorioMsg = Nothing
        Me.CfopDesc_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CfopDesc_X.FlatBorder = False
        Me.CfopDesc_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CfopDesc_X.FocusColor = System.Drawing.Color.Empty
        Me.CfopDesc_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.CfopDesc_X.HighlightBorderOnEnter = False
        Me.CfopDesc_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CfopDesc_X.Location = New System.Drawing.Point(544, 50)
        Me.CfopDesc_X.Name = "CfopDesc_X"
        Me.CfopDesc_X.PreencherZeroEsqueda = False
        Me.CfopDesc_X.RegraValidação = Nothing
        Me.CfopDesc_X.RegraValidaçãoMensagem = Nothing
        Me.CfopDesc_X.Size = New System.Drawing.Size(48, 21)
        Me.CfopDesc_X.TabIndex = 21
        Me.CfopDesc_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CfopDesc_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CfopDesc_X.ValorPadrao = Nothing
        '
        'Endereco_Y
        '
        Me.Endereco_Y.AceitaColarTexto = True
        Me.Endereco_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Endereco_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Endereco_Y.CasasDecimais = 0
        Me.Endereco_Y.CPObrigatorio = False
        Me.Endereco_Y.CPObrigatorioMsg = Nothing
        Me.Endereco_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Endereco_Y.FlatBorder = False
        Me.Endereco_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Endereco_Y.FocusColor = System.Drawing.Color.Empty
        Me.Endereco_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Endereco_Y.HighlightBorderOnEnter = False
        Me.Endereco_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Endereco_Y.Location = New System.Drawing.Point(380, 100)
        Me.Endereco_Y.Name = "Endereco_Y"
        Me.Endereco_Y.PreencherZeroEsqueda = False
        Me.Endereco_Y.RegraValidação = Nothing
        Me.Endereco_Y.RegraValidaçãoMensagem = Nothing
        Me.Endereco_Y.Size = New System.Drawing.Size(48, 21)
        Me.Endereco_Y.TabIndex = 38
        Me.Endereco_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Endereco_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Endereco_Y.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(224, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Endereço"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Endereco_X
        '
        Me.Endereco_X.AceitaColarTexto = True
        Me.Endereco_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Endereco_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Endereco_X.CasasDecimais = 0
        Me.Endereco_X.CPObrigatorio = False
        Me.Endereco_X.CPObrigatorioMsg = Nothing
        Me.Endereco_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Endereco_X.FlatBorder = False
        Me.Endereco_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Endereco_X.FocusColor = System.Drawing.Color.Empty
        Me.Endereco_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Endereco_X.HighlightBorderOnEnter = False
        Me.Endereco_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Endereco_X.Location = New System.Drawing.Point(328, 100)
        Me.Endereco_X.Name = "Endereco_X"
        Me.Endereco_X.PreencherZeroEsqueda = False
        Me.Endereco_X.RegraValidação = Nothing
        Me.Endereco_X.RegraValidaçãoMensagem = Nothing
        Me.Endereco_X.Size = New System.Drawing.Size(48, 21)
        Me.Endereco_X.TabIndex = 37
        Me.Endereco_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Endereco_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Endereco_X.ValorPadrao = Nothing
        '
        'DataEmissao_Y
        '
        Me.DataEmissao_Y.AceitaColarTexto = True
        Me.DataEmissao_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataEmissao_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataEmissao_Y.CasasDecimais = 0
        Me.DataEmissao_Y.CPObrigatorio = False
        Me.DataEmissao_Y.CPObrigatorioMsg = Nothing
        Me.DataEmissao_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataEmissao_Y.FlatBorder = False
        Me.DataEmissao_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataEmissao_Y.FocusColor = System.Drawing.Color.Empty
        Me.DataEmissao_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataEmissao_Y.HighlightBorderOnEnter = False
        Me.DataEmissao_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataEmissao_Y.Location = New System.Drawing.Point(164, 100)
        Me.DataEmissao_Y.Name = "DataEmissao_Y"
        Me.DataEmissao_Y.PreencherZeroEsqueda = False
        Me.DataEmissao_Y.RegraValidação = Nothing
        Me.DataEmissao_Y.RegraValidaçãoMensagem = Nothing
        Me.DataEmissao_Y.Size = New System.Drawing.Size(48, 21)
        Me.DataEmissao_Y.TabIndex = 35
        Me.DataEmissao_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataEmissao_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DataEmissao_Y.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Data da Emissão"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataEmissao_X
        '
        Me.DataEmissao_X.AceitaColarTexto = True
        Me.DataEmissao_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataEmissao_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataEmissao_X.CasasDecimais = 0
        Me.DataEmissao_X.CPObrigatorio = False
        Me.DataEmissao_X.CPObrigatorioMsg = Nothing
        Me.DataEmissao_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataEmissao_X.FlatBorder = False
        Me.DataEmissao_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataEmissao_X.FocusColor = System.Drawing.Color.Empty
        Me.DataEmissao_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataEmissao_X.HighlightBorderOnEnter = False
        Me.DataEmissao_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataEmissao_X.Location = New System.Drawing.Point(112, 100)
        Me.DataEmissao_X.Name = "DataEmissao_X"
        Me.DataEmissao_X.PreencherZeroEsqueda = False
        Me.DataEmissao_X.RegraValidação = Nothing
        Me.DataEmissao_X.RegraValidaçãoMensagem = Nothing
        Me.DataEmissao_X.Size = New System.Drawing.Size(48, 21)
        Me.DataEmissao_X.TabIndex = 34
        Me.DataEmissao_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataEmissao_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DataEmissao_X.ValorPadrao = Nothing
        '
        'Cnpj_Y
        '
        Me.Cnpj_Y.AceitaColarTexto = True
        Me.Cnpj_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cnpj_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cnpj_Y.CasasDecimais = 0
        Me.Cnpj_Y.CPObrigatorio = False
        Me.Cnpj_Y.CPObrigatorioMsg = Nothing
        Me.Cnpj_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cnpj_Y.FlatBorder = False
        Me.Cnpj_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cnpj_Y.FocusColor = System.Drawing.Color.Empty
        Me.Cnpj_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cnpj_Y.HighlightBorderOnEnter = False
        Me.Cnpj_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cnpj_Y.Location = New System.Drawing.Point(596, 75)
        Me.Cnpj_Y.Name = "Cnpj_Y"
        Me.Cnpj_Y.PreencherZeroEsqueda = False
        Me.Cnpj_Y.RegraValidação = Nothing
        Me.Cnpj_Y.RegraValidaçãoMensagem = Nothing
        Me.Cnpj_Y.Size = New System.Drawing.Size(48, 21)
        Me.Cnpj_Y.TabIndex = 32
        Me.Cnpj_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cnpj_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cnpj_Y.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(440, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Cnpj"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cnpj_X
        '
        Me.Cnpj_X.AceitaColarTexto = True
        Me.Cnpj_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cnpj_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cnpj_X.CasasDecimais = 0
        Me.Cnpj_X.CPObrigatorio = False
        Me.Cnpj_X.CPObrigatorioMsg = Nothing
        Me.Cnpj_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cnpj_X.FlatBorder = False
        Me.Cnpj_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cnpj_X.FocusColor = System.Drawing.Color.Empty
        Me.Cnpj_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cnpj_X.HighlightBorderOnEnter = False
        Me.Cnpj_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cnpj_X.Location = New System.Drawing.Point(544, 75)
        Me.Cnpj_X.Name = "Cnpj_X"
        Me.Cnpj_X.PreencherZeroEsqueda = False
        Me.Cnpj_X.RegraValidação = Nothing
        Me.Cnpj_X.RegraValidaçãoMensagem = Nothing
        Me.Cnpj_X.Size = New System.Drawing.Size(48, 21)
        Me.Cnpj_X.TabIndex = 31
        Me.Cnpj_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cnpj_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cnpj_X.ValorPadrao = Nothing
        '
        'Nome_Y
        '
        Me.Nome_Y.AceitaColarTexto = True
        Me.Nome_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Nome_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nome_Y.CasasDecimais = 0
        Me.Nome_Y.CPObrigatorio = False
        Me.Nome_Y.CPObrigatorioMsg = Nothing
        Me.Nome_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Nome_Y.FlatBorder = False
        Me.Nome_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Nome_Y.FocusColor = System.Drawing.Color.Empty
        Me.Nome_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Nome_Y.HighlightBorderOnEnter = False
        Me.Nome_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Nome_Y.Location = New System.Drawing.Point(380, 75)
        Me.Nome_Y.Name = "Nome_Y"
        Me.Nome_Y.PreencherZeroEsqueda = False
        Me.Nome_Y.RegraValidação = Nothing
        Me.Nome_Y.RegraValidaçãoMensagem = Nothing
        Me.Nome_Y.Size = New System.Drawing.Size(48, 21)
        Me.Nome_Y.TabIndex = 28
        Me.Nome_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nome_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Nome_Y.ValorPadrao = Nothing
        '
        'LabelNome
        '
        Me.LabelNome.BackColor = System.Drawing.Color.Transparent
        Me.LabelNome.ForeColor = System.Drawing.Color.Black
        Me.LabelNome.Location = New System.Drawing.Point(224, 80)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(100, 16)
        Me.LabelNome.TabIndex = 26
        Me.LabelNome.Text = "Nome"
        Me.LabelNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Nome_X
        '
        Me.Nome_X.AceitaColarTexto = True
        Me.Nome_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Nome_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nome_X.CasasDecimais = 0
        Me.Nome_X.CPObrigatorio = False
        Me.Nome_X.CPObrigatorioMsg = Nothing
        Me.Nome_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Nome_X.FlatBorder = False
        Me.Nome_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Nome_X.FocusColor = System.Drawing.Color.Empty
        Me.Nome_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Nome_X.HighlightBorderOnEnter = False
        Me.Nome_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Nome_X.Location = New System.Drawing.Point(328, 75)
        Me.Nome_X.Name = "Nome_X"
        Me.Nome_X.PreencherZeroEsqueda = False
        Me.Nome_X.RegraValidação = Nothing
        Me.Nome_X.RegraValidaçãoMensagem = Nothing
        Me.Nome_X.Size = New System.Drawing.Size(48, 21)
        Me.Nome_X.TabIndex = 27
        Me.Nome_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nome_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Nome_X.ValorPadrao = Nothing
        '
        'Cidade_Y
        '
        Me.Cidade_Y.AceitaColarTexto = True
        Me.Cidade_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cidade_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cidade_Y.CasasDecimais = 0
        Me.Cidade_Y.CPObrigatorio = False
        Me.Cidade_Y.CPObrigatorioMsg = Nothing
        Me.Cidade_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cidade_Y.FlatBorder = False
        Me.Cidade_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cidade_Y.FocusColor = System.Drawing.Color.Empty
        Me.Cidade_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cidade_Y.HighlightBorderOnEnter = False
        Me.Cidade_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cidade_Y.Location = New System.Drawing.Point(596, 125)
        Me.Cidade_Y.Name = "Cidade_Y"
        Me.Cidade_Y.PreencherZeroEsqueda = False
        Me.Cidade_Y.RegraValidação = Nothing
        Me.Cidade_Y.RegraValidaçãoMensagem = Nothing
        Me.Cidade_Y.Size = New System.Drawing.Size(48, 21)
        Me.Cidade_Y.TabIndex = 50
        Me.Cidade_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cidade_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cidade_Y.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(440, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Cidade"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cidade_X
        '
        Me.Cidade_X.AceitaColarTexto = True
        Me.Cidade_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cidade_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cidade_X.CasasDecimais = 0
        Me.Cidade_X.CPObrigatorio = False
        Me.Cidade_X.CPObrigatorioMsg = Nothing
        Me.Cidade_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cidade_X.FlatBorder = False
        Me.Cidade_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cidade_X.FocusColor = System.Drawing.Color.Empty
        Me.Cidade_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cidade_X.HighlightBorderOnEnter = False
        Me.Cidade_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cidade_X.Location = New System.Drawing.Point(544, 125)
        Me.Cidade_X.Name = "Cidade_X"
        Me.Cidade_X.PreencherZeroEsqueda = False
        Me.Cidade_X.RegraValidação = Nothing
        Me.Cidade_X.RegraValidaçãoMensagem = Nothing
        Me.Cidade_X.Size = New System.Drawing.Size(48, 21)
        Me.Cidade_X.TabIndex = 49
        Me.Cidade_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cidade_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cidade_X.ValorPadrao = Nothing
        '
        'DataSaida_Y
        '
        Me.DataSaida_Y.AceitaColarTexto = True
        Me.DataSaida_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataSaida_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataSaida_Y.CasasDecimais = 0
        Me.DataSaida_Y.CPObrigatorio = False
        Me.DataSaida_Y.CPObrigatorioMsg = Nothing
        Me.DataSaida_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataSaida_Y.FlatBorder = False
        Me.DataSaida_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataSaida_Y.FocusColor = System.Drawing.Color.Empty
        Me.DataSaida_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataSaida_Y.HighlightBorderOnEnter = False
        Me.DataSaida_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataSaida_Y.Location = New System.Drawing.Point(380, 125)
        Me.DataSaida_Y.Name = "DataSaida_Y"
        Me.DataSaida_Y.PreencherZeroEsqueda = False
        Me.DataSaida_Y.RegraValidação = Nothing
        Me.DataSaida_Y.RegraValidaçãoMensagem = Nothing
        Me.DataSaida_Y.Size = New System.Drawing.Size(48, 21)
        Me.DataSaida_Y.TabIndex = 47
        Me.DataSaida_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataSaida_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DataSaida_Y.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(224, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Data de Saida"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataSaida_X
        '
        Me.DataSaida_X.AceitaColarTexto = True
        Me.DataSaida_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataSaida_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataSaida_X.CasasDecimais = 0
        Me.DataSaida_X.CPObrigatorio = False
        Me.DataSaida_X.CPObrigatorioMsg = Nothing
        Me.DataSaida_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataSaida_X.FlatBorder = False
        Me.DataSaida_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataSaida_X.FocusColor = System.Drawing.Color.Empty
        Me.DataSaida_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataSaida_X.HighlightBorderOnEnter = False
        Me.DataSaida_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataSaida_X.Location = New System.Drawing.Point(328, 125)
        Me.DataSaida_X.Name = "DataSaida_X"
        Me.DataSaida_X.PreencherZeroEsqueda = False
        Me.DataSaida_X.RegraValidação = Nothing
        Me.DataSaida_X.RegraValidaçãoMensagem = Nothing
        Me.DataSaida_X.Size = New System.Drawing.Size(48, 21)
        Me.DataSaida_X.TabIndex = 46
        Me.DataSaida_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataSaida_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DataSaida_X.ValorPadrao = Nothing
        '
        'Cep_Y
        '
        Me.Cep_Y.AceitaColarTexto = True
        Me.Cep_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cep_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cep_Y.CasasDecimais = 0
        Me.Cep_Y.CPObrigatorio = False
        Me.Cep_Y.CPObrigatorioMsg = Nothing
        Me.Cep_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cep_Y.FlatBorder = False
        Me.Cep_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cep_Y.FocusColor = System.Drawing.Color.Empty
        Me.Cep_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cep_Y.HighlightBorderOnEnter = False
        Me.Cep_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cep_Y.Location = New System.Drawing.Point(164, 125)
        Me.Cep_Y.Name = "Cep_Y"
        Me.Cep_Y.PreencherZeroEsqueda = False
        Me.Cep_Y.RegraValidação = Nothing
        Me.Cep_Y.RegraValidaçãoMensagem = Nothing
        Me.Cep_Y.Size = New System.Drawing.Size(48, 21)
        Me.Cep_Y.TabIndex = 44
        Me.Cep_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cep_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cep_Y.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Cep"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cep_X
        '
        Me.Cep_X.AceitaColarTexto = True
        Me.Cep_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cep_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cep_X.CasasDecimais = 0
        Me.Cep_X.CPObrigatorio = False
        Me.Cep_X.CPObrigatorioMsg = Nothing
        Me.Cep_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cep_X.FlatBorder = False
        Me.Cep_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cep_X.FocusColor = System.Drawing.Color.Empty
        Me.Cep_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cep_X.HighlightBorderOnEnter = False
        Me.Cep_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cep_X.Location = New System.Drawing.Point(112, 125)
        Me.Cep_X.Name = "Cep_X"
        Me.Cep_X.PreencherZeroEsqueda = False
        Me.Cep_X.RegraValidação = Nothing
        Me.Cep_X.RegraValidaçãoMensagem = Nothing
        Me.Cep_X.Size = New System.Drawing.Size(48, 21)
        Me.Cep_X.TabIndex = 43
        Me.Cep_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cep_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cep_X.ValorPadrao = Nothing
        '
        'Bairro_Y
        '
        Me.Bairro_Y.AceitaColarTexto = True
        Me.Bairro_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Bairro_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bairro_Y.CasasDecimais = 0
        Me.Bairro_Y.CPObrigatorio = False
        Me.Bairro_Y.CPObrigatorioMsg = Nothing
        Me.Bairro_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Bairro_Y.FlatBorder = False
        Me.Bairro_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Bairro_Y.FocusColor = System.Drawing.Color.Empty
        Me.Bairro_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Bairro_Y.HighlightBorderOnEnter = False
        Me.Bairro_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Bairro_Y.Location = New System.Drawing.Point(596, 100)
        Me.Bairro_Y.Name = "Bairro_Y"
        Me.Bairro_Y.PreencherZeroEsqueda = False
        Me.Bairro_Y.RegraValidação = Nothing
        Me.Bairro_Y.RegraValidaçãoMensagem = Nothing
        Me.Bairro_Y.Size = New System.Drawing.Size(48, 21)
        Me.Bairro_Y.TabIndex = 41
        Me.Bairro_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Bairro_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Bairro_Y.ValorPadrao = Nothing
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(440, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Bairro"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Bairro_X
        '
        Me.Bairro_X.AceitaColarTexto = True
        Me.Bairro_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Bairro_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bairro_X.CasasDecimais = 0
        Me.Bairro_X.CPObrigatorio = False
        Me.Bairro_X.CPObrigatorioMsg = Nothing
        Me.Bairro_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Bairro_X.FlatBorder = False
        Me.Bairro_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Bairro_X.FocusColor = System.Drawing.Color.Empty
        Me.Bairro_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Bairro_X.HighlightBorderOnEnter = False
        Me.Bairro_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Bairro_X.Location = New System.Drawing.Point(544, 100)
        Me.Bairro_X.Name = "Bairro_X"
        Me.Bairro_X.PreencherZeroEsqueda = False
        Me.Bairro_X.RegraValidação = Nothing
        Me.Bairro_X.RegraValidaçãoMensagem = Nothing
        Me.Bairro_X.Size = New System.Drawing.Size(48, 21)
        Me.Bairro_X.TabIndex = 40
        Me.Bairro_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Bairro_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Bairro_X.ValorPadrao = Nothing
        '
        'HoraSaida_Y
        '
        Me.HoraSaida_Y.AceitaColarTexto = True
        Me.HoraSaida_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.HoraSaida_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HoraSaida_Y.CasasDecimais = 0
        Me.HoraSaida_Y.CPObrigatorio = False
        Me.HoraSaida_Y.CPObrigatorioMsg = Nothing
        Me.HoraSaida_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.HoraSaida_Y.FlatBorder = False
        Me.HoraSaida_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.HoraSaida_Y.FocusColor = System.Drawing.Color.Empty
        Me.HoraSaida_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.HoraSaida_Y.HighlightBorderOnEnter = False
        Me.HoraSaida_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.HoraSaida_Y.Location = New System.Drawing.Point(596, 150)
        Me.HoraSaida_Y.Name = "HoraSaida_Y"
        Me.HoraSaida_Y.PreencherZeroEsqueda = False
        Me.HoraSaida_Y.RegraValidação = Nothing
        Me.HoraSaida_Y.RegraValidaçãoMensagem = Nothing
        Me.HoraSaida_Y.Size = New System.Drawing.Size(48, 21)
        Me.HoraSaida_Y.TabIndex = 59
        Me.HoraSaida_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HoraSaida_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.HoraSaida_Y.ValorPadrao = Nothing
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(440, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Hora da Saída"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HoraSaida_X
        '
        Me.HoraSaida_X.AceitaColarTexto = True
        Me.HoraSaida_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.HoraSaida_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HoraSaida_X.CasasDecimais = 0
        Me.HoraSaida_X.CPObrigatorio = False
        Me.HoraSaida_X.CPObrigatorioMsg = Nothing
        Me.HoraSaida_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.HoraSaida_X.FlatBorder = False
        Me.HoraSaida_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.HoraSaida_X.FocusColor = System.Drawing.Color.Empty
        Me.HoraSaida_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.HoraSaida_X.HighlightBorderOnEnter = False
        Me.HoraSaida_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.HoraSaida_X.Location = New System.Drawing.Point(544, 150)
        Me.HoraSaida_X.Name = "HoraSaida_X"
        Me.HoraSaida_X.PreencherZeroEsqueda = False
        Me.HoraSaida_X.RegraValidação = Nothing
        Me.HoraSaida_X.RegraValidaçãoMensagem = Nothing
        Me.HoraSaida_X.Size = New System.Drawing.Size(48, 21)
        Me.HoraSaida_X.TabIndex = 58
        Me.HoraSaida_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HoraSaida_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.HoraSaida_X.ValorPadrao = Nothing
        '
        'Inscricao_Y
        '
        Me.Inscricao_Y.AceitaColarTexto = True
        Me.Inscricao_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Inscricao_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Inscricao_Y.CasasDecimais = 0
        Me.Inscricao_Y.CPObrigatorio = False
        Me.Inscricao_Y.CPObrigatorioMsg = Nothing
        Me.Inscricao_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Inscricao_Y.FlatBorder = False
        Me.Inscricao_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Inscricao_Y.FocusColor = System.Drawing.Color.Empty
        Me.Inscricao_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Inscricao_Y.HighlightBorderOnEnter = False
        Me.Inscricao_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Inscricao_Y.Location = New System.Drawing.Point(380, 150)
        Me.Inscricao_Y.Name = "Inscricao_Y"
        Me.Inscricao_Y.PreencherZeroEsqueda = False
        Me.Inscricao_Y.RegraValidação = Nothing
        Me.Inscricao_Y.RegraValidaçãoMensagem = Nothing
        Me.Inscricao_Y.Size = New System.Drawing.Size(48, 21)
        Me.Inscricao_Y.TabIndex = 56
        Me.Inscricao_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Inscricao_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Inscricao_Y.ValorPadrao = Nothing
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(224, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 16)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Incrição Estadual"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Inscricao_X
        '
        Me.Inscricao_X.AceitaColarTexto = True
        Me.Inscricao_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Inscricao_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Inscricao_X.CasasDecimais = 0
        Me.Inscricao_X.CPObrigatorio = False
        Me.Inscricao_X.CPObrigatorioMsg = Nothing
        Me.Inscricao_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Inscricao_X.FlatBorder = False
        Me.Inscricao_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Inscricao_X.FocusColor = System.Drawing.Color.Empty
        Me.Inscricao_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Inscricao_X.HighlightBorderOnEnter = False
        Me.Inscricao_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Inscricao_X.Location = New System.Drawing.Point(328, 150)
        Me.Inscricao_X.Name = "Inscricao_X"
        Me.Inscricao_X.PreencherZeroEsqueda = False
        Me.Inscricao_X.RegraValidação = Nothing
        Me.Inscricao_X.RegraValidaçãoMensagem = Nothing
        Me.Inscricao_X.Size = New System.Drawing.Size(48, 21)
        Me.Inscricao_X.TabIndex = 55
        Me.Inscricao_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Inscricao_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Inscricao_X.ValorPadrao = Nothing
        '
        'Fone_Y
        '
        Me.Fone_Y.AceitaColarTexto = True
        Me.Fone_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Fone_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fone_Y.CasasDecimais = 0
        Me.Fone_Y.CPObrigatorio = False
        Me.Fone_Y.CPObrigatorioMsg = Nothing
        Me.Fone_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Fone_Y.FlatBorder = False
        Me.Fone_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Fone_Y.FocusColor = System.Drawing.Color.Empty
        Me.Fone_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Fone_Y.HighlightBorderOnEnter = False
        Me.Fone_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Fone_Y.Location = New System.Drawing.Point(164, 150)
        Me.Fone_Y.Name = "Fone_Y"
        Me.Fone_Y.PreencherZeroEsqueda = False
        Me.Fone_Y.RegraValidação = Nothing
        Me.Fone_Y.RegraValidaçãoMensagem = Nothing
        Me.Fone_Y.Size = New System.Drawing.Size(48, 21)
        Me.Fone_Y.TabIndex = 53
        Me.Fone_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fone_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Fone_Y.ValorPadrao = Nothing
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 16)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Telefone"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fone_X
        '
        Me.Fone_X.AceitaColarTexto = True
        Me.Fone_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Fone_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fone_X.CasasDecimais = 0
        Me.Fone_X.CPObrigatorio = False
        Me.Fone_X.CPObrigatorioMsg = Nothing
        Me.Fone_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Fone_X.FlatBorder = False
        Me.Fone_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Fone_X.FocusColor = System.Drawing.Color.Empty
        Me.Fone_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Fone_X.HighlightBorderOnEnter = False
        Me.Fone_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Fone_X.Location = New System.Drawing.Point(112, 150)
        Me.Fone_X.Name = "Fone_X"
        Me.Fone_X.PreencherZeroEsqueda = False
        Me.Fone_X.RegraValidação = Nothing
        Me.Fone_X.RegraValidaçãoMensagem = Nothing
        Me.Fone_X.Size = New System.Drawing.Size(48, 21)
        Me.Fone_X.TabIndex = 52
        Me.Fone_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fone_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Fone_X.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.Location = New System.Drawing.Point(579, 539)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(68, 24)
        Me.Fechar.TabIndex = 168
        Me.Fechar.Text = "Fechar"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(380, 30)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 16)
        Me.Label30.TabIndex = 11
        Me.Label30.Text = "Vertical"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(328, 33)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 16)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "Horizontal"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(600, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 16)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Vertical"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(548, 33)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 16)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "Horizontal"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(-1, 519)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(112, 16)
        Me.Label47.TabIndex = 158
        Me.Label47.Text = "Imprimir Duplicatas ?"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImpressDp
        '
        Me.ImpressDp.AceitaColarTexto = True
        Me.ImpressDp.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ImpressDp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImpressDp.CasasDecimais = 0
        Me.ImpressDp.CPObrigatorio = False
        Me.ImpressDp.CPObrigatorioMsg = Nothing
        Me.ImpressDp.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ImpressDp.FlatBorder = False
        Me.ImpressDp.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ImpressDp.FocusColor = System.Drawing.Color.Empty
        Me.ImpressDp.FocusColorEnd = System.Drawing.Color.Empty
        Me.ImpressDp.HighlightBorderOnEnter = False
        Me.ImpressDp.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ImpressDp.Location = New System.Drawing.Point(114, 514)
        Me.ImpressDp.Name = "ImpressDp"
        Me.ImpressDp.PreencherZeroEsqueda = False
        Me.ImpressDp.RegraValidação = Nothing
        Me.ImpressDp.RegraValidaçãoMensagem = Nothing
        Me.ImpressDp.Size = New System.Drawing.Size(48, 21)
        Me.ImpressDp.TabIndex = 159
        Me.ImpressDp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ImpressDp.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ImpressDp.ValorPadrao = Nothing
        '
        'Novo
        '
        Me.Novo.Location = New System.Drawing.Point(509, 539)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(68, 24)
        Me.Novo.TabIndex = 167
        Me.Novo.Text = "Novo"
        '
        'Editar
        '
        Me.Editar.Location = New System.Drawing.Point(369, 539)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(68, 24)
        Me.Editar.TabIndex = 164
        Me.Editar.Text = "Editar"
        '
        'Salvar
        '
        Me.Salvar.Location = New System.Drawing.Point(439, 539)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(68, 24)
        Me.Salvar.TabIndex = 163
        Me.Salvar.Text = "Salvar"
        '
        'Procurar
        '
        Me.Procurar.Location = New System.Drawing.Point(299, 539)
        Me.Procurar.Name = "Procurar"
        Me.Procurar.Size = New System.Drawing.Size(68, 24)
        Me.Procurar.TabIndex = 165
        Me.Procurar.Text = "Localizar"
        '
        'Padrão
        '
        Me.Padrão.Location = New System.Drawing.Point(229, 539)
        Me.Padrão.Name = "Padrão"
        Me.Padrão.Size = New System.Drawing.Size(68, 24)
        Me.Padrão.TabIndex = 166
        Me.Padrão.Text = "Padrão"
        '
        'Dp3Posição_Y
        '
        Me.Dp3Posição_Y.AceitaColarTexto = True
        Me.Dp3Posição_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Dp3Posição_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dp3Posição_Y.CasasDecimais = 0
        Me.Dp3Posição_Y.CPObrigatorio = False
        Me.Dp3Posição_Y.CPObrigatorioMsg = Nothing
        Me.Dp3Posição_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Dp3Posição_Y.FlatBorder = False
        Me.Dp3Posição_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Dp3Posição_Y.FocusColor = System.Drawing.Color.Empty
        Me.Dp3Posição_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Dp3Posição_Y.HighlightBorderOnEnter = False
        Me.Dp3Posição_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Dp3Posição_Y.Location = New System.Drawing.Point(596, 175)
        Me.Dp3Posição_Y.Name = "Dp3Posição_Y"
        Me.Dp3Posição_Y.PreencherZeroEsqueda = False
        Me.Dp3Posição_Y.RegraValidação = Nothing
        Me.Dp3Posição_Y.RegraValidaçãoMensagem = Nothing
        Me.Dp3Posição_Y.Size = New System.Drawing.Size(48, 21)
        Me.Dp3Posição_Y.TabIndex = 68
        Me.Dp3Posição_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dp3Posição_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Dp3Posição_Y.ValorPadrao = Nothing
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(440, 180)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 16)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Col 3 Dp"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dp3Posição_X
        '
        Me.Dp3Posição_X.AceitaColarTexto = True
        Me.Dp3Posição_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Dp3Posição_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dp3Posição_X.CasasDecimais = 0
        Me.Dp3Posição_X.CPObrigatorio = False
        Me.Dp3Posição_X.CPObrigatorioMsg = Nothing
        Me.Dp3Posição_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Dp3Posição_X.FlatBorder = False
        Me.Dp3Posição_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Dp3Posição_X.FocusColor = System.Drawing.Color.Empty
        Me.Dp3Posição_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Dp3Posição_X.HighlightBorderOnEnter = False
        Me.Dp3Posição_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Dp3Posição_X.Location = New System.Drawing.Point(544, 175)
        Me.Dp3Posição_X.Name = "Dp3Posição_X"
        Me.Dp3Posição_X.PreencherZeroEsqueda = False
        Me.Dp3Posição_X.RegraValidação = Nothing
        Me.Dp3Posição_X.RegraValidaçãoMensagem = Nothing
        Me.Dp3Posição_X.Size = New System.Drawing.Size(48, 21)
        Me.Dp3Posição_X.TabIndex = 67
        Me.Dp3Posição_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dp3Posição_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Dp3Posição_X.ValorPadrao = Nothing
        '
        'Dp2Posição_Y
        '
        Me.Dp2Posição_Y.AceitaColarTexto = True
        Me.Dp2Posição_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Dp2Posição_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dp2Posição_Y.CasasDecimais = 0
        Me.Dp2Posição_Y.CPObrigatorio = False
        Me.Dp2Posição_Y.CPObrigatorioMsg = Nothing
        Me.Dp2Posição_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Dp2Posição_Y.FlatBorder = False
        Me.Dp2Posição_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Dp2Posição_Y.FocusColor = System.Drawing.Color.Empty
        Me.Dp2Posição_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Dp2Posição_Y.HighlightBorderOnEnter = False
        Me.Dp2Posição_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Dp2Posição_Y.Location = New System.Drawing.Point(380, 175)
        Me.Dp2Posição_Y.Name = "Dp2Posição_Y"
        Me.Dp2Posição_Y.PreencherZeroEsqueda = False
        Me.Dp2Posição_Y.RegraValidação = Nothing
        Me.Dp2Posição_Y.RegraValidaçãoMensagem = Nothing
        Me.Dp2Posição_Y.Size = New System.Drawing.Size(48, 21)
        Me.Dp2Posição_Y.TabIndex = 65
        Me.Dp2Posição_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dp2Posição_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Dp2Posição_Y.ValorPadrao = Nothing
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(224, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Col 2 Dp"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dp2Posição_X
        '
        Me.Dp2Posição_X.AceitaColarTexto = True
        Me.Dp2Posição_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Dp2Posição_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dp2Posição_X.CasasDecimais = 0
        Me.Dp2Posição_X.CPObrigatorio = False
        Me.Dp2Posição_X.CPObrigatorioMsg = Nothing
        Me.Dp2Posição_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Dp2Posição_X.FlatBorder = False
        Me.Dp2Posição_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Dp2Posição_X.FocusColor = System.Drawing.Color.Empty
        Me.Dp2Posição_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Dp2Posição_X.HighlightBorderOnEnter = False
        Me.Dp2Posição_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Dp2Posição_X.Location = New System.Drawing.Point(328, 175)
        Me.Dp2Posição_X.Name = "Dp2Posição_X"
        Me.Dp2Posição_X.PreencherZeroEsqueda = False
        Me.Dp2Posição_X.RegraValidação = Nothing
        Me.Dp2Posição_X.RegraValidaçãoMensagem = Nothing
        Me.Dp2Posição_X.Size = New System.Drawing.Size(48, 21)
        Me.Dp2Posição_X.TabIndex = 64
        Me.Dp2Posição_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dp2Posição_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Dp2Posição_X.ValorPadrao = Nothing
        '
        'Dp1Posição_Y
        '
        Me.Dp1Posição_Y.AceitaColarTexto = True
        Me.Dp1Posição_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Dp1Posição_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dp1Posição_Y.CasasDecimais = 0
        Me.Dp1Posição_Y.CPObrigatorio = False
        Me.Dp1Posição_Y.CPObrigatorioMsg = Nothing
        Me.Dp1Posição_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Dp1Posição_Y.FlatBorder = False
        Me.Dp1Posição_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Dp1Posição_Y.FocusColor = System.Drawing.Color.Empty
        Me.Dp1Posição_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Dp1Posição_Y.HighlightBorderOnEnter = False
        Me.Dp1Posição_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Dp1Posição_Y.Location = New System.Drawing.Point(164, 175)
        Me.Dp1Posição_Y.Name = "Dp1Posição_Y"
        Me.Dp1Posição_Y.PreencherZeroEsqueda = False
        Me.Dp1Posição_Y.RegraValidação = Nothing
        Me.Dp1Posição_Y.RegraValidaçãoMensagem = Nothing
        Me.Dp1Posição_Y.Size = New System.Drawing.Size(48, 21)
        Me.Dp1Posição_Y.TabIndex = 62
        Me.Dp1Posição_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dp1Posição_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Dp1Posição_Y.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(8, 180)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Col 1 Dp"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dp1Posição_X
        '
        Me.Dp1Posição_X.AceitaColarTexto = True
        Me.Dp1Posição_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Dp1Posição_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dp1Posição_X.CasasDecimais = 0
        Me.Dp1Posição_X.CPObrigatorio = False
        Me.Dp1Posição_X.CPObrigatorioMsg = Nothing
        Me.Dp1Posição_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Dp1Posição_X.FlatBorder = False
        Me.Dp1Posição_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Dp1Posição_X.FocusColor = System.Drawing.Color.Empty
        Me.Dp1Posição_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Dp1Posição_X.HighlightBorderOnEnter = False
        Me.Dp1Posição_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Dp1Posição_X.Location = New System.Drawing.Point(112, 175)
        Me.Dp1Posição_X.Name = "Dp1Posição_X"
        Me.Dp1Posição_X.PreencherZeroEsqueda = False
        Me.Dp1Posição_X.RegraValidação = Nothing
        Me.Dp1Posição_X.RegraValidaçãoMensagem = Nothing
        Me.Dp1Posição_X.Size = New System.Drawing.Size(48, 21)
        Me.Dp1Posição_X.TabIndex = 61
        Me.Dp1Posição_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dp1Posição_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Dp1Posição_X.ValorPadrao = Nothing
        '
        'ValorIpi_Y
        '
        Me.ValorIpi_Y.AceitaColarTexto = True
        Me.ValorIpi_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIpi_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorIpi_Y.CasasDecimais = 0
        Me.ValorIpi_Y.CPObrigatorio = False
        Me.ValorIpi_Y.CPObrigatorioMsg = Nothing
        Me.ValorIpi_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIpi_Y.FlatBorder = False
        Me.ValorIpi_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIpi_Y.FocusColor = System.Drawing.Color.Empty
        Me.ValorIpi_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIpi_Y.HighlightBorderOnEnter = False
        Me.ValorIpi_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIpi_Y.Location = New System.Drawing.Point(596, 280)
        Me.ValorIpi_Y.Name = "ValorIpi_Y"
        Me.ValorIpi_Y.PreencherZeroEsqueda = False
        Me.ValorIpi_Y.RegraValidação = Nothing
        Me.ValorIpi_Y.RegraValidaçãoMensagem = Nothing
        Me.ValorIpi_Y.Size = New System.Drawing.Size(48, 21)
        Me.ValorIpi_Y.TabIndex = 98
        Me.ValorIpi_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorIpi_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorIpi_Y.ValorPadrao = Nothing
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(440, 285)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(100, 16)
        Me.Label29.TabIndex = 96
        Me.Label29.Text = "Valor do Ipi"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ValorIpi_X
        '
        Me.ValorIpi_X.AceitaColarTexto = True
        Me.ValorIpi_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIpi_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorIpi_X.CasasDecimais = 0
        Me.ValorIpi_X.CPObrigatorio = False
        Me.ValorIpi_X.CPObrigatorioMsg = Nothing
        Me.ValorIpi_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIpi_X.FlatBorder = False
        Me.ValorIpi_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIpi_X.FocusColor = System.Drawing.Color.Empty
        Me.ValorIpi_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIpi_X.HighlightBorderOnEnter = False
        Me.ValorIpi_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIpi_X.Location = New System.Drawing.Point(544, 280)
        Me.ValorIpi_X.Name = "ValorIpi_X"
        Me.ValorIpi_X.PreencherZeroEsqueda = False
        Me.ValorIpi_X.RegraValidação = Nothing
        Me.ValorIpi_X.RegraValidaçãoMensagem = Nothing
        Me.ValorIpi_X.Size = New System.Drawing.Size(48, 21)
        Me.ValorIpi_X.TabIndex = 97
        Me.ValorIpi_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorIpi_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorIpi_X.ValorPadrao = Nothing
        '
        'Ipi_Y
        '
        Me.Ipi_Y.AceitaColarTexto = True
        Me.Ipi_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ipi_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ipi_Y.CasasDecimais = 0
        Me.Ipi_Y.CPObrigatorio = False
        Me.Ipi_Y.CPObrigatorioMsg = Nothing
        Me.Ipi_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ipi_Y.FlatBorder = False
        Me.Ipi_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Ipi_Y.FocusColor = System.Drawing.Color.Empty
        Me.Ipi_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ipi_Y.HighlightBorderOnEnter = False
        Me.Ipi_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Ipi_Y.Location = New System.Drawing.Point(380, 280)
        Me.Ipi_Y.Name = "Ipi_Y"
        Me.Ipi_Y.PreencherZeroEsqueda = False
        Me.Ipi_Y.RegraValidação = Nothing
        Me.Ipi_Y.RegraValidaçãoMensagem = Nothing
        Me.Ipi_Y.Size = New System.Drawing.Size(48, 21)
        Me.Ipi_Y.TabIndex = 95
        Me.Ipi_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ipi_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ipi_Y.ValorPadrao = Nothing
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(224, 285)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 16)
        Me.Label27.TabIndex = 93
        Me.Label27.Text = "Ipi"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ipi_X
        '
        Me.Ipi_X.AceitaColarTexto = True
        Me.Ipi_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ipi_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ipi_X.CasasDecimais = 0
        Me.Ipi_X.CPObrigatorio = False
        Me.Ipi_X.CPObrigatorioMsg = Nothing
        Me.Ipi_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ipi_X.FlatBorder = False
        Me.Ipi_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Ipi_X.FocusColor = System.Drawing.Color.Empty
        Me.Ipi_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ipi_X.HighlightBorderOnEnter = False
        Me.Ipi_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Ipi_X.Location = New System.Drawing.Point(328, 280)
        Me.Ipi_X.Name = "Ipi_X"
        Me.Ipi_X.PreencherZeroEsqueda = False
        Me.Ipi_X.RegraValidação = Nothing
        Me.Ipi_X.RegraValidaçãoMensagem = Nothing
        Me.Ipi_X.Size = New System.Drawing.Size(48, 21)
        Me.Ipi_X.TabIndex = 94
        Me.Ipi_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ipi_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ipi_X.ValorPadrao = Nothing
        '
        'Icms_Y
        '
        Me.Icms_Y.AceitaColarTexto = True
        Me.Icms_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Icms_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Icms_Y.CasasDecimais = 0
        Me.Icms_Y.CPObrigatorio = False
        Me.Icms_Y.CPObrigatorioMsg = Nothing
        Me.Icms_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Icms_Y.FlatBorder = False
        Me.Icms_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Icms_Y.FocusColor = System.Drawing.Color.Empty
        Me.Icms_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Icms_Y.HighlightBorderOnEnter = False
        Me.Icms_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Icms_Y.Location = New System.Drawing.Point(164, 280)
        Me.Icms_Y.Name = "Icms_Y"
        Me.Icms_Y.PreencherZeroEsqueda = False
        Me.Icms_Y.RegraValidação = Nothing
        Me.Icms_Y.RegraValidaçãoMensagem = Nothing
        Me.Icms_Y.Size = New System.Drawing.Size(48, 21)
        Me.Icms_Y.TabIndex = 92
        Me.Icms_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Icms_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Icms_Y.ValorPadrao = Nothing
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(8, 285)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 90
        Me.Label28.Text = "Icms"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Icms_X
        '
        Me.Icms_X.AceitaColarTexto = True
        Me.Icms_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Icms_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Icms_X.CasasDecimais = 0
        Me.Icms_X.CPObrigatorio = False
        Me.Icms_X.CPObrigatorioMsg = Nothing
        Me.Icms_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Icms_X.FlatBorder = False
        Me.Icms_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Icms_X.FocusColor = System.Drawing.Color.Empty
        Me.Icms_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Icms_X.HighlightBorderOnEnter = False
        Me.Icms_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Icms_X.Location = New System.Drawing.Point(112, 280)
        Me.Icms_X.Name = "Icms_X"
        Me.Icms_X.PreencherZeroEsqueda = False
        Me.Icms_X.RegraValidação = Nothing
        Me.Icms_X.RegraValidaçãoMensagem = Nothing
        Me.Icms_X.Size = New System.Drawing.Size(48, 21)
        Me.Icms_X.TabIndex = 91
        Me.Icms_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Icms_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Icms_X.ValorPadrao = Nothing
        '
        'Total_Y
        '
        Me.Total_Y.AceitaColarTexto = True
        Me.Total_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Total_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Total_Y.CasasDecimais = 0
        Me.Total_Y.CPObrigatorio = False
        Me.Total_Y.CPObrigatorioMsg = Nothing
        Me.Total_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Total_Y.FlatBorder = False
        Me.Total_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Total_Y.FocusColor = System.Drawing.Color.Empty
        Me.Total_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total_Y.HighlightBorderOnEnter = False
        Me.Total_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Total_Y.Location = New System.Drawing.Point(596, 255)
        Me.Total_Y.Name = "Total_Y"
        Me.Total_Y.PreencherZeroEsqueda = False
        Me.Total_Y.RegraValidação = Nothing
        Me.Total_Y.RegraValidaçãoMensagem = Nothing
        Me.Total_Y.Size = New System.Drawing.Size(48, 21)
        Me.Total_Y.TabIndex = 89
        Me.Total_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Total_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Total_Y.ValorPadrao = Nothing
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(440, 260)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 16)
        Me.Label26.TabIndex = 87
        Me.Label26.Text = "Valor Total"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Total_X
        '
        Me.Total_X.AceitaColarTexto = True
        Me.Total_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Total_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Total_X.CasasDecimais = 0
        Me.Total_X.CPObrigatorio = False
        Me.Total_X.CPObrigatorioMsg = Nothing
        Me.Total_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Total_X.FlatBorder = False
        Me.Total_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Total_X.FocusColor = System.Drawing.Color.Empty
        Me.Total_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total_X.HighlightBorderOnEnter = False
        Me.Total_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Total_X.Location = New System.Drawing.Point(544, 255)
        Me.Total_X.Name = "Total_X"
        Me.Total_X.PreencherZeroEsqueda = False
        Me.Total_X.RegraValidação = Nothing
        Me.Total_X.RegraValidaçãoMensagem = Nothing
        Me.Total_X.Size = New System.Drawing.Size(48, 21)
        Me.Total_X.TabIndex = 88
        Me.Total_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Total_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Total_X.ValorPadrao = Nothing
        '
        'Unitario_Y
        '
        Me.Unitario_Y.AceitaColarTexto = True
        Me.Unitario_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Unitario_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Unitario_Y.CasasDecimais = 0
        Me.Unitario_Y.CPObrigatorio = False
        Me.Unitario_Y.CPObrigatorioMsg = Nothing
        Me.Unitario_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Unitario_Y.FlatBorder = False
        Me.Unitario_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Unitario_Y.FocusColor = System.Drawing.Color.Empty
        Me.Unitario_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Unitario_Y.HighlightBorderOnEnter = False
        Me.Unitario_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Unitario_Y.Location = New System.Drawing.Point(380, 255)
        Me.Unitario_Y.Name = "Unitario_Y"
        Me.Unitario_Y.PreencherZeroEsqueda = False
        Me.Unitario_Y.RegraValidação = Nothing
        Me.Unitario_Y.RegraValidaçãoMensagem = Nothing
        Me.Unitario_Y.Size = New System.Drawing.Size(48, 21)
        Me.Unitario_Y.TabIndex = 86
        Me.Unitario_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Unitario_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Unitario_Y.ValorPadrao = Nothing
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(224, 260)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 16)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Valor Unitário"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Unitario_X
        '
        Me.Unitario_X.AceitaColarTexto = True
        Me.Unitario_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Unitario_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Unitario_X.CasasDecimais = 0
        Me.Unitario_X.CPObrigatorio = False
        Me.Unitario_X.CPObrigatorioMsg = Nothing
        Me.Unitario_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Unitario_X.FlatBorder = False
        Me.Unitario_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Unitario_X.FocusColor = System.Drawing.Color.Empty
        Me.Unitario_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Unitario_X.HighlightBorderOnEnter = False
        Me.Unitario_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Unitario_X.Location = New System.Drawing.Point(328, 255)
        Me.Unitario_X.Name = "Unitario_X"
        Me.Unitario_X.PreencherZeroEsqueda = False
        Me.Unitario_X.RegraValidação = Nothing
        Me.Unitario_X.RegraValidaçãoMensagem = Nothing
        Me.Unitario_X.Size = New System.Drawing.Size(48, 21)
        Me.Unitario_X.TabIndex = 85
        Me.Unitario_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Unitario_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Unitario_X.ValorPadrao = Nothing
        '
        'Qtd_Y
        '
        Me.Qtd_Y.AceitaColarTexto = True
        Me.Qtd_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Qtd_Y.CasasDecimais = 0
        Me.Qtd_Y.CPObrigatorio = False
        Me.Qtd_Y.CPObrigatorioMsg = Nothing
        Me.Qtd_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd_Y.FlatBorder = False
        Me.Qtd_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Qtd_Y.FocusColor = System.Drawing.Color.Empty
        Me.Qtd_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd_Y.HighlightBorderOnEnter = False
        Me.Qtd_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtd_Y.Location = New System.Drawing.Point(164, 255)
        Me.Qtd_Y.Name = "Qtd_Y"
        Me.Qtd_Y.PreencherZeroEsqueda = False
        Me.Qtd_Y.RegraValidação = Nothing
        Me.Qtd_Y.RegraValidaçãoMensagem = Nothing
        Me.Qtd_Y.Size = New System.Drawing.Size(48, 21)
        Me.Qtd_Y.TabIndex = 83
        Me.Qtd_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Qtd_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Qtd_Y.ValorPadrao = Nothing
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(8, 260)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 16)
        Me.Label24.TabIndex = 81
        Me.Label24.Text = "Quantidade"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Qtd_X
        '
        Me.Qtd_X.AceitaColarTexto = True
        Me.Qtd_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Qtd_X.CasasDecimais = 0
        Me.Qtd_X.CPObrigatorio = False
        Me.Qtd_X.CPObrigatorioMsg = Nothing
        Me.Qtd_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd_X.FlatBorder = False
        Me.Qtd_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Qtd_X.FocusColor = System.Drawing.Color.Empty
        Me.Qtd_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd_X.HighlightBorderOnEnter = False
        Me.Qtd_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtd_X.Location = New System.Drawing.Point(112, 255)
        Me.Qtd_X.Name = "Qtd_X"
        Me.Qtd_X.PreencherZeroEsqueda = False
        Me.Qtd_X.RegraValidação = Nothing
        Me.Qtd_X.RegraValidaçãoMensagem = Nothing
        Me.Qtd_X.Size = New System.Drawing.Size(48, 21)
        Me.Qtd_X.TabIndex = 82
        Me.Qtd_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Qtd_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Qtd_X.ValorPadrao = Nothing
        '
        'Unid_Y
        '
        Me.Unid_Y.AceitaColarTexto = True
        Me.Unid_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Unid_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Unid_Y.CasasDecimais = 0
        Me.Unid_Y.CPObrigatorio = False
        Me.Unid_Y.CPObrigatorioMsg = Nothing
        Me.Unid_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Unid_Y.FlatBorder = False
        Me.Unid_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Unid_Y.FocusColor = System.Drawing.Color.Empty
        Me.Unid_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Unid_Y.HighlightBorderOnEnter = False
        Me.Unid_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Unid_Y.Location = New System.Drawing.Point(596, 205)
        Me.Unid_Y.Name = "Unid_Y"
        Me.Unid_Y.PreencherZeroEsqueda = False
        Me.Unid_Y.RegraValidação = Nothing
        Me.Unid_Y.RegraValidaçãoMensagem = Nothing
        Me.Unid_Y.Size = New System.Drawing.Size(48, 21)
        Me.Unid_Y.TabIndex = 77
        Me.Unid_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Unid_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Unid_Y.ValorPadrao = Nothing
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(440, 210)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 16)
        Me.Label23.TabIndex = 75
        Me.Label23.Text = "Unidade Medida"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Unid_X
        '
        Me.Unid_X.AceitaColarTexto = True
        Me.Unid_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Unid_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Unid_X.CasasDecimais = 0
        Me.Unid_X.CPObrigatorio = False
        Me.Unid_X.CPObrigatorioMsg = Nothing
        Me.Unid_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Unid_X.FlatBorder = False
        Me.Unid_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Unid_X.FocusColor = System.Drawing.Color.Empty
        Me.Unid_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Unid_X.HighlightBorderOnEnter = False
        Me.Unid_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Unid_X.Location = New System.Drawing.Point(544, 205)
        Me.Unid_X.Name = "Unid_X"
        Me.Unid_X.PreencherZeroEsqueda = False
        Me.Unid_X.RegraValidação = Nothing
        Me.Unid_X.RegraValidaçãoMensagem = Nothing
        Me.Unid_X.Size = New System.Drawing.Size(48, 21)
        Me.Unid_X.TabIndex = 76
        Me.Unid_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Unid_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Unid_X.ValorPadrao = Nothing
        '
        'Cf_Y
        '
        Me.Cf_Y.AceitaColarTexto = True
        Me.Cf_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cf_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cf_Y.CasasDecimais = 0
        Me.Cf_Y.CPObrigatorio = False
        Me.Cf_Y.CPObrigatorioMsg = Nothing
        Me.Cf_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cf_Y.FlatBorder = False
        Me.Cf_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cf_Y.FocusColor = System.Drawing.Color.Empty
        Me.Cf_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cf_Y.HighlightBorderOnEnter = False
        Me.Cf_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cf_Y.Location = New System.Drawing.Point(380, 205)
        Me.Cf_Y.Name = "Cf_Y"
        Me.Cf_Y.PreencherZeroEsqueda = False
        Me.Cf_Y.RegraValidação = Nothing
        Me.Cf_Y.RegraValidaçãoMensagem = Nothing
        Me.Cf_Y.Size = New System.Drawing.Size(48, 21)
        Me.Cf_Y.TabIndex = 74
        Me.Cf_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cf_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cf_Y.ValorPadrao = Nothing
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(224, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 16)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Clas. Fiscal"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cf_X
        '
        Me.Cf_X.AceitaColarTexto = True
        Me.Cf_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cf_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cf_X.CasasDecimais = 0
        Me.Cf_X.CPObrigatorio = False
        Me.Cf_X.CPObrigatorioMsg = Nothing
        Me.Cf_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cf_X.FlatBorder = False
        Me.Cf_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cf_X.FocusColor = System.Drawing.Color.Empty
        Me.Cf_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cf_X.HighlightBorderOnEnter = False
        Me.Cf_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cf_X.Location = New System.Drawing.Point(328, 205)
        Me.Cf_X.Name = "Cf_X"
        Me.Cf_X.PreencherZeroEsqueda = False
        Me.Cf_X.RegraValidação = Nothing
        Me.Cf_X.RegraValidaçãoMensagem = Nothing
        Me.Cf_X.Size = New System.Drawing.Size(48, 21)
        Me.Cf_X.TabIndex = 73
        Me.Cf_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cf_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cf_X.ValorPadrao = Nothing
        '
        'DescItens_Y
        '
        Me.DescItens_Y.AceitaColarTexto = True
        Me.DescItens_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescItens_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescItens_Y.CasasDecimais = 0
        Me.DescItens_Y.CPObrigatorio = False
        Me.DescItens_Y.CPObrigatorioMsg = Nothing
        Me.DescItens_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescItens_Y.FlatBorder = False
        Me.DescItens_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescItens_Y.FocusColor = System.Drawing.Color.Empty
        Me.DescItens_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescItens_Y.HighlightBorderOnEnter = False
        Me.DescItens_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescItens_Y.Location = New System.Drawing.Point(164, 205)
        Me.DescItens_Y.Name = "DescItens_Y"
        Me.DescItens_Y.PreencherZeroEsqueda = False
        Me.DescItens_Y.RegraValidação = Nothing
        Me.DescItens_Y.RegraValidaçãoMensagem = Nothing
        Me.DescItens_Y.Size = New System.Drawing.Size(48, 21)
        Me.DescItens_Y.TabIndex = 71
        Me.DescItens_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DescItens_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescItens_Y.ValorPadrao = Nothing
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 210)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 16)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Descrição Itens"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DescItens_X
        '
        Me.DescItens_X.AceitaColarTexto = True
        Me.DescItens_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescItens_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescItens_X.CasasDecimais = 0
        Me.DescItens_X.CPObrigatorio = False
        Me.DescItens_X.CPObrigatorioMsg = Nothing
        Me.DescItens_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescItens_X.FlatBorder = False
        Me.DescItens_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescItens_X.FocusColor = System.Drawing.Color.Empty
        Me.DescItens_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescItens_X.HighlightBorderOnEnter = False
        Me.DescItens_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescItens_X.Location = New System.Drawing.Point(112, 205)
        Me.DescItens_X.Name = "DescItens_X"
        Me.DescItens_X.PreencherZeroEsqueda = False
        Me.DescItens_X.RegraValidação = Nothing
        Me.DescItens_X.RegraValidaçãoMensagem = Nothing
        Me.DescItens_X.Size = New System.Drawing.Size(48, 21)
        Me.DescItens_X.TabIndex = 70
        Me.DescItens_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DescItens_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescItens_X.ValorPadrao = Nothing
        '
        'TotalNota_Y
        '
        Me.TotalNota_Y.AceitaColarTexto = True
        Me.TotalNota_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalNota_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalNota_Y.CasasDecimais = 0
        Me.TotalNota_Y.CPObrigatorio = False
        Me.TotalNota_Y.CPObrigatorioMsg = Nothing
        Me.TotalNota_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalNota_Y.FlatBorder = False
        Me.TotalNota_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalNota_Y.FocusColor = System.Drawing.Color.Empty
        Me.TotalNota_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalNota_Y.HighlightBorderOnEnter = False
        Me.TotalNota_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalNota_Y.Location = New System.Drawing.Point(380, 335)
        Me.TotalNota_Y.Name = "TotalNota_Y"
        Me.TotalNota_Y.PreencherZeroEsqueda = False
        Me.TotalNota_Y.RegraValidação = Nothing
        Me.TotalNota_Y.RegraValidaçãoMensagem = Nothing
        Me.TotalNota_Y.Size = New System.Drawing.Size(48, 21)
        Me.TotalNota_Y.TabIndex = 113
        Me.TotalNota_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalNota_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TotalNota_Y.ValorPadrao = Nothing
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(224, 335)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(100, 16)
        Me.Label38.TabIndex = 111
        Me.Label38.Text = "Total da Nota"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalNota_X
        '
        Me.TotalNota_X.AceitaColarTexto = True
        Me.TotalNota_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalNota_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalNota_X.CasasDecimais = 0
        Me.TotalNota_X.CPObrigatorio = False
        Me.TotalNota_X.CPObrigatorioMsg = Nothing
        Me.TotalNota_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalNota_X.FlatBorder = False
        Me.TotalNota_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalNota_X.FocusColor = System.Drawing.Color.Empty
        Me.TotalNota_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalNota_X.HighlightBorderOnEnter = False
        Me.TotalNota_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalNota_X.Location = New System.Drawing.Point(328, 335)
        Me.TotalNota_X.Name = "TotalNota_X"
        Me.TotalNota_X.PreencherZeroEsqueda = False
        Me.TotalNota_X.RegraValidação = Nothing
        Me.TotalNota_X.RegraValidaçãoMensagem = Nothing
        Me.TotalNota_X.Size = New System.Drawing.Size(48, 21)
        Me.TotalNota_X.TabIndex = 112
        Me.TotalNota_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalNota_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TotalNota_X.ValorPadrao = Nothing
        '
        'TotalIpi_Y
        '
        Me.TotalIpi_Y.AceitaColarTexto = True
        Me.TotalIpi_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalIpi_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalIpi_Y.CasasDecimais = 0
        Me.TotalIpi_Y.CPObrigatorio = False
        Me.TotalIpi_Y.CPObrigatorioMsg = Nothing
        Me.TotalIpi_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalIpi_Y.FlatBorder = False
        Me.TotalIpi_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalIpi_Y.FocusColor = System.Drawing.Color.Empty
        Me.TotalIpi_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalIpi_Y.HighlightBorderOnEnter = False
        Me.TotalIpi_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalIpi_Y.Location = New System.Drawing.Point(164, 335)
        Me.TotalIpi_Y.Name = "TotalIpi_Y"
        Me.TotalIpi_Y.PreencherZeroEsqueda = False
        Me.TotalIpi_Y.RegraValidação = Nothing
        Me.TotalIpi_Y.RegraValidaçãoMensagem = Nothing
        Me.TotalIpi_Y.Size = New System.Drawing.Size(48, 21)
        Me.TotalIpi_Y.TabIndex = 110
        Me.TotalIpi_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalIpi_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TotalIpi_Y.ValorPadrao = Nothing
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(8, 335)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(100, 16)
        Me.Label39.TabIndex = 108
        Me.Label39.Text = "Total do Ipi"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalIpi_X
        '
        Me.TotalIpi_X.AceitaColarTexto = True
        Me.TotalIpi_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalIpi_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalIpi_X.CasasDecimais = 0
        Me.TotalIpi_X.CPObrigatorio = False
        Me.TotalIpi_X.CPObrigatorioMsg = Nothing
        Me.TotalIpi_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalIpi_X.FlatBorder = False
        Me.TotalIpi_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalIpi_X.FocusColor = System.Drawing.Color.Empty
        Me.TotalIpi_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalIpi_X.HighlightBorderOnEnter = False
        Me.TotalIpi_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalIpi_X.Location = New System.Drawing.Point(112, 335)
        Me.TotalIpi_X.Name = "TotalIpi_X"
        Me.TotalIpi_X.PreencherZeroEsqueda = False
        Me.TotalIpi_X.RegraValidação = Nothing
        Me.TotalIpi_X.RegraValidaçãoMensagem = Nothing
        Me.TotalIpi_X.Size = New System.Drawing.Size(48, 21)
        Me.TotalIpi_X.TabIndex = 109
        Me.TotalIpi_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalIpi_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TotalIpi_X.ValorPadrao = Nothing
        '
        'TotalProdutos_Y
        '
        Me.TotalProdutos_Y.AceitaColarTexto = True
        Me.TotalProdutos_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalProdutos_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalProdutos_Y.CasasDecimais = 0
        Me.TotalProdutos_Y.CPObrigatorio = False
        Me.TotalProdutos_Y.CPObrigatorioMsg = Nothing
        Me.TotalProdutos_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalProdutos_Y.FlatBorder = False
        Me.TotalProdutos_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalProdutos_Y.FocusColor = System.Drawing.Color.Empty
        Me.TotalProdutos_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalProdutos_Y.HighlightBorderOnEnter = False
        Me.TotalProdutos_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalProdutos_Y.Location = New System.Drawing.Point(596, 310)
        Me.TotalProdutos_Y.Name = "TotalProdutos_Y"
        Me.TotalProdutos_Y.PreencherZeroEsqueda = False
        Me.TotalProdutos_Y.RegraValidação = Nothing
        Me.TotalProdutos_Y.RegraValidaçãoMensagem = Nothing
        Me.TotalProdutos_Y.Size = New System.Drawing.Size(48, 21)
        Me.TotalProdutos_Y.TabIndex = 107
        Me.TotalProdutos_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalProdutos_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TotalProdutos_Y.ValorPadrao = Nothing
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(440, 315)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(100, 16)
        Me.Label40.TabIndex = 105
        Me.Label40.Text = "Total dos Produtos"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalProdutos_X
        '
        Me.TotalProdutos_X.AceitaColarTexto = True
        Me.TotalProdutos_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalProdutos_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalProdutos_X.CasasDecimais = 0
        Me.TotalProdutos_X.CPObrigatorio = False
        Me.TotalProdutos_X.CPObrigatorioMsg = Nothing
        Me.TotalProdutos_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalProdutos_X.FlatBorder = False
        Me.TotalProdutos_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalProdutos_X.FocusColor = System.Drawing.Color.Empty
        Me.TotalProdutos_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalProdutos_X.HighlightBorderOnEnter = False
        Me.TotalProdutos_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalProdutos_X.Location = New System.Drawing.Point(544, 310)
        Me.TotalProdutos_X.Name = "TotalProdutos_X"
        Me.TotalProdutos_X.PreencherZeroEsqueda = False
        Me.TotalProdutos_X.RegraValidação = Nothing
        Me.TotalProdutos_X.RegraValidaçãoMensagem = Nothing
        Me.TotalProdutos_X.Size = New System.Drawing.Size(48, 21)
        Me.TotalProdutos_X.TabIndex = 106
        Me.TotalProdutos_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalProdutos_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TotalProdutos_X.ValorPadrao = Nothing
        '
        'ValorIcms_Y
        '
        Me.ValorIcms_Y.AceitaColarTexto = True
        Me.ValorIcms_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIcms_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorIcms_Y.CasasDecimais = 0
        Me.ValorIcms_Y.CPObrigatorio = False
        Me.ValorIcms_Y.CPObrigatorioMsg = Nothing
        Me.ValorIcms_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIcms_Y.FlatBorder = False
        Me.ValorIcms_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIcms_Y.FocusColor = System.Drawing.Color.Empty
        Me.ValorIcms_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIcms_Y.HighlightBorderOnEnter = False
        Me.ValorIcms_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIcms_Y.Location = New System.Drawing.Point(380, 310)
        Me.ValorIcms_Y.Name = "ValorIcms_Y"
        Me.ValorIcms_Y.PreencherZeroEsqueda = False
        Me.ValorIcms_Y.RegraValidação = Nothing
        Me.ValorIcms_Y.RegraValidaçãoMensagem = Nothing
        Me.ValorIcms_Y.Size = New System.Drawing.Size(48, 21)
        Me.ValorIcms_Y.TabIndex = 104
        Me.ValorIcms_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorIcms_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorIcms_Y.ValorPadrao = Nothing
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(224, 315)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(100, 16)
        Me.Label41.TabIndex = 102
        Me.Label41.Text = "Valor Icms"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ValorIcms_X
        '
        Me.ValorIcms_X.AceitaColarTexto = True
        Me.ValorIcms_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIcms_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorIcms_X.CasasDecimais = 0
        Me.ValorIcms_X.CPObrigatorio = False
        Me.ValorIcms_X.CPObrigatorioMsg = Nothing
        Me.ValorIcms_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIcms_X.FlatBorder = False
        Me.ValorIcms_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIcms_X.FocusColor = System.Drawing.Color.Empty
        Me.ValorIcms_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIcms_X.HighlightBorderOnEnter = False
        Me.ValorIcms_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIcms_X.Location = New System.Drawing.Point(328, 310)
        Me.ValorIcms_X.Name = "ValorIcms_X"
        Me.ValorIcms_X.PreencherZeroEsqueda = False
        Me.ValorIcms_X.RegraValidação = Nothing
        Me.ValorIcms_X.RegraValidaçãoMensagem = Nothing
        Me.ValorIcms_X.Size = New System.Drawing.Size(48, 21)
        Me.ValorIcms_X.TabIndex = 103
        Me.ValorIcms_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorIcms_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorIcms_X.ValorPadrao = Nothing
        '
        'BaseCalcIcms_Y
        '
        Me.BaseCalcIcms_Y.AceitaColarTexto = True
        Me.BaseCalcIcms_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BaseCalcIcms_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BaseCalcIcms_Y.CasasDecimais = 0
        Me.BaseCalcIcms_Y.CPObrigatorio = False
        Me.BaseCalcIcms_Y.CPObrigatorioMsg = Nothing
        Me.BaseCalcIcms_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BaseCalcIcms_Y.FlatBorder = False
        Me.BaseCalcIcms_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcms_Y.FocusColor = System.Drawing.Color.Empty
        Me.BaseCalcIcms_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.BaseCalcIcms_Y.HighlightBorderOnEnter = False
        Me.BaseCalcIcms_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcms_Y.Location = New System.Drawing.Point(164, 310)
        Me.BaseCalcIcms_Y.Name = "BaseCalcIcms_Y"
        Me.BaseCalcIcms_Y.PreencherZeroEsqueda = False
        Me.BaseCalcIcms_Y.RegraValidação = Nothing
        Me.BaseCalcIcms_Y.RegraValidaçãoMensagem = Nothing
        Me.BaseCalcIcms_Y.Size = New System.Drawing.Size(48, 21)
        Me.BaseCalcIcms_Y.TabIndex = 101
        Me.BaseCalcIcms_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BaseCalcIcms_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BaseCalcIcms_Y.ValorPadrao = Nothing
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(8, 315)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(100, 16)
        Me.Label42.TabIndex = 99
        Me.Label42.Text = "Base Calc Icms"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BaseCalcIcms_X
        '
        Me.BaseCalcIcms_X.AceitaColarTexto = True
        Me.BaseCalcIcms_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BaseCalcIcms_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BaseCalcIcms_X.CasasDecimais = 0
        Me.BaseCalcIcms_X.CPObrigatorio = False
        Me.BaseCalcIcms_X.CPObrigatorioMsg = Nothing
        Me.BaseCalcIcms_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BaseCalcIcms_X.FlatBorder = False
        Me.BaseCalcIcms_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcms_X.FocusColor = System.Drawing.Color.Empty
        Me.BaseCalcIcms_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.BaseCalcIcms_X.HighlightBorderOnEnter = False
        Me.BaseCalcIcms_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcms_X.Location = New System.Drawing.Point(112, 310)
        Me.BaseCalcIcms_X.Name = "BaseCalcIcms_X"
        Me.BaseCalcIcms_X.PreencherZeroEsqueda = False
        Me.BaseCalcIcms_X.RegraValidação = Nothing
        Me.BaseCalcIcms_X.RegraValidaçãoMensagem = Nothing
        Me.BaseCalcIcms_X.Size = New System.Drawing.Size(48, 21)
        Me.BaseCalcIcms_X.TabIndex = 100
        Me.BaseCalcIcms_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BaseCalcIcms_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BaseCalcIcms_X.ValorPadrao = Nothing
        '
        'Desconto_Y
        '
        Me.Desconto_Y.AceitaColarTexto = True
        Me.Desconto_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Desconto_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Desconto_Y.CasasDecimais = 0
        Me.Desconto_Y.CPObrigatorio = False
        Me.Desconto_Y.CPObrigatorioMsg = Nothing
        Me.Desconto_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Desconto_Y.FlatBorder = False
        Me.Desconto_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Desconto_Y.FocusColor = System.Drawing.Color.Empty
        Me.Desconto_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desconto_Y.HighlightBorderOnEnter = False
        Me.Desconto_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Desconto_Y.Location = New System.Drawing.Point(384, 489)
        Me.Desconto_Y.Name = "Desconto_Y"
        Me.Desconto_Y.PreencherZeroEsqueda = False
        Me.Desconto_Y.RegraValidação = Nothing
        Me.Desconto_Y.RegraValidaçãoMensagem = Nothing
        Me.Desconto_Y.Size = New System.Drawing.Size(48, 21)
        Me.Desconto_Y.TabIndex = 157
        Me.Desconto_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Desconto_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Desconto_Y.ValorPadrao = Nothing
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(224, 489)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(100, 16)
        Me.Label46.TabIndex = 155
        Me.Label46.Text = "Desconto"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Desconto_X
        '
        Me.Desconto_X.AceitaColarTexto = True
        Me.Desconto_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Desconto_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Desconto_X.CasasDecimais = 0
        Me.Desconto_X.CPObrigatorio = False
        Me.Desconto_X.CPObrigatorioMsg = Nothing
        Me.Desconto_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Desconto_X.FlatBorder = False
        Me.Desconto_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Desconto_X.FocusColor = System.Drawing.Color.Empty
        Me.Desconto_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desconto_X.HighlightBorderOnEnter = False
        Me.Desconto_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Desconto_X.Location = New System.Drawing.Point(329, 489)
        Me.Desconto_X.Name = "Desconto_X"
        Me.Desconto_X.PreencherZeroEsqueda = False
        Me.Desconto_X.RegraValidação = Nothing
        Me.Desconto_X.RegraValidaçãoMensagem = Nothing
        Me.Desconto_X.Size = New System.Drawing.Size(48, 21)
        Me.Desconto_X.TabIndex = 156
        Me.Desconto_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Desconto_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Desconto_X.ValorPadrao = Nothing
        '
        'NumeroNota2_Y
        '
        Me.NumeroNota2_Y.AceitaColarTexto = True
        Me.NumeroNota2_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NumeroNota2_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroNota2_Y.CasasDecimais = 0
        Me.NumeroNota2_Y.CPObrigatorio = False
        Me.NumeroNota2_Y.CPObrigatorioMsg = Nothing
        Me.NumeroNota2_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NumeroNota2_Y.FlatBorder = False
        Me.NumeroNota2_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NumeroNota2_Y.FocusColor = System.Drawing.Color.Empty
        Me.NumeroNota2_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroNota2_Y.HighlightBorderOnEnter = False
        Me.NumeroNota2_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NumeroNota2_Y.Location = New System.Drawing.Point(164, 489)
        Me.NumeroNota2_Y.Name = "NumeroNota2_Y"
        Me.NumeroNota2_Y.PreencherZeroEsqueda = False
        Me.NumeroNota2_Y.RegraValidação = Nothing
        Me.NumeroNota2_Y.RegraValidaçãoMensagem = Nothing
        Me.NumeroNota2_Y.Size = New System.Drawing.Size(48, 21)
        Me.NumeroNota2_Y.TabIndex = 154
        Me.NumeroNota2_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroNota2_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroNota2_Y.ValorPadrao = Nothing
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(9, 489)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(100, 16)
        Me.Label45.TabIndex = 152
        Me.Label45.Text = "Numero da Nota"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumeroNota2_X
        '
        Me.NumeroNota2_X.AceitaColarTexto = True
        Me.NumeroNota2_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NumeroNota2_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroNota2_X.CasasDecimais = 0
        Me.NumeroNota2_X.CPObrigatorio = False
        Me.NumeroNota2_X.CPObrigatorioMsg = Nothing
        Me.NumeroNota2_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NumeroNota2_X.FlatBorder = False
        Me.NumeroNota2_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NumeroNota2_X.FocusColor = System.Drawing.Color.Empty
        Me.NumeroNota2_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroNota2_X.HighlightBorderOnEnter = False
        Me.NumeroNota2_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NumeroNota2_X.Location = New System.Drawing.Point(114, 489)
        Me.NumeroNota2_X.Name = "NumeroNota2_X"
        Me.NumeroNota2_X.PreencherZeroEsqueda = False
        Me.NumeroNota2_X.RegraValidação = Nothing
        Me.NumeroNota2_X.RegraValidaçãoMensagem = Nothing
        Me.NumeroNota2_X.Size = New System.Drawing.Size(48, 21)
        Me.NumeroNota2_X.TabIndex = 153
        Me.NumeroNota2_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroNota2_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroNota2_X.ValorPadrao = Nothing
        '
        'Observacao_Y
        '
        Me.Observacao_Y.AceitaColarTexto = True
        Me.Observacao_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Observacao_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Observacao_Y.CasasDecimais = 0
        Me.Observacao_Y.CPObrigatorio = False
        Me.Observacao_Y.CPObrigatorioMsg = Nothing
        Me.Observacao_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Observacao_Y.FlatBorder = False
        Me.Observacao_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Observacao_Y.FocusColor = System.Drawing.Color.Empty
        Me.Observacao_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Observacao_Y.HighlightBorderOnEnter = False
        Me.Observacao_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Observacao_Y.Location = New System.Drawing.Point(599, 435)
        Me.Observacao_Y.Name = "Observacao_Y"
        Me.Observacao_Y.PreencherZeroEsqueda = False
        Me.Observacao_Y.RegraValidação = Nothing
        Me.Observacao_Y.RegraValidaçãoMensagem = Nothing
        Me.Observacao_Y.Size = New System.Drawing.Size(48, 21)
        Me.Observacao_Y.TabIndex = 145
        Me.Observacao_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Observacao_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Observacao_Y.ValorPadrao = Nothing
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(444, 440)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(100, 16)
        Me.Label44.TabIndex = 143
        Me.Label44.Text = "Observação"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Observacao_X
        '
        Me.Observacao_X.AceitaColarTexto = True
        Me.Observacao_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Observacao_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Observacao_X.CasasDecimais = 0
        Me.Observacao_X.CPObrigatorio = False
        Me.Observacao_X.CPObrigatorioMsg = Nothing
        Me.Observacao_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Observacao_X.FlatBorder = False
        Me.Observacao_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Observacao_X.FocusColor = System.Drawing.Color.Empty
        Me.Observacao_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Observacao_X.HighlightBorderOnEnter = False
        Me.Observacao_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Observacao_X.Location = New System.Drawing.Point(544, 435)
        Me.Observacao_X.Name = "Observacao_X"
        Me.Observacao_X.PreencherZeroEsqueda = False
        Me.Observacao_X.RegraValidação = Nothing
        Me.Observacao_X.RegraValidaçãoMensagem = Nothing
        Me.Observacao_X.Size = New System.Drawing.Size(48, 21)
        Me.Observacao_X.TabIndex = 144
        Me.Observacao_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Observacao_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Observacao_X.ValorPadrao = Nothing
        '
        'IncricaoTransportadora_Y
        '
        Me.IncricaoTransportadora_Y.AceitaColarTexto = True
        Me.IncricaoTransportadora_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IncricaoTransportadora_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IncricaoTransportadora_Y.CasasDecimais = 0
        Me.IncricaoTransportadora_Y.CPObrigatorio = False
        Me.IncricaoTransportadora_Y.CPObrigatorioMsg = Nothing
        Me.IncricaoTransportadora_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IncricaoTransportadora_Y.FlatBorder = False
        Me.IncricaoTransportadora_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IncricaoTransportadora_Y.FocusColor = System.Drawing.Color.Empty
        Me.IncricaoTransportadora_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.IncricaoTransportadora_Y.HighlightBorderOnEnter = False
        Me.IncricaoTransportadora_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IncricaoTransportadora_Y.Location = New System.Drawing.Point(384, 435)
        Me.IncricaoTransportadora_Y.Name = "IncricaoTransportadora_Y"
        Me.IncricaoTransportadora_Y.PreencherZeroEsqueda = False
        Me.IncricaoTransportadora_Y.RegraValidação = Nothing
        Me.IncricaoTransportadora_Y.RegraValidaçãoMensagem = Nothing
        Me.IncricaoTransportadora_Y.Size = New System.Drawing.Size(48, 21)
        Me.IncricaoTransportadora_Y.TabIndex = 142
        Me.IncricaoTransportadora_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IncricaoTransportadora_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IncricaoTransportadora_Y.ValorPadrao = Nothing
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(224, 440)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(100, 16)
        Me.Label34.TabIndex = 140
        Me.Label34.Text = "Inscrição Estadual"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IncricaoTransportadora_X
        '
        Me.IncricaoTransportadora_X.AceitaColarTexto = True
        Me.IncricaoTransportadora_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IncricaoTransportadora_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IncricaoTransportadora_X.CasasDecimais = 0
        Me.IncricaoTransportadora_X.CPObrigatorio = False
        Me.IncricaoTransportadora_X.CPObrigatorioMsg = Nothing
        Me.IncricaoTransportadora_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IncricaoTransportadora_X.FlatBorder = False
        Me.IncricaoTransportadora_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IncricaoTransportadora_X.FocusColor = System.Drawing.Color.Empty
        Me.IncricaoTransportadora_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.IncricaoTransportadora_X.HighlightBorderOnEnter = False
        Me.IncricaoTransportadora_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IncricaoTransportadora_X.Location = New System.Drawing.Point(329, 435)
        Me.IncricaoTransportadora_X.Name = "IncricaoTransportadora_X"
        Me.IncricaoTransportadora_X.PreencherZeroEsqueda = False
        Me.IncricaoTransportadora_X.RegraValidação = Nothing
        Me.IncricaoTransportadora_X.RegraValidaçãoMensagem = Nothing
        Me.IncricaoTransportadora_X.Size = New System.Drawing.Size(48, 21)
        Me.IncricaoTransportadora_X.TabIndex = 141
        Me.IncricaoTransportadora_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IncricaoTransportadora_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IncricaoTransportadora_X.ValorPadrao = Nothing
        '
        'UfTransportadora_Y
        '
        Me.UfTransportadora_Y.AceitaColarTexto = True
        Me.UfTransportadora_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.UfTransportadora_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UfTransportadora_Y.CasasDecimais = 0
        Me.UfTransportadora_Y.CPObrigatorio = False
        Me.UfTransportadora_Y.CPObrigatorioMsg = Nothing
        Me.UfTransportadora_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.UfTransportadora_Y.FlatBorder = False
        Me.UfTransportadora_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UfTransportadora_Y.FocusColor = System.Drawing.Color.Empty
        Me.UfTransportadora_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.UfTransportadora_Y.HighlightBorderOnEnter = False
        Me.UfTransportadora_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.UfTransportadora_Y.Location = New System.Drawing.Point(164, 435)
        Me.UfTransportadora_Y.Name = "UfTransportadora_Y"
        Me.UfTransportadora_Y.PreencherZeroEsqueda = False
        Me.UfTransportadora_Y.RegraValidação = Nothing
        Me.UfTransportadora_Y.RegraValidaçãoMensagem = Nothing
        Me.UfTransportadora_Y.Size = New System.Drawing.Size(48, 21)
        Me.UfTransportadora_Y.TabIndex = 139
        Me.UfTransportadora_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UfTransportadora_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UfTransportadora_Y.ValorPadrao = Nothing
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(9, 440)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(100, 16)
        Me.Label35.TabIndex = 137
        Me.Label35.Text = "Estado"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UfTransportadora_X
        '
        Me.UfTransportadora_X.AceitaColarTexto = True
        Me.UfTransportadora_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.UfTransportadora_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UfTransportadora_X.CasasDecimais = 0
        Me.UfTransportadora_X.CPObrigatorio = False
        Me.UfTransportadora_X.CPObrigatorioMsg = Nothing
        Me.UfTransportadora_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.UfTransportadora_X.FlatBorder = False
        Me.UfTransportadora_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UfTransportadora_X.FocusColor = System.Drawing.Color.Empty
        Me.UfTransportadora_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.UfTransportadora_X.HighlightBorderOnEnter = False
        Me.UfTransportadora_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.UfTransportadora_X.Location = New System.Drawing.Point(114, 435)
        Me.UfTransportadora_X.Name = "UfTransportadora_X"
        Me.UfTransportadora_X.PreencherZeroEsqueda = False
        Me.UfTransportadora_X.RegraValidação = Nothing
        Me.UfTransportadora_X.RegraValidaçãoMensagem = Nothing
        Me.UfTransportadora_X.Size = New System.Drawing.Size(48, 21)
        Me.UfTransportadora_X.TabIndex = 138
        Me.UfTransportadora_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UfTransportadora_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UfTransportadora_X.ValorPadrao = Nothing
        '
        'CidadeTransportador_Y
        '
        Me.CidadeTransportador_Y.AceitaColarTexto = True
        Me.CidadeTransportador_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CidadeTransportador_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CidadeTransportador_Y.CasasDecimais = 0
        Me.CidadeTransportador_Y.CPObrigatorio = False
        Me.CidadeTransportador_Y.CPObrigatorioMsg = Nothing
        Me.CidadeTransportador_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CidadeTransportador_Y.FlatBorder = False
        Me.CidadeTransportador_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CidadeTransportador_Y.FocusColor = System.Drawing.Color.Empty
        Me.CidadeTransportador_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.CidadeTransportador_Y.HighlightBorderOnEnter = False
        Me.CidadeTransportador_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CidadeTransportador_Y.Location = New System.Drawing.Point(599, 410)
        Me.CidadeTransportador_Y.Name = "CidadeTransportador_Y"
        Me.CidadeTransportador_Y.PreencherZeroEsqueda = False
        Me.CidadeTransportador_Y.RegraValidação = Nothing
        Me.CidadeTransportador_Y.RegraValidaçãoMensagem = Nothing
        Me.CidadeTransportador_Y.Size = New System.Drawing.Size(48, 21)
        Me.CidadeTransportador_Y.TabIndex = 136
        Me.CidadeTransportador_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CidadeTransportador_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CidadeTransportador_Y.ValorPadrao = Nothing
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(444, 415)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(100, 16)
        Me.Label36.TabIndex = 134
        Me.Label36.Text = "Cidade"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CidadeTransportador_X
        '
        Me.CidadeTransportador_X.AceitaColarTexto = True
        Me.CidadeTransportador_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CidadeTransportador_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CidadeTransportador_X.CasasDecimais = 0
        Me.CidadeTransportador_X.CPObrigatorio = False
        Me.CidadeTransportador_X.CPObrigatorioMsg = Nothing
        Me.CidadeTransportador_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CidadeTransportador_X.FlatBorder = False
        Me.CidadeTransportador_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CidadeTransportador_X.FocusColor = System.Drawing.Color.Empty
        Me.CidadeTransportador_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.CidadeTransportador_X.HighlightBorderOnEnter = False
        Me.CidadeTransportador_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CidadeTransportador_X.Location = New System.Drawing.Point(544, 410)
        Me.CidadeTransportador_X.Name = "CidadeTransportador_X"
        Me.CidadeTransportador_X.PreencherZeroEsqueda = False
        Me.CidadeTransportador_X.RegraValidação = Nothing
        Me.CidadeTransportador_X.RegraValidaçãoMensagem = Nothing
        Me.CidadeTransportador_X.Size = New System.Drawing.Size(48, 21)
        Me.CidadeTransportador_X.TabIndex = 135
        Me.CidadeTransportador_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CidadeTransportador_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CidadeTransportador_X.ValorPadrao = Nothing
        '
        'EndTransportadora_Y
        '
        Me.EndTransportadora_Y.AceitaColarTexto = True
        Me.EndTransportadora_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EndTransportadora_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EndTransportadora_Y.CasasDecimais = 0
        Me.EndTransportadora_Y.CPObrigatorio = False
        Me.EndTransportadora_Y.CPObrigatorioMsg = Nothing
        Me.EndTransportadora_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EndTransportadora_Y.FlatBorder = False
        Me.EndTransportadora_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EndTransportadora_Y.FocusColor = System.Drawing.Color.Empty
        Me.EndTransportadora_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.EndTransportadora_Y.HighlightBorderOnEnter = False
        Me.EndTransportadora_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EndTransportadora_Y.Location = New System.Drawing.Point(384, 410)
        Me.EndTransportadora_Y.Name = "EndTransportadora_Y"
        Me.EndTransportadora_Y.PreencherZeroEsqueda = False
        Me.EndTransportadora_Y.RegraValidação = Nothing
        Me.EndTransportadora_Y.RegraValidaçãoMensagem = Nothing
        Me.EndTransportadora_Y.Size = New System.Drawing.Size(48, 21)
        Me.EndTransportadora_Y.TabIndex = 133
        Me.EndTransportadora_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EndTransportadora_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EndTransportadora_Y.ValorPadrao = Nothing
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(224, 415)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(100, 16)
        Me.Label37.TabIndex = 131
        Me.Label37.Text = "Endereço"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EndTransportadora_X
        '
        Me.EndTransportadora_X.AceitaColarTexto = True
        Me.EndTransportadora_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EndTransportadora_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EndTransportadora_X.CasasDecimais = 0
        Me.EndTransportadora_X.CPObrigatorio = False
        Me.EndTransportadora_X.CPObrigatorioMsg = Nothing
        Me.EndTransportadora_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EndTransportadora_X.FlatBorder = False
        Me.EndTransportadora_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EndTransportadora_X.FocusColor = System.Drawing.Color.Empty
        Me.EndTransportadora_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.EndTransportadora_X.HighlightBorderOnEnter = False
        Me.EndTransportadora_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EndTransportadora_X.Location = New System.Drawing.Point(329, 410)
        Me.EndTransportadora_X.Name = "EndTransportadora_X"
        Me.EndTransportadora_X.PreencherZeroEsqueda = False
        Me.EndTransportadora_X.RegraValidação = Nothing
        Me.EndTransportadora_X.RegraValidaçãoMensagem = Nothing
        Me.EndTransportadora_X.Size = New System.Drawing.Size(48, 21)
        Me.EndTransportadora_X.TabIndex = 132
        Me.EndTransportadora_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EndTransportadora_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EndTransportadora_X.ValorPadrao = Nothing
        '
        'Transportadora_Y
        '
        Me.Transportadora_Y.AceitaColarTexto = True
        Me.Transportadora_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Transportadora_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Transportadora_Y.CasasDecimais = 0
        Me.Transportadora_Y.CPObrigatorio = False
        Me.Transportadora_Y.CPObrigatorioMsg = Nothing
        Me.Transportadora_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Transportadora_Y.FlatBorder = False
        Me.Transportadora_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Transportadora_Y.FocusColor = System.Drawing.Color.Empty
        Me.Transportadora_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Transportadora_Y.HighlightBorderOnEnter = False
        Me.Transportadora_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Transportadora_Y.Location = New System.Drawing.Point(164, 410)
        Me.Transportadora_Y.Name = "Transportadora_Y"
        Me.Transportadora_Y.PreencherZeroEsqueda = False
        Me.Transportadora_Y.RegraValidação = Nothing
        Me.Transportadora_Y.RegraValidaçãoMensagem = Nothing
        Me.Transportadora_Y.Size = New System.Drawing.Size(48, 21)
        Me.Transportadora_Y.TabIndex = 130
        Me.Transportadora_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Transportadora_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Transportadora_Y.ValorPadrao = Nothing
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(9, 415)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(100, 16)
        Me.Label43.TabIndex = 128
        Me.Label43.Text = "Transportadora"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Transportadora_X
        '
        Me.Transportadora_X.AceitaColarTexto = True
        Me.Transportadora_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Transportadora_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Transportadora_X.CasasDecimais = 0
        Me.Transportadora_X.CPObrigatorio = False
        Me.Transportadora_X.CPObrigatorioMsg = Nothing
        Me.Transportadora_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Transportadora_X.FlatBorder = False
        Me.Transportadora_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Transportadora_X.FocusColor = System.Drawing.Color.Empty
        Me.Transportadora_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Transportadora_X.HighlightBorderOnEnter = False
        Me.Transportadora_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Transportadora_X.Location = New System.Drawing.Point(114, 410)
        Me.Transportadora_X.Name = "Transportadora_X"
        Me.Transportadora_X.PreencherZeroEsqueda = False
        Me.Transportadora_X.RegraValidação = Nothing
        Me.Transportadora_X.RegraValidaçãoMensagem = Nothing
        Me.Transportadora_X.Size = New System.Drawing.Size(48, 21)
        Me.Transportadora_X.TabIndex = 129
        Me.Transportadora_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Transportadora_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Transportadora_X.ValorPadrao = Nothing
        '
        'St_Y
        '
        Me.St_Y.AceitaColarTexto = True
        Me.St_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.St_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.St_Y.CasasDecimais = 0
        Me.St_Y.CPObrigatorio = False
        Me.St_Y.CPObrigatorioMsg = Nothing
        Me.St_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.St_Y.FlatBorder = False
        Me.St_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.St_Y.FocusColor = System.Drawing.Color.Empty
        Me.St_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.St_Y.HighlightBorderOnEnter = False
        Me.St_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.St_Y.Location = New System.Drawing.Point(164, 230)
        Me.St_Y.Name = "St_Y"
        Me.St_Y.PreencherZeroEsqueda = False
        Me.St_Y.RegraValidação = Nothing
        Me.St_Y.RegraValidaçãoMensagem = Nothing
        Me.St_Y.Size = New System.Drawing.Size(48, 21)
        Me.St_Y.TabIndex = 80
        Me.St_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.St_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.St_Y.ValorPadrao = Nothing
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(8, 230)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(100, 16)
        Me.Label48.TabIndex = 78
        Me.Label48.Text = "Sit. Tributária"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'St_X
        '
        Me.St_X.AceitaColarTexto = True
        Me.St_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.St_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.St_X.CasasDecimais = 0
        Me.St_X.CPObrigatorio = False
        Me.St_X.CPObrigatorioMsg = Nothing
        Me.St_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.St_X.FlatBorder = False
        Me.St_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.St_X.FocusColor = System.Drawing.Color.Empty
        Me.St_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.St_X.HighlightBorderOnEnter = False
        Me.St_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.St_X.Location = New System.Drawing.Point(112, 230)
        Me.St_X.Name = "St_X"
        Me.St_X.PreencherZeroEsqueda = False
        Me.St_X.RegraValidação = Nothing
        Me.St_X.RegraValidaçãoMensagem = Nothing
        Me.St_X.Size = New System.Drawing.Size(48, 21)
        Me.St_X.TabIndex = 79
        Me.St_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.St_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.St_X.ValorPadrao = Nothing
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(564, 10)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(30, 16)
        Me.Label49.TabIndex = 6
        Me.Label49.Text = "T.F."
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TamanhoFonte
        '
        Me.TamanhoFonte.AceitaColarTexto = True
        Me.TamanhoFonte.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TamanhoFonte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TamanhoFonte.CasasDecimais = 0
        Me.TamanhoFonte.CPObrigatorio = False
        Me.TamanhoFonte.CPObrigatorioMsg = Nothing
        Me.TamanhoFonte.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TamanhoFonte.FlatBorder = False
        Me.TamanhoFonte.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TamanhoFonte.FocusColor = System.Drawing.Color.Empty
        Me.TamanhoFonte.FocusColorEnd = System.Drawing.Color.Empty
        Me.TamanhoFonte.HighlightBorderOnEnter = False
        Me.TamanhoFonte.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TamanhoFonte.Location = New System.Drawing.Point(599, 5)
        Me.TamanhoFonte.Name = "TamanhoFonte"
        Me.TamanhoFonte.PreencherZeroEsqueda = False
        Me.TamanhoFonte.RegraValidação = Nothing
        Me.TamanhoFonte.RegraValidaçãoMensagem = Nothing
        Me.TamanhoFonte.Size = New System.Drawing.Size(44, 21)
        Me.TamanhoFonte.TabIndex = 7
        Me.TamanhoFonte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TamanhoFonte.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TamanhoFonte.ValorPadrao = Nothing
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(249, 5)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(75, 16)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Cod. Empresa"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodigoEmpresa
        '
        Me.CodigoEmpresa.AceitaColarTexto = True
        Me.CodigoEmpresa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodigoEmpresa.CasasDecimais = 0
        Me.CodigoEmpresa.CPObrigatorio = False
        Me.CodigoEmpresa.CPObrigatorioMsg = Nothing
        Me.CodigoEmpresa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoEmpresa.FlatBorder = False
        Me.CodigoEmpresa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoEmpresa.FocusColor = System.Drawing.Color.Empty
        Me.CodigoEmpresa.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoEmpresa.HighlightBorderOnEnter = False
        Me.CodigoEmpresa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoEmpresa.Location = New System.Drawing.Point(329, 5)
        Me.CodigoEmpresa.Name = "CodigoEmpresa"
        Me.CodigoEmpresa.PreencherZeroEsqueda = False
        Me.CodigoEmpresa.RegraValidação = Nothing
        Me.CodigoEmpresa.RegraValidaçãoMensagem = Nothing
        Me.CodigoEmpresa.Size = New System.Drawing.Size(44, 21)
        Me.CodigoEmpresa.TabIndex = 3
        Me.CodigoEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoEmpresa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoEmpresa.ValorPadrao = Nothing
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(224, 519)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(100, 16)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Casas Dec. Qtd"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CasaDecimaisQtd
        '
        Me.CasaDecimaisQtd.AceitaColarTexto = True
        Me.CasaDecimaisQtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CasaDecimaisQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CasaDecimaisQtd.CasasDecimais = 0
        Me.CasaDecimaisQtd.CPObrigatorio = False
        Me.CasaDecimaisQtd.CPObrigatorioMsg = Nothing
        Me.CasaDecimaisQtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CasaDecimaisQtd.FlatBorder = False
        Me.CasaDecimaisQtd.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CasaDecimaisQtd.FocusColor = System.Drawing.Color.Empty
        Me.CasaDecimaisQtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.CasaDecimaisQtd.HighlightBorderOnEnter = False
        Me.CasaDecimaisQtd.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CasaDecimaisQtd.Location = New System.Drawing.Point(329, 514)
        Me.CasaDecimaisQtd.Name = "CasaDecimaisQtd"
        Me.CasaDecimaisQtd.PreencherZeroEsqueda = False
        Me.CasaDecimaisQtd.RegraValidação = Nothing
        Me.CasaDecimaisQtd.RegraValidaçãoMensagem = Nothing
        Me.CasaDecimaisQtd.Size = New System.Drawing.Size(48, 21)
        Me.CasaDecimaisQtd.TabIndex = 160
        Me.CasaDecimaisQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CasaDecimaisQtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CasaDecimaisQtd.ValorPadrao = Nothing
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(444, 519)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(100, 16)
        Me.Label52.TabIndex = 161
        Me.Label52.Text = "Casas Dec. Vlrs"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CasaDecimaisValores
        '
        Me.CasaDecimaisValores.AceitaColarTexto = True
        Me.CasaDecimaisValores.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CasaDecimaisValores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CasaDecimaisValores.CasasDecimais = 0
        Me.CasaDecimaisValores.CPObrigatorio = False
        Me.CasaDecimaisValores.CPObrigatorioMsg = Nothing
        Me.CasaDecimaisValores.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CasaDecimaisValores.FlatBorder = False
        Me.CasaDecimaisValores.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CasaDecimaisValores.FocusColor = System.Drawing.Color.Empty
        Me.CasaDecimaisValores.FocusColorEnd = System.Drawing.Color.Empty
        Me.CasaDecimaisValores.HighlightBorderOnEnter = False
        Me.CasaDecimaisValores.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CasaDecimaisValores.Location = New System.Drawing.Point(544, 514)
        Me.CasaDecimaisValores.Name = "CasaDecimaisValores"
        Me.CasaDecimaisValores.PreencherZeroEsqueda = False
        Me.CasaDecimaisValores.RegraValidação = Nothing
        Me.CasaDecimaisValores.RegraValidaçãoMensagem = Nothing
        Me.CasaDecimaisValores.Size = New System.Drawing.Size(48, 21)
        Me.CasaDecimaisValores.TabIndex = 162
        Me.CasaDecimaisValores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CasaDecimaisValores.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CasaDecimaisValores.ValorPadrao = Nothing
        '
        'ValorIss_Y
        '
        Me.ValorIss_Y.AceitaColarTexto = True
        Me.ValorIss_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIss_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorIss_Y.CasasDecimais = 0
        Me.ValorIss_Y.CPObrigatorio = False
        Me.ValorIss_Y.CPObrigatorioMsg = Nothing
        Me.ValorIss_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIss_Y.FlatBorder = False
        Me.ValorIss_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIss_Y.FocusColor = System.Drawing.Color.Empty
        Me.ValorIss_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIss_Y.HighlightBorderOnEnter = False
        Me.ValorIss_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIss_Y.Location = New System.Drawing.Point(599, 360)
        Me.ValorIss_Y.Name = "ValorIss_Y"
        Me.ValorIss_Y.PreencherZeroEsqueda = False
        Me.ValorIss_Y.RegraValidação = Nothing
        Me.ValorIss_Y.RegraValidaçãoMensagem = Nothing
        Me.ValorIss_Y.Size = New System.Drawing.Size(48, 21)
        Me.ValorIss_Y.TabIndex = 122
        Me.ValorIss_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorIss_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorIss_Y.ValorPadrao = Nothing
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(439, 360)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(100, 16)
        Me.Label54.TabIndex = 120
        Me.Label54.Text = "Valor Iss"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ValorIss_X
        '
        Me.ValorIss_X.AceitaColarTexto = True
        Me.ValorIss_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIss_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorIss_X.CasasDecimais = 0
        Me.ValorIss_X.CPObrigatorio = False
        Me.ValorIss_X.CPObrigatorioMsg = Nothing
        Me.ValorIss_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIss_X.FlatBorder = False
        Me.ValorIss_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIss_X.FocusColor = System.Drawing.Color.Empty
        Me.ValorIss_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIss_X.HighlightBorderOnEnter = False
        Me.ValorIss_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIss_X.Location = New System.Drawing.Point(544, 360)
        Me.ValorIss_X.Name = "ValorIss_X"
        Me.ValorIss_X.PreencherZeroEsqueda = False
        Me.ValorIss_X.RegraValidação = Nothing
        Me.ValorIss_X.RegraValidaçãoMensagem = Nothing
        Me.ValorIss_X.Size = New System.Drawing.Size(48, 21)
        Me.ValorIss_X.TabIndex = 121
        Me.ValorIss_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorIss_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorIss_X.ValorPadrao = Nothing
        '
        'AliquotaIss_Y
        '
        Me.AliquotaIss_Y.AceitaColarTexto = True
        Me.AliquotaIss_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AliquotaIss_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AliquotaIss_Y.CasasDecimais = 0
        Me.AliquotaIss_Y.CPObrigatorio = False
        Me.AliquotaIss_Y.CPObrigatorioMsg = Nothing
        Me.AliquotaIss_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AliquotaIss_Y.FlatBorder = False
        Me.AliquotaIss_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.AliquotaIss_Y.FocusColor = System.Drawing.Color.Empty
        Me.AliquotaIss_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.AliquotaIss_Y.HighlightBorderOnEnter = False
        Me.AliquotaIss_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.AliquotaIss_Y.Location = New System.Drawing.Point(379, 360)
        Me.AliquotaIss_Y.Name = "AliquotaIss_Y"
        Me.AliquotaIss_Y.PreencherZeroEsqueda = False
        Me.AliquotaIss_Y.RegraValidação = Nothing
        Me.AliquotaIss_Y.RegraValidaçãoMensagem = Nothing
        Me.AliquotaIss_Y.Size = New System.Drawing.Size(48, 21)
        Me.AliquotaIss_Y.TabIndex = 119
        Me.AliquotaIss_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AliquotaIss_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AliquotaIss_Y.ValorPadrao = Nothing
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(224, 360)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(100, 16)
        Me.Label55.TabIndex = 117
        Me.Label55.Text = "Aliquota Iss"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AliquotaIss_X
        '
        Me.AliquotaIss_X.AceitaColarTexto = True
        Me.AliquotaIss_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AliquotaIss_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AliquotaIss_X.CasasDecimais = 0
        Me.AliquotaIss_X.CPObrigatorio = False
        Me.AliquotaIss_X.CPObrigatorioMsg = Nothing
        Me.AliquotaIss_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AliquotaIss_X.FlatBorder = False
        Me.AliquotaIss_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.AliquotaIss_X.FocusColor = System.Drawing.Color.Empty
        Me.AliquotaIss_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.AliquotaIss_X.HighlightBorderOnEnter = False
        Me.AliquotaIss_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.AliquotaIss_X.Location = New System.Drawing.Point(329, 360)
        Me.AliquotaIss_X.Name = "AliquotaIss_X"
        Me.AliquotaIss_X.PreencherZeroEsqueda = False
        Me.AliquotaIss_X.RegraValidação = Nothing
        Me.AliquotaIss_X.RegraValidaçãoMensagem = Nothing
        Me.AliquotaIss_X.Size = New System.Drawing.Size(48, 21)
        Me.AliquotaIss_X.TabIndex = 118
        Me.AliquotaIss_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AliquotaIss_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AliquotaIss_X.ValorPadrao = Nothing
        '
        'Serviço_Y
        '
        Me.Serviço_Y.AceitaColarTexto = True
        Me.Serviço_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Serviço_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Serviço_Y.CasasDecimais = 0
        Me.Serviço_Y.CPObrigatorio = False
        Me.Serviço_Y.CPObrigatorioMsg = Nothing
        Me.Serviço_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Serviço_Y.FlatBorder = False
        Me.Serviço_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Serviço_Y.FocusColor = System.Drawing.Color.Empty
        Me.Serviço_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.Serviço_Y.HighlightBorderOnEnter = False
        Me.Serviço_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Serviço_Y.Location = New System.Drawing.Point(164, 360)
        Me.Serviço_Y.Name = "Serviço_Y"
        Me.Serviço_Y.PreencherZeroEsqueda = False
        Me.Serviço_Y.RegraValidação = Nothing
        Me.Serviço_Y.RegraValidaçãoMensagem = Nothing
        Me.Serviço_Y.Size = New System.Drawing.Size(48, 21)
        Me.Serviço_Y.TabIndex = 116
        Me.Serviço_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Serviço_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Serviço_Y.ValorPadrao = Nothing
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(9, 360)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(100, 16)
        Me.Label56.TabIndex = 114
        Me.Label56.Text = "Serviço"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Serviço_X
        '
        Me.Serviço_X.AceitaColarTexto = True
        Me.Serviço_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Serviço_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Serviço_X.CasasDecimais = 0
        Me.Serviço_X.CPObrigatorio = False
        Me.Serviço_X.CPObrigatorioMsg = Nothing
        Me.Serviço_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Serviço_X.FlatBorder = False
        Me.Serviço_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Serviço_X.FocusColor = System.Drawing.Color.Empty
        Me.Serviço_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.Serviço_X.HighlightBorderOnEnter = False
        Me.Serviço_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Serviço_X.Location = New System.Drawing.Point(114, 360)
        Me.Serviço_X.Name = "Serviço_X"
        Me.Serviço_X.PreencherZeroEsqueda = False
        Me.Serviço_X.RegraValidação = Nothing
        Me.Serviço_X.RegraValidaçãoMensagem = Nothing
        Me.Serviço_X.Size = New System.Drawing.Size(48, 21)
        Me.Serviço_X.TabIndex = 115
        Me.Serviço_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Serviço_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Serviço_X.ValorPadrao = Nothing
        '
        'ValorServiço_Y
        '
        Me.ValorServiço_Y.AceitaColarTexto = True
        Me.ValorServiço_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorServiço_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorServiço_Y.CasasDecimais = 0
        Me.ValorServiço_Y.CPObrigatorio = False
        Me.ValorServiço_Y.CPObrigatorioMsg = Nothing
        Me.ValorServiço_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorServiço_Y.FlatBorder = False
        Me.ValorServiço_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorServiço_Y.FocusColor = System.Drawing.Color.Empty
        Me.ValorServiço_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorServiço_Y.HighlightBorderOnEnter = False
        Me.ValorServiço_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorServiço_Y.Location = New System.Drawing.Point(164, 385)
        Me.ValorServiço_Y.Name = "ValorServiço_Y"
        Me.ValorServiço_Y.PreencherZeroEsqueda = False
        Me.ValorServiço_Y.RegraValidação = Nothing
        Me.ValorServiço_Y.RegraValidaçãoMensagem = Nothing
        Me.ValorServiço_Y.Size = New System.Drawing.Size(48, 21)
        Me.ValorServiço_Y.TabIndex = 125
        Me.ValorServiço_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorServiço_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorServiço_Y.ValorPadrao = Nothing
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(9, 385)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(100, 16)
        Me.Label57.TabIndex = 123
        Me.Label57.Text = "Valor Serviço"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ValorServiço_X
        '
        Me.ValorServiço_X.AceitaColarTexto = True
        Me.ValorServiço_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorServiço_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorServiço_X.CasasDecimais = 0
        Me.ValorServiço_X.CPObrigatorio = False
        Me.ValorServiço_X.CPObrigatorioMsg = Nothing
        Me.ValorServiço_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorServiço_X.FlatBorder = False
        Me.ValorServiço_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorServiço_X.FocusColor = System.Drawing.Color.Empty
        Me.ValorServiço_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorServiço_X.HighlightBorderOnEnter = False
        Me.ValorServiço_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorServiço_X.Location = New System.Drawing.Point(114, 385)
        Me.ValorServiço_X.Name = "ValorServiço_X"
        Me.ValorServiço_X.PreencherZeroEsqueda = False
        Me.ValorServiço_X.RegraValidação = Nothing
        Me.ValorServiço_X.RegraValidaçãoMensagem = Nothing
        Me.ValorServiço_X.Size = New System.Drawing.Size(48, 21)
        Me.ValorServiço_X.TabIndex = 124
        Me.ValorServiço_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValorServiço_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorServiço_X.ValorPadrao = Nothing
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(224, 385)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(100, 16)
        Me.Label53.TabIndex = 126
        Me.Label53.Text = "Imprimir Serviço ?"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImprimirServiço
        '
        Me.ImprimirServiço.AceitaColarTexto = True
        Me.ImprimirServiço.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ImprimirServiço.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImprimirServiço.CasasDecimais = 0
        Me.ImprimirServiço.CPObrigatorio = False
        Me.ImprimirServiço.CPObrigatorioMsg = Nothing
        Me.ImprimirServiço.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ImprimirServiço.FlatBorder = False
        Me.ImprimirServiço.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ImprimirServiço.FocusColor = System.Drawing.Color.Empty
        Me.ImprimirServiço.FocusColorEnd = System.Drawing.Color.Empty
        Me.ImprimirServiço.HighlightBorderOnEnter = False
        Me.ImprimirServiço.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ImprimirServiço.Location = New System.Drawing.Point(329, 385)
        Me.ImprimirServiço.Name = "ImprimirServiço"
        Me.ImprimirServiço.PreencherZeroEsqueda = False
        Me.ImprimirServiço.RegraValidação = Nothing
        Me.ImprimirServiço.RegraValidaçãoMensagem = Nothing
        Me.ImprimirServiço.Size = New System.Drawing.Size(48, 21)
        Me.ImprimirServiço.TabIndex = 127
        Me.ImprimirServiço.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ImprimirServiço.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ImprimirServiço.ValorPadrao = Nothing
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.PowderBlue
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TABGERAL)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 1
        Me.TabControl1.Size = New System.Drawing.Size(668, 587)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TABGERAL
        '
        Me.TABGERAL.Controls.Add(Me.PlacaTransportadora_Y)
        Me.TABGERAL.Controls.Add(Me.Label59)
        Me.TABGERAL.Controls.Add(Me.PlacaTransportadora_X)
        Me.TABGERAL.Controls.Add(Me.FreteContaDe_Y)
        Me.TABGERAL.Controls.Add(Me.Label60)
        Me.TABGERAL.Controls.Add(Me.FreteContaDe_X)
        Me.TABGERAL.Controls.Add(Me.Label1)
        Me.TABGERAL.Controls.Add(Me.NomeForms)
        Me.TABGERAL.Controls.Add(Me.Label53)
        Me.TABGERAL.Controls.Add(Me.NomeFonte)
        Me.TABGERAL.Controls.Add(Me.ImprimirServiço)
        Me.TABGERAL.Controls.Add(Me.Label2)
        Me.TABGERAL.Controls.Add(Me.ValorServiço_Y)
        Me.TABGERAL.Controls.Add(Me.EntradaSaida_X)
        Me.TABGERAL.Controls.Add(Me.Label57)
        Me.TABGERAL.Controls.Add(Me.Label3)
        Me.TABGERAL.Controls.Add(Me.ValorServiço_X)
        Me.TABGERAL.Controls.Add(Me.Label4)
        Me.TABGERAL.Controls.Add(Me.ValorIss_Y)
        Me.TABGERAL.Controls.Add(Me.EntradaSaida_Y)
        Me.TABGERAL.Controls.Add(Me.Label54)
        Me.TABGERAL.Controls.Add(Me.Label5)
        Me.TABGERAL.Controls.Add(Me.ValorIss_X)
        Me.TABGERAL.Controls.Add(Me.NumeroNf_X)
        Me.TABGERAL.Controls.Add(Me.AliquotaIss_Y)
        Me.TABGERAL.Controls.Add(Me.Label6)
        Me.TABGERAL.Controls.Add(Me.Label55)
        Me.TABGERAL.Controls.Add(Me.NumeroNf_Y)
        Me.TABGERAL.Controls.Add(Me.AliquotaIss_X)
        Me.TABGERAL.Controls.Add(Me.CfopDesc_X)
        Me.TABGERAL.Controls.Add(Me.Serviço_Y)
        Me.TABGERAL.Controls.Add(Me.Label8)
        Me.TABGERAL.Controls.Add(Me.Label56)
        Me.TABGERAL.Controls.Add(Me.CfopDesc_Y)
        Me.TABGERAL.Controls.Add(Me.Serviço_X)
        Me.TABGERAL.Controls.Add(Me.Cfop_X)
        Me.TABGERAL.Controls.Add(Me.Label)
        Me.TABGERAL.Controls.Add(Me.Label52)
        Me.TABGERAL.Controls.Add(Me.Cfop_Y)
        Me.TABGERAL.Controls.Add(Me.CasaDecimaisValores)
        Me.TABGERAL.Controls.Add(Me.Nome_X)
        Me.TABGERAL.Controls.Add(Me.Label51)
        Me.TABGERAL.Controls.Add(Me.LabelNome)
        Me.TABGERAL.Controls.Add(Me.CasaDecimaisQtd)
        Me.TABGERAL.Controls.Add(Me.Nome_Y)
        Me.TABGERAL.Controls.Add(Me.Label50)
        Me.TABGERAL.Controls.Add(Me.Cnpj_X)
        Me.TABGERAL.Controls.Add(Me.CodigoEmpresa)
        Me.TABGERAL.Controls.Add(Me.Label11)
        Me.TABGERAL.Controls.Add(Me.Label49)
        Me.TABGERAL.Controls.Add(Me.Cnpj_Y)
        Me.TABGERAL.Controls.Add(Me.TamanhoFonte)
        Me.TABGERAL.Controls.Add(Me.DataEmissao_X)
        Me.TABGERAL.Controls.Add(Me.St_Y)
        Me.TABGERAL.Controls.Add(Me.Label10)
        Me.TABGERAL.Controls.Add(Me.Label48)
        Me.TABGERAL.Controls.Add(Me.DataEmissao_Y)
        Me.TABGERAL.Controls.Add(Me.St_X)
        Me.TABGERAL.Controls.Add(Me.Endereco_X)
        Me.TABGERAL.Controls.Add(Me.Desconto_Y)
        Me.TABGERAL.Controls.Add(Me.Label9)
        Me.TABGERAL.Controls.Add(Me.Label46)
        Me.TABGERAL.Controls.Add(Me.Endereco_Y)
        Me.TABGERAL.Controls.Add(Me.Desconto_X)
        Me.TABGERAL.Controls.Add(Me.Bairro_X)
        Me.TABGERAL.Controls.Add(Me.NumeroNota2_Y)
        Me.TABGERAL.Controls.Add(Me.Label14)
        Me.TABGERAL.Controls.Add(Me.Label45)
        Me.TABGERAL.Controls.Add(Me.Bairro_Y)
        Me.TABGERAL.Controls.Add(Me.NumeroNota2_X)
        Me.TABGERAL.Controls.Add(Me.Cep_X)
        Me.TABGERAL.Controls.Add(Me.Observacao_Y)
        Me.TABGERAL.Controls.Add(Me.Label13)
        Me.TABGERAL.Controls.Add(Me.Label44)
        Me.TABGERAL.Controls.Add(Me.Cep_Y)
        Me.TABGERAL.Controls.Add(Me.Observacao_X)
        Me.TABGERAL.Controls.Add(Me.DataSaida_X)
        Me.TABGERAL.Controls.Add(Me.IncricaoTransportadora_Y)
        Me.TABGERAL.Controls.Add(Me.Label12)
        Me.TABGERAL.Controls.Add(Me.Label34)
        Me.TABGERAL.Controls.Add(Me.DataSaida_Y)
        Me.TABGERAL.Controls.Add(Me.IncricaoTransportadora_X)
        Me.TABGERAL.Controls.Add(Me.Cidade_X)
        Me.TABGERAL.Controls.Add(Me.UfTransportadora_Y)
        Me.TABGERAL.Controls.Add(Me.Label7)
        Me.TABGERAL.Controls.Add(Me.Label35)
        Me.TABGERAL.Controls.Add(Me.Cidade_Y)
        Me.TABGERAL.Controls.Add(Me.UfTransportadora_X)
        Me.TABGERAL.Controls.Add(Me.Fone_X)
        Me.TABGERAL.Controls.Add(Me.CidadeTransportador_Y)
        Me.TABGERAL.Controls.Add(Me.Label19)
        Me.TABGERAL.Controls.Add(Me.Label36)
        Me.TABGERAL.Controls.Add(Me.Fone_Y)
        Me.TABGERAL.Controls.Add(Me.CidadeTransportador_X)
        Me.TABGERAL.Controls.Add(Me.Inscricao_X)
        Me.TABGERAL.Controls.Add(Me.EndTransportadora_Y)
        Me.TABGERAL.Controls.Add(Me.Label18)
        Me.TABGERAL.Controls.Add(Me.Label37)
        Me.TABGERAL.Controls.Add(Me.Inscricao_Y)
        Me.TABGERAL.Controls.Add(Me.EndTransportadora_X)
        Me.TABGERAL.Controls.Add(Me.HoraSaida_X)
        Me.TABGERAL.Controls.Add(Me.Transportadora_Y)
        Me.TABGERAL.Controls.Add(Me.Label17)
        Me.TABGERAL.Controls.Add(Me.Label43)
        Me.TABGERAL.Controls.Add(Me.HoraSaida_Y)
        Me.TABGERAL.Controls.Add(Me.Transportadora_X)
        Me.TABGERAL.Controls.Add(Me.Fechar)
        Me.TABGERAL.Controls.Add(Me.TotalNota_Y)
        Me.TABGERAL.Controls.Add(Me.Label31)
        Me.TABGERAL.Controls.Add(Me.Label38)
        Me.TABGERAL.Controls.Add(Me.Label30)
        Me.TABGERAL.Controls.Add(Me.TotalNota_X)
        Me.TABGERAL.Controls.Add(Me.Label33)
        Me.TABGERAL.Controls.Add(Me.TotalIpi_Y)
        Me.TABGERAL.Controls.Add(Me.Label32)
        Me.TABGERAL.Controls.Add(Me.Label39)
        Me.TABGERAL.Controls.Add(Me.ImpressDp)
        Me.TABGERAL.Controls.Add(Me.TotalIpi_X)
        Me.TABGERAL.Controls.Add(Me.Label47)
        Me.TABGERAL.Controls.Add(Me.TotalProdutos_Y)
        Me.TABGERAL.Controls.Add(Me.Novo)
        Me.TABGERAL.Controls.Add(Me.Label40)
        Me.TABGERAL.Controls.Add(Me.Salvar)
        Me.TABGERAL.Controls.Add(Me.TotalProdutos_X)
        Me.TABGERAL.Controls.Add(Me.Editar)
        Me.TABGERAL.Controls.Add(Me.ValorIcms_Y)
        Me.TABGERAL.Controls.Add(Me.Procurar)
        Me.TABGERAL.Controls.Add(Me.Label41)
        Me.TABGERAL.Controls.Add(Me.Padrão)
        Me.TABGERAL.Controls.Add(Me.ValorIcms_X)
        Me.TABGERAL.Controls.Add(Me.Dp1Posição_X)
        Me.TABGERAL.Controls.Add(Me.BaseCalcIcms_Y)
        Me.TABGERAL.Controls.Add(Me.Label16)
        Me.TABGERAL.Controls.Add(Me.Label42)
        Me.TABGERAL.Controls.Add(Me.Dp1Posição_Y)
        Me.TABGERAL.Controls.Add(Me.BaseCalcIcms_X)
        Me.TABGERAL.Controls.Add(Me.Dp2Posição_X)
        Me.TABGERAL.Controls.Add(Me.ValorIpi_Y)
        Me.TABGERAL.Controls.Add(Me.Label15)
        Me.TABGERAL.Controls.Add(Me.Label29)
        Me.TABGERAL.Controls.Add(Me.Dp2Posição_Y)
        Me.TABGERAL.Controls.Add(Me.ValorIpi_X)
        Me.TABGERAL.Controls.Add(Me.Dp3Posição_X)
        Me.TABGERAL.Controls.Add(Me.Ipi_Y)
        Me.TABGERAL.Controls.Add(Me.Label20)
        Me.TABGERAL.Controls.Add(Me.Label27)
        Me.TABGERAL.Controls.Add(Me.Dp3Posição_Y)
        Me.TABGERAL.Controls.Add(Me.Ipi_X)
        Me.TABGERAL.Controls.Add(Me.DescItens_X)
        Me.TABGERAL.Controls.Add(Me.Icms_Y)
        Me.TABGERAL.Controls.Add(Me.Label21)
        Me.TABGERAL.Controls.Add(Me.Label28)
        Me.TABGERAL.Controls.Add(Me.DescItens_Y)
        Me.TABGERAL.Controls.Add(Me.Icms_X)
        Me.TABGERAL.Controls.Add(Me.Cf_X)
        Me.TABGERAL.Controls.Add(Me.Total_Y)
        Me.TABGERAL.Controls.Add(Me.Label22)
        Me.TABGERAL.Controls.Add(Me.Label26)
        Me.TABGERAL.Controls.Add(Me.Cf_Y)
        Me.TABGERAL.Controls.Add(Me.Total_X)
        Me.TABGERAL.Controls.Add(Me.Unid_X)
        Me.TABGERAL.Controls.Add(Me.Unitario_Y)
        Me.TABGERAL.Controls.Add(Me.Label23)
        Me.TABGERAL.Controls.Add(Me.Label25)
        Me.TABGERAL.Controls.Add(Me.Unid_Y)
        Me.TABGERAL.Controls.Add(Me.Unitario_X)
        Me.TABGERAL.Controls.Add(Me.Qtd_X)
        Me.TABGERAL.Controls.Add(Me.Qtd_Y)
        Me.TABGERAL.Controls.Add(Me.Label24)
        Me.TABGERAL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TABGERAL.Location = New System.Drawing.Point(0, 23)
        Me.TABGERAL.Name = "TABGERAL"
        Me.TABGERAL.Padding = New System.Windows.Forms.Padding(1)
        Me.TABGERAL.Size = New System.Drawing.Size(668, 564)
        Me.TABGERAL.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TABGERAL.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TABGERAL.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TABGERAL.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TABGERAL.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TABGERAL.Style.GradientAngle = 90
        Me.TABGERAL.TabIndex = 1
        Me.TABGERAL.TabItem = Me.TabItem1
        '
        'PlacaTransportadora_Y
        '
        Me.PlacaTransportadora_Y.AceitaColarTexto = True
        Me.PlacaTransportadora_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PlacaTransportadora_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlacaTransportadora_Y.CasasDecimais = 0
        Me.PlacaTransportadora_Y.CPObrigatorio = False
        Me.PlacaTransportadora_Y.CPObrigatorioMsg = Nothing
        Me.PlacaTransportadora_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PlacaTransportadora_Y.FlatBorder = False
        Me.PlacaTransportadora_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.PlacaTransportadora_Y.FocusColor = System.Drawing.Color.Empty
        Me.PlacaTransportadora_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.PlacaTransportadora_Y.HighlightBorderOnEnter = False
        Me.PlacaTransportadora_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.PlacaTransportadora_Y.Location = New System.Drawing.Point(384, 462)
        Me.PlacaTransportadora_Y.Name = "PlacaTransportadora_Y"
        Me.PlacaTransportadora_Y.PreencherZeroEsqueda = False
        Me.PlacaTransportadora_Y.RegraValidação = Nothing
        Me.PlacaTransportadora_Y.RegraValidaçãoMensagem = Nothing
        Me.PlacaTransportadora_Y.Size = New System.Drawing.Size(48, 21)
        Me.PlacaTransportadora_Y.TabIndex = 151
        Me.PlacaTransportadora_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PlacaTransportadora_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.PlacaTransportadora_Y.ValorPadrao = Nothing
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(224, 467)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(100, 16)
        Me.Label59.TabIndex = 149
        Me.Label59.Text = "Placa"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PlacaTransportadora_X
        '
        Me.PlacaTransportadora_X.AceitaColarTexto = True
        Me.PlacaTransportadora_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PlacaTransportadora_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlacaTransportadora_X.CasasDecimais = 0
        Me.PlacaTransportadora_X.CPObrigatorio = False
        Me.PlacaTransportadora_X.CPObrigatorioMsg = Nothing
        Me.PlacaTransportadora_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PlacaTransportadora_X.FlatBorder = False
        Me.PlacaTransportadora_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.PlacaTransportadora_X.FocusColor = System.Drawing.Color.Empty
        Me.PlacaTransportadora_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.PlacaTransportadora_X.HighlightBorderOnEnter = False
        Me.PlacaTransportadora_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.PlacaTransportadora_X.Location = New System.Drawing.Point(329, 462)
        Me.PlacaTransportadora_X.Name = "PlacaTransportadora_X"
        Me.PlacaTransportadora_X.PreencherZeroEsqueda = False
        Me.PlacaTransportadora_X.RegraValidação = Nothing
        Me.PlacaTransportadora_X.RegraValidaçãoMensagem = Nothing
        Me.PlacaTransportadora_X.Size = New System.Drawing.Size(48, 21)
        Me.PlacaTransportadora_X.TabIndex = 150
        Me.PlacaTransportadora_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PlacaTransportadora_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.PlacaTransportadora_X.ValorPadrao = Nothing
        '
        'FreteContaDe_Y
        '
        Me.FreteContaDe_Y.AceitaColarTexto = True
        Me.FreteContaDe_Y.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FreteContaDe_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FreteContaDe_Y.CasasDecimais = 0
        Me.FreteContaDe_Y.CPObrigatorio = False
        Me.FreteContaDe_Y.CPObrigatorioMsg = Nothing
        Me.FreteContaDe_Y.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FreteContaDe_Y.FlatBorder = False
        Me.FreteContaDe_Y.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FreteContaDe_Y.FocusColor = System.Drawing.Color.Empty
        Me.FreteContaDe_Y.FocusColorEnd = System.Drawing.Color.Empty
        Me.FreteContaDe_Y.HighlightBorderOnEnter = False
        Me.FreteContaDe_Y.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FreteContaDe_Y.Location = New System.Drawing.Point(164, 462)
        Me.FreteContaDe_Y.Name = "FreteContaDe_Y"
        Me.FreteContaDe_Y.PreencherZeroEsqueda = False
        Me.FreteContaDe_Y.RegraValidação = Nothing
        Me.FreteContaDe_Y.RegraValidaçãoMensagem = Nothing
        Me.FreteContaDe_Y.Size = New System.Drawing.Size(48, 21)
        Me.FreteContaDe_Y.TabIndex = 148
        Me.FreteContaDe_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FreteContaDe_Y.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FreteContaDe_Y.ValorPadrao = Nothing
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(9, 467)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(100, 16)
        Me.Label60.TabIndex = 146
        Me.Label60.Text = "Frete Conta do"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FreteContaDe_X
        '
        Me.FreteContaDe_X.AceitaColarTexto = True
        Me.FreteContaDe_X.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FreteContaDe_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FreteContaDe_X.CasasDecimais = 0
        Me.FreteContaDe_X.CPObrigatorio = False
        Me.FreteContaDe_X.CPObrigatorioMsg = Nothing
        Me.FreteContaDe_X.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FreteContaDe_X.FlatBorder = False
        Me.FreteContaDe_X.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FreteContaDe_X.FocusColor = System.Drawing.Color.Empty
        Me.FreteContaDe_X.FocusColorEnd = System.Drawing.Color.Empty
        Me.FreteContaDe_X.HighlightBorderOnEnter = False
        Me.FreteContaDe_X.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FreteContaDe_X.Location = New System.Drawing.Point(114, 462)
        Me.FreteContaDe_X.Name = "FreteContaDe_X"
        Me.FreteContaDe_X.PreencherZeroEsqueda = False
        Me.FreteContaDe_X.RegraValidação = Nothing
        Me.FreteContaDe_X.RegraValidaçãoMensagem = Nothing
        Me.FreteContaDe_X.Size = New System.Drawing.Size(48, 21)
        Me.FreteContaDe_X.TabIndex = 147
        Me.FreteContaDe_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FreteContaDe_X.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FreteContaDe_X.ValorPadrao = Nothing
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TABGERAL
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Configurações da Nota Fiscal"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.VisualizarModelo)
        Me.TabControlPanel2.Controls.Add(Me.Impress)
        Me.TabControlPanel2.Controls.Add(Me.Label58)
        Me.TabControlPanel2.Controls.Add(Me.Impressora)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 23)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(668, 564)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'VisualizarModelo
        '
        Me.VisualizarModelo.Location = New System.Drawing.Point(299, 306)
        Me.VisualizarModelo.Name = "VisualizarModelo"
        Me.VisualizarModelo.Size = New System.Drawing.Size(157, 28)
        Me.VisualizarModelo.TabIndex = 3
        Me.VisualizarModelo.Text = "Imprimir Pagina Modelo"
        '
        'Impress
        '
        Me.Impress.Location = New System.Drawing.Point(299, 260)
        Me.Impress.Name = "Impress"
        Me.Impress.Size = New System.Drawing.Size(157, 28)
        Me.Impress.TabIndex = 2
        Me.Impress.Text = "Definir a Impressora"
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Location = New System.Drawing.Point(144, 199)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(312, 31)
        Me.Label58.TabIndex = 0
        Me.Label58.Text = "Selecione a Impressora uma das impressoras da lista para ser a Impressora Padrão " & _
            "de Nota Fiscal"
        '
        'Impressora
        '
        Me.Impressora.Location = New System.Drawing.Point(144, 233)
        Me.Impressora.Name = "Impressora"
        Me.Impressora.Size = New System.Drawing.Size(312, 21)
        Me.Impressora.TabIndex = 1
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Definir Impressora Padrão"
        '
        'NFCFG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(668, 587)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NFCFG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração Formulario de Nota Fiscal - T149"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TABGERAL.ResumeLayout(False)
        Me.TABGERAL.PerformLayout()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        If Me.NomeForms.Text = "" Then
            MsgBox("Não existe NFForms para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.NomeForms.Focus()
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.Desbloquear_Controle(Me, True)
        Ação.LimpaTextBox(Me)
        Ação.Ultimo_Registro(Me, NomeForms, "ConfNfSystem", "NomeForms")
        Operation = INS
    End Sub

    Private Sub Procurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Procurar.Click
        Ação.Desbloquear_Controle(Me, False)
        ChamaTelaProcura("Codigo", "Descrição", "", "ConfNfSystem", "NomeForms", "NomeForms", "", False)
        Me.NomeForms.Text = RetornoProcura
        If Me.NomeForms.Text <> "" Then
            LocalizaDados()
        End If
    End Sub

    Public Sub LocalizaDados()
        Dim CNN As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from ConfNfSystem where NomeForms = '" & NomeForms.Text & "'"
        Dim CMD As New OleDbCommand(Sql, CNN)
        Dim DR As OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Me.EntradaSaida_X.Text = DR.Item("EntradaSaida_X") & ""
        Me.EntradaSaida_Y.Text = DR.Item("EntradaSaida_Y") & ""
        Me.NumeroNf_X.Text = DR.Item("NumeroNf_X") & ""
        Me.NumeroNf_Y.Text = DR.Item("NumeroNf_Y") & ""
        Me.CfopDesc_X.Text = DR.Item("CfopDesc_X") & ""
        Me.CfopDesc_Y.Text = DR.Item("CfopDesc_Y") & ""
        Me.Cfop_X.Text = DR.Item("Cfop_X") & ""
        Me.Cfop_Y.Text = DR.Item("Cfop_Y") & ""
        Me.Nome_X.Text = DR.Item("Nome_X") & ""
        Me.Nome_Y.Text = DR.Item("Nome_Y") & ""
        Me.Cnpj_X.Text = DR.Item("Cnpj_X") & ""
        Me.Cnpj_Y.Text = DR.Item("CnpJ_Y") & ""
        Me.DataEmissao_X.Text = DR.Item("DataEmissao_X") & ""
        Me.DataEmissao_Y.Text = DR.Item("DataEmissao_Y") & ""
        Me.Endereco_X.Text = DR.Item("Endereco_X") & ""
        Me.Endereco_Y.Text = DR.Item("Endereco_Y") & ""
        Me.Bairro_X.Text = DR.Item("Bairro_X") & ""
        Me.Bairro_Y.Text = DR.Item("Bairro_Y") & ""
        Me.Cep_X.Text = DR.Item("Cep_X") & ""
        Me.Cep_Y.Text = DR.Item("Cep_Y") & ""
        Me.DataSaida_X.Text = DR.Item("DataSaida_X") & ""
        Me.DataSaida_Y.Text = DR.Item("DataSaida_Y") & ""
        Me.Cidade_X.Text = DR.Item("Cidade_X") & ""
        Me.Cidade_Y.Text = DR.Item("Cidade_Y") & ""
        Me.Fone_X.Text = DR.Item("Fone_X") & ""
        Me.Fone_Y.Text = DR.Item("Fone_Y") & ""
        Me.Inscricao_X.Text = DR.Item("Inscricao_X") & ""
        Me.Inscricao_Y.Text = DR.Item("Inscricao_Y") & ""
        Me.HoraSaida_X.Text = DR.Item("HoraSaida_X") & ""
        Me.HoraSaida_Y.Text = DR.Item("HoraSaida_Y") & ""
        Me.Dp1Posição_X.Text = DR.Item("Dp1Posição_X") & ""
        Me.Dp1Posição_Y.Text = DR.Item("Dp1Posição_Y") & ""
        Me.Dp2Posição_X.Text = DR.Item("Dp2Posição_X") & ""
        Me.Dp2Posição_Y.Text = DR.Item("Dp2Posição_Y") & ""
        Me.Dp3Posição_X.Text = DR.Item("Dp3Posição_X") & ""
        Me.Dp3Posição_Y.Text = DR.Item("Dp3Posição_Y") & ""
        Me.DescItens_X.Text = DR.Item("DescItens_X") & ""
        Me.DescItens_Y.Text = DR.Item("DescItens_Y") & ""
        Me.Cf_X.Text = DR.Item("Cf_X") & ""
        Me.Cf_Y.Text = DR.Item("Cf_Y") & ""
        Me.St_X.Text = DR.Item("St_X") & ""
        Me.St_Y.Text = DR.Item("St_Y") & ""
        Me.Unid_X.Text = DR.Item("Unid_X") & ""
        Me.Unid_Y.Text = DR.Item("Unid_Y") & ""
        Me.Qtd_X.Text = DR.Item("Qtd_X") & ""
        Me.Qtd_Y.Text = DR.Item("Qtd_Y") & ""
        Me.Unitario_X.Text = DR.Item("Unitario_X") & ""
        Me.Unitario_Y.Text = DR.Item("Unitario_Y") & ""
        Me.Total_X.Text = DR.Item("Total_X") & ""
        Me.Total_Y.Text = DR.Item("Total_Y") & ""
        Me.Icms_X.Text = DR.Item("Icms_X") & ""
        Me.Icms_Y.Text = DR.Item("Icms_Y") & ""
        Me.Ipi_X.Text = DR.Item("Ipi_X") & ""
        Me.Ipi_Y.Text = DR.Item("Ipi_Y") & ""
        Me.ValorIpi_X.Text = DR.Item("ValorIpi_X") & ""
        Me.ValorIpi_Y.Text = DR.Item("ValorIpi_Y") & ""
        Me.BaseCalcIcms_X.Text = DR.Item("BaseCalcIcms_X") & ""
        Me.BaseCalcIcms_Y.Text = DR.Item("BaseCalcIcms_Y") & ""
        Me.ValorIcms_X.Text = DR.Item("ValorIcms_X") & ""
        Me.ValorIcms_Y.Text = DR.Item("ValorIcms_Y") & ""
        Me.TotalProdutos_X.Text = DR.Item("TotalProdutos_X") & ""
        Me.TotalProdutos_Y.Text = DR.Item("TotalProdutos_Y") & ""
        Me.TotalIpi_X.Text = DR.Item("TotalIpi_X") & ""
        Me.TotalIpi_Y.Text = DR.Item("TotalIpi_Y") & ""
        Me.TotalNota_X.Text = DR.Item("TotalNota_X") & ""
        Me.TotalNota_Y.Text = DR.Item("TotalNota_Y") & ""
        Me.Transportadora_X.Text = DR.Item("Transportadora_X") & ""
        Me.Transportadora_Y.Text = DR.Item("Transportadora_Y") & ""
        Me.EndTransportadora_X.Text = DR.Item("EndTransportadora_X") & ""
        Me.EndTransportadora_Y.Text = DR.Item("EndTransportadora_Y") & ""
        Me.CidadeTransportador_X.Text = DR.Item("CidadeTransportador_X") & ""
        Me.CidadeTransportador_Y.Text = DR.Item("CidadeTransportador_Y") & ""
        Me.UfTransportadora_X.Text = DR.Item("UfTransportadora_X") & ""
        Me.UfTransportadora_Y.Text = DR.Item("UfTransportadora_Y") & ""
        Me.IncricaoTransportadora_X.Text = DR.Item("IncricaoTransportadora_X") & ""
        Me.IncricaoTransportadora_Y.Text = DR.Item("IncricaoTransportadora_Y") & ""
        Me.Observacao_X.Text = DR.Item("Observacao_X") & ""
        Me.Observacao_Y.Text = DR.Item("Observacao_Y") & ""
        Me.NumeroNota2_X.Text = DR.Item("NumeroNota2_X") & ""
        Me.NumeroNota2_Y.Text = DR.Item("NumeroNota2_Y") & ""
        Me.Desconto_X.Text = DR.Item("Desconto_X") & ""
        Me.Desconto_Y.Text = DR.Item("Desconto_Y") & ""
        Me.ImpressDp.Text = DR.Item("ImpressDp") & ""
        Me.NomeForms.Text = DR.Item("NomeForms") & ""
        Me.NomeFonte.Text = DR.Item("NomeFonte") & ""
        Me.TamanhoFonte.Text = DR.Item("TamanhoFonte") & ""
        Me.CodigoEmpresa.Text = DR.Item("CodEmpresa") & ""
        Me.CasaDecimaisQtd.Text = DR.Item("CasaDecimaisQtd") & ""
        Me.CasaDecimaisValores.Text = DR.Item("CasaDecimaisValores") & ""
        Me.Serviço_X.Text = DR.Item("Serviço_X") & ""
        Me.Serviço_Y.Text = DR.Item("Serviço_Y") & ""
        Me.AliquotaIss_X.Text = DR.Item("AliquotaIss_X") & ""
        Me.AliquotaIss_Y.Text = DR.Item("AliquotaIss_Y") & ""
        Me.ValorIss_X.Text = DR.Item("ValorIss_X") & ""
        Me.ValorIss_Y.Text = DR.Item("ValorIss_Y") & ""
        Me.ValorServiço_X.Text = DR.Item("ValorServiço_X") & ""
        Me.ValorServiço_Y.Text = DR.Item("ValorServiço_Y") & ""
        Me.ImprimirServiço.Text = DR.Item("ImprimirServiço") & ""

        Me.FreteContaDe_X.Text = DR.Item("FreteContaDe_X") & ""
        Me.FreteContaDe_Y.Text = DR.Item("FreteContaDe_Y") & ""

        Me.PlacaTransportadora_X.Text = DR.Item("PlacaTransportadora_X") & ""
        Me.PlacaTransportadora_Y.Text = DR.Item("PlacaTransportadora_Y") & ""

        Operation = UPD
        DR.Close()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click

        'Area destinada para as validacoes

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            Dim Sql As String = "INSERT INTO ConfNfSystem (EntradaSaida_X, EntradaSaida_Y, NumeroNf_X, NumeroNf_Y, CfopDesc_X, CfopDesc_Y, Cfop_X, Cfop_Y, Nome_X, Nome_Y, Cnpj_X, CnpJ_Y, DataEmissao_X, DataEmissao_Y, Endereco_X, Endereco_Y, Bairro_X, Bairro_Y, Cep_X, Cep_Y, DataSaida_X, DataSaida_Y, Cidade_X, Cidade_Y, Fone_X, Fone_Y, Inscricao_X, Inscricao_Y, HoraSaida_X, HoraSaida_Y, Dp1Posição_X, Dp1Posição_Y, Dp2Posição_X, Dp2Posição_Y, Dp3Posição_X, Dp3Posição_Y, DescItens_X, DescItens_Y, Cf_X, Cf_Y, Unid_X, Unid_Y, Qtd_X, Qtd_Y, Unitario_X, Unitario_Y, Total_X, Total_Y, Icms_X, Icms_Y, Ipi_X, Ipi_Y, ValorIpi_X, ValorIpi_Y, BaseCalcIcms_X, BaseCalcIcms_Y, ValorIcms_X, ValorIcms_Y, TotalProdutos_X, TotalProdutos_Y, TotalIpi_X, TotalIpi_Y, TotalNota_X, TotalNota_Y, Transportadora_X, Transportadora_Y, EndTransportadora_X, EndTransportadora_Y, CidadeTransportador_X, CidadeTransportador_Y, UfTransportadora_X, UfTransportadora_Y, IncricaoTransportadora_X, IncricaoTransportadora_Y, Observacao_X, Observacao_Y, NumeroNota2_X, NumeroNota2_Y, Desconto_X, Desconto_Y, ImpressDp, NomeForms, NomeFonte, St_X, St_Y, TamanhoFonte, CodEmpresa, CasaDecimaisQtd, CasaDecimaisValores, Serviço_X, Serviço_Y, AliquotaIss_X, AliquotaIss_Y, ValorIss_X, ValorIss_Y, ValorServiço_X, ValorServiço_Y, ImprimirServiço, FreteContaDe_X, FreteContaDe_Y, PlacaTransportadora_X, PlacaTransportadora_Y) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59, @60, @61, @62, @63, @64, @65, @66, @67, @68, @69, @70, @71, @72, @73, @74, @75, @76, @77, @78, @79, @80, @81, @82, @83, @84, @85, @86, @87, @88, @89, @90, @91, @92, @93, @94, @95, @96, @97, @98, @99, @101, @101, @102)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.EntradaSaida_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.EntradaSaida_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NumeroNf_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.NumeroNf_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.CfopDesc_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.CfopDesc_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cfop_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Cfop_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Nome_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Nome_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Cnpj_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Cnpj_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.DataEmissao_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.DataEmissao_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.Endereco_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Endereco_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Bairro_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.Bairro_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Cep_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.Cep_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.DataSaida_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.DataSaida_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.Cidade_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.Cidade_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.Fone_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.Fone_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.Inscricao_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.Inscricao_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.HoraSaida_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.HoraSaida_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.Dp1Posição_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.Dp1Posição_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.Dp2Posição_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.Dp2Posição_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.Dp3Posição_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.Dp3Posição_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.DescItens_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.DescItens_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.Cf_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.Cf_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.Unid_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.Unid_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.Qtd_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.Qtd_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.Unitario_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.Unitario_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.Total_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", Nz(Me.Total_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@49", Nz(Me.Icms_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@50", Nz(Me.Icms_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@51", Nz(Me.Ipi_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@52", Nz(Me.Ipi_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@53", Nz(Me.ValorIpi_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@54", Nz(Me.ValorIpi_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@55", Nz(Me.BaseCalcIcms_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@56", Nz(Me.BaseCalcIcms_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@57", Nz(Me.ValorIcms_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@58", Nz(Me.ValorIcms_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@59", Nz(Me.TotalProdutos_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@60", Nz(Me.TotalProdutos_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@61", Nz(Me.TotalIpi_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@62", Nz(Me.TotalIpi_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@63", Nz(Me.TotalNota_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@64", Nz(Me.TotalNota_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@65", Nz(Me.Transportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@66", Nz(Me.Transportadora_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@67", Nz(Me.EndTransportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@68", Nz(Me.EndTransportadora_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@69", Nz(Me.CidadeTransportador_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@70", Nz(Me.CidadeTransportador_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@71", Nz(Me.UfTransportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@72", Nz(Me.UfTransportadora_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@73", Nz(Me.IncricaoTransportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@74", Nz(Me.IncricaoTransportadora_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@75", Nz(Me.Observacao_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@76", Nz(Me.Observacao_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@77", Nz(Me.NumeroNota2_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@78", Nz(Me.NumeroNota2_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@79", Nz(Me.Desconto_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@80", Nz(Me.Desconto_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@81", Nz(Me.ImpressDp.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@82", Nz(Me.NomeForms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@83", Nz(Me.NomeFonte.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@84", Nz(Me.St_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@85", Nz(Me.St_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@86", Nz(Me.TamanhoFonte.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@87", Nz(Me.CodigoEmpresa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@88", Nz(Me.CasaDecimaisQtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@89", Nz(Me.CasaDecimaisValores.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@90", Nz(Me.Serviço_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@91", Nz(Me.Serviço_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@92", Nz(Me.AliquotaIss_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@93", Nz(Me.AliquotaIss_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@94", Nz(Me.ValorIss_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@95", Nz(Me.ValorIss_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@96", Nz(Me.ValorServiço_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@97", Nz(Me.ValorServiço_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@98", Nz(Me.ImprimirServiço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@99", Nz(Me.FreteContaDe_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@100", Nz(Me.FreteContaDe_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@101", Nz(Me.PlacaTransportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@102", Nz(Me.PlacaTransportadora_Y.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
            Catch er As OleDb.OleDbException
                MsgBox(er.Message)
            End Try

        ElseIf Operation = UPD Then

            CNN.Open()

            Dim Sql As String = "Update ConfNfSystem set EntradaSaida_X = @1, EntradaSaida_Y = @2, NumeroNf_X = @3, NumeroNf_Y = @4, CfopDesc_X = @5, CfopDesc_Y = @6, Cfop_X = @7, Cfop_Y = @8, Nome_X = @9, Nome_Y = @10, Cnpj_X = @11, CnpJ_Y = @12, DataEmissao_X = @13, DataEmissao_Y = @14, Endereco_X = @15, Endereco_Y = @16, Bairro_X = @17, Bairro_Y = @18, Cep_X = @19, Cep_Y = @20, DataSaida_X = @21, DataSaida_Y = @22, Cidade_X = @23, Cidade_Y = @24, Fone_X = @25, Fone_Y = @26, Inscricao_X = @27, Inscricao_Y = @28, HoraSaida_X = @29, HoraSaida_Y = @30, Dp1Posição_X = @31, Dp1Posição_Y = @32, Dp2Posição_X = @33, Dp2Posição_Y = @34, Dp3Posição_X = @35, Dp3Posição_Y = @36, DescItens_X = @37, DescItens_Y = @38, Cf_X = @39, Cf_Y = @40, Unid_X = @41, Unid_Y = @42, Qtd_X = @43, Qtd_Y = @44, Unitario_X = @45, Unitario_Y = @46, Total_X = @47, Total_Y = @48, Icms_X = @49, Icms_Y = @50, Ipi_X = @51, Ipi_Y = @52, ValorIpi_X = @53, ValorIpi_Y = @54, BaseCalcIcms_X = @55, BaseCalcIcms_Y = @56, ValorIcms_X = @57, ValorIcms_Y = @58, TotalProdutos_X = @59, TotalProdutos_Y = @60, TotalIpi_X = @61, TotalIpi_Y = @62, TotalNota_X = @63, TotalNota_Y = @64, Transportadora_X = @65, Transportadora_Y = @66, EndTransportadora_X = @67, EndTransportadora_Y = @68, CidadeTransportador_X = @69, CidadeTransportador_Y = @70, UfTransportadora_X = @71, UfTransportadora_Y = @72, IncricaoTransportadora_X = @73, IncricaoTransportadora_Y = @74, Observacao_X = @75, Observacao_Y = @76, NumeroNota2_X = @77, NumeroNota2_Y = @78, Desconto_X = @79, Desconto_Y = @80, ImpressDp = @81, NomeForms = @82, NomeFonte = @83, St_X = @84, St_Y = @85, TamanhoFonte = @86, CodEmpresa = @87, CasaDecimaisQtd = @88, CasaDecimaisValores = @89, Serviço_X = @90, Serviço_Y = @91, AliquotaIss_X = @92, AliquotaIss_Y = @93, ValorIss_X = @94, ValorIss_Y = @95, ValorServiço_X = @96, ValorServiço_Y = @97, ImprimirServiço = @98, FreteContaDe_X = @99, FreteContaDe_Y = @100, PlacaTransportadora_X = @101, PlacaTransportadora_Y = @102  Where NomeForms = '" & Me.NomeForms.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.EntradaSaida_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.EntradaSaida_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NumeroNf_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.NumeroNf_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.CfopDesc_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.CfopDesc_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cfop_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Cfop_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Nome_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Nome_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Cnpj_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Cnpj_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.DataEmissao_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.DataEmissao_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.Endereco_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Endereco_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Bairro_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.Bairro_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Cep_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.Cep_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.DataSaida_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.DataSaida_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.Cidade_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.Cidade_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.Fone_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.Fone_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.Inscricao_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.Inscricao_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.HoraSaida_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.HoraSaida_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.Dp1Posição_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.Dp1Posição_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.Dp2Posição_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.Dp2Posição_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.Dp3Posição_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.Dp3Posição_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.DescItens_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.DescItens_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.Cf_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.Cf_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.Unid_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.Unid_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.Qtd_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.Qtd_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.Unitario_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.Unitario_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.Total_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", Nz(Me.Total_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@49", Nz(Me.Icms_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@50", Nz(Me.Icms_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@51", Nz(Me.Ipi_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@52", Nz(Me.Ipi_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@53", Nz(Me.ValorIpi_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@54", Nz(Me.ValorIpi_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@55", Nz(Me.BaseCalcIcms_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@56", Nz(Me.BaseCalcIcms_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@57", Nz(Me.ValorIcms_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@58", Nz(Me.ValorIcms_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@59", Nz(Me.TotalProdutos_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@60", Nz(Me.TotalProdutos_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@61", Nz(Me.TotalIpi_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@62", Nz(Me.TotalIpi_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@63", Nz(Me.TotalNota_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@64", Nz(Me.TotalNota_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@65", Nz(Me.Transportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@66", Nz(Me.Transportadora_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@67", Nz(Me.EndTransportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@68", Nz(Me.EndTransportadora_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@69", Nz(Me.CidadeTransportador_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@70", Nz(Me.CidadeTransportador_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@71", Nz(Me.UfTransportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@72", Nz(Me.UfTransportadora_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@73", Nz(Me.IncricaoTransportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@74", Nz(Me.IncricaoTransportadora_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@75", Nz(Me.Observacao_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@76", Nz(Me.Observacao_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@77", Nz(Me.NumeroNota2_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@78", Nz(Me.NumeroNota2_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@79", Nz(Me.Desconto_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@80", Nz(Me.Desconto_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@81", Nz(Me.ImpressDp.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@82", Nz(Me.NomeForms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@83", Nz(Me.NomeFonte.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@84", Nz(Me.St_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@85", Nz(Me.St_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@86", Nz(Me.TamanhoFonte.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@87", Nz(Me.CodigoEmpresa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@88", Nz(Me.CasaDecimaisQtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@89", Nz(Me.CasaDecimaisValores.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@90", Nz(Me.Serviço_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@91", Nz(Me.Serviço_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@92", Nz(Me.AliquotaIss_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@93", Nz(Me.AliquotaIss_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@94", Nz(Me.ValorIss_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@95", Nz(Me.ValorIss_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@96", Nz(Me.ValorServiço_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@97", Nz(Me.ValorServiço_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@98", Nz(Me.ImprimirServiço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@99", Nz(Me.FreteContaDe_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@100", Nz(Me.FreteContaDe_Y.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@101", Nz(Me.PlacaTransportadora_X.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@102", Nz(Me.PlacaTransportadora_Y.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
            Catch er As OleDb.OleDbException
                MsgBox(er.Message)
            End Try
            MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()
        End If
    End Sub

    Private Sub NFCFG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim pkInstalledPrinters As String
        For Each pkInstalledPrinters In PrinterSettings.InstalledPrinters
            Impressora.Items.Add(pkInstalledPrinters)
        Next

        Me.TabControl1.SelectPreviousTab()

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

    Private Sub Padrão_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Padrão.Click
        Dim KeyReg As RegistryKey = Registry.LocalMachine.OpenSubKey("Software", True)
        Dim Key As RegistryKey = KeyReg.CreateSubKey("E-FocusNF")
        Dim PKey As RegistryKey = Key.CreateSubKey("Conf")


        PKey.SetValue("FormPadrao", Me.NomeForms.Text)
        NomeFormulario = Me.NomeForms.Text
        MsgBox("Formulario e Empresa Padrão definido", 64, "Validação de Dados")

    End Sub


    Private Sub Impress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impress.Click
        Dim KeyReg As RegistryKey = Registry.LocalMachine.OpenSubKey("Software", True)
        Dim Key As RegistryKey = KeyReg.CreateSubKey("E-FocusNF")
        Dim PKey As RegistryKey = Key.CreateSubKey("Conf")


        PKey.SetValue("ImpressNf", Me.Impressora.Text)
        ImpressPadrão = Me.Impressora.Text
        MsgBox("Impressora Padrão de Impressão de NF definida", 64, "Validação de Dados")

    End Sub


#Region "Modelo de Impressao de Nf"
    Private Sub VisualizarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizarModelo.Click

        Dim ppd As New PrintPreviewDialog()

        'Dim L As Integer = 23 * 38
        'Dim C As Integer = 27 * 38

        'Dim Papel As New PaperSize("Custom Paper Size", 900, 1000)


        Try
            ppd.Document = PDoc

            With PDoc.DefaultPageSettings
                .Landscape = False
                '       .PaperSize = Papel
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

        'Abertura de Banco de Dados para fazer o posicionamento das informações

        Dim CNN As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        Dim Sql As String = "Select * from ConfNfSystem where NomeForms = '" & NomeFormulario & "'"
        Dim CMD As New OleDbCommand(Sql, CNN)
        Dim DR As OleDbDataReader

        Try
            DR = CMD.ExecuteReader
            DR.Read()
        Catch px As Exception
            MsgBox("Não foi possiver ler o banco de dados de posições", 64, "Validação de Dados")
            Exit Sub
        End Try

        'e.Graphics.PageUnit = GraphicsUnit.Millimeter

        Dim PosVertical As Single = 0
        Dim Contador As Integer = 0
        Dim LinhasPorPagina As Single = 0
        Dim LinhaAtual As Integer = 0
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)
        Dim FFonte As String = DR.Item("NomeFonte")
        Dim TFonte As Integer = DR.Item("TamanhoFonte")
        Dim ImprimirDp As String = DR.Item("ImpressDp")

        Dim G As Graphics = e.Graphics
        Dim F As New Font(FFonte, TFonte, System.Drawing.GraphicsUnit.Point)


        'Entrada/Saida
        G.DrawString("X", F, Brushes.Black, DR.Item("EntradaSaida_X"), DR.Item("EntradaSaida_Y"), New StringFormat())
        'Fim

        'NumeroNf_X 
        G.DrawString("Nº 1010", F, Brushes.Black, DR.Item("NumeroNf_X"), DR.Item("NumeroNf_Y"), New StringFormat())
        'Fim

        'CfopDesc_X 
        G.DrawString("CfopDesc", F, Brushes.Black, DR.Item("CfopDesc_X"), DR.Item("CfopDesc_Y"), New StringFormat())
        'Fim

        'Cfop_X 
        G.DrawString("5101", F, Brushes.Black, DR.Item("Cfop_X"), DR.Item("Cfop_Y"), New StringFormat())
        'Fim

        'Nome_X 
        G.DrawString("Nome", F, Brushes.Black, DR.Item("Nome_X"), DR.Item("Nome_Y"), New StringFormat())
        'Fim

        'Cnpj_X 
        G.DrawString("Cnpj", F, Brushes.Black, DR.Item("Cnpj_X"), DR.Item("Cnpj_Y"), New StringFormat())
        'Fim

        'DataEmissao_X 
        G.DrawString("DataEmi", F, Brushes.Black, DR.Item("DataEmissao_X"), DR.Item("DataEmissao_Y"), New StringFormat())
        'Fim

        'Endereco_X 
        G.DrawString("Endereço", F, Brushes.Black, DR.Item("Endereco_X"), DR.Item("Endereco_Y"), New StringFormat())
        'Fim

        'Bairro_X 
        G.DrawString("Bairro", F, Brushes.Black, DR.Item("Bairro_X"), DR.Item("Bairro_Y"), New StringFormat())
        'Fim

        'Cep_X 
        G.DrawString("Cep", F, Brushes.Black, DR.Item("Cep_X"), DR.Item("Cep_Y"), New StringFormat())
        'Fim

        'DataSaida_X 
        G.DrawString("DataSaida", F, Brushes.Black, DR.Item("DataSaida_X"), DR.Item("DataSaida_Y"), New StringFormat())
        'Fim

        'Cidade_X 
        G.DrawString("Cidade", F, Brushes.Black, DR.Item("Cidade_X"), DR.Item("Cidade_Y"), New StringFormat())
        'Fim

        'Fone_X 
        G.DrawString("Fone", F, Brushes.Black, DR.Item("Fone_X"), DR.Item("Fone_Y"), New StringFormat())
        'Fim

        'Inscricao_X 
        G.DrawString("InscrEst", F, Brushes.Black, DR.Item("Inscricao_X"), DR.Item("Inscricao_Y"), New StringFormat())
        'Fim

        'HoraSaida_X 
        G.DrawString("HoraSaida", F, Brushes.Black, DR.Item("HoraSaida_X"), DR.Item("HoraSaida_Y"), New StringFormat())
        'Fim

        'Area destinadas a duplicatas
        If ImprimirDp = "S" Then

            Dim FonteReceber As New Font(FFonte, 8, System.Drawing.GraphicsUnit.Point)

            G.DrawString("Dp1", FonteReceber, Brushes.Black, DR.Item("Dp1Posição_X"), DR.Item("Dp1Posição_Y"), New StringFormat())
            G.DrawString("00/00/00", FonteReceber, Brushes.Black, DR.Item("Dp1Posição_X") + 60, DR.Item("Dp1Posição_Y"), New StringFormat())
            G.DrawString("00,00", FonteReceber, Brushes.Black, DR.Item("Dp1Posição_X") + 120, DR.Item("Dp1Posição_Y"), New StringFormat())

            G.DrawString("Dp2", FonteReceber, Brushes.Black, DR.Item("Dp2Posição_X"), DR.Item("Dp2Posição_Y"), New StringFormat())
            G.DrawString("00/00/00", FonteReceber, Brushes.Black, DR.Item("Dp2Posição_X") + 60, DR.Item("Dp2Posição_Y"), New StringFormat())
            G.DrawString("00,00", FonteReceber, Brushes.Black, DR.Item("Dp2Posição_X") + 120, DR.Item("Dp2Posição_Y"), New StringFormat())

            G.DrawString("Dp2", FonteReceber, Brushes.Black, DR.Item("Dp3Posição_X"), DR.Item("Dp3Posição_Y"), New StringFormat())
            G.DrawString("00/00/00", FonteReceber, Brushes.Black, DR.Item("Dp3Posição_X") + 60, DR.Item("Dp3Posição_Y"), New StringFormat())
            G.DrawString("00,00", FonteReceber, Brushes.Black, DR.Item("Dp3Posição_X") + 120, DR.Item("Dp3Posição_Y"), New StringFormat())

        End If
        'fim da area destinada a a duplicatas

        'Itens
        G.DrawString("Descrição Prod", F, Brushes.Black, DR.Item("DescItens_X"), DR.Item("DescItens_Y"), New StringFormat())
        G.DrawString("Cf", F, Brushes.Black, DR.Item("Cf_X"), DR.Item("Cf_Y"), New StringFormat())
        G.DrawString("St", F, Brushes.Black, DR.Item("St_X"), DR.Item("St_Y"), New StringFormat())
        G.DrawString("Unid", F, Brushes.Black, DR.Item("Unid_X"), DR.Item("Unid_Y"), New StringFormat())
        G.DrawString("Qtd", F, Brushes.Black, DR.Item("Qtd_X"), DR.Item("Qtd_Y"), New StringFormat())
        G.DrawString("Unit", F, Brushes.Black, DR.Item("Unitario_X"), DR.Item("Unitario_Y"), New StringFormat())
        G.DrawString("Total", F, Brushes.Black, DR.Item("Total_X"), DR.Item("Total_Y"), New StringFormat())
        G.DrawString("Icms", F, Brushes.Black, DR.Item("Icms_X"), DR.Item("Icms_Y"), New StringFormat())
        G.DrawString("Ipi", F, Brushes.Black, DR.Item("Ipi_X"), DR.Item("Ipi_Y"), New StringFormat())
        G.DrawString("VlrIpi", F, Brushes.Black, DR.Item("ValorIpi_X"), DR.Item("ValorIpi_Y"), New StringFormat())
        'fim dos Itens

        'Desconto_X 
        G.DrawString("Desconto", F, Brushes.Black, DR.Item("Desconto_X"), DR.Item("Desconto_Y"), New StringFormat())
        'Fim


        'Area de Serviços
        'Serviço_X 
        G.DrawString("Serviço", F, Brushes.Black, DR.Item("Serviço_X"), DR.Item("Serviço_Y"), New StringFormat())
        'Fim

        'AliquotaIss_X 
        G.DrawString("Aliquota", F, Brushes.Black, DR.Item("AliquotaIss_X"), DR.Item("AliquotaIss_Y"), New StringFormat())
        'Fim

        'ValorIss_X 
        G.DrawString("VlrIss", F, Brushes.Black, DR.Item("ValorIss_X"), DR.Item("ValorIss_Y"), New StringFormat())
        'Fim

        'ValorServiço_X 
        G.DrawString("VlrServiço", F, Brushes.Black, DR.Item("ValorServiço_X"), DR.Item("ValorServiço_Y"), New StringFormat())
        'Fim
        'Fim da area de serviços



        'BaseCalcIcms_X 
        G.DrawString("BcI", F, Brushes.Black, DR.Item("BaseCalcIcms_X"), DR.Item("BaseCalcIcms_Y"), New StringFormat())
        'Fim


        'ValorIcms_X 
        G.DrawString("VIcms", F, Brushes.Black, DR.Item("ValorIcms_X"), DR.Item("ValorIcms_Y"), New StringFormat())
        'Fim

        'TotalProdutos_X 
        G.DrawString("TProd", F, Brushes.Black, DR.Item("TotalProdutos_X"), DR.Item("TotalProdutos_Y"), New StringFormat())
        'Fim

        'TotalIpi_X 
        G.DrawString("TIpi", F, Brushes.Black, DR.Item("TotalIpi_X"), DR.Item("TotalIpi_Y"), New StringFormat())
        'Fim

        'TotalNota_X 
        G.DrawString("TNota", F, Brushes.Black, DR.Item("TotalNota_X"), DR.Item("TotalNota_Y"), New StringFormat())
        'Fim

        'Transportadora_X 
        G.DrawString("Transp", F, Brushes.Black, DR.Item("Transportadora_X"), DR.Item("Transportadora_Y"), New StringFormat())
        'Fim

        'Frete Conta de 
        G.DrawString("1", F, Brushes.Black, DR.Item("FreteContaDe_X"), DR.Item("FreteContaDe_Y"), New StringFormat())
        'Fim

        'Placa
        G.DrawString("Placa", F, Brushes.Black, DR.Item("PlacaTransportadora_X"), DR.Item("PlacaTransportadora_Y"), New StringFormat())
        'Fim


        'EndTransportadora_X 
        G.DrawString("End", F, Brushes.Black, DR.Item("EndTransportadora_X"), DR.Item("EndTransportadora_Y"), New StringFormat())
        'Fim

        'CidadeTransportador_X 
        G.DrawString("Cidade", F, Brushes.Black, DR.Item("CidadeTransportador_X"), DR.Item("CidadeTransportador_Y"), New StringFormat())
        'Fim

        'UfTransportadora_X 
        G.DrawString("UF", F, Brushes.Black, DR.Item("UfTransportadora_X"), DR.Item("UfTransportadora_Y"), New StringFormat())
        'Fim

        'IncricaoTransportadora_X 
        G.DrawString("Insc", F, Brushes.Black, DR.Item("IncricaoTransportadora_X"), DR.Item("IncricaoTransportadora_Y"), New StringFormat())
        'Fim

        'Observacao_X 
        G.DrawString("Obs", F, Brushes.Black, DR.Item("Observacao_X"), DR.Item("Observacao_Y"), New StringFormat())
        'Fim

        'NumeroNota2_X 
        G.DrawString("Nº", F, Brushes.Black, DR.Item("NumeroNota2_X"), DR.Item("NumeroNota2_Y"), New StringFormat())
        'Fim

    End Sub
#End Region


   
End Class
