<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgendaServicoAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgendaServicoAdd))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Usuario = New CBOAutoCompleteFocus.CboFocus()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btFinalizado = New DevComponents.DotNetBar.ButtonX()
        Me.HorasCompromisso = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btEmAndamento = New DevComponents.DotNetBar.ButtonX()
        Me.btCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btEditar = New DevComponents.DotNetBar.ButtonX()
        Me.Status = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.DiasAntecipadoAvisar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataAgenda = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Compromisso = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btFindClintes = New System.Windows.Forms.Label()
        Me.AddTodos = New System.Windows.Forms.CheckBox()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.AddTodos)
        Me.PanelEx1.Controls.Add(Me.Usuario)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.btFinalizado)
        Me.PanelEx1.Controls.Add(Me.HorasCompromisso)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.btEmAndamento)
        Me.PanelEx1.Controls.Add(Me.btCancelar)
        Me.PanelEx1.Controls.Add(Me.btEditar)
        Me.PanelEx1.Controls.Add(Me.Status)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.DiasAntecipadoAvisar)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.DataAgenda)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.ClienteDesc)
        Me.PanelEx1.Controls.Add(Me.Compromisso)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.DataLancamento)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Cliente)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.btFindClintes)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(639, 407)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Usuario
        '
        Me.Usuario.Auto_Complete = True
        Me.Usuario.AutoLimitar_Lista = False
        Me.Usuario.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.Usuario.CPObrigatorio = False
        Me.Usuario.CPObrigatorioMsg = Nothing
        Me.Usuario.FlatBorder = True
        Me.Usuario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Usuario.FormattingEnabled = True
        Me.Usuario.HighlightBorderColor = System.Drawing.Color.Empty
        Me.Usuario.HighlightBorderOnEnter = False
        Me.Usuario.Location = New System.Drawing.Point(121, 146)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(277, 23)
        Me.Usuario.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(14, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Usuário"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFinalizado
        '
        Me.btFinalizado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFinalizado.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFinalizado.Location = New System.Drawing.Point(51, 372)
        Me.btFinalizado.Name = "btFinalizado"
        Me.btFinalizado.Size = New System.Drawing.Size(82, 23)
        Me.btFinalizado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFinalizado.TabIndex = 26
        Me.btFinalizado.Text = "Finalizado"
        '
        'HorasCompromisso
        '
        Me.HorasCompromisso.AceitaColarTexto = False
        Me.HorasCompromisso.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.HorasCompromisso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HorasCompromisso.CasasDecimais = 0
        Me.HorasCompromisso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HorasCompromisso.CPObrigatorio = False
        Me.HorasCompromisso.CPObrigatorioMsg = Nothing
        Me.HorasCompromisso.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.HorasCompromisso.FlatBorder = True
        Me.HorasCompromisso.FlatBorderColor = System.Drawing.Color.Black
        Me.HorasCompromisso.FocusColor = System.Drawing.Color.MistyRose
        Me.HorasCompromisso.FocusColorEnd = System.Drawing.Color.Empty
        Me.HorasCompromisso.HighlightBorderOnEnter = False
        Me.HorasCompromisso.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.HorasCompromisso.Location = New System.Drawing.Point(121, 117)
        Me.HorasCompromisso.MaxLength = 8
        Me.HorasCompromisso.Name = "HorasCompromisso"
        Me.HorasCompromisso.PreencherZeroEsqueda = False
        Me.HorasCompromisso.RegraValidação = Nothing
        Me.HorasCompromisso.RegraValidaçãoMensagem = Nothing
        Me.HorasCompromisso.Size = New System.Drawing.Size(92, 23)
        Me.HorasCompromisso.TabIndex = 13
        Me.HorasCompromisso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HorasCompromisso.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Hora
        Me.HorasCompromisso.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Horas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btEmAndamento
        '
        Me.btEmAndamento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEmAndamento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEmAndamento.Location = New System.Drawing.Point(139, 372)
        Me.btEmAndamento.Name = "btEmAndamento"
        Me.btEmAndamento.Size = New System.Drawing.Size(82, 23)
        Me.btEmAndamento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEmAndamento.TabIndex = 25
        Me.btEmAndamento.Text = "Em Andamento"
        '
        'btCancelar
        '
        Me.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCancelar.Location = New System.Drawing.Point(227, 372)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btCancelar.TabIndex = 24
        Me.btCancelar.Text = "Cancelar"
        '
        'btEditar
        '
        Me.btEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEditar.Location = New System.Drawing.Point(308, 372)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(75, 23)
        Me.btEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEditar.TabIndex = 22
        Me.btEditar.Text = "Editar"
        '
        'Status
        '
        Me.Status.AceitaColarTexto = False
        Me.Status.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Status.CasasDecimais = 0
        Me.Status.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Status.CPObrigatorio = False
        Me.Status.CPObrigatorioMsg = Nothing
        Me.Status.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Status.FlatBorder = True
        Me.Status.FlatBorderColor = System.Drawing.Color.Black
        Me.Status.FocusColor = System.Drawing.Color.MistyRose
        Me.Status.FocusColorEnd = System.Drawing.Color.Empty
        Me.Status.HighlightBorderOnEnter = False
        Me.Status.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Status.Location = New System.Drawing.Point(500, 117)
        Me.Status.MaxLength = 15
        Me.Status.Name = "Status"
        Me.Status.PreencherZeroEsqueda = False
        Me.Status.RegraValidação = Nothing
        Me.Status.RegraValidaçãoMensagem = Nothing
        Me.Status.ShortcutsEnabled = False
        Me.Status.Size = New System.Drawing.Size(126, 23)
        Me.Status.TabIndex = 15
        Me.Status.TabStop = False
        Me.Status.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Status.ValorPadrao = Nothing
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(389, 372)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 21
        Me.btSalvar.Text = "Salvar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(470, 372)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(75, 23)
        Me.btNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNovo.TabIndex = 23
        Me.btNovo.Text = "Novo"
        '
        'DiasAntecipadoAvisar
        '
        Me.DiasAntecipadoAvisar.AceitaColarTexto = False
        Me.DiasAntecipadoAvisar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DiasAntecipadoAvisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiasAntecipadoAvisar.CasasDecimais = 0
        Me.DiasAntecipadoAvisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiasAntecipadoAvisar.CPObrigatorio = False
        Me.DiasAntecipadoAvisar.CPObrigatorioMsg = Nothing
        Me.DiasAntecipadoAvisar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiasAntecipadoAvisar.FlatBorder = True
        Me.DiasAntecipadoAvisar.FlatBorderColor = System.Drawing.Color.Black
        Me.DiasAntecipadoAvisar.FocusColor = System.Drawing.Color.MistyRose
        Me.DiasAntecipadoAvisar.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiasAntecipadoAvisar.HighlightBorderOnEnter = False
        Me.DiasAntecipadoAvisar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DiasAntecipadoAvisar.Location = New System.Drawing.Point(534, 88)
        Me.DiasAntecipadoAvisar.MaxLength = 15
        Me.DiasAntecipadoAvisar.Name = "DiasAntecipadoAvisar"
        Me.DiasAntecipadoAvisar.PreencherZeroEsqueda = False
        Me.DiasAntecipadoAvisar.RegraValidação = Nothing
        Me.DiasAntecipadoAvisar.RegraValidaçãoMensagem = Nothing
        Me.DiasAntecipadoAvisar.Size = New System.Drawing.Size(92, 23)
        Me.DiasAntecipadoAvisar.TabIndex = 11
        Me.DiasAntecipadoAvisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DiasAntecipadoAvisar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.DiasAntecipadoAvisar.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(392, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Status"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(389, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Antecipar Aviso em dias"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataAgenda
        '
        Me.DataAgenda.AceitaColarTexto = False
        Me.DataAgenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataAgenda.CasasDecimais = 0
        Me.DataAgenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataAgenda.CPObrigatorio = False
        Me.DataAgenda.CPObrigatorioMsg = Nothing
        Me.DataAgenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataAgenda.FlatBorder = True
        Me.DataAgenda.FlatBorderColor = System.Drawing.Color.Black
        Me.DataAgenda.FocusColor = System.Drawing.Color.MistyRose
        Me.DataAgenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataAgenda.HighlightBorderOnEnter = False
        Me.DataAgenda.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataAgenda.Location = New System.Drawing.Point(121, 88)
        Me.DataAgenda.MaxLength = 10
        Me.DataAgenda.Name = "DataAgenda"
        Me.DataAgenda.PreencherZeroEsqueda = False
        Me.DataAgenda.RegraValidação = Nothing
        Me.DataAgenda.RegraValidaçãoMensagem = Nothing
        Me.DataAgenda.Size = New System.Drawing.Size(92, 23)
        Me.DataAgenda.TabIndex = 9
        Me.DataAgenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataAgenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataAgenda.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Agendar P/ Data"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = False
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ClienteDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteDesc.FlatBorder = True
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.Black
        Me.ClienteDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(212, 59)
        Me.ClienteDesc.MaxLength = 100
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(414, 23)
        Me.ClienteDesc.TabIndex = 7
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'Compromisso
        '
        Me.Compromisso.AceitaColarTexto = True
        Me.Compromisso.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Compromisso.CasasDecimais = 0
        Me.Compromisso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Compromisso.CPObrigatorio = False
        Me.Compromisso.CPObrigatorioMsg = Nothing
        Me.Compromisso.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Compromisso.FlatBorder = False
        Me.Compromisso.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Compromisso.FocusColor = System.Drawing.Color.MistyRose
        Me.Compromisso.FocusColorEnd = System.Drawing.Color.Empty
        Me.Compromisso.HighlightBorderOnEnter = False
        Me.Compromisso.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Compromisso.Location = New System.Drawing.Point(17, 191)
        Me.Compromisso.MaxLength = 20000
        Me.Compromisso.Multiline = True
        Me.Compromisso.Name = "Compromisso"
        Me.Compromisso.PreencherZeroEsqueda = False
        Me.Compromisso.RegraValidação = Nothing
        Me.Compromisso.RegraValidaçãoMensagem = Nothing
        Me.Compromisso.Size = New System.Drawing.Size(609, 175)
        Me.Compromisso.TabIndex = 20
        Me.Compromisso.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Compromisso.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(17, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Compromisso"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = False
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FlatBorder = True
        Me.DataLancamento.FlatBorderColor = System.Drawing.Color.Black
        Me.DataLancamento.FocusColor = System.Drawing.Color.MistyRose
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.HighlightBorderOnEnter = False
        Me.DataLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataLancamento.Location = New System.Drawing.Point(534, 29)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.PreencherZeroEsqueda = False
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(92, 23)
        Me.DataLancamento.TabIndex = 3
        Me.DataLancamento.TabStop = False
        Me.DataLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(392, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data de Lançamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = True
        Me.Id.FlatBorderColor = System.Drawing.Color.Black
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(121, 30)
        Me.Id.MaxLength = 15
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(69, 23)
        Me.Id.TabIndex = 1
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Id.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = False
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = True
        Me.Cliente.FlatBorderColor = System.Drawing.Color.Black
        Me.Cliente.FocusColor = System.Drawing.Color.MistyRose
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(121, 59)
        Me.Cliente.MaxLength = 15
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(69, 23)
        Me.Cliente.TabIndex = 5
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(14, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(551, 372)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 27
        Me.btFechar.Text = "Fechar"
        '
        'btFindClintes
        '
        Me.btFindClintes.Image = CType(resources.GetObject("btFindClintes.Image"), System.Drawing.Image)
        Me.btFindClintes.Location = New System.Drawing.Point(190, 59)
        Me.btFindClintes.Name = "btFindClintes"
        Me.btFindClintes.Size = New System.Drawing.Size(23, 23)
        Me.btFindClintes.TabIndex = 6
        '
        'AddTodos
        '
        Me.AddTodos.AutoSize = True
        Me.AddTodos.Location = New System.Drawing.Point(404, 150)
        Me.AddTodos.Name = "AddTodos"
        Me.AddTodos.Size = New System.Drawing.Size(184, 19)
        Me.AddTodos.TabIndex = 18
        Me.AddTodos.Text = "Adicionar para Todos Usuários"
        Me.AddTodos.UseVisualStyleBackColor = True
        '
        'AgendaServicoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 407)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AgendaServicoAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda de Serviço - T218"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Compromisso As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btFindClintes As System.Windows.Forms.Label
    Friend WithEvents DiasAntecipadoAvisar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataAgenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Status As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btEmAndamento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HorasCompromisso As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btFinalizado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Usuario As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AddTodos As System.Windows.Forms.CheckBox
End Class
