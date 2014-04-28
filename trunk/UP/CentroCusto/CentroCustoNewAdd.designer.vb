<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentroCustoNewAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CentroCustoNewAdd))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Conta = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.btConfirmar = New System.Windows.Forms.Button()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição da Conta"
        '
        'Descricao
        '
        Me.Descricao.AceitaColarTexto = True
        Me.Descricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Descricao.CasasDecimais = 0
        Me.Descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descricao.CPObrigatorio = False
        Me.Descricao.CPObrigatorioMsg = Nothing
        Me.Descricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Descricao.FlatBorder = False
        Me.Descricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Descricao.FocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Descricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descricao.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descricao.HighlightBorderOnEnter = False
        Me.Descricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Descricao.Location = New System.Drawing.Point(12, 33)
        Me.Descricao.MaxLength = 50
        Me.Descricao.Name = "Descricao"
        Me.Descricao.PreencherZeroEsqueda = False
        Me.Descricao.RegraValidação = Nothing
        Me.Descricao.RegraValidaçãoMensagem = Nothing
        Me.Descricao.Size = New System.Drawing.Size(315, 21)
        Me.Descricao.TabIndex = 2
        Me.Descricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descricao.ValorPadrao = Nothing
        '
        'Conta
        '
        Me.Conta.AceitaColarTexto = True
        Me.Conta.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Conta.CasasDecimais = 2
        Me.Conta.CPObrigatorio = False
        Me.Conta.CPObrigatorioMsg = Nothing
        Me.Conta.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Conta.FlatBorder = False
        Me.Conta.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Conta.FocusColor = System.Drawing.Color.Empty
        Me.Conta.FocusColorEnd = System.Drawing.Color.Empty
        Me.Conta.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Conta.HighlightBorderOnEnter = False
        Me.Conta.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Conta.Location = New System.Drawing.Point(12, 70)
        Me.Conta.Name = "Conta"
        Me.Conta.PreencherZeroEsqueda = False
        Me.Conta.RegraValidação = Nothing
        Me.Conta.RegraValidaçãoMensagem = Nothing
        Me.Conta.Size = New System.Drawing.Size(81, 23)
        Me.Conta.TabIndex = 7
        Me.Conta.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Conta.ValorPadrao = Nothing
        Me.Conta.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.btConfirmar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Descricao)
        Me.Fundo.Controls.Add(Me.Conta)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(338, 116)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'btConfirmar
        '
        Me.btConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btConfirmar.Image = CType(resources.GetObject("btConfirmar.Image"), System.Drawing.Image)
        Me.btConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btConfirmar.Location = New System.Drawing.Point(138, 69)
        Me.btConfirmar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(97, 33)
        Me.btConfirmar.TabIndex = 13
        Me.btConfirmar.Text = "Confirmar"
        Me.btConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btConfirmar.UseVisualStyleBackColor = True
        '
        'btFechar
        '
        Me.btFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btFechar.Location = New System.Drawing.Point(242, 69)
        Me.btFechar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(85, 33)
        Me.btFechar.TabIndex = 12
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'CentroCustoNewAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 116)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "CentroCustoNewAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Contas do Centro de Custo"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Descricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Conta As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents btConfirmar As System.Windows.Forms.Button
End Class
