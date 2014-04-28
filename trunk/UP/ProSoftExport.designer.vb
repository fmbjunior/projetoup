<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProSoftExport
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btGerar = New DevComponents.DotNetBar.ButtonX()
        Me.btEscolherPasta = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Opc = New System.Windows.Forms.GroupBox()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.MyBarra = New System.Windows.Forms.ProgressBar()
        Me.Local = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmpProSoft = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpUP = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.AnoInventario = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fundo.SuspendLayout()
        Me.Opc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Fundo.Controls.Add(Me.AnoInventario)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.btGerar)
        Me.Fundo.Controls.Add(Me.btEscolherPasta)
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
        Me.Fundo.Controls.Add(Me.EmpUP)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(718, 305)
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
        Me.btGerar.Location = New System.Drawing.Point(533, 269)
        Me.btGerar.Name = "btGerar"
        Me.btGerar.Size = New System.Drawing.Size(81, 25)
        Me.btGerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGerar.TabIndex = 15
        Me.btGerar.Text = "Gerar"
        '
        'btEscolherPasta
        '
        Me.btEscolherPasta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEscolherPasta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEscolherPasta.Location = New System.Drawing.Point(667, 106)
        Me.btEscolherPasta.Name = "btEscolherPasta"
        Me.btEscolherPasta.Size = New System.Drawing.Size(34, 23)
        Me.btEscolherPasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEscolherPasta.TabIndex = 3
        Me.btEscolherPasta.Text = "..."
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(620, 269)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(81, 25)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 0
        Me.btFechar.Text = "Fechar"
        '
        'Opc
        '
        Me.Opc.BackColor = System.Drawing.Color.Transparent
        Me.Opc.Controls.Add(Me.A4)
        Me.Opc.Controls.Add(Me.A2)
        Me.Opc.Controls.Add(Me.A3)
        Me.Opc.Controls.Add(Me.A1)
        Me.Opc.Location = New System.Drawing.Point(12, 12)
        Me.Opc.Name = "Opc"
        Me.Opc.Size = New System.Drawing.Size(694, 52)
        Me.Opc.TabIndex = 0
        Me.Opc.TabStop = False
        Me.Opc.Text = "Selecione a Opção"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(96, 22)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(69, 19)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Produtos"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.Location = New System.Drawing.Point(171, 22)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(76, 17)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Entrada"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(15, 22)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(75, 19)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Terceiros"
        Me.A1.UseVisualStyleBackColor = True
        '
        'MyBarra
        '
        Me.MyBarra.Location = New System.Drawing.Point(12, 227)
        Me.MyBarra.Name = "MyBarra"
        Me.MyBarra.Size = New System.Drawing.Size(692, 21)
        Me.MyBarra.TabIndex = 14
        Me.MyBarra.Visible = False
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
        Me.Local.FlatBorder = False
        Me.Local.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Local.FocusColor = System.Drawing.Color.Empty
        Me.Local.FocusColorEnd = System.Drawing.Color.Empty
        Me.Local.HighlightBorderOnEnter = False
        Me.Local.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Local.Location = New System.Drawing.Point(156, 106)
        Me.Local.MaxLength = 50
        Me.Local.Name = "Local"
        Me.Local.PreencherZeroEsqueda = False
        Me.Local.RegraValidação = Nothing
        Me.Local.RegraValidaçãoMensagem = Nothing
        Me.Local.Size = New System.Drawing.Size(505, 23)
        Me.Local.TabIndex = 2
        Me.Local.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Local.ValorPadrao = Nothing
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
        Me.DataFinal.FlatBorder = False
        Me.DataFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.HighlightBorderOnEnter = False
        Me.DataFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataFinal.Location = New System.Drawing.Point(275, 193)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(111, 23)
        Me.DataFinal.TabIndex = 13
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Local Gravar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Período"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.EmpProSoft.FlatBorder = False
        Me.EmpProSoft.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EmpProSoft.FocusColor = System.Drawing.Color.Empty
        Me.EmpProSoft.FocusColorEnd = System.Drawing.Color.Empty
        Me.EmpProSoft.HighlightBorderOnEnter = False
        Me.EmpProSoft.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EmpProSoft.Location = New System.Drawing.Point(156, 135)
        Me.EmpProSoft.MaxLength = 50
        Me.EmpProSoft.Name = "EmpProSoft"
        Me.EmpProSoft.PreencherZeroEsqueda = False
        Me.EmpProSoft.RegraValidação = Nothing
        Me.EmpProSoft.RegraValidaçãoMensagem = Nothing
        Me.EmpProSoft.Size = New System.Drawing.Size(63, 23)
        Me.EmpProSoft.TabIndex = 5
        Me.EmpProSoft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EmpProSoft.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EmpProSoft.ValorPadrao = Nothing
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
        Me.DataInicial.FlatBorder = False
        Me.DataInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.HighlightBorderOnEnter = False
        Me.DataInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataInicial.Location = New System.Drawing.Point(156, 193)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(111, 23)
        Me.DataInicial.TabIndex = 12
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cod. Empresa Pro-Soft"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpUP
        '
        Me.EmpUP.AceitaColarTexto = True
        Me.EmpUP.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EmpUP.CasasDecimais = 0
        Me.EmpUP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpUP.CPObrigatorio = False
        Me.EmpUP.CPObrigatorioMsg = Nothing
        Me.EmpUP.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EmpUP.FlatBorder = False
        Me.EmpUP.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EmpUP.FocusColor = System.Drawing.Color.Empty
        Me.EmpUP.FocusColorEnd = System.Drawing.Color.Empty
        Me.EmpUP.HighlightBorderOnEnter = False
        Me.EmpUP.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EmpUP.Location = New System.Drawing.Point(598, 135)
        Me.EmpUP.MaxLength = 50
        Me.EmpUP.Name = "EmpUP"
        Me.EmpUP.PreencherZeroEsqueda = False
        Me.EmpUP.RegraValidação = Nothing
        Me.EmpUP.RegraValidaçãoMensagem = Nothing
        Me.EmpUP.Size = New System.Drawing.Size(63, 23)
        Me.EmpUP.TabIndex = 7
        Me.EmpUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EmpUP.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EmpUP.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(451, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cod. Empresa E-Focus"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'A4
        '
        Me.A4.Location = New System.Drawing.Point(253, 22)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(82, 17)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Inventário"
        Me.A4.UseVisualStyleBackColor = True
        '
        'AnoInventario
        '
        Me.AnoInventario.AceitaColarTexto = True
        Me.AnoInventario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AnoInventario.CasasDecimais = 0
        Me.AnoInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AnoInventario.CPObrigatorio = False
        Me.AnoInventario.CPObrigatorioMsg = Nothing
        Me.AnoInventario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AnoInventario.FlatBorder = False
        Me.AnoInventario.FlatBorderColor = System.Drawing.Color.DimGray
        Me.AnoInventario.FocusColor = System.Drawing.Color.Empty
        Me.AnoInventario.FocusColorEnd = System.Drawing.Color.Empty
        Me.AnoInventario.HighlightBorderOnEnter = False
        Me.AnoInventario.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.AnoInventario.Location = New System.Drawing.Point(156, 164)
        Me.AnoInventario.MaxLength = 15
        Me.AnoInventario.Name = "AnoInventario"
        Me.AnoInventario.PreencherZeroEsqueda = False
        Me.AnoInventario.RegraValidação = Nothing
        Me.AnoInventario.RegraValidaçãoMensagem = Nothing
        Me.AnoInventario.Size = New System.Drawing.Size(63, 23)
        Me.AnoInventario.TabIndex = 10
        Me.AnoInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnoInventario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.AnoInventario.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ano do Inventário"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProSoftExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ProSoftExport"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProSoftExport - T057"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.Opc.ResumeLayout(False)
        Me.Opc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Opc As System.Windows.Forms.GroupBox
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents MyBarra As System.Windows.Forms.ProgressBar
    Friend WithEvents Local As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EmpProSoft As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmpUP As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Private WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Private WithEvents btEscolherPasta As DevComponents.DotNetBar.ButtonX
    Private WithEvents btGerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents AnoInventario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
