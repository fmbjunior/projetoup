<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auditor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ArqVer = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Filtro = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btRemoveFiltro = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNomeBd = New System.Windows.Forms.Button()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Panel1)
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1006, 468)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ArqVer)
        Me.Panel1.Controls.Add(Me.Filtro)
        Me.Panel1.Controls.Add(Me.btRemoveFiltro)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BTNomeBd)
        Me.Panel1.Location = New System.Drawing.Point(6, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 56)
        Me.Panel1.TabIndex = 3
        '
        'ArqVer
        '
        Me.ArqVer.AceitaColarTexto = True
        Me.ArqVer.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ArqVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ArqVer.CasasDecimais = 0
        Me.ArqVer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ArqVer.CPObrigatorio = False
        Me.ArqVer.CPObrigatorioMsg = Nothing
        Me.ArqVer.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ArqVer.FlatBorder = True
        Me.ArqVer.FlatBorderColor = System.Drawing.Color.Black
        Me.ArqVer.FocusColor = System.Drawing.Color.Empty
        Me.ArqVer.FocusColorEnd = System.Drawing.Color.Empty
        Me.ArqVer.HighlightBorderOnEnter = False
        Me.ArqVer.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ArqVer.Location = New System.Drawing.Point(89, 30)
        Me.ArqVer.MaxLength = 5000
        Me.ArqVer.Name = "ArqVer"
        Me.ArqVer.PreencherZeroEsqueda = False
        Me.ArqVer.RegraValidação = Nothing
        Me.ArqVer.RegraValidaçãoMensagem = Nothing
        Me.ArqVer.Size = New System.Drawing.Size(816, 20)
        Me.ArqVer.TabIndex = 72
        Me.ArqVer.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ArqVer.ValorPadrao = Nothing
        '
        'Filtro
        '
        Me.Filtro.AceitaColarTexto = True
        Me.Filtro.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Filtro.CasasDecimais = 0
        Me.Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Filtro.CPObrigatorio = False
        Me.Filtro.CPObrigatorioMsg = Nothing
        Me.Filtro.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Filtro.FlatBorder = True
        Me.Filtro.FlatBorderColor = System.Drawing.Color.Black
        Me.Filtro.FocusColor = System.Drawing.Color.Empty
        Me.Filtro.FocusColorEnd = System.Drawing.Color.Empty
        Me.Filtro.HighlightBorderOnEnter = False
        Me.Filtro.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Filtro.Location = New System.Drawing.Point(89, 7)
        Me.Filtro.MaxLength = 5000
        Me.Filtro.Name = "Filtro"
        Me.Filtro.PreencherZeroEsqueda = False
        Me.Filtro.RegraValidação = Nothing
        Me.Filtro.RegraValidaçãoMensagem = Nothing
        Me.Filtro.Size = New System.Drawing.Size(816, 20)
        Me.Filtro.TabIndex = 71
        Me.Filtro.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Filtro.ValorPadrao = Nothing
        Me.Filtro.Visible = False
        '
        'btRemoveFiltro
        '
        Me.btRemoveFiltro.BackColor = System.Drawing.Color.Transparent
        Me.btRemoveFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveFiltro.Image = CType(resources.GetObject("btRemoveFiltro.Image"), System.Drawing.Image)
        Me.btRemoveFiltro.Location = New System.Drawing.Point(944, 9)
        Me.btRemoveFiltro.Name = "btRemoveFiltro"
        Me.btRemoveFiltro.Size = New System.Drawing.Size(44, 39)
        Me.btRemoveFiltro.TabIndex = 16
        Me.btRemoveFiltro.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Arquivo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTNomeBd
        '
        Me.BTNomeBd.BackColor = System.Drawing.SystemColors.Control
        Me.BTNomeBd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNomeBd.Location = New System.Drawing.Point(911, 30)
        Me.BTNomeBd.Name = "BTNomeBd"
        Me.BTNomeBd.Size = New System.Drawing.Size(27, 20)
        Me.BTNomeBd.TabIndex = 8
        Me.BTNomeBd.Text = "..."
        Me.BTNomeBd.UseVisualStyleBackColor = False
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Lista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle3
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(6, 65)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersVisible = False
        Me.Lista.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(995, 391)
        Me.Lista.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "User"
        Me.Column1.HeaderText = "User"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Tela"
        Me.Column2.HeaderText = "Tela"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Ação"
        Me.Column3.HeaderText = "Ação"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ID"
        Me.Column4.HeaderText = "ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Data_Hora"
        Me.Column5.HeaderText = "Data Hora"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 130
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "DescAuxiliar"
        Me.Column6.HeaderText = "Desc Auxiliar"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 350
        '
        'Auditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 468)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Auditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoria - T089"
        Me.PanelEx1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTNomeBd As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btRemoveFiltro As System.Windows.Forms.Button
    Friend WithEvents ArqVer As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Filtro As TexBoxFocusNet.TextBoxFocusNet
End Class
