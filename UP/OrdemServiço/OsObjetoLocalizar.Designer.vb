<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OsObjetoLocalizar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.CodOjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PanelEx1.Controls.Add(Me.txtProcura)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Controls.Add(Me.DgvItem)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(984, 566)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'txtProcura
        '
        Me.txtProcura.AceitaColarTexto = True
        Me.txtProcura.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtProcura.CasasDecimais = 0
        Me.txtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcura.CPObrigatorio = False
        Me.txtProcura.CPObrigatorioMsg = Nothing
        Me.txtProcura.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtProcura.FlatBorder = False
        Me.txtProcura.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtProcura.FocusColor = System.Drawing.Color.Empty
        Me.txtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtProcura.HighlightBorderOnEnter = False
        Me.txtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtProcura.Location = New System.Drawing.Point(15, 537)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.Size = New System.Drawing.Size(529, 20)
        Me.txtProcura.TabIndex = 8
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 518)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Procurar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(902, 537)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(70, 26)
        Me.Fechar.TabIndex = 3
        Me.Fechar.Text = "Fechar"
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.AllowUserToResizeColumns = False
        Me.DgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvItem.BackgroundColor = System.Drawing.Color.White
        Me.DgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodOjeto, Me.CP2, Me.CP1, Me.idCliente, Me.Nome, Me.datacad})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(12, 21)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(959, 494)
        Me.DgvItem.TabIndex = 2
        '
        'CodOjeto
        '
        Me.CodOjeto.DataPropertyName = "codobjeto"
        Me.CodOjeto.HeaderText = "ID"
        Me.CodOjeto.Name = "CodOjeto"
        Me.CodOjeto.Visible = False
        Me.CodOjeto.Width = 50
        '
        'CP2
        '
        Me.CP2.DataPropertyName = "placa"
        Me.CP2.HeaderText = "Placa"
        Me.CP2.Name = "CP2"
        '
        'CP1
        '
        Me.CP1.DataPropertyName = "veiculo"
        Me.CP1.HeaderText = "Veiculo"
        Me.CP1.Name = "CP1"
        Me.CP1.Width = 720
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
        Me.Nome.Visible = False
        Me.Nome.Width = 250
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
        'OsObjetoLocalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "OsObjetoLocalizar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Objeto Localizar "
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents CodOjeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datacad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
