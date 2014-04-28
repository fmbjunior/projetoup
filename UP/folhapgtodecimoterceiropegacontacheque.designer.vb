<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoDecimoTerceiroPegaContaCheque
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
        Me.BancoChequeConta = New TexBoxFocusNet.TextBoxFocusNet
        Me.BancoChequeDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.BancoCheque = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Final = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Inicial = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fechar = New DevComponents.DotNetBar.ButtonX
        Me.btOK = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'BancoChequeConta
        '
        Me.BancoChequeConta.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.BancoChequeConta.CasasDecimais = 0
        Me.BancoChequeConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoChequeConta.CPObrigatorio = False
        Me.BancoChequeConta.CPObrigatorioMsg = Nothing
        Me.BancoChequeConta.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.BancoChequeConta.FocusColor = System.Drawing.Color.Empty
        Me.BancoChequeConta.FocusColorEnd = System.Drawing.Color.Empty
        Me.BancoChequeConta.Location = New System.Drawing.Point(152, 25)
        Me.BancoChequeConta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BancoChequeConta.MaxLength = 7
        Me.BancoChequeConta.Name = "BancoChequeConta"
        Me.BancoChequeConta.RegraValidação = Nothing
        Me.BancoChequeConta.RegraValidaçãoMensagem = Nothing
        Me.BancoChequeConta.Size = New System.Drawing.Size(257, 20)
        Me.BancoChequeConta.TabIndex = 2
        Me.BancoChequeConta.TabStop = False
        Me.BancoChequeConta.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BancoChequeConta.ValorPadrao = Nothing
        '
        'BancoChequeDesc
        '
        Me.BancoChequeDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.BancoChequeDesc.CasasDecimais = 0
        Me.BancoChequeDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoChequeDesc.CPObrigatorio = False
        Me.BancoChequeDesc.CPObrigatorioMsg = Nothing
        Me.BancoChequeDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.BancoChequeDesc.FocusColor = System.Drawing.Color.Empty
        Me.BancoChequeDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.BancoChequeDesc.Location = New System.Drawing.Point(86, 53)
        Me.BancoChequeDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BancoChequeDesc.MaxLength = 7
        Me.BancoChequeDesc.Name = "BancoChequeDesc"
        Me.BancoChequeDesc.RegraValidação = Nothing
        Me.BancoChequeDesc.RegraValidaçãoMensagem = Nothing
        Me.BancoChequeDesc.Size = New System.Drawing.Size(323, 20)
        Me.BancoChequeDesc.TabIndex = 3
        Me.BancoChequeDesc.TabStop = False
        Me.BancoChequeDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BancoChequeDesc.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BancoCheque
        '
        Me.BancoCheque.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.BancoCheque.CasasDecimais = 0
        Me.BancoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoCheque.CPObrigatorio = False
        Me.BancoCheque.CPObrigatorioMsg = Nothing
        Me.BancoCheque.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.BancoCheque.FocusColor = System.Drawing.Color.Empty
        Me.BancoCheque.FocusColorEnd = System.Drawing.Color.Empty
        Me.BancoCheque.Location = New System.Drawing.Point(86, 25)
        Me.BancoCheque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BancoCheque.MaxLength = 7
        Me.BancoCheque.Name = "BancoCheque"
        Me.BancoCheque.RegraValidação = Nothing
        Me.BancoCheque.RegraValidaçãoMensagem = Nothing
        Me.BancoCheque.Size = New System.Drawing.Size(60, 20)
        Me.BancoCheque.TabIndex = 1
        Me.BancoCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BancoCheque.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.BancoCheque.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ch Inicial"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Final
        '
        Me.Final.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Final.CasasDecimais = 0
        Me.Final.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Final.CPObrigatorio = False
        Me.Final.CPObrigatorioMsg = Nothing
        Me.Final.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.Final.FocusColor = System.Drawing.Color.Empty
        Me.Final.FocusColorEnd = System.Drawing.Color.Empty
        Me.Final.Location = New System.Drawing.Point(230, 95)
        Me.Final.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Final.MaxLength = 7
        Me.Final.Name = "Final"
        Me.Final.RegraValidação = Nothing
        Me.Final.RegraValidaçãoMensagem = Nothing
        Me.Final.Size = New System.Drawing.Size(60, 20)
        Me.Final.TabIndex = 7
        Me.Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Final.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Final.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(171, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ch Final"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Inicial
        '
        Me.Inicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Inicial.CasasDecimais = 0
        Me.Inicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Inicial.CPObrigatorio = False
        Me.Inicial.CPObrigatorioMsg = Nothing
        Me.Inicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.Inicial.FocusColor = System.Drawing.Color.Empty
        Me.Inicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.Inicial.Location = New System.Drawing.Point(86, 92)
        Me.Inicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Inicial.MaxLength = 7
        Me.Inicial.Name = "Inicial"
        Me.Inicial.RegraValidação = Nothing
        Me.Inicial.RegraValidaçãoMensagem = Nothing
        Me.Inicial.Size = New System.Drawing.Size(60, 20)
        Me.Inicial.TabIndex = 5
        Me.Inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Inicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Inicial.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(334, 141)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(75, 28)
        Me.Fechar.TabIndex = 9
        Me.Fechar.Text = "Fechar"
        '
        'btOK
        '
        Me.btOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btOK.Location = New System.Drawing.Point(253, 141)
        Me.btOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 28)
        Me.btOK.TabIndex = 8
        Me.btOK.Text = "OK"
        '
        'FolhaPgtoPegaContaCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(427, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.Fechar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Inicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Final)
        Me.Controls.Add(Me.BancoChequeConta)
        Me.Controls.Add(Me.BancoChequeDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BancoCheque)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoPegaContaCheque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pegar Conta e Cheque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoChequeConta As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BancoChequeDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BancoCheque As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Final As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Inicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btOK As DevComponents.DotNetBar.ButtonX
End Class
