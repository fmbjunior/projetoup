<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesProcurador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesProcurador))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UFProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CepProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CidadeProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BairroProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EndProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NomeProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CpfProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RgProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NumeroEndProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EstadoCivilProcurador = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Salvar = New System.Windows.Forms.Button()
        Me.Fechar = New System.Windows.Forms.Button()
        Me.PrintProcuração = New System.Windows.Forms.Button()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "UF"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UFProcurador
        '
        Me.UFProcurador.AceitaColarTexto = True
        Me.UFProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UFProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.UFProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UFProcurador.CasasDecimais = 0
        Me.UFProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UFProcurador.CPObrigatorio = False
        Me.UFProcurador.CPObrigatorioMsg = Nothing
        Me.UFProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.UFProcurador.FlatBorder = False
        Me.UFProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UFProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.UFProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.UFProcurador.HighlightBorderOnEnter = False
        Me.UFProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.UFProcurador.Location = New System.Drawing.Point(135, 138)
        Me.UFProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UFProcurador.MaxLength = 2
        Me.UFProcurador.Name = "UFProcurador"
        Me.UFProcurador.PreencherZeroEsqueda = False
        Me.UFProcurador.RegraValidação = Nothing
        Me.UFProcurador.RegraValidaçãoMensagem = Nothing
        Me.UFProcurador.Size = New System.Drawing.Size(25, 20)
        Me.UFProcurador.TabIndex = 17
        Me.UFProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UFProcurador.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(376, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cep"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CepProcurador
        '
        Me.CepProcurador.AceitaColarTexto = True
        Me.CepProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CepProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CepProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CepProcurador.CasasDecimais = 0
        Me.CepProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CepProcurador.CPObrigatorio = False
        Me.CepProcurador.CPObrigatorioMsg = Nothing
        Me.CepProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CepProcurador.FlatBorder = False
        Me.CepProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CepProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.CepProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.CepProcurador.HighlightBorderOnEnter = False
        Me.CepProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CepProcurador.Location = New System.Drawing.Point(456, 114)
        Me.CepProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CepProcurador.MaxLength = 9
        Me.CepProcurador.Name = "CepProcurador"
        Me.CepProcurador.PreencherZeroEsqueda = False
        Me.CepProcurador.RegraValidação = Nothing
        Me.CepProcurador.RegraValidaçãoMensagem = Nothing
        Me.CepProcurador.Size = New System.Drawing.Size(128, 20)
        Me.CepProcurador.TabIndex = 15
        Me.CepProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cep
        Me.CepProcurador.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cidade"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CidadeProcurador
        '
        Me.CidadeProcurador.AceitaColarTexto = True
        Me.CidadeProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CidadeProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CidadeProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CidadeProcurador.CasasDecimais = 0
        Me.CidadeProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CidadeProcurador.CPObrigatorio = False
        Me.CidadeProcurador.CPObrigatorioMsg = Nothing
        Me.CidadeProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CidadeProcurador.FlatBorder = False
        Me.CidadeProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CidadeProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.CidadeProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.CidadeProcurador.HighlightBorderOnEnter = False
        Me.CidadeProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CidadeProcurador.Location = New System.Drawing.Point(135, 114)
        Me.CidadeProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CidadeProcurador.MaxLength = 30
        Me.CidadeProcurador.Name = "CidadeProcurador"
        Me.CidadeProcurador.PreencherZeroEsqueda = False
        Me.CidadeProcurador.RegraValidação = Nothing
        Me.CidadeProcurador.RegraValidaçãoMensagem = Nothing
        Me.CidadeProcurador.Size = New System.Drawing.Size(215, 20)
        Me.CidadeProcurador.TabIndex = 13
        Me.CidadeProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CidadeProcurador.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Bairro"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BairroProcurador
        '
        Me.BairroProcurador.AceitaColarTexto = True
        Me.BairroProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BairroProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BairroProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BairroProcurador.CasasDecimais = 0
        Me.BairroProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BairroProcurador.CPObrigatorio = False
        Me.BairroProcurador.CPObrigatorioMsg = Nothing
        Me.BairroProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.BairroProcurador.FlatBorder = False
        Me.BairroProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BairroProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.BairroProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.BairroProcurador.HighlightBorderOnEnter = False
        Me.BairroProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.BairroProcurador.Location = New System.Drawing.Point(135, 90)
        Me.BairroProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BairroProcurador.MaxLength = 30
        Me.BairroProcurador.Name = "BairroProcurador"
        Me.BairroProcurador.PreencherZeroEsqueda = False
        Me.BairroProcurador.RegraValidação = Nothing
        Me.BairroProcurador.RegraValidaçãoMensagem = Nothing
        Me.BairroProcurador.Size = New System.Drawing.Size(353, 20)
        Me.BairroProcurador.TabIndex = 11
        Me.BairroProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BairroProcurador.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Endereço"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EndProcurador
        '
        Me.EndProcurador.AceitaColarTexto = True
        Me.EndProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EndProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EndProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EndProcurador.CasasDecimais = 0
        Me.EndProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EndProcurador.CPObrigatorio = False
        Me.EndProcurador.CPObrigatorioMsg = Nothing
        Me.EndProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EndProcurador.FlatBorder = False
        Me.EndProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EndProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.EndProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.EndProcurador.HighlightBorderOnEnter = False
        Me.EndProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EndProcurador.Location = New System.Drawing.Point(135, 66)
        Me.EndProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EndProcurador.MaxLength = 50
        Me.EndProcurador.Name = "EndProcurador"
        Me.EndProcurador.PreencherZeroEsqueda = False
        Me.EndProcurador.RegraValidação = Nothing
        Me.EndProcurador.RegraValidaçãoMensagem = Nothing
        Me.EndProcurador.Size = New System.Drawing.Size(363, 20)
        Me.EndProcurador.TabIndex = 7
        Me.EndProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EndProcurador.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nome"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeProcurador
        '
        Me.NomeProcurador.AceitaColarTexto = True
        Me.NomeProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NomeProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomeProcurador.CasasDecimais = 0
        Me.NomeProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeProcurador.CPObrigatorio = False
        Me.NomeProcurador.CPObrigatorioMsg = Nothing
        Me.NomeProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.NomeProcurador.FlatBorder = False
        Me.NomeProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.NomeProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeProcurador.HighlightBorderOnEnter = False
        Me.NomeProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeProcurador.Location = New System.Drawing.Point(135, 18)
        Me.NomeProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NomeProcurador.MaxLength = 50
        Me.NomeProcurador.Name = "NomeProcurador"
        Me.NomeProcurador.PreencherZeroEsqueda = False
        Me.NomeProcurador.RegraValidação = Nothing
        Me.NomeProcurador.RegraValidaçãoMensagem = Nothing
        Me.NomeProcurador.Size = New System.Drawing.Size(449, 20)
        Me.NomeProcurador.TabIndex = 1
        Me.NomeProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeProcurador.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cpf"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CpfProcurador
        '
        Me.CpfProcurador.AceitaColarTexto = True
        Me.CpfProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CpfProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CpfProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CpfProcurador.CasasDecimais = 0
        Me.CpfProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CpfProcurador.CPObrigatorio = False
        Me.CpfProcurador.CPObrigatorioMsg = Nothing
        Me.CpfProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CpfProcurador.FlatBorder = False
        Me.CpfProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CpfProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.CpfProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.CpfProcurador.HighlightBorderOnEnter = False
        Me.CpfProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CpfProcurador.Location = New System.Drawing.Point(135, 42)
        Me.CpfProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CpfProcurador.MaxLength = 14
        Me.CpfProcurador.Name = "CpfProcurador"
        Me.CpfProcurador.PreencherZeroEsqueda = False
        Me.CpfProcurador.RegraValidação = Nothing
        Me.CpfProcurador.RegraValidaçãoMensagem = Nothing
        Me.CpfProcurador.Size = New System.Drawing.Size(128, 20)
        Me.CpfProcurador.TabIndex = 3
        Me.CpfProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cpf
        Me.CpfProcurador.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(376, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Rg"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RgProcurador
        '
        Me.RgProcurador.AceitaColarTexto = True
        Me.RgProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RgProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.RgProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RgProcurador.CasasDecimais = 0
        Me.RgProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RgProcurador.CPObrigatorio = False
        Me.RgProcurador.CPObrigatorioMsg = Nothing
        Me.RgProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.RgProcurador.FlatBorder = False
        Me.RgProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.RgProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.RgProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.RgProcurador.HighlightBorderOnEnter = False
        Me.RgProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.RgProcurador.Location = New System.Drawing.Point(456, 42)
        Me.RgProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RgProcurador.MaxLength = 15
        Me.RgProcurador.Name = "RgProcurador"
        Me.RgProcurador.PreencherZeroEsqueda = False
        Me.RgProcurador.RegraValidação = Nothing
        Me.RgProcurador.RegraValidaçãoMensagem = Nothing
        Me.RgProcurador.Size = New System.Drawing.Size(128, 20)
        Me.RgProcurador.TabIndex = 5
        Me.RgProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.RgProcurador.ValorPadrao = Nothing
        '
        'NumeroEndProcurador
        '
        Me.NumeroEndProcurador.AceitaColarTexto = True
        Me.NumeroEndProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NumeroEndProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NumeroEndProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroEndProcurador.CasasDecimais = 0
        Me.NumeroEndProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroEndProcurador.CPObrigatorio = False
        Me.NumeroEndProcurador.CPObrigatorioMsg = Nothing
        Me.NumeroEndProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NumeroEndProcurador.FlatBorder = False
        Me.NumeroEndProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NumeroEndProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.NumeroEndProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroEndProcurador.HighlightBorderOnEnter = False
        Me.NumeroEndProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NumeroEndProcurador.Location = New System.Drawing.Point(529, 66)
        Me.NumeroEndProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumeroEndProcurador.MaxLength = 9
        Me.NumeroEndProcurador.Name = "NumeroEndProcurador"
        Me.NumeroEndProcurador.PreencherZeroEsqueda = False
        Me.NumeroEndProcurador.RegraValidação = Nothing
        Me.NumeroEndProcurador.RegraValidaçãoMensagem = Nothing
        Me.NumeroEndProcurador.Size = New System.Drawing.Size(55, 20)
        Me.NumeroEndProcurador.TabIndex = 9
        Me.NumeroEndProcurador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroEndProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroEndProcurador.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(376, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Estado Civil"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstadoCivilProcurador
        '
        Me.EstadoCivilProcurador.AceitaColarTexto = True
        Me.EstadoCivilProcurador.AutoCompleteCustomSource.AddRange(New String() {"Solteiro", "Casado"})
        Me.EstadoCivilProcurador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EstadoCivilProcurador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.EstadoCivilProcurador.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EstadoCivilProcurador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EstadoCivilProcurador.CasasDecimais = 0
        Me.EstadoCivilProcurador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstadoCivilProcurador.CPObrigatorio = False
        Me.EstadoCivilProcurador.CPObrigatorioMsg = Nothing
        Me.EstadoCivilProcurador.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EstadoCivilProcurador.FlatBorder = False
        Me.EstadoCivilProcurador.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EstadoCivilProcurador.FocusColor = System.Drawing.Color.MistyRose
        Me.EstadoCivilProcurador.FocusColorEnd = System.Drawing.Color.Empty
        Me.EstadoCivilProcurador.HighlightBorderOnEnter = False
        Me.EstadoCivilProcurador.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EstadoCivilProcurador.Location = New System.Drawing.Point(456, 138)
        Me.EstadoCivilProcurador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EstadoCivilProcurador.MaxLength = 15
        Me.EstadoCivilProcurador.Name = "EstadoCivilProcurador"
        Me.EstadoCivilProcurador.PreencherZeroEsqueda = False
        Me.EstadoCivilProcurador.RegraValidação = Nothing
        Me.EstadoCivilProcurador.RegraValidaçãoMensagem = Nothing
        Me.EstadoCivilProcurador.Size = New System.Drawing.Size(128, 20)
        Me.EstadoCivilProcurador.TabIndex = 19
        Me.EstadoCivilProcurador.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EstadoCivilProcurador.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(504, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Nº"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Salvar
        '
        Me.Salvar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salvar.Image = CType(resources.GetObject("Salvar.Image"), System.Drawing.Image)
        Me.Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salvar.Location = New System.Drawing.Point(356, 190)
        Me.Salvar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(111, 55)
        Me.Salvar.TabIndex = 20
        Me.Salvar.Text = "Salvar"
        Me.Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Salvar.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(473, 190)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(111, 55)
        Me.Fechar.TabIndex = 22
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'PrintProcuração
        '
        Me.PrintProcuração.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintProcuração.Image = CType(resources.GetObject("PrintProcuração.Image"), System.Drawing.Image)
        Me.PrintProcuração.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintProcuração.Location = New System.Drawing.Point(187, 190)
        Me.PrintProcuração.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrintProcuração.Name = "PrintProcuração"
        Me.PrintProcuração.Size = New System.Drawing.Size(163, 55)
        Me.PrintProcuração.TabIndex = 21
        Me.PrintProcuração.Text = "Imp. Procuração"
        Me.PrintProcuração.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintProcuração.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.PrintProcuração)
        Me.Fundo.Controls.Add(Me.NomeProcurador)
        Me.Fundo.Controls.Add(Me.Salvar)
        Me.Fundo.Controls.Add(Me.EndProcurador)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.BairroProcurador)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.EstadoCivilProcurador)
        Me.Fundo.Controls.Add(Me.CidadeProcurador)
        Me.Fundo.Controls.Add(Me.NumeroEndProcurador)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.CepProcurador)
        Me.Fundo.Controls.Add(Me.RgProcurador)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.UFProcurador)
        Me.Fundo.Controls.Add(Me.CpfProcurador)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(596, 257)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 23
        '
        'ClientesProcurador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClientesProcurador"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procuração - T246"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UFProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CepProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CidadeProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BairroProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EndProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NomeProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CpfProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RgProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NumeroEndProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EstadoCivilProcurador As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Salvar As System.Windows.Forms.Button
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents PrintProcuração As System.Windows.Forms.Button
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
