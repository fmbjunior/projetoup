<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdemEntrega
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
        Me.Observação = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MyLista1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ordem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataSaida = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataEmissao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NomeCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CódigoCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.OrdemTemp = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IdTEMP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.AddItensTodos = New DevComponents.DotNetBar.ButtonX()
        Me.BTOrdemNova = New DevComponents.DotNetBar.ButtonX()
        Me.BtItensMostrar = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvarImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Observação
        '
        Me.Observação.AceitaColarTexto = True
        Me.Observação.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Observação.CasasDecimais = 0
        Me.Observação.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Observação.CPObrigatorio = False
        Me.Observação.CPObrigatorioMsg = Nothing
        Me.Observação.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Observação.FlatBorder = False
        Me.Observação.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Observação.FocusColor = System.Drawing.Color.Empty
        Me.Observação.FocusColorEnd = System.Drawing.Color.Empty
        Me.Observação.HighlightBorderOnEnter = False
        Me.Observação.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Observação.Location = New System.Drawing.Point(111, 67)
        Me.Observação.MaxLength = 150
        Me.Observação.Name = "Observação"
        Me.Observação.PreencherZeroEsqueda = False
        Me.Observação.RegraValidação = Nothing
        Me.Observação.RegraValidaçãoMensagem = Nothing
        Me.Observação.Size = New System.Drawing.Size(494, 23)
        Me.Observação.TabIndex = 8
        Me.Observação.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Observação.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Observação"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MyLista1
        '
        Me.MyLista1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader14})
        Me.MyLista1.FullRowSelect = True
        Me.MyLista1.GridLines = True
        Me.MyLista1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista1.Location = New System.Drawing.Point(15, 288)
        Me.MyLista1.MultiSelect = False
        Me.MyLista1.Name = "MyLista1"
        Me.MyLista1.Size = New System.Drawing.Size(590, 158)
        Me.MyLista1.TabIndex = 14
        Me.MyLista1.UseCompatibleStateImageBehavior = False
        Me.MyLista1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Id"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Produto"
        Me.ColumnHeader6.Width = 65
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Descrição"
        Me.ColumnHeader7.Width = 240
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Qtd"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Retirado"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Retirar"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "CustoItem"
        Me.ColumnHeader14.Width = 0
        '
        'MyLista
        '
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(15, 124)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(590, 158)
        Me.MyLista.TabIndex = 13
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Produto"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descrição"
        Me.ColumnHeader3.Width = 305
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Qtd"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "IdItem"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "CustoItem"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "CustoTotal"
        Me.ColumnHeader13.Width = 0
        '
        'Pedido
        '
        Me.Pedido.AceitaColarTexto = True
        Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Pedido.CasasDecimais = 0
        Me.Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pedido.CPObrigatorio = False
        Me.Pedido.CPObrigatorioMsg = Nothing
        Me.Pedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Pedido.FlatBorder = False
        Me.Pedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Pedido.FocusColor = System.Drawing.Color.Empty
        Me.Pedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pedido.HighlightBorderOnEnter = False
        Me.Pedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Pedido.Location = New System.Drawing.Point(316, 9)
        Me.Pedido.MaxLength = 30
        Me.Pedido.Name = "Pedido"
        Me.Pedido.PreencherZeroEsqueda = False
        Me.Pedido.RegraValidação = Nothing
        Me.Pedido.RegraValidaçãoMensagem = Nothing
        Me.Pedido.Size = New System.Drawing.Size(88, 23)
        Me.Pedido.TabIndex = 3
        Me.Pedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pedido.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(213, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Pedido"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ordem
        '
        Me.Ordem.AceitaColarTexto = True
        Me.Ordem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ordem.CasasDecimais = 0
        Me.Ordem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ordem.CPObrigatorio = False
        Me.Ordem.CPObrigatorioMsg = Nothing
        Me.Ordem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ordem.FlatBorder = False
        Me.Ordem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Ordem.FocusColor = System.Drawing.Color.Empty
        Me.Ordem.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ordem.HighlightBorderOnEnter = False
        Me.Ordem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Ordem.Location = New System.Drawing.Point(111, 9)
        Me.Ordem.MaxLength = 8
        Me.Ordem.Name = "Ordem"
        Me.Ordem.PreencherZeroEsqueda = False
        Me.Ordem.RegraValidação = Nothing
        Me.Ordem.RegraValidaçãoMensagem = Nothing
        Me.Ordem.Size = New System.Drawing.Size(88, 23)
        Me.Ordem.TabIndex = 1
        Me.Ordem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Ordem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ordem.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nº da Ordem"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataSaida
        '
        Me.DataSaida.AceitaColarTexto = True
        Me.DataSaida.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataSaida.CasasDecimais = 0
        Me.DataSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataSaida.CPObrigatorio = False
        Me.DataSaida.CPObrigatorioMsg = Nothing
        Me.DataSaida.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataSaida.FlatBorder = False
        Me.DataSaida.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataSaida.FocusColor = System.Drawing.Color.Empty
        Me.DataSaida.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataSaida.HighlightBorderOnEnter = False
        Me.DataSaida.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataSaida.Location = New System.Drawing.Point(316, 95)
        Me.DataSaida.MaxLength = 10
        Me.DataSaida.Name = "DataSaida"
        Me.DataSaida.PreencherZeroEsqueda = False
        Me.DataSaida.RegraValidação = Nothing
        Me.DataSaida.RegraValidaçãoMensagem = Nothing
        Me.DataSaida.Size = New System.Drawing.Size(88, 23)
        Me.DataSaida.TabIndex = 12
        Me.DataSaida.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataSaida.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(213, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Data Saída"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataEmissao
        '
        Me.DataEmissao.AceitaColarTexto = True
        Me.DataEmissao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataEmissao.CasasDecimais = 0
        Me.DataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataEmissao.CPObrigatorio = False
        Me.DataEmissao.CPObrigatorioMsg = Nothing
        Me.DataEmissao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataEmissao.FlatBorder = False
        Me.DataEmissao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataEmissao.FocusColor = System.Drawing.Color.Empty
        Me.DataEmissao.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataEmissao.HighlightBorderOnEnter = False
        Me.DataEmissao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataEmissao.Location = New System.Drawing.Point(111, 96)
        Me.DataEmissao.MaxLength = 10
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.PreencherZeroEsqueda = False
        Me.DataEmissao.RegraValidação = Nothing
        Me.DataEmissao.RegraValidaçãoMensagem = Nothing
        Me.DataEmissao.Size = New System.Drawing.Size(88, 23)
        Me.DataEmissao.TabIndex = 10
        Me.DataEmissao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataEmissao.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Data Emissão"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeCliente
        '
        Me.NomeCliente.AceitaColarTexto = True
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeCliente.CasasDecimais = 0
        Me.NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeCliente.CPObrigatorio = False
        Me.NomeCliente.CPObrigatorioMsg = Nothing
        Me.NomeCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeCliente.FlatBorder = False
        Me.NomeCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeCliente.FocusColor = System.Drawing.Color.Empty
        Me.NomeCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeCliente.HighlightBorderOnEnter = False
        Me.NomeCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeCliente.Location = New System.Drawing.Point(204, 38)
        Me.NomeCliente.MaxLength = 50
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.PreencherZeroEsqueda = False
        Me.NomeCliente.RegraValidação = Nothing
        Me.NomeCliente.RegraValidaçãoMensagem = Nothing
        Me.NomeCliente.Size = New System.Drawing.Size(401, 23)
        Me.NomeCliente.TabIndex = 6
        Me.NomeCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeCliente.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cód. Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CódigoCliente
        '
        Me.CódigoCliente.AceitaColarTexto = True
        Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CódigoCliente.CasasDecimais = 0
        Me.CódigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CódigoCliente.CPObrigatorio = False
        Me.CódigoCliente.CPObrigatorioMsg = Nothing
        Me.CódigoCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CódigoCliente.FlatBorder = False
        Me.CódigoCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CódigoCliente.FocusColor = System.Drawing.Color.Empty
        Me.CódigoCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.CódigoCliente.HighlightBorderOnEnter = False
        Me.CódigoCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CódigoCliente.Location = New System.Drawing.Point(111, 38)
        Me.CódigoCliente.Name = "CódigoCliente"
        Me.CódigoCliente.PreencherZeroEsqueda = False
        Me.CódigoCliente.RegraValidação = Nothing
        Me.CódigoCliente.RegraValidaçãoMensagem = Nothing
        Me.CódigoCliente.Size = New System.Drawing.Size(86, 23)
        Me.CódigoCliente.TabIndex = 5
        Me.CódigoCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CódigoCliente.ValorPadrao = Nothing
        '
        'OrdemTemp
        '
        Me.OrdemTemp.AceitaColarTexto = True
        Me.OrdemTemp.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.OrdemTemp.CasasDecimais = 0
        Me.OrdemTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OrdemTemp.CPObrigatorio = False
        Me.OrdemTemp.CPObrigatorioMsg = Nothing
        Me.OrdemTemp.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OrdemTemp.FlatBorder = False
        Me.OrdemTemp.FlatBorderColor = System.Drawing.Color.DimGray
        Me.OrdemTemp.FocusColor = System.Drawing.Color.Empty
        Me.OrdemTemp.FocusColorEnd = System.Drawing.Color.Empty
        Me.OrdemTemp.HighlightBorderOnEnter = False
        Me.OrdemTemp.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.OrdemTemp.Location = New System.Drawing.Point(15, 452)
        Me.OrdemTemp.MaxLength = 8
        Me.OrdemTemp.Name = "OrdemTemp"
        Me.OrdemTemp.PreencherZeroEsqueda = False
        Me.OrdemTemp.RegraValidação = Nothing
        Me.OrdemTemp.RegraValidaçãoMensagem = Nothing
        Me.OrdemTemp.Size = New System.Drawing.Size(24, 23)
        Me.OrdemTemp.TabIndex = 2
        Me.OrdemTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OrdemTemp.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.OrdemTemp.ValorPadrao = Nothing
        Me.OrdemTemp.Visible = False
        '
        'IdTEMP
        '
        Me.IdTEMP.AceitaColarTexto = True
        Me.IdTEMP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IdTEMP.CasasDecimais = 0
        Me.IdTEMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdTEMP.CPObrigatorio = False
        Me.IdTEMP.CPObrigatorioMsg = Nothing
        Me.IdTEMP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdTEMP.FlatBorder = False
        Me.IdTEMP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdTEMP.FocusColor = System.Drawing.Color.Empty
        Me.IdTEMP.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdTEMP.HighlightBorderOnEnter = False
        Me.IdTEMP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdTEMP.Location = New System.Drawing.Point(45, 452)
        Me.IdTEMP.MaxLength = 30
        Me.IdTEMP.Name = "IdTEMP"
        Me.IdTEMP.PreencherZeroEsqueda = False
        Me.IdTEMP.RegraValidação = Nothing
        Me.IdTEMP.RegraValidaçãoMensagem = Nothing
        Me.IdTEMP.Size = New System.Drawing.Size(27, 23)
        Me.IdTEMP.TabIndex = 6
        Me.IdTEMP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdTEMP.ValorPadrao = Nothing
        Me.IdTEMP.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.AddItensTodos)
        Me.Fundo.Controls.Add(Me.BTOrdemNova)
        Me.Fundo.Controls.Add(Me.BtItensMostrar)
        Me.Fundo.Controls.Add(Me.btSalvarImprimir)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Observação)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.IdTEMP)
        Me.Fundo.Controls.Add(Me.CódigoCliente)
        Me.Fundo.Controls.Add(Me.MyLista1)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.OrdemTemp)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.NomeCliente)
        Me.Fundo.Controls.Add(Me.DataSaida)
        Me.Fundo.Controls.Add(Me.Pedido)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Ordem)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.DataEmissao)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(620, 484)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 7
        '
        'AddItensTodos
        '
        Me.AddItensTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddItensTodos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddItensTodos.Location = New System.Drawing.Point(94, 452)
        Me.AddItensTodos.Name = "AddItensTodos"
        Me.AddItensTodos.Size = New System.Drawing.Size(93, 27)
        Me.AddItensTodos.TabIndex = 20
        Me.AddItensTodos.Text = "Add Todos Itens"
        '
        'BTOrdemNova
        '
        Me.BTOrdemNova.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTOrdemNova.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTOrdemNova.Location = New System.Drawing.Point(292, 452)
        Me.BTOrdemNova.Name = "BTOrdemNova"
        Me.BTOrdemNova.Size = New System.Drawing.Size(93, 27)
        Me.BTOrdemNova.TabIndex = 19
        Me.BTOrdemNova.Text = "Nova Ordem"
        '
        'BtItensMostrar
        '
        Me.BtItensMostrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtItensMostrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtItensMostrar.Location = New System.Drawing.Point(193, 452)
        Me.BtItensMostrar.Name = "BtItensMostrar"
        Me.BtItensMostrar.Size = New System.Drawing.Size(93, 27)
        Me.BtItensMostrar.TabIndex = 18
        Me.BtItensMostrar.Text = "Itens da Ordem"
        '
        'btSalvarImprimir
        '
        Me.btSalvarImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvarImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvarImprimir.Location = New System.Drawing.Point(391, 452)
        Me.btSalvarImprimir.Name = "btSalvarImprimir"
        Me.btSalvarImprimir.Size = New System.Drawing.Size(115, 27)
        Me.btSalvarImprimir.TabIndex = 17
        Me.btSalvarImprimir.Text = "Salvar e Imprimir"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(512, 452)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(93, 27)
        Me.btFechar.TabIndex = 16
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'OrdemEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(620, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OrdemEntrega"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordem de Entrega - T163"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Pedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ordem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSaida As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataEmissao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NomeCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CódigoCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OrdemTemp As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyLista1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents IdTEMP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Observação As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvarImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents AddItensTodos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTOrdemNova As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtItensMostrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
