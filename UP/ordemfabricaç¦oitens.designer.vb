<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdemFabricaçãoItens
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet
        Me.Descrição = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet
        Me.Novo = New System.Windows.Forms.Button
        Me.Salvar = New System.Windows.Forms.Button
        Me.Fechar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(5, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Quantidade"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Qtd
        '
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 4
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.FocusColor = System.Drawing.Color.MistyRose
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.Location = New System.Drawing.Point(130, 38)
        Me.Qtd.MaxLength = 15
        Me.Qtd.Name = "Qtd"
        Me.Qtd.Size = New System.Drawing.Size(78, 20)
        Me.Qtd.TabIndex = 9
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'Descrição
        '
        Me.Descrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Descrição.CasasDecimais = 0
        Me.Descrição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descrição.FocusColor = System.Drawing.Color.MistyRose
        Me.Descrição.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descrição.Location = New System.Drawing.Point(214, 12)
        Me.Descrição.MaxLength = 50
        Me.Descrição.Name = "Descrição"
        Me.Descrição.Size = New System.Drawing.Size(359, 20)
        Me.Descrição.TabIndex = 7
        Me.Descrição.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descrição.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(5, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Produto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Produto
        '
        Me.Produto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Produto.CasasDecimais = 0
        Me.Produto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Produto.FocusColor = System.Drawing.Color.MistyRose
        Me.Produto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Produto.Location = New System.Drawing.Point(130, 12)
        Me.Produto.MaxLength = 10
        Me.Produto.Name = "Produto"
        Me.Produto.Size = New System.Drawing.Size(78, 20)
        Me.Produto.TabIndex = 6
        Me.Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
        '
        'Novo
        '
        Me.Novo.Image = Global.Up.My.Resources.Resources.LimparBorracha
        Me.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Novo.Location = New System.Drawing.Point(234, 64)
        Me.Novo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(108, 40)
        Me.Novo.TabIndex = 15
        Me.Novo.Text = "Novo(F9)"
        Me.Novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Novo.UseVisualStyleBackColor = True
        '
        'Salvar
        '
        Me.Salvar.Image = Global.Up.My.Resources.Resources.Salvar
        Me.Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salvar.Location = New System.Drawing.Point(348, 64)
        Me.Salvar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(108, 40)
        Me.Salvar.TabIndex = 14
        Me.Salvar.Text = "Salvar(F10)"
        Me.Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Salvar.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.Image = Global.Up.My.Resources.Resources.Sair
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(465, 64)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(108, 40)
        Me.Fechar.TabIndex = 16
        Me.Fechar.Text = "Fechar(F11)"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'OrdemFabricaçãoItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(585, 113)
        Me.ControlBox = False
        Me.Controls.Add(Me.Novo)
        Me.Controls.Add(Me.Salvar)
        Me.Controls.Add(Me.Fechar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Qtd)
        Me.Controls.Add(Me.Descrição)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Produto)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OrdemFabricaçãoItens"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Itens da Ordem de Fabricação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Descrição As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Novo As System.Windows.Forms.Button
    Friend WithEvents Salvar As System.Windows.Forms.Button
    Friend WithEvents Fechar As System.Windows.Forms.Button
End Class
