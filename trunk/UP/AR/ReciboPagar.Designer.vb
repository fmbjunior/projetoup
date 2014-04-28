<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReciboPagar 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReciboPagar))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.lblUser = New DataDynamics.ActiveReports.Label()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.Shape1 = New DataDynamics.ActiveReports.Shape()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.txtValorLiquido1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.txtRazãoSocial1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.lblextenso = New DataDynamics.ActiveReports.Label()
        Me.txtReferencia1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.txtPagar_Id1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.txtDocumento1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.lbllocaldata = New DataDynamics.ActiveReports.Label()
        Me.txtPagamento1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtFornecedor1 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.lblUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorLiquido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblextenso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPagar_Id1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbllocaldata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPagamento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFornecedor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblUser})
        Me.PageHeader1.Height = 0.2395833!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblUser
        '
        Me.lblUser.Height = 0.2!
        Me.lblUser.HyperLink = Nothing
        Me.lblUser.Left = 0.074!
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Style = ""
        Me.lblUser.Text = ""
        Me.lblUser.Top = 0.0!
        Me.lblUser.Width = 6.77167!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Label1, Me.Label2, Me.txtValorLiquido1, Me.Label3, Me.Label4, Me.txtRazãoSocial1, Me.Label5, Me.lblextenso, Me.txtReferencia1, Me.Label7, Me.txtPagar_Id1, Me.Label8, Me.txtDocumento1, Me.Label6, Me.lbllocaldata, Me.txtPagamento1, Me.txtFornecedor1})
        Me.Detail1.Height = 3.291667!
        Me.Detail1.Name = "Detail1"
        '
        'Shape1
        '
        Me.Shape1.Height = 3.219!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.0!
        Me.Shape1.Width = 6.876!
        '
        'Label1
        '
        Me.Label1.CharacterSpacing = 4.0!
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.2086614!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 12pt; font-weight: bold; ddo-char-set: 1"
        Me.Label1.Text = "RECIBO"
        Me.Label1.Top = 0.07322834!
        Me.Label1.Width = 1.125197!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.489764!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = ""
        Me.Label2.Text = "Nº"
        Me.Label2.Top = 0.07322833!
        Me.Label2.Width = 0.26063!
        '
        'txtValorLiquido1
        '
        Me.txtValorLiquido1.DataField = "ValorLiquido"
        Me.txtValorLiquido1.Height = 0.2!
        Me.txtValorLiquido1.Left = 5.396063!
        Me.txtValorLiquido1.Name = "txtValorLiquido1"
        Me.txtValorLiquido1.OutputFormat = resources.GetString("txtValorLiquido1.OutputFormat")
        Me.txtValorLiquido1.Style = "font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.txtValorLiquido1.Text = "txtValorLiquido1"
        Me.txtValorLiquido1.Top = 0.07322836!
        Me.txtValorLiquido1.Width = 1.405938!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 4.854331!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "text-align: right"
        Me.Label3.Text = "Valor:"
        Me.Label3.Top = 0.07322834!
        Me.Label3.Width = 0.4795275!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.208662!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "text-align: left"
        Me.Label4.Text = "Recebi(emos)"
        Me.Label4.Top = 0.4897638!
        Me.Label4.Width = 1.125196!
        '
        'txtRazãoSocial1
        '
        Me.txtRazãoSocial1.DataField = "=RazãoSocial + "" Cnpj: "" + cgc"
        Me.txtRazãoSocial1.Height = 0.2!
        Me.txtRazãoSocial1.Left = 1.489764!
        Me.txtRazãoSocial1.Name = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Text = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Top = 0.4897637!
        Me.txtRazãoSocial1.Width = 5.312237!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.2086614!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "text-align: left"
        Me.Label5.Text = "A quantia de "
        Me.Label5.Top = 0.781496!
        Me.Label5.Width = 1.125196!
        '
        'lblextenso
        '
        Me.lblextenso.Height = 0.5751969!
        Me.lblextenso.HyperLink = Nothing
        Me.lblextenso.Left = 1.489764!
        Me.lblextenso.Name = "lblextenso"
        Me.lblextenso.Style = "font-style: italic; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.lblextenso.Text = ""
        Me.lblextenso.Top = 0.781496!
        Me.lblextenso.Width = 5.312237!
        '
        'txtReferencia1
        '
        Me.txtReferencia1.DataField = "Referencia"
        Me.txtReferencia1.Height = 0.4708663!
        Me.txtReferencia1.Left = 1.489764!
        Me.txtReferencia1.Name = "txtReferencia1"
        Me.txtReferencia1.Text = "txtReferencia1"
        Me.txtReferencia1.Top = 1.437401!
        Me.txtReferencia1.Width = 5.312237!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.2086614!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "text-align: left"
        Me.Label7.Text = "Referente a "
        Me.Label7.Top = 1.437401!
        Me.Label7.Width = 1.125196!
        '
        'txtPagar_Id1
        '
        Me.txtPagar_Id1.DataField = "Pagar.Id"
        Me.txtPagar_Id1.Height = 0.2!
        Me.txtPagar_Id1.Left = 1.812599!
        Me.txtPagar_Id1.Name = "txtPagar_Id1"
        Me.txtPagar_Id1.Text = "txtPagar_Id1"
        Me.txtPagar_Id1.Top = 0.07322836!
        Me.txtPagar_Id1.Width = 0.6980312!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.698031!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = ""
        Me.Label8.Text = "Documento"
        Me.Label8.Top = 0.07322834!
        Me.Label8.Width = 0.7397636!
        '
        'txtDocumento1
        '
        Me.txtDocumento1.DataField = "Documento"
        Me.txtDocumento1.Height = 0.2!
        Me.txtDocumento1.Left = 3.531102!
        Me.txtDocumento1.Name = "txtDocumento1"
        Me.txtDocumento1.Text = "txtDocumento1"
        Me.txtDocumento1.Top = 0.07322836!
        Me.txtDocumento1.Width = 1.25!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.2086614!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: left"
        Me.Label6.Text = "e para clareza firmo(amos) o presente."
        Me.Label6.Top = 1.908267!
        Me.Label6.Width = 2.916929!
        '
        'lbllocaldata
        '
        Me.lbllocaldata.Height = 0.2!
        Me.lbllocaldata.HyperLink = Nothing
        Me.lbllocaldata.Left = 0.2086614!
        Me.lbllocaldata.Name = "lbllocaldata"
        Me.lbllocaldata.Style = "text-align: left"
        Me.lbllocaldata.Text = ""
        Me.lbllocaldata.Top = 2.272835!
        Me.lbllocaldata.Width = 3.989764!
        '
        'txtPagamento1
        '
        Me.txtPagamento1.DataField = "Pagamento"
        Me.txtPagamento1.Height = 0.2!
        Me.txtPagamento1.Left = 6.365!
        Me.txtPagamento1.Name = "txtPagamento1"
        Me.txtPagamento1.OutputFormat = resources.GetString("txtPagamento1.OutputFormat")
        Me.txtPagamento1.Text = "txtPagamento1"
        Me.txtPagamento1.Top = 2.073!
        Me.txtPagamento1.Visible = False
        Me.txtPagamento1.Width = 0.4374013!
        '
        'txtFornecedor1
        '
        Me.txtFornecedor1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtFornecedor1.DataField = "=Fornecedor + "" - "" + CGCCPF"
        Me.txtFornecedor1.Height = 0.2311022!
        Me.txtFornecedor1.Left = 2.917!
        Me.txtFornecedor1.Name = "txtFornecedor1"
        Me.txtFornecedor1.Style = "text-align: center"
        Me.txtFornecedor1.Text = "txtFornecedor1"
        Me.txtFornecedor1.Top = 2.888!
        Me.txtFornecedor1.Width = 3.791732!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReciboPagar
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Projetos dblsistemas\Prj Up\Dados" & _
    "\CD\upDados.mdb;Persist Security Info=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.7874016!
        Me.PageSettings.Margins.Left = 0.5905512!
        Me.PageSettings.Margins.Right = 0.5905512!
        Me.PageSettings.Margins.Top = 0.7874016!
        Me.PageSettings.PaperHeight = 5.511811!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 6.947917!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorLiquido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblextenso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPagar_Id1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbllocaldata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPagamento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFornecedor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtValorLiquido1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtRazãoSocial1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents lblextenso As DataDynamics.ActiveReports.Label
    Friend WithEvents txtReferencia1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtPagar_Id1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtDocumento1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents lbllocaldata As DataDynamics.ActiveReports.Label
    Friend WithEvents txtPagamento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFornecedor1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblUser As DataDynamics.ActiveReports.Label
End Class
