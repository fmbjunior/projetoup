<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaixaTransferencia
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PainelBanco = New System.Windows.Forms.Panel()
        Me.BancoTransferir = New CBOAutoCompleteFocus.CboFocus()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValorTransferirBanco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PainelCaixa = New System.Windows.Forms.Panel()
        Me.CaixaTransferir = New CBOAutoCompleteFocus.CboFocus()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ValorTransferirCaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btTranferir = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.SaldoAtual = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.PainelBanco.SuspendLayout()
        Me.PainelCaixa.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PainelBanco)
        Me.PanelEx1.Controls.Add(Me.PainelCaixa)
        Me.PanelEx1.Controls.Add(Me.btTranferir)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpNavigator(Me.PanelEx1, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.HelpProvider1.SetShowHelp(Me.PanelEx1, True)
        Me.PanelEx1.Size = New System.Drawing.Size(491, 264)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PainelBanco
        '
        Me.PainelBanco.Controls.Add(Me.BancoTransferir)
        Me.PainelBanco.Controls.Add(Me.Label1)
        Me.PainelBanco.Controls.Add(Me.ValorTransferirBanco)
        Me.PainelBanco.Controls.Add(Me.Label2)
        Me.PainelBanco.Location = New System.Drawing.Point(6, 163)
        Me.PainelBanco.Name = "PainelBanco"
        Me.PainelBanco.Size = New System.Drawing.Size(473, 61)
        Me.PainelBanco.TabIndex = 2
        Me.PainelBanco.Visible = False
        '
        'BancoTransferir
        '
        Me.BancoTransferir.Auto_Complete = True
        Me.BancoTransferir.AutoLimitar_Lista = True
        Me.BancoTransferir.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.BancoTransferir.CPObrigatorio = False
        Me.BancoTransferir.CPObrigatorioMsg = Nothing
        Me.BancoTransferir.FlatBorder = False
        Me.BancoTransferir.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BancoTransferir.FormattingEnabled = True
        Me.BancoTransferir.HighlightBorderColor = System.Drawing.Color.Empty
        Me.BancoTransferir.HighlightBorderOnEnter = False
        Me.BancoTransferir.Location = New System.Drawing.Point(131, 3)
        Me.BancoTransferir.Name = "BancoTransferir"
        Me.BancoTransferir.Size = New System.Drawing.Size(339, 23)
        Me.BancoTransferir.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco Transferir"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorTransferirBanco
        '
        Me.ValorTransferirBanco.AceitaColarTexto = True
        Me.ValorTransferirBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorTransferirBanco.CasasDecimais = 2
        Me.ValorTransferirBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorTransferirBanco.CPObrigatorio = False
        Me.ValorTransferirBanco.CPObrigatorioMsg = Nothing
        Me.ValorTransferirBanco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorTransferirBanco.FlatBorder = False
        Me.ValorTransferirBanco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorTransferirBanco.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorTransferirBanco.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorTransferirBanco.HighlightBorderOnEnter = False
        Me.ValorTransferirBanco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorTransferirBanco.Location = New System.Drawing.Point(131, 32)
        Me.ValorTransferirBanco.MaxLength = 15
        Me.ValorTransferirBanco.Name = "ValorTransferirBanco"
        Me.ValorTransferirBanco.PreencherZeroEsqueda = False
        Me.ValorTransferirBanco.RegraValidação = Nothing
        Me.ValorTransferirBanco.RegraValidaçãoMensagem = Nothing
        Me.ValorTransferirBanco.Size = New System.Drawing.Size(143, 23)
        Me.ValorTransferirBanco.TabIndex = 3
        Me.ValorTransferirBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorTransferirBanco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.ValorTransferirBanco.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor a Transferir"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PainelCaixa
        '
        Me.PainelCaixa.Controls.Add(Me.CaixaTransferir)
        Me.PainelCaixa.Controls.Add(Me.Label12)
        Me.PainelCaixa.Controls.Add(Me.ValorTransferirCaixa)
        Me.PainelCaixa.Controls.Add(Me.Label28)
        Me.PainelCaixa.Location = New System.Drawing.Point(6, 96)
        Me.PainelCaixa.Name = "PainelCaixa"
        Me.PainelCaixa.Size = New System.Drawing.Size(473, 61)
        Me.PainelCaixa.TabIndex = 1
        '
        'CaixaTransferir
        '
        Me.CaixaTransferir.Auto_Complete = True
        Me.CaixaTransferir.AutoLimitar_Lista = True
        Me.CaixaTransferir.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.CaixaTransferir.CPObrigatorio = False
        Me.CaixaTransferir.CPObrigatorioMsg = Nothing
        Me.CaixaTransferir.FlatBorder = False
        Me.CaixaTransferir.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CaixaTransferir.FormattingEnabled = True
        Me.CaixaTransferir.HighlightBorderColor = System.Drawing.Color.Empty
        Me.CaixaTransferir.HighlightBorderOnEnter = False
        Me.CaixaTransferir.Location = New System.Drawing.Point(131, 3)
        Me.CaixaTransferir.Name = "CaixaTransferir"
        Me.CaixaTransferir.Size = New System.Drawing.Size(339, 23)
        Me.CaixaTransferir.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(5, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Caixa Transferir"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorTransferirCaixa
        '
        Me.ValorTransferirCaixa.AceitaColarTexto = True
        Me.ValorTransferirCaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorTransferirCaixa.CasasDecimais = 2
        Me.ValorTransferirCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorTransferirCaixa.CPObrigatorio = False
        Me.ValorTransferirCaixa.CPObrigatorioMsg = Nothing
        Me.ValorTransferirCaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorTransferirCaixa.FlatBorder = False
        Me.ValorTransferirCaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorTransferirCaixa.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorTransferirCaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorTransferirCaixa.HighlightBorderOnEnter = False
        Me.ValorTransferirCaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorTransferirCaixa.Location = New System.Drawing.Point(131, 32)
        Me.ValorTransferirCaixa.MaxLength = 15
        Me.ValorTransferirCaixa.Name = "ValorTransferirCaixa"
        Me.ValorTransferirCaixa.PreencherZeroEsqueda = False
        Me.ValorTransferirCaixa.RegraValidação = Nothing
        Me.ValorTransferirCaixa.RegraValidaçãoMensagem = Nothing
        Me.ValorTransferirCaixa.Size = New System.Drawing.Size(143, 23)
        Me.ValorTransferirCaixa.TabIndex = 3
        Me.ValorTransferirCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorTransferirCaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.ValorTransferirCaixa.ValorPadrao = Nothing
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(8, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(109, 19)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Valor a Transferir"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btTranferir
        '
        Me.btTranferir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTranferir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btTranferir.Location = New System.Drawing.Point(303, 230)
        Me.btTranferir.Name = "btTranferir"
        Me.btTranferir.Size = New System.Drawing.Size(91, 27)
        Me.btTranferir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btTranferir.TabIndex = 3
        Me.btTranferir.Text = "Transferir"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.SaldoAtual)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(465, 78)
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
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Informe o tipo de Transferência"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(123, 17)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(115, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Caixa para Banco"
        Me.A2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(323, -4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total do Caixa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 17)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(114, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Caixa para Caixa"
        Me.A1.UseVisualStyleBackColor = True
        '
        'SaldoAtual
        '
        Me.SaldoAtual.AceitaColarTexto = True
        Me.SaldoAtual.BackColor = System.Drawing.Color.White
        Me.SaldoAtual.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SaldoAtual.CasasDecimais = 2
        Me.SaldoAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SaldoAtual.CPObrigatorio = False
        Me.SaldoAtual.CPObrigatorioMsg = Nothing
        Me.SaldoAtual.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SaldoAtual.FlatBorder = False
        Me.SaldoAtual.FlatBorderColor = System.Drawing.Color.DimGray
        Me.SaldoAtual.FocusColor = System.Drawing.Color.Empty
        Me.SaldoAtual.FocusColorEnd = System.Drawing.Color.Empty
        Me.SaldoAtual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoAtual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaldoAtual.HighlightBorderOnEnter = False
        Me.SaldoAtual.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.SaldoAtual.Location = New System.Drawing.Point(321, 25)
        Me.SaldoAtual.MaxLength = 10
        Me.SaldoAtual.Name = "SaldoAtual"
        Me.SaldoAtual.PreencherZeroEsqueda = False
        Me.SaldoAtual.RegraValidação = Nothing
        Me.SaldoAtual.RegraValidaçãoMensagem = Nothing
        Me.SaldoAtual.Size = New System.Drawing.Size(135, 26)
        Me.SaldoAtual.TabIndex = 3
        Me.SaldoAtual.TabStop = False
        Me.SaldoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SaldoAtual.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SaldoAtual.ValorPadrao = Nothing
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(400, 230)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(77, 27)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'CaixaTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CaixaTransferencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferência de Valor  - T109"
        Me.PanelEx1.ResumeLayout(False)
        Me.PainelBanco.ResumeLayout(False)
        Me.PainelBanco.PerformLayout()
        Me.PainelCaixa.ResumeLayout(False)
        Me.PainelCaixa.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaldoAtual As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents CaixaTransferir As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ValorTransferirCaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btTranferir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PainelCaixa As System.Windows.Forms.Panel
    Friend WithEvents PainelBanco As System.Windows.Forms.Panel
    Friend WithEvents BancoTransferir As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ValorTransferirBanco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
