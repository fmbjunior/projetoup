<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoVisualizador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoVisualizador))
        Me.TipoGeradorBT = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MesCompetencia = New TexBoxFocusNet.TextBoxFocusNet
        Me.Modulo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuTipoGerador = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MensalDiaristaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FériasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DécimoTerceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PgtoPISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecisãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ValeQuinzenalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PainelFuncionario = New System.Windows.Forms.Panel
        Me.CodPlanoContas = New TexBoxFocusNet.TextBoxFocusNet
        Me.Salario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.SalarioRegistro = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.Profissão = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataAdmissão = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.FuncionarioDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Funcionario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.NovoBT = New System.Windows.Forms.ToolStripButton
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.CadFuncionarioBT = New System.Windows.Forms.ToolStripButton
        Me.TotDebito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label8 = New System.Windows.Forms.Label
        Me.TotCredito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColId = New System.Windows.Forms.ColumnHeader
        Me.ColEvento = New System.Windows.Forms.ColumnHeader
        Me.ColHistorico = New System.Windows.Forms.ColumnHeader
        Me.ColRef = New System.Windows.Forms.ColumnHeader
        Me.ColDebito = New System.Windows.Forms.ColumnHeader
        Me.ColCredito = New System.Windows.Forms.ColumnHeader
        Me.ColConfirmado = New System.Windows.Forms.ColumnHeader
        Me.ColUsuario = New System.Windows.Forms.ColumnHeader
        Me.ColProtegido = New System.Windows.Forms.ColumnHeader
        Me.MenuItens = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NovoItemNaFolhaDePagamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcluirItemSelecionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Liquido = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label10 = New System.Windows.Forms.Label
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.SemFoto = New System.Windows.Forms.PictureBox
        Me.Display = New System.Windows.Forms.PictureBox
        Me.btRecibo = New System.Windows.Forms.ToolStripButton
        Me.MenuTipoGerador.SuspendLayout()
        Me.PainelFuncionario.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.MenuItens.SuspendLayout()
        Me.Fundo.SuspendLayout()
        CType(Me.SemFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoGeradorBT
        '
        Me.TipoGeradorBT.BackColor = System.Drawing.Color.Transparent
        Me.TipoGeradorBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TipoGeradorBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoGeradorBT.Location = New System.Drawing.Point(480, 98)
        Me.TipoGeradorBT.Name = "TipoGeradorBT"
        Me.TipoGeradorBT.Size = New System.Drawing.Size(24, 18)
        Me.TipoGeradorBT.TabIndex = 11
        Me.TipoGeradorBT.Text = "..."
        Me.TipoGeradorBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Competência"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MesCompetencia
        '
        Me.MesCompetencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.MesCompetencia.CasasDecimais = 0
        Me.MesCompetencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MesCompetencia.CPObrigatorio = False
        Me.MesCompetencia.CPObrigatorioMsg = Nothing
        Me.MesCompetencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.MesCompetencia.FocusColor = System.Drawing.Color.Empty
        Me.MesCompetencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.MesCompetencia.Location = New System.Drawing.Point(137, 96)
        Me.MesCompetencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MesCompetencia.MaxLength = 7
        Me.MesCompetencia.Name = "MesCompetencia"
        Me.MesCompetencia.RegraValidação = Nothing
        Me.MesCompetencia.RegraValidaçãoMensagem = Nothing
        Me.MesCompetencia.Size = New System.Drawing.Size(75, 20)
        Me.MesCompetencia.TabIndex = 8
        Me.MesCompetencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MesCompetencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.MesCompetencia.ValorPadrao = Nothing
        '
        'Modulo
        '
        Me.Modulo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Modulo.CasasDecimais = 0
        Me.Modulo.CPObrigatorio = False
        Me.Modulo.CPObrigatorioMsg = Nothing
        Me.Modulo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Modulo.FocusColor = System.Drawing.Color.Empty
        Me.Modulo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Modulo.Location = New System.Drawing.Point(377, 98)
        Me.Modulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Modulo.MaxLength = 16
        Me.Modulo.Name = "Modulo"
        Me.Modulo.RegraValidação = Nothing
        Me.Modulo.RegraValidaçãoMensagem = Nothing
        Me.Modulo.Size = New System.Drawing.Size(97, 20)
        Me.Modulo.TabIndex = 10
        Me.Modulo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Modulo.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(270, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Modulo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuTipoGerador
        '
        Me.MenuTipoGerador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensalDiaristaToolStripMenuItem, Me.FériasToolStripMenuItem, Me.DécimoTerceiroToolStripMenuItem, Me.PISToolStripMenuItem, Me.PgtoPISToolStripMenuItem, Me.RecisãoToolStripMenuItem, Me.ValeQuinzenalToolStripMenuItem})
        Me.MenuTipoGerador.Name = "MenuTipoGerador"
        Me.MenuTipoGerador.Size = New System.Drawing.Size(153, 158)
        '
        'MensalDiaristaToolStripMenuItem
        '
        Me.MensalDiaristaToolStripMenuItem.Name = "MensalDiaristaToolStripMenuItem"
        Me.MensalDiaristaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MensalDiaristaToolStripMenuItem.Text = "1 Par Dec. Terç"
        '
        'FériasToolStripMenuItem
        '
        Me.FériasToolStripMenuItem.Name = "FériasToolStripMenuItem"
        Me.FériasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FériasToolStripMenuItem.Text = "2 Par Dec. Terç"
        '
        'DécimoTerceiroToolStripMenuItem
        '
        Me.DécimoTerceiroToolStripMenuItem.Name = "DécimoTerceiroToolStripMenuItem"
        Me.DécimoTerceiroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DécimoTerceiroToolStripMenuItem.Text = "Férias"
        '
        'PISToolStripMenuItem
        '
        Me.PISToolStripMenuItem.Name = "PISToolStripMenuItem"
        Me.PISToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PISToolStripMenuItem.Text = "Mensalistas"
        '
        'PgtoPISToolStripMenuItem
        '
        Me.PgtoPISToolStripMenuItem.Name = "PgtoPISToolStripMenuItem"
        Me.PgtoPISToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PgtoPISToolStripMenuItem.Text = "Pgto PIS"
        '
        'RecisãoToolStripMenuItem
        '
        Me.RecisãoToolStripMenuItem.Name = "RecisãoToolStripMenuItem"
        Me.RecisãoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RecisãoToolStripMenuItem.Text = "Recisão"
        '
        'ValeQuinzenalToolStripMenuItem
        '
        Me.ValeQuinzenalToolStripMenuItem.Name = "ValeQuinzenalToolStripMenuItem"
        Me.ValeQuinzenalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ValeQuinzenalToolStripMenuItem.Text = "Vale Quinzenal"
        '
        'PainelFuncionario
        '
        Me.PainelFuncionario.BackColor = System.Drawing.Color.Transparent
        Me.PainelFuncionario.Controls.Add(Me.CodPlanoContas)
        Me.PainelFuncionario.Controls.Add(Me.Salario)
        Me.PainelFuncionario.Controls.Add(Me.Label7)
        Me.PainelFuncionario.Controls.Add(Me.SalarioRegistro)
        Me.PainelFuncionario.Controls.Add(Me.Label6)
        Me.PainelFuncionario.Controls.Add(Me.Profissão)
        Me.PainelFuncionario.Controls.Add(Me.Label5)
        Me.PainelFuncionario.Controls.Add(Me.DataAdmissão)
        Me.PainelFuncionario.Controls.Add(Me.Label4)
        Me.PainelFuncionario.Controls.Add(Me.FuncionarioDesc)
        Me.PainelFuncionario.Controls.Add(Me.Funcionario)
        Me.PainelFuncionario.Controls.Add(Me.Label3)
        Me.PainelFuncionario.Location = New System.Drawing.Point(12, 124)
        Me.PainelFuncionario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PainelFuncionario.Name = "PainelFuncionario"
        Me.PainelFuncionario.Size = New System.Drawing.Size(495, 88)
        Me.PainelFuncionario.TabIndex = 170
        '
        'CodPlanoContas
        '
        Me.CodPlanoContas.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CodPlanoContas.CasasDecimais = 0
        Me.CodPlanoContas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodPlanoContas.CPObrigatorio = False
        Me.CodPlanoContas.CPObrigatorioMsg = Nothing
        Me.CodPlanoContas.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodPlanoContas.FocusColor = System.Drawing.Color.Empty
        Me.CodPlanoContas.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodPlanoContas.Location = New System.Drawing.Point(446, 60)
        Me.CodPlanoContas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodPlanoContas.MaxLength = 20
        Me.CodPlanoContas.Name = "CodPlanoContas"
        Me.CodPlanoContas.RegraValidação = Nothing
        Me.CodPlanoContas.RegraValidaçãoMensagem = Nothing
        Me.CodPlanoContas.Size = New System.Drawing.Size(41, 20)
        Me.CodPlanoContas.TabIndex = 18
        Me.CodPlanoContas.TabStop = False
        Me.CodPlanoContas.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodPlanoContas.ValorPadrao = Nothing
        Me.CodPlanoContas.Visible = False
        '
        'Salario
        '
        Me.Salario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Salario.CasasDecimais = 0
        Me.Salario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Salario.CPObrigatorio = False
        Me.Salario.CPObrigatorioMsg = Nothing
        Me.Salario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Salario.FocusColor = System.Drawing.Color.Empty
        Me.Salario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Salario.Location = New System.Drawing.Point(365, 60)
        Me.Salario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salario.MaxLength = 10
        Me.Salario.Name = "Salario"
        Me.Salario.RegraValidação = Nothing
        Me.Salario.RegraValidaçãoMensagem = Nothing
        Me.Salario.Size = New System.Drawing.Size(75, 20)
        Me.Salario.TabIndex = 16
        Me.Salario.TabStop = False
        Me.Salario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Salario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Salario.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(255, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Salário Diferença"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalarioRegistro
        '
        Me.SalarioRegistro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SalarioRegistro.CasasDecimais = 0
        Me.SalarioRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SalarioRegistro.CPObrigatorio = False
        Me.SalarioRegistro.CPObrigatorioMsg = Nothing
        Me.SalarioRegistro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SalarioRegistro.FocusColor = System.Drawing.Color.Empty
        Me.SalarioRegistro.FocusColorEnd = System.Drawing.Color.Empty
        Me.SalarioRegistro.Location = New System.Drawing.Point(125, 60)
        Me.SalarioRegistro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SalarioRegistro.MaxLength = 10
        Me.SalarioRegistro.Name = "SalarioRegistro"
        Me.SalarioRegistro.RegraValidação = Nothing
        Me.SalarioRegistro.RegraValidaçãoMensagem = Nothing
        Me.SalarioRegistro.Size = New System.Drawing.Size(75, 20)
        Me.SalarioRegistro.TabIndex = 14
        Me.SalarioRegistro.TabStop = False
        Me.SalarioRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioRegistro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioRegistro.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Salário Registro"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Profissão
        '
        Me.Profissão.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Profissão.CasasDecimais = 0
        Me.Profissão.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Profissão.CPObrigatorio = False
        Me.Profissão.CPObrigatorioMsg = Nothing
        Me.Profissão.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Profissão.FocusColor = System.Drawing.Color.Empty
        Me.Profissão.FocusColorEnd = System.Drawing.Color.Empty
        Me.Profissão.Location = New System.Drawing.Point(365, 30)
        Me.Profissão.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Profissão.MaxLength = 20
        Me.Profissão.Name = "Profissão"
        Me.Profissão.RegraValidação = Nothing
        Me.Profissão.RegraValidaçãoMensagem = Nothing
        Me.Profissão.Size = New System.Drawing.Size(127, 20)
        Me.Profissão.TabIndex = 12
        Me.Profissão.TabStop = False
        Me.Profissão.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Profissão.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(255, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Profissão"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataAdmissão
        '
        Me.DataAdmissão.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataAdmissão.CasasDecimais = 0
        Me.DataAdmissão.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataAdmissão.CPObrigatorio = False
        Me.DataAdmissão.CPObrigatorioMsg = Nothing
        Me.DataAdmissão.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataAdmissão.FocusColor = System.Drawing.Color.Empty
        Me.DataAdmissão.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataAdmissão.Location = New System.Drawing.Point(125, 32)
        Me.DataAdmissão.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataAdmissão.MaxLength = 10
        Me.DataAdmissão.Name = "DataAdmissão"
        Me.DataAdmissão.RegraValidação = Nothing
        Me.DataAdmissão.RegraValidaçãoMensagem = Nothing
        Me.DataAdmissão.Size = New System.Drawing.Size(75, 20)
        Me.DataAdmissão.TabIndex = 10
        Me.DataAdmissão.TabStop = False
        Me.DataAdmissão.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataAdmissão.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Admissão"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.FuncionarioDesc.Location = New System.Drawing.Point(204, 4)
        Me.FuncionarioDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FuncionarioDesc.MaxLength = 50
        Me.FuncionarioDesc.Name = "FuncionarioDesc"
        Me.FuncionarioDesc.RegraValidação = Nothing
        Me.FuncionarioDesc.RegraValidaçãoMensagem = Nothing
        Me.FuncionarioDesc.Size = New System.Drawing.Size(288, 20)
        Me.FuncionarioDesc.TabIndex = 9
        Me.FuncionarioDesc.TabStop = False
        Me.FuncionarioDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncionarioDesc.ValorPadrao = Nothing
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
        Me.Funcionario.Location = New System.Drawing.Point(125, 4)
        Me.Funcionario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Funcionario.MaxLength = 16
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.RegraValidação = Nothing
        Me.Funcionario.RegraValidaçãoMensagem = Nothing
        Me.Funcionario.Size = New System.Drawing.Size(75, 20)
        Me.Funcionario.TabIndex = 7
        Me.Funcionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Funcionario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Funcionario.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Funcionário"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.ExcluirBT, Me.LocalizarBT, Me.FecharBT, Me.CadFuncionarioBT, Me.btRecibo})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(631, 68)
        Me.BarraBt.TabIndex = 174
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(107, 65)
        Me.NovoBT.Text = "Nova Competência"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcluirBT
        '
        Me.ExcluirBT.Image = CType(resources.GetObject("ExcluirBT.Image"), System.Drawing.Image)
        Me.ExcluirBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirBT.Name = "ExcluirBT"
        Me.ExcluirBT.Size = New System.Drawing.Size(52, 65)
        Me.ExcluirBT.Text = "Excluir"
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
        Me.LocalizarBT.Size = New System.Drawing.Size(55, 65)
        Me.LocalizarBT.Text = "Localizar"
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
        'CadFuncionarioBT
        '
        Me.CadFuncionarioBT.Image = CType(resources.GetObject("CadFuncionarioBT.Image"), System.Drawing.Image)
        Me.CadFuncionarioBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CadFuncionarioBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CadFuncionarioBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CadFuncionarioBT.Name = "CadFuncionarioBT"
        Me.CadFuncionarioBT.Size = New System.Drawing.Size(99, 65)
        Me.CadFuncionarioBT.Text = "Cad. Funcionário"
        Me.CadFuncionarioBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CadFuncionarioBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TotDebito
        '
        Me.TotDebito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotDebito.CasasDecimais = 0
        Me.TotDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotDebito.CPObrigatorio = False
        Me.TotDebito.CPObrigatorioMsg = Nothing
        Me.TotDebito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotDebito.FocusColor = System.Drawing.Color.Empty
        Me.TotDebito.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotDebito.Location = New System.Drawing.Point(117, 420)
        Me.TotDebito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotDebito.MaxLength = 10
        Me.TotDebito.Name = "TotDebito"
        Me.TotDebito.RegraValidação = Nothing
        Me.TotDebito.RegraValidaçãoMensagem = Nothing
        Me.TotDebito.Size = New System.Drawing.Size(75, 20)
        Me.TotDebito.TabIndex = 175
        Me.TotDebito.TabStop = False
        Me.TotDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotDebito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotDebito.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(32, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Total Débito"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotCredito
        '
        Me.TotCredito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotCredito.CasasDecimais = 0
        Me.TotCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotCredito.CPObrigatorio = False
        Me.TotCredito.CPObrigatorioMsg = Nothing
        Me.TotCredito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotCredito.FocusColor = System.Drawing.Color.Empty
        Me.TotCredito.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotCredito.Location = New System.Drawing.Point(309, 421)
        Me.TotCredito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotCredito.MaxLength = 10
        Me.TotCredito.Name = "TotCredito"
        Me.TotCredito.RegraValidação = Nothing
        Me.TotCredito.RegraValidaçãoMensagem = Nothing
        Me.TotCredito.Size = New System.Drawing.Size(75, 20)
        Me.TotCredito.TabIndex = 177
        Me.TotCredito.TabStop = False
        Me.TotCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotCredito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotCredito.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(216, 421)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Total Crédito"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColEvento, Me.ColHistorico, Me.ColRef, Me.ColDebito, Me.ColCredito, Me.ColConfirmado, Me.ColUsuario, Me.ColProtegido})
        Me.MyLista.ContextMenuStrip = Me.MenuItens
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(11, 220)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(611, 193)
        Me.MyLista.TabIndex = 179
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 0
        '
        'ColEvento
        '
        Me.ColEvento.Text = "Evento"
        Me.ColEvento.Width = 47
        '
        'ColHistorico
        '
        Me.ColHistorico.Text = "Histórico"
        Me.ColHistorico.Width = 249
        '
        'ColRef
        '
        Me.ColRef.Text = "REF"
        Me.ColRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColRef.Width = 34
        '
        'ColDebito
        '
        Me.ColDebito.Text = "Valor Débito"
        Me.ColDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColDebito.Width = 91
        '
        'ColCredito
        '
        Me.ColCredito.Text = "Valor Crédito"
        Me.ColCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColCredito.Width = 89
        '
        'ColConfirmado
        '
        Me.ColConfirmado.Text = "Confirmado"
        Me.ColConfirmado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColConfirmado.Width = 0
        '
        'ColUsuario
        '
        Me.ColUsuario.Text = "Usuário"
        Me.ColUsuario.Width = 77
        '
        'ColProtegido
        '
        Me.ColProtegido.Width = 0
        '
        'MenuItens
        '
        Me.MenuItens.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoItemNaFolhaDePagamentoToolStripMenuItem, Me.ExcluirItemSelecionadoToolStripMenuItem})
        Me.MenuItens.Name = "MenuItens"
        Me.MenuItens.Size = New System.Drawing.Size(259, 48)
        '
        'NovoItemNaFolhaDePagamentoToolStripMenuItem
        '
        Me.NovoItemNaFolhaDePagamentoToolStripMenuItem.Name = "NovoItemNaFolhaDePagamentoToolStripMenuItem"
        Me.NovoItemNaFolhaDePagamentoToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.NovoItemNaFolhaDePagamentoToolStripMenuItem.Text = "Novo Item na Folha de Pagamento"
        '
        'ExcluirItemSelecionadoToolStripMenuItem
        '
        Me.ExcluirItemSelecionadoToolStripMenuItem.Name = "ExcluirItemSelecionadoToolStripMenuItem"
        Me.ExcluirItemSelecionadoToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.ExcluirItemSelecionadoToolStripMenuItem.Text = "Excluir Item Selecionado"
        '
        'Liquido
        '
        Me.Liquido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Liquido.CasasDecimais = 0
        Me.Liquido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Liquido.CPObrigatorio = False
        Me.Liquido.CPObrigatorioMsg = Nothing
        Me.Liquido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Liquido.FocusColor = System.Drawing.Color.Empty
        Me.Liquido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Liquido.Location = New System.Drawing.Point(523, 421)
        Me.Liquido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Liquido.MaxLength = 10
        Me.Liquido.Name = "Liquido"
        Me.Liquido.RegraValidação = Nothing
        Me.Liquido.RegraValidaçãoMensagem = Nothing
        Me.Liquido.Size = New System.Drawing.Size(75, 20)
        Me.Liquido.TabIndex = 180
        Me.Liquido.TabStop = False
        Me.Liquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Liquido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Liquido.ValorPadrao = Nothing
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(438, 421)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 25)
        Me.Label10.TabIndex = 181
        Me.Label10.Text = "Total Liquido"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.TipoGeradorBT)
        Me.Fundo.Controls.Add(Me.Liquido)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.MesCompetencia)
        Me.Fundo.Controls.Add(Me.SemFoto)
        Me.Fundo.Controls.Add(Me.Modulo)
        Me.Fundo.Controls.Add(Me.TotCredito)
        Me.Fundo.Controls.Add(Me.PainelFuncionario)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Display)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.TotDebito)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(631, 450)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 182
        Me.Fundo.Text = "PanelEx1"
        '
        'SemFoto
        '
        Me.SemFoto.BackColor = System.Drawing.Color.Transparent
        Me.SemFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SemFoto.Image = CType(resources.GetObject("SemFoto.Image"), System.Drawing.Image)
        Me.SemFoto.Location = New System.Drawing.Point(583, 163)
        Me.SemFoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SemFoto.Name = "SemFoto"
        Me.SemFoto.Size = New System.Drawing.Size(39, 46)
        Me.SemFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SemFoto.TabIndex = 173
        Me.SemFoto.TabStop = False
        Me.SemFoto.Visible = False
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.Color.Transparent
        Me.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Display.Location = New System.Drawing.Point(510, 74)
        Me.Display.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(112, 139)
        Me.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Display.TabIndex = 172
        Me.Display.TabStop = False
        '
        'btRecibo
        '
        Me.btRecibo.Image = CType(resources.GetObject("btRecibo.Image"), System.Drawing.Image)
        Me.btRecibo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btRecibo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btRecibo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRecibo.Name = "btRecibo"
        Me.btRecibo.Size = New System.Drawing.Size(52, 65)
        Me.btRecibo.Text = "Recibo"
        Me.btRecibo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FolhaPgtoVisualizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(631, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoVisualizador"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizador da Folha de Pagamento"
        Me.MenuTipoGerador.ResumeLayout(False)
        Me.PainelFuncionario.ResumeLayout(False)
        Me.PainelFuncionario.PerformLayout()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.MenuItens.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        CType(Me.SemFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TipoGeradorBT As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MesCompetencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Modulo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuTipoGerador As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MensalDiaristaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FériasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DécimoTerceiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PgtoPISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecisãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValeQuinzenalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PainelFuncionario As System.Windows.Forms.Panel
    Friend WithEvents Salario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SalarioRegistro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Profissão As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataAdmissão As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FuncionarioDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Funcionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SemFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Display As System.Windows.Forms.PictureBox
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents TotDebito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TotCredito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColHistorico As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColRef As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDebito As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColCredito As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColConfirmado As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColUsuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents CadFuncionarioBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Liquido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MenuItens As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NovoItemNaFolhaDePagamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirItemSelecionadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodPlanoContas As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColProtegido As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btRecibo As System.Windows.Forms.ToolStripButton
End Class
