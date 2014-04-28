<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesVerSaldoCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesVerSaldoCredito))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Saldo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LimiteMensal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.EmDebito = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.VendaCrediario = New System.Windows.Forms.CheckBox()
        Me.UsarLimite = New System.Windows.Forms.CheckBox()
        Me.VendaCheque = New System.Windows.Forms.CheckBox()
        Me.VendaVista = New System.Windows.Forms.CheckBox()
        Me.btFindClintes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Saldo)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.LimiteMensal)
        Me.PanelEx1.Controls.Add(Me.Label23)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.EmDebito)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel4)
        Me.PanelEx1.Controls.Add(Me.btFindClintes)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Cliente)
        Me.PanelEx1.Controls.Add(Me.ClienteDesc)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(775, 267)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Saldo
        '
        Me.Saldo.AceitaColarTexto = False
        Me.Saldo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Saldo.CasasDecimais = 2
        Me.Saldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Saldo.CPObrigatorio = False
        Me.Saldo.CPObrigatorioMsg = Nothing
        Me.Saldo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Saldo.FlatBorder = False
        Me.Saldo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Saldo.FocusColor = System.Drawing.Color.MistyRose
        Me.Saldo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Saldo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saldo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Saldo.HighlightBorderOnEnter = False
        Me.Saldo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Saldo.Location = New System.Drawing.Point(579, 151)
        Me.Saldo.MaxLength = 15
        Me.Saldo.Name = "Saldo"
        Me.Saldo.PreencherZeroEsqueda = False
        Me.Saldo.RegraValidação = Nothing
        Me.Saldo.RegraValidaçãoMensagem = Nothing
        Me.Saldo.Size = New System.Drawing.Size(184, 34)
        Me.Saldo.TabIndex = 10
        Me.Saldo.TabStop = False
        Me.Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Saldo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Saldo.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(415, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 35)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Valor Saldo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LimiteMensal
        '
        Me.LimiteMensal.AceitaColarTexto = False
        Me.LimiteMensal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.LimiteMensal.CasasDecimais = 2
        Me.LimiteMensal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LimiteMensal.CPObrigatorio = False
        Me.LimiteMensal.CPObrigatorioMsg = Nothing
        Me.LimiteMensal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.LimiteMensal.FlatBorder = False
        Me.LimiteMensal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.LimiteMensal.FocusColor = System.Drawing.Color.MistyRose
        Me.LimiteMensal.FocusColorEnd = System.Drawing.Color.Empty
        Me.LimiteMensal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimiteMensal.HighlightBorderOnEnter = False
        Me.LimiteMensal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.LimiteMensal.Location = New System.Drawing.Point(579, 71)
        Me.LimiteMensal.MaxLength = 15
        Me.LimiteMensal.Name = "LimiteMensal"
        Me.LimiteMensal.PreencherZeroEsqueda = False
        Me.LimiteMensal.RegraValidação = Nothing
        Me.LimiteMensal.RegraValidaçãoMensagem = Nothing
        Me.LimiteMensal.Size = New System.Drawing.Size(184, 34)
        Me.LimiteMensal.TabIndex = 6
        Me.LimiteMensal.TabStop = False
        Me.LimiteMensal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LimiteMensal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.LimiteMensal.ValorPadrao = Nothing
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(415, 71)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(154, 34)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Valor Limíte"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(679, 232)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(84, 29)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 11
        Me.btFechar.Text = "Fechar"
        '
        'EmDebito
        '
        Me.EmDebito.AceitaColarTexto = False
        Me.EmDebito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EmDebito.CasasDecimais = 2
        Me.EmDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmDebito.CPObrigatorio = False
        Me.EmDebito.CPObrigatorioMsg = Nothing
        Me.EmDebito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EmDebito.FlatBorder = False
        Me.EmDebito.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EmDebito.FocusColor = System.Drawing.Color.MistyRose
        Me.EmDebito.FocusColorEnd = System.Drawing.Color.Empty
        Me.EmDebito.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmDebito.ForeColor = System.Drawing.Color.Red
        Me.EmDebito.HighlightBorderOnEnter = False
        Me.EmDebito.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EmDebito.Location = New System.Drawing.Point(579, 111)
        Me.EmDebito.MaxLength = 15
        Me.EmDebito.Name = "EmDebito"
        Me.EmDebito.PreencherZeroEsqueda = False
        Me.EmDebito.RegraValidação = Nothing
        Me.EmDebito.RegraValidaçãoMensagem = Nothing
        Me.EmDebito.Size = New System.Drawing.Size(184, 34)
        Me.EmDebito.TabIndex = 8
        Me.EmDebito.TabStop = False
        Me.EmDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EmDebito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.EmDebito.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(415, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 35)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Valor em Débito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.VendaCrediario)
        Me.GroupPanel4.Controls.Add(Me.UsarLimite)
        Me.GroupPanel4.Controls.Add(Me.VendaCheque)
        Me.GroupPanel4.Controls.Add(Me.VendaVista)
        Me.GroupPanel4.Location = New System.Drawing.Point(15, 60)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(320, 135)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 4
        Me.GroupPanel4.Text = "Crediario e Bloqueios"
        '
        'VendaCrediario
        '
        Me.VendaCrediario.AutoSize = True
        Me.VendaCrediario.BackColor = System.Drawing.Color.Transparent
        Me.VendaCrediario.Enabled = False
        Me.VendaCrediario.Location = New System.Drawing.Point(5, 54)
        Me.VendaCrediario.Name = "VendaCrediario"
        Me.VendaCrediario.Size = New System.Drawing.Size(124, 19)
        Me.VendaCrediario.TabIndex = 2
        Me.VendaCrediario.Text = "Venda no Crediário"
        Me.VendaCrediario.UseVisualStyleBackColor = False
        '
        'UsarLimite
        '
        Me.UsarLimite.AutoSize = True
        Me.UsarLimite.BackColor = System.Drawing.Color.Transparent
        Me.UsarLimite.Enabled = False
        Me.UsarLimite.Location = New System.Drawing.Point(5, 79)
        Me.UsarLimite.Name = "UsarLimite"
        Me.UsarLimite.Size = New System.Drawing.Size(85, 19)
        Me.UsarLimite.TabIndex = 3
        Me.UsarLimite.Text = "Usar Limite"
        Me.UsarLimite.UseVisualStyleBackColor = False
        '
        'VendaCheque
        '
        Me.VendaCheque.AutoSize = True
        Me.VendaCheque.BackColor = System.Drawing.Color.Transparent
        Me.VendaCheque.Enabled = False
        Me.VendaCheque.Location = New System.Drawing.Point(5, 29)
        Me.VendaCheque.Name = "VendaCheque"
        Me.VendaCheque.Size = New System.Drawing.Size(120, 19)
        Me.VendaCheque.TabIndex = 1
        Me.VendaCheque.Text = "Venda com Cheque"
        Me.VendaCheque.UseVisualStyleBackColor = False
        '
        'VendaVista
        '
        Me.VendaVista.AutoSize = True
        Me.VendaVista.BackColor = System.Drawing.Color.Transparent
        Me.VendaVista.Enabled = False
        Me.VendaVista.Location = New System.Drawing.Point(5, 5)
        Me.VendaVista.Name = "VendaVista"
        Me.VendaVista.Size = New System.Drawing.Size(95, 19)
        Me.VendaVista.TabIndex = 0
        Me.VendaVista.Text = "Venda a Vista"
        Me.VendaVista.UseVisualStyleBackColor = False
        '
        'btFindClintes
        '
        Me.btFindClintes.Image = CType(resources.GetObject("btFindClintes.Image"), System.Drawing.Image)
        Me.btFindClintes.Location = New System.Drawing.Point(88, 31)
        Me.btFindClintes.Name = "btFindClintes"
        Me.btFindClintes.Size = New System.Drawing.Size(23, 23)
        Me.btFindClintes.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Informe o Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(15, 31)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(72, 23)
        Me.Cliente.TabIndex = 0
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = True
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteDesc.FlatBorder = False
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.FocusColor = System.Drawing.Color.Empty
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(112, 31)
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(651, 23)
        Me.ClienteDesc.TabIndex = 3
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'ClientesVerSaldoCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "ClientesVerSaldoCredito"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificar Saldo de Crédito - T003"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFindClintes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LimiteMensal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents UsarLimite As System.Windows.Forms.CheckBox
    Friend WithEvents VendaCrediario As System.Windows.Forms.CheckBox
    Friend WithEvents VendaCheque As System.Windows.Forms.CheckBox
    Friend WithEvents VendaVista As System.Windows.Forms.CheckBox
    Friend WithEvents EmDebito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Saldo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
