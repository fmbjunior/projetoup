<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcurarProdutoCtrlPedido
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
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.Col2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProcura = New System.Windows.Forms.TextBox()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Opc = New System.Windows.Forms.GroupBox()
        Me.Almoxarifado = New System.Windows.Forms.RadioButton()
        Me.MateriaPrima = New System.Windows.Forms.RadioButton()
        Me.ProdutoEmpresa = New System.Windows.Forms.RadioButton()
        Me.Atualizar = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Fundo.SuspendLayout()
        Me.Opc.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col2, Me.Col3})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(14, 93)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(467, 382)
        Me.MyLista.TabIndex = 3
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'Col2
        '
        Me.Col2.Text = "Código"
        Me.Col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col2.Width = 80
        '
        'Col3
        '
        Me.Col3.Text = "Descrição"
        Me.Col3.Width = 360
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Procurar"
        '
        'TxtProcura
        '
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.Location = New System.Drawing.Point(66, 65)
        Me.TxtProcura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.Size = New System.Drawing.Size(415, 20)
        Me.TxtProcura.TabIndex = 2
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Opc)
        Me.Fundo.Controls.Add(Me.Atualizar)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.TxtProcura)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(493, 523)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.LightSkyBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Opc
        '
        Me.Opc.Controls.Add(Me.Almoxarifado)
        Me.Opc.Controls.Add(Me.MateriaPrima)
        Me.Opc.Controls.Add(Me.ProdutoEmpresa)
        Me.Opc.Location = New System.Drawing.Point(14, 3)
        Me.Opc.Name = "Opc"
        Me.Opc.Size = New System.Drawing.Size(467, 55)
        Me.Opc.TabIndex = 0
        Me.Opc.TabStop = False
        Me.Opc.Text = "Opção"
        '
        'Almoxarifado
        '
        Me.Almoxarifado.AutoSize = True
        Me.Almoxarifado.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Almoxarifado.ForeColor = System.Drawing.Color.DarkBlue
        Me.Almoxarifado.Location = New System.Drawing.Point(345, 23)
        Me.Almoxarifado.Name = "Almoxarifado"
        Me.Almoxarifado.Size = New System.Drawing.Size(100, 20)
        Me.Almoxarifado.TabIndex = 2
        Me.Almoxarifado.TabStop = True
        Me.Almoxarifado.Text = "Almoxarifado"
        Me.Almoxarifado.UseVisualStyleBackColor = True
        '
        'MateriaPrima
        '
        Me.MateriaPrima.AutoSize = True
        Me.MateriaPrima.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MateriaPrima.ForeColor = System.Drawing.Color.DarkBlue
        Me.MateriaPrima.Location = New System.Drawing.Point(191, 23)
        Me.MateriaPrima.Name = "MateriaPrima"
        Me.MateriaPrima.Size = New System.Drawing.Size(104, 20)
        Me.MateriaPrima.TabIndex = 1
        Me.MateriaPrima.TabStop = True
        Me.MateriaPrima.Text = "Matéria Prima"
        Me.MateriaPrima.UseVisualStyleBackColor = True
        '
        'ProdutoEmpresa
        '
        Me.ProdutoEmpresa.AutoSize = True
        Me.ProdutoEmpresa.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdutoEmpresa.ForeColor = System.Drawing.Color.DarkBlue
        Me.ProdutoEmpresa.Location = New System.Drawing.Point(28, 23)
        Me.ProdutoEmpresa.Name = "ProdutoEmpresa"
        Me.ProdutoEmpresa.Size = New System.Drawing.Size(117, 20)
        Me.ProdutoEmpresa.TabIndex = 0
        Me.ProdutoEmpresa.TabStop = True
        Me.ProdutoEmpresa.Text = "Produto Empresa"
        Me.ProdutoEmpresa.UseVisualStyleBackColor = True
        '
        'Atualizar
        '
        Me.Atualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Atualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Atualizar.Location = New System.Drawing.Point(291, 482)
        Me.Atualizar.Name = "Atualizar"
        Me.Atualizar.Size = New System.Drawing.Size(92, 34)
        Me.Atualizar.TabIndex = 4
        Me.Atualizar.Text = "Atualizar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(389, 482)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(92, 34)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar"
        '
        'ProcurarProdutoCtrlPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(493, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProcurarProdutoCtrlPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar Produto/Matéria Prima - T195"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.Opc.ResumeLayout(False)
        Me.Opc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Atualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Opc As System.Windows.Forms.GroupBox
    Friend WithEvents ProdutoEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents Almoxarifado As System.Windows.Forms.RadioButton
    Friend WithEvents MateriaPrima As System.Windows.Forms.RadioButton
End Class
