<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NfiscalLancaItens
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
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValorDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ValorTotal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ipi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Icms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CST = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CF = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuListaItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImportarTodosOsItensDaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Unitario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SeqNf = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuListaItem.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Produto
        '
        Me.Produto.AceitaColarTexto = True
        Me.Produto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Produto.CasasDecimais = 0
        Me.Produto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Produto.CPObrigatorio = False
        Me.Produto.CPObrigatorioMsg = Nothing
        Me.Produto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Produto.FlatBorder = False
        Me.Produto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Produto.FocusColor = System.Drawing.Color.Empty
        Me.Produto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Produto.HighlightBorderOnEnter = False
        Me.Produto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Produto.Location = New System.Drawing.Point(87, 9)
        Me.Produto.Name = "Produto"
        Me.Produto.PreencherZeroEsqueda = False
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(95, 23)
        Me.Produto.TabIndex = 1
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
        '
        'Qtd
        '
        Me.Qtd.AceitaColarTexto = True
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 4
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.CPObrigatorio = False
        Me.Qtd.CPObrigatorioMsg = Nothing
        Me.Qtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd.FlatBorder = False
        Me.Qtd.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Qtd.FocusColor = System.Drawing.Color.Empty
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.HighlightBorderOnEnter = False
        Me.Qtd.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtd.Location = New System.Drawing.Point(87, 38)
        Me.Qtd.MaxLength = 15
        Me.Qtd.Name = "Qtd"
        Me.Qtd.PreencherZeroEsqueda = False
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(95, 23)
        Me.Qtd.TabIndex = 4
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Qtd"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDesconto
        '
        Me.ValorDesconto.AceitaColarTexto = True
        Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDesconto.CasasDecimais = 4
        Me.ValorDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDesconto.CPObrigatorio = False
        Me.ValorDesconto.CPObrigatorioMsg = Nothing
        Me.ValorDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDesconto.FlatBorder = False
        Me.ValorDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.FocusColor = System.Drawing.Color.Empty
        Me.ValorDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDesconto.HighlightBorderOnEnter = False
        Me.ValorDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.Location = New System.Drawing.Point(472, 38)
        Me.ValorDesconto.MaxLength = 10
        Me.ValorDesconto.Name = "ValorDesconto"
        Me.ValorDesconto.PreencherZeroEsqueda = False
        Me.ValorDesconto.RegraValidação = Nothing
        Me.ValorDesconto.RegraValidaçãoMensagem = Nothing
        Me.ValorDesconto.Size = New System.Drawing.Size(97, 23)
        Me.ValorDesconto.TabIndex = 8
        Me.ValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDesconto.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(384, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Vlr Desconto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(578, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vlr Total"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorTotal
        '
        Me.ValorTotal.AceitaColarTexto = True
        Me.ValorTotal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorTotal.CasasDecimais = 4
        Me.ValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorTotal.CPObrigatorio = False
        Me.ValorTotal.CPObrigatorioMsg = Nothing
        Me.ValorTotal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorTotal.FlatBorder = False
        Me.ValorTotal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorTotal.FocusColor = System.Drawing.Color.Empty
        Me.ValorTotal.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorTotal.HighlightBorderOnEnter = False
        Me.ValorTotal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorTotal.Location = New System.Drawing.Point(657, 38)
        Me.ValorTotal.MaxLength = 10
        Me.ValorTotal.Name = "ValorTotal"
        Me.ValorTotal.PreencherZeroEsqueda = False
        Me.ValorTotal.RegraValidação = Nothing
        Me.ValorTotal.RegraValidaçãoMensagem = Nothing
        Me.ValorTotal.Size = New System.Drawing.Size(95, 23)
        Me.ValorTotal.TabIndex = 10
        Me.ValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorTotal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorTotal.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "IPI %"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ipi
        '
        Me.Ipi.AceitaColarTexto = True
        Me.Ipi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ipi.CasasDecimais = 2
        Me.Ipi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ipi.CPObrigatorio = False
        Me.Ipi.CPObrigatorioMsg = Nothing
        Me.Ipi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ipi.FlatBorder = False
        Me.Ipi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Ipi.FocusColor = System.Drawing.Color.Empty
        Me.Ipi.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ipi.HighlightBorderOnEnter = False
        Me.Ipi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Ipi.Location = New System.Drawing.Point(87, 67)
        Me.Ipi.MaxLength = 15
        Me.Ipi.Name = "Ipi"
        Me.Ipi.PreencherZeroEsqueda = False
        Me.Ipi.RegraValidação = Nothing
        Me.Ipi.RegraValidaçãoMensagem = Nothing
        Me.Ipi.Size = New System.Drawing.Size(95, 23)
        Me.Ipi.TabIndex = 12
        Me.Ipi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Ipi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Ipi.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(384, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ICMS %"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Icms
        '
        Me.Icms.AceitaColarTexto = True
        Me.Icms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Icms.CasasDecimais = 2
        Me.Icms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Icms.CPObrigatorio = False
        Me.Icms.CPObrigatorioMsg = Nothing
        Me.Icms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Icms.FlatBorder = False
        Me.Icms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Icms.FocusColor = System.Drawing.Color.Empty
        Me.Icms.FocusColorEnd = System.Drawing.Color.Empty
        Me.Icms.HighlightBorderOnEnter = False
        Me.Icms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Icms.Location = New System.Drawing.Point(472, 68)
        Me.Icms.MaxLength = 15
        Me.Icms.Name = "Icms"
        Me.Icms.PreencherZeroEsqueda = False
        Me.Icms.RegraValidação = Nothing
        Me.Icms.RegraValidaçãoMensagem = Nothing
        Me.Icms.Size = New System.Drawing.Size(95, 23)
        Me.Icms.TabIndex = 16
        Me.Icms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Icms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Icms.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(578, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "CST"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CST
        '
        Me.CST.AceitaColarTexto = True
        Me.CST.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CST.CasasDecimais = 0
        Me.CST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CST.CPObrigatorio = False
        Me.CST.CPObrigatorioMsg = Nothing
        Me.CST.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CST.FlatBorder = False
        Me.CST.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CST.FocusColor = System.Drawing.Color.Empty
        Me.CST.FocusColorEnd = System.Drawing.Color.Empty
        Me.CST.HighlightBorderOnEnter = False
        Me.CST.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CST.Location = New System.Drawing.Point(657, 67)
        Me.CST.Name = "CST"
        Me.CST.PreencherZeroEsqueda = False
        Me.CST.RegraValidação = Nothing
        Me.CST.RegraValidaçãoMensagem = Nothing
        Me.CST.Size = New System.Drawing.Size(95, 23)
        Me.CST.TabIndex = 18
        Me.CST.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CST.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(12, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "CF"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CF
        '
        Me.CF.AceitaColarTexto = True
        Me.CF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CF.CasasDecimais = 0
        Me.CF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CF.CPObrigatorio = False
        Me.CF.CPObrigatorioMsg = Nothing
        Me.CF.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CF.FlatBorder = False
        Me.CF.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CF.FocusColor = System.Drawing.Color.Empty
        Me.CF.FocusColorEnd = System.Drawing.Color.Empty
        Me.CF.HighlightBorderOnEnter = False
        Me.CF.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CF.Location = New System.Drawing.Point(87, 96)
        Me.CF.Name = "CF"
        Me.CF.PreencherZeroEsqueda = False
        Me.CF.RegraValidação = Nothing
        Me.CF.RegraValidaçãoMensagem = Nothing
        Me.CF.Size = New System.Drawing.Size(95, 23)
        Me.CF.TabIndex = 20
        Me.CF.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CF.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(7, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(379, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Itens do Pedido que pode ser Importado para Nota Fiscal"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MyLista
        '
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.MyLista.ContextMenuStrip = Me.MenuListaItem
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(7, 153)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(745, 161)
        Me.MyLista.TabIndex = 28
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Produto"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição"
        Me.ColumnHeader2.Width = 335
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qtd"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unitário"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Desconto"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.Width = 90
        '
        'MenuListaItem
        '
        Me.MenuListaItem.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MenuListaItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarTodosOsItensDaListaToolStripMenuItem})
        Me.MenuListaItem.Name = "MenuListaItem"
        Me.MenuListaItem.Size = New System.Drawing.Size(236, 26)
        '
        'ImportarTodosOsItensDaListaToolStripMenuItem
        '
        Me.ImportarTodosOsItensDaListaToolStripMenuItem.Name = "ImportarTodosOsItensDaListaToolStripMenuItem"
        Me.ImportarTodosOsItensDaListaToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ImportarTodosOsItensDaListaToolStripMenuItem.Text = "Importar todos os itens da Lista"
        '
        'ProdutoDesc
        '
        Me.ProdutoDesc.AceitaColarTexto = True
        Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ProdutoDesc.CasasDecimais = 0
        Me.ProdutoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoDesc.CPObrigatorio = False
        Me.ProdutoDesc.CPObrigatorioMsg = Nothing
        Me.ProdutoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoDesc.FlatBorder = False
        Me.ProdutoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.FocusColor = System.Drawing.Color.Empty
        Me.ProdutoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDesc.HighlightBorderOnEnter = False
        Me.ProdutoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.Location = New System.Drawing.Point(190, 9)
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(562, 23)
        Me.ProdutoDesc.TabIndex = 2
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btNovo)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.ProdutoDesc)
        Me.Fundo.Controls.Add(Me.Produto)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Qtd)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Unitario)
        Me.Fundo.Controls.Add(Me.ValorDesconto)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.SeqNf)
        Me.Fundo.Controls.Add(Me.ValorTotal)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.CF)
        Me.Fundo.Controls.Add(Me.Ipi)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.CST)
        Me.Fundo.Controls.Add(Me.ValorIpi)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Icms)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(759, 322)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(550, 98)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(63, 22)
        Me.btSalvar.TabIndex = 24
        Me.btSalvar.Text = "Salvar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(620, 98)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(63, 22)
        Me.btNovo.TabIndex = 25
        Me.btNovo.Text = "Novo"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(689, 98)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(63, 22)
        Me.btFechar.TabIndex = 26
        Me.btFechar.Text = "Fechar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(377, 97)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(86, 23)
        Me.Id.TabIndex = 23
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'Unitario
        '
        Me.Unitario.AceitaColarTexto = True
        Me.Unitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Unitario.CasasDecimais = 4
        Me.Unitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Unitario.CPObrigatorio = False
        Me.Unitario.CPObrigatorioMsg = Nothing
        Me.Unitario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Unitario.FlatBorder = False
        Me.Unitario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Unitario.FocusColor = System.Drawing.Color.Empty
        Me.Unitario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Unitario.HighlightBorderOnEnter = False
        Me.Unitario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Unitario.Location = New System.Drawing.Point(285, 38)
        Me.Unitario.MaxLength = 10
        Me.Unitario.Name = "Unitario"
        Me.Unitario.PreencherZeroEsqueda = False
        Me.Unitario.RegraValidação = Nothing
        Me.Unitario.RegraValidaçãoMensagem = Nothing
        Me.Unitario.Size = New System.Drawing.Size(86, 23)
        Me.Unitario.TabIndex = 6
        Me.Unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Unitario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Unitario.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(200, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unitário"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(200, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Sequência"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SeqNf
        '
        Me.SeqNf.AceitaColarTexto = True
        Me.SeqNf.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SeqNf.CasasDecimais = 0
        Me.SeqNf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SeqNf.CPObrigatorio = False
        Me.SeqNf.CPObrigatorioMsg = Nothing
        Me.SeqNf.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SeqNf.FlatBorder = False
        Me.SeqNf.FlatBorderColor = System.Drawing.Color.DimGray
        Me.SeqNf.FocusColor = System.Drawing.Color.Empty
        Me.SeqNf.FocusColorEnd = System.Drawing.Color.Empty
        Me.SeqNf.HighlightBorderOnEnter = False
        Me.SeqNf.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.SeqNf.Location = New System.Drawing.Point(285, 97)
        Me.SeqNf.Name = "SeqNf"
        Me.SeqNf.PreencherZeroEsqueda = False
        Me.SeqNf.RegraValidação = Nothing
        Me.SeqNf.RegraValidaçãoMensagem = Nothing
        Me.SeqNf.Size = New System.Drawing.Size(86, 23)
        Me.SeqNf.TabIndex = 22
        Me.SeqNf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.SeqNf.ValorPadrao = Nothing
        '
        'ValorIpi
        '
        Me.ValorIpi.AceitaColarTexto = True
        Me.ValorIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorIpi.CasasDecimais = 2
        Me.ValorIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorIpi.CPObrigatorio = False
        Me.ValorIpi.CPObrigatorioMsg = Nothing
        Me.ValorIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIpi.FlatBorder = False
        Me.ValorIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIpi.FocusColor = System.Drawing.Color.Empty
        Me.ValorIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIpi.HighlightBorderOnEnter = False
        Me.ValorIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIpi.Location = New System.Drawing.Point(285, 67)
        Me.ValorIpi.MaxLength = 10
        Me.ValorIpi.Name = "ValorIpi"
        Me.ValorIpi.PreencherZeroEsqueda = False
        Me.ValorIpi.RegraValidação = Nothing
        Me.ValorIpi.RegraValidaçãoMensagem = Nothing
        Me.ValorIpi.Size = New System.Drawing.Size(86, 23)
        Me.ValorIpi.TabIndex = 14
        Me.ValorIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorIpi.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(200, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Vlr IPI"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NfiscalLancaItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(759, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NfiscalLancaItens"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançamento de Itens na Nota Fiscal - T155"
        Me.MenuListaItem.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ValorDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ValorTotal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ipi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Icms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CST As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CF As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MenuListaItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImportarTodosOsItensDaListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Unitario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SeqNf As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
