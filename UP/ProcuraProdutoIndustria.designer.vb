<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcuraProdutoIndustria
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A5 = New System.Windows.Forms.RadioButton()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.DgvItem)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(898, 615)
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
        Me.GroupPanel1.Controls.Add(Me.A5)
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.ButtonX2)
        Me.GroupPanel1.Controls.Add(Me.txtProcura)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(874, 82)
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
        Me.GroupPanel1.Text = "Selecione uma das opções de procura do Produto"
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(318, 3)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(89, 19)
        Me.A5.TabIndex = 6
        Me.A5.Text = "Cod. Fábrica"
        Me.A5.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(219, 3)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(93, 19)
        Me.A4.TabIndex = 5
        Me.A4.Text = "Cod. Original"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(118, 3)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(95, 19)
        Me.A2.TabIndex = 1
        Me.A2.Text = "Alfanumérica"
        Me.A2.UseVisualStyleBackColor = True
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(796, 3)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(69, 22)
        Me.ButtonX2.TabIndex = 4
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
        Me.txtProcura.Location = New System.Drawing.Point(3, 28)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.Size = New System.Drawing.Size(862, 23)
        Me.txtProcura.TabIndex = 3
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(20, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(92, 19)
        Me.A1.TabIndex = 0
        Me.A1.Text = "Campo Chave"
        Me.A1.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(413, 3)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(99, 19)
        Me.A3.TabIndex = 2
        Me.A3.Text = "Mostrar Todos"
        Me.A3.UseVisualStyleBackColor = True
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrchid
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column4, Me.Column5, Me.ItemFornecedor, Me.Column1, Me.Column3, Me.Column6})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.Location = New System.Drawing.Point(12, 100)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(874, 503)
        Me.DgvItem.TabIndex = 1
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CodigoProduto"
        Me.Column2.HeaderText = "Código"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 70
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CodigoOriginal"
        Me.Column4.HeaderText = "Cod. Original"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 90
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "CodigoFabrica"
        Me.Column5.HeaderText = "Cod. Fábrica"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'ItemFornecedor
        '
        Me.ItemFornecedor.DataPropertyName = "Descrição"
        Me.ItemFornecedor.HeaderText = "Descrição"
        Me.ItemFornecedor.Name = "ItemFornecedor"
        Me.ItemFornecedor.Width = 300
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "TP"
        Me.Column1.HeaderText = "Tipo"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "QuantidadeEstoque"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Estoque"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 90
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "ValorVenda"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column6.HeaderText = "Vlr Venda"
        Me.Column6.Name = "Column6"
        '
        'ProcuraProdutoIndustria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 615)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ProcuraProdutoIndustria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar de Produtos Industria"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
