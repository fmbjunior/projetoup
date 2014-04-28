<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caixa))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataCaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CaixaCod = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btCaixasAberto = New DevComponents.DotNetBar.ButtonX()
        Me.btAtivarCaixa = New DevComponents.DotNetBar.ButtonX()
        Me.btTransferencia = New DevComponents.DotNetBar.ButtonX()
        Me.btRepasseCheque = New System.Windows.Forms.Label()
        Me.ContextMenuCheque = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TodosOsChequeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosDoDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btChequeDia = New System.Windows.Forms.Label()
        Me.ListaCheque = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.xCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xTitular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xEntreguePro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xVencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Repassar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DisplayAberto = New System.Windows.Forms.Label()
        Me.btImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btFecharCX = New DevComponents.DotNetBar.ButtonX()
        Me.btLancamentos = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DisplayFechado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaldoAtual = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaldoAnterior = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ListaImagem = New System.Windows.Forms.ImageList(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContaDespesaReceita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContaBalanceteDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fundo.SuspendLayout()
        Me.ContextMenuCheque.SuspendLayout()
        CType(Me.ListaCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Data do Caixa"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataCaixa
        '
        Me.DataCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataCaixa.AceitaColarTexto = True
        Me.DataCaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataCaixa.CasasDecimais = 0
        Me.DataCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataCaixa.CPObrigatorio = False
        Me.DataCaixa.CPObrigatorioMsg = Nothing
        Me.DataCaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataCaixa.FlatBorder = False
        Me.DataCaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataCaixa.FocusColor = System.Drawing.Color.Empty
        Me.DataCaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataCaixa.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataCaixa.HighlightBorderOnEnter = False
        Me.DataCaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataCaixa.Location = New System.Drawing.Point(100, 15)
        Me.DataCaixa.MaxLength = 10
        Me.DataCaixa.Name = "DataCaixa"
        Me.DataCaixa.PreencherZeroEsqueda = False
        Me.DataCaixa.RegraValidação = Nothing
        Me.DataCaixa.RegraValidaçãoMensagem = Nothing
        Me.DataCaixa.Size = New System.Drawing.Size(100, 24)
        Me.DataCaixa.TabIndex = 1
        Me.DataCaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataCaixa.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Código Caixa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CaixaCod
        '
        Me.CaixaCod.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.CaixaCod.AceitaColarTexto = True
        Me.CaixaCod.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CaixaCod.CasasDecimais = 0
        Me.CaixaCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CaixaCod.CPObrigatorio = False
        Me.CaixaCod.CPObrigatorioMsg = Nothing
        Me.CaixaCod.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CaixaCod.FlatBorder = False
        Me.CaixaCod.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CaixaCod.FocusColor = System.Drawing.Color.Empty
        Me.CaixaCod.FocusColorEnd = System.Drawing.Color.Empty
        Me.CaixaCod.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaCod.HighlightBorderOnEnter = False
        Me.CaixaCod.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CaixaCod.Location = New System.Drawing.Point(302, 14)
        Me.CaixaCod.MaxLength = 4
        Me.CaixaCod.Name = "CaixaCod"
        Me.CaixaCod.PreencherZeroEsqueda = True
        Me.CaixaCod.RegraValidação = Nothing
        Me.CaixaCod.RegraValidaçãoMensagem = Nothing
        Me.CaixaCod.Size = New System.Drawing.Size(57, 24)
        Me.CaixaCod.TabIndex = 22
        Me.CaixaCod.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CaixaCod.ValorPadrao = Nothing
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Image = CType(resources.GetObject("btAtualizar.Image"), System.Drawing.Image)
        Me.btAtualizar.Location = New System.Drawing.Point(365, 14)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(37, 24)
        Me.btAtualizar.TabIndex = 23
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.ButtonX1)
        Me.Fundo.Controls.Add(Me.btCaixasAberto)
        Me.Fundo.Controls.Add(Me.btAtivarCaixa)
        Me.Fundo.Controls.Add(Me.btTransferencia)
        Me.Fundo.Controls.Add(Me.btRepasseCheque)
        Me.Fundo.Controls.Add(Me.btChequeDia)
        Me.Fundo.Controls.Add(Me.ListaCheque)
        Me.Fundo.Controls.Add(Me.DisplayAberto)
        Me.Fundo.Controls.Add(Me.btImprimir)
        Me.Fundo.Controls.Add(Me.btFecharCX)
        Me.Fundo.Controls.Add(Me.btLancamentos)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Lista)
        Me.Fundo.Controls.Add(Me.DisplayFechado)
        Me.Fundo.Controls.Add(Me.DataCaixa)
        Me.Fundo.Controls.Add(Me.btAtualizar)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.SaldoAtual)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.CaixaCod)
        Me.Fundo.Controls.Add(Me.SaldoAnterior)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(984, 696)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 24
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(293, 664)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(80, 26)
        Me.ButtonX1.TabIndex = 36
        Me.ButtonX1.Text = "Criar Novo Dia"
        '
        'btCaixasAberto
        '
        Me.btCaixasAberto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCaixasAberto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCaixasAberto.Location = New System.Drawing.Point(379, 664)
        Me.btCaixasAberto.Name = "btCaixasAberto"
        Me.btCaixasAberto.Size = New System.Drawing.Size(95, 26)
        Me.btCaixasAberto.TabIndex = 35
        Me.btCaixasAberto.Text = "Caixas Abertos"
        '
        'btAtivarCaixa
        '
        Me.btAtivarCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtivarCaixa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtivarCaixa.Location = New System.Drawing.Point(207, 664)
        Me.btAtivarCaixa.Name = "btAtivarCaixa"
        Me.btAtivarCaixa.Size = New System.Drawing.Size(80, 26)
        Me.btAtivarCaixa.TabIndex = 34
        Me.btAtivarCaixa.Text = "Ativar Caixa"
        '
        'btTransferencia
        '
        Me.btTransferencia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTransferencia.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btTransferencia.Location = New System.Drawing.Point(480, 664)
        Me.btTransferencia.Name = "btTransferencia"
        Me.btTransferencia.Size = New System.Drawing.Size(80, 26)
        Me.btTransferencia.TabIndex = 33
        Me.btTransferencia.Text = "Transferência"
        '
        'btRepasseCheque
        '
        Me.btRepasseCheque.ContextMenuStrip = Me.ContextMenuCheque
        Me.btRepasseCheque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRepasseCheque.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRepasseCheque.Image = CType(resources.GetObject("btRepasseCheque.Image"), System.Drawing.Image)
        Me.btRepasseCheque.Location = New System.Drawing.Point(47, 463)
        Me.btRepasseCheque.Name = "btRepasseCheque"
        Me.btRepasseCheque.Size = New System.Drawing.Size(30, 30)
        Me.btRepasseCheque.TabIndex = 32
        Me.btRepasseCheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenuCheque
        '
        Me.ContextMenuCheque.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuCheque.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosOsChequeToolStripMenuItem, Me.TodosDoDiaToolStripMenuItem})
        Me.ContextMenuCheque.Name = "ContextMenuCheque"
        Me.ContextMenuCheque.Size = New System.Drawing.Size(205, 48)
        '
        'TodosOsChequeToolStripMenuItem
        '
        Me.TodosOsChequeToolStripMenuItem.Name = "TodosOsChequeToolStripMenuItem"
        Me.TodosOsChequeToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.TodosOsChequeToolStripMenuItem.Text = "Todos os Cheque"
        '
        'TodosDoDiaToolStripMenuItem
        '
        Me.TodosDoDiaToolStripMenuItem.Name = "TodosDoDiaToolStripMenuItem"
        Me.TodosDoDiaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.TodosDoDiaToolStripMenuItem.Text = "Todos os Cheque do Dia"
        '
        'btChequeDia
        '
        Me.btChequeDia.ContextMenuStrip = Me.ContextMenuCheque
        Me.btChequeDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btChequeDia.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btChequeDia.Image = CType(resources.GetObject("btChequeDia.Image"), System.Drawing.Image)
        Me.btChequeDia.Location = New System.Drawing.Point(11, 463)
        Me.btChequeDia.Name = "btChequeDia"
        Me.btChequeDia.Size = New System.Drawing.Size(30, 30)
        Me.btChequeDia.TabIndex = 31
        Me.btChequeDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListaCheque
        '
        Me.ListaCheque.AllowUserToAddRows = False
        Me.ListaCheque.AllowUserToDeleteRows = False
        Me.ListaCheque.AllowUserToResizeColumns = False
        Me.ListaCheque.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.ListaCheque.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaCheque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.xCheque, Me.xCC, Me.xCliente, Me.xTitular, Me.xEntreguePro, Me.xValor, Me.xVencimento, Me.Repassar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaCheque.DefaultCellStyle = DataGridViewCellStyle3
        Me.ListaCheque.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaCheque.Location = New System.Drawing.Point(8, 493)
        Me.ListaCheque.Name = "ListaCheque"
        Me.ListaCheque.ReadOnly = True
        Me.ListaCheque.RowHeadersVisible = False
        Me.ListaCheque.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaCheque.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListaCheque.SelectAllSignVisible = False
        Me.ListaCheque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaCheque.Size = New System.Drawing.Size(964, 165)
        Me.ListaCheque.TabIndex = 30
        '
        'xCheque
        '
        Me.xCheque.DataPropertyName = "Cheque"
        Me.xCheque.HeaderText = "Cheque"
        Me.xCheque.Name = "xCheque"
        Me.xCheque.ReadOnly = True
        Me.xCheque.Width = 75
        '
        'xCC
        '
        Me.xCC.DataPropertyName = "CC"
        Me.xCC.HeaderText = "CC"
        Me.xCC.Name = "xCC"
        Me.xCC.ReadOnly = True
        Me.xCC.Width = 70
        '
        'xCliente
        '
        Me.xCliente.DataPropertyName = "Nome"
        Me.xCliente.HeaderText = "Cliente"
        Me.xCliente.Name = "xCliente"
        Me.xCliente.ReadOnly = True
        Me.xCliente.Width = 160
        '
        'xTitular
        '
        Me.xTitular.DataPropertyName = "Titular"
        Me.xTitular.HeaderText = "Titular"
        Me.xTitular.Name = "xTitular"
        Me.xTitular.ReadOnly = True
        Me.xTitular.Width = 160
        '
        'xEntreguePro
        '
        Me.xEntreguePro.DataPropertyName = "EntreguePor"
        Me.xEntreguePro.HeaderText = "Entregue"
        Me.xEntreguePro.Name = "xEntreguePro"
        Me.xEntreguePro.ReadOnly = True
        Me.xEntreguePro.Width = 160
        '
        'xValor
        '
        Me.xValor.DataPropertyName = "ValorCh"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.xValor.DefaultCellStyle = DataGridViewCellStyle2
        Me.xValor.HeaderText = "Valor"
        Me.xValor.Name = "xValor"
        Me.xValor.ReadOnly = True
        Me.xValor.Width = 90
        '
        'xVencimento
        '
        Me.xVencimento.DataPropertyName = "Vencimento"
        Me.xVencimento.HeaderText = "Vencimento"
        Me.xVencimento.Name = "xVencimento"
        Me.xVencimento.ReadOnly = True
        Me.xVencimento.Width = 80
        '
        'Repassar
        '
        Me.Repassar.HeaderText = "Repassar"
        Me.Repassar.Name = "Repassar"
        Me.Repassar.ReadOnly = True
        Me.Repassar.Width = 55
        '
        'DisplayAberto
        '
        Me.DisplayAberto.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayAberto.Image = CType(resources.GetObject("DisplayAberto.Image"), System.Drawing.Image)
        Me.DisplayAberto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DisplayAberto.Location = New System.Drawing.Point(513, 9)
        Me.DisplayAberto.Name = "DisplayAberto"
        Me.DisplayAberto.Size = New System.Drawing.Size(183, 35)
        Me.DisplayAberto.TabIndex = 29
        Me.DisplayAberto.Text = "Caixa Aberto"
        Me.DisplayAberto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DisplayAberto.Visible = False
        '
        'btImprimir
        '
        Me.btImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImprimir.Location = New System.Drawing.Point(738, 664)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(80, 26)
        Me.btImprimir.TabIndex = 28
        Me.btImprimir.Text = "Imprimir CX"
        '
        'btFecharCX
        '
        Me.btFecharCX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFecharCX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFecharCX.Location = New System.Drawing.Point(652, 664)
        Me.btFecharCX.Name = "btFecharCX"
        Me.btFecharCX.Size = New System.Drawing.Size(80, 26)
        Me.btFecharCX.TabIndex = 27
        Me.btFecharCX.Text = "Fechar CX"
        '
        'btLancamentos
        '
        Me.btLancamentos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLancamentos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLancamentos.Location = New System.Drawing.Point(566, 664)
        Me.btLancamentos.Name = "btLancamentos"
        Me.btLancamentos.Size = New System.Drawing.Size(80, 26)
        Me.btLancamentos.TabIndex = 26
        Me.btLancamentos.Text = "Lançamento"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(824, 664)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(61, 26)
        Me.btFechar.TabIndex = 25
        Me.btFechar.Text = "Fechar"
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        Me.Lista.AllowUserToResizeColumns = False
        Me.Lista.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Img, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column12, Me.Column7, Me.Column6, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.cContaDespesaReceita, Me.cContaBalanceteDesc})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle7
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(8, 53)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersVisible = False
        Me.Lista.RowHeadersWidth = 20
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(964, 390)
        Me.Lista.TabIndex = 24
        '
        'DisplayFechado
        '
        Me.DisplayFechado.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayFechado.Image = CType(resources.GetObject("DisplayFechado.Image"), System.Drawing.Image)
        Me.DisplayFechado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DisplayFechado.Location = New System.Drawing.Point(702, 9)
        Me.DisplayFechado.Name = "DisplayFechado"
        Me.DisplayFechado.Size = New System.Drawing.Size(183, 35)
        Me.DisplayFechado.TabIndex = 18
        Me.DisplayFechado.Text = "Caixa Fechado"
        Me.DisplayFechado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DisplayFechado.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(712, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total do Caixa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaldoAtual
        '
        Me.SaldoAtual.AceitaColarTexto = True
        Me.SaldoAtual.BackColor = System.Drawing.Color.White
        Me.SaldoAtual.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SaldoAtual.CasasDecimais = 2
        Me.SaldoAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SaldoAtual.CPObrigatorio = False
        Me.SaldoAtual.CPObrigatorioMsg = Nothing
        Me.SaldoAtual.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SaldoAtual.FlatBorder = False
        Me.SaldoAtual.FlatBorderColor = System.Drawing.Color.DimGray
        Me.SaldoAtual.FocusColor = System.Drawing.Color.Empty
        Me.SaldoAtual.FocusColorEnd = System.Drawing.Color.Empty
        Me.SaldoAtual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoAtual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaldoAtual.HighlightBorderOnEnter = False
        Me.SaldoAtual.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.SaldoAtual.Location = New System.Drawing.Point(837, 449)
        Me.SaldoAtual.MaxLength = 10
        Me.SaldoAtual.Name = "SaldoAtual"
        Me.SaldoAtual.PreencherZeroEsqueda = False
        Me.SaldoAtual.RegraValidação = Nothing
        Me.SaldoAtual.RegraValidaçãoMensagem = Nothing
        Me.SaldoAtual.Size = New System.Drawing.Size(135, 26)
        Me.SaldoAtual.TabIndex = 11
        Me.SaldoAtual.TabStop = False
        Me.SaldoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SaldoAtual.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SaldoAtual.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(434, 450)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Saldo Anterior"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaldoAnterior
        '
        Me.SaldoAnterior.AceitaColarTexto = True
        Me.SaldoAnterior.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SaldoAnterior.CasasDecimais = 2
        Me.SaldoAnterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SaldoAnterior.CPObrigatorio = False
        Me.SaldoAnterior.CPObrigatorioMsg = Nothing
        Me.SaldoAnterior.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SaldoAnterior.FlatBorder = False
        Me.SaldoAnterior.FlatBorderColor = System.Drawing.Color.DimGray
        Me.SaldoAnterior.FocusColor = System.Drawing.Color.Empty
        Me.SaldoAnterior.FocusColorEnd = System.Drawing.Color.Empty
        Me.SaldoAnterior.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoAnterior.ForeColor = System.Drawing.Color.Navy
        Me.SaldoAnterior.HighlightBorderOnEnter = False
        Me.SaldoAnterior.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.SaldoAnterior.Location = New System.Drawing.Point(559, 450)
        Me.SaldoAnterior.MaxLength = 10
        Me.SaldoAnterior.Name = "SaldoAnterior"
        Me.SaldoAnterior.PreencherZeroEsqueda = False
        Me.SaldoAnterior.RegraValidação = Nothing
        Me.SaldoAnterior.RegraValidaçãoMensagem = Nothing
        Me.SaldoAnterior.Size = New System.Drawing.Size(135, 26)
        Me.SaldoAnterior.TabIndex = 9
        Me.SaldoAnterior.TabStop = False
        Me.SaldoAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SaldoAnterior.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SaldoAnterior.ValorPadrao = Nothing
        '
        'ListaImagem
        '
        Me.ListaImagem.ImageStream = CType(resources.GetObject("ListaImagem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagem.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagem.Images.SetKeyName(0, "Caixa.png")
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Id"
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Img
        '
        Me.Img.HeaderText = ""
        Me.Img.Image = CType(resources.GetObject("Img.Image"), System.Drawing.Image)
        Me.Img.Name = "Img"
        Me.Img.ReadOnly = True
        Me.Img.Width = 25
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ContaCorrente"
        Me.Column2.HeaderText = "Caixa Cod"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "DataLancamento"
        Me.Column3.HeaderText = "Data Lanç"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 85
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Documento"
        Me.Column4.HeaderText = "Documento"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 90
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "DataDocumento"
        Me.Column5.HeaderText = "Data Documento"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "Favorecido"
        Me.Column12.HeaderText = "Favorecido"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 160
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Historico"
        Me.Column7.HeaderText = "Historico"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 350
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "ValorDocumento"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column6.HeaderText = "Valor Doc"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 110
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Empresa"
        Me.Column8.HeaderText = "Empresa"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "IdLancamento"
        Me.Column9.HeaderText = "Id Lancamento"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "IdProcura"
        Me.Column10.HeaderText = "Id Origem"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "Tipo"
        Me.Column11.HeaderText = "Tp"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'cContaDespesaReceita
        '
        Me.cContaDespesaReceita.DataPropertyName = "ContaBalancete"
        Me.cContaDespesaReceita.HeaderText = "D/R"
        Me.cContaDespesaReceita.Name = "cContaDespesaReceita"
        Me.cContaDespesaReceita.ReadOnly = True
        Me.cContaDespesaReceita.Width = 60
        '
        'cContaBalanceteDesc
        '
        Me.cContaBalanceteDesc.DataPropertyName = "DescContaGrupo3"
        Me.cContaBalanceteDesc.HeaderText = "Descrição da Conta"
        Me.cContaBalanceteDesc.Name = "cContaBalanceteDesc"
        Me.cContaBalanceteDesc.ReadOnly = True
        Me.cContaBalanceteDesc.Width = 200
        '
        'Caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 696)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Caixa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caixa - T078"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ContextMenuCheque.ResumeLayout(False)
        CType(Me.ListaCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataCaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CaixaCod As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DisplayFechado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaldoAtual As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SaldoAnterior As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btLancamentos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFecharCX As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DisplayAberto As System.Windows.Forms.Label
    Friend WithEvents ListaImagem As System.Windows.Forms.ImageList
    Friend WithEvents ListaCheque As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btChequeDia As System.Windows.Forms.Label
    Friend WithEvents ContextMenuCheque As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TodosOsChequeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodosDoDiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xCC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xTitular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xEntreguePro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xVencimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Repassar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btRepasseCheque As System.Windows.Forms.Label
    Friend WithEvents btTransferencia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAtivarCaixa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btCaixasAberto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaDespesaReceita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaBalanceteDesc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
