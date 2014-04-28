<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoEstoqueAjuste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProdutoEstoqueAjuste))
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EstNFDif = New TexBoxFocusNet.TextBoxFocusNet()
        Me.EstGeralDif = New TexBoxFocusNet.TextBoxFocusNet()
        Me.EstNFReal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EstGeralReal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btFindClintes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstNF = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EstGeral = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.GroupPanel2)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.btAtualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(660, 321)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.Controls.Add(Me.EstNFDif)
        Me.GroupPanel2.Controls.Add(Me.EstGeralDif)
        Me.GroupPanel2.Controls.Add(Me.EstNFReal)
        Me.GroupPanel2.Controls.Add(Me.Label6)
        Me.GroupPanel2.Controls.Add(Me.Label7)
        Me.GroupPanel2.Controls.Add(Me.EstGeralReal)
        Me.GroupPanel2.Location = New System.Drawing.Point(14, 139)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(632, 141)
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
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Informe a Qtd Real do Estoque"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(3, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Diferenças"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstNFDif
        '
        Me.EstNFDif.AceitaColarTexto = True
        Me.EstNFDif.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstNFDif.CasasDecimais = 4
        Me.EstNFDif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstNFDif.CPObrigatorio = False
        Me.EstNFDif.CPObrigatorioMsg = Nothing
        Me.EstNFDif.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstNFDif.FlatBorder = False
        Me.EstNFDif.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstNFDif.FocusColor = System.Drawing.Color.MistyRose
        Me.EstNFDif.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstNFDif.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstNFDif.ForeColor = System.Drawing.Color.Navy
        Me.EstNFDif.HighlightBorderOnEnter = False
        Me.EstNFDif.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstNFDif.Location = New System.Drawing.Point(419, 83)
        Me.EstNFDif.Name = "EstNFDif"
        Me.EstNFDif.PreencherZeroEsqueda = False
        Me.EstNFDif.RegraValidação = Nothing
        Me.EstNFDif.RegraValidaçãoMensagem = Nothing
        Me.EstNFDif.Size = New System.Drawing.Size(202, 30)
        Me.EstNFDif.TabIndex = 6
        Me.EstNFDif.TabStop = False
        Me.EstNFDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstNFDif.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EstNFDif.ValorPadrao = Nothing
        '
        'EstGeralDif
        '
        Me.EstGeralDif.AceitaColarTexto = True
        Me.EstGeralDif.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstGeralDif.CasasDecimais = 4
        Me.EstGeralDif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstGeralDif.CPObrigatorio = False
        Me.EstGeralDif.CPObrigatorioMsg = Nothing
        Me.EstGeralDif.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstGeralDif.FlatBorder = False
        Me.EstGeralDif.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstGeralDif.FocusColor = System.Drawing.Color.MistyRose
        Me.EstGeralDif.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstGeralDif.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstGeralDif.ForeColor = System.Drawing.Color.Navy
        Me.EstGeralDif.HighlightBorderOnEnter = False
        Me.EstGeralDif.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstGeralDif.Location = New System.Drawing.Point(3, 83)
        Me.EstGeralDif.Name = "EstGeralDif"
        Me.EstGeralDif.PreencherZeroEsqueda = False
        Me.EstGeralDif.RegraValidação = Nothing
        Me.EstGeralDif.RegraValidaçãoMensagem = Nothing
        Me.EstGeralDif.Size = New System.Drawing.Size(199, 30)
        Me.EstGeralDif.TabIndex = 5
        Me.EstGeralDif.TabStop = False
        Me.EstGeralDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstGeralDif.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EstGeralDif.ValorPadrao = Nothing
        '
        'EstNFReal
        '
        Me.EstNFReal.AceitaColarTexto = True
        Me.EstNFReal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EstNFReal.CasasDecimais = 4
        Me.EstNFReal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstNFReal.CPObrigatorio = False
        Me.EstNFReal.CPObrigatorioMsg = Nothing
        Me.EstNFReal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstNFReal.FlatBorder = False
        Me.EstNFReal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstNFReal.FocusColor = System.Drawing.Color.MistyRose
        Me.EstNFReal.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstNFReal.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstNFReal.ForeColor = System.Drawing.Color.Green
        Me.EstNFReal.HighlightBorderOnEnter = False
        Me.EstNFReal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstNFReal.Location = New System.Drawing.Point(419, 30)
        Me.EstNFReal.MaxLength = 15
        Me.EstNFReal.Name = "EstNFReal"
        Me.EstNFReal.PreencherZeroEsqueda = False
        Me.EstNFReal.RegraValidação = Nothing
        Me.EstNFReal.RegraValidaçãoMensagem = Nothing
        Me.EstNFReal.Size = New System.Drawing.Size(202, 30)
        Me.EstNFReal.TabIndex = 3
        Me.EstNFReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstNFReal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.EstNFReal.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(419, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Est. NF Real"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(3, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Est. Geral Real"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstGeralReal
        '
        Me.EstGeralReal.AceitaColarTexto = True
        Me.EstGeralReal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EstGeralReal.CasasDecimais = 4
        Me.EstGeralReal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstGeralReal.CPObrigatorio = False
        Me.EstGeralReal.CPObrigatorioMsg = Nothing
        Me.EstGeralReal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstGeralReal.FlatBorder = False
        Me.EstGeralReal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstGeralReal.FocusColor = System.Drawing.Color.MistyRose
        Me.EstGeralReal.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstGeralReal.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstGeralReal.ForeColor = System.Drawing.Color.Green
        Me.EstGeralReal.HighlightBorderOnEnter = False
        Me.EstGeralReal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstGeralReal.Location = New System.Drawing.Point(3, 30)
        Me.EstGeralReal.MaxLength = 15
        Me.EstGeralReal.Name = "EstGeralReal"
        Me.EstGeralReal.PreencherZeroEsqueda = False
        Me.EstGeralReal.RegraValidação = Nothing
        Me.EstGeralReal.RegraValidaçãoMensagem = Nothing
        Me.EstGeralReal.Size = New System.Drawing.Size(199, 30)
        Me.EstGeralReal.TabIndex = 2
        Me.EstGeralReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstGeralReal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.EstGeralReal.ValorPadrao = Nothing
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btFindClintes)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.EstNF)
        Me.GroupPanel1.Controls.Add(Me.Produto)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.ProdutoDesc)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.EstGeral)
        Me.GroupPanel1.Location = New System.Drawing.Point(14, 11)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(632, 120)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Selecione um Produto para Atualizar"
        '
        'btFindClintes
        '
        Me.btFindClintes.Image = CType(resources.GetObject("btFindClintes.Image"), System.Drawing.Image)
        Me.btFindClintes.Location = New System.Drawing.Point(76, 18)
        Me.btFindClintes.Name = "btFindClintes"
        Me.btFindClintes.Size = New System.Drawing.Size(23, 23)
        Me.btFindClintes.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe o Produto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstNF
        '
        Me.EstNF.AceitaColarTexto = True
        Me.EstNF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstNF.CasasDecimais = 4
        Me.EstNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstNF.CPObrigatorio = False
        Me.EstNF.CPObrigatorioMsg = Nothing
        Me.EstNF.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstNF.FlatBorder = False
        Me.EstNF.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstNF.FocusColor = System.Drawing.Color.MistyRose
        Me.EstNF.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstNF.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstNF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EstNF.HighlightBorderOnEnter = False
        Me.EstNF.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstNF.Location = New System.Drawing.Point(419, 62)
        Me.EstNF.Name = "EstNF"
        Me.EstNF.PreencherZeroEsqueda = False
        Me.EstNF.RegraValidação = Nothing
        Me.EstNF.RegraValidaçãoMensagem = Nothing
        Me.EstNF.Size = New System.Drawing.Size(202, 30)
        Me.EstNF.TabIndex = 7
        Me.EstNF.TabStop = False
        Me.EstNF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstNF.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EstNF.ValorPadrao = Nothing
        '
        'Produto
        '
        Me.Produto.AceitaColarTexto = True
        Me.Produto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Produto.CasasDecimais = 0
        Me.Produto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Produto.CPObrigatorio = False
        Me.Produto.CPObrigatorioMsg = Nothing
        Me.Produto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Produto.FlatBorder = False
        Me.Produto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Produto.FocusColor = System.Drawing.Color.MistyRose
        Me.Produto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Produto.HighlightBorderOnEnter = False
        Me.Produto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Produto.Location = New System.Drawing.Point(3, 18)
        Me.Produto.Name = "Produto"
        Me.Produto.PreencherZeroEsqueda = False
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(70, 23)
        Me.Produto.TabIndex = 1
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(419, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Estoque NF"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProdutoDesc
        '
        Me.ProdutoDesc.AceitaColarTexto = False
        Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdutoDesc.CasasDecimais = 0
        Me.ProdutoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoDesc.CPObrigatorio = False
        Me.ProdutoDesc.CPObrigatorioMsg = Nothing
        Me.ProdutoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoDesc.FlatBorder = False
        Me.ProdutoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ProdutoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDesc.HighlightBorderOnEnter = False
        Me.ProdutoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.Location = New System.Drawing.Point(103, 18)
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(518, 23)
        Me.ProdutoDesc.TabIndex = 3
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Estoque Geral"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstGeral
        '
        Me.EstGeral.AceitaColarTexto = True
        Me.EstGeral.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstGeral.CasasDecimais = 4
        Me.EstGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstGeral.CPObrigatorio = False
        Me.EstGeral.CPObrigatorioMsg = Nothing
        Me.EstGeral.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstGeral.FlatBorder = False
        Me.EstGeral.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstGeral.FocusColor = System.Drawing.Color.MistyRose
        Me.EstGeral.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstGeral.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstGeral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EstGeral.HighlightBorderOnEnter = False
        Me.EstGeral.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstGeral.Location = New System.Drawing.Point(3, 62)
        Me.EstGeral.Name = "EstGeral"
        Me.EstGeral.PreencherZeroEsqueda = False
        Me.EstGeral.RegraValidação = Nothing
        Me.EstGeral.RegraValidaçãoMensagem = Nothing
        Me.EstGeral.Size = New System.Drawing.Size(199, 30)
        Me.EstGeral.TabIndex = 6
        Me.EstGeral.TabStop = False
        Me.EstGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstGeral.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EstGeral.ValorPadrao = Nothing
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Location = New System.Drawing.Point(436, 286)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(101, 27)
        Me.btAtualizar.TabIndex = 2
        Me.btAtualizar.Text = "Atualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(545, 286)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(101, 27)
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar"
        '
        'ProdutoEstoqueAjuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProdutoEstoqueAjuste"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste de Estoque  - T013"
        Me.Fundo.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EstNF As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EstGeral As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EstNFDif As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EstGeralDif As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EstNFReal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EstGeralReal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindClintes As System.Windows.Forms.Label
End Class
