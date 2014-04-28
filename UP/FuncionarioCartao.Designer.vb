<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuncionarioCartao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FuncionarioCartao))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Login = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btImpress = New DevComponents.DotNetBar.ButtonX()
        Me.Funcionario = New CBOAutoCompleteFocus.CboFocus()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataExpiracao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataCadastro = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InativoPorque = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Inativo = New System.Windows.Forms.CheckBox()
        Me.PermissaoMaster = New System.Windows.Forms.CheckBox()
        Me.UsadoParaVenda = New System.Windows.Forms.CheckBox()
        Me.idCartao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.NovoBT = New System.Windows.Forms.ToolStripButton()
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton()
        Me.EditarBT = New System.Windows.Forms.ToolStripButton()
        Me.InativarBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.btLocalizar = New System.Windows.Forms.ToolStripButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.Login)
        Me.PanelEx1.Controls.Add(Me.btImpress)
        Me.PanelEx1.Controls.Add(Me.Funcionario)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.DataExpiracao)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.DataCadastro)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.InativoPorque)
        Me.PanelEx1.Controls.Add(Me.Inativo)
        Me.PanelEx1.Controls.Add(Me.PermissaoMaster)
        Me.PanelEx1.Controls.Add(Me.UsadoParaVenda)
        Me.PanelEx1.Controls.Add(Me.idCartao)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.BarraBt)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(523, 308)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(7, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Login Relacionado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login
        '
        Me.Login.AceitaColarTexto = True
        Me.Login.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Login.CasasDecimais = 0
        Me.Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Login.CPObrigatorio = False
        Me.Login.CPObrigatorioMsg = Nothing
        Me.Login.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Login.FlatBorder = False
        Me.Login.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Login.FocusColor = System.Drawing.Color.Empty
        Me.Login.FocusColorEnd = System.Drawing.Color.Empty
        Me.Login.HighlightBorderOnEnter = False
        Me.Login.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Login.Location = New System.Drawing.Point(133, 269)
        Me.Login.MaxLength = 10
        Me.Login.Name = "Login"
        Me.Login.PreencherZeroEsqueda = False
        Me.Login.RegraValidação = Nothing
        Me.Login.RegraValidaçãoMensagem = Nothing
        Me.Login.Size = New System.Drawing.Size(137, 20)
        Me.Login.TabIndex = 16
        Me.Login.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Login.ValorPadrao = Nothing
        '
        'btImpress
        '
        Me.btImpress.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImpress.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImpress.Location = New System.Drawing.Point(394, 278)
        Me.btImpress.Name = "btImpress"
        Me.btImpress.Size = New System.Drawing.Size(117, 24)
        Me.btImpress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btImpress.TabIndex = 17
        Me.btImpress.Text = "Imprimir Cryptografia"
        '
        'Funcionario
        '
        Me.Funcionario.Auto_Complete = True
        Me.Funcionario.AutoLimitar_Lista = True
        Me.Funcionario.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.Funcionario.CPObrigatorio = False
        Me.Funcionario.CPObrigatorioMsg = Nothing
        Me.Funcionario.FlatBorder = False
        Me.Funcionario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Funcionario.FormattingEnabled = True
        Me.Funcionario.HighlightBorderColor = System.Drawing.Color.Empty
        Me.Funcionario.HighlightBorderOnEnter = False
        Me.Funcionario.Location = New System.Drawing.Point(133, 94)
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.Size = New System.Drawing.Size(349, 21)
        Me.Funcionario.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(8, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Data Expiração"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataExpiracao
        '
        Me.DataExpiracao.AceitaColarTexto = True
        Me.DataExpiracao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataExpiracao.CasasDecimais = 0
        Me.DataExpiracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataExpiracao.CPObrigatorio = False
        Me.DataExpiracao.CPObrigatorioMsg = Nothing
        Me.DataExpiracao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataExpiracao.FlatBorder = False
        Me.DataExpiracao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataExpiracao.FocusColor = System.Drawing.Color.Empty
        Me.DataExpiracao.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataExpiracao.HighlightBorderOnEnter = False
        Me.DataExpiracao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataExpiracao.Location = New System.Drawing.Point(134, 243)
        Me.DataExpiracao.MaxLength = 10
        Me.DataExpiracao.Name = "DataExpiracao"
        Me.DataExpiracao.PreencherZeroEsqueda = False
        Me.DataExpiracao.RegraValidação = Nothing
        Me.DataExpiracao.RegraValidaçãoMensagem = Nothing
        Me.DataExpiracao.Size = New System.Drawing.Size(136, 20)
        Me.DataExpiracao.TabIndex = 14
        Me.DataExpiracao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataExpiracao.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Data Cadastro"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataCadastro
        '
        Me.DataCadastro.AceitaColarTexto = True
        Me.DataCadastro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataCadastro.CasasDecimais = 0
        Me.DataCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataCadastro.CPObrigatorio = False
        Me.DataCadastro.CPObrigatorioMsg = Nothing
        Me.DataCadastro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataCadastro.FlatBorder = False
        Me.DataCadastro.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataCadastro.FocusColor = System.Drawing.Color.Empty
        Me.DataCadastro.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataCadastro.HighlightBorderOnEnter = False
        Me.DataCadastro.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataCadastro.Location = New System.Drawing.Point(134, 217)
        Me.DataCadastro.MaxLength = 10
        Me.DataCadastro.Name = "DataCadastro"
        Me.DataCadastro.PreencherZeroEsqueda = False
        Me.DataCadastro.RegraValidação = Nothing
        Me.DataCadastro.RegraValidaçãoMensagem = Nothing
        Me.DataCadastro.Size = New System.Drawing.Size(136, 20)
        Me.DataCadastro.TabIndex = 12
        Me.DataCadastro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataCadastro.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Inativo Porque ?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InativoPorque
        '
        Me.InativoPorque.AceitaColarTexto = True
        Me.InativoPorque.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.InativoPorque.CasasDecimais = 0
        Me.InativoPorque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.InativoPorque.CPObrigatorio = False
        Me.InativoPorque.CPObrigatorioMsg = Nothing
        Me.InativoPorque.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.InativoPorque.FlatBorder = False
        Me.InativoPorque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.InativoPorque.FocusColor = System.Drawing.Color.Empty
        Me.InativoPorque.FocusColorEnd = System.Drawing.Color.Empty
        Me.InativoPorque.HighlightBorderOnEnter = False
        Me.InativoPorque.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.InativoPorque.Location = New System.Drawing.Point(134, 191)
        Me.InativoPorque.MaxLength = 100
        Me.InativoPorque.Name = "InativoPorque"
        Me.InativoPorque.PreencherZeroEsqueda = False
        Me.InativoPorque.RegraValidação = Nothing
        Me.InativoPorque.RegraValidaçãoMensagem = Nothing
        Me.InativoPorque.Size = New System.Drawing.Size(377, 20)
        Me.InativoPorque.TabIndex = 10
        Me.InativoPorque.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.InativoPorque.ValorPadrao = Nothing
        '
        'Inativo
        '
        Me.Inativo.AutoSize = True
        Me.Inativo.Location = New System.Drawing.Point(134, 168)
        Me.Inativo.Name = "Inativo"
        Me.Inativo.Size = New System.Drawing.Size(58, 17)
        Me.Inativo.TabIndex = 8
        Me.Inativo.Text = "Inativo"
        Me.Inativo.UseVisualStyleBackColor = True
        '
        'PermissaoMaster
        '
        Me.PermissaoMaster.AutoSize = True
        Me.PermissaoMaster.Location = New System.Drawing.Point(134, 145)
        Me.PermissaoMaster.Name = "PermissaoMaster"
        Me.PermissaoMaster.Size = New System.Drawing.Size(109, 17)
        Me.PermissaoMaster.TabIndex = 7
        Me.PermissaoMaster.Text = "Permissão Master"
        Me.PermissaoMaster.UseVisualStyleBackColor = True
        '
        'UsadoParaVenda
        '
        Me.UsadoParaVenda.AutoSize = True
        Me.UsadoParaVenda.Location = New System.Drawing.Point(134, 122)
        Me.UsadoParaVenda.Name = "UsadoParaVenda"
        Me.UsadoParaVenda.Size = New System.Drawing.Size(120, 17)
        Me.UsadoParaVenda.TabIndex = 6
        Me.UsadoParaVenda.Text = "Usado para Vendas"
        Me.UsadoParaVenda.UseVisualStyleBackColor = True
        '
        'idCartao
        '
        Me.idCartao.AceitaColarTexto = True
        Me.idCartao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.idCartao.CasasDecimais = 0
        Me.idCartao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.idCartao.CPObrigatorio = False
        Me.idCartao.CPObrigatorioMsg = Nothing
        Me.idCartao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.idCartao.FlatBorder = False
        Me.idCartao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.idCartao.FocusColor = System.Drawing.Color.Empty
        Me.idCartao.FocusColorEnd = System.Drawing.Color.Empty
        Me.idCartao.HighlightBorderOnEnter = False
        Me.idCartao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.idCartao.Location = New System.Drawing.Point(133, 70)
        Me.idCartao.MaxLength = 4
        Me.idCartao.Name = "idCartao"
        Me.idCartao.PreencherZeroEsqueda = False
        Me.idCartao.RegraValidação = Nothing
        Me.idCartao.RegraValidaçãoMensagem = Nothing
        Me.idCartao.Size = New System.Drawing.Size(349, 20)
        Me.idCartao.TabIndex = 2
        Me.idCartao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.idCartao.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Funcionário"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id do Cartão"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.InativarBT, Me.FecharBT, Me.btLocalizar})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(523, 58)
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
        'InativarBT
        '
        Me.InativarBT.Image = CType(resources.GetObject("InativarBT.Image"), System.Drawing.Image)
        Me.InativarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InativarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.InativarBT.Name = "InativarBT"
        Me.InativarBT.Size = New System.Drawing.Size(54, 55)
        Me.InativarBT.Text = "Inativar"
        Me.InativarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.InativarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'btLocalizar
        '
        Me.btLocalizar.Image = CType(resources.GetObject("btLocalizar.Image"), System.Drawing.Image)
        Me.btLocalizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btLocalizar.Name = "btLocalizar"
        Me.btLocalizar.Size = New System.Drawing.Size(59, 55)
        Me.btLocalizar.Text = "Localizar"
        Me.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'FuncionarioCartao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "FuncionarioCartao"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cartão de Funcionário - T140"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents InativarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents idCartao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InativoPorque As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Inativo As System.Windows.Forms.CheckBox
    Friend WithEvents PermissaoMaster As System.Windows.Forms.CheckBox
    Friend WithEvents UsadoParaVenda As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataExpiracao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataCadastro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Funcionario As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents btLocalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btImpress As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Login As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
