<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OSChequePreLancar
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Cheque = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CC = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Titular = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EntreguePor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ValorCh = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Vencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColCheque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColVencimento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItensLista = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditaItenDaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirItemDaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecalculaValoresDaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarNovoItemNaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VlrLançado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VlrLançar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Ped = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IDRECEBER = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IdCodigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BancoCheque = New CBOAutoCompleteFocus.CboFocus()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ItensLista.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(9, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cheque"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cheque
        '
        Me.Cheque.AceitaColarTexto = True
        Me.Cheque.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cheque.CasasDecimais = 0
        Me.Cheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cheque.CPObrigatorio = False
        Me.Cheque.CPObrigatorioMsg = Nothing
        Me.Cheque.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cheque.FlatBorder = False
        Me.Cheque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cheque.FocusColor = System.Drawing.Color.Empty
        Me.Cheque.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cheque.HighlightBorderOnEnter = False
        Me.Cheque.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cheque.Location = New System.Drawing.Point(117, 12)
        Me.Cheque.MaxLength = 15
        Me.Cheque.Name = "Cheque"
        Me.Cheque.PreencherZeroEsqueda = False
        Me.Cheque.RegraValidação = Nothing
        Me.Cheque.RegraValidaçãoMensagem = Nothing
        Me.Cheque.Size = New System.Drawing.Size(116, 23)
        Me.Cheque.TabIndex = 1
        Me.Cheque.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cheque.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(339, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "C/C"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CC
        '
        Me.CC.AceitaColarTexto = True
        Me.CC.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CC.CasasDecimais = 0
        Me.CC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CC.CPObrigatorio = False
        Me.CC.CPObrigatorioMsg = Nothing
        Me.CC.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CC.FlatBorder = False
        Me.CC.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CC.FocusColor = System.Drawing.Color.Empty
        Me.CC.FocusColorEnd = System.Drawing.Color.Empty
        Me.CC.HighlightBorderOnEnter = False
        Me.CC.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CC.Location = New System.Drawing.Point(447, 11)
        Me.CC.MaxLength = 15
        Me.CC.Name = "CC"
        Me.CC.PreencherZeroEsqueda = False
        Me.CC.RegraValidação = Nothing
        Me.CC.RegraValidaçãoMensagem = Nothing
        Me.CC.Size = New System.Drawing.Size(116, 23)
        Me.CC.TabIndex = 3
        Me.CC.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CC.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Banco Cheque"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Titular"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Titular
        '
        Me.Titular.AceitaColarTexto = True
        Me.Titular.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Titular.CasasDecimais = 0
        Me.Titular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Titular.CPObrigatorio = False
        Me.Titular.CPObrigatorioMsg = Nothing
        Me.Titular.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Titular.FlatBorder = False
        Me.Titular.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Titular.FocusColor = System.Drawing.Color.Empty
        Me.Titular.FocusColorEnd = System.Drawing.Color.Empty
        Me.Titular.HighlightBorderOnEnter = False
        Me.Titular.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Titular.Location = New System.Drawing.Point(117, 70)
        Me.Titular.MaxLength = 50
        Me.Titular.Name = "Titular"
        Me.Titular.PreencherZeroEsqueda = False
        Me.Titular.RegraValidação = Nothing
        Me.Titular.RegraValidaçãoMensagem = Nothing
        Me.Titular.Size = New System.Drawing.Size(446, 23)
        Me.Titular.TabIndex = 7
        Me.Titular.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Titular.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Entregue Por"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EntreguePor
        '
        Me.EntreguePor.AceitaColarTexto = True
        Me.EntreguePor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntreguePor.CasasDecimais = 0
        Me.EntreguePor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntreguePor.CPObrigatorio = False
        Me.EntreguePor.CPObrigatorioMsg = Nothing
        Me.EntreguePor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntreguePor.FlatBorder = False
        Me.EntreguePor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EntreguePor.FocusColor = System.Drawing.Color.Empty
        Me.EntreguePor.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntreguePor.HighlightBorderOnEnter = False
        Me.EntreguePor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EntreguePor.Location = New System.Drawing.Point(117, 99)
        Me.EntreguePor.MaxLength = 50
        Me.EntreguePor.Name = "EntreguePor"
        Me.EntreguePor.PreencherZeroEsqueda = False
        Me.EntreguePor.RegraValidação = Nothing
        Me.EntreguePor.RegraValidaçãoMensagem = Nothing
        Me.EntreguePor.Size = New System.Drawing.Size(446, 23)
        Me.EntreguePor.TabIndex = 9
        Me.EntreguePor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntreguePor.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(9, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vlr. Cheque"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorCh
        '
        Me.ValorCh.AceitaColarTexto = True
        Me.ValorCh.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorCh.CasasDecimais = 3
        Me.ValorCh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorCh.CPObrigatorio = False
        Me.ValorCh.CPObrigatorioMsg = Nothing
        Me.ValorCh.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorCh.FlatBorder = False
        Me.ValorCh.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorCh.FocusColor = System.Drawing.Color.Empty
        Me.ValorCh.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorCh.HighlightBorderOnEnter = False
        Me.ValorCh.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorCh.Location = New System.Drawing.Point(117, 128)
        Me.ValorCh.MaxLength = 10
        Me.ValorCh.Name = "ValorCh"
        Me.ValorCh.PreencherZeroEsqueda = False
        Me.ValorCh.RegraValidação = Nothing
        Me.ValorCh.RegraValidaçãoMensagem = Nothing
        Me.ValorCh.Size = New System.Drawing.Size(116, 23)
        Me.ValorCh.TabIndex = 11
        Me.ValorCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorCh.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorCh.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(336, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Vencimento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Vencimento.HighlightBorderOnEnter = False
        Me.Vencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vencimento.Location = New System.Drawing.Point(447, 128)
        Me.Vencimento.MaxLength = 10
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PreencherZeroEsqueda = False
        Me.Vencimento.RegraValidação = Nothing
        Me.Vencimento.RegraValidaçãoMensagem = Nothing
        Me.Vencimento.Size = New System.Drawing.Size(116, 23)
        Me.Vencimento.TabIndex = 13
        Me.Vencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Vencimento.ValorPadrao = Nothing
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColCheque, Me.ColCC, Me.ColVencimento, Me.ColValor, Me.ColumnHeader1})
        Me.MyLista.ContextMenuStrip = Me.ItensLista
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(12, 171)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(640, 147)
        Me.MyLista.TabIndex = 16
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColCheque
        '
        Me.ColCheque.Text = "Cheque"
        Me.ColCheque.Width = 100
        '
        'ColCC
        '
        Me.ColCC.Text = "C/C"
        Me.ColCC.Width = 100
        '
        'ColVencimento
        '
        Me.ColVencimento.Text = "Vencimento"
        Me.ColVencimento.Width = 100
        '
        'ColValor
        '
        Me.ColValor.Text = "Valor"
        Me.ColValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColValor.Width = 110
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Banco"
        Me.ColumnHeader1.Width = 210
        '
        'ItensLista
        '
        Me.ItensLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditaItenDaListaToolStripMenuItem, Me.ExcluirItemDaListaToolStripMenuItem, Me.RecalculaValoresDaListaToolStripMenuItem, Me.AdicionarNovoItemNaListaToolStripMenuItem})
        Me.ItensLista.Name = "ItensLista"
        Me.ItensLista.Size = New System.Drawing.Size(228, 92)
        '
        'EditaItenDaListaToolStripMenuItem
        '
        Me.EditaItenDaListaToolStripMenuItem.Name = "EditaItenDaListaToolStripMenuItem"
        Me.EditaItenDaListaToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.EditaItenDaListaToolStripMenuItem.Text = "Edita Item da Lista"
        '
        'ExcluirItemDaListaToolStripMenuItem
        '
        Me.ExcluirItemDaListaToolStripMenuItem.Name = "ExcluirItemDaListaToolStripMenuItem"
        Me.ExcluirItemDaListaToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ExcluirItemDaListaToolStripMenuItem.Text = "Excluir Item da Lista"
        '
        'RecalculaValoresDaListaToolStripMenuItem
        '
        Me.RecalculaValoresDaListaToolStripMenuItem.Name = "RecalculaValoresDaListaToolStripMenuItem"
        Me.RecalculaValoresDaListaToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.RecalculaValoresDaListaToolStripMenuItem.Text = "Recalcula Valores da Lista"
        '
        'AdicionarNovoItemNaListaToolStripMenuItem
        '
        Me.AdicionarNovoItemNaListaToolStripMenuItem.Name = "AdicionarNovoItemNaListaToolStripMenuItem"
        Me.AdicionarNovoItemNaListaToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AdicionarNovoItemNaListaToolStripMenuItem.Text = "Adicionar Novo Item na Lista"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(511, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Valor Lançado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VlrLançado
        '
        Me.VlrLançado.AceitaColarTexto = True
        Me.VlrLançado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.VlrLançado.CasasDecimais = 2
        Me.VlrLançado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VlrLançado.CPObrigatorio = False
        Me.VlrLançado.CPObrigatorioMsg = Nothing
        Me.VlrLançado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VlrLançado.FlatBorder = False
        Me.VlrLançado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.VlrLançado.FocusColor = System.Drawing.Color.Empty
        Me.VlrLançado.FocusColorEnd = System.Drawing.Color.Empty
        Me.VlrLançado.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VlrLançado.ForeColor = System.Drawing.Color.Navy
        Me.VlrLançado.HighlightBorderOnEnter = False
        Me.VlrLançado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.VlrLançado.Location = New System.Drawing.Point(511, 343)
        Me.VlrLançado.MaxLength = 10
        Me.VlrLançado.Name = "VlrLançado"
        Me.VlrLançado.PreencherZeroEsqueda = False
        Me.VlrLançado.RegraValidação = Nothing
        Me.VlrLançado.RegraValidaçãoMensagem = Nothing
        Me.VlrLançado.Size = New System.Drawing.Size(140, 23)
        Me.VlrLançado.TabIndex = 22
        Me.VlrLançado.TabStop = False
        Me.VlrLançado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrLançado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.VlrLançado.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(339, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Valor a Lançar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VlrLançar
        '
        Me.VlrLançar.AceitaColarTexto = True
        Me.VlrLançar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.VlrLançar.CasasDecimais = 2
        Me.VlrLançar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VlrLançar.CPObrigatorio = False
        Me.VlrLançar.CPObrigatorioMsg = Nothing
        Me.VlrLançar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VlrLançar.FlatBorder = False
        Me.VlrLançar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.VlrLançar.FocusColor = System.Drawing.Color.Empty
        Me.VlrLançar.FocusColorEnd = System.Drawing.Color.Empty
        Me.VlrLançar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VlrLançar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VlrLançar.HighlightBorderOnEnter = False
        Me.VlrLançar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.VlrLançar.Location = New System.Drawing.Point(339, 343)
        Me.VlrLançar.MaxLength = 10
        Me.VlrLançar.Name = "VlrLançar"
        Me.VlrLançar.PreencherZeroEsqueda = False
        Me.VlrLançar.RegraValidação = Nothing
        Me.VlrLançar.RegraValidaçãoMensagem = Nothing
        Me.VlrLançar.Size = New System.Drawing.Size(140, 23)
        Me.VlrLançar.TabIndex = 21
        Me.VlrLançar.TabStop = False
        Me.VlrLançar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrLançar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.VlrLançar.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(178, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Pedido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ped
        '
        Me.Ped.AceitaColarTexto = False
        Me.Ped.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Ped.CasasDecimais = 0
        Me.Ped.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ped.CPObrigatorio = False
        Me.Ped.CPObrigatorioMsg = Nothing
        Me.Ped.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ped.FlatBorder = False
        Me.Ped.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Ped.FocusColor = System.Drawing.Color.Empty
        Me.Ped.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ped.HighlightBorderOnEnter = False
        Me.Ped.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Ped.Location = New System.Drawing.Point(178, 343)
        Me.Ped.MaxLength = 10
        Me.Ped.Name = "Ped"
        Me.Ped.PreencherZeroEsqueda = False
        Me.Ped.RegraValidação = Nothing
        Me.Ped.RegraValidaçãoMensagem = Nothing
        Me.Ped.Size = New System.Drawing.Size(140, 23)
        Me.Ped.TabIndex = 20
        Me.Ped.TabStop = False
        Me.Ped.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ped.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ped.ValorPadrao = Nothing
        '
        'Documento
        '
        Me.Documento.AceitaColarTexto = True
        Me.Documento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
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
        Me.Documento.Location = New System.Drawing.Point(12, 322)
        Me.Documento.MaxLength = 15
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(65, 23)
        Me.Documento.TabIndex = 23
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        Me.Documento.Visible = False
        '
        'IDRECEBER
        '
        Me.IDRECEBER.AceitaColarTexto = True
        Me.IDRECEBER.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IDRECEBER.CasasDecimais = 0
        Me.IDRECEBER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDRECEBER.CPObrigatorio = False
        Me.IDRECEBER.CPObrigatorioMsg = Nothing
        Me.IDRECEBER.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IDRECEBER.FlatBorder = False
        Me.IDRECEBER.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IDRECEBER.FocusColor = System.Drawing.Color.Empty
        Me.IDRECEBER.FocusColorEnd = System.Drawing.Color.Empty
        Me.IDRECEBER.HighlightBorderOnEnter = False
        Me.IDRECEBER.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IDRECEBER.Location = New System.Drawing.Point(83, 322)
        Me.IDRECEBER.MaxLength = 15
        Me.IDRECEBER.Name = "IDRECEBER"
        Me.IDRECEBER.PreencherZeroEsqueda = False
        Me.IDRECEBER.RegraValidação = Nothing
        Me.IDRECEBER.RegraValidaçãoMensagem = Nothing
        Me.IDRECEBER.Size = New System.Drawing.Size(51, 23)
        Me.IDRECEBER.TabIndex = 24
        Me.IDRECEBER.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IDRECEBER.ValorPadrao = Nothing
        Me.IDRECEBER.Visible = False
        '
        'IdCodigo
        '
        Me.IdCodigo.AceitaColarTexto = True
        Me.IdCodigo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IdCodigo.CasasDecimais = 0
        Me.IdCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdCodigo.CPObrigatorio = False
        Me.IdCodigo.CPObrigatorioMsg = Nothing
        Me.IdCodigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdCodigo.FlatBorder = False
        Me.IdCodigo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdCodigo.FocusColor = System.Drawing.Color.Empty
        Me.IdCodigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdCodigo.HighlightBorderOnEnter = False
        Me.IdCodigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdCodigo.Location = New System.Drawing.Point(12, 349)
        Me.IdCodigo.MaxLength = 15
        Me.IdCodigo.Name = "IdCodigo"
        Me.IdCodigo.PreencherZeroEsqueda = False
        Me.IdCodigo.RegraValidação = Nothing
        Me.IdCodigo.RegraValidaçãoMensagem = Nothing
        Me.IdCodigo.Size = New System.Drawing.Size(65, 23)
        Me.IdCodigo.TabIndex = 25
        Me.IdCodigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdCodigo.ValorPadrao = Nothing
        Me.IdCodigo.Visible = False
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.BancoCheque)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.Cheque)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.CC)
        Me.PanelEx1.Controls.Add(Me.Titular)
        Me.PanelEx1.Controls.Add(Me.Documento)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.IDRECEBER)
        Me.PanelEx1.Controls.Add(Me.EntreguePor)
        Me.PanelEx1.Controls.Add(Me.IdCodigo)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.ValorCh)
        Me.PanelEx1.Controls.Add(Me.Ped)
        Me.PanelEx1.Controls.Add(Me.Vencimento)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.VlrLançar)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.VlrLançado)
        Me.PanelEx1.Controls.Add(Me.MyLista)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(658, 375)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'BancoCheque
        '
        Me.BancoCheque.Auto_Complete = True
        Me.BancoCheque.AutoLimitar_Lista = True
        Me.BancoCheque.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.BancoCheque.CPObrigatorio = False
        Me.BancoCheque.CPObrigatorioMsg = Nothing
        Me.BancoCheque.FlatBorder = False
        Me.BancoCheque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BancoCheque.FormattingEnabled = True
        Me.BancoCheque.HighlightBorderColor = System.Drawing.Color.Empty
        Me.BancoCheque.HighlightBorderOnEnter = False
        Me.BancoCheque.Location = New System.Drawing.Point(117, 41)
        Me.BancoCheque.Name = "BancoCheque"
        Me.BancoCheque.Size = New System.Drawing.Size(446, 23)
        Me.BancoCheque.TabIndex = 4
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(569, 64)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(83, 25)
        Me.btFechar.TabIndex = 26
        Me.btFechar.Text = "Fechar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(569, 95)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(83, 25)
        Me.btNovo.TabIndex = 15
        Me.btNovo.Text = "Novo"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(569, 126)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(83, 25)
        Me.btSalvar.TabIndex = 14
        Me.btSalvar.Text = "Salvar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'OSChequePreLancar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(658, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OSChequePreLancar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OS Lançamento de Cheque Pré-Datado - T225"
        Me.ItensLista.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Cheque As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CC As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Titular As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EntreguePor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ValorCh As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Vencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColCheque As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColCC As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColVencimento As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents VlrLançado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VlrLançar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Ped As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ItensLista As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditaItenDaListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirItemDaListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecalculaValoresDaListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdicionarNovoItemNaListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IDRECEBER As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IdCodigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BancoCheque As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
