<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalarioMinimoTabela
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalarioMinimoTabela))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.AtualizarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.Cnn = New System.Data.OleDb.OleDbConnection
        Me.Da = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand = New System.Data.OleDb.OleDbCommand
        Me.Cmd = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DGSalMinimo = New System.Windows.Forms.DataGridView
        Me.Periodo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Periodo2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalarioMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.BarraBt.SuspendLayout()
        CType(Me.DGSalMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtualizarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(372, 68)
        Me.BarraBt.TabIndex = 77
        Me.BarraBt.Text = "ToolStrip1"
        '
        'AtualizarBT
        '
        Me.AtualizarBT.Image = CType(resources.GetObject("AtualizarBT.Image"), System.Drawing.Image)
        Me.AtualizarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AtualizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtualizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtualizarBT.Name = "AtualizarBT"
        Me.AtualizarBT.Size = New System.Drawing.Size(82, 65)
        Me.AtualizarBT.Text = "Atualizar Lista"
        Me.AtualizarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtualizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(76, 65)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        '
        'Da
        '
        Me.Da.DeleteCommand = Me.OleDbDeleteCommand1
        Me.Da.InsertCommand = Me.OleDbInsertCommand
        Me.Da.SelectCommand = Me.Cmd
        Me.Da.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SalarioMinimoTabela", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Periodo1", "Periodo1"), New System.Data.Common.DataColumnMapping("Periodo2", "Periodo2"), New System.Data.Common.DataColumnMapping("SalarioMinimo", "SalarioMinimo")})})
        Me.Da.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM `SalarioMinimoTabela` WHERE ((`Periodo1` = ?) AND (`Periodo2` = ?) AN" & _
            "D ((? = 1 AND `SalarioMinimo` IS NULL) OR (`SalarioMinimo` = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.Cnn
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Periodo1", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Periodo2", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SalarioMinimo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SalarioMinimo", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SalarioMinimo", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioMinimo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand
        '
        Me.OleDbInsertCommand.CommandText = "INSERT INTO `SalarioMinimoTabela` (`Periodo1`, `Periodo2`, `SalarioMinimo`) VALUE" & _
            "S (?, ?, ?)"
        Me.OleDbInsertCommand.Connection = Me.Cnn
        Me.OleDbInsertCommand.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Periodo1", System.Data.OleDb.OleDbType.[Date], 0, "Periodo1"), New System.Data.OleDb.OleDbParameter("Periodo2", System.Data.OleDb.OleDbType.[Date], 0, "Periodo2"), New System.Data.OleDb.OleDbParameter("SalarioMinimo", System.Data.OleDb.OleDbType.Currency, 0, "SalarioMinimo")})
        '
        'Cmd
        '
        Me.Cmd.CommandText = "SELECT        Periodo1, Periodo2, SalarioMinimo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            SalarioMinimoTab" & _
            "ela"
        Me.Cmd.Connection = Me.Cnn
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE `SalarioMinimoTabela` SET `Periodo1` = ?, `Periodo2` = ?, `SalarioMinimo` " & _
            "= ? WHERE ((`Periodo1` = ?) AND (`Periodo2` = ?) AND ((? = 1 AND `SalarioMinimo`" & _
            " IS NULL) OR (`SalarioMinimo` = ?)))"
        Me.OleDbUpdateCommand1.Connection = Me.Cnn
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Periodo1", System.Data.OleDb.OleDbType.[Date], 0, "Periodo1"), New System.Data.OleDb.OleDbParameter("Periodo2", System.Data.OleDb.OleDbType.[Date], 0, "Periodo2"), New System.Data.OleDb.OleDbParameter("SalarioMinimo", System.Data.OleDb.OleDbType.Currency, 0, "SalarioMinimo"), New System.Data.OleDb.OleDbParameter("Original_Periodo1", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Periodo2", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SalarioMinimo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SalarioMinimo", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SalarioMinimo", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioMinimo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DGSalMinimo
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose
        Me.DGSalMinimo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGSalMinimo.BackgroundColor = System.Drawing.Color.Snow
        Me.DGSalMinimo.ColumnHeadersHeight = 20
        Me.DGSalMinimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGSalMinimo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Periodo1, Me.Periodo2, Me.SalarioMinimo})
        Me.DGSalMinimo.GridColor = System.Drawing.Color.Black
        Me.DGSalMinimo.Location = New System.Drawing.Point(12, 80)
        Me.DGSalMinimo.MultiSelect = False
        Me.DGSalMinimo.Name = "DGSalMinimo"
        Me.DGSalMinimo.RowHeadersWidth = 20
        Me.DGSalMinimo.Size = New System.Drawing.Size(347, 399)
        Me.DGSalMinimo.TabIndex = 2
        '
        'Periodo1
        '
        Me.Periodo1.DataPropertyName = "Periodo1"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Periodo1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Periodo1.FillWeight = 95.0!
        Me.Periodo1.HeaderText = "Data Inicial"
        Me.Periodo1.MaxInputLength = 10
        Me.Periodo1.Name = "Periodo1"
        Me.Periodo1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Periodo1.Width = 90
        '
        'Periodo2
        '
        Me.Periodo2.DataPropertyName = "Periodo2"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Periodo2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Periodo2.HeaderText = "Data Final"
        Me.Periodo2.MaxInputLength = 10
        Me.Periodo2.Name = "Periodo2"
        Me.Periodo2.Width = 90
        '
        'SalarioMinimo
        '
        Me.SalarioMinimo.DataPropertyName = "SalarioMinimo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SalarioMinimo.DefaultCellStyle = DataGridViewCellStyle4
        Me.SalarioMinimo.HeaderText = "Valor do Sal. Mínimo"
        Me.SalarioMinimo.MaxInputLength = 10
        Me.SalarioMinimo.Name = "SalarioMinimo"
        Me.SalarioMinimo.Width = 120
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.DGSalMinimo)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(372, 491)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 78
        '
        'SalarioMinimoTabela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SalarioMinimoTabela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabela de Salário Mínimo"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        CType(Me.DGSalMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGSalMinimo As System.Windows.Forms.DataGridView
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents AtualizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cnn As System.Data.OleDb.OleDbConnection
    Friend WithEvents Da As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Cmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand As System.Data.OleDb.OleDbCommand
    Friend WithEvents Periodo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Periodo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalarioMinimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
