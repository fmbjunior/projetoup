<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoMPBusca
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoMPBusca))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.butFechar = New DevComponents.DotNetBar.ButtonX()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.gCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gModelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gDataPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gValorVenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rdbcliente = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbvendedor = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbcodigovenda = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdbData = New System.Windows.Forms.RadioButton()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butFechar
        '
        Me.butFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butFechar.Image = CType(resources.GetObject("butFechar.Image"), System.Drawing.Image)
        Me.butFechar.Location = New System.Drawing.Point(3, 436)
        Me.butFechar.Name = "butFechar"
        Me.butFechar.Size = New System.Drawing.Size(102, 33)
        Me.butFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butFechar.TabIndex = 5
        Me.butFechar.Text = "Fechar"
        '
        'txtProcura
        '
        Me.txtProcura.AceitaColarTexto = True
        Me.txtProcura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtProcura.CasasDecimais = 0
        Me.txtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcura.CPObrigatorio = False
        Me.txtProcura.CPObrigatorioMsg = Nothing
        Me.txtProcura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtProcura.FlatBorder = False
        Me.txtProcura.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtProcura.FocusColor = System.Drawing.Color.MistyRose
        Me.txtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtProcura.HighlightBorderOnEnter = False
        Me.txtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtProcura.Location = New System.Drawing.Point(3, 19)
        Me.txtProcura.MaxLength = 30
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.ShortcutsEnabled = False
        Me.txtProcura.Size = New System.Drawing.Size(232, 20)
        Me.txtProcura.TabIndex = 0
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.AllowUserToResizeColumns = False
        Me.DgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItem.BackgroundColor = System.Drawing.Color.White
        Me.DgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gCodigo, Me.gModelo, Me.gDataPedido, Me.gVendedor, Me.gCliente, Me.gValorVenda, Me.gStatus})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(3, 45)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(895, 385)
        Me.DgvItem.TabIndex = 1
        '
        'gCodigo
        '
        Me.gCodigo.DataPropertyName = "NumeroPedido"
        DataGridViewCellStyle2.Format = "0000"
        Me.gCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.gCodigo.HeaderText = "Código"
        Me.gCodigo.Name = "gCodigo"
        Me.gCodigo.Width = 70
        '
        'gModelo
        '
        Me.gModelo.DataPropertyName = "Modelo"
        Me.gModelo.HeaderText = "Modelo"
        Me.gModelo.Name = "gModelo"
        Me.gModelo.Width = 50
        '
        'gDataPedido
        '
        Me.gDataPedido.DataPropertyName = "DataPedido"
        Me.gDataPedido.HeaderText = "Data Pedido"
        Me.gDataPedido.Name = "gDataPedido"
        Me.gDataPedido.Width = 70
        '
        'gVendedor
        '
        Me.gVendedor.DataPropertyName = "Vendedor"
        Me.gVendedor.HeaderText = "Vendedor"
        Me.gVendedor.Name = "gVendedor"
        '
        'gCliente
        '
        Me.gCliente.DataPropertyName = "Cliente"
        Me.gCliente.HeaderText = "Cliente"
        Me.gCliente.Name = "gCliente"
        Me.gCliente.Width = 350
        '
        'gValorVenda
        '
        Me.gValorVenda.DataPropertyName = "TotalLiquido"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "c2"
        Me.gValorVenda.DefaultCellStyle = DataGridViewCellStyle3
        Me.gValorVenda.HeaderText = "Total Venda"
        Me.gValorVenda.Name = "gValorVenda"
        '
        'gStatus
        '
        Me.gStatus.DataPropertyName = "Status"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.NullValue = Nothing
        Me.gStatus.DefaultCellStyle = DataGridViewCellStyle4
        Me.gStatus.HeaderText = "Status"
        Me.gStatus.Name = "gStatus"
        Me.gStatus.Width = 90
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(259, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Cliente - F2"
        '
        'rdbcliente
        '
        Me.rdbcliente.AutoSize = True
        Me.rdbcliente.Checked = True
        Me.rdbcliente.Location = New System.Drawing.Point(242, 22)
        Me.rdbcliente.Name = "rdbcliente"
        Me.rdbcliente.Size = New System.Drawing.Size(14, 13)
        Me.rdbcliente.TabIndex = 7
        Me.rdbcliente.TabStop = True
        Me.rdbcliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Vendedor - F3"
        '
        'rdbvendedor
        '
        Me.rdbvendedor.AutoSize = True
        Me.rdbvendedor.Location = New System.Drawing.Point(347, 22)
        Me.rdbvendedor.Name = "rdbvendedor"
        Me.rdbvendedor.Size = New System.Drawing.Size(14, 13)
        Me.rdbvendedor.TabIndex = 7
        Me.rdbvendedor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(505, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código Venda - F4"
        '
        'rdbcodigovenda
        '
        Me.rdbcodigovenda.AutoSize = True
        Me.rdbcodigovenda.Location = New System.Drawing.Point(485, 23)
        Me.rdbcodigovenda.Name = "rdbcodigovenda"
        Me.rdbcodigovenda.Size = New System.Drawing.Size(14, 13)
        Me.rdbcodigovenda.TabIndex = 7
        Me.rdbcodigovenda.TabStop = True
        Me.rdbcodigovenda.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(658, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data - F5"
        '
        'rdbData
        '
        Me.rdbData.AutoSize = True
        Me.rdbData.Location = New System.Drawing.Point(638, 23)
        Me.rdbData.Name = "rdbData"
        Me.rdbData.Size = New System.Drawing.Size(14, 13)
        Me.rdbData.TabIndex = 7
        Me.rdbData.TabStop = True
        Me.rdbData.UseVisualStyleBackColor = True
        '
        'PedidoMPBusca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.rdbData)
        Me.Controls.Add(Me.rdbcodigovenda)
        Me.Controls.Add(Me.rdbvendedor)
        Me.Controls.Add(Me.rdbcliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.butFechar)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.DgvItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "PedidoMPBusca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido Busca"
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdbcliente As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbvendedor As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdbcodigovenda As System.Windows.Forms.RadioButton
    Friend WithEvents gCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gModelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gDataPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gVendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gValorVenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdbData As System.Windows.Forms.RadioButton
End Class
