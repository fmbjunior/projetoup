<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoDecimoTerceiroADD
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
        Me.Meses = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label8 = New System.Windows.Forms.Label
        Me.SalarioRegistro = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.SalarioDif = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.OutrosVlrs = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Total = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.VlrDecimo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.Parcela2 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.Parcela1 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.Inss = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.Funcionario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label10 = New System.Windows.Forms.Label
        Me.FuncionarioDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fechar = New DevComponents.DotNetBar.ButtonX
        Me.Novo = New DevComponents.DotNetBar.ButtonX
        Me.Salvar = New DevComponents.DotNetBar.ButtonX
        Me.Excluir = New DevComponents.DotNetBar.ButtonX
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Desc2Pa = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label11 = New System.Windows.Forms.Label
        Me.Desc1Pa = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label12 = New System.Windows.Forms.Label
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Meses
        '
        Me.Meses.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Meses.CasasDecimais = 0
        Me.Meses.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Meses.CPObrigatorio = False
        Me.Meses.CPObrigatorioMsg = Nothing
        Me.Meses.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Meses.FocusColor = System.Drawing.Color.Empty
        Me.Meses.FocusColorEnd = System.Drawing.Color.Empty
        Me.Meses.Location = New System.Drawing.Point(13, 80)
        Me.Meses.MaxLength = 30
        Me.Meses.Name = "Meses"
        Me.Meses.RegraValidação = Nothing
        Me.Meses.RegraValidaçãoMensagem = Nothing
        Me.Meses.Size = New System.Drawing.Size(65, 20)
        Me.Meses.TabIndex = 8
        Me.Meses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Meses.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Meses.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(13, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Referência"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalarioRegistro
        '
        Me.SalarioRegistro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SalarioRegistro.CasasDecimais = 2
        Me.SalarioRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SalarioRegistro.CPObrigatorio = False
        Me.SalarioRegistro.CPObrigatorioMsg = Nothing
        Me.SalarioRegistro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SalarioRegistro.FocusColor = System.Drawing.Color.Empty
        Me.SalarioRegistro.FocusColorEnd = System.Drawing.Color.Empty
        Me.SalarioRegistro.Location = New System.Drawing.Point(84, 80)
        Me.SalarioRegistro.MaxLength = 10
        Me.SalarioRegistro.Name = "SalarioRegistro"
        Me.SalarioRegistro.RegraValidação = Nothing
        Me.SalarioRegistro.RegraValidaçãoMensagem = Nothing
        Me.SalarioRegistro.Size = New System.Drawing.Size(82, 20)
        Me.SalarioRegistro.TabIndex = 9
        Me.SalarioRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioRegistro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioRegistro.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(84, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sal. Reg"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalarioDif
        '
        Me.SalarioDif.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SalarioDif.CasasDecimais = 2
        Me.SalarioDif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SalarioDif.CPObrigatorio = False
        Me.SalarioDif.CPObrigatorioMsg = Nothing
        Me.SalarioDif.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SalarioDif.FocusColor = System.Drawing.Color.Empty
        Me.SalarioDif.FocusColorEnd = System.Drawing.Color.Empty
        Me.SalarioDif.Location = New System.Drawing.Point(172, 80)
        Me.SalarioDif.MaxLength = 10
        Me.SalarioDif.Name = "SalarioDif"
        Me.SalarioDif.RegraValidação = Nothing
        Me.SalarioDif.RegraValidaçãoMensagem = Nothing
        Me.SalarioDif.Size = New System.Drawing.Size(82, 20)
        Me.SalarioDif.TabIndex = 10
        Me.SalarioDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioDif.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioDif.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(172, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sal. Dif"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OutrosVlrs
        '
        Me.OutrosVlrs.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.OutrosVlrs.CasasDecimais = 2
        Me.OutrosVlrs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OutrosVlrs.CPObrigatorio = False
        Me.OutrosVlrs.CPObrigatorioMsg = Nothing
        Me.OutrosVlrs.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OutrosVlrs.FocusColor = System.Drawing.Color.Empty
        Me.OutrosVlrs.FocusColorEnd = System.Drawing.Color.Empty
        Me.OutrosVlrs.Location = New System.Drawing.Point(260, 80)
        Me.OutrosVlrs.MaxLength = 10
        Me.OutrosVlrs.Name = "OutrosVlrs"
        Me.OutrosVlrs.RegraValidação = Nothing
        Me.OutrosVlrs.RegraValidaçãoMensagem = Nothing
        Me.OutrosVlrs.Size = New System.Drawing.Size(82, 20)
        Me.OutrosVlrs.TabIndex = 11
        Me.OutrosVlrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OutrosVlrs.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.OutrosVlrs.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(260, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Vlr Outros"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Total
        '
        Me.Total.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Total.CasasDecimais = 2
        Me.Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Total.CPObrigatorio = False
        Me.Total.CPObrigatorioMsg = Nothing
        Me.Total.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Total.FocusColor = System.Drawing.Color.Empty
        Me.Total.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total.Location = New System.Drawing.Point(348, 80)
        Me.Total.MaxLength = 10
        Me.Total.Name = "Total"
        Me.Total.RegraValidação = Nothing
        Me.Total.RegraValidaçãoMensagem = Nothing
        Me.Total.Size = New System.Drawing.Size(82, 20)
        Me.Total.TabIndex = 12
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Total.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(348, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VlrDecimo
        '
        Me.VlrDecimo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.VlrDecimo.CasasDecimais = 2
        Me.VlrDecimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VlrDecimo.CPObrigatorio = False
        Me.VlrDecimo.CPObrigatorioMsg = Nothing
        Me.VlrDecimo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VlrDecimo.FocusColor = System.Drawing.Color.Empty
        Me.VlrDecimo.FocusColorEnd = System.Drawing.Color.Empty
        Me.VlrDecimo.Location = New System.Drawing.Point(81, 135)
        Me.VlrDecimo.MaxLength = 10
        Me.VlrDecimo.Name = "VlrDecimo"
        Me.VlrDecimo.RegraValidação = Nothing
        Me.VlrDecimo.RegraValidaçãoMensagem = Nothing
        Me.VlrDecimo.Size = New System.Drawing.Size(82, 20)
        Me.VlrDecimo.TabIndex = 15
        Me.VlrDecimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrDecimo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.VlrDecimo.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(81, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Vlr Decimo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Parcela2
        '
        Me.Parcela2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Parcela2.CasasDecimais = 2
        Me.Parcela2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Parcela2.CPObrigatorio = False
        Me.Parcela2.CPObrigatorioMsg = Nothing
        Me.Parcela2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Parcela2.FocusColor = System.Drawing.Color.Empty
        Me.Parcela2.FocusColorEnd = System.Drawing.Color.Empty
        Me.Parcela2.Location = New System.Drawing.Point(168, 234)
        Me.Parcela2.MaxLength = 10
        Me.Parcela2.Name = "Parcela2"
        Me.Parcela2.RegraValidação = Nothing
        Me.Parcela2.RegraValidaçãoMensagem = Nothing
        Me.Parcela2.Size = New System.Drawing.Size(82, 20)
        Me.Parcela2.TabIndex = 24
        Me.Parcela2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Parcela2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Parcela2.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(168, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "2. Parcela"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Parcela1
        '
        Me.Parcela1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Parcela1.CasasDecimais = 2
        Me.Parcela1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Parcela1.CPObrigatorio = False
        Me.Parcela1.CPObrigatorioMsg = Nothing
        Me.Parcela1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Parcela1.FocusColor = System.Drawing.Color.Empty
        Me.Parcela1.FocusColorEnd = System.Drawing.Color.Empty
        Me.Parcela1.Location = New System.Drawing.Point(169, 182)
        Me.Parcela1.MaxLength = 10
        Me.Parcela1.Name = "Parcela1"
        Me.Parcela1.RegraValidação = Nothing
        Me.Parcela1.RegraValidaçãoMensagem = Nothing
        Me.Parcela1.Size = New System.Drawing.Size(82, 20)
        Me.Parcela1.TabIndex = 20
        Me.Parcela1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Parcela1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Parcela1.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(169, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "1. Parcela"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Inss
        '
        Me.Inss.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Inss.CasasDecimais = 2
        Me.Inss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Inss.CPObrigatorio = False
        Me.Inss.CPObrigatorioMsg = Nothing
        Me.Inss.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Inss.FocusColor = System.Drawing.Color.Empty
        Me.Inss.FocusColorEnd = System.Drawing.Color.Empty
        Me.Inss.Location = New System.Drawing.Point(169, 135)
        Me.Inss.MaxLength = 10
        Me.Inss.Name = "Inss"
        Me.Inss.RegraValidação = Nothing
        Me.Inss.RegraValidaçãoMensagem = Nothing
        Me.Inss.Size = New System.Drawing.Size(82, 20)
        Me.Inss.TabIndex = 16
        Me.Inss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Inss.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Inss.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(169, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Vlr Inss"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Funcionario
        '
        Me.Funcionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Funcionario.CasasDecimais = 0
        Me.Funcionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Funcionario.CPObrigatorio = False
        Me.Funcionario.CPObrigatorioMsg = Nothing
        Me.Funcionario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Funcionario.FocusColor = System.Drawing.Color.Empty
        Me.Funcionario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Funcionario.Location = New System.Drawing.Point(12, 34)
        Me.Funcionario.MaxLength = 30
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.RegraValidação = Nothing
        Me.Funcionario.RegraValidaçãoMensagem = Nothing
        Me.Funcionario.Size = New System.Drawing.Size(65, 20)
        Me.Funcionario.TabIndex = 1
        Me.Funcionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Funcionario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Funcionario.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(12, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Funcionário"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FuncionarioDesc
        '
        Me.FuncionarioDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.FuncionarioDesc.CasasDecimais = 0
        Me.FuncionarioDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FuncionarioDesc.CPObrigatorio = False
        Me.FuncionarioDesc.CPObrigatorioMsg = Nothing
        Me.FuncionarioDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FuncionarioDesc.FocusColor = System.Drawing.Color.Empty
        Me.FuncionarioDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FuncionarioDesc.Location = New System.Drawing.Point(87, 34)
        Me.FuncionarioDesc.MaxLength = 30
        Me.FuncionarioDesc.Name = "FuncionarioDesc"
        Me.FuncionarioDesc.RegraValidação = Nothing
        Me.FuncionarioDesc.RegraValidaçãoMensagem = Nothing
        Me.FuncionarioDesc.Size = New System.Drawing.Size(343, 20)
        Me.FuncionarioDesc.TabIndex = 2
        Me.FuncionarioDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncionarioDesc.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(355, 225)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(75, 29)
        Me.Fechar.TabIndex = 27
        Me.Fechar.Text = "Fechar"
        '
        'Novo
        '
        Me.Novo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Novo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Novo.Location = New System.Drawing.Point(355, 190)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(75, 29)
        Me.Novo.TabIndex = 26
        Me.Novo.Text = "Novo"
        '
        'Salvar
        '
        Me.Salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Salvar.Location = New System.Drawing.Point(355, 155)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(75, 29)
        Me.Salvar.TabIndex = 25
        Me.Salvar.Text = "Salvar"
        '
        'Excluir
        '
        Me.Excluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Excluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Excluir.Location = New System.Drawing.Point(355, 120)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Size = New System.Drawing.Size(75, 29)
        Me.Excluir.TabIndex = 28
        Me.Excluir.Text = "Excluir"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Desc2Pa)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.Desc1Pa)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.Excluir)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Salvar)
        Me.Fundo.Controls.Add(Me.Meses)
        Me.Fundo.Controls.Add(Me.Novo)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.SalarioRegistro)
        Me.Fundo.Controls.Add(Me.FuncionarioDesc)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Funcionario)
        Me.Fundo.Controls.Add(Me.SalarioDif)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Parcela2)
        Me.Fundo.Controls.Add(Me.OutrosVlrs)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Parcela1)
        Me.Fundo.Controls.Add(Me.Total)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Inss)
        Me.Fundo.Controls.Add(Me.VlrDecimo)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(442, 267)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.LightSkyBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Desc2Pa
        '
        Me.Desc2Pa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Desc2Pa.CasasDecimais = 2
        Me.Desc2Pa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Desc2Pa.CPObrigatorio = False
        Me.Desc2Pa.CPObrigatorioMsg = Nothing
        Me.Desc2Pa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Desc2Pa.FocusColor = System.Drawing.Color.Empty
        Me.Desc2Pa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desc2Pa.Location = New System.Drawing.Point(80, 234)
        Me.Desc2Pa.MaxLength = 10
        Me.Desc2Pa.Name = "Desc2Pa"
        Me.Desc2Pa.RegraValidação = Nothing
        Me.Desc2Pa.RegraValidaçãoMensagem = Nothing
        Me.Desc2Pa.Size = New System.Drawing.Size(82, 20)
        Me.Desc2Pa.TabIndex = 23
        Me.Desc2Pa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Desc2Pa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Desc2Pa.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(80, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "D.2. Parcela"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Desc1Pa
        '
        Me.Desc1Pa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Desc1Pa.CasasDecimais = 2
        Me.Desc1Pa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Desc1Pa.CPObrigatorio = False
        Me.Desc1Pa.CPObrigatorioMsg = Nothing
        Me.Desc1Pa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Desc1Pa.FocusColor = System.Drawing.Color.Empty
        Me.Desc1Pa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desc1Pa.Location = New System.Drawing.Point(80, 182)
        Me.Desc1Pa.MaxLength = 10
        Me.Desc1Pa.Name = "Desc1Pa"
        Me.Desc1Pa.RegraValidação = Nothing
        Me.Desc1Pa.RegraValidaçãoMensagem = Nothing
        Me.Desc1Pa.Size = New System.Drawing.Size(82, 20)
        Me.Desc1Pa.TabIndex = 19
        Me.Desc1Pa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Desc1Pa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Desc1Pa.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(80, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "D.1. Parcela"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FolhaPgtoDecimoTerceiroADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoDecimoTerceiroADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Décimo Terceiro "
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Meses As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SalarioRegistro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalarioDif As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OutrosVlrs As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Total As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents VlrDecimo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Parcela2 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Parcela1 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Inss As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Funcionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FuncionarioDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Novo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Salvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Excluir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Desc2Pa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Desc1Pa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
