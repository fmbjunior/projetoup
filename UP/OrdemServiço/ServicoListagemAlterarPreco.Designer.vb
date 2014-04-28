<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicoListagemAlterarPreco
    Inherits System.Windows.Forms.Form

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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonFiltar = New DevComponents.DotNetBar.ButtonX()
        Me.cGrupoServico = New CBOAutoCompleteFocus.CboFocus()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.fechar = New DevComponents.DotNetBar.ButtonX()
        Me.salvar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ButtonFiltar)
        Me.PanelEx1.Controls.Add(Me.cGrupoServico)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Dgv)
        Me.PanelEx1.Controls.Add(Me.fechar)
        Me.PanelEx1.Controls.Add(Me.salvar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(850, 450)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'ButtonFiltar
        '
        Me.ButtonFiltar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonFiltar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonFiltar.Location = New System.Drawing.Point(451, 10)
        Me.ButtonFiltar.Name = "ButtonFiltar"
        Me.ButtonFiltar.Size = New System.Drawing.Size(85, 23)
        Me.ButtonFiltar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonFiltar.TabIndex = 2
        Me.ButtonFiltar.Text = "Filtrar"
        '
        'cGrupoServico
        '
        Me.cGrupoServico.Auto_Complete = True
        Me.cGrupoServico.AutoLimitar_Lista = True
        Me.cGrupoServico.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cGrupoServico.CPObrigatorio = False
        Me.cGrupoServico.CPObrigatorioMsg = Nothing
        Me.cGrupoServico.FlatBorder = False
        Me.cGrupoServico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cGrupoServico.FormattingEnabled = True
        Me.cGrupoServico.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cGrupoServico.HighlightBorderOnEnter = False
        Me.cGrupoServico.Location = New System.Drawing.Point(95, 12)
        Me.cGrupoServico.Name = "cGrupoServico"
        Me.cGrupoServico.Size = New System.Drawing.Size(350, 21)
        Me.cGrupoServico.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Grupo Serviço"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(12, 39)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RowHeadersWidth = 25
        Me.Dgv.ShowEditingIcon = False
        Me.Dgv.Size = New System.Drawing.Size(833, 352)
        Me.Dgv.TabIndex = 3
        '
        'fechar
        '
        Me.fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.fechar.Location = New System.Drawing.Point(112, 396)
        Me.fechar.Name = "fechar"
        Me.fechar.Size = New System.Drawing.Size(96, 36)
        Me.fechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechar.TabIndex = 5
        Me.fechar.Text = "Fechar"
        '
        'salvar
        '
        Me.salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.salvar.Location = New System.Drawing.Point(12, 396)
        Me.salvar.Name = "salvar"
        Me.salvar.Size = New System.Drawing.Size(96, 36)
        Me.salvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.salvar.TabIndex = 4
        Me.salvar.Text = "Salvar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ServicoListagemAlterarPreco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 450)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ServicoListagemAlterarPreco"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar preço Serviço - T040"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents salvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cGrupoServico As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonFiltar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
