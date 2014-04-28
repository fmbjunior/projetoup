<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSenhaAllItens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSenhaAllItens))
        Me.DGPermissões = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoTela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exclui = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Adiciona = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Altera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Consultar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Inativo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UsarSenha = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Da = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand = New System.Data.OleDb.OleDbCommand()
        Me.Cnn = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand = New System.Data.OleDb.OleDbCommand()
        Me.Cmd = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DGPermissões, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGPermissões
        '
        Me.DGPermissões.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumOrchid
        Me.DGPermissões.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGPermissões.BackgroundColor = System.Drawing.Color.Snow
        Me.DGPermissões.ColumnHeadersHeight = 20
        Me.DGPermissões.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGPermissões.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Login, Me.Tela, Me.Senha, Me.DescricaoTela, Me.Exclui, Me.Adiciona, Me.Altera, Me.Consultar, Me.Inativo, Me.UsarSenha})
        Me.DGPermissões.GridColor = System.Drawing.Color.Black
        Me.DGPermissões.Location = New System.Drawing.Point(3, 3)
        Me.DGPermissões.Name = "DGPermissões"
        Me.DGPermissões.RowHeadersWidth = 20
        Me.DGPermissões.Size = New System.Drawing.Size(579, 534)
        Me.DGPermissões.TabIndex = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Login
        '
        Me.Login.DataPropertyName = "Login"
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.Visible = False
        '
        'Tela
        '
        Me.Tela.DataPropertyName = "Tela"
        Me.Tela.HeaderText = "Tela"
        Me.Tela.Name = "Tela"
        Me.Tela.Visible = False
        '
        'Senha
        '
        Me.Senha.DataPropertyName = "Senha"
        Me.Senha.HeaderText = "Senha"
        Me.Senha.Name = "Senha"
        Me.Senha.Visible = False
        '
        'DescricaoTela
        '
        Me.DescricaoTela.DataPropertyName = "DescricaoTela"
        Me.DescricaoTela.HeaderText = "Descrição da Tela"
        Me.DescricaoTela.Name = "DescricaoTela"
        Me.DescricaoTela.Width = 290
        '
        'Exclui
        '
        Me.Exclui.DataPropertyName = "Exclui"
        Me.Exclui.HeaderText = "EXC"
        Me.Exclui.Name = "Exclui"
        Me.Exclui.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Exclui.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Exclui.Width = 35
        '
        'Adiciona
        '
        Me.Adiciona.DataPropertyName = "Adiciona"
        Me.Adiciona.HeaderText = "ADI"
        Me.Adiciona.Name = "Adiciona"
        Me.Adiciona.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Adiciona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Adiciona.Width = 35
        '
        'Altera
        '
        Me.Altera.DataPropertyName = "Altera"
        Me.Altera.HeaderText = "ALT"
        Me.Altera.Name = "Altera"
        Me.Altera.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Altera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Altera.Width = 35
        '
        'Consultar
        '
        Me.Consultar.DataPropertyName = "Consultar"
        Me.Consultar.HeaderText = "CON"
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Consultar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Consultar.Width = 35
        '
        'Inativo
        '
        Me.Inativo.DataPropertyName = "Inativo"
        Me.Inativo.HeaderText = "INA"
        Me.Inativo.Name = "Inativo"
        Me.Inativo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Inativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Inativo.Width = 35
        '
        'UsarSenha
        '
        Me.UsarSenha.DataPropertyName = "UsarSenha"
        Me.UsarSenha.HeaderText = "UsarSenha"
        Me.UsarSenha.Name = "UsarSenha"
        Me.UsarSenha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsarSenha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UsarSenha.Width = 70
        '
        'Da
        '
        Me.Da.DeleteCommand = Me.OleDbDeleteCommand
        Me.Da.InsertCommand = Me.OleDbInsertCommand
        Me.Da.SelectCommand = Me.Cmd
        Me.Da.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LoginUserPermissao", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Login", "Login"), New System.Data.Common.DataColumnMapping("Tela", "Tela"), New System.Data.Common.DataColumnMapping("Senha", "Senha"), New System.Data.Common.DataColumnMapping("DescricaoTela", "DescricaoTela"), New System.Data.Common.DataColumnMapping("Exclui", "Exclui"), New System.Data.Common.DataColumnMapping("Adiciona", "Adiciona"), New System.Data.Common.DataColumnMapping("Altera", "Altera"), New System.Data.Common.DataColumnMapping("Consultar", "Consultar"), New System.Data.Common.DataColumnMapping("UsarSenha", "UsarSenha"), New System.Data.Common.DataColumnMapping("Inativo", "Inativo")})})
        Me.Da.UpdateCommand = Me.OleDbCommand1
        '
        'OleDbDeleteCommand
        '
        Me.OleDbDeleteCommand.CommandText = resources.GetString("OleDbDeleteCommand.CommandText")
        Me.OleDbDeleteCommand.Connection = Me.Cnn
        Me.OleDbDeleteCommand.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("IsNull_Id", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Id", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Login", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Login", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Tela", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tela", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Senha", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Senha", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Senha", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Senha", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DescricaoTela", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DescricaoTela", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DescricaoTela", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescricaoTela", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Exclui", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Exclui", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Exclui", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exclui", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Adiciona", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Adiciona", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Adiciona", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adiciona", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Altera", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Altera", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Altera", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Altera", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Consultar", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Consultar", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Consultar", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consultar", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_UsarSenha", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UsarSenha", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_UsarSenha", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UsarSenha", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Inativo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Inativo", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Inativo", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Inativo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\upDados.mdb"
        '
        'OleDbInsertCommand
        '
        Me.OleDbInsertCommand.CommandText = "INSERT INTO `LoginUserPermissao` (`Login`, `Tela`, `Senha`, `DescricaoTela`, `Exc" & _
            "lui`, `Adiciona`, `Altera`, `Consultar`, `UsarSenha`, `Inativo`) VALUES (?, ?, ?" & _
            ", ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand.Connection = Me.Cnn
        Me.OleDbInsertCommand.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Login", System.Data.OleDb.OleDbType.VarWChar, 0, "Login"), New System.Data.OleDb.OleDbParameter("Tela", System.Data.OleDb.OleDbType.VarWChar, 0, "Tela"), New System.Data.OleDb.OleDbParameter("Senha", System.Data.OleDb.OleDbType.VarWChar, 0, "Senha"), New System.Data.OleDb.OleDbParameter("DescricaoTela", System.Data.OleDb.OleDbType.VarWChar, 0, "DescricaoTela"), New System.Data.OleDb.OleDbParameter("Exclui", System.Data.OleDb.OleDbType.[Boolean], 0, "Exclui"), New System.Data.OleDb.OleDbParameter("Adiciona", System.Data.OleDb.OleDbType.[Boolean], 0, "Adiciona"), New System.Data.OleDb.OleDbParameter("Altera", System.Data.OleDb.OleDbType.[Boolean], 0, "Altera"), New System.Data.OleDb.OleDbParameter("Consultar", System.Data.OleDb.OleDbType.[Boolean], 0, "Consultar"), New System.Data.OleDb.OleDbParameter("UsarSenha", System.Data.OleDb.OleDbType.[Boolean], 0, "UsarSenha"), New System.Data.OleDb.OleDbParameter("Inativo", System.Data.OleDb.OleDbType.[Boolean], 0, "Inativo")})
        '
        'Cmd
        '
        Me.Cmd.CommandText = "SELECT        LoginUserPermissao.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            LoginUserPermissao"
        Me.Cmd.Connection = Me.Cnn
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = resources.GetString("OleDbCommand1.CommandText")
        Me.OleDbCommand1.Connection = Me.Cnn
        Me.OleDbCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Login", System.Data.OleDb.OleDbType.VarWChar, 0, "Login"), New System.Data.OleDb.OleDbParameter("Tela", System.Data.OleDb.OleDbType.VarWChar, 0, "Tela"), New System.Data.OleDb.OleDbParameter("Senha", System.Data.OleDb.OleDbType.VarWChar, 0, "Senha"), New System.Data.OleDb.OleDbParameter("DescricaoTela", System.Data.OleDb.OleDbType.VarWChar, 0, "DescricaoTela"), New System.Data.OleDb.OleDbParameter("Exclui", System.Data.OleDb.OleDbType.[Boolean], 0, "Exclui"), New System.Data.OleDb.OleDbParameter("Adiciona", System.Data.OleDb.OleDbType.[Boolean], 0, "Adiciona"), New System.Data.OleDb.OleDbParameter("Altera", System.Data.OleDb.OleDbType.[Boolean], 0, "Altera"), New System.Data.OleDb.OleDbParameter("Consultar", System.Data.OleDb.OleDbType.[Boolean], 0, "Consultar"), New System.Data.OleDb.OleDbParameter("UsarSenha", System.Data.OleDb.OleDbType.[Boolean], 0, "UsarSenha"), New System.Data.OleDb.OleDbParameter("Inativo", System.Data.OleDb.OleDbType.[Boolean], 0, "Inativo"), New System.Data.OleDb.OleDbParameter("IsNull_Id", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Id", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Login", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Login", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Tela", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tela", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Senha", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Senha", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Senha", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Senha", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DescricaoTela", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DescricaoTela", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DescricaoTela", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescricaoTela", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Exclui", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Exclui", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Exclui", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exclui", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Adiciona", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Adiciona", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Adiciona", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adiciona", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Altera", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Altera", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Altera", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Altera", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Consultar", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Consultar", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Consultar", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consultar", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_UsarSenha", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UsarSenha", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_UsarSenha", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UsarSenha", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Inativo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Inativo", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Inativo", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Inativo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btAtualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.DGPermissões)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(592, 576)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 19
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Location = New System.Drawing.Point(418, 543)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(78, 27)
        Me.btAtualizar.TabIndex = 20
        Me.btAtualizar.Text = "Atualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(502, 543)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(78, 27)
        Me.btFechar.TabIndex = 19
        Me.btFechar.Text = "Fechar"
        '
        'UserSenhaAllItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(592, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UserSenhaAllItens"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permissões do usuário - T215"
        CType(Me.DGPermissões, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fundo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGPermissões As System.Windows.Forms.DataGridView
    Friend WithEvents Da As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents Cnn As System.Data.OleDb.OleDbConnection
    Friend WithEvents Cmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand As System.Data.OleDb.OleDbCommand
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Senha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescricaoTela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exclui As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Adiciona As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Altera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Consultar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Inativo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents UsarSenha As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
