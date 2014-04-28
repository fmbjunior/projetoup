<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoProcuraProdutoFind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoProcuraProdutoFind))
        Me.TxtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.btProcura = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtProcura
        '
        Me.TxtProcura.AceitaColarTexto = True
        Me.TxtProcura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TxtProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProcura.CasasDecimais = 2
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.CPObrigatorio = False
        Me.TxtProcura.CPObrigatorioMsg = ""
        Me.TxtProcura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TxtProcura.FlatBorder = False
        Me.TxtProcura.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TxtProcura.FocusColor = System.Drawing.Color.Empty
        Me.TxtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.TxtProcura.HighlightBorderOnEnter = False
        Me.TxtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TxtProcura.Location = New System.Drawing.Point(12, 35)
        Me.TxtProcura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProcura.MaxLength = 50
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.PreencherZeroEsqueda = False
        Me.TxtProcura.RegraValidação = ""
        Me.TxtProcura.RegraValidaçãoMensagem = ""
        Me.TxtProcura.Size = New System.Drawing.Size(342, 23)
        Me.TxtProcura.TabIndex = 11
        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.TxtProcura.ValorPadrao = Nothing
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btFechar.Location = New System.Drawing.Point(314, 63)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(40, 19)
        Me.btFechar.TabIndex = 22
        Me.btFechar.Text = "Fechar"
        Me.btFechar.Visible = False
        '
        'btProcura
        '
        Me.btProcura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btProcura.Image = CType(resources.GetObject("btProcura.Image"), System.Drawing.Image)
        Me.btProcura.Location = New System.Drawing.Point(360, 35)
        Me.btProcura.Name = "btProcura"
        Me.btProcura.Size = New System.Drawing.Size(28, 23)
        Me.btProcura.TabIndex = 24
        '
        'PedidoProcuraProdutoFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btFechar
        Me.ClientSize = New System.Drawing.Size(400, 94)
        Me.ControlBox = False
        Me.Controls.Add(Me.btProcura)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.TxtProcura)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PedidoProcuraProdutoFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Texto a Procurar - T173"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btProcura As System.Windows.Forms.Label
End Class
