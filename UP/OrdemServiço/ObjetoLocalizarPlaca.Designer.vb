<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjetoLocalizarPlaca
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.txtprocura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Lcp1 = New System.Windows.Forms.Label()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.CodOjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeObjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacaVeiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datacad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Controls.Add(Me.txtprocura)
        Me.PanelEx1.Controls.Add(Me.Lcp1)
        Me.PanelEx1.Controls.Add(Me.DgvItem)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(746, 369)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "T032"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(634, 326)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(100, 31)
        Me.Fechar.TabIndex = 3
        Me.Fechar.Text = "Fechar"
        '
        'txtprocura
        '
        Me.txtprocura.AceitaColarTexto = True
        Me.txtprocura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtprocura.CasasDecimais = 0
        Me.txtprocura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprocura.CPObrigatorio = False
        Me.txtprocura.CPObrigatorioMsg = Nothing
        Me.txtprocura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtprocura.FlatBorder = False
        Me.txtprocura.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtprocura.FocusColor = System.Drawing.Color.MistyRose
        Me.txtprocura.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtprocura.HighlightBorderOnEnter = False
        Me.txtprocura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtprocura.Location = New System.Drawing.Point(56, 9)
        Me.txtprocura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtprocura.MaxLength = 40
        Me.txtprocura.Name = "txtprocura"
        Me.txtprocura.PreencherZeroEsqueda = False
        Me.txtprocura.RegraValidação = Nothing
        Me.txtprocura.RegraValidaçãoMensagem = Nothing
        Me.txtprocura.Size = New System.Drawing.Size(137, 20)
        Me.txtprocura.TabIndex = 0
        Me.txtprocura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtprocura.ValorPadrao = Nothing
        '
        'Lcp1
        '
        Me.Lcp1.Location = New System.Drawing.Point(11, 9)
        Me.Lcp1.Name = "Lcp1"
        Me.Lcp1.Size = New System.Drawing.Size(76, 19)
        Me.Lcp1.TabIndex = 2
        Me.Lcp1.Text = "Placa"
        Me.Lcp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.AllowUserToResizeColumns = False
        Me.DgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItem.BackgroundColor = System.Drawing.Color.White
        Me.DgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodOjeto, Me.idCliente, Me.Nome, Me.NomeObjeto, Me.PlacaVeiculo, Me.datacad})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(7, 36)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(727, 284)
        Me.DgvItem.TabIndex = 1
        '
        'CodOjeto
        '
        Me.CodOjeto.DataPropertyName = "codobjeto"
        Me.CodOjeto.HeaderText = "ID"
        Me.CodOjeto.Name = "CodOjeto"
        Me.CodOjeto.Visible = False
        '
        'idCliente
        '
        Me.idCliente.DataPropertyName = "codigocliente"
        Me.idCliente.HeaderText = "Cliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.Visible = False
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 250
        '
        'NomeObjeto
        '
        Me.NomeObjeto.DataPropertyName = "veiculo"
        Me.NomeObjeto.HeaderText = "Veiculo"
        Me.NomeObjeto.Name = "NomeObjeto"
        Me.NomeObjeto.Width = 250
        '
        'PlacaVeiculo
        '
        Me.PlacaVeiculo.DataPropertyName = "placa"
        Me.PlacaVeiculo.HeaderText = "Placa"
        Me.PlacaVeiculo.Name = "PlacaVeiculo"
        Me.PlacaVeiculo.Width = 120
        '
        'datacad
        '
        Me.datacad.DataPropertyName = "datacadastro"
        Me.datacad.HeaderText = "Data Cadastro"
        Me.datacad.Name = "datacad"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ObjetoLocalizarPlaca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ObjetoLocalizarPlaca"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Objeto Localizar - T223"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents txtprocura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Lcp1 As System.Windows.Forms.Label
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CodOjeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeObjeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacaVeiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datacad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
