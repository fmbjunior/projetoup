<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdemCompraRelat
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Visualizar = New DevComponents.DotNetBar.ButtonX
        Me.Fechar = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.A2 = New System.Windows.Forms.RadioButton
        Me.A1 = New System.Windows.Forms.RadioButton
        Me.PainelPeriodo = New System.Windows.Forms.Panel
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet
        Me.A3 = New System.Windows.Forms.RadioButton
        Me.PainelApontamento = New System.Windows.Forms.Panel
        Me.i1 = New System.Windows.Forms.RadioButton
        Me.i2 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.i3 = New System.Windows.Forms.RadioButton
        Me.Fundo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        Me.PainelApontamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.PainelApontamento)
        Me.Fundo.Controls.Add(Me.Visualizar)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.GroupBox1)
        Me.Fundo.Controls.Add(Me.PainelPeriodo)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(340, 243)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Visualizar
        '
        Me.Visualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Visualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Visualizar.Location = New System.Drawing.Point(7, 204)
        Me.Visualizar.Name = "Visualizar"
        Me.Visualizar.Size = New System.Drawing.Size(75, 31)
        Me.Visualizar.TabIndex = 3
        Me.Visualizar.Text = "Visualizar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(88, 204)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(75, 31)
        Me.Fechar.TabIndex = 4
        Me.Fechar.Text = "Fechar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.A3)
        Me.GroupBox1.Controls.Add(Me.A2)
        Me.GroupBox1.Controls.Add(Me.A1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione a Opção"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.A2.Location = New System.Drawing.Point(6, 45)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(163, 17)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Ordem de Compra  Finalizada"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.A1.Location = New System.Drawing.Point(6, 19)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(187, 17)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Ordem de Compra  em Andamento"
        Me.A1.UseVisualStyleBackColor = True
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label9)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(6, 112)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(328, 28)
        Me.PainelPeriodo.TabIndex = 1
        Me.PainelPeriodo.Visible = False
        '
        'DataFinal
        '
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.Location = New System.Drawing.Point(219, 3)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(100, 20)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Informe o Período"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataInicial
        '
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 0
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.Location = New System.Drawing.Point(113, 3)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(100, 20)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.A3.Location = New System.Drawing.Point(6, 68)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(88, 17)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Apontamento"
        Me.A3.UseVisualStyleBackColor = True
        '
        'PainelApontamento
        '
        Me.PainelApontamento.Controls.Add(Me.i3)
        Me.PainelApontamento.Controls.Add(Me.Label2)
        Me.PainelApontamento.Controls.Add(Me.i2)
        Me.PainelApontamento.Controls.Add(Me.i1)
        Me.PainelApontamento.Location = New System.Drawing.Point(6, 147)
        Me.PainelApontamento.Name = "PainelApontamento"
        Me.PainelApontamento.Size = New System.Drawing.Size(328, 51)
        Me.PainelApontamento.TabIndex = 2
        Me.PainelApontamento.Visible = False
        '
        'i1
        '
        Me.i1.AutoSize = True
        Me.i1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.i1.Location = New System.Drawing.Point(6, 27)
        Me.i1.Name = "i1"
        Me.i1.Size = New System.Drawing.Size(55, 17)
        Me.i1.TabIndex = 1
        Me.i1.TabStop = True
        Me.i1.Text = "Todos"
        Me.i1.UseVisualStyleBackColor = True
        '
        'i2
        '
        Me.i2.AutoSize = True
        Me.i2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.i2.Location = New System.Drawing.Point(103, 27)
        Me.i2.Name = "i2"
        Me.i2.Size = New System.Drawing.Size(76, 17)
        Me.i2.TabIndex = 2
        Me.i2.TabStop = True
        Me.i2.Text = "Apontados"
        Me.i2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Itens"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'i3
        '
        Me.i3.AutoSize = True
        Me.i3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.i3.Location = New System.Drawing.Point(209, 27)
        Me.i3.Name = "i3"
        Me.i3.Size = New System.Drawing.Size(99, 17)
        Me.i3.TabIndex = 3
        Me.i3.TabStop = True
        Me.i3.Text = "Não Apontados"
        Me.i3.UseVisualStyleBackColor = True
        '
        'OrdemCompraRelat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "OrdemCompraRelat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordem de compra Relatórios"
        Me.Fundo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.PainelApontamento.ResumeLayout(False)
        Me.PainelApontamento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Visualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents PainelApontamento As System.Windows.Forms.Panel
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents i1 As System.Windows.Forms.RadioButton
    Friend WithEvents i3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents i2 As System.Windows.Forms.RadioButton
End Class
