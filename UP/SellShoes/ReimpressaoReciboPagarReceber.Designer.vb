<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReimpressaoReciboPagarReceber
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PainelDocumento = New System.Windows.Forms.Panel()
        Me.txtProcurar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PorDocumento = New System.Windows.Forms.RadioButton()
        Me.PorPeriodo = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.rdbB = New System.Windows.Forms.RadioButton()
        Me.rdbA = New System.Windows.Forms.RadioButton()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FornecedorCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.PainelDocumento.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PainelDocumento)
        Me.PanelEx1.Controls.Add(Me.PainelPeriodo)
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.btnFechar)
        Me.PanelEx1.Controls.Add(Me.rdbB)
        Me.PanelEx1.Controls.Add(Me.rdbA)
        Me.PanelEx1.Controls.Add(Me.dgvItem)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(771, 483)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PainelDocumento
        '
        Me.PainelDocumento.Controls.Add(Me.txtProcurar)
        Me.PainelDocumento.Controls.Add(Me.LabelX1)
        Me.PainelDocumento.Location = New System.Drawing.Point(553, 3)
        Me.PainelDocumento.Name = "PainelDocumento"
        Me.PainelDocumento.Size = New System.Drawing.Size(113, 52)
        Me.PainelDocumento.TabIndex = 4
        Me.PainelDocumento.Visible = False
        '
        'txtProcurar
        '
        Me.txtProcurar.AceitaColarTexto = True
        Me.txtProcurar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcurar.CasasDecimais = 0
        Me.txtProcurar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcurar.CPObrigatorio = False
        Me.txtProcurar.CPObrigatorioMsg = Nothing
        Me.txtProcurar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtProcurar.FlatBorder = False
        Me.txtProcurar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtProcurar.FocusColor = System.Drawing.Color.Empty
        Me.txtProcurar.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtProcurar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcurar.HighlightBorderOnEnter = False
        Me.txtProcurar.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtProcurar.Location = New System.Drawing.Point(3, 26)
        Me.txtProcurar.MaxLength = 3000
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.PreencherZeroEsqueda = False
        Me.txtProcurar.RegraValidação = Nothing
        Me.txtProcurar.RegraValidaçãoMensagem = Nothing
        Me.txtProcurar.Size = New System.Drawing.Size(103, 24)
        Me.txtProcurar.TabIndex = 1
        Me.txtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcurar.ValorPadrao = Nothing
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(3, 1)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(103, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Informe Documento"
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.LabelX3)
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(348, 3)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(200, 53)
        Me.PainelPeriodo.TabIndex = 3
        Me.PainelPeriodo.Visible = False
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(3, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(114, 19)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Informe o Período"
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FlatBorder = False
        Me.DataFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataFinal.HighlightBorderOnEnter = False
        Me.DataFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataFinal.Location = New System.Drawing.Point(100, 26)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(91, 24)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataInicial.CasasDecimais = 0
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FlatBorder = False
        Me.DataInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataInicial.HighlightBorderOnEnter = False
        Me.DataInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataInicial.Location = New System.Drawing.Point(3, 26)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(91, 24)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PorDocumento)
        Me.GroupBox1.Controls.Add(Me.PorPeriodo)
        Me.GroupBox1.Location = New System.Drawing.Point(116, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 42)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione uma opção de Filtro"
        '
        'PorDocumento
        '
        Me.PorDocumento.AutoSize = True
        Me.PorDocumento.Location = New System.Drawing.Point(94, 19)
        Me.PorDocumento.Name = "PorDocumento"
        Me.PorDocumento.Size = New System.Drawing.Size(99, 17)
        Me.PorDocumento.TabIndex = 1
        Me.PorDocumento.Text = "Por Documento"
        Me.PorDocumento.UseVisualStyleBackColor = True
        '
        'PorPeriodo
        '
        Me.PorPeriodo.AutoSize = True
        Me.PorPeriodo.Location = New System.Drawing.Point(6, 19)
        Me.PorPeriodo.Name = "PorPeriodo"
        Me.PorPeriodo.Size = New System.Drawing.Size(82, 17)
        Me.PorPeriodo.TabIndex = 0
        Me.PorPeriodo.Text = "Por Período"
        Me.PorPeriodo.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(11, 453)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(376, 23)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Dar dois clicks sobre o Documento para reimprimir"
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFechar.Location = New System.Drawing.Point(691, 453)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(68, 23)
        Me.btnFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.Text = "Fechar"
        '
        'rdbB
        '
        Me.rdbB.AutoSize = True
        Me.rdbB.Location = New System.Drawing.Point(12, 35)
        Me.rdbB.Name = "rdbB"
        Me.rdbB.Size = New System.Drawing.Size(66, 17)
        Me.rdbB.TabIndex = 2
        Me.rdbB.Text = "Receber"
        Me.rdbB.UseVisualStyleBackColor = True
        '
        'rdbA
        '
        Me.rdbA.AutoSize = True
        Me.rdbA.Checked = True
        Me.rdbA.Location = New System.Drawing.Point(12, 12)
        Me.rdbA.Name = "rdbA"
        Me.rdbA.Size = New System.Drawing.Size(53, 17)
        Me.rdbA.TabIndex = 0
        Me.rdbA.TabStop = True
        Me.rdbA.Text = "Pagar"
        Me.rdbA.UseVisualStyleBackColor = True
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.AllowUserToResizeColumns = False
        Me.dgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Doc, Me.FornecedorCliente, Me.DataMov, Me.Valor})
        Me.dgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItem.Location = New System.Drawing.Point(11, 58)
        Me.dgvItem.MultiSelect = False
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.ReadOnly = True
        Me.dgvItem.RowHeadersVisible = False
        Me.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItem.Size = New System.Drawing.Size(748, 389)
        Me.dgvItem.TabIndex = 5
        '
        'id
        '
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 80
        '
        'Doc
        '
        Me.Doc.DataPropertyName = "Doc"
        Me.Doc.HeaderText = "Documento"
        Me.Doc.Name = "Doc"
        Me.Doc.ReadOnly = True
        Me.Doc.Width = 120
        '
        'FornecedorCliente
        '
        Me.FornecedorCliente.DataPropertyName = "FornecedorCliente"
        Me.FornecedorCliente.HeaderText = "Fornecedor/Cliente"
        Me.FornecedorCliente.Name = "FornecedorCliente"
        Me.FornecedorCliente.ReadOnly = True
        Me.FornecedorCliente.Width = 320
        '
        'DataMov
        '
        Me.DataMov.DataPropertyName = "DataMov"
        Me.DataMov.HeaderText = "DataMov"
        Me.DataMov.Name = "DataMov"
        Me.DataMov.ReadOnly = True
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "ValorL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle2
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ReimpressaoReciboPagarReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ReimpressaoReciboPagarReceber"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimpressão Recibo de Pagar e Receber - T075"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.PainelDocumento.ResumeLayout(False)
        Me.PainelDocumento.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents rdbB As System.Windows.Forms.RadioButton
    Friend WithEvents rdbA As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtProcurar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FornecedorCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PainelDocumento As System.Windows.Forms.Panel
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PorDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents PorPeriodo As System.Windows.Forms.RadioButton
End Class
