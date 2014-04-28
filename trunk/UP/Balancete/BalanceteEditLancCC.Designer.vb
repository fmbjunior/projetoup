<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceteEditLancCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BalanceteEditLancCC))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.ContaCCDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFindContaCC = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContaCC = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ValorLanc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IdCaixaBanco = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataLanc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.ContaCCDesc)
        Me.PanelEx1.Controls.Add(Me.btFindContaCC)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.ContaCC)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.ValorLanc)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.IdCaixaBanco)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.DataLanc)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(587, 210)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btSalvar
        '
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalvar.Location = New System.Drawing.Point(326, 175)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(78, 29)
        Me.btSalvar.TabIndex = 12
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNovo.Location = New System.Drawing.Point(410, 175)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(78, 29)
        Me.btNovo.TabIndex = 13
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'ContaCCDesc
        '
        Me.ContaCCDesc.AceitaColarTexto = True
        Me.ContaCCDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ContaCCDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContaCCDesc.CasasDecimais = 2
        Me.ContaCCDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCCDesc.CPObrigatorio = False
        Me.ContaCCDesc.CPObrigatorioMsg = Nothing
        Me.ContaCCDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCCDesc.FlatBorder = True
        Me.ContaCCDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCCDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaCCDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCCDesc.HighlightBorderOnEnter = False
        Me.ContaCCDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCCDesc.Location = New System.Drawing.Point(272, 118)
        Me.ContaCCDesc.MaxLength = 6
        Me.ContaCCDesc.Name = "ContaCCDesc"
        Me.ContaCCDesc.PreencherZeroEsqueda = False
        Me.ContaCCDesc.RegraValidação = Nothing
        Me.ContaCCDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaCCDesc.Size = New System.Drawing.Size(302, 23)
        Me.ContaCCDesc.TabIndex = 11
        Me.ContaCCDesc.TabStop = False
        Me.ContaCCDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCCDesc.ValorPadrao = Nothing
        '
        'btFindContaCC
        '
        Me.btFindContaCC.Image = CType(resources.GetObject("btFindContaCC.Image"), System.Drawing.Image)
        Me.btFindContaCC.Location = New System.Drawing.Point(245, 118)
        Me.btFindContaCC.Name = "btFindContaCC"
        Me.btFindContaCC.Size = New System.Drawing.Size(23, 24)
        Me.btFindContaCC.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Conta CC"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaCC
        '
        Me.ContaCC.AceitaColarTexto = True
        Me.ContaCC.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContaCC.CasasDecimais = 0
        Me.ContaCC.CPObrigatorio = False
        Me.ContaCC.CPObrigatorioMsg = Nothing
        Me.ContaCC.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaCC.FlatBorder = True
        Me.ContaCC.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ContaCC.FocusColor = System.Drawing.Color.Empty
        Me.ContaCC.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCC.GlowColor = System.Drawing.Color.Navy
        Me.ContaCC.HighlightBorderOnEnter = False
        Me.ContaCC.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ContaCC.Location = New System.Drawing.Point(148, 118)
        Me.ContaCC.MaxLength = 6
        Me.ContaCC.Name = "ContaCC"
        Me.ContaCC.PreencherZeroEsqueda = True
        Me.ContaCC.RegraValidação = Nothing
        Me.ContaCC.RegraValidaçãoMensagem = Nothing
        Me.ContaCC.Size = New System.Drawing.Size(94, 23)
        Me.ContaCC.TabIndex = 9
        Me.ContaCC.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCC.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Valor Lançamento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorLanc
        '
        Me.ValorLanc.AceitaColarTexto = True
        Me.ValorLanc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorLanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorLanc.CasasDecimais = 2
        Me.ValorLanc.CPObrigatorio = False
        Me.ValorLanc.CPObrigatorioMsg = Nothing
        Me.ValorLanc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorLanc.FlatBorder = True
        Me.ValorLanc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorLanc.FocusColor = System.Drawing.Color.Empty
        Me.ValorLanc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorLanc.GlowColor = System.Drawing.Color.Navy
        Me.ValorLanc.HighlightBorderOnEnter = False
        Me.ValorLanc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorLanc.Location = New System.Drawing.Point(148, 87)
        Me.ValorLanc.MaxLength = 15
        Me.ValorLanc.Name = "ValorLanc"
        Me.ValorLanc.PreencherZeroEsqueda = False
        Me.ValorLanc.RegraValidação = Nothing
        Me.ValorLanc.RegraValidaçãoMensagem = Nothing
        Me.ValorLanc.Size = New System.Drawing.Size(94, 23)
        Me.ValorLanc.TabIndex = 7
        Me.ValorLanc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.ValorLanc.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(342, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Id Caixa/Banco"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IdCaixaBanco
        '
        Me.IdCaixaBanco.AceitaColarTexto = True
        Me.IdCaixaBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IdCaixaBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdCaixaBanco.CasasDecimais = 0
        Me.IdCaixaBanco.CPObrigatorio = False
        Me.IdCaixaBanco.CPObrigatorioMsg = Nothing
        Me.IdCaixaBanco.Enabled = False
        Me.IdCaixaBanco.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdCaixaBanco.FlatBorder = True
        Me.IdCaixaBanco.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdCaixaBanco.FocusColor = System.Drawing.Color.Empty
        Me.IdCaixaBanco.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdCaixaBanco.GlowColor = System.Drawing.Color.Navy
        Me.IdCaixaBanco.HighlightBorderOnEnter = False
        Me.IdCaixaBanco.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdCaixaBanco.Location = New System.Drawing.Point(478, 27)
        Me.IdCaixaBanco.MaxLength = 15
        Me.IdCaixaBanco.Name = "IdCaixaBanco"
        Me.IdCaixaBanco.PreencherZeroEsqueda = False
        Me.IdCaixaBanco.RegraValidação = Nothing
        Me.IdCaixaBanco.RegraValidaçãoMensagem = Nothing
        Me.IdCaixaBanco.Size = New System.Drawing.Size(94, 23)
        Me.IdCaixaBanco.TabIndex = 3
        Me.IdCaixaBanco.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdCaixaBanco.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data Lançamento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLanc
        '
        Me.DataLanc.AceitaColarTexto = True
        Me.DataLanc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataLanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataLanc.CasasDecimais = 0
        Me.DataLanc.CPObrigatorio = False
        Me.DataLanc.CPObrigatorioMsg = Nothing
        Me.DataLanc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLanc.FlatBorder = True
        Me.DataLanc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataLanc.FocusColor = System.Drawing.Color.Empty
        Me.DataLanc.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLanc.GlowColor = System.Drawing.Color.Navy
        Me.DataLanc.HighlightBorderOnEnter = False
        Me.DataLanc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataLanc.Location = New System.Drawing.Point(148, 55)
        Me.DataLanc.MaxLength = 10
        Me.DataLanc.Name = "DataLanc"
        Me.DataLanc.PreencherZeroEsqueda = False
        Me.DataLanc.RegraValidação = Nothing
        Me.DataLanc.RegraValidaçãoMensagem = Nothing
        Me.DataLanc.Size = New System.Drawing.Size(94, 23)
        Me.DataLanc.TabIndex = 5
        Me.DataLanc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLanc.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id.CasasDecimais = 0
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.Enabled = False
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = True
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.GlowColor = System.Drawing.Color.Navy
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(148, 24)
        Me.Id.MaxLength = 15
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(94, 23)
        Me.Id.TabIndex = 1
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.Id.ValorPadrao = Nothing
        '
        'btFechar
        '
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.Location = New System.Drawing.Point(494, 175)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(78, 29)
        Me.btFechar.TabIndex = 14
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'BalanceteEditLancCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BalanceteEditLancCC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Edd Centro Custo"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataLanc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IdCaixaBanco As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ValorLanc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFindContaCC As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ContaCC As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaCCDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents btNovo As System.Windows.Forms.Button
End Class
