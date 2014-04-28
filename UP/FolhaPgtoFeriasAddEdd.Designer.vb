<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoFeriasAddEdd
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Periodo1 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Periodo2 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.DiasTotal = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.DiasGozo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.SalarioDif = New TexBoxFocusNet.TextBoxFocusNet
        Me.SalarioReg = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Variaveis = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label10 = New System.Windows.Forms.Label
        Me.ValorFerias = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label11 = New System.Windows.Forms.Label
        Me.ValorInss = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Pago = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fechar = New System.Windows.Forms.Button
        Me.Salvar = New System.Windows.Forms.Button
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet
        Me.Vale = New DevComponents.DotNetBar.PanelEx
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtVale = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorLiquido = New TexBoxFocusNet.TextBoxFocusNet
        Me.Vale.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Período Inicial"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Periodo1
        '
        Me.Periodo1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Periodo1.CasasDecimais = 0
        Me.Periodo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Periodo1.CPObrigatorio = False
        Me.Periodo1.CPObrigatorioMsg = Nothing
        Me.Periodo1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Periodo1.FocusColor = System.Drawing.Color.Empty
        Me.Periodo1.FocusColorEnd = System.Drawing.Color.Empty
        Me.Periodo1.Location = New System.Drawing.Point(109, 5)
        Me.Periodo1.MaxLength = 10
        Me.Periodo1.Name = "Periodo1"
        Me.Periodo1.RegraValidação = Nothing
        Me.Periodo1.RegraValidaçãoMensagem = Nothing
        Me.Periodo1.Size = New System.Drawing.Size(92, 20)
        Me.Periodo1.TabIndex = 0
        Me.Periodo1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Periodo1.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(244, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Período Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Periodo2
        '
        Me.Periodo2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Periodo2.CasasDecimais = 0
        Me.Periodo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Periodo2.CPObrigatorio = False
        Me.Periodo2.CPObrigatorioMsg = Nothing
        Me.Periodo2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Periodo2.FocusColor = System.Drawing.Color.Empty
        Me.Periodo2.FocusColorEnd = System.Drawing.Color.Empty
        Me.Periodo2.Location = New System.Drawing.Point(341, 5)
        Me.Periodo2.MaxLength = 10
        Me.Periodo2.Name = "Periodo2"
        Me.Periodo2.RegraValidação = Nothing
        Me.Periodo2.RegraValidaçãoMensagem = Nothing
        Me.Periodo2.Size = New System.Drawing.Size(92, 20)
        Me.Periodo2.TabIndex = 1
        Me.Periodo2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Periodo2.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dias Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiasTotal
        '
        Me.DiasTotal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DiasTotal.CasasDecimais = 0
        Me.DiasTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiasTotal.CPObrigatorio = False
        Me.DiasTotal.CPObrigatorioMsg = Nothing
        Me.DiasTotal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiasTotal.FocusColor = System.Drawing.Color.Empty
        Me.DiasTotal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiasTotal.Location = New System.Drawing.Point(109, 31)
        Me.DiasTotal.MaxLength = 8
        Me.DiasTotal.Name = "DiasTotal"
        Me.DiasTotal.RegraValidação = Nothing
        Me.DiasTotal.RegraValidaçãoMensagem = Nothing
        Me.DiasTotal.Size = New System.Drawing.Size(36, 20)
        Me.DiasTotal.TabIndex = 2
        Me.DiasTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DiasTotal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.DiasTotal.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(244, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dias Gozo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiasGozo
        '
        Me.DiasGozo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DiasGozo.CasasDecimais = 0
        Me.DiasGozo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiasGozo.CPObrigatorio = False
        Me.DiasGozo.CPObrigatorioMsg = Nothing
        Me.DiasGozo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiasGozo.FocusColor = System.Drawing.Color.Empty
        Me.DiasGozo.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiasGozo.Location = New System.Drawing.Point(341, 31)
        Me.DiasGozo.MaxLength = 8
        Me.DiasGozo.Name = "DiasGozo"
        Me.DiasGozo.RegraValidação = Nothing
        Me.DiasGozo.RegraValidaçãoMensagem = Nothing
        Me.DiasGozo.Size = New System.Drawing.Size(36, 20)
        Me.DiasGozo.TabIndex = 3
        Me.DiasGozo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DiasGozo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.DiasGozo.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(244, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Data Final"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Data Inicial"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(244, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Salário Dif."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalarioDif
        '
        Me.SalarioDif.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SalarioDif.CasasDecimais = 2
        Me.SalarioDif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SalarioDif.CPObrigatorio = False
        Me.SalarioDif.CPObrigatorioMsg = Nothing
        Me.SalarioDif.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SalarioDif.FocusColor = System.Drawing.Color.Empty
        Me.SalarioDif.FocusColorEnd = System.Drawing.Color.Empty
        Me.SalarioDif.Location = New System.Drawing.Point(341, 133)
        Me.SalarioDif.MaxLength = 10
        Me.SalarioDif.Name = "SalarioDif"
        Me.SalarioDif.RegraValidação = Nothing
        Me.SalarioDif.RegraValidaçãoMensagem = Nothing
        Me.SalarioDif.Size = New System.Drawing.Size(92, 20)
        Me.SalarioDif.TabIndex = 8
        Me.SalarioDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioDif.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioDif.ValorPadrao = Nothing
        '
        'SalarioReg
        '
        Me.SalarioReg.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SalarioReg.CasasDecimais = 2
        Me.SalarioReg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SalarioReg.CPObrigatorio = False
        Me.SalarioReg.CPObrigatorioMsg = Nothing
        Me.SalarioReg.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SalarioReg.FocusColor = System.Drawing.Color.Empty
        Me.SalarioReg.FocusColorEnd = System.Drawing.Color.Empty
        Me.SalarioReg.Location = New System.Drawing.Point(109, 133)
        Me.SalarioReg.MaxLength = 10
        Me.SalarioReg.Name = "SalarioReg"
        Me.SalarioReg.RegraValidação = Nothing
        Me.SalarioReg.RegraValidaçãoMensagem = Nothing
        Me.SalarioReg.Size = New System.Drawing.Size(92, 20)
        Me.SalarioReg.TabIndex = 6
        Me.SalarioReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioReg.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioReg.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Salário Registro"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Variáveis"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Variaveis
        '
        Me.Variaveis.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Variaveis.CasasDecimais = 2
        Me.Variaveis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Variaveis.CPObrigatorio = False
        Me.Variaveis.CPObrigatorioMsg = Nothing
        Me.Variaveis.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Variaveis.FocusColor = System.Drawing.Color.Empty
        Me.Variaveis.FocusColorEnd = System.Drawing.Color.Empty
        Me.Variaveis.Location = New System.Drawing.Point(109, 159)
        Me.Variaveis.MaxLength = 10
        Me.Variaveis.Name = "Variaveis"
        Me.Variaveis.RegraValidação = Nothing
        Me.Variaveis.RegraValidaçãoMensagem = Nothing
        Me.Variaveis.Size = New System.Drawing.Size(92, 20)
        Me.Variaveis.TabIndex = 7
        Me.Variaveis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Variaveis.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Variaveis.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(244, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Valor Férias"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorFerias
        '
        Me.ValorFerias.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorFerias.CasasDecimais = 2
        Me.ValorFerias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorFerias.CPObrigatorio = False
        Me.ValorFerias.CPObrigatorioMsg = Nothing
        Me.ValorFerias.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorFerias.FocusColor = System.Drawing.Color.Empty
        Me.ValorFerias.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorFerias.Location = New System.Drawing.Point(341, 160)
        Me.ValorFerias.MaxLength = 10
        Me.ValorFerias.Name = "ValorFerias"
        Me.ValorFerias.RegraValidação = Nothing
        Me.ValorFerias.RegraValidaçãoMensagem = Nothing
        Me.ValorFerias.Size = New System.Drawing.Size(92, 20)
        Me.ValorFerias.TabIndex = 9
        Me.ValorFerias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorFerias.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorFerias.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Valor Inss"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorInss
        '
        Me.ValorInss.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorInss.CasasDecimais = 2
        Me.ValorInss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorInss.CPObrigatorio = False
        Me.ValorInss.CPObrigatorioMsg = Nothing
        Me.ValorInss.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorInss.FocusColor = System.Drawing.Color.Empty
        Me.ValorInss.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorInss.Location = New System.Drawing.Point(109, 185)
        Me.ValorInss.MaxLength = 10
        Me.ValorInss.Name = "ValorInss"
        Me.ValorInss.RegraValidação = Nothing
        Me.ValorInss.RegraValidaçãoMensagem = Nothing
        Me.ValorInss.Size = New System.Drawing.Size(92, 20)
        Me.ValorInss.TabIndex = 11
        Me.ValorInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorInss.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorInss.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(-4, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(449, 3)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(-2, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(449, 3)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(12, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 20)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Pago"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pago
        '
        Me.Pago.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Pago.CasasDecimais = 0
        Me.Pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pago.CPObrigatorio = False
        Me.Pago.CPObrigatorioMsg = Nothing
        Me.Pago.Enabled = False
        Me.Pago.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Pago.FocusColor = System.Drawing.Color.Empty
        Me.Pago.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pago.Location = New System.Drawing.Point(109, 210)
        Me.Pago.MaxLength = 10
        Me.Pago.Name = "Pago"
        Me.Pago.RegraValidação = Nothing
        Me.Pago.RegraValidaçãoMensagem = Nothing
        Me.Pago.Size = New System.Drawing.Size(54, 20)
        Me.Pago.TabIndex = 12
        Me.Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Pago.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pago.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.Location = New System.Drawing.Point(341, 249)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(92, 29)
        Me.Fechar.TabIndex = 14
        Me.Fechar.Text = "Fechar"
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'Salvar
        '
        Me.Salvar.Location = New System.Drawing.Point(247, 249)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(92, 29)
        Me.Salvar.TabIndex = 13
        Me.Salvar.Text = "Salvar"
        Me.Salvar.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(3, 234)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(54, 20)
        Me.Id.TabIndex = 26
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'DataInicial
        '
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 0
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.Location = New System.Drawing.Point(109, 79)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(100, 20)
        Me.DataInicial.TabIndex = 4
        Me.DataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'DataFinal
        '
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.Location = New System.Drawing.Point(341, 78)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(92, 20)
        Me.DataFinal.TabIndex = 5
        Me.DataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Vale
        '
        Me.Vale.CanvasColor = System.Drawing.SystemColors.Control
        Me.Vale.Controls.Add(Me.Label2)
        Me.Vale.Controls.Add(Me.DataFinal)
        Me.Vale.Controls.Add(Me.Periodo1)
        Me.Vale.Controls.Add(Me.DataInicial)
        Me.Vale.Controls.Add(Me.Periodo2)
        Me.Vale.Controls.Add(Me.Id)
        Me.Vale.Controls.Add(Me.Label1)
        Me.Vale.Controls.Add(Me.Salvar)
        Me.Vale.Controls.Add(Me.DiasTotal)
        Me.Vale.Controls.Add(Me.Fechar)
        Me.Vale.Controls.Add(Me.Label3)
        Me.Vale.Controls.Add(Me.Label14)
        Me.Vale.Controls.Add(Me.DiasGozo)
        Me.Vale.Controls.Add(Me.Pago)
        Me.Vale.Controls.Add(Me.Label4)
        Me.Vale.Controls.Add(Me.Label13)
        Me.Vale.Controls.Add(Me.Label6)
        Me.Vale.Controls.Add(Me.Label12)
        Me.Vale.Controls.Add(Me.Label5)
        Me.Vale.Controls.Add(Me.Label11)
        Me.Vale.Controls.Add(Me.SalarioReg)
        Me.Vale.Controls.Add(Me.ValorInss)
        Me.Vale.Controls.Add(Me.Label7)
        Me.Vale.Controls.Add(Me.Label16)
        Me.Vale.Controls.Add(Me.Label15)
        Me.Vale.Controls.Add(Me.Label10)
        Me.Vale.Controls.Add(Me.SalarioDif)
        Me.Vale.Controls.Add(Me.txtVale)
        Me.Vale.Controls.Add(Me.ValorLiquido)
        Me.Vale.Controls.Add(Me.ValorFerias)
        Me.Vale.Controls.Add(Me.Label8)
        Me.Vale.Controls.Add(Me.Label9)
        Me.Vale.Controls.Add(Me.Variaveis)
        Me.Vale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vale.Location = New System.Drawing.Point(0, 0)
        Me.Vale.Name = "Vale"
        Me.Vale.Size = New System.Drawing.Size(444, 290)
        Me.Vale.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Vale.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.Vale.Style.BackColor2.Color = System.Drawing.Color.LightSkyBlue
        Me.Vale.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Vale.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Vale.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Vale.Style.GradientAngle = 90
        Me.Vale.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(247, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 20)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Vale"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(243, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 20)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Valor Líquido"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVale
        '
        Me.txtVale.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtVale.CasasDecimais = 2
        Me.txtVale.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVale.CPObrigatorio = False
        Me.txtVale.CPObrigatorioMsg = Nothing
        Me.txtVale.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtVale.FocusColor = System.Drawing.Color.Empty
        Me.txtVale.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtVale.Location = New System.Drawing.Point(341, 189)
        Me.txtVale.MaxLength = 10
        Me.txtVale.Name = "txtVale"
        Me.txtVale.RegraValidação = Nothing
        Me.txtVale.RegraValidaçãoMensagem = Nothing
        Me.txtVale.Size = New System.Drawing.Size(92, 20)
        Me.txtVale.TabIndex = 10
        Me.txtVale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVale.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.txtVale.ValorPadrao = Nothing
        '
        'ValorLiquido
        '
        Me.ValorLiquido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorLiquido.CasasDecimais = 2
        Me.ValorLiquido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorLiquido.CPObrigatorio = False
        Me.ValorLiquido.CPObrigatorioMsg = Nothing
        Me.ValorLiquido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorLiquido.FocusColor = System.Drawing.Color.Empty
        Me.ValorLiquido.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorLiquido.Location = New System.Drawing.Point(341, 215)
        Me.ValorLiquido.MaxLength = 10
        Me.ValorLiquido.Name = "ValorLiquido"
        Me.ValorLiquido.RegraValidação = Nothing
        Me.ValorLiquido.RegraValidaçãoMensagem = Nothing
        Me.ValorLiquido.Size = New System.Drawing.Size(92, 20)
        Me.ValorLiquido.TabIndex = 11
        Me.ValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorLiquido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorLiquido.ValorPadrao = Nothing
        '
        'FolhaPgtoFeriasAddEdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(444, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Vale)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoFeriasAddEdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Período Inicial"
        Me.Vale.ResumeLayout(False)
        Me.Vale.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Periodo1 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Periodo2 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DiasTotal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DiasGozo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SalarioDif As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents SalarioReg As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Variaveis As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ValorFerias As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ValorInss As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Pago As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Salvar As System.Windows.Forms.Button
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Vale As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ValorLiquido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtVale As TexBoxFocusNet.TextBoxFocusNet
End Class
