<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndustriaSubComposição
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.DescriçãoSubComposição = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.CodigoSubComposição = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.UM = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.ValorCusto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Ttotal = New System.Windows.Forms.Label
        Me.Tqtd = New System.Windows.Forms.Label
        Me.btDetalheFerragem = New DevComponents.DotNetBar.ButtonX
        Me.btLancaItens = New DevComponents.DotNetBar.ButtonX
        Me.MyLista = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btLocalizar = New DevComponents.DotNetBar.ButtonX
        Me.btEditar = New DevComponents.DotNetBar.ButtonX
        Me.btNovo = New DevComponents.DotNetBar.ButtonX
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.Fundo.SuspendLayout()
        CType(Me.MyLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descrição"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescriçãoSubComposição
        '
        Me.DescriçãoSubComposição.AceitaColarTexto = True
        Me.DescriçãoSubComposição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescriçãoSubComposição.CasasDecimais = 0
        Me.DescriçãoSubComposição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescriçãoSubComposição.CPObrigatorio = False
        Me.DescriçãoSubComposição.CPObrigatorioMsg = Nothing
        Me.DescriçãoSubComposição.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescriçãoSubComposição.FocusColor = System.Drawing.Color.MistyRose
        Me.DescriçãoSubComposição.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescriçãoSubComposição.Location = New System.Drawing.Point(137, 35)
        Me.DescriçãoSubComposição.MaxLength = 120
        Me.DescriçãoSubComposição.Name = "DescriçãoSubComposição"
        Me.DescriçãoSubComposição.RegraValidação = Nothing
        Me.DescriçãoSubComposição.RegraValidaçãoMensagem = Nothing
        Me.DescriçãoSubComposição.Size = New System.Drawing.Size(640, 20)
        Me.DescriçãoSubComposição.TabIndex = 7
        Me.DescriçãoSubComposição.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescriçãoSubComposição.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoSubComposição
        '
        Me.CodigoSubComposição.AceitaColarTexto = True
        Me.CodigoSubComposição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoSubComposição.CasasDecimais = 0
        Me.CodigoSubComposição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoSubComposição.CPObrigatorio = False
        Me.CodigoSubComposição.CPObrigatorioMsg = Nothing
        Me.CodigoSubComposição.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoSubComposição.FocusColor = System.Drawing.Color.MistyRose
        Me.CodigoSubComposição.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoSubComposição.Location = New System.Drawing.Point(137, 9)
        Me.CodigoSubComposição.MaxLength = 10
        Me.CodigoSubComposição.Name = "CodigoSubComposição"
        Me.CodigoSubComposição.RegraValidação = Nothing
        Me.CodigoSubComposição.RegraValidaçãoMensagem = Nothing
        Me.CodigoSubComposição.Size = New System.Drawing.Size(78, 20)
        Me.CodigoSubComposição.TabIndex = 5
        Me.CodigoSubComposição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoSubComposição.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoSubComposição.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Unidade Medida"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UM
        '
        Me.UM.AceitaColarTexto = True
        Me.UM.AutoCompleteCustomSource.AddRange(New String() {"UN", "M³"})
        Me.UM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.UM.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.UM.CasasDecimais = 0
        Me.UM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UM.CPObrigatorio = False
        Me.UM.CPObrigatorioMsg = Nothing
        Me.UM.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.UM.FocusColor = System.Drawing.Color.MistyRose
        Me.UM.FocusColorEnd = System.Drawing.Color.Empty
        Me.UM.Location = New System.Drawing.Point(137, 61)
        Me.UM.MaxLength = 10
        Me.UM.Name = "UM"
        Me.UM.RegraValidação = Nothing
        Me.UM.RegraValidaçãoMensagem = Nothing
        Me.UM.Size = New System.Drawing.Size(37, 20)
        Me.UM.TabIndex = 9
        Me.UM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UM.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UM.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(494, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Valor de Custo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'ValorCusto
        '
        Me.ValorCusto.AceitaColarTexto = True
        Me.ValorCusto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorCusto.CasasDecimais = 2
        Me.ValorCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorCusto.CPObrigatorio = False
        Me.ValorCusto.CPObrigatorioMsg = Nothing
        Me.ValorCusto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorCusto.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorCusto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorCusto.Location = New System.Drawing.Point(619, 61)
        Me.ValorCusto.MaxLength = 10
        Me.ValorCusto.Name = "ValorCusto"
        Me.ValorCusto.RegraValidação = Nothing
        Me.ValorCusto.RegraValidaçãoMensagem = Nothing
        Me.ValorCusto.Size = New System.Drawing.Size(158, 20)
        Me.ValorCusto.TabIndex = 11
        Me.ValorCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorCusto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorCusto.ValorPadrao = Nothing
        Me.ValorCusto.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Ttotal)
        Me.Fundo.Controls.Add(Me.Tqtd)
        Me.Fundo.Controls.Add(Me.btDetalheFerragem)
        Me.Fundo.Controls.Add(Me.btLancaItens)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.btLocalizar)
        Me.Fundo.Controls.Add(Me.btEditar)
        Me.Fundo.Controls.Add(Me.btNovo)
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.CodigoSubComposição)
        Me.Fundo.Controls.Add(Me.DescriçãoSubComposição)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.UM)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.ValorCusto)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(792, 506)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 29
        '
        'Ttotal
        '
        Me.Ttotal.BackColor = System.Drawing.Color.Transparent
        Me.Ttotal.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ttotal.Location = New System.Drawing.Point(567, 424)
        Me.Ttotal.Name = "Ttotal"
        Me.Ttotal.Size = New System.Drawing.Size(188, 20)
        Me.Ttotal.TabIndex = 73
        Me.Ttotal.Text = "0,00"
        Me.Ttotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tqtd
        '
        Me.Tqtd.BackColor = System.Drawing.Color.Transparent
        Me.Tqtd.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tqtd.Location = New System.Drawing.Point(318, 424)
        Me.Tqtd.Name = "Tqtd"
        Me.Tqtd.Size = New System.Drawing.Size(165, 20)
        Me.Tqtd.TabIndex = 72
        Me.Tqtd.Text = "0,00"
        Me.Tqtd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btDetalheFerragem
        '
        Me.btDetalheFerragem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btDetalheFerragem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btDetalheFerragem.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDetalheFerragem.Location = New System.Drawing.Point(154, 465)
        Me.btDetalheFerragem.Name = "btDetalheFerragem"
        Me.btDetalheFerragem.Size = New System.Drawing.Size(99, 29)
        Me.btDetalheFerragem.TabIndex = 71
        Me.btDetalheFerragem.Text = "Detalhe Ferragem"
        '
        'btLancaItens
        '
        Me.btLancaItens.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLancaItens.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLancaItens.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLancaItens.Location = New System.Drawing.Point(14, 465)
        Me.btLancaItens.Name = "btLancaItens"
        Me.btLancaItens.Size = New System.Drawing.Size(99, 29)
        Me.btLancaItens.TabIndex = 70
        Me.btLancaItens.Text = "Lançar Itens"
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
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column4, Me.Total})
        Me.MyLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MyLista.Location = New System.Drawing.Point(12, 87)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.ReadOnly = True
        Me.MyLista.RowHeadersVisible = False
        Me.MyLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyLista.Size = New System.Drawing.Size(765, 334)
        Me.MyLista.TabIndex = 69
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "0000"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CodigoMateriaPrima"
        Me.Column2.HeaderText = "Cod. MP"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Descrição"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Descrição"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Qtd"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Qtd"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "UnidadeMedida"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column6.HeaderText = "UM"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 50
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Unitario"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N4"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.HeaderText = "Unitario"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 110
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N4"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle7
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 110
        '
        'btLocalizar
        '
        Me.btLocalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLocalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLocalizar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLocalizar.Location = New System.Drawing.Point(259, 465)
        Me.btLocalizar.Name = "btLocalizar"
        Me.btLocalizar.Size = New System.Drawing.Size(99, 29)
        Me.btLocalizar.TabIndex = 33
        Me.btLocalizar.Text = "Localizar"
        '
        'btEditar
        '
        Me.btEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEditar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.Location = New System.Drawing.Point(364, 465)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(99, 29)
        Me.btEditar.TabIndex = 32
        Me.btEditar.Text = "Editar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.Location = New System.Drawing.Point(469, 465)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(99, 29)
        Me.btNovo.TabIndex = 31
        Me.btNovo.Text = "Novo"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.Location = New System.Drawing.Point(576, 465)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(99, 29)
        Me.btSalvar.TabIndex = 30
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(681, 465)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(99, 29)
        Me.btFechar.TabIndex = 29
        Me.btFechar.Text = "Fechar"
        '
        'IndustriaSubComposição
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IndustriaSubComposição"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub Composição de Produto"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        CType(Me.MyLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DescriçãoSubComposição As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CodigoSubComposição As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UM As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ValorCusto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btLocalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MyLista As System.Windows.Forms.DataGridView
    Friend WithEvents btLancaItens As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btDetalheFerragem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Ttotal As System.Windows.Forms.Label
    Friend WithEvents Tqtd As System.Windows.Forms.Label
End Class
