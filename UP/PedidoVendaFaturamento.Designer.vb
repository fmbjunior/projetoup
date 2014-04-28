<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVendaFaturamento
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoVendaFaturamento))
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TotalGeral = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.Opt1 = New System.Windows.Forms.RadioButton()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.PainelCliente = New System.Windows.Forms.Panel()
        Me.Cli = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CliDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Opt2 = New System.Windows.Forms.RadioButton()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PainelPeriodo.SuspendLayout()
        Me.PainelCliente.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 0
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FlatBorder = False
        Me.DataInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.HighlightBorderOnEnter = False
        Me.DataInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataInicial.Location = New System.Drawing.Point(70, 5)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(88, 23)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Período"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FlatBorder = False
        Me.DataFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.HighlightBorderOnEnter = False
        Me.DataFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataFinal.Location = New System.Drawing.Point(166, 5)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(88, 23)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'MyLista
        '
        Me.MyLista.BackColor = System.Drawing.Color.White
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.Location = New System.Drawing.Point(12, 97)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(869, 442)
        Me.MyLista.SmallImageList = Me.ImageList1
        Me.MyLista.TabIndex = 3
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Pedido"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "N.º Controle"
        Me.ColumnHeader8.Width = 77
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cliente"
        Me.ColumnHeader2.Width = 320
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Valor"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Data Pedido"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cancelado"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Conf."
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tipo Venda"
        Me.ColumnHeader7.Width = 109
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "BolaVerde18.png")
        Me.ImageList1.Images.SetKeyName(1, "BolaVermelha.png")
        '
        'TotalGeral
        '
        Me.TotalGeral.AceitaColarTexto = True
        Me.TotalGeral.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalGeral.CasasDecimais = 2
        Me.TotalGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalGeral.CPObrigatorio = False
        Me.TotalGeral.CPObrigatorioMsg = Nothing
        Me.TotalGeral.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalGeral.FlatBorder = False
        Me.TotalGeral.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalGeral.FocusColor = System.Drawing.Color.Empty
        Me.TotalGeral.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalGeral.HighlightBorderOnEnter = False
        Me.TotalGeral.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalGeral.Location = New System.Drawing.Point(672, 545)
        Me.TotalGeral.MaxLength = 10
        Me.TotalGeral.Name = "TotalGeral"
        Me.TotalGeral.PreencherZeroEsqueda = False
        Me.TotalGeral.RegraValidação = Nothing
        Me.TotalGeral.RegraValidaçãoMensagem = Nothing
        Me.TotalGeral.Size = New System.Drawing.Size(153, 23)
        Me.TotalGeral.TabIndex = 5
        Me.TotalGeral.TabStop = False
        Me.TotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalGeral.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalGeral.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(601, 545)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(93, 28)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(124, 19)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Pedidos em Abertos"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(93, 3)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(91, 19)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Todos do Dia"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(3, 28)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(81, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Por Cliente"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(84, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Por Período"
        Me.A1.UseVisualStyleBackColor = True
        '
        'Opt1
        '
        Me.Opt1.AutoSize = True
        Me.Opt1.Location = New System.Drawing.Point(3, 3)
        Me.Opt1.Name = "Opt1"
        Me.Opt1.Size = New System.Drawing.Size(108, 19)
        Me.Opt1.TabIndex = 4
        Me.Opt1.TabStop = True
        Me.Opt1.Text = "Vendas Internas"
        Me.Opt1.UseVisualStyleBackColor = True
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Controls.Add(Me.Label5)
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Location = New System.Drawing.Point(369, 12)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(291, 32)
        Me.PainelPeriodo.TabIndex = 8
        '
        'PainelCliente
        '
        Me.PainelCliente.Controls.Add(Me.Cli)
        Me.PainelCliente.Controls.Add(Me.Label2)
        Me.PainelCliente.Controls.Add(Me.CliDesc)
        Me.PainelCliente.Location = New System.Drawing.Point(369, 59)
        Me.PainelCliente.Name = "PainelCliente"
        Me.PainelCliente.Size = New System.Drawing.Size(512, 32)
        Me.PainelCliente.TabIndex = 9
        '
        'Cli
        '
        Me.Cli.AceitaColarTexto = True
        Me.Cli.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cli.CasasDecimais = 0
        Me.Cli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cli.CPObrigatorio = False
        Me.Cli.CPObrigatorioMsg = Nothing
        Me.Cli.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cli.FlatBorder = False
        Me.Cli.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cli.FocusColor = System.Drawing.Color.Empty
        Me.Cli.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cli.HighlightBorderOnEnter = False
        Me.Cli.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cli.Location = New System.Drawing.Point(70, 5)
        Me.Cli.MaxLength = 30
        Me.Cli.Name = "Cli"
        Me.Cli.PreencherZeroEsqueda = False
        Me.Cli.RegraValidação = Nothing
        Me.Cli.RegraValidaçãoMensagem = Nothing
        Me.Cli.Size = New System.Drawing.Size(74, 23)
        Me.Cli.TabIndex = 1
        Me.Cli.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cli.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CliDesc
        '
        Me.CliDesc.AceitaColarTexto = True
        Me.CliDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CliDesc.CasasDecimais = 0
        Me.CliDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CliDesc.CPObrigatorio = False
        Me.CliDesc.CPObrigatorioMsg = Nothing
        Me.CliDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CliDesc.FlatBorder = False
        Me.CliDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CliDesc.FocusColor = System.Drawing.Color.Empty
        Me.CliDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.CliDesc.HighlightBorderOnEnter = False
        Me.CliDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CliDesc.Location = New System.Drawing.Point(152, 5)
        Me.CliDesc.MaxLength = 30
        Me.CliDesc.Name = "CliDesc"
        Me.CliDesc.PreencherZeroEsqueda = False
        Me.CliDesc.RegraValidação = Nothing
        Me.CliDesc.RegraValidaçãoMensagem = Nothing
        Me.CliDesc.Size = New System.Drawing.Size(357, 23)
        Me.CliDesc.TabIndex = 2
        Me.CliDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CliDesc.ValorPadrao = Nothing
        '
        'Opt2
        '
        Me.Opt2.AutoSize = True
        Me.Opt2.Checked = True
        Me.Opt2.Location = New System.Drawing.Point(3, 28)
        Me.Opt2.Name = "Opt2"
        Me.Opt2.Size = New System.Drawing.Size(61, 19)
        Me.Opt2.TabIndex = 4
        Me.Opt2.TabStop = True
        Me.Opt2.Text = "Vendas"
        Me.Opt2.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel2)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.PainelCliente)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.PainelPeriodo)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.TotalGeral)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(893, 576)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 11
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(801, 3)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(80, 26)
        Me.btFechar.TabIndex = 13
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Opt2)
        Me.GroupPanel2.Controls.Add(Me.Opt1)
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(123, 79)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 12
        Me.GroupPanel2.Text = "Tipo de Pesquisa"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Location = New System.Drawing.Point(141, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(221, 79)
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
        Me.GroupPanel1.TabIndex = 11
        Me.GroupPanel1.Text = "Critério de Pesquisa"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'PedidoVendaFaturamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(893, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PedidoVendaFaturamento"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizador de Vendas - T183"
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.PainelCliente.ResumeLayout(False)
        Me.PainelCliente.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents TotalGeral As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents PainelCliente As System.Windows.Forms.Panel
    Friend WithEvents Cli As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CliDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
