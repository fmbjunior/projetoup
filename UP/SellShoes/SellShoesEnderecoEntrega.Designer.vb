<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesEnderecoEntrega
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.EnderecoEntrega = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btConfirmar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Label20)
        Me.PanelEx1.Controls.Add(Me.EnderecoEntrega)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(595, 117)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(431, 82)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(71, 23)
        Me.btConfirmar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btConfirmar.TabIndex = 2
        Me.btConfirmar.Text = "Confirmar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(508, 82)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(71, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 3
        Me.btFechar.TabStop = False
        Me.btFechar.Text = "Fechar"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(516, 19)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Informe o endereço de Entrega"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EnderecoEntrega
        '
        Me.EnderecoEntrega.AceitaColarTexto = True
        Me.EnderecoEntrega.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EnderecoEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EnderecoEntrega.CasasDecimais = 2
        Me.EnderecoEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EnderecoEntrega.CPObrigatorio = False
        Me.EnderecoEntrega.CPObrigatorioMsg = Nothing
        Me.EnderecoEntrega.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EnderecoEntrega.FlatBorder = False
        Me.EnderecoEntrega.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EnderecoEntrega.FocusColor = System.Drawing.Color.Empty
        Me.EnderecoEntrega.FocusColorEnd = System.Drawing.Color.Empty
        Me.EnderecoEntrega.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnderecoEntrega.HighlightBorderOnEnter = False
        Me.EnderecoEntrega.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EnderecoEntrega.Location = New System.Drawing.Point(9, 31)
        Me.EnderecoEntrega.MaxLength = 250
        Me.EnderecoEntrega.Name = "EnderecoEntrega"
        Me.EnderecoEntrega.PreencherZeroEsqueda = False
        Me.EnderecoEntrega.RegraValidação = Nothing
        Me.EnderecoEntrega.RegraValidaçãoMensagem = Nothing
        Me.EnderecoEntrega.Size = New System.Drawing.Size(574, 26)
        Me.EnderecoEntrega.TabIndex = 1
        Me.EnderecoEntrega.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EnderecoEntrega.ValorPadrao = Nothing
        '
        'SellShoesEnderecoEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 117)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SellShoesEnderecoEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observações - T268"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents EnderecoEntrega As TexBoxFocusNet.TextBoxFocusNet
End Class
