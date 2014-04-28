<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoRelat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProdutoRelat))
        Me.PainelGrupo = New System.Windows.Forms.Panel()
        Me.TodosGrupoLabel = New System.Windows.Forms.Label()
        Me.GrupoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grupo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelProduto = New System.Windows.Forms.Panel()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindProduto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.PainelListaPreco = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListaPrecoSelect = New System.Windows.Forms.DomainUpDown()
        Me.PainelLocalizacao = New System.Windows.Forms.Panel()
        Me.Local = New CBOAutoCompleteFocus.CboFocus()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Visualizar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A42 = New System.Windows.Forms.RadioButton()
        Me.A41 = New System.Windows.Forms.RadioButton()
        Me.A40 = New System.Windows.Forms.RadioButton()
        Me.A33 = New System.Windows.Forms.RadioButton()
        Me.A32 = New System.Windows.Forms.RadioButton()
        Me.A31 = New System.Windows.Forms.RadioButton()
        Me.btHelpCurvaAbc = New System.Windows.Forms.Label()
        Me.A30 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.A22 = New System.Windows.Forms.RadioButton()
        Me.A21 = New System.Windows.Forms.RadioButton()
        Me.A20 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.A6 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.A34 = New System.Windows.Forms.RadioButton()
        Me.A7 = New System.Windows.Forms.RadioButton()
        Me.A8 = New System.Windows.Forms.RadioButton()
        Me.A9 = New System.Windows.Forms.RadioButton()
        Me.A5 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.rdb_qtd_vendida = New System.Windows.Forms.RadioButton()
        Me.PainelGrupo.SuspendLayout()
        Me.PainelProduto.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.PainelListaPreco.SuspendLayout()
        Me.PainelLocalizacao.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PainelGrupo
        '
        Me.PainelGrupo.Controls.Add(Me.TodosGrupoLabel)
        Me.PainelGrupo.Controls.Add(Me.GrupoDesc)
        Me.PainelGrupo.Controls.Add(Me.Label1)
        Me.PainelGrupo.Controls.Add(Me.Grupo)
        Me.PainelGrupo.Location = New System.Drawing.Point(7, 284)
        Me.PainelGrupo.Name = "PainelGrupo"
        Me.PainelGrupo.Size = New System.Drawing.Size(540, 56)
        Me.PainelGrupo.TabIndex = 1
        Me.PainelGrupo.Visible = False
        '
        'TodosGrupoLabel
        '
        Me.TodosGrupoLabel.Location = New System.Drawing.Point(215, 3)
        Me.TodosGrupoLabel.Name = "TodosGrupoLabel"
        Me.TodosGrupoLabel.Size = New System.Drawing.Size(195, 19)
        Me.TodosGrupoLabel.TabIndex = 2
        Me.TodosGrupoLabel.Text = "<--Não informar para TODOS"
        Me.TodosGrupoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GrupoDesc
        '
        Me.GrupoDesc.AceitaColarTexto = True
        Me.GrupoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.GrupoDesc.CasasDecimais = 0
        Me.GrupoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GrupoDesc.CPObrigatorio = False
        Me.GrupoDesc.CPObrigatorioMsg = Nothing
        Me.GrupoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.GrupoDesc.FlatBorder = False
        Me.GrupoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.GrupoDesc.FocusColor = System.Drawing.Color.Empty
        Me.GrupoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.GrupoDesc.HighlightBorderOnEnter = False
        Me.GrupoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.GrupoDesc.Location = New System.Drawing.Point(132, 29)
        Me.GrupoDesc.Name = "GrupoDesc"
        Me.GrupoDesc.PreencherZeroEsqueda = False
        Me.GrupoDesc.RegraValidação = Nothing
        Me.GrupoDesc.RegraValidaçãoMensagem = Nothing
        Me.GrupoDesc.Size = New System.Drawing.Size(404, 23)
        Me.GrupoDesc.TabIndex = 3
        Me.GrupoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.GrupoDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe o Grupo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Grupo
        '
        Me.Grupo.AceitaColarTexto = True
        Me.Grupo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Grupo.CasasDecimais = 0
        Me.Grupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Grupo.CPObrigatorio = False
        Me.Grupo.CPObrigatorioMsg = Nothing
        Me.Grupo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Grupo.FlatBorder = False
        Me.Grupo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Grupo.FocusColor = System.Drawing.Color.Empty
        Me.Grupo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Grupo.HighlightBorderOnEnter = False
        Me.Grupo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Grupo.Location = New System.Drawing.Point(132, 3)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.PreencherZeroEsqueda = False
        Me.Grupo.RegraValidação = Nothing
        Me.Grupo.RegraValidaçãoMensagem = Nothing
        Me.Grupo.Size = New System.Drawing.Size(75, 23)
        Me.Grupo.TabIndex = 1
        Me.Grupo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Grupo.ValorPadrao = Nothing
        '
        'PainelProduto
        '
        Me.PainelProduto.Controls.Add(Me.ProdutoDesc)
        Me.PainelProduto.Controls.Add(Me.Produto)
        Me.PainelProduto.Controls.Add(Me.btFindProduto)
        Me.PainelProduto.Controls.Add(Me.Label2)
        Me.PainelProduto.Location = New System.Drawing.Point(7, 340)
        Me.PainelProduto.Name = "PainelProduto"
        Me.PainelProduto.Size = New System.Drawing.Size(540, 31)
        Me.PainelProduto.TabIndex = 2
        Me.PainelProduto.Visible = False
        '
        'ProdutoDesc
        '
        Me.ProdutoDesc.AceitaColarTexto = True
        Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ProdutoDesc.CasasDecimais = 0
        Me.ProdutoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoDesc.CPObrigatorio = False
        Me.ProdutoDesc.CPObrigatorioMsg = Nothing
        Me.ProdutoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoDesc.FlatBorder = False
        Me.ProdutoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.FocusColor = System.Drawing.Color.Empty
        Me.ProdutoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDesc.HighlightBorderOnEnter = False
        Me.ProdutoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.Location = New System.Drawing.Point(227, 3)
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.ReadOnly = True
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(309, 23)
        Me.ProdutoDesc.TabIndex = 2
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
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
        Me.Produto.FocusColor = System.Drawing.Color.Empty
        Me.Produto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Produto.HighlightBorderOnEnter = False
        Me.Produto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Produto.Location = New System.Drawing.Point(132, 3)
        Me.Produto.Name = "Produto"
        Me.Produto.PreencherZeroEsqueda = False
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(75, 23)
        Me.Produto.TabIndex = 1
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
        '
        'btFindProduto
        '
        Me.btFindProduto.Image = CType(resources.GetObject("btFindProduto.Image"), System.Drawing.Image)
        Me.btFindProduto.Location = New System.Drawing.Point(207, 6)
        Me.btFindProduto.Name = "btFindProduto"
        Me.btFindProduto.Size = New System.Drawing.Size(19, 20)
        Me.btFindProduto.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Informe o Produto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label5)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(7, 373)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(540, 34)
        Me.PainelPeriodo.TabIndex = 3
        Me.PainelPeriodo.Visible = False
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
        Me.DataFinal.Location = New System.Drawing.Point(243, 3)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(103, 23)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Informe o Período"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.DataInicial.Location = New System.Drawing.Point(132, 3)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(103, 23)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.PainelListaPreco)
        Me.Fundo.Controls.Add(Me.PainelLocalizacao)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Visualizar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.PainelPeriodo)
        Me.Fundo.Controls.Add(Me.PainelProduto)
        Me.Fundo.Controls.Add(Me.PainelGrupo)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(552, 507)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'PainelListaPreco
        '
        Me.PainelListaPreco.Controls.Add(Me.Label7)
        Me.PainelListaPreco.Controls.Add(Me.ListaPrecoSelect)
        Me.PainelListaPreco.Location = New System.Drawing.Point(7, 453)
        Me.PainelListaPreco.Name = "PainelListaPreco"
        Me.PainelListaPreco.Size = New System.Drawing.Size(272, 34)
        Me.PainelListaPreco.TabIndex = 8
        Me.PainelListaPreco.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Informe a Seleção"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListaPrecoSelect
        '
        Me.ListaPrecoSelect.Items.Add("Itens que pertence a Lista de Preço")
        Me.ListaPrecoSelect.Items.Add("Itens que estão Fora da Lista de Preço")
        Me.ListaPrecoSelect.Items.Add("Lista de Preço - Atacado")
        Me.ListaPrecoSelect.Items.Add("Todos os itens")
        Me.ListaPrecoSelect.Location = New System.Drawing.Point(133, 5)
        Me.ListaPrecoSelect.Name = "ListaPrecoSelect"
        Me.ListaPrecoSelect.Size = New System.Drawing.Size(283, 23)
        Me.ListaPrecoSelect.TabIndex = 7
        '
        'PainelLocalizacao
        '
        Me.PainelLocalizacao.Controls.Add(Me.Local)
        Me.PainelLocalizacao.Controls.Add(Me.Label3)
        Me.PainelLocalizacao.Location = New System.Drawing.Point(7, 413)
        Me.PainelLocalizacao.Name = "PainelLocalizacao"
        Me.PainelLocalizacao.Size = New System.Drawing.Size(540, 34)
        Me.PainelLocalizacao.TabIndex = 6
        Me.PainelLocalizacao.Visible = False
        '
        'Local
        '
        Me.Local.Auto_Complete = False
        Me.Local.AutoLimitar_Lista = False
        Me.Local.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.Local.CPObrigatorio = False
        Me.Local.CPObrigatorioMsg = Nothing
        Me.Local.FlatBorder = False
        Me.Local.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Local.FormattingEnabled = True
        Me.Local.HighlightBorderColor = System.Drawing.Color.Empty
        Me.Local.HighlightBorderOnEnter = False
        Me.Local.Location = New System.Drawing.Point(132, 1)
        Me.Local.Name = "Local"
        Me.Local.Size = New System.Drawing.Size(214, 23)
        Me.Local.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Informe o Local"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(429, 471)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(114, 30)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar"
        '
        'Visualizar
        '
        Me.Visualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Visualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Visualizar.Location = New System.Drawing.Point(285, 471)
        Me.Visualizar.Name = "Visualizar"
        Me.Visualizar.Size = New System.Drawing.Size(138, 31)
        Me.Visualizar.TabIndex = 4
        Me.Visualizar.Text = "Visualizar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rdb_qtd_vendida)
        Me.GroupPanel1.Controls.Add(Me.A42)
        Me.GroupPanel1.Controls.Add(Me.A41)
        Me.GroupPanel1.Controls.Add(Me.A40)
        Me.GroupPanel1.Controls.Add(Me.A33)
        Me.GroupPanel1.Controls.Add(Me.A32)
        Me.GroupPanel1.Controls.Add(Me.A31)
        Me.GroupPanel1.Controls.Add(Me.btHelpCurvaAbc)
        Me.GroupPanel1.Controls.Add(Me.A30)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.A22)
        Me.GroupPanel1.Controls.Add(Me.A21)
        Me.GroupPanel1.Controls.Add(Me.A20)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.A6)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A34)
        Me.GroupPanel1.Controls.Add(Me.A7)
        Me.GroupPanel1.Controls.Add(Me.A8)
        Me.GroupPanel1.Controls.Add(Me.A9)
        Me.GroupPanel1.Controls.Add(Me.A5)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Location = New System.Drawing.Point(6, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(537, 275)
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
        Me.GroupPanel1.Text = "Opções"
        '
        'A42
        '
        Me.A42.AutoSize = True
        Me.A42.Location = New System.Drawing.Point(364, 111)
        Me.A42.Name = "A42"
        Me.A42.Size = New System.Drawing.Size(110, 19)
        Me.A42.TabIndex = 18
        Me.A42.TabStop = True
        Me.A42.Text = "Valor do Estoque"
        Me.A42.UseVisualStyleBackColor = True
        '
        'A41
        '
        Me.A41.AutoSize = True
        Me.A41.Location = New System.Drawing.Point(14, 113)
        Me.A41.Name = "A41"
        Me.A41.Size = New System.Drawing.Size(164, 19)
        Me.A41.TabIndex = 17
        Me.A41.TabStop = True
        Me.A41.Text = "Saida de Produtos [Grupos]"
        Me.A41.UseVisualStyleBackColor = True
        '
        'A40
        '
        Me.A40.AutoSize = True
        Me.A40.Location = New System.Drawing.Point(14, 90)
        Me.A40.Name = "A40"
        Me.A40.Size = New System.Drawing.Size(166, 19)
        Me.A40.TabIndex = 17
        Me.A40.TabStop = True
        Me.A40.Text = "Saida de Produtos [Marcas]"
        Me.A40.UseVisualStyleBackColor = True
        '
        'A33
        '
        Me.A33.AutoSize = True
        Me.A33.Location = New System.Drawing.Point(364, 188)
        Me.A33.Name = "A33"
        Me.A33.Size = New System.Drawing.Size(139, 19)
        Me.A33.TabIndex = 16
        Me.A33.TabStop = True
        Me.A33.Text = "Produtos com impostos"
        Me.A33.UseVisualStyleBackColor = True
        '
        'A32
        '
        Me.A32.Image = CType(resources.GetObject("A32.Image"), System.Drawing.Image)
        Me.A32.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.A32.Location = New System.Drawing.Point(364, 162)
        Me.A32.Name = "A32"
        Me.A32.Size = New System.Drawing.Size(127, 24)
        Me.A32.TabIndex = 15
        Me.A32.TabStop = True
        Me.A32.Text = "Análise de Saída"
        Me.A32.UseVisualStyleBackColor = True
        '
        'A31
        '
        Me.A31.AutoSize = True
        Me.A31.Location = New System.Drawing.Point(364, 138)
        Me.A31.Name = "A31"
        Me.A31.Size = New System.Drawing.Size(174, 19)
        Me.A31.TabIndex = 15
        Me.A31.TabStop = True
        Me.A31.Text = "Análise de Produtos Vendidos"
        Me.A31.UseVisualStyleBackColor = True
        '
        'btHelpCurvaAbc
        '
        Me.btHelpCurvaAbc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btHelpCurvaAbc.Image = CType(resources.GetObject("btHelpCurvaAbc.Image"), System.Drawing.Image)
        Me.btHelpCurvaAbc.Location = New System.Drawing.Point(100, 220)
        Me.btHelpCurvaAbc.Name = "btHelpCurvaAbc"
        Me.btHelpCurvaAbc.Size = New System.Drawing.Size(23, 19)
        Me.SuperTooltip1.SetSuperTooltip(Me.btHelpCurvaAbc, New DevComponents.DotNetBar.SuperTooltipInfo("Ajuda para compreender a Curva ABC", "Up Sistemas ", resources.GetString("btHelpCurvaAbc.SuperTooltip"), CType(resources.GetObject("btHelpCurvaAbc.SuperTooltip1"), System.Drawing.Image), Nothing, DevComponents.DotNetBar.eTooltipColor.Office2003, True, True, New System.Drawing.Size(771, 391)))
        Me.btHelpCurvaAbc.TabIndex = 14
        '
        'A30
        '
        Me.A30.AutoSize = True
        Me.A30.Location = New System.Drawing.Point(14, 220)
        Me.A30.Name = "A30"
        Me.A30.Size = New System.Drawing.Size(80, 19)
        Me.A30.TabIndex = 13
        Me.A30.TabStop = True
        Me.A30.Text = "Curva ABC"
        Me.A30.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(-6, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(542, 1)
        Me.Label6.TabIndex = 12
        '
        'A22
        '
        Me.A22.AutoSize = True
        Me.A22.Location = New System.Drawing.Point(14, 188)
        Me.A22.Name = "A22"
        Me.A22.Size = New System.Drawing.Size(224, 19)
        Me.A22.TabIndex = 11
        Me.A22.TabStop = True
        Me.A22.Text = "Produtos em Estoque Mínimo por Grupo"
        Me.A22.UseVisualStyleBackColor = True
        '
        'A21
        '
        Me.A21.AutoSize = True
        Me.A21.Location = New System.Drawing.Point(14, 163)
        Me.A21.Name = "A21"
        Me.A21.Size = New System.Drawing.Size(165, 19)
        Me.A21.TabIndex = 10
        Me.A21.TabStop = True
        Me.A21.Text = "Produto em Estoque Mínimo"
        Me.A21.UseVisualStyleBackColor = True
        '
        'A20
        '
        Me.A20.AutoSize = True
        Me.A20.Location = New System.Drawing.Point(14, 138)
        Me.A20.Name = "A20"
        Me.A20.Size = New System.Drawing.Size(201, 19)
        Me.A20.TabIndex = 9
        Me.A20.TabStop = True
        Me.A20.Text = "Produtos em Estoque Mínimo Geral"
        Me.A20.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(-5, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(542, 1)
        Me.Label4.TabIndex = 8
        '
        'A6
        '
        Me.A6.AutoSize = True
        Me.A6.Location = New System.Drawing.Point(364, 67)
        Me.A6.Name = "A6"
        Me.A6.Size = New System.Drawing.Size(117, 19)
        Me.A6.TabIndex = 5
        Me.A6.TabStop = True
        Me.A6.Text = "Produtos com Foto"
        Me.A6.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(14, -3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(118, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Produto por Grupo"
        Me.A1.UseVisualStyleBackColor = True
        '
        'A34
        '
        Me.A34.AutoSize = True
        Me.A34.Location = New System.Drawing.Point(364, 47)
        Me.A34.Name = "A34"
        Me.A34.Size = New System.Drawing.Size(161, 19)
        Me.A34.TabIndex = 3
        Me.A34.TabStop = True
        Me.A34.Text = "Lista de Preços  por Marca"
        Me.A34.UseVisualStyleBackColor = True
        '
        'A7
        '
        Me.A7.AutoSize = True
        Me.A7.Location = New System.Drawing.Point(364, 25)
        Me.A7.Name = "A7"
        Me.A7.Size = New System.Drawing.Size(102, 19)
        Me.A7.TabIndex = 3
        Me.A7.TabStop = True
        Me.A7.Text = "Lista de Preços"
        Me.A7.UseVisualStyleBackColor = True
        '
        'A8
        '
        Me.A8.AutoSize = True
        Me.A8.Location = New System.Drawing.Point(364, 3)
        Me.A8.Name = "A8"
        Me.A8.Size = New System.Drawing.Size(127, 19)
        Me.A8.TabIndex = 1
        Me.A8.TabStop = True
        Me.A8.Text = "Produtos por Código"
        Me.A8.UseVisualStyleBackColor = True
        '
        'A9
        '
        Me.A9.AutoSize = True
        Me.A9.Location = New System.Drawing.Point(364, 89)
        Me.A9.Name = "A9"
        Me.A9.Size = New System.Drawing.Size(119, 19)
        Me.A9.TabIndex = 6
        Me.A9.TabStop = True
        Me.A9.Text = "Produtos por Local"
        Me.A9.UseVisualStyleBackColor = True
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(14, 68)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(142, 19)
        Me.A5.TabIndex = 7
        Me.A5.TabStop = True
        Me.A5.Text = "Produtos Alfanumérica"
        Me.A5.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(14, 22)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(224, 19)
        Me.A2.TabIndex = 2
        Me.A2.TabStop = True
        Me.A2.Text = "Análise de Compra e Venda por Produto"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(14, 47)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(281, 19)
        Me.A3.TabIndex = 4
        Me.A3.TabStop = True
        Me.A3.Text = "Análise de Compra e Venda por Produto no Período"
        Me.A3.UseVisualStyleBackColor = True
        '
        'rdb_qtd_vendida
        '
        Me.rdb_qtd_vendida.AutoSize = True
        Me.rdb_qtd_vendida.Location = New System.Drawing.Point(153, 223)
        Me.rdb_qtd_vendida.Name = "rdb_qtd_vendida"
        Me.rdb_qtd_vendida.Size = New System.Drawing.Size(191, 19)
        Me.rdb_qtd_vendida.TabIndex = 19
        Me.rdb_qtd_vendida.TabStop = True
        Me.rdb_qtd_vendida.Text = "Quantidade Vendida por Produto"
        Me.rdb_qtd_vendida.UseVisualStyleBackColor = True
        '
        'ProdutoRelat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(552, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProdutoRelat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Produtos - T024"
        Me.PainelGrupo.ResumeLayout(False)
        Me.PainelGrupo.PerformLayout()
        Me.PainelProduto.ResumeLayout(False)
        Me.PainelProduto.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.PainelListaPreco.ResumeLayout(False)
        Me.PainelLocalizacao.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PainelGrupo As System.Windows.Forms.Panel
    Friend WithEvents GrupoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grupo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PainelProduto As System.Windows.Forms.Panel
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TodosGrupoLabel As System.Windows.Forms.Label
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Visualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents A6 As System.Windows.Forms.RadioButton
    Friend WithEvents A7 As System.Windows.Forms.RadioButton
    Friend WithEvents A8 As System.Windows.Forms.RadioButton
    Friend WithEvents A9 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents A22 As System.Windows.Forms.RadioButton
    Friend WithEvents A21 As System.Windows.Forms.RadioButton
    Friend WithEvents A20 As System.Windows.Forms.RadioButton
    Friend WithEvents A30 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btHelpCurvaAbc As System.Windows.Forms.Label
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents btFindProduto As System.Windows.Forms.Label
    Friend WithEvents PainelLocalizacao As System.Windows.Forms.Panel
    Friend WithEvents Local As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents A31 As System.Windows.Forms.RadioButton
    Friend WithEvents A32 As System.Windows.Forms.RadioButton
    Friend WithEvents A33 As System.Windows.Forms.RadioButton
    Friend WithEvents A34 As System.Windows.Forms.RadioButton
    Friend WithEvents ListaPrecoSelect As System.Windows.Forms.DomainUpDown
    Friend WithEvents PainelListaPreco As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents A40 As System.Windows.Forms.RadioButton
    Friend WithEvents A41 As System.Windows.Forms.RadioButton
    Friend WithEvents A42 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_qtd_vendida As System.Windows.Forms.RadioButton
End Class
