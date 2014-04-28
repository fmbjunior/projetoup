<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProducaoEstoqueConfirmar
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btConfirmarEstoque = New DevComponents.DotNetBar.ButtonX()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GeradoEstoque = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Confirmado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Motivo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Solicitante = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataOrdem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OrdemProducao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btConfirmarEstoque)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.GeradoEstoque)
        Me.Fundo.Controls.Add(Me.Confirmado)
        Me.Fundo.Controls.Add(Me.Motivo)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Solicitante)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.DataOrdem)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.OrdemProducao)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Lista)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(886, 424)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btConfirmarEstoque
        '
        Me.btConfirmarEstoque.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmarEstoque.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmarEstoque.Location = New System.Drawing.Point(647, 393)
        Me.btConfirmarEstoque.Name = "btConfirmarEstoque"
        Me.btConfirmarEstoque.Size = New System.Drawing.Size(167, 23)
        Me.btConfirmarEstoque.TabIndex = 91
        Me.btConfirmarEstoque.Text = "Confirmar Ordem em Estoque"
        '
        'MyLista
        '
        Me.MyLista.BackColor = System.Drawing.Color.White
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader16})
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(494, 176)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(389, 211)
        Me.MyLista.TabIndex = 90
        Me.MyLista.TabStop = False
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Id"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ordem "
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Produto"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descrição"
        Me.ColumnHeader3.Width = 220
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Qtd"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 75
        '
        'GeradoEstoque
        '
        '
        '
        '
        Me.GeradoEstoque.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GeradoEstoque.Enabled = False
        Me.GeradoEstoque.Location = New System.Drawing.Point(767, 147)
        Me.GeradoEstoque.Name = "GeradoEstoque"
        Me.GeradoEstoque.Size = New System.Drawing.Size(107, 23)
        Me.GeradoEstoque.TabIndex = 89
        Me.GeradoEstoque.Text = "Gerado Estoque"
        '
        'Confirmado
        '
        '
        '
        '
        Me.Confirmado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Confirmado.Enabled = False
        Me.Confirmado.Location = New System.Drawing.Point(617, 147)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(87, 23)
        Me.Confirmado.TabIndex = 88
        Me.Confirmado.Text = "Confirmado"
        '
        'Motivo
        '
        Me.Motivo.AceitaColarTexto = True
        Me.Motivo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Motivo.CasasDecimais = 0
        Me.Motivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Motivo.CPObrigatorio = False
        Me.Motivo.CPObrigatorioMsg = Nothing
        Me.Motivo.Enabled = False
        Me.Motivo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Motivo.FlatBorder = False
        Me.Motivo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Motivo.FocusColor = System.Drawing.Color.Empty
        Me.Motivo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Motivo.HighlightBorderOnEnter = False
        Me.Motivo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Motivo.Location = New System.Drawing.Point(617, 118)
        Me.Motivo.MaxLength = 10000
        Me.Motivo.Name = "Motivo"
        Me.Motivo.PreencherZeroEsqueda = False
        Me.Motivo.RegraValidação = Nothing
        Me.Motivo.RegraValidaçãoMensagem = Nothing
        Me.Motivo.Size = New System.Drawing.Size(257, 23)
        Me.Motivo.TabIndex = 87
        Me.Motivo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Motivo.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(491, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Motivo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Solicitante
        '
        Me.Solicitante.AceitaColarTexto = True
        Me.Solicitante.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Solicitante.CasasDecimais = 0
        Me.Solicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Solicitante.CPObrigatorio = False
        Me.Solicitante.CPObrigatorioMsg = Nothing
        Me.Solicitante.Enabled = False
        Me.Solicitante.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Solicitante.FlatBorder = False
        Me.Solicitante.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Solicitante.FocusColor = System.Drawing.Color.Empty
        Me.Solicitante.FocusColorEnd = System.Drawing.Color.Empty
        Me.Solicitante.HighlightBorderOnEnter = False
        Me.Solicitante.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Solicitante.Location = New System.Drawing.Point(617, 89)
        Me.Solicitante.MaxLength = 50
        Me.Solicitante.Name = "Solicitante"
        Me.Solicitante.PreencherZeroEsqueda = False
        Me.Solicitante.RegraValidação = Nothing
        Me.Solicitante.RegraValidaçãoMensagem = Nothing
        Me.Solicitante.Size = New System.Drawing.Size(257, 23)
        Me.Solicitante.TabIndex = 85
        Me.Solicitante.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Solicitante.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(491, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Solicitante"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataOrdem
        '
        Me.DataOrdem.AceitaColarTexto = True
        Me.DataOrdem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataOrdem.CasasDecimais = 0
        Me.DataOrdem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataOrdem.CPObrigatorio = False
        Me.DataOrdem.CPObrigatorioMsg = Nothing
        Me.DataOrdem.Enabled = False
        Me.DataOrdem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataOrdem.FlatBorder = False
        Me.DataOrdem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataOrdem.FocusColor = System.Drawing.Color.Empty
        Me.DataOrdem.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataOrdem.HighlightBorderOnEnter = False
        Me.DataOrdem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataOrdem.Location = New System.Drawing.Point(617, 60)
        Me.DataOrdem.MaxLength = 10
        Me.DataOrdem.Name = "DataOrdem"
        Me.DataOrdem.PreencherZeroEsqueda = False
        Me.DataOrdem.RegraValidação = Nothing
        Me.DataOrdem.RegraValidaçãoMensagem = Nothing
        Me.DataOrdem.Size = New System.Drawing.Size(116, 23)
        Me.DataOrdem.TabIndex = 83
        Me.DataOrdem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataOrdem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataOrdem.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(491, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Data da Ordem"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrdemProducao
        '
        Me.OrdemProducao.AceitaColarTexto = True
        Me.OrdemProducao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.OrdemProducao.CasasDecimais = 0
        Me.OrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OrdemProducao.CPObrigatorio = False
        Me.OrdemProducao.CPObrigatorioMsg = Nothing
        Me.OrdemProducao.Enabled = False
        Me.OrdemProducao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OrdemProducao.FlatBorder = False
        Me.OrdemProducao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.OrdemProducao.FocusColor = System.Drawing.Color.Empty
        Me.OrdemProducao.FocusColorEnd = System.Drawing.Color.Empty
        Me.OrdemProducao.HighlightBorderOnEnter = False
        Me.OrdemProducao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.OrdemProducao.Location = New System.Drawing.Point(617, 31)
        Me.OrdemProducao.MaxLength = 15
        Me.OrdemProducao.Name = "OrdemProducao"
        Me.OrdemProducao.PreencherZeroEsqueda = False
        Me.OrdemProducao.RegraValidação = Nothing
        Me.OrdemProducao.RegraValidaçãoMensagem = Nothing
        Me.OrdemProducao.Size = New System.Drawing.Size(116, 23)
        Me.OrdemProducao.TabIndex = 81
        Me.OrdemProducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OrdemProducao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.OrdemProducao.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(491, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Nº da Ordem"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(820, 393)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(63, 23)
        Me.btFechar.TabIndex = 79
        Me.btFechar.Text = "Fechar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 19)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Ordens de Produção Confirmarda e Pendente no Estoque"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(12, 31)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(473, 356)
        Me.Lista.TabIndex = 77
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "OrdemProducao"
        Me.Column1.HeaderText = "Ordem"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Solicitante"
        Me.Column2.HeaderText = "Solicitante"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "DataOrdem"
        Me.Column3.HeaderText = "Data"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 90
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Confirmado"
        Me.Column4.HeaderText = "Confirmado"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "GeradoEstoque"
        Me.Column5.HeaderText = "Estoque"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ProducaoEstoqueConfirmar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ProducaoEstoqueConfirmar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar Odem de Produção em Estoque - T032"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeradoEstoque As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Confirmado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Motivo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Solicitante As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataOrdem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OrdemProducao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btConfirmarEstoque As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
