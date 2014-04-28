<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoSolicitação
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
        Me.Label14 = New System.Windows.Forms.Label
        Me.TipoSolicitaçao = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.DiasMinimo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.DiasMaximo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Excluir = New System.Windows.Forms.Button
        Me.Salvar = New System.Windows.Forms.Button
        Me.Novo = New System.Windows.Forms.Button
        Me.Fechar = New System.Windows.Forms.Button
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(238, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Tipo de Solicitação"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoSolicitaçao
        '
        Me.TipoSolicitaçao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TipoSolicitaçao.CasasDecimais = 0
        Me.TipoSolicitaçao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TipoSolicitaçao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TipoSolicitaçao.FocusColor = System.Drawing.Color.MistyRose
        Me.TipoSolicitaçao.FocusColorEnd = System.Drawing.Color.Empty
        Me.TipoSolicitaçao.Location = New System.Drawing.Point(390, 40)
        Me.TipoSolicitaçao.MaxLength = 15
        Me.TipoSolicitaçao.Name = "TipoSolicitaçao"
        Me.TipoSolicitaçao.Size = New System.Drawing.Size(106, 20)
        Me.TipoSolicitaçao.TabIndex = 27
        Me.TipoSolicitaçao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TipoSolicitaçao.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(238, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Dias Mínimo p/ Solicitação"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiasMinimo
        '
        Me.DiasMinimo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DiasMinimo.CasasDecimais = 0
        Me.DiasMinimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiasMinimo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiasMinimo.FocusColor = System.Drawing.Color.MistyRose
        Me.DiasMinimo.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiasMinimo.Location = New System.Drawing.Point(390, 65)
        Me.DiasMinimo.MaxLength = 4
        Me.DiasMinimo.Name = "DiasMinimo"
        Me.DiasMinimo.Size = New System.Drawing.Size(40, 20)
        Me.DiasMinimo.TabIndex = 29
        Me.DiasMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DiasMinimo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DiasMinimo.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(238, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Dias Máximo p/ Solicitação"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiasMaximo
        '
        Me.DiasMaximo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DiasMaximo.CasasDecimais = 0
        Me.DiasMaximo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DiasMaximo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DiasMaximo.FocusColor = System.Drawing.Color.MistyRose
        Me.DiasMaximo.FocusColorEnd = System.Drawing.Color.Empty
        Me.DiasMaximo.Location = New System.Drawing.Point(390, 91)
        Me.DiasMaximo.MaxLength = 4
        Me.DiasMaximo.Name = "DiasMaximo"
        Me.DiasMaximo.Size = New System.Drawing.Size(40, 20)
        Me.DiasMaximo.TabIndex = 31
        Me.DiasMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DiasMaximo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DiasMaximo.ValorPadrao = Nothing
        '
        'Excluir
        '
        Me.Excluir.Image = Global.Up.My.Resources.Resources.Excluir
        Me.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Excluir.Location = New System.Drawing.Point(122, 174)
        Me.Excluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Size = New System.Drawing.Size(89, 37)
        Me.Excluir.TabIndex = 73
        Me.Excluir.Text = "Excluir"
        Me.Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Excluir.UseVisualStyleBackColor = True
        '
        'Salvar
        '
        Me.Salvar.Image = Global.Up.My.Resources.Resources.Salvar
        Me.Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salvar.Location = New System.Drawing.Point(217, 174)
        Me.Salvar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(89, 37)
        Me.Salvar.TabIndex = 70
        Me.Salvar.Text = "Salvar"
        Me.Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Salvar.UseVisualStyleBackColor = True
        '
        'Novo
        '
        Me.Novo.Image = Global.Up.My.Resources.Resources.LimparBorracha
        Me.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Novo.Location = New System.Drawing.Point(312, 174)
        Me.Novo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(89, 37)
        Me.Novo.TabIndex = 72
        Me.Novo.Text = "Novo"
        Me.Novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Novo.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.Image = Global.Up.My.Resources.Resources.Sair
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(407, 174)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(89, 37)
        Me.Fechar.TabIndex = 74
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(12, 12)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(220, 155)
        Me.MyLista.TabIndex = 75
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tipo"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mínimo"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Máximo"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 50
        '
        'TipoSolicitação
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(510, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.MyLista)
        Me.Controls.Add(Me.Excluir)
        Me.Controls.Add(Me.Salvar)
        Me.Controls.Add(Me.Novo)
        Me.Controls.Add(Me.Fechar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DiasMaximo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DiasMinimo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TipoSolicitaçao)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TipoSolicitação"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Solicitação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TipoSolicitaçao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DiasMinimo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DiasMaximo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Excluir As System.Windows.Forms.Button
    Friend WithEvents Salvar As System.Windows.Forms.Button
    Friend WithEvents Novo As System.Windows.Forms.Button
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
