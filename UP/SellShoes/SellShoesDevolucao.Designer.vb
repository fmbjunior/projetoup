<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesDevolucao
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btDevolução = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ListaItens = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cQtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDesconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorDesconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selecionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cCustoMercadoriaVendida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDevolvidoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPromocao = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cDevolvido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cQtdDevolvido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cQDevolver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAcrecimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpAcrecimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEspecial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpEspecial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaPedido = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cPedidoSequencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDataPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipoPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDevNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        CType(Me.ListaItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btDevolução)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.PainelPeriodo)
        Me.PanelEx1.Controls.Add(Me.ListaItens)
        Me.PanelEx1.Controls.Add(Me.ListaPedido)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.txtProcura)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(988, 626)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btDevolução
        '
        Me.btDevolução.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btDevolução.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btDevolução.Location = New System.Drawing.Point(716, 593)
        Me.btDevolução.Name = "btDevolução"
        Me.btDevolução.Size = New System.Drawing.Size(170, 26)
        Me.btDevolução.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btDevolução.TabIndex = 6
        Me.btDevolução.Text = "Devolver Itens Selecionado"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(892, 593)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(90, 26)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 5
        Me.btFechar.Text = "Fechar"
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label1)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(291, 32)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(304, 34)
        Me.PainelPeriodo.TabIndex = 0
        Me.PainelPeriodo.Visible = False
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 2
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FlatBorder = False
        Me.DataFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.HighlightBorderOnEnter = False
        Me.DataFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataFinal.Location = New System.Drawing.Point(209, 4)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(91, 23)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Inicia e Final"
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 2
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FlatBorder = False
        Me.DataInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.HighlightBorderOnEnter = False
        Me.DataInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataInicial.Location = New System.Drawing.Point(112, 4)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(91, 23)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'ListaItens
        '
        Me.ListaItens.AllowUserToAddRows = False
        Me.ListaItens.AllowUserToDeleteRows = False
        Me.ListaItens.AllowUserToResizeColumns = False
        Me.ListaItens.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.ListaItens.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaItens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cPedido, Me.cCodigoProduto, Me.cNumero, Me.cDescrição, Me.cQtd, Me.cValorUnitario, Me.cDesconto, Me.cValorDesconto, Me.cTotalProduto, Me.Selecionado, Me.cCustoMercadoriaVendida, Me.cDevolvidoId, Me.cPromocao, Me.cDevolvido, Me.cQtdDevolvido, Me.cQDevolver, Me.cAcrecimo, Me.cpAcrecimo, Me.cEspecial, Me.cpEspecial})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaItens.DefaultCellStyle = DataGridViewCellStyle9
        Me.ListaItens.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaItens.Location = New System.Drawing.Point(12, 338)
        Me.ListaItens.Name = "ListaItens"
        Me.ListaItens.RowHeadersVisible = False
        Me.ListaItens.RowHeadersWidth = 20
        Me.ListaItens.SelectAllSignVisible = False
        Me.ListaItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaItens.Size = New System.Drawing.Size(970, 252)
        Me.ListaItens.TabIndex = 2
        '
        'cId
        '
        Me.cId.DataPropertyName = "Id"
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        '
        'cPedido
        '
        Me.cPedido.DataPropertyName = "PedidoSequencia"
        Me.cPedido.HeaderText = "Pedido"
        Me.cPedido.Name = "cPedido"
        Me.cPedido.ReadOnly = True
        Me.cPedido.Visible = False
        '
        'cCodigoProduto
        '
        Me.cCodigoProduto.DataPropertyName = "CodigoProduto"
        Me.cCodigoProduto.HeaderText = "Produto"
        Me.cCodigoProduto.Name = "cCodigoProduto"
        Me.cCodigoProduto.ReadOnly = True
        Me.cCodigoProduto.Width = 80
        '
        'cNumero
        '
        Me.cNumero.DataPropertyName = "Numero"
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        Me.cNumero.ReadOnly = True
        Me.cNumero.Width = 70
        '
        'cDescrição
        '
        Me.cDescrição.DataPropertyName = "Descrição"
        Me.cDescrição.HeaderText = "Descrição"
        Me.cDescrição.Name = "cDescrição"
        Me.cDescrição.ReadOnly = True
        Me.cDescrição.Width = 240
        '
        'cQtd
        '
        Me.cQtd.DataPropertyName = "Qtd"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cQtd.DefaultCellStyle = DataGridViewCellStyle2
        Me.cQtd.HeaderText = "Qtd"
        Me.cQtd.Name = "cQtd"
        Me.cQtd.ReadOnly = True
        Me.cQtd.Width = 80
        '
        'cValorUnitario
        '
        Me.cValorUnitario.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cValorUnitario.DefaultCellStyle = DataGridViewCellStyle3
        Me.cValorUnitario.HeaderText = "Unitário"
        Me.cValorUnitario.Name = "cValorUnitario"
        Me.cValorUnitario.ReadOnly = True
        Me.cValorUnitario.Width = 80
        '
        'cDesconto
        '
        Me.cDesconto.DataPropertyName = "Desconto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.cDesconto.DefaultCellStyle = DataGridViewCellStyle4
        Me.cDesconto.HeaderText = "Desconto"
        Me.cDesconto.Name = "cDesconto"
        Me.cDesconto.ReadOnly = True
        Me.cDesconto.Width = 90
        '
        'cValorDesconto
        '
        Me.cValorDesconto.DataPropertyName = "ValorDesconto"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.cValorDesconto.DefaultCellStyle = DataGridViewCellStyle5
        Me.cValorDesconto.HeaderText = "Vlr Desc"
        Me.cValorDesconto.Name = "cValorDesconto"
        Me.cValorDesconto.ReadOnly = True
        Me.cValorDesconto.Width = 90
        '
        'cTotalProduto
        '
        Me.cTotalProduto.DataPropertyName = "TotalProduto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.cTotalProduto.DefaultCellStyle = DataGridViewCellStyle6
        Me.cTotalProduto.HeaderText = "Total Prod."
        Me.cTotalProduto.Name = "cTotalProduto"
        Me.cTotalProduto.ReadOnly = True
        Me.cTotalProduto.Width = 90
        '
        'Selecionado
        '
        Me.Selecionado.HeaderText = "Dev"
        Me.Selecionado.Name = "Selecionado"
        Me.Selecionado.Width = 35
        '
        'cCustoMercadoriaVendida
        '
        Me.cCustoMercadoriaVendida.DataPropertyName = "CustoMercadoriaVendida"
        Me.cCustoMercadoriaVendida.HeaderText = "CustoMercadoriaVendida"
        Me.cCustoMercadoriaVendida.Name = "cCustoMercadoriaVendida"
        Me.cCustoMercadoriaVendida.Visible = False
        '
        'cDevolvidoId
        '
        Me.cDevolvidoId.DataPropertyName = "DevolvidoId"
        Me.cDevolvidoId.HeaderText = "Devolvido Id"
        Me.cDevolvidoId.Name = "cDevolvidoId"
        Me.cDevolvidoId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cDevolvidoId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cDevolvidoId.Visible = False
        '
        'cPromocao
        '
        Me.cPromocao.DataPropertyName = "Promocao"
        Me.cPromocao.HeaderText = "Promoção"
        Me.cPromocao.Name = "cPromocao"
        Me.cPromocao.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPromocao.Visible = False
        '
        'cDevolvido
        '
        Me.cDevolvido.DataPropertyName = "Devolvido"
        Me.cDevolvido.HeaderText = "Devolvido"
        Me.cDevolvido.Name = "cDevolvido"
        Me.cDevolvido.Visible = False
        '
        'cQtdDevolvido
        '
        Me.cQtdDevolvido.DataPropertyName = "QtdDevolvido"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.cQtdDevolvido.DefaultCellStyle = DataGridViewCellStyle7
        Me.cQtdDevolvido.HeaderText = "Qtd Dev."
        Me.cQtdDevolvido.Name = "cQtdDevolvido"
        Me.cQtdDevolvido.ReadOnly = True
        Me.cQtdDevolvido.Width = 90
        '
        'cQDevolver
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.cQDevolver.DefaultCellStyle = DataGridViewCellStyle8
        Me.cQDevolver.HeaderText = "QDevolver"
        Me.cQDevolver.Name = "cQDevolver"
        Me.cQDevolver.Visible = False
        '
        'cAcrecimo
        '
        Me.cAcrecimo.DataPropertyName = "vAcrecimoVenda"
        Me.cAcrecimo.HeaderText = "Acrecimo"
        Me.cAcrecimo.Name = "cAcrecimo"
        Me.cAcrecimo.Visible = False
        '
        'cpAcrecimo
        '
        Me.cpAcrecimo.DataPropertyName = "pAcrecimoVenda"
        Me.cpAcrecimo.HeaderText = "pAcrecimo"
        Me.cpAcrecimo.Name = "cpAcrecimo"
        Me.cpAcrecimo.Visible = False
        '
        'cEspecial
        '
        Me.cEspecial.DataPropertyName = "vDescontoEspecial"
        Me.cEspecial.HeaderText = "Especial"
        Me.cEspecial.Name = "cEspecial"
        Me.cEspecial.Visible = False
        '
        'cpEspecial
        '
        Me.cpEspecial.DataPropertyName = "pDescontoEspecial"
        Me.cpEspecial.HeaderText = "pEspecial"
        Me.cpEspecial.Name = "cpEspecial"
        Me.cpEspecial.Visible = False
        '
        'ListaPedido
        '
        Me.ListaPedido.AllowUserToAddRows = False
        Me.ListaPedido.AllowUserToDeleteRows = False
        Me.ListaPedido.AllowUserToResizeColumns = False
        Me.ListaPedido.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro
        Me.ListaPedido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.ListaPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPedidoSequencia, Me.cNome, Me.gVendedor, Me.cDataPedido, Me.cTotalPedido, Me.cCodigoCliente, Me.cTipoPedido, Me.cDevNumero})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaPedido.DefaultCellStyle = DataGridViewCellStyle12
        Me.ListaPedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaPedido.Location = New System.Drawing.Point(12, 80)
        Me.ListaPedido.Name = "ListaPedido"
        Me.ListaPedido.ReadOnly = True
        Me.ListaPedido.RowHeadersVisible = False
        Me.ListaPedido.RowHeadersWidth = 20
        Me.ListaPedido.SelectAllSignVisible = False
        Me.ListaPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaPedido.Size = New System.Drawing.Size(970, 251)
        Me.ListaPedido.TabIndex = 1
        '
        'cPedidoSequencia
        '
        Me.cPedidoSequencia.DataPropertyName = "PedidoSequencia"
        Me.cPedidoSequencia.HeaderText = "Pedido"
        Me.cPedidoSequencia.Name = "cPedidoSequencia"
        Me.cPedidoSequencia.ReadOnly = True
        Me.cPedidoSequencia.Width = 80
        '
        'cNome
        '
        Me.cNome.DataPropertyName = "Nome"
        Me.cNome.HeaderText = "Cliente"
        Me.cNome.Name = "cNome"
        Me.cNome.ReadOnly = True
        Me.cNome.Width = 340
        '
        'gVendedor
        '
        Me.gVendedor.DataPropertyName = "Vendedor"
        Me.gVendedor.HeaderText = "Vendedor"
        Me.gVendedor.Name = "gVendedor"
        Me.gVendedor.ReadOnly = True
        Me.gVendedor.Width = 190
        '
        'cDataPedido
        '
        Me.cDataPedido.DataPropertyName = "DataPedido"
        Me.cDataPedido.HeaderText = "Dt Pedido"
        Me.cDataPedido.Name = "cDataPedido"
        Me.cDataPedido.ReadOnly = True
        Me.cDataPedido.Width = 80
        '
        'cTotalPedido
        '
        Me.cTotalPedido.DataPropertyName = "TotalPedido"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.cTotalPedido.DefaultCellStyle = DataGridViewCellStyle11
        Me.cTotalPedido.HeaderText = "Vlr Pedido"
        Me.cTotalPedido.Name = "cTotalPedido"
        Me.cTotalPedido.ReadOnly = True
        Me.cTotalPedido.Width = 90
        '
        'cCodigoCliente
        '
        Me.cCodigoCliente.DataPropertyName = "CódigoCliente"
        Me.cCodigoCliente.HeaderText = "Cod. Cliente"
        Me.cCodigoCliente.Name = "cCodigoCliente"
        Me.cCodigoCliente.ReadOnly = True
        Me.cCodigoCliente.Visible = False
        '
        'cTipoPedido
        '
        Me.cTipoPedido.DataPropertyName = "PedidoTipo"
        Me.cTipoPedido.HeaderText = "Tipo"
        Me.cTipoPedido.Name = "cTipoPedido"
        Me.cTipoPedido.ReadOnly = True
        Me.cTipoPedido.Width = 85
        '
        'cDevNumero
        '
        Me.cDevNumero.DataPropertyName = "DevNumero"
        Me.cDevNumero.HeaderText = "Ped OR"
        Me.cDevNumero.Name = "cDevNumero"
        Me.cDevNumero.ReadOnly = True
        Me.cDevNumero.Width = 80
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 8)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(273, 66)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Selecione uma Opção de Procura"
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(175, 10)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(84, 19)
        Me.A3.TabIndex = 4
        Me.A3.TabStop = True
        Me.A3.Text = "Por Período"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(88, 10)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(81, 19)
        Me.A2.TabIndex = 3
        Me.A2.TabStop = True
        Me.A2.Text = "Por Cliente"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 10)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(79, 19)
        Me.A1.TabIndex = 2
        Me.A1.TabStop = True
        Me.A1.Text = "Por Pedido"
        Me.A1.UseVisualStyleBackColor = True
        '
        'txtProcura
        '
        Me.txtProcura.AceitaColarTexto = True
        Me.txtProcura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtProcura.CasasDecimais = 2
        Me.txtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcura.CPObrigatorio = False
        Me.txtProcura.CPObrigatorioMsg = Nothing
        Me.txtProcura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtProcura.FlatBorder = False
        Me.txtProcura.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtProcura.FocusColor = System.Drawing.Color.Empty
        Me.txtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtProcura.HighlightBorderOnEnter = False
        Me.txtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtProcura.Location = New System.Drawing.Point(291, 36)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.Size = New System.Drawing.Size(569, 23)
        Me.txtProcura.TabIndex = 1
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        Me.txtProcura.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'SellShoesDevolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "SellShoesDevolucao"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellShoes-Devolução - T251"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        CType(Me.ListaItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ListaPedido As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ListaItens As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Private WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Private WithEvents btDevolução As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents cPedidoSequencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gVendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDataPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigoCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipoPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDevNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigoProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescrição As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cQtd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDesconto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorDesconto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Selecionado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cCustoMercadoriaVendida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDevolvidoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPromocao As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cDevolvido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cQtdDevolvido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cQDevolver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAcrecimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpAcrecimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEspecial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpEspecial As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
