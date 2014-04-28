<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoTributos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoTributos))
        Me.BarraBt = New System.Windows.Forms.ToolStrip
        Me.NovoBT = New System.Windows.Forms.ToolStripButton
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton
        Me.EditarBT = New System.Windows.Forms.ToolStripButton
        Me.ImportarBT = New System.Windows.Forms.ToolStripButton
        Me.FecharBT = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.SalarioMinimo = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorSalarioFamiliaMenor = New TexBoxFocusNet.TextBoxFocusNet
        Me.SalarioFamiliaMenor = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorSalarioFamiliaMaior = New TexBoxFocusNet.TextBoxFocusNet
        Me.SalarioFamiliaMaior = New TexBoxFocusNet.TextBoxFocusNet
        Me.PercFaixa4 = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorFaixa4 = New TexBoxFocusNet.TextBoxFocusNet
        Me.PercFaixa3 = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorFaixa3 = New TexBoxFocusNet.TextBoxFocusNet
        Me.PercFaixa2 = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorFaixa2 = New TexBoxFocusNet.TextBoxFocusNet
        Me.PercFaixa1 = New TexBoxFocusNet.TextBoxFocusNet
        Me.ValorFaixa1 = New TexBoxFocusNet.TextBoxFocusNet
        Me.Competencia = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.PainelImport = New System.Windows.Forms.Panel
        Me.Importar = New System.Windows.Forms.Button
        Me.Label24 = New System.Windows.Forms.Label
        Me.CompNova = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label23 = New System.Windows.Forms.Label
        Me.CompImportar = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.BarraBt.SuspendLayout()
        Me.PainelImport.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ImportarBT, Me.FecharBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraBt.Size = New System.Drawing.Size(491, 68)
        Me.BarraBt.TabIndex = 76
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
        'ImportarBT
        '
        Me.ImportarBT.Image = CType(resources.GetObject("ImportarBT.Image"), System.Drawing.Image)
        Me.ImportarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ImportarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportarBT.Name = "ImportarBT"
        Me.ImportarBT.Size = New System.Drawing.Size(55, 65)
        Me.ImportarBT.Text = "Importar"
        Me.ImportarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ImportarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Competência"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Ate Vlr 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(462, 24)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Fixa de I.N.S.S"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(271, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Percentual"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(271, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Percentual"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(14, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Ate Vlr 2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(271, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Percentual"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Ate Vlr 3"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(271, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 20)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Percentual"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(14, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Ate Vlr 4"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(462, 4)
        Me.Label11.TabIndex = 96
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 293)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(462, 4)
        Me.Label12.TabIndex = 97
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(14, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 20)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Ref. Maior Sal. Fam"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 273)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(462, 24)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Salário Família"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(271, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 20)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Vlr Sal. Fam. Maior"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(271, 330)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 20)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "Vlr Sal. Fam. Menor"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(14, 329)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 20)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Ref. Menor Sal. Fam"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(14, 366)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 20)
        Me.Label18.TabIndex = 107
        Me.Label18.Text = "Salário Mínimo"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalarioMinimo
        '
        Me.SalarioMinimo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SalarioMinimo.CasasDecimais = 2
        Me.SalarioMinimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SalarioMinimo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SalarioMinimo.FocusColor = System.Drawing.Color.Empty
        Me.SalarioMinimo.FocusColorEnd = System.Drawing.Color.Empty
        Me.SalarioMinimo.Location = New System.Drawing.Point(122, 366)
        Me.SalarioMinimo.MaxLength = 10
        Me.SalarioMinimo.Name = "SalarioMinimo"
        Me.SalarioMinimo.RegraValidação = Nothing
        Me.SalarioMinimo.Size = New System.Drawing.Size(100, 20)
        Me.SalarioMinimo.TabIndex = 108
        Me.SalarioMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioMinimo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioMinimo.ValorPadrao = Nothing
        '
        'ValorSalarioFamiliaMenor
        '
        Me.ValorSalarioFamiliaMenor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorSalarioFamiliaMenor.CasasDecimais = 2
        Me.ValorSalarioFamiliaMenor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorSalarioFamiliaMenor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorSalarioFamiliaMenor.FocusColor = System.Drawing.Color.Empty
        Me.ValorSalarioFamiliaMenor.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorSalarioFamiliaMenor.Location = New System.Drawing.Point(379, 329)
        Me.ValorSalarioFamiliaMenor.MaxLength = 10
        Me.ValorSalarioFamiliaMenor.Name = "ValorSalarioFamiliaMenor"
        Me.ValorSalarioFamiliaMenor.RegraValidação = Nothing
        Me.ValorSalarioFamiliaMenor.Size = New System.Drawing.Size(100, 20)
        Me.ValorSalarioFamiliaMenor.TabIndex = 105
        Me.ValorSalarioFamiliaMenor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorSalarioFamiliaMenor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorSalarioFamiliaMenor.ValorPadrao = Nothing
        '
        'SalarioFamiliaMenor
        '
        Me.SalarioFamiliaMenor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SalarioFamiliaMenor.CasasDecimais = 2
        Me.SalarioFamiliaMenor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SalarioFamiliaMenor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SalarioFamiliaMenor.FocusColor = System.Drawing.Color.Empty
        Me.SalarioFamiliaMenor.FocusColorEnd = System.Drawing.Color.Empty
        Me.SalarioFamiliaMenor.Location = New System.Drawing.Point(122, 329)
        Me.SalarioFamiliaMenor.MaxLength = 10
        Me.SalarioFamiliaMenor.Name = "SalarioFamiliaMenor"
        Me.SalarioFamiliaMenor.RegraValidação = Nothing
        Me.SalarioFamiliaMenor.Size = New System.Drawing.Size(100, 20)
        Me.SalarioFamiliaMenor.TabIndex = 104
        Me.SalarioFamiliaMenor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioFamiliaMenor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioFamiliaMenor.ValorPadrao = Nothing
        '
        'ValorSalarioFamiliaMaior
        '
        Me.ValorSalarioFamiliaMaior.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorSalarioFamiliaMaior.CasasDecimais = 2
        Me.ValorSalarioFamiliaMaior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorSalarioFamiliaMaior.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorSalarioFamiliaMaior.FocusColor = System.Drawing.Color.Empty
        Me.ValorSalarioFamiliaMaior.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorSalarioFamiliaMaior.Location = New System.Drawing.Point(379, 303)
        Me.ValorSalarioFamiliaMaior.MaxLength = 10
        Me.ValorSalarioFamiliaMaior.Name = "ValorSalarioFamiliaMaior"
        Me.ValorSalarioFamiliaMaior.RegraValidação = Nothing
        Me.ValorSalarioFamiliaMaior.Size = New System.Drawing.Size(100, 20)
        Me.ValorSalarioFamiliaMaior.TabIndex = 101
        Me.ValorSalarioFamiliaMaior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorSalarioFamiliaMaior.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorSalarioFamiliaMaior.ValorPadrao = Nothing
        '
        'SalarioFamiliaMaior
        '
        Me.SalarioFamiliaMaior.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.SalarioFamiliaMaior.CasasDecimais = 2
        Me.SalarioFamiliaMaior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SalarioFamiliaMaior.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SalarioFamiliaMaior.FocusColor = System.Drawing.Color.Empty
        Me.SalarioFamiliaMaior.FocusColorEnd = System.Drawing.Color.Empty
        Me.SalarioFamiliaMaior.Location = New System.Drawing.Point(122, 303)
        Me.SalarioFamiliaMaior.MaxLength = 10
        Me.SalarioFamiliaMaior.Name = "SalarioFamiliaMaior"
        Me.SalarioFamiliaMaior.RegraValidação = Nothing
        Me.SalarioFamiliaMaior.Size = New System.Drawing.Size(100, 20)
        Me.SalarioFamiliaMaior.TabIndex = 99
        Me.SalarioFamiliaMaior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalarioFamiliaMaior.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SalarioFamiliaMaior.ValorPadrao = Nothing
        '
        'PercFaixa4
        '
        Me.PercFaixa4.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PercFaixa4.CasasDecimais = 2
        Me.PercFaixa4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PercFaixa4.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PercFaixa4.FocusColor = System.Drawing.Color.Empty
        Me.PercFaixa4.FocusColorEnd = System.Drawing.Color.Empty
        Me.PercFaixa4.Location = New System.Drawing.Point(379, 229)
        Me.PercFaixa4.MaxLength = 8
        Me.PercFaixa4.Name = "PercFaixa4"
        Me.PercFaixa4.RegraValidação = Nothing
        Me.PercFaixa4.Size = New System.Drawing.Size(50, 20)
        Me.PercFaixa4.TabIndex = 95
        Me.PercFaixa4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercFaixa4.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.PercFaixa4.ValorPadrao = Nothing
        '
        'ValorFaixa4
        '
        Me.ValorFaixa4.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorFaixa4.CasasDecimais = 2
        Me.ValorFaixa4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorFaixa4.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorFaixa4.FocusColor = System.Drawing.Color.Empty
        Me.ValorFaixa4.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorFaixa4.Location = New System.Drawing.Point(122, 230)
        Me.ValorFaixa4.MaxLength = 10
        Me.ValorFaixa4.Name = "ValorFaixa4"
        Me.ValorFaixa4.RegraValidação = Nothing
        Me.ValorFaixa4.Size = New System.Drawing.Size(100, 20)
        Me.ValorFaixa4.TabIndex = 93
        Me.ValorFaixa4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorFaixa4.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorFaixa4.ValorPadrao = Nothing
        '
        'PercFaixa3
        '
        Me.PercFaixa3.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PercFaixa3.CasasDecimais = 2
        Me.PercFaixa3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PercFaixa3.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PercFaixa3.FocusColor = System.Drawing.Color.Empty
        Me.PercFaixa3.FocusColorEnd = System.Drawing.Color.Empty
        Me.PercFaixa3.Location = New System.Drawing.Point(379, 203)
        Me.PercFaixa3.MaxLength = 8
        Me.PercFaixa3.Name = "PercFaixa3"
        Me.PercFaixa3.RegraValidação = Nothing
        Me.PercFaixa3.Size = New System.Drawing.Size(50, 20)
        Me.PercFaixa3.TabIndex = 91
        Me.PercFaixa3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercFaixa3.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.PercFaixa3.ValorPadrao = Nothing
        '
        'ValorFaixa3
        '
        Me.ValorFaixa3.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorFaixa3.CasasDecimais = 2
        Me.ValorFaixa3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorFaixa3.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorFaixa3.FocusColor = System.Drawing.Color.Empty
        Me.ValorFaixa3.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorFaixa3.Location = New System.Drawing.Point(122, 204)
        Me.ValorFaixa3.MaxLength = 10
        Me.ValorFaixa3.Name = "ValorFaixa3"
        Me.ValorFaixa3.RegraValidação = Nothing
        Me.ValorFaixa3.Size = New System.Drawing.Size(100, 20)
        Me.ValorFaixa3.TabIndex = 89
        Me.ValorFaixa3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorFaixa3.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorFaixa3.ValorPadrao = Nothing
        '
        'PercFaixa2
        '
        Me.PercFaixa2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PercFaixa2.CasasDecimais = 2
        Me.PercFaixa2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PercFaixa2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PercFaixa2.FocusColor = System.Drawing.Color.Empty
        Me.PercFaixa2.FocusColorEnd = System.Drawing.Color.Empty
        Me.PercFaixa2.Location = New System.Drawing.Point(379, 177)
        Me.PercFaixa2.MaxLength = 8
        Me.PercFaixa2.Name = "PercFaixa2"
        Me.PercFaixa2.RegraValidação = Nothing
        Me.PercFaixa2.Size = New System.Drawing.Size(50, 20)
        Me.PercFaixa2.TabIndex = 87
        Me.PercFaixa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercFaixa2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.PercFaixa2.ValorPadrao = Nothing
        '
        'ValorFaixa2
        '
        Me.ValorFaixa2.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorFaixa2.CasasDecimais = 2
        Me.ValorFaixa2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorFaixa2.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorFaixa2.FocusColor = System.Drawing.Color.Empty
        Me.ValorFaixa2.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorFaixa2.Location = New System.Drawing.Point(122, 178)
        Me.ValorFaixa2.MaxLength = 10
        Me.ValorFaixa2.Name = "ValorFaixa2"
        Me.ValorFaixa2.RegraValidação = Nothing
        Me.ValorFaixa2.Size = New System.Drawing.Size(100, 20)
        Me.ValorFaixa2.TabIndex = 85
        Me.ValorFaixa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorFaixa2.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorFaixa2.ValorPadrao = Nothing
        '
        'PercFaixa1
        '
        Me.PercFaixa1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PercFaixa1.CasasDecimais = 2
        Me.PercFaixa1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PercFaixa1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.PercFaixa1.FocusColor = System.Drawing.Color.Empty
        Me.PercFaixa1.FocusColorEnd = System.Drawing.Color.Empty
        Me.PercFaixa1.Location = New System.Drawing.Point(379, 151)
        Me.PercFaixa1.MaxLength = 8
        Me.PercFaixa1.Name = "PercFaixa1"
        Me.PercFaixa1.RegraValidação = Nothing
        Me.PercFaixa1.Size = New System.Drawing.Size(50, 20)
        Me.PercFaixa1.TabIndex = 83
        Me.PercFaixa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PercFaixa1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.PercFaixa1.ValorPadrao = Nothing
        '
        'ValorFaixa1
        '
        Me.ValorFaixa1.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorFaixa1.CasasDecimais = 2
        Me.ValorFaixa1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorFaixa1.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorFaixa1.FocusColor = System.Drawing.Color.Empty
        Me.ValorFaixa1.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorFaixa1.Location = New System.Drawing.Point(122, 152)
        Me.ValorFaixa1.MaxLength = 10
        Me.ValorFaixa1.Name = "ValorFaixa1"
        Me.ValorFaixa1.RegraValidação = Nothing
        Me.ValorFaixa1.Size = New System.Drawing.Size(100, 20)
        Me.ValorFaixa1.TabIndex = 80
        Me.ValorFaixa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorFaixa1.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorFaixa1.ValorPadrao = Nothing
        '
        'Competencia
        '
        Me.Competencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Competencia.CasasDecimais = 0
        Me.Competencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Competencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Competencia.FocusColor = System.Drawing.Color.Empty
        Me.Competencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Competencia.Location = New System.Drawing.Point(122, 90)
        Me.Competencia.MaxLength = 7
        Me.Competencia.Name = "Competencia"
        Me.Competencia.RegraValidação = Nothing
        Me.Competencia.Size = New System.Drawing.Size(100, 20)
        Me.Competencia.TabIndex = 78
        Me.Competencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Competencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.Competencia.ValorPadrao = Nothing
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(429, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 20)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "%"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(429, 178)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 20)
        Me.Label20.TabIndex = 110
        Me.Label20.Text = "%"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(429, 203)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 20)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = "%"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(429, 229)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 20)
        Me.Label22.TabIndex = 112
        Me.Label22.Text = "%"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PainelImport
        '
        Me.PainelImport.BackColor = System.Drawing.Color.Gold
        Me.PainelImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PainelImport.Controls.Add(Me.Importar)
        Me.PainelImport.Controls.Add(Me.Label24)
        Me.PainelImport.Controls.Add(Me.CompNova)
        Me.PainelImport.Controls.Add(Me.Label23)
        Me.PainelImport.Controls.Add(Me.CompImportar)
        Me.PainelImport.Location = New System.Drawing.Point(228, 77)
        Me.PainelImport.Name = "PainelImport"
        Me.PainelImport.Size = New System.Drawing.Size(251, 64)
        Me.PainelImport.TabIndex = 113
        Me.PainelImport.Visible = False
        '
        'Importar
        '
        Me.Importar.Location = New System.Drawing.Point(184, 36)
        Me.Importar.Name = "Importar"
        Me.Importar.Size = New System.Drawing.Size(64, 23)
        Me.Importar.TabIndex = 83
        Me.Importar.Text = "Importar"
        Me.Importar.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(12, 36)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 20)
        Me.Label24.TabIndex = 81
        Me.Label24.Text = "Comp. Nova"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompNova
        '
        Me.CompNova.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CompNova.CasasDecimais = 0
        Me.CompNova.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompNova.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CompNova.FocusColor = System.Drawing.Color.Empty
        Me.CompNova.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompNova.Location = New System.Drawing.Point(105, 35)
        Me.CompNova.MaxLength = 7
        Me.CompNova.Name = "CompNova"
        Me.CompNova.RegraValidação = Nothing
        Me.CompNova.Size = New System.Drawing.Size(73, 20)
        Me.CompNova.TabIndex = 82
        Me.CompNova.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CompNova.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.CompNova.ValorPadrao = Nothing
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(12, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 20)
        Me.Label23.TabIndex = 79
        Me.Label23.Text = "Comp. Importar"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompImportar
        '
        Me.CompImportar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CompImportar.CasasDecimais = 0
        Me.CompImportar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CompImportar.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CompImportar.FocusColor = System.Drawing.Color.Empty
        Me.CompImportar.FocusColorEnd = System.Drawing.Color.Empty
        Me.CompImportar.Location = New System.Drawing.Point(105, 5)
        Me.CompImportar.MaxLength = 7
        Me.CompImportar.Name = "CompImportar"
        Me.CompImportar.RegraValidação = Nothing
        Me.CompImportar.Size = New System.Drawing.Size(73, 20)
        Me.CompImportar.TabIndex = 80
        Me.CompImportar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CompImportar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.MesAnoCompetencia
        Me.CompImportar.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.PainelImport)
        Me.Fundo.Controls.Add(Me.Label20)
        Me.Fundo.Controls.Add(Me.SalarioMinimo)
        Me.Fundo.Controls.Add(Me.Label21)
        Me.Fundo.Controls.Add(Me.Label18)
        Me.Fundo.Controls.Add(Me.Label22)
        Me.Fundo.Controls.Add(Me.ValorSalarioFamiliaMenor)
        Me.Fundo.Controls.Add(Me.Label19)
        Me.Fundo.Controls.Add(Me.SalarioFamiliaMenor)
        Me.Fundo.Controls.Add(Me.Label16)
        Me.Fundo.Controls.Add(Me.Label15)
        Me.Fundo.Controls.Add(Me.Label17)
        Me.Fundo.Controls.Add(Me.ValorSalarioFamiliaMaior)
        Me.Fundo.Controls.Add(Me.Label14)
        Me.Fundo.Controls.Add(Me.Label13)
        Me.Fundo.Controls.Add(Me.Competencia)
        Me.Fundo.Controls.Add(Me.SalarioFamiliaMaior)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.ValorFaixa1)
        Me.Fundo.Controls.Add(Me.Label11)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label9)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.PercFaixa4)
        Me.Fundo.Controls.Add(Me.PercFaixa1)
        Me.Fundo.Controls.Add(Me.Label10)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.ValorFaixa4)
        Me.Fundo.Controls.Add(Me.ValorFaixa2)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.PercFaixa3)
        Me.Fundo.Controls.Add(Me.PercFaixa2)
        Me.Fundo.Controls.Add(Me.Label8)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.ValorFaixa3)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(491, 398)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 114
        '
        'FolhaPgtoTributos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoTributos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tributos da Folha de Pagamento"
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.PainelImport.ResumeLayout(False)
        Me.PainelImport.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImportarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Competencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ValorFaixa1 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PercFaixa1 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PercFaixa2 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ValorFaixa2 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PercFaixa3 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ValorFaixa3 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PercFaixa4 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ValorFaixa4 As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SalarioFamiliaMaior As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ValorSalarioFamiliaMaior As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ValorSalarioFamiliaMenor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SalarioFamiliaMenor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents SalarioMinimo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PainelImport As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CompNova As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CompImportar As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Importar As System.Windows.Forms.Button
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
