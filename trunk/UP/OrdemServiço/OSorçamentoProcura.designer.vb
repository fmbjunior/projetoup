<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OSorçamentoProcura
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TipoProcura = New System.Windows.Forms.GroupBox()
        Me.Todos = New System.Windows.Forms.RadioButton()
        Me.Cliente = New System.Windows.Forms.RadioButton()
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Pedido = New System.Windows.Forms.RadioButton()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.g_orcamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_datadoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.Label()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TipoProcura.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoProcura
        '
        Me.TipoProcura.Controls.Add(Me.Todos)
        Me.TipoProcura.Controls.Add(Me.Cliente)
        Me.TipoProcura.Controls.Add(Me.TxtProcura)
        Me.TipoProcura.Controls.Add(Me.Pedido)
        Me.TipoProcura.Location = New System.Drawing.Point(16, 7)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(811, 40)
        Me.TipoProcura.TabIndex = 0
        Me.TipoProcura.TabStop = False
        Me.TipoProcura.Text = "Tipo de Procura"
        '
        'Todos
        '
        Me.Todos.AutoSize = True
        Me.Todos.Location = New System.Drawing.Point(268, 15)
        Me.Todos.Name = "Todos"
        Me.Todos.Size = New System.Drawing.Size(129, 17)
        Me.Todos.TabIndex = 2
        Me.Todos.TabStop = True
        Me.Todos.Text = "Todos os Orçamentos"
        Me.Todos.UseVisualStyleBackColor = True
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(170, 15)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(76, 17)
        Me.Cliente.TabIndex = 1
        Me.Cliente.TabStop = True
        Me.Cliente.Text = "Por Cliente"
        Me.Cliente.UseVisualStyleBackColor = True
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
        Me.TxtProcura.Location = New System.Drawing.Point(418, 12)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.PreencherZeroEsqueda = False
        Me.TxtProcura.RegraValidação = Nothing
        Me.TxtProcura.RegraValidaçãoMensagem = Nothing
        Me.TxtProcura.Size = New System.Drawing.Size(387, 23)
        Me.TxtProcura.TabIndex = 2
        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'Pedido
        '
        Me.Pedido.Location = New System.Drawing.Point(27, 15)
        Me.Pedido.Name = "Pedido"
        Me.Pedido.Size = New System.Drawing.Size(137, 17)
        Me.Pedido.TabIndex = 0
        Me.Pedido.TabStop = True
        Me.Pedido.Text = "Nº Orçamento"
        Me.Pedido.UseVisualStyleBackColor = True
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.dgvItem)
        Me.PanelEx1.Controls.Add(Me.Obs)
        Me.PanelEx1.Controls.Add(Me.btAtualizar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.TipoProcura)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(839, 499)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.AllowUserToOrderColumns = True
        Me.dgvItem.AllowUserToResizeColumns = False
        Me.dgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue
        Me.dgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItem.BackgroundColor = System.Drawing.Color.White
        Me.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItem.ColumnHeadersHeight = 18
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.g_orcamento, Me.g_valor, Me.g_cliente, Me.g_cidade, Me.g_datadoc, Me.g_status, Me.g_obs})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItem.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItem.EnableHeadersVisualStyles = False
        Me.dgvItem.Location = New System.Drawing.Point(16, 53)
        Me.dgvItem.MultiSelect = False
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.RowHeadersVisible = False
        Me.dgvItem.RowHeadersWidth = 15
        Me.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItem.Size = New System.Drawing.Size(811, 338)
        Me.dgvItem.TabIndex = 34
        '
        'g_orcamento
        '
        Me.g_orcamento.DataPropertyName = "orcamento"
        DataGridViewCellStyle3.Format = "000000"
        Me.g_orcamento.DefaultCellStyle = DataGridViewCellStyle3
        Me.g_orcamento.HeaderText = "Nº Orç."
        Me.g_orcamento.Name = "g_orcamento"
        Me.g_orcamento.Width = 90
        '
        'g_valor
        '
        Me.g_valor.DataPropertyName = "totalorcamento"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.g_valor.DefaultCellStyle = DataGridViewCellStyle4
        Me.g_valor.HeaderText = "Valor"
        Me.g_valor.Name = "g_valor"
        '
        'g_cliente
        '
        Me.g_cliente.DataPropertyName = "nomecliente"
        Me.g_cliente.HeaderText = "Cliente"
        Me.g_cliente.Name = "g_cliente"
        Me.g_cliente.Width = 250
        '
        'g_cidade
        '
        Me.g_cidade.DataPropertyName = "cidade"
        Me.g_cidade.HeaderText = "Cidade"
        Me.g_cidade.Name = "g_cidade"
        Me.g_cidade.Width = 150
        '
        'g_datadoc
        '
        Me.g_datadoc.DataPropertyName = "dataorcamento"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.g_datadoc.DefaultCellStyle = DataGridViewCellStyle5
        Me.g_datadoc.HeaderText = "Data Doc"
        Me.g_datadoc.Name = "g_datadoc"
        Me.g_datadoc.Width = 75
        '
        'g_status
        '
        Me.g_status.DataPropertyName = "st"
        Me.g_status.HeaderText = "Status"
        Me.g_status.Name = "g_status"
        '
        'g_obs
        '
        Me.g_obs.DataPropertyName = "ObsServico"
        Me.g_obs.HeaderText = "Obs"
        Me.g_obs.Name = "g_obs"
        Me.g_obs.Visible = False
        '
        'Obs
        '
        Me.Obs.Location = New System.Drawing.Point(16, 423)
        Me.Obs.Name = "Obs"
        Me.Obs.Size = New System.Drawing.Size(625, 68)
        Me.Obs.TabIndex = 6
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Location = New System.Drawing.Point(669, 466)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(76, 25)
        Me.btAtualizar.TabIndex = 4
        Me.btAtualizar.Text = "Atualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(751, 466)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(76, 25)
        Me.btFechar.TabIndex = 5
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'OSorçamentoProcura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(839, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OSorçamentoProcura"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar Orçamento - T231"
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TipoProcura As System.Windows.Forms.GroupBox
    Friend WithEvents Cliente As System.Windows.Forms.RadioButton
    Friend WithEvents Pedido As System.Windows.Forms.RadioButton
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Todos As System.Windows.Forms.RadioButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Obs As System.Windows.Forms.Label
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents g_orcamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_cidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_datadoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g_obs As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
