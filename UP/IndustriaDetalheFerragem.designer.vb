<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndustriaDetalheFerragem
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MyLista = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.Prod = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.Bitola = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ProdDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.CompUnitario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Posicao = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.PesoMetro = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.CompTotal = New TexBoxFocusNet.TextBoxFocusNet
        Me.btAdd = New DevComponents.DotNetBar.ButtonX
        Me.PesoTotal = New TexBoxFocusNet.TextBoxFocusNet
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.TComprimento = New System.Windows.Forms.Label
        Me.Tpeso = New System.Windows.Forms.Label
        CType(Me.MyLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fundo.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.AllowUserToAddRows = False
        Me.MyLista.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.PaleGreen
        Me.MyLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.MyLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.MyLista.Location = New System.Drawing.Point(12, 73)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.RowHeadersVisible = False
        Me.MyLista.RowHeadersWidth = 25
        Me.MyLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyLista.Size = New System.Drawing.Size(856, 369)
        Me.MyLista.TabIndex = 9
        Me.MyLista.TabStop = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Id"
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CodigoSubComposição"
        Me.Column2.HeaderText = "CodigoSubComposição"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Prod"
        Me.Column3.HeaderText = "Cod"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ProdDesc"
        Me.Column4.HeaderText = "Descrição"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 130
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Posicao"
        DataGridViewCellStyle9.Format = """N""0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column5.HeaderText = "Pos"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Bitola"
        Me.Column6.HeaderText = "Bit"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Qtd"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column7.HeaderText = "Qtd"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "CompUnitario"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column8.HeaderText = "Com. Unitário (CM)"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "PesoMetro"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N4"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column9.HeaderText = " Peso Metro"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 90
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "CompTotal"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column10.HeaderText = "Com. Total (CM)"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 90
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "PesoTotal"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N4"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column11.HeaderText = "Peso Total"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 90
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(769, 487)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(99, 29)
        Me.btFechar.TabIndex = 11
        Me.btFechar.TabStop = False
        Me.btFechar.Text = "Fechar"
        '
        'Prod
        '
        Me.Prod.AceitaColarTexto = True
        Me.Prod.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Prod.CasasDecimais = 0
        Me.Prod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Prod.CPObrigatorio = False
        Me.Prod.CPObrigatorioMsg = Nothing
        Me.Prod.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Prod.FocusColor = System.Drawing.Color.MistyRose
        Me.Prod.FocusColorEnd = System.Drawing.Color.Empty
        Me.Prod.Location = New System.Drawing.Point(4, 27)
        Me.Prod.MaxLength = 10
        Me.Prod.Name = "Prod"
        Me.Prod.RegraValidação = Nothing
        Me.Prod.RegraValidaçãoMensagem = Nothing
        Me.Prod.Size = New System.Drawing.Size(69, 20)
        Me.Prod.TabIndex = 0
        Me.Prod.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Prod.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Tpeso)
        Me.Fundo.Controls.Add(Me.TComprimento)
        Me.Fundo.Controls.Add(Me.PanelEx1)
        Me.Fundo.Controls.Add(Me.PesoTotal)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(878, 525)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Bitola)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.Prod)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.ProdDesc)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.CompUnitario)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Qtd)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Posicao)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.PesoMetro)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.CompTotal)
        Me.PanelEx1.Controls.Add(Me.btAdd)
        Me.PanelEx1.Location = New System.Drawing.Point(12, 12)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(854, 55)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 20
        '
        'Bitola
        '
        Me.Bitola.AceitaColarTexto = False
        Me.Bitola.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Bitola.CasasDecimais = 0
        Me.Bitola.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Bitola.CPObrigatorio = False
        Me.Bitola.CPObrigatorioMsg = Nothing
        Me.Bitola.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Bitola.FocusColor = System.Drawing.Color.MistyRose
        Me.Bitola.FocusColorEnd = System.Drawing.Color.Empty
        Me.Bitola.Location = New System.Drawing.Point(255, 27)
        Me.Bitola.MaxLength = 7
        Me.Bitola.Name = "Bitola"
        Me.Bitola.RegraValidação = Nothing
        Me.Bitola.RegraValidaçãoMensagem = Nothing
        Me.Bitola.Size = New System.Drawing.Size(119, 20)
        Me.Bitola.TabIndex = 3
        Me.Bitola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Bitola.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Bitola.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(645, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Com. Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(556, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Peso Metro"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProdDesc
        '
        Me.ProdDesc.AceitaColarTexto = False
        Me.ProdDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdDesc.CasasDecimais = 0
        Me.ProdDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdDesc.CPObrigatorio = False
        Me.ProdDesc.CPObrigatorioMsg = Nothing
        Me.ProdDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ProdDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdDesc.Location = New System.Drawing.Point(73, 27)
        Me.ProdDesc.MaxLength = 50
        Me.ProdDesc.Name = "ProdDesc"
        Me.ProdDesc.RegraValidação = Nothing
        Me.ProdDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdDesc.Size = New System.Drawing.Size(132, 20)
        Me.ProdDesc.TabIndex = 1
        Me.ProdDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdDesc.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(455, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Com.Unitário"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompUnitario
        '
        Me.CompUnitario.AceitaColarTexto = False
        Me.CompUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CompUnitario.CasasDecimais = 0
        Me.CompUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompUnitario.CPObrigatorio = False
        Me.CompUnitario.CPObrigatorioMsg = Nothing
        Me.CompUnitario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CompUnitario.FocusColor = System.Drawing.Color.MistyRose
        Me.CompUnitario.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompUnitario.Location = New System.Drawing.Point(455, 27)
        Me.CompUnitario.MaxLength = 8
        Me.CompUnitario.Name = "CompUnitario"
        Me.CompUnitario.RegraValidação = Nothing
        Me.CompUnitario.RegraValidaçãoMensagem = Nothing
        Me.CompUnitario.Size = New System.Drawing.Size(100, 20)
        Me.CompUnitario.TabIndex = 5
        Me.CompUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CompUnitario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.CompUnitario.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Qtd"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Qtd
        '
        Me.Qtd.AceitaColarTexto = False
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 0
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.CPObrigatorio = False
        Me.Qtd.CPObrigatorioMsg = Nothing
        Me.Qtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd.FocusColor = System.Drawing.Color.MistyRose
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.Location = New System.Drawing.Point(375, 27)
        Me.Qtd.MaxLength = 8
        Me.Qtd.Name = "Qtd"
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(80, 20)
        Me.Qtd.TabIndex = 4
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Bitola"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Posicao
        '
        Me.Posicao.AceitaColarTexto = False
        Me.Posicao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Posicao.CasasDecimais = 0
        Me.Posicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Posicao.CPObrigatorio = False
        Me.Posicao.CPObrigatorioMsg = Nothing
        Me.Posicao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Posicao.FocusColor = System.Drawing.Color.MistyRose
        Me.Posicao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Posicao.Location = New System.Drawing.Point(205, 27)
        Me.Posicao.MaxLength = 5
        Me.Posicao.Name = "Posicao"
        Me.Posicao.RegraValidação = Nothing
        Me.Posicao.RegraValidaçãoMensagem = Nothing
        Me.Posicao.Size = New System.Drawing.Size(50, 20)
        Me.Posicao.TabIndex = 2
        Me.Posicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Posicao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Posicao.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Pos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PesoMetro
        '
        Me.PesoMetro.AceitaColarTexto = False
        Me.PesoMetro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PesoMetro.CasasDecimais = 4
        Me.PesoMetro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PesoMetro.CPObrigatorio = False
        Me.PesoMetro.CPObrigatorioMsg = Nothing
        Me.PesoMetro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PesoMetro.FocusColor = System.Drawing.Color.MistyRose
        Me.PesoMetro.FocusColorEnd = System.Drawing.Color.Empty
        Me.PesoMetro.Location = New System.Drawing.Point(556, 27)
        Me.PesoMetro.MaxLength = 8
        Me.PesoMetro.Name = "PesoMetro"
        Me.PesoMetro.RegraValidação = Nothing
        Me.PesoMetro.RegraValidaçãoMensagem = Nothing
        Me.PesoMetro.Size = New System.Drawing.Size(89, 20)
        Me.PesoMetro.TabIndex = 6
        Me.PesoMetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PesoMetro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.PesoMetro.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Materia Prima"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompTotal
        '
        Me.CompTotal.AceitaColarTexto = False
        Me.CompTotal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CompTotal.CasasDecimais = 0
        Me.CompTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompTotal.CPObrigatorio = False
        Me.CompTotal.CPObrigatorioMsg = Nothing
        Me.CompTotal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CompTotal.FocusColor = System.Drawing.Color.MistyRose
        Me.CompTotal.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompTotal.Location = New System.Drawing.Point(645, 27)
        Me.CompTotal.MaxLength = 8
        Me.CompTotal.Name = "CompTotal"
        Me.CompTotal.RegraValidação = Nothing
        Me.CompTotal.RegraValidaçãoMensagem = Nothing
        Me.CompTotal.Size = New System.Drawing.Size(86, 20)
        Me.CompTotal.TabIndex = 7
        Me.CompTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CompTotal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.CompTotal.ValorPadrao = Nothing
        '
        'btAdd
        '
        Me.btAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdd.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Location = New System.Drawing.Point(737, 4)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(114, 43)
        Me.btAdd.TabIndex = 8
        Me.btAdd.Text = "Adicionar"
        '
        'PesoTotal
        '
        Me.PesoTotal.AceitaColarTexto = False
        Me.PesoTotal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PesoTotal.CasasDecimais = 4
        Me.PesoTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PesoTotal.CPObrigatorio = False
        Me.PesoTotal.CPObrigatorioMsg = Nothing
        Me.PesoTotal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PesoTotal.FocusColor = System.Drawing.Color.MistyRose
        Me.PesoTotal.FocusColorEnd = System.Drawing.Color.Empty
        Me.PesoTotal.Location = New System.Drawing.Point(99, 481)
        Me.PesoTotal.MaxLength = 8
        Me.PesoTotal.Name = "PesoTotal"
        Me.PesoTotal.RegraValidação = Nothing
        Me.PesoTotal.RegraValidaçãoMensagem = Nothing
        Me.PesoTotal.Size = New System.Drawing.Size(98, 20)
        Me.PesoTotal.TabIndex = 12
        Me.PesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PesoTotal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.PesoTotal.ValorPadrao = Nothing
        Me.PesoTotal.Visible = False
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(11, 481)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(82, 20)
        Me.Id.TabIndex = 10
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'TComprimento
        '
        Me.TComprimento.BackColor = System.Drawing.Color.Transparent
        Me.TComprimento.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TComprimento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TComprimento.Location = New System.Drawing.Point(657, 448)
        Me.TComprimento.Name = "TComprimento"
        Me.TComprimento.Size = New System.Drawing.Size(86, 29)
        Me.TComprimento.TabIndex = 21
        Me.TComprimento.Text = "0,00"
        Me.TComprimento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Tpeso
        '
        Me.Tpeso.BackColor = System.Drawing.Color.Transparent
        Me.Tpeso.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tpeso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Tpeso.Location = New System.Drawing.Point(743, 448)
        Me.Tpeso.Name = "Tpeso"
        Me.Tpeso.Size = New System.Drawing.Size(90, 29)
        Me.Tpeso.TabIndex = 22
        Me.Tpeso.Text = "0,00"
        Me.Tpeso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'IndustriaDetalheFerragem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IndustriaDetalheFerragem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes da Ferragem"
        CType(Me.MyLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.DataGridView
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Prod As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ProdDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CompTotal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PesoMetro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Posicao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Bitola As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CompUnitario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PesoTotal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tpeso As System.Windows.Forms.Label
    Friend WithEvents TComprimento As System.Windows.Forms.Label
End Class
