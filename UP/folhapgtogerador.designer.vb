<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoGerador
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoGerador))
        Me.FuncionarioDesc = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Funcionario = New TexBoxFocusNet.TextBoxFocusNet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Todos = New System.Windows.Forms.RadioButton
        Me.Individual = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Modulo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.MensalCompetencia = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fechar = New System.Windows.Forms.Button
        Me.TipoGeradorBT = New System.Windows.Forms.Label
        Me.MenuTipoGerador = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MensalDiaristaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FériasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DécimoTerceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PgtoPISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecisãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ValeQuinzenalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Display = New System.Windows.Forms.PictureBox
        Me.SemFoto = New System.Windows.Forms.PictureBox
        Me.PainelFuncionario = New System.Windows.Forms.Panel
        Me.Gerar = New System.Windows.Forms.Button
        Me.MyBarra = New System.Windows.Forms.ProgressBar
        Me.Msg = New System.Windows.Forms.Label
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox1.SuspendLayout()
        Me.MenuTipoGerador.SuspendLayout()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PainelFuncionario.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'FuncionarioDesc
        '
        Me.FuncionarioDesc.BackColor = System.Drawing.Color.Transparent
        Me.FuncionarioDesc.ForeColor = System.Drawing.Color.Black
        Me.FuncionarioDesc.Location = New System.Drawing.Point(174, 124)
        Me.FuncionarioDesc.Name = "FuncionarioDesc"
        Me.FuncionarioDesc.Size = New System.Drawing.Size(308, 20)
        Me.FuncionarioDesc.TabIndex = 9
        Me.FuncionarioDesc.Text = "Funcionário"
        Me.FuncionarioDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Funcionário"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Funcionario
        '
        Me.Funcionario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Funcionario.CasasDecimais = 0
        Me.Funcionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Funcionario.CPObrigatorio = False
        Me.Funcionario.CPObrigatorioMsg = Nothing
        Me.Funcionario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Funcionario.FocusColor = System.Drawing.Color.Empty
        Me.Funcionario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Funcionario.Location = New System.Drawing.Point(85, 2)
        Me.Funcionario.MaxLength = 16
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.RegraValidação = Nothing
        Me.Funcionario.RegraValidaçãoMensagem = Nothing
        Me.Funcionario.Size = New System.Drawing.Size(75, 20)
        Me.Funcionario.TabIndex = 7
        Me.Funcionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Funcionario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Funcionario.ValorPadrao = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Todos)
        Me.GroupBox1.Controls.Add(Me.Individual)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 49)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleção de Funcionários"
        '
        'Todos
        '
        Me.Todos.AutoSize = True
        Me.Todos.Location = New System.Drawing.Point(86, 19)
        Me.Todos.Name = "Todos"
        Me.Todos.Size = New System.Drawing.Size(55, 20)
        Me.Todos.TabIndex = 1
        Me.Todos.TabStop = True
        Me.Todos.Text = "Todos"
        Me.Todos.UseVisualStyleBackColor = True
        '
        'Individual
        '
        Me.Individual.AutoSize = True
        Me.Individual.Location = New System.Drawing.Point(6, 19)
        Me.Individual.Name = "Individual"
        Me.Individual.Size = New System.Drawing.Size(74, 20)
        Me.Individual.TabIndex = 0
        Me.Individual.TabStop = True
        Me.Individual.Text = "Individual"
        Me.Individual.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Modulo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Modulo
        '
        Me.Modulo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Modulo.CasasDecimais = 0
        Me.Modulo.CPObrigatorio = False
        Me.Modulo.CPObrigatorioMsg = Nothing
        Me.Modulo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Modulo.FocusColor = System.Drawing.Color.Empty
        Me.Modulo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Modulo.Location = New System.Drawing.Point(141, 38)
        Me.Modulo.MaxLength = 16
        Me.Modulo.Name = "Modulo"
        Me.Modulo.RegraValidação = Nothing
        Me.Modulo.RegraValidaçãoMensagem = Nothing
        Me.Modulo.Size = New System.Drawing.Size(97, 20)
        Me.Modulo.TabIndex = 5
        Me.Modulo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Modulo.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Competência"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MensalCompetencia
        '
        Me.MensalCompetencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.MensalCompetencia.CasasDecimais = 0
        Me.MensalCompetencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MensalCompetencia.CPObrigatorio = False
        Me.MensalCompetencia.CPObrigatorioMsg = Nothing
        Me.MensalCompetencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.MensalCompetencia.FocusColor = System.Drawing.Color.Empty
        Me.MensalCompetencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.MensalCompetencia.Location = New System.Drawing.Point(141, 12)
        Me.MensalCompetencia.MaxLength = 7
        Me.MensalCompetencia.Name = "MensalCompetencia"
        Me.MensalCompetencia.RegraValidação = Nothing
        Me.MensalCompetencia.RegraValidaçãoMensagem = Nothing
        Me.MensalCompetencia.Size = New System.Drawing.Size(97, 20)
        Me.MensalCompetencia.TabIndex = 3
        Me.MensalCompetencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MensalCompetencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.MensalCompetencia.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.Location = New System.Drawing.Point(400, 222)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(82, 29)
        Me.Fechar.TabIndex = 2
        Me.Fechar.Text = "Fechar"
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'TipoGeradorBT
        '
        Me.TipoGeradorBT.BackColor = System.Drawing.Color.Transparent
        Me.TipoGeradorBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TipoGeradorBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoGeradorBT.Location = New System.Drawing.Point(244, 38)
        Me.TipoGeradorBT.Name = "TipoGeradorBT"
        Me.TipoGeradorBT.Size = New System.Drawing.Size(27, 20)
        Me.TipoGeradorBT.TabIndex = 6
        Me.TipoGeradorBT.Text = "..."
        Me.TipoGeradorBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuTipoGerador
        '
        Me.MenuTipoGerador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MensalDiaristaToolStripMenuItem, Me.FériasToolStripMenuItem, Me.DécimoTerceiroToolStripMenuItem, Me.PISToolStripMenuItem, Me.PgtoPISToolStripMenuItem, Me.RecisãoToolStripMenuItem, Me.ValeQuinzenalToolStripMenuItem})
        Me.MenuTipoGerador.Name = "MenuTipoGerador"
        Me.MenuTipoGerador.Size = New System.Drawing.Size(153, 158)
        '
        'MensalDiaristaToolStripMenuItem
        '
        Me.MensalDiaristaToolStripMenuItem.Name = "MensalDiaristaToolStripMenuItem"
        Me.MensalDiaristaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MensalDiaristaToolStripMenuItem.Text = "1 Par Dec. Terç"
        '
        'FériasToolStripMenuItem
        '
        Me.FériasToolStripMenuItem.Name = "FériasToolStripMenuItem"
        Me.FériasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FériasToolStripMenuItem.Text = "2 Par Dec. Terç"
        '
        'DécimoTerceiroToolStripMenuItem
        '
        Me.DécimoTerceiroToolStripMenuItem.Name = "DécimoTerceiroToolStripMenuItem"
        Me.DécimoTerceiroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DécimoTerceiroToolStripMenuItem.Text = "Férias"
        '
        'PISToolStripMenuItem
        '
        Me.PISToolStripMenuItem.Name = "PISToolStripMenuItem"
        Me.PISToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PISToolStripMenuItem.Text = "Mensalistas"
        '
        'PgtoPISToolStripMenuItem
        '
        Me.PgtoPISToolStripMenuItem.Name = "PgtoPISToolStripMenuItem"
        Me.PgtoPISToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PgtoPISToolStripMenuItem.Text = "Pgto PIS"
        '
        'RecisãoToolStripMenuItem
        '
        Me.RecisãoToolStripMenuItem.Name = "RecisãoToolStripMenuItem"
        Me.RecisãoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RecisãoToolStripMenuItem.Text = "Recisão"
        '
        'ValeQuinzenalToolStripMenuItem
        '
        Me.ValeQuinzenalToolStripMenuItem.Name = "ValeQuinzenalToolStripMenuItem"
        Me.ValeQuinzenalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ValeQuinzenalToolStripMenuItem.Text = "Vale Quinzenal"
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.Color.Transparent
        Me.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Display.Location = New System.Drawing.Point(379, 3)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(103, 126)
        Me.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Display.TabIndex = 167
        Me.Display.TabStop = False
        '
        'SemFoto
        '
        Me.SemFoto.BackColor = System.Drawing.Color.Transparent
        Me.SemFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SemFoto.Image = CType(resources.GetObject("SemFoto.Image"), System.Drawing.Image)
        Me.SemFoto.Location = New System.Drawing.Point(339, 83)
        Me.SemFoto.Name = "SemFoto"
        Me.SemFoto.Size = New System.Drawing.Size(39, 46)
        Me.SemFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SemFoto.TabIndex = 168
        Me.SemFoto.TabStop = False
        Me.SemFoto.Visible = False
        '
        'PainelFuncionario
        '
        Me.PainelFuncionario.Controls.Add(Me.Funcionario)
        Me.PainelFuncionario.Controls.Add(Me.Label3)
        Me.PainelFuncionario.Location = New System.Drawing.Point(6, 121)
        Me.PainelFuncionario.Name = "PainelFuncionario"
        Me.PainelFuncionario.Size = New System.Drawing.Size(162, 23)
        Me.PainelFuncionario.TabIndex = 169
        Me.PainelFuncionario.Visible = False
        '
        'Gerar
        '
        Me.Gerar.Location = New System.Drawing.Point(312, 222)
        Me.Gerar.Name = "Gerar"
        Me.Gerar.Size = New System.Drawing.Size(82, 29)
        Me.Gerar.TabIndex = 170
        Me.Gerar.Text = "Gerar"
        Me.Gerar.UseVisualStyleBackColor = True
        '
        'MyBarra
        '
        Me.MyBarra.BackColor = System.Drawing.Color.DimGray
        Me.MyBarra.ForeColor = System.Drawing.Color.DarkOrange
        Me.MyBarra.Location = New System.Drawing.Point(6, 165)
        Me.MyBarra.Name = "MyBarra"
        Me.MyBarra.Size = New System.Drawing.Size(476, 26)
        Me.MyBarra.TabIndex = 171
        Me.MyBarra.Visible = False
        '
        'Msg
        '
        Me.Msg.BackColor = System.Drawing.Color.Transparent
        Me.Msg.ForeColor = System.Drawing.Color.Black
        Me.Msg.Location = New System.Drawing.Point(6, 194)
        Me.Msg.Name = "Msg"
        Me.Msg.Size = New System.Drawing.Size(476, 20)
        Me.Msg.TabIndex = 172
        Me.Msg.Text = "Msg"
        Me.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Msg.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.MensalCompetencia)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Msg)
        Me.Fundo.Controls.Add(Me.Modulo)
        Me.Fundo.Controls.Add(Me.PainelFuncionario)
        Me.Fundo.Controls.Add(Me.GroupBox1)
        Me.Fundo.Controls.Add(Me.SemFoto)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.MyBarra)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Display)
        Me.Fundo.Controls.Add(Me.FuncionarioDesc)
        Me.Fundo.Controls.Add(Me.TipoGeradorBT)
        Me.Fundo.Controls.Add(Me.Gerar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(491, 257)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 173
        '
        'FolhaPgtoGerador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoGerador"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerador da Folha de Pagamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuTipoGerador.ResumeLayout(False)
        CType(Me.Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PainelFuncionario.ResumeLayout(False)
        Me.PainelFuncionario.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MensalCompetencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Modulo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Funcionario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Todos As System.Windows.Forms.RadioButton
    Friend WithEvents Individual As System.Windows.Forms.RadioButton
    Friend WithEvents FuncionarioDesc As System.Windows.Forms.Label
    Friend WithEvents TipoGeradorBT As System.Windows.Forms.Label
    Friend WithEvents MenuTipoGerador As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MensalDiaristaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FériasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DécimoTerceiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PgtoPISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecisãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Display As System.Windows.Forms.PictureBox
    Friend WithEvents SemFoto As System.Windows.Forms.PictureBox
    Friend WithEvents PainelFuncionario As System.Windows.Forms.Panel
    Friend WithEvents ValeQuinzenalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gerar As System.Windows.Forms.Button
    Friend WithEvents MyBarra As System.Windows.Forms.ProgressBar
    Friend WithEvents Msg As System.Windows.Forms.Label
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
