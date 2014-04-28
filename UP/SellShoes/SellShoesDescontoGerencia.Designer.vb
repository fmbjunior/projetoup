<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesDescontoGerencia
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.DescontoValor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Senha = New TexBoxFocusNet.TextBoxFocusNet()
        Me.labelSenha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescontoEspecial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.TimerTeclado = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.DescontoValor)
        Me.PanelEx1.Controls.Add(Me.Senha)
        Me.PanelEx1.Controls.Add(Me.labelSenha)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.DescontoEspecial)
        Me.PanelEx1.Controls.Add(Me.btConfirmar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(465, 139)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.ForestGreen
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.PaleGreen
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'DescontoValor
        '
        Me.DescontoValor.AceitaColarTexto = True
        Me.DescontoValor.BackColor = System.Drawing.Color.White
        Me.DescontoValor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescontoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescontoValor.CasasDecimais = 2
        Me.DescontoValor.CPObrigatorio = False
        Me.DescontoValor.CPObrigatorioMsg = Nothing
        Me.DescontoValor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescontoValor.FlatBorder = False
        Me.DescontoValor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescontoValor.FocusColor = System.Drawing.Color.White
        Me.DescontoValor.FocusColorEnd = System.Drawing.Color.White
        Me.DescontoValor.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescontoValor.HighlightBorderOnEnter = False
        Me.DescontoValor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescontoValor.Location = New System.Drawing.Point(303, 26)
        Me.DescontoValor.MaxLength = 15
        Me.DescontoValor.Name = "DescontoValor"
        Me.DescontoValor.PreencherZeroEsqueda = False
        Me.DescontoValor.RegraValidação = Nothing
        Me.DescontoValor.RegraValidaçãoMensagem = Nothing
        Me.DescontoValor.Size = New System.Drawing.Size(150, 26)
        Me.DescontoValor.TabIndex = 2
        Me.DescontoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DescontoValor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.DescontoValor.ValorPadrao = Nothing
        Me.DescontoValor.Visible = False
        '
        'Senha
        '
        Me.Senha.AceitaColarTexto = False
        Me.Senha.BackColor = System.Drawing.Color.White
        Me.Senha.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Senha.CasasDecimais = 0
        Me.Senha.CPObrigatorio = False
        Me.Senha.CPObrigatorioMsg = Nothing
        Me.Senha.Enabled = False
        Me.Senha.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Senha.FlatBorder = False
        Me.Senha.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Senha.FocusColor = System.Drawing.Color.White
        Me.Senha.FocusColorEnd = System.Drawing.Color.White
        Me.Senha.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha.HighlightBorderOnEnter = False
        Me.Senha.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Senha.Location = New System.Drawing.Point(242, 58)
        Me.Senha.MaxLength = 15
        Me.Senha.Name = "Senha"
        Me.Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Senha.PreencherZeroEsqueda = False
        Me.Senha.RegraValidação = Nothing
        Me.Senha.RegraValidaçãoMensagem = Nothing
        Me.Senha.ShortcutsEnabled = False
        Me.Senha.Size = New System.Drawing.Size(212, 26)
        Me.Senha.TabIndex = 4
        Me.Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Senha.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Senha.ValorPadrao = Nothing
        Me.Senha.Visible = False
        '
        'labelSenha
        '
        Me.labelSenha.BackColor = System.Drawing.Color.Transparent
        Me.labelSenha.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSenha.ForeColor = System.Drawing.Color.Black
        Me.labelSenha.Location = New System.Drawing.Point(12, 58)
        Me.labelSenha.Name = "labelSenha"
        Me.labelSenha.Size = New System.Drawing.Size(212, 20)
        Me.labelSenha.TabIndex = 3
        Me.labelSenha.Text = "Informe a Senha do Desconto"
        Me.labelSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelSenha.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe a percentual que deseja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescontoEspecial
        '
        Me.DescontoEspecial.AceitaColarTexto = True
        Me.DescontoEspecial.BackColor = System.Drawing.Color.White
        Me.DescontoEspecial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescontoEspecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescontoEspecial.CasasDecimais = 2
        Me.DescontoEspecial.CPObrigatorio = False
        Me.DescontoEspecial.CPObrigatorioMsg = Nothing
        Me.DescontoEspecial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescontoEspecial.FlatBorder = False
        Me.DescontoEspecial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescontoEspecial.FocusColor = System.Drawing.Color.White
        Me.DescontoEspecial.FocusColorEnd = System.Drawing.Color.White
        Me.DescontoEspecial.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescontoEspecial.HighlightBorderOnEnter = False
        Me.DescontoEspecial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescontoEspecial.Location = New System.Drawing.Point(242, 26)
        Me.DescontoEspecial.MaxLength = 15
        Me.DescontoEspecial.Name = "DescontoEspecial"
        Me.DescontoEspecial.PreencherZeroEsqueda = False
        Me.DescontoEspecial.RegraValidação = Nothing
        Me.DescontoEspecial.RegraValidaçãoMensagem = Nothing
        Me.DescontoEspecial.Size = New System.Drawing.Size(55, 26)
        Me.DescontoEspecial.TabIndex = 1
        Me.DescontoEspecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DescontoEspecial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.DescontoEspecial.ValorPadrao = Nothing
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(303, 102)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(73, 24)
        Me.btConfirmar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btConfirmar.TabIndex = 5
        Me.btConfirmar.Text = "Ok"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(382, 102)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(73, 24)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 6
        Me.btFechar.Text = "Fechar"
        '
        'TimerTeclado
        '
        Me.TimerTeclado.Interval = 280
        '
        'SellShoesDescontoGerencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 139)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SellShoesDescontoGerencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desconto Gerencial - T265"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Senha As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents labelSenha As System.Windows.Forms.Label
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DescontoEspecial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DescontoValor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TimerTeclado As System.Windows.Forms.Timer
End Class
