<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FichasIrpj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FichasIrpj))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.A4 = New System.Windows.Forms.RadioButton
        Me.A3 = New System.Windows.Forms.RadioButton
        Me.A2 = New System.Windows.Forms.RadioButton
        Me.A1 = New System.Windows.Forms.RadioButton
        Me.Fechar = New System.Windows.Forms.Button
        Me.Visualizar = New System.Windows.Forms.Button
        Me.PainelPeriodo = New System.Windows.Forms.Panel
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet
        Me.GroupBox1.SuspendLayout()
        Me.PainelPeriodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.A4)
        Me.GroupBox1.Controls.Add(Me.A3)
        Me.GroupBox1.Controls.Add(Me.A2)
        Me.GroupBox1.Controls.Add(Me.A1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione a Opção"
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(6, 96)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(274, 20)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = True
        Me.A4.Text = "Saidas de Produtos Mercadoria/Insumo (Ficha 26)"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(6, 71)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(315, 20)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = True
        Me.A3.Text = "Destinatário de Produtos/Mercadoria e Insumo (Ficha 25)"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(6, 45)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(251, 20)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = True
        Me.A2.Text = "Entrada de Insumos e Mercadorias (Ficha 24)"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(6, 19)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(255, 20)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = True
        Me.A1.Text = "Remetente de Insumo e Mercadoria (Ficha 23)"
        Me.A1.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(371, 200)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(112, 55)
        Me.Fechar.TabIndex = 3
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'Visualizar
        '
        Me.Visualizar.Image = CType(resources.GetObject("Visualizar.Image"), System.Drawing.Image)
        Me.Visualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Visualizar.Location = New System.Drawing.Point(253, 200)
        Me.Visualizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visualizar.Name = "Visualizar"
        Me.Visualizar.Size = New System.Drawing.Size(112, 55)
        Me.Visualizar.TabIndex = 2
        Me.Visualizar.Text = "Visualizar"
        Me.Visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Visualizar.UseVisualStyleBackColor = True
        '
        'PainelPeriodo
        '
        Me.PainelPeriodo.Controls.Add(Me.DataFinal)
        Me.PainelPeriodo.Controls.Add(Me.Label9)
        Me.PainelPeriodo.Controls.Add(Me.DataInicial)
        Me.PainelPeriodo.Location = New System.Drawing.Point(12, 154)
        Me.PainelPeriodo.Name = "PainelPeriodo"
        Me.PainelPeriodo.Size = New System.Drawing.Size(328, 28)
        Me.PainelPeriodo.TabIndex = 1
        '
        'DataFinal
        '
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.Location = New System.Drawing.Point(219, 3)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(100, 20)
        Me.DataFinal.TabIndex = 2
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 3)
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
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.Location = New System.Drawing.Point(113, 3)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(100, 20)
        Me.DataInicial.TabIndex = 1
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'FichasIrpj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(495, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.PainelPeriodo)
        Me.Controls.Add(Me.Visualizar)
        Me.Controls.Add(Me.Fechar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FichasIrpj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fichas para IRPJ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PainelPeriodo.ResumeLayout(False)
        Me.PainelPeriodo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Visualizar As System.Windows.Forms.Button
    Friend WithEvents PainelPeriodo As System.Windows.Forms.Panel
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
End Class
