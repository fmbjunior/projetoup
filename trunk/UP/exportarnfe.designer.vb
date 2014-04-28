<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportarNFE
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
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtFechar = New DevComponents.DotNetBar.ButtonX()
        Me.BtGerar = New DevComponents.DotNetBar.ButtonX()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.opt4 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.Fundo.SuspendLayout()
        Me.grpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.BtFechar)
        Me.Fundo.Controls.Add(Me.BtGerar)
        Me.Fundo.Controls.Add(Me.grpBox)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(576, 247)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "O arquivo será gerado na pasta C:\Up\Xml"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Produtos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(560, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Produtos tem que ter valor de venda, descrição do produto , unidade medida, NCM e" & _
    " os impostos para ser exportado."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Clientes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente tem que ter CPF ou CNPJ, Inscrição, Nome, Endereço, Número, Cidade e Pais" & _
    " para ser exportado."
        '
        'BtFechar
        '
        Me.BtFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtFechar.Location = New System.Drawing.Point(409, 211)
        Me.BtFechar.Name = "BtFechar"
        Me.BtFechar.Size = New System.Drawing.Size(74, 28)
        Me.BtFechar.TabIndex = 1
        Me.BtFechar.Text = "Fechar"
        '
        'BtGerar
        '
        Me.BtGerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtGerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtGerar.Location = New System.Drawing.Point(319, 211)
        Me.BtGerar.Name = "BtGerar"
        Me.BtGerar.Size = New System.Drawing.Size(74, 28)
        Me.BtGerar.TabIndex = 0
        Me.BtGerar.Text = "Gerar XML"
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.lblCodigo)
        Me.grpBox.Controls.Add(Me.txtCodigo)
        Me.grpBox.Controls.Add(Me.opt4)
        Me.grpBox.Controls.Add(Me.opt2)
        Me.grpBox.Controls.Add(Me.opt3)
        Me.grpBox.Controls.Add(Me.opt1)
        Me.grpBox.Location = New System.Drawing.Point(12, 116)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(301, 123)
        Me.grpBox.TabIndex = 1
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Opções para gerar XML"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(211, 76)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(78, 13)
        Me.lblCodigo.TabIndex = 4
        Me.lblCodigo.Text = "Digite o código"
        Me.lblCodigo.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.AceitaColarTexto = True
        Me.txtCodigo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtCodigo.CasasDecimais = 2
        Me.txtCodigo.CPObrigatorio = False
        Me.txtCodigo.CPObrigatorioMsg = Nothing
        Me.txtCodigo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtCodigo.FlatBorder = False
        Me.txtCodigo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtCodigo.FocusColor = System.Drawing.Color.Empty
        Me.txtCodigo.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtCodigo.HighlightBorderOnEnter = False
        Me.txtCodigo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtCodigo.Location = New System.Drawing.Point(211, 95)
        Me.txtCodigo.MaxLength = 8
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PreencherZeroEsqueda = False
        Me.txtCodigo.RegraValidação = Nothing
        Me.txtCodigo.RegraValidaçãoMensagem = Nothing
        Me.txtCodigo.Size = New System.Drawing.Size(81, 20)
        Me.txtCodigo.TabIndex = 5
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtCodigo.ValorPadrao = Nothing
        Me.txtCodigo.Visible = False
        '
        'opt4
        '
        Me.opt4.AutoSize = True
        Me.opt4.Location = New System.Drawing.Point(13, 98)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(135, 17)
        Me.opt4.TabIndex = 3
        Me.opt4.Text = "XML Produto Individual"
        Me.opt4.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(13, 72)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(126, 17)
        Me.opt2.TabIndex = 2
        Me.opt2.Text = "XML Produto [Todos]"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(12, 47)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(135, 17)
        Me.opt3.TabIndex = 1
        Me.opt3.Text = "XML Clientes Individual"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(12, 24)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(126, 17)
        Me.opt1.TabIndex = 0
        Me.opt1.Text = "XML Clientes [Todos]"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'ExportarNFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ExportarNFE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ExportarNFE - T054"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents BtFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtGerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents opt4 As System.Windows.Forms.RadioButton
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
