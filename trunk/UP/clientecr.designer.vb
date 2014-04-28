<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteCr
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
        Me.MyLista = New System.Windows.Forms.ListView()
        Me.ColId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDoc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColOcorrencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColIdProcura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPrg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataOcorrencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Ocorrencia = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Documento = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.BtSalvar = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColCliente, Me.ColData, Me.ColDoc, Me.ColOcorrencia, Me.ColIdProcura, Me.ColPrg})
        Me.MyLista.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(12, 37)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(613, 393)
        Me.MyLista.TabIndex = 4
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 0
        '
        'ColCliente
        '
        Me.ColCliente.Text = "Cliente"
        Me.ColCliente.Width = 0
        '
        'ColData
        '
        Me.ColData.Text = "Data"
        Me.ColData.Width = 75
        '
        'ColDoc
        '
        Me.ColDoc.Text = "Documento"
        Me.ColDoc.Width = 70
        '
        'ColOcorrencia
        '
        Me.ColOcorrencia.Text = "Ocorrência"
        Me.ColOcorrencia.Width = 430
        '
        'ColIdProcura
        '
        Me.ColIdProcura.Text = "IdProcura"
        Me.ColIdProcura.Width = 0
        '
        'ColPrg
        '
        Me.ColPrg.Text = "Prg"
        Me.ColPrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColPrg.Width = 0
        '
        'DataOcorrencia
        '
        Me.DataOcorrencia.AceitaColarTexto = True
        Me.DataOcorrencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataOcorrencia.CasasDecimais = 0
        Me.DataOcorrencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataOcorrencia.CPObrigatorio = False
        Me.DataOcorrencia.CPObrigatorioMsg = Nothing
        Me.DataOcorrencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataOcorrencia.FlatBorder = False
        Me.DataOcorrencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataOcorrencia.FocusColor = System.Drawing.Color.MistyRose
        Me.DataOcorrencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataOcorrencia.HighlightBorderOnEnter = False
        Me.DataOcorrencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataOcorrencia.Location = New System.Drawing.Point(15, 11)
        Me.DataOcorrencia.MaxLength = 10
        Me.DataOcorrencia.Name = "DataOcorrencia"
        Me.DataOcorrencia.PreencherZeroEsqueda = False
        Me.DataOcorrencia.RegraValidação = Nothing
        Me.DataOcorrencia.RegraValidaçãoMensagem = Nothing
        Me.DataOcorrencia.Size = New System.Drawing.Size(76, 20)
        Me.DataOcorrencia.TabIndex = 0
        Me.DataOcorrencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataOcorrencia.ValorPadrao = Nothing
        '
        'Ocorrencia
        '
        Me.Ocorrencia.AceitaColarTexto = True
        Me.Ocorrencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Ocorrencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ocorrencia.CasasDecimais = 0
        Me.Ocorrencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ocorrencia.CPObrigatorio = False
        Me.Ocorrencia.CPObrigatorioMsg = Nothing
        Me.Ocorrencia.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Ocorrencia.FlatBorder = False
        Me.Ocorrencia.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Ocorrencia.FocusColor = System.Drawing.Color.MistyRose
        Me.Ocorrencia.FocusColorEnd = System.Drawing.Color.Empty
        Me.Ocorrencia.HighlightBorderOnEnter = False
        Me.Ocorrencia.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Ocorrencia.Location = New System.Drawing.Point(159, 11)
        Me.Ocorrencia.MaxLength = 250
        Me.Ocorrencia.Name = "Ocorrencia"
        Me.Ocorrencia.PreencherZeroEsqueda = False
        Me.Ocorrencia.RegraValidação = Nothing
        Me.Ocorrencia.RegraValidaçãoMensagem = Nothing
        Me.Ocorrencia.Size = New System.Drawing.Size(418, 20)
        Me.Ocorrencia.TabIndex = 2
        Me.Ocorrencia.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Ocorrencia.ValorPadrao = Nothing
        '
        'Id
        '
        Me.Id.AceitaColarTexto = True
        Me.Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.CPObrigatorio = False
        Me.Id.CPObrigatorioMsg = Nothing
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FlatBorder = False
        Me.Id.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Id.FocusColor = System.Drawing.Color.MistyRose
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.HighlightBorderOnEnter = False
        Me.Id.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Id.Location = New System.Drawing.Point(12, 436)
        Me.Id.MaxLength = 50
        Me.Id.Name = "Id"
        Me.Id.PreencherZeroEsqueda = False
        Me.Id.RegraValidação = Nothing
        Me.Id.RegraValidaçãoMensagem = Nothing
        Me.Id.Size = New System.Drawing.Size(45, 20)
        Me.Id.TabIndex = 5
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'Documento
        '
        Me.Documento.AceitaColarTexto = True
        Me.Documento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Documento.CasasDecimais = 0
        Me.Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Documento.CPObrigatorio = False
        Me.Documento.CPObrigatorioMsg = Nothing
        Me.Documento.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Documento.FlatBorder = False
        Me.Documento.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Documento.FocusColor = System.Drawing.Color.MistyRose
        Me.Documento.FocusColorEnd = System.Drawing.Color.Empty
        Me.Documento.HighlightBorderOnEnter = False
        Me.Documento.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Documento.Location = New System.Drawing.Point(92, 11)
        Me.Documento.MaxLength = 15
        Me.Documento.Name = "Documento"
        Me.Documento.PreencherZeroEsqueda = False
        Me.Documento.RegraValidação = Nothing
        Me.Documento.RegraValidaçãoMensagem = Nothing
        Me.Documento.Size = New System.Drawing.Size(66, 20)
        Me.Documento.TabIndex = 1
        Me.Documento.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Documento.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.BtSalvar)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.DataOcorrencia)
        Me.Fundo.Controls.Add(Me.Documento)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Ocorrencia)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(637, 473)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.LightSkyBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'BtSalvar
        '
        Me.BtSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtSalvar.Location = New System.Drawing.Point(583, 11)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(42, 21)
        Me.BtSalvar.TabIndex = 3
        Me.BtSalvar.Text = "Salvar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(528, 436)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(97, 33)
        Me.Fechar.TabIndex = 6
        Me.Fechar.Text = "Fechar"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'ClienteCr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(637, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClienteCr"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ocorrências de Relacionamentos do Cliente - T121"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColOcorrencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColIdProcura As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPrg As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColData As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataOcorrencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Ocorrencia As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColDoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Documento As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtSalvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
