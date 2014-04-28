<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagarEditParcelas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btMudarParcela = New DevComponents.DotNetBar.ButtonX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.VencimentoOriginal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Parcelado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IdLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ListaPagar = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cVenc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cLocalPagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cVencimentoOriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tParcelado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLocalPgto = New CBOAutoCompleteFocus.CboFocus()
        Me.btFecharTela = New DevComponents.DotNetBar.ButtonX()
        Me.txtValor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtVencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        CType(Me.ListaPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btMudarParcela)
        Me.Fundo.Controls.Add(Me.Label14)
        Me.Fundo.Controls.Add(Me.VencimentoOriginal)
        Me.Fundo.Controls.Add(Me.Parcelado)
        Me.Fundo.Controls.Add(Me.IdLancamento)
        Me.Fundo.Controls.Add(Me.ListaPagar)
        Me.Fundo.Controls.Add(Me.tParcelado)
        Me.Fundo.Controls.Add(Me.Label18)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.txtLocalPgto)
        Me.Fundo.Controls.Add(Me.btFecharTela)
        Me.Fundo.Controls.Add(Me.txtValor)
        Me.Fundo.Controls.Add(Me.Label17)
        Me.Fundo.Controls.Add(Me.txtVencimento)
        Me.Fundo.Controls.Add(Me.Label16)
        Me.Fundo.Controls.Add(Me.txtDocumento)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label15)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(899, 276)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 18
        '
        'btMudarParcela
        '
        Me.btMudarParcela.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btMudarParcela.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btMudarParcela.Location = New System.Drawing.Point(750, 141)
        Me.btMudarParcela.Name = "btMudarParcela"
        Me.btMudarParcela.Size = New System.Drawing.Size(139, 31)
        Me.btMudarParcela.TabIndex = 50
        Me.btMudarParcela.Text = "Alterar Parcela"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(268, 244)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 21)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Total Parcelado"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VencimentoOriginal
        '
        Me.VencimentoOriginal.AceitaColarTexto = True
        Me.VencimentoOriginal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.VencimentoOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VencimentoOriginal.CasasDecimais = 0
        Me.VencimentoOriginal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VencimentoOriginal.CPObrigatorio = False
        Me.VencimentoOriginal.CPObrigatorioMsg = Nothing
        Me.VencimentoOriginal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VencimentoOriginal.FlatBorder = False
        Me.VencimentoOriginal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.VencimentoOriginal.FocusColor = System.Drawing.Color.Empty
        Me.VencimentoOriginal.FocusColorEnd = System.Drawing.Color.Empty
        Me.VencimentoOriginal.HighlightBorderOnEnter = False
        Me.VencimentoOriginal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.VencimentoOriginal.Location = New System.Drawing.Point(734, 12)
        Me.VencimentoOriginal.MaxLength = 10
        Me.VencimentoOriginal.Name = "VencimentoOriginal"
        Me.VencimentoOriginal.PreencherZeroEsqueda = False
        Me.VencimentoOriginal.RegraValidação = Nothing
        Me.VencimentoOriginal.RegraValidaçãoMensagem = Nothing
        Me.VencimentoOriginal.Size = New System.Drawing.Size(113, 20)
        Me.VencimentoOriginal.TabIndex = 38
        Me.VencimentoOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VencimentoOriginal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.VencimentoOriginal.ValorPadrao = Nothing
        Me.VencimentoOriginal.Visible = False
        '
        'Parcelado
        '
        Me.Parcelado.AceitaColarTexto = True
        Me.Parcelado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Parcelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Parcelado.CasasDecimais = 2
        Me.Parcelado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Parcelado.CPObrigatorio = False
        Me.Parcelado.CPObrigatorioMsg = Nothing
        Me.Parcelado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Parcelado.FlatBorder = False
        Me.Parcelado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Parcelado.FocusColor = System.Drawing.Color.MistyRose
        Me.Parcelado.FocusColorEnd = System.Drawing.Color.Empty
        Me.Parcelado.HighlightBorderOnEnter = False
        Me.Parcelado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Parcelado.Location = New System.Drawing.Point(365, 244)
        Me.Parcelado.MaxLength = 15
        Me.Parcelado.Name = "Parcelado"
        Me.Parcelado.PreencherZeroEsqueda = False
        Me.Parcelado.RegraValidação = Nothing
        Me.Parcelado.RegraValidaçãoMensagem = Nothing
        Me.Parcelado.Size = New System.Drawing.Size(123, 20)
        Me.Parcelado.TabIndex = 48
        Me.Parcelado.TabStop = False
        Me.Parcelado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Parcelado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Parcelado.ValorPadrao = Nothing
        '
        'IdLancamento
        '
        Me.IdLancamento.AceitaColarTexto = True
        Me.IdLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IdLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdLancamento.CasasDecimais = 2
        Me.IdLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdLancamento.CPObrigatorio = False
        Me.IdLancamento.CPObrigatorioMsg = Nothing
        Me.IdLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdLancamento.FlatBorder = False
        Me.IdLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdLancamento.FocusColor = System.Drawing.Color.MistyRose
        Me.IdLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdLancamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLancamento.HighlightBorderOnEnter = False
        Me.IdLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdLancamento.Location = New System.Drawing.Point(12, 215)
        Me.IdLancamento.MaxLength = 30
        Me.IdLancamento.Name = "IdLancamento"
        Me.IdLancamento.PreencherZeroEsqueda = False
        Me.IdLancamento.RegraValidação = Nothing
        Me.IdLancamento.RegraValidaçãoMensagem = Nothing
        Me.IdLancamento.Size = New System.Drawing.Size(108, 23)
        Me.IdLancamento.TabIndex = 49
        Me.IdLancamento.TabStop = False
        Me.IdLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IdLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdLancamento.ValorPadrao = Nothing
        '
        'ListaPagar
        '
        Me.ListaPagar.AllowUserToAddRows = False
        Me.ListaPagar.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.ListaPagar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaPagar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cDoc, Me.cVenc, Me.cLocalPagamento, Me.cValorDoc, Me.cVencimentoOriginal})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaPagar.DefaultCellStyle = DataGridViewCellStyle3
        Me.ListaPagar.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaPagar.Location = New System.Drawing.Point(12, 12)
        Me.ListaPagar.Name = "ListaPagar"
        Me.ListaPagar.ReadOnly = True
        Me.ListaPagar.RowHeadersWidth = 20
        Me.ListaPagar.SelectAllSignVisible = False
        Me.ListaPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaPagar.Size = New System.Drawing.Size(476, 197)
        Me.ListaPagar.TabIndex = 35
        '
        'cDoc
        '
        Me.cDoc.DataPropertyName = "Documento"
        Me.cDoc.HeaderText = "Documento"
        Me.cDoc.Name = "cDoc"
        Me.cDoc.ReadOnly = True
        '
        'cVenc
        '
        Me.cVenc.DataPropertyName = "Vencimento"
        Me.cVenc.HeaderText = "Vencimento"
        Me.cVenc.Name = "cVenc"
        Me.cVenc.ReadOnly = True
        '
        'cLocalPagamento
        '
        Me.cLocalPagamento.DataPropertyName = "LocalPgto"
        Me.cLocalPagamento.HeaderText = "Local Pgto"
        Me.cLocalPagamento.Name = "cLocalPagamento"
        Me.cLocalPagamento.ReadOnly = True
        Me.cLocalPagamento.Width = 120
        '
        'cValorDoc
        '
        Me.cValorDoc.DataPropertyName = "ValorDocumento"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cValorDoc.DefaultCellStyle = DataGridViewCellStyle2
        Me.cValorDoc.HeaderText = "Valor"
        Me.cValorDoc.Name = "cValorDoc"
        Me.cValorDoc.ReadOnly = True
        Me.cValorDoc.Width = 110
        '
        'cVencimentoOriginal
        '
        Me.cVencimentoOriginal.DataPropertyName = "VencimentoOriginal"
        Me.cVencimentoOriginal.HeaderText = "Venc. Orig"
        Me.cVencimentoOriginal.Name = "cVencimentoOriginal"
        Me.cVencimentoOriginal.ReadOnly = True
        Me.cVencimentoOriginal.Visible = False
        '
        'tParcelado
        '
        Me.tParcelado.AceitaColarTexto = True
        Me.tParcelado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.tParcelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tParcelado.CasasDecimais = 2
        Me.tParcelado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tParcelado.CPObrigatorio = False
        Me.tParcelado.CPObrigatorioMsg = Nothing
        Me.tParcelado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.tParcelado.FlatBorder = False
        Me.tParcelado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.tParcelado.FocusColor = System.Drawing.Color.MistyRose
        Me.tParcelado.FocusColorEnd = System.Drawing.Color.Empty
        Me.tParcelado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tParcelado.HighlightBorderOnEnter = False
        Me.tParcelado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.tParcelado.Location = New System.Drawing.Point(365, 215)
        Me.tParcelado.MaxLength = 10
        Me.tParcelado.Name = "tParcelado"
        Me.tParcelado.PreencherZeroEsqueda = False
        Me.tParcelado.RegraValidação = Nothing
        Me.tParcelado.RegraValidaçãoMensagem = Nothing
        Me.tParcelado.Size = New System.Drawing.Size(123, 23)
        Me.tParcelado.TabIndex = 46
        Me.tParcelado.TabStop = False
        Me.tParcelado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tParcelado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.tParcelado.ValorPadrao = Nothing
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(504, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 23)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Local Pgto"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(271, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 23)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Total Parcelar"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLocalPgto
        '
        Me.txtLocalPgto.Auto_Complete = True
        Me.txtLocalPgto.AutoLimitar_Lista = True
        Me.txtLocalPgto.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.txtLocalPgto.CPObrigatorio = False
        Me.txtLocalPgto.CPObrigatorioMsg = Nothing
        Me.txtLocalPgto.FlatBorder = False
        Me.txtLocalPgto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtLocalPgto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtLocalPgto.FormattingEnabled = True
        Me.txtLocalPgto.HighlightBorderColor = System.Drawing.Color.Empty
        Me.txtLocalPgto.HighlightBorderOnEnter = False
        Me.txtLocalPgto.Location = New System.Drawing.Point(612, 99)
        Me.txtLocalPgto.Name = "txtLocalPgto"
        Me.txtLocalPgto.Size = New System.Drawing.Size(277, 21)
        Me.txtLocalPgto.TabIndex = 44
        '
        'btFecharTela
        '
        Me.btFecharTela.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFecharTela.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFecharTela.Location = New System.Drawing.Point(751, 237)
        Me.btFecharTela.Name = "btFecharTela"
        Me.btFecharTela.Size = New System.Drawing.Size(139, 31)
        Me.btFecharTela.TabIndex = 51
        Me.btFecharTela.Text = "Fechar"
        '
        'txtValor
        '
        Me.txtValor.AceitaColarTexto = True
        Me.txtValor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.CPObrigatorio = False
        Me.txtValor.CPObrigatorioMsg = Nothing
        Me.txtValor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtValor.FlatBorder = False
        Me.txtValor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtValor.FocusColor = System.Drawing.Color.Empty
        Me.txtValor.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtValor.HighlightBorderOnEnter = False
        Me.txtValor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtValor.Location = New System.Drawing.Point(612, 70)
        Me.txtValor.MaxLength = 15
        Me.txtValor.Name = "txtValor"
        Me.txtValor.PreencherZeroEsqueda = False
        Me.txtValor.RegraValidação = Nothing
        Me.txtValor.RegraValidaçãoMensagem = Nothing
        Me.txtValor.Size = New System.Drawing.Size(116, 20)
        Me.txtValor.TabIndex = 42
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.txtValor.ValorPadrao = Nothing
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(504, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 23)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Valor Doc"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVencimento
        '
        Me.txtVencimento.AceitaColarTexto = True
        Me.txtVencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtVencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVencimento.CasasDecimais = 0
        Me.txtVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVencimento.CPObrigatorio = False
        Me.txtVencimento.CPObrigatorioMsg = Nothing
        Me.txtVencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtVencimento.FlatBorder = False
        Me.txtVencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtVencimento.FocusColor = System.Drawing.Color.Empty
        Me.txtVencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtVencimento.HighlightBorderOnEnter = False
        Me.txtVencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtVencimento.Location = New System.Drawing.Point(612, 41)
        Me.txtVencimento.MaxLength = 10
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.PreencherZeroEsqueda = False
        Me.txtVencimento.RegraValidação = Nothing
        Me.txtVencimento.RegraValidaçãoMensagem = Nothing
        Me.txtVencimento.Size = New System.Drawing.Size(116, 20)
        Me.txtVencimento.TabIndex = 40
        Me.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtVencimento.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(504, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 23)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Vencimento"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDocumento
        '
        Me.txtDocumento.AceitaColarTexto = True
        Me.txtDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocumento.CasasDecimais = 0
        Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumento.CPObrigatorio = False
        Me.txtDocumento.CPObrigatorioMsg = Nothing
        Me.txtDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtDocumento.FlatBorder = False
        Me.txtDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtDocumento.FocusColor = System.Drawing.Color.Empty
        Me.txtDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtDocumento.HighlightBorderOnEnter = False
        Me.txtDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtDocumento.Location = New System.Drawing.Point(612, 12)
        Me.txtDocumento.MaxLength = 25
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.PreencherZeroEsqueda = False
        Me.txtDocumento.RegraValidação = Nothing
        Me.txtDocumento.RegraValidaçãoMensagem = Nothing
        Me.txtDocumento.Size = New System.Drawing.Size(116, 20)
        Me.txtDocumento.TabIndex = 37
        Me.txtDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtDocumento.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(611, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 25)
        Me.Label4.TabIndex = 52
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(504, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 23)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Documento"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'PagarEditParcelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "PagarEditParcelas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edição de contas a pagar - T069"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        CType(Me.ListaPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btMudarParcela As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents VencimentoOriginal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Parcelado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IdLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ListaPagar As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cVenc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cLocalPagamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cVencimentoOriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tParcelado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLocalPgto As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents btFecharTela As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtValor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtVencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
