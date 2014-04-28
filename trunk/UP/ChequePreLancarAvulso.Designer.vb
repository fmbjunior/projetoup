<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChequePreLancarAvulso
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Vencimento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ValorCh = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EntreguePor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Titular = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CC = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Cheque = New TexBoxFocusNet.TextBoxFocusNet()
        Me.IdCodigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.ClienteDesc = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Cliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.btNovo = New DevComponents.DotNetBar.ButtonX()
        Me.btFechar = New DevComponents.DotNetBar.ButtonX()
        Me.BancoCheque = New CBOAutoCompleteFocus.CboFocus()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Vencimento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vencimento
        '
        Me.Vencimento.AceitaColarTexto = True
        Me.Vencimento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Vencimento.CasasDecimais = 0
        Me.Vencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Vencimento.CPObrigatorio = False
        Me.Vencimento.CPObrigatorioMsg = Nothing
        Me.Vencimento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Vencimento.FlatBorder = False
        Me.Vencimento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Vencimento.FocusColor = System.Drawing.Color.Empty
        Me.Vencimento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Vencimento.HighlightBorderOnEnter = False
        Me.Vencimento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Vencimento.Location = New System.Drawing.Point(120, 191)
        Me.Vencimento.MaxLength = 10
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.PreencherZeroEsqueda = False
        Me.Vencimento.RegraValidação = Nothing
        Me.Vencimento.RegraValidaçãoMensagem = Nothing
        Me.Vencimento.Size = New System.Drawing.Size(116, 23)
        Me.Vencimento.TabIndex = 16
        Me.Vencimento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.Vencimento.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Vlr. Cheque"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorCh
        '
        Me.ValorCh.AceitaColarTexto = True
        Me.ValorCh.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorCh.CasasDecimais = 3
        Me.ValorCh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValorCh.CPObrigatorio = False
        Me.ValorCh.CPObrigatorioMsg = Nothing
        Me.ValorCh.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.ValorCh.FlatBorder = False
        Me.ValorCh.FlatBorderColor = System.Drawing.Color.DimGray
        Me.ValorCh.FocusColor = System.Drawing.Color.Empty
        Me.ValorCh.FocusColorEnd = System.Drawing.Color.Empty
        Me.ValorCh.HighlightBorderOnEnter = False
        Me.ValorCh.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ValorCh.Location = New System.Drawing.Point(120, 162)
        Me.ValorCh.MaxLength = 10
        Me.ValorCh.Name = "ValorCh"
        Me.ValorCh.PreencherZeroEsqueda = False
        Me.ValorCh.RegraValidação = Nothing
        Me.ValorCh.RegraValidaçãoMensagem = Nothing
        Me.ValorCh.Size = New System.Drawing.Size(116, 23)
        Me.ValorCh.TabIndex = 14
        Me.ValorCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorCh.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.ValorCh.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Entregue Por"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EntreguePor
        '
        Me.EntreguePor.AceitaColarTexto = True
        Me.EntreguePor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EntreguePor.CasasDecimais = 0
        Me.EntreguePor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EntreguePor.CPObrigatorio = False
        Me.EntreguePor.CPObrigatorioMsg = Nothing
        Me.EntreguePor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EntreguePor.FlatBorder = False
        Me.EntreguePor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EntreguePor.FocusColor = System.Drawing.Color.Empty
        Me.EntreguePor.FocusColorEnd = System.Drawing.Color.Empty
        Me.EntreguePor.HighlightBorderOnEnter = False
        Me.EntreguePor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.EntreguePor.Location = New System.Drawing.Point(120, 133)
        Me.EntreguePor.MaxLength = 50
        Me.EntreguePor.Name = "EntreguePor"
        Me.EntreguePor.PreencherZeroEsqueda = False
        Me.EntreguePor.RegraValidação = Nothing
        Me.EntreguePor.RegraValidaçãoMensagem = Nothing
        Me.EntreguePor.Size = New System.Drawing.Size(446, 23)
        Me.EntreguePor.TabIndex = 12
        Me.EntreguePor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EntreguePor.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Titular"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Titular
        '
        Me.Titular.AceitaColarTexto = True
        Me.Titular.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Titular.CasasDecimais = 0
        Me.Titular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Titular.CPObrigatorio = False
        Me.Titular.CPObrigatorioMsg = Nothing
        Me.Titular.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Titular.FlatBorder = False
        Me.Titular.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Titular.FocusColor = System.Drawing.Color.Empty
        Me.Titular.FocusColorEnd = System.Drawing.Color.Empty
        Me.Titular.HighlightBorderOnEnter = False
        Me.Titular.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Titular.Location = New System.Drawing.Point(120, 104)
        Me.Titular.MaxLength = 50
        Me.Titular.Name = "Titular"
        Me.Titular.PreencherZeroEsqueda = False
        Me.Titular.RegraValidação = Nothing
        Me.Titular.RegraValidaçãoMensagem = Nothing
        Me.Titular.Size = New System.Drawing.Size(446, 23)
        Me.Titular.TabIndex = 10
        Me.Titular.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Titular.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(342, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "C/C"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CC
        '
        Me.CC.AceitaColarTexto = True
        Me.CC.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CC.CasasDecimais = 0
        Me.CC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CC.CPObrigatorio = False
        Me.CC.CPObrigatorioMsg = Nothing
        Me.CC.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CC.FlatBorder = False
        Me.CC.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CC.FocusColor = System.Drawing.Color.Empty
        Me.CC.FocusColorEnd = System.Drawing.Color.Empty
        Me.CC.HighlightBorderOnEnter = False
        Me.CC.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CC.Location = New System.Drawing.Point(450, 10)
        Me.CC.MaxLength = 15
        Me.CC.Name = "CC"
        Me.CC.PreencherZeroEsqueda = False
        Me.CC.RegraValidação = Nothing
        Me.CC.RegraValidaçãoMensagem = Nothing
        Me.CC.Size = New System.Drawing.Size(116, 23)
        Me.CC.TabIndex = 3
        Me.CC.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CC.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cheque"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cheque
        '
        Me.Cheque.AceitaColarTexto = True
        Me.Cheque.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Cheque.CasasDecimais = 0
        Me.Cheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cheque.CPObrigatorio = False
        Me.Cheque.CPObrigatorioMsg = Nothing
        Me.Cheque.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Cheque.FlatBorder = False
        Me.Cheque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Cheque.FocusColor = System.Drawing.Color.Empty
        Me.Cheque.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cheque.HighlightBorderOnEnter = False
        Me.Cheque.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cheque.Location = New System.Drawing.Point(120, 11)
        Me.Cheque.MaxLength = 15
        Me.Cheque.Name = "Cheque"
        Me.Cheque.PreencherZeroEsqueda = False
        Me.Cheque.RegraValidação = Nothing
        Me.Cheque.RegraValidaçãoMensagem = Nothing
        Me.Cheque.Size = New System.Drawing.Size(116, 23)
        Me.Cheque.TabIndex = 1
        Me.Cheque.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cheque.ValorPadrao = Nothing
        '
        'IdCodigo
        '
        Me.IdCodigo.AceitaColarTexto = True
        Me.IdCodigo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.IdCodigo.CasasDecimais = 0
        Me.IdCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdCodigo.CPObrigatorio = False
        Me.IdCodigo.CPObrigatorioMsg = Nothing
        Me.IdCodigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.IdCodigo.FlatBorder = False
        Me.IdCodigo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.IdCodigo.FocusColor = System.Drawing.Color.Empty
        Me.IdCodigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.IdCodigo.HighlightBorderOnEnter = False
        Me.IdCodigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.IdCodigo.Location = New System.Drawing.Point(447, 191)
        Me.IdCodigo.MaxLength = 15
        Me.IdCodigo.Name = "IdCodigo"
        Me.IdCodigo.PreencherZeroEsqueda = False
        Me.IdCodigo.RegraValidação = Nothing
        Me.IdCodigo.RegraValidaçãoMensagem = Nothing
        Me.IdCodigo.Size = New System.Drawing.Size(116, 23)
        Me.IdCodigo.TabIndex = 17
        Me.IdCodigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.IdCodigo.ValorPadrao = Nothing
        Me.IdCodigo.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.ClienteDesc)
        Me.Fundo.Controls.Add(Me.Cliente)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Controls.Add(Me.btSalvar)
        Me.Fundo.Controls.Add(Me.btNovo)
        Me.Fundo.Controls.Add(Me.btFechar)
        Me.Fundo.Controls.Add(Me.BancoCheque)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Cheque)
        Me.Fundo.Controls.Add(Me.IdCodigo)
        Me.Fundo.Controls.Add(Me.Label12)
        Me.Fundo.Controls.Add(Me.CC)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Titular)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.EntreguePor)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.ValorCh)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Vencimento)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(581, 263)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
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
        Me.ClienteDesc.FocusColor = System.Drawing.Color.Empty
        Me.ClienteDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.ClienteDesc.HighlightBorderOnEnter = False
        Me.ClienteDesc.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.ClienteDesc.Location = New System.Drawing.Point(201, 69)
        Me.ClienteDesc.MaxLength = 50
        Me.ClienteDesc.Name = "ClienteDesc"
        Me.ClienteDesc.PreencherZeroEsqueda = False
        Me.ClienteDesc.RegraValidação = Nothing
        Me.ClienteDesc.RegraValidaçãoMensagem = Nothing
        Me.ClienteDesc.Size = New System.Drawing.Size(365, 23)
        Me.ClienteDesc.TabIndex = 8
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
        Me.Cliente.FocusColor = System.Drawing.Color.Empty
        Me.Cliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.Cliente.HighlightBorderOnEnter = False
        Me.Cliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Cliente.Location = New System.Drawing.Point(120, 69)
        Me.Cliente.MaxLength = 8
        Me.Cliente.Name = "Cliente"
        Me.Cliente.PreencherZeroEsqueda = False
        Me.Cliente.RegraValidação = Nothing
        Me.Cliente.RegraValidaçãoMensagem = Nothing
        Me.Cliente.Size = New System.Drawing.Size(75, 23)
        Me.Cliente.TabIndex = 7
        Me.Cliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Cliente.ValorPadrao = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btSalvar
        '
        Me.btSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSalvar.Location = New System.Drawing.Point(299, 222)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(85, 29)
        Me.btSalvar.TabIndex = 18
        Me.btSalvar.Text = "Salvar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(390, 222)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(85, 29)
        Me.btNovo.TabIndex = 19
        Me.btNovo.Text = "Novo"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(481, 222)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(85, 29)
        Me.btFechar.TabIndex = 20
        Me.btFechar.Text = "Fechar"
        '
        'BancoCheque
        '
        Me.BancoCheque.Auto_Complete = True
        Me.BancoCheque.AutoLimitar_Lista = True
        Me.BancoCheque.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.BancoCheque.CPObrigatorio = False
        Me.BancoCheque.CPObrigatorioMsg = Nothing
        Me.BancoCheque.FlatBorder = False
        Me.BancoCheque.FlatBorderColor = System.Drawing.Color.DimGray
        Me.BancoCheque.FormattingEnabled = True
        Me.BancoCheque.HighlightBorderColor = System.Drawing.Color.Empty
        Me.BancoCheque.HighlightBorderOnEnter = False
        Me.BancoCheque.Location = New System.Drawing.Point(120, 40)
        Me.BancoCheque.Name = "BancoCheque"
        Me.BancoCheque.Size = New System.Drawing.Size(446, 23)
        Me.BancoCheque.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Banco Cheque"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ChequePreLancarAvulso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(581, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChequePreLancarAvulso"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançamento de Cheque Pré Avulso - T117"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Vencimento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ValorCh As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EntreguePor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Titular As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CC As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Cheque As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents IdCodigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BancoCheque As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClienteDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Cliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
