<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesReimpressao
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btnVisualizarimpressao = New DevComponents.DotNetBar.ButtonX()
        Me.rbnPorcodigo = New System.Windows.Forms.RadioButton()
        Me.rbnData = New System.Windows.Forms.RadioButton()
        Me.rbnVendedor = New System.Windows.Forms.RadioButton()
        Me.rdbNome = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProcurar = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.gpedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gdatavenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gtipovenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.btnFechar)
        Me.PanelEx1.Controls.Add(Me.btnVisualizarimpressao)
        Me.PanelEx1.Controls.Add(Me.rbnPorcodigo)
        Me.PanelEx1.Controls.Add(Me.rbnData)
        Me.PanelEx1.Controls.Add(Me.rbnVendedor)
        Me.PanelEx1.Controls.Add(Me.rdbNome)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.txtProcurar)
        Me.PanelEx1.Controls.Add(Me.Dgv)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(998, 561)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(598, 522)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(236, 30)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 32
        Me.ButtonX2.Text = "Visualizar Impressão  Valor Liquido"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(840, 486)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(152, 33)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 31
        Me.ButtonX1.Text = "Imprimir"
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFechar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(840, 522)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(152, 30)
        Me.btnFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFechar.TabIndex = 30
        Me.btnFechar.Text = "Fechar"
        '
        'btnVisualizarimpressao
        '
        Me.btnVisualizarimpressao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVisualizarimpressao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVisualizarimpressao.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizarimpressao.Location = New System.Drawing.Point(598, 486)
        Me.btnVisualizarimpressao.Name = "btnVisualizarimpressao"
        Me.btnVisualizarimpressao.Size = New System.Drawing.Size(236, 33)
        Me.btnVisualizarimpressao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVisualizarimpressao.TabIndex = 30
        Me.btnVisualizarimpressao.Text = "Visualizar Impressão Normal"
        '
        'rbnPorcodigo
        '
        Me.rbnPorcodigo.AutoSize = True
        Me.rbnPorcodigo.Location = New System.Drawing.Point(81, 486)
        Me.rbnPorcodigo.Name = "rbnPorcodigo"
        Me.rbnPorcodigo.Size = New System.Drawing.Size(110, 17)
        Me.rbnPorcodigo.TabIndex = 3
        Me.rbnPorcodigo.Text = "Código Venda[F4]"
        Me.rbnPorcodigo.UseVisualStyleBackColor = True
        '
        'rbnData
        '
        Me.rbnData.AutoSize = True
        Me.rbnData.Location = New System.Drawing.Point(292, 486)
        Me.rbnData.Name = "rbnData"
        Me.rbnData.Size = New System.Drawing.Size(66, 17)
        Me.rbnData.TabIndex = 3
        Me.rbnData.Text = "Data[F6]"
        Me.rbnData.UseVisualStyleBackColor = True
        '
        'rbnVendedor
        '
        Me.rbnVendedor.AutoSize = True
        Me.rbnVendedor.Location = New System.Drawing.Point(197, 486)
        Me.rbnVendedor.Name = "rbnVendedor"
        Me.rbnVendedor.Size = New System.Drawing.Size(89, 17)
        Me.rbnVendedor.TabIndex = 3
        Me.rbnVendedor.Text = "Vendedor[F5]"
        Me.rbnVendedor.UseVisualStyleBackColor = True
        '
        'rdbNome
        '
        Me.rdbNome.AutoSize = True
        Me.rdbNome.Checked = True
        Me.rdbNome.Location = New System.Drawing.Point(12, 486)
        Me.rdbNome.Name = "rdbNome"
        Me.rdbNome.Size = New System.Drawing.Size(71, 17)
        Me.rdbNome.TabIndex = 3
        Me.rdbNome.TabStop = True
        Me.rdbNome.Text = "Nome[F3]"
        Me.rdbNome.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(364, 484)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Procurar"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.txtProcurar.Location = New System.Drawing.Point(432, 484)
        Me.txtProcurar.MaxLength = 3000
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.PreencherZeroEsqueda = False
        Me.txtProcurar.RegraValidação = Nothing
        Me.txtProcurar.RegraValidaçãoMensagem = Nothing
        Me.txtProcurar.Size = New System.Drawing.Size(160, 24)
        Me.txtProcurar.TabIndex = 2
        Me.txtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcurar.ValorPadrao = Nothing
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.AllowUserToResizeColumns = False
        Me.Dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.BackgroundColor = System.Drawing.Color.White
        Me.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gpedido, Me.gdatavenda, Me.gVendedor, Me.gtipovenda, Me.Nome, Me.gTotal, Me.gstatus})
        Me.Dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.Location = New System.Drawing.Point(12, 12)
        Me.Dgv.MultiSelect = False
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.RowHeadersWidth = 15
        Me.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv.Size = New System.Drawing.Size(980, 468)
        Me.Dgv.TabIndex = 2
        '
        'gpedido
        '
        Me.gpedido.DataPropertyName = "pedidosequencia"
        Me.gpedido.HeaderText = "Pedido"
        Me.gpedido.Name = "gpedido"
        Me.gpedido.Width = 80
        '
        'gdatavenda
        '
        Me.gdatavenda.DataPropertyName = "datapedido"
        Me.gdatavenda.HeaderText = "Data Pedido"
        Me.gdatavenda.Name = "gdatavenda"
        '
        'gVendedor
        '
        Me.gVendedor.DataPropertyName = "vendedor"
        Me.gVendedor.HeaderText = "Vendedor"
        Me.gVendedor.Name = "gVendedor"
        Me.gVendedor.Width = 180
        '
        'gtipovenda
        '
        Me.gtipovenda.DataPropertyName = "pedidotipo"
        Me.gtipovenda.HeaderText = "Tipo Venda"
        Me.gtipovenda.Name = "gtipovenda"
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Cliente"
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 350
        '
        'gTotal
        '
        Me.gTotal.DataPropertyName = "TotalPedido"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0,00"
        Me.gTotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.gTotal.HeaderText = "Valor"
        Me.gTotal.Name = "gTotal"
        '
        'gstatus
        '
        Me.gstatus.DataPropertyName = "status"
        Me.gstatus.HeaderText = "Status"
        Me.gstatus.Name = "gstatus"
        Me.gstatus.Width = 60
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'SellShoesReimpressao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Name = "SellShoesReimpressao"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca Venda - T256"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents txtProcurar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rbnPorcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbnData As System.Windows.Forms.RadioButton
    Friend WithEvents rbnVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNome As System.Windows.Forms.RadioButton
    Friend WithEvents btnVisualizarimpressao As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gdatavenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gVendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gtipovenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
