<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPBusca
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPBusca))
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gEstoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gReserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.optDesc = New System.Windows.Forms.RadioButton()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.butFechar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descricao, Me.gEstoque, Me.gReserva})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(12, 38)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(658, 412)
        Me.DgvItem.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "CodigoProduto"
        DataGridViewCellStyle2.Format = "0000"
        Me.Codigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 70
        '
        'Descricao
        '
        Me.Descricao.DataPropertyName = "Descrição"
        Me.Descricao.HeaderText = "Descrição"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Width = 380
        '
        'gEstoque
        '
        Me.gEstoque.DataPropertyName = "QuantidadeEstoque"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n4"
        Me.gEstoque.DefaultCellStyle = DataGridViewCellStyle3
        Me.gEstoque.HeaderText = "Estoque"
        Me.gEstoque.Name = "gEstoque"
        '
        'gReserva
        '
        Me.gReserva.DataPropertyName = "Reserva"
        Me.gReserva.HeaderText = "Reserva"
        Me.gReserva.Name = "gReserva"
        '
        'optCodigo
        '
        Me.optCodigo.AutoSize = True
        Me.optCodigo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optCodigo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCodigo.Location = New System.Drawing.Point(394, 12)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(99, 20)
        Me.optCodigo.TabIndex = 3
        Me.optCodigo.Text = "Código [F3]"
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'optDesc
        '
        Me.optDesc.AutoSize = True
        Me.optDesc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optDesc.Checked = True
        Me.optDesc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDesc.Location = New System.Drawing.Point(263, 12)
        Me.optDesc.Name = "optDesc"
        Me.optDesc.Size = New System.Drawing.Size(119, 20)
        Me.optDesc.TabIndex = 2
        Me.optDesc.TabStop = True
        Me.optDesc.Text = "Descrição [F2]"
        Me.optDesc.UseVisualStyleBackColor = True
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
        Me.txtProcura.Location = New System.Drawing.Point(12, 12)
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
        'butFechar
        '
        Me.butFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butFechar.Image = CType(resources.GetObject("butFechar.Image"), System.Drawing.Image)
        Me.butFechar.Location = New System.Drawing.Point(12, 456)
        Me.butFechar.Name = "butFechar"
        Me.butFechar.Size = New System.Drawing.Size(109, 33)
        Me.butFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butFechar.TabIndex = 4
        Me.butFechar.Text = "Fechar"
        '
        'frmMPBusca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.butFechar)
        Me.Controls.Add(Me.optCodigo)
        Me.Controls.Add(Me.optDesc)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.DgvItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmMPBusca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca de Matéria Prima"
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents optDesc As System.Windows.Forms.RadioButton
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents butFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gEstoque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gReserva As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
