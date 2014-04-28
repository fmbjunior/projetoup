<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoEventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoEventos))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Indicador = New TexBoxFocusNet.TextBoxFocusNet
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.NovoBT = New System.Windows.Forms.ToolStripButton
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton
        Me.EditarBT = New System.Windows.Forms.ToolStripButton
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.CodigoEvento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Descrição = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.Perc_Valor = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.VlrBase = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.Debito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.Credito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CalculoSobre = New TexBoxFocusNet.TextBoxFocusNet
        Me.SalarioDiferenca = New System.Windows.Forms.RadioButton
        Me.SalarioRegistro = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SalarioFamilia = New System.Windows.Forms.RadioButton
        Me.Inss = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.SomenteEvento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.BarraBt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Indicador"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Indicador
        '
        Me.Indicador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Indicador.CasasDecimais = 2
        Me.Indicador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Indicador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Indicador.FocusColor = System.Drawing.Color.Empty
        Me.Indicador.FocusColorEnd = System.Drawing.Color.Empty
        Me.Indicador.Location = New System.Drawing.Point(120, 135)
        Me.Indicador.MaxLength = 1
        Me.Indicador.Name = "Indicador"
        Me.Indicador.RegraValidação = "D;C"
        Me.Indicador.Size = New System.Drawing.Size(31, 20)
        Me.Indicador.TabIndex = 7
        Me.Indicador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Indicador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Indicador.ValorPadrao = Nothing
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.LocalizarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(494, 68)
        Me.BarraBt.TabIndex = 20
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
        'EditarBT
        '
        Me.EditarBT.Image = CType(resources.GetObject("EditarBT.Image"), System.Drawing.Image)
        Me.EditarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditarBT.Name = "EditarBT"
        Me.EditarBT.Size = New System.Drawing.Size(63, 65)
        Me.EditarBT.Text = "Editar-F11"
        Me.EditarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LocalizarBT
        '
        Me.LocalizarBT.Image = CType(resources.GetObject("LocalizarBT.Image"), System.Drawing.Image)
        Me.LocalizarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LocalizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LocalizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LocalizarBT.Name = "LocalizarBT"
        Me.LocalizarBT.Size = New System.Drawing.Size(71, 65)
        Me.LocalizarBT.Text = "Localizar-F7"
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
        Me.FecharBT.Size = New System.Drawing.Size(76, 65)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoEvento
        '
        Me.CodigoEvento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CodigoEvento.CasasDecimais = 0
        Me.CodigoEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoEvento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoEvento.FocusColor = System.Drawing.Color.Empty
        Me.CodigoEvento.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoEvento.Location = New System.Drawing.Point(120, 83)
        Me.CodigoEvento.MaxLength = 10
        Me.CodigoEvento.Name = "CodigoEvento"
        Me.CodigoEvento.RegraValidação = Nothing
        Me.CodigoEvento.Size = New System.Drawing.Size(100, 20)
        Me.CodigoEvento.TabIndex = 1
        Me.CodigoEvento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoEvento.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descrição"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Descrição
        '
        Me.Descrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Descrição.CasasDecimais = 2
        Me.Descrição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descrição.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Descrição.FocusColor = System.Drawing.Color.Empty
        Me.Descrição.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descrição.Location = New System.Drawing.Point(120, 109)
        Me.Descrição.MaxLength = 30
        Me.Descrição.Name = "Descrição"
        Me.Descrição.RegraValidação = Nothing
        Me.Descrição.Size = New System.Drawing.Size(363, 20)
        Me.Descrição.TabIndex = 5
        Me.Descrição.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descrição.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Perc ou Valor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Perc_Valor
        '
        Me.Perc_Valor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Perc_Valor.CasasDecimais = 2
        Me.Perc_Valor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Perc_Valor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Perc_Valor.FocusColor = System.Drawing.Color.Empty
        Me.Perc_Valor.FocusColorEnd = System.Drawing.Color.Empty
        Me.Perc_Valor.Location = New System.Drawing.Point(120, 161)
        Me.Perc_Valor.MaxLength = 1
        Me.Perc_Valor.Name = "Perc_Valor"
        Me.Perc_Valor.RegraValidação = "P;V"
        Me.Perc_Valor.Size = New System.Drawing.Size(31, 20)
        Me.Perc_Valor.TabIndex = 11
        Me.Perc_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Perc_Valor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Perc_Valor.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Tag = ""
        Me.Label5.Text = "Vlr Base"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VlrBase
        '
        Me.VlrBase.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.VlrBase.CasasDecimais = 2
        Me.VlrBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VlrBase.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VlrBase.FocusColor = System.Drawing.Color.Empty
        Me.VlrBase.FocusColorEnd = System.Drawing.Color.Empty
        Me.VlrBase.Location = New System.Drawing.Point(120, 187)
        Me.VlrBase.MaxLength = 8
        Me.VlrBase.Name = "VlrBase"
        Me.VlrBase.RegraValidação = Nothing
        Me.VlrBase.Size = New System.Drawing.Size(100, 20)
        Me.VlrBase.TabIndex = 14
        Me.VlrBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrBase.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.VlrBase.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Conta Débito"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Debito
        '
        Me.Debito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Debito.CasasDecimais = 2
        Me.Debito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Debito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Debito.FocusColor = System.Drawing.Color.Empty
        Me.Debito.FocusColorEnd = System.Drawing.Color.Empty
        Me.Debito.Location = New System.Drawing.Point(120, 213)
        Me.Debito.MaxLength = 14
        Me.Debito.Name = "Debito"
        Me.Debito.RegraValidação = Nothing
        Me.Debito.Size = New System.Drawing.Size(100, 20)
        Me.Debito.TabIndex = 16
        Me.Debito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Debito.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Conta Crédito"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Credito
        '
        Me.Credito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Credito.CasasDecimais = 2
        Me.Credito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Credito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Credito.FocusColor = System.Drawing.Color.Empty
        Me.Credito.FocusColorEnd = System.Drawing.Color.Empty
        Me.Credito.Location = New System.Drawing.Point(120, 242)
        Me.Credito.MaxLength = 14
        Me.Credito.Name = "Credito"
        Me.Credito.RegraValidação = Nothing
        Me.Credito.Size = New System.Drawing.Size(100, 20)
        Me.Credito.TabIndex = 18
        Me.Credito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Credito.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(157, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "<-D-Débito C-Crédito"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(157, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "<-P-Percentual. V-Valor"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CalculoSobre)
        Me.GroupBox1.Controls.Add(Me.SalarioDiferenca)
        Me.GroupBox1.Controls.Add(Me.SalarioRegistro)
        Me.GroupBox1.Location = New System.Drawing.Point(300, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 59)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculo Sobre"
        '
        'CalculoSobre
        '
        Me.CalculoSobre.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CalculoSobre.CasasDecimais = 2
        Me.CalculoSobre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CalculoSobre.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CalculoSobre.FocusColor = System.Drawing.Color.Empty
        Me.CalculoSobre.FocusColorEnd = System.Drawing.Color.Empty
        Me.CalculoSobre.Location = New System.Drawing.Point(127, 18)
        Me.CalculoSobre.MaxLength = 14
        Me.CalculoSobre.Name = "CalculoSobre"
        Me.CalculoSobre.RegraValidação = Nothing
        Me.CalculoSobre.Size = New System.Drawing.Size(50, 20)
        Me.CalculoSobre.TabIndex = 1
        Me.CalculoSobre.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CalculoSobre.ValorPadrao = Nothing
        Me.CalculoSobre.Visible = False
        '
        'SalarioDiferenca
        '
        Me.SalarioDiferenca.AutoSize = True
        Me.SalarioDiferenca.Location = New System.Drawing.Point(8, 37)
        Me.SalarioDiferenca.Name = "SalarioDiferenca"
        Me.SalarioDiferenca.Size = New System.Drawing.Size(111, 20)
        Me.SalarioDiferenca.TabIndex = 2
        Me.SalarioDiferenca.TabStop = True
        Me.SalarioDiferenca.Text = "Salário Diferença"
        Me.SalarioDiferenca.UseVisualStyleBackColor = True
        '
        'SalarioRegistro
        '
        Me.SalarioRegistro.AutoSize = True
        Me.SalarioRegistro.Location = New System.Drawing.Point(8, 19)
        Me.SalarioRegistro.Name = "SalarioRegistro"
        Me.SalarioRegistro.Size = New System.Drawing.Size(104, 20)
        Me.SalarioRegistro.TabIndex = 0
        Me.SalarioRegistro.TabStop = True
        Me.SalarioRegistro.Text = "Salário Registro"
        Me.SalarioRegistro.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SalarioFamilia)
        Me.GroupBox2.Controls.Add(Me.Inss)
        Me.GroupBox2.Location = New System.Drawing.Point(300, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 46)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calculo Específico"
        '
        'SalarioFamilia
        '
        Me.SalarioFamilia.AutoSize = True
        Me.SalarioFamilia.Location = New System.Drawing.Point(72, 19)
        Me.SalarioFamilia.Name = "SalarioFamilia"
        Me.SalarioFamilia.Size = New System.Drawing.Size(105, 20)
        Me.SalarioFamilia.TabIndex = 1
        Me.SalarioFamilia.TabStop = True
        Me.SalarioFamilia.Text = "É Salário Família"
        Me.SalarioFamilia.UseVisualStyleBackColor = True
        '
        'Inss
        '
        Me.Inss.AutoSize = True
        Me.Inss.Location = New System.Drawing.Point(8, 19)
        Me.Inss.Name = "Inss"
        Me.Inss.Size = New System.Drawing.Size(55, 20)
        Me.Inss.TabIndex = 0
        Me.Inss.TabStop = True
        Me.Inss.Text = "É Inss"
        Me.Inss.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(233, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Somente Evento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SomenteEvento
        '
        Me.SomenteEvento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SomenteEvento.CasasDecimais = 0
        Me.SomenteEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SomenteEvento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SomenteEvento.FocusColor = System.Drawing.Color.Empty
        Me.SomenteEvento.FocusColorEnd = System.Drawing.Color.Empty
        Me.SomenteEvento.Location = New System.Drawing.Point(341, 83)
        Me.SomenteEvento.MaxLength = 10
        Me.SomenteEvento.Name = "SomenteEvento"
        Me.SomenteEvento.RegraValidação = "S;N"
        Me.SomenteEvento.Size = New System.Drawing.Size(34, 20)
        Me.SomenteEvento.TabIndex = 3
        Me.SomenteEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SomenteEvento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.SomenteEvento.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.Indicador)
        Me.Fundo.Controls.Add(Me.SomenteEvento)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.GroupBox2)
        Me.Fundo.Controls.Add(Me.CodigoEvento)
        Me.Fundo.Controls.Add(Me.GroupBox1)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Descrição)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Perc_Valor)
        Me.Fundo.Controls.Add(Me.Credito)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.VlrBase)
        Me.Fundo.Controls.Add(Me.Debito)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(494, 267)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 21
        '
        'FolhaPgtoEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoEventos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos da Folha de Pagamento"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Indicador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CodigoEvento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Descrição As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Perc_Valor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VlrBase As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Debito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Credito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SalarioDiferenca As System.Windows.Forms.RadioButton
    Friend WithEvents SalarioRegistro As System.Windows.Forms.RadioButton
    Friend WithEvents CalculoSobre As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SalarioFamilia As System.Windows.Forms.RadioButton
    Friend WithEvents Inss As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SomenteEvento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
