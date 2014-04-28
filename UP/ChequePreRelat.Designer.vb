<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChequePreRelat
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
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelEntreguePor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EntreguePor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btVisualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PainelPeriodo.SuspendLayout()
        Me.PainelEntreguePor.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.ForeColor = System.Drawing.Color.Black
        Me.A4.Location = New System.Drawing.Point(13, 78)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(178, 19)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Cheque Pré Baixado no Perído"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.ForeColor = System.Drawing.Color.Black
        Me.A3.Location = New System.Drawing.Point(13, 53)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(151, 19)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Cheque Pré Entregue Por"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.ForeColor = System.Drawing.Color.Black
        Me.A2.Location = New System.Drawing.Point(13, 28)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(113, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Cheque Pré Geral"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.ForeColor = System.Drawing.Color.Black
        Me.A1.Location = New System.Drawing.Point(13, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(139, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Cheque Pré no Período"
        Me.A1.UseVisualStyleBackColor = True
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label9)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(282, 36)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(383, 30)
        Me.PainelPeriodo.TabIndex = 1
        Me.PainelPeriodo.Visible = False
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
        'PainelEntreguePor
        '
        Me.PainelEntreguePor.Controls.Add(Me.Label1)
        Me.PainelEntreguePor.Controls.Add(Me.EntreguePor)
        Me.PainelEntreguePor.Location = New System.Drawing.Point(282, 100)
        Me.PainelEntreguePor.Name = "PainelEntreguePor"
        Me.PainelEntreguePor.Size = New System.Drawing.Size(482, 30)
        Me.PainelEntreguePor.TabIndex = 3
        Me.PainelEntreguePor.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entregue Por"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EntreguePor
        '
        Me.EntreguePor.AceitaColarTexto = True
        Me.EntreguePor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntreguePor.CasasDecimais = 0
        Me.EntreguePor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntreguePor.CPObrigatorio = False
        Me.EntreguePor.CPObrigatorioMsg = Nothing
        Me.EntreguePor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntreguePor.FlatBorder = False
        Me.EntreguePor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EntreguePor.FocusColor = System.Drawing.Color.Empty
        Me.EntreguePor.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntreguePor.HighlightBorderOnEnter = False
        Me.EntreguePor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EntreguePor.Location = New System.Drawing.Point(132, 3)
        Me.EntreguePor.Name = "EntreguePor"
        Me.EntreguePor.PreencherZeroEsqueda = False
        Me.EntreguePor.RegraValidação = Nothing
        Me.EntreguePor.RegraValidaçãoMensagem = Nothing
        Me.EntreguePor.Size = New System.Drawing.Size(346, 23)
        Me.EntreguePor.TabIndex = 1
        Me.EntreguePor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntreguePor.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btVisualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.PainelEntreguePor)
        Me.Fundo.Controls.Add(Me.PainelPeriodo)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(774, 272)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 4
        '
        'btVisualizar
        '
        Me.btVisualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVisualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVisualizar.Location = New System.Drawing.Point(572, 228)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(93, 34)
        Me.btVisualizar.TabIndex = 6
        Me.btVisualizar.Text = "Visualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(671, 228)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(93, 34)
        Me.btFechar.TabIndex = 5
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(264, 124)
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
        Me.GroupPanel1.TabIndex = 4
        Me.GroupPanel1.Text = "Selecione uma das Opções"
        '
        'ChequePreRelat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChequePreRelat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios de Cheques Pré - T118"
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.PainelEntreguePor.ResumeLayout(False)
        Me.PainelEntreguePor.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelEntreguePor As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EntreguePor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btVisualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
End Class
