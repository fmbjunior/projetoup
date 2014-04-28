<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuplicataReimpressao
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
        Me.txtCodigoPedido = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.btimprimir = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigoPedido
        '
        Me.txtCodigoPedido.AceitaColarTexto = True
        Me.txtCodigoPedido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigoPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtCodigoPedido.CasasDecimais = 0
        Me.txtCodigoPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoPedido.CPObrigatorio = False
        Me.txtCodigoPedido.CPObrigatorioMsg = Nothing
        Me.txtCodigoPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtCodigoPedido.FocusColor = System.Drawing.Color.Empty
        Me.txtCodigoPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtCodigoPedido.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoPedido.Location = New System.Drawing.Point(30, 53)
        Me.txtCodigoPedido.MaxLength = 250
        Me.txtCodigoPedido.Name = "txtCodigoPedido"
        Me.txtCodigoPedido.PreencherZeroEsqueda = False
        Me.txtCodigoPedido.RegraValidação = Nothing
        Me.txtCodigoPedido.RegraValidaçãoMensagem = Nothing
        Me.txtCodigoPedido.Size = New System.Drawing.Size(218, 30)
        Me.txtCodigoPedido.TabIndex = 21
        Me.txtCodigoPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtCodigoPedido.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 32)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Pedido"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.btimprimir)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(279, 190)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 22
        '
        'btimprimir
        '
        Me.btimprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btimprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btimprimir.Location = New System.Drawing.Point(12, 137)
        Me.btimprimir.Name = "btimprimir"
        Me.btimprimir.Size = New System.Drawing.Size(120, 41)
        Me.btimprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btimprimir.TabIndex = 21
        Me.btimprimir.Text = "Imprimir"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(147, 137)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(120, 41)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 22
        Me.btFechar.Text = "Fechar"
        '
        'DuplicataReimpressao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 190)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCodigoPedido)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DuplicataReimpressao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DuplicataReimpressao"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtCodigoPedido As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btimprimir As DevComponents.DotNetBar.ButtonX
End Class
