<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermissaoGet
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PermissaoGet))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btGetPostPermissao = New System.Windows.Forms.Label()
        Me.btVerificar = New DevComponents.DotNetBar.ButtonX()
        Me.btOK = New DevComponents.DotNetBar.ButtonX()
        Me.tIDRegistro = New System.Windows.Forms.Label()
        Me.tTela = New System.Windows.Forms.Label()
        Me.tUsuario = New System.Windows.Forms.Label()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.tLiberaçao = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btGetPostPermissao)
        Me.PanelEx1.Controls.Add(Me.btVerificar)
        Me.PanelEx1.Controls.Add(Me.btOK)
        Me.PanelEx1.Controls.Add(Me.tIDRegistro)
        Me.PanelEx1.Controls.Add(Me.tTela)
        Me.PanelEx1.Controls.Add(Me.tUsuario)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.tLiberaçao)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(515, 209)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btGetPostPermissao
        '
        Me.btGetPostPermissao.BackColor = System.Drawing.Color.Transparent
        Me.btGetPostPermissao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGetPostPermissao.Image = CType(resources.GetObject("btGetPostPermissao.Image"), System.Drawing.Image)
        Me.btGetPostPermissao.Location = New System.Drawing.Point(12, 139)
        Me.btGetPostPermissao.Name = "btGetPostPermissao"
        Me.btGetPostPermissao.Size = New System.Drawing.Size(37, 37)
        Me.btGetPostPermissao.TabIndex = 75
        Me.btGetPostPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btVerificar
        '
        Me.btVerificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVerificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVerificar.Location = New System.Drawing.Point(12, 179)
        Me.btVerificar.Name = "btVerificar"
        Me.btVerificar.Size = New System.Drawing.Size(205, 23)
        Me.btVerificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btVerificar.TabIndex = 73
        Me.btVerificar.Text = "Verificar Solicitação de Liberação"
        '
        'btOK
        '
        Me.btOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btOK.Location = New System.Drawing.Point(340, 179)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(85, 23)
        Me.btOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btOK.TabIndex = 72
        Me.btOK.Text = "OK"
        '
        'tIDRegistro
        '
        Me.tIDRegistro.BackColor = System.Drawing.Color.Transparent
        Me.tIDRegistro.Location = New System.Drawing.Point(12, 47)
        Me.tIDRegistro.Name = "tIDRegistro"
        Me.tIDRegistro.Size = New System.Drawing.Size(490, 19)
        Me.tIDRegistro.TabIndex = 71
        Me.tIDRegistro.Text = "Id Registro"
        Me.tIDRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tTela
        '
        Me.tTela.BackColor = System.Drawing.Color.Transparent
        Me.tTela.Location = New System.Drawing.Point(12, 28)
        Me.tTela.Name = "tTela"
        Me.tTela.Size = New System.Drawing.Size(490, 19)
        Me.tTela.TabIndex = 70
        Me.tTela.Text = "Tela"
        Me.tTela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tUsuario
        '
        Me.tUsuario.BackColor = System.Drawing.Color.Transparent
        Me.tUsuario.Location = New System.Drawing.Point(12, 9)
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(490, 19)
        Me.tUsuario.TabIndex = 69
        Me.tUsuario.Text = "Usuario"
        Me.tUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btFechar.Location = New System.Drawing.Point(431, 179)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 67
        Me.btFechar.Text = "Fechar"
        '
        'tLiberaçao
        '
        Me.tLiberaçao.BackColor = System.Drawing.Color.Transparent
        Me.tLiberaçao.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLiberaçao.Location = New System.Drawing.Point(11, 90)
        Me.tLiberaçao.Name = "tLiberaçao"
        Me.tLiberaçao.Size = New System.Drawing.Size(495, 37)
        Me.tLiberaçao.TabIndex = 64
        Me.tLiberaçao.Text = "Aguardando Liberação"
        Me.tLiberaçao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'PermissaoGet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PermissaoGet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aguardando... - T188"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tLiberaçao As System.Windows.Forms.Label
    Friend WithEvents tIDRegistro As System.Windows.Forms.Label
    Friend WithEvents tTela As System.Windows.Forms.Label
    Friend WithEvents tUsuario As System.Windows.Forms.Label
    Friend WithEvents btOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btVerificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btGetPostPermissao As System.Windows.Forms.Label
End Class
