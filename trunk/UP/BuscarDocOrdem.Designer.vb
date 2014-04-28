<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarDocOrdem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarDocOrdem))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.Total = New TexBoxFocusNet.TextBoxFocusNet
        Me.lblTotal = New System.Windows.Forms.Label
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.chk = New System.Windows.Forms.CheckBox
        Me.DTPicker = New System.Windows.Forms.DateTimePicker
        Me.opt1 = New System.Windows.Forms.RadioButton
        Me.MostrarTodos = New DevComponents.DotNetBar.ButtonX
        Me.txtpesquisar = New TexBoxFocusNet.TextBoxFocusNet
        Me.DgvItem = New System.Windows.Forms.DataGridView
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CodG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dev = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.img = New System.Windows.Forms.DataGridViewImageColumn
        Me.imgVerde = New System.Windows.Forms.DataGridViewImageColumn
        Me.imgVermelho = New System.Windows.Forms.DataGridViewImageColumn
        Me.imgAzul = New System.Windows.Forms.DataGridViewImageColumn
        Me.itens = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Total)
        Me.PanelEx1.Controls.Add(Me.lblTotal)
        Me.PanelEx1.Controls.Add(Me.ButtonX3)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.DgvItem)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(673, 417)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'Total
        '
        Me.Total.AceitaColarTexto = True
        Me.Total.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Total.CasasDecimais = 2
        Me.Total.CPObrigatorio = False
        Me.Total.CPObrigatorioMsg = Nothing
        Me.Total.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Total.FocusColor = System.Drawing.Color.Empty
        Me.Total.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total.Location = New System.Drawing.Point(52, 392)
        Me.Total.MaxLength = 8
        Me.Total.Name = "Total"
        Me.Total.RegraValidação = Nothing
        Me.Total.RegraValidaçãoMensagem = Nothing
        Me.Total.Size = New System.Drawing.Size(101, 20)
        Me.Total.TabIndex = 21
        Me.Total.TabStop = False
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Total.ValorPadrao = Nothing
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 395)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "Total:"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.Up.My.Resources.Resources.BeOS_write
        Me.ButtonX3.Location = New System.Drawing.Point(362, 373)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(137, 40)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX3.TabIndex = 19
        Me.ButtonX3.Text = "Importar Selecionado"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Up.My.Resources.Resources.Cancelar
        Me.ButtonX1.Location = New System.Drawing.Point(505, 373)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(126, 41)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX1.TabIndex = 18
        Me.ButtonX1.Text = "Fechar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ButtonX2)
        Me.GroupPanel1.Controls.Add(Me.chk)
        Me.GroupPanel1.Controls.Add(Me.DTPicker)
        Me.GroupPanel1.Controls.Add(Me.opt1)
        Me.GroupPanel1.Controls.Add(Me.MostrarTodos)
        Me.GroupPanel1.Controls.Add(Me.txtpesquisar)
        Me.GroupPanel1.DrawTitleBox = False
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(631, 65)
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
        Me.GroupPanel1.TabIndex = 17
        Me.GroupPanel1.Text = "Dados para pesquisar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.Up.My.Resources.Resources.Localizar
        Me.ButtonX2.Location = New System.Drawing.Point(408, 3)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(98, 38)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX2.TabIndex = 21
        Me.ButtonX2.Text = "Filtar"
        '
        'chk
        '
        Me.chk.AutoSize = True
        Me.chk.Location = New System.Drawing.Point(227, 3)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(74, 17)
        Me.chk.TabIndex = 20
        Me.chk.Text = "Usar Data"
        Me.chk.UseVisualStyleBackColor = True
        '
        'DTPicker
        '
        Me.DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPicker.Location = New System.Drawing.Point(307, 3)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.Size = New System.Drawing.Size(95, 20)
        Me.DTPicker.TabIndex = 19
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Checked = True
        Me.opt1.Location = New System.Drawing.Point(3, 26)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(58, 17)
        Me.opt1.TabIndex = 17
        Me.opt1.TabStop = True
        Me.opt1.Text = "Código"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'MostrarTodos
        '
        Me.MostrarTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.MostrarTodos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.MostrarTodos.Image = Global.Up.My.Resources.Resources.Localizar
        Me.MostrarTodos.Location = New System.Drawing.Point(521, 3)
        Me.MostrarTodos.Name = "MostrarTodos"
        Me.MostrarTodos.Size = New System.Drawing.Size(98, 39)
        Me.MostrarTodos.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.MostrarTodos.TabIndex = 15
        Me.MostrarTodos.Text = "Filtar Todos"
        '
        'txtpesquisar
        '
        Me.txtpesquisar.AceitaColarTexto = True
        Me.txtpesquisar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtpesquisar.CasasDecimais = 2
        Me.txtpesquisar.CPObrigatorio = False
        Me.txtpesquisar.CPObrigatorioMsg = Nothing
        Me.txtpesquisar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtpesquisar.FocusColor = System.Drawing.Color.Empty
        Me.txtpesquisar.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtpesquisar.Location = New System.Drawing.Point(3, 2)
        Me.txtpesquisar.Name = "txtpesquisar"
        Me.txtpesquisar.RegraValidação = Nothing
        Me.txtpesquisar.RegraValidaçãoMensagem = Nothing
        Me.txtpesquisar.Size = New System.Drawing.Size(218, 20)
        Me.txtpesquisar.TabIndex = 16
        Me.txtpesquisar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtpesquisar.ValorPadrao = Nothing
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.AllowUserToResizeColumns = False
        Me.DgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.col3, Me.col4, Me.col5, Me.Sel, Me.CodG, Me.Dev, Me.img, Me.imgVerde, Me.imgVermelho, Me.imgAzul, Me.itens})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.Location = New System.Drawing.Point(0, 74)
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.ReadOnly = True
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.ShowEditingIcon = False
        Me.DgvItem.Size = New System.Drawing.Size(668, 297)
        Me.DgvItem.TabIndex = 10
        Me.DgvItem.TabStop = False
        '
        'Col1
        '
        Me.Col1.DataPropertyName = "id"
        Me.Col1.HeaderText = "Nº  Controle"
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        Me.Col1.Width = 70
        '
        'Col2
        '
        Me.Col2.DataPropertyName = "FornecedorDesc"
        Me.Col2.HeaderText = "Fornecedor"
        Me.Col2.Name = "Col2"
        Me.Col2.ReadOnly = True
        Me.Col2.Width = 270
        '
        'col3
        '
        Me.col3.DataPropertyName = "ValorPedido"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col3.DefaultCellStyle = DataGridViewCellStyle2
        Me.col3.HeaderText = "Valor"
        Me.col3.Name = "col3"
        Me.col3.ReadOnly = True
        '
        'col4
        '
        Me.col4.DataPropertyName = "Expr1"
        Me.col4.HeaderText = "Tipo"
        Me.col4.Name = "col4"
        Me.col4.ReadOnly = True
        '
        'col5
        '
        Me.col5.DataPropertyName = "EXPR2"
        Me.col5.HeaderText = "Conf."
        Me.col5.MaxInputLength = 3
        Me.col5.Name = "col5"
        Me.col5.ReadOnly = True
        Me.col5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col5.Width = 50
        '
        'Sel
        '
        Me.Sel.HeaderText = ""
        Me.Sel.Name = "Sel"
        Me.Sel.ReadOnly = True
        Me.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sel.Width = 30
        '
        'CodG
        '
        Me.CodG.DataPropertyName = "CodigoGerenciador"
        DataGridViewCellStyle3.NullValue = "0"
        Me.CodG.DefaultCellStyle = DataGridViewCellStyle3
        Me.CodG.HeaderText = ""
        Me.CodG.Name = "CodG"
        Me.CodG.ReadOnly = True
        Me.CodG.Visible = False
        '
        'Dev
        '
        Me.Dev.DataPropertyName = "NotaDevoluçao"
        Me.Dev.HeaderText = ""
        Me.Dev.Name = "Dev"
        Me.Dev.ReadOnly = True
        Me.Dev.Visible = False
        '
        'img
        '
        Me.img.HeaderText = ""
        Me.img.Name = "img"
        Me.img.ReadOnly = True
        Me.img.Width = 30
        '
        'imgVerde
        '
        Me.imgVerde.HeaderText = ""
        Me.imgVerde.Image = CType(resources.GetObject("imgVerde.Image"), System.Drawing.Image)
        Me.imgVerde.Name = "imgVerde"
        Me.imgVerde.ReadOnly = True
        Me.imgVerde.Visible = False
        '
        'imgVermelho
        '
        Me.imgVermelho.HeaderText = ""
        Me.imgVermelho.Image = CType(resources.GetObject("imgVermelho.Image"), System.Drawing.Image)
        Me.imgVermelho.Name = "imgVermelho"
        Me.imgVermelho.ReadOnly = True
        Me.imgVermelho.Visible = False
        '
        'imgAzul
        '
        Me.imgAzul.HeaderText = ""
        Me.imgAzul.Image = CType(resources.GetObject("imgAzul.Image"), System.Drawing.Image)
        Me.imgAzul.Name = "imgAzul"
        Me.imgAzul.ReadOnly = True
        Me.imgAzul.Visible = False
        '
        'itens
        '
        Me.itens.DataPropertyName = "LancaItens"
        Me.itens.HeaderText = ""
        Me.itens.Name = "itens"
        Me.itens.ReadOnly = True
        Me.itens.Visible = False
        '
        'BuscarDocOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BuscarDocOrdem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar Documento ou Ordem de Compra"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents MostrarTodos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtpesquisar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DTPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Total As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dev As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents imgVerde As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents imgVermelho As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents imgAzul As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents itens As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
