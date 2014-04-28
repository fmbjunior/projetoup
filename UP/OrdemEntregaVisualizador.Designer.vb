<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdemEntregaVisualizador
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdemEntregaVisualizador))
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Ordem = New TexBoxFocusNet.TextBoxFocusNet()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.BackColor = System.Drawing.Color.White
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.MyLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(0, 0)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(611, 313)
        Me.MyLista.SmallImageList = Me.ImageList1
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
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sit"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 40
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Entrega18.png")
        Me.ImageList1.Images.SetKeyName(1, "EntregaCancelada18.png")
        '
        'Ordem
        '
        Me.Ordem.AceitaColarTexto = True
        Me.Ordem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ordem.CasasDecimais = 0
        Me.Ordem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ordem.CPObrigatorio = False
        Me.Ordem.CPObrigatorioMsg = Nothing
        Me.Ordem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ordem.FlatBorder = False
        Me.Ordem.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Ordem.FocusColor = System.Drawing.Color.Empty
        Me.Ordem.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ordem.HighlightBorderOnEnter = False
        Me.Ordem.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Ordem.Location = New System.Drawing.Point(475, 158)
        Me.Ordem.Name = "Ordem"
        Me.Ordem.PreencherZeroEsqueda = False
        Me.Ordem.RegraValidação = Nothing
        Me.Ordem.RegraValidaçãoMensagem = Nothing
        Me.Ordem.Size = New System.Drawing.Size(116, 23)
        Me.Ordem.TabIndex = 114
        Me.Ordem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ordem.ValorPadrao = Nothing
        Me.Ordem.Visible = False
        '
        'OrdemEntregaVisualizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 313)
        Me.Controls.Add(Me.MyLista)
        Me.Controls.Add(Me.Ordem)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OrdemEntregaVisualizador"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizador de Ordem de Entrega - T166"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ordem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
