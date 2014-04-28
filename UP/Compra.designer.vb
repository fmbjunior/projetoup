<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compra))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColProduto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColQtd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSeq = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColVlrUnit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCfopEnt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cMensagemErro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuListaDeItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirOItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarItensParaDevoluçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Confirmado = New System.Windows.Forms.CheckBox()
        Me.Inativo = New System.Windows.Forms.CheckBox()
        Me.MenuDataLancamento = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TravarOCampoDataDeLançamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestravarOCampoDataDeLançamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.NovoBT = New System.Windows.Forms.ToolStripButton()
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton()
        Me.EditarBT = New System.Windows.Forms.ToolStripButton()
        Me.CancelarBT = New System.Windows.Forms.ToolStripButton()
        Me.ConfirmarBT = New System.Windows.Forms.ToolStripButton()
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.btFornecedor = New System.Windows.Forms.ToolStripButton()
        Me.btEditarContas = New System.Windows.Forms.ToolStripButton()
        Me.btImpXML = New System.Windows.Forms.ToolStripButton()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.ChaveNFe = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.CRTfornecedor = New System.Windows.Forms.Label()
        Me.btFindFornecedor = New System.Windows.Forms.Label()
        Me.btFindValor = New System.Windows.Forms.Label()
        Me.ContaCRDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.RazaoSocial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ContaDespesa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Obs = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodigoFornecedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btFormaPgto = New DevComponents.DotNetBar.ButtonX()
        Me.EspecieDocumento = New CBOAutoCompleteFocus.CboFocus()
        Me.FormaPagamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ConfImg = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Find6 = New System.Windows.Forms.Label()
        Me.DescConta6 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Find5 = New System.Windows.Forms.Label()
        Me.DescConta5 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Find4 = New System.Windows.Forms.Label()
        Me.DescConta4 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Find3 = New System.Windows.Forms.Label()
        Me.DescConta3 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Find2 = New System.Windows.Forms.Label()
        Me.DescConta2 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Find1 = New System.Windows.Forms.Label()
        Me.Conta6 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Vlr6 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Conta5 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Vlr5 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Conta4 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Vlr4 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Conta3 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Vlr3 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Conta2 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Vlr2 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Conta1 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DescConta1 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Vlr1 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.SubSerie = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CFOP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PainelDev = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.IdNFdevMae = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NFdevMaeValor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btFindNFDevolucao = New System.Windows.Forms.Label()
        Me.NFdevMae = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NFdevMaeLabel = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.DataCompra = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NotaFiscal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataEntrada = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ValorCompra = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btModelos = New DevComponents.DotNetBar.ButtonX()
        Me.TpEntrada = New CBOAutoCompleteFocus.CboFocus()
        Me.Modelo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cTipo = New CBOAutoCompleteFocus.CboFocus()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabGeral = New DevComponents.DotNetBar.TabControl()
        Me.Itens = New DevComponents.DotNetBar.TabControlPanel()
        Me.TotalCofins = New TexBoxFocusNet.TextBoxFocusNet()
        Me.AdicionarItens = New DevComponents.DotNetBar.ButtonX()
        Me.TotalPis = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TotalItensIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TotalItensLançado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TabItens = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.EFocusPanel3 = New EFocusPanel.EFocusPanel(Me.components)
        Me.c3 = New System.Windows.Forms.Label()
        Me.c2 = New System.Windows.Forms.Label()
        Me.c1 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ValorDesconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TotalProdutos = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorIssqnRetido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.BaseCalcIcmsST = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.ValorIcmsST = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorFrete = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ValorOutros = New TexBoxFocusNet.TextBoxFocusNet()
        Me.EFocusPanel2 = New EFocusPanel.EFocusPanel(Me.components)
        Me.c11 = New System.Windows.Forms.Label()
        Me.c10 = New System.Windows.Forms.Label()
        Me.c9 = New System.Windows.Forms.Label()
        Me.c8 = New System.Windows.Forms.Label()
        Me.ValorOutrosIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IsentoIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BaseCalcIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.VlrIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.EFocusPanel1 = New EFocusPanel.EFocusPanel(Me.components)
        Me.c7 = New System.Windows.Forms.Label()
        Me.c6 = New System.Windows.Forms.Label()
        Me.c5 = New System.Windows.Forms.Label()
        Me.c4 = New System.Windows.Forms.Label()
        Me.ValorOutrosIcms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IsentoIcms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BaseCalcIcms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Icms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorIcms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ListaPagar = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DevolucaoTab = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Serie = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CompraInterno = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuListaDeItem.SuspendLayout()
        Me.MenuDataLancamento.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PainelDev.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.TabGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeral.SuspendLayout()
        Me.Itens.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.EFocusPanel3.SuspendLayout()
        Me.EFocusPanel2.SuspendLayout()
        Me.EFocusPanel1.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.ListaPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(112, 20)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Valor Produtos"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(13, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 19)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Vlr. Ipi"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(95, 19)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Base Calc. Ipi"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 19)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Vlr Icms"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 19)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Base Calc. ICMS"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(158, 216)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(49, 20)
        Me.Label42.TabIndex = 3
        Me.Label42.Text = "Tot. IPI"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(9, 216)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 20)
        Me.Label40.TabIndex = 1
        Me.Label40.Text = "Lançado"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MyLista
        '
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColProduto, Me.ColDesc, Me.ColQtd, Me.ColSeq, Me.ColVlrUnit, Me.colTotal, Me.ColumnHeader1, Me.ColCfopEnt, Me.cMensagemErro})
        Me.MyLista.ContextMenuStrip = Me.MenuListaDeItem
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(8, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(983, 207)
        Me.MyLista.TabIndex = 0
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 0
        '
        'ColProduto
        '
        Me.ColProduto.Text = "Produto"
        '
        'ColDesc
        '
        Me.ColDesc.Text = "Descrição"
        Me.ColDesc.Width = 290
        '
        'ColQtd
        '
        Me.ColQtd.Text = "Qtd"
        Me.ColQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColQtd.Width = 70
        '
        'ColSeq
        '
        Me.ColSeq.Text = "Seq"
        Me.ColSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColSeq.Width = 35
        '
        'ColVlrUnit
        '
        Me.ColVlrUnit.Text = "Vlr. Unit."
        Me.ColVlrUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColVlrUnit.Width = 96
        '
        'colTotal
        '
        Me.colTotal.Text = "Total"
        Me.colTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTotal.Width = 111
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CFOP"
        '
        'ColCfopEnt
        '
        Me.ColCfopEnt.Text = "CFOP Ent"
        '
        'cMensagemErro
        '
        Me.cMensagemErro.Text = ""
        Me.cMensagemErro.Width = 150
        '
        'MenuListaDeItem
        '
        Me.MenuListaDeItem.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MenuListaDeItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirOItemToolStripMenuItem, Me.ExcluirTodosToolStripMenuItem, Me.ImportarItensParaDevoluçãoToolStripMenuItem})
        Me.MenuListaDeItem.Name = "MenuListaDeItem"
        Me.MenuListaDeItem.Size = New System.Drawing.Size(233, 70)
        '
        'ExcluirOItemToolStripMenuItem
        '
        Me.ExcluirOItemToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExcluirOItemToolStripMenuItem.Image = CType(resources.GetObject("ExcluirOItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirOItemToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExcluirOItemToolStripMenuItem.Name = "ExcluirOItemToolStripMenuItem"
        Me.ExcluirOItemToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ExcluirOItemToolStripMenuItem.Text = "Excluir o Item"
        '
        'ExcluirTodosToolStripMenuItem
        '
        Me.ExcluirTodosToolStripMenuItem.Name = "ExcluirTodosToolStripMenuItem"
        Me.ExcluirTodosToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ExcluirTodosToolStripMenuItem.Text = "Excluir Todos"
        '
        'ImportarItensParaDevoluçãoToolStripMenuItem
        '
        Me.ImportarItensParaDevoluçãoToolStripMenuItem.Name = "ImportarItensParaDevoluçãoToolStripMenuItem"
        Me.ImportarItensParaDevoluçãoToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ImportarItensParaDevoluçãoToolStripMenuItem.Text = "Importar Itens para Devolução"
        '
        'Confirmado
        '
        Me.Confirmado.AutoSize = True
        Me.Confirmado.BackColor = System.Drawing.Color.Transparent
        Me.Confirmado.Enabled = False
        Me.Confirmado.Location = New System.Drawing.Point(604, 216)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(84, 20)
        Me.Confirmado.TabIndex = 11
        Me.Confirmado.TabStop = False
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.UseVisualStyleBackColor = False
        Me.Confirmado.Visible = False
        '
        'Inativo
        '
        Me.Inativo.AutoSize = True
        Me.Inativo.BackColor = System.Drawing.Color.Transparent
        Me.Inativo.Enabled = False
        Me.Inativo.Location = New System.Drawing.Point(694, 216)
        Me.Inativo.Name = "Inativo"
        Me.Inativo.Size = New System.Drawing.Size(63, 20)
        Me.Inativo.TabIndex = 10
        Me.Inativo.Text = "Inativo"
        Me.Inativo.UseVisualStyleBackColor = False
        Me.Inativo.Visible = False
        '
        'MenuDataLancamento
        '
        Me.MenuDataLancamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MenuDataLancamento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TravarOCampoDataDeLançamentoToolStripMenuItem, Me.DestravarOCampoDataDeLançamentoToolStripMenuItem})
        Me.MenuDataLancamento.Name = "MenuDataLancamento"
        Me.MenuDataLancamento.Size = New System.Drawing.Size(276, 48)
        '
        'TravarOCampoDataDeLançamentoToolStripMenuItem
        '
        Me.TravarOCampoDataDeLançamentoToolStripMenuItem.Name = "TravarOCampoDataDeLançamentoToolStripMenuItem"
        Me.TravarOCampoDataDeLançamentoToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.TravarOCampoDataDeLançamentoToolStripMenuItem.Text = "Travar o Campo Data de Lançamento"
        '
        'DestravarOCampoDataDeLançamentoToolStripMenuItem
        '
        Me.DestravarOCampoDataDeLançamentoToolStripMenuItem.Name = "DestravarOCampoDataDeLançamentoToolStripMenuItem"
        Me.DestravarOCampoDataDeLançamentoToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.DestravarOCampoDataDeLançamentoToolStripMenuItem.Text = "Destravar o Campo Data de Lançamento"
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.CancelarBT, Me.ConfirmarBT, Me.LocalizarBT, Me.FecharBT, Me.Imprimir, Me.btFornecedor, Me.btEditarContas, Me.btImpXML})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(1020, 56)
        Me.BarraBt.TabIndex = 0
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(40, 53)
        Me.NovoBT.Text = "Novo"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalvarBT
        '
        Me.SalvarBT.Image = CType(resources.GetObject("SalvarBT.Image"), System.Drawing.Image)
        Me.SalvarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(41, 53)
        Me.SalvarBT.Text = "Salvar"
        Me.SalvarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EditarBT
        '
        Me.EditarBT.Image = CType(resources.GetObject("EditarBT.Image"), System.Drawing.Image)
        Me.EditarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditarBT.Name = "EditarBT"
        Me.EditarBT.Size = New System.Drawing.Size(41, 53)
        Me.EditarBT.Text = "Editar"
        Me.EditarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CancelarBT
        '
        Me.CancelarBT.Image = CType(resources.GetObject("CancelarBT.Image"), System.Drawing.Image)
        Me.CancelarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CancelarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarBT.Name = "CancelarBT"
        Me.CancelarBT.Size = New System.Drawing.Size(75, 53)
        Me.CancelarBT.Text = "Cancelar N.F"
        Me.CancelarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CancelarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ConfirmarBT
        '
        Me.ConfirmarBT.Image = CType(resources.GetObject("ConfirmarBT.Image"), System.Drawing.Image)
        Me.ConfirmarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfirmarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConfirmarBT.Name = "ConfirmarBT"
        Me.ConfirmarBT.Size = New System.Drawing.Size(82, 53)
        Me.ConfirmarBT.Text = "Confirmar N.F"
        Me.ConfirmarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfirmarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LocalizarBT
        '
        Me.LocalizarBT.Image = CType(resources.GetObject("LocalizarBT.Image"), System.Drawing.Image)
        Me.LocalizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LocalizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LocalizarBT.Name = "LocalizarBT"
        Me.LocalizarBT.Size = New System.Drawing.Size(55, 53)
        Me.LocalizarBT.Text = "Localizar"
        Me.LocalizarBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LocalizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(45, 53)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Imprimir
        '
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(53, 53)
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btFornecedor
        '
        Me.btFornecedor.Image = CType(resources.GetObject("btFornecedor.Image"), System.Drawing.Image)
        Me.btFornecedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btFornecedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFornecedor.Name = "btFornecedor"
        Me.btFornecedor.Size = New System.Drawing.Size(96, 53)
        Me.btFornecedor.Text = "Cad. Fornecedor"
        Me.btFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btEditarContas
        '
        Me.btEditarContas.Image = CType(resources.GetObject("btEditarContas.Image"), System.Drawing.Image)
        Me.btEditarContas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btEditarContas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditarContas.Name = "btEditarContas"
        Me.btEditarContas.Size = New System.Drawing.Size(68, 53)
        Me.btEditarContas.Text = "Editar Pgto"
        Me.btEditarContas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEditarContas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btImpXML
        '
        Me.btImpXML.Image = CType(resources.GetObject("btImpXML.Image"), System.Drawing.Image)
        Me.btImpXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btImpXML.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btImpXML.Name = "btImpXML"
        Me.btImpXML.Size = New System.Drawing.Size(57, 53)
        Me.btImpXML.Text = "Imp. XML"
        Me.btImpXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btImpXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.ChaveNFe)
        Me.Fundo.Controls.Add(Me.Label29)
        Me.Fundo.Controls.Add(Me.PanelEx1)
        Me.Fundo.Controls.Add(Me.btFormaPgto)
        Me.Fundo.Controls.Add(Me.EspecieDocumento)
        Me.Fundo.Controls.Add(Me.FormaPagamento)
        Me.Fundo.Controls.Add(Me.Label34)
        Me.Fundo.Controls.Add(Me.Label36)
        Me.Fundo.Controls.Add(Me.Label20)
        Me.Fundo.Controls.Add(Me.ConfImg)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.SubSerie)
        Me.Fundo.Controls.Add(Me.CFOP)
        Me.Fundo.Controls.Add(Me.Label35)
        Me.Fundo.Controls.Add(Me.Label26)
        Me.Fundo.Controls.Add(Me.PainelDev)
        Me.Fundo.Controls.Add(Me.PanelEx2)
        Me.Fundo.Controls.Add(Me.btModelos)
        Me.Fundo.Controls.Add(Me.TpEntrada)
        Me.Fundo.Controls.Add(Me.Modelo)
        Me.Fundo.Controls.Add(Me.Label33)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.cTipo)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.TabGeral)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Serie)
        Me.Fundo.Controls.Add(Me.Label32)
        Me.Fundo.Controls.Add(Me.CompraInterno)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(1020, 641)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'ChaveNFe
        '
        Me.ChaveNFe.AceitaColarTexto = True
        Me.ChaveNFe.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ChaveNFe.CasasDecimais = 0
        Me.ChaveNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ChaveNFe.CPObrigatorio = False
        Me.ChaveNFe.CPObrigatorioMsg = Nothing
        Me.ChaveNFe.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ChaveNFe.FlatBorder = False
        Me.ChaveNFe.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ChaveNFe.FocusColor = System.Drawing.Color.Empty
        Me.ChaveNFe.FocusColorEnd = System.Drawing.Color.Empty
        Me.ChaveNFe.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChaveNFe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChaveNFe.HighlightBorderOnEnter = False
        Me.ChaveNFe.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ChaveNFe.Location = New System.Drawing.Point(107, 150)
        Me.ChaveNFe.MaxLength = 44
        Me.ChaveNFe.Name = "ChaveNFe"
        Me.ChaveNFe.PreencherZeroEsqueda = False
        Me.ChaveNFe.RegraValidação = Nothing
        Me.ChaveNFe.RegraValidaçãoMensagem = Nothing
        Me.ChaveNFe.Size = New System.Drawing.Size(457, 23)
        Me.ChaveNFe.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.ChaveNFe, "Utilize o cfop principal de entrada da sua nota")
        Me.ChaveNFe.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ChaveNFe.ValorPadrao = Nothing
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(20, 153)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 20)
        Me.Label29.TabIndex = 21
        Me.Label29.Text = "Chave da NFe"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.CRTfornecedor)
        Me.PanelEx1.Controls.Add(Me.btFindFornecedor)
        Me.PanelEx1.Controls.Add(Me.btFindValor)
        Me.PanelEx1.Controls.Add(Me.ContaCRDesc)
        Me.PanelEx1.Controls.Add(Me.RazaoSocial)
        Me.PanelEx1.Controls.Add(Me.Label16)
        Me.PanelEx1.Controls.Add(Me.ContaDespesa)
        Me.PanelEx1.Controls.Add(Me.Obs)
        Me.PanelEx1.Controls.Add(Me.CodigoFornecedor)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Location = New System.Drawing.Point(12, 233)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(530, 112)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 25
        '
        'CRTfornecedor
        '
        Me.CRTfornecedor.BackColor = System.Drawing.Color.Transparent
        Me.CRTfornecedor.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRTfornecedor.Location = New System.Drawing.Point(6, 89)
        Me.CRTfornecedor.Name = "CRTfornecedor"
        Me.CRTfornecedor.Size = New System.Drawing.Size(516, 23)
        Me.CRTfornecedor.TabIndex = 10
        Me.CRTfornecedor.Text = "Código de Regime Tributário"
        Me.CRTfornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFindFornecedor
        '
        Me.btFindFornecedor.Image = CType(resources.GetObject("btFindFornecedor.Image"), System.Drawing.Image)
        Me.btFindFornecedor.Location = New System.Drawing.Point(155, 9)
        Me.btFindFornecedor.Name = "btFindFornecedor"
        Me.btFindFornecedor.Size = New System.Drawing.Size(18, 21)
        Me.btFindFornecedor.TabIndex = 2
        '
        'btFindValor
        '
        Me.btFindValor.Image = CType(resources.GetObject("btFindValor.Image"), System.Drawing.Image)
        Me.btFindValor.Location = New System.Drawing.Point(155, 37)
        Me.btFindValor.Name = "btFindValor"
        Me.btFindValor.Size = New System.Drawing.Size(19, 20)
        Me.btFindValor.TabIndex = 6
        '
        'ContaCRDesc
        '
        Me.ContaCRDesc.AceitaColarTexto = True
        Me.ContaCRDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaCRDesc.CasasDecimais = 2
        Me.ContaCRDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCRDesc.CPObrigatorio = False
        Me.ContaCRDesc.CPObrigatorioMsg = Nothing
        Me.ContaCRDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCRDesc.FlatBorder = False
        Me.ContaCRDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCRDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaCRDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCRDesc.HighlightBorderOnEnter = False
        Me.ContaCRDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCRDesc.Location = New System.Drawing.Point(176, 37)
        Me.ContaCRDesc.MaxLength = 6
        Me.ContaCRDesc.Name = "ContaCRDesc"
        Me.ContaCRDesc.PreencherZeroEsqueda = False
        Me.ContaCRDesc.RegraValidação = Nothing
        Me.ContaCRDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaCRDesc.Size = New System.Drawing.Size(347, 20)
        Me.ContaCRDesc.TabIndex = 7
        Me.ContaCRDesc.TabStop = False
        Me.ContaCRDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCRDesc.ValorPadrao = Nothing
        '
        'RazaoSocial
        '
        Me.RazaoSocial.AceitaColarTexto = True
        Me.RazaoSocial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.RazaoSocial.CasasDecimais = 0
        Me.RazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RazaoSocial.CPObrigatorio = False
        Me.RazaoSocial.CPObrigatorioMsg = Nothing
        Me.RazaoSocial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.RazaoSocial.FlatBorder = False
        Me.RazaoSocial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.RazaoSocial.FocusColor = System.Drawing.Color.Empty
        Me.RazaoSocial.FocusColorEnd = System.Drawing.Color.Empty
        Me.RazaoSocial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazaoSocial.HighlightBorderOnEnter = False
        Me.RazaoSocial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.RazaoSocial.Location = New System.Drawing.Point(176, 8)
        Me.RazaoSocial.Name = "RazaoSocial"
        Me.RazaoSocial.PreencherZeroEsqueda = False
        Me.RazaoSocial.RegraValidação = Nothing
        Me.RazaoSocial.RegraValidaçãoMensagem = Nothing
        Me.RazaoSocial.Size = New System.Drawing.Size(347, 23)
        Me.RazaoSocial.TabIndex = 3
        Me.RazaoSocial.TabStop = False
        Me.RazaoSocial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.RazaoSocial.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(3, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 22)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Conta Despesa"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaDespesa
        '
        Me.ContaDespesa.AceitaColarTexto = True
        Me.ContaDespesa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaDespesa.CasasDecimais = 2
        Me.ContaDespesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaDespesa.CPObrigatorio = False
        Me.ContaDespesa.CPObrigatorioMsg = Nothing
        Me.ContaDespesa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaDespesa.FlatBorder = False
        Me.ContaDespesa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaDespesa.FocusColor = System.Drawing.Color.Empty
        Me.ContaDespesa.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaDespesa.HighlightBorderOnEnter = False
        Me.ContaDespesa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaDespesa.Location = New System.Drawing.Point(94, 37)
        Me.ContaDespesa.MaxLength = 6
        Me.ContaDespesa.Name = "ContaDespesa"
        Me.ContaDespesa.PreencherZeroEsqueda = True
        Me.ContaDespesa.RegraValidação = Nothing
        Me.ContaDespesa.RegraValidaçãoMensagem = Nothing
        Me.ContaDespesa.Size = New System.Drawing.Size(58, 20)
        Me.ContaDespesa.TabIndex = 5
        Me.ContaDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContaDespesa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaDespesa.ValorPadrao = Nothing
        '
        'Obs
        '
        Me.Obs.AceitaColarTexto = True
        Me.Obs.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Obs.CasasDecimais = 0
        Me.Obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Obs.CPObrigatorio = False
        Me.Obs.CPObrigatorioMsg = Nothing
        Me.Obs.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Obs.FlatBorder = False
        Me.Obs.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Obs.FocusColor = System.Drawing.Color.Empty
        Me.Obs.FocusColorEnd = System.Drawing.Color.Empty
        Me.Obs.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Obs.HighlightBorderOnEnter = False
        Me.Obs.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Obs.Location = New System.Drawing.Point(93, 64)
        Me.Obs.MaxLength = 250
        Me.Obs.Name = "Obs"
        Me.Obs.PreencherZeroEsqueda = False
        Me.Obs.RegraValidação = Nothing
        Me.Obs.RegraValidaçãoMensagem = Nothing
        Me.Obs.Size = New System.Drawing.Size(429, 23)
        Me.Obs.TabIndex = 9
        Me.Obs.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Obs.ValorPadrao = Nothing
        '
        'CodigoFornecedor
        '
        Me.CodigoFornecedor.AceitaColarTexto = True
        Me.CodigoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoFornecedor.CasasDecimais = 0
        Me.CodigoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoFornecedor.CPObrigatorio = False
        Me.CodigoFornecedor.CPObrigatorioMsg = Nothing
        Me.CodigoFornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoFornecedor.FlatBorder = False
        Me.CodigoFornecedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoFornecedor.FocusColor = System.Drawing.Color.Empty
        Me.CodigoFornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoFornecedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoFornecedor.HighlightBorderOnEnter = False
        Me.CodigoFornecedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoFornecedor.Location = New System.Drawing.Point(94, 8)
        Me.CodigoFornecedor.MaxLength = 8
        Me.CodigoFornecedor.Name = "CodigoFornecedor"
        Me.CodigoFornecedor.PreencherZeroEsqueda = False
        Me.CodigoFornecedor.RegraValidação = Nothing
        Me.CodigoFornecedor.RegraValidaçãoMensagem = Nothing
        Me.CodigoFornecedor.Size = New System.Drawing.Size(60, 23)
        Me.CodigoFornecedor.TabIndex = 1
        Me.CodigoFornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoFornecedor.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Observação"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Fornecedor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFormaPgto
        '
        Me.btFormaPgto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFormaPgto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFormaPgto.Location = New System.Drawing.Point(570, 125)
        Me.btFormaPgto.Name = "btFormaPgto"
        Me.btFormaPgto.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btFormaPgto.Size = New System.Drawing.Size(28, 20)
        Me.btFormaPgto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFormaPgto.TabIndex = 20
        Me.btFormaPgto.TabStop = False
        Me.btFormaPgto.Text = "..."
        '
        'EspecieDocumento
        '
        Me.EspecieDocumento.Auto_Complete = True
        Me.EspecieDocumento.AutoLimitar_Lista = True
        Me.EspecieDocumento.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.EspecieDocumento.CPObrigatorio = False
        Me.EspecieDocumento.CPObrigatorioMsg = Nothing
        Me.EspecieDocumento.FlatBorder = False
        Me.EspecieDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EspecieDocumento.FormattingEnabled = True
        Me.EspecieDocumento.HighlightBorderColor = System.Drawing.Color.Empty
        Me.EspecieDocumento.HighlightBorderOnEnter = False
        Me.EspecieDocumento.Items.AddRange(New Object() {"NF", "NFE", "NF-E", "NFT", "CPR"})
        Me.EspecieDocumento.Location = New System.Drawing.Point(261, 120)
        Me.EspecieDocumento.Name = "EspecieDocumento"
        Me.EspecieDocumento.Size = New System.Drawing.Size(54, 24)
        Me.EspecieDocumento.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.EspecieDocumento, "Utilizar: NF-E para nota eletrônica e NFE conta de energia")
        '
        'FormaPagamento
        '
        Me.FormaPagamento.AceitaColarTexto = True
        Me.FormaPagamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FormaPagamento.CasasDecimais = 0
        Me.FormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FormaPagamento.CPObrigatorio = False
        Me.FormaPagamento.CPObrigatorioMsg = Nothing
        Me.FormaPagamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FormaPagamento.FlatBorder = False
        Me.FormaPagamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FormaPagamento.FocusColor = System.Drawing.Color.Empty
        Me.FormaPagamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.FormaPagamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaPagamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormaPagamento.HighlightBorderOnEnter = False
        Me.FormaPagamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FormaPagamento.Location = New System.Drawing.Point(481, 124)
        Me.FormaPagamento.MaxLength = 15
        Me.FormaPagamento.Name = "FormaPagamento"
        Me.FormaPagamento.PreencherZeroEsqueda = False
        Me.FormaPagamento.RegraValidação = "0;1;9"
        Me.FormaPagamento.RegraValidaçãoMensagem = "Informe 0(À vista) 1(À prazo) 9(Sem Pagto)"
        Me.FormaPagamento.Size = New System.Drawing.Size(83, 23)
        Me.FormaPagamento.TabIndex = 19
        Me.FormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.FormaPagamento, "Informe 0(À vista) 1(À prazo) 9(Sem Pagto)")
        Me.FormaPagamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.FormaPagamento.ValorPadrao = Nothing
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(363, 127)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(112, 20)
        Me.Label34.TabIndex = 18
        Me.Label34.Text = "Forma de Pagamento"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(174, 122)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(76, 21)
        Me.Label36.TabIndex = 16
        Me.Label36.Text = "Espécie Doc"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 623)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "T003"
        '
        'ConfImg
        '
        Me.ConfImg.BackColor = System.Drawing.Color.Transparent
        Me.ConfImg.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfImg.ForeColor = System.Drawing.Color.Black
        Me.ConfImg.Image = CType(resources.GetObject("ConfImg.Image"), System.Drawing.Image)
        Me.ConfImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConfImg.Location = New System.Drawing.Point(749, 6)
        Me.ConfImg.Name = "ConfImg"
        Me.ConfImg.Size = New System.Drawing.Size(188, 47)
        Me.ConfImg.TabIndex = 1
        Me.ConfImg.Text = "Lançamento Confirmado"
        Me.ConfImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ConfImg.Visible = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Find6)
        Me.GroupPanel1.Controls.Add(Me.DescConta6)
        Me.GroupPanel1.Controls.Add(Me.Find5)
        Me.GroupPanel1.Controls.Add(Me.DescConta5)
        Me.GroupPanel1.Controls.Add(Me.Find4)
        Me.GroupPanel1.Controls.Add(Me.DescConta4)
        Me.GroupPanel1.Controls.Add(Me.Find3)
        Me.GroupPanel1.Controls.Add(Me.DescConta3)
        Me.GroupPanel1.Controls.Add(Me.Find2)
        Me.GroupPanel1.Controls.Add(Me.DescConta2)
        Me.GroupPanel1.Controls.Add(Me.Find1)
        Me.GroupPanel1.Controls.Add(Me.Conta6)
        Me.GroupPanel1.Controls.Add(Me.Vlr6)
        Me.GroupPanel1.Controls.Add(Me.Conta5)
        Me.GroupPanel1.Controls.Add(Me.Vlr5)
        Me.GroupPanel1.Controls.Add(Me.Conta4)
        Me.GroupPanel1.Controls.Add(Me.Vlr4)
        Me.GroupPanel1.Controls.Add(Me.Conta3)
        Me.GroupPanel1.Controls.Add(Me.Vlr3)
        Me.GroupPanel1.Controls.Add(Me.Conta2)
        Me.GroupPanel1.Controls.Add(Me.Vlr2)
        Me.GroupPanel1.Controls.Add(Me.Conta1)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.Label18)
        Me.GroupPanel1.Controls.Add(Me.DescConta1)
        Me.GroupPanel1.Controls.Add(Me.Label19)
        Me.GroupPanel1.Controls.Add(Me.Vlr1)
        Me.GroupPanel1.Location = New System.Drawing.Point(548, 167)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(466, 178)
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
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 26
        Me.GroupPanel1.Text = "Contas Centro Custo"
        '
        'Find6
        '
        Me.Find6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find6.Enabled = False
        Me.Find6.Image = CType(resources.GetObject("Find6.Image"), System.Drawing.Image)
        Me.Find6.Location = New System.Drawing.Point(65, 132)
        Me.Find6.Name = "Find6"
        Me.Find6.Size = New System.Drawing.Size(22, 23)
        Me.Find6.TabIndex = 24
        '
        'DescConta6
        '
        Me.DescConta6.AceitaColarTexto = True
        Me.DescConta6.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta6.CasasDecimais = 0
        Me.DescConta6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta6.CPObrigatorio = False
        Me.DescConta6.CPObrigatorioMsg = Nothing
        Me.DescConta6.Enabled = False
        Me.DescConta6.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta6.FlatBorder = True
        Me.DescConta6.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta6.FocusColor = System.Drawing.Color.Empty
        Me.DescConta6.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta6.HighlightBorderOnEnter = False
        Me.DescConta6.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescConta6.Location = New System.Drawing.Point(86, 132)
        Me.DescConta6.MaxLength = 100
        Me.DescConta6.Name = "DescConta6"
        Me.DescConta6.PreencherZeroEsqueda = False
        Me.DescConta6.RegraValidação = Nothing
        Me.DescConta6.RegraValidaçãoMensagem = Nothing
        Me.DescConta6.Size = New System.Drawing.Size(278, 23)
        Me.DescConta6.TabIndex = 25
        Me.DescConta6.TabStop = False
        Me.DescConta6.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta6.ValorPadrao = Nothing
        '
        'Find5
        '
        Me.Find5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find5.Enabled = False
        Me.Find5.Image = CType(resources.GetObject("Find5.Image"), System.Drawing.Image)
        Me.Find5.Location = New System.Drawing.Point(65, 110)
        Me.Find5.Name = "Find5"
        Me.Find5.Size = New System.Drawing.Size(22, 23)
        Me.Find5.TabIndex = 20
        '
        'DescConta5
        '
        Me.DescConta5.AceitaColarTexto = True
        Me.DescConta5.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta5.CasasDecimais = 0
        Me.DescConta5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta5.CPObrigatorio = False
        Me.DescConta5.CPObrigatorioMsg = Nothing
        Me.DescConta5.Enabled = False
        Me.DescConta5.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta5.FlatBorder = True
        Me.DescConta5.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta5.FocusColor = System.Drawing.Color.Empty
        Me.DescConta5.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta5.HighlightBorderOnEnter = False
        Me.DescConta5.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescConta5.Location = New System.Drawing.Point(86, 110)
        Me.DescConta5.MaxLength = 100
        Me.DescConta5.Name = "DescConta5"
        Me.DescConta5.PreencherZeroEsqueda = False
        Me.DescConta5.RegraValidação = Nothing
        Me.DescConta5.RegraValidaçãoMensagem = Nothing
        Me.DescConta5.Size = New System.Drawing.Size(278, 23)
        Me.DescConta5.TabIndex = 21
        Me.DescConta5.TabStop = False
        Me.DescConta5.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta5.ValorPadrao = Nothing
        '
        'Find4
        '
        Me.Find4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find4.Enabled = False
        Me.Find4.Image = CType(resources.GetObject("Find4.Image"), System.Drawing.Image)
        Me.Find4.Location = New System.Drawing.Point(65, 88)
        Me.Find4.Name = "Find4"
        Me.Find4.Size = New System.Drawing.Size(22, 23)
        Me.Find4.TabIndex = 16
        '
        'DescConta4
        '
        Me.DescConta4.AceitaColarTexto = True
        Me.DescConta4.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta4.CasasDecimais = 0
        Me.DescConta4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta4.CPObrigatorio = False
        Me.DescConta4.CPObrigatorioMsg = Nothing
        Me.DescConta4.Enabled = False
        Me.DescConta4.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta4.FlatBorder = True
        Me.DescConta4.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta4.FocusColor = System.Drawing.Color.Empty
        Me.DescConta4.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta4.HighlightBorderOnEnter = False
        Me.DescConta4.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescConta4.Location = New System.Drawing.Point(86, 88)
        Me.DescConta4.MaxLength = 100
        Me.DescConta4.Name = "DescConta4"
        Me.DescConta4.PreencherZeroEsqueda = False
        Me.DescConta4.RegraValidação = Nothing
        Me.DescConta4.RegraValidaçãoMensagem = Nothing
        Me.DescConta4.Size = New System.Drawing.Size(278, 23)
        Me.DescConta4.TabIndex = 17
        Me.DescConta4.TabStop = False
        Me.DescConta4.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta4.ValorPadrao = Nothing
        '
        'Find3
        '
        Me.Find3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find3.Enabled = False
        Me.Find3.Image = CType(resources.GetObject("Find3.Image"), System.Drawing.Image)
        Me.Find3.Location = New System.Drawing.Point(65, 66)
        Me.Find3.Name = "Find3"
        Me.Find3.Size = New System.Drawing.Size(22, 23)
        Me.Find3.TabIndex = 12
        '
        'DescConta3
        '
        Me.DescConta3.AceitaColarTexto = True
        Me.DescConta3.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta3.CasasDecimais = 0
        Me.DescConta3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta3.CPObrigatorio = False
        Me.DescConta3.CPObrigatorioMsg = Nothing
        Me.DescConta3.Enabled = False
        Me.DescConta3.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta3.FlatBorder = True
        Me.DescConta3.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta3.FocusColor = System.Drawing.Color.Empty
        Me.DescConta3.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta3.HighlightBorderOnEnter = False
        Me.DescConta3.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescConta3.Location = New System.Drawing.Point(86, 66)
        Me.DescConta3.MaxLength = 100
        Me.DescConta3.Name = "DescConta3"
        Me.DescConta3.PreencherZeroEsqueda = False
        Me.DescConta3.RegraValidação = Nothing
        Me.DescConta3.RegraValidaçãoMensagem = Nothing
        Me.DescConta3.Size = New System.Drawing.Size(278, 23)
        Me.DescConta3.TabIndex = 13
        Me.DescConta3.TabStop = False
        Me.DescConta3.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta3.ValorPadrao = Nothing
        '
        'Find2
        '
        Me.Find2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find2.Enabled = False
        Me.Find2.Image = CType(resources.GetObject("Find2.Image"), System.Drawing.Image)
        Me.Find2.Location = New System.Drawing.Point(65, 44)
        Me.Find2.Name = "Find2"
        Me.Find2.Size = New System.Drawing.Size(22, 23)
        Me.Find2.TabIndex = 8
        '
        'DescConta2
        '
        Me.DescConta2.AceitaColarTexto = True
        Me.DescConta2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta2.CasasDecimais = 0
        Me.DescConta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta2.CPObrigatorio = False
        Me.DescConta2.CPObrigatorioMsg = Nothing
        Me.DescConta2.Enabled = False
        Me.DescConta2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta2.FlatBorder = True
        Me.DescConta2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta2.FocusColor = System.Drawing.Color.Empty
        Me.DescConta2.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta2.HighlightBorderOnEnter = False
        Me.DescConta2.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescConta2.Location = New System.Drawing.Point(86, 44)
        Me.DescConta2.MaxLength = 100
        Me.DescConta2.Name = "DescConta2"
        Me.DescConta2.PreencherZeroEsqueda = False
        Me.DescConta2.RegraValidação = Nothing
        Me.DescConta2.RegraValidaçãoMensagem = Nothing
        Me.DescConta2.Size = New System.Drawing.Size(278, 23)
        Me.DescConta2.TabIndex = 9
        Me.DescConta2.TabStop = False
        Me.DescConta2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta2.ValorPadrao = Nothing
        '
        'Find1
        '
        Me.Find1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Find1.Image = CType(resources.GetObject("Find1.Image"), System.Drawing.Image)
        Me.Find1.Location = New System.Drawing.Point(65, 22)
        Me.Find1.Name = "Find1"
        Me.Find1.Size = New System.Drawing.Size(22, 23)
        Me.Find1.TabIndex = 4
        '
        'Conta6
        '
        Me.Conta6.AceitaColarTexto = True
        Me.Conta6.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta6.CasasDecimais = 0
        Me.Conta6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta6.CPObrigatorio = False
        Me.Conta6.CPObrigatorioMsg = Nothing
        Me.Conta6.Enabled = False
        Me.Conta6.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta6.FlatBorder = True
        Me.Conta6.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta6.FocusColor = System.Drawing.Color.Empty
        Me.Conta6.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta6.HighlightBorderOnEnter = False
        Me.Conta6.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Conta6.Location = New System.Drawing.Point(9, 132)
        Me.Conta6.MaxLength = 6
        Me.Conta6.Name = "Conta6"
        Me.Conta6.PreencherZeroEsqueda = True
        Me.Conta6.RegraValidação = Nothing
        Me.Conta6.RegraValidaçãoMensagem = Nothing
        Me.Conta6.Size = New System.Drawing.Size(57, 23)
        Me.Conta6.TabIndex = 23
        Me.Conta6.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta6.ValorPadrao = Nothing
        '
        'Vlr6
        '
        Me.Vlr6.AceitaColarTexto = True
        Me.Vlr6.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr6.CasasDecimais = 2
        Me.Vlr6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr6.CPObrigatorio = False
        Me.Vlr6.CPObrigatorioMsg = Nothing
        Me.Vlr6.Enabled = False
        Me.Vlr6.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr6.FlatBorder = True
        Me.Vlr6.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr6.FocusColor = System.Drawing.Color.Empty
        Me.Vlr6.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr6.HighlightBorderOnEnter = False
        Me.Vlr6.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vlr6.Location = New System.Drawing.Point(363, 132)
        Me.Vlr6.MaxLength = 15
        Me.Vlr6.Name = "Vlr6"
        Me.Vlr6.PreencherZeroEsqueda = False
        Me.Vlr6.RegraValidação = Nothing
        Me.Vlr6.RegraValidaçãoMensagem = Nothing
        Me.Vlr6.Size = New System.Drawing.Size(92, 23)
        Me.Vlr6.TabIndex = 26
        Me.Vlr6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr6.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr6.ValorPadrao = Nothing
        '
        'Conta5
        '
        Me.Conta5.AceitaColarTexto = True
        Me.Conta5.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta5.CasasDecimais = 0
        Me.Conta5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta5.CPObrigatorio = False
        Me.Conta5.CPObrigatorioMsg = Nothing
        Me.Conta5.Enabled = False
        Me.Conta5.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta5.FlatBorder = True
        Me.Conta5.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta5.FocusColor = System.Drawing.Color.Empty
        Me.Conta5.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta5.HighlightBorderOnEnter = False
        Me.Conta5.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Conta5.Location = New System.Drawing.Point(9, 110)
        Me.Conta5.MaxLength = 6
        Me.Conta5.Name = "Conta5"
        Me.Conta5.PreencherZeroEsqueda = True
        Me.Conta5.RegraValidação = Nothing
        Me.Conta5.RegraValidaçãoMensagem = Nothing
        Me.Conta5.Size = New System.Drawing.Size(57, 23)
        Me.Conta5.TabIndex = 19
        Me.Conta5.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta5.ValorPadrao = Nothing
        '
        'Vlr5
        '
        Me.Vlr5.AceitaColarTexto = True
        Me.Vlr5.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr5.CasasDecimais = 2
        Me.Vlr5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr5.CPObrigatorio = False
        Me.Vlr5.CPObrigatorioMsg = Nothing
        Me.Vlr5.Enabled = False
        Me.Vlr5.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr5.FlatBorder = True
        Me.Vlr5.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr5.FocusColor = System.Drawing.Color.Empty
        Me.Vlr5.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr5.HighlightBorderOnEnter = False
        Me.Vlr5.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vlr5.Location = New System.Drawing.Point(363, 110)
        Me.Vlr5.MaxLength = 15
        Me.Vlr5.Name = "Vlr5"
        Me.Vlr5.PreencherZeroEsqueda = False
        Me.Vlr5.RegraValidação = Nothing
        Me.Vlr5.RegraValidaçãoMensagem = Nothing
        Me.Vlr5.Size = New System.Drawing.Size(92, 23)
        Me.Vlr5.TabIndex = 22
        Me.Vlr5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr5.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr5.ValorPadrao = Nothing
        '
        'Conta4
        '
        Me.Conta4.AceitaColarTexto = True
        Me.Conta4.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta4.CasasDecimais = 0
        Me.Conta4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta4.CPObrigatorio = False
        Me.Conta4.CPObrigatorioMsg = Nothing
        Me.Conta4.Enabled = False
        Me.Conta4.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta4.FlatBorder = True
        Me.Conta4.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta4.FocusColor = System.Drawing.Color.Empty
        Me.Conta4.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta4.HighlightBorderOnEnter = False
        Me.Conta4.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Conta4.Location = New System.Drawing.Point(9, 88)
        Me.Conta4.MaxLength = 6
        Me.Conta4.Name = "Conta4"
        Me.Conta4.PreencherZeroEsqueda = True
        Me.Conta4.RegraValidação = Nothing
        Me.Conta4.RegraValidaçãoMensagem = Nothing
        Me.Conta4.Size = New System.Drawing.Size(57, 23)
        Me.Conta4.TabIndex = 15
        Me.Conta4.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta4.ValorPadrao = Nothing
        '
        'Vlr4
        '
        Me.Vlr4.AceitaColarTexto = True
        Me.Vlr4.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr4.CasasDecimais = 2
        Me.Vlr4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr4.CPObrigatorio = False
        Me.Vlr4.CPObrigatorioMsg = Nothing
        Me.Vlr4.Enabled = False
        Me.Vlr4.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr4.FlatBorder = True
        Me.Vlr4.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr4.FocusColor = System.Drawing.Color.Empty
        Me.Vlr4.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr4.HighlightBorderOnEnter = False
        Me.Vlr4.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vlr4.Location = New System.Drawing.Point(363, 88)
        Me.Vlr4.MaxLength = 15
        Me.Vlr4.Name = "Vlr4"
        Me.Vlr4.PreencherZeroEsqueda = False
        Me.Vlr4.RegraValidação = Nothing
        Me.Vlr4.RegraValidaçãoMensagem = Nothing
        Me.Vlr4.Size = New System.Drawing.Size(92, 23)
        Me.Vlr4.TabIndex = 18
        Me.Vlr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr4.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr4.ValorPadrao = Nothing
        '
        'Conta3
        '
        Me.Conta3.AceitaColarTexto = True
        Me.Conta3.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta3.CasasDecimais = 0
        Me.Conta3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta3.CPObrigatorio = False
        Me.Conta3.CPObrigatorioMsg = Nothing
        Me.Conta3.Enabled = False
        Me.Conta3.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta3.FlatBorder = True
        Me.Conta3.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta3.FocusColor = System.Drawing.Color.Empty
        Me.Conta3.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta3.HighlightBorderOnEnter = False
        Me.Conta3.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Conta3.Location = New System.Drawing.Point(9, 66)
        Me.Conta3.MaxLength = 6
        Me.Conta3.Name = "Conta3"
        Me.Conta3.PreencherZeroEsqueda = True
        Me.Conta3.RegraValidação = Nothing
        Me.Conta3.RegraValidaçãoMensagem = Nothing
        Me.Conta3.Size = New System.Drawing.Size(57, 23)
        Me.Conta3.TabIndex = 11
        Me.Conta3.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta3.ValorPadrao = Nothing
        '
        'Vlr3
        '
        Me.Vlr3.AceitaColarTexto = True
        Me.Vlr3.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr3.CasasDecimais = 2
        Me.Vlr3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr3.CPObrigatorio = False
        Me.Vlr3.CPObrigatorioMsg = Nothing
        Me.Vlr3.Enabled = False
        Me.Vlr3.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr3.FlatBorder = True
        Me.Vlr3.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr3.FocusColor = System.Drawing.Color.Empty
        Me.Vlr3.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr3.HighlightBorderOnEnter = False
        Me.Vlr3.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vlr3.Location = New System.Drawing.Point(363, 66)
        Me.Vlr3.MaxLength = 15
        Me.Vlr3.Name = "Vlr3"
        Me.Vlr3.PreencherZeroEsqueda = False
        Me.Vlr3.RegraValidação = Nothing
        Me.Vlr3.RegraValidaçãoMensagem = Nothing
        Me.Vlr3.Size = New System.Drawing.Size(92, 23)
        Me.Vlr3.TabIndex = 14
        Me.Vlr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr3.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr3.ValorPadrao = Nothing
        '
        'Conta2
        '
        Me.Conta2.AceitaColarTexto = True
        Me.Conta2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta2.CasasDecimais = 0
        Me.Conta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta2.CPObrigatorio = False
        Me.Conta2.CPObrigatorioMsg = Nothing
        Me.Conta2.Enabled = False
        Me.Conta2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta2.FlatBorder = True
        Me.Conta2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta2.FocusColor = System.Drawing.Color.Empty
        Me.Conta2.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta2.HighlightBorderOnEnter = False
        Me.Conta2.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Conta2.Location = New System.Drawing.Point(9, 44)
        Me.Conta2.MaxLength = 6
        Me.Conta2.Name = "Conta2"
        Me.Conta2.PreencherZeroEsqueda = True
        Me.Conta2.RegraValidação = Nothing
        Me.Conta2.RegraValidaçãoMensagem = Nothing
        Me.Conta2.Size = New System.Drawing.Size(57, 23)
        Me.Conta2.TabIndex = 7
        Me.Conta2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta2.ValorPadrao = Nothing
        '
        'Vlr2
        '
        Me.Vlr2.AceitaColarTexto = True
        Me.Vlr2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr2.CasasDecimais = 2
        Me.Vlr2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr2.CPObrigatorio = False
        Me.Vlr2.CPObrigatorioMsg = Nothing
        Me.Vlr2.Enabled = False
        Me.Vlr2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr2.FlatBorder = True
        Me.Vlr2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr2.FocusColor = System.Drawing.Color.Empty
        Me.Vlr2.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr2.HighlightBorderOnEnter = False
        Me.Vlr2.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vlr2.Location = New System.Drawing.Point(363, 44)
        Me.Vlr2.MaxLength = 15
        Me.Vlr2.Name = "Vlr2"
        Me.Vlr2.PreencherZeroEsqueda = False
        Me.Vlr2.RegraValidação = Nothing
        Me.Vlr2.RegraValidaçãoMensagem = Nothing
        Me.Vlr2.Size = New System.Drawing.Size(92, 23)
        Me.Vlr2.TabIndex = 10
        Me.Vlr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr2.ValorPadrao = Nothing
        '
        'Conta1
        '
        Me.Conta1.AceitaColarTexto = True
        Me.Conta1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta1.CasasDecimais = 0
        Me.Conta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta1.CPObrigatorio = False
        Me.Conta1.CPObrigatorioMsg = Nothing
        Me.Conta1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta1.FlatBorder = True
        Me.Conta1.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta1.FocusColor = System.Drawing.Color.Empty
        Me.Conta1.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta1.HighlightBorderOnEnter = False
        Me.Conta1.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Conta1.Location = New System.Drawing.Point(9, 22)
        Me.Conta1.MaxLength = 6
        Me.Conta1.Name = "Conta1"
        Me.Conta1.PreencherZeroEsqueda = True
        Me.Conta1.RegraValidação = Nothing
        Me.Conta1.RegraValidaçãoMensagem = Nothing
        Me.Conta1.Size = New System.Drawing.Size(57, 23)
        Me.Conta1.TabIndex = 3
        Me.Conta1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta1.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Conta"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(363, 2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 21)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Valor"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescConta1
        '
        Me.DescConta1.AceitaColarTexto = True
        Me.DescConta1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescConta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescConta1.CasasDecimais = 0
        Me.DescConta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescConta1.CPObrigatorio = False
        Me.DescConta1.CPObrigatorioMsg = Nothing
        Me.DescConta1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescConta1.FlatBorder = True
        Me.DescConta1.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescConta1.FocusColor = System.Drawing.Color.Empty
        Me.DescConta1.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescConta1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescConta1.HighlightBorderOnEnter = False
        Me.DescConta1.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescConta1.Location = New System.Drawing.Point(86, 22)
        Me.DescConta1.MaxLength = 100
        Me.DescConta1.Name = "DescConta1"
        Me.DescConta1.PreencherZeroEsqueda = False
        Me.DescConta1.RegraValidação = Nothing
        Me.DescConta1.RegraValidaçãoMensagem = Nothing
        Me.DescConta1.Size = New System.Drawing.Size(278, 23)
        Me.DescConta1.TabIndex = 5
        Me.DescConta1.TabStop = False
        Me.DescConta1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescConta1.ValorPadrao = Nothing
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(65, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(299, 21)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Descrição"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vlr1
        '
        Me.Vlr1.AceitaColarTexto = True
        Me.Vlr1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vlr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vlr1.CasasDecimais = 2
        Me.Vlr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vlr1.CPObrigatorio = False
        Me.Vlr1.CPObrigatorioMsg = Nothing
        Me.Vlr1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vlr1.FlatBorder = True
        Me.Vlr1.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vlr1.FocusColor = System.Drawing.Color.Empty
        Me.Vlr1.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vlr1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vlr1.HighlightBorderOnEnter = False
        Me.Vlr1.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vlr1.Location = New System.Drawing.Point(363, 22)
        Me.Vlr1.MaxLength = 15
        Me.Vlr1.Name = "Vlr1"
        Me.Vlr1.PreencherZeroEsqueda = False
        Me.Vlr1.RegraValidação = Nothing
        Me.Vlr1.RegraValidaçãoMensagem = Nothing
        Me.Vlr1.Size = New System.Drawing.Size(92, 23)
        Me.Vlr1.TabIndex = 6
        Me.Vlr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vlr1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Vlr1.ValorPadrao = Nothing
        '
        'SubSerie
        '
        Me.SubSerie.AceitaColarTexto = True
        Me.SubSerie.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SubSerie.CasasDecimais = 0
        Me.SubSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SubSerie.CPObrigatorio = False
        Me.SubSerie.CPObrigatorioMsg = Nothing
        Me.SubSerie.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SubSerie.FlatBorder = False
        Me.SubSerie.FlatBorderColor = System.Drawing.Color.DimGray
        Me.SubSerie.FocusColor = System.Drawing.Color.Empty
        Me.SubSerie.FocusColorEnd = System.Drawing.Color.Empty
        Me.SubSerie.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SubSerie.HighlightBorderOnEnter = False
        Me.SubSerie.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.SubSerie.Location = New System.Drawing.Point(261, 93)
        Me.SubSerie.MaxLength = 2
        Me.SubSerie.Name = "SubSerie"
        Me.SubSerie.PreencherZeroEsqueda = False
        Me.SubSerie.RegraValidação = Nothing
        Me.SubSerie.RegraValidaçãoMensagem = Nothing
        Me.SubSerie.Size = New System.Drawing.Size(54, 23)
        Me.SubSerie.TabIndex = 10
        Me.SubSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.SubSerie, "Lançar conforme a nota de entrada")
        Me.SubSerie.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.SubSerie.ValorPadrao = Nothing
        '
        'CFOP
        '
        Me.CFOP.AceitaColarTexto = True
        Me.CFOP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CFOP.CasasDecimais = 0
        Me.CFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CFOP.CPObrigatorio = False
        Me.CFOP.CPObrigatorioMsg = Nothing
        Me.CFOP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CFOP.FlatBorder = False
        Me.CFOP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CFOP.FocusColor = System.Drawing.Color.Empty
        Me.CFOP.FocusColorEnd = System.Drawing.Color.Empty
        Me.CFOP.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFOP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CFOP.HighlightBorderOnEnter = False
        Me.CFOP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CFOP.Location = New System.Drawing.Point(107, 121)
        Me.CFOP.MaxLength = 15
        Me.CFOP.Name = "CFOP"
        Me.CFOP.PreencherZeroEsqueda = False
        Me.CFOP.RegraValidação = Nothing
        Me.CFOP.RegraValidaçãoMensagem = Nothing
        Me.CFOP.Size = New System.Drawing.Size(54, 23)
        Me.CFOP.TabIndex = 15
        Me.CFOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.CFOP, "Utilize o cfop principal de entrada da sua nota")
        Me.CFOP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.CFOP.ValorPadrao = Nothing
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(17, 124)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 20)
        Me.Label35.TabIndex = 14
        Me.Label35.Text = "CFOP Entrada"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(174, 96)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 20)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "SubSérie"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PainelDev
        '
        Me.PainelDev.CanvasColor = System.Drawing.SystemColors.Control
        Me.PainelDev.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PainelDev.Controls.Add(Me.IdNFdevMae)
        Me.PainelDev.Controls.Add(Me.NFdevMaeValor)
        Me.PainelDev.Controls.Add(Me.Label13)
        Me.PainelDev.Controls.Add(Me.btFindNFDevolucao)
        Me.PainelDev.Controls.Add(Me.NFdevMae)
        Me.PainelDev.Controls.Add(Me.NFdevMaeLabel)
        Me.PainelDev.Location = New System.Drawing.Point(12, 179)
        Me.PainelDev.Name = "PainelDev"
        Me.PainelDev.Size = New System.Drawing.Size(523, 50)
        '
        '
        '
        Me.PainelDev.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PainelDev.Style.BackColorGradientAngle = 90
        Me.PainelDev.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PainelDev.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PainelDev.Style.BorderBottomWidth = 1
        Me.PainelDev.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PainelDev.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PainelDev.Style.BorderLeftWidth = 1
        Me.PainelDev.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PainelDev.Style.BorderRightWidth = 1
        Me.PainelDev.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PainelDev.Style.BorderTopWidth = 1
        Me.PainelDev.Style.Class = ""
        Me.PainelDev.Style.CornerDiameter = 4
        Me.PainelDev.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PainelDev.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.PainelDev.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PainelDev.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.PainelDev.StyleMouseDown.Class = ""
        Me.PainelDev.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.PainelDev.StyleMouseOver.Class = ""
        Me.PainelDev.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PainelDev.TabIndex = 24
        Me.PainelDev.Text = "Dados do Doc/NF Mãe de Devolução"
        Me.PainelDev.Visible = False
        '
        'IdNFdevMae
        '
        Me.IdNFdevMae.AceitaColarTexto = True
        Me.IdNFdevMae.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IdNFdevMae.CasasDecimais = 0
        Me.IdNFdevMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdNFdevMae.CPObrigatorio = False
        Me.IdNFdevMae.CPObrigatorioMsg = Nothing
        Me.IdNFdevMae.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.IdNFdevMae.FlatBorder = False
        Me.IdNFdevMae.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdNFdevMae.FocusColor = System.Drawing.Color.Empty
        Me.IdNFdevMae.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdNFdevMae.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdNFdevMae.HighlightBorderOnEnter = False
        Me.IdNFdevMae.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdNFdevMae.Location = New System.Drawing.Point(370, 5)
        Me.IdNFdevMae.Name = "IdNFdevMae"
        Me.IdNFdevMae.PreencherZeroEsqueda = False
        Me.IdNFdevMae.RegraValidação = Nothing
        Me.IdNFdevMae.RegraValidaçãoMensagem = Nothing
        Me.IdNFdevMae.Size = New System.Drawing.Size(26, 23)
        Me.IdNFdevMae.TabIndex = 4
        Me.IdNFdevMae.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IdNFdevMae.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdNFdevMae.ValorPadrao = Nothing
        Me.IdNFdevMae.Visible = False
        '
        'NFdevMaeValor
        '
        Me.NFdevMaeValor.AceitaColarTexto = True
        Me.NFdevMaeValor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NFdevMaeValor.CasasDecimais = 0
        Me.NFdevMaeValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NFdevMaeValor.CPObrigatorio = False
        Me.NFdevMaeValor.CPObrigatorioMsg = Nothing
        Me.NFdevMaeValor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.NFdevMaeValor.FlatBorder = False
        Me.NFdevMaeValor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NFdevMaeValor.FocusColor = System.Drawing.Color.Empty
        Me.NFdevMaeValor.FocusColorEnd = System.Drawing.Color.Empty
        Me.NFdevMaeValor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NFdevMaeValor.HighlightBorderOnEnter = False
        Me.NFdevMaeValor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NFdevMaeValor.Location = New System.Drawing.Point(401, 5)
        Me.NFdevMaeValor.MaxLength = 10
        Me.NFdevMaeValor.Name = "NFdevMaeValor"
        Me.NFdevMaeValor.PreencherZeroEsqueda = False
        Me.NFdevMaeValor.RegraValidação = Nothing
        Me.NFdevMaeValor.RegraValidaçãoMensagem = Nothing
        Me.NFdevMaeValor.Size = New System.Drawing.Size(84, 23)
        Me.NFdevMaeValor.TabIndex = 5
        Me.NFdevMaeValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NFdevMaeValor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.NFdevMaeValor.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(267, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 20)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Vlr NF/Doc Mãe"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFindNFDevolucao
        '
        Me.btFindNFDevolucao.Image = CType(resources.GetObject("btFindNFDevolucao.Image"), System.Drawing.Image)
        Me.btFindNFDevolucao.Location = New System.Drawing.Point(222, 5)
        Me.btFindNFDevolucao.Name = "btFindNFDevolucao"
        Me.btFindNFDevolucao.Size = New System.Drawing.Size(23, 23)
        Me.btFindNFDevolucao.TabIndex = 2
        '
        'NFdevMae
        '
        Me.NFdevMae.AceitaColarTexto = True
        Me.NFdevMae.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NFdevMae.CasasDecimais = 0
        Me.NFdevMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NFdevMae.CPObrigatorio = False
        Me.NFdevMae.CPObrigatorioMsg = Nothing
        Me.NFdevMae.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.NFdevMae.FlatBorder = False
        Me.NFdevMae.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NFdevMae.FocusColor = System.Drawing.Color.Empty
        Me.NFdevMae.FocusColorEnd = System.Drawing.Color.Empty
        Me.NFdevMae.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NFdevMae.HighlightBorderOnEnter = False
        Me.NFdevMae.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NFdevMae.Location = New System.Drawing.Point(135, 5)
        Me.NFdevMae.Name = "NFdevMae"
        Me.NFdevMae.PreencherZeroEsqueda = False
        Me.NFdevMae.RegraValidação = Nothing
        Me.NFdevMae.RegraValidaçãoMensagem = Nothing
        Me.NFdevMae.Size = New System.Drawing.Size(84, 23)
        Me.NFdevMae.TabIndex = 1
        Me.NFdevMae.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NFdevMae.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NFdevMae.ValorPadrao = Nothing
        '
        'NFdevMaeLabel
        '
        Me.NFdevMaeLabel.BackColor = System.Drawing.Color.Transparent
        Me.NFdevMaeLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NFdevMaeLabel.Location = New System.Drawing.Point(1, 5)
        Me.NFdevMaeLabel.Name = "NFdevMaeLabel"
        Me.NFdevMaeLabel.Size = New System.Drawing.Size(128, 20)
        Me.NFdevMaeLabel.TabIndex = 0
        Me.NFdevMaeLabel.Text = "NF/Doc Dev. Mãe"
        Me.NFdevMaeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx2.Controls.Add(Me.DataCompra)
        Me.PanelEx2.Controls.Add(Me.DataLancamento)
        Me.PanelEx2.Controls.Add(Me.NotaFiscal)
        Me.PanelEx2.Controls.Add(Me.DataEntrada)
        Me.PanelEx2.Controls.Add(Me.Label41)
        Me.PanelEx2.Controls.Add(Me.ValorCompra)
        Me.PanelEx2.Controls.Add(Me.Label4)
        Me.PanelEx2.Controls.Add(Me.Label14)
        Me.PanelEx2.Controls.Add(Me.Label3)
        Me.PanelEx2.Controls.Add(Me.Label7)
        Me.PanelEx2.Location = New System.Drawing.Point(637, 59)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(374, 102)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 23
        '
        'DataCompra
        '
        Me.DataCompra.AceitaColarTexto = True
        Me.DataCompra.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataCompra.CasasDecimais = 0
        Me.DataCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataCompra.CPObrigatorio = False
        Me.DataCompra.CPObrigatorioMsg = Nothing
        Me.DataCompra.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataCompra.FlatBorder = False
        Me.DataCompra.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataCompra.FocusColor = System.Drawing.Color.Empty
        Me.DataCompra.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataCompra.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataCompra.HighlightBorderOnEnter = False
        Me.DataCompra.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataCompra.Location = New System.Drawing.Point(260, 7)
        Me.DataCompra.MaxLength = 10
        Me.DataCompra.Name = "DataCompra"
        Me.DataCompra.PreencherZeroEsqueda = False
        Me.DataCompra.RegraValidação = Nothing
        Me.DataCompra.RegraValidaçãoMensagem = Nothing
        Me.DataCompra.Size = New System.Drawing.Size(102, 23)
        Me.DataCompra.TabIndex = 3
        Me.DataCompra.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataCompra.ValorPadrao = Nothing
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = True
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.ContextMenuStrip = Me.MenuDataLancamento
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FlatBorder = False
        Me.DataLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataLancamento.HighlightBorderOnEnter = False
        Me.DataLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataLancamento.Location = New System.Drawing.Point(260, 36)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.PreencherZeroEsqueda = False
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(102, 23)
        Me.DataLancamento.TabIndex = 7
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'NotaFiscal
        '
        Me.NotaFiscal.AceitaColarTexto = True
        Me.NotaFiscal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NotaFiscal.CasasDecimais = 2
        Me.NotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NotaFiscal.CPObrigatorio = False
        Me.NotaFiscal.CPObrigatorioMsg = Nothing
        Me.NotaFiscal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NotaFiscal.FlatBorder = False
        Me.NotaFiscal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.FocusColor = System.Drawing.Color.Empty
        Me.NotaFiscal.FocusColorEnd = System.Drawing.Color.Empty
        Me.NotaFiscal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaFiscal.HighlightBorderOnEnter = False
        Me.NotaFiscal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.Location = New System.Drawing.Point(78, 7)
        Me.NotaFiscal.MaxLength = 10
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.PreencherZeroEsqueda = False
        Me.NotaFiscal.RegraValidação = Nothing
        Me.NotaFiscal.RegraValidaçãoMensagem = Nothing
        Me.NotaFiscal.Size = New System.Drawing.Size(103, 23)
        Me.NotaFiscal.TabIndex = 1
        Me.NotaFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NotaFiscal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NotaFiscal.ValorPadrao = Nothing
        '
        'DataEntrada
        '
        Me.DataEntrada.AceitaColarTexto = True
        Me.DataEntrada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataEntrada.CasasDecimais = 0
        Me.DataEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataEntrada.CPObrigatorio = False
        Me.DataEntrada.CPObrigatorioMsg = Nothing
        Me.DataEntrada.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataEntrada.FlatBorder = False
        Me.DataEntrada.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataEntrada.FocusColor = System.Drawing.Color.Empty
        Me.DataEntrada.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataEntrada.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataEntrada.HighlightBorderOnEnter = False
        Me.DataEntrada.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataEntrada.Location = New System.Drawing.Point(78, 37)
        Me.DataEntrada.MaxLength = 10
        Me.DataEntrada.Name = "DataEntrada"
        Me.DataEntrada.PreencherZeroEsqueda = False
        Me.DataEntrada.RegraValidação = Nothing
        Me.DataEntrada.RegraValidaçãoMensagem = Nothing
        Me.DataEntrada.Size = New System.Drawing.Size(102, 23)
        Me.DataEntrada.TabIndex = 5
        Me.DataEntrada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataEntrada.ValorPadrao = Nothing
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(183, 37)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(73, 23)
        Me.Label41.TabIndex = 6
        Me.Label41.Text = "Data Lanç."
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorCompra
        '
        Me.ValorCompra.AceitaColarTexto = True
        Me.ValorCompra.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorCompra.CasasDecimais = 2
        Me.ValorCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorCompra.CPObrigatorio = False
        Me.ValorCompra.CPObrigatorioMsg = Nothing
        Me.ValorCompra.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.ValorCompra.FlatBorder = False
        Me.ValorCompra.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorCompra.FocusColor = System.Drawing.Color.Empty
        Me.ValorCompra.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorCompra.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ValorCompra.HighlightBorderOnEnter = False
        Me.ValorCompra.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorCompra.Location = New System.Drawing.Point(260, 65)
        Me.ValorCompra.MaxLength = 10
        Me.ValorCompra.Name = "ValorCompra"
        Me.ValorCompra.PreencherZeroEsqueda = False
        Me.ValorCompra.RegraValidação = Nothing
        Me.ValorCompra.RegraValidaçãoMensagem = Nothing
        Me.ValorCompra.Size = New System.Drawing.Size(103, 23)
        Me.ValorCompra.TabIndex = 7
        Me.ValorCompra.Text = "R$ 0,00"
        Me.ValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorCompra.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorCompra.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data Entrada"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(183, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 22)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Total NF"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data Emissão"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "NF/Doc"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btModelos
        '
        Me.btModelos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btModelos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btModelos.Location = New System.Drawing.Point(570, 97)
        Me.btModelos.Name = "btModelos"
        Me.btModelos.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btModelos.Size = New System.Drawing.Size(28, 20)
        Me.btModelos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btModelos.TabIndex = 13
        Me.btModelos.TabStop = False
        Me.btModelos.Text = "..."
        '
        'TpEntrada
        '
        Me.TpEntrada.Auto_Complete = True
        Me.TpEntrada.AutoLimitar_Lista = True
        Me.TpEntrada.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.TpEntrada.CPObrigatorio = False
        Me.TpEntrada.CPObrigatorioMsg = Nothing
        Me.TpEntrada.FlatBorder = False
        Me.TpEntrada.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TpEntrada.FormattingEnabled = True
        Me.TpEntrada.HighlightBorderColor = System.Drawing.Color.Empty
        Me.TpEntrada.HighlightBorderOnEnter = False
        Me.TpEntrada.Items.AddRange(New Object() {"ENTRADA", "DEVOLUÇÃO", "ENT BRINDE"})
        Me.TpEntrada.Location = New System.Drawing.Point(261, 63)
        Me.TpEntrada.Name = "TpEntrada"
        Me.TpEntrada.Size = New System.Drawing.Size(117, 24)
        Me.TpEntrada.TabIndex = 4
        '
        'Modelo
        '
        Me.Modelo.AceitaColarTexto = True
        Me.Modelo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Modelo.CasasDecimais = 0
        Me.Modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Modelo.CPObrigatorio = False
        Me.Modelo.CPObrigatorioMsg = Nothing
        Me.Modelo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Modelo.FlatBorder = False
        Me.Modelo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Modelo.FocusColor = System.Drawing.Color.Empty
        Me.Modelo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Modelo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Modelo.HighlightBorderOnEnter = False
        Me.Modelo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Modelo.Location = New System.Drawing.Point(481, 96)
        Me.Modelo.MaxLength = 2
        Me.Modelo.Name = "Modelo"
        Me.Modelo.PreencherZeroEsqueda = True
        Me.Modelo.RegraValidação = Nothing
        Me.Modelo.RegraValidaçãoMensagem = Nothing
        Me.Modelo.Size = New System.Drawing.Size(83, 23)
        Me.Modelo.TabIndex = 12
        Me.Modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Modelo, "Utilizar cod 55 para NFE")
        Me.Modelo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Modelo.ValorPadrao = Nothing
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(397, 99)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(78, 20)
        Me.Label33.TabIndex = 11
        Me.Label33.Text = "Modelo"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(174, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 21)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Ent/Dev"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cTipo
        '
        Me.cTipo.Auto_Complete = True
        Me.cTipo.AutoLimitar_Lista = True
        Me.cTipo.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cTipo.CPObrigatorio = False
        Me.cTipo.CPObrigatorioMsg = Nothing
        Me.cTipo.FlatBorder = False
        Me.cTipo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cTipo.FormattingEnabled = True
        Me.cTipo.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cTipo.HighlightBorderOnEnter = False
        Me.cTipo.Items.AddRange(New Object() {"NF", "DOC"})
        Me.cTipo.Location = New System.Drawing.Point(481, 63)
        Me.cTipo.Name = "cTipo"
        Me.cTipo.Size = New System.Drawing.Size(117, 24)
        Me.cTipo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(394, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tipo Doc"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabGeral
        '
        Me.TabGeral.BackColor = System.Drawing.Color.Transparent
        Me.TabGeral.CanReorderTabs = False
        Me.TabGeral.Controls.Add(Me.Itens)
        Me.TabGeral.Controls.Add(Me.TabControlPanel1)
        Me.TabGeral.Controls.Add(Me.TabControlPanel3)
        Me.TabGeral.Controls.Add(Me.TabControlPanel2)
        Me.TabGeral.Location = New System.Drawing.Point(12, 351)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedTabFont = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabGeral.SelectedTabIndex = 2
        Me.TabGeral.Size = New System.Drawing.Size(999, 269)
        Me.TabGeral.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabGeral.TabIndex = 27
        Me.TabGeral.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabGeral.Tabs.Add(Me.TabItens)
        Me.TabGeral.Tabs.Add(Me.TabItem1)
        Me.TabGeral.Tabs.Add(Me.DevolucaoTab)
        Me.TabGeral.Tabs.Add(Me.TabItem2)
        '
        'Itens
        '
        Me.Itens.Controls.Add(Me.Confirmado)
        Me.Itens.Controls.Add(Me.TotalCofins)
        Me.Itens.Controls.Add(Me.AdicionarItens)
        Me.Itens.Controls.Add(Me.TotalPis)
        Me.Itens.Controls.Add(Me.TotalItensIpi)
        Me.Itens.Controls.Add(Me.Label42)
        Me.Itens.Controls.Add(Me.MyLista)
        Me.Itens.Controls.Add(Me.TotalItensLançado)
        Me.Itens.Controls.Add(Me.Inativo)
        Me.Itens.Controls.Add(Me.Label40)
        Me.Itens.Controls.Add(Me.Label53)
        Me.Itens.Controls.Add(Me.Label54)
        Me.Itens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Itens.Location = New System.Drawing.Point(0, 22)
        Me.Itens.Name = "Itens"
        Me.Itens.Padding = New System.Windows.Forms.Padding(1)
        Me.Itens.Size = New System.Drawing.Size(999, 247)
        Me.Itens.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Itens.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Itens.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Itens.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Itens.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.Itens.Style.GradientAngle = 90
        Me.Itens.TabIndex = 1
        Me.Itens.TabItem = Me.TabItens
        '
        'TotalCofins
        '
        Me.TotalCofins.AceitaColarTexto = True
        Me.TotalCofins.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalCofins.CasasDecimais = 2
        Me.TotalCofins.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalCofins.CPObrigatorio = False
        Me.TotalCofins.CPObrigatorioMsg = Nothing
        Me.TotalCofins.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalCofins.FlatBorder = False
        Me.TotalCofins.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalCofins.FocusColor = System.Drawing.Color.Empty
        Me.TotalCofins.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalCofins.HighlightBorderOnEnter = False
        Me.TotalCofins.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalCofins.Location = New System.Drawing.Point(518, 216)
        Me.TotalCofins.MaxLength = 15
        Me.TotalCofins.Name = "TotalCofins"
        Me.TotalCofins.PreencherZeroEsqueda = False
        Me.TotalCofins.RegraValidação = Nothing
        Me.TotalCofins.RegraValidaçãoMensagem = Nothing
        Me.TotalCofins.Size = New System.Drawing.Size(76, 20)
        Me.TotalCofins.TabIndex = 8
        Me.TotalCofins.TabStop = False
        Me.TotalCofins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalCofins.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.TotalCofins.ValorPadrao = Nothing
        '
        'AdicionarItens
        '
        Me.AdicionarItens.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AdicionarItens.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AdicionarItens.Location = New System.Drawing.Point(897, 216)
        Me.AdicionarItens.Name = "AdicionarItens"
        Me.AdicionarItens.Size = New System.Drawing.Size(94, 25)
        Me.AdicionarItens.TabIndex = 9
        Me.AdicionarItens.Text = "Add Item [F7]"
        '
        'TotalPis
        '
        Me.TotalPis.AceitaColarTexto = True
        Me.TotalPis.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalPis.CasasDecimais = 2
        Me.TotalPis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalPis.CPObrigatorio = False
        Me.TotalPis.CPObrigatorioMsg = Nothing
        Me.TotalPis.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalPis.FlatBorder = False
        Me.TotalPis.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalPis.FocusColor = System.Drawing.Color.Empty
        Me.TotalPis.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalPis.HighlightBorderOnEnter = False
        Me.TotalPis.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalPis.Location = New System.Drawing.Point(357, 216)
        Me.TotalPis.MaxLength = 15
        Me.TotalPis.Name = "TotalPis"
        Me.TotalPis.PreencherZeroEsqueda = False
        Me.TotalPis.RegraValidação = Nothing
        Me.TotalPis.RegraValidaçãoMensagem = Nothing
        Me.TotalPis.Size = New System.Drawing.Size(76, 20)
        Me.TotalPis.TabIndex = 6
        Me.TotalPis.TabStop = False
        Me.TotalPis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalPis.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.TotalPis.ValorPadrao = Nothing
        '
        'TotalItensIpi
        '
        Me.TotalItensIpi.AceitaColarTexto = True
        Me.TotalItensIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalItensIpi.CasasDecimais = 2
        Me.TotalItensIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalItensIpi.CPObrigatorio = False
        Me.TotalItensIpi.CPObrigatorioMsg = Nothing
        Me.TotalItensIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalItensIpi.FlatBorder = False
        Me.TotalItensIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalItensIpi.FocusColor = System.Drawing.Color.Empty
        Me.TotalItensIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalItensIpi.HighlightBorderOnEnter = False
        Me.TotalItensIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalItensIpi.Location = New System.Drawing.Point(213, 216)
        Me.TotalItensIpi.MaxLength = 15
        Me.TotalItensIpi.Name = "TotalItensIpi"
        Me.TotalItensIpi.PreencherZeroEsqueda = False
        Me.TotalItensIpi.RegraValidação = Nothing
        Me.TotalItensIpi.RegraValidaçãoMensagem = Nothing
        Me.TotalItensIpi.Size = New System.Drawing.Size(76, 20)
        Me.TotalItensIpi.TabIndex = 4
        Me.TotalItensIpi.TabStop = False
        Me.TotalItensIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalItensIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.TotalItensIpi.ValorPadrao = Nothing
        '
        'TotalItensLançado
        '
        Me.TotalItensLançado.AceitaColarTexto = True
        Me.TotalItensLançado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalItensLançado.CasasDecimais = 2
        Me.TotalItensLançado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalItensLançado.CPObrigatorio = False
        Me.TotalItensLançado.CPObrigatorioMsg = Nothing
        Me.TotalItensLançado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalItensLançado.FlatBorder = False
        Me.TotalItensLançado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalItensLançado.FocusColor = System.Drawing.Color.Empty
        Me.TotalItensLançado.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalItensLançado.HighlightBorderOnEnter = False
        Me.TotalItensLançado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalItensLançado.Location = New System.Drawing.Point(71, 216)
        Me.TotalItensLançado.MaxLength = 15
        Me.TotalItensLançado.Name = "TotalItensLançado"
        Me.TotalItensLançado.PreencherZeroEsqueda = False
        Me.TotalItensLançado.RegraValidação = Nothing
        Me.TotalItensLançado.RegraValidaçãoMensagem = Nothing
        Me.TotalItensLançado.Size = New System.Drawing.Size(76, 20)
        Me.TotalItensLançado.TabIndex = 2
        Me.TotalItensLançado.TabStop = False
        Me.TotalItensLançado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalItensLançado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.TotalItensLançado.ValorPadrao = Nothing
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(297, 216)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(54, 20)
        Me.Label53.TabIndex = 5
        Me.Label53.Text = "Tot. PIS"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label54.Location = New System.Drawing.Point(439, 217)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(73, 20)
        Me.Label54.TabIndex = 7
        Me.Label54.Text = "Tot. COFINS"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabItens
        '
        Me.TabItens.AttachedControl = Me.Itens
        Me.TabItens.Name = "TabItens"
        Me.TabItens.Text = "Itens [F7]"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.EFocusPanel3)
        Me.TabControlPanel1.Controls.Add(Me.EFocusPanel2)
        Me.TabControlPanel1.Controls.Add(Me.EFocusPanel1)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(999, 247)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 3
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'EFocusPanel3
        '
        Me.EFocusPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EFocusPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EFocusPanel3.Controls.Add(Me.c3)
        Me.EFocusPanel3.Controls.Add(Me.c2)
        Me.EFocusPanel3.Controls.Add(Me.c1)
        Me.EFocusPanel3.Controls.Add(Me.Label37)
        Me.EFocusPanel3.Controls.Add(Me.ValorDesconto)
        Me.EFocusPanel3.Controls.Add(Me.Label2)
        Me.EFocusPanel3.Controls.Add(Me.Label31)
        Me.EFocusPanel3.Controls.Add(Me.TotalProdutos)
        Me.EFocusPanel3.Controls.Add(Me.ValorIssqnRetido)
        Me.EFocusPanel3.Controls.Add(Me.BaseCalcIcmsST)
        Me.EFocusPanel3.Controls.Add(Me.Label50)
        Me.EFocusPanel3.Controls.Add(Me.ValorIcmsST)
        Me.EFocusPanel3.Controls.Add(Me.ValorFrete)
        Me.EFocusPanel3.Controls.Add(Me.Label30)
        Me.EFocusPanel3.Controls.Add(Me.Label10)
        Me.EFocusPanel3.Controls.Add(Me.Label6)
        Me.EFocusPanel3.Controls.Add(Me.ValorOutros)
        Me.EFocusPanel3.Icon = Nothing
        Me.EFocusPanel3.Image = Nothing
        Me.EFocusPanel3.IsTransparent = False
        Me.EFocusPanel3.LineColor = System.Drawing.SystemColors.Highlight
        Me.EFocusPanel3.Location = New System.Drawing.Point(11, 9)
        Me.EFocusPanel3.Name = "EFocusPanel3"
        Me.EFocusPanel3.Padding = New System.Windows.Forms.Padding(4, 22, 4, 4)
        Me.EFocusPanel3.Size = New System.Drawing.Size(325, 230)
        Me.EFocusPanel3.TabIndex = 12
        Me.EFocusPanel3.Text = "Informações Gerais"
        '
        'c3
        '
        Me.c3.BackColor = System.Drawing.Color.Khaki
        Me.c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c3.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c3.ForeColor = System.Drawing.Color.Maroon
        Me.c3.Location = New System.Drawing.Point(230, 198)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(86, 23)
        Me.c3.TabIndex = 18
        Me.c3.Text = "00,00"
        Me.c3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c2
        '
        Me.c2.BackColor = System.Drawing.Color.Khaki
        Me.c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c2.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.ForeColor = System.Drawing.Color.Maroon
        Me.c2.Location = New System.Drawing.Point(230, 137)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(86, 23)
        Me.c2.TabIndex = 17
        Me.c2.Text = "00,00"
        Me.c2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c1
        '
        Me.c1.BackColor = System.Drawing.Color.Khaki
        Me.c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c1.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.ForeColor = System.Drawing.Color.Maroon
        Me.c1.Location = New System.Drawing.Point(230, 109)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(86, 23)
        Me.c1.TabIndex = 16
        Me.c1.Text = "00,00"
        Me.c1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(7, 52)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(113, 19)
        Me.Label37.TabIndex = 4
        Me.Label37.Text = "Valor Desconto"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDesconto
        '
        Me.ValorDesconto.AceitaColarTexto = True
        Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDesconto.CasasDecimais = 2
        Me.ValorDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDesconto.CPObrigatorio = False
        Me.ValorDesconto.CPObrigatorioMsg = Nothing
        Me.ValorDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDesconto.FlatBorder = False
        Me.ValorDesconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.FocusColor = System.Drawing.Color.Empty
        Me.ValorDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDesconto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorDesconto.HighlightBorderOnEnter = False
        Me.ValorDesconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDesconto.Location = New System.Drawing.Point(126, 51)
        Me.ValorDesconto.MaxLength = 10
        Me.ValorDesconto.Name = "ValorDesconto"
        Me.ValorDesconto.PreencherZeroEsqueda = False
        Me.ValorDesconto.RegraValidação = Nothing
        Me.ValorDesconto.RegraValidaçãoMensagem = Nothing
        Me.ValorDesconto.Size = New System.Drawing.Size(97, 23)
        Me.ValorDesconto.TabIndex = 5
        Me.ValorDesconto.Text = "R$ 0,00"
        Me.ValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDesconto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDesconto.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Base Calc. ICMS ST"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 171)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(112, 19)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Vlr. ISSQN Retido"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalProdutos
        '
        Me.TotalProdutos.AceitaColarTexto = True
        Me.TotalProdutos.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalProdutos.CasasDecimais = 2
        Me.TotalProdutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalProdutos.CPObrigatorio = False
        Me.TotalProdutos.CPObrigatorioMsg = Nothing
        Me.TotalProdutos.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalProdutos.FlatBorder = False
        Me.TotalProdutos.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalProdutos.FocusColor = System.Drawing.Color.Empty
        Me.TotalProdutos.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalProdutos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalProdutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalProdutos.HighlightBorderOnEnter = False
        Me.TotalProdutos.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalProdutos.Location = New System.Drawing.Point(126, 22)
        Me.TotalProdutos.MaxLength = 10
        Me.TotalProdutos.Name = "TotalProdutos"
        Me.TotalProdutos.PreencherZeroEsqueda = False
        Me.TotalProdutos.RegraValidação = Nothing
        Me.TotalProdutos.RegraValidaçãoMensagem = Nothing
        Me.TotalProdutos.Size = New System.Drawing.Size(98, 23)
        Me.TotalProdutos.TabIndex = 1
        Me.TotalProdutos.Text = "R$ 0,00"
        Me.TotalProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalProdutos.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalProdutos.ValorPadrao = Nothing
        '
        'ValorIssqnRetido
        '
        Me.ValorIssqnRetido.AceitaColarTexto = True
        Me.ValorIssqnRetido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIssqnRetido.CasasDecimais = 2
        Me.ValorIssqnRetido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorIssqnRetido.CPObrigatorio = False
        Me.ValorIssqnRetido.CPObrigatorioMsg = Nothing
        Me.ValorIssqnRetido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIssqnRetido.FlatBorder = False
        Me.ValorIssqnRetido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIssqnRetido.FocusColor = System.Drawing.Color.Empty
        Me.ValorIssqnRetido.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIssqnRetido.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorIssqnRetido.HighlightBorderOnEnter = False
        Me.ValorIssqnRetido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIssqnRetido.Location = New System.Drawing.Point(126, 167)
        Me.ValorIssqnRetido.MaxLength = 10
        Me.ValorIssqnRetido.Name = "ValorIssqnRetido"
        Me.ValorIssqnRetido.PreencherZeroEsqueda = False
        Me.ValorIssqnRetido.RegraValidação = Nothing
        Me.ValorIssqnRetido.RegraValidaçãoMensagem = Nothing
        Me.ValorIssqnRetido.Size = New System.Drawing.Size(98, 23)
        Me.ValorIssqnRetido.TabIndex = 13
        Me.ValorIssqnRetido.Text = "R$ 0,00"
        Me.ValorIssqnRetido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorIssqnRetido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorIssqnRetido.ValorPadrao = Nothing
        '
        'BaseCalcIcmsST
        '
        Me.BaseCalcIcmsST.AceitaColarTexto = True
        Me.BaseCalcIcmsST.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BaseCalcIcmsST.CasasDecimais = 2
        Me.BaseCalcIcmsST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BaseCalcIcmsST.CPObrigatorio = False
        Me.BaseCalcIcmsST.CPObrigatorioMsg = Nothing
        Me.BaseCalcIcmsST.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BaseCalcIcmsST.FlatBorder = False
        Me.BaseCalcIcmsST.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcmsST.FocusColor = System.Drawing.Color.Empty
        Me.BaseCalcIcmsST.FocusColorEnd = System.Drawing.Color.Empty
        Me.BaseCalcIcmsST.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaseCalcIcmsST.HighlightBorderOnEnter = False
        Me.BaseCalcIcmsST.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcmsST.Location = New System.Drawing.Point(126, 109)
        Me.BaseCalcIcmsST.MaxLength = 10
        Me.BaseCalcIcmsST.Name = "BaseCalcIcmsST"
        Me.BaseCalcIcmsST.PreencherZeroEsqueda = False
        Me.BaseCalcIcmsST.RegraValidação = Nothing
        Me.BaseCalcIcmsST.RegraValidaçãoMensagem = Nothing
        Me.BaseCalcIcmsST.Size = New System.Drawing.Size(98, 23)
        Me.BaseCalcIcmsST.TabIndex = 9
        Me.BaseCalcIcmsST.Text = "R$ 0,00"
        Me.BaseCalcIcmsST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BaseCalcIcmsST.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.BaseCalcIcmsST.ValorPadrao = Nothing
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(7, 81)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(113, 19)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Valor Frete"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorIcmsST
        '
        Me.ValorIcmsST.AceitaColarTexto = True
        Me.ValorIcmsST.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIcmsST.CasasDecimais = 2
        Me.ValorIcmsST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorIcmsST.CPObrigatorio = False
        Me.ValorIcmsST.CPObrigatorioMsg = Nothing
        Me.ValorIcmsST.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIcmsST.FlatBorder = False
        Me.ValorIcmsST.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIcmsST.FocusColor = System.Drawing.Color.Empty
        Me.ValorIcmsST.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIcmsST.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorIcmsST.HighlightBorderOnEnter = False
        Me.ValorIcmsST.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIcmsST.Location = New System.Drawing.Point(126, 138)
        Me.ValorIcmsST.MaxLength = 10
        Me.ValorIcmsST.Name = "ValorIcmsST"
        Me.ValorIcmsST.PreencherZeroEsqueda = False
        Me.ValorIcmsST.RegraValidação = Nothing
        Me.ValorIcmsST.RegraValidaçãoMensagem = Nothing
        Me.ValorIcmsST.Size = New System.Drawing.Size(98, 23)
        Me.ValorIcmsST.TabIndex = 11
        Me.ValorIcmsST.Text = "R$ 0,00"
        Me.ValorIcmsST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorIcmsST.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorIcmsST.ValorPadrao = Nothing
        '
        'ValorFrete
        '
        Me.ValorFrete.AceitaColarTexto = True
        Me.ValorFrete.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorFrete.CasasDecimais = 2
        Me.ValorFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorFrete.CPObrigatorio = False
        Me.ValorFrete.CPObrigatorioMsg = Nothing
        Me.ValorFrete.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorFrete.FlatBorder = False
        Me.ValorFrete.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorFrete.FocusColor = System.Drawing.Color.Empty
        Me.ValorFrete.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorFrete.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorFrete.HighlightBorderOnEnter = False
        Me.ValorFrete.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorFrete.Location = New System.Drawing.Point(126, 80)
        Me.ValorFrete.MaxLength = 10
        Me.ValorFrete.Name = "ValorFrete"
        Me.ValorFrete.PreencherZeroEsqueda = False
        Me.ValorFrete.RegraValidação = Nothing
        Me.ValorFrete.RegraValidaçãoMensagem = Nothing
        Me.ValorFrete.Size = New System.Drawing.Size(98, 23)
        Me.ValorFrete.TabIndex = 3
        Me.ValorFrete.Text = "R$ 0,00"
        Me.ValorFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorFrete.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorFrete.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Valor Outros da NF"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Vlr. ICMS ST"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorOutros
        '
        Me.ValorOutros.AceitaColarTexto = True
        Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorOutros.CasasDecimais = 2
        Me.ValorOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorOutros.CPObrigatorio = False
        Me.ValorOutros.CPObrigatorioMsg = Nothing
        Me.ValorOutros.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorOutros.FlatBorder = False
        Me.ValorOutros.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorOutros.FocusColor = System.Drawing.Color.Empty
        Me.ValorOutros.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorOutros.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorOutros.HighlightBorderOnEnter = False
        Me.ValorOutros.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorOutros.Location = New System.Drawing.Point(126, 198)
        Me.ValorOutros.MaxLength = 10
        Me.ValorOutros.Name = "ValorOutros"
        Me.ValorOutros.PreencherZeroEsqueda = False
        Me.ValorOutros.RegraValidação = Nothing
        Me.ValorOutros.RegraValidaçãoMensagem = Nothing
        Me.ValorOutros.Size = New System.Drawing.Size(98, 23)
        Me.ValorOutros.TabIndex = 15
        Me.ValorOutros.Text = "R$ 0,00"
        Me.ValorOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorOutros.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorOutros.ValorPadrao = Nothing
        '
        'EFocusPanel2
        '
        Me.EFocusPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EFocusPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EFocusPanel2.Controls.Add(Me.c11)
        Me.EFocusPanel2.Controls.Add(Me.c10)
        Me.EFocusPanel2.Controls.Add(Me.c9)
        Me.EFocusPanel2.Controls.Add(Me.c8)
        Me.EFocusPanel2.Controls.Add(Me.ValorOutrosIpi)
        Me.EFocusPanel2.Controls.Add(Me.IsentoIpi)
        Me.EFocusPanel2.Controls.Add(Me.Label27)
        Me.EFocusPanel2.Controls.Add(Me.Label28)
        Me.EFocusPanel2.Controls.Add(Me.BaseCalcIpi)
        Me.EFocusPanel2.Controls.Add(Me.Label23)
        Me.EFocusPanel2.Controls.Add(Me.VlrIpi)
        Me.EFocusPanel2.Controls.Add(Me.Label24)
        Me.EFocusPanel2.Icon = Nothing
        Me.EFocusPanel2.Image = Nothing
        Me.EFocusPanel2.IsTransparent = False
        Me.EFocusPanel2.LineColor = System.Drawing.SystemColors.Highlight
        Me.EFocusPanel2.Location = New System.Drawing.Point(673, 9)
        Me.EFocusPanel2.Name = "EFocusPanel2"
        Me.EFocusPanel2.Padding = New System.Windows.Forms.Padding(4, 22, 4, 4)
        Me.EFocusPanel2.Size = New System.Drawing.Size(325, 230)
        Me.EFocusPanel2.TabIndex = 14
        Me.EFocusPanel2.Text = "Informações de IPI"
        '
        'c11
        '
        Me.c11.BackColor = System.Drawing.Color.Khaki
        Me.c11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c11.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c11.ForeColor = System.Drawing.Color.Maroon
        Me.c11.Location = New System.Drawing.Point(227, 115)
        Me.c11.Name = "c11"
        Me.c11.Size = New System.Drawing.Size(86, 23)
        Me.c11.TabIndex = 24
        Me.c11.Text = "00,00"
        Me.c11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c10
        '
        Me.c10.BackColor = System.Drawing.Color.Khaki
        Me.c10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c10.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c10.ForeColor = System.Drawing.Color.Maroon
        Me.c10.Location = New System.Drawing.Point(227, 86)
        Me.c10.Name = "c10"
        Me.c10.Size = New System.Drawing.Size(86, 23)
        Me.c10.TabIndex = 23
        Me.c10.Text = "00,00"
        Me.c10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c9
        '
        Me.c9.BackColor = System.Drawing.Color.Khaki
        Me.c9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c9.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c9.ForeColor = System.Drawing.Color.Maroon
        Me.c9.Location = New System.Drawing.Point(227, 54)
        Me.c9.Name = "c9"
        Me.c9.Size = New System.Drawing.Size(86, 23)
        Me.c9.TabIndex = 22
        Me.c9.Text = "00,00"
        Me.c9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c8
        '
        Me.c8.BackColor = System.Drawing.Color.Khaki
        Me.c8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c8.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c8.ForeColor = System.Drawing.Color.Maroon
        Me.c8.Location = New System.Drawing.Point(227, 26)
        Me.c8.Name = "c8"
        Me.c8.Size = New System.Drawing.Size(86, 23)
        Me.c8.TabIndex = 21
        Me.c8.Text = "00,00"
        Me.c8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ValorOutrosIpi
        '
        Me.ValorOutrosIpi.AceitaColarTexto = True
        Me.ValorOutrosIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorOutrosIpi.CasasDecimais = 2
        Me.ValorOutrosIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorOutrosIpi.CPObrigatorio = False
        Me.ValorOutrosIpi.CPObrigatorioMsg = Nothing
        Me.ValorOutrosIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorOutrosIpi.FlatBorder = False
        Me.ValorOutrosIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorOutrosIpi.FocusColor = System.Drawing.Color.Empty
        Me.ValorOutrosIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorOutrosIpi.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorOutrosIpi.HighlightBorderOnEnter = False
        Me.ValorOutrosIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorOutrosIpi.Location = New System.Drawing.Point(118, 115)
        Me.ValorOutrosIpi.MaxLength = 10
        Me.ValorOutrosIpi.Name = "ValorOutrosIpi"
        Me.ValorOutrosIpi.PreencherZeroEsqueda = False
        Me.ValorOutrosIpi.RegraValidação = Nothing
        Me.ValorOutrosIpi.RegraValidaçãoMensagem = Nothing
        Me.ValorOutrosIpi.Size = New System.Drawing.Size(103, 23)
        Me.ValorOutrosIpi.TabIndex = 9
        Me.ValorOutrosIpi.Text = "R$ 0,00"
        Me.ValorOutrosIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorOutrosIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorOutrosIpi.ValorPadrao = Nothing
        '
        'IsentoIpi
        '
        Me.IsentoIpi.AceitaColarTexto = True
        Me.IsentoIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IsentoIpi.CasasDecimais = 2
        Me.IsentoIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IsentoIpi.CPObrigatorio = False
        Me.IsentoIpi.CPObrigatorioMsg = Nothing
        Me.IsentoIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IsentoIpi.FlatBorder = False
        Me.IsentoIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IsentoIpi.FocusColor = System.Drawing.Color.Empty
        Me.IsentoIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.IsentoIpi.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsentoIpi.HighlightBorderOnEnter = False
        Me.IsentoIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IsentoIpi.Location = New System.Drawing.Point(118, 86)
        Me.IsentoIpi.MaxLength = 10
        Me.IsentoIpi.Name = "IsentoIpi"
        Me.IsentoIpi.PreencherZeroEsqueda = False
        Me.IsentoIpi.RegraValidação = Nothing
        Me.IsentoIpi.RegraValidaçãoMensagem = Nothing
        Me.IsentoIpi.Size = New System.Drawing.Size(103, 23)
        Me.IsentoIpi.TabIndex = 7
        Me.IsentoIpi.Text = "R$ 0,00"
        Me.IsentoIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IsentoIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.IsentoIpi.ValorPadrao = Nothing
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(10, 89)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 20)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Valor Isento IPI"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(10, 118)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(102, 20)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Valor Outos IPI"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BaseCalcIpi
        '
        Me.BaseCalcIpi.AceitaColarTexto = True
        Me.BaseCalcIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BaseCalcIpi.CasasDecimais = 2
        Me.BaseCalcIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BaseCalcIpi.CPObrigatorio = False
        Me.BaseCalcIpi.CPObrigatorioMsg = Nothing
        Me.BaseCalcIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BaseCalcIpi.FlatBorder = False
        Me.BaseCalcIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BaseCalcIpi.FocusColor = System.Drawing.Color.Empty
        Me.BaseCalcIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.BaseCalcIpi.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaseCalcIpi.HighlightBorderOnEnter = False
        Me.BaseCalcIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BaseCalcIpi.Location = New System.Drawing.Point(118, 25)
        Me.BaseCalcIpi.MaxLength = 10
        Me.BaseCalcIpi.Name = "BaseCalcIpi"
        Me.BaseCalcIpi.PreencherZeroEsqueda = False
        Me.BaseCalcIpi.RegraValidação = Nothing
        Me.BaseCalcIpi.RegraValidaçãoMensagem = Nothing
        Me.BaseCalcIpi.Size = New System.Drawing.Size(103, 23)
        Me.BaseCalcIpi.TabIndex = 1
        Me.BaseCalcIpi.Text = "R$ 0,00"
        Me.BaseCalcIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BaseCalcIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.BaseCalcIpi.ValorPadrao = Nothing
        '
        'VlrIpi
        '
        Me.VlrIpi.AceitaColarTexto = True
        Me.VlrIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.VlrIpi.CasasDecimais = 2
        Me.VlrIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VlrIpi.CPObrigatorio = False
        Me.VlrIpi.CPObrigatorioMsg = Nothing
        Me.VlrIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VlrIpi.FlatBorder = False
        Me.VlrIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.VlrIpi.FocusColor = System.Drawing.Color.Empty
        Me.VlrIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.VlrIpi.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VlrIpi.HighlightBorderOnEnter = False
        Me.VlrIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.VlrIpi.Location = New System.Drawing.Point(118, 54)
        Me.VlrIpi.MaxLength = 10
        Me.VlrIpi.Name = "VlrIpi"
        Me.VlrIpi.PreencherZeroEsqueda = False
        Me.VlrIpi.RegraValidação = Nothing
        Me.VlrIpi.RegraValidaçãoMensagem = Nothing
        Me.VlrIpi.Size = New System.Drawing.Size(103, 23)
        Me.VlrIpi.TabIndex = 5
        Me.VlrIpi.Text = "R$ 0,00"
        Me.VlrIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.VlrIpi.ValorPadrao = Nothing
        '
        'EFocusPanel1
        '
        Me.EFocusPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EFocusPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EFocusPanel1.Controls.Add(Me.c7)
        Me.EFocusPanel1.Controls.Add(Me.c6)
        Me.EFocusPanel1.Controls.Add(Me.c5)
        Me.EFocusPanel1.Controls.Add(Me.c4)
        Me.EFocusPanel1.Controls.Add(Me.ValorOutrosIcms)
        Me.EFocusPanel1.Controls.Add(Me.IsentoIcms)
        Me.EFocusPanel1.Controls.Add(Me.Label22)
        Me.EFocusPanel1.Controls.Add(Me.Label21)
        Me.EFocusPanel1.Controls.Add(Me.Label25)
        Me.EFocusPanel1.Controls.Add(Me.BaseCalcIcms)
        Me.EFocusPanel1.Controls.Add(Me.Icms)
        Me.EFocusPanel1.Controls.Add(Me.Label15)
        Me.EFocusPanel1.Controls.Add(Me.ValorIcms)
        Me.EFocusPanel1.Controls.Add(Me.Label17)
        Me.EFocusPanel1.Icon = Nothing
        Me.EFocusPanel1.Image = Nothing
        Me.EFocusPanel1.IsTransparent = False
        Me.EFocusPanel1.LineColor = System.Drawing.SystemColors.Highlight
        Me.EFocusPanel1.Location = New System.Drawing.Point(342, 9)
        Me.EFocusPanel1.Name = "EFocusPanel1"
        Me.EFocusPanel1.Padding = New System.Windows.Forms.Padding(4, 22, 4, 4)
        Me.EFocusPanel1.Size = New System.Drawing.Size(325, 230)
        Me.EFocusPanel1.TabIndex = 13
        Me.EFocusPanel1.Text = "Informações de ICMS"
        '
        'c7
        '
        Me.c7.BackColor = System.Drawing.Color.Khaki
        Me.c7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c7.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c7.ForeColor = System.Drawing.Color.Maroon
        Me.c7.Location = New System.Drawing.Point(233, 147)
        Me.c7.Name = "c7"
        Me.c7.Size = New System.Drawing.Size(86, 23)
        Me.c7.TabIndex = 20
        Me.c7.Text = "00,00"
        Me.c7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c6
        '
        Me.c6.BackColor = System.Drawing.Color.Khaki
        Me.c6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c6.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c6.ForeColor = System.Drawing.Color.Maroon
        Me.c6.Location = New System.Drawing.Point(233, 118)
        Me.c6.Name = "c6"
        Me.c6.Size = New System.Drawing.Size(86, 23)
        Me.c6.TabIndex = 19
        Me.c6.Text = "00,00"
        Me.c6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c5
        '
        Me.c5.BackColor = System.Drawing.Color.Khaki
        Me.c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c5.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c5.ForeColor = System.Drawing.Color.Maroon
        Me.c5.Location = New System.Drawing.Point(233, 85)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(86, 23)
        Me.c5.TabIndex = 18
        Me.c5.Text = "00,00"
        Me.c5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c4
        '
        Me.c4.BackColor = System.Drawing.Color.Khaki
        Me.c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c4.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c4.ForeColor = System.Drawing.Color.Maroon
        Me.c4.Location = New System.Drawing.Point(233, 26)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(86, 23)
        Me.c4.TabIndex = 17
        Me.c4.Text = "00,00"
        Me.c4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ValorOutrosIcms
        '
        Me.ValorOutrosIcms.AceitaColarTexto = True
        Me.ValorOutrosIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorOutrosIcms.CasasDecimais = 2
        Me.ValorOutrosIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorOutrosIcms.CPObrigatorio = False
        Me.ValorOutrosIcms.CPObrigatorioMsg = Nothing
        Me.ValorOutrosIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorOutrosIcms.FlatBorder = False
        Me.ValorOutrosIcms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorOutrosIcms.FocusColor = System.Drawing.Color.Empty
        Me.ValorOutrosIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorOutrosIcms.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorOutrosIcms.HighlightBorderOnEnter = False
        Me.ValorOutrosIcms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorOutrosIcms.Location = New System.Drawing.Point(120, 147)
        Me.ValorOutrosIcms.MaxLength = 10
        Me.ValorOutrosIcms.Name = "ValorOutrosIcms"
        Me.ValorOutrosIcms.PreencherZeroEsqueda = False
        Me.ValorOutrosIcms.RegraValidação = Nothing
        Me.ValorOutrosIcms.RegraValidaçãoMensagem = Nothing
        Me.ValorOutrosIcms.Size = New System.Drawing.Size(107, 23)
        Me.ValorOutrosIcms.TabIndex = 9
        Me.ValorOutrosIcms.Text = "R$ 0,00"
        Me.ValorOutrosIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorOutrosIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorOutrosIcms.ValorPadrao = Nothing
        '
        'IsentoIcms
        '
        Me.IsentoIcms.AceitaColarTexto = True
        Me.IsentoIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IsentoIcms.CasasDecimais = 2
        Me.IsentoIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IsentoIcms.CPObrigatorio = False
        Me.IsentoIcms.CPObrigatorioMsg = Nothing
        Me.IsentoIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IsentoIcms.FlatBorder = False
        Me.IsentoIcms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IsentoIcms.FocusColor = System.Drawing.Color.Empty
        Me.IsentoIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.IsentoIcms.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsentoIcms.HighlightBorderOnEnter = False
        Me.IsentoIcms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IsentoIcms.Location = New System.Drawing.Point(120, 118)
        Me.IsentoIcms.MaxLength = 10
        Me.IsentoIcms.Name = "IsentoIcms"
        Me.IsentoIcms.PreencherZeroEsqueda = False
        Me.IsentoIcms.RegraValidação = Nothing
        Me.IsentoIcms.RegraValidaçãoMensagem = Nothing
        Me.IsentoIcms.Size = New System.Drawing.Size(107, 23)
        Me.IsentoIcms.TabIndex = 7
        Me.IsentoIcms.Text = "R$ 0,00"
        Me.IsentoIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IsentoIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.IsentoIcms.ValorPadrao = Nothing
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 150)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 20)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Valor Outros ICMS"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(12, 54)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 19)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Icms %"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 121)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(102, 20)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Valor Isento ICMS"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BaseCalcIcms
        '
        Me.BaseCalcIcms.AceitaColarTexto = True
        Me.BaseCalcIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BaseCalcIcms.CasasDecimais = 2
        Me.BaseCalcIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BaseCalcIcms.CPObrigatorio = False
        Me.BaseCalcIcms.CPObrigatorioMsg = Nothing
        Me.BaseCalcIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BaseCalcIcms.FlatBorder = False
        Me.BaseCalcIcms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcms.FocusColor = System.Drawing.Color.Empty
        Me.BaseCalcIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.BaseCalcIcms.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaseCalcIcms.HighlightBorderOnEnter = False
        Me.BaseCalcIcms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcms.Location = New System.Drawing.Point(120, 25)
        Me.BaseCalcIcms.MaxLength = 10
        Me.BaseCalcIcms.Name = "BaseCalcIcms"
        Me.BaseCalcIcms.PreencherZeroEsqueda = False
        Me.BaseCalcIcms.RegraValidação = Nothing
        Me.BaseCalcIcms.RegraValidaçãoMensagem = Nothing
        Me.BaseCalcIcms.Size = New System.Drawing.Size(107, 23)
        Me.BaseCalcIcms.TabIndex = 1
        Me.BaseCalcIcms.Text = "R$ 0,00"
        Me.BaseCalcIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BaseCalcIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.BaseCalcIcms.ValorPadrao = Nothing
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
        Me.Icms.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icms.HighlightBorderOnEnter = False
        Me.Icms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Icms.Location = New System.Drawing.Point(120, 54)
        Me.Icms.MaxLength = 15
        Me.Icms.Name = "Icms"
        Me.Icms.PreencherZeroEsqueda = False
        Me.Icms.RegraValidação = Nothing
        Me.Icms.RegraValidaçãoMensagem = Nothing
        Me.Icms.Size = New System.Drawing.Size(107, 23)
        Me.Icms.TabIndex = 3
        Me.Icms.Text = "0,00"
        Me.Icms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Icms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Icms.ValorPadrao = Nothing
        '
        'ValorIcms
        '
        Me.ValorIcms.AceitaColarTexto = True
        Me.ValorIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIcms.CasasDecimais = 2
        Me.ValorIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorIcms.CPObrigatorio = False
        Me.ValorIcms.CPObrigatorioMsg = Nothing
        Me.ValorIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIcms.FlatBorder = False
        Me.ValorIcms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIcms.FocusColor = System.Drawing.Color.Empty
        Me.ValorIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIcms.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorIcms.HighlightBorderOnEnter = False
        Me.ValorIcms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIcms.Location = New System.Drawing.Point(120, 86)
        Me.ValorIcms.MaxLength = 10
        Me.ValorIcms.Name = "ValorIcms"
        Me.ValorIcms.PreencherZeroEsqueda = False
        Me.ValorIcms.RegraValidação = Nothing
        Me.ValorIcms.RegraValidaçãoMensagem = Nothing
        Me.ValorIcms.Size = New System.Drawing.Size(107, 23)
        Me.ValorIcms.TabIndex = 5
        Me.ValorIcms.Text = "R$ 0,00"
        Me.ValorIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorIcms.ValorPadrao = Nothing
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Rodapé  NF [F8]"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.ListaPagar)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(999, 247)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 0
        Me.TabControlPanel3.TabItem = Me.TabItem2
        '
        'ListaPagar
        '
        Me.ListaPagar.AllowUserToAddRows = False
        Me.ListaPagar.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        Me.ListaPagar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListaPagar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ListaPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaPagar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.ValorDocumento, Me.Vencimento, Me.cPagamento, Me.cId})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaPagar.DefaultCellStyle = DataGridViewCellStyle4
        Me.ListaPagar.EnableHeadersVisualStyles = False
        Me.ListaPagar.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaPagar.Location = New System.Drawing.Point(8, 4)
        Me.ListaPagar.Name = "ListaPagar"
        Me.ListaPagar.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListaPagar.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ListaPagar.RowHeadersWidth = 20
        Me.ListaPagar.SelectAllSignVisible = False
        Me.ListaPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaPagar.Size = New System.Drawing.Size(983, 235)
        Me.ListaPagar.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Documento"
        Me.Column5.HeaderText = "Documento"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "NotaFiscal"
        Me.Column6.HeaderText = "Nota Fiscal"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 90
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Fornecedor"
        Me.Column7.HeaderText = "Fornecedor"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 290
        '
        'ValorDocumento
        '
        Me.ValorDocumento.DataPropertyName = "ValorDocumento"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ValorDocumento.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValorDocumento.HeaderText = "Valor Doc"
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.ReadOnly = True
        Me.ValorDocumento.Width = 90
        '
        'Vencimento
        '
        Me.Vencimento.DataPropertyName = "Vencimento"
        Me.Vencimento.HeaderText = "Vencimento"
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.ReadOnly = True
        Me.Vencimento.Width = 90
        '
        'cPagamento
        '
        Me.cPagamento.DataPropertyName = "Pagamento"
        Me.cPagamento.HeaderText = "Pagamento"
        Me.cPagamento.Name = "cPagamento"
        Me.cPagamento.ReadOnly = True
        Me.cPagamento.Width = 90
        '
        'cId
        '
        Me.cId.DataPropertyName = "Id"
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel3
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Parcelamento do Documento [F10]"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.Lista)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(999, 247)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.DevolucaoTab
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumPurple
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Lista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle9
        Me.Lista.EnableHeadersVisualStyles = False
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(8, 4)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Lista.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(983, 235)
        Me.Lista.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CompraInterno"
        Me.Column1.HeaderText = "Cod. Interno"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NotaFiscal"
        Me.Column2.HeaderText = "NF/Doc"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "RazãoSocial"
        Me.Column3.HeaderText = "Fornecedor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 400
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ValorCompra"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column4.HeaderText = "Valor Devolução"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 130
        '
        'DevolucaoTab
        '
        Me.DevolucaoTab.AttachedControl = Me.TabControlPanel2
        Me.DevolucaoTab.Name = "DevolucaoTab"
        Me.DevolucaoTab.Text = "NF/Doc Devolvidos [F9]"
        Me.DevolucaoTab.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identificação"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Serie
        '
        Me.Serie.AceitaColarTexto = True
        Me.Serie.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Serie.CasasDecimais = 0
        Me.Serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Serie.CPObrigatorio = False
        Me.Serie.CPObrigatorioMsg = Nothing
        Me.Serie.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Serie.FlatBorder = False
        Me.Serie.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Serie.FocusColor = System.Drawing.Color.Empty
        Me.Serie.FocusColorEnd = System.Drawing.Color.Empty
        Me.Serie.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Serie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Serie.HighlightBorderOnEnter = False
        Me.Serie.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Serie.Location = New System.Drawing.Point(107, 93)
        Me.Serie.MaxLength = 3
        Me.Serie.Name = "Serie"
        Me.Serie.PreencherZeroEsqueda = False
        Me.Serie.RegraValidação = Nothing
        Me.Serie.RegraValidaçãoMensagem = Nothing
        Me.Serie.Size = New System.Drawing.Size(54, 23)
        Me.Serie.TabIndex = 8
        Me.Serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Serie, "Lançar conforme nota de entrada")
        Me.Serie.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Serie.ValorPadrao = Nothing
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(20, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(81, 20)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "Série"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompraInterno
        '
        Me.CompraInterno.AceitaColarTexto = True
        Me.CompraInterno.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CompraInterno.CasasDecimais = 0
        Me.CompraInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompraInterno.CPObrigatorio = False
        Me.CompraInterno.CPObrigatorioMsg = Nothing
        Me.CompraInterno.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.CompraInterno.FlatBorder = False
        Me.CompraInterno.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CompraInterno.FocusColor = System.Drawing.Color.Empty
        Me.CompraInterno.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompraInterno.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompraInterno.HighlightBorderOnEnter = False
        Me.CompraInterno.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CompraInterno.Location = New System.Drawing.Point(107, 64)
        Me.CompraInterno.Name = "CompraInterno"
        Me.CompraInterno.PreencherZeroEsqueda = False
        Me.CompraInterno.RegraValidação = Nothing
        Me.CompraInterno.RegraValidaçãoMensagem = Nothing
        Me.CompraInterno.Size = New System.Drawing.Size(62, 23)
        Me.CompraInterno.TabIndex = 2
        Me.CompraInterno.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CompraInterno.ValorPadrao = Nothing
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Dica:"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1020, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Compra"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota Fiscal de Entrada - T124"
        Me.MenuListaDeItem.ResumeLayout(False)
        Me.MenuDataLancamento.ResumeLayout(False)
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.PainelDev.ResumeLayout(False)
        Me.PainelDev.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.TabGeral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeral.ResumeLayout(False)
        Me.Itens.ResumeLayout(False)
        Me.Itens.PerformLayout()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.EFocusPanel3.ResumeLayout(False)
        Me.EFocusPanel3.PerformLayout()
        Me.EFocusPanel2.ResumeLayout(False)
        Me.EFocusPanel2.PerformLayout()
        Me.EFocusPanel1.ResumeLayout(False)
        Me.EFocusPanel1.PerformLayout()
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.ListaPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CompraInterno As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataCompra As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataEntrada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Obs As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoFornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents RazaoSocial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents VlrIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BaseCalcIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ValorIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BaseCalcIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorCompra As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Confirmado As System.Windows.Forms.CheckBox
    Friend WithEvents Inativo As System.Windows.Forms.CheckBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TotalProdutos As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColProduto As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColQtd As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalItensLançado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents ColSeq As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TotalItensIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConfirmarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuDataLancamento As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TravarOCampoDataDeLançamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestravarOCampoDataDeLançamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TabGeral As DevComponents.DotNetBar.TabControl
    Friend WithEvents Itens As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItens As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents ValorFrete As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TotalPis As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents TotalCofins As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents ColVlrUnit As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTipo As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BaseCalcIcmsST As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ValorIcmsST As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NotaFiscal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents AdicionarItens As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ConfImg As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuListaDeItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirOItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ValorOutros As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TpEntrada As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents NFdevMae As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NFdevMaeLabel As System.Windows.Forms.Label
    Friend WithEvents PainelDev As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents IdNFdevMae As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindNFDevolucao As System.Windows.Forms.Label
    Friend WithEvents NFdevMaeValor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ImportarItensParaDevoluçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents DevolucaoTab As DevComponents.DotNetBar.TabItem
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btFindValor As System.Windows.Forms.Label
    Friend WithEvents ContaCRDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ContaDespesa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ListaPagar As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btFornecedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vencimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPagamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btEditarContas As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFindFornecedor As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Public WithEvents Find6 As System.Windows.Forms.Label
    Public WithEvents DescConta6 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find5 As System.Windows.Forms.Label
    Public WithEvents DescConta5 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find4 As System.Windows.Forms.Label
    Public WithEvents DescConta4 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find3 As System.Windows.Forms.Label
    Public WithEvents DescConta3 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find2 As System.Windows.Forms.Label
    Public WithEvents DescConta2 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Find1 As System.Windows.Forms.Label
    Public WithEvents Conta6 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr6 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta5 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr5 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta4 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr4 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta3 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr3 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta2 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Vlr2 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Conta1 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents DescConta1 As TexBoxFocusNet.TextBoxFocusNet
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Vlr1 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents EFocusPanel1 As EFocusPanel.EFocusPanel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Icms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorOutrosIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IsentoIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents EFocusPanel2 As EFocusPanel.EFocusPanel
    Friend WithEvents ValorOutrosIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IsentoIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents ValorIssqnRetido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EFocusPanel3 As EFocusPanel.EFocusPanel
    Friend WithEvents Modelo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Serie As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btModelos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents FormaPagamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents CFOP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents btFormaPgto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SubSerie As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents EspecieDocumento As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents cMensagemErro As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ChaveNFe As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btImpXML As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents ValorDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CRTfornecedor As System.Windows.Forms.Label
    Friend WithEvents c3 As System.Windows.Forms.Label
    Friend WithEvents c2 As System.Windows.Forms.Label
    Friend WithEvents c1 As System.Windows.Forms.Label
    Friend WithEvents c11 As System.Windows.Forms.Label
    Friend WithEvents c10 As System.Windows.Forms.Label
    Friend WithEvents c9 As System.Windows.Forms.Label
    Friend WithEvents c8 As System.Windows.Forms.Label
    Friend WithEvents c7 As System.Windows.Forms.Label
    Friend WithEvents c6 As System.Windows.Forms.Label
    Friend WithEvents c5 As System.Windows.Forms.Label
    Friend WithEvents c4 As System.Windows.Forms.Label
    Friend WithEvents ExcluirTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColCfopEnt As System.Windows.Forms.ColumnHeader
End Class
