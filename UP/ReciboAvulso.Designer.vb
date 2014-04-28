<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReciboAvulso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReciboAvulso))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataRecibo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValorDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RecebiDe = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Correspondente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Emitente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.ValorExtenso = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CaixaEmitiu = New TexBoxFocusNet.TextBoxFocusNet()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.NovoBT = New System.Windows.Forms.ToolStripButton()
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton()
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirBT = New System.Windows.Forms.ToolStripButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btLocalizaEmpresa = New DevComponents.DotNetBar.ButtonX()
        Me.CpfCnpj = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EndereçoEmitente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Recibo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Recibo Nº"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(433, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data Recibo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataRecibo
        '
        Me.DataRecibo.AceitaColarTexto = True
        Me.DataRecibo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataRecibo.CasasDecimais = 0
        Me.DataRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataRecibo.CPObrigatorio = False
        Me.DataRecibo.CPObrigatorioMsg = Nothing
        Me.DataRecibo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataRecibo.FlatBorder = False
        Me.DataRecibo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataRecibo.FocusColor = System.Drawing.Color.Empty
        Me.DataRecibo.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataRecibo.HighlightBorderOnEnter = False
        Me.DataRecibo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataRecibo.Location = New System.Drawing.Point(559, 78)
        Me.DataRecibo.MaxLength = 10
        Me.DataRecibo.Name = "DataRecibo"
        Me.DataRecibo.PreencherZeroEsqueda = False
        Me.DataRecibo.RegraValidação = Nothing
        Me.DataRecibo.RegraValidaçãoMensagem = Nothing
        Me.DataRecibo.Size = New System.Drawing.Size(112, 23)
        Me.DataRecibo.TabIndex = 4
        Me.DataRecibo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataRecibo.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "A impotância de"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AceitaColarTexto = True
        Me.ValorDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDocumento.CasasDecimais = 2
        Me.ValorDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDocumento.CPObrigatorio = False
        Me.ValorDocumento.CPObrigatorioMsg = Nothing
        Me.ValorDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDocumento.FlatBorder = False
        Me.ValorDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.FocusColor = System.Drawing.Color.Empty
        Me.ValorDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDocumento.HighlightBorderOnEnter = False
        Me.ValorDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.Location = New System.Drawing.Point(129, 149)
        Me.ValorDocumento.MaxLength = 10
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.PreencherZeroEsqueda = False
        Me.ValorDocumento.RegraValidação = Nothing
        Me.ValorDocumento.RegraValidaçãoMensagem = Nothing
        Me.ValorDocumento.Size = New System.Drawing.Size(112, 23)
        Me.ValorDocumento.TabIndex = 8
        Me.ValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDocumento.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Recebi de"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RecebiDe
        '
        Me.RecebiDe.AceitaColarTexto = True
        Me.RecebiDe.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.RecebiDe.CasasDecimais = 0
        Me.RecebiDe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RecebiDe.CPObrigatorio = False
        Me.RecebiDe.CPObrigatorioMsg = Nothing
        Me.RecebiDe.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.RecebiDe.FlatBorder = False
        Me.RecebiDe.FlatBorderColor = System.Drawing.Color.DimGray
        Me.RecebiDe.FocusColor = System.Drawing.Color.Empty
        Me.RecebiDe.FocusColorEnd = System.Drawing.Color.Empty
        Me.RecebiDe.HighlightBorderOnEnter = False
        Me.RecebiDe.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.RecebiDe.Location = New System.Drawing.Point(129, 120)
        Me.RecebiDe.MaxLength = 50
        Me.RecebiDe.Name = "RecebiDe"
        Me.RecebiDe.PreencherZeroEsqueda = False
        Me.RecebiDe.RegraValidação = Nothing
        Me.RecebiDe.RegraValidaçãoMensagem = Nothing
        Me.RecebiDe.Size = New System.Drawing.Size(542, 23)
        Me.RecebiDe.TabIndex = 6
        Me.RecebiDe.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.RecebiDe.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Correspondente a"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Correspondente
        '
        Me.Correspondente.AceitaColarTexto = True
        Me.Correspondente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Correspondente.CasasDecimais = 0
        Me.Correspondente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Correspondente.CPObrigatorio = False
        Me.Correspondente.CPObrigatorioMsg = Nothing
        Me.Correspondente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Correspondente.FlatBorder = False
        Me.Correspondente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Correspondente.FocusColor = System.Drawing.Color.Empty
        Me.Correspondente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Correspondente.HighlightBorderOnEnter = False
        Me.Correspondente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Correspondente.Location = New System.Drawing.Point(130, 178)
        Me.Correspondente.MaxLength = 2500
        Me.Correspondente.Multiline = True
        Me.Correspondente.Name = "Correspondente"
        Me.Correspondente.PreencherZeroEsqueda = False
        Me.Correspondente.RegraValidação = Nothing
        Me.Correspondente.RegraValidaçãoMensagem = Nothing
        Me.Correspondente.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Correspondente.Size = New System.Drawing.Size(542, 43)
        Me.Correspondente.TabIndex = 10
        Me.Correspondente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Correspondente.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Emitente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Emitente
        '
        Me.Emitente.AceitaColarTexto = True
        Me.Emitente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Emitente.CasasDecimais = 0
        Me.Emitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Emitente.CPObrigatorio = False
        Me.Emitente.CPObrigatorioMsg = Nothing
        Me.Emitente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Emitente.FlatBorder = False
        Me.Emitente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Emitente.FocusColor = System.Drawing.Color.Empty
        Me.Emitente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Emitente.HighlightBorderOnEnter = False
        Me.Emitente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Emitente.Location = New System.Drawing.Point(119, 3)
        Me.Emitente.MaxLength = 50
        Me.Emitente.Name = "Emitente"
        Me.Emitente.PreencherZeroEsqueda = False
        Me.Emitente.RegraValidação = Nothing
        Me.Emitente.RegraValidaçãoMensagem = Nothing
        Me.Emitente.Size = New System.Drawing.Size(518, 23)
        Me.Emitente.TabIndex = 1
        Me.Emitente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Emitente.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.ValorExtenso)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.CaixaEmitiu)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.Recibo)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.DataRecibo)
        Me.Fundo.Controls.Add(Me.Correspondente)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.ValorDocumento)
        Me.Fundo.Controls.Add(Me.RecebiDe)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(690, 376)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'ValorExtenso
        '
        Me.ValorExtenso.BackColor = System.Drawing.Color.Transparent
        Me.ValorExtenso.Location = New System.Drawing.Point(247, 149)
        Me.ValorExtenso.Name = "ValorExtenso"
        Me.ValorExtenso.Size = New System.Drawing.Size(424, 23)
        Me.ValorExtenso.TabIndex = 14
        Me.ValorExtenso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(14, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Caixa Emitente"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CaixaEmitiu
        '
        Me.CaixaEmitiu.AceitaColarTexto = False
        Me.CaixaEmitiu.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CaixaEmitiu.CasasDecimais = 0
        Me.CaixaEmitiu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CaixaEmitiu.CPObrigatorio = False
        Me.CaixaEmitiu.CPObrigatorioMsg = Nothing
        Me.CaixaEmitiu.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CaixaEmitiu.FlatBorder = False
        Me.CaixaEmitiu.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CaixaEmitiu.FocusColor = System.Drawing.Color.Empty
        Me.CaixaEmitiu.FocusColorEnd = System.Drawing.Color.Empty
        Me.CaixaEmitiu.HighlightBorderOnEnter = False
        Me.CaixaEmitiu.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CaixaEmitiu.Location = New System.Drawing.Point(130, 228)
        Me.CaixaEmitiu.MaxLength = 15
        Me.CaixaEmitiu.Name = "CaixaEmitiu"
        Me.CaixaEmitiu.PreencherZeroEsqueda = False
        Me.CaixaEmitiu.RegraValidação = Nothing
        Me.CaixaEmitiu.RegraValidaçãoMensagem = Nothing
        Me.CaixaEmitiu.Size = New System.Drawing.Size(65, 23)
        Me.CaixaEmitiu.TabIndex = 12
        Me.CaixaEmitiu.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CaixaEmitiu.ValorPadrao = Nothing
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HelpProvider1.SetHelpNavigator(Me.BarraBt, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.LocalizarBT, Me.FecharBT, Me.ImprimirBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HelpProvider1.SetShowHelp(Me.BarraBt, True)
        Me.BarraBt.Size = New System.Drawing.Size(690, 58)
        Me.BarraBt.TabIndex = 0
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(40, 55)
        Me.NovoBT.Text = "Novo"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalvarBT
        '
        Me.SalvarBT.Image = CType(resources.GetObject("SalvarBT.Image"), System.Drawing.Image)
        Me.SalvarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(45, 55)
        Me.SalvarBT.Text = "Salvar"
        Me.SalvarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LocalizarBT
        '
        Me.LocalizarBT.Image = CType(resources.GetObject("LocalizarBT.Image"), System.Drawing.Image)
        Me.LocalizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LocalizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LocalizarBT.Name = "LocalizarBT"
        Me.LocalizarBT.Size = New System.Drawing.Size(59, 55)
        Me.LocalizarBT.Text = "Localizar"
        Me.LocalizarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LocalizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(46, 55)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImprimirBT
        '
        Me.ImprimirBT.Image = CType(resources.GetObject("ImprimirBT.Image"), System.Drawing.Image)
        Me.ImprimirBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImprimirBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirBT.Name = "ImprimirBT"
        Me.ImprimirBT.Size = New System.Drawing.Size(57, 55)
        Me.ImprimirBT.Text = "Imprimir"
        Me.ImprimirBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ImprimirBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btLocalizaEmpresa)
        Me.GroupPanel1.Controls.Add(Me.CpfCnpj)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.EndereçoEmitente)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Emitente)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Location = New System.Drawing.Point(7, 257)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(676, 110)
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
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 13
        Me.GroupPanel1.Text = "Emitente"
        '
        'btLocalizaEmpresa
        '
        Me.btLocalizaEmpresa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLocalizaEmpresa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLocalizaEmpresa.Image = CType(resources.GetObject("btLocalizaEmpresa.Image"), System.Drawing.Image)
        Me.btLocalizaEmpresa.Location = New System.Drawing.Point(643, 3)
        Me.btLocalizaEmpresa.Name = "btLocalizaEmpresa"
        Me.btLocalizaEmpresa.Size = New System.Drawing.Size(24, 23)
        Me.btLocalizaEmpresa.TabIndex = 14
        Me.btLocalizaEmpresa.TabStop = False
        '
        'CpfCnpj
        '
        Me.CpfCnpj.AceitaColarTexto = True
        Me.CpfCnpj.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CpfCnpj.CasasDecimais = 0
        Me.CpfCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CpfCnpj.CPObrigatorio = False
        Me.CpfCnpj.CPObrigatorioMsg = Nothing
        Me.CpfCnpj.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CpfCnpj.FlatBorder = False
        Me.CpfCnpj.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CpfCnpj.FocusColor = System.Drawing.Color.Empty
        Me.CpfCnpj.FocusColorEnd = System.Drawing.Color.Empty
        Me.CpfCnpj.HighlightBorderOnEnter = False
        Me.CpfCnpj.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CpfCnpj.Location = New System.Drawing.Point(119, 61)
        Me.CpfCnpj.MaxLength = 18
        Me.CpfCnpj.Name = "CpfCnpj"
        Me.CpfCnpj.PreencherZeroEsqueda = False
        Me.CpfCnpj.RegraValidação = Nothing
        Me.CpfCnpj.RegraValidaçãoMensagem = Nothing
        Me.CpfCnpj.Size = New System.Drawing.Size(189, 23)
        Me.CpfCnpj.TabIndex = 5
        Me.CpfCnpj.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CpfCnpj.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(3, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "CPF/CNPJ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EndereçoEmitente
        '
        Me.EndereçoEmitente.AceitaColarTexto = True
        Me.EndereçoEmitente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EndereçoEmitente.CasasDecimais = 0
        Me.EndereçoEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EndereçoEmitente.CPObrigatorio = False
        Me.EndereçoEmitente.CPObrigatorioMsg = Nothing
        Me.EndereçoEmitente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EndereçoEmitente.FlatBorder = False
        Me.EndereçoEmitente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EndereçoEmitente.FocusColor = System.Drawing.Color.Empty
        Me.EndereçoEmitente.FocusColorEnd = System.Drawing.Color.Empty
        Me.EndereçoEmitente.HighlightBorderOnEnter = False
        Me.EndereçoEmitente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EndereçoEmitente.Location = New System.Drawing.Point(119, 32)
        Me.EndereçoEmitente.MaxLength = 50
        Me.EndereçoEmitente.Name = "EndereçoEmitente"
        Me.EndereçoEmitente.PreencherZeroEsqueda = False
        Me.EndereçoEmitente.RegraValidação = Nothing
        Me.EndereçoEmitente.RegraValidaçãoMensagem = Nothing
        Me.EndereçoEmitente.Size = New System.Drawing.Size(518, 23)
        Me.EndereçoEmitente.TabIndex = 3
        Me.EndereçoEmitente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EndereçoEmitente.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(3, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Endereço"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Recibo
        '
        Me.Recibo.AcceptsReturn = True
        Me.Recibo.AceitaColarTexto = False
        Me.Recibo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Recibo.CasasDecimais = 0
        Me.Recibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Recibo.CPObrigatorio = False
        Me.Recibo.CPObrigatorioMsg = Nothing
        Me.Recibo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Recibo.FlatBorder = False
        Me.Recibo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Recibo.FocusColor = System.Drawing.Color.Empty
        Me.Recibo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Recibo.HighlightBorderOnEnter = False
        Me.Recibo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Recibo.Location = New System.Drawing.Point(129, 79)
        Me.Recibo.MaxLength = 6
        Me.Recibo.Name = "Recibo"
        Me.Recibo.PreencherZeroEsqueda = True
        Me.Recibo.RegraValidação = Nothing
        Me.Recibo.RegraValidaçãoMensagem = Nothing
        Me.Recibo.Size = New System.Drawing.Size(112, 23)
        Me.Recibo.TabIndex = 2
        Me.Recibo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Recibo.ValorPadrao = Nothing
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ReciboAvulso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(690, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "ReciboAvulso"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo Avulso - T202"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataRecibo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ValorDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RecebiDe As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Correspondente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Emitente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Recibo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CpfCnpj As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EndereçoEmitente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CaixaEmitiu As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents btLocalizaEmpresa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ValorExtenso As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
