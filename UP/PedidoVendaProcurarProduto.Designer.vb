<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoVendaProcurarProduto
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
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.Col2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Referencia = New System.Windows.Forms.Label()
        Me.btMostrarTodos = New DevComponents.DotNetBar.ButtonX()
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col2, Me.Col3, Me.Col4, Me.Col5})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(7, 63)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(524, 367)
        Me.MyLista.TabIndex = 3
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'Col2
        '
        Me.Col2.Text = "Código"
        Me.Col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col2.Width = 80
        '
        'Col3
        '
        Me.Col3.Text = "Descrição"
        Me.Col3.Width = 300
        '
        'Col4
        '
        Me.Col4.Text = "Estoque"
        Me.Col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col4.Width = 120
        '
        'Col5
        '
        Me.Col5.Width = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe o Texto a Procurar"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Referencia)
        Me.Fundo.Controls.Add(Me.btMostrarTodos)
        Me.Fundo.Controls.Add(Me.TxtProcura)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(543, 515)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        Me.Fundo.Text = "PanelEx1"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(7, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Referência"
        '
        'Referencia
        '
        Me.Referencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Referencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Referencia.Location = New System.Drawing.Point(7, 450)
        Me.Referencia.Name = "Referencia"
        Me.Referencia.Size = New System.Drawing.Size(524, 56)
        Me.Referencia.TabIndex = 5
        '
        'btMostrarTodos
        '
        Me.btMostrarTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btMostrarTodos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btMostrarTodos.Location = New System.Drawing.Point(354, 8)
        Me.btMostrarTodos.Name = "btMostrarTodos"
        Me.btMostrarTodos.Size = New System.Drawing.Size(96, 23)
        Me.btMostrarTodos.TabIndex = 4
        Me.btMostrarTodos.Text = "Mostrar Todos"
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
        Me.TxtProcura.HighlightBorderOnEnter = False
        Me.TxtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TxtProcura.Location = New System.Drawing.Point(15, 36)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.PreencherZeroEsqueda = False
        Me.TxtProcura.RegraValidação = Nothing
        Me.TxtProcura.RegraValidaçãoMensagem = Nothing
        Me.TxtProcura.Size = New System.Drawing.Size(516, 20)
        Me.TxtProcura.TabIndex = 1
        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(456, 8)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 2
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'PedidoVendaProcurarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(543, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PedidoVendaProcurarProduto"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar Produto para Venda - T184"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Col4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btMostrarTodos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Col5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Referencia As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
