<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagarRelat
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
        Me.components = New System.ComponentModel.Container()
        Me.PainelForncedor = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FornecedorDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fornecedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A14 = New System.Windows.Forms.RadioButton()
        Me.A5 = New System.Windows.Forms.RadioButton()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A13 = New System.Windows.Forms.RadioButton()
        Me.A12 = New System.Windows.Forms.RadioButton()
        Me.A11 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.PainelCheque = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cheque = New TexBoxFocusNet.TextBoxFocusNet()
        Me.BalãoAjuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btVisualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A6 = New System.Windows.Forms.RadioButton()
        Me.PainelLocal = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Local = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelForncedor.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        Me.PainelCheque.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PainelLocal.SuspendLayout()
        Me.SuspendLayout()
        '
        'PainelForncedor
        '
        Me.PainelForncedor.Controls.Add(Me.Label3)
        Me.PainelForncedor.Controls.Add(Me.FornecedorDesc)
        Me.PainelForncedor.Controls.Add(Me.Label1)
        Me.PainelForncedor.Controls.Add(Me.Fornecedor)
        Me.PainelForncedor.Location = New System.Drawing.Point(313, 97)
        Me.PainelForncedor.Name = "PainelForncedor"
        Me.PainelForncedor.Size = New System.Drawing.Size(467, 60)
        Me.PainelForncedor.TabIndex = 3
        Me.PainelForncedor.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(217, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Não informar o período para todas as contas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FornecedorDesc
        '
        Me.FornecedorDesc.AceitaColarTexto = True
        Me.FornecedorDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FornecedorDesc.CasasDecimais = 0
        Me.FornecedorDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FornecedorDesc.CPObrigatorio = False
        Me.FornecedorDesc.CPObrigatorioMsg = Nothing
        Me.FornecedorDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FornecedorDesc.FlatBorder = False
        Me.FornecedorDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FornecedorDesc.FocusColor = System.Drawing.Color.Empty
        Me.FornecedorDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FornecedorDesc.HighlightBorderOnEnter = False
        Me.FornecedorDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FornecedorDesc.Location = New System.Drawing.Point(132, 32)
        Me.FornecedorDesc.Name = "FornecedorDesc"
        Me.FornecedorDesc.PreencherZeroEsqueda = False
        Me.FornecedorDesc.RegraValidação = Nothing
        Me.FornecedorDesc.RegraValidaçãoMensagem = Nothing
        Me.FornecedorDesc.Size = New System.Drawing.Size(330, 23)
        Me.FornecedorDesc.TabIndex = 3
        Me.FornecedorDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FornecedorDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inf. o Fornecedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fornecedor
        '
        Me.Fornecedor.AceitaColarTexto = True
        Me.Fornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Fornecedor.CasasDecimais = 0
        Me.Fornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fornecedor.CPObrigatorio = False
        Me.Fornecedor.CPObrigatorioMsg = Nothing
        Me.Fornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Fornecedor.FlatBorder = False
        Me.Fornecedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Fornecedor.FocusColor = System.Drawing.Color.Empty
        Me.Fornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.Fornecedor.HighlightBorderOnEnter = False
        Me.Fornecedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Fornecedor.Location = New System.Drawing.Point(132, 3)
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.PreencherZeroEsqueda = False
        Me.Fornecedor.RegraValidação = Nothing
        Me.Fornecedor.RegraValidaçãoMensagem = Nothing
        Me.Fornecedor.Size = New System.Drawing.Size(77, 23)
        Me.Fornecedor.TabIndex = 1
        Me.Fornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Fornecedor.ValorPadrao = Nothing
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label9)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(313, 61)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(383, 30)
        Me.PainelPeriodo.TabIndex = 2
        Me.PainelPeriodo.Visible = False
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FlatBorder = False
        Me.DataFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.HighlightBorderOnEnter = False
        Me.DataFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataFinal.Location = New System.Drawing.Point(255, 3)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(116, 23)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(5, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Informe o Período"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 0
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FlatBorder = False
        Me.DataInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.HighlightBorderOnEnter = False
        Me.DataInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataInicial.Location = New System.Drawing.Point(132, 3)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(116, 23)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'A14
        '
        Me.A14.AutoSize = True
        Me.A14.Location = New System.Drawing.Point(3, 187)
        Me.A14.Name = "A14"
        Me.A14.Size = New System.Drawing.Size(149, 19)
        Me.A14.TabIndex = 8
        Me.A14.TabStop = True
        Me.A14.Text = "Histórico de Fornecedor"
        Me.A14.UseVisualStyleBackColor = True
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(3, 98)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(187, 19)
        Me.A5.TabIndex = 4
        Me.A5.TabStop = True
        Me.A5.Text = "A Pagar por Local de Pagamento"
        Me.A5.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(3, 79)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(145, 19)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "A Pagar Vencidas Geral"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(3, 60)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(195, 19)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "A Pagar Vencidas por Fornecedor"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A13
        '
        Me.A13.AutoSize = True
        Me.A13.Location = New System.Drawing.Point(3, 165)
        Me.A13.Name = "A13"
        Me.A13.Size = New System.Drawing.Size(151, 19)
        Me.A13.TabIndex = 7
        Me.A13.TabStop = True
        Me.A13.Text = "Contas Pagas por Cheque"
        Me.A13.UseVisualStyleBackColor = True
        '
        'A12
        '
        Me.A12.AutoSize = True
        Me.A12.Location = New System.Drawing.Point(3, 142)
        Me.A12.Name = "A12"
        Me.A12.Size = New System.Drawing.Size(135, 19)
        Me.A12.TabIndex = 6
        Me.A12.TabStop = True
        Me.A12.Text = "Pagas por Fornecedor"
        Me.A12.UseVisualStyleBackColor = True
        '
        'A11
        '
        Me.A11.AutoSize = True
        Me.A11.Location = New System.Drawing.Point(3, 120)
        Me.A11.Name = "A11"
        Me.A11.Size = New System.Drawing.Size(111, 19)
        Me.A11.TabIndex = 5
        Me.A11.TabStop = True
        Me.A11.Text = "Pagas no Período"
        Me.A11.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(3, 41)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(146, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "A Pagar por Fornecedor"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(122, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "A Pagar no Período"
        Me.A1.UseVisualStyleBackColor = True
        '
        'PainelCheque
        '
        Me.PainelCheque.Controls.Add(Me.Label2)
        Me.PainelCheque.Controls.Add(Me.Cheque)
        Me.PainelCheque.Location = New System.Drawing.Point(313, 25)
        Me.PainelCheque.Name = "PainelCheque"
        Me.PainelCheque.Size = New System.Drawing.Size(383, 30)
        Me.PainelCheque.TabIndex = 1
        Me.PainelCheque.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Informe o Nº Ch."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cheque
        '
        Me.Cheque.AceitaColarTexto = True
        Me.Cheque.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cheque.CasasDecimais = 0
        Me.Cheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cheque.CPObrigatorio = False
        Me.Cheque.CPObrigatorioMsg = Nothing
        Me.Cheque.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cheque.FlatBorder = False
        Me.Cheque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cheque.FocusColor = System.Drawing.Color.Empty
        Me.Cheque.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cheque.HighlightBorderOnEnter = False
        Me.Cheque.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cheque.Location = New System.Drawing.Point(132, 2)
        Me.Cheque.Name = "Cheque"
        Me.Cheque.PreencherZeroEsqueda = False
        Me.Cheque.RegraValidação = Nothing
        Me.Cheque.RegraValidaçãoMensagem = Nothing
        Me.Cheque.Size = New System.Drawing.Size(138, 23)
        Me.Cheque.TabIndex = 1
        Me.Cheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cheque.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cheque.ValorPadrao = Nothing
        '
        'BalãoAjuda
        '
        Me.BalãoAjuda.IsBalloon = True
        Me.BalãoAjuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.BalãoAjuda.ToolTipTitle = "Ajuda E-Focus"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btVisualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.PainelLocal)
        Me.Fundo.Controls.Add(Me.PainelCheque)
        Me.Fundo.Controls.Add(Me.PainelPeriodo)
        Me.Fundo.Controls.Add(Me.PainelForncedor)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(787, 293)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btVisualizar
        '
        Me.btVisualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVisualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVisualizar.Location = New System.Drawing.Point(610, 231)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(82, 30)
        Me.btVisualizar.TabIndex = 9
        Me.btVisualizar.Text = "Visualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(698, 231)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(82, 30)
        Me.btFechar.TabIndex = 8
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A14)
        Me.GroupPanel1.Controls.Add(Me.A6)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A13)
        Me.GroupPanel1.Controls.Add(Me.A5)
        Me.GroupPanel1.Controls.Add(Me.A12)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A11)
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(295, 258)
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
        Me.GroupPanel1.TabIndex = 7
        Me.GroupPanel1.Text = "Selecione uma das Opções"
        '
        'A6
        '
        Me.A6.AutoSize = True
        Me.A6.Location = New System.Drawing.Point(3, 22)
        Me.A6.Name = "A6"
        Me.A6.Size = New System.Drawing.Size(203, 19)
        Me.A6.TabIndex = 0
        Me.A6.TabStop = True
        Me.A6.Text = "A Pagar no período por vencimento"
        Me.A6.UseVisualStyleBackColor = True
        '
        'PainelLocal
        '
        Me.PainelLocal.Controls.Add(Me.Label4)
        Me.PainelLocal.Controls.Add(Me.Local)
        Me.PainelLocal.Location = New System.Drawing.Point(313, 163)
        Me.PainelLocal.Name = "PainelLocal"
        Me.PainelLocal.Size = New System.Drawing.Size(467, 30)
        Me.PainelLocal.TabIndex = 6
        Me.PainelLocal.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Informe o Local"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Local
        '
        Me.Local.AceitaColarTexto = True
        Me.Local.AutoCompleteCustomSource.AddRange(New String() {"Banco", "Carteira", "Permuta", "Cheque Pré-Datado", "VisaNet", "BB Vendor", "Protestado"})
        Me.Local.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Local.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Local.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Local.CasasDecimais = 0
        Me.Local.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Local.CPObrigatorio = False
        Me.Local.CPObrigatorioMsg = Nothing
        Me.Local.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Local.FlatBorder = False
        Me.Local.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Local.FocusColor = System.Drawing.Color.Empty
        Me.Local.FocusColorEnd = System.Drawing.Color.Empty
        Me.Local.HighlightBorderOnEnter = False
        Me.Local.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Local.Location = New System.Drawing.Point(132, 3)
        Me.Local.Name = "Local"
        Me.Local.PreencherZeroEsqueda = False
        Me.Local.RegraValidação = Nothing
        Me.Local.RegraValidaçãoMensagem = Nothing
        Me.Local.Size = New System.Drawing.Size(330, 23)
        Me.Local.TabIndex = 1
        Me.Local.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Local.ValorPadrao = Nothing
        '
        'PagarRelat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(787, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PagarRelat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Contas a Pagar - T072"
        Me.PainelForncedor.ResumeLayout(False)
        Me.PainelForncedor.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.PainelCheque.ResumeLayout(False)
        Me.PainelCheque.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.PainelLocal.ResumeLayout(False)
        Me.PainelLocal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PainelForncedor As System.Windows.Forms.Panel
    Friend WithEvents FornecedorDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A12 As System.Windows.Forms.RadioButton
    Friend WithEvents A11 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents A13 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelCheque As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cheque As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BalãoAjuda As System.Windows.Forms.ToolTip
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelLocal As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Local As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A14 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btVisualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents A6 As System.Windows.Forms.RadioButton
End Class
