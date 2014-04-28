<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Senha = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataHoje = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Usuario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.labelSenha = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.PainelLogin = New System.Windows.Forms.Panel()
        Me.lblEmpresaPadrao = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfirmarBT = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AltSenha = New System.Windows.Forms.LinkLabel()
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.Fundo.SuspendLayout()
        Me.PainelLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(259, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Data --->"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Senha
        '
        Me.Senha.AceitaColarTexto = True
        Me.Senha.BackColor = System.Drawing.Color.White
        Me.Senha.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Senha.CasasDecimais = 0
        Me.Senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Senha.CPObrigatorio = False
        Me.Senha.CPObrigatorioMsg = Nothing
        Me.Senha.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Senha.FlatBorder = False
        Me.Senha.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Senha.FocusColor = System.Drawing.Color.White
        Me.Senha.FocusColorEnd = System.Drawing.Color.White
        Me.Senha.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha.HighlightBorderOnEnter = False
        Me.Senha.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Senha.Location = New System.Drawing.Point(259, 159)
        Me.Senha.MaxLength = 15
        Me.Senha.Name = "Senha"
        Me.Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(174)
        Me.Senha.PreencherZeroEsqueda = False
        Me.Senha.RegraValidação = Nothing
        Me.Senha.RegraValidaçãoMensagem = Nothing
        Me.Senha.Size = New System.Drawing.Size(152, 26)
        Me.Senha.TabIndex = 7
        Me.Senha.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Senha.ValorPadrao = Nothing
        '
        'DataHoje
        '
        Me.DataHoje.AceitaColarTexto = True
        Me.DataHoje.BackColor = System.Drawing.Color.White
        Me.DataHoje.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataHoje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataHoje.CasasDecimais = 0
        Me.DataHoje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataHoje.CPObrigatorio = False
        Me.DataHoje.CPObrigatorioMsg = Nothing
        Me.DataHoje.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataHoje.FlatBorder = False
        Me.DataHoje.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataHoje.FocusColor = System.Drawing.Color.White
        Me.DataHoje.FocusColorEnd = System.Drawing.Color.White
        Me.DataHoje.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.DataHoje.HighlightBorderOnEnter = False
        Me.DataHoje.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataHoje.Location = New System.Drawing.Point(259, 213)
        Me.DataHoje.MaxLength = 10
        Me.DataHoje.Name = "DataHoje"
        Me.DataHoje.PreencherZeroEsqueda = False
        Me.DataHoje.RegraValidação = Nothing
        Me.DataHoje.RegraValidaçãoMensagem = Nothing
        Me.DataHoje.Size = New System.Drawing.Size(152, 23)
        Me.DataHoje.TabIndex = 9
        Me.DataHoje.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataHoje.ValorPadrao = Nothing
        '
        'Usuario
        '
        Me.Usuario.AceitaColarTexto = True
        Me.Usuario.BackColor = System.Drawing.Color.White
        Me.Usuario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Usuario.CasasDecimais = 0
        Me.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usuario.CPObrigatorio = False
        Me.Usuario.CPObrigatorioMsg = Nothing
        Me.Usuario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Usuario.FlatBorder = False
        Me.Usuario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Usuario.FocusColor = System.Drawing.Color.White
        Me.Usuario.FocusColorEnd = System.Drawing.Color.White
        Me.Usuario.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Usuario.HighlightBorderOnEnter = False
        Me.Usuario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Usuario.Location = New System.Drawing.Point(259, 110)
        Me.Usuario.MaxLength = 15
        Me.Usuario.Name = "Usuario"
        Me.Usuario.PreencherZeroEsqueda = False
        Me.Usuario.RegraValidação = Nothing
        Me.Usuario.RegraValidaçãoMensagem = Nothing
        Me.Usuario.Size = New System.Drawing.Size(152, 23)
        Me.Usuario.TabIndex = 5
        Me.Usuario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Usuario.ValorPadrao = Nothing
        '
        'labelSenha
        '
        Me.labelSenha.BackColor = System.Drawing.Color.Transparent
        Me.labelSenha.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.labelSenha.ForeColor = System.Drawing.Color.DodgerBlue
        Me.labelSenha.Location = New System.Drawing.Point(259, 136)
        Me.labelSenha.Name = "labelSenha"
        Me.labelSenha.Size = New System.Drawing.Size(69, 20)
        Me.labelSenha.TabIndex = 6
        Me.labelSenha.Text = "Senha ->"
        Me.labelSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(259, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Login -->"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.Fundo.Controls.Add(Me.PainelLogin)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(918, 580)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.White
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.Silver
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'PainelLogin
        '
        Me.PainelLogin.Controls.Add(Me.lblVersao)
        Me.PainelLogin.Controls.Add(Me.lblEmpresaPadrao)
        Me.PainelLogin.Controls.Add(Me.Label3)
        Me.PainelLogin.Controls.Add(Me.ConfirmarBT)
        Me.PainelLogin.Controls.Add(Me.Usuario)
        Me.PainelLogin.Controls.Add(Me.Fechar)
        Me.PainelLogin.Controls.Add(Me.Label6)
        Me.PainelLogin.Controls.Add(Me.Senha)
        Me.PainelLogin.Controls.Add(Me.DataHoje)
        Me.PainelLogin.Controls.Add(Me.labelSenha)
        Me.PainelLogin.Controls.Add(Me.Label2)
        Me.PainelLogin.Controls.Add(Me.Label1)
        Me.PainelLogin.Controls.Add(Me.AltSenha)
        Me.PainelLogin.Location = New System.Drawing.Point(12, 219)
        Me.PainelLogin.Name = "PainelLogin"
        Me.PainelLogin.Size = New System.Drawing.Size(493, 349)
        Me.PainelLogin.TabIndex = 0
        '
        'lblEmpresaPadrao
        '
        Me.lblEmpresaPadrao.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaPadrao.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblEmpresaPadrao.Location = New System.Drawing.Point(13, 276)
        Me.lblEmpresaPadrao.Name = "lblEmpresaPadrao"
        Me.lblEmpresaPadrao.Size = New System.Drawing.Size(470, 32)
        Me.lblEmpresaPadrao.TabIndex = 12
        Me.lblEmpresaPadrao.Text = "Empresa Padrao"
        Me.lblEmpresaPadrao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(258, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 58)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Controle de Acesso"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ConfirmarBT
        '
        Me.ConfirmarBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ConfirmarBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ConfirmarBT.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.ConfirmarBT.Location = New System.Drawing.Point(258, 242)
        Me.ConfirmarBT.Name = "ConfirmarBT"
        Me.ConfirmarBT.Size = New System.Drawing.Size(71, 25)
        Me.ConfirmarBT.TabIndex = 10
        Me.ConfirmarBT.Text = "Login"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Fechar.Location = New System.Drawing.Point(340, 242)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(71, 25)
        Me.Fechar.TabIndex = 11
        Me.Fechar.Text = "Fechar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 255)
        Me.Label2.TabIndex = 1
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AltSenha
        '
        Me.AltSenha.AutoSize = True
        Me.AltSenha.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltSenha.LinkColor = System.Drawing.Color.DodgerBlue
        Me.AltSenha.Location = New System.Drawing.Point(9, 253)
        Me.AltSenha.Name = "AltSenha"
        Me.AltSenha.Size = New System.Drawing.Size(168, 17)
        Me.AltSenha.TabIndex = 0
        Me.AltSenha.TabStop = True
        Me.AltSenha.Text = "Alterar a Senha do Usuário..."
        '
        'lblVersao
        '
        Me.lblVersao.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersao.ForeColor = System.Drawing.Color.Black
        Me.lblVersao.Location = New System.Drawing.Point(13, 308)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(470, 32)
        Me.lblVersao.TabIndex = 13
        Me.lblVersao.Text = "Versão"
        Me.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(918, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Fundo.ResumeLayout(False)
        Me.PainelLogin.ResumeLayout(False)
        Me.PainelLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Senha As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataHoje As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Usuario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents labelSenha As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ConfirmarBT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents AltSenha As System.Windows.Forms.LinkLabel
    Friend WithEvents PainelLogin As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEmpresaPadrao As System.Windows.Forms.Label
    Friend WithEvents lblVersao As System.Windows.Forms.Label
End Class
