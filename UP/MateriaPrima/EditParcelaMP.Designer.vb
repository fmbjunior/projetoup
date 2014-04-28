<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditParcelaMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditParcelaMP))
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.salvar = New DevComponents.DotNetBar.ButtonX()
        Me.Total = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.valor2 = New TexBoxFocusNet.TextBoxFocusNet()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(4, 9)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RowHeadersWidth = 25
        Me.Dgv.ShowEditingIcon = False
        Me.Dgv.Size = New System.Drawing.Size(526, 194)
        Me.Dgv.TabIndex = 0
        '
        'salvar
        '
        Me.salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.salvar.Image = CType(resources.GetObject("salvar.Image"), System.Drawing.Image)
        Me.salvar.Location = New System.Drawing.Point(443, 209)
        Me.salvar.Name = "salvar"
        Me.salvar.Size = New System.Drawing.Size(96, 36)
        Me.salvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.salvar.TabIndex = 2
        Me.salvar.Text = "Salvar"
        '
        'Total
        '
        Me.Total.AceitaColarTexto = True
        Me.Total.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Total.CasasDecimais = 2
        Me.Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Total.CPObrigatorio = False
        Me.Total.CPObrigatorioMsg = Nothing
        Me.Total.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Total.FlatBorder = False
        Me.Total.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Total.FocusColor = System.Drawing.Color.Empty
        Me.Total.FocusColorEnd = System.Drawing.Color.Empty
        Me.Total.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.HighlightBorderOnEnter = False
        Me.Total.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Total.Location = New System.Drawing.Point(216, 209)
        Me.Total.MaxLength = 10
        Me.Total.Name = "Total"
        Me.Total.PreencherZeroEsqueda = False
        Me.Total.RegraValidação = Nothing
        Me.Total.RegraValidaçãoMensagem = Nothing
        Me.Total.Size = New System.Drawing.Size(119, 23)
        Me.Total.TabIndex = 1
        Me.Total.TabStop = False
        Me.Total.Text = "0,00"
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Total.ValorPadrao = "0,00"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.Location = New System.Drawing.Point(341, 209)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(96, 36)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 3
        Me.btFechar.Text = "Fechar"
        '
        'valor2
        '
        Me.valor2.AceitaColarTexto = True
        Me.valor2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.valor2.CasasDecimais = 2
        Me.valor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.valor2.CPObrigatorio = False
        Me.valor2.CPObrigatorioMsg = Nothing
        Me.valor2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.valor2.FlatBorder = False
        Me.valor2.FlatBorderColor = System.Drawing.Color.DimGray
        Me.valor2.FocusColor = System.Drawing.Color.Empty
        Me.valor2.FocusColorEnd = System.Drawing.Color.Empty
        Me.valor2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor2.HighlightBorderOnEnter = False
        Me.valor2.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.valor2.Location = New System.Drawing.Point(12, 257)
        Me.valor2.MaxLength = 10
        Me.valor2.Name = "valor2"
        Me.valor2.PreencherZeroEsqueda = False
        Me.valor2.RegraValidação = Nothing
        Me.valor2.RegraValidaçãoMensagem = Nothing
        Me.valor2.Size = New System.Drawing.Size(119, 23)
        Me.valor2.TabIndex = 1
        Me.valor2.TabStop = False
        Me.valor2.Text = "0,00"
        Me.valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.valor2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.valor2.ValorPadrao = "0,00"
        Me.valor2.Visible = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX1.Location = New System.Drawing.Point(107, 209)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(103, 23)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Total Documento"
        '
        'EditParcelaMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(542, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.salvar)
        Me.KeyPreview = True
        Me.Name = "EditParcelaMP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Parcelas"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents salvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Total As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents valor2 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class

