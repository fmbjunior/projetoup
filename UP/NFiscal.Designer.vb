<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NFiscal
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotaFiscal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Propriedade = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataEmissao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataSaida = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Modelo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Serie = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Descri��oServi�o = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorServi�o = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ValorIss = New TexBoxFocusNet.TextBoxFocusNet()
        Me.AliquotaIss = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TotalProdutos = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Desconto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TotalNota = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Cnpj = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Incri��o = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IdProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TTIPI = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.UF = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Comfirmado = New System.Windows.Forms.CheckBox()
        Me.ValorInss = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ReterImpostosServi�o = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NatOpera��oDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CFOP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ControlarEstoque = New System.Windows.Forms.CheckBox()
        Me.MenuNFComplementar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DestravarCamposParaNFComplementarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Novo = New DevComponents.DotNetBar.ButtonX()
        Me.btClientes = New DevComponents.DotNetBar.ButtonX()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btItens = New DevComponents.DotNetBar.ButtonX()
        Me.MenuNFComplementar.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota Fiscal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NotaFiscal
        '
        Me.NotaFiscal.AceitaColarTexto = True
        Me.NotaFiscal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.NotaFiscal.CasasDecimais = 0
        Me.NotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NotaFiscal.CPObrigatorio = False
        Me.NotaFiscal.CPObrigatorioMsg = Nothing
        Me.NotaFiscal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.NotaFiscal.FlatBorder = False
        Me.NotaFiscal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.FocusColor = System.Drawing.Color.Empty
        Me.NotaFiscal.FocusColorEnd = System.Drawing.Color.Empty
        Me.NotaFiscal.HighlightBorderOnEnter = False
        Me.NotaFiscal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.Location = New System.Drawing.Point(107, 9)
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.PreencherZeroEsqueda = False
        Me.NotaFiscal.RegraValida��o = Nothing
        Me.NotaFiscal.RegraValida��oMensagem = Nothing
        Me.NotaFiscal.Size = New System.Drawing.Size(82, 23)
        Me.NotaFiscal.TabIndex = 1
        Me.NotaFiscal.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NotaFiscal.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(273, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pedido"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pedido
        '
        Me.Pedido.AceitaColarTexto = True
        Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Pedido.CasasDecimais = 0
        Me.Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pedido.CPObrigatorio = False
        Me.Pedido.CPObrigatorioMsg = Nothing
        Me.Pedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Pedido.FlatBorder = False
        Me.Pedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Pedido.FocusColor = System.Drawing.Color.Empty
        Me.Pedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pedido.HighlightBorderOnEnter = False
        Me.Pedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Pedido.Location = New System.Drawing.Point(399, 8)
        Me.Pedido.Name = "Pedido"
        Me.Pedido.PreencherZeroEsqueda = False
        Me.Pedido.RegraValida��o = Nothing
        Me.Pedido.RegraValida��oMensagem = Nothing
        Me.Pedido.Size = New System.Drawing.Size(116, 23)
        Me.Pedido.TabIndex = 3
        Me.Pedido.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pedido.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CFOP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cliente"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(7, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Prop. Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Propriedade
        '
        Me.Propriedade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Propriedade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Propriedade.FormattingEnabled = True
        Me.Propriedade.Location = New System.Drawing.Point(105, 96)
        Me.Propriedade.Name = "Propriedade"
        Me.Propriedade.Size = New System.Drawing.Size(408, 23)
        Me.Propriedade.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(538, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 19)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Data Emiss�o"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataEmissao
        '
        Me.DataEmissao.AceitaColarTexto = True
        Me.DataEmissao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.DataEmissao.CasasDecimais = 0
        Me.DataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataEmissao.CPObrigatorio = False
        Me.DataEmissao.CPObrigatorioMsg = Nothing
        Me.DataEmissao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.DataEmissao.FlatBorder = False
        Me.DataEmissao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataEmissao.FocusColor = System.Drawing.Color.Empty
        Me.DataEmissao.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataEmissao.HighlightBorderOnEnter = False
        Me.DataEmissao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataEmissao.Location = New System.Drawing.Point(631, 9)
        Me.DataEmissao.MaxLength = 10
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.PreencherZeroEsqueda = False
        Me.DataEmissao.RegraValida��o = Nothing
        Me.DataEmissao.RegraValida��oMensagem = Nothing
        Me.DataEmissao.Size = New System.Drawing.Size(112, 23)
        Me.DataEmissao.TabIndex = 19
        Me.DataEmissao.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataEmissao.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(538, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Data Saida"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataSaida
        '
        Me.DataSaida.AceitaColarTexto = True
        Me.DataSaida.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.DataSaida.CasasDecimais = 0
        Me.DataSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataSaida.CPObrigatorio = False
        Me.DataSaida.CPObrigatorioMsg = Nothing
        Me.DataSaida.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.DataSaida.FlatBorder = False
        Me.DataSaida.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataSaida.FocusColor = System.Drawing.Color.Empty
        Me.DataSaida.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataSaida.HighlightBorderOnEnter = False
        Me.DataSaida.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataSaida.Location = New System.Drawing.Point(631, 38)
        Me.DataSaida.MaxLength = 10
        Me.DataSaida.Name = "DataSaida"
        Me.DataSaida.PreencherZeroEsqueda = False
        Me.DataSaida.RegraValida��o = Nothing
        Me.DataSaida.RegraValida��oMensagem = Nothing
        Me.DataSaida.Size = New System.Drawing.Size(112, 23)
        Me.DataSaida.TabIndex = 21
        Me.DataSaida.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataSaida.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(538, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Modelo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Modelo
        '
        Me.Modelo.AceitaColarTexto = True
        Me.Modelo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Modelo.CasasDecimais = 0
        Me.Modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Modelo.CPObrigatorio = False
        Me.Modelo.CPObrigatorioMsg = Nothing
        Me.Modelo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Modelo.FlatBorder = False
        Me.Modelo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Modelo.FocusColor = System.Drawing.Color.Empty
        Me.Modelo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Modelo.HighlightBorderOnEnter = False
        Me.Modelo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Modelo.Location = New System.Drawing.Point(631, 67)
        Me.Modelo.Name = "Modelo"
        Me.Modelo.PreencherZeroEsqueda = False
        Me.Modelo.RegraValida��o = Nothing
        Me.Modelo.RegraValida��oMensagem = Nothing
        Me.Modelo.Size = New System.Drawing.Size(31, 23)
        Me.Modelo.TabIndex = 23
        Me.Modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Modelo.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Modelo.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(668, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "S�rie"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Serie
        '
        Me.Serie.AceitaColarTexto = True
        Me.Serie.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Serie.CasasDecimais = 0
        Me.Serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Serie.CPObrigatorio = False
        Me.Serie.CPObrigatorioMsg = Nothing
        Me.Serie.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Serie.FlatBorder = False
        Me.Serie.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Serie.FocusColor = System.Drawing.Color.Empty
        Me.Serie.FocusColorEnd = System.Drawing.Color.Empty
        Me.Serie.HighlightBorderOnEnter = False
        Me.Serie.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Serie.Location = New System.Drawing.Point(720, 66)
        Me.Serie.Name = "Serie"
        Me.Serie.PreencherZeroEsqueda = False
        Me.Serie.RegraValida��o = Nothing
        Me.Serie.RegraValida��oMensagem = Nothing
        Me.Serie.Size = New System.Drawing.Size(23, 23)
        Me.Serie.TabIndex = 25
        Me.Serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Serie.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Serie.ValorPadrao = Nothing
        '
        'Descri��oServi�o
        '
        Me.Descri��oServi�o.AceitaColarTexto = True
        Me.Descri��oServi�o.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Descri��oServi�o.CasasDecimais = 0
        Me.Descri��oServi�o.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descri��oServi�o.CPObrigatorio = False
        Me.Descri��oServi�o.CPObrigatorioMsg = Nothing
        Me.Descri��oServi�o.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Descri��oServi�o.FlatBorder = False
        Me.Descri��oServi�o.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Descri��oServi�o.FocusColor = System.Drawing.Color.Empty
        Me.Descri��oServi�o.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descri��oServi�o.HighlightBorderOnEnter = False
        Me.Descri��oServi�o.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Descri��oServi�o.Location = New System.Drawing.Point(263, 214)
        Me.Descri��oServi�o.MaxLength = 700
        Me.Descri��oServi�o.Multiline = True
        Me.Descri��oServi�o.Name = "Descri��oServi�o"
        Me.Descri��oServi�o.PreencherZeroEsqueda = False
        Me.Descri��oServi�o.RegraValida��o = Nothing
        Me.Descri��oServi�o.RegraValida��oMensagem = Nothing
        Me.Descri��oServi�o.Size = New System.Drawing.Size(114, 47)
        Me.Descri��oServi�o.TabIndex = 31
        Me.Descri��oServi�o.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descri��oServi�o.ValorPadrao = Nothing
        Me.Descri��oServi�o.Visible = False
        '
        'ValorServi�o
        '
        Me.ValorServi�o.AceitaColarTexto = True
        Me.ValorServi�o.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ValorServi�o.CasasDecimais = 2
        Me.ValorServi�o.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorServi�o.CPObrigatorio = False
        Me.ValorServi�o.CPObrigatorioMsg = Nothing
        Me.ValorServi�o.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorServi�o.FlatBorder = False
        Me.ValorServi�o.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorServi�o.FocusColor = System.Drawing.Color.Empty
        Me.ValorServi�o.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorServi�o.HighlightBorderOnEnter = False
        Me.ValorServi�o.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorServi�o.Location = New System.Drawing.Point(263, 267)
        Me.ValorServi�o.MaxLength = 10
        Me.ValorServi�o.Name = "ValorServi�o"
        Me.ValorServi�o.PreencherZeroEsqueda = False
        Me.ValorServi�o.RegraValida��o = Nothing
        Me.ValorServi�o.RegraValida��oMensagem = Nothing
        Me.ValorServi�o.Size = New System.Drawing.Size(31, 23)
        Me.ValorServi�o.TabIndex = 33
        Me.ValorServi�o.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorServi�o.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorServi�o.ValorPadrao = Nothing
        Me.ValorServi�o.Visible = False
        '
        'ValorIss
        '
        Me.ValorIss.AceitaColarTexto = True
        Me.ValorIss.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ValorIss.CasasDecimais = 2
        Me.ValorIss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorIss.CPObrigatorio = False
        Me.ValorIss.CPObrigatorioMsg = Nothing
        Me.ValorIss.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorIss.FlatBorder = False
        Me.ValorIss.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIss.FocusColor = System.Drawing.Color.Empty
        Me.ValorIss.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIss.HighlightBorderOnEnter = False
        Me.ValorIss.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIss.Location = New System.Drawing.Point(346, 267)
        Me.ValorIss.MaxLength = 10
        Me.ValorIss.Name = "ValorIss"
        Me.ValorIss.PreencherZeroEsqueda = False
        Me.ValorIss.RegraValida��o = Nothing
        Me.ValorIss.RegraValida��oMensagem = Nothing
        Me.ValorIss.Size = New System.Drawing.Size(31, 23)
        Me.ValorIss.TabIndex = 37
        Me.ValorIss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorIss.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorIss.ValorPadrao = Nothing
        Me.ValorIss.Visible = False
        '
        'AliquotaIss
        '
        Me.AliquotaIss.AceitaColarTexto = True
        Me.AliquotaIss.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.AliquotaIss.CasasDecimais = 0
        Me.AliquotaIss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AliquotaIss.CPObrigatorio = False
        Me.AliquotaIss.CPObrigatorioMsg = Nothing
        Me.AliquotaIss.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.AliquotaIss.FlatBorder = False
        Me.AliquotaIss.FlatBorderColor = System.Drawing.Color.DimGray
        Me.AliquotaIss.FocusColor = System.Drawing.Color.Empty
        Me.AliquotaIss.FocusColorEnd = System.Drawing.Color.Empty
        Me.AliquotaIss.HighlightBorderOnEnter = False
        Me.AliquotaIss.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.AliquotaIss.Location = New System.Drawing.Point(304, 267)
        Me.AliquotaIss.Name = "AliquotaIss"
        Me.AliquotaIss.PreencherZeroEsqueda = False
        Me.AliquotaIss.RegraValida��o = Nothing
        Me.AliquotaIss.RegraValida��oMensagem = Nothing
        Me.AliquotaIss.Size = New System.Drawing.Size(36, 23)
        Me.AliquotaIss.TabIndex = 35
        Me.AliquotaIss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AliquotaIss.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AliquotaIss.ValorPadrao = Nothing
        Me.AliquotaIss.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(12, 453)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 19)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Total Produtos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalProdutos
        '
        Me.TotalProdutos.AceitaColarTexto = True
        Me.TotalProdutos.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalProdutos.CasasDecimais = 2
        Me.TotalProdutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalProdutos.CPObrigatorio = False
        Me.TotalProdutos.CPObrigatorioMsg = Nothing
        Me.TotalProdutos.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.TotalProdutos.FlatBorder = False
        Me.TotalProdutos.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalProdutos.FocusColor = System.Drawing.Color.Empty
        Me.TotalProdutos.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalProdutos.HighlightBorderOnEnter = False
        Me.TotalProdutos.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalProdutos.Location = New System.Drawing.Point(118, 452)
        Me.TotalProdutos.MaxLength = 10
        Me.TotalProdutos.Name = "TotalProdutos"
        Me.TotalProdutos.PreencherZeroEsqueda = False
        Me.TotalProdutos.RegraValida��o = Nothing
        Me.TotalProdutos.RegraValida��oMensagem = Nothing
        Me.TotalProdutos.Size = New System.Drawing.Size(135, 23)
        Me.TotalProdutos.TabIndex = 43
        Me.TotalProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalProdutos.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalProdutos.ValorPadrao = Nothing
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(272, 454)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 19)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Desconto"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Desconto
        '
        Me.Desconto.AceitaColarTexto = True
        Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Desconto.CasasDecimais = 2
        Me.Desconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Desconto.CPObrigatorio = False
        Me.Desconto.CPObrigatorioMsg = Nothing
        Me.Desconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Desconto.FlatBorder = False
        Me.Desconto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Desconto.FocusColor = System.Drawing.Color.Empty
        Me.Desconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desconto.HighlightBorderOnEnter = False
        Me.Desconto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Desconto.Location = New System.Drawing.Point(379, 453)
        Me.Desconto.MaxLength = 10
        Me.Desconto.Name = "Desconto"
        Me.Desconto.PreencherZeroEsqueda = False
        Me.Desconto.RegraValida��o = Nothing
        Me.Desconto.RegraValida��oMensagem = Nothing
        Me.Desconto.Size = New System.Drawing.Size(134, 23)
        Me.Desconto.TabIndex = 45
        Me.Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Desconto.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Desconto.ValorPadrao = Nothing
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(519, 455)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 19)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Total da Nota"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalNota
        '
        Me.TotalNota.AceitaColarTexto = True
        Me.TotalNota.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalNota.CasasDecimais = 2
        Me.TotalNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalNota.CPObrigatorio = False
        Me.TotalNota.CPObrigatorioMsg = Nothing
        Me.TotalNota.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.TotalNota.FlatBorder = False
        Me.TotalNota.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalNota.FocusColor = System.Drawing.Color.Empty
        Me.TotalNota.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalNota.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNota.ForeColor = System.Drawing.Color.Navy
        Me.TotalNota.HighlightBorderOnEnter = False
        Me.TotalNota.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalNota.Location = New System.Drawing.Point(616, 454)
        Me.TotalNota.MaxLength = 10
        Me.TotalNota.Name = "TotalNota"
        Me.TotalNota.PreencherZeroEsqueda = False
        Me.TotalNota.RegraValida��o = Nothing
        Me.TotalNota.RegraValida��oMensagem = Nothing
        Me.TotalNota.Size = New System.Drawing.Size(134, 23)
        Me.TotalNota.TabIndex = 47
        Me.TotalNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalNota.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalNota.ValorPadrao = Nothing
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(7, 126)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 19)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Cnpj/Cpf"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cnpj
        '
        Me.Cnpj.AceitaColarTexto = True
        Me.Cnpj.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Cnpj.CasasDecimais = 0
        Me.Cnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cnpj.CPObrigatorio = False
        Me.Cnpj.CPObrigatorioMsg = Nothing
        Me.Cnpj.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Cnpj.FlatBorder = False
        Me.Cnpj.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cnpj.FocusColor = System.Drawing.Color.Empty
        Me.Cnpj.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cnpj.HighlightBorderOnEnter = False
        Me.Cnpj.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cnpj.Location = New System.Drawing.Point(105, 125)
        Me.Cnpj.Name = "Cnpj"
        Me.Cnpj.PreencherZeroEsqueda = False
        Me.Cnpj.RegraValida��o = Nothing
        Me.Cnpj.RegraValida��oMensagem = Nothing
        Me.Cnpj.Size = New System.Drawing.Size(114, 23)
        Me.Cnpj.TabIndex = 13
        Me.Cnpj.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cnpj.ValorPadrao = Nothing
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(237, 125)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 19)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Inscr. Estadual"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Incri��o
        '
        Me.Incri��o.AceitaColarTexto = True
        Me.Incri��o.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Incri��o.CasasDecimais = 0
        Me.Incri��o.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Incri��o.CPObrigatorio = False
        Me.Incri��o.CPObrigatorioMsg = Nothing
        Me.Incri��o.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Incri��o.FlatBorder = False
        Me.Incri��o.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Incri��o.FocusColor = System.Drawing.Color.Empty
        Me.Incri��o.FocusColorEnd = System.Drawing.Color.Empty
        Me.Incri��o.HighlightBorderOnEnter = False
        Me.Incri��o.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Incri��o.Location = New System.Drawing.Point(345, 125)
        Me.Incri��o.Name = "Incri��o"
        Me.Incri��o.PreencherZeroEsqueda = False
        Me.Incri��o.RegraValida��o = Nothing
        Me.Incri��o.RegraValida��oMensagem = Nothing
        Me.Incri��o.Size = New System.Drawing.Size(108, 23)
        Me.Incri��o.TabIndex = 15
        Me.Incri��o.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Incri��o.ValorPadrao = Nothing
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(106, 67)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValida��o = Nothing
        Me.Cliente.RegraValida��oMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(82, 23)
        Me.Cliente.TabIndex = 8
        Me.Cliente.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = True
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ClienteDesc.FlatBorder = False
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.FocusColor = System.Drawing.Color.Empty
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(194, 67)
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValida��o = Nothing
        Me.ClienteDesc.RegraValida��oMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(320, 23)
        Me.ClienteDesc.TabIndex = 9
        Me.ClienteDesc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader1})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(6, 155)
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(746, 291)
        Me.MyLista.TabIndex = 28
        Me.MyLista.TabStop = False
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Cod Prod"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Descri��o"
        Me.ColumnHeader15.Width = 125
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Qtd"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "CST"
        Me.ColumnHeader17.Width = 35
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "CF"
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Unit�rio"
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Vlr Desc"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Vlr Total"
        Me.ColumnHeader21.Width = 70
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "ICMS"
        Me.ColumnHeader22.Width = 45
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "IPI"
        Me.ColumnHeader23.Width = 40
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Valor Ipi"
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "SeqNF"
        Me.ColumnHeader25.Width = 50
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 0
        '
        'IdProduto
        '
        Me.IdProduto.AceitaColarTexto = True
        Me.IdProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IdProduto.CasasDecimais = 0
        Me.IdProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdProduto.CPObrigatorio = False
        Me.IdProduto.CPObrigatorioMsg = Nothing
        Me.IdProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.IdProduto.FlatBorder = False
        Me.IdProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdProduto.FocusColor = System.Drawing.Color.Empty
        Me.IdProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdProduto.HighlightBorderOnEnter = False
        Me.IdProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdProduto.Location = New System.Drawing.Point(657, 289)
        Me.IdProduto.Name = "IdProduto"
        Me.IdProduto.PreencherZeroEsqueda = False
        Me.IdProduto.RegraValida��o = Nothing
        Me.IdProduto.RegraValida��oMensagem = Nothing
        Me.IdProduto.Size = New System.Drawing.Size(95, 23)
        Me.IdProduto.TabIndex = 29
        Me.IdProduto.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdProduto.ValorPadrao = Nothing
        Me.IdProduto.Visible = False
        '
        'TTIPI
        '
        Me.TTIPI.AceitaColarTexto = True
        Me.TTIPI.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TTIPI.CasasDecimais = 2
        Me.TTIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TTIPI.CPObrigatorio = False
        Me.TTIPI.CPObrigatorioMsg = Nothing
        Me.TTIPI.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.TTIPI.FlatBorder = False
        Me.TTIPI.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TTIPI.FocusColor = System.Drawing.Color.Empty
        Me.TTIPI.FocusColorEnd = System.Drawing.Color.Empty
        Me.TTIPI.HighlightBorderOnEnter = False
        Me.TTIPI.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TTIPI.Location = New System.Drawing.Point(263, 296)
        Me.TTIPI.MaxLength = 10
        Me.TTIPI.Name = "TTIPI"
        Me.TTIPI.PreencherZeroEsqueda = False
        Me.TTIPI.RegraValida��o = Nothing
        Me.TTIPI.RegraValida��oMensagem = Nothing
        Me.TTIPI.Size = New System.Drawing.Size(114, 23)
        Me.TTIPI.TabIndex = 52
        Me.TTIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TTIPI.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TTIPI.ValorPadrao = Nothing
        Me.TTIPI.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(453, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 19)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "UF"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UF
        '
        Me.UF.AceitaColarTexto = True
        Me.UF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.UF.CasasDecimais = 0
        Me.UF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UF.CPObrigatorio = False
        Me.UF.CPObrigatorioMsg = Nothing
        Me.UF.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.UF.FlatBorder = False
        Me.UF.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UF.FocusColor = System.Drawing.Color.Empty
        Me.UF.FocusColorEnd = System.Drawing.Color.Empty
        Me.UF.HighlightBorderOnEnter = False
        Me.UF.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.UF.Location = New System.Drawing.Point(479, 125)
        Me.UF.Name = "UF"
        Me.UF.PreencherZeroEsqueda = False
        Me.UF.RegraValida��o = Nothing
        Me.UF.RegraValida��oMensagem = Nothing
        Me.UF.Size = New System.Drawing.Size(34, 23)
        Me.UF.TabIndex = 17
        Me.UF.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UF.ValorPadrao = Nothing
        '
        'Comfirmado
        '
        Me.Comfirmado.AutoSize = True
        Me.Comfirmado.Enabled = False
        Me.Comfirmado.Location = New System.Drawing.Point(25, 490)
        Me.Comfirmado.Name = "Comfirmado"
        Me.Comfirmado.Size = New System.Drawing.Size(147, 19)
        Me.Comfirmado.TabIndex = 51
        Me.Comfirmado.Text = "Nota Fiscal Confirmada"
        Me.Comfirmado.UseVisualStyleBackColor = True
        '
        'ValorInss
        '
        Me.ValorInss.AceitaColarTexto = True
        Me.ValorInss.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ValorInss.CasasDecimais = 2
        Me.ValorInss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorInss.CPObrigatorio = False
        Me.ValorInss.CPObrigatorioMsg = Nothing
        Me.ValorInss.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorInss.FlatBorder = False
        Me.ValorInss.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorInss.FocusColor = System.Drawing.Color.Empty
        Me.ValorInss.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorInss.HighlightBorderOnEnter = False
        Me.ValorInss.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorInss.Location = New System.Drawing.Point(263, 185)
        Me.ValorInss.MaxLength = 10
        Me.ValorInss.Name = "ValorInss"
        Me.ValorInss.PreencherZeroEsqueda = False
        Me.ValorInss.RegraValida��o = Nothing
        Me.ValorInss.RegraValida��oMensagem = Nothing
        Me.ValorInss.Size = New System.Drawing.Size(77, 23)
        Me.ValorInss.TabIndex = 39
        Me.ValorInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorInss.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorInss.ValorPadrao = Nothing
        Me.ValorInss.Visible = False
        '
        'ReterImpostosServi�o
        '
        Me.ReterImpostosServi�o.AceitaColarTexto = True
        Me.ReterImpostosServi�o.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ReterImpostosServi�o.CasasDecimais = 2
        Me.ReterImpostosServi�o.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReterImpostosServi�o.CPObrigatorio = False
        Me.ReterImpostosServi�o.CPObrigatorioMsg = Nothing
        Me.ReterImpostosServi�o.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ReterImpostosServi�o.FlatBorder = False
        Me.ReterImpostosServi�o.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ReterImpostosServi�o.FocusColor = System.Drawing.Color.Empty
        Me.ReterImpostosServi�o.FocusColorEnd = System.Drawing.Color.Empty
        Me.ReterImpostosServi�o.HighlightBorderOnEnter = False
        Me.ReterImpostosServi�o.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ReterImpostosServi�o.Location = New System.Drawing.Point(346, 185)
        Me.ReterImpostosServi�o.MaxLength = 1
        Me.ReterImpostosServi�o.Name = "ReterImpostosServi�o"
        Me.ReterImpostosServi�o.PreencherZeroEsqueda = False
        Me.ReterImpostosServi�o.RegraValida��o = Nothing
        Me.ReterImpostosServi�o.RegraValida��oMensagem = Nothing
        Me.ReterImpostosServi�o.Size = New System.Drawing.Size(25, 23)
        Me.ReterImpostosServi�o.TabIndex = 41
        Me.ReterImpostosServi�o.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ReterImpostosServi�o.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ReterImpostosServi�o.ValorPadrao = Nothing
        Me.ReterImpostosServi�o.Visible = False
        '
        'NatOpera��oDesc
        '
        Me.NatOpera��oDesc.AceitaColarTexto = True
        Me.NatOpera��oDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NatOpera��oDesc.CasasDecimais = 0
        Me.NatOpera��oDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NatOpera��oDesc.CPObrigatorio = False
        Me.NatOpera��oDesc.CPObrigatorioMsg = Nothing
        Me.NatOpera��oDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.NatOpera��oDesc.FlatBorder = False
        Me.NatOpera��oDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NatOpera��oDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.NatOpera��oDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.NatOpera��oDesc.HighlightBorderOnEnter = False
        Me.NatOpera��oDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NatOpera��oDesc.Location = New System.Drawing.Point(194, 38)
        Me.NatOpera��oDesc.Name = "NatOpera��oDesc"
        Me.NatOpera��oDesc.PreencherZeroEsqueda = False
        Me.NatOpera��oDesc.RegraValida��o = Nothing
        Me.NatOpera��oDesc.RegraValida��oMensagem = Nothing
        Me.NatOpera��oDesc.Size = New System.Drawing.Size(320, 23)
        Me.NatOpera��oDesc.TabIndex = 6
        Me.NatOpera��oDesc.TabStop = False
        Me.NatOpera��oDesc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NatOpera��oDesc.ValorPadrao = Nothing
        '
        'CFOP
        '
        Me.CFOP.AceitaColarTexto = True
        Me.CFOP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.CFOP.CasasDecimais = 0
        Me.CFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CFOP.CPObrigatorio = False
        Me.CFOP.CPObrigatorioMsg = Nothing
        Me.CFOP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.CFOP.FlatBorder = False
        Me.CFOP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CFOP.FocusColor = System.Drawing.Color.MistyRose
        Me.CFOP.FocusColorEnd = System.Drawing.Color.Empty
        Me.CFOP.HighlightBorderOnEnter = False
        Me.CFOP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CFOP.Location = New System.Drawing.Point(106, 38)
        Me.CFOP.Name = "CFOP"
        Me.CFOP.PreencherZeroEsqueda = False
        Me.CFOP.RegraValida��o = Nothing
        Me.CFOP.RegraValida��oMensagem = Nothing
        Me.CFOP.Size = New System.Drawing.Size(82, 23)
        Me.CFOP.TabIndex = 5
        Me.CFOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CFOP.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CFOP.ValorPadrao = Nothing
        '
        'ControlarEstoque
        '
        Me.ControlarEstoque.AutoSize = True
        Me.ControlarEstoque.Location = New System.Drawing.Point(631, 96)
        Me.ControlarEstoque.Name = "ControlarEstoque"
        Me.ControlarEstoque.Size = New System.Drawing.Size(112, 19)
        Me.ControlarEstoque.TabIndex = 26
        Me.ControlarEstoque.Text = "Controla Estoque"
        Me.ControlarEstoque.UseVisualStyleBackColor = True
        Me.ControlarEstoque.Visible = False
        '
        'MenuNFComplementar
        '
        Me.MenuNFComplementar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DestravarCamposParaNFComplementarToolStripMenuItem})
        Me.MenuNFComplementar.Name = "MenuNFComplementar"
        Me.MenuNFComplementar.Size = New System.Drawing.Size(298, 26)
        '
        'DestravarCamposParaNFComplementarToolStripMenuItem
        '
        Me.DestravarCamposParaNFComplementarToolStripMenuItem.Name = "DestravarCamposParaNFComplementarToolStripMenuItem"
        Me.DestravarCamposParaNFComplementarToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.DestravarCamposParaNFComplementarToolStripMenuItem.Text = "Destravar Campos Para NF Complementar"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Novo)
        Me.Fundo.Controls.Add(Me.btClientes)
        Me.Fundo.Controls.Add(Me.btConfirmar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.btItens)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.NotaFiscal)
        Me.Fundo.Controls.Add(Me.ControlarEstoque)
        Me.Fundo.Controls.Add(Me.Pedido)
        Me.Fundo.Controls.Add(Me.NatOpera��oDesc)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.CFOP)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.ReterImpostosServi�o)
        Me.Fundo.Controls.Add(Me.Propriedade)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.ValorInss)
        Me.Fundo.Controls.Add(Me.DataEmissao)
        Me.Fundo.Controls.Add(Me.Comfirmado)
        Me.Fundo.Controls.Add(Me.Label19)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.DataSaida)
        Me.Fundo.Controls.Add(Me.UF)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.TTIPI)
        Me.Fundo.Controls.Add(Me.Modelo)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.IdProduto)
        Me.Fundo.Controls.Add(Me.Serie)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Descri��oServi�o)
        Me.Fundo.Controls.Add(Me.ClienteDesc)
        Me.Fundo.Controls.Add(Me.ValorServi�o)
        Me.Fundo.Controls.Add(Me.Cliente)
        Me.Fundo.Controls.Add(Me.Label21)
        Me.Fundo.Controls.Add(Me.ValorIss)
        Me.Fundo.Controls.Add(Me.Incri��o)
        Me.Fundo.Controls.Add(Me.Label20)
        Me.Fundo.Controls.Add(Me.AliquotaIss)
        Me.Fundo.Controls.Add(Me.Cnpj)
        Me.Fundo.Controls.Add(Me.Label18)
        Me.Fundo.Controls.Add(Me.TotalNota)
        Me.Fundo.Controls.Add(Me.TotalProdutos)
        Me.Fundo.Controls.Add(Me.Label14)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Desconto)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(759, 519)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Novo
        '
        Me.Novo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Novo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Novo.Location = New System.Drawing.Point(419, 486)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(89, 23)
        Me.Novo.TabIndex = 53
        Me.Novo.Text = "Novo"
        '
        'btClientes
        '
        Me.btClientes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btClientes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btClientes.Location = New System.Drawing.Point(514, 486)
        Me.btClientes.Name = "btClientes"
        Me.btClientes.Size = New System.Drawing.Size(76, 23)
        Me.btClientes.TabIndex = 49
        Me.btClientes.Text = "Clientes"
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(596, 486)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(76, 23)
        Me.btConfirmar.TabIndex = 48
        Me.btConfirmar.Text = "Confirmar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(678, 486)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(76, 23)
        Me.btFechar.TabIndex = 50
        Me.btFechar.Text = "Fechar"
        '
        'btItens
        '
        Me.btItens.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btItens.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btItens.Location = New System.Drawing.Point(616, 126)
        Me.btItens.Name = "btItens"
        Me.btItens.Size = New System.Drawing.Size(127, 23)
        Me.btItens.TabIndex = 27
        Me.btItens.Text = "Itens da Nota Fiscal"
        '
        'NFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(759, 519)
        Me.ContextMenuStrip = Me.MenuNFComplementar
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NFiscal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota Fiscal - T153"
        Me.MenuNFComplementar.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NotaFiscal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Propriedade As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DataEmissao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSaida As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Modelo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Serie As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Descri��oServi�o As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorServi�o As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ValorIss As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents AliquotaIss As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TotalProdutos As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Desconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TotalNota As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Cnpj As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Incri��o As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents IdProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TTIPI As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents UF As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Comfirmado As System.Windows.Forms.CheckBox
    Friend WithEvents ValorInss As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ReterImpostosServi�o As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NatOpera��oDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CFOP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ControlarEstoque As System.Windows.Forms.CheckBox
    Friend WithEvents MenuNFComplementar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DestravarCamposParaNFComplementarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btItens As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btClientes As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Novo As DevComponents.DotNetBar.ButtonX
End Class
