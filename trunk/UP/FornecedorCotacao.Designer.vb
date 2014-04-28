<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FornecedorCotacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FornecedorCotacao))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.dgitem = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.codFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RazaoSocial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Aprovar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.mnuAprovarDesaprovar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AtivarApontar = New System.Windows.Forms.ToolStripMenuItem
        Me.DesativarApont = New System.Windows.Forms.ToolStripMenuItem
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DescricaoFornecedor = New TexBoxFocusNet.TextBoxFocusNet
        Me.Condicaopagamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Valor = New TexBoxFocusNet.TextBoxFocusNet
        Me.CodigoFornecedor = New TexBoxFocusNet.TextBoxFocusNet
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuAprovarDesaprovar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.dgitem)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.DescricaoFornecedor)
        Me.PanelEx1.Controls.Add(Me.Condicaopagamento)
        Me.PanelEx1.Controls.Add(Me.Valor)
        Me.PanelEx1.Controls.Add(Me.CodigoFornecedor)
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(652, 298)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'dgitem
        '
        Me.dgitem.AllowUserToAddRows = False
        Me.dgitem.AllowUserToDeleteRows = False
        Me.dgitem.AllowUserToResizeColumns = False
        Me.dgitem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgitem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgitem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.codFornecedor, Me.RazaoSocial, Me.Column1, Me.Column2, Me.Aprovar})
        Me.dgitem.Location = New System.Drawing.Point(3, 85)
        Me.dgitem.Name = "dgitem"
        Me.dgitem.ReadOnly = True
        Me.dgitem.RowHeadersVisible = False
        Me.dgitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgitem.ShowEditingIcon = False
        Me.dgitem.Size = New System.Drawing.Size(643, 172)
        Me.dgitem.TabIndex = 3
        Me.dgitem.TabStop = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'codFornecedor
        '
        Me.codFornecedor.DataPropertyName = "CodigoFornecedor"
        Me.codFornecedor.HeaderText = "Cod For"
        Me.codFornecedor.Name = "codFornecedor"
        Me.codFornecedor.ReadOnly = True
        Me.codFornecedor.Width = 70
        '
        'RazaoSocial
        '
        Me.RazaoSocial.DataPropertyName = "RazãoSocial"
        Me.RazaoSocial.HeaderText = "Razão Social"
        Me.RazaoSocial.Name = "RazaoSocial"
        Me.RazaoSocial.ReadOnly = True
        Me.RazaoSocial.Width = 300
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Valor"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Vlr Orçado"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Condicaopagamento"
        Me.Column2.HeaderText = "Condição Pagamento"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Aprovar
        '
        Me.Aprovar.ContextMenuStrip = Me.mnuAprovarDesaprovar
        Me.Aprovar.DataPropertyName = "Ap"
        Me.Aprovar.HeaderText = "Ap?"
        Me.Aprovar.Name = "Aprovar"
        Me.Aprovar.ReadOnly = True
        Me.Aprovar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Aprovar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Aprovar.Width = 30
        '
        'mnuAprovarDesaprovar
        '
        Me.mnuAprovarDesaprovar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivarApontar, Me.DesativarApont})
        Me.mnuAprovarDesaprovar.Name = "mnuAtivarApontamento"
        Me.mnuAprovarDesaprovar.Size = New System.Drawing.Size(134, 48)
        '
        'AtivarApontar
        '
        Me.AtivarApontar.Image = CType(resources.GetObject("AtivarApontar.Image"), System.Drawing.Image)
        Me.AtivarApontar.Name = "AtivarApontar"
        Me.AtivarApontar.Size = New System.Drawing.Size(133, 22)
        Me.AtivarApontar.Text = "Aprovar"
        '
        'DesativarApont
        '
        Me.DesativarApont.Image = CType(resources.GetObject("DesativarApont.Image"), System.Drawing.Image)
        Me.DesativarApont.Name = "DesativarApont"
        Me.DesativarApont.Size = New System.Drawing.Size(133, 22)
        Me.DesativarApont.Text = "Desaprovar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Condição Pgto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fornecedor"
        '
        'DescricaoFornecedor
        '
        Me.DescricaoFornecedor.AceitaColarTexto = True
        Me.DescricaoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescricaoFornecedor.CasasDecimais = 2
        Me.DescricaoFornecedor.CPObrigatorio = False
        Me.DescricaoFornecedor.CPObrigatorioMsg = Nothing
        Me.DescricaoFornecedor.Enabled = False
        Me.DescricaoFornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescricaoFornecedor.FocusColor = System.Drawing.Color.Empty
        Me.DescricaoFornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescricaoFornecedor.Location = New System.Drawing.Point(133, 24)
        Me.DescricaoFornecedor.Name = "DescricaoFornecedor"
        Me.DescricaoFornecedor.RegraValidação = Nothing
        Me.DescricaoFornecedor.RegraValidaçãoMensagem = Nothing
        Me.DescricaoFornecedor.Size = New System.Drawing.Size(362, 20)
        Me.DescricaoFornecedor.TabIndex = 2
        Me.DescricaoFornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescricaoFornecedor.ValorPadrao = Nothing
        '
        'Condicaopagamento
        '
        Me.Condicaopagamento.AceitaColarTexto = True
        Me.Condicaopagamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Condicaopagamento.CasasDecimais = 2
        Me.Condicaopagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Condicaopagamento.CPObrigatorio = False
        Me.Condicaopagamento.CPObrigatorioMsg = Nothing
        Me.Condicaopagamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Condicaopagamento.FocusColor = System.Drawing.Color.Empty
        Me.Condicaopagamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Condicaopagamento.Location = New System.Drawing.Point(263, 53)
        Me.Condicaopagamento.Name = "Condicaopagamento"
        Me.Condicaopagamento.RegraValidação = Nothing
        Me.Condicaopagamento.RegraValidaçãoMensagem = Nothing
        Me.Condicaopagamento.Size = New System.Drawing.Size(232, 20)
        Me.Condicaopagamento.TabIndex = 6
        Me.Condicaopagamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Condicaopagamento.ValorPadrao = Nothing
        '
        'Valor
        '
        Me.Valor.AceitaColarTexto = True
        Me.Valor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Valor.CasasDecimais = 2
        Me.Valor.CPObrigatorio = False
        Me.Valor.CPObrigatorioMsg = Nothing
        Me.Valor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Valor.FocusColor = System.Drawing.Color.Empty
        Me.Valor.FocusColorEnd = System.Drawing.Color.Empty
        Me.Valor.Location = New System.Drawing.Point(71, 50)
        Me.Valor.MaxLength = 10
        Me.Valor.Name = "Valor"
        Me.Valor.RegraValidação = Nothing
        Me.Valor.RegraValidaçãoMensagem = Nothing
        Me.Valor.Size = New System.Drawing.Size(91, 20)
        Me.Valor.TabIndex = 4
        Me.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Valor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Valor.ValorPadrao = Nothing
        '
        'CodigoFornecedor
        '
        Me.CodigoFornecedor.AceitaColarTexto = True
        Me.CodigoFornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoFornecedor.CasasDecimais = 2
        Me.CodigoFornecedor.CPObrigatorio = False
        Me.CodigoFornecedor.CPObrigatorioMsg = Nothing
        Me.CodigoFornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoFornecedor.FocusColor = System.Drawing.Color.Empty
        Me.CodigoFornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoFornecedor.Location = New System.Drawing.Point(71, 24)
        Me.CodigoFornecedor.Name = "CodigoFornecedor"
        Me.CodigoFornecedor.RegraValidação = Nothing
        Me.CodigoFornecedor.RegraValidaçãoMensagem = Nothing
        Me.CodigoFornecedor.Size = New System.Drawing.Size(56, 20)
        Me.CodigoFornecedor.TabIndex = 1
        Me.CodigoFornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoFornecedor.ValorPadrao = Nothing
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(93, 263)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.TabIndex = 7
        Me.ButtonX2.Text = "Salvar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(12, 263)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.TabIndex = 8
        Me.ButtonX1.Text = "Fechar"
        '
        'FornecedorCotacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FornecedorCotacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotação de Fornecedor"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.dgitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuAprovarDesaprovar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DescricaoFornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Condicaopagamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Valor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoFornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgitem As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mnuAprovarDesaprovar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AtivarApontar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesativarApont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazaoSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aprovar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
