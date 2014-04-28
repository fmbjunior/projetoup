<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutosGrade
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Sequencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QtdEst = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Numero = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GradeLista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cQtdEst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSequencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.GradeLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.GradeLista)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(370, 525)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Delete - Para excluir uma Numeração"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btSalvar)
        Me.GroupPanel1.Controls.Add(Me.btFechar)
        Me.GroupPanel1.Controls.Add(Me.Sequencia)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.QtdEst)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Numero)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 407)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(344, 106)
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
        Me.GroupPanel1.TabIndex = 1
        Me.GroupPanel1.Text = "Cadastro de Numeros"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(240, 24)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(95, 23)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 6
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(240, 53)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(95, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 7
        Me.btFechar.Text = "Fechar"
        '
        'Sequencia
        '
        Me.Sequencia.AceitaColarTexto = True
        Me.Sequencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Sequencia.CasasDecimais = 0
        Me.Sequencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Sequencia.CPObrigatorio = False
        Me.Sequencia.CPObrigatorioMsg = Nothing
        Me.Sequencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Sequencia.FlatBorder = False
        Me.Sequencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Sequencia.FocusColor = System.Drawing.Color.MistyRose
        Me.Sequencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Sequencia.HighlightBorderOnEnter = False
        Me.Sequencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Sequencia.Location = New System.Drawing.Point(163, 23)
        Me.Sequencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sequencia.Name = "Sequencia"
        Me.Sequencia.PreencherZeroEsqueda = False
        Me.Sequencia.RegraValidação = Nothing
        Me.Sequencia.RegraValidaçãoMensagem = Nothing
        Me.Sequencia.Size = New System.Drawing.Size(71, 23)
        Me.Sequencia.TabIndex = 5
        Me.Sequencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sequencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Sequencia.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(161, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sequência"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QtdEst
        '
        Me.QtdEst.AceitaColarTexto = True
        Me.QtdEst.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.QtdEst.CasasDecimais = 4
        Me.QtdEst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.QtdEst.CPObrigatorio = False
        Me.QtdEst.CPObrigatorioMsg = Nothing
        Me.QtdEst.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.QtdEst.FlatBorder = False
        Me.QtdEst.FlatBorderColor = System.Drawing.Color.DimGray
        Me.QtdEst.FocusColor = System.Drawing.Color.MistyRose
        Me.QtdEst.FocusColorEnd = System.Drawing.Color.Empty
        Me.QtdEst.HighlightBorderOnEnter = False
        Me.QtdEst.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.QtdEst.Location = New System.Drawing.Point(82, 23)
        Me.QtdEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QtdEst.Name = "QtdEst"
        Me.QtdEst.PreencherZeroEsqueda = False
        Me.QtdEst.RegraValidação = Nothing
        Me.QtdEst.RegraValidaçãoMensagem = Nothing
        Me.QtdEst.Size = New System.Drawing.Size(73, 23)
        Me.QtdEst.TabIndex = 4
        Me.QtdEst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.QtdEst.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.QtdEst.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(82, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantidade"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Numero
        '
        Me.Numero.AceitaColarTexto = True
        Me.Numero.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Numero.CasasDecimais = 0
        Me.Numero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Numero.CPObrigatorio = False
        Me.Numero.CPObrigatorioMsg = Nothing
        Me.Numero.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Numero.FlatBorder = False
        Me.Numero.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Numero.FocusColor = System.Drawing.Color.MistyRose
        Me.Numero.FocusColorEnd = System.Drawing.Color.Empty
        Me.Numero.HighlightBorderOnEnter = False
        Me.Numero.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Numero.Location = New System.Drawing.Point(5, 23)
        Me.Numero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Numero.Name = "Numero"
        Me.Numero.PreencherZeroEsqueda = False
        Me.Numero.RegraValidação = Nothing
        Me.Numero.RegraValidaçãoMensagem = Nothing
        Me.Numero.Size = New System.Drawing.Size(71, 23)
        Me.Numero.TabIndex = 3
        Me.Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Numero.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Numero.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GradeLista
        '
        Me.GradeLista.AllowUserToAddRows = False
        Me.GradeLista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        Me.GradeLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GradeLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GradeLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cProduto, Me.cNumero, Me.cQtdEst, Me.cSequencia})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GradeLista.DefaultCellStyle = DataGridViewCellStyle4
        Me.GradeLista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GradeLista.Location = New System.Drawing.Point(12, 12)
        Me.GradeLista.Name = "GradeLista"
        Me.GradeLista.ReadOnly = True
        Me.GradeLista.RowHeadersWidth = 20
        Me.GradeLista.SelectAllSignVisible = False
        Me.GradeLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GradeLista.Size = New System.Drawing.Size(344, 361)
        Me.GradeLista.TabIndex = 0
        '
        'cProduto
        '
        Me.cProduto.DataPropertyName = "Produto"
        Me.cProduto.HeaderText = "Produto"
        Me.cProduto.Name = "cProduto"
        Me.cProduto.ReadOnly = True
        Me.cProduto.Visible = False
        '
        'cNumero
        '
        Me.cNumero.DataPropertyName = "Numero"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cNumero.DefaultCellStyle = DataGridViewCellStyle2
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        Me.cNumero.ReadOnly = True
        '
        'cQtdEst
        '
        Me.cQtdEst.DataPropertyName = "QtdEst"
        Me.cQtdEst.HeaderText = "Qtd"
        Me.cQtdEst.Name = "cQtdEst"
        Me.cQtdEst.ReadOnly = True
        '
        'cSequencia
        '
        Me.cSequencia.DataPropertyName = "Sequencia"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cSequencia.DefaultCellStyle = DataGridViewCellStyle3
        Me.cSequencia.HeaderText = "Sequência"
        Me.cSequencia.Name = "cSequencia"
        Me.cSequencia.ReadOnly = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ProdutosGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProdutosGrade"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade de Produtos - T199"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.GradeLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GradeLista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Sequencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents QtdEst As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Numero As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cQtdEst As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSequencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
