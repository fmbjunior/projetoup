<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AnaliseProdutoVendido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaliseProdutoVendido))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCodigoProduto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescrição1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSomaDeQtd1 = New DataDynamics.ActiveReports.TextBox
        Me.txtExpr11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.txtMarca1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescontoMaximo1 = New DataDynamics.ActiveReports.TextBox
        Me.txtQuantidadeEstoque1 = New DataDynamics.ActiveReports.TextBox
        Me.txtEstoqueMinimo1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Dias = New DataDynamics.ActiveReports.TextBox
        Me.txtCodigoFabrica1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDuracEstoque1 = New DataDynamics.ActiveReports.TextBox
        Me.QtdUltimaCompra = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.periodo = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.NomeEmpresa = New DataDynamics.ActiveReports.Label
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Line3 = New DataDynamics.ActiveReports.Line
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSomaDeQtd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpr11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescontoMaximo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantidadeEstoque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstoqueMinimo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFabrica1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuracEstoque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtdUltimaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomeEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Line2, Me.Label11, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Line3})
        Me.PageHeader1.Height = 0.3680556!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.Label1.Height = 0.1476378!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.684055!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.Label1.Text = "Média"
        Me.Label1.Top = 0.0492126!
        Me.Label1.Width = 0.418307!
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
        Me.Label2.Height = 0.1476378!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.970473!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label2.Text = "Qtd Vendida"
        Me.Label2.Top = 0.0492126!
        Me.Label2.Width = 0.6889763!
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
        Me.Label3.Height = 0.1476378!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 7.185039!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label3.Text = "Est. min."
        Me.Label3.Top = 0.0492126!
        Me.Label3.Width = 0.4675197!
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
        Me.Label4.Height = 0.1476378!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 6.126968!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label4.Text = "Estoque"
        Me.Label4.Top = 0.0492126!
        Me.Label4.Width = 0.4675197!
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
        Me.Label5.Height = 0.2706693!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 8.366141!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label5.Text = "Desc. max"
        Me.Label5.Top = 0.0492126!
        Me.Label5.Width = 0.3690948!
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
        Me.Label6.Height = 0.1476378!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 7.677166!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label6.Text = "Valor Venda"
        Me.Label6.Top = 0.0492126!
        Me.Label6.Width = 0.6643698!
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
        Me.Label7.Height = 0.2952756!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 9.374016!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label7.Text = "Ult. Vlr Compra"
        Me.Label7.Top = 0.0511811!
        Me.Label7.Width = 0.6151575!
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
        Me.Label8.Height = 0.1476378!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 3.59252!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "text-align: left; font-size: 8pt; font-family: Tahoma; "
        Me.Label8.Text = "Marcas"
        Me.Label8.Top = 0.0492126!
        Me.Label8.Width = 0.9596457!
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
        Me.Label9.Height = 0.1476378!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 1.304134!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "text-align: left; font-size: 8pt; font-family: Tahoma; "
        Me.Label9.Text = "Descrição do Produto"
        Me.Label9.Top = 0.0492126!
        Me.Label9.Width = 2.239173!
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
        Me.Label10.Height = 0.1476378!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "text-align: left; font-size: 8pt; font-family: Tahoma; "
        Me.Label10.Text = "Código"
        Me.Label10.Top = 0.0492126!
        Me.Label10.Width = 0.5659449!
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
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0246063!
        Me.Line2.Width = 10.75853!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 10.75853!
        Me.Line2.Y1 = 0.0246063!
        Me.Line2.Y2 = 0.0246063!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Height = 0.1476378!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 4.601378!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label11.Text = "Dias"
        Me.Label11.Top = 0.0492126!
        Me.Label11.Width = 0.3198818!
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
        Me.Label13.Height = 0.1476378!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.5905512!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "text-align: left; font-size: 8pt; font-family: Tahoma; "
        Me.Label13.Text = "Cod. Fabrica"
        Me.Label13.Top = 0.0492126!
        Me.Label13.Width = 0.6889763!
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
        Me.Label14.Height = 0.2952756!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 6.619094!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; vertical-align: top; "
        Me.Label14.Text = "Duração Est. dias"
        Me.Label14.Top = 0.0492126!
        Me.Label14.Width = 0.5413386!
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
        Me.Label15.Height = 0.2952756!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 8.783464!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label15.Text = "Qtd Ult. Compra"
        Me.Label15.Top = 0.0511811!
        Me.Label15.Width = 0.5669292!
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
        Me.Label16.Height = 0.2706693!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 10.03937!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "text-align: center; font-size: 8pt; font-family: Tahoma; "
        Me.Label16.Text = "Data Ult. Compra"
        Me.Label16.Top = 0.0492126!
        Me.Label16.Width = 0.7135825!
        '
        'Detail1
        '
        Me.Detail1.CanGrow = False
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodigoProduto1, Me.txtDescrição1, Me.txtSomaDeQtd1, Me.txtExpr11, Me.TextBox3, Me.txtMarca1, Me.txtDescontoMaximo1, Me.txtQuantidadeEstoque1, Me.txtEstoqueMinimo1, Me.TextBox1, Me.Dias, Me.txtCodigoFabrica1, Me.txtDuracEstoque1, Me.QtdUltimaCompra, Me.TextBox2})
        Me.Detail1.Height = 0.1527778!
        Me.Detail1.Name = "Detail1"
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
        Me.txtCodigoProduto1.CanGrow = False
        Me.txtCodigoProduto1.DataField = "CodigoProduto"
        Me.txtCodigoProduto1.Height = 0.1476378!
        Me.txtCodigoProduto1.Left = 0.0!
        Me.txtCodigoProduto1.Name = "txtCodigoProduto1"
        Me.txtCodigoProduto1.OutputFormat = resources.GetString("txtCodigoProduto1.OutputFormat")
        Me.txtCodigoProduto1.Style = "font-size: 8pt; font-family: Tahoma; "
        Me.txtCodigoProduto1.Text = Nothing
        Me.txtCodigoProduto1.Top = 0.0!
        Me.txtCodigoProduto1.Width = 0.5413386!
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
        Me.txtDescrição1.CanGrow = False
        Me.txtDescrição1.DataField = "Descrição"
        Me.txtDescrição1.Height = 0.1476378!
        Me.txtDescrição1.Left = 1.279528!
        Me.txtDescrição1.Name = "txtDescrição1"
        Me.txtDescrição1.Style = "font-size: 8pt; font-family: Tahoma; "
        Me.txtDescrição1.Text = Nothing
        Me.txtDescrição1.Top = 0.0!
        Me.txtDescrição1.Width = 2.263779!
        '
        'txtSomaDeQtd1
        '
        Me.txtSomaDeQtd1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSomaDeQtd1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeQtd1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSomaDeQtd1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeQtd1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSomaDeQtd1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeQtd1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSomaDeQtd1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeQtd1.CanGrow = False
        Me.txtSomaDeQtd1.DataField = "SomaDeQtd"
        Me.txtSomaDeQtd1.Height = 0.1476378!
        Me.txtSomaDeQtd1.Left = 4.970473!
        Me.txtSomaDeQtd1.Name = "txtSomaDeQtd1"
        Me.txtSomaDeQtd1.OutputFormat = resources.GetString("txtSomaDeQtd1.OutputFormat")
        Me.txtSomaDeQtd1.Style = "text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtSomaDeQtd1.Text = Nothing
        Me.txtSomaDeQtd1.Top = 0.0!
        Me.txtSomaDeQtd1.Width = 0.6889766!
        '
        'txtExpr11
        '
        Me.txtExpr11.Border.BottomColor = System.Drawing.Color.Black
        Me.txtExpr11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExpr11.Border.LeftColor = System.Drawing.Color.Black
        Me.txtExpr11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExpr11.Border.RightColor = System.Drawing.Color.Black
        Me.txtExpr11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExpr11.Border.TopColor = System.Drawing.Color.Black
        Me.txtExpr11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExpr11.CanGrow = False
        Me.txtExpr11.DataField = "Expr1"
        Me.txtExpr11.Height = 0.1476378!
        Me.txtExpr11.Left = 5.684055!
        Me.txtExpr11.Name = "txtExpr11"
        Me.txtExpr11.OutputFormat = resources.GetString("txtExpr11.OutputFormat")
        Me.txtExpr11.Style = "text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtExpr11.Text = Nothing
        Me.txtExpr11.Top = 0.0!
        Me.txtExpr11.Width = 0.418307!
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
        Me.TextBox3.CanGrow = False
        Me.TextBox3.DataField = "ValorVenda"
        Me.TextBox3.Height = 0.1476378!
        Me.TextBox3.Left = 7.726377!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.6643704!
        '
        'txtMarca1
        '
        Me.txtMarca1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMarca1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMarca1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca1.Border.RightColor = System.Drawing.Color.Black
        Me.txtMarca1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca1.Border.TopColor = System.Drawing.Color.Black
        Me.txtMarca1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca1.CanGrow = False
        Me.txtMarca1.DataField = "Marca"
        Me.txtMarca1.Height = 0.1476378!
        Me.txtMarca1.Left = 3.59252!
        Me.txtMarca1.Name = "txtMarca1"
        Me.txtMarca1.Style = "font-size: 8pt; font-family: Tahoma; "
        Me.txtMarca1.Text = Nothing
        Me.txtMarca1.Top = 0.0!
        Me.txtMarca1.Width = 0.9596456!
        '
        'txtDescontoMaximo1
        '
        Me.txtDescontoMaximo1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescontoMaximo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescontoMaximo1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescontoMaximo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescontoMaximo1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescontoMaximo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescontoMaximo1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescontoMaximo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescontoMaximo1.DataField = "DescontoMaximo"
        Me.txtDescontoMaximo1.Height = 0.1476378!
        Me.txtDescontoMaximo1.Left = 8.415355!
        Me.txtDescontoMaximo1.Name = "txtDescontoMaximo1"
        Me.txtDescontoMaximo1.Style = "text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtDescontoMaximo1.Text = Nothing
        Me.txtDescontoMaximo1.Top = 0.0!
        Me.txtDescontoMaximo1.Width = 0.3198818!
        '
        'txtQuantidadeEstoque1
        '
        Me.txtQuantidadeEstoque1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQuantidadeEstoque1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQuantidadeEstoque1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQuantidadeEstoque1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQuantidadeEstoque1.Border.RightColor = System.Drawing.Color.Black
        Me.txtQuantidadeEstoque1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQuantidadeEstoque1.Border.TopColor = System.Drawing.Color.Black
        Me.txtQuantidadeEstoque1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQuantidadeEstoque1.DataField = "QuantidadeEstoque"
        Me.txtQuantidadeEstoque1.Height = 0.1476378!
        Me.txtQuantidadeEstoque1.Left = 6.126968!
        Me.txtQuantidadeEstoque1.Name = "txtQuantidadeEstoque1"
        Me.txtQuantidadeEstoque1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.txtQuantidadeEstoque1.Text = Nothing
        Me.txtQuantidadeEstoque1.Top = 0.0!
        Me.txtQuantidadeEstoque1.Width = 0.4921263!
        '
        'txtEstoqueMinimo1
        '
        Me.txtEstoqueMinimo1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtEstoqueMinimo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEstoqueMinimo1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtEstoqueMinimo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEstoqueMinimo1.Border.RightColor = System.Drawing.Color.Black
        Me.txtEstoqueMinimo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEstoqueMinimo1.Border.TopColor = System.Drawing.Color.Black
        Me.txtEstoqueMinimo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEstoqueMinimo1.DataField = "EstoqueMinimo"
        Me.txtEstoqueMinimo1.Height = 0.1476378!
        Me.txtEstoqueMinimo1.Left = 7.209646!
        Me.txtEstoqueMinimo1.Name = "txtEstoqueMinimo1"
        Me.txtEstoqueMinimo1.Style = "text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.txtEstoqueMinimo1.Text = Nothing
        Me.txtEstoqueMinimo1.Top = 0.0!
        Me.txtEstoqueMinimo1.Width = 0.4675197!
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
        Me.TextBox1.CanGrow = False
        Me.TextBox1.DataField = "ValorCompra"
        Me.TextBox1.Height = 0.1476378!
        Me.TextBox1.Left = 9.375!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.6397639!
        '
        'Dias
        '
        Me.Dias.Border.BottomColor = System.Drawing.Color.Black
        Me.Dias.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Dias.Border.LeftColor = System.Drawing.Color.Black
        Me.Dias.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Dias.Border.RightColor = System.Drawing.Color.Black
        Me.Dias.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Dias.Border.TopColor = System.Drawing.Color.Black
        Me.Dias.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Dias.Height = 0.1476378!
        Me.Dias.Left = 4.601378!
        Me.Dias.Name = "Dias"
        Me.Dias.Style = "text-align: right; font-size: 8pt; font-family: Tahoma; "
        Me.Dias.Text = Nothing
        Me.Dias.Top = 0.0!
        Me.Dias.Width = 0.3198816!
        '
        'txtCodigoFabrica1
        '
        Me.txtCodigoFabrica1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoFabrica1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoFabrica1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoFabrica1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoFabrica1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoFabrica1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoFabrica1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoFabrica1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoFabrica1.DataField = "CodigoFabrica"
        Me.txtCodigoFabrica1.Height = 0.1476378!
        Me.txtCodigoFabrica1.Left = 0.5413386!
        Me.txtCodigoFabrica1.Name = "txtCodigoFabrica1"
        Me.txtCodigoFabrica1.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.txtCodigoFabrica1.Text = Nothing
        Me.txtCodigoFabrica1.Top = 0.0!
        Me.txtCodigoFabrica1.Width = 0.7135827!
        '
        'txtDuracEstoque1
        '
        Me.txtDuracEstoque1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDuracEstoque1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDuracEstoque1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDuracEstoque1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDuracEstoque1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDuracEstoque1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDuracEstoque1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDuracEstoque1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDuracEstoque1.DataField = "DuracEstoque"
        Me.txtDuracEstoque1.Height = 0.1476378!
        Me.txtDuracEstoque1.Left = 6.643701!
        Me.txtDuracEstoque1.Name = "txtDuracEstoque1"
        Me.txtDuracEstoque1.OutputFormat = resources.GetString("txtDuracEstoque1.OutputFormat")
        Me.txtDuracEstoque1.Style = "color: #0000C0; ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: " & _
            "Tahoma; "
        Me.txtDuracEstoque1.Text = Nothing
        Me.txtDuracEstoque1.Top = 0.0!
        Me.txtDuracEstoque1.Width = 0.4921259!
        '
        'QtdUltimaCompra
        '
        Me.QtdUltimaCompra.Border.BottomColor = System.Drawing.Color.Black
        Me.QtdUltimaCompra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.QtdUltimaCompra.Border.LeftColor = System.Drawing.Color.Black
        Me.QtdUltimaCompra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.QtdUltimaCompra.Border.RightColor = System.Drawing.Color.Black
        Me.QtdUltimaCompra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.QtdUltimaCompra.Border.TopColor = System.Drawing.Color.Black
        Me.QtdUltimaCompra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.QtdUltimaCompra.DataField = "UltimoValorCompra"
        Me.QtdUltimaCompra.Height = 0.1476378!
        Me.QtdUltimaCompra.Left = 8.784449!
        Me.QtdUltimaCompra.Name = "QtdUltimaCompra"
        Me.QtdUltimaCompra.OutputFormat = resources.GetString("QtdUltimaCompra.OutputFormat")
        Me.QtdUltimaCompra.Style = "color: #0000C0; ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: " & _
            "Tahoma; "
        Me.QtdUltimaCompra.Text = Nothing
        Me.QtdUltimaCompra.Top = 0.0!
        Me.QtdUltimaCompra.Width = 0.5659453!
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
        Me.TextBox2.CanGrow = False
        Me.TextBox2.DataField = "DataUltimaCompra"
        Me.TextBox2.Height = 0.1476378!
        Me.TextBox2.Left = 10.06398!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "color: #0000C0; ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: " & _
            "Tahoma; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.688976!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.periodo, Me.Label12, Me.Line1, Me.NomeEmpresa})
        Me.ReportHeader1.Height = 0.8819444!
        Me.ReportHeader1.Name = "ReportHeader1"
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
        Me.periodo.Height = 0.1968504!
        Me.periodo.HyperLink = Nothing
        Me.periodo.Left = 0.0246063!
        Me.periodo.Name = "periodo"
        Me.periodo.Style = "font-weight: bold; font-size: 10pt; font-family: Tahoma; "
        Me.periodo.Text = ""
        Me.periodo.Top = 0.6349246!
        Me.periodo.Width = 4.625985!
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
        Me.Label12.Height = 0.2706693!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0246063!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-weight: bold; font-size: 14pt; font-family: Tahoma; "
        Me.Label12.Text = "Análise de produtos vendidos"
        Me.Label12.Top = 0.3254593!
        Me.Label12.Width = 4.625985!
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
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.8612205!
        Me.Line1.Width = 10.72835!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 10.72835!
        Me.Line1.Y1 = 0.8612205!
        Me.Line1.Y2 = 0.8612205!
        '
        'NomeEmpresa
        '
        Me.NomeEmpresa.Border.BottomColor = System.Drawing.Color.Black
        Me.NomeEmpresa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NomeEmpresa.Border.LeftColor = System.Drawing.Color.Black
        Me.NomeEmpresa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NomeEmpresa.Border.RightColor = System.Drawing.Color.Black
        Me.NomeEmpresa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NomeEmpresa.Border.TopColor = System.Drawing.Color.Black
        Me.NomeEmpresa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.NomeEmpresa.Height = 0.2706693!
        Me.NomeEmpresa.HyperLink = Nothing
        Me.NomeEmpresa.Left = 0.0246063!
        Me.NomeEmpresa.Name = "NomeEmpresa"
        Me.NomeEmpresa.Style = "font-weight: bold; font-size: 14pt; font-family: Tahoma; "
        Me.NomeEmpresa.Text = ""
        Me.NomeEmpresa.Top = 0.0246063!
        Me.NomeEmpresa.Width = 7.824804!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.25!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.3482611!
        Me.Line3.Width = 10.76895!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 10.76895!
        Me.Line3.Y1 = 0.3482611!
        Me.Line3.Y2 = 0.3482611!
        '
        'AnaliseProdutoVendido
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Projetos dblsistemas\Prj Up mAX\D" & _
            "ados\max\updados.mdb;Jet oledb:database password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.3937007!
        Me.PageSettings.Margins.Left = 0.1968504!
        Me.PageSettings.Margins.Right = 0.1968504!
        Me.PageSettings.Margins.Top = 0.3937007!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.79637!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSomaDeQtd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpr11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescontoMaximo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantidadeEstoque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstoqueMinimo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFabrica1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuracEstoque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtdUltimaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomeEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCodigoProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescrição1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSomaDeQtd1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtExpr11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtMarca1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescontoMaximo1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQuantidadeEstoque1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEstoqueMinimo1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents periodo As DataDynamics.ActiveReports.Label
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Dias As DataDynamics.ActiveReports.TextBox
    Friend WithEvents NomeEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtCodigoFabrica1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtDuracEstoque1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label15 As DataDynamics.ActiveReports.Label
    Friend WithEvents QtdUltimaCompra As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label16 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
End Class
