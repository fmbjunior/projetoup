<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelAnaliseSaida 
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
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelAnaliseSaida))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtRazãoSocial1 = New DataDynamics.ActiveReports.TextBox
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.periodo = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtPedidoSequencia1 = New DataDynamics.ActiveReports.TextBox
        Me.txtQtd1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorUnitario1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDesconto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorDesconto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalProduto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDataUltimaCompra1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorCompra1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorLiquido1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.txtCodigoProduto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescrição1 = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedidoSequencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUnitario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDesconto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataUltimaCompra1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorCompra1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorLiquido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtRazãoSocial1, Me.Label10, Me.periodo})
        Me.PageHeader1.Height = 0.71875!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtRazãoSocial1
        '
        Me.txtRazãoSocial1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRazãoSocial1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRazãoSocial1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRazãoSocial1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRazãoSocial1.Border.RightColor = System.Drawing.Color.Black
        Me.txtRazãoSocial1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRazãoSocial1.Border.TopColor = System.Drawing.Color.Black
        Me.txtRazãoSocial1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRazãoSocial1.DataField = "RazãoSocial"
        Me.txtRazãoSocial1.Height = 0.2833333!
        Me.txtRazãoSocial1.Left = 0.05208333!
        Me.txtRazãoSocial1.Name = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 14pt; font-family: Segoe UI; "
        Me.txtRazãoSocial1.Text = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Top = 0.0!
        Me.txtRazãoSocial1.Width = 7.229167!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.21875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0625!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; font-family: Tahoma; "
        Me.Label10.Text = "Relatório:  Análise de Saída"
        Me.Label10.Top = 0.4479167!
        Me.Label10.Width = 2.208333!
        '
        'periodo
        '
        Me.periodo.Border.BottomColor = System.Drawing.Color.Black
        Me.periodo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.periodo.Border.LeftColor = System.Drawing.Color.Black
        Me.periodo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.periodo.Border.RightColor = System.Drawing.Color.Black
        Me.periodo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.periodo.Border.TopColor = System.Drawing.Color.Black
        Me.periodo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.periodo.Height = 0.1979167!
        Me.periodo.HyperLink = Nothing
        Me.periodo.Left = 4.447917!
        Me.periodo.Name = "periodo"
        Me.periodo.Style = ""
        Me.periodo.Text = "perído de 01/04/2010  e 30/05/2010"
        Me.periodo.Top = 0.46875!
        Me.periodo.Width = 2.895833!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPedidoSequencia1, Me.txtQtd1, Me.txtValorUnitario1, Me.txtDesconto1, Me.txtValorDesconto1, Me.txtTotalProduto1, Me.txtDataUltimaCompra1, Me.txtValorCompra1, Me.txtValorLiquido1})
        Me.Detail1.Height = 0.2!
        Me.Detail1.Name = "Detail1"
        '
        'txtPedidoSequencia1
        '
        Me.txtPedidoSequencia1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPedidoSequencia1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPedidoSequencia1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPedidoSequencia1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPedidoSequencia1.Border.RightColor = System.Drawing.Color.Black
        Me.txtPedidoSequencia1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPedidoSequencia1.Border.TopColor = System.Drawing.Color.Black
        Me.txtPedidoSequencia1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPedidoSequencia1.DataField = "PedidoSequencia"
        Me.txtPedidoSequencia1.Height = 0.1791667!
        Me.txtPedidoSequencia1.Left = 0.01041667!
        Me.txtPedidoSequencia1.Name = "txtPedidoSequencia1"
        Me.txtPedidoSequencia1.OutputFormat = resources.GetString("txtPedidoSequencia1.OutputFormat")
        Me.txtPedidoSequencia1.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
        Me.txtPedidoSequencia1.Text = "txtPedidoSequencia1"
        Me.txtPedidoSequencia1.Top = 0.0!
        Me.txtPedidoSequencia1.Width = 0.5208333!
        '
        'txtQtd1
        '
        Me.txtQtd1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQtd1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtd1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQtd1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtd1.Border.RightColor = System.Drawing.Color.Black
        Me.txtQtd1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtd1.Border.TopColor = System.Drawing.Color.Black
        Me.txtQtd1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtd1.DataField = "Qtd"
        Me.txtQtd1.Height = 0.1791667!
        Me.txtQtd1.Left = 2.239583!
        Me.txtQtd1.Name = "txtQtd1"
        Me.txtQtd1.OutputFormat = resources.GetString("txtQtd1.OutputFormat")
        Me.txtQtd1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtQtd1.Text = "txtQtd1"
        Me.txtQtd1.Top = 0.0!
        Me.txtQtd1.Width = 0.8020833!
        '
        'txtValorUnitario1
        '
        Me.txtValorUnitario1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtValorUnitario1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorUnitario1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtValorUnitario1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorUnitario1.Border.RightColor = System.Drawing.Color.Black
        Me.txtValorUnitario1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorUnitario1.Border.TopColor = System.Drawing.Color.Black
        Me.txtValorUnitario1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorUnitario1.DataField = "ValorUnitario"
        Me.txtValorUnitario1.Height = 0.1791667!
        Me.txtValorUnitario1.Left = 3.104167!
        Me.txtValorUnitario1.Name = "txtValorUnitario1"
        Me.txtValorUnitario1.OutputFormat = resources.GetString("txtValorUnitario1.OutputFormat")
        Me.txtValorUnitario1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtValorUnitario1.Text = "txtValorUnitario1"
        Me.txtValorUnitario1.Top = 0.0!
        Me.txtValorUnitario1.Width = 0.8541667!
        '
        'txtDesconto1
        '
        Me.txtDesconto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDesconto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDesconto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDesconto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDesconto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto1.DataField = "Desconto"
        Me.txtDesconto1.Height = 0.1791667!
        Me.txtDesconto1.Left = 4.03125!
        Me.txtDesconto1.Name = "txtDesconto1"
        Me.txtDesconto1.OutputFormat = resources.GetString("txtDesconto1.OutputFormat")
        Me.txtDesconto1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtDesconto1.Text = "txtDesconto1"
        Me.txtDesconto1.Top = 0.0!
        Me.txtDesconto1.Width = 0.5520833!
        '
        'txtValorDesconto1
        '
        Me.txtValorDesconto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtValorDesconto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorDesconto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtValorDesconto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorDesconto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtValorDesconto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorDesconto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtValorDesconto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorDesconto1.DataField = "ValorDesconto"
        Me.txtValorDesconto1.Height = 0.1791667!
        Me.txtValorDesconto1.Left = 4.645833!
        Me.txtValorDesconto1.Name = "txtValorDesconto1"
        Me.txtValorDesconto1.OutputFormat = resources.GetString("txtValorDesconto1.OutputFormat")
        Me.txtValorDesconto1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtValorDesconto1.Text = "txtValorDesconto1"
        Me.txtValorDesconto1.Top = 0.0!
        Me.txtValorDesconto1.Width = 0.7604167!
        '
        'txtTotalProduto1
        '
        Me.txtTotalProduto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalProduto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalProduto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalProduto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalProduto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalProduto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalProduto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalProduto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalProduto1.DataField = "TotalProduto"
        Me.txtTotalProduto1.Height = 0.1791667!
        Me.txtTotalProduto1.Left = 5.46875!
        Me.txtTotalProduto1.Name = "txtTotalProduto1"
        Me.txtTotalProduto1.OutputFormat = resources.GetString("txtTotalProduto1.OutputFormat")
        Me.txtTotalProduto1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtTotalProduto1.Text = "txtTotalProduto1"
        Me.txtTotalProduto1.Top = 0.0!
        Me.txtTotalProduto1.Width = 0.8645833!
        '
        'txtDataUltimaCompra1
        '
        Me.txtDataUltimaCompra1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDataUltimaCompra1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataUltimaCompra1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDataUltimaCompra1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataUltimaCompra1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDataUltimaCompra1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataUltimaCompra1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDataUltimaCompra1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataUltimaCompra1.DataField = "DataUltimaCompra"
        Me.txtDataUltimaCompra1.Height = 0.1791667!
        Me.txtDataUltimaCompra1.Left = 0.59375!
        Me.txtDataUltimaCompra1.Name = "txtDataUltimaCompra1"
        Me.txtDataUltimaCompra1.OutputFormat = resources.GetString("txtDataUltimaCompra1.OutputFormat")
        Me.txtDataUltimaCompra1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtDataUltimaCompra1.Text = "txtDataUltimaCompra1"
        Me.txtDataUltimaCompra1.Top = 0.0!
        Me.txtDataUltimaCompra1.Width = 0.78125!
        '
        'txtValorCompra1
        '
        Me.txtValorCompra1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtValorCompra1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorCompra1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtValorCompra1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorCompra1.Border.RightColor = System.Drawing.Color.Black
        Me.txtValorCompra1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorCompra1.Border.TopColor = System.Drawing.Color.Black
        Me.txtValorCompra1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorCompra1.DataField = "ValorCompra"
        Me.txtValorCompra1.Height = 0.1791667!
        Me.txtValorCompra1.Left = 1.447917!
        Me.txtValorCompra1.Name = "txtValorCompra1"
        Me.txtValorCompra1.OutputFormat = resources.GetString("txtValorCompra1.OutputFormat")
        Me.txtValorCompra1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtValorCompra1.Text = "txtValorCompra1"
        Me.txtValorCompra1.Top = 0.0!
        Me.txtValorCompra1.Width = 0.71875!
        '
        'txtValorLiquido1
        '
        Me.txtValorLiquido1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtValorLiquido1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorLiquido1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtValorLiquido1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorLiquido1.Border.RightColor = System.Drawing.Color.Black
        Me.txtValorLiquido1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorLiquido1.Border.TopColor = System.Drawing.Color.Black
        Me.txtValorLiquido1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorLiquido1.DataField = "ValorLiquido"
        Me.txtValorLiquido1.Height = 0.16875!
        Me.txtValorLiquido1.Left = 6.385417!
        Me.txtValorLiquido1.Name = "txtValorLiquido1"
        Me.txtValorLiquido1.OutputFormat = resources.GetString("txtValorLiquido1.OutputFormat")
        Me.txtValorLiquido1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtValorLiquido1.Text = "txtValorLiquido1"
        Me.txtValorLiquido1.Top = 0.0!
        Me.txtValorLiquido1.Width = 0.9166667!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label12, Me.ReportInfo1})
        Me.PageFooter1.Height = 0.15625!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Height = 0.1230315!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-size: 6pt; "
        Me.Label12.Text = "Sistemas Up"
        Me.Label12.Top = 0.0!
        Me.Label12.Width = 1.008858!
        '
        'ReportInfo1
        '
        Me.ReportInfo1.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.FormatString = "Pag.: {PageNumber} de {PageCount} : {RunDateTime}"
        Me.ReportInfo1.Height = 0.1902067!
        Me.ReportInfo1.Left = 3.386566!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: Black; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8" & _
            "pt; font-family: Tahoma; "
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 3.749262!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodigoProduto1, Me.txtDescrição1, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Line1, Me.Line2, Me.Label9})
        Me.GroupHeader1.Height = 0.75!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'txtCodigoProduto1
        '
        Me.txtCodigoProduto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoProduto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoProduto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoProduto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoProduto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoProduto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoProduto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoProduto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoProduto1.DataField = "CodigoProduto"
        Me.txtCodigoProduto1.Height = 0.2!
        Me.txtCodigoProduto1.Left = 0.04166667!
        Me.txtCodigoProduto1.Name = "txtCodigoProduto1"
        Me.txtCodigoProduto1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.txtCodigoProduto1.Text = "txtCodigoProduto1"
        Me.txtCodigoProduto1.Top = 0.1666667!
        Me.txtCodigoProduto1.Width = 1.0!
        '
        'txtDescrição1
        '
        Me.txtDescrição1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescrição1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescrição1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescrição1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescrição1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescrição1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescrição1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescrição1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescrição1.DataField = "Descrição"
        Me.txtDescrição1.Height = 0.2!
        Me.txtDescrição1.Left = 1.09375!
        Me.txtDescrição1.Name = "txtDescrição1"
        Me.txtDescrição1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.txtDescrição1.Text = "txtDescrição1"
        Me.txtDescrição1.Top = 0.1666667!
        Me.txtDescrição1.Width = 5.15625!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.15625!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.02083333!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 7pt; font-family: Tahoma; "
        Me.Label1.Text = "Pedido"
        Me.Label1.Top = 0.5!
        Me.Label1.Width = 0.5104167!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.15625!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.5625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; font-famil" & _
            "y: Tahoma; "
        Me.Label2.Text = "Dt. Ult. Compra"
        Me.Label2.Top = 0.5!
        Me.Label2.Width = 0.8333333!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.15625!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.25!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; font-famil" & _
            "y: Tahoma; "
        Me.Label3.Text = "Qtde Vendida"
        Me.Label3.Top = 0.5104167!
        Me.Label3.Width = 0.78125!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.15625!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; font-famil" & _
            "y: Tahoma; "
        Me.Label4.Text = "Vlr. Venda"
        Me.Label4.Top = 0.5!
        Me.Label4.Width = 0.8020833!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.15625!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 1.4375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; font-famil" & _
            "y: Tahoma; "
        Me.Label5.Text = "Vlr Compra"
        Me.Label5.Top = 0.5!
        Me.Label5.Width = 0.6979167!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.15625!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.03125!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; font-famil" & _
            "y: Tahoma; "
        Me.Label6.Text = "Desc %"
        Me.Label6.Top = 0.5104167!
        Me.Label6.Width = 0.5208333!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.15625!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.614583!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; font-famil" & _
            "y: Tahoma; "
        Me.Label7.Text = "Vlr. Desc R$"
        Me.Label7.Top = 0.5104167!
        Me.Label7.Width = 0.7604167!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.15625!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.489583!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; font-famil" & _
            "y: Tahoma; "
        Me.Label8.Text = "Total R$"
        Me.Label8.Top = 0.5104167!
        Me.Label8.Width = 0.8333333!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.03125!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.7083333!
        Me.Line1.Width = 7.34375!
        Me.Line1.X1 = 0.03125!
        Me.Line1.X2 = 7.375!
        Me.Line1.Y1 = 0.7083333!
        Me.Line1.Y2 = 0.7083333!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.04166667!
        Me.Line2.LineWeight = 3.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.05208333!
        Me.Line2.Width = 7.354167!
        Me.Line2.X1 = 0.04166667!
        Me.Line2.X2 = 7.395833!
        Me.Line2.Y1 = 0.05208333!
        Me.Line2.Y2 = 0.05208333!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.15625!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 6.40625!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; font-famil" & _
            "y: Tahoma; "
        Me.Label9.Text = "Total Liquido"
        Me.Label9.Top = 0.5104167!
        Me.Label9.Width = 0.90625!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox9, Me.Label13, Me.Label14, Me.TextBox1, Me.Label15, Me.TextBox2, Me.Label16, Me.TextBox3, Me.Label17, Me.TextBox4, Me.Label18, Me.TextBox5, Me.Label19, Me.TextBox6, Me.Line3})
        Me.GroupFooter1.Height = 1.09375!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.DataField = "Qtd"
        Me.TextBox9.Height = 0.1968504!
        Me.TextBox9.Left = 1.342028!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox9.SummaryGroup = "GroupHeader1"
        Me.TextBox9.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox9.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.05208333!
        Me.TextBox9.Width = 1.033465!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.1968504!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.0625!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "text-align: left; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label13.Text = "Total Itens"
        Me.Label13.Top = 0.05208333!
        Me.Label13.Width = 1.254921!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.1968504!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.07291666!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "text-align: left; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label14.Text = "Total Desconto"
        Me.Label14.Top = 0.2708333!
        Me.Label14.Width = 1.254921!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "ValorDesconto"
        Me.TextBox1.Height = 0.1968504!
        Me.TextBox1.Left = 1.352445!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox1.SummaryGroup = "GroupHeader1"
        Me.TextBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.2708333!
        Me.TextBox1.Width = 1.033465!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Height = 0.1968504!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.07291666!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "text-align: left; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label15.Text = "Total Bruto"
        Me.Label15.Top = 0.5!
        Me.Label15.Width = 1.254921!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "TotalProduto"
        Me.TextBox2.Height = 0.1968504!
        Me.TextBox2.Left = 1.352445!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox2.SummaryGroup = "GroupHeader1"
        Me.TextBox2.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.5!
        Me.TextBox2.Width = 1.033465!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Height = 0.1968504!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.07291666!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "text-align: left; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label16.Text = "Total Liquido"
        Me.Label16.Top = 0.7395833!
        Me.Label16.Width = 1.254921!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "ValorLiquido"
        Me.TextBox3.Height = 0.1968504!
        Me.TextBox3.Left = 1.352445!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox3.SummaryGroup = "GroupHeader1"
        Me.TextBox3.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox3.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.7395833!
        Me.TextBox3.Width = 1.033465!
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.Black
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.LeftColor = System.Drawing.Color.Black
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.RightColor = System.Drawing.Color.Black
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.TopColor = System.Drawing.Color.Black
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Height = 0.1968504!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 4.895833!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "text-align: left; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label17.Text = "Média desconto em %"
        Me.Label17.Top = 0.09375!
        Me.Label17.Width = 1.473671!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Height = 0.1968504!
        Me.TextBox4.Left = 6.414945!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox4.SummaryFunc = DataDynamics.ActiveReports.SummaryFunc.Avg
        Me.TextBox4.SummaryGroup = "GroupHeader1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.09375!
        Me.TextBox4.Width = 0.8459654!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Height = 0.1968504!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 4.875!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "text-align: left; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label18.Text = "Média de preço de venda"
        Me.Label18.Top = 0.3854167!
        Me.Label18.Width = 1.504921!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Height = 0.1968504!
        Me.TextBox5.Left = 6.414945!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox5.SummaryFunc = DataDynamics.ActiveReports.SummaryFunc.Avg
        Me.TextBox5.SummaryGroup = "GroupHeader1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.3958333!
        Me.TextBox5.Width = 0.8563821!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Height = 0.1968504!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 4.875!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "text-align: left; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label19.Text = "Lucro presumível"
        Me.Label19.Top = 0.6770833!
        Me.Label19.Width = 1.504921!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Height = 0.1968504!
        Me.TextBox6.Left = 6.414945!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox6.SummaryFunc = DataDynamics.ActiveReports.SummaryFunc.Avg
        Me.TextBox6.SummaryGroup = "GroupHeader1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.6875!
        Me.TextBox6.Width = 0.8563821!
        '
        'Line3
        '
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0625!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 1.041667!
        Me.Line3.Width = 7.34375!
        Me.Line3.X1 = 0.0625!
        Me.Line3.X2 = 7.40625!
        Me.Line3.Y1 = 1.041667!
        Me.Line3.Y2 = 1.041667!
        '
        'RelAnaliseSaida
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=I:\Projetos dblsistemas\Dados\max\up" & _
            "Dados.mdb;Jet oledb:database password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.385417!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedidoSequencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUnitario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDesconto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataUltimaCompra1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorCompra1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorLiquido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtPedidoSequencia1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQtd1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorUnitario1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDesconto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorDesconto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDataUltimaCompra1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents txtCodigoProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescrição1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtValorCompra1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtRazãoSocial1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents periodo As DataDynamics.ActiveReports.Label
    Friend WithEvents txtValorLiquido1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label15 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label16 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label17 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label18 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label19 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
End Class 
