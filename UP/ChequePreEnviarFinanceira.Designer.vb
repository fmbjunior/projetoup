<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChequePreEnviarFinanceira
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
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtFinanceira = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtDataEnvio = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Cheque = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Vencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Pedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValorCh = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CC = New TexBoxFocusNet.TextBoxFocusNet()
        Me.EntreguePor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Titular = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btnFechar)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(623, 270)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFechar.Location = New System.Drawing.Point(159, 238)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(133, 25)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.Text = "Fechar"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(12, 238)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(133, 25)
        Me.btSalvar.TabIndex = 2
        Me.btSalvar.Text = "Salvar"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtFinanceira)
        Me.GroupPanel2.Controls.Add(Me.txtDataEnvio)
        Me.GroupPanel2.Controls.Add(Me.Label8)
        Me.GroupPanel2.Controls.Add(Me.Label7)
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 180)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(599, 52)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        '
        'txtFinanceira
        '
        Me.txtFinanceira.AceitaColarTexto = True
        Me.txtFinanceira.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtFinanceira.CasasDecimais = 0
        Me.txtFinanceira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFinanceira.CPObrigatorio = False
        Me.txtFinanceira.CPObrigatorioMsg = Nothing
        Me.txtFinanceira.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtFinanceira.FlatBorder = False
        Me.txtFinanceira.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtFinanceira.FocusColor = System.Drawing.Color.MistyRose
        Me.txtFinanceira.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtFinanceira.HighlightBorderOnEnter = False
        Me.txtFinanceira.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtFinanceira.Location = New System.Drawing.Point(407, 15)
        Me.txtFinanceira.MaxLength = 20
        Me.txtFinanceira.Name = "txtFinanceira"
        Me.txtFinanceira.PreencherZeroEsqueda = False
        Me.txtFinanceira.RegraValidação = Nothing
        Me.txtFinanceira.RegraValidaçãoMensagem = Nothing
        Me.txtFinanceira.Size = New System.Drawing.Size(178, 20)
        Me.txtFinanceira.TabIndex = 3
        Me.txtFinanceira.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtFinanceira.ValorPadrao = Nothing
        '
        'txtDataEnvio
        '
        Me.txtDataEnvio.AceitaColarTexto = True
        Me.txtDataEnvio.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtDataEnvio.CasasDecimais = 0
        Me.txtDataEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEnvio.CPObrigatorio = False
        Me.txtDataEnvio.CPObrigatorioMsg = Nothing
        Me.txtDataEnvio.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtDataEnvio.FlatBorder = False
        Me.txtDataEnvio.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtDataEnvio.FocusColor = System.Drawing.Color.MistyRose
        Me.txtDataEnvio.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtDataEnvio.HighlightBorderOnEnter = False
        Me.txtDataEnvio.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtDataEnvio.Location = New System.Drawing.Point(83, 15)
        Me.txtDataEnvio.MaxLength = 10
        Me.txtDataEnvio.Name = "txtDataEnvio"
        Me.txtDataEnvio.PreencherZeroEsqueda = False
        Me.txtDataEnvio.RegraValidação = Nothing
        Me.txtDataEnvio.RegraValidaçãoMensagem = Nothing
        Me.txtDataEnvio.Size = New System.Drawing.Size(116, 20)
        Me.txtDataEnvio.TabIndex = 1
        Me.txtDataEnvio.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtDataEnvio.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(2, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Data Envio"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(319, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Financeira"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Cheque)
        Me.GroupPanel1.Controls.Add(Me.Vencimento)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Pedido)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.ValorCh)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.CC)
        Me.GroupPanel1.Controls.Add(Me.EntreguePor)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Titular)
        Me.GroupPanel1.Enabled = False
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(599, 162)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Dados do Cheque"
        '
        'Cheque
        '
        Me.Cheque.AceitaColarTexto = True
        Me.Cheque.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cheque.CasasDecimais = 0
        Me.Cheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cheque.CPObrigatorio = False
        Me.Cheque.CPObrigatorioMsg = Nothing
        Me.Cheque.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cheque.FlatBorder = False
        Me.Cheque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cheque.FocusColor = System.Drawing.Color.MistyRose
        Me.Cheque.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cheque.HighlightBorderOnEnter = False
        Me.Cheque.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cheque.Location = New System.Drawing.Point(161, 3)
        Me.Cheque.Name = "Cheque"
        Me.Cheque.PreencherZeroEsqueda = False
        Me.Cheque.RegraValidação = Nothing
        Me.Cheque.RegraValidaçãoMensagem = Nothing
        Me.Cheque.Size = New System.Drawing.Size(116, 20)
        Me.Cheque.TabIndex = 1
        Me.Cheque.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cheque.ValorPadrao = Nothing
        '
        'Vencimento
        '
        Me.Vencimento.AceitaColarTexto = True
        Me.Vencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Vencimento.CasasDecimais = 0
        Me.Vencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vencimento.CPObrigatorio = False
        Me.Vencimento.CPObrigatorioMsg = Nothing
        Me.Vencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vencimento.FlatBorder = False
        Me.Vencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vencimento.FocusColor = System.Drawing.Color.MistyRose
        Me.Vencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vencimento.HighlightBorderOnEnter = False
        Me.Vencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vencimento.Location = New System.Drawing.Point(469, 90)
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PreencherZeroEsqueda = False
        Me.Vencimento.RegraValidação = Nothing
        Me.Vencimento.RegraValidaçãoMensagem = Nothing
        Me.Vencimento.Size = New System.Drawing.Size(116, 20)
        Me.Vencimento.TabIndex = 11
        Me.Vencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Vencimento.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(319, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Vencimento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pedido
        '
        Me.Pedido.AceitaColarTexto = True
        Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Pedido.CasasDecimais = 0
        Me.Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pedido.CPObrigatorio = False
        Me.Pedido.CPObrigatorioMsg = Nothing
        Me.Pedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Pedido.FlatBorder = False
        Me.Pedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Pedido.FocusColor = System.Drawing.Color.MistyRose
        Me.Pedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pedido.HighlightBorderOnEnter = False
        Me.Pedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Pedido.Location = New System.Drawing.Point(161, 116)
        Me.Pedido.Name = "Pedido"
        Me.Pedido.PreencherZeroEsqueda = False
        Me.Pedido.RegraValidação = Nothing
        Me.Pedido.RegraValidaçãoMensagem = Nothing
        Me.Pedido.Size = New System.Drawing.Size(116, 20)
        Me.Pedido.TabIndex = 13
        Me.Pedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pedido.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(11, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Pedido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cheque"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(366, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "C/C"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorCh
        '
        Me.ValorCh.AceitaColarTexto = True
        Me.ValorCh.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorCh.CasasDecimais = 2
        Me.ValorCh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorCh.CPObrigatorio = False
        Me.ValorCh.CPObrigatorioMsg = Nothing
        Me.ValorCh.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorCh.FlatBorder = False
        Me.ValorCh.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorCh.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorCh.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorCh.HighlightBorderOnEnter = False
        Me.ValorCh.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorCh.Location = New System.Drawing.Point(161, 90)
        Me.ValorCh.Name = "ValorCh"
        Me.ValorCh.PreencherZeroEsqueda = False
        Me.ValorCh.RegraValidação = Nothing
        Me.ValorCh.RegraValidaçãoMensagem = Nothing
        Me.ValorCh.Size = New System.Drawing.Size(116, 20)
        Me.ValorCh.TabIndex = 9
        Me.ValorCh.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorCh.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(11, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Valor do Cheque"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CC
        '
        Me.CC.AceitaColarTexto = True
        Me.CC.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CC.CasasDecimais = 0
        Me.CC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CC.CPObrigatorio = False
        Me.CC.CPObrigatorioMsg = Nothing
        Me.CC.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CC.FlatBorder = False
        Me.CC.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CC.FocusColor = System.Drawing.Color.MistyRose
        Me.CC.FocusColorEnd = System.Drawing.Color.Empty
        Me.CC.HighlightBorderOnEnter = False
        Me.CC.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CC.Location = New System.Drawing.Point(469, 3)
        Me.CC.Name = "CC"
        Me.CC.PreencherZeroEsqueda = False
        Me.CC.RegraValidação = Nothing
        Me.CC.RegraValidaçãoMensagem = Nothing
        Me.CC.Size = New System.Drawing.Size(116, 20)
        Me.CC.TabIndex = 3
        Me.CC.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CC.ValorPadrao = Nothing
        '
        'EntreguePor
        '
        Me.EntreguePor.AceitaColarTexto = True
        Me.EntreguePor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EntreguePor.CasasDecimais = 0
        Me.EntreguePor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntreguePor.CPObrigatorio = False
        Me.EntreguePor.CPObrigatorioMsg = Nothing
        Me.EntreguePor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntreguePor.FlatBorder = False
        Me.EntreguePor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EntreguePor.FocusColor = System.Drawing.Color.MistyRose
        Me.EntreguePor.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntreguePor.HighlightBorderOnEnter = False
        Me.EntreguePor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EntreguePor.Location = New System.Drawing.Point(161, 61)
        Me.EntreguePor.Name = "EntreguePor"
        Me.EntreguePor.PreencherZeroEsqueda = False
        Me.EntreguePor.RegraValidação = Nothing
        Me.EntreguePor.RegraValidaçãoMensagem = Nothing
        Me.EntreguePor.Size = New System.Drawing.Size(424, 20)
        Me.EntreguePor.TabIndex = 7
        Me.EntreguePor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntreguePor.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(11, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Titular"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(11, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Entregue Por"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Titular
        '
        Me.Titular.AceitaColarTexto = True
        Me.Titular.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Titular.CasasDecimais = 0
        Me.Titular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Titular.CPObrigatorio = False
        Me.Titular.CPObrigatorioMsg = Nothing
        Me.Titular.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Titular.FlatBorder = False
        Me.Titular.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Titular.FocusColor = System.Drawing.Color.MistyRose
        Me.Titular.FocusColorEnd = System.Drawing.Color.Empty
        Me.Titular.HighlightBorderOnEnter = False
        Me.Titular.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Titular.Location = New System.Drawing.Point(161, 32)
        Me.Titular.Name = "Titular"
        Me.Titular.PreencherZeroEsqueda = False
        Me.Titular.RegraValidação = Nothing
        Me.Titular.RegraValidaçãoMensagem = Nothing
        Me.Titular.Size = New System.Drawing.Size(424, 20)
        Me.Titular.TabIndex = 5
        Me.Titular.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Titular.ValorPadrao = Nothing
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ChequePreEnviarFinanceira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ChequePreEnviarFinanceira"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar para Fananceira - T115"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Cheque As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Pedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Vencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ValorCh As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CC As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EntreguePor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Titular As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtFinanceira As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtDataEnvio As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
