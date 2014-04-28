<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servicos))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ValorServico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.descricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codigoServico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.NovoBT = New System.Windows.Forms.ToolStripButton()
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton()
        Me.EditarBT = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton()
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Referencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.cGrupoServico = New CBOAutoCompleteFocus.CboFocus()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DescontoMaximo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(15, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 19)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Valor Serviço"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorServico
        '
        Me.ValorServico.AceitaColarTexto = True
        Me.ValorServico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorServico.CasasDecimais = 4
        Me.ValorServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorServico.CPObrigatorio = False
        Me.ValorServico.CPObrigatorioMsg = Nothing
        Me.ValorServico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorServico.FlatBorder = False
        Me.ValorServico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorServico.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorServico.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorServico.HighlightBorderOnEnter = False
        Me.ValorServico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorServico.Location = New System.Drawing.Point(146, 245)
        Me.ValorServico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValorServico.MaxLength = 10
        Me.ValorServico.Name = "ValorServico"
        Me.ValorServico.PreencherZeroEsqueda = False
        Me.ValorServico.RegraValidação = Nothing
        Me.ValorServico.RegraValidaçãoMensagem = Nothing
        Me.ValorServico.Size = New System.Drawing.Size(113, 23)
        Me.ValorServico.TabIndex = 10
        Me.ValorServico.Tag = "O valor de venda não pode ser zero"
        Me.ValorServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorServico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorServico.ValorPadrao = Nothing
        '
        'descricao
        '
        Me.descricao.AceitaColarTexto = True
        Me.descricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.descricao.CasasDecimais = 0
        Me.descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.descricao.CPObrigatorio = False
        Me.descricao.CPObrigatorioMsg = Nothing
        Me.descricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.descricao.FlatBorder = False
        Me.descricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.descricao.FocusColor = System.Drawing.Color.MistyRose
        Me.descricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.descricao.HighlightBorderOnEnter = False
        Me.descricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.descricao.Location = New System.Drawing.Point(146, 95)
        Me.descricao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.descricao.MaxLength = 120
        Me.descricao.Name = "descricao"
        Me.descricao.PreencherZeroEsqueda = False
        Me.descricao.RegraValidação = Nothing
        Me.descricao.RegraValidaçãoMensagem = Nothing
        Me.descricao.Size = New System.Drawing.Size(437, 23)
        Me.descricao.TabIndex = 5
        Me.descricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.descricao.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'codigoServico
        '
        Me.codigoServico.AceitaColarTexto = True
        Me.codigoServico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.codigoServico.CasasDecimais = 0
        Me.codigoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.codigoServico.CPObrigatorio = False
        Me.codigoServico.CPObrigatorioMsg = Nothing
        Me.codigoServico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.codigoServico.FlatBorder = False
        Me.codigoServico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.codigoServico.FocusColor = System.Drawing.Color.MistyRose
        Me.codigoServico.FocusColorEnd = System.Drawing.Color.Empty
        Me.codigoServico.HighlightBorderOnEnter = False
        Me.codigoServico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.codigoServico.Location = New System.Drawing.Point(146, 67)
        Me.codigoServico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.codigoServico.Name = "codigoServico"
        Me.codigoServico.PreencherZeroEsqueda = False
        Me.codigoServico.RegraValidação = Nothing
        Me.codigoServico.RegraValidaçãoMensagem = Nothing
        Me.codigoServico.Size = New System.Drawing.Size(73, 23)
        Me.codigoServico.TabIndex = 2
        Me.codigoServico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.codigoServico.ValorPadrao = Nothing
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ExcluirBT, Me.LocalizarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(600, 58)
        Me.BarraBt.TabIndex = 0
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(40, 55)
        Me.NovoBT.Text = "Novo"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalvarBT
        '
        Me.SalvarBT.Image = CType(resources.GetObject("SalvarBT.Image"), System.Drawing.Image)
        Me.SalvarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(45, 55)
        Me.SalvarBT.Text = "Salvar"
        Me.SalvarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EditarBT
        '
        Me.EditarBT.Image = CType(resources.GetObject("EditarBT.Image"), System.Drawing.Image)
        Me.EditarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditarBT.Name = "EditarBT"
        Me.EditarBT.Size = New System.Drawing.Size(43, 55)
        Me.EditarBT.Text = "Editar"
        Me.EditarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcluirBT
        '
        Me.ExcluirBT.Image = CType(resources.GetObject("ExcluirBT.Image"), System.Drawing.Image)
        Me.ExcluirBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirBT.Name = "ExcluirBT"
        Me.ExcluirBT.Size = New System.Drawing.Size(49, 55)
        Me.ExcluirBT.Text = "Excluir"
        Me.ExcluirBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExcluirBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LocalizarBT
        '
        Me.LocalizarBT.Image = CType(resources.GetObject("LocalizarBT.Image"), System.Drawing.Image)
        Me.LocalizarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LocalizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LocalizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LocalizarBT.Name = "LocalizarBT"
        Me.LocalizarBT.Size = New System.Drawing.Size(59, 55)
        Me.LocalizarBT.Text = "Localizar"
        Me.LocalizarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LocalizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(46, 55)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(15, 156)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(115, 19)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Referência"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Referencia
        '
        Me.Referencia.AceitaColarTexto = True
        Me.Referencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Referencia.CasasDecimais = 0
        Me.Referencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Referencia.CPObrigatorio = False
        Me.Referencia.CPObrigatorioMsg = Nothing
        Me.Referencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Referencia.FlatBorder = False
        Me.Referencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Referencia.FocusColor = System.Drawing.Color.MistyRose
        Me.Referencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Referencia.HighlightBorderOnEnter = False
        Me.Referencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Referencia.Location = New System.Drawing.Point(146, 156)
        Me.Referencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Referencia.MaxLength = 250
        Me.Referencia.Multiline = True
        Me.Referencia.Name = "Referencia"
        Me.Referencia.PreencherZeroEsqueda = False
        Me.Referencia.RegraValidação = Nothing
        Me.Referencia.RegraValidaçãoMensagem = Nothing
        Me.Referencia.Size = New System.Drawing.Size(437, 49)
        Me.Referencia.TabIndex = 8
        Me.Referencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Referencia.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.cGrupoServico)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.codigoServico)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label27)
        Me.Fundo.Controls.Add(Me.Referencia)
        Me.Fundo.Controls.Add(Me.descricao)
        Me.Fundo.Controls.Add(Me.DescontoMaximo)
        Me.Fundo.Controls.Add(Me.ValorServico)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(600, 324)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'cGrupoServico
        '
        Me.cGrupoServico.Auto_Complete = True
        Me.cGrupoServico.AutoLimitar_Lista = True
        Me.cGrupoServico.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cGrupoServico.CPObrigatorio = False
        Me.cGrupoServico.CPObrigatorioMsg = Nothing
        Me.cGrupoServico.FlatBorder = False
        Me.cGrupoServico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cGrupoServico.FormattingEnabled = True
        Me.cGrupoServico.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cGrupoServico.HighlightBorderOnEnter = False
        Me.cGrupoServico.Location = New System.Drawing.Point(146, 125)
        Me.cGrupoServico.Name = "cGrupoServico"
        Me.cGrupoServico.Size = New System.Drawing.Size(437, 23)
        Me.cGrupoServico.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Grupo Serviço"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descrição Serviço"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Desconto Maximo %"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescontoMaximo
        '
        Me.DescontoMaximo.AceitaColarTexto = True
        Me.DescontoMaximo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescontoMaximo.CasasDecimais = 2
        Me.DescontoMaximo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescontoMaximo.CPObrigatorio = False
        Me.DescontoMaximo.CPObrigatorioMsg = Nothing
        Me.DescontoMaximo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescontoMaximo.FlatBorder = False
        Me.DescontoMaximo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescontoMaximo.FocusColor = System.Drawing.Color.MistyRose
        Me.DescontoMaximo.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescontoMaximo.HighlightBorderOnEnter = False
        Me.DescontoMaximo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescontoMaximo.Location = New System.Drawing.Point(146, 214)
        Me.DescontoMaximo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DescontoMaximo.MaxLength = 15
        Me.DescontoMaximo.Name = "DescontoMaximo"
        Me.DescontoMaximo.PreencherZeroEsqueda = False
        Me.DescontoMaximo.RegraValidação = Nothing
        Me.DescontoMaximo.RegraValidaçãoMensagem = Nothing
        Me.DescontoMaximo.Size = New System.Drawing.Size(73, 23)
        Me.DescontoMaximo.TabIndex = 10
        Me.DescontoMaximo.Tag = ""
        Me.DescontoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DescontoMaximo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.DescontoMaximo.ValorPadrao = "0"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Servicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Servicos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviços - T244"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ValorServico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents descricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents codigoServico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Referencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cGrupoServico As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DescontoMaximo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
