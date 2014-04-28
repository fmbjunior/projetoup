<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChequePreClientesBaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChequePreClientesBaixa))
        Me.Cheque = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CC = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Titular = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EntreguePor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ValorCh = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Vencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataBaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Banco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Pedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BancoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Historico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Destino = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DescriçãoDestino = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IdCodigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btFindCC = New System.Windows.Forms.Label()
        Me.btFindContaBalancete = New System.Windows.Forms.Label()
        Me.ContaBalanceteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ContaBalancete = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LocalPgto = New CBOAutoCompleteFocus.CboFocus()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Vendedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MediaDescontoPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PercentComissao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btBaixar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cheque
        '
        Me.Cheque.AceitaColarTexto = True
        Me.Cheque.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cheque.CasasDecimais = 0
        Me.Cheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cheque.CPObrigatorio = False
        Me.Cheque.CPObrigatorioMsg = Nothing
        Me.Cheque.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cheque.FlatBorder = False
        Me.Cheque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cheque.FocusColor = System.Drawing.Color.MistyRose
        Me.Cheque.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cheque.HighlightBorderOnEnter = False
        Me.Cheque.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cheque.Location = New System.Drawing.Point(161, 3)
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
        Me.Label1.Location = New System.Drawing.Point(11, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cheque"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CC
        '
        Me.CC.AceitaColarTexto = True
        Me.CC.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CC.CasasDecimais = 0
        Me.CC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CC.CPObrigatorio = False
        Me.CC.CPObrigatorioMsg = Nothing
        Me.CC.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CC.FlatBorder = False
        Me.CC.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CC.FocusColor = System.Drawing.Color.MistyRose
        Me.CC.FocusColorEnd = System.Drawing.Color.Empty
        Me.CC.HighlightBorderOnEnter = False
        Me.CC.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CC.Location = New System.Drawing.Point(469, 3)
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
        Me.Label2.Location = New System.Drawing.Point(366, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "C/C"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Titular
        '
        Me.Titular.AceitaColarTexto = True
        Me.Titular.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Titular.CasasDecimais = 0
        Me.Titular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Titular.CPObrigatorio = False
        Me.Titular.CPObrigatorioMsg = Nothing
        Me.Titular.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Titular.FlatBorder = False
        Me.Titular.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Titular.FocusColor = System.Drawing.Color.MistyRose
        Me.Titular.FocusColorEnd = System.Drawing.Color.Empty
        Me.Titular.HighlightBorderOnEnter = False
        Me.Titular.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Titular.Location = New System.Drawing.Point(161, 32)
        Me.Titular.Name = "Titular"
        Me.Titular.PreencherZeroEsqueda = False
        Me.Titular.RegraValidação = Nothing
        Me.Titular.RegraValidaçãoMensagem = Nothing
        Me.Titular.Size = New System.Drawing.Size(424, 23)
        Me.Titular.TabIndex = 5
        Me.Titular.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Titular.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(11, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Titular"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EntreguePor
        '
        Me.EntreguePor.AceitaColarTexto = True
        Me.EntreguePor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EntreguePor.CasasDecimais = 0
        Me.EntreguePor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntreguePor.CPObrigatorio = False
        Me.EntreguePor.CPObrigatorioMsg = Nothing
        Me.EntreguePor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntreguePor.FlatBorder = False
        Me.EntreguePor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EntreguePor.FocusColor = System.Drawing.Color.MistyRose
        Me.EntreguePor.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntreguePor.HighlightBorderOnEnter = False
        Me.EntreguePor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EntreguePor.Location = New System.Drawing.Point(161, 61)
        Me.EntreguePor.Name = "EntreguePor"
        Me.EntreguePor.PreencherZeroEsqueda = False
        Me.EntreguePor.RegraValidação = Nothing
        Me.EntreguePor.RegraValidaçãoMensagem = Nothing
        Me.EntreguePor.Size = New System.Drawing.Size(424, 23)
        Me.EntreguePor.TabIndex = 7
        Me.EntreguePor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntreguePor.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(11, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Entregue Por"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorCh
        '
        Me.ValorCh.AceitaColarTexto = True
        Me.ValorCh.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorCh.CasasDecimais = 2
        Me.ValorCh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorCh.CPObrigatorio = False
        Me.ValorCh.CPObrigatorioMsg = Nothing
        Me.ValorCh.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorCh.FlatBorder = False
        Me.ValorCh.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorCh.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorCh.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorCh.HighlightBorderOnEnter = False
        Me.ValorCh.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorCh.Location = New System.Drawing.Point(161, 90)
        Me.ValorCh.Name = "ValorCh"
        Me.ValorCh.PreencherZeroEsqueda = False
        Me.ValorCh.RegraValidação = Nothing
        Me.ValorCh.RegraValidaçãoMensagem = Nothing
        Me.ValorCh.Size = New System.Drawing.Size(116, 23)
        Me.ValorCh.TabIndex = 9
        Me.ValorCh.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ValorCh.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(11, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Valor do Cheque"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vencimento
        '
        Me.Vencimento.AceitaColarTexto = True
        Me.Vencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Vencimento.CasasDecimais = 0
        Me.Vencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vencimento.CPObrigatorio = False
        Me.Vencimento.CPObrigatorioMsg = Nothing
        Me.Vencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vencimento.FlatBorder = False
        Me.Vencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vencimento.FocusColor = System.Drawing.Color.MistyRose
        Me.Vencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vencimento.HighlightBorderOnEnter = False
        Me.Vencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vencimento.Location = New System.Drawing.Point(161, 119)
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PreencherZeroEsqueda = False
        Me.Vencimento.RegraValidação = Nothing
        Me.Vencimento.RegraValidaçãoMensagem = Nothing
        Me.Vencimento.Size = New System.Drawing.Size(116, 23)
        Me.Vencimento.TabIndex = 11
        Me.Vencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Vencimento.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(11, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Vencimento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataBaixa
        '
        Me.DataBaixa.AceitaColarTexto = True
        Me.DataBaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataBaixa.CasasDecimais = 0
        Me.DataBaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataBaixa.CPObrigatorio = False
        Me.DataBaixa.CPObrigatorioMsg = Nothing
        Me.DataBaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataBaixa.FlatBorder = False
        Me.DataBaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataBaixa.FocusColor = System.Drawing.Color.MistyRose
        Me.DataBaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataBaixa.HighlightBorderOnEnter = False
        Me.DataBaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataBaixa.Location = New System.Drawing.Point(174, 401)
        Me.DataBaixa.MaxLength = 10
        Me.DataBaixa.Name = "DataBaixa"
        Me.DataBaixa.PreencherZeroEsqueda = False
        Me.DataBaixa.RegraValidação = Nothing
        Me.DataBaixa.RegraValidaçãoMensagem = Nothing
        Me.DataBaixa.Size = New System.Drawing.Size(116, 23)
        Me.DataBaixa.TabIndex = 15
        Me.DataBaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataBaixa.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(27, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Data da Baixa"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Banco
        '
        Me.Banco.AceitaColarTexto = True
        Me.Banco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Banco.CasasDecimais = 0
        Me.Banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Banco.CPObrigatorio = False
        Me.Banco.CPObrigatorioMsg = Nothing
        Me.Banco.Enabled = False
        Me.Banco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Banco.FlatBorder = False
        Me.Banco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Banco.FocusColor = System.Drawing.Color.MistyRose
        Me.Banco.FocusColorEnd = System.Drawing.Color.Empty
        Me.Banco.HighlightBorderOnEnter = False
        Me.Banco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Banco.Location = New System.Drawing.Point(175, 251)
        Me.Banco.Name = "Banco"
        Me.Banco.PreencherZeroEsqueda = False
        Me.Banco.RegraValidação = Nothing
        Me.Banco.RegraValidaçãoMensagem = Nothing
        Me.Banco.Size = New System.Drawing.Size(70, 23)
        Me.Banco.TabIndex = 4
        Me.Banco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Banco.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(25, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Banco"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pedido
        '
        Me.Pedido.AceitaColarTexto = True
        Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Pedido.CasasDecimais = 0
        Me.Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pedido.CPObrigatorio = False
        Me.Pedido.CPObrigatorioMsg = Nothing
        Me.Pedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Pedido.FlatBorder = False
        Me.Pedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Pedido.FocusColor = System.Drawing.Color.MistyRose
        Me.Pedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pedido.HighlightBorderOnEnter = False
        Me.Pedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Pedido.Location = New System.Drawing.Point(161, 148)
        Me.Pedido.Name = "Pedido"
        Me.Pedido.PreencherZeroEsqueda = False
        Me.Pedido.RegraValidação = Nothing
        Me.Pedido.RegraValidaçãoMensagem = Nothing
        Me.Pedido.Size = New System.Drawing.Size(116, 23)
        Me.Pedido.TabIndex = 13
        Me.Pedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pedido.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(11, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Pedido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BancoDesc
        '
        Me.BancoDesc.AceitaColarTexto = True
        Me.BancoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BancoDesc.CasasDecimais = 0
        Me.BancoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoDesc.CPObrigatorio = False
        Me.BancoDesc.CPObrigatorioMsg = Nothing
        Me.BancoDesc.Enabled = False
        Me.BancoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BancoDesc.FlatBorder = False
        Me.BancoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BancoDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.BancoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.BancoDesc.HighlightBorderOnEnter = False
        Me.BancoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BancoDesc.Location = New System.Drawing.Point(276, 251)
        Me.BancoDesc.Name = "BancoDesc"
        Me.BancoDesc.PreencherZeroEsqueda = False
        Me.BancoDesc.RegraValidação = Nothing
        Me.BancoDesc.RegraValidaçãoMensagem = Nothing
        Me.BancoDesc.Size = New System.Drawing.Size(322, 23)
        Me.BancoDesc.TabIndex = 5
        Me.BancoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BancoDesc.ValorPadrao = Nothing
        '
        'Historico
        '
        Me.Historico.AceitaColarTexto = True
        Me.Historico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Historico.CasasDecimais = 0
        Me.Historico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Historico.CPObrigatorio = False
        Me.Historico.CPObrigatorioMsg = Nothing
        Me.Historico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Historico.FlatBorder = False
        Me.Historico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Historico.FocusColor = System.Drawing.Color.MistyRose
        Me.Historico.FocusColorEnd = System.Drawing.Color.Empty
        Me.Historico.HighlightBorderOnEnter = False
        Me.Historico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Historico.Location = New System.Drawing.Point(469, 148)
        Me.Historico.Name = "Historico"
        Me.Historico.PreencherZeroEsqueda = False
        Me.Historico.RegraValidação = Nothing
        Me.Historico.RegraValidaçãoMensagem = Nothing
        Me.Historico.Size = New System.Drawing.Size(116, 23)
        Me.Historico.TabIndex = 14
        Me.Historico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Historico.ValorPadrao = Nothing
        Me.Historico.Visible = False
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
        Me.Destino.FocusColor = System.Drawing.Color.MistyRose
        Me.Destino.FocusColorEnd = System.Drawing.Color.Empty
        Me.Destino.HighlightBorderOnEnter = False
        Me.Destino.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Destino.Location = New System.Drawing.Point(175, 280)
        Me.Destino.MaxLength = 50
        Me.Destino.Name = "Destino"
        Me.Destino.PreencherZeroEsqueda = False
        Me.Destino.RegraValidação = Nothing
        Me.Destino.RegraValidaçãoMensagem = Nothing
        Me.Destino.Size = New System.Drawing.Size(424, 23)
        Me.Destino.TabIndex = 7
        Me.Destino.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Destino.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(25, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 19)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Destino do Cheque"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescriçãoDestino
        '
        Me.DescriçãoDestino.AceitaColarTexto = True
        Me.DescriçãoDestino.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescriçãoDestino.CasasDecimais = 0
        Me.DescriçãoDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescriçãoDestino.CPObrigatorio = False
        Me.DescriçãoDestino.CPObrigatorioMsg = Nothing
        Me.DescriçãoDestino.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescriçãoDestino.FlatBorder = False
        Me.DescriçãoDestino.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescriçãoDestino.FocusColor = System.Drawing.Color.MistyRose
        Me.DescriçãoDestino.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescriçãoDestino.HighlightBorderOnEnter = False
        Me.DescriçãoDestino.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescriçãoDestino.Location = New System.Drawing.Point(174, 309)
        Me.DescriçãoDestino.MaxLength = 250
        Me.DescriçãoDestino.Multiline = True
        Me.DescriçãoDestino.Name = "DescriçãoDestino"
        Me.DescriçãoDestino.PreencherZeroEsqueda = False
        Me.DescriçãoDestino.RegraValidação = Nothing
        Me.DescriçãoDestino.RegraValidaçãoMensagem = Nothing
        Me.DescriçãoDestino.Size = New System.Drawing.Size(424, 57)
        Me.DescriçãoDestino.TabIndex = 9
        Me.DescriçãoDestino.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescriçãoDestino.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(24, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 19)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Descrição"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IdCodigo
        '
        Me.IdCodigo.AceitaColarTexto = True
        Me.IdCodigo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IdCodigo.CasasDecimais = 0
        Me.IdCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdCodigo.CPObrigatorio = False
        Me.IdCodigo.CPObrigatorioMsg = Nothing
        Me.IdCodigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdCodigo.FlatBorder = False
        Me.IdCodigo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdCodigo.FocusColor = System.Drawing.Color.MistyRose
        Me.IdCodigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdCodigo.HighlightBorderOnEnter = False
        Me.IdCodigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdCodigo.Location = New System.Drawing.Point(27, 343)
        Me.IdCodigo.Name = "IdCodigo"
        Me.IdCodigo.PreencherZeroEsqueda = False
        Me.IdCodigo.RegraValidação = Nothing
        Me.IdCodigo.RegraValidaçãoMensagem = Nothing
        Me.IdCodigo.Size = New System.Drawing.Size(116, 23)
        Me.IdCodigo.TabIndex = 10
        Me.IdCodigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdCodigo.ValorPadrao = Nothing
        Me.IdCodigo.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btFindCC)
        Me.Fundo.Controls.Add(Me.btFindContaBalancete)
        Me.Fundo.Controls.Add(Me.ContaBalanceteDesc)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.ContaBalancete)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.LocalPgto)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.btBaixar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.DataBaixa)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.IdCodigo)
        Me.Fundo.Controls.Add(Me.DescriçãoDestino)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Destino)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.BancoDesc)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Banco)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(622, 434)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btFindCC
        '
        Me.btFindCC.Image = CType(resources.GetObject("btFindCC.Image"), System.Drawing.Image)
        Me.btFindCC.Location = New System.Drawing.Point(249, 252)
        Me.btFindCC.Name = "btFindCC"
        Me.btFindCC.Size = New System.Drawing.Size(22, 22)
        Me.btFindCC.TabIndex = 36
        '
        'btFindContaBalancete
        '
        Me.btFindContaBalancete.Image = CType(resources.GetObject("btFindContaBalancete.Image"), System.Drawing.Image)
        Me.btFindContaBalancete.Location = New System.Drawing.Point(249, 373)
        Me.btFindContaBalancete.Name = "btFindContaBalancete"
        Me.btFindContaBalancete.Size = New System.Drawing.Size(22, 21)
        Me.btFindContaBalancete.TabIndex = 35
        '
        'ContaBalanceteDesc
        '
        Me.ContaBalanceteDesc.AceitaColarTexto = True
        Me.ContaBalanceteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaBalanceteDesc.CasasDecimais = 2
        Me.ContaBalanceteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaBalanceteDesc.CPObrigatorio = False
        Me.ContaBalanceteDesc.CPObrigatorioMsg = Nothing
        Me.ContaBalanceteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaBalanceteDesc.FlatBorder = False
        Me.ContaBalanceteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaBalanceteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaBalanceteDesc.HighlightBorderOnEnter = False
        Me.ContaBalanceteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaBalanceteDesc.Location = New System.Drawing.Point(276, 372)
        Me.ContaBalanceteDesc.MaxLength = 6
        Me.ContaBalanceteDesc.Name = "ContaBalanceteDesc"
        Me.ContaBalanceteDesc.PreencherZeroEsqueda = False
        Me.ContaBalanceteDesc.RegraValidação = Nothing
        Me.ContaBalanceteDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaBalanceteDesc.Size = New System.Drawing.Size(322, 23)
        Me.ContaBalanceteDesc.TabIndex = 13
        Me.ContaBalanceteDesc.TabStop = False
        Me.ContaBalanceteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaBalanceteDesc.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(27, 373)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 22)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Conta Lançamento"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaBalancete
        '
        Me.ContaBalancete.AceitaColarTexto = True
        Me.ContaBalancete.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaBalancete.CasasDecimais = 2
        Me.ContaBalancete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaBalancete.CPObrigatorio = False
        Me.ContaBalancete.CPObrigatorioMsg = Nothing
        Me.ContaBalancete.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaBalancete.FlatBorder = False
        Me.ContaBalancete.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaBalancete.FocusColor = System.Drawing.Color.Empty
        Me.ContaBalancete.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaBalancete.HighlightBorderOnEnter = False
        Me.ContaBalancete.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaBalancete.Location = New System.Drawing.Point(174, 372)
        Me.ContaBalancete.MaxLength = 6
        Me.ContaBalancete.Name = "ContaBalancete"
        Me.ContaBalancete.PreencherZeroEsqueda = True
        Me.ContaBalancete.RegraValidação = Nothing
        Me.ContaBalancete.RegraValidaçãoMensagem = Nothing
        Me.ContaBalancete.Size = New System.Drawing.Size(71, 23)
        Me.ContaBalancete.TabIndex = 12
        Me.ContaBalancete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContaBalancete.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaBalancete.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(27, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Local de Pagamento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.LocalPgto.Location = New System.Drawing.Point(175, 220)
        Me.LocalPgto.Name = "LocalPgto"
        Me.LocalPgto.Size = New System.Drawing.Size(423, 23)
        Me.LocalPgto.TabIndex = 2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Vendedor)
        Me.GroupPanel1.Controls.Add(Me.MediaDescontoPedido)
        Me.GroupPanel1.Controls.Add(Me.PercentComissao)
        Me.GroupPanel1.Controls.Add(Me.Cheque)
        Me.GroupPanel1.Controls.Add(Me.Pedido)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Vencimento)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.ValorCh)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.CC)
        Me.GroupPanel1.Controls.Add(Me.EntreguePor)
        Me.GroupPanel1.Controls.Add(Me.Historico)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Titular)
        Me.GroupPanel1.Location = New System.Drawing.Point(11, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(599, 202)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Dados do Cheque"
        '
        'Vendedor
        '
        Me.Vendedor.AceitaColarTexto = True
        Me.Vendedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Vendedor.CasasDecimais = 2
        Me.Vendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vendedor.CPObrigatorio = False
        Me.Vendedor.CPObrigatorioMsg = Nothing
        Me.Vendedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vendedor.FlatBorder = False
        Me.Vendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vendedor.FocusColor = System.Drawing.Color.Empty
        Me.Vendedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vendedor.HighlightBorderOnEnter = False
        Me.Vendedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vendedor.Location = New System.Drawing.Point(369, 90)
        Me.Vendedor.MaxLength = 10
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.PreencherZeroEsqueda = False
        Me.Vendedor.RegraValidação = Nothing
        Me.Vendedor.RegraValidaçãoMensagem = Nothing
        Me.Vendedor.Size = New System.Drawing.Size(85, 23)
        Me.Vendedor.TabIndex = 31
        Me.Vendedor.TabStop = False
        Me.Vendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vendedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Vendedor.ValorPadrao = Nothing
        Me.Vendedor.Visible = False
        '
        'MediaDescontoPedido
        '
        Me.MediaDescontoPedido.AceitaColarTexto = True
        Me.MediaDescontoPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.MediaDescontoPedido.CasasDecimais = 2
        Me.MediaDescontoPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MediaDescontoPedido.CPObrigatorio = False
        Me.MediaDescontoPedido.CPObrigatorioMsg = Nothing
        Me.MediaDescontoPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.MediaDescontoPedido.FlatBorder = False
        Me.MediaDescontoPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.MediaDescontoPedido.FocusColor = System.Drawing.Color.Empty
        Me.MediaDescontoPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.MediaDescontoPedido.HighlightBorderOnEnter = False
        Me.MediaDescontoPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.MediaDescontoPedido.Location = New System.Drawing.Point(469, 89)
        Me.MediaDescontoPedido.MaxLength = 10
        Me.MediaDescontoPedido.Name = "MediaDescontoPedido"
        Me.MediaDescontoPedido.PreencherZeroEsqueda = False
        Me.MediaDescontoPedido.RegraValidação = Nothing
        Me.MediaDescontoPedido.RegraValidaçãoMensagem = Nothing
        Me.MediaDescontoPedido.Size = New System.Drawing.Size(85, 23)
        Me.MediaDescontoPedido.TabIndex = 30
        Me.MediaDescontoPedido.TabStop = False
        Me.MediaDescontoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MediaDescontoPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.MediaDescontoPedido.ValorPadrao = Nothing
        Me.MediaDescontoPedido.Visible = False
        '
        'PercentComissao
        '
        Me.PercentComissao.AceitaColarTexto = True
        Me.PercentComissao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PercentComissao.CasasDecimais = 2
        Me.PercentComissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PercentComissao.CPObrigatorio = False
        Me.PercentComissao.CPObrigatorioMsg = Nothing
        Me.PercentComissao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PercentComissao.FlatBorder = False
        Me.PercentComissao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.PercentComissao.FocusColor = System.Drawing.Color.Empty
        Me.PercentComissao.FocusColorEnd = System.Drawing.Color.Empty
        Me.PercentComissao.HighlightBorderOnEnter = False
        Me.PercentComissao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.PercentComissao.Location = New System.Drawing.Point(469, 118)
        Me.PercentComissao.MaxLength = 10
        Me.PercentComissao.Name = "PercentComissao"
        Me.PercentComissao.PreencherZeroEsqueda = False
        Me.PercentComissao.RegraValidação = Nothing
        Me.PercentComissao.RegraValidaçãoMensagem = Nothing
        Me.PercentComissao.Size = New System.Drawing.Size(85, 23)
        Me.PercentComissao.TabIndex = 29
        Me.PercentComissao.TabStop = False
        Me.PercentComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercentComissao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.PercentComissao.ValorPadrao = Nothing
        Me.PercentComissao.Visible = False
        '
        'btBaixar
        '
        Me.btBaixar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBaixar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBaixar.Location = New System.Drawing.Point(407, 401)
        Me.btBaixar.Name = "btBaixar"
        Me.btBaixar.Size = New System.Drawing.Size(92, 25)
        Me.btBaixar.TabIndex = 16
        Me.btBaixar.Text = "Baixar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(506, 401)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(92, 25)
        Me.btFechar.TabIndex = 17
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ChequePreClientesBaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(622, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChequePreClientesBaixa"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baixa de Cheques Pre-Datados - T113"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cheque As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CC As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Titular As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EntreguePor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ValorCh As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Vencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataBaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Banco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Pedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BancoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Historico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Destino As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DescriçãoDestino As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents IdCodigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btBaixar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LocalPgto As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents ContaBalanceteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ContaBalancete As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindCC As System.Windows.Forms.Label
    Friend WithEvents btFindContaBalancete As System.Windows.Forms.Label
    Friend WithEvents MediaDescontoPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PercentComissao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Vendedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
