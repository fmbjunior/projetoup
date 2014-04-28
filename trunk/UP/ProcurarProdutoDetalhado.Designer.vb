<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcurarProdutoDetalhado
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
        Me.TipoProcura = New System.Windows.Forms.GroupBox
        Me.Almoxarifado = New System.Windows.Forms.RadioButton
        Me.MateriaPrima = New System.Windows.Forms.RadioButton
        Me.ProdutoEmpresa = New System.Windows.Forms.RadioButton
        Me.Atualizar = New System.Windows.Forms.Button
        Me.MyLista = New System.Windows.Forms.ListView
        Me.Col2 = New System.Windows.Forms.ColumnHeader
        Me.Col3 = New System.Windows.Forms.ColumnHeader
        Me.Col4 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtProcura = New System.Windows.Forms.TextBox
        Me.Fechar = New System.Windows.Forms.Button
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.TipoProcura.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TipoProcura
        '
        Me.TipoProcura.Controls.Add(Me.Almoxarifado)
        Me.TipoProcura.Controls.Add(Me.MateriaPrima)
        Me.TipoProcura.Controls.Add(Me.ProdutoEmpresa)
        Me.TipoProcura.Location = New System.Drawing.Point(7, 12)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(524, 43)
        Me.TipoProcura.TabIndex = 3
        Me.TipoProcura.TabStop = False
        Me.TipoProcura.Text = "Tipo de Procura"
        '
        'Almoxarifado
        '
        Me.Almoxarifado.AutoSize = True
        Me.Almoxarifado.Location = New System.Drawing.Point(242, 16)
        Me.Almoxarifado.Name = "Almoxarifado"
        Me.Almoxarifado.Size = New System.Drawing.Size(90, 20)
        Me.Almoxarifado.TabIndex = 2
        Me.Almoxarifado.TabStop = True
        Me.Almoxarifado.Text = "Almoxarifado"
        Me.Almoxarifado.UseVisualStyleBackColor = True
        '
        'MateriaPrima
        '
        Me.MateriaPrima.AutoSize = True
        Me.MateriaPrima.Location = New System.Drawing.Point(140, 16)
        Me.MateriaPrima.Name = "MateriaPrima"
        Me.MateriaPrima.Size = New System.Drawing.Size(96, 20)
        Me.MateriaPrima.TabIndex = 1
        Me.MateriaPrima.TabStop = True
        Me.MateriaPrima.Text = "Matéria Prima"
        Me.MateriaPrima.UseVisualStyleBackColor = True
        '
        'ProdutoEmpresa
        '
        Me.ProdutoEmpresa.AutoSize = True
        Me.ProdutoEmpresa.Location = New System.Drawing.Point(23, 16)
        Me.ProdutoEmpresa.Name = "ProdutoEmpresa"
        Me.ProdutoEmpresa.Size = New System.Drawing.Size(111, 20)
        Me.ProdutoEmpresa.TabIndex = 0
        Me.ProdutoEmpresa.TabStop = True
        Me.ProdutoEmpresa.Text = "Produto Empresa"
        Me.ProdutoEmpresa.UseVisualStyleBackColor = True
        '
        'Atualizar
        '
        Me.Atualizar.Image = Global.Up.My.Resources.Resources.Atualizar
        Me.Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Atualizar.Location = New System.Drawing.Point(305, 406)
        Me.Atualizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Atualizar.Name = "Atualizar"
        Me.Atualizar.Size = New System.Drawing.Size(110, 39)
        Me.Atualizar.TabIndex = 4
        Me.Atualizar.Text = "Atualizar"
        Me.Atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Atualizar.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col2, Me.Col3, Me.Col4})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(7, 90)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(524, 308)
        Me.MyLista.TabIndex = 2
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
        Me.Col3.Width = 300
        '
        'Col4
        '
        Me.Col4.Text = "Estoque"
        Me.Col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Col4.Width = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Procurar"
        '
        'TxtProcura
        '
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.Location = New System.Drawing.Point(59, 62)
        Me.TxtProcura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.Size = New System.Drawing.Size(472, 20)
        Me.TxtProcura.TabIndex = 0
        '
        'Fechar
        '
        Me.Fechar.Image = Global.Up.My.Resources.Resources.Sair
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(421, 406)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(110, 39)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar(F11)"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.TipoProcura)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Atualizar)
        Me.Fundo.Controls.Add(Me.TxtProcura)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(543, 455)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 6
        Me.Fundo.Text = "PanelEx1"
        '
        'ProcurarProdutoDetalhado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(543, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProcurarProdutoDetalhado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar Produto/Matéria Prima"
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TipoProcura As System.Windows.Forms.GroupBox
    Friend WithEvents MateriaPrima As System.Windows.Forms.RadioButton
    Friend WithEvents ProdutoEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents Atualizar As System.Windows.Forms.Button
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Almoxarifado As System.Windows.Forms.RadioButton
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Col4 As System.Windows.Forms.ColumnHeader
End Class
