<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesAutenticacao
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Vendedor = New CBOAutoCompleteFocus.CboFocus()
        Me.OpcConsVenda = New System.Windows.Forms.RadioButton()
        Me.OpcOrcamento = New System.Windows.Forms.RadioButton()
        Me.OpcDevoluçao = New System.Windows.Forms.RadioButton()
        Me.LabelAutenticação = New System.Windows.Forms.Label()
        Me.Autenticacao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.OpcVenda = New System.Windows.Forms.RadioButton()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.TimerTeclado = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(388, 191)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Vendedor)
        Me.GroupPanel1.Controls.Add(Me.OpcConsVenda)
        Me.GroupPanel1.Controls.Add(Me.OpcOrcamento)
        Me.GroupPanel1.Controls.Add(Me.OpcDevoluçao)
        Me.GroupPanel1.Controls.Add(Me.LabelAutenticação)
        Me.GroupPanel1.Controls.Add(Me.Autenticacao)
        Me.GroupPanel1.Controls.Add(Me.btConfirmar)
        Me.GroupPanel1.Controls.Add(Me.OpcVenda)
        Me.GroupPanel1.Controls.Add(Me.btFechar)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(363, 167)
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
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Selecione um Tipo de Operação"
        '
        'Vendedor
        '
        Me.Vendedor.Auto_Complete = True
        Me.Vendedor.AutoLimitar_Lista = True
        Me.Vendedor.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.Vendedor.CPObrigatorio = False
        Me.Vendedor.CPObrigatorioMsg = Nothing
        Me.Vendedor.DropDownWidth = 250
        Me.Vendedor.FlatBorder = True
        Me.Vendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Vendedor.FormattingEnabled = True
        Me.Vendedor.HighlightBorderColor = System.Drawing.Color.Empty
        Me.Vendedor.HighlightBorderOnEnter = False
        Me.Vendedor.ItemHeight = 15
        Me.Vendedor.Location = New System.Drawing.Point(3, 56)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(349, 23)
        Me.Vendedor.TabIndex = 7
        Me.Vendedor.Visible = False
        '
        'OpcConsVenda
        '
        Me.OpcConsVenda.AutoSize = True
        Me.OpcConsVenda.Enabled = False
        Me.OpcConsVenda.Location = New System.Drawing.Point(256, 3)
        Me.OpcConsVenda.Name = "OpcConsVenda"
        Me.OpcConsVenda.Size = New System.Drawing.Size(97, 19)
        Me.OpcConsVenda.TabIndex = 6
        Me.OpcConsVenda.TabStop = True
        Me.OpcConsVenda.Text = "Resumo Venda"
        Me.OpcConsVenda.UseVisualStyleBackColor = True
        '
        'OpcOrcamento
        '
        Me.OpcOrcamento.AutoSize = True
        Me.OpcOrcamento.Enabled = False
        Me.OpcOrcamento.Location = New System.Drawing.Point(158, 3)
        Me.OpcOrcamento.Name = "OpcOrcamento"
        Me.OpcOrcamento.Size = New System.Drawing.Size(81, 19)
        Me.OpcOrcamento.TabIndex = 6
        Me.OpcOrcamento.TabStop = True
        Me.OpcOrcamento.Text = "Orçamento"
        Me.OpcOrcamento.UseVisualStyleBackColor = True
        '
        'OpcDevoluçao
        '
        Me.OpcDevoluçao.AutoSize = True
        Me.OpcDevoluçao.Enabled = False
        Me.OpcDevoluçao.Location = New System.Drawing.Point(74, 3)
        Me.OpcDevoluçao.Name = "OpcDevoluçao"
        Me.OpcDevoluçao.Size = New System.Drawing.Size(78, 19)
        Me.OpcDevoluçao.TabIndex = 1
        Me.OpcDevoluçao.TabStop = True
        Me.OpcDevoluçao.Text = "Devolução"
        Me.OpcDevoluçao.UseVisualStyleBackColor = True
        '
        'LabelAutenticação
        '
        Me.LabelAutenticação.Location = New System.Drawing.Point(3, 33)
        Me.LabelAutenticação.Name = "LabelAutenticação"
        Me.LabelAutenticação.Size = New System.Drawing.Size(349, 19)
        Me.LabelAutenticação.TabIndex = 2
        Me.LabelAutenticação.Text = "Favor Informar a Autenticação"
        Me.LabelAutenticação.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Autenticacao
        '
        Me.Autenticacao.AceitaColarTexto = True
        Me.Autenticacao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Autenticacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Autenticacao.CasasDecimais = 0
        Me.Autenticacao.CPObrigatorio = False
        Me.Autenticacao.CPObrigatorioMsg = Nothing
        Me.Autenticacao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Autenticacao.FlatBorder = False
        Me.Autenticacao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Autenticacao.FocusColor = System.Drawing.Color.Empty
        Me.Autenticacao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Autenticacao.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Autenticacao.HighlightBorderOnEnter = False
        Me.Autenticacao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Autenticacao.Location = New System.Drawing.Point(3, 55)
        Me.Autenticacao.MaxLength = 20
        Me.Autenticacao.Name = "Autenticacao"
        Me.Autenticacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Autenticacao.PreencherZeroEsqueda = False
        Me.Autenticacao.RegraValidação = Nothing
        Me.Autenticacao.RegraValidaçãoMensagem = Nothing
        Me.Autenticacao.Size = New System.Drawing.Size(349, 24)
        Me.Autenticacao.TabIndex = 3
        Me.Autenticacao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Autenticacao.ValorPadrao = Nothing
        Me.Autenticacao.Visible = False
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(204, 117)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(71, 23)
        Me.btConfirmar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btConfirmar.TabIndex = 4
        Me.btConfirmar.Text = "Confirmar"
        '
        'OpcVenda
        '
        Me.OpcVenda.AutoSize = True
        Me.OpcVenda.Checked = True
        Me.OpcVenda.Enabled = False
        Me.OpcVenda.Location = New System.Drawing.Point(3, 3)
        Me.OpcVenda.Name = "OpcVenda"
        Me.OpcVenda.Size = New System.Drawing.Size(56, 19)
        Me.OpcVenda.TabIndex = 0
        Me.OpcVenda.TabStop = True
        Me.OpcVenda.Text = "Venda"
        Me.OpcVenda.UseVisualStyleBackColor = True
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(281, 117)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(71, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 5
        Me.btFechar.TabStop = False
        Me.btFechar.Text = "Fechar"
        '
        'TimerTeclado
        '
        Me.TimerTeclado.Interval = 280
        '
        'SellShoesAutenticacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 191)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "SellShoesAutenticacao"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autenticação de Venda - T259"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Autenticacao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelAutenticação As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents OpcDevoluçao As System.Windows.Forms.RadioButton
    Friend WithEvents OpcVenda As System.Windows.Forms.RadioButton
    Friend WithEvents OpcOrcamento As System.Windows.Forms.RadioButton
    Friend WithEvents OpcConsVenda As System.Windows.Forms.RadioButton
    Friend WithEvents TimerTeclado As System.Windows.Forms.Timer
    Friend WithEvents Vendedor As CBOAutoCompleteFocus.CboFocus
End Class
