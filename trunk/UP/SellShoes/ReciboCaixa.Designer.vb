<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReciboCaixa 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReciboCaixa))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.txtDataLancamento1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtFavorecido1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHistorico1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.txtValorDocumento1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.txtId1 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataLancamento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFavorecido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHistorico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1})
        Me.PageHeader1.Height = 0.6145834!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.Label1.Height = 0.4602362!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: Tahoma; font-size: 24pt; font-weight: bold; text-align: center; ddo-" & _
            "char-set: 1"
        Me.Label1.Text = "RECIBO DO CAIXA"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 6.364567!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDataLancamento1, Me.txtFavorecido1, Me.txtHistorico1, Me.Label2, Me.Label3, Me.Label4, Me.txtValorDocumento1, Me.Label5, Me.Label6, Me.txtId1})
        Me.Detail1.Height = 2.645833!
        Me.Detail1.Name = "Detail1"
        '
        'txtDataLancamento1
        '
        Me.txtDataLancamento1.DataField = "DataLancamento"
        Me.txtDataLancamento1.Height = 0.2728347!
        Me.txtDataLancamento1.Left = 1.72874!
        Me.txtDataLancamento1.Name = "txtDataLancamento1"
        Me.txtDataLancamento1.OutputFormat = resources.GetString("txtDataLancamento1.OutputFormat")
        Me.txtDataLancamento1.Style = "font-family: Comic Sans MS; font-size: 10pt; font-weight: normal; ddo-char-set: 1" & _
            ""
        Me.txtDataLancamento1.Text = "txtDataLancamento1"
        Me.txtDataLancamento1.Top = 0.1043307!
        Me.txtDataLancamento1.Width = 1.792126!
        '
        'txtFavorecido1
        '
        Me.txtFavorecido1.DataField = "Favorecido"
        Me.txtFavorecido1.Height = 0.2!
        Me.txtFavorecido1.Left = 1.72874!
        Me.txtFavorecido1.Name = "txtFavorecido1"
        Me.txtFavorecido1.Style = "font-family: Comic Sans MS; font-size: 10pt; font-weight: normal; ddo-char-set: 1" & _
            ""
        Me.txtFavorecido1.Text = "txtFavorecido1"
        Me.txtFavorecido1.Top = 0.5011811!
        Me.txtFavorecido1.Width = 4.551969!
        '
        'txtHistorico1
        '
        Me.txtHistorico1.DataField = "Historico"
        Me.txtHistorico1.Height = 0.6169292!
        Me.txtHistorico1.Left = 1.72874!
        Me.txtHistorico1.Name = "txtHistorico1"
        Me.txtHistorico1.Style = "font-family: Comic Sans MS; font-size: 10pt; font-weight: normal; ddo-char-set: 1" & _
            ""
        Me.txtHistorico1.Text = "txtHistorico1"
        Me.txtHistorico1.Top = 0.8129921!
        Me.txtHistorico1.Width = 4.551969!
        '
        'Label2
        '
        Me.Label2.Height = 0.2728347!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.04133858!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: Comic Sans MS; font-size: 10pt; font-weight: normal; ddo-char-set: 1" & _
            ""
        Me.Label2.Text = "Data lançamento"
        Me.Label2.Top = 0.1043307!
        Me.Label2.Width = 1.562205!
        '
        'Label3
        '
        Me.Label3.Height = 0.1999999!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.04133847!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: Comic Sans MS; font-size: 10pt; font-weight: normal; ddo-char-set: 1" & _
            ""
        Me.Label3.Text = "Favorecido"
        Me.Label3.Top = 0.5011811!
        Me.Label3.Width = 1.562205!
        '
        'Label4
        '
        Me.Label4.Height = 0.2417323!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.04133847!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: Comic Sans MS; font-size: 10pt; font-weight: normal; ddo-char-set: 1" & _
            ""
        Me.Label4.Text = "Histórico"
        Me.Label4.Top = 0.8129921!
        Me.Label4.Width = 1.562205!
        '
        'txtValorDocumento1
        '
        Me.txtValorDocumento1.DataField = "ValorDocumento"
        Me.txtValorDocumento1.Height = 0.2728347!
        Me.txtValorDocumento1.Left = 4.875197!
        Me.txtValorDocumento1.Name = "txtValorDocumento1"
        Me.txtValorDocumento1.OutputFormat = resources.GetString("txtValorDocumento1.OutputFormat")
        Me.txtValorDocumento1.Style = "font-family: Comic Sans MS; font-size: 10pt; font-weight: bold; text-align: right" & _
            "; ddo-char-set: 1"
        Me.txtValorDocumento1.Text = "txtValorDocumento1"
        Me.txtValorDocumento1.Top = 0.1043307!
        Me.txtValorDocumento1.Width = 1.48937!
        '
        'Label5
        '
        Me.Label5.Height = 0.2728347!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.979134!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: Comic Sans MS; font-size: 10pt; font-weight: normal; text-align: rig" & _
            "ht; ddo-char-set: 1"
        Me.Label5.Text = "Valor"
        Me.Label5.Top = 0.1043307!
        Me.Label5.Width = 0.8224411!
        '
        'Label6
        '
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Height = 0.2417324!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 3.448031!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: Comic Sans MS; font-size: 10pt; text-align: center; ddo-char-set: 1"
        Me.Label6.Text = "Ass. Responsável"
        Me.Label6.Top = 2.198426!
        Me.Label6.Width = 2.916535!
        '
        'txtId1
        '
        Me.txtId1.DataField = "=""Identificador.: "" +Id"
        Me.txtId1.Height = 0.2!
        Me.txtId1.Left = 0.04133858!
        Me.txtId1.Name = "txtId1"
        Me.txtId1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtId1.Text = Nothing
        Me.txtId1.Top = 2.240157!
        Me.txtId1.Width = 1.322835!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line1})
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0519685!
        Me.Line1.Width = 6.364567!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 6.364567!
        Me.Line1.Y1 = 0.0519685!
        Me.Line1.Y2 = 0.0519685!
        '
        'ReciboCaixa
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Projetos dblsistemas\Prj Up\Dados" & _
            "\CD\upDados.mdb;Persist Security Info=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        'Me.PageSettings.DefaultPaperSize = True
        'Me.PageSettings.Margins.Left = 0.5905512!
        'Me.PageSettings.Margins.Right = 0.5905512!
        'Me.PageSettings.Margins.Top = 0.3937007!
        'Me.PageSettings.PaperHeight = 5.511811!
        'Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        'Me.PageSettings.PaperName = "Custom paper"
        'Me.PageSettings.PaperWidth = 8.5!
        'Me.PrintWidth = 6.46875!
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.1968504!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.1968504!
        Me.PageSettings.Margins.Top = 0.1968504!
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 7.58883!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataLancamento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFavorecido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHistorico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtDataLancamento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFavorecido1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtHistorico1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtValorDocumento1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtId1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
End Class 
