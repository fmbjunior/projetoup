<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancosContaCorrente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BancosContaCorrente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Codigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomeBanco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContaCorrente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Agencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Telefone = New TexBoxFocusNet.TextBoxFocusNet()
        Me.AgruparFluxoCaixa = New System.Windows.Forms.CheckBox()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.NovoBT = New System.Windows.Forms.ToolStripButton()
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton()
        Me.EditarBT = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraBt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Codigo.FocusColor = System.Drawing.Color.MistyRose
        Me.Codigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Codigo.HighlightBorderOnEnter = False
        Me.Codigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Codigo.Location = New System.Drawing.Point(123, 70)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.PreencherZeroEsqueda = False
        Me.Codigo.RegraValidação = Nothing
        Me.Codigo.RegraValidaçãoMensagem = Nothing
        Me.Codigo.Size = New System.Drawing.Size(75, 23)
        Me.Codigo.TabIndex = 1
        Me.Codigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Codigo.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome Banco"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeBanco
        '
        Me.NomeBanco.AceitaColarTexto = True
        Me.NomeBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeBanco.CasasDecimais = 0
        Me.NomeBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeBanco.CPObrigatorio = False
        Me.NomeBanco.CPObrigatorioMsg = Nothing
        Me.NomeBanco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeBanco.FlatBorder = False
        Me.NomeBanco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeBanco.FocusColor = System.Drawing.Color.MistyRose
        Me.NomeBanco.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeBanco.HighlightBorderOnEnter = False
        Me.NomeBanco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeBanco.Location = New System.Drawing.Point(123, 99)
        Me.NomeBanco.MaxLength = 35
        Me.NomeBanco.Name = "NomeBanco"
        Me.NomeBanco.PreencherZeroEsqueda = False
        Me.NomeBanco.RegraValidação = Nothing
        Me.NomeBanco.RegraValidaçãoMensagem = Nothing
        Me.NomeBanco.Size = New System.Drawing.Size(380, 23)
        Me.NomeBanco.TabIndex = 3
        Me.NomeBanco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeBanco.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Conta Corrente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaCorrente
        '
        Me.ContaCorrente.AceitaColarTexto = True
        Me.ContaCorrente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaCorrente.CasasDecimais = 0
        Me.ContaCorrente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCorrente.CPObrigatorio = False
        Me.ContaCorrente.CPObrigatorioMsg = Nothing
        Me.ContaCorrente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCorrente.FlatBorder = False
        Me.ContaCorrente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCorrente.FocusColor = System.Drawing.Color.MistyRose
        Me.ContaCorrente.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCorrente.HighlightBorderOnEnter = False
        Me.ContaCorrente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCorrente.Location = New System.Drawing.Point(123, 128)
        Me.ContaCorrente.MaxLength = 15
        Me.ContaCorrente.Name = "ContaCorrente"
        Me.ContaCorrente.PreencherZeroEsqueda = False
        Me.ContaCorrente.RegraValidação = Nothing
        Me.ContaCorrente.RegraValidaçãoMensagem = Nothing
        Me.ContaCorrente.Size = New System.Drawing.Size(116, 23)
        Me.ContaCorrente.TabIndex = 5
        Me.ContaCorrente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCorrente.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Agência"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Agencia
        '
        Me.Agencia.AceitaColarTexto = True
        Me.Agencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Agencia.CasasDecimais = 0
        Me.Agencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Agencia.CPObrigatorio = False
        Me.Agencia.CPObrigatorioMsg = Nothing
        Me.Agencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Agencia.FlatBorder = False
        Me.Agencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Agencia.FocusColor = System.Drawing.Color.MistyRose
        Me.Agencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Agencia.HighlightBorderOnEnter = False
        Me.Agencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Agencia.Location = New System.Drawing.Point(123, 157)
        Me.Agencia.MaxLength = 15
        Me.Agencia.Name = "Agencia"
        Me.Agencia.PreencherZeroEsqueda = False
        Me.Agencia.RegraValidação = Nothing
        Me.Agencia.RegraValidaçãoMensagem = Nothing
        Me.Agencia.Size = New System.Drawing.Size(116, 23)
        Me.Agencia.TabIndex = 7
        Me.Agencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Agencia.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(300, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefone"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Telefone
        '
        Me.Telefone.AceitaColarTexto = True
        Me.Telefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Telefone.CasasDecimais = 0
        Me.Telefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telefone.CPObrigatorio = False
        Me.Telefone.CPObrigatorioMsg = Nothing
        Me.Telefone.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Telefone.FlatBorder = False
        Me.Telefone.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Telefone.FocusColor = System.Drawing.Color.MistyRose
        Me.Telefone.FocusColorEnd = System.Drawing.Color.Empty
        Me.Telefone.HighlightBorderOnEnter = False
        Me.Telefone.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Telefone.Location = New System.Drawing.Point(387, 157)
        Me.Telefone.MaxLength = 13
        Me.Telefone.Name = "Telefone"
        Me.Telefone.PreencherZeroEsqueda = False
        Me.Telefone.RegraValidação = Nothing
        Me.Telefone.RegraValidaçãoMensagem = Nothing
        Me.Telefone.Size = New System.Drawing.Size(116, 23)
        Me.Telefone.TabIndex = 9
        Me.Telefone.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Fone
        Me.Telefone.ValorPadrao = Nothing
        '
        'AgruparFluxoCaixa
        '
        Me.AgruparFluxoCaixa.AutoSize = True
        Me.AgruparFluxoCaixa.Location = New System.Drawing.Point(123, 186)
        Me.AgruparFluxoCaixa.Name = "AgruparFluxoCaixa"
        Me.AgruparFluxoCaixa.Size = New System.Drawing.Size(203, 19)
        Me.AgruparFluxoCaixa.TabIndex = 10
        Me.AgruparFluxoCaixa.Text = "Agrupar Conta no Fluxo de Caixa ?"
        Me.AgruparFluxoCaixa.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.AgruparFluxoCaixa)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Codigo)
        Me.Fundo.Controls.Add(Me.NomeBanco)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.ContaCorrente)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Agencia)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Telefone)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(519, 464)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.TxtProcura)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.Lista)
        Me.GroupPanel1.Location = New System.Drawing.Point(6, 206)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(503, 246)
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
        Me.GroupPanel1.TabIndex = 11
        Me.GroupPanel1.Text = "Procura de Marcas"
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(175, 166)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(55, 19)
        Me.A3.TabIndex = 3
        Me.A3.TabStop = True
        Me.A3.Text = "Todos"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 166)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(60, 19)
        Me.A1.TabIndex = 1
        Me.A1.TabStop = True
        Me.A1.Text = "Código"
        Me.A1.UseVisualStyleBackColor = True
        '
        'TxtProcura
        '
        Me.TxtProcura.AceitaColarTexto = True
        Me.TxtProcura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TxtProcura.CasasDecimais = 0
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.CPObrigatorio = False
        Me.TxtProcura.CPObrigatorioMsg = Nothing
        Me.TxtProcura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TxtProcura.FlatBorder = False
        Me.TxtProcura.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TxtProcura.FocusColor = System.Drawing.Color.Empty
        Me.TxtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.TxtProcura.HighlightBorderOnEnter = False
        Me.TxtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TxtProcura.Location = New System.Drawing.Point(3, 191)
        Me.TxtProcura.MaxLength = 30
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.PreencherZeroEsqueda = False
        Me.TxtProcura.RegraValidação = Nothing
        Me.TxtProcura.RegraValidaçãoMensagem = Nothing
        Me.TxtProcura.Size = New System.Drawing.Size(491, 23)
        Me.TxtProcura.TabIndex = 4
        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(69, 166)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(102, 19)
        Me.A2.TabIndex = 2
        Me.A2.TabStop = True
        Me.A2.Text = "Conta Corrente"
        Me.A2.UseVisualStyleBackColor = True
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(3, 2)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(491, 158)
        Me.Lista.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codigo"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ContaCorrente"
        Me.Column2.HeaderText = "Conta Corrente"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "NomeBanco"
        Me.Column3.HeaderText = "Nome Banco"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 270
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ExcluirBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(519, 56)
        Me.BarraBt.TabIndex = 12
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(40, 53)
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
        Me.SalvarBT.Size = New System.Drawing.Size(41, 53)
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
        Me.EditarBT.Size = New System.Drawing.Size(41, 53)
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
        Me.ExcluirBT.Size = New System.Drawing.Size(44, 53)
        Me.ExcluirBT.Text = "Excluir"
        Me.ExcluirBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExcluirBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(45, 53)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'BancosContaCorrente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BancosContaCorrente"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bancos/Contas Correntes - T101"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Codigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomeBanco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContaCorrente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Agencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Telefone As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents AgruparFluxoCaixa As System.Windows.Forms.CheckBox
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
