<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministradorPW
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
        Me.components = New System.ComponentModel.Container
        Me.pw = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Ok = New System.Windows.Forms.Button
        Me.cancelar = New System.Windows.Forms.Button
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pw
        '
        Me.pw.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.pw.CasasDecimais = 2
        Me.pw.CPObrigatorio = False
        Me.pw.CPObrigatorioMsg = Nothing
        Me.pw.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.pw.FocusColor = System.Drawing.Color.Empty
        Me.pw.FocusColorEnd = System.Drawing.Color.Empty
        Me.pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw.Location = New System.Drawing.Point(12, 28)
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw.RegraValidação = Nothing
        Me.pw.RegraValidaçãoMensagem = Nothing
        Me.pw.Size = New System.Drawing.Size(126, 29)
        Me.pw.TabIndex = 0
        Me.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pw.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.pw.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Senha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'Ok
        '
        Me.Ok.Location = New System.Drawing.Point(12, 73)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(59, 36)
        Me.Ok.TabIndex = 1
        Me.Ok.Text = "Ok"
        Me.Ok.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(77, 73)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(57, 36)
        Me.cancelar.TabIndex = 2
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'AdministradorPW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(149, 118)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "AdministradorPW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pw As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cancelar As System.Windows.Forms.Button
    Friend WithEvents Ok As System.Windows.Forms.Button
End Class
