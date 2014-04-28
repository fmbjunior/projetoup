<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CilindroA 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CilindroA))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.lblempresa = New DataDynamics.ActiveReports.Label()
        Me.lbldescricao = New DataDynamics.ActiveReports.Label()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.txtSomaDeLocQtde1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtLocCodigoProduto1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtDescrição1 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        CType(Me.lblempresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbldescricao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSomaDeLocQtde1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocCodigoProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblempresa, Me.lbldescricao, Me.Line2, Me.Label4, Me.Label7, Me.Label2})
        Me.PageHeader1.Height = 0.8874018!
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
        Me.lblempresa.Width = 6.166931!
        '
        'lbldescricao
        '
        Me.lbldescricao.Height = 0.2102362!
        Me.lbldescricao.HyperLink = Nothing
        Me.lbldescricao.Left = 0.04015748!
        Me.lbldescricao.Name = "lbldescricao"
        Me.lbldescricao.Style = "font-family: Tahoma; font-size: 10pt; font-weight: bold; ddo-char-set: 1"
        Me.lbldescricao.Text = "Cilindros Locados"
        Me.lbldescricao.Top = 0.3452756!
        Me.lbldescricao.Width = 6.166931!
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
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.479134!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 1"
        Me.Label4.Text = "Nome Cliente"
        Me.Label4.Top = 0.6669292!
        Me.Label4.Width = 3.979134!
        '
        'Label7
        '
        Me.Label7.Height = 0.1897638!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.554725!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: Tahoma; font-size: 8pt; text-align: right; ddo-char-set: 1"
        Me.Label7.Text = "Qtde"
        Me.Label7.Top = 0.6669292!
        Me.Label7.Width = 0.7385834!
        '
        'Label2
        '
        Me.Label2.Height = 0.1897638!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.04015779!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: Tahoma; font-size: 8pt; text-align: left; ddo-char-set: 1"
        Me.Label2.Text = "Cod./Desc. Produto"
        Me.Label2.Top = 0.6669292!
        Me.Label2.Width = 1.387008!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSomaDeLocQtde1, Me.txtNome1})
        Me.Detail1.Height = 0.2188976!
        Me.Detail1.Name = "Detail1"
        '
        'txtSomaDeLocQtde1
        '
        Me.txtSomaDeLocQtde1.DataField = "SomaDeLocQtde"
        Me.txtSomaDeLocQtde1.Height = 0.2!
        Me.txtSomaDeLocQtde1.Left = 5.614567!
        Me.txtSomaDeLocQtde1.Name = "txtSomaDeLocQtde1"
        Me.txtSomaDeLocQtde1.Style = "font-family: Tahoma; font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtSomaDeLocQtde1.Text = "txtSomaDeLocQtde1"
        Me.txtSomaDeLocQtde1.Top = 0.0!
        Me.txtSomaDeLocQtde1.Width = 0.7291343!
        '
        'txtNome1
        '
        Me.txtNome1.DataField = "Nome"
        Me.txtNome1.Height = 0.2!
        Me.txtNome1.Left = 1.479134!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-family: Tahoma; font-size: 9pt; ddo-char-set: 1"
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.0!
        Me.txtNome1.Width = 4.062205!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtLocCodigoProduto1, Me.txtDescrição1})
        Me.GroupHeader1.DataField = "LocCodigoProduto"
        Me.GroupHeader1.Height = 0.2291667!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'txtLocCodigoProduto1
        '
        Me.txtLocCodigoProduto1.DataField = "LocCodigoProduto"
        Me.txtLocCodigoProduto1.Height = 0.1897638!
        Me.txtLocCodigoProduto1.Left = 0.07322835!
        Me.txtLocCodigoProduto1.Name = "txtLocCodigoProduto1"
        Me.txtLocCodigoProduto1.Style = "font-family: Tahoma; font-weight: bold; ddo-char-set: 1"
        Me.txtLocCodigoProduto1.Text = "txtLocCodigoProduto1"
        Me.txtLocCodigoProduto1.Top = 0.03070866!
        Me.txtLocCodigoProduto1.Width = 0.5425197!
        '
        'txtDescrição1
        '
        Me.txtDescrição1.DataField = "Descrição"
        Me.txtDescrição1.Height = 0.2!
        Me.txtDescrição1.Left = 0.6669292!
        Me.txtDescrição1.Name = "txtDescrição1"
        Me.txtDescrição1.Style = "font-family: Tahoma; font-weight: bold; ddo-char-set: 1"
        Me.txtDescrição1.Text = "txtDescrição1"
        Me.txtDescrição1.Top = 0.02913386!
        Me.txtDescrição1.Width = 4.98937!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.Label1, Me.Line1})
        Me.GroupFooter1.Height = 0.25!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "SomaDeLocQtde"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 5.614567!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "font-family: Tahoma; font-size: 9pt; font-weight: bold; text-align: right; ddo-ch" & _
            "ar-set: 1"
        Me.TextBox1.SummaryGroup = "GroupHeader1"
        Me.TextBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.03976378!
        Me.TextBox1.Width = 0.7291341!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.843701!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: Tahoma; font-size: 9pt; font-weight: bold; text-align: right; ddo-ch" & _
            "ar-set: 1"
        Me.Label1.Text = "Total Locado:"
        Me.Label1.Top = 0.02952756!
        Me.Label1.Width = 1.614567!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.009055119!
        Me.Line1.Width = 6.343701!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 6.343701!
        Me.Line1.Y1 = 0.009055119!
        Me.Line1.Y2 = 0.009055119!
        '
        'CilindroA
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\Dados\oxigran\upDados.mdb;Persist" & _
            " Security Info=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Left = 0.7874016!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
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
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSomaDeLocQtde1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocCodigoProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtSomaDeLocQtde1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents txtLocCodigoProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescrição1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents lbldescricao As DataDynamics.ActiveReports.Label
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Public WithEvents lblempresa As DataDynamics.ActiveReports.Label
End Class 
