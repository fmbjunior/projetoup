<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesProdutoProcura
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ListaGrade = New System.Windows.Forms.DataGridView()
        Me.cProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cQtdEst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSequencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A5 = New System.Windows.Forms.RadioButton()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.Lista = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codOr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoFabrica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Local = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorvenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ListaGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.ListaGrade)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1048, 615)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'ListaGrade
        '
        Me.ListaGrade.AllowUserToAddRows = False
        Me.ListaGrade.AllowUserToDeleteRows = False
        Me.ListaGrade.AllowUserToResizeColumns = False
        Me.ListaGrade.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.ListaGrade.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaGrade.BackgroundColor = System.Drawing.Color.White
        Me.ListaGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cProduto, Me.cNumero, Me.cQtdEst, Me.cSequencia})
        Me.ListaGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ListaGrade.Location = New System.Drawing.Point(852, 86)
        Me.ListaGrade.MultiSelect = False
        Me.ListaGrade.Name = "ListaGrade"
        Me.ListaGrade.RowHeadersVisible = False
        Me.ListaGrade.RowHeadersWidth = 15
        Me.ListaGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaGrade.Size = New System.Drawing.Size(193, 524)
        Me.ListaGrade.TabIndex = 2
        '
        'cProduto
        '
        Me.cProduto.DataPropertyName = "Produto"
        Me.cProduto.HeaderText = "Produto"
        Me.cProduto.Name = "cProduto"
        Me.cProduto.Visible = False
        '
        'cNumero
        '
        Me.cNumero.DataPropertyName = "Numero"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cNumero.DefaultCellStyle = DataGridViewCellStyle2
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        Me.cNumero.Width = 80
        '
        'cQtdEst
        '
        Me.cQtdEst.DataPropertyName = "QtdEst"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cQtdEst.DefaultCellStyle = DataGridViewCellStyle3
        Me.cQtdEst.HeaderText = "Estoque"
        Me.cQtdEst.Name = "cQtdEst"
        Me.cQtdEst.Width = 90
        '
        'cSequencia
        '
        Me.cSequencia.DataPropertyName = "Sequencia"
        Me.cSequencia.HeaderText = "Sequencia"
        Me.cSequencia.Name = "cSequencia"
        Me.cSequencia.Visible = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A5)
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.ButtonX2)
        Me.GroupPanel1.Controls.Add(Me.txtProcura)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1042, 68)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Selecione uma das opções de procura do Produto"
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(670, 19)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(113, 19)
        Me.A5.TabIndex = 5
        Me.A5.Text = "Cod. Fábrica [F6]"
        Me.A5.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(532, 19)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(117, 19)
        Me.A4.TabIndex = 4
        Me.A4.Text = "Cod. Original [F5]"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Checked = True
        Me.A2.Location = New System.Drawing.Point(415, 19)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(101, 19)
        Me.A2.TabIndex = 3
        Me.A2.TabStop = True
        Me.A2.Text = "Descrição [F4]"
        Me.A2.UseVisualStyleBackColor = True
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(955, 18)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(69, 23)
        Me.ButtonX2.TabIndex = 0
        Me.ButtonX2.TabStop = False
        Me.ButtonX2.Text = "Fechar"
        '
        'txtProcura
        '
        Me.txtProcura.AceitaColarTexto = True
        Me.txtProcura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtProcura.CasasDecimais = 2
        Me.txtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcura.CPObrigatorio = False
        Me.txtProcura.CPObrigatorioMsg = Nothing
        Me.txtProcura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtProcura.FlatBorder = False
        Me.txtProcura.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtProcura.FocusColor = System.Drawing.Color.Empty
        Me.txtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtProcura.HighlightBorderOnEnter = False
        Me.txtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtProcura.Location = New System.Drawing.Point(3, 17)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.Size = New System.Drawing.Size(309, 23)
        Me.txtProcura.TabIndex = 1
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(318, 18)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(84, 19)
        Me.A1.TabIndex = 2
        Me.A1.Text = "Código [F3]"
        Me.A1.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(800, 19)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(123, 19)
        Me.A3.TabIndex = 6
        Me.A3.Text = "Mostrar Todos [F7]"
        Me.A3.UseVisualStyleBackColor = True
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        Me.Lista.AllowUserToResizeColumns = False
        Me.Lista.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Lista.BackgroundColor = System.Drawing.Color.White
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.codOr, Me.CodigoFabrica, Me.Desc, Me.cCor, Me.unidade, Me.tipo, Me.Local, Me.estoque, Me.valorvenda})
        Me.Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Lista.Location = New System.Drawing.Point(3, 86)
        Me.Lista.MultiSelect = False
        Me.Lista.Name = "Lista"
        Me.Lista.RowHeadersVisible = False
        Me.Lista.RowHeadersWidth = 15
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(843, 524)
        Me.Lista.TabIndex = 1
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "CodigoProduto"
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 70
        '
        'codOr
        '
        Me.codOr.DataPropertyName = "CodigoOriginal"
        Me.codOr.HeaderText = "Cod. Original"
        Me.codOr.Name = "codOr"
        Me.codOr.Visible = False
        '
        'CodigoFabrica
        '
        Me.CodigoFabrica.DataPropertyName = "CodigoFabrica"
        Me.CodigoFabrica.HeaderText = "Cod. Fábrica"
        Me.CodigoFabrica.Name = "CodigoFabrica"
        Me.CodigoFabrica.Visible = False
        '
        'Desc
        '
        Me.Desc.DataPropertyName = "Descrição"
        Me.Desc.HeaderText = "Descrição"
        Me.Desc.Name = "Desc"
        Me.Desc.Width = 290
        '
        'cCor
        '
        Me.cCor.DataPropertyName = "CorDesc"
        Me.cCor.HeaderText = "Cor"
        Me.cCor.Name = "cCor"
        Me.cCor.Width = 80
        '
        'unidade
        '
        Me.unidade.DataPropertyName = "UnidadeMedida"
        Me.unidade.HeaderText = "Un"
        Me.unidade.Name = "unidade"
        Me.unidade.Width = 35
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "TP"
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.Width = 80
        '
        'Local
        '
        Me.Local.DataPropertyName = "SetorLocalDesc"
        DataGridViewCellStyle5.NullValue = "Não Locado"
        Me.Local.DefaultCellStyle = DataGridViewCellStyle5
        Me.Local.HeaderText = "Local"
        Me.Local.MaxInputLength = 20
        Me.Local.Name = "Local"
        Me.Local.Width = 80
        '
        'estoque
        '
        Me.estoque.DataPropertyName = "QuantidadeEstoque"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N4"
        DataGridViewCellStyle6.NullValue = "0,0000"
        Me.estoque.DefaultCellStyle = DataGridViewCellStyle6
        Me.estoque.HeaderText = "Estoque"
        Me.estoque.Name = "estoque"
        Me.estoque.Width = 90
        '
        'valorvenda
        '
        Me.valorvenda.DataPropertyName = "ValorVenda"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0,00"
        Me.valorvenda.DefaultCellStyle = DataGridViewCellStyle7
        Me.valorvenda.HeaderText = "Vlr Venda"
        Me.valorvenda.Name = "valorvenda"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'SellShoesProdutoProcura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 615)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Name = "SellShoesProdutoProcura"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar de Produtos - T255"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.ListaGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents Lista As System.Windows.Forms.DataGridView
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents ListaGrade As System.Windows.Forms.DataGridView
    Friend WithEvents cProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cQtdEst As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSequencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codOr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFabrica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Local As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estoque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valorvenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
