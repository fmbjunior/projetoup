<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelCompraSintetico 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelCompraSintetico))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCompraInterno1 = New DataDynamics.ActiveReports.TextBox
        Me.txtNotaFiscal1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDataLançamento1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDataCompra1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCodNomeFornecedor1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCFOP1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorCompra1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.periodo = New DataDynamics.ActiveReports.Label
        Me.txtNomeFantasia1 = New DataDynamics.ActiveReports.TextBox
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompraInterno1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotaFiscal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataLançamento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataCompra1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodNomeFornecedor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCFOP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorCompra1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeFantasia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Line2})
        Me.PageHeader1.Height = 0.2396654!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Label1
        '
        Me.Label1.Height = 0.1795276!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label1.Text = "Cod. ID"
        Me.Label1.Top = 0.00000002980232!
        Me.Label1.Width = 0.4897638!
        '
        'Label2
        '
        Me.Label2.Height = 0.1795276!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.5413386!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Label2.Text = "NF"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.5425197!
        '
        'Label3
        '
        Me.Label3.Height = 0.1795276!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.198819!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label3.Text = "Dt. Lanç."
        Me.Label3.Top = 0.00000002980232!
        Me.Label3.Width = 0.7188976!
        '
        'Label4
        '
        Me.Label4.Height = 0.1795276!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.979921!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label4.Text = "Dt.Compra"
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 0.6350397!
        '
        'Label5
        '
        Me.Label5.Height = 0.1795276!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.677165!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label5.Text = "Fornecedor"
        Me.Label5.Top = 0.00000002980232!
        Me.Label5.Width = 3.364173!
        '
        'Label6
        '
        Me.Label6.Height = 0.1795276!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 6.093701!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.Label6.Text = "Cfop"
        Me.Label6.Top = 0.01023622!
        Me.Label6.Width = 0.3244101!
        '
        'Label7
        '
        Me.Label7.Height = 0.1795276!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.458268!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label7.Text = "Valor NF"
        Me.Label7.Top = 0.00000002980232!
        Me.Label7.Width = 0.8645668!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.09212598!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.2204724!
        Me.Line2.Width = 7.191339!
        Me.Line2.X1 = 0.09212598!
        Me.Line2.X2 = 7.283465!
        Me.Line2.Y1 = 0.2204724!
        Me.Line2.Y2 = 0.2204724!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCompraInterno1, Me.txtNotaFiscal1, Me.txtDataLançamento1, Me.txtDataCompra1, Me.txtCodNomeFornecedor1, Me.txtCFOP1, Me.txtValorCompra1})
        Me.Detail1.Height = 0.2083334!
        Me.Detail1.Name = "Detail1"
        '
        'txtCompraInterno1
        '
        Me.txtCompraInterno1.DataField = "CompraInterno"
        Me.txtCompraInterno1.Height = 0.2!
        Me.txtCompraInterno1.Left = 0.0!
        Me.txtCompraInterno1.Name = "txtCompraInterno1"
        Me.txtCompraInterno1.OutputFormat = resources.GetString("txtCompraInterno1.OutputFormat")
        Me.txtCompraInterno1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCompraInterno1.Text = "txtCompraInterno1"
        Me.txtCompraInterno1.Top = 0.0!
        Me.txtCompraInterno1.Width = 0.4897638!
        '
        'txtNotaFiscal1
        '
        Me.txtNotaFiscal1.DataField = "NotaFiscal"
        Me.txtNotaFiscal1.Height = 0.2!
        Me.txtNotaFiscal1.Left = 0.5413386!
        Me.txtNotaFiscal1.Name = "txtNotaFiscal1"
        Me.txtNotaFiscal1.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtNotaFiscal1.Text = "txtNotaFiscal1"
        Me.txtNotaFiscal1.Top = 0.0!
        Me.txtNotaFiscal1.Width = 0.5425197!
        '
        'txtDataLançamento1
        '
        Me.txtDataLançamento1.DataField = "DataLançamento"
        Me.txtDataLançamento1.Height = 0.2!
        Me.txtDataLançamento1.Left = 1.198819!
        Me.txtDataLançamento1.Name = "txtDataLançamento1"
        Me.txtDataLançamento1.OutputFormat = resources.GetString("txtDataLançamento1.OutputFormat")
        Me.txtDataLançamento1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtDataLançamento1.Text = "txtDataLançamento1"
        Me.txtDataLançamento1.Top = 0.0!
        Me.txtDataLançamento1.Width = 0.7188976!
        '
        'txtDataCompra1
        '
        Me.txtDataCompra1.DataField = "DataCompra"
        Me.txtDataCompra1.Height = 0.2!
        Me.txtDataCompra1.Left = 1.979921!
        Me.txtDataCompra1.Name = "txtDataCompra1"
        Me.txtDataCompra1.OutputFormat = resources.GetString("txtDataCompra1.OutputFormat")
        Me.txtDataCompra1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtDataCompra1.Text = "txtDataCompra1"
        Me.txtDataCompra1.Top = 0.0!
        Me.txtDataCompra1.Width = 0.6350396!
        '
        'txtCodNomeFornecedor1
        '
        Me.txtCodNomeFornecedor1.DataField = "CodNomeFornecedor"
        Me.txtCodNomeFornecedor1.Height = 0.2!
        Me.txtCodNomeFornecedor1.Left = 2.677165!
        Me.txtCodNomeFornecedor1.Name = "txtCodNomeFornecedor1"
        Me.txtCodNomeFornecedor1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCodNomeFornecedor1.Text = "txtCodNomeFornecedor1"
        Me.txtCodNomeFornecedor1.Top = 0.0!
        Me.txtCodNomeFornecedor1.Width = 3.364173!
        '
        'txtCFOP1
        '
        Me.txtCFOP1.DataField = "CFOP"
        Me.txtCFOP1.Height = 0.2!
        Me.txtCFOP1.Left = 6.093701!
        Me.txtCFOP1.Name = "txtCFOP1"
        Me.txtCFOP1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCFOP1.Text = "txtCFOP1"
        Me.txtCFOP1.Top = 0.008267717!
        Me.txtCFOP1.Width = 0.3244095!
        '
        'txtValorCompra1
        '
        Me.txtValorCompra1.DataField = "ValorCompra"
        Me.txtValorCompra1.Height = 0.2!
        Me.txtValorCompra1.Left = 6.458268!
        Me.txtValorCompra1.Name = "txtValorCompra1"
        Me.txtValorCompra1.OutputFormat = resources.GetString("txtValorCompra1.OutputFormat")
        Me.txtValorCompra1.Style = "font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.txtValorCompra1.Text = "txtValorCompra1"
        Me.txtValorCompra1.Top = 0.0!
        Me.txtValorCompra1.Width = 0.8645663!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1, Me.Line4, Me.Label10})
        Me.PageFooter1.Height = 0.246063!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportInfo1
        '
        Me.ReportInfo1.FormatString = "Pag.: {PageNumber} de {PageCount} : {RunDateTime}"
        Me.ReportInfo1.Height = 0.2214567!
        Me.ReportInfo1.Left = 4.404529!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: Black; font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align:" & _
            " right; ddo-char-set: 1"
        Me.ReportInfo1.Top = 0.0246063!
        Me.ReportInfo1.Width = 2.780513!
        '
        'Line4
        '
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 7.185041!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 7.185041!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.0!
        '
        'Label10
        '
        Me.Label10.Height = 0.1230315!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0492126!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 6pt"
        Me.Label10.Text = "Sistemas Up"
        Me.Label10.Top = 0.0246063!
        Me.Label10.Width = 1.008858!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.periodo, Me.txtNomeFantasia1})
        Me.ReportHeader1.Height = 0.5833334!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'periodo
        '
        Me.periodo.Height = 0.2!
        Me.periodo.HyperLink = Nothing
        Me.periodo.Left = 0.0!
        Me.periodo.Name = "periodo"
        Me.periodo.Style = "font-weight: bold; ddo-char-set: 1"
        Me.periodo.Text = "Relatório de Nota Fiscais no Período de 01/01/2012 a 30/01/2012"
        Me.periodo.Top = 0.3334646!
        Me.periodo.Width = 5.197638!
        '
        'txtNomeFantasia1
        '
        Me.txtNomeFantasia1.DataField = "NomeFantasia"
        Me.txtNomeFantasia1.Height = 0.2!
        Me.txtNomeFantasia1.Left = 0.0!
        Me.txtNomeFantasia1.Name = "txtNomeFantasia1"
        Me.txtNomeFantasia1.Style = "font-size: 12pt; font-weight: bold; ddo-char-set: 1"
        Me.txtNomeFantasia1.Text = "txtNomeFantasia1"
        Me.txtNomeFantasia1.Top = 0.05196851!
        Me.txtNomeFantasia1.Width = 5.197638!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.Label8, Me.Line1})
        Me.ReportFooter1.Height = 0.25!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "ValorCompra"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 6.093701!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.TextBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.02952756!
        Me.TextBox1.Width = 1.229134!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.937402!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-weight: bold; ddo-char-set: 1"
        Me.Label8.Text = "Total Geral.:"
        Me.Label8.Top = 0.02952756!
        Me.Label8.Width = 1.0!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.08385827!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 7.199606!
        Me.Line1.X1 = 0.08385827!
        Me.Line1.X2 = 7.283465!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
        '
        'RelCompraSintetico
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\Dados\CD\upDados.mdb;Persist Secu" & _
            "rity Info=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 7.375!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: ""Tahoma""; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; font-style: italic; font-family: ""Tahoma""; dd" & _
                    "o-char-set: 204", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 204", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompraInterno1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotaFiscal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataLançamento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataCompra1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodNomeFornecedor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCFOP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorCompra1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeFantasia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCompraInterno1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNotaFiscal1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDataLançamento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDataCompra1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodNomeFornecedor1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCFOP1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorCompra1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Private WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtNomeFantasia1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Public WithEvents periodo As DataDynamics.ActiveReports.Label
End Class
