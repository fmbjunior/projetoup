<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoMarkup
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Label42 = New System.Windows.Forms.Label
        Me.TipoCalculo = New CBOAutoCompleteFocus.CboFocus
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.ValorCompra = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.mkCustoCompra = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label15 = New System.Windows.Forms.Label
        Me.ValorVenda = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.mkPisVenda = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.mkCofinsVenda = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.mkIpiVenda = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.mkOperador = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.mkMargemLucroVenda = New TexBoxFocusNet.TextBoxFocusNet
        Me.mkIcmsVenda = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.mkComissaoVenda = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.mkOutrosVenda = New TexBoxFocusNet.TextBoxFocusNet
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.PisEntrada = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label13 = New System.Windows.Forms.Label
        Me.CofinsEntrada = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.IcmsEntrada = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label11 = New System.Windows.Forms.Label
        Me.FreteEntrada = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label14 = New System.Windows.Forms.Label
        Me.IpiEntrada = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label16 = New System.Windows.Forms.Label
        Me.btAcharMakup = New DevComponents.DotNetBar.ButtonX
        Me.CodigoProduto = New TexBoxFocusNet.TextBoxFocusNet
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.Fundo.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label42)
        Me.Fundo.Controls.Add(Me.TipoCalculo)
        Me.Fundo.Controls.Add(Me.GroupPanel3)
        Me.Fundo.Controls.Add(Me.GroupPanel2)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.btAcharMakup)
        Me.Fundo.Controls.Add(Me.CodigoProduto)
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(508, 455)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(22, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(122, 23)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Tipo de Calculo"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoCalculo
        '
        Me.TipoCalculo.Auto_Complete = True
        Me.TipoCalculo.AutoLimitar_Lista = True
        Me.TipoCalculo.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.TipoCalculo.CPObrigatorio = False
        Me.TipoCalculo.CPObrigatorioMsg = Nothing
        Me.TipoCalculo.FormattingEnabled = True
        Me.TipoCalculo.Items.AddRange(New Object() {"MARKUP", "DIRETO"})
        Me.TipoCalculo.Location = New System.Drawing.Point(153, 7)
        Me.TipoCalculo.Name = "TipoCalculo"
        Me.TipoCalculo.Size = New System.Drawing.Size(323, 23)
        Me.TipoCalculo.TabIndex = 1
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.ValorCompra)
        Me.GroupPanel3.Controls.Add(Me.Label7)
        Me.GroupPanel3.Controls.Add(Me.mkCustoCompra)
        Me.GroupPanel3.Controls.Add(Me.Label15)
        Me.GroupPanel3.Controls.Add(Me.ValorVenda)
        Me.GroupPanel3.Controls.Add(Me.Label12)
        Me.GroupPanel3.Location = New System.Drawing.Point(13, 318)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(481, 91)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel3.TabIndex = 4
        Me.GroupPanel3.Text = "Resultados"
        '
        'ValorCompra
        '
        Me.ValorCompra.AceitaColarTexto = True
        Me.ValorCompra.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorCompra.CasasDecimais = 3
        Me.ValorCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorCompra.CPObrigatorio = False
        Me.ValorCompra.CPObrigatorioMsg = Nothing
        Me.ValorCompra.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorCompra.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorCompra.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorCompra.Location = New System.Drawing.Point(137, 4)
        Me.ValorCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValorCompra.MaxLength = 10
        Me.ValorCompra.Name = "ValorCompra"
        Me.ValorCompra.PreencherZeroEsqueda = False
        Me.ValorCompra.RegraValidação = Nothing
        Me.ValorCompra.RegraValidaçãoMensagem = Nothing
        Me.ValorCompra.Size = New System.Drawing.Size(88, 23)
        Me.ValorCompra.TabIndex = 1
        Me.ValorCompra.Tag = ""
        Me.ValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorCompra.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorCompra.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Valor de Compra"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mkCustoCompra
        '
        Me.mkCustoCompra.AceitaColarTexto = True
        Me.mkCustoCompra.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.mkCustoCompra.CasasDecimais = 3
        Me.mkCustoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkCustoCompra.CPObrigatorio = False
        Me.mkCustoCompra.CPObrigatorioMsg = Nothing
        Me.mkCustoCompra.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkCustoCompra.FocusColor = System.Drawing.Color.MistyRose
        Me.mkCustoCompra.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkCustoCompra.Location = New System.Drawing.Point(372, 4)
        Me.mkCustoCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkCustoCompra.MaxLength = 10
        Me.mkCustoCompra.Name = "mkCustoCompra"
        Me.mkCustoCompra.PreencherZeroEsqueda = False
        Me.mkCustoCompra.RegraValidação = Nothing
        Me.mkCustoCompra.RegraValidaçãoMensagem = Nothing
        Me.mkCustoCompra.Size = New System.Drawing.Size(88, 23)
        Me.mkCustoCompra.TabIndex = 3
        Me.mkCustoCompra.Tag = ""
        Me.mkCustoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkCustoCompra.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.mkCustoCompra.ValorPadrao = Nothing
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(241, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 19)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Custo Mercadoria"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorVenda
        '
        Me.ValorVenda.AceitaColarTexto = True
        Me.ValorVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorVenda.CasasDecimais = 3
        Me.ValorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorVenda.CPObrigatorio = False
        Me.ValorVenda.CPObrigatorioMsg = Nothing
        Me.ValorVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorVenda.Location = New System.Drawing.Point(372, 35)
        Me.ValorVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValorVenda.MaxLength = 10
        Me.ValorVenda.Name = "ValorVenda"
        Me.ValorVenda.PreencherZeroEsqueda = False
        Me.ValorVenda.RegraValidação = Nothing
        Me.ValorVenda.RegraValidaçãoMensagem = Nothing
        Me.ValorVenda.Size = New System.Drawing.Size(88, 23)
        Me.ValorVenda.TabIndex = 5
        Me.ValorVenda.Tag = ""
        Me.ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorVenda.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(238, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 19)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Valor Venda"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.mkPisVenda)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.Controls.Add(Me.mkCofinsVenda)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.Controls.Add(Me.mkIpiVenda)
        Me.GroupPanel2.Controls.Add(Me.Label8)
        Me.GroupPanel2.Controls.Add(Me.Label6)
        Me.GroupPanel2.Controls.Add(Me.mkOperador)
        Me.GroupPanel2.Controls.Add(Me.Label2)
        Me.GroupPanel2.Controls.Add(Me.mkMargemLucroVenda)
        Me.GroupPanel2.Controls.Add(Me.mkIcmsVenda)
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.Controls.Add(Me.mkComissaoVenda)
        Me.GroupPanel2.Controls.Add(Me.Label9)
        Me.GroupPanel2.Controls.Add(Me.Label10)
        Me.GroupPanel2.Controls.Add(Me.mkOutrosVenda)
        Me.GroupPanel2.Location = New System.Drawing.Point(13, 162)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(481, 150)
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
        Me.GroupPanel2.TabIndex = 3
        Me.GroupPanel2.Text = "Dados da Saída"
        '
        'mkPisVenda
        '
        Me.mkPisVenda.AceitaColarTexto = True
        Me.mkPisVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.mkPisVenda.CasasDecimais = 3
        Me.mkPisVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkPisVenda.CPObrigatorio = False
        Me.mkPisVenda.CPObrigatorioMsg = Nothing
        Me.mkPisVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkPisVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.mkPisVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkPisVenda.Location = New System.Drawing.Point(139, 35)
        Me.mkPisVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkPisVenda.MaxLength = 8
        Me.mkPisVenda.Name = "mkPisVenda"
        Me.mkPisVenda.PreencherZeroEsqueda = False
        Me.mkPisVenda.RegraValidação = Nothing
        Me.mkPisVenda.RegraValidaçãoMensagem = Nothing
        Me.mkPisVenda.Size = New System.Drawing.Size(88, 23)
        Me.mkPisVenda.TabIndex = 5
        Me.mkPisVenda.Tag = ""
        Me.mkPisVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkPisVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.mkPisVenda.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "% Pis"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mkCofinsVenda
        '
        Me.mkCofinsVenda.AceitaColarTexto = True
        Me.mkCofinsVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.mkCofinsVenda.CasasDecimais = 3
        Me.mkCofinsVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkCofinsVenda.CPObrigatorio = False
        Me.mkCofinsVenda.CPObrigatorioMsg = Nothing
        Me.mkCofinsVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkCofinsVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.mkCofinsVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkCofinsVenda.Location = New System.Drawing.Point(372, 35)
        Me.mkCofinsVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkCofinsVenda.MaxLength = 8
        Me.mkCofinsVenda.Name = "mkCofinsVenda"
        Me.mkCofinsVenda.PreencherZeroEsqueda = False
        Me.mkCofinsVenda.RegraValidação = Nothing
        Me.mkCofinsVenda.RegraValidaçãoMensagem = Nothing
        Me.mkCofinsVenda.Size = New System.Drawing.Size(88, 23)
        Me.mkCofinsVenda.TabIndex = 7
        Me.mkCofinsVenda.Tag = ""
        Me.mkCofinsVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkCofinsVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.mkCofinsVenda.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(238, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "% Cofins"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mkIpiVenda
        '
        Me.mkIpiVenda.AceitaColarTexto = True
        Me.mkIpiVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.mkIpiVenda.CasasDecimais = 3
        Me.mkIpiVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkIpiVenda.CPObrigatorio = False
        Me.mkIpiVenda.CPObrigatorioMsg = Nothing
        Me.mkIpiVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkIpiVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.mkIpiVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkIpiVenda.Location = New System.Drawing.Point(372, 4)
        Me.mkIpiVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkIpiVenda.MaxLength = 8
        Me.mkIpiVenda.Name = "mkIpiVenda"
        Me.mkIpiVenda.PreencherZeroEsqueda = False
        Me.mkIpiVenda.RegraValidação = Nothing
        Me.mkIpiVenda.RegraValidaçãoMensagem = Nothing
        Me.mkIpiVenda.Size = New System.Drawing.Size(88, 23)
        Me.mkIpiVenda.TabIndex = 3
        Me.mkIpiVenda.Tag = ""
        Me.mkIpiVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkIpiVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.mkIpiVenda.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(238, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Operador"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "% Margem Lucro"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mkOperador
        '
        Me.mkOperador.AceitaColarTexto = True
        Me.mkOperador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.mkOperador.CasasDecimais = 3
        Me.mkOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkOperador.CPObrigatorio = False
        Me.mkOperador.CPObrigatorioMsg = Nothing
        Me.mkOperador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkOperador.FocusColor = System.Drawing.Color.MistyRose
        Me.mkOperador.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkOperador.Location = New System.Drawing.Point(372, 97)
        Me.mkOperador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkOperador.MaxLength = 8
        Me.mkOperador.Name = "mkOperador"
        Me.mkOperador.PreencherZeroEsqueda = False
        Me.mkOperador.RegraValidação = Nothing
        Me.mkOperador.RegraValidaçãoMensagem = Nothing
        Me.mkOperador.Size = New System.Drawing.Size(88, 23)
        Me.mkOperador.TabIndex = 15
        Me.mkOperador.Tag = ""
        Me.mkOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkOperador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.mkOperador.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(238, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "% Ipi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mkMargemLucroVenda
        '
        Me.mkMargemLucroVenda.AceitaColarTexto = True
        Me.mkMargemLucroVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.mkMargemLucroVenda.CasasDecimais = 3
        Me.mkMargemLucroVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkMargemLucroVenda.CPObrigatorio = False
        Me.mkMargemLucroVenda.CPObrigatorioMsg = Nothing
        Me.mkMargemLucroVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkMargemLucroVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.mkMargemLucroVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkMargemLucroVenda.Location = New System.Drawing.Point(139, 97)
        Me.mkMargemLucroVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkMargemLucroVenda.MaxLength = 8
        Me.mkMargemLucroVenda.Name = "mkMargemLucroVenda"
        Me.mkMargemLucroVenda.PreencherZeroEsqueda = False
        Me.mkMargemLucroVenda.RegraValidação = Nothing
        Me.mkMargemLucroVenda.RegraValidaçãoMensagem = Nothing
        Me.mkMargemLucroVenda.Size = New System.Drawing.Size(88, 23)
        Me.mkMargemLucroVenda.TabIndex = 13
        Me.mkMargemLucroVenda.Tag = ""
        Me.mkMargemLucroVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkMargemLucroVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.mkMargemLucroVenda.ValorPadrao = Nothing
        '
        'mkIcmsVenda
        '
        Me.mkIcmsVenda.AceitaColarTexto = True
        Me.mkIcmsVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.mkIcmsVenda.CasasDecimais = 3
        Me.mkIcmsVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkIcmsVenda.CPObrigatorio = False
        Me.mkIcmsVenda.CPObrigatorioMsg = Nothing
        Me.mkIcmsVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkIcmsVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.mkIcmsVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkIcmsVenda.Location = New System.Drawing.Point(139, 4)
        Me.mkIcmsVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkIcmsVenda.MaxLength = 8
        Me.mkIcmsVenda.Name = "mkIcmsVenda"
        Me.mkIcmsVenda.PreencherZeroEsqueda = False
        Me.mkIcmsVenda.RegraValidação = Nothing
        Me.mkIcmsVenda.RegraValidaçãoMensagem = Nothing
        Me.mkIcmsVenda.Size = New System.Drawing.Size(88, 23)
        Me.mkIcmsVenda.TabIndex = 1
        Me.mkIcmsVenda.Tag = ""
        Me.mkIcmsVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkIcmsVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.mkIcmsVenda.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "% Icms"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mkComissaoVenda
        '
        Me.mkComissaoVenda.AceitaColarTexto = True
        Me.mkComissaoVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.mkComissaoVenda.CasasDecimais = 3
        Me.mkComissaoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkComissaoVenda.CPObrigatorio = False
        Me.mkComissaoVenda.CPObrigatorioMsg = Nothing
        Me.mkComissaoVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkComissaoVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.mkComissaoVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkComissaoVenda.Location = New System.Drawing.Point(139, 66)
        Me.mkComissaoVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkComissaoVenda.MaxLength = 8
        Me.mkComissaoVenda.Name = "mkComissaoVenda"
        Me.mkComissaoVenda.PreencherZeroEsqueda = False
        Me.mkComissaoVenda.RegraValidação = Nothing
        Me.mkComissaoVenda.RegraValidaçãoMensagem = Nothing
        Me.mkComissaoVenda.Size = New System.Drawing.Size(88, 23)
        Me.mkComissaoVenda.TabIndex = 9
        Me.mkComissaoVenda.Tag = ""
        Me.mkComissaoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkComissaoVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.mkComissaoVenda.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(238, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "% Outros"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(5, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "% Comissão"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mkOutrosVenda
        '
        Me.mkOutrosVenda.AceitaColarTexto = True
        Me.mkOutrosVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.mkOutrosVenda.CasasDecimais = 3
        Me.mkOutrosVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mkOutrosVenda.CPObrigatorio = False
        Me.mkOutrosVenda.CPObrigatorioMsg = Nothing
        Me.mkOutrosVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.mkOutrosVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.mkOutrosVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.mkOutrosVenda.Location = New System.Drawing.Point(372, 66)
        Me.mkOutrosVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mkOutrosVenda.MaxLength = 8
        Me.mkOutrosVenda.Name = "mkOutrosVenda"
        Me.mkOutrosVenda.PreencherZeroEsqueda = False
        Me.mkOutrosVenda.RegraValidação = Nothing
        Me.mkOutrosVenda.RegraValidaçãoMensagem = Nothing
        Me.mkOutrosVenda.Size = New System.Drawing.Size(88, 23)
        Me.mkOutrosVenda.TabIndex = 11
        Me.mkOutrosVenda.Tag = ""
        Me.mkOutrosVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mkOutrosVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.mkOutrosVenda.ValorPadrao = Nothing
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PisEntrada)
        Me.GroupPanel1.Controls.Add(Me.Label13)
        Me.GroupPanel1.Controls.Add(Me.CofinsEntrada)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.IcmsEntrada)
        Me.GroupPanel1.Controls.Add(Me.Label11)
        Me.GroupPanel1.Controls.Add(Me.FreteEntrada)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.IpiEntrada)
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 36)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(481, 120)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Dados da Entrada"
        '
        'PisEntrada
        '
        Me.PisEntrada.AceitaColarTexto = True
        Me.PisEntrada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PisEntrada.CasasDecimais = 3
        Me.PisEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PisEntrada.CPObrigatorio = False
        Me.PisEntrada.CPObrigatorioMsg = Nothing
        Me.PisEntrada.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PisEntrada.FocusColor = System.Drawing.Color.MistyRose
        Me.PisEntrada.FocusColorEnd = System.Drawing.Color.Empty
        Me.PisEntrada.Location = New System.Drawing.Point(138, 4)
        Me.PisEntrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PisEntrada.MaxLength = 8
        Me.PisEntrada.Name = "PisEntrada"
        Me.PisEntrada.PreencherZeroEsqueda = False
        Me.PisEntrada.RegraValidação = Nothing
        Me.PisEntrada.RegraValidaçãoMensagem = Nothing
        Me.PisEntrada.Size = New System.Drawing.Size(88, 23)
        Me.PisEntrada.TabIndex = 1
        Me.PisEntrada.Tag = ""
        Me.PisEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PisEntrada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.PisEntrada.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(4, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "% Pis"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CofinsEntrada
        '
        Me.CofinsEntrada.AceitaColarTexto = True
        Me.CofinsEntrada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CofinsEntrada.CasasDecimais = 3
        Me.CofinsEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CofinsEntrada.CPObrigatorio = False
        Me.CofinsEntrada.CPObrigatorioMsg = Nothing
        Me.CofinsEntrada.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CofinsEntrada.FocusColor = System.Drawing.Color.MistyRose
        Me.CofinsEntrada.FocusColorEnd = System.Drawing.Color.Empty
        Me.CofinsEntrada.Location = New System.Drawing.Point(371, 4)
        Me.CofinsEntrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CofinsEntrada.MaxLength = 8
        Me.CofinsEntrada.Name = "CofinsEntrada"
        Me.CofinsEntrada.PreencherZeroEsqueda = False
        Me.CofinsEntrada.RegraValidação = Nothing
        Me.CofinsEntrada.RegraValidaçãoMensagem = Nothing
        Me.CofinsEntrada.Size = New System.Drawing.Size(88, 23)
        Me.CofinsEntrada.TabIndex = 3
        Me.CofinsEntrada.Tag = ""
        Me.CofinsEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CofinsEntrada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.CofinsEntrada.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(237, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "% Cofins"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IcmsEntrada
        '
        Me.IcmsEntrada.AceitaColarTexto = True
        Me.IcmsEntrada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IcmsEntrada.CasasDecimais = 3
        Me.IcmsEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IcmsEntrada.CPObrigatorio = False
        Me.IcmsEntrada.CPObrigatorioMsg = Nothing
        Me.IcmsEntrada.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IcmsEntrada.FocusColor = System.Drawing.Color.MistyRose
        Me.IcmsEntrada.FocusColorEnd = System.Drawing.Color.Empty
        Me.IcmsEntrada.Location = New System.Drawing.Point(138, 35)
        Me.IcmsEntrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IcmsEntrada.MaxLength = 8
        Me.IcmsEntrada.Name = "IcmsEntrada"
        Me.IcmsEntrada.PreencherZeroEsqueda = False
        Me.IcmsEntrada.RegraValidação = Nothing
        Me.IcmsEntrada.RegraValidaçãoMensagem = Nothing
        Me.IcmsEntrada.Size = New System.Drawing.Size(88, 23)
        Me.IcmsEntrada.TabIndex = 5
        Me.IcmsEntrada.Tag = ""
        Me.IcmsEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IcmsEntrada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.IcmsEntrada.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(4, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 19)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "% Icms"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FreteEntrada
        '
        Me.FreteEntrada.AceitaColarTexto = True
        Me.FreteEntrada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FreteEntrada.CasasDecimais = 3
        Me.FreteEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FreteEntrada.CPObrigatorio = False
        Me.FreteEntrada.CPObrigatorioMsg = Nothing
        Me.FreteEntrada.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FreteEntrada.FocusColor = System.Drawing.Color.MistyRose
        Me.FreteEntrada.FocusColorEnd = System.Drawing.Color.Empty
        Me.FreteEntrada.Location = New System.Drawing.Point(371, 34)
        Me.FreteEntrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FreteEntrada.MaxLength = 8
        Me.FreteEntrada.Name = "FreteEntrada"
        Me.FreteEntrada.PreencherZeroEsqueda = False
        Me.FreteEntrada.RegraValidação = Nothing
        Me.FreteEntrada.RegraValidaçãoMensagem = Nothing
        Me.FreteEntrada.Size = New System.Drawing.Size(88, 23)
        Me.FreteEntrada.TabIndex = 7
        Me.FreteEntrada.Tag = ""
        Me.FreteEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FreteEntrada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.FreteEntrada.ValorPadrao = Nothing
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(237, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 19)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "% Frete"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IpiEntrada
        '
        Me.IpiEntrada.AceitaColarTexto = True
        Me.IpiEntrada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IpiEntrada.CasasDecimais = 3
        Me.IpiEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IpiEntrada.CPObrigatorio = False
        Me.IpiEntrada.CPObrigatorioMsg = Nothing
        Me.IpiEntrada.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IpiEntrada.FocusColor = System.Drawing.Color.MistyRose
        Me.IpiEntrada.FocusColorEnd = System.Drawing.Color.Empty
        Me.IpiEntrada.Location = New System.Drawing.Point(138, 66)
        Me.IpiEntrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IpiEntrada.MaxLength = 8
        Me.IpiEntrada.Name = "IpiEntrada"
        Me.IpiEntrada.PreencherZeroEsqueda = False
        Me.IpiEntrada.RegraValidação = Nothing
        Me.IpiEntrada.RegraValidaçãoMensagem = Nothing
        Me.IpiEntrada.Size = New System.Drawing.Size(88, 23)
        Me.IpiEntrada.TabIndex = 9
        Me.IpiEntrada.Tag = ""
        Me.IpiEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IpiEntrada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.IpiEntrada.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(4, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 19)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "% Ipi"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btAcharMakup
        '
        Me.btAcharMakup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAcharMakup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAcharMakup.Location = New System.Drawing.Point(191, 415)
        Me.btAcharMakup.Name = "btAcharMakup"
        Me.btAcharMakup.Size = New System.Drawing.Size(101, 25)
        Me.btAcharMakup.TabIndex = 6
        Me.btAcharMakup.Text = "Localizar Markup"
        Me.btAcharMakup.Visible = False
        '
        'CodigoProduto
        '
        Me.CodigoProduto.AceitaColarTexto = True
        Me.CodigoProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoProduto.CasasDecimais = 3
        Me.CodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoProduto.CPObrigatorio = False
        Me.CodigoProduto.CPObrigatorioMsg = Nothing
        Me.CodigoProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoProduto.FocusColor = System.Drawing.Color.MistyRose
        Me.CodigoProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoProduto.Location = New System.Drawing.Point(12, 417)
        Me.CodigoProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodigoProduto.MaxLength = 15
        Me.CodigoProduto.Name = "CodigoProduto"
        Me.CodigoProduto.PreencherZeroEsqueda = False
        Me.CodigoProduto.RegraValidação = Nothing
        Me.CodigoProduto.RegraValidaçãoMensagem = Nothing
        Me.CodigoProduto.Size = New System.Drawing.Size(74, 23)
        Me.CodigoProduto.TabIndex = 7
        Me.CodigoProduto.Tag = ""
        Me.CodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CodigoProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoProduto.ValorPadrao = Nothing
        Me.CodigoProduto.Visible = False
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(298, 415)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(107, 25)
        Me.btSalvar.TabIndex = 5
        Me.btSalvar.Text = "Salvar e Fechar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(411, 415)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(83, 25)
        Me.btFechar.TabIndex = 8
        Me.btFechar.Text = "Fechar"
        '
        'ProdutoMarkup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProdutoMarkup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produto Markup"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ValorVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ValorCompra As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CodigoProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btAcharMakup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mkCustoCompra As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents mkPisVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mkCofinsVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mkIpiVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mkOperador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mkMargemLucroVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents mkIcmsVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mkComissaoVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mkOutrosVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PisEntrada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CofinsEntrada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IcmsEntrada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FreteEntrada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents IpiEntrada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TipoCalculo As CBOAutoCompleteFocus.CboFocus
End Class
