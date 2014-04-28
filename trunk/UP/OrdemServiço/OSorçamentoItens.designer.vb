<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OSorçamentoItens
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
        Me.IdItem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TotalProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorUnitario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodigoProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ValorDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Desconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.UserSenhaDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdItem
        '
        Me.IdItem.AceitaColarTexto = True
        Me.IdItem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IdItem.CasasDecimais = 0
        Me.IdItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdItem.CPObrigatorio = False
        Me.IdItem.CPObrigatorioMsg = Nothing
        Me.IdItem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdItem.FlatBorder = False
        Me.IdItem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdItem.FocusColor = System.Drawing.Color.Empty
        Me.IdItem.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdItem.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdItem.HighlightBorderOnEnter = False
        Me.IdItem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdItem.Location = New System.Drawing.Point(513, 89)
        Me.IdItem.Name = "IdItem"
        Me.IdItem.PreencherZeroEsqueda = False
        Me.IdItem.RegraValidação = Nothing
        Me.IdItem.RegraValidaçãoMensagem = Nothing
        Me.IdItem.Size = New System.Drawing.Size(74, 23)
        Me.IdItem.TabIndex = 15
        Me.IdItem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdItem.ValorPadrao = Nothing
        Me.IdItem.Visible = False
        '
        'TotalProduto
        '
        Me.TotalProduto.AceitaColarTexto = True
        Me.TotalProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalProduto.CasasDecimais = 4
        Me.TotalProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalProduto.CPObrigatorio = False
        Me.TotalProduto.CPObrigatorioMsg = Nothing
        Me.TotalProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalProduto.FlatBorder = False
        Me.TotalProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalProduto.FocusColor = System.Drawing.Color.Empty
        Me.TotalProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalProduto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalProduto.HighlightBorderOnEnter = False
        Me.TotalProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalProduto.Location = New System.Drawing.Point(89, 90)
        Me.TotalProduto.MaxLength = 10
        Me.TotalProduto.Name = "TotalProduto"
        Me.TotalProduto.PreencherZeroEsqueda = False
        Me.TotalProduto.RegraValidação = Nothing
        Me.TotalProduto.RegraValidaçãoMensagem = Nothing
        Me.TotalProduto.Size = New System.Drawing.Size(114, 23)
        Me.TotalProduto.TabIndex = 9
        Me.TotalProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalProduto.ValorPadrao = Nothing
        '
        'ValorUnitario
        '
        Me.ValorUnitario.AceitaColarTexto = True
        Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorUnitario.CasasDecimais = 4
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
        Me.ValorUnitario.Location = New System.Drawing.Point(448, 31)
        Me.ValorUnitario.MaxLength = 10
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.PreencherZeroEsqueda = False
        Me.ValorUnitario.RegraValidação = Nothing
        Me.ValorUnitario.RegraValidaçãoMensagem = Nothing
        Me.ValorUnitario.Size = New System.Drawing.Size(139, 23)
        Me.ValorUnitario.TabIndex = 6
        Me.ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorUnitario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorUnitario.ValorPadrao = Nothing
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
        Me.Qtd.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qtd.HighlightBorderOnEnter = False
        Me.Qtd.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtd.Location = New System.Drawing.Point(89, 32)
        Me.Qtd.MaxLength = 15
        Me.Qtd.Name = "Qtd"
        Me.Qtd.PreencherZeroEsqueda = False
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(114, 23)
        Me.Qtd.TabIndex = 2
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
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
        Me.ProdutoDesc.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdutoDesc.HighlightBorderOnEnter = False
        Me.ProdutoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.Location = New System.Drawing.Point(174, 3)
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(413, 23)
        Me.ProdutoDesc.TabIndex = 3
        Me.ProdutoDesc.TabStop = False
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
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
        Me.CodigoProduto.Location = New System.Drawing.Point(89, 3)
        Me.CodigoProduto.Name = "CodigoProduto"
        Me.CodigoProduto.PreencherZeroEsqueda = False
        Me.CodigoProduto.RegraValidação = Nothing
        Me.CodigoProduto.RegraValidaçãoMensagem = Nothing
        Me.CodigoProduto.Size = New System.Drawing.Size(79, 23)
        Me.CodigoProduto.TabIndex = 1
        Me.CodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoProduto.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Qtd"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(349, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Vlr Unitário"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Vlr Total"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(348, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Vlr Desconto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Desconto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDesconto
        '
        Me.ValorDesconto.AceitaColarTexto = True
        Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDesconto.CasasDecimais = 4
        Me.ValorDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDesconto.CPObrigatorio = False
        Me.ValorDesconto.CPObrigatorioMsg = Nothing
        Me.ValorDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDesconto.FlatBorder = False
        Me.ValorDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.FocusColor = System.Drawing.Color.Empty
        Me.ValorDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDesconto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorDesconto.HighlightBorderOnEnter = False
        Me.ValorDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.Location = New System.Drawing.Point(448, 60)
        Me.ValorDesconto.MaxLength = 10
        Me.ValorDesconto.Name = "ValorDesconto"
        Me.ValorDesconto.PreencherZeroEsqueda = False
        Me.ValorDesconto.RegraValidação = Nothing
        Me.ValorDesconto.RegraValidaçãoMensagem = Nothing
        Me.ValorDesconto.Size = New System.Drawing.Size(139, 23)
        Me.ValorDesconto.TabIndex = 8
        Me.ValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDesconto.ValorPadrao = Nothing
        '
        'Desconto
        '
        Me.Desconto.AceitaColarTexto = True
        Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Desconto.CasasDecimais = 4
        Me.Desconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Desconto.CPObrigatorio = False
        Me.Desconto.CPObrigatorioMsg = Nothing
        Me.Desconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Desconto.FlatBorder = False
        Me.Desconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Desconto.FocusColor = System.Drawing.Color.Empty
        Me.Desconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desconto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desconto.HighlightBorderOnEnter = False
        Me.Desconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Desconto.Location = New System.Drawing.Point(89, 61)
        Me.Desconto.Name = "Desconto"
        Me.Desconto.PreencherZeroEsqueda = False
        Me.Desconto.RegraValidação = Nothing
        Me.Desconto.RegraValidaçãoMensagem = Nothing
        Me.Desconto.Size = New System.Drawing.Size(114, 23)
        Me.Desconto.TabIndex = 7
        Me.Desconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Desconto.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(209, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(623, 209)
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
        Me.GroupPanel1.Controls.Add(Me.UserSenhaDesconto)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.CodigoProduto)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.btNovo)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.btSalvar)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.btFechar)
        Me.GroupPanel1.Controls.Add(Me.Desconto)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.IdItem)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.ValorDesconto)
        Me.GroupPanel1.Controls.Add(Me.TotalProduto)
        Me.GroupPanel1.Controls.Add(Me.ProdutoDesc)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Qtd)
        Me.GroupPanel1.Controls.Add(Me.ValorUnitario)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(601, 187)
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
        Me.GroupPanel1.Text = "Adicionar Item ao Orçamento"
        '
        'UserSenhaDesconto
        '
        Me.UserSenhaDesconto.AceitaColarTexto = True
        Me.UserSenhaDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.UserSenhaDesconto.CasasDecimais = 0
        Me.UserSenhaDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UserSenhaDesconto.CPObrigatorio = False
        Me.UserSenhaDesconto.CPObrigatorioMsg = Nothing
        Me.UserSenhaDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.UserSenhaDesconto.FlatBorder = False
        Me.UserSenhaDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UserSenhaDesconto.FocusColor = System.Drawing.Color.MistyRose
        Me.UserSenhaDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.UserSenhaDesconto.HighlightBorderOnEnter = False
        Me.UserSenhaDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.UserSenhaDesconto.Location = New System.Drawing.Point(126, 136)
        Me.UserSenhaDesconto.Name = "UserSenhaDesconto"
        Me.UserSenhaDesconto.PreencherZeroEsqueda = False
        Me.UserSenhaDesconto.RegraValidação = Nothing
        Me.UserSenhaDesconto.RegraValidaçãoMensagem = Nothing
        Me.UserSenhaDesconto.Size = New System.Drawing.Size(103, 23)
        Me.UserSenhaDesconto.TabIndex = 27
        Me.UserSenhaDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UserSenhaDesconto.ValorPadrao = Nothing
        Me.UserSenhaDesconto.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "[ESC] Fecha a Tela"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(332, 131)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(81, 24)
        Me.btNovo.TabIndex = 17
        Me.btNovo.Text = "Novo Item"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(419, 131)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(81, 24)
        Me.btSalvar.TabIndex = 10
        Me.btSalvar.Text = "Salvar Item"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btFechar.Location = New System.Drawing.Point(506, 131)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(81, 24)
        Me.btFechar.TabIndex = 18
        Me.btFechar.Text = "Fechar"
        '
        'OSorçamentoItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.CancelButton = Me.btFechar
        Me.ClientSize = New System.Drawing.Size(623, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OSorçamentoItens"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itens do Orçamento Produtos - T230"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IdItem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TotalProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorUnitario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ValorDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Desconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UserSenhaDesconto As TexBoxFocusNet.TextBoxFocusNet
End Class
