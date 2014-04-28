<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaixaEditaItemLancCtb
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
        Me.Reduzida = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Historico = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.ValorLancamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Credito = New System.Windows.Forms.RadioButton
        Me.Debito = New System.Windows.Forms.RadioButton
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColumnHeader0 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet
        Me.btAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.PlanoContas = New TexBoxFocusNet.TextBoxFocusNet
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.ReduzidaDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.SerLancado = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.SaldoDebito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label8 = New System.Windows.Forms.Label
        Me.SaldoCredito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.SaldoDiferenca = New TexBoxFocusNet.TextBoxFocusNet
        Me.btSalvarDados = New DevComponents.DotNetBar.ButtonX
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.btNovo = New DevComponents.DotNetBar.ButtonX
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.btExcluir = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Conta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Reduzida
        '
        Me.Reduzida.AceitaColarTexto = True
        Me.Reduzida.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Reduzida.CasasDecimais = 0
        Me.Reduzida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Reduzida.CPObrigatorio = False
        Me.Reduzida.CPObrigatorioMsg = Nothing
        Me.Reduzida.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Reduzida.FocusColor = System.Drawing.Color.Empty
        Me.Reduzida.FocusColorEnd = System.Drawing.Color.Empty
        Me.Reduzida.Location = New System.Drawing.Point(110, 12)
        Me.Reduzida.MaxLength = 6
        Me.Reduzida.Name = "Reduzida"
        Me.Reduzida.RegraValidação = Nothing
        Me.Reduzida.RegraValidaçãoMensagem = Nothing
        Me.Reduzida.Size = New System.Drawing.Size(83, 20)
        Me.Reduzida.TabIndex = 1
        Me.Reduzida.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Reduzida.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Histórico"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Historico
        '
        Me.Historico.AceitaColarTexto = True
        Me.Historico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Historico.CasasDecimais = 0
        Me.Historico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Historico.CPObrigatorio = False
        Me.Historico.CPObrigatorioMsg = Nothing
        Me.Historico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Historico.FocusColor = System.Drawing.Color.Empty
        Me.Historico.FocusColorEnd = System.Drawing.Color.Empty
        Me.Historico.Location = New System.Drawing.Point(110, 38)
        Me.Historico.MaxLength = 300
        Me.Historico.Name = "Historico"
        Me.Historico.RegraValidação = Nothing
        Me.Historico.RegraValidaçãoMensagem = Nothing
        Me.Historico.Size = New System.Drawing.Size(671, 20)
        Me.Historico.TabIndex = 5
        Me.Historico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Historico.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(216, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorLancamento
        '
        Me.ValorLancamento.AceitaColarTexto = True
        Me.ValorLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorLancamento.CasasDecimais = 2
        Me.ValorLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorLancamento.CPObrigatorio = False
        Me.ValorLancamento.CPObrigatorioMsg = Nothing
        Me.ValorLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorLancamento.FocusColor = System.Drawing.Color.Empty
        Me.ValorLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorLancamento.Location = New System.Drawing.Point(269, 18)
        Me.ValorLancamento.MaxLength = 10
        Me.ValorLancamento.Name = "ValorLancamento"
        Me.ValorLancamento.RegraValidação = Nothing
        Me.ValorLancamento.RegraValidaçãoMensagem = Nothing
        Me.ValorLancamento.Size = New System.Drawing.Size(83, 20)
        Me.ValorLancamento.TabIndex = 3
        Me.ValorLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorLancamento.ValorPadrao = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Credito)
        Me.GroupBox1.Controls.Add(Me.Debito)
        Me.GroupBox1.Controls.Add(Me.ValorLancamento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(356, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 46)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opção de Valor"
        '
        'Credito
        '
        Me.Credito.AutoSize = True
        Me.Credito.Location = New System.Drawing.Point(100, 19)
        Me.Credito.Name = "Credito"
        Me.Credito.Size = New System.Drawing.Size(64, 20)
        Me.Credito.TabIndex = 1
        Me.Credito.TabStop = True
        Me.Credito.Text = "Crédito"
        Me.Credito.UseVisualStyleBackColor = True
        '
        'Debito
        '
        Me.Debito.AutoSize = True
        Me.Debito.Location = New System.Drawing.Point(10, 19)
        Me.Debito.Name = "Debito"
        Me.Debito.Size = New System.Drawing.Size(59, 20)
        Me.Debito.TabIndex = 0
        Me.Debito.TabStop = True
        Me.Debito.Text = "Débito"
        Me.Debito.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(11, 116)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(770, 248)
        Me.MyLista.TabIndex = 12
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "Id"
        Me.ColumnHeader0.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Conta"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Data Lanc."
        Me.ColumnHeader2.Width = 83
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Documento"
        Me.ColumnHeader3.Width = 82
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Débito"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 77
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Crédito"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 71
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Histórico"
        Me.ColumnHeader6.Width = 335
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "IdOrigem"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "IdLancamento"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "IdProcura"
        Me.ColumnHeader9.Width = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(11, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data Lanç."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.AceitaColarTexto = True
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.Location = New System.Drawing.Point(110, 64)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(83, 20)
        Me.DataLancamento.TabIndex = 7
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(11, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Documento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Documento.FocusColor = System.Drawing.Color.Empty
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.Location = New System.Drawing.Point(110, 90)
        Me.Documento.MaxLength = 15
        Me.Documento.Name = "Documento"
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(83, 20)
        Me.Documento.TabIndex = 9
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'btAdicionar
        '
        Me.btAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdicionar.Location = New System.Drawing.Point(721, 88)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(60, 22)
        Me.btAdicionar.TabIndex = 11
        Me.btAdicionar.Text = "Add/Edd"
        '
        'PlanoContas
        '
        Me.PlanoContas.AceitaColarTexto = True
        Me.PlanoContas.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PlanoContas.CasasDecimais = 0
        Me.PlanoContas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PlanoContas.CPObrigatorio = False
        Me.PlanoContas.CPObrigatorioMsg = Nothing
        Me.PlanoContas.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PlanoContas.FocusColor = System.Drawing.Color.Empty
        Me.PlanoContas.FocusColorEnd = System.Drawing.Color.Empty
        Me.PlanoContas.Location = New System.Drawing.Point(698, 11)
        Me.PlanoContas.MaxLength = 6
        Me.PlanoContas.Name = "PlanoContas"
        Me.PlanoContas.RegraValidação = Nothing
        Me.PlanoContas.RegraValidaçãoMensagem = Nothing
        Me.PlanoContas.Size = New System.Drawing.Size(83, 20)
        Me.PlanoContas.TabIndex = 3
        Me.PlanoContas.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.PlanoContas.ValorPadrao = Nothing
        Me.PlanoContas.Visible = False
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(679, 398)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(102, 29)
        Me.btFechar.TabIndex = 22
        Me.btFechar.Text = "Fechar"
        '
        'ReduzidaDesc
        '
        Me.ReduzidaDesc.AceitaColarTexto = True
        Me.ReduzidaDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ReduzidaDesc.CasasDecimais = 0
        Me.ReduzidaDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReduzidaDesc.CPObrigatorio = False
        Me.ReduzidaDesc.CPObrigatorioMsg = Nothing
        Me.ReduzidaDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ReduzidaDesc.FocusColor = System.Drawing.Color.Empty
        Me.ReduzidaDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ReduzidaDesc.Location = New System.Drawing.Point(202, 11)
        Me.ReduzidaDesc.MaxLength = 6
        Me.ReduzidaDesc.Name = "ReduzidaDesc"
        Me.ReduzidaDesc.RegraValidação = Nothing
        Me.ReduzidaDesc.RegraValidaçãoMensagem = Nothing
        Me.ReduzidaDesc.Size = New System.Drawing.Size(579, 20)
        Me.ReduzidaDesc.TabIndex = 2
        Me.ReduzidaDesc.TabStop = False
        Me.ReduzidaDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ReduzidaDesc.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ser Lançado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SerLancado
        '
        Me.SerLancado.AceitaColarTexto = True
        Me.SerLancado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SerLancado.CasasDecimais = 2
        Me.SerLancado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SerLancado.CPObrigatorio = False
        Me.SerLancado.CPObrigatorioMsg = Nothing
        Me.SerLancado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SerLancado.FocusColor = System.Drawing.Color.Empty
        Me.SerLancado.FocusColorEnd = System.Drawing.Color.Empty
        Me.SerLancado.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerLancado.ForeColor = System.Drawing.Color.Navy
        Me.SerLancado.Location = New System.Drawing.Point(89, 370)
        Me.SerLancado.MaxLength = 8
        Me.SerLancado.Name = "SerLancado"
        Me.SerLancado.RegraValidação = Nothing
        Me.SerLancado.RegraValidaçãoMensagem = Nothing
        Me.SerLancado.Size = New System.Drawing.Size(104, 20)
        Me.SerLancado.TabIndex = 14
        Me.SerLancado.TabStop = False
        Me.SerLancado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SerLancado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.SerLancado.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(207, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Débito"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaldoDebito
        '
        Me.SaldoDebito.AceitaColarTexto = True
        Me.SaldoDebito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SaldoDebito.CasasDecimais = 2
        Me.SaldoDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SaldoDebito.CPObrigatorio = False
        Me.SaldoDebito.CPObrigatorioMsg = Nothing
        Me.SaldoDebito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SaldoDebito.FocusColor = System.Drawing.Color.Empty
        Me.SaldoDebito.FocusColorEnd = System.Drawing.Color.Empty
        Me.SaldoDebito.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoDebito.Location = New System.Drawing.Point(286, 370)
        Me.SaldoDebito.MaxLength = 8
        Me.SaldoDebito.Name = "SaldoDebito"
        Me.SaldoDebito.RegraValidação = Nothing
        Me.SaldoDebito.RegraValidaçãoMensagem = Nothing
        Me.SaldoDebito.Size = New System.Drawing.Size(104, 20)
        Me.SaldoDebito.TabIndex = 16
        Me.SaldoDebito.TabStop = False
        Me.SaldoDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SaldoDebito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.SaldoDebito.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(396, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Crédito"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaldoCredito
        '
        Me.SaldoCredito.AceitaColarTexto = True
        Me.SaldoCredito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SaldoCredito.CasasDecimais = 2
        Me.SaldoCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SaldoCredito.CPObrigatorio = False
        Me.SaldoCredito.CPObrigatorioMsg = Nothing
        Me.SaldoCredito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SaldoCredito.FocusColor = System.Drawing.Color.Empty
        Me.SaldoCredito.FocusColorEnd = System.Drawing.Color.Empty
        Me.SaldoCredito.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoCredito.Location = New System.Drawing.Point(475, 370)
        Me.SaldoCredito.MaxLength = 8
        Me.SaldoCredito.Name = "SaldoCredito"
        Me.SaldoCredito.RegraValidação = Nothing
        Me.SaldoCredito.RegraValidaçãoMensagem = Nothing
        Me.SaldoCredito.Size = New System.Drawing.Size(104, 20)
        Me.SaldoCredito.TabIndex = 18
        Me.SaldoCredito.TabStop = False
        Me.SaldoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SaldoCredito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.SaldoCredito.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(598, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Diferença"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaldoDiferenca
        '
        Me.SaldoDiferenca.AceitaColarTexto = True
        Me.SaldoDiferenca.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SaldoDiferenca.CasasDecimais = 2
        Me.SaldoDiferenca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SaldoDiferenca.CPObrigatorio = False
        Me.SaldoDiferenca.CPObrigatorioMsg = Nothing
        Me.SaldoDiferenca.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SaldoDiferenca.FocusColor = System.Drawing.Color.Empty
        Me.SaldoDiferenca.FocusColorEnd = System.Drawing.Color.Empty
        Me.SaldoDiferenca.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoDiferenca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaldoDiferenca.Location = New System.Drawing.Point(677, 369)
        Me.SaldoDiferenca.MaxLength = 8
        Me.SaldoDiferenca.Name = "SaldoDiferenca"
        Me.SaldoDiferenca.RegraValidação = Nothing
        Me.SaldoDiferenca.RegraValidaçãoMensagem = Nothing
        Me.SaldoDiferenca.Size = New System.Drawing.Size(104, 20)
        Me.SaldoDiferenca.TabIndex = 20
        Me.SaldoDiferenca.TabStop = False
        Me.SaldoDiferenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SaldoDiferenca.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.SaldoDiferenca.ValorPadrao = Nothing
        '
        'btSalvarDados
        '
        Me.btSalvarDados.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvarDados.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvarDados.Location = New System.Drawing.Point(493, 398)
        Me.btSalvarDados.Name = "btSalvarDados"
        Me.btSalvarDados.Size = New System.Drawing.Size(180, 29)
        Me.btSalvarDados.TabIndex = 21
        Me.btSalvarDados.Text = "Salvar e Fechar"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.btExcluir)
        Me.Fundo.Controls.Add(Me.btNovo)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.btSalvarDados)
        Me.Fundo.Controls.Add(Me.Reduzida)
        Me.Fundo.Controls.Add(Me.PlanoContas)
        Me.Fundo.Controls.Add(Me.Historico)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.SaldoDiferenca)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.SaldoCredito)
        Me.Fundo.Controls.Add(Me.GroupBox1)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.SaldoDebito)
        Me.Fundo.Controls.Add(Me.DataLancamento)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.SerLancado)
        Me.Fundo.Controls.Add(Me.Documento)
        Me.Fundo.Controls.Add(Me.ReduzidaDesc)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.btAdicionar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(796, 435)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.DarkSeaGreen
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.White
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(721, 64)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(60, 22)
        Me.btNovo.TabIndex = 27
        Me.btNovo.Text = "Novo"
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(225, 63)
        Me.Id.MaxLength = 6
        Me.Id.Name = "Id"
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(83, 20)
        Me.Id.TabIndex = 23
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'btExcluir
        '
        Me.btExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExcluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExcluir.Location = New System.Drawing.Point(11, 398)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(125, 29)
        Me.btExcluir.TabIndex = 28
        Me.btExcluir.Text = "Excluir Lançamento"
        '
        'CaixaEditaItemLancCtb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CaixaEditaItemLancCtb"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edição Lanç. Contabil"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Reduzida As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Historico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ValorLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Credito As System.Windows.Forms.RadioButton
    Friend WithEvents Debito As System.Windows.Forms.RadioButton
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PlanoContas As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ReduzidaDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SerLancado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SaldoDebito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SaldoCredito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SaldoDiferenca As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btSalvarDados As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ColumnHeader0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btExcluir As DevComponents.DotNetBar.ButtonX
End Class
