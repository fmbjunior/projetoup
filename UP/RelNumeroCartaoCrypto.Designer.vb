<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelNumeroCartaoCrypto 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RelNumeroCartaoCrypto))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.NumeroCartao = New DataDynamics.ActiveReports.TextBox()
        Me.CodBarra = New DataDynamics.ActiveReports.Barcode()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.NumeroCartao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 0.02083333!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.NumeroCartao, Me.CodBarra})
        Me.Detail1.Height = 1.322917!
        Me.Detail1.Name = "Detail1"
        '
        'NumeroCartao
        '
        Me.NumeroCartao.Height = 0.3444882!
        Me.NumeroCartao.Left = 0.6397638!
        Me.NumeroCartao.Name = "NumeroCartao"
        Me.NumeroCartao.Style = "color: Transparent; font-family: Tahoma; font-size: 14pt; font-weight: bold"
        Me.NumeroCartao.Text = "TextBox1"
        Me.NumeroCartao.Top = 0.2952756!
        Me.NumeroCartao.Width = 2.978236!
        '
        'CodBarra
        '
        Me.CodBarra.Font = New System.Drawing.Font("Arial", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodBarra.Height = 0.4088111!
        Me.CodBarra.Left = 0.6151575!
        Me.CodBarra.Name = "CodBarra"
        Me.CodBarra.Style = DataDynamics.ActiveReports.BarCodeStyle.Code_128_B
        Me.CodBarra.Top = 0.738189!
        Me.CodBarra.Width = 1.765842!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'RelNumeroCartaoCrypto
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.1968504!
        Me.PageSettings.Margins.Left = 0.1968504!
        Me.PageSettings.Margins.Right = 0.1968504!
        Me.PageSettings.Margins.Top = 0.1968504!
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 4.989583!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.NumeroCartao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents NumeroCartao As DataDynamics.ActiveReports.TextBox
    Friend WithEvents CodBarra As DataDynamics.ActiveReports.Barcode
End Class 
