<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerLimiteCreditoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerLimiteCreditoCliente))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.Label17 = New System.Windows.Forms.Label
        Me.SaldoLimiteCredito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label12 = New System.Windows.Forms.Label
        Me.EmDebito = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label21 = New System.Windows.Forms.Label
        Me.LimiteCredito = New TexBoxFocusNet.TextBoxFocusNet
        Me.CódigoCliente = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label1 = New System.Windows.Forms.Label
        Me.NomeCliente = New TexBoxFocusNet.TextBoxFocusNet
        Me.btClienteFind = New System.Windows.Forms.Label
        Me.UsarLimite = New System.Windows.Forms.CheckBox
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.btNovo = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btNovo)
        Me.PanelEx1.Controls.Add(Me.btFechar)
        Me.PanelEx1.Controls.Add(Me.UsarLimite)
        Me.PanelEx1.Controls.Add(Me.CódigoCliente)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.NomeCliente)
        Me.PanelEx1.Controls.Add(Me.btClienteFind)
        Me.PanelEx1.Controls.Add(Me.Label17)
        Me.PanelEx1.Controls.Add(Me.SaldoLimiteCredito)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.EmDebito)
        Me.PanelEx1.Controls.Add(Me.Label21)
        Me.PanelEx1.Controls.Add(Me.LimiteCredito)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(549, 206)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(15, 163)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 23)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Saldo de Crédito"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaldoLimiteCredito
        '
        Me.SaldoLimiteCredito.AceitaColarTexto = True
        Me.SaldoLimiteCredito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.SaldoLimiteCredito.CasasDecimais = 2
        Me.SaldoLimiteCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SaldoLimiteCredito.CPObrigatorio = False
        Me.SaldoLimiteCredito.CPObrigatorioMsg = Nothing
        Me.SaldoLimiteCredito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.SaldoLimiteCredito.FlatBorder = False
        Me.SaldoLimiteCredito.FlatBorderColor = System.Drawing.Color.DimGray
        Me.SaldoLimiteCredito.FocusColor = System.Drawing.Color.MistyRose
        Me.SaldoLimiteCredito.FocusColorEnd = System.Drawing.Color.Empty
        Me.SaldoLimiteCredito.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoLimiteCredito.HighlightBorderOnEnter = False
        Me.SaldoLimiteCredito.Location = New System.Drawing.Point(132, 164)
        Me.SaldoLimiteCredito.MaxLength = 10
        Me.SaldoLimiteCredito.Name = "SaldoLimiteCredito"
        Me.SaldoLimiteCredito.PreencherZeroEsqueda = False
        Me.SaldoLimiteCredito.RegraValidação = Nothing
        Me.SaldoLimiteCredito.RegraValidaçãoMensagem = Nothing
        Me.SaldoLimiteCredito.ShortcutsEnabled = False
        Me.SaldoLimiteCredito.Size = New System.Drawing.Size(109, 23)
        Me.SaldoLimiteCredito.TabIndex = 10
        Me.SaldoLimiteCredito.TabStop = False
        Me.SaldoLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SaldoLimiteCredito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.SaldoLimiteCredito.ValorPadrao = Nothing
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(15, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 23)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Em Débito"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmDebito
        '
        Me.EmDebito.AceitaColarTexto = True
        Me.EmDebito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EmDebito.CasasDecimais = 2
        Me.EmDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmDebito.CPObrigatorio = False
        Me.EmDebito.CPObrigatorioMsg = Nothing
        Me.EmDebito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.EmDebito.FlatBorder = False
        Me.EmDebito.FlatBorderColor = System.Drawing.Color.DimGray
        Me.EmDebito.FocusColor = System.Drawing.Color.MistyRose
        Me.EmDebito.FocusColorEnd = System.Drawing.Color.Empty
        Me.EmDebito.HighlightBorderOnEnter = False
        Me.EmDebito.Location = New System.Drawing.Point(132, 135)
        Me.EmDebito.MaxLength = 10
        Me.EmDebito.Name = "EmDebito"
        Me.EmDebito.PreencherZeroEsqueda = False
        Me.EmDebito.RegraValidação = Nothing
        Me.EmDebito.RegraValidaçãoMensagem = Nothing
        Me.EmDebito.ShortcutsEnabled = False
        Me.EmDebito.Size = New System.Drawing.Size(109, 23)
        Me.EmDebito.TabIndex = 8
        Me.EmDebito.TabStop = False
        Me.EmDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EmDebito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.EmDebito.ValorPadrao = Nothing
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(15, 105)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 23)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Limite de Crédito"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LimiteCredito
        '
        Me.LimiteCredito.AceitaColarTexto = True
        Me.LimiteCredito.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.LimiteCredito.CasasDecimais = 2
        Me.LimiteCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LimiteCredito.CPObrigatorio = False
        Me.LimiteCredito.CPObrigatorioMsg = Nothing
        Me.LimiteCredito.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.LimiteCredito.FlatBorder = False
        Me.LimiteCredito.FlatBorderColor = System.Drawing.Color.DimGray
        Me.LimiteCredito.FocusColor = System.Drawing.Color.MistyRose
        Me.LimiteCredito.FocusColorEnd = System.Drawing.Color.Empty
        Me.LimiteCredito.HighlightBorderOnEnter = False
        Me.LimiteCredito.Location = New System.Drawing.Point(132, 106)
        Me.LimiteCredito.MaxLength = 10
        Me.LimiteCredito.Name = "LimiteCredito"
        Me.LimiteCredito.PreencherZeroEsqueda = False
        Me.LimiteCredito.RegraValidação = Nothing
        Me.LimiteCredito.RegraValidaçãoMensagem = Nothing
        Me.LimiteCredito.ShortcutsEnabled = False
        Me.LimiteCredito.Size = New System.Drawing.Size(109, 23)
        Me.LimiteCredito.TabIndex = 6
        Me.LimiteCredito.TabStop = False
        Me.LimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LimiteCredito.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.LimiteCredito.ValorPadrao = Nothing
        '
        'CódigoCliente
        '
        Me.CódigoCliente.AceitaColarTexto = True
        Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CódigoCliente.CasasDecimais = 0
        Me.CódigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CódigoCliente.CPObrigatorio = False
        Me.CódigoCliente.CPObrigatorioMsg = Nothing
        Me.CódigoCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CódigoCliente.FlatBorder = False
        Me.CódigoCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CódigoCliente.FocusColor = System.Drawing.Color.MistyRose
        Me.CódigoCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.CódigoCliente.HighlightBorderOnEnter = False
        Me.CódigoCliente.Location = New System.Drawing.Point(132, 21)
        Me.CódigoCliente.Name = "CódigoCliente"
        Me.CódigoCliente.PreencherZeroEsqueda = False
        Me.CódigoCliente.RegraValidação = Nothing
        Me.CódigoCliente.RegraValidaçãoMensagem = Nothing
        Me.CódigoCliente.ShortcutsEnabled = False
        Me.CódigoCliente.Size = New System.Drawing.Size(86, 23)
        Me.CódigoCliente.TabIndex = 2
        Me.CódigoCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CódigoCliente.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cód. Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeCliente
        '
        Me.NomeCliente.AceitaColarTexto = True
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeCliente.CasasDecimais = 0
        Me.NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeCliente.CPObrigatorio = False
        Me.NomeCliente.CPObrigatorioMsg = Nothing
        Me.NomeCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeCliente.FlatBorder = False
        Me.NomeCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeCliente.FocusColor = System.Drawing.Color.MistyRose
        Me.NomeCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeCliente.HighlightBorderOnEnter = False
        Me.NomeCliente.Location = New System.Drawing.Point(133, 50)
        Me.NomeCliente.MaxLength = 50
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.PreencherZeroEsqueda = False
        Me.NomeCliente.RegraValidação = Nothing
        Me.NomeCliente.RegraValidaçãoMensagem = Nothing
        Me.NomeCliente.ShortcutsEnabled = False
        Me.NomeCliente.Size = New System.Drawing.Size(407, 23)
        Me.NomeCliente.TabIndex = 4
        Me.NomeCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeCliente.ValorPadrao = Nothing
        '
        'btClienteFind
        '
        Me.btClienteFind.BackColor = System.Drawing.Color.Transparent
        Me.btClienteFind.Image = CType(resources.GetObject("btClienteFind.Image"), System.Drawing.Image)
        Me.btClienteFind.Location = New System.Drawing.Point(219, 20)
        Me.btClienteFind.Name = "btClienteFind"
        Me.btClienteFind.Size = New System.Drawing.Size(23, 23)
        Me.btClienteFind.TabIndex = 3
        '
        'UsarLimite
        '
        Me.UsarLimite.AutoSize = True
        Me.UsarLimite.BackColor = System.Drawing.Color.Transparent
        Me.UsarLimite.Enabled = False
        Me.UsarLimite.Location = New System.Drawing.Point(247, 167)
        Me.UsarLimite.Name = "UsarLimite"
        Me.UsarLimite.Size = New System.Drawing.Size(85, 19)
        Me.UsarLimite.TabIndex = 0
        Me.UsarLimite.Text = "Usar Limite"
        Me.UsarLimite.UseVisualStyleBackColor = False
        Me.UsarLimite.Visible = False
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(467, 172)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(70, 22)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 11
        Me.btFechar.Text = "Fechar"
        '
        'btNovo
        '
        Me.btNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNovo.Location = New System.Drawing.Point(391, 172)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(70, 22)
        Me.btNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNovo.TabIndex = 12
        Me.btNovo.Text = "Novo"
        '
        'VerLimiteCreditoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "VerLimiteCreditoCliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver limíte de Crédito do Cliente"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SaldoLimiteCredito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents EmDebito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LimiteCredito As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CódigoCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NomeCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btClienteFind As System.Windows.Forms.Label
    Friend WithEvents UsarLimite As System.Windows.Forms.CheckBox
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNovo As DevComponents.DotNetBar.ButtonX
End Class
