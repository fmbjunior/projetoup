<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagarLancamentos
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
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelNotaFiscal = New System.Windows.Forms.Label()
        Me.NotaFiscal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CodFornecedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataDocumento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fornecedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Vencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDoc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colfor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColVenc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuLista = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirParcelaSelecionadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirTodasAsParcelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Novo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Parcelar = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Parcela = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Destino = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Salvar = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.LocalPgto = New CBOAutoCompleteFocus.CboFocus()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Parcelado = New System.Windows.Forms.Label()
        Me.vValorDoc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuLista.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Id.Location = New System.Drawing.Point(230, 15)
        Me.Id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(44, 23)
        Me.Id.TabIndex = 2
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Documento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Documento
        '
        Me.Documento.AceitaColarTexto = True
        Me.Documento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Documento.CasasDecimais = 0
        Me.Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Documento.CPObrigatorio = False
        Me.Documento.CPObrigatorioMsg = Nothing
        Me.Documento.Enabled = False
        Me.Documento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Documento.FlatBorder = False
        Me.Documento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Documento.FocusColor = System.Drawing.Color.Empty
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Documento.HighlightBorderOnEnter = False
        Me.Documento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Documento.Location = New System.Drawing.Point(119, 16)
        Me.Documento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(105, 23)
        Me.Documento.TabIndex = 1
        Me.Documento.TabStop = False
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'LabelNotaFiscal
        '
        Me.LabelNotaFiscal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNotaFiscal.Location = New System.Drawing.Point(8, 15)
        Me.LabelNotaFiscal.Name = "LabelNotaFiscal"
        Me.LabelNotaFiscal.Size = New System.Drawing.Size(105, 23)
        Me.LabelNotaFiscal.TabIndex = 0
        Me.LabelNotaFiscal.Text = "Nota Fiscal"
        Me.LabelNotaFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NotaFiscal
        '
        Me.NotaFiscal.AceitaColarTexto = True
        Me.NotaFiscal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NotaFiscal.CasasDecimais = 0
        Me.NotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NotaFiscal.CPObrigatorio = False
        Me.NotaFiscal.CPObrigatorioMsg = Nothing
        Me.NotaFiscal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NotaFiscal.FlatBorder = False
        Me.NotaFiscal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.FocusColor = System.Drawing.Color.Empty
        Me.NotaFiscal.FocusColorEnd = System.Drawing.Color.Empty
        Me.NotaFiscal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaFiscal.HighlightBorderOnEnter = False
        Me.NotaFiscal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.Location = New System.Drawing.Point(119, 15)
        Me.NotaFiscal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.PreencherZeroEsqueda = False
        Me.NotaFiscal.RegraValidação = Nothing
        Me.NotaFiscal.RegraValidaçãoMensagem = Nothing
        Me.NotaFiscal.Size = New System.Drawing.Size(105, 23)
        Me.NotaFiscal.TabIndex = 1
        Me.NotaFiscal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NotaFiscal.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fornecedor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodFornecedor
        '
        Me.CodFornecedor.AceitaColarTexto = True
        Me.CodFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodFornecedor.CasasDecimais = 0
        Me.CodFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodFornecedor.CPObrigatorio = False
        Me.CodFornecedor.CPObrigatorioMsg = Nothing
        Me.CodFornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodFornecedor.FlatBorder = False
        Me.CodFornecedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodFornecedor.FocusColor = System.Drawing.Color.Empty
        Me.CodFornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodFornecedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodFornecedor.HighlightBorderOnEnter = False
        Me.CodFornecedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodFornecedor.Location = New System.Drawing.Point(119, 46)
        Me.CodFornecedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodFornecedor.Name = "CodFornecedor"
        Me.CodFornecedor.PreencherZeroEsqueda = False
        Me.CodFornecedor.RegraValidação = Nothing
        Me.CodFornecedor.RegraValidaçãoMensagem = Nothing
        Me.CodFornecedor.Size = New System.Drawing.Size(105, 23)
        Me.CodFornecedor.TabIndex = 4
        Me.CodFornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodFornecedor.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data Doc"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataDocumento
        '
        Me.DataDocumento.AceitaColarTexto = True
        Me.DataDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataDocumento.CasasDecimais = 0
        Me.DataDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataDocumento.CPObrigatorio = False
        Me.DataDocumento.CPObrigatorioMsg = Nothing
        Me.DataDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataDocumento.FlatBorder = False
        Me.DataDocumento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataDocumento.FocusColor = System.Drawing.Color.Empty
        Me.DataDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataDocumento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDocumento.HighlightBorderOnEnter = False
        Me.DataDocumento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataDocumento.Location = New System.Drawing.Point(119, 47)
        Me.DataDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataDocumento.MaxLength = 10
        Me.DataDocumento.Name = "DataDocumento"
        Me.DataDocumento.PreencherZeroEsqueda = False
        Me.DataDocumento.RegraValidação = Nothing
        Me.DataDocumento.RegraValidaçãoMensagem = Nothing
        Me.DataDocumento.Size = New System.Drawing.Size(105, 23)
        Me.DataDocumento.TabIndex = 5
        Me.DataDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataDocumento.ValorPadrao = Nothing
        '
        'Fornecedor
        '
        Me.Fornecedor.AceitaColarTexto = True
        Me.Fornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Fornecedor.CasasDecimais = 0
        Me.Fornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fornecedor.CPObrigatorio = False
        Me.Fornecedor.CPObrigatorioMsg = Nothing
        Me.Fornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Fornecedor.FlatBorder = False
        Me.Fornecedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Fornecedor.FocusColor = System.Drawing.Color.Empty
        Me.Fornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.Fornecedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fornecedor.HighlightBorderOnEnter = False
        Me.Fornecedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Fornecedor.Location = New System.Drawing.Point(230, 46)
        Me.Fornecedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.PreencherZeroEsqueda = False
        Me.Fornecedor.RegraValidação = Nothing
        Me.Fornecedor.RegraValidaçãoMensagem = Nothing
        Me.Fornecedor.Size = New System.Drawing.Size(285, 23)
        Me.Fornecedor.TabIndex = 5
        Me.Fornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Fornecedor.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(286, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "1º  Vencimento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vencimento
        '
        Me.Vencimento.AceitaColarTexto = True
        Me.Vencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vencimento.CasasDecimais = 0
        Me.Vencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vencimento.CPObrigatorio = False
        Me.Vencimento.CPObrigatorioMsg = Nothing
        Me.Vencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vencimento.FlatBorder = False
        Me.Vencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vencimento.FocusColor = System.Drawing.Color.Empty
        Me.Vencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vencimento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vencimento.HighlightBorderOnEnter = False
        Me.Vencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vencimento.Location = New System.Drawing.Point(391, 48)
        Me.Vencimento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Vencimento.MaxLength = 10
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PreencherZeroEsqueda = False
        Me.Vencimento.RegraValidação = Nothing
        Me.Vencimento.RegraValidaçãoMensagem = Nothing
        Me.Vencimento.Size = New System.Drawing.Size(122, 23)
        Me.Vencimento.TabIndex = 7
        Me.Vencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Vencimento.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 22)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Local Pgto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MyLista
        '
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColNf, Me.ColDoc, Me.Colfor, Me.ColVenc, Me.ColValor})
        Me.MyLista.ContextMenuStrip = Me.MenuLista
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(12, 278)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(516, 158)
        Me.MyLista.TabIndex = 2
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "ColId"
        Me.ColId.Width = 0
        '
        'ColNf
        '
        Me.ColNf.Text = "Nota Fiscal"
        Me.ColNf.Width = 70
        '
        'ColDoc
        '
        Me.ColDoc.Text = "Doc"
        '
        'Colfor
        '
        Me.Colfor.Text = "Fornecedor"
        Me.Colfor.Width = 200
        '
        'ColVenc
        '
        Me.ColVenc.Text = "Vencimento"
        Me.ColVenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColVenc.Width = 80
        '
        'ColValor
        '
        Me.ColValor.Text = "Valor"
        Me.ColValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColValor.Width = 80
        '
        'MenuLista
        '
        Me.MenuLista.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.MenuLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirParcelaSelecionadaToolStripMenuItem, Me.ExcluirTodasAsParcelasToolStripMenuItem})
        Me.MenuLista.Name = "MenuLista"
        Me.MenuLista.Size = New System.Drawing.Size(230, 48)
        '
        'ExcluirParcelaSelecionadaToolStripMenuItem
        '
        Me.ExcluirParcelaSelecionadaToolStripMenuItem.Name = "ExcluirParcelaSelecionadaToolStripMenuItem"
        Me.ExcluirParcelaSelecionadaToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ExcluirParcelaSelecionadaToolStripMenuItem.Text = "Excluir Parcela Selecionada"
        '
        'ExcluirTodasAsParcelasToolStripMenuItem
        '
        Me.ExcluirTodasAsParcelasToolStripMenuItem.Name = "ExcluirTodasAsParcelasToolStripMenuItem"
        Me.ExcluirTodasAsParcelasToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ExcluirTodasAsParcelasToolStripMenuItem.Text = "Excluir Todas as Parcelas"
        '
        'Novo
        '
        Me.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Novo.Location = New System.Drawing.Point(434, 12)
        Me.Novo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(61, 25)
        Me.Novo.TabIndex = 0
        Me.Novo.Text = "Novo"
        Me.Novo.UseVisualStyleBackColor = True
        Me.Novo.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(301, 439)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total Parcelar"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Parcelar
        '
        Me.Parcelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Parcelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Parcelar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parcelar.Location = New System.Drawing.Point(403, 439)
        Me.Parcelar.Name = "Parcelar"
        Me.Parcelar.Size = New System.Drawing.Size(121, 19)
        Me.Parcelar.TabIndex = 5
        Me.Parcelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(289, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Parcela"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Parcela
        '
        Me.Parcela.AceitaColarTexto = False
        Me.Parcela.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Parcela.CasasDecimais = 0
        Me.Parcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Parcela.CPObrigatorio = True
        Me.Parcela.CPObrigatorioMsg = Nothing
        Me.Parcela.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Parcela.FlatBorder = False
        Me.Parcela.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Parcela.FocusColor = System.Drawing.Color.Empty
        Me.Parcela.FocusColorEnd = System.Drawing.Color.Empty
        Me.Parcela.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parcela.HighlightBorderOnEnter = False
        Me.Parcela.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Parcela.Location = New System.Drawing.Point(391, 17)
        Me.Parcela.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Parcela.MaxLength = 15
        Me.Parcela.Name = "Parcela"
        Me.Parcela.PreencherZeroEsqueda = False
        Me.Parcela.RegraValidação = Nothing
        Me.Parcela.RegraValidaçãoMensagem = Nothing
        Me.Parcela.Size = New System.Drawing.Size(34, 23)
        Me.Parcela.TabIndex = 3
        Me.Parcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Parcela.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.Parcela.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 19)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Destino"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Destino
        '
        Me.Destino.AceitaColarTexto = True
        Me.Destino.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Destino.CasasDecimais = 0
        Me.Destino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Destino.CPObrigatorio = False
        Me.Destino.CPObrigatorioMsg = Nothing
        Me.Destino.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Destino.FlatBorder = False
        Me.Destino.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Destino.FocusColor = System.Drawing.Color.Empty
        Me.Destino.FocusColorEnd = System.Drawing.Color.Empty
        Me.Destino.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destino.HighlightBorderOnEnter = False
        Me.Destino.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Destino.Location = New System.Drawing.Point(119, 109)
        Me.Destino.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Destino.MaxLength = 150
        Me.Destino.Name = "Destino"
        Me.Destino.PreencherZeroEsqueda = False
        Me.Destino.RegraValidação = Nothing
        Me.Destino.RegraValidaçãoMensagem = Nothing
        Me.Destino.Size = New System.Drawing.Size(394, 23)
        Me.Destino.TabIndex = 11
        Me.Destino.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Destino.ValorPadrao = Nothing
        '
        'Salvar
        '
        Me.Salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Salvar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salvar.Location = New System.Drawing.Point(312, 139)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(105, 24)
        Me.Salvar.TabIndex = 12
        Me.Salvar.Text = "Gerar Parcelas"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Location = New System.Drawing.Point(423, 139)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(90, 24)
        Me.Fechar.TabIndex = 13
        Me.Fechar.TabStop = False
        Me.Fechar.Text = "Fechar"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.PanelEx2)
        Me.Fundo.Controls.Add(Me.PanelEx1)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Parcelado)
        Me.Fundo.Controls.Add(Me.vValorDoc)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.Parcelar)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(539, 486)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.LocalPgto)
        Me.PanelEx2.Controls.Add(Me.Documento)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Controls.Add(Me.Parcela)
        Me.PanelEx2.Controls.Add(Me.Label8)
        Me.PanelEx2.Controls.Add(Me.DataDocumento)
        Me.PanelEx2.Controls.Add(Me.Fechar)
        Me.PanelEx2.Controls.Add(Me.Label4)
        Me.PanelEx2.Controls.Add(Me.Salvar)
        Me.PanelEx2.Controls.Add(Me.Label11)
        Me.PanelEx2.Controls.Add(Me.Label12)
        Me.PanelEx2.Controls.Add(Me.Vencimento)
        Me.PanelEx2.Controls.Add(Me.Destino)
        Me.PanelEx2.Controls.Add(Me.Label5)
        Me.PanelEx2.Location = New System.Drawing.Point(12, 99)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(516, 173)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'LocalPgto
        '
        Me.LocalPgto.Auto_Complete = True
        Me.LocalPgto.AutoLimitar_Lista = True
        Me.LocalPgto.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.LocalPgto.CPObrigatorio = False
        Me.LocalPgto.CPObrigatorioMsg = Nothing
        Me.LocalPgto.FlatBorder = False
        Me.LocalPgto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.LocalPgto.FormattingEnabled = True
        Me.LocalPgto.HighlightBorderColor = System.Drawing.Color.Empty
        Me.LocalPgto.HighlightBorderOnEnter = False
        Me.LocalPgto.Items.AddRange(New Object() {"BANCO", "CARTEIRA"})
        Me.LocalPgto.Location = New System.Drawing.Point(119, 78)
        Me.LocalPgto.Name = "LocalPgto"
        Me.LocalPgto.Size = New System.Drawing.Size(393, 23)
        Me.LocalPgto.TabIndex = 9
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.NotaFiscal)
        Me.PanelEx1.Controls.Add(Me.LabelNotaFiscal)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.CodFornecedor)
        Me.PanelEx1.Controls.Add(Me.Fornecedor)
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.Novo)
        Me.PanelEx1.Location = New System.Drawing.Point(10, 12)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(518, 81)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Parcelado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Parcelado
        '
        Me.Parcelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Parcelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Parcelado.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parcelado.Location = New System.Drawing.Point(403, 462)
        Me.Parcelado.Name = "Parcelado"
        Me.Parcelado.Size = New System.Drawing.Size(121, 19)
        Me.Parcelado.TabIndex = 7
        Me.Parcelado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vValorDoc
        '
        Me.vValorDoc.AceitaColarTexto = True
        Me.vValorDoc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.vValorDoc.CasasDecimais = 0
        Me.vValorDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vValorDoc.CPObrigatorio = False
        Me.vValorDoc.CPObrigatorioMsg = Nothing
        Me.vValorDoc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.vValorDoc.FlatBorder = False
        Me.vValorDoc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.vValorDoc.FocusColor = System.Drawing.Color.Empty
        Me.vValorDoc.FocusColorEnd = System.Drawing.Color.Empty
        Me.vValorDoc.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vValorDoc.HighlightBorderOnEnter = False
        Me.vValorDoc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.vValorDoc.Location = New System.Drawing.Point(189, 436)
        Me.vValorDoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.vValorDoc.MaxLength = 10
        Me.vValorDoc.Name = "vValorDoc"
        Me.vValorDoc.PreencherZeroEsqueda = False
        Me.vValorDoc.RegraValidação = Nothing
        Me.vValorDoc.RegraValidaçãoMensagem = Nothing
        Me.vValorDoc.Size = New System.Drawing.Size(106, 23)
        Me.vValorDoc.TabIndex = 3
        Me.vValorDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vValorDoc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.vValorDoc.ValorPadrao = Nothing
        Me.vValorDoc.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 463)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Para editar de dois clicks nas parcelas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(258, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Para excluir de um click com botão direito mouse"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PagarLancamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(539, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PagarLancamentos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançamentos de Contas a Pagar - T167"
        Me.MenuLista.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents NotaFiscal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CodFornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Vencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Novo As System.Windows.Forms.Button
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColNf As System.Windows.Forms.ColumnHeader
    Friend WithEvents Colfor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColVenc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Parcelar As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Parcela As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Destino As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Salvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents MenuLista As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirParcelaSelecionadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirTodasAsParcelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vValorDoc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Parcelado As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Public WithEvents LocalPgto As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
