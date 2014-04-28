<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellShoesResumoVenda
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
        Me.lblVendasHoje = New DevComponents.DotNetBar.LabelX()
        Me.btnfechar = New DevComponents.DotNetBar.ButtonX()
        Me.lblTotalVendas = New DevComponents.DotNetBar.LabelX()
        Me.lblVendedor = New DevComponents.DotNetBar.LabelX()
        Me.PainelGrupo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A = New TexBoxFocusNet.TextBoxFocusNet()
        Me.PanelEx1.SuspendLayout()
        Me.PainelGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.lblVendasHoje)
        Me.PanelEx1.Controls.Add(Me.btnfechar)
        Me.PanelEx1.Controls.Add(Me.lblTotalVendas)
        Me.PanelEx1.Controls.Add(Me.lblVendedor)
        Me.PanelEx1.Controls.Add(Me.PainelGrupo)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(454, 352)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'lblVendasHoje
        '
        Me.lblVendasHoje.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.lblVendasHoje.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblVendasHoje.BackgroundStyle.BorderColor = System.Drawing.SystemColors.Desktop
        Me.lblVendasHoje.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblVendasHoje.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblVendasHoje.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblVendasHoje.BackgroundStyle.Class = ""
        Me.lblVendasHoje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblVendasHoje.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendasHoje.ForeColor = System.Drawing.Color.Yellow
        Me.lblVendasHoje.Location = New System.Drawing.Point(3, 249)
        Me.lblVendasHoje.Name = "lblVendasHoje"
        Me.lblVendasHoje.Size = New System.Drawing.Size(448, 38)
        Me.lblVendasHoje.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.lblVendasHoje.TabIndex = 5
        Me.lblVendasHoje.Text = "0,00"
        Me.lblVendasHoje.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnfechar
        '
        Me.btnfechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnfechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnfechar.Location = New System.Drawing.Point(3, 297)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(448, 43)
        Me.btnfechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnfechar.TabIndex = 4
        Me.btnfechar.Text = "Fechar"
        '
        'lblTotalVendas
        '
        Me.lblTotalVendas.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.lblTotalVendas.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblTotalVendas.BackgroundStyle.BorderColor = System.Drawing.SystemColors.Desktop
        Me.lblTotalVendas.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblTotalVendas.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblTotalVendas.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblTotalVendas.BackgroundStyle.Class = ""
        Me.lblTotalVendas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalVendas.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVendas.ForeColor = System.Drawing.Color.Yellow
        Me.lblTotalVendas.Location = New System.Drawing.Point(3, 205)
        Me.lblTotalVendas.Name = "lblTotalVendas"
        Me.lblTotalVendas.Size = New System.Drawing.Size(448, 38)
        Me.lblTotalVendas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.lblTotalVendas.TabIndex = 3
        Me.lblTotalVendas.Text = "0,00"
        Me.lblTotalVendas.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblVendedor
        '
        Me.lblVendedor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblVendedor.BackgroundStyle.Class = ""
        Me.lblVendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblVendedor.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(3, 163)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(448, 38)
        Me.lblVendedor.TabIndex = 3
        Me.lblVendedor.Text = "Vendedor"
        Me.lblVendedor.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PainelGrupo
        '
        Me.PainelGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PainelGrupo.Controls.Add(Me.Label2)
        Me.PainelGrupo.Controls.Add(Me.Label1)
        Me.PainelGrupo.Controls.Add(Me.B)
        Me.PainelGrupo.Controls.Add(Me.A)
        Me.PainelGrupo.Location = New System.Drawing.Point(3, 14)
        Me.PainelGrupo.Name = "PainelGrupo"
        Me.PainelGrupo.Size = New System.Drawing.Size(448, 146)
        Me.PainelGrupo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Data Final"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Inicial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'B
        '
        Me.B.AceitaColarTexto = True
        Me.B.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.B.CasasDecimais = 0
        Me.B.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.B.CPObrigatorio = False
        Me.B.CPObrigatorioMsg = Nothing
        Me.B.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.B.FlatBorder = False
        Me.B.FlatBorderColor = System.Drawing.Color.DimGray
        Me.B.FocusColor = System.Drawing.Color.Empty
        Me.B.FocusColorEnd = System.Drawing.Color.Empty
        Me.B.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B.HighlightBorderOnEnter = False
        Me.B.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.B.Location = New System.Drawing.Point(182, 60)
        Me.B.MaxLength = 10
        Me.B.Name = "B"
        Me.B.PreencherZeroEsqueda = False
        Me.B.RegraValidação = Nothing
        Me.B.RegraValidaçãoMensagem = Nothing
        Me.B.Size = New System.Drawing.Size(219, 37)
        Me.B.TabIndex = 1
        Me.B.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.B.ValorPadrao = Nothing
        '
        'A
        '
        Me.A.AceitaColarTexto = True
        Me.A.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.A.CasasDecimais = 0
        Me.A.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.A.CPObrigatorio = False
        Me.A.CPObrigatorioMsg = Nothing
        Me.A.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.A.FlatBorder = False
        Me.A.FlatBorderColor = System.Drawing.Color.DimGray
        Me.A.FocusColor = System.Drawing.Color.Empty
        Me.A.FocusColorEnd = System.Drawing.Color.Empty
        Me.A.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A.HighlightBorderOnEnter = False
        Me.A.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.A.Location = New System.Drawing.Point(182, 15)
        Me.A.MaxLength = 10
        Me.A.Name = "A"
        Me.A.PreencherZeroEsqueda = False
        Me.A.RegraValidação = Nothing
        Me.A.RegraValidaçãoMensagem = Nothing
        Me.A.Size = New System.Drawing.Size(219, 37)
        Me.A.TabIndex = 1
        Me.A.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.A.ValorPadrao = Nothing
        '
        'SellShoesResumoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SellShoesResumoVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumo Vendas - T258"
        Me.PanelEx1.ResumeLayout(False)
        Me.PainelGrupo.ResumeLayout(False)
        Me.PainelGrupo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PainelGrupo As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents A As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents B As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents lblVendedor As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnfechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTotalVendas As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblVendasHoje As DevComponents.DotNetBar.LabelX
End Class
