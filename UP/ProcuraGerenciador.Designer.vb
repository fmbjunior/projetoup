<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcuraGerenciador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.TipoProcura = New System.Windows.Forms.GroupBox
        Me.txtFornecedor = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fornecedor = New System.Windows.Forms.RadioButton
        Me.MostraTodos = New System.Windows.Forms.RadioButton
        Me.CampoChave = New System.Windows.Forms.RadioButton
        Me.DgvItem = New System.Windows.Forms.DataGridView
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemData = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.itemValor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelEx1.SuspendLayout()
        Me.TipoProcura.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.TipoProcura)
        Me.PanelEx1.Controls.Add(Me.DgvItem)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(618, 390)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(488, 337)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(125, 33)
        Me.ButtonX2.TabIndex = 18
        Me.ButtonX2.Text = "Fechar"
        '
        'TipoProcura
        '
        Me.TipoProcura.BackColor = System.Drawing.Color.Transparent
        Me.TipoProcura.Controls.Add(Me.txtFornecedor)
        Me.TipoProcura.Controls.Add(Me.Fornecedor)
        Me.TipoProcura.Controls.Add(Me.MostraTodos)
        Me.TipoProcura.Controls.Add(Me.CampoChave)
        Me.TipoProcura.Location = New System.Drawing.Point(12, 26)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(601, 43)
        Me.TipoProcura.TabIndex = 1
        Me.TipoProcura.TabStop = False
        Me.TipoProcura.Text = "Tipo de Procura"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.AceitaColarTexto = True
        Me.txtFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtFornecedor.CasasDecimais = 2
        Me.txtFornecedor.CPObrigatorio = False
        Me.txtFornecedor.CPObrigatorioMsg = Nothing
        Me.txtFornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtFornecedor.FocusColor = System.Drawing.Color.Empty
        Me.txtFornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtFornecedor.Location = New System.Drawing.Point(6, 17)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.RegraValidação = Nothing
        Me.txtFornecedor.RegraValidaçãoMensagem = Nothing
        Me.txtFornecedor.Size = New System.Drawing.Size(263, 20)
        Me.txtFornecedor.TabIndex = 0
        Me.txtFornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtFornecedor.ValorPadrao = Nothing
        '
        'Fornecedor
        '
        Me.Fornecedor.AutoSize = True
        Me.Fornecedor.Location = New System.Drawing.Point(404, 17)
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.Size = New System.Drawing.Size(79, 17)
        Me.Fornecedor.TabIndex = 2
        Me.Fornecedor.Text = "Fornecedor"
        Me.Fornecedor.UseVisualStyleBackColor = True
        '
        'MostraTodos
        '
        Me.MostraTodos.AutoSize = True
        Me.MostraTodos.Location = New System.Drawing.Point(506, 17)
        Me.MostraTodos.Name = "MostraTodos"
        Me.MostraTodos.Size = New System.Drawing.Size(93, 17)
        Me.MostraTodos.TabIndex = 3
        Me.MostraTodos.Text = "Mostrar Todos"
        Me.MostraTodos.UseVisualStyleBackColor = True
        '
        'CampoChave
        '
        Me.CampoChave.AutoSize = True
        Me.CampoChave.Location = New System.Drawing.Point(297, 17)
        Me.CampoChave.Name = "CampoChave"
        Me.CampoChave.Size = New System.Drawing.Size(92, 17)
        Me.CampoChave.TabIndex = 1
        Me.CampoChave.Text = "Campo Chave"
        Me.CampoChave.UseVisualStyleBackColor = True
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.ItemFornecedor, Me.ItemData, Me.itemValor})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.Location = New System.Drawing.Point(12, 75)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(601, 256)
        Me.DgvItem.TabIndex = 2
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ID"
        Me.Column2.HeaderText = "Cod Gerenc."
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'ItemFornecedor
        '
        Me.ItemFornecedor.DataPropertyName = "RazãoSocial"
        Me.ItemFornecedor.HeaderText = "Nome do Fornecedor"
        Me.ItemFornecedor.Name = "ItemFornecedor"
        Me.ItemFornecedor.Width = 280
        '
        'ItemData
        '
        Me.ItemData.DataPropertyName = "DataLancamento"
        Me.ItemData.HeaderText = "Data Lanç."
        Me.ItemData.Name = "ItemData"
        Me.ItemData.Width = 90
        '
        'itemValor
        '
        Me.itemValor.DataPropertyName = "Total"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.itemValor.DefaultCellStyle = DataGridViewCellStyle2
        Me.itemValor.HeaderText = "Valor"
        Me.itemValor.Name = "itemValor"
        Me.itemValor.Width = 110
        '
        'ProcuraGerenciador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 390)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ProcuraGerenciador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar Gerenciador"
        Me.PanelEx1.ResumeLayout(False)
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TipoProcura As System.Windows.Forms.GroupBox
    Friend WithEvents txtFornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fornecedor As System.Windows.Forms.RadioButton
    Friend WithEvents MostraTodos As System.Windows.Forms.RadioButton
    Friend WithEvents CampoChave As System.Windows.Forms.RadioButton
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemValor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
