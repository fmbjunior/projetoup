<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegiaoCidade
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btAddAllEstado = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btAdd = New DevComponents.DotNetBar.ButtonX()
        Me.cUF = New CBOAutoCompleteFocus.CboFocus()
        Me.cMun = New CBOAutoCompleteFocus.CboFocus()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Informe o Estado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btAddAllEstado)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.btAdd)
        Me.Fundo.Controls.Add(Me.cUF)
        Me.Fundo.Controls.Add(Me.cMun)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(465, 355)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 60
        '
        'btAddAllEstado
        '
        Me.btAddAllEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAddAllEstado.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAddAllEstado.Location = New System.Drawing.Point(219, 12)
        Me.btAddAllEstado.Name = "btAddAllEstado"
        Me.btAddAllEstado.Size = New System.Drawing.Size(98, 23)
        Me.btAddAllEstado.TabIndex = 95
        Me.btAddAllEstado.TabStop = False
        Me.btAddAllEstado.Text = "Add todo Estado"
        Me.btAddAllEstado.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(10, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(407, 23)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Para excluir uma cidade de duplo click na cidade desejada"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(371, 11)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(82, 23)
        Me.btFechar.TabIndex = 93
        Me.btFechar.Text = "Fechar"
        '
        'btAdd
        '
        Me.btAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdd.Location = New System.Drawing.Point(371, 41)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(82, 23)
        Me.btAdd.TabIndex = 92
        Me.btAdd.Text = "Add Cidade"
        '
        'cUF
        '
        Me.cUF.Auto_Complete = True
        Me.cUF.AutoLimitar_Lista = True
        Me.cUF.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cUF.CPObrigatorio = False
        Me.cUF.CPObrigatorioMsg = Nothing
        Me.cUF.FlatBorder = False
        Me.cUF.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cUF.FormattingEnabled = True
        Me.cUF.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cUF.HighlightBorderOnEnter = False
        Me.cUF.Location = New System.Drawing.Point(159, 12)
        Me.cUF.Name = "cUF"
        Me.cUF.Size = New System.Drawing.Size(54, 23)
        Me.cUF.TabIndex = 90
        '
        'cMun
        '
        Me.cMun.Auto_Complete = True
        Me.cMun.AutoLimitar_Lista = True
        Me.cMun.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cMun.CPObrigatorio = False
        Me.cMun.CPObrigatorioMsg = Nothing
        Me.cMun.FlatBorder = False
        Me.cMun.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cMun.FormattingEnabled = True
        Me.cMun.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cMun.HighlightBorderOnEnter = False
        Me.cMun.Location = New System.Drawing.Point(159, 41)
        Me.cMun.Name = "cMun"
        Me.cMun.Size = New System.Drawing.Size(206, 23)
        Me.cMun.TabIndex = 91
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Lista)
        Me.GroupPanel1.Location = New System.Drawing.Point(11, 80)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(442, 246)
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
        Me.GroupPanel1.TabIndex = 89
        Me.GroupPanel1.Text = "Cidades Adicionadas na Região"
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(3, 2)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(430, 217)
        Me.Lista.TabIndex = 76
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CodCidade"
        Me.Column1.HeaderText = "Cod."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CidadeDesc"
        Me.Column2.HeaderText = "Descrição"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 390
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cidade"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'RegiaoCidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(465, 355)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RegiaoCidade"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Região Cidade - T203"
        Me.Fundo.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cUF As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents cMun As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btAddAllEstado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
