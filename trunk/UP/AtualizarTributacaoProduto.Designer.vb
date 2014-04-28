<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtualizarTributacaoProduto
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCofins = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpis = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtncm = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fundo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.GroupBox2)
        Me.Fundo.Controls.Add(Me.GroupBox1)
        Me.Fundo.Controls.Add(Me.btAtualizar)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(335, 178)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCofins)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtpis)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 81)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Campos a serem atualizados"
        '
        'txtCofins
        '
        Me.txtCofins.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtCofins.AceitaColarTexto = True
        Me.txtCofins.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtCofins.CasasDecimais = 2
        Me.txtCofins.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCofins.CPObrigatorio = False
        Me.txtCofins.CPObrigatorioMsg = Nothing
        Me.txtCofins.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtCofins.FlatBorder = False
        Me.txtCofins.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtCofins.FocusColor = System.Drawing.Color.Empty
        Me.txtCofins.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtCofins.HighlightBorderOnEnter = False
        Me.txtCofins.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtCofins.Location = New System.Drawing.Point(155, 45)
        Me.txtCofins.MaxLength = 3
        Me.txtCofins.Name = "txtCofins"
        Me.txtCofins.PreencherZeroEsqueda = False
        Me.txtCofins.RegraValidação = Nothing
        Me.txtCofins.RegraValidaçãoMensagem = Nothing
        Me.txtCofins.Size = New System.Drawing.Size(143, 20)
        Me.txtCofins.TabIndex = 1
        Me.txtCofins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCofins.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtCofins.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cst Cofins - Venda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpis
        '
        Me.txtpis.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtpis.AceitaColarTexto = True
        Me.txtpis.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtpis.CasasDecimais = 2
        Me.txtpis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpis.CPObrigatorio = False
        Me.txtpis.CPObrigatorioMsg = Nothing
        Me.txtpis.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtpis.FlatBorder = False
        Me.txtpis.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtpis.FocusColor = System.Drawing.Color.Empty
        Me.txtpis.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtpis.HighlightBorderOnEnter = False
        Me.txtpis.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtpis.Location = New System.Drawing.Point(155, 19)
        Me.txtpis.MaxLength = 3
        Me.txtpis.Name = "txtpis"
        Me.txtpis.PreencherZeroEsqueda = False
        Me.txtpis.RegraValidação = Nothing
        Me.txtpis.RegraValidaçãoMensagem = Nothing
        Me.txtpis.Size = New System.Drawing.Size(143, 20)
        Me.txtpis.TabIndex = 0
        Me.txtpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpis.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtpis.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cst Pis - Venda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtncm)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fitrar Por"
        '
        'txtncm
        '
        Me.txtncm.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtncm.AceitaColarTexto = True
        Me.txtncm.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtncm.CasasDecimais = 0
        Me.txtncm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtncm.CPObrigatorio = False
        Me.txtncm.CPObrigatorioMsg = Nothing
        Me.txtncm.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtncm.FlatBorder = False
        Me.txtncm.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtncm.FocusColor = System.Drawing.Color.Empty
        Me.txtncm.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtncm.HighlightBorderOnEnter = False
        Me.txtncm.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtncm.Location = New System.Drawing.Point(154, 15)
        Me.txtncm.MaxLength = 8
        Me.txtncm.Name = "txtncm"
        Me.txtncm.PreencherZeroEsqueda = False
        Me.txtncm.RegraValidação = Nothing
        Me.txtncm.RegraValidaçãoMensagem = Nothing
        Me.txtncm.Size = New System.Drawing.Size(143, 20)
        Me.txtncm.TabIndex = 1
        Me.txtncm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtncm.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtncm.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Digite o NCM--------->"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Location = New System.Drawing.Point(128, 138)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(93, 29)
        Me.btAtualizar.TabIndex = 2
        Me.btAtualizar.Text = "Atualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(236, 138)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(83, 29)
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AtualizarTributacaoProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AtualizarTributacaoProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atualizar Tributação - T269"
        Me.Fundo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtpis As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtncm As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCofins As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
