<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelServicoExecutadoGrupo 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelServicoExecutadoGrupo))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Periodo = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.txtgDescricao1 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.T1 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.subrlt = New DataDynamics.ActiveReports.SubReport
        CType(Me.Periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgDescricao1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Periodo, Me.Line2, Me.Label3, Me.Label4, Me.Label8})
        Me.PageHeader1.Height = 0.7291667!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Periodo
        '
        Me.Periodo.Border.BottomColor = System.Drawing.Color.Black
        Me.Periodo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Periodo.Border.LeftColor = System.Drawing.Color.Black
        Me.Periodo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Periodo.Border.RightColor = System.Drawing.Color.Black
        Me.Periodo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Periodo.Border.TopColor = System.Drawing.Color.Black
        Me.Periodo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Periodo.ClassName = "Heading1"
        Me.Periodo.Height = 0.1968504!
        Me.Periodo.Left = 0.0492126!
        Me.Periodo.Name = "Periodo"
        Me.Periodo.Style = "font-size: 10pt; font-family: Tahoma; "
        Me.Periodo.Text = "Serviços Executados no Período"
        Me.Periodo.Top = 0.0984252!
        Me.Periodo.Width = 5.019685!
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
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.Line2.Height = 0.008284122!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.3854167!
        Me.Line2.Width = 7.086615!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.086615!
        Me.Line2.Y1 = 0.3854167!
        Me.Line2.Y2 = 0.3937008!
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
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0246063!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label3.Text = "Cod.Serv"
        Me.Label3.Top = 0.4675197!
        Me.Label3.Width = 0.6151575!
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
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.6643701!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label4.Text = "Descrição Serviço"
        Me.Label4.Top = 0.4675197!
        Me.Label4.Width = 2.509843!
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
        Me.Label8.Height = 0.1968504!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 6.25!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label8.Text = "Total Serviço"
        Me.Label8.Top = 0.4375!
        Me.Label8.Width = 0.8366141!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox8, Me.txtNome1})
        Me.Detail1.Height = 0.1968504!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.DataField = "SomaDeTotalservico"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 5.1875!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "text-align: right; font-weight: normal; font-size: 9pt; font-family: Tahoma; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 1.9375!
        '
        'txtNome1
        '
        Me.txtNome1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNome1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNome1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNome1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNome1.Border.RightColor = System.Drawing.Color.Black
        Me.txtNome1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNome1.Border.TopColor = System.Drawing.Color.Black
        Me.txtNome1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNome1.DataField = "Nome"
        Me.txtNome1.Height = 0.1875!
        Me.txtNome1.Left = 1.8125!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-size: 9pt; font-family: Tahoma; "
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.0!
        Me.txtNome1.Width = 3.3125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1, Me.Line4, Me.Label10})
        Me.PageFooter1.Height = 0.2952756!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportInfo1
        '
        Me.ReportInfo1.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.FormatString = "Pag.: {PageNumber} de {PageCount} : {RunDateTime}"
        Me.ReportInfo1.Height = 0.2214567!
        Me.ReportInfo1.Left = 4.404528!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: Black; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8" & _
            "pt; font-family: Tahoma; "
        Me.ReportInfo1.Top = 0.0246063!
        Me.ReportInfo1.Width = 2.780512!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 7.18504!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 7.18504!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.0!
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
        Me.Label10.Height = 0.1230315!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0492126!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 6pt; "
        Me.Label10.Text = "Sistemas Up"
        Me.Label10.Top = 0.0246063!
        Me.Label10.Width = 1.008858!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.Line3, Me.txtgDescricao1})
        Me.GroupHeader1.DataField = "GrupoServico"
        Me.GroupHeader1.Height = 0.3541667!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.TextBox1.DataField = "GrupoServico"
        Me.TextBox1.Height = 0.1968504!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-weight: bold; font-size: 9pt; font-family: Tahoma; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.125!
        Me.TextBox1.Width = 0.5659449!
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
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0492126!
        Me.Line3.Width = 7.086615!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.086615!
        Me.Line3.Y1 = 0.0492126!
        Me.Line3.Y2 = 0.0492126!
        '
        'txtgDescricao1
        '
        Me.txtgDescricao1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtgDescricao1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtgDescricao1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtgDescricao1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtgDescricao1.Border.RightColor = System.Drawing.Color.Black
        Me.txtgDescricao1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtgDescricao1.Border.TopColor = System.Drawing.Color.Black
        Me.txtgDescricao1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtgDescricao1.DataField = "gDescricao"
        Me.txtgDescricao1.Height = 0.1968504!
        Me.txtgDescricao1.Left = 0.625!
        Me.txtgDescricao1.Name = "txtgDescricao1"
        Me.txtgDescricao1.Style = "font-weight: bold; font-size: 9pt; font-family: Tahoma; "
        Me.txtgDescricao1.Text = "txtgDescricao1"
        Me.txtgDescricao1.Top = 0.125!
        Me.txtgDescricao1.Width = 3.641732!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox9, Me.Label1})
        Me.GroupFooter1.Height = 0.25!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.DataField = "SomaDeTotalservico"
        Me.TextBox9.Height = 0.1968504!
        Me.TextBox9.Left = 6.102362!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox9.SummaryGroup = "GroupHeader1"
        Me.TextBox9.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox9.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0246063!
        Me.TextBox9.Width = 1.033465!
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
        Me.Label1.Left = 4.822834!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label1.Text = "Sub Total"
        Me.Label1.Top = 0.0246063!
        Me.Label1.Width = 1.254921!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.T1, Me.Line1})
        Me.ReportHeader1.Height = 0.5104167!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'T1
        '
        Me.T1.Border.BottomColor = System.Drawing.Color.Black
        Me.T1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.T1.Border.LeftColor = System.Drawing.Color.Black
        Me.T1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.T1.Border.RightColor = System.Drawing.Color.Black
        Me.T1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.T1.Border.TopColor = System.Drawing.Color.Black
        Me.T1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.T1.ClassName = "Heading1"
        Me.T1.Height = 0.3125!
        Me.T1.Left = 0.0625!
        Me.T1.Name = "T1"
        Me.T1.Style = "font-family: Tahoma; "
        Me.T1.Text = Nothing
        Me.T1.Top = 0.0625!
        Me.T1.Width = 6.6875!
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
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.492126!
        Me.Line1.Width = 7.18504!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 7.18504!
        Me.Line1.Y1 = 0.492126!
        Me.Line1.Y2 = 0.492126!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label9, Me.TextBox10, Me.subrlt})
        Me.ReportFooter1.Height = 1.375!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Label9.Height = 0.1968504!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 4.822834!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label9.Text = "Total Geral"
        Me.Label9.Top = 0.0246063!
        Me.Label9.Width = 1.254921!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.DataField = "SomaDeTotalservico"
        Me.TextBox10.Height = 0.1968504!
        Me.TextBox10.Left = 6.102362!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "text-align: right; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox10.SummaryGroup = "GroupHeader1"
        Me.TextBox10.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0246063!
        Me.TextBox10.Width = 1.033465!
        '
        'subrlt
        '
        Me.subrlt.Border.BottomColor = System.Drawing.Color.Black
        Me.subrlt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.subrlt.Border.LeftColor = System.Drawing.Color.Black
        Me.subrlt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subrlt.Border.RightColor = System.Drawing.Color.Black
        Me.subrlt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subrlt.Border.TopColor = System.Drawing.Color.Black
        Me.subrlt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.subrlt.CloseBorder = False
        Me.subrlt.Height = 1.0!
        Me.subrlt.Left = 0.0625!
        Me.subrlt.Name = "subrlt"
        Me.subrlt.Report = Nothing
        Me.subrlt.ReportName = "SubReport1"
        Me.subrlt.Top = 0.375!
        Me.subrlt.Width = 7.0625!
        '
        'RelServicoExecutadoGrupo
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Prj Up\Dados\retificams\upDados.m" & _
            "db;Jet oledb:database password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.25!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.Periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgDescricao1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Periodo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents T1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtgDescricao1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents subrlt As DataDynamics.ActiveReports.SubReport
End Class
