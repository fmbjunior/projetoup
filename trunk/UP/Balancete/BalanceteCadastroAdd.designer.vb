<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceteCadastroAdd
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Conta = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.cTIPO = New CBOAutoCompleteFocus.CboFocus()
        Me.cIntegracaoLabel = New System.Windows.Forms.Label()
        Me.cIntegracao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição da Conta"
        '
        'Descricao
        '
        Me.Descricao.AceitaColarTexto = True
        Me.Descricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Descricao.CasasDecimais = 0
        Me.Descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descricao.CPObrigatorio = False
        Me.Descricao.CPObrigatorioMsg = Nothing
        Me.Descricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Descricao.FlatBorder = False
        Me.Descricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Descricao.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Descricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descricao.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Descricao.HighlightBorderOnEnter = False
        Me.Descricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Descricao.Location = New System.Drawing.Point(12, 34)
        Me.Descricao.MaxLength = 50
        Me.Descricao.Name = "Descricao"
        Me.Descricao.PreencherZeroEsqueda = False
        Me.Descricao.RegraValidação = Nothing
        Me.Descricao.RegraValidaçãoMensagem = Nothing
        Me.Descricao.Size = New System.Drawing.Size(315, 23)
        Me.Descricao.TabIndex = 2
        Me.Descricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descricao.ValorPadrao = Nothing
        '
        'Conta
        '
        Me.Conta.AceitaColarTexto = True
        Me.Conta.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta.CasasDecimais = 2
        Me.Conta.CPObrigatorio = False
        Me.Conta.CPObrigatorioMsg = Nothing
        Me.Conta.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta.FlatBorder = False
        Me.Conta.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta.FocusColor = System.Drawing.Color.Empty
        Me.Conta.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Conta.HighlightBorderOnEnter = False
        Me.Conta.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Conta.Location = New System.Drawing.Point(246, 78)
        Me.Conta.Name = "Conta"
        Me.Conta.PreencherZeroEsqueda = False
        Me.Conta.RegraValidação = Nothing
        Me.Conta.RegraValidaçãoMensagem = Nothing
        Me.Conta.Size = New System.Drawing.Size(81, 23)
        Me.Conta.TabIndex = 7
        Me.Conta.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta.ValorPadrao = Nothing
        Me.Conta.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.cTIPO)
        Me.Fundo.Controls.Add(Me.cIntegracaoLabel)
        Me.Fundo.Controls.Add(Me.cIntegracao)
        Me.Fundo.Controls.Add(Me.btConfirmar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Descricao)
        Me.Fundo.Controls.Add(Me.Conta)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(345, 221)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'cTIPO
        '
        Me.cTIPO.Auto_Complete = True
        Me.cTIPO.AutoLimitar_Lista = True
        Me.cTIPO.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cTIPO.CPObrigatorio = False
        Me.cTIPO.CPObrigatorioMsg = Nothing
        Me.cTIPO.FlatBorder = False
        Me.cTIPO.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cTIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cTIPO.FormattingEnabled = True
        Me.cTIPO.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cTIPO.HighlightBorderOnEnter = False
        Me.cTIPO.Items.AddRange(New Object() {"CREDITO", "DEBITO"})
        Me.cTIPO.Location = New System.Drawing.Point(13, 80)
        Me.cTIPO.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cTIPO.Name = "cTIPO"
        Me.cTIPO.Size = New System.Drawing.Size(115, 21)
        Me.cTIPO.TabIndex = 3
        '
        'cIntegracaoLabel
        '
        Me.cIntegracaoLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.cIntegracaoLabel.Location = New System.Drawing.Point(12, 104)
        Me.cIntegracaoLabel.Name = "cIntegracaoLabel"
        Me.cIntegracaoLabel.Size = New System.Drawing.Size(128, 17)
        Me.cIntegracaoLabel.TabIndex = 8
        Me.cIntegracaoLabel.Text = "Codigo de Integração"
        '
        'cIntegracao
        '
        Me.cIntegracao.AceitaColarTexto = True
        Me.cIntegracao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.cIntegracao.CasasDecimais = 0
        Me.cIntegracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cIntegracao.CPObrigatorio = False
        Me.cIntegracao.CPObrigatorioMsg = Nothing
        Me.cIntegracao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.cIntegracao.FlatBorder = False
        Me.cIntegracao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cIntegracao.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cIntegracao.FocusColorEnd = System.Drawing.Color.Empty
        Me.cIntegracao.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.cIntegracao.HighlightBorderOnEnter = False
        Me.cIntegracao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.cIntegracao.Location = New System.Drawing.Point(12, 124)
        Me.cIntegracao.MaxLength = 14
        Me.cIntegracao.Name = "cIntegracao"
        Me.cIntegracao.PreencherZeroEsqueda = False
        Me.cIntegracao.RegraValidação = Nothing
        Me.cIntegracao.RegraValidaçãoMensagem = Nothing
        Me.cIntegracao.Size = New System.Drawing.Size(315, 23)
        Me.cIntegracao.TabIndex = 4
        Me.cIntegracao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.cIntegracao.ValorPadrao = Nothing
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(171, 182)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btConfirmar.TabIndex = 5
        Me.btConfirmar.Text = "Confirmar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(252, 182)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 6
        Me.btFechar.Text = "Fechar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de conta"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'BalanceteCadastroAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Name = "BalanceteCadastroAdd"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Contas Balancete - T092"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Descricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Conta As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cIntegracaoLabel As System.Windows.Forms.Label
    Friend WithEvents cIntegracao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents cTIPO As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
