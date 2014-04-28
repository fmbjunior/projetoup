<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoCompraConfirmar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoCompraConfirmar))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.txtDataLancamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.butConfirmar = New DevComponents.DotNetBar.ButtonX
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.tValorPedidoCompra = New TexBoxFocusNet.TextBoxFocusNet
        Me.txtResto = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.ListaPagar = New System.Windows.Forms.DataGridView
        Me.MenuLista = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirTodasAsParcelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnGerarParcelas = New DevComponents.DotNetBar.ButtonX
        Me.parcelas = New TexBoxFocusNet.TextBoxFocusNet
        Me.DataPrimeiroVencimento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LocalPgto = New CBOAutoCompleteFocus.CboFocus
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Destino = New TexBoxFocusNet.TextBoxFocusNet
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.ContaLancamentoDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.btFindValor = New System.Windows.Forms.Label
        Me.ContaLancamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Find6 = New System.Windows.Forms.Label
        Me.DescConta6 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Find5 = New System.Windows.Forms.Label
        Me.DescConta5 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Find4 = New System.Windows.Forms.Label
        Me.DescConta4 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Find3 = New System.Windows.Forms.Label
        Me.DescConta3 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Find2 = New System.Windows.Forms.Label
        Me.DescConta2 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Find1 = New System.Windows.Forms.Label
        Me.Conta6 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Vlr6 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Conta5 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Vlr5 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Conta4 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Vlr4 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Conta3 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Vlr3 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Conta2 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Vlr2 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Conta1 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.DescConta1 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label19 = New System.Windows.Forms.Label
        Me.Vlr1 = New TexBoxFocusNet.TextBoxFocusNet
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.ListaPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuLista.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtDataLancamento)
        Me.PanelEx1.Controls.Add(Me.butConfirmar)
        Me.PanelEx1.Controls.Add(Me.btnFechar)
        Me.PanelEx1.Controls.Add(Me.GroupPanel3)
        Me.PanelEx1.Controls.Add(Me.txtResto)
        Me.PanelEx1.Controls.Add(Me.txtTotal)
        Me.PanelEx1.Controls.Add(Me.ListaPagar)
        Me.PanelEx1.Controls.Add(Me.btnGerarParcelas)
        Me.PanelEx1.Controls.Add(Me.parcelas)
        Me.PanelEx1.Controls.Add(Me.DataPrimeiroVencimento)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.LocalPgto)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Destino)
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(650, 376)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
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
        Me.txtDataLancamento.Location = New System.Drawing.Point(256, 400)
        Me.txtDataLancamento.MaxLength = 10
        Me.txtDataLancamento.Name = "txtDataLancamento"
        Me.txtDataLancamento.PreencherZeroEsqueda = False
        Me.txtDataLancamento.RegraValidação = Nothing
        Me.txtDataLancamento.RegraValidaçãoMensagem = Nothing
        Me.txtDataLancamento.Size = New System.Drawing.Size(94, 23)
        Me.txtDataLancamento.TabIndex = 17
        Me.txtDataLancamento.TabStop = False
        Me.txtDataLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtDataLancamento.ValorPadrao = Nothing
        Me.txtDataLancamento.Visible = False
        '
        'butConfirmar
        '
        Me.butConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butConfirmar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butConfirmar.Location = New System.Drawing.Point(398, 342)
        Me.butConfirmar.Name = "butConfirmar"
        Me.butConfirmar.Size = New System.Drawing.Size(126, 30)
        Me.butConfirmar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butConfirmar.TabIndex = 13
        Me.butConfirmar.Text = "Confimar"
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(287, 342)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(105, 30)
        Me.btnFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFechar.TabIndex = 14
        Me.btnFechar.Text = "Fechar"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Controls.Add(Me.tValorPedidoCompra)
        Me.GroupPanel3.Location = New System.Drawing.Point(298, 4)
        Me.GroupPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(350, 37)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.Class = ""
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.Class = ""
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.Class = ""
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 0
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(6, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(85, 26)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Valor Total.:"
        '
        'tValorPedidoCompra
        '
        Me.tValorPedidoCompra.AceitaColarTexto = True
        Me.tValorPedidoCompra.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.tValorPedidoCompra.CasasDecimais = 2
        Me.tValorPedidoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tValorPedidoCompra.CPObrigatorio = False
        Me.tValorPedidoCompra.CPObrigatorioMsg = Nothing
        Me.tValorPedidoCompra.Enabled = False
        Me.tValorPedidoCompra.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.tValorPedidoCompra.FlatBorder = False
        Me.tValorPedidoCompra.FlatBorderColor = System.Drawing.Color.DimGray
        Me.tValorPedidoCompra.FocusColor = System.Drawing.Color.Empty
        Me.tValorPedidoCompra.FocusColorEnd = System.Drawing.Color.Empty
        Me.tValorPedidoCompra.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tValorPedidoCompra.HighlightBorderOnEnter = False
        Me.tValorPedidoCompra.Location = New System.Drawing.Point(175, 4)
        Me.tValorPedidoCompra.MaxLength = 15
        Me.tValorPedidoCompra.Name = "tValorPedidoCompra"
        Me.tValorPedidoCompra.PreencherZeroEsqueda = False
        Me.tValorPedidoCompra.RegraValidação = Nothing
        Me.tValorPedidoCompra.RegraValidaçãoMensagem = Nothing
        Me.tValorPedidoCompra.Size = New System.Drawing.Size(166, 26)
        Me.tValorPedidoCompra.TabIndex = 1
        Me.tValorPedidoCompra.TabStop = False
        Me.tValorPedidoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tValorPedidoCompra.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.tValorPedidoCompra.ValorPadrao = Nothing
        '
        'txtResto
        '
        Me.txtResto.Location = New System.Drawing.Point(3, 400)
        Me.txtResto.Name = "txtResto"
        Me.txtResto.Size = New System.Drawing.Size(82, 20)
        Me.txtResto.TabIndex = 15
        Me.txtResto.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(90, 402)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(82, 20)
        Me.txtTotal.TabIndex = 16
        Me.txtTotal.Visible = False
        '
        'ListaPagar
        '
        Me.ListaPagar.AllowUserToAddRows = False
        Me.ListaPagar.AllowUserToDeleteRows = False
        Me.ListaPagar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ListaPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ListaPagar.ContextMenuStrip = Me.MenuLista
        Me.ListaPagar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ListaPagar.Location = New System.Drawing.Point(6, 5)
        Me.ListaPagar.MultiSelect = False
        Me.ListaPagar.Name = "ListaPagar"
        Me.ListaPagar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ListaPagar.RowHeadersWidth = 21
        Me.ListaPagar.RowTemplate.Height = 24
        Me.ListaPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ListaPagar.ShowEditingIcon = False
        Me.ListaPagar.Size = New System.Drawing.Size(282, 316)
        Me.ListaPagar.TabIndex = 12
        '
        'MenuLista
        '
        Me.MenuLista.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.MenuLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirTodasAsParcelasToolStripMenuItem})
        Me.MenuLista.Name = "MenuLista"
        Me.MenuLista.Size = New System.Drawing.Size(220, 26)
        '
        'ExcluirTodasAsParcelasToolStripMenuItem
        '
        Me.ExcluirTodasAsParcelasToolStripMenuItem.Name = "ExcluirTodasAsParcelasToolStripMenuItem"
        Me.ExcluirTodasAsParcelasToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ExcluirTodasAsParcelasToolStripMenuItem.Text = "Excluir Todas as Parcelas"
        '
        'btnGerarParcelas
        '
        Me.btnGerarParcelas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGerarParcelas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGerarParcelas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerarParcelas.Location = New System.Drawing.Point(530, 342)
        Me.btnGerarParcelas.Name = "btnGerarParcelas"
        Me.btnGerarParcelas.Size = New System.Drawing.Size(116, 30)
        Me.btnGerarParcelas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGerarParcelas.TabIndex = 11
        Me.btnGerarParcelas.Text = "Gerar Parcelas"
        '
        'parcelas
        '
        Me.parcelas.AceitaColarTexto = True
        Me.parcelas.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.parcelas.CasasDecimais = 2
        Me.parcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.parcelas.CPObrigatorio = False
        Me.parcelas.CPObrigatorioMsg = Nothing
        Me.parcelas.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.parcelas.FlatBorder = False
        Me.parcelas.FlatBorderColor = System.Drawing.Color.DimGray
        Me.parcelas.FocusColor = System.Drawing.Color.Empty
        Me.parcelas.FocusColorEnd = System.Drawing.Color.Empty
        Me.parcelas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parcelas.HighlightBorderOnEnter = False
        Me.parcelas.Location = New System.Drawing.Point(365, 306)
        Me.parcelas.MaxLength = 10
        Me.parcelas.Name = "parcelas"
        Me.parcelas.PreencherZeroEsqueda = False
        Me.parcelas.RegraValidação = Nothing
        Me.parcelas.RegraValidaçãoMensagem = Nothing
        Me.parcelas.Size = New System.Drawing.Size(53, 23)
        Me.parcelas.TabIndex = 8
        Me.parcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.parcelas.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.parcelas.ValorPadrao = Nothing
        '
        'DataPrimeiroVencimento
        '
        Me.DataPrimeiroVencimento.AceitaColarTexto = True
        Me.DataPrimeiroVencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataPrimeiroVencimento.CasasDecimais = 2
        Me.DataPrimeiroVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataPrimeiroVencimento.CPObrigatorio = False
        Me.DataPrimeiroVencimento.CPObrigatorioMsg = Nothing
        Me.DataPrimeiroVencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataPrimeiroVencimento.FlatBorder = False
        Me.DataPrimeiroVencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataPrimeiroVencimento.FocusColor = System.Drawing.Color.Empty
        Me.DataPrimeiroVencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataPrimeiroVencimento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPrimeiroVencimento.HighlightBorderOnEnter = False
        Me.DataPrimeiroVencimento.Location = New System.Drawing.Point(530, 306)
        Me.DataPrimeiroVencimento.MaxLength = 10
        Me.DataPrimeiroVencimento.Name = "DataPrimeiroVencimento"
        Me.DataPrimeiroVencimento.PreencherZeroEsqueda = False
        Me.DataPrimeiroVencimento.RegraValidação = Nothing
        Me.DataPrimeiroVencimento.RegraValidaçãoMensagem = Nothing
        Me.DataPrimeiroVencimento.Size = New System.Drawing.Size(117, 23)
        Me.DataPrimeiroVencimento.TabIndex = 10
        Me.DataPrimeiroVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataPrimeiroVencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataPrimeiroVencimento.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Data 1º Vencimento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Parcelas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocalPgto
        '
        Me.LocalPgto.Auto_Complete = True
        Me.LocalPgto.AutoLimitar_Lista = True
        Me.LocalPgto.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.LocalPgto.CPObrigatorio = False
        Me.LocalPgto.CPObrigatorioMsg = Nothing
        Me.LocalPgto.FlatBorder = False
        Me.LocalPgto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.LocalPgto.FormattingEnabled = True
        Me.LocalPgto.HighlightBorderOnEnter = False
        Me.LocalPgto.Items.AddRange(New Object() {"BANCO", "CARTEIRA"})
        Me.LocalPgto.Location = New System.Drawing.Point(365, 253)
        Me.LocalPgto.Margin = New System.Windows.Forms.Padding(2)
        Me.LocalPgto.Name = "LocalPgto"
        Me.LocalPgto.Size = New System.Drawing.Size(283, 21)
        Me.LocalPgto.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(294, 254)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Local Pgto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 284)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Destino"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Destino
        '
        Me.Destino.AceitaColarTexto = True
        Me.Destino.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Destino.CasasDecimais = 0
        Me.Destino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Destino.CPObrigatorio = False
        Me.Destino.CPObrigatorioMsg = Nothing
        Me.Destino.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Destino.FlatBorder = False
        Me.Destino.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Destino.FocusColor = System.Drawing.Color.Empty
        Me.Destino.FocusColorEnd = System.Drawing.Color.Empty
        Me.Destino.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destino.HighlightBorderOnEnter = False
        Me.Destino.Location = New System.Drawing.Point(365, 278)
        Me.Destino.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Destino.MaxLength = 90
        Me.Destino.Name = "Destino"
        Me.Destino.PreencherZeroEsqueda = False
        Me.Destino.RegraValidação = Nothing
        Me.Destino.RegraValidaçãoMensagem = Nothing
        Me.Destino.Size = New System.Drawing.Size(282, 23)
        Me.Destino.TabIndex = 6
        Me.Destino.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Destino.ValorPadrao = Nothing
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.ContaLancamentoDesc)
        Me.GroupPanel2.Controls.Add(Me.btFindValor)
        Me.GroupPanel2.Controls.Add(Me.ContaLancamento)
        Me.GroupPanel2.Location = New System.Drawing.Point(298, 46)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(350, 45)
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
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Conta balancente"
        '
        'ContaLancamentoDesc
        '
        Me.ContaLancamentoDesc.AceitaColarTexto = True
        Me.ContaLancamentoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaLancamentoDesc.CasasDecimais = 2
        Me.ContaLancamentoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaLancamentoDesc.CPObrigatorio = False
        Me.ContaLancamentoDesc.CPObrigatorioMsg = Nothing
        Me.ContaLancamentoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaLancamentoDesc.FlatBorder = False
        Me.ContaLancamentoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaLancamentoDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaLancamentoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaLancamentoDesc.HighlightBorderOnEnter = False
        Me.ContaLancamentoDesc.Location = New System.Drawing.Point(73, 2)
        Me.ContaLancamentoDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.ContaLancamentoDesc.MaxLength = 6
        Me.ContaLancamentoDesc.Name = "ContaLancamentoDesc"
        Me.ContaLancamentoDesc.PreencherZeroEsqueda = False
        Me.ContaLancamentoDesc.RegraValidação = Nothing
        Me.ContaLancamentoDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaLancamentoDesc.Size = New System.Drawing.Size(270, 20)
        Me.ContaLancamentoDesc.TabIndex = 2
        Me.ContaLancamentoDesc.TabStop = False
        Me.ContaLancamentoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaLancamentoDesc.ValorPadrao = Nothing
        '
        'btFindValor
        '
        Me.btFindValor.Image = CType(resources.GetObject("btFindValor.Image"), System.Drawing.Image)
        Me.btFindValor.Location = New System.Drawing.Point(54, 4)
        Me.btFindValor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btFindValor.Name = "btFindValor"
        Me.btFindValor.Size = New System.Drawing.Size(14, 16)
        Me.btFindValor.TabIndex = 1
        '
        'ContaLancamento
        '
        Me.ContaLancamento.AceitaColarTexto = True
        Me.ContaLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaLancamento.CasasDecimais = 2
        Me.ContaLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaLancamento.CPObrigatorio = False
        Me.ContaLancamento.CPObrigatorioMsg = Nothing
        Me.ContaLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaLancamento.FlatBorder = False
        Me.ContaLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaLancamento.FocusColor = System.Drawing.Color.Empty
        Me.ContaLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaLancamento.HighlightBorderOnEnter = False
        Me.ContaLancamento.Location = New System.Drawing.Point(6, 2)
        Me.ContaLancamento.Margin = New System.Windows.Forms.Padding(2)
        Me.ContaLancamento.MaxLength = 6
        Me.ContaLancamento.Name = "ContaLancamento"
        Me.ContaLancamento.PreencherZeroEsqueda = True
        Me.ContaLancamento.RegraValidação = Nothing
        Me.ContaLancamento.RegraValidaçãoMensagem = Nothing
        Me.ContaLancamento.Size = New System.Drawing.Size(44, 20)
        Me.ContaLancamento.TabIndex = 0
        Me.ContaLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContaLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaLancamento.ValorPadrao = Nothing
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Find6)
        Me.GroupPanel1.Controls.Add(Me.DescConta6)
        Me.GroupPanel1.Controls.Add(Me.Find5)
        Me.GroupPanel1.Controls.Add(Me.DescConta5)
        Me.GroupPanel1.Controls.Add(Me.Find4)
        Me.GroupPanel1.Controls.Add(Me.DescConta4)
        Me.GroupPanel1.Controls.Add(Me.Find3)
        Me.GroupPanel1.Controls.Add(Me.DescConta3)
        Me.GroupPanel1.Controls.Add(Me.Find2)
        Me.GroupPanel1.Controls.Add(Me.DescConta2)
        Me.GroupPanel1.Controls.Add(Me.Find1)
        Me.GroupPanel1.Controls.Add(Me.Conta6)
        Me.GroupPanel1.Controls.Add(Me.Vlr6)
        Me.GroupPanel1.Controls.Add(Me.Conta5)
        Me.GroupPanel1.Controls.Add(Me.Vlr5)
        Me.GroupPanel1.Controls.Add(Me.Conta4)
        Me.GroupPanel1.Controls.Add(Me.Vlr4)
        Me.GroupPanel1.Controls.Add(Me.Conta3)
        Me.GroupPanel1.Controls.Add(Me.Vlr3)
        Me.GroupPanel1.Controls.Add(Me.Conta2)
        Me.GroupPanel1.Controls.Add(Me.Vlr2)
        Me.GroupPanel1.Controls.Add(Me.Conta1)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.Label18)
        Me.GroupPanel1.Controls.Add(Me.DescConta1)
        Me.GroupPanel1.Controls.Add(Me.Label19)
        Me.GroupPanel1.Controls.Add(Me.Vlr1)
        Me.GroupPanel1.Location = New System.Drawing.Point(297, 96)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(350, 150)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Lançamento de Contas"
        '
        'Find6
        '
        Me.Find6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find6.Enabled = False
        Me.Find6.Image = CType(resources.GetObject("Find6.Image"), System.Drawing.Image)
        Me.Find6.Location = New System.Drawing.Point(49, 106)
        Me.Find6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Find6.Name = "Find6"
        Me.Find6.Size = New System.Drawing.Size(17, 19)
        Me.Find6.TabIndex = 24
        '
        'DescConta6
        '
        Me.DescConta6.AceitaColarTexto = True
        Me.DescConta6.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta6.CasasDecimais = 0
        Me.DescConta6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta6.CPObrigatorio = False
        Me.DescConta6.CPObrigatorioMsg = Nothing
        Me.DescConta6.Enabled = False
        Me.DescConta6.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta6.FlatBorder = True
        Me.DescConta6.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta6.FocusColor = System.Drawing.Color.Empty
        Me.DescConta6.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta6.HighlightBorderOnEnter = False
        Me.DescConta6.Location = New System.Drawing.Point(64, 106)
        Me.DescConta6.Margin = New System.Windows.Forms.Padding(2)
        Me.DescConta6.MaxLength = 100
        Me.DescConta6.Name = "DescConta6"
        Me.DescConta6.PreencherZeroEsqueda = False
        Me.DescConta6.RegraValidação = Nothing
        Me.DescConta6.RegraValidaçãoMensagem = Nothing
        Me.DescConta6.Size = New System.Drawing.Size(209, 23)
        Me.DescConta6.TabIndex = 25
        Me.DescConta6.TabStop = False
        Me.DescConta6.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta6.ValorPadrao = Nothing
        '
        'Find5
        '
        Me.Find5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find5.Enabled = False
        Me.Find5.Image = CType(resources.GetObject("Find5.Image"), System.Drawing.Image)
        Me.Find5.Location = New System.Drawing.Point(49, 88)
        Me.Find5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Find5.Name = "Find5"
        Me.Find5.Size = New System.Drawing.Size(17, 19)
        Me.Find5.TabIndex = 20
        '
        'DescConta5
        '
        Me.DescConta5.AceitaColarTexto = True
        Me.DescConta5.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta5.CasasDecimais = 0
        Me.DescConta5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta5.CPObrigatorio = False
        Me.DescConta5.CPObrigatorioMsg = Nothing
        Me.DescConta5.Enabled = False
        Me.DescConta5.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta5.FlatBorder = True
        Me.DescConta5.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta5.FocusColor = System.Drawing.Color.Empty
        Me.DescConta5.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta5.HighlightBorderOnEnter = False
        Me.DescConta5.Location = New System.Drawing.Point(64, 88)
        Me.DescConta5.Margin = New System.Windows.Forms.Padding(2)
        Me.DescConta5.MaxLength = 100
        Me.DescConta5.Name = "DescConta5"
        Me.DescConta5.PreencherZeroEsqueda = False
        Me.DescConta5.RegraValidação = Nothing
        Me.DescConta5.RegraValidaçãoMensagem = Nothing
        Me.DescConta5.Size = New System.Drawing.Size(209, 23)
        Me.DescConta5.TabIndex = 21
        Me.DescConta5.TabStop = False
        Me.DescConta5.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta5.ValorPadrao = Nothing
        '
        'Find4
        '
        Me.Find4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find4.Enabled = False
        Me.Find4.Image = CType(resources.GetObject("Find4.Image"), System.Drawing.Image)
        Me.Find4.Location = New System.Drawing.Point(49, 70)
        Me.Find4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Find4.Name = "Find4"
        Me.Find4.Size = New System.Drawing.Size(17, 19)
        Me.Find4.TabIndex = 16
        '
        'DescConta4
        '
        Me.DescConta4.AceitaColarTexto = True
        Me.DescConta4.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta4.CasasDecimais = 0
        Me.DescConta4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta4.CPObrigatorio = False
        Me.DescConta4.CPObrigatorioMsg = Nothing
        Me.DescConta4.Enabled = False
        Me.DescConta4.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta4.FlatBorder = True
        Me.DescConta4.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta4.FocusColor = System.Drawing.Color.Empty
        Me.DescConta4.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta4.HighlightBorderOnEnter = False
        Me.DescConta4.Location = New System.Drawing.Point(64, 70)
        Me.DescConta4.Margin = New System.Windows.Forms.Padding(2)
        Me.DescConta4.MaxLength = 100
        Me.DescConta4.Name = "DescConta4"
        Me.DescConta4.PreencherZeroEsqueda = False
        Me.DescConta4.RegraValidação = Nothing
        Me.DescConta4.RegraValidaçãoMensagem = Nothing
        Me.DescConta4.Size = New System.Drawing.Size(209, 23)
        Me.DescConta4.TabIndex = 17
        Me.DescConta4.TabStop = False
        Me.DescConta4.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta4.ValorPadrao = Nothing
        '
        'Find3
        '
        Me.Find3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find3.Enabled = False
        Me.Find3.Image = CType(resources.GetObject("Find3.Image"), System.Drawing.Image)
        Me.Find3.Location = New System.Drawing.Point(49, 52)
        Me.Find3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Find3.Name = "Find3"
        Me.Find3.Size = New System.Drawing.Size(17, 19)
        Me.Find3.TabIndex = 12
        '
        'DescConta3
        '
        Me.DescConta3.AceitaColarTexto = True
        Me.DescConta3.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta3.CasasDecimais = 0
        Me.DescConta3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta3.CPObrigatorio = False
        Me.DescConta3.CPObrigatorioMsg = Nothing
        Me.DescConta3.Enabled = False
        Me.DescConta3.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta3.FlatBorder = True
        Me.DescConta3.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta3.FocusColor = System.Drawing.Color.Empty
        Me.DescConta3.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta3.HighlightBorderOnEnter = False
        Me.DescConta3.Location = New System.Drawing.Point(64, 52)
        Me.DescConta3.Margin = New System.Windows.Forms.Padding(2)
        Me.DescConta3.MaxLength = 100
        Me.DescConta3.Name = "DescConta3"
        Me.DescConta3.PreencherZeroEsqueda = False
        Me.DescConta3.RegraValidação = Nothing
        Me.DescConta3.RegraValidaçãoMensagem = Nothing
        Me.DescConta3.Size = New System.Drawing.Size(209, 23)
        Me.DescConta3.TabIndex = 13
        Me.DescConta3.TabStop = False
        Me.DescConta3.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta3.ValorPadrao = Nothing
        '
        'Find2
        '
        Me.Find2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find2.Enabled = False
        Me.Find2.Image = CType(resources.GetObject("Find2.Image"), System.Drawing.Image)
        Me.Find2.Location = New System.Drawing.Point(49, 34)
        Me.Find2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Find2.Name = "Find2"
        Me.Find2.Size = New System.Drawing.Size(17, 19)
        Me.Find2.TabIndex = 8
        '
        'DescConta2
        '
        Me.DescConta2.AceitaColarTexto = True
        Me.DescConta2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta2.CasasDecimais = 0
        Me.DescConta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta2.CPObrigatorio = False
        Me.DescConta2.CPObrigatorioMsg = Nothing
        Me.DescConta2.Enabled = False
        Me.DescConta2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta2.FlatBorder = True
        Me.DescConta2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta2.FocusColor = System.Drawing.Color.Empty
        Me.DescConta2.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta2.HighlightBorderOnEnter = False
        Me.DescConta2.Location = New System.Drawing.Point(64, 34)
        Me.DescConta2.Margin = New System.Windows.Forms.Padding(2)
        Me.DescConta2.MaxLength = 100
        Me.DescConta2.Name = "DescConta2"
        Me.DescConta2.PreencherZeroEsqueda = False
        Me.DescConta2.RegraValidação = Nothing
        Me.DescConta2.RegraValidaçãoMensagem = Nothing
        Me.DescConta2.Size = New System.Drawing.Size(209, 23)
        Me.DescConta2.TabIndex = 9
        Me.DescConta2.TabStop = False
        Me.DescConta2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta2.ValorPadrao = Nothing
        '
        'Find1
        '
        Me.Find1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find1.Image = CType(resources.GetObject("Find1.Image"), System.Drawing.Image)
        Me.Find1.Location = New System.Drawing.Point(49, 16)
        Me.Find1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Find1.Name = "Find1"
        Me.Find1.Size = New System.Drawing.Size(17, 19)
        Me.Find1.TabIndex = 4
        '
        'Conta6
        '
        Me.Conta6.AceitaColarTexto = True
        Me.Conta6.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta6.CasasDecimais = 0
        Me.Conta6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta6.CPObrigatorio = False
        Me.Conta6.CPObrigatorioMsg = Nothing
        Me.Conta6.Enabled = False
        Me.Conta6.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta6.FlatBorder = True
        Me.Conta6.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta6.FocusColor = System.Drawing.Color.Empty
        Me.Conta6.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta6.HighlightBorderOnEnter = False
        Me.Conta6.Location = New System.Drawing.Point(7, 106)
        Me.Conta6.Margin = New System.Windows.Forms.Padding(2)
        Me.Conta6.MaxLength = 6
        Me.Conta6.Name = "Conta6"
        Me.Conta6.PreencherZeroEsqueda = True
        Me.Conta6.RegraValidação = Nothing
        Me.Conta6.RegraValidaçãoMensagem = Nothing
        Me.Conta6.Size = New System.Drawing.Size(43, 23)
        Me.Conta6.TabIndex = 23
        Me.Conta6.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta6.ValorPadrao = Nothing
        '
        'Vlr6
        '
        Me.Vlr6.AceitaColarTexto = True
        Me.Vlr6.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr6.CasasDecimais = 2
        Me.Vlr6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr6.CPObrigatorio = False
        Me.Vlr6.CPObrigatorioMsg = Nothing
        Me.Vlr6.Enabled = False
        Me.Vlr6.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr6.FlatBorder = True
        Me.Vlr6.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr6.FocusColor = System.Drawing.Color.Empty
        Me.Vlr6.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr6.HighlightBorderOnEnter = False
        Me.Vlr6.Location = New System.Drawing.Point(272, 106)
        Me.Vlr6.Margin = New System.Windows.Forms.Padding(2)
        Me.Vlr6.MaxLength = 15
        Me.Vlr6.Name = "Vlr6"
        Me.Vlr6.PreencherZeroEsqueda = False
        Me.Vlr6.RegraValidação = Nothing
        Me.Vlr6.RegraValidaçãoMensagem = Nothing
        Me.Vlr6.Size = New System.Drawing.Size(70, 23)
        Me.Vlr6.TabIndex = 26
        Me.Vlr6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr6.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr6.ValorPadrao = Nothing
        '
        'Conta5
        '
        Me.Conta5.AceitaColarTexto = True
        Me.Conta5.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta5.CasasDecimais = 0
        Me.Conta5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta5.CPObrigatorio = False
        Me.Conta5.CPObrigatorioMsg = Nothing
        Me.Conta5.Enabled = False
        Me.Conta5.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta5.FlatBorder = True
        Me.Conta5.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta5.FocusColor = System.Drawing.Color.Empty
        Me.Conta5.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta5.HighlightBorderOnEnter = False
        Me.Conta5.Location = New System.Drawing.Point(7, 88)
        Me.Conta5.Margin = New System.Windows.Forms.Padding(2)
        Me.Conta5.MaxLength = 6
        Me.Conta5.Name = "Conta5"
        Me.Conta5.PreencherZeroEsqueda = True
        Me.Conta5.RegraValidação = Nothing
        Me.Conta5.RegraValidaçãoMensagem = Nothing
        Me.Conta5.Size = New System.Drawing.Size(43, 23)
        Me.Conta5.TabIndex = 19
        Me.Conta5.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta5.ValorPadrao = Nothing
        '
        'Vlr5
        '
        Me.Vlr5.AceitaColarTexto = True
        Me.Vlr5.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr5.CasasDecimais = 2
        Me.Vlr5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr5.CPObrigatorio = False
        Me.Vlr5.CPObrigatorioMsg = Nothing
        Me.Vlr5.Enabled = False
        Me.Vlr5.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr5.FlatBorder = True
        Me.Vlr5.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr5.FocusColor = System.Drawing.Color.Empty
        Me.Vlr5.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr5.HighlightBorderOnEnter = False
        Me.Vlr5.Location = New System.Drawing.Point(272, 88)
        Me.Vlr5.Margin = New System.Windows.Forms.Padding(2)
        Me.Vlr5.MaxLength = 15
        Me.Vlr5.Name = "Vlr5"
        Me.Vlr5.PreencherZeroEsqueda = False
        Me.Vlr5.RegraValidação = Nothing
        Me.Vlr5.RegraValidaçãoMensagem = Nothing
        Me.Vlr5.Size = New System.Drawing.Size(70, 23)
        Me.Vlr5.TabIndex = 22
        Me.Vlr5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr5.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr5.ValorPadrao = Nothing
        '
        'Conta4
        '
        Me.Conta4.AceitaColarTexto = True
        Me.Conta4.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta4.CasasDecimais = 0
        Me.Conta4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta4.CPObrigatorio = False
        Me.Conta4.CPObrigatorioMsg = Nothing
        Me.Conta4.Enabled = False
        Me.Conta4.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta4.FlatBorder = True
        Me.Conta4.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta4.FocusColor = System.Drawing.Color.Empty
        Me.Conta4.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta4.HighlightBorderOnEnter = False
        Me.Conta4.Location = New System.Drawing.Point(7, 70)
        Me.Conta4.Margin = New System.Windows.Forms.Padding(2)
        Me.Conta4.MaxLength = 6
        Me.Conta4.Name = "Conta4"
        Me.Conta4.PreencherZeroEsqueda = True
        Me.Conta4.RegraValidação = Nothing
        Me.Conta4.RegraValidaçãoMensagem = Nothing
        Me.Conta4.Size = New System.Drawing.Size(43, 23)
        Me.Conta4.TabIndex = 15
        Me.Conta4.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta4.ValorPadrao = Nothing
        '
        'Vlr4
        '
        Me.Vlr4.AceitaColarTexto = True
        Me.Vlr4.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr4.CasasDecimais = 2
        Me.Vlr4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr4.CPObrigatorio = False
        Me.Vlr4.CPObrigatorioMsg = Nothing
        Me.Vlr4.Enabled = False
        Me.Vlr4.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr4.FlatBorder = True
        Me.Vlr4.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr4.FocusColor = System.Drawing.Color.Empty
        Me.Vlr4.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr4.HighlightBorderOnEnter = False
        Me.Vlr4.Location = New System.Drawing.Point(272, 70)
        Me.Vlr4.Margin = New System.Windows.Forms.Padding(2)
        Me.Vlr4.MaxLength = 15
        Me.Vlr4.Name = "Vlr4"
        Me.Vlr4.PreencherZeroEsqueda = False
        Me.Vlr4.RegraValidação = Nothing
        Me.Vlr4.RegraValidaçãoMensagem = Nothing
        Me.Vlr4.Size = New System.Drawing.Size(70, 23)
        Me.Vlr4.TabIndex = 18
        Me.Vlr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr4.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr4.ValorPadrao = Nothing
        '
        'Conta3
        '
        Me.Conta3.AceitaColarTexto = True
        Me.Conta3.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta3.CasasDecimais = 0
        Me.Conta3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta3.CPObrigatorio = False
        Me.Conta3.CPObrigatorioMsg = Nothing
        Me.Conta3.Enabled = False
        Me.Conta3.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta3.FlatBorder = True
        Me.Conta3.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta3.FocusColor = System.Drawing.Color.Empty
        Me.Conta3.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta3.HighlightBorderOnEnter = False
        Me.Conta3.Location = New System.Drawing.Point(7, 52)
        Me.Conta3.Margin = New System.Windows.Forms.Padding(2)
        Me.Conta3.MaxLength = 6
        Me.Conta3.Name = "Conta3"
        Me.Conta3.PreencherZeroEsqueda = True
        Me.Conta3.RegraValidação = Nothing
        Me.Conta3.RegraValidaçãoMensagem = Nothing
        Me.Conta3.Size = New System.Drawing.Size(43, 23)
        Me.Conta3.TabIndex = 11
        Me.Conta3.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta3.ValorPadrao = Nothing
        '
        'Vlr3
        '
        Me.Vlr3.AceitaColarTexto = True
        Me.Vlr3.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr3.CasasDecimais = 2
        Me.Vlr3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr3.CPObrigatorio = False
        Me.Vlr3.CPObrigatorioMsg = Nothing
        Me.Vlr3.Enabled = False
        Me.Vlr3.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr3.FlatBorder = True
        Me.Vlr3.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr3.FocusColor = System.Drawing.Color.Empty
        Me.Vlr3.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr3.HighlightBorderOnEnter = False
        Me.Vlr3.Location = New System.Drawing.Point(272, 52)
        Me.Vlr3.Margin = New System.Windows.Forms.Padding(2)
        Me.Vlr3.MaxLength = 15
        Me.Vlr3.Name = "Vlr3"
        Me.Vlr3.PreencherZeroEsqueda = False
        Me.Vlr3.RegraValidação = Nothing
        Me.Vlr3.RegraValidaçãoMensagem = Nothing
        Me.Vlr3.Size = New System.Drawing.Size(70, 23)
        Me.Vlr3.TabIndex = 14
        Me.Vlr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr3.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr3.ValorPadrao = Nothing
        '
        'Conta2
        '
        Me.Conta2.AceitaColarTexto = True
        Me.Conta2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta2.CasasDecimais = 0
        Me.Conta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta2.CPObrigatorio = False
        Me.Conta2.CPObrigatorioMsg = Nothing
        Me.Conta2.Enabled = False
        Me.Conta2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta2.FlatBorder = True
        Me.Conta2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta2.FocusColor = System.Drawing.Color.Empty
        Me.Conta2.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta2.HighlightBorderOnEnter = False
        Me.Conta2.Location = New System.Drawing.Point(7, 34)
        Me.Conta2.Margin = New System.Windows.Forms.Padding(2)
        Me.Conta2.MaxLength = 6
        Me.Conta2.Name = "Conta2"
        Me.Conta2.PreencherZeroEsqueda = True
        Me.Conta2.RegraValidação = Nothing
        Me.Conta2.RegraValidaçãoMensagem = Nothing
        Me.Conta2.Size = New System.Drawing.Size(43, 23)
        Me.Conta2.TabIndex = 7
        Me.Conta2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta2.ValorPadrao = Nothing
        '
        'Vlr2
        '
        Me.Vlr2.AceitaColarTexto = True
        Me.Vlr2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr2.CasasDecimais = 2
        Me.Vlr2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr2.CPObrigatorio = False
        Me.Vlr2.CPObrigatorioMsg = Nothing
        Me.Vlr2.Enabled = False
        Me.Vlr2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr2.FlatBorder = True
        Me.Vlr2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr2.FocusColor = System.Drawing.Color.Empty
        Me.Vlr2.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr2.HighlightBorderOnEnter = False
        Me.Vlr2.Location = New System.Drawing.Point(272, 34)
        Me.Vlr2.Margin = New System.Windows.Forms.Padding(2)
        Me.Vlr2.MaxLength = 15
        Me.Vlr2.Name = "Vlr2"
        Me.Vlr2.PreencherZeroEsqueda = False
        Me.Vlr2.RegraValidação = Nothing
        Me.Vlr2.RegraValidaçãoMensagem = Nothing
        Me.Vlr2.Size = New System.Drawing.Size(70, 23)
        Me.Vlr2.TabIndex = 10
        Me.Vlr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr2.ValorPadrao = Nothing
        '
        'Conta1
        '
        Me.Conta1.AceitaColarTexto = True
        Me.Conta1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta1.CasasDecimais = 0
        Me.Conta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta1.CPObrigatorio = False
        Me.Conta1.CPObrigatorioMsg = Nothing
        Me.Conta1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta1.FlatBorder = True
        Me.Conta1.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta1.FocusColor = System.Drawing.Color.Empty
        Me.Conta1.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta1.HighlightBorderOnEnter = False
        Me.Conta1.Location = New System.Drawing.Point(7, 16)
        Me.Conta1.Margin = New System.Windows.Forms.Padding(2)
        Me.Conta1.MaxLength = 6
        Me.Conta1.Name = "Conta1"
        Me.Conta1.PreencherZeroEsqueda = True
        Me.Conta1.RegraValidação = Nothing
        Me.Conta1.RegraValidaçãoMensagem = Nothing
        Me.Conta1.Size = New System.Drawing.Size(43, 23)
        Me.Conta1.TabIndex = 3
        Me.Conta1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta1.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Conta"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(272, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Valor"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescConta1
        '
        Me.DescConta1.AceitaColarTexto = True
        Me.DescConta1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta1.CasasDecimais = 0
        Me.DescConta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta1.CPObrigatorio = False
        Me.DescConta1.CPObrigatorioMsg = Nothing
        Me.DescConta1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta1.FlatBorder = True
        Me.DescConta1.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta1.FocusColor = System.Drawing.Color.Empty
        Me.DescConta1.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta1.HighlightBorderOnEnter = False
        Me.DescConta1.Location = New System.Drawing.Point(64, 16)
        Me.DescConta1.Margin = New System.Windows.Forms.Padding(2)
        Me.DescConta1.MaxLength = 100
        Me.DescConta1.Name = "DescConta1"
        Me.DescConta1.PreencherZeroEsqueda = False
        Me.DescConta1.RegraValidação = Nothing
        Me.DescConta1.RegraValidaçãoMensagem = Nothing
        Me.DescConta1.Size = New System.Drawing.Size(209, 23)
        Me.DescConta1.TabIndex = 5
        Me.DescConta1.TabStop = False
        Me.DescConta1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta1.ValorPadrao = Nothing
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(49, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(225, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Descrição"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vlr1
        '
        Me.Vlr1.AceitaColarTexto = True
        Me.Vlr1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr1.CasasDecimais = 2
        Me.Vlr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr1.CPObrigatorio = False
        Me.Vlr1.CPObrigatorioMsg = Nothing
        Me.Vlr1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr1.FlatBorder = True
        Me.Vlr1.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr1.FocusColor = System.Drawing.Color.Empty
        Me.Vlr1.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr1.HighlightBorderOnEnter = False
        Me.Vlr1.Location = New System.Drawing.Point(272, 16)
        Me.Vlr1.Margin = New System.Windows.Forms.Padding(2)
        Me.Vlr1.MaxLength = 15
        Me.Vlr1.Name = "Vlr1"
        Me.Vlr1.PreencherZeroEsqueda = False
        Me.Vlr1.RegraValidação = Nothing
        Me.Vlr1.RegraValidaçãoMensagem = Nothing
        Me.Vlr1.Size = New System.Drawing.Size(70, 23)
        Me.Vlr1.TabIndex = 6
        Me.Vlr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr1.ValorPadrao = Nothing
        '
        'PedidoCompraConfirmar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PedidoCompraConfirmar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido Compra Confirmar"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.ListaPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuLista.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Public WithEvents Find6 As System.Windows.Forms.Label
    Public WithEvents DescConta6 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find5 As System.Windows.Forms.Label
    Public WithEvents DescConta5 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find4 As System.Windows.Forms.Label
    Public WithEvents DescConta4 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find3 As System.Windows.Forms.Label
    Public WithEvents DescConta3 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find2 As System.Windows.Forms.Label
    Public WithEvents DescConta2 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find1 As System.Windows.Forms.Label
    Public WithEvents Conta6 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr6 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta5 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr5 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta4 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr4 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta3 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr3 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta2 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr2 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta1 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents DescConta1 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Vlr1 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btFindValor As System.Windows.Forms.Label
    Friend WithEvents ContaLancamentoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaLancamento As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents LocalPgto As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Destino As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents parcelas As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataPrimeiroVencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGerarParcelas As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtResto As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents ListaPagar As System.Windows.Forms.DataGridView
    Friend WithEvents MenuLista As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirTodasAsParcelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tValorPedidoCompra As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents butConfirmar As DevComponents.DotNetBar.ButtonX
End Class
