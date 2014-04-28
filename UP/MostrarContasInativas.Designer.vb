<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostrarContasInativas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblF2Novo = New System.Windows.Forms.Label()
        Me.txtProcura = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.gcontaprincipal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gNameContaPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gSubConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gNomeSuuConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AtivarContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelEx1.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelEx1
        '
        Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelEx1.Controls.Add(Me.Label1)
        Me.panelEx1.Controls.Add(Me.lblF2Novo)
        Me.panelEx1.Controls.Add(Me.txtProcura)
        Me.panelEx1.Controls.Add(Me.btnFechar)
        Me.panelEx1.Controls.Add(Me.DgvItem)
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx1.Location = New System.Drawing.Point(0, 0)
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(749, 384)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.TabIndex = 1
        Me.panelEx1.Text = "PanelEx1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Para reativar a conta de resultado selecione com o mouse e dê um click com o botã" & _
    "o direito"
        '
        'lblF2Novo
        '
        Me.lblF2Novo.AutoSize = True
        Me.lblF2Novo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF2Novo.Location = New System.Drawing.Point(245, 9)
        Me.lblF2Novo.Name = "lblF2Novo"
        Me.lblF2Novo.Size = New System.Drawing.Size(133, 19)
        Me.lblF2Novo.TabIndex = 1
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
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFechar.Location = New System.Drawing.Point(623, 347)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(120, 29)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.Text = "Fechar"
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToResizeColumns = False
        Me.DgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItem.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.DgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gcontaprincipal, Me.gNameContaPrincipal, Me.gSubConta, Me.gNomeSuuConta})
        Me.DgvItem.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvItem.EnableHeadersVisualStyles = False
        Me.DgvItem.Location = New System.Drawing.Point(7, 34)
        Me.DgvItem.MultiSelect = False
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.RowHeadersVisible = False
        Me.DgvItem.RowHeadersWidth = 15
        Me.DgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItem.Size = New System.Drawing.Size(736, 307)
        Me.DgvItem.TabIndex = 2
        '
        'gcontaprincipal
        '
        Me.gcontaprincipal.DataPropertyName = "cr1"
        Me.gcontaprincipal.HeaderText = "Conta Principal"
        Me.gcontaprincipal.Name = "gcontaprincipal"
        Me.gcontaprincipal.Width = 101
        '
        'gNameContaPrincipal
        '
        Me.gNameContaPrincipal.DataPropertyName = "Desccr1"
        Me.gNameContaPrincipal.HeaderText = "Nome Conta Principal"
        Me.gNameContaPrincipal.Name = "gNameContaPrincipal"
        Me.gNameContaPrincipal.Width = 300
        '
        'gSubConta
        '
        Me.gSubConta.DataPropertyName = "cr2"
        Me.gSubConta.HeaderText = "Sub Conta"
        Me.gSubConta.Name = "gSubConta"
        Me.gSubConta.Width = 80
        '
        'gNomeSuuConta
        '
        Me.gNomeSuuConta.DataPropertyName = "desccr2"
        Me.gNomeSuuConta.HeaderText = "Nome SubConta"
        Me.gNomeSuuConta.Name = "gNomeSuuConta"
        Me.gNomeSuuConta.Width = 250
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivarContaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 26)
        '
        'AtivarContaToolStripMenuItem
        '
        Me.AtivarContaToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtivarContaToolStripMenuItem.Name = "AtivarContaToolStripMenuItem"
        Me.AtivarContaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AtivarContaToolStripMenuItem.Text = "Ativar Conta"
        '
        'MostrarContasInativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "MostrarContasInativas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas Inativas - T276"
        Me.panelEx1.ResumeLayout(False)
        Me.panelEx1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblF2Novo As System.Windows.Forms.Label
    Friend WithEvents txtProcura As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents gcontaprincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gNameContaPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gSubConta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gNomeSuuConta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AtivarContaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
