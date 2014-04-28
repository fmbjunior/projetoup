<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndustriaSubComposiçãoItens
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.CodigoMateriaPrima = New TexBoxFocusNet.TextBoxFocusNet
        Me.DescriçãoMP = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.Unitario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.Total = New TexBoxFocusNet.TextBoxFocusNet
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.btExcluir = New DevComponents.DotNetBar.ButtonX
        Me.btNovo = New DevComponents.DotNetBar.ButtonX
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.Label6 = New System.Windows.Forms.Label
        Me.UnidadeMedida = New TexBoxFocusNet.TextBoxFocusNet
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(476, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.Enabled = False
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(556, 64)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(106, 20)
        Me.Id.TabIndex = 12
        Me.Id.TabStop = False
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código MP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoMateriaPrima
        '
        Me.CodigoMateriaPrima.AceitaColarTexto = True
        Me.CodigoMateriaPrima.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoMateriaPrima.CasasDecimais = 0
        Me.CodigoMateriaPrima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoMateriaPrima.CPObrigatorio = False
        Me.CodigoMateriaPrima.CPObrigatorioMsg = Nothing
        Me.CodigoMateriaPrima.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoMateriaPrima.FocusColor = System.Drawing.Color.MistyRose
        Me.CodigoMateriaPrima.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoMateriaPrima.Location = New System.Drawing.Point(133, 12)
        Me.CodigoMateriaPrima.MaxLength = 10
        Me.CodigoMateriaPrima.Name = "CodigoMateriaPrima"
        Me.CodigoMateriaPrima.RegraValidação = Nothing
        Me.CodigoMateriaPrima.RegraValidaçãoMensagem = Nothing
        Me.CodigoMateriaPrima.Size = New System.Drawing.Size(106, 20)
        Me.CodigoMateriaPrima.TabIndex = 1
        Me.CodigoMateriaPrima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoMateriaPrima.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoMateriaPrima.ValorPadrao = Nothing
        '
        'DescriçãoMP
        '
        Me.DescriçãoMP.AceitaColarTexto = True
        Me.DescriçãoMP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DescriçãoMP.CasasDecimais = 0
        Me.DescriçãoMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescriçãoMP.CPObrigatorio = False
        Me.DescriçãoMP.CPObrigatorioMsg = Nothing
        Me.DescriçãoMP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescriçãoMP.FocusColor = System.Drawing.Color.MistyRose
        Me.DescriçãoMP.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescriçãoMP.Location = New System.Drawing.Point(245, 12)
        Me.DescriçãoMP.MaxLength = 50
        Me.DescriçãoMP.Name = "DescriçãoMP"
        Me.DescriçãoMP.RegraValidação = Nothing
        Me.DescriçãoMP.RegraValidaçãoMensagem = Nothing
        Me.DescriçãoMP.Size = New System.Drawing.Size(417, 20)
        Me.DescriçãoMP.TabIndex = 2
        Me.DescriçãoMP.TabStop = False
        Me.DescriçãoMP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescriçãoMP.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantidade"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Qtd
        '
        Me.Qtd.AceitaColarTexto = True
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 4
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.CPObrigatorio = False
        Me.Qtd.CPObrigatorioMsg = Nothing
        Me.Qtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd.FocusColor = System.Drawing.Color.MistyRose
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.Location = New System.Drawing.Point(133, 38)
        Me.Qtd.MaxLength = 8
        Me.Qtd.Name = "Qtd"
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.RegraValidaçãoMensagem = Nothing
        Me.Qtd.Size = New System.Drawing.Size(106, 20)
        Me.Qtd.TabIndex = 4
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(473, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Unitário"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Unitario
        '
        Me.Unitario.AceitaColarTexto = True
        Me.Unitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Unitario.CasasDecimais = 4
        Me.Unitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Unitario.CPObrigatorio = False
        Me.Unitario.CPObrigatorioMsg = Nothing
        Me.Unitario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Unitario.FocusColor = System.Drawing.Color.MistyRose
        Me.Unitario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Unitario.Location = New System.Drawing.Point(556, 38)
        Me.Unitario.MaxLength = 10
        Me.Unitario.Name = "Unitario"
        Me.Unitario.RegraValidação = Nothing
        Me.Unitario.RegraValidaçãoMensagem = Nothing
        Me.Unitario.Size = New System.Drawing.Size(106, 20)
        Me.Unitario.TabIndex = 8
        Me.Unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Unitario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Unitario.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Total
        '
        Me.Total.AceitaColarTexto = True
        Me.Total.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Total.CasasDecimais = 4
        Me.Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Total.CPObrigatorio = False
        Me.Total.CPObrigatorioMsg = Nothing
        Me.Total.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Total.FocusColor = System.Drawing.Color.MistyRose
        Me.Total.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total.Location = New System.Drawing.Point(133, 64)
        Me.Total.MaxLength = 10
        Me.Total.Name = "Total"
        Me.Total.RegraValidação = Nothing
        Me.Total.RegraValidaçãoMensagem = Nothing
        Me.Total.Size = New System.Drawing.Size(106, 20)
        Me.Total.TabIndex = 10
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Total.ValorPadrao = Nothing
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.UnidadeMedida)
        Me.PanelEx1.Controls.Add(Me.btExcluir)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.CodigoMateriaPrima)
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Total)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.DescriçãoMP)
        Me.PanelEx1.Controls.Add(Me.Unitario)
        Me.PanelEx1.Controls.Add(Me.Qtd)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(674, 135)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btExcluir
        '
        Me.btExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExcluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExcluir.Location = New System.Drawing.Point(300, 103)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(86, 26)
        Me.btExcluir.TabIndex = 15
        Me.btExcluir.Text = "Excluir"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(484, 103)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(86, 26)
        Me.btNovo.TabIndex = 14
        Me.btNovo.Text = "Novo"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(392, 103)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(86, 26)
        Me.btSalvar.TabIndex = 13
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(576, 103)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(86, 26)
        Me.btFechar.TabIndex = 16
        Me.btFechar.Text = "Fechar"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(280, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Unidade Medida"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UnidadeMedida
        '
        Me.UnidadeMedida.AceitaColarTexto = True
        Me.UnidadeMedida.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.UnidadeMedida.CasasDecimais = 0
        Me.UnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UnidadeMedida.CPObrigatorio = False
        Me.UnidadeMedida.CPObrigatorioMsg = Nothing
        Me.UnidadeMedida.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.UnidadeMedida.FocusColor = System.Drawing.Color.MistyRose
        Me.UnidadeMedida.FocusColorEnd = System.Drawing.Color.Empty
        Me.UnidadeMedida.Location = New System.Drawing.Point(377, 37)
        Me.UnidadeMedida.MaxLength = 10
        Me.UnidadeMedida.Name = "UnidadeMedida"
        Me.UnidadeMedida.RegraValidação = Nothing
        Me.UnidadeMedida.RegraValidaçãoMensagem = Nothing
        Me.UnidadeMedida.Size = New System.Drawing.Size(50, 20)
        Me.UnidadeMedida.TabIndex = 6
        Me.UnidadeMedida.TabStop = False
        Me.UnidadeMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UnidadeMedida.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.UnidadeMedida.ValorPadrao = Nothing
        '
        'IndustriaSubComposiçãoItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 135)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IndustriaSubComposiçãoItens"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Itens de Sub-Composição"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodigoMateriaPrima As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DescriçãoMP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Unitario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Total As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btExcluir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UnidadeMedida As TexBoxFocusNet.TextBoxFocusNet
End Class
