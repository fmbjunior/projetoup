<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoteInformarNF
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.NF = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.btDocSelec = New DevComponents.DotNetBar.ButtonX
        Me.Label3 = New System.Windows.Forms.Label
        Me.TSelecionado = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TDoc = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.FornecedorDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fornecedor = New TexBoxFocusNet.TextBoxFocusNet
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.MyLista = New System.Windows.Forms.ListView
        Me.Col1 = New System.Windows.Forms.ColumnHeader
        Me.Col2 = New System.Windows.Forms.ColumnHeader
        Me.Col3 = New System.Windows.Forms.ColumnHeader
        Me.Col4 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.NF)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.btDocSelec)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.TSelecionado)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.TDoc)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.FornecedorDesc)
        Me.Fundo.Controls.Add(Me.Fornecedor)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(652, 467)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.LightBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'NF
        '
        Me.NF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NF.CasasDecimais = 0
        Me.NF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NF.CPObrigatorio = False
        Me.NF.CPObrigatorioMsg = Nothing
        Me.NF.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NF.FocusColor = System.Drawing.Color.Empty
        Me.NF.FocusColorEnd = System.Drawing.Color.Empty
        Me.NF.Location = New System.Drawing.Point(84, 37)
        Me.NF.MaxLength = 6
        Me.NF.Name = "NF"
        Me.NF.RegraValidação = Nothing
        Me.NF.RegraValidaçãoMensagem = Nothing
        Me.NF.Size = New System.Drawing.Size(71, 20)
        Me.NF.TabIndex = 5
        Me.NF.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NF.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nº da NF"
        '
        'btDocSelec
        '
        Me.btDocSelec.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btDocSelec.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btDocSelec.Location = New System.Drawing.Point(357, 432)
        Me.btDocSelec.Name = "btDocSelec"
        Me.btDocSelec.Size = New System.Drawing.Size(202, 29)
        Me.btDocSelec.TabIndex = 12
        Me.btDocSelec.Text = "Atualizar Documentos Selecionados"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Verifique os Documentos depois de atualizados não poderão mais ser Retornados"
        '
        'TSelecionado
        '
        Me.TSelecionado.BackColor = System.Drawing.Color.Transparent
        Me.TSelecionado.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSelecionado.ForeColor = System.Drawing.Color.Navy
        Me.TSelecionado.Location = New System.Drawing.Point(550, 409)
        Me.TSelecionado.Name = "TSelecionado"
        Me.TSelecionado.Size = New System.Drawing.Size(85, 20)
        Me.TSelecionado.TabIndex = 11
        Me.TSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(428, 409)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total de Selecionado"
        '
        'TDoc
        '
        Me.TDoc.BackColor = System.Drawing.Color.Transparent
        Me.TDoc.ForeColor = System.Drawing.Color.Green
        Me.TDoc.Location = New System.Drawing.Point(550, 389)
        Me.TDoc.Name = "TDoc"
        Me.TDoc.Size = New System.Drawing.Size(85, 20)
        Me.TDoc.TabIndex = 9
        Me.TDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(428, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total de Documentos"
        '
        'FornecedorDesc
        '
        Me.FornecedorDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.FornecedorDesc.CasasDecimais = 0
        Me.FornecedorDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FornecedorDesc.CPObrigatorio = False
        Me.FornecedorDesc.CPObrigatorioMsg = Nothing
        Me.FornecedorDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.FornecedorDesc.FocusColor = System.Drawing.Color.Empty
        Me.FornecedorDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.FornecedorDesc.Location = New System.Drawing.Point(161, 12)
        Me.FornecedorDesc.MaxLength = 6
        Me.FornecedorDesc.Name = "FornecedorDesc"
        Me.FornecedorDesc.RegraValidação = Nothing
        Me.FornecedorDesc.RegraValidaçãoMensagem = Nothing
        Me.FornecedorDesc.Size = New System.Drawing.Size(474, 20)
        Me.FornecedorDesc.TabIndex = 3
        Me.FornecedorDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.FornecedorDesc.ValorPadrao = Nothing
        '
        'Fornecedor
        '
        Me.Fornecedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Fornecedor.CasasDecimais = 0
        Me.Fornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fornecedor.CPObrigatorio = False
        Me.Fornecedor.CPObrigatorioMsg = Nothing
        Me.Fornecedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Fornecedor.FocusColor = System.Drawing.Color.Empty
        Me.Fornecedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.Fornecedor.Location = New System.Drawing.Point(84, 12)
        Me.Fornecedor.MaxLength = 6
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.RegraValidação = Nothing
        Me.Fornecedor.RegraValidaçãoMensagem = Nothing
        Me.Fornecedor.Size = New System.Drawing.Size(71, 20)
        Me.Fornecedor.TabIndex = 2
        Me.Fornecedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Fornecedor.ValorPadrao = Nothing
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(565, 432)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 29)
        Me.btFechar.TabIndex = 0
        Me.btFechar.Text = "Fechar"
        '
        'MyLista
        '
        Me.MyLista.CheckBoxes = True
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1, Me.Col2, Me.Col3, Me.Col4})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.Location = New System.Drawing.Point(12, 64)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(623, 321)
        Me.MyLista.TabIndex = 6
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'Col1
        '
        Me.Col1.Text = "Código"
        Me.Col1.Width = 70
        '
        'Col2
        '
        Me.Col2.Text = "Fornecedor"
        Me.Col2.Width = 350
        '
        'Col3
        '
        Me.Col3.Text = "Documento"
        Me.Col3.Width = 90
        '
        'Col4
        '
        Me.Col4.Text = "Valor"
        Me.Col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col4.Width = 80
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fornecedor"
        '
        'LoteInformarNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LoteInformarNF"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informar NF em Lote de Pedido"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Col1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents FornecedorDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fornecedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents TDoc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TSelecionado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btDocSelec As DevComponents.DotNetBar.ButtonX
    Friend WithEvents NF As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
