<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteCPFCNPJ
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
        Me.CpfCgc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoPessoa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btOK = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.CpfCgc)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.TipoPessoa)
        Me.PanelEx1.Controls.Add(Me.btOK)
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(332, 146)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'CpfCgc
        '
        Me.CpfCgc.AceitaColarTexto = False
        Me.CpfCgc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CpfCgc.CasasDecimais = 0
        Me.CpfCgc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CpfCgc.CPObrigatorio = False
        Me.CpfCgc.CPObrigatorioMsg = Nothing
        Me.CpfCgc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CpfCgc.FlatBorder = False
        Me.CpfCgc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CpfCgc.FocusColor = System.Drawing.Color.MistyRose
        Me.CpfCgc.FocusColorEnd = System.Drawing.Color.Empty
        Me.CpfCgc.HighlightBorderOnEnter = False
        Me.CpfCgc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CpfCgc.Location = New System.Drawing.Point(124, 53)
        Me.CpfCgc.Name = "CpfCgc"
        Me.CpfCgc.PreencherZeroEsqueda = False
        Me.CpfCgc.RegraValidação = Nothing
        Me.CpfCgc.RegraValidaçãoMensagem = Nothing
        Me.CpfCgc.ShortcutsEnabled = False
        Me.CpfCgc.Size = New System.Drawing.Size(196, 23)
        Me.CpfCgc.TabIndex = 3
        Me.CpfCgc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CpfCgc.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cnpj/Cpf"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "F-Físico J-Jurídico"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoPessoa
        '
        Me.TipoPessoa.AceitaColarTexto = True
        Me.TipoPessoa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TipoPessoa.CasasDecimais = 0
        Me.TipoPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TipoPessoa.CPObrigatorio = False
        Me.TipoPessoa.CPObrigatorioMsg = Nothing
        Me.TipoPessoa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TipoPessoa.FlatBorder = False
        Me.TipoPessoa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TipoPessoa.FocusColor = System.Drawing.Color.MistyRose
        Me.TipoPessoa.FocusColorEnd = System.Drawing.Color.Empty
        Me.TipoPessoa.HighlightBorderOnEnter = False
        Me.TipoPessoa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TipoPessoa.Location = New System.Drawing.Point(124, 24)
        Me.TipoPessoa.MaxLength = 1
        Me.TipoPessoa.Name = "TipoPessoa"
        Me.TipoPessoa.PreencherZeroEsqueda = False
        Me.TipoPessoa.RegraValidação = "F:J"
        Me.TipoPessoa.RegraValidaçãoMensagem = "F-Para Pessoa Física J-Para Pessoa jurídica"
        Me.TipoPessoa.Size = New System.Drawing.Size(41, 23)
        Me.TipoPessoa.TabIndex = 1
        Me.TipoPessoa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TipoPessoa.ValorPadrao = Nothing
        '
        'btOK
        '
        Me.btOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btOK.Location = New System.Drawing.Point(182, 109)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(66, 25)
        Me.btOK.TabIndex = 4
        Me.btOK.Text = "OK"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(254, 109)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(66, 25)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar"
        '
        'ClienteCPFCNPJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 146)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ClienteCPFCNPJ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CPF/CNPJ de Clientes - T120"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TipoPessoa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CpfCgc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
