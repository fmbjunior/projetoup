<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoAcompanhamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoAcompanhamento))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pedido = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Status = New TexBoxFocusNet.TextBoxFocusNet
        Me.ClienteNome = New TexBoxFocusNet.TextBoxFocusNet
        Me.Cnpj = New TexBoxFocusNet.TextBoxFocusNet
        Me.Ie = New TexBoxFocusNet.TextBoxFocusNet
        Me.CidadeEstado = New TexBoxFocusNet.TextBoxFocusNet
        Me.Telefone = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.AddItem = New System.Windows.Forms.Button
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColPedido = New System.Windows.Forms.ColumnHeader
        Me.ColSequencia = New System.Windows.Forms.ColumnHeader
        Me.ColDataLançamento = New System.Windows.Forms.ColumnHeader
        Me.ColUsuario = New System.Windows.Forms.ColumnHeader
        Me.ColHistorico = New System.Windows.Forms.ColumnHeader
        Me.ColLancInterno = New System.Windows.Forms.ColumnHeader
        Me.Acompanhamento = New System.Windows.Forms.Label
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.NovoBT = New System.Windows.Forms.ToolStripButton
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton
        Me.EditarBT = New System.Windows.Forms.ToolStripButton
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton
        Me.ImprimirBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.IdItem = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pedido"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pedido
        '
        Me.Pedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Pedido.CasasDecimais = 0
        Me.Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Pedido.FocusColor = System.Drawing.Color.Empty
        Me.Pedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.Pedido.Location = New System.Drawing.Point(115, 82)
        Me.Pedido.MaxLength = 8
        Me.Pedido.Name = "Pedido"
        Me.Pedido.RegraValidação = Nothing
        Me.Pedido.Size = New System.Drawing.Size(70, 20)
        Me.Pedido.TabIndex = 3
        Me.Pedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Pedido.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.Location = New System.Drawing.Point(115, 108)
        Me.Cliente.MaxLength = 8
        Me.Cliente.Name = "Cliente"
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.Size = New System.Drawing.Size(70, 20)
        Me.Cliente.TabIndex = 5
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(367, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Status"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Status
        '
        Me.Status.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Status.CasasDecimais = 0
        Me.Status.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Status.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Status.FocusColor = System.Drawing.Color.Empty
        Me.Status.FocusColorEnd = System.Drawing.Color.Empty
        Me.Status.Location = New System.Drawing.Point(435, 105)
        Me.Status.MaxLength = 15
        Me.Status.Name = "Status"
        Me.Status.RegraValidação = Nothing
        Me.Status.Size = New System.Drawing.Size(129, 20)
        Me.Status.TabIndex = 7
        Me.Status.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Status.ValorPadrao = Nothing
        '
        'ClienteNome
        '
        Me.ClienteNome.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ClienteNome.CasasDecimais = 0
        Me.ClienteNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteNome.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteNome.FocusColor = System.Drawing.Color.Empty
        Me.ClienteNome.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteNome.Location = New System.Drawing.Point(115, 131)
        Me.ClienteNome.MaxLength = 50
        Me.ClienteNome.Name = "ClienteNome"
        Me.ClienteNome.RegraValidação = Nothing
        Me.ClienteNome.Size = New System.Drawing.Size(449, 20)
        Me.ClienteNome.TabIndex = 8
        Me.ClienteNome.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteNome.ValorPadrao = Nothing
        '
        'Cnpj
        '
        Me.Cnpj.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cnpj.CasasDecimais = 0
        Me.Cnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cnpj.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cnpj.FocusColor = System.Drawing.Color.Empty
        Me.Cnpj.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cnpj.Location = New System.Drawing.Point(115, 156)
        Me.Cnpj.MaxLength = 20
        Me.Cnpj.Name = "Cnpj"
        Me.Cnpj.RegraValidação = Nothing
        Me.Cnpj.Size = New System.Drawing.Size(141, 20)
        Me.Cnpj.TabIndex = 20
        Me.Cnpj.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cnpj.ValorPadrao = Nothing
        '
        'Ie
        '
        Me.Ie.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Ie.CasasDecimais = 0
        Me.Ie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ie.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ie.FocusColor = System.Drawing.Color.Empty
        Me.Ie.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ie.Location = New System.Drawing.Point(435, 157)
        Me.Ie.MaxLength = 20
        Me.Ie.Name = "Ie"
        Me.Ie.RegraValidação = Nothing
        Me.Ie.Size = New System.Drawing.Size(129, 20)
        Me.Ie.TabIndex = 10
        Me.Ie.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ie.ValorPadrao = Nothing
        '
        'CidadeEstado
        '
        Me.CidadeEstado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CidadeEstado.CasasDecimais = 0
        Me.CidadeEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CidadeEstado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CidadeEstado.FocusColor = System.Drawing.Color.Empty
        Me.CidadeEstado.FocusColorEnd = System.Drawing.Color.Empty
        Me.CidadeEstado.Location = New System.Drawing.Point(115, 182)
        Me.CidadeEstado.MaxLength = 50
        Me.CidadeEstado.Name = "CidadeEstado"
        Me.CidadeEstado.RegraValidação = Nothing
        Me.CidadeEstado.Size = New System.Drawing.Size(234, 20)
        Me.CidadeEstado.TabIndex = 11
        Me.CidadeEstado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CidadeEstado.ValorPadrao = Nothing
        '
        'Telefone
        '
        Me.Telefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Telefone.CasasDecimais = 0
        Me.Telefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telefone.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Telefone.FocusColor = System.Drawing.Color.Empty
        Me.Telefone.FocusColorEnd = System.Drawing.Color.Empty
        Me.Telefone.Location = New System.Drawing.Point(435, 183)
        Me.Telefone.MaxLength = 18
        Me.Telefone.Name = "Telefone"
        Me.Telefone.RegraValidação = Nothing
        Me.Telefone.Size = New System.Drawing.Size(129, 20)
        Me.Telefone.TabIndex = 12
        Me.Telefone.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Telefone.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cnpj"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(364, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "I.E"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(364, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Telefone"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(13, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cidade/UF"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddItem
        '
        Me.AddItem.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItem.ForeColor = System.Drawing.Color.Navy
        Me.AddItem.Location = New System.Drawing.Point(12, 201)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(67, 23)
        Me.AddItem.TabIndex = 68
        Me.AddItem.Text = "Add Item"
        Me.AddItem.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColPedido, Me.ColSequencia, Me.ColDataLançamento, Me.ColUsuario, Me.ColHistorico, Me.ColLancInterno})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(12, 224)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(720, 359)
        Me.MyLista.TabIndex = 69
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColPedido
        '
        Me.ColPedido.Text = "Pedido"
        Me.ColPedido.Width = 0
        '
        'ColSequencia
        '
        Me.ColSequencia.Text = "Sequência"
        Me.ColSequencia.Width = 70
        '
        'ColDataLançamento
        '
        Me.ColDataLançamento.Text = "Data Lanç"
        Me.ColDataLançamento.Width = 80
        '
        'ColUsuario
        '
        Me.ColUsuario.Text = "Usuário"
        Me.ColUsuario.Width = 80
        '
        'ColHistorico
        '
        Me.ColHistorico.Text = "Historico"
        Me.ColHistorico.Width = 455
        '
        'ColLancInterno
        '
        Me.ColLancInterno.Text = "Interno"
        Me.ColLancInterno.Width = 0
        '
        'Acompanhamento
        '
        Me.Acompanhamento.BackColor = System.Drawing.Color.Transparent
        Me.Acompanhamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Acompanhamento.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acompanhamento.Image = CType(resources.GetObject("Acompanhamento.Image"), System.Drawing.Image)
        Me.Acompanhamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Acompanhamento.Location = New System.Drawing.Point(570, 77)
        Me.Acompanhamento.Name = "Acompanhamento"
        Me.Acompanhamento.Size = New System.Drawing.Size(161, 143)
        Me.Acompanhamento.TabIndex = 66
        Me.Acompanhamento.Text = "Em Produção"
        Me.Acompanhamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ExcluirBT, Me.LocalizarBT, Me.ImprimirBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(741, 68)
        Me.BarraBt.TabIndex = 71
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(54, 65)
        Me.NovoBT.Text = "Novo-F9"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalvarBT
        '
        Me.SalvarBT.Image = CType(resources.GetObject("SalvarBT.Image"), System.Drawing.Image)
        Me.SalvarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(63, 65)
        Me.SalvarBT.Text = "Salvar-F10"
        Me.SalvarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EditarBT
        '
        Me.EditarBT.Image = CType(resources.GetObject("EditarBT.Image"), System.Drawing.Image)
        Me.EditarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditarBT.Name = "EditarBT"
        Me.EditarBT.Size = New System.Drawing.Size(63, 65)
        Me.EditarBT.Text = "Editar-F11"
        Me.EditarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcluirBT
        '
        Me.ExcluirBT.Image = CType(resources.GetObject("ExcluirBT.Image"), System.Drawing.Image)
        Me.ExcluirBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ExcluirBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirBT.Name = "ExcluirBT"
        Me.ExcluirBT.Size = New System.Drawing.Size(60, 65)
        Me.ExcluirBT.Text = "Excluir-F8"
        Me.ExcluirBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExcluirBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LocalizarBT
        '
        Me.LocalizarBT.Image = CType(resources.GetObject("LocalizarBT.Image"), System.Drawing.Image)
        Me.LocalizarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LocalizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LocalizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LocalizarBT.Name = "LocalizarBT"
        Me.LocalizarBT.Size = New System.Drawing.Size(71, 65)
        Me.LocalizarBT.Text = "Localizar-F7"
        Me.LocalizarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LocalizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImprimirBT
        '
        Me.ImprimirBT.Image = CType(resources.GetObject("ImprimirBT.Image"), System.Drawing.Image)
        Me.ImprimirBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ImprimirBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImprimirBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirBT.Name = "ImprimirBT"
        Me.ImprimirBT.Size = New System.Drawing.Size(92, 65)
        Me.ImprimirBT.Text = "Imprimir Pedido"
        Me.ImprimirBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ImprimirBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(76, 65)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IdItem
        '
        Me.IdItem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IdItem.CasasDecimais = 0
        Me.IdItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdItem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdItem.FocusColor = System.Drawing.Color.Empty
        Me.IdItem.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdItem.Location = New System.Drawing.Point(12, 561)
        Me.IdItem.MaxLength = 15
        Me.IdItem.Name = "IdItem"
        Me.IdItem.RegraValidação = Nothing
        Me.IdItem.Size = New System.Drawing.Size(70, 20)
        Me.IdItem.TabIndex = 72
        Me.IdItem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdItem.ValorPadrao = Nothing
        Me.IdItem.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.IdItem)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Pedido)
        Me.Fundo.Controls.Add(Me.AddItem)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Acompanhamento)
        Me.Fundo.Controls.Add(Me.Cliente)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.Status)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.ClienteNome)
        Me.Fundo.Controls.Add(Me.Telefone)
        Me.Fundo.Controls.Add(Me.Cnpj)
        Me.Fundo.Controls.Add(Me.CidadeEstado)
        Me.Fundo.Controls.Add(Me.Ie)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(741, 591)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 73
        '
        'PedidoAcompanhamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PedidoAcompanhamento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acompanhamento de Pedido"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Status As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ClienteNome As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cnpj As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Ie As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CidadeEstado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Telefone As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Acompanhamento As System.Windows.Forms.Label
    Friend WithEvents AddItem As System.Windows.Forms.Button
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColPedido As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSequencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDataLançamento As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColUsuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColHistorico As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColLancInterno As System.Windows.Forms.ColumnHeader
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdItem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
