<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaServicoPlaca
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblF2Novo = New System.Windows.Forms.Label()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.gPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gPlaca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gCodServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gQtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gVlrDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.lblF2Novo)
        Me.PanelEx1.Controls.Add(Me.txtProcura)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.DgvItem)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(959, 489)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "T039"
        '
        'lblF2Novo
        '
        Me.lblF2Novo.AutoSize = True
        Me.lblF2Novo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF2Novo.Location = New System.Drawing.Point(248, 13)
        Me.lblF2Novo.Name = "lblF2Novo"
        Me.lblF2Novo.Size = New System.Drawing.Size(133, 19)
        Me.lblF2Novo.TabIndex = 6
        Me.lblF2Novo.Text = "F2 - Nova consulta"
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
        Me.txtProcura.FocusColor = System.Drawing.Color.MistyRose
        Me.txtProcura.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtProcura.HighlightBorderOnEnter = False
        Me.txtProcura.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtProcura.Location = New System.Drawing.Point(12, 11)
        Me.txtProcura.MaxLength = 30
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.ShortcutsEnabled = False
        Me.txtProcura.Size = New System.Drawing.Size(232, 20)
        Me.txtProcura.TabIndex = 5
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(827, 444)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(120, 29)
        Me.ButtonX1.TabIndex = 8
        Me.ButtonX1.Text = "Fechar"
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
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gPedido, Me.gData, Me.gPlaca, Me.gCodServ, Me.gServico, Me.gQtd, Me.gValor, Me.gVlrDesc, Me.gTotal})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvItem.DefaultCellStyle = DataGridViewCellStyle8
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.Location = New System.Drawing.Point(12, 36)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersWidth = 24
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(935, 402)
        Me.DgvItem.TabIndex = 7
        '
        'gPedido
        '
        Me.gPedido.DataPropertyName = "pedidosequencia"
        DataGridViewCellStyle2.Format = "00000"
        Me.gPedido.DefaultCellStyle = DataGridViewCellStyle2
        Me.gPedido.HeaderText = "Pedido"
        Me.gPedido.Name = "gPedido"
        Me.gPedido.Width = 60
        '
        'gData
        '
        Me.gData.DataPropertyName = "datapedido"
        Me.gData.HeaderText = "Data OS"
        Me.gData.Name = "gData"
        Me.gData.Width = 70
        '
        'gPlaca
        '
        Me.gPlaca.DataPropertyName = "placa"
        Me.gPlaca.HeaderText = "Placa"
        Me.gPlaca.Name = "gPlaca"
        Me.gPlaca.Width = 70
        '
        'gCodServ
        '
        Me.gCodServ.DataPropertyName = "codigoservico"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "0000"
        Me.gCodServ.DefaultCellStyle = DataGridViewCellStyle3
        Me.gCodServ.HeaderText = "Cod. Serv"
        Me.gCodServ.Name = "gCodServ"
        Me.gCodServ.Width = 60
        '
        'gServico
        '
        Me.gServico.DataPropertyName = "serv_descricao"
        Me.gServico.HeaderText = "Serviço"
        Me.gServico.Name = "gServico"
        Me.gServico.Width = 280
        '
        'gQtd
        '
        Me.gQtd.DataPropertyName = "qtd"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = "0,000"
        Me.gQtd.DefaultCellStyle = DataGridViewCellStyle4
        Me.gQtd.HeaderText = "Qtde"
        Me.gQtd.Name = "gQtd"
        Me.gQtd.Width = 70
        '
        'gValor
        '
        Me.gValor.DataPropertyName = "valorunitario"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        Me.gValor.DefaultCellStyle = DataGridViewCellStyle5
        Me.gValor.HeaderText = "Vlr. Unit"
        Me.gValor.Name = "gValor"
        Me.gValor.Width = 90
        '
        'gVlrDesc
        '
        Me.gVlrDesc.DataPropertyName = "valordesconto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        Me.gVlrDesc.DefaultCellStyle = DataGridViewCellStyle6
        Me.gVlrDesc.HeaderText = "Vlr. Desc"
        Me.gVlrDesc.Name = "gVlrDesc"
        Me.gVlrDesc.Width = 90
        '
        'gTotal
        '
        Me.gTotal.DataPropertyName = "totalservico"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle7.Format = "C2"
        Me.gTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.gTotal.HeaderText = "Total"
        Me.gTotal.Name = "gTotal"
        Me.gTotal.Width = 90
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ConsultaServicoPlaca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ConsultaServicoPlaca"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Serviço Placa - T219"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblF2Novo As System.Windows.Forms.Label
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents gPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gPlaca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gCodServ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gQtd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gVlrDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
