<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoEtiquetas
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.PainelCompra = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CompraInterno = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelProduto = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.Impressora = New System.Windows.Forms.ComboBox()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.PainelCompra.SuspendLayout()
        Me.PainelProduto.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.PainelCompra)
        Me.Fundo.Controls.Add(Me.PainelProduto)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.btImprimir)
        Me.Fundo.Controls.Add(Me.Impressora)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(592, 257)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'PainelCompra
        '
        Me.PainelCompra.Controls.Add(Me.Label4)
        Me.PainelCompra.Controls.Add(Me.CompraInterno)
        Me.PainelCompra.Location = New System.Drawing.Point(12, 179)
        Me.PainelCompra.Name = "PainelCompra"
        Me.PainelCompra.Size = New System.Drawing.Size(577, 31)
        Me.PainelCompra.TabIndex = 4
        Me.PainelCompra.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Informe o Pedido de Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompraInterno
        '
        Me.CompraInterno.AceitaColarTexto = True
        Me.CompraInterno.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CompraInterno.CasasDecimais = 0
        Me.CompraInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompraInterno.CPObrigatorio = False
        Me.CompraInterno.CPObrigatorioMsg = Nothing
        Me.CompraInterno.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CompraInterno.FlatBorder = False
        Me.CompraInterno.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CompraInterno.FocusColor = System.Drawing.Color.Empty
        Me.CompraInterno.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompraInterno.HighlightBorderOnEnter = False
        Me.CompraInterno.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CompraInterno.Location = New System.Drawing.Point(166, 5)
        Me.CompraInterno.MaxLength = 15
        Me.CompraInterno.Name = "CompraInterno"
        Me.CompraInterno.PreencherZeroEsqueda = False
        Me.CompraInterno.RegraValidação = Nothing
        Me.CompraInterno.RegraValidaçãoMensagem = Nothing
        Me.CompraInterno.Size = New System.Drawing.Size(75, 23)
        Me.CompraInterno.TabIndex = 1
        Me.CompraInterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CompraInterno.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.CompraInterno.ValorPadrao = Nothing
        '
        'PainelProduto
        '
        Me.PainelProduto.Controls.Add(Me.Label2)
        Me.PainelProduto.Controls.Add(Me.Produto)
        Me.PainelProduto.Controls.Add(Me.ProdutoDesc)
        Me.PainelProduto.Controls.Add(Me.Label1)
        Me.PainelProduto.Controls.Add(Me.Qtd)
        Me.PainelProduto.Location = New System.Drawing.Point(12, 112)
        Me.PainelProduto.Name = "PainelProduto"
        Me.PainelProduto.Size = New System.Drawing.Size(577, 61)
        Me.PainelProduto.TabIndex = 3
        Me.PainelProduto.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Informe o Produto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Produto.Location = New System.Drawing.Point(166, 5)
        Me.Produto.Name = "Produto"
        Me.Produto.PreencherZeroEsqueda = False
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(75, 23)
        Me.Produto.TabIndex = 1
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
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
        Me.ProdutoDesc.Location = New System.Drawing.Point(252, 5)
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(318, 23)
        Me.ProdutoDesc.TabIndex = 2
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Informe a Qtd de Etiqueta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Qtd
        '
        Me.Qtd.AceitaColarTexto = True
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 0
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.CPObrigatorio = False
        Me.Qtd.CPObrigatorioMsg = Nothing
        Me.Qtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd.FlatBorder = False
        Me.Qtd.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Qtd.FocusColor = System.Drawing.Color.Empty
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.HighlightBorderOnEnter = False
        Me.Qtd.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtd.Location = New System.Drawing.Point(166, 34)
        Me.Qtd.MaxLength = 15
        Me.Qtd.Name = "Qtd"
        Me.Qtd.PreencherZeroEsqueda = False
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(75, 23)
        Me.Qtd.TabIndex = 4
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(569, 56)
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
        Me.GroupPanel1.Text = "Selecione uma Opção"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(126, 3)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(192, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Definição por Pedido de Entrada"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(117, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Definição Manual"
        Me.A1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Informe a Impressora"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btImprimir
        '
        Me.btImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImprimir.Location = New System.Drawing.Point(428, 229)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btImprimir.TabIndex = 5
        Me.btImprimir.Text = "Imprimir"
        '
        'Impressora
        '
        Me.Impressora.Location = New System.Drawing.Point(177, 83)
        Me.Impressora.Name = "Impressora"
        Me.Impressora.Size = New System.Drawing.Size(404, 23)
        Me.Impressora.TabIndex = 2
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(509, 229)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 6
        Me.btFechar.Text = "Fechar"
        '
        'ProdutoEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ProdutoEtiquetas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etiquetas - T028"
        Me.Fundo.ResumeLayout(False)
        Me.PainelCompra.ResumeLayout(False)
        Me.PainelCompra.PerformLayout()
        Me.PainelProduto.ResumeLayout(False)
        Me.PainelProduto.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Impressora As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelProduto As System.Windows.Forms.Panel
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelCompra As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CompraInterno As TexBoxFocusNet.TextBoxFocusNet
End Class
