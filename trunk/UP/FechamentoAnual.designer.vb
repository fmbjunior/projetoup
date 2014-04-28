<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FechamentoAnual
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.MyBarra = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.Label5 = New System.Windows.Forms.Label
        Me.DiaInicalNovoAno = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.DiaFinalAno = New TexBoxFocusNet.TextBoxFocusNet
        Me.ContaSaldoDreDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.ContaSaldoDre = New TexBoxFocusNet.TextBoxFocusNet
        Me.EmpresaDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Empresa = New TexBoxFocusNet.TextBoxFocusNet
        Me.btFechamentoAnual = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.AnoTransferir = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.AnoFechar = New TexBoxFocusNet.TextBoxFocusNet
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.MyBarra)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.DiaInicalNovoAno)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.DiaFinalAno)
        Me.Fundo.Controls.Add(Me.ContaSaldoDreDesc)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.ContaSaldoDre)
        Me.Fundo.Controls.Add(Me.EmpresaDesc)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Empresa)
        Me.Fundo.Controls.Add(Me.btFechamentoAnual)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.AnoTransferir)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.AnoFechar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(527, 301)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'MyBarra
        '
        Me.MyBarra.Location = New System.Drawing.Point(12, 214)
        Me.MyBarra.Name = "MyBarra"
        Me.MyBarra.Size = New System.Drawing.Size(504, 28)
        Me.MyBarra.TabIndex = 18
        Me.MyBarra.TextVisible = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(152, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Inf. o dia Inicial do Novo Ano"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiaInicalNovoAno
        '
        Me.DiaInicalNovoAno.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DiaInicalNovoAno.CasasDecimais = 0
        Me.DiaInicalNovoAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiaInicalNovoAno.CPObrigatorio = False
        Me.DiaInicalNovoAno.CPObrigatorioMsg = Nothing
        Me.DiaInicalNovoAno.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiaInicalNovoAno.FocusColor = System.Drawing.Color.Empty
        Me.DiaInicalNovoAno.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiaInicalNovoAno.Location = New System.Drawing.Point(152, 176)
        Me.DiaInicalNovoAno.MaxLength = 10
        Me.DiaInicalNovoAno.Name = "DiaInicalNovoAno"
        Me.DiaInicalNovoAno.RegraValidação = Nothing
        Me.DiaInicalNovoAno.RegraValidaçãoMensagem = Nothing
        Me.DiaInicalNovoAno.Size = New System.Drawing.Size(131, 20)
        Me.DiaInicalNovoAno.TabIndex = 13
        Me.DiaInicalNovoAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DiaInicalNovoAno.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DiaInicalNovoAno.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Inf. o dia Final do Ano"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiaFinalAno
        '
        Me.DiaFinalAno.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DiaFinalAno.CasasDecimais = 0
        Me.DiaFinalAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiaFinalAno.CPObrigatorio = False
        Me.DiaFinalAno.CPObrigatorioMsg = Nothing
        Me.DiaFinalAno.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiaFinalAno.FocusColor = System.Drawing.Color.Empty
        Me.DiaFinalAno.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiaFinalAno.Location = New System.Drawing.Point(12, 176)
        Me.DiaFinalAno.MaxLength = 10
        Me.DiaFinalAno.Name = "DiaFinalAno"
        Me.DiaFinalAno.RegraValidação = Nothing
        Me.DiaFinalAno.RegraValidaçãoMensagem = Nothing
        Me.DiaFinalAno.Size = New System.Drawing.Size(134, 20)
        Me.DiaFinalAno.TabIndex = 11
        Me.DiaFinalAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DiaFinalAno.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DiaFinalAno.ValorPadrao = Nothing
        '
        'ContaSaldoDreDesc
        '
        Me.ContaSaldoDreDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaSaldoDreDesc.CasasDecimais = 0
        Me.ContaSaldoDreDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaSaldoDreDesc.CPObrigatorio = False
        Me.ContaSaldoDreDesc.CPObrigatorioMsg = Nothing
        Me.ContaSaldoDreDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaSaldoDreDesc.FocusColor = System.Drawing.Color.Empty
        Me.ContaSaldoDreDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaSaldoDreDesc.Location = New System.Drawing.Point(152, 130)
        Me.ContaSaldoDreDesc.MaxLength = 10
        Me.ContaSaldoDreDesc.Name = "ContaSaldoDreDesc"
        Me.ContaSaldoDreDesc.RegraValidação = Nothing
        Me.ContaSaldoDreDesc.RegraValidaçãoMensagem = Nothing
        Me.ContaSaldoDreDesc.Size = New System.Drawing.Size(361, 20)
        Me.ContaSaldoDreDesc.TabIndex = 9
        Me.ContaSaldoDreDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaSaldoDreDesc.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Inf. a Conta de Transf. de Saldo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaSaldoDre
        '
        Me.ContaSaldoDre.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ContaSaldoDre.CasasDecimais = 0
        Me.ContaSaldoDre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaSaldoDre.CPObrigatorio = False
        Me.ContaSaldoDre.CPObrigatorioMsg = Nothing
        Me.ContaSaldoDre.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ContaSaldoDre.FocusColor = System.Drawing.Color.Empty
        Me.ContaSaldoDre.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaSaldoDre.Location = New System.Drawing.Point(12, 130)
        Me.ContaSaldoDre.MaxLength = 14
        Me.ContaSaldoDre.Name = "ContaSaldoDre"
        Me.ContaSaldoDre.RegraValidação = Nothing
        Me.ContaSaldoDre.RegraValidaçãoMensagem = Nothing
        Me.ContaSaldoDre.Size = New System.Drawing.Size(134, 20)
        Me.ContaSaldoDre.TabIndex = 8
        Me.ContaSaldoDre.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaSaldoDre.ValorPadrao = Nothing
        '
        'EmpresaDesc
        '
        Me.EmpresaDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EmpresaDesc.CasasDecimais = 0
        Me.EmpresaDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaDesc.CPObrigatorio = False
        Me.EmpresaDesc.CPObrigatorioMsg = Nothing
        Me.EmpresaDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EmpresaDesc.FocusColor = System.Drawing.Color.Empty
        Me.EmpresaDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.EmpresaDesc.Location = New System.Drawing.Point(101, 36)
        Me.EmpresaDesc.MaxLength = 10
        Me.EmpresaDesc.Name = "EmpresaDesc"
        Me.EmpresaDesc.RegraValidação = Nothing
        Me.EmpresaDesc.RegraValidaçãoMensagem = Nothing
        Me.EmpresaDesc.Size = New System.Drawing.Size(415, 20)
        Me.EmpresaDesc.TabIndex = 2
        Me.EmpresaDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EmpresaDesc.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Empresa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Empresa
        '
        Me.Empresa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Empresa.CasasDecimais = 0
        Me.Empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Empresa.CPObrigatorio = False
        Me.Empresa.CPObrigatorioMsg = Nothing
        Me.Empresa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Empresa.FocusColor = System.Drawing.Color.Empty
        Me.Empresa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Empresa.Location = New System.Drawing.Point(15, 36)
        Me.Empresa.MaxLength = 10
        Me.Empresa.Name = "Empresa"
        Me.Empresa.RegraValidação = Nothing
        Me.Empresa.RegraValidaçãoMensagem = Nothing
        Me.Empresa.Size = New System.Drawing.Size(80, 20)
        Me.Empresa.TabIndex = 1
        Me.Empresa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Empresa.ValorPadrao = Nothing
        '
        'btFechamentoAnual
        '
        Me.btFechamentoAnual.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechamentoAnual.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechamentoAnual.Location = New System.Drawing.Point(316, 258)
        Me.btFechamentoAnual.Name = "btFechamentoAnual"
        Me.btFechamentoAnual.Size = New System.Drawing.Size(97, 33)
        Me.btFechamentoAnual.TabIndex = 14
        Me.btFechamentoAnual.Text = "Fechar o Ano"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(149, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Inf. o Ano a Tranf. Saldos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnoTransferir
        '
        Me.AnoTransferir.AcceptsTab = True
        Me.AnoTransferir.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AnoTransferir.CasasDecimais = 0
        Me.AnoTransferir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AnoTransferir.CPObrigatorio = False
        Me.AnoTransferir.CPObrigatorioMsg = Nothing
        Me.AnoTransferir.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AnoTransferir.FocusColor = System.Drawing.Color.Empty
        Me.AnoTransferir.FocusColorEnd = System.Drawing.Color.Empty
        Me.AnoTransferir.Location = New System.Drawing.Point(149, 84)
        Me.AnoTransferir.MaxLength = 10
        Me.AnoTransferir.Name = "AnoTransferir"
        Me.AnoTransferir.RegraValidação = Nothing
        Me.AnoTransferir.RegraValidaçãoMensagem = Nothing
        Me.AnoTransferir.Size = New System.Drawing.Size(131, 20)
        Me.AnoTransferir.TabIndex = 6
        Me.AnoTransferir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnoTransferir.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AnoTransferir.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Inf. o Ano a Fechar"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnoFechar
        '
        Me.AnoFechar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AnoFechar.CasasDecimais = 0
        Me.AnoFechar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AnoFechar.CPObrigatorio = False
        Me.AnoFechar.CPObrigatorioMsg = Nothing
        Me.AnoFechar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AnoFechar.FocusColor = System.Drawing.Color.Empty
        Me.AnoFechar.FocusColorEnd = System.Drawing.Color.Empty
        Me.AnoFechar.Location = New System.Drawing.Point(12, 84)
        Me.AnoFechar.MaxLength = 10
        Me.AnoFechar.Name = "AnoFechar"
        Me.AnoFechar.RegraValidação = Nothing
        Me.AnoFechar.RegraValidaçãoMensagem = Nothing
        Me.AnoFechar.Size = New System.Drawing.Size(131, 20)
        Me.AnoFechar.TabIndex = 4
        Me.AnoFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnoFechar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AnoFechar.ValorPadrao = Nothing
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(419, 258)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(97, 33)
        Me.btFechar.TabIndex = 15
        Me.btFechar.Text = "Fechar"
        '
        'FechamentoAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FechamentoAnual"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fechamento Anual"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AnoTransferir As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AnoFechar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechamentoAnual As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Empresa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EmpresaDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ContaSaldoDreDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContaSaldoDre As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DiaFinalAno As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DiaInicalNovoAno As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyBarra As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
