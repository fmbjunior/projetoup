<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChequePreClientes
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
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColCheque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColTitular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColEntreguePor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColValorCh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColVencimento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPedido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDataFin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColFinan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuListaCheque = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirChequeSelecionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarParaFinanceiraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.TxtProcurar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.CC = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NCheque = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CaixaUser = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btNovoLancamento = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A6 = New System.Windows.Forms.RadioButton()
        Me.A5 = New System.Windows.Forms.RadioButton()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuListaCheque.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColCheque, Me.ColCC, Me.ColTitular, Me.ColEntreguePor, Me.ColValorCh, Me.ColVencimento, Me.ColPedido, Me.ColStatus, Me.ColDataFin, Me.ColFinan})
        Me.MyLista.ContextMenuStrip = Me.MenuListaCheque
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 7.0!)
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.Location = New System.Drawing.Point(12, 123)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(1035, 412)
        Me.MyLista.TabIndex = 1
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColCheque
        '
        Me.ColCheque.Text = "Cheque"
        Me.ColCheque.Width = 70
        '
        'ColCC
        '
        Me.ColCC.Text = "C/C"
        Me.ColCC.Width = 75
        '
        'ColTitular
        '
        Me.ColTitular.Text = "Titular"
        Me.ColTitular.Width = 174
        '
        'ColEntreguePor
        '
        Me.ColEntreguePor.Text = "EntreguePor"
        Me.ColEntreguePor.Width = 155
        '
        'ColValorCh
        '
        Me.ColValorCh.Text = "Vlr Cheque"
        Me.ColValorCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColValorCh.Width = 80
        '
        'ColVencimento
        '
        Me.ColVencimento.Text = "Vencimento"
        Me.ColVencimento.Width = 86
        '
        'ColPedido
        '
        Me.ColPedido.Text = "Pedido"
        '
        'ColStatus
        '
        Me.ColStatus.Text = "Status"
        Me.ColStatus.Width = 90
        '
        'ColDataFin
        '
        Me.ColDataFin.Text = "Dt. Env. Fin"
        Me.ColDataFin.Width = 79
        '
        'ColFinan
        '
        Me.ColFinan.Text = "Financeira"
        Me.ColFinan.Width = 150
        '
        'MenuListaCheque
        '
        Me.MenuListaCheque.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirChequeSelecionadoToolStripMenuItem, Me.EnviarParaFinanceiraToolStripMenuItem})
        Me.MenuListaCheque.Name = "MenuListaCheque"
        Me.MenuListaCheque.Size = New System.Drawing.Size(220, 48)
        '
        'ExcluirChequeSelecionadoToolStripMenuItem
        '
        Me.ExcluirChequeSelecionadoToolStripMenuItem.Enabled = False
        Me.ExcluirChequeSelecionadoToolStripMenuItem.Name = "ExcluirChequeSelecionadoToolStripMenuItem"
        Me.ExcluirChequeSelecionadoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ExcluirChequeSelecionadoToolStripMenuItem.Text = "Excluir Cheque Selecionado"
        '
        'EnviarParaFinanceiraToolStripMenuItem
        '
        Me.EnviarParaFinanceiraToolStripMenuItem.Name = "EnviarParaFinanceiraToolStripMenuItem"
        Me.EnviarParaFinanceiraToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.EnviarParaFinanceiraToolStripMenuItem.Text = "Enviar para financeira"
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(177, 3)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(91, 19)
        Me.A3.TabIndex = 3
        Me.A3.TabStop = True
        Me.A3.Text = "Entregue Por"
        Me.A3.UseVisualStyleBackColor = True
        '
        'TxtProcurar
        '
        Me.TxtProcurar.AceitaColarTexto = True
        Me.TxtProcurar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TxtProcurar.CasasDecimais = 0
        Me.TxtProcurar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcurar.CPObrigatorio = False
        Me.TxtProcurar.CPObrigatorioMsg = Nothing
        Me.TxtProcurar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TxtProcurar.FlatBorder = False
        Me.TxtProcurar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TxtProcurar.FocusColor = System.Drawing.Color.MistyRose
        Me.TxtProcurar.FocusColorEnd = System.Drawing.Color.Empty
        Me.TxtProcurar.HighlightBorderOnEnter = False
        Me.TxtProcurar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TxtProcurar.Location = New System.Drawing.Point(3, 28)
        Me.TxtProcurar.Name = "TxtProcurar"
        Me.TxtProcurar.PreencherZeroEsqueda = False
        Me.TxtProcurar.RegraValidação = Nothing
        Me.TxtProcurar.RegraValidaçãoMensagem = Nothing
        Me.TxtProcurar.Size = New System.Drawing.Size(517, 23)
        Me.TxtProcurar.TabIndex = 2
        Me.TxtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcurar.ValorPadrao = Nothing
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(91, 3)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(80, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Por Titular"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(82, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Por Cheque"
        Me.A1.UseVisualStyleBackColor = True
        '
        'CC
        '
        Me.CC.AceitaColarTexto = True
        Me.CC.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CC.CasasDecimais = 0
        Me.CC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CC.CPObrigatorio = False
        Me.CC.CPObrigatorioMsg = Nothing
        Me.CC.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CC.FlatBorder = False
        Me.CC.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CC.FocusColor = System.Drawing.Color.MistyRose
        Me.CC.FocusColorEnd = System.Drawing.Color.Empty
        Me.CC.HighlightBorderOnEnter = False
        Me.CC.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CC.Location = New System.Drawing.Point(415, 541)
        Me.CC.Name = "CC"
        Me.CC.PreencherZeroEsqueda = False
        Me.CC.RegraValidação = Nothing
        Me.CC.RegraValidaçãoMensagem = Nothing
        Me.CC.Size = New System.Drawing.Size(75, 23)
        Me.CC.TabIndex = 8
        Me.CC.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CC.ValorPadrao = Nothing
        Me.CC.Visible = False
        '
        'NCheque
        '
        Me.NCheque.AceitaColarTexto = True
        Me.NCheque.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NCheque.CasasDecimais = 0
        Me.NCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NCheque.CPObrigatorio = False
        Me.NCheque.CPObrigatorioMsg = Nothing
        Me.NCheque.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NCheque.FlatBorder = False
        Me.NCheque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NCheque.FocusColor = System.Drawing.Color.MistyRose
        Me.NCheque.FocusColorEnd = System.Drawing.Color.Empty
        Me.NCheque.HighlightBorderOnEnter = False
        Me.NCheque.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NCheque.Location = New System.Drawing.Point(498, 541)
        Me.NCheque.Name = "NCheque"
        Me.NCheque.PreencherZeroEsqueda = False
        Me.NCheque.RegraValidação = Nothing
        Me.NCheque.RegraValidaçãoMensagem = Nothing
        Me.NCheque.Size = New System.Drawing.Size(75, 23)
        Me.NCheque.TabIndex = 9
        Me.NCheque.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NCheque.ValorPadrao = Nothing
        Me.NCheque.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label21)
        Me.Fundo.Controls.Add(Me.CaixaUser)
        Me.Fundo.Controls.Add(Me.Label)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Panel1)
        Me.Fundo.Controls.Add(Me.btNovoLancamento)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.NCheque)
        Me.Fundo.Controls.Add(Me.CC)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(1059, 572)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(849, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(198, 19)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Pressione [F10] para mudar o caixa"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CaixaUser
        '
        Me.CaixaUser.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaUser.Location = New System.Drawing.Point(101, 9)
        Me.CaixaUser.Name = "CaixaUser"
        Me.CaixaUser.Size = New System.Drawing.Size(199, 15)
        Me.CaixaUser.TabIndex = 18
        Me.CaixaUser.Text = "Caixa Ativo"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(10, 9)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(88, 19)
        Me.Label.TabIndex = 16
        Me.Label.Text = "Caixa Ativo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 538)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Contas vencidas"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(13, 541)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 10)
        Me.Panel1.TabIndex = 14
        '
        'btNovoLancamento
        '
        Me.btNovoLancamento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovoLancamento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovoLancamento.Location = New System.Drawing.Point(860, 540)
        Me.btNovoLancamento.Name = "btNovoLancamento"
        Me.btNovoLancamento.Size = New System.Drawing.Size(104, 24)
        Me.btNovoLancamento.TabIndex = 13
        Me.btNovoLancamento.Text = "Novo Lançamento"
        Me.btNovoLancamento.Visible = False
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(970, 540)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(77, 24)
        Me.btFechar.TabIndex = 12
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A6)
        Me.GroupPanel1.Controls.Add(Me.TxtProcurar)
        Me.GroupPanel1.Controls.Add(Me.A5)
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 37)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1035, 80)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 11
        Me.GroupPanel1.Text = "Selecione uma das Opções"
        '
        'A6
        '
        Me.A6.AutoSize = True
        Me.A6.Location = New System.Drawing.Point(465, 3)
        Me.A6.Name = "A6"
        Me.A6.Size = New System.Drawing.Size(55, 19)
        Me.A6.TabIndex = 6
        Me.A6.TabStop = True
        Me.A6.Text = "Todos"
        Me.A6.UseVisualStyleBackColor = True
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(384, 3)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(75, 19)
        Me.A5.TabIndex = 5
        Me.A5.TabStop = True
        Me.A5.Text = "Por Valor "
        Me.A5.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(274, 3)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(104, 19)
        Me.A4.TabIndex = 4
        Me.A4.TabStop = True
        Me.A4.Text = "Por Vencimento"
        Me.A4.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ChequePreClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1059, 572)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChequePreClientes"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheques Pre-Datados de Clientes - T112"
        Me.MenuListaCheque.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents TxtProcurar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColCheque As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColCC As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTitular As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColValorCh As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColVencimento As System.Windows.Forms.ColumnHeader
    Friend WithEvents CC As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NCheque As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents ColEntreguePor As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuListaCheque As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirChequeSelecionadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents A6 As System.Windows.Forms.RadioButton
    Friend WithEvents btNovoLancamento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ColPedido As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents CaixaUser As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ColDataFin As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColFinan As System.Windows.Forms.ColumnHeader
    Friend WithEvents EnviarParaFinanceiraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
