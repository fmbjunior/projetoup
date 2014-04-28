<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraCtrPedidoItens
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Codigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ValorTotal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ValorUnitario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedido"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IdPedido
        '
        Me.IdPedido.AceitaColarTexto = True
        Me.IdPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IdPedido.CasasDecimais = 0
        Me.IdPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdPedido.CPObrigatorio = False
        Me.IdPedido.CPObrigatorioMsg = Nothing
        Me.IdPedido.Enabled = False
        Me.IdPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdPedido.FlatBorder = False
        Me.IdPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdPedido.FocusColor = System.Drawing.Color.Empty
        Me.IdPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdPedido.HighlightBorderOnEnter = False
        Me.IdPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdPedido.Location = New System.Drawing.Point(120, 9)
        Me.IdPedido.MaxLength = 8
        Me.IdPedido.Name = "IdPedido"
        Me.IdPedido.PreencherZeroEsqueda = False
        Me.IdPedido.RegraValidação = Nothing
        Me.IdPedido.RegraValidaçãoMensagem = Nothing
        Me.IdPedido.Size = New System.Drawing.Size(71, 20)
        Me.IdPedido.TabIndex = 1
        Me.IdPedido.TabStop = False
        Me.IdPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdPedido.ValorPadrao = Nothing
        '
        'Codigo
        '
        Me.Codigo.AceitaColarTexto = True
        Me.Codigo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Codigo.CasasDecimais = 0
        Me.Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Codigo.CPObrigatorio = False
        Me.Codigo.CPObrigatorioMsg = Nothing
        Me.Codigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Codigo.FlatBorder = False
        Me.Codigo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Codigo.FocusColor = System.Drawing.Color.Empty
        Me.Codigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Codigo.HighlightBorderOnEnter = False
        Me.Codigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Codigo.Location = New System.Drawing.Point(470, 12)
        Me.Codigo.MaxLength = 8
        Me.Codigo.Name = "Codigo"
        Me.Codigo.PreencherZeroEsqueda = False
        Me.Codigo.RegraValidação = Nothing
        Me.Codigo.RegraValidaçãoMensagem = Nothing
        Me.Codigo.Size = New System.Drawing.Size(71, 20)
        Me.Codigo.TabIndex = 2
        Me.Codigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Codigo.ValorPadrao = Nothing
        Me.Codigo.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Produto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Produto.Location = New System.Drawing.Point(120, 35)
        Me.Produto.MaxLength = 8
        Me.Produto.Name = "Produto"
        Me.Produto.PreencherZeroEsqueda = False
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(71, 20)
        Me.Produto.TabIndex = 4
        Me.Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
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
        Me.ProdutoDesc.Location = New System.Drawing.Point(197, 35)
        Me.ProdutoDesc.MaxLength = 50
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(344, 20)
        Me.ProdutoDesc.TabIndex = 5
        Me.ProdutoDesc.TabStop = False
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Qtd"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Qtd
        '
        Me.Qtd.AceitaColarTexto = True
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 3
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
        Me.Qtd.Location = New System.Drawing.Point(120, 61)
        Me.Qtd.MaxLength = 15
        Me.Qtd.Name = "Qtd"
        Me.Qtd.PreencherZeroEsqueda = False
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(71, 20)
        Me.Qtd.TabIndex = 7
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(307, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorTotal
        '
        Me.ValorTotal.AceitaColarTexto = True
        Me.ValorTotal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorTotal.CasasDecimais = 4
        Me.ValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorTotal.CPObrigatorio = False
        Me.ValorTotal.CPObrigatorioMsg = Nothing
        Me.ValorTotal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorTotal.FlatBorder = False
        Me.ValorTotal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorTotal.FocusColor = System.Drawing.Color.Empty
        Me.ValorTotal.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorTotal.HighlightBorderOnEnter = False
        Me.ValorTotal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorTotal.Location = New System.Drawing.Point(415, 86)
        Me.ValorTotal.MaxLength = 10
        Me.ValorTotal.Name = "ValorTotal"
        Me.ValorTotal.PreencherZeroEsqueda = False
        Me.ValorTotal.RegraValidação = Nothing
        Me.ValorTotal.RegraValidaçãoMensagem = Nothing
        Me.ValorTotal.Size = New System.Drawing.Size(126, 20)
        Me.ValorTotal.TabIndex = 11
        Me.ValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorTotal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorTotal.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Unitário"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.ValorUnitario.HighlightBorderOnEnter = False
        Me.ValorUnitario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorUnitario.Location = New System.Drawing.Point(120, 87)
        Me.ValorUnitario.MaxLength = 10
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.PreencherZeroEsqueda = False
        Me.ValorUnitario.RegraValidação = Nothing
        Me.ValorUnitario.RegraValidaçãoMensagem = Nothing
        Me.ValorUnitario.Size = New System.Drawing.Size(126, 20)
        Me.ValorUnitario.TabIndex = 9
        Me.ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorUnitario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorUnitario.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.btNovo)
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.IdPedido)
        Me.Fundo.Controls.Add(Me.Codigo)
        Me.Fundo.Controls.Add(Me.Produto)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.ValorUnitario)
        Me.Fundo.Controls.Add(Me.ProdutoDesc)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Qtd)
        Me.Fundo.Controls.Add(Me.ValorTotal)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(552, 165)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.Location = New System.Drawing.Point(241, 127)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(96, 32)
        Me.btNovo.TabIndex = 13
        Me.btNovo.Text = "Novo"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.Location = New System.Drawing.Point(343, 127)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(96, 32)
        Me.btSalvar.TabIndex = 12
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(445, 127)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(96, 32)
        Me.btFechar.TabIndex = 14
        Me.btFechar.Text = "Fechar"
        '
        'CompraCtrPedidoItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CompraCtrPedidoItens"
        Me.Text = "CompraCtrPedidoItens - 127"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Codigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ValorTotal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ValorUnitario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
End Class
