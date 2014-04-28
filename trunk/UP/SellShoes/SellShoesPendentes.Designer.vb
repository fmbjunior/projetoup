<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesPendentes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellShoesPendentes))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btAtivarCaixa = New DevComponents.DotNetBar.ButtonX()
        Me.VendaNumero = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btAtulizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cPedidoSequencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDataPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStatusAndamentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipoPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btAtivarCaixa)
        Me.PanelEx1.Controls.Add(Me.VendaNumero)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.btAtulizar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(926, 665)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btAtivarCaixa
        '
        Me.btAtivarCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtivarCaixa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtivarCaixa.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtivarCaixa.Location = New System.Drawing.Point(557, 626)
        Me.btAtivarCaixa.Name = "btAtivarCaixa"
        Me.btAtivarCaixa.Size = New System.Drawing.Size(115, 33)
        Me.btAtivarCaixa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAtivarCaixa.TabIndex = 6
        Me.btAtivarCaixa.Text = "Ativar &Caixa"
        '
        'VendaNumero
        '
        Me.VendaNumero.AceitaColarTexto = True
        Me.VendaNumero.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.VendaNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VendaNumero.CasasDecimais = 0
        Me.VendaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VendaNumero.CPObrigatorio = False
        Me.VendaNumero.CPObrigatorioMsg = Nothing
        Me.VendaNumero.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VendaNumero.FlatBorder = False
        Me.VendaNumero.FlatBorderColor = System.Drawing.Color.DimGray
        Me.VendaNumero.FocusColor = System.Drawing.Color.Empty
        Me.VendaNumero.FocusColorEnd = System.Drawing.Color.Empty
        Me.VendaNumero.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendaNumero.HighlightBorderOnEnter = False
        Me.VendaNumero.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.VendaNumero.Location = New System.Drawing.Point(185, 631)
        Me.VendaNumero.MaxLength = 15
        Me.VendaNumero.Name = "VendaNumero"
        Me.VendaNumero.PreencherZeroEsqueda = False
        Me.VendaNumero.RegraValidação = Nothing
        Me.VendaNumero.RegraValidaçãoMensagem = Nothing
        Me.VendaNumero.Size = New System.Drawing.Size(356, 28)
        Me.VendaNumero.TabIndex = 5
        Me.VendaNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.VendaNumero.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.VendaNumero.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 632)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 27)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Informe a Venda...:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btAtulizar
        '
        Me.btAtulizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtulizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtulizar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtulizar.Location = New System.Drawing.Point(678, 626)
        Me.btAtulizar.Name = "btAtulizar"
        Me.btAtulizar.Size = New System.Drawing.Size(115, 33)
        Me.btAtulizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAtulizar.TabIndex = 3
        Me.btAtulizar.Text = "Atualizar &Lista"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(799, 626)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(115, 33)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 2
        Me.btFechar.Text = "&Fechar"
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Img, Me.cPedidoSequencia, Me.cCliente, Me.cDataPedido, Me.cStatusAndamentos, Me.cTotalPedido, Me.cTipoPedido})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle3
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(12, 12)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersVisible = False
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(902, 607)
        Me.Lista.TabIndex = 1
        '
        'Img
        '
        Me.Img.HeaderText = ""
        Me.Img.Image = CType(resources.GetObject("Img.Image"), System.Drawing.Image)
        Me.Img.Name = "Img"
        Me.Img.ReadOnly = True
        Me.Img.Width = 30
        '
        'cPedidoSequencia
        '
        Me.cPedidoSequencia.DataPropertyName = "PedidoSequencia"
        Me.cPedidoSequencia.FillWeight = 90.0!
        Me.cPedidoSequencia.HeaderText = "Venda"
        Me.cPedidoSequencia.Name = "cPedidoSequencia"
        Me.cPedidoSequencia.ReadOnly = True
        Me.cPedidoSequencia.Width = 80
        '
        'cCliente
        '
        Me.cCliente.DataPropertyName = "Cliente"
        Me.cCliente.HeaderText = "Cliente"
        Me.cCliente.Name = "cCliente"
        Me.cCliente.ReadOnly = True
        Me.cCliente.Width = 380
        '
        'cDataPedido
        '
        Me.cDataPedido.DataPropertyName = "DataPedido"
        Me.cDataPedido.HeaderText = "Data Pedido"
        Me.cDataPedido.Name = "cDataPedido"
        Me.cDataPedido.ReadOnly = True
        '
        'cStatusAndamentos
        '
        Me.cStatusAndamentos.DataPropertyName = "StatusAndamentos"
        Me.cStatusAndamentos.HeaderText = "Status"
        Me.cStatusAndamentos.Name = "cStatusAndamentos"
        Me.cStatusAndamentos.ReadOnly = True
        '
        'cTotalPedido
        '
        Me.cTotalPedido.DataPropertyName = "TotalPedido"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cTotalPedido.DefaultCellStyle = DataGridViewCellStyle2
        Me.cTotalPedido.HeaderText = "Total Venda"
        Me.cTotalPedido.Name = "cTotalPedido"
        Me.cTotalPedido.ReadOnly = True
        '
        'cTipoPedido
        '
        Me.cTipoPedido.DataPropertyName = "PedidoTipo"
        Me.cTipoPedido.HeaderText = "Tipo"
        Me.cTipoPedido.Name = "cTipoPedido"
        Me.cTipoPedido.ReadOnly = True
        Me.cTipoPedido.Width = 90
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'SellShoesPendentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 665)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "SellShoesPendentes"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellShoesPendentes - T254"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btAtulizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents VendaNumero As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cPedidoSequencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDataPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStatusAndamentos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipoPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btAtivarCaixa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
