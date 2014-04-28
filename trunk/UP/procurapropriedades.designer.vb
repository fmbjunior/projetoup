<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcuraPropriedades
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
        Me.Fechar = New System.Windows.Forms.Button()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.gCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gUF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gInscricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fechar
        '
        Me.Fechar.Location = New System.Drawing.Point(1, 312)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(472, 35)
        Me.Fechar.TabIndex = 1
        Me.Fechar.Text = "Fechar"
        Me.Fechar.UseVisualStyleBackColor = True
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
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gCodigo, Me.gDescricao, Me.gUF, Me.gInscricao})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(2, 1)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(471, 311)
        Me.DgvItem.TabIndex = 0
        '
        'gCodigo
        '
        Me.gCodigo.DataPropertyName = "id"
        DataGridViewCellStyle2.Format = "0000"
        Me.gCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.gCodigo.HeaderText = "Código"
        Me.gCodigo.Name = "gCodigo"
        Me.gCodigo.Width = 50
        '
        'gDescricao
        '
        Me.gDescricao.DataPropertyName = "NomePropriedade"
        Me.gDescricao.HeaderText = "Nome da Propriedade"
        Me.gDescricao.Name = "gDescricao"
        Me.gDescricao.Width = 280
        '
        'gUF
        '
        Me.gUF.DataPropertyName = "Estado"
        Me.gUF.HeaderText = "UF"
        Me.gUF.Name = "gUF"
        Me.gUF.Width = 30
        '
        'gInscricao
        '
        Me.gInscricao.DataPropertyName = "Inscricao"
        Me.gInscricao.HeaderText = "I.E"
        Me.gInscricao.Name = "gInscricao"
        Me.gInscricao.Width = 90
        '
        'ProcuraPropriedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(477, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgvItem)
        Me.Controls.Add(Me.Fechar)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProcuraPropriedades"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procura de Propriedades - T194"
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents gCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gDescricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gUF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gInscricao As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
