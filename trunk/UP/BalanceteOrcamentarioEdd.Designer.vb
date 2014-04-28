<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceteOrcamentarioEdd
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.Label1 = New System.Windows.Forms.Label
        Me.DezPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label13 = New System.Windows.Forms.Label
        Me.OutPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label12 = New System.Windows.Forms.Label
        Me.AgoPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label11 = New System.Windows.Forms.Label
        Me.JunPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label10 = New System.Windows.Forms.Label
        Me.AbrPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.FevPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label8 = New System.Windows.Forms.Label
        Me.NovPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.SetPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.JulPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.MaiPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.MarPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.JanPrevisto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.ControlaDespesas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX
        Me.Conta = New TexBoxFocusNet.TextBoxFocusNet
        Me.Ano = New TexBoxFocusNet.TextBoxFocusNet
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.DezPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label13)
        Me.PanelEx1.Controls.Add(Me.OutPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.AgoPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.JunPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.AbrPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.FevPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.NovPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.SetPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.JulPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.MaiPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.MarPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.JanPrevisto)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.ControlaDespesas)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.Conta)
        Me.PanelEx1.Controls.Add(Me.Ano)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(632, 253)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Favor Entrar com os Valores previsto para cada Mês"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DezPrevisto
        '
        Me.DezPrevisto.AceitaColarTexto = True
        Me.DezPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DezPrevisto.CasasDecimais = 2
        Me.DezPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DezPrevisto.CPObrigatorio = False
        Me.DezPrevisto.CPObrigatorioMsg = Nothing
        Me.DezPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DezPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.DezPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.DezPrevisto.Location = New System.Drawing.Point(469, 182)
        Me.DezPrevisto.MaxLength = 10
        Me.DezPrevisto.Name = "DezPrevisto"
        Me.DezPrevisto.PreencherZeroEsqueda = False
        Me.DezPrevisto.RegraValidação = Nothing
        Me.DezPrevisto.RegraValidaçãoMensagem = Nothing
        Me.DezPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.DezPrevisto.TabIndex = 24
        Me.DezPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DezPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.DezPrevisto.ValorPadrao = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(325, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 19)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Dezembro"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OutPrevisto
        '
        Me.OutPrevisto.AceitaColarTexto = True
        Me.OutPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.OutPrevisto.CasasDecimais = 2
        Me.OutPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OutPrevisto.CPObrigatorio = False
        Me.OutPrevisto.CPObrigatorioMsg = Nothing
        Me.OutPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OutPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.OutPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.OutPrevisto.Location = New System.Drawing.Point(469, 153)
        Me.OutPrevisto.MaxLength = 10
        Me.OutPrevisto.Name = "OutPrevisto"
        Me.OutPrevisto.PreencherZeroEsqueda = False
        Me.OutPrevisto.RegraValidação = Nothing
        Me.OutPrevisto.RegraValidaçãoMensagem = Nothing
        Me.OutPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.OutPrevisto.TabIndex = 20
        Me.OutPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OutPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.OutPrevisto.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(325, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 19)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Outubro"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AgoPrevisto
        '
        Me.AgoPrevisto.AceitaColarTexto = True
        Me.AgoPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AgoPrevisto.CasasDecimais = 2
        Me.AgoPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AgoPrevisto.CPObrigatorio = False
        Me.AgoPrevisto.CPObrigatorioMsg = Nothing
        Me.AgoPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AgoPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.AgoPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.AgoPrevisto.Location = New System.Drawing.Point(469, 124)
        Me.AgoPrevisto.MaxLength = 10
        Me.AgoPrevisto.Name = "AgoPrevisto"
        Me.AgoPrevisto.PreencherZeroEsqueda = False
        Me.AgoPrevisto.RegraValidação = Nothing
        Me.AgoPrevisto.RegraValidaçãoMensagem = Nothing
        Me.AgoPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.AgoPrevisto.TabIndex = 16
        Me.AgoPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AgoPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.AgoPrevisto.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(325, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 19)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Agosto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JunPrevisto
        '
        Me.JunPrevisto.AceitaColarTexto = True
        Me.JunPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.JunPrevisto.CasasDecimais = 2
        Me.JunPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.JunPrevisto.CPObrigatorio = False
        Me.JunPrevisto.CPObrigatorioMsg = Nothing
        Me.JunPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.JunPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.JunPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.JunPrevisto.Location = New System.Drawing.Point(469, 95)
        Me.JunPrevisto.MaxLength = 10
        Me.JunPrevisto.Name = "JunPrevisto"
        Me.JunPrevisto.PreencherZeroEsqueda = False
        Me.JunPrevisto.RegraValidação = Nothing
        Me.JunPrevisto.RegraValidaçãoMensagem = Nothing
        Me.JunPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.JunPrevisto.TabIndex = 12
        Me.JunPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.JunPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.JunPrevisto.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(325, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Junho"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbrPrevisto
        '
        Me.AbrPrevisto.AceitaColarTexto = True
        Me.AbrPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AbrPrevisto.CasasDecimais = 2
        Me.AbrPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AbrPrevisto.CPObrigatorio = False
        Me.AbrPrevisto.CPObrigatorioMsg = Nothing
        Me.AbrPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AbrPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.AbrPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.AbrPrevisto.Location = New System.Drawing.Point(469, 66)
        Me.AbrPrevisto.MaxLength = 10
        Me.AbrPrevisto.Name = "AbrPrevisto"
        Me.AbrPrevisto.PreencherZeroEsqueda = False
        Me.AbrPrevisto.RegraValidação = Nothing
        Me.AbrPrevisto.RegraValidaçãoMensagem = Nothing
        Me.AbrPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.AbrPrevisto.TabIndex = 8
        Me.AbrPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AbrPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.AbrPrevisto.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(325, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Abril"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FevPrevisto
        '
        Me.FevPrevisto.AceitaColarTexto = True
        Me.FevPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FevPrevisto.CasasDecimais = 2
        Me.FevPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FevPrevisto.CPObrigatorio = False
        Me.FevPrevisto.CPObrigatorioMsg = Nothing
        Me.FevPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FevPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.FevPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.FevPrevisto.Location = New System.Drawing.Point(469, 37)
        Me.FevPrevisto.MaxLength = 10
        Me.FevPrevisto.Name = "FevPrevisto"
        Me.FevPrevisto.PreencherZeroEsqueda = False
        Me.FevPrevisto.RegraValidação = Nothing
        Me.FevPrevisto.RegraValidaçãoMensagem = Nothing
        Me.FevPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.FevPrevisto.TabIndex = 4
        Me.FevPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FevPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.FevPrevisto.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(325, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fevereiro"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NovPrevisto
        '
        Me.NovPrevisto.AceitaColarTexto = True
        Me.NovPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NovPrevisto.CasasDecimais = 2
        Me.NovPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NovPrevisto.CPObrigatorio = False
        Me.NovPrevisto.CPObrigatorioMsg = Nothing
        Me.NovPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NovPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.NovPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.NovPrevisto.Location = New System.Drawing.Point(154, 182)
        Me.NovPrevisto.MaxLength = 10
        Me.NovPrevisto.Name = "NovPrevisto"
        Me.NovPrevisto.PreencherZeroEsqueda = False
        Me.NovPrevisto.RegraValidação = Nothing
        Me.NovPrevisto.RegraValidaçãoMensagem = Nothing
        Me.NovPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.NovPrevisto.TabIndex = 23
        Me.NovPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NovPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.NovPrevisto.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(10, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Novenbro"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SetPrevisto
        '
        Me.SetPrevisto.AceitaColarTexto = True
        Me.SetPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SetPrevisto.CasasDecimais = 2
        Me.SetPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SetPrevisto.CPObrigatorio = False
        Me.SetPrevisto.CPObrigatorioMsg = Nothing
        Me.SetPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SetPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.SetPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.SetPrevisto.Location = New System.Drawing.Point(154, 153)
        Me.SetPrevisto.MaxLength = 10
        Me.SetPrevisto.Name = "SetPrevisto"
        Me.SetPrevisto.PreencherZeroEsqueda = False
        Me.SetPrevisto.RegraValidação = Nothing
        Me.SetPrevisto.RegraValidaçãoMensagem = Nothing
        Me.SetPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.SetPrevisto.TabIndex = 19
        Me.SetPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SetPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SetPrevisto.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(10, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Setembro"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JulPrevisto
        '
        Me.JulPrevisto.AceitaColarTexto = True
        Me.JulPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.JulPrevisto.CasasDecimais = 2
        Me.JulPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.JulPrevisto.CPObrigatorio = False
        Me.JulPrevisto.CPObrigatorioMsg = Nothing
        Me.JulPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.JulPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.JulPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.JulPrevisto.Location = New System.Drawing.Point(154, 124)
        Me.JulPrevisto.MaxLength = 10
        Me.JulPrevisto.Name = "JulPrevisto"
        Me.JulPrevisto.PreencherZeroEsqueda = False
        Me.JulPrevisto.RegraValidação = Nothing
        Me.JulPrevisto.RegraValidaçãoMensagem = Nothing
        Me.JulPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.JulPrevisto.TabIndex = 15
        Me.JulPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.JulPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.JulPrevisto.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(10, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Julho"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaiPrevisto
        '
        Me.MaiPrevisto.AceitaColarTexto = True
        Me.MaiPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.MaiPrevisto.CasasDecimais = 2
        Me.MaiPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MaiPrevisto.CPObrigatorio = False
        Me.MaiPrevisto.CPObrigatorioMsg = Nothing
        Me.MaiPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.MaiPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.MaiPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.MaiPrevisto.Location = New System.Drawing.Point(154, 95)
        Me.MaiPrevisto.MaxLength = 10
        Me.MaiPrevisto.Name = "MaiPrevisto"
        Me.MaiPrevisto.PreencherZeroEsqueda = False
        Me.MaiPrevisto.RegraValidação = Nothing
        Me.MaiPrevisto.RegraValidaçãoMensagem = Nothing
        Me.MaiPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.MaiPrevisto.TabIndex = 11
        Me.MaiPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaiPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.MaiPrevisto.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(10, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Maio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MarPrevisto
        '
        Me.MarPrevisto.AceitaColarTexto = True
        Me.MarPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.MarPrevisto.CasasDecimais = 2
        Me.MarPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MarPrevisto.CPObrigatorio = False
        Me.MarPrevisto.CPObrigatorioMsg = Nothing
        Me.MarPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.MarPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.MarPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.MarPrevisto.Location = New System.Drawing.Point(154, 66)
        Me.MarPrevisto.MaxLength = 10
        Me.MarPrevisto.Name = "MarPrevisto"
        Me.MarPrevisto.PreencherZeroEsqueda = False
        Me.MarPrevisto.RegraValidação = Nothing
        Me.MarPrevisto.RegraValidaçãoMensagem = Nothing
        Me.MarPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.MarPrevisto.TabIndex = 7
        Me.MarPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MarPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.MarPrevisto.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(10, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Março"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JanPrevisto
        '
        Me.JanPrevisto.AceitaColarTexto = True
        Me.JanPrevisto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.JanPrevisto.CasasDecimais = 2
        Me.JanPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.JanPrevisto.CPObrigatorio = False
        Me.JanPrevisto.CPObrigatorioMsg = Nothing
        Me.JanPrevisto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.JanPrevisto.FocusColor = System.Drawing.Color.MistyRose
        Me.JanPrevisto.FocusColorEnd = System.Drawing.Color.Empty
        Me.JanPrevisto.Location = New System.Drawing.Point(154, 37)
        Me.JanPrevisto.MaxLength = 10
        Me.JanPrevisto.Name = "JanPrevisto"
        Me.JanPrevisto.PreencherZeroEsqueda = False
        Me.JanPrevisto.RegraValidação = Nothing
        Me.JanPrevisto.RegraValidaçãoMensagem = Nothing
        Me.JanPrevisto.Size = New System.Drawing.Size(147, 23)
        Me.JanPrevisto.TabIndex = 3
        Me.JanPrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.JanPrevisto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.JanPrevisto.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Janeiro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ControlaDespesas
        '
        '
        '
        '
        Me.ControlaDespesas.BackgroundStyle.Class = ""
        Me.ControlaDespesas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ControlaDespesas.Location = New System.Drawing.Point(160, 222)
        Me.ControlaDespesas.Name = "ControlaDespesas"
        Me.ControlaDespesas.Size = New System.Drawing.Size(132, 23)
        Me.ControlaDespesas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ControlaDespesas.TabIndex = 27
        Me.ControlaDespesas.Text = "Controla Despesas"
        Me.ControlaDespesas.Visible = False
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(474, 222)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(68, 23)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 28
        Me.btSalvar.Text = "Salvar"
        '
        'Conta
        '
        Me.Conta.AceitaColarTexto = True
        Me.Conta.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta.CasasDecimais = 0
        Me.Conta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Conta.CPObrigatorio = False
        Me.Conta.CPObrigatorioMsg = Nothing
        Me.Conta.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta.FocusColor = System.Drawing.Color.MistyRose
        Me.Conta.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta.Location = New System.Drawing.Point(22, 222)
        Me.Conta.Name = "Conta"
        Me.Conta.PreencherZeroEsqueda = False
        Me.Conta.RegraValidação = Nothing
        Me.Conta.RegraValidaçãoMensagem = Nothing
        Me.Conta.Size = New System.Drawing.Size(69, 23)
        Me.Conta.TabIndex = 25
        Me.Conta.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta.ValorPadrao = Nothing
        Me.Conta.Visible = False
        '
        'Ano
        '
        Me.Ano.AceitaColarTexto = True
        Me.Ano.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ano.CasasDecimais = 0
        Me.Ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ano.CPObrigatorio = False
        Me.Ano.CPObrigatorioMsg = Nothing
        Me.Ano.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ano.FocusColor = System.Drawing.Color.MistyRose
        Me.Ano.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ano.Location = New System.Drawing.Point(97, 222)
        Me.Ano.Name = "Ano"
        Me.Ano.PreencherZeroEsqueda = False
        Me.Ano.RegraValidação = Nothing
        Me.Ano.RegraValidaçãoMensagem = Nothing
        Me.Ano.Size = New System.Drawing.Size(57, 23)
        Me.Ano.TabIndex = 26
        Me.Ano.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ano.ValorPadrao = Nothing
        Me.Ano.Visible = False
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(548, 222)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(68, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 29
        Me.btFechar.Text = "Fechar"
        '
        'BalanceteOrcamentarioEdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 253)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BalanceteOrcamentarioEdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edição de Balancete Orçamentário"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Conta As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Ano As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlaDespesas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents DezPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents OutPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AgoPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents JunPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AbrPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FevPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NovPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SetPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents JulPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaiPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MarPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents JanPrevisto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
