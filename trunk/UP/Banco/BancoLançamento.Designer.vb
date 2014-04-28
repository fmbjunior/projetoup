<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancoLançamento
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BancoLançamento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PreDatado = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataPreDatado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MenuDataLancamento = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LiberarDataLançamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ValorDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TipoLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Favorecido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Historico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CaiuBanco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IdLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TravarDados = New System.Windows.Forms.CheckBox()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Salvar = New DevComponents.DotNetBar.ButtonX()
        Me.Novo = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.CodigoCaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelCaixa = New System.Windows.Forms.Label()
        Me.PainelContaBalancete = New System.Windows.Forms.Panel()
        Me.btContaDespesaReceita = New System.Windows.Forms.Label()
        Me.ContaBalancete = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelDespesaReceita = New System.Windows.Forms.Label()
        Me.ContaBalanceteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindContaCentroCusto = New System.Windows.Forms.Label()
        Me.CentroCusto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CentroCustoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.GrupoCCTransf = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ContaCorrenteTranferenciaDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindCC = New System.Windows.Forms.Label()
        Me.ContaCorrenteTranferencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CaixaDesc = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuDataLancamento.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.PainelContaBalancete.SuspendLayout()
        Me.GrupoCCTransf.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(18, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id"
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
        Me.Id.Enabled = False
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(165, 72)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(75, 23)
        Me.Id.TabIndex = 2
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'PreDatado
        '
        Me.PreDatado.BackColor = System.Drawing.Color.Transparent
        Me.PreDatado.Location = New System.Drawing.Point(18, 101)
        Me.PreDatado.Name = "PreDatado"
        Me.PreDatado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PreDatado.Size = New System.Drawing.Size(162, 16)
        Me.PreDatado.TabIndex = 3
        Me.PreDatado.TabStop = False
        Me.PreDatado.Text = "Pré-Datado"
        Me.PreDatado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PreDatado.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data do Pré-Datado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataPreDatado
        '
        Me.DataPreDatado.AceitaColarTexto = True
        Me.DataPreDatado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataPreDatado.CasasDecimais = 0
        Me.DataPreDatado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataPreDatado.CPObrigatorio = False
        Me.DataPreDatado.CPObrigatorioMsg = Nothing
        Me.DataPreDatado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataPreDatado.FlatBorder = False
        Me.DataPreDatado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataPreDatado.FocusColor = System.Drawing.Color.MistyRose
        Me.DataPreDatado.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataPreDatado.HighlightBorderOnEnter = False
        Me.DataPreDatado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataPreDatado.Location = New System.Drawing.Point(165, 123)
        Me.DataPreDatado.MaxLength = 10
        Me.DataPreDatado.Name = "DataPreDatado"
        Me.DataPreDatado.PreencherZeroEsqueda = False
        Me.DataPreDatado.RegraValidação = Nothing
        Me.DataPreDatado.RegraValidaçãoMensagem = Nothing
        Me.DataPreDatado.Size = New System.Drawing.Size(109, 23)
        Me.DataPreDatado.TabIndex = 5
        Me.DataPreDatado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataPreDatado.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data Lançamento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = True
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.ContextMenuStrip = Me.MenuDataLancamento
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FlatBorder = False
        Me.DataLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataLancamento.FocusColor = System.Drawing.Color.MistyRose
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.HighlightBorderOnEnter = False
        Me.DataLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataLancamento.Location = New System.Drawing.Point(165, 152)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.PreencherZeroEsqueda = False
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(109, 23)
        Me.DataLancamento.TabIndex = 7
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'MenuDataLancamento
        '
        Me.MenuDataLancamento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiberarDataLançamentoToolStripMenuItem})
        Me.MenuDataLancamento.Name = "MenuDataLancamento"
        Me.MenuDataLancamento.Size = New System.Drawing.Size(220, 26)
        '
        'LiberarDataLançamentoToolStripMenuItem
        '
        Me.LiberarDataLançamentoToolStripMenuItem.Name = "LiberarDataLançamentoToolStripMenuItem"
        Me.LiberarDataLançamentoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.LiberarDataLançamentoToolStripMenuItem.Text = "Destravar Data Lançamento"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Documento/Cheque"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Documento.FocusColor = System.Drawing.Color.MistyRose
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.HighlightBorderOnEnter = False
        Me.Documento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Documento.Location = New System.Drawing.Point(153, 5)
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(83, 23)
        Me.Documento.TabIndex = 1
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(276, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Data Documento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataDocumento
        '
        Me.DataDocumento.AceitaColarTexto = True
        Me.DataDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataDocumento.CasasDecimais = 0
        Me.DataDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataDocumento.CPObrigatorio = False
        Me.DataDocumento.CPObrigatorioMsg = Nothing
        Me.DataDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataDocumento.FlatBorder = False
        Me.DataDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataDocumento.FocusColor = System.Drawing.Color.MistyRose
        Me.DataDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataDocumento.HighlightBorderOnEnter = False
        Me.DataDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataDocumento.Location = New System.Drawing.Point(426, 4)
        Me.DataDocumento.MaxLength = 10
        Me.DataDocumento.Name = "DataDocumento"
        Me.DataDocumento.PreencherZeroEsqueda = False
        Me.DataDocumento.RegraValidação = Nothing
        Me.DataDocumento.RegraValidaçãoMensagem = Nothing
        Me.DataDocumento.Size = New System.Drawing.Size(109, 23)
        Me.DataDocumento.TabIndex = 3
        Me.DataDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataDocumento.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(3, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Valor Documento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AceitaColarTexto = True
        Me.ValorDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDocumento.CasasDecimais = 2
        Me.ValorDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDocumento.CPObrigatorio = False
        Me.ValorDocumento.CPObrigatorioMsg = Nothing
        Me.ValorDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDocumento.FlatBorder = False
        Me.ValorDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDocumento.HighlightBorderOnEnter = False
        Me.ValorDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.Location = New System.Drawing.Point(153, 34)
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.PreencherZeroEsqueda = False
        Me.ValorDocumento.RegraValidação = Nothing
        Me.ValorDocumento.RegraValidaçãoMensagem = Nothing
        Me.ValorDocumento.Size = New System.Drawing.Size(83, 23)
        Me.ValorDocumento.TabIndex = 5
        Me.ValorDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorDocumento.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(277, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Tipo Lançamento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoLancamento
        '
        Me.TipoLancamento.AceitaColarTexto = True
        Me.TipoLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TipoLancamento.CasasDecimais = 0
        Me.TipoLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TipoLancamento.CPObrigatorio = False
        Me.TipoLancamento.CPObrigatorioMsg = Nothing
        Me.TipoLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TipoLancamento.FlatBorder = False
        Me.TipoLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TipoLancamento.FocusColor = System.Drawing.Color.MistyRose
        Me.TipoLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.TipoLancamento.HighlightBorderOnEnter = False
        Me.TipoLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TipoLancamento.Location = New System.Drawing.Point(426, 30)
        Me.TipoLancamento.Name = "TipoLancamento"
        Me.TipoLancamento.PreencherZeroEsqueda = False
        Me.TipoLancamento.RegraValidação = Nothing
        Me.TipoLancamento.RegraValidaçãoMensagem = Nothing
        Me.TipoLancamento.Size = New System.Drawing.Size(23, 23)
        Me.TipoLancamento.TabIndex = 7
        Me.TipoLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TipoLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TipoLancamento.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(3, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Favorecido"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Favorecido
        '
        Me.Favorecido.AceitaColarTexto = True
        Me.Favorecido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Favorecido.CasasDecimais = 0
        Me.Favorecido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Favorecido.CPObrigatorio = False
        Me.Favorecido.CPObrigatorioMsg = Nothing
        Me.Favorecido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Favorecido.FlatBorder = False
        Me.Favorecido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Favorecido.FocusColor = System.Drawing.Color.MistyRose
        Me.Favorecido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Favorecido.HighlightBorderOnEnter = False
        Me.Favorecido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Favorecido.Location = New System.Drawing.Point(153, 63)
        Me.Favorecido.Name = "Favorecido"
        Me.Favorecido.PreencherZeroEsqueda = False
        Me.Favorecido.RegraValidação = Nothing
        Me.Favorecido.RegraValidaçãoMensagem = Nothing
        Me.Favorecido.Size = New System.Drawing.Size(382, 23)
        Me.Favorecido.TabIndex = 9
        Me.Favorecido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Favorecido.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(21, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 22)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Histórico"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Historico
        '
        Me.Historico.AceitaColarTexto = True
        Me.Historico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Historico.CasasDecimais = 0
        Me.Historico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Historico.CPObrigatorio = False
        Me.Historico.CPObrigatorioMsg = Nothing
        Me.Historico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Historico.FlatBorder = False
        Me.Historico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Historico.FocusColor = System.Drawing.Color.MistyRose
        Me.Historico.FocusColorEnd = System.Drawing.Color.Empty
        Me.Historico.HighlightBorderOnEnter = False
        Me.Historico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Historico.Location = New System.Drawing.Point(171, 318)
        Me.Historico.Multiline = True
        Me.Historico.Name = "Historico"
        Me.Historico.PreencherZeroEsqueda = False
        Me.Historico.RegraValidação = Nothing
        Me.Historico.RegraValidaçãoMensagem = Nothing
        Me.Historico.Size = New System.Drawing.Size(382, 47)
        Me.Historico.TabIndex = 13
        Me.Historico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Historico.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(19, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 19)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Compensado"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CaiuBanco
        '
        Me.CaiuBanco.AceitaColarTexto = True
        Me.CaiuBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CaiuBanco.CasasDecimais = 0
        Me.CaiuBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CaiuBanco.CPObrigatorio = False
        Me.CaiuBanco.CPObrigatorioMsg = Nothing
        Me.CaiuBanco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CaiuBanco.FlatBorder = False
        Me.CaiuBanco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CaiuBanco.FocusColor = System.Drawing.Color.MistyRose
        Me.CaiuBanco.FocusColorEnd = System.Drawing.Color.Empty
        Me.CaiuBanco.HighlightBorderOnEnter = False
        Me.CaiuBanco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CaiuBanco.Location = New System.Drawing.Point(169, 437)
        Me.CaiuBanco.Name = "CaiuBanco"
        Me.CaiuBanco.PreencherZeroEsqueda = False
        Me.CaiuBanco.RegraValidação = Nothing
        Me.CaiuBanco.RegraValidaçãoMensagem = Nothing
        Me.CaiuBanco.Size = New System.Drawing.Size(31, 23)
        Me.CaiuBanco.TabIndex = 16
        Me.CaiuBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CaiuBanco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CaiuBanco.ValorPadrao = Nothing
        '
        'IdLancamento
        '
        Me.IdLancamento.AceitaColarTexto = True
        Me.IdLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IdLancamento.CasasDecimais = 0
        Me.IdLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdLancamento.CPObrigatorio = False
        Me.IdLancamento.CPObrigatorioMsg = Nothing
        Me.IdLancamento.Enabled = False
        Me.IdLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdLancamento.FlatBorder = False
        Me.IdLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdLancamento.FocusColor = System.Drawing.Color.MistyRose
        Me.IdLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdLancamento.HighlightBorderOnEnter = False
        Me.IdLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdLancamento.Location = New System.Drawing.Point(503, 440)
        Me.IdLancamento.Name = "IdLancamento"
        Me.IdLancamento.PreencherZeroEsqueda = False
        Me.IdLancamento.RegraValidação = Nothing
        Me.IdLancamento.RegraValidaçãoMensagem = Nothing
        Me.IdLancamento.Size = New System.Drawing.Size(49, 23)
        Me.IdLancamento.TabIndex = 18
        Me.IdLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdLancamento.ValorPadrao = Nothing
        Me.IdLancamento.Visible = False
        '
        'TravarDados
        '
        Me.TravarDados.BackColor = System.Drawing.Color.Transparent
        Me.TravarDados.Location = New System.Drawing.Point(295, 440)
        Me.TravarDados.Name = "TravarDados"
        Me.TravarDados.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TravarDados.Size = New System.Drawing.Size(164, 16)
        Me.TravarDados.TabIndex = 17
        Me.TravarDados.TabStop = False
        Me.TravarDados.Text = "Travar os Dados"
        Me.TravarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TravarDados.UseVisualStyleBackColor = False
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(467, 485)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(91, 29)
        Me.Fechar.TabIndex = 21
        Me.Fechar.Text = "Fechar"
        '
        'Salvar
        '
        Me.Salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Salvar.Location = New System.Drawing.Point(273, 485)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(91, 29)
        Me.Salvar.TabIndex = 19
        Me.Salvar.Text = "Salvar"
        '
        'Novo
        '
        Me.Novo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Novo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Novo.Location = New System.Drawing.Point(370, 485)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(91, 29)
        Me.Novo.TabIndex = 20
        Me.Novo.Text = "Novo"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.CodigoCaixa)
        Me.Fundo.Controls.Add(Me.LabelCaixa)
        Me.Fundo.Controls.Add(Me.PainelContaBalancete)
        Me.Fundo.Controls.Add(Me.GrupoCCTransf)
        Me.Fundo.Controls.Add(Me.GroupPanel2)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Novo)
        Me.Fundo.Controls.Add(Me.PreDatado)
        Me.Fundo.Controls.Add(Me.Salvar)
        Me.Fundo.Controls.Add(Me.DataPreDatado)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.TravarDados)
        Me.Fundo.Controls.Add(Me.DataLancamento)
        Me.Fundo.Controls.Add(Me.IdLancamento)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.CaiuBanco)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.Historico)
        Me.Fundo.Controls.Add(Me.CaixaDesc)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpNavigator(Me.Fundo, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.HelpProvider1.SetShowHelp(Me.Fundo, True)
        Me.Fundo.Size = New System.Drawing.Size(570, 526)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'CodigoCaixa
        '
        Me.CodigoCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.CodigoCaixa.AceitaColarTexto = True
        Me.CodigoCaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoCaixa.CasasDecimais = 0
        Me.CodigoCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoCaixa.CPObrigatorio = False
        Me.CodigoCaixa.CPObrigatorioMsg = Nothing
        Me.CodigoCaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoCaixa.FlatBorder = False
        Me.CodigoCaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoCaixa.FocusColor = System.Drawing.Color.Empty
        Me.CodigoCaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoCaixa.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoCaixa.HighlightBorderOnEnter = False
        Me.CodigoCaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoCaixa.Location = New System.Drawing.Point(494, 150)
        Me.CodigoCaixa.MaxLength = 4
        Me.CodigoCaixa.Name = "CodigoCaixa"
        Me.CodigoCaixa.PreencherZeroEsqueda = True
        Me.CodigoCaixa.RegraValidação = Nothing
        Me.CodigoCaixa.RegraValidaçãoMensagem = Nothing
        Me.CodigoCaixa.Size = New System.Drawing.Size(57, 24)
        Me.CodigoCaixa.TabIndex = 10
        Me.CodigoCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CodigoCaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoCaixa.ValorPadrao = Nothing
        Me.CodigoCaixa.Visible = False
        '
        'LabelCaixa
        '
        Me.LabelCaixa.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCaixa.Location = New System.Drawing.Point(299, 152)
        Me.LabelCaixa.Name = "LabelCaixa"
        Me.LabelCaixa.Size = New System.Drawing.Size(189, 19)
        Me.LabelCaixa.TabIndex = 9
        Me.LabelCaixa.Text = "Inf. o Caixa para Transfêrencia"
        Me.LabelCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelCaixa.Visible = False
        '
        'PainelContaBalancete
        '
        Me.PainelContaBalancete.Controls.Add(Me.btContaDespesaReceita)
        Me.PainelContaBalancete.Controls.Add(Me.ContaBalancete)
        Me.PainelContaBalancete.Controls.Add(Me.LabelDespesaReceita)
        Me.PainelContaBalancete.Controls.Add(Me.ContaBalanceteDesc)
        Me.PainelContaBalancete.Controls.Add(Me.btFindContaCentroCusto)
        Me.PainelContaBalancete.Controls.Add(Me.CentroCusto)
        Me.PainelContaBalancete.Controls.Add(Me.Label4)
        Me.PainelContaBalancete.Controls.Add(Me.CentroCustoDesc)
        Me.PainelContaBalancete.Location = New System.Drawing.Point(18, 369)
        Me.PainelContaBalancete.Name = "PainelContaBalancete"
        Me.PainelContaBalancete.Size = New System.Drawing.Size(541, 60)
        Me.PainelContaBalancete.TabIndex = 14
        '
        'btContaDespesaReceita
        '
        Me.btContaDespesaReceita.Image = CType(resources.GetObject("btContaDespesaReceita.Image"), System.Drawing.Image)
        Me.btContaDespesaReceita.Location = New System.Drawing.Point(220, 3)
        Me.btContaDespesaReceita.Name = "btContaDespesaReceita"
        Me.btContaDespesaReceita.Size = New System.Drawing.Size(20, 23)
        Me.btContaDespesaReceita.TabIndex = 2
        '
        'ContaBalancete
        '
        Me.ContaBalancete.AceitaColarTexto = True
        Me.ContaBalancete.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaBalancete.CasasDecimais = 0
        Me.ContaBalancete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaBalancete.CPObrigatorio = False
        Me.ContaBalancete.CPObrigatorioMsg = Nothing
        Me.ContaBalancete.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaBalancete.FlatBorder = False
        Me.ContaBalancete.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaBalancete.FocusColor = System.Drawing.Color.MistyRose
        Me.ContaBalancete.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaBalancete.HighlightBorderOnEnter = False
        Me.ContaBalancete.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaBalancete.Location = New System.Drawing.Point(151, 3)
        Me.ContaBalancete.MaxLength = 6
        Me.ContaBalancete.Name = "ContaBalancete"
        Me.ContaBalancete.PreencherZeroEsqueda = True
        Me.ContaBalancete.RegraValidação = Nothing
        Me.ContaBalancete.RegraValidaçãoMensagem = Nothing
        Me.ContaBalancete.Size = New System.Drawing.Size(68, 23)
        Me.ContaBalancete.TabIndex = 1
        Me.ContaBalancete.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaBalancete.ValorPadrao = Nothing
        '
        'LabelDespesaReceita
        '
        Me.LabelDespesaReceita.BackColor = System.Drawing.Color.Transparent
        Me.LabelDespesaReceita.Location = New System.Drawing.Point(0, 2)
        Me.LabelDespesaReceita.Name = "LabelDespesaReceita"
        Me.LabelDespesaReceita.Size = New System.Drawing.Size(142, 22)
        Me.LabelDespesaReceita.TabIndex = 0
        Me.LabelDespesaReceita.Text = "Despesa/Receita"
        Me.LabelDespesaReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaBalanceteDesc
        '
        Me.ContaBalanceteDesc.AceitaColarTexto = True
        Me.ContaBalanceteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaBalanceteDesc.CasasDecimais = 0
        Me.ContaBalanceteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaBalanceteDesc.CPObrigatorio = False
        Me.ContaBalanceteDesc.CPObrigatorioMsg = Nothing
        Me.ContaBalanceteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaBalanceteDesc.FlatBorder = False
        Me.ContaBalanceteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ContaBalanceteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaBalanceteDesc.HighlightBorderOnEnter = False
        Me.ContaBalanceteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteDesc.Location = New System.Drawing.Point(243, 3)
        Me.ContaBalanceteDesc.Name = "ContaBalanceteDesc"
        Me.ContaBalanceteDesc.PreencherZeroEsqueda = False
        Me.ContaBalanceteDesc.RegraValidação = Nothing
        Me.ContaBalanceteDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaBalanceteDesc.Size = New System.Drawing.Size(292, 23)
        Me.ContaBalanceteDesc.TabIndex = 3
        Me.ContaBalanceteDesc.TabStop = False
        Me.ContaBalanceteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaBalanceteDesc.ValorPadrao = Nothing
        '
        'btFindContaCentroCusto
        '
        Me.btFindContaCentroCusto.Image = CType(resources.GetObject("btFindContaCentroCusto.Image"), System.Drawing.Image)
        Me.btFindContaCentroCusto.Location = New System.Drawing.Point(220, 32)
        Me.btFindContaCentroCusto.Name = "btFindContaCentroCusto"
        Me.btFindContaCentroCusto.Size = New System.Drawing.Size(20, 23)
        Me.btFindContaCentroCusto.TabIndex = 6
        '
        'CentroCusto
        '
        Me.CentroCusto.AceitaColarTexto = True
        Me.CentroCusto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CentroCusto.CasasDecimais = 0
        Me.CentroCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CentroCusto.CPObrigatorio = False
        Me.CentroCusto.CPObrigatorioMsg = Nothing
        Me.CentroCusto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CentroCusto.FlatBorder = False
        Me.CentroCusto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CentroCusto.FocusColor = System.Drawing.Color.MistyRose
        Me.CentroCusto.FocusColorEnd = System.Drawing.Color.Empty
        Me.CentroCusto.HighlightBorderOnEnter = False
        Me.CentroCusto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CentroCusto.Location = New System.Drawing.Point(151, 32)
        Me.CentroCusto.MaxLength = 6
        Me.CentroCusto.Name = "CentroCusto"
        Me.CentroCusto.PreencherZeroEsqueda = True
        Me.CentroCusto.RegraValidação = Nothing
        Me.CentroCusto.RegraValidaçãoMensagem = Nothing
        Me.CentroCusto.Size = New System.Drawing.Size(68, 23)
        Me.CentroCusto.TabIndex = 5
        Me.CentroCusto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CentroCusto.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(-1, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Centro Custo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CentroCustoDesc
        '
        Me.CentroCustoDesc.AceitaColarTexto = True
        Me.CentroCustoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CentroCustoDesc.CasasDecimais = 0
        Me.CentroCustoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CentroCustoDesc.CPObrigatorio = False
        Me.CentroCustoDesc.CPObrigatorioMsg = Nothing
        Me.CentroCustoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CentroCustoDesc.FlatBorder = False
        Me.CentroCustoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CentroCustoDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.CentroCustoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.CentroCustoDesc.HighlightBorderOnEnter = False
        Me.CentroCustoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CentroCustoDesc.Location = New System.Drawing.Point(243, 32)
        Me.CentroCustoDesc.Name = "CentroCustoDesc"
        Me.CentroCustoDesc.PreencherZeroEsqueda = False
        Me.CentroCustoDesc.RegraValidação = Nothing
        Me.CentroCustoDesc.RegraValidaçãoMensagem = Nothing
        Me.CentroCustoDesc.Size = New System.Drawing.Size(292, 23)
        Me.CentroCustoDesc.TabIndex = 7
        Me.CentroCustoDesc.TabStop = False
        Me.CentroCustoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CentroCustoDesc.ValorPadrao = Nothing
        '
        'GrupoCCTransf
        '
        Me.GrupoCCTransf.CanvasColor = System.Drawing.SystemColors.Control
        Me.GrupoCCTransf.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GrupoCCTransf.Controls.Add(Me.ContaCorrenteTranferenciaDesc)
        Me.GrupoCCTransf.Controls.Add(Me.btFindCC)
        Me.GrupoCCTransf.Controls.Add(Me.ContaCorrenteTranferencia)
        Me.GrupoCCTransf.Location = New System.Drawing.Point(280, 72)
        Me.GrupoCCTransf.Name = "GrupoCCTransf"
        Me.GrupoCCTransf.Size = New System.Drawing.Size(273, 79)
        '
        '
        '
        Me.GrupoCCTransf.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GrupoCCTransf.Style.BackColorGradientAngle = 90
        Me.GrupoCCTransf.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GrupoCCTransf.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrupoCCTransf.Style.BorderBottomWidth = 1
        Me.GrupoCCTransf.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GrupoCCTransf.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrupoCCTransf.Style.BorderLeftWidth = 1
        Me.GrupoCCTransf.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrupoCCTransf.Style.BorderRightWidth = 1
        Me.GrupoCCTransf.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrupoCCTransf.Style.BorderTopWidth = 1
        Me.GrupoCCTransf.Style.Class = ""
        Me.GrupoCCTransf.Style.CornerDiameter = 4
        Me.GrupoCCTransf.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GrupoCCTransf.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GrupoCCTransf.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GrupoCCTransf.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GrupoCCTransf.StyleMouseDown.Class = ""
        Me.GrupoCCTransf.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GrupoCCTransf.StyleMouseOver.Class = ""
        Me.GrupoCCTransf.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GrupoCCTransf.TabIndex = 8
        Me.GrupoCCTransf.Text = "Informe a Conta para Fazer a Transferência"
        Me.GrupoCCTransf.Visible = False
        '
        'ContaCorrenteTranferenciaDesc
        '
        Me.ContaCorrenteTranferenciaDesc.AceitaColarTexto = True
        Me.ContaCorrenteTranferenciaDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaCorrenteTranferenciaDesc.CasasDecimais = 0
        Me.ContaCorrenteTranferenciaDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCorrenteTranferenciaDesc.CPObrigatorio = False
        Me.ContaCorrenteTranferenciaDesc.CPObrigatorioMsg = Nothing
        Me.ContaCorrenteTranferenciaDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCorrenteTranferenciaDesc.FlatBorder = False
        Me.ContaCorrenteTranferenciaDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCorrenteTranferenciaDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ContaCorrenteTranferenciaDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCorrenteTranferenciaDesc.HighlightBorderOnEnter = False
        Me.ContaCorrenteTranferenciaDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCorrenteTranferenciaDesc.Location = New System.Drawing.Point(3, 30)
        Me.ContaCorrenteTranferenciaDesc.Name = "ContaCorrenteTranferenciaDesc"
        Me.ContaCorrenteTranferenciaDesc.PreencherZeroEsqueda = False
        Me.ContaCorrenteTranferenciaDesc.RegraValidação = Nothing
        Me.ContaCorrenteTranferenciaDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaCorrenteTranferenciaDesc.Size = New System.Drawing.Size(261, 23)
        Me.ContaCorrenteTranferenciaDesc.TabIndex = 2
        Me.ContaCorrenteTranferenciaDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCorrenteTranferenciaDesc.ValorPadrao = Nothing
        '
        'btFindCC
        '
        Me.btFindCC.Image = CType(resources.GetObject("btFindCC.Image"), System.Drawing.Image)
        Me.btFindCC.Location = New System.Drawing.Point(78, 1)
        Me.btFindCC.Name = "btFindCC"
        Me.btFindCC.Size = New System.Drawing.Size(23, 23)
        Me.btFindCC.TabIndex = 1
        '
        'ContaCorrenteTranferencia
        '
        Me.ContaCorrenteTranferencia.AceitaColarTexto = True
        Me.ContaCorrenteTranferencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaCorrenteTranferencia.CasasDecimais = 0
        Me.ContaCorrenteTranferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCorrenteTranferencia.CPObrigatorio = False
        Me.ContaCorrenteTranferencia.CPObrigatorioMsg = Nothing
        Me.ContaCorrenteTranferencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCorrenteTranferencia.FlatBorder = False
        Me.ContaCorrenteTranferencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCorrenteTranferencia.FocusColor = System.Drawing.Color.MistyRose
        Me.ContaCorrenteTranferencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCorrenteTranferencia.HighlightBorderOnEnter = False
        Me.ContaCorrenteTranferencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCorrenteTranferencia.Location = New System.Drawing.Point(3, 1)
        Me.ContaCorrenteTranferencia.Name = "ContaCorrenteTranferencia"
        Me.ContaCorrenteTranferencia.PreencherZeroEsqueda = False
        Me.ContaCorrenteTranferencia.RegraValidação = Nothing
        Me.ContaCorrenteTranferencia.RegraValidaçãoMensagem = Nothing
        Me.ContaCorrenteTranferencia.Size = New System.Drawing.Size(72, 23)
        Me.ContaCorrenteTranferencia.TabIndex = 0
        Me.ContaCorrenteTranferencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCorrenteTranferencia.ValorPadrao = Nothing
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.A4)
        Me.GroupPanel2.Controls.Add(Me.A3)
        Me.GroupPanel2.Controls.Add(Me.A2)
        Me.GroupPanel2.Controls.Add(Me.A1)
        Me.GroupPanel2.Location = New System.Drawing.Point(9, 5)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(544, 61)
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
        Me.GroupPanel2.TabIndex = 0
        Me.GroupPanel2.Text = "Selecione o Tipo de Laçamento"
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(366, 6)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(122, 19)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Transf. para Caixa"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(230, 6)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(130, 19)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Transf. entre Contas"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(116, 6)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(108, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Lanç. de Crédito"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(6, 6)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(104, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Lanç. de Débito"
        Me.A1.UseVisualStyleBackColor = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Documento)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.DataDocumento)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.ValorDocumento)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.TipoLancamento)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Favorecido)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Location = New System.Drawing.Point(15, 195)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(544, 117)
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
        Me.GroupPanel1.TabIndex = 11
        Me.GroupPanel1.Text = "Informações do Cheque"
        '
        'CaixaDesc
        '
        Me.CaixaDesc.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaDesc.Location = New System.Drawing.Point(299, 171)
        Me.CaixaDesc.Name = "CaixaDesc"
        Me.CaixaDesc.Size = New System.Drawing.Size(252, 19)
        Me.CaixaDesc.TabIndex = 22
        Me.CaixaDesc.Text = "CaixaDesc"
        Me.CaixaDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CaixaDesc.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'BancoLançamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BancoLançamento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançamentos na Conta Corrente - T271"
        Me.MenuDataLancamento.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.PainelContaBalancete.ResumeLayout(False)
        Me.PainelContaBalancete.PerformLayout()
        Me.GrupoCCTransf.ResumeLayout(False)
        Me.GrupoCCTransf.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PreDatado As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataPreDatado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ValorDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TipoLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Favorecido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Historico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CaiuBanco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IdLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TravarDados As System.Windows.Forms.CheckBox
    Friend WithEvents MenuDataLancamento As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LiberarDataLançamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Salvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Novo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoCCTransf As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ContaCorrenteTranferenciaDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaCorrenteTranferencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CentroCustoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CentroCusto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PainelContaBalancete As System.Windows.Forms.Panel
    Friend WithEvents btFindContaCentroCusto As System.Windows.Forms.Label
    Friend WithEvents btFindCC As System.Windows.Forms.Label
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents CodigoCaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelCaixa As System.Windows.Forms.Label
    Friend WithEvents btContaDespesaReceita As System.Windows.Forms.Label
    Friend WithEvents ContaBalancete As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelDespesaReceita As System.Windows.Forms.Label
    Friend WithEvents ContaBalanceteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CaixaDesc As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
