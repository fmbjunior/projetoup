<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicoFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServicoFuncionario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.picPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdicionarUmNovoServiçoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarTodosOsServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcluirServiçoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Servico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuFuncionario = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdicionarUmNovoFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExccluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        CType(Me.picPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextItem.SuspendLayout()
        Me.ContextMenuFuncionario.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.lblLabel1)
        Me.Fundo.Controls.Add(Me.picPictureBox1)
        Me.Fundo.Controls.Add(Me.DgvItem)
        Me.Fundo.Controls.Add(Me.ButtonX1)
        Me.Fundo.Controls.Add(Me.TreeView1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(756, 554)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Incluir serviço p/funcionário click com o botão direito do mouse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 520)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Incluir funcionário click com o botão direito do mouse"
        '
        'lblLabel1
        '
        Me.lblLabel1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel1.Location = New System.Drawing.Point(126, 13)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(463, 49)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "Funcionário e Serviços"
        '
        'picPictureBox1
        '
        Me.picPictureBox1.Image = CType(resources.GetObject("picPictureBox1.Image"), System.Drawing.Image)
        Me.picPictureBox1.Location = New System.Drawing.Point(26, 3)
        Me.picPictureBox1.Name = "picPictureBox1"
        Me.picPictureBox1.Size = New System.Drawing.Size(94, 71)
        Me.picPictureBox1.TabIndex = 3
        Me.picPictureBox1.TabStop = False
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.AllowUserToResizeColumns = False
        Me.DgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItem.BackgroundColor = System.Drawing.Color.White
        Me.DgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.CodigoServico, Me.Servico, Me.ValorServico, Me.Comissao})
        Me.DgvItem.ContextMenuStrip = Me.ContextItem
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(265, 77)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(479, 437)
        Me.DgvItem.TabIndex = 2
        '
        'id
        '
        Me.id.DataPropertyName = "sv_id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'CodigoServico
        '
        Me.CodigoServico.ContextMenuStrip = Me.ContextItem
        Me.CodigoServico.DataPropertyName = "Serv_Codigo"
        DataGridViewCellStyle2.Format = "0000"
        Me.CodigoServico.DefaultCellStyle = DataGridViewCellStyle2
        Me.CodigoServico.HeaderText = "Cod.Serviço"
        Me.CodigoServico.Name = "CodigoServico"
        Me.CodigoServico.Width = 80
        '
        'ContextItem
        '
        Me.ContextItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarUmNovoServiçoToolStripMenuItem, Me.AdicionarTodosOsServiçosToolStripMenuItem, Me.AtualizarToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExcluirServiçoToolStripMenuItem})
        Me.ContextItem.Name = "ContextItem"
        Me.ContextItem.Size = New System.Drawing.Size(223, 98)
        '
        'AdicionarUmNovoServiçoToolStripMenuItem
        '
        Me.AdicionarUmNovoServiçoToolStripMenuItem.Image = CType(resources.GetObject("AdicionarUmNovoServiçoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdicionarUmNovoServiçoToolStripMenuItem.Name = "AdicionarUmNovoServiçoToolStripMenuItem"
        Me.AdicionarUmNovoServiçoToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AdicionarUmNovoServiçoToolStripMenuItem.Text = "Adicionar um novo Serviço"
        '
        'AdicionarTodosOsServiçosToolStripMenuItem
        '
        Me.AdicionarTodosOsServiçosToolStripMenuItem.Name = "AdicionarTodosOsServiçosToolStripMenuItem"
        Me.AdicionarTodosOsServiçosToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AdicionarTodosOsServiçosToolStripMenuItem.Text = "Adicionar Todos os Serviços"
        '
        'AtualizarToolStripMenuItem
        '
        Me.AtualizarToolStripMenuItem.Name = "AtualizarToolStripMenuItem"
        Me.AtualizarToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AtualizarToolStripMenuItem.Text = "Atualizar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(219, 6)
        '
        'ExcluirServiçoToolStripMenuItem
        '
        Me.ExcluirServiçoToolStripMenuItem.Image = CType(resources.GetObject("ExcluirServiçoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirServiçoToolStripMenuItem.Name = "ExcluirServiçoToolStripMenuItem"
        Me.ExcluirServiçoToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ExcluirServiçoToolStripMenuItem.Text = "Excluir Serviço"
        '
        'Servico
        '
        Me.Servico.DataPropertyName = "Serv_Descricao"
        Me.Servico.HeaderText = "Serviço"
        Me.Servico.Name = "Servico"
        Me.Servico.Width = 200
        '
        'ValorServico
        '
        Me.ValorServico.DataPropertyName = "Serv_ValorServico"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ValorServico.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValorServico.HeaderText = "Valor Serviço"
        Me.ValorServico.Name = "ValorServico"
        '
        'Comissao
        '
        Me.Comissao.DataPropertyName = "Sv_Comissão"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Comissao.DefaultCellStyle = DataGridViewCellStyle4
        Me.Comissao.HeaderText = "Comissão"
        Me.Comissao.Name = "Comissao"
        Me.Comissao.Width = 95
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(667, 520)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(77, 26)
        Me.ButtonX1.TabIndex = 3
        Me.ButtonX1.Text = "Fechar"
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuFuncionario
        Me.TreeView1.Location = New System.Drawing.Point(5, 77)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(254, 437)
        Me.TreeView1.TabIndex = 1
        '
        'ContextMenuFuncionario
        '
        Me.ContextMenuFuncionario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarUmNovoFuncionárioToolStripMenuItem, Me.ExccluirToolStripMenuItem})
        Me.ContextMenuFuncionario.Name = "ContextMenu"
        Me.ContextMenuFuncionario.Size = New System.Drawing.Size(213, 48)
        '
        'AdicionarUmNovoFuncionárioToolStripMenuItem
        '
        Me.AdicionarUmNovoFuncionárioToolStripMenuItem.Image = CType(resources.GetObject("AdicionarUmNovoFuncionárioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdicionarUmNovoFuncionárioToolStripMenuItem.Name = "AdicionarUmNovoFuncionárioToolStripMenuItem"
        Me.AdicionarUmNovoFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.AdicionarUmNovoFuncionárioToolStripMenuItem.Text = "Adicionar um Funcionário"
        '
        'ExccluirToolStripMenuItem
        '
        Me.ExccluirToolStripMenuItem.Image = Global.Up.My.Resources.Resources.Cancelar
        Me.ExccluirToolStripMenuItem.Name = "ExccluirToolStripMenuItem"
        Me.ExccluirToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ExccluirToolStripMenuItem.Text = "Excluir "
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ServicoFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ServicoFuncionario"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Funcionários e Serviços - T242"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        CType(Me.picPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextItem.ResumeLayout(False)
        Me.ContextMenuFuncionario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuFuncionario As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AdicionarUmNovoFuncionárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExccluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AdicionarUmNovoServiçoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirServiçoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comissao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picPictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label
    Friend WithEvents AdicionarTodosOsServiçosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AtualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
