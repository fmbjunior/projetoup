<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesPedidoCompraAddItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellShoesPedidoCompraAddItem))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.butNovo = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupNumeracao = New System.Windows.Forms.GroupBox()
        Me.cTamanho = New CBOAutoCompleteFocus.CboFocus()
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Total = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btFindCFOP = New System.Windows.Forms.Label()
        Me.ValorP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindProduto = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.CFOP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CFOPDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SalvarItens = New DevComponents.DotNetBar.ButtonX()
        Me.CodigoProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorUnitario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DescProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupNumeracao.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.GroupBox3)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(584, 326)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
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
        Me.Id.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(13, 253)
        Me.Id.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(94, 20)
        Me.Id.TabIndex = 7
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.butNovo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.GroupNumeracao)
        Me.GroupBox3.Controls.Add(Me.btFindCFOP)
        Me.GroupBox3.Controls.Add(Me.ValorP)
        Me.GroupBox3.Controls.Add(Me.btFindProduto)
        Me.GroupBox3.Controls.Add(Me.btFechar)
        Me.GroupBox3.Controls.Add(Me.CFOP)
        Me.GroupBox3.Controls.Add(Me.CFOPDesc)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.SalvarItens)
        Me.GroupBox3.Controls.Add(Me.CodigoProduto)
        Me.GroupBox3.Controls.Add(Me.ValorUnitario)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.DescProduto)
        Me.GroupBox3.Controls.Add(Me.lblcodigo)
        Me.GroupBox3.Location = New System.Drawing.Point(4, -1)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(570, 248)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'butNovo
        '
        Me.butNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butNovo.Location = New System.Drawing.Point(163, 208)
        Me.butNovo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butNovo.Name = "butNovo"
        Me.butNovo.Size = New System.Drawing.Size(115, 27)
        Me.butNovo.TabIndex = 16
        Me.butNovo.Text = "&Novo Produto"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Vlr. Orçado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupNumeracao
        '
        Me.GroupNumeracao.Controls.Add(Me.cTamanho)
        Me.GroupNumeracao.Controls.Add(Me.Qtd)
        Me.GroupNumeracao.Controls.Add(Me.Label5)
        Me.GroupNumeracao.Controls.Add(Me.Label32)
        Me.GroupNumeracao.Controls.Add(Me.Total)
        Me.GroupNumeracao.Controls.Add(Me.Label34)
        Me.GroupNumeracao.Location = New System.Drawing.Point(271, 81)
        Me.GroupNumeracao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupNumeracao.Name = "GroupNumeracao"
        Me.GroupNumeracao.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupNumeracao.Size = New System.Drawing.Size(290, 121)
        Me.GroupNumeracao.TabIndex = 6
        Me.GroupNumeracao.TabStop = False
        Me.GroupNumeracao.Text = "Numeração"
        '
        'cTamanho
        '
        Me.cTamanho.Auto_Complete = True
        Me.cTamanho.AutoLimitar_Lista = True
        Me.cTamanho.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cTamanho.CPObrigatorio = False
        Me.cTamanho.CPObrigatorioMsg = Nothing
        Me.cTamanho.FlatBorder = False
        Me.cTamanho.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cTamanho.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTamanho.FormattingEnabled = True
        Me.cTamanho.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cTamanho.HighlightBorderOnEnter = False
        Me.cTamanho.Location = New System.Drawing.Point(118, 21)
        Me.cTamanho.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cTamanho.Name = "cTamanho"
        Me.cTamanho.Size = New System.Drawing.Size(145, 26)
        Me.cTamanho.TabIndex = 0
        '
        'Qtd
        '
        Me.Qtd.AceitaColarTexto = True
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 4
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.CPObrigatorio = False
        Me.Qtd.CPObrigatorioMsg = Nothing
        Me.Qtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd.FlatBorder = False
        Me.Qtd.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Qtd.FocusColor = System.Drawing.Color.Empty
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qtd.HighlightBorderOnEnter = False
        Me.Qtd.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtd.Location = New System.Drawing.Point(118, 52)
        Me.Qtd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Qtd.MaxLength = 10
        Me.Qtd.Name = "Qtd"
        Me.Qtd.PreencherZeroEsqueda = False
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(145, 26)
        Me.Qtd.TabIndex = 1
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Qtd.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Qtd"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 22)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(76, 23)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Tamanho"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Total
        '
        Me.Total.AceitaColarTexto = True
        Me.Total.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Total.CasasDecimais = 2
        Me.Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Total.CPObrigatorio = False
        Me.Total.CPObrigatorioMsg = Nothing
        Me.Total.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Total.FlatBorder = False
        Me.Total.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Total.FocusColor = System.Drawing.Color.Empty
        Me.Total.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Navy
        Me.Total.HighlightBorderOnEnter = False
        Me.Total.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Total.Location = New System.Drawing.Point(118, 84)
        Me.Total.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Total.MaxLength = 10
        Me.Total.Name = "Total"
        Me.Total.PreencherZeroEsqueda = False
        Me.Total.RegraValidação = Nothing
        Me.Total.RegraValidaçãoMensagem = Nothing
        Me.Total.Size = New System.Drawing.Size(145, 26)
        Me.Total.TabIndex = 2
        Me.Total.TabStop = False
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Total.ValorPadrao = Nothing
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(12, 84)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(98, 25)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Total"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFindCFOP
        '
        Me.btFindCFOP.Image = CType(resources.GetObject("btFindCFOP.Image"), System.Drawing.Image)
        Me.btFindCFOP.Location = New System.Drawing.Point(147, 51)
        Me.btFindCFOP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btFindCFOP.Name = "btFindCFOP"
        Me.btFindCFOP.Size = New System.Drawing.Size(24, 24)
        Me.btFindCFOP.TabIndex = 11
        '
        'ValorP
        '
        Me.ValorP.AceitaColarTexto = False
        Me.ValorP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorP.CasasDecimais = 5
        Me.ValorP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorP.CPObrigatorio = False
        Me.ValorP.CPObrigatorioMsg = Nothing
        Me.ValorP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorP.FlatBorder = False
        Me.ValorP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorP.FocusColor = System.Drawing.Color.Empty
        Me.ValorP.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorP.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorP.HighlightBorderOnEnter = False
        Me.ValorP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorP.Location = New System.Drawing.Point(19, 165)
        Me.ValorP.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ValorP.MaxLength = 10
        Me.ValorP.Name = "ValorP"
        Me.ValorP.PreencherZeroEsqueda = False
        Me.ValorP.RegraValidação = Nothing
        Me.ValorP.RegraValidaçãoMensagem = Nothing
        Me.ValorP.Size = New System.Drawing.Size(152, 23)
        Me.ValorP.TabIndex = 5
        Me.ValorP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorP.ValorPadrao = Nothing
        '
        'btFindProduto
        '
        Me.btFindProduto.Image = CType(resources.GetObject("btFindProduto.Image"), System.Drawing.Image)
        Me.btFindProduto.Location = New System.Drawing.Point(147, 21)
        Me.btFindProduto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btFindProduto.Name = "btFindProduto"
        Me.btFindProduto.Size = New System.Drawing.Size(24, 24)
        Me.btFindProduto.TabIndex = 8
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btFechar.Location = New System.Drawing.Point(420, 208)
        Me.btFechar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(136, 27)
        Me.btFechar.TabIndex = 14
        Me.btFechar.TabStop = False
        Me.btFechar.Text = "Fechar"
        '
        'CFOP
        '
        Me.CFOP.AceitaColarTexto = True
        Me.CFOP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CFOP.CasasDecimais = 0
        Me.CFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CFOP.CPObrigatorio = False
        Me.CFOP.CPObrigatorioMsg = Nothing
        Me.CFOP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CFOP.FlatBorder = False
        Me.CFOP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CFOP.FocusColor = System.Drawing.Color.Empty
        Me.CFOP.FocusColorEnd = System.Drawing.Color.Empty
        Me.CFOP.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFOP.HighlightBorderOnEnter = False
        Me.CFOP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CFOP.Location = New System.Drawing.Point(63, 52)
        Me.CFOP.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CFOP.MaxLength = 4
        Me.CFOP.Name = "CFOP"
        Me.CFOP.PreencherZeroEsqueda = False
        Me.CFOP.RegraValidação = Nothing
        Me.CFOP.RegraValidaçãoMensagem = Nothing
        Me.CFOP.Size = New System.Drawing.Size(82, 23)
        Me.CFOP.TabIndex = 2
        Me.CFOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CFOP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CFOP.ValorPadrao = Nothing
        '
        'CFOPDesc
        '
        Me.CFOPDesc.AceitaColarTexto = True
        Me.CFOPDesc.BackColor = System.Drawing.Color.White
        Me.CFOPDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CFOPDesc.CasasDecimais = 0
        Me.CFOPDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CFOPDesc.CPObrigatorio = False
        Me.CFOPDesc.CPObrigatorioMsg = Nothing
        Me.CFOPDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CFOPDesc.FlatBorder = False
        Me.CFOPDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CFOPDesc.FocusColor = System.Drawing.Color.Empty
        Me.CFOPDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.CFOPDesc.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFOPDesc.HighlightBorderOnEnter = False
        Me.CFOPDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CFOPDesc.Location = New System.Drawing.Point(174, 52)
        Me.CFOPDesc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CFOPDesc.MaxLength = 3
        Me.CFOPDesc.Name = "CFOPDesc"
        Me.CFOPDesc.PreencherZeroEsqueda = False
        Me.CFOPDesc.ReadOnly = True
        Me.CFOPDesc.RegraValidação = Nothing
        Me.CFOPDesc.RegraValidaçãoMensagem = Nothing
        Me.CFOPDesc.Size = New System.Drawing.Size(387, 23)
        Me.CFOPDesc.TabIndex = 12
        Me.CFOPDesc.TabStop = False
        Me.CFOPDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CFOPDesc.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CFOP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalvarItens
        '
        Me.SalvarItens.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SalvarItens.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SalvarItens.Location = New System.Drawing.Point(286, 208)
        Me.SalvarItens.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SalvarItens.Name = "SalvarItens"
        Me.SalvarItens.Size = New System.Drawing.Size(126, 27)
        Me.SalvarItens.TabIndex = 7
        Me.SalvarItens.Text = "Lancar na Grade"
        '
        'CodigoProduto
        '
        Me.CodigoProduto.AceitaColarTexto = True
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
        Me.CodigoProduto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoProduto.HighlightBorderOnEnter = False
        Me.CodigoProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoProduto.Location = New System.Drawing.Point(63, 22)
        Me.CodigoProduto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CodigoProduto.MaxLength = 10
        Me.CodigoProduto.Name = "CodigoProduto"
        Me.CodigoProduto.PreencherZeroEsqueda = False
        Me.CodigoProduto.RegraValidação = Nothing
        Me.CodigoProduto.RegraValidaçãoMensagem = Nothing
        Me.CodigoProduto.Size = New System.Drawing.Size(82, 23)
        Me.CodigoProduto.TabIndex = 1
        Me.CodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoProduto.ValorPadrao = Nothing
        '
        'ValorUnitario
        '
        Me.ValorUnitario.AceitaColarTexto = True
        Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorUnitario.CasasDecimais = 5
        Me.ValorUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorUnitario.CPObrigatorio = False
        Me.ValorUnitario.CPObrigatorioMsg = Nothing
        Me.ValorUnitario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorUnitario.FlatBorder = False
        Me.ValorUnitario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorUnitario.FocusColor = System.Drawing.Color.Empty
        Me.ValorUnitario.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorUnitario.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorUnitario.HighlightBorderOnEnter = False
        Me.ValorUnitario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorUnitario.Location = New System.Drawing.Point(19, 110)
        Me.ValorUnitario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ValorUnitario.MaxLength = 10
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.PreencherZeroEsqueda = False
        Me.ValorUnitario.RegraValidação = Nothing
        Me.ValorUnitario.RegraValidaçãoMensagem = Nothing
        Me.ValorUnitario.Size = New System.Drawing.Size(152, 23)
        Me.ValorUnitario.TabIndex = 4
        Me.ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorUnitario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorUnitario.ValorPadrao = Nothing
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(16, 84)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(101, 23)
        Me.Label33.TabIndex = 13
        Me.Label33.Text = "Vlr. Unitário"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescProduto
        '
        Me.DescProduto.AceitaColarTexto = True
        Me.DescProduto.BackColor = System.Drawing.Color.White
        Me.DescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescProduto.CasasDecimais = 0
        Me.DescProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescProduto.CPObrigatorio = False
        Me.DescProduto.CPObrigatorioMsg = Nothing
        Me.DescProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescProduto.FlatBorder = False
        Me.DescProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescProduto.FocusColor = System.Drawing.Color.Empty
        Me.DescProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescProduto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescProduto.HighlightBorderOnEnter = False
        Me.DescProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescProduto.Location = New System.Drawing.Point(174, 22)
        Me.DescProduto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DescProduto.MaxLength = 3
        Me.DescProduto.Name = "DescProduto"
        Me.DescProduto.PreencherZeroEsqueda = False
        Me.DescProduto.ReadOnly = True
        Me.DescProduto.RegraValidação = Nothing
        Me.DescProduto.RegraValidaçãoMensagem = Nothing
        Me.DescProduto.Size = New System.Drawing.Size(387, 23)
        Me.DescProduto.TabIndex = 9
        Me.DescProduto.TabStop = False
        Me.DescProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescProduto.ValorPadrao = Nothing
        '
        'lblcodigo
        '
        Me.lblcodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblcodigo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcodigo.Location = New System.Drawing.Point(9, 18)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(58, 23)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "Codigo"
        Me.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 291)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "[Use a Tecla F5 para Buscar um Produto] - [Use a tecla  ESC para fechar a tela]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'SellShoesPedidoCompraAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btFechar
        Me.ClientSize = New System.Drawing.Size(584, 326)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "SellShoesPedidoCompraAddItem"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido Compra Adicionar Item"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupNumeracao.ResumeLayout(False)
        Me.GroupNumeracao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents butNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupNumeracao As System.Windows.Forms.GroupBox
    Friend WithEvents cTamanho As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Total As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents btFindCFOP As System.Windows.Forms.Label
    Friend WithEvents ValorP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindProduto As System.Windows.Forms.Label
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CFOP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CFOPDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SalvarItens As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CodigoProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorUnitario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents DescProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
