<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstoqueFabrica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstoqueFabrica))
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColId = New System.Windows.Forms.ColumnHeader
        Me.ColDesc = New System.Windows.Forms.ColumnHeader
        Me.ColPatio = New System.Windows.Forms.ColumnHeader
        Me.ColEmpresa = New System.Windows.Forms.ColumnHeader
        Me.ColControlada = New System.Windows.Forms.ColumnHeader
        Me.Patio = New TexBoxFocusNet.TextBoxFocusNet
        Me.Empresa = New TexBoxFocusNet.TextBoxFocusNet
        Me.Controlada = New TexBoxFocusNet.TextBoxFocusNet
        Me.Curando = New TexBoxFocusNet.TextBoxFocusNet
        Me.Curado = New TexBoxFocusNet.TextBoxFocusNet
        Me.MyListaCura = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Fechar = New DevComponents.DotNetBar.ButtonX
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColDesc, Me.ColPatio, Me.ColEmpresa, Me.ColControlada})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(3, 3)
        Me.MyLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(291, 518)
        Me.MyLista.TabIndex = 61
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Código"
        Me.ColId.Width = 50
        '
        'ColDesc
        '
        Me.ColDesc.Text = "Descrição"
        Me.ColDesc.Width = 215
        '
        'ColPatio
        '
        Me.ColPatio.Text = "Patio"
        Me.ColPatio.Width = 0
        '
        'ColEmpresa
        '
        Me.ColEmpresa.Text = "Empresa"
        Me.ColEmpresa.Width = 0
        '
        'ColControlada
        '
        Me.ColControlada.Text = "Controlada"
        Me.ColControlada.Width = 0
        '
        'Patio
        '
        Me.Patio.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Patio.CasasDecimais = 0
        Me.Patio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Patio.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Patio.FocusColor = System.Drawing.Color.Empty
        Me.Patio.FocusColorEnd = System.Drawing.Color.Empty
        Me.Patio.Location = New System.Drawing.Point(297, 31)
        Me.Patio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Patio.MaxLength = 10
        Me.Patio.Name = "Patio"
        Me.Patio.RegraValidação = Nothing
        Me.Patio.Size = New System.Drawing.Size(69, 20)
        Me.Patio.TabIndex = 62
        Me.Patio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Patio.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Patio.ValorPadrao = Nothing
        '
        'Empresa
        '
        Me.Empresa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Empresa.CasasDecimais = 0
        Me.Empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Empresa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Empresa.FocusColor = System.Drawing.Color.Empty
        Me.Empresa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Empresa.Location = New System.Drawing.Point(367, 31)
        Me.Empresa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Empresa.MaxLength = 10
        Me.Empresa.Name = "Empresa"
        Me.Empresa.RegraValidação = Nothing
        Me.Empresa.Size = New System.Drawing.Size(69, 20)
        Me.Empresa.TabIndex = 63
        Me.Empresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Empresa.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Empresa.ValorPadrao = Nothing
        '
        'Controlada
        '
        Me.Controlada.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Controlada.CasasDecimais = 0
        Me.Controlada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Controlada.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Controlada.FocusColor = System.Drawing.Color.Empty
        Me.Controlada.FocusColorEnd = System.Drawing.Color.Empty
        Me.Controlada.Location = New System.Drawing.Point(438, 31)
        Me.Controlada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Controlada.MaxLength = 10
        Me.Controlada.Name = "Controlada"
        Me.Controlada.RegraValidação = Nothing
        Me.Controlada.Size = New System.Drawing.Size(69, 20)
        Me.Controlada.TabIndex = 64
        Me.Controlada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Controlada.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Controlada.ValorPadrao = Nothing
        '
        'Curando
        '
        Me.Curando.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Curando.CasasDecimais = 0
        Me.Curando.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Curando.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Curando.FocusColor = System.Drawing.Color.Empty
        Me.Curando.FocusColorEnd = System.Drawing.Color.Empty
        Me.Curando.Location = New System.Drawing.Point(508, 31)
        Me.Curando.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Curando.MaxLength = 10
        Me.Curando.Name = "Curando"
        Me.Curando.RegraValidação = Nothing
        Me.Curando.Size = New System.Drawing.Size(69, 20)
        Me.Curando.TabIndex = 65
        Me.Curando.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Curando.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Curando.ValorPadrao = Nothing
        '
        'Curado
        '
        Me.Curado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Curado.CasasDecimais = 0
        Me.Curado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Curado.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Curado.FocusColor = System.Drawing.Color.Empty
        Me.Curado.FocusColorEnd = System.Drawing.Color.Empty
        Me.Curado.Location = New System.Drawing.Point(578, 31)
        Me.Curado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Curado.MaxLength = 10
        Me.Curado.Name = "Curado"
        Me.Curado.RegraValidação = Nothing
        Me.Curado.Size = New System.Drawing.Size(69, 20)
        Me.Curado.TabIndex = 66
        Me.Curado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Curado.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Curado.ValorPadrao = Nothing
        '
        'MyListaCura
        '
        Me.MyListaCura.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.MyListaCura.FullRowSelect = True
        Me.MyListaCura.GridLines = True
        Me.MyListaCura.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyListaCura.Location = New System.Drawing.Point(300, 63)
        Me.MyListaCura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyListaCura.MultiSelect = False
        Me.MyListaCura.Name = "MyListaCura"
        Me.MyListaCura.Size = New System.Drawing.Size(347, 413)
        Me.MyListaCura.TabIndex = 67
        Me.MyListaCura.UseCompatibleStateImageBehavior = False
        Me.MyListaCura.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Qtd Curando"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Data da Produção"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Dias Restante"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 110
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(297, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Pátio"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(367, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(438, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Controlada"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(508, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Curando"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(578, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Curado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Id
        '
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(326, 501)
        Me.Id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.RegraValidação = Nothing
        Me.Id.Size = New System.Drawing.Size(69, 20)
        Me.Id.TabIndex = 74
        Me.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Id.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Patio)
        Me.Fundo.Controls.Add(Me.Empresa)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Controlada)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Curando)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Curado)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.MyListaCura)
        Me.Fundo.Controls.Add(Me.Label7)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(661, 537)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 75
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.Location = New System.Drawing.Point(552, 480)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(95, 49)
        Me.Fechar.TabIndex = 75
        Me.Fechar.Text = "Fechar"
        '
        'EstoqueFabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EstoqueFabrica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque da Fabrica"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Patio As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Empresa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Controlada As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Curando As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Curado As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents MyListaCura As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColPatio As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColEmpresa As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColControlada As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
End Class
