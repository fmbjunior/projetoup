<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoRelat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoRelat))
        Me.Visualizar = New System.Windows.Forms.Button
        Me.Fechar = New System.Windows.Forms.Button
        Me.Opções = New System.Windows.Forms.GroupBox
        Me.A4 = New System.Windows.Forms.RadioButton
        Me.A3 = New System.Windows.Forms.RadioButton
        Me.A2 = New System.Windows.Forms.RadioButton
        Me.A1 = New System.Windows.Forms.RadioButton
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.PainelEvento = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Evento = New TexBoxFocusNet.TextBoxFocusNet
        Me.SubRelat = New System.Windows.Forms.GroupBox
        Me.B5 = New System.Windows.Forms.RadioButton
        Me.B4 = New System.Windows.Forms.RadioButton
        Me.B3 = New System.Windows.Forms.RadioButton
        Me.B2 = New System.Windows.Forms.RadioButton
        Me.B1 = New System.Windows.Forms.RadioButton
        Me.PainelFuncionario = New System.Windows.Forms.Panel
        Me.FuncDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Func = New TexBoxFocusNet.TextBoxFocusNet
        Me.PainelCompetencia = New System.Windows.Forms.Panel
        Me.Competencia = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Modulo = New TexBoxFocusNet.TextBoxFocusNet
        Me.TipoGeradorBT = New System.Windows.Forms.Label
        Me.MenuTipoGerador = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MensalDiaristaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FériasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DécimoTerceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PgtoPISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecisãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ValeQuinzenalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Opções.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.PainelEvento.SuspendLayout()
        Me.SubRelat.SuspendLayout()
        Me.PainelFuncionario.SuspendLayout()
        Me.PainelCompetencia.SuspendLayout()
        Me.MenuTipoGerador.SuspendLayout()
        Me.SuspendLayout()
        '
        'Visualizar
        '
        Me.Visualizar.Image = CType(resources.GetObject("Visualizar.Image"), System.Drawing.Image)
        Me.Visualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Visualizar.Location = New System.Drawing.Point(404, 309)
        Me.Visualizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visualizar.Name = "Visualizar"
        Me.Visualizar.Size = New System.Drawing.Size(111, 54)
        Me.Visualizar.TabIndex = 5
        Me.Visualizar.Text = "Visualizar"
        Me.Visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Visualizar.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(521, 309)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(111, 54)
        Me.Fechar.TabIndex = 6
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'Opções
        '
        Me.Opções.Controls.Add(Me.A4)
        Me.Opções.Controls.Add(Me.A3)
        Me.Opções.Controls.Add(Me.A2)
        Me.Opções.Controls.Add(Me.A1)
        Me.Opções.Location = New System.Drawing.Point(3, 3)
        Me.Opções.Name = "Opções"
        Me.Opções.Size = New System.Drawing.Size(244, 190)
        Me.Opções.TabIndex = 0
        Me.Opções.TabStop = False
        Me.Opções.Text = "Selecione o Relatório"
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(5, 97)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(41, 20)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "PIS"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(6, 71)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(183, 20)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Vales de Funcionários via Caixa"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(6, 45)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(158, 20)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Folha Pagamento (Valores)"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(6, 19)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(147, 20)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Vale Quinzenal (Valores)"
        Me.A1.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.PainelEvento)
        Me.Fundo.Controls.Add(Me.SubRelat)
        Me.Fundo.Controls.Add(Me.PainelFuncionario)
        Me.Fundo.Controls.Add(Me.PainelCompetencia)
        Me.Fundo.Controls.Add(Me.Opções)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Visualizar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(644, 375)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'PainelEvento
        '
        Me.PainelEvento.Controls.Add(Me.Label2)
        Me.PainelEvento.Controls.Add(Me.Evento)
        Me.PainelEvento.Location = New System.Drawing.Point(258, 132)
        Me.PainelEvento.Name = "PainelEvento"
        Me.PainelEvento.Size = New System.Drawing.Size(373, 30)
        Me.PainelEvento.TabIndex = 4
        Me.PainelEvento.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Informe o Evento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Evento
        '
        Me.Evento.AceitaColarTexto = True
        Me.Evento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Evento.CasasDecimais = 0
        Me.Evento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Evento.CPObrigatorio = False
        Me.Evento.CPObrigatorioMsg = Nothing
        Me.Evento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Evento.FocusColor = System.Drawing.Color.Empty
        Me.Evento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Evento.Location = New System.Drawing.Point(116, 3)
        Me.Evento.Name = "Evento"
        Me.Evento.RegraValidação = Nothing
        Me.Evento.RegraValidaçãoMensagem = Nothing
        Me.Evento.Size = New System.Drawing.Size(59, 20)
        Me.Evento.TabIndex = 1
        Me.Evento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Evento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Evento.ValorPadrao = Nothing
        '
        'SubRelat
        '
        Me.SubRelat.Controls.Add(Me.B5)
        Me.SubRelat.Controls.Add(Me.B4)
        Me.SubRelat.Controls.Add(Me.B3)
        Me.SubRelat.Controls.Add(Me.B2)
        Me.SubRelat.Controls.Add(Me.B1)
        Me.SubRelat.Location = New System.Drawing.Point(3, 206)
        Me.SubRelat.Name = "SubRelat"
        Me.SubRelat.Size = New System.Drawing.Size(244, 157)
        Me.SubRelat.TabIndex = 1
        Me.SubRelat.TabStop = False
        Me.SubRelat.Text = "Opções"
        Me.SubRelat.Visible = False
        '
        'B5
        '
        Me.B5.AutoSize = True
        Me.B5.Location = New System.Drawing.Point(7, 123)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(158, 20)
        Me.B5.TabIndex = 4
        Me.B5.TabStop = True
        Me.B5.Text = "Por Competência e Evento"
        Me.B5.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.AutoSize = True
        Me.B4.Location = New System.Drawing.Point(6, 97)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(182, 20)
        Me.B4.TabIndex = 3
        Me.B4.TabStop = True
        Me.B4.Text = "Por Funcionário e Competência"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.AutoSize = True
        Me.B3.Location = New System.Drawing.Point(6, 71)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(105, 20)
        Me.B3.TabIndex = 2
        Me.B3.TabStop = True
        Me.B3.Text = "Por Funcionário"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.AutoSize = True
        Me.B2.Location = New System.Drawing.Point(6, 45)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(152, 20)
        Me.B2.TabIndex = 1
        Me.B2.TabStop = True
        Me.B2.Text = "Competência Selecionada"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.AutoSize = True
        Me.B1.Location = New System.Drawing.Point(6, 19)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(123, 20)
        Me.B1.TabIndex = 0
        Me.B1.TabStop = True
        Me.B1.Text = "Todas Competência"
        Me.B1.UseVisualStyleBackColor = True
        '
        'PainelFuncionario
        '
        Me.PainelFuncionario.Controls.Add(Me.FuncDesc)
        Me.PainelFuncionario.Controls.Add(Me.Label1)
        Me.PainelFuncionario.Controls.Add(Me.Func)
        Me.PainelFuncionario.Location = New System.Drawing.Point(258, 48)
        Me.PainelFuncionario.Name = "PainelFuncionario"
        Me.PainelFuncionario.Size = New System.Drawing.Size(373, 78)
        Me.PainelFuncionario.TabIndex = 3
        Me.PainelFuncionario.Visible = False
        '
        'FuncDesc
        '
        Me.FuncDesc.AceitaColarTexto = True
        Me.FuncDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FuncDesc.CasasDecimais = 0
        Me.FuncDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FuncDesc.CPObrigatorio = False
        Me.FuncDesc.CPObrigatorioMsg = Nothing
        Me.FuncDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FuncDesc.FocusColor = System.Drawing.Color.Empty
        Me.FuncDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FuncDesc.Location = New System.Drawing.Point(7, 52)
        Me.FuncDesc.Name = "FuncDesc"
        Me.FuncDesc.RegraValidação = Nothing
        Me.FuncDesc.RegraValidaçãoMensagem = Nothing
        Me.FuncDesc.Size = New System.Drawing.Size(363, 20)
        Me.FuncDesc.TabIndex = 2
        Me.FuncDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe o Funcionário"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Func
        '
        Me.Func.AceitaColarTexto = True
        Me.Func.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Func.CasasDecimais = 0
        Me.Func.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Func.CPObrigatorio = False
        Me.Func.CPObrigatorioMsg = Nothing
        Me.Func.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Func.FocusColor = System.Drawing.Color.Empty
        Me.Func.FocusColorEnd = System.Drawing.Color.Empty
        Me.Func.Location = New System.Drawing.Point(7, 26)
        Me.Func.Name = "Func"
        Me.Func.RegraValidação = Nothing
        Me.Func.RegraValidaçãoMensagem = Nothing
        Me.Func.Size = New System.Drawing.Size(100, 20)
        Me.Func.TabIndex = 1
        Me.Func.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Func.ValorPadrao = Nothing
        '
        'PainelCompetencia
        '
        Me.PainelCompetencia.Controls.Add(Me.TipoGeradorBT)
        Me.PainelCompetencia.Controls.Add(Me.Label3)
        Me.PainelCompetencia.Controls.Add(Me.Competencia)
        Me.PainelCompetencia.Controls.Add(Me.Modulo)
        Me.PainelCompetencia.Controls.Add(Me.Label8)
        Me.PainelCompetencia.Location = New System.Drawing.Point(258, 12)
        Me.PainelCompetencia.Name = "PainelCompetencia"
        Me.PainelCompetencia.Size = New System.Drawing.Size(373, 30)
        Me.PainelCompetencia.TabIndex = 2
        Me.PainelCompetencia.Visible = False
        '
        'Competencia
        '
        Me.Competencia.AceitaColarTexto = True
        Me.Competencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Competencia.CasasDecimais = 0
        Me.Competencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Competencia.CPObrigatorio = False
        Me.Competencia.CPObrigatorioMsg = Nothing
        Me.Competencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.Competencia.FocusColor = System.Drawing.Color.Empty
        Me.Competencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Competencia.Location = New System.Drawing.Point(88, 5)
        Me.Competencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Competencia.MaxLength = 7
        Me.Competencia.Name = "Competencia"
        Me.Competencia.RegraValidação = Nothing
        Me.Competencia.RegraValidaçãoMensagem = Nothing
        Me.Competencia.Size = New System.Drawing.Size(75, 20)
        Me.Competencia.TabIndex = 1
        Me.Competencia.TabStop = False
        Me.Competencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Competencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.Competencia.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Competência"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(173, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Modulo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Modulo
        '
        Me.Modulo.AceitaColarTexto = True
        Me.Modulo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Modulo.CasasDecimais = 0
        Me.Modulo.CPObrigatorio = False
        Me.Modulo.CPObrigatorioMsg = Nothing
        Me.Modulo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Modulo.FocusColor = System.Drawing.Color.Empty
        Me.Modulo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Modulo.Location = New System.Drawing.Point(234, 5)
        Me.Modulo.MaxLength = 16
        Me.Modulo.Name = "Modulo"
        Me.Modulo.RegraValidação = Nothing
        Me.Modulo.RegraValidaçãoMensagem = Nothing
        Me.Modulo.Size = New System.Drawing.Size(97, 20)
        Me.Modulo.TabIndex = 8
        Me.Modulo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Modulo.ValorPadrao = Nothing
        '
        'TipoGeradorBT
        '
        Me.TipoGeradorBT.BackColor = System.Drawing.Color.Transparent
        Me.TipoGeradorBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TipoGeradorBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoGeradorBT.Location = New System.Drawing.Point(337, 5)
        Me.TipoGeradorBT.Name = "TipoGeradorBT"
        Me.TipoGeradorBT.Size = New System.Drawing.Size(27, 20)
        Me.TipoGeradorBT.TabIndex = 7
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
        'FolhaPgtoRelat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoRelat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios da Folha de Pagamento"
        Me.Opções.ResumeLayout(False)
        Me.Opções.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.PainelEvento.ResumeLayout(False)
        Me.PainelEvento.PerformLayout()
        Me.SubRelat.ResumeLayout(False)
        Me.SubRelat.PerformLayout()
        Me.PainelFuncionario.ResumeLayout(False)
        Me.PainelFuncionario.PerformLayout()
        Me.PainelCompetencia.ResumeLayout(False)
        Me.PainelCompetencia.PerformLayout()
        Me.MenuTipoGerador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Visualizar As System.Windows.Forms.Button
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Opções As System.Windows.Forms.GroupBox
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelCompetencia As System.Windows.Forms.Panel
    Friend WithEvents Competencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelFuncionario As System.Windows.Forms.Panel
    Friend WithEvents FuncDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Func As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents SubRelat As System.Windows.Forms.GroupBox
    Friend WithEvents B4 As System.Windows.Forms.RadioButton
    Friend WithEvents B3 As System.Windows.Forms.RadioButton
    Friend WithEvents B2 As System.Windows.Forms.RadioButton
    Friend WithEvents B1 As System.Windows.Forms.RadioButton
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents B5 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelEvento As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Evento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Modulo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TipoGeradorBT As System.Windows.Forms.Label
    Friend WithEvents MenuTipoGerador As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MensalDiaristaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FériasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DécimoTerceiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PgtoPISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecisãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValeQuinzenalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
