<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedOSServicoAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedOSServicoAdd))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtValorCusto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.NomeServico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodigoServico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btProdutoFind = New System.Windows.Forms.Label()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.NomeFuncionario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Total = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorUnitario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodFuncionario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btnSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.UserSenhaDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.UserSenhaDesconto)
        Me.PanelEx1.Controls.Add(Me.LabelX8)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.txtDesconto)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.txtValorCusto)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.NomeServico)
        Me.PanelEx1.Controls.Add(Me.CodigoServico)
        Me.PanelEx1.Controls.Add(Me.btProdutoFind)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX9)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.NomeFuncionario)
        Me.PanelEx1.Controls.Add(Me.Total)
        Me.PanelEx1.Controls.Add(Me.ValorDesconto)
        Me.PanelEx1.Controls.Add(Me.ValorUnitario)
        Me.PanelEx1.Controls.Add(Me.Qtd)
        Me.PanelEx1.Controls.Add(Me.CodFuncionario)
        Me.PanelEx1.Controls.Add(Me.btnFechar)
        Me.PanelEx1.Controls.Add(Me.btnSalvar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(738, 153)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(516, 61)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX7.Size = New System.Drawing.Size(99, 15)
        Me.LabelX7.TabIndex = 16
        Me.LabelX7.Text = "% Desconto"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtDesconto
        '
        Me.txtDesconto.AceitaColarTexto = True
        Me.txtDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.txtDesconto.CasasDecimais = 4
        Me.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesconto.CPObrigatorio = False
        Me.txtDesconto.CPObrigatorioMsg = Nothing
        Me.txtDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.txtDesconto.FlatBorder = False
        Me.txtDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtDesconto.FocusColor = System.Drawing.Color.MistyRose
        Me.txtDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtDesconto.HighlightBorderOnEnter = False
        Me.txtDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtDesconto.Location = New System.Drawing.Point(516, 82)
        Me.txtDesconto.MaxLength = 15
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.PreencherZeroEsqueda = False
        Me.txtDesconto.RegraValida��o = Nothing
        Me.txtDesconto.RegraValida��oMensagem = Nothing
        Me.txtDesconto.Size = New System.Drawing.Size(99, 20)
        Me.txtDesconto.TabIndex = 17
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDesconto.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.txtDesconto.ValorPadrao = Nothing
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(209, 62)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX5.Size = New System.Drawing.Size(90, 15)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "Vlr. Custo"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtValorCusto
        '
        Me.txtValorCusto.AceitaColarTexto = True
        Me.txtValorCusto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.txtValorCusto.CasasDecimais = 4
        Me.txtValorCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorCusto.CPObrigatorio = False
        Me.txtValorCusto.CPObrigatorioMsg = Nothing
        Me.txtValorCusto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.txtValorCusto.FlatBorder = False
        Me.txtValorCusto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtValorCusto.FocusColor = System.Drawing.Color.MistyRose
        Me.txtValorCusto.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtValorCusto.HighlightBorderOnEnter = False
        Me.txtValorCusto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtValorCusto.Location = New System.Drawing.Point(209, 81)
        Me.txtValorCusto.MaxLength = 10
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.PreencherZeroEsqueda = False
        Me.txtValorCusto.RegraValida��o = Nothing
        Me.txtValorCusto.RegraValida��oMensagem = Nothing
        Me.txtValorCusto.Size = New System.Drawing.Size(90, 20)
        Me.txtValorCusto.TabIndex = 11
        Me.txtValorCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorCusto.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.txtValorCusto.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(186, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 23)
        Me.Label1.TabIndex = 6
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(10, 38)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX2.Size = New System.Drawing.Size(70, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Servi�o"
        '
        'NomeServico
        '
        Me.NomeServico.AceitaColarTexto = True
        Me.NomeServico.BackColor = System.Drawing.Color.White
        Me.NomeServico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.NomeServico.CasasDecimais = 0
        Me.NomeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeServico.CPObrigatorio = False
        Me.NomeServico.CPObrigatorioMsg = Nothing
        Me.NomeServico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.NomeServico.FlatBorder = False
        Me.NomeServico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeServico.FocusColor = System.Drawing.Color.MistyRose
        Me.NomeServico.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeServico.HighlightBorderOnEnter = False
        Me.NomeServico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeServico.Location = New System.Drawing.Point(209, 38)
        Me.NomeServico.Name = "NomeServico"
        Me.NomeServico.PreencherZeroEsqueda = False
        Me.NomeServico.ReadOnly = True
        Me.NomeServico.RegraValida��o = Nothing
        Me.NomeServico.RegraValida��oMensagem = Nothing
        Me.NomeServico.Size = New System.Drawing.Size(521, 20)
        Me.NomeServico.TabIndex = 7
        Me.NomeServico.TabStop = False
        Me.NomeServico.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeServico.ValorPadrao = Nothing
        '
        'CodigoServico
        '
        Me.CodigoServico.AceitaColarTexto = True
        Me.CodigoServico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.CodigoServico.CasasDecimais = 0
        Me.CodigoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoServico.CPObrigatorio = False
        Me.CodigoServico.CPObrigatorioMsg = Nothing
        Me.CodigoServico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.CodigoServico.FlatBorder = False
        Me.CodigoServico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoServico.FocusColor = System.Drawing.Color.MistyRose
        Me.CodigoServico.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoServico.HighlightBorderOnEnter = False
        Me.CodigoServico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoServico.Location = New System.Drawing.Point(86, 37)
        Me.CodigoServico.Name = "CodigoServico"
        Me.CodigoServico.PreencherZeroEsqueda = False
        Me.CodigoServico.RegraValida��o = Nothing
        Me.CodigoServico.RegraValida��oMensagem = Nothing
        Me.CodigoServico.Size = New System.Drawing.Size(95, 20)
        Me.CodigoServico.TabIndex = 5
        Me.CodigoServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoServico.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoServico.ValorPadrao = Nothing
        '
        'btProdutoFind
        '
        Me.btProdutoFind.Image = CType(resources.GetObject("btProdutoFind.Image"), System.Drawing.Image)
        Me.btProdutoFind.Location = New System.Drawing.Point(183, 12)
        Me.btProdutoFind.Name = "btProdutoFind"
        Me.btProdutoFind.Size = New System.Drawing.Size(23, 23)
        Me.btProdutoFind.TabIndex = 2
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(440, 62)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX3.Size = New System.Drawing.Size(70, 15)
        Me.LabelX3.TabIndex = 14
        Me.LabelX3.Text = "Vlr. Desconto"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(329, 64)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX6.Size = New System.Drawing.Size(76, 15)
        Me.LabelX6.TabIndex = 12
        Me.LabelX6.Text = "Vlr. Unit�rio"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(93, 62)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX4.Size = New System.Drawing.Size(60, 15)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Qtde."
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(621, 62)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX9.Size = New System.Drawing.Size(109, 15)
        Me.LabelX9.TabIndex = 18
        Me.LabelX9.Text = "Total"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(10, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX1.Size = New System.Drawing.Size(60, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Funcion�rio"
        '
        'NomeFuncionario
        '
        Me.NomeFuncionario.AceitaColarTexto = True
        Me.NomeFuncionario.BackColor = System.Drawing.Color.White
        Me.NomeFuncionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.NomeFuncionario.CasasDecimais = 0
        Me.NomeFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeFuncionario.CPObrigatorio = False
        Me.NomeFuncionario.CPObrigatorioMsg = Nothing
        Me.NomeFuncionario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.NomeFuncionario.FlatBorder = False
        Me.NomeFuncionario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeFuncionario.FocusColor = System.Drawing.Color.MistyRose
        Me.NomeFuncionario.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeFuncionario.HighlightBorderOnEnter = False
        Me.NomeFuncionario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeFuncionario.Location = New System.Drawing.Point(209, 12)
        Me.NomeFuncionario.Name = "NomeFuncionario"
        Me.NomeFuncionario.PreencherZeroEsqueda = False
        Me.NomeFuncionario.ReadOnly = True
        Me.NomeFuncionario.RegraValida��o = Nothing
        Me.NomeFuncionario.RegraValida��oMensagem = Nothing
        Me.NomeFuncionario.Size = New System.Drawing.Size(521, 20)
        Me.NomeFuncionario.TabIndex = 3
        Me.NomeFuncionario.TabStop = False
        Me.NomeFuncionario.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeFuncionario.ValorPadrao = Nothing
        '
        'Total
        '
        Me.Total.AceitaColarTexto = True
        Me.Total.BackColor = System.Drawing.Color.White
        Me.Total.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Total.CasasDecimais = 4
        Me.Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Total.CPObrigatorio = False
        Me.Total.CPObrigatorioMsg = Nothing
        Me.Total.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Total.FlatBorder = False
        Me.Total.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Total.FocusColor = System.Drawing.Color.MistyRose
        Me.Total.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total.HighlightBorderOnEnter = False
        Me.Total.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Total.Location = New System.Drawing.Point(621, 81)
        Me.Total.MaxLength = 10
        Me.Total.Name = "Total"
        Me.Total.PreencherZeroEsqueda = False
        Me.Total.ReadOnly = True
        Me.Total.RegraValida��o = Nothing
        Me.Total.RegraValida��oMensagem = Nothing
        Me.Total.Size = New System.Drawing.Size(109, 20)
        Me.Total.TabIndex = 19
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Total.ValorPadrao = Nothing
        '
        'ValorDesconto
        '
        Me.ValorDesconto.AceitaColarTexto = True
        Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ValorDesconto.CasasDecimais = 2
        Me.ValorDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDesconto.CPObrigatorio = False
        Me.ValorDesconto.CPObrigatorioMsg = Nothing
        Me.ValorDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorDesconto.FlatBorder = False
        Me.ValorDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDesconto.HighlightBorderOnEnter = False
        Me.ValorDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.Location = New System.Drawing.Point(411, 81)
        Me.ValorDesconto.MaxLength = 10
        Me.ValorDesconto.Name = "ValorDesconto"
        Me.ValorDesconto.PreencherZeroEsqueda = False
        Me.ValorDesconto.RegraValida��o = Nothing
        Me.ValorDesconto.RegraValida��oMensagem = Nothing
        Me.ValorDesconto.Size = New System.Drawing.Size(99, 20)
        Me.ValorDesconto.TabIndex = 15
        Me.ValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDesconto.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDesconto.ValorPadrao = Nothing
        '
        'ValorUnitario
        '
        Me.ValorUnitario.AceitaColarTexto = True
        Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ValorUnitario.CasasDecimais = 4
        Me.ValorUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorUnitario.CPObrigatorio = False
        Me.ValorUnitario.CPObrigatorioMsg = Nothing
        Me.ValorUnitario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorUnitario.FlatBorder = False
        Me.ValorUnitario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorUnitario.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorUnitario.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorUnitario.HighlightBorderOnEnter = False
        Me.ValorUnitario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorUnitario.Location = New System.Drawing.Point(305, 81)
        Me.ValorUnitario.MaxLength = 10
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.PreencherZeroEsqueda = False
        Me.ValorUnitario.RegraValida��o = Nothing
        Me.ValorUnitario.RegraValida��oMensagem = Nothing
        Me.ValorUnitario.Size = New System.Drawing.Size(100, 20)
        Me.ValorUnitario.TabIndex = 13
        Me.ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorUnitario.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorUnitario.ValorPadrao = Nothing
        '
        'Qtd
        '
        Me.Qtd.AceitaColarTexto = True
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Qtd.CasasDecimais = 4
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.CPObrigatorio = False
        Me.Qtd.CPObrigatorioMsg = Nothing
        Me.Qtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Qtd.FlatBorder = False
        Me.Qtd.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Qtd.FocusColor = System.Drawing.Color.MistyRose
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.HighlightBorderOnEnter = False
        Me.Qtd.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtd.Location = New System.Drawing.Point(86, 81)
        Me.Qtd.MaxLength = 15
        Me.Qtd.Name = "Qtd"
        Me.Qtd.PreencherZeroEsqueda = False
        Me.Qtd.RegraValida��o = Nothing
        Me.Qtd.RegraValida��oMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(95, 20)
        Me.Qtd.TabIndex = 9
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'CodFuncionario
        '
        Me.CodFuncionario.AceitaColarTexto = True
        Me.CodFuncionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.CodFuncionario.CasasDecimais = 0
        Me.CodFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodFuncionario.CPObrigatorio = False
        Me.CodFuncionario.CPObrigatorioMsg = Nothing
        Me.CodFuncionario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.CodFuncionario.FlatBorder = False
        Me.CodFuncionario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodFuncionario.FocusColor = System.Drawing.Color.MistyRose
        Me.CodFuncionario.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodFuncionario.HighlightBorderOnEnter = False
        Me.CodFuncionario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodFuncionario.Location = New System.Drawing.Point(86, 12)
        Me.CodFuncionario.Name = "CodFuncionario"
        Me.CodFuncionario.PreencherZeroEsqueda = False
        Me.CodFuncionario.RegraValida��o = Nothing
        Me.CodFuncionario.RegraValida��oMensagem = Nothing
        Me.CodFuncionario.Size = New System.Drawing.Size(95, 20)
        Me.CodFuncionario.TabIndex = 1
        Me.CodFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodFuncionario.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodFuncionario.ValorPadrao = Nothing
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFechar.Location = New System.Drawing.Point(632, 118)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(98, 26)
        Me.btnFechar.TabIndex = 21
        Me.btnFechar.Text = "Fechar"
        '
        'btnSalvar
        '
        Me.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSalvar.Location = New System.Drawing.Point(517, 119)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(98, 25)
        Me.btnSalvar.TabIndex = 20
        Me.btnSalvar.Text = "Salvar Item"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(83, 119)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.SingleLineColor = System.Drawing.Color.Black
        Me.LabelX8.Size = New System.Drawing.Size(427, 23)
        Me.LabelX8.TabIndex = 32
        Me.LabelX8.Text = "Para desconto adicional pressione CTR + Insert. Necess�ria senha com autoriza��o." & _
    ""
        '
        'UserSenhaDesconto
        '
        Me.UserSenhaDesconto.AceitaColarTexto = True
        Me.UserSenhaDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.UserSenhaDesconto.CasasDecimais = 0
        Me.UserSenhaDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UserSenhaDesconto.CPObrigatorio = False
        Me.UserSenhaDesconto.CPObrigatorioMsg = Nothing
        Me.UserSenhaDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.UserSenhaDesconto.FlatBorder = False
        Me.UserSenhaDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UserSenhaDesconto.FocusColor = System.Drawing.Color.MistyRose
        Me.UserSenhaDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.UserSenhaDesconto.HighlightBorderOnEnter = False
        Me.UserSenhaDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.UserSenhaDesconto.Location = New System.Drawing.Point(3, 104)
        Me.UserSenhaDesconto.Name = "UserSenhaDesconto"
        Me.UserSenhaDesconto.PreencherZeroEsqueda = False
        Me.UserSenhaDesconto.RegraValida��o = Nothing
        Me.UserSenhaDesconto.RegraValida��oMensagem = Nothing
        Me.UserSenhaDesconto.Size = New System.Drawing.Size(103, 20)
        Me.UserSenhaDesconto.TabIndex = 33
        Me.UserSenhaDesconto.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UserSenhaDesconto.ValorPadrao = Nothing
        Me.UserSenhaDesconto.Visible = False
        '
        'PedOSServicoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnFechar
        Me.ClientSize = New System.Drawing.Size(738, 153)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PedOSServicoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PedOSServicoAdd - T237"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btProdutoFind As System.Windows.Forms.Label
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NomeFuncionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Total As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorUnitario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodFuncionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NomeServico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoServico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ValorDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtValorCusto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents UserSenhaDesconto As TexBoxFocusNet.TextBoxFocusNet
End Class
