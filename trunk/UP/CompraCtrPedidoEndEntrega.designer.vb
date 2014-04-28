<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraCtrPedidoEndEntrega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompraCtrPedidoEndEntrega))
        Me.Label2 = New System.Windows.Forms.Label
        Me.EntregaCidade = New TexBoxFocusNet.TextBoxFocusNet
        Me.OrdemLabel = New System.Windows.Forms.Label
        Me.Entregalocal = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.EntregaUF = New TexBoxFocusNet.TextBoxFocusNet
        Me.MenuDataLancamento = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TravarOCampoDataDeLançamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DestravarOCampoDataDeLançamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label9 = New System.Windows.Forms.Label
        Me.EntregaCep = New TexBoxFocusNet.TextBoxFocusNet
        Me.MenuMyLista = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarItenSelecionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcluirItenSelecionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.EntregaEnd = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label16 = New System.Windows.Forms.Label
        Me.MenuDataLancamento.SuspendLayout()
        Me.MenuMyLista.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cidade Entrega"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EntregaCidade
        '
        Me.EntregaCidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntregaCidade.CasasDecimais = 0
        Me.EntregaCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntregaCidade.CPObrigatorio = False
        Me.EntregaCidade.CPObrigatorioMsg = Nothing
        Me.EntregaCidade.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntregaCidade.FocusColor = System.Drawing.Color.Empty
        Me.EntregaCidade.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntregaCidade.Location = New System.Drawing.Point(131, 63)
        Me.EntregaCidade.MaxLength = 35
        Me.EntregaCidade.Name = "EntregaCidade"
        Me.EntregaCidade.RegraValidação = Nothing
        Me.EntregaCidade.RegraValidaçãoMensagem = Nothing
        Me.EntregaCidade.Size = New System.Drawing.Size(243, 21)
        Me.EntregaCidade.TabIndex = 13
        Me.EntregaCidade.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntregaCidade.ValorPadrao = Nothing
        '
        'OrdemLabel
        '
        Me.OrdemLabel.BackColor = System.Drawing.Color.Transparent
        Me.OrdemLabel.Location = New System.Drawing.Point(12, 9)
        Me.OrdemLabel.Name = "OrdemLabel"
        Me.OrdemLabel.Size = New System.Drawing.Size(113, 20)
        Me.OrdemLabel.TabIndex = 1
        Me.OrdemLabel.Text = "Local Entrega"
        Me.OrdemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Entregalocal
        '
        Me.Entregalocal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Entregalocal.CasasDecimais = 0
        Me.Entregalocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Entregalocal.CPObrigatorio = False
        Me.Entregalocal.CPObrigatorioMsg = Nothing
        Me.Entregalocal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Entregalocal.FocusColor = System.Drawing.Color.Empty
        Me.Entregalocal.FocusColorEnd = System.Drawing.Color.Empty
        Me.Entregalocal.Location = New System.Drawing.Point(131, 9)
        Me.Entregalocal.MaxLength = 50
        Me.Entregalocal.Name = "Entregalocal"
        Me.Entregalocal.RegraValidação = Nothing
        Me.Entregalocal.RegraValidaçãoMensagem = Nothing
        Me.Entregalocal.Size = New System.Drawing.Size(513, 21)
        Me.Entregalocal.TabIndex = 2
        Me.Entregalocal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Entregalocal.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(380, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "UF"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EntregaUF
        '
        Me.EntregaUF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntregaUF.CasasDecimais = 0
        Me.EntregaUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntregaUF.CPObrigatorio = False
        Me.EntregaUF.CPObrigatorioMsg = Nothing
        Me.EntregaUF.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntregaUF.FocusColor = System.Drawing.Color.Empty
        Me.EntregaUF.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntregaUF.Location = New System.Drawing.Point(412, 64)
        Me.EntregaUF.MaxLength = 2
        Me.EntregaUF.Name = "EntregaUF"
        Me.EntregaUF.RegraValidação = Nothing
        Me.EntregaUF.RegraValidaçãoMensagem = Nothing
        Me.EntregaUF.Size = New System.Drawing.Size(29, 21)
        Me.EntregaUF.TabIndex = 18
        Me.EntregaUF.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntregaUF.ValorPadrao = Nothing
        '
        'MenuDataLancamento
        '
        Me.MenuDataLancamento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TravarOCampoDataDeLançamentoToolStripMenuItem, Me.DestravarOCampoDataDeLançamentoToolStripMenuItem})
        Me.MenuDataLancamento.Name = "MenuDataLancamento"
        Me.MenuDataLancamento.Size = New System.Drawing.Size(288, 48)
        '
        'TravarOCampoDataDeLançamentoToolStripMenuItem
        '
        Me.TravarOCampoDataDeLançamentoToolStripMenuItem.Name = "TravarOCampoDataDeLançamentoToolStripMenuItem"
        Me.TravarOCampoDataDeLançamentoToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.TravarOCampoDataDeLançamentoToolStripMenuItem.Text = "Travar o Campo Data de Lançamento"
        '
        'DestravarOCampoDataDeLançamentoToolStripMenuItem
        '
        Me.DestravarOCampoDataDeLançamentoToolStripMenuItem.Name = "DestravarOCampoDataDeLançamentoToolStripMenuItem"
        Me.DestravarOCampoDataDeLançamentoToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.DestravarOCampoDataDeLançamentoToolStripMenuItem.Text = "Destravar o Campo Data de Lançamento"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(475, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "CEP"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EntregaCep
        '
        Me.EntregaCep.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntregaCep.CasasDecimais = 0
        Me.EntregaCep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntregaCep.CPObrigatorio = False
        Me.EntregaCep.CPObrigatorioMsg = Nothing
        Me.EntregaCep.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntregaCep.FocusColor = System.Drawing.Color.Empty
        Me.EntregaCep.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntregaCep.Location = New System.Drawing.Point(546, 64)
        Me.EntregaCep.MaxLength = 9
        Me.EntregaCep.Name = "EntregaCep"
        Me.EntregaCep.RegraValidação = Nothing
        Me.EntregaCep.RegraValidaçãoMensagem = Nothing
        Me.EntregaCep.Size = New System.Drawing.Size(98, 21)
        Me.EntregaCep.TabIndex = 20
        Me.EntregaCep.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cep
        Me.EntregaCep.ValorPadrao = Nothing
        '
        'MenuMyLista
        '
        Me.MenuMyLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarItenSelecionadoToolStripMenuItem, Me.ExcluirItenSelecionadoToolStripMenuItem})
        Me.MenuMyLista.Name = "MenuMyLista"
        Me.MenuMyLista.Size = New System.Drawing.Size(199, 48)
        '
        'EditarItenSelecionadoToolStripMenuItem
        '
        Me.EditarItenSelecionadoToolStripMenuItem.Name = "EditarItenSelecionadoToolStripMenuItem"
        Me.EditarItenSelecionadoToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EditarItenSelecionadoToolStripMenuItem.Text = "Editar Iten Selecionado"
        '
        'ExcluirItenSelecionadoToolStripMenuItem
        '
        Me.ExcluirItenSelecionadoToolStripMenuItem.Name = "ExcluirItenSelecionadoToolStripMenuItem"
        Me.ExcluirItenSelecionadoToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ExcluirItenSelecionadoToolStripMenuItem.Text = "Excluir Iten Selecionado"
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.EntregaEnd)
        Me.Fundo.Controls.Add(Me.Label16)
        Me.Fundo.Controls.Add(Me.Entregalocal)
        Me.Fundo.Controls.Add(Me.OrdemLabel)
        Me.Fundo.Controls.Add(Me.EntregaCidade)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.EntregaUF)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.EntregaCep)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(656, 140)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(472, 101)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(83, 28)
        Me.btSalvar.TabIndex = 22
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(561, 101)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(83, 28)
        Me.btFechar.TabIndex = 21
        Me.btFechar.Text = "Fechar"
        '
        'EntregaEnd
        '
        Me.EntregaEnd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntregaEnd.CasasDecimais = 0
        Me.EntregaEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntregaEnd.CPObrigatorio = False
        Me.EntregaEnd.CPObrigatorioMsg = Nothing
        Me.EntregaEnd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntregaEnd.FocusColor = System.Drawing.Color.Empty
        Me.EntregaEnd.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntregaEnd.Location = New System.Drawing.Point(131, 36)
        Me.EntregaEnd.MaxLength = 50
        Me.EntregaEnd.Name = "EntregaEnd"
        Me.EntregaEnd.RegraValidação = ""
        Me.EntregaEnd.RegraValidaçãoMensagem = ""
        Me.EntregaEnd.Size = New System.Drawing.Size(513, 21)
        Me.EntregaEnd.TabIndex = 9
        Me.EntregaEnd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntregaEnd.ValorPadrao = Nothing
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(12, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 20)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "End. Entrega"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompraCtrPedidoEndEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(656, 140)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CompraCtrPedidoEndEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordem de Compra"
        Me.MenuDataLancamento.ResumeLayout(False)
        Me.MenuMyLista.ResumeLayout(False)
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EntregaCidade As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents OrdemLabel As System.Windows.Forms.Label
    Friend WithEvents Entregalocal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EntregaUF As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EntregaCep As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MenuDataLancamento As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TravarOCampoDataDeLançamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestravarOCampoDataDeLançamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuMyLista As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditarItenSelecionadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirItenSelecionadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents EntregaEnd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
End Class
