<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelComissaoFaixaSub 
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
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelComissaoFaixaSub))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtSomaDeValorDocumento1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCarteira1 = New DataDynamics.ActiveReports.TextBox
        Me.Indice = New DataDynamics.ActiveReports.TextBox
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Label1 = New DataDynamics.ActiveReports.Label
        CType(Me.txtSomaDeValorDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCarteira1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Indice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSomaDeValorDocumento1, Me.txtCarteira1})
        Me.Detail1.Height = 0.1979167!
        Me.Detail1.Name = "Detail1"
        '
        'txtSomaDeValorDocumento1
        '
        Me.txtSomaDeValorDocumento1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSomaDeValorDocumento1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeValorDocumento1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSomaDeValorDocumento1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeValorDocumento1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSomaDeValorDocumento1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeValorDocumento1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSomaDeValorDocumento1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeValorDocumento1.DataField = "SomaDeValorDocumento"
        Me.txtSomaDeValorDocumento1.Height = 0.1968504!
        Me.txtSomaDeValorDocumento1.Left = 2.241798!
        Me.txtSomaDeValorDocumento1.Name = "txtSomaDeValorDocumento1"
        Me.txtSomaDeValorDocumento1.OutputFormat = resources.GetString("txtSomaDeValorDocumento1.OutputFormat")
        Me.txtSomaDeValorDocumento1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.txtSomaDeValorDocumento1.Text = "txtSomaDeValorDocumento1"
        Me.txtSomaDeValorDocumento1.Top = 0.0!
        Me.txtSomaDeValorDocumento1.Width = 1.279528!
        '
        'txtCarteira1
        '
        Me.txtCarteira1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCarteira1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCarteira1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCarteira1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCarteira1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCarteira1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCarteira1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCarteira1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCarteira1.DataField = "Carteira"
        Me.txtCarteira1.Height = 0.1968504!
        Me.txtCarteira1.Left = 0.0!
        Me.txtCarteira1.Name = "txtCarteira1"
        Me.txtCarteira1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.txtCarteira1.Text = "txtCarteira1"
        Me.txtCarteira1.Top = 0.0!
        Me.txtCarteira1.Width = 1.614173!
        '
        'Indice
        '
        Me.Indice.Border.BottomColor = System.Drawing.Color.Black
        Me.Indice.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Indice.Border.LeftColor = System.Drawing.Color.Black
        Me.Indice.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Indice.Border.RightColor = System.Drawing.Color.Black
        Me.Indice.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Indice.Border.TopColor = System.Drawing.Color.Black
        Me.Indice.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Indice.Height = 0.1968504!
        Me.Indice.Left = 2.241798!
        Me.Indice.Name = "Indice"
        Me.Indice.OutputFormat = resources.GetString("Indice.OutputFormat")
        Me.Indice.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.Indice.Text = "TextBox1"
        Me.Indice.Top = 0.0!
        Me.Indice.Width = 1.279528!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.01041667!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Indice, Me.Label1})
        Me.ReportFooter1.Height = 0.25!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label1.Text = "Indice"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 1.614173!
        '
        'RelComissaoFaixaSub
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Sistemas -Up\Prj Up\Dados\max\upD" & _
            "ados.mdb;Jet oledb:database password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 3.59375!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtSomaDeValorDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCarteira1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Indice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtSomaDeValorDocumento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCarteira1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Indice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
End Class 
