<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CriaAnoContabil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CriaAnoContabil))
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Label2 = New System.Windows.Forms.Label
        Me.CriarTabela = New System.Windows.Forms.Button
        Me.NomeTabela = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fechar = New System.Windows.Forms.Button
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.CriarTabela)
        Me.Fundo.Controls.Add(Me.NomeTabela)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(284, 165)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.CadetBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Digite o nome da Tabela para Criá-la"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CriarTabela
        '
        Me.CriarTabela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CriarTabela.Image = CType(resources.GetObject("CriarTabela.Image"), System.Drawing.Image)
        Me.CriarTabela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CriarTabela.Location = New System.Drawing.Point(12, 99)
        Me.CriarTabela.Name = "CriarTabela"
        Me.CriarTabela.Size = New System.Drawing.Size(124, 55)
        Me.CriarTabela.TabIndex = 2
        Me.CriarTabela.Text = "Criar Tabela"
        Me.CriarTabela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CriarTabela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CriarTabela.UseVisualStyleBackColor = True
        '
        'NomeTabela
        '
        Me.NomeTabela.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeTabela.CasasDecimais = 0
        Me.NomeTabela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeTabela.CPObrigatorio = False
        Me.NomeTabela.CPObrigatorioMsg = Nothing
        Me.NomeTabela.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeTabela.FocusColor = System.Drawing.Color.Empty
        Me.NomeTabela.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeTabela.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTabela.Location = New System.Drawing.Point(81, 48)
        Me.NomeTabela.MaxLength = 4
        Me.NomeTabela.Name = "NomeTabela"
        Me.NomeTabela.RegraValidação = Nothing
        Me.NomeTabela.RegraValidaçãoMensagem = Nothing
        Me.NomeTabela.Size = New System.Drawing.Size(128, 32)
        Me.NomeTabela.TabIndex = 1
        Me.NomeTabela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NomeTabela.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeTabela.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(142, 99)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(130, 55)
        Me.Fechar.TabIndex = 3
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'CriaAnoContabil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CriaAnoContabil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criar Ano Contábil"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CriarTabela As System.Windows.Forms.Button
    Friend WithEvents NomeTabela As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fechar As System.Windows.Forms.Button
End Class
