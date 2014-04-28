<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuncionariosRelat
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
        Me.A6 = New System.Windows.Forms.RadioButton()
        Me.A5 = New System.Windows.Forms.RadioButton()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.PainelFuncionario = New System.Windows.Forms.Panel()
        Me.FuncDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Func = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelDepartamento = New System.Windows.Forms.Panel()
        Me.DepartamentoDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Departamento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PainelPeriodo = New System.Windows.Forms.Panel()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btVisualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PainelFuncionario.SuspendLayout()
        Me.PainelDepartamento.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A6
        '
        Me.A6.AutoSize = True
        Me.A6.Location = New System.Drawing.Point(4, 144)
        Me.A6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A6.Name = "A6"
        Me.A6.Size = New System.Drawing.Size(151, 20)
        Me.A6.TabIndex = 5
        Me.A6.TabStop = True
        Me.A6.Text = "Funcionário  Ativos Geral"
        Me.A6.UseVisualStyleBackColor = True
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(3, 116)
        Me.A5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(283, 20)
        Me.A5.TabIndex = 4
        Me.A5.TabStop = True
        Me.A5.Text = "Funcionário  Data Admissão (Período) (Vazio Todos)"
        Me.A5.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(3, 88)
        Me.A4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(185, 20)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Funcionário por Departamentos"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(3, 60)
        Me.A3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(222, 20)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Funcionário por Departamentos (Geral)"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(3, 32)
        Me.A2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(134, 20)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Funcionário Histórico"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 4)
        Me.A1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(153, 20)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Funcionários Geral (Foto)"
        Me.A1.UseVisualStyleBackColor = True
        '
        'PainelFuncionario
        '
        Me.PainelFuncionario.Controls.Add(Me.FuncDesc)
        Me.PainelFuncionario.Controls.Add(Me.Label1)
        Me.PainelFuncionario.Controls.Add(Me.Func)
        Me.PainelFuncionario.Location = New System.Drawing.Point(323, 11)
        Me.PainelFuncionario.Name = "PainelFuncionario"
        Me.PainelFuncionario.Size = New System.Drawing.Size(318, 78)
        Me.PainelFuncionario.TabIndex = 67
        Me.PainelFuncionario.Visible = False
        '
        'FuncDesc
        '
        Me.FuncDesc.AceitaColarTexto = True
        Me.FuncDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.FuncDesc.CasasDecimais = 0
        Me.FuncDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FuncDesc.CPObrigatorio = False
        Me.FuncDesc.CPObrigatorioMsg = Nothing
        Me.FuncDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FuncDesc.FlatBorder = False
        Me.FuncDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.FuncDesc.FocusColor = System.Drawing.Color.Empty
        Me.FuncDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FuncDesc.HighlightBorderOnEnter = False
        Me.FuncDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.FuncDesc.Location = New System.Drawing.Point(7, 52)
        Me.FuncDesc.Name = "FuncDesc"
        Me.FuncDesc.PreencherZeroEsqueda = False
        Me.FuncDesc.RegraValidação = Nothing
        Me.FuncDesc.RegraValidaçãoMensagem = Nothing
        Me.FuncDesc.Size = New System.Drawing.Size(303, 20)
        Me.FuncDesc.TabIndex = 61
        Me.FuncDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FuncDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Informe o Funcionário"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Func
        '
        Me.Func.AceitaColarTexto = True
        Me.Func.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Func.CasasDecimais = 0
        Me.Func.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Func.CPObrigatorio = False
        Me.Func.CPObrigatorioMsg = Nothing
        Me.Func.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Func.FlatBorder = False
        Me.Func.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Func.FocusColor = System.Drawing.Color.Empty
        Me.Func.FocusColorEnd = System.Drawing.Color.Empty
        Me.Func.HighlightBorderOnEnter = False
        Me.Func.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Func.Location = New System.Drawing.Point(7, 26)
        Me.Func.Name = "Func"
        Me.Func.PreencherZeroEsqueda = False
        Me.Func.RegraValidação = Nothing
        Me.Func.RegraValidaçãoMensagem = Nothing
        Me.Func.Size = New System.Drawing.Size(100, 20)
        Me.Func.TabIndex = 60
        Me.Func.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Func.ValorPadrao = Nothing
        '
        'PainelDepartamento
        '
        Me.PainelDepartamento.Controls.Add(Me.DepartamentoDesc)
        Me.PainelDepartamento.Controls.Add(Me.Label2)
        Me.PainelDepartamento.Controls.Add(Me.Departamento)
        Me.PainelDepartamento.Location = New System.Drawing.Point(321, 95)
        Me.PainelDepartamento.Name = "PainelDepartamento"
        Me.PainelDepartamento.Size = New System.Drawing.Size(318, 78)
        Me.PainelDepartamento.TabIndex = 68
        Me.PainelDepartamento.Visible = False
        '
        'DepartamentoDesc
        '
        Me.DepartamentoDesc.AceitaColarTexto = True
        Me.DepartamentoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DepartamentoDesc.CasasDecimais = 0
        Me.DepartamentoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DepartamentoDesc.CPObrigatorio = False
        Me.DepartamentoDesc.CPObrigatorioMsg = Nothing
        Me.DepartamentoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DepartamentoDesc.FlatBorder = False
        Me.DepartamentoDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DepartamentoDesc.FocusColor = System.Drawing.Color.Empty
        Me.DepartamentoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.DepartamentoDesc.HighlightBorderOnEnter = False
        Me.DepartamentoDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DepartamentoDesc.Location = New System.Drawing.Point(7, 52)
        Me.DepartamentoDesc.Name = "DepartamentoDesc"
        Me.DepartamentoDesc.PreencherZeroEsqueda = False
        Me.DepartamentoDesc.RegraValidação = Nothing
        Me.DepartamentoDesc.RegraValidaçãoMensagem = Nothing
        Me.DepartamentoDesc.Size = New System.Drawing.Size(303, 20)
        Me.DepartamentoDesc.TabIndex = 61
        Me.DepartamentoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DepartamentoDesc.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Informe o Departamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Departamento
        '
        Me.Departamento.AceitaColarTexto = True
        Me.Departamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Departamento.CasasDecimais = 0
        Me.Departamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Departamento.CPObrigatorio = False
        Me.Departamento.CPObrigatorioMsg = Nothing
        Me.Departamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Departamento.FlatBorder = False
        Me.Departamento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Departamento.FocusColor = System.Drawing.Color.Empty
        Me.Departamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Departamento.HighlightBorderOnEnter = False
        Me.Departamento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Departamento.Location = New System.Drawing.Point(7, 26)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.PreencherZeroEsqueda = False
        Me.Departamento.RegraValidação = Nothing
        Me.Departamento.RegraValidaçãoMensagem = Nothing
        Me.Departamento.Size = New System.Drawing.Size(100, 20)
        Me.Departamento.TabIndex = 60
        Me.Departamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Departamento.ValorPadrao = Nothing
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label9)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(321, 180)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(318, 28)
        Me.PainelPeriodo.TabIndex = 69
        Me.PainelPeriodo.Visible = False
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
        Me.DataFinal.Location = New System.Drawing.Point(210, 3)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(100, 20)
        Me.DataFinal.TabIndex = 61
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Data Admissão"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.DataInicial.Location = New System.Drawing.Point(104, 3)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(100, 20)
        Me.DataInicial.TabIndex = 60
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btVisualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Controls.Add(Me.PainelPeriodo)
        Me.Fundo.Controls.Add(Me.PainelDepartamento)
        Me.Fundo.Controls.Add(Me.PainelFuncionario)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(653, 272)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 70
        '
        'btVisualizar
        '
        Me.btVisualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVisualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVisualizar.Location = New System.Drawing.Point(460, 235)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(87, 29)
        Me.btVisualizar.TabIndex = 72
        Me.btVisualizar.Text = "Visualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(554, 235)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(87, 29)
        Me.btFechar.TabIndex = 71
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A6)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A5)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Location = New System.Drawing.Point(9, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(310, 205)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 70
        Me.GroupPanel1.Text = "Selecione uma das Opções"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'FuncionariosRelat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(653, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FuncionariosRelat"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios de Funcionários - T145"
        Me.PainelFuncionario.ResumeLayout(False)
        Me.PainelFuncionario.PerformLayout()
        Me.PainelDepartamento.ResumeLayout(False)
        Me.PainelDepartamento.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelFuncionario As System.Windows.Forms.Panel
    Friend WithEvents FuncDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Func As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelDepartamento As System.Windows.Forms.Panel
    Friend WithEvents DepartamentoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Departamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A6 As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btVisualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
