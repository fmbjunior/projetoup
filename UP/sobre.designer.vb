<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sobre
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
        Me.Local = New System.Windows.Forms.Label
        Me.BDPrincipal = New System.Windows.Forms.Label
        Me.User = New System.Windows.Forms.Label
        Me.Versão = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Local
        '
        Me.Local.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Local.Location = New System.Drawing.Point(12, 9)
        Me.Local.Name = "Local"
        Me.Local.Size = New System.Drawing.Size(446, 21)
        Me.Local.TabIndex = 0
        Me.Local.Text = "Local"
        '
        'BDPrincipal
        '
        Me.BDPrincipal.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDPrincipal.Location = New System.Drawing.Point(12, 30)
        Me.BDPrincipal.Name = "BDPrincipal"
        Me.BDPrincipal.Size = New System.Drawing.Size(446, 21)
        Me.BDPrincipal.TabIndex = 1
        Me.BDPrincipal.Text = "BDPrincipal"
        '
        'User
        '
        Me.User.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(12, 51)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(446, 21)
        Me.User.TabIndex = 3
        Me.User.Text = "User"
        '
        'Versão
        '
        Me.Versão.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Versão.Location = New System.Drawing.Point(12, 72)
        Me.Versão.Name = "Versão"
        Me.Versão.Size = New System.Drawing.Size(446, 21)
        Me.Versão.TabIndex = 4
        Me.Versão.Text = "Versão"
        '
        'Sobre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(470, 266)
        Me.Controls.Add(Me.Versão)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.BDPrincipal)
        Me.Controls.Add(Me.Local)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Sobre"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sobre"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Local As System.Windows.Forms.Label
    Friend WithEvents BDPrincipal As System.Windows.Forms.Label
    Friend WithEvents User As System.Windows.Forms.Label
    Friend WithEvents Versão As System.Windows.Forms.Label
End Class
