<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaProcuraDocumento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TipoProcura = New System.Windows.Forms.GroupBox()
        Me.DocumentoFornecedor = New System.Windows.Forms.RadioButton()
        Me.MostraTodos = New System.Windows.Forms.RadioButton()
        Me.AlfaNumerica = New System.Windows.Forms.RadioButton()
        Me.CampoChave = New System.Windows.Forms.RadioButton()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFornecedorDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNotaFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValorPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gDataLancamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cInativo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cConfirmado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TipoProcura.SuspendLayout()
        Me.Fundo.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Procurar"
        '
        'TipoProcura
        '
        Me.TipoProcura.BackColor = System.Drawing.Color.Transparent
        Me.TipoProcura.Controls.Add(Me.DocumentoFornecedor)
        Me.TipoProcura.Controls.Add(Me.MostraTodos)
        Me.TipoProcura.Controls.Add(Me.AlfaNumerica)
        Me.TipoProcura.Controls.Add(Me.CampoChave)
        Me.TipoProcura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoProcura.Location = New System.Drawing.Point(12, 12)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(861, 43)
        Me.TipoProcura.TabIndex = 0
        Me.TipoProcura.TabStop = False
        Me.TipoProcura.Text = "Tipo de Procura"
        '
        'DocumentoFornecedor
        '
        Me.DocumentoFornecedor.AutoSize = True
        Me.DocumentoFornecedor.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentoFornecedor.Location = New System.Drawing.Point(210, 17)
        Me.DocumentoFornecedor.Name = "DocumentoFornecedor"
        Me.DocumentoFornecedor.Size = New System.Drawing.Size(142, 19)
        Me.DocumentoFornecedor.TabIndex = 2
        Me.DocumentoFornecedor.Text = "Documento Fornecedor"
        Me.DocumentoFornecedor.UseVisualStyleBackColor = True
        '
        'MostraTodos
        '
        Me.MostraTodos.AutoSize = True
        Me.MostraTodos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostraTodos.Location = New System.Drawing.Point(358, 18)
        Me.MostraTodos.Name = "MostraTodos"
        Me.MostraTodos.Size = New System.Drawing.Size(99, 19)
        Me.MostraTodos.TabIndex = 3
        Me.MostraTodos.Text = "Mostrar Todos"
        Me.MostraTodos.UseVisualStyleBackColor = True
        '
        'AlfaNumerica
        '
        Me.AlfaNumerica.AutoSize = True
        Me.AlfaNumerica.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlfaNumerica.Location = New System.Drawing.Point(121, 16)
        Me.AlfaNumerica.Name = "AlfaNumerica"
        Me.AlfaNumerica.Size = New System.Drawing.Size(83, 19)
        Me.AlfaNumerica.TabIndex = 1
        Me.AlfaNumerica.Text = "Fornecedor"
        Me.AlfaNumerica.UseVisualStyleBackColor = True
        '
        'CampoChave
        '
        Me.CampoChave.AutoSize = True
        Me.CampoChave.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CampoChave.Location = New System.Drawing.Point(23, 16)
        Me.CampoChave.Name = "CampoChave"
        Me.CampoChave.Size = New System.Drawing.Size(92, 19)
        Me.CampoChave.TabIndex = 0
        Me.CampoChave.Text = "Campo Chave"
        Me.CampoChave.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.lblDestino)
        Me.Fundo.Controls.Add(Me.Lista)
        Me.Fundo.Controls.Add(Me.TxtProcura)
        Me.Fundo.Controls.Add(Me.btnFechar)
        Me.Fundo.Controls.Add(Me.TipoProcura)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(893, 480)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'lblDestino
        '
        Me.lblDestino.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDestino.Location = New System.Drawing.Point(13, 441)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(679, 27)
        Me.lblDestino.TabIndex = 5
        Me.lblDestino.Text = "Destino"
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cFornecedorDesc, Me.cNotaFiscal, Me.cValorPedido, Me.cTipo, Me.gDataLancamento, Me.cInativo, Me.cConfirmado, Me.gDestino})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle4
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(12, 106)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(865, 329)
        Me.Lista.TabIndex = 3
        '
        'cId
        '
        Me.cId.DataPropertyName = "Id"
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Width = 80
        '
        'cFornecedorDesc
        '
        Me.cFornecedorDesc.DataPropertyName = "FornecedorDesc"
        Me.cFornecedorDesc.HeaderText = "Fornecedor"
        Me.cFornecedorDesc.Name = "cFornecedorDesc"
        Me.cFornecedorDesc.ReadOnly = True
        Me.cFornecedorDesc.Width = 290
        '
        'cNotaFiscal
        '
        Me.cNotaFiscal.DataPropertyName = "NotaFiscal"
        Me.cNotaFiscal.HeaderText = "NF"
        Me.cNotaFiscal.Name = "cNotaFiscal"
        Me.cNotaFiscal.ReadOnly = True
        '
        'cValorPedido
        '
        Me.cValorPedido.DataPropertyName = "ValorPedido"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cValorPedido.DefaultCellStyle = DataGridViewCellStyle2
        Me.cValorPedido.HeaderText = "Valor Pedido"
        Me.cValorPedido.Name = "cValorPedido"
        Me.cValorPedido.ReadOnly = True
        '
        'cTipo
        '
        Me.cTipo.DataPropertyName = "Tipo"
        Me.cTipo.HeaderText = "Tipo"
        Me.cTipo.Name = "cTipo"
        Me.cTipo.ReadOnly = True
        '
        'gDataLancamento
        '
        Me.gDataLancamento.DataPropertyName = "DataLançamento"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.gDataLancamento.DefaultCellStyle = DataGridViewCellStyle3
        Me.gDataLancamento.HeaderText = "Dt. Lanç"
        Me.gDataLancamento.Name = "gDataLancamento"
        Me.gDataLancamento.ReadOnly = True
        Me.gDataLancamento.Width = 80
        '
        'cInativo
        '
        Me.cInativo.DataPropertyName = "Inativo"
        Me.cInativo.HeaderText = "Canc."
        Me.cInativo.Name = "cInativo"
        Me.cInativo.ReadOnly = True
        Me.cInativo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cInativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cInativo.Width = 40
        '
        'cConfirmado
        '
        Me.cConfirmado.DataPropertyName = "Confirmado"
        Me.cConfirmado.HeaderText = "Conf."
        Me.cConfirmado.Name = "cConfirmado"
        Me.cConfirmado.ReadOnly = True
        Me.cConfirmado.Width = 40
        '
        'gDestino
        '
        Me.gDestino.DataPropertyName = "Destino"
        Me.gDestino.HeaderText = "Destino"
        Me.gDestino.Name = "gDestino"
        Me.gDestino.ReadOnly = True
        Me.gDestino.Visible = False
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
        Me.TxtProcura.Location = New System.Drawing.Point(12, 77)
        Me.TxtProcura.MaxLength = 250
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.PreencherZeroEsqueda = False
        Me.TxtProcura.RegraValidação = Nothing
        Me.TxtProcura.RegraValidaçãoMensagem = Nothing
        Me.TxtProcura.Size = New System.Drawing.Size(864, 23)
        Me.TxtProcura.TabIndex = 2
        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(774, 441)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(113, 27)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'TelaProcuraDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(893, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TelaProcuraDocumento"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar - T209"
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TipoProcura As System.Windows.Forms.GroupBox
    Friend WithEvents AlfaNumerica As System.Windows.Forms.RadioButton
    Friend WithEvents CampoChave As System.Windows.Forms.RadioButton
    Friend WithEvents MostraTodos As System.Windows.Forms.RadioButton
    Friend WithEvents DocumentoFornecedor As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Public WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFornecedorDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNotaFiscal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cValorPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gDataLancamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cInativo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cConfirmado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents gDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents lblDestino As System.Windows.Forms.Label
End Class
