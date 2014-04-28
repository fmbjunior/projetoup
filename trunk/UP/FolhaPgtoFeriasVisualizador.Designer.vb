<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoFeriasVisualizador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoFeriasVisualizador))
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColId = New System.Windows.Forms.ColumnHeader
        Me.ColPeriodo1 = New System.Windows.Forms.ColumnHeader
        Me.ColPeriodo2 = New System.Windows.Forms.ColumnHeader
        Me.ColDiasTotal = New System.Windows.Forms.ColumnHeader
        Me.ColDiasGozo = New System.Windows.Forms.ColumnHeader
        Me.ColDataInicial = New System.Windows.Forms.ColumnHeader
        Me.ColDataFinal = New System.Windows.Forms.ColumnHeader
        Me.ColSalarioReg = New System.Windows.Forms.ColumnHeader
        Me.ColSalarioDif = New System.Windows.Forms.ColumnHeader
        Me.ColVariaveis = New System.Windows.Forms.ColumnHeader
        Me.ColValorFerias = New System.Windows.Forms.ColumnHeader
        Me.ColValorInss = New System.Windows.Forms.ColumnHeader
        Me.colVlrLiquido = New System.Windows.Forms.ColumnHeader
        Me.ColPago = New System.Windows.Forms.ColumnHeader
        Me.ctMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirLançamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarLançamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.CadFuncionarioBT = New System.Windows.Forms.ToolStripButton
        Me.AddPeriodoBT = New System.Windows.Forms.ToolStripButton
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.FuncionarioDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Funcionario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataAdmissao = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataRecisao = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cpf = New TexBoxFocusNet.TextBoxFocusNet
        Me.SalarioReg = New TexBoxFocusNet.TextBoxFocusNet
        Me.SalarioDif = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.pagarFerias = New DevComponents.DotNetBar.ButtonX
        Me.colVale = New System.Windows.Forms.ColumnHeader
        Me.ctMenu.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColPeriodo1, Me.ColPeriodo2, Me.ColDiasTotal, Me.ColDiasGozo, Me.ColDataInicial, Me.ColDataFinal, Me.ColSalarioReg, Me.ColSalarioDif, Me.ColVariaveis, Me.ColValorFerias, Me.ColValorInss, Me.colVlrLiquido, Me.colVale, Me.ColPago})
        Me.MyLista.ContextMenuStrip = Me.ctMenu
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(3, 146)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(904, 397)
        Me.MyLista.TabIndex = 9
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 40
        '
        'ColPeriodo1
        '
        Me.ColPeriodo1.Text = "Per. Inicial"
        Me.ColPeriodo1.Width = 70
        '
        'ColPeriodo2
        '
        Me.ColPeriodo2.Text = "Per. Final"
        Me.ColPeriodo2.Width = 67
        '
        'ColDiasTotal
        '
        Me.ColDiasTotal.Text = "D. Total"
        Me.ColDiasTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColDiasTotal.Width = 53
        '
        'ColDiasGozo
        '
        Me.ColDiasGozo.Text = "D. Gozo"
        Me.ColDiasGozo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColDiasGozo.Width = 51
        '
        'ColDataInicial
        '
        Me.ColDataInicial.Text = "Início"
        Me.ColDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColDataInicial.Width = 67
        '
        'ColDataFinal
        '
        Me.ColDataFinal.Text = "Fim"
        Me.ColDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColDataFinal.Width = 61
        '
        'ColSalarioReg
        '
        Me.ColSalarioReg.Text = "Sal. Reg"
        Me.ColSalarioReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColSalarioReg.Width = 59
        '
        'ColSalarioDif
        '
        Me.ColSalarioDif.Text = "Sal. Dif"
        Me.ColSalarioDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColVariaveis
        '
        Me.ColVariaveis.Text = "Variáveis"
        Me.ColVariaveis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColValorFerias
        '
        Me.ColValorFerias.Text = "Valor Férias"
        Me.ColValorFerias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColValorFerias.Width = 74
        '
        'ColValorInss
        '
        Me.ColValorInss.Text = "Valor Inss"
        Me.ColValorInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColValorInss.Width = 64
        '
        'colVlrLiquido
        '
        Me.colVlrLiquido.Text = "Vlr. Liquido"
        Me.colVlrLiquido.Width = 72
        '
        'ColPago
        '
        Me.ColPago.Text = "Pago"
        Me.ColPago.Width = 36
        '
        'ctMenu
        '
        Me.ctMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirLançamentoToolStripMenuItem, Me.EditarLançamentoToolStripMenuItem})
        Me.ctMenu.Name = "ContextMenuStrip1"
        Me.ctMenu.Size = New System.Drawing.Size(187, 48)
        Me.ctMenu.Text = "Focus"
        '
        'ExcluirLançamentoToolStripMenuItem
        '
        Me.ExcluirLançamentoToolStripMenuItem.Name = "ExcluirLançamentoToolStripMenuItem"
        Me.ExcluirLançamentoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExcluirLançamentoToolStripMenuItem.Text = "Excluir Lançamento..."
        '
        'EditarLançamentoToolStripMenuItem
        '
        Me.EditarLançamentoToolStripMenuItem.Name = "EditarLançamentoToolStripMenuItem"
        Me.EditarLançamentoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.EditarLançamentoToolStripMenuItem.Text = "Editar Lançamento..."
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadFuncionarioBT, Me.AddPeriodoBT, Me.LocalizarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(912, 68)
        Me.BarraBt.TabIndex = 10
        Me.BarraBt.Text = "ToolStrip1"
        '
        'CadFuncionarioBT
        '
        Me.CadFuncionarioBT.Image = CType(resources.GetObject("CadFuncionarioBT.Image"), System.Drawing.Image)
        Me.CadFuncionarioBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CadFuncionarioBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CadFuncionarioBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CadFuncionarioBT.Name = "CadFuncionarioBT"
        Me.CadFuncionarioBT.Size = New System.Drawing.Size(104, 65)
        Me.CadFuncionarioBT.Text = "Cad. Funcionários"
        Me.CadFuncionarioBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CadFuncionarioBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AddPeriodoBT
        '
        Me.AddPeriodoBT.Image = CType(resources.GetObject("AddPeriodoBT.Image"), System.Drawing.Image)
        Me.AddPeriodoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddPeriodoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddPeriodoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddPeriodoBT.Name = "AddPeriodoBT"
        Me.AddPeriodoBT.Size = New System.Drawing.Size(78, 65)
        Me.AddPeriodoBT.Text = "Add. Período"
        Me.AddPeriodoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddPeriodoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'FuncionarioDesc
        '
        Me.FuncionarioDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FuncionarioDesc.CasasDecimais = 0
        Me.FuncionarioDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FuncionarioDesc.CPObrigatorio = False
        Me.FuncionarioDesc.CPObrigatorioMsg = Nothing
        Me.FuncionarioDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FuncionarioDesc.FocusColor = System.Drawing.Color.Empty
        Me.FuncionarioDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FuncionarioDesc.Location = New System.Drawing.Point(178, 90)
        Me.FuncionarioDesc.Name = "FuncionarioDesc"
        Me.FuncionarioDesc.RegraValidação = Nothing
        Me.FuncionarioDesc.RegraValidaçãoMensagem = Nothing
        Me.FuncionarioDesc.Size = New System.Drawing.Size(462, 20)
        Me.FuncionarioDesc.TabIndex = 2
        Me.FuncionarioDesc.TabStop = False
        Me.FuncionarioDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncionarioDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Funcionário"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Funcionario.Location = New System.Drawing.Point(116, 90)
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.RegraValidação = Nothing
        Me.Funcionario.RegraValidaçãoMensagem = Nothing
        Me.Funcionario.Size = New System.Drawing.Size(56, 20)
        Me.Funcionario.TabIndex = 1
        Me.Funcionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Funcionario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Funcionario.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(693, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Data Admissão"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataAdmissao
        '
        Me.DataAdmissao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataAdmissao.CasasDecimais = 0
        Me.DataAdmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataAdmissao.CPObrigatorio = False
        Me.DataAdmissao.CPObrigatorioMsg = Nothing
        Me.DataAdmissao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataAdmissao.FocusColor = System.Drawing.Color.Empty
        Me.DataAdmissao.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataAdmissao.Location = New System.Drawing.Point(790, 90)
        Me.DataAdmissao.MaxLength = 10
        Me.DataAdmissao.Name = "DataAdmissao"
        Me.DataAdmissao.RegraValidação = Nothing
        Me.DataAdmissao.RegraValidaçãoMensagem = Nothing
        Me.DataAdmissao.Size = New System.Drawing.Size(92, 20)
        Me.DataAdmissao.TabIndex = 6
        Me.DataAdmissao.TabStop = False
        Me.DataAdmissao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataAdmissao.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(693, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data Recisão"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataRecisao
        '
        Me.DataRecisao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataRecisao.CasasDecimais = 0
        Me.DataRecisao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataRecisao.CPObrigatorio = False
        Me.DataRecisao.CPObrigatorioMsg = Nothing
        Me.DataRecisao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataRecisao.FocusColor = System.Drawing.Color.Empty
        Me.DataRecisao.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataRecisao.Location = New System.Drawing.Point(790, 116)
        Me.DataRecisao.MaxLength = 10
        Me.DataRecisao.Name = "DataRecisao"
        Me.DataRecisao.RegraValidação = Nothing
        Me.DataRecisao.RegraValidaçãoMensagem = Nothing
        Me.DataRecisao.Size = New System.Drawing.Size(92, 20)
        Me.DataRecisao.TabIndex = 8
        Me.DataRecisao.TabStop = False
        Me.DataRecisao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataRecisao.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CPF"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cpf
        '
        Me.Cpf.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cpf.CasasDecimais = 0
        Me.Cpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cpf.CPObrigatorio = False
        Me.Cpf.CPObrigatorioMsg = Nothing
        Me.Cpf.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cpf.FocusColor = System.Drawing.Color.Empty
        Me.Cpf.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cpf.Location = New System.Drawing.Point(116, 116)
        Me.Cpf.Name = "Cpf"
        Me.Cpf.RegraValidação = Nothing
        Me.Cpf.RegraValidaçãoMensagem = Nothing
        Me.Cpf.Size = New System.Drawing.Size(169, 20)
        Me.Cpf.TabIndex = 4
        Me.Cpf.TabStop = False
        Me.Cpf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cpf.ValorPadrao = Nothing
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
        Me.SalarioReg.Location = New System.Drawing.Point(450, 119)
        Me.SalarioReg.MaxLength = 10
        Me.SalarioReg.Name = "SalarioReg"
        Me.SalarioReg.RegraValidação = Nothing
        Me.SalarioReg.RegraValidaçãoMensagem = Nothing
        Me.SalarioReg.Size = New System.Drawing.Size(92, 20)
        Me.SalarioReg.TabIndex = 11
        Me.SalarioReg.TabStop = False
        Me.SalarioReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioReg.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioReg.ValorPadrao = Nothing
        Me.SalarioReg.Visible = False
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
        Me.SalarioDif.Location = New System.Drawing.Point(548, 119)
        Me.SalarioDif.MaxLength = 10
        Me.SalarioDif.Name = "SalarioDif"
        Me.SalarioDif.RegraValidação = Nothing
        Me.SalarioDif.RegraValidaçãoMensagem = Nothing
        Me.SalarioDif.Size = New System.Drawing.Size(92, 20)
        Me.SalarioDif.TabIndex = 12
        Me.SalarioDif.TabStop = False
        Me.SalarioDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioDif.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioDif.ValorPadrao = Nothing
        Me.SalarioDif.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.pagarFerias)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.SalarioDif)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.SalarioReg)
        Me.Fundo.Controls.Add(Me.Funcionario)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Cpf)
        Me.Fundo.Controls.Add(Me.FuncionarioDesc)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.DataAdmissao)
        Me.Fundo.Controls.Add(Me.DataRecisao)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(912, 590)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 13
        '
        'pagarFerias
        '
        Me.pagarFerias.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.pagarFerias.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.pagarFerias.Location = New System.Drawing.Point(16, 550)
        Me.pagarFerias.Name = "pagarFerias"
        Me.pagarFerias.Size = New System.Drawing.Size(94, 28)
        Me.pagarFerias.TabIndex = 13
        Me.pagarFerias.Text = "Pagar Férias"
        '
        'colVale
        '
        Me.colVale.Text = "Vale"
        Me.colVale.Width = 48
        '
        'FolhaPgtoFeriasVisualizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoFeriasVisualizador"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizador de Férias"
        Me.ctMenu.ResumeLayout(False)
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPeriodo1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPeriodo2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDiasTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDiasGozo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDataInicial As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDataFinal As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSalarioReg As System.Windows.Forms.ColumnHeader
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents CadFuncionarioBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColSalarioDif As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColVariaveis As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColValorFerias As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColValorInss As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPago As System.Windows.Forms.ColumnHeader
    Friend WithEvents FuncionarioDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Funcionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataAdmissao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataRecisao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cpf As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents AddPeriodoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalarioReg As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents SalarioDif As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pagarFerias As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ctMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirLançamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarLançamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colVlrLiquido As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVale As System.Windows.Forms.ColumnHeader
End Class
