<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoEstoqueConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProdutoEstoqueConsulta))
        Me.Descrição = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QtdDisponivel = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ValorVenda = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.EstDeposito = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EstoqueMedio = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btFindProduto = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Descrição
        '
        Me.Descrição.AceitaColarTexto = True
        Me.Descrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Descrição.CasasDecimais = 0
        Me.Descrição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descrição.CPObrigatorio = False
        Me.Descrição.CPObrigatorioMsg = Nothing
        Me.Descrição.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Descrição.FlatBorder = False
        Me.Descrição.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Descrição.FocusColor = System.Drawing.Color.MistyRose
        Me.Descrição.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descrição.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descrição.HighlightBorderOnEnter = False
        Me.Descrição.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Descrição.Location = New System.Drawing.Point(127, 30)
        Me.Descrição.MaxLength = 50
        Me.Descrição.Name = "Descrição"
        Me.Descrição.PreencherZeroEsqueda = False
        Me.Descrição.RegraValidação = Nothing
        Me.Descrição.RegraValidaçãoMensagem = Nothing
        Me.Descrição.Size = New System.Drawing.Size(423, 26)
        Me.Descrição.TabIndex = 2
        Me.Descrição.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descrição.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Informe o Produto a Consultar"
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
        Me.Produto.FocusColor = System.Drawing.Color.MistyRose
        Me.Produto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Produto.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Produto.HighlightBorderOnEnter = False
        Me.Produto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Produto.Location = New System.Drawing.Point(12, 30)
        Me.Produto.MaxLength = 10
        Me.Produto.Name = "Produto"
        Me.Produto.PreencherZeroEsqueda = False
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(90, 26)
        Me.Produto.TabIndex = 1
        Me.Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Estoque Disponivel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QtdDisponivel
        '
        Me.QtdDisponivel.AceitaColarTexto = True
        Me.QtdDisponivel.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.QtdDisponivel.CasasDecimais = 0
        Me.QtdDisponivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.QtdDisponivel.CPObrigatorio = False
        Me.QtdDisponivel.CPObrigatorioMsg = Nothing
        Me.QtdDisponivel.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.QtdDisponivel.FlatBorder = False
        Me.QtdDisponivel.FlatBorderColor = System.Drawing.Color.DimGray
        Me.QtdDisponivel.FocusColor = System.Drawing.Color.MistyRose
        Me.QtdDisponivel.FocusColorEnd = System.Drawing.Color.Empty
        Me.QtdDisponivel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtdDisponivel.HighlightBorderOnEnter = False
        Me.QtdDisponivel.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.QtdDisponivel.Location = New System.Drawing.Point(12, 96)
        Me.QtdDisponivel.MaxLength = 10
        Me.QtdDisponivel.Name = "QtdDisponivel"
        Me.QtdDisponivel.PreencherZeroEsqueda = False
        Me.QtdDisponivel.RegraValidação = Nothing
        Me.QtdDisponivel.RegraValidaçãoMensagem = Nothing
        Me.QtdDisponivel.Size = New System.Drawing.Size(224, 30)
        Me.QtdDisponivel.TabIndex = 4
        Me.QtdDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtdDisponivel.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.QtdDisponivel.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(326, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Valor Venda"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorVenda
        '
        Me.ValorVenda.AceitaColarTexto = True
        Me.ValorVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorVenda.CasasDecimais = 0
        Me.ValorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorVenda.CPObrigatorio = False
        Me.ValorVenda.CPObrigatorioMsg = Nothing
        Me.ValorVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorVenda.FlatBorder = False
        Me.ValorVenda.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorVenda.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorVenda.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorVenda.HighlightBorderOnEnter = False
        Me.ValorVenda.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorVenda.Location = New System.Drawing.Point(326, 166)
        Me.ValorVenda.MaxLength = 10
        Me.ValorVenda.Name = "ValorVenda"
        Me.ValorVenda.PreencherZeroEsqueda = False
        Me.ValorVenda.RegraValidação = Nothing
        Me.ValorVenda.RegraValidaçãoMensagem = Nothing
        Me.ValorVenda.Size = New System.Drawing.Size(224, 30)
        Me.ValorVenda.TabIndex = 12
        Me.ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorVenda.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.EstDeposito)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.EstoqueMedio)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.btFindProduto)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.ValorVenda)
        Me.Fundo.Controls.Add(Me.Produto)
        Me.Fundo.Controls.Add(Me.Descrição)
        Me.Fundo.Controls.Add(Me.QtdDisponivel)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(562, 251)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 13
        '
        'EstDeposito
        '
        Me.EstDeposito.AceitaColarTexto = True
        Me.EstDeposito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstDeposito.CasasDecimais = 0
        Me.EstDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstDeposito.CPObrigatorio = False
        Me.EstDeposito.CPObrigatorioMsg = Nothing
        Me.EstDeposito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstDeposito.FlatBorder = False
        Me.EstDeposito.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstDeposito.FocusColor = System.Drawing.Color.MistyRose
        Me.EstDeposito.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstDeposito.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstDeposito.HighlightBorderOnEnter = False
        Me.EstDeposito.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstDeposito.Location = New System.Drawing.Point(11, 166)
        Me.EstDeposito.MaxLength = 10
        Me.EstDeposito.Name = "EstDeposito"
        Me.EstDeposito.PreencherZeroEsqueda = False
        Me.EstDeposito.RegraValidação = Nothing
        Me.EstDeposito.RegraValidaçãoMensagem = Nothing
        Me.EstDeposito.Size = New System.Drawing.Size(224, 30)
        Me.EstDeposito.TabIndex = 31
        Me.EstDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstDeposito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EstDeposito.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Estoque Depósito"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstoqueMedio
        '
        Me.EstoqueMedio.AceitaColarTexto = True
        Me.EstoqueMedio.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstoqueMedio.CasasDecimais = 0
        Me.EstoqueMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstoqueMedio.CPObrigatorio = False
        Me.EstoqueMedio.CPObrigatorioMsg = Nothing
        Me.EstoqueMedio.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstoqueMedio.FlatBorder = False
        Me.EstoqueMedio.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstoqueMedio.FocusColor = System.Drawing.Color.MistyRose
        Me.EstoqueMedio.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstoqueMedio.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstoqueMedio.HighlightBorderOnEnter = False
        Me.EstoqueMedio.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstoqueMedio.Location = New System.Drawing.Point(326, 96)
        Me.EstoqueMedio.MaxLength = 10
        Me.EstoqueMedio.Name = "EstoqueMedio"
        Me.EstoqueMedio.PreencherZeroEsqueda = False
        Me.EstoqueMedio.RegraValidação = Nothing
        Me.EstoqueMedio.RegraValidaçãoMensagem = Nothing
        Me.EstoqueMedio.Size = New System.Drawing.Size(224, 30)
        Me.EstoqueMedio.TabIndex = 29
        Me.EstoqueMedio.TabStop = False
        Me.EstoqueMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstoqueMedio.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EstoqueMedio.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(326, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Estoque Médio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFindProduto
        '
        Me.btFindProduto.Image = CType(resources.GetObject("btFindProduto.Image"), System.Drawing.Image)
        Me.btFindProduto.Location = New System.Drawing.Point(104, 31)
        Me.btFindProduto.Name = "btFindProduto"
        Me.btFindProduto.Size = New System.Drawing.Size(23, 23)
        Me.btFindProduto.TabIndex = 27
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(467, 213)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(84, 27)
        Me.btFechar.TabIndex = 13
        Me.btFechar.Text = "Fechar"
        '
        'ProdutoEstoqueConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(562, 251)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProdutoEstoqueConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Estoque - T011"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Descrição As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QtdDisponivel As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ValorVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFindProduto As System.Windows.Forms.Label
    Friend WithEvents EstoqueMedio As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EstDeposito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
