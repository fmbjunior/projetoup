<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuncionariosHistorico
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
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataHistorico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Historico = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Editar = New System.Windows.Forms.Button()
        Me.Salvar = New System.Windows.Forms.Button()
        Me.Novo = New System.Windows.Forms.Button()
        Me.Fechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(14, 12)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(663, 220)
        Me.MyLista.TabIndex = 0
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Data"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Histórico"
        Me.ColumnHeader3.Width = 560
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(135, 237)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(107, 23)
        Me.Id.TabIndex = 168
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(9, 266)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 19)
        Me.Label15.TabIndex = 169
        Me.Label15.Text = "Data Histórico"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataHistorico
        '
        Me.DataHistorico.AceitaColarTexto = True
        Me.DataHistorico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataHistorico.CasasDecimais = 0
        Me.DataHistorico.CPObrigatorio = False
        Me.DataHistorico.CPObrigatorioMsg = Nothing
        Me.DataHistorico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataHistorico.FlatBorder = False
        Me.DataHistorico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataHistorico.FocusColor = System.Drawing.Color.Empty
        Me.DataHistorico.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataHistorico.HighlightBorderOnEnter = False
        Me.DataHistorico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataHistorico.Location = New System.Drawing.Point(135, 266)
        Me.DataHistorico.MaxLength = 10
        Me.DataHistorico.Name = "DataHistorico"
        Me.DataHistorico.PreencherZeroEsqueda = False
        Me.DataHistorico.RegraValidação = Nothing
        Me.DataHistorico.RegraValidaçãoMensagem = Nothing
        Me.DataHistorico.Size = New System.Drawing.Size(107, 23)
        Me.DataHistorico.TabIndex = 170
        Me.DataHistorico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataHistorico.ValorPadrao = Nothing
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(10, 295)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 19)
        Me.Label20.TabIndex = 171
        Me.Label20.Text = "Histórico"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Historico
        '
        Me.Historico.AceitaColarTexto = True
        Me.Historico.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Historico.CasasDecimais = 0
        Me.Historico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Historico.CPObrigatorio = False
        Me.Historico.CPObrigatorioMsg = Nothing
        Me.Historico.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Historico.FlatBorder = False
        Me.Historico.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Historico.FocusColor = System.Drawing.Color.Empty
        Me.Historico.FocusColorEnd = System.Drawing.Color.Empty
        Me.Historico.HighlightBorderOnEnter = False
        Me.Historico.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Historico.Location = New System.Drawing.Point(135, 295)
        Me.Historico.MaxLength = 50
        Me.Historico.Name = "Historico"
        Me.Historico.PreencherZeroEsqueda = False
        Me.Historico.RegraValidação = Nothing
        Me.Historico.RegraValidaçãoMensagem = Nothing
        Me.Historico.Size = New System.Drawing.Size(542, 23)
        Me.Historico.TabIndex = 172
        Me.Historico.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Historico.ValorPadrao = Nothing
        '
        'Editar
        '
        Me.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar.Location = New System.Drawing.Point(327, 325)
        Me.Editar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(83, 29)
        Me.Editar.TabIndex = 174
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Salvar
        '
        Me.Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salvar.Location = New System.Drawing.Point(416, 325)
        Me.Salvar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(83, 29)
        Me.Salvar.TabIndex = 173
        Me.Salvar.Text = "Salvar"
        Me.Salvar.UseVisualStyleBackColor = True
        '
        'Novo
        '
        Me.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Novo.Location = New System.Drawing.Point(505, 325)
        Me.Novo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(83, 29)
        Me.Novo.TabIndex = 175
        Me.Novo.Text = "Novo"
        Me.Novo.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(594, 325)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(83, 29)
        Me.Fechar.TabIndex = 166
        Me.Fechar.Text = "Fechar"
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'FuncionariosHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(692, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Salvar)
        Me.Controls.Add(Me.Novo)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Historico)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DataHistorico)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Fechar)
        Me.Controls.Add(Me.MyLista)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FuncionariosHistorico"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hitórico de Funcionário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataHistorico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Historico As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents Salvar As System.Windows.Forms.Button
    Friend WithEvents Novo As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
