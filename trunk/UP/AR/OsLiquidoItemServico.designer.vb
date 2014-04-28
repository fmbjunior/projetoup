<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OsLiquidoItemServico
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OsLiquidoItemServico))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.txtServ_Codigo = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.txtField11 = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader()
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter()
        CType(Me.txtServ_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtField11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtServ_Codigo, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6})
        Me.Detail1.Height = 0.1968504!
        Me.Detail1.Name = "Detail1"
        '
        'txtServ_Codigo
        '
        Me.txtServ_Codigo.DataField = "Serv_Codigo"
        Me.txtServ_Codigo.Height = 0.1968504!
        Me.txtServ_Codigo.Left = 0.0!
        Me.txtServ_Codigo.Name = "txtServ_Codigo"
        Me.txtServ_Codigo.Text = "txtServ_Codigo"
        Me.txtServ_Codigo.Top = 0.0!
        Me.txtServ_Codigo.Width = 0.5659449!
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = False
        Me.TextBox2.DataField = "Serv_Descricao"
        Me.TextBox2.Height = 0.1968504!
        Me.TextBox2.Left = 0.5905512!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Text = "txtServ_Descricao"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 3.262713!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "Funcionario"
        Me.TextBox3.Height = 0.1968504!
        Me.TextBox3.Left = 3.954561!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Text = "txtFuncionario"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.3198819!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "Qtd"
        Me.TextBox4.Height = 0.1968504!
        Me.TextBox4.Left = 4.436106!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "text-align: right"
        Me.TextBox4.Text = "txtqtd"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.8612204!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "UnitarioL"
        Me.TextBox5.Height = 0.1968504!
        Me.TextBox5.Left = 5.370408!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "text-align: right"
        Me.TextBox5.Text = "txtValorUnitario"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.8366141!
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "TotalServico"
        Me.TextBox6.Height = 0.1968504!
        Me.TextBox6.Left = 6.296178!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "text-align: right"
        Me.TextBox6.Text = "txtTotalServico"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 1.058071!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Line1})
        Me.GroupHeader1.Height = 0.1979167!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0492126!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-weight: bold; ddo-char-set: 1"
        Me.Label2.Text = "Serviço Executado"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 3.824886!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.958333!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-weight: bold; ddo-char-set: 1"
        Me.Label3.Text = "Func."
        Me.Label3.Top = 0.0!
        Me.Label3.Width = 0.3444883!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.436106!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label4.Text = "Qtde"
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 0.8622047!
        '
        'Label5
        '
        Me.Label5.Height = 0.1968504!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 5.370408!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label5.Text = "Vlr. Unit"
        Me.Label5.Top = 0.0!
        Me.Label5.Width = 0.8366141!
        '
        'Label6
        '
        Me.Label6.Height = 0.1968504!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 6.299213!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label6.Text = "Total Serviço"
        Me.Label6.Top = 0.0!
        Me.Label6.Width = 1.033465!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0492126!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 7.627954!
        Me.Line1.X1 = 0.0492126!
        Me.Line1.X2 = 7.677166!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label8, Me.txtField11})
        Me.GroupFooter1.Height = 0.2!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label8
        '
        Me.Label8.Height = 0.1968504!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.939058!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label8.Text = "Sub-Total Serviço.:"
        Me.Label8.Top = 0.0!
        Me.Label8.Width = 1.304134!
        '
        'txtField11
        '
        Me.txtField11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtField11.DataField = "totalServico"
        Me.txtField11.Height = 0.2!
        Me.txtField11.Left = 6.366224!
        Me.txtField11.Name = "txtField11"
        Me.txtField11.OutputFormat = resources.GetString("txtField11.OutputFormat")
        Me.txtField11.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.txtField11.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtField11.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtField11.Text = "txtField11"
        Me.txtField11.Top = 0.0!
        Me.txtField11.Width = 1.0!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.2395833!
        Me.ReportHeader1.Name = "ReportHeader1"
        Me.ReportHeader1.Visible = False
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.25!
        Me.ReportFooter1.Name = "ReportFooter1"
        Me.ReportFooter1.Visible = False
        '
        'OsLiquidoItemServico
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.449066!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; color: Black; fon" & _
                    "t-family: ""Tahoma""; ddo-char-set: 204; font-size: 9pt", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; font-style: italic; font-family: ""Tahoma""; dd" & _
                    "o-char-set: 204", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 204", "Heading3", "Normal"))
        CType(Me.txtServ_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtField11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtServ_Codigo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtField11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
End Class
