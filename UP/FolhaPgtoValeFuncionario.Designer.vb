<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoValeFuncionario
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoValeFuncionario))
        Me.CodPlanoContas = New TexBoxFocusNet.TextBoxFocusNet
        Me.Profiss�o = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataAdmiss�o = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.FuncionarioDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Funcionario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataQuitar = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.ModuloDescontar = New TexBoxFocusNet.TextBoxFocusNet
        Me.CompetenciaDesconto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TipoGeradorBT = New System.Windows.Forms.Label
        Me.ValorLancamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.Evento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label10 = New System.Windows.Forms.Label
        Me.EventoDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.LancadoFolha = New TexBoxFocusNet.TextBoxFocusNet
        Me.Confirmado = New System.Windows.Forms.CheckBox
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.NovoBT = New System.Windows.Forms.ToolStripButton
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton
        Me.ImprimirConfirmarBT = New System.Windows.Forms.ToolStripButton
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.Debito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Credito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.MenuTipoGerador = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DecimoParcela1menu = New System.Windows.Forms.ToolStripMenuItem
        Me.DecimoParcela2Menu = New System.Windows.Forms.ToolStripMenuItem
        Me.FeriasMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.MensalistasMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.PgtoPISMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.Recis�oMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.SemFoto = New System.Windows.Forms.PictureBox
        Me.Display = New System.Windows.Forms.PictureBox
        Me.Usuario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label11 = New System.Windows.Forms.Label
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.BarraBt.SuspendLayout()
        Me.MenuTipoGerador.SuspendLayout()
        CType(Me.SemFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodPlanoContas
        '
        Me.CodPlanoContas.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CodPlanoContas.CasasDecimais = 0
        Me.CodPlanoContas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodPlanoContas.CPObrigatorio = False
        Me.CodPlanoContas.CPObrigatorioMsg = Nothing
        Me.CodPlanoContas.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.CodPlanoContas.FocusColor = System.Drawing.Color.Empty
        Me.CodPlanoContas.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodPlanoContas.Location = New System.Drawing.Point(209, 275)
        Me.CodPlanoContas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodPlanoContas.MaxLength = 20
        Me.CodPlanoContas.Name = "CodPlanoContas"
        Me.CodPlanoContas.RegraValida��o = Nothing
        Me.CodPlanoContas.RegraValida��oMensagem = Nothing
        Me.CodPlanoContas.Size = New System.Drawing.Size(39, 20)
        Me.CodPlanoContas.TabIndex = 24
        Me.CodPlanoContas.TabStop = False
        Me.CodPlanoContas.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodPlanoContas.ValorPadrao = Nothing
        Me.CodPlanoContas.Visible = False
        '
        'Profiss�o
        '
        Me.Profiss�o.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Profiss�o.CasasDecimais = 0
        Me.Profiss�o.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Profiss�o.CPObrigatorio = False
        Me.Profiss�o.CPObrigatorioMsg = Nothing
        Me.Profiss�o.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Profiss�o.FocusColor = System.Drawing.Color.Empty
        Me.Profiss�o.FocusColorEnd = System.Drawing.Color.Empty
        Me.Profiss�o.Location = New System.Drawing.Point(364, 274)
        Me.Profiss�o.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Profiss�o.MaxLength = 20
        Me.Profiss�o.Name = "Profiss�o"
        Me.Profiss�o.RegraValida��o = Nothing
        Me.Profiss�o.RegraValida��oMensagem = Nothing
        Me.Profiss�o.Size = New System.Drawing.Size(123, 20)
        Me.Profiss�o.TabIndex = 26
        Me.Profiss�o.TabStop = False
        Me.Profiss�o.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Profiss�o.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(254, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Profiss�o"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataAdmiss�o
        '
        Me.DataAdmiss�o.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataAdmiss�o.CasasDecimais = 0
        Me.DataAdmiss�o.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataAdmiss�o.CPObrigatorio = False
        Me.DataAdmiss�o.CPObrigatorioMsg = Nothing
        Me.DataAdmiss�o.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.DataAdmiss�o.FocusColor = System.Drawing.Color.Empty
        Me.DataAdmiss�o.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataAdmiss�o.Location = New System.Drawing.Point(122, 276)
        Me.DataAdmiss�o.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataAdmiss�o.MaxLength = 10
        Me.DataAdmiss�o.Name = "DataAdmiss�o"
        Me.DataAdmiss�o.RegraValida��o = Nothing
        Me.DataAdmiss�o.RegraValida��oMensagem = Nothing
        Me.DataAdmiss�o.Size = New System.Drawing.Size(77, 20)
        Me.DataAdmiss�o.TabIndex = 23
        Me.DataAdmiss�o.TabStop = False
        Me.DataAdmiss�o.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataAdmiss�o.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Admiss�o"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FuncionarioDesc
        '
        Me.FuncionarioDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.FuncionarioDesc.CasasDecimais = 0
        Me.FuncionarioDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FuncionarioDesc.CPObrigatorio = False
        Me.FuncionarioDesc.CPObrigatorioMsg = Nothing
        Me.FuncionarioDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.FuncionarioDesc.FocusColor = System.Drawing.Color.Empty
        Me.FuncionarioDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FuncionarioDesc.Location = New System.Drawing.Point(203, 248)
        Me.FuncionarioDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FuncionarioDesc.MaxLength = 50
        Me.FuncionarioDesc.Name = "FuncionarioDesc"
        Me.FuncionarioDesc.RegraValida��o = Nothing
        Me.FuncionarioDesc.RegraValida��oMensagem = Nothing
        Me.FuncionarioDesc.Size = New System.Drawing.Size(284, 20)
        Me.FuncionarioDesc.TabIndex = 21
        Me.FuncionarioDesc.TabStop = False
        Me.FuncionarioDesc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncionarioDesc.ValorPadrao = Nothing
        '
        'Funcionario
        '
        Me.Funcionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Funcionario.CasasDecimais = 0
        Me.Funcionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Funcionario.CPObrigatorio = False
        Me.Funcionario.CPObrigatorioMsg = Nothing
        Me.Funcionario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Funcionario.FocusColor = System.Drawing.Color.Empty
        Me.Funcionario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Funcionario.Location = New System.Drawing.Point(122, 248)
        Me.Funcionario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionario.MaxLength = 16
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.RegraValida��o = Nothing
        Me.Funcionario.RegraValida��oMensagem = Nothing
        Me.Funcionario.Size = New System.Drawing.Size(77, 20)
        Me.Funcionario.TabIndex = 20
        Me.Funcionario.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Funcionario.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Funcion�rio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.DataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.Location = New System.Drawing.Point(122, 108)
        Me.DataLancamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.RegraValida��o = Nothing
        Me.DataLancamento.RegraValida��oMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(75, 20)
        Me.DataLancamento.TabIndex = 6
        Me.DataLancamento.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Lan�amento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataQuitar
        '
        Me.DataQuitar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.DataQuitar.CasasDecimais = 0
        Me.DataQuitar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataQuitar.CPObrigatorio = False
        Me.DataQuitar.CPObrigatorioMsg = Nothing
        Me.DataQuitar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.DataQuitar.FocusColor = System.Drawing.Color.Empty
        Me.DataQuitar.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataQuitar.Location = New System.Drawing.Point(122, 136)
        Me.DataQuitar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataQuitar.MaxLength = 10
        Me.DataQuitar.Name = "DataQuitar"
        Me.DataQuitar.RegraValida��o = Nothing
        Me.DataQuitar.RegraValida��oMensagem = Nothing
        Me.DataQuitar.Size = New System.Drawing.Size(75, 20)
        Me.DataQuitar.TabIndex = 8
        Me.DataQuitar.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataQuitar.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Data Descontar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(122, 80)
        Me.Id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Id.MaxLength = 16
        Me.Id.Name = "Id"
        Me.Id.RegraValida��o = Nothing
        Me.Id.RegraValida��oMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(75, 20)
        Me.Id.TabIndex = 1
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Id.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Id"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModuloDescontar
        '
        Me.ModuloDescontar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ModuloDescontar.CasasDecimais = 0
        Me.ModuloDescontar.CPObrigatorio = False
        Me.ModuloDescontar.CPObrigatorioMsg = Nothing
        Me.ModuloDescontar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ModuloDescontar.FocusColor = System.Drawing.Color.Empty
        Me.ModuloDescontar.FocusColorEnd = System.Drawing.Color.Empty
        Me.ModuloDescontar.Location = New System.Drawing.Point(257, 164)
        Me.ModuloDescontar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ModuloDescontar.MaxLength = 16
        Me.ModuloDescontar.Name = "ModuloDescontar"
        Me.ModuloDescontar.RegraValida��o = Nothing
        Me.ModuloDescontar.RegraValida��oMensagem = Nothing
        Me.ModuloDescontar.Size = New System.Drawing.Size(84, 20)
        Me.ModuloDescontar.TabIndex = 12
        Me.ModuloDescontar.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ModuloDescontar.ValorPadrao = Nothing
        '
        'CompetenciaDesconto
        '
        Me.CompetenciaDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CompetenciaDesconto.CasasDecimais = 0
        Me.CompetenciaDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompetenciaDesconto.CPObrigatorio = False
        Me.CompetenciaDesconto.CPObrigatorioMsg = Nothing
        Me.CompetenciaDesconto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.CompetenciaDesconto.FocusColor = System.Drawing.Color.Empty
        Me.CompetenciaDesconto.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompetenciaDesconto.Location = New System.Drawing.Point(122, 164)
        Me.CompetenciaDesconto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompetenciaDesconto.MaxLength = 7
        Me.CompetenciaDesconto.Name = "CompetenciaDesconto"
        Me.CompetenciaDesconto.RegraValida��o = Nothing
        Me.CompetenciaDesconto.RegraValida��oMensagem = Nothing
        Me.CompetenciaDesconto.Size = New System.Drawing.Size(75, 20)
        Me.CompetenciaDesconto.TabIndex = 10
        Me.CompetenciaDesconto.TabStop = False
        Me.CompetenciaDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CompetenciaDesconto.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.CompetenciaDesconto.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(205, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Modulo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Compet�ncia"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoGeradorBT
        '
        Me.TipoGeradorBT.BackColor = System.Drawing.Color.Transparent
        Me.TipoGeradorBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TipoGeradorBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoGeradorBT.Location = New System.Drawing.Point(346, 164)
        Me.TipoGeradorBT.Name = "TipoGeradorBT"
        Me.TipoGeradorBT.Size = New System.Drawing.Size(24, 18)
        Me.TipoGeradorBT.TabIndex = 13
        Me.TipoGeradorBT.Text = "..."
        Me.TipoGeradorBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValorLancamento
        '
        Me.ValorLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ValorLancamento.CasasDecimais = 2
        Me.ValorLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorLancamento.CPObrigatorio = False
        Me.ValorLancamento.CPObrigatorioMsg = Nothing
        Me.ValorLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.ValorLancamento.FocusColor = System.Drawing.Color.Empty
        Me.ValorLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorLancamento.Location = New System.Drawing.Point(122, 192)
        Me.ValorLancamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValorLancamento.MaxLength = 10
        Me.ValorLancamento.Name = "ValorLancamento"
        Me.ValorLancamento.RegraValida��o = Nothing
        Me.ValorLancamento.RegraValida��oMensagem = Nothing
        Me.ValorLancamento.Size = New System.Drawing.Size(75, 20)
        Me.ValorLancamento.TabIndex = 15
        Me.ValorLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorLancamento.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorLancamento.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Valor Lan�amento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Evento
        '
        Me.Evento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Evento.CasasDecimais = 0
        Me.Evento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Evento.CPObrigatorio = False
        Me.Evento.CPObrigatorioMsg = Nothing
        Me.Evento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Evento.FocusColor = System.Drawing.Color.Empty
        Me.Evento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Evento.Location = New System.Drawing.Point(122, 220)
        Me.Evento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Evento.MaxLength = 6
        Me.Evento.Name = "Evento"
        Me.Evento.RegraValida��o = Nothing
        Me.Evento.RegraValida��oMensagem = Nothing
        Me.Evento.Size = New System.Drawing.Size(75, 20)
        Me.Evento.TabIndex = 17
        Me.Evento.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Evento.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(14, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Evento"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EventoDesc
        '
        Me.EventoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.EventoDesc.CasasDecimais = 0
        Me.EventoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EventoDesc.CPObrigatorio = False
        Me.EventoDesc.CPObrigatorioMsg = Nothing
        Me.EventoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.EventoDesc.FocusColor = System.Drawing.Color.Empty
        Me.EventoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.EventoDesc.Location = New System.Drawing.Point(203, 220)
        Me.EventoDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EventoDesc.MaxLength = 30
        Me.EventoDesc.Name = "EventoDesc"
        Me.EventoDesc.RegraValida��o = Nothing
        Me.EventoDesc.RegraValida��oMensagem = Nothing
        Me.EventoDesc.Size = New System.Drawing.Size(284, 20)
        Me.EventoDesc.TabIndex = 18
        Me.EventoDesc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EventoDesc.ValorPadrao = Nothing
        '
        'LancadoFolha
        '
        Me.LancadoFolha.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.LancadoFolha.CasasDecimais = 0
        Me.LancadoFolha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LancadoFolha.CPObrigatorio = False
        Me.LancadoFolha.CPObrigatorioMsg = Nothing
        Me.LancadoFolha.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.LancadoFolha.FocusColor = System.Drawing.Color.Empty
        Me.LancadoFolha.FocusColorEnd = System.Drawing.Color.Empty
        Me.LancadoFolha.Location = New System.Drawing.Point(257, 81)
        Me.LancadoFolha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LancadoFolha.MaxLength = 1
        Me.LancadoFolha.Name = "LancadoFolha"
        Me.LancadoFolha.RegraValida��o = Nothing
        Me.LancadoFolha.RegraValida��oMensagem = Nothing
        Me.LancadoFolha.Size = New System.Drawing.Size(24, 20)
        Me.LancadoFolha.TabIndex = 3
        Me.LancadoFolha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LancadoFolha.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.LancadoFolha.ValorPadrao = Nothing
        Me.LancadoFolha.Visible = False
        '
        'Confirmado
        '
        Me.Confirmado.AutoSize = True
        Me.Confirmado.Enabled = False
        Me.Confirmado.Location = New System.Drawing.Point(403, 360)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(84, 20)
        Me.Confirmado.TabIndex = 4
        Me.Confirmado.TabStop = False
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.UseVisualStyleBackColor = True
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.ImprimirConfirmarBT, Me.ExcluirBT, Me.LocalizarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(499, 68)
        Me.BarraBt.TabIndex = 191
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(54, 65)
        Me.NovoBT.Text = "Novo-F9"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalvarBT
        '
        Me.SalvarBT.Image = CType(resources.GetObject("SalvarBT.Image"), System.Drawing.Image)
        Me.SalvarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(63, 65)
        Me.SalvarBT.Text = "Salvar-F10"
        Me.SalvarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImprimirConfirmarBT
        '
        Me.ImprimirConfirmarBT.Image = CType(resources.GetObject("ImprimirConfirmarBT.Image"), System.Drawing.Image)
        Me.ImprimirConfirmarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ImprimirConfirmarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImprimirConfirmarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirConfirmarBT.Name = "ImprimirConfirmarBT"
        Me.ImprimirConfirmarBT.Size = New System.Drawing.Size(116, 65)
        Me.ImprimirConfirmarBT.Text = "Imprimir e Confirmar"
        Me.ImprimirConfirmarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ImprimirConfirmarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcluirBT
        '
        Me.ExcluirBT.Image = CType(resources.GetObject("ExcluirBT.Image"), System.Drawing.Image)
        Me.ExcluirBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirBT.Name = "ExcluirBT"
        Me.ExcluirBT.Size = New System.Drawing.Size(60, 65)
        Me.ExcluirBT.Text = "Excluir-F8"
        Me.ExcluirBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExcluirBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LocalizarBT
        '
        Me.LocalizarBT.Image = CType(resources.GetObject("LocalizarBT.Image"), System.Drawing.Image)
        Me.LocalizarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LocalizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LocalizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LocalizarBT.Name = "LocalizarBT"
        Me.LocalizarBT.Size = New System.Drawing.Size(71, 65)
        Me.LocalizarBT.Text = "Localizar-F7"
        Me.LocalizarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LocalizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(76, 65)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Debito
        '
        Me.Debito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Debito.CasasDecimais = 0
        Me.Debito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Debito.CPObrigatorio = False
        Me.Debito.CPObrigatorioMsg = Nothing
        Me.Debito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Debito.FocusColor = System.Drawing.Color.Empty
        Me.Debito.FocusColorEnd = System.Drawing.Color.Empty
        Me.Debito.Location = New System.Drawing.Point(122, 304)
        Me.Debito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Debito.MaxLength = 20
        Me.Debito.Name = "Debito"
        Me.Debito.RegraValida��o = Nothing
        Me.Debito.RegraValida��oMensagem = Nothing
        Me.Debito.Size = New System.Drawing.Size(148, 20)
        Me.Debito.TabIndex = 28
        Me.Debito.TabStop = False
        Me.Debito.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Debito.ValorPadrao = Nothing
        '
        'Credito
        '
        Me.Credito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Credito.CasasDecimais = 0
        Me.Credito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Credito.CPObrigatorio = False
        Me.Credito.CPObrigatorioMsg = Nothing
        Me.Credito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Credito.FocusColor = System.Drawing.Color.Empty
        Me.Credito.FocusColorEnd = System.Drawing.Color.Empty
        Me.Credito.Location = New System.Drawing.Point(122, 332)
        Me.Credito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Credito.MaxLength = 20
        Me.Credito.Name = "Credito"
        Me.Credito.RegraValida��o = Nothing
        Me.Credito.RegraValida��oMensagem = Nothing
        Me.Credito.Size = New System.Drawing.Size(148, 20)
        Me.Credito.TabIndex = 30
        Me.Credito.TabStop = False
        Me.Credito.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Credito.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(14, 304)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "D�bito"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(14, 333)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Cr�dito"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuTipoGerador
        '
        Me.MenuTipoGerador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DecimoParcela1menu, Me.DecimoParcela2Menu, Me.FeriasMenu, Me.MensalistasMenu, Me.PgtoPISMenu, Me.Recis�oMenu})
        Me.MenuTipoGerador.Name = "MenuTipoGerador"
        Me.MenuTipoGerador.Size = New System.Drawing.Size(153, 136)
        '
        'DecimoParcela1menu
        '
        Me.DecimoParcela1menu.Name = "DecimoParcela1menu"
        Me.DecimoParcela1menu.Size = New System.Drawing.Size(152, 22)
        Me.DecimoParcela1menu.Text = "1 Par Dec. Ter�"
        '
        'DecimoParcela2Menu
        '
        Me.DecimoParcela2Menu.Name = "DecimoParcela2Menu"
        Me.DecimoParcela2Menu.Size = New System.Drawing.Size(152, 22)
        Me.DecimoParcela2Menu.Text = "2 Par Dec. Ter�"
        '
        'FeriasMenu
        '
        Me.FeriasMenu.Name = "FeriasMenu"
        Me.FeriasMenu.Size = New System.Drawing.Size(152, 22)
        Me.FeriasMenu.Text = "F�rias"
        '
        'MensalistasMenu
        '
        Me.MensalistasMenu.Name = "MensalistasMenu"
        Me.MensalistasMenu.Size = New System.Drawing.Size(152, 22)
        Me.MensalistasMenu.Text = "Mensalistas"
        '
        'PgtoPISMenu
        '
        Me.PgtoPISMenu.Name = "PgtoPISMenu"
        Me.PgtoPISMenu.Size = New System.Drawing.Size(152, 22)
        Me.PgtoPISMenu.Text = "Pgto PIS"
        '
        'Recis�oMenu
        '
        Me.Recis�oMenu.Name = "Recis�oMenu"
        Me.Recis�oMenu.Size = New System.Drawing.Size(152, 22)
        Me.Recis�oMenu.Text = "Recis�o"
        '
        'SemFoto
        '
        Me.SemFoto.BackColor = System.Drawing.Color.Transparent
        Me.SemFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SemFoto.Image = CType(resources.GetObject("SemFoto.Image"), System.Drawing.Image)
        Me.SemFoto.Location = New System.Drawing.Point(449, 166)
        Me.SemFoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SemFoto.Name = "SemFoto"
        Me.SemFoto.Size = New System.Drawing.Size(39, 46)
        Me.SemFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SemFoto.TabIndex = 193
        Me.SemFoto.TabStop = False
        Me.SemFoto.Visible = False
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.Color.Transparent
        Me.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Display.Location = New System.Drawing.Point(376, 73)
        Me.Display.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(112, 139)
        Me.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Display.TabIndex = 192
        Me.Display.TabStop = False
        '
        'Usuario
        '
        Me.Usuario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Usuario.CasasDecimais = 0
        Me.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usuario.CPObrigatorio = False
        Me.Usuario.CPObrigatorioMsg = Nothing
        Me.Usuario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Usuario.FocusColor = System.Drawing.Color.Empty
        Me.Usuario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Usuario.Location = New System.Drawing.Point(122, 360)
        Me.Usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Usuario.MaxLength = 16
        Me.Usuario.Name = "Usuario"
        Me.Usuario.RegraValida��o = Nothing
        Me.Usuario.RegraValida��oMensagem = Nothing
        Me.Usuario.Size = New System.Drawing.Size(105, 20)
        Me.Usuario.TabIndex = 195
        Me.Usuario.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Usuario.ValorPadrao = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 25)
        Me.Label11.TabIndex = 194
        Me.Label11.Text = "Usu�rio"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Usuario)
        Me.Fundo.Controls.Add(Me.DataLancamento)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.SemFoto)
        Me.Fundo.Controls.Add(Me.DataQuitar)
        Me.Fundo.Controls.Add(Me.Display)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.TipoGeradorBT)
        Me.Fundo.Controls.Add(Me.Credito)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Debito)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.CompetenciaDesconto)
        Me.Fundo.Controls.Add(Me.CodPlanoContas)
        Me.Fundo.Controls.Add(Me.ModuloDescontar)
        Me.Fundo.Controls.Add(Me.Confirmado)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Profiss�o)
        Me.Fundo.Controls.Add(Me.ValorLancamento)
        Me.Fundo.Controls.Add(Me.LancadoFolha)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Funcionario)
        Me.Fundo.Controls.Add(Me.DataAdmiss�o)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.EventoDesc)
        Me.Fundo.Controls.Add(Me.FuncionarioDesc)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Evento)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(499, 390)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 196
        '
        'FolhaPgtoValeFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoValeFuncionario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vale para Funcion�rio"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.MenuTipoGerador.ResumeLayout(False)
        CType(Me.SemFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CodPlanoContas As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Profiss�o As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataAdmiss�o As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FuncionarioDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Funcionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataQuitar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ModuloDescontar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CompetenciaDesconto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TipoGeradorBT As System.Windows.Forms.Label
    Friend WithEvents ValorLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Evento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents EventoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LancadoFolha As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Confirmado As System.Windows.Forms.CheckBox
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirConfirmarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Debito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Credito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MenuTipoGerador As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DecimoParcela1menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecimoParcela2Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeriasMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MensalistasMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PgtoPISMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Recis�oMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Display As System.Windows.Forms.PictureBox
    Friend WithEvents Usuario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
