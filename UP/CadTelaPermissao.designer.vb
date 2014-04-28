<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadTelaPermissao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadTelaPermissao))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btEditarSelecionado = New System.Windows.Forms.PictureBox
        Me.btSalvarTodos = New System.Windows.Forms.PictureBox
        Me.ListaPermissao = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ccTela = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cLogin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cSenha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cDescricaoTela = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cExclui = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cAdiciona = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cAltera = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cConsultar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cInativo = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.A1 = New System.Windows.Forms.RadioButton
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet
        Me.A2 = New System.Windows.Forms.RadioButton
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.cTela = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Menu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdicionarPermissãoParaUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.btNovo = New System.Windows.Forms.ToolStripButton
        Me.btSalvar = New System.Windows.Forms.ToolStripButton
        Me.btEditar = New System.Windows.Forms.ToolStripButton
        Me.btExcluir = New System.Windows.Forms.ToolStripButton
        Me.btFechar = New System.Windows.Forms.ToolStripButton
        Me.lblCódigoCliente = New System.Windows.Forms.Label
        Me.Tela = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.DescricaoTela = New TexBoxFocusNet.TextBoxFocusNet
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.btEditarSelecionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btSalvarTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPermissao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu1.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.BarraBt)
        Me.PanelEx1.Controls.Add(Me.lblCódigoCliente)
        Me.PanelEx1.Controls.Add(Me.Tela)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.DescricaoTela)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(894, 500)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.btEditarSelecionado)
        Me.GroupPanel2.Controls.Add(Me.btSalvarTodos)
        Me.GroupPanel2.Controls.Add(Me.ListaPermissao)
        Me.GroupPanel2.Location = New System.Drawing.Point(454, 129)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(429, 362)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 13
        Me.GroupPanel2.Text = "Permissões"
        '
        'btEditarSelecionado
        '
        Me.btEditarSelecionado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEditarSelecionado.Image = CType(resources.GetObject("btEditarSelecionado.Image"), System.Drawing.Image)
        Me.btEditarSelecionado.Location = New System.Drawing.Point(40, 308)
        Me.btEditarSelecionado.Name = "btEditarSelecionado"
        Me.btEditarSelecionado.Size = New System.Drawing.Size(30, 30)
        Me.btEditarSelecionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btEditarSelecionado.TabIndex = 3
        Me.btEditarSelecionado.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btEditarSelecionado, "Edita o Item selecionado da Lista de Permissão")
        '
        'btSalvarTodos
        '
        Me.btSalvarTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvarTodos.Image = CType(resources.GetObject("btSalvarTodos.Image"), System.Drawing.Image)
        Me.btSalvarTodos.Location = New System.Drawing.Point(4, 308)
        Me.btSalvarTodos.Name = "btSalvarTodos"
        Me.btSalvarTodos.Size = New System.Drawing.Size(30, 30)
        Me.btSalvarTodos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btSalvarTodos.TabIndex = 2
        Me.btSalvarTodos.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btSalvarTodos, "Salva todos os Item da Lista de Permissão")
        '
        'ListaPermissao
        '
        Me.ListaPermissao.AllowUserToAddRows = False
        Me.ListaPermissao.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        Me.ListaPermissao.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaPermissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaPermissao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.ccTela, Me.cLogin, Me.cSenha, Me.cDescricaoTela, Me.cExclui, Me.cAdiciona, Me.cAltera, Me.cConsultar, Me.cInativo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaPermissao.DefaultCellStyle = DataGridViewCellStyle2
        Me.ListaPermissao.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaPermissao.Location = New System.Drawing.Point(3, 2)
        Me.ListaPermissao.Name = "ListaPermissao"
        Me.ListaPermissao.RowHeadersWidth = 20
        Me.ListaPermissao.SelectAllSignVisible = False
        Me.ListaPermissao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaPermissao.Size = New System.Drawing.Size(418, 304)
        Me.ListaPermissao.TabIndex = 1
        '
        'cId
        '
        Me.cId.DataPropertyName = "Id"
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        '
        'ccTela
        '
        Me.ccTela.DataPropertyName = "Tela"
        Me.ccTela.HeaderText = "Tela"
        Me.ccTela.Name = "ccTela"
        Me.ccTela.ReadOnly = True
        Me.ccTela.Visible = False
        '
        'cLogin
        '
        Me.cLogin.DataPropertyName = "Login"
        Me.cLogin.HeaderText = "Login"
        Me.cLogin.Name = "cLogin"
        Me.cLogin.ReadOnly = True
        Me.cLogin.Width = 220
        '
        'cSenha
        '
        Me.cSenha.DataPropertyName = "Senha"
        Me.cSenha.HeaderText = "Senha"
        Me.cSenha.Name = "cSenha"
        Me.cSenha.ReadOnly = True
        Me.cSenha.Visible = False
        '
        'cDescricaoTela
        '
        Me.cDescricaoTela.DataPropertyName = "DescricaoTela"
        Me.cDescricaoTela.HeaderText = "Descrição Tela"
        Me.cDescricaoTela.Name = "cDescricaoTela"
        Me.cDescricaoTela.ReadOnly = True
        Me.cDescricaoTela.Visible = False
        '
        'cExclui
        '
        Me.cExclui.DataPropertyName = "Exclui"
        Me.cExclui.HeaderText = "Exc"
        Me.cExclui.Name = "cExclui"
        Me.cExclui.Width = 30
        '
        'cAdiciona
        '
        Me.cAdiciona.DataPropertyName = "Adiciona"
        Me.cAdiciona.HeaderText = "Adi"
        Me.cAdiciona.Name = "cAdiciona"
        Me.cAdiciona.Width = 30
        '
        'cAltera
        '
        Me.cAltera.DataPropertyName = "Altera"
        Me.cAltera.HeaderText = "Alt"
        Me.cAltera.Name = "cAltera"
        Me.cAltera.Width = 30
        '
        'cConsultar
        '
        Me.cConsultar.DataPropertyName = "Consultar"
        Me.cConsultar.HeaderText = "Con"
        Me.cConsultar.Name = "cConsultar"
        Me.cConsultar.Width = 30
        '
        'cInativo
        '
        Me.cInativo.DataPropertyName = "Inativo"
        Me.cInativo.HeaderText = "Ina"
        Me.cInativo.Name = "cInativo"
        Me.cInativo.Width = 30
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.TxtProcura)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.Lista)
        Me.GroupPanel1.Location = New System.Drawing.Point(11, 129)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(437, 362)
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
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 12
        Me.GroupPanel1.Text = "Procura de Telas"
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 287)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(77, 19)
        Me.A1.TabIndex = 1
        Me.A1.TabStop = True
        Me.A1.Text = "Descrição"
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
        Me.TxtProcura.Location = New System.Drawing.Point(3, 312)
        Me.TxtProcura.MaxLength = 30
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.PreencherZeroEsqueda = False
        Me.TxtProcura.RegraValidação = Nothing
        Me.TxtProcura.RegraValidaçãoMensagem = Nothing
        Me.TxtProcura.Size = New System.Drawing.Size(418, 23)
        Me.TxtProcura.TabIndex = 3
        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(86, 287)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(55, 19)
        Me.A2.TabIndex = 2
        Me.A2.TabStop = True
        Me.A2.Text = "Todos"
        Me.A2.UseVisualStyleBackColor = True
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTela, Me.cDesc})
        Me.Lista.ContextMenuStrip = Me.Menu1
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle4
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(3, 2)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(418, 279)
        Me.Lista.TabIndex = 0
        '
        'cTela
        '
        Me.cTela.DataPropertyName = "Tela"
        Me.cTela.HeaderText = "Tela"
        Me.cTela.Name = "cTela"
        Me.cTela.ReadOnly = True
        Me.cTela.Visible = False
        '
        'cDesc
        '
        Me.cDesc.DataPropertyName = "DescricaoTela"
        Me.cDesc.HeaderText = "Descrição"
        Me.cDesc.Name = "cDesc"
        Me.cDesc.ReadOnly = True
        Me.cDesc.Width = 370
        '
        'Menu1
        '
        Me.Menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarPermissãoParaUsuárioToolStripMenuItem, Me.AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem})
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(305, 70)
        '
        'AdicionarPermissãoParaUsuárioToolStripMenuItem
        '
        Me.AdicionarPermissãoParaUsuárioToolStripMenuItem.Name = "AdicionarPermissãoParaUsuárioToolStripMenuItem"
        Me.AdicionarPermissãoParaUsuárioToolStripMenuItem.Size = New System.Drawing.Size(304, 22)
        Me.AdicionarPermissãoParaUsuárioToolStripMenuItem.Text = "Adicionar Permissão para Usuário"
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNovo, Me.btSalvar, Me.btEditar, Me.btExcluir, Me.btFechar})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(894, 58)
        Me.BarraBt.TabIndex = 7
        Me.BarraBt.Text = "ToolStrip1"
        '
        'btNovo
        '
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(40, 55)
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSalvar
        '
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(45, 55)
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btEditar
        '
        Me.btEditar.Image = CType(resources.GetObject("btEditar.Image"), System.Drawing.Image)
        Me.btEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(43, 55)
        Me.btEditar.Text = "Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btExcluir
        '
        Me.btExcluir.Image = CType(resources.GetObject("btExcluir.Image"), System.Drawing.Image)
        Me.btExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(49, 55)
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btFechar
        '
        Me.btFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(46, 55)
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lblCódigoCliente
        '
        Me.lblCódigoCliente.Location = New System.Drawing.Point(8, 72)
        Me.lblCódigoCliente.Name = "lblCódigoCliente"
        Me.lblCódigoCliente.Size = New System.Drawing.Size(115, 23)
        Me.lblCódigoCliente.TabIndex = 8
        Me.lblCódigoCliente.Text = "Nome do Forms"
        '
        'Tela
        '
        Me.Tela.AceitaColarTexto = True
        Me.Tela.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Tela.CasasDecimais = 0
        Me.Tela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tela.CPObrigatorio = False
        Me.Tela.CPObrigatorioMsg = Nothing
        Me.Tela.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Tela.FlatBorder = False
        Me.Tela.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Tela.FocusColor = System.Drawing.Color.MistyRose
        Me.Tela.FocusColorEnd = System.Drawing.Color.Empty
        Me.Tela.HighlightBorderOnEnter = False
        Me.Tela.Location = New System.Drawing.Point(128, 72)
        Me.Tela.MaxLength = 50
        Me.Tela.Name = "Tela"
        Me.Tela.PreencherZeroEsqueda = False
        Me.Tela.RegraValidação = Nothing
        Me.Tela.RegraValidaçãoMensagem = Nothing
        Me.Tela.Size = New System.Drawing.Size(755, 23)
        Me.Tela.TabIndex = 9
        Me.Tela.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Tela.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Descrição do Forms"
        '
        'DescricaoTela
        '
        Me.DescricaoTela.AceitaColarTexto = True
        Me.DescricaoTela.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescricaoTela.CasasDecimais = 0
        Me.DescricaoTela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescricaoTela.CPObrigatorio = False
        Me.DescricaoTela.CPObrigatorioMsg = Nothing
        Me.DescricaoTela.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescricaoTela.FlatBorder = False
        Me.DescricaoTela.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescricaoTela.FocusColor = System.Drawing.Color.MistyRose
        Me.DescricaoTela.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescricaoTela.HighlightBorderOnEnter = False
        Me.DescricaoTela.Location = New System.Drawing.Point(128, 100)
        Me.DescricaoTela.MaxLength = 50
        Me.DescricaoTela.Name = "DescricaoTela"
        Me.DescricaoTela.PreencherZeroEsqueda = False
        Me.DescricaoTela.RegraValidação = Nothing
        Me.DescricaoTela.RegraValidaçãoMensagem = Nothing
        Me.DescricaoTela.Size = New System.Drawing.Size(755, 23)
        Me.DescricaoTela.TabIndex = 11
        Me.DescricaoTela.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescricaoTela.ValorPadrao = Nothing
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipTitle = "Ajuda"
        '
        'AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem
        '
        Me.AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem.Name = "AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem"
        Me.AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem.Size = New System.Drawing.Size(304, 22)
        Me.AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem.Text = "Adicionar Permissão para todos os Usuários"
        '
        'CadTelaPermissao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CadTelaPermissao"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadTelaPermissao1"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.btEditarSelecionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btSalvarTodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPermissao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu1.ResumeLayout(False)
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btEditarSelecionado As System.Windows.Forms.PictureBox
    Friend WithEvents btSalvarTodos As System.Windows.Forms.PictureBox
    Friend WithEvents ListaPermissao As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ccTela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cLogin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSenha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescricaoTela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cExclui As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cAdiciona As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cAltera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cConsultar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cInativo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cTela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents btNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCódigoCliente As System.Windows.Forms.Label
    Friend WithEvents Tela As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DescricaoTela As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Menu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AdicionarPermissãoParaUsuárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
