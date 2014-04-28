<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesPedidoCompraProcurar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellShoesPedidoCompraProcurar))
        Me.Fornecedor = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProcura = New System.Windows.Forms.TextBox()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lista = New System.Windows.Forms.DataGridView()
        Me.IDp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cRazaoSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gConfirmado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gPosicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gCancelado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoProcura = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.MostrarTodos = New System.Windows.Forms.RadioButton()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.PedidoCompra = New System.Windows.Forms.RadioButton()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipoProcura.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fornecedor
        '
        Me.Fornecedor.AutoSize = True
        Me.Fornecedor.Checked = True
        Me.Fornecedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fornecedor.Location = New System.Drawing.Point(118, 1)
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.Size = New System.Drawing.Size(83, 19)
        Me.Fornecedor.TabIndex = 2
        Me.Fornecedor.TabStop = True
        Me.Fornecedor.Text = "Fornecedor"
        Me.Fornecedor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Procurar"
        '
        'TxtProcura
        '
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcura.Location = New System.Drawing.Point(61, 27)
        Me.TxtProcura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.Size = New System.Drawing.Size(635, 23)
        Me.TxtProcura.TabIndex = 4
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.lista)
        Me.PanelEx1.Controls.Add(Me.TipoProcura)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(820, 441)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'lista
        '
        Me.lista.AllowUserToAddRows = False
        Me.lista.AllowUserToDeleteRows = False
        Me.lista.AllowUserToResizeColumns = False
        Me.lista.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.lista.BackgroundColor = System.Drawing.Color.White
        Me.lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDp, Me.cRazaoSocial, Me.Column1, Me.Column2, Me.Column3, Me.gStatus, Me.gConfirmado, Me.gPosicao, Me.gCancelado})
        Me.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lista.Location = New System.Drawing.Point(12, 88)
        Me.lista.MultiSelect = False
        Me.lista.Name = "lista"
        Me.lista.ReadOnly = True
        Me.lista.RowHeadersVisible = False
        Me.lista.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lista.Size = New System.Drawing.Size(796, 343)
        Me.lista.TabIndex = 1
        '
        'IDp
        '
        Me.IDp.DataPropertyName = "CodigoPedidoCompra"
        DataGridViewCellStyle2.Format = "00000"
        Me.IDp.DefaultCellStyle = DataGridViewCellStyle2
        Me.IDp.HeaderText = "Pedido Nº"
        Me.IDp.Name = "IDp"
        Me.IDp.ReadOnly = True
        Me.IDp.Width = 70
        '
        'cRazaoSocial
        '
        Me.cRazaoSocial.DataPropertyName = "razãosocial"
        Me.cRazaoSocial.HeaderText = "Razão Social"
        Me.cRazaoSocial.Name = "cRazaoSocial"
        Me.cRazaoSocial.ReadOnly = True
        Me.cRazaoSocial.Width = 250
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "datalancamento"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "d"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Data Lanç."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "dataprevistaentrega"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "Dta. Prevista"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "totalpedidocompra"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "c2"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.HeaderText = "Valor Pedido"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'gStatus
        '
        Me.gStatus.HeaderText = "Status"
        Me.gStatus.Name = "gStatus"
        Me.gStatus.ReadOnly = True
        '
        'gConfirmado
        '
        Me.gConfirmado.DataPropertyName = "confirmado"
        Me.gConfirmado.HeaderText = "con"
        Me.gConfirmado.Name = "gConfirmado"
        Me.gConfirmado.ReadOnly = True
        Me.gConfirmado.Visible = False
        '
        'gPosicao
        '
        Me.gPosicao.DataPropertyName = "Status"
        Me.gPosicao.HeaderText = "Pos. Pedido"
        Me.gPosicao.Name = "gPosicao"
        Me.gPosicao.ReadOnly = True
        Me.gPosicao.ToolTipText = "Posição do Pedido"
        Me.gPosicao.Width = 120
        '
        'gCancelado
        '
        Me.gCancelado.DataPropertyName = "inativo"
        Me.gCancelado.HeaderText = "inativo"
        Me.gCancelado.Name = "gCancelado"
        Me.gCancelado.ReadOnly = True
        Me.gCancelado.Visible = False
        '
        'TipoProcura
        '
        Me.TipoProcura.CanvasColor = System.Drawing.SystemColors.Control
        Me.TipoProcura.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.TipoProcura.Controls.Add(Me.TxtProcura)
        Me.TipoProcura.Controls.Add(Me.MostrarTodos)
        Me.TipoProcura.Controls.Add(Me.Fechar)
        Me.TipoProcura.Controls.Add(Me.Label1)
        Me.TipoProcura.Controls.Add(Me.Fornecedor)
        Me.TipoProcura.Controls.Add(Me.PedidoCompra)
        Me.TipoProcura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoProcura.Location = New System.Drawing.Point(17, 7)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(791, 75)
        '
        '
        '
        Me.TipoProcura.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TipoProcura.Style.BackColorGradientAngle = 90
        Me.TipoProcura.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TipoProcura.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TipoProcura.Style.BorderBottomWidth = 1
        Me.TipoProcura.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.TipoProcura.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TipoProcura.Style.BorderLeftWidth = 1
        Me.TipoProcura.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TipoProcura.Style.BorderRightWidth = 1
        Me.TipoProcura.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TipoProcura.Style.BorderTopWidth = 1
        Me.TipoProcura.Style.CornerDiameter = 4
        Me.TipoProcura.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TipoProcura.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.TipoProcura.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.TipoProcura.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.TipoProcura.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.TipoProcura.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TipoProcura.TabIndex = 0
        Me.TipoProcura.Text = "Critérios"
        '
        'MostrarTodos
        '
        Me.MostrarTodos.AutoSize = True
        Me.MostrarTodos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarTodos.Location = New System.Drawing.Point(218, -1)
        Me.MostrarTodos.Name = "MostrarTodos"
        Me.MostrarTodos.Size = New System.Drawing.Size(99, 19)
        Me.MostrarTodos.TabIndex = 1
        Me.MostrarTodos.Text = "Mostrar Todos"
        Me.MostrarTodos.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Location = New System.Drawing.Point(702, 26)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(80, 24)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar"
        '
        'PedidoCompra
        '
        Me.PedidoCompra.AutoSize = True
        Me.PedidoCompra.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PedidoCompra.Location = New System.Drawing.Point(3, -1)
        Me.PedidoCompra.Name = "PedidoCompra"
        Me.PedidoCompra.Size = New System.Drawing.Size(100, 19)
        Me.PedidoCompra.TabIndex = 0
        Me.PedidoCompra.Text = "Pedido Compra"
        Me.PedidoCompra.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Visible = False
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'SellShoesPedidoCompraProcurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(820, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SellShoesPedidoCompraProcurar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procuarar Pedido Compra"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fornecedor As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TipoProcura As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PedidoCompra As System.Windows.Forms.RadioButton
    Friend WithEvents lista As System.Windows.Forms.DataGridView
    Friend WithEvents IDp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRazaoSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gConfirmado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gPosicao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gCancelado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
