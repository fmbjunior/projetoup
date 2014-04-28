<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstoqueAptoFabricaTransf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstoqueAptoFabricaTransf))
        Me.ProdutoOrigemDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.ProdutoOrigem = New TexBoxFocusNet.TextBoxFocusNet
        Me.ProdutoDestinoDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.ProdutoDestino = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DescTransferencia = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Usuario = New TexBoxFocusNet.TextBoxFocusNet
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.NovoBT = New System.Windows.Forms.ToolStripButton
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton
        Me.EditarBT = New System.Windows.Forms.ToolStripButton
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton
        Me.ConfirmarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.ID = New TexBoxFocusNet.TextBoxFocusNet
        Me.Confirmado = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.ConfImg = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Qtd = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.BarraBt.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProdutoOrigemDesc
        '
        Me.ProdutoOrigemDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdutoOrigemDesc.CasasDecimais = 0
        Me.ProdutoOrigemDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoOrigemDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoOrigemDesc.FocusColor = System.Drawing.Color.Empty
        Me.ProdutoOrigemDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoOrigemDesc.Location = New System.Drawing.Point(193, 142)
        Me.ProdutoOrigemDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProdutoOrigemDesc.MaxLength = 10
        Me.ProdutoOrigemDesc.Name = "ProdutoOrigemDesc"
        Me.ProdutoOrigemDesc.RegraValidação = Nothing
        Me.ProdutoOrigemDesc.Size = New System.Drawing.Size(327, 20)
        Me.ProdutoOrigemDesc.TabIndex = 6
        Me.ProdutoOrigemDesc.TabStop = False
        Me.ProdutoOrigemDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoOrigemDesc.ValorPadrao = Nothing
        '
        'ProdutoOrigem
        '
        Me.ProdutoOrigem.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ProdutoOrigem.CasasDecimais = 0
        Me.ProdutoOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoOrigem.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoOrigem.FocusColor = System.Drawing.Color.Empty
        Me.ProdutoOrigem.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoOrigem.Location = New System.Drawing.Point(123, 142)
        Me.ProdutoOrigem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProdutoOrigem.MaxLength = 10
        Me.ProdutoOrigem.Name = "ProdutoOrigem"
        Me.ProdutoOrigem.RegraValidação = Nothing
        Me.ProdutoOrigem.Size = New System.Drawing.Size(64, 20)
        Me.ProdutoOrigem.TabIndex = 5
        Me.ProdutoOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ProdutoOrigem.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoOrigem.ValorPadrao = Nothing
        '
        'ProdutoDestinoDesc
        '
        Me.ProdutoDestinoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdutoDestinoDesc.CasasDecimais = 0
        Me.ProdutoDestinoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoDestinoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoDestinoDesc.FocusColor = System.Drawing.Color.Empty
        Me.ProdutoDestinoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDestinoDesc.Location = New System.Drawing.Point(193, 170)
        Me.ProdutoDestinoDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProdutoDestinoDesc.MaxLength = 10
        Me.ProdutoDestinoDesc.Name = "ProdutoDestinoDesc"
        Me.ProdutoDestinoDesc.RegraValidação = Nothing
        Me.ProdutoDestinoDesc.Size = New System.Drawing.Size(327, 20)
        Me.ProdutoDestinoDesc.TabIndex = 9
        Me.ProdutoDestinoDesc.TabStop = False
        Me.ProdutoDestinoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDestinoDesc.ValorPadrao = Nothing
        '
        'ProdutoDestino
        '
        Me.ProdutoDestino.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ProdutoDestino.CasasDecimais = 0
        Me.ProdutoDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoDestino.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoDestino.FocusColor = System.Drawing.Color.Empty
        Me.ProdutoDestino.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDestino.Location = New System.Drawing.Point(123, 170)
        Me.ProdutoDestino.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProdutoDestino.MaxLength = 10
        Me.ProdutoDestino.Name = "ProdutoDestino"
        Me.ProdutoDestino.RegraValidação = Nothing
        Me.ProdutoDestino.Size = New System.Drawing.Size(64, 20)
        Me.ProdutoDestino.TabIndex = 8
        Me.ProdutoDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ProdutoDestino.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDestino.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Produto de Destino"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Produto de Origem"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Descrição"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescTransferencia
        '
        Me.DescTransferencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescTransferencia.CasasDecimais = 0
        Me.DescTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescTransferencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescTransferencia.FocusColor = System.Drawing.Color.Empty
        Me.DescTransferencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescTransferencia.Location = New System.Drawing.Point(123, 254)
        Me.DescTransferencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DescTransferencia.MaxLength = 30
        Me.DescTransferencia.Name = "DescTransferencia"
        Me.DescTransferencia.RegraValidação = Nothing
        Me.DescTransferencia.Size = New System.Drawing.Size(403, 20)
        Me.DescTransferencia.TabIndex = 16
        Me.DescTransferencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescTransferencia.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Usuário"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Usuario
        '
        Me.Usuario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Usuario.CasasDecimais = 0
        Me.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usuario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Usuario.FocusColor = System.Drawing.Color.Empty
        Me.Usuario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Usuario.Location = New System.Drawing.Point(123, 226)
        Me.Usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Usuario.MaxLength = 15
        Me.Usuario.Name = "Usuario"
        Me.Usuario.RegraValidação = Nothing
        Me.Usuario.Size = New System.Drawing.Size(132, 20)
        Me.Usuario.TabIndex = 13
        Me.Usuario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Usuario.ValorPadrao = Nothing
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ExcluirBT, Me.LocalizarBT, Me.ConfirmarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(534, 68)
        Me.BarraBt.TabIndex = 18
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
        'ConfirmarBT
        '
        Me.ConfirmarBT.Image = CType(resources.GetObject("ConfirmarBT.Image"), System.Drawing.Image)
        Me.ConfirmarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ConfirmarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfirmarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConfirmarBT.Name = "ConfirmarBT"
        Me.ConfirmarBT.Size = New System.Drawing.Size(62, 65)
        Me.ConfirmarBT.Text = "Confirmar"
        Me.ConfirmarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfirmarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.FecharBT.Text = "Finalizar-F12"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID
        '
        Me.ID.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ID.CasasDecimais = 0
        Me.ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ID.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ID.FocusColor = System.Drawing.Color.Empty
        Me.ID.FocusColorEnd = System.Drawing.Color.Empty
        Me.ID.Location = New System.Drawing.Point(123, 86)
        Me.ID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ID.MaxLength = 10
        Me.ID.Name = "ID"
        Me.ID.RegraValidação = Nothing
        Me.ID.Size = New System.Drawing.Size(90, 20)
        Me.ID.TabIndex = 1
        Me.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ID.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ID.ValorPadrao = Nothing
        '
        'Confirmado
        '
        Me.Confirmado.AutoSize = True
        Me.Confirmado.Location = New System.Drawing.Point(261, 225)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(84, 20)
        Me.Confirmado.TabIndex = 14
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.UseVisualStyleBackColor = True
        Me.Confirmado.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Data Lançamento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.Location = New System.Drawing.Point(123, 114)
        Me.DataLancamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(90, 20)
        Me.DataLancamento.TabIndex = 3
        Me.DataLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'ConfImg
        '
        Me.ConfImg.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfImg.Image = CType(resources.GetObject("ConfImg.Image"), System.Drawing.Image)
        Me.ConfImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConfImg.Location = New System.Drawing.Point(284, 86)
        Me.ConfImg.Name = "ConfImg"
        Me.ConfImg.Size = New System.Drawing.Size(236, 47)
        Me.ConfImg.TabIndex = 17
        Me.ConfImg.Text = "Transf. Confirmado"
        Me.ConfImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ConfImg.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Qtd Transferir"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Qtd
        '
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.CasasDecimais = 3
        Me.Qtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Qtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Qtd.FocusColor = System.Drawing.Color.Empty
        Me.Qtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.Qtd.Location = New System.Drawing.Point(123, 198)
        Me.Qtd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Qtd.MaxLength = 8
        Me.Qtd.Name = "Qtd"
        Me.Qtd.RegraValidação = Nothing
        Me.Qtd.Size = New System.Drawing.Size(90, 20)
        Me.Qtd.TabIndex = 11
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Qtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.Qtd.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.ProdutoOrigem)
        Me.Fundo.Controls.Add(Me.Qtd)
        Me.Fundo.Controls.Add(Me.ProdutoOrigemDesc)
        Me.Fundo.Controls.Add(Me.ConfImg)
        Me.Fundo.Controls.Add(Me.ProdutoDestino)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.ProdutoDestinoDesc)
        Me.Fundo.Controls.Add(Me.DataLancamento)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Confirmado)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Usuario)
        Me.Fundo.Controls.Add(Me.ID)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.DescTransferencia)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(534, 279)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 19
        '
        'EstoqueAptoFabricaTransf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EstoqueAptoFabricaTransf"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque Fábrica Transferência"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProdutoOrigemDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ProdutoOrigem As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ProdutoDestinoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ProdutoDestino As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DescTransferencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Usuario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConfirmarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ID As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Confirmado As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ConfImg As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Qtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
