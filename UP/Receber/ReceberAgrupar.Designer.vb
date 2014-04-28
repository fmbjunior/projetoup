<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceberAgrupar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceberAgrupar))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Inativo = New System.Windows.Forms.CheckBox()
        Me.btDesfazer = New DevComponents.DotNetBar.ButtonX()
        Me.btLocalizarAgrupamento = New DevComponents.DotNetBar.ButtonX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btEditar = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvarReceber = New DevComponents.DotNetBar.ButtonX()
        Me.TotParcelado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListaReceber = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimento = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.LocalPgto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Confirmado = New System.Windows.Forms.CheckBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.DiasParcelamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPedidoProdutos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selecao = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btFindClintes = New System.Windows.Forms.Label()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ValorAgrupado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IdAgrupar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ListaReceber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Inativo)
        Me.PanelEx1.Controls.Add(Me.btDesfazer)
        Me.PanelEx1.Controls.Add(Me.btLocalizarAgrupamento)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.btEditar)
        Me.PanelEx1.Controls.Add(Me.btSalvarReceber)
        Me.PanelEx1.Controls.Add(Me.TotParcelado)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.ListaReceber)
        Me.PanelEx1.Controls.Add(Me.Confirmado)
        Me.PanelEx1.Controls.Add(Me.Label42)
        Me.PanelEx1.Controls.Add(Me.DiasParcelamento)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.DataLancamento)
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Controls.Add(Me.btFindClintes)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.ClienteDesc)
        Me.PanelEx1.Controls.Add(Me.Cliente)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.ValorAgrupado)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Descricao)
        Me.PanelEx1.Controls.Add(Me.IdAgrupar)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(882, 525)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Inativo
        '
        Me.Inativo.AutoSize = True
        Me.Inativo.Location = New System.Drawing.Point(677, 85)
        Me.Inativo.Name = "Inativo"
        Me.Inativo.Size = New System.Drawing.Size(64, 19)
        Me.Inativo.TabIndex = 30
        Me.Inativo.Text = "Inativo"
        Me.Inativo.UseVisualStyleBackColor = True
        Me.Inativo.Visible = False
        '
        'btDesfazer
        '
        Me.btDesfazer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btDesfazer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btDesfazer.Location = New System.Drawing.Point(356, 494)
        Me.btDesfazer.Name = "btDesfazer"
        Me.btDesfazer.Size = New System.Drawing.Size(134, 26)
        Me.btDesfazer.TabIndex = 29
        Me.btDesfazer.Text = "Desfazer Agrupamento"
        '
        'btLocalizarAgrupamento
        '
        Me.btLocalizarAgrupamento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLocalizarAgrupamento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLocalizarAgrupamento.Location = New System.Drawing.Point(496, 494)
        Me.btLocalizarAgrupamento.Name = "btLocalizarAgrupamento"
        Me.btLocalizarAgrupamento.Size = New System.Drawing.Size(134, 26)
        Me.btLocalizarAgrupamento.TabIndex = 28
        Me.btLocalizarAgrupamento.Text = "Localizar Agrupamento"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(427, 36)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "1 - Caso necessário excluir o parcelamento selecione o parcelamento e de um click" & _
    " com o botaão direito do mouse e após excluir selecione o botão (Editar)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 460)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(427, 33)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "2 - Caso necessário alterar data, Local ou valor após a alteração selecione o bot" & _
    "ão (Salvar Receber)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btEditar
        '
        Me.btEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEditar.Location = New System.Drawing.Point(636, 494)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(75, 26)
        Me.btEditar.TabIndex = 24
        Me.btEditar.Text = "Editar"
        '
        'btSalvarReceber
        '
        Me.btSalvarReceber.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvarReceber.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvarReceber.Location = New System.Drawing.Point(775, 394)
        Me.btSalvarReceber.Name = "btSalvarReceber"
        Me.btSalvarReceber.Size = New System.Drawing.Size(97, 26)
        Me.btSalvarReceber.TabIndex = 23
        Me.btSalvarReceber.Text = "Salvar Receber"
        Me.btSalvarReceber.Visible = False
        '
        'TotParcelado
        '
        Me.TotParcelado.BackColor = System.Drawing.Color.Transparent
        Me.TotParcelado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotParcelado.Location = New System.Drawing.Point(539, 402)
        Me.TotParcelado.Name = "TotParcelado"
        Me.TotParcelado.Size = New System.Drawing.Size(108, 19)
        Me.TotParcelado.TabIndex = 21
        Me.TotParcelado.Text = "00,00"
        Me.TotParcelado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total Parcelado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListaReceber
        '
        Me.ListaReceber.AllowUserToAddRows = False
        Me.ListaReceber.AllowUserToDeleteRows = False
        Me.ListaReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaReceber.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Documento, Me.ValorDocumento, Me.Vencimento, Me.LocalPgto, Me.CodCliente})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaReceber.DefaultCellStyle = DataGridViewCellStyle2
        Me.ListaReceber.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaReceber.Location = New System.Drawing.Point(445, 210)
        Me.ListaReceber.Name = "ListaReceber"
        Me.ListaReceber.RowHeadersWidth = 20
        Me.ListaReceber.Size = New System.Drawing.Size(427, 179)
        Me.ListaReceber.TabIndex = 17
        '
        'Id
        '
        Me.Id.DataPropertyName = "ID"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Documento
        '
        Me.Documento.DataPropertyName = "Documento"
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        '
        'ValorDocumento
        '
        Me.ValorDocumento.DataPropertyName = "ValorDocumento"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ValorDocumento.DefaultCellStyle = DataGridViewCellStyle1
        Me.ValorDocumento.HeaderText = "Valor"
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.Width = 80
        '
        'Vencimento
        '
        Me.Vencimento.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Vencimento.BackgroundStyle.Class = "DataGridViewBorder"
        Me.Vencimento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Vencimento.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.Vencimento.DataPropertyName = "Vencimento"
        Me.Vencimento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Vencimento.HeaderText = "Vencimento"
        Me.Vencimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Vencimento.Mask = "00/00/0000"
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Vencimento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Vencimento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Vencimento.Text = "  /  /"
        Me.Vencimento.Width = 80
        '
        'LocalPgto
        '
        Me.LocalPgto.DataPropertyName = "LocalPgto"
        Me.LocalPgto.FillWeight = 120.0!
        Me.LocalPgto.HeaderText = "Local"
        Me.LocalPgto.Items.AddRange(New Object() {"CARTEIRA", "BANCO"})
        Me.LocalPgto.Name = "LocalPgto"
        Me.LocalPgto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LocalPgto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.LocalPgto.Width = 120
        '
        'CodCliente
        '
        Me.CodCliente.DataPropertyName = "CodCliente"
        Me.CodCliente.HeaderText = "CodCliente"
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.Visible = False
        '
        'Confirmado
        '
        Me.Confirmado.AutoSize = True
        Me.Confirmado.Location = New System.Drawing.Point(585, 85)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(86, 19)
        Me.Confirmado.TabIndex = 10
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.UseVisualStyleBackColor = True
        Me.Confirmado.Visible = False
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(448, 159)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(95, 19)
        Me.Label42.TabIndex = 13
        Me.Label42.Text = "Parcelamento"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiasParcelamento
        '
        Me.DiasParcelamento.AceitaColarTexto = True
        Me.DiasParcelamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DiasParcelamento.CasasDecimais = 0
        Me.DiasParcelamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiasParcelamento.CPObrigatorio = False
        Me.DiasParcelamento.CPObrigatorioMsg = Nothing
        Me.DiasParcelamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiasParcelamento.FlatBorder = False
        Me.DiasParcelamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DiasParcelamento.FocusColor = System.Drawing.Color.MistyRose
        Me.DiasParcelamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiasParcelamento.HighlightBorderOnEnter = False
        Me.DiasParcelamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DiasParcelamento.Location = New System.Drawing.Point(448, 181)
        Me.DiasParcelamento.MaxLength = 75
        Me.DiasParcelamento.Name = "DiasParcelamento"
        Me.DiasParcelamento.PreencherZeroEsqueda = False
        Me.DiasParcelamento.RegraValidação = Nothing
        Me.DiasParcelamento.RegraValidaçãoMensagem = Nothing
        Me.DiasParcelamento.Size = New System.Drawing.Size(374, 23)
        Me.DiasParcelamento.TabIndex = 14
        Me.DiasParcelamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Parcelamento
        Me.DiasParcelamento.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(445, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data de Lançamento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = True
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FlatBorder = False
        Me.DataLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.HighlightBorderOnEnter = False
        Me.DataLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataLancamento.Location = New System.Drawing.Point(448, 85)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.PreencherZeroEsqueda = False
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(116, 23)
        Me.DataLancamento.TabIndex = 9
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cID, Me.cDocumento, Me.cPedidoProdutos, Me.cValorDocumento, Me.Selecao})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle4
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(12, 63)
        Me.Lista.Name = "Lista"
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.Size = New System.Drawing.Size(427, 358)
        Me.Lista.TabIndex = 16
        '
        'cID
        '
        Me.cID.DataPropertyName = "ID"
        Me.cID.HeaderText = "ID"
        Me.cID.Name = "cID"
        Me.cID.ReadOnly = True
        Me.cID.Width = 60
        '
        'cDocumento
        '
        Me.cDocumento.DataPropertyName = "Documento"
        Me.cDocumento.HeaderText = "Documento"
        Me.cDocumento.Name = "cDocumento"
        Me.cDocumento.ReadOnly = True
        Me.cDocumento.Width = 90
        '
        'cPedidoProdutos
        '
        Me.cPedidoProdutos.DataPropertyName = "PedidoProdutos"
        Me.cPedidoProdutos.HeaderText = "Pedido"
        Me.cPedidoProdutos.Name = "cPedidoProdutos"
        Me.cPedidoProdutos.ReadOnly = True
        Me.cPedidoProdutos.Width = 80
        '
        'cValorDocumento
        '
        Me.cValorDocumento.DataPropertyName = "ValorDocumento"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cValorDocumento.DefaultCellStyle = DataGridViewCellStyle3
        Me.cValorDocumento.HeaderText = "Valor Doc"
        Me.cValorDocumento.Name = "cValorDocumento"
        Me.cValorDocumento.ReadOnly = True
        Me.cValorDocumento.Width = 80
        '
        'Selecao
        '
        Me.Selecao.HeaderText = "Select"
        Me.Selecao.Name = "Selecao"
        Me.Selecao.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Selecao.Width = 60
        '
        'btFindClintes
        '
        Me.btFindClintes.Image = CType(resources.GetObject("btFindClintes.Image"), System.Drawing.Image)
        Me.btFindClintes.Location = New System.Drawing.Point(68, 34)
        Me.btFindClintes.Name = "btFindClintes"
        Me.btFindClintes.Size = New System.Drawing.Size(20, 21)
        Me.btFindClintes.TabIndex = 2
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(828, 181)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(44, 23)
        Me.btSalvar.TabIndex = 15
        Me.btSalvar.Text = "Gerar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(717, 494)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(75, 26)
        Me.btNovo.TabIndex = 18
        Me.btNovo.Text = "Novo"
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
        Me.ClienteDesc.Location = New System.Drawing.Point(94, 34)
        Me.ClienteDesc.MaxLength = 100
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(345, 23)
        Me.ClienteDesc.TabIndex = 3
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
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
        Me.Cliente.Location = New System.Drawing.Point(12, 34)
        Me.Cliente.MaxLength = 15
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(55, 23)
        Me.Cliente.TabIndex = 1
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cliente"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorAgrupado
        '
        Me.ValorAgrupado.AceitaColarTexto = True
        Me.ValorAgrupado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorAgrupado.CasasDecimais = 2
        Me.ValorAgrupado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorAgrupado.CPObrigatorio = False
        Me.ValorAgrupado.CPObrigatorioMsg = Nothing
        Me.ValorAgrupado.Enabled = False
        Me.ValorAgrupado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorAgrupado.FlatBorder = False
        Me.ValorAgrupado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorAgrupado.FocusColor = System.Drawing.Color.Empty
        Me.ValorAgrupado.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorAgrupado.HighlightBorderOnEnter = False
        Me.ValorAgrupado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorAgrupado.Location = New System.Drawing.Point(707, 34)
        Me.ValorAgrupado.MaxLength = 15
        Me.ValorAgrupado.Name = "ValorAgrupado"
        Me.ValorAgrupado.PreencherZeroEsqueda = False
        Me.ValorAgrupado.RegraValidação = Nothing
        Me.ValorAgrupado.RegraValidaçãoMensagem = Nothing
        Me.ValorAgrupado.Size = New System.Drawing.Size(163, 23)
        Me.ValorAgrupado.TabIndex = 7
        Me.ValorAgrupado.TabStop = False
        Me.ValorAgrupado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.ValorAgrupado.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(704, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Valor Agrupado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(448, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Descrição"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Descricao
        '
        Me.Descricao.AceitaColarTexto = True
        Me.Descricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Descricao.CasasDecimais = 0
        Me.Descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descricao.CPObrigatorio = False
        Me.Descricao.CPObrigatorioMsg = Nothing
        Me.Descricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Descricao.FlatBorder = False
        Me.Descricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Descricao.FocusColor = System.Drawing.Color.Empty
        Me.Descricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descricao.HighlightBorderOnEnter = False
        Me.Descricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Descricao.Location = New System.Drawing.Point(448, 133)
        Me.Descricao.MaxLength = 100
        Me.Descricao.Name = "Descricao"
        Me.Descricao.PreencherZeroEsqueda = False
        Me.Descricao.RegraValidação = Nothing
        Me.Descricao.RegraValidaçãoMensagem = Nothing
        Me.Descricao.Size = New System.Drawing.Size(422, 23)
        Me.Descricao.TabIndex = 12
        Me.Descricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descricao.ValorPadrao = Nothing
        '
        'IdAgrupar
        '
        Me.IdAgrupar.AceitaColarTexto = True
        Me.IdAgrupar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IdAgrupar.CasasDecimais = 0
        Me.IdAgrupar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdAgrupar.CPObrigatorio = False
        Me.IdAgrupar.CPObrigatorioMsg = Nothing
        Me.IdAgrupar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdAgrupar.FlatBorder = False
        Me.IdAgrupar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdAgrupar.FocusColor = System.Drawing.Color.Empty
        Me.IdAgrupar.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdAgrupar.HighlightBorderOnEnter = False
        Me.IdAgrupar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdAgrupar.Location = New System.Drawing.Point(448, 34)
        Me.IdAgrupar.MaxLength = 15
        Me.IdAgrupar.Name = "IdAgrupar"
        Me.IdAgrupar.PreencherZeroEsqueda = False
        Me.IdAgrupar.RegraValidação = Nothing
        Me.IdAgrupar.RegraValidaçãoMensagem = Nothing
        Me.IdAgrupar.Size = New System.Drawing.Size(69, 23)
        Me.IdAgrupar.TabIndex = 6
        Me.IdAgrupar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.IdAgrupar.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(445, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(798, 494)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 26)
        Me.btFechar.TabIndex = 19
        Me.btFechar.Text = "Fechar"
        '
        'ReceberAgrupar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReceberAgrupar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agrupamento de Contas a Receber - T279"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.ListaReceber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents IdAgrupar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ValorAgrupado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Descricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btFindClintes As System.Windows.Forms.Label
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPedidoProdutos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Selecao As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents DiasParcelamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ListaReceber As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Confirmado As System.Windows.Forms.CheckBox
    Friend WithEvents TotParcelado As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btSalvarReceber As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btLocalizarAgrupamento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btDesfazer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Inativo As System.Windows.Forms.CheckBox
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vencimento As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents LocalPgto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CodCliente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
