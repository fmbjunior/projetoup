<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentroCustoNewLocalizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CentroCustoNewLocalizar))
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtPesquisa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btMostrarArvore = New System.Windows.Forms.Button()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btPesquisar = New System.Windows.Forms.Button()
        Me.Fundo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'treeView1
        '
        Me.treeView1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeView1.ImageIndex = 0
        Me.treeView1.ImageList = Me.ImageList1
        Me.treeView1.Location = New System.Drawing.Point(12, 95)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.SelectedImageIndex = 3
        Me.treeView1.Size = New System.Drawing.Size(448, 397)
        Me.treeView1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "key.png")
        Me.ImageList1.Images.SetKeyName(1, "add_folder.png")
        Me.ImageList1.Images.SetKeyName(2, "solutions.png")
        Me.ImageList1.Images.SetKeyName(3, "right.png")
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
        Me.txtPesquisa.Location = New System.Drawing.Point(132, 44)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.PreencherZeroEsqueda = False
        Me.txtPesquisa.RegraValidação = Nothing
        Me.txtPesquisa.RegraValidaçãoMensagem = Nothing
        Me.txtPesquisa.Size = New System.Drawing.Size(207, 23)
        Me.txtPesquisa.TabIndex = 3
        Me.txtPesquisa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtPesquisa.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Texto para localizar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(6, 22)
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
        Me.opt3.Location = New System.Drawing.Point(181, 22)
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
        Me.opt2.Location = New System.Drawing.Point(94, 22)
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
        Me.Fundo.Controls.Add(Me.btMostrarArvore)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupBox1)
        Me.Fundo.Controls.Add(Me.treeView1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(475, 541)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 9
        '
        'btMostrarArvore
        '
        Me.btMostrarArvore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMostrarArvore.Image = CType(resources.GetObject("btMostrarArvore.Image"), System.Drawing.Image)
        Me.btMostrarArvore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMostrarArvore.Location = New System.Drawing.Point(238, 497)
        Me.btMostrarArvore.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btMostrarArvore.Name = "btMostrarArvore"
        Me.btMostrarArvore.Size = New System.Drawing.Size(128, 33)
        Me.btMostrarArvore.TabIndex = 16
        Me.btMostrarArvore.Text = "Mostrar Arvore"
        Me.btMostrarArvore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMostrarArvore.UseVisualStyleBackColor = True
        '
        'btFechar
        '
        Me.btFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.Location = New System.Drawing.Point(373, 497)
        Me.btFechar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(87, 33)
        Me.btFechar.TabIndex = 15
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btPesquisar)
        Me.GroupBox1.Controls.Add(Me.opt1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPesquisa)
        Me.GroupBox1.Controls.Add(Me.opt3)
        Me.GroupBox1.Controls.Add(Me.opt2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 77)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione o Grupo para Pesquisar"
        '
        'btPesquisar
        '
        Me.btPesquisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPesquisar.Image = CType(resources.GetObject("btPesquisar.Image"), System.Drawing.Image)
        Me.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPesquisar.Location = New System.Drawing.Point(346, 39)
        Me.btPesquisar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btPesquisar.Name = "btPesquisar"
        Me.btPesquisar.Size = New System.Drawing.Size(94, 32)
        Me.btPesquisar.TabIndex = 11
        Me.btPesquisar.Text = "Pesquisar"
        Me.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesquisar.UseVisualStyleBackColor = True
        '
        'CentroCustoNewLocalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CentroCustoNewLocalizar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Centro de Custo Pesquisa"
        Me.Fundo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents treeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtPesquisa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btPesquisar As System.Windows.Forms.Button
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents btMostrarArvore As System.Windows.Forms.Button
End Class
