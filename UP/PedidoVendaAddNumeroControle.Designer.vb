<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVendaAddNumeroControle
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
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.NumeroControle = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Label23)
        Me.PanelEx1.Controls.Add(Me.NumeroControle)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(354, 180)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(184, 140)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(76, 28)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 28
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(266, 140)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(76, 28)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 27
        Me.btFechar.Text = "Fechar"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(331, 28)
        Me.Label23.TabIndex = 26
        Me.Label23.Tag = "8"
        Me.Label23.Text = "Informe o Numero do Controle "
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumeroControle
        '
        Me.NumeroControle.AceitaColarTexto = False
        Me.NumeroControle.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NumeroControle.CasasDecimais = 0
        Me.NumeroControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroControle.CPObrigatorio = False
        Me.NumeroControle.CPObrigatorioMsg = Nothing
        Me.NumeroControle.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NumeroControle.FlatBorder = False
        Me.NumeroControle.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NumeroControle.FocusColor = System.Drawing.Color.MistyRose
        Me.NumeroControle.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroControle.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroControle.HighlightBorderOnEnter = False
        Me.NumeroControle.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NumeroControle.Location = New System.Drawing.Point(116, 62)
        Me.NumeroControle.MaxLength = 15
        Me.NumeroControle.Name = "NumeroControle"
        Me.NumeroControle.PreencherZeroEsqueda = False
        Me.NumeroControle.RegraValidação = Nothing
        Me.NumeroControle.RegraValidaçãoMensagem = Nothing
        Me.NumeroControle.ShortcutsEnabled = False
        Me.NumeroControle.Size = New System.Drawing.Size(109, 28)
        Me.NumeroControle.TabIndex = 25
        Me.NumeroControle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroControle.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroControle.ValorPadrao = Nothing
        '
        'PedidoVendaAddNumeroControle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PedidoVendaAddNumeroControle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Número de Controle - T178"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents NumeroControle As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
End Class
