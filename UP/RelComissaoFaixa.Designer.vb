<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelComissaoFaixa 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelComissaoFaixa))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtDataLancamento1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDocumento1 = New DataDynamics.ActiveReports.TextBox
        Me.txtPedidoVenda1 = New DataDynamics.ActiveReports.TextBox
        Me.txtPercentual1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorDocumento1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorComissao1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescComissao1 = New DataDynamics.ActiveReports.TextBox
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.FuncionarioGrupo = New DataDynamics.ActiveReports.TextBox
        Me.txtFuncionario1 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        Me.SubIndice = New DataDynamics.ActiveReports.SubReport
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
        Me.IsFaturamento = New DataDynamics.ActiveReports.CheckBox
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader
        Me.txtComissaoFat = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Field1 = New DataDynamics.ActiveReports.Field
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtRazãoSocial1 = New DataDynamics.ActiveReports.TextBox
        Me.Titulo = New DataDynamics.ActiveReports.TextBox
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtDataLancamento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedidoVenda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercentual1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorComissao1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescComissao1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFuncionario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsFaturamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComissaoFat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtDataLancamento1, Me.txtDocumento1, Me.txtPedidoVenda1, Me.txtPercentual1, Me.txtValorDocumento1, Me.txtValorComissao1, Me.txtDescComissao1})
        Me.Detail1.Height = 0.125!
        Me.Detail1.Name = "Detail1"
        '
        'txtDataLancamento1
        '
        Me.txtDataLancamento1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDataLancamento1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataLancamento1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDataLancamento1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataLancamento1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDataLancamento1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataLancamento1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDataLancamento1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataLancamento1.DataField = "DataLancamento"
        Me.txtDataLancamento1.Height = 0.1574803!
        Me.txtDataLancamento1.Left = 0.1574803!
        Me.txtDataLancamento1.Name = "txtDataLancamento1"
        Me.txtDataLancamento1.OutputFormat = resources.GetString("txtDataLancamento1.OutputFormat")
        Me.txtDataLancamento1.Style = ""
        Me.txtDataLancamento1.Text = "txtDataLancamento1"
        Me.txtDataLancamento1.Top = 0.0!
        Me.txtDataLancamento1.Width = 0.6692913!
        '
        'txtDocumento1
        '
        Me.txtDocumento1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDocumento1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDocumento1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDocumento1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDocumento1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDocumento1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDocumento1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDocumento1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDocumento1.DataField = "Documento"
        Me.txtDocumento1.Height = 0.1574803!
        Me.txtDocumento1.Left = 1.496063!
        Me.txtDocumento1.Name = "txtDocumento1"
        Me.txtDocumento1.Style = ""
        Me.txtDocumento1.Text = "txtDocumento1"
        Me.txtDocumento1.Top = 0.0!
        Me.txtDocumento1.Width = 0.6692913!
        '
        'txtPedidoVenda1
        '
        Me.txtPedidoVenda1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPedidoVenda1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPedidoVenda1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPedidoVenda1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPedidoVenda1.Border.RightColor = System.Drawing.Color.Black
        Me.txtPedidoVenda1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPedidoVenda1.Border.TopColor = System.Drawing.Color.Black
        Me.txtPedidoVenda1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPedidoVenda1.DataField = "PedidoVenda"
        Me.txtPedidoVenda1.Height = 0.1574803!
        Me.txtPedidoVenda1.Left = 0.8661418!
        Me.txtPedidoVenda1.Name = "txtPedidoVenda1"
        Me.txtPedidoVenda1.Style = ""
        Me.txtPedidoVenda1.Text = "txtPedidoVenda1"
        Me.txtPedidoVenda1.Top = 0.0!
        Me.txtPedidoVenda1.Width = 0.5905511!
        '
        'txtPercentual1
        '
        Me.txtPercentual1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPercentual1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPercentual1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPercentual1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPercentual1.Border.RightColor = System.Drawing.Color.Black
        Me.txtPercentual1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPercentual1.Border.TopColor = System.Drawing.Color.Black
        Me.txtPercentual1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPercentual1.DataField = "Percentual"
        Me.txtPercentual1.Height = 0.1574803!
        Me.txtPercentual1.Left = 2.992126!
        Me.txtPercentual1.Name = "txtPercentual1"
        Me.txtPercentual1.OutputFormat = resources.GetString("txtPercentual1.OutputFormat")
        Me.txtPercentual1.Style = "text-align: center; "
        Me.txtPercentual1.Text = "txtPercentual1"
        Me.txtPercentual1.Top = 0.0!
        Me.txtPercentual1.Width = 0.3543306!
        '
        'txtValorDocumento1
        '
        Me.txtValorDocumento1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtValorDocumento1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorDocumento1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtValorDocumento1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorDocumento1.Border.RightColor = System.Drawing.Color.Black
        Me.txtValorDocumento1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorDocumento1.Border.TopColor = System.Drawing.Color.Black
        Me.txtValorDocumento1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorDocumento1.DataField = "ValorDocumento"
        Me.txtValorDocumento1.Height = 0.1574803!
        Me.txtValorDocumento1.Left = 2.204725!
        Me.txtValorDocumento1.Name = "txtValorDocumento1"
        Me.txtValorDocumento1.OutputFormat = resources.GetString("txtValorDocumento1.OutputFormat")
        Me.txtValorDocumento1.Style = "text-align: right; "
        Me.txtValorDocumento1.Text = "txtValorDocumento1"
        Me.txtValorDocumento1.Top = 0.0!
        Me.txtValorDocumento1.Width = 0.7480316!
        '
        'txtValorComissao1
        '
        Me.txtValorComissao1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtValorComissao1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorComissao1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtValorComissao1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorComissao1.Border.RightColor = System.Drawing.Color.Black
        Me.txtValorComissao1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorComissao1.Border.TopColor = System.Drawing.Color.Black
        Me.txtValorComissao1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorComissao1.DataField = "ValorComissao"
        Me.txtValorComissao1.Height = 0.1574803!
        Me.txtValorComissao1.Left = 3.425197!
        Me.txtValorComissao1.Name = "txtValorComissao1"
        Me.txtValorComissao1.OutputFormat = resources.GetString("txtValorComissao1.OutputFormat")
        Me.txtValorComissao1.Style = "text-align: right; "
        Me.txtValorComissao1.Text = "txtValorComissao1"
        Me.txtValorComissao1.Top = 0.0!
        Me.txtValorComissao1.Width = 0.7480314!
        '
        'txtDescComissao1
        '
        Me.txtDescComissao1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescComissao1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescComissao1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescComissao1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescComissao1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescComissao1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescComissao1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescComissao1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescComissao1.DataField = "DescComissao"
        Me.txtDescComissao1.Height = 0.1574803!
        Me.txtDescComissao1.Left = 4.212598!
        Me.txtDescComissao1.Name = "txtDescComissao1"
        Me.txtDescComissao1.Style = ""
        Me.txtDescComissao1.Text = "txtDescComissao1"
        Me.txtDescComissao1.Top = 0.0!
        Me.txtDescComissao1.Width = 3.582677!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.FuncionarioGrupo, Me.txtFuncionario1})
        Me.GroupHeader1.DataField = "Nome"
        Me.GroupHeader1.Height = 0.3541667!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'FuncionarioGrupo
        '
        Me.FuncionarioGrupo.Border.BottomColor = System.Drawing.Color.Black
        Me.FuncionarioGrupo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.FuncionarioGrupo.Border.LeftColor = System.Drawing.Color.Black
        Me.FuncionarioGrupo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.FuncionarioGrupo.Border.RightColor = System.Drawing.Color.Black
        Me.FuncionarioGrupo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.FuncionarioGrupo.Border.TopColor = System.Drawing.Color.Black
        Me.FuncionarioGrupo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.FuncionarioGrupo.DataField = "=Funcionario + ""-"" +  Nome"
        Me.FuncionarioGrupo.Height = 0.1968504!
        Me.FuncionarioGrupo.Left = 0.03937008!
        Me.FuncionarioGrupo.Name = "FuncionarioGrupo"
        Me.FuncionarioGrupo.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.FuncionarioGrupo.Text = "TextBox1"
        Me.FuncionarioGrupo.Top = 0.0!
        Me.FuncionarioGrupo.Width = 5.078741!
        '
        'txtFuncionario1
        '
        Me.txtFuncionario1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFuncionario1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFuncionario1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFuncionario1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFuncionario1.Border.RightColor = System.Drawing.Color.Black
        Me.txtFuncionario1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFuncionario1.Border.TopColor = System.Drawing.Color.Black
        Me.txtFuncionario1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFuncionario1.DataField = "Funcionario"
        Me.txtFuncionario1.Height = 0.2!
        Me.txtFuncionario1.Left = 5.866142!
        Me.txtFuncionario1.Name = "txtFuncionario1"
        Me.txtFuncionario1.Style = ""
        Me.txtFuncionario1.Text = "txtFuncionario1"
        Me.txtFuncionario1.Top = 0.03937008!
        Me.txtFuncionario1.Visible = False
        Me.txtFuncionario1.Width = 1.0!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.TextBox4, Me.Line2, Me.TextBox13, Me.SubIndice, Me.Label1, Me.TextBox14, Me.TextBox15})
        Me.GroupFooter1.Height = 1.322917!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "ValorComissao"
        Me.TextBox2.Height = 0.1574803!
        Me.TextBox2.Left = 3.425197!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox2.SummaryGroup = "GroupHeader1"
        Me.TextBox2.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox2.Text = "Total ComissaoG1"
        Me.TextBox2.Top = 0.03937008!
        Me.TextBox2.Width = 0.7480314!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Height = 0.1574803!
        Me.TextBox4.Left = 0.03937008!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox4.Text = "Total Geral do Vendedor"
        Me.TextBox4.Top = 0.03937008!
        Me.TextBox4.Width = 1.732284!
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
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.2362205!
        Me.Line2.Width = 7.834646!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.834646!
        Me.Line2.Y1 = 0.2362205!
        Me.Line2.Y2 = 0.2362205!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.DataField = "ValorDocumento"
        Me.TextBox13.Height = 0.1476378!
        Me.TextBox13.Left = 2.214567!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox13.SummaryGroup = "GroupHeader1"
        Me.TextBox13.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox13.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox13.Text = "TotalDoc"
        Me.TextBox13.Top = 0.0492126!
        Me.TextBox13.Width = 0.738189!
        '
        'SubIndice
        '
        Me.SubIndice.Border.BottomColor = System.Drawing.Color.Black
        Me.SubIndice.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubIndice.Border.LeftColor = System.Drawing.Color.Black
        Me.SubIndice.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubIndice.Border.RightColor = System.Drawing.Color.Black
        Me.SubIndice.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubIndice.Border.TopColor = System.Drawing.Color.Black
        Me.SubIndice.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubIndice.CloseBorder = False
        Me.SubIndice.Height = 0.375!
        Me.SubIndice.Left = 0.0625!
        Me.SubIndice.Name = "SubIndice"
        Me.SubIndice.Report = Nothing
        Me.SubIndice.ReportName = "SubReport1"
        Me.SubIndice.Top = 0.5625!
        Me.SubIndice.Width = 3.875!
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
        Me.Label1.Left = 0.03937008!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; "
        Me.Label1.Text = "Resumo do Vendedor"
        Me.Label1.Top = 0.3543307!
        Me.Label1.Width = 1.811024!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.DataField = "ValorComissao"
        Me.TextBox14.Height = 0.1574803!
        Me.TextBox14.Left = 2.795276!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox14.SummaryGroup = "GroupHeader1"
        Me.TextBox14.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox14.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox14.Text = "Total ComissaoG1"
        Me.TextBox14.Top = 0.984252!
        Me.TextBox14.Width = 0.7480314!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Height = 0.1574803!
        Me.TextBox15.Left = 0.03937008!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox15.Text = "Total da Comissão"
        Me.TextBox15.Top = 0.984252!
        Me.TextBox15.Width = 1.732284!
        '
        'IsFaturamento
        '
        Me.IsFaturamento.Border.BottomColor = System.Drawing.Color.Black
        Me.IsFaturamento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.IsFaturamento.Border.LeftColor = System.Drawing.Color.Black
        Me.IsFaturamento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.IsFaturamento.Border.RightColor = System.Drawing.Color.Black
        Me.IsFaturamento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.IsFaturamento.Border.TopColor = System.Drawing.Color.Black
        Me.IsFaturamento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.IsFaturamento.DataField = "ComissaoFaturamento"
        Me.IsFaturamento.Height = 0.1574803!
        Me.IsFaturamento.Left = 0.1574803!
        Me.IsFaturamento.Name = "IsFaturamento"
        Me.IsFaturamento.Style = ""
        Me.IsFaturamento.Text = ""
        Me.IsFaturamento.Top = 0.0!
        Me.IsFaturamento.Width = 0.1574803!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.IsFaturamento, Me.txtComissaoFat})
        Me.GroupHeader2.DataField = "ComissaoFaturamento"
        Me.GroupHeader2.Height = 0.28125!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'txtComissaoFat
        '
        Me.txtComissaoFat.Border.BottomColor = System.Drawing.Color.Black
        Me.txtComissaoFat.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtComissaoFat.Border.LeftColor = System.Drawing.Color.Black
        Me.txtComissaoFat.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtComissaoFat.Border.RightColor = System.Drawing.Color.Black
        Me.txtComissaoFat.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtComissaoFat.Border.TopColor = System.Drawing.Color.Black
        Me.txtComissaoFat.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtComissaoFat.Height = 0.1574803!
        Me.txtComissaoFat.Left = 0.3543307!
        Me.txtComissaoFat.Name = "txtComissaoFat"
        Me.txtComissaoFat.Style = ""
        Me.txtComissaoFat.Text = "TextBox1"
        Me.txtComissaoFat.Top = 0.0!
        Me.txtComissaoFat.Width = 2.677165!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.Line1, Me.TextBox5, Me.Line5})
        Me.GroupFooter2.Height = 0.3020833!
        Me.GroupFooter2.Name = "GroupFooter2"
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
        Me.TextBox1.DataField = "ValorComissao"
        Me.TextBox1.Height = 0.1574803!
        Me.TextBox1.Left = 3.425197!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox1.SummaryGroup = "GroupHeader2"
        Me.TextBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox1.Text = "Total ComissaoG2"
        Me.TextBox1.Top = 0.03937008!
        Me.TextBox1.Width = 0.7480314!
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
        Me.Line1.Left = 3.425197!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.03937008!
        Me.Line1.Width = 0.7480323!
        Me.Line1.X1 = 3.425197!
        Me.Line1.X2 = 4.173229!
        Me.Line1.Y1 = 0.03937008!
        Me.Line1.Y2 = 0.03937008!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.DataField = "ValorDocumento"
        Me.TextBox5.Height = 0.1476378!
        Me.TextBox5.Left = 2.214567!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox5.SummaryGroup = "GroupHeader2"
        Me.TextBox5.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox5.Text = "TotalDoc"
        Me.TextBox5.Top = 0.0492126!
        Me.TextBox5.Width = 0.738189!
        '
        'Line5
        '
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 2.214567!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0492126!
        Me.Line5.Width = 0.738189!
        Me.Line5.X1 = 2.214567!
        Me.Line5.X2 = 2.952756!
        Me.Line5.Y1 = 0.0492126!
        Me.Line5.Y2 = 0.0492126!
        '
        'Field1
        '
        Me.Field1.DefaultValue = Nothing
        Me.Field1.FieldType = DataDynamics.ActiveReports.FieldTypeEnum.[Double]
        Me.Field1.Formula = ""
        Me.Field1.Name = "Field1"
        Me.Field1.Tag = Nothing
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
        Me.ReportInfo1.FormatString = "Pagina {PageNumber} de {PageCount} Data: {RunDateTime}"
        Me.ReportInfo1.Height = 0.1574803!
        Me.ReportInfo1.Left = 0.03937008!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.ReportInfo1.Top = 0.07874016!
        Me.ReportInfo1.Width = 4.094488!
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtRazãoSocial1, Me.Titulo, Me.Line4, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12})
        Me.PageHeader1.Height = 0.9270833!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtRazãoSocial1
        '
        Me.txtRazãoSocial1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRazãoSocial1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRazãoSocial1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRazãoSocial1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRazãoSocial1.Border.RightColor = System.Drawing.Color.Black
        Me.txtRazãoSocial1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRazãoSocial1.Border.TopColor = System.Drawing.Color.Black
        Me.txtRazãoSocial1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRazãoSocial1.DataField = "RazãoSocial"
        Me.txtRazãoSocial1.Height = 0.1968504!
        Me.txtRazãoSocial1.Left = 0.03937008!
        Me.txtRazãoSocial1.Name = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 11pt; "
        Me.txtRazãoSocial1.Text = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Top = 0.0!
        Me.txtRazãoSocial1.Width = 4.527559!
        '
        'Titulo
        '
        Me.Titulo.Border.BottomColor = System.Drawing.Color.Black
        Me.Titulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Titulo.Border.LeftColor = System.Drawing.Color.Black
        Me.Titulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Titulo.Border.RightColor = System.Drawing.Color.Black
        Me.Titulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Titulo.Border.TopColor = System.Drawing.Color.Black
        Me.Titulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Titulo.Height = 0.1574803!
        Me.Titulo.Left = 0.03937008!
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Style = ""
        Me.Titulo.Text = "Comissão por Vendedor"
        Me.Titulo.Top = 0.2755906!
        Me.Titulo.Width = 4.527559!
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
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.9055119!
        Me.Line4.Width = 7.834646!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 7.834646!
        Me.Line4.Y1 = 0.9055119!
        Me.Line4.Y2 = 0.9055119!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Height = 0.1574803!
        Me.TextBox6.Left = 0.1574803!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox6.Text = "Data Lanç"
        Me.TextBox6.Top = 0.7480316!
        Me.TextBox6.Width = 0.6692913!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Height = 0.1574803!
        Me.TextBox7.Left = 0.8661418!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox7.Text = "Pedido"
        Me.TextBox7.Top = 0.7480316!
        Me.TextBox7.Width = 0.5905512!
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
        Me.TextBox8.Height = 0.1574803!
        Me.TextBox8.Left = 1.535433!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox8.Text = "Documento"
        Me.TextBox8.Top = 0.7480316!
        Me.TextBox8.Width = 0.6692913!
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
        Me.TextBox9.Height = 0.1574803!
        Me.TextBox9.Left = 2.283465!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox9.Text = "Valor Doc"
        Me.TextBox9.Top = 0.7480316!
        Me.TextBox9.Width = 0.7086614!
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
        Me.TextBox10.Height = 0.1574803!
        Me.TextBox10.Left = 3.031496!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
        Me.TextBox10.Text = "%"
        Me.TextBox10.Top = 0.7480316!
        Me.TextBox10.Width = 0.3149607!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Height = 0.1574803!
        Me.TextBox11.Left = 3.464567!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox11.Text = "Comissão"
        Me.TextBox11.Top = 0.7480316!
        Me.TextBox11.Width = 0.7086613!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Height = 0.1574803!
        Me.TextBox12.Left = 4.212598!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; "
        Me.TextBox12.Text = "Descrição"
        Me.TextBox12.Top = 0.7480316!
        Me.TextBox12.Width = 2.677165!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1, Me.Line3, Me.TextBox3})
        Me.PageFooter1.Height = 0.3229167!
        Me.PageFooter1.Name = "PageFooter1"
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
        Me.Line3.Top = 0.03937008!
        Me.Line3.Width = 7.874016!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.874016!
        Me.Line3.Y1 = 0.03937008!
        Me.Line3.Y2 = 0.03937008!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Height = 0.1574803!
        Me.TextBox3.Left = 5.787402!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: right; "
        Me.TextBox3.Text = "RelComissaoFaixa"
        Me.TextBox3.Top = 0.03937008!
        Me.TextBox3.Width = 1.968504!
        '
        'RelComissaoFaixa
        '
        Me.MasterReport = False
        Me.CalculatedFields.Add(Me.Field1)
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DouglasDados\Projetos Vb.Net\Prj " & _
            "Up\Dados\max\upDados.mdb;Jet oledb:database password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.1968504!
        Me.PageSettings.Margins.Left = 0.1968504!
        Me.PageSettings.Margins.Right = 0.1968504!
        Me.PageSettings.Margins.Top = 0.1968504!
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 7.84375!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; color: Black; fon" & _
                    "t-family: ""Tahoma""; font-size: 8pt; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-weight: bold; ddo-char-set: 204; font-size: 8pt; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-weight: bold; font-style: italic; font-family: ""Tahoma""; ddo-char-set: 204; " & _
                    "font-size: 8pt; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-weight: bold; ddo-char-set: 204; font-size: 8pt; ", "Heading3", "Normal"))
        CType(Me.txtDataLancamento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedidoVenda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercentual1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorComissao1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescComissao1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFuncionario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsFaturamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComissaoFat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtDataLancamento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDocumento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPedidoVenda1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPercentual1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorDocumento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorComissao1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents IsFaturamento As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents txtDescComissao1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtComissaoFat As DataDynamics.ActiveReports.TextBox
    Friend WithEvents FuncionarioGrupo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Field1 As DataDynamics.ActiveReports.Field
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Friend WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRazãoSocial1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Titulo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents SubIndice As DataDynamics.ActiveReports.SubReport
    Friend WithEvents txtFuncionario1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
End Class
