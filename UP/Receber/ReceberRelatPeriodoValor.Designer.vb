<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceberRelatPeriodoValor
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
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Vlr1 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Vlr2 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btVisualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PainelPeriodo.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label9)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(12, 8)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(383, 28)
        Me.PainelPeriodo.TabIndex = 2
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
        Me.DataFinal.Location = New System.Drawing.Point(255, 3)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(116, 23)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(5, 3)
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
        Me.DataInicial.Location = New System.Drawing.Point(132, 3)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(116, 23)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(212, 3)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(53, 19)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Entre"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(139, 3)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(58, 19)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Menor"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(69, 3)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(56, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Maior"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(52, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Igual"
        Me.A1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'Vlr1
        '
        Me.Vlr1.AceitaColarTexto = True
        Me.Vlr1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr1.CasasDecimais = 2
        Me.Vlr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr1.CPObrigatorio = False
        Me.Vlr1.CPObrigatorioMsg = Nothing
        Me.Vlr1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr1.FlatBorder = False
        Me.Vlr1.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr1.FocusColor = System.Drawing.Color.Empty
        Me.Vlr1.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr1.HighlightBorderOnEnter = False
        Me.Vlr1.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vlr1.Location = New System.Drawing.Point(80, 99)
        Me.Vlr1.MaxLength = 10
        Me.Vlr1.Name = "Vlr1"
        Me.Vlr1.PreencherZeroEsqueda = False
        Me.Vlr1.RegraValidação = Nothing
        Me.Vlr1.RegraValidaçãoMensagem = Nothing
        Me.Vlr1.Size = New System.Drawing.Size(124, 23)
        Me.Vlr1.TabIndex = 5
        Me.Vlr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Vlr1.ValorPadrao = Nothing
        Me.Vlr1.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(212, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Valor 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Vlr2
        '
        Me.Vlr2.AceitaColarTexto = True
        Me.Vlr2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr2.CasasDecimais = 2
        Me.Vlr2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr2.CPObrigatorio = False
        Me.Vlr2.CPObrigatorioMsg = Nothing
        Me.Vlr2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr2.FlatBorder = False
        Me.Vlr2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr2.FocusColor = System.Drawing.Color.Empty
        Me.Vlr2.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr2.HighlightBorderOnEnter = False
        Me.Vlr2.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vlr2.Location = New System.Drawing.Point(279, 99)
        Me.Vlr2.MaxLength = 10
        Me.Vlr2.Name = "Vlr2"
        Me.Vlr2.PreencherZeroEsqueda = False
        Me.Vlr2.RegraValidação = Nothing
        Me.Vlr2.RegraValidaçãoMensagem = Nothing
        Me.Vlr2.Size = New System.Drawing.Size(116, 23)
        Me.Vlr2.TabIndex = 7
        Me.Vlr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Vlr2.ValorPadrao = Nothing
        Me.Vlr2.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btVisualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.PainelPeriodo)
        Me.Fundo.Controls.Add(Me.Vlr1)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Vlr2)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(409, 171)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 10
        '
        'btVisualizar
        '
        Me.btVisualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVisualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVisualizar.Location = New System.Drawing.Point(247, 139)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(71, 26)
        Me.btVisualizar.TabIndex = 12
        Me.btVisualizar.Text = "Visualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(324, 139)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(71, 26)
        Me.btFechar.TabIndex = 11
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 40)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(383, 53)
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
        Me.GroupPanel1.TabIndex = 10
        Me.GroupPanel1.Text = "Selecione uma das Opções"
        '
        'ReceberRelatPeriodoValor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(409, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReceberRelatPeriodoValor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Receber no Período e Valor - T066"
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Vlr1 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Vlr2 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btVisualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
End Class
