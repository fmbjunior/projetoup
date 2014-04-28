<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChequePreDevolver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChequePreDevolver))
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CaixaCod = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Filtrar = New DevComponents.DotNetBar.ButtonX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCheque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColContaBalancete = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataMovimentoInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DataMovimentoFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.DataMovimentoFinal)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.CaixaCod)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Filtrar)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.DataMovimentoInicial)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpNavigator(Me.Fundo, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fundo.Name = "Fundo"
        Me.HelpProvider1.SetShowHelp(Me.Fundo, True)
        Me.Fundo.Size = New System.Drawing.Size(978, 571)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(420, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Código Caixa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CaixaCod
        '
        Me.CaixaCod.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.CaixaCod.AceitaColarTexto = True
        Me.CaixaCod.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CaixaCod.CasasDecimais = 0
        Me.CaixaCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CaixaCod.CPObrigatorio = False
        Me.CaixaCod.CPObrigatorioMsg = Nothing
        Me.CaixaCod.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CaixaCod.FlatBorder = False
        Me.CaixaCod.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CaixaCod.FocusColor = System.Drawing.Color.Empty
        Me.CaixaCod.FocusColorEnd = System.Drawing.Color.Empty
        Me.CaixaCod.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaCod.HighlightBorderOnEnter = False
        Me.CaixaCod.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CaixaCod.Location = New System.Drawing.Point(507, 7)
        Me.CaixaCod.MaxLength = 4
        Me.CaixaCod.Name = "CaixaCod"
        Me.CaixaCod.PreencherZeroEsqueda = False
        Me.CaixaCod.RegraValidação = Nothing
        Me.CaixaCod.RegraValidaçãoMensagem = Nothing
        Me.CaixaCod.Size = New System.Drawing.Size(57, 24)
        Me.CaixaCod.TabIndex = 4
        Me.CaixaCod.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CaixaCod.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(894, 538)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(72, 26)
        Me.Fechar.TabIndex = 6
        Me.Fechar.Text = "Fechar"
        '
        'Filtrar
        '
        Me.Filtrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Filtrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Filtrar.Image = CType(resources.GetObject("Filtrar.Image"), System.Drawing.Image)
        Me.Filtrar.Location = New System.Drawing.Point(570, 8)
        Me.Filtrar.Name = "Filtrar"
        Me.Filtrar.Size = New System.Drawing.Size(27, 23)
        Me.Filtrar.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(14, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Informe o Período"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColCheque, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColContaBalancete})
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(14, 38)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(952, 493)
        Me.MyLista.TabIndex = 6
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 0
        '
        'ColCheque
        '
        Me.ColCheque.Text = "Cheque"
        Me.ColCheque.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "C/C"
        Me.ColumnHeader9.Width = 93
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Valor"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 97
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Recebimento"
        Me.ColumnHeader11.Width = 77
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Entregue Por"
        Me.ColumnHeader1.Width = 220
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Banco"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Valor Ch"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "LocalPgto"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Pedido"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.Width = 90
        '
        'ColContaBalancete
        '
        Me.ColContaBalancete.Text = ""
        Me.ColContaBalancete.Width = 0
        '
        'DataMovimentoInicial
        '
        Me.DataMovimentoInicial.AceitaColarTexto = True
        Me.DataMovimentoInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataMovimentoInicial.CasasDecimais = 0
        Me.DataMovimentoInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataMovimentoInicial.CPObrigatorio = False
        Me.DataMovimentoInicial.CPObrigatorioMsg = Nothing
        Me.DataMovimentoInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataMovimentoInicial.FlatBorder = False
        Me.DataMovimentoInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataMovimentoInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataMovimentoInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataMovimentoInicial.HighlightBorderOnEnter = False
        Me.DataMovimentoInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataMovimentoInicial.Location = New System.Drawing.Point(150, 8)
        Me.DataMovimentoInicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataMovimentoInicial.MaxLength = 10
        Me.DataMovimentoInicial.Name = "DataMovimentoInicial"
        Me.DataMovimentoInicial.PreencherZeroEsqueda = False
        Me.DataMovimentoInicial.RegraValidação = Nothing
        Me.DataMovimentoInicial.RegraValidaçãoMensagem = Nothing
        Me.DataMovimentoInicial.Size = New System.Drawing.Size(117, 23)
        Me.DataMovimentoInicial.TabIndex = 1
        Me.DataMovimentoInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataMovimentoInicial.ValorPadrao = Nothing
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'DataMovimentoFinal
        '
        Me.DataMovimentoFinal.AceitaColarTexto = True
        Me.DataMovimentoFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataMovimentoFinal.CasasDecimais = 0
        Me.DataMovimentoFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataMovimentoFinal.CPObrigatorio = False
        Me.DataMovimentoFinal.CPObrigatorioMsg = Nothing
        Me.DataMovimentoFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataMovimentoFinal.FlatBorder = False
        Me.DataMovimentoFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataMovimentoFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataMovimentoFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataMovimentoFinal.HighlightBorderOnEnter = False
        Me.DataMovimentoFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataMovimentoFinal.Location = New System.Drawing.Point(273, 8)
        Me.DataMovimentoFinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataMovimentoFinal.MaxLength = 10
        Me.DataMovimentoFinal.Name = "DataMovimentoFinal"
        Me.DataMovimentoFinal.PreencherZeroEsqueda = False
        Me.DataMovimentoFinal.RegraValidação = Nothing
        Me.DataMovimentoFinal.RegraValidaçãoMensagem = Nothing
        Me.DataMovimentoFinal.Size = New System.Drawing.Size(117, 23)
        Me.DataMovimentoFinal.TabIndex = 2
        Me.DataMovimentoFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataMovimentoFinal.ValorPadrao = Nothing
        '
        'ChequePreDevolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChequePreDevolver"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque-Pré Devolução - T114"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColCheque As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataMovimentoInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Filtrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CaixaCod As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColContaBalancete As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents DataMovimentoFinal As TexBoxFocusNet.TextBoxFocusNet
End Class
