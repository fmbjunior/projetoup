<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelRepasseCheque 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelRepasseCheque))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.txtCodRepasse1 = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.CaixaOrigem = New DataDynamics.ActiveReports.TextBox
        Me.CaixaDestino = New DataDynamics.ActiveReports.TextBox
        Me.txtDataRepasse1 = New DataDynamics.ActiveReports.TextBox
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCheque1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCC1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorCh1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.CaixaOrigemASS = New DataDynamics.ActiveReports.TextBox
        Me.CaixaDestinoASS = New DataDynamics.ActiveReports.TextBox
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodRepasse1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaOrigem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataRepasse1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorCh1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaOrigemASS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaDestinoASS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label5, Me.Label6, Me.Label7, Me.txtCodRepasse1, Me.Label1, Me.Label2, Me.Label3, Me.CaixaOrigem, Me.CaixaDestino, Me.txtDataRepasse1, Me.Label4, Me.Line1, Me.Line2})
        Me.PageHeader1.Height = 1.5625!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.Label5.Height = 0.1968505!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.312992!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.Label5.Text = "Valor"
        Me.Label5.Top = 1.377953!
        Me.Label5.Width = 1.181102!
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
        Me.Label6.Height = 0.1476379!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.32874!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.Label6.Text = "CC"
        Me.Label6.Top = 1.377953!
        Me.Label6.Width = 0.8858268!
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
        Me.Label7.Height = 0.1476379!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.1968504!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.Label7.Text = "Cheque"
        Me.Label7.Top = 1.377953!
        Me.Label7.Width = 0.9350393!
        '
        'txtCodRepasse1
        '
        Me.txtCodRepasse1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodRepasse1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodRepasse1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodRepasse1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodRepasse1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodRepasse1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodRepasse1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodRepasse1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodRepasse1.DataField = "CodRepasse"
        Me.txtCodRepasse1.Height = 0.2187227!
        Me.txtCodRepasse1.Left = 1.618548!
        Me.txtCodRepasse1.Name = "txtCodRepasse1"
        Me.txtCodRepasse1.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
        Me.txtCodRepasse1.Text = "txtCodRepasse1"
        Me.txtCodRepasse1.Top = 0.04374453!
        Me.txtCodRepasse1.Width = 1.92476!
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
        Me.Label1.Height = 0.1749781!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.08748907!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.Label1.Text = "Código do Repasse.......:"
        Me.Label1.Top = 0.04374453!
        Me.Label1.Width = 1.487314!
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
        Me.Label2.Height = 0.1749781!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.08748907!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.Label2.Text = "Caixa de Origem...........:"
        Me.Label2.Top = 0.3062117!
        Me.Label2.Width = 1.487314!
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
        Me.Label3.Height = 0.1749781!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.08748907!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.Label3.Text = "Caixa de Destino..........:"
        Me.Label3.Top = 0.5686789!
        Me.Label3.Width = 1.487314!
        '
        'CaixaOrigem
        '
        Me.CaixaOrigem.Border.BottomColor = System.Drawing.Color.Black
        Me.CaixaOrigem.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaOrigem.Border.LeftColor = System.Drawing.Color.Black
        Me.CaixaOrigem.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaOrigem.Border.RightColor = System.Drawing.Color.Black
        Me.CaixaOrigem.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaOrigem.Border.TopColor = System.Drawing.Color.Black
        Me.CaixaOrigem.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaOrigem.DataField = "= CaixaOrigem + ""-"" + CaixaCadastro.CaixaNome"
        Me.CaixaOrigem.Height = 0.2187227!
        Me.CaixaOrigem.Left = 1.618548!
        Me.CaixaOrigem.Name = "CaixaOrigem"
        Me.CaixaOrigem.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
        Me.CaixaOrigem.Text = "txtCaixaOrigem1"
        Me.CaixaOrigem.Top = 0.3062117!
        Me.CaixaOrigem.Width = 5.5993!
        '
        'CaixaDestino
        '
        Me.CaixaDestino.Border.BottomColor = System.Drawing.Color.Black
        Me.CaixaDestino.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaDestino.Border.LeftColor = System.Drawing.Color.Black
        Me.CaixaDestino.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaDestino.Border.RightColor = System.Drawing.Color.Black
        Me.CaixaDestino.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaDestino.Border.TopColor = System.Drawing.Color.Black
        Me.CaixaDestino.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaDestino.DataField = "=CaixaDestino + ""-"" + CaixaCadastro_1.CaixaNome"
        Me.CaixaDestino.Height = 0.2187227!
        Me.CaixaDestino.Left = 1.618548!
        Me.CaixaDestino.Name = "CaixaDestino"
        Me.CaixaDestino.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
        Me.CaixaDestino.Text = "txtCaixaDestino1"
        Me.CaixaDestino.Top = 0.5686789!
        Me.CaixaDestino.Width = 5.5993!
        '
        'txtDataRepasse1
        '
        Me.txtDataRepasse1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDataRepasse1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataRepasse1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDataRepasse1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataRepasse1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDataRepasse1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataRepasse1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDataRepasse1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDataRepasse1.DataField = "DataRepasse"
        Me.txtDataRepasse1.Height = 0.2187227!
        Me.txtDataRepasse1.Left = 1.618548!
        Me.txtDataRepasse1.Name = "txtDataRepasse1"
        Me.txtDataRepasse1.OutputFormat = resources.GetString("txtDataRepasse1.OutputFormat")
        Me.txtDataRepasse1.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
        Me.txtDataRepasse1.Text = "txtDataRepasse1"
        Me.txtDataRepasse1.Top = 0.8748906!
        Me.txtDataRepasse1.Width = 0.9623798!
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
        Me.Label4.Height = 0.1749781!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.08748907!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Tahoma; "
        Me.Label4.Text = "Data Repasse...............:"
        Me.Label4.Top = 0.8748906!
        Me.Label4.Width = 1.487314!
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
        Me.Line1.Top = 1.312336!
        Me.Line1.Width = 7.786527!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 7.786527!
        Me.Line1.Y1 = 1.312336!
        Me.Line1.Y2 = 1.312336!
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
        Me.Line2.Top = 1.531059!
        Me.Line2.Width = 7.786527!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.786527!
        Me.Line2.Y1 = 1.531059!
        Me.Line2.Y2 = 1.531059!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCheque1, Me.txtCC1, Me.txtValorCh1})
        Me.Detail1.Height = 0.1875!
        Me.Detail1.Name = "Detail1"
        '
        'txtCheque1
        '
        Me.txtCheque1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCheque1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCheque1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCheque1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCheque1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCheque1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCheque1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCheque1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCheque1.DataField = "Cheque"
        Me.txtCheque1.Height = 0.1968504!
        Me.txtCheque1.Left = 0.1968504!
        Me.txtCheque1.Name = "txtCheque1"
        Me.txtCheque1.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; font-family: Tahoma; "
        Me.txtCheque1.Text = "txtCheque1"
        Me.txtCheque1.Top = 0.0!
        Me.txtCheque1.Width = 0.984252!
        '
        'txtCC1
        '
        Me.txtCC1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCC1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCC1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCC1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCC1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCC1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCC1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCC1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCC1.DataField = "CC"
        Me.txtCC1.Height = 0.1968504!
        Me.txtCC1.Left = 1.279528!
        Me.txtCC1.Name = "txtCC1"
        Me.txtCC1.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; font-family: Tahoma; "
        Me.txtCC1.Text = "txtCC1"
        Me.txtCC1.Top = 0.0!
        Me.txtCC1.Width = 0.8858268!
        '
        'txtValorCh1
        '
        Me.txtValorCh1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtValorCh1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorCh1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtValorCh1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorCh1.Border.RightColor = System.Drawing.Color.Black
        Me.txtValorCh1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorCh1.Border.TopColor = System.Drawing.Color.Black
        Me.txtValorCh1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValorCh1.DataField = "ValorCh"
        Me.txtValorCh1.Height = 0.1968504!
        Me.txtValorCh1.Left = 2.312992!
        Me.txtValorCh1.Name = "txtValorCh1"
        Me.txtValorCh1.OutputFormat = resources.GetString("txtValorCh1.OutputFormat")
        Me.txtValorCh1.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; font-family: Tahoma; "
        Me.txtValorCh1.Text = "txtValorCh1"
        Me.txtValorCh1.Top = 0.0!
        Me.txtValorCh1.Width = 1.181102!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.1458333!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.25!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.Label8, Me.Line3, Me.CaixaOrigemASS, Me.CaixaDestinoASS, Me.Line4, Me.Line5})
        Me.ReportFooter1.Height = 1.645833!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.TextBox1.DataField = "ValorCh"
        Me.TextBox1.Height = 0.1749781!
        Me.TextBox1.Left = 1.487314!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; font-famil" & _
            "y: Tahoma; "
        Me.TextBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.08748907!
        Me.TextBox1.Width = 1.268591!
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
        Me.Label8.Height = 0.1749781!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.0!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; font-famil" & _
            "y: Tahoma; "
        Me.Label8.Text = "Total do Repasse...:"
        Me.Label8.Top = 0.08748907!
        Me.Label8.Width = 1.487314!
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
        Me.Line3.Width = 7.786527!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.786527!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.0!
        '
        'CaixaOrigemASS
        '
        Me.CaixaOrigemASS.Border.BottomColor = System.Drawing.Color.Black
        Me.CaixaOrigemASS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaOrigemASS.Border.LeftColor = System.Drawing.Color.Black
        Me.CaixaOrigemASS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaOrigemASS.Border.RightColor = System.Drawing.Color.Black
        Me.CaixaOrigemASS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaOrigemASS.Border.TopColor = System.Drawing.Color.Black
        Me.CaixaOrigemASS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaOrigemASS.Height = 0.2187227!
        Me.CaixaOrigemASS.Left = 0.0!
        Me.CaixaOrigemASS.Name = "CaixaOrigemASS"
        Me.CaixaOrigemASS.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" & _
            "ly: Tahoma; "
        Me.CaixaOrigemASS.Text = "Caixa Origem"
        Me.CaixaOrigemASS.Top = 1.399825!
        Me.CaixaOrigemASS.Width = 3.805774!
        '
        'CaixaDestinoASS
        '
        Me.CaixaDestinoASS.Border.BottomColor = System.Drawing.Color.Black
        Me.CaixaDestinoASS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaDestinoASS.Border.LeftColor = System.Drawing.Color.Black
        Me.CaixaDestinoASS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaDestinoASS.Border.RightColor = System.Drawing.Color.Black
        Me.CaixaDestinoASS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaDestinoASS.Border.TopColor = System.Drawing.Color.Black
        Me.CaixaDestinoASS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CaixaDestinoASS.Height = 0.2187227!
        Me.CaixaDestinoASS.Left = 3.893264!
        Me.CaixaDestinoASS.Name = "CaixaDestinoASS"
        Me.CaixaDestinoASS.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; font-fami" & _
            "ly: Tahoma; "
        Me.CaixaDestinoASS.Text = "Caixa Destino"
        Me.CaixaDestinoASS.Top = 1.399825!
        Me.CaixaDestinoASS.Width = 3.805774!
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
        Me.Line4.Top = 1.399825!
        Me.Line4.Width = 3.805774!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 3.805774!
        Me.Line4.Y1 = 1.399825!
        Me.Line4.Y2 = 1.399825!
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
        Me.Line5.Left = 3.893264!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.399825!
        Me.Line5.Width = 3.805774!
        Me.Line5.X1 = 3.893264!
        Me.Line5.X2 = 7.699038!
        Me.Line5.Y1 = 1.399825!
        Me.Line5.Y2 = 1.399825!
        '
        'RelRepasseCheque
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Sistemas -Up\Prj Up\Dados\max\upD" & _
            "ados.mdb;Jet oledb:database password=abc"
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
        Me.PrintWidth = 7.7906!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodRepasse1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaOrigem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataRepasse1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorCh1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaOrigemASS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaDestinoASS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtCodRepasse1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents CaixaOrigem As DataDynamics.ActiveReports.TextBox
    Friend WithEvents CaixaDestino As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtDataRepasse1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtCheque1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCC1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents CaixaOrigemASS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents CaixaDestinoASS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtValorCh1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
End Class 
