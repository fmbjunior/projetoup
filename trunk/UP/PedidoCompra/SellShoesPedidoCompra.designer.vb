<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesPedidoCompra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellShoesPedidoCompra))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btnEncerrar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.ConfImg = New System.Windows.Forms.Label()
        Me.butIniciarFechamento = New DevComponents.DotNetBar.ButtonX()
        Me.TabGeral = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ListaPagar = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gVencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcluirParcelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Itens = New DevComponents.DotNetBar.TabControlPanel()
        Me.AdicionarItens = New DevComponents.DotNetBar.ButtonX()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.IDp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gCodigoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuListaDeItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirOItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportarItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdEntregue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gResta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeqP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VlrUnitP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFOPp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalItensLançado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Confirmado = New System.Windows.Forms.CheckBox()
        Me.Inativo = New System.Windows.Forms.CheckBox()
        Me.TabItens = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtRazaoSocial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Obs = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtCodigoFornecedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodigoFuncionario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.FuncionarioDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtDataPrevista = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtDataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodigoPedidoCompra = New TexBoxFocusNet.TextBoxFocusNet()
        Me.butFechar = New DevComponents.DotNetBar.ButtonX()
        Me.butImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.butLocalizar = New DevComponents.DotNetBar.ButtonX()
        Me.butCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.butSalvarEditar = New DevComponents.DotNetBar.ButtonX()
        Me.butNovo = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.DevolucaoTab = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.BalloonTip1 = New DevComponents.DotNetBar.BalloonTip()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.TabGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeral.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.ListaPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Itens.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuListaDeItem.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btnEncerrar)
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.ConfImg)
        Me.PanelEx1.Controls.Add(Me.butIniciarFechamento)
        Me.PanelEx1.Controls.Add(Me.TabGeral)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.txtDataPrevista)
        Me.PanelEx1.Controls.Add(Me.txtDataLancamento)
        Me.PanelEx1.Controls.Add(Me.CodigoPedidoCompra)
        Me.PanelEx1.Controls.Add(Me.butFechar)
        Me.PanelEx1.Controls.Add(Me.butImprimir)
        Me.PanelEx1.Controls.Add(Me.butLocalizar)
        Me.PanelEx1.Controls.Add(Me.butCancelar)
        Me.PanelEx1.Controls.Add(Me.butSalvarEditar)
        Me.PanelEx1.Controls.Add(Me.butNovo)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(885, 525)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btnEncerrar
        '
        Me.btnEncerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEncerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEncerrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncerrar.Location = New System.Drawing.Point(779, 480)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(102, 40)
        Me.btnEncerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEncerrar.TabIndex = 17
        Me.btnEncerrar.Text = "Encerrar Acompanhamento"
        Me.btnEncerrar.Tooltip = "<b><i><font color=""#2E415A"">Este botão muda o status do pedido para ""Finalizado""." & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Qualquer dúvida contate o suporte.</font></i></b>"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.Label4)
        Me.PanelEx3.Controls.Add(Me.lblStatus)
        Me.PanelEx3.Location = New System.Drawing.Point(532, 94)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(353, 54)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 33)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Status"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Green
        Me.lblStatus.Location = New System.Drawing.Point(111, 10)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(202, 33)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "EM ANDAMENTO"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConfImg
        '
        Me.ConfImg.BackColor = System.Drawing.Color.Transparent
        Me.ConfImg.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfImg.ForeColor = System.Drawing.Color.Black
        Me.ConfImg.Image = CType(resources.GetObject("ConfImg.Image"), System.Drawing.Image)
        Me.ConfImg.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ConfImg.Location = New System.Drawing.Point(9, 430)
        Me.ConfImg.Name = "ConfImg"
        Me.ConfImg.Size = New System.Drawing.Size(253, 47)
        Me.ConfImg.TabIndex = 9
        Me.ConfImg.Text = "Lançamento Confirmado"
        Me.ConfImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ConfImg.Visible = False
        '
        'butIniciarFechamento
        '
        Me.butIniciarFechamento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butIniciarFechamento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butIniciarFechamento.Enabled = False
        Me.butIniciarFechamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butIniciarFechamento.Location = New System.Drawing.Point(686, 480)
        Me.butIniciarFechamento.Name = "butIniciarFechamento"
        Me.butIniciarFechamento.Size = New System.Drawing.Size(88, 41)
        Me.butIniciarFechamento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butIniciarFechamento.TabIndex = 16
        Me.butIniciarFechamento.Text = "C&onfirmar"
        '
        'TabGeral
        '
        Me.TabGeral.BackColor = System.Drawing.Color.Transparent
        Me.TabGeral.CanReorderTabs = True
        Me.TabGeral.Controls.Add(Me.Itens)
        Me.TabGeral.Controls.Add(Me.TabControlPanel1)
        Me.TabGeral.Location = New System.Drawing.Point(1, 154)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedTabFont = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabGeral.SelectedTabIndex = 2
        Me.TabGeral.Size = New System.Drawing.Size(884, 269)
        Me.TabGeral.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabGeral.TabIndex = 8
        Me.TabGeral.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox
        Me.TabGeral.Tabs.Add(Me.TabItens)
        Me.TabGeral.Tabs.Add(Me.TabItem1)
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.ListaPagar)
        Me.TabControlPanel1.Controls.Add(Me.LabelX2)
        Me.TabControlPanel1.Controls.Add(Me.LabelX1)
        Me.TabControlPanel1.Controls.Add(Me.dgv2)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(884, 247)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 0
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'ListaPagar
        '
        Me.ListaPagar.AllowUserToAddRows = False
        Me.ListaPagar.AllowUserToDeleteRows = False
        Me.ListaPagar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ListaPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ListaPagar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.gDocumento, Me.gVencimento, Me.gValor, Me.gLocal})
        Me.ListaPagar.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListaPagar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ListaPagar.Location = New System.Drawing.Point(393, 36)
        Me.ListaPagar.MultiSelect = False
        Me.ListaPagar.Name = "ListaPagar"
        Me.ListaPagar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ListaPagar.RowHeadersWidth = 21
        Me.ListaPagar.RowTemplate.Height = 24
        Me.ListaPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ListaPagar.ShowEditingIcon = False
        Me.ListaPagar.Size = New System.Drawing.Size(437, 207)
        Me.ListaPagar.TabIndex = 3
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'gDocumento
        '
        Me.gDocumento.DataPropertyName = "documento"
        Me.gDocumento.HeaderText = "Documento"
        Me.gDocumento.Name = "gDocumento"
        '
        'gVencimento
        '
        Me.gVencimento.DataPropertyName = "vencimento"
        Me.gVencimento.HeaderText = "Vencimento"
        Me.gVencimento.Name = "gVencimento"
        '
        'gValor
        '
        Me.gValor.DataPropertyName = "valordocumento"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "c2"
        Me.gValor.DefaultCellStyle = DataGridViewCellStyle7
        Me.gValor.HeaderText = "Valor"
        Me.gValor.Name = "gValor"
        '
        'gLocal
        '
        Me.gLocal.DataPropertyName = "localpgto"
        Me.gLocal.HeaderText = "Local Pgto"
        Me.gLocal.Name = "gLocal"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripSeparator1, Me.ExcluirParcelaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "MenuListaDeItem"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(209, 54)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem4.Text = "Excluir  Parcela Virtual"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'ExcluirParcelaToolStripMenuItem
        '
        Me.ExcluirParcelaToolStripMenuItem.Name = "ExcluirParcelaToolStripMenuItem"
        Me.ExcluirParcelaToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ExcluirParcelaToolStripMenuItem.Text = "Excluir Parcela"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(393, 9)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(108, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Parcelamentos"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(9, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(108, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Notas Lançadas"
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.AllowUserToResizeColumns = False
        Me.dgv2.AllowUserToResizeRows = False
        Me.dgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv2.Location = New System.Drawing.Point(4, 36)
        Me.dgv2.MultiSelect = False
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv2.RowHeadersVisible = False
        Me.dgv2.RowTemplate.Height = 24
        Me.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv2.ShowEditingIcon = False
        Me.dgv2.Size = New System.Drawing.Size(334, 207)
        Me.dgv2.TabIndex = 2
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Outras Informações"
        '
        'Itens
        '
        Me.Itens.Controls.Add(Me.AdicionarItens)
        Me.Itens.Controls.Add(Me.dgv)
        Me.Itens.Controls.Add(Me.TotalItensLançado)
        Me.Itens.Controls.Add(Me.Label40)
        Me.Itens.Controls.Add(Me.Confirmado)
        Me.Itens.Controls.Add(Me.Inativo)
        Me.Itens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Itens.Location = New System.Drawing.Point(0, 22)
        Me.Itens.Name = "Itens"
        Me.Itens.Padding = New System.Windows.Forms.Padding(1)
        Me.Itens.Size = New System.Drawing.Size(884, 247)
        Me.Itens.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Itens.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Itens.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Itens.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Itens.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.Itens.Style.GradientAngle = 90
        Me.Itens.TabIndex = 1
        Me.Itens.TabItem = Me.TabItens
        '
        'AdicionarItens
        '
        Me.AdicionarItens.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AdicionarItens.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AdicionarItens.Location = New System.Drawing.Point(786, 216)
        Me.AdicionarItens.Name = "AdicionarItens"
        Me.AdicionarItens.Size = New System.Drawing.Size(94, 25)
        Me.AdicionarItens.TabIndex = 5
        Me.AdicionarItens.Text = "Add Item [F7]"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDp, Me.gCodigoCompra, Me.CodigoP, Me.TamP, Me.DescricaoP, Me.QtdP, Me.QtdEntregue, Me.gResta, Me.SeqP, Me.VlrUnitP, Me.TotalP, Me.CFOPp})
        Me.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv.Location = New System.Drawing.Point(8, 4)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(873, 206)
        Me.dgv.TabIndex = 0
        '
        'IDp
        '
        Me.IDp.DataPropertyName = "id"
        Me.IDp.HeaderText = "ID"
        Me.IDp.Name = "IDp"
        Me.IDp.ReadOnly = True
        Me.IDp.Visible = False
        '
        'gCodigoCompra
        '
        Me.gCodigoCompra.DataPropertyName = "CompraInterno"
        Me.gCodigoCompra.HeaderText = "CodigoCmpra"
        Me.gCodigoCompra.Name = "gCodigoCompra"
        Me.gCodigoCompra.ReadOnly = True
        Me.gCodigoCompra.Visible = False
        '
        'CodigoP
        '
        Me.CodigoP.ContextMenuStrip = Me.MenuListaDeItem
        Me.CodigoP.DataPropertyName = "CodigoProduto"
        Me.CodigoP.HeaderText = "Codigo"
        Me.CodigoP.Name = "CodigoP"
        Me.CodigoP.ReadOnly = True
        Me.CodigoP.Width = 70
        '
        'MenuListaDeItem
        '
        Me.MenuListaDeItem.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MenuListaDeItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ExcluirOItemToolStripMenuItem, Me.ToolStripMenuItem2, Me.ImportarItemToolStripMenuItem})
        Me.MenuListaDeItem.Name = "MenuListaDeItem"
        Me.MenuListaDeItem.Size = New System.Drawing.Size(158, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ToolStripMenuItem1.Text = "Editar Item"
        '
        'ExcluirOItemToolStripMenuItem
        '
        Me.ExcluirOItemToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExcluirOItemToolStripMenuItem.Image = CType(resources.GetObject("ExcluirOItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirOItemToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExcluirOItemToolStripMenuItem.Name = "ExcluirOItemToolStripMenuItem"
        Me.ExcluirOItemToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ExcluirOItemToolStripMenuItem.Text = "Excluir o Item"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(154, 6)
        '
        'ImportarItemToolStripMenuItem
        '
        Me.ImportarItemToolStripMenuItem.Name = "ImportarItemToolStripMenuItem"
        Me.ImportarItemToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ImportarItemToolStripMenuItem.Text = "Importar Item"
        '
        'TamP
        '
        Me.TamP.ContextMenuStrip = Me.MenuListaDeItem
        Me.TamP.DataPropertyName = "Tamanho"
        Me.TamP.HeaderText = "Tam"
        Me.TamP.Name = "TamP"
        Me.TamP.ReadOnly = True
        Me.TamP.Width = 50
        '
        'DescricaoP
        '
        Me.DescricaoP.ContextMenuStrip = Me.MenuListaDeItem
        Me.DescricaoP.DataPropertyName = "Descrição"
        Me.DescricaoP.HeaderText = "Descricao"
        Me.DescricaoP.Name = "DescricaoP"
        Me.DescricaoP.ReadOnly = True
        Me.DescricaoP.Width = 290
        '
        'QtdP
        '
        Me.QtdP.DataPropertyName = "qtd"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        Me.QtdP.DefaultCellStyle = DataGridViewCellStyle2
        Me.QtdP.HeaderText = "Qtd Ped."
        Me.QtdP.Name = "QtdP"
        Me.QtdP.ReadOnly = True
        Me.QtdP.Width = 70
        '
        'QtdEntregue
        '
        Me.QtdEntregue.DataPropertyName = "QtdEntregue"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n2"
        Me.QtdEntregue.DefaultCellStyle = DataGridViewCellStyle3
        Me.QtdEntregue.HeaderText = "Entregue"
        Me.QtdEntregue.Name = "QtdEntregue"
        Me.QtdEntregue.ReadOnly = True
        Me.QtdEntregue.Width = 70
        '
        'gResta
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0,00"
        Me.gResta.DefaultCellStyle = DataGridViewCellStyle4
        Me.gResta.HeaderText = "Resta"
        Me.gResta.Name = "gResta"
        Me.gResta.ReadOnly = True
        Me.gResta.Width = 80
        '
        'SeqP
        '
        Me.SeqP.DataPropertyName = "seqnf"
        Me.SeqP.HeaderText = "Seq"
        Me.SeqP.Name = "SeqP"
        Me.SeqP.ReadOnly = True
        Me.SeqP.Width = 30
        '
        'VlrUnitP
        '
        Me.VlrUnitP.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "c2"
        Me.VlrUnitP.DefaultCellStyle = DataGridViewCellStyle5
        Me.VlrUnitP.HeaderText = "Vlr Unit"
        Me.VlrUnitP.Name = "VlrUnitP"
        Me.VlrUnitP.ReadOnly = True
        Me.VlrUnitP.Width = 80
        '
        'TotalP
        '
        Me.TotalP.DataPropertyName = "TotalProduto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "c2"
        Me.TotalP.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalP.HeaderText = "Total"
        Me.TotalP.Name = "TotalP"
        Me.TotalP.ReadOnly = True
        '
        'CFOPp
        '
        Me.CFOPp.DataPropertyName = "cfop"
        Me.CFOPp.HeaderText = "CFOP"
        Me.CFOPp.Name = "CFOPp"
        Me.CFOPp.ReadOnly = True
        Me.CFOPp.Width = 50
        '
        'TotalItensLançado
        '
        Me.TotalItensLançado.AceitaColarTexto = True
        Me.TotalItensLançado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalItensLançado.CasasDecimais = 2
        Me.TotalItensLançado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalItensLançado.CPObrigatorio = False
        Me.TotalItensLançado.CPObrigatorioMsg = Nothing
        Me.TotalItensLançado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalItensLançado.FlatBorder = False
        Me.TotalItensLançado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalItensLançado.FocusColor = System.Drawing.Color.Empty
        Me.TotalItensLançado.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalItensLançado.HighlightBorderOnEnter = False
        Me.TotalItensLançado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalItensLançado.Location = New System.Drawing.Point(71, 216)
        Me.TotalItensLançado.MaxLength = 15
        Me.TotalItensLançado.Name = "TotalItensLançado"
        Me.TotalItensLançado.PreencherZeroEsqueda = False
        Me.TotalItensLançado.RegraValidação = Nothing
        Me.TotalItensLançado.RegraValidaçãoMensagem = Nothing
        Me.TotalItensLançado.Size = New System.Drawing.Size(115, 20)
        Me.TotalItensLançado.TabIndex = 2
        Me.TotalItensLançado.TabStop = False
        Me.TotalItensLançado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalItensLançado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.TotalItensLançado.ValorPadrao = Nothing
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(9, 216)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 20)
        Me.Label40.TabIndex = 1
        Me.Label40.Text = "Lançado"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Confirmado
        '
        Me.Confirmado.AutoSize = True
        Me.Confirmado.BackColor = System.Drawing.Color.Transparent
        Me.Confirmado.Enabled = False
        Me.Confirmado.Location = New System.Drawing.Point(226, 218)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(79, 17)
        Me.Confirmado.TabIndex = 3
        Me.Confirmado.TabStop = False
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.UseVisualStyleBackColor = False
        Me.Confirmado.Visible = False
        '
        'Inativo
        '
        Me.Inativo.AutoSize = True
        Me.Inativo.BackColor = System.Drawing.Color.Transparent
        Me.Inativo.Enabled = False
        Me.Inativo.Location = New System.Drawing.Point(311, 218)
        Me.Inativo.Name = "Inativo"
        Me.Inativo.Size = New System.Drawing.Size(58, 17)
        Me.Inativo.TabIndex = 4
        Me.Inativo.Text = "Inativo"
        Me.Inativo.UseVisualStyleBackColor = False
        Me.Inativo.Visible = False
        '
        'TabItens
        '
        Me.TabItens.AttachedControl = Me.Itens
        Me.TabItens.Name = "TabItens"
        Me.TabItens.Text = "Itens [F7]"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx2.Controls.Add(Me.txtRazaoSocial)
        Me.PanelEx2.Controls.Add(Me.Obs)
        Me.PanelEx2.Controls.Add(Me.txtCodigoFornecedor)
        Me.PanelEx2.Controls.Add(Me.CodigoFuncionario)
        Me.PanelEx2.Controls.Add(Me.FuncionarioDesc)
        Me.PanelEx2.Controls.Add(Me.Label9)
        Me.PanelEx2.Controls.Add(Me.Label8)
        Me.PanelEx2.Controls.Add(Me.Label29)
        Me.PanelEx2.Location = New System.Drawing.Point(12, 12)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(514, 139)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.AceitaColarTexto = True
        Me.txtRazaoSocial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.txtRazaoSocial.CasasDecimais = 0
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazaoSocial.CPObrigatorio = False
        Me.txtRazaoSocial.CPObrigatorioMsg = Nothing
        Me.txtRazaoSocial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtRazaoSocial.FlatBorder = False
        Me.txtRazaoSocial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtRazaoSocial.FocusColor = System.Drawing.Color.Empty
        Me.txtRazaoSocial.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazaoSocial.HighlightBorderOnEnter = False
        Me.txtRazaoSocial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtRazaoSocial.Location = New System.Drawing.Point(169, 14)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.PreencherZeroEsqueda = False
        Me.txtRazaoSocial.RegraValidação = Nothing
        Me.txtRazaoSocial.RegraValidaçãoMensagem = Nothing
        Me.txtRazaoSocial.Size = New System.Drawing.Size(341, 23)
        Me.txtRazaoSocial.TabIndex = 2
        Me.txtRazaoSocial.TabStop = False
        Me.txtRazaoSocial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtRazaoSocial.ValorPadrao = Nothing
        '
        'Obs
        '
        Me.Obs.AceitaColarTexto = True
        Me.Obs.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Obs.CasasDecimais = 0
        Me.Obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Obs.CPObrigatorio = False
        Me.Obs.CPObrigatorioMsg = Nothing
        Me.Obs.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Obs.FlatBorder = False
        Me.Obs.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Obs.FocusColor = System.Drawing.Color.Empty
        Me.Obs.FocusColorEnd = System.Drawing.Color.Empty
        Me.Obs.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Obs.HighlightBorderOnEnter = False
        Me.Obs.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Obs.Location = New System.Drawing.Point(103, 43)
        Me.Obs.Multiline = True
        Me.Obs.Name = "Obs"
        Me.Obs.PreencherZeroEsqueda = False
        Me.Obs.RegraValidação = Nothing
        Me.Obs.RegraValidaçãoMensagem = Nothing
        Me.Obs.Size = New System.Drawing.Size(407, 51)
        Me.Obs.TabIndex = 4
        Me.Obs.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Obs.ValorPadrao = Nothing
        '
        'txtCodigoFornecedor
        '
        Me.txtCodigoFornecedor.AceitaColarTexto = True
        Me.BalloonTip1.SetBalloonCaption(Me.txtCodigoFornecedor, "Dicas!")
        Me.BalloonTip1.SetBalloonText(Me.txtCodigoFornecedor, "Pressione F5 para Buscar um Fornecedor")
        Me.txtCodigoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtCodigoFornecedor.CasasDecimais = 0
        Me.txtCodigoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoFornecedor.CPObrigatorio = False
        Me.txtCodigoFornecedor.CPObrigatorioMsg = Nothing
        Me.txtCodigoFornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtCodigoFornecedor.FlatBorder = False
        Me.txtCodigoFornecedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtCodigoFornecedor.FocusColor = System.Drawing.Color.Empty
        Me.txtCodigoFornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtCodigoFornecedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoFornecedor.HighlightBorderOnEnter = False
        Me.txtCodigoFornecedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtCodigoFornecedor.Location = New System.Drawing.Point(103, 14)
        Me.txtCodigoFornecedor.MaxLength = 8
        Me.txtCodigoFornecedor.Name = "txtCodigoFornecedor"
        Me.txtCodigoFornecedor.PreencherZeroEsqueda = False
        Me.txtCodigoFornecedor.RegraValidação = Nothing
        Me.txtCodigoFornecedor.RegraValidaçãoMensagem = Nothing
        Me.txtCodigoFornecedor.Size = New System.Drawing.Size(60, 23)
        Me.txtCodigoFornecedor.TabIndex = 1
        Me.txtCodigoFornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtCodigoFornecedor.ValorPadrao = Nothing
        '
        'CodigoFuncionario
        '
        Me.CodigoFuncionario.AceitaColarTexto = True
        Me.BalloonTip1.SetBalloonCaption(Me.CodigoFuncionario, "Dicas!")
        Me.BalloonTip1.SetBalloonText(Me.CodigoFuncionario, "Pressione F5 para buscar um Funcionário.")
        Me.CodigoFuncionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoFuncionario.CasasDecimais = 0
        Me.CodigoFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoFuncionario.CPObrigatorio = False
        Me.CodigoFuncionario.CPObrigatorioMsg = Nothing
        Me.CodigoFuncionario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoFuncionario.FlatBorder = False
        Me.CodigoFuncionario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoFuncionario.FocusColor = System.Drawing.Color.Empty
        Me.CodigoFuncionario.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoFuncionario.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoFuncionario.HighlightBorderOnEnter = False
        Me.CodigoFuncionario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoFuncionario.Location = New System.Drawing.Point(103, 100)
        Me.CodigoFuncionario.MaxLength = 15
        Me.CodigoFuncionario.Name = "CodigoFuncionario"
        Me.CodigoFuncionario.PreencherZeroEsqueda = False
        Me.CodigoFuncionario.RegraValidação = Nothing
        Me.CodigoFuncionario.RegraValidaçãoMensagem = Nothing
        Me.CodigoFuncionario.Size = New System.Drawing.Size(60, 23)
        Me.CodigoFuncionario.TabIndex = 5
        Me.CodigoFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CodigoFuncionario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.CodigoFuncionario.ValorPadrao = Nothing
        '
        'FuncionarioDesc
        '
        Me.FuncionarioDesc.AceitaColarTexto = True
        Me.FuncionarioDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.FuncionarioDesc.CasasDecimais = 0
        Me.FuncionarioDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FuncionarioDesc.CPObrigatorio = False
        Me.FuncionarioDesc.CPObrigatorioMsg = Nothing
        Me.FuncionarioDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FuncionarioDesc.FlatBorder = False
        Me.FuncionarioDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FuncionarioDesc.FocusColor = System.Drawing.Color.Empty
        Me.FuncionarioDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FuncionarioDesc.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncionarioDesc.HighlightBorderOnEnter = False
        Me.FuncionarioDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FuncionarioDesc.Location = New System.Drawing.Point(169, 100)
        Me.FuncionarioDesc.Name = "FuncionarioDesc"
        Me.FuncionarioDesc.PreencherZeroEsqueda = False
        Me.FuncionarioDesc.RegraValidação = Nothing
        Me.FuncionarioDesc.RegraValidaçãoMensagem = Nothing
        Me.FuncionarioDesc.Size = New System.Drawing.Size(341, 23)
        Me.FuncionarioDesc.TabIndex = 6
        Me.FuncionarioDesc.TabStop = False
        Me.FuncionarioDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncionarioDesc.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Observação"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Fornecedor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(13, 101)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 23)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Funcionário"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataPrevista
        '
        Me.txtDataPrevista.AceitaColarTexto = True
        Me.txtDataPrevista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtDataPrevista.CasasDecimais = 2
        Me.txtDataPrevista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataPrevista.CPObrigatorio = False
        Me.txtDataPrevista.CPObrigatorioMsg = Nothing
        Me.txtDataPrevista.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtDataPrevista.FlatBorder = False
        Me.txtDataPrevista.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtDataPrevista.FocusColor = System.Drawing.Color.Empty
        Me.txtDataPrevista.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtDataPrevista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataPrevista.HighlightBorderOnEnter = False
        Me.txtDataPrevista.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtDataPrevista.Location = New System.Drawing.Point(779, 65)
        Me.txtDataPrevista.MaxLength = 10
        Me.txtDataPrevista.Name = "txtDataPrevista"
        Me.txtDataPrevista.PreencherZeroEsqueda = False
        Me.txtDataPrevista.RegraValidação = Nothing
        Me.txtDataPrevista.RegraValidaçãoMensagem = Nothing
        Me.txtDataPrevista.Size = New System.Drawing.Size(94, 23)
        Me.txtDataPrevista.TabIndex = 6
        Me.txtDataPrevista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataPrevista.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtDataPrevista.ValorPadrao = Nothing
        '
        'txtDataLancamento
        '
        Me.txtDataLancamento.AceitaColarTexto = True
        Me.txtDataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtDataLancamento.CasasDecimais = 2
        Me.txtDataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataLancamento.CPObrigatorio = False
        Me.txtDataLancamento.CPObrigatorioMsg = Nothing
        Me.txtDataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtDataLancamento.FlatBorder = False
        Me.txtDataLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtDataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.txtDataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtDataLancamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataLancamento.HighlightBorderOnEnter = False
        Me.txtDataLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtDataLancamento.Location = New System.Drawing.Point(779, 37)
        Me.txtDataLancamento.MaxLength = 10
        Me.txtDataLancamento.Name = "txtDataLancamento"
        Me.txtDataLancamento.PreencherZeroEsqueda = False
        Me.txtDataLancamento.RegraValidação = Nothing
        Me.txtDataLancamento.RegraValidaçãoMensagem = Nothing
        Me.txtDataLancamento.Size = New System.Drawing.Size(94, 23)
        Me.txtDataLancamento.TabIndex = 4
        Me.txtDataLancamento.TabStop = False
        Me.txtDataLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtDataLancamento.ValorPadrao = Nothing
        '
        'CodigoPedidoCompra
        '
        Me.CodigoPedidoCompra.AceitaColarTexto = True
        Me.CodigoPedidoCompra.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CodigoPedidoCompra.CasasDecimais = 2
        Me.CodigoPedidoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoPedidoCompra.CPObrigatorio = False
        Me.CodigoPedidoCompra.CPObrigatorioMsg = Nothing
        Me.CodigoPedidoCompra.Enabled = False
        Me.CodigoPedidoCompra.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoPedidoCompra.FlatBorder = False
        Me.CodigoPedidoCompra.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoPedidoCompra.FocusColor = System.Drawing.Color.Empty
        Me.CodigoPedidoCompra.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoPedidoCompra.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoPedidoCompra.HighlightBorderOnEnter = False
        Me.CodigoPedidoCompra.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoPedidoCompra.Location = New System.Drawing.Point(779, 12)
        Me.CodigoPedidoCompra.MaxLength = 10
        Me.CodigoPedidoCompra.Name = "CodigoPedidoCompra"
        Me.CodigoPedidoCompra.PreencherZeroEsqueda = False
        Me.CodigoPedidoCompra.RegraValidação = Nothing
        Me.CodigoPedidoCompra.RegraValidaçãoMensagem = Nothing
        Me.CodigoPedidoCompra.Size = New System.Drawing.Size(94, 23)
        Me.CodigoPedidoCompra.TabIndex = 2
        Me.CodigoPedidoCompra.TabStop = False
        Me.CodigoPedidoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoPedidoCompra.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoPedidoCompra.ValorPadrao = Nothing
        '
        'butFechar
        '
        Me.butFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butFechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butFechar.Location = New System.Drawing.Point(605, 480)
        Me.butFechar.Name = "butFechar"
        Me.butFechar.Size = New System.Drawing.Size(75, 41)
        Me.butFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butFechar.TabIndex = 15
        Me.butFechar.Text = "&Fechar"
        '
        'butImprimir
        '
        Me.butImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butImprimir.Enabled = False
        Me.butImprimir.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butImprimir.Location = New System.Drawing.Point(524, 480)
        Me.butImprimir.Name = "butImprimir"
        Me.butImprimir.Size = New System.Drawing.Size(75, 41)
        Me.butImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butImprimir.TabIndex = 14
        Me.butImprimir.Text = "Im&primir"
        '
        'butLocalizar
        '
        Me.butLocalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butLocalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butLocalizar.Enabled = False
        Me.butLocalizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butLocalizar.Location = New System.Drawing.Point(444, 480)
        Me.butLocalizar.Name = "butLocalizar"
        Me.butLocalizar.Size = New System.Drawing.Size(75, 41)
        Me.butLocalizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butLocalizar.TabIndex = 13
        Me.butLocalizar.Text = "&Localizar"
        '
        'butCancelar
        '
        Me.butCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butCancelar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCancelar.Location = New System.Drawing.Point(363, 480)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(75, 41)
        Me.butCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butCancelar.TabIndex = 12
        Me.butCancelar.Text = "&Cancelar"
        '
        'butSalvarEditar
        '
        Me.butSalvarEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butSalvarEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butSalvarEditar.Enabled = False
        Me.butSalvarEditar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSalvarEditar.Location = New System.Drawing.Point(282, 480)
        Me.butSalvarEditar.Name = "butSalvarEditar"
        Me.butSalvarEditar.Size = New System.Drawing.Size(75, 41)
        Me.butSalvarEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butSalvarEditar.TabIndex = 11
        Me.butSalvarEditar.Text = "&Salvar"
        '
        'butNovo
        '
        Me.butNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butNovo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butNovo.Location = New System.Drawing.Point(201, 480)
        Me.butNovo.Name = "butNovo"
        Me.butNovo.Size = New System.Drawing.Size(75, 41)
        Me.butNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butNovo.TabIndex = 10
        Me.butNovo.Text = "&Novo"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(662, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Data prevista Chegada"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(662, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data Lançamento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(662, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Pedido Compra Nº"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabItem2
        '
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Parcelamento do Documento"
        '
        'DevolucaoTab
        '
        Me.DevolucaoTab.Name = "DevolucaoTab"
        Me.DevolucaoTab.Text = "NF/Doc Devolvidos"
        Me.DevolucaoTab.Visible = False
        '
        'BalloonTip1
        '
        Me.BalloonTip1.ShowAlways = True
        Me.BalloonTip1.ShowBalloonOnFocus = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'SellShoesPedidoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Name = "SellShoesPedidoCompra"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido de Compra"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.TabGeral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeral.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.ListaPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Itens.ResumeLayout(False)
        Me.Itens.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuListaDeItem.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents butNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents butFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents butLocalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents butCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents butSalvarEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents CodigoPedidoCompra As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtRazaoSocial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Obs As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Confirmado As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigoFornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoFuncionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Inativo As System.Windows.Forms.CheckBox
    Friend WithEvents FuncionarioDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtDataPrevista As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtDataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabGeral As DevComponents.DotNetBar.TabControl
    Friend WithEvents Itens As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents TotalItensLançado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TabItens As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents DevolucaoTab As DevComponents.DotNetBar.TabItem
    Friend WithEvents AdicionarItens As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BalloonTip1 As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents MenuListaDeItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirOItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents butImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents butIniciarFechamento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ConfImg As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImportarItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents IDp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gCodigoCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TamP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescricaoP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtdP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtdEntregue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gResta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeqP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VlrUnitP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFOPp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ListaPagar As System.Windows.Forms.DataGridView
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEncerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExcluirParcelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gVencimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gLocal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
