<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProducaoAddItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProducaoAddItem))
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.ValorUnitarioComissao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btProdutoFind = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.OrdemProducao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.ValorUnitarioComissao)
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.btProdutoFind)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.LabelX4)
        Me.Fundo.Controls.Add(Me.LabelX1)
        Me.Fundo.Controls.Add(Me.ProdutoDesc)
        Me.Fundo.Controls.Add(Me.OrdemProducao)
        Me.Fundo.Controls.Add(Me.Qtd)
        Me.Fundo.Controls.Add(Me.Produto)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(652, 121)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'ValorUnitarioComissao
        '
        Me.ValorUnitarioComissao.AceitaColarTexto = True
        Me.ValorUnitarioComissao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorUnitarioComissao.CasasDecimais = 4
        Me.ValorUnitarioComissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorUnitarioComissao.CPObrigatorio = False
        Me.ValorUnitarioComissao.CPObrigatorioMsg = Nothing
        Me.ValorUnitarioComissao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorUnitarioComissao.FlatBorder = False
        Me.ValorUnitarioComissao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorUnitarioComissao.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorUnitarioComissao.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorUnitarioComissao.HighlightBorderOnEnter = False
        Me.ValorUnitarioComissao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorUnitarioComissao.Location = New System.Drawing.Point(118, 86)
        Me.ValorUnitarioComissao.MaxLength = 8
        Me.ValorUnitarioComissao.Name = "ValorUnitarioComissao"
        Me.ValorUnitarioComissao.PreencherZeroEsqueda = False
        Me.ValorUnitarioComissao.RegraValidação = Nothing
        Me.ValorUnitarioComissao.RegraValidaçãoMensagem = Nothing
        Me.ValorUnitarioComissao.Size = New System.Drawing.Size(52, 23)
        Me.ValorUnitarioComissao.TabIndex = 39
        Me.ValorUnitarioComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorUnitarioComissao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorUnitarioComissao.ValorPadrao = Nothing
        Me.ValorUnitarioComissao.Visible = False
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(512, 86)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(63, 23)
        Me.btSalvar.TabIndex = 37
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(581, 86)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(63, 23)
        Me.btFechar.TabIndex = 38
        Me.btFechar.Text = "Fechar"
        '
        'btProdutoFind
        '
        Me.btProdutoFind.Image = CType(resources.GetObject("btProdutoFind.Image"), System.Drawing.Image)
        Me.btProdutoFind.Location = New System.Drawing.Point(91, 42)
        Me.btProdutoFind.Name = "btProdutoFind"
        Me.btProdutoFind.Size = New System.Drawing.Size(23, 23)
        Me.btProdutoFind.TabIndex = 36
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
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(12, 86)
        Me.Id.MaxLength = 15
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(44, 23)
        Me.Id.TabIndex = 35
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(548, 13)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX4.Size = New System.Drawing.Size(92, 23)
        Me.LabelX4.TabIndex = 31
        Me.LabelX4.Text = "Qtde."
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX1.Size = New System.Drawing.Size(77, 23)
        Me.LabelX1.TabIndex = 27
        Me.LabelX1.Text = "Produto"
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
        Me.ProdutoDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ProdutoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDesc.HighlightBorderOnEnter = False
        Me.ProdutoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.Location = New System.Drawing.Point(118, 42)
        Me.ProdutoDesc.MaxLength = 50
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(422, 23)
        Me.ProdutoDesc.TabIndex = 30
        Me.ProdutoDesc.TabStop = False
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'OrdemProducao
        '
        Me.OrdemProducao.AceitaColarTexto = True
        Me.OrdemProducao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.OrdemProducao.CasasDecimais = 4
        Me.OrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OrdemProducao.CPObrigatorio = False
        Me.OrdemProducao.CPObrigatorioMsg = Nothing
        Me.OrdemProducao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OrdemProducao.FlatBorder = False
        Me.OrdemProducao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.OrdemProducao.FocusColor = System.Drawing.Color.MistyRose
        Me.OrdemProducao.FocusColorEnd = System.Drawing.Color.Empty
        Me.OrdemProducao.HighlightBorderOnEnter = False
        Me.OrdemProducao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.OrdemProducao.Location = New System.Drawing.Point(62, 86)
        Me.OrdemProducao.MaxLength = 15
        Me.OrdemProducao.Name = "OrdemProducao"
        Me.OrdemProducao.PreencherZeroEsqueda = False
        Me.OrdemProducao.RegraValidação = Nothing
        Me.OrdemProducao.RegraValidaçãoMensagem = Nothing
        Me.OrdemProducao.Size = New System.Drawing.Size(52, 23)
        Me.OrdemProducao.TabIndex = 34
        Me.OrdemProducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OrdemProducao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.OrdemProducao.ValorPadrao = Nothing
        Me.OrdemProducao.Visible = False
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
        Me.Qtd.FocusColor = System.Drawing.Color.MistyRose
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.HighlightBorderOnEnter = False
        Me.Qtd.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtd.Location = New System.Drawing.Point(546, 42)
        Me.Qtd.MaxLength = 15
        Me.Qtd.Name = "Qtd"
        Me.Qtd.PreencherZeroEsqueda = False
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(94, 23)
        Me.Qtd.TabIndex = 32
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'Produto
        '
        Me.Produto.AceitaColarTexto = True
        Me.Produto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Produto.CasasDecimais = 0
        Me.Produto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Produto.CPObrigatorio = False
        Me.Produto.CPObrigatorioMsg = Nothing
        Me.Produto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.Produto.FlatBorder = False
        Me.Produto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Produto.FocusColor = System.Drawing.Color.MistyRose
        Me.Produto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Produto.HighlightBorderOnEnter = False
        Me.Produto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Produto.Location = New System.Drawing.Point(12, 42)
        Me.Produto.MaxLength = 15
        Me.Produto.Name = "Produto"
        Me.Produto.PreencherZeroEsqueda = False
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(77, 23)
        Me.Produto.TabIndex = 28
        Me.Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.Produto.ValorPadrao = Nothing
        '
        'ProducaoAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 121)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ProducaoAddItem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item de Produção - T196"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents OrdemProducao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btProdutoFind As System.Windows.Forms.Label
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ValorUnitarioComissao As TexBoxFocusNet.TextBoxFocusNet
End Class
