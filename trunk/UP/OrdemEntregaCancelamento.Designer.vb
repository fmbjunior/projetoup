<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdemEntregaCancelamento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrdemEntrega = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ordem de Embarque a ser Cancelada"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrdemEntrega
        '
        Me.OrdemEntrega.AceitaColarTexto = True
        Me.OrdemEntrega.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.OrdemEntrega.CasasDecimais = 0
        Me.OrdemEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OrdemEntrega.CPObrigatorio = False
        Me.OrdemEntrega.CPObrigatorioMsg = Nothing
        Me.OrdemEntrega.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OrdemEntrega.FlatBorder = False
        Me.OrdemEntrega.FlatBorderColor = System.Drawing.Color.DimGray
        Me.OrdemEntrega.FocusColor = System.Drawing.Color.Empty
        Me.OrdemEntrega.FocusColorEnd = System.Drawing.Color.Empty
        Me.OrdemEntrega.HighlightBorderOnEnter = False
        Me.OrdemEntrega.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.OrdemEntrega.Location = New System.Drawing.Point(225, 44)
        Me.OrdemEntrega.Name = "OrdemEntrega"
        Me.OrdemEntrega.PreencherZeroEsqueda = False
        Me.OrdemEntrega.RegraValidação = Nothing
        Me.OrdemEntrega.RegraValidaçãoMensagem = Nothing
        Me.OrdemEntrega.Size = New System.Drawing.Size(116, 23)
        Me.OrdemEntrega.TabIndex = 1
        Me.OrdemEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OrdemEntrega.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.OrdemEntrega.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btCancelar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.OrdemEntrega)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(419, 163)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btCancelar
        '
        Me.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCancelar.Location = New System.Drawing.Point(241, 124)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(80, 27)
        Me.btCancelar.TabIndex = 2
        Me.btCancelar.Text = "Cancelar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(327, 124)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(80, 27)
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar"
        '
        'OrdemEntregaCancelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OrdemEntregaCancelamento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelamento de Ordem de Embarque - T164"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrdemEntrega As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
End Class
