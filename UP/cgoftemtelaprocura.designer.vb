<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CGOFtemTelaProcura
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
        Me.TxtProcura = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MyLista = New System.Windows.Forms.ListView
        Me.Col1 = New System.Windows.Forms.ColumnHeader
        Me.Col2 = New System.Windows.Forms.ColumnHeader
        Me.MyBarra = New System.Windows.Forms.ProgressBar
        Me.Atualizar = New System.Windows.Forms.Button
        Me.Fechar = New System.Windows.Forms.Button
        Me.TipoProcura = New System.Windows.Forms.GroupBox
        Me.AlfaNumerica = New System.Windows.Forms.RadioButton
        Me.CampoChave = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.TipoProcura.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtProcura
        '
        Me.TxtProcura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcura.Location = New System.Drawing.Point(67, 58)
        Me.TxtProcura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProcura.Name = "TxtProcura"
        Me.TxtProcura.Size = New System.Drawing.Size(391, 20)
        Me.TxtProcura.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Procurar"
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1, Me.Col2})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.HideSelection = False
        Me.MyLista.Location = New System.Drawing.Point(15, 86)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(443, 260)
        Me.MyLista.TabIndex = 2
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
        Me.Col2.Text = "Descrição"
        Me.Col2.Width = 355
        '
        'MyBarra
        '
        Me.MyBarra.Location = New System.Drawing.Point(15, 370)
        Me.MyBarra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyBarra.Name = "MyBarra"
        Me.MyBarra.Size = New System.Drawing.Size(239, 23)
        Me.MyBarra.TabIndex = 3
        Me.MyBarra.Visible = False
        '
        'Atualizar
        '
        Me.Atualizar.Image = Global.E_Focus.My.Resources.Resources.Atualizar
        Me.Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Atualizar.Location = New System.Drawing.Point(260, 354)
        Me.Atualizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Atualizar.Name = "Atualizar"
        Me.Atualizar.Size = New System.Drawing.Size(96, 39)
        Me.Atualizar.TabIndex = 4
        Me.Atualizar.Text = "Atualizar"
        Me.Atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Atualizar.UseVisualStyleBackColor = True
        '
        'Fechar
        '
        Me.Fechar.Image = Global.E_Focus.My.Resources.Resources.Sair
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(362, 354)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(96, 39)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'TipoProcura
        '
        Me.TipoProcura.BackColor = System.Drawing.Color.Transparent
        Me.TipoProcura.Controls.Add(Me.AlfaNumerica)
        Me.TipoProcura.Controls.Add(Me.CampoChave)
        Me.TipoProcura.Location = New System.Drawing.Point(15, 8)
        Me.TipoProcura.Name = "TipoProcura"
        Me.TipoProcura.Size = New System.Drawing.Size(443, 43)
        Me.TipoProcura.TabIndex = 7
        Me.TipoProcura.TabStop = False
        Me.TipoProcura.Text = "Tipo de Procura"
        '
        'AlfaNumerica
        '
        Me.AlfaNumerica.AutoSize = True
        Me.AlfaNumerica.Location = New System.Drawing.Point(127, 16)
        Me.AlfaNumerica.Name = "AlfaNumerica"
        Me.AlfaNumerica.Size = New System.Drawing.Size(85, 20)
        Me.AlfaNumerica.TabIndex = 1
        Me.AlfaNumerica.TabStop = True
        Me.AlfaNumerica.Text = "Alfanuméica"
        Me.AlfaNumerica.UseVisualStyleBackColor = True
        '
        'CampoChave
        '
        Me.CampoChave.AutoSize = True
        Me.CampoChave.Location = New System.Drawing.Point(23, 16)
        Me.CampoChave.Name = "CampoChave"
        Me.CampoChave.Size = New System.Drawing.Size(93, 20)
        Me.CampoChave.TabIndex = 0
        Me.CampoChave.TabStop = True
        Me.CampoChave.Text = "Campo Chave"
        Me.CampoChave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "F5-Refaz a Consulta"
        '
        'TelaProcura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(470, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TipoProcura)
        Me.Controls.Add(Me.Atualizar)
        Me.Controls.Add(Me.MyBarra)
        Me.Controls.Add(Me.MyLista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtProcura)
        Me.Controls.Add(Me.Fechar)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TelaProcura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar"
        Me.TipoProcura.ResumeLayout(False)
        Me.TipoProcura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents TxtProcura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents MyBarra As System.Windows.Forms.ProgressBar
    Friend WithEvents Atualizar As System.Windows.Forms.Button
    Friend WithEvents Col1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TipoProcura As System.Windows.Forms.GroupBox
    Friend WithEvents AlfaNumerica As System.Windows.Forms.RadioButton
    Friend WithEvents CampoChave As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
