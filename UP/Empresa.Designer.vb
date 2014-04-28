<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresa))
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Mensagem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Telefone = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Estado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Endereço = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cidade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NomeFantasia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RazãoSocial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InçriçãoEstadual = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cgc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CódigoEmpresa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Display = New System.Windows.Forms.PictureBox()
        Me.CapSalvaImg = New System.Windows.Forms.Button()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.NovoBT = New System.Windows.Forms.ToolStripButton()
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton()
        Me.EditarBT = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton()
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.ConfBT = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.CEP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EsquemaTS = New System.Windows.Forms.CheckBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(6, 307)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 19)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Mensagem"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mensagem
        '
        Me.Mensagem.AceitaColarTexto = True
        Me.Mensagem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Mensagem.CasasDecimais = 0
        Me.Mensagem.CPObrigatorio = False
        Me.Mensagem.CPObrigatorioMsg = Nothing
        Me.Mensagem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Mensagem.FlatBorder = False
        Me.Mensagem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Mensagem.FocusColor = System.Drawing.Color.Empty
        Me.Mensagem.FocusColorEnd = System.Drawing.Color.Empty
        Me.Mensagem.HighlightBorderOnEnter = False
        Me.Mensagem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Mensagem.Location = New System.Drawing.Point(129, 307)
        Me.Mensagem.MaxLength = 50
        Me.Mensagem.Name = "Mensagem"
        Me.Mensagem.PreencherZeroEsqueda = False
        Me.Mensagem.RegraValidação = Nothing
        Me.Mensagem.RegraValidaçãoMensagem = Nothing
        Me.Mensagem.Size = New System.Drawing.Size(340, 23)
        Me.Mensagem.TabIndex = 20
        Me.Mensagem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Mensagem.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(6, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 19)
        Me.Label13.TabIndex = 19
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
        Me.Telefone.Location = New System.Drawing.Point(129, 277)
        Me.Telefone.MaxLength = 13
        Me.Telefone.Name = "Telefone"
        Me.Telefone.PreencherZeroEsqueda = False
        Me.Telefone.RegraValidação = Nothing
        Me.Telefone.RegraValidaçãoMensagem = Nothing
        Me.Telefone.Size = New System.Drawing.Size(131, 23)
        Me.Telefone.TabIndex = 20
        Me.Telefone.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Fone
        Me.Telefone.ValorPadrao = Nothing
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
        Me.Estado.Location = New System.Drawing.Point(465, 219)
        Me.Estado.MaxLength = 2
        Me.Estado.Name = "Estado"
        Me.Estado.PreencherZeroEsqueda = False
        Me.Estado.RegraValidação = Nothing
        Me.Estado.RegraValidaçãoMensagem = Nothing
        Me.Estado.Size = New System.Drawing.Size(44, 23)
        Me.Estado.TabIndex = 16
        Me.Estado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Estado.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(7, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 11
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
        Me.Endereço.Location = New System.Drawing.Point(130, 190)
        Me.Endereço.MaxLength = 50
        Me.Endereço.Name = "Endereço"
        Me.Endereço.PreencherZeroEsqueda = False
        Me.Endereço.RegraValidação = Nothing
        Me.Endereço.RegraValidaçãoMensagem = Nothing
        Me.Endereço.Size = New System.Drawing.Size(456, 23)
        Me.Endereço.TabIndex = 12
        Me.Endereço.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Endereço.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(7, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 19)
        Me.Label8.TabIndex = 13
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
        Me.Cidade.Location = New System.Drawing.Point(130, 219)
        Me.Cidade.MaxLength = 30
        Me.Cidade.Name = "Cidade"
        Me.Cidade.PreencherZeroEsqueda = False
        Me.Cidade.RegraValidação = Nothing
        Me.Cidade.RegraValidaçãoMensagem = Nothing
        Me.Cidade.Size = New System.Drawing.Size(184, 23)
        Me.Cidade.TabIndex = 14
        Me.Cidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cidade.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(7, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 9
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
        Me.NomeFantasia.Location = New System.Drawing.Point(130, 161)
        Me.NomeFantasia.MaxLength = 50
        Me.NomeFantasia.Name = "NomeFantasia"
        Me.NomeFantasia.PreencherZeroEsqueda = False
        Me.NomeFantasia.RegraValidação = Nothing
        Me.NomeFantasia.RegraValidaçãoMensagem = Nothing
        Me.NomeFantasia.Size = New System.Drawing.Size(456, 23)
        Me.NomeFantasia.TabIndex = 10
        Me.NomeFantasia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeFantasia.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(7, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 7
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
        Me.RazãoSocial.Location = New System.Drawing.Point(130, 132)
        Me.RazãoSocial.MaxLength = 50
        Me.RazãoSocial.Name = "RazãoSocial"
        Me.RazãoSocial.PreencherZeroEsqueda = False
        Me.RazãoSocial.RegraValidação = Nothing
        Me.RazãoSocial.RegraValidaçãoMensagem = Nothing
        Me.RazãoSocial.Size = New System.Drawing.Size(456, 23)
        Me.RazãoSocial.TabIndex = 8
        Me.RazãoSocial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.RazãoSocial.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(360, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Rg/Insc Est."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InçriçãoEstadual
        '
        Me.InçriçãoEstadual.AceitaColarTexto = True
        Me.InçriçãoEstadual.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.InçriçãoEstadual.CasasDecimais = 0
        Me.InçriçãoEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.InçriçãoEstadual.CPObrigatorio = False
        Me.InçriçãoEstadual.CPObrigatorioMsg = Nothing
        Me.InçriçãoEstadual.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.InçriçãoEstadual.FlatBorder = False
        Me.InçriçãoEstadual.FlatBorderColor = System.Drawing.Color.DimGray
        Me.InçriçãoEstadual.FocusColor = System.Drawing.Color.Empty
        Me.InçriçãoEstadual.FocusColorEnd = System.Drawing.Color.Empty
        Me.InçriçãoEstadual.HighlightBorderOnEnter = False
        Me.InçriçãoEstadual.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.InçriçãoEstadual.Location = New System.Drawing.Point(465, 99)
        Me.InçriçãoEstadual.Name = "InçriçãoEstadual"
        Me.InçriçãoEstadual.PreencherZeroEsqueda = False
        Me.InçriçãoEstadual.RegraValidação = Nothing
        Me.InçriçãoEstadual.RegraValidaçãoMensagem = Nothing
        Me.InçriçãoEstadual.Size = New System.Drawing.Size(121, 23)
        Me.InçriçãoEstadual.TabIndex = 6
        Me.InçriçãoEstadual.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.InçriçãoEstadual.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(7, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cnpj"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cgc
        '
        Me.Cgc.AceitaColarTexto = True
        Me.Cgc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cgc.CasasDecimais = 0
        Me.Cgc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cgc.CPObrigatorio = False
        Me.Cgc.CPObrigatorioMsg = Nothing
        Me.Cgc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cgc.FlatBorder = False
        Me.Cgc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cgc.FocusColor = System.Drawing.Color.Empty
        Me.Cgc.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cgc.HighlightBorderOnEnter = False
        Me.Cgc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cgc.Location = New System.Drawing.Point(130, 103)
        Me.Cgc.MaxLength = 18
        Me.Cgc.Name = "Cgc"
        Me.Cgc.PreencherZeroEsqueda = False
        Me.Cgc.RegraValidação = Nothing
        Me.Cgc.RegraValidaçãoMensagem = Nothing
        Me.Cgc.Size = New System.Drawing.Size(131, 23)
        Me.Cgc.TabIndex = 4
        Me.Cgc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cnpj
        Me.Cgc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CódigoEmpresa
        '
        Me.CódigoEmpresa.AceitaColarTexto = True
        Me.CódigoEmpresa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CódigoEmpresa.CasasDecimais = 0
        Me.CódigoEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CódigoEmpresa.CPObrigatorio = False
        Me.CódigoEmpresa.CPObrigatorioMsg = Nothing
        Me.CódigoEmpresa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CódigoEmpresa.FlatBorder = False
        Me.CódigoEmpresa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CódigoEmpresa.FocusColor = System.Drawing.Color.Empty
        Me.CódigoEmpresa.FocusColorEnd = System.Drawing.Color.Empty
        Me.CódigoEmpresa.HighlightBorderOnEnter = False
        Me.CódigoEmpresa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CódigoEmpresa.Location = New System.Drawing.Point(130, 74)
        Me.CódigoEmpresa.Name = "CódigoEmpresa"
        Me.CódigoEmpresa.PreencherZeroEsqueda = False
        Me.CódigoEmpresa.RegraValidação = Nothing
        Me.CódigoEmpresa.RegraValidaçãoMensagem = Nothing
        Me.CódigoEmpresa.Size = New System.Drawing.Size(131, 23)
        Me.CódigoEmpresa.TabIndex = 2
        Me.CódigoEmpresa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CódigoEmpresa.ValorPadrao = Nothing
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.Color.Transparent
        Me.Display.Location = New System.Drawing.Point(9, 343)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(169, 121)
        Me.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Display.TabIndex = 95
        Me.Display.TabStop = False
        '
        'CapSalvaImg
        '
        Me.CapSalvaImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CapSalvaImg.Location = New System.Drawing.Point(11, 471)
        Me.CapSalvaImg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CapSalvaImg.Name = "CapSalvaImg"
        Me.CapSalvaImg.Size = New System.Drawing.Size(169, 25)
        Me.CapSalvaImg.TabIndex = 22
        Me.CapSalvaImg.Text = "Cap. Salva Foto"
        Me.CapSalvaImg.UseVisualStyleBackColor = True
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ExcluirBT, Me.LocalizarBT, Me.FecharBT, Me.ConfBT, Me.ToolStripButton1})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(599, 58)
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
        Me.NovoBT.ToolTipText = "Novo"
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
        Me.SalvarBT.ToolTipText = "Salvar"
        '
        'EditarBT
        '
        Me.EditarBT.Image = CType(resources.GetObject("EditarBT.Image"), System.Drawing.Image)
        Me.EditarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditarBT.Name = "EditarBT"
        Me.EditarBT.Size = New System.Drawing.Size(63, 55)
        Me.EditarBT.Text = "Editar-F11"
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
        'ConfBT
        '
        Me.ConfBT.Image = CType(resources.GetObject("ConfBT.Image"), System.Drawing.Image)
        Me.ConfBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ConfBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConfBT.Name = "ConfBT"
        Me.ConfBT.Size = New System.Drawing.Size(81, 55)
        Me.ConfBT.Text = "Configuração"
        Me.ConfBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(92, 55)
        Me.ToolStripButton1.Text = "Dia de Trabalho"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.CEP)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.EsquemaTS)
        Me.Fundo.Controls.Add(Me.Cgc)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.CódigoEmpresa)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.InçriçãoEstadual)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.RazãoSocial)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.NomeFantasia)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Endereço)
        Me.Fundo.Controls.Add(Me.CapSalvaImg)
        Me.Fundo.Controls.Add(Me.Display)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Cidade)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Estado)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.Telefone)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Mensagem)
        Me.Fundo.Controls.Add(Me.Label17)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(599, 504)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 104
        '
        'CEP
        '
        Me.CEP.AceitaColarTexto = True
        Me.CEP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CEP.CasasDecimais = 0
        Me.CEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CEP.CPObrigatorio = False
        Me.CEP.CPObrigatorioMsg = Nothing
        Me.CEP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CEP.FlatBorder = False
        Me.CEP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CEP.FocusColor = System.Drawing.Color.Empty
        Me.CEP.FocusColorEnd = System.Drawing.Color.Empty
        Me.CEP.HighlightBorderOnEnter = False
        Me.CEP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CEP.Location = New System.Drawing.Point(129, 248)
        Me.CEP.MaxLength = 9
        Me.CEP.Name = "CEP"
        Me.CEP.PreencherZeroEsqueda = False
        Me.CEP.RegraValidação = Nothing
        Me.CEP.RegraValidaçãoMensagem = Nothing
        Me.CEP.Size = New System.Drawing.Size(184, 23)
        Me.CEP.TabIndex = 18
        Me.CEP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cep
        Me.CEP.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "CEP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EsquemaTS
        '
        Me.EsquemaTS.AutoSize = True
        Me.EsquemaTS.BackColor = System.Drawing.Color.Transparent
        Me.EsquemaTS.Location = New System.Drawing.Point(197, 343)
        Me.EsquemaTS.Name = "EsquemaTS"
        Me.EsquemaTS.Size = New System.Drawing.Size(115, 19)
        Me.EsquemaTS.TabIndex = 22
        Me.EsquemaTS.Text = "Usar Esquema TS"
        Me.EsquemaTS.UseVisualStyleBackColor = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(363, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 19)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Uf"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 504)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Empresa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Empresas - T050"
        CType(Me.Display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Mensagem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Telefone As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Estado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Endereço As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NomeFantasia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RazãoSocial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InçriçãoEstadual As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cgc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CódigoEmpresa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Display As System.Windows.Forms.PictureBox
    Friend WithEvents CapSalvaImg As System.Windows.Forms.Button
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ConfBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents EsquemaTS As System.Windows.Forms.CheckBox
    Friend WithEvents CEP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
