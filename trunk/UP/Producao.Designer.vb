<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producao))
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.btConfirmar = New DevComponents.DotNetBar.ButtonX()
        Me.btProcurar = New DevComponents.DotNetBar.ButtonX()
        Me.btAddItem = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GeradoEstoque = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Confirmado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuListaItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Motivo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Solicitante = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataOrdem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OrdemProducao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.MenuListaItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btImprimir)
        Me.Fundo.Controls.Add(Me.btConfirmar)
        Me.Fundo.Controls.Add(Me.btProcurar)
        Me.Fundo.Controls.Add(Me.btAddItem)
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btNovo)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GeradoEstoque)
        Me.Fundo.Controls.Add(Me.Confirmado)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Motivo)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Solicitante)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.DataOrdem)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.OrdemProducao)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(652, 384)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btImprimir
        '
        Me.btImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImprimir.Location = New System.Drawing.Point(152, 354)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(94, 23)
        Me.btImprimir.TabIndex = 19
        Me.btImprimir.Text = "Imprimir"
        '
        'btConfirmar
        '
        Me.btConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConfirmar.Location = New System.Drawing.Point(252, 354)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(83, 23)
        Me.btConfirmar.TabIndex = 18
        Me.btConfirmar.Text = "Comfirmar"
        '
        'btProcurar
        '
        Me.btProcurar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btProcurar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btProcurar.Location = New System.Drawing.Point(341, 354)
        Me.btProcurar.Name = "btProcurar"
        Me.btProcurar.Size = New System.Drawing.Size(92, 23)
        Me.btProcurar.TabIndex = 17
        Me.btProcurar.Text = "Localizar Ordem"
        '
        'btAddItem
        '
        Me.btAddItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAddItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAddItem.Location = New System.Drawing.Point(15, 354)
        Me.btAddItem.Name = "btAddItem"
        Me.btAddItem.Size = New System.Drawing.Size(63, 23)
        Me.btAddItem.TabIndex = 16
        Me.btAddItem.Text = "Add Itens"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(439, 354)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(63, 23)
        Me.btSalvar.TabIndex = 13
        Me.btSalvar.Text = "Salvar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(508, 354)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(63, 23)
        Me.btNovo.TabIndex = 14
        Me.btNovo.Text = "Novo"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(577, 354)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(63, 23)
        Me.btFechar.TabIndex = 15
        Me.btFechar.Text = "Fechar"
        '
        'GeradoEstoque
        '
        '
        '
        '
        Me.GeradoEstoque.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GeradoEstoque.Enabled = False
        Me.GeradoEstoque.Location = New System.Drawing.Point(533, 108)
        Me.GeradoEstoque.Name = "GeradoEstoque"
        Me.GeradoEstoque.Size = New System.Drawing.Size(107, 23)
        Me.GeradoEstoque.TabIndex = 11
        Me.GeradoEstoque.Text = "Gerado Estoque"
        Me.GeradoEstoque.Visible = False
        '
        'Confirmado
        '
        '
        '
        '
        Me.Confirmado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Confirmado.Enabled = False
        Me.Confirmado.Location = New System.Drawing.Point(15, 108)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(87, 23)
        Me.Confirmado.TabIndex = 10
        Me.Confirmado.Text = "Confirmado"
        '
        'MyLista
        '
        Me.MyLista.BackColor = System.Drawing.Color.White
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader16})
        Me.MyLista.ContextMenuStrip = Me.MenuListaItem
        Me.MyLista.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(15, 137)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(625, 211)
        Me.MyLista.SmallImageList = Me.ImageList1
        Me.MyLista.TabIndex = 12
        Me.MyLista.TabStop = False
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Id"
        Me.ColumnHeader12.Width = 70
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ordem "
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Produto"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descrição"
        Me.ColumnHeader3.Width = 330
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Qtd"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 100
        '
        'MenuListaItem
        '
        Me.MenuListaItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirItemToolStripMenuItem})
        Me.MenuListaItem.Name = "MenuListaItem"
        Me.MenuListaItem.Size = New System.Drawing.Size(142, 26)
        '
        'ExcluirItemToolStripMenuItem
        '
        Me.ExcluirItemToolStripMenuItem.Name = "ExcluirItemToolStripMenuItem"
        Me.ExcluirItemToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ExcluirItemToolStripMenuItem.Text = "Excluir Item"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Produzir.png")
        '
        'Motivo
        '
        Me.Motivo.AceitaColarTexto = True
        Me.Motivo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Motivo.CasasDecimais = 0
        Me.Motivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Motivo.CPObrigatorio = False
        Me.Motivo.CPObrigatorioMsg = Nothing
        Me.Motivo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Motivo.FlatBorder = False
        Me.Motivo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Motivo.FocusColor = System.Drawing.Color.Empty
        Me.Motivo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Motivo.HighlightBorderOnEnter = False
        Me.Motivo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Motivo.Location = New System.Drawing.Point(138, 79)
        Me.Motivo.MaxLength = 10000
        Me.Motivo.Name = "Motivo"
        Me.Motivo.PreencherZeroEsqueda = False
        Me.Motivo.RegraValidação = Nothing
        Me.Motivo.RegraValidaçãoMensagem = Nothing
        Me.Motivo.Size = New System.Drawing.Size(502, 23)
        Me.Motivo.TabIndex = 7
        Me.Motivo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Motivo.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 6
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
        Me.Solicitante.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Solicitante.FlatBorder = False
        Me.Solicitante.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Solicitante.FocusColor = System.Drawing.Color.Empty
        Me.Solicitante.FocusColorEnd = System.Drawing.Color.Empty
        Me.Solicitante.HighlightBorderOnEnter = False
        Me.Solicitante.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Solicitante.Location = New System.Drawing.Point(138, 50)
        Me.Solicitante.MaxLength = 50
        Me.Solicitante.Name = "Solicitante"
        Me.Solicitante.PreencherZeroEsqueda = False
        Me.Solicitante.RegraValidação = Nothing
        Me.Solicitante.RegraValidaçãoMensagem = Nothing
        Me.Solicitante.Size = New System.Drawing.Size(502, 23)
        Me.Solicitante.TabIndex = 5
        Me.Solicitante.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Solicitante.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 4
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
        Me.DataOrdem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataOrdem.FlatBorder = False
        Me.DataOrdem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataOrdem.FocusColor = System.Drawing.Color.Empty
        Me.DataOrdem.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataOrdem.HighlightBorderOnEnter = False
        Me.DataOrdem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataOrdem.Location = New System.Drawing.Point(524, 21)
        Me.DataOrdem.MaxLength = 10
        Me.DataOrdem.Name = "DataOrdem"
        Me.DataOrdem.PreencherZeroEsqueda = False
        Me.DataOrdem.RegraValidação = Nothing
        Me.DataOrdem.RegraValidaçãoMensagem = Nothing
        Me.DataOrdem.Size = New System.Drawing.Size(116, 23)
        Me.DataOrdem.TabIndex = 3
        Me.DataOrdem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataOrdem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataOrdem.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(398, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 2
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
        Me.OrdemProducao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.OrdemProducao.FlatBorder = False
        Me.OrdemProducao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.OrdemProducao.FocusColor = System.Drawing.Color.Empty
        Me.OrdemProducao.FocusColorEnd = System.Drawing.Color.Empty
        Me.OrdemProducao.HighlightBorderOnEnter = False
        Me.OrdemProducao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.OrdemProducao.Location = New System.Drawing.Point(138, 21)
        Me.OrdemProducao.MaxLength = 15
        Me.OrdemProducao.Name = "OrdemProducao"
        Me.OrdemProducao.PreencherZeroEsqueda = False
        Me.OrdemProducao.RegraValidação = Nothing
        Me.OrdemProducao.RegraValidaçãoMensagem = Nothing
        Me.OrdemProducao.Size = New System.Drawing.Size(116, 23)
        Me.OrdemProducao.TabIndex = 1
        Me.OrdemProducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OrdemProducao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.OrdemProducao.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº da Ordem"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'Producao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "Producao"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordem de Produção - T031"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.MenuListaItem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Motivo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Solicitante As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataOrdem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OrdemProducao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GeradoEstoque As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Confirmado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAddItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btProcurar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btConfirmar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MenuListaItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
