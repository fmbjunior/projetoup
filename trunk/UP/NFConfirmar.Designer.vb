<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NFConfirmar
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ValorIcms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Icms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BaseCalcIcms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MaterialParaImobilizado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IsentoIcms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValorOutrosIcms = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValorOutrosIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IsentoIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BaseCalcIpi = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PlacaVeiculo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FreteContaDo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ObsCupon = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Obs = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Mensagem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.BtHelpMensagem = New System.Windows.Forms.Label()
        Me.FormaPagamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.FormaPagamentoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TransportadoraDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Transportadora = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btSalvarImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(9, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 19)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Valor ICMS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorIcms
        '
        Me.ValorIcms.AceitaColarTexto = True
        Me.ValorIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorIcms.CasasDecimais = 2
        Me.ValorIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorIcms.CPObrigatorio = False
        Me.ValorIcms.CPObrigatorioMsg = Nothing
        Me.ValorIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorIcms.FlatBorder = False
        Me.ValorIcms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorIcms.FocusColor = System.Drawing.Color.Empty
        Me.ValorIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorIcms.HighlightBorderOnEnter = False
        Me.ValorIcms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorIcms.Location = New System.Drawing.Point(132, 97)
        Me.ValorIcms.MaxLength = 10
        Me.ValorIcms.Name = "ValorIcms"
        Me.ValorIcms.PreencherZeroEsqueda = False
        Me.ValorIcms.RegraValidação = Nothing
        Me.ValorIcms.RegraValidaçãoMensagem = Nothing
        Me.ValorIcms.Size = New System.Drawing.Size(135, 23)
        Me.ValorIcms.TabIndex = 7
        Me.ValorIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorIcms.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(13, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 19)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "ICMS %"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Icms
        '
        Me.Icms.AceitaColarTexto = True
        Me.Icms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Icms.CasasDecimais = 0
        Me.Icms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Icms.CPObrigatorio = False
        Me.Icms.CPObrigatorioMsg = Nothing
        Me.Icms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Icms.FlatBorder = False
        Me.Icms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Icms.FocusColor = System.Drawing.Color.Empty
        Me.Icms.FocusColorEnd = System.Drawing.Color.Empty
        Me.Icms.HighlightBorderOnEnter = False
        Me.Icms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Icms.Location = New System.Drawing.Point(132, 39)
        Me.Icms.Name = "Icms"
        Me.Icms.PreencherZeroEsqueda = False
        Me.Icms.RegraValidação = Nothing
        Me.Icms.RegraValidaçãoMensagem = Nothing
        Me.Icms.Size = New System.Drawing.Size(40, 23)
        Me.Icms.TabIndex = 3
        Me.Icms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Icms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Icms.ValorPadrao = Nothing
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(9, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 19)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Base Calc. ICMS"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BaseCalcIcms
        '
        Me.BaseCalcIcms.AceitaColarTexto = True
        Me.BaseCalcIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BaseCalcIcms.CasasDecimais = 2
        Me.BaseCalcIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BaseCalcIcms.CPObrigatorio = False
        Me.BaseCalcIcms.CPObrigatorioMsg = Nothing
        Me.BaseCalcIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BaseCalcIcms.FlatBorder = False
        Me.BaseCalcIcms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcms.FocusColor = System.Drawing.Color.Empty
        Me.BaseCalcIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.BaseCalcIcms.HighlightBorderOnEnter = False
        Me.BaseCalcIcms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BaseCalcIcms.Location = New System.Drawing.Point(132, 68)
        Me.BaseCalcIcms.MaxLength = 10
        Me.BaseCalcIcms.Name = "BaseCalcIcms"
        Me.BaseCalcIcms.PreencherZeroEsqueda = False
        Me.BaseCalcIcms.RegraValidação = Nothing
        Me.BaseCalcIcms.RegraValidaçãoMensagem = Nothing
        Me.BaseCalcIcms.Size = New System.Drawing.Size(135, 23)
        Me.BaseCalcIcms.TabIndex = 5
        Me.BaseCalcIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BaseCalcIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.BaseCalcIcms.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(13, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "IMOBILIZADO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialParaImobilizado
        '
        Me.MaterialParaImobilizado.AceitaColarTexto = True
        Me.MaterialParaImobilizado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.MaterialParaImobilizado.CasasDecimais = 0
        Me.MaterialParaImobilizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MaterialParaImobilizado.CPObrigatorio = False
        Me.MaterialParaImobilizado.CPObrigatorioMsg = Nothing
        Me.MaterialParaImobilizado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.MaterialParaImobilizado.FlatBorder = False
        Me.MaterialParaImobilizado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.MaterialParaImobilizado.FocusColor = System.Drawing.Color.Empty
        Me.MaterialParaImobilizado.FocusColorEnd = System.Drawing.Color.Empty
        Me.MaterialParaImobilizado.HighlightBorderOnEnter = False
        Me.MaterialParaImobilizado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.MaterialParaImobilizado.Location = New System.Drawing.Point(132, 10)
        Me.MaterialParaImobilizado.Name = "MaterialParaImobilizado"
        Me.MaterialParaImobilizado.PreencherZeroEsqueda = False
        Me.MaterialParaImobilizado.RegraValidação = Nothing
        Me.MaterialParaImobilizado.RegraValidaçãoMensagem = Nothing
        Me.MaterialParaImobilizado.Size = New System.Drawing.Size(40, 23)
        Me.MaterialParaImobilizado.TabIndex = 1
        Me.MaterialParaImobilizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaterialParaImobilizado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.MaterialParaImobilizado.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Isento ICMS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IsentoIcms
        '
        Me.IsentoIcms.AceitaColarTexto = True
        Me.IsentoIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IsentoIcms.CasasDecimais = 2
        Me.IsentoIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IsentoIcms.CPObrigatorio = False
        Me.IsentoIcms.CPObrigatorioMsg = Nothing
        Me.IsentoIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IsentoIcms.FlatBorder = False
        Me.IsentoIcms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IsentoIcms.FocusColor = System.Drawing.Color.Empty
        Me.IsentoIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.IsentoIcms.HighlightBorderOnEnter = False
        Me.IsentoIcms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IsentoIcms.Location = New System.Drawing.Point(132, 126)
        Me.IsentoIcms.MaxLength = 10
        Me.IsentoIcms.Name = "IsentoIcms"
        Me.IsentoIcms.PreencherZeroEsqueda = False
        Me.IsentoIcms.RegraValidação = Nothing
        Me.IsentoIcms.RegraValidaçãoMensagem = Nothing
        Me.IsentoIcms.Size = New System.Drawing.Size(135, 23)
        Me.IsentoIcms.TabIndex = 9
        Me.IsentoIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IsentoIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.IsentoIcms.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Outros ICMS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorOutrosIcms
        '
        Me.ValorOutrosIcms.AceitaColarTexto = True
        Me.ValorOutrosIcms.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorOutrosIcms.CasasDecimais = 2
        Me.ValorOutrosIcms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorOutrosIcms.CPObrigatorio = False
        Me.ValorOutrosIcms.CPObrigatorioMsg = Nothing
        Me.ValorOutrosIcms.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorOutrosIcms.FlatBorder = False
        Me.ValorOutrosIcms.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorOutrosIcms.FocusColor = System.Drawing.Color.Empty
        Me.ValorOutrosIcms.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorOutrosIcms.HighlightBorderOnEnter = False
        Me.ValorOutrosIcms.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorOutrosIcms.Location = New System.Drawing.Point(132, 155)
        Me.ValorOutrosIcms.MaxLength = 10
        Me.ValorOutrosIcms.Name = "ValorOutrosIcms"
        Me.ValorOutrosIcms.PreencherZeroEsqueda = False
        Me.ValorOutrosIcms.RegraValidação = Nothing
        Me.ValorOutrosIcms.RegraValidaçãoMensagem = Nothing
        Me.ValorOutrosIcms.Size = New System.Drawing.Size(135, 23)
        Me.ValorOutrosIcms.TabIndex = 11
        Me.ValorOutrosIcms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorOutrosIcms.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorOutrosIcms.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(287, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Outros IPI"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorOutrosIpi
        '
        Me.ValorOutrosIpi.AceitaColarTexto = True
        Me.ValorOutrosIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorOutrosIpi.CasasDecimais = 2
        Me.ValorOutrosIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorOutrosIpi.CPObrigatorio = False
        Me.ValorOutrosIpi.CPObrigatorioMsg = Nothing
        Me.ValorOutrosIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorOutrosIpi.FlatBorder = False
        Me.ValorOutrosIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorOutrosIpi.FocusColor = System.Drawing.Color.Empty
        Me.ValorOutrosIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorOutrosIpi.HighlightBorderOnEnter = False
        Me.ValorOutrosIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorOutrosIpi.Location = New System.Drawing.Point(409, 156)
        Me.ValorOutrosIpi.MaxLength = 10
        Me.ValorOutrosIpi.Name = "ValorOutrosIpi"
        Me.ValorOutrosIpi.PreencherZeroEsqueda = False
        Me.ValorOutrosIpi.RegraValidação = Nothing
        Me.ValorOutrosIpi.RegraValidaçãoMensagem = Nothing
        Me.ValorOutrosIpi.Size = New System.Drawing.Size(135, 23)
        Me.ValorOutrosIpi.TabIndex = 19
        Me.ValorOutrosIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorOutrosIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorOutrosIpi.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(287, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Isento IPI"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IsentoIpi
        '
        Me.IsentoIpi.AceitaColarTexto = True
        Me.IsentoIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IsentoIpi.CasasDecimais = 2
        Me.IsentoIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IsentoIpi.CPObrigatorio = False
        Me.IsentoIpi.CPObrigatorioMsg = Nothing
        Me.IsentoIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IsentoIpi.FlatBorder = False
        Me.IsentoIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IsentoIpi.FocusColor = System.Drawing.Color.Empty
        Me.IsentoIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.IsentoIpi.HighlightBorderOnEnter = False
        Me.IsentoIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IsentoIpi.Location = New System.Drawing.Point(409, 127)
        Me.IsentoIpi.MaxLength = 10
        Me.IsentoIpi.Name = "IsentoIpi"
        Me.IsentoIpi.PreencherZeroEsqueda = False
        Me.IsentoIpi.RegraValidação = Nothing
        Me.IsentoIpi.RegraValidaçãoMensagem = Nothing
        Me.IsentoIpi.Size = New System.Drawing.Size(135, 23)
        Me.IsentoIpi.TabIndex = 17
        Me.IsentoIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IsentoIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.IsentoIpi.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(287, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Valor IPI"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalIpi
        '
        Me.TotalIpi.AceitaColarTexto = True
        Me.TotalIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalIpi.CasasDecimais = 2
        Me.TotalIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalIpi.CPObrigatorio = False
        Me.TotalIpi.CPObrigatorioMsg = Nothing
        Me.TotalIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalIpi.FlatBorder = False
        Me.TotalIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalIpi.FocusColor = System.Drawing.Color.Empty
        Me.TotalIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalIpi.HighlightBorderOnEnter = False
        Me.TotalIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalIpi.Location = New System.Drawing.Point(409, 98)
        Me.TotalIpi.MaxLength = 10
        Me.TotalIpi.Name = "TotalIpi"
        Me.TotalIpi.PreencherZeroEsqueda = False
        Me.TotalIpi.RegraValidação = Nothing
        Me.TotalIpi.RegraValidaçãoMensagem = Nothing
        Me.TotalIpi.Size = New System.Drawing.Size(135, 23)
        Me.TotalIpi.TabIndex = 15
        Me.TotalIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalIpi.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(287, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Base Calc. IPI"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BaseCalcIpi
        '
        Me.BaseCalcIpi.AceitaColarTexto = True
        Me.BaseCalcIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.BaseCalcIpi.CasasDecimais = 2
        Me.BaseCalcIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BaseCalcIpi.CPObrigatorio = False
        Me.BaseCalcIpi.CPObrigatorioMsg = Nothing
        Me.BaseCalcIpi.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BaseCalcIpi.FlatBorder = False
        Me.BaseCalcIpi.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BaseCalcIpi.FocusColor = System.Drawing.Color.Empty
        Me.BaseCalcIpi.FocusColorEnd = System.Drawing.Color.Empty
        Me.BaseCalcIpi.HighlightBorderOnEnter = False
        Me.BaseCalcIpi.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BaseCalcIpi.Location = New System.Drawing.Point(409, 69)
        Me.BaseCalcIpi.MaxLength = 10
        Me.BaseCalcIpi.Name = "BaseCalcIpi"
        Me.BaseCalcIpi.PreencherZeroEsqueda = False
        Me.BaseCalcIpi.RegraValidação = Nothing
        Me.BaseCalcIpi.RegraValidaçãoMensagem = Nothing
        Me.BaseCalcIpi.Size = New System.Drawing.Size(135, 23)
        Me.BaseCalcIpi.TabIndex = 13
        Me.BaseCalcIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BaseCalcIpi.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.BaseCalcIpi.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(9, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Transportadora"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(13, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Placa Veiculo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PlacaVeiculo
        '
        Me.PlacaVeiculo.AceitaColarTexto = True
        Me.PlacaVeiculo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PlacaVeiculo.CasasDecimais = 0
        Me.PlacaVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PlacaVeiculo.CPObrigatorio = False
        Me.PlacaVeiculo.CPObrigatorioMsg = Nothing
        Me.PlacaVeiculo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PlacaVeiculo.FlatBorder = False
        Me.PlacaVeiculo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.PlacaVeiculo.FocusColor = System.Drawing.Color.Empty
        Me.PlacaVeiculo.FocusColorEnd = System.Drawing.Color.Empty
        Me.PlacaVeiculo.HighlightBorderOnEnter = False
        Me.PlacaVeiculo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.PlacaVeiculo.Location = New System.Drawing.Point(132, 213)
        Me.PlacaVeiculo.Name = "PlacaVeiculo"
        Me.PlacaVeiculo.PreencherZeroEsqueda = False
        Me.PlacaVeiculo.RegraValidação = Nothing
        Me.PlacaVeiculo.RegraValidaçãoMensagem = Nothing
        Me.PlacaVeiculo.Size = New System.Drawing.Size(135, 23)
        Me.PlacaVeiculo.TabIndex = 24
        Me.PlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PlacaVeiculo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.PlacaVeiculo.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(385, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 19)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Frete Conta do"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FreteContaDo
        '
        Me.FreteContaDo.AceitaColarTexto = True
        Me.FreteContaDo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FreteContaDo.CasasDecimais = 0
        Me.FreteContaDo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FreteContaDo.CPObrigatorio = False
        Me.FreteContaDo.CPObrigatorioMsg = Nothing
        Me.FreteContaDo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FreteContaDo.FlatBorder = False
        Me.FreteContaDo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FreteContaDo.FocusColor = System.Drawing.Color.Empty
        Me.FreteContaDo.FocusColorEnd = System.Drawing.Color.Empty
        Me.FreteContaDo.HighlightBorderOnEnter = False
        Me.FreteContaDo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FreteContaDo.Location = New System.Drawing.Point(503, 212)
        Me.FreteContaDo.Name = "FreteContaDo"
        Me.FreteContaDo.PreencherZeroEsqueda = False
        Me.FreteContaDo.RegraValidação = Nothing
        Me.FreteContaDo.RegraValidaçãoMensagem = Nothing
        Me.FreteContaDo.Size = New System.Drawing.Size(40, 23)
        Me.FreteContaDo.TabIndex = 26
        Me.FreteContaDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FreteContaDo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FreteContaDo.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(13, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Mensagem"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(290, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 19)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "0-AVista 1-Aprazo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(13, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 19)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Nº Cupom Fiscal"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObsCupon
        '
        Me.ObsCupon.AceitaColarTexto = True
        Me.ObsCupon.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ObsCupon.CasasDecimais = 0
        Me.ObsCupon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ObsCupon.CPObrigatorio = False
        Me.ObsCupon.CPObrigatorioMsg = Nothing
        Me.ObsCupon.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ObsCupon.FlatBorder = False
        Me.ObsCupon.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ObsCupon.FocusColor = System.Drawing.Color.Empty
        Me.ObsCupon.FocusColorEnd = System.Drawing.Color.Empty
        Me.ObsCupon.HighlightBorderOnEnter = False
        Me.ObsCupon.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ObsCupon.Location = New System.Drawing.Point(132, 271)
        Me.ObsCupon.Name = "ObsCupon"
        Me.ObsCupon.PreencherZeroEsqueda = False
        Me.ObsCupon.RegraValidação = Nothing
        Me.ObsCupon.RegraValidaçãoMensagem = Nothing
        Me.ObsCupon.Size = New System.Drawing.Size(135, 23)
        Me.ObsCupon.TabIndex = 34
        Me.ObsCupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ObsCupon.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ObsCupon.ValorPadrao = Nothing
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(12, 300)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 19)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Observação"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Obs
        '
        Me.Obs.AceitaColarTexto = True
        Me.Obs.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Obs.CasasDecimais = 0
        Me.Obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Obs.CPObrigatorio = False
        Me.Obs.CPObrigatorioMsg = Nothing
        Me.Obs.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Obs.FlatBorder = False
        Me.Obs.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Obs.FocusColor = System.Drawing.Color.Empty
        Me.Obs.FocusColorEnd = System.Drawing.Color.Empty
        Me.Obs.HighlightBorderOnEnter = False
        Me.Obs.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Obs.Location = New System.Drawing.Point(131, 300)
        Me.Obs.Multiline = True
        Me.Obs.Name = "Obs"
        Me.Obs.PreencherZeroEsqueda = False
        Me.Obs.RegraValidação = Nothing
        Me.Obs.RegraValidaçãoMensagem = Nothing
        Me.Obs.Size = New System.Drawing.Size(412, 56)
        Me.Obs.TabIndex = 36
        Me.Obs.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Obs.ValorPadrao = Nothing
        '
        'Mensagem
        '
        Me.Mensagem.AceitaColarTexto = True
        Me.Mensagem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Mensagem.CasasDecimais = 0
        Me.Mensagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mensagem.CPObrigatorio = False
        Me.Mensagem.CPObrigatorioMsg = Nothing
        Me.Mensagem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Mensagem.FlatBorder = False
        Me.Mensagem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Mensagem.FocusColor = System.Drawing.Color.Empty
        Me.Mensagem.FocusColorEnd = System.Drawing.Color.Empty
        Me.Mensagem.HighlightBorderOnEnter = False
        Me.Mensagem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Mensagem.Location = New System.Drawing.Point(132, 242)
        Me.Mensagem.Name = "Mensagem"
        Me.Mensagem.PreencherZeroEsqueda = False
        Me.Mensagem.RegraValidação = Nothing
        Me.Mensagem.RegraValidaçãoMensagem = Nothing
        Me.Mensagem.Size = New System.Drawing.Size(40, 23)
        Me.Mensagem.TabIndex = 28
        Me.Mensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensagem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Mensagem.ValorPadrao = Nothing
        '
        'BtHelpMensagem
        '
        Me.BtHelpMensagem.BackColor = System.Drawing.Color.Transparent
        Me.BtHelpMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtHelpMensagem.Location = New System.Drawing.Point(180, 242)
        Me.BtHelpMensagem.Name = "BtHelpMensagem"
        Me.BtHelpMensagem.Size = New System.Drawing.Size(71, 19)
        Me.BtHelpMensagem.TabIndex = 29
        Me.BtHelpMensagem.Text = "1-2-3-4-5"
        Me.BtHelpMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormaPagamento
        '
        Me.FormaPagamento.AceitaColarTexto = True
        Me.FormaPagamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FormaPagamento.CasasDecimais = 0
        Me.FormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FormaPagamento.CPObrigatorio = False
        Me.FormaPagamento.CPObrigatorioMsg = Nothing
        Me.FormaPagamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FormaPagamento.FlatBorder = False
        Me.FormaPagamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FormaPagamento.FocusColor = System.Drawing.Color.Empty
        Me.FormaPagamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.FormaPagamento.HighlightBorderOnEnter = False
        Me.FormaPagamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FormaPagamento.Location = New System.Drawing.Point(409, 246)
        Me.FormaPagamento.Name = "FormaPagamento"
        Me.FormaPagamento.PreencherZeroEsqueda = False
        Me.FormaPagamento.RegraValidação = Nothing
        Me.FormaPagamento.RegraValidaçãoMensagem = Nothing
        Me.FormaPagamento.Size = New System.Drawing.Size(27, 23)
        Me.FormaPagamento.TabIndex = 31
        Me.FormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FormaPagamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FormaPagamento.ValorPadrao = Nothing
        '
        'FormaPagamentoDesc
        '
        Me.FormaPagamentoDesc.AceitaColarTexto = True
        Me.FormaPagamentoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FormaPagamentoDesc.CasasDecimais = 0
        Me.FormaPagamentoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FormaPagamentoDesc.CPObrigatorio = False
        Me.FormaPagamentoDesc.CPObrigatorioMsg = Nothing
        Me.FormaPagamentoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FormaPagamentoDesc.FlatBorder = False
        Me.FormaPagamentoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FormaPagamentoDesc.FocusColor = System.Drawing.Color.Empty
        Me.FormaPagamentoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FormaPagamentoDesc.HighlightBorderOnEnter = False
        Me.FormaPagamentoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FormaPagamentoDesc.Location = New System.Drawing.Point(444, 246)
        Me.FormaPagamentoDesc.Name = "FormaPagamentoDesc"
        Me.FormaPagamentoDesc.PreencherZeroEsqueda = False
        Me.FormaPagamentoDesc.RegraValidação = Nothing
        Me.FormaPagamentoDesc.RegraValidaçãoMensagem = Nothing
        Me.FormaPagamentoDesc.Size = New System.Drawing.Size(100, 23)
        Me.FormaPagamentoDesc.TabIndex = 32
        Me.FormaPagamentoDesc.TabStop = False
        Me.FormaPagamentoDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FormaPagamentoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FormaPagamentoDesc.ValorPadrao = Nothing
        '
        'TransportadoraDesc
        '
        Me.TransportadoraDesc.AceitaColarTexto = True
        Me.TransportadoraDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TransportadoraDesc.CasasDecimais = 0
        Me.TransportadoraDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TransportadoraDesc.CPObrigatorio = False
        Me.TransportadoraDesc.CPObrigatorioMsg = Nothing
        Me.TransportadoraDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TransportadoraDesc.FlatBorder = False
        Me.TransportadoraDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TransportadoraDesc.FocusColor = System.Drawing.Color.Empty
        Me.TransportadoraDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.TransportadoraDesc.HighlightBorderOnEnter = False
        Me.TransportadoraDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TransportadoraDesc.Location = New System.Drawing.Point(216, 184)
        Me.TransportadoraDesc.Name = "TransportadoraDesc"
        Me.TransportadoraDesc.PreencherZeroEsqueda = False
        Me.TransportadoraDesc.RegraValidação = Nothing
        Me.TransportadoraDesc.RegraValidaçãoMensagem = Nothing
        Me.TransportadoraDesc.Size = New System.Drawing.Size(328, 23)
        Me.TransportadoraDesc.TabIndex = 22
        Me.TransportadoraDesc.TabStop = False
        Me.TransportadoraDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TransportadoraDesc.ValorPadrao = Nothing
        '
        'Transportadora
        '
        Me.Transportadora.AceitaColarTexto = True
        Me.Transportadora.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Transportadora.CasasDecimais = 0
        Me.Transportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Transportadora.CPObrigatorio = False
        Me.Transportadora.CPObrigatorioMsg = Nothing
        Me.Transportadora.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Transportadora.FlatBorder = False
        Me.Transportadora.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Transportadora.FocusColor = System.Drawing.Color.Empty
        Me.Transportadora.FocusColorEnd = System.Drawing.Color.Empty
        Me.Transportadora.HighlightBorderOnEnter = False
        Me.Transportadora.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Transportadora.Location = New System.Drawing.Point(132, 184)
        Me.Transportadora.MaxLength = 6
        Me.Transportadora.Name = "Transportadora"
        Me.Transportadora.PreencherZeroEsqueda = False
        Me.Transportadora.RegraValidação = Nothing
        Me.Transportadora.RegraValidaçãoMensagem = Nothing
        Me.Transportadora.Size = New System.Drawing.Size(76, 23)
        Me.Transportadora.TabIndex = 21
        Me.Transportadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Transportadora.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Transportadora.ValorPadrao = Nothing
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btSalvarImprimir)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.TransportadoraDesc)
        Me.PanelEx1.Controls.Add(Me.MaterialParaImobilizado)
        Me.PanelEx1.Controls.Add(Me.Transportadora)
        Me.PanelEx1.Controls.Add(Me.BaseCalcIcms)
        Me.PanelEx1.Controls.Add(Me.FormaPagamentoDesc)
        Me.PanelEx1.Controls.Add(Me.Label15)
        Me.PanelEx1.Controls.Add(Me.FormaPagamento)
        Me.PanelEx1.Controls.Add(Me.Icms)
        Me.PanelEx1.Controls.Add(Me.BtHelpMensagem)
        Me.PanelEx1.Controls.Add(Me.Label16)
        Me.PanelEx1.Controls.Add(Me.Mensagem)
        Me.PanelEx1.Controls.Add(Me.ValorIcms)
        Me.PanelEx1.Controls.Add(Me.Label17)
        Me.PanelEx1.Controls.Add(Me.IsentoIcms)
        Me.PanelEx1.Controls.Add(Me.Label14)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Obs)
        Me.PanelEx1.Controls.Add(Me.ValorOutrosIcms)
        Me.PanelEx1.Controls.Add(Me.Label13)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.ObsCupon)
        Me.PanelEx1.Controls.Add(Me.BaseCalcIpi)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.TotalIpi)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.FreteContaDo)
        Me.PanelEx1.Controls.Add(Me.IsentoIpi)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.PlacaVeiculo)
        Me.PanelEx1.Controls.Add(Me.ValorOutrosIpi)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(557, 393)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btSalvarImprimir
        '
        Me.btSalvarImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvarImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvarImprimir.Location = New System.Drawing.Point(357, 362)
        Me.btSalvarImprimir.Name = "btSalvarImprimir"
        Me.btSalvarImprimir.Size = New System.Drawing.Size(105, 23)
        Me.btSalvarImprimir.TabIndex = 37
        Me.btSalvarImprimir.Text = "Salvar e Imprimir"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(468, 362)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 38
        Me.btFechar.Text = "Fechar"
        '
        'NFConfirmar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(557, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NFConfirmar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar e Imprimir Nota Fiscal - T151"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ValorIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Icms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BaseCalcIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MaterialParaImobilizado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IsentoIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ValorOutrosIcms As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ValorOutrosIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IsentoIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotalIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BaseCalcIpi As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PlacaVeiculo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FreteContaDo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ObsCupon As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Obs As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Mensagem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BtHelpMensagem As System.Windows.Forms.Label
    Friend WithEvents FormaPagamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents FormaPagamentoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TransportadoraDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Transportadora As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btSalvarImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
End Class
