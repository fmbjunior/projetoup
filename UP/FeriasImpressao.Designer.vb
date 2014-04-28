<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeriasImpressao
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.opt2 = New System.Windows.Forms.RadioButton
        Me.opt1 = New System.Windows.Forms.RadioButton
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Controls.Add(Me.btnSair)
        Me.PanelEx1.Controls.Add(Me.btnVisualizar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(284, 127)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.LightSkyBlue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Transparent
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 35
        Me.PanelEx1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt2)
        Me.GroupBox1.Controls.Add(Me.opt1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 62)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opções"
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(178, 29)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(85, 17)
        Me.opt2.TabIndex = 1
        Me.opt2.Text = "Férias pagas"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Checked = True
        Me.opt1.Location = New System.Drawing.Point(9, 29)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(118, 17)
        Me.opt1.TabIndex = 0
        Me.opt1.TabStop = True
        Me.opt1.Text = "Férias Programadas"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(142, 80)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(97, 37)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(33, 80)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(100, 37)
        Me.btnVisualizar.TabIndex = 3
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'FeriasImpressao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 127)
        Me.Controls.Add(Me.PanelEx1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FeriasImpressao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Férias"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
End Class
