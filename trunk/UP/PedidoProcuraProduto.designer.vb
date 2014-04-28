<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoProcuraProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoProcuraProduto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btLimparFiltro = New DevComponents.DotNetBar.ButtonX()
        Me.lbldescProd = New System.Windows.Forms.Label()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codOr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoFabrica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodBarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Local = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gmarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorvenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.greferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pMarca = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pDescricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btLimparFiltro)
        Me.PanelEx1.Controls.Add(Me.lbldescProd)
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.lblMensagem)
        Me.PanelEx1.Controls.Add(Me.lblRef)
        Me.PanelEx1.Controls.Add(Me.DgvItem)
        Me.PanelEx1.Controls.Add(Me.pMarca)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.pDescricao)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1005, 615)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btLimparFiltro
        '
        Me.btLimparFiltro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLimparFiltro.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLimparFiltro.Image = CType(resources.GetObject("btLimparFiltro.Image"), System.Drawing.Image)
        Me.btLimparFiltro.Location = New System.Drawing.Point(972, 580)
        Me.btLimparFiltro.Name = "btLimparFiltro"
        Me.btLimparFiltro.Size = New System.Drawing.Size(27, 23)
        Me.btLimparFiltro.TabIndex = 8
        Me.btLimparFiltro.TabStop = False
        '
        'lbldescProd
        '
        Me.lbldescProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescProd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbldescProd.Location = New System.Drawing.Point(12, 578)
        Me.lbldescProd.Name = "lbldescProd"
        Me.lbldescProd.Size = New System.Drawing.Size(650, 33)
        Me.lbldescProd.TabIndex = 7
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(924, 12)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(69, 23)
        Me.ButtonX2.TabIndex = 9
        Me.ButtonX2.TabStop = False
        Me.ButtonX2.Text = "Fechar"
        '
        'lblMensagem
        '
        Me.lblMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.Location = New System.Drawing.Point(653, 578)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(306, 33)
        Me.lblMensagem.TabIndex = 6
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRef.Location = New System.Drawing.Point(653, 578)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(41, 23)
        Me.lblRef.TabIndex = 2
        Me.lblRef.Text = "Ref."
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.AllowUserToResizeColumns = False
        Me.DgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItem.BackgroundColor = System.Drawing.Color.White
        Me.DgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.codOr, Me.CodigoFabrica, Me.CodBarra, Me.Desc, Me.unidade, Me.Local, Me.gmarca, Me.estoque, Me.Column1, Me.valorvenda, Me.greferencia, Me.tipo})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.Location = New System.Drawing.Point(3, 42)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(996, 533)
        Me.DgvItem.TabIndex = 4
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "CodigoProduto"
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 50
        '
        'codOr
        '
        Me.codOr.DataPropertyName = "CodigoOriginal"
        Me.codOr.HeaderText = "Cod. Original"
        Me.codOr.Name = "codOr"
        Me.codOr.Width = 80
        '
        'CodigoFabrica
        '
        Me.CodigoFabrica.DataPropertyName = "CodigoFabrica"
        Me.CodigoFabrica.HeaderText = "Cod. Fábrica"
        Me.CodigoFabrica.Name = "CodigoFabrica"
        Me.CodigoFabrica.Width = 90
        '
        'CodBarra
        '
        Me.CodBarra.DataPropertyName = "CodigoBarra"
        Me.CodBarra.HeaderText = "CodBarra"
        Me.CodBarra.Name = "CodBarra"
        '
        'Desc
        '
        Me.Desc.DataPropertyName = "Descrição"
        Me.Desc.HeaderText = "Descrição"
        Me.Desc.Name = "Desc"
        Me.Desc.Width = 220
        '
        'unidade
        '
        Me.unidade.DataPropertyName = "UnidadeMedida"
        Me.unidade.HeaderText = "Un"
        Me.unidade.Name = "unidade"
        Me.unidade.Width = 30
        '
        'Local
        '
        Me.Local.DataPropertyName = "SetorLocalDesc"
        DataGridViewCellStyle2.NullValue = "Não Locado"
        Me.Local.DefaultCellStyle = DataGridViewCellStyle2
        Me.Local.HeaderText = "Local"
        Me.Local.MaxInputLength = 20
        Me.Local.Name = "Local"
        Me.Local.Width = 70
        '
        'gmarca
        '
        Me.gmarca.DataPropertyName = "Marca"
        Me.gmarca.HeaderText = "Marca"
        Me.gmarca.Name = "gmarca"
        '
        'estoque
        '
        Me.estoque.DataPropertyName = "QuantidadeEstoque"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = "0,0000"
        Me.estoque.DefaultCellStyle = DataGridViewCellStyle3
        Me.estoque.HeaderText = "Estoque"
        Me.estoque.Name = "estoque"
        Me.estoque.Width = 90
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "EstDeposito"
        Me.Column1.HeaderText = "Depósito"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'valorvenda
        '
        Me.valorvenda.DataPropertyName = "ValorVenda"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0,00"
        Me.valorvenda.DefaultCellStyle = DataGridViewCellStyle4
        Me.valorvenda.HeaderText = "Vlr Venda"
        Me.valorvenda.Name = "valorvenda"
        Me.valorvenda.Width = 75
        '
        'greferencia
        '
        Me.greferencia.DataPropertyName = "referencia"
        Me.greferencia.HeaderText = "Referencia"
        Me.greferencia.Name = "greferencia"
        Me.greferencia.Visible = False
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "TP"
        Me.tipo.FillWeight = 90.0!
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.Visible = False
        Me.tipo.Width = 80
        '
        'pMarca
        '
        Me.pMarca.AceitaColarTexto = True
        Me.pMarca.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.pMarca.CasasDecimais = 2
        Me.pMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pMarca.CPObrigatorio = False
        Me.pMarca.CPObrigatorioMsg = Nothing
        Me.pMarca.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.pMarca.FlatBorder = False
        Me.pMarca.FlatBorderColor = System.Drawing.Color.DimGray
        Me.pMarca.FocusColor = System.Drawing.Color.Empty
        Me.pMarca.FocusColorEnd = System.Drawing.Color.Empty
        Me.pMarca.HighlightBorderOnEnter = False
        Me.pMarca.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.pMarca.Location = New System.Drawing.Point(90, 12)
        Me.pMarca.Name = "pMarca"
        Me.pMarca.PreencherZeroEsqueda = False
        Me.pMarca.RegraValidação = Nothing
        Me.pMarca.RegraValidaçãoMensagem = Nothing
        Me.pMarca.Size = New System.Drawing.Size(312, 23)
        Me.pMarca.TabIndex = 1
        Me.pMarca.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.pMarca.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(424, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descrição"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pDescricao
        '
        Me.pDescricao.AceitaColarTexto = True
        Me.pDescricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.pDescricao.CasasDecimais = 2
        Me.pDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pDescricao.CPObrigatorio = False
        Me.pDescricao.CPObrigatorioMsg = Nothing
        Me.pDescricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.pDescricao.FlatBorder = False
        Me.pDescricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.pDescricao.FocusColor = System.Drawing.Color.Empty
        Me.pDescricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.pDescricao.HighlightBorderOnEnter = False
        Me.pDescricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.pDescricao.Location = New System.Drawing.Point(509, 9)
        Me.pDescricao.Name = "pDescricao"
        Me.pDescricao.PreencherZeroEsqueda = False
        Me.pDescricao.RegraValidação = Nothing
        Me.pDescricao.RegraValidaçãoMensagem = Nothing
        Me.pDescricao.Size = New System.Drawing.Size(312, 23)
        Me.pDescricao.TabIndex = 3
        Me.pDescricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.pDescricao.ValorPadrao = Nothing
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'PedidoProcuraProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 615)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Name = "PedidoProcuraProduto"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar de Produtos - T172"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents lbldescProd As System.Windows.Forms.Label
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codOr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFabrica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Local As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gmarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estoque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valorvenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents greferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pMarca As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pDescricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btLimparFiltro As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
