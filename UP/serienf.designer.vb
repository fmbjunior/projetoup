<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerieNf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SerieNf))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Descricao = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Codigo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Editar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Sigla = New TexBoxFocusNet.TextBoxFocusNet
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.A3 = New System.Windows.Forms.RadioButton
        Me.A1 = New System.Windows.Forms.RadioButton
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet
        Me.A2 = New System.Windows.Forms.RadioButton
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.btNovo = New System.Windows.Forms.ToolStripButton
        Me.btSalvar = New System.Windows.Forms.ToolStripButton
        Me.btEditar = New System.Windows.Forms.ToolStripButton
        Me.btExcluir = New System.Windows.Forms.ToolStripButton
        Me.btFechar = New System.Windows.Forms.ToolStripButton
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraBt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Descri��o"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Descricao
        '
        Me.Descricao.AcceptsTab = True
        Me.Descricao.AceitaColarTexto = True
        Me.Descricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Descricao.CasasDecimais = 0
        Me.Descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descricao.CPObrigatorio = False
        Me.Descricao.CPObrigatorioMsg = Nothing
        Me.Descricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Descricao.FocusColor = System.Drawing.Color.Empty
        Me.Descricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descricao.Location = New System.Drawing.Point(142, 110)
        Me.Descricao.MaxLength = 30
        Me.Descricao.Name = "Descricao"
        Me.Descricao.RegraValida��o = Nothing
        Me.Descricao.RegraValida��oMensagem = Nothing
        Me.Descricao.Size = New System.Drawing.Size(374, 23)
        Me.Descricao.TabIndex = 73
        Me.Descricao.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descricao.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "C�digo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Codigo
        '
        Me.Codigo.AceitaColarTexto = True
        Me.Codigo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Codigo.CasasDecimais = 0
        Me.Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Codigo.CPObrigatorio = False
        Me.Codigo.CPObrigatorioMsg = Nothing
        Me.Codigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Codigo.FocusColor = System.Drawing.Color.Empty
        Me.Codigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Codigo.Location = New System.Drawing.Point(142, 81)
        Me.Codigo.MaxLength = 10
        Me.Codigo.Name = "Codigo"
        Me.Codigo.RegraValida��o = Nothing
        Me.Codigo.RegraValida��oMensagem = Nothing
        Me.Codigo.Size = New System.Drawing.Size(116, 23)
        Me.Codigo.TabIndex = 71
        Me.Codigo.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Codigo.ValorPadrao = Nothing
        '
        'Editar
        '
        Me.Editar.Image = Global.Up.My.Resources.Resources.Editar
        Me.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar.Location = New System.Drawing.Point(-161, 118)
        Me.Editar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(104, 35)
        Me.Editar.TabIndex = 65
        Me.Editar.Text = "Editar"
        Me.Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Sigla"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sigla
        '
        Me.Sigla.AceitaColarTexto = True
        Me.Sigla.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Sigla.CasasDecimais = 0
        Me.Sigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Sigla.CPObrigatorio = False
        Me.Sigla.CPObrigatorioMsg = Nothing
        Me.Sigla.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Sigla.FocusColor = System.Drawing.Color.Empty
        Me.Sigla.FocusColorEnd = System.Drawing.Color.Empty
        Me.Sigla.Location = New System.Drawing.Point(142, 139)
        Me.Sigla.MaxLength = 3
        Me.Sigla.Name = "Sigla"
        Me.Sigla.RegraValida��o = Nothing
        Me.Sigla.RegraValida��oMensagem = Nothing
        Me.Sigla.Size = New System.Drawing.Size(49, 23)
        Me.Sigla.TabIndex = 75
        Me.Sigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sigla.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Sigla.ValorPadrao = Nothing
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.BarraBt)
        Me.PanelEx1.Controls.Add(Me.Codigo)
        Me.PanelEx1.Controls.Add(Me.Editar)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Sigla)
        Me.PanelEx1.Controls.Add(Me.Descricao)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(524, 426)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 76
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.TxtProcura)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.Lista)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 168)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(503, 246)
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
        Me.GroupPanel1.TabIndex = 78
        Me.GroupPanel1.Text = "Procura de S�rie de Nota Fiscal"
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(152, 166)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(55, 19)
        Me.A3.TabIndex = 81
        Me.A3.TabStop = True
        Me.A3.Text = "Todos"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 166)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(60, 19)
        Me.A1.TabIndex = 80
        Me.A1.TabStop = True
        Me.A1.Text = "C�digo"
        Me.A1.UseVisualStyleBackColor = True
        '
        'TxtProcura
        '
        Me.TxtProcura.AceitaColarTexto = True
        Me.TxtProcura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.TxtProcura.CasasDecimais = 0
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.CPObrigatorio = False
        Me.TxtProcura.CPObrigatorioMsg = Nothing
        Me.TxtProcura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.TxtProcura.FocusColor = System.Drawing.Color.Empty
        Me.TxtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.TxtProcura.Location = New System.Drawing.Point(3, 191)
        Me.TxtProcura.MaxLength = 30
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.RegraValida��o = Nothing
        Me.TxtProcura.RegraValida��oMensagem = Nothing
        Me.TxtProcura.Size = New System.Drawing.Size(491, 23)
        Me.TxtProcura.TabIndex = 79
        Me.TxtProcura.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(69, 166)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(77, 19)
        Me.A2.TabIndex = 78
        Me.A2.TabStop = True
        Me.A2.Text = "Descri��o"
        Me.A2.UseVisualStyleBackColor = True
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(3, 2)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(491, 158)
        Me.Lista.TabIndex = 76
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNovo, Me.btSalvar, Me.btEditar, Me.btExcluir, Me.btFechar})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(524, 58)
        Me.BarraBt.TabIndex = 76
        Me.BarraBt.Text = "ToolStrip1"
        '
        'btNovo
        '
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(40, 55)
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btSalvar
        '
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(45, 55)
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btEditar
        '
        Me.btEditar.Image = CType(resources.GetObject("btEditar.Image"), System.Drawing.Image)
        Me.btEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(43, 55)
        Me.btEditar.Text = "Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btExcluir
        '
        Me.btExcluir.Image = CType(resources.GetObject("btExcluir.Image"), System.Drawing.Image)
        Me.btExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(49, 55)
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btFechar
        '
        Me.btFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(46, 55)
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codigo"
        Me.Column1.HeaderText = "C�digo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Descricao"
        Me.Column2.HeaderText = "Descri��o"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Sigla"
        Me.Column3.HeaderText = "Sigla"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 90
        '
        'SerieNf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(524, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SerieNf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Series de Nota Fiscal"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Descricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Codigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Sigla As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents btNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
