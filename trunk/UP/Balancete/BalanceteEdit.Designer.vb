<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceteEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BalanceteEdit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btAddCC = New System.Windows.Forms.Label()
        Me.TotCentroCusto = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Lista = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorLanc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdLanc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSalvarDados = New System.Windows.Forms.Button()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindConta = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ContaCorrente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tipo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContaRC = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ValorDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Historico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFiltrar = New System.Windows.Forms.Button()
        Me.DG = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDataLancamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cHistorico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContaRC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContaCorrente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btAddCC)
        Me.PanelEx1.Controls.Add(Me.TotCentroCusto)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.DataFinal)
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.btSalvarDados)
        Me.PanelEx1.Controls.Add(Me.DataInicial)
        Me.PanelEx1.Controls.Add(Me.btFindConta)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.ContaCorrente)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Tipo)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.ContaRC)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.ValorDocumento)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.Historico)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Documento)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.DataLancamento)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.btFiltrar)
        Me.PanelEx1.Controls.Add(Me.DG)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1148, 677)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btAddCC
        '
        Me.btAddCC.BackColor = System.Drawing.Color.Transparent
        Me.btAddCC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAddCC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddCC.Image = CType(resources.GetObject("btAddCC.Image"), System.Drawing.Image)
        Me.btAddCC.Location = New System.Drawing.Point(751, 327)
        Me.btAddCC.Name = "btAddCC"
        Me.btAddCC.Size = New System.Drawing.Size(22, 24)
        Me.btAddCC.TabIndex = 63
        Me.btAddCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotCentroCusto
        '
        Me.TotCentroCusto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotCentroCusto.Location = New System.Drawing.Point(1021, 583)
        Me.TotCentroCusto.Name = "TotCentroCusto"
        Me.TotCentroCusto.Size = New System.Drawing.Size(94, 24)
        Me.TotCentroCusto.TabIndex = 25
        Me.TotCentroCusto.Text = "00,00"
        Me.TotCentroCusto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(812, 583)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 24)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total de Centro de Custo Lançado"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(639, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 24)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Centro de Custo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataFinal.CasasDecimais = 2
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FlatBorder = True
        Me.DataFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.GlowColor = System.Drawing.Color.Navy
        Me.DataFinal.HighlightBorderOnEnter = False
        Me.DataFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataFinal.Location = New System.Drawing.Point(115, 35)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(94, 23)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Lista
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.cValorLanc, Me.cIdLanc})
        Me.Lista.Location = New System.Drawing.Point(643, 354)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(491, 223)
        Me.Lista.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ContaCC"
        Me.Column1.HeaderText = "Conta"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "DescContaGrupo3"
        Me.Column2.HeaderText = "Descrição"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 180
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "DataLanc"
        Me.Column3.HeaderText = "Data Lanç"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'cValorLanc
        '
        Me.cValorLanc.DataPropertyName = "ValorLanc"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cValorLanc.DefaultCellStyle = DataGridViewCellStyle2
        Me.cValorLanc.HeaderText = "Valor"
        Me.cValorLanc.Name = "cValorLanc"
        Me.cValorLanc.ReadOnly = True
        '
        'cIdLanc
        '
        Me.cIdLanc.DataPropertyName = "Id"
        Me.cIdLanc.HeaderText = "Id"
        Me.cIdLanc.Name = "cIdLanc"
        Me.cIdLanc.ReadOnly = True
        Me.cIdLanc.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe a Data Inicial e Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btSalvarDados
        '
        Me.btSalvarDados.Image = CType(resources.GetObject("btSalvarDados.Image"), System.Drawing.Image)
        Me.btSalvarDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalvarDados.Location = New System.Drawing.Point(931, 290)
        Me.btSalvarDados.Name = "btSalvarDados"
        Me.btSalvarDados.Size = New System.Drawing.Size(203, 35)
        Me.btSalvarDados.TabIndex = 26
        Me.btSalvarDados.Text = "Salvar os Dados Selecionado"
        Me.btSalvarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvarDados.UseVisualStyleBackColor = True
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataInicial.CasasDecimais = 2
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FlatBorder = True
        Me.DataInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.GlowColor = System.Drawing.Color.Navy
        Me.DataInicial.HighlightBorderOnEnter = False
        Me.DataInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataInicial.Location = New System.Drawing.Point(14, 35)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(94, 23)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'btFindConta
        '
        Me.btFindConta.Image = CType(resources.GetObject("btFindConta.Image"), System.Drawing.Image)
        Me.btFindConta.Location = New System.Drawing.Point(868, 298)
        Me.btFindConta.Name = "btFindConta"
        Me.btFindConta.Size = New System.Drawing.Size(23, 24)
        Me.btFindConta.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(898, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Conta Caixa/Banco"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaCorrente
        '
        Me.ContaCorrente.AceitaColarTexto = True
        Me.ContaCorrente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaCorrente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContaCorrente.CasasDecimais = 0
        Me.ContaCorrente.CPObrigatorio = False
        Me.ContaCorrente.CPObrigatorioMsg = Nothing
        Me.ContaCorrente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCorrente.FlatBorder = True
        Me.ContaCorrente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCorrente.FocusColor = System.Drawing.Color.Empty
        Me.ContaCorrente.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCorrente.GlowColor = System.Drawing.Color.Navy
        Me.ContaCorrente.HighlightBorderOnEnter = False
        Me.ContaCorrente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCorrente.Location = New System.Drawing.Point(1035, 238)
        Me.ContaCorrente.MaxLength = 6
        Me.ContaCorrente.Name = "ContaCorrente"
        Me.ContaCorrente.PreencherZeroEsqueda = False
        Me.ContaCorrente.RegraValidação = Nothing
        Me.ContaCorrente.RegraValidaçãoMensagem = Nothing
        Me.ContaCorrente.Size = New System.Drawing.Size(94, 23)
        Me.ContaCorrente.TabIndex = 16
        Me.ContaCorrente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCorrente.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(635, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tipo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tipo
        '
        Me.Tipo.AceitaColarTexto = True
        Me.Tipo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tipo.CasasDecimais = 0
        Me.Tipo.CPObrigatorio = False
        Me.Tipo.CPObrigatorioMsg = Nothing
        Me.Tipo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Tipo.FlatBorder = True
        Me.Tipo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Tipo.FocusColor = System.Drawing.Color.Empty
        Me.Tipo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Tipo.GlowColor = System.Drawing.Color.Navy
        Me.Tipo.HighlightBorderOnEnter = False
        Me.Tipo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Tipo.Location = New System.Drawing.Point(771, 235)
        Me.Tipo.MaxLength = 5
        Me.Tipo.Name = "Tipo"
        Me.Tipo.PreencherZeroEsqueda = False
        Me.Tipo.RegraValidação = Nothing
        Me.Tipo.RegraValidaçãoMensagem = Nothing
        Me.Tipo.Size = New System.Drawing.Size(94, 23)
        Me.Tipo.TabIndex = 14
        Me.Tipo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Tipo.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(635, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Conta Desp./Receita"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaRC
        '
        Me.ContaRC.AceitaColarTexto = True
        Me.ContaRC.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaRC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContaRC.CasasDecimais = 0
        Me.ContaRC.CPObrigatorio = False
        Me.ContaRC.CPObrigatorioMsg = Nothing
        Me.ContaRC.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaRC.FlatBorder = True
        Me.ContaRC.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaRC.FocusColor = System.Drawing.Color.Empty
        Me.ContaRC.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaRC.GlowColor = System.Drawing.Color.Navy
        Me.ContaRC.HighlightBorderOnEnter = False
        Me.ContaRC.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaRC.Location = New System.Drawing.Point(771, 298)
        Me.ContaRC.MaxLength = 6
        Me.ContaRC.Name = "ContaRC"
        Me.ContaRC.PreencherZeroEsqueda = True
        Me.ContaRC.RegraValidação = Nothing
        Me.ContaRC.RegraValidaçãoMensagem = Nothing
        Me.ContaRC.Size = New System.Drawing.Size(94, 23)
        Me.ContaRC.TabIndex = 20
        Me.ContaRC.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaRC.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(635, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Valor Documento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AceitaColarTexto = True
        Me.ValorDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorDocumento.CasasDecimais = 2
        Me.ValorDocumento.CPObrigatorio = False
        Me.ValorDocumento.CPObrigatorioMsg = Nothing
        Me.ValorDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDocumento.FlatBorder = True
        Me.ValorDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.FocusColor = System.Drawing.Color.Empty
        Me.ValorDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDocumento.GlowColor = System.Drawing.Color.Navy
        Me.ValorDocumento.HighlightBorderOnEnter = False
        Me.ValorDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorDocumento.Location = New System.Drawing.Point(771, 267)
        Me.ValorDocumento.MaxLength = 15
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.PreencherZeroEsqueda = False
        Me.ValorDocumento.RegraValidação = Nothing
        Me.ValorDocumento.RegraValidaçãoMensagem = Nothing
        Me.ValorDocumento.Size = New System.Drawing.Size(94, 23)
        Me.ValorDocumento.TabIndex = 18
        Me.ValorDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.ValorDocumento.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(635, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Historico"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Historico
        '
        Me.Historico.AceitaColarTexto = True
        Me.Historico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Historico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Historico.CasasDecimais = 0
        Me.Historico.CPObrigatorio = False
        Me.Historico.CPObrigatorioMsg = Nothing
        Me.Historico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Historico.FlatBorder = True
        Me.Historico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Historico.FocusColor = System.Drawing.Color.Empty
        Me.Historico.FocusColorEnd = System.Drawing.Color.Empty
        Me.Historico.GlowColor = System.Drawing.Color.Navy
        Me.Historico.HighlightBorderOnEnter = False
        Me.Historico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Historico.Location = New System.Drawing.Point(771, 148)
        Me.Historico.MaxLength = 254
        Me.Historico.Multiline = True
        Me.Historico.Name = "Historico"
        Me.Historico.PreencherZeroEsqueda = False
        Me.Historico.RegraValidação = Nothing
        Me.Historico.RegraValidaçãoMensagem = Nothing
        Me.Historico.Size = New System.Drawing.Size(358, 80)
        Me.Historico.TabIndex = 12
        Me.Historico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Historico.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(635, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Documento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Documento
        '
        Me.Documento.AceitaColarTexto = True
        Me.Documento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Documento.CasasDecimais = 0
        Me.Documento.CPObrigatorio = False
        Me.Documento.CPObrigatorioMsg = Nothing
        Me.Documento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Documento.FlatBorder = True
        Me.Documento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Documento.FocusColor = System.Drawing.Color.Empty
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.GlowColor = System.Drawing.Color.Navy
        Me.Documento.HighlightBorderOnEnter = False
        Me.Documento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Documento.Location = New System.Drawing.Point(771, 117)
        Me.Documento.MaxLength = 15
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(94, 23)
        Me.Documento.TabIndex = 10
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(913, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data Lançamento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = True
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FlatBorder = True
        Me.DataLancamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.GlowColor = System.Drawing.Color.Navy
        Me.DataLancamento.HighlightBorderOnEnter = False
        Me.DataLancamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataLancamento.Location = New System.Drawing.Point(1035, 85)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.PreencherZeroEsqueda = False
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(94, 23)
        Me.DataLancamento.TabIndex = 8
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(635, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Id"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id.CasasDecimais = 0
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = True
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.GlowColor = System.Drawing.Color.Navy
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(771, 85)
        Me.Id.MaxLength = 15
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(94, 23)
        Me.Id.TabIndex = 6
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.Id.ValorPadrao = Nothing
        '
        'btFiltrar
        '
        Me.btFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFiltrar.Image = CType(resources.GetObject("btFiltrar.Image"), System.Drawing.Image)
        Me.btFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFiltrar.Location = New System.Drawing.Point(217, 27)
        Me.btFiltrar.Name = "btFiltrar"
        Me.btFiltrar.Size = New System.Drawing.Size(87, 32)
        Me.btFiltrar.TabIndex = 3
        Me.btFiltrar.Text = "Filtrar"
        Me.btFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFiltrar.UseVisualStyleBackColor = True
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        Me.DG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cDataLancamento, Me.cDocumento, Me.cHistorico, Me.cValorDocumento, Me.cContaRC, Me.cTipo, Me.cContaCorrente})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG.DefaultCellStyle = DataGridViewCellStyle5
        Me.DG.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DG.Location = New System.Drawing.Point(14, 66)
        Me.DG.MultiSelect = False
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.RowHeadersWidth = 20
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(614, 598)
        Me.DG.TabIndex = 4
        '
        'btFechar
        '
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.Location = New System.Drawing.Point(1035, 629)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(99, 35)
        Me.btFechar.TabIndex = 27
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'cId
        '
        Me.cId.DataPropertyName = "Id"
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        '
        'cDataLancamento
        '
        Me.cDataLancamento.DataPropertyName = "DataLancamento"
        Me.cDataLancamento.HeaderText = "Data Lanc"
        Me.cDataLancamento.Name = "cDataLancamento"
        Me.cDataLancamento.ReadOnly = True
        Me.cDataLancamento.Width = 85
        '
        'cDocumento
        '
        Me.cDocumento.DataPropertyName = "Documento"
        Me.cDocumento.HeaderText = "Documento"
        Me.cDocumento.Name = "cDocumento"
        Me.cDocumento.ReadOnly = True
        Me.cDocumento.Width = 85
        '
        'cHistorico
        '
        Me.cHistorico.DataPropertyName = "Historico"
        Me.cHistorico.HeaderText = "Historico"
        Me.cHistorico.Name = "cHistorico"
        Me.cHistorico.ReadOnly = True
        Me.cHistorico.Width = 200
        '
        'cValorDocumento
        '
        Me.cValorDocumento.DataPropertyName = "ValorDocumento"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cValorDocumento.DefaultCellStyle = DataGridViewCellStyle4
        Me.cValorDocumento.HeaderText = "Valor Doc"
        Me.cValorDocumento.Name = "cValorDocumento"
        Me.cValorDocumento.ReadOnly = True
        '
        'cContaRC
        '
        Me.cContaRC.DataPropertyName = "ContaBalancete"
        Me.cContaRC.HeaderText = "D/R"
        Me.cContaRC.Name = "cContaRC"
        Me.cContaRC.ReadOnly = True
        Me.cContaRC.Width = 70
        '
        'cTipo
        '
        Me.cTipo.DataPropertyName = "Tipo"
        Me.cTipo.HeaderText = "Tipo"
        Me.cTipo.Name = "cTipo"
        Me.cTipo.ReadOnly = True
        '
        'cContaCorrente
        '
        Me.cContaCorrente.DataPropertyName = "ContaCorrente"
        Me.cContaCorrente.HeaderText = "C/C"
        Me.cContaCorrente.Name = "cContaCorrente"
        Me.cContaCorrente.ReadOnly = True
        '
        'BalanceteEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 677)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BalanceteEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alteração de Conta "
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DG As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ContaCorrente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tipo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ContaRC As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ValorDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Historico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindConta As System.Windows.Forms.Label
    Friend WithEvents btSalvarDados As System.Windows.Forms.Button
    Friend WithEvents Lista As System.Windows.Forms.DataGridView
    Friend WithEvents TotCentroCusto As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btAddCC As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorLanc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIdLanc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDataLancamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cHistorico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaCorrente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
