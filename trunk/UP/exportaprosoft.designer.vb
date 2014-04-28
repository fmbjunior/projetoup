<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportaProSoft
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportaProSoft))
        Me.A1 = New System.Windows.Forms.RadioButton
        Me.Opc = New System.Windows.Forms.GroupBox
        Me.A7 = New System.Windows.Forms.RadioButton
        Me.A6 = New System.Windows.Forms.RadioButton
        Me.A5 = New System.Windows.Forms.RadioButton
        Me.A4 = New System.Windows.Forms.RadioButton
        Me.A3 = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Local = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.EmpProSoft = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.EmpFocus = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.NomeArquivo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet
        Me.MyBarra = New System.Windows.Forms.ProgressBar
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.btGerar = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.Opc.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(6, 19)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(74, 20)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Terceiros"
        Me.A1.UseVisualStyleBackColor = True
        '
        'Opc
        '
        Me.Opc.BackColor = System.Drawing.Color.Transparent
        Me.Opc.Controls.Add(Me.A7)
        Me.Opc.Controls.Add(Me.A6)
        Me.Opc.Controls.Add(Me.A5)
        Me.Opc.Controls.Add(Me.A4)
        Me.Opc.Controls.Add(Me.A3)
        Me.Opc.Controls.Add(Me.A1)
        Me.Opc.Location = New System.Drawing.Point(12, 12)
        Me.Opc.Name = "Opc"
        Me.Opc.Size = New System.Drawing.Size(387, 106)
        Me.Opc.TabIndex = 0
        Me.Opc.TabStop = False
        Me.Opc.Text = "Selecione a Opção"
        '
        'A7
        '
        Me.A7.AutoSize = True
        Me.A7.Location = New System.Drawing.Point(129, 19)
        Me.A7.Name = "A7"
        Me.A7.Size = New System.Drawing.Size(71, 20)
        Me.A7.TabIndex = 1
        Me.A7.TabStop = True
        Me.A7.Text = "Produtos"
        Me.A7.UseVisualStyleBackColor = True
        '
        'A6
        '
        Me.A6.AutoSize = True
        Me.A6.Location = New System.Drawing.Point(129, 71)
        Me.A6.Name = "A6"
        Me.A6.Size = New System.Drawing.Size(95, 20)
        Me.A6.TabIndex = 5
        Me.A6.TabStop = True
        Me.A6.Text = "Itens Entrada"
        Me.A6.UseVisualStyleBackColor = True
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(6, 71)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(66, 20)
        Me.A5.TabIndex = 4
        Me.A5.TabStop = True
        Me.A5.Text = "Entrada"
        Me.A5.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(129, 45)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(81, 20)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Itens Saida"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(6, 45)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(57, 20)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Saidas"
        Me.A3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(15, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Local Gravar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Local
        '
        Me.Local.AceitaColarTexto = True
        Me.Local.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Local.CasasDecimais = 0
        Me.Local.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Local.CPObrigatorio = False
        Me.Local.CPObrigatorioMsg = Nothing
        Me.Local.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Local.FocusColor = System.Drawing.Color.Empty
        Me.Local.FocusColorEnd = System.Drawing.Color.Empty
        Me.Local.Location = New System.Drawing.Point(141, 124)
        Me.Local.MaxLength = 50
        Me.Local.Name = "Local"
        Me.Local.PreencherZeroEsqueda = False
        Me.Local.RegraValidação = Nothing
        Me.Local.RegraValidaçãoMensagem = Nothing
        Me.Local.Size = New System.Drawing.Size(258, 20)
        Me.Local.TabIndex = 2
        Me.Local.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Local.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cod. Empresa Pro-Soft"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpProSoft
        '
        Me.EmpProSoft.AceitaColarTexto = True
        Me.EmpProSoft.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EmpProSoft.CasasDecimais = 0
        Me.EmpProSoft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpProSoft.CPObrigatorio = False
        Me.EmpProSoft.CPObrigatorioMsg = Nothing
        Me.EmpProSoft.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EmpProSoft.FocusColor = System.Drawing.Color.Empty
        Me.EmpProSoft.FocusColorEnd = System.Drawing.Color.Empty
        Me.EmpProSoft.Location = New System.Drawing.Point(141, 150)
        Me.EmpProSoft.MaxLength = 50
        Me.EmpProSoft.Name = "EmpProSoft"
        Me.EmpProSoft.PreencherZeroEsqueda = False
        Me.EmpProSoft.RegraValidação = Nothing
        Me.EmpProSoft.RegraValidaçãoMensagem = Nothing
        Me.EmpProSoft.Size = New System.Drawing.Size(55, 20)
        Me.EmpProSoft.TabIndex = 4
        Me.EmpProSoft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EmpProSoft.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EmpProSoft.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(218, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cod. Empresa UP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpFocus
        '
        Me.EmpFocus.AceitaColarTexto = True
        Me.EmpFocus.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EmpFocus.CasasDecimais = 0
        Me.EmpFocus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpFocus.CPObrigatorio = False
        Me.EmpFocus.CPObrigatorioMsg = Nothing
        Me.EmpFocus.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EmpFocus.FocusColor = System.Drawing.Color.Empty
        Me.EmpFocus.FocusColorEnd = System.Drawing.Color.Empty
        Me.EmpFocus.Location = New System.Drawing.Point(344, 150)
        Me.EmpFocus.MaxLength = 50
        Me.EmpFocus.Name = "EmpFocus"
        Me.EmpFocus.PreencherZeroEsqueda = False
        Me.EmpFocus.RegraValidação = Nothing
        Me.EmpFocus.RegraValidaçãoMensagem = Nothing
        Me.EmpFocus.Size = New System.Drawing.Size(55, 20)
        Me.EmpFocus.TabIndex = 6
        Me.EmpFocus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EmpFocus.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EmpFocus.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nome Arquivo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeArquivo
        '
        Me.NomeArquivo.AceitaColarTexto = True
        Me.NomeArquivo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeArquivo.CasasDecimais = 0
        Me.NomeArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeArquivo.CPObrigatorio = False
        Me.NomeArquivo.CPObrigatorioMsg = Nothing
        Me.NomeArquivo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeArquivo.FocusColor = System.Drawing.Color.Empty
        Me.NomeArquivo.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeArquivo.Location = New System.Drawing.Point(141, 176)
        Me.NomeArquivo.MaxLength = 50
        Me.NomeArquivo.Name = "NomeArquivo"
        Me.NomeArquivo.PreencherZeroEsqueda = False
        Me.NomeArquivo.RegraValidação = Nothing
        Me.NomeArquivo.RegraValidaçãoMensagem = Nothing
        Me.NomeArquivo.Size = New System.Drawing.Size(144, 20)
        Me.NomeArquivo.TabIndex = 8
        Me.NomeArquivo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeArquivo.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(15, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Período"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 0
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.Location = New System.Drawing.Point(141, 202)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(96, 20)
        Me.DataInicial.TabIndex = 10
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.Location = New System.Drawing.Point(243, 202)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(96, 20)
        Me.DataFinal.TabIndex = 11
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'MyBarra
        '
        Me.MyBarra.Location = New System.Drawing.Point(12, 235)
        Me.MyBarra.Name = "MyBarra"
        Me.MyBarra.Size = New System.Drawing.Size(387, 23)
        Me.MyBarra.TabIndex = 12
        Me.MyBarra.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btGerar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Opc)
        Me.Fundo.Controls.Add(Me.MyBarra)
        Me.Fundo.Controls.Add(Me.Local)
        Me.Fundo.Controls.Add(Me.DataFinal)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.EmpProSoft)
        Me.Fundo.Controls.Add(Me.DataInicial)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.EmpFocus)
        Me.Fundo.Controls.Add(Me.NomeArquivo)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(409, 310)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btGerar
        '
        Me.btGerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGerar.Location = New System.Drawing.Point(219, 279)
        Me.btGerar.Name = "btGerar"
        Me.btGerar.Size = New System.Drawing.Size(86, 25)
        Me.btGerar.TabIndex = 13
        Me.btGerar.Text = "Gerar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(313, 279)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(86, 25)
        Me.btFechar.TabIndex = 14
        Me.btFechar.Text = "Fechar"
        '
        'ExportaProSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(409, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "ExportaProSoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportação de Dados para o Pro-Soft"
        Me.Opc.ResumeLayout(False)
        Me.Opc.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents Opc As System.Windows.Forms.GroupBox
    Friend WithEvents A6 As System.Windows.Forms.RadioButton
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Local As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmpProSoft As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EmpFocus As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NomeArquivo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyBarra As System.Windows.Forms.ProgressBar
    Friend WithEvents A7 As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btGerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
End Class
