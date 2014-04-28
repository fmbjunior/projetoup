<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancoVisualizador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BancoVisualizador))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Codigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContaCorrente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Agencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Banco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btChequePre = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Lançamentos = New DevComponents.DotNetBar.ButtonX()
        Me.Compensar = New DevComponents.DotNetBar.ButtonX()
        Me.Extrato = New DevComponents.DotNetBar.ButtonX()
        Me.Localizar = New DevComponents.DotNetBar.ButtonX()
        Me.BTCC = New DevComponents.DotNetBar.ButtonX()
        Me.Painel = New System.Windows.Forms.Panel()
        Me.Visualizador = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VerMovimento = New DevComponents.DotNetBar.ButtonX()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindCC = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Painel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod C/C"
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
        Me.Codigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.Codigo.FlatBorder = False
        Me.Codigo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Codigo.FocusColor = System.Drawing.Color.MistyRose
        Me.Codigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Codigo.HighlightBorderOnEnter = False
        Me.Codigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Codigo.Location = New System.Drawing.Point(70, 14)
        Me.Codigo.MaxLength = 15
        Me.Codigo.Name = "Codigo"
        Me.Codigo.PreencherZeroEsqueda = False
        Me.Codigo.RegraValidação = Nothing
        Me.Codigo.RegraValidaçãoMensagem = Nothing
        Me.Codigo.Size = New System.Drawing.Size(62, 23)
        Me.Codigo.TabIndex = 1
        Me.Codigo.Text = "0"
        Me.Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Codigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Codigo.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "C/C"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaCorrente
        '
        Me.ContaCorrente.AceitaColarTexto = True
        Me.ContaCorrente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaCorrente.CasasDecimais = 0
        Me.ContaCorrente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCorrente.CPObrigatorio = False
        Me.ContaCorrente.CPObrigatorioMsg = Nothing
        Me.ContaCorrente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCorrente.FlatBorder = False
        Me.ContaCorrente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCorrente.FocusColor = System.Drawing.Color.MistyRose
        Me.ContaCorrente.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCorrente.HighlightBorderOnEnter = False
        Me.ContaCorrente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCorrente.Location = New System.Drawing.Point(70, 40)
        Me.ContaCorrente.Name = "ContaCorrente"
        Me.ContaCorrente.PreencherZeroEsqueda = False
        Me.ContaCorrente.RegraValidação = Nothing
        Me.ContaCorrente.RegraValidaçãoMensagem = Nothing
        Me.ContaCorrente.Size = New System.Drawing.Size(103, 23)
        Me.ContaCorrente.TabIndex = 4
        Me.ContaCorrente.TabStop = False
        Me.ContaCorrente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCorrente.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Agência"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Agencia
        '
        Me.Agencia.AceitaColarTexto = True
        Me.Agencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Agencia.CasasDecimais = 0
        Me.Agencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Agencia.CPObrigatorio = False
        Me.Agencia.CPObrigatorioMsg = Nothing
        Me.Agencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Agencia.FlatBorder = False
        Me.Agencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Agencia.FocusColor = System.Drawing.Color.MistyRose
        Me.Agencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Agencia.HighlightBorderOnEnter = False
        Me.Agencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Agencia.Location = New System.Drawing.Point(70, 69)
        Me.Agencia.Name = "Agencia"
        Me.Agencia.PreencherZeroEsqueda = False
        Me.Agencia.RegraValidação = Nothing
        Me.Agencia.RegraValidaçãoMensagem = Nothing
        Me.Agencia.Size = New System.Drawing.Size(103, 23)
        Me.Agencia.TabIndex = 6
        Me.Agencia.TabStop = False
        Me.Agencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Agencia.ValorPadrao = Nothing
        '
        'Banco
        '
        Me.Banco.AceitaColarTexto = True
        Me.Banco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Banco.CasasDecimais = 0
        Me.Banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Banco.CPObrigatorio = False
        Me.Banco.CPObrigatorioMsg = Nothing
        Me.Banco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Banco.FlatBorder = False
        Me.Banco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Banco.FocusColor = System.Drawing.Color.MistyRose
        Me.Banco.FocusColorEnd = System.Drawing.Color.Empty
        Me.Banco.HighlightBorderOnEnter = False
        Me.Banco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Banco.Location = New System.Drawing.Point(193, 69)
        Me.Banco.Name = "Banco"
        Me.Banco.PreencherZeroEsqueda = False
        Me.Banco.RegraValidação = Nothing
        Me.Banco.RegraValidaçãoMensagem = Nothing
        Me.Banco.Size = New System.Drawing.Size(281, 23)
        Me.Banco.TabIndex = 7
        Me.Banco.TabStop = False
        Me.Banco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Banco.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Panel3)
        Me.Fundo.Controls.Add(Me.Painel)
        Me.Fundo.Controls.Add(Me.Panel1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(994, 616)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btChequePre)
        Me.Panel3.Controls.Add(Me.Fechar)
        Me.Panel3.Controls.Add(Me.Lançamentos)
        Me.Panel3.Controls.Add(Me.Compensar)
        Me.Panel3.Controls.Add(Me.Extrato)
        Me.Panel3.Controls.Add(Me.Localizar)
        Me.Panel3.Controls.Add(Me.BTCC)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 580)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(994, 36)
        Me.Panel3.TabIndex = 19
        '
        'btChequePre
        '
        Me.btChequePre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btChequePre.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btChequePre.Location = New System.Drawing.Point(447, 4)
        Me.btChequePre.Name = "btChequePre"
        Me.btChequePre.Size = New System.Drawing.Size(82, 27)
        Me.btChequePre.TabIndex = 17
        Me.btChequePre.Text = "Cheques-pré"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(7, 3)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(82, 27)
        Me.Fechar.TabIndex = 12
        Me.Fechar.Text = "Fechar"
        '
        'Lançamentos
        '
        Me.Lançamentos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Lançamentos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Lançamentos.Location = New System.Drawing.Point(95, 3)
        Me.Lançamentos.Name = "Lançamentos"
        Me.Lançamentos.Size = New System.Drawing.Size(82, 27)
        Me.Lançamentos.TabIndex = 11
        Me.Lançamentos.Text = "Lançamentos"
        '
        'Compensar
        '
        Me.Compensar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Compensar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Compensar.Location = New System.Drawing.Point(535, 4)
        Me.Compensar.Name = "Compensar"
        Me.Compensar.Size = New System.Drawing.Size(82, 27)
        Me.Compensar.TabIndex = 16
        Me.Compensar.Text = "Compensar"
        '
        'Extrato
        '
        Me.Extrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Extrato.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Extrato.Location = New System.Drawing.Point(359, 4)
        Me.Extrato.Name = "Extrato"
        Me.Extrato.Size = New System.Drawing.Size(82, 27)
        Me.Extrato.TabIndex = 15
        Me.Extrato.Text = "Extratos"
        '
        'Localizar
        '
        Me.Localizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Localizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Localizar.Location = New System.Drawing.Point(183, 4)
        Me.Localizar.Name = "Localizar"
        Me.Localizar.Size = New System.Drawing.Size(82, 27)
        Me.Localizar.TabIndex = 13
        Me.Localizar.Text = "Localizar"
        '
        'BTCC
        '
        Me.BTCC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTCC.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTCC.Location = New System.Drawing.Point(271, 4)
        Me.BTCC.Name = "BTCC"
        Me.BTCC.Size = New System.Drawing.Size(82, 27)
        Me.BTCC.TabIndex = 14
        Me.BTCC.Text = "C/C"
        '
        'Painel
        '
        Me.Painel.Controls.Add(Me.Visualizador)
        Me.Painel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Painel.Location = New System.Drawing.Point(0, 103)
        Me.Painel.Name = "Painel"
        Me.Painel.Size = New System.Drawing.Size(994, 513)
        Me.Painel.TabIndex = 18
        '
        'Visualizador
        '
        Me.Visualizador.ActiveViewIndex = -1
        Me.Visualizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visualizador.Cursor = System.Windows.Forms.Cursors.Default
        Me.Visualizador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Visualizador.Location = New System.Drawing.Point(0, 0)
        Me.Visualizador.Name = "Visualizador"
        Me.Visualizador.Size = New System.Drawing.Size(994, 513)
        Me.Visualizador.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Codigo)
        Me.Panel1.Controls.Add(Me.VerMovimento)
        Me.Panel1.Controls.Add(Me.Banco)
        Me.Panel1.Controls.Add(Me.PainelPeriodo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Agencia)
        Me.Panel1.Controls.Add(Me.btFindCC)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ContaCorrente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 103)
        Me.Panel1.TabIndex = 17
        '
        'VerMovimento
        '
        Me.VerMovimento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.VerMovimento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.VerMovimento.Location = New System.Drawing.Point(849, 43)
        Me.VerMovimento.Name = "VerMovimento"
        Me.VerMovimento.Size = New System.Drawing.Size(129, 27)
        Me.VerMovimento.TabIndex = 9
        Me.VerMovimento.Text = "Mostrar Movimento"
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.Label9)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Location = New System.Drawing.Point(637, 9)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(341, 28)
        Me.PainelPeriodo.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Informe o Período"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 0
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FlatBorder = False
        Me.DataInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.HighlightBorderOnEnter = False
        Me.DataInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataInicial.Location = New System.Drawing.Point(131, 3)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(101, 23)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FlatBorder = False
        Me.DataFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.HighlightBorderOnEnter = False
        Me.DataFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataFinal.Location = New System.Drawing.Point(238, 3)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(101, 23)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'btFindCC
        '
        Me.btFindCC.Image = CType(resources.GetObject("btFindCC.Image"), System.Drawing.Image)
        Me.btFindCC.Location = New System.Drawing.Point(134, 14)
        Me.btFindCC.Name = "btFindCC"
        Me.btFindCC.Size = New System.Drawing.Size(23, 23)
        Me.btFindCC.TabIndex = 2
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'BancoVisualizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 616)
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.HelpProvider1.SetHelpKeyword(Me, "Conta Corrente")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "BancoVisualizador"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conta Corrente - T102"
        Me.Fundo.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Painel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Codigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContaCorrente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Agencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Banco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Lançamentos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Localizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTCC As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Extrato As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Compensar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFindCC As System.Windows.Forms.Label
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents VerMovimento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Painel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btChequePre As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Visualizador As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
