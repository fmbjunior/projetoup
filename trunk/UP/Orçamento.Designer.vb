<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orçamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orçamento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodOrçamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CódigoCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NomeCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CpfCnpj = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RgInscrição = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataOrçamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Validade = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ValorProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VlrDescProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TotalOrcamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CódigoPagamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.GeradoPedido = New System.Windows.Forms.CheckBox()
        Me.FuncionarioDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CódigoFuncionário = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ConfImg = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btExportar = New DevComponents.DotNetBar.ButtonX()
        Me.btItens = New DevComponents.DotNetBar.ButtonX()
        Me.btImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btLocalizar = New DevComponents.DotNetBar.ButtonX()
        Me.btEditar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PedidoGerado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PedidoGeradoLabel = New System.Windows.Forms.Label()
        Me.btFindVendedor = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btEditarCliente = New System.Windows.Forms.Label()
        Me.btClienteFind = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orçamento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodOrçamento
        '
        Me.CodOrçamento.AceitaColarTexto = True
        Me.CodOrçamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodOrçamento.CasasDecimais = 0
        Me.CodOrçamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodOrçamento.CPObrigatorio = False
        Me.CodOrçamento.CPObrigatorioMsg = Nothing
        Me.CodOrçamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodOrçamento.FlatBorder = False
        Me.CodOrçamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodOrçamento.FocusColor = System.Drawing.Color.Empty
        Me.CodOrçamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodOrçamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodOrçamento.HighlightBorderOnEnter = False
        Me.CodOrçamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodOrçamento.Location = New System.Drawing.Point(121, 3)
        Me.CodOrçamento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CodOrçamento.Name = "CodOrçamento"
        Me.CodOrçamento.PreencherZeroEsqueda = False
        Me.CodOrçamento.RegraValidação = Nothing
        Me.CodOrçamento.RegraValidaçãoMensagem = Nothing
        Me.CodOrçamento.Size = New System.Drawing.Size(67, 23)
        Me.CodOrçamento.TabIndex = 1
        Me.CodOrçamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodOrçamento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.CódigoCliente.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CódigoCliente.HighlightBorderOnEnter = False
        Me.CódigoCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CódigoCliente.Location = New System.Drawing.Point(121, 0)
        Me.CódigoCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CódigoCliente.Name = "CódigoCliente"
        Me.CódigoCliente.PreencherZeroEsqueda = False
        Me.CódigoCliente.RegraValidação = Nothing
        Me.CódigoCliente.RegraValidaçãoMensagem = Nothing
        Me.CódigoCliente.Size = New System.Drawing.Size(65, 23)
        Me.CódigoCliente.TabIndex = 1
        Me.CódigoCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CódigoCliente.ValorPadrao = Nothing
        '
        'NomeCliente
        '
        Me.NomeCliente.AceitaColarTexto = True
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NomeCliente.CasasDecimais = 0
        Me.NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeCliente.CPObrigatorio = False
        Me.NomeCliente.CPObrigatorioMsg = Nothing
        Me.NomeCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeCliente.FlatBorder = False
        Me.NomeCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeCliente.FocusColor = System.Drawing.Color.Empty
        Me.NomeCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeCliente.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeCliente.HighlightBorderOnEnter = False
        Me.NomeCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeCliente.Location = New System.Drawing.Point(121, 30)
        Me.NomeCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.PreencherZeroEsqueda = False
        Me.NomeCliente.RegraValidação = Nothing
        Me.NomeCliente.RegraValidaçãoMensagem = Nothing
        Me.NomeCliente.Size = New System.Drawing.Size(330, 23)
        Me.NomeCliente.TabIndex = 2
        Me.NomeCliente.TabStop = False
        Me.NomeCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeCliente.ValorPadrao = Nothing
        '
        'CpfCnpj
        '
        Me.CpfCnpj.AceitaColarTexto = True
        Me.CpfCnpj.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CpfCnpj.CasasDecimais = 0
        Me.CpfCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CpfCnpj.CPObrigatorio = False
        Me.CpfCnpj.CPObrigatorioMsg = Nothing
        Me.CpfCnpj.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CpfCnpj.FlatBorder = False
        Me.CpfCnpj.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CpfCnpj.FocusColor = System.Drawing.Color.Empty
        Me.CpfCnpj.FocusColorEnd = System.Drawing.Color.Empty
        Me.CpfCnpj.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpfCnpj.HighlightBorderOnEnter = False
        Me.CpfCnpj.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CpfCnpj.Location = New System.Drawing.Point(121, 62)
        Me.CpfCnpj.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CpfCnpj.Name = "CpfCnpj"
        Me.CpfCnpj.PreencherZeroEsqueda = False
        Me.CpfCnpj.RegraValidação = Nothing
        Me.CpfCnpj.RegraValidaçãoMensagem = Nothing
        Me.CpfCnpj.Size = New System.Drawing.Size(170, 23)
        Me.CpfCnpj.TabIndex = 4
        Me.CpfCnpj.TabStop = False
        Me.CpfCnpj.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CpfCnpj.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cpf/Cnpj"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Rg/Inscrição"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RgInscrição
        '
        Me.RgInscrição.AceitaColarTexto = True
        Me.RgInscrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.RgInscrição.CasasDecimais = 0
        Me.RgInscrição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RgInscrição.CPObrigatorio = False
        Me.RgInscrição.CPObrigatorioMsg = Nothing
        Me.RgInscrição.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.RgInscrição.FlatBorder = False
        Me.RgInscrição.FlatBorderColor = System.Drawing.Color.DimGray
        Me.RgInscrição.FocusColor = System.Drawing.Color.Empty
        Me.RgInscrição.FocusColorEnd = System.Drawing.Color.Empty
        Me.RgInscrição.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RgInscrição.HighlightBorderOnEnter = False
        Me.RgInscrição.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.RgInscrição.Location = New System.Drawing.Point(121, 91)
        Me.RgInscrição.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RgInscrição.Name = "RgInscrição"
        Me.RgInscrição.PreencherZeroEsqueda = False
        Me.RgInscrição.RegraValidação = Nothing
        Me.RgInscrição.RegraValidaçãoMensagem = Nothing
        Me.RgInscrição.Size = New System.Drawing.Size(170, 23)
        Me.RgInscrição.TabIndex = 6
        Me.RgInscrição.TabStop = False
        Me.RgInscrição.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.RgInscrição.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Data Orçamento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataOrçamento
        '
        Me.DataOrçamento.AceitaColarTexto = True
        Me.DataOrçamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataOrçamento.CasasDecimais = 0
        Me.DataOrçamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataOrçamento.CPObrigatorio = False
        Me.DataOrçamento.CPObrigatorioMsg = Nothing
        Me.DataOrçamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataOrçamento.FlatBorder = False
        Me.DataOrçamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataOrçamento.FocusColor = System.Drawing.Color.Empty
        Me.DataOrçamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataOrçamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataOrçamento.HighlightBorderOnEnter = False
        Me.DataOrçamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataOrçamento.Location = New System.Drawing.Point(315, 0)
        Me.DataOrçamento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataOrçamento.MaxLength = 10
        Me.DataOrçamento.Name = "DataOrçamento"
        Me.DataOrçamento.PreencherZeroEsqueda = False
        Me.DataOrçamento.RegraValidação = Nothing
        Me.DataOrçamento.RegraValidaçãoMensagem = Nothing
        Me.DataOrçamento.Size = New System.Drawing.Size(94, 23)
        Me.DataOrçamento.TabIndex = 3
        Me.DataOrçamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataOrçamento.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Validade em Dias"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Validade
        '
        Me.Validade.AceitaColarTexto = False
        Me.Validade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Validade.CasasDecimais = 0
        Me.Validade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Validade.CPObrigatorio = False
        Me.Validade.CPObrigatorioMsg = Nothing
        Me.Validade.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Validade.FlatBorder = False
        Me.Validade.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Validade.FocusColor = System.Drawing.Color.Empty
        Me.Validade.FocusColorEnd = System.Drawing.Color.Empty
        Me.Validade.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Validade.HighlightBorderOnEnter = False
        Me.Validade.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Validade.Location = New System.Drawing.Point(121, 32)
        Me.Validade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Validade.MaxLength = 15
        Me.Validade.Name = "Validade"
        Me.Validade.PreencherZeroEsqueda = False
        Me.Validade.RegraValidação = Nothing
        Me.Validade.RegraValidaçãoMensagem = Nothing
        Me.Validade.Size = New System.Drawing.Size(51, 23)
        Me.Validade.TabIndex = 5
        Me.Validade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Validade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.Validade.ValorPadrao = Nothing
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader5})
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(13, 176)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(887, 275)
        Me.MyLista.TabIndex = 3
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 5
        Me.ColumnHeader6.Text = "Id"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 0
        Me.ColumnHeader1.Text = "Cod"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 1
        Me.ColumnHeader2.Text = "Descrição"
        Me.ColumnHeader2.Width = 370
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 2
        Me.ColumnHeader3.Text = "Qtd"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 3
        Me.ColumnHeader4.Text = "Unitario"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 4
        Me.ColumnHeader7.Text = "Vlr. Desc."
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 100
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Produtos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorProduto
        '
        Me.ValorProduto.AceitaColarTexto = True
        Me.ValorProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorProduto.CasasDecimais = 0
        Me.ValorProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorProduto.CPObrigatorio = False
        Me.ValorProduto.CPObrigatorioMsg = Nothing
        Me.ValorProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorProduto.FlatBorder = False
        Me.ValorProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorProduto.FocusColor = System.Drawing.Color.Empty
        Me.ValorProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorProduto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorProduto.ForeColor = System.Drawing.Color.Green
        Me.ValorProduto.HighlightBorderOnEnter = False
        Me.ValorProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorProduto.Location = New System.Drawing.Point(109, 4)
        Me.ValorProduto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ValorProduto.Name = "ValorProduto"
        Me.ValorProduto.PreencherZeroEsqueda = False
        Me.ValorProduto.RegraValidação = Nothing
        Me.ValorProduto.RegraValidaçãoMensagem = Nothing
        Me.ValorProduto.Size = New System.Drawing.Size(146, 23)
        Me.ValorProduto.TabIndex = 5
        Me.ValorProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorProduto.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Descontos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VlrDescProduto
        '
        Me.VlrDescProduto.AceitaColarTexto = True
        Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.VlrDescProduto.CasasDecimais = 0
        Me.VlrDescProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VlrDescProduto.CPObrigatorio = False
        Me.VlrDescProduto.CPObrigatorioMsg = Nothing
        Me.VlrDescProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VlrDescProduto.FlatBorder = False
        Me.VlrDescProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.VlrDescProduto.FocusColor = System.Drawing.Color.Empty
        Me.VlrDescProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.VlrDescProduto.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VlrDescProduto.ForeColor = System.Drawing.Color.Maroon
        Me.VlrDescProduto.HighlightBorderOnEnter = False
        Me.VlrDescProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.VlrDescProduto.Location = New System.Drawing.Point(109, 33)
        Me.VlrDescProduto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.VlrDescProduto.Name = "VlrDescProduto"
        Me.VlrDescProduto.PreencherZeroEsqueda = False
        Me.VlrDescProduto.RegraValidação = Nothing
        Me.VlrDescProduto.RegraValidaçãoMensagem = Nothing
        Me.VlrDescProduto.Size = New System.Drawing.Size(146, 23)
        Me.VlrDescProduto.TabIndex = 7
        Me.VlrDescProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrDescProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.VlrDescProduto.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Total Orçamento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalOrcamento
        '
        Me.TotalOrcamento.AceitaColarTexto = True
        Me.TotalOrcamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalOrcamento.CasasDecimais = 0
        Me.TotalOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalOrcamento.CPObrigatorio = False
        Me.TotalOrcamento.CPObrigatorioMsg = Nothing
        Me.TotalOrcamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalOrcamento.FlatBorder = False
        Me.TotalOrcamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalOrcamento.FocusColor = System.Drawing.Color.Empty
        Me.TotalOrcamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalOrcamento.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalOrcamento.ForeColor = System.Drawing.Color.Navy
        Me.TotalOrcamento.HighlightBorderOnEnter = False
        Me.TotalOrcamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalOrcamento.Location = New System.Drawing.Point(109, 62)
        Me.TotalOrcamento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TotalOrcamento.Name = "TotalOrcamento"
        Me.TotalOrcamento.PreencherZeroEsqueda = False
        Me.TotalOrcamento.RegraValidação = Nothing
        Me.TotalOrcamento.RegraValidaçãoMensagem = Nothing
        Me.TotalOrcamento.Size = New System.Drawing.Size(146, 26)
        Me.TotalOrcamento.TabIndex = 9
        Me.TotalOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalOrcamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TotalOrcamento.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 92)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Cond. Pagamento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CódigoPagamento
        '
        Me.CódigoPagamento.AceitaColarTexto = True
        Me.CódigoPagamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CódigoPagamento.CasasDecimais = 0
        Me.CódigoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CódigoPagamento.CPObrigatorio = False
        Me.CódigoPagamento.CPObrigatorioMsg = Nothing
        Me.CódigoPagamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CódigoPagamento.FlatBorder = False
        Me.CódigoPagamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CódigoPagamento.FocusColor = System.Drawing.Color.Empty
        Me.CódigoPagamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.CódigoPagamento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CódigoPagamento.HighlightBorderOnEnter = False
        Me.CódigoPagamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CódigoPagamento.Location = New System.Drawing.Point(121, 90)
        Me.CódigoPagamento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CódigoPagamento.Name = "CódigoPagamento"
        Me.CódigoPagamento.PreencherZeroEsqueda = False
        Me.CódigoPagamento.RegraValidação = Nothing
        Me.CódigoPagamento.RegraValidaçãoMensagem = Nothing
        Me.CódigoPagamento.Size = New System.Drawing.Size(288, 23)
        Me.CódigoPagamento.TabIndex = 11
        Me.CódigoPagamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CódigoPagamento.ValorPadrao = Nothing
        '
        'GeradoPedido
        '
        Me.GeradoPedido.AutoSize = True
        Me.GeradoPedido.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeradoPedido.Location = New System.Drawing.Point(354, 95)
        Me.GeradoPedido.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GeradoPedido.Name = "GeradoPedido"
        Me.GeradoPedido.Size = New System.Drawing.Size(97, 19)
        Me.GeradoPedido.TabIndex = 6
        Me.GeradoPedido.Text = "GeradoPedido"
        Me.GeradoPedido.UseVisualStyleBackColor = True
        Me.GeradoPedido.Visible = False
        '
        'FuncionarioDesc
        '
        Me.FuncionarioDesc.AceitaColarTexto = True
        Me.FuncionarioDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.FuncionarioDesc.CasasDecimais = 0
        Me.FuncionarioDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FuncionarioDesc.CPObrigatorio = False
        Me.FuncionarioDesc.CPObrigatorioMsg = Nothing
        Me.FuncionarioDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FuncionarioDesc.FlatBorder = False
        Me.FuncionarioDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FuncionarioDesc.FocusColor = System.Drawing.Color.Empty
        Me.FuncionarioDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FuncionarioDesc.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncionarioDesc.HighlightBorderOnEnter = False
        Me.FuncionarioDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FuncionarioDesc.Location = New System.Drawing.Point(197, 61)
        Me.FuncionarioDesc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FuncionarioDesc.Name = "FuncionarioDesc"
        Me.FuncionarioDesc.PreencherZeroEsqueda = False
        Me.FuncionarioDesc.RegraValidação = Nothing
        Me.FuncionarioDesc.RegraValidaçãoMensagem = Nothing
        Me.FuncionarioDesc.Size = New System.Drawing.Size(212, 23)
        Me.FuncionarioDesc.TabIndex = 9
        Me.FuncionarioDesc.TabStop = False
        Me.FuncionarioDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncionarioDesc.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 59)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 23)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Vendedor"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CódigoFuncionário
        '
        Me.CódigoFuncionário.AceitaColarTexto = True
        Me.CódigoFuncionário.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CódigoFuncionário.CasasDecimais = 0
        Me.CódigoFuncionário.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CódigoFuncionário.CPObrigatorio = False
        Me.CódigoFuncionário.CPObrigatorioMsg = Nothing
        Me.CódigoFuncionário.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CódigoFuncionário.FlatBorder = False
        Me.CódigoFuncionário.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CódigoFuncionário.FocusColor = System.Drawing.Color.Empty
        Me.CódigoFuncionário.FocusColorEnd = System.Drawing.Color.Empty
        Me.CódigoFuncionário.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CódigoFuncionário.HighlightBorderOnEnter = False
        Me.CódigoFuncionário.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CódigoFuncionário.Location = New System.Drawing.Point(121, 61)
        Me.CódigoFuncionário.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CódigoFuncionário.Name = "CódigoFuncionário"
        Me.CódigoFuncionário.PreencherZeroEsqueda = False
        Me.CódigoFuncionário.RegraValidação = Nothing
        Me.CódigoFuncionário.RegraValidaçãoMensagem = Nothing
        Me.CódigoFuncionário.Size = New System.Drawing.Size(51, 23)
        Me.CódigoFuncionário.TabIndex = 8
        Me.CódigoFuncionário.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CódigoFuncionário.ValorPadrao = Nothing
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.ConfImg)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.btExportar)
        Me.PanelEx1.Controls.Add(Me.btItens)
        Me.PanelEx1.Controls.Add(Me.btImprimir)
        Me.PanelEx1.Controls.Add(Me.btLocalizar)
        Me.PanelEx1.Controls.Add(Me.btEditar)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.MyLista)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(913, 556)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'ConfImg
        '
        Me.ConfImg.BackColor = System.Drawing.Color.Transparent
        Me.ConfImg.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfImg.Image = CType(resources.GetObject("ConfImg.Image"), System.Drawing.Image)
        Me.ConfImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConfImg.Location = New System.Drawing.Point(362, 463)
        Me.ConfImg.Name = "ConfImg"
        Me.ConfImg.Size = New System.Drawing.Size(266, 51)
        Me.ConfImg.TabIndex = 33
        Me.ConfImg.Tag = "7654"
        Me.ConfImg.Text = "Orçamento Confirmado"
        Me.ConfImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ConfImg.Visible = False
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx2.Controls.Add(Me.TotalOrcamento)
        Me.PanelEx2.Controls.Add(Me.Label9)
        Me.PanelEx2.Controls.Add(Me.ValorProduto)
        Me.PanelEx2.Controls.Add(Me.Label7)
        Me.PanelEx2.Controls.Add(Me.VlrDescProduto)
        Me.PanelEx2.Controls.Add(Me.Label8)
        Me.PanelEx2.Location = New System.Drawing.Point(638, 457)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(262, 93)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 18
        '
        'btExportar
        '
        Me.btExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExportar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExportar.Location = New System.Drawing.Point(13, 487)
        Me.btExportar.Name = "btExportar"
        Me.btExportar.Size = New System.Drawing.Size(103, 27)
        Me.btExportar.TabIndex = 17
        Me.btExportar.Text = "Exportar p/ Pedido"
        '
        'btItens
        '
        Me.btItens.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btItens.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btItens.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btItens.Location = New System.Drawing.Point(13, 154)
        Me.btItens.Name = "btItens"
        Me.btItens.Size = New System.Drawing.Size(116, 21)
        Me.btItens.TabIndex = 2
        Me.btItens.Text = "Itens Orçamento"
        '
        'btImprimir
        '
        Me.btImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImprimir.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Location = New System.Drawing.Point(122, 487)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(103, 27)
        Me.btImprimir.TabIndex = 13
        Me.btImprimir.Text = "Imprimir"
        '
        'btLocalizar
        '
        Me.btLocalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLocalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLocalizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLocalizar.Location = New System.Drawing.Point(231, 486)
        Me.btLocalizar.Name = "btLocalizar"
        Me.btLocalizar.Size = New System.Drawing.Size(103, 27)
        Me.btLocalizar.TabIndex = 12
        Me.btLocalizar.Text = "Localizar"
        '
        'btEditar
        '
        Me.btEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEditar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.Location = New System.Drawing.Point(12, 520)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(103, 27)
        Me.btEditar.TabIndex = 11
        Me.btEditar.Text = "Editar Orçamento"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.Location = New System.Drawing.Point(231, 520)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(103, 27)
        Me.btNovo.TabIndex = 15
        Me.btNovo.Text = "Novo Orçamento"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.Location = New System.Drawing.Point(122, 520)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(103, 27)
        Me.btSalvar.TabIndex = 10
        Me.btSalvar.Text = "Salvar Orçamento"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(340, 520)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(103, 27)
        Me.btFechar.TabIndex = 16
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.PedidoGerado)
        Me.GroupPanel2.Controls.Add(Me.PedidoGeradoLabel)
        Me.GroupPanel2.Controls.Add(Me.btFindVendedor)
        Me.GroupPanel2.Controls.Add(Me.CodOrçamento)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.Controls.Add(Me.FuncionarioDesc)
        Me.GroupPanel2.Controls.Add(Me.Label12)
        Me.GroupPanel2.Controls.Add(Me.DataOrçamento)
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.Controls.Add(Me.CódigoFuncionário)
        Me.GroupPanel2.Controls.Add(Me.Validade)
        Me.GroupPanel2.Controls.Add(Me.Label6)
        Me.GroupPanel2.Controls.Add(Me.Label10)
        Me.GroupPanel2.Controls.Add(Me.CódigoPagamento)
        Me.GroupPanel2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 5)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(420, 144)
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
        Me.GroupPanel2.TabIndex = 0
        Me.GroupPanel2.Text = "Orçamento/Validade"
        '
        'PedidoGerado
        '
        Me.PedidoGerado.AceitaColarTexto = False
        Me.PedidoGerado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PedidoGerado.CasasDecimais = 0
        Me.PedidoGerado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PedidoGerado.CPObrigatorio = False
        Me.PedidoGerado.CPObrigatorioMsg = Nothing
        Me.PedidoGerado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PedidoGerado.FlatBorder = False
        Me.PedidoGerado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.PedidoGerado.FocusColor = System.Drawing.Color.Empty
        Me.PedidoGerado.FocusColorEnd = System.Drawing.Color.Empty
        Me.PedidoGerado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PedidoGerado.HighlightBorderOnEnter = False
        Me.PedidoGerado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.PedidoGerado.Location = New System.Drawing.Point(315, 29)
        Me.PedidoGerado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PedidoGerado.MaxLength = 15
        Me.PedidoGerado.Name = "PedidoGerado"
        Me.PedidoGerado.PreencherZeroEsqueda = False
        Me.PedidoGerado.RegraValidação = Nothing
        Me.PedidoGerado.RegraValidaçãoMensagem = Nothing
        Me.PedidoGerado.Size = New System.Drawing.Size(94, 23)
        Me.PedidoGerado.TabIndex = 50
        Me.PedidoGerado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PedidoGerado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.PedidoGerado.ValorPadrao = Nothing
        Me.PedidoGerado.Visible = False
        '
        'PedidoGeradoLabel
        '
        Me.PedidoGeradoLabel.BackColor = System.Drawing.Color.Transparent
        Me.PedidoGeradoLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PedidoGeradoLabel.Location = New System.Drawing.Point(218, 29)
        Me.PedidoGeradoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PedidoGeradoLabel.Name = "PedidoGeradoLabel"
        Me.PedidoGeradoLabel.Size = New System.Drawing.Size(89, 23)
        Me.PedidoGeradoLabel.TabIndex = 49
        Me.PedidoGeradoLabel.Text = "Pedido Gerado"
        Me.PedidoGeradoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PedidoGeradoLabel.Visible = False
        '
        'btFindVendedor
        '
        Me.btFindVendedor.BackColor = System.Drawing.Color.Transparent
        Me.btFindVendedor.Image = CType(resources.GetObject("btFindVendedor.Image"), System.Drawing.Image)
        Me.btFindVendedor.Location = New System.Drawing.Point(172, 61)
        Me.btFindVendedor.Name = "btFindVendedor"
        Me.btFindVendedor.Size = New System.Drawing.Size(21, 23)
        Me.btFindVendedor.TabIndex = 48
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btEditarCliente)
        Me.GroupPanel1.Controls.Add(Me.btClienteFind)
        Me.GroupPanel1.Controls.Add(Me.CódigoCliente)
        Me.GroupPanel1.Controls.Add(Me.NomeCliente)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.CpfCnpj)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.RgInscrição)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.GeradoPedido)
        Me.GroupPanel1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpNavigator(Me.GroupPanel1, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.GroupPanel1.Location = New System.Drawing.Point(439, 5)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.HelpProvider1.SetShowHelp(Me.GroupPanel1, True)
        Me.GroupPanel1.Size = New System.Drawing.Size(461, 144)
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
        Me.GroupPanel1.TabIndex = 1
        Me.GroupPanel1.Text = "Dados do Cliente"
        '
        'btEditarCliente
        '
        Me.btEditarCliente.BackColor = System.Drawing.Color.Transparent
        Me.btEditarCliente.Image = CType(resources.GetObject("btEditarCliente.Image"), System.Drawing.Image)
        Me.btEditarCliente.Location = New System.Drawing.Point(216, 0)
        Me.btEditarCliente.Name = "btEditarCliente"
        Me.btEditarCliente.Size = New System.Drawing.Size(23, 23)
        Me.btEditarCliente.TabIndex = 48
        '
        'btClienteFind
        '
        Me.btClienteFind.BackColor = System.Drawing.Color.Transparent
        Me.btClienteFind.Image = CType(resources.GetObject("btClienteFind.Image"), System.Drawing.Image)
        Me.btClienteFind.Location = New System.Drawing.Point(187, -1)
        Me.btClienteFind.Name = "btClienteFind"
        Me.btClienteFind.Size = New System.Drawing.Size(23, 23)
        Me.btClienteFind.TabIndex = 47
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Orçamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(913, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Orçamento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orçamentos - T160"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CodOrçamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CódigoCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NomeCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CpfCnpj As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RgInscrição As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataOrçamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Validade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ValorProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VlrDescProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TotalOrcamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CódigoPagamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GeradoPedido As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents FuncionarioDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CódigoFuncionário As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btLocalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btItens As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFindVendedor As System.Windows.Forms.Label
    Friend WithEvents btClienteFind As System.Windows.Forms.Label
    Friend WithEvents btEditarCliente As System.Windows.Forms.Label
    Friend WithEvents btExportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PedidoGerado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PedidoGeradoLabel As System.Windows.Forms.Label
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ConfImg As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
