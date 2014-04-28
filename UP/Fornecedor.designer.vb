<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fornecedor))
        Me.CartaoNatal = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Email = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Contato = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Fax = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Telefone2 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Telefone1 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Estado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cep = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Endereço = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cidade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NomeFantasia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RazãoSocial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IncriçãoEstadual = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CgcCpf = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoFornecedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CódigoFornecedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Fone0800 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.NovoBT = New System.Windows.Forms.ToolStripButton()
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton()
        Me.EditarBT = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton()
        Me.InativarBT = New System.Windows.Forms.ToolStripButton()
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.btForCli = New System.Windows.Forms.ToolStripButton()
        Me.Inativo = New System.Windows.Forms.CheckBox()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.cUF = New CBOAutoCompleteFocus.CboFocus()
        Me.cPais = New CBOAutoCompleteFocus.CboFocus()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cMun = New CBOAutoCompleteFocus.CboFocus()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.xCpl = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Nro = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Observação = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.AgenciaBancaria = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Banco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ContaCorrente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.UFCorrespondencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BairroCorrespondencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.EndCorrespondencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CidCorrespondencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CepCorrespondencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Bairro = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CartaoNatal
        '
        Me.CartaoNatal.AutoSize = True
        Me.CartaoNatal.BackColor = System.Drawing.Color.Transparent
        Me.CartaoNatal.Location = New System.Drawing.Point(487, 392)
        Me.CartaoNatal.Name = "CartaoNatal"
        Me.CartaoNatal.Size = New System.Drawing.Size(144, 19)
        Me.CartaoNatal.TabIndex = 45
        Me.CartaoNatal.Text = "Mala Direta para Natal"
        Me.CartaoNatal.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(9, 390)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 19)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Email"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Email
        '
        Me.Email.AceitaColarTexto = True
        Me.Email.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Email.CasasDecimais = 0
        Me.Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Email.CPObrigatorio = False
        Me.Email.CPObrigatorioMsg = Nothing
        Me.Email.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Email.FlatBorder = False
        Me.Email.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Email.FocusColor = System.Drawing.Color.Empty
        Me.Email.FocusColorEnd = System.Drawing.Color.Empty
        Me.Email.HighlightBorderOnEnter = False
        Me.Email.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Email.Location = New System.Drawing.Point(132, 390)
        Me.Email.MaxLength = 50
        Me.Email.Name = "Email"
        Me.Email.PreencherZeroEsqueda = False
        Me.Email.RegraValidação = Nothing
        Me.Email.RegraValidaçãoMensagem = Nothing
        Me.Email.Size = New System.Drawing.Size(341, 23)
        Me.Email.TabIndex = 44
        Me.Email.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Email.ValorPadrao = Nothing
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(9, 363)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 19)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Pessoa Contato"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Contato
        '
        Me.Contato.AceitaColarTexto = True
        Me.Contato.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Contato.CasasDecimais = 0
        Me.Contato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Contato.CPObrigatorio = False
        Me.Contato.CPObrigatorioMsg = Nothing
        Me.Contato.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Contato.FlatBorder = False
        Me.Contato.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Contato.FocusColor = System.Drawing.Color.Empty
        Me.Contato.FocusColorEnd = System.Drawing.Color.Empty
        Me.Contato.HighlightBorderOnEnter = False
        Me.Contato.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Contato.Location = New System.Drawing.Point(132, 363)
        Me.Contato.MaxLength = 50
        Me.Contato.Name = "Contato"
        Me.Contato.PreencherZeroEsqueda = False
        Me.Contato.RegraValidação = Nothing
        Me.Contato.RegraValidaçãoMensagem = Nothing
        Me.Contato.Size = New System.Drawing.Size(300, 23)
        Me.Contato.TabIndex = 41
        Me.Contato.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Contato.ValorPadrao = Nothing
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(484, 335)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 19)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Fax"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fax
        '
        Me.Fax.AceitaColarTexto = True
        Me.Fax.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Fax.CasasDecimais = 0
        Me.Fax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fax.CPObrigatorio = False
        Me.Fax.CPObrigatorioMsg = Nothing
        Me.Fax.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Fax.FlatBorder = False
        Me.Fax.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Fax.FocusColor = System.Drawing.Color.Empty
        Me.Fax.FocusColorEnd = System.Drawing.Color.Empty
        Me.Fax.HighlightBorderOnEnter = False
        Me.Fax.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Fax.Location = New System.Drawing.Point(607, 335)
        Me.Fax.MaxLength = 13
        Me.Fax.Name = "Fax"
        Me.Fax.PreencherZeroEsqueda = False
        Me.Fax.RegraValidação = Nothing
        Me.Fax.RegraValidaçãoMensagem = Nothing
        Me.Fax.Size = New System.Drawing.Size(146, 23)
        Me.Fax.TabIndex = 39
        Me.Fax.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Fone
        Me.Fax.ValorPadrao = Nothing
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(9, 336)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 19)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Telefone 2"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Telefone2
        '
        Me.Telefone2.AceitaColarTexto = True
        Me.Telefone2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Telefone2.CasasDecimais = 0
        Me.Telefone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telefone2.CPObrigatorio = False
        Me.Telefone2.CPObrigatorioMsg = Nothing
        Me.Telefone2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Telefone2.FlatBorder = False
        Me.Telefone2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Telefone2.FocusColor = System.Drawing.Color.Empty
        Me.Telefone2.FocusColorEnd = System.Drawing.Color.Empty
        Me.Telefone2.HighlightBorderOnEnter = False
        Me.Telefone2.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Telefone2.Location = New System.Drawing.Point(132, 336)
        Me.Telefone2.MaxLength = 13
        Me.Telefone2.Name = "Telefone2"
        Me.Telefone2.PreencherZeroEsqueda = False
        Me.Telefone2.RegraValidação = Nothing
        Me.Telefone2.RegraValidaçãoMensagem = Nothing
        Me.Telefone2.Size = New System.Drawing.Size(146, 23)
        Me.Telefone2.TabIndex = 37
        Me.Telefone2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Fone
        Me.Telefone2.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(9, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 19)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Telefone 1"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Telefone1
        '
        Me.Telefone1.AceitaColarTexto = True
        Me.Telefone1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Telefone1.CasasDecimais = 0
        Me.Telefone1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telefone1.CPObrigatorio = False
        Me.Telefone1.CPObrigatorioMsg = Nothing
        Me.Telefone1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Telefone1.FlatBorder = False
        Me.Telefone1.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Telefone1.FocusColor = System.Drawing.Color.Empty
        Me.Telefone1.FocusColorEnd = System.Drawing.Color.Empty
        Me.Telefone1.HighlightBorderOnEnter = False
        Me.Telefone1.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Telefone1.Location = New System.Drawing.Point(132, 309)
        Me.Telefone1.MaxLength = 13
        Me.Telefone1.Name = "Telefone1"
        Me.Telefone1.PreencherZeroEsqueda = False
        Me.Telefone1.RegraValidação = Nothing
        Me.Telefone1.RegraValidaçãoMensagem = Nothing
        Me.Telefone1.Size = New System.Drawing.Size(146, 23)
        Me.Telefone1.TabIndex = 33
        Me.Telefone1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Fone
        Me.Telefone1.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(291, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 19)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Uf"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estado
        '
        Me.Estado.AceitaColarTexto = True
        Me.Estado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Estado.CasasDecimais = 0
        Me.Estado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Estado.CPObrigatorio = False
        Me.Estado.CPObrigatorioMsg = Nothing
        Me.Estado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Estado.FlatBorder = False
        Me.Estado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Estado.FocusColor = System.Drawing.Color.Empty
        Me.Estado.FocusColorEnd = System.Drawing.Color.Empty
        Me.Estado.HighlightBorderOnEnter = False
        Me.Estado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Estado.Location = New System.Drawing.Point(363, 92)
        Me.Estado.MaxLength = 2
        Me.Estado.Name = "Estado"
        Me.Estado.PreencherZeroEsqueda = False
        Me.Estado.RegraValidação = Nothing
        Me.Estado.RegraValidaçãoMensagem = Nothing
        Me.Estado.Size = New System.Drawing.Size(41, 23)
        Me.Estado.TabIndex = 9
        Me.Estado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Estado.ValorPadrao = Nothing
        Me.Estado.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(484, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 19)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Cep"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cep
        '
        Me.Cep.AceitaColarTexto = True
        Me.Cep.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cep.CasasDecimais = 0
        Me.Cep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cep.CPObrigatorio = False
        Me.Cep.CPObrigatorioMsg = Nothing
        Me.Cep.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cep.FlatBorder = False
        Me.Cep.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cep.FocusColor = System.Drawing.Color.Empty
        Me.Cep.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cep.HighlightBorderOnEnter = False
        Me.Cep.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cep.Location = New System.Drawing.Point(607, 254)
        Me.Cep.MaxLength = 9
        Me.Cep.Name = "Cep"
        Me.Cep.PreencherZeroEsqueda = False
        Me.Cep.RegraValidação = Nothing
        Me.Cep.RegraValidaçãoMensagem = Nothing
        Me.Cep.Size = New System.Drawing.Size(146, 23)
        Me.Cep.TabIndex = 29
        Me.Cep.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cep
        Me.Cep.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(9, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Endereço"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Endereço
        '
        Me.Endereço.AceitaColarTexto = True
        Me.Endereço.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Endereço.CasasDecimais = 0
        Me.Endereço.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Endereço.CPObrigatorio = False
        Me.Endereço.CPObrigatorioMsg = Nothing
        Me.Endereço.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Endereço.FlatBorder = False
        Me.Endereço.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Endereço.FocusColor = System.Drawing.Color.Empty
        Me.Endereço.FocusColorEnd = System.Drawing.Color.Empty
        Me.Endereço.HighlightBorderOnEnter = False
        Me.Endereço.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Endereço.Location = New System.Drawing.Point(132, 173)
        Me.Endereço.MaxLength = 100
        Me.Endereço.Name = "Endereço"
        Me.Endereço.PreencherZeroEsqueda = False
        Me.Endereço.RegraValidação = Nothing
        Me.Endereço.RegraValidaçãoMensagem = Nothing
        Me.Endereço.Size = New System.Drawing.Size(539, 23)
        Me.Endereço.TabIndex = 18
        Me.Endereço.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Endereço.ValorPadrao = Nothing
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
        Me.Cidade.Location = New System.Drawing.Point(723, 225)
        Me.Cidade.MaxLength = 30
        Me.Cidade.Name = "Cidade"
        Me.Cidade.PreencherZeroEsqueda = False
        Me.Cidade.RegraValidação = Nothing
        Me.Cidade.RegraValidaçãoMensagem = Nothing
        Me.Cidade.Size = New System.Drawing.Size(30, 23)
        Me.Cidade.TabIndex = 25
        Me.Cidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cidade.ValorPadrao = Nothing
        Me.Cidade.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(9, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nome Fantasia"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeFantasia
        '
        Me.NomeFantasia.AceitaColarTexto = True
        Me.NomeFantasia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeFantasia.CasasDecimais = 0
        Me.NomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeFantasia.CPObrigatorio = False
        Me.NomeFantasia.CPObrigatorioMsg = Nothing
        Me.NomeFantasia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeFantasia.FlatBorder = False
        Me.NomeFantasia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeFantasia.FocusColor = System.Drawing.Color.Empty
        Me.NomeFantasia.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeFantasia.HighlightBorderOnEnter = False
        Me.NomeFantasia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeFantasia.Location = New System.Drawing.Point(132, 146)
        Me.NomeFantasia.MaxLength = 50
        Me.NomeFantasia.Name = "NomeFantasia"
        Me.NomeFantasia.PreencherZeroEsqueda = False
        Me.NomeFantasia.RegraValidação = Nothing
        Me.NomeFantasia.RegraValidaçãoMensagem = Nothing
        Me.NomeFantasia.Size = New System.Drawing.Size(621, 23)
        Me.NomeFantasia.TabIndex = 16
        Me.NomeFantasia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeFantasia.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Razão Social"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RazãoSocial
        '
        Me.RazãoSocial.AceitaColarTexto = True
        Me.RazãoSocial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.RazãoSocial.CasasDecimais = 0
        Me.RazãoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RazãoSocial.CPObrigatorio = False
        Me.RazãoSocial.CPObrigatorioMsg = Nothing
        Me.RazãoSocial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.RazãoSocial.FlatBorder = False
        Me.RazãoSocial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.RazãoSocial.FocusColor = System.Drawing.Color.Empty
        Me.RazãoSocial.FocusColorEnd = System.Drawing.Color.Empty
        Me.RazãoSocial.HighlightBorderOnEnter = False
        Me.RazãoSocial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.RazãoSocial.Location = New System.Drawing.Point(132, 119)
        Me.RazãoSocial.MaxLength = 50
        Me.RazãoSocial.Name = "RazãoSocial"
        Me.RazãoSocial.PreencherZeroEsqueda = False
        Me.RazãoSocial.RegraValidação = Nothing
        Me.RazãoSocial.RegraValidaçãoMensagem = Nothing
        Me.RazãoSocial.Size = New System.Drawing.Size(621, 23)
        Me.RazãoSocial.TabIndex = 14
        Me.RazãoSocial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.RazãoSocial.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(481, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Incrição Est."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IncriçãoEstadual
        '
        Me.IncriçãoEstadual.AceitaColarTexto = False
        Me.IncriçãoEstadual.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IncriçãoEstadual.CasasDecimais = 0
        Me.IncriçãoEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IncriçãoEstadual.CPObrigatorio = False
        Me.IncriçãoEstadual.CPObrigatorioMsg = Nothing
        Me.IncriçãoEstadual.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IncriçãoEstadual.FlatBorder = False
        Me.IncriçãoEstadual.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IncriçãoEstadual.FocusColor = System.Drawing.Color.Empty
        Me.IncriçãoEstadual.FocusColorEnd = System.Drawing.Color.Empty
        Me.IncriçãoEstadual.HighlightBorderOnEnter = False
        Me.IncriçãoEstadual.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IncriçãoEstadual.Location = New System.Drawing.Point(607, 92)
        Me.IncriçãoEstadual.Name = "IncriçãoEstadual"
        Me.IncriçãoEstadual.PreencherZeroEsqueda = False
        Me.IncriçãoEstadual.RegraValidação = Nothing
        Me.IncriçãoEstadual.RegraValidaçãoMensagem = Nothing
        Me.IncriçãoEstadual.ShortcutsEnabled = False
        Me.IncriçãoEstadual.Size = New System.Drawing.Size(146, 23)
        Me.IncriçãoEstadual.TabIndex = 12
        Me.IncriçãoEstadual.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IncriçãoEstadual.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cnpj/Cpf"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CgcCpf
        '
        Me.CgcCpf.AceitaColarTexto = False
        Me.CgcCpf.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CgcCpf.CasasDecimais = 0
        Me.CgcCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CgcCpf.CPObrigatorio = False
        Me.CgcCpf.CPObrigatorioMsg = Nothing
        Me.CgcCpf.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CgcCpf.FlatBorder = False
        Me.CgcCpf.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CgcCpf.FocusColor = System.Drawing.Color.Empty
        Me.CgcCpf.FocusColorEnd = System.Drawing.Color.Empty
        Me.CgcCpf.HighlightBorderOnEnter = False
        Me.CgcCpf.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CgcCpf.Location = New System.Drawing.Point(132, 92)
        Me.CgcCpf.Name = "CgcCpf"
        Me.CgcCpf.PreencherZeroEsqueda = False
        Me.CgcCpf.RegraValidação = Nothing
        Me.CgcCpf.RegraValidaçãoMensagem = Nothing
        Me.CgcCpf.ShortcutsEnabled = False
        Me.CgcCpf.Size = New System.Drawing.Size(133, 23)
        Me.CgcCpf.TabIndex = 7
        Me.CgcCpf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CgcCpf.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(292, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoFornecedor
        '
        Me.TipoFornecedor.AceitaColarTexto = True
        Me.TipoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TipoFornecedor.CasasDecimais = 0
        Me.TipoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TipoFornecedor.CPObrigatorio = False
        Me.TipoFornecedor.CPObrigatorioMsg = Nothing
        Me.TipoFornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TipoFornecedor.FlatBorder = False
        Me.TipoFornecedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TipoFornecedor.FocusColor = System.Drawing.Color.Empty
        Me.TipoFornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.TipoFornecedor.HighlightBorderOnEnter = False
        Me.TipoFornecedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TipoFornecedor.Location = New System.Drawing.Point(411, 65)
        Me.TipoFornecedor.MaxLength = 1
        Me.TipoFornecedor.Name = "TipoFornecedor"
        Me.TipoFornecedor.PreencherZeroEsqueda = False
        Me.TipoFornecedor.RegraValidação = "F:J:G"
        Me.TipoFornecedor.RegraValidaçãoMensagem = Nothing
        Me.TipoFornecedor.Size = New System.Drawing.Size(41, 23)
        Me.TipoFornecedor.TabIndex = 4
        Me.TipoFornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TipoFornecedor.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CódigoFornecedor
        '
        Me.CódigoFornecedor.AceitaColarTexto = True
        Me.CódigoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CódigoFornecedor.CasasDecimais = 0
        Me.CódigoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CódigoFornecedor.CPObrigatorio = False
        Me.CódigoFornecedor.CPObrigatorioMsg = Nothing
        Me.CódigoFornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CódigoFornecedor.FlatBorder = False
        Me.CódigoFornecedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CódigoFornecedor.FocusColor = System.Drawing.Color.Empty
        Me.CódigoFornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.CódigoFornecedor.HighlightBorderOnEnter = False
        Me.CódigoFornecedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CódigoFornecedor.Location = New System.Drawing.Point(132, 65)
        Me.CódigoFornecedor.Name = "CódigoFornecedor"
        Me.CódigoFornecedor.PreencherZeroEsqueda = False
        Me.CódigoFornecedor.RegraValidação = Nothing
        Me.CódigoFornecedor.RegraValidaçãoMensagem = Nothing
        Me.CódigoFornecedor.Size = New System.Drawing.Size(133, 23)
        Me.CódigoFornecedor.TabIndex = 2
        Me.CódigoFornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CódigoFornecedor.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(484, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 19)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Telefone 0800"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fone0800
        '
        Me.Fone0800.AceitaColarTexto = True
        Me.Fone0800.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Fone0800.CasasDecimais = 0
        Me.Fone0800.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fone0800.CPObrigatorio = False
        Me.Fone0800.CPObrigatorioMsg = Nothing
        Me.Fone0800.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Fone0800.FlatBorder = False
        Me.Fone0800.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Fone0800.FocusColor = System.Drawing.Color.Empty
        Me.Fone0800.FocusColorEnd = System.Drawing.Color.Empty
        Me.Fone0800.HighlightBorderOnEnter = False
        Me.Fone0800.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Fone0800.Location = New System.Drawing.Point(607, 309)
        Me.Fone0800.MaxLength = 13
        Me.Fone0800.Name = "Fone0800"
        Me.Fone0800.PreencherZeroEsqueda = False
        Me.Fone0800.RegraValidação = Nothing
        Me.Fone0800.RegraValidaçãoMensagem = Nothing
        Me.Fone0800.Size = New System.Drawing.Size(146, 23)
        Me.Fone0800.TabIndex = 35
        Me.Fone0800.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Fone
        Me.Fone0800.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(461, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "F-Físico J-Jurídico G-Governo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ExcluirBT, Me.InativarBT, Me.LocalizarBT, Me.FecharBT, Me.btForCli})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(760, 58)
        Me.BarraBt.TabIndex = 0
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(40, 55)
        Me.NovoBT.Text = "Novo"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalvarBT
        '
        Me.SalvarBT.Image = CType(resources.GetObject("SalvarBT.Image"), System.Drawing.Image)
        Me.SalvarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(45, 55)
        Me.SalvarBT.Text = "Salvar"
        Me.SalvarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EditarBT
        '
        Me.EditarBT.Image = CType(resources.GetObject("EditarBT.Image"), System.Drawing.Image)
        Me.EditarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditarBT.Name = "EditarBT"
        Me.EditarBT.Size = New System.Drawing.Size(43, 55)
        Me.EditarBT.Text = "Editar"
        Me.EditarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcluirBT
        '
        Me.ExcluirBT.Image = CType(resources.GetObject("ExcluirBT.Image"), System.Drawing.Image)
        Me.ExcluirBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirBT.Name = "ExcluirBT"
        Me.ExcluirBT.Size = New System.Drawing.Size(49, 55)
        Me.ExcluirBT.Text = "Excluir"
        Me.ExcluirBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExcluirBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'InativarBT
        '
        Me.InativarBT.Image = CType(resources.GetObject("InativarBT.Image"), System.Drawing.Image)
        Me.InativarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InativarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.InativarBT.Name = "InativarBT"
        Me.InativarBT.Size = New System.Drawing.Size(54, 55)
        Me.InativarBT.Text = "Inativar"
        Me.InativarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.InativarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LocalizarBT
        '
        Me.LocalizarBT.Image = CType(resources.GetObject("LocalizarBT.Image"), System.Drawing.Image)
        Me.LocalizarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LocalizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LocalizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LocalizarBT.Name = "LocalizarBT"
        Me.LocalizarBT.Size = New System.Drawing.Size(59, 55)
        Me.LocalizarBT.Text = "Localizar"
        Me.LocalizarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LocalizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(46, 55)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btForCli
        '
        Me.btForCli.Image = CType(resources.GetObject("btForCli.Image"), System.Drawing.Image)
        Me.btForCli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btForCli.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btForCli.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btForCli.Name = "btForCli"
        Me.btForCli.Size = New System.Drawing.Size(48, 55)
        Me.btForCli.Text = "For/Cli"
        Me.btForCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btForCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Inativo
        '
        Me.Inativo.AutoSize = True
        Me.Inativo.Enabled = False
        Me.Inativo.Location = New System.Drawing.Point(487, 365)
        Me.Inativo.Name = "Inativo"
        Me.Inativo.Size = New System.Drawing.Size(64, 19)
        Me.Inativo.TabIndex = 42
        Me.Inativo.Text = "Inativo"
        Me.Inativo.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.cUF)
        Me.Fundo.Controls.Add(Me.cPais)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.cMun)
        Me.Fundo.Controls.Add(Me.Label30)
        Me.Fundo.Controls.Add(Me.xCpl)
        Me.Fundo.Controls.Add(Me.Label29)
        Me.Fundo.Controls.Add(Me.Nro)
        Me.Fundo.Controls.Add(Me.Label26)
        Me.Fundo.Controls.Add(Me.Observação)
        Me.Fundo.Controls.Add(Me.Label24)
        Me.Fundo.Controls.Add(Me.GroupPanel2)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.Bairro)
        Me.Fundo.Controls.Add(Me.Label16)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.CódigoFornecedor)
        Me.Fundo.Controls.Add(Me.Inativo)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.TipoFornecedor)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.CgcCpf)
        Me.Fundo.Controls.Add(Me.Fone0800)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.IncriçãoEstadual)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.CartaoNatal)
        Me.Fundo.Controls.Add(Me.RazãoSocial)
        Me.Fundo.Controls.Add(Me.Label18)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Email)
        Me.Fundo.Controls.Add(Me.NomeFantasia)
        Me.Fundo.Controls.Add(Me.Label17)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Contato)
        Me.Fundo.Controls.Add(Me.Cidade)
        Me.Fundo.Controls.Add(Me.Label15)
        Me.Fundo.Controls.Add(Me.Fax)
        Me.Fundo.Controls.Add(Me.Endereço)
        Me.Fundo.Controls.Add(Me.Label14)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Telefone2)
        Me.Fundo.Controls.Add(Me.Cep)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.Telefone1)
        Me.Fundo.Controls.Add(Me.Estado)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(760, 603)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'cUF
        '
        Me.cUF.Auto_Complete = True
        Me.cUF.AutoLimitar_Lista = True
        Me.cUF.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cUF.CPObrigatorio = False
        Me.cUF.CPObrigatorioMsg = Nothing
        Me.cUF.FlatBorder = False
        Me.cUF.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cUF.FormattingEnabled = True
        Me.cUF.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cUF.HighlightBorderOnEnter = False
        Me.cUF.Location = New System.Drawing.Point(411, 92)
        Me.cUF.Name = "cUF"
        Me.cUF.Size = New System.Drawing.Size(41, 23)
        Me.cUF.TabIndex = 10
        '
        'cPais
        '
        Me.cPais.Auto_Complete = True
        Me.cPais.AutoLimitar_Lista = True
        Me.cPais.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cPais.CPObrigatorio = False
        Me.cPais.CPObrigatorioMsg = Nothing
        Me.cPais.FlatBorder = False
        Me.cPais.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cPais.FormattingEnabled = True
        Me.cPais.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cPais.HighlightBorderOnEnter = False
        Me.cPais.Location = New System.Drawing.Point(132, 281)
        Me.cPais.Name = "cPais"
        Me.cPais.Size = New System.Drawing.Size(300, 23)
        Me.cPais.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(9, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "País"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cMun
        '
        Me.cMun.Auto_Complete = True
        Me.cMun.AutoLimitar_Lista = True
        Me.cMun.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cMun.CPObrigatorio = False
        Me.cMun.CPObrigatorioMsg = Nothing
        Me.cMun.FlatBorder = False
        Me.cMun.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cMun.FormattingEnabled = True
        Me.cMun.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cMun.HighlightBorderOnEnter = False
        Me.cMun.Location = New System.Drawing.Point(132, 254)
        Me.cMun.Name = "cMun"
        Me.cMun.Size = New System.Drawing.Size(300, 23)
        Me.cMun.TabIndex = 27
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(9, 256)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 19)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "Municipio"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xCpl
        '
        Me.xCpl.AceitaColarTexto = True
        Me.xCpl.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.xCpl.CasasDecimais = 0
        Me.xCpl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xCpl.CPObrigatorio = False
        Me.xCpl.CPObrigatorioMsg = Nothing
        Me.xCpl.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.xCpl.FlatBorder = False
        Me.xCpl.FlatBorderColor = System.Drawing.Color.DimGray
        Me.xCpl.FocusColor = System.Drawing.Color.MistyRose
        Me.xCpl.FocusColorEnd = System.Drawing.Color.Empty
        Me.xCpl.HighlightBorderOnEnter = False
        Me.xCpl.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.xCpl.Location = New System.Drawing.Point(132, 200)
        Me.xCpl.MaxLength = 40
        Me.xCpl.Name = "xCpl"
        Me.xCpl.PreencherZeroEsqueda = False
        Me.xCpl.RegraValidação = Nothing
        Me.xCpl.RegraValidaçãoMensagem = Nothing
        Me.xCpl.Size = New System.Drawing.Size(621, 23)
        Me.xCpl.TabIndex = 22
        Me.xCpl.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.xCpl.ValorPadrao = Nothing
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(9, 200)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(91, 19)
        Me.Label29.TabIndex = 21
        Me.Label29.Text = "Complemento"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nro
        '
        Me.Nro.AceitaColarTexto = True
        Me.Nro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Nro.CasasDecimais = 0
        Me.Nro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nro.CPObrigatorio = False
        Me.Nro.CPObrigatorioMsg = Nothing
        Me.Nro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Nro.FlatBorder = False
        Me.Nro.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Nro.FocusColor = System.Drawing.Color.MistyRose
        Me.Nro.FocusColorEnd = System.Drawing.Color.Empty
        Me.Nro.HighlightBorderOnEnter = False
        Me.Nro.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Nro.Location = New System.Drawing.Point(704, 173)
        Me.Nro.MaxLength = 6
        Me.Nro.Name = "Nro"
        Me.Nro.PreencherZeroEsqueda = False
        Me.Nro.RegraValidação = Nothing
        Me.Nro.RegraValidaçãoMensagem = Nothing
        Me.Nro.Size = New System.Drawing.Size(49, 23)
        Me.Nro.TabIndex = 20
        Me.Nro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Nro.ValorPadrao = Nothing
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(677, 173)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(21, 19)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Nº"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Observação
        '
        Me.Observação.AceitaColarTexto = True
        Me.Observação.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Observação.CasasDecimais = 0
        Me.Observação.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Observação.CPObrigatorio = False
        Me.Observação.CPObrigatorioMsg = Nothing
        Me.Observação.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Observação.FlatBorder = False
        Me.Observação.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Observação.FocusColor = System.Drawing.Color.Empty
        Me.Observação.FocusColorEnd = System.Drawing.Color.Empty
        Me.Observação.HighlightBorderOnEnter = False
        Me.Observação.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Observação.Location = New System.Drawing.Point(132, 555)
        Me.Observação.MaxLength = 5000
        Me.Observação.Multiline = True
        Me.Observação.Name = "Observação"
        Me.Observação.PreencherZeroEsqueda = False
        Me.Observação.RegraValidação = Nothing
        Me.Observação.RegraValidaçãoMensagem = Nothing
        Me.Observação.Size = New System.Drawing.Size(621, 41)
        Me.Observação.TabIndex = 49
        Me.Observação.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Observação.ValorPadrao = Nothing
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(9, 555)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(108, 19)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "Observação"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.AgenciaBancaria)
        Me.GroupPanel2.Controls.Add(Me.Banco)
        Me.GroupPanel2.Controls.Add(Me.Label25)
        Me.GroupPanel2.Controls.Add(Me.ContaCorrente)
        Me.GroupPanel2.Controls.Add(Me.Label27)
        Me.GroupPanel2.Controls.Add(Me.Label28)
        Me.GroupPanel2.Location = New System.Drawing.Point(474, 417)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(279, 134)
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
        Me.GroupPanel2.TabIndex = 47
        Me.GroupPanel2.Text = "Dados Bancários"
        '
        'AgenciaBancaria
        '
        Me.AgenciaBancaria.AceitaColarTexto = True
        Me.AgenciaBancaria.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AgenciaBancaria.CasasDecimais = 0
        Me.AgenciaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AgenciaBancaria.CPObrigatorio = False
        Me.AgenciaBancaria.CPObrigatorioMsg = Nothing
        Me.AgenciaBancaria.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AgenciaBancaria.FlatBorder = False
        Me.AgenciaBancaria.FlatBorderColor = System.Drawing.Color.DimGray
        Me.AgenciaBancaria.FocusColor = System.Drawing.Color.Empty
        Me.AgenciaBancaria.FocusColorEnd = System.Drawing.Color.Empty
        Me.AgenciaBancaria.HighlightBorderOnEnter = False
        Me.AgenciaBancaria.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.AgenciaBancaria.Location = New System.Drawing.Point(127, 30)
        Me.AgenciaBancaria.MaxLength = 10
        Me.AgenciaBancaria.Name = "AgenciaBancaria"
        Me.AgenciaBancaria.PreencherZeroEsqueda = False
        Me.AgenciaBancaria.RegraValidação = Nothing
        Me.AgenciaBancaria.RegraValidaçãoMensagem = Nothing
        Me.AgenciaBancaria.Size = New System.Drawing.Size(142, 23)
        Me.AgenciaBancaria.TabIndex = 3
        Me.AgenciaBancaria.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AgenciaBancaria.ValorPadrao = Nothing
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
        Me.Banco.Location = New System.Drawing.Point(127, 3)
        Me.Banco.MaxLength = 30
        Me.Banco.Name = "Banco"
        Me.Banco.PreencherZeroEsqueda = False
        Me.Banco.RegraValidação = Nothing
        Me.Banco.RegraValidaçãoMensagem = Nothing
        Me.Banco.Size = New System.Drawing.Size(142, 23)
        Me.Banco.TabIndex = 1
        Me.Banco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Banco.ValorPadrao = Nothing
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(4, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(108, 19)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Agência"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaCorrente
        '
        Me.ContaCorrente.AceitaColarTexto = True
        Me.ContaCorrente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaCorrente.CasasDecimais = 0
        Me.ContaCorrente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCorrente.CPObrigatorio = False
        Me.ContaCorrente.CPObrigatorioMsg = Nothing
        Me.ContaCorrente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCorrente.FlatBorder = False
        Me.ContaCorrente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCorrente.FocusColor = System.Drawing.Color.Empty
        Me.ContaCorrente.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCorrente.HighlightBorderOnEnter = False
        Me.ContaCorrente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCorrente.Location = New System.Drawing.Point(127, 57)
        Me.ContaCorrente.MaxLength = 15
        Me.ContaCorrente.Name = "ContaCorrente"
        Me.ContaCorrente.PreencherZeroEsqueda = False
        Me.ContaCorrente.RegraValidação = Nothing
        Me.ContaCorrente.RegraValidaçãoMensagem = Nothing
        Me.ContaCorrente.Size = New System.Drawing.Size(142, 23)
        Me.ContaCorrente.TabIndex = 5
        Me.ContaCorrente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCorrente.ValorPadrao = Nothing
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(4, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(108, 19)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Conta Corrente"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(4, 3)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(117, 19)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Banco"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.UFCorrespondencia)
        Me.GroupPanel1.Controls.Add(Me.Label23)
        Me.GroupPanel1.Controls.Add(Me.BairroCorrespondencia)
        Me.GroupPanel1.Controls.Add(Me.EndCorrespondencia)
        Me.GroupPanel1.Controls.Add(Me.Label19)
        Me.GroupPanel1.Controls.Add(Me.Label22)
        Me.GroupPanel1.Controls.Add(Me.CidCorrespondencia)
        Me.GroupPanel1.Controls.Add(Me.CepCorrespondencia)
        Me.GroupPanel1.Controls.Add(Me.Label20)
        Me.GroupPanel1.Controls.Add(Me.Label21)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 417)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(456, 134)
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
        Me.GroupPanel1.TabIndex = 46
        Me.GroupPanel1.Text = "Endereço de Correspondência"
        '
        'UFCorrespondencia
        '
        Me.UFCorrespondencia.AceitaColarTexto = True
        Me.UFCorrespondencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.UFCorrespondencia.CasasDecimais = 0
        Me.UFCorrespondencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UFCorrespondencia.CPObrigatorio = False
        Me.UFCorrespondencia.CPObrigatorioMsg = Nothing
        Me.UFCorrespondencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.UFCorrespondencia.FlatBorder = False
        Me.UFCorrespondencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UFCorrespondencia.FocusColor = System.Drawing.Color.Empty
        Me.UFCorrespondencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.UFCorrespondencia.HighlightBorderOnEnter = False
        Me.UFCorrespondencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.UFCorrespondencia.Location = New System.Drawing.Point(117, 84)
        Me.UFCorrespondencia.MaxLength = 2
        Me.UFCorrespondencia.Name = "UFCorrespondencia"
        Me.UFCorrespondencia.PreencherZeroEsqueda = False
        Me.UFCorrespondencia.RegraValidação = Nothing
        Me.UFCorrespondencia.RegraValidaçãoMensagem = Nothing
        Me.UFCorrespondencia.Size = New System.Drawing.Size(41, 23)
        Me.UFCorrespondencia.TabIndex = 7
        Me.UFCorrespondencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UFCorrespondencia.ValorPadrao = Nothing
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(7, 84)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(113, 19)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Uf"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BairroCorrespondencia
        '
        Me.BairroCorrespondencia.AceitaColarTexto = True
        Me.BairroCorrespondencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BairroCorrespondencia.CasasDecimais = 0
        Me.BairroCorrespondencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BairroCorrespondencia.CPObrigatorio = False
        Me.BairroCorrespondencia.CPObrigatorioMsg = Nothing
        Me.BairroCorrespondencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BairroCorrespondencia.FlatBorder = False
        Me.BairroCorrespondencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BairroCorrespondencia.FocusColor = System.Drawing.Color.Empty
        Me.BairroCorrespondencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.BairroCorrespondencia.HighlightBorderOnEnter = False
        Me.BairroCorrespondencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BairroCorrespondencia.Location = New System.Drawing.Point(117, 30)
        Me.BairroCorrespondencia.MaxLength = 40
        Me.BairroCorrespondencia.Name = "BairroCorrespondencia"
        Me.BairroCorrespondencia.PreencherZeroEsqueda = False
        Me.BairroCorrespondencia.RegraValidação = Nothing
        Me.BairroCorrespondencia.RegraValidaçãoMensagem = Nothing
        Me.BairroCorrespondencia.Size = New System.Drawing.Size(331, 23)
        Me.BairroCorrespondencia.TabIndex = 3
        Me.BairroCorrespondencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BairroCorrespondencia.ValorPadrao = Nothing
        '
        'EndCorrespondencia
        '
        Me.EndCorrespondencia.AceitaColarTexto = True
        Me.EndCorrespondencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EndCorrespondencia.CasasDecimais = 0
        Me.EndCorrespondencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EndCorrespondencia.CPObrigatorio = False
        Me.EndCorrespondencia.CPObrigatorioMsg = Nothing
        Me.EndCorrespondencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EndCorrespondencia.FlatBorder = False
        Me.EndCorrespondencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EndCorrespondencia.FocusColor = System.Drawing.Color.Empty
        Me.EndCorrespondencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.EndCorrespondencia.HighlightBorderOnEnter = False
        Me.EndCorrespondencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EndCorrespondencia.Location = New System.Drawing.Point(117, 3)
        Me.EndCorrespondencia.MaxLength = 50
        Me.EndCorrespondencia.Name = "EndCorrespondencia"
        Me.EndCorrespondencia.PreencherZeroEsqueda = False
        Me.EndCorrespondencia.RegraValidação = Nothing
        Me.EndCorrespondencia.RegraValidaçãoMensagem = Nothing
        Me.EndCorrespondencia.Size = New System.Drawing.Size(331, 23)
        Me.EndCorrespondencia.TabIndex = 1
        Me.EndCorrespondencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EndCorrespondencia.ValorPadrao = Nothing
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(4, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 19)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Bairro"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(183, 84)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 19)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Cep"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CidCorrespondencia
        '
        Me.CidCorrespondencia.AceitaColarTexto = True
        Me.CidCorrespondencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CidCorrespondencia.CasasDecimais = 0
        Me.CidCorrespondencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CidCorrespondencia.CPObrigatorio = False
        Me.CidCorrespondencia.CPObrigatorioMsg = Nothing
        Me.CidCorrespondencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CidCorrespondencia.FlatBorder = False
        Me.CidCorrespondencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CidCorrespondencia.FocusColor = System.Drawing.Color.Empty
        Me.CidCorrespondencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.CidCorrespondencia.HighlightBorderOnEnter = False
        Me.CidCorrespondencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CidCorrespondencia.Location = New System.Drawing.Point(117, 57)
        Me.CidCorrespondencia.MaxLength = 30
        Me.CidCorrespondencia.Name = "CidCorrespondencia"
        Me.CidCorrespondencia.PreencherZeroEsqueda = False
        Me.CidCorrespondencia.RegraValidação = Nothing
        Me.CidCorrespondencia.RegraValidaçãoMensagem = Nothing
        Me.CidCorrespondencia.Size = New System.Drawing.Size(331, 23)
        Me.CidCorrespondencia.TabIndex = 5
        Me.CidCorrespondencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CidCorrespondencia.ValorPadrao = Nothing
        '
        'CepCorrespondencia
        '
        Me.CepCorrespondencia.AceitaColarTexto = True
        Me.CepCorrespondencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CepCorrespondencia.CasasDecimais = 0
        Me.CepCorrespondencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CepCorrespondencia.CPObrigatorio = False
        Me.CepCorrespondencia.CPObrigatorioMsg = Nothing
        Me.CepCorrespondencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CepCorrespondencia.FlatBorder = False
        Me.CepCorrespondencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CepCorrespondencia.FocusColor = System.Drawing.Color.Empty
        Me.CepCorrespondencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.CepCorrespondencia.HighlightBorderOnEnter = False
        Me.CepCorrespondencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CepCorrespondencia.Location = New System.Drawing.Point(302, 83)
        Me.CepCorrespondencia.MaxLength = 9
        Me.CepCorrespondencia.Name = "CepCorrespondencia"
        Me.CepCorrespondencia.PreencherZeroEsqueda = False
        Me.CepCorrespondencia.RegraValidação = Nothing
        Me.CepCorrespondencia.RegraValidaçãoMensagem = Nothing
        Me.CepCorrespondencia.Size = New System.Drawing.Size(146, 23)
        Me.CepCorrespondencia.TabIndex = 9
        Me.CepCorrespondencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cep
        Me.CepCorrespondencia.ValorPadrao = Nothing
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(4, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 19)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Cidade"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(4, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(117, 19)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Endereço"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bairro
        '
        Me.Bairro.AceitaColarTexto = True
        Me.Bairro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Bairro.CasasDecimais = 0
        Me.Bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Bairro.CPObrigatorio = False
        Me.Bairro.CPObrigatorioMsg = Nothing
        Me.Bairro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Bairro.FlatBorder = False
        Me.Bairro.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Bairro.FocusColor = System.Drawing.Color.Empty
        Me.Bairro.FocusColorEnd = System.Drawing.Color.Empty
        Me.Bairro.HighlightBorderOnEnter = False
        Me.Bairro.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Bairro.Location = New System.Drawing.Point(132, 227)
        Me.Bairro.MaxLength = 30
        Me.Bairro.Name = "Bairro"
        Me.Bairro.PreencherZeroEsqueda = False
        Me.Bairro.RegraValidação = Nothing
        Me.Bairro.RegraValidaçãoMensagem = Nothing
        Me.Bairro.Size = New System.Drawing.Size(300, 23)
        Me.Bairro.TabIndex = 24
        Me.Bairro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Bairro.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(9, 227)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 19)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Bairro"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Fornecedor"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedor - T007"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CartaoNatal As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Email As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Contato As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Fax As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Telefone2 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Telefone1 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Estado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Cep As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Endereço As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NomeFantasia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RazãoSocial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IncriçãoEstadual As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CgcCpf As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TipoFornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CódigoFornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Fone0800 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Inativo As System.Windows.Forms.CheckBox
    Friend WithEvents InativarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Bairro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents UFCorrespondencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BairroCorrespondencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EndCorrespondencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CidCorrespondencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CepCorrespondencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents AgenciaBancaria As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Banco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ContaCorrente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Observação As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Nro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents xCpl As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cMun As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cPais As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cUF As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents btForCli As System.Windows.Forms.ToolStripButton
End Class
