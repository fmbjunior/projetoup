<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjetoLocalizar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFantasia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCpfCnpj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAvista = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cCheque = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cCrediario = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cBloqueado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.A3a = New System.Windows.Forms.RadioButton()
        Me.A5 = New System.Windows.Forms.RadioButton()
        Me.A4 = New System.Windows.Forms.RadioButton()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A1 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.CodOjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datacad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
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
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.BackgroundColor = System.Drawing.Color.White
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigo, Me.cNome, Me.cFantasia, Me.cCpfCnpj, Me.cCidade, Me.cAvista, Me.cCheque, Me.cCrediario, Me.cBloqueado, Me.cMotivo, Me.cTelefone, Me.cCelular, Me.cContato, Me.cEndereco})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(13, 119)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(959, 224)
        Me.Lista.TabIndex = 1
        '
        'cCodigo
        '
        Me.cCodigo.DataPropertyName = "Codigo"
        Me.cCodigo.HeaderText = "Código"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Width = 70
        '
        'cNome
        '
        Me.cNome.DataPropertyName = "Nome"
        Me.cNome.HeaderText = "Nome"
        Me.cNome.Name = "cNome"
        Me.cNome.ReadOnly = True
        Me.cNome.Width = 370
        '
        'cFantasia
        '
        Me.cFantasia.DataPropertyName = "NomeFantasia"
        Me.cFantasia.HeaderText = "Nome Fantasia"
        Me.cFantasia.Name = "cFantasia"
        Me.cFantasia.ReadOnly = True
        Me.cFantasia.Width = 210
        '
        'cCpfCnpj
        '
        Me.cCpfCnpj.DataPropertyName = "CpfCgc"
        Me.cCpfCnpj.HeaderText = "Cpf/Cnpj"
        Me.cCpfCnpj.Name = "cCpfCnpj"
        Me.cCpfCnpj.ReadOnly = True
        Me.cCpfCnpj.Width = 120
        '
        'cCidade
        '
        Me.cCidade.DataPropertyName = "Cidade"
        Me.cCidade.HeaderText = "Cidade"
        Me.cCidade.Name = "cCidade"
        Me.cCidade.ReadOnly = True
        Me.cCidade.Width = 140
        '
        'cAvista
        '
        Me.cAvista.DataPropertyName = "VendaVista"
        Me.cAvista.HeaderText = "avista"
        Me.cAvista.Name = "cAvista"
        Me.cAvista.ReadOnly = True
        Me.cAvista.Visible = False
        '
        'cCheque
        '
        Me.cCheque.DataPropertyName = "VendaCheque"
        Me.cCheque.HeaderText = "cheque"
        Me.cCheque.Name = "cCheque"
        Me.cCheque.ReadOnly = True
        Me.cCheque.Visible = False
        '
        'cCrediario
        '
        Me.cCrediario.DataPropertyName = "VendaCrediario"
        Me.cCrediario.HeaderText = "crediario"
        Me.cCrediario.Name = "cCrediario"
        Me.cCrediario.ReadOnly = True
        Me.cCrediario.Visible = False
        '
        'cBloqueado
        '
        Me.cBloqueado.DataPropertyName = "Bloqueado"
        Me.cBloqueado.HeaderText = "bloqueado"
        Me.cBloqueado.Name = "cBloqueado"
        Me.cBloqueado.ReadOnly = True
        Me.cBloqueado.Visible = False
        '
        'cMotivo
        '
        Me.cMotivo.DataPropertyName = "MotivoBloqueado"
        Me.cMotivo.HeaderText = "motivo"
        Me.cMotivo.Name = "cMotivo"
        Me.cMotivo.ReadOnly = True
        Me.cMotivo.Visible = False
        '
        'cTelefone
        '
        Me.cTelefone.DataPropertyName = "Telefone"
        Me.cTelefone.HeaderText = "telefone"
        Me.cTelefone.Name = "cTelefone"
        Me.cTelefone.ReadOnly = True
        Me.cTelefone.Visible = False
        '
        'cCelular
        '
        Me.cCelular.DataPropertyName = "celular"
        Me.cCelular.HeaderText = "celular"
        Me.cCelular.Name = "cCelular"
        Me.cCelular.ReadOnly = True
        Me.cCelular.Visible = False
        '
        'cContato
        '
        Me.cContato.DataPropertyName = "PessoaContato"
        Me.cContato.HeaderText = "contato"
        Me.cContato.Name = "cContato"
        Me.cContato.ReadOnly = True
        Me.cContato.Visible = False
        '
        'cEndereco
        '
        Me.cEndereco.DataPropertyName = "endereço"
        Me.cEndereco.HeaderText = "endereco"
        Me.cEndereco.Name = "cEndereco"
        Me.cEndereco.ReadOnly = True
        Me.cEndereco.Visible = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.A3a)
        Me.GroupPanel1.Controls.Add(Me.A5)
        Me.GroupPanel1.Controls.Add(Me.A4)
        Me.GroupPanel1.Controls.Add(Me.A3)
        Me.GroupPanel1.Controls.Add(Me.txtProcura)
        Me.GroupPanel1.Controls.Add(Me.A1)
        Me.GroupPanel1.Controls.Add(Me.A2)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(524, 79)
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
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Selecione uma das opções"
        '
        'A3a
        '
        Me.A3a.AutoSize = True
        Me.A3a.Location = New System.Drawing.Point(279, 3)
        Me.A3a.Name = "A3a"
        Me.A3a.Size = New System.Drawing.Size(52, 17)
        Me.A3a.TabIndex = 5
        Me.A3a.Text = "CNPJ"
        Me.A3a.UseVisualStyleBackColor = True
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Location = New System.Drawing.Point(126, 3)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(96, 17)
        Me.A5.TabIndex = 3
        Me.A5.Text = "Nome Fantasia"
        Me.A5.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(337, 3)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(93, 17)
        Me.A4.TabIndex = 6
        Me.A4.Text = "Mostrar Todos"
        Me.A4.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(228, 3)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(45, 17)
        Me.A3.TabIndex = 4
        Me.A3.Text = "CPF"
        Me.A3.UseVisualStyleBackColor = True
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
        Me.txtProcura.Location = New System.Drawing.Point(61, 31)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.Size = New System.Drawing.Size(454, 20)
        Me.txtProcura.TabIndex = 0
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(3, 3)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(58, 17)
        Me.A1.TabIndex = 1
        Me.A1.Text = "Código"
        Me.A1.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Checked = True
        Me.A2.Location = New System.Drawing.Point(67, 3)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(53, 17)
        Me.A2.TabIndex = 2
        Me.A2.TabStop = True
        Me.A2.Text = "Nome"
        Me.A2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvItem.BackgroundColor = System.Drawing.Color.White
        Me.DgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodOjeto, Me.CP2, Me.CP1, Me.idCliente, Me.Nome, Me.datacad})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(13, 349)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(959, 182)
        Me.DgvItem.TabIndex = 2
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
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
        'ObjetoLocalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ObjetoLocalizar"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Objeto Localizar - T222"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents A3a As System.Windows.Forms.RadioButton
    Friend WithEvents A5 As System.Windows.Forms.RadioButton
    Friend WithEvents A4 As System.Windows.Forms.RadioButton
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A1 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFantasia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCpfCnpj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAvista As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cCheque As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cCrediario As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cBloqueado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTelefone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCelular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEndereco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodOjeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datacad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
