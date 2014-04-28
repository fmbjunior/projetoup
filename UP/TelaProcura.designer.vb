<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaProcura
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
        Me.TxtProcura = New System.Windows.Forms.TextBox()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.Col1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MostraTodos = New System.Windows.Forms.RadioButton()
        Me.AlfaNumerica = New System.Windows.Forms.RadioButton()
        Me.CampoChave = New System.Windows.Forms.RadioButton()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtProcura
        '
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.Location = New System.Drawing.Point(3, 29)
        Me.TxtProcura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.Size = New System.Drawing.Size(641, 23)
        Me.TxtProcura.TabIndex = 0
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1, Me.Col2, Me.Col3})
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.Location = New System.Drawing.Point(10, 100)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(655, 388)
        Me.MyLista.TabIndex = 2
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
        Me.Col2.Text = "Descrição"
        Me.Col2.Width = 400
        '
        'Col3
        '
        Me.Col3.Text = ""
        Me.Col3.Width = 125
        '
        'MostraTodos
        '
        Me.MostraTodos.AutoSize = True
        Me.MostraTodos.Location = New System.Drawing.Point(197, 3)
        Me.MostraTodos.Name = "MostraTodos"
        Me.MostraTodos.Size = New System.Drawing.Size(99, 19)
        Me.MostraTodos.TabIndex = 2
        Me.MostraTodos.TabStop = True
        Me.MostraTodos.Text = "Mostrar Todos"
        Me.MostraTodos.UseVisualStyleBackColor = True
        '
        'AlfaNumerica
        '
        Me.AlfaNumerica.AutoSize = True
        Me.AlfaNumerica.Location = New System.Drawing.Point(101, 3)
        Me.AlfaNumerica.Name = "AlfaNumerica"
        Me.AlfaNumerica.Size = New System.Drawing.Size(90, 19)
        Me.AlfaNumerica.TabIndex = 1
        Me.AlfaNumerica.TabStop = True
        Me.AlfaNumerica.Text = "Alfanuméica"
        Me.AlfaNumerica.UseVisualStyleBackColor = True
        '
        'CampoChave
        '
        Me.CampoChave.AutoSize = True
        Me.CampoChave.Location = New System.Drawing.Point(3, 3)
        Me.CampoChave.Name = "CampoChave"
        Me.CampoChave.Size = New System.Drawing.Size(92, 19)
        Me.CampoChave.TabIndex = 0
        Me.CampoChave.TabStop = True
        Me.CampoChave.Text = "Campo Chave"
        Me.CampoChave.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btAtualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(676, 532)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 76
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Location = New System.Drawing.Point(495, 495)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(82, 28)
        Me.btAtualizar.TabIndex = 10
        Me.btAtualizar.Text = "Atualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(583, 495)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(82, 28)
        Me.btFechar.TabIndex = 9
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.MostraTodos)
        Me.GroupPanel1.Controls.Add(Me.CampoChave)
        Me.GroupPanel1.Controls.Add(Me.TxtProcura)
        Me.GroupPanel1.Controls.Add(Me.AlfaNumerica)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(653, 81)
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
        Me.GroupPanel1.TabIndex = 8
        Me.GroupPanel1.Text = "Selecione uma das Opções"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'TelaProcura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(676, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TelaProcura"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar Dados Gerais - T207"
        Me.Fundo.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Col1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlfaNumerica As System.Windows.Forms.RadioButton
    Friend WithEvents CampoChave As System.Windows.Forms.RadioButton
    Friend WithEvents MostraTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
