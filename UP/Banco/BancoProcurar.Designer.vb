<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancoProcurar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BancoProcurar))
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtProcurar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.IdLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ContaCorrenteTranferenciaDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ContaCorrenteTranferencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CaiuBanco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Historico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Favorecido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TipoLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ValorDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataPreDatado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PreDatado = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btNaoCompensar = New System.Windows.Forms.Label()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(8, 69)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(778, 181)
        Me.MyLista.TabIndex = 1
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Documento"
        Me.ColumnHeader3.Width = 85
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Valor"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 85
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Histórico"
        Me.ColumnHeader7.Width = 480
        '
        'TxtProcurar
        '
        Me.TxtProcurar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TxtProcurar.AceitaColarTexto = True
        Me.TxtProcurar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TxtProcurar.CasasDecimais = 0
        Me.TxtProcurar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcurar.CPObrigatorio = False
        Me.TxtProcurar.CPObrigatorioMsg = Nothing
        Me.TxtProcurar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TxtProcurar.FlatBorder = False
        Me.TxtProcurar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TxtProcurar.FocusColor = System.Drawing.Color.Empty
        Me.TxtProcurar.FocusColorEnd = System.Drawing.Color.Empty
        Me.TxtProcurar.HighlightBorderOnEnter = False
        Me.TxtProcurar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TxtProcurar.Location = New System.Drawing.Point(267, 4)
        Me.TxtProcurar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProcurar.Name = "TxtProcurar"
        Me.TxtProcurar.PreencherZeroEsqueda = False
        Me.TxtProcurar.RegraValidação = Nothing
        Me.TxtProcurar.RegraValidaçãoMensagem = Nothing
        Me.TxtProcurar.Size = New System.Drawing.Size(503, 23)
        Me.TxtProcurar.TabIndex = 3
        Me.TxtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcurar.ValorPadrao = Nothing
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(176, 4)
        Me.A3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(73, 19)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Histórico"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(108, 4)
        Me.A2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(52, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Valor"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 4)
        Me.A1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(81, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Documento"
        Me.A1.UseVisualStyleBackColor = True
        '
        'IdLancamento
        '
        Me.IdLancamento.AceitaColarTexto = True
        Me.IdLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.IdLancamento.Location = New System.Drawing.Point(236, 257)
        Me.IdLancamento.Name = "IdLancamento"
        Me.IdLancamento.PreencherZeroEsqueda = False
        Me.IdLancamento.RegraValidação = Nothing
        Me.IdLancamento.RegraValidaçãoMensagem = Nothing
        Me.IdLancamento.Size = New System.Drawing.Size(107, 23)
        Me.IdLancamento.TabIndex = 36
        Me.IdLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdLancamento.ValorPadrao = Nothing
        Me.IdLancamento.Visible = False
        '
        'ContaCorrenteTranferenciaDesc
        '
        Me.ContaCorrenteTranferenciaDesc.AceitaColarTexto = True
        Me.ContaCorrenteTranferenciaDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.ContaCorrenteTranferenciaDesc.Location = New System.Drawing.Point(252, 400)
        Me.ContaCorrenteTranferenciaDesc.Name = "ContaCorrenteTranferenciaDesc"
        Me.ContaCorrenteTranferenciaDesc.PreencherZeroEsqueda = False
        Me.ContaCorrenteTranferenciaDesc.RegraValidação = Nothing
        Me.ContaCorrenteTranferenciaDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaCorrenteTranferenciaDesc.Size = New System.Drawing.Size(313, 23)
        Me.ContaCorrenteTranferenciaDesc.TabIndex = 26
        Me.ContaCorrenteTranferenciaDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCorrenteTranferenciaDesc.ValorPadrao = Nothing
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(12, 400)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 19)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "C/C Tranferência"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaCorrenteTranferencia
        '
        Me.ContaCorrenteTranferencia.AceitaColarTexto = True
        Me.ContaCorrenteTranferencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.ContaCorrenteTranferencia.Location = New System.Drawing.Point(161, 400)
        Me.ContaCorrenteTranferencia.Name = "ContaCorrenteTranferencia"
        Me.ContaCorrenteTranferencia.PreencherZeroEsqueda = False
        Me.ContaCorrenteTranferencia.RegraValidação = Nothing
        Me.ContaCorrenteTranferencia.RegraValidaçãoMensagem = Nothing
        Me.ContaCorrenteTranferencia.Size = New System.Drawing.Size(83, 23)
        Me.ContaCorrenteTranferencia.TabIndex = 25
        Me.ContaCorrenteTranferencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCorrenteTranferencia.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(13, 508)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 19)
        Me.Label13.TabIndex = 34
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
        Me.CaiuBanco.Location = New System.Drawing.Point(161, 508)
        Me.CaiuBanco.Name = "CaiuBanco"
        Me.CaiuBanco.PreencherZeroEsqueda = False
        Me.CaiuBanco.RegraValidação = Nothing
        Me.CaiuBanco.RegraValidaçãoMensagem = Nothing
        Me.CaiuBanco.Size = New System.Drawing.Size(31, 23)
        Me.CaiuBanco.TabIndex = 35
        Me.CaiuBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CaiuBanco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CaiuBanco.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(12, 458)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 19)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Histórico"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Historico
        '
        Me.Historico.AceitaColarTexto = True
        Me.Historico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.Historico.Location = New System.Drawing.Point(161, 458)
        Me.Historico.Multiline = True
        Me.Historico.Name = "Historico"
        Me.Historico.PreencherZeroEsqueda = False
        Me.Historico.RegraValidação = Nothing
        Me.Historico.RegraValidaçãoMensagem = Nothing
        Me.Historico.Size = New System.Drawing.Size(404, 44)
        Me.Historico.TabIndex = 33
        Me.Historico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Historico.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(11, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 19)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Favorecido"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Favorecido
        '
        Me.Favorecido.AceitaColarTexto = True
        Me.Favorecido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
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
        Me.Favorecido.Location = New System.Drawing.Point(160, 429)
        Me.Favorecido.Name = "Favorecido"
        Me.Favorecido.PreencherZeroEsqueda = False
        Me.Favorecido.RegraValidação = Nothing
        Me.Favorecido.RegraValidaçãoMensagem = Nothing
        Me.Favorecido.Size = New System.Drawing.Size(404, 23)
        Me.Favorecido.TabIndex = 28
        Me.Favorecido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Favorecido.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(12, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 19)
        Me.Label9.TabIndex = 21
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
        Me.TipoLancamento.Location = New System.Drawing.Point(161, 370)
        Me.TipoLancamento.Name = "TipoLancamento"
        Me.TipoLancamento.PreencherZeroEsqueda = False
        Me.TipoLancamento.RegraValidação = Nothing
        Me.TipoLancamento.RegraValidaçãoMensagem = Nothing
        Me.TipoLancamento.Size = New System.Drawing.Size(23, 23)
        Me.TipoLancamento.TabIndex = 22
        Me.TipoLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TipoLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TipoLancamento.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(548, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Valor Documento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AceitaColarTexto = True
        Me.ValorDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorDocumento.CasasDecimais = 0
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
        Me.ValorDocumento.Location = New System.Drawing.Point(669, 340)
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.PreencherZeroEsqueda = False
        Me.ValorDocumento.RegraValidação = Nothing
        Me.ValorDocumento.RegraValidaçãoMensagem = Nothing
        Me.ValorDocumento.Size = New System.Drawing.Size(111, 23)
        Me.ValorDocumento.TabIndex = 20
        Me.ValorDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorDocumento.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(274, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Data Documento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.DataDocumento.FocusColor = System.Drawing.Color.MistyRose
        Me.DataDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataDocumento.HighlightBorderOnEnter = False
        Me.DataDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataDocumento.Location = New System.Drawing.Point(413, 341)
        Me.DataDocumento.MaxLength = 10
        Me.DataDocumento.Name = "DataDocumento"
        Me.DataDocumento.PreencherZeroEsqueda = False
        Me.DataDocumento.RegraValidação = Nothing
        Me.DataDocumento.RegraValidaçãoMensagem = Nothing
        Me.DataDocumento.Size = New System.Drawing.Size(109, 23)
        Me.DataDocumento.TabIndex = 18
        Me.DataDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataDocumento.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 19)
        Me.Label6.TabIndex = 15
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
        Me.Documento.Location = New System.Drawing.Point(161, 341)
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(83, 23)
        Me.Documento.TabIndex = 16
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(11, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data Lanç"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = True
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FlatBorder = False
        Me.DataLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataLancamento.FocusColor = System.Drawing.Color.MistyRose
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.HighlightBorderOnEnter = False
        Me.DataLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataLancamento.Location = New System.Drawing.Point(160, 286)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.PreencherZeroEsqueda = False
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(109, 23)
        Me.DataLancamento.TabIndex = 5
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(274, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Data do Pré-Datado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataPreDatado
        '
        Me.DataPreDatado.AceitaColarTexto = True
        Me.DataPreDatado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataPreDatado.CasasDecimais = 0
        Me.DataPreDatado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataPreDatado.CPObrigatorio = False
        Me.DataPreDatado.CPObrigatorioMsg = Nothing
        Me.DataPreDatado.Enabled = False
        Me.DataPreDatado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataPreDatado.FlatBorder = False
        Me.DataPreDatado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataPreDatado.FocusColor = System.Drawing.Color.MistyRose
        Me.DataPreDatado.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataPreDatado.HighlightBorderOnEnter = False
        Me.DataPreDatado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataPreDatado.Location = New System.Drawing.Point(413, 312)
        Me.DataPreDatado.MaxLength = 10
        Me.DataPreDatado.Name = "DataPreDatado"
        Me.DataPreDatado.PreencherZeroEsqueda = False
        Me.DataPreDatado.RegraValidação = Nothing
        Me.DataPreDatado.RegraValidaçãoMensagem = Nothing
        Me.DataPreDatado.Size = New System.Drawing.Size(94, 23)
        Me.DataPreDatado.TabIndex = 8
        Me.DataPreDatado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataPreDatado.ValorPadrao = Nothing
        '
        'PreDatado
        '
        Me.PreDatado.BackColor = System.Drawing.Color.Transparent
        Me.PreDatado.Enabled = False
        Me.PreDatado.Location = New System.Drawing.Point(12, 315)
        Me.PreDatado.Name = "PreDatado"
        Me.PreDatado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PreDatado.Size = New System.Drawing.Size(164, 16)
        Me.PreDatado.TabIndex = 6
        Me.PreDatado.Text = "Pré-Datado"
        Me.PreDatado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PreDatado.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 19)
        Me.Label1.TabIndex = 2
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
        Me.Id.Location = New System.Drawing.Point(160, 257)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(60, 23)
        Me.Id.TabIndex = 3
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btNaoCompensar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.IdLancamento)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.ContaCorrenteTranferenciaDesc)
        Me.Fundo.Controls.Add(Me.PreDatado)
        Me.Fundo.Controls.Add(Me.Label14)
        Me.Fundo.Controls.Add(Me.DataPreDatado)
        Me.Fundo.Controls.Add(Me.ContaCorrenteTranferencia)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.DataLancamento)
        Me.Fundo.Controls.Add(Me.CaiuBanco)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.Historico)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.Favorecido)
        Me.Fundo.Controls.Add(Me.Documento)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.DataDocumento)
        Me.Fundo.Controls.Add(Me.TipoLancamento)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.ValorDocumento)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpNavigator(Me.Fundo, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.HelpProvider1.SetShowHelp(Me.Fundo, True)
        Me.Fundo.Size = New System.Drawing.Size(794, 538)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(703, 506)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(83, 25)
        Me.btFechar.TabIndex = 41
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TxtProcurar)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Location = New System.Drawing.Point(7, 5)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(779, 57)
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
        Me.GroupPanel1.TabIndex = 40
        Me.GroupPanel1.Text = "Selecione uma das Opções"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'btNaoCompensar
        '
        Me.btNaoCompensar.BackColor = System.Drawing.Color.Transparent
        Me.btNaoCompensar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNaoCompensar.Image = CType(resources.GetObject("btNaoCompensar.Image"), System.Drawing.Image)
        Me.btNaoCompensar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNaoCompensar.Location = New System.Drawing.Point(198, 508)
        Me.btNaoCompensar.Name = "btNaoCompensar"
        Me.btNaoCompensar.Size = New System.Drawing.Size(61, 23)
        Me.btNaoCompensar.TabIndex = 42
        Me.btNaoCompensar.Text = "Voltar"
        Me.btNaoCompensar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BancoProcurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(794, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BancoProcurar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procura de Documentos no Banco - T098"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtProcurar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents IdLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaCorrenteTranferenciaDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ContaCorrenteTranferencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CaiuBanco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Historico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Favorecido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TipoLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ValorDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataPreDatado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PreDatado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btNaoCompensar As System.Windows.Forms.Label
End Class
