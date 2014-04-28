<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstoqueTransferencia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstoqueTransferencia))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Confirmado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btFindJuros = New System.Windows.Forms.Label()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.EstDeposito = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EstVenda = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CodigoProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.Usuario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DescTransf = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QtdTransf = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Confirmado)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.Usuario)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.DescTransf)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.DataLancamento)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.QtdTransf)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(645, 384)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Confirmado
        '
        '
        '
        '
        Me.Confirmado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Confirmado.Location = New System.Drawing.Point(379, 306)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(100, 23)
        Me.Confirmado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Confirmado.TabIndex = 12
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.Visible = False
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(360, 346)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(86, 29)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 13
        Me.btSalvar.Text = "Salvar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(452, 346)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(86, 29)
        Me.btNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNovo.TabIndex = 14
        Me.btNovo.Text = "Novo"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.btFindJuros)
        Me.PanelEx2.Controls.Add(Me.ProdutoDesc)
        Me.PanelEx2.Controls.Add(Me.EstDeposito)
        Me.PanelEx2.Controls.Add(Me.Label10)
        Me.PanelEx2.Controls.Add(Me.EstVenda)
        Me.PanelEx2.Controls.Add(Me.Label9)
        Me.PanelEx2.Controls.Add(Me.CodigoProduto)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Location = New System.Drawing.Point(12, 121)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(621, 66)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 3
        '
        'btFindJuros
        '
        Me.btFindJuros.Image = CType(resources.GetObject("btFindJuros.Image"), System.Drawing.Image)
        Me.btFindJuros.Location = New System.Drawing.Point(227, 7)
        Me.btFindJuros.Name = "btFindJuros"
        Me.btFindJuros.Size = New System.Drawing.Size(21, 21)
        Me.btFindJuros.TabIndex = 2
        '
        'ProdutoDesc
        '
        Me.ProdutoDesc.AceitaColarTexto = True
        Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.ProdutoDesc.Location = New System.Drawing.Point(248, 7)
        Me.ProdutoDesc.MaxLength = 50
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(370, 23)
        Me.ProdutoDesc.TabIndex = 3
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'EstDeposito
        '
        Me.EstDeposito.AceitaColarTexto = True
        Me.EstDeposito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstDeposito.CasasDecimais = 4
        Me.EstDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstDeposito.CPObrigatorio = False
        Me.EstDeposito.CPObrigatorioMsg = Nothing
        Me.EstDeposito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstDeposito.FlatBorder = False
        Me.EstDeposito.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstDeposito.FocusColor = System.Drawing.Color.Empty
        Me.EstDeposito.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstDeposito.HighlightBorderOnEnter = False
        Me.EstDeposito.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstDeposito.Location = New System.Drawing.Point(498, 36)
        Me.EstDeposito.MaxLength = 15
        Me.EstDeposito.Name = "EstDeposito"
        Me.EstDeposito.PreencherZeroEsqueda = False
        Me.EstDeposito.RegraValidação = Nothing
        Me.EstDeposito.RegraValidaçãoMensagem = Nothing
        Me.EstDeposito.Size = New System.Drawing.Size(120, 23)
        Me.EstDeposito.TabIndex = 7
        Me.EstDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstDeposito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.EstDeposito.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(387, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 19)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Est. Depósito"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstVenda
        '
        Me.EstVenda.AceitaColarTexto = True
        Me.EstVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstVenda.CasasDecimais = 4
        Me.EstVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstVenda.CPObrigatorio = False
        Me.EstVenda.CPObrigatorioMsg = Nothing
        Me.EstVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstVenda.FlatBorder = False
        Me.EstVenda.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstVenda.FocusColor = System.Drawing.Color.Empty
        Me.EstVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstVenda.HighlightBorderOnEnter = False
        Me.EstVenda.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstVenda.Location = New System.Drawing.Point(122, 36)
        Me.EstVenda.MaxLength = 15
        Me.EstVenda.Name = "EstVenda"
        Me.EstVenda.PreencherZeroEsqueda = False
        Me.EstVenda.RegraValidação = Nothing
        Me.EstVenda.RegraValidaçãoMensagem = Nothing
        Me.EstVenda.Size = New System.Drawing.Size(120, 23)
        Me.EstVenda.TabIndex = 5
        Me.EstVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.EstVenda.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(8, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Est. Venda"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoProduto
        '
        Me.CodigoProduto.AceitaColarTexto = False
        Me.CodigoProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoProduto.CasasDecimais = 0
        Me.CodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoProduto.CPObrigatorio = False
        Me.CodigoProduto.CPObrigatorioMsg = Nothing
        Me.CodigoProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoProduto.FlatBorder = False
        Me.CodigoProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoProduto.FocusColor = System.Drawing.Color.Empty
        Me.CodigoProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoProduto.HighlightBorderOnEnter = False
        Me.CodigoProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoProduto.Location = New System.Drawing.Point(122, 7)
        Me.CodigoProduto.MaxLength = 15
        Me.CodigoProduto.Name = "CodigoProduto"
        Me.CodigoProduto.PreencherZeroEsqueda = False
        Me.CodigoProduto.RegraValidação = Nothing
        Me.CodigoProduto.RegraValidaçãoMensagem = Nothing
        Me.CodigoProduto.Size = New System.Drawing.Size(105, 23)
        Me.CodigoProduto.TabIndex = 1
        Me.CodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CodigoProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.CodigoProduto.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Location = New System.Drawing.Point(14, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(619, 59)
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
        Me.GroupPanel1.Text = "Informe o tipo de Transferência"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(313, 3)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(304, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Tranferência (Estoque Depósito) para (Estoque Venda)"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(304, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Tranferência (Estoque Venda) para (Estoque Depósito)"
        Me.A1.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.Usuario.AceitaColarTexto = True
        Me.Usuario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Usuario.CasasDecimais = 0
        Me.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usuario.CPObrigatorio = False
        Me.Usuario.CPObrigatorioMsg = Nothing
        Me.Usuario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Usuario.FlatBorder = False
        Me.Usuario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Usuario.FocusColor = System.Drawing.Color.Empty
        Me.Usuario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Usuario.HighlightBorderOnEnter = False
        Me.Usuario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Usuario.Location = New System.Drawing.Point(134, 306)
        Me.Usuario.MaxLength = 15
        Me.Usuario.Name = "Usuario"
        Me.Usuario.PreencherZeroEsqueda = False
        Me.Usuario.RegraValidação = Nothing
        Me.Usuario.RegraValidaçãoMensagem = Nothing
        Me.Usuario.Size = New System.Drawing.Size(229, 23)
        Me.Usuario.TabIndex = 11
        Me.Usuario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Usuario.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(20, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Usuário"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescTransf
        '
        Me.DescTransf.AceitaColarTexto = True
        Me.DescTransf.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescTransf.CasasDecimais = 0
        Me.DescTransf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescTransf.CPObrigatorio = False
        Me.DescTransf.CPObrigatorioMsg = Nothing
        Me.DescTransf.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescTransf.FlatBorder = False
        Me.DescTransf.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescTransf.FocusColor = System.Drawing.Color.Empty
        Me.DescTransf.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescTransf.HighlightBorderOnEnter = False
        Me.DescTransf.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescTransf.Location = New System.Drawing.Point(134, 251)
        Me.DescTransf.MaxLength = 250
        Me.DescTransf.Multiline = True
        Me.DescTransf.Name = "DescTransf"
        Me.DescTransf.PreencherZeroEsqueda = False
        Me.DescTransf.RegraValidação = Nothing
        Me.DescTransf.RegraValidaçãoMensagem = Nothing
        Me.DescTransf.Size = New System.Drawing.Size(496, 49)
        Me.DescTransf.TabIndex = 9
        Me.DescTransf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescTransf.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(20, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descrição"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = True
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.DataLancamento.Location = New System.Drawing.Point(134, 222)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.PreencherZeroEsqueda = False
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(120, 23)
        Me.DataLancamento.TabIndex = 7
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(20, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Data Transferência"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QtdTransf
        '
        Me.QtdTransf.AceitaColarTexto = True
        Me.QtdTransf.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.QtdTransf.CasasDecimais = 4
        Me.QtdTransf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.QtdTransf.CPObrigatorio = False
        Me.QtdTransf.CPObrigatorioMsg = Nothing
        Me.QtdTransf.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.QtdTransf.FlatBorder = False
        Me.QtdTransf.FlatBorderColor = System.Drawing.Color.DimGray
        Me.QtdTransf.FocusColor = System.Drawing.Color.Empty
        Me.QtdTransf.FocusColorEnd = System.Drawing.Color.Empty
        Me.QtdTransf.HighlightBorderOnEnter = False
        Me.QtdTransf.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.QtdTransf.Location = New System.Drawing.Point(134, 193)
        Me.QtdTransf.MaxLength = 15
        Me.QtdTransf.Name = "QtdTransf"
        Me.QtdTransf.PreencherZeroEsqueda = False
        Me.QtdTransf.RegraValidação = Nothing
        Me.QtdTransf.RegraValidaçãoMensagem = Nothing
        Me.QtdTransf.Size = New System.Drawing.Size(120, 23)
        Me.QtdTransf.TabIndex = 5
        Me.QtdTransf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.QtdTransf.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(20, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Qtd Tranferir"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.Id.Location = New System.Drawing.Point(134, 92)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(68, 23)
        Me.Id.TabIndex = 2
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(20, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Id"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(544, 346)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(86, 29)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 15
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'EstoqueTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EstoqueTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferência de Local de Estoque - T015"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents Usuario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DescTransf As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QtdTransf As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CodigoProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EstDeposito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents EstVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Confirmado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btFindJuros As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
