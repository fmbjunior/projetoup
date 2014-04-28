<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstoqueFindProdutoFabrica
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
        Me.Atualizar = New System.Windows.Forms.Button
        Me.MyLista = New System.Windows.Forms.ListView
        Me.Col2 = New System.Windows.Forms.ColumnHeader
        Me.Col3 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtProcura = New System.Windows.Forms.TextBox
        Me.Fechar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Atualizar
        '
        Me.Atualizar.Image = Global.Up.My.Resources.Resources.Atualizar
        Me.Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Atualizar.Location = New System.Drawing.Point(162, 356)
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
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col2, Me.Col3})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.LabelEdit = True
        Me.MyLista.Location = New System.Drawing.Point(12, 41)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(376, 307)
        Me.MyLista.TabIndex = 2
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'Col2
        '
        Me.Col2.Text = "Código"
        Me.Col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Col3
        '
        Me.Col3.Text = "Descrição"
        Me.Col3.Width = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Procurar"
        '
        'TxtProcura
        '
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.Location = New System.Drawing.Point(64, 13)
        Me.TxtProcura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.Size = New System.Drawing.Size(324, 20)
        Me.TxtProcura.TabIndex = 0
        '
        'Fechar
        '
        Me.Fechar.Image = Global.Up.My.Resources.Resources.Sair
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(278, 356)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(110, 39)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar(F11)"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'EstoqueFindProdutoFabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(399, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.Atualizar)
        Me.Controls.Add(Me.MyLista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtProcura)
        Me.Controls.Add(Me.Fechar)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EstoqueFindProdutoFabrica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurar Produto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Atualizar As System.Windows.Forms.Button
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents Fechar As System.Windows.Forms.Button
End Class
