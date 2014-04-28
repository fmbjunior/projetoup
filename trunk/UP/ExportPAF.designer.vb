<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportPAF
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
        Me.mybarra = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnFindFolder = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtNumeroPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtPath = New TexBoxFocusNet.TextBoxFocusNet()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.btnExportar = New DevComponents.DotNetBar.ButtonX()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.mybarra)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.btnExportar)
        Me.PanelEx1.Controls.Add(Me.btnFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(380, 272)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'mybarra
        '
        '
        '
        '
        Me.mybarra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mybarra.Location = New System.Drawing.Point(10, 212)
        Me.mybarra.Name = "mybarra"
        Me.mybarra.Size = New System.Drawing.Size(358, 22)
        Me.mybarra.Step = 10
        Me.mybarra.TabIndex = 72
        Me.mybarra.Visible = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnFindFolder)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.Panel1)
        Me.GroupPanel1.Controls.Add(Me.txtPath)
        Me.GroupPanel1.Controls.Add(Me.opt3)
        Me.GroupPanel1.Controls.Add(Me.opt2)
        Me.GroupPanel1.Controls.Add(Me.opt1)
        Me.GroupPanel1.Location = New System.Drawing.Point(10, 11)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(357, 195)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.Style.TextTrimming = DevComponents.DotNetBar.eStyleTextTrimming.EllipsisWord
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 3
        Me.GroupPanel1.Text = "Painel de Opções"
        '
        'btnFindFolder
        '
        Me.btnFindFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFindFolder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFindFolder.Location = New System.Drawing.Point(311, 139)
        Me.btnFindFolder.Name = "btnFindFolder"
        Me.btnFindFolder.Size = New System.Drawing.Size(27, 23)
        Me.btnFindFolder.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.btnFindFolder.TabIndex = 3
        Me.btnFindFolder.Text = "..."
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 116)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(86, 18)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Local do Arquivo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.txtNumeroPedido)
        Me.Panel1.Location = New System.Drawing.Point(3, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 32)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Visible = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(14, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(99, 27)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Nº Pedido"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.AceitaColarTexto = True
        Me.txtNumeroPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtNumeroPedido.CasasDecimais = 2
        Me.txtNumeroPedido.CPObrigatorio = False
        Me.txtNumeroPedido.CPObrigatorioMsg = Nothing
        Me.txtNumeroPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtNumeroPedido.FlatBorder = False
        Me.txtNumeroPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtNumeroPedido.FocusColor = System.Drawing.Color.Empty
        Me.txtNumeroPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtNumeroPedido.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPedido.HighlightBorderOnEnter = False
        Me.txtNumeroPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtNumeroPedido.Location = New System.Drawing.Point(120, 4)
        Me.txtNumeroPedido.MaxLength = 15
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.PreencherZeroEsqueda = False
        Me.txtNumeroPedido.RegraValidação = Nothing
        Me.txtNumeroPedido.RegraValidaçãoMensagem = Nothing
        Me.txtNumeroPedido.Size = New System.Drawing.Size(97, 23)
        Me.txtNumeroPedido.TabIndex = 0
        Me.txtNumeroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumeroPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtNumeroPedido.ValorPadrao = Nothing
        '
        'txtPath
        '
        Me.txtPath.AceitaColarTexto = True
        Me.txtPath.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtPath.CasasDecimais = 2
        Me.txtPath.CPObrigatorio = False
        Me.txtPath.CPObrigatorioMsg = Nothing
        Me.txtPath.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtPath.FlatBorder = False
        Me.txtPath.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtPath.FocusColor = System.Drawing.Color.Empty
        Me.txtPath.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtPath.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.HighlightBorderOnEnter = False
        Me.txtPath.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtPath.Location = New System.Drawing.Point(3, 139)
        Me.txtPath.MaxLength = 15
        Me.txtPath.Name = "txtPath"
        Me.txtPath.PreencherZeroEsqueda = False
        Me.txtPath.ReadOnly = True
        Me.txtPath.RegraValidação = Nothing
        Me.txtPath.RegraValidaçãoMensagem = Nothing
        Me.txtPath.Size = New System.Drawing.Size(302, 23)
        Me.txtPath.TabIndex = 0
        Me.txtPath.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtPath.ValorPadrao = Nothing
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt3.Location = New System.Drawing.Point(3, 53)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(108, 19)
        Me.opt3.TabIndex = 1
        Me.opt3.Text = "Exportar Pedido"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt2.Location = New System.Drawing.Point(3, 28)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(118, 19)
        Me.opt2.TabIndex = 0
        Me.opt2.Text = "Exportar Produtos"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt1.Location = New System.Drawing.Point(3, 3)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(110, 19)
        Me.opt1.TabIndex = 0
        Me.opt1.Text = "Exportar Cliente"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportar.Location = New System.Drawing.Point(198, 240)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(82, 26)
        Me.btnExportar.TabIndex = 2
        Me.btnExportar.Text = "Exportar"
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFechar.Location = New System.Drawing.Point(286, 240)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(82, 26)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Fechar"
        '
        'ExportPAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ExportPAF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar PAF - T055"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnExportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNumeroPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPath As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btnFindFolder As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mybarra As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
