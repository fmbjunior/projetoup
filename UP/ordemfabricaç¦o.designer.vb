<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdemFabricação
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.AutorizadoPor = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataEmissão = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumeroPedido = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumeroOF = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fechar = New System.Windows.Forms.Button
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.MenuMyLista = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LançarItensNaOFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportarItensDoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImprimirOFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Editar = New System.Windows.Forms.Button
        Me.Localizar = New System.Windows.Forms.Button
        Me.Salvar = New System.Windows.Forms.Button
        Me.Novo = New System.Windows.Forms.Button
        Me.NomeCliente = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DataEntrega = New TexBoxFocusNet.TextBoxFocusNet
        Me.ExcluirItenSelecionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Confirmada = New TexBoxFocusNet.TextBoxFocusNet
        Me.ConfirmarOFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuMyLista.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Autorizado Por"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AutorizadoPor
        '
        Me.AutorizadoPor.AutoCompleteCustomSource.AddRange(New String() {"José Irineu Antonio", "Rinaldo Serrano Soares", "Daniele Cristina Sarruf"})
        Me.AutorizadoPor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AutorizadoPor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.AutorizadoPor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.AutorizadoPor.CasasDecimais = 0
        Me.AutorizadoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AutorizadoPor.FocusColor = System.Drawing.Color.MistyRose
        Me.AutorizadoPor.FocusColorEnd = System.Drawing.Color.Empty
        Me.AutorizadoPor.Location = New System.Drawing.Point(137, 87)
        Me.AutorizadoPor.MaxLength = 50
        Me.AutorizadoPor.Name = "AutorizadoPor"
        Me.AutorizadoPor.Size = New System.Drawing.Size(436, 20)
        Me.AutorizadoPor.TabIndex = 11
        Me.AutorizadoPor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AutorizadoPor.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data Emissão"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataEmissão
        '
        Me.DataEmissão.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataEmissão.CasasDecimais = 0
        Me.DataEmissão.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataEmissão.FocusColor = System.Drawing.Color.MistyRose
        Me.DataEmissão.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataEmissão.Location = New System.Drawing.Point(137, 61)
        Me.DataEmissão.MaxLength = 10
        Me.DataEmissão.Name = "DataEmissão"
        Me.DataEmissão.Size = New System.Drawing.Size(78, 20)
        Me.DataEmissão.TabIndex = 7
        Me.DataEmissão.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataEmissão.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataEmissão.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(266, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pedido"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumeroPedido
        '
        Me.NumeroPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NumeroPedido.CasasDecimais = 0
        Me.NumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroPedido.FocusColor = System.Drawing.Color.MistyRose
        Me.NumeroPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroPedido.Location = New System.Drawing.Point(355, 12)
        Me.NumeroPedido.MaxLength = 10
        Me.NumeroPedido.Name = "NumeroPedido"
        Me.NumeroPedido.Size = New System.Drawing.Size(78, 20)
        Me.NumeroPedido.TabIndex = 3
        Me.NumeroPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroPedido.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número OF"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumeroOF
        '
        Me.NumeroOF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NumeroOF.CasasDecimais = 0
        Me.NumeroOF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroOF.FocusColor = System.Drawing.Color.MistyRose
        Me.NumeroOF.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroOF.Location = New System.Drawing.Point(137, 9)
        Me.NumeroOF.MaxLength = 10
        Me.NumeroOF.Name = "NumeroOF"
        Me.NumeroOF.Size = New System.Drawing.Size(78, 20)
        Me.NumeroOF.TabIndex = 1
        Me.NumeroOF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumeroOF.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroOF.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Image = Global.Up.My.Resources.Resources.Sair
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(468, 314)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(107, 40)
        Me.Fechar.TabIndex = 17
        Me.Fechar.Text = "Fechar-F11"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader2})
        Me.MyLista.ContextMenuStrip = Me.MenuMyLista
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(15, 113)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(558, 193)
        Me.MyLista.TabIndex = 12
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Produto"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descrição"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Qtd "
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Produzido"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "A Produzir"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NumeroOF"
        Me.ColumnHeader2.Width = 0
        '
        'MenuMyLista
        '
        Me.MenuMyLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LançarItensNaOFToolStripMenuItem, Me.ExcluirItenSelecionadoToolStripMenuItem, Me.ImportarItensDoPedidoToolStripMenuItem, Me.ToolStripMenuItem1, Me.ConfirmarOFToolStripMenuItem, Me.ImprimirOFToolStripMenuItem})
        Me.MenuMyLista.Name = "MenuMyLista"
        Me.MenuMyLista.Size = New System.Drawing.Size(206, 142)
        '
        'LançarItensNaOFToolStripMenuItem
        '
        Me.LançarItensNaOFToolStripMenuItem.Name = "LançarItensNaOFToolStripMenuItem"
        Me.LançarItensNaOFToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.LançarItensNaOFToolStripMenuItem.Text = "Lançar Itens na OF"
        '
        'ImportarItensDoPedidoToolStripMenuItem
        '
        Me.ImportarItensDoPedidoToolStripMenuItem.Name = "ImportarItensDoPedidoToolStripMenuItem"
        Me.ImportarItensDoPedidoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ImportarItensDoPedidoToolStripMenuItem.Text = "Importar Itens do Pedido"
        '
        'ImprimirOFToolStripMenuItem
        '
        Me.ImprimirOFToolStripMenuItem.Name = "ImprimirOFToolStripMenuItem"
        Me.ImprimirOFToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ImprimirOFToolStripMenuItem.Text = "Imprimir OF"
        '
        'Editar
        '
        Me.Editar.Image = Global.Up.My.Resources.Resources.Editar
        Me.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar.Location = New System.Drawing.Point(128, 313)
        Me.Editar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(107, 40)
        Me.Editar.TabIndex = 16
        Me.Editar.Text = "Editar-F8"
        Me.Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Localizar
        '
        Me.Localizar.Image = Global.Up.My.Resources.Resources.Localizar
        Me.Localizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizar.Location = New System.Drawing.Point(10, 313)
        Me.Localizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Localizar.Name = "Localizar"
        Me.Localizar.Size = New System.Drawing.Size(112, 40)
        Me.Localizar.TabIndex = 14
        Me.Localizar.Text = "Localizar-F4"
        Me.Localizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizar.UseVisualStyleBackColor = True
        '
        'Salvar
        '
        Me.Salvar.Image = Global.Up.My.Resources.Resources.Salvar
        Me.Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salvar.Location = New System.Drawing.Point(354, 313)
        Me.Salvar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(108, 40)
        Me.Salvar.TabIndex = 13
        Me.Salvar.Text = "Salvar-F10"
        Me.Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Salvar.UseVisualStyleBackColor = True
        '
        'Novo
        '
        Me.Novo.Image = Global.Up.My.Resources.Resources.LimparBorracha
        Me.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Novo.Location = New System.Drawing.Point(241, 313)
        Me.Novo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Novo.Name = "Novo"
        Me.Novo.Size = New System.Drawing.Size(108, 40)
        Me.Novo.TabIndex = 15
        Me.Novo.Text = "Novo-F9"
        Me.Novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Novo.UseVisualStyleBackColor = True
        '
        'NomeCliente
        '
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeCliente.CasasDecimais = 0
        Me.NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeCliente.FocusColor = System.Drawing.Color.MistyRose
        Me.NomeCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeCliente.Location = New System.Drawing.Point(137, 35)
        Me.NomeCliente.MaxLength = 50
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.Size = New System.Drawing.Size(436, 20)
        Me.NomeCliente.TabIndex = 5
        Me.NomeCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeCliente.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nome Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(269, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Data Entrega"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataEntrega
        '
        Me.DataEntrega.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataEntrega.CasasDecimais = 0
        Me.DataEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataEntrega.FocusColor = System.Drawing.Color.MistyRose
        Me.DataEntrega.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataEntrega.Location = New System.Drawing.Point(355, 61)
        Me.DataEntrega.MaxLength = 10
        Me.DataEntrega.Name = "DataEntrega"
        Me.DataEntrega.Size = New System.Drawing.Size(78, 20)
        Me.DataEntrega.TabIndex = 9
        Me.DataEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataEntrega.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataEntrega.ValorPadrao = Nothing
        '
        'ExcluirItenSelecionadoToolStripMenuItem
        '
        Me.ExcluirItenSelecionadoToolStripMenuItem.Name = "ExcluirItenSelecionadoToolStripMenuItem"
        Me.ExcluirItenSelecionadoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ExcluirItenSelecionadoToolStripMenuItem.Text = "Excluir Iten Selecionado"
        '
        'Confirmada
        '
        Me.Confirmada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Confirmada.CasasDecimais = 0
        Me.Confirmada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Confirmada.FocusColor = System.Drawing.Color.MistyRose
        Me.Confirmada.FocusColorEnd = System.Drawing.Color.Empty
        Me.Confirmada.Location = New System.Drawing.Point(497, 61)
        Me.Confirmada.MaxLength = 10
        Me.Confirmada.Name = "Confirmada"
        Me.Confirmada.Size = New System.Drawing.Size(78, 20)
        Me.Confirmada.TabIndex = 18
        Me.Confirmada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Confirmada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Confirmada.ValorPadrao = Nothing
        Me.Confirmada.Visible = False
        '
        'ConfirmarOFToolStripMenuItem
        '
        Me.ConfirmarOFToolStripMenuItem.Name = "ConfirmarOFToolStripMenuItem"
        Me.ConfirmarOFToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ConfirmarOFToolStripMenuItem.Text = "Confirmar OF"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 6)
        '
        'OrdemFabricação
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(585, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.Confirmada)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataEntrega)
        Me.Controls.Add(Me.NomeCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumeroOF)
        Me.Controls.Add(Me.MyLista)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Localizar)
        Me.Controls.Add(Me.Salvar)
        Me.Controls.Add(Me.Novo)
        Me.Controls.Add(Me.AutorizadoPor)
        Me.Controls.Add(Me.Fechar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataEmissão)
        Me.Controls.Add(Me.NumeroPedido)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OrdemFabricação"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordem de Fabricação"
        Me.MenuMyLista.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AutorizadoPor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataEmissão As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumeroPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumeroOF As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents Localizar As System.Windows.Forms.Button
    Friend WithEvents Salvar As System.Windows.Forms.Button
    Friend WithEvents Novo As System.Windows.Forms.Button
    Friend WithEvents MenuMyLista As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LançarItensNaOFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarItensDoPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirOFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NomeCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataEntrega As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ExcluirItenSelecionadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Confirmada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConfirmarOFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
