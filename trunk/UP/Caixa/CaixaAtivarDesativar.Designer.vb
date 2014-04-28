<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaixaAtivarDesativar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaixaAtivarDesativar))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btCriarCaixa = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btFindCaixa = New System.Windows.Forms.Label()
        Me.DataCaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CodigoCaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CaixaNome = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Responsavel = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Senha = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btDesativar = New DevComponents.DotNetBar.ButtonX()
        Me.btAtivar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btCriarCaixa)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.btDesativar)
        Me.PanelEx1.Controls.Add(Me.btAtivar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(455, 197)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btCriarCaixa
        '
        Me.btCriarCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCriarCaixa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCriarCaixa.Location = New System.Drawing.Point(12, 163)
        Me.btCriarCaixa.Name = "btCriarCaixa"
        Me.btCriarCaixa.Size = New System.Drawing.Size(137, 28)
        Me.btCriarCaixa.TabIndex = 4
        Me.btCriarCaixa.Text = "Criar Caixa para este Dia"
        Me.btCriarCaixa.Visible = False
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx2.Controls.Add(Me.btFindCaixa)
        Me.PanelEx2.Controls.Add(Me.DataCaixa)
        Me.PanelEx2.Controls.Add(Me.Label4)
        Me.PanelEx2.Controls.Add(Me.CodigoCaixa)
        Me.PanelEx2.Controls.Add(Me.Label5)
        Me.PanelEx2.Controls.Add(Me.CaixaNome)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Controls.Add(Me.Label3)
        Me.PanelEx2.Controls.Add(Me.Responsavel)
        Me.PanelEx2.Controls.Add(Me.Senha)
        Me.PanelEx2.Controls.Add(Me.Label2)
        Me.PanelEx2.Location = New System.Drawing.Point(12, 6)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(431, 151)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'btFindCaixa
        '
        Me.btFindCaixa.Image = CType(resources.GetObject("btFindCaixa.Image"), System.Drawing.Image)
        Me.btFindCaixa.Location = New System.Drawing.Point(175, 11)
        Me.btFindCaixa.Name = "btFindCaixa"
        Me.btFindCaixa.Size = New System.Drawing.Size(23, 23)
        Me.btFindCaixa.TabIndex = 32
        '
        'DataCaixa
        '
        Me.DataCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataCaixa.AceitaColarTexto = True
        Me.DataCaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataCaixa.CasasDecimais = 0
        Me.DataCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataCaixa.CPObrigatorio = False
        Me.DataCaixa.CPObrigatorioMsg = Nothing
        Me.DataCaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataCaixa.FlatBorder = False
        Me.DataCaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataCaixa.FocusColor = System.Drawing.Color.Empty
        Me.DataCaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataCaixa.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataCaixa.HighlightBorderOnEnter = False
        Me.DataCaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataCaixa.Location = New System.Drawing.Point(341, 99)
        Me.DataCaixa.MaxLength = 10
        Me.DataCaixa.Name = "DataCaixa"
        Me.DataCaixa.PreencherZeroEsqueda = False
        Me.DataCaixa.RegraValidação = Nothing
        Me.DataCaixa.RegraValidaçãoMensagem = Nothing
        Me.DataCaixa.Size = New System.Drawing.Size(83, 24)
        Me.DataCaixa.TabIndex = 9
        Me.DataCaixa.TabStop = False
        Me.DataCaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataCaixa.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Data do Caixa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoCaixa
        '
        Me.CodigoCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.CodigoCaixa.AceitaColarTexto = True
        Me.CodigoCaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoCaixa.CasasDecimais = 0
        Me.CodigoCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoCaixa.CPObrigatorio = False
        Me.CodigoCaixa.CPObrigatorioMsg = Nothing
        Me.CodigoCaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoCaixa.FlatBorder = False
        Me.CodigoCaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoCaixa.FocusColor = System.Drawing.Color.Empty
        Me.CodigoCaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoCaixa.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoCaixa.HighlightBorderOnEnter = False
        Me.CodigoCaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoCaixa.Location = New System.Drawing.Point(115, 9)
        Me.CodigoCaixa.MaxLength = 4
        Me.CodigoCaixa.Name = "CodigoCaixa"
        Me.CodigoCaixa.PreencherZeroEsqueda = True
        Me.CodigoCaixa.RegraValidação = Nothing
        Me.CodigoCaixa.RegraValidaçãoMensagem = Nothing
        Me.CodigoCaixa.Size = New System.Drawing.Size(57, 24)
        Me.CodigoCaixa.TabIndex = 1
        Me.CodigoCaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoCaixa.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código Caixa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CaixaNome
        '
        Me.CaixaNome.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.CaixaNome.AceitaColarTexto = True
        Me.CaixaNome.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CaixaNome.CasasDecimais = 0
        Me.CaixaNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CaixaNome.CPObrigatorio = False
        Me.CaixaNome.CPObrigatorioMsg = Nothing
        Me.CaixaNome.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CaixaNome.FlatBorder = False
        Me.CaixaNome.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CaixaNome.FocusColor = System.Drawing.Color.Empty
        Me.CaixaNome.FocusColorEnd = System.Drawing.Color.Empty
        Me.CaixaNome.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaNome.HighlightBorderOnEnter = False
        Me.CaixaNome.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CaixaNome.Location = New System.Drawing.Point(115, 39)
        Me.CaixaNome.MaxLength = 50
        Me.CaixaNome.Name = "CaixaNome"
        Me.CaixaNome.PreencherZeroEsqueda = False
        Me.CaixaNome.RegraValidação = Nothing
        Me.CaixaNome.RegraValidaçãoMensagem = Nothing
        Me.CaixaNome.Size = New System.Drawing.Size(309, 24)
        Me.CaixaNome.TabIndex = 3
        Me.CaixaNome.TabStop = False
        Me.CaixaNome.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CaixaNome.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descrição"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Senha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Responsavel
        '
        Me.Responsavel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Responsavel.AceitaColarTexto = True
        Me.Responsavel.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Responsavel.CasasDecimais = 0
        Me.Responsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Responsavel.CPObrigatorio = False
        Me.Responsavel.CPObrigatorioMsg = Nothing
        Me.Responsavel.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Responsavel.FlatBorder = False
        Me.Responsavel.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Responsavel.FocusColor = System.Drawing.Color.Empty
        Me.Responsavel.FocusColorEnd = System.Drawing.Color.Empty
        Me.Responsavel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Responsavel.HighlightBorderOnEnter = False
        Me.Responsavel.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Responsavel.Location = New System.Drawing.Point(115, 69)
        Me.Responsavel.MaxLength = 50
        Me.Responsavel.Name = "Responsavel"
        Me.Responsavel.PreencherZeroEsqueda = False
        Me.Responsavel.RegraValidação = Nothing
        Me.Responsavel.RegraValidaçãoMensagem = Nothing
        Me.Responsavel.Size = New System.Drawing.Size(309, 24)
        Me.Responsavel.TabIndex = 5
        Me.Responsavel.TabStop = False
        Me.Responsavel.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Responsavel.ValorPadrao = Nothing
        '
        'Senha
        '
        Me.Senha.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Senha.AceitaColarTexto = True
        Me.Senha.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Senha.CasasDecimais = 0
        Me.Senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Senha.CPObrigatorio = False
        Me.Senha.CPObrigatorioMsg = Nothing
        Me.Senha.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Senha.FlatBorder = False
        Me.Senha.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Senha.FocusColor = System.Drawing.Color.Empty
        Me.Senha.FocusColorEnd = System.Drawing.Color.Empty
        Me.Senha.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha.HighlightBorderOnEnter = False
        Me.Senha.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Senha.Location = New System.Drawing.Point(115, 99)
        Me.Senha.MaxLength = 15
        Me.Senha.Name = "Senha"
        Me.Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Senha.PreencherZeroEsqueda = False
        Me.Senha.RegraValidação = Nothing
        Me.Senha.RegraValidaçãoMensagem = Nothing
        Me.Senha.Size = New System.Drawing.Size(104, 24)
        Me.Senha.TabIndex = 7
        Me.Senha.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Senha.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Responsavel"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btDesativar
        '
        Me.btDesativar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btDesativar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btDesativar.Location = New System.Drawing.Point(224, 163)
        Me.btDesativar.Name = "btDesativar"
        Me.btDesativar.Size = New System.Drawing.Size(69, 28)
        Me.btDesativar.TabIndex = 2
        Me.btDesativar.Text = "Desativar"
        '
        'btAtivar
        '
        Me.btAtivar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtivar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtivar.Location = New System.Drawing.Point(299, 163)
        Me.btAtivar.Name = "btAtivar"
        Me.btAtivar.Size = New System.Drawing.Size(69, 28)
        Me.btAtivar.TabIndex = 1
        Me.btAtivar.Text = "Ativar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(374, 163)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(69, 28)
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'CaixaAtivarDesativar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "CaixaAtivarDesativar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ativar e Desativar Caixa - T077"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Senha As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Responsavel As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CaixaNome As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CodigoCaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataCaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Private WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Private WithEvents btAtivar As DevComponents.DotNetBar.ButtonX
    Private WithEvents btDesativar As DevComponents.DotNetBar.ButtonX
    Private WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Private WithEvents btCriarCaixa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btFindCaixa As System.Windows.Forms.Label
End Class
