<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoDefinirCompetencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoDefinirCompetencia))
        Me.Label2 = New System.Windows.Forms.Label
        Me.MesAno = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fechar = New System.Windows.Forms.Button
        Me.Definir = New System.Windows.Forms.Button
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mês e Ano de Competência"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MesAno
        '
        Me.MesAno.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.MesAno.CasasDecimais = 0
        Me.MesAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MesAno.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.MesAno.FocusColor = System.Drawing.Color.Empty
        Me.MesAno.FocusColorEnd = System.Drawing.Color.Empty
        Me.MesAno.Location = New System.Drawing.Point(173, 12)
        Me.MesAno.MaxLength = 7
        Me.MesAno.Name = "MesAno"
        Me.MesAno.RegraValidação = Nothing
        Me.MesAno.Size = New System.Drawing.Size(92, 20)
        Me.MesAno.TabIndex = 1
        Me.MesAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MesAno.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.MesAno.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(164, 38)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(101, 55)
        Me.Fechar.TabIndex = 3
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'Definir
        '
        Me.Definir.Image = CType(resources.GetObject("Definir.Image"), System.Drawing.Image)
        Me.Definir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Definir.Location = New System.Drawing.Point(57, 38)
        Me.Definir.Name = "Definir"
        Me.Definir.Size = New System.Drawing.Size(101, 55)
        Me.Definir.TabIndex = 2
        Me.Definir.Text = "Definir"
        Me.Definir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Definir.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Definir)
        Me.Fundo.Controls.Add(Me.MesAno)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(281, 106)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 4
        '
        'FolhaPgtoDefinirCompetencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(281, 106)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoDefinirCompetencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definir Mês e Ano de Copentência"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MesAno As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Definir As System.Windows.Forms.Button
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
