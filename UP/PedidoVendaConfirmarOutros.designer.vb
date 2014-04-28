<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVendaConfirmarOutros
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
        Me.TotalPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalPedido
        '
        Me.TotalPedido.AceitaColarTexto = True
        Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalPedido.CasasDecimais = 2
        Me.TotalPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalPedido.CPObrigatorio = False
        Me.TotalPedido.CPObrigatorioMsg = Nothing
        Me.TotalPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalPedido.FlatBorder = False
        Me.TotalPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalPedido.FocusColor = System.Drawing.Color.MistyRose
        Me.TotalPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalPedido.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPedido.HighlightBorderOnEnter = False
        Me.TotalPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalPedido.Location = New System.Drawing.Point(187, 30)
        Me.TotalPedido.MaxLength = 10
        Me.TotalPedido.Name = "TotalPedido"
        Me.TotalPedido.PreencherZeroEsqueda = False
        Me.TotalPedido.RegraValidação = Nothing
        Me.TotalPedido.RegraValidaçãoMensagem = Nothing
        Me.TotalPedido.Size = New System.Drawing.Size(206, 30)
        Me.TotalPedido.TabIndex = 1
        Me.TotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalPedido.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.btConfirmar)
        Me.Fundo.Controls.Add(Me.TotalPedido)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(410, 163)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(316, 121)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(77, 28)
        Me.btFechar.TabIndex = 5
        Me.btFechar.TabStop = False
        Me.btFechar.Text = "Fechar"
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(233, 121)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(77, 28)
        Me.btConfirmar.TabIndex = 4
        Me.btConfirmar.Text = "Confirmar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total do Pedido"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PedidoVendaConfirmarOutros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(410, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PedidoVendaConfirmarOutros"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar Pedido/Venda - T180"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TotalPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
End Class
