<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocacaoCilindro
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocacaoCilindro))
        Me.cPainel = New DevComponents.DotNetBar.PanelEx()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.IDp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.controle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.txtCodigoProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtDataMovimentacao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtcontrole = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtQuantidade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtRazaoSocial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtCodigoCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.butLocalizar = New DevComponents.DotNetBar.ButtonX()
        Me.butFechar = New DevComponents.DotNetBar.ButtonX()
        Me.butImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.cPainel.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cPainel
        '
        Me.cPainel.CanvasColor = System.Drawing.SystemColors.Control
        Me.cPainel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cPainel.Controls.Add(Me.dgv)
        Me.cPainel.Controls.Add(Me.PanelEx4)
        Me.cPainel.Controls.Add(Me.PanelEx2)
        Me.cPainel.Controls.Add(Me.butFechar)
        Me.cPainel.Controls.Add(Me.butImprimir)
        Me.cPainel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cPainel.Location = New System.Drawing.Point(0, 0)
        Me.cPainel.Name = "cPainel"
        Me.cPainel.Size = New System.Drawing.Size(849, 539)
        Me.cPainel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.cPainel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.cPainel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.cPainel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.cPainel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.cPainel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.cPainel.Style.GradientAngle = 90
        Me.cPainel.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDp, Me.CodigoProduto, Me.Descricao, Me.Qtde, Me.data, Me.controle})
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv.Location = New System.Drawing.Point(12, 181)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(831, 299)
        Me.dgv.TabIndex = 18
        '
        'IDp
        '
        Me.IDp.DataPropertyName = "Locid"
        Me.IDp.HeaderText = "ID"
        Me.IDp.Name = "IDp"
        Me.IDp.ReadOnly = True
        Me.IDp.Visible = False
        Me.IDp.Width = 80
        '
        'CodigoProduto
        '
        Me.CodigoProduto.DataPropertyName = "LocCodigoProduto"
        Me.CodigoProduto.HeaderText = "Cod Prod."
        Me.CodigoProduto.Name = "CodigoProduto"
        Me.CodigoProduto.ReadOnly = True
        Me.CodigoProduto.Width = 80
        '
        'Descricao
        '
        Me.Descricao.DataPropertyName = "Descrição"
        Me.Descricao.HeaderText = "Descrição"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        Me.Descricao.Width = 400
        '
        'Qtde
        '
        Me.Qtde.DataPropertyName = "LocQtde"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0,00"
        Me.Qtde.DefaultCellStyle = DataGridViewCellStyle3
        Me.Qtde.HeaderText = "Qtde"
        Me.Qtde.Name = "Qtde"
        Me.Qtde.ReadOnly = True
        Me.Qtde.Width = 120
        '
        'data
        '
        Me.data.DataPropertyName = "LocData"
        Me.data.HeaderText = "Data Mov."
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.Width = 120
        '
        'controle
        '
        Me.controle.DataPropertyName = "LocControle"
        Me.controle.HeaderText = "Controle"
        Me.controle.Name = "controle"
        Me.controle.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "MenuListaDeItem"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 26)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem4.Text = "Excluir  produtos"
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx4.Controls.Add(Me.txtCodigoProduto)
        Me.PanelEx4.Controls.Add(Me.ButtonX1)
        Me.PanelEx4.Controls.Add(Me.txtProduto)
        Me.PanelEx4.Controls.Add(Me.txtDataMovimentacao)
        Me.PanelEx4.Controls.Add(Me.txtcontrole)
        Me.PanelEx4.Controls.Add(Me.txtQuantidade)
        Me.PanelEx4.Controls.Add(Me.Label7)
        Me.PanelEx4.Controls.Add(Me.Label1)
        Me.PanelEx4.Controls.Add(Me.Label3)
        Me.PanelEx4.Controls.Add(Me.Label5)
        Me.PanelEx4.Controls.Add(Me.Label2)
        Me.PanelEx4.Location = New System.Drawing.Point(12, 84)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(831, 89)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 1
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
        Me.txtCodigoProduto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProduto.HighlightBorderOnEnter = False
        Me.txtCodigoProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtCodigoProduto.Location = New System.Drawing.Point(6, 62)
        Me.txtCodigoProduto.MaxLength = 8
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.PreencherZeroEsqueda = False
        Me.txtCodigoProduto.RegraValidação = Nothing
        Me.txtCodigoProduto.RegraValidaçãoMensagem = Nothing
        Me.txtCodigoProduto.Size = New System.Drawing.Size(85, 23)
        Me.txtCodigoProduto.TabIndex = 0
        Me.txtCodigoProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtCodigoProduto.ValorPadrao = Nothing
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.Location = New System.Drawing.Point(770, 62)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(52, 25)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 5
        '
        'txtProduto
        '
        Me.txtProduto.AceitaColarTexto = True
        Me.txtProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtProduto.CasasDecimais = 2
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.CPObrigatorio = False
        Me.txtProduto.CPObrigatorioMsg = Nothing
        Me.txtProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtProduto.FlatBorder = False
        Me.txtProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtProduto.FocusColor = System.Drawing.Color.Empty
        Me.txtProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtProduto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.HighlightBorderOnEnter = False
        Me.txtProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtProduto.Location = New System.Drawing.Point(103, 63)
        Me.txtProduto.MaxLength = 10
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.PreencherZeroEsqueda = False
        Me.txtProduto.RegraValidação = Nothing
        Me.txtProduto.RegraValidaçãoMensagem = Nothing
        Me.txtProduto.Size = New System.Drawing.Size(397, 23)
        Me.txtProduto.TabIndex = 1
        Me.txtProduto.TabStop = False
        Me.txtProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtProduto.ValorPadrao = Nothing
        '
        'txtDataMovimentacao
        '
        Me.txtDataMovimentacao.AceitaColarTexto = True
        Me.txtDataMovimentacao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtDataMovimentacao.CasasDecimais = 2
        Me.txtDataMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataMovimentacao.CPObrigatorio = False
        Me.txtDataMovimentacao.CPObrigatorioMsg = Nothing
        Me.txtDataMovimentacao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.txtDataMovimentacao.FlatBorder = False
        Me.txtDataMovimentacao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtDataMovimentacao.FocusColor = System.Drawing.Color.Empty
        Me.txtDataMovimentacao.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtDataMovimentacao.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataMovimentacao.HighlightBorderOnEnter = False
        Me.txtDataMovimentacao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtDataMovimentacao.Location = New System.Drawing.Point(586, 63)
        Me.txtDataMovimentacao.MaxLength = 10
        Me.txtDataMovimentacao.Name = "txtDataMovimentacao"
        Me.txtDataMovimentacao.PreencherZeroEsqueda = False
        Me.txtDataMovimentacao.RegraValidação = Nothing
        Me.txtDataMovimentacao.RegraValidaçãoMensagem = Nothing
        Me.txtDataMovimentacao.Size = New System.Drawing.Size(97, 23)
        Me.txtDataMovimentacao.TabIndex = 3
        Me.txtDataMovimentacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataMovimentacao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtDataMovimentacao.ValorPadrao = Nothing
        '
        'txtcontrole
        '
        Me.txtcontrole.AceitaColarTexto = True
        Me.txtcontrole.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtcontrole.CasasDecimais = 2
        Me.txtcontrole.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontrole.CPObrigatorio = False
        Me.txtcontrole.CPObrigatorioMsg = Nothing
        Me.txtcontrole.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtcontrole.FlatBorder = False
        Me.txtcontrole.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtcontrole.FocusColor = System.Drawing.Color.Empty
        Me.txtcontrole.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtcontrole.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrole.HighlightBorderOnEnter = False
        Me.txtcontrole.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtcontrole.Location = New System.Drawing.Point(689, 63)
        Me.txtcontrole.MaxLength = 15
        Me.txtcontrole.Name = "txtcontrole"
        Me.txtcontrole.PreencherZeroEsqueda = False
        Me.txtcontrole.RegraValidação = Nothing
        Me.txtcontrole.RegraValidaçãoMensagem = Nothing
        Me.txtcontrole.Size = New System.Drawing.Size(75, 23)
        Me.txtcontrole.TabIndex = 4
        Me.txtcontrole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcontrole.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtcontrole.ValorPadrao = Nothing
        '
        'txtQuantidade
        '
        Me.txtQuantidade.AceitaColarTexto = True
        Me.txtQuantidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtQuantidade.CasasDecimais = 2
        Me.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantidade.CPObrigatorio = False
        Me.txtQuantidade.CPObrigatorioMsg = Nothing
        Me.txtQuantidade.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtQuantidade.FlatBorder = False
        Me.txtQuantidade.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtQuantidade.FocusColor = System.Drawing.Color.Empty
        Me.txtQuantidade.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtQuantidade.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.HighlightBorderOnEnter = False
        Me.txtQuantidade.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtQuantidade.Location = New System.Drawing.Point(505, 63)
        Me.txtQuantidade.MaxLength = 15
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.PreencherZeroEsqueda = False
        Me.txtQuantidade.RegraValidação = Nothing
        Me.txtQuantidade.RegraValidaçãoMensagem = Nothing
        Me.txtQuantidade.Size = New System.Drawing.Size(75, 23)
        Me.txtQuantidade.TabIndex = 2
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQuantidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.txtQuantidade.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Codigo Prod."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descrição"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(589, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data Mov."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(689, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Controle"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(515, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Qtde"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx2.Controls.Add(Me.txtRazaoSocial)
        Me.PanelEx2.Controls.Add(Me.txtCodigoCliente)
        Me.PanelEx2.Controls.Add(Me.Label8)
        Me.PanelEx2.Controls.Add(Me.butLocalizar)
        Me.PanelEx2.Location = New System.Drawing.Point(12, 12)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(831, 66)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.AceitaColarTexto = True
        Me.txtRazaoSocial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.txtRazaoSocial.CasasDecimais = 0
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazaoSocial.CPObrigatorio = False
        Me.txtRazaoSocial.CPObrigatorioMsg = Nothing
        Me.txtRazaoSocial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtRazaoSocial.FlatBorder = False
        Me.txtRazaoSocial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtRazaoSocial.FocusColor = System.Drawing.Color.Empty
        Me.txtRazaoSocial.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazaoSocial.HighlightBorderOnEnter = False
        Me.txtRazaoSocial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtRazaoSocial.Location = New System.Drawing.Point(172, 21)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.PreencherZeroEsqueda = False
        Me.txtRazaoSocial.RegraValidação = Nothing
        Me.txtRazaoSocial.RegraValidaçãoMensagem = Nothing
        Me.txtRazaoSocial.Size = New System.Drawing.Size(532, 23)
        Me.txtRazaoSocial.TabIndex = 2
        Me.txtRazaoSocial.TabStop = False
        Me.txtRazaoSocial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtRazaoSocial.ValorPadrao = Nothing
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.AceitaColarTexto = True
        Me.txtCodigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.txtCodigoCliente.CasasDecimais = 0
        Me.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCliente.CPObrigatorio = False
        Me.txtCodigoCliente.CPObrigatorioMsg = Nothing
        Me.txtCodigoCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtCodigoCliente.FlatBorder = False
        Me.txtCodigoCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtCodigoCliente.FocusColor = System.Drawing.Color.Empty
        Me.txtCodigoCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtCodigoCliente.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.HighlightBorderOnEnter = False
        Me.txtCodigoCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtCodigoCliente.Location = New System.Drawing.Point(81, 21)
        Me.txtCodigoCliente.MaxLength = 8
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.PreencherZeroEsqueda = False
        Me.txtCodigoCliente.RegraValidação = Nothing
        Me.txtCodigoCliente.RegraValidaçãoMensagem = Nothing
        Me.txtCodigoCliente.Size = New System.Drawing.Size(85, 23)
        Me.txtCodigoCliente.TabIndex = 1
        Me.txtCodigoCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtCodigoCliente.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cliente"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'butLocalizar
        '
        Me.butLocalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butLocalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butLocalizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butLocalizar.Location = New System.Drawing.Point(710, 19)
        Me.butLocalizar.Name = "butLocalizar"
        Me.butLocalizar.Size = New System.Drawing.Size(106, 25)
        Me.butLocalizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butLocalizar.TabIndex = 3
        Me.butLocalizar.Text = "&Localizar Cliente"
        '
        'butFechar
        '
        Me.butFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butFechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butFechar.Location = New System.Drawing.Point(768, 489)
        Me.butFechar.Name = "butFechar"
        Me.butFechar.Size = New System.Drawing.Size(75, 41)
        Me.butFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butFechar.TabIndex = 3
        Me.butFechar.Text = "&Fechar"
        '
        'butImprimir
        '
        Me.butImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butImprimir.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butImprimir.Location = New System.Drawing.Point(687, 489)
        Me.butImprimir.Name = "butImprimir"
        Me.butImprimir.Size = New System.Drawing.Size(75, 41)
        Me.butImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butImprimir.TabIndex = 2
        Me.butImprimir.Text = "Im&primir"
        '
        'LocacaoCilindro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 539)
        Me.ControlBox = False
        Me.Controls.Add(Me.cPainel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LocacaoCilindro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locação de Cilindros - T016"
        Me.cPainel.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.PanelEx4.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cPainel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtRazaoSocial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtCodigoCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents butFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents butImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents butLocalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtDataMovimentacao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtcontrole As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtQuantidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtCodigoProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IDp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qtde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents controle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
End Class
