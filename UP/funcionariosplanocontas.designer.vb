<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuncionariosPlanoContas
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
        Me.Cadastrar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Desc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Reduzida = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Analitica = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label17 = New System.Windows.Forms.Label
        Me.ContaCabe�a = New TexBoxFocusNet.TextBoxFocusNet
        Me.SuspendLayout()
        '
        'Cadastrar
        '
        Me.Cadastrar.Image = Global.Up.My.Resources.Resources.Salvar
        Me.Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cadastrar.Location = New System.Drawing.Point(334, 126)
        Me.Cadastrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Cadastrar.Name = "Cadastrar"
        Me.Cadastrar.Size = New System.Drawing.Size(97, 38)
        Me.Cadastrar.TabIndex = 26
        Me.Cadastrar.Text = "Cadastrar"
        Me.Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cadastrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Descri��o"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Desc
        '
        Me.Desc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Desc.CasasDecimais = 0
        Me.Desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Desc.FocusColor = System.Drawing.Color.Empty
        Me.Desc.FocusColorEnd = System.Drawing.Color.Empty
        Me.Desc.Location = New System.Drawing.Point(114, 97)
        Me.Desc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Desc.MaxLength = 50
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(317, 20)
        Me.Desc.TabIndex = 25
        Me.Desc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Desc.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Conta Reduzida"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Reduzida
        '
        Me.Reduzida.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Reduzida.CasasDecimais = 0
        Me.Reduzida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Reduzida.FocusColor = System.Drawing.Color.Empty
        Me.Reduzida.FocusColorEnd = System.Drawing.Color.Empty
        Me.Reduzida.Location = New System.Drawing.Point(114, 69)
        Me.Reduzida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Reduzida.MaxLength = 50
        Me.Reduzida.Name = "Reduzida"
        Me.Reduzida.Size = New System.Drawing.Size(154, 20)
        Me.Reduzida.TabIndex = 23
        Me.Reduzida.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Reduzida.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Conta Analitica"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Analitica
        '
        Me.Analitica.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Analitica.CasasDecimais = 0
        Me.Analitica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Analitica.FocusColor = System.Drawing.Color.Empty
        Me.Analitica.FocusColorEnd = System.Drawing.Color.Empty
        Me.Analitica.Location = New System.Drawing.Point(114, 41)
        Me.Analitica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Analitica.MaxLength = 50
        Me.Analitica.Name = "Analitica"
        Me.Analitica.Size = New System.Drawing.Size(154, 20)
        Me.Analitica.TabIndex = 21
        Me.Analitica.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Analitica.ValorPadrao = Nothing
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(9, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 25)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Conta Cabe�a"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContaCabe�a
        '
        Me.ContaCabe�a.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.ContaCabe�a.CasasDecimais = 0
        Me.ContaCabe�a.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ContaCabe�a.FocusColor = System.Drawing.Color.Empty
        Me.ContaCabe�a.FocusColorEnd = System.Drawing.Color.Empty
        Me.ContaCabe�a.Location = New System.Drawing.Point(114, 13)
        Me.ContaCabe�a.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContaCabe�a.MaxLength = 50
        Me.ContaCabe�a.Name = "ContaCabe�a"
        Me.ContaCabe�a.Size = New System.Drawing.Size(154, 20)
        Me.ContaCabe�a.TabIndex = 19
        Me.ContaCabe�a.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ContaCabe�a.ValorPadrao = Nothing
        '
        'FuncionariosPlanoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(436, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cadastrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Reduzida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Analitica)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ContaCabe�a)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FuncionariosPlanoContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastra Funcion�rios no Plano de Contas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cadastrar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Desc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Reduzida As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Analitica As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ContaCabe�a As TexBoxFocusNet.TextBoxFocusNet
End Class
