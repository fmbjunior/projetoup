<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaProcuraCtrlPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaProcuraCtrlPedido))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.Col1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoProcura = New System.Windows.Forms.GroupBox()
        Me.DocumentoFornecedor = New System.Windows.Forms.RadioButton()
        Me.MostraTodos = New System.Windows.Forms.RadioButton()
        Me.AlfaNumerica = New System.Windows.Forms.RadioButton()
        Me.rdbSolicitacao = New System.Windows.Forms.RadioButton()
        Me.CampoChave = New System.Windows.Forms.RadioButton()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.AtualizarBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TipoProcura.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Procurar"
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.Location = New System.Drawing.Point(12, 158)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(678, 312)
        Me.MyLista.TabIndex = 4
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'Col1
        '
        Me.Col1.Text = "Código"
        Me.Col1.Width = 70
        '
        'Col2
        '
        Me.Col2.Text = "Fornecedor"
        Me.Col2.Width = 350
        '
        'Col3
        '
        Me.Col3.Text = "Documento"
        Me.Col3.Width = 90
        '
        'Col4
        '
        Me.Col4.Text = "Valor"
        Me.Col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col4.Width = 80
        '
        'Col5
        '
        Me.Col5.Text = "Solicitação"
        Me.Col5.Width = 80
        '
        'TipoProcura
        '
        Me.TipoProcura.BackColor = System.Drawing.Color.Transparent
        Me.TipoProcura.Controls.Add(Me.DocumentoFornecedor)
        Me.TipoProcura.Controls.Add(Me.MostraTodos)
        Me.TipoProcura.Controls.Add(Me.AlfaNumerica)
        Me.TipoProcura.Controls.Add(Me.rdbSolicitacao)
        Me.TipoProcura.Controls.Add(Me.CampoChave)
        Me.TipoProcura.Location = New System.Drawing.Point(12, 80)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(678, 43)
        Me.TipoProcura.TabIndex = 1
        Me.TipoProcura.TabStop = False
        Me.TipoProcura.Text = "Tipo de Procura"
        '
        'DocumentoFornecedor
        '
        Me.DocumentoFornecedor.AutoSize = True
        Me.DocumentoFornecedor.Location = New System.Drawing.Point(218, 17)
        Me.DocumentoFornecedor.Name = "DocumentoFornecedor"
        Me.DocumentoFornecedor.Size = New System.Drawing.Size(137, 17)
        Me.DocumentoFornecedor.TabIndex = 2
        Me.DocumentoFornecedor.TabStop = True
        Me.DocumentoFornecedor.Text = "Documento Fornecedor"
        Me.DocumentoFornecedor.UseVisualStyleBackColor = True
        '
        'MostraTodos
        '
        Me.MostraTodos.AutoSize = True
        Me.MostraTodos.Location = New System.Drawing.Point(519, 16)
        Me.MostraTodos.Name = "MostraTodos"
        Me.MostraTodos.Size = New System.Drawing.Size(93, 17)
        Me.MostraTodos.TabIndex = 4
        Me.MostraTodos.TabStop = True
        Me.MostraTodos.Text = "Mostrar Todos"
        Me.MostraTodos.UseVisualStyleBackColor = True
        '
        'AlfaNumerica
        '
        Me.AlfaNumerica.AutoSize = True
        Me.AlfaNumerica.Location = New System.Drawing.Point(127, 16)
        Me.AlfaNumerica.Name = "AlfaNumerica"
        Me.AlfaNumerica.Size = New System.Drawing.Size(79, 17)
        Me.AlfaNumerica.TabIndex = 1
        Me.AlfaNumerica.TabStop = True
        Me.AlfaNumerica.Text = "Fornecedor"
        Me.AlfaNumerica.UseVisualStyleBackColor = True
        '
        'rdbSolicitacao
        '
        Me.rdbSolicitacao.AutoSize = True
        Me.rdbSolicitacao.Location = New System.Drawing.Point(394, 16)
        Me.rdbSolicitacao.Name = "rdbSolicitacao"
        Me.rdbSolicitacao.Size = New System.Drawing.Size(77, 17)
        Me.rdbSolicitacao.TabIndex = 3
        Me.rdbSolicitacao.TabStop = True
        Me.rdbSolicitacao.Text = "Solicitação"
        Me.rdbSolicitacao.UseVisualStyleBackColor = True
        '
        'CampoChave
        '
        Me.CampoChave.AutoSize = True
        Me.CampoChave.Location = New System.Drawing.Point(23, 16)
        Me.CampoChave.Name = "CampoChave"
        Me.CampoChave.Size = New System.Drawing.Size(92, 17)
        Me.CampoChave.TabIndex = 0
        Me.CampoChave.TabStop = True
        Me.CampoChave.Text = "Campo Chave"
        Me.CampoChave.UseVisualStyleBackColor = True
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtualizarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(697, 68)
        Me.BarraBt.TabIndex = 0
        Me.BarraBt.Text = "ToolStrip1"
        '
        'AtualizarBT
        '
        Me.AtualizarBT.Image = CType(resources.GetObject("AtualizarBT.Image"), System.Drawing.Image)
        Me.AtualizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtualizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtualizarBT.Name = "AtualizarBT"
        Me.AtualizarBT.Size = New System.Drawing.Size(56, 65)
        Me.AtualizarBT.Text = "Atualizar"
        Me.AtualizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(52, 65)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.TxtProcura)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.TipoProcura)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(697, 480)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'TxtProcura
        '
        Me.TxtProcura.AcceptsTab = True
        Me.TxtProcura.AceitaColarTexto = True
        Me.TxtProcura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TxtProcura.CasasDecimais = 0
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.CPObrigatorio = False
        Me.TxtProcura.CPObrigatorioMsg = Nothing
        Me.TxtProcura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TxtProcura.FlatBorder = False
        Me.TxtProcura.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TxtProcura.FocusColor = System.Drawing.Color.Empty
        Me.TxtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.TxtProcura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcura.HighlightBorderOnEnter = False
        Me.TxtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TxtProcura.Location = New System.Drawing.Point(68, 130)
        Me.TxtProcura.MaxLength = 250
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.PreencherZeroEsqueda = False
        Me.TxtProcura.RegraValidação = Nothing
        Me.TxtProcura.RegraValidaçãoMensagem = Nothing
        Me.TxtProcura.Size = New System.Drawing.Size(622, 23)
        Me.TxtProcura.TabIndex = 3
        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'TelaProcuraCtrlPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(697, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TelaProcuraCtrlPedido"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar"
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Col1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TipoProcura As System.Windows.Forms.GroupBox
    Friend WithEvents AlfaNumerica As System.Windows.Forms.RadioButton
    Friend WithEvents CampoChave As System.Windows.Forms.RadioButton
    Friend WithEvents MostraTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents AtualizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents DocumentoFornecedor As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Col5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents rdbSolicitacao As System.Windows.Forms.RadioButton
    Public WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
