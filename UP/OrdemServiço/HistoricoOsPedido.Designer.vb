<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricoOsPedido
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoricoOsPedido))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.DescPedido = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListaProduto = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.gridID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridCodigoServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridFuncionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridQuantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridValorServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlrDesconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridTotalServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorISS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaPedido = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDataPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cObsCab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindClientes = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ListaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.DescPedido)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.ListaProduto)
        Me.PanelEx1.Controls.Add(Me.DgvItem)
        Me.PanelEx1.Controls.Add(Me.ListaPedido)
        Me.PanelEx1.Controls.Add(Me.ClienteDesc)
        Me.PanelEx1.Controls.Add(Me.btFindClientes)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Cliente)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1075, 565)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'DescPedido
        '
        Me.DescPedido.Location = New System.Drawing.Point(258, 495)
        Me.DescPedido.Name = "DescPedido"
        Me.DescPedido.Size = New System.Drawing.Size(801, 58)
        Me.DescPedido.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(258, 477)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descrição do Pedido"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListaProduto
        '
        Me.ListaProduto.AllowUserToAddRows = False
        Me.ListaProduto.AllowUserToDeleteRows = False
        Me.ListaProduto.AllowUserToResizeColumns = False
        Me.ListaProduto.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListaProduto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaProduto.BackgroundColor = System.Drawing.Color.White
        Me.ListaProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ListaProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ListaProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.ListaProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ListaProduto.EnableHeadersVisualStyles = False
        Me.ListaProduto.Location = New System.Drawing.Point(257, 53)
        Me.ListaProduto.MultiSelect = False
        Me.ListaProduto.Name = "ListaProduto"
        Me.ListaProduto.RowHeadersVisible = False
        Me.ListaProduto.RowHeadersWidth = 15
        Me.ListaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaProduto.Size = New System.Drawing.Size(802, 182)
        Me.ListaProduto.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CodigoProduto"
        Me.Column1.HeaderText = "Produto"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Descrição"
        Me.Column2.HeaderText = "Descrição"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Qtd"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Qtd"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Unitário"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ValorDesconto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Desconto"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "TotalProduto"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.AllowUserToResizeColumns = False
        Me.DgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvItem.BackgroundColor = System.Drawing.Color.White
        Me.DgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gridID, Me.GridCodigoServico, Me.GridServico, Me.GridFuncionario, Me.GridQuantidade, Me.GridValorServico, Me.vlrDesconto, Me.GridTotalServico, Me.GridPedido, Me.cValorISS})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(257, 241)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(802, 233)
        Me.DgvItem.TabIndex = 5
        '
        'gridID
        '
        Me.gridID.DataPropertyName = "id"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0,00"
        Me.gridID.DefaultCellStyle = DataGridViewCellStyle7
        Me.gridID.HeaderText = "ID"
        Me.gridID.Name = "gridID"
        Me.gridID.Visible = False
        '
        'GridCodigoServico
        '
        Me.GridCodigoServico.DataPropertyName = "CodigoServico"
        DataGridViewCellStyle8.Format = "0000"
        Me.GridCodigoServico.DefaultCellStyle = DataGridViewCellStyle8
        Me.GridCodigoServico.FillWeight = 70.0!
        Me.GridCodigoServico.HeaderText = "Cod."
        Me.GridCodigoServico.Name = "GridCodigoServico"
        Me.GridCodigoServico.Width = 60
        '
        'GridServico
        '
        Me.GridServico.DataPropertyName = "Serv_Descricao"
        Me.GridServico.HeaderText = "Serviço"
        Me.GridServico.Name = "GridServico"
        Me.GridServico.Width = 230
        '
        'GridFuncionario
        '
        Me.GridFuncionario.DataPropertyName = "Nome"
        Me.GridFuncionario.FillWeight = 90.0!
        Me.GridFuncionario.HeaderText = "Executado por"
        Me.GridFuncionario.Name = "GridFuncionario"
        Me.GridFuncionario.Width = 150
        '
        'GridQuantidade
        '
        Me.GridQuantidade.DataPropertyName = "Qtd"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.GridQuantidade.DefaultCellStyle = DataGridViewCellStyle9
        Me.GridQuantidade.HeaderText = "Qtde"
        Me.GridQuantidade.Name = "GridQuantidade"
        Me.GridQuantidade.Width = 80
        '
        'GridValorServico
        '
        Me.GridValorServico.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.GridValorServico.DefaultCellStyle = DataGridViewCellStyle10
        Me.GridValorServico.HeaderText = "Valor Serviço"
        Me.GridValorServico.Name = "GridValorServico"
        Me.GridValorServico.Width = 90
        '
        'vlrDesconto
        '
        Me.vlrDesconto.DataPropertyName = "ValorDesconto"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = "0,00"
        Me.vlrDesconto.DefaultCellStyle = DataGridViewCellStyle11
        Me.vlrDesconto.HeaderText = "VlrDesconto"
        Me.vlrDesconto.Name = "vlrDesconto"
        '
        'GridTotalServico
        '
        Me.GridTotalServico.DataPropertyName = "TotalServico"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.GridTotalServico.DefaultCellStyle = DataGridViewCellStyle12
        Me.GridTotalServico.HeaderText = "Total"
        Me.GridTotalServico.Name = "GridTotalServico"
        '
        'GridPedido
        '
        Me.GridPedido.DataPropertyName = "PedidoSequencia"
        Me.GridPedido.HeaderText = "Pedido"
        Me.GridPedido.Name = "GridPedido"
        Me.GridPedido.Visible = False
        '
        'cValorISS
        '
        Me.cValorISS.DataPropertyName = "ValorISSQN"
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.cValorISS.DefaultCellStyle = DataGridViewCellStyle13
        Me.cValorISS.HeaderText = "ValorISS"
        Me.cValorISS.Name = "cValorISS"
        Me.cValorISS.Visible = False
        '
        'ListaPedido
        '
        Me.ListaPedido.AllowUserToAddRows = False
        Me.ListaPedido.AllowUserToDeleteRows = False
        Me.ListaPedido.AllowUserToOrderColumns = True
        Me.ListaPedido.AllowUserToResizeColumns = False
        Me.ListaPedido.AllowUserToResizeRows = False
        Me.ListaPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPedido, Me.cDataPedido, Me.cObsCab})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaPedido.DefaultCellStyle = DataGridViewCellStyle14
        Me.ListaPedido.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ListaPedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaPedido.Location = New System.Drawing.Point(12, 53)
        Me.ListaPedido.MultiSelect = False
        Me.ListaPedido.Name = "ListaPedido"
        Me.ListaPedido.RowHeadersWidth = 20
        Me.ListaPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaPedido.Size = New System.Drawing.Size(240, 500)
        Me.ListaPedido.TabIndex = 4
        '
        'cPedido
        '
        Me.cPedido.DataPropertyName = "PedidoSequencia"
        Me.cPedido.HeaderText = "Pedido"
        Me.cPedido.Name = "cPedido"
        '
        'cDataPedido
        '
        Me.cDataPedido.DataPropertyName = "DataPedido"
        Me.cDataPedido.HeaderText = "Data Pedido"
        Me.cDataPedido.Name = "cDataPedido"
        '
        'cObsCab
        '
        Me.cObsCab.DataPropertyName = "ObsCab"
        Me.cObsCab.HeaderText = "ObsCab"
        Me.cObsCab.Name = "cObsCab"
        Me.cObsCab.Visible = False
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = True
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteDesc.FlatBorder = False
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.FocusColor = System.Drawing.Color.Empty
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(278, 11)
        Me.ClienteDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(696, 23)
        Me.ClienteDesc.TabIndex = 3
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'btFindClientes
        '
        Me.btFindClientes.Image = CType(resources.GetObject("btFindClientes.Image"), System.Drawing.Image)
        Me.btFindClientes.Location = New System.Drawing.Point(254, 13)
        Me.btFindClientes.Name = "btFindClientes"
        Me.btFindClientes.Size = New System.Drawing.Size(18, 21)
        Me.btFindClientes.TabIndex = 2
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(980, 7)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(79, 27)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 0
        Me.btFechar.Text = "Fechar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe o Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(136, 11)
        Me.Cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(116, 23)
        Me.Cliente.TabIndex = 1
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'HistoricoOsPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HistoricoOsPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico de Odem de Serviço - T221"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.ListaProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindClientes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ListaPedido As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents gridID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridCodigoServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridFuncionario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridQuantidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridValorServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vlrDesconto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridTotalServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorISS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaProduto As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescPedido As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDataPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cObsCab As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
