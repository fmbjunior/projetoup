<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaixaFechar
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
        Me.DataCaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalCaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataCaixa
        '
        Me.DataCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataCaixa.AceitaColarTexto = True
        Me.DataCaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataCaixa.CasasDecimais = 0
        Me.DataCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataCaixa.CPObrigatorio = False
        Me.DataCaixa.CPObrigatorioMsg = Nothing
        Me.DataCaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataCaixa.FlatBorder = False
        Me.DataCaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataCaixa.FocusColor = System.Drawing.Color.Empty
        Me.DataCaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataCaixa.HighlightBorderOnEnter = False
        Me.DataCaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataCaixa.Location = New System.Drawing.Point(112, 17)
        Me.DataCaixa.MaxLength = 10
        Me.DataCaixa.Name = "DataCaixa"
        Me.DataCaixa.PreencherZeroEsqueda = False
        Me.DataCaixa.RegraValidação = Nothing
        Me.DataCaixa.RegraValidaçãoMensagem = Nothing
        Me.DataCaixa.Size = New System.Drawing.Size(143, 23)
        Me.DataCaixa.TabIndex = 1
        Me.DataCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataCaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataCaixa.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Data Dia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalCaixa
        '
        Me.TotalCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TotalCaixa.AceitaColarTexto = True
        Me.TotalCaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalCaixa.CasasDecimais = 2
        Me.TotalCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalCaixa.CPObrigatorio = False
        Me.TotalCaixa.CPObrigatorioMsg = Nothing
        Me.TotalCaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalCaixa.FlatBorder = False
        Me.TotalCaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalCaixa.FocusColor = System.Drawing.Color.Empty
        Me.TotalCaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalCaixa.HighlightBorderOnEnter = False
        Me.TotalCaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalCaixa.Location = New System.Drawing.Point(112, 46)
        Me.TotalCaixa.MaxLength = 10
        Me.TotalCaixa.Name = "TotalCaixa"
        Me.TotalCaixa.PreencherZeroEsqueda = False
        Me.TotalCaixa.RegraValidação = Nothing
        Me.TotalCaixa.RegraValidaçãoMensagem = Nothing
        Me.TotalCaixa.Size = New System.Drawing.Size(143, 23)
        Me.TotalCaixa.TabIndex = 3
        Me.TotalCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalCaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalCaixa.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Caixa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btAtualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.TotalCaixa)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.DataCaixa)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(267, 154)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Location = New System.Drawing.Point(73, 113)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(93, 29)
        Me.btAtualizar.TabIndex = 4
        Me.btAtualizar.Text = "Fechar o Caixa"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(172, 113)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(83, 29)
        Me.btFechar.TabIndex = 5
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'CaixaFechar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(267, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CaixaFechar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atualizar Dados do Caixa - T104"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataCaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalCaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
