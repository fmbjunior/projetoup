<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoComposicaoAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProdutoComposicaoAdd))
        Me.Panel = New DevComponents.DotNetBar.PanelEx()
        Me.btProdutoFind = New System.Windows.Forms.Label()
        Me.btAdItem = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ProdComposicaoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.QtdUsar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ProdComposicao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.CanvasColor = System.Drawing.Color.Aquamarine
        Me.Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Panel.Controls.Add(Me.btProdutoFind)
        Me.Panel.Controls.Add(Me.btAdItem)
        Me.Panel.Controls.Add(Me.btFechar)
        Me.Panel.Controls.Add(Me.LabelX4)
        Me.Panel.Controls.Add(Me.LabelX1)
        Me.Panel.Controls.Add(Me.ProdComposicaoDesc)
        Me.Panel.Controls.Add(Me.QtdUsar)
        Me.Panel.Controls.Add(Me.ProdComposicao)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(546, 112)
        Me.Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Panel.Style.GradientAngle = 90
        Me.Panel.TabIndex = 0
        '
        'btProdutoFind
        '
        Me.btProdutoFind.Image = CType(resources.GetObject("btProdutoFind.Image"), System.Drawing.Image)
        Me.btProdutoFind.Location = New System.Drawing.Point(206, 12)
        Me.btProdutoFind.Name = "btProdutoFind"
        Me.btProdutoFind.Size = New System.Drawing.Size(23, 23)
        Me.btProdutoFind.TabIndex = 27
        '
        'btAdItem
        '
        Me.btAdItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdItem.Location = New System.Drawing.Point(355, 78)
        Me.btAdItem.Name = "btAdItem"
        Me.btAdItem.Size = New System.Drawing.Size(95, 27)
        Me.btAdItem.TabIndex = 20
        Me.btAdItem.Text = "Adicionar Item"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(457, 78)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(80, 27)
        Me.btFechar.TabIndex = 21
        Me.btFechar.Text = "Fechar"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(12, 41)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX4.Size = New System.Drawing.Size(103, 23)
        Me.LabelX4.TabIndex = 4
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
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX1.Size = New System.Drawing.Size(103, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Produto"
        '
        'ProdComposicaoDesc
        '
        Me.ProdComposicaoDesc.AceitaColarTexto = False
        Me.ProdComposicaoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdComposicaoDesc.CasasDecimais = 0
        Me.ProdComposicaoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdComposicaoDesc.CPObrigatorio = False
        Me.ProdComposicaoDesc.CPObrigatorioMsg = Nothing
        Me.ProdComposicaoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdComposicaoDesc.FlatBorder = False
        Me.ProdComposicaoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ProdComposicaoDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ProdComposicaoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdComposicaoDesc.HighlightBorderOnEnter = False
        Me.ProdComposicaoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProdComposicaoDesc.Location = New System.Drawing.Point(235, 12)
        Me.ProdComposicaoDesc.Name = "ProdComposicaoDesc"
        Me.ProdComposicaoDesc.PreencherZeroEsqueda = False
        Me.ProdComposicaoDesc.RegraValidação = Nothing
        Me.ProdComposicaoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdComposicaoDesc.Size = New System.Drawing.Size(302, 23)
        Me.ProdComposicaoDesc.TabIndex = 3
        Me.ProdComposicaoDesc.TabStop = False
        Me.ProdComposicaoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdComposicaoDesc.ValorPadrao = Nothing
        '
        'QtdUsar
        '
        Me.QtdUsar.AceitaColarTexto = False
        Me.QtdUsar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.QtdUsar.CasasDecimais = 4
        Me.QtdUsar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.QtdUsar.CPObrigatorio = False
        Me.QtdUsar.CPObrigatorioMsg = Nothing
        Me.QtdUsar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.QtdUsar.FlatBorder = False
        Me.QtdUsar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.QtdUsar.FocusColor = System.Drawing.Color.MistyRose
        Me.QtdUsar.FocusColorEnd = System.Drawing.Color.Empty
        Me.QtdUsar.HighlightBorderOnEnter = False
        Me.QtdUsar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.QtdUsar.Location = New System.Drawing.Point(121, 41)
        Me.QtdUsar.MaxLength = 15
        Me.QtdUsar.Name = "QtdUsar"
        Me.QtdUsar.PreencherZeroEsqueda = False
        Me.QtdUsar.RegraValidação = Nothing
        Me.QtdUsar.RegraValidaçãoMensagem = Nothing
        Me.QtdUsar.Size = New System.Drawing.Size(112, 23)
        Me.QtdUsar.TabIndex = 5
        Me.QtdUsar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtdUsar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.QtdUsar.ValorPadrao = Nothing
        '
        'ProdComposicao
        '
        Me.ProdComposicao.AceitaColarTexto = False
        Me.ProdComposicao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ProdComposicao.CasasDecimais = 0
        Me.ProdComposicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdComposicao.CPObrigatorio = False
        Me.ProdComposicao.CPObrigatorioMsg = Nothing
        Me.ProdComposicao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.ProdComposicao.FlatBorder = False
        Me.ProdComposicao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ProdComposicao.FocusColor = System.Drawing.Color.MistyRose
        Me.ProdComposicao.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdComposicao.HighlightBorderOnEnter = False
        Me.ProdComposicao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProdComposicao.Location = New System.Drawing.Point(121, 12)
        Me.ProdComposicao.MaxLength = 10
        Me.ProdComposicao.Name = "ProdComposicao"
        Me.ProdComposicao.PreencherZeroEsqueda = False
        Me.ProdComposicao.RegraValidação = Nothing
        Me.ProdComposicao.RegraValidaçãoMensagem = Nothing
        Me.ProdComposicao.Size = New System.Drawing.Size(82, 23)
        Me.ProdComposicao.TabIndex = 1
        Me.ProdComposicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ProdComposicao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdComposicao.ValorPadrao = Nothing
        '
        'ProdutoComposicaoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 112)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ProdutoComposicaoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Item da Composição - T198"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ProdComposicaoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents QtdUsar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ProdComposicao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAdItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btProdutoFind As System.Windows.Forms.Label
End Class
