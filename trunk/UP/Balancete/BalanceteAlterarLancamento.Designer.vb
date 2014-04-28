<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceteAlterarLancamento
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotReg = New System.Windows.Forms.Label()
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX()
        Me.DataInicial = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataFinal = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.ListaProcura = New System.Windows.Forms.DataGridView()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContaBalancete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContaCR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDataLancamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VlDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Local = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cHistorico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ListaProcura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.TotReg)
        Me.PanelEx1.Controls.Add(Me.btAtualizar)
        Me.PanelEx1.Controls.Add(Me.DataInicial)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.DataFinal)
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Controls.Add(Me.ListaProcura)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1023, 515)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(264, 475)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "* Selecione Ct Balancete ou Conta Cr na lista  e pressione F5 para pesquisar a co" & _
    "nta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotReg
        '
        Me.TotReg.BackColor = System.Drawing.Color.Transparent
        Me.TotReg.Location = New System.Drawing.Point(12, 475)
        Me.TotReg.Name = "TotReg"
        Me.TotReg.Size = New System.Drawing.Size(215, 19)
        Me.TotReg.TabIndex = 10
        Me.TotReg.Text = "Total de Registros...: 0"
        Me.TotReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Location = New System.Drawing.Point(777, 487)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(119, 25)
        Me.btAtualizar.TabIndex = 9
        Me.btAtualizar.Text = "Atualizar Dados"
        '
        'DataInicial
        '
        Me.DataInicial.AceitaColarTexto = True
        Me.DataInicial.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataInicial.CasasDecimais = 0
        Me.DataInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataInicial.CPObrigatorio = False
        Me.DataInicial.CPObrigatorioMsg = Nothing
        Me.DataInicial.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataInicial.FlatBorder = False
        Me.DataInicial.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataInicial.FocusColor = System.Drawing.Color.Empty
        Me.DataInicial.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataInicial.HighlightBorderOnEnter = False
        Me.DataInicial.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataInicial.Location = New System.Drawing.Point(233, 12)
        Me.DataInicial.MaxLength = 10
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.PreencherZeroEsqueda = False
        Me.DataInicial.RegraValidação = Nothing
        Me.DataInicial.RegraValidaçãoMensagem = Nothing
        Me.DataInicial.Size = New System.Drawing.Size(101, 23)
        Me.DataInicial.TabIndex = 7
        Me.DataInicial.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataInicial.ValorPadrao = Nothing
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(12, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Informe o Período de Lançamentos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataFinal
        '
        Me.DataFinal.AceitaColarTexto = True
        Me.DataFinal.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataFinal.CasasDecimais = 0
        Me.DataFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataFinal.CPObrigatorio = False
        Me.DataFinal.CPObrigatorioMsg = Nothing
        Me.DataFinal.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataFinal.FlatBorder = False
        Me.DataFinal.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataFinal.FocusColor = System.Drawing.Color.Empty
        Me.DataFinal.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataFinal.HighlightBorderOnEnter = False
        Me.DataFinal.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataFinal.Location = New System.Drawing.Point(340, 12)
        Me.DataFinal.MaxLength = 10
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.PreencherZeroEsqueda = False
        Me.DataFinal.RegraValidação = Nothing
        Me.DataFinal.RegraValidaçãoMensagem = Nothing
        Me.DataFinal.Size = New System.Drawing.Size(101, 23)
        Me.DataFinal.TabIndex = 8
        Me.DataFinal.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataFinal.ValorPadrao = Nothing
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(902, 487)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(92, 25)
        Me.Fechar.TabIndex = 5
        Me.Fechar.Text = "Fechar"
        '
        'ListaProcura
        '
        Me.ListaProcura.AllowUserToAddRows = False
        Me.ListaProcura.AllowUserToDeleteRows = False
        Me.ListaProcura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaProcura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cContaBalancete, Me.cContaCR, Me.cDataLancamento, Me.cDocumento, Me.VlDocumento, Me.Local, Me.cHistorico})
        Me.ListaProcura.Location = New System.Drawing.Point(12, 41)
        Me.ListaProcura.Name = "ListaProcura"
        Me.ListaProcura.Size = New System.Drawing.Size(999, 431)
        Me.ListaProcura.TabIndex = 0
        '
        'cId
        '
        Me.cId.DataPropertyName = "Id"
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Width = 70
        '
        'cContaBalancete
        '
        Me.cContaBalancete.DataPropertyName = "ContaBalancete"
        Me.cContaBalancete.HeaderText = "Ct Balancete"
        Me.cContaBalancete.Name = "cContaBalancete"
        '
        'cContaCR
        '
        Me.cContaCR.DataPropertyName = "ContaCR"
        Me.cContaCR.HeaderText = "Conta CR"
        Me.cContaCR.Name = "cContaCR"
        '
        'cDataLancamento
        '
        Me.cDataLancamento.DataPropertyName = "DataLancamento"
        Me.cDataLancamento.HeaderText = "Data Lanc"
        Me.cDataLancamento.Name = "cDataLancamento"
        Me.cDataLancamento.ReadOnly = True
        '
        'cDocumento
        '
        Me.cDocumento.DataPropertyName = "Documento"
        Me.cDocumento.HeaderText = "Documento"
        Me.cDocumento.Name = "cDocumento"
        Me.cDocumento.ReadOnly = True
        '
        'VlDocumento
        '
        Me.VlDocumento.DataPropertyName = "ValorDocumento"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.VlDocumento.DefaultCellStyle = DataGridViewCellStyle1
        Me.VlDocumento.HeaderText = "Vl. Doc"
        Me.VlDocumento.Name = "VlDocumento"
        '
        'Local
        '
        Me.Local.DataPropertyName = "PrgLancamento"
        Me.Local.HeaderText = "Origem"
        Me.Local.Name = "Local"
        '
        'cHistorico
        '
        Me.cHistorico.DataPropertyName = "Historico"
        Me.cHistorico.HeaderText = "Historico"
        Me.cHistorico.Name = "cHistorico"
        Me.cHistorico.ReadOnly = True
        Me.cHistorico.Width = 350
        '
        'BalanceteAlterarLancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "BalanceteAlterarLancamento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar lançamento de  balancete - T270"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.ListaProcura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ListaProcura As System.Windows.Forms.DataGridView
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataInicial As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataFinal As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TotReg As System.Windows.Forms.Label
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaBalancete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContaCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDataLancamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VlDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Local As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cHistorico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
