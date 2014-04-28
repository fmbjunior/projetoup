<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlternarEmpresa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Codigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Empresa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Alternar = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa"
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
        Me.Codigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Codigo.FlatBorder = False
        Me.Codigo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Codigo.FocusColor = System.Drawing.Color.MistyRose
        Me.Codigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Codigo.HighlightBorderOnEnter = False
        Me.Codigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Codigo.Location = New System.Drawing.Point(12, 31)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.PreencherZeroEsqueda = False
        Me.Codigo.RegraValidação = Nothing
        Me.Codigo.RegraValidaçãoMensagem = Nothing
        Me.Codigo.Size = New System.Drawing.Size(76, 23)
        Me.Codigo.TabIndex = 1
        Me.Codigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Codigo.ValorPadrao = Nothing
        '
        'Empresa
        '
        Me.Empresa.AceitaColarTexto = True
        Me.Empresa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Empresa.CasasDecimais = 0
        Me.Empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Empresa.CPObrigatorio = False
        Me.Empresa.CPObrigatorioMsg = Nothing
        Me.Empresa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Empresa.FlatBorder = False
        Me.Empresa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Empresa.FocusColor = System.Drawing.Color.MistyRose
        Me.Empresa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Empresa.HighlightBorderOnEnter = False
        Me.Empresa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Empresa.Location = New System.Drawing.Point(12, 60)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.PreencherZeroEsqueda = False
        Me.Empresa.RegraValidação = Nothing
        Me.Empresa.RegraValidaçãoMensagem = Nothing
        Me.Empresa.Size = New System.Drawing.Size(384, 23)
        Me.Empresa.TabIndex = 2
        Me.Empresa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Empresa.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Alternar)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Codigo)
        Me.Fundo.Controls.Add(Me.Empresa)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(408, 130)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Alternar
        '
        Me.Alternar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Alternar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Alternar.Location = New System.Drawing.Point(246, 93)
        Me.Alternar.Name = "Alternar"
        Me.Alternar.Size = New System.Drawing.Size(72, 25)
        Me.Alternar.TabIndex = 3
        Me.Alternar.Text = "Alternar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(324, 93)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(72, 25)
        Me.Fechar.TabIndex = 4
        Me.Fechar.Text = "Fechar"
        '
        'AlternarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(408, 130)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AlternarEmpresa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alternar Empresa Padrão - T088"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Codigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Empresa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Alternar As DevComponents.DotNetBar.ButtonX
End Class
