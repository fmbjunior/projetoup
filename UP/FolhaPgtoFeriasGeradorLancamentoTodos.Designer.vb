<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoFeriasGeradorLancamentoTodos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CaixaConta = New TexBoxFocusNet.TextBoxFocusNet
        Me.CaixaDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Caixa = New TexBoxFocusNet.TextBoxFocusNet
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BancoCartaoConta = New TexBoxFocusNet.TextBoxFocusNet
        Me.BancoCartaoDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.BancoCartao = New TexBoxFocusNet.TextBoxFocusNet
        Me.DescPagamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataLan�amento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.GerarLanc = New System.Windows.Forms.Button
        Me.Fechar = New System.Windows.Forms.Button
        Me.MyBarra = New System.Windows.Forms.ProgressBar
        Me.Msg = New System.Windows.Forms.Label
        Me.Fundo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.GroupBox1)
        Me.Fundo.Controls.Add(Me.GroupBox3)
        Me.Fundo.Controls.Add(Me.DescPagamento)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.DataLan�amento)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.GerarLanc)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.MyBarra)
        Me.Fundo.Controls.Add(Me.Msg)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(607, 285)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.MediumSeaGreen
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CaixaConta)
        Me.GroupBox1.Controls.Add(Me.CaixaDesc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Caixa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gerar no Caixa"
        '
        'CaixaConta
        '
        Me.CaixaConta.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CaixaConta.CasasDecimais = 0
        Me.CaixaConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CaixaConta.CPObrigatorio = False
        Me.CaixaConta.CPObrigatorioMsg = Nothing
        Me.CaixaConta.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.CaixaConta.FocusColor = System.Drawing.Color.Empty
        Me.CaixaConta.FocusColorEnd = System.Drawing.Color.Empty
        Me.CaixaConta.Location = New System.Drawing.Point(139, 20)
        Me.CaixaConta.MaxLength = 7
        Me.CaixaConta.Name = "CaixaConta"
        Me.CaixaConta.RegraValida��o = Nothing
        Me.CaixaConta.RegraValida��oMensagem = Nothing
        Me.CaixaConta.Size = New System.Drawing.Size(127, 20)
        Me.CaixaConta.TabIndex = 2
        Me.CaixaConta.TabStop = False
        Me.CaixaConta.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CaixaConta.ValorPadrao = Nothing
        '
        'CaixaDesc
        '
        Me.CaixaDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CaixaDesc.CasasDecimais = 0
        Me.CaixaDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CaixaDesc.CPObrigatorio = False
        Me.CaixaDesc.CPObrigatorioMsg = Nothing
        Me.CaixaDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.CaixaDesc.FocusColor = System.Drawing.Color.Empty
        Me.CaixaDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.CaixaDesc.Location = New System.Drawing.Point(73, 45)
        Me.CaixaDesc.MaxLength = 7
        Me.CaixaDesc.Name = "CaixaDesc"
        Me.CaixaDesc.RegraValida��o = Nothing
        Me.CaixaDesc.RegraValida��oMensagem = Nothing
        Me.CaixaDesc.Size = New System.Drawing.Size(224, 20)
        Me.CaixaDesc.TabIndex = 3
        Me.CaixaDesc.TabStop = False
        Me.CaixaDesc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CaixaDesc.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Caixa"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Caixa
        '
        Me.Caixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Caixa.CasasDecimais = 0
        Me.Caixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Caixa.CPObrigatorio = False
        Me.Caixa.CPObrigatorioMsg = Nothing
        Me.Caixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.Caixa.FocusColor = System.Drawing.Color.Empty
        Me.Caixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Caixa.Location = New System.Drawing.Point(73, 19)
        Me.Caixa.MaxLength = 7
        Me.Caixa.Name = "Caixa"
        Me.Caixa.RegraValida��o = Nothing
        Me.Caixa.RegraValida��oMensagem = Nothing
        Me.Caixa.Size = New System.Drawing.Size(60, 20)
        Me.Caixa.TabIndex = 1
        Me.Caixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Caixa.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Caixa.ValorPadrao = Nothing
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BancoCartaoConta)
        Me.GroupBox3.Controls.Add(Me.BancoCartaoDesc)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.BancoCartao)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 70)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gerar com Cart�o"
        '
        'BancoCartaoConta
        '
        Me.BancoCartaoConta.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.BancoCartaoConta.CasasDecimais = 0
        Me.BancoCartaoConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoCartaoConta.CPObrigatorio = False
        Me.BancoCartaoConta.CPObrigatorioMsg = Nothing
        Me.BancoCartaoConta.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.BancoCartaoConta.FocusColor = System.Drawing.Color.Empty
        Me.BancoCartaoConta.FocusColorEnd = System.Drawing.Color.Empty
        Me.BancoCartaoConta.Location = New System.Drawing.Point(139, 19)
        Me.BancoCartaoConta.MaxLength = 7
        Me.BancoCartaoConta.Name = "BancoCartaoConta"
        Me.BancoCartaoConta.RegraValida��o = Nothing
        Me.BancoCartaoConta.RegraValida��oMensagem = Nothing
        Me.BancoCartaoConta.Size = New System.Drawing.Size(127, 20)
        Me.BancoCartaoConta.TabIndex = 2
        Me.BancoCartaoConta.TabStop = False
        Me.BancoCartaoConta.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BancoCartaoConta.ValorPadrao = Nothing
        '
        'BancoCartaoDesc
        '
        Me.BancoCartaoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.BancoCartaoDesc.CasasDecimais = 0
        Me.BancoCartaoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoCartaoDesc.CPObrigatorio = False
        Me.BancoCartaoDesc.CPObrigatorioMsg = Nothing
        Me.BancoCartaoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.BancoCartaoDesc.FocusColor = System.Drawing.Color.Empty
        Me.BancoCartaoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.BancoCartaoDesc.Location = New System.Drawing.Point(73, 45)
        Me.BancoCartaoDesc.MaxLength = 7
        Me.BancoCartaoDesc.Name = "BancoCartaoDesc"
        Me.BancoCartaoDesc.RegraValida��o = Nothing
        Me.BancoCartaoDesc.RegraValida��oMensagem = Nothing
        Me.BancoCartaoDesc.Size = New System.Drawing.Size(224, 20)
        Me.BancoCartaoDesc.TabIndex = 3
        Me.BancoCartaoDesc.TabStop = False
        Me.BancoCartaoDesc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BancoCartaoDesc.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Banco"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BancoCartao
        '
        Me.BancoCartao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.BancoCartao.CasasDecimais = 0
        Me.BancoCartao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoCartao.CPObrigatorio = False
        Me.BancoCartao.CPObrigatorioMsg = Nothing
        Me.BancoCartao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.BancoCartao.FocusColor = System.Drawing.Color.Empty
        Me.BancoCartao.FocusColorEnd = System.Drawing.Color.Empty
        Me.BancoCartao.Location = New System.Drawing.Point(73, 19)
        Me.BancoCartao.MaxLength = 7
        Me.BancoCartao.Name = "BancoCartao"
        Me.BancoCartao.RegraValida��o = Nothing
        Me.BancoCartao.RegraValida��oMensagem = Nothing
        Me.BancoCartao.Size = New System.Drawing.Size(60, 20)
        Me.BancoCartao.TabIndex = 1
        Me.BancoCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BancoCartao.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BancoCartao.ValorPadrao = Nothing
        '
        'DescPagamento
        '
        Me.DescPagamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.DescPagamento.CasasDecimais = 0
        Me.DescPagamento.CPObrigatorio = False
        Me.DescPagamento.CPObrigatorioMsg = Nothing
        Me.DescPagamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.DescPagamento.FocusColor = System.Drawing.Color.Empty
        Me.DescPagamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescPagamento.Location = New System.Drawing.Point(333, 88)
        Me.DescPagamento.MaxLength = 40
        Me.DescPagamento.Name = "DescPagamento"
        Me.DescPagamento.RegraValida��o = Nothing
        Me.DescPagamento.RegraValida��oMensagem = Nothing
        Me.DescPagamento.Size = New System.Drawing.Size(256, 20)
        Me.DescPagamento.TabIndex = 11
        Me.DescPagamento.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescPagamento.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(330, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Descri��o do Pagamento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLan�amento
        '
        Me.DataLan�amento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.DataLan�amento.CasasDecimais = 0
        Me.DataLan�amento.CPObrigatorio = False
        Me.DataLan�amento.CPObrigatorioMsg = Nothing
        Me.DataLan�amento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.DataLan�amento.FocusColor = System.Drawing.Color.Empty
        Me.DataLan�amento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLan�amento.Location = New System.Drawing.Point(459, 26)
        Me.DataLan�amento.MaxLength = 10
        Me.DataLan�amento.Name = "DataLan�amento"
        Me.DataLan�amento.RegraValida��o = Nothing
        Me.DataLan�amento.RegraValida��oMensagem = Nothing
        Me.DataLan�amento.Size = New System.Drawing.Size(97, 20)
        Me.DataLan�amento.TabIndex = 9
        Me.DataLan�amento.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLan�amento.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(330, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Data Lan�amento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GerarLanc
        '
        Me.GerarLanc.Location = New System.Drawing.Point(380, 243)
        Me.GerarLanc.Name = "GerarLanc"
        Me.GerarLanc.Size = New System.Drawing.Size(123, 29)
        Me.GerarLanc.TabIndex = 14
        Me.GerarLanc.Text = "Gerar Lan�amentos"
        Me.GerarLanc.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.Location = New System.Drawing.Point(509, 243)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(82, 29)
        Me.Fechar.TabIndex = 15
        Me.Fechar.Text = "Fechar"
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'MyBarra
        '
        Me.MyBarra.BackColor = System.Drawing.Color.DimGray
        Me.MyBarra.ForeColor = System.Drawing.Color.DarkOrange
        Me.MyBarra.Location = New System.Drawing.Point(12, 181)
        Me.MyBarra.Name = "MyBarra"
        Me.MyBarra.Size = New System.Drawing.Size(577, 26)
        Me.MyBarra.TabIndex = 12
        Me.MyBarra.Visible = False
        '
        'Msg
        '
        Me.Msg.BackColor = System.Drawing.Color.Transparent
        Me.Msg.ForeColor = System.Drawing.Color.Black
        Me.Msg.Location = New System.Drawing.Point(12, 210)
        Me.Msg.Name = "Msg"
        Me.Msg.Size = New System.Drawing.Size(577, 20)
        Me.Msg.TabIndex = 13
        Me.Msg.Text = "Msg"
        Me.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Msg.Visible = False
        '
        'FolhaPgtoFeriasGeradorLancamentoTodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FolhaPgtoFeriasGeradorLancamentoTodos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan�ar  pgto f�rias para Todos"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CaixaConta As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CaixaDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Caixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BancoCartaoConta As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BancoCartaoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BancoCartao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DescPagamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataLan�amento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GerarLanc As System.Windows.Forms.Button
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents MyBarra As System.Windows.Forms.ProgressBar
    Friend WithEvents Msg As System.Windows.Forms.Label
End Class
