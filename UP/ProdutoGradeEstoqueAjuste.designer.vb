<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoGradeEstoqueAjuste
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProdutoGradeEstoqueAjuste))
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EstoqueNew = New TexBoxFocusNet.TextBoxFocusNet()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEstAtual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btFindClintes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.EstoqueNew)
        Me.Fundo.Controls.Add(Me.GroupPanel2)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.btAtualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(450, 413)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Estoque Novo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstoqueNew
        '
        Me.EstoqueNew.AceitaColarTexto = True
        Me.EstoqueNew.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EstoqueNew.CasasDecimais = 4
        Me.EstoqueNew.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstoqueNew.CPObrigatorio = False
        Me.EstoqueNew.CPObrigatorioMsg = Nothing
        Me.EstoqueNew.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstoqueNew.FlatBorder = False
        Me.EstoqueNew.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstoqueNew.FocusColor = System.Drawing.Color.MistyRose
        Me.EstoqueNew.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstoqueNew.HighlightBorderOnEnter = False
        Me.EstoqueNew.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstoqueNew.Location = New System.Drawing.Point(96, 377)
        Me.EstoqueNew.MaxLength = 15
        Me.EstoqueNew.Name = "EstoqueNew"
        Me.EstoqueNew.PreencherZeroEsqueda = False
        Me.EstoqueNew.RegraValidação = Nothing
        Me.EstoqueNew.RegraValidaçãoMensagem = Nothing
        Me.EstoqueNew.Size = New System.Drawing.Size(111, 23)
        Me.EstoqueNew.TabIndex = 5
        Me.EstoqueNew.TabStop = False
        Me.EstoqueNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EstoqueNew.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.EstoqueNew.ValorPadrao = Nothing
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Lista)
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 120)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(423, 251)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Grade dos Produtos"
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cProduto, Me.cNumero, Me.Column3, Me.cEstAtual, Me.Column5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle5
        Me.Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(3, 3)
        Me.Lista.Name = "Lista"
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(405, 216)
        Me.Lista.TabIndex = 2
        '
        'cProduto
        '
        Me.cProduto.DataPropertyName = "Produto"
        Me.cProduto.HeaderText = "Produto"
        Me.cProduto.Name = "cProduto"
        Me.cProduto.ReadOnly = True
        Me.cProduto.Visible = False
        '
        'cNumero
        '
        Me.cNumero.DataPropertyName = "Numero"
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        Me.cNumero.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "QtdEst"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Estoque"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'cEstAtual
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = "0,00"
        Me.cEstAtual.DefaultCellStyle = DataGridViewCellStyle3
        Me.cEstAtual.HeaderText = "Est. Novo"
        Me.cEstAtual.Name = "cEstAtual"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Sequencia"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Seq"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btFindClintes)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Produto)
        Me.GroupPanel1.Controls.Add(Me.ProdutoDesc)
        Me.GroupPanel1.Location = New System.Drawing.Point(14, 11)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(423, 103)
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
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Selecione um Produto para Atualizar"
        '
        'btFindClintes
        '
        Me.btFindClintes.Image = CType(resources.GetObject("btFindClintes.Image"), System.Drawing.Image)
        Me.btFindClintes.Location = New System.Drawing.Point(76, 18)
        Me.btFindClintes.Name = "btFindClintes"
        Me.btFindClintes.Size = New System.Drawing.Size(23, 23)
        Me.btFindClintes.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe o Produto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Produto.FocusColor = System.Drawing.Color.MistyRose
        Me.Produto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Produto.HighlightBorderOnEnter = False
        Me.Produto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Produto.Location = New System.Drawing.Point(3, 18)
        Me.Produto.Name = "Produto"
        Me.Produto.PreencherZeroEsqueda = False
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(70, 23)
        Me.Produto.TabIndex = 1
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
        '
        'ProdutoDesc
        '
        Me.ProdutoDesc.AceitaColarTexto = False
        Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdutoDesc.CasasDecimais = 0
        Me.ProdutoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoDesc.CPObrigatorio = False
        Me.ProdutoDesc.CPObrigatorioMsg = Nothing
        Me.ProdutoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoDesc.FlatBorder = False
        Me.ProdutoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ProdutoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDesc.HighlightBorderOnEnter = False
        Me.ProdutoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ProdutoDesc.Location = New System.Drawing.Point(3, 47)
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.PreencherZeroEsqueda = False
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(405, 23)
        Me.ProdutoDesc.TabIndex = 3
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Location = New System.Drawing.Point(227, 377)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(101, 27)
        Me.btAtualizar.TabIndex = 2
        Me.btAtualizar.Text = "Atualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(336, 377)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(101, 27)
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar"
        '
        'ProdutoGradeEstoqueAjuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProdutoGradeEstoqueAjuste"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste de Estoque  - T014"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btFindClintes As System.Windows.Forms.Label
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EstoqueNew As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents cProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEstAtual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
