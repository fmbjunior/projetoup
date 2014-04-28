<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItemPedido
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
        Me.Panel = New DevComponents.DotNetBar.PanelEx
        Me.Grupo = New CBOAutoCompleteFocus.CboFocus
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.AdItem = New System.Windows.Forms.Button
        Me.btFechar = New System.Windows.Forms.Button
        Me.UserSenhaDesconto = New TexBoxFocusNet.TextBoxFocusNet
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorIcms = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorIpi = New TexBoxFocusNet.TextBoxFocusNet
        Me.cfop = New TexBoxFocusNet.TextBoxFocusNet
        Me.AliqIcms = New TexBoxFocusNet.TextBoxFocusNet
        Me.Ipi = New TexBoxFocusNet.TextBoxFocusNet
        Me.BcIcms = New TexBoxFocusNet.TextBoxFocusNet
        Me.TotalProduto = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorDesconto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Desconto = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorUnitario = New TexBoxFocusNet.TextBoxFocusNet
        Me.QtdPc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet
        Me.CodigoProduto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.CanvasColor = System.Drawing.Color.Aquamarine
        Me.Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.Panel.Controls.Add(Me.Grupo)
        Me.Panel.Controls.Add(Me.LabelX2)
        Me.Panel.Controls.Add(Me.LabelX6)
        Me.Panel.Controls.Add(Me.LabelX5)
        Me.Panel.Controls.Add(Me.LabelX4)
        Me.Panel.Controls.Add(Me.LabelX3)
        Me.Panel.Controls.Add(Me.LabelX15)
        Me.Panel.Controls.Add(Me.LabelX14)
        Me.Panel.Controls.Add(Me.LabelX13)
        Me.Panel.Controls.Add(Me.LabelX12)
        Me.Panel.Controls.Add(Me.LabelX11)
        Me.Panel.Controls.Add(Me.LabelX10)
        Me.Panel.Controls.Add(Me.LabelX9)
        Me.Panel.Controls.Add(Me.LabelX8)
        Me.Panel.Controls.Add(Me.LabelX7)
        Me.Panel.Controls.Add(Me.LabelX1)
        Me.Panel.Controls.Add(Me.Id)
        Me.Panel.Controls.Add(Me.AdItem)
        Me.Panel.Controls.Add(Me.btFechar)
        Me.Panel.Controls.Add(Me.UserSenhaDesconto)
        Me.Panel.Controls.Add(Me.ProdutoDesc)
        Me.Panel.Controls.Add(Me.ValorIcms)
        Me.Panel.Controls.Add(Me.ValorIpi)
        Me.Panel.Controls.Add(Me.cfop)
        Me.Panel.Controls.Add(Me.AliqIcms)
        Me.Panel.Controls.Add(Me.Ipi)
        Me.Panel.Controls.Add(Me.BcIcms)
        Me.Panel.Controls.Add(Me.TotalProduto)
        Me.Panel.Controls.Add(Me.ValorDesconto)
        Me.Panel.Controls.Add(Me.Desconto)
        Me.Panel.Controls.Add(Me.ValorUnitario)
        Me.Panel.Controls.Add(Me.QtdPc)
        Me.Panel.Controls.Add(Me.Qtd)
        Me.Panel.Controls.Add(Me.CodigoProduto)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(815, 157)
        Me.Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel.Style.BackColor2.Color = System.Drawing.Color.Teal
        Me.Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Panel.Style.GradientAngle = 90
        Me.Panel.TabIndex = 0
        '
        'Grupo
        '
        Me.Grupo.Auto_Complete = True
        Me.Grupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Grupo.AutoLimitar_Lista = False
        Me.Grupo.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.Grupo.FormattingEnabled = True
        Me.Grupo.Location = New System.Drawing.Point(654, 78)
        Me.Grupo.MaxDropDownItems = 4
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Size = New System.Drawing.Size(153, 21)
        Me.Grupo.TabIndex = 29
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(98, 9)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX2.Size = New System.Drawing.Size(313, 20)
        Me.LabelX2.TabIndex = 34
        Me.LabelX2.Text = "Descrição Produto"
        '
        'LabelX6
        '
        Me.LabelX6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(737, 9)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX6.Size = New System.Drawing.Size(74, 20)
        Me.LabelX6.TabIndex = 34
        Me.LabelX6.Text = "Vlr. Unitário"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        Me.LabelX5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(651, 9)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX5.Size = New System.Drawing.Size(79, 20)
        Me.LabelX5.TabIndex = 34
        Me.LabelX5.Text = "Qtde. Pç"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        Me.LabelX4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(566, 9)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX4.Size = New System.Drawing.Size(79, 20)
        Me.LabelX4.TabIndex = 34
        Me.LabelX4.Text = "Qtde."
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(476, 9)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX3.Size = New System.Drawing.Size(67, 20)
        Me.LabelX3.TabIndex = 34
        Me.LabelX3.Text = "CFOP"
        '
        'LabelX15
        '
        Me.LabelX15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.Black
        Me.LabelX15.Location = New System.Drawing.Point(658, 55)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX15.Size = New System.Drawing.Size(66, 20)
        Me.LabelX15.TabIndex = 34
        Me.LabelX15.Text = "Grupo"
        '
        'LabelX14
        '
        Me.LabelX14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(583, 55)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX14.Size = New System.Drawing.Size(66, 20)
        Me.LabelX14.TabIndex = 34
        Me.LabelX14.Text = "Alíq. Icms"
        '
        'LabelX13
        '
        Me.LabelX13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(531, 55)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX13.Size = New System.Drawing.Size(47, 20)
        Me.LabelX13.TabIndex = 34
        Me.LabelX13.Text = "Alíq. IPI"
        '
        'LabelX12
        '
        Me.LabelX12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(453, 55)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX12.Size = New System.Drawing.Size(77, 20)
        Me.LabelX12.TabIndex = 34
        Me.LabelX12.Text = "Vlr.IPI"
        '
        'LabelX11
        '
        Me.LabelX11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(364, 55)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX11.Size = New System.Drawing.Size(77, 20)
        Me.LabelX11.TabIndex = 34
        Me.LabelX11.Text = "Vlr.Icms"
        '
        'LabelX10
        '
        Me.LabelX10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(275, 55)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX10.Size = New System.Drawing.Size(80, 20)
        Me.LabelX10.TabIndex = 34
        Me.LabelX10.Text = "Bc.  Icms"
        '
        'LabelX9
        '
        Me.LabelX9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(184, 55)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX9.Size = New System.Drawing.Size(80, 20)
        Me.LabelX9.TabIndex = 34
        Me.LabelX9.Text = "Total Item"
        '
        'LabelX8
        '
        Me.LabelX8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(98, 55)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX8.Size = New System.Drawing.Size(80, 20)
        Me.LabelX8.TabIndex = 34
        Me.LabelX8.Text = "Vlr Desconto"
        '
        'LabelX7
        '
        Me.LabelX7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(12, 55)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX7.Size = New System.Drawing.Size(80, 20)
        Me.LabelX7.TabIndex = 34
        Me.LabelX7.Text = "Desconto %"
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX1.Size = New System.Drawing.Size(67, 20)
        Me.LabelX1.TabIndex = 34
        Me.LabelX1.Text = "Produto"
        '
        'Id
        '
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(329, 114)
        Me.Id.Name = "Id"
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(70, 20)
        Me.Id.TabIndex = 33
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'AdItem
        '
        Me.AdItem.Location = New System.Drawing.Point(596, 114)
        Me.AdItem.Name = "AdItem"
        Me.AdItem.Size = New System.Drawing.Size(120, 31)
        Me.AdItem.TabIndex = 31
        Me.AdItem.Text = "Adicionar Item"
        Me.AdItem.UseVisualStyleBackColor = True
        '
        'btFechar
        '
        Me.btFechar.Location = New System.Drawing.Point(722, 114)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(89, 31)
        Me.btFechar.TabIndex = 32
        Me.btFechar.Text = "Fechar"
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'UserSenhaDesconto
        '
        Me.UserSenhaDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.UserSenhaDesconto.CasasDecimais = 0
        Me.UserSenhaDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UserSenhaDesconto.CPObrigatorio = False
        Me.UserSenhaDesconto.CPObrigatorioMsg = Nothing
        Me.UserSenhaDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.UserSenhaDesconto.FocusColor = System.Drawing.Color.MistyRose
        Me.UserSenhaDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.UserSenhaDesconto.Location = New System.Drawing.Point(12, 114)
        Me.UserSenhaDesconto.Name = "UserSenhaDesconto"
        Me.UserSenhaDesconto.RegraValidação = Nothing
        Me.UserSenhaDesconto.RegraValidaçãoMensagem = Nothing
        Me.UserSenhaDesconto.Size = New System.Drawing.Size(296, 20)
        Me.UserSenhaDesconto.TabIndex = 30
        Me.UserSenhaDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UserSenhaDesconto.ValorPadrao = Nothing
        Me.UserSenhaDesconto.Visible = False
        '
        'ProdutoDesc
        '
        Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdutoDesc.CasasDecimais = 0
        Me.ProdutoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoDesc.CPObrigatorio = False
        Me.ProdutoDesc.CPObrigatorioMsg = Nothing
        Me.ProdutoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ProdutoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDesc.Location = New System.Drawing.Point(98, 32)
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(375, 20)
        Me.ProdutoDesc.TabIndex = 7
        Me.ProdutoDesc.TabStop = False
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'ValorIcms
        '
        Me.ValorIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorIcms.CasasDecimais = 4
        Me.ValorIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorIcms.CPObrigatorio = False
        Me.ValorIcms.CPObrigatorioMsg = Nothing
        Me.ValorIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIcms.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIcms.Location = New System.Drawing.Point(352, 78)
        Me.ValorIcms.MaxLength = 10
        Me.ValorIcms.Name = "ValorIcms"
        Me.ValorIcms.RegraValidação = Nothing
        Me.ValorIcms.RegraValidaçãoMensagem = Nothing
        Me.ValorIcms.Size = New System.Drawing.Size(85, 20)
        Me.ValorIcms.TabIndex = 25
        Me.ValorIcms.TabStop = False
        Me.ValorIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorIcms.ValorPadrao = Nothing
        '
        'ValorIpi
        '
        Me.ValorIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorIpi.CasasDecimais = 4
        Me.ValorIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorIpi.CPObrigatorio = False
        Me.ValorIpi.CPObrigatorioMsg = Nothing
        Me.ValorIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIpi.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIpi.Location = New System.Drawing.Point(442, 78)
        Me.ValorIpi.MaxLength = 10
        Me.ValorIpi.Name = "ValorIpi"
        Me.ValorIpi.RegraValidação = Nothing
        Me.ValorIpi.RegraValidaçãoMensagem = Nothing
        Me.ValorIpi.Size = New System.Drawing.Size(85, 20)
        Me.ValorIpi.TabIndex = 26
        Me.ValorIpi.TabStop = False
        Me.ValorIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorIpi.ValorPadrao = Nothing
        '
        'cfop
        '
        Me.cfop.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.cfop.CasasDecimais = 2
        Me.cfop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cfop.CPObrigatorio = False
        Me.cfop.CPObrigatorioMsg = Nothing
        Me.cfop.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.cfop.FocusColor = System.Drawing.Color.MistyRose
        Me.cfop.FocusColorEnd = System.Drawing.Color.Empty
        Me.cfop.Location = New System.Drawing.Point(476, 32)
        Me.cfop.MaxLength = 4
        Me.cfop.Name = "cfop"
        Me.cfop.RegraValidação = Nothing
        Me.cfop.RegraValidaçãoMensagem = Nothing
        Me.cfop.Size = New System.Drawing.Size(84, 20)
        Me.cfop.TabIndex = 8
        Me.cfop.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.cfop.ValorPadrao = Nothing
        '
        'AliqIcms
        '
        Me.AliqIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.AliqIcms.CasasDecimais = 2
        Me.AliqIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AliqIcms.CPObrigatorio = False
        Me.AliqIcms.CPObrigatorioMsg = Nothing
        Me.AliqIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AliqIcms.FocusColor = System.Drawing.Color.MistyRose
        Me.AliqIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.AliqIcms.Location = New System.Drawing.Point(584, 78)
        Me.AliqIcms.Name = "AliqIcms"
        Me.AliqIcms.RegraValidação = Nothing
        Me.AliqIcms.RegraValidaçãoMensagem = Nothing
        Me.AliqIcms.Size = New System.Drawing.Size(61, 20)
        Me.AliqIcms.TabIndex = 28
        Me.AliqIcms.TabStop = False
        Me.AliqIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AliqIcms.ValorPadrao = Nothing
        '
        'Ipi
        '
        Me.Ipi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Ipi.CasasDecimais = 2
        Me.Ipi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ipi.CPObrigatorio = False
        Me.Ipi.CPObrigatorioMsg = Nothing
        Me.Ipi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ipi.FocusColor = System.Drawing.Color.MistyRose
        Me.Ipi.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ipi.Location = New System.Drawing.Point(532, 78)
        Me.Ipi.Name = "Ipi"
        Me.Ipi.RegraValidação = Nothing
        Me.Ipi.RegraValidaçãoMensagem = Nothing
        Me.Ipi.Size = New System.Drawing.Size(47, 20)
        Me.Ipi.TabIndex = 27
        Me.Ipi.TabStop = False
        Me.Ipi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ipi.ValorPadrao = Nothing
        '
        'BcIcms
        '
        Me.BcIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.BcIcms.CasasDecimais = 4
        Me.BcIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BcIcms.CPObrigatorio = False
        Me.BcIcms.CPObrigatorioMsg = Nothing
        Me.BcIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BcIcms.FocusColor = System.Drawing.Color.MistyRose
        Me.BcIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.BcIcms.Location = New System.Drawing.Point(263, 78)
        Me.BcIcms.MaxLength = 10
        Me.BcIcms.Name = "BcIcms"
        Me.BcIcms.RegraValidação = Nothing
        Me.BcIcms.RegraValidaçãoMensagem = Nothing
        Me.BcIcms.Size = New System.Drawing.Size(84, 20)
        Me.BcIcms.TabIndex = 24
        Me.BcIcms.TabStop = False
        Me.BcIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BcIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.BcIcms.ValorPadrao = Nothing
        '
        'TotalProduto
        '
        Me.TotalProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalProduto.CasasDecimais = 4
        Me.TotalProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalProduto.CPObrigatorio = False
        Me.TotalProduto.CPObrigatorioMsg = Nothing
        Me.TotalProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalProduto.FocusColor = System.Drawing.Color.MistyRose
        Me.TotalProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalProduto.Location = New System.Drawing.Point(173, 78)
        Me.TotalProduto.MaxLength = 10
        Me.TotalProduto.Name = "TotalProduto"
        Me.TotalProduto.RegraValidação = Nothing
        Me.TotalProduto.RegraValidaçãoMensagem = Nothing
        Me.TotalProduto.Size = New System.Drawing.Size(84, 20)
        Me.TotalProduto.TabIndex = 23
        Me.TotalProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalProduto.ValorPadrao = Nothing
        '
        'ValorDesconto
        '
        Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDesconto.CasasDecimais = 2
        Me.ValorDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDesconto.CPObrigatorio = False
        Me.ValorDesconto.CPObrigatorioMsg = Nothing
        Me.ValorDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDesconto.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDesconto.Location = New System.Drawing.Point(98, 78)
        Me.ValorDesconto.MaxLength = 10
        Me.ValorDesconto.Name = "ValorDesconto"
        Me.ValorDesconto.RegraValidação = Nothing
        Me.ValorDesconto.RegraValidaçãoMensagem = Nothing
        Me.ValorDesconto.Size = New System.Drawing.Size(69, 20)
        Me.ValorDesconto.TabIndex = 22
        Me.ValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDesconto.ValorPadrao = Nothing
        '
        'Desconto
        '
        Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Desconto.CasasDecimais = 3
        Me.Desconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Desconto.CPObrigatorio = False
        Me.Desconto.CPObrigatorioMsg = Nothing
        Me.Desconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Desconto.FocusColor = System.Drawing.Color.MistyRose
        Me.Desconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desconto.Location = New System.Drawing.Point(12, 78)
        Me.Desconto.MaxLength = 8
        Me.Desconto.Name = "Desconto"
        Me.Desconto.RegraValidação = Nothing
        Me.Desconto.RegraValidaçãoMensagem = Nothing
        Me.Desconto.Size = New System.Drawing.Size(80, 20)
        Me.Desconto.TabIndex = 21
        Me.Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Desconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Desconto.ValorPadrao = Nothing
        '
        'ValorUnitario
        '
        Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorUnitario.CasasDecimais = 4
        Me.ValorUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorUnitario.CPObrigatorio = False
        Me.ValorUnitario.CPObrigatorioMsg = Nothing
        Me.ValorUnitario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorUnitario.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorUnitario.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorUnitario.Location = New System.Drawing.Point(737, 32)
        Me.ValorUnitario.MaxLength = 10
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.RegraValidação = Nothing
        Me.ValorUnitario.RegraValidaçãoMensagem = Nothing
        Me.ValorUnitario.Size = New System.Drawing.Size(74, 20)
        Me.ValorUnitario.TabIndex = 11
        Me.ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorUnitario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorUnitario.ValorPadrao = Nothing
        '
        'QtdPc
        '
        Me.QtdPc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.QtdPc.CasasDecimais = 4
        Me.QtdPc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.QtdPc.CPObrigatorio = False
        Me.QtdPc.CPObrigatorioMsg = Nothing
        Me.QtdPc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.QtdPc.FocusColor = System.Drawing.Color.MistyRose
        Me.QtdPc.FocusColorEnd = System.Drawing.Color.Empty
        Me.QtdPc.Location = New System.Drawing.Point(651, 32)
        Me.QtdPc.MaxLength = 8
        Me.QtdPc.Name = "QtdPc"
        Me.QtdPc.RegraValidação = Nothing
        Me.QtdPc.RegraValidaçãoMensagem = Nothing
        Me.QtdPc.Size = New System.Drawing.Size(80, 20)
        Me.QtdPc.TabIndex = 10
        Me.QtdPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtdPc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.QtdPc.ValorPadrao = Nothing
        '
        'Qtd
        '
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 4
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.CPObrigatorio = False
        Me.Qtd.CPObrigatorioMsg = Nothing
        Me.Qtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd.FocusColor = System.Drawing.Color.MistyRose
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.Location = New System.Drawing.Point(566, 32)
        Me.Qtd.MaxLength = 8
        Me.Qtd.Name = "Qtd"
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(80, 20)
        Me.Qtd.TabIndex = 9
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'CodigoProduto
        '
        Me.CodigoProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoProduto.CasasDecimais = 0
        Me.CodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoProduto.CPObrigatorio = False
        Me.CodigoProduto.CPObrigatorioMsg = Nothing
        Me.CodigoProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.CodigoProduto.FocusColor = System.Drawing.Color.MistyRose
        Me.CodigoProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoProduto.Location = New System.Drawing.Point(12, 32)
        Me.CodigoProduto.Name = "CodigoProduto"
        Me.CodigoProduto.RegraValidação = Nothing
        Me.CodigoProduto.RegraValidaçãoMensagem = Nothing
        Me.CodigoProduto.Size = New System.Drawing.Size(80, 20)
        Me.CodigoProduto.TabIndex = 6
        Me.CodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoProduto.ValorPadrao = Nothing
        '
        'AddItemPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddItemPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar item no pedido"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents UserSenhaDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Ipi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TotalProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Desconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorUnitario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents QtdPc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents cfop As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents AliqIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BcIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents AdItem As System.Windows.Forms.Button
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Grupo As CBOAutoCompleteFocus.CboFocus
End Class
