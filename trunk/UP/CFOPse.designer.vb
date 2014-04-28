<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFOPse
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btExcluir = New DevComponents.DotNetBar.ButtonX()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCFOPs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCFOPe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCTB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ctb = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cfopE = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cfopS = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Empresa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btExcluir)
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.ctb)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.cfopE)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.cfopS)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Empresa)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(626, 335)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btExcluir
        '
        Me.btExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExcluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btExcluir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcluir.Location = New System.Drawing.Point(297, 305)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btExcluir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btExcluir.TabIndex = 25
        Me.btExcluir.Text = "Excluir"
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        Me.Lista.AllowUserToResizeColumns = False
        Me.Lista.AllowUserToResizeRows = False
        Me.Lista.BackgroundColor = System.Drawing.Color.White
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cEmpresa, Me.cCFOPs, Me.cCFOPe, Me.cCTB})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(12, 12)
        Me.Lista.MultiSelect = False
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(275, 316)
        Me.Lista.TabIndex = 13
        '
        'cEmpresa
        '
        Me.cEmpresa.DataPropertyName = "Empresa"
        Me.cEmpresa.HeaderText = "Empresa"
        Me.cEmpresa.Name = "cEmpresa"
        Me.cEmpresa.ReadOnly = True
        Me.cEmpresa.Visible = False
        '
        'cCFOPs
        '
        Me.cCFOPs.DataPropertyName = "cfopS"
        Me.cCFOPs.HeaderText = "CFOP Sai"
        Me.cCFOPs.Name = "cCFOPs"
        Me.cCFOPs.ReadOnly = True
        Me.cCFOPs.Width = 80
        '
        'cCFOPe
        '
        Me.cCFOPe.DataPropertyName = "cfopE"
        Me.cCFOPe.HeaderText = "CFOP Ent"
        Me.cCFOPe.Name = "cCFOPe"
        Me.cCFOPe.ReadOnly = True
        Me.cCFOPe.Width = 80
        '
        'cCTB
        '
        Me.cCTB.DataPropertyName = "ctb"
        Me.cCTB.HeaderText = "CTB"
        Me.cCTB.Name = "cCTB"
        Me.cCTB.ReadOnly = True
        Me.cCTB.Width = 90
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btSalvar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.Location = New System.Drawing.Point(378, 305)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 22
        Me.btSalvar.Text = "Salvar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btNovo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.Location = New System.Drawing.Point(459, 305)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(75, 23)
        Me.btNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNovo.TabIndex = 23
        Me.btNovo.Text = "Novo"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Código CTB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctb
        '
        Me.ctb.AceitaColarTexto = True
        Me.ctb.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ctb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctb.CasasDecimais = 0
        Me.ctb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ctb.CPObrigatorio = False
        Me.ctb.CPObrigatorioMsg = Nothing
        Me.ctb.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ctb.FlatBorder = True
        Me.ctb.FlatBorderColor = System.Drawing.Color.Black
        Me.ctb.FocusColor = System.Drawing.Color.Empty
        Me.ctb.FocusColorEnd = System.Drawing.Color.Empty
        Me.ctb.HighlightBorderOnEnter = False
        Me.ctb.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ctb.Location = New System.Drawing.Point(406, 102)
        Me.ctb.MaxLength = 30
        Me.ctb.Name = "ctb"
        Me.ctb.PreencherZeroEsqueda = False
        Me.ctb.RegraValidação = Nothing
        Me.ctb.RegraValidaçãoMensagem = Nothing
        Me.ctb.Size = New System.Drawing.Size(209, 23)
        Me.ctb.TabIndex = 21
        Me.ctb.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ctb.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "CFOP Entrada"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cfopE
        '
        Me.cfopE.AceitaColarTexto = True
        Me.cfopE.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.cfopE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cfopE.CasasDecimais = 0
        Me.cfopE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cfopE.CPObrigatorio = False
        Me.cfopE.CPObrigatorioMsg = Nothing
        Me.cfopE.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.cfopE.FlatBorder = True
        Me.cfopE.FlatBorderColor = System.Drawing.Color.Black
        Me.cfopE.FocusColor = System.Drawing.Color.Empty
        Me.cfopE.FocusColorEnd = System.Drawing.Color.Empty
        Me.cfopE.HighlightBorderOnEnter = False
        Me.cfopE.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.cfopE.Location = New System.Drawing.Point(406, 76)
        Me.cfopE.MaxLength = 4
        Me.cfopE.Name = "cfopE"
        Me.cfopE.PreencherZeroEsqueda = False
        Me.cfopE.RegraValidação = Nothing
        Me.cfopE.RegraValidaçãoMensagem = Nothing
        Me.cfopE.Size = New System.Drawing.Size(209, 23)
        Me.cfopE.TabIndex = 19
        Me.cfopE.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.cfopE.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CFOP Saida"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cfopS
        '
        Me.cfopS.AceitaColarTexto = True
        Me.cfopS.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.cfopS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cfopS.CasasDecimais = 0
        Me.cfopS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cfopS.CPObrigatorio = False
        Me.cfopS.CPObrigatorioMsg = Nothing
        Me.cfopS.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.cfopS.FlatBorder = True
        Me.cfopS.FlatBorderColor = System.Drawing.Color.Black
        Me.cfopS.FocusColor = System.Drawing.Color.Empty
        Me.cfopS.FocusColorEnd = System.Drawing.Color.Empty
        Me.cfopS.HighlightBorderOnEnter = False
        Me.cfopS.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.cfopS.Location = New System.Drawing.Point(406, 50)
        Me.cfopS.MaxLength = 4
        Me.cfopS.Name = "cfopS"
        Me.cfopS.PreencherZeroEsqueda = False
        Me.cfopS.RegraValidação = Nothing
        Me.cfopS.RegraValidaçãoMensagem = Nothing
        Me.cfopS.Size = New System.Drawing.Size(209, 23)
        Me.cfopS.TabIndex = 17
        Me.cfopS.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.cfopS.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Empresa"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Empresa
        '
        Me.Empresa.AceitaColarTexto = True
        Me.Empresa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Empresa.CasasDecimais = 0
        Me.Empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Empresa.CPObrigatorio = False
        Me.Empresa.CPObrigatorioMsg = Nothing
        Me.Empresa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Empresa.FlatBorder = True
        Me.Empresa.FlatBorderColor = System.Drawing.Color.Black
        Me.Empresa.FocusColor = System.Drawing.Color.Empty
        Me.Empresa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Empresa.HighlightBorderOnEnter = False
        Me.Empresa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Empresa.Location = New System.Drawing.Point(406, 24)
        Me.Empresa.MaxLength = 20
        Me.Empresa.Name = "Empresa"
        Me.Empresa.PreencherZeroEsqueda = False
        Me.Empresa.RegraValidação = Nothing
        Me.Empresa.RegraValidaçãoMensagem = Nothing
        Me.Empresa.Size = New System.Drawing.Size(209, 23)
        Me.Empresa.TabIndex = 15
        Me.Empresa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Empresa.ValorPadrao = Nothing
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(540, 305)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 24
        Me.btFechar.Text = "Fechar"
        '
        'CFOPse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CFOPse"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CFOP entrada e Saida - T274"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btExcluir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ctb As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cfopE As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cfopS As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Empresa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCFOPs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCFOPe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCTB As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
