<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermissoesCopiarDe
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.UsuarioNovo = New CBOAutoCompleteFocus.CboFocus()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCopiar = New DevComponents.DotNetBar.ButtonX()
        Me.UsuarioCopiar = New CBOAutoCompleteFocus.CboFocus()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.UsuarioNovo)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.btCopiar)
        Me.PanelEx1.Controls.Add(Me.UsuarioCopiar)
        Me.PanelEx1.Controls.Add(Me.Label30)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(435, 213)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'UsuarioNovo
        '
        Me.UsuarioNovo.Auto_Complete = True
        Me.UsuarioNovo.AutoLimitar_Lista = True
        Me.UsuarioNovo.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.UsuarioNovo.CPObrigatorio = False
        Me.UsuarioNovo.CPObrigatorioMsg = Nothing
        Me.UsuarioNovo.FlatBorder = False
        Me.UsuarioNovo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UsuarioNovo.FormattingEnabled = True
        Me.UsuarioNovo.HighlightBorderColor = System.Drawing.Color.Empty
        Me.UsuarioNovo.HighlightBorderOnEnter = False
        Me.UsuarioNovo.Location = New System.Drawing.Point(11, 123)
        Me.UsuarioNovo.Name = "UsuarioNovo"
        Me.UsuarioNovo.Size = New System.Drawing.Size(412, 23)
        Me.UsuarioNovo.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Para qual usuário iremos copiar as Permissões ?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btCopiar
        '
        Me.btCopiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCopiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCopiar.Location = New System.Drawing.Point(267, 179)
        Me.btCopiar.Name = "btCopiar"
        Me.btCopiar.Size = New System.Drawing.Size(75, 23)
        Me.btCopiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btCopiar.TabIndex = 30
        Me.btCopiar.Text = "Copiar"
        '
        'UsuarioCopiar
        '
        Me.UsuarioCopiar.Auto_Complete = True
        Me.UsuarioCopiar.AutoLimitar_Lista = True
        Me.UsuarioCopiar.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.UsuarioCopiar.CPObrigatorio = False
        Me.UsuarioCopiar.CPObrigatorioMsg = Nothing
        Me.UsuarioCopiar.FlatBorder = False
        Me.UsuarioCopiar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.UsuarioCopiar.FormattingEnabled = True
        Me.UsuarioCopiar.HighlightBorderColor = System.Drawing.Color.Empty
        Me.UsuarioCopiar.HighlightBorderOnEnter = False
        Me.UsuarioCopiar.Location = New System.Drawing.Point(12, 61)
        Me.UsuarioCopiar.Name = "UsuarioCopiar"
        Me.UsuarioCopiar.Size = New System.Drawing.Size(412, 23)
        Me.UsuarioCopiar.TabIndex = 29
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(12, 39)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(412, 19)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "De qual usuário iremos copiar as Permissões ?"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(348, 179)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 0
        Me.btFechar.Text = "Fechar"
        '
        'PermissoesCopiarDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 213)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PermissoesCopiarDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiar Permissões do Usuário - T192"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents UsuarioCopiar As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btCopiar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents UsuarioNovo As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
