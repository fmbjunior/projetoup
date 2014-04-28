<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdemEmbarque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdemEmbarque))
        Me.Observação = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.MyLista1 = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.Pedido = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.Ordem = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataSaida = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataEmissao = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.NomeCliente = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.CódigoCliente = New TexBoxFocusNet.TextBoxFocusNet
        Me.AddItens = New System.Windows.Forms.Label
        Me.BtItens = New System.Windows.Forms.Label
        Me.BTOrdem = New System.Windows.Forms.Label
        Me.OrdemTemp = New TexBoxFocusNet.TextBoxFocusNet
        Me.SalvarImprimir = New System.Windows.Forms.Button
        Me.Fechar = New System.Windows.Forms.Button
        Me.IdTEMP = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.PanelOrdem = New DevComponents.DotNetBar.PanelEx
        Me.Panel2 = New DevComponents.DotNetBar.PanelEx
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.Fundo.SuspendLayout()
        Me.PanelOrdem.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Observação
        '
        Me.Observação.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Observação.CasasDecimais = 0
        Me.Observação.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Observação.CPObrigatorio = False
        Me.Observação.CPObrigatorioMsg = Nothing
        Me.Observação.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Observação.FocusColor = System.Drawing.Color.Empty
        Me.Observação.FocusColorEnd = System.Drawing.Color.Empty
        Me.Observação.Location = New System.Drawing.Point(92, 63)
        Me.Observação.MaxLength = 150
        Me.Observação.Name = "Observação"
        Me.Observação.RegraValidação = Nothing
        Me.Observação.RegraValidaçãoMensagem = Nothing
        Me.Observação.Size = New System.Drawing.Size(424, 20)
        Me.Observação.TabIndex = 8
        Me.Observação.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Observação.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
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
        Me.MyLista1.Location = New System.Drawing.Point(7, 244)
        Me.MyLista1.MultiSelect = False
        Me.MyLista1.Name = "MyLista1"
        Me.MyLista1.Size = New System.Drawing.Size(509, 122)
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
        'MyLista
        '
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(7, 116)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(509, 122)
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
        'Pedido
        '
        Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Pedido.CasasDecimais = 0
        Me.Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pedido.CPObrigatorio = False
        Me.Pedido.CPObrigatorioMsg = Nothing
        Me.Pedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Pedido.FocusColor = System.Drawing.Color.Empty
        Me.Pedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pedido.Location = New System.Drawing.Point(268, 11)
        Me.Pedido.MaxLength = 30
        Me.Pedido.Name = "Pedido"
        Me.Pedido.RegraValidação = Nothing
        Me.Pedido.RegraValidaçãoMensagem = Nothing
        Me.Pedido.Size = New System.Drawing.Size(76, 20)
        Me.Pedido.TabIndex = 3
        Me.Pedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pedido.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(180, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Pedido"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ordem
        '
        Me.Ordem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ordem.CasasDecimais = 0
        Me.Ordem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ordem.CPObrigatorio = False
        Me.Ordem.CPObrigatorioMsg = Nothing
        Me.Ordem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ordem.FocusColor = System.Drawing.Color.Empty
        Me.Ordem.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ordem.Location = New System.Drawing.Point(92, 11)
        Me.Ordem.MaxLength = 8
        Me.Ordem.Name = "Ordem"
        Me.Ordem.RegraValidação = Nothing
        Me.Ordem.RegraValidaçãoMensagem = Nothing
        Me.Ordem.Size = New System.Drawing.Size(76, 20)
        Me.Ordem.TabIndex = 1
        Me.Ordem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Ordem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ordem.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nº da Ordem"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataSaida
        '
        Me.DataSaida.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataSaida.CasasDecimais = 0
        Me.DataSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataSaida.CPObrigatorio = False
        Me.DataSaida.CPObrigatorioMsg = Nothing
        Me.DataSaida.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataSaida.FocusColor = System.Drawing.Color.Empty
        Me.DataSaida.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataSaida.Location = New System.Drawing.Point(268, 89)
        Me.DataSaida.MaxLength = 10
        Me.DataSaida.Name = "DataSaida"
        Me.DataSaida.RegraValidação = Nothing
        Me.DataSaida.RegraValidaçãoMensagem = Nothing
        Me.DataSaida.Size = New System.Drawing.Size(76, 20)
        Me.DataSaida.TabIndex = 12
        Me.DataSaida.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataSaida.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(180, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Data Saída"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataEmissao
        '
        Me.DataEmissao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataEmissao.CasasDecimais = 0
        Me.DataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataEmissao.CPObrigatorio = False
        Me.DataEmissao.CPObrigatorioMsg = Nothing
        Me.DataEmissao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataEmissao.FocusColor = System.Drawing.Color.Empty
        Me.DataEmissao.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataEmissao.Location = New System.Drawing.Point(92, 90)
        Me.DataEmissao.MaxLength = 10
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.RegraValidação = Nothing
        Me.DataEmissao.RegraValidaçãoMensagem = Nothing
        Me.DataEmissao.Size = New System.Drawing.Size(76, 20)
        Me.DataEmissao.TabIndex = 10
        Me.DataEmissao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataEmissao.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Data Emissão"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeCliente
        '
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeCliente.CasasDecimais = 0
        Me.NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeCliente.CPObrigatorio = False
        Me.NomeCliente.CPObrigatorioMsg = Nothing
        Me.NomeCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeCliente.FocusColor = System.Drawing.Color.Empty
        Me.NomeCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeCliente.Location = New System.Drawing.Point(172, 37)
        Me.NomeCliente.MaxLength = 50
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.RegraValidação = Nothing
        Me.NomeCliente.RegraValidaçãoMensagem = Nothing
        Me.NomeCliente.Size = New System.Drawing.Size(344, 20)
        Me.NomeCliente.TabIndex = 6
        Me.NomeCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeCliente.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cód. Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CódigoCliente
        '
        Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CódigoCliente.CasasDecimais = 0
        Me.CódigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CódigoCliente.CPObrigatorio = False
        Me.CódigoCliente.CPObrigatorioMsg = Nothing
        Me.CódigoCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CódigoCliente.FocusColor = System.Drawing.Color.Empty
        Me.CódigoCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.CódigoCliente.Location = New System.Drawing.Point(92, 37)
        Me.CódigoCliente.Name = "CódigoCliente"
        Me.CódigoCliente.RegraValidação = Nothing
        Me.CódigoCliente.RegraValidaçãoMensagem = Nothing
        Me.CódigoCliente.Size = New System.Drawing.Size(74, 20)
        Me.CódigoCliente.TabIndex = 5
        Me.CódigoCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CódigoCliente.ValorPadrao = Nothing
        '
        'AddItens
        '
        Me.AddItens.BackColor = System.Drawing.Color.Transparent
        Me.AddItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddItens.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItens.Image = CType(resources.GetObject("AddItens.Image"), System.Drawing.Image)
        Me.AddItens.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddItens.Location = New System.Drawing.Point(2, 271)
        Me.AddItens.Name = "AddItens"
        Me.AddItens.Size = New System.Drawing.Size(119, 98)
        Me.AddItens.TabIndex = 2
        Me.AddItens.Text = "Add. Todos Itens"
        Me.AddItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtItens
        '
        Me.BtItens.BackColor = System.Drawing.Color.Transparent
        Me.BtItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtItens.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtItens.Image = CType(resources.GetObject("BtItens.Image"), System.Drawing.Image)
        Me.BtItens.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtItens.Location = New System.Drawing.Point(3, 86)
        Me.BtItens.Name = "BtItens"
        Me.BtItens.Size = New System.Drawing.Size(119, 86)
        Me.BtItens.TabIndex = 1
        Me.BtItens.Text = "Ordem Itens"
        Me.BtItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BTOrdem
        '
        Me.BTOrdem.BackColor = System.Drawing.Color.Transparent
        Me.BTOrdem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BTOrdem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTOrdem.Image = CType(resources.GetObject("BTOrdem.Image"), System.Drawing.Image)
        Me.BTOrdem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTOrdem.Location = New System.Drawing.Point(3, 0)
        Me.BTOrdem.Name = "BTOrdem"
        Me.BTOrdem.Size = New System.Drawing.Size(119, 86)
        Me.BTOrdem.TabIndex = 0
        Me.BTOrdem.Text = "Ordem Embarque"
        Me.BTOrdem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'OrdemTemp
        '
        Me.OrdemTemp.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.OrdemTemp.CasasDecimais = 0
        Me.OrdemTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OrdemTemp.CPObrigatorio = False
        Me.OrdemTemp.CPObrigatorioMsg = Nothing
        Me.OrdemTemp.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OrdemTemp.FocusColor = System.Drawing.Color.Empty
        Me.OrdemTemp.FocusColorEnd = System.Drawing.Color.Empty
        Me.OrdemTemp.Location = New System.Drawing.Point(12, 388)
        Me.OrdemTemp.MaxLength = 8
        Me.OrdemTemp.Name = "OrdemTemp"
        Me.OrdemTemp.RegraValidação = Nothing
        Me.OrdemTemp.RegraValidaçãoMensagem = Nothing
        Me.OrdemTemp.Size = New System.Drawing.Size(76, 20)
        Me.OrdemTemp.TabIndex = 2
        Me.OrdemTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OrdemTemp.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.OrdemTemp.ValorPadrao = Nothing
        Me.OrdemTemp.Visible = False
        '
        'SalvarImprimir
        '
        Me.SalvarImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalvarImprimir.Image = Global.Up.My.Resources.Resources.Editar
        Me.SalvarImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalvarImprimir.Location = New System.Drawing.Point(395, 386)
        Me.SalvarImprimir.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SalvarImprimir.Name = "SalvarImprimir"
        Me.SalvarImprimir.Size = New System.Drawing.Size(146, 40)
        Me.SalvarImprimir.TabIndex = 3
        Me.SalvarImprimir.Text = "Salvar e Imprimir-F10"
        Me.SalvarImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SalvarImprimir.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Image = Global.Up.My.Resources.Resources.Sair
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(547, 386)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(107, 40)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar-F11"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'IdTEMP
        '
        Me.IdTEMP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IdTEMP.CasasDecimais = 0
        Me.IdTEMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdTEMP.CPObrigatorio = False
        Me.IdTEMP.CPObrigatorioMsg = Nothing
        Me.IdTEMP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdTEMP.FocusColor = System.Drawing.Color.Empty
        Me.IdTEMP.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdTEMP.Location = New System.Drawing.Point(94, 388)
        Me.IdTEMP.MaxLength = 30
        Me.IdTEMP.Name = "IdTEMP"
        Me.IdTEMP.RegraValidação = Nothing
        Me.IdTEMP.RegraValidaçãoMensagem = Nothing
        Me.IdTEMP.Size = New System.Drawing.Size(76, 20)
        Me.IdTEMP.TabIndex = 6
        Me.IdTEMP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdTEMP.ValorPadrao = Nothing
        Me.IdTEMP.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.PanelOrdem)
        Me.Fundo.Controls.Add(Me.Panel2)
        Me.Fundo.Controls.Add(Me.IdTEMP)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.SalvarImprimir)
        Me.Fundo.Controls.Add(Me.OrdemTemp)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(666, 432)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.LightSkyBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 7
        '
        'PanelOrdem
        '
        Me.PanelOrdem.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelOrdem.Controls.Add(Me.Observação)
        Me.PanelOrdem.Controls.Add(Me.Label3)
        Me.PanelOrdem.Controls.Add(Me.Label6)
        Me.PanelOrdem.Controls.Add(Me.CódigoCliente)
        Me.PanelOrdem.Controls.Add(Me.MyLista1)
        Me.PanelOrdem.Controls.Add(Me.Label1)
        Me.PanelOrdem.Controls.Add(Me.MyLista)
        Me.PanelOrdem.Controls.Add(Me.NomeCliente)
        Me.PanelOrdem.Controls.Add(Me.Pedido)
        Me.PanelOrdem.Controls.Add(Me.Label5)
        Me.PanelOrdem.Controls.Add(Me.Label4)
        Me.PanelOrdem.Controls.Add(Me.DataEmissao)
        Me.PanelOrdem.Controls.Add(Me.Ordem)
        Me.PanelOrdem.Controls.Add(Me.Label2)
        Me.PanelOrdem.Controls.Add(Me.DataSaida)
        Me.PanelOrdem.Location = New System.Drawing.Point(135, 7)
        Me.PanelOrdem.Name = "PanelOrdem"
        Me.PanelOrdem.Size = New System.Drawing.Size(523, 375)
        Me.PanelOrdem.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelOrdem.Style.BackColor1.Color = System.Drawing.Color.CadetBlue
        Me.PanelOrdem.Style.BackColor2.Color = System.Drawing.Color.Azure
        Me.PanelOrdem.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelOrdem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelOrdem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelOrdem.Style.GradientAngle = 90
        Me.PanelOrdem.TabIndex = 8
        Me.PanelOrdem.Text = "PanelEx1"
        '
        'Panel2
        '
        Me.Panel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.AddItens)
        Me.Panel2.Controls.Add(Me.BtItens)
        Me.Panel2.Controls.Add(Me.BTOrdem)
        Me.Panel2.Location = New System.Drawing.Point(4, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(125, 375)
        Me.Panel2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Panel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Panel2.Style.GradientAngle = 90
        Me.Panel2.TabIndex = 7
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
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "CustoItem"
        Me.ColumnHeader14.Width = 0
        '
        'OrdemEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(666, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OrdemEmbarque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordem Embarque"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.PanelOrdem.ResumeLayout(False)
        Me.PanelOrdem.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fechar As System.Windows.Forms.Button
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
    Friend WithEvents BtItens As System.Windows.Forms.Label
    Friend WithEvents BTOrdem As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OrdemTemp As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents SalvarImprimir As System.Windows.Forms.Button
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
    Friend WithEvents AddItens As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelOrdem As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
End Class
