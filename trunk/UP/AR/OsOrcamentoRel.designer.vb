<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OsOrcamentoRel
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OsOrcamentoRel))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource()
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.Shape1 = New DataDynamics.ActiveReports.Shape()
        Me.txtCodigoOrcamento = New DataDynamics.ActiveReports.TextBox()
        Me.txtRazãoSocial1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEmpresa_Endereço1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtEmpresa_Telefone1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.txtDataPedido1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Validade = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.chkGeradoPed = New DataDynamics.ActiveReports.CheckBox()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.SubProduto = New DataDynamics.ActiveReports.SubReport()
        Me.SubServico = New DataDynamics.ActiveReports.SubReport()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo()
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
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.CondicaoPgto = New DataDynamics.ActiveReports.TextBox()
        Me.txtObsServico = New DataDynamics.ActiveReports.TextBox()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter()
        Me.lblMsg = New DataDynamics.ActiveReports.Label()
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
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txtCodigoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa_Endereço1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa_Telefone1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataPedido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Validade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGeradoPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CondicaoPgto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObsServico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMsg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.txtCodigoOrcamento, Me.txtRazãoSocial1, Me.txtEmpresa_Endereço1, Me.txtEmpresa_Telefone1, Me.Label2, Me.txtDataPedido1, Me.Label4, Me.Line1, Me.Validade, Me.Label3, Me.Picture1, Me.chkGeradoPed})
        Me.PageHeader1.Height = 1.145834!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Shape1
        '
        Me.Shape1.Height = 0.7758662!
        Me.Shape1.Left = 5.266!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 20.0!
        Me.Shape1.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
        Me.Shape1.Top = 0.295!
        Me.Shape1.Width = 2.260417!
        '
        'txtCodigoOrcamento
        '
        Me.txtCodigoOrcamento.DataField = "Orcamento"
        Me.txtCodigoOrcamento.Height = 0.1968504!
        Me.txtCodigoOrcamento.Left = 6.545473!
        Me.txtCodigoOrcamento.Name = "txtCodigoOrcamento"
        Me.txtCodigoOrcamento.OutputFormat = resources.GetString("txtCodigoOrcamento.OutputFormat")
        Me.txtCodigoOrcamento.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtCodigoOrcamento.Text = "CodigoOrcamento"
        Me.txtCodigoOrcamento.Top = 0.3420932!
        Me.txtCodigoOrcamento.Width = 0.9104329!
        '
        'txtRazãoSocial1
        '
        Me.txtRazãoSocial1.DataField = "RazãoSocial"
        Me.txtRazãoSocial1.Height = 0.1945433!
        Me.txtRazãoSocial1.Left = 1.051!
        Me.txtRazãoSocial1.Name = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Style = "font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.txtRazãoSocial1.Text = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Top = 0.009000001!
        Me.txtRazãoSocial1.Width = 6.469001!
        '
        'txtEmpresa_Endereço1
        '
        Me.txtEmpresa_Endereço1.DataField = "Empresa.Endereço"
        Me.txtEmpresa_Endereço1.Height = 0.1559055!
        Me.txtEmpresa_Endereço1.Left = 1.050787!
        Me.txtEmpresa_Endereço1.Name = "txtEmpresa_Endereço1"
        Me.txtEmpresa_Endereço1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtEmpresa_Endereço1.Text = "txtEmpresa_Endereço1"
        Me.txtEmpresa_Endereço1.Top = 0.2440945!
        Me.txtEmpresa_Endereço1.Width = 2.763566!
        '
        'txtEmpresa_Telefone1
        '
        Me.txtEmpresa_Telefone1.DataField = "Empresa.Telefone"
        Me.txtEmpresa_Telefone1.Height = 0.1661417!
        Me.txtEmpresa_Telefone1.Left = 1.050787!
        Me.txtEmpresa_Telefone1.Name = "txtEmpresa_Telefone1"
        Me.txtEmpresa_Telefone1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtEmpresa_Telefone1.Text = "txtEmpresa_Telefone1"
        Me.txtEmpresa_Telefone1.Top = 0.4204725!
        Me.txtEmpresa_Telefone1.Width = 2.763566!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.339764!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label2.Text = "Orçamento N.:"
        Me.Label2.Top = 0.3420932!
        Me.Label2.Width = 1.205709!
        '
        'txtDataPedido1
        '
        Me.txtDataPedido1.DataField = "DataOrcamento"
        Me.txtDataPedido1.Height = 0.1968504!
        Me.txtDataPedido1.Left = 6.545473!
        Me.txtDataPedido1.Name = "txtDataPedido1"
        Me.txtDataPedido1.OutputFormat = resources.GetString("txtDataPedido1.OutputFormat")
        Me.txtDataPedido1.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtDataPedido1.Text = "DataOrcamento"
        Me.txtDataPedido1.Top = 0.5881562!
        Me.txtDataPedido1.Width = 0.9104329!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 5.339764!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label4.Text = "Data Orçamento.:"
        Me.Label4.Top = 0.5881562!
        Me.Label4.Width = 1.205709!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.109449!
        Me.Line1.Width = 7.57874!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 7.57874!
        Me.Line1.Y1 = 1.109449!
        Me.Line1.Y2 = 1.109449!
        '
        'Validade
        '
        Me.Validade.ClassName = "Style1"
        Me.Validade.DataField = "Validade"
        Me.Validade.Height = 0.1968504!
        Me.Validade.Left = 6.570079!
        Me.Validade.Name = "Validade"
        Me.Validade.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Validade.Text = "Validade"
        Me.Validade.Top = 0.8133859!
        Me.Validade.Width = 0.8612205!
        '
        'Label3
        '
        Me.Label3.ClassName = "Style1"
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.36437!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label3.Text = "Validade.:"
        Me.Label3.Top = 0.8096129!
        Me.Label3.Width = 1.156496!
        '
        'Picture1
        '
        Me.Picture1.DataField = "Foto"
        Me.Picture1.Height = 0.835!
        Me.Picture1.ImageData = Nothing
        Me.Picture1.Left = 0.035!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture1.Top = 0.079!
        Me.Picture1.Width = 0.9539999!
        '
        'chkGeradoPed
        '
        Me.chkGeradoPed.DataField = "GeradoPedido"
        Me.chkGeradoPed.Height = 0.2!
        Me.chkGeradoPed.Left = 0.08661418!
        Me.chkGeradoPed.Name = "chkGeradoPed"
        Me.chkGeradoPed.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.chkGeradoPed.Text = "GeradoPedido"
        Me.chkGeradoPed.Top = 0.9295276!
        Me.chkGeradoPed.Visible = False
        Me.chkGeradoPed.Width = 1.0!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.SubProduto, Me.SubServico})
        Me.Detail1.Height = 0.6666667!
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
        Me.SubProduto.Top = 0.01023622!
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
        Me.SubServico.Top = 0.3220473!
        Me.SubServico.Width = 7.504921!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line4, Me.ReportInfo1})
        Me.PageFooter1.Height = 0.2760417!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'Line4
        '
        Me.Line4.Height = 0.00377297!
        Me.Line4.Left = 0.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.02086614!
        Me.Line4.Width = 7.57874!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 7.57874!
        Me.Line4.Y1 = 0.02086614!
        Me.Line4.Y2 = 0.02463911!
        '
        'ReportInfo1
        '
        Me.ReportInfo1.FormatString = "Pág. {PageNumber} de {PageCount} em {RunDateTime}"
        Me.ReportInfo1.Height = 0.1968504!
        Me.ReportInfo1.Left = 0.0246063!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.ReportInfo1.Top = 0.0492126!
        Me.ReportInfo1.Width = 3.887795!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNome1, Me.Label1, Me.Label5, Me.Label6, Me.Label7, Me.txtClientes_Endereço1, Me.txtCidade1, Me.txtCep1, Me.Label8, Me.Label9, Me.Label10, Me.txtNro1, Me.Label11, Me.txtCpfCgc1, Me.txtInsc1, Me.txtClientes_Telefone1, Me.txtCodigoPropriedade})
        Me.GroupHeader1.DataField = "PedidoInterno"
        Me.GroupHeader1.Height = 0.8020834!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'txtNome1
        '
        Me.txtNome1.DataField = "NomeCliente"
        Me.txtNome1.Height = 0.1574803!
        Me.txtNome1.Left = 0.9055119!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.03937008!
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
        Me.Label1.Top = 0.0492126!
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
        Me.Label5.Top = 0.2214567!
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
        Me.Label6.Top = 0.3937008!
        Me.Label6.Width = 0.9104331!
        '
        'Label7
        '
        Me.Label7.Height = 0.1722441!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.0!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label7.Text = "Cep.............:"
        Me.Label7.Top = 0.5725886!
        Me.Label7.Width = 0.9104331!
        '
        'txtClientes_Endereço1
        '
        Me.txtClientes_Endereço1.DataField = "Clientes.Endereço"
        Me.txtClientes_Endereço1.Height = 0.1722441!
        Me.txtClientes_Endereço1.Left = 0.9075623!
        Me.txtClientes_Endereço1.Name = "txtClientes_Endereço1"
        Me.txtClientes_Endereço1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtClientes_Endereço1.Text = "txtClientes_Endereço1"
        Me.txtClientes_Endereço1.Top = 0.2214567!
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
        Me.txtCidade1.Top = 0.3937008!
        Me.txtCidade1.Width = 2.509843!
        '
        'txtCep1
        '
        Me.txtCep1.DataField = "Cep"
        Me.txtCep1.Height = 0.1722441!
        Me.txtCep1.Left = 0.9113353!
        Me.txtCep1.Name = "txtCep1"
        Me.txtCep1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCep1.Text = "txtCep1"
        Me.txtCep1.Top = 0.5659449!
        Me.txtCep1.Width = 1.008858!
        '
        'Label8
        '
        Me.Label8.Height = 0.1722441!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.265748!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label8.Text = "Cnpj/Cpf.:"
        Me.Label8.Top = 0.0492126!
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
        Me.Label9.Top = 0.4391404!
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
        Me.Label10.Top = 0.2214567!
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
        Me.txtNro1.Top = 0.2214567!
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
        Me.Label11.Top = 0.246063!
        Me.Label11.Width = 0.8120081!
        '
        'txtCpfCgc1
        '
        Me.txtCpfCgc1.DataField = "CnpjCpf"
        Me.txtCpfCgc1.Height = 0.1574803!
        Me.txtCpfCgc1.Left = 6.141733!
        Me.txtCpfCgc1.Name = "txtCpfCgc1"
        Me.txtCpfCgc1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCpfCgc1.Text = "txtCpfCgc1"
        Me.txtCpfCgc1.Top = 0.05790683!
        Me.txtCpfCgc1.Width = 1.377953!
        '
        'txtInsc1
        '
        Me.txtInsc1.DataField = "Rgie"
        Me.txtInsc1.Height = 0.1574803!
        Me.txtInsc1.Left = 6.141733!
        Me.txtInsc1.Name = "txtInsc1"
        Me.txtInsc1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtInsc1.Text = "txtInsc1"
        Me.txtInsc1.Top = 0.2755906!
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
        Me.txtClientes_Telefone1.Top = 0.4434876!
        Me.txtClientes_Telefone1.Width = 0.9842519!
        '
        'txtCodigoPropriedade
        '
        Me.txtCodigoPropriedade.DataField = "Propriedade"
        Me.txtCodigoPropriedade.Height = 0.1722441!
        Me.txtCodigoPropriedade.Left = 4.749016!
        Me.txtCodigoPropriedade.Name = "txtCodigoPropriedade"
        Me.txtCodigoPropriedade.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCodigoPropriedade.Text = Nothing
        Me.txtCodigoPropriedade.Top = 0.0492126!
        Me.txtCodigoPropriedade.Visible = False
        Me.txtCodigoPropriedade.Width = 0.3444885!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label26, Me.TextBox15, Me.Line2, Me.Label18, Me.CondicaoPgto, Me.txtObsServico, Me.Label23})
        Me.GroupFooter1.Height = 0.96875!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label26
        '
        Me.Label26.Height = 0.2214567!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 5.831693!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-size: 10pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Label26.Text = "Total Orçamento"
        Me.Label26.Top = 0.1027559!
        Me.Label26.Width = 1.648622!
        '
        'TextBox15
        '
        Me.TextBox15.DataField = "TotalOrcamento"
        Me.TextBox15.Height = 0.2214567!
        Me.TextBox15.Left = 5.831693!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "font-size: 10pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.3242127!
        Me.TextBox15.Width = 1.648622!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.05354331!
        Me.Line2.Width = 7.57874!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.57874!
        Me.Line2.Y1 = 0.05354331!
        Me.Line2.Y2 = 0.05354331!
        '
        'Label18
        '
        Me.Label18.ClassName = "Style1"
        Me.Label18.Height = 0.1722441!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.0246063!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label18.Text = "Condição de pagamento.:"
        Me.Label18.Top = 0.1765749!
        Me.Label18.Width = 1.722441!
        '
        'CondicaoPgto
        '
        Me.CondicaoPgto.DataField = "CódigoPagamento"
        Me.CondicaoPgto.Height = 0.1722441!
        Me.CondicaoPgto.Left = 1.79626!
        Me.CondicaoPgto.Name = "CondicaoPgto"
        Me.CondicaoPgto.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.CondicaoPgto.Text = "CondicaoPgto"
        Me.CondicaoPgto.Top = 0.1765749!
        Me.CondicaoPgto.Width = 2.878937!
        '
        'txtObsServico
        '
        Me.txtObsServico.DataField = "ObsServico"
        Me.txtObsServico.Height = 0.1657688!
        Me.txtObsServico.Left = 0.04144219!
        Me.txtObsServico.Name = "txtObsServico"
        Me.txtObsServico.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtObsServico.Text = "ObsServico"
        Me.txtObsServico.Top = 0.6453897!
        Me.txtObsServico.Width = 4.600083!
        '
        'Label23
        '
        Me.Label23.Height = 0.1722441!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.04144219!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-size: 8pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.Label23.Text = "Obs.:"
        Me.Label23.Top = 0.4588999!
        Me.Label23.Width = 1.008858!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.25!
        Me.ReportHeader1.Name = "ReportHeader1"
        Me.ReportHeader1.Visible = False
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblMsg})
        Me.ReportFooter1.Height = 0.4479167!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'lblMsg
        '
        Me.lblMsg.Height = 0.25!
        Me.lblMsg.HyperLink = Nothing
        Me.lblMsg.Left = 0.0492126!
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.lblMsg.Text = "Atenção.:"
        Me.lblMsg.Top = 0.08070867!
        Me.lblMsg.Width = 6.958333!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.TextBox2, Me.TextBox3, Me.Label16, Me.Label17, Me.Label19, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox4, Me.TextBox5})
        Me.GroupHeader2.Height = 0.8854167!
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
        Me.TextBox1.Top = 0.0738189!
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
        Me.Label12.Top = 0.0738189!
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
        Me.Label13.Top = 0.4675197!
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
        Me.Label14.Top = 0.6643701!
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
        Me.Label15.Top = 0.2706693!
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
        Me.TextBox2.Top = 0.4675197!
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
        Me.TextBox3.Top = 0.6643701!
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
        Me.Label16.Top = 0.0738189!
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
        Me.Label17.Top = 0.4429134!
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
        Me.Label19.Top = 0.2706693!
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
        Me.TextBox6.Top = 0.0738189!
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
        Me.TextBox7.Top = 0.2706693!
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
        Me.TextBox8.Top = 0.4429134!
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
        Me.TextBox4.Top = 0.2706693!
        Me.TextBox4.Width = 2.509843!
        '
        'TextBox5
        '
        Me.TextBox5.ClassName = "Style1"
        Me.TextBox5.DataField = "Validade"
        Me.TextBox5.Height = 0.1968504!
        Me.TextBox5.Left = 3.666339!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TextBox5.Text = "Validade"
        Me.TextBox5.Top = 0.5413386!
        Me.TextBox5.Width = 0.8612205!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Height = 0.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'OsOrcamentoRel
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
        Me.Sections.Add(Me.Detail1)
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
        CType(Me.txtCodigoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa_Endereço1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa_Telefone1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataPedido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Validade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGeradoPed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CondicaoPgto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObsServico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMsg, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SubProduto As DataDynamics.ActiveReports.SubReport
    Friend WithEvents SubServico As DataDynamics.ActiveReports.SubReport
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodigoOrcamento As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRazãoSocial1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEmpresa_Endereço1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEmpresa_Telefone1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtDataPedido1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
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
    Friend WithEvents Label26 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Validade As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents lblMsg As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents Label18 As DataDynamics.ActiveReports.Label
    Friend WithEvents CondicaoPgto As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtObsServico As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Private WithEvents chkGeradoPed As DataDynamics.ActiveReports.CheckBox
End Class
