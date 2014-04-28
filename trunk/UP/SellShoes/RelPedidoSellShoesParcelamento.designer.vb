<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelPedidoSellShoesParcelamento 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RelPedidoSellShoesParcelamento))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource()
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.txtDocumento1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtVencimento1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtValorDocumento1 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVencimento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 0.0!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0492126!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold"
        Me.Label1.Text = "Doc"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.8366142!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.9596457!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right"
        Me.Label2.Text = "Valor"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.9350395!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.017717!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right"
        Me.Label3.Text = "Vencimento"
        Me.Label3.Top = 0.0!
        Me.Label3.Width = 0.9842519!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.1968504!
        Me.Line1.Width = 3.100394!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 3.100394!
        Me.Line1.Y1 = 0.1968504!
        Me.Line1.Y2 = 0.1968504!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDocumento1, Me.txtVencimento1, Me.txtValorDocumento1})
        Me.Detail1.Height = 0.2083333!
        Me.Detail1.Name = "Detail1"
        '
        'txtDocumento1
        '
        Me.txtDocumento1.DataField = "Documento"
        Me.txtDocumento1.Height = 0.1968504!
        Me.txtDocumento1.Left = 0.0246063!
        Me.txtDocumento1.Name = "txtDocumento1"
        Me.txtDocumento1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: left"
        Me.txtDocumento1.Text = "txtDocumento1"
        Me.txtDocumento1.Top = 0.0!
        Me.txtDocumento1.Width = 0.8858268!
        '
        'txtVencimento1
        '
        Me.txtVencimento1.DataField = "Vencimento"
        Me.txtVencimento1.Height = 0.2!
        Me.txtVencimento1.Left = 2.042323!
        Me.txtVencimento1.Name = "txtVencimento1"
        Me.txtVencimento1.OutputFormat = resources.GetString("txtVencimento1.OutputFormat")
        Me.txtVencimento1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right"
        Me.txtVencimento1.Text = "txtVencimento1"
        Me.txtVencimento1.Top = 0.0!
        Me.txtVencimento1.Width = 1.0!
        '
        'txtValorDocumento1
        '
        Me.txtValorDocumento1.DataField = "ValorDocumento"
        Me.txtValorDocumento1.Height = 0.1968504!
        Me.txtValorDocumento1.Left = 0.984252!
        Me.txtValorDocumento1.Name = "txtValorDocumento1"
        Me.txtValorDocumento1.OutputFormat = resources.GetString("txtValorDocumento1.OutputFormat")
        Me.txtValorDocumento1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right"
        Me.txtValorDocumento1.Text = "txtValorDocumento1"
        Me.txtValorDocumento1.Top = 0.0!
        Me.txtValorDocumento1.Width = 0.9596457!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Line1})
        Me.ReportHeader1.Height = 0.2291667!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'RelPedidoSellShoesParcelamento
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\DouglasDados\Projetos Vb.Net\Prj " & _
            "Up\Dados\CD\upDados.mdb;Jet oledb:database password=abc"
        OleDBDataSource1.SQL = "SELECT Receber.Documento, Receber.Vencimento, Receber.ValorDocumento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM Recebe" & _
            "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE (((Receber.PedidoProdutos)=2));"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 3.072917!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVencimento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtDocumento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtVencimento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorDocumento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
End Class 
