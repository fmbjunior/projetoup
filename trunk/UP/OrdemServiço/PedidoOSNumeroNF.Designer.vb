<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoOSNumeroNF
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nfs = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Nfe = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Nfs)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Label23)
        Me.PanelEx1.Controls.Add(Me.Nfe)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(371, 167)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Tag = "8"
        Me.Label1.Text = "Informe o NFe Serv"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nfs
        '
        Me.Nfs.AceitaColarTexto = False
        Me.Nfs.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Nfs.CasasDecimais = 0
        Me.Nfs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nfs.CPObrigatorio = False
        Me.Nfs.CPObrigatorioMsg = Nothing
        Me.Nfs.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Nfs.FlatBorder = False
        Me.Nfs.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Nfs.FocusColor = System.Drawing.Color.MistyRose
        Me.Nfs.FocusColorEnd = System.Drawing.Color.Empty
        Me.Nfs.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nfs.HighlightBorderOnEnter = False
        Me.Nfs.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Nfs.Location = New System.Drawing.Point(166, 65)
        Me.Nfs.MaxLength = 15
        Me.Nfs.Name = "Nfs"
        Me.Nfs.PreencherZeroEsqueda = False
        Me.Nfs.RegraValidação = Nothing
        Me.Nfs.RegraValidaçãoMensagem = Nothing
        Me.Nfs.ShortcutsEnabled = False
        Me.Nfs.Size = New System.Drawing.Size(157, 28)
        Me.Nfs.TabIndex = 1
        Me.Nfs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nfs.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Nfs.ValorPadrao = Nothing
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(165, 111)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(76, 28)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 2
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(247, 111)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(76, 28)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(148, 28)
        Me.Label23.TabIndex = 4
        Me.Label23.Tag = "8"
        Me.Label23.Text = "Informe o NFe Peças"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nfe
        '
        Me.Nfe.AceitaColarTexto = False
        Me.Nfe.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Nfe.CasasDecimais = 0
        Me.Nfe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nfe.CPObrigatorio = False
        Me.Nfe.CPObrigatorioMsg = Nothing
        Me.Nfe.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Nfe.FlatBorder = False
        Me.Nfe.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Nfe.FocusColor = System.Drawing.Color.MistyRose
        Me.Nfe.FocusColorEnd = System.Drawing.Color.Empty
        Me.Nfe.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nfe.HighlightBorderOnEnter = False
        Me.Nfe.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Nfe.Location = New System.Drawing.Point(166, 31)
        Me.Nfe.MaxLength = 15
        Me.Nfe.Name = "Nfe"
        Me.Nfe.PreencherZeroEsqueda = False
        Me.Nfe.RegraValidação = Nothing
        Me.Nfe.RegraValidaçãoMensagem = Nothing
        Me.Nfe.ShortcutsEnabled = False
        Me.Nfe.Size = New System.Drawing.Size(157, 28)
        Me.Nfe.TabIndex = 0
        Me.Nfe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nfe.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Nfe.ValorPadrao = Nothing
        '
        'PedidoOSNumeroNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "PedidoOSNumeroNF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PedidoOSNumeroNF"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Nfs As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Nfe As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
