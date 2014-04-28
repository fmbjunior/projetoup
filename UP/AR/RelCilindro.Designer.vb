<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelCilindro 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelCilindro))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.lblempresa = New DataDynamics.ActiveReports.Label()
        Me.lbldescricao = New DataDynamics.ActiveReports.Label()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.txtLocCodigoProduto1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtDescrição1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtLocQtde1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtLocData1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtLocControle1 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtLocCodigoCliente1 = New DataDynamics.ActiveReports.TextBox()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.lblempresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbldescricao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocCodigoProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocQtde1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocControle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocCodigoCliente1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblempresa, Me.lbldescricao, Me.Line2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7})
        Me.PageHeader1.Height = 0.9375001!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblempresa
        '
        Me.lblempresa.Height = 0.2519685!
        Me.lblempresa.HyperLink = Nothing
        Me.lblempresa.Left = 0.04015748!
        Me.lblempresa.Name = "lblempresa"
        Me.lblempresa.Style = "font-family: Tahoma; font-size: 12pt; font-weight: bold; ddo-char-set: 1"
        Me.lblempresa.Text = "EMPRESA"
        Me.lblempresa.Top = 0.0!
        Me.lblempresa.Width = 6.16693!
        '
        'lbldescricao
        '
        Me.lbldescricao.Height = 0.2102362!
        Me.lbldescricao.HyperLink = Nothing
        Me.lbldescricao.Left = 0.04015748!
        Me.lbldescricao.Name = "lbldescricao"
        Me.lbldescricao.Style = "font-family: Tahoma; font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.lbldescricao.Text = "Movimentação de Cilindros"
        Me.lbldescricao.Top = 0.3452756!
        Me.lbldescricao.Width = 6.16693!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.6291339!
        Me.Line2.Width = 6.436693!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 6.436693!
        Me.Line2.Y1 = 0.6291339!
        Me.Line2.Y2 = 0.6291339!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.02007874!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 1"
        Me.Label3.Text = "Cód. Prod"
        Me.Label3.Top = 0.6874016!
        Me.Label3.Width = 0.6047244!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.6870079!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 1"
        Me.Label4.Text = "Descrição do Produto"
        Me.Label4.Top = 0.6874017!
        Me.Label4.Width = 2.792126!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.989764!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: Tahoma; font-size: 8pt; text-align: center; ddo-char-set: 1"
        Me.Label5.Text = "Qtde"
        Me.Label5.Top = 0.6874017!
        Me.Label5.Width = 0.833071!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.875985!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: Tahoma; font-size: 8pt; text-align: center; ddo-char-set: 1"
        Me.Label6.Text = "Dta. Locação"
        Me.Label6.Top = 0.6874017!
        Me.Label6.Width = 0.7811017!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.708268!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: Tahoma; font-size: 8pt; text-align: center; ddo-char-set: 1"
        Me.Label7.Text = "Nº Controle"
        Me.Label7.Top = 0.6874017!
        Me.Label7.Width = 0.7385831!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtLocCodigoProduto1, Me.txtDescrição1, Me.txtLocQtde1, Me.txtLocData1, Me.txtLocControle1})
        Me.Detail1.Height = 0.2083334!
        Me.Detail1.Name = "Detail1"
        '
        'txtLocCodigoProduto1
        '
        Me.txtLocCodigoProduto1.DataField = "LocCodigoProduto"
        Me.txtLocCodigoProduto1.Height = 0.2!
        Me.txtLocCodigoProduto1.Left = 0.0!
        Me.txtLocCodigoProduto1.Name = "txtLocCodigoProduto1"
        Me.txtLocCodigoProduto1.Style = "font-family: Tahoma; font-size: 9pt; ddo-char-set: 1"
        Me.txtLocCodigoProduto1.Text = "txtLocCodigoProduto1"
        Me.txtLocCodigoProduto1.Top = 0.0!
        Me.txtLocCodigoProduto1.Width = 0.625!
        '
        'txtDescrição1
        '
        Me.txtDescrição1.CanGrow = False
        Me.txtDescrição1.DataField = "Descrição"
        Me.txtDescrição1.Height = 0.2!
        Me.txtDescrição1.Left = 0.687!
        Me.txtDescrição1.Name = "txtDescrição1"
        Me.txtDescrição1.Style = "font-family: Tahoma; font-size: 9pt; ddo-char-set: 1"
        Me.txtDescrição1.Text = "txtDescrição1"
        Me.txtDescrição1.Top = 0.0!
        Me.txtDescrição1.Width = 3.250402!
        '
        'txtLocQtde1
        '
        Me.txtLocQtde1.DataField = "LocQtde"
        Me.txtLocQtde1.Height = 0.2!
        Me.txtLocQtde1.Left = 3.989764!
        Me.txtLocQtde1.Name = "txtLocQtde1"
        Me.txtLocQtde1.OutputFormat = resources.GetString("txtLocQtde1.OutputFormat")
        Me.txtLocQtde1.Style = "font-family: Tahoma; font-size: 9pt; ddo-char-set: 1"
        Me.txtLocQtde1.Text = "txtLocQtde1"
        Me.txtLocQtde1.Top = 0.0!
        Me.txtLocQtde1.Width = 0.833071!
        '
        'txtLocData1
        '
        Me.txtLocData1.DataField = "LocData"
        Me.txtLocData1.Height = 0.2!
        Me.txtLocData1.Left = 4.875985!
        Me.txtLocData1.Name = "txtLocData1"
        Me.txtLocData1.OutputFormat = resources.GetString("txtLocData1.OutputFormat")
        Me.txtLocData1.Style = "font-family: Tahoma; font-size: 9pt; ddo-char-set: 1"
        Me.txtLocData1.Text = "txtLocData1"
        Me.txtLocData1.Top = 0.0!
        Me.txtLocData1.Width = 0.7811022!
        '
        'txtLocControle1
        '
        Me.txtLocControle1.DataField = "LocControle"
        Me.txtLocControle1.Height = 0.2!
        Me.txtLocControle1.Left = 5.708268!
        Me.txtLocControle1.Name = "txtLocControle1"
        Me.txtLocControle1.Style = "font-family: Tahoma; font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.txtLocControle1.Text = "txtLocControle1"
        Me.txtLocControle1.Top = 0.0!
        Me.txtLocControle1.Width = 0.7387319!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNome1, Me.txtLocCodigoCliente1, Me.Line1})
        Me.GroupHeader1.DataField = "LocCodigoCliente"
        Me.GroupHeader1.Height = 0.3958333!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'txtNome1
        '
        Me.txtNome1.DataField = "Nome"
        Me.txtNome1.Height = 0.2!
        Me.txtNome1.Left = 0.625!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-family: Tahoma; font-weight: bold; ddo-char-set: 1"
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.104!
        Me.txtNome1.Width = 3.187!
        '
        'txtLocCodigoCliente1
        '
        Me.txtLocCodigoCliente1.DataField = "LocCodigoCliente"
        Me.txtLocCodigoCliente1.Height = 0.2!
        Me.txtLocCodigoCliente1.Left = 0.04!
        Me.txtLocCodigoCliente1.Name = "txtLocCodigoCliente1"
        Me.txtLocCodigoCliente1.Style = "font-family: Tahoma; font-weight: bold; ddo-char-set: 1"
        Me.txtLocCodigoCliente1.Text = "txtLocCodigoCliente1"
        Me.txtLocCodigoCliente1.Top = 0.104!
        Me.txtLocCodigoCliente1.Width = 0.49!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.02!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.344!
        Me.Line1.Width = 6.436693!
        Me.Line1.X1 = 0.02!
        Me.Line1.X2 = 6.456693!
        Me.Line1.Y1 = 0.344!
        Me.Line1.Y2 = 0.344!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'RelCilindro
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\Dados\oxigran\upDados.mdb;Persist" & _
            " Security Info=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.7874016!
        Me.PageSettings.Margins.Left = 0.7874016!
        Me.PageSettings.Margins.Right = 0.3937007!
        Me.PageSettings.Margins.Top = 0.3937007!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 6.520768!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblempresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbldescricao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocCodigoProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocQtde1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocControle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocCodigoCliente1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtLocCodigoProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescrição1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtLocQtde1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtLocData1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtLocControle1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents lbldescricao As DataDynamics.ActiveReports.Label
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtLocCodigoCliente1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Public WithEvents lblempresa As DataDynamics.ActiveReports.Label
End Class 
