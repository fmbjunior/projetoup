<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoDecimoTerceiroGerador
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
        Me.AnoAtual = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label8 = New System.Windows.Forms.Label
        Me.Fechar = New DevComponents.DotNetBar.ButtonX
        Me.Gerar = New DevComponents.DotNetBar.ButtonX
        Me.CompetenciaBase = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.MyBarra = New System.Windows.Forms.ProgressBar
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Label2 = New System.Windows.Forms.Label
        Me.ContaDecimoTerceiro = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.ContaInss = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnoAtual
        '
        Me.AnoAtual.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AnoAtual.CasasDecimais = 0
        Me.AnoAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AnoAtual.CPObrigatorio = False
        Me.AnoAtual.CPObrigatorioMsg = Nothing
        Me.AnoAtual.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AnoAtual.FocusColor = System.Drawing.Color.Empty
        Me.AnoAtual.FocusColorEnd = System.Drawing.Color.Empty
        Me.AnoAtual.Location = New System.Drawing.Point(12, 35)
        Me.AnoAtual.MaxLength = 30
        Me.AnoAtual.Name = "AnoAtual"
        Me.AnoAtual.RegraValidação = Nothing
        Me.AnoAtual.RegraValidaçãoMensagem = Nothing
        Me.AnoAtual.Size = New System.Drawing.Size(145, 20)
        Me.AnoAtual.TabIndex = 2
        Me.AnoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnoAtual.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AnoAtual.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Informe o ano a Gerar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(363, 181)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(86, 29)
        Me.Fechar.TabIndex = 10
        Me.Fechar.Text = "Fechar"
        '
        'Gerar
        '
        Me.Gerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Gerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Gerar.Location = New System.Drawing.Point(225, 181)
        Me.Gerar.Name = "Gerar"
        Me.Gerar.Size = New System.Drawing.Size(132, 29)
        Me.Gerar.TabIndex = 9
        Me.Gerar.Text = "Gerar Décimo Terceiro"
        '
        'CompetenciaBase
        '
        Me.CompetenciaBase.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CompetenciaBase.CasasDecimais = 0
        Me.CompetenciaBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompetenciaBase.CPObrigatorio = False
        Me.CompetenciaBase.CPObrigatorioMsg = Nothing
        Me.CompetenciaBase.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CompetenciaBase.FocusColor = System.Drawing.Color.Empty
        Me.CompetenciaBase.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompetenciaBase.Location = New System.Drawing.Point(169, 35)
        Me.CompetenciaBase.MaxLength = 7
        Me.CompetenciaBase.Name = "CompetenciaBase"
        Me.CompetenciaBase.RegraValidação = Nothing
        Me.CompetenciaBase.RegraValidaçãoMensagem = Nothing
        Me.CompetenciaBase.Size = New System.Drawing.Size(142, 20)
        Me.CompetenciaBase.TabIndex = 3
        Me.CompetenciaBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CompetenciaBase.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.CompetenciaBase.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(169, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Competência Base"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MyBarra
        '
        Me.MyBarra.BackColor = System.Drawing.Color.DimGray
        Me.MyBarra.ForeColor = System.Drawing.Color.DarkOrange
        Me.MyBarra.Location = New System.Drawing.Point(12, 129)
        Me.MyBarra.Name = "MyBarra"
        Me.MyBarra.Size = New System.Drawing.Size(437, 26)
        Me.MyBarra.TabIndex = 8
        Me.MyBarra.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.ContaInss)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.ContaDecimoTerceiro)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.MyBarra)
        Me.Fundo.Controls.Add(Me.AnoAtual)
        Me.Fundo.Controls.Add(Me.CompetenciaBase)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Gerar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(460, 217)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Conta p/ Décimo Terceiro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaDecimoTerceiro
        '
        Me.ContaDecimoTerceiro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaDecimoTerceiro.CasasDecimais = 0
        Me.ContaDecimoTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaDecimoTerceiro.CPObrigatorio = False
        Me.ContaDecimoTerceiro.CPObrigatorioMsg = Nothing
        Me.ContaDecimoTerceiro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaDecimoTerceiro.FocusColor = System.Drawing.Color.Empty
        Me.ContaDecimoTerceiro.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaDecimoTerceiro.Location = New System.Drawing.Point(12, 85)
        Me.ContaDecimoTerceiro.MaxLength = 30
        Me.ContaDecimoTerceiro.Name = "ContaDecimoTerceiro"
        Me.ContaDecimoTerceiro.RegraValidação = Nothing
        Me.ContaDecimoTerceiro.RegraValidaçãoMensagem = Nothing
        Me.ContaDecimoTerceiro.Size = New System.Drawing.Size(145, 20)
        Me.ContaDecimoTerceiro.TabIndex = 6
        Me.ContaDecimoTerceiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ContaDecimoTerceiro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaDecimoTerceiro.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(166, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Conta p/ INSS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaInss
        '
        Me.ContaInss.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaInss.CasasDecimais = 0
        Me.ContaInss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaInss.CPObrigatorio = False
        Me.ContaInss.CPObrigatorioMsg = Nothing
        Me.ContaInss.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaInss.FocusColor = System.Drawing.Color.Empty
        Me.ContaInss.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaInss.Location = New System.Drawing.Point(166, 85)
        Me.ContaInss.MaxLength = 30
        Me.ContaInss.Name = "ContaInss"
        Me.ContaInss.RegraValidação = Nothing
        Me.ContaInss.RegraValidaçãoMensagem = Nothing
        Me.ContaInss.Size = New System.Drawing.Size(145, 20)
        Me.ContaInss.TabIndex = 7
        Me.ContaInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ContaInss.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaInss.ValorPadrao = Nothing
        '
        'FolhaPgtoDecimoTerceiroGerador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoDecimoTerceiroGerador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerador de décimo terceiro"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AnoAtual As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Gerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CompetenciaBase As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MyBarra As System.Windows.Forms.ProgressBar
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContaDecimoTerceiro As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContaInss As TexBoxFocusNet.TextBoxFocusNet
End Class
