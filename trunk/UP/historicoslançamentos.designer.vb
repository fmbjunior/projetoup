<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricosLançamentos
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
        Me.Display = New System.Windows.Forms.Label
        Me.Hist = New TexBoxFocusNet.TextBoxFocusNet
        Me.Confirmar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Display
        '
        Me.Display.Location = New System.Drawing.Point(12, -1)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(398, 20)
        Me.Display.TabIndex = 54
        Me.Display.Text = "Histórico"
        Me.Display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Hist
        '
        Me.Hist.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Hist.CasasDecimais = 0
        Me.Hist.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Hist.CPObrigatorio = False
        Me.Hist.CPObrigatorioMsg = Nothing
        Me.Hist.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Hist.FocusColor = System.Drawing.Color.Empty
        Me.Hist.FocusColorEnd = System.Drawing.Color.Empty
        Me.Hist.Location = New System.Drawing.Point(12, 22)
        Me.Hist.MaxLength = 120
        Me.Hist.Multiline = True
        Me.Hist.Name = "Hist"
        Me.Hist.RegraValidação = Nothing
        Me.Hist.RegraValidaçãoMensagem = Nothing
        Me.Hist.Size = New System.Drawing.Size(398, 87)
        Me.Hist.TabIndex = 55
        Me.Hist.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Hist.ValorPadrao = Nothing
        '
        'Confirmar
        '
        Me.Confirmar.FlatAppearance.BorderSize = 0
        Me.Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Confirmar.Image = Global.Up.My.Resources.Resources.Confirmar
        Me.Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Confirmar.Location = New System.Drawing.Point(307, 116)
        Me.Confirmar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Confirmar.Name = "Confirmar"
        Me.Confirmar.Size = New System.Drawing.Size(103, 39)
        Me.Confirmar.TabIndex = 56
        Me.Confirmar.Text = "&Confirmar"
        Me.Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Confirmar.UseVisualStyleBackColor = True
        '
        'HistoricosLançamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(422, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.Confirmar)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.Hist)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HistoricosLançamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historicos de Lançamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Display As System.Windows.Forms.Label
    Friend WithEvents Hist As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Confirmar As System.Windows.Forms.Button
End Class
