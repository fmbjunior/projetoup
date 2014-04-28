<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraProcurar
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompraProcurar))
        Me.Fornecedor = New System.Windows.Forms.RadioButton()
        Me.NotaFiscal = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProcura = New System.Windows.Forms.TextBox()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Confirmado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Inativo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImgCanc = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ImgConf = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ImgEdd = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TipoProcura = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TodasDia = New System.Windows.Forms.RadioButton()
        Me.MostrarTodos = New System.Windows.Forms.RadioButton()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipoProcura.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fornecedor
        '
        Me.Fornecedor.AutoSize = True
        Me.Fornecedor.Checked = True
        Me.Fornecedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fornecedor.Location = New System.Drawing.Point(92, -1)
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.Size = New System.Drawing.Size(83, 19)
        Me.Fornecedor.TabIndex = 1
        Me.Fornecedor.TabStop = True
        Me.Fornecedor.Text = "Fornecedor"
        Me.Fornecedor.UseVisualStyleBackColor = True
        '
        'NotaFiscal
        '
        Me.NotaFiscal.AutoSize = True
        Me.NotaFiscal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaFiscal.Location = New System.Drawing.Point(3, -1)
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.Size = New System.Drawing.Size(83, 19)
        Me.NotaFiscal.TabIndex = 0
        Me.NotaFiscal.Text = "Nota Fiscal"
        Me.NotaFiscal.UseVisualStyleBackColor = True
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
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Controls.Add(Me.TipoProcura)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(820, 627)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Img, Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4, Me.Column6, Me.Confirmado, Me.Inativo, Me.Column8, Me.ImgCanc, Me.ImgConf, Me.ImgEdd})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle3
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(14, 88)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersVisible = False
        Me.Lista.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(794, 527)
        Me.Lista.TabIndex = 1
        '
        'Img
        '
        Me.Img.HeaderText = ""
        Me.Img.Name = "Img"
        Me.Img.ReadOnly = True
        Me.Img.Width = 30
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CompraInterno"
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NotaFiscal"
        Me.Column2.HeaderText = "NF"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 90
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ValorCompra"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column5.HeaderText = "Valor Compra"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "RazãoSocial"
        Me.Column3.HeaderText = "Razão Social"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 290
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Tipo"
        Me.Column4.HeaderText = "Tipo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 60
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "DataCompra"
        Me.Column6.HeaderText = "Data Compra"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Confirmado
        '
        Me.Confirmado.DataPropertyName = "Confirmado"
        Me.Confirmado.HeaderText = "Confirmado"
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.ReadOnly = True
        Me.Confirmado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Confirmado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Confirmado.Width = 80
        '
        'Inativo
        '
        Me.Inativo.DataPropertyName = "Inativo"
        Me.Inativo.HeaderText = "Inativo"
        Me.Inativo.Name = "Inativo"
        Me.Inativo.ReadOnly = True
        Me.Inativo.Visible = False
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Empresa"
        Me.Column8.HeaderText = "Empresa"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'ImgCanc
        '
        Me.ImgCanc.HeaderText = ""
        Me.ImgCanc.Image = CType(resources.GetObject("ImgCanc.Image"), System.Drawing.Image)
        Me.ImgCanc.Name = "ImgCanc"
        Me.ImgCanc.ReadOnly = True
        Me.ImgCanc.Visible = False
        '
        'ImgConf
        '
        Me.ImgConf.HeaderText = ""
        Me.ImgConf.Image = CType(resources.GetObject("ImgConf.Image"), System.Drawing.Image)
        Me.ImgConf.Name = "ImgConf"
        Me.ImgConf.ReadOnly = True
        Me.ImgConf.Visible = False
        '
        'ImgEdd
        '
        Me.ImgEdd.HeaderText = ""
        Me.ImgEdd.Image = CType(resources.GetObject("ImgEdd.Image"), System.Drawing.Image)
        Me.ImgEdd.Name = "ImgEdd"
        Me.ImgEdd.ReadOnly = True
        Me.ImgEdd.Visible = False
        '
        'TipoProcura
        '
        Me.TipoProcura.CanvasColor = System.Drawing.SystemColors.Control
        Me.TipoProcura.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.TipoProcura.Controls.Add(Me.TodasDia)
        Me.TipoProcura.Controls.Add(Me.TxtProcura)
        Me.TipoProcura.Controls.Add(Me.MostrarTodos)
        Me.TipoProcura.Controls.Add(Me.Fechar)
        Me.TipoProcura.Controls.Add(Me.Label1)
        Me.TipoProcura.Controls.Add(Me.Fornecedor)
        Me.TipoProcura.Controls.Add(Me.NotaFiscal)
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
        'TodasDia
        '
        Me.TodasDia.AutoSize = True
        Me.TodasDia.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodasDia.Location = New System.Drawing.Point(296, 1)
        Me.TodasDia.Name = "TodasDia"
        Me.TodasDia.Size = New System.Drawing.Size(91, 19)
        Me.TodasDia.TabIndex = 6
        Me.TodasDia.Text = "Todos do Dia"
        Me.TodasDia.UseVisualStyleBackColor = True
        '
        'MostrarTodos
        '
        Me.MostrarTodos.AutoSize = True
        Me.MostrarTodos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarTodos.Location = New System.Drawing.Point(181, -1)
        Me.MostrarTodos.Name = "MostrarTodos"
        Me.MostrarTodos.Size = New System.Drawing.Size(99, 19)
        Me.MostrarTodos.TabIndex = 2
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
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'CompraProcurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(820, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CompraProcurar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar Compra - T125"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fornecedor As System.Windows.Forms.RadioButton
    Friend WithEvents NotaFiscal As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TipoProcura As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Confirmado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Inativo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImgCanc As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ImgConf As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ImgEdd As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TodasDia As System.Windows.Forms.RadioButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
