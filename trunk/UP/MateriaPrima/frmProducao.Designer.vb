<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducao
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducao))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btnPesquisar = New DevComponents.DotNetBar.ButtonX()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CodigoVendedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CodigoCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NomeCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Contato = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NumeroOrdem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.lblTipoPedido = New System.Windows.Forms.Label()
        Me.DataProducao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpReservaMP = New System.Windows.Forms.GroupBox()
        Me.dgvMP = New System.Windows.Forms.DataGridView()
        Me.gId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gQtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gUn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gValor_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuExclusao = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAddMP = New DevComponents.DotNetBar.ButtonX()
        Me.NomeVendedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtCodigoProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtDescricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtQuantidade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNovo = New DevComponents.DotNetBar.ButtonX()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumeroPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataPrazo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.grpReservaMP.SuspendLayout()
        CType(Me.dgvMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuExclusao.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(745, 497)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(134, 33)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.Text = "Fechar"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPesquisar.AutoExpandOnClick = True
        Me.btnPesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(635, 498)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(104, 33)
        Me.btnPesquisar.TabIndex = 3
        Me.btnPesquisar.Text = "Pesquisar"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(888, 534)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(5, 138)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(873, 67)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(7, 12)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(871, 118)
        '
        'CodigoVendedor
        '
        Me.CodigoVendedor.AceitaColarTexto = True
        Me.CodigoVendedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoVendedor.CasasDecimais = 2
        Me.CodigoVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoVendedor.CPObrigatorio = False
        Me.CodigoVendedor.CPObrigatorioMsg = Nothing
        Me.CodigoVendedor.Enabled = False
        Me.CodigoVendedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoVendedor.FlatBorder = False
        Me.CodigoVendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoVendedor.FocusColor = System.Drawing.Color.Empty
        Me.CodigoVendedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoVendedor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoVendedor.HighlightBorderOnEnter = False
        Me.CodigoVendedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoVendedor.Location = New System.Drawing.Point(101, 94)
        Me.CodigoVendedor.MaxLength = 5
        Me.CodigoVendedor.Name = "CodigoVendedor"
        Me.CodigoVendedor.PreencherZeroEsqueda = False
        Me.CodigoVendedor.RegraValidação = Nothing
        Me.CodigoVendedor.RegraValidaçãoMensagem = Nothing
        Me.CodigoVendedor.Size = New System.Drawing.Size(76, 23)
        Me.CodigoVendedor.TabIndex = 7
        Me.CodigoVendedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoVendedor.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Vendedor"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cliente"
        '
        'CodigoCliente
        '
        Me.CodigoCliente.AceitaColarTexto = True
        Me.CodigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoCliente.CasasDecimais = 2
        Me.CodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoCliente.CPObrigatorio = False
        Me.CodigoCliente.CPObrigatorioMsg = Nothing
        Me.CodigoCliente.Enabled = False
        Me.CodigoCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoCliente.FlatBorder = False
        Me.CodigoCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoCliente.FocusColor = System.Drawing.Color.Empty
        Me.CodigoCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoCliente.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoCliente.HighlightBorderOnEnter = False
        Me.CodigoCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoCliente.Location = New System.Drawing.Point(101, 35)
        Me.CodigoCliente.Name = "CodigoCliente"
        Me.CodigoCliente.PreencherZeroEsqueda = False
        Me.CodigoCliente.RegraValidação = Nothing
        Me.CodigoCliente.RegraValidaçãoMensagem = Nothing
        Me.CodigoCliente.Size = New System.Drawing.Size(76, 23)
        Me.CodigoCliente.TabIndex = 12
        Me.CodigoCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoCliente.ValorPadrao = Nothing
        '
        'NomeCliente
        '
        Me.NomeCliente.AceitaColarTexto = True
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NomeCliente.CasasDecimais = 2
        Me.NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeCliente.CPObrigatorio = False
        Me.NomeCliente.CPObrigatorioMsg = Nothing
        Me.NomeCliente.Enabled = False
        Me.NomeCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeCliente.FlatBorder = False
        Me.NomeCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeCliente.FocusColor = System.Drawing.Color.Empty
        Me.NomeCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeCliente.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeCliente.HighlightBorderOnEnter = False
        Me.NomeCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeCliente.Location = New System.Drawing.Point(183, 35)
        Me.NomeCliente.MaxLength = 100
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.PreencherZeroEsqueda = False
        Me.NomeCliente.RegraValidação = Nothing
        Me.NomeCliente.RegraValidaçãoMensagem = Nothing
        Me.NomeCliente.Size = New System.Drawing.Size(450, 23)
        Me.NomeCliente.TabIndex = 13
        Me.NomeCliente.TabStop = False
        Me.NomeCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeCliente.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Contato"
        '
        'Contato
        '
        Me.Contato.AceitaColarTexto = True
        Me.Contato.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Contato.CasasDecimais = 2
        Me.Contato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Contato.CPObrigatorio = False
        Me.Contato.CPObrigatorioMsg = Nothing
        Me.Contato.Enabled = False
        Me.Contato.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Contato.FlatBorder = False
        Me.Contato.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Contato.FocusColor = System.Drawing.Color.Empty
        Me.Contato.FocusColorEnd = System.Drawing.Color.Empty
        Me.Contato.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contato.HighlightBorderOnEnter = False
        Me.Contato.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Contato.Location = New System.Drawing.Point(101, 65)
        Me.Contato.Name = "Contato"
        Me.Contato.PreencherZeroEsqueda = False
        Me.Contato.RegraValidação = Nothing
        Me.Contato.RegraValidaçãoMensagem = Nothing
        Me.Contato.Size = New System.Drawing.Size(313, 23)
        Me.Contato.TabIndex = 14
        Me.Contato.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Contato.ValorPadrao = Nothing
        '
        'NumeroOrdem
        '
        Me.NumeroOrdem.AceitaColarTexto = True
        Me.NumeroOrdem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NumeroOrdem.CasasDecimais = 2
        Me.NumeroOrdem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroOrdem.CPObrigatorio = False
        Me.NumeroOrdem.CPObrigatorioMsg = Nothing
        Me.NumeroOrdem.Enabled = False
        Me.NumeroOrdem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NumeroOrdem.FlatBorder = False
        Me.NumeroOrdem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NumeroOrdem.FocusColor = System.Drawing.Color.Empty
        Me.NumeroOrdem.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroOrdem.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroOrdem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumeroOrdem.HighlightBorderOnEnter = False
        Me.NumeroOrdem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NumeroOrdem.Location = New System.Drawing.Point(756, 35)
        Me.NumeroOrdem.MaxLength = 5
        Me.NumeroOrdem.Name = "NumeroOrdem"
        Me.NumeroOrdem.PreencherZeroEsqueda = False
        Me.NumeroOrdem.RegraValidação = Nothing
        Me.NumeroOrdem.RegraValidaçãoMensagem = Nothing
        Me.NumeroOrdem.Size = New System.Drawing.Size(119, 30)
        Me.NumeroOrdem.TabIndex = 18
        Me.NumeroOrdem.TabStop = False
        Me.NumeroOrdem.Text = "00000"
        Me.NumeroOrdem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroOrdem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroOrdem.ValorPadrao = Nothing
        '
        'lblTipoPedido
        '
        Me.lblTipoPedido.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoPedido.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTipoPedido.Location = New System.Drawing.Point(639, 38)
        Me.lblTipoPedido.Name = "lblTipoPedido"
        Me.lblTipoPedido.Size = New System.Drawing.Size(111, 23)
        Me.lblTipoPedido.TabIndex = 17
        Me.lblTipoPedido.Text = "Nº Ordem"
        '
        'DataProducao
        '
        Me.DataProducao.AceitaColarTexto = True
        Me.DataProducao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataProducao.CasasDecimais = 2
        Me.DataProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataProducao.CPObrigatorio = False
        Me.DataProducao.CPObrigatorioMsg = Nothing
        Me.DataProducao.Enabled = False
        Me.DataProducao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataProducao.FlatBorder = False
        Me.DataProducao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataProducao.FocusColor = System.Drawing.Color.Empty
        Me.DataProducao.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataProducao.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataProducao.HighlightBorderOnEnter = False
        Me.DataProducao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataProducao.Location = New System.Drawing.Point(756, 100)
        Me.DataProducao.MaxLength = 10
        Me.DataProducao.Name = "DataProducao"
        Me.DataProducao.PreencherZeroEsqueda = False
        Me.DataProducao.RegraValidação = Nothing
        Me.DataProducao.RegraValidaçãoMensagem = Nothing
        Me.DataProducao.Size = New System.Drawing.Size(119, 23)
        Me.DataProducao.TabIndex = 25
        Me.DataProducao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataProducao.ValorPadrao = Nothing
        '
        'DataPedido
        '
        Me.DataPedido.AceitaColarTexto = True
        Me.DataPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataPedido.CasasDecimais = 2
        Me.DataPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataPedido.CPObrigatorio = False
        Me.DataPedido.CPObrigatorioMsg = Nothing
        Me.DataPedido.Enabled = False
        Me.DataPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataPedido.FlatBorder = False
        Me.DataPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataPedido.FocusColor = System.Drawing.Color.Empty
        Me.DataPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataPedido.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPedido.HighlightBorderOnEnter = False
        Me.DataPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataPedido.Location = New System.Drawing.Point(514, 94)
        Me.DataPedido.Name = "DataPedido"
        Me.DataPedido.PreencherZeroEsqueda = False
        Me.DataPedido.RegraValidação = Nothing
        Me.DataPedido.RegraValidaçãoMensagem = Nothing
        Me.DataPedido.Size = New System.Drawing.Size(119, 23)
        Me.DataPedido.TabIndex = 23
        Me.DataPedido.TabStop = False
        Me.DataPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DataPedido.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(420, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Data Ped/Orc"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(647, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Data Produção"
        '
        'grpReservaMP
        '
        Me.grpReservaMP.Controls.Add(Me.dgvMP)
        Me.grpReservaMP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReservaMP.Location = New System.Drawing.Point(7, 212)
        Me.grpReservaMP.Name = "grpReservaMP"
        Me.grpReservaMP.Size = New System.Drawing.Size(872, 273)
        Me.grpReservaMP.TabIndex = 26
        Me.grpReservaMP.TabStop = False
        Me.grpReservaMP.Text = "Reserva Matéria Prima"
        '
        'dgvMP
        '
        Me.dgvMP.AllowUserToAddRows = False
        Me.dgvMP.AllowUserToDeleteRows = False
        Me.dgvMP.AllowUserToResizeColumns = False
        Me.dgvMP.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgvMP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gId, Me.gCodigo, Me.gDescricao, Me.gQtde, Me.gUn, Me.gValor_unitario, Me.gTotal})
        Me.dgvMP.ContextMenuStrip = Me.mnuExclusao
        Me.dgvMP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMP.Location = New System.Drawing.Point(8, 22)
        Me.dgvMP.MultiSelect = False
        Me.dgvMP.Name = "dgvMP"
        Me.dgvMP.ReadOnly = True
        Me.dgvMP.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgvMP.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMP.Size = New System.Drawing.Size(860, 236)
        Me.dgvMP.TabIndex = 0
        '
        'gId
        '
        Me.gId.DataPropertyName = "id"
        Me.gId.HeaderText = "ID"
        Me.gId.Name = "gId"
        Me.gId.ReadOnly = True
        Me.gId.Visible = False
        '
        'gCodigo
        '
        Me.gCodigo.DataPropertyName = "CodigoMP"
        Me.gCodigo.HeaderText = "MP"
        Me.gCodigo.Name = "gCodigo"
        Me.gCodigo.ReadOnly = True
        Me.gCodigo.Width = 70
        '
        'gDescricao
        '
        Me.gDescricao.DataPropertyName = "Descrição"
        Me.gDescricao.HeaderText = "Descrição"
        Me.gDescricao.Name = "gDescricao"
        Me.gDescricao.ReadOnly = True
        Me.gDescricao.Width = 400
        '
        'gQtde
        '
        Me.gQtde.DataPropertyName = "Quantidade"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        Me.gQtde.DefaultCellStyle = DataGridViewCellStyle2
        Me.gQtde.HeaderText = "Qtde"
        Me.gQtde.Name = "gQtde"
        Me.gQtde.ReadOnly = True
        '
        'gUn
        '
        Me.gUn.DataPropertyName = "UnidadeMedida"
        Me.gUn.HeaderText = "Un."
        Me.gUn.Name = "gUn"
        Me.gUn.ReadOnly = True
        Me.gUn.Width = 50
        '
        'gValor_unitario
        '
        Me.gValor_unitario.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle3.Format = "******"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.gValor_unitario.DefaultCellStyle = DataGridViewCellStyle3
        Me.gValor_unitario.HeaderText = "Vlr.Unit."
        Me.gValor_unitario.Name = "gValor_unitario"
        Me.gValor_unitario.ReadOnly = True
        '
        'gTotal
        '
        Me.gTotal.DataPropertyName = "ValorTotal"
        DataGridViewCellStyle4.Format = "*******"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.gTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.gTotal.HeaderText = "Total"
        Me.gTotal.Name = "gTotal"
        Me.gTotal.ReadOnly = True
        '
        'mnuExclusao
        '
        Me.mnuExclusao.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mnuExclusao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.ToolStripMenuItem4, Me.ToolStripSeparator3})
        Me.mnuExclusao.Name = "MenuListaProduto"
        Me.mnuExclusao.Size = New System.Drawing.Size(207, 66)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(206, 22)
        Me.ToolStripMenuItem3.Text = "Excluir Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(203, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(206, 22)
        Me.ToolStripMenuItem4.Text = "Excluir Todos os Produtos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(203, 6)
        '
        'btnAddMP
        '
        Me.btnAddMP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddMP.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAddMP.Image = CType(resources.GetObject("btnAddMP.Image"), System.Drawing.Image)
        Me.btnAddMP.Location = New System.Drawing.Point(761, 21)
        Me.btnAddMP.Name = "btnAddMP"
        Me.btnAddMP.Size = New System.Drawing.Size(95, 31)
        Me.btnAddMP.TabIndex = 2
        Me.btnAddMP.Text = "Adicionar"
        '
        'NomeVendedor
        '
        Me.NomeVendedor.AceitaColarTexto = True
        Me.NomeVendedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NomeVendedor.CasasDecimais = 2
        Me.NomeVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeVendedor.CPObrigatorio = False
        Me.NomeVendedor.CPObrigatorioMsg = Nothing
        Me.NomeVendedor.Enabled = False
        Me.NomeVendedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeVendedor.FlatBorder = False
        Me.NomeVendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeVendedor.FocusColor = System.Drawing.Color.Empty
        Me.NomeVendedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeVendedor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeVendedor.HighlightBorderOnEnter = False
        Me.NomeVendedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeVendedor.Location = New System.Drawing.Point(183, 94)
        Me.NomeVendedor.Name = "NomeVendedor"
        Me.NomeVendedor.PreencherZeroEsqueda = False
        Me.NomeVendedor.RegraValidação = Nothing
        Me.NomeVendedor.RegraValidaçãoMensagem = Nothing
        Me.NomeVendedor.Size = New System.Drawing.Size(231, 23)
        Me.NomeVendedor.TabIndex = 27
        Me.NomeVendedor.TabStop = False
        Me.NomeVendedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeVendedor.ValorPadrao = Nothing
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.AceitaColarTexto = True
        Me.txtCodigoProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtCodigoProduto.CasasDecimais = 0
        Me.txtCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProduto.CPObrigatorio = False
        Me.txtCodigoProduto.CPObrigatorioMsg = Nothing
        Me.txtCodigoProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtCodigoProduto.FlatBorder = False
        Me.txtCodigoProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtCodigoProduto.FocusColor = System.Drawing.Color.Empty
        Me.txtCodigoProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtCodigoProduto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProduto.HighlightBorderOnEnter = False
        Me.txtCodigoProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtCodigoProduto.Location = New System.Drawing.Point(8, 28)
        Me.txtCodigoProduto.MaxLength = 15
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.PreencherZeroEsqueda = False
        Me.txtCodigoProduto.RegraValidação = Nothing
        Me.txtCodigoProduto.RegraValidaçãoMensagem = Nothing
        Me.txtCodigoProduto.Size = New System.Drawing.Size(82, 23)
        Me.txtCodigoProduto.TabIndex = 0
        Me.txtCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigoProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtCodigoProduto.ValorPadrao = Nothing
        '
        'txtDescricao
        '
        Me.txtDescricao.AceitaColarTexto = True
        Me.txtDescricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.txtDescricao.CasasDecimais = 3
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.CPObrigatorio = False
        Me.txtDescricao.CPObrigatorioMsg = Nothing
        Me.txtDescricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtDescricao.FlatBorder = False
        Me.txtDescricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtDescricao.FocusColor = System.Drawing.Color.Empty
        Me.txtDescricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtDescricao.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.HighlightBorderOnEnter = False
        Me.txtDescricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtDescricao.Location = New System.Drawing.Point(96, 28)
        Me.txtDescricao.MaxLength = 15
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.PreencherZeroEsqueda = False
        Me.txtDescricao.RegraValidação = Nothing
        Me.txtDescricao.RegraValidaçãoMensagem = Nothing
        Me.txtDescricao.Size = New System.Drawing.Size(541, 23)
        Me.txtDescricao.TabIndex = 28
        Me.txtDescricao.TabStop = False
        Me.txtDescricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtDescricao.ValorPadrao = Nothing
        '
        'txtQuantidade
        '
        Me.txtQuantidade.AceitaColarTexto = True
        Me.txtQuantidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtQuantidade.CasasDecimais = 3
        Me.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantidade.CPObrigatorio = False
        Me.txtQuantidade.CPObrigatorioMsg = Nothing
        Me.txtQuantidade.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtQuantidade.FlatBorder = False
        Me.txtQuantidade.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtQuantidade.FocusColor = System.Drawing.Color.Empty
        Me.txtQuantidade.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtQuantidade.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.HighlightBorderOnEnter = False
        Me.txtQuantidade.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtQuantidade.Location = New System.Drawing.Point(643, 28)
        Me.txtQuantidade.MaxLength = 15
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.PreencherZeroEsqueda = False
        Me.txtQuantidade.RegraValidação = Nothing
        Me.txtQuantidade.RegraValidaçãoMensagem = Nothing
        Me.txtQuantidade.Size = New System.Drawing.Size(112, 23)
        Me.txtQuantidade.TabIndex = 1
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtQuantidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.txtQuantidade.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código MP"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(120, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Descrição do Produto MP"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(642, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Qtde"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNovo
        '
        Me.btnNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(404, 498)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNovo.Size = New System.Drawing.Size(115, 33)
        Me.btnNovo.TabIndex = 29
        Me.btnNovo.Text = "Novo"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(641, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Pedido"
        '
        'NumeroPedido
        '
        Me.NumeroPedido.AceitaColarTexto = True
        Me.NumeroPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NumeroPedido.CasasDecimais = 2
        Me.NumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroPedido.CPObrigatorio = False
        Me.NumeroPedido.CPObrigatorioMsg = Nothing
        Me.NumeroPedido.Enabled = False
        Me.NumeroPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NumeroPedido.FlatBorder = False
        Me.NumeroPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NumeroPedido.FocusColor = System.Drawing.Color.Empty
        Me.NumeroPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroPedido.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroPedido.ForeColor = System.Drawing.Color.Green
        Me.NumeroPedido.HighlightBorderOnEnter = False
        Me.NumeroPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NumeroPedido.Location = New System.Drawing.Point(756, 69)
        Me.NumeroPedido.MaxLength = 5
        Me.NumeroPedido.Name = "NumeroPedido"
        Me.NumeroPedido.PreencherZeroEsqueda = False
        Me.NumeroPedido.RegraValidação = Nothing
        Me.NumeroPedido.RegraValidaçãoMensagem = Nothing
        Me.NumeroPedido.Size = New System.Drawing.Size(119, 27)
        Me.NumeroPedido.TabIndex = 19
        Me.NumeroPedido.TabStop = False
        Me.NumeroPedido.Text = "00000"
        Me.NumeroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroPedido.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(420, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Data Prazo"
        '
        'DataPrazo
        '
        Me.DataPrazo.AceitaColarTexto = True
        Me.DataPrazo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataPrazo.CasasDecimais = 2
        Me.DataPrazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataPrazo.CPObrigatorio = False
        Me.DataPrazo.CPObrigatorioMsg = Nothing
        Me.DataPrazo.Enabled = False
        Me.DataPrazo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataPrazo.FlatBorder = False
        Me.DataPrazo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataPrazo.FocusColor = System.Drawing.Color.Empty
        Me.DataPrazo.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataPrazo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPrazo.HighlightBorderOnEnter = False
        Me.DataPrazo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataPrazo.Location = New System.Drawing.Point(514, 65)
        Me.DataPrazo.Name = "DataPrazo"
        Me.DataPrazo.PreencherZeroEsqueda = False
        Me.DataPrazo.RegraValidação = Nothing
        Me.DataPrazo.RegraValidaçãoMensagem = Nothing
        Me.DataPrazo.Size = New System.Drawing.Size(119, 23)
        Me.DataPrazo.TabIndex = 22
        Me.DataPrazo.TabStop = False
        Me.DataPrazo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DataPrazo.ValorPadrao = Nothing
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnAddMP)
        Me.Panel1.Controls.Add(Me.txtCodigoProduto)
        Me.Panel1.Controls.Add(Me.txtDescricao)
        Me.Panel1.Controls.Add(Me.txtQuantidade)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(10, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 55)
        Me.Panel1.TabIndex = 30
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.AutoExpandOnClick = True
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnImprimir.Image = Global.Up.My.Resources.Resources.Impressora
        Me.btnImprimir.Location = New System.Drawing.Point(525, 498)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 33)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Pesquisar"
        '
        'frmProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataPrazo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NumeroPedido)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.NomeVendedor)
        Me.Controls.Add(Me.grpReservaMP)
        Me.Controls.Add(Me.DataProducao)
        Me.Controls.Add(Me.DataPedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumeroOrdem)
        Me.Controls.Add(Me.lblTipoPedido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Contato)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CodigoCliente)
        Me.Controls.Add(Me.NomeCliente)
        Me.Controls.Add(Me.CodigoVendedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProducao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançamento da Produção"
        Me.grpReservaMP.ResumeLayout(False)
        CType(Me.dgvMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuExclusao.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPesquisar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CodigoVendedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CodigoCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NomeCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Contato As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NumeroOrdem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents lblTipoPedido As System.Windows.Forms.Label
    Friend WithEvents DataProducao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpReservaMP As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddMP As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvMP As System.Windows.Forms.DataGridView
    Friend WithEvents NomeVendedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtCodigoProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtDescricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtQuantidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NumeroPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataPrazo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mnuExclusao As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gDescricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gQtde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gUn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gValor_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
End Class
