<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CondicaoPagamentoBuscaMP
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.gCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.butFechar = New DevComponents.DotNetBar.ButtonX()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.A3 = New System.Windows.Forms.RadioButton()
        Me.A2 = New System.Windows.Forms.RadioButton()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gCodigo, Me.gDescricao, Me.gDias})
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(7, 33)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(464, 301)
        Me.DgvItem.TabIndex = 1
        '
        'gCodigo
        '
        Me.gCodigo.DataPropertyName = "CodFormaPgto"
        DataGridViewCellStyle2.Format = "0000"
        Me.gCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.gCodigo.HeaderText = "Código"
        Me.gCodigo.Name = "gCodigo"
        Me.gCodigo.Width = 70
        '
        'gDescricao
        '
        Me.gDescricao.DataPropertyName = "Descrição"
        Me.gDescricao.HeaderText = "Descrição da Condição de Pagamento"
        Me.gDescricao.Name = "gDescricao"
        Me.gDescricao.Width = 390
        '
        'gDias
        '
        Me.gDias.DataPropertyName = "DiasParcelamento"
        Me.gDias.HeaderText = "Dias"
        Me.gDias.Name = "gDias"
        Me.gDias.Visible = False
        '
        'butFechar
        '
        Me.butFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.butFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.butFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butFechar.Image = Global.Up.My.Resources.Resources.Cancelar
        Me.butFechar.Location = New System.Drawing.Point(7, 340)
        Me.butFechar.Name = "butFechar"
        Me.butFechar.Size = New System.Drawing.Size(93, 33)
        Me.butFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.butFechar.TabIndex = 2
        Me.butFechar.Text = "Fechar"
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
        Me.txtProcura.Location = New System.Drawing.Point(9, 5)
        Me.txtProcura.MaxLength = 30
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.PreencherZeroEsqueda = False
        Me.txtProcura.RegraValidação = Nothing
        Me.txtProcura.RegraValidaçãoMensagem = Nothing
        Me.txtProcura.ShortcutsEnabled = False
        Me.txtProcura.Size = New System.Drawing.Size(160, 20)
        Me.txtProcura.TabIndex = 0
        Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProcura.ValorPadrao = Nothing
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(267, 6)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(55, 17)
        Me.A3.TabIndex = 5
        Me.A3.Text = "Todos"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Checked = True
        Me.A2.Location = New System.Drawing.Point(175, 6)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(73, 17)
        Me.A2.TabIndex = 4
        Me.A2.TabStop = True
        Me.A2.Text = "Descrição"
        Me.A2.UseVisualStyleBackColor = True
        '
        'CondicaoPagamentoBuscaMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 380)
        Me.ControlBox = False
        Me.Controls.Add(Me.A3)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.butFechar)
        Me.Controls.Add(Me.DgvItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CondicaoPagamentoBuscaMP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca Condição Pagamento"
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents butFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents A3 As System.Windows.Forms.RadioButton
    Friend WithEvents A2 As System.Windows.Forms.RadioButton
    Friend WithEvents gCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gDescricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gDias As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
