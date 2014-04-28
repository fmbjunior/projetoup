<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarOrdem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarOrdem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.butFechar = New DevComponents.DotNetBar.ButtonX()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.gCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gNumeroPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gDataProducao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rdbData = New System.Windows.Forms.RadioButton()
        Me.rdbNumeroOrdem = New System.Windows.Forms.RadioButton()
        Me.rdbcliente = New System.Windows.Forms.RadioButton()
        Me.rdbPedido = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(544, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Data - F5"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "N. Ordem - F4"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(211, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Cliente - F2"
        '
        'butFechar
        '
        Me.butFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butFechar.Image = CType(resources.GetObject("butFechar.Image"), System.Drawing.Image)
        Me.butFechar.Location = New System.Drawing.Point(12, 408)
        Me.butFechar.Name = "butFechar"
        Me.butFechar.Size = New System.Drawing.Size(106, 33)
        Me.butFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butFechar.TabIndex = 9
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
        Me.txtProcura.Location = New System.Drawing.Point(12, 9)
        Me.txtProcura.MaxLength = 30
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.ShortcutsEnabled = False
        Me.txtProcura.Size = New System.Drawing.Size(168, 20)
        Me.txtProcura.TabIndex = 7
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
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gCodigo, Me.gNumeroPedido, Me.gCliente, Me.gDataProducao})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(12, 35)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(627, 367)
        Me.DgvItem.TabIndex = 8
        '
        'gCodigo
        '
        Me.gCodigo.DataPropertyName = "NumeroOrdem"
        DataGridViewCellStyle2.Format = "0000"
        Me.gCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.gCodigo.HeaderText = "Ordem"
        Me.gCodigo.Name = "gCodigo"
        Me.gCodigo.Width = 70
        '
        'gNumeroPedido
        '
        Me.gNumeroPedido.DataPropertyName = "NumeroPedido"
        Me.gNumeroPedido.HeaderText = "N. Pedido"
        Me.gNumeroPedido.Name = "gNumeroPedido"
        '
        'gCliente
        '
        Me.gCliente.DataPropertyName = "NomeCliente"
        Me.gCliente.HeaderText = "Cliente"
        Me.gCliente.Name = "gCliente"
        Me.gCliente.Width = 350
        '
        'gDataProducao
        '
        Me.gDataProducao.DataPropertyName = "DataProducao"
        Me.gDataProducao.HeaderText = "Data Produção"
        Me.gDataProducao.Name = "gDataProducao"
        '
        'rdbData
        '
        Me.rdbData.AutoSize = True
        Me.rdbData.Location = New System.Drawing.Point(524, 12)
        Me.rdbData.Name = "rdbData"
        Me.rdbData.Size = New System.Drawing.Size(14, 13)
        Me.rdbData.TabIndex = 14
        Me.rdbData.TabStop = True
        Me.rdbData.UseVisualStyleBackColor = True
        '
        'rdbNumeroOrdem
        '
        Me.rdbNumeroOrdem.AutoSize = True
        Me.rdbNumeroOrdem.Location = New System.Drawing.Point(399, 10)
        Me.rdbNumeroOrdem.Name = "rdbNumeroOrdem"
        Me.rdbNumeroOrdem.Size = New System.Drawing.Size(14, 13)
        Me.rdbNumeroOrdem.TabIndex = 15
        Me.rdbNumeroOrdem.TabStop = True
        Me.rdbNumeroOrdem.UseVisualStyleBackColor = True
        '
        'rdbcliente
        '
        Me.rdbcliente.AutoSize = True
        Me.rdbcliente.Checked = True
        Me.rdbcliente.Location = New System.Drawing.Point(190, 11)
        Me.rdbcliente.Name = "rdbcliente"
        Me.rdbcliente.Size = New System.Drawing.Size(14, 13)
        Me.rdbcliente.TabIndex = 17
        Me.rdbcliente.TabStop = True
        Me.rdbcliente.UseVisualStyleBackColor = True
        '
        'rdbPedido
        '
        Me.rdbPedido.AutoSize = True
        Me.rdbPedido.Location = New System.Drawing.Point(290, 10)
        Me.rdbPedido.Name = "rdbPedido"
        Me.rdbPedido.Size = New System.Drawing.Size(14, 13)
        Me.rdbPedido.TabIndex = 15
        Me.rdbPedido.TabStop = True
        Me.rdbPedido.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "N. Pedido - F3"
        '
        'frmBuscarOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.rdbData)
        Me.Controls.Add(Me.rdbPedido)
        Me.Controls.Add(Me.rdbNumeroOrdem)
        Me.Controls.Add(Me.rdbcliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.butFechar)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.DgvItem)
        Me.KeyPreview = True
        Me.Name = "frmBuscarOrdem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizando Ordem de Produção"
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents butFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents rdbData As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNumeroOrdem As System.Windows.Forms.RadioButton
    Friend WithEvents rdbcliente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPedido As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gNumeroPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gDataProducao As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
