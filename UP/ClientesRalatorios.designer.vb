<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesRalatorios
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.optUF = New System.Windows.Forms.RadioButton()
        Me.optVendedor = New System.Windows.Forms.RadioButton()
        Me.optCidade = New System.Windows.Forms.RadioButton()
        Me.creterios = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtVendedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtUF = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtEndereco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtCidade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NomeMunic = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Nome = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.NomeUF = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Endereço = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Visualizar = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.creterios.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.creterios)
        Me.PanelEx1.Controls.Add(Me.Visualizar)
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(314, 402)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.optUF)
        Me.GroupPanel1.Controls.Add(Me.optVendedor)
        Me.GroupPanel1.Controls.Add(Me.optCidade)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(290, 143)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 9
        Me.GroupPanel1.Text = "Agrupados por:"
        '
        'optUF
        '
        Me.optUF.AutoSize = True
        Me.optUF.Location = New System.Drawing.Point(14, 37)
        Me.optUF.Name = "optUF"
        Me.optUF.Size = New System.Drawing.Size(106, 19)
        Me.optUF.TabIndex = 0
        Me.optUF.TabStop = True
        Me.optUF.Text = "Clientes por  UF"
        Me.optUF.UseVisualStyleBackColor = True
        '
        'optVendedor
        '
        Me.optVendedor.AutoSize = True
        Me.optVendedor.Location = New System.Drawing.Point(14, 62)
        Me.optVendedor.Name = "optVendedor"
        Me.optVendedor.Size = New System.Drawing.Size(136, 19)
        Me.optVendedor.TabIndex = 0
        Me.optVendedor.TabStop = True
        Me.optVendedor.Text = "Clientes por vendedor"
        Me.optVendedor.UseVisualStyleBackColor = True
        '
        'optCidade
        '
        Me.optCidade.AutoSize = True
        Me.optCidade.Location = New System.Drawing.Point(14, 12)
        Me.optCidade.Name = "optCidade"
        Me.optCidade.Size = New System.Drawing.Size(123, 19)
        Me.optCidade.TabIndex = 0
        Me.optCidade.TabStop = True
        Me.optCidade.Text = "Clientes por cidade"
        Me.optCidade.UseVisualStyleBackColor = True
        '
        'creterios
        '
        Me.creterios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.creterios.CanvasColor = System.Drawing.SystemColors.Control
        Me.creterios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.creterios.Controls.Add(Me.txtVendedor)
        Me.creterios.Controls.Add(Me.txtUF)
        Me.creterios.Controls.Add(Me.txtEndereco)
        Me.creterios.Controls.Add(Me.txtCidade)
        Me.creterios.Controls.Add(Me.NomeMunic)
        Me.creterios.Controls.Add(Me.Nome)
        Me.creterios.Controls.Add(Me.NomeUF)
        Me.creterios.Controls.Add(Me.Endereço)
        Me.creterios.Location = New System.Drawing.Point(12, 161)
        Me.creterios.Name = "creterios"
        Me.creterios.Size = New System.Drawing.Size(290, 196)
        '
        '
        '
        Me.creterios.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.creterios.Style.BackColorGradientAngle = 90
        Me.creterios.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.creterios.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.creterios.Style.BorderBottomWidth = 1
        Me.creterios.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.creterios.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.creterios.Style.BorderLeftWidth = 1
        Me.creterios.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.creterios.Style.BorderRightWidth = 1
        Me.creterios.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.creterios.Style.BorderTopWidth = 1
        Me.creterios.Style.CornerDiameter = 4
        Me.creterios.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.creterios.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.creterios.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.creterios.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.creterios.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.creterios.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.creterios.TabIndex = 9
        Me.creterios.Text = "Critérios para Filtros"
        '
        'txtVendedor
        '
        Me.txtVendedor.AceitaColarTexto = True
        Me.txtVendedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtVendedor.CasasDecimais = 0
        Me.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendedor.CPObrigatorio = False
        Me.txtVendedor.CPObrigatorioMsg = Nothing
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtVendedor.FlatBorder = False
        Me.txtVendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtVendedor.FocusColor = System.Drawing.Color.Empty
        Me.txtVendedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtVendedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.HighlightBorderOnEnter = False
        Me.txtVendedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtVendedor.Location = New System.Drawing.Point(85, 83)
        Me.txtVendedor.MaxLength = 50
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.PreencherZeroEsqueda = False
        Me.txtVendedor.RegraValidação = Nothing
        Me.txtVendedor.RegraValidaçãoMensagem = Nothing
        Me.txtVendedor.Size = New System.Drawing.Size(157, 23)
        Me.txtVendedor.TabIndex = 18
        Me.txtVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVendedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtVendedor.ValorPadrao = Nothing
        '
        'txtUF
        '
        Me.txtUF.AceitaColarTexto = True
        Me.txtUF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtUF.CasasDecimais = 0
        Me.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUF.CPObrigatorio = False
        Me.txtUF.CPObrigatorioMsg = Nothing
        Me.txtUF.Enabled = False
        Me.txtUF.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtUF.FlatBorder = False
        Me.txtUF.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtUF.FocusColor = System.Drawing.Color.Empty
        Me.txtUF.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtUF.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUF.HighlightBorderOnEnter = False
        Me.txtUF.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtUF.Location = New System.Drawing.Point(85, 54)
        Me.txtUF.MaxLength = 50
        Me.txtUF.Name = "txtUF"
        Me.txtUF.PreencherZeroEsqueda = False
        Me.txtUF.RegraValidação = Nothing
        Me.txtUF.RegraValidaçãoMensagem = Nothing
        Me.txtUF.Size = New System.Drawing.Size(157, 23)
        Me.txtUF.TabIndex = 19
        Me.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUF.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtUF.ValorPadrao = Nothing
        '
        'txtEndereco
        '
        Me.txtEndereco.AceitaColarTexto = True
        Me.txtEndereco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtEndereco.CasasDecimais = 0
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.CPObrigatorio = False
        Me.txtEndereco.CPObrigatorioMsg = Nothing
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtEndereco.FlatBorder = False
        Me.txtEndereco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtEndereco.FocusColor = System.Drawing.Color.Empty
        Me.txtEndereco.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtEndereco.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.HighlightBorderOnEnter = False
        Me.txtEndereco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtEndereco.Location = New System.Drawing.Point(85, 112)
        Me.txtEndereco.MaxLength = 50
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.PreencherZeroEsqueda = False
        Me.txtEndereco.RegraValidação = Nothing
        Me.txtEndereco.RegraValidaçãoMensagem = Nothing
        Me.txtEndereco.Size = New System.Drawing.Size(157, 23)
        Me.txtEndereco.TabIndex = 20
        Me.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEndereco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtEndereco.ValorPadrao = Nothing
        '
        'txtCidade
        '
        Me.txtCidade.AceitaColarTexto = True
        Me.txtCidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtCidade.CasasDecimais = 0
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.CPObrigatorio = False
        Me.txtCidade.CPObrigatorioMsg = Nothing
        Me.txtCidade.Enabled = False
        Me.txtCidade.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtCidade.FlatBorder = False
        Me.txtCidade.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtCidade.FocusColor = System.Drawing.Color.Empty
        Me.txtCidade.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtCidade.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.HighlightBorderOnEnter = False
        Me.txtCidade.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtCidade.Location = New System.Drawing.Point(85, 25)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.PreencherZeroEsqueda = False
        Me.txtCidade.RegraValidação = Nothing
        Me.txtCidade.RegraValidaçãoMensagem = Nothing
        Me.txtCidade.Size = New System.Drawing.Size(157, 23)
        Me.txtCidade.TabIndex = 21
        Me.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtCidade.ValorPadrao = Nothing
        '
        'NomeMunic
        '
        '
        '
        '
        Me.NomeMunic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NomeMunic.Location = New System.Drawing.Point(3, 25)
        Me.NomeMunic.Name = "NomeMunic"
        Me.NomeMunic.Size = New System.Drawing.Size(75, 27)
        Me.NomeMunic.TabIndex = 11
        Me.NomeMunic.Text = "Cidade"
        '
        'Nome
        '
        '
        '
        '
        Me.Nome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Nome.Location = New System.Drawing.Point(3, 83)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(70, 27)
        Me.Nome.TabIndex = 10
        Me.Nome.Text = "Vendedor"
        '
        'NomeUF
        '
        '
        '
        '
        Me.NomeUF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NomeUF.Location = New System.Drawing.Point(4, 54)
        Me.NomeUF.Name = "NomeUF"
        Me.NomeUF.Size = New System.Drawing.Size(35, 27)
        Me.NomeUF.TabIndex = 12
        Me.NomeUF.Text = "UF"
        '
        'Endereço
        '
        '
        '
        '
        Me.Endereço.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Endereço.Location = New System.Drawing.Point(4, 112)
        Me.Endereço.Name = "Endereço"
        Me.Endereço.Size = New System.Drawing.Size(75, 27)
        Me.Endereço.TabIndex = 13
        Me.Endereço.Text = "Endereço"
        '
        'Visualizar
        '
        Me.Visualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Visualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Visualizar.Location = New System.Drawing.Point(13, 363)
        Me.Visualizar.Name = "Visualizar"
        Me.Visualizar.Size = New System.Drawing.Size(118, 32)
        Me.Visualizar.TabIndex = 0
        Me.Visualizar.Text = "Visualizar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(191, 363)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(111, 32)
        Me.Fechar.TabIndex = 0
        Me.Fechar.Text = "Fechar"
        '
        'ClientesRalatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ClientesRalatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relátorios de Clientes - T004"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.creterios.ResumeLayout(False)
        Me.creterios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents creterios As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents NomeMunic As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Nome As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents NomeUF As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Endereço As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtVendedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtUF As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtEndereco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtCidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Visualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents optUF As System.Windows.Forms.RadioButton
    Friend WithEvents optVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents optCidade As System.Windows.Forms.RadioButton
End Class
