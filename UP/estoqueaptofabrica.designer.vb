<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstoqueAptoFabrica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstoqueAptoFabrica))
        Me.Label7 = New System.Windows.Forms.Label
        Me.AptoId = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataLancamento = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataProducao = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Usuario = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.Descricao = New TexBoxFocusNet.TextBoxFocusNet
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.NovoBT = New System.Windows.Forms.ToolStripButton
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton
        Me.EditarBT = New System.Windows.Forms.ToolStripButton
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton
        Me.ConfirmarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Produto = New TexBoxFocusNet.TextBoxFocusNet
        Me.ProdutoDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.QtdEntrada = New TexBoxFocusNet.TextBoxFocusNet
        Me.BTAdd = New System.Windows.Forms.Button
        Me.PainelItens = New System.Windows.Forms.Panel
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.Confirmado = New System.Windows.Forms.CheckBox
        Me.ApontarEmpresaControlada = New System.Windows.Forms.CheckBox
        Me.ConfImg = New System.Windows.Forms.Label
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.AtEstBt = New System.Windows.Forms.ToolStripButton
        Me.BarraBt.SuspendLayout()
        Me.PainelItens.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Apto ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AptoId
        '
        Me.AptoId.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.AptoId.CasasDecimais = 0
        Me.AptoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AptoId.CPObrigatorio = False
        Me.AptoId.CPObrigatorioMsg = Nothing
        Me.AptoId.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.AptoId.FocusColor = System.Drawing.Color.Empty
        Me.AptoId.FocusColorEnd = System.Drawing.Color.Empty
        Me.AptoId.Location = New System.Drawing.Point(116, 85)
        Me.AptoId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AptoId.MaxLength = 10
        Me.AptoId.Name = "AptoId"
        Me.AptoId.RegraValidação = Nothing
        Me.AptoId.RegraValidaçãoMensagem = Nothing
        Me.AptoId.Size = New System.Drawing.Size(90, 20)
        Me.AptoId.TabIndex = 69
        Me.AptoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AptoId.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.AptoId.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Data Lançamento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataLancamento
        '
        Me.DataLancamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataLancamento.CasasDecimais = 0
        Me.DataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataLancamento.CPObrigatorio = False
        Me.DataLancamento.CPObrigatorioMsg = Nothing
        Me.DataLancamento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataLancamento.FocusColor = System.Drawing.Color.Empty
        Me.DataLancamento.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataLancamento.Location = New System.Drawing.Point(116, 113)
        Me.DataLancamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataLancamento.MaxLength = 10
        Me.DataLancamento.Name = "DataLancamento"
        Me.DataLancamento.RegraValidação = Nothing
        Me.DataLancamento.RegraValidaçãoMensagem = Nothing
        Me.DataLancamento.Size = New System.Drawing.Size(90, 20)
        Me.DataLancamento.TabIndex = 71
        Me.DataLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataLancamento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataLancamento.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Data Produção"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataProducao
        '
        Me.DataProducao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataProducao.CasasDecimais = 0
        Me.DataProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataProducao.CPObrigatorio = False
        Me.DataProducao.CPObrigatorioMsg = Nothing
        Me.DataProducao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataProducao.FocusColor = System.Drawing.Color.Empty
        Me.DataProducao.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataProducao.Location = New System.Drawing.Point(116, 141)
        Me.DataProducao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataProducao.MaxLength = 10
        Me.DataProducao.Name = "DataProducao"
        Me.DataProducao.RegraValidação = Nothing
        Me.DataProducao.RegraValidaçãoMensagem = Nothing
        Me.DataProducao.Size = New System.Drawing.Size(90, 20)
        Me.DataProducao.TabIndex = 73
        Me.DataProducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataProducao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataProducao.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Usuário"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Usuario
        '
        Me.Usuario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Usuario.CasasDecimais = 0
        Me.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usuario.CPObrigatorio = False
        Me.Usuario.CPObrigatorioMsg = Nothing
        Me.Usuario.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Usuario.FocusColor = System.Drawing.Color.Empty
        Me.Usuario.FocusColorEnd = System.Drawing.Color.Empty
        Me.Usuario.Location = New System.Drawing.Point(116, 169)
        Me.Usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Usuario.MaxLength = 20
        Me.Usuario.Name = "Usuario"
        Me.Usuario.RegraValidação = Nothing
        Me.Usuario.RegraValidaçãoMensagem = Nothing
        Me.Usuario.Size = New System.Drawing.Size(132, 20)
        Me.Usuario.TabIndex = 75
        Me.Usuario.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Usuario.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Descrição"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Descricao
        '
        Me.Descricao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Descricao.CasasDecimais = 0
        Me.Descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descricao.CPObrigatorio = False
        Me.Descricao.CPObrigatorioMsg = Nothing
        Me.Descricao.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Descricao.FocusColor = System.Drawing.Color.Empty
        Me.Descricao.FocusColorEnd = System.Drawing.Color.Empty
        Me.Descricao.Location = New System.Drawing.Point(116, 197)
        Me.Descricao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Descricao.MaxLength = 50
        Me.Descricao.Name = "Descricao"
        Me.Descricao.RegraValidação = Nothing
        Me.Descricao.RegraValidaçãoMensagem = Nothing
        Me.Descricao.Size = New System.Drawing.Size(403, 20)
        Me.Descricao.TabIndex = 77
        Me.Descricao.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Descricao.ValorPadrao = Nothing
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ExcluirBT, Me.LocalizarBT, Me.AtEstBt, Me.ConfirmarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(533, 68)
        Me.BarraBt.TabIndex = 79
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
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(15, 261)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(504, 171)
        Me.MyLista.TabIndex = 80
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "AptoId"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Produto"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descrição"
        Me.ColumnHeader4.Width = 332
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Qtd Entrada"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 75
        '
        'Produto
        '
        Me.Produto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Produto.CasasDecimais = 0
        Me.Produto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Produto.CPObrigatorio = False
        Me.Produto.CPObrigatorioMsg = Nothing
        Me.Produto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Produto.FocusColor = System.Drawing.Color.Empty
        Me.Produto.FocusColorEnd = System.Drawing.Color.Empty
        Me.Produto.Location = New System.Drawing.Point(2, 4)
        Me.Produto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Produto.MaxLength = 10
        Me.Produto.Name = "Produto"
        Me.Produto.RegraValidação = Nothing
        Me.Produto.RegraValidaçãoMensagem = Nothing
        Me.Produto.Size = New System.Drawing.Size(64, 20)
        Me.Produto.TabIndex = 81
        Me.Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Produto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Produto.ValorPadrao = Nothing
        '
        'ProdutoDesc
        '
        Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdutoDesc.CasasDecimais = 0
        Me.ProdutoDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProdutoDesc.CPObrigatorio = False
        Me.ProdutoDesc.CPObrigatorioMsg = Nothing
        Me.ProdutoDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ProdutoDesc.FocusColor = System.Drawing.Color.Empty
        Me.ProdutoDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ProdutoDesc.Location = New System.Drawing.Point(66, 4)
        Me.ProdutoDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProdutoDesc.MaxLength = 10
        Me.ProdutoDesc.Name = "ProdutoDesc"
        Me.ProdutoDesc.RegraValidação = Nothing
        Me.ProdutoDesc.RegraValidaçãoMensagem = Nothing
        Me.ProdutoDesc.Size = New System.Drawing.Size(333, 20)
        Me.ProdutoDesc.TabIndex = 82
        Me.ProdutoDesc.TabStop = False
        Me.ProdutoDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ProdutoDesc.ValorPadrao = Nothing
        '
        'QtdEntrada
        '
        Me.QtdEntrada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.QtdEntrada.CasasDecimais = 3
        Me.QtdEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.QtdEntrada.CPObrigatorio = False
        Me.QtdEntrada.CPObrigatorioMsg = Nothing
        Me.QtdEntrada.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.QtdEntrada.FocusColor = System.Drawing.Color.Empty
        Me.QtdEntrada.FocusColorEnd = System.Drawing.Color.Empty
        Me.QtdEntrada.Location = New System.Drawing.Point(399, 4)
        Me.QtdEntrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QtdEntrada.MaxLength = 8
        Me.QtdEntrada.Name = "QtdEntrada"
        Me.QtdEntrada.RegraValidação = Nothing
        Me.QtdEntrada.RegraValidaçãoMensagem = Nothing
        Me.QtdEntrada.Size = New System.Drawing.Size(72, 20)
        Me.QtdEntrada.TabIndex = 83
        Me.QtdEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtdEntrada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.QtdEntrada.ValorPadrao = Nothing
        '
        'BTAdd
        '
        Me.BTAdd.Location = New System.Drawing.Point(471, 3)
        Me.BTAdd.Name = "BTAdd"
        Me.BTAdd.Size = New System.Drawing.Size(35, 23)
        Me.BTAdd.TabIndex = 84
        Me.BTAdd.Text = "Add"
        Me.BTAdd.UseVisualStyleBackColor = True
        '
        'PainelItens
        '
        Me.PainelItens.BackColor = System.Drawing.Color.Transparent
        Me.PainelItens.Controls.Add(Me.ProdutoDesc)
        Me.PainelItens.Controls.Add(Me.BTAdd)
        Me.PainelItens.Controls.Add(Me.Produto)
        Me.PainelItens.Controls.Add(Me.QtdEntrada)
        Me.PainelItens.Location = New System.Drawing.Point(15, 235)
        Me.PainelItens.Name = "PainelItens"
        Me.PainelItens.Size = New System.Drawing.Size(507, 29)
        Me.PainelItens.TabIndex = 85
        '
        'Id
        '
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(46, 400)
        Me.Id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(64, 20)
        Me.Id.TabIndex = 86
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'Confirmado
        '
        Me.Confirmado.AutoSize = True
        Me.Confirmado.Location = New System.Drawing.Point(297, 141)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(84, 20)
        Me.Confirmado.TabIndex = 88
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.UseVisualStyleBackColor = True
        Me.Confirmado.Visible = False
        '
        'ApontarEmpresaControlada
        '
        Me.ApontarEmpresaControlada.AutoSize = True
        Me.ApontarEmpresaControlada.BackColor = System.Drawing.Color.Transparent
        Me.ApontarEmpresaControlada.Location = New System.Drawing.Point(297, 167)
        Me.ApontarEmpresaControlada.Name = "ApontarEmpresaControlada"
        Me.ApontarEmpresaControlada.Size = New System.Drawing.Size(185, 20)
        Me.ApontarEmpresaControlada.TabIndex = 89
        Me.ApontarEmpresaControlada.TabStop = False
        Me.ApontarEmpresaControlada.Text = "Apontar na Empresa Controlada"
        Me.ApontarEmpresaControlada.UseVisualStyleBackColor = False
        '
        'ConfImg
        '
        Me.ConfImg.BackColor = System.Drawing.Color.Transparent
        Me.ConfImg.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfImg.Image = CType(resources.GetObject("ConfImg.Image"), System.Drawing.Image)
        Me.ConfImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConfImg.Location = New System.Drawing.Point(241, 85)
        Me.ConfImg.Name = "ConfImg"
        Me.ConfImg.Size = New System.Drawing.Size(289, 47)
        Me.ConfImg.TabIndex = 87
        Me.ConfImg.Text = "Apontamento Confirmado"
        Me.ConfImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ConfImg.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.ApontarEmpresaControlada)
        Me.Fundo.Controls.Add(Me.ConfImg)
        Me.Fundo.Controls.Add(Me.Confirmado)
        Me.Fundo.Controls.Add(Me.AptoId)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.DataLancamento)
        Me.Fundo.Controls.Add(Me.PainelItens)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.DataProducao)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Descricao)
        Me.Fundo.Controls.Add(Me.Usuario)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(533, 442)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 90
        '
        'AtEstBt
        '
        Me.AtEstBt.Image = CType(resources.GetObject("AtEstBt.Image"), System.Drawing.Image)
        Me.AtEstBt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AtEstBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtEstBt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtEstBt.Name = "AtEstBt"
        Me.AtEstBt.Size = New System.Drawing.Size(52, 65)
        Me.AtEstBt.Text = "At. Est."
        Me.AtEstBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtEstBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EstoqueAptoFabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EstoqueAptoFabrica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apontamento da Fábrica"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.PainelItens.ResumeLayout(False)
        Me.PainelItens.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AptoId As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataLancamento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataProducao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Usuario As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Descricao As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConfirmarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Produto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ProdutoDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents QtdEntrada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents BTAdd As System.Windows.Forms.Button
    Friend WithEvents PainelItens As System.Windows.Forms.Panel
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConfImg As System.Windows.Forms.Label
    Friend WithEvents Confirmado As System.Windows.Forms.CheckBox
    Friend WithEvents ApontarEmpresaControlada As System.Windows.Forms.CheckBox
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents AtEstBt As System.Windows.Forms.ToolStripButton
End Class
