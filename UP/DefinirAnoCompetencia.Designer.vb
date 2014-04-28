<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefinirAnoCompetencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DefinirAnoCompetencia))
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Label2 = New System.Windows.Forms.Label
        Me.Definir = New System.Windows.Forms.Button
        Me.AnoComp = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fechar = New System.Windows.Forms.Button
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Fundo.SuspendLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Definir)
        Me.Fundo.Controls.Add(Me.AnoComp)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(284, 161)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.CadetBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Digite o Ano da Competência"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Definir
        '
        Me.Definir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Definir.Image = CType(resources.GetObject("Definir.Image"), System.Drawing.Image)
        Me.Definir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Definir.Location = New System.Drawing.Point(12, 99)
        Me.Definir.Name = "Definir"
        Me.Definir.Size = New System.Drawing.Size(124, 55)
        Me.Definir.TabIndex = 1
        Me.Definir.Text = "Definir"
        Me.Definir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Definir.UseVisualStyleBackColor = True
        '
        'AnoComp
        '
        Me.AnoComp.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AnoComp.CasasDecimais = 0
        Me.AnoComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AnoComp.CPObrigatorio = False
        Me.AnoComp.CPObrigatorioMsg = Nothing
        Me.AnoComp.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AnoComp.FocusColor = System.Drawing.Color.Empty
        Me.AnoComp.FocusColorEnd = System.Drawing.Color.Empty
        Me.AnoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnoComp.Location = New System.Drawing.Point(81, 48)
        Me.AnoComp.MaxLength = 4
        Me.AnoComp.Name = "AnoComp"
        Me.AnoComp.RegraValidação = Nothing
        Me.AnoComp.RegraValidaçãoMensagem = Nothing
        Me.AnoComp.Size = New System.Drawing.Size(128, 32)
        Me.AnoComp.TabIndex = 0
        Me.AnoComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnoComp.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AnoComp.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(142, 99)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(130, 55)
        Me.Fechar.TabIndex = 2
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'DefinirAnoCompetencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DefinirAnoCompetencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definir Ano da Competência"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Definir As System.Windows.Forms.Button
    Friend WithEvents AnoComp As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
End Class
