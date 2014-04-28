<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoDecimoTerceiro
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
        Me.Descrição = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Gerado2Parcela = New System.Windows.Forms.CheckBox
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.Visualizar = New DevComponents.DotNetBar.ButtonX
        Me.Fechar = New DevComponents.DotNetBar.ButtonX
        Me.Novo = New DevComponents.DotNetBar.ButtonX
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Gerado1Parcela = New System.Windows.Forms.CheckBox
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.Parcela1 = New DevComponents.DotNetBar.ButtonX
        Me.Imprimir = New DevComponents.DotNetBar.ButtonX
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
        Me.AnoAtual.Location = New System.Drawing.Point(12, 28)
        Me.AnoAtual.MaxLength = 30
        Me.AnoAtual.Name = "AnoAtual"
        Me.AnoAtual.RegraValidação = Nothing
        Me.AnoAtual.RegraValidaçãoMensagem = Nothing
        Me.AnoAtual.Size = New System.Drawing.Size(79, 20)
        Me.AnoAtual.TabIndex = 1
        Me.AnoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnoAtual.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AnoAtual.ValorPadrao = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Informe o Ano"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Descrição
        '
        Me.Descrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Descrição.CasasDecimais = 0
        Me.Descrição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descrição.CPObrigatorio = False
        Me.Descrição.CPObrigatorioMsg = Nothing
        Me.Descrição.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Descrição.FocusColor = System.Drawing.Color.Empty
        Me.Descrição.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descrição.Location = New System.Drawing.Point(178, 28)
        Me.Descrição.MaxLength = 30
        Me.Descrição.Name = "Descrição"
        Me.Descrição.RegraValidação = Nothing
        Me.Descrição.RegraValidaçãoMensagem = Nothing
        Me.Descrição.Size = New System.Drawing.Size(483, 20)
        Me.Descrição.TabIndex = 4
        Me.Descrição.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descrição.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(178, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Informe o ano a Gerar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Gerado2Parcela
        '
        Me.Gerado2Parcela.AutoSize = True
        Me.Gerado2Parcela.Enabled = False
        Me.Gerado2Parcela.Location = New System.Drawing.Point(667, 28)
        Me.Gerado2Parcela.Name = "Gerado2Parcela"
        Me.Gerado2Parcela.Size = New System.Drawing.Size(116, 20)
        Me.Gerado2Parcela.TabIndex = 5
        Me.Gerado2Parcela.Text = "Gerado 2. Parcela"
        Me.Gerado2Parcela.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.BackColor = System.Drawing.Color.White
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader11, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader12, Me.ColumnHeader9, Me.ColumnHeader13, Me.ColumnHeader10})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(12, 55)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(1006, 492)
        Me.MyLista.TabIndex = 7
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Func."
        Me.ColumnHeader1.Width = 55
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Nome Funcionário"
        Me.ColumnHeader11.Width = 190
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ref."
        Me.ColumnHeader2.Width = 35
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sal. Reg."
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sal. Dif"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Vlr. Outros"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Vlr. Décimo"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Inss"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 70
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "D. 1 Par"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 70
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "1. Parcela"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 70
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "D 2.Par"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "2. Parcela"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 70
        '
        'Visualizar
        '
        Me.Visualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Visualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Visualizar.Location = New System.Drawing.Point(97, 20)
        Me.Visualizar.Name = "Visualizar"
        Me.Visualizar.Size = New System.Drawing.Size(75, 28)
        Me.Visualizar.TabIndex = 2
        Me.Visualizar.Text = "Visualizar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(933, 20)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(85, 28)
        Me.Fechar.TabIndex = 6
        Me.Fechar.Text = "Fechar"
        '
        'Novo
        '
        Me.Novo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Novo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Novo.Location = New System.Drawing.Point(842, 20)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(85, 28)
        Me.Novo.TabIndex = 8
        Me.Novo.Text = "Novo Func."
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Imprimir)
        Me.Fundo.Controls.Add(Me.Gerado1Parcela)
        Me.Fundo.Controls.Add(Me.ButtonX1)
        Me.Fundo.Controls.Add(Me.Parcela1)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Novo)
        Me.Fundo.Controls.Add(Me.AnoAtual)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Visualizar)
        Me.Fundo.Controls.Add(Me.Descrição)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Gerado2Parcela)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(1030, 590)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 9
        '
        'Gerado1Parcela
        '
        Me.Gerado1Parcela.AutoSize = True
        Me.Gerado1Parcela.Enabled = False
        Me.Gerado1Parcela.Location = New System.Drawing.Point(667, 6)
        Me.Gerado1Parcela.Name = "Gerado1Parcela"
        Me.Gerado1Parcela.Size = New System.Drawing.Size(116, 20)
        Me.Gerado1Parcela.TabIndex = 11
        Me.Gerado1Parcela.Text = "Gerado 1. Parcela"
        Me.Gerado1Parcela.UseVisualStyleBackColor = True
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(115, 554)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(94, 28)
        Me.ButtonX1.TabIndex = 10
        Me.ButtonX1.Text = "Pgto 2º Parcela"
        '
        'Parcela1
        '
        Me.Parcela1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Parcela1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Parcela1.Location = New System.Drawing.Point(15, 554)
        Me.Parcela1.Name = "Parcela1"
        Me.Parcela1.Size = New System.Drawing.Size(94, 28)
        Me.Parcela1.TabIndex = 9
        Me.Parcela1.Text = "Pgto 1º Parcela"
        '
        'Imprimir
        '
        Me.Imprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Imprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Imprimir.Location = New System.Drawing.Point(215, 554)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(171, 28)
        Me.Imprimir.TabIndex = 12
        Me.Imprimir.Text = "Imprimir Décimo Terceiro"
        '
        'FolhaPgtoDecimoTerceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoDecimoTerceiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folha de Pagamento Décimo Terceiro"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AnoAtual As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Descrição As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gerado2Parcela As System.Windows.Forms.CheckBox
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Visualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Novo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Parcela1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Gerado1Parcela As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Imprimir As DevComponents.DotNetBar.ButtonX
End Class
