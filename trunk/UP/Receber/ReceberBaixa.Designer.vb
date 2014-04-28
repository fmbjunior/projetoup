<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceberBaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceberBaixa))
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Multa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Baixado = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ValorDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.BancoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Referencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelDocCheque = New System.Windows.Forms.Label()
        Me.DocRecebBanco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelBanco = New System.Windows.Forms.Label()
        Me.Banco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Recebimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ValorLiquido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ValorDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ValorJuros = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Vencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NotaFiscal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Pedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DisplayCaixa = New System.Windows.Forms.Label()
        Me.Vendedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MediaDescontoPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ControlePedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PercentComissao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MultaP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.JurosP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DiasAtraso = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btFindValor = New System.Windows.Forms.Label()
        Me.btFindDesconto = New System.Windows.Forms.Label()
        Me.btFindMulta = New System.Windows.Forms.Label()
        Me.btFindJuros = New System.Windows.Forms.Label()
        Me.ContaValorBaixadoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ContaValorBaixado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ContaDescontoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ContaDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ContaMultaDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ContaMulta = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ContaJurosDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContaJuros = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LocalPgto = New CBOAutoCompleteFocus.CboFocus()
        Me.btBaixa = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(4, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 19)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Multa"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Multa
        '
        Me.Multa.AceitaColarTexto = True
        Me.Multa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Multa.CasasDecimais = 2
        Me.Multa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Multa.CPObrigatorio = False
        Me.Multa.CPObrigatorioMsg = Nothing
        Me.Multa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Multa.FlatBorder = False
        Me.Multa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Multa.FocusColor = System.Drawing.Color.Empty
        Me.Multa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Multa.HighlightBorderOnEnter = False
        Me.Multa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Multa.Location = New System.Drawing.Point(122, 69)
        Me.Multa.MaxLength = 10
        Me.Multa.Name = "Multa"
        Me.Multa.PreencherZeroEsqueda = False
        Me.Multa.RegraValidação = Nothing
        Me.Multa.RegraValidaçãoMensagem = Nothing
        Me.Multa.Size = New System.Drawing.Size(116, 23)
        Me.Multa.TabIndex = 15
        Me.Multa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Multa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Multa.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(13, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cliente"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.Cliente.Location = New System.Drawing.Point(264, 10)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(496, 23)
        Me.Cliente.TabIndex = 2
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'CodCliente
        '
        Me.CodCliente.AceitaColarTexto = True
        Me.CodCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CodCliente.CasasDecimais = 0
        Me.CodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodCliente.CPObrigatorio = False
        Me.CodCliente.CPObrigatorioMsg = Nothing
        Me.CodCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodCliente.FlatBorder = False
        Me.CodCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodCliente.FocusColor = System.Drawing.Color.Empty
        Me.CodCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodCliente.HighlightBorderOnEnter = False
        Me.CodCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodCliente.Location = New System.Drawing.Point(140, 11)
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.PreencherZeroEsqueda = False
        Me.CodCliente.RegraValidação = Nothing
        Me.CodCliente.RegraValidaçãoMensagem = Nothing
        Me.CodCliente.Size = New System.Drawing.Size(116, 23)
        Me.CodCliente.TabIndex = 1
        Me.CodCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodCliente.ValorPadrao = Nothing
        '
        'Baixado
        '
        Me.Baixado.AutoSize = True
        Me.Baixado.BackColor = System.Drawing.Color.Transparent
        Me.Baixado.Enabled = False
        Me.Baixado.Location = New System.Drawing.Point(478, 472)
        Me.Baixado.Name = "Baixado"
        Me.Baixado.Size = New System.Drawing.Size(68, 19)
        Me.Baixado.TabIndex = 25
        Me.Baixado.Text = "Baixado"
        Me.Baixado.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(3, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 19)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Valor Documento"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AceitaColarTexto = True
        Me.ValorDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorDocumento.CasasDecimais = 2
        Me.ValorDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDocumento.CPObrigatorio = False
        Me.ValorDocumento.CPObrigatorioMsg = Nothing
        Me.ValorDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDocumento.FlatBorder = False
        Me.ValorDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.FocusColor = System.Drawing.Color.Empty
        Me.ValorDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDocumento.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ValorDocumento.HighlightBorderOnEnter = False
        Me.ValorDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.Location = New System.Drawing.Point(121, 11)
        Me.ValorDocumento.MaxLength = 10
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.PreencherZeroEsqueda = False
        Me.ValorDocumento.RegraValidação = Nothing
        Me.ValorDocumento.RegraValidaçãoMensagem = Nothing
        Me.ValorDocumento.Size = New System.Drawing.Size(117, 23)
        Me.ValorDocumento.TabIndex = 1
        Me.ValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDocumento.ValorPadrao = Nothing
        '
        'BancoDesc
        '
        Me.BancoDesc.AceitaColarTexto = True
        Me.BancoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.BancoDesc.CasasDecimais = 0
        Me.BancoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoDesc.CPObrigatorio = False
        Me.BancoDesc.CPObrigatorioMsg = Nothing
        Me.BancoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BancoDesc.FlatBorder = False
        Me.BancoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BancoDesc.FocusColor = System.Drawing.Color.Empty
        Me.BancoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.BancoDesc.HighlightBorderOnEnter = False
        Me.BancoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BancoDesc.Location = New System.Drawing.Point(263, 127)
        Me.BancoDesc.Name = "BancoDesc"
        Me.BancoDesc.PreencherZeroEsqueda = False
        Me.BancoDesc.RegraValidação = Nothing
        Me.BancoDesc.RegraValidaçãoMensagem = Nothing
        Me.BancoDesc.Size = New System.Drawing.Size(495, 23)
        Me.BancoDesc.TabIndex = 17
        Me.BancoDesc.TabStop = False
        Me.BancoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BancoDesc.ValorPadrao = Nothing
        '
        'Referencia
        '
        Me.Referencia.AceitaColarTexto = True
        Me.Referencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Referencia.CasasDecimais = 0
        Me.Referencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Referencia.CPObrigatorio = False
        Me.Referencia.CPObrigatorioMsg = Nothing
        Me.Referencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Referencia.FlatBorder = False
        Me.Referencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Referencia.FocusColor = System.Drawing.Color.Empty
        Me.Referencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Referencia.HighlightBorderOnEnter = False
        Me.Referencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Referencia.Location = New System.Drawing.Point(122, 185)
        Me.Referencia.Multiline = True
        Me.Referencia.Name = "Referencia"
        Me.Referencia.PreencherZeroEsqueda = False
        Me.Referencia.RegraValidação = Nothing
        Me.Referencia.RegraValidaçãoMensagem = Nothing
        Me.Referencia.Size = New System.Drawing.Size(611, 63)
        Me.Referencia.TabIndex = 35
        Me.Referencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Referencia.ValorPadrao = Nothing
        '
        'LabelDocCheque
        '
        Me.LabelDocCheque.BackColor = System.Drawing.Color.Transparent
        Me.LabelDocCheque.Location = New System.Drawing.Point(287, 157)
        Me.LabelDocCheque.Name = "LabelDocCheque"
        Me.LabelDocCheque.Size = New System.Drawing.Size(82, 19)
        Me.LabelDocCheque.TabIndex = 20
        Me.LabelDocCheque.Text = "Doc/Cheque"
        Me.LabelDocCheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DocRecebBanco
        '
        Me.DocRecebBanco.AceitaColarTexto = True
        Me.DocRecebBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DocRecebBanco.CasasDecimais = 0
        Me.DocRecebBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DocRecebBanco.CPObrigatorio = False
        Me.DocRecebBanco.CPObrigatorioMsg = Nothing
        Me.DocRecebBanco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DocRecebBanco.FlatBorder = False
        Me.DocRecebBanco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DocRecebBanco.FocusColor = System.Drawing.Color.Empty
        Me.DocRecebBanco.FocusColorEnd = System.Drawing.Color.Empty
        Me.DocRecebBanco.HighlightBorderOnEnter = False
        Me.DocRecebBanco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DocRecebBanco.Location = New System.Drawing.Point(389, 156)
        Me.DocRecebBanco.Name = "DocRecebBanco"
        Me.DocRecebBanco.PreencherZeroEsqueda = False
        Me.DocRecebBanco.RegraValidação = Nothing
        Me.DocRecebBanco.RegraValidaçãoMensagem = Nothing
        Me.DocRecebBanco.Size = New System.Drawing.Size(116, 23)
        Me.DocRecebBanco.TabIndex = 21
        Me.DocRecebBanco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DocRecebBanco.ValorPadrao = Nothing
        '
        'LabelBanco
        '
        Me.LabelBanco.BackColor = System.Drawing.Color.Transparent
        Me.LabelBanco.Location = New System.Drawing.Point(14, 127)
        Me.LabelBanco.Name = "LabelBanco"
        Me.LabelBanco.Size = New System.Drawing.Size(121, 19)
        Me.LabelBanco.TabIndex = 15
        Me.LabelBanco.Text = "Banco"
        Me.LabelBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Banco
        '
        Me.Banco.AceitaColarTexto = True
        Me.Banco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Banco.CasasDecimais = 0
        Me.Banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Banco.CPObrigatorio = False
        Me.Banco.CPObrigatorioMsg = Nothing
        Me.Banco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Banco.FlatBorder = False
        Me.Banco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Banco.FocusColor = System.Drawing.Color.Empty
        Me.Banco.FocusColorEnd = System.Drawing.Color.Empty
        Me.Banco.HighlightBorderOnEnter = False
        Me.Banco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Banco.Location = New System.Drawing.Point(140, 127)
        Me.Banco.Name = "Banco"
        Me.Banco.PreencherZeroEsqueda = False
        Me.Banco.RegraValidação = Nothing
        Me.Banco.RegraValidaçãoMensagem = Nothing
        Me.Banco.Size = New System.Drawing.Size(116, 23)
        Me.Banco.TabIndex = 16
        Me.Banco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Banco.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(14, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 19)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Local Pagamento"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(4, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 19)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Data Receb."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Recebimento
        '
        Me.Recebimento.AceitaColarTexto = True
        Me.Recebimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Recebimento.CasasDecimais = 0
        Me.Recebimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Recebimento.CPObrigatorio = False
        Me.Recebimento.CPObrigatorioMsg = Nothing
        Me.Recebimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Recebimento.FlatBorder = False
        Me.Recebimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Recebimento.FocusColor = System.Drawing.Color.Empty
        Me.Recebimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Recebimento.HighlightBorderOnEnter = False
        Me.Recebimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Recebimento.Location = New System.Drawing.Point(122, 156)
        Me.Recebimento.MaxLength = 10
        Me.Recebimento.Name = "Recebimento"
        Me.Recebimento.PreencherZeroEsqueda = False
        Me.Recebimento.RegraValidação = Nothing
        Me.Recebimento.RegraValidaçãoMensagem = Nothing
        Me.Recebimento.Size = New System.Drawing.Size(116, 23)
        Me.Recebimento.TabIndex = 33
        Me.Recebimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Recebimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Recebimento.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(4, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 19)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Valor Liquido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorLiquido
        '
        Me.ValorLiquido.AceitaColarTexto = True
        Me.ValorLiquido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorLiquido.CasasDecimais = 2
        Me.ValorLiquido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorLiquido.CPObrigatorio = False
        Me.ValorLiquido.CPObrigatorioMsg = Nothing
        Me.ValorLiquido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorLiquido.FlatBorder = False
        Me.ValorLiquido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorLiquido.FocusColor = System.Drawing.Color.Empty
        Me.ValorLiquido.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorLiquido.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorLiquido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ValorLiquido.HighlightBorderOnEnter = False
        Me.ValorLiquido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorLiquido.Location = New System.Drawing.Point(122, 127)
        Me.ValorLiquido.MaxLength = 10
        Me.ValorLiquido.Name = "ValorLiquido"
        Me.ValorLiquido.PreencherZeroEsqueda = False
        Me.ValorLiquido.RegraValidação = Nothing
        Me.ValorLiquido.RegraValidaçãoMensagem = Nothing
        Me.ValorLiquido.Size = New System.Drawing.Size(116, 23)
        Me.ValorLiquido.TabIndex = 27
        Me.ValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorLiquido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorLiquido.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(4, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Desconto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDesconto
        '
        Me.ValorDesconto.AceitaColarTexto = True
        Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDesconto.CasasDecimais = 2
        Me.ValorDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDesconto.CPObrigatorio = False
        Me.ValorDesconto.CPObrigatorioMsg = Nothing
        Me.ValorDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDesconto.FlatBorder = False
        Me.ValorDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.FocusColor = System.Drawing.Color.Empty
        Me.ValorDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDesconto.HighlightBorderOnEnter = False
        Me.ValorDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.Location = New System.Drawing.Point(122, 98)
        Me.ValorDesconto.MaxLength = 10
        Me.ValorDesconto.Name = "ValorDesconto"
        Me.ValorDesconto.PreencherZeroEsqueda = False
        Me.ValorDesconto.RegraValidação = Nothing
        Me.ValorDesconto.RegraValidaçãoMensagem = Nothing
        Me.ValorDesconto.Size = New System.Drawing.Size(116, 23)
        Me.ValorDesconto.TabIndex = 21
        Me.ValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDesconto.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(4, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Juros"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorJuros
        '
        Me.ValorJuros.AceitaColarTexto = True
        Me.ValorJuros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorJuros.CasasDecimais = 2
        Me.ValorJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorJuros.CPObrigatorio = False
        Me.ValorJuros.CPObrigatorioMsg = Nothing
        Me.ValorJuros.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorJuros.FlatBorder = False
        Me.ValorJuros.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorJuros.FocusColor = System.Drawing.Color.Empty
        Me.ValorJuros.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorJuros.HighlightBorderOnEnter = False
        Me.ValorJuros.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorJuros.Location = New System.Drawing.Point(122, 40)
        Me.ValorJuros.MaxLength = 10
        Me.ValorJuros.Name = "ValorJuros"
        Me.ValorJuros.PreencherZeroEsqueda = False
        Me.ValorJuros.RegraValidação = Nothing
        Me.ValorJuros.RegraValidaçãoMensagem = Nothing
        Me.ValorJuros.Size = New System.Drawing.Size(116, 23)
        Me.ValorJuros.TabIndex = 7
        Me.ValorJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorJuros.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorJuros.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(284, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Vencimento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vencimento
        '
        Me.Vencimento.AceitaColarTexto = True
        Me.Vencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Vencimento.CasasDecimais = 0
        Me.Vencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vencimento.CPObrigatorio = False
        Me.Vencimento.CPObrigatorioMsg = Nothing
        Me.Vencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vencimento.FlatBorder = False
        Me.Vencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vencimento.FocusColor = System.Drawing.Color.Empty
        Me.Vencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vencimento.HighlightBorderOnEnter = False
        Me.Vencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vencimento.Location = New System.Drawing.Point(389, 69)
        Me.Vencimento.MaxLength = 10
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PreencherZeroEsqueda = False
        Me.Vencimento.RegraValidação = Nothing
        Me.Vencimento.RegraValidaçãoMensagem = Nothing
        Me.Vencimento.Size = New System.Drawing.Size(116, 23)
        Me.Vencimento.TabIndex = 12
        Me.Vencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Vencimento.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Data Doc"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataDocumento
        '
        Me.DataDocumento.AceitaColarTexto = True
        Me.DataDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataDocumento.CasasDecimais = 0
        Me.DataDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataDocumento.CPObrigatorio = False
        Me.DataDocumento.CPObrigatorioMsg = Nothing
        Me.DataDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataDocumento.FlatBorder = False
        Me.DataDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataDocumento.FocusColor = System.Drawing.Color.Empty
        Me.DataDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataDocumento.HighlightBorderOnEnter = False
        Me.DataDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataDocumento.Location = New System.Drawing.Point(139, 69)
        Me.DataDocumento.MaxLength = 10
        Me.DataDocumento.Name = "DataDocumento"
        Me.DataDocumento.PreencherZeroEsqueda = False
        Me.DataDocumento.RegraValidação = Nothing
        Me.DataDocumento.RegraValidaçãoMensagem = Nothing
        Me.DataDocumento.Size = New System.Drawing.Size(118, 23)
        Me.DataDocumento.TabIndex = 10
        Me.DataDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataDocumento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(287, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Documento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Documento
        '
        Me.Documento.AceitaColarTexto = True
        Me.Documento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Documento.CasasDecimais = 0
        Me.Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Documento.CPObrigatorio = False
        Me.Documento.CPObrigatorioMsg = Nothing
        Me.Documento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Documento.FlatBorder = False
        Me.Documento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Documento.FocusColor = System.Drawing.Color.Empty
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.HighlightBorderOnEnter = False
        Me.Documento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Documento.Location = New System.Drawing.Point(389, 40)
        Me.Documento.MaxLength = 40
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(169, 23)
        Me.Documento.TabIndex = 6
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Identificador"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(140, 40)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(116, 23)
        Me.Id.TabIndex = 4
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'NotaFiscal
        '
        Me.NotaFiscal.AceitaColarTexto = True
        Me.NotaFiscal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NotaFiscal.CasasDecimais = 0
        Me.NotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NotaFiscal.CPObrigatorio = False
        Me.NotaFiscal.CPObrigatorioMsg = Nothing
        Me.NotaFiscal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NotaFiscal.FlatBorder = False
        Me.NotaFiscal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.FocusColor = System.Drawing.Color.Empty
        Me.NotaFiscal.FocusColorEnd = System.Drawing.Color.Empty
        Me.NotaFiscal.HighlightBorderOnEnter = False
        Me.NotaFiscal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.Location = New System.Drawing.Point(642, 39)
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.PreencherZeroEsqueda = False
        Me.NotaFiscal.RegraValidação = Nothing
        Me.NotaFiscal.RegraValidaçãoMensagem = Nothing
        Me.NotaFiscal.Size = New System.Drawing.Size(116, 23)
        Me.NotaFiscal.TabIndex = 8
        Me.NotaFiscal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NotaFiscal.ValorPadrao = Nothing
        '
        'Pedido
        '
        Me.Pedido.AceitaColarTexto = True
        Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Pedido.CasasDecimais = 0
        Me.Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pedido.CPObrigatorio = False
        Me.Pedido.CPObrigatorioMsg = Nothing
        Me.Pedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Pedido.FlatBorder = False
        Me.Pedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Pedido.FocusColor = System.Drawing.Color.Empty
        Me.Pedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pedido.HighlightBorderOnEnter = False
        Me.Pedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Pedido.Location = New System.Drawing.Point(141, 156)
        Me.Pedido.MaxLength = 8
        Me.Pedido.Name = "Pedido"
        Me.Pedido.PreencherZeroEsqueda = False
        Me.Pedido.RegraValidação = Nothing
        Me.Pedido.RegraValidaçãoMensagem = Nothing
        Me.Pedido.Size = New System.Drawing.Size(116, 23)
        Me.Pedido.TabIndex = 19
        Me.Pedido.TabStop = False
        Me.Pedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Pedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pedido.ValorPadrao = Nothing
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(15, 157)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 19)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Pedido"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label21)
        Me.Fundo.Controls.Add(Me.DisplayCaixa)
        Me.Fundo.Controls.Add(Me.Vendedor)
        Me.Fundo.Controls.Add(Me.MediaDescontoPedido)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.LocalPgto)
        Me.Fundo.Controls.Add(Me.btBaixa)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Documento)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.DataDocumento)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Vencimento)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label20)
        Me.Fundo.Controls.Add(Me.Pedido)
        Me.Fundo.Controls.Add(Me.NotaFiscal)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.Banco)
        Me.Fundo.Controls.Add(Me.LabelBanco)
        Me.Fundo.Controls.Add(Me.DocRecebBanco)
        Me.Fundo.Controls.Add(Me.Cliente)
        Me.Fundo.Controls.Add(Me.LabelDocCheque)
        Me.Fundo.Controls.Add(Me.CodCliente)
        Me.Fundo.Controls.Add(Me.Baixado)
        Me.Fundo.Controls.Add(Me.BancoDesc)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(773, 526)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(15, 499)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(198, 19)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Pressione [F10] para mudar o caixa"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DisplayCaixa
        '
        Me.DisplayCaixa.BackColor = System.Drawing.Color.Transparent
        Me.DisplayCaixa.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCaixa.Location = New System.Drawing.Point(14, 472)
        Me.DisplayCaixa.Name = "DisplayCaixa"
        Me.DisplayCaixa.Size = New System.Drawing.Size(350, 28)
        Me.DisplayCaixa.TabIndex = 32
        Me.DisplayCaixa.Text = "Caixa Ativo:"
        Me.DisplayCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vendedor
        '
        Me.Vendedor.AceitaColarTexto = True
        Me.Vendedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.Vendedor.Location = New System.Drawing.Point(576, 157)
        Me.Vendedor.MaxLength = 10
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.PreencherZeroEsqueda = False
        Me.Vendedor.RegraValidação = Nothing
        Me.Vendedor.RegraValidaçãoMensagem = Nothing
        Me.Vendedor.Size = New System.Drawing.Size(85, 23)
        Me.Vendedor.TabIndex = 22
        Me.Vendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vendedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Vendedor.ValorPadrao = Nothing
        Me.Vendedor.Visible = False
        '
        'MediaDescontoPedido
        '
        Me.MediaDescontoPedido.AceitaColarTexto = True
        Me.MediaDescontoPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.MediaDescontoPedido.CasasDecimais = 2
        Me.MediaDescontoPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MediaDescontoPedido.CPObrigatorio = False
        Me.MediaDescontoPedido.CPObrigatorioMsg = Nothing
        Me.MediaDescontoPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.MediaDescontoPedido.FlatBorder = False
        Me.MediaDescontoPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.MediaDescontoPedido.FocusColor = System.Drawing.Color.Empty
        Me.MediaDescontoPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.MediaDescontoPedido.HighlightBorderOnEnter = False
        Me.MediaDescontoPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.MediaDescontoPedido.Location = New System.Drawing.Point(667, 156)
        Me.MediaDescontoPedido.MaxLength = 10
        Me.MediaDescontoPedido.Name = "MediaDescontoPedido"
        Me.MediaDescontoPedido.PreencherZeroEsqueda = False
        Me.MediaDescontoPedido.RegraValidação = Nothing
        Me.MediaDescontoPedido.RegraValidaçãoMensagem = Nothing
        Me.MediaDescontoPedido.Size = New System.Drawing.Size(85, 23)
        Me.MediaDescontoPedido.TabIndex = 23
        Me.MediaDescontoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MediaDescontoPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.MediaDescontoPedido.ValorPadrao = Nothing
        Me.MediaDescontoPedido.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(564, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nota Fiscal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Label23)
        Me.GroupPanel1.Controls.Add(Me.Label22)
        Me.GroupPanel1.Controls.Add(Me.ControlePedido)
        Me.GroupPanel1.Controls.Add(Me.PercentComissao)
        Me.GroupPanel1.Controls.Add(Me.MultaP)
        Me.GroupPanel1.Controls.Add(Me.JurosP)
        Me.GroupPanel1.Controls.Add(Me.DiasAtraso)
        Me.GroupPanel1.Controls.Add(Me.Label18)
        Me.GroupPanel1.Controls.Add(Me.btFindValor)
        Me.GroupPanel1.Controls.Add(Me.btFindDesconto)
        Me.GroupPanel1.Controls.Add(Me.btFindMulta)
        Me.GroupPanel1.Controls.Add(Me.btFindJuros)
        Me.GroupPanel1.Controls.Add(Me.ContaValorBaixadoDesc)
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Controls.Add(Me.ContaValorBaixado)
        Me.GroupPanel1.Controls.Add(Me.ContaDescontoDesc)
        Me.GroupPanel1.Controls.Add(Me.Label15)
        Me.GroupPanel1.Controls.Add(Me.ContaDesconto)
        Me.GroupPanel1.Controls.Add(Me.ContaMultaDesc)
        Me.GroupPanel1.Controls.Add(Me.Label13)
        Me.GroupPanel1.Controls.Add(Me.ContaMulta)
        Me.GroupPanel1.Controls.Add(Me.ContaJurosDesc)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.ContaJuros)
        Me.GroupPanel1.Controls.Add(Me.ValorDocumento)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.Label17)
        Me.GroupPanel1.Controls.Add(Me.ValorJuros)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Multa)
        Me.GroupPanel1.Controls.Add(Me.Label19)
        Me.GroupPanel1.Controls.Add(Me.ValorDesconto)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.ValorLiquido)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Recebimento)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.Referencia)
        Me.GroupPanel1.Location = New System.Drawing.Point(16, 186)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(742, 276)
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
        Me.GroupPanel1.TabIndex = 24
        Me.GroupPanel1.Text = "Valores do Documento"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(108, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(12, 21)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "%"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(109, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(12, 21)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "%"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ControlePedido
        '
        Me.ControlePedido.AceitaColarTexto = True
        Me.ControlePedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ControlePedido.CasasDecimais = 0
        Me.ControlePedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ControlePedido.CPObrigatorio = False
        Me.ControlePedido.CPObrigatorioMsg = Nothing
        Me.ControlePedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ControlePedido.FlatBorder = False
        Me.ControlePedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ControlePedido.FocusColor = System.Drawing.Color.Empty
        Me.ControlePedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.ControlePedido.HighlightBorderOnEnter = False
        Me.ControlePedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ControlePedido.Location = New System.Drawing.Point(648, 156)
        Me.ControlePedido.MaxLength = 10
        Me.ControlePedido.Name = "ControlePedido"
        Me.ControlePedido.PreencherZeroEsqueda = False
        Me.ControlePedido.RegraValidação = Nothing
        Me.ControlePedido.RegraValidaçãoMensagem = Nothing
        Me.ControlePedido.Size = New System.Drawing.Size(85, 23)
        Me.ControlePedido.TabIndex = 27
        Me.ControlePedido.TabStop = False
        Me.ControlePedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ControlePedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ControlePedido.ValorPadrao = Nothing
        Me.ControlePedido.Visible = False
        '
        'PercentComissao
        '
        Me.PercentComissao.AceitaColarTexto = True
        Me.PercentComissao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PercentComissao.CasasDecimais = 2
        Me.PercentComissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PercentComissao.CPObrigatorio = False
        Me.PercentComissao.CPObrigatorioMsg = Nothing
        Me.PercentComissao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PercentComissao.FlatBorder = False
        Me.PercentComissao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.PercentComissao.FocusColor = System.Drawing.Color.Empty
        Me.PercentComissao.FocusColorEnd = System.Drawing.Color.Empty
        Me.PercentComissao.HighlightBorderOnEnter = False
        Me.PercentComissao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.PercentComissao.Location = New System.Drawing.Point(557, 156)
        Me.PercentComissao.MaxLength = 10
        Me.PercentComissao.Name = "PercentComissao"
        Me.PercentComissao.PreencherZeroEsqueda = False
        Me.PercentComissao.RegraValidação = Nothing
        Me.PercentComissao.RegraValidaçãoMensagem = Nothing
        Me.PercentComissao.Size = New System.Drawing.Size(85, 23)
        Me.PercentComissao.TabIndex = 26
        Me.PercentComissao.TabStop = False
        Me.PercentComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercentComissao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.PercentComissao.ValorPadrao = Nothing
        Me.PercentComissao.Visible = False
        '
        'MultaP
        '
        Me.MultaP.AceitaColarTexto = True
        Me.MultaP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.MultaP.CasasDecimais = 2
        Me.MultaP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MultaP.CPObrigatorio = False
        Me.MultaP.CPObrigatorioMsg = Nothing
        Me.MultaP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.MultaP.FlatBorder = False
        Me.MultaP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.MultaP.FocusColor = System.Drawing.Color.Empty
        Me.MultaP.FocusColorEnd = System.Drawing.Color.Empty
        Me.MultaP.HighlightBorderOnEnter = False
        Me.MultaP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.MultaP.Location = New System.Drawing.Point(63, 69)
        Me.MultaP.MaxLength = 15
        Me.MultaP.Name = "MultaP"
        Me.MultaP.PreencherZeroEsqueda = False
        Me.MultaP.RegraValidação = Nothing
        Me.MultaP.RegraValidaçãoMensagem = Nothing
        Me.MultaP.Size = New System.Drawing.Size(46, 23)
        Me.MultaP.TabIndex = 13
        Me.MultaP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MultaP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.MultaP.ValorPadrao = Nothing
        '
        'JurosP
        '
        Me.JurosP.AceitaColarTexto = True
        Me.JurosP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.JurosP.CasasDecimais = 2
        Me.JurosP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.JurosP.CPObrigatorio = False
        Me.JurosP.CPObrigatorioMsg = Nothing
        Me.JurosP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.JurosP.FlatBorder = False
        Me.JurosP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.JurosP.FocusColor = System.Drawing.Color.Empty
        Me.JurosP.FocusColorEnd = System.Drawing.Color.Empty
        Me.JurosP.HighlightBorderOnEnter = False
        Me.JurosP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.JurosP.Location = New System.Drawing.Point(63, 40)
        Me.JurosP.MaxLength = 15
        Me.JurosP.Name = "JurosP"
        Me.JurosP.PreencherZeroEsqueda = False
        Me.JurosP.RegraValidação = Nothing
        Me.JurosP.RegraValidaçãoMensagem = Nothing
        Me.JurosP.Size = New System.Drawing.Size(46, 23)
        Me.JurosP.TabIndex = 5
        Me.JurosP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.JurosP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.JurosP.ValorPadrao = Nothing
        '
        'DiasAtraso
        '
        Me.DiasAtraso.AceitaColarTexto = True
        Me.DiasAtraso.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DiasAtraso.CasasDecimais = 0
        Me.DiasAtraso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiasAtraso.CPObrigatorio = False
        Me.DiasAtraso.CPObrigatorioMsg = Nothing
        Me.DiasAtraso.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiasAtraso.FlatBorder = False
        Me.DiasAtraso.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DiasAtraso.FocusColor = System.Drawing.Color.Empty
        Me.DiasAtraso.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiasAtraso.HighlightBorderOnEnter = False
        Me.DiasAtraso.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DiasAtraso.Location = New System.Drawing.Point(370, 9)
        Me.DiasAtraso.MaxLength = 8
        Me.DiasAtraso.Name = "DiasAtraso"
        Me.DiasAtraso.PreencherZeroEsqueda = False
        Me.DiasAtraso.RegraValidação = Nothing
        Me.DiasAtraso.RegraValidaçãoMensagem = Nothing
        Me.DiasAtraso.Size = New System.Drawing.Size(58, 23)
        Me.DiasAtraso.TabIndex = 3
        Me.DiasAtraso.TabStop = False
        Me.DiasAtraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DiasAtraso.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DiasAtraso.ValorPadrao = Nothing
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(261, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 19)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Dias de Atraso"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFindValor
        '
        Me.btFindValor.Image = CType(resources.GetObject("btFindValor.Image"), System.Drawing.Image)
        Me.btFindValor.Location = New System.Drawing.Point(431, 126)
        Me.btFindValor.Name = "btFindValor"
        Me.btFindValor.Size = New System.Drawing.Size(23, 23)
        Me.btFindValor.TabIndex = 30
        '
        'btFindDesconto
        '
        Me.btFindDesconto.Image = CType(resources.GetObject("btFindDesconto.Image"), System.Drawing.Image)
        Me.btFindDesconto.Location = New System.Drawing.Point(431, 97)
        Me.btFindDesconto.Name = "btFindDesconto"
        Me.btFindDesconto.Size = New System.Drawing.Size(23, 23)
        Me.btFindDesconto.TabIndex = 24
        '
        'btFindMulta
        '
        Me.btFindMulta.Image = CType(resources.GetObject("btFindMulta.Image"), System.Drawing.Image)
        Me.btFindMulta.Location = New System.Drawing.Point(431, 69)
        Me.btFindMulta.Name = "btFindMulta"
        Me.btFindMulta.Size = New System.Drawing.Size(23, 23)
        Me.btFindMulta.TabIndex = 18
        '
        'btFindJuros
        '
        Me.btFindJuros.Image = CType(resources.GetObject("btFindJuros.Image"), System.Drawing.Image)
        Me.btFindJuros.Location = New System.Drawing.Point(431, 40)
        Me.btFindJuros.Name = "btFindJuros"
        Me.btFindJuros.Size = New System.Drawing.Size(23, 23)
        Me.btFindJuros.TabIndex = 10
        '
        'ContaValorBaixadoDesc
        '
        Me.ContaValorBaixadoDesc.AceitaColarTexto = True
        Me.ContaValorBaixadoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaValorBaixadoDesc.CasasDecimais = 2
        Me.ContaValorBaixadoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaValorBaixadoDesc.CPObrigatorio = False
        Me.ContaValorBaixadoDesc.CPObrigatorioMsg = Nothing
        Me.ContaValorBaixadoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaValorBaixadoDesc.FlatBorder = False
        Me.ContaValorBaixadoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaValorBaixadoDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaValorBaixadoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaValorBaixadoDesc.HighlightBorderOnEnter = False
        Me.ContaValorBaixadoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaValorBaixadoDesc.Location = New System.Drawing.Point(460, 126)
        Me.ContaValorBaixadoDesc.MaxLength = 6
        Me.ContaValorBaixadoDesc.Name = "ContaValorBaixadoDesc"
        Me.ContaValorBaixadoDesc.PreencherZeroEsqueda = False
        Me.ContaValorBaixadoDesc.RegraValidação = Nothing
        Me.ContaValorBaixadoDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaValorBaixadoDesc.Size = New System.Drawing.Size(273, 23)
        Me.ContaValorBaixadoDesc.TabIndex = 31
        Me.ContaValorBaixadoDesc.TabStop = False
        Me.ContaValorBaixadoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaValorBaixadoDesc.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(261, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 22)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Conta Valor"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaValorBaixado
        '
        Me.ContaValorBaixado.AceitaColarTexto = True
        Me.ContaValorBaixado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaValorBaixado.CasasDecimais = 2
        Me.ContaValorBaixado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaValorBaixado.CPObrigatorio = False
        Me.ContaValorBaixado.CPObrigatorioMsg = Nothing
        Me.ContaValorBaixado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaValorBaixado.FlatBorder = False
        Me.ContaValorBaixado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaValorBaixado.FocusColor = System.Drawing.Color.Empty
        Me.ContaValorBaixado.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaValorBaixado.HighlightBorderOnEnter = False
        Me.ContaValorBaixado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaValorBaixado.Location = New System.Drawing.Point(370, 126)
        Me.ContaValorBaixado.MaxLength = 6
        Me.ContaValorBaixado.Name = "ContaValorBaixado"
        Me.ContaValorBaixado.PreencherZeroEsqueda = True
        Me.ContaValorBaixado.RegraValidação = Nothing
        Me.ContaValorBaixado.RegraValidaçãoMensagem = Nothing
        Me.ContaValorBaixado.Size = New System.Drawing.Size(58, 23)
        Me.ContaValorBaixado.TabIndex = 29
        Me.ContaValorBaixado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContaValorBaixado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaValorBaixado.ValorPadrao = Nothing
        '
        'ContaDescontoDesc
        '
        Me.ContaDescontoDesc.AceitaColarTexto = True
        Me.ContaDescontoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaDescontoDesc.CasasDecimais = 2
        Me.ContaDescontoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaDescontoDesc.CPObrigatorio = False
        Me.ContaDescontoDesc.CPObrigatorioMsg = Nothing
        Me.ContaDescontoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaDescontoDesc.FlatBorder = False
        Me.ContaDescontoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaDescontoDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaDescontoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaDescontoDesc.HighlightBorderOnEnter = False
        Me.ContaDescontoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaDescontoDesc.Location = New System.Drawing.Point(460, 97)
        Me.ContaDescontoDesc.MaxLength = 6
        Me.ContaDescontoDesc.Name = "ContaDescontoDesc"
        Me.ContaDescontoDesc.PreencherZeroEsqueda = False
        Me.ContaDescontoDesc.RegraValidação = Nothing
        Me.ContaDescontoDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaDescontoDesc.Size = New System.Drawing.Size(273, 23)
        Me.ContaDescontoDesc.TabIndex = 25
        Me.ContaDescontoDesc.TabStop = False
        Me.ContaDescontoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaDescontoDesc.ValorPadrao = Nothing
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(261, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 22)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Conta Desconto"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaDesconto
        '
        Me.ContaDesconto.AceitaColarTexto = True
        Me.ContaDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaDesconto.CasasDecimais = 2
        Me.ContaDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaDesconto.CPObrigatorio = False
        Me.ContaDesconto.CPObrigatorioMsg = Nothing
        Me.ContaDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaDesconto.FlatBorder = False
        Me.ContaDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaDesconto.FocusColor = System.Drawing.Color.Empty
        Me.ContaDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaDesconto.HighlightBorderOnEnter = False
        Me.ContaDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaDesconto.Location = New System.Drawing.Point(370, 97)
        Me.ContaDesconto.MaxLength = 6
        Me.ContaDesconto.Name = "ContaDesconto"
        Me.ContaDesconto.PreencherZeroEsqueda = True
        Me.ContaDesconto.RegraValidação = Nothing
        Me.ContaDesconto.RegraValidaçãoMensagem = Nothing
        Me.ContaDesconto.Size = New System.Drawing.Size(58, 23)
        Me.ContaDesconto.TabIndex = 23
        Me.ContaDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContaDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaDesconto.ValorPadrao = Nothing
        '
        'ContaMultaDesc
        '
        Me.ContaMultaDesc.AceitaColarTexto = True
        Me.ContaMultaDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaMultaDesc.CasasDecimais = 2
        Me.ContaMultaDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaMultaDesc.CPObrigatorio = False
        Me.ContaMultaDesc.CPObrigatorioMsg = Nothing
        Me.ContaMultaDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaMultaDesc.FlatBorder = False
        Me.ContaMultaDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaMultaDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaMultaDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaMultaDesc.HighlightBorderOnEnter = False
        Me.ContaMultaDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaMultaDesc.Location = New System.Drawing.Point(460, 69)
        Me.ContaMultaDesc.MaxLength = 6
        Me.ContaMultaDesc.Name = "ContaMultaDesc"
        Me.ContaMultaDesc.PreencherZeroEsqueda = False
        Me.ContaMultaDesc.RegraValidação = Nothing
        Me.ContaMultaDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaMultaDesc.Size = New System.Drawing.Size(273, 23)
        Me.ContaMultaDesc.TabIndex = 19
        Me.ContaMultaDesc.TabStop = False
        Me.ContaMultaDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaMultaDesc.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(261, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 22)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Conta Multa"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaMulta
        '
        Me.ContaMulta.AceitaColarTexto = True
        Me.ContaMulta.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaMulta.CasasDecimais = 2
        Me.ContaMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaMulta.CPObrigatorio = False
        Me.ContaMulta.CPObrigatorioMsg = Nothing
        Me.ContaMulta.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaMulta.FlatBorder = False
        Me.ContaMulta.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaMulta.FocusColor = System.Drawing.Color.Empty
        Me.ContaMulta.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaMulta.HighlightBorderOnEnter = False
        Me.ContaMulta.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaMulta.Location = New System.Drawing.Point(370, 69)
        Me.ContaMulta.MaxLength = 6
        Me.ContaMulta.Name = "ContaMulta"
        Me.ContaMulta.PreencherZeroEsqueda = True
        Me.ContaMulta.RegraValidação = Nothing
        Me.ContaMulta.RegraValidaçãoMensagem = Nothing
        Me.ContaMulta.Size = New System.Drawing.Size(58, 23)
        Me.ContaMulta.TabIndex = 17
        Me.ContaMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContaMulta.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaMulta.ValorPadrao = Nothing
        '
        'ContaJurosDesc
        '
        Me.ContaJurosDesc.AceitaColarTexto = True
        Me.ContaJurosDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaJurosDesc.CasasDecimais = 2
        Me.ContaJurosDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaJurosDesc.CPObrigatorio = False
        Me.ContaJurosDesc.CPObrigatorioMsg = Nothing
        Me.ContaJurosDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaJurosDesc.FlatBorder = False
        Me.ContaJurosDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaJurosDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaJurosDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaJurosDesc.HighlightBorderOnEnter = False
        Me.ContaJurosDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaJurosDesc.Location = New System.Drawing.Point(460, 39)
        Me.ContaJurosDesc.MaxLength = 6
        Me.ContaJurosDesc.Name = "ContaJurosDesc"
        Me.ContaJurosDesc.PreencherZeroEsqueda = False
        Me.ContaJurosDesc.RegraValidação = Nothing
        Me.ContaJurosDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaJurosDesc.Size = New System.Drawing.Size(273, 23)
        Me.ContaJurosDesc.TabIndex = 11
        Me.ContaJurosDesc.TabStop = False
        Me.ContaJurosDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaJurosDesc.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(261, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Conta Juros"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaJuros
        '
        Me.ContaJuros.AceitaColarTexto = True
        Me.ContaJuros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaJuros.CasasDecimais = 2
        Me.ContaJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaJuros.CPObrigatorio = False
        Me.ContaJuros.CPObrigatorioMsg = Nothing
        Me.ContaJuros.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaJuros.FlatBorder = False
        Me.ContaJuros.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaJuros.FocusColor = System.Drawing.Color.Empty
        Me.ContaJuros.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaJuros.HighlightBorderOnEnter = False
        Me.ContaJuros.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaJuros.Location = New System.Drawing.Point(370, 39)
        Me.ContaJuros.MaxLength = 6
        Me.ContaJuros.Name = "ContaJuros"
        Me.ContaJuros.PreencherZeroEsqueda = True
        Me.ContaJuros.RegraValidação = Nothing
        Me.ContaJuros.RegraValidaçãoMensagem = Nothing
        Me.ContaJuros.Size = New System.Drawing.Size(58, 23)
        Me.ContaJuros.TabIndex = 9
        Me.ContaJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContaJuros.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaJuros.ValorPadrao = Nothing
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(4, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 19)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Histórico"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.LocalPgto.HighlightBorderColor = System.Drawing.Color.Empty
        Me.LocalPgto.HighlightBorderOnEnter = False
        Me.LocalPgto.Location = New System.Drawing.Point(140, 98)
        Me.LocalPgto.MaxDropDownItems = 4
        Me.LocalPgto.Name = "LocalPgto"
        Me.LocalPgto.Size = New System.Drawing.Size(618, 23)
        Me.LocalPgto.TabIndex = 14
        '
        'btBaixa
        '
        Me.btBaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBaixa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBaixa.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBaixa.Location = New System.Drawing.Point(552, 492)
        Me.btBaixa.Name = "btBaixa"
        Me.btBaixa.Size = New System.Drawing.Size(116, 28)
        Me.btBaixa.TabIndex = 29
        Me.btBaixa.Text = "Baixar Documento"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(674, 492)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(84, 28)
        Me.btFechar.TabIndex = 30
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ReceberBaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(773, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReceberBaixa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baixar Documento Contas a Receber - T059"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Multa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Baixado As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ValorDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BancoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Referencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelDocCheque As System.Windows.Forms.Label
    Friend WithEvents DocRecebBanco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelBanco As System.Windows.Forms.Label
    Friend WithEvents Banco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Recebimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ValorLiquido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ValorDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ValorJuros As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Vencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NotaFiscal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Pedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btBaixa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LocalPgto As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ContaJuros As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaValorBaixadoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ContaValorBaixado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaDescontoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ContaDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaMultaDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ContaMulta As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaJurosDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindValor As System.Windows.Forms.Label
    Friend WithEvents btFindDesconto As System.Windows.Forms.Label
    Friend WithEvents btFindMulta As System.Windows.Forms.Label
    Friend WithEvents btFindJuros As System.Windows.Forms.Label
    Friend WithEvents DiasAtraso As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents JurosP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MediaDescontoPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Vendedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PercentComissao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ControlePedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MultaP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DisplayCaixa As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
