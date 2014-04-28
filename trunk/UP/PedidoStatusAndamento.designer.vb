<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoStatusAndamento
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.TotalRegistro = New System.Windows.Forms.Label()
        Me.MyLista = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.controle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btGerarVisualizacao = New DevComponents.DotNetBar.ButtonX()
        Me.btImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.PainelData = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataB = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataA = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.O3 = New System.Windows.Forms.RadioButton()
        Me.O2 = New System.Windows.Forms.RadioButton()
        Me.O1 = New System.Windows.Forms.RadioButton()
        Me.MyBarra = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.btAtualizaAndamento = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        CType(Me.MyLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.PainelData.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.TotalRegistro)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.btGerarVisualizacao)
        Me.Fundo.Controls.Add(Me.btImprimir)
        Me.Fundo.Controls.Add(Me.GroupPanel2)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.MyBarra)
        Me.Fundo.Controls.Add(Me.btAtualizaAndamento)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(814, 543)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'TotalRegistro
        '
        Me.TotalRegistro.Location = New System.Drawing.Point(12, 514)
        Me.TotalRegistro.Name = "TotalRegistro"
        Me.TotalRegistro.Size = New System.Drawing.Size(226, 20)
        Me.TotalRegistro.TabIndex = 69
        Me.TotalRegistro.Text = "Total de Registro : 0"
        Me.TotalRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MyLista
        '
        Me.MyLista.AllowUserToAddRows = False
        Me.MyLista.AllowUserToDeleteRows = False
        Me.MyLista.AllowUserToResizeColumns = False
        Me.MyLista.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MyLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.controle, Me.Column2, Me.Column3, Me.Column5, Me.Column4})
        Me.MyLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MyLista.Location = New System.Drawing.Point(12, 111)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.ReadOnly = True
        Me.MyLista.RowHeadersVisible = False
        Me.MyLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyLista.Size = New System.Drawing.Size(790, 396)
        Me.MyLista.TabIndex = 68
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "PedidoSequencia"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "0000"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Pedido"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'controle
        '
        Me.controle.DataPropertyName = "requisicao"
        Me.controle.HeaderText = "N. Controle"
        Me.controle.Name = "controle"
        Me.controle.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Nome"
        Me.Column2.HeaderText = "Cliente"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "TotalPedido"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Total"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "DataPedido"
        Me.Column5.HeaderText = "Data Pedido"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "StatusAndamentos"
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'btGerarVisualizacao
        '
        Me.btGerarVisualizacao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGerarVisualizacao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGerarVisualizacao.Location = New System.Drawing.Point(12, 77)
        Me.btGerarVisualizacao.Name = "btGerarVisualizacao"
        Me.btGerarVisualizacao.Size = New System.Drawing.Size(122, 28)
        Me.btGerarVisualizacao.TabIndex = 7
        Me.btGerarVisualizacao.Text = "Gerar Visualização"
        '
        'btImprimir
        '
        Me.btImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImprimir.Location = New System.Drawing.Point(140, 77)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(128, 28)
        Me.btImprimir.TabIndex = 3
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.Visible = False
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.A3)
        Me.GroupPanel2.Controls.Add(Me.PainelData)
        Me.GroupPanel2.Controls.Add(Me.A2)
        Me.GroupPanel2.Controls.Add(Me.A1)
        Me.GroupPanel2.Location = New System.Drawing.Point(274, 4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(528, 70)
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
        Me.GroupPanel2.Text = "Opção do Status"
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(150, 15)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(59, 20)
        Me.A3.TabIndex = 3
        Me.A3.Text = "Pedido"
        Me.A3.UseVisualStyleBackColor = True
        '
        'PainelData
        '
        Me.PainelData.CanvasColor = System.Drawing.SystemColors.Control
        Me.PainelData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PainelData.Controls.Add(Me.Label1)
        Me.PainelData.Controls.Add(Me.DataB)
        Me.PainelData.Controls.Add(Me.Label6)
        Me.PainelData.Controls.Add(Me.DataA)
        Me.PainelData.Location = New System.Drawing.Point(373, 0)
        Me.PainelData.Name = "PainelData"
        Me.PainelData.Size = New System.Drawing.Size(146, 47)
        Me.PainelData.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PainelData.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PainelData.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PainelData.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PainelData.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PainelData.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PainelData.Style.GradientAngle = 90
        Me.PainelData.TabIndex = 2
        Me.PainelData.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dt. Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataB
        '
        Me.DataB.AceitaColarTexto = True
        Me.DataB.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataB.CasasDecimais = 0
        Me.DataB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataB.CPObrigatorio = False
        Me.DataB.CPObrigatorioMsg = Nothing
        Me.DataB.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataB.FlatBorder = False
        Me.DataB.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataB.FocusColor = System.Drawing.Color.MistyRose
        Me.DataB.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataB.HighlightBorderOnEnter = False
        Me.DataB.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataB.Location = New System.Drawing.Point(66, 24)
        Me.DataB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataB.MaxLength = 10
        Me.DataB.Name = "DataB"
        Me.DataB.PreencherZeroEsqueda = False
        Me.DataB.RegraValidação = Nothing
        Me.DataB.RegraValidaçãoMensagem = Nothing
        Me.DataB.Size = New System.Drawing.Size(77, 20)
        Me.DataB.TabIndex = 3
        Me.DataB.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataB.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Dt. Inicial"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataA
        '
        Me.DataA.AceitaColarTexto = True
        Me.DataA.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataA.CasasDecimais = 0
        Me.DataA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataA.CPObrigatorio = False
        Me.DataA.CPObrigatorioMsg = Nothing
        Me.DataA.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataA.FlatBorder = False
        Me.DataA.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataA.FocusColor = System.Drawing.Color.MistyRose
        Me.DataA.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataA.HighlightBorderOnEnter = False
        Me.DataA.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataA.Location = New System.Drawing.Point(66, 3)
        Me.DataA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataA.MaxLength = 10
        Me.DataA.Name = "DataA"
        Me.DataA.PreencherZeroEsqueda = False
        Me.DataA.RegraValidação = Nothing
        Me.DataA.RegraValidaçãoMensagem = Nothing
        Me.DataA.Size = New System.Drawing.Size(77, 20)
        Me.DataA.TabIndex = 1
        Me.DataA.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataA.ValorPadrao = Nothing
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(64, 15)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(80, 20)
        Me.A2.TabIndex = 1
        Me.A2.Text = "No Período"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Checked = True
        Me.A1.Location = New System.Drawing.Point(3, 15)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(55, 20)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Todos"
        Me.A1.UseVisualStyleBackColor = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.O3)
        Me.GroupPanel1.Controls.Add(Me.O2)
        Me.GroupPanel1.Controls.Add(Me.O1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(256, 70)
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
        Me.GroupPanel1.Text = "Selecione o Status"
        '
        'O3
        '
        Me.O3.AutoSize = True
        Me.O3.Location = New System.Drawing.Point(168, 15)
        Me.O3.Name = "O3"
        Me.O3.Size = New System.Drawing.Size(76, 20)
        Me.O3.TabIndex = 2
        Me.O3.Text = "Finalizado"
        Me.O3.UseVisualStyleBackColor = True
        '
        'O2
        '
        Me.O2.AutoSize = True
        Me.O2.Checked = True
        Me.O2.Location = New System.Drawing.Point(65, 15)
        Me.O2.Name = "O2"
        Me.O2.Size = New System.Drawing.Size(98, 20)
        Me.O2.TabIndex = 1
        Me.O2.TabStop = True
        Me.O2.Text = "Em Andamento"
        Me.O2.UseVisualStyleBackColor = True
        '
        'O1
        '
        Me.O1.AutoSize = True
        Me.O1.Location = New System.Drawing.Point(3, 15)
        Me.O1.Name = "O1"
        Me.O1.Size = New System.Drawing.Size(56, 20)
        Me.O1.TabIndex = 0
        Me.O1.Text = "Inicial"
        Me.O1.UseVisualStyleBackColor = True
        '
        'MyBarra
        '
        '
        '
        '
        Me.MyBarra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MyBarra.Location = New System.Drawing.Point(244, 513)
        Me.MyBarra.Name = "MyBarra"
        Me.MyBarra.Size = New System.Drawing.Size(484, 27)
        Me.MyBarra.TabIndex = 5
        Me.MyBarra.Visible = False
        '
        'btAtualizaAndamento
        '
        Me.btAtualizaAndamento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizaAndamento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizaAndamento.Location = New System.Drawing.Point(553, 77)
        Me.btAtualizaAndamento.Name = "btAtualizaAndamento"
        Me.btAtualizaAndamento.Size = New System.Drawing.Size(122, 28)
        Me.btAtualizaAndamento.TabIndex = 4
        Me.btAtualizaAndamento.Text = "Atualizar Andamento"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(681, 77)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(121, 28)
        Me.btFechar.TabIndex = 6
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'PedidoStatusAndamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PedidoStatusAndamento"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Andamento de Pedido - T176"
        Me.Fundo.ResumeLayout(False)
        CType(Me.MyLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.PainelData.ResumeLayout(False)
        Me.PainelData.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAtualizaAndamento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MyBarra As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents O3 As System.Windows.Forms.RadioButton
    Friend WithEvents O2 As System.Windows.Forms.RadioButton
    Friend WithEvents O1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelData As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DataB As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataA As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btGerarVisualizacao As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MyLista As System.Windows.Forms.DataGridView
    Friend WithEvents TotalRegistro As System.Windows.Forms.Label
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents controle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
