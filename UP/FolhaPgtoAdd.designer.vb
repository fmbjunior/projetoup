<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoAdd
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoAdd))
        Me.CodPlanoContas = New TexBoxFocusNet.TextBoxFocusNet
        Me.FuncionarioDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Funcionario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.ModuloDescontar = New TexBoxFocusNet.TextBoxFocusNet
        Me.CompetenciaDesconto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.VlrDebito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.Evento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label10 = New System.Windows.Forms.Label
        Me.Historico = New TexBoxFocusNet.TextBoxFocusNet
        Me.Confirmado = New System.Windows.Forms.CheckBox
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.NovoBT = New System.Windows.Forms.ToolStripButton
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.ContaDebito = New TexBoxFocusNet.TextBoxFocusNet
        Me.ContaCredito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.MenuTipoGerador = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DecimoParcela1menu = New System.Windows.Forms.ToolStripMenuItem
        Me.DecimoParcela2Menu = New System.Windows.Forms.ToolStripMenuItem
        Me.FeriasMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.MensalistasMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.PgtoPISMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.RecisãoMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.Usuario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label11 = New System.Windows.Forms.Label
        Me.VlrCredito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Referencia = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.BarraBt.SuspendLayout()
        Me.MenuTipoGerador.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodPlanoContas
        '
        Me.CodPlanoContas.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CodPlanoContas.CasasDecimais = 0
        Me.CodPlanoContas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodPlanoContas.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodPlanoContas.FocusColor = System.Drawing.Color.Empty
        Me.CodPlanoContas.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodPlanoContas.Location = New System.Drawing.Point(448, 246)
        Me.CodPlanoContas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodPlanoContas.MaxLength = 20
        Me.CodPlanoContas.Name = "CodPlanoContas"
        Me.CodPlanoContas.RegraValidação = Nothing
        Me.CodPlanoContas.Size = New System.Drawing.Size(39, 20)
        Me.CodPlanoContas.TabIndex = 25
        Me.CodPlanoContas.TabStop = False
        Me.CodPlanoContas.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodPlanoContas.ValorPadrao = Nothing
        Me.CodPlanoContas.Visible = False
        '
        'FuncionarioDesc
        '
        Me.FuncionarioDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.FuncionarioDesc.CasasDecimais = 0
        Me.FuncionarioDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FuncionarioDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FuncionarioDesc.FocusColor = System.Drawing.Color.Empty
        Me.FuncionarioDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FuncionarioDesc.Location = New System.Drawing.Point(203, 222)
        Me.FuncionarioDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FuncionarioDesc.MaxLength = 50
        Me.FuncionarioDesc.Name = "FuncionarioDesc"
        Me.FuncionarioDesc.RegraValidação = Nothing
        Me.FuncionarioDesc.Size = New System.Drawing.Size(284, 20)
        Me.FuncionarioDesc.TabIndex = 18
        Me.FuncionarioDesc.TabStop = False
        Me.FuncionarioDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncionarioDesc.ValorPadrao = Nothing
        '
        'Funcionario
        '
        Me.Funcionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Funcionario.CasasDecimais = 0
        Me.Funcionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Funcionario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Funcionario.FocusColor = System.Drawing.Color.Empty
        Me.Funcionario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Funcionario.Location = New System.Drawing.Point(122, 222)
        Me.Funcionario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionario.MaxLength = 16
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.RegraValidação = Nothing
        Me.Funcionario.Size = New System.Drawing.Size(77, 20)
        Me.Funcionario.TabIndex = 17
        Me.Funcionario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Funcionario.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Funcionário"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(122, 111)
        Me.Id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Id.MaxLength = 16
        Me.Id.Name = "Id"
        Me.Id.RegraValidação = Nothing
        Me.Id.Size = New System.Drawing.Size(75, 20)
        Me.Id.TabIndex = 6
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Id"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModuloDescontar
        '
        Me.ModuloDescontar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ModuloDescontar.CasasDecimais = 0
        Me.ModuloDescontar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ModuloDescontar.FocusColor = System.Drawing.Color.Empty
        Me.ModuloDescontar.FocusColorEnd = System.Drawing.Color.Empty
        Me.ModuloDescontar.Location = New System.Drawing.Point(257, 83)
        Me.ModuloDescontar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ModuloDescontar.MaxLength = 16
        Me.ModuloDescontar.Name = "ModuloDescontar"
        Me.ModuloDescontar.RegraValidação = Nothing
        Me.ModuloDescontar.Size = New System.Drawing.Size(84, 20)
        Me.ModuloDescontar.TabIndex = 3
        Me.ModuloDescontar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ModuloDescontar.ValorPadrao = Nothing
        '
        'CompetenciaDesconto
        '
        Me.CompetenciaDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CompetenciaDesconto.CasasDecimais = 0
        Me.CompetenciaDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompetenciaDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.CompetenciaDesconto.FocusColor = System.Drawing.Color.Empty
        Me.CompetenciaDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompetenciaDesconto.Location = New System.Drawing.Point(122, 83)
        Me.CompetenciaDesconto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompetenciaDesconto.MaxLength = 7
        Me.CompetenciaDesconto.Name = "CompetenciaDesconto"
        Me.CompetenciaDesconto.RegraValidação = Nothing
        Me.CompetenciaDesconto.Size = New System.Drawing.Size(75, 20)
        Me.CompetenciaDesconto.TabIndex = 1
        Me.CompetenciaDesconto.TabStop = False
        Me.CompetenciaDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CompetenciaDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.CompetenciaDesconto.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(205, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Modulo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Competência"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VlrDebito
        '
        Me.VlrDebito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.VlrDebito.CasasDecimais = 2
        Me.VlrDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VlrDebito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VlrDebito.FocusColor = System.Drawing.Color.Empty
        Me.VlrDebito.FocusColorEnd = System.Drawing.Color.Empty
        Me.VlrDebito.Location = New System.Drawing.Point(122, 138)
        Me.VlrDebito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.VlrDebito.MaxLength = 10
        Me.VlrDebito.Name = "VlrDebito"
        Me.VlrDebito.RegraValidação = Nothing
        Me.VlrDebito.Size = New System.Drawing.Size(75, 20)
        Me.VlrDebito.TabIndex = 8
        Me.VlrDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrDebito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.VlrDebito.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Valor Débito"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Evento
        '
        Me.Evento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Evento.CasasDecimais = 0
        Me.Evento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Evento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Evento.FocusColor = System.Drawing.Color.Empty
        Me.Evento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Evento.Location = New System.Drawing.Point(122, 194)
        Me.Evento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Evento.MaxLength = 6
        Me.Evento.Name = "Evento"
        Me.Evento.RegraValidação = Nothing
        Me.Evento.Size = New System.Drawing.Size(77, 20)
        Me.Evento.TabIndex = 14
        Me.Evento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Evento.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 25)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Evento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Historico
        '
        Me.Historico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Historico.CasasDecimais = 0
        Me.Historico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Historico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Historico.FocusColor = System.Drawing.Color.Empty
        Me.Historico.FocusColorEnd = System.Drawing.Color.Empty
        Me.Historico.Location = New System.Drawing.Point(203, 194)
        Me.Historico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Historico.MaxLength = 30
        Me.Historico.Name = "Historico"
        Me.Historico.RegraValidação = Nothing
        Me.Historico.Size = New System.Drawing.Size(286, 20)
        Me.Historico.TabIndex = 15
        Me.Historico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Historico.ValorPadrao = Nothing
        '
        'Confirmado
        '
        Me.Confirmado.AutoSize = True
        Me.Confirmado.Location = New System.Drawing.Point(238, 308)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(84, 20)
        Me.Confirmado.TabIndex = 4
        Me.Confirmado.TabStop = False
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.UseVisualStyleBackColor = True
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(501, 68)
        Me.BarraBt.TabIndex = 26
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(54, 65)
        Me.NovoBT.Text = "Novo-F9"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalvarBT
        '
        Me.SalvarBT.Image = CType(resources.GetObject("SalvarBT.Image"), System.Drawing.Image)
        Me.SalvarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(63, 65)
        Me.SalvarBT.Text = "Salvar-F10"
        Me.SalvarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(76, 65)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ContaDebito
        '
        Me.ContaDebito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaDebito.CasasDecimais = 0
        Me.ContaDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaDebito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaDebito.FocusColor = System.Drawing.Color.Empty
        Me.ContaDebito.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaDebito.Location = New System.Drawing.Point(122, 250)
        Me.ContaDebito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContaDebito.MaxLength = 20
        Me.ContaDebito.Name = "ContaDebito"
        Me.ContaDebito.RegraValidação = Nothing
        Me.ContaDebito.Size = New System.Drawing.Size(148, 20)
        Me.ContaDebito.TabIndex = 20
        Me.ContaDebito.TabStop = False
        Me.ContaDebito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaDebito.ValorPadrao = Nothing
        '
        'ContaCredito
        '
        Me.ContaCredito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaCredito.CasasDecimais = 0
        Me.ContaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCredito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCredito.FocusColor = System.Drawing.Color.Empty
        Me.ContaCredito.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCredito.Location = New System.Drawing.Point(122, 278)
        Me.ContaCredito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContaCredito.MaxLength = 20
        Me.ContaCredito.Name = "ContaCredito"
        Me.ContaCredito.RegraValidação = Nothing
        Me.ContaCredito.Size = New System.Drawing.Size(148, 20)
        Me.ContaCredito.TabIndex = 22
        Me.ContaCredito.TabStop = False
        Me.ContaCredito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCredito.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(14, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Conta Débito"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(14, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Conta Crédito"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuTipoGerador
        '
        Me.MenuTipoGerador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DecimoParcela1menu, Me.DecimoParcela2Menu, Me.FeriasMenu, Me.MensalistasMenu, Me.PgtoPISMenu, Me.RecisãoMenu})
        Me.MenuTipoGerador.Name = "MenuTipoGerador"
        Me.MenuTipoGerador.Size = New System.Drawing.Size(153, 136)
        '
        'DecimoParcela1menu
        '
        Me.DecimoParcela1menu.Name = "DecimoParcela1menu"
        Me.DecimoParcela1menu.Size = New System.Drawing.Size(152, 22)
        Me.DecimoParcela1menu.Text = "1 Par Dec. Terç"
        '
        'DecimoParcela2Menu
        '
        Me.DecimoParcela2Menu.Name = "DecimoParcela2Menu"
        Me.DecimoParcela2Menu.Size = New System.Drawing.Size(152, 22)
        Me.DecimoParcela2Menu.Text = "2 Par Dec. Terç"
        '
        'FeriasMenu
        '
        Me.FeriasMenu.Name = "FeriasMenu"
        Me.FeriasMenu.Size = New System.Drawing.Size(152, 22)
        Me.FeriasMenu.Text = "Férias"
        '
        'MensalistasMenu
        '
        Me.MensalistasMenu.Name = "MensalistasMenu"
        Me.MensalistasMenu.Size = New System.Drawing.Size(152, 22)
        Me.MensalistasMenu.Text = "Mensalistas"
        '
        'PgtoPISMenu
        '
        Me.PgtoPISMenu.Name = "PgtoPISMenu"
        Me.PgtoPISMenu.Size = New System.Drawing.Size(152, 22)
        Me.PgtoPISMenu.Text = "Pgto PIS"
        '
        'RecisãoMenu
        '
        Me.RecisãoMenu.Name = "RecisãoMenu"
        Me.RecisãoMenu.Size = New System.Drawing.Size(152, 22)
        Me.RecisãoMenu.Text = "Recisão"
        '
        'Usuario
        '
        Me.Usuario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Usuario.CasasDecimais = 0
        Me.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usuario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Usuario.FocusColor = System.Drawing.Color.Empty
        Me.Usuario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Usuario.Location = New System.Drawing.Point(122, 306)
        Me.Usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Usuario.MaxLength = 16
        Me.Usuario.Name = "Usuario"
        Me.Usuario.RegraValidação = Nothing
        Me.Usuario.Size = New System.Drawing.Size(105, 20)
        Me.Usuario.TabIndex = 24
        Me.Usuario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Usuario.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 25)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Usuário"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VlrCredito
        '
        Me.VlrCredito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.VlrCredito.CasasDecimais = 2
        Me.VlrCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VlrCredito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VlrCredito.FocusColor = System.Drawing.Color.Empty
        Me.VlrCredito.FocusColorEnd = System.Drawing.Color.Empty
        Me.VlrCredito.Location = New System.Drawing.Point(325, 138)
        Me.VlrCredito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.VlrCredito.MaxLength = 10
        Me.VlrCredito.Name = "VlrCredito"
        Me.VlrCredito.RegraValidação = Nothing
        Me.VlrCredito.Size = New System.Drawing.Size(75, 20)
        Me.VlrCredito.TabIndex = 10
        Me.VlrCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrCredito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.VlrCredito.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(217, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Valor Crédito"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.Referencia)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.VlrCredito)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.ModuloDescontar)
        Me.Fundo.Controls.Add(Me.Usuario)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.CompetenciaDesconto)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.VlrDebito)
        Me.Fundo.Controls.Add(Me.ContaCredito)
        Me.Fundo.Controls.Add(Me.Funcionario)
        Me.Fundo.Controls.Add(Me.ContaDebito)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.CodPlanoContas)
        Me.Fundo.Controls.Add(Me.FuncionarioDesc)
        Me.Fundo.Controls.Add(Me.Confirmado)
        Me.Fundo.Controls.Add(Me.Evento)
        Me.Fundo.Controls.Add(Me.Historico)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(501, 332)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.LightSkyBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 198
        '
        'Referencia
        '
        Me.Referencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Referencia.CasasDecimais = 0
        Me.Referencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Referencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Referencia.FocusColor = System.Drawing.Color.Empty
        Me.Referencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Referencia.Location = New System.Drawing.Point(122, 166)
        Me.Referencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Referencia.MaxLength = 6
        Me.Referencia.Name = "Referencia"
        Me.Referencia.RegraValidação = Nothing
        Me.Referencia.Size = New System.Drawing.Size(39, 20)
        Me.Referencia.TabIndex = 12
        Me.Referencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Referencia.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Referencia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FolhaPgtoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vale para Funcionário"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.MenuTipoGerador.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CodPlanoContas As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents FuncionarioDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Funcionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ModuloDescontar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CompetenciaDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VlrDebito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Evento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Historico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Confirmado As System.Windows.Forms.CheckBox
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContaDebito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaCredito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MenuTipoGerador As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DecimoParcela1menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecimoParcela2Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeriasMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MensalistasMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PgtoPISMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecisãoMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Usuario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents VlrCredito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Referencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
