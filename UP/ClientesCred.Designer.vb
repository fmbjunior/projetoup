<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesCred
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesCred))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.DisplayCancelado = New System.Windows.Forms.Label()
        Me.DisplayConfirmado = New System.Windows.Forms.Label()
        Me.Inativo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btLocalizar = New DevComponents.DotNetBar.ButtonX()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Confirmado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ValorCred = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btFindClientes = New System.Windows.Forms.Label()
        Me.VencimentoCred = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataCred = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DescCred = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.DisplayCancelado)
        Me.PanelEx1.Controls.Add(Me.DisplayConfirmado)
        Me.PanelEx1.Controls.Add(Me.Inativo)
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.btLocalizar)
        Me.PanelEx1.Controls.Add(Me.btSalvar)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.Confirmado)
        Me.PanelEx1.Controls.Add(Me.ValorCred)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.btFindClientes)
        Me.PanelEx1.Controls.Add(Me.VencimentoCred)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.DataCred)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.DescCred)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.ClienteDesc)
        Me.PanelEx1.Controls.Add(Me.Cliente)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Id)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(645, 290)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'DisplayCancelado
        '
        Me.DisplayCancelado.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCancelado.Image = CType(resources.GetObject("DisplayCancelado.Image"), System.Drawing.Image)
        Me.DisplayCancelado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DisplayCancelado.Location = New System.Drawing.Point(473, 195)
        Me.DisplayCancelado.Name = "DisplayCancelado"
        Me.DisplayCancelado.Size = New System.Drawing.Size(160, 35)
        Me.DisplayCancelado.TabIndex = 23
        Me.DisplayCancelado.Text = "Cancelado"
        Me.DisplayCancelado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DisplayCancelado.Visible = False
        '
        'DisplayConfirmado
        '
        Me.DisplayConfirmado.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayConfirmado.Image = CType(resources.GetObject("DisplayConfirmado.Image"), System.Drawing.Image)
        Me.DisplayConfirmado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DisplayConfirmado.Location = New System.Drawing.Point(473, 160)
        Me.DisplayConfirmado.Name = "DisplayConfirmado"
        Me.DisplayConfirmado.Size = New System.Drawing.Size(172, 35)
        Me.DisplayConfirmado.TabIndex = 22
        Me.DisplayConfirmado.Text = "Confirmado"
        Me.DisplayConfirmado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DisplayConfirmado.Visible = False
        '
        'Inativo
        '
        '
        '
        '
        Me.Inativo.BackgroundStyle.Class = ""
        Me.Inativo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Inativo.Location = New System.Drawing.Point(458, 134)
        Me.Inativo.Name = "Inativo"
        Me.Inativo.Size = New System.Drawing.Size(83, 23)
        Me.Inativo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Inativo.TabIndex = 21
        Me.Inativo.Text = "Inativo"
        Me.Inativo.Visible = False
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(458, 251)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(83, 28)
        Me.btNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNovo.TabIndex = 19
        Me.btNovo.Text = "Novo"
        '
        'btLocalizar
        '
        Me.btLocalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLocalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLocalizar.Location = New System.Drawing.Point(250, 251)
        Me.btLocalizar.Name = "btLocalizar"
        Me.btLocalizar.Size = New System.Drawing.Size(83, 28)
        Me.btLocalizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btLocalizar.TabIndex = 18
        Me.btLocalizar.Text = "Localizar"
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(339, 251)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(113, 28)
        Me.btSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSalvar.TabIndex = 15
        Me.btSalvar.Text = "Salvar e Confirmar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(547, 251)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(83, 28)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 17
        Me.btFechar.Text = "Fechar"
        '
        'Confirmado
        '
        '
        '
        '
        Me.Confirmado.BackgroundStyle.Class = ""
        Me.Confirmado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Confirmado.Location = New System.Drawing.Point(300, 134)
        Me.Confirmado.Name = "Confirmado"
        Me.Confirmado.Size = New System.Drawing.Size(79, 23)
        Me.Confirmado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Confirmado.TabIndex = 14
        Me.Confirmado.Text = "Confirmado"
        Me.Confirmado.Visible = False
        '
        'ValorCred
        '
        Me.ValorCred.AceitaColarTexto = True
        Me.ValorCred.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorCred.CasasDecimais = 2
        Me.ValorCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorCred.CPObrigatorio = False
        Me.ValorCred.CPObrigatorioMsg = Nothing
        Me.ValorCred.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorCred.FlatBorder = False
        Me.ValorCred.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorCred.FocusColor = System.Drawing.Color.MistyRose
        Me.ValorCred.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorCred.HighlightBorderOnEnter = False
        Me.ValorCred.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorCred.Location = New System.Drawing.Point(165, 196)
        Me.ValorCred.MaxLength = 10
        Me.ValorCred.Name = "ValorCred"
        Me.ValorCred.PreencherZeroEsqueda = False
        Me.ValorCred.RegraValidação = Nothing
        Me.ValorCred.RegraValidaçãoMensagem = Nothing
        Me.ValorCred.Size = New System.Drawing.Size(129, 23)
        Me.ValorCred.TabIndex = 13
        Me.ValorCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorCred.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorCred.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Valor do Crédito"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btFindClientes
        '
        Me.btFindClientes.Image = CType(resources.GetObject("btFindClientes.Image"), System.Drawing.Image)
        Me.btFindClientes.Location = New System.Drawing.Point(247, 51)
        Me.btFindClientes.Name = "btFindClientes"
        Me.btFindClientes.Size = New System.Drawing.Size(20, 21)
        Me.btFindClientes.TabIndex = 4
        '
        'VencimentoCred
        '
        Me.VencimentoCred.AceitaColarTexto = True
        Me.VencimentoCred.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.VencimentoCred.CasasDecimais = 0
        Me.VencimentoCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VencimentoCred.CPObrigatorio = False
        Me.VencimentoCred.CPObrigatorioMsg = Nothing
        Me.VencimentoCred.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.VencimentoCred.FlatBorder = False
        Me.VencimentoCred.FlatBorderColor = System.Drawing.Color.DimGray
        Me.VencimentoCred.FocusColor = System.Drawing.Color.MistyRose
        Me.VencimentoCred.FocusColorEnd = System.Drawing.Color.Empty
        Me.VencimentoCred.HighlightBorderOnEnter = False
        Me.VencimentoCred.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.VencimentoCred.Location = New System.Drawing.Point(165, 167)
        Me.VencimentoCred.MaxLength = 10
        Me.VencimentoCred.Name = "VencimentoCred"
        Me.VencimentoCred.PreencherZeroEsqueda = False
        Me.VencimentoCred.RegraValidação = Nothing
        Me.VencimentoCred.RegraValidaçãoMensagem = Nothing
        Me.VencimentoCred.Size = New System.Drawing.Size(129, 23)
        Me.VencimentoCred.TabIndex = 11
        Me.VencimentoCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VencimentoCred.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.VencimentoCred.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Vencimento do Crédito"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataCred
        '
        Me.DataCred.AceitaColarTexto = True
        Me.DataCred.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataCred.CasasDecimais = 0
        Me.DataCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataCred.CPObrigatorio = False
        Me.DataCred.CPObrigatorioMsg = Nothing
        Me.DataCred.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataCred.FlatBorder = False
        Me.DataCred.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataCred.FocusColor = System.Drawing.Color.MistyRose
        Me.DataCred.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataCred.HighlightBorderOnEnter = False
        Me.DataCred.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataCred.Location = New System.Drawing.Point(165, 138)
        Me.DataCred.MaxLength = 10
        Me.DataCred.Name = "DataCred"
        Me.DataCred.PreencherZeroEsqueda = False
        Me.DataCred.RegraValidação = Nothing
        Me.DataCred.RegraValidaçãoMensagem = Nothing
        Me.DataCred.Size = New System.Drawing.Size(129, 23)
        Me.DataCred.TabIndex = 9
        Me.DataCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataCred.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataCred.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data do Crédito"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescCred
        '
        Me.DescCred.AceitaColarTexto = True
        Me.DescCred.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DescCred.CasasDecimais = 0
        Me.DescCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescCred.CPObrigatorio = False
        Me.DescCred.CPObrigatorioMsg = Nothing
        Me.DescCred.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DescCred.FlatBorder = False
        Me.DescCred.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DescCred.FocusColor = System.Drawing.Color.MistyRose
        Me.DescCred.FocusColorEnd = System.Drawing.Color.Empty
        Me.DescCred.HighlightBorderOnEnter = False
        Me.DescCred.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DescCred.Location = New System.Drawing.Point(165, 80)
        Me.DescCred.MaxLength = 200
        Me.DescCred.Multiline = True
        Me.DescCred.Name = "DescCred"
        Me.DescCred.PreencherZeroEsqueda = False
        Me.DescCred.RegraValidação = Nothing
        Me.DescCred.RegraValidaçãoMensagem = Nothing
        Me.DescCred.Size = New System.Drawing.Size(465, 52)
        Me.DescCred.TabIndex = 7
        Me.DescCred.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DescCred.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descrição do Crédito"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClienteDesc
        '
        Me.ClienteDesc.AceitaColarTexto = True
        Me.ClienteDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ClienteDesc.CasasDecimais = 0
        Me.ClienteDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClienteDesc.CPObrigatorio = False
        Me.ClienteDesc.CPObrigatorioMsg = Nothing
        Me.ClienteDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ClienteDesc.FlatBorder = False
        Me.ClienteDesc.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.FocusColor = System.Drawing.Color.MistyRose
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(270, 51)
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(360, 23)
        Me.ClienteDesc.TabIndex = 5
        Me.ClienteDesc.TabStop = False
        Me.ClienteDesc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.ClienteDesc.ValorPadrao = Nothing
        '
        'Cliente
        '
        Me.Cliente.AceitaColarTexto = True
        Me.Cliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cliente.CasasDecimais = 0
        Me.Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cliente.CPObrigatorio = False
        Me.Cliente.CPObrigatorioMsg = Nothing
        Me.Cliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cliente.FlatBorder = False
        Me.Cliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cliente.FocusColor = System.Drawing.Color.MistyRose
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(165, 51)
        Me.Cliente.MaxLength = 15
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(82, 23)
        Me.Cliente.TabIndex = 3
        Me.Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.Enabled = False
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(165, 22)
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(82, 23)
        Me.Id.TabIndex = 1
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ClientesCred
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Name = "ClientesCred"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançamentos de Créditos para Clientes - T079"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents VencimentoCred As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataCred As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DescCred As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btFindClientes As System.Windows.Forms.Label
    Friend WithEvents ValorCred As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Confirmado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btLocalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Inativo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents DisplayConfirmado As System.Windows.Forms.Label
    Friend WithEvents DisplayCancelado As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
