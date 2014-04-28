<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiaAbrirFechar
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btFecharCriar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.NovoDia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DiaAtual = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btFecharCriar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(452, 177)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btFecharCriar
        '
        Me.btFecharCriar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFecharCriar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFecharCriar.Location = New System.Drawing.Point(244, 138)
        Me.btFecharCriar.Name = "btFecharCriar"
        Me.btFecharCriar.Size = New System.Drawing.Size(105, 27)
        Me.btFecharCriar.TabIndex = 1
        Me.btFecharCriar.Text = "Fechar e Criar Dia"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(355, 138)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(85, 27)
        Me.btFechar.TabIndex = 2
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.NovoDia)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.DiaAtual)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(428, 70)
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
        Me.GroupPanel1.Text = "Informação do Dia"
        '
        'NovoDia
        '
        Me.NovoDia.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.NovoDia.AceitaColarTexto = True
        Me.NovoDia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NovoDia.CasasDecimais = 0
        Me.NovoDia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NovoDia.CPObrigatorio = False
        Me.NovoDia.CPObrigatorioMsg = Nothing
        Me.NovoDia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NovoDia.FlatBorder = False
        Me.NovoDia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NovoDia.FocusColor = System.Drawing.Color.Empty
        Me.NovoDia.FocusColorEnd = System.Drawing.Color.Empty
        Me.NovoDia.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NovoDia.HighlightBorderOnEnter = False
        Me.NovoDia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NovoDia.Location = New System.Drawing.Point(304, 8)
        Me.NovoDia.MaxLength = 10
        Me.NovoDia.Name = "NovoDia"
        Me.NovoDia.PreencherZeroEsqueda = False
        Me.NovoDia.RegraValidação = Nothing
        Me.NovoDia.RegraValidaçãoMensagem = Nothing
        Me.NovoDia.Size = New System.Drawing.Size(105, 24)
        Me.NovoDia.TabIndex = 3
        Me.NovoDia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.NovoDia.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Novo Dia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiaAtual
        '
        Me.DiaAtual.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DiaAtual.AceitaColarTexto = True
        Me.DiaAtual.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DiaAtual.CasasDecimais = 0
        Me.DiaAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiaAtual.CPObrigatorio = False
        Me.DiaAtual.CPObrigatorioMsg = Nothing
        Me.DiaAtual.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiaAtual.FlatBorder = False
        Me.DiaAtual.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DiaAtual.FocusColor = System.Drawing.Color.Empty
        Me.DiaAtual.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiaAtual.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiaAtual.HighlightBorderOnEnter = False
        Me.DiaAtual.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DiaAtual.Location = New System.Drawing.Point(93, 9)
        Me.DiaAtual.MaxLength = 10
        Me.DiaAtual.Name = "DiaAtual"
        Me.DiaAtual.PreencherZeroEsqueda = False
        Me.DiaAtual.RegraValidação = Nothing
        Me.DiaAtual.RegraValidaçãoMensagem = Nothing
        Me.DiaAtual.Size = New System.Drawing.Size(105, 24)
        Me.DiaAtual.TabIndex = 1
        Me.DiaAtual.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DiaAtual.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dia Atual"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'DiaAbrirFechar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 177)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "DiaAbrirFechar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abrir e Fechar o Dia - T134"
        Me.Fundo.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents NovoDia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DiaAtual As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFecharCriar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
