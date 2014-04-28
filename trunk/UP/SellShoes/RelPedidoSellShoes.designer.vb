<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelPedidoSellShoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelPedidoSellShoes))
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
        Me.txtValorUnitario1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtValorDesconto1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTotalProduto1 = New DataDynamics.ActiveReports.TextBox()
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
        Me.txtPedSequencia1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.txtDataPed1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.lblReimpresso = New DataDynamics.ActiveReports.Label()
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter()
        Me.Line5 = New DataDynamics.ActiveReports.Line()
        Me.txtPedValorProdutos1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtPedVlrDescProduto1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTotalPed1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label21 = New DataDynamics.ActiveReports.Label()
        Me.Label22 = New DataDynamics.ActiveReports.Label()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.Parcelas = New DataDynamics.ActiveReports.SubReport()
        Me.lblmsgCancelado = New DataDynamics.ActiveReports.Label()
        Me.txtDescrição2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtDescricaoTipoPgto2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEndereço1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCidade1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTelefone1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCelular1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtBairro1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtInativo1 = New DataDynamics.ActiveReports.TextBox()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtPedidoTipo1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.txtCpfCgc1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.Label25 = New DataDynamics.ActiveReports.Label()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
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
        CType(Me.txtValorUnitario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDesconto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnderecoEmpresa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCidadeEmpresa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeFuncionario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedSequencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataPed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReimpresso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedValorProdutos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedVlrDescProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblmsgCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrição2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescricaoTipoPgto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndereço1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCidade1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelular1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBairro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInativo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedidoTipo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCpfCgc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodigoProduto1, Me.txtProdutoDescricao1, Me.txtUnidadeMedida1, Me.txtQtd1, Me.txtValorUnitario1, Me.txtValorDesconto1, Me.txtTotalProduto1})
        Me.Detail1.Height = 0.1631608!
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
        Me.txtProdutoDescricao1.Width = 4.033662!
        '
        'txtUnidadeMedida1
        '
        Me.txtUnidadeMedida1.DataField = "UnidadeMedida"
        Me.txtUnidadeMedida1.Height = 0.1722441!
        Me.txtUnidadeMedida1.Left = 4.757087!
        Me.txtUnidadeMedida1.Name = "txtUnidadeMedida1"
        Me.txtUnidadeMedida1.Style = "font-size: 8pt; text-align: center; ddo-char-set: 1"
        Me.txtUnidadeMedida1.Text = "txtUnidadeMedida1"
        Me.txtUnidadeMedida1.Top = 0.0!
        Me.txtUnidadeMedida1.Width = 0.4558816!
        '
        'txtQtd1
        '
        Me.txtQtd1.DataField = "Qtd"
        Me.txtQtd1.Height = 0.1722441!
        Me.txtQtd1.Left = 5.246725!
        Me.txtQtd1.Name = "txtQtd1"
        Me.txtQtd1.OutputFormat = resources.GetString("txtQtd1.OutputFormat")
        Me.txtQtd1.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtQtd1.Text = "txtQtd1"
        Me.txtQtd1.Top = 0.0!
        Me.txtQtd1.Width = 0.7819762!
        '
        'txtValorUnitario1
        '
        Me.txtValorUnitario1.DataField = "ValorUnitario"
        Me.txtValorUnitario1.Height = 0.1722441!
        Me.txtValorUnitario1.Left = 6.079087!
        Me.txtValorUnitario1.Name = "txtValorUnitario1"
        Me.txtValorUnitario1.OutputFormat = resources.GetString("txtValorUnitario1.OutputFormat")
        Me.txtValorUnitario1.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtValorUnitario1.Text = "txtValorUnitario1"
        Me.txtValorUnitario1.Top = 0.0!
        Me.txtValorUnitario1.Width = 0.6799369!
        '
        'txtValorDesconto1
        '
        Me.txtValorDesconto1.DataField = "Desc"
        Me.txtValorDesconto1.Height = 0.1722441!
        Me.txtValorDesconto1.Left = 6.028543!
        Me.txtValorDesconto1.Name = "txtValorDesconto1"
        Me.txtValorDesconto1.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtValorDesconto1.Text = "txtValorDesconto1"
        Me.txtValorDesconto1.Top = 0.0!
        Me.txtValorDesconto1.Visible = False
        Me.txtValorDesconto1.Width = 0.7627954!
        '
        'txtTotalProduto1
        '
        Me.txtTotalProduto1.DataField = "TotalProduto"
        Me.txtTotalProduto1.Height = 0.1722441!
        Me.txtTotalProduto1.Left = 6.840551!
        Me.txtTotalProduto1.Name = "txtTotalProduto1"
        Me.txtTotalProduto1.OutputFormat = resources.GetString("txtTotalProduto1.OutputFormat")
        Me.txtTotalProduto1.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtTotalProduto1.Text = "txtTotalProduto1"
        Me.txtTotalProduto1.Top = 0.0!
        Me.txtTotalProduto1.Width = 0.8858268!
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
        Me.Label20.Text = "ECONOMIZE ENERGIA. RECICLAR MATERIAIS É PRESERVAR O MEIO AMBIENTE"
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
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label23, Me.txtEnderecoEmpresa1, Me.txtCidadeEmpresa1, Me.txtNomeFuncionario1, Me.Line1, Me.txtPedSequencia1, Me.Label2, Me.txtDataPed1, Me.Label3, Me.lblReimpresso})
        Me.ReportHeader1.Height = 0.6927493!
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
        Me.Label23.Width = 2.087!
        '
        'txtEnderecoEmpresa1
        '
        Me.txtEnderecoEmpresa1.DataField = "=EnderecoEmpresa  + "" - FONE "" + FoneEmpresa"
        Me.txtEnderecoEmpresa1.Height = 0.1968504!
        Me.txtEnderecoEmpresa1.Left = 0.094!
        Me.txtEnderecoEmpresa1.Name = "txtEnderecoEmpresa1"
        Me.txtEnderecoEmpresa1.Style = "font-size: 10pt; ddo-char-set: 1"
        Me.txtEnderecoEmpresa1.Text = "txtEnderecoEmpresa1"
        Me.txtEnderecoEmpresa1.Top = 0.271!
        Me.txtEnderecoEmpresa1.Width = 4.565182!
        '
        'txtCidadeEmpresa1
        '
        Me.txtCidadeEmpresa1.DataField = "=CidadeEmpresa + "" - "" + EstadoEmpresa  + "" - "" +  Cep"
        Me.txtCidadeEmpresa1.Height = 0.1968504!
        Me.txtCidadeEmpresa1.Left = 0.094!
        Me.txtCidadeEmpresa1.Name = "txtCidadeEmpresa1"
        Me.txtCidadeEmpresa1.Style = "font-size: 10pt; ddo-char-set: 1"
        Me.txtCidadeEmpresa1.Text = "txtCidadeEmpresa1"
        Me.txtCidadeEmpresa1.Top = 0.468!
        Me.txtCidadeEmpresa1.Width = 4.183072!
        '
        'txtNomeFuncionario1
        '
        Me.txtNomeFuncionario1.DataField = "=""Vendedor: "" + NomeFuncionario + "" - "" + FoneFuncionario"
        Me.txtNomeFuncionario1.Height = 0.146!
        Me.txtNomeFuncionario1.Left = 4.277!
        Me.txtNomeFuncionario1.Name = "txtNomeFuncionario1"
        Me.txtNomeFuncionario1.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
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
        Me.Line1.Top = 0.684!
        Me.Line1.Width = 7.77559!
        Me.Line1.X1 = 0.024!
        Me.Line1.X2 = 7.79959!
        Me.Line1.Y1 = 0.684!
        Me.Line1.Y2 = 0.684!
        '
        'txtPedSequencia1
        '
        Me.txtPedSequencia1.CanGrow = False
        Me.txtPedSequencia1.DataField = "PedidoSequencia"
        Me.txtPedSequencia1.Height = 0.1897559!
        Me.txtPedSequencia1.Left = 6.816!
        Me.txtPedSequencia1.Name = "txtPedSequencia1"
        Me.txtPedSequencia1.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.txtPedSequencia1.Text = "txtOrcSequencia1"
        Me.txtPedSequencia1.Top = 0.0!
        Me.txtPedSequencia1.Width = 1.0!
        '
        'Label2
        '
        Me.Label2.Height = 0.162!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 6.163!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.Label2.Text = "Pedido:"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.6283932!
        '
        'txtDataPed1
        '
        Me.txtDataPed1.DataField = "DataPedido"
        Me.txtDataPed1.Height = 0.1897559!
        Me.txtDataPed1.Left = 6.816!
        Me.txtDataPed1.Name = "txtDataPed1"
        Me.txtDataPed1.OutputFormat = resources.GetString("txtDataPed1.OutputFormat")
        Me.txtDataPed1.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.txtDataPed1.Text = "txtDataOrc1"
        Me.txtDataPed1.Top = 0.231!
        Me.txtDataPed1.Width = 1.0!
        '
        'Label3
        '
        Me.Label3.Height = 0.162!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 6.163221!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.Label3.Text = "Data....:"
        Me.Label3.Top = 0.231!
        Me.Label3.Width = 0.6277795!
        '
        'lblReimpresso
        '
        Me.lblReimpresso.Height = 0.187!
        Me.lblReimpresso.HyperLink = Nothing
        Me.lblReimpresso.Left = 2.358!
        Me.lblReimpresso.Name = "lblReimpresso"
        Me.lblReimpresso.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.lblReimpresso.Text = "***PEDIDO REIMPRESSO***"
        Me.lblReimpresso.Top = 0.044!
        Me.lblReimpresso.Visible = False
        Me.lblReimpresso.Width = 2.156!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line5, Me.txtPedValorProdutos1, Me.txtPedVlrDescProduto1, Me.txtTotalPed1, Me.Label1, Me.Label21, Me.Label22, Me.TextBox4, Me.TextBox5, Me.Parcelas, Me.lblmsgCancelado})
        Me.ReportFooter1.Height = 0.6770831!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        'txtPedValorProdutos1
        '
        Me.txtPedValorProdutos1.DataField = "PedValorProdutos"
        Me.txtPedValorProdutos1.Height = 0.1968504!
        Me.txtPedValorProdutos1.Left = 6.619094!
        Me.txtPedValorProdutos1.Name = "txtPedValorProdutos1"
        Me.txtPedValorProdutos1.OutputFormat = resources.GetString("txtPedValorProdutos1.OutputFormat")
        Me.txtPedValorProdutos1.Style = "text-align: right"
        Me.txtPedValorProdutos1.Text = "txtOrcValorProdutos1"
        Me.txtPedValorProdutos1.Top = 0.0246063!
        Me.txtPedValorProdutos1.Width = 1.107283!
        '
        'txtPedVlrDescProduto1
        '
        Me.txtPedVlrDescProduto1.Height = 0.1968504!
        Me.txtPedVlrDescProduto1.Left = 6.619094!
        Me.txtPedVlrDescProduto1.Name = "txtPedVlrDescProduto1"
        Me.txtPedVlrDescProduto1.OutputFormat = resources.GetString("txtPedVlrDescProduto1.OutputFormat")
        Me.txtPedVlrDescProduto1.Style = "text-align: right"
        Me.txtPedVlrDescProduto1.Text = "txtOrcVlrDescProduto1"
        Me.txtPedVlrDescProduto1.Top = 0.2214567!
        Me.txtPedVlrDescProduto1.Width = 1.107283!
        '
        'txtTotalPed1
        '
        Me.txtTotalPed1.DataField = "TotalPedido"
        Me.txtTotalPed1.Height = 0.1968504!
        Me.txtTotalPed1.Left = 6.619094!
        Me.txtTotalPed1.Name = "txtTotalPed1"
        Me.txtTotalPed1.OutputFormat = resources.GetString("txtTotalPed1.OutputFormat")
        Me.txtTotalPed1.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.txtTotalPed1.Text = "txtTotalOrc1"
        Me.txtTotalPed1.Top = 0.4183071!
        Me.txtTotalPed1.Width = 1.107283!
        '
        'Label1
        '
        Me.Label1.Height = 0.1722441!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.659449!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label1.Text = "Total a Prazo:"
        Me.Label1.Top = 0.0492126!
        Me.Label1.Width = 0.9104328!
        '
        'Label21
        '
        Me.Label21.Height = 0.1722441!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 5.659449!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label21.Text = "Ajuste(+)ou(-)"
        Me.Label21.Top = 0.246063!
        Me.Label21.Width = 0.9104328!
        '
        'Label22
        '
        Me.Label22.Height = 0.1722441!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 5.659449!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label22.Text = "Total Liquido:"
        Me.Label22.Top = 0.4429134!
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
        Me.TextBox5.Left = 3.723!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Text = "txtAcrecimo1"
        Me.TextBox5.Top = 0.295!
        Me.TextBox5.Visible = False
        Me.TextBox5.Width = 0.9842517!
        '
        'Parcelas
        '
        Me.Parcelas.CloseBorder = False
        Me.Parcelas.Height = 0.4375!
        Me.Parcelas.Left = 0.024!
        Me.Parcelas.Name = "Parcelas"
        Me.Parcelas.Report = Nothing
        Me.Parcelas.ReportName = ""
        Me.Parcelas.Top = 0.04899999!
        Me.Parcelas.Width = 3.4375!
        '
        'lblmsgCancelado
        '
        Me.lblmsgCancelado.Height = 0.187!
        Me.lblmsgCancelado.HyperLink = Nothing
        Me.lblmsgCancelado.Left = 3.461!
        Me.lblmsgCancelado.Name = "lblmsgCancelado"
        Me.lblmsgCancelado.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.lblmsgCancelado.Text = "***PEDIDO CANCELADO***"
        Me.lblmsgCancelado.Top = 0.344!
        Me.lblmsgCancelado.Visible = False
        Me.lblmsgCancelado.Width = 2.156!
        '
        'txtDescrição2
        '
        Me.txtDescrição2.DataField = "Descrição"
        Me.txtDescrição2.Height = 0.17!
        Me.txtDescrição2.Left = 0.7876298!
        Me.txtDescrição2.Name = "txtDescrição2"
        Me.txtDescrição2.Text = "txtDescrição2"
        Me.txtDescrição2.Top = 0.01508656!
        Me.txtDescrição2.Width = 2.105598!
        '
        'txtDescricaoTipoPgto2
        '
        Me.txtDescricaoTipoPgto2.DataField = "DescricaoTipoPgto"
        Me.txtDescricaoTipoPgto2.Height = 0.17!
        Me.txtDescricaoTipoPgto2.Left = 5.848228!
        Me.txtDescricaoTipoPgto2.Name = "txtDescricaoTipoPgto2"
        Me.txtDescricaoTipoPgto2.Text = "txtDescricaoTipoPgto2"
        Me.txtDescricaoTipoPgto2.Top = 0.01508656!
        Me.txtDescricaoTipoPgto2.Width = 1.968!
        '
        'Label18
        '
        Me.Label18.Height = 0.1722441!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.0002281666!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label18.Text = "Forma Pgto:"
        Me.Label18.Top = 0.01508656!
        Me.Label18.Width = 0.738189!
        '
        'Label19
        '
        Me.Label19.Height = 0.17!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 5.349229!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label19.Text = "Prazo:"
        Me.Label19.Top = 0.02208656!
        Me.Label19.Width = 0.4991889!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox6})
        Me.GroupFooter1.Height = 0.1504167!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "EnderecoEntrega"
        Me.TextBox6.Height = 0.15!
        Me.TextBox6.Left = 0.049!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Text = "LocalEntrega"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 4.528!
        '
        'Label6
        '
        Me.Label6.Height = 0.152!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.074!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.Label6.Text = "Cidade:"
        Me.Label6.Top = 0.563!
        Me.Label6.Width = 0.591!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.199!
        Me.Line2.Width = 7.77559!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.77559!
        Me.Line2.Y1 = 0.199!
        Me.Line2.Y2 = 0.199!
        '
        'Label4
        '
        Me.Label4.Height = 0.152!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.074!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.Label4.Text = "Cliente:"
        Me.Label4.Top = 0.2285118!
        Me.Label4.Width = 0.591!
        '
        'Label5
        '
        Me.Label5.Height = 0.152!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.074!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.Label5.Text = "Endereço:"
        Me.Label5.Top = 0.4007562!
        Me.Label5.Width = 0.591!
        '
        'Label7
        '
        Me.Label7.Height = 0.152!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.972!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.Label7.Text = "Telefone:"
        Me.Label7.Top = 0.529!
        Me.Label7.Width = 0.6013932!
        '
        'Label8
        '
        Me.Label8.Height = 0.152!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.972!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.Label8.Text = "Celular...:"
        Me.Label8.Top = 0.371!
        Me.Label8.Width = 0.6079988!
        '
        'Label9
        '
        Me.Label9.Height = 0.152!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 3.397!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.Label9.Text = "Bairro.:"
        Me.Label9.Top = 0.401!
        Me.Label9.Width = 0.4660001!
        '
        'txtNome1
        '
        Me.txtNome1.DataField = "=Nome + "" - "" + Codigo"
        Me.txtNome1.Height = 0.152!
        Me.txtNome1.Left = 0.738!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.2284105!
        Me.txtNome1.Width = 3.846!
        '
        'txtEndereço1
        '
        Me.txtEndereço1.CanGrow = False
        Me.txtEndereço1.DataField = "=Endereço + "" Nº "" +  Nro"
        Me.txtEndereço1.Height = 0.152!
        Me.txtEndereço1.Left = 0.738!
        Me.txtEndereço1.Name = "txtEndereço1"
        Me.txtEndereço1.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.txtEndereço1.Text = "txtEndereço1"
        Me.txtEndereço1.Top = 0.4006542!
        Me.txtEndereço1.Width = 2.627!
        '
        'txtCidade1
        '
        Me.txtCidade1.DataField = "=Cidade +""/""+Estado"
        Me.txtCidade1.Height = 0.152!
        Me.txtCidade1.Left = 0.7378191!
        Me.txtCidade1.Name = "txtCidade1"
        Me.txtCidade1.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.txtCidade1.Text = "txtCidade1"
        Me.txtCidade1.Top = 0.562!
        Me.txtCidade1.Width = 1.780181!
        '
        'txtTelefone1
        '
        Me.txtTelefone1.DataField = "Telefone"
        Me.txtTelefone1.Height = 0.1420001!
        Me.txtTelefone1.Left = 6.58!
        Me.txtTelefone1.Name = "txtTelefone1"
        Me.txtTelefone1.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0"
        Me.txtTelefone1.Text = "txtTelefone1"
        Me.txtTelefone1.Top = 0.529!
        Me.txtTelefone1.Width = 1.132!
        '
        'txtCelular1
        '
        Me.txtCelular1.DataField = "Celular"
        Me.txtCelular1.Height = 0.152!
        Me.txtCelular1.Left = 6.58!
        Me.txtCelular1.Name = "txtCelular1"
        Me.txtCelular1.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0"
        Me.txtCelular1.Text = "txtCelular1"
        Me.txtCelular1.Top = 0.371!
        Me.txtCelular1.Width = 1.13189!
        '
        'txtBairro1
        '
        Me.txtBairro1.DataField = "Bairro"
        Me.txtBairro1.Height = 0.152!
        Me.txtBairro1.Left = 3.888!
        Me.txtBairro1.Name = "txtBairro1"
        Me.txtBairro1.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.txtBairro1.Text = "txtBairro1"
        Me.txtBairro1.Top = 0.401!
        Me.txtBairro1.Width = 1.997!
        '
        'txtInativo1
        '
        Me.txtInativo1.DataField = "Inativo"
        Me.txtInativo1.Height = 0.1793458!
        Me.txtInativo1.Left = 4.514!
        Me.txtInativo1.Name = "txtInativo1"
        Me.txtInativo1.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.txtInativo1.Text = "txtInativo1"
        Me.txtInativo1.Top = 0.401!
        Me.txtInativo1.Visible = False
        Me.txtInativo1.Width = 0.4689999!
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 1.862645E-9!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.913!
        Me.Line4.Width = 7.775591!
        Me.Line4.X1 = 1.862645E-9!
        Me.Line4.X2 = 7.775591!
        Me.Line4.Y1 = 0.913!
        Me.Line4.Y2 = 0.913!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.7410001!
        Me.Line3.Width = 7.775589!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.775589!
        Me.Line3.Y1 = 0.7410001!
        Me.Line3.Y2 = 0.7410001!
        '
        'Label11
        '
        Me.Label11.Height = 0.1515899!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.04934267!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label11.Text = "Codigo"
        Me.Label11.Top = 0.7617952!
        Me.Label11.Width = 0.6151575!
        '
        'Label12
        '
        Me.Label12.Height = 0.1515899!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.6645001!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label12.Text = "Descrição do Produto"
        Me.Label12.Top = 0.7617952!
        Me.Label12.Width = 3.912666!
        '
        'Label13
        '
        Me.Label13.Height = 0.1515899!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 4.698087!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Label13.Text = "Un.M"
        Me.Label13.Top = 0.756!
        Me.Label13.Width = 0.6340001!
        '
        'Label14
        '
        Me.Label14.Height = 0.1515899!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 5.414087!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label14.Text = "Qtd"
        Me.Label14.Top = 0.7617952!
        Me.Label14.Width = 0.6397123!
        '
        'Label15
        '
        Me.Label15.Height = 0.1515899!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 6.103823!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label15.Text = "Vlr. Unit."
        Me.Label15.Top = 0.7617952!
        Me.Label15.Width = 0.6799369!
        '
        'Label16
        '
        Me.Label16.Height = 0.1515899!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 6.053279!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label16.Text = "Vlr. Desc."
        Me.Label16.Top = 0.7617952!
        Me.Label16.Visible = False
        Me.Label16.Width = 0.7627952!
        '
        'Label17
        '
        Me.Label17.Height = 0.1515899!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 6.865287!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label17.Text = "Total"
        Me.Label17.Top = 0.7617952!
        Me.Label17.Width = 0.8858271!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line2, Me.Label6, Me.Label4, Me.Label5, Me.Label7, Me.Label8, Me.Label9, Me.txtNome1, Me.txtEndereço1, Me.txtCidade1, Me.txtTelefone1, Me.txtCelular1, Me.txtBairro1, Me.txtInativo1, Me.Line3, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Line4, Me.txtPedidoTipo1, Me.Label24, Me.txtDescrição2, Me.Label18, Me.txtDescricaoTipoPgto2, Me.Label19, Me.txtCpfCgc1, Me.Label10, Me.Label25, Me.TextBox7})
        Me.GroupHeader2.Height = 0.9375899!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'txtPedidoTipo1
        '
        Me.txtPedidoTipo1.DataField = "PedidoTipo"
        Me.txtPedidoTipo1.Height = 0.17!
        Me.txtPedidoTipo1.Left = 3.577!
        Me.txtPedidoTipo1.Name = "txtPedidoTipo1"
        Me.txtPedidoTipo1.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtPedidoTipo1.Text = "txtPedidoTipo1"
        Me.txtPedidoTipo1.Top = 0.022!
        Me.txtPedidoTipo1.Width = 1.479228!
        '
        'Label24
        '
        Me.Label24.Height = 0.17!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 2.945228!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label24.Text = "Tipo...:"
        Me.Label24.Top = 0.02199994!
        Me.Label24.Width = 0.6030319!
        '
        'txtCpfCgc1
        '
        Me.txtCpfCgc1.CanGrow = False
        Me.txtCpfCgc1.DataField = "CpfCgc"
        Me.txtCpfCgc1.Height = 0.1497559!
        Me.txtCpfCgc1.Left = 6.571!
        Me.txtCpfCgc1.Name = "txtCpfCgc1"
        Me.txtCpfCgc1.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0"
        Me.txtCpfCgc1.Text = "txtCpfCgc1"
        Me.txtCpfCgc1.Top = 0.222!
        Me.txtCpfCgc1.Width = 1.141!
        '
        'Label10
        '
        Me.Label10.Height = 0.152!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 5.972!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 8.25pt; ddo-char-set: 0"
        Me.Label10.Text = "Cnpj/Cpf:"
        Me.Label10.Top = 0.205!
        Me.Label10.Width = 0.5905511!
        '
        'Label25
        '
        Me.Label25.Height = 0.17!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 4.644!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-size: 8pt; font-weight: normal; ddo-char-set: 1"
        Me.Label25.Text = "Contrato:"
        Me.Label25.Top = 0.231!
        Me.Label25.Width = 0.6029997!
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = False
        Me.TextBox7.DataField = "Contrato"
        Me.TextBox7.Height = 0.1497559!
        Me.TextBox7.Left = 5.247!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0"
        Me.TextBox7.Text = "txtContrato"
        Me.TextBox7.Top = 0.222!
        Me.TextBox7.Width = 0.6580005!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Height = 0.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'RelPedidoSellShoes
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Projetos dblsistemas\Prj Up\Dados" & _
            "\CD\upDados.mdb;Persist Security Info=False;Jet OLEDB:Database Password=abc"
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
        Me.PrintWidth = 7.839314!
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
        CType(Me.txtValorUnitario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDesconto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnderecoEmpresa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCidadeEmpresa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeFuncionario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedSequencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataPed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReimpresso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedValorProdutos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedVlrDescProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblmsgCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrição2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescricaoTipoPgto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndereço1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCidade1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelular1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBairro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInativo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedidoTipo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCpfCgc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCodigoProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtProdutoDescricao1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUnidadeMedida1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQtd1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorUnitario1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorDesconto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalProduto1 As DataDynamics.ActiveReports.TextBox
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
    Friend WithEvents txtPedValorProdutos1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPedVlrDescProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalPed1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label21 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label22 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Parcelas As DataDynamics.ActiveReports.SubReport
    Friend WithEvents lblmsgCancelado As DataDynamics.ActiveReports.Label
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
    Private WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtEndereço1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtCidade1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtTelefone1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtCelular1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtBairro1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtInativo1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtPedidoTipo1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCpfCgc1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Public WithEvents lblReimpresso As DataDynamics.ActiveReports.Label
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
End Class
