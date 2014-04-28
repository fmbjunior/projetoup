<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaixaRepasseCheque
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaixaRepasseCheque))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btFazerRepasse = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TotalRepassar = New System.Windows.Forms.Label()
        Me.CaixaRepassar = New CBOAutoCompleteFocus.CboFocus()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListaCheque = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.xCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xTitular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xVencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Repassar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.ListaCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btFazerRepasse)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.ListaCheque)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(894, 691)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btFazerRepasse
        '
        Me.btFazerRepasse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFazerRepasse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFazerRepasse.Location = New System.Drawing.Point(690, 659)
        Me.btFazerRepasse.Name = "btFazerRepasse"
        Me.btFazerRepasse.Size = New System.Drawing.Size(107, 25)
        Me.btFazerRepasse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFazerRepasse.TabIndex = 81
        Me.btFazerRepasse.Text = "Fazer Repasse"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TotalRepassar)
        Me.GroupPanel1.Controls.Add(Me.CaixaRepassar)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 9)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(870, 59)
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
        Me.GroupPanel1.TabIndex = 80
        Me.GroupPanel1.Text = "Informações do Repasse"
        '
        'TotalRepassar
        '
        Me.TotalRepassar.BackColor = System.Drawing.Color.Transparent
        Me.TotalRepassar.Location = New System.Drawing.Point(731, 4)
        Me.TotalRepassar.Name = "TotalRepassar"
        Me.TotalRepassar.Size = New System.Drawing.Size(119, 19)
        Me.TotalRepassar.TabIndex = 83
        Me.TotalRepassar.Text = "00,00"
        Me.TotalRepassar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CaixaRepassar
        '
        Me.CaixaRepassar.Auto_Complete = True
        Me.CaixaRepassar.AutoLimitar_Lista = True
        Me.CaixaRepassar.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.CaixaRepassar.CPObrigatorio = False
        Me.CaixaRepassar.CPObrigatorioMsg = Nothing
        Me.CaixaRepassar.FlatBorder = False
        Me.CaixaRepassar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CaixaRepassar.FormattingEnabled = True
        Me.CaixaRepassar.HighlightBorderColor = System.Drawing.Color.Empty
        Me.CaixaRepassar.HighlightBorderOnEnter = False
        Me.CaixaRepassar.Location = New System.Drawing.Point(114, 3)
        Me.CaixaRepassar.Name = "CaixaRepassar"
        Me.CaixaRepassar.Size = New System.Drawing.Size(218, 23)
        Me.CaixaRepassar.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(643, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Total Repassar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(7, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 19)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Caixa Repassar"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListaCheque
        '
        Me.ListaCheque.AllowUserToAddRows = False
        Me.ListaCheque.AllowUserToDeleteRows = False
        Me.ListaCheque.AllowUserToResizeColumns = False
        Me.ListaCheque.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.ListaCheque.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaCheque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Img, Me.xCheque, Me.xCC, Me.xCliente, Me.xTitular, Me.xValor, Me.xVencimento, Me.Repassar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaCheque.DefaultCellStyle = DataGridViewCellStyle3
        Me.ListaCheque.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ListaCheque.Location = New System.Drawing.Point(12, 74)
        Me.ListaCheque.MultiSelect = False
        Me.ListaCheque.Name = "ListaCheque"
        Me.ListaCheque.RowHeadersVisible = False
        Me.ListaCheque.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaCheque.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListaCheque.SelectAllSignVisible = False
        Me.ListaCheque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaCheque.Size = New System.Drawing.Size(870, 579)
        Me.ListaCheque.TabIndex = 31
        '
        'Img
        '
        Me.Img.HeaderText = ""
        Me.Img.Image = CType(resources.GetObject("Img.Image"), System.Drawing.Image)
        Me.Img.Name = "Img"
        Me.Img.Width = 30
        '
        'xCheque
        '
        Me.xCheque.DataPropertyName = "Cheque"
        Me.xCheque.HeaderText = "Cheque"
        Me.xCheque.Name = "xCheque"
        Me.xCheque.Width = 85
        '
        'xCC
        '
        Me.xCC.DataPropertyName = "CC"
        Me.xCC.HeaderText = "CC"
        Me.xCC.Name = "xCC"
        Me.xCC.Width = 85
        '
        'xCliente
        '
        Me.xCliente.DataPropertyName = "Nome"
        Me.xCliente.HeaderText = "Cliente"
        Me.xCliente.Name = "xCliente"
        Me.xCliente.Width = 200
        '
        'xTitular
        '
        Me.xTitular.DataPropertyName = "Titular"
        Me.xTitular.HeaderText = "Titular"
        Me.xTitular.Name = "xTitular"
        Me.xTitular.Width = 200
        '
        'xValor
        '
        Me.xValor.DataPropertyName = "ValorCh"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.xValor.DefaultCellStyle = DataGridViewCellStyle2
        Me.xValor.HeaderText = "Valor"
        Me.xValor.Name = "xValor"
        '
        'xVencimento
        '
        Me.xVencimento.DataPropertyName = "Vencimento"
        Me.xVencimento.HeaderText = "Vencimento"
        Me.xVencimento.Name = "xVencimento"
        Me.xVencimento.Width = 90
        '
        'Repassar
        '
        Me.Repassar.HeaderText = "Repassar"
        Me.Repassar.Name = "Repassar"
        Me.Repassar.Width = 55
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(803, 659)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(79, 25)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 0
        Me.btFechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'CaixaRepasseCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 691)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "CaixaRepasseCheque"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repasse de Cheque do Caixa - T107"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.ListaCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ListaCheque As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CaixaRepassar As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TotalRepassar As System.Windows.Forms.Label
    Friend WithEvents btFazerRepasse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents xCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xCC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xTitular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xVencimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Repassar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
