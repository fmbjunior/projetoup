<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoReImpress
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
        Me.Pedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Espelho = New System.Windows.Forms.CheckBox()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btVisualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Informe o Nº do Pedido"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pedido
        '
        Me.Pedido.AceitaColarTexto = True
        Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Pedido.CasasDecimais = 0
        Me.Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pedido.CPObrigatorio = False
        Me.Pedido.CPObrigatorioMsg = Nothing
        Me.Pedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Pedido.FlatBorder = False
        Me.Pedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Pedido.FocusColor = System.Drawing.Color.Empty
        Me.Pedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pedido.HighlightBorderOnEnter = False
        Me.Pedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Pedido.Location = New System.Drawing.Point(168, 25)
        Me.Pedido.MaxLength = 50
        Me.Pedido.Name = "Pedido"
        Me.Pedido.PreencherZeroEsqueda = False
        Me.Pedido.RegraValidação = Nothing
        Me.Pedido.RegraValidaçãoMensagem = Nothing
        Me.Pedido.Size = New System.Drawing.Size(86, 23)
        Me.Pedido.TabIndex = 1
        Me.Pedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Pedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pedido.ValorPadrao = Nothing
        '
        'Espelho
        '
        Me.Espelho.Location = New System.Drawing.Point(16, 54)
        Me.Espelho.Name = "Espelho"
        Me.Espelho.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Espelho.Size = New System.Drawing.Size(165, 19)
        Me.Espelho.TabIndex = 2
        Me.Espelho.Text = "Imprimir em Espelho"
        Me.Espelho.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Espelho.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btVisualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Pedido)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Espelho)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(337, 159)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btVisualizar
        '
        Me.btVisualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVisualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVisualizar.Location = New System.Drawing.Point(165, 124)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(77, 26)
        Me.btVisualizar.TabIndex = 3
        Me.btVisualizar.Text = "Visualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(248, 124)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(77, 26)
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "Fechar"
        '
        'PedidoReImpress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(337, 159)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PedidoReImpress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimpressão de Pedido/Venda - T174"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Pedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Espelho As System.Windows.Forms.CheckBox
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btVisualizar As DevComponents.DotNetBar.ButtonX
End Class
