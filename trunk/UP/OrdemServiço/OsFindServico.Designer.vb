<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OsFindServico
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
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.CodigoServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.lblF2Novo = New System.Windows.Forms.Label()
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEx1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoServico, Me.Servico, Me.Referencia, Me.ValorServico})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(7, 34)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(756, 307)
        Me.DgvItem.TabIndex = 2
        '
        'CodigoServico
        '
        Me.CodigoServico.DataPropertyName = "Serv_Codigo"
        DataGridViewCellStyle2.Format = "0000"
        Me.CodigoServico.DefaultCellStyle = DataGridViewCellStyle2
        Me.CodigoServico.HeaderText = "Cod. Serv"
        Me.CodigoServico.Name = "CodigoServico"
        Me.CodigoServico.Width = 70
        '
        'Servico
        '
        Me.Servico.DataPropertyName = "Serv_Descricao"
        Me.Servico.HeaderText = "Serviço"
        Me.Servico.Name = "Servico"
        Me.Servico.Width = 270
        '
        'Referencia
        '
        Me.Referencia.DataPropertyName = "Serv_Referencia"
        Me.Referencia.HeaderText = "Referência"
        Me.Referencia.Name = "Referencia"
        Me.Referencia.Width = 300
        '
        'ValorServico
        '
        Me.ValorServico.DataPropertyName = "Serv_ValorServico"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ValorServico.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValorServico.HeaderText = "Valor Serviço"
        Me.ValorServico.Name = "ValorServico"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(638, 346)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(120, 29)
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "Fechar"
        '
        'lblReferencia
        '
        Me.lblReferencia.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReferencia.Location = New System.Drawing.Point(16, 346)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(532, 28)
        Me.lblReferencia.TabIndex = 3
        Me.lblReferencia.Text = "Referencia"
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
        Me.txtProcura.Location = New System.Drawing.Point(7, 9)
        Me.txtProcura.MaxLength = 30
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.ShortcutsEnabled = False
        Me.txtProcura.Size = New System.Drawing.Size(232, 20)
        Me.txtProcura.TabIndex = 0
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        '
        'lblF2Novo
        '
        Me.lblF2Novo.AutoSize = True
        Me.lblF2Novo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF2Novo.Location = New System.Drawing.Point(243, 11)
        Me.lblF2Novo.Name = "lblF2Novo"
        Me.lblF2Novo.Size = New System.Drawing.Size(133, 19)
        Me.lblF2Novo.TabIndex = 1
        Me.lblF2Novo.Text = "F2 - Nova consulta"
        '
        'panelEx1
        '
        Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelEx1.Controls.Add(Me.lblF2Novo)
        Me.panelEx1.Controls.Add(Me.txtProcura)
        Me.panelEx1.Controls.Add(Me.lblReferencia)
        Me.panelEx1.Controls.Add(Me.ButtonX1)
        Me.panelEx1.Controls.Add(Me.DgvItem)
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx1.Location = New System.Drawing.Point(0, 0)
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(775, 388)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.TabIndex = 0
        Me.panelEx1.Text = "PanelEx1"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'OsFindServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelEx1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.KeyPreview = True
        Me.Name = "OsFindServico"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviço do Funcinário - T227"
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEx1.ResumeLayout(False)
        Me.panelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents lblF2Novo As System.Windows.Forms.Label
    Friend WithEvents CodigoServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Referencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorServico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
