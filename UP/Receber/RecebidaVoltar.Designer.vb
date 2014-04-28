<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecebidaVoltar
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
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDocumento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataMovimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ListaDocParcial = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Valor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Recebimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ListaCaixa = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btVoltar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Tipo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColDocumento, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(3, 45)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(284, 460)
        Me.MyLista.TabIndex = 6
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 65
        '
        'ColDocumento
        '
        Me.ColDocumento.Text = "Documento"
        Me.ColDocumento.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Valor"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Recebimento"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Cliente"
        Me.ColumnHeader11.Width = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Data do Dia"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataMovimento
        '
        Me.DataMovimento.AceitaColarTexto = True
        Me.DataMovimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataMovimento.CasasDecimais = 0
        Me.DataMovimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataMovimento.CPObrigatorio = False
        Me.DataMovimento.CPObrigatorioMsg = Nothing
        Me.DataMovimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataMovimento.FlatBorder = False
        Me.DataMovimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataMovimento.FocusColor = System.Drawing.Color.Empty
        Me.DataMovimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataMovimento.HighlightBorderOnEnter = False
        Me.DataMovimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataMovimento.Location = New System.Drawing.Point(141, 16)
        Me.DataMovimento.MaxLength = 10
        Me.DataMovimento.Name = "DataMovimento"
        Me.DataMovimento.PreencherZeroEsqueda = False
        Me.DataMovimento.RegraValidação = Nothing
        Me.DataMovimento.RegraValidaçãoMensagem = Nothing
        Me.DataMovimento.Size = New System.Drawing.Size(146, 23)
        Me.DataMovimento.TabIndex = 12
        Me.DataMovimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataMovimento.ValorPadrao = Nothing
        '
        'ListaDocParcial
        '
        Me.ListaDocParcial.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader7})
        Me.ListaDocParcial.FullRowSelect = True
        Me.ListaDocParcial.GridLines = True
        Me.ListaDocParcial.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListaDocParcial.LabelEdit = True
        Me.ListaDocParcial.Location = New System.Drawing.Point(8, 3)
        Me.ListaDocParcial.MultiSelect = False
        Me.ListaDocParcial.Name = "ListaDocParcial"
        Me.ListaDocParcial.Size = New System.Drawing.Size(513, 104)
        Me.ListaDocParcial.TabIndex = 16
        Me.ListaDocParcial.TabStop = False
        Me.ListaDocParcial.UseCompatibleStateImageBehavior = False
        Me.ListaDocParcial.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Id"
        Me.ColumnHeader5.Width = 71
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Documento"
        Me.ColumnHeader6.Width = 149
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Valor"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Vencimento"
        Me.ColumnHeader7.Width = 147
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(77, 3)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(103, 23)
        Me.Id.TabIndex = 16
        Me.Id.TabStop = False
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(5, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Valor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Valor
        '
        Me.Valor.AceitaColarTexto = True
        Me.Valor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Valor.CasasDecimais = 2
        Me.Valor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Valor.CPObrigatorio = False
        Me.Valor.CPObrigatorioMsg = Nothing
        Me.Valor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Valor.FlatBorder = False
        Me.Valor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Valor.FocusColor = System.Drawing.Color.Empty
        Me.Valor.FocusColorEnd = System.Drawing.Color.Empty
        Me.Valor.HighlightBorderOnEnter = False
        Me.Valor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Valor.Location = New System.Drawing.Point(77, 32)
        Me.Valor.MaxLength = 10
        Me.Valor.Name = "Valor"
        Me.Valor.PreencherZeroEsqueda = False
        Me.Valor.RegraValidação = Nothing
        Me.Valor.RegraValidaçãoMensagem = Nothing
        Me.Valor.Size = New System.Drawing.Size(103, 23)
        Me.Valor.TabIndex = 18
        Me.Valor.TabStop = False
        Me.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Valor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Valor.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(321, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Recebimento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Recebimento
        '
        Me.Recebimento.AceitaColarTexto = True
        Me.Recebimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Recebimento.CasasDecimais = 0
        Me.Recebimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Recebimento.CPObrigatorio = False
        Me.Recebimento.CPObrigatorioMsg = Nothing
        Me.Recebimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Recebimento.FlatBorder = False
        Me.Recebimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Recebimento.FocusColor = System.Drawing.Color.Empty
        Me.Recebimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Recebimento.HighlightBorderOnEnter = False
        Me.Recebimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Recebimento.Location = New System.Drawing.Point(414, 33)
        Me.Recebimento.MaxLength = 10
        Me.Recebimento.Name = "Recebimento"
        Me.Recebimento.PreencherZeroEsqueda = False
        Me.Recebimento.RegraValidação = Nothing
        Me.Recebimento.RegraValidaçãoMensagem = Nothing
        Me.Recebimento.Size = New System.Drawing.Size(110, 23)
        Me.Recebimento.TabIndex = 20
        Me.Recebimento.TabStop = False
        Me.Recebimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Recebimento.ValorPadrao = Nothing
        '
        'Documento
        '
        Me.Documento.AceitaColarTexto = True
        Me.Documento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Documento.CasasDecimais = 0
        Me.Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Documento.CPObrigatorio = False
        Me.Documento.CPObrigatorioMsg = Nothing
        Me.Documento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Documento.FlatBorder = False
        Me.Documento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Documento.FocusColor = System.Drawing.Color.Empty
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.HighlightBorderOnEnter = False
        Me.Documento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Documento.Location = New System.Drawing.Point(414, 4)
        Me.Documento.MaxLength = 10
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(110, 23)
        Me.Documento.TabIndex = 24
        Me.Documento.TabStop = False
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(321, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Documento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(79, 61)
        Me.Cliente.MaxLength = 10
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(446, 23)
        Me.Cliente.TabIndex = 22
        Me.Cliente.TabStop = False
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Tipo)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.GroupPanel4)
        Me.Fundo.Controls.Add(Me.GroupPanel2)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.btVoltar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.DataMovimento)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(849, 544)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(0, 516)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(539, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Selecione c/ dois clicks  a conta a ser feito extorno e depois de um click no bot" & _
    "ão Voltar"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.ListaCaixa)
        Me.GroupPanel4.Location = New System.Drawing.Point(303, 297)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(534, 208)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.Class = ""
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.Class = ""
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.Class = ""
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 29
        Me.GroupPanel4.Text = "Lançamento do Caixa/Banco"
        '
        'ListaCaixa
        '
        Me.ListaCaixa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17})
        Me.ListaCaixa.FullRowSelect = True
        Me.ListaCaixa.GridLines = True
        Me.ListaCaixa.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListaCaixa.LabelEdit = True
        Me.ListaCaixa.Location = New System.Drawing.Point(8, 3)
        Me.ListaCaixa.MultiSelect = False
        Me.ListaCaixa.Name = "ListaCaixa"
        Me.ListaCaixa.Size = New System.Drawing.Size(513, 178)
        Me.ListaCaixa.TabIndex = 16
        Me.ListaCaixa.TabStop = False
        Me.ListaCaixa.UseCompatibleStateImageBehavior = False
        Me.ListaCaixa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Id"
        Me.ColumnHeader13.Width = 65
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Documento"
        Me.ColumnHeader14.Width = 124
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Data Lançamento"
        Me.ColumnHeader15.Width = 109
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Valor"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 142
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Conta"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader17.Width = 40
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.ListaDocParcial)
        Me.GroupPanel2.Location = New System.Drawing.Point(303, 157)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(534, 134)
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
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 27
        Me.GroupPanel2.Text = "Documento Parcial Relacionado"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Cliente)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Documento)
        Me.GroupPanel1.Controls.Add(Me.Id)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Valor)
        Me.GroupPanel1.Controls.Add(Me.Recebimento)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Location = New System.Drawing.Point(303, 33)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(534, 118)
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
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 26
        Me.GroupPanel1.Text = "Documento Selecionado"
        '
        'btVoltar
        '
        Me.btVoltar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVoltar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVoltar.Location = New System.Drawing.Point(667, 511)
        Me.btVoltar.Name = "btVoltar"
        Me.btVoltar.Size = New System.Drawing.Size(82, 27)
        Me.btVoltar.TabIndex = 25
        Me.btVoltar.Text = "Voltar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(755, 511)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(82, 27)
        Me.btFechar.TabIndex = 24
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Tipo
        '
        Me.Tipo.AceitaColarTexto = True
        Me.Tipo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Tipo.CasasDecimais = 2
        Me.Tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tipo.CPObrigatorio = False
        Me.Tipo.CPObrigatorioMsg = Nothing
        Me.Tipo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Tipo.FlatBorder = False
        Me.Tipo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Tipo.FocusColor = System.Drawing.Color.Empty
        Me.Tipo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Tipo.HighlightBorderOnEnter = False
        Me.Tipo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Tipo.Location = New System.Drawing.Point(512, 509)
        Me.Tipo.MaxLength = 10
        Me.Tipo.Name = "Tipo"
        Me.Tipo.PreencherZeroEsqueda = False
        Me.Tipo.RegraValidação = Nothing
        Me.Tipo.RegraValidaçãoMensagem = Nothing
        Me.Tipo.Size = New System.Drawing.Size(55, 23)
        Me.Tipo.TabIndex = 25
        Me.Tipo.TabStop = False
        Me.Tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Tipo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Tipo.ValorPadrao = Nothing
        Me.Tipo.Visible = False
        '
        'RecebidaVoltar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RecebidaVoltar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voltar Recebimento de  Contas a Receber - T2101"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDocumento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataMovimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ListaDocParcial As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Valor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Recebimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btVoltar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ListaCaixa As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tipo As TexBoxFocusNet.TextBoxFocusNet
End Class
