<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjetoAlterarLegenda
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
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.btOk = New DevComponents.DotNetBar.ButtonX()
        Me.NovoTexto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(138, 55)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(56, 19)
        Me.Fechar.TabIndex = 3
        Me.Fechar.Text = "Fechar"
        '
        'btOk
        '
        Me.btOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btOk.Location = New System.Drawing.Point(76, 55)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(56, 19)
        Me.btOk.TabIndex = 2
        Me.btOk.Text = "Ok"
        '
        'NovoTexto
        '
        Me.NovoTexto.AceitaColarTexto = True
        Me.NovoTexto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NovoTexto.CasasDecimais = 0
        Me.NovoTexto.CPObrigatorio = False
        Me.NovoTexto.CPObrigatorioMsg = Nothing
        Me.NovoTexto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NovoTexto.FlatBorder = False
        Me.NovoTexto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NovoTexto.FocusColor = System.Drawing.Color.MistyRose
        Me.NovoTexto.FocusColorEnd = System.Drawing.Color.Empty
        Me.NovoTexto.HighlightBorderOnEnter = False
        Me.NovoTexto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NovoTexto.Location = New System.Drawing.Point(3, 28)
        Me.NovoTexto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NovoTexto.MaxLength = 30
        Me.NovoTexto.Name = "NovoTexto"
        Me.NovoTexto.PreencherZeroEsqueda = False
        Me.NovoTexto.RegraValidação = Nothing
        Me.NovoTexto.RegraValidaçãoMensagem = Nothing
        Me.NovoTexto.Size = New System.Drawing.Size(191, 20)
        Me.NovoTexto.TabIndex = 1
        Me.NovoTexto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NovoTexto.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Novo Texto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NovoTexto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Fechar)
        Me.Panel1.Controls.Add(Me.btOk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 80)
        Me.Panel1.TabIndex = 4
        '
        'ObjetoAlterarLegenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(199, 80)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ObjetoAlterarLegenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ObjetoAlterarLegenda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents NovoTexto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
