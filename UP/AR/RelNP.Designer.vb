<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelNP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelNP))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.Picture1 = New DataDynamics.ActiveReports.Picture
        Me.txtDocumento1 = New DataDynamics.ActiveReports.TextBox
        Me.txtVencimento1 = New DataDynamics.ActiveReports.TextBox
        Me.dataserial = New DataDynamics.ActiveReports.TextBox
        Me.txtVencimento2 = New DataDynamics.ActiveReports.TextBox
        Me.txtRazãoSocial1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCgc1 = New DataDynamics.ActiveReports.TextBox
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCpfCgc1 = New DataDynamics.ActiveReports.TextBox
        Me.txtEndereço1 = New DataDynamics.ActiveReports.TextBox
        Me.txtClientes_Cidade1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCEP1 = New DataDynamics.ActiveReports.TextBox
        Me.txtValorDocumento1 = New DataDynamics.ActiveReports.TextBox
        Me.lblValorExtenso = New DataDynamics.ActiveReports.Label
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.txtEmpresa_Cidade1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCidadeEstado = New DataDynamics.ActiveReports.TextBox
        Me.txtDataDocumento1 = New DataDynamics.ActiveReports.TextBox
        Me.txtLocalData = New DataDynamics.ActiveReports.TextBox
        Me.ReportInfo2 = New DataDynamics.ActiveReports.ReportInfo
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVencimento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataserial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVencimento2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCgc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCpfCgc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndereço1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientes_Cidade1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCEP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblValorExtenso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa_Cidade1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCidadeEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocalData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 0.0!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Picture1, Me.txtDocumento1, Me.txtVencimento1, Me.dataserial, Me.txtVencimento2, Me.txtRazãoSocial1, Me.txtCgc1, Me.txtNome1, Me.txtCpfCgc1, Me.txtEndereço1, Me.txtClientes_Cidade1, Me.txtCEP1, Me.txtValorDocumento1, Me.lblValorExtenso, Me.txtEmpresa_Cidade1, Me.txtCidadeEstado, Me.txtDataDocumento1, Me.txtLocalData})
        Me.Detail1.Height = 4.262336!
        Me.Detail1.Name = "Detail1"
        '
        'Picture1
        '
        Me.Picture1.Height = 4.322835!
        Me.Picture1.ImageData = CType(resources.GetObject("Picture1.ImageData"), System.IO.Stream)
        Me.Picture1.Left = 0.0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture1.Top = 0.07283465!
        Me.Picture1.Width = 7.301969!
        '
        'txtDocumento1
        '
        Me.txtDocumento1.DataField = "Documento"
        Me.txtDocumento1.Height = 0.2!
        Me.txtDocumento1.Left = 2.312205!
        Me.txtDocumento1.Name = "txtDocumento1"
        Me.txtDocumento1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtDocumento1.Text = "txtDocumento1"
        Me.txtDocumento1.Top = 0.2173228!
        Me.txtDocumento1.Width = 1.0!
        '
        'txtVencimento1
        '
        Me.txtVencimento1.DataField = "Vencimento"
        Me.txtVencimento1.Height = 0.2!
        Me.txtVencimento1.Left = 4.854331!
        Me.txtVencimento1.Name = "txtVencimento1"
        Me.txtVencimento1.OutputFormat = resources.GetString("txtVencimento1.OutputFormat")
        Me.txtVencimento1.Style = "font-family: Tahoma; font-size: 9pt; font-weight: bold; text-align: right; ddo-ch" & _
            "ar-set: 1"
        Me.txtVencimento1.Text = "txtVencimento1"
        Me.txtVencimento1.Top = 0.2070866!
        Me.txtVencimento1.Width = 2.364567!
        '
        'dataserial
        '
        Me.dataserial.Height = 0.2!
        Me.dataserial.Left = 1.781102!
        Me.dataserial.Name = "dataserial"
        Me.dataserial.Style = "font-family: Tahoma; font-size: 9pt; ddo-char-set: 1"
        Me.dataserial.Text = Nothing
        Me.dataserial.Top = 1.051968!
        Me.dataserial.Width = 4.322835!
        '
        'txtVencimento2
        '
        Me.txtVencimento2.DataField = "Vencimento"
        Me.txtVencimento2.Height = 0.2!
        Me.txtVencimento2.Left = 1.312205!
        Me.txtVencimento2.Name = "txtVencimento2"
        Me.txtVencimento2.Text = "txtVencimento2"
        Me.txtVencimento2.Top = 4.604331!
        Me.txtVencimento2.Visible = False
        Me.txtVencimento2.Width = 1.0!
        '
        'txtRazãoSocial1
        '
        Me.txtRazãoSocial1.DataField = "RazãoSocial"
        Me.txtRazãoSocial1.Height = 0.2!
        Me.txtRazãoSocial1.Left = 1.614567!
        Me.txtRazãoSocial1.Name = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Text = "txtRazãoSocial1"
        Me.txtRazãoSocial1.Top = 1.333464!
        Me.txtRazãoSocial1.Width = 3.239764!
        '
        'txtCgc1
        '
        Me.txtCgc1.DataField = "Cgc"
        Me.txtCgc1.Height = 0.2!
        Me.txtCgc1.Left = 5.458268!
        Me.txtCgc1.Name = "txtCgc1"
        Me.txtCgc1.Text = "txtCgc1"
        Me.txtCgc1.Top = 1.333465!
        Me.txtCgc1.Width = 1.698031!
        '
        'txtNome1
        '
        Me.txtNome1.DataField = "Nome"
        Me.txtNome1.Height = 0.2!
        Me.txtNome1.Left = 1.520866!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 2.717323!
        Me.txtNome1.Width = 2.895669!
        '
        'txtCpfCgc1
        '
        Me.txtCpfCgc1.DataField = "CpfCgc"
        Me.txtCpfCgc1.Height = 0.2!
        Me.txtCpfCgc1.Left = 1.520866!
        Me.txtCpfCgc1.Name = "txtCpfCgc1"
        Me.txtCpfCgc1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtCpfCgc1.Text = "txtCpfCgc1"
        Me.txtCpfCgc1.Top = 3.0!
        Me.txtCpfCgc1.Width = 2.301969!
        '
        'txtEndereço1
        '
        Me.txtEndereço1.DataField = "=Endereço + ""Nº ""+ Nro"
        Me.txtEndereço1.Height = 0.2!
        Me.txtEndereço1.Left = 1.520866!
        Me.txtEndereço1.Name = "txtEndereço1"
        Me.txtEndereço1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtEndereço1.Text = "txtEndereço1"
        Me.txtEndereço1.Top = 3.343701!
        Me.txtEndereço1.Width = 2.489764!
        '
        'txtClientes_Cidade1
        '
        Me.txtClientes_Cidade1.DataField = "=Clientes.Cidade +""/""+ Clientes.Estado "
        Me.txtClientes_Cidade1.Height = 0.2!
        Me.txtClientes_Cidade1.Left = 1.520866!
        Me.txtClientes_Cidade1.Name = "txtClientes_Cidade1"
        Me.txtClientes_Cidade1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtClientes_Cidade1.Text = "txtClientes_Cidade1"
        Me.txtClientes_Cidade1.Top = 3.698031!
        Me.txtClientes_Cidade1.Width = 1.437402!
        '
        'txtCEP1
        '
        Me.txtCEP1.DataField = "CEP"
        Me.txtCEP1.Height = 0.2!
        Me.txtCEP1.Left = 3.104331!
        Me.txtCEP1.Name = "txtCEP1"
        Me.txtCEP1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtCEP1.Text = "txtCEP1"
        Me.txtCEP1.Top = 3.698031!
        Me.txtCEP1.Width = 1.0!
        '
        'txtValorDocumento1
        '
        Me.txtValorDocumento1.DataField = "ValorDocumento"
        Me.txtValorDocumento1.Height = 0.2102362!
        Me.txtValorDocumento1.Left = 5.875197!
        Me.txtValorDocumento1.Name = "txtValorDocumento1"
        Me.txtValorDocumento1.OutputFormat = resources.GetString("txtValorDocumento1.OutputFormat")
        Me.txtValorDocumento1.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold; text-align: right; ddo-c" & _
            "har-set: 1"
        Me.txtValorDocumento1.Text = "txtValorDocumento1"
        Me.txtValorDocumento1.Top = 0.5889764!
        Me.txtValorDocumento1.Width = 1.245669!
        '
        'lblValorExtenso
        '
        Me.lblValorExtenso.Height = 0.3456692!
        Me.lblValorExtenso.HyperLink = Nothing
        Me.lblValorExtenso.Left = 2.010236!
        Me.lblValorExtenso.Name = "lblValorExtenso"
        Me.lblValorExtenso.Style = "font-family: Tahoma; font-size: 9pt; ddo-char-set: 1"
        Me.lblValorExtenso.Text = ""
        Me.lblValorExtenso.Top = 1.739764!
        Me.lblValorExtenso.Width = 5.11063!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo2})
        Me.PageFooter1.Height = 0.21875!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'txtEmpresa_Cidade1
        '
        Me.txtEmpresa_Cidade1.DataField = "=Empresa.Cidade +"", "" + Empresa.Estado"
        Me.txtEmpresa_Cidade1.Height = 0.2!
        Me.txtEmpresa_Cidade1.Left = 3.843307!
        Me.txtEmpresa_Cidade1.Name = "txtEmpresa_Cidade1"
        Me.txtEmpresa_Cidade1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtEmpresa_Cidade1.Text = "txtEmpresa_Cidade1"
        Me.txtEmpresa_Cidade1.Top = 2.36378!
        Me.txtEmpresa_Cidade1.Width = 2.895669!
        '
        'txtCidadeEstado
        '
        Me.txtCidadeEstado.DataField = "=Empresa.Cidade +"", "" + Empresa.Estado + txtDataDocumento1"
        Me.txtCidadeEstado.Height = 0.2!
        Me.txtCidadeEstado.Left = 2.396063!
        Me.txtCidadeEstado.Name = "txtCidadeEstado"
        Me.txtCidadeEstado.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtCidadeEstado.Text = "txtEmpresa_Cidade1"
        Me.txtCidadeEstado.Top = 4.604331!
        Me.txtCidadeEstado.Visible = False
        Me.txtCidadeEstado.Width = 1.614567!
        '
        'txtDataDocumento1
        '
        Me.txtDataDocumento1.DataField = "DataDocumento"
        Me.txtDataDocumento1.Height = 0.2!
        Me.txtDataDocumento1.Left = 0.1767716!
        Me.txtDataDocumento1.Name = "txtDataDocumento1"
        Me.txtDataDocumento1.OutputFormat = resources.GetString("txtDataDocumento1.OutputFormat")
        Me.txtDataDocumento1.Text = "txtDataDocumento1"
        Me.txtDataDocumento1.Top = 4.604331!
        Me.txtDataDocumento1.Visible = False
        Me.txtDataDocumento1.Width = 1.0!
        '
        'txtLocalData
        '
        Me.txtLocalData.Height = 0.1692912!
        Me.txtLocalData.Left = 4.25!
        Me.txtLocalData.Name = "txtLocalData"
        Me.txtLocalData.Style = "font-family: Tahoma; font-size: 7pt; font-weight: bold; text-align: right; ddo-ch" & _
            "ar-set: 1"
        Me.txtLocalData.Text = "LocalData"
        Me.txtLocalData.Top = 3.061417!
        Me.txtLocalData.Width = 2.906299!
        '
        'ReportInfo2
        '
        Me.ReportInfo2.FormatString = Nothing
        Me.ReportInfo2.Height = 0.1968504!
        Me.ReportInfo2.Left = 0.0!
        Me.ReportInfo2.Name = "ReportInfo2"
        Me.ReportInfo2.Style = "color: Black; font-family: Tahoma; font-size: 8pt; font-weight: normal; text-alig" & _
            "n: left; ddo-char-set: 1"
        Me.ReportInfo2.Top = 0.0!
        Me.ReportInfo2.Width = 3.572835!
        '
        'RelNP
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\CD\upDados.mdb;Persist Security I" & _
            "nfo=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.PaperHeight = 5.708662!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.375!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVencimento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataserial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVencimento2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazãoSocial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCgc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCpfCgc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndereço1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientes_Cidade1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCEP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblValorExtenso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa_Cidade1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCidadeEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocalData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents txtDocumento1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtVencimento1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents dataserial As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtVencimento2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRazãoSocial1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCgc1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCpfCgc1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtEndereço1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtClientes_Cidade1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCEP1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtValorDocumento1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblValorExtenso As DataDynamics.ActiveReports.Label
    Friend WithEvents txtEmpresa_Cidade1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtCidadeEstado As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDataDocumento1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtLocalData As DataDynamics.ActiveReports.TextBox
    Private WithEvents ReportInfo2 As DataDynamics.ActiveReports.ReportInfo
End Class
