<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditoriaFiltro
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
        Me.Filtro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btOK = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Filtro
        '
        Me.Filtro.BackColor = System.Drawing.Color.White
        Me.Filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Filtro.Location = New System.Drawing.Point(12, 33)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(398, 20)
        Me.Filtro.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Texto a Filtrar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btOK
        '
        Me.btOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btOK.Location = New System.Drawing.Point(335, 59)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 23)
        Me.btOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btOK.TabIndex = 18
        Me.btOK.Text = "OK"
        '
        'AuditoriaFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(423, 96)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.Filtro)
        Me.Controls.Add(Me.Label6)
        Me.Name = "AuditoriaFiltro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuditoriaFiltro - T090"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btOK As DevComponents.DotNetBar.ButtonX
End Class
