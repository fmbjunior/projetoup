<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceteCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BalanceteCadastro))
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NovaContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtPesquisa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btImpressao = New DevComponents.DotNetBar.ButtonX()
        Me.btMostrarArvore = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btPesquisar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'treeView1
        '
        Me.treeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.treeView1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.treeView1.ImageIndex = 0
        Me.treeView1.ImageList = Me.ImageList1
        Me.treeView1.Location = New System.Drawing.Point(12, 95)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.SelectedImageIndex = 3
        Me.treeView1.Size = New System.Drawing.Size(411, 398)
        Me.treeView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaContaToolStripMenuItem, Me.EditarContaToolStripMenuItem, Me.ExcluirContaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(192, 130)
        '
        'NovaContaToolStripMenuItem
        '
        Me.NovaContaToolStripMenuItem.Image = CType(resources.GetObject("NovaContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovaContaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovaContaToolStripMenuItem.Name = "NovaContaToolStripMenuItem"
        Me.NovaContaToolStripMenuItem.Size = New System.Drawing.Size(191, 42)
        Me.NovaContaToolStripMenuItem.Text = "Nova Conta"
        '
        'EditarContaToolStripMenuItem
        '
        Me.EditarContaToolStripMenuItem.Image = CType(resources.GetObject("EditarContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarContaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarContaToolStripMenuItem.Name = "EditarContaToolStripMenuItem"
        Me.EditarContaToolStripMenuItem.Size = New System.Drawing.Size(191, 42)
        Me.EditarContaToolStripMenuItem.Text = "Editar Conta"
        '
        'ExcluirContaToolStripMenuItem
        '
        Me.ExcluirContaToolStripMenuItem.Image = CType(resources.GetObject("ExcluirContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirContaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirContaToolStripMenuItem.Name = "ExcluirContaToolStripMenuItem"
        Me.ExcluirContaToolStripMenuItem.Size = New System.Drawing.Size(191, 42)
        Me.ExcluirContaToolStripMenuItem.Text = "Excluir Conta"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Chave18.png")
        Me.ImageList1.Images.SetKeyName(1, "ChaveAbrir18.png")
        Me.ImageList1.Images.SetKeyName(2, "BolaVerde18.png")
        Me.ImageList1.Images.SetKeyName(3, "SetaDireita18.png")
        '
        'txtPesquisa
        '
        Me.txtPesquisa.AceitaColarTexto = True
        Me.txtPesquisa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtPesquisa.CasasDecimais = 2
        Me.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisa.CPObrigatorio = False
        Me.txtPesquisa.CPObrigatorioMsg = Nothing
        Me.txtPesquisa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtPesquisa.FlatBorder = False
        Me.txtPesquisa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtPesquisa.FocusColor = System.Drawing.Color.Empty
        Me.txtPesquisa.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtPesquisa.HighlightBorderOnEnter = False
        Me.txtPesquisa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtPesquisa.Location = New System.Drawing.Point(130, 29)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.PreencherZeroEsqueda = False
        Me.txtPesquisa.RegraValidação = Nothing
        Me.txtPesquisa.RegraValidaçãoMensagem = Nothing
        Me.txtPesquisa.Size = New System.Drawing.Size(179, 23)
        Me.txtPesquisa.TabIndex = 3
        Me.txtPesquisa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtPesquisa.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Texto para localizar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(3, 3)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(69, 19)
        Me.opt1.TabIndex = 9
        Me.opt1.TabStop = True
        Me.opt1.Text = "1º Grupo"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(178, 3)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(71, 19)
        Me.opt3.TabIndex = 2
        Me.opt3.TabStop = True
        Me.opt3.Text = "3º Grupo"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(91, 3)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(71, 19)
        Me.opt2.TabIndex = 1
        Me.opt2.TabStop = True
        Me.opt2.Text = "2º Grupo"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btImpressao)
        Me.Fundo.Controls.Add(Me.btMostrarArvore)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.treeView1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(435, 533)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 9
        '
        'btImpressao
        '
        Me.btImpressao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImpressao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImpressao.Location = New System.Drawing.Point(140, 498)
        Me.btImpressao.Name = "btImpressao"
        Me.btImpressao.Size = New System.Drawing.Size(98, 23)
        Me.btImpressao.TabIndex = 13
        Me.btImpressao.Text = "Imprimir"
        '
        'btMostrarArvore
        '
        Me.btMostrarArvore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btMostrarArvore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btMostrarArvore.Location = New System.Drawing.Point(244, 498)
        Me.btMostrarArvore.Name = "btMostrarArvore"
        Me.btMostrarArvore.Size = New System.Drawing.Size(98, 23)
        Me.btMostrarArvore.TabIndex = 12
        Me.btMostrarArvore.Text = "Mostrar Arvore"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(348, 498)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 11
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btPesquisar)
        Me.GroupPanel1.Controls.Add(Me.opt3)
        Me.GroupPanel1.Controls.Add(Me.opt1)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.opt2)
        Me.GroupPanel1.Controls.Add(Me.txtPesquisa)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 11)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(411, 79)
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
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 9
        Me.GroupPanel1.Text = "Selecione um dos Grupos para Pesquisar"
        '
        'btPesquisar
        '
        Me.btPesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btPesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btPesquisar.Location = New System.Drawing.Point(315, 29)
        Me.btPesquisar.Name = "btPesquisar"
        Me.btPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btPesquisar.TabIndex = 10
        Me.btPesquisar.Text = "Pesquisar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'BalanceteCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BalanceteCadastro"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas Balancete - T091"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents treeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NovaContaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirContaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarContaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPesquisa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btPesquisar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btMostrarArvore As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btImpressao As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
