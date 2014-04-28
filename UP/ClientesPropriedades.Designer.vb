<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesPropriedades
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
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNomePropriedade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColFone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColIncriçao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NomePropriedade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Endereço = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cep = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fone = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Inscricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Obs = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.cUF = New CBOAutoCompleteFocus.CboFocus()
        Me.cMun = New CBOAutoCompleteFocus.CboFocus()
        Me.Cidade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Nro = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btInativar = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Roteiro = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColNomePropriedade, Me.ColFone, Me.ColIncriçao})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(6, 360)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(472, 164)
        Me.MyLista.TabIndex = 23
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 0
        '
        'ColNomePropriedade
        '
        Me.ColNomePropriedade.Text = "Nome"
        Me.ColNomePropriedade.Width = 220
        '
        'ColFone
        '
        Me.ColFone.Text = "Fone"
        Me.ColFone.Width = 80
        '
        'ColIncriçao
        '
        Me.ColIncriçao.Text = "Incrição"
        Me.ColIncriçao.Width = 80
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(14, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Propriedade"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomePropriedade
        '
        Me.NomePropriedade.AceitaColarTexto = True
        Me.NomePropriedade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomePropriedade.CasasDecimais = 0
        Me.NomePropriedade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomePropriedade.CPObrigatorio = False
        Me.NomePropriedade.CPObrigatorioMsg = Nothing
        Me.NomePropriedade.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomePropriedade.FlatBorder = False
        Me.NomePropriedade.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomePropriedade.FocusColor = System.Drawing.Color.MistyRose
        Me.NomePropriedade.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomePropriedade.HighlightBorderOnEnter = False
        Me.NomePropriedade.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomePropriedade.Location = New System.Drawing.Point(136, 15)
        Me.NomePropriedade.MaxLength = 50
        Me.NomePropriedade.Name = "NomePropriedade"
        Me.NomePropriedade.PreencherZeroEsqueda = False
        Me.NomePropriedade.RegraValidação = Nothing
        Me.NomePropriedade.RegraValidaçãoMensagem = Nothing
        Me.NomePropriedade.Size = New System.Drawing.Size(349, 23)
        Me.NomePropriedade.TabIndex = 1
        Me.NomePropriedade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomePropriedade.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Endereço"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Endereço.FocusColor = System.Drawing.Color.MistyRose
        Me.Endereço.FocusColorEnd = System.Drawing.Color.Empty
        Me.Endereço.HighlightBorderOnEnter = False
        Me.Endereço.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Endereço.Location = New System.Drawing.Point(136, 44)
        Me.Endereço.MaxLength = 50
        Me.Endereço.Name = "Endereço"
        Me.Endereço.PreencherZeroEsqueda = False
        Me.Endereço.RegraValidação = Nothing
        Me.Endereço.RegraValidaçãoMensagem = Nothing
        Me.Endereço.Size = New System.Drawing.Size(349, 23)
        Me.Endereço.TabIndex = 3
        Me.Endereço.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Endereço.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cidade"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Uf"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(316, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Cep"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Cep.FocusColor = System.Drawing.Color.MistyRose
        Me.Cep.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cep.HighlightBorderOnEnter = False
        Me.Cep.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cep.Location = New System.Drawing.Point(377, 162)
        Me.Cep.MaxLength = 9
        Me.Cep.Name = "Cep"
        Me.Cep.PreencherZeroEsqueda = False
        Me.Cep.RegraValidação = Nothing
        Me.Cep.RegraValidaçãoMensagem = Nothing
        Me.Cep.Size = New System.Drawing.Size(107, 23)
        Me.Cep.TabIndex = 17
        Me.Cep.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cep
        Me.Cep.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefone"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fone
        '
        Me.Fone.AceitaColarTexto = True
        Me.Fone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Fone.CasasDecimais = 0
        Me.Fone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fone.CPObrigatorio = False
        Me.Fone.CPObrigatorioMsg = Nothing
        Me.Fone.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Fone.FlatBorder = False
        Me.Fone.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Fone.FocusColor = System.Drawing.Color.MistyRose
        Me.Fone.FocusColorEnd = System.Drawing.Color.Empty
        Me.Fone.HighlightBorderOnEnter = False
        Me.Fone.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Fone.Location = New System.Drawing.Point(136, 131)
        Me.Fone.MaxLength = 13
        Me.Fone.Name = "Fone"
        Me.Fone.PreencherZeroEsqueda = False
        Me.Fone.RegraValidação = Nothing
        Me.Fone.RegraValidaçãoMensagem = Nothing
        Me.Fone.Size = New System.Drawing.Size(158, 23)
        Me.Fone.TabIndex = 11
        Me.Fone.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Fone
        Me.Fone.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(14, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Inscrição"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Inscricao
        '
        Me.Inscricao.AceitaColarTexto = True
        Me.Inscricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Inscricao.CasasDecimais = 0
        Me.Inscricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Inscricao.CPObrigatorio = False
        Me.Inscricao.CPObrigatorioMsg = Nothing
        Me.Inscricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Inscricao.FlatBorder = False
        Me.Inscricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Inscricao.FocusColor = System.Drawing.Color.MistyRose
        Me.Inscricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Inscricao.HighlightBorderOnEnter = False
        Me.Inscricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Inscricao.Location = New System.Drawing.Point(136, 160)
        Me.Inscricao.MaxLength = 50
        Me.Inscricao.Name = "Inscricao"
        Me.Inscricao.PreencherZeroEsqueda = False
        Me.Inscricao.RegraValidação = Nothing
        Me.Inscricao.RegraValidaçãoMensagem = Nothing
        Me.Inscricao.Size = New System.Drawing.Size(158, 23)
        Me.Inscricao.TabIndex = 15
        Me.Inscricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Inscricao.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(14, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Obs"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Obs
        '
        Me.Obs.AceitaColarTexto = True
        Me.Obs.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Obs.CasasDecimais = 0
        Me.Obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Obs.CPObrigatorio = False
        Me.Obs.CPObrigatorioMsg = Nothing
        Me.Obs.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Obs.FlatBorder = False
        Me.Obs.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Obs.FocusColor = System.Drawing.Color.MistyRose
        Me.Obs.FocusColorEnd = System.Drawing.Color.Empty
        Me.Obs.HighlightBorderOnEnter = False
        Me.Obs.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Obs.Location = New System.Drawing.Point(136, 189)
        Me.Obs.MaxLength = 50
        Me.Obs.Name = "Obs"
        Me.Obs.PreencherZeroEsqueda = False
        Me.Obs.RegraValidação = Nothing
        Me.Obs.RegraValidaçãoMensagem = Nothing
        Me.Obs.Size = New System.Drawing.Size(349, 23)
        Me.Obs.TabIndex = 18
        Me.Obs.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Obs.ValorPadrao = Nothing
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.MistyRose
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(95, 530)
        Me.Cliente.MaxLength = 2
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(60, 23)
        Me.Cliente.TabIndex = 24
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        Me.Cliente.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 531)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 19)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Cliente"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(198, 532)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Id"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(285, 531)
        Me.Id.MaxLength = 2
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(64, 23)
        Me.Id.TabIndex = 26
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
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
        Me.cUF.Location = New System.Drawing.Point(136, 73)
        Me.cUF.Name = "cUF"
        Me.cUF.Size = New System.Drawing.Size(54, 23)
        Me.cUF.TabIndex = 5
        '
        'cMun
        '
        Me.cMun.Auto_Complete = True
        Me.cMun.AutoLimitar_Lista = True
        Me.cMun.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cMun.CPObrigatorio = False
        Me.cMun.CPObrigatorioMsg = Nothing
        Me.cMun.DropDownHeight = 300
        Me.cMun.FlatBorder = False
        Me.cMun.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cMun.FormattingEnabled = True
        Me.cMun.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cMun.HighlightBorderOnEnter = False
        Me.cMun.IntegralHeight = False
        Me.cMun.Location = New System.Drawing.Point(136, 102)
        Me.cMun.MaxDropDownItems = 1
        Me.cMun.Name = "cMun"
        Me.cMun.Size = New System.Drawing.Size(349, 23)
        Me.cMun.TabIndex = 9
        '
        'Cidade
        '
        Me.Cidade.AceitaColarTexto = True
        Me.Cidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cidade.CasasDecimais = 0
        Me.Cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cidade.CPObrigatorio = False
        Me.Cidade.CPObrigatorioMsg = Nothing
        Me.Cidade.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cidade.FlatBorder = False
        Me.Cidade.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cidade.FocusColor = System.Drawing.Color.MistyRose
        Me.Cidade.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cidade.HighlightBorderOnEnter = False
        Me.Cidade.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cidade.Location = New System.Drawing.Point(271, 73)
        Me.Cidade.MaxLength = 50
        Me.Cidade.Name = "Cidade"
        Me.Cidade.PreencherZeroEsqueda = False
        Me.Cidade.RegraValidação = Nothing
        Me.Cidade.RegraValidaçãoMensagem = Nothing
        Me.Cidade.Size = New System.Drawing.Size(213, 23)
        Me.Cidade.TabIndex = 7
        Me.Cidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cidade.ValorPadrao = Nothing
        Me.Cidade.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(198, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 19)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Desativado"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Visible = False
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
        Me.Nro.Location = New System.Drawing.Point(377, 133)
        Me.Nro.MaxLength = 9
        Me.Nro.Name = "Nro"
        Me.Nro.PreencherZeroEsqueda = False
        Me.Nro.RegraValidação = Nothing
        Me.Nro.RegraValidaçãoMensagem = Nothing
        Me.Nro.Size = New System.Drawing.Size(107, 23)
        Me.Nro.TabIndex = 13
        Me.Nro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Nro.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(316, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 19)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Número"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btInativar)
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btNovo)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.cUF)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.cMun)
        Me.Fundo.Controls.Add(Me.NomePropriedade)
        Me.Fundo.Controls.Add(Me.Endereço)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.Cidade)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Cliente)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.Cep)
        Me.Fundo.Controls.Add(Me.Nro)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.Roteiro)
        Me.Fundo.Controls.Add(Me.Obs)
        Me.Fundo.Controls.Add(Me.Fone)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Inscricao)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(494, 557)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btInativar
        '
        Me.btInativar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btInativar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btInativar.Location = New System.Drawing.Point(136, 325)
        Me.btInativar.Name = "btInativar"
        Me.btInativar.Size = New System.Drawing.Size(114, 29)
        Me.btInativar.TabIndex = 21
        Me.btInativar.Text = "Inativar Propriedade"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(256, 325)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(114, 29)
        Me.btSalvar.TabIndex = 20
        Me.btSalvar.Text = "Salvar Propriedade"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(376, 325)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(103, 29)
        Me.btNovo.TabIndex = 22
        Me.btNovo.Text = "Novo"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(375, 530)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(103, 29)
        Me.btFechar.TabIndex = 27
        Me.btFechar.Text = "Fechar"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(14, 218)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 19)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Roteiro"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Roteiro
        '
        Me.Roteiro.AceitaColarTexto = True
        Me.Roteiro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Roteiro.CasasDecimais = 0
        Me.Roteiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Roteiro.CPObrigatorio = False
        Me.Roteiro.CPObrigatorioMsg = Nothing
        Me.Roteiro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Roteiro.FlatBorder = False
        Me.Roteiro.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Roteiro.FocusColor = System.Drawing.Color.MistyRose
        Me.Roteiro.FocusColorEnd = System.Drawing.Color.Empty
        Me.Roteiro.HighlightBorderOnEnter = False
        Me.Roteiro.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Roteiro.Location = New System.Drawing.Point(136, 218)
        Me.Roteiro.MaxLength = 200
        Me.Roteiro.Multiline = True
        Me.Roteiro.Name = "Roteiro"
        Me.Roteiro.PreencherZeroEsqueda = False
        Me.Roteiro.RegraValidação = Nothing
        Me.Roteiro.RegraValidaçãoMensagem = Nothing
        Me.Roteiro.Size = New System.Drawing.Size(349, 101)
        Me.Roteiro.TabIndex = 19
        Me.Roteiro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Roteiro.ValorPadrao = Nothing
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ClientesPropriedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(494, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClientesPropriedades"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propriedades - T083"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColNomePropriedade As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColFone As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColIncriçao As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NomePropriedade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Endereço As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cep As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Fone As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Inscricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Obs As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents cUF As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents cMun As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Cidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Nro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btInativar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Roteiro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
