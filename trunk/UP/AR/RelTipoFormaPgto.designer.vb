<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelTipoFormaPgto 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelTipoFormaPgto))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCodFormaPgto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescrição1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDesconto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtAcrescimo1 = New DataDynamics.ActiveReports.TextBox
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.txtDescricaoTipoPgto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCodigoTipoPgto1 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.T1 = New DataDynamics.ActiveReports.TextBox
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodFormaPgto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcrescimo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescricaoTipoPgto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoTipoPgto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.Label3, Me.Label4, Me.Line1, Me.Label7, Me.Label8})
        Me.PageHeader1.Height = 0.25!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.1181102!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = ""
        Me.Label2.Text = "Cod. Tipo"
        Me.Label2.Top = 0.01394357!
        Me.Label2.Width = 0.7086614!
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
        Me.Label3.Left = 0.8661418!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = ""
        Me.Label3.Text = "Descrição Tipo"
        Me.Label3.Top = 0.01394357!
        Me.Label3.Width = 1.102362!
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
        Me.Label4.Left = 2.125984!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = ""
        Me.Label4.Text = "Plano de Pagamento"
        Me.Label4.Top = 0.01394357!
        Me.Label4.Width = 1.574803!
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
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.2362205!
        Me.Line1.Width = 6.338583!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 6.338583!
        Me.Line1.Y1 = 0.2362205!
        Me.Line1.Y2 = 0.2362205!
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
        Me.Label7.Height = 0.1968504!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.606299!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "text-align: right; "
        Me.Label7.Text = "Desconto"
        Me.Label7.Top = 0.01394357!
        Me.Label7.Width = 0.7086614!
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
        Me.Label8.Left = 5.590551!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "text-align: right; "
        Me.Label8.Text = "Acrescimo"
        Me.Label8.Top = 0.01394357!
        Me.Label8.Width = 0.7086614!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodFormaPgto1, Me.txtDescrição1, Me.txtDesconto1, Me.txtAcrescimo1, Me.Label5, Me.Label6})
        Me.Detail1.Height = 0.2291667!
        Me.Detail1.Name = "Detail1"
        '
        'txtCodFormaPgto1
        '
        Me.txtCodFormaPgto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodFormaPgto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodFormaPgto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodFormaPgto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodFormaPgto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodFormaPgto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodFormaPgto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodFormaPgto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodFormaPgto1.DataField = "CodFormaPgto"
        Me.txtCodFormaPgto1.Height = 0.1968504!
        Me.txtCodFormaPgto1.Left = 1.732284!
        Me.txtCodFormaPgto1.Name = "txtCodFormaPgto1"
        Me.txtCodFormaPgto1.OutputFormat = resources.GetString("txtCodFormaPgto1.OutputFormat")
        Me.txtCodFormaPgto1.Style = "font-family: Tahoma; "
        Me.txtCodFormaPgto1.Text = "txtCodFormaPgto1"
        Me.txtCodFormaPgto1.Top = 0.0!
        Me.txtCodFormaPgto1.Width = 0.4724409!
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
        Me.txtDescrição1.DataField = "Descrição"
        Me.txtDescrição1.Height = 0.1968504!
        Me.txtDescrição1.Left = 2.218668!
        Me.txtDescrição1.Name = "txtDescrição1"
        Me.txtDescrição1.Style = ""
        Me.txtDescrição1.Text = "txtDescrição1"
        Me.txtDescrição1.Top = 0.0!
        Me.txtDescrição1.Width = 2.440945!
        '
        'txtDesconto1
        '
        Me.txtDesconto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDesconto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDesconto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDesconto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDesconto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto1.DataField = "Desconto"
        Me.txtDesconto1.Height = 0.1968504!
        Me.txtDesconto1.Left = 4.68504!
        Me.txtDesconto1.Name = "txtDesconto1"
        Me.txtDesconto1.OutputFormat = resources.GetString("txtDesconto1.OutputFormat")
        Me.txtDesconto1.Style = "text-align: right; "
        Me.txtDesconto1.Text = "txtDesconto1"
        Me.txtDesconto1.Top = 0.0!
        Me.txtDesconto1.Width = 0.6299213!
        '
        'txtAcrescimo1
        '
        Me.txtAcrescimo1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAcrescimo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAcrescimo1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAcrescimo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAcrescimo1.Border.RightColor = System.Drawing.Color.Black
        Me.txtAcrescimo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAcrescimo1.Border.TopColor = System.Drawing.Color.Black
        Me.txtAcrescimo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAcrescimo1.DataField = "Acrescimo"
        Me.txtAcrescimo1.Height = 0.1968504!
        Me.txtAcrescimo1.Left = 5.590551!
        Me.txtAcrescimo1.Name = "txtAcrescimo1"
        Me.txtAcrescimo1.OutputFormat = resources.GetString("txtAcrescimo1.OutputFormat")
        Me.txtAcrescimo1.Style = "text-align: right; "
        Me.txtAcrescimo1.Text = "txtAcrescimo1"
        Me.txtAcrescimo1.Top = 0.0!
        Me.txtAcrescimo1.Width = 0.5905511!
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
        Me.Label5.Height = 0.1968504!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 5.354331!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = ""
        Me.Label5.Text = "%"
        Me.Label5.Top = 0.0!
        Me.Label5.Width = 0.1968504!
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
        Me.Label6.Height = 0.1968504!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 6.220472!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = ""
        Me.Label6.Text = "%"
        Me.Label6.Top = 0.0!
        Me.Label6.Width = 0.1968504!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1, Me.Line3})
        Me.PageFooter1.Height = 0.3229167!
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
        Me.ReportInfo1.FormatString = "Pág {PageNumber} de {PageCount}  -  {RunDateTime}"
        Me.ReportInfo1.Height = 0.1968504!
        Me.ReportInfo1.Left = 0.03937008!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = ""
        Me.ReportInfo1.Top = 0.03937008!
        Me.ReportInfo1.Width = 2.637795!
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
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 6.377953!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 6.377953!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.0!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDescricaoTipoPgto1, Me.txtCodigoTipoPgto1})
        Me.GroupHeader1.DataField = "CodigoTipoPgto"
        Me.GroupHeader1.Height = 0.3229167!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'txtDescricaoTipoPgto1
        '
        Me.txtDescricaoTipoPgto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescricaoTipoPgto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescricaoTipoPgto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescricaoTipoPgto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescricaoTipoPgto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescricaoTipoPgto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescricaoTipoPgto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescricaoTipoPgto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescricaoTipoPgto1.DataField = "DescricaoTipoPgto"
        Me.txtDescricaoTipoPgto1.Height = 0.1968504!
        Me.txtDescricaoTipoPgto1.Left = 0.6751149!
        Me.txtDescricaoTipoPgto1.Name = "txtDescricaoTipoPgto1"
        Me.txtDescricaoTipoPgto1.Style = "font-weight: bold; font-family: Tahoma; "
        Me.txtDescricaoTipoPgto1.Text = "txtDescricaoTipoPgto1"
        Me.txtDescricaoTipoPgto1.Top = 0.08686024!
        Me.txtDescricaoTipoPgto1.Width = 2.204725!
        '
        'txtCodigoTipoPgto1
        '
        Me.txtCodigoTipoPgto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoTipoPgto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTipoPgto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoTipoPgto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTipoPgto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoTipoPgto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTipoPgto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoTipoPgto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTipoPgto1.DataField = "CodigoTipoPgto"
        Me.txtCodigoTipoPgto1.Height = 0.1968504!
        Me.txtCodigoTipoPgto1.Left = 0.1574803!
        Me.txtCodigoTipoPgto1.Name = "txtCodigoTipoPgto1"
        Me.txtCodigoTipoPgto1.OutputFormat = resources.GetString("txtCodigoTipoPgto1.OutputFormat")
        Me.txtCodigoTipoPgto1.Style = "font-weight: bold; font-family: Tahoma; "
        Me.txtCodigoTipoPgto1.Text = "txtCodigoTipoPgto1"
        Me.txtCodigoTipoPgto1.Top = 0.07874016!
        Me.txtCodigoTipoPgto1.Width = 0.5118111!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.Label1.Left = 0.02436024!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-weight: bold; font-size: 11pt; font-family: Tahoma; "
        Me.Label1.Text = "Tipos e Forma de Pagamentos"
        Me.Label1.Top = 0.343914!
        Me.Label1.Width = 3.543307!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Line2, Me.T1})
        Me.ReportHeader1.Height = 0.6041667!
        Me.ReportHeader1.Name = "ReportHeader1"
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
        Me.Line2.Left = 0.01041667!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.5520833!
        Me.Line2.Width = 6.377954!
        Me.Line2.X1 = 0.01041667!
        Me.Line2.X2 = 6.38837!
        Me.Line2.Y1 = 0.5520833!
        Me.Line2.Y2 = 0.5520833!
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
        Me.T1.Height = 0.2362205!
        Me.T1.Left = 0.0!
        Me.T1.Name = "T1"
        Me.T1.Style = "font-family: Tahoma; "
        Me.T1.Text = Nothing
        Me.T1.Top = 0.03937008!
        Me.T1.Width = 6.771654!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'RelTipoFormaPgto
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Temp\Database.mdb;Persist Securit" & _
            "y Info=False"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
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
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodFormaPgto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcrescimo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescricaoTipoPgto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoTipoPgto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCodFormaPgto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescrição1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents txtDescricaoTipoPgto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodigoTipoPgto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtDesconto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAcrescimo1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents T1 As DataDynamics.ActiveReports.TextBox
End Class 
