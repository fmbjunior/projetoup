<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraProcurarDevolucao
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
        Me.Fornecedor = New System.Windows.Forms.RadioButton()
        Me.NotaFiscal = New System.Windows.Forms.RadioButton()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColCompraInterno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProcura = New System.Windows.Forms.TextBox()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.TipoProcura = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.MostrarTodos = New System.Windows.Forms.RadioButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.TipoProcura.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fornecedor
        '
        Me.Fornecedor.AutoSize = True
        Me.Fornecedor.Checked = True
        Me.Fornecedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fornecedor.Location = New System.Drawing.Point(119, 1)
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.Size = New System.Drawing.Size(83, 19)
        Me.Fornecedor.TabIndex = 1
        Me.Fornecedor.TabStop = True
        Me.Fornecedor.Text = "Fornecedor"
        Me.Fornecedor.UseVisualStyleBackColor = True
        '
        'NotaFiscal
        '
        Me.NotaFiscal.AutoSize = True
        Me.NotaFiscal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaFiscal.Location = New System.Drawing.Point(3, 1)
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.Size = New System.Drawing.Size(83, 19)
        Me.NotaFiscal.TabIndex = 0
        Me.NotaFiscal.Text = "Nota Fiscal"
        Me.NotaFiscal.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColCompraInterno, Me.ColNf, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6})
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(14, 84)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(637, 244)
        Me.MyLista.TabIndex = 2
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColCompraInterno
        '
        Me.ColCompraInterno.DisplayIndex = 2
        Me.ColCompraInterno.Text = "CompraInterno"
        Me.ColCompraInterno.Width = 0
        '
        'ColNf
        '
        Me.ColNf.DisplayIndex = 0
        Me.ColNf.Text = "Nota Fiscal"
        Me.ColNf.Width = 70
        '
        'Col2
        '
        Me.Col2.DisplayIndex = 1
        Me.Col2.Text = "Valor"
        Me.Col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col2.Width = 80
        '
        'Col3
        '
        Me.Col3.Text = "Fornecedor"
        Me.Col3.Width = 260
        '
        'Col4
        '
        Me.Col4.Text = "Tipo"
        '
        'Col5
        '
        Me.Col5.Text = "Data"
        Me.Col5.Width = 85
        '
        'Col6
        '
        Me.Col6.Text = "Conf ?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Procurar"
        '
        'TxtProcura
        '
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcura.Location = New System.Drawing.Point(75, 58)
        Me.TxtProcura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.Size = New System.Drawing.Size(576, 23)
        Me.TxtProcura.TabIndex = 1
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Controls.Add(Me.TipoProcura)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(663, 373)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "PanelEx1"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Location = New System.Drawing.Point(558, 335)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(93, 30)
        Me.Fechar.TabIndex = 2
        Me.Fechar.Text = "Fechar"
        '
        'TipoProcura
        '
        Me.TipoProcura.CanvasColor = System.Drawing.SystemColors.Control
        Me.TipoProcura.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.TipoProcura.Controls.Add(Me.MostrarTodos)
        Me.TipoProcura.Controls.Add(Me.Fornecedor)
        Me.TipoProcura.Controls.Add(Me.NotaFiscal)
        Me.TipoProcura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoProcura.Location = New System.Drawing.Point(17, 7)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(634, 45)
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
        Me.TipoProcura.TabIndex = 0
        Me.TipoProcura.Text = "Critérios"
        '
        'MostrarTodos
        '
        Me.MostrarTodos.AutoSize = True
        Me.MostrarTodos.Checked = True
        Me.MostrarTodos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarTodos.Location = New System.Drawing.Point(208, 3)
        Me.MostrarTodos.Name = "MostrarTodos"
        Me.MostrarTodos.Size = New System.Drawing.Size(99, 19)
        Me.MostrarTodos.TabIndex = 2
        Me.MostrarTodos.TabStop = True
        Me.MostrarTodos.Text = "Mostrar Todos"
        Me.MostrarTodos.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'CompraProcurarDevolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(663, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.MyLista)
        Me.Controls.Add(Me.TxtProcura)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CompraProcurarDevolucao"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar NF/Doc de Compra - T126"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fornecedor As System.Windows.Forms.RadioButton
    Friend WithEvents NotaFiscal As System.Windows.Forms.RadioButton
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColNf As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents ColCompraInterno As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TipoProcura As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Col5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
