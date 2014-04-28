<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdemEmbarqueVisualizador
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
        Me.components = New System.ComponentModel.Container
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.MenuRapido = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VisualizarImpressãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FinalizarVisualizadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Ordem = New TexBoxFocusNet.TextBoxFocusNet
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.MenuRapido.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.BackColor = System.Drawing.Color.Ivory
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.MyLista.ContextMenuStrip = Me.MenuRapido
        Me.MyLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(0, 0)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(615, 266)
        Me.MyLista.TabIndex = 1
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ordem"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cliente"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Emissão"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Saida"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 85
        '
        'MenuRapido
        '
        Me.MenuRapido.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarImpressãoToolStripMenuItem, Me.FinalizarVisualizadorToolStripMenuItem})
        Me.MenuRapido.Name = "MenuRapido"
        Me.MenuRapido.Size = New System.Drawing.Size(295, 48)
        '
        'VisualizarImpressãoToolStripMenuItem
        '
        Me.VisualizarImpressãoToolStripMenuItem.Name = "VisualizarImpressãoToolStripMenuItem"
        Me.VisualizarImpressãoToolStripMenuItem.Size = New System.Drawing.Size(294, 22)
        Me.VisualizarImpressãoToolStripMenuItem.Text = "Visualizar Ordem Selecionada (Impressão)"
        '
        'FinalizarVisualizadorToolStripMenuItem
        '
        Me.FinalizarVisualizadorToolStripMenuItem.Name = "FinalizarVisualizadorToolStripMenuItem"
        Me.FinalizarVisualizadorToolStripMenuItem.Size = New System.Drawing.Size(294, 22)
        Me.FinalizarVisualizadorToolStripMenuItem.Text = "Finalizar Visualizador"
        '
        'Ordem
        '
        Me.Ordem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ordem.CasasDecimais = 0
        Me.Ordem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ordem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ordem.FocusColor = System.Drawing.Color.Empty
        Me.Ordem.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ordem.Location = New System.Drawing.Point(503, 234)
        Me.Ordem.Name = "Ordem"
        Me.Ordem.RegraValidação = Nothing
        Me.Ordem.Size = New System.Drawing.Size(100, 20)
        Me.Ordem.TabIndex = 114
        Me.Ordem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ordem.ValorPadrao = Nothing
        Me.Ordem.Visible = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sit"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 40
        '
        'OrdemEmbarqueVisualizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 266)
        Me.Controls.Add(Me.Ordem)
        Me.Controls.Add(Me.MyLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OrdemEmbarqueVisualizador"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizador de Ordem de Embarque Emitida"
        Me.MenuRapido.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuRapido As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VisualizarImpressãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalizarVisualizadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ordem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
