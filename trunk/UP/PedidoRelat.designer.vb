<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoRelat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoRelat))
        Me.PainelCliente = New System.Windows.Forms.Panel()
        Me.btFindClientes = New System.Windows.Forms.Label()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A5 = New System.Windows.Forms.RadioButton()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A7 = New System.Windows.Forms.RadioButton()
        Me.A6 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.PainelVendedor = New System.Windows.Forms.Panel()
        Me.btFindVendedor = New System.Windows.Forms.Label()
        Me.Vendedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.VendedorDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.PanelFiltros = New System.Windows.Forms.Panel()
        Me.cboFiltros = New CBOAutoCompleteFocus.CboFocus()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Visualizar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A13 = New System.Windows.Forms.RadioButton()
        Me.A12 = New System.Windows.Forms.RadioButton()
        Me.A11 = New System.Windows.Forms.RadioButton()
        Me.A8 = New System.Windows.Forms.RadioButton()
        Me.A10 = New System.Windows.Forms.RadioButton()
        Me.A9 = New System.Windows.Forms.RadioButton()
        Me.PainelCidade = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cidade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelCliente.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        Me.PainelVendedor.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PainelCidade.SuspendLayout()
        Me.SuspendLayout()
        '
        'PainelCliente
        '
        Me.PainelCliente.Controls.Add(Me.btFindClientes)
        Me.PainelCliente.Controls.Add(Me.ClienteDesc)
        Me.PainelCliente.Controls.Add(Me.Label1)
        Me.PainelCliente.Controls.Add(Me.Cliente)
        Me.PainelCliente.Location = New System.Drawing.Point(3, 276)
        Me.PainelCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PainelCliente.Name = "PainelCliente"
        Me.PainelCliente.Size = New System.Drawing.Size(558, 55)
        Me.PainelCliente.TabIndex = 2
        Me.PainelCliente.Visible = False
        '
        'btFindClientes
        '
        Me.btFindClientes.Image = CType(resources.GetObject("btFindClientes.Image"), System.Drawing.Image)
        Me.btFindClientes.Location = New System.Drawing.Point(250, 4)
        Me.btFindClientes.Name = "btFindClientes"
        Me.btFindClientes.Size = New System.Drawing.Size(18, 21)
        Me.btFindClientes.TabIndex = 2
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
        Me.ClienteDesc.Location = New System.Drawing.Point(132, 29)
        Me.ClienteDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(422, 23)
        Me.ClienteDesc.TabIndex = 3
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 2)
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
        Me.Cliente.Location = New System.Drawing.Point(132, 2)
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
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label9)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(3, 208)
        Me.PainelPeriodo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(383, 30)
        Me.PainelPeriodo.TabIndex = 1
        Me.PainelPeriodo.Visible = False
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
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
        Me.DataFinal.Location = New System.Drawing.Point(255, 2)
        Me.DataFinal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(116, 23)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(5, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Informe o Período"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 0
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
        Me.DataInicial.Location = New System.Drawing.Point(132, 2)
        Me.DataInicial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(116, 23)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Enabled = False
        Me.A5.Location = New System.Drawing.Point(311, 28)
        Me.A5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(139, 19)
        Me.A5.TabIndex = 5
        Me.A5.TabStop = True
        Me.A5.Text = "Pedido Fat. por Cidade"
        Me.A5.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Enabled = False
        Me.A4.Location = New System.Drawing.Point(311, 2)
        Me.A4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(190, 19)
        Me.A4.TabIndex = 4
        Me.A4.TabStop = True
        Me.A4.Text = "Pedido Fat. por Cidade e Periodo"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(3, 51)
        Me.A3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(188, 19)
        Me.A3.TabIndex = 1
        Me.A3.TabStop = True
        Me.A3.Text = "Pedidos Faturados por Vendedor"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(3, 28)
        Me.A2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(176, 19)
        Me.A2.TabIndex = 2
        Me.A2.TabStop = True
        Me.A2.Text = "Pedidos Faturados por Cliente"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A7
        '
        Me.A7.AutoSize = True
        Me.A7.Enabled = False
        Me.A7.Location = New System.Drawing.Point(311, 74)
        Me.A7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A7.Name = "A7"
        Me.A7.Size = New System.Drawing.Size(151, 19)
        Me.A7.TabIndex = 7
        Me.A7.TabStop = True
        Me.A7.Text = "Vendas Internas Abertas"
        Me.A7.UseVisualStyleBackColor = True
        '
        'A6
        '
        Me.A6.AutoSize = True
        Me.A6.Enabled = False
        Me.A6.Location = New System.Drawing.Point(311, 51)
        Me.A6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A6.Name = "A6"
        Me.A6.Size = New System.Drawing.Size(159, 19)
        Me.A6.TabIndex = 6
        Me.A6.TabStop = True
        Me.A6.Text = "Vendas Internas Faturado "
        Me.A6.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Checked = True
        Me.A1.Location = New System.Drawing.Point(3, 2)
        Me.A1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(117, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Pedidos Faturados"
        Me.A1.UseVisualStyleBackColor = True
        '
        'PainelVendedor
        '
        Me.PainelVendedor.Controls.Add(Me.btFindVendedor)
        Me.PainelVendedor.Controls.Add(Me.Vendedor)
        Me.PainelVendedor.Controls.Add(Me.VendedorDesc)
        Me.PainelVendedor.Controls.Add(Me.Label2)
        Me.PainelVendedor.Location = New System.Drawing.Point(3, 334)
        Me.PainelVendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PainelVendedor.Name = "PainelVendedor"
        Me.PainelVendedor.Size = New System.Drawing.Size(558, 57)
        Me.PainelVendedor.TabIndex = 3
        Me.PainelVendedor.Visible = False
        '
        'btFindVendedor
        '
        Me.btFindVendedor.Image = CType(resources.GetObject("btFindVendedor.Image"), System.Drawing.Image)
        Me.btFindVendedor.Location = New System.Drawing.Point(250, 3)
        Me.btFindVendedor.Name = "btFindVendedor"
        Me.btFindVendedor.Size = New System.Drawing.Size(18, 21)
        Me.btFindVendedor.TabIndex = 2
        '
        'Vendedor
        '
        Me.Vendedor.AceitaColarTexto = True
        Me.Vendedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vendedor.CasasDecimais = 0
        Me.Vendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vendedor.CPObrigatorio = False
        Me.Vendedor.CPObrigatorioMsg = Nothing
        Me.Vendedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vendedor.FlatBorder = False
        Me.Vendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vendedor.FocusColor = System.Drawing.Color.Empty
        Me.Vendedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vendedor.HighlightBorderOnEnter = False
        Me.Vendedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vendedor.Location = New System.Drawing.Point(132, 2)
        Me.Vendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.PreencherZeroEsqueda = False
        Me.Vendedor.RegraValidação = Nothing
        Me.Vendedor.RegraValidaçãoMensagem = Nothing
        Me.Vendedor.Size = New System.Drawing.Size(116, 23)
        Me.Vendedor.TabIndex = 1
        Me.Vendedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Vendedor.ValorPadrao = Nothing
        '
        'VendedorDesc
        '
        Me.VendedorDesc.AceitaColarTexto = True
        Me.VendedorDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.VendedorDesc.CasasDecimais = 0
        Me.VendedorDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VendedorDesc.CPObrigatorio = False
        Me.VendedorDesc.CPObrigatorioMsg = Nothing
        Me.VendedorDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VendedorDesc.FlatBorder = False
        Me.VendedorDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.VendedorDesc.FocusColor = System.Drawing.Color.Empty
        Me.VendedorDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.VendedorDesc.HighlightBorderOnEnter = False
        Me.VendedorDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.VendedorDesc.Location = New System.Drawing.Point(132, 28)
        Me.VendedorDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VendedorDesc.Name = "VendedorDesc"
        Me.VendedorDesc.PreencherZeroEsqueda = False
        Me.VendedorDesc.RegraValidação = Nothing
        Me.VendedorDesc.RegraValidaçãoMensagem = Nothing
        Me.VendedorDesc.Size = New System.Drawing.Size(422, 23)
        Me.VendedorDesc.TabIndex = 3
        Me.VendedorDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.VendedorDesc.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Informe o Vendedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.PanelFiltros)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Visualizar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.PainelCidade)
        Me.Fundo.Controls.Add(Me.PainelVendedor)
        Me.Fundo.Controls.Add(Me.PainelPeriodo)
        Me.Fundo.Controls.Add(Me.PainelCliente)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(567, 480)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'PanelFiltros
        '
        Me.PanelFiltros.Controls.Add(Me.cboFiltros)
        Me.PanelFiltros.Controls.Add(Me.Label4)
        Me.PanelFiltros.Location = New System.Drawing.Point(3, 242)
        Me.PanelFiltros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelFiltros.Name = "PanelFiltros"
        Me.PanelFiltros.Size = New System.Drawing.Size(383, 30)
        Me.PanelFiltros.TabIndex = 8
        Me.PanelFiltros.Visible = False
        '
        'cboFiltros
        '
        Me.cboFiltros.Auto_Complete = True
        Me.cboFiltros.AutoLimitar_Lista = True
        Me.cboFiltros.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cboFiltros.CPObrigatorio = False
        Me.cboFiltros.CPObrigatorioMsg = Nothing
        Me.cboFiltros.FlatBorder = False
        Me.cboFiltros.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cboFiltros.FormattingEnabled = True
        Me.cboFiltros.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cboFiltros.HighlightBorderOnEnter = False
        Me.cboFiltros.Items.AddRange(New Object() {"Todos", "Varejo", "Atacado"})
        Me.cboFiltros.Location = New System.Drawing.Point(132, 3)
        Me.cboFiltros.Name = "cboFiltros"
        Me.cboFiltros.Size = New System.Drawing.Size(239, 23)
        Me.cboFiltros.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Filtros"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(473, 428)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(90, 31)
        Me.Fechar.TabIndex = 6
        Me.Fechar.Text = "Fechar"
        '
        'Visualizar
        '
        Me.Visualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Visualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Visualizar.Location = New System.Drawing.Point(349, 428)
        Me.Visualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Visualizar.Name = "Visualizar"
        Me.Visualizar.Size = New System.Drawing.Size(118, 32)
        Me.Visualizar.TabIndex = 5
        Me.Visualizar.Text = "Visualizar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A13)
        Me.GroupPanel1.Controls.Add(Me.A12)
        Me.GroupPanel1.Controls.Add(Me.A11)
        Me.GroupPanel1.Controls.Add(Me.A8)
        Me.GroupPanel1.Controls.Add(Me.A5)
        Me.GroupPanel1.Controls.Add(Me.A10)
        Me.GroupPanel1.Controls.Add(Me.A9)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A7)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A6)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 12)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(559, 192)
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
        Me.GroupPanel1.Text = "Selecione a Opção"
        '
        'A13
        '
        Me.A13.AutoSize = True
        Me.A13.Location = New System.Drawing.Point(3, 143)
        Me.A13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A13.Name = "A13"
        Me.A13.Size = New System.Drawing.Size(157, 19)
        Me.A13.TabIndex = 10
        Me.A13.TabStop = True
        Me.A13.Text = "Pedidos [Margem e Lucro]"
        Me.A13.UseVisualStyleBackColor = True
        '
        'A12
        '
        Me.A12.AutoSize = True
        Me.A12.Location = New System.Drawing.Point(311, 120)
        Me.A12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A12.Name = "A12"
        Me.A12.Size = New System.Drawing.Size(238, 19)
        Me.A12.TabIndex = 10
        Me.A12.TabStop = True
        Me.A12.Text = "Análise de Vendas Diário dos Vendedores "
        Me.A12.UseVisualStyleBackColor = True
        '
        'A11
        '
        Me.A11.AutoSize = True
        Me.A11.Location = New System.Drawing.Point(3, 120)
        Me.A11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A11.Name = "A11"
        Me.A11.Size = New System.Drawing.Size(170, 19)
        Me.A11.TabIndex = 8
        Me.A11.TabStop = True
        Me.A11.Text = "Pedidos por Vendedor e Tipo"
        Me.A11.UseVisualStyleBackColor = True
        '
        'A8
        '
        Me.A8.AutoSize = True
        Me.A8.Location = New System.Drawing.Point(3, 74)
        Me.A8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A8.Name = "A8"
        Me.A8.Size = New System.Drawing.Size(206, 19)
        Me.A8.TabIndex = 3
        Me.A8.TabStop = True
        Me.A8.Text = "Pedidos (Ordem Entrega Pendentes)"
        Me.A8.UseVisualStyleBackColor = True
        '
        'A10
        '
        Me.A10.AutoSize = True
        Me.A10.Location = New System.Drawing.Point(311, 97)
        Me.A10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A10.Name = "A10"
        Me.A10.Size = New System.Drawing.Size(189, 19)
        Me.A10.TabIndex = 0
        Me.A10.TabStop = True
        Me.A10.Text = "Análise Grafico dos Vendedores"
        Me.A10.UseVisualStyleBackColor = True
        '
        'A9
        '
        Me.A9.AutoSize = True
        Me.A9.Location = New System.Drawing.Point(3, 97)
        Me.A9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A9.Name = "A9"
        Me.A9.Size = New System.Drawing.Size(203, 19)
        Me.A9.TabIndex = 0
        Me.A9.TabStop = True
        Me.A9.Text = "Pedidos Faturados Por Tipo de Pgto"
        Me.A9.UseVisualStyleBackColor = True
        '
        'PainelCidade
        '
        Me.PainelCidade.Controls.Add(Me.Label3)
        Me.PainelCidade.Controls.Add(Me.Cidade)
        Me.PainelCidade.Location = New System.Drawing.Point(3, 395)
        Me.PainelCidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PainelCidade.Name = "PainelCidade"
        Me.PainelCidade.Size = New System.Drawing.Size(559, 29)
        Me.PainelCidade.TabIndex = 4
        Me.PainelCidade.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Inf. a Cidade"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cidade
        '
        Me.Cidade.AceitaColarTexto = True
        Me.Cidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cidade.CasasDecimais = 0
        Me.Cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cidade.CPObrigatorio = False
        Me.Cidade.CPObrigatorioMsg = Nothing
        Me.Cidade.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cidade.FlatBorder = False
        Me.Cidade.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cidade.FocusColor = System.Drawing.Color.Empty
        Me.Cidade.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cidade.HighlightBorderOnEnter = False
        Me.Cidade.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cidade.Location = New System.Drawing.Point(132, 2)
        Me.Cidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cidade.MaxLength = 30
        Me.Cidade.Name = "Cidade"
        Me.Cidade.PreencherZeroEsqueda = False
        Me.Cidade.RegraValidação = Nothing
        Me.Cidade.RegraValidaçãoMensagem = Nothing
        Me.Cidade.Size = New System.Drawing.Size(422, 23)
        Me.Cidade.TabIndex = 1
        Me.Cidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cidade.ValorPadrao = Nothing
        '
        'PedidoRelat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(567, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "PedidoRelat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios de Pedido - T175"
        Me.PainelCliente.ResumeLayout(False)
        Me.PainelCliente.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.PainelVendedor.ResumeLayout(False)
        Me.PainelVendedor.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.PanelFiltros.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.PainelCidade.ResumeLayout(False)
        Me.PainelCidade.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PainelCliente As System.Windows.Forms.Panel
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelVendedor As System.Windows.Forms.Panel
    Friend WithEvents VendedorDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Vendedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelCidade As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A7 As System.Windows.Forms.RadioButton
    Friend WithEvents A6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Visualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents A8 As System.Windows.Forms.RadioButton
    Friend WithEvents btFindClientes As System.Windows.Forms.Label
    Friend WithEvents btFindVendedor As System.Windows.Forms.Label
    Friend WithEvents PanelFiltros As System.Windows.Forms.Panel
    Friend WithEvents cboFiltros As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents A9 As System.Windows.Forms.RadioButton
    Friend WithEvents A10 As System.Windows.Forms.RadioButton
    Friend WithEvents A11 As System.Windows.Forms.RadioButton
    Friend WithEvents A12 As System.Windows.Forms.RadioButton
    Friend WithEvents A13 As System.Windows.Forms.RadioButton
End Class
