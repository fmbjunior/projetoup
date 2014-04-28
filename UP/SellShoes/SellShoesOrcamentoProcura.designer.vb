<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesOrcamentoProcura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellShoesOrcamentoProcura))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PainelCliente = New System.Windows.Forms.Panel()
        Me.CliDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CodCli = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindClintes = New System.Windows.Forms.Label()
        Me.PainelOutros = New System.Windows.Forms.Panel()
        Me.LabelOutros = New System.Windows.Forms.Label()
        Me.ProcuraTxt = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cOrcSequencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDataPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PainelCliente.SuspendLayout()
        Me.PainelOutros.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(977, 667)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PainelCliente)
        Me.GroupPanel1.Controls.Add(Me.PainelOutros)
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 571)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(704, 90)
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
        Me.GroupPanel1.TabIndex = 30
        Me.GroupPanel1.Text = "Informações de Procura"
        '
        'PainelCliente
        '
        Me.PainelCliente.Controls.Add(Me.CliDesc)
        Me.PainelCliente.Controls.Add(Me.Label12)
        Me.PainelCliente.Controls.Add(Me.CodCli)
        Me.PainelCliente.Controls.Add(Me.btFindClintes)
        Me.PainelCliente.Location = New System.Drawing.Point(197, 34)
        Me.PainelCliente.Name = "PainelCliente"
        Me.PainelCliente.Size = New System.Drawing.Size(504, 31)
        Me.PainelCliente.TabIndex = 31
        Me.PainelCliente.Visible = False
        '
        'CliDesc
        '
        Me.CliDesc.AceitaColarTexto = True
        Me.CliDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CliDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CliDesc.CasasDecimais = 0
        Me.CliDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CliDesc.CPObrigatorio = False
        Me.CliDesc.CPObrigatorioMsg = Nothing
        Me.CliDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CliDesc.FlatBorder = False
        Me.CliDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CliDesc.FocusColor = System.Drawing.Color.Empty
        Me.CliDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.CliDesc.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CliDesc.HighlightBorderOnEnter = False
        Me.CliDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CliDesc.Location = New System.Drawing.Point(186, 3)
        Me.CliDesc.MaxLength = 3000
        Me.CliDesc.Name = "CliDesc"
        Me.CliDesc.PreencherZeroEsqueda = False
        Me.CliDesc.RegraValidação = Nothing
        Me.CliDesc.RegraValidaçãoMensagem = Nothing
        Me.CliDesc.Size = New System.Drawing.Size(312, 24)
        Me.CliDesc.TabIndex = 2
        Me.CliDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CliDesc.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-3, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Inf. o Cliente"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodCli
        '
        Me.CodCli.AceitaColarTexto = True
        Me.CodCli.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodCli.CasasDecimais = 0
        Me.CodCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodCli.CPObrigatorio = False
        Me.CodCli.CPObrigatorioMsg = Nothing
        Me.CodCli.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodCli.FlatBorder = False
        Me.CodCli.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodCli.FocusColor = System.Drawing.Color.Empty
        Me.CodCli.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodCli.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodCli.HighlightBorderOnEnter = False
        Me.CodCli.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodCli.Location = New System.Drawing.Point(82, 3)
        Me.CodCli.MaxLength = 3000
        Me.CodCli.Name = "CodCli"
        Me.CodCli.PreencherZeroEsqueda = False
        Me.CodCli.RegraValidação = Nothing
        Me.CodCli.RegraValidaçãoMensagem = Nothing
        Me.CodCli.Size = New System.Drawing.Size(76, 24)
        Me.CodCli.TabIndex = 1
        Me.CodCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodCli.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodCli.ValorPadrao = Nothing
        '
        'btFindClintes
        '
        Me.btFindClintes.Image = CType(resources.GetObject("btFindClintes.Image"), System.Drawing.Image)
        Me.btFindClintes.Location = New System.Drawing.Point(160, 3)
        Me.btFindClintes.Name = "btFindClintes"
        Me.btFindClintes.Size = New System.Drawing.Size(23, 23)
        Me.btFindClintes.TabIndex = 28
        '
        'PainelOutros
        '
        Me.PainelOutros.Controls.Add(Me.LabelOutros)
        Me.PainelOutros.Controls.Add(Me.ProcuraTxt)
        Me.PainelOutros.Location = New System.Drawing.Point(313, 2)
        Me.PainelOutros.Name = "PainelOutros"
        Me.PainelOutros.Size = New System.Drawing.Size(275, 29)
        Me.PainelOutros.TabIndex = 32
        Me.PainelOutros.Visible = False
        '
        'LabelOutros
        '
        Me.LabelOutros.BackColor = System.Drawing.Color.Transparent
        Me.LabelOutros.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutros.Location = New System.Drawing.Point(-3, 6)
        Me.LabelOutros.Name = "LabelOutros"
        Me.LabelOutros.Size = New System.Drawing.Size(103, 21)
        Me.LabelOutros.TabIndex = 0
        Me.LabelOutros.Text = "Inf. o Orçamento"
        Me.LabelOutros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcuraTxt
        '
        Me.ProcuraTxt.AceitaColarTexto = True
        Me.ProcuraTxt.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ProcuraTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProcuraTxt.CasasDecimais = 0
        Me.ProcuraTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProcuraTxt.CPObrigatorio = False
        Me.ProcuraTxt.CPObrigatorioMsg = Nothing
        Me.ProcuraTxt.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProcuraTxt.FlatBorder = False
        Me.ProcuraTxt.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ProcuraTxt.FocusColor = System.Drawing.Color.Empty
        Me.ProcuraTxt.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProcuraTxt.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcuraTxt.HighlightBorderOnEnter = False
        Me.ProcuraTxt.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProcuraTxt.Location = New System.Drawing.Point(106, 4)
        Me.ProcuraTxt.MaxLength = 3000
        Me.ProcuraTxt.Name = "ProcuraTxt"
        Me.ProcuraTxt.PreencherZeroEsqueda = False
        Me.ProcuraTxt.RegraValidação = Nothing
        Me.ProcuraTxt.RegraValidaçãoMensagem = Nothing
        Me.ProcuraTxt.Size = New System.Drawing.Size(76, 24)
        Me.ProcuraTxt.TabIndex = 1
        Me.ProcuraTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ProcuraTxt.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProcuraTxt.ValorPadrao = Nothing
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(90, 38)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(101, 19)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Por Orçamento"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(3, 38)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(69, 19)
        Me.A2.TabIndex = 2
        Me.A2.TabStop = True
        Me.A2.Text = "Por Data"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(90, 3)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(131, 19)
        Me.A3.TabIndex = 1
        Me.A3.TabStop = True
        Me.A3.Text = "Por Vendedor Código"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(81, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Por Cliente"
        Me.A1.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.Location = New System.Drawing.Point(773, 636)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(93, 25)
        Me.btNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNovo.TabIndex = 29
        Me.btNovo.Text = "&Novo"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(872, 636)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(93, 25)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "&Fechar"
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Img, Me.cOrcSequencia, Me.cCliente, Me.gvendedor, Me.cDataPedido, Me.cTotalPedido})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle3
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(12, 12)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersVisible = False
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(953, 553)
        Me.Lista.TabIndex = 3
        '
        'Img
        '
        Me.Img.HeaderText = ""
        Me.Img.Image = CType(resources.GetObject("Img.Image"), System.Drawing.Image)
        Me.Img.Name = "Img"
        Me.Img.ReadOnly = True
        Me.Img.Width = 30
        '
        'cOrcSequencia
        '
        Me.cOrcSequencia.DataPropertyName = "OrcSequencia"
        Me.cOrcSequencia.FillWeight = 90.0!
        Me.cOrcSequencia.HeaderText = "Orçamento"
        Me.cOrcSequencia.Name = "cOrcSequencia"
        Me.cOrcSequencia.ReadOnly = True
        Me.cOrcSequencia.Width = 80
        '
        'cCliente
        '
        Me.cCliente.DataPropertyName = "Cliente"
        Me.cCliente.HeaderText = "Cliente"
        Me.cCliente.Name = "cCliente"
        Me.cCliente.ReadOnly = True
        Me.cCliente.Width = 380
        '
        'gvendedor
        '
        Me.gvendedor.DataPropertyName = "Vendedor"
        Me.gvendedor.HeaderText = "Vendedor"
        Me.gvendedor.Name = "gvendedor"
        Me.gvendedor.ReadOnly = True
        Me.gvendedor.Width = 200
        '
        'cDataPedido
        '
        Me.cDataPedido.DataPropertyName = "DataOrc"
        Me.cDataPedido.HeaderText = "Data Orç."
        Me.cDataPedido.Name = "cDataPedido"
        Me.cDataPedido.ReadOnly = True
        Me.cDataPedido.Width = 120
        '
        'cTotalPedido
        '
        Me.cTotalPedido.DataPropertyName = "TotalOrc"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cTotalPedido.DefaultCellStyle = DataGridViewCellStyle2
        Me.cTotalPedido.HeaderText = "Total Orç"
        Me.cTotalPedido.Name = "cTotalPedido"
        Me.cTotalPedido.ReadOnly = True
        Me.cTotalPedido.Width = 120
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'SellShoesOrcamentoProcura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 667)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "SellShoesOrcamentoProcura"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellShoesPendentes - T253"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.PainelCliente.ResumeLayout(False)
        Me.PainelCliente.PerformLayout()
        Me.PainelOutros.ResumeLayout(False)
        Me.PainelOutros.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents CliDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CodCli As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindClintes As System.Windows.Forms.Label
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PainelCliente As System.Windows.Forms.Panel
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelOutros As System.Windows.Forms.Panel
    Friend WithEvents LabelOutros As System.Windows.Forms.Label
    Friend WithEvents ProcuraTxt As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cOrcSequencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDataPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
