<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transportadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transportadora))
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Email = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Contato = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Telefone = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Uf = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cep = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Endereço = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cidade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RazãoTransportadora = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Incricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CgcCpf = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoPessoa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Codigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Observação = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.btNovo = New System.Windows.Forms.ToolStripButton()
        Me.btSalvar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btFechar = New System.Windows.Forms.ToolStripButton()
        Me.btLocalizar = New System.Windows.Forms.ToolStripButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(23, 302)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 19)
        Me.Label18.TabIndex = 73
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
        Me.Email.Location = New System.Drawing.Point(142, 302)
        Me.Email.MaxLength = 50
        Me.Email.Name = "Email"
        Me.Email.PreencherZeroEsqueda = False
        Me.Email.RegraValidação = Nothing
        Me.Email.RegraValidaçãoMensagem = Nothing
        Me.Email.Size = New System.Drawing.Size(341, 23)
        Me.Email.TabIndex = 74
        Me.Email.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Email.ValorPadrao = Nothing
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(23, 273)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 19)
        Me.Label17.TabIndex = 71
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
        Me.Contato.Location = New System.Drawing.Point(142, 273)
        Me.Contato.MaxLength = 50
        Me.Contato.Name = "Contato"
        Me.Contato.PreencherZeroEsqueda = False
        Me.Contato.RegraValidação = Nothing
        Me.Contato.RegraValidaçãoMensagem = Nothing
        Me.Contato.Size = New System.Drawing.Size(341, 23)
        Me.Contato.TabIndex = 72
        Me.Contato.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Contato.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(23, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 19)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Telefone"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Telefone
        '
        Me.Telefone.AceitaColarTexto = True
        Me.Telefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Telefone.CasasDecimais = 0
        Me.Telefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telefone.CPObrigatorio = False
        Me.Telefone.CPObrigatorioMsg = Nothing
        Me.Telefone.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Telefone.FlatBorder = False
        Me.Telefone.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Telefone.FocusColor = System.Drawing.Color.Empty
        Me.Telefone.FocusColorEnd = System.Drawing.Color.Empty
        Me.Telefone.HighlightBorderOnEnter = False
        Me.Telefone.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Telefone.Location = New System.Drawing.Point(142, 244)
        Me.Telefone.MaxLength = 13
        Me.Telefone.Name = "Telefone"
        Me.Telefone.PreencherZeroEsqueda = False
        Me.Telefone.RegraValidação = Nothing
        Me.Telefone.RegraValidaçãoMensagem = Nothing
        Me.Telefone.Size = New System.Drawing.Size(146, 23)
        Me.Telefone.TabIndex = 64
        Me.Telefone.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Fone
        Me.Telefone.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(414, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 19)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Uf"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Uf
        '
        Me.Uf.AceitaColarTexto = True
        Me.Uf.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Uf.CasasDecimais = 0
        Me.Uf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Uf.CPObrigatorio = False
        Me.Uf.CPObrigatorioMsg = Nothing
        Me.Uf.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Uf.FlatBorder = False
        Me.Uf.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Uf.FocusColor = System.Drawing.Color.Empty
        Me.Uf.FocusColorEnd = System.Drawing.Color.Empty
        Me.Uf.HighlightBorderOnEnter = False
        Me.Uf.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Uf.Location = New System.Drawing.Point(451, 215)
        Me.Uf.MaxLength = 2
        Me.Uf.Name = "Uf"
        Me.Uf.PreencherZeroEsqueda = False
        Me.Uf.RegraValidação = Nothing
        Me.Uf.RegraValidaçãoMensagem = Nothing
        Me.Uf.Size = New System.Drawing.Size(41, 23)
        Me.Uf.TabIndex = 60
        Me.Uf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Uf.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(500, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 19)
        Me.Label11.TabIndex = 61
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
        Me.Cep.Location = New System.Drawing.Point(551, 215)
        Me.Cep.MaxLength = 9
        Me.Cep.Name = "Cep"
        Me.Cep.PreencherZeroEsqueda = False
        Me.Cep.RegraValidação = Nothing
        Me.Cep.RegraValidaçãoMensagem = Nothing
        Me.Cep.Size = New System.Drawing.Size(98, 23)
        Me.Cep.TabIndex = 62
        Me.Cep.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cep
        Me.Cep.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(23, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 55
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
        Me.Endereço.Location = New System.Drawing.Point(142, 186)
        Me.Endereço.MaxLength = 50
        Me.Endereço.Name = "Endereço"
        Me.Endereço.PreencherZeroEsqueda = False
        Me.Endereço.RegraValidação = Nothing
        Me.Endereço.RegraValidaçãoMensagem = Nothing
        Me.Endereço.Size = New System.Drawing.Size(507, 23)
        Me.Endereço.TabIndex = 56
        Me.Endereço.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Endereço.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 19)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Cidade"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Cidade.Location = New System.Drawing.Point(142, 215)
        Me.Cidade.MaxLength = 30
        Me.Cidade.Name = "Cidade"
        Me.Cidade.PreencherZeroEsqueda = False
        Me.Cidade.RegraValidação = Nothing
        Me.Cidade.RegraValidaçãoMensagem = Nothing
        Me.Cidade.Size = New System.Drawing.Size(266, 23)
        Me.Cidade.TabIndex = 58
        Me.Cidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cidade.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Razão Social"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RazãoTransportadora
        '
        Me.RazãoTransportadora.AceitaColarTexto = True
        Me.RazãoTransportadora.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.RazãoTransportadora.CasasDecimais = 0
        Me.RazãoTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RazãoTransportadora.CPObrigatorio = False
        Me.RazãoTransportadora.CPObrigatorioMsg = Nothing
        Me.RazãoTransportadora.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.RazãoTransportadora.FlatBorder = False
        Me.RazãoTransportadora.FlatBorderColor = System.Drawing.Color.DimGray
        Me.RazãoTransportadora.FocusColor = System.Drawing.Color.Empty
        Me.RazãoTransportadora.FocusColorEnd = System.Drawing.Color.Empty
        Me.RazãoTransportadora.HighlightBorderOnEnter = False
        Me.RazãoTransportadora.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.RazãoTransportadora.Location = New System.Drawing.Point(142, 157)
        Me.RazãoTransportadora.MaxLength = 50
        Me.RazãoTransportadora.Name = "RazãoTransportadora"
        Me.RazãoTransportadora.PreencherZeroEsqueda = False
        Me.RazãoTransportadora.RegraValidação = Nothing
        Me.RazãoTransportadora.RegraValidaçãoMensagem = Nothing
        Me.RazãoTransportadora.Size = New System.Drawing.Size(507, 23)
        Me.RazãoTransportadora.TabIndex = 52
        Me.RazãoTransportadora.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.RazãoTransportadora.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(290, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Rg/Incrição Est."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Incricao
        '
        Me.Incricao.AceitaColarTexto = True
        Me.Incricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Incricao.CasasDecimais = 0
        Me.Incricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Incricao.CPObrigatorio = False
        Me.Incricao.CPObrigatorioMsg = Nothing
        Me.Incricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Incricao.FlatBorder = False
        Me.Incricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Incricao.FocusColor = System.Drawing.Color.Empty
        Me.Incricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Incricao.HighlightBorderOnEnter = False
        Me.Incricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Incricao.Location = New System.Drawing.Point(416, 128)
        Me.Incricao.Name = "Incricao"
        Me.Incricao.PreencherZeroEsqueda = False
        Me.Incricao.RegraValidação = Nothing
        Me.Incricao.RegraValidaçãoMensagem = Nothing
        Me.Incricao.Size = New System.Drawing.Size(112, 23)
        Me.Incricao.TabIndex = 50
        Me.Incricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Incricao.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Cnpj/Cpf"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CgcCpf
        '
        Me.CgcCpf.AceitaColarTexto = True
        Me.CgcCpf.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
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
        Me.CgcCpf.Location = New System.Drawing.Point(142, 128)
        Me.CgcCpf.Name = "CgcCpf"
        Me.CgcCpf.PreencherZeroEsqueda = False
        Me.CgcCpf.RegraValidação = Nothing
        Me.CgcCpf.RegraValidaçãoMensagem = Nothing
        Me.CgcCpf.Size = New System.Drawing.Size(133, 23)
        Me.CgcCpf.TabIndex = 48
        Me.CgcCpf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CgcCpf.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "F-Físico J-Jurídico"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoPessoa
        '
        Me.TipoPessoa.AceitaColarTexto = True
        Me.TipoPessoa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TipoPessoa.CasasDecimais = 0
        Me.TipoPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TipoPessoa.CPObrigatorio = False
        Me.TipoPessoa.CPObrigatorioMsg = Nothing
        Me.TipoPessoa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TipoPessoa.FlatBorder = False
        Me.TipoPessoa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TipoPessoa.FocusColor = System.Drawing.Color.Empty
        Me.TipoPessoa.FocusColorEnd = System.Drawing.Color.Empty
        Me.TipoPessoa.HighlightBorderOnEnter = False
        Me.TipoPessoa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TipoPessoa.Location = New System.Drawing.Point(142, 99)
        Me.TipoPessoa.MaxLength = 1
        Me.TipoPessoa.Name = "TipoPessoa"
        Me.TipoPessoa.PreencherZeroEsqueda = False
        Me.TipoPessoa.RegraValidação = Nothing
        Me.TipoPessoa.RegraValidaçãoMensagem = Nothing
        Me.TipoPessoa.Size = New System.Drawing.Size(41, 23)
        Me.TipoPessoa.TabIndex = 46
        Me.TipoPessoa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TipoPessoa.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Codigo
        '
        Me.Codigo.AceitaColarTexto = True
        Me.Codigo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Codigo.CasasDecimais = 0
        Me.Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Codigo.CPObrigatorio = False
        Me.Codigo.CPObrigatorioMsg = Nothing
        Me.Codigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Codigo.FlatBorder = False
        Me.Codigo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Codigo.FocusColor = System.Drawing.Color.Empty
        Me.Codigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Codigo.HighlightBorderOnEnter = False
        Me.Codigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Codigo.Location = New System.Drawing.Point(142, 70)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.PreencherZeroEsqueda = False
        Me.Codigo.RegraValidação = Nothing
        Me.Codigo.RegraValidaçãoMensagem = Nothing
        Me.Codigo.Size = New System.Drawing.Size(116, 23)
        Me.Codigo.TabIndex = 42
        Me.Codigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Codigo.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Observação"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Observação.Location = New System.Drawing.Point(142, 331)
        Me.Observação.MaxLength = 50
        Me.Observação.Multiline = True
        Me.Observação.Name = "Observação"
        Me.Observação.PreencherZeroEsqueda = False
        Me.Observação.RegraValidação = Nothing
        Me.Observação.RegraValidaçãoMensagem = Nothing
        Me.Observação.Size = New System.Drawing.Size(507, 55)
        Me.Observação.TabIndex = 83
        Me.Observação.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Observação.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Observação)
        Me.Fundo.Controls.Add(Me.Label18)
        Me.Fundo.Controls.Add(Me.Email)
        Me.Fundo.Controls.Add(Me.Label17)
        Me.Fundo.Controls.Add(Me.Codigo)
        Me.Fundo.Controls.Add(Me.Contato)
        Me.Fundo.Controls.Add(Me.TipoPessoa)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Telefone)
        Me.Fundo.Controls.Add(Me.CgcCpf)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Uf)
        Me.Fundo.Controls.Add(Me.Incricao)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Cep)
        Me.Fundo.Controls.Add(Me.RazãoTransportadora)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Endereço)
        Me.Fundo.Controls.Add(Me.Cidade)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(662, 395)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 84
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HelpProvider1.SetHelpNavigator(Me.BarraBt, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNovo, Me.btSalvar, Me.btEditar, Me.btExcluir, Me.btFechar, Me.btLocalizar})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HelpProvider1.SetShowHelp(Me.BarraBt, True)
        Me.BarraBt.Size = New System.Drawing.Size(662, 58)
        Me.BarraBt.TabIndex = 84
        Me.BarraBt.Text = "ToolStrip1"
        '
        'btNovo
        '
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(40, 55)
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSalvar
        '
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(45, 55)
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btEditar
        '
        Me.btEditar.Image = CType(resources.GetObject("btEditar.Image"), System.Drawing.Image)
        Me.btEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(43, 55)
        Me.btEditar.Text = "Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btExcluir
        '
        Me.btExcluir.Image = CType(resources.GetObject("btExcluir.Image"), System.Drawing.Image)
        Me.btExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(49, 55)
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btFechar
        '
        Me.btFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(46, 55)
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btLocalizar
        '
        Me.btLocalizar.Image = CType(resources.GetObject("btLocalizar.Image"), System.Drawing.Image)
        Me.btLocalizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btLocalizar.Name = "btLocalizar"
        Me.btLocalizar.Size = New System.Drawing.Size(59, 55)
        Me.btLocalizar.Text = "Localizar"
        Me.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Transportadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(662, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Transportadora"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transportadora - T049"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Email As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Contato As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Telefone As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Uf As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Cep As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Endereço As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RazãoTransportadora As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Incricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CgcCpf As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TipoPessoa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Codigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Observação As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents btNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btLocalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
