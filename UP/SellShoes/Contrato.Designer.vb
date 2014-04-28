<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contrato))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btExcluir = New DevComponents.DotNetBar.ButtonX()
        Me.ContaBalanceteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindContaLanc = New System.Windows.Forms.Label()
        Me.ContaBalancete = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EFocusPanel1 = New EFocusPanel.EFocusPanel(Me.components)
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.btn_impExtrato = New DevComponents.DotNetBar.ButtonX()
        Me.Recebido = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorLiquido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btLocalizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFinalizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFindCliente = New System.Windows.Forms.Label()
        Me.btEditar = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Finalizado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OBS = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataContrato = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValorContrato = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CodContrato = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btnLancarDespContrato = New DevComponents.DotNetBar.ButtonX()
        Me.txtTotalProdutos = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtTotalDespesas = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSaldo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1.SuspendLayout()
        Me.EFocusPanel1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.txtSaldo)
        Me.PanelEx1.Controls.Add(Me.txtTotalDespesas)
        Me.PanelEx1.Controls.Add(Me.txtTotalProdutos)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.btExcluir)
        Me.PanelEx1.Controls.Add(Me.ContaBalanceteDesc)
        Me.PanelEx1.Controls.Add(Me.btFindContaLanc)
        Me.PanelEx1.Controls.Add(Me.ContaBalancete)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.EFocusPanel1)
        Me.PanelEx1.Controls.Add(Me.btLocalizar)
        Me.PanelEx1.Controls.Add(Me.btFinalizar)
        Me.PanelEx1.Controls.Add(Me.btFindCliente)
        Me.PanelEx1.Controls.Add(Me.btEditar)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.Finalizado)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.OBS)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.DataContrato)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.ValorContrato)
        Me.PanelEx1.Controls.Add(Me.ClienteDesc)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Cliente)
        Me.PanelEx1.Controls.Add(Me.Label13)
        Me.PanelEx1.Controls.Add(Me.CodContrato)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(742, 537)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(72, 255)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(129, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 30
        Me.ButtonX1.Text = "Alterar Valor Contrato"
        '
        'btExcluir
        '
        Me.btExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExcluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExcluir.Location = New System.Drawing.Point(361, 255)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(95, 23)
        Me.btExcluir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btExcluir.TabIndex = 29
        Me.btExcluir.Text = "Excluir Contrato"
        '
        'ContaBalanceteDesc
        '
        Me.ContaBalanceteDesc.AceitaColarTexto = True
        Me.ContaBalanceteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaBalanceteDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContaBalanceteDesc.CasasDecimais = 0
        Me.ContaBalanceteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaBalanceteDesc.CPObrigatorio = False
        Me.ContaBalanceteDesc.CPObrigatorioMsg = Nothing
        Me.ContaBalanceteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaBalanceteDesc.FlatBorder = False
        Me.ContaBalanceteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteDesc.FocusColor = System.Drawing.Color.NavajoWhite
        Me.ContaBalanceteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaBalanceteDesc.HighlightBorderOnEnter = False
        Me.ContaBalanceteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteDesc.Location = New System.Drawing.Point(261, 136)
        Me.ContaBalanceteDesc.Name = "ContaBalanceteDesc"
        Me.ContaBalanceteDesc.PreencherZeroEsqueda = False
        Me.ContaBalanceteDesc.RegraValidação = Nothing
        Me.ContaBalanceteDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaBalanceteDesc.Size = New System.Drawing.Size(470, 23)
        Me.ContaBalanceteDesc.TabIndex = 13
        Me.ContaBalanceteDesc.TabStop = False
        Me.ContaBalanceteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaBalanceteDesc.ValorPadrao = Nothing
        '
        'btFindContaLanc
        '
        Me.btFindContaLanc.Image = CType(resources.GetObject("btFindContaLanc.Image"), System.Drawing.Image)
        Me.btFindContaLanc.Location = New System.Drawing.Point(238, 137)
        Me.btFindContaLanc.Name = "btFindContaLanc"
        Me.btFindContaLanc.Size = New System.Drawing.Size(23, 23)
        Me.btFindContaLanc.TabIndex = 12
        '
        'ContaBalancete
        '
        Me.ContaBalancete.AceitaColarTexto = True
        Me.ContaBalancete.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaBalancete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContaBalancete.CasasDecimais = 0
        Me.ContaBalancete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaBalancete.CPObrigatorio = False
        Me.ContaBalancete.CPObrigatorioMsg = Nothing
        Me.ContaBalancete.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaBalancete.FlatBorder = False
        Me.ContaBalancete.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaBalancete.FocusColor = System.Drawing.Color.NavajoWhite
        Me.ContaBalancete.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaBalancete.HighlightBorderOnEnter = False
        Me.ContaBalancete.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaBalancete.Location = New System.Drawing.Point(162, 135)
        Me.ContaBalancete.MaxLength = 6
        Me.ContaBalancete.Name = "ContaBalancete"
        Me.ContaBalancete.PreencherZeroEsqueda = True
        Me.ContaBalancete.RegraValidação = Nothing
        Me.ContaBalancete.RegraValidaçãoMensagem = Nothing
        Me.ContaBalancete.Size = New System.Drawing.Size(76, 23)
        Me.ContaBalancete.TabIndex = 11
        Me.ContaBalancete.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaBalancete.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Conta Lançamento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EFocusPanel1
        '
        Me.EFocusPanel1.Controls.Add(Me.btnLancarDespContrato)
        Me.EFocusPanel1.Controls.Add(Me.ButtonX2)
        Me.EFocusPanel1.Controls.Add(Me.btn_impExtrato)
        Me.EFocusPanel1.Controls.Add(Me.Recebido)
        Me.EFocusPanel1.Controls.Add(Me.Label8)
        Me.EFocusPanel1.Controls.Add(Me.Lista)
        Me.EFocusPanel1.Icon = Nothing
        Me.EFocusPanel1.Image = Nothing
        Me.EFocusPanel1.IsTransparent = False
        Me.EFocusPanel1.LineColor = System.Drawing.SystemColors.Highlight
        Me.EFocusPanel1.Location = New System.Drawing.Point(12, 284)
        Me.EFocusPanel1.Name = "EFocusPanel1"
        Me.EFocusPanel1.Padding = New System.Windows.Forms.Padding(4, 22, 4, 4)
        Me.EFocusPanel1.Size = New System.Drawing.Size(721, 250)
        Me.EFocusPanel1.TabIndex = 28
        Me.EFocusPanel1.Text = "Parcelamentos e Recebimentos"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(439, 207)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(145, 40)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 29
        Me.ButtonX2.Text = "Imprimir Produtos do Contrato"
        '
        'btn_impExtrato
        '
        Me.btn_impExtrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_impExtrato.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_impExtrato.Location = New System.Drawing.Point(590, 206)
        Me.btn_impExtrato.Name = "btn_impExtrato"
        Me.btn_impExtrato.Size = New System.Drawing.Size(122, 39)
        Me.btn_impExtrato.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_impExtrato.TabIndex = 28
        Me.btn_impExtrato.Text = "Imprimir Extrato"
        '
        'Recebido
        '
        Me.Recebido.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recebido.Location = New System.Drawing.Point(163, 207)
        Me.Recebido.Name = "Recebido"
        Me.Recebido.Size = New System.Drawing.Size(137, 19)
        Me.Recebido.TabIndex = 20
        Me.Recebido.Text = "00,00"
        Me.Recebido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Total Recebido do Contrato:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.cValorLiquido, Me.Column4, Me.Column5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle4
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(7, 19)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(707, 185)
        Me.Lista.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Documento"
        Me.Column1.HeaderText = "Documento"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ValorDocumento"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Valor Doc"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'cValorLiquido
        '
        Me.cValorLiquido.DataPropertyName = "ValorLiquido"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cValorLiquido.DefaultCellStyle = DataGridViewCellStyle3
        Me.cValorLiquido.HeaderText = "Vlr Liquido"
        Me.cValorLiquido.Name = "cValorLiquido"
        Me.cValorLiquido.ReadOnly = True
        Me.cValorLiquido.Width = 120
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Vencimento"
        Me.Column4.HeaderText = "Vencimento"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Recebimento"
        Me.Column5.HeaderText = "Recebimento"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btLocalizar
        '
        Me.btLocalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLocalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLocalizar.Location = New System.Drawing.Point(207, 255)
        Me.btLocalizar.Name = "btLocalizar"
        Me.btLocalizar.Size = New System.Drawing.Size(71, 23)
        Me.btLocalizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btLocalizar.TabIndex = 25
        Me.btLocalizar.Text = "Localizar"
        '
        'btFinalizar
        '
        Me.btFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFinalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFinalizar.Location = New System.Drawing.Point(284, 255)
        Me.btFinalizar.Name = "btFinalizar"
        Me.btFinalizar.Size = New System.Drawing.Size(71, 23)
        Me.btFinalizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFinalizar.TabIndex = 24
        Me.btFinalizar.Text = "Finalizar"
        '
        'btFindCliente
        '
        Me.btFindCliente.Image = CType(resources.GetObject("btFindCliente.Image"), System.Drawing.Image)
        Me.btFindCliente.Location = New System.Drawing.Point(239, 48)
        Me.btFindCliente.Name = "btFindCliente"
        Me.btFindCliente.Size = New System.Drawing.Size(20, 22)
        Me.btFindCliente.TabIndex = 4
        '
        'btEditar
        '
        Me.btEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEditar.Enabled = False
        Me.btEditar.Location = New System.Drawing.Point(462, 255)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(64, 23)
        Me.btEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEditar.TabIndex = 23
        Me.btEditar.Text = "Editar"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(532, 255)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(64, 23)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 22
        Me.btSalvar.Text = "Salvar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(602, 255)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(64, 23)
        Me.btNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNovo.TabIndex = 26
        Me.btNovo.Text = "Novo"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(550, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Finalizado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Finalizado
        '
        Me.Finalizado.AceitaColarTexto = True
        Me.Finalizado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Finalizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Finalizado.CasasDecimais = 0
        Me.Finalizado.CPObrigatorio = False
        Me.Finalizado.CPObrigatorioMsg = Nothing
        Me.Finalizado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Finalizado.FlatBorder = False
        Me.Finalizado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Finalizado.FocusColor = System.Drawing.Color.Empty
        Me.Finalizado.FocusColorEnd = System.Drawing.Color.Empty
        Me.Finalizado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finalizado.HighlightBorderOnEnter = False
        Me.Finalizado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Finalizado.Location = New System.Drawing.Point(699, 18)
        Me.Finalizado.MaxLength = 1
        Me.Finalizado.Name = "Finalizado"
        Me.Finalizado.PreencherZeroEsqueda = False
        Me.Finalizado.RegraValidação = Nothing
        Me.Finalizado.RegraValidaçãoMensagem = Nothing
        Me.Finalizado.Size = New System.Drawing.Size(32, 23)
        Me.Finalizado.TabIndex = 21
        Me.Finalizado.TabStop = False
        Me.Finalizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Finalizado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Finalizado.ValorPadrao = Nothing
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(672, 255)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(64, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 27
        Me.btFechar.Text = "Fechar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(13, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Histórico"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OBS
        '
        Me.OBS.AceitaColarTexto = True
        Me.OBS.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.OBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OBS.CasasDecimais = 2
        Me.OBS.CPObrigatorio = False
        Me.OBS.CPObrigatorioMsg = Nothing
        Me.OBS.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OBS.FlatBorder = False
        Me.OBS.FlatBorderColor = System.Drawing.Color.DimGray
        Me.OBS.FocusColor = System.Drawing.Color.Empty
        Me.OBS.FocusColorEnd = System.Drawing.Color.Empty
        Me.OBS.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBS.HighlightBorderOnEnter = False
        Me.OBS.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.OBS.Location = New System.Drawing.Point(162, 164)
        Me.OBS.Multiline = True
        Me.OBS.Name = "OBS"
        Me.OBS.PreencherZeroEsqueda = False
        Me.OBS.RegraValidação = Nothing
        Me.OBS.RegraValidaçãoMensagem = Nothing
        Me.OBS.Size = New System.Drawing.Size(569, 82)
        Me.OBS.TabIndex = 19
        Me.OBS.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.OBS.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Data do Contrato"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataContrato
        '
        Me.DataContrato.AceitaColarTexto = True
        Me.DataContrato.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataContrato.CasasDecimais = 2
        Me.DataContrato.CPObrigatorio = False
        Me.DataContrato.CPObrigatorioMsg = Nothing
        Me.DataContrato.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataContrato.FlatBorder = False
        Me.DataContrato.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataContrato.FocusColor = System.Drawing.Color.Empty
        Me.DataContrato.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataContrato.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataContrato.HighlightBorderOnEnter = False
        Me.DataContrato.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataContrato.Location = New System.Drawing.Point(161, 106)
        Me.DataContrato.MaxLength = 10
        Me.DataContrato.Name = "DataContrato"
        Me.DataContrato.PreencherZeroEsqueda = False
        Me.DataContrato.RegraValidação = Nothing
        Me.DataContrato.RegraValidaçãoMensagem = Nothing
        Me.DataContrato.Size = New System.Drawing.Size(110, 23)
        Me.DataContrato.TabIndex = 9
        Me.DataContrato.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataContrato.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Valor do Contrato"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorContrato
        '
        Me.ValorContrato.AceitaColarTexto = True
        Me.ValorContrato.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorContrato.CasasDecimais = 2
        Me.ValorContrato.CPObrigatorio = False
        Me.ValorContrato.CPObrigatorioMsg = Nothing
        Me.ValorContrato.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorContrato.FlatBorder = False
        Me.ValorContrato.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorContrato.FocusColor = System.Drawing.Color.Empty
        Me.ValorContrato.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorContrato.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorContrato.HighlightBorderOnEnter = False
        Me.ValorContrato.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorContrato.Location = New System.Drawing.Point(161, 77)
        Me.ValorContrato.MaxLength = 15
        Me.ValorContrato.Name = "ValorContrato"
        Me.ValorContrato.PreencherZeroEsqueda = False
        Me.ValorContrato.RegraValidação = Nothing
        Me.ValorContrato.RegraValidaçãoMensagem = Nothing
        Me.ValorContrato.Size = New System.Drawing.Size(110, 23)
        Me.ValorContrato.TabIndex = 7
        Me.ValorContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorContrato.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.ValorContrato.ValorPadrao = Nothing
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = True
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ClienteDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteDesc.FlatBorder = False
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.FocusColor = System.Drawing.Color.Empty
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(261, 47)
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(470, 23)
        Me.ClienteDesc.TabIndex = 5
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cliente.CasasDecimais = 2
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(161, 48)
        Me.Cliente.MaxLength = 10
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(77, 23)
        Me.Cliente.TabIndex = 3
        Me.Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Cliente, "Selecione um cliente")
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(12, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Nº do Contrato"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodContrato
        '
        Me.CodContrato.AceitaColarTexto = True
        Me.CodContrato.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodContrato.CasasDecimais = 2
        Me.CodContrato.CPObrigatorio = False
        Me.CodContrato.CPObrigatorioMsg = Nothing
        Me.CodContrato.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodContrato.FlatBorder = False
        Me.CodContrato.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodContrato.FocusColor = System.Drawing.Color.Empty
        Me.CodContrato.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodContrato.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodContrato.HighlightBorderOnEnter = False
        Me.CodContrato.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodContrato.Location = New System.Drawing.Point(161, 19)
        Me.CodContrato.MaxLength = 6
        Me.CodContrato.Name = "CodContrato"
        Me.CodContrato.PreencherZeroEsqueda = False
        Me.CodContrato.RegraValidação = Nothing
        Me.CodContrato.RegraValidaçãoMensagem = Nothing
        Me.CodContrato.Size = New System.Drawing.Size(77, 23)
        Me.CodContrato.TabIndex = 1
        Me.CodContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CodContrato.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodContrato.ValorPadrao = Nothing
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Dica:"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'btnLancarDespContrato
        '
        Me.btnLancarDespContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLancarDespContrato.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLancarDespContrato.Location = New System.Drawing.Point(288, 206)
        Me.btnLancarDespContrato.Name = "btnLancarDespContrato"
        Me.btnLancarDespContrato.Size = New System.Drawing.Size(145, 40)
        Me.btnLancarDespContrato.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLancarDespContrato.TabIndex = 30
        Me.btnLancarDespContrato.Text = "Lançar Despesas do Contrato"
        '
        'txtTotalProdutos
        '
        Me.txtTotalProdutos.AceitaColarTexto = True
        Me.txtTotalProdutos.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtTotalProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalProdutos.CasasDecimais = 2
        Me.txtTotalProdutos.CPObrigatorio = False
        Me.txtTotalProdutos.CPObrigatorioMsg = Nothing
        Me.txtTotalProdutos.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtTotalProdutos.FlatBorder = False
        Me.txtTotalProdutos.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtTotalProdutos.FocusColor = System.Drawing.Color.Empty
        Me.txtTotalProdutos.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtTotalProdutos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalProdutos.HighlightBorderOnEnter = False
        Me.txtTotalProdutos.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtTotalProdutos.Location = New System.Drawing.Point(380, 76)
        Me.txtTotalProdutos.MaxLength = 15
        Me.txtTotalProdutos.Name = "txtTotalProdutos"
        Me.txtTotalProdutos.PreencherZeroEsqueda = False
        Me.txtTotalProdutos.RegraValidação = Nothing
        Me.txtTotalProdutos.RegraValidaçãoMensagem = Nothing
        Me.txtTotalProdutos.Size = New System.Drawing.Size(110, 23)
        Me.txtTotalProdutos.TabIndex = 31
        Me.txtTotalProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalProdutos.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.txtTotalProdutos.ValorPadrao = Nothing
        '
        'txtTotalDespesas
        '
        Me.txtTotalDespesas.AceitaColarTexto = True
        Me.txtTotalDespesas.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtTotalDespesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDespesas.CasasDecimais = 2
        Me.txtTotalDespesas.CPObrigatorio = False
        Me.txtTotalDespesas.CPObrigatorioMsg = Nothing
        Me.txtTotalDespesas.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtTotalDespesas.FlatBorder = False
        Me.txtTotalDespesas.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtTotalDespesas.FocusColor = System.Drawing.Color.Empty
        Me.txtTotalDespesas.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtTotalDespesas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesas.HighlightBorderOnEnter = False
        Me.txtTotalDespesas.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtTotalDespesas.Location = New System.Drawing.Point(621, 76)
        Me.txtTotalDespesas.MaxLength = 15
        Me.txtTotalDespesas.Name = "txtTotalDespesas"
        Me.txtTotalDespesas.PreencherZeroEsqueda = False
        Me.txtTotalDespesas.RegraValidação = Nothing
        Me.txtTotalDespesas.RegraValidaçãoMensagem = Nothing
        Me.txtTotalDespesas.Size = New System.Drawing.Size(110, 23)
        Me.txtTotalDespesas.TabIndex = 31
        Me.txtTotalDespesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalDespesas.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.txtTotalDespesas.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(276, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vlr dos Produtos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(496, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Vlr das Despesas"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(496, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 19)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Saldo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaldo
        '
        Me.txtSaldo.AceitaColarTexto = True
        Me.txtSaldo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.CasasDecimais = 2
        Me.txtSaldo.CPObrigatorio = False
        Me.txtSaldo.CPObrigatorioMsg = Nothing
        Me.txtSaldo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtSaldo.FlatBorder = False
        Me.txtSaldo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtSaldo.FocusColor = System.Drawing.Color.Empty
        Me.txtSaldo.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtSaldo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.HighlightBorderOnEnter = False
        Me.txtSaldo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtSaldo.Location = New System.Drawing.Point(621, 104)
        Me.txtSaldo.MaxLength = 15
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.PreencherZeroEsqueda = False
        Me.txtSaldo.RegraValidação = Nothing
        Me.txtSaldo.RegraValidaçãoMensagem = Nothing
        Me.txtSaldo.Size = New System.Drawing.Size(110, 23)
        Me.txtSaldo.TabIndex = 31
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.txtSaldo.ValorPadrao = Nothing
        '
        'Contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "Contrato"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrato - T 247"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.EFocusPanel1.ResumeLayout(False)
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OBS As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataContrato As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ValorContrato As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CodContrato As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Finalizado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFindCliente As System.Windows.Forms.Label
    Friend WithEvents btFinalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btLocalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents EFocusPanel1 As EFocusPanel.EFocusPanel
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btFindContaLanc As System.Windows.Forms.Label
    Friend WithEvents ContaBalanceteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaBalancete As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btExcluir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Recebido As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorLiquido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_impExtrato As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLancarDespContrato As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtSaldo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtTotalDespesas As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtTotalProdutos As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
