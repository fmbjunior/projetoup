<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GerarParcelasPagar
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Parcela = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Vencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ValorDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LocalPgto = New System.Windows.Forms.ComboBox()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Gerar = New DevComponents.DotNetBar.ButtonX()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Destino = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Qtd Parcela"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Parcela
        '
        Me.Parcela.AceitaColarTexto = True
        Me.Parcela.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Parcela.CasasDecimais = 0
        Me.Parcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Parcela.CPObrigatorio = False
        Me.Parcela.CPObrigatorioMsg = Nothing
        Me.Parcela.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Parcela.FlatBorder = False
        Me.Parcela.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Parcela.FocusColor = System.Drawing.Color.Empty
        Me.Parcela.FocusColorEnd = System.Drawing.Color.Empty
        Me.Parcela.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parcela.HighlightBorderOnEnter = False
        Me.Parcela.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Parcela.Location = New System.Drawing.Point(152, 14)
        Me.Parcela.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Parcela.Name = "Parcela"
        Me.Parcela.PreencherZeroEsqueda = False
        Me.Parcela.RegraValidação = Nothing
        Me.Parcela.RegraValidaçãoMensagem = Nothing
        Me.Parcela.Size = New System.Drawing.Size(48, 23)
        Me.Parcela.TabIndex = 1
        Me.Parcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Parcela.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Parcela.ValorPadrao = Nothing
        '
        'Vencimento
        '
        Me.Vencimento.AceitaColarTexto = True
        Me.Vencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vencimento.CasasDecimais = 0
        Me.Vencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vencimento.CPObrigatorio = False
        Me.Vencimento.CPObrigatorioMsg = Nothing
        Me.Vencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vencimento.FlatBorder = False
        Me.Vencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vencimento.FocusColor = System.Drawing.Color.Empty
        Me.Vencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vencimento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vencimento.HighlightBorderOnEnter = False
        Me.Vencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vencimento.Location = New System.Drawing.Point(381, 13)
        Me.Vencimento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Vencimento.MaxLength = 10
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PreencherZeroEsqueda = False
        Me.Vencimento.RegraValidação = Nothing
        Me.Vencimento.RegraValidaçãoMensagem = Nothing
        Me.Vencimento.Size = New System.Drawing.Size(93, 23)
        Me.Vencimento.TabIndex = 3
        Me.Vencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Vencimento.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Vencimento 1º Parcela"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AceitaColarTexto = True
        Me.ValorDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDocumento.CasasDecimais = 2
        Me.ValorDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDocumento.CPObrigatorio = False
        Me.ValorDocumento.CPObrigatorioMsg = Nothing
        Me.ValorDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDocumento.FlatBorder = False
        Me.ValorDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.FocusColor = System.Drawing.Color.Empty
        Me.ValorDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDocumento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorDocumento.HighlightBorderOnEnter = False
        Me.ValorDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.Location = New System.Drawing.Point(152, 42)
        Me.ValorDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValorDocumento.MaxLength = 10
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.PreencherZeroEsqueda = False
        Me.ValorDocumento.RegraValidação = Nothing
        Me.ValorDocumento.RegraValidaçãoMensagem = Nothing
        Me.ValorDocumento.Size = New System.Drawing.Size(148, 23)
        Me.ValorDocumento.TabIndex = 5
        Me.ValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDocumento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valor Documento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 24)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Local Pgto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocalPgto
        '
        Me.LocalPgto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.LocalPgto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LocalPgto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalPgto.FormattingEnabled = True
        Me.LocalPgto.Items.AddRange(New Object() {"BANCO", "CARTEIRA", "PERMUTA", "CHEQUE PRE-DATADO", "VISANET", "BB VENDOR", "PROTESTADO"})
        Me.LocalPgto.Location = New System.Drawing.Point(152, 70)
        Me.LocalPgto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LocalPgto.Name = "LocalPgto"
        Me.LocalPgto.Size = New System.Drawing.Size(148, 23)
        Me.LocalPgto.TabIndex = 7
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(282, 151)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(135, 31)
        Me.Fechar.TabIndex = 11
        Me.Fechar.Text = "Fechar"
        '
        'Gerar
        '
        Me.Gerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Gerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Gerar.Location = New System.Drawing.Point(152, 151)
        Me.Gerar.Name = "Gerar"
        Me.Gerar.Size = New System.Drawing.Size(124, 31)
        Me.Gerar.TabIndex = 10
        Me.Gerar.Text = "Gerar"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 20)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Destino"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Destino
        '
        Me.Destino.AceitaColarTexto = True
        Me.Destino.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Destino.CasasDecimais = 0
        Me.Destino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Destino.CPObrigatorio = False
        Me.Destino.CPObrigatorioMsg = Nothing
        Me.Destino.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Destino.FlatBorder = False
        Me.Destino.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Destino.FocusColor = System.Drawing.Color.Empty
        Me.Destino.FocusColorEnd = System.Drawing.Color.Empty
        Me.Destino.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destino.HighlightBorderOnEnter = False
        Me.Destino.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Destino.Location = New System.Drawing.Point(152, 102)
        Me.Destino.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Destino.MaxLength = 30
        Me.Destino.Name = "Destino"
        Me.Destino.PreencherZeroEsqueda = False
        Me.Destino.RegraValidação = Nothing
        Me.Destino.RegraValidaçãoMensagem = Nothing
        Me.Destino.Size = New System.Drawing.Size(321, 23)
        Me.Destino.TabIndex = 9
        Me.Destino.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Destino.ValorPadrao = Nothing
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Controls.Add(Me.Gerar)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(526, 194)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 12
        '
        'GerarParcelasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(526, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.Destino)
        Me.Controls.Add(Me.LocalPgto)
        Me.Controls.Add(Me.ValorDocumento)
        Me.Controls.Add(Me.Vencimento)
        Me.Controls.Add(Me.Parcela)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GerarParcelasPagar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerar Parcelas de Contas Pagar - T146"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Parcela As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Vencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ValorDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LocalPgto As System.Windows.Forms.ComboBox
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Gerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Destino As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
End Class
