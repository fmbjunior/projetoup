<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermissaoPost
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
        Me.tRestante = New System.Windows.Forms.Label()
        Me.tDataHora = New System.Windows.Forms.Label()
        Me.tIDRegistro = New System.Windows.Forms.Label()
        Me.tTela = New System.Windows.Forms.Label()
        Me.tUsuario = New System.Windows.Forms.Label()
        Me.btEnviar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Motivo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.tRestante)
        Me.PanelEx1.Controls.Add(Me.tDataHora)
        Me.PanelEx1.Controls.Add(Me.tIDRegistro)
        Me.PanelEx1.Controls.Add(Me.tTela)
        Me.PanelEx1.Controls.Add(Me.tUsuario)
        Me.PanelEx1.Controls.Add(Me.btEnviar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Motivo)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(515, 273)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'tRestante
        '
        Me.tRestante.BackColor = System.Drawing.Color.Transparent
        Me.tRestante.Location = New System.Drawing.Point(12, 238)
        Me.tRestante.Name = "tRestante"
        Me.tRestante.Size = New System.Drawing.Size(137, 19)
        Me.tRestante.TabIndex = 73
        Me.tRestante.Text = "Texto Restante: 150"
        Me.tRestante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tDataHora
        '
        Me.tDataHora.BackColor = System.Drawing.Color.Transparent
        Me.tDataHora.Location = New System.Drawing.Point(13, 66)
        Me.tDataHora.Name = "tDataHora"
        Me.tDataHora.Size = New System.Drawing.Size(490, 19)
        Me.tDataHora.TabIndex = 72
        Me.tDataHora.Text = "Data e Hora"
        Me.tDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'btEnviar
        '
        Me.btEnviar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEnviar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEnviar.Location = New System.Drawing.Point(284, 238)
        Me.btEnviar.Name = "btEnviar"
        Me.btEnviar.Size = New System.Drawing.Size(141, 23)
        Me.btEnviar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEnviar.TabIndex = 68
        Me.btEnviar.Text = "Enviar a Solicitação"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(431, 238)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 67
        Me.btFechar.Text = "Fechar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Informe o Motivo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Motivo
        '
        Me.Motivo.AceitaColarTexto = True
        Me.Motivo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Motivo.CasasDecimais = 0
        Me.Motivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Motivo.CPObrigatorio = False
        Me.Motivo.CPObrigatorioMsg = Nothing
        Me.Motivo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Motivo.FlatBorder = False
        Me.Motivo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Motivo.FocusColor = System.Drawing.Color.Empty
        Me.Motivo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Motivo.HighlightBorderOnEnter = False
        Me.Motivo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Motivo.Location = New System.Drawing.Point(15, 155)
        Me.Motivo.MaxLength = 150
        Me.Motivo.Multiline = True
        Me.Motivo.Name = "Motivo"
        Me.Motivo.PreencherZeroEsqueda = False
        Me.Motivo.RegraValidação = Nothing
        Me.Motivo.RegraValidaçãoMensagem = Nothing
        Me.Motivo.Size = New System.Drawing.Size(493, 65)
        Me.Motivo.TabIndex = 65
        Me.Motivo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Motivo.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(493, 43)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Descreva o motivo informado o maximo de detalhes  EX: Número Pedido, Valor errado" & _
    ",  Valor correto, Número da Nota etc.."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PermissaoPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PermissaoPost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitar Permissão - T190"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btEnviar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Motivo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents tDataHora As System.Windows.Forms.Label
    Friend WithEvents tIDRegistro As System.Windows.Forms.Label
    Friend WithEvents tTela As System.Windows.Forms.Label
    Friend WithEvents tUsuario As System.Windows.Forms.Label
    Friend WithEvents tRestante As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
