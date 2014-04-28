<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receber
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receber))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IdSelecionado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuAuxiliar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProrrogarContaSelecionadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarContasProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivaEDesativarComoContaPerdiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarLocalDePagamentoDaContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarDataDeVencimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Total = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PainelOcorrencia = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btAdd = New DevComponents.DotNetBar.ButtonX()
        Me.Ocorrencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btFindClintes = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btOcorrencia = New DevComponents.DotNetBar.ButtonX()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.VisualizarVinculoDeAgrupamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.g_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_nf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_controle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_datadoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_vencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_pro = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.g_virtual = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.g_perdida = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.g_origem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdAgrupamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuAuxiliar.SuspendLayout()
        Me.PainelOcorrencia.SuspendLayout()
        Me.Fundo.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdSelecionado
        '
        Me.IdSelecionado.AceitaColarTexto = True
        Me.IdSelecionado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.IdSelecionado.CasasDecimais = 0
        Me.IdSelecionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdSelecionado.CPObrigatorio = False
        Me.IdSelecionado.CPObrigatorioMsg = Nothing
        Me.IdSelecionado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdSelecionado.FlatBorder = False
        Me.IdSelecionado.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdSelecionado.FocusColor = System.Drawing.Color.Empty
        Me.IdSelecionado.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdSelecionado.HighlightBorderOnEnter = False
        Me.IdSelecionado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdSelecionado.Location = New System.Drawing.Point(625, 530)
        Me.IdSelecionado.Name = "IdSelecionado"
        Me.IdSelecionado.PreencherZeroEsqueda = False
        Me.IdSelecionado.RegraValidação = Nothing
        Me.IdSelecionado.RegraValidaçãoMensagem = Nothing
        Me.IdSelecionado.Size = New System.Drawing.Size(81, 23)
        Me.IdSelecionado.TabIndex = 14
        Me.IdSelecionado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdSelecionado.ValorPadrao = Nothing
        Me.IdSelecionado.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(51, 475)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Duplo Click no Documento para baixa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuAuxiliar
        '
        Me.MenuAuxiliar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProrrogarContaSelecionadaToolStripMenuItem, Me.MostrarContasProToolStripMenuItem, Me.ColoToolStripMenuItem, Me.AtivaEDesativarComoContaPerdiaToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.AlterarLocalDePagamentoDaContaToolStripMenuItem, Me.AlterarDataDeVencimentoToolStripMenuItem, Me.VisualizarVinculoDeAgrupamentoToolStripMenuItem})
        Me.MenuAuxiliar.Name = "MenuAuxiliar"
        Me.MenuAuxiliar.Size = New System.Drawing.Size(278, 180)
        '
        'ProrrogarContaSelecionadaToolStripMenuItem
        '
        Me.ProrrogarContaSelecionadaToolStripMenuItem.Name = "ProrrogarContaSelecionadaToolStripMenuItem"
        Me.ProrrogarContaSelecionadaToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ProrrogarContaSelecionadaToolStripMenuItem.Text = "Prorrogar Conta Selecionada"
        '
        'MostrarContasProToolStripMenuItem
        '
        Me.MostrarContasProToolStripMenuItem.Name = "MostrarContasProToolStripMenuItem"
        Me.MostrarContasProToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.MostrarContasProToolStripMenuItem.Text = "Mostrar Contas Prorrogadas para Hoje"
        '
        'ColoToolStripMenuItem
        '
        Me.ColoToolStripMenuItem.Name = "ColoToolStripMenuItem"
        Me.ColoToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ColoToolStripMenuItem.Text = "Cadastrar Ocorrência na Conta"
        '
        'AtivaEDesativarComoContaPerdiaToolStripMenuItem
        '
        Me.AtivaEDesativarComoContaPerdiaToolStripMenuItem.Name = "AtivaEDesativarComoContaPerdiaToolStripMenuItem"
        Me.AtivaEDesativarComoContaPerdiaToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.AtivaEDesativarComoContaPerdiaToolStripMenuItem.Text = "Ativar e Desativar como Conta Perdida"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir Recebimento Avulso"
        '
        'AlterarLocalDePagamentoDaContaToolStripMenuItem
        '
        Me.AlterarLocalDePagamentoDaContaToolStripMenuItem.Name = "AlterarLocalDePagamentoDaContaToolStripMenuItem"
        Me.AlterarLocalDePagamentoDaContaToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.AlterarLocalDePagamentoDaContaToolStripMenuItem.Text = "Alterar Local de Pagamento da Conta"
        '
        'AlterarDataDeVencimentoToolStripMenuItem
        '
        Me.AlterarDataDeVencimentoToolStripMenuItem.Name = "AlterarDataDeVencimentoToolStripMenuItem"
        Me.AlterarDataDeVencimentoToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.AlterarDataDeVencimentoToolStripMenuItem.Text = "Alterar Data de Vencimento"
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = True
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteDesc.FlatBorder = False
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.FocusColor = System.Drawing.Color.Empty
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(187, 9)
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(722, 23)
        Me.ClienteDesc.TabIndex = 2
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(90, 9)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(72, 23)
        Me.Cliente.TabIndex = 1
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(557, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total a Receber R$"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Total
        '
        Me.Total.AceitaColarTexto = True
        Me.Total.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Total.CasasDecimais = 2
        Me.Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Total.CPObrigatorio = False
        Me.Total.CPObrigatorioMsg = Nothing
        Me.Total.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Total.FlatBorder = False
        Me.Total.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Total.FocusColor = System.Drawing.Color.Empty
        Me.Total.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Total.HighlightBorderOnEnter = False
        Me.Total.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Total.Location = New System.Drawing.Point(723, 488)
        Me.Total.Name = "Total"
        Me.Total.PreencherZeroEsqueda = False
        Me.Total.RegraValidação = Nothing
        Me.Total.RegraValidaçãoMensagem = Nothing
        Me.Total.Size = New System.Drawing.Size(180, 26)
        Me.Total.TabIndex = 7
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Total.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(51, 519)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(328, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Conta em Atraso"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(51, 498)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(328, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Conta marcada como Perdida"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PainelOcorrencia
        '
        Me.PainelOcorrencia.BackColor = System.Drawing.Color.SteelBlue
        Me.PainelOcorrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PainelOcorrencia.Controls.Add(Me.Label7)
        Me.PainelOcorrencia.Controls.Add(Me.btCancelar)
        Me.PainelOcorrencia.Controls.Add(Me.btAdd)
        Me.PainelOcorrencia.Controls.Add(Me.Ocorrencia)
        Me.PainelOcorrencia.Location = New System.Drawing.Point(12, 421)
        Me.PainelOcorrencia.Name = "PainelOcorrencia"
        Me.PainelOcorrencia.Size = New System.Drawing.Size(890, 51)
        Me.PainelOcorrencia.TabIndex = 5
        Me.PainelOcorrencia.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(321, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Informe a Ocorrência"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btCancelar
        '
        Me.btCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCancelar.Location = New System.Drawing.Point(823, 23)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(59, 23)
        Me.btCancelar.TabIndex = 3
        Me.btCancelar.Text = "Cancelar"
        '
        'btAdd
        '
        Me.btAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdd.Location = New System.Drawing.Point(773, 23)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(44, 23)
        Me.btAdd.TabIndex = 2
        Me.btAdd.Text = "Add"
        '
        'Ocorrencia
        '
        Me.Ocorrencia.AceitaColarTexto = True
        Me.Ocorrencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ocorrencia.CasasDecimais = 0
        Me.Ocorrencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ocorrencia.CPObrigatorio = False
        Me.Ocorrencia.CPObrigatorioMsg = Nothing
        Me.Ocorrencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ocorrencia.FlatBorder = False
        Me.Ocorrencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Ocorrencia.FocusColor = System.Drawing.Color.Empty
        Me.Ocorrencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ocorrencia.HighlightBorderOnEnter = False
        Me.Ocorrencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Ocorrencia.Location = New System.Drawing.Point(3, 23)
        Me.Ocorrencia.MaxLength = 250
        Me.Ocorrencia.Name = "Ocorrencia"
        Me.Ocorrencia.PreencherZeroEsqueda = False
        Me.Ocorrencia.RegraValidação = Nothing
        Me.Ocorrencia.RegraValidaçãoMensagem = Nothing
        Me.Ocorrencia.Size = New System.Drawing.Size(764, 23)
        Me.Ocorrencia.TabIndex = 1
        Me.Ocorrencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ocorrencia.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.PainelOcorrencia)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.btFindClintes)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.btOcorrencia)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Cliente)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.ClienteDesc)
        Me.Fundo.Controls.Add(Me.Total)
        Me.Fundo.Controls.Add(Me.IdSelecionado)
        Me.Fundo.Controls.Add(Me.dgvItem)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(921, 560)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(20, 517)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "      "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(20, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "      "
        '
        'btFindClintes
        '
        Me.btFindClintes.Image = CType(resources.GetObject("btFindClintes.Image"), System.Drawing.Image)
        Me.btFindClintes.Location = New System.Drawing.Point(163, 9)
        Me.btFindClintes.Name = "btFindClintes"
        Me.btFindClintes.Size = New System.Drawing.Size(23, 23)
        Me.btFindClintes.TabIndex = 27
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(815, 521)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(96, 31)
        Me.btFechar.TabIndex = 9
        Me.btFechar.Text = "Fechar"
        '
        'btOcorrencia
        '
        Me.btOcorrencia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btOcorrencia.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btOcorrencia.Location = New System.Drawing.Point(712, 521)
        Me.btOcorrencia.Name = "btOcorrencia"
        Me.btOcorrencia.Size = New System.Drawing.Size(97, 31)
        Me.btOcorrencia.TabIndex = 8
        Me.btOcorrencia.Text = "Ocorrências"
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.AllowUserToResizeColumns = False
        Me.dgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItem.BackgroundColor = System.Drawing.Color.White
        Me.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItem.ColumnHeadersHeight = 18
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.g_id, Me.g_documento, Me.g_nf, Me.g_controle, Me.g_cliente, Me.g_datadoc, Me.g_vencimento, Me.g_valor, Me.g_pro, Me.g_virtual, Me.g_perdida, Me.g_origem, Me.cIdAgrupamento})
        Me.dgvItem.ContextMenuStrip = Me.MenuAuxiliar
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItem.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItem.EnableHeadersVisualStyles = False
        Me.dgvItem.Location = New System.Drawing.Point(7, 38)
        Me.dgvItem.MultiSelect = False
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.RowHeadersVisible = False
        Me.dgvItem.RowHeadersWidth = 15
        Me.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItem.Size = New System.Drawing.Size(902, 434)
        Me.dgvItem.TabIndex = 28
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'VisualizarVinculoDeAgrupamentoToolStripMenuItem
        '
        Me.VisualizarVinculoDeAgrupamentoToolStripMenuItem.Name = "VisualizarVinculoDeAgrupamentoToolStripMenuItem"
        Me.VisualizarVinculoDeAgrupamentoToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.VisualizarVinculoDeAgrupamentoToolStripMenuItem.Text = "Visualizar Vinculo de Agrupamento"
        '
        'g_id
        '
        Me.g_id.DataPropertyName = "id"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.g_id.DefaultCellStyle = DataGridViewCellStyle3
        Me.g_id.HeaderText = "ID"
        Me.g_id.Name = "g_id"
        Me.g_id.Visible = False
        '
        'g_documento
        '
        Me.g_documento.DataPropertyName = "documento"
        Me.g_documento.FillWeight = 70.0!
        Me.g_documento.HeaderText = "Documento"
        Me.g_documento.Name = "g_documento"
        Me.g_documento.Width = 90
        '
        'g_nf
        '
        Me.g_nf.DataPropertyName = "notafiscal"
        Me.g_nf.HeaderText = "NF"
        Me.g_nf.Name = "g_nf"
        Me.g_nf.Width = 80
        '
        'g_controle
        '
        Me.g_controle.DataPropertyName = "controlepedido"
        Me.g_controle.FillWeight = 90.0!
        Me.g_controle.HeaderText = "Controle"
        Me.g_controle.Name = "g_controle"
        Me.g_controle.Width = 90
        '
        'g_cliente
        '
        Me.g_cliente.DataPropertyName = "cliente"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.NullValue = Nothing
        Me.g_cliente.DefaultCellStyle = DataGridViewCellStyle4
        Me.g_cliente.HeaderText = "Cliente"
        Me.g_cliente.Name = "g_cliente"
        Me.g_cliente.Width = 250
        '
        'g_datadoc
        '
        Me.g_datadoc.DataPropertyName = "datadocumento"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.NullValue = Nothing
        Me.g_datadoc.DefaultCellStyle = DataGridViewCellStyle5
        Me.g_datadoc.HeaderText = "Data Doc"
        Me.g_datadoc.Name = "g_datadoc"
        Me.g_datadoc.Width = 90
        '
        'g_vencimento
        '
        Me.g_vencimento.DataPropertyName = "vencimento"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.g_vencimento.DefaultCellStyle = DataGridViewCellStyle6
        Me.g_vencimento.HeaderText = "Vencimento"
        Me.g_vencimento.Name = "g_vencimento"
        '
        'g_valor
        '
        Me.g_valor.DataPropertyName = "valordocumento"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.g_valor.DefaultCellStyle = DataGridViewCellStyle7
        Me.g_valor.HeaderText = "Valor"
        Me.g_valor.Name = "g_valor"
        '
        'g_pro
        '
        Me.g_pro.DataPropertyName = "prorrogada"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "Não"
        DataGridViewCellStyle8.NullValue = False
        Me.g_pro.DefaultCellStyle = DataGridViewCellStyle8
        Me.g_pro.HeaderText = "PRO"
        Me.g_pro.Name = "g_pro"
        Me.g_pro.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.g_pro.Width = 40
        '
        'g_virtual
        '
        Me.g_virtual.DataPropertyName = "virtual"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = False
        Me.g_virtual.DefaultCellStyle = DataGridViewCellStyle9
        Me.g_virtual.HeaderText = "Virtual"
        Me.g_virtual.Name = "g_virtual"
        Me.g_virtual.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_virtual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.g_virtual.Width = 50
        '
        'g_perdida
        '
        Me.g_perdida.DataPropertyName = "ContaPerdida"
        Me.g_perdida.HeaderText = "perdida"
        Me.g_perdida.Name = "g_perdida"
        Me.g_perdida.Visible = False
        '
        'g_origem
        '
        Me.g_origem.DataPropertyName = "origem"
        Me.g_origem.HeaderText = "origem"
        Me.g_origem.Name = "g_origem"
        Me.g_origem.Visible = False
        '
        'cIdAgrupamento
        '
        Me.cIdAgrupamento.DataPropertyName = "IdAgrupamento"
        Me.cIdAgrupamento.HeaderText = "IdAgrupamento"
        Me.cIdAgrupamento.Name = "cIdAgrupamento"
        Me.cIdAgrupamento.Visible = False
        '
        'Receber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(921, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Receber"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta e Baixa de Contas a Receber - T058"
        Me.MenuAuxiliar.ResumeLayout(False)
        Me.PainelOcorrencia.ResumeLayout(False)
        Me.PainelOcorrencia.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IdSelecionado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Total As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuAuxiliar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MostrarContasProToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PainelOcorrencia As System.Windows.Forms.Panel
    Friend WithEvents Ocorrencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btOcorrencia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFindClintes As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents AtivaEDesativarComoContaPerdiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ExcluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProrrogarContaSelecionadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarLocalDePagamentoDaContaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarDataDeVencimentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizarVinculoDeAgrupamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents g_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_nf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_controle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_datadoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_vencimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_pro As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents g_virtual As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents g_perdida As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents g_origem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIdAgrupamento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
