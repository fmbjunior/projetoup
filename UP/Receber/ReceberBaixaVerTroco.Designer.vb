<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceberBaixaVerTroco
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ValorLiquido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Recebido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Troco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 30)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Valor Liquido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ValorLiquido
        '
        Me.ValorLiquido.AceitaColarTexto = True
        Me.ValorLiquido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorLiquido.CasasDecimais = 2
        Me.ValorLiquido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorLiquido.CPObrigatorio = False
        Me.ValorLiquido.CPObrigatorioMsg = Nothing
        Me.ValorLiquido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorLiquido.FlatBorder = False
        Me.ValorLiquido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorLiquido.FocusColor = System.Drawing.Color.Empty
        Me.ValorLiquido.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorLiquido.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorLiquido.ForeColor = System.Drawing.Color.Navy
        Me.ValorLiquido.HighlightBorderOnEnter = False
        Me.ValorLiquido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorLiquido.Location = New System.Drawing.Point(17, 41)
        Me.ValorLiquido.MaxLength = 10
        Me.ValorLiquido.Name = "ValorLiquido"
        Me.ValorLiquido.PreencherZeroEsqueda = False
        Me.ValorLiquido.RegraValidação = Nothing
        Me.ValorLiquido.RegraValidaçãoMensagem = Nothing
        Me.ValorLiquido.Size = New System.Drawing.Size(251, 37)
        Me.ValorLiquido.TabIndex = 34
        Me.ValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorLiquido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorLiquido.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 37)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Recebido"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Recebido
        '
        Me.Recebido.AceitaColarTexto = True
        Me.Recebido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Recebido.CasasDecimais = 2
        Me.Recebido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Recebido.CPObrigatorio = False
        Me.Recebido.CPObrigatorioMsg = Nothing
        Me.Recebido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Recebido.FlatBorder = False
        Me.Recebido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Recebido.FocusColor = System.Drawing.Color.Empty
        Me.Recebido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Recebido.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recebido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Recebido.HighlightBorderOnEnter = False
        Me.Recebido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Recebido.Location = New System.Drawing.Point(17, 121)
        Me.Recebido.MaxLength = 10
        Me.Recebido.Name = "Recebido"
        Me.Recebido.PreencherZeroEsqueda = False
        Me.Recebido.RegraValidação = Nothing
        Me.Recebido.RegraValidaçãoMensagem = Nothing
        Me.Recebido.Size = New System.Drawing.Size(251, 37)
        Me.Recebido.TabIndex = 36
        Me.Recebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Recebido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Recebido.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 37)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Troco"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Troco
        '
        Me.Troco.AceitaColarTexto = True
        Me.Troco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Troco.CasasDecimais = 2
        Me.Troco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Troco.CPObrigatorio = False
        Me.Troco.CPObrigatorioMsg = Nothing
        Me.Troco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Troco.FlatBorder = False
        Me.Troco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Troco.FocusColor = System.Drawing.Color.Empty
        Me.Troco.FocusColorEnd = System.Drawing.Color.Empty
        Me.Troco.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Troco.ForeColor = System.Drawing.Color.Maroon
        Me.Troco.HighlightBorderOnEnter = False
        Me.Troco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Troco.Location = New System.Drawing.Point(12, 201)
        Me.Troco.MaxLength = 10
        Me.Troco.Name = "Troco"
        Me.Troco.PreencherZeroEsqueda = False
        Me.Troco.RegraValidação = Nothing
        Me.Troco.RegraValidaçãoMensagem = Nothing
        Me.Troco.Size = New System.Drawing.Size(251, 37)
        Me.Troco.TabIndex = 38
        Me.Troco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Troco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Troco.ValorPadrao = Nothing
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.ValorLiquido)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Troco)
        Me.PanelEx1.Controls.Add(Me.Recebido)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(274, 298)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 55
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(12, 253)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(251, 33)
        Me.btFechar.TabIndex = 55
        Me.btFechar.Text = "Fechar"
        '
        'ReceberBaixaVerTroco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(274, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReceberBaixaVerTroco"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas a Receber - T060"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ValorLiquido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Recebido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Troco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
End Class
