<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpresaDiaTrabalho
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Domingo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Sabado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Sexta = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Quinta = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Quarta = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Terca = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Segunda = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.GroupPanel1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(383, 182)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 79
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "T053"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(214, 147)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 79
        Me.btSalvar.Text = "Salvar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(295, 147)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 78
        Me.btFechar.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Domingo)
        Me.GroupPanel1.Controls.Add(Me.Sabado)
        Me.GroupPanel1.Controls.Add(Me.Sexta)
        Me.GroupPanel1.Controls.Add(Me.Quinta)
        Me.GroupPanel1.Controls.Add(Me.Quarta)
        Me.GroupPanel1.Controls.Add(Me.Terca)
        Me.GroupPanel1.Controls.Add(Me.Segunda)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(358, 124)
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
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 77
        Me.GroupPanel1.Text = "Dias de Trabalho"
        '
        'Domingo
        '
        '
        '
        '
        Me.Domingo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Domingo.Location = New System.Drawing.Point(19, 71)
        Me.Domingo.Name = "Domingo"
        Me.Domingo.Size = New System.Drawing.Size(100, 23)
        Me.Domingo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Domingo.TabIndex = 6
        Me.Domingo.Text = "Domingo"
        '
        'Sabado
        '
        '
        '
        '
        Me.Sabado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Sabado.Location = New System.Drawing.Point(269, 42)
        Me.Sabado.Name = "Sabado"
        Me.Sabado.Size = New System.Drawing.Size(100, 23)
        Me.Sabado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Sabado.TabIndex = 5
        Me.Sabado.Text = "Sabado"
        '
        'Sexta
        '
        '
        '
        '
        Me.Sexta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Sexta.Location = New System.Drawing.Point(143, 42)
        Me.Sexta.Name = "Sexta"
        Me.Sexta.Size = New System.Drawing.Size(100, 23)
        Me.Sexta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Sexta.TabIndex = 4
        Me.Sexta.Text = "Sexta"
        '
        'Quinta
        '
        '
        '
        '
        Me.Quinta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Quinta.Location = New System.Drawing.Point(19, 42)
        Me.Quinta.Name = "Quinta"
        Me.Quinta.Size = New System.Drawing.Size(100, 23)
        Me.Quinta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Quinta.TabIndex = 3
        Me.Quinta.Text = "Quinta"
        '
        'Quarta
        '
        '
        '
        '
        Me.Quarta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Quarta.Location = New System.Drawing.Point(269, 20)
        Me.Quarta.Name = "Quarta"
        Me.Quarta.Size = New System.Drawing.Size(100, 16)
        Me.Quarta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Quarta.TabIndex = 2
        Me.Quarta.Text = "Quarta"
        '
        'Terca
        '
        '
        '
        '
        Me.Terca.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Terca.Location = New System.Drawing.Point(143, 13)
        Me.Terca.Name = "Terca"
        Me.Terca.Size = New System.Drawing.Size(100, 23)
        Me.Terca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Terca.TabIndex = 1
        Me.Terca.Text = "Terça"
        '
        'Segunda
        '
        '
        '
        '
        Me.Segunda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Segunda.Location = New System.Drawing.Point(19, 13)
        Me.Segunda.Name = "Segunda"
        Me.Segunda.Size = New System.Drawing.Size(100, 23)
        Me.Segunda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Segunda.TabIndex = 0
        Me.Segunda.Text = "Segunda"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'EmpresaDiaTrabalho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "EmpresaDiaTrabalho"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa DiaTrabalho -T053"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Segunda As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Domingo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Sabado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Sexta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Quinta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Quarta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Terca As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
