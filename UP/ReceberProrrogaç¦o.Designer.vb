<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceberProrrogação
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.ValorDocumento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.Vencimento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataProrrogação = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.MotivoProrrogação = New TexBoxFocusNet.TextBoxFocusNet
        Me.Prorrogada = New System.Windows.Forms.CheckBox
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.QuemProrrogou = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.Fundo1 = New DevComponents.DotNetBar.PanelEx
        Me.Fundo.SuspendLayout()
        Me.Fundo1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(23, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 19)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Valor Doc."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AceitaColarTexto = True
        Me.ValorDocumento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorDocumento.CasasDecimais = 2
        Me.ValorDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorDocumento.CPObrigatorio = False
        Me.ValorDocumento.CPObrigatorioMsg = Nothing
        Me.ValorDocumento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorDocumento.FocusColor = System.Drawing.Color.Empty
        Me.ValorDocumento.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ValorDocumento.Location = New System.Drawing.Point(139, 41)
        Me.ValorDocumento.MaxLength = 10
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.PreencherZeroEsqueda = False
        Me.ValorDocumento.RegraValidação = Nothing
        Me.ValorDocumento.RegraValidaçãoMensagem = Nothing
        Me.ValorDocumento.Size = New System.Drawing.Size(116, 23)
        Me.ValorDocumento.TabIndex = 5
        Me.ValorDocumento.TabStop = False
        Me.ValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorDocumento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorDocumento.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(270, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Vencimento OR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vencimento
        '
        Me.Vencimento.AceitaColarTexto = True
        Me.Vencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Vencimento.CasasDecimais = 0
        Me.Vencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vencimento.CPObrigatorio = False
        Me.Vencimento.CPObrigatorioMsg = Nothing
        Me.Vencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vencimento.FocusColor = System.Drawing.Color.Empty
        Me.Vencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vencimento.Location = New System.Drawing.Point(389, 12)
        Me.Vencimento.MaxLength = 10
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PreencherZeroEsqueda = False
        Me.Vencimento.RegraValidação = Nothing
        Me.Vencimento.RegraValidaçãoMensagem = Nothing
        Me.Vencimento.Size = New System.Drawing.Size(116, 23)
        Me.Vencimento.TabIndex = 3
        Me.Vencimento.TabStop = False
        Me.Vencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Vencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Vencimento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(20, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Documento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Documento
        '
        Me.Documento.AceitaColarTexto = True
        Me.Documento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Documento.CasasDecimais = 0
        Me.Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Documento.CPObrigatorio = False
        Me.Documento.CPObrigatorioMsg = Nothing
        Me.Documento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Documento.FocusColor = System.Drawing.Color.Empty
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.Location = New System.Drawing.Point(139, 12)
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(116, 23)
        Me.Documento.TabIndex = 1
        Me.Documento.TabStop = False
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dt. Prorrogação"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataProrrogação
        '
        Me.DataProrrogação.AceitaColarTexto = True
        Me.DataProrrogação.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataProrrogação.CasasDecimais = 0
        Me.DataProrrogação.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataProrrogação.CPObrigatorio = False
        Me.DataProrrogação.CPObrigatorioMsg = Nothing
        Me.DataProrrogação.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataProrrogação.FocusColor = System.Drawing.Color.Empty
        Me.DataProrrogação.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataProrrogação.Location = New System.Drawing.Point(132, 38)
        Me.DataProrrogação.MaxLength = 10
        Me.DataProrrogação.Name = "DataProrrogação"
        Me.DataProrrogação.PreencherZeroEsqueda = False
        Me.DataProrrogação.RegraValidação = Nothing
        Me.DataProrrogação.RegraValidaçãoMensagem = Nothing
        Me.DataProrrogação.Size = New System.Drawing.Size(116, 23)
        Me.DataProrrogação.TabIndex = 9
        Me.DataProrrogação.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataProrrogação.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Motivo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MotivoProrrogação
        '
        Me.MotivoProrrogação.AceitaColarTexto = True
        Me.MotivoProrrogação.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.MotivoProrrogação.CasasDecimais = 0
        Me.MotivoProrrogação.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MotivoProrrogação.CPObrigatorio = False
        Me.MotivoProrrogação.CPObrigatorioMsg = Nothing
        Me.MotivoProrrogação.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.MotivoProrrogação.FocusColor = System.Drawing.Color.Empty
        Me.MotivoProrrogação.FocusColorEnd = System.Drawing.Color.Empty
        Me.MotivoProrrogação.Location = New System.Drawing.Point(132, 67)
        Me.MotivoProrrogação.MaxLength = 100
        Me.MotivoProrrogação.Name = "MotivoProrrogação"
        Me.MotivoProrrogação.PreencherZeroEsqueda = False
        Me.MotivoProrrogação.RegraValidação = Nothing
        Me.MotivoProrrogação.RegraValidaçãoMensagem = Nothing
        Me.MotivoProrrogação.Size = New System.Drawing.Size(366, 23)
        Me.MotivoProrrogação.TabIndex = 11
        Me.MotivoProrrogação.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.MotivoProrrogação.ValorPadrao = Nothing
        '
        'Prorrogada
        '
        Me.Prorrogada.AutoSize = True
        Me.Prorrogada.Location = New System.Drawing.Point(132, 13)
        Me.Prorrogada.Name = "Prorrogada"
        Me.Prorrogada.Size = New System.Drawing.Size(76, 19)
        Me.Prorrogada.TabIndex = 7
        Me.Prorrogada.Text = "Prorrogar"
        Me.Prorrogada.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(389, 41)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(116, 23)
        Me.Id.TabIndex = 14
        Me.Id.TabStop = False
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(13, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Quem Prorrogou"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QuemProrrogou
        '
        Me.QuemProrrogou.AceitaColarTexto = True
        Me.QuemProrrogou.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.QuemProrrogou.CasasDecimais = 0
        Me.QuemProrrogou.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.QuemProrrogou.CPObrigatorio = False
        Me.QuemProrrogou.CPObrigatorioMsg = Nothing
        Me.QuemProrrogou.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.QuemProrrogou.FocusColor = System.Drawing.Color.Empty
        Me.QuemProrrogou.FocusColorEnd = System.Drawing.Color.Empty
        Me.QuemProrrogou.Location = New System.Drawing.Point(132, 96)
        Me.QuemProrrogou.MaxLength = 10
        Me.QuemProrrogou.Name = "QuemProrrogou"
        Me.QuemProrrogou.PreencherZeroEsqueda = False
        Me.QuemProrrogou.RegraValidação = Nothing
        Me.QuemProrrogou.RegraValidaçãoMensagem = Nothing
        Me.QuemProrrogou.Size = New System.Drawing.Size(116, 23)
        Me.QuemProrrogou.TabIndex = 16
        Me.QuemProrrogou.TabStop = False
        Me.QuemProrrogou.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.QuemProrrogou.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Fundo1)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Documento)
        Me.Fundo.Controls.Add(Me.Vencimento)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.ValorDocumento)
        Me.Fundo.Controls.Add(Me.Label17)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(529, 262)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 17
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(321, 218)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(111, 32)
        Me.btSalvar.TabIndex = 19
        Me.btSalvar.Text = "Salvar Prorrogação"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(438, 218)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(79, 32)
        Me.btFechar.TabIndex = 18
        Me.btFechar.Text = "Fechar"
        '
        'Fundo1
        '
        Me.Fundo1.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo1.Controls.Add(Me.DataProrrogação)
        Me.Fundo1.Controls.Add(Me.Label1)
        Me.Fundo1.Controls.Add(Me.Label5)
        Me.Fundo1.Controls.Add(Me.MotivoProrrogação)
        Me.Fundo1.Controls.Add(Me.Label3)
        Me.Fundo1.Controls.Add(Me.QuemProrrogou)
        Me.Fundo1.Controls.Add(Me.Prorrogada)
        Me.Fundo1.Location = New System.Drawing.Point(7, 70)
        Me.Fundo1.Name = "Fundo1"
        Me.Fundo1.Size = New System.Drawing.Size(510, 133)
        Me.Fundo1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Fundo1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo1.Style.GradientAngle = 90
        Me.Fundo1.TabIndex = 17
        '
        'ReceberProrrogação
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReceberProrrogação"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prorrogação de Contas a Receber"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.Fundo1.ResumeLayout(False)
        Me.Fundo1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ValorDocumento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Vencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataProrrogação As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MotivoProrrogação As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Prorrogada As System.Windows.Forms.CheckBox
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents QuemProrrogou As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Fundo1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
End Class
