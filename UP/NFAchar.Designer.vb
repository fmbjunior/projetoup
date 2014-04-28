<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NFAchar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NFAchar))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NotaFiscal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btAchaPorCliente = New System.Windows.Forms.Label()
        Me.btAchaPorNf = New System.Windows.Forms.Label()
        Me.cmdMostrarTodos = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(12, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 19)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Informe a Nota Fiscal"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NotaFiscal
        '
        Me.NotaFiscal.AceitaColarTexto = True
        Me.NotaFiscal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NotaFiscal.CasasDecimais = 0
        Me.NotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NotaFiscal.CPObrigatorio = False
        Me.NotaFiscal.CPObrigatorioMsg = Nothing
        Me.NotaFiscal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NotaFiscal.FlatBorder = False
        Me.NotaFiscal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.FocusColor = System.Drawing.Color.MistyRose
        Me.NotaFiscal.FocusColorEnd = System.Drawing.Color.Empty
        Me.NotaFiscal.HighlightBorderOnEnter = False
        Me.NotaFiscal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NotaFiscal.Location = New System.Drawing.Point(146, 8)
        Me.NotaFiscal.MaxLength = 10
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.PreencherZeroEsqueda = False
        Me.NotaFiscal.RegraValidação = Nothing
        Me.NotaFiscal.RegraValidaçãoMensagem = Nothing
        Me.NotaFiscal.Size = New System.Drawing.Size(74, 23)
        Me.NotaFiscal.TabIndex = 1
        Me.NotaFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NotaFiscal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NotaFiscal.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.MistyRose
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(146, 37)
        Me.Cliente.MaxLength = 10
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(74, 23)
        Me.Cliente.TabIndex = 4
        Me.Cliente.TabStop = False
        Me.Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = True
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteDesc.FlatBorder = False
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(226, 37)
        Me.ClienteDesc.MaxLength = 10
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(405, 23)
        Me.ClienteDesc.TabIndex = 5
        Me.ClienteDesc.TabStop = False
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(12, 67)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(648, 197)
        Me.MyLista.TabIndex = 7
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cliente"
        Me.ColumnHeader7.Width = 293
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nota Fiscal"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nº Pedido"
        Me.ColumnHeader9.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Emissão"
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Total NF"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ST"
        Me.ColumnHeader2.Width = 30
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btAchaPorCliente)
        Me.Fundo.Controls.Add(Me.btAchaPorNf)
        Me.Fundo.Controls.Add(Me.cmdMostrarTodos)
        Me.Fundo.Controls.Add(Me.btNovo)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label14)
        Me.Fundo.Controls.Add(Me.NotaFiscal)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Cliente)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.ClienteDesc)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(672, 302)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 10
        '
        'btAchaPorCliente
        '
        Me.btAchaPorCliente.Image = CType(resources.GetObject("btAchaPorCliente.Image"), System.Drawing.Image)
        Me.btAchaPorCliente.Location = New System.Drawing.Point(637, 37)
        Me.btAchaPorCliente.Name = "btAchaPorCliente"
        Me.btAchaPorCliente.Size = New System.Drawing.Size(23, 23)
        Me.btAchaPorCliente.TabIndex = 32
        '
        'btAchaPorNf
        '
        Me.btAchaPorNf.Image = CType(resources.GetObject("btAchaPorNf.Image"), System.Drawing.Image)
        Me.btAchaPorNf.Location = New System.Drawing.Point(226, 8)
        Me.btAchaPorNf.Name = "btAchaPorNf"
        Me.btAchaPorNf.Size = New System.Drawing.Size(23, 23)
        Me.btAchaPorNf.TabIndex = 31
        '
        'cmdMostrarTodos
        '
        Me.cmdMostrarTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdMostrarTodos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdMostrarTodos.Location = New System.Drawing.Point(491, 8)
        Me.cmdMostrarTodos.Name = "cmdMostrarTodos"
        Me.cmdMostrarTodos.Size = New System.Drawing.Size(140, 23)
        Me.cmdMostrarTodos.TabIndex = 11
        Me.cmdMostrarTodos.Text = "Mostrar Todos"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(458, 271)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(121, 23)
        Me.btNovo.TabIndex = 11
        Me.btNovo.Text = "&Novo Pesquisa"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(585, 271)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 10
        Me.btFechar.Text = "&Fechar"
        '
        'NFAchar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NFAchar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa por Nota Fiscal - T148"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NotaFiscal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAchaPorNf As System.Windows.Forms.Label
    Friend WithEvents btAchaPorCliente As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdMostrarTodos As DevComponents.DotNetBar.ButtonX
End Class
