<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVendaConfirmarOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoVendaConfirmarOS))
        Me.ValorAFaturar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorOutros = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorAVista = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalParcelamentoOutros = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MyListaOutros = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuCheque = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirChequeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.ExpandablePanel4 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_valor_credito_Descontar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtvalor_atual_credito = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ExpandablePanel3 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.ContaBalanceteVendaAvistaDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ContaBalanceteVendaAvista = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExpandablePanel2 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.PercentComissao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.BTParcelaOutros = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalOS = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuCheque.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.ExpandablePanel4.SuspendLayout()
        Me.ExpandablePanel3.SuspendLayout()
        Me.ExpandablePanel2.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ValorAFaturar
        '
        Me.ValorAFaturar.AceitaColarTexto = True
        Me.ValorAFaturar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorAFaturar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorAFaturar.CasasDecimais = 2
        Me.ValorAFaturar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorAFaturar.CPObrigatorio = False
        Me.ValorAFaturar.CPObrigatorioMsg = Nothing
        Me.ValorAFaturar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorAFaturar.FlatBorder = False
        Me.ValorAFaturar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorAFaturar.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorAFaturar.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorAFaturar.HighlightBorderOnEnter = False
        Me.ValorAFaturar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorAFaturar.Location = New System.Drawing.Point(77, 35)
        Me.ValorAFaturar.MaxLength = 10
        Me.ValorAFaturar.Name = "ValorAFaturar"
        Me.ValorAFaturar.PreencherZeroEsqueda = False
        Me.ValorAFaturar.RegraValida��o = Nothing
        Me.ValorAFaturar.RegraValida��oMensagem = Nothing
        Me.ValorAFaturar.Size = New System.Drawing.Size(147, 23)
        Me.ValorAFaturar.TabIndex = 1
        Me.ValorAFaturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorAFaturar.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorAFaturar.ValorPadrao = Nothing
        '
        'ValorOutros
        '
        Me.ValorOutros.AceitaColarTexto = True
        Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorOutros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorOutros.CasasDecimais = 2
        Me.ValorOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorOutros.CPObrigatorio = False
        Me.ValorOutros.CPObrigatorioMsg = Nothing
        Me.ValorOutros.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorOutros.FlatBorder = False
        Me.ValorOutros.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorOutros.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorOutros.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorOutros.HighlightBorderOnEnter = False
        Me.ValorOutros.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorOutros.Location = New System.Drawing.Point(77, 29)
        Me.ValorOutros.MaxLength = 10
        Me.ValorOutros.Name = "ValorOutros"
        Me.ValorOutros.PreencherZeroEsqueda = False
        Me.ValorOutros.RegraValida��o = Nothing
        Me.ValorOutros.RegraValida��oMensagem = Nothing
        Me.ValorOutros.Size = New System.Drawing.Size(147, 23)
        Me.ValorOutros.TabIndex = 1
        Me.ValorOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorOutros.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorOutros.ValorPadrao = Nothing
        '
        'ValorAVista
        '
        Me.ValorAVista.AceitaColarTexto = True
        Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorAVista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorAVista.CasasDecimais = 2
        Me.ValorAVista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorAVista.CPObrigatorio = False
        Me.ValorAVista.CPObrigatorioMsg = Nothing
        Me.ValorAVista.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorAVista.FlatBorder = False
        Me.ValorAVista.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorAVista.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorAVista.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorAVista.HighlightBorderOnEnter = False
        Me.ValorAVista.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorAVista.Location = New System.Drawing.Point(77, 34)
        Me.ValorAVista.MaxLength = 10
        Me.ValorAVista.Name = "ValorAVista"
        Me.ValorAVista.PreencherZeroEsqueda = False
        Me.ValorAVista.RegraValida��o = Nothing
        Me.ValorAVista.RegraValida��oMensagem = Nothing
        Me.ValorAVista.Size = New System.Drawing.Size(147, 23)
        Me.ValorAVista.TabIndex = 1
        Me.ValorAVista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorAVista.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorAVista.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(138, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total do Parcelamento de Cheque"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalParcelamentoOutros
        '
        Me.TotalParcelamentoOutros.AceitaColarTexto = True
        Me.TotalParcelamentoOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalParcelamentoOutros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalParcelamentoOutros.CasasDecimais = 2
        Me.TotalParcelamentoOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalParcelamentoOutros.CPObrigatorio = False
        Me.TotalParcelamentoOutros.CPObrigatorioMsg = Nothing
        Me.TotalParcelamentoOutros.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.TotalParcelamentoOutros.FlatBorder = False
        Me.TotalParcelamentoOutros.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalParcelamentoOutros.FocusColor = System.Drawing.Color.MistyRose
        Me.TotalParcelamentoOutros.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalParcelamentoOutros.HighlightBorderOnEnter = False
        Me.TotalParcelamentoOutros.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalParcelamentoOutros.Location = New System.Drawing.Point(359, 182)
        Me.TotalParcelamentoOutros.MaxLength = 10
        Me.TotalParcelamentoOutros.Name = "TotalParcelamentoOutros"
        Me.TotalParcelamentoOutros.PreencherZeroEsqueda = False
        Me.TotalParcelamentoOutros.RegraValida��o = Nothing
        Me.TotalParcelamentoOutros.RegraValida��oMensagem = Nothing
        Me.TotalParcelamentoOutros.Size = New System.Drawing.Size(140, 23)
        Me.TotalParcelamentoOutros.TabIndex = 5
        Me.TotalParcelamentoOutros.TabStop = False
        Me.TotalParcelamentoOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalParcelamentoOutros.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalParcelamentoOutros.ValorPadrao = Nothing
        '
        'MyListaOutros
        '
        Me.MyListaOutros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.MyListaOutros.ContextMenuStrip = Me.MenuCheque
        Me.MyListaOutros.FullRowSelect = True
        Me.MyListaOutros.GridLines = True
        Me.MyListaOutros.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyListaOutros.LabelEdit = True
        Me.MyListaOutros.Location = New System.Drawing.Point(3, 58)
        Me.MyListaOutros.MultiSelect = False
        Me.MyListaOutros.Name = "MyListaOutros"
        Me.MyListaOutros.Size = New System.Drawing.Size(496, 118)
        Me.MyListaOutros.TabIndex = 3
        Me.MyListaOutros.TabStop = False
        Me.MyListaOutros.UseCompatibleStateImageBehavior = False
        Me.MyListaOutros.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cheque"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CC"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Valor"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Vencimento"
        Me.ColumnHeader4.Width = 92
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Entregue Por"
        Me.ColumnHeader5.Width = 170
        '
        'MenuCheque
        '
        Me.MenuCheque.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MenuCheque.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirChequeToolStripMenuItem})
        Me.MenuCheque.Name = "MenuCheque"
        Me.MenuCheque.Size = New System.Drawing.Size(153, 26)
        '
        'ExcluirChequeToolStripMenuItem
        '
        Me.ExcluirChequeToolStripMenuItem.Image = CType(resources.GetObject("ExcluirChequeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirChequeToolStripMenuItem.Name = "ExcluirChequeToolStripMenuItem"
        Me.ExcluirChequeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExcluirChequeToolStripMenuItem.Text = "Excluir Cheque"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.ExpandablePanel4)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.ExpandablePanel3)
        Me.Fundo.Controls.Add(Me.btConfirmar)
        Me.Fundo.Controls.Add(Me.ExpandablePanel2)
        Me.Fundo.Controls.Add(Me.ExpandablePanel1)
        Me.Fundo.Controls.Add(Me.lblTotalOS)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(540, 556)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'ExpandablePanel4
        '
        Me.ExpandablePanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel4.Controls.Add(Me.Label5)
        Me.ExpandablePanel4.Controls.Add(Me.txt_valor_credito_Descontar)
        Me.ExpandablePanel4.Controls.Add(Me.txtvalor_atual_credito)
        Me.ExpandablePanel4.Controls.Add(Me.Label6)
        Me.ExpandablePanel4.ExpandButtonVisible = False
        Me.ExpandablePanel4.Location = New System.Drawing.Point(14, 153)
        Me.ExpandablePanel4.Name = "ExpandablePanel4"
        Me.ExpandablePanel4.Size = New System.Drawing.Size(509, 73)
        Me.ExpandablePanel4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel4.Style.GradientAngle = 90
        Me.ExpandablePanel4.TabIndex = 1
        Me.ExpandablePanel4.TitleHeight = 24
        Me.ExpandablePanel4.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel4.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel4.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel4.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel4.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel4.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel4.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel4.TitleText = "Cr�dito do Cliente"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(232, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Valor Descontar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_valor_credito_Descontar
        '
        Me.txt_valor_credito_Descontar.AceitaColarTexto = True
        Me.txt_valor_credito_Descontar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.txt_valor_credito_Descontar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_valor_credito_Descontar.CasasDecimais = 2
        Me.txt_valor_credito_Descontar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_valor_credito_Descontar.CPObrigatorio = False
        Me.txt_valor_credito_Descontar.CPObrigatorioMsg = Nothing
        Me.txt_valor_credito_Descontar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.txt_valor_credito_Descontar.FlatBorder = False
        Me.txt_valor_credito_Descontar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txt_valor_credito_Descontar.FocusColor = System.Drawing.Color.MistyRose
        Me.txt_valor_credito_Descontar.FocusColorEnd = System.Drawing.Color.Empty
        Me.txt_valor_credito_Descontar.HighlightBorderOnEnter = False
        Me.txt_valor_credito_Descontar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txt_valor_credito_Descontar.Location = New System.Drawing.Point(352, 36)
        Me.txt_valor_credito_Descontar.MaxLength = 10
        Me.txt_valor_credito_Descontar.Name = "txt_valor_credito_Descontar"
        Me.txt_valor_credito_Descontar.PreencherZeroEsqueda = False
        Me.txt_valor_credito_Descontar.RegraValida��o = Nothing
        Me.txt_valor_credito_Descontar.RegraValida��oMensagem = Nothing
        Me.txt_valor_credito_Descontar.Size = New System.Drawing.Size(147, 23)
        Me.txt_valor_credito_Descontar.TabIndex = 2
        Me.txt_valor_credito_Descontar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_valor_credito_Descontar.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.txt_valor_credito_Descontar.ValorPadrao = ""
        '
        'txtvalor_atual_credito
        '
        Me.txtvalor_atual_credito.AceitaColarTexto = True
        Me.txtvalor_atual_credito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.txtvalor_atual_credito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalor_atual_credito.CasasDecimais = 2
        Me.txtvalor_atual_credito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvalor_atual_credito.CPObrigatorio = False
        Me.txtvalor_atual_credito.CPObrigatorioMsg = Nothing
        Me.txtvalor_atual_credito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.txtvalor_atual_credito.FlatBorder = False
        Me.txtvalor_atual_credito.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtvalor_atual_credito.FocusColor = System.Drawing.Color.MistyRose
        Me.txtvalor_atual_credito.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtvalor_atual_credito.HighlightBorderOnEnter = False
        Me.txtvalor_atual_credito.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtvalor_atual_credito.Location = New System.Drawing.Point(77, 34)
        Me.txtvalor_atual_credito.MaxLength = 10
        Me.txtvalor_atual_credito.Name = "txtvalor_atual_credito"
        Me.txtvalor_atual_credito.PreencherZeroEsqueda = False
        Me.txtvalor_atual_credito.RegraValida��o = Nothing
        Me.txtvalor_atual_credito.RegraValida��oMensagem = Nothing
        Me.txtvalor_atual_credito.Size = New System.Drawing.Size(147, 23)
        Me.txtvalor_atual_credito.TabIndex = 1
        Me.txtvalor_atual_credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtvalor_atual_credito.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.txtvalor_atual_credito.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(6, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Valor Atual"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpandablePanel3
        '
        Me.ExpandablePanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel3.Controls.Add(Me.ContaBalanceteVendaAvistaDesc)
        Me.ExpandablePanel3.Controls.Add(Me.ContaBalanceteVendaAvista)
        Me.ExpandablePanel3.Controls.Add(Me.Label4)
        Me.ExpandablePanel3.Controls.Add(Me.ValorAVista)
        Me.ExpandablePanel3.Controls.Add(Me.Label1)
        Me.ExpandablePanel3.ExpandButtonVisible = False
        Me.ExpandablePanel3.Location = New System.Drawing.Point(14, 55)
        Me.ExpandablePanel3.Name = "ExpandablePanel3"
        Me.ExpandablePanel3.Size = New System.Drawing.Size(509, 94)
        Me.ExpandablePanel3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel3.Style.GradientAngle = 90
        Me.ExpandablePanel3.TabIndex = 0
        Me.ExpandablePanel3.TitleHeight = 24
        Me.ExpandablePanel3.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel3.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel3.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel3.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel3.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel3.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel3.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel3.TitleText = "Faturamento Avista"
        '
        'ContaBalanceteVendaAvistaDesc
        '
        Me.ContaBalanceteVendaAvistaDesc.AceitaColarTexto = True
        Me.ContaBalanceteVendaAvistaDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaBalanceteVendaAvistaDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContaBalanceteVendaAvistaDesc.CasasDecimais = 0
        Me.ContaBalanceteVendaAvistaDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaBalanceteVendaAvistaDesc.CPObrigatorio = False
        Me.ContaBalanceteVendaAvistaDesc.CPObrigatorioMsg = Nothing
        Me.ContaBalanceteVendaAvistaDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ContaBalanceteVendaAvistaDesc.FlatBorder = False
        Me.ContaBalanceteVendaAvistaDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteVendaAvistaDesc.FocusColor = System.Drawing.Color.NavajoWhite
        Me.ContaBalanceteVendaAvistaDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaBalanceteVendaAvistaDesc.HighlightBorderOnEnter = False
        Me.ContaBalanceteVendaAvistaDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteVendaAvistaDesc.Location = New System.Drawing.Point(230, 63)
        Me.ContaBalanceteVendaAvistaDesc.Name = "ContaBalanceteVendaAvistaDesc"
        Me.ContaBalanceteVendaAvistaDesc.PreencherZeroEsqueda = False
        Me.ContaBalanceteVendaAvistaDesc.RegraValida��o = Nothing
        Me.ContaBalanceteVendaAvistaDesc.RegraValida��oMensagem = Nothing
        Me.ContaBalanceteVendaAvistaDesc.Size = New System.Drawing.Size(269, 23)
        Me.ContaBalanceteVendaAvistaDesc.TabIndex = 4
        Me.ContaBalanceteVendaAvistaDesc.TabStop = False
        Me.ContaBalanceteVendaAvistaDesc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaBalanceteVendaAvistaDesc.ValorPadrao = Nothing
        '
        'ContaBalanceteVendaAvista
        '
        Me.ContaBalanceteVendaAvista.AceitaColarTexto = True
        Me.ContaBalanceteVendaAvista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ContaBalanceteVendaAvista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContaBalanceteVendaAvista.CasasDecimais = 0
        Me.ContaBalanceteVendaAvista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaBalanceteVendaAvista.CPObrigatorio = False
        Me.ContaBalanceteVendaAvista.CPObrigatorioMsg = Nothing
        Me.ContaBalanceteVendaAvista.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ContaBalanceteVendaAvista.FlatBorder = False
        Me.ContaBalanceteVendaAvista.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteVendaAvista.FocusColor = System.Drawing.Color.NavajoWhite
        Me.ContaBalanceteVendaAvista.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaBalanceteVendaAvista.HighlightBorderOnEnter = False
        Me.ContaBalanceteVendaAvista.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteVendaAvista.Location = New System.Drawing.Point(77, 63)
        Me.ContaBalanceteVendaAvista.MaxLength = 6
        Me.ContaBalanceteVendaAvista.Name = "ContaBalanceteVendaAvista"
        Me.ContaBalanceteVendaAvista.PreencherZeroEsqueda = True
        Me.ContaBalanceteVendaAvista.RegraValida��o = Nothing
        Me.ContaBalanceteVendaAvista.RegraValida��oMensagem = Nothing
        Me.ContaBalanceteVendaAvista.Size = New System.Drawing.Size(147, 23)
        Me.ContaBalanceteVendaAvista.TabIndex = 3
        Me.ContaBalanceteVendaAvista.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaBalanceteVendaAvista.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Conta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpandablePanel2
        '
        Me.ExpandablePanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel2.Controls.Add(Me.Label3)
        Me.ExpandablePanel2.Controls.Add(Me.ValorAFaturar)
        Me.ExpandablePanel2.ExpandButtonVisible = False
        Me.ExpandablePanel2.Location = New System.Drawing.Point(14, 443)
        Me.ExpandablePanel2.Name = "ExpandablePanel2"
        Me.ExpandablePanel2.Size = New System.Drawing.Size(509, 72)
        Me.ExpandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel2.Style.GradientAngle = 90
        Me.ExpandablePanel2.TabIndex = 3
        Me.ExpandablePanel2.TitleHeight = 24
        Me.ExpandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel2.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel2.TitleText = "Faturamento Aprazo"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Valor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(446, 521)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(77, 27)
        Me.btFechar.TabIndex = 6
        Me.btFechar.TabStop = False
        Me.btFechar.Text = "Fechar"
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(363, 521)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(77, 27)
        Me.btConfirmar.TabIndex = 5
        Me.btConfirmar.Text = "Confirmar"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.PercentComissao)
        Me.ExpandablePanel1.Controls.Add(Me.BTParcelaOutros)
        Me.ExpandablePanel1.Controls.Add(Me.Label2)
        Me.ExpandablePanel1.Controls.Add(Me.MyListaOutros)
        Me.ExpandablePanel1.Controls.Add(Me.Label7)
        Me.ExpandablePanel1.Controls.Add(Me.ValorOutros)
        Me.ExpandablePanel1.Controls.Add(Me.TotalParcelamentoOutros)
        Me.ExpandablePanel1.ExpandButtonVisible = False
        Me.ExpandablePanel1.Location = New System.Drawing.Point(14, 230)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(509, 208)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 2
        Me.ExpandablePanel1.TitleHeight = 24
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Faturamento Cheque-pr�"
        '
        'PercentComissao
        '
        Me.PercentComissao.AceitaColarTexto = True
        Me.PercentComissao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PercentComissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PercentComissao.CasasDecimais = 2
        Me.PercentComissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PercentComissao.CPObrigatorio = False
        Me.PercentComissao.CPObrigatorioMsg = Nothing
        Me.PercentComissao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.PercentComissao.FlatBorder = False
        Me.PercentComissao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.PercentComissao.FocusColor = System.Drawing.Color.MistyRose
        Me.PercentComissao.FocusColorEnd = System.Drawing.Color.Empty
        Me.PercentComissao.HighlightBorderOnEnter = False
        Me.PercentComissao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.PercentComissao.Location = New System.Drawing.Point(359, 29)
        Me.PercentComissao.MaxLength = 15
        Me.PercentComissao.Name = "PercentComissao"
        Me.PercentComissao.PreencherZeroEsqueda = False
        Me.PercentComissao.RegraValida��o = Nothing
        Me.PercentComissao.RegraValida��oMensagem = Nothing
        Me.PercentComissao.Size = New System.Drawing.Size(140, 23)
        Me.PercentComissao.TabIndex = 6
        Me.PercentComissao.TabStop = False
        Me.PercentComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercentComissao.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.PercentComissao.ValorPadrao = Nothing
        Me.PercentComissao.Visible = False
        '
        'BTParcelaOutros
        '
        Me.BTParcelaOutros.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTParcelaOutros.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTParcelaOutros.Location = New System.Drawing.Point(230, 29)
        Me.BTParcelaOutros.Name = "BTParcelaOutros"
        Me.BTParcelaOutros.Size = New System.Drawing.Size(86, 23)
        Me.BTParcelaOutros.TabIndex = 2
        Me.BTParcelaOutros.Text = "Parcelamento"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Valor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalOS
        '
        Me.lblTotalOS.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalOS.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalOS.ForeColor = System.Drawing.Color.Red
        Me.lblTotalOS.Location = New System.Drawing.Point(295, 9)
        Me.lblTotalOS.Name = "lblTotalOS"
        Me.lblTotalOS.Size = New System.Drawing.Size(228, 43)
        Me.lblTotalOS.TabIndex = 0
        Me.lblTotalOS.Text = "0,00"
        Me.lblTotalOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(18, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(279, 43)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total PedidoOS  ====>>"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'PedidoVendaConfirmarOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(540, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PedidoVendaConfirmarOS"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar Pedido/Venda - T235"
        Me.MenuCheque.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.ExpandablePanel4.ResumeLayout(False)
        Me.ExpandablePanel4.PerformLayout()
        Me.ExpandablePanel3.ResumeLayout(False)
        Me.ExpandablePanel3.PerformLayout()
        Me.ExpandablePanel2.ResumeLayout(False)
        Me.ExpandablePanel2.PerformLayout()
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ValorAFaturar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorOutros As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorAVista As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyListaOutros As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TotalParcelamentoOutros As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ExpandablePanel2 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents ExpandablePanel3 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTParcelaOutros As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContaBalanceteVendaAvistaDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaBalanceteVendaAvista As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuCheque As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirChequeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PercentComissao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ExpandablePanel4 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_valor_credito_Descontar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtvalor_atual_credito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalOS As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
