<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelServicoGrupo
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txtB = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtA = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butfechar = New DevComponents.DotNetBar.ButtonX()
        Me.butImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtB)
        Me.PanelEx1.Controls.Add(Me.txtA)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.butfechar)
        Me.PanelEx1.Controls.Add(Me.butImprimir)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(315, 131)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.AceitaColarTexto = True
        Me.txtB.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtB.CasasDecimais = 2
        Me.txtB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtB.CPObrigatorio = False
        Me.txtB.CPObrigatorioMsg = Nothing
        Me.txtB.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtB.FlatBorder = False
        Me.txtB.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtB.FocusColor = System.Drawing.Color.Empty
        Me.txtB.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtB.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.HighlightBorderOnEnter = False
        Me.txtB.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtB.Location = New System.Drawing.Point(175, 40)
        Me.txtB.MaxLength = 10
        Me.txtB.Name = "txtB"
        Me.txtB.PreencherZeroEsqueda = False
        Me.txtB.RegraValidação = Nothing
        Me.txtB.RegraValidaçãoMensagem = Nothing
        Me.txtB.Size = New System.Drawing.Size(117, 23)
        Me.txtB.TabIndex = 1
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtB.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtB.ValorPadrao = Nothing
        '
        'txtA
        '
        Me.txtA.AceitaColarTexto = True
        Me.txtA.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtA.CasasDecimais = 2
        Me.txtA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtA.CPObrigatorio = False
        Me.txtA.CPObrigatorioMsg = Nothing
        Me.txtA.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtA.FlatBorder = False
        Me.txtA.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtA.FocusColor = System.Drawing.Color.Empty
        Me.txtA.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtA.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.HighlightBorderOnEnter = False
        Me.txtA.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtA.Location = New System.Drawing.Point(31, 40)
        Me.txtA.MaxLength = 10
        Me.txtA.Name = "txtA"
        Me.txtA.PreencherZeroEsqueda = False
        Me.txtA.RegraValidação = Nothing
        Me.txtA.RegraValidaçãoMensagem = Nothing
        Me.txtA.Size = New System.Drawing.Size(117, 23)
        Me.txtA.TabIndex = 0
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtA.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.txtA.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Inicial e Data Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'butfechar
        '
        Me.butfechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butfechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butfechar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butfechar.Location = New System.Drawing.Point(175, 86)
        Me.butfechar.Name = "butfechar"
        Me.butfechar.Size = New System.Drawing.Size(117, 30)
        Me.butfechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butfechar.TabIndex = 4
        Me.butfechar.Text = "Fechar"
        '
        'butImprimir
        '
        Me.butImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butImprimir.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butImprimir.Location = New System.Drawing.Point(31, 86)
        Me.butImprimir.Name = "butImprimir"
        Me.butImprimir.Size = New System.Drawing.Size(117, 30)
        Me.butImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butImprimir.TabIndex = 3
        Me.butImprimir.Text = "Imprimir"
        '
        'RelServicoGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 131)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RelServicoGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Serviços Por Grupo - T239"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents butImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtB As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtA As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butfechar As DevComponents.DotNetBar.ButtonX
End Class
