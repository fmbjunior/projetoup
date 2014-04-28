<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterarSenha
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Salvar = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.SenhaNova = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Login = New TexBoxFocusNet.TextBoxFocusNet()
        Me.SenhaAntiga = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(5, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Senha Antiga"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(5, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Senha Nova"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Salvar)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.SenhaNova)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Login)
        Me.Fundo.Controls.Add(Me.SenhaAntiga)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(287, 143)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 8
        '
        'Salvar
        '
        Me.Salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Salvar.Location = New System.Drawing.Point(126, 110)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(72, 25)
        Me.Salvar.TabIndex = 3
        Me.Salvar.Text = "Salvar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(204, 110)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(72, 25)
        Me.Fechar.TabIndex = 4
        Me.Fechar.Text = "Fechar"
        '
        'SenhaNova
        '
        Me.SenhaNova.AceitaColarTexto = True
        Me.SenhaNova.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SenhaNova.CasasDecimais = 0
        Me.SenhaNova.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SenhaNova.CPObrigatorio = False
        Me.SenhaNova.CPObrigatorioMsg = Nothing
        Me.SenhaNova.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SenhaNova.FlatBorder = False
        Me.SenhaNova.FlatBorderColor = System.Drawing.Color.DimGray
        Me.SenhaNova.FocusColor = System.Drawing.Color.MistyRose
        Me.SenhaNova.FocusColorEnd = System.Drawing.Color.Empty
        Me.SenhaNova.HighlightBorderOnEnter = False
        Me.SenhaNova.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.SenhaNova.Location = New System.Drawing.Point(150, 70)
        Me.SenhaNova.Name = "SenhaNova"
        Me.SenhaNova.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaNova.PreencherZeroEsqueda = False
        Me.SenhaNova.RegraValidação = Nothing
        Me.SenhaNova.RegraValidaçãoMensagem = Nothing
        Me.SenhaNova.Size = New System.Drawing.Size(126, 23)
        Me.SenhaNova.TabIndex = 5
        Me.SenhaNova.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.SenhaNova.ValorPadrao = Nothing
        '
        'Login
        '
        Me.Login.AceitaColarTexto = True
        Me.Login.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Login.CasasDecimais = 0
        Me.Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Login.CPObrigatorio = False
        Me.Login.CPObrigatorioMsg = Nothing
        Me.Login.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Login.FlatBorder = False
        Me.Login.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Login.FocusColor = System.Drawing.Color.MistyRose
        Me.Login.FocusColorEnd = System.Drawing.Color.Empty
        Me.Login.HighlightBorderOnEnter = False
        Me.Login.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Login.Location = New System.Drawing.Point(150, 12)
        Me.Login.Name = "Login"
        Me.Login.PreencherZeroEsqueda = False
        Me.Login.RegraValidação = Nothing
        Me.Login.RegraValidaçãoMensagem = Nothing
        Me.Login.Size = New System.Drawing.Size(126, 23)
        Me.Login.TabIndex = 1
        Me.Login.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Login.ValorPadrao = Nothing
        '
        'SenhaAntiga
        '
        Me.SenhaAntiga.AceitaColarTexto = True
        Me.SenhaAntiga.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SenhaAntiga.CasasDecimais = 0
        Me.SenhaAntiga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SenhaAntiga.CPObrigatorio = False
        Me.SenhaAntiga.CPObrigatorioMsg = Nothing
        Me.SenhaAntiga.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SenhaAntiga.FlatBorder = False
        Me.SenhaAntiga.FlatBorderColor = System.Drawing.Color.DimGray
        Me.SenhaAntiga.FocusColor = System.Drawing.Color.MistyRose
        Me.SenhaAntiga.FocusColorEnd = System.Drawing.Color.Empty
        Me.SenhaAntiga.HighlightBorderOnEnter = False
        Me.SenhaAntiga.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.SenhaAntiga.Location = New System.Drawing.Point(150, 41)
        Me.SenhaAntiga.Name = "SenhaAntiga"
        Me.SenhaAntiga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaAntiga.PreencherZeroEsqueda = False
        Me.SenhaAntiga.RegraValidação = Nothing
        Me.SenhaAntiga.RegraValidaçãoMensagem = Nothing
        Me.SenhaAntiga.Size = New System.Drawing.Size(126, 23)
        Me.SenhaAntiga.TabIndex = 3
        Me.SenhaAntiga.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.SenhaAntiga.ValorPadrao = Nothing
        '
        'AlterarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(287, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AlterarSenha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alteração de Senha - T087"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Login As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SenhaAntiga As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SenhaNova As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Salvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
End Class
