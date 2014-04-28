<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelPedidoLiquido
    Inherits DataDynamics.ActiveReports.ActiveReport

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelPedidoLiquido))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.txtDescrição1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtDescricaoTipoPgto1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtAcrecimo1 = New DataDynamics.ActiveReports.TextBox()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.txtCodigoProduto1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtProdutoDescricao1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtUnidadeMedida1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtQtd1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtValorUnitario = New DataDynamics.ActiveReports.TextBox()
        Me.txtPercentual1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtVlrUnitLiq = New DataDynamics.ActiveReports.TextBox()
        Me.VlrLiquido = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.Line6 = New DataDynamics.ActiveReports.Line()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.ReportInfo2 = New DataDynamics.ActiveReports.ReportInfo()
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.txtEnderecoEmpresa1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCidadeEmpresa1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNomeFuncionario1 = New DataDynamics.ActiveReports.TextBox()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter()
        Me.txtDescrição2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtDescricaoTipoPgto2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.Line5 = New DataDynamics.ActiveReports.Line()
        Me.txtTotalPed1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label22 = New DataDynamics.ActiveReports.Label()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.txtPedSequencia1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtDataPed1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEndereço1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCidade1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTelefone1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCelular1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtBairro1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEstado1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtInativo1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNro1 = New DataDynamics.ActiveReports.TextBox()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtPedidoTipo1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescricaoTipoPgto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcrecimo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdutoDescricao1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidadeMedida1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercentual1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVlrUnitLiq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VlrLiquido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnderecoEmpresa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCidadeEmpresa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeFuncionario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrição2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescricaoTipoPgto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedSequencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataPed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndereço1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCidade1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelular1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBairro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInativo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedidoTipo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDescrição1, Me.txtDescricaoTipoPgto1, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.txtAcrecimo1})
        Me.PageHeader1.Height = 0.0!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtDescrição1
        '
        Me.txtDescrição1.DataField = "Descrição"
        Me.txtDescrição1.Height = 0.1968504!
        Me.txtDescrição1.Left = 7.135826!
        Me.txtDescrição1.Name = "txtDescrição1"
        Me.txtDescrição1.Text = "txtDescrição1"
        Me.txtDescrição1.Top = 0.07381889!
        Me.txtDescrição1.Visible = False
        Me.txtDescrição1.Width = 0.2214565!
        '
        'txtDescricaoTipoPgto1
        '
        Me.txtDescricaoTipoPgto1.DataField = "DescricaoTipoPgto"
        Me.txtDescricaoTipoPgto1.Height = 0.1968504!
        Me.txtDescricaoTipoPgto1.Left = 7.381889!
        Me.txtDescricaoTipoPgto1.Name = "txtDescricaoTipoPgto1"
        Me.txtDescricaoTipoPgto1.Text = "txtDescricaoTipoPgto1"
        Me.txtDescricaoTipoPgto1.Top = 0.07381889!
        Me.txtDescricaoTipoPgto1.Visible = False
        Me.txtDescricaoTipoPgto1.Width = 0.2460627!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "PedValorProdutos"
        Me.TextBox1.Height = 0.1968504!
        Me.TextBox1.Left = 6.25!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Text = "txtOrcValorProdutos1"
        Me.TextBox1.Top = 0.07381889!
        Me.TextBox1.Visible = False
        Me.TextBox1.Width = 0.2706693!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "PedVlrDescProduto"
        Me.TextBox2.Height = 0.1968504!
        Me.TextBox2.Left = 6.545275!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Text = "txtOrcVlrDescProduto1"
        Me.TextBox2.Top = 0.07381889!
        Me.TextBox2.Visible = False
        Me.TextBox2.Width = 0.2706693!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "TotalPedido"
        Me.TextBox3.Height = 0.1968504!
        Me.TextBox3.Left = 6.840551!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Text = "txtTotalOrc1"
        Me.TextBox3.Top = 0.07381889!
        Me.TextBox3.Visible = False
        Me.TextBox3.Width = 0.2706693!
        '
        'txtAcrecimo1
        '
        Me.txtAcrecimo1.DataField = "Acrecimo"
        Me.txtAcrecimo1.Height = 0.1968504!
        Me.txtAcrecimo1.Left = 5.758!
        Me.txtAcrecimo1.Name = "txtAcrecimo1"
        Me.txtAcrecimo1.Text = "txtAcrecimo1"
        Me.txtAcrecimo1.Top = 0.074!
        Me.txtAcrecimo1.Visible = False
        Me.txtAcrecimo1.Width = 0.2706694!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodigoProduto1, Me.txtProdutoDescricao1, Me.txtUnidadeMedida1, Me.txtQtd1, Me.txtValorUnitario, Me.txtPercentual1, Me.txtVlrUnitLiq, Me.VlrLiquido})
        Me.Detail1.Height = 0.1736111!
        Me.Detail1.Name = "Detail1"
        '
        'txtCodigoProduto1
        '
        Me.txtCodigoProduto1.DataField = "CodigoProduto"
        Me.txtCodigoProduto1.Height = 0.1722441!
        Me.txtCodigoProduto1.Left = 0.0246063!
        Me.txtCodigoProduto1.Name = "txtCodigoProduto1"
        Me.txtCodigoProduto1.OutputFormat = resources.GetString("txtCodigoProduto1.OutputFormat")
        Me.txtCodigoProduto1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCodigoProduto1.Text = "txtCodigoProduto1"
        Me.txtCodigoProduto1.Top = 0.0!
        Me.txtCodigoProduto1.Width = 0.6151575!
        '
        'txtProdutoDescricao1
        '
        Me.txtProdutoDescricao1.DataField = "ProdutoDescricao"
        Me.txtProdutoDescricao1.Height = 0.1722441!
        Me.txtProdutoDescricao1.Left = 0.6643701!
        Me.txtProdutoDescricao1.Name = "txtProdutoDescricao1"
        Me.txtProdutoDescricao1.Style = "font-size: 8pt; white-space: nowrap; ddo-char-set: 1"
        Me.txtProdutoDescricao1.Text = "txtProdutoDescricao1"
        Me.txtProdutoDescricao1.Top = 0.0!
        Me.txtProdutoDescricao1.Width = 3.80863!
        '
        'txtUnidadeMedida1
        '
        Me.txtUnidadeMedida1.DataField = "UnidadeMedida"
        Me.txtUnidadeMedida1.Height = 0.1722441!
        Me.txtUnidadeMedida1.Left = 4.525!
        Me.txtUnidadeMedida1.Name = "txtUnidadeMedida1"
        Me.txtUnidadeMedida1.Style = "font-size: 8pt; text-align: center; ddo-char-set: 1"
        Me.txtUnidadeMedida1.Text = "txtUnidadeMedida1"
        Me.txtUnidadeMedida1.Top = 0.0!
        Me.txtUnidadeMedida1.Width = 0.420866!
        '
        'txtQtd1
        '
        Me.txtQtd1.DataField = "Qtd"
        Me.txtQtd1.Height = 0.1722441!
        Me.txtQtd1.Left = 4.995275!
        Me.txtQtd1.Name = "txtQtd1"
        Me.txtQtd1.OutputFormat = resources.GetString("txtQtd1.OutputFormat")
        Me.txtQtd1.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtQtd1.Text = "txtQtd1"
        Me.txtQtd1.Top = 0.0!
        Me.txtQtd1.Width = 0.6889765!
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.DataField = "ValorUnitario"
        Me.txtValorUnitario.Height = 0.1722441!
        Me.txtValorUnitario.Left = 5.216142!
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.OutputFormat = resources.GetString("txtValorUnitario.OutputFormat")
        Me.txtValorUnitario.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtValorUnitario.Text = "txtValorUnitario1"
        Me.txtValorUnitario.Top = 0.2!
        Me.txtValorUnitario.Visible = False
        Me.txtValorUnitario.Width = 0.8366142!
        '
        'txtPercentual1
        '
        Me.txtPercentual1.DataField = "Percentual"
        Me.txtPercentual1.Height = 0.2!
        Me.txtPercentual1.Left = 4.634252!
        Me.txtPercentual1.Name = "txtPercentual1"
        Me.txtPercentual1.Text = "txtPercentual1"
        Me.txtPercentual1.Top = 0.2!
        Me.txtPercentual1.Visible = False
        Me.txtPercentual1.Width = 0.5326772!
        '
        'txtVlrUnitLiq
        '
        Me.txtVlrUnitLiq.Height = 0.1722441!
        Me.txtVlrUnitLiq.Left = 5.881103!
        Me.txtVlrUnitLiq.Name = "txtVlrUnitLiq"
        Me.txtVlrUnitLiq.OutputFormat = resources.GetString("txtVlrUnitLiq.OutputFormat")
        Me.txtVlrUnitLiq.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtVlrUnitLiq.Text = "txtVlrUnitLiq"
        Me.txtVlrUnitLiq.Top = 0.0!
        Me.txtVlrUnitLiq.Width = 0.8366139!
        '
        'VlrLiquido
        '
        Me.VlrLiquido.Height = 0.1722441!
        Me.VlrLiquido.Left = 6.750787!
        Me.VlrLiquido.Name = "VlrLiquido"
        Me.VlrLiquido.OutputFormat = resources.GetString("VlrLiquido.OutputFormat")
        Me.VlrLiquido.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.VlrLiquido.Text = Nothing
        Me.VlrLiquido.Top = 0.0!
        Me.VlrLiquido.Width = 0.9999995!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line6, Me.Label20, Me.ReportInfo2})
        Me.PageFooter1.Height = 0.2777778!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'Line6
        '
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.0!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.0246063!
        Me.Line6.Width = 7.775591!
        Me.Line6.X1 = 0.0!
        Me.Line6.X2 = 7.775591!
        Me.Line6.Y1 = 0.0246063!
        Me.Line6.Y2 = 0.0246063!
        '
        'Label20
        '
        Me.Label20.Height = 0.1722441!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.0!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label20.Text = "PEDIDO REIMPRESSO COM VALOR LIQUIDO"
        Me.Label20.Top = 0.0492126!
        Me.Label20.Width = 4.576772!
        '
        'ReportInfo2
        '
        Me.ReportInfo2.FormatString = "Pag.: {PageNumber} de {PageCount} : {RunDateTime}"
        Me.ReportInfo2.Height = 0.1968504!
        Me.ReportInfo2.Left = 4.625984!
        Me.ReportInfo2.Name = "ReportInfo2"
        Me.ReportInfo2.Style = "color: Black; font-family: Tahoma; font-size: 8pt; font-weight: normal; text-alig" & _
            "n: right; ddo-char-set: 1"
        Me.ReportInfo2.Top = 0.0492126!
        Me.ReportInfo2.Width = 3.125!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label23, Me.txtEnderecoEmpresa1, Me.txtCidadeEmpresa1, Me.txtNomeFuncionario1, Me.Line1})
        Me.ReportHeader1.Height = 0.7552493!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'Label23
        '
        Me.Label23.Height = 0.271!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.082!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-size: 14pt; font-weight: bold; ddo-char-set: 1"
        Me.Label23.Text = "Orçamento"
        Me.Label23.Top = 0.0!
        Me.Label23.Width = 4.576772!
        '
        'txtEnderecoEmpresa1
        '
        Me.txtEnderecoEmpresa1.DataField = "=EnderecoEmpresa  + "" - FONE "" + FoneEmpresa"
        Me.txtEnderecoEmpresa1.Height = 0.1968504!
        Me.txtEnderecoEmpresa1.Left = 0.09381889!
        Me.txtEnderecoEmpresa1.Name = "txtEnderecoEmpresa1"
        Me.txtEnderecoEmpresa1.Style = "font-size: 10pt; ddo-char-set: 1"
        Me.txtEnderecoEmpresa1.Text = "txtEnderecoEmpresa1"
        Me.txtEnderecoEmpresa1.Top = 0.3198819!
        Me.txtEnderecoEmpresa1.Width = 5.18218!
        '
        'txtCidadeEmpresa1
        '
        Me.txtCidadeEmpresa1.DataField = "=CidadeEmpresa + "" - "" + EstadoEmpresa  + "" - "" +  Cep"
        Me.txtCidadeEmpresa1.Height = 0.1968504!
        Me.txtCidadeEmpresa1.Left = 0.09381889!
        Me.txtCidadeEmpresa1.Name = "txtCidadeEmpresa1"
        Me.txtCidadeEmpresa1.Style = "font-size: 10pt; ddo-char-set: 1"
        Me.txtCidadeEmpresa1.Text = "txtCidadeEmpresa1"
        Me.txtCidadeEmpresa1.Top = 0.5167323!
        Me.txtCidadeEmpresa1.Width = 4.183072!
        '
        'txtNomeFuncionario1
        '
        Me.txtNomeFuncionario1.DataField = "=""Vendedor: "" + NomeFuncionario + "" - "" + FoneFuncionario"
        Me.txtNomeFuncionario1.Height = 0.1968504!
        Me.txtNomeFuncionario1.Left = 4.276999!
        Me.txtNomeFuncionario1.Name = "txtNomeFuncionario1"
        Me.txtNomeFuncionario1.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.txtNomeFuncionario1.Text = "txtNomeFuncionario1"
        Me.txtNomeFuncionario1.Top = 0.517!
        Me.txtNomeFuncionario1.Width = 3.444882!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.024!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.714!
        Me.Line1.Width = 7.77559!
        Me.Line1.X1 = 0.024!
        Me.Line1.X2 = 7.79959!
        Me.Line1.Y1 = 0.714!
        Me.Line1.Y2 = 0.714!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDescrição2, Me.txtDescricaoTipoPgto2, Me.Label18, Me.Label19, Me.Line5, Me.txtTotalPed1, Me.Label22, Me.TextBox4, Me.TextBox5})
        Me.ReportFooter1.Height = 0.541666!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'txtDescrição2
        '
        Me.txtDescrição2.DataField = "Descrição"
        Me.txtDescrição2.Height = 0.1968504!
        Me.txtDescrição2.Left = 0.8366142!
        Me.txtDescrição2.Name = "txtDescrição2"
        Me.txtDescrição2.Text = "txtDescrição2"
        Me.txtDescrição2.Top = 0.0492126!
        Me.txtDescrição2.Width = 2.65748!
        '
        'txtDescricaoTipoPgto2
        '
        Me.txtDescricaoTipoPgto2.DataField = "DescricaoTipoPgto"
        Me.txtDescricaoTipoPgto2.Height = 0.1968504!
        Me.txtDescricaoTipoPgto2.Left = 0.8366142!
        Me.txtDescricaoTipoPgto2.Name = "txtDescricaoTipoPgto2"
        Me.txtDescricaoTipoPgto2.Text = "txtDescricaoTipoPgto2"
        Me.txtDescricaoTipoPgto2.Top = 0.246063!
        Me.txtDescricaoTipoPgto2.Width = 2.65748!
        '
        'Label18
        '
        Me.Label18.Height = 0.1722441!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.0492126!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label18.Text = "Forma Pgto:"
        Me.Label18.Top = 0.0492126!
        Me.Label18.Width = 0.738189!
        '
        'Label19
        '
        Me.Label19.Height = 0.1722441!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.0492126!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label19.Text = "Prazo:"
        Me.Label19.Top = 0.246063!
        Me.Label19.Width = 0.738189!
        '
        'Line5
        '
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 0.0!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0246063!
        Me.Line5.Width = 7.775591!
        Me.Line5.X1 = 0.0!
        Me.Line5.X2 = 7.775591!
        Me.Line5.Y1 = 0.0246063!
        Me.Line5.Y2 = 0.0246063!
        '
        'txtTotalPed1
        '
        Me.txtTotalPed1.DataField = "TotalPedido"
        Me.txtTotalPed1.Height = 0.1968504!
        Me.txtTotalPed1.Left = 6.643701!
        Me.txtTotalPed1.Name = "txtTotalPed1"
        Me.txtTotalPed1.OutputFormat = resources.GetString("txtTotalPed1.OutputFormat")
        Me.txtTotalPed1.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.txtTotalPed1.Text = "txtTotalOrc1"
        Me.txtTotalPed1.Top = 0.09842518!
        Me.txtTotalPed1.Width = 1.107283!
        '
        'Label22
        '
        Me.Label22.Height = 0.1722441!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 5.684056!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label22.Text = "Total Liquido:"
        Me.Label22.Top = 0.1230315!
        Me.Label22.Width = 0.9104328!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "PedVlrDescProduto"
        Me.TextBox4.Height = 0.1968504!
        Me.TextBox4.Left = 3.764764!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Text = "txtOrcVlrDescProduto1"
        Me.TextBox4.Top = 0.0984252!
        Me.TextBox4.Visible = False
        Me.TextBox4.Width = 1.008858!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "Acrecimo"
        Me.TextBox5.Height = 0.1968504!
        Me.TextBox5.Left = 3.764961!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Text = "txtAcrecimo1"
        Me.TextBox5.Top = 0.2952756!
        Me.TextBox5.Visible = False
        Me.TextBox5.Width = 0.9842517!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label6
        '
        Me.Label6.Height = 0.1722441!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.07381889!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label6.Text = "Cidade:"
        Me.Label6.Top = 0.6635507!
        Me.Label6.Width = 0.6561811!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.2698507!
        Me.Line2.Width = 7.77559!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.77559!
        Me.Line2.Y1 = 0.2698507!
        Me.Line2.Y2 = 0.2698507!
        '
        'Label2
        '
        Me.Label2.Height = 0.162!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.074!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.Label2.Text = "Pedido:"
        Me.Label2.Top = 0.053!
        Me.Label2.Width = 0.8366139!
        '
        'txtPedSequencia1
        '
        Me.txtPedSequencia1.CanGrow = False
        Me.txtPedSequencia1.DataField = "PedidoSequencia"
        Me.txtPedSequencia1.Height = 0.1897559!
        Me.txtPedSequencia1.Left = 0.9352207!
        Me.txtPedSequencia1.Name = "txtPedSequencia1"
        Me.txtPedSequencia1.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.txtPedSequencia1.Text = "txtOrcSequencia1"
        Me.txtPedSequencia1.Top = 0.053!
        Me.txtPedSequencia1.Width = 1.0!
        '
        'txtDataPed1
        '
        Me.txtDataPed1.DataField = "DataPedido"
        Me.txtDataPed1.Height = 0.1897559!
        Me.txtDataPed1.Left = 6.717701!
        Me.txtDataPed1.Name = "txtDataPed1"
        Me.txtDataPed1.OutputFormat = resources.GetString("txtDataPed1.OutputFormat")
        Me.txtDataPed1.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.txtDataPed1.Text = "txtDataOrc1"
        Me.txtDataPed1.Top = 0.053!
        Me.txtDataPed1.Width = 1.0!
        '
        'Label3
        '
        Me.Label3.Height = 0.162!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.905694!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.Label3.Text = "Data..:"
        Me.Label3.Top = 0.053!
        Me.Label3.Width = 0.7627952!
        '
        'Label4
        '
        Me.Label4.Height = 0.1722441!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.07381889!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label4.Text = "Cliente:"
        Me.Label4.Top = 0.3190625!
        Me.Label4.Width = 0.6561811!
        '
        'Label5
        '
        Me.Label5.Height = 0.1722441!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.07381889!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label5.Text = "Endereço:"
        Me.Label5.Top = 0.4913069!
        Me.Label5.Width = 0.6561811!
        '
        'Label7
        '
        Me.Label7.Height = 0.1722441!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.971842!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label7.Text = "Telefone:"
        Me.Label7.Top = 0.491!
        Me.Label7.Width = 0.5905511!
        '
        'Label8
        '
        Me.Label8.Height = 0.1722441!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.972!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label8.Text = "Celular..:"
        Me.Label8.Top = 0.3190625!
        Me.Label8.Width = 0.6224875!
        '
        'Label9
        '
        Me.Label9.Height = 0.1722441!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 3.548!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label9.Text = "Bairro:"
        Me.Label9.Top = 0.491!
        Me.Label9.Width = 0.413!
        '
        'Label10
        '
        Me.Label10.Height = 0.1722441!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 4.256889!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label10.Text = "UF:"
        Me.Label10.Top = 0.6635507!
        Me.Label10.Width = 0.5905511!
        '
        'txtNome1
        '
        Me.txtNome1.DataField = "=Nome + "" - "" + Codigo"
        Me.txtNome1.Height = 0.1722441!
        Me.txtNome1.Left = 0.8049999!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.3189611!
        Me.txtNome1.Width = 3.72!
        '
        'txtEndereço1
        '
        Me.txtEndereço1.DataField = "Endereço"
        Me.txtEndereço1.Height = 0.1722441!
        Me.txtEndereço1.Left = 0.8049999!
        Me.txtEndereço1.Name = "txtEndereço1"
        Me.txtEndereço1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtEndereço1.Text = "txtEndereço1"
        Me.txtEndereço1.Top = 0.4912049!
        Me.txtEndereço1.Width = 2.176!
        '
        'txtCidade1
        '
        Me.txtCidade1.DataField = "Cidade"
        Me.txtCidade1.Height = 0.1722441!
        Me.txtCidade1.Left = 0.8049999!
        Me.txtCidade1.Name = "txtCidade1"
        Me.txtCidade1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCidade1.Text = "txtCidade1"
        Me.txtCidade1.Top = 0.6634486!
        Me.txtCidade1.Width = 2.742913!
        '
        'txtTelefone1
        '
        Me.txtTelefone1.DataField = "Telefone"
        Me.txtTelefone1.Height = 0.1722441!
        Me.txtTelefone1.Left = 6.587!
        Me.txtTelefone1.Name = "txtTelefone1"
        Me.txtTelefone1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtTelefone1.Text = "txtTelefone1"
        Me.txtTelefone1.Top = 0.491!
        Me.txtTelefone1.Width = 1.156496!
        '
        'txtCelular1
        '
        Me.txtCelular1.DataField = "Celular"
        Me.txtCelular1.Height = 0.1722441!
        Me.txtCelular1.Left = 6.594489!
        Me.txtCelular1.Name = "txtCelular1"
        Me.txtCelular1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCelular1.Text = "txtCelular1"
        Me.txtCelular1.Top = 0.3190625!
        Me.txtCelular1.Width = 1.13189!
        '
        'txtBairro1
        '
        Me.txtBairro1.DataField = "Bairro"
        Me.txtBairro1.Height = 0.1722441!
        Me.txtBairro1.Left = 3.961!
        Me.txtBairro1.Name = "txtBairro1"
        Me.txtBairro1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtBairro1.Text = "txtBairro1"
        Me.txtBairro1.Top = 0.491!
        Me.txtBairro1.Width = 1.963!
        '
        'txtEstado1
        '
        Me.txtEstado1.DataField = "Estado"
        Me.txtEstado1.Height = 0.1722441!
        Me.txtEstado1.Left = 4.872047!
        Me.txtEstado1.Name = "txtEstado1"
        Me.txtEstado1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtEstado1.Text = "txtEstado1"
        Me.txtEstado1.Top = 0.6635507!
        Me.txtEstado1.Width = 0.6397635!
        '
        'txtInativo1
        '
        Me.txtInativo1.DataField = "Inativo"
        Me.txtInativo1.Height = 0.2!
        Me.txtInativo1.Left = 6.5625!
        Me.txtInativo1.Name = "txtInativo1"
        Me.txtInativo1.Text = "txtInativo1"
        Me.txtInativo1.Top = 0.8102049!
        Me.txtInativo1.Visible = False
        Me.txtInativo1.Width = 1.0!
        '
        'txtNro1
        '
        Me.txtNro1.DataField = "Nro"
        Me.txtNro1.Height = 0.172!
        Me.txtNro1.Left = 2.988!
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Style = "ddo-char-set: 1"
        Me.txtNro1.Text = "txtNro1"
        Me.txtNro1.Top = 0.491!
        Me.txtNro1.Width = 0.5060002!
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.025!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.104!
        Me.Line4.Width = 7.775591!
        Me.Line4.X1 = 0.025!
        Me.Line4.X2 = 7.800591!
        Me.Line4.Y1 = 1.104!
        Me.Line4.Y2 = 1.104!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.02423626!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.8920001!
        Me.Line3.Width = 7.77559!
        Me.Line3.X1 = 0.02423626!
        Me.Line3.X2 = 7.799826!
        Me.Line3.Y1 = 0.8920001!
        Me.Line3.Y2 = 0.8920001!
        '
        'Label11
        '
        Me.Label11.Height = 0.1722441!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.04884256!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label11.Text = "Codigo"
        Me.Label11.Top = 0.8920001!
        Me.Label11.Width = 0.6151575!
        '
        'Label12
        '
        Me.Label12.Height = 0.1722441!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.664!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label12.Text = "Descrição do Produto"
        Me.Label12.Top = 0.8920001!
        Me.Label12.Width = 3.198819!
        '
        'Label13
        '
        Me.Label13.Height = 0.1722441!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 4.257!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Label13.Text = "Un.M"
        Me.Label13.Top = 0.8920001!
        Me.Label13.Width = 0.73771!
        '
        'Label14
        '
        Me.Label14.Height = 0.1722441!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 5.068724!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label14.Text = "Qtd"
        Me.Label14.Top = 0.8920001!
        Me.Label14.Width = 0.639764!
        '
        'Label15
        '
        Me.Label15.Height = 0.1722441!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 5.881103!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label15.Text = "Vlr. Unit."
        Me.Label15.Top = 0.892126!
        Me.Label15.Width = 0.8366139!
        '
        'Label17
        '
        Me.Label17.Height = 0.1722441!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 6.864787!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label17.Text = "Total"
        Me.Label17.Top = 0.8920001!
        Me.Label17.Width = 0.8858271!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.Line2, Me.Label6, Me.txtPedSequencia1, Me.txtDataPed1, Me.Label3, Me.Label4, Me.Label5, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.txtNome1, Me.txtEndereço1, Me.txtCidade1, Me.txtTelefone1, Me.txtCelular1, Me.txtBairro1, Me.txtEstado1, Me.txtInativo1, Me.txtNro1, Me.Line3, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label17, Me.Line4, Me.txtPedidoTipo1, Me.Label24, Me.Label1, Me.TextBox6})
        Me.GroupHeader2.Height = 1.21875!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'txtPedidoTipo1
        '
        Me.txtPedidoTipo1.DataField = "PedidoTipo"
        Me.txtPedidoTipo1.Height = 0.2!
        Me.txtPedidoTipo1.Left = 3.576772!
        Me.txtPedidoTipo1.Name = "txtPedidoTipo1"
        Me.txtPedidoTipo1.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.txtPedidoTipo1.Text = "txtPedidoTipo1"
        Me.txtPedidoTipo1.Top = 0.04291344!
        Me.txtPedidoTipo1.Width = 1.875197!
        '
        'Label24
        '
        Me.Label24.Height = 0.1897638!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 2.479134!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label24.Text = "Tipo...:"
        Me.Label24.Top = 0.04291338!
        Me.Label24.Width = 1.068898!
        '
        'Label1
        '
        Me.Label1.Height = 0.152!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 4.577!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label1.Text = "Contrato:"
        Me.Label1.Top = 0.319!
        Me.Label1.Width = 0.5500002!
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "Contrato"
        Me.TextBox6.Height = 0.1722441!
        Me.TextBox6.Left = 5.167!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox6.Text = "txtContrato1"
        Me.TextBox6.Top = 0.319!
        Me.TextBox6.Width = 0.7568903!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Height = 0.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'RelPedidoLiquido
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\Dados\CD\upDados.mdb;Persist Secu" & _
            "rity Info=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.1968504!
        Me.PageSettings.Margins.Left = 0.1968504!
        Me.PageSettings.Margins.Right = 0.1968504!
        Me.PageSettings.Margins.Top = 0.1968504!
        Me.PageSettings.PaperHeight = 5.51!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 8.26378!
        Me.PrintWidth = 7.860882!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; color: Black; fon" & _
                    "t-family: ""Tahoma""; font-size: 8pt; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; color: Black; font-family: ""Tahoma""; d" & _
                    "do-char-set: 204; font-size: 14pt; font-weight: bold", "Modelo Cabeçalho"))
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescricaoTipoPgto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcrecimo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdutoDescricao1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidadeMedida1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercentual1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVlrUnitLiq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VlrLiquido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnderecoEmpresa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCidadeEmpresa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeFuncionario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrição2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescricaoTipoPgto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedSequencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataPed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndereço1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCidade1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelular1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBairro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInativo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedidoTipo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCodigoProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtProdutoDescricao1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUnidadeMedida1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQtd1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorUnitario As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtDescrição2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescricaoTipoPgto2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label18 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label19 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label20 As DataDynamics.ActiveReports.Label
    Friend WithEvents ReportInfo2 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents txtTotalPed1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label22 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNomeFuncionario1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtCidadeEmpresa1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents txtDescrição1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtDescricaoTipoPgto1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtAcrecimo1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtEnderecoEmpresa1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents txtPedSequencia1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtDataPed1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtEndereço1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtCidade1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtTelefone1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtCelular1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtBairro1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtEstado1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtInativo1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNro1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtPedidoTipo1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtPercentual1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtVlrUnitLiq As DataDynamics.ActiveReports.TextBox
    Private WithEvents VlrLiquido As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
End Class
