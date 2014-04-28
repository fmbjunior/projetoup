<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceberAvulso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceberAvulso))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btFindContaLanc = New System.Windows.Forms.Label()
        Me.ContaLancamentoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ContaLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LocalPgto = New CBOAutoCompleteFocus.CboFocus()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Vendedor = New CBOAutoCompleteFocus.CboFocus()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindClintes = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IdReceber = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Confirmado = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Historico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataVencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValorDoc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(627, 445)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btFindContaLanc)
        Me.GroupPanel1.Controls.Add(Me.ContaLancamentoDesc)
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Controls.Add(Me.ContaLancamento)
        Me.GroupPanel1.Controls.Add(Me.LocalPgto)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Vendedor)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.ClienteDesc)
        Me.GroupPanel1.Controls.Add(Me.btFindClintes)
        Me.GroupPanel1.Controls.Add(Me.Id)
        Me.GroupPanel1.Controls.Add(Me.IdReceber)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.DataLancamento)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Cliente)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Documento)
        Me.GroupPanel1.Controls.Add(Me.Confirmado)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Historico)
        Me.GroupPanel1.Controls.Add(Me.DataVencimento)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.ValorDoc)
        Me.GroupPanel1.Location = New System.Drawing.Point(14, 14)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(601, 393)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Dados do Recebimento Avulso"
        '
        'btFindContaLanc
        '
        Me.btFindContaLanc.Image = CType(resources.GetObject("btFindContaLanc.Image"), System.Drawing.Image)
        Me.btFindContaLanc.Location = New System.Drawing.Point(228, 177)
        Me.btFindContaLanc.Name = "btFindContaLanc"
        Me.btFindContaLanc.Size = New System.Drawing.Size(19, 20)
        Me.btFindContaLanc.TabIndex = 22
        '
        'ContaLancamentoDesc
        '
        Me.ContaLancamentoDesc.AceitaColarTexto = True
        Me.ContaLancamentoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaLancamentoDesc.CasasDecimais = 2
        Me.ContaLancamentoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaLancamentoDesc.CPObrigatorio = False
        Me.ContaLancamentoDesc.CPObrigatorioMsg = Nothing
        Me.ContaLancamentoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaLancamentoDesc.FlatBorder = False
        Me.ContaLancamentoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaLancamentoDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaLancamentoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaLancamentoDesc.HighlightBorderOnEnter = False
        Me.ContaLancamentoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaLancamentoDesc.Location = New System.Drawing.Point(249, 177)
        Me.ContaLancamentoDesc.MaxLength = 6
        Me.ContaLancamentoDesc.Name = "ContaLancamentoDesc"
        Me.ContaLancamentoDesc.PreencherZeroEsqueda = False
        Me.ContaLancamentoDesc.RegraValidação = Nothing
        Me.ContaLancamentoDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaLancamentoDesc.Size = New System.Drawing.Size(338, 23)
        Me.ContaLancamentoDesc.TabIndex = 23
        Me.ContaLancamentoDesc.TabStop = False
        Me.ContaLancamentoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaLancamentoDesc.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(8, 178)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 22)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Conta de Receita"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaLancamento
        '
        Me.ContaLancamento.AceitaColarTexto = True
        Me.ContaLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaLancamento.CasasDecimais = 2
        Me.ContaLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaLancamento.CPObrigatorio = False
        Me.ContaLancamento.CPObrigatorioMsg = Nothing
        Me.ContaLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaLancamento.FlatBorder = False
        Me.ContaLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaLancamento.FocusColor = System.Drawing.Color.Empty
        Me.ContaLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaLancamento.HighlightBorderOnEnter = False
        Me.ContaLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaLancamento.Location = New System.Drawing.Point(134, 177)
        Me.ContaLancamento.MaxLength = 6
        Me.ContaLancamento.Name = "ContaLancamento"
        Me.ContaLancamento.PreencherZeroEsqueda = True
        Me.ContaLancamento.RegraValidação = Nothing
        Me.ContaLancamento.RegraValidaçãoMensagem = Nothing
        Me.ContaLancamento.Size = New System.Drawing.Size(93, 23)
        Me.ContaLancamento.TabIndex = 21
        Me.ContaLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContaLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaLancamento.ValorPadrao = Nothing
        '
        'LocalPgto
        '
        Me.LocalPgto.Auto_Complete = True
        Me.LocalPgto.AutoLimitar_Lista = True
        Me.LocalPgto.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.LocalPgto.CPObrigatorio = False
        Me.LocalPgto.CPObrigatorioMsg = Nothing
        Me.LocalPgto.FlatBorder = False
        Me.LocalPgto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.LocalPgto.FormattingEnabled = True
        Me.LocalPgto.HighlightBorderColor = System.Drawing.Color.Empty
        Me.LocalPgto.HighlightBorderOnEnter = False
        Me.LocalPgto.Location = New System.Drawing.Point(133, 206)
        Me.LocalPgto.Name = "LocalPgto"
        Me.LocalPgto.Size = New System.Drawing.Size(210, 23)
        Me.LocalPgto.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(8, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Local Pagamento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vendedor
        '
        Me.Vendedor.Auto_Complete = True
        Me.Vendedor.AutoLimitar_Lista = True
        Me.Vendedor.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.Vendedor.CPObrigatorio = False
        Me.Vendedor.CPObrigatorioMsg = Nothing
        Me.Vendedor.FlatBorder = False
        Me.Vendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vendedor.FormattingEnabled = True
        Me.Vendedor.HighlightBorderColor = System.Drawing.Color.Empty
        Me.Vendedor.HighlightBorderOnEnter = False
        Me.Vendedor.Location = New System.Drawing.Point(134, 235)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(453, 23)
        Me.Vendedor.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(8, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Vendedor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = True
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteDesc.FlatBorder = False
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.FocusColor = System.Drawing.Color.Empty
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(249, 33)
        Me.ClienteDesc.MaxLength = 50
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(338, 23)
        Me.ClienteDesc.TabIndex = 6
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'btFindClintes
        '
        Me.btFindClintes.Image = CType(resources.GetObject("btFindClintes.Image"), System.Drawing.Image)
        Me.btFindClintes.Location = New System.Drawing.Point(228, 33)
        Me.btFindClintes.Name = "btFindClintes"
        Me.btFindClintes.Size = New System.Drawing.Size(23, 23)
        Me.btFindClintes.TabIndex = 7
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(134, 3)
        Me.Id.MaxLength = 8
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(94, 23)
        Me.Id.TabIndex = 1
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'IdReceber
        '
        Me.IdReceber.AceitaColarTexto = True
        Me.IdReceber.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IdReceber.CasasDecimais = 0
        Me.IdReceber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdReceber.CPObrigatorio = False
        Me.IdReceber.CPObrigatorioMsg = Nothing
        Me.IdReceber.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdReceber.FlatBorder = False
        Me.IdReceber.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdReceber.FocusColor = System.Drawing.Color.Empty
        Me.IdReceber.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdReceber.HighlightBorderOnEnter = False
        Me.IdReceber.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdReceber.Location = New System.Drawing.Point(493, 5)
        Me.IdReceber.MaxLength = 8
        Me.IdReceber.Name = "IdReceber"
        Me.IdReceber.PreencherZeroEsqueda = False
        Me.IdReceber.RegraValidação = Nothing
        Me.IdReceber.RegraValidaçãoMensagem = Nothing
        Me.IdReceber.Size = New System.Drawing.Size(94, 23)
        Me.IdReceber.TabIndex = 3
        Me.IdReceber.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdReceber.ValorPadrao = Nothing
        Me.IdReceber.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(9, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Id"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = True
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FlatBorder = False
        Me.DataLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.HighlightBorderOnEnter = False
        Me.DataLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataLancamento.Location = New System.Drawing.Point(134, 90)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.PreencherZeroEsqueda = False
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(94, 23)
        Me.DataLancamento.TabIndex = 11
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Data Lançamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(134, 32)
        Me.Cliente.MaxLength = 8
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(93, 23)
        Me.Cliente.TabIndex = 5
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Documento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Documento
        '
        Me.Documento.AceitaColarTexto = True
        Me.Documento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Documento.CasasDecimais = 0
        Me.Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Documento.CPObrigatorio = False
        Me.Documento.CPObrigatorioMsg = Nothing
        Me.Documento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Documento.FlatBorder = False
        Me.Documento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Documento.FocusColor = System.Drawing.Color.Empty
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.HighlightBorderOnEnter = False
        Me.Documento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Documento.Location = New System.Drawing.Point(134, 61)
        Me.Documento.MaxLength = 15
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(94, 23)
        Me.Documento.TabIndex = 9
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'Confirmado
        '
        Me.Confirmado.AutoSize = True
        Me.Confirmado.Location = New System.Drawing.Point(236, 8)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(86, 19)
        Me.Confirmado.TabIndex = 2
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Data Vencimento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Historico
        '
        Me.Historico.AceitaColarTexto = True
        Me.Historico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Historico.CasasDecimais = 0
        Me.Historico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Historico.CPObrigatorio = False
        Me.Historico.CPObrigatorioMsg = Nothing
        Me.Historico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Historico.FlatBorder = False
        Me.Historico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Historico.FocusColor = System.Drawing.Color.Empty
        Me.Historico.FocusColorEnd = System.Drawing.Color.Empty
        Me.Historico.HighlightBorderOnEnter = False
        Me.Historico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Historico.Location = New System.Drawing.Point(133, 264)
        Me.Historico.MaxLength = 5000
        Me.Historico.Multiline = True
        Me.Historico.Name = "Historico"
        Me.Historico.PreencherZeroEsqueda = False
        Me.Historico.RegraValidação = Nothing
        Me.Historico.RegraValidaçãoMensagem = Nothing
        Me.Historico.Size = New System.Drawing.Size(454, 55)
        Me.Historico.TabIndex = 29
        Me.Historico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Historico.ValorPadrao = Nothing
        '
        'DataVencimento
        '
        Me.DataVencimento.AceitaColarTexto = True
        Me.DataVencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataVencimento.CasasDecimais = 0
        Me.DataVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataVencimento.CPObrigatorio = False
        Me.DataVencimento.CPObrigatorioMsg = Nothing
        Me.DataVencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataVencimento.FlatBorder = False
        Me.DataVencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataVencimento.FocusColor = System.Drawing.Color.Empty
        Me.DataVencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataVencimento.HighlightBorderOnEnter = False
        Me.DataVencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataVencimento.Location = New System.Drawing.Point(134, 119)
        Me.DataVencimento.MaxLength = 10
        Me.DataVencimento.Name = "DataVencimento"
        Me.DataVencimento.PreencherZeroEsqueda = False
        Me.DataVencimento.RegraValidação = Nothing
        Me.DataVencimento.RegraValidaçãoMensagem = Nothing
        Me.DataVencimento.Size = New System.Drawing.Size(94, 23)
        Me.DataVencimento.TabIndex = 13
        Me.DataVencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataVencimento.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(8, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 23)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Histórico"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Valor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDoc
        '
        Me.ValorDoc.AceitaColarTexto = True
        Me.ValorDoc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDoc.CasasDecimais = 2
        Me.ValorDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDoc.CPObrigatorio = False
        Me.ValorDoc.CPObrigatorioMsg = Nothing
        Me.ValorDoc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDoc.FlatBorder = False
        Me.ValorDoc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDoc.FocusColor = System.Drawing.Color.Empty
        Me.ValorDoc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDoc.HighlightBorderOnEnter = False
        Me.ValorDoc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDoc.Location = New System.Drawing.Point(134, 148)
        Me.ValorDoc.MaxLength = 10
        Me.ValorDoc.Name = "ValorDoc"
        Me.ValorDoc.PreencherZeroEsqueda = False
        Me.ValorDoc.RegraValidação = Nothing
        Me.ValorDoc.RegraValidaçãoMensagem = Nothing
        Me.ValorDoc.Size = New System.Drawing.Size(94, 23)
        Me.ValorDoc.TabIndex = 15
        Me.ValorDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDoc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDoc.ValorPadrao = Nothing
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(433, 413)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(88, 28)
        Me.btNovo.TabIndex = 2
        Me.btNovo.Text = "Novo"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(280, 413)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(147, 28)
        Me.btSalvar.TabIndex = 1
        Me.btSalvar.Text = "Salvar e Confirmar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(527, 413)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(88, 28)
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ReceberAvulso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 445)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ReceberAvulso"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recebimento Avulso - T064"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Historico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ValorDoc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataVencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Confirmado As System.Windows.Forms.CheckBox
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdReceber As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btFindClintes As System.Windows.Forms.Label
    Friend WithEvents LocalPgto As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Vendedor As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btFindContaLanc As System.Windows.Forms.Label
    Friend WithEvents ContaLancamentoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ContaLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
