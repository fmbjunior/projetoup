<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoFormaPgtoAnexar
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboFormaPagamento = New CBOAutoCompleteFocus.CboFocus()
        Me.Acrescimo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Desconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodigoAnexo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.codigoTipo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pagamento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Acréscimo %"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Desconto %"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboFormaPagamento
        '
        Me.CboFormaPagamento.Auto_Complete = True
        Me.CboFormaPagamento.AutoLimitar_Lista = True
        Me.CboFormaPagamento.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.CboFormaPagamento.CPObrigatorio = False
        Me.CboFormaPagamento.CPObrigatorioMsg = Nothing
        Me.CboFormaPagamento.FlatBorder = False
        Me.CboFormaPagamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CboFormaPagamento.FormattingEnabled = True
        Me.CboFormaPagamento.HighlightBorderColor = System.Drawing.Color.Empty
        Me.CboFormaPagamento.HighlightBorderOnEnter = False
        Me.CboFormaPagamento.Location = New System.Drawing.Point(118, 16)
        Me.CboFormaPagamento.Name = "CboFormaPagamento"
        Me.CboFormaPagamento.Size = New System.Drawing.Size(240, 21)
        Me.CboFormaPagamento.TabIndex = 0
        '
        'Acrescimo
        '
        Me.Acrescimo.AceitaColarTexto = True
        Me.Acrescimo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Acrescimo.CasasDecimais = 4
        Me.Acrescimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Acrescimo.CPObrigatorio = False
        Me.Acrescimo.CPObrigatorioMsg = Nothing
        Me.Acrescimo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Acrescimo.FlatBorder = False
        Me.Acrescimo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Acrescimo.FocusColor = System.Drawing.Color.Empty
        Me.Acrescimo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Acrescimo.HighlightBorderOnEnter = False
        Me.Acrescimo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Acrescimo.Location = New System.Drawing.Point(118, 69)
        Me.Acrescimo.MaxLength = 15
        Me.Acrescimo.Name = "Acrescimo"
        Me.Acrescimo.PreencherZeroEsqueda = False
        Me.Acrescimo.RegraValidação = Nothing
        Me.Acrescimo.RegraValidaçãoMensagem = Nothing
        Me.Acrescimo.Size = New System.Drawing.Size(91, 20)
        Me.Acrescimo.TabIndex = 2
        Me.Acrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Acrescimo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Acrescimo.ValorPadrao = Nothing
        '
        'Desconto
        '
        Me.Desconto.AceitaColarTexto = True
        Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Desconto.CasasDecimais = 4
        Me.Desconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Desconto.CPObrigatorio = False
        Me.Desconto.CPObrigatorioMsg = Nothing
        Me.Desconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Desconto.FlatBorder = False
        Me.Desconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Desconto.FocusColor = System.Drawing.Color.Empty
        Me.Desconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desconto.HighlightBorderOnEnter = False
        Me.Desconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Desconto.Location = New System.Drawing.Point(118, 43)
        Me.Desconto.MaxLength = 15
        Me.Desconto.Name = "Desconto"
        Me.Desconto.PreencherZeroEsqueda = False
        Me.Desconto.RegraValidação = Nothing
        Me.Desconto.RegraValidaçãoMensagem = Nothing
        Me.Desconto.Size = New System.Drawing.Size(91, 20)
        Me.Desconto.TabIndex = 1
        Me.Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Desconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Desconto.ValorPadrao = Nothing
        '
        'CodigoAnexo
        '
        Me.CodigoAnexo.AceitaColarTexto = True
        Me.CodigoAnexo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoAnexo.CasasDecimais = 0
        Me.CodigoAnexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoAnexo.CPObrigatorio = False
        Me.CodigoAnexo.CPObrigatorioMsg = Nothing
        Me.CodigoAnexo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoAnexo.FlatBorder = False
        Me.CodigoAnexo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoAnexo.FocusColor = System.Drawing.Color.Empty
        Me.CodigoAnexo.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoAnexo.HighlightBorderOnEnter = False
        Me.CodigoAnexo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoAnexo.Location = New System.Drawing.Point(220, 233)
        Me.CodigoAnexo.MaxLength = 30
        Me.CodigoAnexo.Name = "CodigoAnexo"
        Me.CodigoAnexo.PreencherZeroEsqueda = False
        Me.CodigoAnexo.ReadOnly = True
        Me.CodigoAnexo.RegraValidação = Nothing
        Me.CodigoAnexo.RegraValidaçãoMensagem = Nothing
        Me.CodigoAnexo.Size = New System.Drawing.Size(91, 20)
        Me.CodigoAnexo.TabIndex = 5
        Me.CodigoAnexo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoAnexo.ValorPadrao = Nothing
        '
        'codigoTipo
        '
        Me.codigoTipo.AceitaColarTexto = True
        Me.codigoTipo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.codigoTipo.CasasDecimais = 0
        Me.codigoTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.codigoTipo.CPObrigatorio = False
        Me.codigoTipo.CPObrigatorioMsg = Nothing
        Me.codigoTipo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.codigoTipo.FlatBorder = False
        Me.codigoTipo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.codigoTipo.FocusColor = System.Drawing.Color.Empty
        Me.codigoTipo.FocusColorEnd = System.Drawing.Color.Empty
        Me.codigoTipo.HighlightBorderOnEnter = False
        Me.codigoTipo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.codigoTipo.Location = New System.Drawing.Point(115, 199)
        Me.codigoTipo.MaxLength = 15
        Me.codigoTipo.Name = "codigoTipo"
        Me.codigoTipo.PreencherZeroEsqueda = False
        Me.codigoTipo.RegraValidação = Nothing
        Me.codigoTipo.RegraValidaçãoMensagem = Nothing
        Me.codigoTipo.Size = New System.Drawing.Size(49, 20)
        Me.codigoTipo.TabIndex = 6
        Me.codigoTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.codigoTipo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.codigoTipo.ValorPadrao = Nothing
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(123, 107)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(99, 40)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 3
        Me.ButtonX1.Text = "Salvar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(228, 107)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(99, 40)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 7
        Me.ButtonX2.Text = "Fechar"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(403, 156)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 8
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'TipoFormaPgtoAnexar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 156)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.codigoTipo)
        Me.Controls.Add(Me.CboFormaPagamento)
        Me.Controls.Add(Me.Acrescimo)
        Me.Controls.Add(Me.Desconto)
        Me.Controls.Add(Me.CodigoAnexo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "TipoFormaPgtoAnexar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anexar Forma de Pgto - T045"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboFormaPagamento As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Acrescimo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Desconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoAnexo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents codigoTipo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
