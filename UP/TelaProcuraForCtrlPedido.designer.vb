<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaProcuraForCtrlPedido
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fantasia = New System.Windows.Forms.RadioButton()
        Me.MostraTodos = New System.Windows.Forms.RadioButton()
        Me.RazãoSocial = New System.Windows.Forms.RadioButton()
        Me.CampoChave = New System.Windows.Forms.RadioButton()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.Col1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.TipoProcura = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.TipoProcura.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procurar"
        '
        'Fantasia
        '
        Me.Fantasia.AutoSize = True
        Me.Fantasia.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fantasia.Location = New System.Drawing.Point(360, 7)
        Me.Fantasia.Name = "Fantasia"
        Me.Fantasia.Size = New System.Drawing.Size(68, 19)
        Me.Fantasia.TabIndex = 2
        Me.Fantasia.Text = "Fantasia"
        Me.Fantasia.UseVisualStyleBackColor = True
        '
        'MostraTodos
        '
        Me.MostraTodos.AutoSize = True
        Me.MostraTodos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostraTodos.Location = New System.Drawing.Point(546, 7)
        Me.MostraTodos.Name = "MostraTodos"
        Me.MostraTodos.Size = New System.Drawing.Size(99, 19)
        Me.MostraTodos.TabIndex = 3
        Me.MostraTodos.Text = "Mostrar Todos"
        Me.MostraTodos.UseVisualStyleBackColor = True
        '
        'RazãoSocial
        '
        Me.RazãoSocial.AutoSize = True
        Me.RazãoSocial.Checked = True
        Me.RazãoSocial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazãoSocial.Location = New System.Drawing.Point(157, 7)
        Me.RazãoSocial.Name = "RazãoSocial"
        Me.RazãoSocial.Size = New System.Drawing.Size(92, 19)
        Me.RazãoSocial.TabIndex = 1
        Me.RazãoSocial.TabStop = True
        Me.RazãoSocial.Text = "Razão Social"
        Me.RazãoSocial.UseVisualStyleBackColor = True
        '
        'CampoChave
        '
        Me.CampoChave.AutoSize = True
        Me.CampoChave.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CampoChave.Location = New System.Drawing.Point(3, 7)
        Me.CampoChave.Name = "CampoChave"
        Me.CampoChave.Size = New System.Drawing.Size(92, 19)
        Me.CampoChave.TabIndex = 0
        Me.CampoChave.Text = "Campo Chave"
        Me.CampoChave.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1, Me.Col2, Me.Col3, Me.Col4})
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.Location = New System.Drawing.Point(5, 100)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(676, 366)
        Me.MyLista.TabIndex = 3
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'Col1
        '
        Me.Col1.Text = "Código"
        '
        'Col2
        '
        Me.Col2.Text = "Razão Social"
        Me.Col2.Width = 270
        '
        'Col3
        '
        Me.Col3.Text = "Nome Fantasia"
        Me.Col3.Width = 200
        '
        'Col4
        '
        Me.Col4.Text = "Cpf/Cnpj"
        Me.Col4.Width = 110
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.TxtProcura)
        Me.Fundo.Controls.Add(Me.TipoProcura)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(687, 517)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        Me.Fundo.Text = "PanelEx1"
        '
        'TxtProcura
        '
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
        Me.TxtProcura.Location = New System.Drawing.Point(66, 70)
        Me.TxtProcura.MaxLength = 250
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.PreencherZeroEsqueda = False
        Me.TxtProcura.RegraValidação = Nothing
        Me.TxtProcura.RegraValidaçãoMensagem = Nothing
        Me.TxtProcura.Size = New System.Drawing.Size(615, 23)
        Me.TxtProcura.TabIndex = 1
        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'TipoProcura
        '
        Me.TipoProcura.CanvasColor = System.Drawing.SystemColors.Control
        Me.TipoProcura.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.TipoProcura.Controls.Add(Me.Fantasia)
        Me.TipoProcura.Controls.Add(Me.MostraTodos)
        Me.TipoProcura.Controls.Add(Me.CampoChave)
        Me.TipoProcura.Controls.Add(Me.RazãoSocial)
        Me.TipoProcura.Location = New System.Drawing.Point(11, 12)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(670, 50)
        '
        '
        '
        Me.TipoProcura.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TipoProcura.Style.BackColorGradientAngle = 90
        Me.TipoProcura.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TipoProcura.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TipoProcura.Style.BorderBottomWidth = 1
        Me.TipoProcura.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.TipoProcura.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TipoProcura.Style.BorderLeftWidth = 1
        Me.TipoProcura.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TipoProcura.Style.BorderRightWidth = 1
        Me.TipoProcura.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TipoProcura.Style.BorderTopWidth = 1
        Me.TipoProcura.Style.CornerDiameter = 4
        Me.TipoProcura.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TipoProcura.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.TipoProcura.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.TipoProcura.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.TipoProcura.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.TipoProcura.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TipoProcura.TabIndex = 2
        Me.TipoProcura.Text = "Tipo de procura"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Location = New System.Drawing.Point(548, 473)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(133, 37)
        Me.Fechar.TabIndex = 4
        Me.Fechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'TelaProcuraForCtrlPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(687, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TelaProcuraForCtrlPedido"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar - T211"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RazãoSocial As System.Windows.Forms.RadioButton
    Friend WithEvents CampoChave As System.Windows.Forms.RadioButton
    Friend WithEvents MostraTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Fantasia As System.Windows.Forms.RadioButton
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Col1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TipoProcura As DevComponents.DotNetBar.Controls.GroupPanel
    Public WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
