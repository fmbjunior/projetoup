<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoPIS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoPIS))
        Me.DGFuncPis = New System.Windows.Forms.DataGridView
        Me.CódigoFuncionário = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorPIS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.AtualizarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.Cnn = New System.Data.OleDb.OleDbConnection
        Me.Da = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Cmd = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        CType(Me.DGFuncPis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGFuncPis
        '
        Me.DGFuncPis.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose
        Me.DGFuncPis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGFuncPis.BackgroundColor = System.Drawing.Color.Snow
        Me.DGFuncPis.ColumnHeadersHeight = 20
        Me.DGFuncPis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGFuncPis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoFuncionário, Me.Nome, Me.Pis, Me.ValorPIS})
        Me.DGFuncPis.GridColor = System.Drawing.Color.Black
        Me.DGFuncPis.Location = New System.Drawing.Point(6, 75)
        Me.DGFuncPis.Name = "DGFuncPis"
        Me.DGFuncPis.RowHeadersWidth = 20
        Me.DGFuncPis.Size = New System.Drawing.Size(561, 441)
        Me.DGFuncPis.TabIndex = 1
        '
        'CódigoFuncionário
        '
        Me.CódigoFuncionário.DataPropertyName = "CódigoFuncionário"
        Me.CódigoFuncionário.FillWeight = 95.0!
        Me.CódigoFuncionário.HeaderText = "Código"
        Me.CódigoFuncionário.Name = "CódigoFuncionário"
        Me.CódigoFuncionário.ReadOnly = True
        Me.CódigoFuncionário.Width = 70
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Nome do Funcionário"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        Me.Nome.Width = 250
        '
        'Pis
        '
        Me.Pis.DataPropertyName = "Pis"
        Me.Pis.HeaderText = "PIS"
        Me.Pis.Name = "Pis"
        Me.Pis.Width = 110
        '
        'ValorPIS
        '
        Me.ValorPIS.DataPropertyName = "ValorPis"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ValorPIS.DefaultCellStyle = DataGridViewCellStyle2
        Me.ValorPIS.HeaderText = "Valor do PIS"
        Me.ValorPIS.Name = "ValorPIS"
        Me.ValorPIS.Width = 90
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
        Me.BarraBt.Size = New System.Drawing.Size(573, 68)
        Me.BarraBt.TabIndex = 76
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
        Me.Da.SelectCommand = Me.Cmd
        Me.Da.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Funcionários", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CódigoFuncionário", "CódigoFuncionário"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Pis", "Pis"), New System.Data.Common.DataColumnMapping("ValorPis", "ValorPis")})})
        Me.Da.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.Cnn
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_CódigoFuncionário", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CódigoFuncionário", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Nome", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Nome", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Pis", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Pis", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Pis", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pis", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ValorPis", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ValorPis", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ValorPis", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorPis", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Cmd
        '
        Me.Cmd.CommandText = "SELECT        CódigoFuncionário, Nome, Pis, ValorPis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Funcionário" & _
            "s"
        Me.Cmd.Connection = Me.Cnn
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.Cnn
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Nome", System.Data.OleDb.OleDbType.VarWChar, 0, "Nome"), New System.Data.OleDb.OleDbParameter("Pis", System.Data.OleDb.OleDbType.VarWChar, 0, "Pis"), New System.Data.OleDb.OleDbParameter("ValorPis", System.Data.OleDb.OleDbType.Currency, 0, "ValorPis"), New System.Data.OleDb.OleDbParameter("Original_CódigoFuncionário", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CódigoFuncionário", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Nome", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Nome", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Pis", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Pis", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Pis", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pis", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ValorPis", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ValorPis", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ValorPis", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorPis", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.DGFuncPis)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(573, 522)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 77
        '
        'FolhaPgtoPIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoPIS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionários Ativos e PIS"
        CType(Me.DGFuncPis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGFuncPis As System.Windows.Forms.DataGridView
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents AtualizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cnn As System.Data.OleDb.OleDbConnection
    Friend WithEvents Da As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Cmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CódigoFuncionário As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorPIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
