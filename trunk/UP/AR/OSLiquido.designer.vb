<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OSLiquido
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OSLiquido))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource()
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.Shape1 = New DataDynamics.ActiveReports.Shape()
        Me.txtPedido_PedidoSequencia1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRazãoSocial1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEmpresa_Endereço1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEmpresa_Telefone1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.txtRequisicao1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtDataPedido1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.txtPedidoTipo1 = New DataDynamics.ActiveReports.TextBox()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.SubProduto = New DataDynamics.ActiveReports.SubReport()
        Me.SubServico = New DataDynamics.ActiveReports.SubReport()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.Label33 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.txtClientes_Endereço1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCidade1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCep1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.txtNro1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.txtCpfCgc1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtInsc1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtClientes_Telefone1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCodigoPropriedade = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label26 = New DataDynamics.ActiveReports.Label()
        Me.TLiquido = New DataDynamics.ActiveReports.TextBox()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.Label21 = New DataDynamics.ActiveReports.Label()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.ValorIssqn = New DataDynamics.ActiveReports.TextBox()
        Me.Label32 = New DataDynamics.ActiveReports.Label()
        Me.Tped = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        Me.GroupHeader3 = New DataDynamics.ActiveReports.GroupHeader()
        Me.Shape2 = New DataDynamics.ActiveReports.Shape()
        Me.Label27 = New DataDynamics.ActiveReports.Label()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.txtVeiculo = New DataDynamics.ActiveReports.TextBox()
        Me.txtkm = New DataDynamics.ActiveReports.TextBox()
        Me.txtplaca = New DataDynamics.ActiveReports.TextBox()
        Me.Label28 = New DataDynamics.ActiveReports.Label()
        Me.Label29 = New DataDynamics.ActiveReports.Label()
        Me.Label30 = New DataDynamics.ActiveReports.Label()
        Me.Label31 = New DataDynamics.ActiveReports.Label()
        Me.GroupFooter3 = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txtPedido_PedidoSequencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa_Endereço1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa_Telefone1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequisicao1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataPedido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedidoTipo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientes_Endereço1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCidade1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCep1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCpfCgc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInsc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientes_Telefone1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPropriedade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLiquido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValorIssqn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tped, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtplaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.txtPedido_PedidoSequencia1, Me.txtRazãoSocial1, Me.txtEmpresa_Endereço1, Me.txtEmpresa_Telefone1, Me.Label2, Me.Label3, Me.txtRequisicao1, Me.txtDataPedido1, Me.Label4, Me.txtPedidoTipo1, Me.Line1})
        Me.PageHeader1.Height = 0.8437504!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Shape1
        '
        Me.Shape1.Height = 0.8354331!
        Me.Shape1.Left = 5.265749!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 20.0!
        Me.Shape1.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
        Me.Shape1.Top = 0.01456693!
        Me.Shape1.Width = 2.260417!
        '
        'txtPedido_PedidoSequencia1
        '
        Me.txtPedido_PedidoSequencia1.DataField = "Pedido.PedidoSequencia"
        Me.txtPedido_PedidoSequencia1.Height = 0.1722441!
        Me.txtPedido_PedidoSequencia1.Left = 6.446652!
        Me.txtPedido_PedidoSequencia1.Name = "txtPedido_PedidoSequencia1"
        Me.txtPedido_PedidoSequencia1.OutputFormat = resources.GetString("txtPedido_PedidoSequencia1.OutputFormat")
        Me.txtPedido_PedidoSequencia1.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtPedido_PedidoSequencia1.Text = "txtPedido_PedidoSequencia1"
        Me.txtPedido_PedidoSequencia1.Top = 0.05157482!
        Me.txtPedido_PedidoSequencia1.Width = 1.008858!
        '
        'txtRazãoSocial1
        '
        Me.txtRazãoSocial1.DataField = "RazãoSocial"
        Me.txtRazãoSocial1.Height = 0.1744095!
        Me.txtRazãoSocial1.Left = 0.0492126!
        Me.txtRazãoSocial1.Name = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.txtRazãoSocial1.Text = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Top = 0.02874016!
        Me.txtRazãoSocial1.Width = 4.92126!
        '
        'txtEmpresa_Endereço1
        '
        Me.txtEmpresa_Endereço1.DataField = "Empresa.Endereço"
        Me.txtEmpresa_Endereço1.Height = 0.1968504!
        Me.txtEmpresa_Endereço1.Left = 0.07362206!
        Me.txtEmpresa_Endereço1.Name = "txtEmpresa_Endereço1"
        Me.txtEmpresa_Endereço1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtEmpresa_Endereço1.Text = "txtEmpresa_Endereço1"
        Me.txtEmpresa_Endereço1.Top = 0.2338583!
        Me.txtEmpresa_Endereço1.Width = 2.731299!
        '
        'txtEmpresa_Telefone1
        '
        Me.txtEmpresa_Telefone1.DataField = "Empresa.Telefone"
        Me.txtEmpresa_Telefone1.Height = 0.1968504!
        Me.txtEmpresa_Telefone1.Left = 0.07362205!
        Me.txtEmpresa_Telefone1.Name = "txtEmpresa_Telefone1"
        Me.txtEmpresa_Telefone1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtEmpresa_Telefone1.Text = "txtEmpresa_Telefone1"
        Me.txtEmpresa_Telefone1.Top = 0.4492126!
        Me.txtEmpresa_Telefone1.Width = 2.731103!
        '
        'Label2
        '
        Me.Label2.Height = 0.1722441!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.33937!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label2.Text = "Pedido OS N.:"
        Me.Label2.Top = 0.05157482!
        Me.Label2.Width = 1.058071!
        '
        'Label3
        '
        Me.Label3.Height = 0.1413386!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.33937!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label3.Text = "Controle N.:"
        Me.Label3.Top = 0.2484252!
        Me.Label3.Width = 1.058071!
        '
        'txtRequisicao1
        '
        Me.txtRequisicao1.DataField = "Requisicao"
        Me.txtRequisicao1.Height = 0.1476378!
        Me.txtRequisicao1.Left = 6.446652!
        Me.txtRequisicao1.Name = "txtRequisicao1"
        Me.txtRequisicao1.OutputFormat = resources.GetString("txtRequisicao1.OutputFormat")
        Me.txtRequisicao1.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtRequisicao1.Text = "txtRequisicao1"
        Me.txtRequisicao1.Top = 0.2484252!
        Me.txtRequisicao1.Width = 1.008858!
        '
        'txtDataPedido1
        '
        Me.txtDataPedido1.DataField = "DataPedido"
        Me.txtDataPedido1.Height = 0.1515748!
        Me.txtDataPedido1.Left = 6.446456!
        Me.txtDataPedido1.Name = "txtDataPedido1"
        Me.txtDataPedido1.OutputFormat = resources.GetString("txtDataPedido1.OutputFormat")
        Me.txtDataPedido1.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtDataPedido1.Text = "txtDataPedido1"
        Me.txtDataPedido1.Top = 0.4208661!
        Me.txtDataPedido1.Width = 1.008858!
        '
        'Label4
        '
        Me.Label4.Height = 0.1515748!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 5.33937!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label4.Text = "Data Pedido.:"
        Me.Label4.Top = 0.4145669!
        Me.Label4.Width = 1.058071!
        '
        'txtPedidoTipo1
        '
        Me.txtPedidoTipo1.DataField = "PedidoTipo"
        Me.txtPedidoTipo1.Height = 0.1968504!
        Me.txtPedidoTipo1.Left = 5.364173!
        Me.txtPedidoTipo1.Name = "txtPedidoTipo1"
        Me.txtPedidoTipo1.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.txtPedidoTipo1.Text = "txtPedidoTipo1"
        Me.txtPedidoTipo1.Top = 0.6011813!
        Me.txtPedidoTipo1.Width = 2.091536!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0492126!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.181102!
        Me.Line1.Width = 7.529529!
        Me.Line1.X1 = 0.0492126!
        Me.Line1.X2 = 7.578741!
        Me.Line1.Y1 = 1.181102!
        Me.Line1.Y2 = 1.181102!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.SubProduto, Me.SubServico})
        Me.Detail1.Height = 0.6041667!
        Me.Detail1.Name = "Detail1"
        '
        'SubProduto
        '
        Me.SubProduto.CloseBorder = False
        Me.SubProduto.Height = 0.2214567!
        Me.SubProduto.Left = 0.0!
        Me.SubProduto.Name = "SubProduto"
        Me.SubProduto.Report = Nothing
        Me.SubProduto.ReportName = "SubReport1"
        Me.SubProduto.Tag = ""
        Me.SubProduto.Top = 0.0!
        Me.SubProduto.Width = 7.504921!
        '
        'SubServico
        '
        Me.SubServico.CloseBorder = False
        Me.SubServico.Height = 0.246063!
        Me.SubServico.Left = 0.0!
        Me.SubServico.Name = "SubServico"
        Me.SubServico.Report = Nothing
        Me.SubServico.ReportName = "SubReport1"
        Me.SubServico.Top = 0.2706693!
        Me.SubServico.Width = 7.504921!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line4, Me.TextBox17, Me.Label33})
        Me.PageFooter1.Height = 0.5833333!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0984252!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.2952756!
        Me.Line4.Width = 3.715552!
        Me.Line4.X1 = 3.813977!
        Me.Line4.X2 = 0.0984252!
        Me.Line4.Y1 = 0.2952756!
        Me.Line4.Y2 = 0.2952756!
        '
        'TextBox17
        '
        Me.TextBox17.ClassName = "Style2"
        Me.TextBox17.DataField = "nome"
        Me.TextBox17.Height = 0.1722441!
        Me.TextBox17.Left = 0.0984252!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "text-align: center"
        Me.TextBox17.Text = "TextBox17"
        Me.TextBox17.Top = 0.3198819!
        Me.TextBox17.Width = 3.740157!
        '
        'Label33
        '
        Me.Label33.Height = 0.1458333!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 6.916667!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-size: 6pt; ddo-char-set: 1"
        Me.Label33.Text = "Rpt.OSliquido"
        Me.Label33.Top = 0.3854167!
        Me.Label33.Width = 0.625!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNome1, Me.Label1, Me.Label5, Me.Label6, Me.Label7, Me.txtClientes_Endereço1, Me.txtCidade1, Me.txtCep1, Me.Label8, Me.Label9, Me.Label10, Me.txtNro1, Me.Label11, Me.txtCpfCgc1, Me.txtInsc1, Me.txtClientes_Telefone1, Me.txtCodigoPropriedade})
        Me.GroupHeader1.DataField = "PedidoInterno"
        Me.GroupHeader1.Height = 0.6354167!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'txtNome1
        '
        Me.txtNome1.DataField = "Nome"
        Me.txtNome1.Height = 0.1574803!
        Me.txtNome1.Left = 0.9055119!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.008661415!
        Me.txtNome1.Width = 4.212598!
        '
        'Label1
        '
        Me.Label1.Height = 0.1722441!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label1.Text = "Cliente.........:"
        Me.Label1.Top = 0.008267717!
        Me.Label1.Width = 0.9104331!
        '
        'Label5
        '
        Me.Label5.Height = 0.1722441!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label5.Text = "Endereço.....:"
        Me.Label5.Top = 0.1905512!
        Me.Label5.Width = 0.9104331!
        '
        'Label6
        '
        Me.Label6.Height = 0.1722441!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.0!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label6.Text = "Cidade.........:"
        Me.Label6.Top = 0.3629921!
        Me.Label6.Width = 0.9104331!
        '
        'Label7
        '
        Me.Label7.Height = 0.1722441!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.469292!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label7.Text = "Cep.:"
        Me.Label7.Top = 0.3838583!
        Me.Label7.Width = 0.3200786!
        '
        'txtClientes_Endereço1
        '
        Me.txtClientes_Endereço1.DataField = "Clientes.Endereço"
        Me.txtClientes_Endereço1.Height = 0.1722441!
        Me.txtClientes_Endereço1.Left = 0.9075623!
        Me.txtClientes_Endereço1.Name = "txtClientes_Endereço1"
        Me.txtClientes_Endereço1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtClientes_Endereço1.Text = "txtClientes_Endereço1"
        Me.txtClientes_Endereço1.Top = 0.1905512!
        Me.txtClientes_Endereço1.Width = 2.509843!
        '
        'txtCidade1
        '
        Me.txtCidade1.DataField = "Clientes.Cidade"
        Me.txtCidade1.Height = 0.1722441!
        Me.txtCidade1.Left = 0.9075623!
        Me.txtCidade1.Name = "txtCidade1"
        Me.txtCidade1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCidade1.Text = "txtCidade1"
        Me.txtCidade1.Top = 0.3629921!
        Me.txtCidade1.Width = 2.509843!
        '
        'txtCep1
        '
        Me.txtCep1.DataField = "Cep"
        Me.txtCep1.Height = 0.1515748!
        Me.txtCep1.Left = 3.814173!
        Me.txtCep1.Name = "txtCep1"
        Me.txtCep1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCep1.Text = "txtCep1"
        Me.txtCep1.Top = 0.3877953!
        Me.txtCep1.Width = 0.9346459!
        '
        'Label8
        '
        Me.Label8.Height = 0.1722441!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.265748!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label8.Text = "Cnpj/Cpf.:"
        Me.Label8.Top = 0.01850394!
        Me.Label8.Width = 0.8120081!
        '
        'Label9
        '
        Me.Label9.Height = 0.1722441!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 5.265748!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label9.Text = "Telefone.:"
        Me.Label9.Top = 0.4084317!
        Me.Label9.Width = 0.8120081!
        '
        'Label10
        '
        Me.Label10.Height = 0.1722441!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 3.469488!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label10.Text = "Nro.:"
        Me.Label10.Top = 0.1905512!
        Me.Label10.Width = 0.319882!
        '
        'txtNro1
        '
        Me.txtNro1.DataField = "Nro"
        Me.txtNro1.Height = 0.1722441!
        Me.txtNro1.Left = 3.813977!
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtNro1.Text = "txtNro1"
        Me.txtNro1.Top = 0.1905512!
        Me.txtNro1.Width = 0.7874014!
        '
        'Label11
        '
        Me.Label11.Height = 0.1722441!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 5.265748!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label11.Text = "Insc. Est.:"
        Me.Label11.Top = 0.2151575!
        Me.Label11.Width = 0.8120081!
        '
        'txtCpfCgc1
        '
        Me.txtCpfCgc1.DataField = "CpfCgc"
        Me.txtCpfCgc1.Height = 0.1574803!
        Me.txtCpfCgc1.Left = 6.141733!
        Me.txtCpfCgc1.Name = "txtCpfCgc1"
        Me.txtCpfCgc1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCpfCgc1.Text = "txtCpfCgc1"
        Me.txtCpfCgc1.Top = 0.02719817!
        Me.txtCpfCgc1.Width = 1.377953!
        '
        'txtInsc1
        '
        Me.txtInsc1.DataField = "Insc"
        Me.txtInsc1.Height = 0.1574803!
        Me.txtInsc1.Left = 6.141733!
        Me.txtInsc1.Name = "txtInsc1"
        Me.txtInsc1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtInsc1.Text = "txtInsc1"
        Me.txtInsc1.Top = 0.2446851!
        Me.txtInsc1.Width = 1.377953!
        '
        'txtClientes_Telefone1
        '
        Me.txtClientes_Telefone1.DataField = "Clientes.Telefone"
        Me.txtClientes_Telefone1.Height = 0.1574803!
        Me.txtClientes_Telefone1.Left = 6.141733!
        Me.txtClientes_Telefone1.Name = "txtClientes_Telefone1"
        Me.txtClientes_Telefone1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtClientes_Telefone1.Text = "txtClientes_Telefone1"
        Me.txtClientes_Telefone1.Top = 0.4127789!
        Me.txtClientes_Telefone1.Width = 0.9842519!
        '
        'txtCodigoPropriedade
        '
        Me.txtCodigoPropriedade.DataField = "Propriedade"
        Me.txtCodigoPropriedade.Height = 0.1722441!
        Me.txtCodigoPropriedade.Left = 4.748819!
        Me.txtCodigoPropriedade.Name = "txtCodigoPropriedade"
        Me.txtCodigoPropriedade.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCodigoPropriedade.Text = Nothing
        Me.txtCodigoPropriedade.Top = 0.01850394!
        Me.txtCodigoPropriedade.Visible = False
        Me.txtCodigoPropriedade.Width = 0.3444885!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label26, Me.TLiquido, Me.Label18, Me.TextBox5, Me.Label20, Me.TextBox9, Me.Label21, Me.TextBox10, Me.Line3, Me.Line2, Me.ValorIssqn, Me.Label32, Me.Tped})
        Me.GroupFooter1.Height = 0.9270833!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label26
        '
        Me.Label26.Height = 0.2214567!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 4.675198!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-size: 10pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Label26.Text = "Total Pedido"
        Me.Label26.Top = 0.6377953!
        Me.Label26.Width = 1.156496!
        '
        'TLiquido
        '
        Me.TLiquido.Height = 0.2214567!
        Me.TLiquido.Left = 5.905512!
        Me.TLiquido.Name = "TLiquido"
        Me.TLiquido.OutputFormat = resources.GetString("TLiquido.OutputFormat")
        Me.TLiquido.Style = "font-size: 10pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.TLiquido.Text = Nothing
        Me.TLiquido.Top = 0.6377953!
        Me.TLiquido.Width = 1.476379!
        '
        'Label18
        '
        Me.Label18.Height = 0.1722441!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 1.816273!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label18.Text = "Total IPI.:"
        Me.Label18.Top = 0.08423557!
        Me.Label18.Width = 0.8120081!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "ValorIpiPedido"
        Me.TextBox5.Height = 0.1722441!
        Me.TextBox5.Left = 2.677493!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox5.Text = "txtClientes_Telefone1"
        Me.TextBox5.Top = 0.08423557!
        Me.TextBox5.Width = 0.6397638!
        '
        'Label20
        '
        Me.Label20.Height = 0.1722441!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 3.391076!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label20.Text = "Total Produtos.:"
        Me.Label20.Top = 0.08423557!
        Me.Label20.Width = 0.984252!
        '
        'TextBox9
        '
        Me.TextBox9.DataField = "ValorProduto"
        Me.TextBox9.Height = 0.1968504!
        Me.TextBox9.Left = 4.473753!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox9.Text = "txtClientes_Telefone1"
        Me.TextBox9.Top = 0.08423557!
        Me.TextBox9.Width = 0.8612204!
        '
        'Label21
        '
        Me.Label21.Height = 0.1722441!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 5.408792!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label21.Text = "Total Serviços.:"
        Me.Label21.Top = 0.08423557!
        Me.Label21.Width = 1.008858!
        '
        'TextBox10
        '
        Me.TextBox10.DataField = "ValorServicos"
        Me.TextBox10.Height = 0.1968504!
        Me.TextBox10.Left = 6.516077!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox10.Text = "txtClientes_Telefone1"
        Me.TextBox10.Top = 0.08423557!
        Me.TextBox10.Width = 0.8612204!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0492126!
        Me.Line3.Width = 7.38189!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.38189!
        Me.Line3.Y1 = 0.0492126!
        Me.Line3.Y2 = 0.0492126!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.3198819!
        Me.Line2.Width = 7.480315!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.480315!
        Me.Line2.Y1 = 0.3198819!
        Me.Line2.Y2 = 0.3198819!
        '
        'ValorIssqn
        '
        Me.ValorIssqn.DataField = "issqn"
        Me.ValorIssqn.Height = 0.1722441!
        Me.ValorIssqn.Left = 6.516142!
        Me.ValorIssqn.Name = "ValorIssqn"
        Me.ValorIssqn.OutputFormat = resources.GetString("ValorIssqn.OutputFormat")
        Me.ValorIssqn.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.ValorIssqn.Text = Nothing
        Me.ValorIssqn.Top = 0.3690945!
        Me.ValorIssqn.Width = 0.8657479!
        '
        'Label32
        '
        Me.Label32.Height = 0.1722441!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 5.708662!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label32.Text = "ISSQN.:"
        Me.Label32.Top = 0.3690945!
        Me.Label32.Width = 0.7627954!
        '
        'Tped
        '
        Me.Tped.DataField = "totalpedido"
        Me.Tped.Height = 0.2214567!
        Me.Tped.Left = 3.297244!
        Me.Tped.Name = "Tped"
        Me.Tped.OutputFormat = resources.GetString("Tped.OutputFormat")
        Me.Tped.Style = "font-size: 11pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Tped.Text = Nothing
        Me.Tped.Top = 1.279528!
        Me.Tped.Visible = False
        Me.Tped.Width = 1.525591!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.25!
        Me.ReportHeader1.Name = "ReportHeader1"
        Me.ReportHeader1.Visible = False
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.TextBox2, Me.TextBox3, Me.Label16, Me.Label17, Me.Label19, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox4})
        Me.GroupHeader2.Height = 0.8125!
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "Nome"
        Me.TextBox1.Height = 0.1722441!
        Me.TextBox1.Left = 0.9104331!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox1.Text = "txtNome1"
        Me.TextBox1.Top = 0.02244095!
        Me.TextBox1.Width = 2.509843!
        '
        'Label12
        '
        Me.Label12.Height = 0.1722441!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label12.Text = "Cliente.........:"
        Me.Label12.Top = 0.02244095!
        Me.Label12.Width = 0.9104331!
        '
        'Label13
        '
        Me.Label13.Height = 0.1722441!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label13.Text = "Endereço.....:"
        Me.Label13.Top = 0.4161417!
        Me.Label13.Width = 0.9104331!
        '
        'Label14
        '
        Me.Label14.Height = 0.1722441!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.0!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label14.Text = "Cidade.........:"
        Me.Label14.Top = 0.6129922!
        Me.Label14.Width = 0.9104331!
        '
        'Label15
        '
        Me.Label15.Height = 0.1722441!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.0!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label15.Text = "Propriedade.:"
        Me.Label15.Top = 0.2192913!
        Me.Label15.Width = 0.9104331!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "Endereco"
        Me.TextBox2.Height = 0.1722441!
        Me.TextBox2.Left = 0.9104331!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox2.Text = "txtClientes_Endereço1"
        Me.TextBox2.Top = 0.4161417!
        Me.TextBox2.Width = 2.509843!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "Propriedades.Cidade"
        Me.TextBox3.Height = 0.1722441!
        Me.TextBox3.Left = 0.9104331!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox3.Text = "txtCidade1"
        Me.TextBox3.Top = 0.6129922!
        Me.TextBox3.Width = 2.509843!
        '
        'Label16
        '
        Me.Label16.Height = 0.1722441!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 5.265748!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label16.Text = "Cnpj/Cpf.:"
        Me.Label16.Top = 0.02244095!
        Me.Label16.Width = 0.8120081!
        '
        'Label17
        '
        Me.Label17.Height = 0.1722441!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 5.265748!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label17.Text = "Telefone.:"
        Me.Label17.Top = 0.3915354!
        Me.Label17.Width = 0.8120081!
        '
        'Label19
        '
        Me.Label19.Height = 0.1722441!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 5.265748!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label19.Text = "Insc. Est.:"
        Me.Label19.Top = 0.2192913!
        Me.Label19.Width = 0.8120081!
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "CpfCgc"
        Me.TextBox6.Height = 0.2!
        Me.TextBox6.Left = 6.151575!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox6.Text = "txtCpfCgc1"
        Me.TextBox6.Top = 0.02244095!
        Me.TextBox6.Width = 1.0!
        '
        'TextBox7
        '
        Me.TextBox7.DataField = "Inscricao"
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 6.151575!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox7.Text = "txtInscricao"
        Me.TextBox7.Top = 0.2192913!
        Me.TextBox7.Width = 1.0!
        '
        'TextBox8
        '
        Me.TextBox8.DataField = "Clientes.Telefone"
        Me.TextBox8.Height = 0.2!
        Me.TextBox8.Left = 6.151575!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox8.Text = "txtClientes_Telefone1"
        Me.TextBox8.Top = 0.3915354!
        Me.TextBox8.Width = 1.0!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "NomePropriedade"
        Me.TextBox4.Height = 0.1722441!
        Me.TextBox4.Left = 0.9104331!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox4.Text = "txtPropriedade"
        Me.TextBox4.Top = 0.2192913!
        Me.TextBox4.Width = 2.509843!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Height = 0.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.Label27, Me.TextBox16, Me.txtVeiculo, Me.txtkm, Me.txtplaca, Me.Label28, Me.Label29, Me.Label30, Me.Label31})
        Me.GroupHeader3.Height = 1.260417!
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'Shape2
        '
        Me.Shape2.Height = 1.033465!
        Me.Shape2.Left = 3.764764!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 0.2214567!
        Me.Shape2.Width = 3.715551!
        '
        'Label27
        '
        Me.Label27.ClassName = "Style1"
        Me.Label27.Height = 0.1722441!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 0.0246063!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label27.Text = "Descrição do Pedido"
        Me.Label27.Top = 0.0!
        Me.Label27.Width = 1.279528!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.CanGrow = False
        Me.TextBox16.DataField = "ObsCab"
        Me.TextBox16.Height = 1.058071!
        Me.TextBox16.Left = 0.0492126!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox16.Text = "TextBox16"
        Me.TextBox16.Top = 0.1968504!
        Me.TextBox16.Width = 3.617126!
        '
        'txtVeiculo
        '
        Me.txtVeiculo.Height = 0.7627953!
        Me.txtVeiculo.Left = 4.429134!
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtVeiculo.Text = Nothing
        Me.txtVeiculo.Top = 0.4675197!
        Me.txtVeiculo.Width = 3.001968!
        '
        'txtkm
        '
        Me.txtkm.DataField = "kmobjeto"
        Me.txtkm.Height = 0.1968504!
        Me.txtkm.Left = 6.278379!
        Me.txtkm.Name = "txtkm"
        Me.txtkm.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtkm.Text = Nothing
        Me.txtkm.Top = 0.2349083!
        Me.txtkm.Width = 1.13189!
        '
        'txtplaca
        '
        Me.txtplaca.Height = 0.1968504!
        Me.txtplaca.Left = 4.432907!
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtplaca.Text = Nothing
        Me.txtplaca.Top = 0.2349083!
        Me.txtplaca.Width = 1.32874!
        '
        'Label28
        '
        Me.Label28.Height = 0.1722441!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 3.785597!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "color: Transparent; font-size: 8pt; font-weight: bold; text-align: right; ddo-cha" & _
            "r-set: 1"
        Me.Label28.Text = "Veículo"
        Me.Label28.Top = 0.4831038!
        Me.Label28.Width = 0.5905512!
        '
        'Label29
        '
        Me.Label29.Height = 0.1722441!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 5.890419!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "color: Transparent; font-size: 8pt; font-weight: bold; text-align: right; ddo-cha" & _
            "r-set: 1"
        Me.Label29.Text = "Km"
        Me.Label29.Top = 0.2490979!
        Me.Label29.Width = 0.3198817!
        '
        'Label30
        '
        Me.Label30.Height = 0.1722441!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 3.785597!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "color: Transparent; font-size: 8pt; font-weight: bold; text-align: right; ddo-cha" & _
            "r-set: 1"
        Me.Label30.Text = "Placa"
        Me.Label30.Top = 0.2595146!
        Me.Label30.Width = 0.5905512!
        '
        'Label31
        '
        Me.Label31.ClassName = "Style1"
        Me.Label31.Height = 0.1722441!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 3.764764!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label31.Text = "Objeto"
        Me.Label31.Top = 0.0246063!
        Me.Label31.Width = 1.279528!
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Height = 0.2083333!
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'OSLiquido
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=E:\Prj Up\Dados\max\updados.mdb;jet " & _
            "oledb:database password=abc;"
        OleDBDataSource1.SQL = ""
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.1968504!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.1968504!
        Me.PageSettings.Margins.Top = 0.1968504!
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 7.58883!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.GroupHeader3)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter3)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; color: Black; fon" & _
                    "t-family: ""Tahoma""; font-size: 9pt; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; font-style: italic; font-family: ""Tahoma""; dd" & _
                    "o-char-set: 204", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 204", "Heading3", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; color: Black; font-family: ""Tahoma""; f" & _
                    "ont-size: 9pt; ddo-char-set: 204; font-weight: bold", "Style1"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; color: Black; fon" & _
                    "t-family: ""Tahoma""; ddo-char-set: 204; font-size: 8pt", "Style2"))
        CType(Me.txtPedido_PedidoSequencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa_Endereço1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa_Telefone1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequisicao1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataPedido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedidoTipo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientes_Endereço1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCidade1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCep1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCpfCgc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInsc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientes_Telefone1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPropriedade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLiquido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValorIssqn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tped, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtplaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SubProduto As DataDynamics.ActiveReports.SubReport
    Friend WithEvents SubServico As DataDynamics.ActiveReports.SubReport
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPedido_PedidoSequencia1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRazãoSocial1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEmpresa_Endereço1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEmpresa_Telefone1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtRequisicao1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDataPedido1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtPedidoTipo1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtClientes_Endereço1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCidade1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCep1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtNro1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtCpfCgc1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtInsc1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtClientes_Telefone1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label15 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label16 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label17 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label19 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodigoPropriedade As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label26 As DataDynamics.ActiveReports.Label
    Friend WithEvents TLiquido As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label18 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label20 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label21 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader3 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Label27 As DataDynamics.ActiveReports.Label
    Friend WithEvents GroupFooter3 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtVeiculo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtkm As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtplaca As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label28 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label29 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label30 As DataDynamics.ActiveReports.Label
    Friend WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label31 As DataDynamics.ActiveReports.Label
    Friend WithEvents ValorIssqn As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label32 As DataDynamics.ActiveReports.Label
    Friend WithEvents Tped As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label33 As DataDynamics.ActiveReports.Label
End Class
