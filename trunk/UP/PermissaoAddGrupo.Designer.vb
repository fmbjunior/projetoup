<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermissaoAddGrupo
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.EFocusPanel1 = New EFocusPanel.EFocusPanel(Me.components)
        Me.Exclui = New System.Windows.Forms.CheckBox()
        Me.Adiciona = New System.Windows.Forms.CheckBox()
        Me.Altera = New System.Windows.Forms.CheckBox()
        Me.Consultar = New System.Windows.Forms.CheckBox()
        Me.Inativo = New System.Windows.Forms.CheckBox()
        Me.Login = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selecao = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescricaoTela = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tela = New TexBoxFocusNet.TextBoxFocusNet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.EFocusPanel1.SuspendLayout()
        CType(Me.Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.EFocusPanel1)
        Me.PanelEx1.Controls.Add(Me.Login)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.DescricaoTela)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Tela)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(424, 327)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'EFocusPanel1
        '
        Me.EFocusPanel1.Controls.Add(Me.Exclui)
        Me.EFocusPanel1.Controls.Add(Me.Adiciona)
        Me.EFocusPanel1.Controls.Add(Me.Altera)
        Me.EFocusPanel1.Controls.Add(Me.Consultar)
        Me.EFocusPanel1.Controls.Add(Me.Inativo)
        Me.EFocusPanel1.Icon = Nothing
        Me.EFocusPanel1.Image = Nothing
        Me.EFocusPanel1.IsTransparent = False
        Me.EFocusPanel1.LineColor = System.Drawing.SystemColors.Highlight
        Me.EFocusPanel1.Location = New System.Drawing.Point(260, 131)
        Me.EFocusPanel1.Name = "EFocusPanel1"
        Me.EFocusPanel1.Padding = New System.Windows.Forms.Padding(4, 22, 4, 4)
        Me.EFocusPanel1.Size = New System.Drawing.Size(156, 155)
        Me.EFocusPanel1.TabIndex = 16
        Me.EFocusPanel1.Text = "Permissões"
        '
        'Exclui
        '
        Me.Exclui.AutoSize = True
        Me.Exclui.Location = New System.Drawing.Point(7, 25)
        Me.Exclui.Name = "Exclui"
        Me.Exclui.Size = New System.Drawing.Size(64, 19)
        Me.Exclui.TabIndex = 7
        Me.Exclui.Text = "Excluir"
        Me.Exclui.UseVisualStyleBackColor = True
        '
        'Adiciona
        '
        Me.Adiciona.AutoSize = True
        Me.Adiciona.Location = New System.Drawing.Point(7, 50)
        Me.Adiciona.Name = "Adiciona"
        Me.Adiciona.Size = New System.Drawing.Size(73, 19)
        Me.Adiciona.TabIndex = 8
        Me.Adiciona.Text = "Adcionar"
        Me.Adiciona.UseVisualStyleBackColor = True
        '
        'Altera
        '
        Me.Altera.AutoSize = True
        Me.Altera.Location = New System.Drawing.Point(7, 75)
        Me.Altera.Name = "Altera"
        Me.Altera.Size = New System.Drawing.Size(63, 19)
        Me.Altera.TabIndex = 9
        Me.Altera.Text = "Alterar"
        Me.Altera.UseVisualStyleBackColor = True
        '
        'Consultar
        '
        Me.Consultar.AutoSize = True
        Me.Consultar.Location = New System.Drawing.Point(6, 100)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(74, 19)
        Me.Consultar.TabIndex = 10
        Me.Consultar.Text = "Consultar"
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'Inativo
        '
        Me.Inativo.AutoSize = True
        Me.Inativo.Location = New System.Drawing.Point(6, 125)
        Me.Inativo.Name = "Inativo"
        Me.Inativo.Size = New System.Drawing.Size(64, 19)
        Me.Inativo.TabIndex = 11
        Me.Inativo.Text = "Inativo"
        Me.Inativo.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.Login.AllowUserToAddRows = False
        Me.Login.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Login.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Login.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.User, Me.Selecao})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Login.DefaultCellStyle = DataGridViewCellStyle2
        Me.Login.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Login.Location = New System.Drawing.Point(12, 131)
        Me.Login.Name = "Login"
        Me.Login.RowHeadersWidth = 20
        Me.Login.SelectAllSignVisible = False
        Me.Login.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Login.Size = New System.Drawing.Size(242, 184)
        Me.Login.TabIndex = 15
        '
        'User
        '
        Me.User.DataPropertyName = "Login"
        Me.User.HeaderText = "Usuário"
        Me.User.Name = "User"
        Me.User.ReadOnly = True
        Me.User.Width = 150
        '
        'Selecao
        '
        Me.Selecao.HeaderText = ""
        Me.Selecao.Name = "Selecao"
        Me.Selecao.Width = 50
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(260, 292)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.TabIndex = 12
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(341, 292)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 14
        Me.btFechar.Text = "Fechar"
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = True
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = True
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(355, 8)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(61, 23)
        Me.Id.TabIndex = 6
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descrição"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescricaoTela
        '
        Me.DescricaoTela.AceitaColarTexto = True
        Me.DescricaoTela.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescricaoTela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescricaoTela.CasasDecimais = 0
        Me.DescricaoTela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescricaoTela.CPObrigatorio = False
        Me.DescricaoTela.CPObrigatorioMsg = Nothing
        Me.DescricaoTela.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescricaoTela.FlatBorder = True
        Me.DescricaoTela.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescricaoTela.FocusColor = System.Drawing.Color.MistyRose
        Me.DescricaoTela.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescricaoTela.HighlightBorderOnEnter = True
        Me.DescricaoTela.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescricaoTela.Location = New System.Drawing.Point(12, 89)
        Me.DescricaoTela.Multiline = True
        Me.DescricaoTela.Name = "DescricaoTela"
        Me.DescricaoTela.PreencherZeroEsqueda = False
        Me.DescricaoTela.RegraValidação = Nothing
        Me.DescricaoTela.RegraValidaçãoMensagem = Nothing
        Me.DescricaoTela.Size = New System.Drawing.Size(404, 36)
        Me.DescricaoTela.TabIndex = 3
        Me.DescricaoTela.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescricaoTela.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tela"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tela
        '
        Me.Tela.AceitaColarTexto = True
        Me.Tela.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Tela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tela.CasasDecimais = 0
        Me.Tela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tela.CPObrigatorio = False
        Me.Tela.CPObrigatorioMsg = Nothing
        Me.Tela.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Tela.FlatBorder = True
        Me.Tela.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Tela.FocusColor = System.Drawing.Color.MistyRose
        Me.Tela.FocusColorEnd = System.Drawing.Color.Empty
        Me.Tela.HighlightBorderOnEnter = True
        Me.Tela.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Tela.Location = New System.Drawing.Point(12, 37)
        Me.Tela.Name = "Tela"
        Me.Tela.PreencherZeroEsqueda = False
        Me.Tela.RegraValidação = Nothing
        Me.Tela.RegraValidaçãoMensagem = Nothing
        Me.Tela.Size = New System.Drawing.Size(404, 23)
        Me.Tela.TabIndex = 1
        Me.Tela.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Tela.ValorPadrao = Nothing
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'PermissaoAddGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "PermissaoAddGrupo"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adição e Edição de Permissão - T187"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.EFocusPanel1.ResumeLayout(False)
        Me.EFocusPanel1.PerformLayout()
        CType(Me.Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Inativo As System.Windows.Forms.CheckBox
    Friend WithEvents Consultar As System.Windows.Forms.CheckBox
    Friend WithEvents Altera As System.Windows.Forms.CheckBox
    Friend WithEvents Adiciona As System.Windows.Forms.CheckBox
    Friend WithEvents Exclui As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tela As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DescricaoTela As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Login As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents EFocusPanel1 As EFocusPanel.EFocusPanel
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Selecao As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
