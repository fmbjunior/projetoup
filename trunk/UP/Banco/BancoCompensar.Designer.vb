<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancoCompensar
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
        Me.ColData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDoc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColHist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDataBaixa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDataPre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PainelOk = New DevComponents.DotNetBar.ButtonX()
        Me.PainelCancela = New DevComponents.DotNetBar.ButtonX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataBaixa = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Compensar = New DevComponents.DotNetBar.ButtonX()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.PainelData = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tselecionado = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PainelData.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.AllowColumnReorder = True
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColData, Me.ColDoc, Me.ColValor, Me.ColHist, Me.ColDataBaixa, Me.ColPre, Me.ColDataPre})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.Location = New System.Drawing.Point(12, 6)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(836, 502)
        Me.MyLista.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.MyLista.TabIndex = 0
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 0
        '
        'ColData
        '
        Me.ColData.Text = "Data Lanç"
        Me.ColData.Width = 80
        '
        'ColDoc
        '
        Me.ColDoc.Text = "Documento"
        Me.ColDoc.Width = 80
        '
        'ColValor
        '
        Me.ColValor.Text = "Valor"
        Me.ColValor.Width = 80
        '
        'ColHist
        '
        Me.ColHist.Text = "Historico"
        Me.ColHist.Width = 370
        '
        'ColDataBaixa
        '
        Me.ColDataBaixa.Text = "Data Baixa"
        Me.ColDataBaixa.Width = 80
        '
        'ColPre
        '
        Me.ColPre.Text = "Pré"
        Me.ColPre.Width = 40
        '
        'ColDataPre
        '
        Me.ColDataPre.Text = "Data Pré"
        Me.ColDataPre.Width = 80
        '
        'PainelOk
        '
        Me.PainelOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.PainelOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.PainelOk.Location = New System.Drawing.Point(175, 45)
        Me.PainelOk.Name = "PainelOk"
        Me.PainelOk.Size = New System.Drawing.Size(67, 23)
        Me.PainelOk.TabIndex = 2
        Me.PainelOk.Text = "OK"
        '
        'PainelCancela
        '
        Me.PainelCancela.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.PainelCancela.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.PainelCancela.Location = New System.Drawing.Point(102, 45)
        Me.PainelCancela.Name = "PainelCancela"
        Me.PainelCancela.Size = New System.Drawing.Size(67, 23)
        Me.PainelCancela.TabIndex = 3
        Me.PainelCancela.Text = "Cancelar"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Inf. a Data da Baixa"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataBaixa
        '
        Me.DataBaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataBaixa.AceitaColarTexto = True
        Me.DataBaixa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataBaixa.CasasDecimais = 0
        Me.DataBaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataBaixa.CPObrigatorio = False
        Me.DataBaixa.CPObrigatorioMsg = Nothing
        Me.DataBaixa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataBaixa.FlatBorder = False
        Me.DataBaixa.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataBaixa.FocusColor = System.Drawing.Color.Empty
        Me.DataBaixa.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataBaixa.HighlightBorderOnEnter = False
        Me.DataBaixa.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataBaixa.Location = New System.Drawing.Point(134, 9)
        Me.DataBaixa.MaxLength = 10
        Me.DataBaixa.Name = "DataBaixa"
        Me.DataBaixa.PreencherZeroEsqueda = False
        Me.DataBaixa.RegraValidação = Nothing
        Me.DataBaixa.RegraValidaçãoMensagem = Nothing
        Me.DataBaixa.Size = New System.Drawing.Size(108, 23)
        Me.DataBaixa.TabIndex = 1
        Me.DataBaixa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataBaixa.ValorPadrao = Nothing
        '
        'Compensar
        '
        Me.Compensar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Compensar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Compensar.Location = New System.Drawing.Point(674, 534)
        Me.Compensar.Name = "Compensar"
        Me.Compensar.Size = New System.Drawing.Size(84, 26)
        Me.Compensar.TabIndex = 3
        Me.Compensar.Text = "Compensar"
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(764, 534)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(84, 26)
        Me.Fechar.TabIndex = 4
        Me.Fechar.Text = "Fechar"
        '
        'PainelData
        '
        Me.PainelData.CanvasColor = System.Drawing.SystemColors.Control
        Me.PainelData.Controls.Add(Me.PainelOk)
        Me.PainelData.Controls.Add(Me.Label9)
        Me.PainelData.Controls.Add(Me.PainelCancela)
        Me.PainelData.Controls.Add(Me.DataBaixa)
        Me.PainelData.Location = New System.Drawing.Point(12, 433)
        Me.PainelData.Name = "PainelData"
        Me.PainelData.Size = New System.Drawing.Size(253, 75)
        Me.PainelData.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PainelData.Style.BackColor1.Color = System.Drawing.Color.MediumOrchid
        Me.PainelData.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PainelData.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PainelData.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PainelData.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PainelData.Style.GradientAngle = 90
        Me.PainelData.TabIndex = 1
        Me.PainelData.Visible = False
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Tselecionado)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.PainelData)
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Controls.Add(Me.MyLista)
        Me.PanelEx1.Controls.Add(Me.Compensar)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpNavigator(Me.PanelEx1, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.HelpProvider1.SetShowHelp(Me.PanelEx1, True)
        Me.PanelEx1.Size = New System.Drawing.Size(858, 565)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 5
        Me.PanelEx1.Text = "PanelEx1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 514)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Selecionado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tselecionado
        '
        Me.Tselecionado.AceitaColarTexto = True
        Me.Tselecionado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Tselecionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tselecionado.CasasDecimais = 2
        Me.Tselecionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tselecionado.CPObrigatorio = False
        Me.Tselecionado.CPObrigatorioMsg = Nothing
        Me.Tselecionado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Tselecionado.FlatBorder = True
        Me.Tselecionado.FlatBorderColor = System.Drawing.Color.Black
        Me.Tselecionado.FocusColor = System.Drawing.Color.Empty
        Me.Tselecionado.FocusColorEnd = System.Drawing.Color.Empty
        Me.Tselecionado.HighlightBorderOnEnter = False
        Me.Tselecionado.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Tselecionado.Location = New System.Drawing.Point(138, 514)
        Me.Tselecionado.MaxLength = 10
        Me.Tselecionado.Name = "Tselecionado"
        Me.Tselecionado.PreencherZeroEsqueda = False
        Me.Tselecionado.RegraValidação = Nothing
        Me.Tselecionado.RegraValidaçãoMensagem = Nothing
        Me.Tselecionado.Size = New System.Drawing.Size(160, 23)
        Me.Tselecionado.TabIndex = 10
        Me.Tselecionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Tselecionado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Moeda
        Me.Tselecionado.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 542)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Duplo Click no documento para marcar como compensado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'BancoCompensar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(858, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BancoCompensar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compensar Documentos da Conta Corrente - T096"
        Me.PainelData.ResumeLayout(False)
        Me.PainelData.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColData As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColHist As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataBaixa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents ColDataBaixa As System.Windows.Forms.ColumnHeader
    Friend WithEvents PainelOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PainelCancela As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Compensar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PainelData As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ColPre As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDataPre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tselecionado As TexBoxFocusNet.TextBoxFocusNet
End Class
