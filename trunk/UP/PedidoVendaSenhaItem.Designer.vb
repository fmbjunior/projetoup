<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVendaSenhaItem
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelSenha = New System.Windows.Forms.Label()
        Me.Senha = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Usuario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.btCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 38)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Login -->"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelSenha
        '
        Me.labelSenha.BackColor = System.Drawing.Color.Transparent
        Me.labelSenha.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSenha.ForeColor = System.Drawing.Color.Black
        Me.labelSenha.Location = New System.Drawing.Point(18, 49)
        Me.labelSenha.Name = "labelSenha"
        Me.labelSenha.Size = New System.Drawing.Size(88, 32)
        Me.labelSenha.TabIndex = 2
        Me.labelSenha.Text = "Senha ->"
        Me.labelSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Senha
        '
        Me.Senha.AceitaColarTexto = True
        Me.Senha.BackColor = System.Drawing.Color.White
        Me.Senha.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Senha.CasasDecimais = 0
        Me.Senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Senha.CPObrigatorio = False
        Me.Senha.CPObrigatorioMsg = Nothing
        Me.Senha.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Senha.FlatBorder = False
        Me.Senha.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Senha.FocusColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Senha.FocusColorEnd = System.Drawing.Color.White
        Me.Senha.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha.ForeColor = System.Drawing.Color.Black
        Me.Senha.HighlightBorderOnEnter = False
        Me.Senha.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Senha.Location = New System.Drawing.Point(112, 49)
        Me.Senha.MaxLength = 15
        Me.Senha.Name = "Senha"
        Me.Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Senha.PreencherZeroEsqueda = False
        Me.Senha.RegraValidação = Nothing
        Me.Senha.RegraValidaçãoMensagem = Nothing
        Me.Senha.Size = New System.Drawing.Size(133, 23)
        Me.Senha.TabIndex = 3
        Me.Senha.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Senha.ValorPadrao = Nothing
        '
        'Usuario
        '
        Me.Usuario.AceitaColarTexto = True
        Me.Usuario.BackColor = System.Drawing.Color.White
        Me.Usuario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Usuario.CasasDecimais = 0
        Me.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usuario.CPObrigatorio = False
        Me.Usuario.CPObrigatorioMsg = Nothing
        Me.Usuario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Usuario.FlatBorder = False
        Me.Usuario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Usuario.FocusColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Usuario.FocusColorEnd = System.Drawing.Color.White
        Me.Usuario.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.ForeColor = System.Drawing.Color.Black
        Me.Usuario.HighlightBorderOnEnter = False
        Me.Usuario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Usuario.Location = New System.Drawing.Point(112, 12)
        Me.Usuario.MaxLength = 15
        Me.Usuario.Name = "Usuario"
        Me.Usuario.PreencherZeroEsqueda = False
        Me.Usuario.RegraValidação = Nothing
        Me.Usuario.RegraValidaçãoMensagem = Nothing
        Me.Usuario.Size = New System.Drawing.Size(133, 23)
        Me.Usuario.TabIndex = 1
        Me.Usuario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Usuario.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btConfirmar)
        Me.Fundo.Controls.Add(Me.btCancelar)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Usuario)
        Me.Fundo.Controls.Add(Me.Senha)
        Me.Fundo.Controls.Add(Me.labelSenha)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(267, 132)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(89, 95)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btConfirmar.TabIndex = 4
        Me.btConfirmar.Text = "Confirmar"
        '
        'btCancelar
        '
        Me.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCancelar.Location = New System.Drawing.Point(170, 95)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 5
        Me.btCancelar.Text = "Cancelar"
        '
        'PedidoVendaSenhaItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(267, 132)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PedidoVendaSenhaItem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Senha e Permições - T185"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents labelSenha As System.Windows.Forms.Label
    Friend WithEvents Senha As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Usuario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btCancelar As DevComponents.DotNetBar.ButtonX
End Class
