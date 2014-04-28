<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarItemMP
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionarItemMP))
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TotalItem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.xxxx = New DevComponents.DotNetBar.LabelX()
        Me.cboTam = New CBOAutoCompleteFocus.CboFocus()
        Me.ValorVenda = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Qtde = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Descricao = New TexBoxFocusNet.TextBoxFocusNet()
        Me.btnAdicionarItem = New DevComponents.DotNetBar.ButtonX()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtIdLinha = New TexBoxFocusNet.TextBoxFocusNet()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(211, 162)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(143, 23)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "TOTAL ITEM"
        '
        'TotalItem
        '
        Me.TotalItem.AceitaColarTexto = True
        Me.TotalItem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalItem.CasasDecimais = 2
        Me.TotalItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalItem.CPObrigatorio = False
        Me.TotalItem.CPObrigatorioMsg = Nothing
        Me.TotalItem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.TotalItem.FlatBorder = False
        Me.TotalItem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.TotalItem.FocusColor = System.Drawing.Color.Empty
        Me.TotalItem.FocusColorEnd = System.Drawing.Color.Empty
        Me.TotalItem.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalItem.HighlightBorderOnEnter = False
        Me.TotalItem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.TotalItem.Location = New System.Drawing.Point(362, 155)
        Me.TotalItem.MaxLength = 10
        Me.TotalItem.Name = "TotalItem"
        Me.TotalItem.PreencherZeroEsqueda = False
        Me.TotalItem.RegraValidação = Nothing
        Me.TotalItem.RegraValidaçãoMensagem = Nothing
        Me.TotalItem.Size = New System.Drawing.Size(171, 30)
        Me.TotalItem.TabIndex = 20
        Me.TotalItem.TabStop = False
        Me.TotalItem.Text = "0,00"
        Me.TotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalItem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.TotalItem.ValorPadrao = "0,00"
        '
        'xxxx
        '
        Me.xxxx.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.xxxx.BackgroundStyle.Class = ""
        Me.xxxx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.xxxx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xxxx.ForeColor = System.Drawing.Color.Black
        Me.xxxx.Location = New System.Drawing.Point(171, 116)
        Me.xxxx.Name = "xxxx"
        Me.xxxx.Size = New System.Drawing.Size(60, 20)
        Me.xxxx.TabIndex = 15
        Me.xxxx.Text = "Tamanho"
        Me.xxxx.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'cboTam
        '
        Me.cboTam.Auto_Complete = True
        Me.cboTam.AutoLimitar_Lista = True
        Me.cboTam.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.cboTam.CPObrigatorio = False
        Me.cboTam.CPObrigatorioMsg = Nothing
        Me.cboTam.FlatBorder = False
        Me.cboTam.FlatBorderColor = System.Drawing.Color.DimGray
        Me.cboTam.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTam.FormattingEnabled = True
        Me.cboTam.HighlightBorderColor = System.Drawing.Color.Empty
        Me.cboTam.HighlightBorderOnEnter = False
        Me.cboTam.Items.AddRange(New Object() {"G", "GG", "M", "P", "PP", "S/T", "XGG"})
        Me.cboTam.Location = New System.Drawing.Point(237, 113)
        Me.cboTam.Name = "cboTam"
        Me.cboTam.Size = New System.Drawing.Size(95, 24)
        Me.cboTam.Sorted = True
        Me.cboTam.TabIndex = 16
        '
        'ValorVenda
        '
        Me.ValorVenda.AceitaColarTexto = True
        Me.ValorVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorVenda.CasasDecimais = 4
        Me.ValorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorVenda.CPObrigatorio = False
        Me.ValorVenda.CPObrigatorioMsg = Nothing
        Me.ValorVenda.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorVenda.FlatBorder = False
        Me.ValorVenda.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorVenda.FocusColor = System.Drawing.Color.Empty
        Me.ValorVenda.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorVenda.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorVenda.HighlightBorderOnEnter = False
        Me.ValorVenda.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorVenda.Location = New System.Drawing.Point(438, 116)
        Me.ValorVenda.MaxLength = 10
        Me.ValorVenda.Name = "ValorVenda"
        Me.ValorVenda.PreencherZeroEsqueda = False
        Me.ValorVenda.RegraValidação = Nothing
        Me.ValorVenda.RegraValidaçãoMensagem = Nothing
        Me.ValorVenda.Size = New System.Drawing.Size(95, 23)
        Me.ValorVenda.TabIndex = 18
        Me.ValorVenda.Text = "0,00"
        Me.ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorVenda.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorVenda.ValorPadrao = "0,00"
        '
        'Qtde
        '
        Me.Qtde.AceitaColarTexto = True
        Me.Qtde.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtde.CasasDecimais = 3
        Me.Qtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtde.CPObrigatorio = False
        Me.Qtde.CPObrigatorioMsg = Nothing
        Me.Qtde.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtde.FlatBorder = False
        Me.Qtde.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Qtde.FocusColor = System.Drawing.Color.Empty
        Me.Qtde.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtde.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qtde.HighlightBorderOnEnter = False
        Me.Qtde.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Qtde.Location = New System.Drawing.Point(68, 113)
        Me.Qtde.MaxLength = 15
        Me.Qtde.Name = "Qtde"
        Me.Qtde.PreencherZeroEsqueda = False
        Me.Qtde.RegraValidação = Nothing
        Me.Qtde.RegraValidaçãoMensagem = Nothing
        Me.Qtde.Size = New System.Drawing.Size(95, 23)
        Me.Qtde.TabIndex = 14
        Me.Qtde.Text = "0,000"
        Me.Qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtde.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtde.ValorPadrao = Nothing
        '
        'Descricao
        '
        Me.Descricao.AceitaColarTexto = True
        Me.Descricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Descricao.CasasDecimais = 2
        Me.Descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descricao.CPObrigatorio = False
        Me.Descricao.CPObrigatorioMsg = Nothing
        Me.Descricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Descricao.FlatBorder = False
        Me.Descricao.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Descricao.FocusColor = System.Drawing.Color.Empty
        Me.Descricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descricao.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descricao.HighlightBorderOnEnter = False
        Me.Descricao.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Descricao.Location = New System.Drawing.Point(68, 12)
        Me.Descricao.MaxLength = 200
        Me.Descricao.Multiline = True
        Me.Descricao.Name = "Descricao"
        Me.Descricao.PreencherZeroEsqueda = False
        Me.Descricao.RegraValidação = Nothing
        Me.Descricao.RegraValidaçãoMensagem = Nothing
        Me.Descricao.Size = New System.Drawing.Size(465, 95)
        Me.Descricao.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.Descricao, "Use a Tecla CTRL+Enter para um nova linha.")
        Me.Descricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descricao.ValorPadrao = Nothing
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionarItem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAdicionarItem.Image = CType(resources.GetObject("btnAdicionarItem.Image"), System.Drawing.Image)
        Me.btnAdicionarItem.Location = New System.Drawing.Point(12, 205)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.Size = New System.Drawing.Size(138, 33)
        Me.btnAdicionarItem.TabIndex = 31
        Me.btnAdicionarItem.Text = "Salvar"
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(156, 205)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(137, 33)
        Me.btnFechar.TabIndex = 32
        Me.btnFechar.Text = "Fechar"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 536
        Me.LineShape1.Y1 = 198
        Me.LineShape1.Y2 = 198
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(546, 241)
        Me.ShapeContainer1.TabIndex = 33
        Me.ShapeContainer1.TabStop = False
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(3, 113)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(60, 20)
        Me.LabelX1.TabIndex = 34
        Me.LabelX1.Text = "Qtde"
        Me.LabelX1.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(3, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(60, 20)
        Me.LabelX2.TabIndex = 34
        Me.LabelX2.Text = "Descrição"
        Me.LabelX2.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(350, 116)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(60, 20)
        Me.LabelX3.TabIndex = 34
        Me.LabelX3.Text = "Valor Unit."
        Me.LabelX3.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'txtIdLinha
        '
        Me.txtIdLinha.AceitaColarTexto = True
        Me.txtIdLinha.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtIdLinha.CasasDecimais = 2
        Me.txtIdLinha.CPObrigatorio = False
        Me.txtIdLinha.CPObrigatorioMsg = Nothing
        Me.txtIdLinha.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtIdLinha.FlatBorder = False
        Me.txtIdLinha.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtIdLinha.FocusColor = System.Drawing.Color.Empty
        Me.txtIdLinha.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtIdLinha.HighlightBorderOnEnter = False
        Me.txtIdLinha.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtIdLinha.Location = New System.Drawing.Point(12, 167)
        Me.txtIdLinha.Name = "txtIdLinha"
        Me.txtIdLinha.PreencherZeroEsqueda = False
        Me.txtIdLinha.RegraValidação = Nothing
        Me.txtIdLinha.RegraValidaçãoMensagem = Nothing
        Me.txtIdLinha.Size = New System.Drawing.Size(100, 20)
        Me.txtIdLinha.TabIndex = 35
        Me.txtIdLinha.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtIdLinha.ValorPadrao = Nothing
        Me.txtIdLinha.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.Tag = ""
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Dicas"
        '
        'frmAdicionarItemMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnFechar
        Me.ClientSize = New System.Drawing.Size(546, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtIdLinha)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnAdicionarItem)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TotalItem)
        Me.Controls.Add(Me.xxxx)
        Me.Controls.Add(Me.cboTam)
        Me.Controls.Add(Me.ValorVenda)
        Me.Controls.Add(Me.Qtde)
        Me.Controls.Add(Me.Descricao)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAdicionarItemMP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TotalItem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents xxxx As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboTam As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents ValorVenda As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Qtde As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Descricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btnAdicionarItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdLinha As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
